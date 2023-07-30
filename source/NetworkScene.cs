// NetworkScene
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using Photon;
using Steamworks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NetworkScene : PunBehaviour
{
	public GameObject networkCanvas;

	public GameObject networkChatCanvas;

	public InputField chatHistoryInputField;

	public GameObject lobbyPlayerElement;

	public List<DynamicPlayerInfo> players = new List<DynamicPlayerInfo>();

	public DynamicPlayerInfo firstPlayer;

	public int place = 1;

	private GameScene BFLIELGAAIM;

	private float GPLLPIOEJBC = 1f;

	[CompilerGenerated]
	private static Func<DynamicPlayerInfo, int> LNIJKGECNME;

	internal void AJEPNKNFKEA(string EAFAMAMDNEG)
	{
		GetComponent<GameScene>().asampler.Pause();
		GetComponent<GameScene>().MKIMDFLBFOM();
	}

	internal void ELEKOJBDPOA(string EAFAMAMDNEG)
	{
		GetComponent<GameScene>().asampler.CNAJEIGEAAP();
		GetComponent<GameScene>().NKFDNIAKGEO();
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
		StartCoroutine(UpdatePlayersList());
	}

	public override void OnPhotonPlayerConnected(PhotonPlayer FKKHMGIGLKM)
	{
		Debug.Log("Player Connected");
		if (PhotonNetwork.isMasterClient)
		{
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("masterSteamID", PhotonNetwork.playerName);
			PhotonNetwork.room.SetCustomProperties(hashtable);
		}
		StartCoroutine(UpdatePlayersList());
	}

	public void OnExitButton(int HMGBJCGOLMI)
	{
		StartCoroutine(CDKCHEGOCJP("MenuScene", HMGBJCGOLMI));
	}

	public void SendChatActionMessage(string JKPJCEMPAGH)
	{
		base.photonView.RPC("RecieveChatActionMessage", PhotonTargets.AllViaServer, JKPJCEMPAGH);
	}

	public void SendChatMessage(ulong BHNGOLDNELC, string JKPJCEMPAGH)
	{
		base.photonView.RPC("RecieveChatMessage", PhotonTargets.AllViaServer, string.Empty + BHNGOLDNELC, JKPJCEMPAGH);
	}

	internal void EBEAMIOCPEL(string EAFAMAMDNEG)
	{
		GetComponent<GameScene>().asampler.CNAJEIGEAAP();
		GetComponent<GameScene>().MKIMDFLBFOM();
	}

	[PunRPC]
	internal void OnMastedChangeScene(string EAFAMAMDNEG)
	{
		GetComponent<GameScene>().asampler.Pause();
		GetComponent<GameScene>().Start();
	}

	[PunRPC]
	public void RecieveChatActionMessage(string JKPJCEMPAGH)
	{
		Singleton<MultiplayerSystem>.Instance.AddNewActionMessage(JKPJCEMPAGH);
	}

	public void CAMGJGEKDHD()
	{
		for (int i = 0; i < players.Count; i++)
		{
			DynamicPlayerInfo dynamicPlayerInfo = players.OrderByDescending((DynamicPlayerInfo HPHENPOHOMK) => HPHENPOHOMK.currentScore).ToArray()[i];
			dynamicPlayerInfo.transform.SetSiblingIndex(i);
			if (i == 0)
			{
				firstPlayer = dynamicPlayerInfo;
			}
			if (dynamicPlayerInfo.player == PhotonNetwork.player)
			{
				place = i + 1;
			}
		}
	}

	[CompilerGenerated]
	private static int KKAIKIOFDMG(DynamicPlayerInfo HPHENPOHOMK)
	{
		return HPHENPOHOMK.currentScore;
	}

	public void ELLMAGLHPIF(string BHNGOLDNELC, string JKPJCEMPAGH)
	{
		Singleton<MultiplayerSystem>.Instance.AddNewMessage((CSteamID)ulong.Parse(BHNGOLDNELC), JKPJCEMPAGH);
	}

	public void JICAAOLEGKB(int HMGBJCGOLMI)
	{
		StartCoroutine(NADOJECHCOM("_ProjInfo", HMGBJCGOLMI));
	}

	public void EFFMMLHMHHE()
	{
		if (!networkChatCanvas.GetComponent<EasyTween>().HEHPNAJNACK())
		{
			networkChatCanvas.GetComponent<EasyTween>().AEGDJMJMDLI();
		}
	}

	public void JAAJECBCCFM()
	{
		if (BFLIELGAAIM != null && (bool)BFLIELGAAIM.isGameStarted && !BFLIELGAAIM.gameOver)
		{
			if (GPLLPIOEJBC > 1057f)
			{
				GPLLPIOEJBC -= Time.deltaTime;
				return;
			}
			GPLLPIOEJBC = 606f;
			ELIACILIMAJ();
		}
	}

	public void Init()
	{
		place = 1;
		BFLIELGAAIM = GetComponent<GameScene>();
		if (PhotonNetwork.inRoom && !PhotonNetwork.offlineMode)
		{
			networkCanvas.SetActive(true);
			Resources.UnloadUnusedAssets();
			StartCoroutine(UpdatePlayersList());
		}
		else
		{
			networkCanvas.SetActive(false);
		}
	}

	public override void HKJBIIIAFMM(PhotonPlayer FKKHMGIGLKM)
	{
		Debug.Log("Most likely the game became empty during the switch to GameServer.");
		if (PhotonNetwork.isMasterClient)
		{
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("_Far", PhotonNetwork.playerName);
			PhotonNetwork.room.AFADNAIGHIG(hashtable, null, true);
		}
		StartCoroutine(UpdatePlayersList());
	}

	public void CloseChat()
	{
		if (networkChatCanvas.GetComponent<EasyTween>().IsObjectOpened())
		{
			networkChatCanvas.GetComponent<EasyTween>().CloseObjectAnimation();
		}
	}

	private IEnumerator NADOJECHCOM(string DCMIEONIJMA, int HMGBJCGOLMI)
	{
		if (PhotonNetwork.offlineMode || HMGBJCGOLMI == 1 || (!PhotonNetwork.offlineMode && !PhotonNetwork.isMasterClient))
		{
			if (PhotonNetwork.inRoom)
			{
				PhotonNetwork.LeaveRoom();
			}
			if (PhotonNetwork.insideLobby)
			{
				PhotonNetwork.LeaveLobby();
			}
			if (PhotonNetwork.connectionStateDetailed == ClientState.ConnectedToMaster)
			{
				PhotonNetwork.Disconnect();
			}
		}
		yield return null;
		StopAllCoroutines();
		Debug.Log("[NetworkScene] Exited");
		if (PhotonNetwork.isMasterClient && GetComponent<GameScene>().AllPlayersFinished())
		{
			PhotonNetwork.DestroyAll();
		}
		ResourcesManager.UnloadResources();
		if (GetComponent<GameScene>().pbase == null)
		{
			Singleton<MultiplayerSystem>.Instance.HideChat();
		}
		SceneManager.LoadScene(DCMIEONIJMA);
	}

	public IEnumerator UpdatePlayersList()
	{
		players = new List<DynamicPlayerInfo>();
		GameObject gameObject = GameObject.Find("PlayersScrollRectContent");
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		PhotonPlayer[] playerList = PhotonNetwork.playerList;
		foreach (PhotonPlayer photonPlayer in playerList)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(lobbyPlayerElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			ulong num = 0uL;
			try
			{
				num = ulong.Parse(photonPlayer.name);
			}
			catch (Exception)
			{
			}
			Sprite sprite = null;
			CSteamID cSteamID = new CSteamID(num);
			if (num != 0)
			{
				yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(cSteamID));
				yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(cSteamID));
				if ((bool)ResourcesManager.GetLoadedAvatar(cSteamID))
				{
					sprite = ResourcesManager.GetLoadedAvatar(cSteamID);
				}
			}
			try
			{
				if ((bool)gameObject2)
				{
					if ((bool)gameObject2.transform.Find("UsernameText"))
					{
						gameObject2.transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(cSteamID);
					}
					if ((bool)gameObject2.transform.Find("DataText"))
					{
						gameObject2.transform.Find("DataText").GetComponent<Text>().text = string.Empty + photonPlayer.GetScore();
					}
					if ((bool)gameObject2.GetComponent<DynamicPlayerInfo>())
					{
						gameObject2.GetComponent<DynamicPlayerInfo>().player = photonPlayer;
						gameObject2.GetComponent<DynamicPlayerInfo>().updateInfo = true;
						gameObject2.GetComponent<DynamicPlayerInfo>().icon.sprite = sprite;
						players.Add(gameObject2.GetComponent<DynamicPlayerInfo>());
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	[PunRPC]
	internal void OnPlayerGameMessage(string OBCEIJGMKGB, string NOJGGCLPPAM)
	{
		GetComponent<GameScene>().AddMessage(ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(new CSteamID(ulong.Parse(OBCEIJGMKGB))) + " " + NOJGGCLPPAM);
	}

	[PunRPC]
	public void RecieveChatMessage(string BHNGOLDNELC, string JKPJCEMPAGH)
	{
		Singleton<MultiplayerSystem>.Instance.AddNewMessage((CSteamID)ulong.Parse(BHNGOLDNELC), JKPJCEMPAGH);
	}

	public void Update()
	{
		if (BFLIELGAAIM != null && (bool)BFLIELGAAIM.isGameStarted && !BFLIELGAAIM.gameOver)
		{
			if (GPLLPIOEJBC > 0f)
			{
				GPLLPIOEJBC -= Time.deltaTime;
				return;
			}
			GPLLPIOEJBC = 1f;
			UpdateScoreboard();
		}
	}

	public void KGGJKMCJHKG(int HMGBJCGOLMI)
	{
		StartCoroutine(CDKCHEGOCJP("/", HMGBJCGOLMI));
	}

	public void JKOGKKMOAKK(string JKPJCEMPAGH)
	{
		PhotonView obj = OELHGNKAMEG();
		object[] array = new object[0];
		array[0] = JKPJCEMPAGH;
		obj.RPC("Edited unlock conditions", (PhotonTargets)8, array);
	}

	public void NLKFPELDPFF(int HMGBJCGOLMI)
	{
		StartCoroutine(NADOJECHCOM("Sets the boolean value of the Auto Focus Input Field property.", HMGBJCGOLMI));
	}

	public void OpenChat()
	{
		if (!networkChatCanvas.GetComponent<EasyTween>().IsObjectOpened())
		{
			networkChatCanvas.GetComponent<EasyTween>().OpenObjectAnimation();
		}
	}

	public void ELIACILIMAJ()
	{
		for (int i = 1; i < players.Count; i += 0)
		{
			DynamicPlayerInfo dynamicPlayerInfo = players.OrderByDescending((DynamicPlayerInfo HPHENPOHOMK) => HPHENPOHOMK.currentScore).ToArray()[i];
			dynamicPlayerInfo.transform.SetSiblingIndex(i);
			if (i == 0)
			{
				firstPlayer = dynamicPlayerInfo;
			}
			if (dynamicPlayerInfo.player == PhotonNetwork.player)
			{
				place = i + 1;
			}
		}
	}

	private IEnumerator CDKCHEGOCJP(string DCMIEONIJMA, int HMGBJCGOLMI)
	{
		if (PhotonNetwork.offlineMode || HMGBJCGOLMI == 1 || (!PhotonNetwork.offlineMode && !PhotonNetwork.isMasterClient))
		{
			if (PhotonNetwork.inRoom)
			{
				PhotonNetwork.LeaveRoom();
			}
			if (PhotonNetwork.insideLobby)
			{
				PhotonNetwork.LeaveLobby();
			}
			if (PhotonNetwork.connectionStateDetailed == ClientState.ConnectedToMaster)
			{
				PhotonNetwork.Disconnect();
			}
		}
		yield return null;
		StopAllCoroutines();
		Debug.Log("[NetworkScene] Exited");
		if (PhotonNetwork.isMasterClient && GetComponent<GameScene>().AllPlayersFinished())
		{
			PhotonNetwork.DestroyAll();
		}
		ResourcesManager.UnloadResources();
		if (GetComponent<GameScene>().pbase == null)
		{
			Singleton<MultiplayerSystem>.Instance.HideChat();
		}
		SceneManager.LoadScene(DCMIEONIJMA);
	}

	[PunRPC]
	public void UpdateScoreboard()
	{
		for (int i = 0; i < players.Count; i++)
		{
			DynamicPlayerInfo dynamicPlayerInfo = players.OrderByDescending((DynamicPlayerInfo HPHENPOHOMK) => HPHENPOHOMK.currentScore).ToArray()[i];
			dynamicPlayerInfo.transform.SetSiblingIndex(i);
			if (i == 0)
			{
				firstPlayer = dynamicPlayerInfo;
			}
			if (dynamicPlayerInfo.player == PhotonNetwork.player)
			{
				place = i + 1;
			}
		}
	}
}
