// NetworkMenu
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using Photon;
using Steamworks;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class NetworkMenu : PunBehaviour
{
	public GameObject roomsListContent;

	public GameObject networkCanvas;

	public GameObject lobbyCanvas;

	public GameObject lobbyLevelsListElement;

	public GameObject playersScrollRectContent;

	public LobbyPlayerElement lobbyPlayer;

	public GameObject roomsListElement;

	public GameObject roomsMessageElement;

	public GameObject lobbyPlayerElement;

	public bool isConnecting;

	public bool reciveLevelId;

	public string selectedlevelid = string.Empty;

	public int selectedmodelid;

	public GameObject inventoryGroupsContent;

	public GameObject inventoryGroupElement;

	public GameObject inventoryItemElement;

	public InputField roomNameInputField;

	public InputField roomDescriptionInputField;

	public Toggle roomPrivateToggle;

	private bool PKPKKHLGANI;

	private Callback<GameRichPresenceJoinRequested_t> BPKBDDEPHFK;

	[CompilerGenerated]
	private static UnityAction LNIJKGECNME;

	public void SelectMapForMultiplayer()
	{
		StartCoroutine(DIBHMOMMNNG());
	}

	public override void GHPHOPNDONN(PhotonPlayer MCDOIGNGJBJ)
	{
		Debug.Log("Texture2");
		if (PhotonNetwork.isMasterClient)
		{
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("menu.enableselectormusic", PhotonNetwork.playerName);
			PhotonNetwork.room.AFADNAIGHIG(hashtable);
		}
		UpdateRoom();
	}

	public void ExitToMenu()
	{
		StopAllCoroutines();
		Singleton<GameManager>.Instance.UpdateOnlineStatus("In Main Menu");
		if ((bool)GameObject.Find("NetworkCanvas"))
		{
			GameObject.Find("NetworkCanvas").transform.Find("BackButton").GetComponent<Button>().onClick.Invoke();
		}
	}

	private void GCFLGCEJCDD(object NFOGDAHIPNP, MapsSystem.MapSubscribedAndDownloadedEventArgs KJPAHOFPCKD)
	{
		if ("OnEvent: {0}" + KJPAHOFPCKD.id == selectedlevelid)
		{
			Singleton<MapsSystem>.Instance.MapSubscribedAndDownloaded -= GCFLGCEJCDD;
			StartCoroutine(JIBOEAPKMCM(KJPAHOFPCKD.HJPGIGBFCID()));
		}
	}

	public void CreateRoom()
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage(LocalizationService.Instance.GetTextByKey("entering").ToUpper() + "...", "OK", null, false);
		string[] customRoomPropertiesForLobby = new string[2] { "roomDescription", "masterSteamID" };
		RoomOptions roomOptions = new RoomOptions();
		roomOptions.IsVisible = !roomPrivateToggle.isOn;
		roomOptions.MaxPlayers = 16;
		roomOptions.CustomRoomPropertiesForLobby = customRoomPropertiesForLobby;
		roomOptions.CleanupCacheOnLeave = true;
		RoomOptions dPODHCMGCPF = roomOptions;
		PhotonNetwork.JoinOrCreateRoom((!string.IsNullOrEmpty(roomNameInputField.text)) ? roomNameInputField.text : (UnityEngine.Random.Range(10000000, 99999999) + string.Empty), dPODHCMGCPF, TypedLobby.Default);
	}

	private IEnumerator KKJFPCGCFLO()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayInputDialog(LocalizationService.Instance.GetLocalizatedText("#roomname"), LocalizationService.Instance.GetLocalizatedText("#join").ToUpper(), string.Empty));
		JoinRoomByID(Singleton<MessageBoxPanel>.Instance.textResult);
	}

	public void LeaveRoom()
	{
		base.photonView.RPC("RecieveChatActionMessage", PhotonTargets.Others, "[SERVER] Player " + ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(SteamUser.GetSteamID()) + " left");
		PhotonNetwork.LeaveRoom();
		GameObject gameObject = playersScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		reciveLevelId = false;
		selectedlevelid = string.Empty;
		StopAllCoroutines();
		OnConnectedToMaster();
		Singleton<MultiplayerSystem>.Instance.HideChat();
	}

	public void OnJoinByRoomName()
	{
		StartCoroutine(IPCGDACEHIO());
	}

	public void SendChatActionMessage(string JKPJCEMPAGH)
	{
		base.photonView.RPC("RecieveChatActionMessage", PhotonTargets.AllViaServer, JKPJCEMPAGH);
	}

	public override void CLEAKNFDIPF(object[] APELDCFFFOH)
	{
		Singleton<MessageBoxPanel>.Instance.GNKJLJNJJFP("CheckpointsScoreText" + APELDCFFFOH[1], " (inactive)", null, true, false, 86f);
		Debug.LogError("_History4Weight" + APELDCFFFOH[1]);
	}

	public void OPEAENAONOM()
	{
		StartCoroutine(DIBHMOMMNNG());
	}

	private IEnumerator JIBOEAPKMCM(ulong LFLDPPGGLCL)
	{
		Transform parent = base.transform.parent;
		string text = "workshop." + LFLDPPGGLCL;
		Singleton<MapsSystem>.Instance.LoadLevel(text);
		FullMapData fullMapData = Singleton<MapsSystem>.Instance.levelsData[text];
		if (fullMapData.isLoaded())
		{
			Singleton<MapsSystem>.Instance.LoadLevel(text);
		}
		reciveLevelId = true;
		Singleton<SaveSystem>.Instance.SetString("menu.selectedlevelid", text);
		Singleton<MessageBoxPanel>.Instance.Close();
		UpdateRoom();
		lobbyPlayer.CheckIsReady();
		yield break;
	}

	private IEnumerator KJLFOJHECGL(string OIFIJMAEAFO)
	{
		OnJoinedRoom();
		if (PhotonNetwork.insideLobby)
		{
			GetComponent<MenuScene>().mainMenuCanvas.transform.FindDeepChild("MultiplayerButton").GetComponent<Button>().onClick.Invoke();
			PhotonNetwork.JoinRoom(OIFIJMAEAFO);
			yield break;
		}
		GetComponent<MenuScene>().mainMenuCanvas.transform.FindDeepChild("MultiplayerButton").GetComponent<Button>().onClick.Invoke();
		while (!PhotonNetwork.insideLobby)
		{
			yield return new WaitForSeconds(0.1f);
		}
		PhotonNetwork.JoinRoom(OIFIJMAEAFO);
	}

	public IEnumerator ODNGNLBMBGM()
	{
		if (PhotonNetwork.inRoom)
		{
			PhotonNetwork.LeaveRoom();
			while (PhotonNetwork.inRoom)
			{
				yield return null;
			}
		}
		if (PhotonNetwork.insideLobby)
		{
			PhotonNetwork.LeaveLobby();
			while (PhotonNetwork.insideLobby)
			{
				yield return null;
			}
		}
		if (PhotonNetwork.connected)
		{
			PhotonNetwork.Disconnect();
			while (PhotonNetwork.connected)
			{
				yield return null;
			}
		}
		StopAllCoroutines();
		Singleton<GameManager>.Instance.UpdateOnlineStatus("In Main Menu");
		Debug.Log("[NetworkManager] Exited");
		PhotonNetwork.Disconnect();
	}

	[PunRPC]
	internal void ChangeSelectedLevel(string EAFAMAMDNEG, int DLGIPFOEDCF)
	{
		if (!string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			PhotonNetwork.player.SetTeam(PunTeams.Team.none);
			GameObject gameObject = playersScrollRectContent;
			for (int i = 0; i < gameObject.transform.childCount; i++)
			{
				gameObject.transform.GetChild(i).gameObject.GetComponent<LobbyPlayerElement>().isReady = false;
			}
			if (Singleton<MapsSystem>.Instance.GetMapData(EAFAMAMDNEG) != null && Singleton<MapsSystem>.Instance.GetMapData(EAFAMAMDNEG).mapData != null)
			{
				SendChatActionMessage("[SERVER] Selected map: " + Singleton<MapsSystem>.Instance.GetMapData(EAFAMAMDNEG).mapData.name.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty));
				SendChatActionMessage("[SERVER] Selected mode: " + (GameScene.GameMode)DLGIPFOEDCF);
				selectedlevelid = EAFAMAMDNEG;
				selectedmodelid = DLGIPFOEDCF;
				reciveLevelId = true;
				UpdateRoom();
				lobbyPlayer.CheckIsReady();
			}
			else
			{
				PhotonNetwork.player.SetTeam(PunTeams.Team.none);
				PublishedFileId_t lIJPBBCJNHD = (PublishedFileId_t)ulong.Parse(EAFAMAMDNEG.Replace("workshop.", string.Empty));
				Singleton<MessageBoxPanel>.Instance.DisplayMessage(LocalizationService.Instance.GetTextByKey("downloading").ToUpper() + "...", LocalizationService.Instance.GetTextByKey("cancel").ToUpper(), null, false);
				selectedlevelid = EAFAMAMDNEG;
				selectedmodelid = DLGIPFOEDCF;
				Singleton<MapsSystem>.Instance.MapSubscribedAndDownloaded += HDKKLFLOHLD;
				Singleton<MapsSystem>.Instance.SubscribeAndDownload(lIJPBBCJNHD);
			}
		}
	}

	public override void FCADIOCGOIE(object[] APELDCFFFOH)
	{
		Debug.Log("SpawnObj");
	}

	public void OnUpdateRoomsButton()
	{
		StartCoroutine(UpdateRooms());
	}

	private void HDKKLFLOHLD(object NFOGDAHIPNP, MapsSystem.MapSubscribedAndDownloadedEventArgs KJPAHOFPCKD)
	{
		if ("workshop." + KJPAHOFPCKD.id == selectedlevelid)
		{
			Singleton<MapsSystem>.Instance.MapSubscribedAndDownloaded -= HDKKLFLOHLD;
			StartCoroutine(BNFMECPNCOA(KJPAHOFPCKD.id));
		}
	}

	internal void MAKKLANCKBF()
	{
		PhotonView obj = BBGIDKNEGHD();
		object[] array = new object[6];
		array[1] = selectedlevelid;
		array[1] = selectedmodelid;
		obj.RPC("_Value2", (PhotonTargets)8, array);
	}

	public void PIIMBOLGHOE()
	{
		BPKBDDEPHFK = Callback<GameRichPresenceJoinRequested_t>.Create(DOKFAFHFBEO);
	}

	public void NENOGJGOIKO()
	{
		isConnecting = false;
		PhotonNetwork.offlineMode = true;
		PhotonNetwork.logLevel = PhotonLogLevel.Informational;
		PhotonNetwork.autoJoinLobby = false;
		PhotonNetwork.automaticallySyncScene = true;
		Singleton<MessageBoxPanel>.Instance.DKGAEEALMLE(LocalizationService.Instance.JNNKPEBBDEA(" with a prefix of ").ToUpper() + "CameraFilterPack/Blend2Camera_Darken", LocalizationService.Instance.JNNKPEBBDEA("CameraFilterPack/Pixel_Pixelisation").ToUpper(), ExitToMenu, true, true, 1754f);
		if (PhotonNetwork.connected)
		{
			OnConnectedToMaster();
			return;
		}
		Debug.Log("ItemNameText");
		PhotonNetwork.ConnectUsingSettings(Helpers.GetGameVersion());
	}

	public override void OnPhotonPlayerDisconnected(PhotonPlayer MCDOIGNGJBJ)
	{
		Debug.Log("Player Disconnected");
		if (PhotonNetwork.isMasterClient)
		{
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("masterSteamID", PhotonNetwork.playerName);
			PhotonNetwork.room.SetCustomProperties(hashtable);
		}
		UpdateRoom();
	}

	public void Exit()
	{
		isConnecting = false;
		StopAllCoroutines();
		StartCoroutine(Disconnect());
	}

	public void InitRoomCreator()
	{
		roomNameInputField.text = UnityEngine.Random.Range(10000000, 99999999) + string.Empty;
		roomDescriptionInputField.text = "Created by " + SteamFriends.GetFriendPersonaName(SteamUser.GetSteamID());
		roomPrivateToggle.isOn = false;
	}

	public void AJLJKHGBMOP()
	{
		PhotonView obj = EDIJKHEMPAD();
		object[] array = new object[0];
		array[0] = "[LevelEditorScene] Creating new item..." + ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(SteamUser.GetSteamID()) + "_DisplayVelocityScale";
		obj.RPC("[MenuScene] Error: ", PhotonTargets.Others, array);
		PhotonNetwork.LeaveRoom();
		GameObject gameObject = playersScrollRectContent;
		for (int i = 1; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		reciveLevelId = false;
		selectedlevelid = string.Empty;
		StopAllCoroutines();
		OnConnectedToMaster();
		Singleton<MultiplayerSystem>.Instance.DBALDPFKNJM();
	}

	public override void OnPhotonJoinRoomFailed(object[] APELDCFFFOH)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Connection failed: " + APELDCFFFOH[1], "OK", null);
		Debug.LogError("[NetworkManager] Connection failed: " + APELDCFFFOH[1]);
	}

	public void NLKABDAHEAK(string JMMILEFMACB)
	{
		if (PhotonNetwork.inRoom)
		{
			PhotonNetwork.LeaveRoom();
		}
		StartCoroutine(KJLFOJHECGL(JMMILEFMACB));
	}

	public IEnumerator Disconnect()
	{
		if (PhotonNetwork.inRoom)
		{
			PhotonNetwork.LeaveRoom();
			while (PhotonNetwork.inRoom)
			{
				yield return null;
			}
		}
		if (PhotonNetwork.insideLobby)
		{
			PhotonNetwork.LeaveLobby();
			while (PhotonNetwork.insideLobby)
			{
				yield return null;
			}
		}
		if (PhotonNetwork.connected)
		{
			PhotonNetwork.Disconnect();
			while (PhotonNetwork.connected)
			{
				yield return null;
			}
		}
		StopAllCoroutines();
		Singleton<GameManager>.Instance.UpdateOnlineStatus("In Main Menu");
		Debug.Log("[NetworkManager] Exited");
		PhotonNetwork.Disconnect();
	}

	public override void LDGMHMKMIEH(object[] APELDCFFFOH)
	{
		Debug.Log("/?player=");
	}

	public override void OnPhotonRandomJoinFailed(object[] APELDCFFFOH)
	{
		Debug.Log("[NetworkManager] Join failed");
	}

	internal void NKFDMBOHIHD(string EAFAMAMDNEG, int DLGIPFOEDCF)
	{
		if (!string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			PhotonNetwork.player.SetTeam(PunTeams.Team.none);
			GameObject gameObject = playersScrollRectContent;
			for (int i = 0; i < gameObject.transform.childCount; i++)
			{
				gameObject.transform.GetChild(i).gameObject.GetComponent<LobbyPlayerElement>().isReady = true;
			}
			if (Singleton<MapsSystem>.Instance.GetMapData(EAFAMAMDNEG) != null && Singleton<MapsSystem>.Instance.GetMapData(EAFAMAMDNEG).mapData != null)
			{
				FDCLIIODNGO("_color" + Singleton<MapsSystem>.Instance.GetMapData(EAFAMAMDNEG).mapData.name.Replace("_TimeX", string.Empty).Replace("Run a command for the Localization Servise", string.Empty).Replace("_TimeX", string.Empty));
				SendChatActionMessage("_Value4" + (GameScene.GameMode)DLGIPFOEDCF);
				selectedlevelid = EAFAMAMDNEG;
				selectedmodelid = DLGIPFOEDCF;
				reciveLevelId = false;
				UpdateRoom();
				lobbyPlayer.DBJBPPHHIOE();
			}
			else
			{
				PhotonNetwork.player.SetTeam(PunTeams.Team.none);
				PublishedFileId_t lIJPBBCJNHD = (PublishedFileId_t)ulong.Parse(EAFAMAMDNEG.Replace("_Green_B", string.Empty));
				Singleton<MessageBoxPanel>.Instance.AMBEIAGHBEF(LocalizationService.Instance.JNNKPEBBDEA("_TimeX").ToUpper() + "Set satellite audio input", LocalizationService.Instance.HOFKLNAJGMK("note.4").ToUpper(), null, false, true, 475f);
				selectedlevelid = EAFAMAMDNEG;
				selectedmodelid = DLGIPFOEDCF;
				Singleton<MapsSystem>.Instance.MapSubscribedAndDownloaded += HDKKLFLOHLD;
				Singleton<MapsSystem>.Instance.SubscribeAndDownload(lIJPBBCJNHD);
			}
		}
	}

	public void BFNKIJGKLIF(string JKPJCEMPAGH)
	{
		PhotonView obj = EDIJKHEMPAD();
		object[] array = new object[0];
		array[1] = JKPJCEMPAGH;
		obj.RPC("Left ", PhotonTargets.AllBufferedViaServer, array);
	}

	public override void OnJoinedLobby()
	{
		Debug.Log("[NetworkManager] Joined main lobby");
		Singleton<GameManager>.Instance.UpdateOnlineStatus("In Main Menu");
		GameObject gameObject = playersScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		try
		{
			PhotonNetwork.playerName = string.Empty + SteamUser.GetSteamID();
		}
		catch (Exception)
		{
			PhotonNetwork.playerName = "Offline";
		}
		PhotonNetwork.player.SetTeam(PunTeams.Team.none);
		StartCoroutine(UpdateRooms());
	}

	public override void CLBGGFIOBIB()
	{
		Debug.Log("Mouse Wheel Down");
		Singleton<GameManager>.Instance.INLEIPHNJPF("_EdgeSize");
		GameObject gameObject = playersScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		try
		{
			PhotonNetwork.playerName = string.Empty + SteamUser.GetSteamID();
		}
		catch (Exception)
		{
			PhotonNetwork.playerName = "https://store.steampowered.com/recommended/recommendgame/";
		}
		PhotonNetwork.player.SetTeam(PunTeams.Team.none);
		StartCoroutine(UpdateRooms());
	}

	public void HJONLNNPBMN()
	{
		StartCoroutine(DIBHMOMMNNG());
	}

	public void UpdateRoom()
	{
		Debug.Log("[NetworkManager] Updating current room...");
		if (reciveLevelId)
		{
			if (Singleton<MapsSystem>.Instance.GetMapData(selectedlevelid) != null && Singleton<MapsSystem>.Instance.GetMapData(selectedlevelid).source != FullMapData.MapSource.Editor)
			{
				if ((bool)GameObject.Find("StartButton"))
				{
					if (!IsAllPlayersReady())
					{
						GameObject.Find("StartButton").GetComponentInChildren<Text>().text = ((PhotonNetwork.player.GetTeam() != 0) ? LocalizationService.Instance.GetTextByKey("notready").ToUpper() : LocalizationService.Instance.GetTextByKey("ready").ToUpper());
					}
					else
					{
						GameObject.Find("StartButton").GetComponentInChildren<Text>().text = ((!PhotonNetwork.isMasterClient || !IsAllPlayersReady()) ? LocalizationService.Instance.GetTextByKey("ready").ToUpper() : LocalizationService.Instance.GetTextByKey("start").ToUpper());
					}
					GameObject.Find("StartButton").GetComponent<Button>().interactable = true;
				}
			}
			else if ((bool)GameObject.Find("StartButton"))
			{
				GameObject.Find("StartButton").GetComponentInChildren<Text>().text = LocalizationService.Instance.GetTextByKey("downloading").ToUpper() + "...";
				GameObject.Find("StartButton").GetComponent<Button>().interactable = false;
			}
		}
		Singleton<GameManager>.Instance.UpdateOnlineStatus("In Network lobby", "Waiting to start", PhotonNetwork.room.Name, PhotonNetwork.room.Name, PhotonNetwork.room.PlayerCount, PhotonNetwork.room.MaxPlayers);
	}

	internal void NBAJIDNOAOA(string EAFAMAMDNEG, int DLGIPFOEDCF)
	{
		if (!string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			PhotonNetwork.player.SetTeam(PunTeams.Team.none);
			GameObject gameObject = playersScrollRectContent;
			for (int i = 0; i < gameObject.transform.childCount; i++)
			{
				gameObject.transform.GetChild(i).gameObject.GetComponent<LobbyPlayerElement>().isReady = true;
			}
			if (Singleton<MapsSystem>.Instance.GetMapData(EAFAMAMDNEG) != null && Singleton<MapsSystem>.Instance.GetMapData(EAFAMAMDNEG).mapData != null)
			{
				FDCLIIODNGO("RPCs can only be sent in rooms. Call of \"" + Singleton<MapsSystem>.Instance.GetMapData(EAFAMAMDNEG).mapData.name.Replace("OK", string.Empty).Replace("offsets", string.Empty).Replace("Down ", string.Empty));
				FDCLIIODNGO("CameraFilterPack_eyes_vision_2" + (GameScene.GameMode)DLGIPFOEDCF);
				selectedlevelid = EAFAMAMDNEG;
				selectedmodelid = DLGIPFOEDCF;
				reciveLevelId = true;
				UpdateRoom();
				lobbyPlayer.GKOOCOGHOGJ();
			}
			else
			{
				PhotonNetwork.player.SetTeam(PunTeams.Team.red);
				PublishedFileId_t lIJPBBCJNHD = (PublishedFileId_t)ulong.Parse(EAFAMAMDNEG.Replace("GlassesColor", string.Empty));
				Singleton<MessageBoxPanel>.Instance.GNKJLJNJJFP(LocalizationService.Instance.HOFKLNAJGMK("You did not select a Hosting Type in your PhotonServerSettings. Please set it up or don't use ConnectUsingSettings().").ToUpper() + "AllocateViewID() failed. Room (user {0}) is out of 'scene' viewIDs. It seems all available are in use.", LocalizationService.Instance.NDAPBHEDJFP("note.5").ToUpper(), null, true, false, 1402f);
				selectedlevelid = EAFAMAMDNEG;
				selectedmodelid = DLGIPFOEDCF;
				Singleton<MapsSystem>.Instance.MapSubscribedAndDownloaded += HDKKLFLOHLD;
				Singleton<MapsSystem>.Instance.SubscribeAndDownload(lIJPBBCJNHD);
			}
		}
	}

	public IEnumerator HODELLNPDEJ()
	{
		if (PhotonNetwork.inRoom)
		{
			PhotonNetwork.LeaveRoom();
			while (PhotonNetwork.inRoom)
			{
				yield return null;
			}
		}
		if (PhotonNetwork.insideLobby)
		{
			PhotonNetwork.LeaveLobby();
			while (PhotonNetwork.insideLobby)
			{
				yield return null;
			}
		}
		if (PhotonNetwork.connected)
		{
			PhotonNetwork.Disconnect();
			while (PhotonNetwork.connected)
			{
				yield return null;
			}
		}
		StopAllCoroutines();
		Singleton<GameManager>.Instance.UpdateOnlineStatus("In Main Menu");
		Debug.Log("[NetworkManager] Exited");
		PhotonNetwork.Disconnect();
	}

	public IEnumerator EJMEBIHJEGD()
	{
		if (PhotonNetwork.inRoom)
		{
			PhotonNetwork.LeaveRoom();
			while (PhotonNetwork.inRoom)
			{
				yield return null;
			}
		}
		if (PhotonNetwork.insideLobby)
		{
			PhotonNetwork.LeaveLobby();
			while (PhotonNetwork.insideLobby)
			{
				yield return null;
			}
		}
		if (PhotonNetwork.connected)
		{
			PhotonNetwork.Disconnect();
			while (PhotonNetwork.connected)
			{
				yield return null;
			}
		}
		StopAllCoroutines();
		Singleton<GameManager>.Instance.UpdateOnlineStatus("In Main Menu");
		Debug.Log("[NetworkManager] Exited");
		PhotonNetwork.Disconnect();
	}

	[CompilerGenerated]
	private static void NNNDDGHDLCP()
	{
	}

	public override void OnCreatedRoom()
	{
		ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
		hashtable.Add("roomDescription", roomDescriptionInputField.text);
		hashtable.Add("masterSteamID", PhotonNetwork.playerName);
		PhotonNetwork.room.SetCustomProperties(hashtable);
	}

	private IEnumerator EPIOFCFPDLG()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayInputDialog(LocalizationService.Instance.GetLocalizatedText("#roomname"), LocalizationService.Instance.GetLocalizatedText("#join").ToUpper(), string.Empty));
		JoinRoomByID(Singleton<MessageBoxPanel>.Instance.textResult);
	}

	private IEnumerator BNFMECPNCOA(ulong LFLDPPGGLCL)
	{
		Transform parent = base.transform.parent;
		string text = "workshop." + LFLDPPGGLCL;
		Singleton<MapsSystem>.Instance.LoadLevel(text);
		FullMapData fullMapData = Singleton<MapsSystem>.Instance.levelsData[text];
		if (fullMapData.isLoaded())
		{
			Singleton<MapsSystem>.Instance.LoadLevel(text);
		}
		reciveLevelId = true;
		Singleton<SaveSystem>.Instance.SetString("menu.selectedlevelid", text);
		Singleton<MessageBoxPanel>.Instance.Close();
		UpdateRoom();
		lobbyPlayer.CheckIsReady();
		yield break;
	}

	public IEnumerator GPOBKBBFFGG()
	{
		if (PhotonNetwork.inRoom)
		{
			PhotonNetwork.LeaveRoom();
			while (PhotonNetwork.inRoom)
			{
				yield return null;
			}
		}
		if (PhotonNetwork.insideLobby)
		{
			PhotonNetwork.LeaveLobby();
			while (PhotonNetwork.insideLobby)
			{
				yield return null;
			}
		}
		if (PhotonNetwork.connected)
		{
			PhotonNetwork.Disconnect();
			while (PhotonNetwork.connected)
			{
				yield return null;
			}
		}
		StopAllCoroutines();
		Singleton<GameManager>.Instance.UpdateOnlineStatus("In Main Menu");
		Debug.Log("[NetworkManager] Exited");
		PhotonNetwork.Disconnect();
	}

	public void FGPFJJOCOML()
	{
		StartCoroutine(Singleton<InventorySelector>.Instance.OPLFJNJCHLN(delegate
		{
		}));
	}

	[PunRPC]
	public void RecieveChatMessage(string BHNGOLDNELC, string JKPJCEMPAGH)
	{
		Singleton<MultiplayerSystem>.Instance.AddNewMessage((CSteamID)ulong.Parse(BHNGOLDNELC), JKPJCEMPAGH);
	}

	public void LEFINIALDEP()
	{
		roomNameInputField.text = UnityEngine.Random.Range(-163, 198) + string.Empty;
		roomDescriptionInputField.text = "_Distortion" + SteamFriends.GetFriendPersonaName(SteamUser.GetSteamID());
		roomPrivateToggle.isOn = true;
	}

	public override void EMBFNPAGFIK()
	{
		if (isConnecting)
		{
			Debug.Log(string.Concat("_DX11NoiseTime", PhotonNetwork.JNJJAMNLOHA.CloudRegion, "CameraFilterPack/OldFilm_Cutting2"));
			PhotonNetwork.LeaveLobby();
			PhotonNetwork.JoinLobby();
		}
	}

	public void LGLBEJMADLM(string JMMILEFMACB)
	{
		if (PhotonNetwork.inRoom)
		{
			PhotonNetwork.LeaveRoom();
		}
		StartCoroutine(KJLFOJHECGL(JMMILEFMACB));
	}

	public void HBGBBOHJBII()
	{
		StopAllCoroutines();
		Singleton<GameManager>.Instance.EMFPBLEIEFG("_ScreenResolution", null, null, null, 1, 1);
		if ((bool)GameObject.Find("CameraFilterPack/Drawing_NewCellShading"))
		{
			GameObject.Find("The given 2D texture ").transform.Find("[MapsData] User's maps was loaded").GetComponent<Button>().onClick.Invoke();
		}
	}

	public void OnReadyButton()
	{
		if (!IsAllPlayersReady())
		{
			if (PhotonNetwork.player.GetTeam() == PunTeams.Team.none)
			{
				PhotonNetwork.player.SetTeam(PunTeams.Team.red);
				Singleton<SaveSystem>.Instance.SetString("menu.selectedlevelid", selectedlevelid);
				Singleton<SaveSystem>.Instance.SetInt("menu.selectedplaymode", selectedmodelid);
				lobbyPlayer.photonView.RPC("OnReadyClick", PhotonTargets.All, PhotonNetwork.player);
			}
			else
			{
				PhotonNetwork.player.SetTeam(PunTeams.Team.none);
				lobbyPlayer.photonView.RPC("OnReadyClick", PhotonTargets.All, PhotonNetwork.player);
			}
		}
		else if (PhotonNetwork.isMasterClient)
		{
			Singleton<SaveSystem>.Instance.SetString("menu.selectedlevelid", selectedlevelid);
			Singleton<SaveSystem>.Instance.SetInt("menu.selectedplaymode", selectedmodelid);
			PhotonNetwork.LoadLevel("GameScene");
			PhotonNetwork.room.IsOpen = false;
		}
	}

	private void DOKFAFHFBEO(GameRichPresenceJoinRequested_t OEJIJIPGMCO)
	{
		Debug.Log("[NetworkMenu] Joining " + OEJIJIPGMCO.m_rgchConnect);
		JoinRoomByID(OEJIJIPGMCO.m_rgchConnect);
	}

	public bool IsAllPlayersReady()
	{
		bool result = true;
		PhotonPlayer[] playerList = PhotonNetwork.playerList;
		foreach (PhotonPlayer jHOEDACNNKK in playerList)
		{
			if (jHOEDACNNKK.GetTeam() == PunTeams.Team.none)
			{
				result = false;
			}
		}
		return result;
	}

	private IEnumerator JDIMNMMELCJ()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayInputDialog(LocalizationService.Instance.GetLocalizatedText("#roomname"), LocalizationService.Instance.GetLocalizatedText("#join").ToUpper(), string.Empty));
		JoinRoomByID(Singleton<MessageBoxPanel>.Instance.textResult);
	}

	public void FMKLKALEHHJ()
	{
		IJBFILBDGDO().RPC("BestScoreText", PhotonTargets.All, "id" + ResourcesManager.CFJBGBIOCDD(SteamUser.GetSteamID(), false) + "t");
		PhotonNetwork.LeaveRoom();
		GameObject gameObject = playersScrollRectContent;
		for (int i = 1; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		reciveLevelId = false;
		selectedlevelid = string.Empty;
		StopAllCoroutines();
		OnConnectedToMaster();
		Singleton<MultiplayerSystem>.Instance.DBALDPFKNJM();
	}

	internal void NMFBIIKBKOD(string EAFAMAMDNEG, int DLGIPFOEDCF)
	{
		if (!string.IsNullOrEmpty(EAFAMAMDNEG))
		{
			PhotonNetwork.player.SetTeam(PunTeams.Team.none);
			GameObject gameObject = playersScrollRectContent;
			for (int i = 0; i < gameObject.transform.childCount; i++)
			{
				gameObject.transform.GetChild(i).gameObject.GetComponent<LobbyPlayerElement>().isReady = true;
			}
			if (Singleton<MapsSystem>.Instance.GetMapData(EAFAMAMDNEG) != null && Singleton<MapsSystem>.Instance.GetMapData(EAFAMAMDNEG).mapData != null)
			{
				SendChatActionMessage("_TimeX" + Singleton<MapsSystem>.Instance.GetMapData(EAFAMAMDNEG).mapData.name.Replace("threshold", string.Empty).Replace("_ScreenResolution", string.Empty).Replace("_TimeX", string.Empty));
				SendChatActionMessage("Vertical" + (GameScene.GameMode)DLGIPFOEDCF);
				selectedlevelid = EAFAMAMDNEG;
				selectedmodelid = DLGIPFOEDCF;
				reciveLevelId = false;
				UpdateRoom();
				lobbyPlayer.BOBDANOFGAE();
			}
			else
			{
				PhotonNetwork.player.SetTeam(PunTeams.Team.red);
				PublishedFileId_t lIJPBBCJNHD = (PublishedFileId_t)ulong.Parse(EAFAMAMDNEG.Replace("Connected to NameServer.", string.Empty));
				Singleton<MessageBoxPanel>.Instance.BOKKOAKIDMK(LocalizationService.Instance.MPHMJLAOHAB("player.xp").ToUpper() + "(http|https)://([\\w+?\\.\\w+])+([a-zA-Z0-9\\~\\!\\@\\#\\$\\%\\^\\&amp;\\*\\(\\)_\\-\\=\\+\\\\\\/\\?\\.\\:\\;\\'\\,]*)?\\.(jpg|jpeg|gif|png)", LocalizationService.Instance.JNNKPEBBDEA("_ScreenResolution").ToUpper(), null, false, true, 1437f);
				selectedlevelid = EAFAMAMDNEG;
				selectedmodelid = DLGIPFOEDCF;
				Singleton<MapsSystem>.Instance.MapSubscribedAndDownloaded += HDKKLFLOHLD;
				Singleton<MapsSystem>.Instance.NOIMEBKFCKA(lIJPBBCJNHD);
			}
		}
	}

	public void InitProfileCanvas()
	{
		StartCoroutine(Singleton<InventorySelector>.Instance.DisplayInventory(delegate
		{
		}));
	}

	public void FDCLIIODNGO(string JKPJCEMPAGH)
	{
		PhotonView obj = FFIPLLNKGEN();
		object[] array = new object[0];
		array[0] = JKPJCEMPAGH;
		obj.RPC(" has no method \"", PhotonTargets.OthersBuffered, array);
	}

	public IEnumerator UpdateRooms()
	{
		StopCoroutine(UpdateRooms());
		Singleton<MessageBoxPanel>.Instance.DisplayMessage(LocalizationService.Instance.GetTextByKey("updating").ToUpper() + "...", LocalizationService.Instance.GetTextByKey("cancel").ToUpper(), ExitToMenu);
		yield return new WaitForSeconds(0.5f);
		if (PhotonNetwork.insideLobby && (bool)roomsListContent)
		{
			Debug.Log("[NetworkManager] Updating rooms...");
			GameObject gameObject = roomsListContent;
			for (int i = 0; i < gameObject.transform.childCount; i++)
			{
				UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
			}
			int num = 0;
			Debug.Log("[NetworkManager] Found " + PhotonNetwork.GetRoomList().Length + " room(s)");
			RoomInfo[] roomList = PhotonNetwork.GetRoomList();
			foreach (RoomInfo roomInfo in roomList)
			{
				Debug.Log("[NetworkManager] roomInfo.name: " + roomInfo.Name);
				GameObject gameObject2 = UnityEngine.Object.Instantiate(roomsListElement, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(gameObject.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject2.GetComponent<RoomListItem>().roomInfo = roomInfo;
				ulong num2 = 0uL;
				try
				{
					num2 = ulong.Parse((string)roomInfo.CustomProperties["masterSteamID"]);
				}
				catch (Exception ex)
				{
					Debug.Log(ex.ToString());
				}
				Sprite sprite = null;
				CSteamID cSteamID = new CSteamID(num2);
				if (num2 != 0)
				{
					yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(cSteamID));
					try
					{
						if ((bool)ResourcesManager.GetLoadedAvatar(cSteamID))
						{
							sprite = ResourcesManager.GetLoadedAvatar(cSteamID);
						}
					}
					catch (Exception)
					{
					}
				}
				if ((bool)gameObject2.transform.Find("AvatarImage"))
				{
					gameObject2.transform.Find("AvatarImage").GetComponent<Image>().sprite = sprite;
				}
				if ((bool)gameObject2.transform.Find("RoomNameText"))
				{
					gameObject2.transform.Find("RoomNameText").GetComponent<Text>().text = roomInfo.Name;
				}
				if ((bool)gameObject2.transform.Find("RoomPlayersCountText"))
				{
					gameObject2.transform.Find("RoomPlayersCountText").GetComponent<Text>().text = roomInfo.PlayerCount + "/" + roomInfo.MaxPlayers;
				}
				if ((bool)gameObject2.transform.Find("RoomDescriptionText") && roomInfo.CustomProperties["roomDescription"] != null)
				{
					gameObject2.transform.Find("RoomDescriptionText").GetComponent<Text>().text = (string)roomInfo.CustomProperties["roomDescription"];
				}
				if (!roomInfo.IsOpen && (bool)gameObject2.transform.Find("JoinButton"))
				{
					gameObject2.transform.Find("JoinButton").GetComponent<Button>().interactable = false;
					gameObject2.transform.Find("JoinButton").GetComponent<Button>().GetComponentInChildren<Text>()
						.text = "#alreadystarted";
				}
				num++;
			}
			if (num == 0)
			{
				GameObject gameObject3 = UnityEngine.Object.Instantiate(roomsMessageElement, Vector3.zero, Quaternion.identity);
				gameObject3.transform.SetParent(gameObject.transform, true);
				gameObject3.transform.localScale = new Vector3(1f, 1f, 1f);
				if ((bool)gameObject3.transform.Find("MessageText"))
				{
					gameObject3.transform.Find("MessageText").GetComponent<Text>().text = LocalizationService.Instance.GetTextByKey("nogamesfound").ToUpper();
				}
			}
		}
		else
		{
			StopAllCoroutines();
		}
		yield return null;
		StopAllCoroutines();
		Singleton<MessageBoxPanel>.Instance.Close();
	}

	public bool CKMNOIEBHIJ()
	{
		bool result = true;
		PhotonPlayer[] playerList = PhotonNetwork.playerList;
		for (int i = 1; i < playerList.Length; i++)
		{
			PhotonPlayer jHOEDACNNKK = playerList[i];
			if (jHOEDACNNKK.GetTeam() == PunTeams.Team.none)
			{
				result = true;
			}
		}
		return result;
	}

	public override void OnJoinedRoom()
	{
		Singleton<MessageBoxPanel>.Instance.Close();
		Debug.Log("[NetworkManager] Joined room with " + PhotonNetwork.room.PlayerCount + " player(s)");
		Singleton<MultiplayerSystem>.Instance.AddNewActionMessage("Joined room " + PhotonNetwork.room.Name);
		StopAllCoroutines();
		Singleton<MultiplayerSystem>.Instance.InitChat();
		base.photonView.RPC("RecieveChatActionMessage", PhotonTargets.Others, "[SERVER] Player " + ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(SteamUser.GetSteamID()) + " joined");
		reciveLevelId = false;
		lobbyCanvas.SetActive(true);
		networkCanvas.SetActive(false);
		GameObject.Find("StartButton").GetComponent<Button>().interactable = false;
		if ((bool)GameObject.Find("ChatHistoryInputField"))
		{
			GameObject.Find("ChatHistoryInputField").GetComponent<InputField>().text = string.Empty;
		}
		Singleton<GameManager>.Instance.UpdateOnlineStatus("In Network lobby", "Waiting to start", PhotonNetwork.room.Name, PhotonNetwork.room.Name, PhotonNetwork.room.PlayerCount, PhotonNetwork.room.MaxPlayers);
		GameObject gameObject = playersScrollRectContent;
		GameObject gameObject2 = PhotonNetwork.Instantiate("Gameplay/LobbyPlayerIconElement", new Vector3(0f, 0f, 0f), Quaternion.identity, 0);
		gameObject2.transform.SetParent(gameObject.transform, true);
		gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
		lobbyPlayer = gameObject2.GetComponent<LobbyPlayerElement>();
		lobbyPlayer.Init();
		UpdateRoom();
		base.photonView.RPC("RequestSelectedLevel", PhotonTargets.MasterClient);
	}

	public void IMHOHMBMFBE()
	{
		if (!CKMNOIEBHIJ())
		{
			if (PhotonNetwork.player.GetTeam() == PunTeams.Team.none)
			{
				PhotonNetwork.player.SetTeam(PunTeams.Team.red);
				Singleton<SaveSystem>.Instance.BMHFKLHLOCG("_Value", selectedlevelid);
				Singleton<SaveSystem>.Instance.SetInt("menu.enableselectormusic", selectedmodelid);
				PhotonView obj = lobbyPlayer.JAEJDHHCJJO();
				object[] array = new object[0];
				array[1] = PhotonNetwork.player;
				obj.RPC(" not exist", PhotonTargets.Others, array);
			}
			else
			{
				PhotonNetwork.player.SetTeam(PunTeams.Team.none);
				lobbyPlayer.IJBFILBDGDO().RPC("_Value3", PhotonTargets.All, PhotonNetwork.player);
			}
		}
		else if (PhotonNetwork.isMasterClient)
		{
			Singleton<SaveSystem>.Instance.ELJPKMDFBML("_TimeX", selectedlevelid);
			Singleton<SaveSystem>.Instance.SetInt("_Blue_C", selectedmodelid);
			PhotonNetwork.LoadLevel(": ");
			PhotonNetwork.room.IsOpen = true;
		}
	}

	public override void BAMLNAEDCKM(object[] APELDCFFFOH)
	{
		Debug.Log("_TimeX");
	}

	public void Init()
	{
		isConnecting = true;
		PhotonNetwork.offlineMode = false;
		PhotonNetwork.logLevel = PhotonLogLevel.ErrorsOnly;
		PhotonNetwork.autoJoinLobby = false;
		PhotonNetwork.automaticallySyncScene = true;
		Singleton<MessageBoxPanel>.Instance.DisplayMessage(LocalizationService.Instance.GetTextByKey("connecting").ToUpper() + "...", LocalizationService.Instance.GetTextByKey("cancel").ToUpper(), ExitToMenu);
		if (PhotonNetwork.connected)
		{
			OnConnectedToMaster();
			return;
		}
		Debug.Log("[NetworkManager] Connecting...");
		PhotonNetwork.ConnectUsingSettings(Helpers.GetGameVersion());
	}

	[PunRPC]
	internal void RequestSelectedLevel()
	{
		base.photonView.RPC("ChangeSelectedLevel", PhotonTargets.AllViaServer, selectedlevelid, selectedmodelid);
	}

	public override void OnConnectedToMaster()
	{
		if (isConnecting)
		{
			Debug.Log(string.Concat("[NetworkManager] Connected to ", PhotonNetwork.JNJJAMNLOHA.CloudRegion, " region"));
			PhotonNetwork.LeaveLobby();
			PhotonNetwork.JoinLobby();
		}
	}

	public void LGLEEFDEKPC(ulong BHNGOLDNELC, string JKPJCEMPAGH)
	{
		PhotonView obj = GBHNDHLAJLI();
		object[] array = new object[4];
		array[1] = string.Empty + BHNGOLDNELC;
		array[1] = JKPJCEMPAGH;
		obj.RPC("_FgOverlap", (PhotonTargets)8, array);
	}

	private IEnumerator OFFIFMDADNM(ulong LFLDPPGGLCL)
	{
		Transform parent = base.transform.parent;
		string text = "workshop." + LFLDPPGGLCL;
		Singleton<MapsSystem>.Instance.LoadLevel(text);
		FullMapData fullMapData = Singleton<MapsSystem>.Instance.levelsData[text];
		if (fullMapData.isLoaded())
		{
			Singleton<MapsSystem>.Instance.LoadLevel(text);
		}
		reciveLevelId = true;
		Singleton<SaveSystem>.Instance.SetString("menu.selectedlevelid", text);
		Singleton<MessageBoxPanel>.Instance.Close();
		UpdateRoom();
		lobbyPlayer.CheckIsReady();
		yield break;
	}

	public void SendChatMessage(ulong BHNGOLDNELC, string JKPJCEMPAGH)
	{
		base.photonView.RPC("RecieveChatMessage", PhotonTargets.AllViaServer, string.Empty + BHNGOLDNELC, JKPJCEMPAGH);
	}

	public void MLFHPKHDGKA()
	{
		isConnecting = true;
		StopAllCoroutines();
		StartCoroutine(ODNGNLBMBGM());
	}

	public override void OnPhotonPlayerConnected(PhotonPlayer FKKHMGIGLKM)
	{
		Debug.Log("Player Connected");
		Singleton<GameManager>.Instance.UpdateOnlineStatus("In Network lobby", "Waiting to start", PhotonNetwork.room.Name, PhotonNetwork.room.Name, PhotonNetwork.room.PlayerCount, PhotonNetwork.room.MaxPlayers);
	}

	private IEnumerator IPCGDACEHIO()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayInputDialog(LocalizationService.Instance.GetLocalizatedText("#roomname"), LocalizationService.Instance.GetLocalizatedText("#join").ToUpper(), string.Empty));
		JoinRoomByID(Singleton<MessageBoxPanel>.Instance.textResult);
	}

	public void Awake()
	{
		BPKBDDEPHFK = Callback<GameRichPresenceJoinRequested_t>.Create(DOKFAFHFBEO);
	}

	private IEnumerator DIBHMOMMNNG()
	{
		yield return new WaitUntil(() => UnityEngine.Object.FindObjectOfType<MapsListSelector>() != null);
		yield return StartCoroutine(Singleton<MapsListSelector>.Instance.DisplayMapSelector(Singleton<SaveSystem>.Instance.GetInt("menu.tabid", -1), Singleton<SaveSystem>.Instance.GetInt("menu.playedpage", -1)));
		Singleton<SaveSystem>.Instance.DeleteKey("menu.playedsolo");
		if (!string.IsNullOrEmpty(Singleton<MapsListSelector>.Instance.result))
		{
			Singleton<SaveSystem>.Instance.SetInt("menu.playedpage", Singleton<MapsListSelector>.Instance.currentMapsPageID);
			Singleton<SaveSystem>.Instance.SetInt("menu.tabid", Singleton<MapsListSelector>.Instance.currentMapsTab);
			if (PhotonNetwork.isMasterClient)
			{
				base.photonView.RPC("ChangeSelectedLevel", PhotonTargets.AllBufferedViaServer, Singleton<MapsListSelector>.Instance.result, (int)Singleton<MapsListSelector>.Instance.resultMode);
				yield break;
			}
			base.photonView.RPC("RecieveChatActionMessage", PhotonTargets.AllViaServer, "[" + SteamFriends.GetFriendPersonaName(new CSteamID(ulong.Parse(PhotonNetwork.playerName))) + "] Suggested " + Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapsListSelector>.Instance.result).mapData.name.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty) + " at " + Singleton<MapsListSelector>.Instance.resultMode);
		}
	}

	public void JoinRoomByID(string JMMILEFMACB)
	{
		if (PhotonNetwork.inRoom)
		{
			PhotonNetwork.LeaveRoom();
		}
		StartCoroutine(KJLFOJHECGL(JMMILEFMACB));
	}

	public void GLNALDOEPGK()
	{
		StartCoroutine(UpdateRooms());
	}

	public void ONBOIFALAJG()
	{
		StartCoroutine(UpdateRooms());
	}

	public override void OBCKMEMNPFA(PhotonPlayer MCDOIGNGJBJ)
	{
		Debug.Log("init");
		if (PhotonNetwork.isMasterClient)
		{
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("z", PhotonNetwork.playerName);
			PhotonNetwork.room.AFADNAIGHIG(hashtable, null, true);
		}
		UpdateRoom();
	}

	public IEnumerator NBOPAKLOIBI()
	{
		if (PhotonNetwork.inRoom)
		{
			PhotonNetwork.LeaveRoom();
			while (PhotonNetwork.inRoom)
			{
				yield return null;
			}
		}
		if (PhotonNetwork.insideLobby)
		{
			PhotonNetwork.LeaveLobby();
			while (PhotonNetwork.insideLobby)
			{
				yield return null;
			}
		}
		if (PhotonNetwork.connected)
		{
			PhotonNetwork.Disconnect();
			while (PhotonNetwork.connected)
			{
				yield return null;
			}
		}
		StopAllCoroutines();
		Singleton<GameManager>.Instance.UpdateOnlineStatus("In Main Menu");
		Debug.Log("[NetworkManager] Exited");
		PhotonNetwork.Disconnect();
	}

	public void HOHGOGBHBFO(ulong BHNGOLDNELC, string JKPJCEMPAGH)
	{
		GMAHNPNHMFK().RPC("CameraFilterPack/Color_Sepia", PhotonTargets.Others, string.Empty + BHNGOLDNELC, JKPJCEMPAGH, null, null, null, null, null);
	}

	public override void OIMJJNMHFJP(PhotonPlayer MCDOIGNGJBJ)
	{
		Debug.Log("The used master server address is not available with the subscription currently used. Got to Photon Cloud Dashboard or change URL. Disconnecting.");
		if (PhotonNetwork.isMasterClient)
		{
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("_BlurSize", PhotonNetwork.playerName);
			PhotonNetwork.room.AFADNAIGHIG(hashtable, null, true);
		}
		UpdateRoom();
	}

	[PunRPC]
	public void RecieveChatActionMessage(string JKPJCEMPAGH)
	{
		Singleton<MultiplayerSystem>.Instance.AddNewActionMessage(JKPJCEMPAGH);
	}
}
