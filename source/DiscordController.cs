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

	private void POEEMFJIMIP()
	{
		if (UnityEngine.Object.FindObjectsOfType(GetType()).Length > 1)
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

	public void GANJNHLKEAN(ref DiscordRpc.DiscordUser GILCPIJNOKK)
	{
		Debug.Log(string.Format("CameraFilterPack/Pixel_Pixelisation", GILCPIJNOKK.username, GILCPIJNOKK.discriminator, GILCPIJNOKK.userId));
		joinRequest = GILCPIJNOKK;
		onJoinRequest.Invoke(GILCPIJNOKK);
		StartCoroutine(JLNDNKCKFMM());
	}

	private IEnumerator NGEJLEIHLCB()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#discord{0}joinrequest".Replace("{0}", joinRequest.username), "#yes", delegate
		{
			DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.Yes);
		}, "#no", delegate
		{
			DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.No);
		}));
	}

	public void JoinCallback(string MJDPJLOCLIL)
	{
		Debug.Log($"[DiscordController] Join ({MJDPJLOCLIL})");
		onJoin.Invoke(MJDPJLOCLIL);
		string kGINEMAHHFO = GameManager.Decrypt(MJDPJLOCLIL);
		StartCoroutine(KJLFOJHECGL(kGINEMAHHFO));
	}

	public void CBODPIHCEGA(string MJDPJLOCLIL)
	{
		Debug.Log(string.Format("ShowTitle", MJDPJLOCLIL));
		onJoin.Invoke(MJDPJLOCLIL);
		string kGINEMAHHFO = GameManager.CHADLKENPOO(MJDPJLOCLIL);
		StartCoroutine(KJGBKGACNLL(kGINEMAHHFO));
	}

	public void IIICEMAHEFI(ref DiscordRpc.DiscordUser GILCPIJNOKK)
	{
		Debug.Log(string.Format("SpawnObj", GILCPIJNOKK.username, GILCPIJNOKK.discriminator, GILCPIJNOKK.userId));
		joinRequest = GILCPIJNOKK;
		onJoinRequest.Invoke(GILCPIJNOKK);
		StartCoroutine(EJNMPGAOIJE());
	}

	public void ENCLPEECENL()
	{
		Debug.Log("maps.");
		DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.Yes);
		hasResponded.Invoke();
	}

	public void JNIEKHLEICK(string LELHDONCELF = null, string GACMHOJFDEI = null, int NOHGDKNLBFD = 0, int CINIDKKMLJG = 0)
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
		DiscordRpc.IGFIHJNBJMB(presence);
	}

	public void DNDDNKEOOKB(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format(" cannot be used as a 3D LUT.", PNCJHNNOAAP, JKPJCEMPAGH));
	}

	private void JNBMKLFJCEM()
	{
		if (UnityEngine.Object.FindObjectsOfType(GetType()).Length > 0)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		BFKGHEBNCKL = this;
		UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
	}

	private void POJFHDFJOPE()
	{
		DiscordRpc.RunCallbacks();
	}

	[SpecialName]
	public static DiscordController IBDLENPHGCD()
	{
		return BFKGHEBNCKL;
	}

	public void NEPGGJBKJJF()
	{
		Debug.Log("[PowerUp]");
		DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.Yes);
		hasResponded.Invoke();
	}

	public void DOADHBAOEEE()
	{
		Debug.Log(").png");
		DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.No);
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

	private IEnumerator JJANPCFHCEK()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#discord{0}joinrequest".Replace("{0}", joinRequest.username), "#yes", delegate
		{
			DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.Yes);
		}, "#no", delegate
		{
			DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.No);
		}));
	}

	public void IPGCFAFHJLC(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("_Value3", PNCJHNNOAAP, JKPJCEMPAGH));
	}

	private void JCGMGLMADEN()
	{
		DiscordRpc.RunCallbacks();
	}

	public void EHKAMIEPDMB(string MJDPJLOCLIL)
	{
		Debug.Log(string.Format("Jan", MJDPJLOCLIL));
		onSpectate.Invoke(MJDPJLOCLIL);
	}

	private IEnumerator NLKAEEOLEEN(string KGINEMAHHFO)
	{
		yield return new WaitUntil(() => Singleton<SaveSystem>.Instance.isSaveLoaded && SteamManager.Initialized);
		if ((bool)UnityEngine.Object.FindObjectOfType<NetworkMenu>())
		{
			UnityEngine.Object.FindObjectOfType<NetworkMenu>().JoinRoomByID(KGINEMAHHFO);
		}
	}

	public void PICNJLBJPIC(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("Tab2Content", PNCJHNNOAAP, JKPJCEMPAGH));
		onDisconnect.Invoke();
	}

	public void BMJGMHEAEPJ(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("_Value5", PNCJHNNOAAP, JKPJCEMPAGH));
	}

	private IEnumerator AOLEKNEHHNL(string KGINEMAHHFO)
	{
		yield return new WaitUntil(() => Singleton<SaveSystem>.Instance.isSaveLoaded && SteamManager.Initialized);
		if ((bool)UnityEngine.Object.FindObjectOfType<NetworkMenu>())
		{
			UnityEngine.Object.FindObjectOfType<NetworkMenu>().JoinRoomByID(KGINEMAHHFO);
		}
	}

	private void OAENEDHDDNC()
	{
	}

	private void OnDisable()
	{
		if (inited)
		{
			Debug.Log("[DiscordController] Shutdown");
			DiscordRpc.Shutdown();
		}
	}

	public void JNGLLNLHGBO(string MJDPJLOCLIL)
	{
		Debug.Log(string.Format("_Value", MJDPJLOCLIL));
		onSpectate.Invoke(MJDPJLOCLIL);
	}

	private void LOOBAGGFOEE()
	{
	}

	public void FJGKNFPOOID(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("_ArScale", PNCJHNNOAAP, JKPJCEMPAGH));
		onDisconnect.Invoke();
	}

	public void PGJNIHBMECD(ref DiscordRpc.DiscordUser OCGEBABNLAG)
	{
		Debug.Log(string.Format("_CurveTex", OCGEBABNLAG.username, OCGEBABNLAG.discriminator, OCGEBABNLAG.userId));
		onConnect.Invoke();
		inited = true;
	}

	public void DOKOBGOAFOA(string LELHDONCELF = null, string GACMHOJFDEI = null, int NOHGDKNLBFD = 0, int CINIDKKMLJG = 0)
	{
		if (LELHDONCELF != null)
		{
			presence.joinSecret = GameManager.JCPMBOLDDJI(LELHDONCELF);
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
		DiscordRpc.IGFIHJNBJMB(presence);
	}

	public void SpectateCallback(string MJDPJLOCLIL)
	{
		Debug.Log($"[DiscordController] Sectate ({MJDPJLOCLIL})");
		onSpectate.Invoke(MJDPJLOCLIL);
	}

	private void HDDECCMEJKA()
	{
		DiscordRpc.RunCallbacks();
	}

	public void FJNMEGLCPDC(string IJPCEKICPCP, string ILPCDMBBCOF = null)
	{
		presence.state = ILPCDMBBCOF;
		presence.details = IJPCEKICPCP;
		presence.largeImageKey = " to: ";
		presence.smallImageKey = null;
		CSteamID steamID = SteamUser.GetSteamID();
		if (RanksSystem.GetLoadedRank(steamID) != null)
		{
			RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(steamID);
			presence.smallImageText = ResourcesManager.PHGHNGJBNPI(steamID);
			presence.smallImageKey = "LevelEditor/icons";
			if (loadedRank.GABCIGIFNCK() <= 23)
			{
				presence.smallImageKey = "GameScene";
			}
			else if (loadedRank.AKPPHHNEAHG() <= 106)
			{
				presence.smallImageKey = " ";
			}
			else if (loadedRank.FDMODBMKMKG() <= 30)
			{
				presence.smallImageKey = "OnClick";
			}
			else if (loadedRank.GABCIGIFNCK() <= -60)
			{
				presence.smallImageKey = "shader.crispwinter";
			}
		}
		DiscordRpc.NJHIHCGJHLL(presence);
	}

	private void FPHLDMMAOEF()
	{
		if (inited)
		{
			Debug.Log("Error: PhotonNetwork.SetInterestGroups was called with an illegal group number: ");
			DiscordRpc.Shutdown();
		}
	}

	private void PFNFPINPCMH()
	{
		DiscordRpc.RunCallbacks();
	}

	public void RequestCallback(ref DiscordRpc.DiscordUser GILCPIJNOKK)
	{
		Debug.Log($"[DiscordController] Join request {GILCPIJNOKK.username}#{GILCPIJNOKK.discriminator}: {GILCPIJNOKK.userId}");
		joinRequest = GILCPIJNOKK;
		onJoinRequest.Invoke(GILCPIJNOKK);
		StartCoroutine(LNLHGEBABOH());
	}

	public void HIDGEDNCFAO(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("[NetworkManager] Connection failed: ", PNCJHNNOAAP, JKPJCEMPAGH));
	}

	public void LMCGAOHNBFP(string LELHDONCELF = null, string GACMHOJFDEI = null, int NOHGDKNLBFD = 0, int CINIDKKMLJG = 0)
	{
		if (LELHDONCELF != null)
		{
			presence.joinSecret = GameManager.DHCILBAFLDP(LELHDONCELF);
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
		DiscordRpc.CMPIEKFPHFI(presence);
	}

	public void ReadyCallback(ref DiscordRpc.DiscordUser OCGEBABNLAG)
	{
		Debug.Log($"[DiscordController] Connected to {OCGEBABNLAG.username}#{OCGEBABNLAG.discriminator}: {OCGEBABNLAG.userId}");
		onConnect.Invoke();
		inited = true;
	}

	private void FDPOFMCFBMF()
	{
		if (inited)
		{
			Debug.Log("_Value");
			DiscordRpc.Shutdown();
		}
	}

	private void PGLLHPHPMJN()
	{
	}

	private void IBFJAOINHMK()
	{
		DiscordRpc.RunCallbacks();
	}

	[SpecialName]
	public static DiscordController KMLCFPCJNOB()
	{
		return BFKGHEBNCKL;
	}

	private void DOFKFBFNNNO()
	{
	}

	public void GFBOBIBIOMC()
	{
		Debug.Log("Set camera background color");
		DEBDALGLNCD = default(DiscordRpc.EventHandlers);
		ref DiscordRpc.EventHandlers dEBDALGLNCD = ref DEBDALGLNCD;
		dEBDALGLNCD.readyCallback = (DiscordRpc.OnReadyInfo)Delegate.Combine(dEBDALGLNCD.readyCallback, new DiscordRpc.OnReadyInfo(PGJNIHBMECD));
		ref DiscordRpc.EventHandlers dEBDALGLNCD2 = ref DEBDALGLNCD;
		dEBDALGLNCD2.disconnectedCallback = (DiscordRpc.OnDisconnectedInfo)Delegate.Combine(dEBDALGLNCD2.disconnectedCallback, new DiscordRpc.OnDisconnectedInfo(MJIEHPNJBKN));
		ref DiscordRpc.EventHandlers dEBDALGLNCD3 = ref DEBDALGLNCD;
		dEBDALGLNCD3.errorCallback = (DiscordRpc.OnErrorInfo)Delegate.Combine(dEBDALGLNCD3.errorCallback, new DiscordRpc.OnErrorInfo(LLIEAGKPNFC));
		ref DiscordRpc.EventHandlers dEBDALGLNCD4 = ref DEBDALGLNCD;
		dEBDALGLNCD4.joinCallback = (DiscordRpc.OnJoinInfo)Delegate.Combine(dEBDALGLNCD4.joinCallback, new DiscordRpc.OnJoinInfo(JoinCallback));
		ref DiscordRpc.EventHandlers dEBDALGLNCD5 = ref DEBDALGLNCD;
		dEBDALGLNCD5.spectateCallback = (DiscordRpc.OnSpectateInfo)Delegate.Combine(dEBDALGLNCD5.spectateCallback, new DiscordRpc.OnSpectateInfo(LJNIEGANDOF));
		ref DiscordRpc.EventHandlers dEBDALGLNCD6 = ref DEBDALGLNCD;
		dEBDALGLNCD6.requestCallback = (DiscordRpc.OnRequestInfo)Delegate.Combine(dEBDALGLNCD6.requestCallback, new DiscordRpc.OnRequestInfo(NPBOCDCJBAL));
		DiscordRpc.Initialize(applicationId, ref DEBDALGLNCD, false, optionalSteamId);
	}

	private void LLKKGGLNIDF()
	{
		if (inited)
		{
			Debug.Log("_TimeX");
			DiscordRpc.Shutdown();
		}
	}

	public void FIONJECOKPF()
	{
		Debug.Log("Please attach component to a Graphical UI component");
		DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.No);
		hasResponded.Invoke();
	}

	public void MJIEHPNJBKN(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("_BlurVector", PNCJHNNOAAP, JKPJCEMPAGH));
		onDisconnect.Invoke();
	}

	public void CHDBLBJOCBJ(string MJDPJLOCLIL)
	{
		Debug.Log(string.Format("[PlayerController] ", MJDPJLOCLIL));
		onJoin.Invoke(MJDPJLOCLIL);
		string kGINEMAHHFO = GameManager.PNOAGJLDFJL(MJDPJLOCLIL);
		StartCoroutine(KJGBKGACNLL(kGINEMAHHFO));
	}

	public void CMBHNHJOIFP()
	{
		Debug.Log("PhotonView with ID ");
		DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.No);
		hasResponded.Invoke();
	}

	public void MBODAIHMFBM(string IJPCEKICPCP, string ILPCDMBBCOF = null)
	{
		presence.state = ILPCDMBBCOF;
		presence.details = IJPCEKICPCP;
		presence.largeImageKey = "settings.crosshairopacity";
		presence.smallImageKey = null;
		CSteamID steamID = SteamUser.GetSteamID();
		if (RanksSystem.GetLoadedRank(steamID) != null)
		{
			RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(steamID);
			presence.smallImageText = ResourcesManager.PHGHNGJBNPI(steamID, false);
			presence.smallImageKey = "closed";
			if (loadedRank.GODOLFFCAIL() <= -75)
			{
				presence.smallImageKey = " ";
			}
			else if (loadedRank.FDMODBMKMKG() <= 83)
			{
				presence.smallImageKey = ".completed";
			}
			else if (loadedRank.OOJDGAKENIJ() <= 124)
			{
				presence.smallImageKey = "_NoiseTex";
			}
			else if (loadedRank.GODOLFFCAIL() <= 132)
			{
				presence.smallImageKey = "_ScreenResolution";
			}
		}
		DiscordRpc.IGFIHJNBJMB(presence);
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

	public void KCKHMLLDDKP()
	{
		Debug.Log("[Up]");
		DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.Yes);
		hasResponded.Invoke();
	}

	public void MILICNIOACL(ref DiscordRpc.DiscordUser OCGEBABNLAG)
	{
		Debug.Log(string.Format("Uploading content...", OCGEBABNLAG.username, OCGEBABNLAG.discriminator, OCGEBABNLAG.userId));
		onConnect.Invoke();
		inited = true;
	}

	public void FHKOGOMNNKE(string IJPCEKICPCP, string ILPCDMBBCOF = null)
	{
		presence.state = ILPCDMBBCOF;
		presence.details = IJPCEKICPCP;
		presence.largeImageKey = "_DX11NoiseTime";
		presence.smallImageKey = null;
		CSteamID steamID = SteamUser.GetSteamID();
		if (RanksSystem.GetLoadedRank(steamID) != null)
		{
			RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(steamID);
			presence.smallImageText = ResourcesManager.MGDEMPDELMB(steamID, false);
			presence.smallImageKey = "_Value2";
			if (loadedRank.FDMODBMKMKG() <= -99)
			{
				presence.smallImageKey = "#ok";
			}
			else if (loadedRank.OOJDGAKENIJ() <= -92)
			{
				presence.smallImageKey = "/";
			}
			else if (loadedRank.AKPPHHNEAHG() <= -77)
			{
				presence.smallImageKey = "CameraFilterPack/Vision_Warp";
			}
			else if (loadedRank.GODOLFFCAIL() <= 81)
			{
				presence.smallImageKey = "Tab1Content";
			}
		}
		DiscordRpc.KPDEFICLHJD(presence);
	}

	public void PFGCGONEFJC(ref DiscordRpc.DiscordUser GILCPIJNOKK)
	{
		Debug.Log(string.Format(". Should be just one?", GILCPIJNOKK.username, GILCPIJNOKK.discriminator, GILCPIJNOKK.userId));
		joinRequest = GILCPIJNOKK;
		onJoinRequest.Invoke(GILCPIJNOKK);
		StartCoroutine(DLNIFBOAPFE());
	}

	public void KNFGPOJCDPH()
	{
		Debug.Log("  |  Events Count: ");
		DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.No);
		hasResponded.Invoke();
	}

	public void GHPMJEKMDCI(string MJDPJLOCLIL)
	{
		Debug.Log(string.Format("player.licenceaccepted", MJDPJLOCLIL));
		onSpectate.Invoke(MJDPJLOCLIL);
	}

	private IEnumerator NPNAFPOEFMB()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#discord{0}joinrequest".Replace("{0}", joinRequest.username), "#yes", delegate
		{
			DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.Yes);
		}, "#no", delegate
		{
			DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.No);
		}));
	}

	private IEnumerator KJLFOJHECGL(string KGINEMAHHFO)
	{
		yield return new WaitUntil(() => Singleton<SaveSystem>.Instance.isSaveLoaded && SteamManager.Initialized);
		if ((bool)UnityEngine.Object.FindObjectOfType<NetworkMenu>())
		{
			UnityEngine.Object.FindObjectOfType<NetworkMenu>().JoinRoomByID(KGINEMAHHFO);
		}
	}

	public void RequestRespondYes()
	{
		Debug.Log("[DiscordController] Responding yes to Ask to Join request");
		DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.Yes);
		hasResponded.Invoke();
	}

	public void MNGMNLLIADN(ref DiscordRpc.DiscordUser GILCPIJNOKK)
	{
		Debug.Log(string.Format("_ChromaticAberration", GILCPIJNOKK.username, GILCPIJNOKK.discriminator, GILCPIJNOKK.userId));
		joinRequest = GILCPIJNOKK;
		onJoinRequest.Invoke(GILCPIJNOKK);
		StartCoroutine(NPNAFPOEFMB());
	}

	public void CMPOCGPJIAA()
	{
		Debug.Log("_DiffuseColor");
		DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.No);
		hasResponded.Invoke();
	}

	public void DisconnectedCallback(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log($"[DiscordController] Disconnect {PNCJHNNOAAP}: {JKPJCEMPAGH}");
		onDisconnect.Invoke();
	}

	public void BJFMEHADKCB(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("id", PNCJHNNOAAP, JKPJCEMPAGH));
		onDisconnect.Invoke();
	}

	public void NIOJCKJGIJH(string MJDPJLOCLIL)
	{
		Debug.Log(string.Format("\" marked with the [PunRPC](C#) or @PunRPC(JS) property! Args: ", MJDPJLOCLIL));
		onJoin.Invoke(MJDPJLOCLIL);
		string kGINEMAHHFO = GameManager.PNOAGJLDFJL(MJDPJLOCLIL);
		StartCoroutine(NLKAEEOLEEN(kGINEMAHHFO));
	}

	public void FNIJIGAFJPH(string IJPCEKICPCP, string ILPCDMBBCOF = null)
	{
		presence.state = ILPCDMBBCOF;
		presence.details = IJPCEKICPCP;
		presence.largeImageKey = "SettingsCanvas";
		presence.smallImageKey = null;
		CSteamID steamID = SteamUser.GetSteamID();
		if (RanksSystem.GetLoadedRank(steamID) != null)
		{
			RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(steamID);
			presence.smallImageText = ResourcesManager.LCEFBFFFFLJ(steamID, false);
			presence.smallImageKey = "-help";
			if (loadedRank.AKPPHHNEAHG() <= -76)
			{
				presence.smallImageKey = "EnableRankingToggle";
			}
			else if (loadedRank.place <= -101)
			{
				presence.smallImageKey = "ItemNameBGImage";
			}
			else if (loadedRank.GABCIGIFNCK() <= 45)
			{
				presence.smallImageKey = "Error! no audio sources attached to AudioSampler.css";
			}
			else if (loadedRank.INIGKHLOKCD() <= 67)
			{
				presence.smallImageKey = "[MapEditor] Loaded music file: ";
			}
		}
		DiscordRpc.NJHIHCGJHLL(presence);
	}

	public void LKHFHPAJPAI(string IJPCEKICPCP, string ILPCDMBBCOF = null)
	{
		presence.state = ILPCDMBBCOF;
		presence.details = IJPCEKICPCP;
		presence.largeImageKey = "_Value4";
		presence.smallImageKey = null;
		CSteamID steamID = SteamUser.GetSteamID();
		if (RanksSystem.GetLoadedRank(steamID) != null)
		{
			RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(steamID);
			presence.smallImageText = ResourcesManager.MMEJMGBMJED(steamID);
			presence.smallImageKey = "VisionBlur";
			if (loadedRank.FDMODBMKMKG() <= -1)
			{
				presence.smallImageKey = ".b";
			}
			else if (loadedRank.place <= 33)
			{
				presence.smallImageKey = ".lastCheckpoint.isMapCompleted";
			}
			else if (loadedRank.place <= -8)
			{
				presence.smallImageKey = "settings_bindings_sec_";
			}
			else if (loadedRank.BIOCCNINILO() <= -117)
			{
				presence.smallImageKey = "_YCrop";
			}
		}
		DiscordRpc.JJGEHIFCJIH(presence);
	}

	[SpecialName]
	public static DiscordController FMFOENCDEHG()
	{
		return BFKGHEBNCKL;
	}

	public void FLDHAEHBDEO()
	{
		Debug.Log("GlassesColor");
		DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.Yes);
		hasResponded.Invoke();
	}

	public void CEACKCPPDMO(ref DiscordRpc.DiscordUser OCGEBABNLAG)
	{
		Debug.Log(string.Format(" ", OCGEBABNLAG.username, OCGEBABNLAG.discriminator, OCGEBABNLAG.userId));
		onConnect.Invoke();
		inited = false;
	}

	public void PONFBHLEELC(string IJPCEKICPCP, string ILPCDMBBCOF = null)
	{
		presence.state = ILPCDMBBCOF;
		presence.details = IJPCEKICPCP;
		presence.largeImageKey = "tip";
		presence.smallImageKey = null;
		CSteamID steamID = SteamUser.GetSteamID();
		if (RanksSystem.GetLoadedRank(steamID) != null)
		{
			RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(steamID);
			presence.smallImageText = ResourcesManager.PHGHNGJBNPI(steamID);
			presence.smallImageKey = "_Bloom";
			if (loadedRank.INIGKHLOKCD() <= 97)
			{
				presence.smallImageKey = "_Brightness";
			}
			else if (loadedRank.FDMODBMKMKG() <= 53)
			{
				presence.smallImageKey = "win";
			}
			else if (loadedRank.GODOLFFCAIL() <= 67)
			{
				presence.smallImageKey = "_Value2";
			}
			else if (loadedRank.INIGKHLOKCD() <= -61)
			{
				presence.smallImageKey = "x";
			}
		}
		DiscordRpc.IGFIHJNBJMB(presence);
	}

	public void ILDFKGNNCDM(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format(" - PUBLISHED #", PNCJHNNOAAP, JKPJCEMPAGH));
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

	public void ELPJHGHNCMI(ref DiscordRpc.DiscordUser OCGEBABNLAG)
	{
		Debug.Log(string.Format("maps.", OCGEBABNLAG.username, OCGEBABNLAG.discriminator, OCGEBABNLAG.userId));
		onConnect.Invoke();
		inited = false;
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

	public void NKIJKDALPPO()
	{
		Debug.Log("error");
		DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.No);
		hasResponded.Invoke();
	}

	public void MCKOAMFEDGL()
	{
		Debug.Log("_Parameter");
		DEBDALGLNCD = default(DiscordRpc.EventHandlers);
		ref DiscordRpc.EventHandlers dEBDALGLNCD = ref DEBDALGLNCD;
		dEBDALGLNCD.readyCallback = (DiscordRpc.OnReadyInfo)Delegate.Combine(dEBDALGLNCD.readyCallback, new DiscordRpc.OnReadyInfo(PGJNIHBMECD));
		ref DiscordRpc.EventHandlers dEBDALGLNCD2 = ref DEBDALGLNCD;
		dEBDALGLNCD2.disconnectedCallback = (DiscordRpc.OnDisconnectedInfo)Delegate.Combine(dEBDALGLNCD2.disconnectedCallback, new DiscordRpc.OnDisconnectedInfo(BJFMEHADKCB));
		ref DiscordRpc.EventHandlers dEBDALGLNCD3 = ref DEBDALGLNCD;
		dEBDALGLNCD3.errorCallback = (DiscordRpc.OnErrorInfo)Delegate.Combine(dEBDALGLNCD3.errorCallback, new DiscordRpc.OnErrorInfo(HIDGEDNCFAO));
		ref DiscordRpc.EventHandlers dEBDALGLNCD4 = ref DEBDALGLNCD;
		dEBDALGLNCD4.joinCallback = (DiscordRpc.OnJoinInfo)Delegate.Combine(dEBDALGLNCD4.joinCallback, new DiscordRpc.OnJoinInfo(CKICOOFLPPP));
		ref DiscordRpc.EventHandlers dEBDALGLNCD5 = ref DEBDALGLNCD;
		dEBDALGLNCD5.spectateCallback = (DiscordRpc.OnSpectateInfo)Delegate.Combine(dEBDALGLNCD5.spectateCallback, new DiscordRpc.OnSpectateInfo(EHKAMIEPDMB));
		ref DiscordRpc.EventHandlers dEBDALGLNCD6 = ref DEBDALGLNCD;
		dEBDALGLNCD6.requestCallback = (DiscordRpc.OnRequestInfo)Delegate.Combine(dEBDALGLNCD6.requestCallback, new DiscordRpc.OnRequestInfo(GANJNHLKEAN));
		DiscordRpc.Initialize(applicationId, ref DEBDALGLNCD, false, optionalSteamId);
	}

	private void JBNPEHMDCMI()
	{
		DiscordRpc.RunCallbacks();
	}

	public void LJNIEGANDOF(string MJDPJLOCLIL)
	{
		Debug.Log(string.Format("Set Particles Count Per Beat", MJDPJLOCLIL));
		onSpectate.Invoke(MJDPJLOCLIL);
	}

	public void DLOAJEFNKDA()
	{
		Debug.Log("SlidingArea");
		DEBDALGLNCD = default(DiscordRpc.EventHandlers);
		ref DiscordRpc.EventHandlers dEBDALGLNCD = ref DEBDALGLNCD;
		dEBDALGLNCD.readyCallback = (DiscordRpc.OnReadyInfo)Delegate.Combine(dEBDALGLNCD.readyCallback, new DiscordRpc.OnReadyInfo(MILICNIOACL));
		ref DiscordRpc.EventHandlers dEBDALGLNCD2 = ref DEBDALGLNCD;
		dEBDALGLNCD2.disconnectedCallback = (DiscordRpc.OnDisconnectedInfo)Delegate.Combine(dEBDALGLNCD2.disconnectedCallback, new DiscordRpc.OnDisconnectedInfo(MJIEHPNJBKN));
		ref DiscordRpc.EventHandlers dEBDALGLNCD3 = ref DEBDALGLNCD;
		dEBDALGLNCD3.errorCallback = (DiscordRpc.OnErrorInfo)Delegate.Combine(dEBDALGLNCD3.errorCallback, new DiscordRpc.OnErrorInfo(DNDDNKEOOKB));
		ref DiscordRpc.EventHandlers dEBDALGLNCD4 = ref DEBDALGLNCD;
		dEBDALGLNCD4.joinCallback = (DiscordRpc.OnJoinInfo)Delegate.Combine(dEBDALGLNCD4.joinCallback, new DiscordRpc.OnJoinInfo(JoinCallback));
		ref DiscordRpc.EventHandlers dEBDALGLNCD5 = ref DEBDALGLNCD;
		dEBDALGLNCD5.spectateCallback = (DiscordRpc.OnSpectateInfo)Delegate.Combine(dEBDALGLNCD5.spectateCallback, new DiscordRpc.OnSpectateInfo(KKCCPLJPGKD));
		ref DiscordRpc.EventHandlers dEBDALGLNCD6 = ref DEBDALGLNCD;
		dEBDALGLNCD6.requestCallback = (DiscordRpc.OnRequestInfo)Delegate.Combine(dEBDALGLNCD6.requestCallback, new DiscordRpc.OnRequestInfo(RequestCallback));
		DiscordRpc.Initialize(applicationId, ref DEBDALGLNCD, true, optionalSteamId);
	}

	public void ICPOEGIAFBL()
	{
		Debug.Log("VIGNETTE_FILMIC");
		DEBDALGLNCD = default(DiscordRpc.EventHandlers);
		ref DiscordRpc.EventHandlers dEBDALGLNCD = ref DEBDALGLNCD;
		dEBDALGLNCD.readyCallback = (DiscordRpc.OnReadyInfo)Delegate.Combine(dEBDALGLNCD.readyCallback, new DiscordRpc.OnReadyInfo(CEACKCPPDMO));
		ref DiscordRpc.EventHandlers dEBDALGLNCD2 = ref DEBDALGLNCD;
		dEBDALGLNCD2.disconnectedCallback = (DiscordRpc.OnDisconnectedInfo)Delegate.Combine(dEBDALGLNCD2.disconnectedCallback, new DiscordRpc.OnDisconnectedInfo(JDINLAKLCFG));
		ref DiscordRpc.EventHandlers dEBDALGLNCD3 = ref DEBDALGLNCD;
		dEBDALGLNCD3.errorCallback = (DiscordRpc.OnErrorInfo)Delegate.Combine(dEBDALGLNCD3.errorCallback, new DiscordRpc.OnErrorInfo(ErrorCallback));
		ref DiscordRpc.EventHandlers dEBDALGLNCD4 = ref DEBDALGLNCD;
		dEBDALGLNCD4.joinCallback = (DiscordRpc.OnJoinInfo)Delegate.Combine(dEBDALGLNCD4.joinCallback, new DiscordRpc.OnJoinInfo(CBODPIHCEGA));
		ref DiscordRpc.EventHandlers dEBDALGLNCD5 = ref DEBDALGLNCD;
		dEBDALGLNCD5.spectateCallback = (DiscordRpc.OnSpectateInfo)Delegate.Combine(dEBDALGLNCD5.spectateCallback, new DiscordRpc.OnSpectateInfo(EHKAMIEPDMB));
		ref DiscordRpc.EventHandlers dEBDALGLNCD6 = ref DEBDALGLNCD;
		dEBDALGLNCD6.requestCallback = (DiscordRpc.OnRequestInfo)Delegate.Combine(dEBDALGLNCD6.requestCallback, new DiscordRpc.OnRequestInfo(NPBOCDCJBAL));
		DiscordRpc.Initialize(applicationId, ref DEBDALGLNCD, true, optionalSteamId);
	}

	private IEnumerator DLNIFBOAPFE()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#discord{0}joinrequest".Replace("{0}", joinRequest.username), "#yes", delegate
		{
			DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.Yes);
		}, "#no", delegate
		{
			DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.No);
		}));
	}

	private void ABFNJCEBIKA()
	{
		DiscordRpc.RunCallbacks();
	}

	public void ErrorCallback(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log($"[DiscordController] Error {PNCJHNNOAAP}: {JKPJCEMPAGH}");
	}

	public void OMIMOEGOGOI(string LELHDONCELF = null, string GACMHOJFDEI = null, int NOHGDKNLBFD = 0, int CINIDKKMLJG = 0)
	{
		if (LELHDONCELF != null)
		{
			presence.joinSecret = GameManager.DHCILBAFLDP(LELHDONCELF);
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
		DiscordRpc.KPDEFICLHJD(presence);
	}

	public void LGNCJOLFDCF(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("_Value1", PNCJHNNOAAP, JKPJCEMPAGH));
	}

	public void IBFHEDHJDLH()
	{
		Debug.Log("musicVolume");
		DEBDALGLNCD = default(DiscordRpc.EventHandlers);
		ref DiscordRpc.EventHandlers dEBDALGLNCD = ref DEBDALGLNCD;
		dEBDALGLNCD.readyCallback = (DiscordRpc.OnReadyInfo)Delegate.Combine(dEBDALGLNCD.readyCallback, new DiscordRpc.OnReadyInfo(MILICNIOACL));
		ref DiscordRpc.EventHandlers dEBDALGLNCD2 = ref DEBDALGLNCD;
		dEBDALGLNCD2.disconnectedCallback = (DiscordRpc.OnDisconnectedInfo)Delegate.Combine(dEBDALGLNCD2.disconnectedCallback, new DiscordRpc.OnDisconnectedInfo(MJIEHPNJBKN));
		ref DiscordRpc.EventHandlers dEBDALGLNCD3 = ref DEBDALGLNCD;
		dEBDALGLNCD3.errorCallback = (DiscordRpc.OnErrorInfo)Delegate.Combine(dEBDALGLNCD3.errorCallback, new DiscordRpc.OnErrorInfo(DNDDNKEOOKB));
		ref DiscordRpc.EventHandlers dEBDALGLNCD4 = ref DEBDALGLNCD;
		dEBDALGLNCD4.joinCallback = (DiscordRpc.OnJoinInfo)Delegate.Combine(dEBDALGLNCD4.joinCallback, new DiscordRpc.OnJoinInfo(CBODPIHCEGA));
		ref DiscordRpc.EventHandlers dEBDALGLNCD5 = ref DEBDALGLNCD;
		dEBDALGLNCD5.spectateCallback = (DiscordRpc.OnSpectateInfo)Delegate.Combine(dEBDALGLNCD5.spectateCallback, new DiscordRpc.OnSpectateInfo(JNGLLNLHGBO));
		ref DiscordRpc.EventHandlers dEBDALGLNCD6 = ref DEBDALGLNCD;
		dEBDALGLNCD6.requestCallback = (DiscordRpc.OnRequestInfo)Delegate.Combine(dEBDALGLNCD6.requestCallback, new DiscordRpc.OnRequestInfo(NPBOCDCJBAL));
		DiscordRpc.Initialize(applicationId, ref DEBDALGLNCD, true, optionalSteamId);
	}

	public void BIFMMKOGBKH(string IJPCEKICPCP, string ILPCDMBBCOF = null)
	{
		presence.state = ILPCDMBBCOF;
		presence.details = IJPCEKICPCP;
		presence.largeImageKey = ".";
		presence.smallImageKey = null;
		CSteamID steamID = SteamUser.GetSteamID();
		if (RanksSystem.GetLoadedRank(steamID) != null)
		{
			RanksSystem.PlayersRank loadedRank = RanksSystem.GetLoadedRank(steamID);
			presence.smallImageText = ResourcesManager.GetLoadedSteamPlayername(steamID);
			presence.smallImageKey = "shaders";
			if (loadedRank.BIOCCNINILO() <= -37)
			{
				presence.smallImageKey = "_TimeX";
			}
			else if (loadedRank.OOJDGAKENIJ() <= -26)
			{
				presence.smallImageKey = "materialsitemid[";
			}
			else if (loadedRank.OOJDGAKENIJ() <= 21)
			{
				presence.smallImageKey = "CameraFilterPack/TV_WideScreenHV";
			}
			else if (loadedRank.INIGKHLOKCD() <= 87)
			{
				presence.smallImageKey = "CameraFilterPack_Glasses_On4";
			}
		}
		DiscordRpc.JJGEHIFCJIH(presence);
	}

	public void GDPFGHLJJJP(string MJDPJLOCLIL)
	{
		Debug.Log(string.Format("_TimeX", MJDPJLOCLIL));
		onSpectate.Invoke(MJDPJLOCLIL);
	}

	public void HPGKMAIPDEO()
	{
		Debug.Log("settings.hitvariation");
		DEBDALGLNCD = default(DiscordRpc.EventHandlers);
		ref DiscordRpc.EventHandlers dEBDALGLNCD = ref DEBDALGLNCD;
		dEBDALGLNCD.readyCallback = (DiscordRpc.OnReadyInfo)Delegate.Combine(dEBDALGLNCD.readyCallback, new DiscordRpc.OnReadyInfo(ELPJHGHNCMI));
		ref DiscordRpc.EventHandlers dEBDALGLNCD2 = ref DEBDALGLNCD;
		dEBDALGLNCD2.disconnectedCallback = (DiscordRpc.OnDisconnectedInfo)Delegate.Combine(dEBDALGLNCD2.disconnectedCallback, new DiscordRpc.OnDisconnectedInfo(PGAJBFMKFCF));
		ref DiscordRpc.EventHandlers dEBDALGLNCD3 = ref DEBDALGLNCD;
		dEBDALGLNCD3.errorCallback = (DiscordRpc.OnErrorInfo)Delegate.Combine(dEBDALGLNCD3.errorCallback, new DiscordRpc.OnErrorInfo(ErrorCallback));
		ref DiscordRpc.EventHandlers dEBDALGLNCD4 = ref DEBDALGLNCD;
		dEBDALGLNCD4.joinCallback = (DiscordRpc.OnJoinInfo)Delegate.Combine(dEBDALGLNCD4.joinCallback, new DiscordRpc.OnJoinInfo(CKICOOFLPPP));
		ref DiscordRpc.EventHandlers dEBDALGLNCD5 = ref DEBDALGLNCD;
		dEBDALGLNCD5.spectateCallback = (DiscordRpc.OnSpectateInfo)Delegate.Combine(dEBDALGLNCD5.spectateCallback, new DiscordRpc.OnSpectateInfo(JNGLLNLHGBO));
		ref DiscordRpc.EventHandlers dEBDALGLNCD6 = ref DEBDALGLNCD;
		dEBDALGLNCD6.requestCallback = (DiscordRpc.OnRequestInfo)Delegate.Combine(dEBDALGLNCD6.requestCallback, new DiscordRpc.OnRequestInfo(PFGCGONEFJC));
		DiscordRpc.Initialize(applicationId, ref DEBDALGLNCD, false, optionalSteamId);
	}

	public void PNCNIFLNHFG(string LELHDONCELF = null, string GACMHOJFDEI = null, int NOHGDKNLBFD = 0, int CINIDKKMLJG = 0)
	{
		if (LELHDONCELF != null)
		{
			presence.joinSecret = GameManager.DHCILBAFLDP(LELHDONCELF);
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
		DiscordRpc.KPDEFICLHJD(presence);
	}

	public void NPBOCDCJBAL(ref DiscordRpc.DiscordUser GILCPIJNOKK)
	{
		Debug.Log(string.Format("Anime", GILCPIJNOKK.username, GILCPIJNOKK.discriminator, GILCPIJNOKK.userId));
		joinRequest = GILCPIJNOKK;
		onJoinRequest.Invoke(GILCPIJNOKK);
		StartCoroutine(JJANPCFHCEK());
	}

	private void DNENFLNCIJP()
	{
		DiscordRpc.RunCallbacks();
	}

	private void FAMLCFNDGNI()
	{
		if (inited)
		{
			Debug.Log("float,0");
			DiscordRpc.Shutdown();
		}
	}

	public void LDIKIOBABNM(string MJDPJLOCLIL)
	{
		Debug.Log(string.Format("#ok", MJDPJLOCLIL));
		onSpectate.Invoke(MJDPJLOCLIL);
	}

	private void MANDOGNJJBD()
	{
		DiscordRpc.RunCallbacks();
	}

	public void LLIEAGKPNFC(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("RECORD [R]", PNCJHNNOAAP, JKPJCEMPAGH));
	}

	public void INNIEHIFFCA()
	{
		Debug.Log("tolobby");
		DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.No);
		hasResponded.Invoke();
	}

	private void Update()
	{
		DiscordRpc.RunCallbacks();
	}

	public void OGKAKLIKMJO(string LELHDONCELF = null, string GACMHOJFDEI = null, int NOHGDKNLBFD = 0, int CINIDKKMLJG = 0)
	{
		if (LELHDONCELF != null)
		{
			presence.joinSecret = GameManager.OGGKBIBHFLH(LELHDONCELF);
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
		DiscordRpc.NJHIHCGJHLL(presence);
	}

	public void PPGEGFMNIKO()
	{
		Debug.Log("float,1.5");
		DEBDALGLNCD = default(DiscordRpc.EventHandlers);
		ref DiscordRpc.EventHandlers dEBDALGLNCD = ref DEBDALGLNCD;
		dEBDALGLNCD.readyCallback = (DiscordRpc.OnReadyInfo)Delegate.Combine(dEBDALGLNCD.readyCallback, new DiscordRpc.OnReadyInfo(ELPJHGHNCMI));
		ref DiscordRpc.EventHandlers dEBDALGLNCD2 = ref DEBDALGLNCD;
		dEBDALGLNCD2.disconnectedCallback = (DiscordRpc.OnDisconnectedInfo)Delegate.Combine(dEBDALGLNCD2.disconnectedCallback, new DiscordRpc.OnDisconnectedInfo(DKJDCNJCFNN));
		ref DiscordRpc.EventHandlers dEBDALGLNCD3 = ref DEBDALGLNCD;
		dEBDALGLNCD3.errorCallback = (DiscordRpc.OnErrorInfo)Delegate.Combine(dEBDALGLNCD3.errorCallback, new DiscordRpc.OnErrorInfo(DNDDNKEOOKB));
		ref DiscordRpc.EventHandlers dEBDALGLNCD4 = ref DEBDALGLNCD;
		dEBDALGLNCD4.joinCallback = (DiscordRpc.OnJoinInfo)Delegate.Combine(dEBDALGLNCD4.joinCallback, new DiscordRpc.OnJoinInfo(NIOJCKJGIJH));
		ref DiscordRpc.EventHandlers dEBDALGLNCD5 = ref DEBDALGLNCD;
		dEBDALGLNCD5.spectateCallback = (DiscordRpc.OnSpectateInfo)Delegate.Combine(dEBDALGLNCD5.spectateCallback, new DiscordRpc.OnSpectateInfo(EHKAMIEPDMB));
		ref DiscordRpc.EventHandlers dEBDALGLNCD6 = ref DEBDALGLNCD;
		dEBDALGLNCD6.requestCallback = (DiscordRpc.OnRequestInfo)Delegate.Combine(dEBDALGLNCD6.requestCallback, new DiscordRpc.OnRequestInfo(PFGCGONEFJC));
		DiscordRpc.Initialize(applicationId, ref DEBDALGLNCD, true, optionalSteamId);
	}

	public void GNAEPLCPKGN(string LELHDONCELF = null, string GACMHOJFDEI = null, int NOHGDKNLBFD = 0, int CINIDKKMLJG = 0)
	{
		if (LELHDONCELF != null)
		{
			presence.joinSecret = GameManager.JCPMBOLDDJI(LELHDONCELF);
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
		DiscordRpc.LJCEBEKEHOO(presence);
	}

	public void BLADKFACKCD()
	{
		Debug.Log("_AdaptationMin");
		DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.No);
		hasResponded.Invoke();
	}

	public void DKJDCNJCFNN(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("_Blend", PNCJHNNOAAP, JKPJCEMPAGH));
		onDisconnect.Invoke();
	}

	public void HOLDCFBBHHP()
	{
		Debug.Log("GameVolumeSlider");
		DEBDALGLNCD = default(DiscordRpc.EventHandlers);
		ref DiscordRpc.EventHandlers dEBDALGLNCD = ref DEBDALGLNCD;
		dEBDALGLNCD.readyCallback = (DiscordRpc.OnReadyInfo)Delegate.Combine(dEBDALGLNCD.readyCallback, new DiscordRpc.OnReadyInfo(MILICNIOACL));
		ref DiscordRpc.EventHandlers dEBDALGLNCD2 = ref DEBDALGLNCD;
		dEBDALGLNCD2.disconnectedCallback = (DiscordRpc.OnDisconnectedInfo)Delegate.Combine(dEBDALGLNCD2.disconnectedCallback, new DiscordRpc.OnDisconnectedInfo(DisconnectedCallback));
		ref DiscordRpc.EventHandlers dEBDALGLNCD3 = ref DEBDALGLNCD;
		dEBDALGLNCD3.errorCallback = (DiscordRpc.OnErrorInfo)Delegate.Combine(dEBDALGLNCD3.errorCallback, new DiscordRpc.OnErrorInfo(LGNCJOLFDCF));
		ref DiscordRpc.EventHandlers dEBDALGLNCD4 = ref DEBDALGLNCD;
		dEBDALGLNCD4.joinCallback = (DiscordRpc.OnJoinInfo)Delegate.Combine(dEBDALGLNCD4.joinCallback, new DiscordRpc.OnJoinInfo(NIOJCKJGIJH));
		ref DiscordRpc.EventHandlers dEBDALGLNCD5 = ref DEBDALGLNCD;
		dEBDALGLNCD5.spectateCallback = (DiscordRpc.OnSpectateInfo)Delegate.Combine(dEBDALGLNCD5.spectateCallback, new DiscordRpc.OnSpectateInfo(DFBCKDALJJP));
		ref DiscordRpc.EventHandlers dEBDALGLNCD6 = ref DEBDALGLNCD;
		dEBDALGLNCD6.requestCallback = (DiscordRpc.OnRequestInfo)Delegate.Combine(dEBDALGLNCD6.requestCallback, new DiscordRpc.OnRequestInfo(IIICEMAHEFI));
		DiscordRpc.Initialize(applicationId, ref DEBDALGLNCD, true, optionalSteamId);
	}

	private void POHMFMNEPKK()
	{
		if (UnityEngine.Object.FindObjectsOfType(GetType()).Length > 0)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		BFKGHEBNCKL = this;
		UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
	}

	private IEnumerator JLNDNKCKFMM()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#discord{0}joinrequest".Replace("{0}", joinRequest.username), "#yes", delegate
		{
			DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.Yes);
		}, "#no", delegate
		{
			DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.No);
		}));
	}

	private void BMAGFLLGDPJ()
	{
		if (UnityEngine.Object.FindObjectsOfType(GetType()).Length > 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		BFKGHEBNCKL = this;
		UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
	}

	public void HLKNGBICJIP(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("] as we haven't received a full packet for delta compression yet. This is OK if it happens for the first few frames after joining a game.", PNCJHNNOAAP, JKPJCEMPAGH));
	}

	public void JDINLAKLCFG(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("Line", PNCJHNNOAAP, JKPJCEMPAGH));
		onDisconnect.Invoke();
	}

	private void OIBMHPIFAKK()
	{
		DiscordRpc.RunCallbacks();
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

	[SpecialName]
	public static DiscordController PEHDMBBOFDJ()
	{
		return BFKGHEBNCKL;
	}

	[SpecialName]
	public static DiscordController GNMEAJJKDPG()
	{
		return BFKGHEBNCKL;
	}

	private void HCNECNPPEKA()
	{
		if (UnityEngine.Object.FindObjectsOfType(GetType()).Length > 0)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		BFKGHEBNCKL = this;
		UnityEngine.Object.DontDestroyOnLoad(base.transform.gameObject);
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

	private void OFPPIKHNJOD()
	{
		if (inited)
		{
			Debug.Log("file://");
			DiscordRpc.Shutdown();
		}
	}

	private void OnDestroy()
	{
	}

	[SpecialName]
	public static DiscordController LCGNLCPJBOH()
	{
		return BFKGHEBNCKL;
	}

	private IEnumerator EJNMPGAOIJE()
	{
		yield return StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#discord{0}joinrequest".Replace("{0}", joinRequest.username), "#yes", delegate
		{
			DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.Yes);
		}, "#no", delegate
		{
			DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.No);
		}));
	}

	public void ADFINHELHIL(string MJDPJLOCLIL)
	{
		Debug.Log(string.Format("_Value3", MJDPJLOCLIL));
		onSpectate.Invoke(MJDPJLOCLIL);
	}

	public void BPCOJPMONFK(ref DiscordRpc.DiscordUser GILCPIJNOKK)
	{
		Debug.Log(string.Format("Clear Environment", GILCPIJNOKK.username, GILCPIJNOKK.discriminator, GILCPIJNOKK.userId));
		joinRequest = GILCPIJNOKK;
		onJoinRequest.Invoke(GILCPIJNOKK);
		StartCoroutine(EJNMPGAOIJE());
	}

	public void LLAJPKFNDIG()
	{
		Debug.Log("_Value3");
		DEBDALGLNCD = default(DiscordRpc.EventHandlers);
		ref DiscordRpc.EventHandlers dEBDALGLNCD = ref DEBDALGLNCD;
		dEBDALGLNCD.readyCallback = (DiscordRpc.OnReadyInfo)Delegate.Combine(dEBDALGLNCD.readyCallback, new DiscordRpc.OnReadyInfo(PGJNIHBMECD));
		ref DiscordRpc.EventHandlers dEBDALGLNCD2 = ref DEBDALGLNCD;
		dEBDALGLNCD2.disconnectedCallback = (DiscordRpc.OnDisconnectedInfo)Delegate.Combine(dEBDALGLNCD2.disconnectedCallback, new DiscordRpc.OnDisconnectedInfo(JDINLAKLCFG));
		ref DiscordRpc.EventHandlers dEBDALGLNCD3 = ref DEBDALGLNCD;
		dEBDALGLNCD3.errorCallback = (DiscordRpc.OnErrorInfo)Delegate.Combine(dEBDALGLNCD3.errorCallback, new DiscordRpc.OnErrorInfo(BMJGMHEAEPJ));
		ref DiscordRpc.EventHandlers dEBDALGLNCD4 = ref DEBDALGLNCD;
		dEBDALGLNCD4.joinCallback = (DiscordRpc.OnJoinInfo)Delegate.Combine(dEBDALGLNCD4.joinCallback, new DiscordRpc.OnJoinInfo(JoinCallback));
		ref DiscordRpc.EventHandlers dEBDALGLNCD5 = ref DEBDALGLNCD;
		dEBDALGLNCD5.spectateCallback = (DiscordRpc.OnSpectateInfo)Delegate.Combine(dEBDALGLNCD5.spectateCallback, new DiscordRpc.OnSpectateInfo(GHPMJEKMDCI));
		ref DiscordRpc.EventHandlers dEBDALGLNCD6 = ref DEBDALGLNCD;
		dEBDALGLNCD6.requestCallback = (DiscordRpc.OnRequestInfo)Delegate.Combine(dEBDALGLNCD6.requestCallback, new DiscordRpc.OnRequestInfo(BPCOJPMONFK));
		DiscordRpc.Initialize(applicationId, ref DEBDALGLNCD, false, optionalSteamId);
	}

	public void EEACPGKCKBH()
	{
		Debug.Log("_Value3");
		DiscordRpc.Respond(joinRequest.userId, DiscordRpc.Reply.No);
		hasResponded.Invoke();
	}

	private IEnumerator KJGBKGACNLL(string KGINEMAHHFO)
	{
		yield return new WaitUntil(() => Singleton<SaveSystem>.Instance.isSaveLoaded && SteamManager.Initialized);
		if ((bool)UnityEngine.Object.FindObjectOfType<NetworkMenu>())
		{
			UnityEngine.Object.FindObjectOfType<NetworkMenu>().JoinRoomByID(KGINEMAHHFO);
		}
	}

	public void KKCCPLJPGKD(string MJDPJLOCLIL)
	{
		Debug.Log(string.Format("Save Path: ", MJDPJLOCLIL));
		onSpectate.Invoke(MJDPJLOCLIL);
	}

	[SpecialName]
	public static DiscordController GGCHKDLDGBJ()
	{
		return BFKGHEBNCKL;
	}

	public void JNJBMKDHNLN(string MJDPJLOCLIL)
	{
		Debug.Log(string.Format("Connection error: ", MJDPJLOCLIL));
		onJoin.Invoke(MJDPJLOCLIL);
		string kGINEMAHHFO = GameManager.PNOAGJLDFJL(MJDPJLOCLIL);
		StartCoroutine(KJLFOJHECGL(kGINEMAHHFO));
	}

	public void DFBCKDALJJP(string MJDPJLOCLIL)
	{
		Debug.Log(string.Format("NO", MJDPJLOCLIL));
		onSpectate.Invoke(MJDPJLOCLIL);
	}

	public void CKICOOFLPPP(string MJDPJLOCLIL)
	{
		Debug.Log(string.Format("_ForceYSwap", MJDPJLOCLIL));
		onJoin.Invoke(MJDPJLOCLIL);
		string kGINEMAHHFO = GameManager.IBOCADBLICL(MJDPJLOCLIL);
		StartCoroutine(NLKAEEOLEEN(kGINEMAHHFO));
	}

	private void MAOCOEGAFND()
	{
		DiscordRpc.RunCallbacks();
	}

	public void PGAJBFMKFCF(int PNCJHNNOAAP, string JKPJCEMPAGH)
	{
		Debug.Log(string.Format("[LevelEditorScene] Error: Timeout :S", PNCJHNNOAAP, JKPJCEMPAGH));
		onDisconnect.Invoke();
	}
}
