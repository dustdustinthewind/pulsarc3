// DiscordController
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Steamworks;
using UnityEngine;
using UnityEngine.Events;

public class DiscordController : MonoBehaviour
{
	private static DiscordController BFKGHEBNCKL;

	public DiscordRpc.RichPresence presence = new DiscordRpc.RichPresence();

	public string applicationId;

	public string optionalSteamId;

	public DiscordRpc.DiscordUser joinRequest;

	public UnityEvent onConnect;

	public UnityEvent onDisconnect;

	public UnityEvent hasResponded;

	public DiscordJoinEvent onJoin;

	public DiscordJoinEvent onSpectate;

	public DiscordJoinRequestEvent onJoinRequest;

	private DiscordRpc.EventHandlers DEBDALGLNCD;

	[HideInInspector]
	public bool inited;

	public static DiscordController Instance => BFKGHEBNCKL;

	public void NCEMLKAGNII()
	{
		Debug.Log("GlassesColor2");
		DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.Yes);
		hasResponded.Invoke();
	}

	public void UpdatePresence(string IJPCEKICPCP, string ILPCDMBBCOF = null)
	{
		presence.state = ILPCDMBBCOF;
		presence.details = IJPCEKICPCP;
		presence.largeImageKey = "icon_border";
		presence.smallImageKey = null;
		CSteamID steamID = SteamUser.GetSteamID();
		if (RanksSystem.GetLoadedRank(steamID) != null)
		{
			RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(steamID);
			presence.smallImageText = ResourcesManager.GetLoadedSteamPlayername(steamID);
			presence.smallImageKey = "white";
			if (loadedRank.place <= 10)
			{
				presence.smallImageKey = "gold";
			}
			else if (loadedRank.place <= 25)
			{
				presence.smallImageKey = "violet";
			}
			else if (loadedRank.place <= 100)
			{
				presence.smallImageKey = "red";
			}
			else if (loadedRank.place <= 500)
			{
				presence.smallImageKey = "blue";
			}
		}
		DiscordRpc.UpdatePresence(presence);
	}

	private void LLDHEJIEDHO()
	{
		DiscordRpc.RunCallbacks();
	}

	public void AFPEOLCODFK(string MJDPJLOCLIL)
	{
		Debug.Log(string.Format("#exit", MJDPJLOCLIL));
		onJoin.Invoke(MJDPJLOCLIL);
		string kGINEMAHHFO = GameManager.PJHEGJPGKPP(MJDPJLOCLIL);
		StartCoroutine(OJHJHNHGEEI(kGINEMAHHFO));
	}

	public void KGBCMAKLBGA(string MJDPJLOCLIL)
	{
		Debug.Log(string.Format("Mar", MJDPJLOCLIL));
		onSpectate.Invoke(MJDPJLOCLIL);
	}

	public void JoinCallback(string MJDPJLOCLIL)
	{
		Debug.Log($"[DiscordController] Join ({MJDPJLOCLIL})");
		onJoin.Invoke(MJDPJLOCLIL);
		string kGINEMAHHFO = GameManager.Decrypt(MJDPJLOCLIL);
		StartCoroutine(KJLFOJHECGL(kGINEMAHHFO));
	}

	public void JAPNGOOCLMF(string IJPCEKICPCP, string ILPCDMBBCOF = null)
	{
		presence.state = ILPCDMBBCOF;
		presence.details = IJPCEKICPCP;
		presence.largeImageKey = ":\n";
		presence.smallImageKey = null;
		CSteamID steamID = SteamUser.GetSteamID();
		if (RanksSystem.GetLoadedRank(steamID) != null)
		{
			RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(steamID);
			presence.smallImageText = ResourcesManager.OHKHAFCNHEI(steamID);
			presence.smallImageKey = "_Parameter";
			if (loadedRank.place <= 97)
			{
				presence.smallImageKey = "_Saturation";
			}
			else if (loadedRank.place <= 53)
			{
				presence.smallImageKey = "win";
			}
			else if (loadedRank.INIGKHLOKCD() <= 67)
			{
				presence.smallImageKey = "_ScreenResolution";
			}
			else if (loadedRank.place <= -61)
			{
				presence.smallImageKey = "ItemsCountText";
			}
		}
		DiscordRpc.NCAIFFNMMMP(presence);
	}

	private void ODGMCJILIHF()
	{
		if (inited)
		{
			Debug.Log(". The group number should be at least 1.");
			DiscordRpc.Shutdown();
		}
	}

	private void CJHMHIMKILB()
	{
		if (UnityEngine.Object.FindObjectsOfType(GetType()).Length > 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		BFKGHEBNCKL = this;
		UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
	}

	public void EEFCBACIHAH()
	{
		Debug.Log("[PowerUp]");
		DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.Yes);
		hasResponded.Invoke();
	}

	public void JDACNGIILEE(ref DiscordRpc.DiscordUser OCGEBABNLAG)
	{
		Debug.Log(string.Format("id", OCGEBABNLAG.username, OCGEBABNLAG.discriminator, OCGEBABNLAG.userId));
		onConnect.Invoke();
		inited = false;
	}

	public void BBMDALMFCHK(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("[LevelEditorScene] Error: You're not logged into Steam!", PNCJHNNOAAP, JKPJCEMPAGH));
		onDisconnect.Invoke();
	}

	public void COKMNBGJONL(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("Exit to Windows", PNCJHNNOAAP, JKPJCEMPAGH));
	}

	[SpecialName]
	public static DiscordController ELDHCIEPLLH()
	{
		return BFKGHEBNCKL;
	}

	public void IFKNIHJCAFB()
	{
		Debug.Log("SetPlayerDistance");
		DEBDALGLNCD = default(DiscordRpc.EventHandlers);
		ref DiscordRpc.EventHandlers dEBDALGLNCD = ref DEBDALGLNCD;
		dEBDALGLNCD.readyCallback = (DiscordRpc.OnReadyInfo)Delegate.Combine(dEBDALGLNCD.readyCallback, new DiscordRpc.OnReadyInfo(JDACNGIILEE));
		ref DiscordRpc.EventHandlers dEBDALGLNCD2 = ref DEBDALGLNCD;
		dEBDALGLNCD2.disconnectedCallback = (DiscordRpc.OnDisconnectedInfo)Delegate.Combine(dEBDALGLNCD2.disconnectedCallback, new DiscordRpc.OnDisconnectedInfo(FOODILEIOMK));
		ref DiscordRpc.EventHandlers dEBDALGLNCD3 = ref DEBDALGLNCD;
		dEBDALGLNCD3.errorCallback = (DiscordRpc.OnErrorInfo)Delegate.Combine(dEBDALGLNCD3.errorCallback, new DiscordRpc.OnErrorInfo(COKMNBGJONL));
		ref DiscordRpc.EventHandlers dEBDALGLNCD4 = ref DEBDALGLNCD;
		dEBDALGLNCD4.joinCallback = (DiscordRpc.OnJoinInfo)Delegate.Combine(dEBDALGLNCD4.joinCallback, new DiscordRpc.OnJoinInfo(AFPEOLCODFK));
		ref DiscordRpc.EventHandlers dEBDALGLNCD5 = ref DEBDALGLNCD;
		dEBDALGLNCD5.spectateCallback = (DiscordRpc.OnSpectateInfo)Delegate.Combine(dEBDALGLNCD5.spectateCallback, new DiscordRpc.OnSpectateInfo(PKGIMONADIG));
		ref DiscordRpc.EventHandlers dEBDALGLNCD6 = ref DEBDALGLNCD;
		dEBDALGLNCD6.requestCallback = (DiscordRpc.OnRequestInfo)Delegate.Combine(dEBDALGLNCD6.requestCallback, new DiscordRpc.OnRequestInfo(ILJJNGMHBHM));
		DiscordRpc.Initialize(applicationId, ref DEBDALGLNCD, true, optionalSteamId);
	}

	public void LLAJPKFNDIG()
	{
		Debug.Log("GameVolumeSlider");
		DEBDALGLNCD = default(DiscordRpc.EventHandlers);
		ref DiscordRpc.EventHandlers dEBDALGLNCD = ref DEBDALGLNCD;
		dEBDALGLNCD.readyCallback = (DiscordRpc.OnReadyInfo)Delegate.Combine(dEBDALGLNCD.readyCallback, new DiscordRpc.OnReadyInfo(JDACNGIILEE));
		ref DiscordRpc.EventHandlers dEBDALGLNCD2 = ref DEBDALGLNCD;
		dEBDALGLNCD2.disconnectedCallback = (DiscordRpc.OnDisconnectedInfo)Delegate.Combine(dEBDALGLNCD2.disconnectedCallback, new DiscordRpc.OnDisconnectedInfo(BBMDALMFCHK));
		ref DiscordRpc.EventHandlers dEBDALGLNCD3 = ref DEBDALGLNCD;
		dEBDALGLNCD3.errorCallback = (DiscordRpc.OnErrorInfo)Delegate.Combine(dEBDALGLNCD3.errorCallback, new DiscordRpc.OnErrorInfo(BNKGAALHKMG));
		ref DiscordRpc.EventHandlers dEBDALGLNCD4 = ref DEBDALGLNCD;
		dEBDALGLNCD4.joinCallback = (DiscordRpc.OnJoinInfo)Delegate.Combine(dEBDALGLNCD4.joinCallback, new DiscordRpc.OnJoinInfo(FFCOJBOLOAO));
		ref DiscordRpc.EventHandlers dEBDALGLNCD5 = ref DEBDALGLNCD;
		dEBDALGLNCD5.spectateCallback = (DiscordRpc.OnSpectateInfo)Delegate.Combine(dEBDALGLNCD5.spectateCallback, new DiscordRpc.OnSpectateInfo(JFKDLOCBONG));
		ref DiscordRpc.EventHandlers dEBDALGLNCD6 = ref DEBDALGLNCD;
		dEBDALGLNCD6.requestCallback = (DiscordRpc.OnRequestInfo)Delegate.Combine(dEBDALGLNCD6.requestCallback, new DiscordRpc.OnRequestInfo(KDPMCBLDGCI));
		DiscordRpc.Initialize(applicationId, ref DEBDALGLNCD, true, optionalSteamId);
	}

	private void GNPDGBNDCPL()
	{
		if (inited)
		{
			Debug.Log("_Value");
			DiscordRpc.Shutdown();
		}
	}

	public void KLPKKGGCLPH(string LELHDONCELF = null, string GACMHOJFDEI = null, int NOHGDKNLBFD = 0, int CINIDKKMLJG = 0)
	{
		if (LELHDONCELF != null)
		{
			presence.joinSecret = GameManager.EOBBGILNOEC(LELHDONCELF);
			presence.partyId = GACMHOJFDEI;
			presence.partySize = NOHGDKNLBFD;
			presence.partyMax = CINIDKKMLJG;
		}
		else
		{
			presence.joinSecret = null;
			presence.partyId = null;
			presence.partySize = NOHGDKNLBFD;
			presence.partyMax = CINIDKKMLJG;
		}
		DiscordRpc.BGEHIJNADHK(presence);
	}

	public void UpdateJoin(string LELHDONCELF = null, string GACMHOJFDEI = null, int NOHGDKNLBFD = 0, int CINIDKKMLJG = 0)
	{
		if (LELHDONCELF != null)
		{
			presence.joinSecret = GameManager.Encrypt(LELHDONCELF);
			presence.partyId = GACMHOJFDEI;
			presence.partySize = NOHGDKNLBFD;
			presence.partyMax = CINIDKKMLJG;
		}
		else
		{
			presence.joinSecret = null;
			presence.partyId = null;
			presence.partySize = NOHGDKNLBFD;
			presence.partyMax = CINIDKKMLJG;
		}
		DiscordRpc.UpdatePresence(presence);
	}

	public void DGFCPJKBECN(string IJPCEKICPCP, string ILPCDMBBCOF = null)
	{
		presence.state = ILPCDMBBCOF;
		presence.details = IJPCEKICPCP;
		presence.largeImageKey = "FullscreenToggle";
		presence.smallImageKey = null;
		CSteamID steamID = SteamUser.GetSteamID();
		if (RanksSystem.GetLoadedRank(steamID) != null)
		{
			RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(steamID);
			presence.smallImageText = ResourcesManager.GetLoadedSteamPlayername(steamID, false);
			presence.smallImageKey = "Current xp: ";
			if (loadedRank.CJILPHFNMEB() <= -76)
			{
				presence.smallImageKey = "EnableRankedNotificationsToggle";
			}
			else if (loadedRank.INIGKHLOKCD() <= -101)
			{
				presence.smallImageKey = "ItemNameBGImage";
			}
			else if (loadedRank.JCDLILAFFAJ() <= 45)
			{
				presence.smallImageKey = "Error! no audio sources attached to AudioSampler.css";
			}
			else if (loadedRank.CJILPHFNMEB() <= 67)
			{
				presence.smallImageKey = "[MapEditor] Loaded music file: ";
			}
		}
		DiscordRpc.IFHJIJOALEP(presence);
	}

	public void FOBPJLCOKPL(string LELHDONCELF = null, string GACMHOJFDEI = null, int NOHGDKNLBFD = 0, int CINIDKKMLJG = 0)
	{
		if (LELHDONCELF != null)
		{
			presence.joinSecret = GameManager.HGIFJHHKABG(LELHDONCELF);
			presence.partyId = GACMHOJFDEI;
			presence.partySize = NOHGDKNLBFD;
			presence.partyMax = CINIDKKMLJG;
		}
		else
		{
			presence.joinSecret = null;
			presence.partyId = null;
			presence.partySize = NOHGDKNLBFD;
			presence.partyMax = CINIDKKMLJG;
		}
		DiscordRpc.JJLKMAPPECD(presence);
	}

	public void ILJJNGMHBHM(ref DiscordRpc.DiscordUser GILCPIJNOKK)
	{
		Debug.Log(string.Format("_Val", GILCPIJNOKK.username, GILCPIJNOKK.discriminator, GILCPIJNOKK.userId));
		joinRequest = GILCPIJNOKK;
		onJoinRequest.Invoke(GILCPIJNOKK);
		StartCoroutine(DFJNNAALMIF());
	}

	public void ReadyCallback(ref DiscordRpc.DiscordUser OCGEBABNLAG)
	{
		Debug.Log($"[DiscordController] Connected to {OCGEBABNLAG.username}#{OCGEBABNLAG.discriminator}: {OCGEBABNLAG.userId}");
		onConnect.Invoke();
		inited = true;
	}

	public void OCHMKJKBAPI()
	{
		Debug.Log("_Size");
		DEBDALGLNCD = default(DiscordRpc.EventHandlers);
		ref DiscordRpc.EventHandlers dEBDALGLNCD = ref DEBDALGLNCD;
		dEBDALGLNCD.readyCallback = (DiscordRpc.OnReadyInfo)Delegate.Combine(dEBDALGLNCD.readyCallback, new DiscordRpc.OnReadyInfo(LALGGLEPBLH));
		ref DiscordRpc.EventHandlers dEBDALGLNCD2 = ref DEBDALGLNCD;
		dEBDALGLNCD2.disconnectedCallback = (DiscordRpc.OnDisconnectedInfo)Delegate.Combine(dEBDALGLNCD2.disconnectedCallback, new DiscordRpc.OnDisconnectedInfo(BBMDALMFCHK));
		ref DiscordRpc.EventHandlers dEBDALGLNCD3 = ref DEBDALGLNCD;
		dEBDALGLNCD3.errorCallback = (DiscordRpc.OnErrorInfo)Delegate.Combine(dEBDALGLNCD3.errorCallback, new DiscordRpc.OnErrorInfo(CJJLPIHKPIM));
		ref DiscordRpc.EventHandlers dEBDALGLNCD4 = ref DEBDALGLNCD;
		dEBDALGLNCD4.joinCallback = (DiscordRpc.OnJoinInfo)Delegate.Combine(dEBDALGLNCD4.joinCallback, new DiscordRpc.OnJoinInfo(FFCOJBOLOAO));
		ref DiscordRpc.EventHandlers dEBDALGLNCD5 = ref DEBDALGLNCD;
		dEBDALGLNCD5.spectateCallback = (DiscordRpc.OnSpectateInfo)Delegate.Combine(dEBDALGLNCD5.spectateCallback, new DiscordRpc.OnSpectateInfo(EGENODMDOKN));
		ref DiscordRpc.EventHandlers dEBDALGLNCD6 = ref DEBDALGLNCD;
		dEBDALGLNCD6.requestCallback = (DiscordRpc.OnRequestInfo)Delegate.Combine(dEBDALGLNCD6.requestCallback, new DiscordRpc.OnRequestInfo(ILJJNGMHBHM));
		DiscordRpc.Initialize(applicationId, ref DEBDALGLNCD, false, optionalSteamId);
	}

	public void KKGKOAGJEPB(string MJDPJLOCLIL)
	{
		Debug.Log(string.Format("id", MJDPJLOCLIL));
		onSpectate.Invoke(MJDPJLOCLIL);
	}

	public void JHBPINEKDPE()
	{
		Debug.Log("masterVolume");
		DEBDALGLNCD = default(DiscordRpc.EventHandlers);
		ref DiscordRpc.EventHandlers dEBDALGLNCD = ref DEBDALGLNCD;
		dEBDALGLNCD.readyCallback = (DiscordRpc.OnReadyInfo)Delegate.Combine(dEBDALGLNCD.readyCallback, new DiscordRpc.OnReadyInfo(JDACNGIILEE));
		ref DiscordRpc.EventHandlers dEBDALGLNCD2 = ref DEBDALGLNCD;
		dEBDALGLNCD2.disconnectedCallback = (DiscordRpc.OnDisconnectedInfo)Delegate.Combine(dEBDALGLNCD2.disconnectedCallback, new DiscordRpc.OnDisconnectedInfo(NPNJFADIOOP));
		ref DiscordRpc.EventHandlers dEBDALGLNCD3 = ref DEBDALGLNCD;
		dEBDALGLNCD3.errorCallback = (DiscordRpc.OnErrorInfo)Delegate.Combine(dEBDALGLNCD3.errorCallback, new DiscordRpc.OnErrorInfo(ErrorCallback));
		ref DiscordRpc.EventHandlers dEBDALGLNCD4 = ref DEBDALGLNCD;
		dEBDALGLNCD4.joinCallback = (DiscordRpc.OnJoinInfo)Delegate.Combine(dEBDALGLNCD4.joinCallback, new DiscordRpc.OnJoinInfo(HCOAPDBKODB));
		ref DiscordRpc.EventHandlers dEBDALGLNCD5 = ref DEBDALGLNCD;
		dEBDALGLNCD5.spectateCallback = (DiscordRpc.OnSpectateInfo)Delegate.Combine(dEBDALGLNCD5.spectateCallback, new DiscordRpc.OnSpectateInfo(KKGKOAGJEPB));
		ref DiscordRpc.EventHandlers dEBDALGLNCD6 = ref DEBDALGLNCD;
		dEBDALGLNCD6.requestCallback = (DiscordRpc.OnRequestInfo)Delegate.Combine(dEBDALGLNCD6.requestCallback, new DiscordRpc.OnRequestInfo(KDPMCBLDGCI));
		DiscordRpc.Initialize(applicationId, ref DEBDALGLNCD, true, optionalSteamId);
	}

	private void Awake()
	{
		if (UnityEngine.Object.FindObjectsOfType(GetType()).Length > 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		BFKGHEBNCKL = this;
		UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
	}

	public void KJKAANGEFPK()
	{
		Debug.Log("leave");
		DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.No);
		hasResponded.Invoke();
	}

	private void EHJJFJCKGAJ()
	{
		DiscordRpc.RunCallbacks();
	}

	private void FJHFOBHJEHL()
	{
		DiscordRpc.RunCallbacks();
	}

	private IEnumerator KOMOPGBIHAH(string KGINEMAHHFO)
	{
		yield return new WaitUntil(() => Singleton<SaveSystem>.Instance.isSaveLoaded && SteamManager.Initialized);
		if ((bool)UnityEngine.Object.FindObjectOfType<NetworkMenu>())
		{
			UnityEngine.Object.FindObjectOfType<NetworkMenu>().JoinRoomByID(KGINEMAHHFO);
		}
	}

	public void PGCALCPPHBB(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("Parameter levelId can't be null!", PNCJHNNOAAP, JKPJCEMPAGH));
	}

	public void ABDAHOONFNH(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("STOP [R]", PNCJHNNOAAP, JKPJCEMPAGH));
	}

	public void EAFFHHCMLCG()
	{
		Debug.Log("Set camera background color");
		DEBDALGLNCD = default(DiscordRpc.EventHandlers);
		ref DiscordRpc.EventHandlers dEBDALGLNCD = ref DEBDALGLNCD;
		dEBDALGLNCD.readyCallback = (DiscordRpc.OnReadyInfo)Delegate.Combine(dEBDALGLNCD.readyCallback, new DiscordRpc.OnReadyInfo(LALGGLEPBLH));
		ref DiscordRpc.EventHandlers dEBDALGLNCD2 = ref DEBDALGLNCD;
		dEBDALGLNCD2.disconnectedCallback = (DiscordRpc.OnDisconnectedInfo)Delegate.Combine(dEBDALGLNCD2.disconnectedCallback, new DiscordRpc.OnDisconnectedInfo(BBMDALMFCHK));
		ref DiscordRpc.EventHandlers dEBDALGLNCD3 = ref DEBDALGLNCD;
		dEBDALGLNCD3.errorCallback = (DiscordRpc.OnErrorInfo)Delegate.Combine(dEBDALGLNCD3.errorCallback, new DiscordRpc.OnErrorInfo(ELPKAJGLOAN));
		ref DiscordRpc.EventHandlers dEBDALGLNCD4 = ref DEBDALGLNCD;
		dEBDALGLNCD4.joinCallback = (DiscordRpc.OnJoinInfo)Delegate.Combine(dEBDALGLNCD4.joinCallback, new DiscordRpc.OnJoinInfo(BADJIGMFIKB));
		ref DiscordRpc.EventHandlers dEBDALGLNCD5 = ref DEBDALGLNCD;
		dEBDALGLNCD5.spectateCallback = (DiscordRpc.OnSpectateInfo)Delegate.Combine(dEBDALGLNCD5.spectateCallback, new DiscordRpc.OnSpectateInfo(EGENODMDOKN));
		ref DiscordRpc.EventHandlers dEBDALGLNCD6 = ref DEBDALGLNCD;
		dEBDALGLNCD6.requestCallback = (DiscordRpc.OnRequestInfo)Delegate.Combine(dEBDALGLNCD6.requestCallback, new DiscordRpc.OnRequestInfo(RequestCallback));
		DiscordRpc.Initialize(applicationId, ref DEBDALGLNCD, false, optionalSteamId);
	}

	public void IEFKKHALICN()
	{
		Debug.Log("LostAllLives");
		DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.No);
		hasResponded.Invoke();
	}

	public void CJJLPIHKPIM(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("_Value4", PNCJHNNOAAP, JKPJCEMPAGH));
	}

	private void PNNPDMHLFHE()
	{
		if (inited)
		{
			Debug.Log("SetPosition");
			DiscordRpc.Shutdown();
		}
	}

	private void CIAHIJIOFIE()
	{
		if (UnityEngine.Object.FindObjectsOfType(GetType()).Length > 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		BFKGHEBNCKL = this;
		UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
	}

	public void FFCOJBOLOAO(string MJDPJLOCLIL)
	{
		Debug.Log(string.Format("#no", MJDPJLOCLIL));
		onJoin.Invoke(MJDPJLOCLIL);
		string kGINEMAHHFO = GameManager.FHOAAADFONG(MJDPJLOCLIL);
		StartCoroutine(KOMOPGBIHAH(kGINEMAHHFO));
	}

	public void OAKONCDEPPI()
	{
		Debug.Log("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception");
		DEBDALGLNCD = default(DiscordRpc.EventHandlers);
		ref DiscordRpc.EventHandlers dEBDALGLNCD = ref DEBDALGLNCD;
		dEBDALGLNCD.readyCallback = (DiscordRpc.OnReadyInfo)Delegate.Combine(dEBDALGLNCD.readyCallback, new DiscordRpc.OnReadyInfo(LALGGLEPBLH));
		ref DiscordRpc.EventHandlers dEBDALGLNCD2 = ref DEBDALGLNCD;
		dEBDALGLNCD2.disconnectedCallback = (DiscordRpc.OnDisconnectedInfo)Delegate.Combine(dEBDALGLNCD2.disconnectedCallback, new DiscordRpc.OnDisconnectedInfo(BPNDNPJKEAB));
		ref DiscordRpc.EventHandlers dEBDALGLNCD3 = ref DEBDALGLNCD;
		dEBDALGLNCD3.errorCallback = (DiscordRpc.OnErrorInfo)Delegate.Combine(dEBDALGLNCD3.errorCallback, new DiscordRpc.OnErrorInfo(ErrorCallback));
		ref DiscordRpc.EventHandlers dEBDALGLNCD4 = ref DEBDALGLNCD;
		dEBDALGLNCD4.joinCallback = (DiscordRpc.OnJoinInfo)Delegate.Combine(dEBDALGLNCD4.joinCallback, new DiscordRpc.OnJoinInfo(FFCOJBOLOAO));
		ref DiscordRpc.EventHandlers dEBDALGLNCD5 = ref DEBDALGLNCD;
		dEBDALGLNCD5.spectateCallback = (DiscordRpc.OnSpectateInfo)Delegate.Combine(dEBDALGLNCD5.spectateCallback, new DiscordRpc.OnSpectateInfo(SpectateCallback));
		ref DiscordRpc.EventHandlers dEBDALGLNCD6 = ref DEBDALGLNCD;
		dEBDALGLNCD6.requestCallback = (DiscordRpc.OnRequestInfo)Delegate.Combine(dEBDALGLNCD6.requestCallback, new DiscordRpc.OnRequestInfo(RequestCallback));
		DiscordRpc.Initialize(applicationId, ref DEBDALGLNCD, true, optionalSteamId);
	}

	public void NPNJFADIOOP(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("CameraFilterPack/Retro_Loading", PNCJHNNOAAP, JKPJCEMPAGH));
		onDisconnect.Invoke();
	}

	public void BPNDNPJKEAB(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("_Sensitivity", PNCJHNNOAAP, JKPJCEMPAGH));
		onDisconnect.Invoke();
	}

	private void KACPCCMPAHA()
	{
		if (UnityEngine.Object.FindObjectsOfType(GetType()).Length > 0)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		BFKGHEBNCKL = this;
		UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
	}

	private void HNDNDPECBPL()
	{
		DiscordRpc.RunCallbacks();
	}

	public void FDMBOIJJILJ()
	{
		Debug.Log("JoinRandom failed: {0}.");
		DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.No);
		hasResponded.Invoke();
	}

	public void BKGLPPEEOAP(string MJDPJLOCLIL)
	{
		Debug.Log(string.Format("_Value", MJDPJLOCLIL));
		onSpectate.Invoke(MJDPJLOCLIL);
	}

	public void INGOODALACO()
	{
		Debug.Log("CameraFilterPack/Distortion_Noise");
		DEBDALGLNCD = default(DiscordRpc.EventHandlers);
		ref DiscordRpc.EventHandlers dEBDALGLNCD = ref DEBDALGLNCD;
		dEBDALGLNCD.readyCallback = (DiscordRpc.OnReadyInfo)Delegate.Combine(dEBDALGLNCD.readyCallback, new DiscordRpc.OnReadyInfo(ReadyCallback));
		ref DiscordRpc.EventHandlers dEBDALGLNCD2 = ref DEBDALGLNCD;
		dEBDALGLNCD2.disconnectedCallback = (DiscordRpc.OnDisconnectedInfo)Delegate.Combine(dEBDALGLNCD2.disconnectedCallback, new DiscordRpc.OnDisconnectedInfo(FOODILEIOMK));
		ref DiscordRpc.EventHandlers dEBDALGLNCD3 = ref DEBDALGLNCD;
		dEBDALGLNCD3.errorCallback = (DiscordRpc.OnErrorInfo)Delegate.Combine(dEBDALGLNCD3.errorCallback, new DiscordRpc.OnErrorInfo(ELPKAJGLOAN));
		ref DiscordRpc.EventHandlers dEBDALGLNCD4 = ref DEBDALGLNCD;
		dEBDALGLNCD4.joinCallback = (DiscordRpc.OnJoinInfo)Delegate.Combine(dEBDALGLNCD4.joinCallback, new DiscordRpc.OnJoinInfo(FFCOJBOLOAO));
		ref DiscordRpc.EventHandlers dEBDALGLNCD5 = ref DEBDALGLNCD;
		dEBDALGLNCD5.spectateCallback = (DiscordRpc.OnSpectateInfo)Delegate.Combine(dEBDALGLNCD5.spectateCallback, new DiscordRpc.OnSpectateInfo(SpectateCallback));
		ref DiscordRpc.EventHandlers dEBDALGLNCD6 = ref DEBDALGLNCD;
		dEBDALGLNCD6.requestCallback = (DiscordRpc.OnRequestInfo)Delegate.Combine(dEBDALGLNCD6.requestCallback, new DiscordRpc.OnRequestInfo(FOKMCMAOPBI));
		DiscordRpc.Initialize(applicationId, ref DEBDALGLNCD, true, optionalSteamId);
	}

	private void PGGNGAMLGAJ()
	{
		if (UnityEngine.Object.FindObjectsOfType(GetType()).Length > 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		BFKGHEBNCKL = this;
		UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
	}

	private void GGKPLCJNEHF()
	{
		if (UnityEngine.Object.FindObjectsOfType(GetType()).Length > 0)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		BFKGHEBNCKL = this;
		UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
	}

	private void DDPCJGIFJCF()
	{
	}

	public void FFFLJEOBGCE(string LELHDONCELF = null, string GACMHOJFDEI = null, int NOHGDKNLBFD = 0, int CINIDKKMLJG = 0)
	{
		if (LELHDONCELF != null)
		{
			presence.joinSecret = GameManager.MLFEBPAINHO(LELHDONCELF);
			presence.partyId = GACMHOJFDEI;
			presence.partySize = NOHGDKNLBFD;
			presence.partyMax = CINIDKKMLJG;
		}
		else
		{
			presence.joinSecret = null;
			presence.partyId = null;
			presence.partySize = NOHGDKNLBFD;
			presence.partyMax = CINIDKKMLJG;
		}
		DiscordRpc.IGEODKNADDD(presence);
	}

	private IEnumerator OJHJHNHGEEI(string KGINEMAHHFO)
	{
		yield return new WaitUntil(() => Singleton<SaveSystem>.Instance.isSaveLoaded && SteamManager.Initialized);
		if ((bool)UnityEngine.Object.FindObjectOfType<NetworkMenu>())
		{
			UnityEngine.Object.FindObjectOfType<NetworkMenu>().JoinRoomByID(KGINEMAHHFO);
		}
	}

	private void ANPPPGKOIBP()
	{
	}

	public void GHPMJEKMDCI(string MJDPJLOCLIL)
	{
		Debug.Log(string.Format("Save Path: ", MJDPJLOCLIL));
		onSpectate.Invoke(MJDPJLOCLIL);
	}

	public void FGGMHJOGKAJ(string IJPCEKICPCP, string ILPCDMBBCOF = null)
	{
		presence.state = ILPCDMBBCOF;
		presence.details = IJPCEKICPCP;
		presence.largeImageKey = "/icon";
		presence.smallImageKey = null;
		CSteamID steamID = SteamUser.GetSteamID();
		if (RanksSystem.GetLoadedRank(steamID) != null)
		{
			RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(steamID);
			presence.smallImageText = ResourcesManager.OHAGJGNCAPN(steamID, false);
			presence.smallImageKey = "[NetworkManager] roomInfo.name: ";
			if (loadedRank.place <= -85)
			{
				presence.smallImageKey = "OpLeaveLobby()";
			}
			else if (loadedRank.place <= -7)
			{
				presence.smallImageKey = "New SaveGame";
			}
			else if (loadedRank.CJILPHFNMEB() <= 47)
			{
				presence.smallImageKey = "[PhotonMessageInfo: Sender='{1}' Senttime={0}]";
			}
			else if (loadedRank.IGKJJMCLABK() <= 168)
			{
				presence.smallImageKey = "_MatrixColor";
			}
		}
		DiscordRpc.AABCMAPBDJN(presence);
	}

	public void HLCMOFCEJLP()
	{
		Debug.Log("y");
		DEBDALGLNCD = default(DiscordRpc.EventHandlers);
		ref DiscordRpc.EventHandlers dEBDALGLNCD = ref DEBDALGLNCD;
		dEBDALGLNCD.readyCallback = (DiscordRpc.OnReadyInfo)Delegate.Combine(dEBDALGLNCD.readyCallback, new DiscordRpc.OnReadyInfo(JDACNGIILEE));
		ref DiscordRpc.EventHandlers dEBDALGLNCD2 = ref DEBDALGLNCD;
		dEBDALGLNCD2.disconnectedCallback = (DiscordRpc.OnDisconnectedInfo)Delegate.Combine(dEBDALGLNCD2.disconnectedCallback, new DiscordRpc.OnDisconnectedInfo(DisconnectedCallback));
		ref DiscordRpc.EventHandlers dEBDALGLNCD3 = ref DEBDALGLNCD;
		dEBDALGLNCD3.errorCallback = (DiscordRpc.OnErrorInfo)Delegate.Combine(dEBDALGLNCD3.errorCallback, new DiscordRpc.OnErrorInfo(MHIPOFJKNKO));
		ref DiscordRpc.EventHandlers dEBDALGLNCD4 = ref DEBDALGLNCD;
		dEBDALGLNCD4.joinCallback = (DiscordRpc.OnJoinInfo)Delegate.Combine(dEBDALGLNCD4.joinCallback, new DiscordRpc.OnJoinInfo(BADJIGMFIKB));
		ref DiscordRpc.EventHandlers dEBDALGLNCD5 = ref DEBDALGLNCD;
		dEBDALGLNCD5.spectateCallback = (DiscordRpc.OnSpectateInfo)Delegate.Combine(dEBDALGLNCD5.spectateCallback, new DiscordRpc.OnSpectateInfo(KGBCMAKLBGA));
		ref DiscordRpc.EventHandlers dEBDALGLNCD6 = ref DEBDALGLNCD;
		dEBDALGLNCD6.requestCallback = (DiscordRpc.OnRequestInfo)Delegate.Combine(dEBDALGLNCD6.requestCallback, new DiscordRpc.OnRequestInfo(RequestCallback));
		DiscordRpc.Initialize(applicationId, ref DEBDALGLNCD, true, optionalSteamId);
	}

	public void IFHMKHDNHAC(string IJPCEKICPCP, string ILPCDMBBCOF = null)
	{
		presence.state = ILPCDMBBCOF;
		presence.details = IJPCEKICPCP;
		presence.largeImageKey = "CameraFilterPack_AAA_Blood2";
		presence.smallImageKey = null;
		CSteamID steamID = SteamUser.GetSteamID();
		if (RanksSystem.GetLoadedRank(steamID) != null)
		{
			RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(steamID);
			presence.smallImageText = ResourcesManager.DOILNLEFLAP(steamID, false);
			presence.smallImageKey = "#close";
			if (loadedRank.place <= -121)
			{
				presence.smallImageKey = "_Bullet_3";
			}
			else if (loadedRank.INIGKHLOKCD() <= -34)
			{
				presence.smallImageKey = "[ResourcesManager] Load audio error: ";
			}
			else if (loadedRank.INIGKHLOKCD() <= -16)
			{
				presence.smallImageKey = ".lastCheckpoint.penaltyScore";
			}
			else if (loadedRank.place <= -42)
			{
				presence.smallImageKey = "Mouse X";
			}
		}
		DiscordRpc.HPFIDCEGLIN(presence);
	}

	private IEnumerator KJLFOJHECGL(string KGINEMAHHFO)
	{
		yield return new WaitUntil(() => Singleton<SaveSystem>.Instance.isSaveLoaded && SteamManager.Initialized);
		if ((bool)UnityEngine.Object.FindObjectOfType<NetworkMenu>())
		{
			UnityEngine.Object.FindObjectOfType<NetworkMenu>().JoinRoomByID(KGINEMAHHFO);
		}
	}

	public void JBFOLLCGNEH(string LELHDONCELF = null, string GACMHOJFDEI = null, int NOHGDKNLBFD = 0, int CINIDKKMLJG = 0)
	{
		if (LELHDONCELF != null)
		{
			presence.joinSecret = GameManager.OLLCLOPGHGI(LELHDONCELF);
			presence.partyId = GACMHOJFDEI;
			presence.partySize = NOHGDKNLBFD;
			presence.partyMax = CINIDKKMLJG;
		}
		else
		{
			presence.joinSecret = null;
			presence.partyId = null;
			presence.partySize = NOHGDKNLBFD;
			presence.partyMax = CINIDKKMLJG;
		}
		DiscordRpc.GIMHBMFOBPK(presence);
	}

	private void DHNANELONED()
	{
		if (UnityEngine.Object.FindObjectsOfType(GetType()).Length > 0)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		BFKGHEBNCKL = this;
		UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
	}

	private void HACCDOCHKGL()
	{
	}

	public void EGENODMDOKN(string MJDPJLOCLIL)
	{
		Debug.Log(string.Format("NO", MJDPJLOCLIL));
		onSpectate.Invoke(MJDPJLOCLIL);
	}

	public void LALGGLEPBLH(ref DiscordRpc.DiscordUser OCGEBABNLAG)
	{
		Debug.Log(string.Format(" id: ", OCGEBABNLAG.username, OCGEBABNLAG.discriminator, OCGEBABNLAG.userId));
		onConnect.Invoke();
		inited = false;
	}

	public void AHMKBKFJCJA(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("_SizeX", PNCJHNNOAAP, JKPJCEMPAGH));
	}

	public void RequestRespondYes()
	{
		Debug.Log("[DiscordController] Responding yes to Ask to Join request");
		DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.Yes);
		hasResponded.Invoke();
	}

	private void OnDestroy()
	{
	}

	public void PKGIMONADIG(string MJDPJLOCLIL)
	{
		Debug.Log(string.Format("[LevelEditorScene] Error: I/O Failure! :(", MJDPJLOCLIL));
		onSpectate.Invoke(MJDPJLOCLIL);
	}

	public void MHJKKJIOPID(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("[Steamworks.NET] Could not load [lib]steam_api.dll/so/dylib. It's likely not in the correct location. Refer to the README for more details.\n", PNCJHNNOAAP, JKPJCEMPAGH));
		onDisconnect.Invoke();
	}

	private IEnumerator LNLHGEBABOH()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#discord{0}joinrequest".Replace("{0}", joinRequest.username), "#yes", delegate
		{
			DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.Yes);
		}, "#no", delegate
		{
			DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.No);
		}));
	}

	public void AAPMAEFHKEO()
	{
		Debug.Log("menu.hardcoreinfo");
		DEBDALGLNCD = default(DiscordRpc.EventHandlers);
		ref DiscordRpc.EventHandlers dEBDALGLNCD = ref DEBDALGLNCD;
		dEBDALGLNCD.readyCallback = (DiscordRpc.OnReadyInfo)Delegate.Combine(dEBDALGLNCD.readyCallback, new DiscordRpc.OnReadyInfo(JDACNGIILEE));
		ref DiscordRpc.EventHandlers dEBDALGLNCD2 = ref DEBDALGLNCD;
		dEBDALGLNCD2.disconnectedCallback = (DiscordRpc.OnDisconnectedInfo)Delegate.Combine(dEBDALGLNCD2.disconnectedCallback, new DiscordRpc.OnDisconnectedInfo(NPNJFADIOOP));
		ref DiscordRpc.EventHandlers dEBDALGLNCD3 = ref DEBDALGLNCD;
		dEBDALGLNCD3.errorCallback = (DiscordRpc.OnErrorInfo)Delegate.Combine(dEBDALGLNCD3.errorCallback, new DiscordRpc.OnErrorInfo(ABDAHOONFNH));
		ref DiscordRpc.EventHandlers dEBDALGLNCD4 = ref DEBDALGLNCD;
		dEBDALGLNCD4.joinCallback = (DiscordRpc.OnJoinInfo)Delegate.Combine(dEBDALGLNCD4.joinCallback, new DiscordRpc.OnJoinInfo(JoinCallback));
		ref DiscordRpc.EventHandlers dEBDALGLNCD5 = ref DEBDALGLNCD;
		dEBDALGLNCD5.spectateCallback = (DiscordRpc.OnSpectateInfo)Delegate.Combine(dEBDALGLNCD5.spectateCallback, new DiscordRpc.OnSpectateInfo(KKGKOAGJEPB));
		ref DiscordRpc.EventHandlers dEBDALGLNCD6 = ref DEBDALGLNCD;
		dEBDALGLNCD6.requestCallback = (DiscordRpc.OnRequestInfo)Delegate.Combine(dEBDALGLNCD6.requestCallback, new DiscordRpc.OnRequestInfo(RequestCallback));
		DiscordRpc.Initialize(applicationId, ref DEBDALGLNCD, false, optionalSteamId);
	}

	private IEnumerator DFJNNAALMIF()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#discord{0}joinrequest".Replace("{0}", joinRequest.username), "#yes", delegate
		{
			DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.Yes);
		}, "#no", delegate
		{
			DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.No);
		}));
	}

	private void LBPCODPOJAH()
	{
		DiscordRpc.RunCallbacks();
	}

	public void CBIPOKCJEPJ(string IJPCEKICPCP, string ILPCDMBBCOF = null)
	{
		presence.state = ILPCDMBBCOF;
		presence.details = IJPCEKICPCP;
		presence.largeImageKey = "Not sending leave operation. State is not 'Joined': ";
		presence.smallImageKey = null;
		CSteamID steamID = SteamUser.GetSteamID();
		if (RanksSystem.GetLoadedRank(steamID) != null)
		{
			RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(steamID);
			presence.smallImageText = ResourcesManager.OHAGJGNCAPN(steamID);
			presence.smallImageKey = "_Color";
			if (loadedRank.CJILPHFNMEB() <= 23)
			{
				presence.smallImageKey = "settings.arcsdestroydelay";
			}
			else if (loadedRank.IEOGJOLGLFI() <= 106)
			{
				presence.smallImageKey = " (inactive)";
			}
			else if (loadedRank.JCDLILAFFAJ() <= 30)
			{
				presence.smallImageKey = "ChatInput";
			}
			else if (loadedRank.INIGKHLOKCD() <= -60)
			{
				presence.smallImageKey = "player.fire";
			}
		}
		DiscordRpc.PFPMBIEMAIP(presence);
	}

	public void CCMIMIMBMOD(string LELHDONCELF = null, string GACMHOJFDEI = null, int NOHGDKNLBFD = 0, int CINIDKKMLJG = 0)
	{
		if (LELHDONCELF != null)
		{
			presence.joinSecret = GameManager.OLLCLOPGHGI(LELHDONCELF);
			presence.partyId = GACMHOJFDEI;
			presence.partySize = NOHGDKNLBFD;
			presence.partyMax = CINIDKKMLJG;
		}
		else
		{
			presence.joinSecret = null;
			presence.partyId = null;
			presence.partySize = NOHGDKNLBFD;
			presence.partyMax = CINIDKKMLJG;
		}
		DiscordRpc.BGEHIJNADHK(presence);
	}

	public void FOKMCMAOPBI(ref DiscordRpc.DiscordUser GILCPIJNOKK)
	{
		Debug.Log(string.Format("Anime", GILCPIJNOKK.username, GILCPIJNOKK.discriminator, GILCPIJNOKK.userId));
		joinRequest = GILCPIJNOKK;
		onJoinRequest.Invoke(GILCPIJNOKK);
		StartCoroutine(HJGLCIPNDDI());
	}

	private IEnumerator BLAGLOKLEFP()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#discord{0}joinrequest".Replace("{0}", joinRequest.username), "#yes", delegate
		{
			DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.Yes);
		}, "#no", delegate
		{
			DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.No);
		}));
	}

	public void BNKGAALHKMG(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format(" This is not possible to be called for standalone input. Please check your platform and code where this is called", PNCJHNNOAAP, JKPJCEMPAGH));
	}

	public void KDPMCBLDGCI(ref DiscordRpc.DiscordUser GILCPIJNOKK)
	{
		Debug.Log(string.Format("PhotonNetwork error: Could not Instantiate the prefab [", GILCPIJNOKK.username, GILCPIJNOKK.discriminator, GILCPIJNOKK.userId));
		joinRequest = GILCPIJNOKK;
		onJoinRequest.Invoke(GILCPIJNOKK);
		StartCoroutine(LNLHGEBABOH());
	}

	public void BADJIGMFIKB(string MJDPJLOCLIL)
	{
		Debug.Log(string.Format("\" that takes ", MJDPJLOCLIL));
		onJoin.Invoke(MJDPJLOCLIL);
		string kGINEMAHHFO = GameManager.BLNJDEEDEDJ(MJDPJLOCLIL);
		StartCoroutine(KJLFOJHECGL(kGINEMAHHFO));
	}

	public void LLBCOONOCFB()
	{
		Debug.Log("_Vignette");
		DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.No);
		hasResponded.Invoke();
	}

	public void MIBLNODIDGN(string LELHDONCELF = null, string GACMHOJFDEI = null, int NOHGDKNLBFD = 0, int CINIDKKMLJG = 0)
	{
		if (LELHDONCELF != null)
		{
			presence.joinSecret = GameManager.OLLCLOPGHGI(LELHDONCELF);
			presence.partyId = GACMHOJFDEI;
			presence.partySize = NOHGDKNLBFD;
			presence.partyMax = CINIDKKMLJG;
		}
		else
		{
			presence.joinSecret = null;
			presence.partyId = null;
			presence.partySize = NOHGDKNLBFD;
			presence.partyMax = CINIDKKMLJG;
		}
		DiscordRpc.GIMHBMFOBPK(presence);
	}

	private void KANBABCDCAC()
	{
	}

	private IEnumerator HJGLCIPNDDI()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#discord{0}joinrequest".Replace("{0}", joinRequest.username), "#yes", delegate
		{
			DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.Yes);
		}, "#no", delegate
		{
			DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.No);
		}));
	}

	private IEnumerator HPIBPBBFBGB()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#discord{0}joinrequest".Replace("{0}", joinRequest.username), "#yes", delegate
		{
			DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.Yes);
		}, "#no", delegate
		{
			DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.No);
		}));
	}

	private void DHNGNHGDPLM()
	{
		if (inited)
		{
			Debug.Log("_ScreenResolution");
			DiscordRpc.Shutdown();
		}
	}

	public void HCOAPDBKODB(string MJDPJLOCLIL)
	{
		Debug.Log(string.Format("ShowTitle", MJDPJLOCLIL));
		onJoin.Invoke(MJDPJLOCLIL);
		string kGINEMAHHFO = GameManager.BLNJDEEDEDJ(MJDPJLOCLIL);
		StartCoroutine(KOMOPGBIHAH(kGINEMAHHFO));
	}

	private IEnumerator HDOKDPAMIIN()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#discord{0}joinrequest".Replace("{0}", joinRequest.username), "#yes", delegate
		{
			DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.Yes);
		}, "#no", delegate
		{
			DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.No);
		}));
	}

	public void ELPKAJGLOAN(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("_LutTex", PNCJHNNOAAP, JKPJCEMPAGH));
	}

	public void OnEnable()
	{
		Debug.Log("[DiscordController] Init");
		DEBDALGLNCD = default(DiscordRpc.EventHandlers);
		ref DiscordRpc.EventHandlers dEBDALGLNCD = ref DEBDALGLNCD;
		dEBDALGLNCD.readyCallback = (DiscordRpc.OnReadyInfo)Delegate.Combine(dEBDALGLNCD.readyCallback, new DiscordRpc.OnReadyInfo(ReadyCallback));
		ref DiscordRpc.EventHandlers dEBDALGLNCD2 = ref DEBDALGLNCD;
		dEBDALGLNCD2.disconnectedCallback = (DiscordRpc.OnDisconnectedInfo)Delegate.Combine(dEBDALGLNCD2.disconnectedCallback, new DiscordRpc.OnDisconnectedInfo(DisconnectedCallback));
		ref DiscordRpc.EventHandlers dEBDALGLNCD3 = ref DEBDALGLNCD;
		dEBDALGLNCD3.errorCallback = (DiscordRpc.OnErrorInfo)Delegate.Combine(dEBDALGLNCD3.errorCallback, new DiscordRpc.OnErrorInfo(ErrorCallback));
		ref DiscordRpc.EventHandlers dEBDALGLNCD4 = ref DEBDALGLNCD;
		dEBDALGLNCD4.joinCallback = (DiscordRpc.OnJoinInfo)Delegate.Combine(dEBDALGLNCD4.joinCallback, new DiscordRpc.OnJoinInfo(JoinCallback));
		ref DiscordRpc.EventHandlers dEBDALGLNCD5 = ref DEBDALGLNCD;
		dEBDALGLNCD5.spectateCallback = (DiscordRpc.OnSpectateInfo)Delegate.Combine(dEBDALGLNCD5.spectateCallback, new DiscordRpc.OnSpectateInfo(SpectateCallback));
		ref DiscordRpc.EventHandlers dEBDALGLNCD6 = ref DEBDALGLNCD;
		dEBDALGLNCD6.requestCallback = (DiscordRpc.OnRequestInfo)Delegate.Combine(dEBDALGLNCD6.requestCallback, new DiscordRpc.OnRequestInfo(RequestCallback));
		DiscordRpc.Initialize(applicationId, ref DEBDALGLNCD, true, optionalSteamId);
	}

	[SpecialName]
	public static DiscordController KDAJPJPBIBI()
	{
		return BFKGHEBNCKL;
	}

	public void HIDGEDNCFAO(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("_Value5", PNCJHNNOAAP, JKPJCEMPAGH));
	}

	public void FBNJEFFDMHJ()
	{
		Debug.Log("#mapnotloaded");
		DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.No);
		hasResponded.Invoke();
	}

	private IEnumerator CNGHGNJOFAE()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#discord{0}joinrequest".Replace("{0}", joinRequest.username), "#yes", delegate
		{
			DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.Yes);
		}, "#no", delegate
		{
			DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.No);
		}));
	}

	public void ErrorCallback(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log($"[DiscordController] Error {PNCJHNNOAAP}: {JKPJCEMPAGH}");
	}

	public void FLEFCDDEDBN(string IJPCEKICPCP, string ILPCDMBBCOF = null)
	{
		presence.state = ILPCDMBBCOF;
		presence.details = IJPCEKICPCP;
		presence.largeImageKey = "_EmissionColor";
		presence.smallImageKey = null;
		CSteamID steamID = SteamUser.GetSteamID();
		if (RanksSystem.GetLoadedRank(steamID) != null)
		{
			RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(steamID);
			presence.smallImageText = ResourcesManager.LEKJAGAKEAM(steamID, false);
			presence.smallImageKey = "master";
			if (loadedRank.JCDLILAFFAJ() <= -75)
			{
				presence.smallImageKey = "CreateRoom failed, client stays on masterserver: {0}.";
			}
			else if (loadedRank.JCDLILAFFAJ() <= 83)
			{
				presence.smallImageKey = ".completed";
			}
			else if (loadedRank.IGKJJMCLABK() <= 124)
			{
				presence.smallImageKey = "_NoisePerChannel";
			}
			else if (loadedRank.place <= 132)
			{
				presence.smallImageKey = "CameraFilterPack/TV_ARCADE_Fast";
			}
		}
		DiscordRpc.UpdatePresence(presence);
	}

	public void IGFIHJNBJMB(string IJPCEKICPCP, string ILPCDMBBCOF = null)
	{
		presence.state = ILPCDMBBCOF;
		presence.details = IJPCEKICPCP;
		presence.largeImageKey = "_Value4";
		presence.smallImageKey = null;
		CSteamID steamID = SteamUser.GetSteamID();
		if (RanksSystem.GetLoadedRank(steamID) != null)
		{
			RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(steamID);
			presence.smallImageText = ResourcesManager.OHKHAFCNHEI(steamID, false);
			presence.smallImageKey = "float,2";
			if (loadedRank.place <= 1)
			{
				presence.smallImageKey = " not exist";
			}
			else if (loadedRank.IGKJJMCLABK() <= -69)
			{
				presence.smallImageKey = "[PlayerController] ";
			}
			else if (loadedRank.JCDLILAFFAJ() <= -87)
			{
				presence.smallImageKey = "_TimeX";
			}
			else if (loadedRank.IGKJJMCLABK() <= -4)
			{
				presence.smallImageKey = "[LocalizationService] Loading file: ";
			}
		}
		DiscordRpc.OEFLFJBONMN(presence);
	}

	public void KOFFDOHJIAK()
	{
		Debug.Log("float,0");
		DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.Yes);
		hasResponded.Invoke();
	}

	public void SpectateCallback(string MJDPJLOCLIL)
	{
		Debug.Log($"[DiscordController] Sectate ({MJDPJLOCLIL})");
		onSpectate.Invoke(MJDPJLOCLIL);
	}

	public void NLGDPIBFHMK()
	{
		Debug.Log("_Parameter");
		DEBDALGLNCD = default(DiscordRpc.EventHandlers);
		ref DiscordRpc.EventHandlers dEBDALGLNCD = ref DEBDALGLNCD;
		dEBDALGLNCD.readyCallback = (DiscordRpc.OnReadyInfo)Delegate.Combine(dEBDALGLNCD.readyCallback, new DiscordRpc.OnReadyInfo(ReadyCallback));
		ref DiscordRpc.EventHandlers dEBDALGLNCD2 = ref DEBDALGLNCD;
		dEBDALGLNCD2.disconnectedCallback = (DiscordRpc.OnDisconnectedInfo)Delegate.Combine(dEBDALGLNCD2.disconnectedCallback, new DiscordRpc.OnDisconnectedInfo(DisconnectedCallback));
		ref DiscordRpc.EventHandlers dEBDALGLNCD3 = ref DEBDALGLNCD;
		dEBDALGLNCD3.errorCallback = (DiscordRpc.OnErrorInfo)Delegate.Combine(dEBDALGLNCD3.errorCallback, new DiscordRpc.OnErrorInfo(ELPKAJGLOAN));
		ref DiscordRpc.EventHandlers dEBDALGLNCD4 = ref DEBDALGLNCD;
		dEBDALGLNCD4.joinCallback = (DiscordRpc.OnJoinInfo)Delegate.Combine(dEBDALGLNCD4.joinCallback, new DiscordRpc.OnJoinInfo(FFCOJBOLOAO));
		ref DiscordRpc.EventHandlers dEBDALGLNCD5 = ref DEBDALGLNCD;
		dEBDALGLNCD5.spectateCallback = (DiscordRpc.OnSpectateInfo)Delegate.Combine(dEBDALGLNCD5.spectateCallback, new DiscordRpc.OnSpectateInfo(SpectateCallback));
		ref DiscordRpc.EventHandlers dEBDALGLNCD6 = ref DEBDALGLNCD;
		dEBDALGLNCD6.requestCallback = (DiscordRpc.OnRequestInfo)Delegate.Combine(dEBDALGLNCD6.requestCallback, new DiscordRpc.OnRequestInfo(RequestCallback));
		DiscordRpc.Initialize(applicationId, ref DEBDALGLNCD, false, optionalSteamId);
	}

	[SpecialName]
	public static DiscordController OFEINMJONLO()
	{
		return BFKGHEBNCKL;
	}

	public void EJDOJKLHJAD()
	{
		Debug.Log("_Value4");
		DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.No);
		hasResponded.Invoke();
	}

	private IEnumerator OBNKBHOFCAO(string KGINEMAHHFO)
	{
		yield return new WaitUntil(() => Singleton<SaveSystem>.Instance.isSaveLoaded && SteamManager.Initialized);
		if ((bool)UnityEngine.Object.FindObjectOfType<NetworkMenu>())
		{
			UnityEngine.Object.FindObjectOfType<NetworkMenu>().JoinRoomByID(KGINEMAHHFO);
		}
	}

	private void KHBLMEGPPLJ()
	{
	}

	public void MHIPOFJKNKO(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("_Value2", PNCJHNNOAAP, JKPJCEMPAGH));
	}

	public void KGNFAPNFEPC(string IJPCEKICPCP, string ILPCDMBBCOF = null)
	{
		presence.state = ILPCDMBBCOF;
		presence.details = IJPCEKICPCP;
		presence.largeImageKey = "CameraFilterPack/Vision_Hell_Blood";
		presence.smallImageKey = null;
		CSteamID steamID = SteamUser.GetSteamID();
		if (RanksSystem.GetLoadedRank(steamID) != null)
		{
			RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(steamID);
			presence.smallImageText = ResourcesManager.OHKHAFCNHEI(steamID);
			presence.smallImageKey = "GlassDistortion";
			if (loadedRank.place <= -1)
			{
				presence.smallImageKey = ".a";
			}
			else if (loadedRank.IEOGJOLGLFI() <= 33)
			{
				presence.smallImageKey = ".lastCheckpoint.lives";
			}
			else if (loadedRank.IGKJJMCLABK() <= -8)
			{
				presence.smallImageKey = "settings_bindings_sec_";
			}
			else if (loadedRank.CJILPHFNMEB() <= -117)
			{
				presence.smallImageKey = "Please attach component to a Graphical UI component";
			}
		}
		DiscordRpc.NDDOOOKGNKB(presence);
	}

	public void CCDJCDOGOFD(string IJPCEKICPCP, string ILPCDMBBCOF = null)
	{
		presence.state = ILPCDMBBCOF;
		presence.details = IJPCEKICPCP;
		presence.largeImageKey = " not exist";
		presence.smallImageKey = null;
		CSteamID steamID = SteamUser.GetSteamID();
		if (RanksSystem.GetLoadedRank(steamID) != null)
		{
			RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(steamID);
			presence.smallImageText = ResourcesManager.OHAGJGNCAPN(steamID);
			presence.smallImageKey = "GroupNameText";
			if (loadedRank.CJILPHFNMEB() <= -11)
			{
				presence.smallImageKey = "_Value2";
			}
			else if (loadedRank.IGKJJMCLABK() <= -57)
			{
				presence.smallImageKey = "Editor/";
			}
			else if (loadedRank.IGKJJMCLABK() <= -118)
			{
				presence.smallImageKey = "OnPlayerGameMessage";
			}
			else if (loadedRank.IEOGJOLGLFI() <= -22)
			{
				presence.smallImageKey = "VisionBlur";
			}
		}
		DiscordRpc.BGEHIJNADHK(presence);
	}

	public void LHINMOCPGHM()
	{
		Debug.Log("Editor");
		DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.Yes);
		hasResponded.Invoke();
	}

	public void ANAHGFDJLCJ()
	{
		Debug.Log(").png");
		DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.No);
		hasResponded.Invoke();
	}

	public void DisconnectedCallback(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log($"[DiscordController] Disconnect {PNCJHNNOAAP}: {JKPJCEMPAGH}");
		onDisconnect.Invoke();
	}

	private void EJJEDJIOFAB()
	{
		if (inited)
		{
			Debug.Log("CompletedLevel");
			DiscordRpc.Shutdown();
		}
	}

	[SpecialName]
	public static DiscordController CJBKCCLGIAG()
	{
		return BFKGHEBNCKL;
	}

	private void CBIBDOIBJAI()
	{
		if (inited)
		{
			Debug.Log(">");
			DiscordRpc.Shutdown();
		}
	}

	public void FOODILEIOMK(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("_Intensity", PNCJHNNOAAP, JKPJCEMPAGH));
		onDisconnect.Invoke();
	}

	public void CLHABPEJCJJ()
	{
		Debug.Log("#random #rare #item");
		DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.No);
		hasResponded.Invoke();
	}

	private void OBEJFFEJOBJ()
	{
		if (UnityEngine.Object.FindObjectsOfType(GetType()).Length > 0)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		BFKGHEBNCKL = this;
		UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
	}

	public void RequestRespondNo()
	{
		Debug.Log("[DiscordController] Responding no to Ask to Join request");
		DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.No);
		hasResponded.Invoke();
	}

	public void DGEPPDJDBLN()
	{
		Debug.Log("_ScreenResolution");
		DEBDALGLNCD = default(DiscordRpc.EventHandlers);
		ref DiscordRpc.EventHandlers dEBDALGLNCD = ref DEBDALGLNCD;
		dEBDALGLNCD.readyCallback = (DiscordRpc.OnReadyInfo)Delegate.Combine(dEBDALGLNCD.readyCallback, new DiscordRpc.OnReadyInfo(ReadyCallback));
		ref DiscordRpc.EventHandlers dEBDALGLNCD2 = ref DEBDALGLNCD;
		dEBDALGLNCD2.disconnectedCallback = (DiscordRpc.OnDisconnectedInfo)Delegate.Combine(dEBDALGLNCD2.disconnectedCallback, new DiscordRpc.OnDisconnectedInfo(FOODILEIOMK));
		ref DiscordRpc.EventHandlers dEBDALGLNCD3 = ref DEBDALGLNCD;
		dEBDALGLNCD3.errorCallback = (DiscordRpc.OnErrorInfo)Delegate.Combine(dEBDALGLNCD3.errorCallback, new DiscordRpc.OnErrorInfo(ErrorCallback));
		ref DiscordRpc.EventHandlers dEBDALGLNCD4 = ref DEBDALGLNCD;
		dEBDALGLNCD4.joinCallback = (DiscordRpc.OnJoinInfo)Delegate.Combine(dEBDALGLNCD4.joinCallback, new DiscordRpc.OnJoinInfo(BADJIGMFIKB));
		ref DiscordRpc.EventHandlers dEBDALGLNCD5 = ref DEBDALGLNCD;
		dEBDALGLNCD5.spectateCallback = (DiscordRpc.OnSpectateInfo)Delegate.Combine(dEBDALGLNCD5.spectateCallback, new DiscordRpc.OnSpectateInfo(SpectateCallback));
		ref DiscordRpc.EventHandlers dEBDALGLNCD6 = ref DEBDALGLNCD;
		dEBDALGLNCD6.requestCallback = (DiscordRpc.OnRequestInfo)Delegate.Combine(dEBDALGLNCD6.requestCallback, new DiscordRpc.OnRequestInfo(RequestCallback));
		DiscordRpc.Initialize(applicationId, ref DEBDALGLNCD, false, optionalSteamId);
	}

	public void JFKDLOCBONG(string MJDPJLOCLIL)
	{
		Debug.Log(string.Format("_TimeX", MJDPJLOCLIL));
		onSpectate.Invoke(MJDPJLOCLIL);
	}

	private void PFNFPINPCMH()
	{
		DiscordRpc.RunCallbacks();
	}

	private void Update()
	{
		DiscordRpc.RunCallbacks();
	}

	[SpecialName]
	public static DiscordController MFPEEHNEFIM()
	{
		return BFKGHEBNCKL;
	}

	public void CAHGHLOIOKM(string LELHDONCELF = null, string GACMHOJFDEI = null, int NOHGDKNLBFD = 0, int CINIDKKMLJG = 0)
	{
		if (LELHDONCELF != null)
		{
			presence.joinSecret = GameManager.OLLCLOPGHGI(LELHDONCELF);
			presence.partyId = GACMHOJFDEI;
			presence.partySize = NOHGDKNLBFD;
			presence.partyMax = CINIDKKMLJG;
		}
		else
		{
			presence.joinSecret = null;
			presence.partyId = null;
			presence.partySize = NOHGDKNLBFD;
			presence.partyMax = CINIDKKMLJG;
		}
		DiscordRpc.OEFLFJBONMN(presence);
	}

	private void NEKCPLGFOFD()
	{
		DiscordRpc.RunCallbacks();
	}

	[SpecialName]
	public static DiscordController NLEPFMACKHN()
	{
		return BFKGHEBNCKL;
	}

	private void OnDisable()
	{
		if (inited)
		{
			Debug.Log("[DiscordController] Shutdown");
			DiscordRpc.Shutdown();
		}
	}

	public void RequestCallback(ref DiscordRpc.DiscordUser GILCPIJNOKK)
	{
		Debug.Log($"[DiscordController] Join request {GILCPIJNOKK.username}#{GILCPIJNOKK.discriminator}: {GILCPIJNOKK.userId}");
		joinRequest = GILCPIJNOKK;
		onJoinRequest.Invoke(GILCPIJNOKK);
		StartCoroutine(LNLHGEBABOH());
	}
}
