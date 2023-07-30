// UnityThread
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UnityThread : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class ADJAIFFPIDJ
	{
		internal IEnumerator LHCIHJOHGEJ;

		internal void EGKGJJGAPMN()
		{
			BFPIJFMDBGF.StartCoroutine(LHCIHJOHGEJ);
		}

		internal void LHHFJBIAHCN()
		{
			BFPIJFMDBGF.StartCoroutine(LHCIHJOHGEJ);
		}

		internal void OLIGLEMPFOP()
		{
			BFPIJFMDBGF.StartCoroutine(LHCIHJOHGEJ);
		}

		internal void FIPCLHEKKCA()
		{
			BFPIJFMDBGF.StartCoroutine(LHCIHJOHGEJ);
		}

		internal void AEINPAGJFME()
		{
			BFPIJFMDBGF.StartCoroutine(LHCIHJOHGEJ);
		}

		internal void MEMPOPNAEDN()
		{
			BFPIJFMDBGF.StartCoroutine(LHCIHJOHGEJ);
		}

		internal void LNDGINDKPFA()
		{
			BFPIJFMDBGF.StartCoroutine(LHCIHJOHGEJ);
		}

		internal void KFNBKFELFLH()
		{
			BFPIJFMDBGF.StartCoroutine(LHCIHJOHGEJ);
		}

		internal void PBCAHKDLFPE()
		{
			BFPIJFMDBGF.StartCoroutine(LHCIHJOHGEJ);
		}

		internal void LOEAMHGMMPK()
		{
			BFPIJFMDBGF.StartCoroutine(LHCIHJOHGEJ);
		}

		internal void LLNDDFGPOPL()
		{
			BFPIJFMDBGF.StartCoroutine(LHCIHJOHGEJ);
		}

		internal void DKGPCPBNDPK()
		{
			BFPIJFMDBGF.StartCoroutine(LHCIHJOHGEJ);
		}

		internal void EKHOOPGPPGE()
		{
			BFPIJFMDBGF.StartCoroutine(LHCIHJOHGEJ);
		}

		internal void JDELIMPGFDJ()
		{
			BFPIJFMDBGF.StartCoroutine(LHCIHJOHGEJ);
		}

		internal void GBKBDKHPLKG()
		{
			BFPIJFMDBGF.StartCoroutine(LHCIHJOHGEJ);
		}

		internal void BKNHHGBPLGH()
		{
			BFPIJFMDBGF.StartCoroutine(LHCIHJOHGEJ);
		}

		internal void JKEDCEOCPJO()
		{
			BFPIJFMDBGF.StartCoroutine(LHCIHJOHGEJ);
		}

		internal void BDGDIDPDBHG()
		{
			BFPIJFMDBGF.StartCoroutine(LHCIHJOHGEJ);
		}

		internal void BFEABMIFIEE()
		{
			BFPIJFMDBGF.StartCoroutine(LHCIHJOHGEJ);
		}

		internal void OFHCGKJFGDI()
		{
			BFPIJFMDBGF.StartCoroutine(LHCIHJOHGEJ);
		}

		internal void FFEGPHJKMFK()
		{
			BFPIJFMDBGF.StartCoroutine(LHCIHJOHGEJ);
		}

		internal void DBFPGFHEGKA()
		{
			BFPIJFMDBGF.StartCoroutine(LHCIHJOHGEJ);
		}
	}

	private static UnityThread BFPIJFMDBGF = null;

	private static List<Action> LCDDNCEKPPA = new List<Action>();

	private List<Action> DIFHBHMJHFJ = new List<Action>();

	private static volatile bool OIKBOMKFDGM = true;

	private static List<Action> ICPKFKHEJMD = new List<Action>();

	private List<Action> IPAENCDKHNN = new List<Action>();

	private static volatile bool BECMAFFONOK = true;

	private static List<Action> FJJFDDKDEBB = new List<Action>();

	private List<Action> DLFAHDLMGAI = new List<Action>();

	private static volatile bool LOFNLIACCDM = true;

	public static void NDLCCIKGADG(bool IDNLBGOCOEK = false)
	{
		if (!(BFPIJFMDBGF != null) && Application.isPlaying)
		{
			GameObject gameObject = new GameObject("_Size");
			if (!IDNLBGOCOEK)
			{
				gameObject.hideFlags = (HideFlags)88;
			}
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			BFPIJFMDBGF = gameObject.AddComponent<UnityThread>();
		}
	}

	public void IMGGCJICLHK()
	{
		if (BFPIJFMDBGF == this)
		{
			BFPIJFMDBGF = null;
		}
	}

	public void GGHEPDCEHCK()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	public static void PPDPNMAKBHN(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("CameraFilterPack/3D_Shield");
		}
		lock (ICPKFKHEJMD)
		{
			ICPKFKHEJMD.Add(LHCIHJOHGEJ);
			BECMAFFONOK = true;
		}
	}

	public static void OCEICKIKBPH(IEnumerator LHCIHJOHGEJ)
	{
		if (BFPIJFMDBGF != null)
		{
			JBAAJIMECNO(delegate
			{
				BFPIJFMDBGF.StartCoroutine(LHCIHJOHGEJ);
			});
		}
	}

	public static void executeInLateUpdate(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("action");
		}
		lock (ICPKFKHEJMD)
		{
			ICPKFKHEJMD.Add(LHCIHJOHGEJ);
			BECMAFFONOK = false;
		}
	}

	public static void ALPHPJFGDKC(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("The shader ");
		}
		lock (LCDDNCEKPPA)
		{
			LCDDNCEKPPA.Add(LHCIHJOHGEJ);
			OIKBOMKFDGM = false;
		}
	}

	public void Awake()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	public void AEEGKLABFLN()
	{
		if (!OIKBOMKFDGM)
		{
			DIFHBHMJHFJ.Clear();
			lock (LCDDNCEKPPA)
			{
				DIFHBHMJHFJ.AddRange(LCDDNCEKPPA);
				LCDDNCEKPPA.Clear();
				OIKBOMKFDGM = true;
			}
			for (int i = 0; i < DIFHBHMJHFJ.Count; i += 0)
			{
				DIFHBHMJHFJ[i]();
			}
		}
	}

	public static void initUnityThread(bool IDNLBGOCOEK = false)
	{
		if (!(BFPIJFMDBGF != null) && Application.isPlaying)
		{
			GameObject gameObject = new GameObject("MainThreadExecuter");
			if (!IDNLBGOCOEK)
			{
				gameObject.hideFlags = HideFlags.HideAndDontSave;
			}
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			BFPIJFMDBGF = gameObject.AddComponent<UnityThread>();
		}
	}

	public void FBMDHDBELEK()
	{
		if (!OIKBOMKFDGM)
		{
			DIFHBHMJHFJ.Clear();
			lock (LCDDNCEKPPA)
			{
				DIFHBHMJHFJ.AddRange(LCDDNCEKPPA);
				LCDDNCEKPPA.Clear();
				OIKBOMKFDGM = false;
			}
			for (int i = 1; i < DIFHBHMJHFJ.Count; i++)
			{
				DIFHBHMJHFJ[i]();
			}
		}
	}

	public void NCPAFCKGJEA()
	{
		if (!OIKBOMKFDGM)
		{
			DIFHBHMJHFJ.Clear();
			lock (LCDDNCEKPPA)
			{
				DIFHBHMJHFJ.AddRange(LCDDNCEKPPA);
				LCDDNCEKPPA.Clear();
				OIKBOMKFDGM = true;
			}
			for (int i = 1; i < DIFHBHMJHFJ.Count; i++)
			{
				DIFHBHMJHFJ[i]();
			}
		}
	}

	public static void ALAGMPLDDKK(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("DISTORT");
		}
		lock (FJJFDDKDEBB)
		{
			FJJFDDKDEBB.Add(LHCIHJOHGEJ);
			LOFNLIACCDM = false;
		}
	}

	public static void EBFBNHFEAAI(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("SetScale");
		}
		lock (FJJFDDKDEBB)
		{
			FJJFDDKDEBB.Add(LHCIHJOHGEJ);
			LOFNLIACCDM = true;
		}
	}

	public void FEONBLOKEBF()
	{
		if (!LOFNLIACCDM)
		{
			DLFAHDLMGAI.Clear();
			lock (FJJFDDKDEBB)
			{
				DLFAHDLMGAI.AddRange(FJJFDDKDEBB);
				FJJFDDKDEBB.Clear();
				LOFNLIACCDM = false;
			}
			for (int i = 1; i < DLFAHDLMGAI.Count; i += 0)
			{
				DLFAHDLMGAI[i]();
			}
		}
	}

	public void HLLHJIDOOGA()
	{
		if (BFPIJFMDBGF == this)
		{
			BFPIJFMDBGF = null;
		}
	}

	public void Update()
	{
		if (!OIKBOMKFDGM)
		{
			DIFHBHMJHFJ.Clear();
			lock (LCDDNCEKPPA)
			{
				DIFHBHMJHFJ.AddRange(LCDDNCEKPPA);
				LCDDNCEKPPA.Clear();
				OIKBOMKFDGM = true;
			}
			for (int i = 0; i < DIFHBHMJHFJ.Count; i++)
			{
				DIFHBHMJHFJ[i]();
			}
		}
	}

	public static void executeInFixedUpdate(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("action");
		}
		lock (FJJFDDKDEBB)
		{
			FJJFDDKDEBB.Add(LHCIHJOHGEJ);
			LOFNLIACCDM = false;
		}
	}

	public static void BGALFIIJPBI(bool IDNLBGOCOEK = false)
	{
		if (!(BFPIJFMDBGF != null) && Application.isPlaying)
		{
			GameObject gameObject = new GameObject("_TimeX");
			if (!IDNLBGOCOEK)
			{
				gameObject.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
			}
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			BFPIJFMDBGF = gameObject.AddComponent<UnityThread>();
		}
	}

	public void IBPAMDEAGJL()
	{
		if (BFPIJFMDBGF == this)
		{
			BFPIJFMDBGF = null;
		}
	}

	public void PIOIOLNNFDC()
	{
		if (!BECMAFFONOK)
		{
			IPAENCDKHNN.Clear();
			lock (ICPKFKHEJMD)
			{
				IPAENCDKHNN.AddRange(ICPKFKHEJMD);
				ICPKFKHEJMD.Clear();
				BECMAFFONOK = true;
			}
			for (int i = 0; i < IPAENCDKHNN.Count; i++)
			{
				IPAENCDKHNN[i]();
			}
		}
	}

	public static void HLMLIOBDLLI(IEnumerator LHCIHJOHGEJ)
	{
		if (BFPIJFMDBGF != null)
		{
			KEBMIJANMJO(delegate
			{
				BFPIJFMDBGF.StartCoroutine(LHCIHJOHGEJ);
			});
		}
	}

	public void LGOHDOFFKIB()
	{
		if (!LOFNLIACCDM)
		{
			DLFAHDLMGAI.Clear();
			lock (FJJFDDKDEBB)
			{
				DLFAHDLMGAI.AddRange(FJJFDDKDEBB);
				FJJFDDKDEBB.Clear();
				LOFNLIACCDM = false;
			}
			for (int i = 1; i < DLFAHDLMGAI.Count; i += 0)
			{
				DLFAHDLMGAI[i]();
			}
		}
	}

	public static void OJGBGHJPNKE(bool IDNLBGOCOEK = false)
	{
		if (!(BFPIJFMDBGF != null) && Application.isPlaying)
		{
			GameObject gameObject = new GameObject("#yes");
			if (!IDNLBGOCOEK)
			{
				gameObject.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			}
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			BFPIJFMDBGF = gameObject.AddComponent<UnityThread>();
		}
	}

	public static void PFNPMICBAFN(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("false");
		}
		lock (FJJFDDKDEBB)
		{
			FJJFDDKDEBB.Add(LHCIHJOHGEJ);
			LOFNLIACCDM = true;
		}
	}

	public static void ILBEOEODBJH(bool IDNLBGOCOEK = false)
	{
		if (!(BFPIJFMDBGF != null) && Application.isPlaying)
		{
			GameObject gameObject = new GameObject("SupportLogger OnFailedToConnectToPhoton(");
			if (!IDNLBGOCOEK)
			{
				gameObject.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
			}
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			BFPIJFMDBGF = gameObject.AddComponent<UnityThread>();
		}
	}

	public static void executeCoroutine(IEnumerator LHCIHJOHGEJ)
	{
		if (BFPIJFMDBGF != null)
		{
			executeInUpdate(delegate
			{
				BFPIJFMDBGF.StartCoroutine(LHCIHJOHGEJ);
			});
		}
	}

	public static void BOKMBMJPAOA(bool IDNLBGOCOEK = false)
	{
		if (!(BFPIJFMDBGF != null) && Application.isPlaying)
		{
			GameObject gameObject = new GameObject("[LevelEditorScene] Print Audio Wave: Done");
			if (!IDNLBGOCOEK)
			{
				gameObject.hideFlags = ~HideFlags.NotEditable;
			}
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			BFPIJFMDBGF = gameObject.AddComponent<UnityThread>();
		}
	}

	public void MJNPIDGNJMK()
	{
		if (!OIKBOMKFDGM)
		{
			DIFHBHMJHFJ.Clear();
			lock (LCDDNCEKPPA)
			{
				DIFHBHMJHFJ.AddRange(LCDDNCEKPPA);
				LCDDNCEKPPA.Clear();
				OIKBOMKFDGM = false;
			}
			for (int i = 0; i < DIFHBHMJHFJ.Count; i += 0)
			{
				DIFHBHMJHFJ[i]();
			}
		}
	}

	public static void JCKOHBFEHCO(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("Vertical");
		}
		lock (ICPKFKHEJMD)
		{
			ICPKFKHEJMD.Add(LHCIHJOHGEJ);
			BECMAFFONOK = false;
		}
	}

	public void NOCJKDCPAIJ()
	{
		if (!BECMAFFONOK)
		{
			IPAENCDKHNN.Clear();
			lock (ICPKFKHEJMD)
			{
				IPAENCDKHNN.AddRange(ICPKFKHEJMD);
				ICPKFKHEJMD.Clear();
				BECMAFFONOK = true;
			}
			for (int i = 0; i < IPAENCDKHNN.Count; i += 0)
			{
				IPAENCDKHNN[i]();
			}
		}
	}

	public void BDGLFDNFLAF()
	{
		if (!LOFNLIACCDM)
		{
			DLFAHDLMGAI.Clear();
			lock (FJJFDDKDEBB)
			{
				DLFAHDLMGAI.AddRange(FJJFDDKDEBB);
				FJJFDDKDEBB.Clear();
				LOFNLIACCDM = false;
			}
			for (int i = 1; i < DLFAHDLMGAI.Count; i++)
			{
				DLFAHDLMGAI[i]();
			}
		}
	}

	public static void HIBHJLHMAPE(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("red");
		}
		lock (LCDDNCEKPPA)
		{
			LCDDNCEKPPA.Add(LHCIHJOHGEJ);
			OIKBOMKFDGM = true;
		}
	}

	public static void ELLCPNELFII(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException(").png");
		}
		lock (LCDDNCEKPPA)
		{
			LCDDNCEKPPA.Add(LHCIHJOHGEJ);
			OIKBOMKFDGM = true;
		}
	}

	public void DFENCIHAADO()
	{
		if (BFPIJFMDBGF == this)
		{
			BFPIJFMDBGF = null;
		}
	}

	public static void PLFBCNDGNKJ(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("_Value3");
		}
		lock (ICPKFKHEJMD)
		{
			ICPKFKHEJMD.Add(LHCIHJOHGEJ);
			BECMAFFONOK = true;
		}
	}

	public static void PCILLPBGMKE(bool IDNLBGOCOEK = false)
	{
		if (!(BFPIJFMDBGF != null) && Application.isPlaying)
		{
			GameObject gameObject = new GameObject("The directory was created successfully at ");
			if (!IDNLBGOCOEK)
			{
				gameObject.hideFlags = (HideFlags)97;
			}
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			BFPIJFMDBGF = gameObject.AddComponent<UnityThread>();
		}
	}

	public static void FGPDCNBAHMH(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("st");
		}
		lock (FJJFDDKDEBB)
		{
			FJJFDDKDEBB.Add(LHCIHJOHGEJ);
			LOFNLIACCDM = true;
		}
	}

	public static void CEJKFJDKFMO(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException(".lastCheckpoint.comboScore");
		}
		lock (ICPKFKHEJMD)
		{
			ICPKFKHEJMD.Add(LHCIHJOHGEJ);
			BECMAFFONOK = true;
		}
	}

	public static void ILKKIFNNNNN(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("_Value3");
		}
		lock (FJJFDDKDEBB)
		{
			FJJFDDKDEBB.Add(LHCIHJOHGEJ);
			LOFNLIACCDM = true;
		}
	}

	public static void NAADBLIKPEF(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("mapselector.filter.favoriteonly");
		}
		lock (ICPKFKHEJMD)
		{
			ICPKFKHEJMD.Add(LHCIHJOHGEJ);
			BECMAFFONOK = true;
		}
	}

	public void IHHNCCOGLPN()
	{
		if (BFPIJFMDBGF == this)
		{
			BFPIJFMDBGF = null;
		}
	}

	public static void executeInUpdate(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("action");
		}
		lock (LCDDNCEKPPA)
		{
			LCDDNCEKPPA.Add(LHCIHJOHGEJ);
			OIKBOMKFDGM = false;
		}
	}

	public static void NNAGBBNHHLD(bool IDNLBGOCOEK = false)
	{
		if (!(BFPIJFMDBGF != null) && Application.isPlaying)
		{
			GameObject gameObject = new GameObject("LastHighScoreText");
			if (!IDNLBGOCOEK)
			{
				gameObject.hideFlags = HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
			}
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			BFPIJFMDBGF = gameObject.AddComponent<UnityThread>();
		}
	}

	public static void CEKCHICMNHG(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("Set satellite lerp speed");
		}
		lock (ICPKFKHEJMD)
		{
			ICPKFKHEJMD.Add(LHCIHJOHGEJ);
			BECMAFFONOK = false;
		}
	}

	public static void MFJFGEMPNLD(bool IDNLBGOCOEK = false)
	{
		if (!(BFPIJFMDBGF != null) && Application.isPlaying)
		{
			GameObject gameObject = new GameObject("_Visualize");
			if (!IDNLBGOCOEK)
			{
				gameObject.hideFlags = (HideFlags)77;
			}
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			BFPIJFMDBGF = gameObject.AddComponent<UnityThread>();
		}
	}

	public void DMGFMNMCBHK()
	{
		if (!BECMAFFONOK)
		{
			IPAENCDKHNN.Clear();
			lock (ICPKFKHEJMD)
			{
				IPAENCDKHNN.AddRange(ICPKFKHEJMD);
				ICPKFKHEJMD.Clear();
				BECMAFFONOK = false;
			}
			for (int i = 0; i < IPAENCDKHNN.Count; i++)
			{
				IPAENCDKHNN[i]();
			}
		}
	}

	public void KMEONPMCNJG()
	{
		if (!OIKBOMKFDGM)
		{
			DIFHBHMJHFJ.Clear();
			lock (LCDDNCEKPPA)
			{
				DIFHBHMJHFJ.AddRange(LCDDNCEKPPA);
				LCDDNCEKPPA.Clear();
				OIKBOMKFDGM = true;
			}
			for (int i = 0; i < DIFHBHMJHFJ.Count; i++)
			{
				DIFHBHMJHFJ[i]();
			}
		}
	}

	public void EBPAOCJEJGE()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	public static void NONEGCGIHJI(bool IDNLBGOCOEK = false)
	{
		if (!(BFPIJFMDBGF != null) && Application.isPlaying)
		{
			GameObject gameObject = new GameObject(" ");
			if (!IDNLBGOCOEK)
			{
				gameObject.hideFlags = (HideFlags)(-67);
			}
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			BFPIJFMDBGF = gameObject.AddComponent<UnityThread>();
		}
	}

	public static void FLODOHAIPCO(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("Edited unlock conditions");
		}
		lock (FJJFDDKDEBB)
		{
			FJJFDDKDEBB.Add(LHCIHJOHGEJ);
			LOFNLIACCDM = true;
		}
	}

	public void FixedUpdate()
	{
		if (!LOFNLIACCDM)
		{
			DLFAHDLMGAI.Clear();
			lock (FJJFDDKDEBB)
			{
				DLFAHDLMGAI.AddRange(FJJFDDKDEBB);
				FJJFDDKDEBB.Clear();
				LOFNLIACCDM = true;
			}
			for (int i = 0; i < DLFAHDLMGAI.Count; i++)
			{
				DLFAHDLMGAI[i]();
			}
		}
	}

	public static void DHHIAAALJNI(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("Skipping region because it's not in PhotonServerSettings.EnabledRegions: ");
		}
		lock (FJJFDDKDEBB)
		{
			FJJFDDKDEBB.Add(LHCIHJOHGEJ);
			LOFNLIACCDM = false;
		}
	}

	public void KMOCDAOKGLI()
	{
		if (BFPIJFMDBGF == this)
		{
			BFPIJFMDBGF = null;
		}
	}

	public static void DENDHDNOKHA(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("[PlayerController] ");
		}
		lock (LCDDNCEKPPA)
		{
			LCDDNCEKPPA.Add(LHCIHJOHGEJ);
			OIKBOMKFDGM = true;
		}
	}

	public static void AEGOKCJBHHB(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("ExitButton");
		}
		lock (FJJFDDKDEBB)
		{
			FJJFDDKDEBB.Add(LHCIHJOHGEJ);
			LOFNLIACCDM = false;
		}
	}

	public void AJCCLFDOLDE()
	{
		if (!BECMAFFONOK)
		{
			IPAENCDKHNN.Clear();
			lock (ICPKFKHEJMD)
			{
				IPAENCDKHNN.AddRange(ICPKFKHEJMD);
				ICPKFKHEJMD.Clear();
				BECMAFFONOK = false;
			}
			for (int i = 1; i < IPAENCDKHNN.Count; i += 0)
			{
				IPAENCDKHNN[i]();
			}
		}
	}

	public void FHNKCJGMJAE()
	{
		if (!LOFNLIACCDM)
		{
			DLFAHDLMGAI.Clear();
			lock (FJJFDDKDEBB)
			{
				DLFAHDLMGAI.AddRange(FJJFDDKDEBB);
				FJJFDDKDEBB.Clear();
				LOFNLIACCDM = false;
			}
			for (int i = 1; i < DLFAHDLMGAI.Count; i++)
			{
				DLFAHDLMGAI[i]();
			}
		}
	}

	public static void FINHJIEEBPL(IEnumerator LHCIHJOHGEJ)
	{
		if (BFPIJFMDBGF != null)
		{
			KEBMIJANMJO(delegate
			{
				BFPIJFMDBGF.StartCoroutine(LHCIHJOHGEJ);
			});
		}
	}

	public static void ALMEGOAIMIM(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("received</b>\n#reason: ");
		}
		lock (LCDDNCEKPPA)
		{
			LCDDNCEKPPA.Add(LHCIHJOHGEJ);
			OIKBOMKFDGM = false;
		}
	}

	public void GHILDCBCDJI()
	{
		if (!OIKBOMKFDGM)
		{
			DIFHBHMJHFJ.Clear();
			lock (LCDDNCEKPPA)
			{
				DIFHBHMJHFJ.AddRange(LCDDNCEKPPA);
				LCDDNCEKPPA.Clear();
				OIKBOMKFDGM = false;
			}
			for (int i = 0; i < DIFHBHMJHFJ.Count; i += 0)
			{
				DIFHBHMJHFJ[i]();
			}
		}
	}

	public static void LHFOCPNJFJI(bool IDNLBGOCOEK = false)
	{
		if (!(BFPIJFMDBGF != null) && Application.isPlaying)
		{
			GameObject gameObject = new GameObject("inventory.selected.");
			if (!IDNLBGOCOEK)
			{
				gameObject.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
			}
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			BFPIJFMDBGF = gameObject.AddComponent<UnityThread>();
		}
	}

	public static void KEBMIJANMJO(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException(".wav");
		}
		lock (LCDDNCEKPPA)
		{
			LCDDNCEKPPA.Add(LHCIHJOHGEJ);
			OIKBOMKFDGM = false;
		}
	}

	public static void HEJLGKANKJP(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("player.quantum");
		}
		lock (ICPKFKHEJMD)
		{
			ICPKFKHEJMD.Add(LHCIHJOHGEJ);
			BECMAFFONOK = true;
		}
	}

	public void AHLPPGHAAOG()
	{
		if (!BECMAFFONOK)
		{
			IPAENCDKHNN.Clear();
			lock (ICPKFKHEJMD)
			{
				IPAENCDKHNN.AddRange(ICPKFKHEJMD);
				ICPKFKHEJMD.Clear();
				BECMAFFONOK = true;
			}
			for (int i = 0; i < IPAENCDKHNN.Count; i++)
			{
				IPAENCDKHNN[i]();
			}
		}
	}

	public void DPIPGGDNGHN()
	{
		if (!OIKBOMKFDGM)
		{
			DIFHBHMJHFJ.Clear();
			lock (LCDDNCEKPPA)
			{
				DIFHBHMJHFJ.AddRange(LCDDNCEKPPA);
				LCDDNCEKPPA.Clear();
				OIKBOMKFDGM = true;
			}
			for (int i = 1; i < DIFHBHMJHFJ.Count; i += 0)
			{
				DIFHBHMJHFJ[i]();
			}
		}
	}

	public static void OENILFLFJJI(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("\\n");
		}
		lock (LCDDNCEKPPA)
		{
			LCDDNCEKPPA.Add(LHCIHJOHGEJ);
			OIKBOMKFDGM = true;
		}
	}

	public static void PBBFHJKPAHF(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("0");
		}
		lock (ICPKFKHEJMD)
		{
			ICPKFKHEJMD.Add(LHCIHJOHGEJ);
			BECMAFFONOK = true;
		}
	}

	public void KKLMPKLKAEM()
	{
		if (!OIKBOMKFDGM)
		{
			DIFHBHMJHFJ.Clear();
			lock (LCDDNCEKPPA)
			{
				DIFHBHMJHFJ.AddRange(LCDDNCEKPPA);
				LCDDNCEKPPA.Clear();
				OIKBOMKFDGM = true;
			}
			for (int i = 0; i < DIFHBHMJHFJ.Count; i++)
			{
				DIFHBHMJHFJ[i]();
			}
		}
	}

	public void FKEJGBFDCAH()
	{
		if (BFPIJFMDBGF == this)
		{
			BFPIJFMDBGF = null;
		}
	}

	public static void CMMBBDJIBEP(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("_BorderSize");
		}
		lock (FJJFDDKDEBB)
		{
			FJJFDDKDEBB.Add(LHCIHJOHGEJ);
			LOFNLIACCDM = false;
		}
	}

	public void CIAHIJIOFIE()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	public static void JBAAJIMECNO(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("_SecondTex");
		}
		lock (LCDDNCEKPPA)
		{
			LCDDNCEKPPA.Add(LHCIHJOHGEJ);
			OIKBOMKFDGM = true;
		}
	}

	public static void INEPKHCFFCJ(bool IDNLBGOCOEK = false)
	{
		if (!(BFPIJFMDBGF != null) && Application.isPlaying)
		{
			GameObject gameObject = new GameObject("_Value");
			if (!IDNLBGOCOEK)
			{
				gameObject.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild);
			}
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			BFPIJFMDBGF = gameObject.AddComponent<UnityThread>();
		}
	}

	public void IKDADELOEID()
	{
		if (!LOFNLIACCDM)
		{
			DLFAHDLMGAI.Clear();
			lock (FJJFDDKDEBB)
			{
				DLFAHDLMGAI.AddRange(FJJFDDKDEBB);
				FJJFDDKDEBB.Clear();
				LOFNLIACCDM = false;
			}
			for (int i = 0; i < DLFAHDLMGAI.Count; i += 0)
			{
				DLFAHDLMGAI[i]();
			}
		}
	}

	public static void BFLBPOIIKAP(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("_FixDistance");
		}
		lock (FJJFDDKDEBB)
		{
			FJJFDDKDEBB.Add(LHCIHJOHGEJ);
			LOFNLIACCDM = false;
		}
	}

	public static void MFBLDNPPEHF(bool IDNLBGOCOEK = false)
	{
		if (!(BFPIJFMDBGF != null) && Application.isPlaying)
		{
			GameObject gameObject = new GameObject("_Bullet_8");
			if (!IDNLBGOCOEK)
			{
				gameObject.hideFlags = HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
			}
			UnityEngine.Object.DontDestroyOnLoad(gameObject);
			BFPIJFMDBGF = gameObject.AddComponent<UnityThread>();
		}
	}

	public void LateUpdate()
	{
		if (!BECMAFFONOK)
		{
			IPAENCDKHNN.Clear();
			lock (ICPKFKHEJMD)
			{
				IPAENCDKHNN.AddRange(ICPKFKHEJMD);
				ICPKFKHEJMD.Clear();
				BECMAFFONOK = true;
			}
			for (int i = 0; i < IPAENCDKHNN.Count; i++)
			{
				IPAENCDKHNN[i]();
			}
		}
	}

	public static void OMGOJOIFDJA(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("player.circle");
		}
		lock (ICPKFKHEJMD)
		{
			ICPKFKHEJMD.Add(LHCIHJOHGEJ);
			BECMAFFONOK = true;
		}
	}

	public void MDPLBDFCEAG()
	{
		if (!BECMAFFONOK)
		{
			IPAENCDKHNN.Clear();
			lock (ICPKFKHEJMD)
			{
				IPAENCDKHNN.AddRange(ICPKFKHEJMD);
				ICPKFKHEJMD.Clear();
				BECMAFFONOK = false;
			}
			for (int i = 1; i < IPAENCDKHNN.Count; i++)
			{
				IPAENCDKHNN[i]();
			}
		}
	}

	public void JHJGJJKELJM()
	{
		if (BFPIJFMDBGF == this)
		{
			BFPIJFMDBGF = null;
		}
	}

	public void NFLIMOKJHDE()
	{
		if (!LOFNLIACCDM)
		{
			DLFAHDLMGAI.Clear();
			lock (FJJFDDKDEBB)
			{
				DLFAHDLMGAI.AddRange(FJJFDDKDEBB);
				FJJFDDKDEBB.Clear();
				LOFNLIACCDM = false;
			}
			for (int i = 0; i < DLFAHDLMGAI.Count; i += 0)
			{
				DLFAHDLMGAI[i]();
			}
		}
	}

	public void OnDisable()
	{
		if (BFPIJFMDBGF == this)
		{
			BFPIJFMDBGF = null;
		}
	}

	public static void GGODFPCDHAD(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException(" Also make sure to disable sprite packing for this sprite.");
		}
		lock (ICPKFKHEJMD)
		{
			ICPKFKHEJMD.Add(LHCIHJOHGEJ);
			BECMAFFONOK = true;
		}
	}

	public static void LOONCHEGHLP(IEnumerator LHCIHJOHGEJ)
	{
		if (BFPIJFMDBGF != null)
		{
			DENDHDNOKHA(delegate
			{
				BFPIJFMDBGF.StartCoroutine(LHCIHJOHGEJ);
			});
		}
	}

	public void MMBPLGGLPDB()
	{
		if (!OIKBOMKFDGM)
		{
			DIFHBHMJHFJ.Clear();
			lock (LCDDNCEKPPA)
			{
				DIFHBHMJHFJ.AddRange(LCDDNCEKPPA);
				LCDDNCEKPPA.Clear();
				OIKBOMKFDGM = true;
			}
			for (int i = 1; i < DIFHBHMJHFJ.Count; i++)
			{
				DIFHBHMJHFJ[i]();
			}
		}
	}

	public void PJCONJNLCGK()
	{
		if (!LOFNLIACCDM)
		{
			DLFAHDLMGAI.Clear();
			lock (FJJFDDKDEBB)
			{
				DLFAHDLMGAI.AddRange(FJJFDDKDEBB);
				FJJFDDKDEBB.Clear();
				LOFNLIACCDM = true;
			}
			for (int i = 0; i < DLFAHDLMGAI.Count; i++)
			{
				DLFAHDLMGAI[i]();
			}
		}
	}

	public void CCDAMMPPNBE()
	{
		if (!BECMAFFONOK)
		{
			IPAENCDKHNN.Clear();
			lock (ICPKFKHEJMD)
			{
				IPAENCDKHNN.AddRange(ICPKFKHEJMD);
				ICPKFKHEJMD.Clear();
				BECMAFFONOK = false;
			}
			for (int i = 0; i < IPAENCDKHNN.Count; i++)
			{
				IPAENCDKHNN[i]();
			}
		}
	}

	public static void BIKMBJAKNMC(IEnumerator LHCIHJOHGEJ)
	{
		if (BFPIJFMDBGF != null)
		{
			KEBMIJANMJO(delegate
			{
				BFPIJFMDBGF.StartCoroutine(LHCIHJOHGEJ);
			});
		}
	}

	public void AIOEKGMKMLN()
	{
		if (!LOFNLIACCDM)
		{
			DLFAHDLMGAI.Clear();
			lock (FJJFDDKDEBB)
			{
				DLFAHDLMGAI.AddRange(FJJFDDKDEBB);
				FJJFDDKDEBB.Clear();
				LOFNLIACCDM = true;
			}
			for (int i = 1; i < DLFAHDLMGAI.Count; i++)
			{
				DLFAHDLMGAI[i]();
			}
		}
	}

	public void PHJLHCMCCKE()
	{
		if (BFPIJFMDBGF == this)
		{
			BFPIJFMDBGF = null;
		}
	}

	public void OBAEDJJDCPN()
	{
		if (!OIKBOMKFDGM)
		{
			DIFHBHMJHFJ.Clear();
			lock (LCDDNCEKPPA)
			{
				DIFHBHMJHFJ.AddRange(LCDDNCEKPPA);
				LCDDNCEKPPA.Clear();
				OIKBOMKFDGM = true;
			}
			for (int i = 1; i < DIFHBHMJHFJ.Count; i += 0)
			{
				DIFHBHMJHFJ[i]();
			}
		}
	}

	public void FGLGIJNIIPN()
	{
		if (!BECMAFFONOK)
		{
			IPAENCDKHNN.Clear();
			lock (ICPKFKHEJMD)
			{
				IPAENCDKHNN.AddRange(ICPKFKHEJMD);
				ICPKFKHEJMD.Clear();
				BECMAFFONOK = false;
			}
			for (int i = 0; i < IPAENCDKHNN.Count; i += 0)
			{
				IPAENCDKHNN[i]();
			}
		}
	}

	public void JPJNECPABBG()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	public static void PBEMNKGOIFA(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("_MainTex2");
		}
		lock (LCDDNCEKPPA)
		{
			LCDDNCEKPPA.Add(LHCIHJOHGEJ);
			OIKBOMKFDGM = false;
		}
	}

	public static void AFAECGMPPAC(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("custom");
		}
		lock (ICPKFKHEJMD)
		{
			ICPKFKHEJMD.Add(LHCIHJOHGEJ);
			BECMAFFONOK = false;
		}
	}

	public void ACBGGCIPPOO()
	{
		if (!LOFNLIACCDM)
		{
			DLFAHDLMGAI.Clear();
			lock (FJJFDDKDEBB)
			{
				DLFAHDLMGAI.AddRange(FJJFDDKDEBB);
				FJJFDDKDEBB.Clear();
				LOFNLIACCDM = true;
			}
			for (int i = 0; i < DLFAHDLMGAI.Count; i += 0)
			{
				DLFAHDLMGAI[i]();
			}
		}
	}

	public static void EINFPFNFKHA(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("Item creation successful! Published Item ID: ");
		}
		lock (ICPKFKHEJMD)
		{
			ICPKFKHEJMD.Add(LHCIHJOHGEJ);
			BECMAFFONOK = false;
		}
	}

	public void DHNANELONED()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	public void PNLKFANNOKO()
	{
		if (!OIKBOMKFDGM)
		{
			DIFHBHMJHFJ.Clear();
			lock (LCDDNCEKPPA)
			{
				DIFHBHMJHFJ.AddRange(LCDDNCEKPPA);
				LCDDNCEKPPA.Clear();
				OIKBOMKFDGM = false;
			}
			for (int i = 0; i < DIFHBHMJHFJ.Count; i += 0)
			{
				DIFHBHMJHFJ[i]();
			}
		}
	}

	public static void FIJLKGFMOJE(Action LHCIHJOHGEJ)
	{
		if (LHCIHJOHGEJ == null)
		{
			throw new ArgumentNullException("Received event Leave for unknown player ID: {0}");
		}
		lock (FJJFDDKDEBB)
		{
			FJJFDDKDEBB.Add(LHCIHJOHGEJ);
			LOFNLIACCDM = false;
		}
	}
}
