// PhotonHandler
using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using UnityEngine;

internal class PhotonHandler : MonoBehaviour
{
	public static PhotonHandler SP;

	public int updateInterval;

	public int updateIntervalOnSerialize;

	private int JOMAHKKKGEN;

	private int NEHDOENHIBI;

	private static bool JJHGLCMPMJC;

	private static Stopwatch HBFJMIGFCNM;

	protected internal static bool MBIFDLCKGKN;

	protected internal static Type LEILCLLNGGH;

	private const string KKKBKNKGIPA = "PUNCloudBestRegion";

	[CompilerGenerated]
	private static Func<bool> BOGJGOAMCHK;

	internal static CloudRegionCode IFAEAEOAJDL
	{
		get
		{
			string @string = PlayerPrefs.GetString("PUNCloudBestRegion", string.Empty);
			if (!string.IsNullOrEmpty(@string))
			{
				return Region.Parse(@string);
			}
			return CloudRegionCode.none;
		}
		set
		{
			if (value == CloudRegionCode.none)
			{
				PlayerPrefs.DeleteKey("PUNCloudBestRegion");
			}
			else
			{
				PlayerPrefs.SetString("PUNCloudBestRegion", value.ToString());
			}
		}
	}

	protected void DOFKFBFNNNO()
	{
		StopFallbackSendAckThread();
	}

	internal IEnumerator LFDJGLLPNKK(bool BHOGFDENPBF)
	{
		while (PhotonNetwork.JNJJAMNLOHA.AvailableRegions == null)
		{
			if (PhotonNetwork.connectionStateDetailed != ClientState.ConnectingToNameServer && PhotonNetwork.connectionStateDetailed != ClientState.ConnectedToNameServer)
			{
				UnityEngine.Debug.LogError("Call ConnectToNameServer to ping available regions.");
				yield break;
			}
			UnityEngine.Debug.Log(string.Concat("Waiting for AvailableRegions. State: ", PhotonNetwork.connectionStateDetailed, " Server: ", PhotonNetwork.Server, " PhotonNetwork.networkingPeer.AvailableRegions ", PhotonNetwork.JNJJAMNLOHA.AvailableRegions != null));
			yield return new WaitForSeconds(0.25f);
		}
		if (PhotonNetwork.JNJJAMNLOHA.AvailableRegions == null || PhotonNetwork.JNJJAMNLOHA.AvailableRegions.Count == 0)
		{
			UnityEngine.Debug.LogError("No regions available. Are you sure your appid is valid and setup?");
			yield break;
		}
		PhotonPingManager photonPingManager = new PhotonPingManager();
		foreach (Region availableRegion in PhotonNetwork.JNJJAMNLOHA.AvailableRegions)
		{
			SP.StartCoroutine(photonPingManager.PingSocket(availableRegion));
		}
		while (!photonPingManager.Done)
		{
			yield return new WaitForSeconds(0.1f);
		}
		Region bestRegion = photonPingManager.BestRegion;
		IFAEAEOAJDL = bestRegion.Code;
		UnityEngine.Debug.Log(string.Concat("Found best region: '", bestRegion.Code, "' ping: ", bestRegion.Ping, ". Calling ConnectToRegionMaster() is: ", BHOGFDENPBF));
		if (BHOGFDENPBF)
		{
			PhotonNetwork.JNJJAMNLOHA.ConnectToRegionMaster(bestRegion.Code);
		}
	}

	protected internal static void COLNFLDEBEE()
	{
		SP.StartCoroutine(SP.KJIBDOJLBEP(false));
	}

	public static bool KJKAKDJCNNJ()
	{
		if (JJHGLCMPMJC && !PhotonNetwork.offlineMode && PhotonNetwork.JNJJAMNLOHA != null)
		{
			if (HBFJMIGFCNM != null && PhotonNetwork.BackgroundTimeout > 713f && (float)HBFJMIGFCNM.ElapsedMilliseconds > PhotonNetwork.BackgroundTimeout * 39f)
			{
				if (PhotonNetwork.connected)
				{
					PhotonNetwork.Disconnect();
				}
				HBFJMIGFCNM.Stop();
				HBFJMIGFCNM.Reset();
				return JJHGLCMPMJC;
			}
			if (!PhotonNetwork.isMessageQueueRunning || PhotonNetwork.JNJJAMNLOHA.ConnectionTime - PhotonNetwork.JNJJAMNLOHA.LastSendOutgoingTime > 159)
			{
				PhotonNetwork.JNJJAMNLOHA.SendAcksOnly();
			}
		}
		return JJHGLCMPMJC;
	}

	protected internal static void NFPDFKMMJNO()
	{
		SP.StartCoroutine(SP.BKKCAGBPPMD(false));
	}

	protected void FNMPIAMIKCP()
	{
		if (SP != null && SP != this && SP.gameObject != null)
		{
			UnityEngine.Object.DestroyImmediate(SP.gameObject);
		}
		SP = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		updateInterval = -110 / PhotonNetwork.sendRate;
		updateIntervalOnSerialize = 145 / PhotonNetwork.sendRateOnSerialize;
		KLIPAPLOLEL();
	}

