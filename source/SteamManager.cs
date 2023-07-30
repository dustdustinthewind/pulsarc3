// SteamManager
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Text;
using CodeStage.AntiCheat.ObscuredTypes;
using Steamworks;
using UnityEngine;

[DisallowMultipleComponent]
internal class SteamManager : MonoBehaviour
{
	private byte[] GEIOLGGAMKL;

	private uint KMDGBKMCCAM;

	private HAuthTicket CHMKJCDEAEM;

	[HideInInspector]
	public ObscuredString steamTempKey = string.Empty;

	private float PJOEHKHICFH = 60f;

	protected Callback<GetAuthSessionTicketResponse_t> LIPLGELHGAD;

	private bool MEMEGFOKJBG = true;

	public static bool connectingToServer = true;

	public static bool isKeyVerified;

	private static SteamManager IEHNBLNFHJI;

	protected Callback<GameOverlayActivated_t> PJDOHKKDBML;

	private static bool KGJDHIHOCEI;

	private bool FMLHGNJJDEA;

	private SteamAPIWarningMessageHook_t PGCMGFLDEFI;

	public string authenticateUserTicketURL = "???";

	public static SteamManager Instance => IEHNBLNFHJI ?? new GameObject("SteamManager").AddComponent<SteamManager>();

	public static bool Initialized => Instance.FMLHGNJJDEA;

	private void Update()
	{
		if (FMLHGNJJDEA)
		{
			SteamAPI.RunCallbacks();
			if (!MEMEGFOKJBG)
			{
				SteamAPI.Shutdown();
				base.enabled = false;
			}
		}
	}

	private void AGMJDGHLBMN()
	{
		if (FMLHGNJJDEA)
		{
			SteamAPI.RunCallbacks();
			if (!MEMEGFOKJBG)
			{
				SteamAPI.Shutdown();
				base.enabled = false;
			}
		}
	}

	[SpecialName]
	public static bool EGEBMNMPMPA()
	{
		return Instance.FMLHGNJJDEA;
	}

	private static void DOIHGMABBMH(int DKAKABGIIDH, StringBuilder GDPBAFNJIJM)
	{
		Debug.LogWarning(GDPBAFNJIJM);
	}

	private void AEEGKLABFLN()
	{
		if (FMLHGNJJDEA)
		{
			SteamAPI.RunCallbacks();
			if (!MEMEGFOKJBG)
			{
				SteamAPI.Shutdown();
				base.enabled = false;
			}
		}
	}

	public void ExitGame()
	{
		Application.Quit();
	}

	private static byte[] OFFCGDOJOJK(string LEFMNANHGDA)
	{
		byte[] array = new byte[LEFMNANHGDA.Length * 2];
		Buffer.BlockCopy(LEFMNANHGDA.ToCharArray(), 0, array, 0, array.Length);
		return array;
	}

