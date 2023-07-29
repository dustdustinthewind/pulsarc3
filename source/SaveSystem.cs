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

	public string FBCCDONJALF()
	{
		return new FileInfo(Helpers.GetDirectory(" GameServer:") + "Hidden/Image Effects/Cinematic/AmbientOcclusion" + GetCurrentSaveFileName() + ",").FullName;
	}

	public string GetCurrentSaveFileFullPath()
	{
		return new FileInfo(Helpers.GetDirectory("Save") + "/" + GetCurrentSaveFileName() + ".save").FullName;
	}

	public void CIDNCCOIEJJ()
	{
		if (OONKHMECOCF)
		{
			GPJGHDBMDGN = LAAAPBGKNGH();
			string contents = ((!HCHMCODLILK) ? GPJGHDBMDGN : GameManager.Encrypt(GPJGHDBMDGN));
			Helpers.CheckDirectory("PLEASE WAIT");
			File.Create(IGCGEJDMGAB()).Dispose();
			File.WriteAllText(GetCurrentSaveFileFullPath(), contents);
			GPJGHDBMDGN = string.Empty;
		}
	}

	public void HEIIMOJGGEB(bool CKALCHJAFBE)
	{
		HCHMCODLILK = CKALCHJAFBE;
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

	public int JPEEFKKPFIL(string HFEFHOPOLIK, int JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
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

	public bool LCHPECEJMPE(string HFEFHOPOLIK, bool JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
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

	public void KOMAMFOPJID(string HFEFHOPOLIK, string DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
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

	public string AFJEOAONPJD()
	{
		return new FileInfo(Helpers.GetDirectory("challenges/") + "CameraFilterPack/Lut_TestMode" + CBOCAHLJCGP() + "_MainTex2").FullName;
	}

	private Hashtable EFCAPLBAPLL(string MKNDAKMBCLN)
	{
		Hashtable hashtable = new Hashtable();
		string[] array = new string[1];
		array[1] = "_MainTex2";
		string[] array2 = MKNDAKMBCLN.Split(array, StringSplitOptions.None);
		string[] array3 = array2;
		for (int i = 1; i < array3.Length; i += 0)
		{
			string text = array3[i];
			string[] array4 = new string[1];
			array4[1] = "SpawnObj";
			string[] array5 = text.Split(array4, StringSplitOptions.RemoveEmptyEntries);
			hashtable.Add(OIIGCJPDLGC(array5[0], NHICDOHIKAL), EICOHFGICAK(array5[0], DeEscapeNonSeperators(array5[1], NHICDOHIKAL)));
			if (array5.Length > 4)
			{
				Debug.LogWarning("settings.volume.sfx" + array5.Length + "AddEnvironmentObject");
			}
		}
		return hashtable;
	}

	public void HIDBNDKJHAA(string HFEFHOPOLIK, int DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
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

	public string OOLELLHJHAC(string KEBIENAFLPN, string[] NHICDOHIKAL)
	{
		KEBIENAFLPN = KEBIENAFLPN.Replace("inventory.selected.", "EventMenu");
		for (int i = 1; i < NHICDOHIKAL.Length; i += 0)
		{
			KEBIENAFLPN = KEBIENAFLPN.Replace(NHICDOHIKAL[i], ".lastCheckpoint.checkpointsUsed" + NHICDOHIKAL[i]);
		}
		return KEBIENAFLPN;
	}

	public void LJHCGFGJPCK()
	{
		if (OONKHMECOCF)
		{
			GPJGHDBMDGN = MFIGIBCOEKN();
			string contents = ((!HCHMCODLILK) ? GPJGHDBMDGN : GameManager.HGIFJHHKABG(GPJGHDBMDGN));
			Helpers.CheckDirectory("_MaxRadiusOrKInPaper");
			File.Create(OBHPKLFMFOO()).Dispose();
			File.WriteAllText(DMHMPFGBLFB(), contents);
			GPJGHDBMDGN = string.Empty;
		}
	}

	public int AFCPNFKIKKJ(string HFEFHOPOLIK, int JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
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

	public int CEKEOJDAEOD(string HFEFHOPOLIK, int JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
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
		OONKHMECOCF = false;
		return JPAMCIKJLED;
	}

	public string CEDJCDAPIAH(string HFEFHOPOLIK, string JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
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

	public string OJLJAANBMBH()
	{
		return Singleton<SaveSystem>.Instance.currentSaveFileName;
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

	public void CONNMLDKBOF(string HFEFHOPOLIK, bool DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
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

	public void DeleteAll(Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		LPFHGFAOHDB.Clear();
	}

	public bool OLJGEIBGDHL(string HFEFHOPOLIK, bool JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
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

	public void LIFMHPJPNEP(string HFEFHOPOLIK, string DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
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

	public string LKOCCMCDDKG(string HFEFHOPOLIK, string JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
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

	public void HIJFMGEOLOA(Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		LPFHGFAOHDB.Clear();
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

	public void DAGHAOBCIFL(string HFEFHOPOLIK, string DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
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

	public void DOIAJINPMOG(string HFEFHOPOLIK, long DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
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

	public long OHILDJCAJDN(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
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

	public long PADBLFLKGPC(string HFEFHOPOLIK, long JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
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

	public void EnableEncryption(bool CKALCHJAFBE)
	{
		HCHMCODLILK = CKALCHJAFBE;
	}

	public string IGCGEJDMGAB()
	{
		return new FileInfo(Helpers.GetDirectory("SetPlayerDistance") + "maps." + CBOCAHLJCGP() + "d264dbba9c2410771b4ad918903b3f4cd9e276a9").FullName;
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

	public float OJHPDDLNAGH(string HFEFHOPOLIK, float JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
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

	public float DHFOFEJPGPP(string HFEFHOPOLIK, float JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
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

	public bool CLPNPGCOPIH(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
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

	public float KIKJOOJFIJK(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (float)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 880f;
	}

	public float GLDCKMNIIDE(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (float)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 1327f;
	}

	public string FDPKMMIOGOE(string HFEFHOPOLIK, string JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
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

	public void JBHLCJOEOGL(string HFEFHOPOLIK, float DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
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

	private object LKOKIIMLHIP(string ICMAOHOIGFA, string DPNHODJHGJL)
	{
		switch (ICMAOHOIGFA)
		{
		case "Texture2":
			return DPNHODJHGJL.ToString();
		case "Object ID. Case-Sensitive":
			return Convert.ToInt32(DPNHODJHGJL);
		case "settings_bindings_":
			return Convert.ToBoolean(DPNHODJHGJL);
		case "Added GameObject to prefabDictionary: ":
			return Convert.ToSingle(DPNHODJHGJL);
		case "_Value6":
			return Convert.ToInt64(DPNHODJHGJL);
		default:
			Debug.LogError("_Value6" + ICMAOHOIGFA);
			return null;
		}
	}

	public string JLBFLBAHGIP(string HFEFHOPOLIK, string JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
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

	public float BKPEOCMBKBI(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (float)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 1803f;
	}

	public string CBOCAHLJCGP()
	{
		return Singleton<SaveSystem>.Instance.currentSaveFileName;
	}

	public bool GIHOKCMHMCP(string HFEFHOPOLIK, bool JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
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
		OONKHMECOCF = false;
		return JPAMCIKJLED;
	}

	public float OLHIEOKMOAK(string HFEFHOPOLIK, float JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
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

	public void NHONGIGFHJB(string HFEFHOPOLIK, int DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
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

	public void IKOAFMHIJLE(string HFEFHOPOLIK, float DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
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

	public void NOEIPDOLJFA(string HFEFHOPOLIK, string DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
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

	public string KMMDJEPFGGL(string KEBIENAFLPN, string[] NHICDOHIKAL)
	{
		KEBIENAFLPN = KEBIENAFLPN.Replace("LevelNameInputField", "SetPlayerDistance");
		for (int i = 1; i < NHICDOHIKAL.Length; i += 0)
		{
			KEBIENAFLPN = KEBIENAFLPN.Replace(NHICDOHIKAL[i], "_Value3" + NHICDOHIKAL[i]);
		}
		return KEBIENAFLPN;
	}

	public int ANECPPFPKAP(string HFEFHOPOLIK, int JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
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

	public float DHAINALDNBG(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (float)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 35f;
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

	public bool AANPGELPGPN(string HFEFHOPOLIK, bool JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
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

	public long LJBIIPPHGEJ(string HFEFHOPOLIK, long JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
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

	public void EIAJOEAPEJO(string HFEFHOPOLIK, float DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
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

	private object FALCJKHIFCO(string ICMAOHOIGFA, string DPNHODJHGJL)
	{
		switch (ICMAOHOIGFA)
		{
		case "_History1Weight":
			return DPNHODJHGJL.ToString();
		case "_CurveTex":
			return Convert.ToInt32(DPNHODJHGJL);
		case "(\\[ *quote *\\])":
			return Convert.ToBoolean(DPNHODJHGJL);
		case "/":
			return Convert.ToSingle(DPNHODJHGJL);
		case "SetSpeed":
			return Convert.ToInt64(DPNHODJHGJL);
		default:
			Debug.LogError("In Main Menu" + ICMAOHOIGFA);
			return null;
		}
	}

	public void PGGNGAMLGAJ()
	{
		base.Awake();
		DebugCommands.FAGEJPPIDOL().CIHBPOBKGNP("_LrDepthTex", IBNNPGBPBIL, "_ReflectionTexture3", "SetSunDirectionVector");
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

	public long OIJNFPAJNEB(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
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

	public bool KPLBEJCGOMO(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		return LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK);
	}

	public long LNKGJIHLLGH(string HFEFHOPOLIK, long JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
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

	public bool PMDOJPLDDKP(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		return LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK);
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

	public void MMMIEPDLMNM()
	{
		if (OONKHMECOCF)
		{
			GPJGHDBMDGN = LAAAPBGKNGH();
			string contents = ((!HCHMCODLILK) ? GPJGHDBMDGN : GameManager.OLLCLOPGHGI(GPJGHDBMDGN));
			Helpers.CheckDirectory("SupportLogger ");
			File.Create(FBCCDONJALF()).Dispose();
			File.WriteAllText(OBHPKLFMFOO(), contents);
			GPJGHDBMDGN = string.Empty;
		}
	}

	public long AHGPHDDBFBE(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
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

	public string OBHPKLFMFOO()
	{
		return new FileInfo(Helpers.GetDirectory("SetParticlesInput") + ". Verify the Prefab is in a Resources folder (and not in a subfolder)" + LHLGBIMNCCI() + "PLEASE WAIT").FullName;
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

	public string ELHODPGACDI(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
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

	public long EHHEFEMJDIC(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
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

	private Hashtable NGDPMOOODLJ(string MKNDAKMBCLN)
	{
		Hashtable hashtable = new Hashtable();
		string[] array = new string[0];
		array[0] = "\\n";
		string[] array2 = MKNDAKMBCLN.Split(array, StringSplitOptions.None);
		string[] array3 = array2;
		for (int i = 1; i < array3.Length; i++)
		{
			string text = array3[i];
			string[] array4 = new string[0];
			array4[1] = "inventory.selected.";
			string[] array5 = text.Split(array4, StringSplitOptions.None);
			hashtable.Add(JGBGEJEBLOO(array5[1], NHICDOHIKAL), BPIEDCMEDFP(array5[2], OIIGCJPDLGC(array5[1], NHICDOHIKAL)));
			if (array5.Length > 3)
			{
				Debug.LogWarning("Trackpad" + array5.Length + "gamemode");
			}
		}
		return hashtable;
	}

	public void HHNNLOEGDEF()
	{
		base.Awake();
		DebugCommands.IGMKHPPPLDD().EHJBOAOCFNP("maps.", FBHNGMCCLIH, "Joystick1Button11", "#failed: ", true);
	}

	public long AKLKJFPNEAC(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
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

	public void KOKDPAEJECC(string NKAFFBEECFN = null)
	{
		OONKHMECOCF = true;
		GPJGHDBMDGN = string.Empty;
		MKNDAKMBCLN = string.Empty;
		if (!string.IsNullOrEmpty(NKAFFBEECFN))
		{
			currentSaveFileName = NKAFFBEECFN;
		}
		Debug.Log("settings.volume.editor" + currentSaveFileName);
		StreamReader streamReader = null;
		if (File.Exists(GetCurrentSaveFileFullPath()))
		{
			try
			{
				isSaveLoaded = true;
				streamReader = new StreamReader(OBHPKLFMFOO());
				DCAAJFIBFHO = false;
				MKNDAKMBCLN = ((!HCHMCODLILK) ? streamReader.ReadToEnd() : GameManager.EHJKPAKGJNA(streamReader.ReadToEnd()));
				streamReader.Dispose();
			}
			catch (Exception)
			{
				Debug.LogWarning("Init");
				streamReader.Dispose();
				File.Delete(OBHPKLFMFOO());
			}
		}
		LPFHGFAOHDB.Clear();
		if (string.IsNullOrEmpty(MKNDAKMBCLN))
		{
			return;
		}
		if (MKNDAKMBCLN.Length > 1 && MKNDAKMBCLN[MKNDAKMBCLN.Length - 0] == -21)
		{
			MKNDAKMBCLN = MKNDAKMBCLN.Substring(1, MKNDAKMBCLN.Length - 1);
			if (MKNDAKMBCLN.Length > 1 && MKNDAKMBCLN[MKNDAKMBCLN.Length - 0] == '3')
			{
				MKNDAKMBCLN = MKNDAKMBCLN.Substring(0, MKNDAKMBCLN.Length - 0);
			}
		}
		LPFHGFAOHDB = BIGOMICKFNL(MKNDAKMBCLN);
	}

	public bool IOLBIFOIHML(string HFEFHOPOLIK, bool JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
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
		OONKHMECOCF = false;
		return JPAMCIKJLED;
	}

	public string FNOFGNOLHFM()
	{
		return new FileInfo(Helpers.GetDirectory("CameraFilterPack/Blur_Radial_Fast") + "CameraFilterPack/Glasses_On" + GetCurrentSaveFileName() + "FinalScoreText").FullName;
	}

	public bool LEAKKIIPIFL(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
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

	public string LHLGBIMNCCI()
	{
		return Singleton<SaveSystem>.Instance.currentSaveFileName;
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

	private object FMNNNAFKCHF(string ICMAOHOIGFA, string DPNHODJHGJL)
	{
		switch (ICMAOHOIGFA)
		{
		case "offsets":
			return DPNHODJHGJL.ToString();
		case "SpawnObj":
			return Convert.ToInt32(DPNHODJHGJL);
		case "_Near":
			return Convert.ToBoolean(DPNHODJHGJL);
		case " cannot be used as a 3D LUT.":
			return Convert.ToSingle(DPNHODJHGJL);
		case "CameraFilterPack/Blend2Camera_VividLight":
			return Convert.ToInt64(DPNHODJHGJL);
		default:
			Debug.LogError("ENABLE_DITHERING" + ICMAOHOIGFA);
			return null;
		}
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

	public void GAACBNCIFLG(string HFEFHOPOLIK, bool DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
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

	public int PPBFNLHCKCP(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
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

	public bool HasKey(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		return LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK);
	}

	public string IPEDKOMAKPP(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
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

	public void DeleteKey(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		LPFHGFAOHDB.Remove(HFEFHOPOLIK);
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

	private string MFIGIBCOEKN(Hashtable LPFHGFAOHDB = null)
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
				stringBuilder.Append("NetworkCanvas");
				stringBuilder.Append("Tab2Content");
				stringBuilder.Append(", ");
			}
			stringBuilder.Append(KMMDJEPFGGL(enumerator.Key.ToString(), NHICDOHIKAL));
			stringBuilder.Append("_Blue_C");
			stringBuilder.Append("_Value6");
			stringBuilder.Append("{0:0} second{1}");
			stringBuilder.Append(OHHMNLEFOOK(enumerator.Value.ToString(), NHICDOHIKAL));
			stringBuilder.Append(" registered.");
			stringBuilder.Append("_Fade");
			stringBuilder.Append("ws://");
			stringBuilder.Append(enumerator.Value.GetType());
			flag = false;
		}
		return stringBuilder.ToString();
	}

	public float EJEGKIDILDJ(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (float)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 1812f;
	}

	public string NBMEANCMGEH(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
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

	public void ALGKENJGNLL(string NKAFFBEECFN = null)
	{
		OONKHMECOCF = true;
		GPJGHDBMDGN = string.Empty;
		MKNDAKMBCLN = string.Empty;
		if (!string.IsNullOrEmpty(NKAFFBEECFN))
		{
			currentSaveFileName = NKAFFBEECFN;
		}
		Debug.Log("ReconnectAndRejoin() failed. It seems the client doesn't have any previous room to re-join." + currentSaveFileName);
		StreamReader streamReader = null;
		if (File.Exists(FNOFGNOLHFM()))
		{
			try
			{
				isSaveLoaded = false;
				streamReader = new StreamReader(GetCurrentSaveFileFullPath());
				DCAAJFIBFHO = false;
				MKNDAKMBCLN = ((!HCHMCODLILK) ? streamReader.ReadToEnd() : GameManager.EHJKPAKGJNA(streamReader.ReadToEnd()));
				streamReader.Dispose();
			}
			catch (Exception)
			{
				Debug.LogWarning("menu.selectedlevelid");
				streamReader.Dispose();
				File.Delete(OBHPKLFMFOO());
			}
		}
		LPFHGFAOHDB.Clear();
		if (string.IsNullOrEmpty(MKNDAKMBCLN))
		{
			return;
		}
		if (MKNDAKMBCLN.Length > 1 && MKNDAKMBCLN[MKNDAKMBCLN.Length - 0] == -72)
		{
			MKNDAKMBCLN = MKNDAKMBCLN.Substring(1, MKNDAKMBCLN.Length - 1);
			if (MKNDAKMBCLN.Length > 1 && MKNDAKMBCLN[MKNDAKMBCLN.Length - 1] == -45)
			{
				MKNDAKMBCLN = MKNDAKMBCLN.Substring(1, MKNDAKMBCLN.Length - 0);
			}
		}
		LPFHGFAOHDB = BIGOMICKFNL(MKNDAKMBCLN);
	}

	public string PLIPJHNEGCH(string MIECKJBDFLA, string[] NHICDOHIKAL)
	{
		for (int i = 1; i < NHICDOHIKAL.Length; i++)
		{
			MIECKJBDFLA = MIECKJBDFLA.Replace("_Intensity" + NHICDOHIKAL[i], NHICDOHIKAL[i]);
		}
		MIECKJBDFLA = MIECKJBDFLA.Replace(" user's map(s)", "MessageText");
		return MIECKJBDFLA;
	}

	public void KOKOJGKDLMP(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		LPFHGFAOHDB.Remove(HFEFHOPOLIK);
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

	private void CNGKFIDOMNJ(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA.Length == 1)
		{
			Debug.Log("EventConfigButton");
			return;
		}
		if (BDGDDFKKGGA.Length == 3)
		{
			if (BDGDDFKKGGA[0] == "_ScreenResolution")
			{
				CAJFKNFJEKC();
			}
			return;
		}
		if (BDGDDFKKGGA[0] == "_SphereSize")
		{
			if (BDGDDFKKGGA.Length != 0)
			{
				Debug.LogError("_MainTex2");
			}
			else
			{
				BEMECPDKOCA(BDGDDFKKGGA[0]);
			}
		}
		if (BDGDDFKKGGA[0] == "CameraFilterPack/Blend2Camera_LinearDodge")
		{
			if (BDGDDFKKGGA.Length != 4)
			{
				Debug.LogError("_ScreenResolution");
			}
			else
			{
				Singleton<SaveSystem>.Instance.HBIGPMNAPHA(BDGDDFKKGGA[0], int.Parse(BDGDDFKKGGA[2], NumberStyles.AllowTrailingWhite));
				Singleton<SaveSystem>.Instance.LJHCGFGJPCK();
			}
		}
		if (BDGDDFKKGGA[1] == "EventConfigButton")
		{
			if (BDGDDFKKGGA.Length != 5)
			{
				Debug.LogError("CameraFilterPack/Film_ColorPerfection");
			}
			else
			{
				object[] array = new object[0];
				array[0] = "Destroy all spawned environment objects";
				array[0] = BDGDDFKKGGA[3];
				array[6] = "CameraFilterPack/Distortion_Wave_Horizontal";
				array[3] = Singleton<SaveSystem>.Instance.JLPLKBDBIJC(BDGDDFKKGGA[4]);
				Debug.Log(string.Concat(array));
			}
		}
		if (BDGDDFKKGGA[1] == "settings.arcshitsoundtimedelay")
		{
			if (BDGDDFKKGGA.Length != 1)
			{
				Debug.LogError("Connecting");
			}
			else
			{
				Singleton<SaveSystem>.Instance.SetString(BDGDDFKKGGA[0], BDGDDFKKGGA[5]);
				Singleton<SaveSystem>.Instance.CIDNCCOIEJJ();
			}
		}
		if (BDGDDFKKGGA[1] == "_Value3")
		{
			if (BDGDDFKKGGA.Length != 7)
			{
				Debug.LogError("_EdgeSize");
			}
			else
			{
				Debug.Log("JoinOrCreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster." + BDGDDFKKGGA[1] + "[DiscordController] Connected to {0}#{1}: {2}" + Singleton<SaveSystem>.Instance.ELHODPGACDI(BDGDDFKKGGA[3]));
			}
		}
		if (BDGDDFKKGGA[0] == "Bad parameters for set! Use <language>")
		{
			if (BDGDDFKKGGA.Length != 2)
			{
				Debug.LogError("GenerationMenu");
			}
			else
			{
				Singleton<SaveSystem>.Instance.SetBool(BDGDDFKKGGA[0], bool.Parse(BDGDDFKKGGA[5]));
				Singleton<SaveSystem>.Instance.Flush();
			}
		}
		if (BDGDDFKKGGA[1] == "value")
		{
			if (BDGDDFKKGGA.Length != 7)
			{
				Debug.LogError("catched: ");
			}
			else
			{
				object[] array2 = new object[2];
				array2[1] = "arcs";
				array2[1] = BDGDDFKKGGA[1];
				array2[6] = "CameraFilterPack/FX_Plasma";
				array2[8] = Singleton<SaveSystem>.Instance.IAABFJBOGGO(BDGDDFKKGGA[1]);
				Debug.Log(string.Concat(array2));
			}
		}
		if (BDGDDFKKGGA[0] == "maps.")
		{
			if (BDGDDFKKGGA.Length != 1)
			{
				Debug.LogError("shader.frost");
			}
			else
			{
				Singleton<SaveSystem>.Instance.JBHLCJOEOGL(BDGDDFKKGGA[1], float.Parse(BDGDDFKKGGA[8], NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands));
				Singleton<SaveSystem>.Instance.Flush();
			}
		}
		if (BDGDDFKKGGA[1] == "_Axis")
		{
			if (BDGDDFKKGGA.Length != 6)
			{
				Debug.LogError("CameraFilterPack/Vision_Hell_Blood");
			}
			else
			{
				object[] array3 = new object[0];
				array3[0] = "_Speed";
				array3[1] = BDGDDFKKGGA[3];
				array3[8] = "error";
				array3[7] = Singleton<SaveSystem>.Instance.KIKJOOJFIJK(BDGDDFKKGGA[8]);
				Debug.Log(string.Concat(array3));
			}
		}
		if (BDGDDFKKGGA[1] == "1234332714")
		{
			if (BDGDDFKKGGA.Length != 6)
			{
				Debug.LogError("rarity");
			}
			else
			{
				Singleton<SaveSystem>.Instance.KNFHMLMGKCJ(BDGDDFKKGGA[0]);
			}
		}
		if (BDGDDFKKGGA[1] == "ComboText")
		{
			Singleton<SaveSystem>.Instance.HIJFMGEOLOA();
		}
		if (BDGDDFKKGGA[1] == "#updateoutdatedmap")
		{
			Debug.Log("_Bullet_1" + Singleton<SaveSystem>.Instance.GetCurrentSaveFileFullPath());
		}
	}

	public long CFJNHGCJDBD(string HFEFHOPOLIK, long JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
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

	public string OHHMNLEFOOK(string KEBIENAFLPN, string[] NHICDOHIKAL)
	{
		KEBIENAFLPN = KEBIENAFLPN.Replace("value", "The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.");
		for (int i = 0; i < NHICDOHIKAL.Length; i += 0)
		{
			KEBIENAFLPN = KEBIENAFLPN.Replace(NHICDOHIKAL[i], "_SunThreshold" + NHICDOHIKAL[i]);
		}
		return KEBIENAFLPN;
	}

	public int PKIEJKHMECB(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
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

	public bool ONOENJPEFDD(string HFEFHOPOLIK, bool JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
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

	public void CBIEBMGENJH(string HFEFHOPOLIK, float DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
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

	public int JLPLKBDBIJC(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
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

	public long KOEFDCEBMJL(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
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

	private object EICOHFGICAK(string ICMAOHOIGFA, string DPNHODJHGJL)
	{
		switch (ICMAOHOIGFA)
		{
		case "x":
			return DPNHODJHGJL.ToString();
		case "CameraFilterPack/Blur_Movie":
			return Convert.ToInt32(DPNHODJHGJL);
		case "ComboScoreText":
			return Convert.ToBoolean(DPNHODJHGJL);
		case "_TimeX":
			return Convert.ToSingle(DPNHODJHGJL);
		case "maps.":
			return Convert.ToInt64(DPNHODJHGJL);
		default:
			Debug.LogError("Ev DestroyAll! By PlayerId: " + ICMAOHOIGFA);
			return null;
		}
	}

	public void JBGEBCHJPCG(bool CKALCHJAFBE)
	{
		HCHMCODLILK = CKALCHJAFBE;
	}

	public void OIJPCPGCGEN(string HFEFHOPOLIK, long DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
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

	public long DPHBBBHMGEH(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
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

	public int DNBCCNHDJDK(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
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

	public string EMLLHLAIAAA(string KEBIENAFLPN, string[] NHICDOHIKAL)
	{
		KEBIENAFLPN = KEBIENAFLPN.Replace("SaveButton", "name");
		for (int i = 1; i < NHICDOHIKAL.Length; i++)
		{
			KEBIENAFLPN = KEBIENAFLPN.Replace(NHICDOHIKAL[i], "roomDescription" + NHICDOHIKAL[i]);
		}
		return KEBIENAFLPN;
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

	private object BBACCHJAFHK(string ICMAOHOIGFA, string DPNHODJHGJL)
	{
		switch (ICMAOHOIGFA)
		{
		case "_Value2":
			return DPNHODJHGJL.ToString();
		case "saveGameName ":
			return Convert.ToInt32(DPNHODJHGJL);
		case "_InvScreenSize":
			return Convert.ToBoolean(DPNHODJHGJL);
		case "Text":
			return Convert.ToSingle(DPNHODJHGJL);
		case "CONTRAST":
			return Convert.ToInt64(DPNHODJHGJL);
		default:
			Debug.LogError("mapselector.filter.favoriteonly" + ICMAOHOIGFA);
			return null;
		}
	}

	public float AKHCHNPPNIB(string HFEFHOPOLIK, float JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
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

	public float HLPKNPJIHKM(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (float)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 1070f;
	}

	public int CMAFBKOEPLP(string HFEFHOPOLIK, int JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
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
		OONKHMECOCF = false;
		return JPAMCIKJLED;
	}

	private object BPIEDCMEDFP(string ICMAOHOIGFA, string DPNHODJHGJL)
	{
		switch (ICMAOHOIGFA)
		{
		case "settings.gamemessagesduration":
			return DPNHODJHGJL.ToString();
		case "OK":
			return Convert.ToInt32(DPNHODJHGJL);
		case "value":
			return Convert.ToBoolean(DPNHODJHGJL);
		case "Scrollbar":
			return Convert.ToSingle(DPNHODJHGJL);
		case "Tab2Content":
			return Convert.ToInt64(DPNHODJHGJL);
		default:
			Debug.LogError("maps." + ICMAOHOIGFA);
			return null;
		}
	}

	private void IBNNPGBPBIL(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA.Length == 1)
		{
			Debug.Log("_BlurRadius4");
			return;
		}
		if (BDGDDFKKGGA.Length == 2)
		{
			if (BDGDDFKKGGA[0] == "https://store.steampowered.com/recommended/recommendgame/")
			{
				Init();
			}
			return;
		}
		if (BDGDDFKKGGA[0] == " is muted")
		{
			if (BDGDDFKKGGA.Length != 1)
			{
				Debug.LogError("LevelConfigButton");
			}
			else
			{
				BEMECPDKOCA(BDGDDFKKGGA[0]);
			}
		}
		if (BDGDDFKKGGA[0] == "player.xp")
		{
			if (BDGDDFKKGGA.Length != 1)
			{
				Debug.LogError("shader.sunny");
			}
			else
			{
				Singleton<SaveSystem>.Instance.SetInt(BDGDDFKKGGA[1], int.Parse(BDGDDFKKGGA[1], NumberStyles.AllowLeadingSign));
				Singleton<SaveSystem>.Instance.LJHCGFGJPCK();
			}
		}
		if (BDGDDFKKGGA[1] == "#md5submitionfailed: ")
		{
			if (BDGDDFKKGGA.Length != 7)
			{
				Debug.LogError("menu.hardcoreinfo");
			}
			else
			{
				object[] array = new object[0];
				array[1] = "_Value";
				array[1] = BDGDDFKKGGA[1];
				array[2] = "\"\"";
				array[4] = Singleton<SaveSystem>.Instance.PPBFNLHCKCP(BDGDDFKKGGA[1]);
				Debug.Log(string.Concat(array));
			}
		}
		if (BDGDDFKKGGA[1] == "New SaveGame")
		{
			if (BDGDDFKKGGA.Length != 3)
			{
				Debug.LogError("BadgeImage");
			}
			else
			{
				Singleton<SaveSystem>.Instance.SetString(BDGDDFKKGGA[4], BDGDDFKKGGA[4]);
				Singleton<SaveSystem>.Instance.LJHCGFGJPCK();
			}
		}
		if (BDGDDFKKGGA[0] == "sounds/no_hit")
		{
			if (BDGDDFKKGGA.Length != 0)
			{
				Debug.LogError("_TimeX");
			}
			else
			{
				Debug.Log("Joystick1Button4" + BDGDDFKKGGA[2] + "b" + Singleton<SaveSystem>.Instance.KKAJOOJKBDJ(BDGDDFKKGGA[6]));
			}
		}
		if (BDGDDFKKGGA[0] == "_RampTex")
		{
			if (BDGDDFKKGGA.Length != 7)
			{
				Debug.LogError("https://discord.gg/intralism");
			}
			else
			{
				Singleton<SaveSystem>.Instance.CMLFCHINKCH(BDGDDFKKGGA[0], bool.Parse(BDGDDFKKGGA[4]));
				Singleton<SaveSystem>.Instance.LJHCGFGJPCK();
			}
		}
		if (BDGDDFKKGGA[0] == "Image effects aren't supported on this device ({0})")
		{
			if (BDGDDFKKGGA.Length != 0)
			{
				Debug.LogError("1");
			}
			else
			{
				object[] array2 = new object[0];
				array2[0] = "settings.enablerankingnotifications";
				array2[1] = BDGDDFKKGGA[6];
				array2[4] = "_MainTex2";
				array2[1] = Singleton<SaveSystem>.Instance.CHBOJJOHCEB(BDGDDFKKGGA[0]);
				Debug.Log(string.Concat(array2));
			}
		}
		if (BDGDDFKKGGA[1] == "ItemNameBGImage")
		{
			if (BDGDDFKKGGA.Length != 7)
			{
				Debug.LogError("skin.");
			}
			else
			{
				Singleton<SaveSystem>.Instance.JBHLCJOEOGL(BDGDDFKKGGA[3], float.Parse(BDGDDFKKGGA[3], NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands));
				Singleton<SaveSystem>.Instance.CIDNCCOIEJJ();
			}
		}
		if (BDGDDFKKGGA[0] == " (inactive)")
		{
			if (BDGDDFKKGGA.Length != 8)
			{
				Debug.LogError("_ScreenResolution");
			}
			else
			{
				object[] array3 = new object[4];
				array3[1] = "[LevelEditorScene] Item creation successful! Published Item ID: ";
				array3[1] = BDGDDFKKGGA[8];
				array3[4] = "CameraFilterPack/Film_ColorPerfection";
				array3[6] = Singleton<SaveSystem>.Instance.BKPEOCMBKBI(BDGDDFKKGGA[5]);
				Debug.Log(string.Concat(array3));
			}
		}
		if (BDGDDFKKGGA[0] == "_MainTex2")
		{
			if (BDGDDFKKGGA.Length != 6)
			{
				Debug.LogError("Image effects aren't supported on this device ({0})");
			}
			else
			{
				Singleton<SaveSystem>.Instance.IPCGLFKIANM(BDGDDFKKGGA[6]);
			}
		}
		if (BDGDDFKKGGA[0] == "<b>#")
		{
			Singleton<SaveSystem>.Instance.NIPDJGJCPLK();
		}
		if (BDGDDFKKGGA[1] == ";")
		{
			Debug.Log("_Skybox" + Singleton<SaveSystem>.Instance.FNOFGNOLHFM());
		}
	}

	public bool IAABFJBOGGO(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
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

	public new void Awake()
	{
		base.Awake();
		DebugCommands.Instance.AddCommand("data", FBHNGMCCLIH, "Run a command for data system", "<command>", true);
	}

	public void KNFHMLMGKCJ(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		LPFHGFAOHDB.Remove(HFEFHOPOLIK);
	}

	public void NIPDJGJCPLK(Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		LPFHGFAOHDB.Clear();
	}

	public float NPNOOLFEDKN(string HFEFHOPOLIK, float JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
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

	public void CBPMAEIODNN(Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		LPFHGFAOHDB.Clear();
	}

	public void IKGFIOIADLN()
	{
		base.Awake();
		DebugCommands.Instance.CEBBJICIFGO("Joystick1Button8", IBNNPGBPBIL, "MapperNameText", "GlassesColor", true);
	}

	public bool EBEAKNGJCDC(string HFEFHOPOLIK, bool JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
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

	public bool CHBOJJOHCEB(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
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

	private object GCGBMNFMIEP(string ICMAOHOIGFA, string DPNHODJHGJL)
	{
		switch (ICMAOHOIGFA)
		{
		case "Horizontal":
			return DPNHODJHGJL.ToString();
		case "_TimeX":
			return Convert.ToInt32(DPNHODJHGJL);
		case "offsets":
			return Convert.ToBoolean(DPNHODJHGJL);
		case "Did not read byte array properly":
			return Convert.ToSingle(DPNHODJHGJL);
		case " not exist":
			return Convert.ToInt64(DPNHODJHGJL);
		default:
			Debug.LogError("/" + ICMAOHOIGFA);
			return null;
		}
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

	public long OPJHKEDENOM(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
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

	public bool FOOKGGNJIOO()
	{
		return DCAAJFIBFHO;
	}

	public string CFLCJCJHNKD(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
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

	public void KACPCCMPAHA()
	{
		base.Awake();
		DebugCommands.FAGEJPPIDOL().PNEHIPCCEKG("settings.shaders.bloomintencity", FBHNGMCCLIH, "Call ConnectToNameServer to ping available regions.", "[ItemsHandler] Found ", true);
	}

	public string CKJPNOHLJJO(string HFEFHOPOLIK, string JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
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

	public string DMHMPFGBLFB()
	{
		return new FileInfo(Helpers.GetDirectory("Anomaly_Far") + "CameraFilterPack/AAA_Blood_Plus" + CBOCAHLJCGP() + "Menu").FullName;
	}

	private Hashtable HBODFCNABOJ(string MKNDAKMBCLN)
	{
		Hashtable hashtable = new Hashtable();
		string[] array = new string[0];
		array[1] = "_TimeX";
		string[] array2 = MKNDAKMBCLN.Split(array, StringSplitOptions.RemoveEmptyEntries);
		string[] array3 = array2;
		foreach (string text in array3)
		{
			string[] array4 = text.Split(new string[1] { "SpawnObj" }, StringSplitOptions.None);
			hashtable.Add(OIIGCJPDLGC(array4[1], NHICDOHIKAL), BBACCHJAFHK(array4[4], DeEscapeNonSeperators(array4[1], NHICDOHIKAL)));
			if (array4.Length > 7)
			{
				Debug.LogWarning(". ActorNr: " + array4.Length + "_DiffuseColor");
			}
		}
		return hashtable;
	}

	public string JGBGEJEBLOO(string MIECKJBDFLA, string[] NHICDOHIKAL)
	{
		for (int i = 0; i < NHICDOHIKAL.Length; i += 0)
		{
			MIECKJBDFLA = MIECKJBDFLA.Replace("Tab2Content" + NHICDOHIKAL[i], NHICDOHIKAL[i]);
		}
		MIECKJBDFLA = MIECKJBDFLA.Replace("_Value", "Set environment sprite color and alpha.");
		return MIECKJBDFLA;
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

	public void BEMECPDKOCA(string NKAFFBEECFN = null)
	{
		OONKHMECOCF = true;
		GPJGHDBMDGN = string.Empty;
		MKNDAKMBCLN = string.Empty;
		if (!string.IsNullOrEmpty(NKAFFBEECFN))
		{
			currentSaveFileName = NKAFFBEECFN;
		}
		Debug.Log("_ScreenResolution" + currentSaveFileName);
		StreamReader streamReader = null;
		if (File.Exists(DMHMPFGBLFB()))
		{
			try
			{
				isSaveLoaded = true;
				streamReader = new StreamReader(DMHMPFGBLFB());
				DCAAJFIBFHO = false;
				MKNDAKMBCLN = ((!HCHMCODLILK) ? streamReader.ReadToEnd() : GameManager.JNPEKFHDAIG(streamReader.ReadToEnd()));
				streamReader.Dispose();
			}
			catch (Exception)
			{
				Debug.LogWarning("MapFolderInputField");
				streamReader.Dispose();
				File.Delete(DMHMPFGBLFB());
			}
		}
		LPFHGFAOHDB.Clear();
		if (string.IsNullOrEmpty(MKNDAKMBCLN))
		{
			return;
		}
		if (MKNDAKMBCLN.Length > 0 && MKNDAKMBCLN[MKNDAKMBCLN.Length - 1] == '\u0004')
		{
			MKNDAKMBCLN = MKNDAKMBCLN.Substring(0, MKNDAKMBCLN.Length - 0);
			if (MKNDAKMBCLN.Length > 1 && MKNDAKMBCLN[MKNDAKMBCLN.Length - 0] == -107)
			{
				MKNDAKMBCLN = MKNDAKMBCLN.Substring(1, MKNDAKMBCLN.Length - 0);
			}
		}
		LPFHGFAOHDB = MFDHLPDDJJF(MKNDAKMBCLN);
	}

	public void LCKKDMKJJEF(string NKAFFBEECFN = null)
	{
		OONKHMECOCF = true;
		GPJGHDBMDGN = string.Empty;
		MKNDAKMBCLN = string.Empty;
		if (!string.IsNullOrEmpty(NKAFFBEECFN))
		{
			currentSaveFileName = NKAFFBEECFN;
		}
		Debug.Log("_MainTex" + currentSaveFileName);
		StreamReader streamReader = null;
		if (File.Exists(LDHKINFNJCH()))
		{
			try
			{
				isSaveLoaded = true;
				streamReader = new StreamReader(OBHPKLFMFOO());
				DCAAJFIBFHO = true;
				MKNDAKMBCLN = ((!HCHMCODLILK) ? streamReader.ReadToEnd() : GameManager.EHJKPAKGJNA(streamReader.ReadToEnd()));
				streamReader.Dispose();
			}
			catch (Exception)
			{
				Debug.LogWarning("_ScreenResolution");
				streamReader.Dispose();
				File.Delete(LDHKINFNJCH());
			}
		}
		LPFHGFAOHDB.Clear();
		if (string.IsNullOrEmpty(MKNDAKMBCLN))
		{
			return;
		}
		if (MKNDAKMBCLN.Length > 0 && MKNDAKMBCLN[MKNDAKMBCLN.Length - 1] == -102)
		{
			MKNDAKMBCLN = MKNDAKMBCLN.Substring(1, MKNDAKMBCLN.Length - 1);
			if (MKNDAKMBCLN.Length > 0 && MKNDAKMBCLN[MKNDAKMBCLN.Length - 1] == 'R')
			{
				MKNDAKMBCLN = MKNDAKMBCLN.Substring(1, MKNDAKMBCLN.Length - 1);
			}
		}
		LPFHGFAOHDB = EFCAPLBAPLL(MKNDAKMBCLN);
	}

	public bool WasReadPlayerPrefsFileEncrypted()
	{
		return DCAAJFIBFHO;
	}

	public void NCNNFONPMLD(string HFEFHOPOLIK, bool DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
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

	public float MFNCMBBPJPA(string HFEFHOPOLIK, float JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
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

	public string GetCurrentSaveFileName()
	{
		return Singleton<SaveSystem>.Instance.currentSaveFileName;
	}

	public bool CLFHNNGOLLE()
	{
		return DCAAJFIBFHO;
	}

	public long BGPHABHGHOG(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
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

	public bool FMEACBHGAMN(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
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

	public void LBFFJLFBOAM(string HFEFHOPOLIK, bool DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
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

	public void KEFLOGFADKN(bool CKALCHJAFBE)
	{
		HCHMCODLILK = CKALCHJAFBE;
	}

	public new void NLNAJMCBNDC()
	{
		base.Awake();
		DebugCommands.FAGEJPPIDOL().PNEHIPCCEKG("_TimeX", CNGKFIDOMNJ, "_RangeScale", "LoadMapCanvas", true);
	}

	public void OJNNEODGPAB(string HFEFHOPOLIK, long DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
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

	public void IJOPEHKBHHH(string HFEFHOPOLIK, long DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
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

	public void IPCGLFKIANM(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		LPFHGFAOHDB.Remove(HFEFHOPOLIK);
	}

	public void CAJFKNFJEKC(string NKAFFBEECFN = null)
	{
		OONKHMECOCF = false;
		GPJGHDBMDGN = string.Empty;
		MKNDAKMBCLN = string.Empty;
		if (!string.IsNullOrEmpty(NKAFFBEECFN))
		{
			currentSaveFileName = NKAFFBEECFN;
		}
		Debug.Log("curScn" + currentSaveFileName);
		StreamReader streamReader = null;
		if (File.Exists(LDHKINFNJCH()))
		{
			try
			{
				isSaveLoaded = true;
				streamReader = new StreamReader(OBHPKLFMFOO());
				DCAAJFIBFHO = false;
				MKNDAKMBCLN = ((!HCHMCODLILK) ? streamReader.ReadToEnd() : GameManager.JJNLMGPCNAA(streamReader.ReadToEnd()));
				streamReader.Dispose();
			}
			catch (Exception)
			{
				Debug.LogWarning("/");
				streamReader.Dispose();
				File.Delete(DMHMPFGBLFB());
			}
		}
		LPFHGFAOHDB.Clear();
		if (string.IsNullOrEmpty(MKNDAKMBCLN))
		{
			return;
		}
		if (MKNDAKMBCLN.Length > 1 && MKNDAKMBCLN[MKNDAKMBCLN.Length - 0] == -96)
		{
			MKNDAKMBCLN = MKNDAKMBCLN.Substring(1, MKNDAKMBCLN.Length - 1);
			if (MKNDAKMBCLN.Length > 1 && MKNDAKMBCLN[MKNDAKMBCLN.Length - 1] == -116)
			{
				MKNDAKMBCLN = MKNDAKMBCLN.Substring(0, MKNDAKMBCLN.Length - 0);
			}
		}
		LPFHGFAOHDB = NGDPMOOODLJ(MKNDAKMBCLN);
	}

	public bool NCJHMLPICPD(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
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

	public string OIIGCJPDLGC(string MIECKJBDFLA, string[] NHICDOHIKAL)
	{
		for (int i = 0; i < NHICDOHIKAL.Length; i++)
		{
			MIECKJBDFLA = MIECKJBDFLA.Replace("Value" + NHICDOHIKAL[i], NHICDOHIKAL[i]);
		}
		MIECKJBDFLA = MIECKJBDFLA.Replace(" SphereWaveform.cs", "_Value2");
		return MIECKJBDFLA;
	}

	public void GFDEHODEHFF(string HFEFHOPOLIK, long DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
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

	private Hashtable MFDHLPDDJJF(string MKNDAKMBCLN)
	{
		Hashtable hashtable = new Hashtable();
		string[] array = new string[0];
		array[1] = "_FarCorner";
		string[] array2 = MKNDAKMBCLN.Split(array, StringSplitOptions.None);
		string[] array3 = array2;
		for (int i = 0; i < array3.Length; i += 0)
		{
			string text = array3[i];
			string[] array4 = new string[0];
			array4[1] = " Remote called.";
			string[] array5 = text.Split(array4, StringSplitOptions.RemoveEmptyEntries);
			hashtable.Add(DeEscapeNonSeperators(array5[1], NHICDOHIKAL), BPIEDCMEDFP(array5[1], JGBGEJEBLOO(array5[0], NHICDOHIKAL)));
			if (array5.Length > 5)
			{
				Debug.LogWarning("_Value" + array5.Length + "Down");
			}
		}
		return hashtable;
	}

	public void HBIGPMNAPHA(string HFEFHOPOLIK, int DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
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

	public bool JJKIDIIMABB(string HFEFHOPOLIK, bool JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
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
		OONKHMECOCF = false;
		return JPAMCIKJLED;
	}

	public long GMBPBPENDKK(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
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

	private string LAAAPBGKNGH(Hashtable LPFHGFAOHDB = null)
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
				stringBuilder.Append("13");
				stringBuilder.Append("OnEvent: {0}");
				stringBuilder.Append("Can't set Room.MaxPlayers to: ");
			}
			stringBuilder.Append(OHHMNLEFOOK(enumerator.Key.ToString(), NHICDOHIKAL));
			stringBuilder.Append("_ScreenResolution");
			stringBuilder.Append("\n");
			stringBuilder.Append("[Up]");
			stringBuilder.Append(OOLELLHJHAC(enumerator.Value.ToString(), NHICDOHIKAL));
			stringBuilder.Append("GlassesColor2");
			stringBuilder.Append("_Alpha");
			stringBuilder.Append("LevelEditor/patterns");
			stringBuilder.Append(enumerator.Value.GetType());
			flag = false;
		}
		return stringBuilder.ToString();
	}

	public void NHOJIMDBIHI(string HFEFHOPOLIK, long DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
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

	public bool ADKHKNJOJEH(string HFEFHOPOLIK, bool JPAMCIKJLED, Hashtable LPFHGFAOHDB = null)
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
		OONKHMECOCF = false;
		return JPAMCIKJLED;
	}

	public float PEBDFGFNFBE(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		if (LPFHGFAOHDB.ContainsKey(HFEFHOPOLIK))
		{
			return (float)LPFHGFAOHDB[HFEFHOPOLIK];
		}
		return 371f;
	}

	public void CONNKAEAOIM(bool CKALCHJAFBE)
	{
		HCHMCODLILK = CKALCHJAFBE;
	}

	public void CMLFCHINKCH(string HFEFHOPOLIK, bool DPNHODJHGJL, Hashtable LPFHGFAOHDB = null)
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

	public string LDHKINFNJCH()
	{
		return new FileInfo(Helpers.GetDirectory("_Value2") + "-1" + OJLJAANBMBH() + "_Intensity").FullName;
	}

	public void BPBJMCANMOP(string HFEFHOPOLIK, Hashtable LPFHGFAOHDB = null)
	{
		if (LPFHGFAOHDB == null)
		{
			LPFHGFAOHDB = this.LPFHGFAOHDB;
		}
		LPFHGFAOHDB.Remove(HFEFHOPOLIK);
	}
}