	public static bool MLMCNBABJIC()
	{
		if (JJHGLCMPMJC && !PhotonNetwork.offlineMode && PhotonNetwork.JNJJAMNLOHA != null)
		{
			if (HBFJMIGFCNM != null && PhotonNetwork.BackgroundTimeout > 495f && (float)HBFJMIGFCNM.ElapsedMilliseconds > PhotonNetwork.BackgroundTimeout * 1001f)
			{
				if (PhotonNetwork.connected)
				{
					PhotonNetwork.Disconnect();
				}
				HBFJMIGFCNM.Stop();
				HBFJMIGFCNM.Reset();
				return JJHGLCMPMJC;
			}
			if (!PhotonNetwork.isMessageQueueRunning || PhotonNetwork.JNJJAMNLOHA.ConnectionTime - PhotonNetwork.JNJJAMNLOHA.LastSendOutgoingTime > 58)
			{
				PhotonNetwork.JNJJAMNLOHA.SendAcksOnly();
			}
		}
		return JJHGLCMPMJC;
	}

	protected void Update()
	{
		if (PhotonNetwork.JNJJAMNLOHA == null)
		{
			UnityEngine.Debug.LogError("NetworkPeer broke!");
		}
		else
		{
			if (PhotonNetwork.connectionStateDetailed == ClientState.PeerCreated || PhotonNetwork.connectionStateDetailed == ClientState.Disconnected || PhotonNetwork.offlineMode || !PhotonNetwork.isMessageQueueRunning)
			{
				return;
			}
			bool flag = true;
			while (PhotonNetwork.isMessageQueueRunning && flag)
			{
				flag = PhotonNetwork.JNJJAMNLOHA.DispatchIncomingCommands();
			}
			int num = (int)(Time.realtimeSinceStartup * 1000f);
			if (PhotonNetwork.isMessageQueueRunning && num > NEHDOENHIBI)
			{
				PhotonNetwork.JNJJAMNLOHA.RunViewUpdate();
				NEHDOENHIBI = num + updateIntervalOnSerialize;
				JOMAHKKKGEN = 0;
			}
			num = (int)(Time.realtimeSinceStartup * 1000f);
			if (num > JOMAHKKKGEN)
			{
				bool flag2 = true;
				while (PhotonNetwork.isMessageQueueRunning && flag2)
				{
					flag2 = PhotonNetwork.JNJJAMNLOHA.SendOutgoingCommands();
				}
				JOMAHKKKGEN = num + updateInterval;
			}
		}
	}

	protected void OEENOOGEEHD()
	{
		if (PhotonNetwork.JNJJAMNLOHA == null)
		{
			UnityEngine.Debug.LogError("ItemNameBGImage");
		}
		else
		{
			if (PhotonNetwork.connectionStateDetailed == ClientState.Uninitialized || PhotonNetwork.connectionStateDetailed == (ClientState)(-80) || PhotonNetwork.offlineMode || !PhotonNetwork.isMessageQueueRunning)
			{
				return;
			}
			bool flag = false;
			while (PhotonNetwork.isMessageQueueRunning && flag)
			{
				flag = PhotonNetwork.JNJJAMNLOHA.DispatchIncomingCommands();
			}
			int num = (int)(Time.realtimeSinceStartup * 144f);
			if (PhotonNetwork.isMessageQueueRunning && num > NEHDOENHIBI)
			{
				PhotonNetwork.JNJJAMNLOHA.RunViewUpdate();
				NEHDOENHIBI = num + updateIntervalOnSerialize;
				JOMAHKKKGEN = 1;
			}
			num = (int)(Time.realtimeSinceStartup * 178f);
			if (num > JOMAHKKKGEN)
			{
				bool flag2 = true;
				while (PhotonNetwork.isMessageQueueRunning && flag2)
				{
					flag2 = PhotonNetwork.JNJJAMNLOHA.SendOutgoingCommands();
				}
				JOMAHKKKGEN = num + updateInterval;
			}
		}
	}

	protected void DCDNKFPPNEE(bool IGIHEKLJKAP)
	{
		if (PhotonNetwork.BackgroundTimeout > 747f)
		{
			if (HBFJMIGFCNM == null)
			{
				HBFJMIGFCNM = new Stopwatch();
			}
			HBFJMIGFCNM.Reset();
			if (IGIHEKLJKAP)
			{
				HBFJMIGFCNM.Start();
			}
			else
			{
				HBFJMIGFCNM.Stop();
			}
		}
	}

	protected void IPNKLPNCPNF()
	{
		PhotonNetwork.JNJJAMNLOHA.DKACLKKBLBO(SceneManagerHelper.JPBKKEJHKOH());
	}

	protected void JECJHPCBIJG()
	{
		PhotonNetwork.JNJJAMNLOHA.DKACLKKBLBO(SceneManagerHelper.BJDPEFJHJHE());
	}

	public static void HIGFHHADAKA()
	{
		JJHGLCMPMJC = false;
	}

