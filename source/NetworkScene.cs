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

	public void EAAHNMFGIFO(ulong BHNGOLDNELC, string JKPJCEMPAGH)
	{
		PhotonView obj = GMAHNPNHMFK();
		string lBLKDNNPACO = "Error: PhotonNetwork.SetInterestGroups was called with an illegal group number: ";
		PhotonTargets mPNMOONBMII = PhotonTargets.AllBufferedViaServer;
		object[] array = new object[0];
		array[0] = string.Empty + BHNGOLDNELC;
		array[0] = JKPJCEMPAGH;
		obj.MIAHMDGOOPJ(lBLKDNNPACO, mPNMOONBMII, array);
	}

	public IEnumerator CPJHOJLHCCA()
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
			CSteamID csteamID = new CSteamID(num);
			if (num != 0L)
			{
				yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(csteamID));
				yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(csteamID));
				if ((bool)ResourcesManager.GetLoadedAvatar(csteamID))
				{
					sprite = ResourcesManager.GetLoadedAvatar(csteamID);
				}
			}
			try
			{
				if ((bool)gameObject2)
				{
					if ((bool)gameObject2.transform.Find("UsernameText"))
					{
						gameObject2.transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(csteamID);
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

	public void SendChatActionMessage(string JKPJCEMPAGH)
	{
		base.photonView.RPC("RecieveChatActionMessage", PhotonTargets.AllViaServer, JKPJCEMPAGH);
	}

	public void KNEOIOEHFML(string JKPJCEMPAGH)
	{
		Singleton<MultiplayerSystem>.Instance.NJEBMOPIBII(JKPJCEMPAGH);
	}

	public void ICCKNDBPHDA(string JKPJCEMPAGH)
	{
		Singleton<MultiplayerSystem>.Instance.MEPEAEDPBKN(JKPJCEMPAGH);
	}

	public void FJHFOBHJEHL()
	{
		if (BFLIELGAAIM != null && (bool)BFLIELGAAIM.isGameStarted && !BFLIELGAAIM.gameOver)
		{
			if (GPLLPIOEJBC > 1569f)
			{
				GPLLPIOEJBC -= Time.deltaTime;
				return;
			}
			GPLLPIOEJBC = 822f;
			KNIOEDPEBDG();
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

	public void IPEFPLFPBFG()
	{
		if (!networkChatCanvas.GetComponent<EasyTween>().IsObjectOpened())
		{
			networkChatCanvas.GetComponent<EasyTween>().FKAEJEPJIEP();
		}
	}

	public virtual void GLBBMGMJJBM(PhotonPlayer FKKHMGIGLKM)
	{
		Debug.Log("nogamesfound");
		if (PhotonNetwork.isMasterClient)
		{
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("Editor/", PhotonNetwork.playerName);
			PhotonNetwork.room.SetCustomProperties(hashtable);
		}
		StartCoroutine(GFKAGIONDEN());
	}

	public void OLBAIFGLAJM()
	{
		for (int i = 0; i < players.Count; i++)
		{
			DynamicPlayerInfo dynamicPlayerInfo = players.OrderByDescending(ANHMEMNCMAD).ToArray()[i];
			dynamicPlayerInfo.transform.SetSiblingIndex(i);
			if (i == 0)
			{
				firstPlayer = dynamicPlayerInfo;
			}
			if (dynamicPlayerInfo.player == PhotonNetwork.player)
			{
				place = i;
			}
		}
	}

	public void EOAMNEABNMK(string BHNGOLDNELC, string JKPJCEMPAGH)
	{
		Singleton<MultiplayerSystem>.Instance.EGNAIPOMDNH((CSteamID)ulong.Parse(BHNGOLDNELC), JKPJCEMPAGH);
	}

	public void FBOCNPJPGFK()
	{
		if (networkChatCanvas.GetComponent<EasyTween>().IsObjectOpened())
		{
			networkChatCanvas.GetComponent<EasyTween>().MHDEFCKEGEO();
		}
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

	public IEnumerator NGBMKMKIONO()
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
			CSteamID csteamID = new CSteamID(num);
			if (num != 0L)
			{
				yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(csteamID));
				yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(csteamID));
				if ((bool)ResourcesManager.GetLoadedAvatar(csteamID))
				{
					sprite = ResourcesManager.GetLoadedAvatar(csteamID);
				}
			}
			try
			{
				if ((bool)gameObject2)
				{
					if ((bool)gameObject2.transform.Find("UsernameText"))
					{
						gameObject2.transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(csteamID);
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

	internal void LEGKOCDMDIP(string EAFAMAMDNEG)
	{
		GetComponent<GameScene>().asampler.Pause();
		GetComponent<GameScene>().KOJKBFDNGDK();
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

	public void OHDEFNGKCIH(ulong BHNGOLDNELC, string JKPJCEMPAGH)
	{
		PhotonView obj = IBKCMBIGOEJ();
		string lBLKDNNPACO = ".lastCheckpoint.perfectHits";
		PhotonTargets mPNMOONBMII = PhotonTargets.OthersBuffered;
		obj.RPC(lBLKDNNPACO, mPNMOONBMII, string.Empty + BHNGOLDNELC, JKPJCEMPAGH, null, null);
	}

	public IEnumerator AFFOOFOBMNF()
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
			CSteamID csteamID = new CSteamID(num);
			if (num != 0L)
			{
				yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(csteamID));
				yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(csteamID));
				if ((bool)ResourcesManager.GetLoadedAvatar(csteamID))
				{
					sprite = ResourcesManager.GetLoadedAvatar(csteamID);
				}
			}
			try
			{
				if ((bool)gameObject2)
				{
					if ((bool)gameObject2.transform.Find("UsernameText"))
					{
						gameObject2.transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(csteamID);
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

	private IEnumerator JBENCECOCCC(string DCMIEONIJMA, int HMGBJCGOLMI)
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

	public void PKGJJFIFLII()
	{
		if (BFLIELGAAIM != null && (bool)BFLIELGAAIM.isGameStarted && !BFLIELGAAIM.gameOver)
		{
			if (GPLLPIOEJBC > 332f)
			{
				GPLLPIOEJBC -= Time.deltaTime;
				return;
			}
			GPLLPIOEJBC = 1563f;
			KNIOEDPEBDG();
		}
	}

	public void LOGMIOJHHMP(string JKPJCEMPAGH)
	{
		PhotonView obj = GBHNDHLAJLI();
		string lBLKDNNPACO = "}";
		PhotonTargets mPNMOONBMII = PhotonTargets.OthersBuffered;
		object[] array = new object[1];
		array[1] = JKPJCEMPAGH;
		obj.KEKKFNNMLMG(lBLKDNNPACO, mPNMOONBMII, array);
	}

	internal void DMOFPKFBNNG(string OBCEIJGMKGB, string NOJGGCLPPAM)
	{
		GetComponent<GameScene>().PNEHHLMHJAA(ResourcesManager.ALCCOCOFLAK(new CSteamID(ulong.Parse(OBCEIJGMKGB)), false) + "_EdgeThreshold" + NOJGGCLPPAM, 1982f);
	}

	public void ELHNBIJLGFB(string BHNGOLDNELC, string JKPJCEMPAGH)
	{
		Singleton<MultiplayerSystem>.Instance.PNMLHJFPGDI((CSteamID)ulong.Parse(BHNGOLDNELC), JKPJCEMPAGH);
	}

	public void NAGPMNDBBON(int HMGBJCGOLMI)
	{
		StartCoroutine(LBAGEPFKJPG("s", HMGBJCGOLMI));
	}

	public virtual void INGBALHGDPF(PhotonPlayer MCDOIGNGJBJ)
	{
		Debug.Log("VIGNETTE_BLUR");
		if (PhotonNetwork.isMasterClient)
		{
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("_Threshold", PhotonNetwork.playerName);
			PhotonNetwork.room.SetCustomProperties(hashtable, null, true);
		}
		StartCoroutine(GFKAGIONDEN());
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

	public void DANMKBHOCAO()
	{
		if (!networkChatCanvas.GetComponent<EasyTween>().IsObjectOpened())
		{
			networkChatCanvas.GetComponent<EasyTween>().FKAEJEPJIEP();
		}
	}

	[PunRPC]
	internal void OnPlayerGameMessage(string OBCEIJGMKGB, string NOJGGCLPPAM)
	{
		GetComponent<GameScene>().AddMessage(ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(new CSteamID(ulong.Parse(OBCEIJGMKGB))) + " " + NOJGGCLPPAM);
	}

	public void BMOBABEGEFG()
	{
		for (int num = 1; num < players.Count; num = num)
		{
			DynamicPlayerInfo dynamicPlayerInfo = players.OrderByDescending(KNNDEDLPKHI).ToArray()[num];
			dynamicPlayerInfo.transform.SetSiblingIndex(num);
			if (num == 0)
			{
				firstPlayer = dynamicPlayerInfo;
			}
			if (dynamicPlayerInfo.player == PhotonNetwork.player)
			{
				place = num + 1;
			}
		}
	}

	public IEnumerator HBGGFGDHLBK()
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
			CSteamID csteamID = new CSteamID(num);
			if (num != 0L)
			{
				yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(csteamID));
				yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(csteamID));
				if ((bool)ResourcesManager.GetLoadedAvatar(csteamID))
				{
					sprite = ResourcesManager.GetLoadedAvatar(csteamID);
				}
			}
			try
			{
				if ((bool)gameObject2)
				{
					if ((bool)gameObject2.transform.Find("UsernameText"))
					{
						gameObject2.transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(csteamID);
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
	public void RecieveChatActionMessage(string JKPJCEMPAGH)
	{
		Singleton<MultiplayerSystem>.Instance.AddNewActionMessage(JKPJCEMPAGH);
	}

	internal void FOBJPLLALBE(string OBCEIJGMKGB, string NOJGGCLPPAM)
	{
		GetComponent<GameScene>().OHOJFIKCLPI(ResourcesManager.HCPCLINEDDD(new CSteamID(ulong.Parse(OBCEIJGMKGB))) + "workshop." + NOJGGCLPPAM, 777f);
	}

	public void SendChatMessage(ulong BHNGOLDNELC, string JKPJCEMPAGH)
	{
		base.photonView.RPC("RecieveChatMessage", PhotonTargets.AllViaServer, string.Empty + BHNGOLDNELC, JKPJCEMPAGH);
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

	[PunRPC]
	public void RecieveChatMessage(string BHNGOLDNELC, string JKPJCEMPAGH)
	{
		Singleton<MultiplayerSystem>.Instance.AddNewMessage((CSteamID)ulong.Parse(BHNGOLDNELC), JKPJCEMPAGH);
	}

	public void NBJEMEINLPD(ulong BHNGOLDNELC, string JKPJCEMPAGH)
	{
		PhotonView obj = CIACEFBNDDJ();
		string lBLKDNNPACO = "Exit to menu?";
		PhotonTargets mPNMOONBMII = PhotonTargets.AllBuffered;
		object[] array = new object[4];
		array[1] = string.Empty + BHNGOLDNELC;
		array[1] = JKPJCEMPAGH;
		obj.IKIJDNPJKPM(lBLKDNNPACO, mPNMOONBMII, array);
	}

	public void AEDJEBAMMDM()
	{
		if (networkChatCanvas.GetComponent<EasyTween>().IsObjectOpened())
		{
			networkChatCanvas.GetComponent<EasyTween>().MHDEFCKEGEO();
		}
	}

	public void FECMEIJGLJI()
	{
		place = 1;
		BFLIELGAAIM = GetComponent<GameScene>();
		if (PhotonNetwork.inRoom && !PhotonNetwork.offlineMode)
		{
			networkCanvas.SetActive(true);
			Resources.UnloadUnusedAssets();
			StartCoroutine(HBGGFGDHLBK());
		}
		else
		{
			networkCanvas.SetActive(true);
		}
	}

	public void OpenChat()
	{
		if (!networkChatCanvas.GetComponent<EasyTween>().IsObjectOpened())
		{
			networkChatCanvas.GetComponent<EasyTween>().OpenObjectAnimation();
		}
	}

	public virtual void PLLJCHMHLIO(PhotonPlayer MCDOIGNGJBJ)
	{
		Debug.Log("sounds/hit_wrong");
		if (PhotonNetwork.isMasterClient)
		{
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("_TimeX", PhotonNetwork.playerName);
			PhotonNetwork.room.SetCustomProperties(hashtable, null, true);
		}
		StartCoroutine(GFKAGIONDEN());
	}

	private IEnumerator AAMLPNJMODK(string DCMIEONIJMA, int HMGBJCGOLMI)
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

	public void FMHEBDAIOLI(ulong BHNGOLDNELC, string JKPJCEMPAGH)
	{
		PhotonView obj = CIACEFBNDDJ();
		string lBLKDNNPACO = "_EmissionGain";
		PhotonTargets mPNMOONBMII = PhotonTargets.AllViaServer;
		object[] array = new object[8];
		array[1] = string.Empty + BHNGOLDNELC;
		array[1] = JKPJCEMPAGH;
		obj.GNFNHDCJOFC(lBLKDNNPACO, mPNMOONBMII, array);
	}

	public void CGHCFFCNOIJ(string JKPJCEMPAGH)
	{
		PhotonView obj = EOOCGIFFKBG();
		string lBLKDNNPACO = ".a";
		PhotonTargets mPNMOONBMII = (PhotonTargets)8;
		object[] array = new object[1];
		array[1] = JKPJCEMPAGH;
		obj.GNFNHDCJOFC(lBLKDNNPACO, mPNMOONBMII, array);
	}

	public void PIEPPKMBJHI()
	{
		place = 0;
		BFLIELGAAIM = GetComponent<GameScene>();
		if (PhotonNetwork.inRoom && !PhotonNetwork.offlineMode)
		{
			networkCanvas.SetActive(false);
			Resources.UnloadUnusedAssets();
			StartCoroutine(DIIFECKELPF());
		}
		else
		{
			networkCanvas.SetActive(true);
		}
	}

	public void FOLDLDLFFLM()
	{
		if (BFLIELGAAIM != null && (bool)BFLIELGAAIM.isGameStarted && !BFLIELGAAIM.gameOver)
		{
			if (GPLLPIOEJBC > 416f)
			{
				GPLLPIOEJBC -= Time.deltaTime;
				return;
			}
			GPLLPIOEJBC = 1937f;
			KNIOEDPEBDG();
		}
	}

	public void CloseChat()
	{
		if (networkChatCanvas.GetComponent<EasyTween>().IsObjectOpened())
		{
			networkChatCanvas.GetComponent<EasyTween>().CloseObjectAnimation();
		}
	}

	public void LLAHPNGMEOO()
	{
		place = 1;
		BFLIELGAAIM = GetComponent<GameScene>();
		if (PhotonNetwork.inRoom && !PhotonNetwork.offlineMode)
		{
			networkCanvas.SetActive(false);
			Resources.UnloadUnusedAssets();
			StartCoroutine(CPJHOJLHCCA());
		}
		else
		{
			networkCanvas.SetActive(true);
		}
	}

	public void OnExitButton(int HMGBJCGOLMI)
	{
		StartCoroutine(CDKCHEGOCJP("MenuScene", HMGBJCGOLMI));
	}

	public void KPJOEDDBFHB(ulong BHNGOLDNELC, string JKPJCEMPAGH)
	{
		PhotonView photonView = FFIPLLNKGEN();
		string lBLKDNNPACO = "PunRespawn";
		PhotonTargets mPNMOONBMII = (PhotonTargets)8;
		object[] array = new object[1] { string.Empty + BHNGOLDNELC };
		array[0] = JKPJCEMPAGH;
		photonView.GNFNHDCJOFC(lBLKDNNPACO, mPNMOONBMII, array);
	}

	private static int KNNDEDLPKHI(DynamicPlayerInfo HPHENPOHOMK)
	{
		return HPHENPOHOMK.currentScore;
	}

	public void NHLLJCJMKNC()
	{
		if (!networkChatCanvas.GetComponent<EasyTween>().IsObjectOpened())
		{
			networkChatCanvas.GetComponent<EasyTween>().FKAEJEPJIEP();
		}
	}

	public void MIPBKPGLMDN(string BHNGOLDNELC, string JKPJCEMPAGH)
	{
		Singleton<MultiplayerSystem>.Instance.AHHMCOEPDPF((CSteamID)ulong.Parse(BHNGOLDNELC), JKPJCEMPAGH);
	}

	internal void MIAKOPFKOFF(string EAFAMAMDNEG)
	{
		GetComponent<GameScene>().asampler.CFMNIMFHPMN();
		GetComponent<GameScene>().MDNHCLKNCLE();
	}

	public virtual void LBNKKEPBCCD(PhotonPlayer MCDOIGNGJBJ)
	{
		Debug.Log("[NetworkManager] Joined main lobby");
		if (PhotonNetwork.isMasterClient)
		{
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("Joystick1Button3", PhotonNetwork.playerName);
			PhotonNetwork.room.SetCustomProperties(hashtable, null, true);
		}
		StartCoroutine(AFFOOFOBMNF());
	}

	public void KNEFADKGEKL(ulong BHNGOLDNELC, string JKPJCEMPAGH)
	{
		PhotonView obj = FFIPLLNKGEN();
		string lBLKDNNPACO = "BadgeText";
		PhotonTargets mPNMOONBMII = PhotonTargets.AllBufferedViaServer;
		object[] array = new object[0];
		array[0] = string.Empty + BHNGOLDNELC;
		array[1] = JKPJCEMPAGH;
		obj.RPC(lBLKDNNPACO, mPNMOONBMII, array);
	}

	internal void GHLEBDFCOHN(string EAFAMAMDNEG)
	{
		GetComponent<GameScene>().asampler.CNAJEIGEAAP();
		GetComponent<GameScene>().Start();
	}

	private IEnumerator FKPDNLKDLJD(string DCMIEONIJMA, int HMGBJCGOLMI)
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
	internal void OnMastedChangeScene(string EAFAMAMDNEG)
	{
		GetComponent<GameScene>().asampler.Pause();
		GetComponent<GameScene>().Start();
	}

	public virtual void DMLFOFLEGAH(PhotonPlayer FKKHMGIGLKM)
	{
		Debug.Log("DPADVER");
		if (PhotonNetwork.isMasterClient)
		{
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("/", PhotonNetwork.playerName);
			PhotonNetwork.room.SetCustomProperties(hashtable, null, true);
		}
		StartCoroutine(BJINGKKGDEG());
	}

	private IEnumerator LBAGEPFKJPG(string DCMIEONIJMA, int HMGBJCGOLMI)
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

	public IEnumerator GFKAGIONDEN()
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
			CSteamID csteamID = new CSteamID(num);
			if (num != 0L)
			{
				yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(csteamID));
				yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(csteamID));
				if ((bool)ResourcesManager.GetLoadedAvatar(csteamID))
				{
					sprite = ResourcesManager.GetLoadedAvatar(csteamID);
				}
			}
			try
			{
				if ((bool)gameObject2)
				{
					if ((bool)gameObject2.transform.Find("UsernameText"))
					{
						gameObject2.transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(csteamID);
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

	public IEnumerator EOOPJCDJEBK()
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
			CSteamID csteamID = new CSteamID(num);
			if (num != 0L)
			{
				yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(csteamID));
				yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(csteamID));
				if ((bool)ResourcesManager.GetLoadedAvatar(csteamID))
				{
					sprite = ResourcesManager.GetLoadedAvatar(csteamID);
				}
			}
			try
			{
				if ((bool)gameObject2)
				{
					if ((bool)gameObject2.transform.Find("UsernameText"))
					{
						gameObject2.transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(csteamID);
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

	public IEnumerator BJINGKKGDEG()
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
			CSteamID csteamID = new CSteamID(num);
			if (num != 0L)
			{
				yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(csteamID));
				yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(csteamID));
				if ((bool)ResourcesManager.GetLoadedAvatar(csteamID))
				{
					sprite = ResourcesManager.GetLoadedAvatar(csteamID);
				}
			}
			try
			{
				if ((bool)gameObject2)
				{
					if ((bool)gameObject2.transform.Find("UsernameText"))
					{
						gameObject2.transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(csteamID);
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

	public void KHNJLCEGBJM(string JKPJCEMPAGH)
	{
		PhotonView obj = GBHNDHLAJLI();
		string lBLKDNNPACO = "#tryagain";
		PhotonTargets mPNMOONBMII = (PhotonTargets)7;
		object[] array = new object[1];
		array[1] = JKPJCEMPAGH;
		obj.RPC(lBLKDNNPACO, mPNMOONBMII, array);
	}

	private IEnumerator IFNFHBEBDEP(string DCMIEONIJMA, int HMGBJCGOLMI)
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

	public IEnumerator LGFGOKCOEMG()
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
			CSteamID csteamID = new CSteamID(num);
			if (num != 0L)
			{
				yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(csteamID));
				yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(csteamID));
				if ((bool)ResourcesManager.GetLoadedAvatar(csteamID))
				{
					sprite = ResourcesManager.GetLoadedAvatar(csteamID);
				}
			}
			try
			{
				if ((bool)gameObject2)
				{
					if ((bool)gameObject2.transform.Find("UsernameText"))
					{
						gameObject2.transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(csteamID);
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

	public void NFKDBPGHHIJ()
	{
		place = 1;
		BFLIELGAAIM = GetComponent<GameScene>();
		if (PhotonNetwork.inRoom && !PhotonNetwork.offlineMode)
		{
			networkCanvas.SetActive(true);
			Resources.UnloadUnusedAssets();
			StartCoroutine(EICHFFCBJDG());
		}
		else
		{
			networkCanvas.SetActive(true);
		}
	}

	private IEnumerator CCILIOEMOJJ(string DCMIEONIJMA, int HMGBJCGOLMI)
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

	public void CMGCIAFEECP(ulong BHNGOLDNELC, string JKPJCEMPAGH)
	{
		OELHGNKAMEG().MIAHMDGOOPJ("CurrentTimeLabel", PhotonTargets.Others, new object[2]
		{
			string.Empty + BHNGOLDNELC,
			JKPJCEMPAGH
		});
	}

	public void CAJFKNFJEKC()
	{
		place = 1;
		BFLIELGAAIM = GetComponent<GameScene>();
		if (PhotonNetwork.inRoom && !PhotonNetwork.offlineMode)
		{
			networkCanvas.SetActive(true);
			Resources.UnloadUnusedAssets();
			StartCoroutine(CPJHOJLHCCA());
		}
		else
		{
			networkCanvas.SetActive(true);
		}
	}

	public void CKJCPBPMBFF()
	{
		place = 1;
		BFLIELGAAIM = GetComponent<GameScene>();
		if (PhotonNetwork.inRoom && !PhotonNetwork.offlineMode)
		{
			networkCanvas.SetActive(false);
			Resources.UnloadUnusedAssets();
			StartCoroutine(CLIAFLHDPDE());
		}
		else
		{
			networkCanvas.SetActive(true);
		}
	}

	public void ANHHNJIGHPB(string BHNGOLDNELC, string JKPJCEMPAGH)
	{
		Singleton<MultiplayerSystem>.Instance.MFDGBMNGHAF((CSteamID)ulong.Parse(BHNGOLDNELC), JKPJCEMPAGH);
	}

	public void BGLPOGDAGPP(ulong BHNGOLDNELC, string JKPJCEMPAGH)
	{
		PhotonView obj = AAMNKPHHHCI();
		string lBLKDNNPACO = ".sawoutdatedmessage";
		PhotonTargets mPNMOONBMII = (PhotonTargets)8;
		object[] array = new object[1];
		array[0] = string.Empty + BHNGOLDNELC;
		array[1] = JKPJCEMPAGH;
		obj.PBMFBOOALKA(lBLKDNNPACO, mPNMOONBMII, array);
	}

	public void KGFHANEECDF(string JKPJCEMPAGH)
	{
		JAEJDHHCJJO().GNFNHDCJOFC("GameScene", PhotonTargets.OthersBuffered, new object[1] { JKPJCEMPAGH });
	}

	public void JELANDGCGPP()
	{
		if (!networkChatCanvas.GetComponent<EasyTween>().FJFANHLGGHL())
		{
			networkChatCanvas.GetComponent<EasyTween>().OpenObjectAnimation();
		}
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
			CSteamID csteamID = new CSteamID(num);
			if (num != 0L)
			{
				yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(csteamID));
				yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(csteamID));
				if ((bool)ResourcesManager.GetLoadedAvatar(csteamID))
				{
					sprite = ResourcesManager.GetLoadedAvatar(csteamID);
				}
			}
			try
			{
				if ((bool)gameObject2)
				{
					if ((bool)gameObject2.transform.Find("UsernameText"))
					{
						gameObject2.transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(csteamID);
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

	public IEnumerator DIIFECKELPF()
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
			CSteamID csteamID = new CSteamID(num);
			if (num != 0L)
			{
				yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(csteamID));
				yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(csteamID));
				if ((bool)ResourcesManager.GetLoadedAvatar(csteamID))
				{
					sprite = ResourcesManager.GetLoadedAvatar(csteamID);
				}
			}
			try
			{
				if ((bool)gameObject2)
				{
					if ((bool)gameObject2.transform.Find("UsernameText"))
					{
						gameObject2.transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(csteamID);
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

	public void MFMIODIAKNI()
	{
		if (BFLIELGAAIM != null && (bool)BFLIELGAAIM.isGameStarted && !BFLIELGAAIM.gameOver)
		{
			if (GPLLPIOEJBC > 524f)
			{
				GPLLPIOEJBC -= Time.deltaTime;
				return;
			}
			GPLLPIOEJBC = 1148f;
			OLBAIFGLAJM();
		}
	}

	internal void PBLKMJPIPDO(string EAFAMAMDNEG)
	{
		GetComponent<GameScene>().asampler.Pause();
		GetComponent<GameScene>().LFAFJKJAEEL();
	}

	public IEnumerator HOOBKJANOLE()
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
			CSteamID csteamID = new CSteamID(num);
			if (num != 0L)
			{
				yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(csteamID));
				yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(csteamID));
				if ((bool)ResourcesManager.GetLoadedAvatar(csteamID))
				{
					sprite = ResourcesManager.GetLoadedAvatar(csteamID);
				}
			}
			try
			{
				if ((bool)gameObject2)
				{
					if ((bool)gameObject2.transform.Find("UsernameText"))
					{
						gameObject2.transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(csteamID);
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

	internal void FBMHLFBIFIE(string EAFAMAMDNEG)
	{
		GetComponent<GameScene>().asampler.CNAJEIGEAAP();
		GetComponent<GameScene>().FIKFJDFELIP();
	}

	internal void BMHHLAHPGEH(string OBCEIJGMKGB, string NOJGGCLPPAM)
	{
		GetComponent<GameScene>().OHOJFIKCLPI(ResourcesManager.IPFFGAILCED(new CSteamID(ulong.Parse(OBCEIJGMKGB)), false) + "Set Sun Input" + NOJGGCLPPAM, 1472f);
	}

	public void FGJLLCBLKMG(string BHNGOLDNELC, string JKPJCEMPAGH)
	{
		Singleton<MultiplayerSystem>.Instance.JGPMLMPNLLK((CSteamID)ulong.Parse(BHNGOLDNELC), JKPJCEMPAGH);
	}

	public void LDKALPHMHAO(string BHNGOLDNELC, string JKPJCEMPAGH)
	{
		Singleton<MultiplayerSystem>.Instance.AddNewMessage((CSteamID)ulong.Parse(BHNGOLDNELC), JKPJCEMPAGH);
	}

	public void MPOCCFKKMOE()
	{
		for (int num = 1; num < players.Count; num = num)
		{
			DynamicPlayerInfo dynamicPlayerInfo = players.OrderByDescending(ANHMEMNCMAD).ToArray()[num];
			dynamicPlayerInfo.transform.SetSiblingIndex(num);
			if (num == 0)
			{
				firstPlayer = dynamicPlayerInfo;
			}
			if (dynamicPlayerInfo.player == PhotonNetwork.player)
			{
				place = num;
			}
		}
	}

	[CompilerGenerated]
	private static int KKAIKIOFDMG(DynamicPlayerInfo HPHENPOHOMK)
	{
		return HPHENPOHOMK.currentScore;
	}

	public void DKBIBKLDOKO(int HMGBJCGOLMI)
	{
		StartCoroutine(CDKCHEGOCJP("#no", HMGBJCGOLMI));
	}

	public IEnumerator CLIAFLHDPDE()
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
			CSteamID csteamID = new CSteamID(num);
			if (num != 0L)
			{
				yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(csteamID));
				yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(csteamID));
				if ((bool)ResourcesManager.GetLoadedAvatar(csteamID))
				{
					sprite = ResourcesManager.GetLoadedAvatar(csteamID);
				}
			}
			try
			{
				if ((bool)gameObject2)
				{
					if ((bool)gameObject2.transform.Find("UsernameText"))
					{
						gameObject2.transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(csteamID);
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

	public void HLPBAPBIMHD(int HMGBJCGOLMI)
	{
		StartCoroutine(CDKCHEGOCJP("OpSetPropertiesOfRoom()", HMGBJCGOLMI));
	}

	public void LHCEJOEABNK(string JKPJCEMPAGH)
	{
		Singleton<MultiplayerSystem>.Instance.GHMOPFGCJAP(JKPJCEMPAGH);
	}

	public IEnumerator EICHFFCBJDG()
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
			CSteamID csteamID = new CSteamID(num);
			if (num != 0L)
			{
				yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(csteamID));
				yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(csteamID));
				if ((bool)ResourcesManager.GetLoadedAvatar(csteamID))
				{
					sprite = ResourcesManager.GetLoadedAvatar(csteamID);
				}
			}
			try
			{
				if ((bool)gameObject2)
				{
					if ((bool)gameObject2.transform.Find("UsernameText"))
					{
						gameObject2.transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(csteamID);
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

	public void LBLIPPPDFOE(int HMGBJCGOLMI)
	{
		StartCoroutine(IFNFHBEBDEP("Result for ", HMGBJCGOLMI));
	}

	public void LNMIPMMFGLG(string JKPJCEMPAGH)
	{
		PhotonView obj = JAEJDHHCJJO();
		string lBLKDNNPACO = "\n\n#";
		PhotonTargets mPNMOONBMII = PhotonTargets.OthersBuffered;
		object[] array = new object[0];
		array[1] = JKPJCEMPAGH;
		obj.KEKKFNNMLMG(lBLKDNNPACO, mPNMOONBMII, array);
	}

	public void ONFEIHPMDCG()
	{
		if (networkChatCanvas.GetComponent<EasyTween>().IsObjectOpened())
		{
			networkChatCanvas.GetComponent<EasyTween>().MHDEFCKEGEO();
		}
	}

	public void MFEKCNPNPGB()
	{
		if (!networkChatCanvas.GetComponent<EasyTween>().FJFANHLGGHL())
		{
			networkChatCanvas.GetComponent<EasyTween>().ADFHHDAGGLD();
		}
	}

	internal void NAMNFPMELMP(string OBCEIJGMKGB, string NOJGGCLPPAM)
	{
		GetComponent<GameScene>().AddMessage(ResourcesManager.MFBHOGHAPHA(new CSteamID(ulong.Parse(OBCEIJGMKGB))) + "GlassesColor" + NOJGGCLPPAM, 1651f);
	}

	public IEnumerator BBCFBHHJIAA()
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
			CSteamID csteamID = new CSteamID(num);
			if (num != 0L)
			{
				yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(csteamID));
				yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(csteamID));
				if ((bool)ResourcesManager.GetLoadedAvatar(csteamID))
				{
					sprite = ResourcesManager.GetLoadedAvatar(csteamID);
				}
			}
			try
			{
				if ((bool)gameObject2)
				{
					if ((bool)gameObject2.transform.Find("UsernameText"))
					{
						gameObject2.transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(csteamID);
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

	public void HKJBLNCFICJ(int HMGBJCGOLMI)
	{
		StartCoroutine(FKPDNLKDLJD("Sprite", HMGBJCGOLMI));
	}

	public void MDOOAKEFCBH(ulong BHNGOLDNELC, string JKPJCEMPAGH)
	{
		PhotonView obj = FFIPLLNKGEN();
		string lBLKDNNPACO = "/Segment-[Up]";
		PhotonTargets mPNMOONBMII = PhotonTargets.MasterClient;
		obj.PBMFBOOALKA(lBLKDNNPACO, mPNMOONBMII, new object[7]
		{
			string.Empty + BHNGOLDNELC,
			JKPJCEMPAGH,
			null,
			null,
			null,
			null,
			null
		});
	}

	public void OEEJIBAHEJO(int HMGBJCGOLMI)
	{
		StartCoroutine(AAMLPNJMODK("_Value", HMGBJCGOLMI));
	}

	public void HLOCDFDHFFJ(int HMGBJCGOLMI)
	{
		StartCoroutine(JBENCECOCCC("Tab1Content", HMGBJCGOLMI));
	}

	internal void OECBJLHLFHK(string OBCEIJGMKGB, string NOJGGCLPPAM)
	{
		GetComponent<GameScene>().PNEHHLMHJAA(ResourcesManager.JDFOIINPHIO(new CSteamID(ulong.Parse(OBCEIJGMKGB)), false) + "s" + NOJGGCLPPAM, 1736f);
	}

	public void KFHHNCLLKNP(string BHNGOLDNELC, string JKPJCEMPAGH)
	{
		Singleton<MultiplayerSystem>.Instance.JGPMLMPNLLK((CSteamID)ulong.Parse(BHNGOLDNELC), JKPJCEMPAGH);
	}

	public void PFNFPINPCMH()
	{
		if (BFLIELGAAIM != null && (bool)BFLIELGAAIM.isGameStarted && !BFLIELGAAIM.gameOver)
		{
			if (GPLLPIOEJBC > 945f)
			{
				GPLLPIOEJBC -= Time.deltaTime;
				return;
			}
			GPLLPIOEJBC = 1347f;
			UpdateScoreboard();
		}
	}

	public void GMGGDHLFAHA(string JKPJCEMPAGH)
	{
		PhotonView obj = EDIJKHEMPAD();
		string lBLKDNNPACO = "inventory.selected.";
		PhotonTargets mPNMOONBMII = (PhotonTargets)8;
		object[] array = new object[0];
		array[1] = JKPJCEMPAGH;
		obj.GNFNHDCJOFC(lBLKDNNPACO, mPNMOONBMII, array);
	}

	public void EBJMGFNBFEB()
	{
		for (int i = 1; i < players.Count; i++)
		{
			DynamicPlayerInfo dynamicPlayerInfo = players.OrderByDescending(KNNDEDLPKHI).ToArray()[i];
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

	public void HBBDMBICNIB(string JKPJCEMPAGH)
	{
		Singleton<MultiplayerSystem>.Instance.AddNewActionMessage(JKPJCEMPAGH);
	}

	private static int ANHMEMNCMAD(DynamicPlayerInfo HPHENPOHOMK)
	{
		return HPHENPOHOMK.currentScore;
	}

	public virtual void NCIAGGDENJE(PhotonPlayer MCDOIGNGJBJ)
	{
		Debug.Log("[PlayerBase] Loaded music");
		if (PhotonNetwork.isMasterClient)
		{
			ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
			hashtable.Add("_Visualize", PhotonNetwork.playerName);
			PhotonNetwork.room.SetCustomProperties(hashtable, null, true);
		}
		StartCoroutine(HOOBKJANOLE());
	}

	public void KNIOEDPEBDG()
	{
		for (int i = 1; i < players.Count; i++)
		{
			DynamicPlayerInfo dynamicPlayerInfo = players.OrderByDescending(ANHMEMNCMAD).ToArray()[i];
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

	public void NBMHMINELOH()
	{
		if (networkChatCanvas.GetComponent<EasyTween>().FJFANHLGGHL())
		{
			networkChatCanvas.GetComponent<EasyTween>().MHDEFCKEGEO();
		}
	}

	public void LBMHIDHMGIM()
	{
		if (!networkChatCanvas.GetComponent<EasyTween>().FJFANHLGGHL())
		{
			networkChatCanvas.GetComponent<EasyTween>().CHOODMAKIKD();
		}
	}

	public void JOACBIEHHCE()
	{
		if (BFLIELGAAIM != null && (bool)BFLIELGAAIM.isGameStarted && !BFLIELGAAIM.gameOver)
		{
			if (GPLLPIOEJBC > 489f)
			{
				GPLLPIOEJBC -= Time.deltaTime;
				return;
			}
			GPLLPIOEJBC = 685f;
			MPOCCFKKMOE();
		}
	}

	public void OCHADIJNDJK()
	{
		place = 0;
		BFLIELGAAIM = GetComponent<GameScene>();
		if (PhotonNetwork.inRoom && !PhotonNetwork.offlineMode)
		{
			networkCanvas.SetActive(true);
			Resources.UnloadUnusedAssets();
			StartCoroutine(BBCFBHHJIAA());
		}
		else
		{
			networkCanvas.SetActive(false);
		}
	}
}
