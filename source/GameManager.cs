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

	public static string Decrypt(string LDDAHEGMOCH)
	{
		if (string.IsNullOrEmpty(LDDAHEGMOCH))
		{
			return string.Empty;
		}
		return Crypto.DecryptStringAES(LDDAHEGMOCH, GetSecurityKey());
	}

	private void MNNGBOLAGOC()
	{
		ExitGame();
	}

	public static byte[] NBLDDMGCBJH(byte[] NOJGGCLPPAM)
	{
		return Crypto.EncryptBytesAES(NOJGGCLPPAM, IHEKPNPBIDK());
	}

	[SpecialName]
	public void IJANEODJFIG(FinishedMapEvent DPNHODJHGJL)
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

	public static string JJEBHHFOBPP()
	{
		return Singleton<GameManager>.Instance.securityKey;
	}

	public int GetCurrentBanLevel()
	{
		return (int)((actveBan != null) ? (actveBan.bantype + 1) : RanksSystem.Ban.BanType.Warning);
	}

	public static bool LHMIJFLLKHK()
	{
		return SteamApps.GetAppOwner() == SteamUser.GetSteamID();
	}

	[CompilerGenerated]
	private void CMKMEMANHFF()
	{
		ExitGame();
	}

	public static string Encrypt(string JEIPGPHFBNO)
	{
		if (string.IsNullOrEmpty(JEIPGPHFBNO))
		{
			return string.Empty;
		}
		return Crypto.EncryptStringAES(JEIPGPHFBNO, GetSecurityKey());
	}

	public void DOFMKEPFKDP(string PIKFJDJLPJP, string ILPCDMBBCOF = null, string NOEBNLFEPCN = null, string GACMHOJFDEI = null, int NOHGDKNLBFD = 0, int CINIDKKMLJG = 0)
	{
		DiscordController.GNMEAJJKDPG().BIFMMKOGBKH(PIKFJDJLPJP, ILPCDMBBCOF);
		if (NOEBNLFEPCN == null)
		{
			DiscordController.PEHDMBBOFDJ().DOKOBGOAFOA();
		}
		else
		{
			DiscordController.Instance.DOKOBGOAFOA(NOEBNLFEPCN, GACMHOJFDEI, NOHGDKNLBFD, CINIDKKMLJG);
		}
		SteamFriends.SetRichPresence("player.bluelifering", PIKFJDJLPJP + (string.IsNullOrEmpty(ILPCDMBBCOF) ? string.Empty : ("#close" + ILPCDMBBCOF)));
		SteamFriends.SetRichPresence("_Greenness", NOEBNLFEPCN);
	}

	public void BFFBAOFFMJM(GameEventInfo DAGALCAILLN)
	{
		if (OKLHDAEHLKC != null)
		{
			OKLHDAEHLKC(DAGALCAILLN);
		}
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

	[SpecialName]
	public void LKMBANBOLHD(PlayerGameEvent DPNHODJHGJL)
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

	public static string IBOCADBLICL(string LDDAHEGMOCH)
	{
		if (string.IsNullOrEmpty(LDDAHEGMOCH))
		{
			return string.Empty;
		}
		return Crypto.DecryptStringAES(LDDAHEGMOCH, IHEKPNPBIDK());
	}

	public static byte[] Encrypt(byte[] NOJGGCLPPAM)
	{
		return Crypto.EncryptBytesAES(NOJGGCLPPAM, GetSecurityKey());
	}

	public static string MEEAAMMCJED(string JEIPGPHFBNO)
	{
		if (string.IsNullOrEmpty(JEIPGPHFBNO))
		{
			return string.Empty;
		}
		return Crypto.EncryptStringAES(JEIPGPHFBNO, IHEKPNPBIDK());
	}

	public void CKMMHJLDADB(string NBEBMKFPBEP, bool COOCOLAOJPM = true)
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

	public int EDMAKDCDHNM()
	{
		return (int)((actveBan != null) ? (actveBan.bantype + 1) : RanksSystem.Ban.BanType.Warning);
	}

	[SpecialName]
	public static bool AFFAMCPHDJN()
	{
		return Singleton<GameManager>.Instance.CBBMLBIMBIH;
	}

	public static bool IsOwner()
	{
		return SteamApps.GetAppOwner() == SteamUser.GetSteamID();
	}

	public void FMCBLGPDACK(string NBEBMKFPBEP, bool COOCOLAOJPM = true)
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

	public static string JCPMBOLDDJI(string JEIPGPHFBNO)
	{
		if (string.IsNullOrEmpty(JEIPGPHFBNO))
		{
			return string.Empty;
		}
		return Crypto.EncryptStringAES(JEIPGPHFBNO, GetSecurityKey());
	}

	public void DieWithError(string EAFAMAMDNEG)
	{
		StopAllCoroutines();
		Singleton<Scene>.Instance.ShowCursor(true);
		UnityEngine.Debug.LogError(string.Empty + EAFAMAMDNEG);
		Singleton<MessageBoxPanel>.Instance.DisplayMessage(EAFAMAMDNEG.ToUpper(), "#ok".ToUpper(), ExitGame);
	}

	public void KNCMACOFNLJ(string EAFAMAMDNEG)
	{
		StopAllCoroutines();
		Singleton<Scene>.Instance.EJBGCLOEOPN(false);
		UnityEngine.Debug.LogError(string.Empty + EAFAMAMDNEG);
		Singleton<MessageBoxPanel>.Instance.LOLNHCPOKFP(EAFAMAMDNEG.ToUpper(), "[PlayerController] ".ToUpper(), NBIKPADDEIH, true, true, 715f);
	}

	public void DBPNHMBLICN(FinishedMapInfo DAGALCAILLN)
	{
		if (HOGJGGGDPDD != null)
		{
			HOGJGGGDPDD(DAGALCAILLN);
		}
	}

	private void OMFKIFIPEFN()
	{
		IPLENMOHHCC(true);
	}

	public void PlayerWarnCheats()
	{
	}

	public void ELKPGFANDCG(GameEventInfo DAGALCAILLN)
	{
		if (OKLHDAEHLKC != null)
		{
			OKLHDAEHLKC(DAGALCAILLN);
		}
	}

	public void KEKNHAAEPCJ()
	{
		base.Awake();
		UnityEngine.Debug.unityLogger.filterLogType = LogType.Assert;
	}

	public string HashHMAC(string HFEFHOPOLIK, string JKPJCEMPAGH)
	{
		ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
		HMACSHA256 hMACSHA = new HMACSHA256(aSCIIEncoding.GetBytes(HFEFHOPOLIK));
		byte[] inArray = hMACSHA.ComputeHash(aSCIIEncoding.GetBytes(JKPJCEMPAGH));
		return Convert.ToBase64String(inArray);
	}

	public bool IsCheatsAllowed()
	{
		return true;
	}

	public bool LALHDBFPKPH()
	{
		return false;
	}

	public static byte[] EGOADBKLAFB(byte[] NOJGGCLPPAM)
	{
		return Crypto.DecryptBytesAES(NOJGGCLPPAM, GetSecurityKey());
	}

	public string JJGKGCBCGGD(string IEENFEMACND)
	{
		return ((!isBeta) ? dataServerURL : betaDataServerURL) + IEENFEMACND;
	}

	private void NKCALAOCDGN()
	{
		HFILOGADNKL();
	}

	public new void Awake()
	{
		base.Awake();
		UnityEngine.Debug.unityLogger.filterLogType = LogType.Warning;
	}

	public void CDDFCJDDMJL(FinishedMapInfo DAGALCAILLN)
	{
		if (HOGJGGGDPDD != null)
		{
			HOGJGGGDPDD(DAGALCAILLN);
		}
	}

	public int BNOEDGPIGID()
	{
		return (int)((actveBan == null) ? RanksSystem.Ban.BanType.Mute : (actveBan.bantype + 0));
	}

	public void EMFPBLEIEFG(string PIKFJDJLPJP, string ILPCDMBBCOF = null, string NOEBNLFEPCN = null, string GACMHOJFDEI = null, int NOHGDKNLBFD = 0, int CINIDKKMLJG = 0)
	{
		DiscordController.PEHDMBBOFDJ().LKHFHPAJPAI(PIKFJDJLPJP, ILPCDMBBCOF);
		if (NOEBNLFEPCN == null)
		{
			DiscordController.LCGNLCPJBOH().DOKOBGOAFOA(null, null, 1, 1);
		}
		else
		{
			DiscordController.FMFOENCDEHG().OMIMOEGOGOI(NOEBNLFEPCN, GACMHOJFDEI, NOHGDKNLBFD, CINIDKKMLJG);
		}
		SteamFriends.SetRichPresence("Items/", PIKFJDJLPJP + (string.IsNullOrEmpty(ILPCDMBBCOF) ? string.Empty : ("Edited unlock conditions" + ILPCDMBBCOF)));
		SteamFriends.SetRichPresence("CameraFilterPack/Blend2Camera_LinearLight", NOEBNLFEPCN);
	}

	public void HEHKJIHIBLD(string NBEBMKFPBEP, bool COOCOLAOJPM = true)
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

	public void HOMKLIBLNHC()
	{
		Singleton<Scene>.Instance.BHNKGIHGELM(true);
		StartCoroutine(Singleton<MessageBoxPanel>.Instance.LFPIIMKNLAN(": ", "_ScreenResolution".ToUpper(), ExitGame, "CameraFilterPack/3D_Distortion".ToUpper(), HAFFCJCDCJP));
	}

	public void FinishedMap(FinishedMapInfo DAGALCAILLN)
	{
		if (HOGJGGGDPDD != null)
		{
			HOGJGGGDPDD(DAGALCAILLN);
		}
	}

	public void COLPGBJFLGM(string NBEBMKFPBEP, bool COOCOLAOJPM = true)
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

	public static byte[] HIBCCKALOFL(byte[] NOJGGCLPPAM)
	{
		return Crypto.DecryptBytesAES(NOJGGCLPPAM, GetSecurityKey());
	}

	[SpecialName]
	public static bool LCHEOPKMPBB()
	{
		return Singleton<GameManager>.Instance.CBBMLBIMBIH;
	}

	public void MMPGEMFKNAN(GameEventInfo DAGALCAILLN)
	{
		if (OKLHDAEHLKC != null)
		{
			OKLHDAEHLKC(DAGALCAILLN);
		}
	}

	private void HAFFCJCDCJP()
	{
		OBEKBHKGCHE();
	}

	[SpecialName]
	public void NGJBMCKLKLN(PlayerGameEvent DPNHODJHGJL)
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

	public void HFILOGADNKL(bool HHJAEKFIJAI = false)
	{
		IsOffline = HHJAEKFIJAI;
		SteamUserStats.RequestCurrentStats();
		Singleton<SaveSystem>.Instance.CDDHLFNJOGC(Helpers.Md5Sum("_Near" + SteamUser.GetSteamID().m_SteamID).ToUpper());
		Singleton<ItemsHandler>.Instance.MMGKIFCGGDB();
		Singleton<RanksSystem>.Instance.FFBDGOBNNCO();
		Singleton<LuaEnvironment>.Instance.DLMPKCLPMGK();
	}

	public string EHNEJEMIKLH(string HFEFHOPOLIK, string JKPJCEMPAGH)
	{
		ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
		HMACSHA256 hMACSHA = new HMACSHA256(aSCIIEncoding.GetBytes(HFEFHOPOLIK));
		byte[] inArray = hMACSHA.ComputeHash(aSCIIEncoding.GetBytes(JKPJCEMPAGH));
		return Convert.ToBase64String(inArray);
	}

	public void GameEvent(GameEventInfo DAGALCAILLN)
	{
		if (OKLHDAEHLKC != null)
		{
			OKLHDAEHLKC(DAGALCAILLN);
		}
	}

	[SpecialName]
	public void IALDPMHMMAJ(FinishedMapEvent DPNHODJHGJL)
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

	public new void EPCGHAAONLN()
	{
		base.Awake();
		UnityEngine.Debug.unityLogger.filterLogType = (LogType)5;
	}

	[SpecialName]
	public void FOKIAPDGFAB(PlayerGameEvent DPNHODJHGJL)
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

	public void CKMBAOLHJAJ(bool HHJAEKFIJAI = false)
	{
		IsOffline = HHJAEKFIJAI;
		SteamUserStats.RequestCurrentStats();
		Singleton<SaveSystem>.Instance.AOEEOKNJDCK(Helpers.Md5Sum("_TimeX" + SteamUser.GetSteamID().m_SteamID).ToUpper());
		Singleton<ItemsHandler>.Instance.IMDBAKAIHII();
		Singleton<RanksSystem>.Instance.FFBDGOBNNCO();
		Singleton<LuaEnvironment>.Instance.BMHPOFKMIJJ();
	}

	private void FJNKABJJEPF()
	{
		IPLENMOHHCC();
	}

	public static string GetSecurityKey()
	{
		return Singleton<GameManager>.Instance.securityKey;
	}

	[SpecialName]
	public void PLHPCLABBIA(PlayerGameEvent DPNHODJHGJL)
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

	private void LLEAFBCCNDA()
	{
		CKMBAOLHJAJ();
	}

	public static byte[] Decrypt(byte[] NOJGGCLPPAM)
	{
		return Crypto.DecryptBytesAES(NOJGGCLPPAM, GetSecurityKey());
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

	[SpecialName]
	public void AALMFLNJPDG(PlayerGameEvent DPNHODJHGJL)
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

	[SpecialName]
	public void BKDFHECPBCM(FinishedMapEvent DPNHODJHGJL)
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

	public static byte[] NAKBBIFIGKD(byte[] NOJGGCLPPAM)
	{
		return Crypto.EncryptBytesAES(NOJGGCLPPAM, GetSecurityKey());
	}

	public static string IHEKPNPBIDK()
	{
		return Singleton<GameManager>.Instance.securityKey;
	}

	public static string DHCILBAFLDP(string JEIPGPHFBNO)
	{
		if (string.IsNullOrEmpty(JEIPGPHFBNO))
		{
			return string.Empty;
		}
		return Crypto.EncryptStringAES(JEIPGPHFBNO, IHEKPNPBIDK());
	}

	[SpecialName]
	public static bool MBCLCEGBDIB()
	{
		return Singleton<GameManager>.Instance.CBBMLBIMBIH;
	}

	public void StartOfflineMessage()
	{
		Singleton<Scene>.Instance.ShowCursor(true);
		StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#startofflinemessage", "#exit".ToUpper(), ExitGame, "#yes".ToUpper(), delegate
		{
			OnUserVerified(true);
		}));
	}

	public void OLIINGPOEIE(string NBEBMKFPBEP, bool COOCOLAOJPM = true)
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

	public void HNIMJMPFCLA()
	{
		Singleton<Scene>.Instance.GKMMBPLIKDO(false);
		StartCoroutine(Singleton<MessageBoxPanel>.Instance.MDBCFODECPM("player.lollipop", "\0\0".ToUpper(), NBIKPADDEIH, "pointBuffer".ToUpper(), delegate
		{
			OnUserVerified(true);
		}));
	}

	public string CreateServerURL(string IEENFEMACND)
	{
		return ((!isBeta) ? dataServerURL : betaDataServerURL) + IEENFEMACND;
	}

	public void OBEKBHKGCHE(bool HHJAEKFIJAI = false)
	{
		IsOffline = HHJAEKFIJAI;
		SteamUserStats.RequestCurrentStats();
		Singleton<SaveSystem>.Instance.NOBNCNJKOLA(Helpers.Md5Sum("SetParticlesCountPerBeat" + SteamUser.GetSteamID().m_SteamID).ToUpper());
		Singleton<ItemsHandler>.Instance.Initializate();
		Singleton<RanksSystem>.Instance.FFBDGOBNNCO();
		Singleton<LuaEnvironment>.Instance.MFCPJPOMGFN();
	}

	public static byte[] AJBHCCFOFBC(byte[] NOJGGCLPPAM)
	{
		return Crypto.DecryptBytesAES(NOJGGCLPPAM, IHEKPNPBIDK());
	}

	public void PBKIGEDGLJC()
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
					if (item.bantype == RanksSystem.Ban.BanType.Warning && !Singleton<SaveSystem>.Instance.HasKey("_Y" + item.id))
					{
						if (!NJCNMDDBJKI)
						{
							MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
							string[] array = new string[7];
							array[0] = "_BgFade";
							array[1] = item.bantype.ToString().ToLower();
							array[3] = "_AxialAberration";
							array[5] = item.reason;
							array[8] = "player.quantum";
							array[8] = item.bantype.ToString().ToLower();
							array[7] = "ready";
							instance.DisplayMessage(string.Concat(array), "_TintColor", null, false, false, 1277f);
							NJCNMDDBJKI = false;
							Singleton<SaveSystem>.Instance.JKOMMNBGPDK("mapselector.lastSearch" + item.id, true);
						}
					}
					else if (!NJCNMDDBJKI)
					{
						MessageBoxPanel instance2 = Singleton<MessageBoxPanel>.Instance;
						string[] array2 = new string[3];
						array2[0] = "' has been reset to the fault value";
						array2[0] = item.bantype.ToString().ToLower();
						array2[0] = "SpawnObj";
						array2[1] = item.reason;
						array2[7] = "_NoiseScale";
						array2[3] = item.bantype.ToString().ToLower();
						array2[3] = "_TimeX";
						array2[6] = ((!(item.until == "Set satellite lerp speed")) ? item.until : "0.000");
						instance2.IINDNBDIOMJ(string.Concat(array2), "_ScreenResolution", null, false, false, 1131f);
						NJCNMDDBJKI = true;
					}
				}
				else
				{
					MessageBoxPanel instance3 = Singleton<MessageBoxPanel>.Instance;
					string[] array3 = new string[4];
					array3[1] = "player.circle";
					array3[1] = item.bantype.ToString().ToLower();
					array3[4] = "Dec";
					array3[6] = item.reason;
					array3[3] = "Gameplay/particles";
					array3[3] = item.bantype.ToString().ToLower();
					array3[3] = "Bad SegmentType passed in to CreateLineCap. Must be SegmentType.Start or SegmentType.End";
					array3[8] = ((!(item.until == "editorVolume")) ? item.until : "maps.");
					instance3.AMBEIAGHBEF(string.Concat(array3), "[NetworkManager] Connecting...", MNNGBOLAGOC, false, true, 1442f);
				}
			}
			return;
		}
		if (actveBan != null)
		{
			Singleton<MessageBoxPanel>.Instance.HLEOBMODPLO("SupportLogger OnCreatedRoom(", "_Visualize", null, false, false, 370f);
		}
	}

	public void JMCBNFNJINF(FinishedMapInfo DAGALCAILLN)
	{
		if (HOGJGGGDPDD != null)
		{
			HOGJGGGDPDD(DAGALCAILLN);
		}
	}

	public void INLEIPHNJPF(string PIKFJDJLPJP, string ILPCDMBBCOF = null, string NOEBNLFEPCN = null, string GACMHOJFDEI = null, int NOHGDKNLBFD = 0, int CINIDKKMLJG = 0)
	{
		DiscordController.IBDLENPHGCD().LKHFHPAJPAI(PIKFJDJLPJP, ILPCDMBBCOF);
		if (NOEBNLFEPCN == null)
		{
			DiscordController.KMLCFPCJNOB().JNIEKHLEICK(null, null, 0, 1);
		}
		else
		{
			DiscordController.GNMEAJJKDPG().JNIEKHLEICK(NOEBNLFEPCN, GACMHOJFDEI, NOHGDKNLBFD, CINIDKKMLJG);
		}
		SteamFriends.SetRichPresence("Joystick1Button9", PIKFJDJLPJP + (string.IsNullOrEmpty(ILPCDMBBCOF) ? string.Empty : ("Toggle {0} is not part of ToggleGroup {1}" + ILPCDMBBCOF)));
		SteamFriends.SetRichPresence("#tryagain", NOEBNLFEPCN);
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

	[SpecialName]
	public static bool OACLFEJPBDA()
	{
		return Singleton<GameManager>.Instance.CBBMLBIMBIH;
	}

	public void ExitGame()
	{
		Application.Quit();
	}

	public void CKFIPMLMEBJ(FinishedMapInfo DAGALCAILLN)
	{
		if (HOGJGGGDPDD != null)
		{
			HOGJGGGDPDD(DAGALCAILLN);
		}
	}

	public void OJFIOIHBEOE(string EAFAMAMDNEG)
	{
		StopAllCoroutines();
		Singleton<Scene>.Instance.LICGKFKFJOF(true);
		UnityEngine.Debug.LogError(string.Empty + EAFAMAMDNEG);
		Singleton<MessageBoxPanel>.Instance.BPANCBNKDKD(EAFAMAMDNEG.ToUpper(), "BitsData".ToUpper(), ExitGame, false, false, 1837f);
	}

	public static string PJHEGJPGKPP(string LDDAHEGMOCH)
	{
		if (string.IsNullOrEmpty(LDDAHEGMOCH))
		{
			return string.Empty;
		}
		return Crypto.DecryptStringAES(LDDAHEGMOCH, IHEKPNPBIDK());
	}

	public void JBACEOMALNO()
	{
		Singleton<Scene>.Instance.MMLKMEBMOFK(false);
		StartCoroutine(Singleton<MessageBoxPanel>.Instance.MPOMHPPFBBP("/Saved Games/", "#ok".ToUpper(), NBIKPADDEIH, "_LensDirtIntensity".ToUpper(), delegate
		{
			OnUserVerified(true);
		}));
	}

	public void IPLENMOHHCC(bool HHJAEKFIJAI = false)
	{
		IsOffline = HHJAEKFIJAI;
		SteamUserStats.RequestCurrentStats();
		Singleton<SaveSystem>.Instance.NOBNCNJKOLA(Helpers.Md5Sum(". Check if the server is available." + SteamUser.GetSteamID().m_SteamID).ToUpper());
		Singleton<ItemsHandler>.Instance.Initializate();
		Singleton<RanksSystem>.Instance.Init();
		Singleton<LuaEnvironment>.Instance.BMHPOFKMIJJ();
	}

	public void GGGDONNAMNG()
	{
	}

	public static string CHADLKENPOO(string LDDAHEGMOCH)
	{
		if (string.IsNullOrEmpty(LDDAHEGMOCH))
		{
			return string.Empty;
		}
		return Crypto.DecryptStringAES(LDDAHEGMOCH, JJEBHHFOBPP());
	}

	public void IIAGAGAIMKN(string EAFAMAMDNEG)
	{
		StopAllCoroutines();
		Singleton<Scene>.Instance.EPEBJKNNFAP(true);
		UnityEngine.Debug.LogError(string.Empty + EAFAMAMDNEG);
		Singleton<MessageBoxPanel>.Instance.DMDDLAICNDI(EAFAMAMDNEG.ToUpper(), "_Value2".ToUpper(), NBIKPADDEIH, true, true, 1647f);
	}

	private void AIINJLMMADI()
	{
		HFILOGADNKL(true);
	}

	public void PFHAPKOAIDK()
	{
	}

	public void CJEBLBGOINH()
	{
	}

	[CompilerGenerated]
	private void CFNONKKJIOC()
	{
		OnUserVerified(true);
	}

	public void PBOKFNEJIEG(string PIKFJDJLPJP, string ILPCDMBBCOF = null, string NOEBNLFEPCN = null, string GACMHOJFDEI = null, int NOHGDKNLBFD = 0, int CINIDKKMLJG = 0)
	{
		DiscordController.FMFOENCDEHG().FHKOGOMNNKE(PIKFJDJLPJP, ILPCDMBBCOF);
		if (NOEBNLFEPCN == null)
		{
			DiscordController.GGCHKDLDGBJ().DOKOBGOAFOA(null, null, 1, 1);
		}
		else
		{
			DiscordController.KMLCFPCJNOB().GNAEPLCPKGN(NOEBNLFEPCN, GACMHOJFDEI, NOHGDKNLBFD, CINIDKKMLJG);
		}
		SteamFriends.SetRichPresence("_Intensity", PIKFJDJLPJP + (string.IsNullOrEmpty(ILPCDMBBCOF) ? string.Empty : ("Set particles size" + ILPCDMBBCOF)));
		SteamFriends.SetRichPresence("#yes", NOEBNLFEPCN);
	}

	public int EHDHPGCLLAE()
	{
		return (int)((actveBan != null) ? (actveBan.bantype + 0) : RanksSystem.Ban.BanType.Warning);
	}

	public static string PNOAGJLDFJL(string LDDAHEGMOCH)
	{
		if (string.IsNullOrEmpty(LDDAHEGMOCH))
		{
			return string.Empty;
		}
		return Crypto.DecryptStringAES(LDDAHEGMOCH, JJEBHHFOBPP());
	}

	public static string NOPLBGANHHC(string LDDAHEGMOCH)
	{
		if (string.IsNullOrEmpty(LDDAHEGMOCH))
		{
			return string.Empty;
		}
		return Crypto.DecryptStringAES(LDDAHEGMOCH, IHEKPNPBIDK());
	}

	public void LNNCKEKFPIF(GameEventInfo DAGALCAILLN)
	{
		if (OKLHDAEHLKC != null)
		{
			OKLHDAEHLKC(DAGALCAILLN);
		}
	}

	public void NBIKPADDEIH()
	{
		Application.Quit();
	}

	public static byte[] FBMKCIGCLAI(byte[] NOJGGCLPPAM)
	{
		return Crypto.EncryptBytesAES(NOJGGCLPPAM, GetSecurityKey());
	}

	[SpecialName]
	public void GPEKLFBAAGI(FinishedMapEvent DPNHODJHGJL)
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

	public static string OGGKBIBHFLH(string JEIPGPHFBNO)
	{
		if (string.IsNullOrEmpty(JEIPGPHFBNO))
		{
			return string.Empty;
		}
		return Crypto.EncryptStringAES(JEIPGPHFBNO, GetSecurityKey());
	}

	public string PMHKJAJLFJJ(string HFEFHOPOLIK, string JKPJCEMPAGH)
	{
		ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
		HMACSHA256 hMACSHA = new HMACSHA256(aSCIIEncoding.GetBytes(HFEFHOPOLIK));
		byte[] inArray = hMACSHA.ComputeHash(aSCIIEncoding.GetBytes(JKPJCEMPAGH));
		return Convert.ToBase64String(inArray);
	}

	public void GMOJGDKBHEL(string NBEBMKFPBEP, bool COOCOLAOJPM = true)
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
}