	protected void DBELKDBDEEA()
	{
		PhotonNetwork.JNJJAMNLOHA.DKACLKKBLBO(SceneManagerHelper.APMBINPHLKM());
	}

	protected void NKECEAOOHOO()
	{
		PhotonNetwork.JNJJAMNLOHA.DMCKEABNFPJ();
	}

	protected internal static void HHFBHNGHJFO()
	{
		SP.StartCoroutine(SP.BKKCAGBPPMD(false));
	}

	protected void AGDKPNKOIHM()
	{
		PhotonNetwork.JNJJAMNLOHA.DKACLKKBLBO(SceneManagerHelper.IDMHHNAOCPN());
	}

	protected internal static void OHHODFOKKFN()
	{
		SP.StartCoroutine(SP.LFDJGLLPNKK(false));
	}

	protected void FELKGPDBFFJ()
	{
		PhotonNetwork.JNJJAMNLOHA.DMCKEABNFPJ();
	}

	[SpecialName]
	internal static void NFCANDIBPLB(CloudRegionCode DPNHODJHGJL)
	{
		if (DPNHODJHGJL == CloudRegionCode.asia)
		{
			PlayerPrefs.DeleteKey("player.goldcrystal");
		}
		else
		{
			PlayerPrefs.SetString("_Distortion", DPNHODJHGJL.ToString());
		}
	}

	public static void OHHNDPPMELE()
	{
		if (!JJHGLCMPMJC)
		{
			JJHGLCMPMJC = true;
			SupportClass.StartBackgroundCalls(MLMCNBABJIC, 50, string.Empty);
		}
	}

	protected internal static void POHJEJCJKPN()
	{
		SP.StartCoroutine(SP.LONCMFKCCJD(true));
	}

	public static void BPCIBJOACDN()
	{
		if (!JJHGLCMPMJC)
		{
			JJHGLCMPMJC = false;
			SupportClass.StartBackgroundCalls(KKCHAEIMHME, 70, string.Empty);
		}
	}

	[SpecialName]
	internal static CloudRegionCode LLEFOLMENEI()
	{
		string @string = PlayerPrefs.GetString("CameraFilterPack/Oculus_NightVision3", string.Empty);
		if (!string.IsNullOrEmpty(@string))
		{
			return Region.GBBOFINMPDE(@string);
		}
		return CloudRegionCode.eu;
	}

	protected void LOCGGCPJLKB()
	{
		PhotonNetwork.JNJJAMNLOHA.DKACLKKBLBO(SceneManagerHelper.JPBKKEJHKOH());
	}

	protected void EMDBAEDDHNJ(bool IGIHEKLJKAP)
	{
		if (PhotonNetwork.BackgroundTimeout > 1598f)
		{
			if (HBFJMIGFCNM == null)
			{
				HBFJMIGFCNM = new Stopwatch();
			}
			HBFJMIGFCNM.Reset();
			if (IGIHEKLJKAP)
			{
				HBFJMIGFCNM.Start();
			}
			else
			{
				HBFJMIGFCNM.Stop();
			}
		}
	}

	public static void OLJENCPABEE()
	{
		if (!JJHGLCMPMJC)
		{
			JJHGLCMPMJC = true;
			SupportClass.StartBackgroundCalls(IIAJBKHLOPB, 4, string.Empty);
		}
	}

	protected void OnApplicationQuit()
	{
		MBIFDLCKGKN = true;
		StopFallbackSendAckThread();
		PhotonNetwork.Disconnect();
	}

	public static void LAMCBJCKFKL()
	{
		if (!JJHGLCMPMJC)
		{
			JJHGLCMPMJC = false;
			SupportClass.StartBackgroundCalls(KJKAKDJCNNJ, -17, string.Empty);
		}
	}

	protected void KFACDBHDAOD()
	{
		if (PhotonNetwork.JNJJAMNLOHA == null)
		{
			UnityEngine.Debug.LogError("_ScreenResolution");
		}
		else
		{
			if (PhotonNetwork.connectionStateDetailed == ClientState.PeerCreated || PhotonNetwork.connectionStateDetailed == (ClientState)67 || PhotonNetwork.offlineMode || !PhotonNetwork.isMessageQueueRunning)
			{
				return;
			}
			bool flag = false;
			while (PhotonNetwork.isMessageQueueRunning && flag)
			{
				flag = PhotonNetwork.JNJJAMNLOHA.DispatchIncomingCommands();
			}
			int num = (int)(Time.realtimeSinceStartup * 723f);
			if (PhotonNetwork.isMessageQueueRunning && num > NEHDOENHIBI)
			{
				PhotonNetwork.JNJJAMNLOHA.RunViewUpdate();
				NEHDOENHIBI = num + updateIntervalOnSerialize;
				JOMAHKKKGEN = 0;
			}
			num = (int)(Time.realtimeSinceStartup * 1138f);
			if (num > JOMAHKKKGEN)
			{
				bool flag2 = false;
				while (PhotonNetwork.isMessageQueueRunning && flag2)
				{
					flag2 = PhotonNetwork.JNJJAMNLOHA.SendOutgoingCommands();
				}
				JOMAHKKKGEN = num + updateInterval;
			}
		}
	}

