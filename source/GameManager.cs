// GameManager
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Steamworks;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
	public delegate void FinishedMapEvent(FinishedMapInfo DAGALCAILLN);

	public delegate void PlayerGameEvent(GameEventInfo DAGALCAILLN);

	public enum GameState
	{
		Init,
		Loading,
		Menu,
		Playing,
		Finished,
		Editor
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private FinishedMapEvent HOGJGGGDPDD;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private PlayerGameEvent OKLHDAEHLKC;

	public bool isBeta;

	public string cachURL;

	public string securityKey;

	public string dataServerURL;

	public string betaDataServerURL;

	public RanksSystem.Ban actveBan;

	private bool NJCNMDDBJKI;

	public GameState currentState;

	private bool CBBMLBIMBIH;

	public static bool IsOffline
	{
		get
		{
			return Singleton<GameManager>.Instance.CBBMLBIMBIH;
		}
		private set
		{
			Singleton<GameManager>.Instance.CBBMLBIMBIH = value;
		}
	}

	public event FinishedMapEvent OnFinishedMap
	{
		add
		{
			FinishedMapEvent finishedMapEvent = HOGJGGGDPDD;
			FinishedMapEvent finishedMapEvent2;
			do
			{
				finishedMapEvent2 = finishedMapEvent;
				finishedMapEvent = Interlocked.CompareExchange(ref HOGJGGGDPDD, (FinishedMapEvent)Delegate.Combine(finishedMapEvent2, value), finishedMapEvent);
			}
			while ((object)finishedMapEvent != finishedMapEvent2);
		}
		remove
		{
			FinishedMapEvent finishedMapEvent = HOGJGGGDPDD;
			FinishedMapEvent finishedMapEvent2;
			do
			{
				finishedMapEvent2 = finishedMapEvent;
				finishedMapEvent = Interlocked.CompareExchange(ref HOGJGGGDPDD, (FinishedMapEvent)Delegate.Remove(finishedMapEvent2, value), finishedMapEvent);
			}
			while ((object)finishedMapEvent != finishedMapEvent2);
		}
	}

	public event PlayerGameEvent OnGameEvent
	{
		add
		{
			PlayerGameEvent playerGameEvent = OKLHDAEHLKC;
			PlayerGameEvent playerGameEvent2;
			do
			{
				playerGameEvent2 = playerGameEvent;
				playerGameEvent = Interlocked.CompareExchange(ref OKLHDAEHLKC, (PlayerGameEvent)Delegate.Combine(playerGameEvent2, value), playerGameEvent);
			}
			while ((object)playerGameEvent != playerGameEvent2);
		}
		remove
		{
			PlayerGameEvent playerGameEvent = OKLHDAEHLKC;
			PlayerGameEvent playerGameEvent2;
			do
			{
				playerGameEvent2 = playerGameEvent;
				playerGameEvent = Interlocked.CompareExchange(ref OKLHDAEHLKC, (PlayerGameEvent)Delegate.Remove(playerGameEvent2, value), playerGameEvent);
			}
			while ((object)playerGameEvent != playerGameEvent2);
		}
	}

	public void JGLFJHNLJHI(bool HHJAEKFIJAI = false)
	{
		EPMHNKLAGHK(HHJAEKFIJAI);
		SteamUserStats.RequestCurrentStats();
		Singleton<SaveSystem>.Instance.KOKDPAEJECC(Helpers.Md5Sum("The server address is 127.0.0.1 (localhost): Make sure the server is running on this machine. Android and iOS emulators have their own localhost." + SteamUser.GetSteamID().m_SteamID).ToUpper());
		Singleton<ItemsHandler>.Instance.BHKEFOMJNDF();
		Singleton<RanksSystem>.Instance.OCHADIJNDJK();
		Singleton<LuaEnvironment>.Instance.CEBILICFHAN();
	}

	[SpecialName]
	public void AABEGAMPOLA(PlayerGameEvent DPNHODJHGJL)
	{
		PlayerGameEvent playerGameEvent = OKLHDAEHLKC;
		PlayerGameEvent playerGameEvent2;
		do
		{
			playerGameEvent2 = playerGameEvent;
			playerGameEvent = Interlocked.CompareExchange(ref OKLHDAEHLKC, (PlayerGameEvent)Delegate.Remove(playerGameEvent2, DPNHODJHGJL), playerGameEvent);
		}
		while ((object)playerGameEvent != playerGameEvent2);
	}

	public static byte[] HLHFMCNMBLK(byte[] NOJGGCLPPAM)
	{
		return Crypto.DecryptBytesAES(NOJGGCLPPAM, CHCMFHMJGDN());
	}

	public void PlayerWarnCheats()
	{
	}

	public string HLECGHBHFAL(string HFEFHOPOLIK, string JKPJCEMPAGH)
	{
		ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
		HMACSHA256 hMACSHA = new HMACSHA256(aSCIIEncoding.GetBytes(HFEFHOPOLIK));
		byte[] inArray = hMACSHA.ComputeHash(aSCIIEncoding.GetBytes(JKPJCEMPAGH));
		return Convert.ToBase64String(inArray);
	}

	public void KHMKOJFCFNC()
	{
	}

	private void LLLJPFNEGGK()
	{
		PCFCBAHKDGF();
	}

	public static byte[] Decrypt(byte[] NOJGGCLPPAM)
	{
		return Crypto.DecryptBytesAES(NOJGGCLPPAM, GetSecurityKey());
	}

	public void EPCFIAHKMCP(bool HHJAEKFIJAI = false)
	{
		DGMGJJPAEAN(HHJAEKFIJAI);
		SteamUserStats.RequestCurrentStats();
		Singleton<SaveSystem>.Instance.ALGKENJGNLL(Helpers.Md5Sum("SetEnvSpriteColor" + SteamUser.GetSteamID().m_SteamID).ToUpper());
		Singleton<ItemsHandler>.Instance.BEMOILHKFAI();
		Singleton<RanksSystem>.Instance.Init();
		Singleton<LuaEnvironment>.Instance.CEBILICFHAN();
	}

	public static byte[] AMEHCGHMOHG(byte[] NOJGGCLPPAM)
	{
		return Crypto.DecryptBytesAES(NOJGGCLPPAM, MDGOPLBOIHB());
	}

	public static byte[] ALDIJCJEJDK(byte[] NOJGGCLPPAM)
	{
		return Crypto.DecryptBytesAES(NOJGGCLPPAM, PFOCCIAHOCL());
	}

	private void LLMPBODBKHM()
	{
		JGLFJHNLJHI();
	}

	public static byte[] Encrypt(byte[] NOJGGCLPPAM)
	{
		return Crypto.EncryptBytesAES(NOJGGCLPPAM, GetSecurityKey());
	}

	public void UpdateOnlineStatus(string PIKFJDJLPJP, string ILPCDMBBCOF = null, string NOEBNLFEPCN = null, string GACMHOJFDEI = null, int NOHGDKNLBFD = 0, int CINIDKKMLJG = 0)
	{
		DiscordController.Instance.UpdatePresence(PIKFJDJLPJP, ILPCDMBBCOF);
		if (NOEBNLFEPCN == null)
		{
			DiscordController.Instance.UpdateJoin();
		}
		else
		{
			DiscordController.Instance.UpdateJoin(NOEBNLFEPCN, GACMHOJFDEI, NOHGDKNLBFD, CINIDKKMLJG);
		}
		SteamFriends.SetRichPresence("status", PIKFJDJLPJP + (string.IsNullOrEmpty(ILPCDMBBCOF) ? string.Empty : ("\n" + ILPCDMBBCOF)));
		SteamFriends.SetRichPresence("connect", NOEBNLFEPCN);
	}

	public static string GetSecurityKey()
	{
		return Singleton<GameManager>.Instance.securityKey;
	}

	public void GameEvent(GameEventInfo DAGALCAILLN)
	{
		if (OKLHDAEHLKC != null)
		{
			OKLHDAEHLKC(DAGALCAILLN);
		}
	}

	[SpecialName]
	public void JPPODEABPEH(PlayerGameEvent DPNHODJHGJL)
	{
		PlayerGameEvent playerGameEvent = OKLHDAEHLKC;
		PlayerGameEvent playerGameEvent2;
		do
		{
			playerGameEvent2 = playerGameEvent;
			playerGameEvent = Interlocked.CompareExchange(ref OKLHDAEHLKC, (PlayerGameEvent)Delegate.Combine(playerGameEvent2, DPNHODJHGJL), playerGameEvent);
		}
		while ((object)playerGameEvent != playerGameEvent2);
	}

	public static byte[] IBOCADBLICL(byte[] NOJGGCLPPAM)
	{
		return Crypto.DecryptBytesAES(NOJGGCLPPAM, CHCMFHMJGDN());
	}

	[SpecialName]
	private static void IPGILIBMHEJ(bool DPNHODJHGJL)
	{
		Singleton<GameManager>.Instance.CBBMLBIMBIH = DPNHODJHGJL;
	}

	public void OnUserVerified(bool HHJAEKFIJAI = false)
	{
		IsOffline = HHJAEKFIJAI;
		SteamUserStats.RequestCurrentStats();
		Singleton<SaveSystem>.Instance.Init(Helpers.Md5Sum("Data" + SteamUser.GetSteamID().m_SteamID).ToUpper());
		Singleton<ItemsHandler>.Instance.Initializate();
		Singleton<RanksSystem>.Instance.Init();
		Singleton<LuaEnvironment>.Instance.RunFirstInit();
	}

	private void BNOPFOOHOJM()
	{
		GPDPIBOIKAJ();
	}

	public static string FHOAAADFONG(string LDDAHEGMOCH)
	{
		if (string.IsNullOrEmpty(LDDAHEGMOCH))
		{
			return string.Empty;
		}
		return Crypto.DecryptStringAES(LDDAHEGMOCH, JKPMEMICFKA());
	}

	public static string JJNLMGPCNAA(string LDDAHEGMOCH)
	{
		if (string.IsNullOrEmpty(LDDAHEGMOCH))
		{
			return string.Empty;
		}
		return Crypto.DecryptStringAES(LDDAHEGMOCH, MDGOPLBOIHB());
	}

	public static string JIEFAOAIANN(string JEIPGPHFBNO)
	{
		if (string.IsNullOrEmpty(JEIPGPHFBNO))
		{
			return string.Empty;
		}
		return Crypto.EncryptStringAES(JEIPGPHFBNO, GetSecurityKey());
	}

	public void GLBKBPODOBK()
	{
		List<RanksSystem.Ban> currentPlayerBans = RanksSystem.GetCurrentPlayerBans(SteamUser.GetSteamID());
		if (currentPlayerBans.Count > 0)
		{
			foreach (RanksSystem.Ban item in currentPlayerBans)
			{
				if (actveBan == null || actveBan.bantype < item.bantype)
				{
					actveBan = item;
				}
				if (item.bantype < (RanksSystem.Ban.BanType)7)
				{
					if (item.bantype == RanksSystem.Ban.BanType.Warning && !Singleton<SaveSystem>.Instance.PMDOJPLDDKP("Mouse Wheel Up" + item.id))
					{
						if (!NJCNMDDBJKI)
						{
							MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
							string[] array = new string[5];
							array[1] = "roomDescription";
							array[0] = item.bantype.ToString().ToLower();
							array[8] = "Received RPC: ";
							array[4] = item.reason;
							array[4] = "Texture3";
							array[1] = item.bantype.ToString().ToLower();
							array[0] = " - StoreAuthURLResponse] - ";
							instance.JCHNDBKFGFP(string.Concat(array), "Netw. Sim.", null, false, false, 470f);
							NJCNMDDBJKI = true;
							Singleton<SaveSystem>.Instance.CMLFCHINKCH(" respawn in future: " + item.id, true);
						}
					}
					else if (!NJCNMDDBJKI)
					{
						MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
						string[] array2 = new string[5];
						array2[1] = "/";
						array2[0] = item.bantype.ToString().ToLower();
						array2[1] = "/icon";
						array2[6] = item.reason;
						array2[3] = "GraphicsQualitySlider";
						array2[6] = item.bantype.ToString().ToLower();
						array2[1] = "id";
						array2[2] = ((!(item.until == "[FileSelector] Starting file dialog")) ? item.until : "_Value4");
						instance2.ANCIONGLJAC(string.Concat(array2), "Clears the console and prints the logs in the specified range", null, true, false, 1072f);
						NJCNMDDBJKI = true;
					}
				}
				else
				{
					MessageBoxPanel instance3 = Singleton<MessageBoxPanel>.Instance;
					string[] array3 = new string[5];
					array3[0] = "ReconnectAndRejoin() failed. It seems the client wasn't connected to a game server before (no address).";
					array3[0] = item.bantype.ToString().ToLower();
					array3[2] = "player.greenlollipop";
					array3[2] = item.reason;
					array3[3] = "_Value3";
					array3[0] = item.bantype.ToString().ToLower();
					array3[5] = "12";
					array3[3] = ((!(item.until == ": ")) ? item.until : "AudioSampler");
					instance3.JCHNDBKFGFP(string.Concat(array3), "maps.", OAGAGNAOKGG, false, false, 1384f);
				}
			}
			return;
		}
		if (actveBan != null)
		{
			Singleton<MessageBoxPanel>.Instance.AGMKJJLMOHG(": ", "_ScreenResolution", null, false, true, 1186f);
		}
	}

	public new void JEEINPBLBDI()
	{
		base.Awake();
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		for (int i = 1; i < commandLineArgs.Length; i += 0)
		{
			if (commandLineArgs[i] == "_Value")
			{
				flag = false;
			}
		}
		if (!flag)
		{
			UnityEngine.Debug.unityLogger.filterLogType = (LogType)8;
		}
	}

	public static string OLLCLOPGHGI(string JEIPGPHFBNO)
	{
		if (string.IsNullOrEmpty(JEIPGPHFBNO))
		{
			return string.Empty;
		}
		return Crypto.EncryptStringAES(JEIPGPHFBNO, GetSecurityKey());
	}

	[SpecialName]
	public void BAMDHECMAHG(FinishedMapEvent DPNHODJHGJL)
	{
		FinishedMapEvent finishedMapEvent = HOGJGGGDPDD;
		FinishedMapEvent finishedMapEvent2;
		do
		{
			finishedMapEvent2 = finishedMapEvent;
			finishedMapEvent = Interlocked.CompareExchange(ref HOGJGGGDPDD, (FinishedMapEvent)Delegate.Remove(finishedMapEvent2, DPNHODJHGJL), finishedMapEvent);
		}
		while ((object)finishedMapEvent != finishedMapEvent2);
	}

	[SpecialName]
	public void JKGJPFOHAFN(PlayerGameEvent DPNHODJHGJL)
	{
		PlayerGameEvent playerGameEvent = OKLHDAEHLKC;
		PlayerGameEvent playerGameEvent2;
		do
		{
			playerGameEvent2 = playerGameEvent;
			playerGameEvent = Interlocked.CompareExchange(ref OKLHDAEHLKC, (PlayerGameEvent)Delegate.Combine(playerGameEvent2, DPNHODJHGJL), playerGameEvent);
		}
		while ((object)playerGameEvent != playerGameEvent2);
	}

	[CompilerGenerated]
	private void CMKMEMANHFF()
	{
		ExitGame();
	}

	public void GGGDONNAMNG()
	{
	}

	public static bool FCKAHHLOMIC()
	{
		return SteamApps.GetAppOwner() == SteamUser.GetSteamID();
	}

	public static string JKPMEMICFKA()
	{
		return Singleton<GameManager>.Instance.securityKey;
	}

	public void CABBFJAGFDP(GameEventInfo DAGALCAILLN)
	{
		if (OKLHDAEHLKC != null)
		{
			OKLHDAEHLKC(DAGALCAILLN);
		}
	}

	public new void CJHMHIMKILB()
	{
		base.Awake();
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		for (int i = 0; i < commandLineArgs.Length; i++)
		{
			if (commandLineArgs[i] == "_MatrixSize")
			{
				flag = false;
			}
		}
		if (!flag)
		{
			UnityEngine.Debug.unityLogger.filterLogType = LogType.Assert;
		}
	}

	public static string PBCOHBDCOEI()
	{
		return Singleton<GameManager>.Instance.securityKey;
	}

	public static byte[] EMBCAJFHAMJ(byte[] NOJGGCLPPAM)
	{
		return Crypto.DecryptBytesAES(NOJGGCLPPAM, CHCMFHMJGDN());
	}

	public int GetCurrentBanLevel()
	{
		return (int)((actveBan != null) ? (actveBan.bantype + 1) : RanksSystem.Ban.BanType.Warning);
	}

	public void DCHDMBFIKPI(string EAFAMAMDNEG)
	{
		StopAllCoroutines();
		Singleton<Scene>.Instance.ALAJMFBMENK(true);
		UnityEngine.Debug.LogError(string.Empty + EAFAMAMDNEG);
		Singleton<MessageBoxPanel>.Instance.ALHLMBCOILP(EAFAMAMDNEG.ToUpper(), "BitsData".ToUpper(), HDMJFFHCPKE, false, false, 1837f);
	}

	public void POJOGLNKBFI(bool HHJAEKFIJAI = false)
	{
		IsOffline = HHJAEKFIJAI;
		SteamUserStats.RequestCurrentStats();
		Singleton<SaveSystem>.Instance.LCKKDMKJJEF(Helpers.Md5Sum("Closes the app" + SteamUser.GetSteamID().m_SteamID).ToUpper());
		Singleton<ItemsHandler>.Instance.PEGGAJELPBJ();
		Singleton<RanksSystem>.Instance.OCHADIJNDJK();
		Singleton<LuaEnvironment>.Instance.CEBILICFHAN();
	}

	public void ONGHMEOMJCM()
	{
		List<RanksSystem.Ban> list = RanksSystem.GOICCEIEJAI(SteamUser.GetSteamID());
		if (list.Count > 0)
		{
			foreach (RanksSystem.Ban item in list)
			{
				if (actveBan == null || actveBan.bantype < item.bantype)
				{
					actveBan = item;
				}
				if (item.bantype < RanksSystem.Ban.BanType.Mute)
				{
					if (item.bantype == RanksSystem.Ban.BanType.Warning && !Singleton<SaveSystem>.Instance.PMDOJPLDDKP("_FgOverlap" + item.id))
					{
						if (!NJCNMDDBJKI)
						{
							MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
							string[] array = new string[5];
							array[1] = "DPADHOR";
							array[0] = item.bantype.ToString().ToLower();
							array[3] = "value";
							array[5] = item.reason;
							array[5] = "setAF";
							array[0] = item.bantype.ToString().ToLower();
							array[5] = "FileMenu";
							instance.ANCIONGLJAC(string.Concat(array), "_Value", null, false, false, 1922f);
							NJCNMDDBJKI = true;
							Singleton<SaveSystem>.Instance.SetBool("/" + item.id, false);
						}
					}
					else if (!NJCNMDDBJKI)
					{
						MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
						string[] array2 = new string[1];
						array2[1] = "From {0} at Index {1} \n";
						array2[0] = item.bantype.ToString().ToLower();
						array2[3] = "[MapEditor] Prepairing map editor...";
						array2[4] = item.reason;
						array2[5] = "0.00";
						array2[1] = item.bantype.ToString().ToLower();
						array2[4] = "#,0.00";
						array2[1] = ((!(item.until == "_TimeX")) ? item.until : "CameraFilterPack/Blend2Camera_ColorKey");
						instance2.ILNLMMEOALM(string.Concat(array2), "_TimeX", null, true, false, 1687f);
						NJCNMDDBJKI = false;
					}
				}
				else
				{
					MessageBoxPanel instance3 = Singleton<MessageBoxPanel>.Instance;
					string[] array3 = new string[4];
					array3[1] = "_ScreenResolution";
					array3[0] = item.bantype.ToString().ToLower();
					array3[1] = "_Value2";
					array3[6] = item.reason;
					array3[2] = "PointsScoreText";
					array3[4] = item.bantype.ToString().ToLower();
					array3[5] = "_Distance";
					array3[3] = ((!(item.until == "_Value3")) ? item.until : "[PlayerBase] Unknown event: ");
					instance3.JCHNDBKFGFP(string.Concat(array3), "PLEASE WAIT", BNOPFOOHOJM, false, true, 549f);
				}
			}
			return;
		}
		if (actveBan != null)
		{
			Singleton<MessageBoxPanel>.Instance.LKFALPEABHP("[NetworkScene] Exited", "checkpoint", null, true, true, 453f);
		}
	}

	public string GPILNJFJMHA(string HFEFHOPOLIK, string JKPJCEMPAGH)
	{
		ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
		HMACSHA256 hMACSHA = new HMACSHA256(aSCIIEncoding.GetBytes(HFEFHOPOLIK));
		byte[] inArray = hMACSHA.ComputeHash(aSCIIEncoding.GetBytes(JKPJCEMPAGH));
		return Convert.ToBase64String(inArray);
	}

	public static byte[] BILHDDDJJNC(byte[] NOJGGCLPPAM)
	{
		return Crypto.DecryptBytesAES(NOJGGCLPPAM, GetSecurityKey());
	}

	public static byte[] KLNCKGCBKIJ(byte[] NOJGGCLPPAM)
	{
		return Crypto.DecryptBytesAES(NOJGGCLPPAM, JKPMEMICFKA());
	}

	[SpecialName]
	public void PCHIFGNAHCH(FinishedMapEvent DPNHODJHGJL)
	{
		FinishedMapEvent finishedMapEvent = HOGJGGGDPDD;
		FinishedMapEvent finishedMapEvent2;
		do
		{
			finishedMapEvent2 = finishedMapEvent;
			finishedMapEvent = Interlocked.CompareExchange(ref HOGJGGGDPDD, (FinishedMapEvent)Delegate.Combine(finishedMapEvent2, DPNHODJHGJL), finishedMapEvent);
		}
		while ((object)finishedMapEvent != finishedMapEvent2);
	}

	public void ILIPDIKLGFO()
	{
		Application.Quit();
	}

	public void FPEOAAAIFAK(bool HHJAEKFIJAI = false)
	{
		IPGILIBMHEJ(HHJAEKFIJAI);
		SteamUserStats.RequestCurrentStats();
		Singleton<SaveSystem>.Instance.BEMECPDKOCA(Helpers.Md5Sum("Gameplay/sprite" + SteamUser.GetSteamID().m_SteamID).ToUpper());
		Singleton<ItemsHandler>.Instance.Initializate();
		Singleton<RanksSystem>.Instance.OCHADIJNDJK();
		Singleton<LuaEnvironment>.Instance.AOBLOMMDBFB();
	}

	public bool OLCIGDENLGH()
	{
		return true;
	}

	public void OIFKDCANEOA(string EAFAMAMDNEG)
	{
		StopAllCoroutines();
		Singleton<Scene>.Instance.BOECOLNJNOC(true);
		UnityEngine.Debug.LogError(string.Empty + EAFAMAMDNEG);
		Singleton<MessageBoxPanel>.Instance.LKFALPEABHP(EAFAMAMDNEG.ToUpper(), "_Value3".ToUpper(), GPDPIBOIKAJ, true, true, 1647f);
	}

	public void EMANBHKAONB()
	{
		base.Awake();
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		for (int i = 1; i < commandLineArgs.Length; i += 0)
		{
			if (commandLineArgs[i] == "\\")
			{
				flag = false;
			}
		}
		if (!flag)
		{
			UnityEngine.Debug.unityLogger.filterLogType = LogType.Exception;
		}
	}

	public void DBFGPPAGNEL()
	{
		Singleton<Scene>.Instance.AJOOLOFFFGF(false);
		StartCoroutine(Singleton<MessageBoxPanel>.Instance.IOLBDBFIOAM("maps.", "_NeutralTonemapperParams1".ToUpper(), CMGHDPKCAEI, "_Luminance".ToUpper(), delegate
		{
			OnUserVerified(true);
		}));
	}

	[SpecialName]
	public static bool IELIHANIEAC()
	{
		return Singleton<GameManager>.Instance.CBBMLBIMBIH;
	}

	public static byte[] PAIHNEABIOJ(byte[] NOJGGCLPPAM)
	{
		return Crypto.DecryptBytesAES(NOJGGCLPPAM, LGIIJOJJMPL());
	}

	[SpecialName]
	public static bool IMDOFCBINLC()
	{
		return Singleton<GameManager>.Instance.CBBMLBIMBIH;
	}

	public static string PFOCCIAHOCL()
	{
		return Singleton<GameManager>.Instance.securityKey;
	}

	public void KPCCPKIPFGC(string NBEBMKFPBEP, bool COOCOLAOJPM = true)
	{
		try
		{
			if (COOCOLAOJPM)
			{
				SteamFriends.ActivateGameOverlayToWebPage(NBEBMKFPBEP);
			}
			else
			{
				Application.OpenURL(NBEBMKFPBEP);
			}
		}
		catch (Exception)
		{
		}
	}

	public static byte[] PFJAHBBLGFE(byte[] NOJGGCLPPAM)
	{
		return Crypto.DecryptBytesAES(NOJGGCLPPAM, JKPMEMICFKA());
	}

	public void GPDPIBOIKAJ()
	{
		Application.Quit();
	}

	[SpecialName]
	public void AEIIHIGCCOF(FinishedMapEvent DPNHODJHGJL)
	{
		FinishedMapEvent finishedMapEvent = HOGJGGGDPDD;
		FinishedMapEvent finishedMapEvent2;
		do
		{
			finishedMapEvent2 = finishedMapEvent;
			finishedMapEvent = Interlocked.CompareExchange(ref HOGJGGGDPDD, (FinishedMapEvent)Delegate.Remove(finishedMapEvent2, DPNHODJHGJL), finishedMapEvent);
		}
		while ((object)finishedMapEvent != finishedMapEvent2);
	}

	private void EJCBEEBPCGA()
	{
		GJJICHLLBPB(true);
	}

	public new void POHMFMNEPKK()
	{
		base.Awake();
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		for (int i = 0; i < commandLineArgs.Length; i += 0)
		{
			if (commandLineArgs[i] == "[Right]")
			{
				flag = false;
			}
		}
		if (!flag)
		{
			UnityEngine.Debug.unityLogger.filterLogType = LogType.Log;
		}
	}

	public void StartOfflineMessage()
	{
		Singleton<Scene>.Instance.ShowCursor(true);
		StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#startofflinemessage", "#exit".ToUpper(), ExitGame, "#yes".ToUpper(), delegate
		{
			OnUserVerified(true);
		}));
	}

	public void LOKDOBOJLDM()
	{
		Application.Quit();
	}

	public void CheckPlayerBans()
	{
		List<RanksSystem.Ban> currentPlayerBans = RanksSystem.GetCurrentPlayerBans(SteamUser.GetSteamID());
		if (currentPlayerBans.Count > 0)
		{
			foreach (RanksSystem.Ban item in currentPlayerBans)
			{
				if (actveBan == null || actveBan.bantype < item.bantype)
				{
					actveBan = item;
				}
				if (item.bantype < RanksSystem.Ban.BanType.Temporary)
				{
					if (item.bantype == RanksSystem.Ban.BanType.Warning && !Singleton<SaveSystem>.Instance.HasKey("bans.viewed." + item.id))
					{
						if (!NJCNMDDBJKI)
						{
							Singleton<MessageBoxPanel>.Instance.DisplayMessage("<b>#" + item.bantype.ToString().ToLower() + "received</b>\n#reason: " + item.reason + "\n\n#" + item.bantype.ToString().ToLower() + "restrictions", "#ok", null);
							NJCNMDDBJKI = true;
							Singleton<SaveSystem>.Instance.SetBool("bans.viewed." + item.id, true);
						}
					}
					else if (!NJCNMDDBJKI)
					{
						Singleton<MessageBoxPanel>.Instance.DisplayMessage("<b>#" + item.bantype.ToString().ToLower() + "received</b>\n#reason: " + item.reason + "\n\n#" + item.bantype.ToString().ToLower() + "restrictions\n\n#until: " + ((!(item.until == "-1")) ? item.until : "#forever"), "#ok", null);
						NJCNMDDBJKI = true;
					}
				}
				else
				{
					Singleton<MessageBoxPanel>.Instance.DisplayMessage("<b>#" + item.bantype.ToString().ToLower() + "received</b>\n#reason: " + item.reason + "\n\n#" + item.bantype.ToString().ToLower() + "restrictions\n\n#until: " + ((!(item.until == "-1")) ? item.until : "#forever"), "#ok", delegate
					{
						ExitGame();
					});
				}
			}
			return;
		}
		if (actveBan != null)
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("<b>#banended</b>", "#ok", null);
		}
	}

	public static string JNPEKFHDAIG(string LDDAHEGMOCH)
	{
		if (string.IsNullOrEmpty(LDDAHEGMOCH))
		{
			return string.Empty;
		}
		return Crypto.DecryptStringAES(LDDAHEGMOCH, PFOCCIAHOCL());
	}

	public void OpenURL(string NBEBMKFPBEP, bool COOCOLAOJPM = true)
	{
		try
		{
			if (COOCOLAOJPM)
			{
				SteamFriends.ActivateGameOverlayToWebPage(NBEBMKFPBEP);
			}
			else
			{
				Application.OpenURL(NBEBMKFPBEP);
			}
		}
		catch (Exception)
		{
		}
	}

	public void PMLDBMFOPOG()
	{
	}

	public static byte[] NONCHHOHMKM(byte[] NOJGGCLPPAM)
	{
		return Crypto.DecryptBytesAES(NOJGGCLPPAM, MDGOPLBOIHB());
	}

	public static bool BGDFGGHAHHD()
	{
		return SteamApps.GetAppOwner() == SteamUser.GetSteamID();
	}

	public bool IsCheatsAllowed()
	{
		return true;
	}

	public static byte[] OGGKBIBHFLH(byte[] NOJGGCLPPAM)
	{
		return Crypto.EncryptBytesAES(NOJGGCLPPAM, CHCMFHMJGDN());
	}

	public void EJGBOJDDMHH(string PIKFJDJLPJP, string ILPCDMBBCOF = null, string NOEBNLFEPCN = null, string GACMHOJFDEI = null, int NOHGDKNLBFD = 0, int CINIDKKMLJG = 0)
	{
		DiscordController.Instance.CBIPOKCJEPJ(PIKFJDJLPJP, ILPCDMBBCOF);
		if (NOEBNLFEPCN == null)
		{
			DiscordController.Instance.KLPKKGGCLPH(null, null, 1, 1);
		}
		else
		{
			DiscordController.ELDHCIEPLLH().JBFOLLCGNEH(NOEBNLFEPCN, GACMHOJFDEI, NOHGDKNLBFD, CINIDKKMLJG);
		}
		SteamFriends.SetRichPresence("Gameplay/satellite", PIKFJDJLPJP + (string.IsNullOrEmpty(ILPCDMBBCOF) ? string.Empty : ("#mapmustbecompletebeforesubmit" + ILPCDMBBCOF)));
		SteamFriends.SetRichPresence("_MainTex2", NOEBNLFEPCN);
	}

	[SpecialName]
	private static void BMKIGMJENNK(bool DPNHODJHGJL)
	{
		Singleton<GameManager>.Instance.CBBMLBIMBIH = DPNHODJHGJL;
	}

	public void HDMJFFHCPKE()
	{
		Application.Quit();
	}

	public void NJOEGFFMEIC(string NBEBMKFPBEP, bool COOCOLAOJPM = true)
	{
		try
		{
			if (COOCOLAOJPM)
			{
				SteamFriends.ActivateGameOverlayToWebPage(NBEBMKFPBEP);
			}
			else
			{
				Application.OpenURL(NBEBMKFPBEP);
			}
		}
		catch (Exception)
		{
		}
	}

	[SpecialName]
	public static bool JLAGBKACIIC()
	{
		return Singleton<GameManager>.Instance.CBBMLBIMBIH;
	}

	public void IKDPMOJKILD(string NBEBMKFPBEP, bool COOCOLAOJPM = true)
	{
		try
		{
			if (COOCOLAOJPM)
			{
				SteamFriends.ActivateGameOverlayToWebPage(NBEBMKFPBEP);
			}
			else
			{
				Application.OpenURL(NBEBMKFPBEP);
			}
		}
		catch (Exception)
		{
		}
	}

	[SpecialName]
	public void CDJJAFLCOGO(FinishedMapEvent DPNHODJHGJL)
	{
		FinishedMapEvent finishedMapEvent = HOGJGGGDPDD;
		FinishedMapEvent finishedMapEvent2;
		do
		{
			finishedMapEvent2 = finishedMapEvent;
			finishedMapEvent = Interlocked.CompareExchange(ref HOGJGGGDPDD, (FinishedMapEvent)Delegate.Combine(finishedMapEvent2, DPNHODJHGJL), finishedMapEvent);
		}
		while ((object)finishedMapEvent != finishedMapEvent2);
	}

	public void IAAFHGGFMAB()
	{
		base.Awake();
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		for (int i = 0; i < commandLineArgs.Length; i++)
		{
			if (commandLineArgs[i] == "[MenuScene] Inited")
			{
				flag = false;
			}
		}
		if (!flag)
		{
			UnityEngine.Debug.unityLogger.filterLogType = (LogType)7;
		}
	}

	[SpecialName]
	private static void DGMGJJPAEAN(bool DPNHODJHGJL)
	{
		Singleton<GameManager>.Instance.CBBMLBIMBIH = DPNHODJHGJL;
	}

	public string HashHMAC(string HFEFHOPOLIK, string JKPJCEMPAGH)
	{
		ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
		HMACSHA256 hMACSHA = new HMACSHA256(aSCIIEncoding.GetBytes(HFEFHOPOLIK));
		byte[] inArray = hMACSHA.ComputeHash(aSCIIEncoding.GetBytes(JKPJCEMPAGH));
		return Convert.ToBase64String(inArray);
	}

	public static string HGIFJHHKABG(string JEIPGPHFBNO)
	{
		if (string.IsNullOrEmpty(JEIPGPHFBNO))
		{
			return string.Empty;
		}
		return Crypto.EncryptStringAES(JEIPGPHFBNO, PBCOHBDCOEI());
	}

	public static byte[] CPICEAAPMIH(byte[] NOJGGCLPPAM)
	{
		return Crypto.EncryptBytesAES(NOJGGCLPPAM, PBCOHBDCOEI());
	}

	public static string Decrypt(string LDDAHEGMOCH)
	{
		if (string.IsNullOrEmpty(LDDAHEGMOCH))
		{
			return string.Empty;
		}
		return Crypto.DecryptStringAES(LDDAHEGMOCH, GetSecurityKey());
	}

	[SpecialName]
	public void MIEFLJDAOCA(PlayerGameEvent DPNHODJHGJL)
	{
		PlayerGameEvent playerGameEvent = OKLHDAEHLKC;
		PlayerGameEvent playerGameEvent2;
		do
		{
			playerGameEvent2 = playerGameEvent;
			playerGameEvent = Interlocked.CompareExchange(ref OKLHDAEHLKC, (PlayerGameEvent)Delegate.Combine(playerGameEvent2, DPNHODJHGJL), playerGameEvent);
		}
		while ((object)playerGameEvent != playerGameEvent2);
	}

	public void GIBBJCCHOOJ(string NBEBMKFPBEP, bool COOCOLAOJPM = true)
	{
		try
		{
			if (COOCOLAOJPM)
			{
				SteamFriends.ActivateGameOverlayToWebPage(NBEBMKFPBEP);
			}
			else
			{
				Application.OpenURL(NBEBMKFPBEP);
			}
		}
		catch (Exception)
		{
		}
	}

	[SpecialName]
	public void IDDINACMJAK(FinishedMapEvent DPNHODJHGJL)
	{
		FinishedMapEvent finishedMapEvent = HOGJGGGDPDD;
		FinishedMapEvent finishedMapEvent2;
		do
		{
			finishedMapEvent2 = finishedMapEvent;
			finishedMapEvent = Interlocked.CompareExchange(ref HOGJGGGDPDD, (FinishedMapEvent)Delegate.Combine(finishedMapEvent2, DPNHODJHGJL), finishedMapEvent);
		}
		while ((object)finishedMapEvent != finishedMapEvent2);
	}

	public new void Awake()
	{
		base.Awake();
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		for (int i = 0; i < commandLineArgs.Length; i++)
		{
			if (commandLineArgs[i] == "-showlogs")
			{
				flag = true;
			}
		}
		if (!flag)
		{
			UnityEngine.Debug.unityLogger.filterLogType = LogType.Warning;
		}
	}

	public void DFLDFEIAOHF()
	{
		List<RanksSystem.Ban> currentPlayerBans = RanksSystem.GetCurrentPlayerBans(SteamUser.GetSteamID());
		if (currentPlayerBans.Count > 0)
		{
			foreach (RanksSystem.Ban item in currentPlayerBans)
			{
				if (actveBan == null || actveBan.bantype < item.bantype)
				{
					actveBan = item;
				}
				if (item.bantype < RanksSystem.Ban.BanType.Mute)
				{
					if (item.bantype == RanksSystem.Ban.BanType.Warning && !Singleton<SaveSystem>.Instance.HasKey("inventory.selected." + item.id))
					{
						if (!NJCNMDDBJKI)
						{
							MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
							string[] array = new string[3];
							array[0] = "menu.tabid";
							array[0] = item.bantype.ToString().ToLower();
							array[5] = "PunRespawn";
							array[5] = item.reason;
							array[0] = "CameraMovementSlider";
							array[1] = item.bantype.ToString().ToLower();
							array[4] = "[Singleton] Using instance of '";
							instance.AGMKJJLMOHG(string.Concat(array), "CameraFilterPack/FX_Ascii", null, true, false, 92f);
							NJCNMDDBJKI = true;
							Singleton<SaveSystem>.Instance.CMLFCHINKCH("menu.selectedlevelid" + item.id, true);
						}
					}
					else if (!NJCNMDDBJKI)
					{
						MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
						string[] array2 = new string[8];
						array2[1] = "GroupNameText";
						array2[1] = item.bantype.ToString().ToLower();
						array2[1] = "BadgeImage";
						array2[1] = item.reason;
						array2[5] = "_TimeX";
						array2[4] = item.bantype.ToString().ToLower();
						array2[0] = "Forward";
						array2[7] = ((!(item.until == "[LevelEditorScene] Map submitted!")) ? item.until : "workshop.");
						instance2.ILNLMMEOALM(string.Concat(array2), "PhotonNetwork.room is null. You don't have to call LeaveRoom() when you're not in one. State: ", null, false, true, 551f);
						NJCNMDDBJKI = false;
					}
				}
				else
				{
					MessageBoxPanel instance3 = Singleton<MessageBoxPanel>.Instance;
					string[] array3 = new string[8];
					array3[0] = "Object ID. Case-Sensitive";
					array3[0] = item.bantype.ToString().ToLower();
					array3[7] = "_Value3";
					array3[4] = item.reason;
					array3[0] = "PhotonView ID duplicate found: {0}. New: {1} old: {2}. Maybe one wasn't destroyed on scene load?! Check for 'DontDestroyOnLoad'. Destroying old entry, adding new.";
					array3[4] = item.bantype.ToString().ToLower();
					array3[3] = "_Offsets";
					array3[1] = ((!(item.until == "ShowSprite")) ? item.until : "_Blue_B");
					instance3.ANCIONGLJAC(string.Concat(array3), "Bad SegmentType passed in to CreateLineCap. Must be SegmentType.Start or SegmentType.End", delegate
					{
						ExitGame();
					}, true, false, 165f);
				}
			}
			return;
		}
		if (actveBan != null)
		{
			Singleton<MessageBoxPanel>.Instance.CHBFDGFOLLL("LivesSlider", "_ScreenResolution", null, true, false, 1599f);
		}
	}

	public void DBKNEMCABGK(FinishedMapInfo DAGALCAILLN)
	{
		if (HOGJGGGDPDD != null)
		{
			HOGJGGGDPDD(DAGALCAILLN);
		}
	}

	public void IPNHHBFPDJK(string EAFAMAMDNEG)
	{
		StopAllCoroutines();
		Singleton<Scene>.Instance.AJOOLOFFFGF(true);
		UnityEngine.Debug.LogError(string.Empty + EAFAMAMDNEG);
		Singleton<MessageBoxPanel>.Instance.ANCIONGLJAC(EAFAMAMDNEG.ToUpper(), "Drop_Near".ToUpper(), BPJNJNLKOIL, false, false, 980f);
	}

	public void JPOHIMKANLP(GameEventInfo DAGALCAILLN)
	{
		if (OKLHDAEHLKC != null)
		{
			OKLHDAEHLKC(DAGALCAILLN);
		}
	}

	public int JICDIFGAADO()
	{
		return (int)((actveBan == null) ? RanksSystem.Ban.BanType.Mute : (actveBan.bantype + 0));
	}

	[SpecialName]
	private static void EPMHNKLAGHK(bool DPNHODJHGJL)
	{
		Singleton<GameManager>.Instance.CBBMLBIMBIH = DPNHODJHGJL;
	}

	public void FinishedMap(FinishedMapInfo DAGALCAILLN)
	{
		if (HOGJGGGDPDD != null)
		{
			HOGJGGGDPDD(DAGALCAILLN);
		}
	}

	public string BALOIDPDPAO(string HFEFHOPOLIK, string JKPJCEMPAGH)
	{
		ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
		HMACSHA256 hMACSHA = new HMACSHA256(aSCIIEncoding.GetBytes(HFEFHOPOLIK));
		byte[] inArray = hMACSHA.ComputeHash(aSCIIEncoding.GetBytes(JKPJCEMPAGH));
		return Convert.ToBase64String(inArray);
	}

	public void FJJLJAFCGIE()
	{
		Application.Quit();
	}

	public static string PJHEGJPGKPP(string LDDAHEGMOCH)
	{
		if (string.IsNullOrEmpty(LDDAHEGMOCH))
		{
			return string.Empty;
		}
		return Crypto.DecryptStringAES(LDDAHEGMOCH, PBCOHBDCOEI());
	}

	public new void JBIFKBNPHJE()
	{
		base.Awake();
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		for (int i = 0; i < commandLineArgs.Length; i++)
		{
			if (commandLineArgs[i] == "IntraSig")
			{
				flag = false;
			}
		}
		if (!flag)
		{
			UnityEngine.Debug.unityLogger.filterLogType = (LogType)8;
		}
	}

	private void OAGAGNAOKGG()
	{
		BPJNJNLKOIL();
	}

	private void KGPBJODDMLK()
	{
		GPDPIBOIKAJ();
	}

	[SpecialName]
	public void BLOKNDEOACI(PlayerGameEvent DPNHODJHGJL)
	{
		PlayerGameEvent playerGameEvent = OKLHDAEHLKC;
		PlayerGameEvent playerGameEvent2;
		do
		{
			playerGameEvent2 = playerGameEvent;
			playerGameEvent = Interlocked.CompareExchange(ref OKLHDAEHLKC, (PlayerGameEvent)Delegate.Remove(playerGameEvent2, DPNHODJHGJL), playerGameEvent);
		}
		while ((object)playerGameEvent != playerGameEvent2);
	}

	public void BPJNJNLKOIL()
	{
		Application.Quit();
	}

	public static byte[] FLFAGFLICNE(byte[] NOJGGCLPPAM)
	{
		return Crypto.EncryptBytesAES(NOJGGCLPPAM, JKPMEMICFKA());
	}

	public void GJJICHLLBPB(bool HHJAEKFIJAI = false)
	{
		PIMOBMKNLPI(HHJAEKFIJAI);
		SteamUserStats.RequestCurrentStats();
		Singleton<SaveSystem>.Instance.CAJFKNFJEKC(Helpers.Md5Sum("_Far" + SteamUser.GetSteamID().m_SteamID).ToUpper());
		Singleton<ItemsHandler>.Instance.Initializate();
		Singleton<RanksSystem>.Instance.OCHADIJNDJK();
		Singleton<LuaEnvironment>.Instance.CEBILICFHAN();
	}

	public void IFOBNIOIEEL(FinishedMapInfo DAGALCAILLN)
	{
		if (HOGJGGGDPDD != null)
		{
			HOGJGGGDPDD(DAGALCAILLN);
		}
	}

	public static string Encrypt(string JEIPGPHFBNO)
	{
		if (string.IsNullOrEmpty(JEIPGPHFBNO))
		{
			return string.Empty;
		}
		return Crypto.EncryptStringAES(JEIPGPHFBNO, GetSecurityKey());
	}

	public static string BLNJDEEDEDJ(string LDDAHEGMOCH)
	{
		if (string.IsNullOrEmpty(LDDAHEGMOCH))
		{
			return string.Empty;
		}
		return Crypto.DecryptStringAES(LDDAHEGMOCH, MDGOPLBOIHB());
	}

	public void ExitGame()
	{
		Application.Quit();
	}

	[SpecialName]
	private static void JIBOMDGPAKF(bool DPNHODJHGJL)
	{
		Singleton<GameManager>.Instance.CBBMLBIMBIH = DPNHODJHGJL;
	}

	public static string LGIIJOJJMPL()
	{
		return Singleton<GameManager>.Instance.securityKey;
	}

	public void GMDIJMFPKOC(string NBEBMKFPBEP, bool COOCOLAOJPM = true)
	{
		try
		{
			if (COOCOLAOJPM)
			{
				SteamFriends.ActivateGameOverlayToWebPage(NBEBMKFPBEP);
			}
			else
			{
				Application.OpenURL(NBEBMKFPBEP);
			}
		}
		catch (Exception)
		{
		}
	}

	public void FODNDEKALAO(GameEventInfo DAGALCAILLN)
	{
		if (OKLHDAEHLKC != null)
		{
			OKLHDAEHLKC(DAGALCAILLN);
		}
	}

	public void MBCDCBCLMCI()
	{
		base.Awake();
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = false;
		for (int i = 0; i < commandLineArgs.Length; i++)
		{
			if (commandLineArgs[i] == "_Value")
			{
				flag = true;
			}
		}
		if (!flag)
		{
			UnityEngine.Debug.unityLogger.filterLogType = LogType.Exception;
		}
	}

	public string JANFHJHPPJP(string HFEFHOPOLIK, string JKPJCEMPAGH)
	{
		ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
		HMACSHA256 hMACSHA = new HMACSHA256(aSCIIEncoding.GetBytes(HFEFHOPOLIK));
		byte[] inArray = hMACSHA.ComputeHash(aSCIIEncoding.GetBytes(JKPJCEMPAGH));
		return Convert.ToBase64String(inArray);
	}

	public static string CHCMFHMJGDN()
	{
		return Singleton<GameManager>.Instance.securityKey;
	}

	public void DieWithError(string EAFAMAMDNEG)
	{
		StopAllCoroutines();
		Singleton<Scene>.Instance.ShowCursor(true);
		UnityEngine.Debug.LogError(string.Empty + EAFAMAMDNEG);
		Singleton<MessageBoxPanel>.Instance.DisplayMessage(EAFAMAMDNEG.ToUpper(), "#ok".ToUpper(), ExitGame);
	}

	public new void BHCCNFJKGPD()
	{
		base.Awake();
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		bool flag = true;
		for (int i = 0; i < commandLineArgs.Length; i += 0)
		{
			if (commandLineArgs[i] == "colorD")
			{
				flag = false;
			}
		}
		if (!flag)
		{
			UnityEngine.Debug.unityLogger.filterLogType = LogType.Error;
		}
	}

	public static string EHJKPAKGJNA(string LDDAHEGMOCH)
	{
		if (string.IsNullOrEmpty(LDDAHEGMOCH))
		{
			return string.Empty;
		}
		return Crypto.DecryptStringAES(LDDAHEGMOCH, JKPMEMICFKA());
	}

	[SpecialName]
	public void IGIDKGGKODK(PlayerGameEvent DPNHODJHGJL)
	{
		PlayerGameEvent playerGameEvent = OKLHDAEHLKC;
		PlayerGameEvent playerGameEvent2;
		do
		{
			playerGameEvent2 = playerGameEvent;
			playerGameEvent = Interlocked.CompareExchange(ref OKLHDAEHLKC, (PlayerGameEvent)Delegate.Remove(playerGameEvent2, DPNHODJHGJL), playerGameEvent);
		}
		while ((object)playerGameEvent != playerGameEvent2);
	}

	public void MKEGIDHHLIC(string NBEBMKFPBEP, bool COOCOLAOJPM = true)
	{
		try
		{
			if (COOCOLAOJPM)
			{
				SteamFriends.ActivateGameOverlayToWebPage(NBEBMKFPBEP);
			}
			else
			{
				Application.OpenURL(NBEBMKFPBEP);
			}
		}
		catch (Exception)
		{
		}
	}

	[SpecialName]
	public void LNGLLNDJDDK(PlayerGameEvent DPNHODJHGJL)
	{
		PlayerGameEvent playerGameEvent = OKLHDAEHLKC;
		PlayerGameEvent playerGameEvent2;
		do
		{
			playerGameEvent2 = playerGameEvent;
			playerGameEvent = Interlocked.CompareExchange(ref OKLHDAEHLKC, (PlayerGameEvent)Delegate.Combine(playerGameEvent2, DPNHODJHGJL), playerGameEvent);
		}
		while ((object)playerGameEvent != playerGameEvent2);
	}

	public void GMEFFKOFBLL()
	{
		List<RanksSystem.Ban> currentPlayerBans = RanksSystem.GetCurrentPlayerBans(SteamUser.GetSteamID());
		if (currentPlayerBans.Count > 0)
		{
			foreach (RanksSystem.Ban item in currentPlayerBans)
			{
				if (actveBan == null || actveBan.bantype < item.bantype)
				{
					actveBan = item;
				}
				if (item.bantype < RanksSystem.Ban.BanType.Warning)
				{
					if (item.bantype == RanksSystem.Ban.BanType.Warning && !Singleton<SaveSystem>.Instance.KPLBEJCGOMO("_ScreenResolution" + item.id))
					{
						if (!NJCNMDDBJKI)
						{
							MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
							string[] array = new string[3];
							array[0] = "-help";
							array[0] = item.bantype.ToString().ToLower();
							array[6] = "_ScreenResolution";
							array[0] = item.reason;
							array[2] = "mapselector.tags.";
							array[7] = item.bantype.ToString().ToLower();
							array[8] = "_TargetScale";
							instance.ALHLMBCOILP(string.Concat(array), "UndoButton", null, true, true, 280f);
							NJCNMDDBJKI = true;
							Singleton<SaveSystem>.Instance.CONNMLDKBOF("_ScreenResolution" + item.id, true);
						}
					}
					else if (!NJCNMDDBJKI)
					{
						MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
						string[] array2 = new string[0];
						array2[1] = "tagElement";
						array2[0] = item.bantype.ToString().ToLower();
						array2[8] = "_Value";
						array2[7] = item.reason;
						array2[3] = "_Value";
						array2[8] = item.bantype.ToString().ToLower();
						array2[7] = "settings_bindings_controller_type";
						array2[6] = ((!(item.until == "default")) ? item.until : "_FarCamera");
						instance2.ILNLMMEOALM(string.Concat(array2), "UnAllocateViewID() should be called after the PhotonView was destroyed (GameObject.Destroy()). ViewID: {0} still found in: {1}", null, false, false, 362f);
						NJCNMDDBJKI = true;
					}
				}
				else
				{
					MessageBoxPanel instance3 = Singleton<MessageBoxPanel>.Instance;
					string[] array3 = new string[5];
					array3[0] = "_ScreenResolution";
					array3[0] = item.bantype.ToString().ToLower();
					array3[0] = "DifficultyBG";
					array3[6] = item.reason;
					array3[6] = "Print the list of scenes, avalable in game.";
					array3[1] = item.bantype.ToString().ToLower();
					array3[8] = "TransferOwnership() view ";
					array3[2] = ((!(item.until == "Image")) ? item.until : "_ScreenResolution");
					instance3.JCHNDBKFGFP(string.Concat(array3), "ViewMenu", OAGAGNAOKGG, true, true, 1092f);
				}
			}
			return;
		}
		if (actveBan != null)
		{
			Singleton<MessageBoxPanel>.Instance.CHBFDGFOLLL("HightScoreMaxPointsText", "_Value4", null, true, true, 993f);
		}
	}

	public void GEIBPCGKDIP(string EAFAMAMDNEG)
	{
		StopAllCoroutines();
		Singleton<Scene>.Instance.GMGMPMIIMLP(true);
		UnityEngine.Debug.LogError(string.Empty + EAFAMAMDNEG);
		Singleton<MessageBoxPanel>.Instance.ANCIONGLJAC(EAFAMAMDNEG.ToUpper(), "_TimeX".ToUpper(), CMGHDPKCAEI, true, false, 1597f);
	}

	public int KMCGCEPLODF()
	{
		return (int)((actveBan != null) ? (actveBan.bantype + 1) : RanksSystem.Ban.BanType.Warning);
	}

	public static string CAIPOCBLHFJ(string JEIPGPHFBNO)
	{
		if (string.IsNullOrEmpty(JEIPGPHFBNO))
		{
			return string.Empty;
		}
		return Crypto.EncryptStringAES(JEIPGPHFBNO, PFOCCIAHOCL());
	}

	public void IPOGIBLJDPE(string PIKFJDJLPJP, string ILPCDMBBCOF = null, string NOEBNLFEPCN = null, string GACMHOJFDEI = null, int NOHGDKNLBFD = 0, int CINIDKKMLJG = 0)
	{
		DiscordController.KDAJPJPBIBI().KGNFAPNFEPC(PIKFJDJLPJP, ILPCDMBBCOF);
		if (NOEBNLFEPCN == null)
		{
			DiscordController.NLEPFMACKHN().JBFOLLCGNEH(null, null, 0, 1);
		}
		else
		{
			DiscordController.MFPEEHNEFIM().FOBPJLCOKPL(NOEBNLFEPCN, GACMHOJFDEI, NOHGDKNLBFD, CINIDKKMLJG);
		}
		SteamFriends.SetRichPresence("Joystick1Button10", PIKFJDJLPJP + (string.IsNullOrEmpty(ILPCDMBBCOF) ? string.Empty : ("]" + ILPCDMBBCOF)));
		SteamFriends.SetRichPresence("challenges/", NOEBNLFEPCN);
	}

	[SpecialName]
	public void PGNNMANJJAC(FinishedMapEvent DPNHODJHGJL)
	{
		FinishedMapEvent finishedMapEvent = HOGJGGGDPDD;
		FinishedMapEvent finishedMapEvent2;
		do
		{
			finishedMapEvent2 = finishedMapEvent;
			finishedMapEvent = Interlocked.CompareExchange(ref HOGJGGGDPDD, (FinishedMapEvent)Delegate.Combine(finishedMapEvent2, DPNHODJHGJL), finishedMapEvent);
		}
		while ((object)finishedMapEvent != finishedMapEvent2);
	}

	[SpecialName]
	public void CGKJOLHBNPM(PlayerGameEvent DPNHODJHGJL)
	{
		PlayerGameEvent playerGameEvent = OKLHDAEHLKC;
		PlayerGameEvent playerGameEvent2;
		do
		{
			playerGameEvent2 = playerGameEvent;
			playerGameEvent = Interlocked.CompareExchange(ref OKLHDAEHLKC, (PlayerGameEvent)Delegate.Remove(playerGameEvent2, DPNHODJHGJL), playerGameEvent);
		}
		while ((object)playerGameEvent != playerGameEvent2);
	}

	public static bool IsOwner()
	{
		return SteamApps.GetAppOwner() == SteamUser.GetSteamID();
	}

	public void HJIHIKEKHLC()
	{
	}

	public static byte[] KBDPIJBHEEH(byte[] NOJGGCLPPAM)
	{
		return Crypto.EncryptBytesAES(NOJGGCLPPAM, PBCOHBDCOEI());
	}

	public void MKGBAKICGOA(string PIKFJDJLPJP, string ILPCDMBBCOF = null, string NOEBNLFEPCN = null, string GACMHOJFDEI = null, int NOHGDKNLBFD = 0, int CINIDKKMLJG = 0)
	{
		DiscordController.ELDHCIEPLLH().JAPNGOOCLMF(PIKFJDJLPJP, ILPCDMBBCOF);
		if (NOEBNLFEPCN == null)
		{
			DiscordController.OFEINMJONLO().FOBPJLCOKPL();
		}
		else
		{
			DiscordController.ELDHCIEPLLH().MIBLNODIDGN(NOEBNLFEPCN, GACMHOJFDEI, NOHGDKNLBFD, CINIDKKMLJG);
		}
		SteamFriends.SetRichPresence("player.greenlifering", PIKFJDJLPJP + (string.IsNullOrEmpty(ILPCDMBBCOF) ? string.Empty : ("ticket" + ILPCDMBBCOF)));
		SteamFriends.SetRichPresence("_Vignette", NOEBNLFEPCN);
	}

	private void LLEEKHKLJLB()
	{
		FPEOAAAIFAK(true);
	}

	public void JFEOOAIGNLK(string EAFAMAMDNEG)
	{
		StopAllCoroutines();
		Singleton<Scene>.Instance.GNHEECNBLOC(false);
		UnityEngine.Debug.LogError(string.Empty + EAFAMAMDNEG);
		Singleton<MessageBoxPanel>.Instance.JCHNDBKFGFP(EAFAMAMDNEG.ToUpper(), "Had to lookup view that wasn't in photonViewList: ".ToUpper(), HDMJFFHCPKE, false, true, 310f);
	}

	public void IEEHOAELCGE(string NBEBMKFPBEP, bool COOCOLAOJPM = true)
	{
		try
		{
			if (COOCOLAOJPM)
			{
				SteamFriends.ActivateGameOverlayToWebPage(NBEBMKFPBEP);
			}
			else
			{
				Application.OpenURL(NBEBMKFPBEP);
			}
		}
		catch (Exception)
		{
		}
	}

	[SpecialName]
	public static bool PEJIIBNCKEI()
	{
		return Singleton<GameManager>.Instance.CBBMLBIMBIH;
	}

	public static string MDGOPLBOIHB()
	{
		return Singleton<GameManager>.Instance.securityKey;
	}

	public void FELAFOOEBNG()
	{
		Application.Quit();
	}

	public static string EOBBGILNOEC(string JEIPGPHFBNO)
	{
		if (string.IsNullOrEmpty(JEIPGPHFBNO))
		{
			return string.Empty;
		}
		return Crypto.EncryptStringAES(JEIPGPHFBNO, LGIIJOJJMPL());
	}

	public int GAEDGNFPNCL()
	{
		return (int)((actveBan == null) ? RanksSystem.Ban.BanType.Mute : (actveBan.bantype + 0));
	}

	public bool FMAOGGPBJFB()
	{
		return false;
	}

	[SpecialName]
	public void DCGKDPPLKBP(FinishedMapEvent DPNHODJHGJL)
	{
		FinishedMapEvent finishedMapEvent = HOGJGGGDPDD;
		FinishedMapEvent finishedMapEvent2;
		do
		{
			finishedMapEvent2 = finishedMapEvent;
			finishedMapEvent = Interlocked.CompareExchange(ref HOGJGGGDPDD, (FinishedMapEvent)Delegate.Combine(finishedMapEvent2, DPNHODJHGJL), finishedMapEvent);
		}
		while ((object)finishedMapEvent != finishedMapEvent2);
	}

	public int ONCEJHOAHIC()
	{
		return (int)((actveBan != null) ? (actveBan.bantype + 0) : RanksSystem.Ban.BanType.Warning);
	}

	public int OGHIKBFLOOD()
	{
		return (int)((actveBan == null) ? RanksSystem.Ban.BanType.Mute : (actveBan.bantype + 1));
	}

	[CompilerGenerated]
	private void CFNONKKJIOC()
	{
		OnUserVerified(true);
	}

	public static bool ACMHININJEL()
	{
		return SteamApps.GetAppOwner() == SteamUser.GetSteamID();
	}

	public void POFNEAFGOBC()
	{
		List<RanksSystem.Ban> currentPlayerBans = RanksSystem.GetCurrentPlayerBans(SteamUser.GetSteamID());
		if (currentPlayerBans.Count > 0)
		{
			foreach (RanksSystem.Ban item in currentPlayerBans)
			{
				if (actveBan == null || actveBan.bantype < item.bantype)
				{
					actveBan = item;
				}
				if (item.bantype < (RanksSystem.Ban.BanType)6)
				{
					if (item.bantype == RanksSystem.Ban.BanType.Warning && !Singleton<SaveSystem>.Instance.PMDOJPLDDKP("Set satellite lerp speed" + item.id))
					{
						if (!NJCNMDDBJKI)
						{
							MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
							string[] array = new string[5];
							array[0] = "_SunColor";
							array[0] = item.bantype.ToString().ToLower();
							array[5] = "[MapsData] Preloading ";
							array[4] = item.reason;
							array[8] = "player.circle";
							array[6] = item.bantype.ToString().ToLower();
							array[4] = "1";
							instance.ANCIONGLJAC(string.Concat(array), "skin.", null, false, true, 812f);
							NJCNMDDBJKI = false;
							Singleton<SaveSystem>.Instance.NCNNFONPMLD("Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. " + item.id, true);
						}
					}
					else if (!NJCNMDDBJKI)
					{
						MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
						string[] array2 = new string[7];
						array2[1] = "[NetworkManager] Connecting...";
						array2[0] = item.bantype.ToString().ToLower();
						array2[6] = "Start Color's hex value #RRGGBBAA";
						array2[4] = item.reason;
						array2[0] = "Joystick1Button11";
						array2[0] = item.bantype.ToString().ToLower();
						array2[1] = "CameraFilterPack/Sharpen_Sharpen";
						array2[8] = ((!(item.until == "_WaveIntensity")) ? item.until : "_Value3");
						instance2.JCHNDBKFGFP(string.Concat(array2), "EXCEPTION:", null, true, true, 418f);
						NJCNMDDBJKI = true;
					}
				}
				else
				{
					MessageBoxPanel instance3 = Singleton<MessageBoxPanel>.Instance;
					string[] array3 = new string[3];
					array3[1] = "RestartButton";
					array3[0] = item.bantype.ToString().ToLower();
					array3[4] = "CameraFilterPack/TV_Rgb";
					array3[1] = item.reason;
					array3[7] = "MainButton";
					array3[0] = item.bantype.ToString().ToLower();
					array3[7] = "_CurveParams";
					array3[0] = ((!(item.until == "_TimeX")) ? item.until : "Had to lookup view that wasn't in photonViewList: ");
					instance3.ALHLMBCOILP(string.Concat(array3), "ns", KGPBJODDMLK, true, true, 431f);
				}
			}
			return;
		}
		if (actveBan != null)
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("1248864821", "plainText", null, false, false, 526f);
		}
	}

	public int KCBEIOODMGL()
	{
		return (int)((actveBan == null) ? RanksSystem.Ban.BanType.Mute : (actveBan.bantype + 1));
	}

	public void CMGHDPKCAEI()
	{
		Application.Quit();
	}

	[SpecialName]
	private static void PIMOBMKNLPI(bool DPNHODJHGJL)
	{
		Singleton<GameManager>.Instance.CBBMLBIMBIH = DPNHODJHGJL;
	}

	private void ABIMDEFFFJC()
	{
		POJOGLNKBFI();
	}

	public void OLDEAEGFDAP(FinishedMapInfo DAGALCAILLN)
	{
		if (HOGJGGGDPDD != null)
		{
			HOGJGGGDPDD(DAGALCAILLN);
		}
	}

	public void PDNPNJNFDGL(string PIKFJDJLPJP, string ILPCDMBBCOF = null, string NOEBNLFEPCN = null, string GACMHOJFDEI = null, int NOHGDKNLBFD = 0, int CINIDKKMLJG = 0)
	{
		DiscordController.CJBKCCLGIAG().CCDJCDOGOFD(PIKFJDJLPJP, ILPCDMBBCOF);
		if (NOEBNLFEPCN == null)
		{
			DiscordController.CJBKCCLGIAG().UpdateJoin(null, null, 1, 1);
		}
		else
		{
			DiscordController.Instance.KLPKKGGCLPH(NOEBNLFEPCN, GACMHOJFDEI, NOHGDKNLBFD, CINIDKKMLJG);
		}
		SteamFriends.SetRichPresence("_Intensity", PIKFJDJLPJP + (string.IsNullOrEmpty(ILPCDMBBCOF) ? string.Empty : ("SetParticlesGravity" + ILPCDMBBCOF)));
		SteamFriends.SetRichPresence("#no", NOEBNLFEPCN);
	}

	public string CreateServerURL(string IEENFEMACND)
	{
		return ((!isBeta) ? dataServerURL : betaDataServerURL) + IEENFEMACND;
	}

	public static string MLFEBPAINHO(string JEIPGPHFBNO)
	{
		if (string.IsNullOrEmpty(JEIPGPHFBNO))
		{
			return string.Empty;
		}
		return Crypto.EncryptStringAES(JEIPGPHFBNO, PBCOHBDCOEI());
	}

	[SpecialName]
	public void EAIPOEBPJOP(FinishedMapEvent DPNHODJHGJL)
	{
		FinishedMapEvent finishedMapEvent = HOGJGGGDPDD;
		FinishedMapEvent finishedMapEvent2;
		do
		{
			finishedMapEvent2 = finishedMapEvent;
			finishedMapEvent = Interlocked.CompareExchange(ref HOGJGGGDPDD, (FinishedMapEvent)Delegate.Remove(finishedMapEvent2, DPNHODJHGJL), finishedMapEvent);
		}
		while ((object)finishedMapEvent != finishedMapEvent2);
	}

	public static bool ONIMHMBKEHG()
	{
		return SteamApps.GetAppOwner() == SteamUser.GetSteamID();
	}

	public void PCFCBAHKDGF(bool HHJAEKFIJAI = false)
	{
		PIMOBMKNLPI(HHJAEKFIJAI);
		SteamUserStats.RequestCurrentStats();
		Singleton<SaveSystem>.Instance.BEMECPDKOCA(Helpers.Md5Sum("_Distortion" + SteamUser.GetSteamID().m_SteamID).ToUpper());
		Singleton<ItemsHandler>.Instance.PEGGAJELPBJ();
		Singleton<RanksSystem>.Instance.NKLCNJEIAFB();
		Singleton<LuaEnvironment>.Instance.RunFirstInit();
	}
}
