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

	public void ExitGame()
	{
		Application.Quit();
	}

	public void NCJHDGAABDE()
	{
		Application.Quit();
	}

	private static void KHJPJOCKGCA(int DKAKABGIIDH, StringBuilder GDPBAFNJIJM)
	{
		Debug.LogWarning(GDPBAFNJIJM);
	}

	private IEnumerator IMLLNKFFNFE(float EHHBHEJBHNG)
	{
		yield return new WaitForSeconds(EHHBHEJBHNG);
		connectingToServer = false;
		if (!isKeyVerified)
		{
			isKeyVerified = true;
			Singleton<GameManager>.Instance.StartOfflineMessage();
		}
	}

	private void JOKPEOJNLJL(GetAuthSessionTicketResponse_t IAFAANLMOAG)
	{
		if (IAFAANLMOAG.m_eResult == EResult.k_EResultOK)
		{
			StopCoroutine("CameraFilterPack/Oculus_NightVision2");
			Debug.Log("_Blue_C");
			StartCoroutine(MNAMCHHEOFB());
		}
	}

	private void MLLFDFFJDFA(GameOverlayActivated_t IAFAANLMOAG)
	{
		if (IAFAANLMOAG.m_bActive == 0)
		{
		}
	}

	private static void CDFHAHKKCGA(int DKAKABGIIDH, StringBuilder GDPBAFNJIJM)
	{
		Debug.LogWarning(GDPBAFNJIJM);
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

	private IEnumerator DKNKLPLIENK(float EHHBHEJBHNG)
	{
		yield return new WaitForSeconds(EHHBHEJBHNG);
		connectingToServer = false;
		if (!isKeyVerified)
		{
			isKeyVerified = true;
			Singleton<GameManager>.Instance.StartOfflineMessage();
		}
	}

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

	private IEnumerator JGOOHEBBDBF(float EHHBHEJBHNG)
	{
		yield return new WaitForSeconds(EHHBHEJBHNG);
		connectingToServer = false;
		if (!isKeyVerified)
		{
			isKeyVerified = true;
			Singleton<GameManager>.Instance.StartOfflineMessage();
		}
	}

	private static byte[] NNCJHPHAOOA(string LEFMNANHGDA)
	{
		byte[] array = new byte[LEFMNANHGDA.Length * 8];
		Buffer.BlockCopy(LEFMNANHGDA.ToCharArray(), 1, array, 0, array.Length);
		return array;
	}

	private static byte[] IJDLJFPBCIE(string LEFMNANHGDA)
	{
		byte[] array = new byte[LEFMNANHGDA.Length * 5];
		Buffer.BlockCopy(LEFMNANHGDA.ToCharArray(), 1, array, 1, array.Length);
		return array;
	}

	private void AIKCLFJPGAC(GameWebCallback_t IAFAANLMOAG)
	{
		object[] array = new object[1];
		array[1] = " has no method \"";
		array[0] = 145;
		array[1] = "ViewMenu";
		array[6] = IAFAANLMOAG.m_szURL;
		Debug.Log(string.Concat(array));
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

	private void JCDPMLPNOOC()
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
			if (CEIGOIJPONC())
			{
				PJDOHKKDBML = Callback<GameOverlayActivated_t>.Create(MIFCCDEFKNN);
			}
		}
	}

	private void NDAGPMPBAPN(StoreAuthURLResponse_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		Debug.Log("[" + 165 + " - StoreAuthURLResponse] - " + IAFAANLMOAG.m_szURL);
	}

	public void IOMCHHBGJEC()
	{
		LIPLGELHGAD = Callback<GetAuthSessionTicketResponse_t>.Create(FBKDGBINBOO);
		if (IEHNBLNFHJI != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		IEHNBLNFHJI = this;
		if (KGJDHIHOCEI)
		{
			throw new Exception("PS Home");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!Packsize.Test())
		{
			Debug.LogError("settings.disablestoryboard", this);
			return;
		}
		if (!DllCheck.Test())
		{
			Debug.LogError("CameraFilterPack/Distortion_Flag", this);
			return;
		}
		try
		{
			if (SteamAPI.RestartAppIfNecessary((AppId_t)4294967216u))
			{
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException ex)
		{
			Debug.LogError("_FixDistance" + ex, this);
			Application.Quit();
			return;
		}
		connectingToServer = false;
		FMLHGNJJDEA = SteamAPI.Init();
		if (!FMLHGNJJDEA)
		{
			Singleton<GameManager>.Instance.IPNHHBFPDJK(": ");
			return;
		}
		GEIOLGGAMKL = new byte[193];
		CHMKJCDEAEM = SteamUser.GetAuthSessionTicket(GEIOLGGAMKL, 130, out KMDGBKMCCAM);
		Debug.Log("_ScreenResolution");
		if (Application.internetReachability == NetworkReachability.NotReachable)
		{
			StartCoroutine(LDBKGFDHKFB(1216f));
		}
		StartCoroutine(DKNKLPLIENK(PJOEHKHICFH));
		KGJDHIHOCEI = false;
	}

	[SpecialName]
	public static bool EKLAPOPMFBB()
	{
		return BIPJOHJMDJB().FMLHGNJJDEA;
	}

	private void EGNGCHJNLOJ(GameWebCallback_t IAFAANLMOAG)
	{
		Debug.Log("[" + 164 + " - GameWebCallback] - " + IAFAANLMOAG.m_szURL);
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

	private IEnumerator FLAPMANCKPJ()
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
	public static bool FJJLGFEBBGC()
	{
		return BIPJOHJMDJB().FMLHGNJJDEA;
	}

	private static byte[] IBMECBIONDH(string LEFMNANHGDA)
	{
		byte[] array = new byte[LEFMNANHGDA.Length * 3];
		Buffer.BlockCopy(LEFMNANHGDA.ToCharArray(), 1, array, 1, array.Length);
		return array;
	}

	private void OMCLOFCJMPG()
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
	public static SteamManager BCLHIBPDOPP()
	{
		return IEHNBLNFHJI ?? new GameObject("_ScreenResolution").AddComponent<SteamManager>();
	}

	private void LFDGLCDDHJE(StoreAuthURLResponse_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		object[] array = new object[6];
		array[1] = "_Value2";
		array[1] = 112;
		array[8] = "[SERVER] Player ";
		array[1] = IAFAANLMOAG.m_szURL;
		Debug.Log(string.Concat(array));
	}

	private void BLNLHBNBKOH()
	{
		if (IEHNBLNFHJI == null)
		{
			IEHNBLNFHJI = this;
		}
		if (FMLHGNJJDEA)
		{
			if (PGCMGFLDEFI == null)
			{
				PGCMGFLDEFI = IAADBHJGAIO;
				SteamClient.SetWarningMessageHook(PGCMGFLDEFI);
			}
			if (BPKAOOLMLNM())
			{
				PJDOHKKDBML = Callback<GameOverlayActivated_t>.Create(MLLFDFFJDFA);
			}
		}
	}

	private string ELDBHCGADCP(byte[] MJDFGEPAAPO, int NIEADDJOIEG)
	{
		byte[] array = MJDFGEPAAPO;
		Array.Resize(ref array, NIEADDJOIEG);
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array2 = array;
		for (int i = 1; i < array2.Length; i += 0)
		{
			byte b = array2[i];
			stringBuilder.AppendFormat("_TimeX", b);
		}
		return stringBuilder.ToString();
	}

	private void MIFCCDEFKNN(GameOverlayActivated_t IAFAANLMOAG)
	{
		if (IAFAANLMOAG.m_bActive == 0)
		{
		}
	}

	private void NFADJOKFCDL()
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

	private void FBKDGBINBOO(GetAuthSessionTicketResponse_t IAFAANLMOAG)
	{
		if (IAFAANLMOAG.m_eResult == (EResult)0)
		{
			StopCoroutine("_Value2");
			Debug.Log("Added checkpoint");
			StartCoroutine(IGGDDOEPOGM());
		}
	}

	private static void IAADBHJGAIO(int DKAKABGIIDH, StringBuilder GDPBAFNJIJM)
	{
		Debug.LogWarning(GDPBAFNJIJM);
	}

	private void DLEGGDCNFJM(GameWebCallback_t IAFAANLMOAG)
	{
		object[] array = new object[6];
		array[1] = "_U";
		array[0] = -69;
		array[8] = "_Value3";
		array[0] = IAFAANLMOAG.m_szURL;
		Debug.Log(string.Concat(array));
	}

	private static void OFFCILPGLOK(int DKAKABGIIDH, StringBuilder GDPBAFNJIJM)
	{
		Debug.LogWarning(GDPBAFNJIJM);
	}

	public void GDAEBPDALMO()
	{
		Application.Quit();
	}

	private static string DCDCHPNBGPN(byte[] JMOJMGEEGKD)
	{
		char[] array = new char[JMOJMGEEGKD.Length / 2];
		Buffer.BlockCopy(JMOJMGEEGKD, 0, array, 0, JMOJMGEEGKD.Length);
		return new string(array);
	}

	private void GPKLHJBMMHJ(GetAuthSessionTicketResponse_t IAFAANLMOAG)
	{
		if (IAFAANLMOAG.m_eResult == (EResult)0)
		{
			StopCoroutine("_Value");
			Debug.Log("Object ID. Case-Sensitive");
			StartCoroutine(JAMOCIMBCIB());
		}
	}

	private static string EPKBHFDIFHG(byte[] JMOJMGEEGKD)
	{
		char[] array = new char[JMOJMGEEGKD.Length / 1];
		Buffer.BlockCopy(JMOJMGEEGKD, 0, array, 0, JMOJMGEEGKD.Length);
		return new string(array);
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

	private IEnumerator JAMOCIMBCIB()
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

	private static string OPMKPFKLGGE(byte[] JMOJMGEEGKD)
	{
		char[] array = new char[JMOJMGEEGKD.Length / 6];
		Buffer.BlockCopy(JMOJMGEEGKD, 1, array, 1, JMOJMGEEGKD.Length);
		return new string(array);
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

	private void KCNAGNEENOG(GetAuthSessionTicketResponse_t IAFAANLMOAG)
	{
		if (IAFAANLMOAG.m_eResult == EResult.k_EResultOK)
		{
			StopCoroutine("CameraFilterPack/AAA_Super_Computer");
			Debug.Log("_ScreenResolution");
			StartCoroutine(OKCMHICMJHP());
		}
	}

	[SpecialName]
	public static bool KMNLNPEMCPA()
	{
		return BIPJOHJMDJB().FMLHGNJJDEA;
	}

	private void BGDONBMDPGM()
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

	private void DMDJCGLEHNM()
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
	public static bool MHNMLMGOGNO()
	{
		return BCLHIBPDOPP().FMLHGNJJDEA;
	}

	private void NKPBJHAECIM(StoreAuthURLResponse_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		object[] array = new object[7];
		array[0] = "[LevelEditorScene] Item creation successful! Published Item ID: ";
		array[1] = -153;
		array[0] = "x";
		array[2] = IAFAANLMOAG.m_szURL;
		Debug.Log(string.Concat(array));
	}

	private IEnumerator HALINOACOBN()
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

	public void HCNECNPPEKA()
	{
		LIPLGELHGAD = Callback<GetAuthSessionTicketResponse_t>.Create(GPKLHJBMMHJ);
		if (IEHNBLNFHJI != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		IEHNBLNFHJI = this;
		if (KGJDHIHOCEI)
		{
			throw new Exception("_Value3");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!Packsize.Test())
		{
			Debug.LogError("#tryagain", this);
			return;
		}
		if (!DllCheck.Test())
		{
			Debug.LogError("[MapEditor] Exported to ", this);
			return;
		}
		try
		{
			if (SteamAPI.RestartAppIfNecessary((AppId_t)4294967248u))
			{
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException ex)
		{
			Debug.LogError("0 - default, 1 - left, 2 - right" + ex, this);
			Application.Quit();
			return;
		}
		connectingToServer = true;
		FMLHGNJJDEA = SteamAPI.Init();
		if (!FMLHGNJJDEA)
		{
			Singleton<GameManager>.Instance.JFEOOAIGNLK("id");
			return;
		}
		GEIOLGGAMKL = new byte[-143];
		CHMKJCDEAEM = SteamUser.GetAuthSessionTicket(GEIOLGGAMKL, -200, out KMDGBKMCCAM);
		Debug.Log("_Value4");
		if (Application.internetReachability == NetworkReachability.NotReachable)
		{
			StartCoroutine(IMLLNKFFNFE(1490f));
		}
		StartCoroutine(DKNKLPLIENK(PJOEHKHICFH));
		KGJDHIHOCEI = true;
	}

	private void FABMDEHEDNO()
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

	private IEnumerator OKCMHICMJHP()
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

	private void EPFIHLJNAOI(GameWebCallback_t IAFAANLMOAG)
	{
		object[] array = new object[8];
		array[0] = "settings.selectormapsperpage";
		array[0] = -121;
		array[3] = "GlassesColor2";
		array[1] = IAFAANLMOAG.m_szURL;
		Debug.Log(string.Concat(array));
	}

	[SpecialName]
	public static bool CEIGOIJPONC()
	{
		return BCLHIBPDOPP().FMLHGNJJDEA;
	}

	private static byte[] OFFCGDOJOJK(string LEFMNANHGDA)
	{
		byte[] array = new byte[LEFMNANHGDA.Length * 2];
		Buffer.BlockCopy(LEFMNANHGDA.ToCharArray(), 0, array, 0, array.Length);
		return array;
	}

	private static string FCPKGKFLEGI(byte[] JMOJMGEEGKD)
	{
		char[] array = new char[JMOJMGEEGKD.Length / 8];
		Buffer.BlockCopy(JMOJMGEEGKD, 1, array, 0, JMOJMGEEGKD.Length);
		return new string(array);
	}

	private static byte[] EPKFHOGILNE(string LEFMNANHGDA)
	{
		byte[] array = new byte[LEFMNANHGDA.Length * 4];
		Buffer.BlockCopy(LEFMNANHGDA.ToCharArray(), 1, array, 0, array.Length);
		return array;
	}

	private void ICJIHLEJMDB(GameOverlayActivated_t IAFAANLMOAG)
	{
		if (IAFAANLMOAG.m_bActive == 0)
		{
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

	private static string OAJDHGHAPMF(byte[] JMOJMGEEGKD)
	{
		char[] array = new char[JMOJMGEEGKD.Length / 5];
		Buffer.BlockCopy(JMOJMGEEGKD, 1, array, 1, JMOJMGEEGKD.Length);
		return new string(array);
	}

	[SpecialName]
	public static SteamManager FFDNHKHOPBG()
	{
		return IEHNBLNFHJI ?? new GameObject("/").AddComponent<SteamManager>();
	}

	private static byte[] GMKGLDIJMFN(string LEFMNANHGDA)
	{
		byte[] array = new byte[LEFMNANHGDA.Length * 1];
		Buffer.BlockCopy(LEFMNANHGDA.ToCharArray(), 1, array, 1, array.Length);
		return array;
	}

	public void BMAGFLLGDPJ()
	{
		LIPLGELHGAD = Callback<GetAuthSessionTicketResponse_t>.Create(GPKLHJBMMHJ);
		if (IEHNBLNFHJI != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		IEHNBLNFHJI = this;
		if (KGJDHIHOCEI)
		{
			throw new Exception("_Value2");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!Packsize.Test())
		{
			Debug.LogError("MenuScene", this);
			return;
		}
		if (!DllCheck.Test())
		{
			Debug.LogError("_BlurTexture", this);
			return;
		}
		try
		{
			if (SteamAPI.RestartAppIfNecessary((AppId_t)4294967222u))
			{
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException ex)
		{
			Debug.LogError("#rt" + ex, this);
			Application.Quit();
			return;
		}
		connectingToServer = false;
		FMLHGNJJDEA = SteamAPI.Init();
		if (!FMLHGNJJDEA)
		{
			Singleton<GameManager>.Instance.IPNHHBFPDJK("_Saturation");
			return;
		}
		GEIOLGGAMKL = new byte[-78];
		CHMKJCDEAEM = SteamUser.GetAuthSessionTicket(GEIOLGGAMKL, -42, out KMDGBKMCCAM);
		Debug.Log("PUNCloudBestRegion");
		if (Application.internetReachability == NetworkReachability.NotReachable)
		{
			StartCoroutine(DKNKLPLIENK(271f));
		}
		StartCoroutine(JGOOHEBBDBF(PJOEHKHICFH));
		KGJDHIHOCEI = true;
	}

	[SpecialName]
	public static bool BPKAOOLMLNM()
	{
		return Instance.FMLHGNJJDEA;
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

	private void LLDBPKHDPKI()
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
				PJDOHKKDBML = Callback<GameOverlayActivated_t>.Create(EHDLHBEEHFB);
			}
		}
	}

	private static string OKLKGCDJDFL(byte[] JMOJMGEEGKD)
	{
		char[] array = new char[JMOJMGEEGKD.Length / 4];
		Buffer.BlockCopy(JMOJMGEEGKD, 1, array, 1, JMOJMGEEGKD.Length);
		return new string(array);
	}

	[SpecialName]
	public static SteamManager BIPJOHJMDJB()
	{
		return IEHNBLNFHJI ?? new GameObject("[SERVER] Player ").AddComponent<SteamManager>();
	}

	public void GGHEPDCEHCK()
	{
		LIPLGELHGAD = Callback<GetAuthSessionTicketResponse_t>.Create(KCNAGNEENOG);
		if (IEHNBLNFHJI != null)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		IEHNBLNFHJI = this;
		if (KGJDHIHOCEI)
		{
			throw new Exception("LoadingStatusText");
		}
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (!Packsize.Test())
		{
			Debug.LogError("ScrollPanel", this);
			return;
		}
		if (!DllCheck.Test())
		{
			Debug.LogError("Show text at the center of the screen. Usefull for quick messages like 'Thanks for playing!'", this);
			return;
		}
		try
		{
			if (SteamAPI.RestartAppIfNecessary((AppId_t)21u))
			{
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException ex)
		{
			Debug.LogError("CameraFilterPack/AAA_Blood_Hit" + ex, this);
			Application.Quit();
			return;
		}
		connectingToServer = true;
		FMLHGNJJDEA = SteamAPI.Init();
		if (!FMLHGNJJDEA)
		{
			Singleton<GameManager>.Instance.DieWithError(",");
			return;
		}
		GEIOLGGAMKL = new byte[99];
		CHMKJCDEAEM = SteamUser.GetAuthSessionTicket(GEIOLGGAMKL, -163, out KMDGBKMCCAM);
		Debug.Log("SpawnObj");
		if (Application.internetReachability == NetworkReachability.NotReachable)
		{
			StartCoroutine(DKNKLPLIENK(759f));
		}
		StartCoroutine(JGOOHEBBDBF(PJOEHKHICFH));
		KGJDHIHOCEI = true;
	}

	[SpecialName]
	public static SteamManager IKBFAFODKLE()
	{
		return IEHNBLNFHJI ?? new GameObject("LoadingStatusText").AddComponent<SteamManager>();
	}

	private void EHDLHBEEHFB(GameOverlayActivated_t IAFAANLMOAG)
	{
		if (IAFAANLMOAG.m_bActive == 0)
		{
		}
	}
}