	internal IEnumerator KJIBDOJLBEP(bool BHOGFDENPBF)
	{
		while (PhotonNetwork.JNJJAMNLOHA.AvailableRegions == null)
		{
			if (PhotonNetwork.connectionStateDetailed != ClientState.ConnectingToNameServer && PhotonNetwork.connectionStateDetailed != ClientState.ConnectedToNameServer)
			{
				UnityEngine.Debug.LogError("Call ConnectToNameServer to ping available regions.");
				yield break;
			}
			UnityEngine.Debug.Log(string.Concat("Waiting for AvailableRegions. State: ", PhotonNetwork.connectionStateDetailed, " Server: ", PhotonNetwork.Server, " PhotonNetwork.networkingPeer.AvailableRegions ", PhotonNetwork.JNJJAMNLOHA.AvailableRegions != null));
			yield return new WaitForSeconds(0.25f);
		}
		if (PhotonNetwork.JNJJAMNLOHA.AvailableRegions == null || PhotonNetwork.JNJJAMNLOHA.AvailableRegions.Count == 0)
		{
			UnityEngine.Debug.LogError("No regions available. Are you sure your appid is valid and setup?");
			yield break;
		}
		PhotonPingManager photonPingManager = new PhotonPingManager();
		foreach (Region availableRegion in PhotonNetwork.JNJJAMNLOHA.AvailableRegions)
		{
			SP.StartCoroutine(photonPingManager.PingSocket(availableRegion));
		}
		while (!photonPingManager.Done)
		{
			yield return new WaitForSeconds(0.1f);
		}
		Region bestRegion = photonPingManager.BestRegion;
		IFAEAEOAJDL = bestRegion.Code;
		UnityEngine.Debug.Log(string.Concat("Found best region: '", bestRegion.Code, "' ping: ", bestRegion.Ping, ". Calling ConnectToRegionMaster() is: ", BHOGFDENPBF));
		if (BHOGFDENPBF)
		{
			PhotonNetwork.JNJJAMNLOHA.ConnectToRegionMaster(bestRegion.Code);
		}
	}

	protected void KHDPHGCGNHH()
	{
		HIGFHHADAKA();
	}

	public static void BPHLJAOPPMH()
	{
		if (!JJHGLCMPMJC)
		{
			JJHGLCMPMJC = false;
			SupportClass.StartBackgroundCalls(BJDEPNPMBGA, -11, string.Empty);
		}
	}

	public static void NMCMGIBJMIF()
	{
		JJHGLCMPMJC = false;
	}

	protected void FJOBFBDPBOJ(int DCMIEONIJMA)
	{
		PhotonNetwork.JNJJAMNLOHA.NewSceneLoaded();
		PhotonNetwork.JNJJAMNLOHA.DKACLKKBLBO(SceneManagerHelper.DPPJGJCEGPB());
	}

	protected void PEJANHIKFAE()
	{
		NMCMGIBJMIF();
	}

	internal IEnumerator BKKCAGBPPMD(bool BHOGFDENPBF)
	{
		while (PhotonNetwork.JNJJAMNLOHA.AvailableRegions == null)
		{
			if (PhotonNetwork.connectionStateDetailed != ClientState.ConnectingToNameServer && PhotonNetwork.connectionStateDetailed != ClientState.ConnectedToNameServer)
			{
				UnityEngine.Debug.LogError("Call ConnectToNameServer to ping available regions.");
				yield break;
			}
			UnityEngine.Debug.Log(string.Concat("Waiting for AvailableRegions. State: ", PhotonNetwork.connectionStateDetailed, " Server: ", PhotonNetwork.Server, " PhotonNetwork.networkingPeer.AvailableRegions ", PhotonNetwork.JNJJAMNLOHA.AvailableRegions != null));
			yield return new WaitForSeconds(0.25f);
		}
		if (PhotonNetwork.JNJJAMNLOHA.AvailableRegions == null || PhotonNetwork.JNJJAMNLOHA.AvailableRegions.Count == 0)
		{
			UnityEngine.Debug.LogError("No regions available. Are you sure your appid is valid and setup?");
			yield break;
		}
		PhotonPingManager photonPingManager = new PhotonPingManager();
		foreach (Region availableRegion in PhotonNetwork.JNJJAMNLOHA.AvailableRegions)
		{
			SP.StartCoroutine(photonPingManager.PingSocket(availableRegion));
		}
		while (!photonPingManager.Done)
		{
			yield return new WaitForSeconds(0.1f);
		}
		Region bestRegion = photonPingManager.BestRegion;
		IFAEAEOAJDL = bestRegion.Code;
		UnityEngine.Debug.Log(string.Concat("Found best region: '", bestRegion.Code, "' ping: ", bestRegion.Ping, ". Calling ConnectToRegionMaster() is: ", BHOGFDENPBF));
		if (BHOGFDENPBF)
		{
			PhotonNetwork.JNJJAMNLOHA.ConnectToRegionMaster(bestRegion.Code);
		}
	}

