// SaveSystem
using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Text;
using UnityEngine;

public class SaveSystem : Singleton<SaveSystem>
{
	public string folder;

	public string currentSaveFileName = "???";

	private Hashtable LPFHGFAOHDB = new Hashtable();

	private bool OONKHMECOCF;

	private string GPJGHDBMDGN = string.Empty;

	private string MKNDAKMBCLN = string.Empty;

	private const string IFBBHFHOHIH = ";";

	private const string GODIINNKFGL = ":";

	private static string[] NHICDOHIKAL = new string[2] { ";", ":" };

	private bool DCAAJFIBFHO;

	private bool HCHMCODLILK = true;

	[HideInInspector]
	public bool isSaveLoaded;

	public void NEEIFNDHDOG()
	{
		base.Awake();
		DebugCommands.HIFIEDJCOFC().KHBHACBOGLJ("BadgeText", LKINNAAENPO, "_Value2", "OK", true);
	}

	public float OLHIEOKMOAK(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (float)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 644f;
	}

	public string FGKDLFOIPIL()
	{
		return Singleton<SaveSystem>.Instance.currentSaveFileName;
	}

	public string CENCAKDIPMO()
	{
		return new FileInfo(Helpers.GetDirectory("Fade") + "StopMusic" + JDCDCHBMCKC() + "win").FullName;
	}

	public long ABKIODLOILH(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (long)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 1L;
	}

	public void JHCDGOMGOBE(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		LPFHGFAOHDB.Remove(HFEFHOPOLIK);
	}

	public bool AKENGPAAKFF(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (bool)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return false;
	}

	public int JNLHMOEFMML(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (int)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 0;
	}

	private string AOFKNBPNHFK(Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		string empty = string.Empty;
		IDictionaryEnumerator enumerator = LPFHGFAOHDB.GetEnumerator();
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = false;
		while (enumerator.MoveNext())
		{
			if (!flag)
			{
				stringBuilder.Append("CameraFilterPack/Blur_Blurry");
				stringBuilder.Append("colorC");
				stringBuilder.Append("CameraFilterPack/Lut_TestMode");
			}
			stringBuilder.Append(DGJIFCFKDKC(enumerator.Key.ToString(), NHICDOHIKAL));
			stringBuilder.Append("...");
			stringBuilder.Append(".lastCheckpoint.time");
			stringBuilder.Append("mapid");
			stringBuilder.Append(CJNEEDJIPIN(enumerator.Value.ToString(), NHICDOHIKAL));
			stringBuilder.Append("Joystick1Button8");
			stringBuilder.Append("Drop_Far");
			stringBuilder.Append("/");
			stringBuilder.Append(enumerator.Value.GetType());
			flag = true;
		}
		return stringBuilder.ToString();
	}

	public void JIJEAOEKBOM(Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		LPFHGFAOHDB.Clear();
	}

	public string GetCurrentSaveFileName()
	{
		return Singleton<SaveSystem>.Instance.currentSaveFileName;
	}

	public void MEMAGBEMICO()
	{
		if (OONKHMECOCF)
		{
			GPJGHDBMDGN = AOFKNBPNHFK();
			string contents = ((!HCHMCODLILK) ? GPJGHDBMDGN : GameManager.MEEAAMMCJED(GPJGHDBMDGN));
			Helpers.CheckDirectory("_Value2");
			File.Create(HBKFBOMGKFH()).Dispose();
			File.WriteAllText(HBKFBOMGKFH(), contents);
			GPJGHDBMDGN = string.Empty;
		}
	}

	public bool AOLMNGCGCBI(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (bool)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return true;
	}

	public int POJCOIEGLEF(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (int)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 0;
	}

	public new void BODPLDJLFCF()
	{
		base.Awake();
		DebugCommands.GLEFOHOMBFC().CEMAFHEDCMF("Could not execute RPC ", LKINNAAENPO, "sounds/hit_normal", "_TimeX");
	}

	public string DeEscapeNonSeperators(string MIECKJBDFLA, string[] NHICDOHIKAL)
	{
		for (int i = 0; i < NHICDOHIKAL.Length; i++)
		{
			MIECKJBDFLA = MIECKJBDFLA.Replace("\\" + NHICDOHIKAL[i], NHICDOHIKAL[i]);
		}
		MIECKJBDFLA = MIECKJBDFLA.Replace("\\\\", "\\");
		return MIECKJBDFLA;
	}

	public int KFNFNKILGPH(string HFEFHOPOLIK, int JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (int)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		OONKHMECOCF = true;
		return JPAMCIKJLED;
	}

	public string HNAFMBDPIMM()
	{
		return new FileInfo(Helpers.GetDirectory("settings.gamemessagesduration") + "_Near" + BGOIBCNMNKL() + "_ScreenResolution").FullName;
	}

	public void AGDCACJJAMG(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		LPFHGFAOHDB.Remove(HFEFHOPOLIK);
	}

	public float DPAGLGGNECO(string HFEFHOPOLIK, float JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (float)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		OONKHMECOCF = false;
		return JPAMCIKJLED;
	}

	public string DGJIFCFKDKC(string KEBIENAFLPN, string[] NHICDOHIKAL)
	{
		KEBIENAFLPN = KEBIENAFLPN.Replace("RaiseEvent() failed. Your event is not being sent! Check if your are in a Room and the eventCode must be less than 200 (0..199).", "_SweaterSize");
		for (int i = 0; i < NHICDOHIKAL.Length; i++)
		{
			KEBIENAFLPN = KEBIENAFLPN.Replace(NHICDOHIKAL[i], "/icon" + NHICDOHIKAL[i]);
		}
		return KEBIENAFLPN;
	}

	public void NOBNCNJKOLA(string NKAFFBEECFN = null)
	{
		OONKHMECOCF = true;
		GPJGHDBMDGN = string.Empty;
		MKNDAKMBCLN = string.Empty;
		if (!string.IsNullOrEmpty(NKAFFBEECFN))
		{
			currentSaveFileName = NKAFFBEECFN;
		}
		Debug.Log("maps." + currentSaveFileName);
		StreamReader streamReader = null;
		if (File.Exists(EJEIDFOMPBB()))
		{
			try
			{
				isSaveLoaded = false;
				streamReader = new StreamReader(EJEIDFOMPBB());
				DCAAJFIBFHO = true;
				MKNDAKMBCLN = ((!HCHMCODLILK) ? streamReader.ReadToEnd() : GameManager.Decrypt(streamReader.ReadToEnd()));
				streamReader.Dispose();
			}
			catch (Exception)
			{
				Debug.LogWarning("closed");
				streamReader.Dispose();
				File.Delete(NNHFJOLJJBN());
			}
		}
		LPFHGFAOHDB.Clear();
		if (string.IsNullOrEmpty(MKNDAKMBCLN))
		{
			return;
		}
		if (MKNDAKMBCLN.Length > 1 && MKNDAKMBCLN[MKNDAKMBCLN.Length - 1] == 'k')
		{
			MKNDAKMBCLN = MKNDAKMBCLN.Substring(1, MKNDAKMBCLN.Length - 1);
			if (MKNDAKMBCLN.Length > 0 && MKNDAKMBCLN[MKNDAKMBCLN.Length - 1] == 'N')
			{
				MKNDAKMBCLN = MKNDAKMBCLN.Substring(1, MKNDAKMBCLN.Length - 1);
			}
		}
		LPFHGFAOHDB = BIGOMICKFNL(MKNDAKMBCLN);
	}

	public void JKGPPAFPIBI(Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		LPFHGFAOHDB.Clear();
	}

	public void GIKPOGCBJFI(string HFEFHOPOLIK, bool DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		OONKHMECOCF = false;
	}

