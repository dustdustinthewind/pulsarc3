// GameScene
// referenced: https://github.com/dustdustinthewind/IQoLDecompiled/blob/main/Gameplay/GameScene.cs

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AudioVisualizer;
using CodeStage.AntiCheat.ObscuredTypes;
using ExitGames.Client.Photon;
using Newtonsoft.Json;
using Steamworks;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameScene : Scene
{
	public enum GameMode
	{
		Relax,
		Normal,
		Hardcore,
		Random,
		Endless,
		Hidden
	}

	public Image hiddenImage;

	public ObscuredBool gameOver;

	public ObscuredBool isGameStarted;

	public AudioSampler asampler;

	[HideInInspector]
	public PlayerBase pbase;

	public GameObject levelCanvas;

	public GameObject levelCanvasImage;

	public GameObject gameOverCanvas;

	public GameObject messageCanvas;

	public GameObject spectatorCanvas;

	public GameObject messageAnimation;

	public GameObject resultText;

	public GameObject ingameUICanvas;

	public GameObject loadingCanvas;

	public UnityEvent OnGameOverEvent;

	[HideInInspector]
	public ObscuredString mapID;

	public bool usingCheckpoints;

	public GameMode gameMode;

	public UnityEvent OnLoaded;

	public GameObject restartCheckpointPanel;

	public GameObject restartNoCheckpointPanel;

	public GameObject spectatePanel;

	public GameObject levelInfo;

	public GameObject levelInfoContent;

	public float calculatedmaptime;

	private ObscuredBool firstFrameInit;

	private List<string> messageTextQueue;

	private List<float> messageDurationQueue;

	private string scoreString;

	private string livesOrAcc;

	private string highscore;

	private string comboString;

	private GameObject levelProgressBar;

	private Text scoreText;

	private Text hpText;

	[HideInInspector]
	public Text comboTextGO;

	private bool showHP;

	private ObscuredFloat currentMusicTime;

	// iqol renamed this to CurrentTime
	public ObscuredFloat HPAnimationTime
	{
		get => currentMusicTime;
		set
		{
			currentMusicTime = value;
			if (currentMusicTime >= 0f)
			{
				if (asampler.audioSources[0].clip)
					asampler.audioSources[0].time = currentMusicTime;
				if (asampler.audioSources[1].clip)
					asampler.audioSources[1].time = currentMusicTime;
			}
		}
	}

	// unused, seems removed in iqol
	public ObscuredFloat CurrentMusicTime
	{
		get => float.PositiveInfinity;
		set
		{
			currentMusicTime = value;
			if (currentMusicTime >= 0f)
			{
				if (asampler.audioSources[1].clip)
					asampler.audioSources[1].time = currentMusicTime;

				if (asampler.audioSources[0].clip)
					asampler.audioSources[0].time = currentMusicTime;
			}
		}
	}

	public void OnStartRound()
	{
		// stop loading, start game
		loadingCanvas.SetActive(false);
		ingameUICanvas.SetActive(true);

		// highscore
		Transform bestScoreText = ingameUICanvas.transform.FindDeepChild("BestScoreText");
		bestScoreText.GetComponent<Text>().text = highscore + ": " + pbase.lastBestScore;
		
		// remove scoring ui elements in relax
		if (gameMode == GameMode.Relax)
		{
			bestScoreText.gameObject.SetActive(false);
			scoreText.gameObject.SetActive(false);
			hpText.gameObject.SetActive(false);
			comboTextGO.gameObject.SetActive(false);
		}

		// if in multiplayer, hide chat
		if (!PhotonNetwork.offlineMode)
			Singleton<MultiplayerSystem>.Instance.HideChat();
	}

	public void Reset()
	{
		// audio volume pitch, used for game over effect
		foreach (AudioSource audioSource in asampler.audioSources)
		{
			audioSource.pitch = 1f;
			audioSource.volume = 1f;
		}

		// remove all playerbases
		PlayerBase[] array = UnityEngine.Object.FindObjectsOfType<PlayerBase>();
		for (int i = 0; i < array.Length; i++)
		{
			UnityEngine.Object.DestroyImmediate(array[i].gameObject);
		}

		// ui
		gameOverCanvas.SetActive(false);
		spectatorCanvas.SetActive(false);
		spectatePanel.SetActive(false);
		ingameUICanvas.SetActive(false);
		restartCheckpointPanel.SetActive(false);
		restartNoCheckpointPanel.SetActive(false);

		// assorted bools
		gameOver = false;
		isGameStarted = false;
		calculatedmaptime = 0f;
		asampler.isMuted = false;
		asampler.isInited = false;
		firstFrameInit = false;

		try
		{
			levelProgressBar = ingameUICanvas.transform.Find("LevelProgressBar").gameObject;
			levelProgressBar.transform.Find("Fill Area").Find("Fill").GetComponent<Image>().color = new Color(0.654902f, 0.8784314f, 0.9843137f);
			levelProgressBar.GetComponent<Slider>().value = 0f;
		}
		catch (Exception) {}

		try
		{
			scoreText = ingameUICanvas.transform.FindDeepChild("ScoreText").GetComponent<Text>();
			scoreText.text = LocalizationService.Instance.GetLocalizatedText("#score").ToUpper() + ": " + 0;
		}
		catch (Exception){}

		try
		{
			showHP = Singleton<SaveSystem>.Instance.GetBool("settings.showHP", true);
			hpText = ingameUICanvas.transform.FindDeepChild("HPText").GetComponent<Text>();
			hpText.text = string.Empty;
		}
		catch (Exception) { }

		try
		{
			comboTextGO = ingameUICanvas.transform.FindDeepChild("ComboText").GetComponent<Text>();
			comboTextGO.text = LocalizationService.Instance.GetLocalizatedText("#combo").ToUpper() + ": " + 0;
		}
		catch (Exception) { }
		
		ShowCursor(false);
	}

	// queue a banner message
	public void AddMessage(string message, float duration = 1f)
	{
		messageTextQueue.Add(message);
		messageDurationQueue.Add(duration);
	}

	public void OnExitButton()
	{
		if (PhotonNetwork.offlineMode && mapID != (ObscuredString)"original.tutorial")
			Singleton<SaveSystem>.Instance.SetBool("menu.playedsolo", true);
			
		if (pbase != null)
		{
			pbase.DeletePlayerData();
			PhotonNetwork.offlineMode = false;
		}

		GetComponent<NetworkScene>().OnExitButton(0);

		Singleton<SaveSystem>.Instance.Flush();
	}

	[CompilerGenerated]
	private bool IsLoved(RanksSystem.Map IACGDFHKCAE)
	{
		if ((ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID)
		{
			return IACGDFHKCAE.isLoved;
		}
		return false;
	}

	public bool AllPlayersFinished()
	{
		foreach (PhotonPlayer photonPlayer in PhotonNetwork.playerList)
			if (!(photonPlayer.CustomProperties["finished"] != null ? (bool)photonPlayer.CustomProperties["finished"] : false))
				return false;

		return true;
	}

	public IEnumerator UpdateSpectatingInfo()
	{
		ulong num = 0uL;
		try
		{
			num = ulong.Parse(PhotonNetwork.playerList[pbase.spectrid].NickName);
		}
		catch (Exception) { }

		Sprite sprite = null;
		CSteamID csteamID = new CSteamID(num);
		if (num != 0L)
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(csteamID));
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(csteamID));

			if ((bool)ResourcesManager.GetLoadedAvatar(csteamID))
				sprite = ResourcesManager.GetLoadedAvatar(csteamID);
		}

		GameObject spectatingInfo = GameObject.Find("SpectatingUserInfo");
		spectatingInfo.transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(csteamID);
		spectatingInfo.transform.Find("AvatarImage").GetComponent<Image>().sprite = sprite;
	}

	public void OnSpectatePrevButton()
	{
		pbase.SpectateNext(false);
		StartCoroutine(UpdateSpectatingInfo());
	}

	public void ShowGOCanvas(bool showCanvas = false)
	{
		gameOverCanvas.SetActive(showCanvas);
		spectatePanel.SetActive(!AllPlayersFinished());

		if (this.AllPlayersFinished())
		{
			// do we add reset from checkpoint button
			bool resetFromCheckPoint = pbase.isPlayerWon && pbase.CanResumeFromCheckpoint();
			restartCheckpointPanel.SetActive(resetFromCheckPoint);
			restartNoCheckpointPanel.SetActive(!resetFromCheckPoint);

			// highlights the restart button whaow
			// iqol just removes this lol
			SelectRestartButton();

			// did you win a multiplayer match?
			if (!PhotonNetwork.offlineMode && PhotonNetwork.room.PlayerCount > 1 && GetComponent<NetworkScene>().firstPlayer.player != null && GetComponent<NetworkScene>().firstPlayer.player == PhotonNetwork.player)
				Helpers.ObtainAchievement(17);
		}

		for (int i = 0; i < levelInfoContent.transform.childCount; i++)
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);

		// set up map icon on the right (i think)
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(mapID);
		
		GameObject mapIcon = Singleton<MapsSystem>.Instance.AddDownloadedLevelItemToList(levelInfo, mapData, gameObject);
		mapIcon.GetComponent<LevelsListElementButton>().launchLevelMode = -1;
		
		if (mapData.source == FullMapData.MapSource.Workshop && Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(mapData.workshopId)) == 0)
			mapIcon.GetComponent<LevelsListElementButton>().ToggleRate();
	}

	[CompilerGenerated]
	private bool IsFunny(RanksSystem.Map IACGDFHKCAE)
	{
		if ((ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID)
		{
			return IACGDFHKCAE.isFunny;
		}
		return false;
	}

	public IEnumerator ShowMessage(string message, float duration)
	{
		// remove to upper lol
		messageCanvas.GetComponentInChildren<Text>().text = message.ToUpper();
		
		// max fade time of 1 second, otherwise 1/4th of duration
		messageAnimation.GetComponent<EasyTween>().SetAnimatioDuration((duration >= 1f) ? 1f : (duration / 4f));
		
		// animation
		// fade-in over fade time
		messageAnimation.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		// wait for duration
		yield return new WaitForSeconds(duration);
		// fade-out over fade time
		messageAnimation.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		// wait for fade time before showing another message
		yield return new WaitForSeconds((duration >= 1f) ? 1f : (duration / 4f));
	}

	[CompilerGenerated]
	private bool IsOfficial(RanksSystem.Map IACGDFHKCAE)
	{
		if ((ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID)
		{
			return IACGDFHKCAE.isOfficial;
		}
		return false;
	}

	private IEnumerator NewHighscore()
	{
		yield return new WaitForSeconds(1f);

		pbase.scoreBeated = true;
		Debug.Log("[PlayerBase] New highscore");

		AddMessage(LocalizationService.Instance.GetLocalizatedText("#newhighscore"));
		
		string highscoreSave = "maps." + this.mapID + 
		                       (this.gameMode != GameScene.GameMode.Normal ? "." + this.gameMode.ToString().ToLower() : "") +
							   ".highScore";
							   
		Singleton<SaveSystem>.Instance.SetInt(highscoreSave, pbase.GetCurrentScore());
	}

	public void ShowResult(string result = "")
	{
		gameOver = true;

		// HandleMultiplayerStuff() in iqol
		if (!PhotonNetwork.offlineMode)
			Singleton<MultiplayerSystem>.Instance.ShowChat();
		
		GetComponent<NetworkScene>().UpdateScoreboard();
		
		if (PhotonNetwork.inRoom && !PhotonNetwork.offlineMode && result != "CompletedLevel")
			GetComponent<NetworkScene>().photonView.RPC("OnPlayerGameMessage", PhotonTargets.Others, PhotonNetwork.playerName, "Finished");
		
		
		//
		if (AllPlayersFinished())
			currentMusicTime = calculatedmaptime;

		if (string.IsNullOrEmpty(result))
			levelProgressBar.transform.Find("Fill Area").Find("Fill").GetComponent<Image>()
				.color = Color.red;

		// completed level?
		pbase.isMapCompleted = result == "CompletedLevel";
		pbase.isPlayerWon = result == "CompletedLevel";

		// got highscore?
		// BUG: pbase.currentAttempt > 0 means you have to wait till your next attempt before you can save a highscore, remove it, iqol did
		if (gameMode != GameMode.Relax && pbase.GetCurrentScore() > pbase.lastBestScore && !pbase.scoreBeated && pbase.currentAttempt > 0) 
			StartCoroutine(NewHighscore());

		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(this.mapID);

		// submit score and "replay" to server
		pbase.StopReplayRecording();

		ulong workshopID = 0;

		if (pbase.GetCurrentScore() >= 0 && GameManager.IsOwner() // removed in iqol
		    && Singleton<SaveSystem>.Instance.GetInt("settings.enableranking", 1) == 1
			&& gameMode != GameMode.Relax 
			&& mapData.source != FullMapData.MapSource.Editor
			&& ulong.TryParse(mapData.workshopId, out workshopID)
			&& RanksSystem.IsOfficial(workshopID))
		{
			string mapFilePath = mapData.fullLevelPath + "/" + Helpers.levelConfigFileName;
			string replayJson = pbase.Replay() != null ? JsonConvert.SerializeObject(pbase.Replay()) : "{}";
			
			StartCoroutine(Singleton<RanksSystem>.Instance.SubmitScore(mapData.workshopId, gameMode, pbase.GetCurrentScore(), pbase.accuracyScore, pbase.incorrectScore, EGOPKJHICLK.CompressString(replayJson), Helpers.CalculateMD5(mapFilePath)));
		}

		Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
		
		// add 1 to playcount
		string timesPlayedSave = "maps." + Singleton<MapsSystem>.Instance.GetMapID(mapData) + ".played";
		int addOneToTimesPlayed = Singleton<SaveSystem>.Instance.GetInt("maps." + Singleton<MapsSystem>.Instance.GetMapID(mapData) + ".played", 0) + 1;
		Singleton<SaveSystem>.Instance.SetInt(timesPlayedSave, addOneToTimesPlayed);
		
		// BuildMapInfo() in iqol
		FinishedMapInfo finishedMapInfo = new FinishedMapInfo();
		try
		{
			finishedMapInfo.accuracy = pbase.accuracyScore;
			finishedMapInfo.completed = pbase.isMapCompleted;
			finishedMapInfo.isstoryboardactive = !Singleton<SaveSystem>.Instance.GetBool("settings.disablestoryboard", false);
			finishedMapInfo.gamemode = (int)gameMode;
			finishedMapInfo.loopscount = pbase.loopsCount;
			if (RanksSystem.IsOfficial(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(mapID).workshopId), true))
			{
				finishedMapInfo.isofficial = RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID && IACGDFHKCAE.isOfficial);
				finishedMapInfo.isloved = RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID && IACGDFHKCAE.isLoved);
				finishedMapInfo.isfunny = RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID && IACGDFHKCAE.isFunny);
			}
			else
			{
				finishedMapInfo.isofficial = false;
				finishedMapInfo.isloved = false;
				finishedMapInfo.isfunny = false;
			}
			finishedMapInfo.ismultiplayer = !PhotonNetwork.offlineMode;
			finishedMapInfo.multiplayerplayers = PhotonNetwork.room.PlayerCount;
			finishedMapInfo.multiplayerplace = GetComponent<NetworkScene>().place;
			if (RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID) != null)
			{
				finishedMapInfo.mapdifficulty = RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID).difficulty;
			}
			else
			{
				finishedMapInfo.mapdifficulty = -1f;
			}
			finishedMapInfo.handsCount = Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.handCount;
			finishedMapInfo.mapid = mapID;
			finishedMapInfo.maptags = string.Join(",", Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.tags.ToArray());
			finishedMapInfo.mapper = string.Empty + Singleton<MapsSystem>.Instance.GetMapData(mapID).mapperSteamID;
			finishedMapInfo.misses = pbase.incorrectScore;
			finishedMapInfo.perfecthits = pbase.perfectHits;
			finishedMapInfo.time = HPAnimationTime;
			finishedMapInfo.score = pbase.GetCurrentScore();
			foreach (GameEventInfo gameEventInfo in pbase.gameEventInfoList)
			{
				Singleton<GameManager>.Instance.GameEvent(gameEventInfo);
			}
			pbase.gameEventInfoList.Clear();
			Singleton<GameManager>.Instance.FinishedMap(finishedMapInfo);
		}
		catch (Exception) {	}


		// ObtainAchievementsAndLevelUp() in iqol
		if (!PhotonNetwork.offlineMode && PhotonNetwork.room.PlayerCount >= 2)
		{
			Helpers.ObtainAchievement(18);
		}
		if (!PhotonNetwork.offlineMode && PhotonNetwork.room.PlayerCount == 1)
		{
			Helpers.ObtainAchievement(19);
		}

		if ((bool)pbase.isPlayerWon && gameMode != 0)
		{
			string hFEFHOPOLIK2 = "maps." + Singleton<MapsSystem>.Instance.GetMapID(mapData) + ".completed";
			int dPNHODJHGJL2 = 1;
			Singleton<SaveSystem>.Instance.SetInt(hFEFHOPOLIK2, dPNHODJHGJL2);
			if (!PhotonNetwork.offlineMode)
			{
				Helpers.ObtainAchievement(15);
			}
			if (!PhotonNetwork.offlineMode && Singleton<MapsSystem>.Instance.GetMapData(mapID).source == FullMapData.MapSource.Workshop)
			{
				Helpers.ObtainAchievement(16);
			}
			if (!string.IsNullOrEmpty(mapData.workshopId) && RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.id == workshopID && IACGDFHKCAE.isOfficial && (gameMode == GameMode.Hardcore || gameMode == GameMode.Normal)) && !Singleton<SaveSystem>.Instance.GetBool("achievements.21.completed." + mapID, false))
			{
				Singleton<SaveSystem>.Instance.SetBool("achievements.21.completed." + mapID, true);
				Helpers.AddToStat("achievements.21.progress", 1);
				SteamUserStats.IndicateAchievementProgress("NEW_ACHIEVEMENT_1_21", (uint)Helpers.GetStat("achievements.21.progress"), 10u);
			}
			int dPNHODJHGJL3 = (int)((float)pbase.accuracyScore * (float)(int)pbase.correctScore);
			Helpers.AddToStat("player.xp", dPNHODJHGJL3);
			pbase.DeletePlayerData();
			if ((float)pbase.accuracyScore >= 0.9f && mapData.source == FullMapData.MapSource.Workshop && RanksSystem.IsOfficial(workshopID) && RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map x) => x.id == workshopID && x.isOfficial && x.difficulty >= 4.5f))
			{
				Helpers.ObtainAchievement(22);
			}
		}
		if ((bool)pbase.isPlayerWon && gameMode == GameMode.Relax && mapData.source == FullMapData.MapSource.Workshop)
		{
			Helpers.AddToStat("achievements.26.progress", 1);
			SteamUserStats.IndicateAchievementProgress("NEW_ACHIEVEMENT_1_26", (uint)Helpers.GetStat("achievements.26.progress"), 5u);
			if (RanksSystem.IsOfficial(workshopID) && (int)pbase.incorrectScore == 0)
			{
				Helpers.ObtainAchievement(27);
			}
		}


		if (mapData.source == FullMapData.MapSource.Workshop && !string.IsNullOrEmpty(mapData.workshopId))
			SteamUGC.StopPlaytimeTrackingForAllItems();

		resultText.GetComponent<Text>().text = LocalizationService.Instance.GetTextByKey(!this.pbase.isPlayerWon ? "failed" : "levelcompleted").ToUpper();

		OnGameOverEvent.Invoke();

		ShowGOCanvas();
	}

	public void RestartEndless()
	{
		pbase.loopsCount++;
		StartCoroutine(ShowMessage("#loopnumber " + pbase.loopsCount, 1f * Singleton<SaveSystem>.Instance.GetFloat("settings.gamemessagesduration", 1f)));
		firstFrameInit = false;
		currentMusicTime = -1f;
		pbase.ResetEndless();
	}

	public bool AllPlayersWin()
	{
		bool result = true;
		PhotonPlayer[] playerList = PhotonNetwork.playerList;
		foreach (PhotonPlayer photonPlayer in playerList)
		{
			if (photonPlayer.CustomProperties["win"] == null || (photonPlayer.CustomProperties["win"] != null && !(bool)photonPlayer.CustomProperties["win"]))
			{
				result = false;
			}
		}
		return result;
	}

	public override void Update()
	{
		base.Update();
		
		// if game has not started but all players loaded, start round
		if (!isGameStarted && AllPlayerLoaded())
			pbase.photonView.RPC("StartRound", PhotonTargets.AllBufferedViaServer, null);

		// if game started and the song has started but we haven't done our first frame stuffs, do those
		if ((bool)isGameStarted && (float)currentMusicTime > 0f && !firstFrameInit)
		{
			asampler.audioSources[0].time = currentMusicTime;
			asampler.audioSources[1].time = currentMusicTime;
			asampler.Play(0);
			asampler.Play(1);
			firstFrameInit = true;
		}

		// if current music time is greater than the end of map, but the round is not finished and the game has started
		// then update ui and handle restart (what)
		if ((float)currentMusicTime < calculatedmaptime && !IsRoundFinished() && (bool)isGameStarted)
		{
			currentMusicTime = (float)currentMusicTime + Time.deltaTime;
			levelProgressBar.GetComponent<Slider>().value = currentMusicTime;
			PlayerBase spectatedPlayerBase = pbase;

			// if can spectate, spectate
			if (pbase.currentState == PlayerBase.PlayerState.Spectator && pbase.spectatedPlayerBase != null)
				spectatedPlayerBase = pbase.spectatedPlayerBase;

			// if we see hp, show hp, depending on gamemode (hardcore sees acc only)
			if (showHP)
				if (gameMode != GameMode.Hardcore)
					hpText.text = livesOrAcc + ": " + spectatedPlayerBase.lives + " / " + spectatedPlayerBase.fullLevelData.mapData.maxLives;
				else
					hpText.text = livesOrAcc + ": " + (Math.Floor((float)spectatedPlayerBase.accuracyScore * 10000f) / 10000.0 * 100.0).ToString("0.00") + "%";

			scoreText.text = scoreString + ": " + spectatedPlayerBase.GetCurrentScore();
			comboTextGO.text = comboString + ": " + "x" + spectatedPlayerBase.currentCombo;
			
			// handle restart (what)
			if (hardInput.GetKeyDown("restart") && PhotonNetwork.offlineMode)
			{
				foreach (GameEventInfo gameEventInfo in pbase.gameEventInfoList)
					Singleton<GameManager>.Instance.GameEvent(gameEventInfo);

				pbase.gameEventInfoList.Clear();
				OnRestartButton(true);
			}
		}

		// if game over, and we are finished
		if ((bool)gameOver && pbase.currentState == PlayerBase.PlayerState.Finished)
		{
			// disable game ui
			ingameUICanvas.SetActive(false);
			
			// if everyone done
			if (AllPlayersFinished())
			{
				// lower music volume
				foreach (AudioSource audioSource in asampler.audioSources)
				{
					// if we lost, lower pitch too
					if (!pbase.isPlayerWon)
						audioSource.pitch = Mathf.Lerp(audioSource.pitch, 0f, Time.deltaTime * 0.5f);

					audioSource.volume = Mathf.Lerp(audioSource.volume, 0f, Time.deltaTime * 0.5f);
				}

				asampler.isMuted = true;
			}

			FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(mapID);

			// Todo, store the found objects to variables somewhere
			// SetUpGameOverShit() in iqol
			if (!string.IsNullOrEmpty(mapData.workshopId)
			    && RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map x)
					=> x.id == ulong.Parse(mapData.workshopId) && x.isOfficial && (gameMode == GameMode.Hardcore || gameMode == GameMode.Normal))
				&& (bool)GameObject.Find("FinalScoreText"))
			{
				GameObject.Find("FinalScoreText").SetActive(false);
			}
			else
			{
				if ((bool)GameObject.Find("HightScoreMaxPointsText"))
					GameObject.Find("HightScoreMaxPointsText").SetActive(false);

				if ((bool)GameObject.Find("PossibleMapPointsText"))
					GameObject.Find("PossibleMapPointsText").SetActive(false);

				if ((bool)GameObject.Find("PointsScoreText"))
					GameObject.Find("PointsScoreText").SetActive(false);

				if ((bool)GameObject.Find("FinalScoreSmallText"))
					GameObject.Find("FinalScoreSmallText").SetActive(false);
			}

			if ((gameMode == GameMode.Hardcore || gameMode == GameMode.Endless) && (bool)GameObject.Find("CheckpointsScoreText"))
				GameObject.Find("CheckpointsScoreText").SetActive(false);

			if (gameMode != GameMode.Endless && (bool)GameObject.Find("EndlessLoopsScoreText"))
				GameObject.Find("EndlessLoopsScoreText").SetActive(false);

			int currentScore = pbase.GetCurrentScore();
			if ((bool)GameObject.Find("LastHighScoreText"))
				GameObject.Find("LastHighScoreText").GetComponent<Text>().text = string.Empty + pbase.lastBestScore;

			if ((bool)GameObject.Find("PossibleMapMaxScoreText"))
				GameObject.Find("PossibleMapMaxScoreText").GetComponent<Text>().text = string.Empty + Helpers.GetMapMaxScore(pbase.fullLevelData.mapData);

			if ((bool)GameObject.Find("GameModeText"))
				GameObject.Find("GameModeText").GetComponent<Text>().text = string.Empty + LocalizationService.Instance.GetLocalizatedText("#" + gameMode.ToString().ToLower() + "mode").ToUpper();

			if ((bool)GameObject.Find("FinalScoreText"))
				GameObject.Find("FinalScoreText").GetComponent<Text>().text = string.Empty + currentScore;

			if ((bool)GameObject.Find("TotalHitsScoreText"))
				GameObject.Find("TotalHitsScoreText").GetComponent<Text>().text = string.Empty + ((int)pbase.correctScore + (int)pbase.incorrectScore);

			if ((bool)GameObject.Find("PerfectHitsScoreText"))
				GameObject.Find("PerfectHitsScoreText").GetComponent<Text>().text = string.Empty + pbase.perfectHits;
				
			if ((bool)GameObject.Find("CorrectHitsScoreText"))
				GameObject.Find("CorrectHitsScoreText").GetComponent<Text>().text = string.Empty + ((int)pbase.correctScore - (int)pbase.perfectHits);

			if ((bool)GameObject.Find("IncorrectHitsScoreText"))
				GameObject.Find("IncorrectHitsScoreText").GetComponent<Text>().text = string.Empty + pbase.incorrectScore;

			if ((bool)GameObject.Find("ComboScoreText"))
				GameObject.Find("ComboScoreText").GetComponent<Text>().text = string.Empty + Mathf.RoundToInt(pbase.comboScore);

			if ((bool)GameObject.Find("PenaltyScoreText"))
				GameObject.Find("PenaltyScoreText").GetComponent<Text>().text = string.Empty + Mathf.CeilToInt(pbase.penaltyScore);

			if ((bool)GameObject.Find("AccuracyScoreText"))
				GameObject.Find("AccuracyScoreText").GetComponent<Text>().text = string.Empty + (Math.Floor((float)pbase.accuracyScore * 10000f) / 10000.0 * 100.0).ToString("0.00") + "%";

			if ((bool)GameObject.Find("CheckpointsScoreText"))
				GameObject.Find("CheckpointsScoreText").GetComponent<Text>().text = string.Empty + pbase.checkpointsUsed;
				
			if ((bool)GameObject.Find("EndlessLoopsScoreText"))
				GameObject.Find("EndlessLoopsScoreText").GetComponent<Text>().text = string.Empty + pbase.loopsCount;

			if ((bool)GameObject.Find("HightScoreMaxPointsText"))
			{
				float num = (float)pbase.lastBestScore / (float)Helpers.GetMapMaxScore(pbase.fullLevelData.mapData) * RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.id == ulong.Parse(mapData.workshopId)).difficulty;
				GameObject.Find("HightScoreMaxPointsText").GetComponent<Text>().text = string.Empty + (Math.Floor(num * 100f) / 100.0).ToString("0.00");
			}

			if ((bool)GameObject.Find("PossibleMapPointsText"))
				GameObject.Find("PossibleMapPointsText").GetComponent<Text>().text = string.Empty + RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.id == ulong.Parse(mapData.workshopId)).difficulty.ToString("0.00");

			if ((bool)GameObject.Find("PointsScoreText"))
			{
				float num2 = (float)currentScore / (float)Helpers.GetMapMaxScore(pbase.fullLevelData.mapData) * RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.id == ulong.Parse(mapData.workshopId)).difficulty;
				num2 = ((num2 >= 0f) ? num2 : 0f);
				GameObject.Find("PointsScoreText").GetComponent<Text>().text = string.Empty + (Math.Floor(num2 * 100f) / 100.0).ToString("0.00");
			}

			if ((bool)GameObject.Find("FinalScoreSmallText"))
				GameObject.Find("FinalScoreSmallText").GetComponent<Text>().text = string.Empty + currentScore;

			if (restartNoCheckpointPanel.transform.Find("ExitButton").gameObject.activeInHierarchy && !PhotonNetwork.offlineMode)
				restartNoCheckpointPanel.transform.Find("ExitButton").gameObject.GetComponentInChildren<Text>().text = ((!PhotonNetwork.isMasterClient) ? LocalizationService.Instance.GetTextByKey("leave").ToUpper() : LocalizationService.Instance.GetTextByKey("tolobby").ToUpper());

			if (!PhotonNetwork.isMasterClient && PhotonNetwork.inRoom && (bool)GameObject.Find("ResetButton"))
				GameObject.Find("ResetButton").GetComponent<Button>().interactable = false;
				
			if (!PhotonNetwork.offlineMode && PhotonNetwork.inRoom)
				GetComponent<NetworkScene>().networkChatCanvas.SetActive(true);
		}


		if ((bool)gameOver && Singleton<RanksSystem>.Instance.isRankChanged)
			Singleton<RanksSystem>.Instance.DisplayRanksChanges();

		if ((bool)gameOver && Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
			Singleton<ItemsHandler>.Instance.ShowNewItems();

		if ((bool)gameOver && Singleton<ChallengesManager>.Instance.HasProgress())
			Singleton<ChallengesManager>.Instance.RewardsReadyNotification();

		if (AllPlayersFinished() && pbase.currentState == PlayerBase.PlayerState.Finished && spectatePanel.activeSelf)
		{
			gameOverCanvas.SetActive(true);
			spectatorCanvas.SetActive(false);
			spectatePanel.SetActive(false);
			ingameUICanvas.SetActive(false);

			if (!pbase.isPlayerWon && pbase.CanResumeFromCheckpoint())
				restartCheckpointPanel.SetActive(true);
			else
				restartNoCheckpointPanel.SetActive(true);
		}

		if (AllPlayersFinished() && pbase.currentState == PlayerBase.PlayerState.Spectator)
		{
			gameOverCanvas.SetActive(true);
			spectatorCanvas.SetActive(false);
			spectatePanel.SetActive(false);
			ingameUICanvas.SetActive(false);
			if (!pbase.isPlayerWon && pbase.CanResumeFromCheckpoint())
				restartCheckpointPanel.SetActive(true);
			else
				restartNoCheckpointPanel.SetActive(true);

			pbase.currentState = PlayerBase.PlayerState.Finished;
		}

		if ((bool)isGameStarted && (bool)pbase && PhotonNetwork.inRoom && (bool)pbase.isPlayerWon && !PhotonNetwork.offlineMode && AllPlayersWin())
		{
			int playerCount = PhotonNetwork.room.PlayerCount;
			int num4 = 1;
		}

		// HandleEndingShitIThink() in iqol
		if ((bool)isGameStarted && (float)currentMusicTime > calculatedmaptime && !gameOver)
		{
			foreach (GameObject gameObject in this.pbase.playerController.objects)
				if (gameObject.transform.childCount > 0) return;

			pbase.isMapCompleted = true;

			// if endless, restart
			if (gameMode == GameMode.Endless)
			{
				RestartEndless();
				return;
			}

			// otherwise finish
			ExitGames.Client.Photon.Hashtable finishedHashtable = new ExitGames.Client.Photon.Hashtable { { "finished", true } };
			PhotonNetwork.player.SetCustomProperties(finishedHashtable);
			pbase.currentState = PlayerBase.PlayerState.Finished;

			if (pbase.photonView.isMine)
			{
				ExitGames.Client.Photon.Hashtable winHashTable = new ExitGames.Client.Photon.Hashtable { { "win", true } };
				PhotonNetwork.player.SetCustomProperties(winHashTable);
			}

			ShowResult("CompletedLevel");
		}

		// display messages
		if (messageTextQueue.Count > 0 && !messageCanvas.activeSelf)
		{
			string message = messageTextQueue[0];
			float messageDuration = 1f;
			if (messageDurationQueue.Count == messageTextQueue.Count)
				messageDuration = messageDurationQueue[0];

			StartCoroutine(ShowMessage(message, messageDuration * Singleton<SaveSystem>.Instance.GetFloat("settings.gamemessagesduration", 1f)));
			messageTextQueue.RemoveAt(0);
			messageDurationQueue.RemoveAt(0);
		}
	}

	public bool AllPlayerLoaded()
	{
		foreach (PhotonPlayer photonPlayer in PhotonNetwork.playerList)
			if (photonPlayer.CustomProperties["ready"] == null || (photonPlayer.CustomProperties["ready"] != null && !(bool)photonPlayer.CustomProperties["ready"]))
				return false;

		return true;
	}

	public void SelectRestartButton()
	{
		if ((bool)GameObject.Find("SpectateButton"))
			EventSystem.current.SetSelectedGameObject(GameObject.Find("SpectateButton"));

		else if ((bool)GameObject.Find("RestartButton"))
			EventSystem.current.SetSelectedGameObject(GameObject.Find("RestartButton"));

		else if ((bool)GameObject.Find("ResetButton"))
			EventSystem.current.SetSelectedGameObject(GameObject.Find("ResetButton"));

		ShowCursor(true);
	}

	[CompilerGenerated]
	private bool MakeMapIDAgain(RanksSystem.Map IACGDFHKCAE)
	{
		return (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID;
	}

	public GameScene()
	{
		gameOver = false;
		isGameStarted = false;
		usingCheckpoints = true;
		gameMode = GameMode.Normal;
		firstFrameInit = false;
		messageTextQueue = new List<string>();
		messageDurationQueue = new List<float>();
		scoreString = string.Empty;
		livesOrAcc = string.Empty;
		highscore = string.Empty;
		comboString = string.Empty;
		currentMusicTime = 0f;
	}

	[CompilerGenerated]
	private static bool FindMapEnd(MapEvent mapEvent)
	{
		return mapEvent.data[0] == "MapEnd";
	}

	public void OnSpectateButton()
	{
		restartCheckpointPanel.SetActive(false);
		restartNoCheckpointPanel.SetActive(false);
		gameOverCanvas.SetActive(false);
		spectatorCanvas.SetActive(true);
		StartCoroutine(UpdateSpectatingInfo());
		pbase.StartSpectating();
	}

	[CompilerGenerated]
	private static bool FindMapEndAgain(MapEvent mapEvent)
	{
		return mapEvent.data[0] == "MapEnd";
	}

	public void OnSpectateNextButton()
	{
		pbase.SpectateNext(true);
		StartCoroutine(UpdateSpectatingInfo());
	}

	public void OnEnable() { }

	public bool IsRoundFinished()
	{
		if ((bool)gameOver)
			return AllPlayersFinished();

		return false;
	}

	public override void Start()
	{
		base.Start();
		Reset();

		if (!PhotonNetwork.inRoom)
		{
			PhotonNetwork.offlineMode = true;
			PhotonNetwork.JoinOrCreateRoom("offline", new RoomOptions(), TypedLobby.Default);
		}

		mapID = Singleton<SaveSystem>.Instance.GetString("menu.selectedlevelid");
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(mapID);
		int num = (int)(gameMode = (GameMode)Singleton<SaveSystem>.Instance.GetInt("menu.selectedplaymode", 0));
		scoreString = LocalizationService.Instance.GetLocalizatedText("#score").ToUpper();

		if (gameMode != GameMode.Hardcore)
			livesOrAcc = LocalizationService.Instance.GetLocalizatedText("#lives").ToUpper();
		else
			livesOrAcc = LocalizationService.Instance.GetLocalizatedText("#accuracy").ToUpper();

		highscore = LocalizationService.Instance.GetLocalizatedText("#highscore").ToUpper();
		comboString = LocalizationService.Instance.GetLocalizatedText("#combo").ToUpper();
		GameObject gameObject = levelInfoContent;

		for (int i = 0; i < gameObject.transform.childCount; i++)
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);

		GameObject gameObject2 = Singleton<MapsSystem>.Instance.AddDownloadedLevelItemToList(levelInfo, Singleton<MapsSystem>.Instance.GetMapData(mapID), gameObject);
		gameObject2.GetComponent<LevelsListElementButton>().launchLevelMode = -1;
		
		if (Singleton<MapsSystem>.Instance.GetMapData(mapID).source != 0 && Singleton<MapsSystem>.Instance.GetMapData(mapID).source != FullMapData.MapSource.Editor && Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(mapID).workshopId)) == 0)
			gameObject2.GetComponent<LevelsListElementButton>().ToggleRate();

		if (mapData.mapData.maxLives < mapData.mapData.lives)
			mapData.mapData.maxLives = mapData.mapData.lives;

		GameObject gameObject3 = ((!PhotonNetwork.inRoom) ? UnityEngine.Object.Instantiate(Resources.Load("Gameplay/Base") as GameObject) : PhotonNetwork.Instantiate("Gameplay/Base", new Vector3(0f, 0f, 0f), Quaternion.identity, 0));
		pbase = gameObject3.GetComponent<PlayerBase>();
		
		if (showHP)
			hpText.text = string.Empty;
		else
			hpText.gameObject.SetActive(false);
		
		Singleton<GameManager>.Instance.UpdateOnlineStatus("Playing " + ((!PhotonNetwork.offlineMode) ? "Multiplayer" : "Solo"), "Map: " + mapData.mapData.name.Replace(Environment.NewLine, string.Empty));
		
		if (mapData.source == FullMapData.MapSource.Workshop && !string.IsNullOrEmpty(mapData.workshopId))
		{
			List<PublishedFileId_t> list = new List<PublishedFileId_t>();
			list.Add(new PublishedFileId_t(ulong.Parse(mapData.workshopId)));
			SteamUGC.StartPlaytimeTracking(list.ToArray(), (uint)list.Count);
		}

		Debug.Log("[GameScene] Checkpoints count: " + mapData.mapData.checkpoints.Count);
		Debug.Log("[GameScene] Events count: " + mapData.mapData.events.Count);

		if (mapData.mapData.events.Find((MapEvent IACGDFHKCAE) => IACGDFHKCAE.data[0] == "MapEnd") != null)
		{
			List<MapEvent> events = mapData.mapData.events;
			calculatedmaptime = events.Find((MapEvent IACGDFHKCAE) => IACGDFHKCAE.data[0] == "MapEnd").time;
		}
		else
			calculatedmaptime = mapData.mapData.musicTime;

		if (!PhotonNetwork.offlineMode)
			usingCheckpoints = false;

		if (gameMode == GameMode.Relax || gameMode == GameMode.Hardcore || gameMode == GameMode.Endless)
			usingCheckpoints = false;

		pbase.gameEventInfoList = new List<GameEventInfo>();
		GameEventInfo gameEventInfo = new GameEventInfo();

		try
		{
			gameEventInfo.isstoryboardactive = !Singleton<SaveSystem>.Instance.GetBool("settings.disablestoryboard", false);
			gameEventInfo.gamemode = (int)gameMode;

			if (RanksSystem.IsOfficial(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(mapID).workshopId), true))
			{
				gameEventInfo.isofficial = RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID && IACGDFHKCAE.isOfficial);
				gameEventInfo.isloved = RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID && IACGDFHKCAE.isLoved);
				gameEventInfo.isfunny = RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID && IACGDFHKCAE.isFunny);
			}
			else
			{
				gameEventInfo.isofficial = false;
				gameEventInfo.isloved = false;
				gameEventInfo.isfunny = false;
			}

			if (RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID) != null)
				gameEventInfo.mapdifficulty = RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID).difficulty;
			else
				gameEventInfo.mapdifficulty = -1f;

			gameEventInfo.handsCount = Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.handCount;
			gameEventInfo.mapid = mapID;
			gameEventInfo.maptags = string.Join(",", Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.tags.ToArray());
			gameEventInfo.mapper = string.Empty + Singleton<MapsSystem>.Instance.GetMapData(mapID).mapperSteamID;
		}
		catch (Exception) { }

		pbase.gameEventInfoBase = gameEventInfo;
		pbase.InitSystem();
	}

	public void OnRestartRound()
	{
		loadingCanvas.SetActive(true);
		GetComponent<NetworkScene>().networkChatCanvas.SetActive(false);
	}

	public void OnRestartButton(bool fullRestart)
	{
		if (fullRestart)
			pbase.DeletePlayerData();
		else if (pbase.ach12)
			Helpers.ObtainAchievement(12);

		GetComponent<NetworkScene>().photonView.RPC("OnMastedChangeScene", PhotonTargets.AllViaServer, SceneManager.GetActiveScene().name);
	}

	[CompilerGenerated]
	private bool MakeMapID(RanksSystem.Map map)
	{
		return (ObscuredString)("workshop." + map.id) == mapID;
	}
}