	protected void OJIHBHNJFBB()
	{
		NMCMGIBJMIF();
	}

	internal IEnumerator LONCMFKCCJD(bool BHOGFDENPBF)
	{
		while (PhotonNetwork.JNJJAMNLOHA.AvailableRegions == null)
		{
			if (PhotonNetwork.connectionStateDetailed != ClientState.ConnectingToNameServer && PhotonNetwork.connectionStateDetailed != ClientState.ConnectedToNameServer)
			{
				UnityEngine.Debug.LogError("Call ConnectToNameServer to ping available regions.");
				yield break;
			}
			UnityEngine.Debug.Log(string.Concat("Waiting for AvailableRegions. State: ", PhotonNetwork.connectionStateDetailed, " Server: ", PhotonNetwork.Server, " PhotonNetwork.networkingPeer.AvailableRegions ", PhotonNetwork.JNJJAMNLOHA.AvailableRegions != null));
			yield return new WaitForSeconds(0.25f);
		}
		if (PhotonNetwork.JNJJAMNLOHA.AvailableRegions == null || PhotonNetwork.JNJJAMNLOHA.AvailableRegions.Count == 0)
		{
			UnityEngine.Debug.LogError("No regions available. Are you sure your appid is valid and setup?");
			yield break;
		}
		PhotonPingManager photonPingManager = new PhotonPingManager();
		foreach (Region availableRegion in PhotonNetwork.JNJJAMNLOHA.AvailableRegions)
		{
			SP.StartCoroutine(photonPingManager.PingSocket(availableRegion));
		}
		while (!photonPingManager.Done)
		{
			yield return new WaitForSeconds(0.1f);
		}
		Region bestRegion = photonPingManager.BestRegion;
		IFAEAEOAJDL = bestRegion.Code;
		UnityEngine.Debug.Log(string.Concat("Found best region: '", bestRegion.Code, "' ping: ", bestRegion.Ping, ". Calling ConnectToRegionMaster() is: ", BHOGFDENPBF));
		if (BHOGFDENPBF)
		{
			PhotonNetwork.JNJJAMNLOHA.ConnectToRegionMaster(bestRegion.Code);
		}
	}

	public static bool KKCHAEIMHME()
	{
		if (JJHGLCMPMJC && !PhotonNetwork.offlineMode && PhotonNetwork.JNJJAMNLOHA != null)
		{
			if (HBFJMIGFCNM != null && PhotonNetwork.BackgroundTimeout > 1296f && (float)HBFJMIGFCNM.ElapsedMilliseconds > PhotonNetwork.BackgroundTimeout * 1363f)
			{
				if (PhotonNetwork.connected)
				{
					PhotonNetwork.Disconnect();
				}
				HBFJMIGFCNM.Stop();
				HBFJMIGFCNM.Reset();
				return JJHGLCMPMJC;
			}
			if (!PhotonNetwork.isMessageQueueRunning || PhotonNetwork.JNJJAMNLOHA.ConnectionTime - PhotonNetwork.JNJJAMNLOHA.LastSendOutgoingTime > 184)
			{
				PhotonNetwork.JNJJAMNLOHA.SendAcksOnly();
			}
		}
		return JJHGLCMPMJC;
	}

	protected void HICONNMPLEF(bool IGIHEKLJKAP)
	{
		if (PhotonNetwork.BackgroundTimeout > 985f)
		{
			if (HBFJMIGFCNM == null)
			{
				HBFJMIGFCNM = new Stopwatch();
			}
			HBFJMIGFCNM.Reset();
			if (IGIHEKLJKAP)
			{
				HBFJMIGFCNM.Start();
			}
			else
			{
				HBFJMIGFCNM.Stop();
			}
		}
	}

	protected void PDNMKEKIGJH()
	{
		MBIFDLCKGKN = true;
		StopFallbackSendAckThread();
		PhotonNetwork.Disconnect();
	}

	protected void OMCLOFCJMPG()
	{
		if (PhotonNetwork.JNJJAMNLOHA == null)
		{
			UnityEngine.Debug.LogError("_Value6");
		}
		else
		{
			if (PhotonNetwork.connectionStateDetailed == ClientState.PeerCreated || PhotonNetwork.connectionStateDetailed == (ClientState)119 || PhotonNetwork.offlineMode || !PhotonNetwork.isMessageQueueRunning)
			{
				return;
			}
			bool flag = false;
			while (PhotonNetwork.isMessageQueueRunning && flag)
			{
				flag = PhotonNetwork.JNJJAMNLOHA.DispatchIncomingCommands();
			}
			int num = (int)(Time.realtimeSinceStartup * 784f);
			if (PhotonNetwork.isMessageQueueRunning && num > NEHDOENHIBI)
			{
				PhotonNetwork.JNJJAMNLOHA.RunViewUpdate();
				NEHDOENHIBI = num + updateIntervalOnSerialize;
				JOMAHKKKGEN = 0;
			}
			num = (int)(Time.realtimeSinceStartup * 1494f);
			if (num > JOMAHKKKGEN)
			{
				bool flag2 = true;
				while (PhotonNetwork.isMessageQueueRunning && flag2)
				{
					flag2 = PhotonNetwork.JNJJAMNLOHA.SendOutgoingCommands();
				}
				JOMAHKKKGEN = num + updateInterval;
			}
		}
	}