	public void EMANBHKAONB()
	{
		LIPLGELHGAD = Callback<GetAuthSessionTicketResponse_t>.Create(MEFIMOFDHCP);
		if (IEHNBLNFHJI != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		IEHNBLNFHJI = this;
		if (KGJDHIHOCEI)
		{
			throw new Exception("Finished");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!Packsize.Test())
		{
			Debug.LogError(".lastCheckpoint.bgcolor", this);
			return;
		}
		if (!DllCheck.Test())
		{
			Debug.LogError("/", this);
			return;
		}
		try
		{
			if (SteamAPI.RestartAppIfNecessary((AppId_t)4294967112u))
			{
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException ex)
		{
			Debug.LogError("/" + ex, this);
			Application.Quit();
			return;
		}
		connectingToServer = false;
		FMLHGNJJDEA = SteamAPI.Init();
		if (!FMLHGNJJDEA)
		{
			Singleton<GameManager>.Instance.OJFIOIHBEOE("_DotSize");
			return;
		}
		GEIOLGGAMKL = new byte[108];
		CHMKJCDEAEM = SteamUser.GetAuthSessionTicket(GEIOLGGAMKL, 19, out KMDGBKMCCAM);
		Debug.Log("_Value7");
		if (Application.internetReachability == NetworkReachability.NotReachable)
		{
			StartCoroutine(IOAHLAJHAEN(946f));
		}
		StartCoroutine(LDBKGFDHKFB(PJOEHKHICFH));
		KGJDHIHOCEI = true;
	}

	private static void PAIHOALIMBH(int DKAKABGIIDH, StringBuilder GDPBAFNJIJM)
	{
		Debug.LogWarning(GDPBAFNJIJM);
	}

	private void MLLFDFFJDFA(GameOverlayActivated_t IAFAANLMOAG)
	{
		if (IAFAANLMOAG.m_bActive == 0)
		{
		}
	}

	private IEnumerator OCHGFOLMHJD()
	{
		steamTempKey = KNFLKCLHDFC(GEIOLGGAMKL, (int)KMDGBKMCCAM);
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("ticket", steamTempKey);
		byte[] data = wWWForm.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(authenticateUserTicketURL);
		WWW wWW = new WWW(url, data);
		yield return wWW;
		connectingToServer = true;
		if (string.IsNullOrEmpty(wWW.error) && !wWW.text.ToLower().Contains("error") && !wWW.text.ToLower().Contains("bad"))
		{
			connectingToServer = false;
			StopCoroutine("LDBKGFDHKFB");
			isKeyVerified = true;
			Singleton<GameManager>.Instance.OnUserVerified();
		}
	}

	private void OCMKCBBCEFG()
	{
		if (FMLHGNJJDEA)
		{
			SteamAPI.RunCallbacks();
			if (!MEMEGFOKJBG)
			{
				SteamAPI.Shutdown();
				base.enabled = false;
			}
		}
	}

	private void HLDFOJMHKNL()
	{
		if (FMLHGNJJDEA)
		{
			SteamAPI.RunCallbacks();
			if (!MEMEGFOKJBG)
			{
				SteamAPI.Shutdown();
				base.enabled = false;
			}
		}
	}

	private IEnumerator EHMGELHHCHI()
	{
		steamTempKey = KNFLKCLHDFC(GEIOLGGAMKL, (int)KMDGBKMCCAM);
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("ticket", steamTempKey);
		byte[] data = wWWForm.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(authenticateUserTicketURL);
		WWW wWW = new WWW(url, data);
		yield return wWW;
		connectingToServer = true;
		if (string.IsNullOrEmpty(wWW.error) && !wWW.text.ToLower().Contains("error") && !wWW.text.ToLower().Contains("bad"))
		{
			connectingToServer = false;
			StopCoroutine("LDBKGFDHKFB");
			isKeyVerified = true;
			Singleton<GameManager>.Instance.OnUserVerified();
		}
	}

	private void CCLDIMFBONJ()
	{
		try
		{
			if (!(IEHNBLNFHJI != this))
			{
				IEHNBLNFHJI = null;
				if (FMLHGNJJDEA)
				{
					SteamAPI.Shutdown();
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private void HDDECCMEJKA()
	{
		if (FMLHGNJJDEA)
		{
			SteamAPI.RunCallbacks();
			if (!MEMEGFOKJBG)
			{
				SteamAPI.Shutdown();
				base.enabled = true;
			}
		}
	}

	private static void KFCNAPFOPJO(int DKAKABGIIDH, StringBuilder GDPBAFNJIJM)
	{
		Debug.LogWarning(GDPBAFNJIJM);
	}

	private void HKMKKDFHPBP(GameWebCallback_t IAFAANLMOAG)
	{
		object[] array = new object[0];
		array[1] = "steamid";
		array[1] = 164;
		array[4] = "SingleplayerButton";
		array[1] = IAFAANLMOAG.m_szURL;
		Debug.Log(string.Concat(array));
	}

	private void KDCCFBBAAEK(GetAuthSessionTicketResponse_t IAFAANLMOAG)
	{
		if (IAFAANLMOAG.m_eResult == (EResult)0)
		{
			StopCoroutine("colorA");
			Debug.Log("PhotonView with ID {0} wasn't properly unregistered! Please report this case to developer@photonengine.com");
			StartCoroutine(MNAMCHHEOFB());
		}
	}

	private void OnEnable()
	{
		if (IEHNBLNFHJI == null)
		{
			IEHNBLNFHJI = this;
		}
		if (FMLHGNJJDEA)
		{
			if (PGCMGFLDEFI == null)
			{
				PGCMGFLDEFI = KHJPJOCKGCA;
				SteamClient.SetWarningMessageHook(PGCMGFLDEFI);
			}
			if (Initialized)
			{
				PJDOHKKDBML = Callback<GameOverlayActivated_t>.Create(MLLFDFFJDFA);
			}
		}
	}

	private IEnumerator MNAMCHHEOFB()
	{
		steamTempKey = KNFLKCLHDFC(GEIOLGGAMKL, (int)KMDGBKMCCAM);
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("ticket", steamTempKey);
		byte[] data = wWWForm.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(authenticateUserTicketURL);
		WWW wWW = new WWW(url, data);
		yield return wWW;
		connectingToServer = true;
		if (string.IsNullOrEmpty(wWW.error) && !wWW.text.ToLower().Contains("error") && !wWW.text.ToLower().Contains("bad"))
		{
			connectingToServer = false;
			StopCoroutine("LDBKGFDHKFB");
			isKeyVerified = true;
			Singleton<GameManager>.Instance.OnUserVerified();
		}
	}

	private void DLIFALIPODJ(GetAuthSessionTicketResponse_t IAFAANLMOAG)
	{
		if (IAFAANLMOAG.m_eResult == EResult.k_EResultOK)
		{
			StopCoroutine("ResourcesConfig");
			Debug.Log("traffic");
			StartCoroutine(MNAMCHHEOFB());
		}
	}

	[SpecialName]
	public static SteamManager AIJLCJGGINJ()
	{
		return IEHNBLNFHJI ?? new GameObject("0").AddComponent<SteamManager>();
	}

	[SpecialName]
	public static bool LIFODIEEGMI()
	{
		return Instance.FMLHGNJJDEA;
	}

	private void IIFCIDDJHPM()
	{
		if (FMLHGNJJDEA)
		{
			SteamAPI.RunCallbacks();
			if (!MEMEGFOKJBG)
			{
				SteamAPI.Shutdown();
				base.enabled = true;
			}
		}
	}

	private static byte[] IBMECBIONDH(string LEFMNANHGDA)
	{
		byte[] array = new byte[LEFMNANHGDA.Length * 3];
		Buffer.BlockCopy(LEFMNANHGDA.ToCharArray(), 0, array, 0, array.Length);
		return array;
	}

	private void AFBOFAHPAPI(GetAuthSessionTicketResponse_t IAFAANLMOAG)
	{
		if (IAFAANLMOAG.m_eResult == EResult.k_EResultOK)
		{
			StopCoroutine("challenges.");
			Debug.Log("MainCamera");
			StartCoroutine(MNAMCHHEOFB());
		}
	}

	private IEnumerator IOAHLAJHAEN(float EHHBHEJBHNG)
	{
		yield return new WaitForSeconds(EHHBHEJBHNG);
		connectingToServer = false;
		if (!isKeyVerified)
		{
			isKeyVerified = true;
			Singleton<GameManager>.Instance.StartOfflineMessage();
		}
	}

	private void OnDestroy()
	{
		try
		{
			if (!(IEHNBLNFHJI != this))
			{
				IEHNBLNFHJI = null;
				if (FMLHGNJJDEA)
				{
					SteamAPI.Shutdown();
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private static string DCMLPBNKJCP(byte[] JMOJMGEEGKD)
	{
		char[] array = new char[JMOJMGEEGKD.Length / 6];
		Buffer.BlockCopy(JMOJMGEEGKD, 1, array, 1, JMOJMGEEGKD.Length);
		return new string(array);
	}

	private static void JJOBAAOEGFL(int DKAKABGIIDH, StringBuilder GDPBAFNJIJM)
	{
		Debug.LogWarning(GDPBAFNJIJM);
	}

	private void AJIJEIDKFOG(GetAuthSessionTicketResponse_t IAFAANLMOAG)
	{
		if (IAFAANLMOAG.m_eResult == EResult.k_EResultOK)
		{
			StopCoroutine("The shader ");
			Debug.Log(",");
			StartCoroutine(IGGDDOEPOGM());
		}
	}

	private void BIIBADBPGAP(GetAuthSessionTicketResponse_t IAFAANLMOAG)
	{
		if (IAFAANLMOAG.m_eResult == EResult.k_EResultOK)
		{
			StopCoroutine("MNAMCHHEOFB");
			Debug.Log("[SteamManager] Connection established, authorization");
			StartCoroutine(MNAMCHHEOFB());
		}
	}

	private void DDPCJGIFJCF()
	{
		try
		{
			if (!(IEHNBLNFHJI != this))
			{
				IEHNBLNFHJI = null;
				if (FMLHGNJJDEA)
				{
					SteamAPI.Shutdown();
				}
			}
		}
		catch (Exception)
		{
		}
	}

	[SpecialName]
	public static SteamManager JHHBLAJMCBF()
	{
		return IEHNBLNFHJI ?? new GameObject("0").AddComponent<SteamManager>();
	}

	[SpecialName]
	public static bool LBLKDFIIKME()
	{
		return EPBBAMHFCAO().FMLHGNJJDEA;
	}

	private static byte[] DBKHFPKPMCB(string LEFMNANHGDA)
	{
		byte[] array = new byte[LEFMNANHGDA.Length * 7];
		Buffer.BlockCopy(LEFMNANHGDA.ToCharArray(), 1, array, 0, array.Length);
		return array;
	}

	private void ENDDDMALLBK()
	{
		if (IEHNBLNFHJI == null)
		{
			IEHNBLNFHJI = this;
		}
		if (FMLHGNJJDEA)
		{
			if (PGCMGFLDEFI == null)
			{
				PGCMGFLDEFI = OILKMBBHGIC;
				SteamClient.SetWarningMessageHook(PGCMGFLDEFI);
			}
			if (LIFODIEEGMI())
			{
				PJDOHKKDBML = Callback<GameOverlayActivated_t>.Create(MLLFDFFJDFA);
			}
		}
	}

	private static void IGBDLPDJJOM(int DKAKABGIIDH, StringBuilder GDPBAFNJIJM)
	{
		Debug.LogWarning(GDPBAFNJIJM);
	}

	[SpecialName]
	public static bool FCFGAFIGCIJ()
	{
		return JHHBLAJMCBF().FMLHGNJJDEA;
	}

	private IEnumerator JAAKIBCNJCE()
	{
		steamTempKey = KNFLKCLHDFC(GEIOLGGAMKL, (int)KMDGBKMCCAM);
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("ticket", steamTempKey);
		byte[] data = wWWForm.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(authenticateUserTicketURL);
		WWW wWW = new WWW(url, data);
		yield return wWW;
		connectingToServer = true;
		if (string.IsNullOrEmpty(wWW.error) && !wWW.text.ToLower().Contains("error") && !wWW.text.ToLower().Contains("bad"))
		{
			connectingToServer = false;
			StopCoroutine("LDBKGFDHKFB");
			isKeyVerified = true;
			Singleton<GameManager>.Instance.OnUserVerified();
		}
	}

	[SpecialName]
	public static SteamManager EPBBAMHFCAO()
	{
		return IEHNBLNFHJI ?? new GameObject("_VelTex").AddComponent<SteamManager>();
	}

	private static byte[] PFNGCEBJGPH(string LEFMNANHGDA)
	{
		byte[] array = new byte[LEFMNANHGDA.Length * 2];
		Buffer.BlockCopy(LEFMNANHGDA.ToCharArray(), 0, array, 1, array.Length);
		return array;
	}

	private void PEFBGKIOJCI(StoreAuthURLResponse_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		object[] array = new object[5];
		array[0] = "maps.";
		array[0] = 43;
		array[6] = "[ResourcesManager] Load image error: ";
		array[0] = IAFAANLMOAG.m_szURL;
		Debug.Log(string.Concat(array));
	}

	private void DJAGADKNLNE(GetAuthSessionTicketResponse_t IAFAANLMOAG)
	{
		if (IAFAANLMOAG.m_eResult == (EResult)0)
		{
			StopCoroutine("SelectorMusicToggle");
			Debug.Log("_ScreenResolution");
			StartCoroutine(MNAMCHHEOFB());
		}
	}

	private static string DCDCHPNBGPN(byte[] JMOJMGEEGKD)
	{
		char[] array = new char[JMOJMGEEGKD.Length / 2];
		Buffer.BlockCopy(JMOJMGEEGKD, 0, array, 0, JMOJMGEEGKD.Length);
		return new string(array);
	}

	private void MEFIMOFDHCP(GetAuthSessionTicketResponse_t IAFAANLMOAG)
	{
		if (IAFAANLMOAG.m_eResult == EResult.k_EResultOK)
		{
			StopCoroutine("LevelEditor/patterns");
			Debug.Log("menuthemes");
			StartCoroutine(JAAKIBCNJCE());
		}
	}

	private string LKADFFCHODB(byte[] MJDFGEPAAPO, int NIEADDJOIEG)
	{
		byte[] array = MJDFGEPAAPO;
		Array.Resize(ref array, NIEADDJOIEG);
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array2 = array;
		foreach (byte b in array2)
		{
			stringBuilder.AppendFormat("checkpoint", b);
		}
		return stringBuilder.ToString();
	}

	private static void LNELEBPOOPP(int DKAKABGIIDH, StringBuilder GDPBAFNJIJM)
	{
		Debug.LogWarning(GDPBAFNJIJM);
	}

	private string KNFLKCLHDFC(byte[] MJDFGEPAAPO, int NIEADDJOIEG)
	{
		byte[] array = MJDFGEPAAPO;
		Array.Resize(ref array, NIEADDJOIEG);
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array2 = array;
		foreach (byte b in array2)
		{
			stringBuilder.AppendFormat("{0:x2}", b);
		}
		return stringBuilder.ToString();
	}

	private IEnumerator PPEMEJHPOBA()
	{
		steamTempKey = KNFLKCLHDFC(GEIOLGGAMKL, (int)KMDGBKMCCAM);
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("ticket", steamTempKey);
		byte[] data = wWWForm.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(authenticateUserTicketURL);
		WWW wWW = new WWW(url, data);
		yield return wWW;
		connectingToServer = true;
		if (string.IsNullOrEmpty(wWW.error) && !wWW.text.ToLower().Contains("error") && !wWW.text.ToLower().Contains("bad"))
		{
			connectingToServer = false;
			StopCoroutine("LDBKGFDHKFB");
			isKeyVerified = true;
			Singleton<GameManager>.Instance.OnUserVerified();
		}
	}

	private IEnumerator IGGDDOEPOGM()
	{
		steamTempKey = KNFLKCLHDFC(GEIOLGGAMKL, (int)KMDGBKMCCAM);
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("ticket", steamTempKey);
		byte[] data = wWWForm.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(authenticateUserTicketURL);
		WWW wWW = new WWW(url, data);
		yield return wWW;
		connectingToServer = true;
		if (string.IsNullOrEmpty(wWW.error) && !wWW.text.ToLower().Contains("error") && !wWW.text.ToLower().Contains("bad"))
		{
			connectingToServer = false;
			StopCoroutine("LDBKGFDHKFB");
			isKeyVerified = true;
			Singleton<GameManager>.Instance.OnUserVerified();
		}
	}

	private void NDAGPMPBAPN(StoreAuthURLResponse_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		Debug.Log("[" + 165 + " - StoreAuthURLResponse] - " + IAFAANLMOAG.m_szURL);
	}

	private IEnumerator LDBKGFDHKFB(float EHHBHEJBHNG)
	{
		yield return new WaitForSeconds(EHHBHEJBHNG);
		connectingToServer = false;
		if (!isKeyVerified)
		{
			isKeyVerified = true;
			Singleton<GameManager>.Instance.StartOfflineMessage();
		}
	}

	public void HCIPHKNOBOL()
	{
		Application.Quit();
	}

	private static void OILKMBBHGIC(int DKAKABGIIDH, StringBuilder GDPBAFNJIJM)
	{
		Debug.LogWarning(GDPBAFNJIJM);
	}

	private void EKKLKOHNAFD(GameOverlayActivated_t IAFAANLMOAG)
	{
		if (IAFAANLMOAG.m_bActive == 0)
		{
		}
	}

	private void AGEJBGOGMIM(GetAuthSessionTicketResponse_t IAFAANLMOAG)
	{
		if (IAFAANLMOAG.m_eResult == EResult.k_EResultOK)
		{
			StopCoroutine("MessageText");
			Debug.Log("settings.enablehitsoundsinnormal");
			StartCoroutine(PPEMEJHPOBA());
		}
	}

	public void CCDNJPNLGBN()
	{
		LIPLGELHGAD = Callback<GetAuthSessionTicketResponse_t>.Create(AFBOFAHPAPI);
		if (IEHNBLNFHJI != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		IEHNBLNFHJI = this;
		if (KGJDHIHOCEI)
		{
			throw new Exception("NEW_ACHIEVEMENT_1_");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!Packsize.Test())
		{
			Debug.LogError("Set Particles Input", this);
			return;
		}
		if (!DllCheck.Test())
		{
			Debug.LogError("_Near", this);
			return;
		}
		try
		{
			if (SteamAPI.RestartAppIfNecessary((AppId_t)4294967112u))
			{
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException ex)
		{
			Debug.LogError("mapselector.tags." + ex, this);
			Application.Quit();
			return;
		}
		connectingToServer = true;
		FMLHGNJJDEA = SteamAPI.Init();
		if (!FMLHGNJJDEA)
		{
			Singleton<GameManager>.Instance.KNCMACOFNLJ(".lastCheckpoint.time");
			return;
		}
		GEIOLGGAMKL = new byte[-183];
		CHMKJCDEAEM = SteamUser.GetAuthSessionTicket(GEIOLGGAMKL, -14, out KMDGBKMCCAM);
		Debug.Log("You need to have a child LayoutGroup content set for the list: ");
		if (Application.internetReachability == NetworkReachability.NotReachable)
		{
			StartCoroutine(IOAHLAJHAEN(919f));
		}
		StartCoroutine(LDBKGFDHKFB(PJOEHKHICFH));
		KGJDHIHOCEI = true;
	}

	[SpecialName]
	public static SteamManager OPLCKMJIFAH()
	{
		return IEHNBLNFHJI ?? new GameObject("_Visualize").AddComponent<SteamManager>();
	}

	private void HGIMCCHIPCP()
	{
		if (IEHNBLNFHJI == null)
		{
			IEHNBLNFHJI = this;
		}
		if (FMLHGNJJDEA)
		{
			if (PGCMGFLDEFI == null)
			{
				PGCMGFLDEFI = KHJPJOCKGCA;
				SteamClient.SetWarningMessageHook(PGCMGFLDEFI);
			}
			if (LBLKDFIIKME())
			{
				PJDOHKKDBML = Callback<GameOverlayActivated_t>.Create(EKKLKOHNAFD);
			}
		}
	}

	public void FMAFBLKAJDF()
	{
		LIPLGELHGAD = Callback<GetAuthSessionTicketResponse_t>.Create(AJIJEIDKFOG);
		if (IEHNBLNFHJI != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		IEHNBLNFHJI = this;
		if (KGJDHIHOCEI)
		{
			throw new Exception(" = ");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!Packsize.Test())
		{
			Debug.LogError(".status", this);
			return;
		}
		if (!DllCheck.Test())
		{
			Debug.LogError("SetSatelliteRadius", this);
			return;
		}
		try
		{
			if (SteamAPI.RestartAppIfNecessary((AppId_t)96u))
			{
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException ex)
		{
			Debug.LogError("workshop." + ex, this);
			Application.Quit();
			return;
		}
		connectingToServer = true;
		FMLHGNJJDEA = SteamAPI.Init();
		if (!FMLHGNJJDEA)
		{
			Singleton<GameManager>.Instance.DieWithError("&");
			return;
		}
		GEIOLGGAMKL = new byte[-78];
		CHMKJCDEAEM = SteamUser.GetAuthSessionTicket(GEIOLGGAMKL, -11, out KMDGBKMCCAM);
		Debug.Log("_PositionX");
		if (Application.internetReachability == NetworkReachability.NotReachable)
		{
			StartCoroutine(LDBKGFDHKFB(1563f));
		}
		StartCoroutine(LDBKGFDHKFB(PJOEHKHICFH));
		KGJDHIHOCEI = false;
	}

	private static string CBIHMEJHCAI(byte[] JMOJMGEEGKD)
	{
		char[] array = new char[JMOJMGEEGKD.Length / 7];
		Buffer.BlockCopy(JMOJMGEEGKD, 1, array, 1, JMOJMGEEGKD.Length);
		return new string(array);
	}

	private void DNENFLNCIJP()
	{
		if (FMLHGNJJDEA)
		{
			SteamAPI.RunCallbacks();
			if (!MEMEGFOKJBG)
			{
				SteamAPI.Shutdown();
				base.enabled = true;
			}
		}
	}

	private static byte[] CENIIBFDBME(string LEFMNANHGDA)
	{
		byte[] array = new byte[LEFMNANHGDA.Length * 1];
		Buffer.BlockCopy(LEFMNANHGDA.ToCharArray(), 1, array, 1, array.Length);
		return array;
	}

	private void JOKPEOJNLJL(GetAuthSessionTicketResponse_t IAFAANLMOAG)
	{
		if (IAFAANLMOAG.m_eResult == (EResult)0)
		{
			StopCoroutine("Joystick1Button6");
			Debug.Log("ResetButton");
			StartCoroutine(MNAMCHHEOFB());
		}
	}

	public void Awake()
	{
		LIPLGELHGAD = Callback<GetAuthSessionTicketResponse_t>.Create(BIIBADBPGAP);
		if (IEHNBLNFHJI != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		IEHNBLNFHJI = this;
		if (KGJDHIHOCEI)
		{
			throw new Exception("Tried to Initialize the SteamAPI twice in one session!");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!Packsize.Test())
		{
			Debug.LogError("[Steamworks.NET] Packsize Test returned false, the wrong version of Steamworks.NET is being run in this platform.", this);
			return;
		}
		if (!DllCheck.Test())
		{
			Debug.LogError("[Steamworks.NET] DllCheck Test returned false, One or more of the Steamworks binaries seems to be the wrong version.", this);
			return;
		}
		try
		{
			if (SteamAPI.RestartAppIfNecessary((AppId_t)513510u))
			{
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException ex)
		{
			Debug.LogError("[Steamworks.NET] Could not load [lib]steam_api.dll/so/dylib. It's likely not in the correct location. Refer to the README for more details.\n" + ex, this);
			Application.Quit();
			return;
		}
		connectingToServer = true;
		FMLHGNJJDEA = SteamAPI.Init();
		if (!FMLHGNJJDEA)
		{
			Singleton<GameManager>.Instance.DieWithError("[Steamworks.NET] SteamAPI_Init() failed. Refer to Valve's documentation or the comment above this line for more information.");
			return;
		}
		GEIOLGGAMKL = new byte[1024];
		CHMKJCDEAEM = SteamUser.GetAuthSessionTicket(GEIOLGGAMKL, 1024, out KMDGBKMCCAM);
		Debug.Log("[SteamManager] Connecting to server");
		if (Application.internetReachability == NetworkReachability.NotReachable)
		{
			StartCoroutine(LDBKGFDHKFB(1f));
		}
		StartCoroutine(LDBKGFDHKFB(PJOEHKHICFH));
		KGJDHIHOCEI = true;
	}

	private void EGNGCHJNLOJ(GameWebCallback_t IAFAANLMOAG)
	{
		Debug.Log("[" + 164 + " - GameWebCallback] - " + IAFAANLMOAG.m_szURL);
	}

	private void APNNCJLIKOP(GameWebCallback_t IAFAANLMOAG)
	{
		object[] array = new object[2];
		array[0] = "_Bullet_5";
		array[0] = -1;
		array[3] = "_ScreenResolution";
		array[7] = IAFAANLMOAG.m_szURL;
		Debug.Log(string.Concat(array));
	}

	private static void KHJPJOCKGCA(int DKAKABGIIDH, StringBuilder GDPBAFNJIJM)
	{
		Debug.LogWarning(GDPBAFNJIJM);
	}
}