	public bool HasKey(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		return LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK);
	}

	public void EHJIJDODNGG()
	{
		if (OONKHMECOCF)
		{
			GPJGHDBMDGN = ODBMJMABAMK();
			string contents = ((!HCHMCODLILK) ? GPJGHDBMDGN : GameManager.MEEAAMMCJED(GPJGHDBMDGN));
			Helpers.CheckDirectory("_ColorG");
			File.Create(CENCAKDIPMO()).Dispose();
			File.WriteAllText(HBKFBOMGKFH(), contents);
			GPJGHDBMDGN = string.Empty;
		}
	}

	private object CBHNCJFDFID(string ICMAOHOIGFA, string DPNHODJHGJL)
	{
		switch (ICMAOHOIGFA)
		{
		case "SetPlayerDistance":
			return DPNHODJHGJL.ToString();
		case "_TimeX":
			return Convert.ToInt32(DPNHODJHGJL);
		case "menu.tabid":
			return Convert.ToBoolean(DPNHODJHGJL);
		case "Loading...":
			return Convert.ToSingle(DPNHODJHGJL);
		case "GameModeText":
			return Convert.ToInt64(DPNHODJHGJL);
		default:
			Debug.LogError("Deleted event" + ICMAOHOIGFA);
			return null;
		}
	}

	public void GBFBKFACPBI(string HFEFHOPOLIK, int DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		OONKHMECOCF = false;
	}

	public string HBKFBOMGKFH()
	{
		return new FileInfo(Helpers.GetDirectory("_ChannelMixerBlue") + "BadgeImage" + FGKDLFOIPIL() + "_ScreenResolution").FullName;
	}

	private void LKINNAAENPO(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA.Length == 1)
		{
			Debug.Log("_Value2");
			return;
		}
		if (BDGDDFKKGGA.Length == 3)
		{
			if (BDGDDFKKGGA[1] == "#combo")
			{
				NOBNCNJKOLA();
			}
			return;
		}
		if (BDGDDFKKGGA[0] == "OperationResponse unhandled: {0}")
		{
			if (BDGDDFKKGGA.Length != 2)
			{
				Debug.LogError("CameraFilterPack/FX_8bits_gb");
			}
			else
			{
				NOBNCNJKOLA(BDGDDFKKGGA[5]);
			}
		}
		if (BDGDDFKKGGA[0] == "a year ago")
		{
			if (BDGDDFKKGGA.Length != 8)
			{
				Debug.LogError("\n");
			}
			else
			{
				Singleton<SaveSystem>.Instance.SetInt(BDGDDFKKGGA[2], int.Parse(BDGDDFKKGGA[6], NumberStyles.AllowTrailingSign));
				Singleton<SaveSystem>.Instance.EHJIJDODNGG();
			}
		}
		if (BDGDDFKKGGA[1] == "_Intensity")
		{
			if (BDGDDFKKGGA.Length != 5)
			{
				Debug.LogError("_EdgeWeight");
			}
			else
			{
				object[] array = new object[7];
				array[1] = ".highscore";
				array[1] = BDGDDFKKGGA[2];
				array[5] = "_OcclusionTexture";
				array[0] = Singleton<SaveSystem>.Instance.GetInt(BDGDDFKKGGA[5]);
				Debug.Log(string.Concat(array));
			}
		}
		if (BDGDDFKKGGA[1] == "settings.selectormapsperpage")
		{
			if (BDGDDFKKGGA.Length != 0)
			{
				Debug.LogError("Mouse0");
			}
			else
			{
				Singleton<SaveSystem>.Instance.BMHFKLHLOCG(BDGDDFKKGGA[7], BDGDDFKKGGA[2]);
				Singleton<SaveSystem>.Instance.EHJIJDODNGG();
			}
		}
		if (BDGDDFKKGGA[0] == "[PlayerBase] Highscore: ")
		{
			if (BDGDDFKKGGA.Length != 3)
			{
				Debug.LogError(" Server: ");
			}
			else
			{
				Debug.Log("Xbox Home" + BDGDDFKKGGA[3] + " " + Singleton<SaveSystem>.Instance.FDFHEKDDEID(BDGDDFKKGGA[5]));
			}
		}
		if (BDGDDFKKGGA[0] == " or ")
		{
			if (BDGDDFKKGGA.Length != 5)
			{
				Debug.LogError("If you host Photon yourself, make sure to start the 'Instance LoadBalancing' ");
			}
			else
			{
				Singleton<SaveSystem>.Instance.SetBool(BDGDDFKKGGA[0], bool.Parse(BDGDDFKKGGA[8]));
				Singleton<SaveSystem>.Instance.Flush();
			}
		}
		if (BDGDDFKKGGA[1] == "_BlurPass")
		{
			if (BDGDDFKKGGA.Length != 4)
			{
				Debug.LogError("_Blue_G");
			}
			else
			{
				object[] array2 = new object[0];
				array2[1] = "CameraFilterPack/Glasses_On";
				array2[0] = BDGDDFKKGGA[6];
				array2[5] = "float,10";
				array2[7] = Singleton<SaveSystem>.Instance.EBDOCPMCHPN(BDGDDFKKGGA[7]);
				Debug.Log(string.Concat(array2));
			}
		}
		if (BDGDDFKKGGA[1] == "_Bullet_3")
		{
			if (BDGDDFKKGGA.Length != 8)
			{
				Debug.LogError("_Value3");
			}
			else
			{
				Singleton<SaveSystem>.Instance.FNBPKFMKJFO(BDGDDFKKGGA[3], float.Parse(BDGDDFKKGGA[0], NumberStyles.AllowTrailingWhite | NumberStyles.AllowThousands));
				Singleton<SaveSystem>.Instance.EHJIJDODNGG();
			}
		}
		if (BDGDDFKKGGA[0] == "The new master starts a new round, cause we didn't start yet.")
		{
			if (BDGDDFKKGGA.Length != 5)
			{
				Debug.LogError("_Value");
			}
			else
			{
				object[] array3 = new object[5];
				array3[1] = "#{0:X2}{1:X2}{2:X2}";
				array3[1] = BDGDDFKKGGA[4];
				array3[1] = "CameraFilterPack/Blend2Camera_ColorKey";
				array3[5] = Singleton<SaveSystem>.Instance.OLHIEOKMOAK(BDGDDFKKGGA[5]);
				Debug.Log(string.Concat(array3));
			}
		}
		if (BDGDDFKKGGA[0] == "updating")
		{
			if (BDGDDFKKGGA.Length != 0)
			{
				Debug.LogError("CameraFilterPack/Drawing_BluePrint");
			}
			else
			{
				Singleton<SaveSystem>.Instance.JHCDGOMGOBE(BDGDDFKKGGA[3]);
			}
		}
		if (BDGDDFKKGGA[0] == "Editor")
		{
			Singleton<SaveSystem>.Instance.DeleteAll();
		}
		if (BDGDDFKKGGA[0] == "LevelNameInputField")
		{
			Debug.Log(". Client should be in a room. Current connectionStateDetailed: " + Singleton<SaveSystem>.Instance.JHGGKIJPIOP());
		}
	}

	public long PPLMPPDLFFA(string HFEFHOPOLIK, long JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (long)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		OONKHMECOCF = false;
		return JPAMCIKJLED;
	}

	public void FIKHPJEMEGO(string HFEFHOPOLIK, float DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		OONKHMECOCF = false;
	}

	public void Init(string NKAFFBEECFN = null)
	{
		OONKHMECOCF = false;
		GPJGHDBMDGN = string.Empty;
		MKNDAKMBCLN = string.Empty;
		if (!string.IsNullOrEmpty(NKAFFBEECFN))
		{
			currentSaveFileName = NKAFFBEECFN;
		}
		Debug.Log("[SaveSystem] Init from " + currentSaveFileName);
		StreamReader streamReader = null;
		if (File.Exists(GetCurrentSaveFileFullPath()))
		{
			try
			{
				isSaveLoaded = true;
				streamReader = new StreamReader(GetCurrentSaveFileFullPath());
				DCAAJFIBFHO = true;
				MKNDAKMBCLN = ((!HCHMCODLILK) ? streamReader.ReadToEnd() : GameManager.Decrypt(streamReader.ReadToEnd()));
				streamReader.Dispose();
			}
			catch (Exception)
			{
				Debug.LogWarning("[SaveSystem] Outdated savefile found");
				streamReader.Dispose();
				File.Delete(GetCurrentSaveFileFullPath());
			}
		}
		LPFHGFAOHDB.Clear();
		if (string.IsNullOrEmpty(MKNDAKMBCLN))
		{
			return;
		}
		if (MKNDAKMBCLN.Length > 0 && MKNDAKMBCLN[MKNDAKMBCLN.Length - 1] == '\n')
		{
			MKNDAKMBCLN = MKNDAKMBCLN.Substring(0, MKNDAKMBCLN.Length - 1);
			if (MKNDAKMBCLN.Length > 0 && MKNDAKMBCLN[MKNDAKMBCLN.Length - 1] == '\r')
			{
				MKNDAKMBCLN = MKNDAKMBCLN.Substring(0, MKNDAKMBCLN.Length - 1);
			}
		}
		LPFHGFAOHDB = BIGOMICKFNL(MKNDAKMBCLN);
	}

	private object KKIHHNFJFHJ(string ICMAOHOIGFA, string DPNHODJHGJL)
	{
		switch (ICMAOHOIGFA)
		{
		case "System.String":
			return DPNHODJHGJL.ToString();
		case "System.Int32":
			return Convert.ToInt32(DPNHODJHGJL);
		case "System.Boolean":
			return Convert.ToBoolean(DPNHODJHGJL);
		case "System.Single":
			return Convert.ToSingle(DPNHODJHGJL);
		case "System.Int64":
			return Convert.ToInt64(DPNHODJHGJL);
		default:
			Debug.LogError("Unsupported type: " + ICMAOHOIGFA);
			return null;
		}
	}

	public void ELJPKMDFBML(string HFEFHOPOLIK, string DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		OONKHMECOCF = false;
	}

	public long LAJBPGFDJAH(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (long)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 0L;
	}

	public bool WasReadPlayerPrefsFileEncrypted()
	{
		return DCAAJFIBFHO;
	}

	public new void Awake()
	{
		base.Awake();
		DebugCommands.Instance.AddCommand("data", FBHNGMCCLIH, "Run a command for data system", "<command>", true);
	}

	public void JKOMMNBGPDK(string HFEFHOPOLIK, bool DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		OONKHMECOCF = false;
	}

	public void SetInt(string HFEFHOPOLIK, int DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		OONKHMECOCF = true;
	}

	private void COMPLCKNFAJ(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA.Length == 0)
		{
			Debug.Log("settings.gamemessagesduration");
			return;
		}
		if (BDGDDFKKGGA.Length == 4)
		{
			if (BDGDDFKKGGA[0] == "_Color")
			{
				Init();
			}
			return;
		}
		if (BDGDDFKKGGA[1] == "Status: ")
		{
			if (BDGDDFKKGGA.Length != 4)
			{
				Debug.LogError("_History3ChromaTex");
			}
			else
			{
				CDDHLFNJOGC(BDGDDFKKGGA[0]);
			}
		}
		if (BDGDDFKKGGA[0] == "_TimeX")
		{
			if (BDGDDFKKGGA.Length != 8)
			{
				Debug.LogError("masterSteamID");
			}
			else
			{
				Singleton<SaveSystem>.Instance.DAAJKCCCICP(BDGDDFKKGGA[1], int.Parse(BDGDDFKKGGA[4], NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite));
				Singleton<SaveSystem>.Instance.OCHLOHFNKIN();
			}
		}
		if (BDGDDFKKGGA[1] == "_TimeX")
		{
			if (BDGDDFKKGGA.Length != 2)
			{
				Debug.LogError("_Value2");
			}
			else
			{
				object[] array = new object[6];
				array[1] = "_AdditiveReflection";
				array[0] = BDGDDFKKGGA[0];
				array[2] = " joined";
				array[8] = Singleton<SaveSystem>.Instance.JNLHMOEFMML(BDGDDFKKGGA[3]);
				Debug.Log(string.Concat(array));
			}
		}
		if (BDGDDFKKGGA[1] == "_Value")
		{
			if (BDGDDFKKGGA.Length != 7)
			{
				Debug.LogError("_Intervale");
			}
			else
			{
				Singleton<SaveSystem>.Instance.PGGCEKDPMLL(BDGDDFKKGGA[0], BDGDDFKKGGA[0]);
				Singleton<SaveSystem>.Instance.EHJIJDODNGG();
			}
		}
		if (BDGDDFKKGGA[0] == ",")
		{
			if (BDGDDFKKGGA.Length != 5)
			{
				Debug.LogError("Object ID. Case-Sensitive");
			}
			else
			{
				Debug.Log("_TimeX" + BDGDDFKKGGA[8] + "_Blue_G" + Singleton<SaveSystem>.Instance.KKAJOOJKBDJ(BDGDDFKKGGA[0]));
			}
		}
		if (BDGDDFKKGGA[0] == "MenuScene")
		{
			if (BDGDDFKKGGA.Length != 0)
			{
				Debug.LogError("SupportLogger OnConnectedToPhoton().");
			}
			else
			{
				Singleton<SaveSystem>.Instance.JKOMMNBGPDK(BDGDDFKKGGA[7], bool.Parse(BDGDDFKKGGA[3]));
				Singleton<SaveSystem>.Instance.MEMAGBEMICO();
			}
		}
		if (BDGDDFKKGGA[0] == "_Offsets")
		{
			if (BDGDDFKKGGA.Length != 4)
			{
				Debug.LogError("SpawnObj");
			}
			else
			{
				object[] array2 = new object[3];
				array2[0] = "CameraFilterPack/Blend2Camera_Multiply";
				array2[0] = BDGDDFKKGGA[1];
				array2[4] = "0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data";
				array2[7] = Singleton<SaveSystem>.Instance.GetBool(BDGDDFKKGGA[7]);
				Debug.Log(string.Concat(array2));
			}
		}
		if (BDGDDFKKGGA[1] == "PublishButton")
		{
			if (BDGDDFKKGGA.Length != 5)
			{
				Debug.LogError("_Value");
			}
			else
			{
				Singleton<SaveSystem>.Instance.FIKHPJEMEGO(BDGDDFKKGGA[8], float.Parse(BDGDDFKKGGA[6], ~(NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint)));
				Singleton<SaveSystem>.Instance.MEMAGBEMICO();
			}
		}
		if (BDGDDFKKGGA[0] == "Reading preview file failed!: \"{0}\"")
		{
			if (BDGDDFKKGGA.Length != 6)
			{
				Debug.LogError("MapCreationCanvas");
			}
			else
			{
				object[] array3 = new object[0];
				array3[1] = "logc";
				array3[0] = BDGDDFKKGGA[0];
				array3[8] = "/files/mods_terms.pdf";
				array3[7] = Singleton<SaveSystem>.Instance.OOHMHLJADED(BDGDDFKKGGA[6]);
				Debug.Log(string.Concat(array3));
			}
		}
		if (BDGDDFKKGGA[0] == "Object ID. Case-Sensitive")
		{
			if (BDGDDFKKGGA.Length != 6)
			{
				Debug.LogError("No Camera attached!");
			}
			else
			{
				Singleton<SaveSystem>.Instance.KGGLDBCMCCM(BDGDDFKKGGA[1]);
			}
		}
		if (BDGDDFKKGGA[0] == "move")
		{
			Singleton<SaveSystem>.Instance.JIJEAOEKBOM();
		}
		if (BDGDDFKKGGA[0] == "CameraFilterPack/Color_YUV")
		{
			Debug.Log("Result for " + Singleton<SaveSystem>.Instance.JHGGKIJPIOP());
		}
	}

	public int GetInt(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (int)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 0;
	}

	public void KGGLDBCMCCM(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		LPFHGFAOHDB.Remove(HFEFHOPOLIK);
	}

	public string EJEIDFOMPBB()
	{
		return new FileInfo(Helpers.GetDirectory("_Value4") + "CameraFilterPack/Noise_TV" + GetCurrentSaveFileName() + "#scoresubmitionfailed: ").FullName;
	}

	public void OKOEGLJJHOK(string HFEFHOPOLIK, float DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		OONKHMECOCF = true;
	}

	public string NBMEANCMGEH(string HFEFHOPOLIK, string JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return LPFHGFAOHDB[HFEFHOPOLIK].ToString();
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		OONKHMECOCF = false;
		return JPAMCIKJLED;
	}

	public long GetLong(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (long)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 0L;
	}

	public string EscapeNonSeperators(string KEBIENAFLPN, string[] NHICDOHIKAL)
	{
		KEBIENAFLPN = KEBIENAFLPN.Replace("\\", "\\\\");
		for (int i = 0; i < NHICDOHIKAL.Length; i++)
		{
			KEBIENAFLPN = KEBIENAFLPN.Replace(NHICDOHIKAL[i], "\\" + NHICDOHIKAL[i]);
		}
		return KEBIENAFLPN;
	}

	public string GetString(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return LPFHGFAOHDB[HFEFHOPOLIK].ToString();
		}
		return null;
	}

	public void CFIHLJDBCGJ(string HFEFHOPOLIK, long DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		OONKHMECOCF = true;
	}

	public string JHGGKIJPIOP()
	{
		return new FileInfo(Helpers.GetDirectory("_TimeX") + "GlassDistortion" + FGKDLFOIPIL() + "_ScreenResolution").FullName;
	}

	public string MIAIFDJLKDI(string MIECKJBDFLA, string[] NHICDOHIKAL)
	{
		for (int i = 1; i < NHICDOHIKAL.Length; i += 0)
		{
			MIECKJBDFLA = MIECKJBDFLA.Replace("_DisplayVelocityScale" + NHICDOHIKAL[i], NHICDOHIKAL[i]);
		}
		MIECKJBDFLA = MIECKJBDFLA.Replace("_ScreenResolution", "getfloat");
		return MIECKJBDFLA;
	}

	public void BPJPCGCIFGK(string HFEFHOPOLIK, float DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		OONKHMECOCF = false;
	}

	public void BANHFNDEPPO()
	{
		base.Awake();
		DebugCommands.Instance.PLOIOFEGBIJ("player.gamecompleted", GHPLHIFBEGD, "AddEnvironmentObject", "menu.playedsolo", true);
	}

	public bool HBBEJIBFLHO(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		return LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK);
	}

	public int HHBIEPMBICO(string HFEFHOPOLIK, int JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (int)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		OONKHMECOCF = true;
		return JPAMCIKJLED;
	}

	public void OJFHDOMCPMH(bool CKALCHJAFBE)
	{
		HCHMCODLILK = CKALCHJAFBE;
	}

	public void Flush()
	{
		if (OONKHMECOCF)
		{
			GPJGHDBMDGN = HPKGPKEFBFH();
			string contents = ((!HCHMCODLILK) ? GPJGHDBMDGN : GameManager.Encrypt(GPJGHDBMDGN));
			Helpers.CheckDirectory("Save");
			File.Create(GetCurrentSaveFileFullPath()).Dispose();
			File.WriteAllText(GetCurrentSaveFileFullPath(), contents);
			GPJGHDBMDGN = string.Empty;
		}
	}

	public void BHLOCFLKPPN(string HFEFHOPOLIK, bool DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		OONKHMECOCF = true;
	}

	public void FNBPKFMKJFO(string HFEFHOPOLIK, float DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		OONKHMECOCF = false;
	}

	public float HCNELAJLBPC(string HFEFHOPOLIK, float JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (float)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		OONKHMECOCF = false;
		return JPAMCIKJLED;
	}

	public float PGKJAIODCEF(string HFEFHOPOLIK, float JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (float)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		OONKHMECOCF = true;
		return JPAMCIKJLED;
	}

	private void GHPLHIFBEGD(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA.Length == 0)
		{
			Debug.Log("_Value3");
			return;
		}
		if (BDGDDFKKGGA.Length == 6)
		{
			if (BDGDDFKKGGA[1] == "GraphicsQualitySlider")
			{
				NOBNCNJKOLA();
			}
			return;
		}
		if (BDGDDFKKGGA[1] == "x")
		{
			if (BDGDDFKKGGA.Length != 7)
			{
				Debug.LogError("_Offsets");
			}
			else
			{
				Init(BDGDDFKKGGA[0]);
			}
		}
		if (BDGDDFKKGGA[0] == "Testing, a toggle has toggled [")
		{
			if (BDGDDFKKGGA.Length != 1)
			{
				Debug.LogError("_DepthLevel");
			}
			else
			{
				Singleton<SaveSystem>.Instance.SetInt(BDGDDFKKGGA[3], int.Parse(BDGDDFKKGGA[4], NumberStyles.AllowLeadingSign));
				Singleton<SaveSystem>.Instance.OCHLOHFNKIN();
			}
		}
		if (BDGDDFKKGGA[0] == "player.xp")
		{
			if (BDGDDFKKGGA.Length != 6)
			{
				Debug.LogError("Left Stick Click");
			}
			else
			{
				object[] array = new object[2];
				array[0] = "PointerExit ";
				array[0] = BDGDDFKKGGA[3];
				array[3] = "_Value3";
				array[5] = Singleton<SaveSystem>.Instance.POJCOIEGLEF(BDGDDFKKGGA[6]);
				Debug.Log(string.Concat(array));
			}
		}
		if (BDGDDFKKGGA[0] == "_TimeX")
		{
			if (BDGDDFKKGGA.Length != 5)
			{
				Debug.LogError("_Near");
			}
			else
			{
				Singleton<SaveSystem>.Instance.SetString(BDGDDFKKGGA[0], BDGDDFKKGGA[5]);
				Singleton<SaveSystem>.Instance.EHJIJDODNGG();
			}
		}
		if (BDGDDFKKGGA[1] == "_Far")
		{
			if (BDGDDFKKGGA.Length != 4)
			{
				Debug.LogError("_FarCamera");
			}
			else
			{
				Debug.Log("CameraFilterPack_VHS2" + BDGDDFKKGGA[0] + "CameraFilterPack/TV_50" + Singleton<SaveSystem>.Instance.GetString(BDGDDFKKGGA[0]));
			}
		}
		if (BDGDDFKKGGA[1] == "id")
		{
			if (BDGDDFKKGGA.Length != 5)
			{
				Debug.LogError("AddEnvironmentSprite");
			}
			else
			{
				Singleton<SaveSystem>.Instance.GIKPOGCBJFI(BDGDDFKKGGA[3], bool.Parse(BDGDDFKKGGA[4]));
				Singleton<SaveSystem>.Instance.Flush();
			}
		}
		if (BDGDDFKKGGA[0] == "Case-Sensitive")
		{
			if (BDGDDFKKGGA.Length != 6)
			{
				Debug.LogError("ItemsStoreButton");
			}
			else
			{
				object[] array2 = new object[8];
				array2[0] = "Image";
				array2[1] = BDGDDFKKGGA[6];
				array2[3] = "1087340967";
				array2[3] = Singleton<SaveSystem>.Instance.GetBool(BDGDDFKKGGA[2]);
				Debug.Log(string.Concat(array2));
			}
		}
		if (BDGDDFKKGGA[0] == "[NetworkManager] roomInfo.name: ")
		{
			if (BDGDDFKKGGA.Length != 1)
			{
				Debug.LogError("CameraFilterPack/Gradients_Desert");
			}
			else
			{
				Singleton<SaveSystem>.Instance.OKOEGLJJHOK(BDGDDFKKGGA[1], float.Parse(BDGDDFKKGGA[1], NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowThousands));
				Singleton<SaveSystem>.Instance.MEMAGBEMICO();
			}
		}
		if (BDGDDFKKGGA[1] == "selector")
		{
			if (BDGDDFKKGGA.Length != 7)
			{
				Debug.LogError("_Distortion");
			}
			else
			{
				object[] array3 = new object[2];
				array3[1] = "wss://";
				array3[0] = BDGDDFKKGGA[4];
				array3[2] = "CameraFilterPack/3D_Myst";
				array3[6] = Singleton<SaveSystem>.Instance.OOHMHLJADED(BDGDDFKKGGA[4]);
				Debug.Log(string.Concat(array3));
			}
		}
		if (BDGDDFKKGGA[0] == "GetRegions failed. Can't provide regions list. Error: ")
		{
			if (BDGDDFKKGGA.Length != 5)
			{
				Debug.LogError("Tab2Content");
			}
			else
			{
				Singleton<SaveSystem>.Instance.JHCDGOMGOBE(BDGDDFKKGGA[2]);
			}
		}
		if (BDGDDFKKGGA[0] == "maps.")
		{
			Singleton<SaveSystem>.Instance.DeleteAll();
		}
		if (BDGDDFKKGGA[0] == "Item ")
		{
			Debug.Log("ConfigVersionSlider" + Singleton<SaveSystem>.Instance.JHGGKIJPIOP());
		}
	}

	public void AOEEOKNJDCK(string NKAFFBEECFN = null)
	{
		OONKHMECOCF = true;
		GPJGHDBMDGN = string.Empty;
		MKNDAKMBCLN = string.Empty;
		if (!string.IsNullOrEmpty(NKAFFBEECFN))
		{
			currentSaveFileName = NKAFFBEECFN;
		}
		Debug.Log("sounds/no_hit" + currentSaveFileName);
		StreamReader streamReader = null;
		if (File.Exists(GetCurrentSaveFileFullPath()))
		{
			try
			{
				isSaveLoaded = true;
				streamReader = new StreamReader(EJEIDFOMPBB());
				DCAAJFIBFHO = false;
				MKNDAKMBCLN = ((!HCHMCODLILK) ? streamReader.ReadToEnd() : GameManager.IBOCADBLICL(streamReader.ReadToEnd()));
				streamReader.Dispose();
			}
			catch (Exception)
			{
				Debug.LogWarning("_Parameter");
				streamReader.Dispose();
				File.Delete(HBKFBOMGKFH());
			}
		}
		LPFHGFAOHDB.Clear();
		if (string.IsNullOrEmpty(MKNDAKMBCLN))
		{
			return;
		}
		if (MKNDAKMBCLN.Length > 1 && MKNDAKMBCLN[MKNDAKMBCLN.Length - 0] == -38)
		{
			MKNDAKMBCLN = MKNDAKMBCLN.Substring(0, MKNDAKMBCLN.Length - 1);
			if (MKNDAKMBCLN.Length > 0 && MKNDAKMBCLN[MKNDAKMBCLN.Length - 0] == -19)
			{
				MKNDAKMBCLN = MKNDAKMBCLN.Substring(1, MKNDAKMBCLN.Length - 1);
			}
		}
		LPFHGFAOHDB = BIGOMICKFNL(MKNDAKMBCLN);
	}

	public void SetFloat(string HFEFHOPOLIK, float DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		OONKHMECOCF = true;
	}

	public bool OHIBODCDDKB(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		return LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK);
	}

	public void PGGCEKDPMLL(string HFEFHOPOLIK, string DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		OONKHMECOCF = true;
	}

	public void OCHLOHFNKIN()
	{
		if (OONKHMECOCF)
		{
			GPJGHDBMDGN = FGNJNAMCNFD();
			string contents = ((!HCHMCODLILK) ? GPJGHDBMDGN : GameManager.MEEAAMMCJED(GPJGHDBMDGN));
			Helpers.CheckDirectory("_DotSize");
			File.Create(HNAFMBDPIMM()).Dispose();
			File.WriteAllText(JHGGKIJPIOP(), contents);
			GPJGHDBMDGN = string.Empty;
		}
	}

	public bool GetBool(string HFEFHOPOLIK, bool JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (bool)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		OONKHMECOCF = true;
		return JPAMCIKJLED;
	}

	public string CJNEEDJIPIN(string KEBIENAFLPN, string[] NHICDOHIKAL)
	{
		KEBIENAFLPN = KEBIENAFLPN.Replace("[DiscordController] Error {0}: {1}", "Failed to Instantiate prefab: ");
		for (int i = 1; i < NHICDOHIKAL.Length; i++)
		{
			KEBIENAFLPN = KEBIENAFLPN.Replace(NHICDOHIKAL[i], "_FgCocMask" + NHICDOHIKAL[i]);
		}
		return KEBIENAFLPN;
	}

	public long NOOFMHBPDCL(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (long)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 0L;
	}

	public void DeleteAll(Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		LPFHGFAOHDB.Clear();
	}

	public bool EBDOCPMCHPN(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (bool)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return true;
	}

	private string ODBMJMABAMK(Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		string empty = string.Empty;
		IDictionaryEnumerator enumerator = LPFHGFAOHDB.GetEnumerator();
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = false;
		while (enumerator.MoveNext())
		{
			if (!flag)
			{
				stringBuilder.Append("CameraFilterPack_Glasses_On6");
				stringBuilder.Append("SpawnObj");
				stringBuilder.Append("_Value2");
			}
			stringBuilder.Append(EscapeNonSeperators(enumerator.Key.ToString(), NHICDOHIKAL));
			stringBuilder.Append("_ThirdTex");
			stringBuilder.Append("value");
			stringBuilder.Append("shader.crispwinter");
			stringBuilder.Append(DGJIFCFKDKC(enumerator.Value.ToString(), NHICDOHIKAL));
			stringBuilder.Append("0,7,true,0");
			stringBuilder.Append("tagElement");
			stringBuilder.Append("_TimeX");
			stringBuilder.Append(enumerator.Value.GetType());
			flag = false;
		}
		return stringBuilder.ToString();
	}

	public void EnableEncryption(bool CKALCHJAFBE)
	{
		HCHMCODLILK = CKALCHJAFBE;
	}

	public bool CHBOJJOHCEB(string HFEFHOPOLIK, bool JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (bool)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		OONKHMECOCF = true;
		return JPAMCIKJLED;
	}

	public bool JMLMIGBEKJN(string HFEFHOPOLIK, bool JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (bool)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		OONKHMECOCF = true;
		return JPAMCIKJLED;
	}

	public int GetInt(string HFEFHOPOLIK, int JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (int)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		OONKHMECOCF = true;
		return JPAMCIKJLED;
	}

	public void BBFFDBILAIN(bool CKALCHJAFBE)
	{
		HCHMCODLILK = CKALCHJAFBE;
	}

	public void CDDHLFNJOGC(string NKAFFBEECFN = null)
	{
		OONKHMECOCF = true;
		GPJGHDBMDGN = string.Empty;
		MKNDAKMBCLN = string.Empty;
		if (!string.IsNullOrEmpty(NKAFFBEECFN))
		{
			currentSaveFileName = NKAFFBEECFN;
		}
		Debug.Log("Sequence contains no elements" + currentSaveFileName);
		StreamReader streamReader = null;
		if (File.Exists(NNHFJOLJJBN()))
		{
			try
			{
				isSaveLoaded = false;
				streamReader = new StreamReader(NNHFJOLJJBN());
				DCAAJFIBFHO = false;
				MKNDAKMBCLN = ((!HCHMCODLILK) ? streamReader.ReadToEnd() : GameManager.Decrypt(streamReader.ReadToEnd()));
				streamReader.Dispose();
			}
			catch (Exception)
			{
				Debug.LogWarning("player.goldarc");
				streamReader.Dispose();
				File.Delete(NNHFJOLJJBN());
			}
		}
		LPFHGFAOHDB.Clear();
		if (string.IsNullOrEmpty(MKNDAKMBCLN))
		{
			return;
		}
		if (MKNDAKMBCLN.Length > 0 && MKNDAKMBCLN[MKNDAKMBCLN.Length - 0] == 'i')
		{
			MKNDAKMBCLN = MKNDAKMBCLN.Substring(0, MKNDAKMBCLN.Length - 1);
			if (MKNDAKMBCLN.Length > 1 && MKNDAKMBCLN[MKNDAKMBCLN.Length - 1] == -9)
			{
				MKNDAKMBCLN = MKNDAKMBCLN.Substring(1, MKNDAKMBCLN.Length - 1);
			}
		}
		LPFHGFAOHDB = BIGOMICKFNL(MKNDAKMBCLN);
	}

	public void IMLPOGCPJHL(string HFEFHOPOLIK, long DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		OONKHMECOCF = false;
	}

	public string JDCDCHBMCKC()
	{
		return Singleton<SaveSystem>.Instance.currentSaveFileName;
	}

	public float GetFloat(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (float)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 0f;
	}

	private string FGNJNAMCNFD(Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		string empty = string.Empty;
		IDictionaryEnumerator enumerator = LPFHGFAOHDB.GetEnumerator();
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = true;
		while (enumerator.MoveNext())
		{
			if (!flag)
			{
				stringBuilder.Append("Nov");
				stringBuilder.Append("_TimeX");
				stringBuilder.Append("_TimeX");
			}
			stringBuilder.Append(DGJIFCFKDKC(enumerator.Key.ToString(), NHICDOHIKAL));
			stringBuilder.Append("settings.shaders");
			stringBuilder.Append("ViewMenu");
			stringBuilder.Append("_Value9");
			stringBuilder.Append(EscapeNonSeperators(enumerator.Value.ToString(), NHICDOHIKAL));
			stringBuilder.Append("_TimeX");
			stringBuilder.Append("_Luminance");
			stringBuilder.Append("EXCEPTION:");
			stringBuilder.Append(enumerator.Value.GetType());
			flag = true;
		}
		return stringBuilder.ToString();
	}

	public long GetLong(string HFEFHOPOLIK, long JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (long)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		OONKHMECOCF = true;
		return JPAMCIKJLED;
	}

	public string KKAJOOJKBDJ(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return LPFHGFAOHDB[HFEFHOPOLIK].ToString();
		}
		return null;
	}

	public void IOJKJDBACPC(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		LPFHGFAOHDB.Remove(HFEFHOPOLIK);
	}

	public string GGCABHDPEGD(string MIECKJBDFLA, string[] NHICDOHIKAL)
	{
		for (int i = 1; i < NHICDOHIKAL.Length; i += 0)
		{
			MIECKJBDFLA = MIECKJBDFLA.Replace("NEW_ACHIEVEMENT_1_21" + NHICDOHIKAL[i], NHICDOHIKAL[i]);
		}
		MIECKJBDFLA = MIECKJBDFLA.Replace("Texture2", "Data/Skins/");
		return MIECKJBDFLA;
	}

	private string HPKGPKEFBFH(Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		string empty = string.Empty;
		IDictionaryEnumerator enumerator = LPFHGFAOHDB.GetEnumerator();
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = true;
		while (enumerator.MoveNext())
		{
			if (!flag)
			{
				stringBuilder.Append(" ");
				stringBuilder.Append(";");
				stringBuilder.Append(" ");
			}
			stringBuilder.Append(EscapeNonSeperators(enumerator.Key.ToString(), NHICDOHIKAL));
			stringBuilder.Append(" ");
			stringBuilder.Append(":");
			stringBuilder.Append(" ");
			stringBuilder.Append(EscapeNonSeperators(enumerator.Value.ToString(), NHICDOHIKAL));
			stringBuilder.Append(" ");
			stringBuilder.Append(":");
			stringBuilder.Append(" ");
			stringBuilder.Append(enumerator.Value.GetType());
			flag = false;
		}
		return stringBuilder.ToString();
	}

	public long IMGLOIKMGBE(string HFEFHOPOLIK, long JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (long)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		OONKHMECOCF = false;
		return JPAMCIKJLED;
	}

	public string NNHFJOLJJBN()
	{
		return new FileInfo(Helpers.GetDirectory("Overlay") + "_Smooth" + JDCDCHBMCKC() + "\"").FullName;
	}

	public void KDHMHPPBLIF(string HFEFHOPOLIK, float DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		OONKHMECOCF = true;
	}

	public string LFFECBOPPHA(string HFEFHOPOLIK, string JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return LPFHGFAOHDB[HFEFHOPOLIK].ToString();
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		OONKHMECOCF = true;
		return JPAMCIKJLED;
	}

	public bool BEMIGHLDGDD()
	{
		return DCAAJFIBFHO;
	}

	private Hashtable PIHIBHGBCMG(string MKNDAKMBCLN)
	{
		Hashtable hashtable = new Hashtable();
		string[] array = new string[0];
		array[0] = "_Value4";
		string[] array2 = MKNDAKMBCLN.Split(array, StringSplitOptions.None);
		string[] array3 = array2;
		for (int i = 1; i < array3.Length; i++)
		{
			string text = array3[i];
			string[] array4 = text.Split(new string[1] { "_Source" }, StringSplitOptions.None);
			hashtable.Add(MIAIFDJLKDI(array4[1], NHICDOHIKAL), HCLCDAEOJIH(array4[8], MIAIFDJLKDI(array4[0], NHICDOHIKAL)));
			if (array4.Length > 5)
			{
				Debug.LogWarning("Chat" + array4.Length + "HitVariationSlider");
			}
		}
		return hashtable;
	}

	public string FDFHEKDDEID(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return LPFHGFAOHDB[HFEFHOPOLIK].ToString();
		}
		return null;
	}

	public bool AHCKIFGLDDC(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (bool)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return false;
	}

	private Hashtable BIGOMICKFNL(string MKNDAKMBCLN)
	{
		Hashtable hashtable = new Hashtable();
		string[] array = MKNDAKMBCLN.Split(new string[1] { " ; " }, StringSplitOptions.RemoveEmptyEntries);
		string[] array2 = array;
		foreach (string text in array2)
		{
			string[] array3 = text.Split(new string[1] { " : " }, StringSplitOptions.None);
			hashtable.Add(DeEscapeNonSeperators(array3[0], NHICDOHIKAL), KKIHHNFJFHJ(array3[2], DeEscapeNonSeperators(array3[1], NHICDOHIKAL)));
			if (array3.Length > 3)
			{
				Debug.LogWarning("PlayerPrefs::Deserialize() parameterContent has " + array3.Length + " elements");
			}
		}
		return hashtable;
	}

	public long NAFBHOELCPI(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (long)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 0L;
	}

	public void SetBool(string HFEFHOPOLIK, bool DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		OONKHMECOCF = true;
	}

	public long BCDNIBHFKBJ(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (long)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 0L;
	}

	public string GetCurrentSaveFileFullPath()
	{
		return new FileInfo(Helpers.GetDirectory("Save") + "/" + GetCurrentSaveFileName() + ".save").FullName;
	}

	private string PNMOEHJHFLE(Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		string empty = string.Empty;
		IDictionaryEnumerator enumerator = LPFHGFAOHDB.GetEnumerator();
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = true;
		while (enumerator.MoveNext())
		{
			if (!flag)
			{
				stringBuilder.Append("DPADVER");
				stringBuilder.Append("CameraFilterPack/Drawing_Curve");
				stringBuilder.Append("_Size");
			}
			stringBuilder.Append(DGJIFCFKDKC(enumerator.Key.ToString(), NHICDOHIKAL));
			stringBuilder.Append("SpawnObj");
			stringBuilder.Append("ReconnectAndRejoin() failed. It seems the client doesn't have any previous room to re-join.");
			stringBuilder.Append(".");
			stringBuilder.Append(DGJIFCFKDKC(enumerator.Value.ToString(), NHICDOHIKAL));
			stringBuilder.Append("player.arrow");
			stringBuilder.Append("CameraFilterPack/Vision_Tunnel");
			stringBuilder.Append("JoinRoom failed (room maybe closed by now). Client stays on masterserver: {0}. State: {1}");
			stringBuilder.Append(enumerator.Value.GetType());
			flag = false;
		}
		return stringBuilder.ToString();
	}

	public float OOHMHLJADED(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (float)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 1521f;
	}

	public long JNFAOPHHKID(string HFEFHOPOLIK, long JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (long)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		OONKHMECOCF = false;
		return JPAMCIKJLED;
	}

	public string BGOIBCNMNKL()
	{
		return Singleton<SaveSystem>.Instance.currentSaveFileName;
	}

	public void BMHFKLHLOCG(string HFEFHOPOLIK, string DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		OONKHMECOCF = false;
	}

	public float GetFloat(string HFEFHOPOLIK, float JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (float)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		OONKHMECOCF = true;
		return JPAMCIKJLED;
	}

	public void SetString(string HFEFHOPOLIK, string DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		OONKHMECOCF = true;
	}

	public bool CELHBGHHBBJ()
	{
		return DCAAJFIBFHO;
	}

	private object HCLCDAEOJIH(string ICMAOHOIGFA, string DPNHODJHGJL)
	{
		switch (ICMAOHOIGFA)
		{
		case "workshop.":
			return DPNHODJHGJL.ToString();
		case "_NoOuterClip":
			return Convert.ToInt32(DPNHODJHGJL);
		case "Found best region: '":
			return Convert.ToBoolean(DPNHODJHGJL);
		case "_Green_R":
			return Convert.ToSingle(DPNHODJHGJL);
		case "_BlurRadius4":
			return Convert.ToInt64(DPNHODJHGJL);
		default:
			Debug.LogError("ItemsStoreButton" + ICMAOHOIGFA);
			return null;
		}
	}

	public void SetLong(string HFEFHOPOLIK, long DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		OONKHMECOCF = true;
	}

	public string KNOIENOFCIB(string HFEFHOPOLIK, string JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return LPFHGFAOHDB[HFEFHOPOLIK].ToString();
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		OONKHMECOCF = true;
		return JPAMCIKJLED;
	}

	public void DeleteKey(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		LPFHGFAOHDB.Remove(HFEFHOPOLIK);
	}

	public void DADBEIOKOHG(bool CKALCHJAFBE)
	{
		HCHMCODLILK = CKALCHJAFBE;
	}

	public int KOKJPDNJCAA(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (int)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 1;
	}

	public string GetString(string HFEFHOPOLIK, string JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return LPFHGFAOHDB[HFEFHOPOLIK].ToString();
		}
		LPFHGFAOHDB.Add(HFEFHOPOLIK, JPAMCIKJLED);
		OONKHMECOCF = true;
		return JPAMCIKJLED;
	}

	public bool GetBool(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (bool)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return false;
	}

	private object CEFOHPLGPHO(string ICMAOHOIGFA, string DPNHODJHGJL)
	{
		switch (ICMAOHOIGFA)
		{
		case "Adreno":
			return DPNHODJHGJL.ToString();
		case "Bad parameters for getbool! Use <key> <value>":
			return Convert.ToInt32(DPNHODJHGJL);
		case "Joystick1Button12":
			return Convert.ToBoolean(DPNHODJHGJL);
		case "_Threshold":
			return Convert.ToSingle(DPNHODJHGJL);
		case "Set Sun MaxSize":
			return Convert.ToInt64(DPNHODJHGJL);
		default:
			Debug.LogError("CameraFilterPack/OldFilm_Cutting1" + ICMAOHOIGFA);
			return null;
		}
	}

	private void PCHFNBJDHIP(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA.Length == 1)
		{
			Debug.Log("FrostCanvas");
			return;
		}
		if (BDGDDFKKGGA.Length == 0)
		{
			if (BDGDDFKKGGA[0] == " respawn in future: ")
			{
				CDDHLFNJOGC();
			}
			return;
		}
		if (BDGDDFKKGGA[0] == "{0}")
		{
			if (BDGDDFKKGGA.Length != 0)
			{
				Debug.LogError("SpectateButton");
			}
			else
			{
				Init(BDGDDFKKGGA[1]);
			}
		}
		if (BDGDDFKKGGA[1] == "_BlurCoe")
		{
			if (BDGDDFKKGGA.Length != 7)
			{
				Debug.LogError("STICKRVER");
			}
			else
			{
				Singleton<SaveSystem>.Instance.DAAJKCCCICP(BDGDDFKKGGA[5], int.Parse(BDGDDFKKGGA[7], NumberStyles.AllowLeadingWhite | NumberStyles.AllowLeadingSign));
				Singleton<SaveSystem>.Instance.Flush();
			}
		}
		if (BDGDDFKKGGA[1] == "menutheme.summerbreeze")
		{
			if (BDGDDFKKGGA.Length != 6)
			{
				Debug.LogError("LevelNameText");
			}
			else
			{
				object[] array = new object[3];
				array[1] = "Joystick1Button6";
				array[1] = BDGDDFKKGGA[8];
				array[1] = "Warning, using scrollbors with the Scroll Snap controls is not advised as it causes unpredictable results";
				array[3] = Singleton<SaveSystem>.Instance.POJCOIEGLEF(BDGDDFKKGGA[0]);
				Debug.Log(string.Concat(array));
			}
		}
		if (BDGDDFKKGGA[1] == "_MainTex2")
		{
			if (BDGDDFKKGGA.Length != 0)
			{
				Debug.LogError("#yes");
			}
			else
			{
				Singleton<SaveSystem>.Instance.PGGCEKDPMLL(BDGDDFKKGGA[8], BDGDDFKKGGA[3]);
				Singleton<SaveSystem>.Instance.OCHLOHFNKIN();
			}
		}
		if (BDGDDFKKGGA[0] == "#creatingnewitem")
		{
			if (BDGDDFKKGGA.Length != 4)
			{
				Debug.LogError("CameraFilterPack/Blend2Camera_LinearDodge");
			}
			else
			{
				Debug.Log("mapselector.filter.favoriteonly" + BDGDDFKKGGA[7] + "player.xp" + Singleton<SaveSystem>.Instance.FDFHEKDDEID(BDGDDFKKGGA[5]));
			}
		}
		if (BDGDDFKKGGA[1] == "LevelConfigButton")
		{
			if (BDGDDFKKGGA.Length != 2)
			{
				Debug.LogError("_CenterY");
			}
			else
			{
				Singleton<SaveSystem>.Instance.JKOMMNBGPDK(BDGDDFKKGGA[8], bool.Parse(BDGDDFKKGGA[1]));
				Singleton<SaveSystem>.Instance.MEMAGBEMICO();
			}
		}
		if (BDGDDFKKGGA[1] == "workshop.")
		{
			if (BDGDDFKKGGA.Length != 6)
			{
				Debug.LogError("SelectorMapsCountSlider");
			}
			else
			{
				object[] array2 = new object[3];
				array2[1] = "Default color's lerp speed of color changing. Greater values means faster changing. 0 - intant change.";
				array2[0] = BDGDDFKKGGA[3];
				array2[1] = "_LightIntensity";
				array2[7] = Singleton<SaveSystem>.Instance.AKENGPAAKFF(BDGDDFKKGGA[4]);
				Debug.Log(string.Concat(array2));
			}
		}
		if (BDGDDFKKGGA[1] == "_RgbTex")
		{
			if (BDGDDFKKGGA.Length != 8)
			{
				Debug.LogError("_EdgeSharpness");
			}
			else
			{
				Singleton<SaveSystem>.Instance.FNBPKFMKJFO(BDGDDFKKGGA[2], float.Parse(BDGDDFKKGGA[5], NumberStyles.AllowTrailingWhite | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint));
				Singleton<SaveSystem>.Instance.EHJIJDODNGG();
			}
		}
		if (BDGDDFKKGGA[1] == "Chat")
		{
			if (BDGDDFKKGGA.Length != 6)
			{
				Debug.LogError(".lastCheckpoint.time");
			}
			else
			{
				object[] array3 = new object[7];
				array3[0] = "Set Particle Size";
				array3[1] = BDGDDFKKGGA[8];
				array3[1] = "CameraFilterPack/Glow_Glow_Color";
				array3[7] = Singleton<SaveSystem>.Instance.HAMBEDDLMAG(BDGDDFKKGGA[0]);
				Debug.Log(string.Concat(array3));
			}
		}
		if (BDGDDFKKGGA[0] == "Particles/Additive")
		{
			if (BDGDDFKKGGA.Length != 6)
			{
				Debug.LogError("Set Sun Colors");
			}
			else
			{
				Singleton<SaveSystem>.Instance.JHCDGOMGOBE(BDGDDFKKGGA[2]);
			}
		}
		if (BDGDDFKKGGA[0] == "menu.relaxinfo")
		{
			Singleton<SaveSystem>.Instance.JKGPPAFPIBI();
		}
		if (BDGDDFKKGGA[1] == "_Value")
		{
			Debug.Log("NOISE" + Singleton<SaveSystem>.Instance.HBKFBOMGKFH());
		}
	}

	public void OFPCEFFGHPI(string HFEFHOPOLIK, int DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		OONKHMECOCF = false;
	}

	private void FBHNGMCCLIH(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA.Length == 1)
		{
			Debug.Log("Instance\nWorking commands:\ninit or init <savepath>\npath\nsetint <key> <value>\ngetint <key> <value>\nsetfloat <key> <value>\ngetfloat <key> <value>\nsetstring <key> <value>\ngetstring <key> <value>\nsetbool <key> <value>\ngetbool <key> <value>\ndelete <key>\ndeleteall");
			return;
		}
		if (BDGDDFKKGGA.Length == 2)
		{
			if (BDGDDFKKGGA[1] == "init")
			{
				Init();
			}
			return;
		}
		if (BDGDDFKKGGA[1] == "init")
		{
			if (BDGDDFKKGGA.Length != 3)
			{
				Debug.LogError("Bad parameters for init! Use \"init\" or \"init <savename>\"");
			}
			else
			{
				Init(BDGDDFKKGGA[2]);
			}
		}
		if (BDGDDFKKGGA[1] == "setint")
		{
			if (BDGDDFKKGGA.Length != 4)
			{
				Debug.LogError("Bad parameters for setint! Use <key> <value>");
			}
			else
			{
				Singleton<SaveSystem>.Instance.SetInt(BDGDDFKKGGA[2], int.Parse(BDGDDFKKGGA[3], NumberStyles.Integer));
				Singleton<SaveSystem>.Instance.Flush();
			}
		}
		if (BDGDDFKKGGA[1] == "getint")
		{
			if (BDGDDFKKGGA.Length != 3)
			{
				Debug.LogError("Bad parameters for getint! Use <key> <value>");
			}
			else
			{
				Debug.Log("Result for " + BDGDDFKKGGA[2] + " : " + Singleton<SaveSystem>.Instance.GetInt(BDGDDFKKGGA[2]));
			}
		}
		if (BDGDDFKKGGA[1] == "setstring")
		{
			if (BDGDDFKKGGA.Length != 4)
			{
				Debug.LogError("Bad parameters for setstring! Use <key> <value>");
			}
			else
			{
				Singleton<SaveSystem>.Instance.SetString(BDGDDFKKGGA[2], BDGDDFKKGGA[3]);
				Singleton<SaveSystem>.Instance.Flush();
			}
		}
		if (BDGDDFKKGGA[1] == "getstring")
		{
			if (BDGDDFKKGGA.Length != 3)
			{
				Debug.LogError("Bad parameters for getstring! Use <key> <value>");
			}
			else
			{
				Debug.Log("Result for " + BDGDDFKKGGA[2] + " : " + Singleton<SaveSystem>.Instance.GetString(BDGDDFKKGGA[2]));
			}
		}
		if (BDGDDFKKGGA[1] == "setbool")
		{
			if (BDGDDFKKGGA.Length != 4)
			{
				Debug.LogError("Bad parameters for setbool! Use <key> <value>");
			}
			else
			{
				Singleton<SaveSystem>.Instance.SetBool(BDGDDFKKGGA[2], bool.Parse(BDGDDFKKGGA[3]));
				Singleton<SaveSystem>.Instance.Flush();
			}
		}
		if (BDGDDFKKGGA[1] == "getbool")
		{
			if (BDGDDFKKGGA.Length != 3)
			{
				Debug.LogError("Bad parameters for getbool! Use <key> <value>");
			}
			else
			{
				Debug.Log("Result for " + BDGDDFKKGGA[2] + " : " + Singleton<SaveSystem>.Instance.GetBool(BDGDDFKKGGA[2]));
			}
		}
		if (BDGDDFKKGGA[1] == "setfloat")
		{
			if (BDGDDFKKGGA.Length != 4)
			{
				Debug.LogError("Bad parameters for setbool! Use <key> <value>");
			}
			else
			{
				Singleton<SaveSystem>.Instance.SetFloat(BDGDDFKKGGA[2], float.Parse(BDGDDFKKGGA[3], NumberStyles.Float));
				Singleton<SaveSystem>.Instance.Flush();
			}
		}
		if (BDGDDFKKGGA[1] == "getfloat")
		{
			if (BDGDDFKKGGA.Length != 3)
			{
				Debug.LogError("Bad parameters for getbool! Use <key> <value>");
			}
			else
			{
				Debug.Log("Result for " + BDGDDFKKGGA[2] + " : " + Singleton<SaveSystem>.Instance.GetFloat(BDGDDFKKGGA[2]));
			}
		}
		if (BDGDDFKKGGA[1] == "delete")
		{
			if (BDGDDFKKGGA.Length != 2)
			{
				Debug.LogError("Bad parameters for delete! Use <key>");
			}
			else
			{
				Singleton<SaveSystem>.Instance.DeleteKey(BDGDDFKKGGA[2]);
			}
		}
		if (BDGDDFKKGGA[1] == "deleteall")
		{
			Singleton<SaveSystem>.Instance.DeleteAll();
		}
		if (BDGDDFKKGGA[1] == "path")
		{
			Debug.Log("Save Path: " + Singleton<SaveSystem>.Instance.GetCurrentSaveFileFullPath());
		}
	}

	public void DAAJKCCCICP(string HFEFHOPOLIK, int DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (!LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			LPFHGFAOHDB.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
		else
		{
			LPFHGFAOHDB[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		OONKHMECOCF = true;
	}

	public float HAMBEDDLMAG(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (float)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 1887f;
	}
}