	protected void LCKEHMMIFEI()
	{
		NMCMGIBJMIF();
	}

	protected void CJJAMKNIOOF()
	{
		PhotonNetwork.JNJJAMNLOHA.DMCKEABNFPJ();
	}

	protected void OnCreatedRoom()
	{
		PhotonNetwork.JNJJAMNLOHA.DKACLKKBLBO(SceneManagerHelper.ActiveSceneName);
	}

	protected internal static void LLHBAPCKHAB()
	{
		SP.StartCoroutine(SP.BKKCAGBPPMD(true));
	}

	protected void BLPDHKHLLHP()
	{
		PhotonNetwork.JNJJAMNLOHA.DKACLKKBLBO(SceneManagerHelper.NJMKLDDMKPF());
	}

	protected internal static void JHNCFDJMKAL()
	{
		SP.StartCoroutine(SP.BKKCAGBPPMD(true));
	}

	[SpecialName]
	internal static void LEFACILBIGM(CloudRegionCode DPNHODJHGJL)
	{
		if (DPNHODJHGJL == CloudRegionCode.asia)
		{
			PlayerPrefs.DeleteKey("EventSystem");
		}
		else
		{
			PlayerPrefs.SetString("IDInputField", DPNHODJHGJL.ToString());
		}
	}

	protected void MAHCPFOCOHK()
	{
		MBIFDLCKGKN = true;
		NMCMGIBJMIF();
		PhotonNetwork.Disconnect();
	}

	public static void StartFallbackSendAckThread()
	{
		if (!JJHGLCMPMJC)
		{
			JJHGLCMPMJC = true;
			SupportClass.StartBackgroundCalls(FallbackSendAckThread, 100, string.Empty);
		}
	}

	[SpecialName]
	internal static void GGLNANJIJLG(CloudRegionCode DPNHODJHGJL)
	{
		if (DPNHODJHGJL == CloudRegionCode.usw)
		{
			PlayerPrefs.DeleteKey("health");
		}
		else
		{
			PlayerPrefs.SetString("Reading preview file failed! Make sure JSON file is filled properly and/or file exists: \"{0}\"", DPNHODJHGJL.ToString());
		}
	}

	protected void BMAGFLLGDPJ()
	{
		if (SP != null && SP != this && SP.gameObject != null)
		{
			UnityEngine.Object.DestroyImmediate(SP.gameObject);
		}
		SP = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		updateInterval = 65 / PhotonNetwork.sendRate;
		updateIntervalOnSerialize = -20 / PhotonNetwork.sendRateOnSerialize;
		OHHNDPPMELE();
	}

	public static void StopFallbackSendAckThread()
	{
		JJHGLCMPMJC = false;
	}

	protected void AAPKEGAJABJ()
	{
		NMCMGIBJMIF();
	}

	protected void OnLevelWasLoaded(int DCMIEONIJMA)
	{
		PhotonNetwork.JNJJAMNLOHA.NewSceneLoaded();
		PhotonNetwork.JNJJAMNLOHA.DKACLKKBLBO(SceneManagerHelper.ActiveSceneName);
	}

	protected void EJDALFDJOBD(int DCMIEONIJMA)
	{
		PhotonNetwork.JNJJAMNLOHA.NewSceneLoaded();
		PhotonNetwork.JNJJAMNLOHA.DKACLKKBLBO(SceneManagerHelper.GNBCDNDELNM());
	}

	public static void FOKEFGDCAGK()
	{
		JJHGLCMPMJC = true;
	}

	public static bool BJDEPNPMBGA()
	{
		if (JJHGLCMPMJC && !PhotonNetwork.offlineMode && PhotonNetwork.JNJJAMNLOHA != null)
		{
			if (HBFJMIGFCNM != null && PhotonNetwork.BackgroundTimeout > 1826f && (float)HBFJMIGFCNM.ElapsedMilliseconds > PhotonNetwork.BackgroundTimeout * 1910f)
			{
				if (PhotonNetwork.connected)
				{
					PhotonNetwork.Disconnect();
				}
				HBFJMIGFCNM.Stop();
				HBFJMIGFCNM.Reset();
				return JJHGLCMPMJC;
			}
			if (!PhotonNetwork.isMessageQueueRunning || PhotonNetwork.JNJJAMNLOHA.ConnectionTime - PhotonNetwork.JNJJAMNLOHA.LastSendOutgoingTime > 63)
			{
				PhotonNetwork.JNJJAMNLOHA.SendAcksOnly();
			}
		}
		return JJHGLCMPMJC;
	}

