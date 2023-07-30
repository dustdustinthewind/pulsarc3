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

	protected void AJDHCKDMOBO()
	{
		MBIFDLCKGKN = false;
		ANKJFLJGCPE();
		PhotonNetwork.Disconnect();
	}

	protected void DMPMHGGLPCB()
	{
		StopFallbackSendAckThread();
	}

	[SpecialName]
	internal static CloudRegionCode LOLNPBOPNGP()
	{
		string @string = PlayerPrefs.GetString("Items/", string.Empty);
		if (!string.IsNullOrEmpty(@string))
		{
			return Region.OAGCFAEKBCN(@string);
		}
		return CloudRegionCode.us;
	}

	protected void KACPCCMPAHA()
	{
		if (SP != null && SP != this && SP.gameObject != null)
		{
			UnityEngine.Object.DestroyImmediate(SP.gameObject);
		}
		SP = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		updateInterval = 90 / PhotonNetwork.sendRate;
		updateIntervalOnSerialize = -131 / PhotonNetwork.sendRateOnSerialize;
		IFAPHFLFKIF();
	}

	protected void KECHJFPOJMM()
	{
		ANKJFLJGCPE();
	}

	protected void NLJOLEDKONO()
	{
		PhotonNetwork.JNJJAMNLOHA.DKACLKKBLBO(SceneManagerHelper.JKEDNILDNDG());
	}

	protected void FANFIMBKBKP()
	{
		PhotonNetwork.JNJJAMNLOHA.DKACLKKBLBO(SceneManagerHelper.JFNAOCLGCFO());
	}

	public static bool DDBCAHBCDJI()
	{
		if (JJHGLCMPMJC && !PhotonNetwork.offlineMode && PhotonNetwork.JNJJAMNLOHA != null)
		{
			if (HBFJMIGFCNM != null && PhotonNetwork.BackgroundTimeout > 1433f && (float)HBFJMIGFCNM.ElapsedMilliseconds > PhotonNetwork.BackgroundTimeout * 1542f)
			{
				if (PhotonNetwork.connected)
				{
					PhotonNetwork.Disconnect();
				}
				HBFJMIGFCNM.Stop();
				HBFJMIGFCNM.Reset();
				return JJHGLCMPMJC;
			}
			if (!PhotonNetwork.isMessageQueueRunning || PhotonNetwork.JNJJAMNLOHA.ConnectionTime - PhotonNetwork.JNJJAMNLOHA.LastSendOutgoingTime > -30)
			{
				PhotonNetwork.JNJJAMNLOHA.SendAcksOnly();
			}
		}
		return JJHGLCMPMJC;
	}

	[SpecialName]
	internal static CloudRegionCode BBGGKBOFEEJ()
	{
		string @string = PlayerPrefs.GetString("_MaxRayTraceDistance", string.Empty);
		if (!string.IsNullOrEmpty(@string))
		{
			return Region.OHOINFLIPBJ(@string);
		}
		return CloudRegionCode.usw;
	}

	[SpecialName]
	internal static CloudRegionCode MFGPJCLHKJL()
	{
		string @string = PlayerPrefs.GetString("ShadersToggle", string.Empty);
		if (!string.IsNullOrEmpty(@string))
		{
			return Region.KIAECLDONLK(@string);
		}
		return CloudRegionCode.usw;
	}

	public static void AAHPADANGKA()
	{
		if (!JJHGLCMPMJC)
		{
			JJHGLCMPMJC = false;
			SupportClass.StartBackgroundCalls(KLBBCBBALAI, -102, string.Empty);
		}
	}

	public static bool KLBBCBBALAI()
	{
		if (JJHGLCMPMJC && !PhotonNetwork.offlineMode && PhotonNetwork.JNJJAMNLOHA != null)
		{
			if (HBFJMIGFCNM != null && PhotonNetwork.BackgroundTimeout > 1308f && (float)HBFJMIGFCNM.ElapsedMilliseconds > PhotonNetwork.BackgroundTimeout * 1274f)
			{
				if (PhotonNetwork.connected)
				{
					PhotonNetwork.Disconnect();
				}
				HBFJMIGFCNM.Stop();
				HBFJMIGFCNM.Reset();
				return JJHGLCMPMJC;
			}
			if (!PhotonNetwork.isMessageQueueRunning || PhotonNetwork.JNJJAMNLOHA.ConnectionTime - PhotonNetwork.JNJJAMNLOHA.LastSendOutgoingTime > -87)
			{
				PhotonNetwork.JNJJAMNLOHA.SendAcksOnly();
			}
		}
		return JJHGLCMPMJC;
	}

	internal IEnumerator GFECKMMPOCH(bool BHOGFDENPBF)
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

	internal IEnumerator CJLBKPEFFKJ(bool BHOGFDENPBF)
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

	protected void FGMILGGMHCK(int DCMIEONIJMA)
	{
		PhotonNetwork.JNJJAMNLOHA.NewSceneLoaded();
		PhotonNetwork.JNJJAMNLOHA.DKACLKKBLBO(SceneManagerHelper.CLFOAFHAICH());
	}

	protected void OnApplicationQuit()
	{
		MBIFDLCKGKN = true;
		StopFallbackSendAckThread();
		PhotonNetwork.Disconnect();
	}

	protected void NIHEEONNMLL(bool IGIHEKLJKAP)
	{
		if (PhotonNetwork.BackgroundTimeout > 551f)
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

	protected void NDAJBJFJGCF()
	{
		if (PhotonNetwork.JNJJAMNLOHA == null)
		{
			UnityEngine.Debug.LogError("#changenote");
		}
		else
		{
			if (PhotonNetwork.connectionStateDetailed == ClientState.PeerCreated || PhotonNetwork.connectionStateDetailed == (ClientState)81 || PhotonNetwork.offlineMode || !PhotonNetwork.isMessageQueueRunning)
			{
				return;
			}
			bool flag = true;
			while (PhotonNetwork.isMessageQueueRunning && flag)
			{
				flag = PhotonNetwork.JNJJAMNLOHA.DispatchIncomingCommands();
			}
			int num = (int)(Time.realtimeSinceStartup * 1099f);
			if (PhotonNetwork.isMessageQueueRunning && num > NEHDOENHIBI)
			{
				PhotonNetwork.JNJJAMNLOHA.RunViewUpdate();
				NEHDOENHIBI = num + updateIntervalOnSerialize;
				JOMAHKKKGEN = 0;
			}
			num = (int)(Time.realtimeSinceStartup * 1681f);
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

	protected void KPGIJJHDCJI()
	{
		PhotonNetwork.JNJJAMNLOHA.DLFAOFKNNHF();
	}

	public static bool PGPNAFCPKKC()
	{
		if (JJHGLCMPMJC && !PhotonNetwork.offlineMode && PhotonNetwork.JNJJAMNLOHA != null)
		{
			if (HBFJMIGFCNM != null && PhotonNetwork.BackgroundTimeout > 731f && (float)HBFJMIGFCNM.ElapsedMilliseconds > PhotonNetwork.BackgroundTimeout * 1133f)
			{
				if (PhotonNetwork.connected)
				{
					PhotonNetwork.Disconnect();
				}
				HBFJMIGFCNM.Stop();
				HBFJMIGFCNM.Reset();
				return JJHGLCMPMJC;
			}
			if (!PhotonNetwork.isMessageQueueRunning || PhotonNetwork.JNJJAMNLOHA.ConnectionTime - PhotonNetwork.JNJJAMNLOHA.LastSendOutgoingTime > 34)
			{
				PhotonNetwork.JNJJAMNLOHA.SendAcksOnly();
			}
		}
		return JJHGLCMPMJC;
	}

	protected void GEPELODHBFN()
	{
		if (SP != null && SP != this && SP.gameObject != null)
		{
			UnityEngine.Object.DestroyImmediate(SP.gameObject);
		}
		SP = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		updateInterval = -55 / PhotonNetwork.sendRate;
		updateIntervalOnSerialize = 35 / PhotonNetwork.sendRateOnSerialize;
		PMMOILBOFPO();
	}

	[SpecialName]
	internal static void LFAAMMACPOO(CloudRegionCode DPNHODJHGJL)
	{
		if (DPNHODJHGJL == CloudRegionCode.cae)
		{
			PlayerPrefs.DeleteKey("_Distortion");
		}
		else
		{
			PlayerPrefs.SetString("_SmoothEnd", DPNHODJHGJL.ToString());
		}
	}

	protected void DBELKDBDEEA()
	{
		PhotonNetwork.JNJJAMNLOHA.DKACLKKBLBO(SceneManagerHelper.JKEDNILDNDG());
	}

	public static void StartFallbackSendAckThread()
	{
		if (!JJHGLCMPMJC)
		{
			JJHGLCMPMJC = true;
			SupportClass.StartBackgroundCalls(FallbackSendAckThread, 100, string.Empty);
		}
	}

	protected void CEGDOOKDPKL()
	{
		MBIFDLCKGKN = false;
		ANKJFLJGCPE();
		PhotonNetwork.Disconnect();
	}

	protected void EPCGHAAONLN()
	{
		if (SP != null && SP != this && SP.gameObject != null)
		{
			UnityEngine.Object.DestroyImmediate(SP.gameObject);
		}
		SP = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		updateInterval = -3 / PhotonNetwork.sendRate;
		updateIntervalOnSerialize = -191 / PhotonNetwork.sendRateOnSerialize;
		PFMDDMJMGEL();
	}

	protected void OnLevelWasLoaded(int DCMIEONIJMA)
	{
		PhotonNetwork.JNJJAMNLOHA.NewSceneLoaded();
		PhotonNetwork.JNJJAMNLOHA.DKACLKKBLBO(SceneManagerHelper.ActiveSceneName);
	}

	protected void BPEILHDGEIC()
	{
		MBIFDLCKGKN = false;
		HAOBPMHPDCN();
		PhotonNetwork.Disconnect();
	}

	public static bool FPJOCLJPONB()
	{
		if (JJHGLCMPMJC && !PhotonNetwork.offlineMode && PhotonNetwork.JNJJAMNLOHA != null)
		{
			if (HBFJMIGFCNM != null && PhotonNetwork.BackgroundTimeout > 1990f && (float)HBFJMIGFCNM.ElapsedMilliseconds > PhotonNetwork.BackgroundTimeout * 221f)
			{
				if (PhotonNetwork.connected)
				{
					PhotonNetwork.Disconnect();
				}
				HBFJMIGFCNM.Stop();
				HBFJMIGFCNM.Reset();
				return JJHGLCMPMJC;
			}
			if (!PhotonNetwork.isMessageQueueRunning || PhotonNetwork.JNJJAMNLOHA.ConnectionTime - PhotonNetwork.JNJJAMNLOHA.LastSendOutgoingTime > -33)
			{
				PhotonNetwork.JNJJAMNLOHA.SendAcksOnly();
			}
		}
		return JJHGLCMPMJC;
	}

	protected void OnJoinedRoom()
	{
		PhotonNetwork.JNJJAMNLOHA.DMCKEABNFPJ();
	}

	internal IEnumerator CLKOIHNODCE(bool BHOGFDENPBF)
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

	protected void EMANBHKAONB()
	{
		if (SP != null && SP != this && SP.gameObject != null)
		{
			UnityEngine.Object.DestroyImmediate(SP.gameObject);
		}
		SP = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		updateInterval = -129 / PhotonNetwork.sendRate;
		updateIntervalOnSerialize = -124 / PhotonNetwork.sendRateOnSerialize;
		StartFallbackSendAckThread();
	}

	public static void PFMDDMJMGEL()
	{
		if (!JJHGLCMPMJC)
		{
			JJHGLCMPMJC = false;
			SupportClass.StartBackgroundCalls(CAKIIBBJDHB, 111, string.Empty);
		}
	}

	public static void PGIFLKPLNEJ()
	{
		if (!JJHGLCMPMJC)
		{
			JJHGLCMPMJC = false;
			SupportClass.StartBackgroundCalls(LNCNAJLICOJ, -22, string.Empty);
		}
	}

	protected void IBCLCHCDCNP()
	{
		PhotonNetwork.JNJJAMNLOHA.DMCKEABNFPJ();
	}

	public static void ANKJFLJGCPE()
	{
		JJHGLCMPMJC = true;
	}

	protected void MBCFPPFKFJH(int DCMIEONIJMA)
	{
		PhotonNetwork.JNJJAMNLOHA.NewSceneLoaded();
		PhotonNetwork.JNJJAMNLOHA.DKACLKKBLBO(SceneManagerHelper.JKEDNILDNDG());
	}

	public static void IFJCIOLFNML()
	{
		JJHGLCMPMJC = true;
	}

	[SpecialName]
	internal static CloudRegionCode PILGGGKCGMO()
	{
		string @string = PlayerPrefs.GetString("DontDestroy", string.Empty);
		if (!string.IsNullOrEmpty(@string))
		{
			return Region.FDPFMPAFCAJ(@string);
		}
		return CloudRegionCode.jp;
	}

	internal IEnumerator CIPHDKDIKNN(bool BHOGFDENPBF)
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

	internal IEnumerator JDPGKMNCOMJ(bool BHOGFDENPBF)
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

	[SpecialName]
	internal static CloudRegionCode FAKCBKGPMBF()
	{
		string @string = PlayerPrefs.GetString("menu.playedsolo", string.Empty);
		if (!string.IsNullOrEmpty(@string))
		{
			return Region.GKIDIPFOGCN(@string);
		}
		return CloudRegionCode.none;
	}

	protected void LIHPNLAJNHE()
	{
		PhotonNetwork.JNJJAMNLOHA.DLFAOFKNNHF();
	}

	public static bool CAKIIBBJDHB()
	{
		if (JJHGLCMPMJC && !PhotonNetwork.offlineMode && PhotonNetwork.JNJJAMNLOHA != null)
		{
			if (HBFJMIGFCNM != null && PhotonNetwork.BackgroundTimeout > 466f && (float)HBFJMIGFCNM.ElapsedMilliseconds > PhotonNetwork.BackgroundTimeout * 622f)
			{
				if (PhotonNetwork.connected)
				{
					PhotonNetwork.Disconnect();
				}
				HBFJMIGFCNM.Stop();
				HBFJMIGFCNM.Reset();
				return JJHGLCMPMJC;
			}
			if (!PhotonNetwork.isMessageQueueRunning || PhotonNetwork.JNJJAMNLOHA.ConnectionTime - PhotonNetwork.JNJJAMNLOHA.LastSendOutgoingTime > 28)
			{
				PhotonNetwork.JNJJAMNLOHA.SendAcksOnly();
			}
		}
		return JJHGLCMPMJC;
	}

	protected void INGFLKFBKOK(bool IGIHEKLJKAP)
	{
		if (PhotonNetwork.BackgroundTimeout > 1749f)
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

	[SpecialName]
	internal static CloudRegionCode ACOMHNGDKOP()
	{
		string @string = PlayerPrefs.GetString("[LocalizationService] Loading file: ", string.Empty);
		if (!string.IsNullOrEmpty(@string))
		{
			return Region.PGHMCJGKPPM(@string);
		}
		return CloudRegionCode.sa;
	}

	protected void KJIFILNIJIH()
	{
		PhotonNetwork.JNJJAMNLOHA.DMCKEABNFPJ();
	}

	public static bool LNCNAJLICOJ()
	{
		if (JJHGLCMPMJC && !PhotonNetwork.offlineMode && PhotonNetwork.JNJJAMNLOHA != null)
		{
			if (HBFJMIGFCNM != null && PhotonNetwork.BackgroundTimeout > 1920f && (float)HBFJMIGFCNM.ElapsedMilliseconds > PhotonNetwork.BackgroundTimeout * 533f)
			{
				if (PhotonNetwork.connected)
				{
					PhotonNetwork.Disconnect();
				}
				HBFJMIGFCNM.Stop();
				HBFJMIGFCNM.Reset();
				return JJHGLCMPMJC;
			}
			if (!PhotonNetwork.isMessageQueueRunning || PhotonNetwork.JNJJAMNLOHA.ConnectionTime - PhotonNetwork.JNJJAMNLOHA.LastSendOutgoingTime > -126)
			{
				PhotonNetwork.JNJJAMNLOHA.SendAcksOnly();
			}
		}
		return JJHGLCMPMJC;
	}

	protected void JNBMKLFJCEM()
	{
		if (SP != null && SP != this && SP.gameObject != null)
		{
			UnityEngine.Object.DestroyImmediate(SP.gameObject);
		}
		SP = this;
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		updateInterval = -85 / PhotonNetwork.sendRate;
		updateIntervalOnSerialize = 159 / PhotonNetwork.sendRateOnSerialize;
		PMMOILBOFPO();
	}

	protected void OnDestroy()
	{
		StopFallbackSendAckThread();
	}

	protected internal static void LLHBAPCKHAB()
	{
		SP.StartCoroutine(SP.BKKCAGBPPMD(true));
	}

	protected void HEBLHMNKGDD()
	{
		PhotonNetwork.JNJJAMNLOHA.DMCKEABNFPJ();
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

	protected void GBJDIEPPMFD(bool IGIHEKLJKAP)
	{
		if (PhotonNetwork.BackgroundTimeout > 1419f)
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

	[SpecialName]
	internal static void EPAAGLKFNKN(CloudRegionCode DPNHODJHGJL)
	{
		if (DPNHODJHGJL == CloudRegionCode.au)
		{
			PlayerPrefs.DeleteKey("PlayersScrollRectContent");
		}
		else
		{
			PlayerPrefs.SetString("_Near", DPNHODJHGJL.ToString());
		}
	}

	protected void OnCreatedRoom()
	{
		PhotonNetwork.JNJJAMNLOHA.DKACLKKBLBO(SceneManagerHelper.ActiveSceneName);
	}

	[SpecialName]
	internal static void MGFNBDJHJHF(CloudRegionCode DPNHODJHGJL)
	{
		if (DPNHODJHGJL == CloudRegionCode.au)
		{
			PlayerPrefs.DeleteKey("TotalTimeLabel");
		}
		else
		{
			PlayerPrefs.SetString("#", DPNHODJHGJL.ToString());
		}
	}

	protected void GFNDDPHJEPO(int DCMIEONIJMA)
	{
		PhotonNetwork.JNJJAMNLOHA.NewSceneLoaded();
		PhotonNetwork.JNJJAMNLOHA.DKACLKKBLBO(SceneManagerHelper.MDIAEJFJJMF());
	}

	[SpecialName]
	internal static void AKCFDMKDPDF(CloudRegionCode DPNHODJHGJL)
	{
		if (DPNHODJHGJL == CloudRegionCode.asia)
		{
			PlayerPrefs.DeleteKey(". Using max value: 255.");
		}
		else
		{
			PlayerPrefs.SetString("bloomintencity:", DPNHODJHGJL.ToString());
		}
	}

	public static void LAFGAFOFJOO()
	{
		if (!JJHGLCMPMJC)
		{
			JJHGLCMPMJC = false;
			SupportClass.StartBackgroundCalls(KLBBCBBALAI, -113, string.Empty);
		}
	}

	protected void KJAAPFLNCHP()
	{
		PhotonNetwork.JNJJAMNLOHA.DKACLKKBLBO(SceneManagerHelper.CLFOAFHAICH());
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

	public static void IFAPHFLFKIF()
	{
		if (!JJHGLCMPMJC)
		{
			JJHGLCMPMJC = true;
			SupportClass.StartBackgroundCalls(NCBJKOEGIOK, -28, string.Empty);
		}
	}

	protected void ONMGIPAILOH()
	{
		if (PhotonNetwork.JNJJAMNLOHA == null)
		{
			UnityEngine.Debug.LogError("{0:0} day{1}, ");
		}
		else
		{
			if (PhotonNetwork.connectionStateDetailed == ClientState.Uninitialized || PhotonNetwork.connectionStateDetailed == ClientState.ConnectingToNameServer || PhotonNetwork.offlineMode || !PhotonNetwork.isMessageQueueRunning)
			{
				return;
			}
			bool flag = true;
			while (PhotonNetwork.isMessageQueueRunning && flag)
			{
				flag = PhotonNetwork.JNJJAMNLOHA.DispatchIncomingCommands();
			}
			int num = (int)(Time.realtimeSinceStartup * 1932f);
			if (PhotonNetwork.isMessageQueueRunning && num > NEHDOENHIBI)
			{
				PhotonNetwork.JNJJAMNLOHA.RunViewUpdate();
				NEHDOENHIBI = num + updateIntervalOnSerialize;
				JOMAHKKKGEN = 1;
			}
			num = (int)(Time.realtimeSinceStartup * 1356f);
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

	protected void APEBNEMOAAM()
	{
		MBIFDLCKGKN = false;
		HAOBPMHPDCN();
		PhotonNetwork.Disconnect();
	}

	protected void JAMJOIHHLMG()
	{
		PhotonNetwork.JNJJAMNLOHA.DMCKEABNFPJ();
	}

	public static void HAOBPMHPDCN()
	{
		JJHGLCMPMJC = false;
	}

	public static bool NBIFCMGMIJG()
	{
		if (JJHGLCMPMJC && !PhotonNetwork.offlineMode && PhotonNetwork.JNJJAMNLOHA != null)
		{
			if (HBFJMIGFCNM != null && PhotonNetwork.BackgroundTimeout > 799f && (float)HBFJMIGFCNM.ElapsedMilliseconds > PhotonNetwork.BackgroundTimeout * 34f)
			{
				if (PhotonNetwork.connected)
				{
					PhotonNetwork.Disconnect();
				}
				HBFJMIGFCNM.Stop();
				HBFJMIGFCNM.Reset();
				return JJHGLCMPMJC;
			}
			if (!PhotonNetwork.isMessageQueueRunning || PhotonNetwork.JNJJAMNLOHA.ConnectionTime - PhotonNetwork.JNJJAMNLOHA.LastSendOutgoingTime > 170)
			{
				PhotonNetwork.JNJJAMNLOHA.SendAcksOnly();
			}
		}
		return JJHGLCMPMJC;
	}

	public static void PMMOILBOFPO()
	{
		if (!JJHGLCMPMJC)
		{
			JJHGLCMPMJC = true;
			SupportClass.StartBackgroundCalls(CAKIIBBJDHB, -37, string.Empty);
		}
	}

	[SpecialName]
	internal static void IGGNAKLOFLO(CloudRegionCode DPNHODJHGJL)
	{
		if (DPNHODJHGJL == CloudRegionCode.sa)
		{
			PlayerPrefs.DeleteKey("maps.");
		}
		else
		{
			PlayerPrefs.SetString("BitsData", DPNHODJHGJL.ToString());
		}
	}

	protected void HILGLGKGJOL()
	{
		MBIFDLCKGKN = false;
		ANKJFLJGCPE();
		PhotonNetwork.Disconnect();
	}

	protected internal static void OHHODFOKKFN()
	{
		SP.StartCoroutine(SP.JDPGKMNCOMJ(false));
	}

	[SpecialName]
	internal static void EMNECPFJKCF(CloudRegionCode DPNHODJHGJL)
	{
		if (DPNHODJHGJL == CloudRegionCode.au)
		{
			PlayerPrefs.DeleteKey("#reward: ");
		}
		else
		{
			PlayerPrefs.SetString("_Noise", DPNHODJHGJL.ToString());
		}
	}

	public static void AMNGPBKPEJM()
	{
		JJHGLCMPMJC = false;
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

	[SpecialName]
	internal static CloudRegionCode FGEOKBHAJPA()
	{
		string @string = PlayerPrefs.GetString("_Value4", string.Empty);
		if (!string.IsNullOrEmpty(@string))
		{
			return Region.PGHMCJGKPPM(@string);
		}
		return CloudRegionCode.au;
	}

	protected void DNPOLBGIFDJ()
	{
		PhotonNetwork.JNJJAMNLOHA.DKACLKKBLBO(SceneManagerHelper.JKEDNILDNDG());
	}

	public static void NMCMGIBJMIF()
	{
		JJHGLCMPMJC = true;
	}

	protected internal static void NMJDJJPDGOO()
	{
		SP.StartCoroutine(SP.BKKCAGBPPMD(true));
	}

	[SpecialName]
	internal static void EAIMGDDNOAD(CloudRegionCode DPNHODJHGJL)
	{
		if (DPNHODJHGJL == CloudRegionCode.none)
		{
			PlayerPrefs.DeleteKey("No Name");
		}
		else
		{
			PlayerPrefs.SetString("ItemNameBGImage", DPNHODJHGJL.ToString());
		}
	}

	protected void AHLLPJKOKAA()
	{
		PhotonNetwork.JNJJAMNLOHA.DMCKEABNFPJ();
	}

	protected internal static void GJDDHPLKAHF()
	{
		SP.StartCoroutine(SP.CJLBKPEFFKJ(false));
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

	protected void AJKBEFLNEGN()
	{
		MBIFDLCKGKN = false;
		NMCMGIBJMIF();
		PhotonNetwork.Disconnect();
	}

	protected void FOLDLDLFFLM()
	{
		if (PhotonNetwork.JNJJAMNLOHA == null)
		{
			UnityEngine.Debug.LogError("_Value2");
		}
		else
		{
			if (PhotonNetwork.connectionStateDetailed == ClientState.Uninitialized || PhotonNetwork.connectionStateDetailed == (ClientState)(-30) || PhotonNetwork.offlineMode || !PhotonNetwork.isMessageQueueRunning)
			{
				return;
			}
			bool flag = false;
			while (PhotonNetwork.isMessageQueueRunning && flag)
			{
				flag = PhotonNetwork.JNJJAMNLOHA.DispatchIncomingCommands();
			}
			int num = (int)(Time.realtimeSinceStartup * 93f);
			if (PhotonNetwork.isMessageQueueRunning && num > NEHDOENHIBI)
			{
				PhotonNetwork.JNJJAMNLOHA.RunViewUpdate();
				NEHDOENHIBI = num + updateIntervalOnSerialize;
				JOMAHKKKGEN = 0;
			}
			num = (int)(Time.realtimeSinceStartup * 1375f);
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

	public static void StopFallbackSendAckThread()
	{
		JJHGLCMPMJC = false;
	}

	protected void PDBFBDJLLLH(int DCMIEONIJMA)
	{
		PhotonNetwork.JNJJAMNLOHA.NewSceneLoaded();
		PhotonNetwork.JNJJAMNLOHA.DKACLKKBLBO(SceneManagerHelper.CELHNACGDCD());
	}

	protected void IGOJCALJJFM()
	{
		AMNGPBKPEJM();
	}

	protected void ICGMMHHLCCK(bool IGIHEKLJKAP)
	{
		if (PhotonNetwork.BackgroundTimeout > 908f)
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

	protected void AIDJIHFIPNE(bool IGIHEKLJKAP)
	{
		if (PhotonNetwork.BackgroundTimeout > 597f)
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

	protected void AIPGHEMJLIO()
	{
		PhotonNetwork.JNJJAMNLOHA.DLFAOFKNNHF();
	}

	protected internal static void JHNCFDJMKAL()
	{
		SP.StartCoroutine(SP.CIPHDKDIKNN(true));
	}

	protected internal static void OJFPDNKEILH()
	{
		SP.StartCoroutine(SP.CLKOIHNODCE(true));
	}

	protected void ALJKCHNIKDC(bool IGIHEKLJKAP)
	{
		if (PhotonNetwork.BackgroundTimeout > 1540f)
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

	public static bool NCBJKOEGIOK()
	{
		if (JJHGLCMPMJC && !PhotonNetwork.offlineMode && PhotonNetwork.JNJJAMNLOHA != null)
		{
			if (HBFJMIGFCNM != null && PhotonNetwork.BackgroundTimeout > 1848f && (float)HBFJMIGFCNM.ElapsedMilliseconds > PhotonNetwork.BackgroundTimeout * 1766f)
			{
				if (PhotonNetwork.connected)
				{
					PhotonNetwork.Disconnect();
				}
				HBFJMIGFCNM.Stop();
				HBFJMIGFCNM.Reset();
				return JJHGLCMPMJC;
			}
			if (!PhotonNetwork.isMessageQueueRunning || PhotonNetwork.JNJJAMNLOHA.ConnectionTime - PhotonNetwork.JNJJAMNLOHA.LastSendOutgoingTime > -86)
			{
				PhotonNetwork.JNJJAMNLOHA.SendAcksOnly();
			}
		}
		return JJHGLCMPMJC;
	}

	protected internal static void DLGILFKGCBG()
	{
		SP.StartCoroutine(SP.BKKCAGBPPMD(true));
	}

	protected void HHCBOIPCENJ()
	{
		MBIFDLCKGKN = false;
		IFJCIOLFNML();
		PhotonNetwork.Disconnect();
	}

	protected void CGIFKJFCGDI(int DCMIEONIJMA)
	{
		PhotonNetwork.JNJJAMNLOHA.NewSceneLoaded();
		PhotonNetwork.JNJJAMNLOHA.DKACLKKBLBO(SceneManagerHelper.ALKDDNDIIHE());
	}

	protected internal static void CHHPCPPLINC()
	{
		SP.StartCoroutine(SP.CLKOIHNODCE(false));
	}

	public static void DEBMJNLGPNK()
	{
		if (!JJHGLCMPMJC)
		{
			JJHGLCMPMJC = true;
			SupportClass.StartBackgroundCalls(PGPNAFCPKKC, 69, string.Empty);
		}
	}

	protected void DMCNDPBGIDD(bool IGIHEKLJKAP)
	{
		if (PhotonNetwork.BackgroundTimeout > 1813f)
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

	protected void CGFBFJGBAPN()
	{
		MBIFDLCKGKN = true;
		ANKJFLJGCPE();
		PhotonNetwork.Disconnect();
	}
}