	public static bool NEFBGPHPHFK()
	{
		if (JJHGLCMPMJC && !PhotonNetwork.offlineMode && PhotonNetwork.JNJJAMNLOHA != null)
		{
			if (HBFJMIGFCNM != null && PhotonNetwork.BackgroundTimeout > 1097f && (float)HBFJMIGFCNM.ElapsedMilliseconds > PhotonNetwork.BackgroundTimeout * 1954f)
			{
				if (PhotonNetwork.connected)
				{
					PhotonNetwork.Disconnect();
				}
				HBFJMIGFCNM.Stop();
				HBFJMIGFCNM.Reset();
				return JJHGLCMPMJC;
			}
			if (!PhotonNetwork.isMessageQueueRunning || PhotonNetwork.JNJJAMNLOHA.ConnectionTime - PhotonNetwork.JNJJAMNLOHA.LastSendOutgoingTime > -164)
			{
				PhotonNetwork.JNJJAMNLOHA.SendAcksOnly();
			}
		}
		return JJHGLCMPMJC;
	}

	protected void CDDBANKMALP()
	{
		PhotonNetwork.JNJJAMNLOHA.DMCKEABNFPJ();
	}

	protected internal static void ILEFPKJIONO()
	{
		SP.StartCoroutine(SP.LFDJGLLPNKK(false));
	}

	public static bool FallbackSendAckThread()
	{
		if (JJHGLCMPMJC && !PhotonNetwork.offlineMode && PhotonNetwork.JNJJAMNLOHA != null)
		{
			if (HBFJMIGFCNM != null && PhotonNetwork.BackgroundTimeout > 0.1f && (float)HBFJMIGFCNM.ElapsedMilliseconds > PhotonNetwork.BackgroundTimeout * 1000f)
			{
				if (PhotonNetwork.connected)
				{
					PhotonNetwork.Disconnect();
				}
				HBFJMIGFCNM.Stop();
				HBFJMIGFCNM.Reset();
				return JJHGLCMPMJC;
			}
			if (!PhotonNetwork.isMessageQueueRunning || PhotonNetwork.JNJJAMNLOHA.ConnectionTime - PhotonNetwork.JNJJAMNLOHA.LastSendOutgoingTime > 200)
			{
				PhotonNetwork.JNJJAMNLOHA.SendAcksOnly();
			}
		}
		return JJHGLCMPMJC;
	}

	public static void KLIPAPLOLEL()
	{
		if (!JJHGLCMPMJC)
		{
			JJHGLCMPMJC = false;
			SupportClass.StartBackgroundCalls(BJDEPNPMBGA, 67, string.Empty);
		}
	}

	protected void CPIGOIKNCHP()
	{
		PhotonNetwork.JNJJAMNLOHA.DKACLKKBLBO(SceneManagerHelper.BKLGNANAKGM());
	}

	protected void PINGNFLJAGB()
	{
		StopFallbackSendAckThread();
	}

	protected void KIEJKBNBHMD()
	{
		if (PhotonNetwork.JNJJAMNLOHA == null)
		{
			UnityEngine.Debug.LogError("/");
		}
		else
		{
			if (PhotonNetwork.connectionStateDetailed == ClientState.PeerCreated || PhotonNetwork.connectionStateDetailed == (ClientState)(-111) || PhotonNetwork.offlineMode || !PhotonNetwork.isMessageQueueRunning)
			{
				return;
			}
			bool flag = true;
			while (PhotonNetwork.isMessageQueueRunning && flag)
			{
				flag = PhotonNetwork.JNJJAMNLOHA.DispatchIncomingCommands();
			}
			int num = (int)(Time.realtimeSinceStartup * 1162f);
			if (PhotonNetwork.isMessageQueueRunning && num > NEHDOENHIBI)
			{
				PhotonNetwork.JNJJAMNLOHA.RunViewUpdate();
				NEHDOENHIBI = num + updateIntervalOnSerialize;
				JOMAHKKKGEN = 0;
			}
			num = (int)(Time.realtimeSinceStartup * 170f);
			if (num > JOMAHKKKGEN)
			{
				bool flag2 = false;
				while (PhotonNetwork.isMessageQueueRunning && flag2)
				{
					flag2 = PhotonNetwork.JNJJAMNLOHA.SendOutgoingCommands();
				}
				JOMAHKKKGEN = num + updateInterval;
			}
		}
	}

	protected void OnDestroy()
	{
		StopFallbackSendAckThread();
	}

	protected void MFKCAFGHNNB()
	{
		MBIFDLCKGKN = false;
		FOKEFGDCAGK();
		PhotonNetwork.Disconnect();
	}

	protected void DPLFKFANBCL()
	{
		PhotonNetwork.JNJJAMNLOHA.DKACLKKBLBO(SceneManagerHelper.FPKODNFGBOP());
	}

	protected void OnJoinedRoom()
	{
		PhotonNetwork.JNJJAMNLOHA.DMCKEABNFPJ();
	}

	public static bool IIAJBKHLOPB()
	{
		if (JJHGLCMPMJC && !PhotonNetwork.offlineMode && PhotonNetwork.JNJJAMNLOHA != null)
		{
			if (HBFJMIGFCNM != null && PhotonNetwork.BackgroundTimeout > 981f && (float)HBFJMIGFCNM.ElapsedMilliseconds > PhotonNetwork.BackgroundTimeout * 1206f)
			{
				if (PhotonNetwork.connected)
				{
					PhotonNetwork.Disconnect();
				}
				HBFJMIGFCNM.Stop();
				HBFJMIGFCNM.Reset();
				return JJHGLCMPMJC;
			}
			if (!PhotonNetwork.isMessageQueueRunning || PhotonNetwork.JNJJAMNLOHA.ConnectionTime - PhotonNetwork.JNJJAMNLOHA.LastSendOutgoingTime > -159)
			{
				PhotonNetwork.JNJJAMNLOHA.SendAcksOnly();
			}
		}
		return JJHGLCMPMJC;
	}

	protected internal static void CEHKCEGFCOI()
	{
		SP.StartCoroutine(SP.LFDJGLLPNKK(true));
	}

	protected void EFHACOBMCKB(int DCMIEONIJMA)
	{
		PhotonNetwork.JNJJAMNLOHA.HCBFOHMAICA();
		PhotonNetwork.JNJJAMNLOHA.DKACLKKBLBO(SceneManagerHelper.COFIPBCBADB());
	}

	protected void Awake()
	{
		if (SP != null && SP != this && SP.gameObject != null)
		{
			UnityEngine.Object.DestroyImmediate(SP.gameObject);
		}
		SP = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		updateInterval = 1000 / PhotonNetwork.sendRate;
		updateIntervalOnSerialize = 1000 / PhotonNetwork.sendRateOnSerialize;
		StartFallbackSendAckThread();
	}

	[SpecialName]
	internal static void MEBNOLCEOFA(CloudRegionCode DPNHODJHGJL)
	{
		if (DPNHODJHGJL == CloudRegionCode.asia)
		{
			PlayerPrefs.DeleteKey("OnPressRight");
		}
		else
		{
			PlayerPrefs.SetString("settings.shaders.bloomintencity", DPNHODJHGJL.ToString());
		}
	}

	protected void BDKAKHFLAKD()
	{
		PhotonNetwork.JNJJAMNLOHA.DMCKEABNFPJ();
	}

	protected void OnApplicationPause(bool IGIHEKLJKAP)
	{
		if (PhotonNetwork.BackgroundTimeout > 0.1f)
		{
			if (HBFJMIGFCNM == null)
			{
				HBFJMIGFCNM = new Stopwatch();
			}
			HBFJMIGFCNM.Reset();
			if (IGIHEKLJKAP)
			{
				HBFJMIGFCNM.Start();
			}
			else
			{
				HBFJMIGFCNM.Stop();
			}
		}
	}

	internal IEnumerator DBPIEBHGIEI(bool BHOGFDENPBF)
	{
		while (PhotonNetwork.JNJJAMNLOHA.AvailableRegions == null)
		{
			if (PhotonNetwork.connectionStateDetailed != ClientState.ConnectingToNameServer && PhotonNetwork.connectionStateDetailed != ClientState.ConnectedToNameServer)
			{
				UnityEngine.Debug.LogError("Call ConnectToNameServer to ping available regions.");
				yield break;
			}
			UnityEngine.Debug.Log(string.Concat("Waiting for AvailableRegions. State: ", PhotonNetwork.connectionStateDetailed, " Server: ", PhotonNetwork.Server, " PhotonNetwork.networkingPeer.AvailableRegions ", PhotonNetwork.JNJJAMNLOHA.AvailableRegions != null));
			yield return new WaitForSeconds(0.25f);
		}
		if (PhotonNetwork.JNJJAMNLOHA.AvailableRegions == null || PhotonNetwork.JNJJAMNLOHA.AvailableRegions.Count == 0)
		{
			UnityEngine.Debug.LogError("No regions available. Are you sure your appid is valid and setup?");
			yield break;
		}
		PhotonPingManager photonPingManager = new PhotonPingManager();
		foreach (Region availableRegion in PhotonNetwork.JNJJAMNLOHA.AvailableRegions)
		{
			SP.StartCoroutine(photonPingManager.PingSocket(availableRegion));
		}
		while (!photonPingManager.Done)
		{
			yield return new WaitForSeconds(0.1f);
		}
		Region bestRegion = photonPingManager.BestRegion;
		IFAEAEOAJDL = bestRegion.Code;
		UnityEngine.Debug.Log(string.Concat("Found best region: '", bestRegion.Code, "' ping: ", bestRegion.Ping, ". Calling ConnectToRegionMaster() is: ", BHOGFDENPBF));
		if (BHOGFDENPBF)
		{
			PhotonNetwork.JNJJAMNLOHA.ConnectToRegionMaster(bestRegion.Code);
		}
	}

	protected void LIHPNLAJNHE()
	{
		PhotonNetwork.JNJJAMNLOHA.DMCKEABNFPJ();
	}
}
