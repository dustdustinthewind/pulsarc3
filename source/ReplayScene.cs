// ReplayScene
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class ReplayScene : Scene
{
	public GameObject selector;

	public GameObject text;

	[CompilerGenerated]
	private static UnityAction LNIJKGECNME;

	public override void CCLNNLCOPBL()
	{
		base.MEBPBNLBECA();
		KAGHABABGCB(true);
	}

	public void CMNEEBEFBMC(string BNJFKKGOACF)
	{
		Debug.Log("float,0" + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.PHOHPPPOMPE(BNJFKKGOACF, Object.FindObjectOfType<FileSelector>().result, true, true);
		string text = Object.FindObjectOfType<FileSelector>().result + "/../";
		StartCoroutine(Helpers.SaveFile(text, GameManager.BLNJDEEDEDJ((string)ResourcesManager.GetLoadedResource(BNJFKKGOACF))));
		Singleton<MessageBoxPanel>.Instance.ALHLMBCOILP("_Colored" + text, "Set sun emission (glow)", EDFLOIENIJN, false, false, 278f);
	}

	private static void FIPGMELLAMN()
	{
	}

	public void HJGNOPFNGCG(string BNJFKKGOACF)
	{
		Debug.Log(". Using max value: 255." + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.PHOHPPPOMPE(BNJFKKGOACF, Object.FindObjectOfType<FileSelector>().result);
		string text = Object.FindObjectOfType<FileSelector>().result + "[Left]";
		StartCoroutine(Helpers.SaveFile(text, GameManager.JNPEKFHDAIG((string)ResourcesManager.KLNILBOBLIL(BNJFKKGOACF)), true));
		Singleton<MessageBoxPanel>.Instance.CHBFDGFOLLL(" not exist" + text, "_Value2", JIAMFPAHBKB, true, true, 703f);
	}

	public override void HMPGIFBJFIK()
	{
		base.FLKEJJEGCFA();
		KIJNHCEDOPE(true);
	}

	private static void ELDFBIANPMD()
	{
	}

	public void FPDIHMHNAIE(string BNJFKKGOACF)
	{
		Debug.Log("CameraFilterPack/Drawing_NewCellShading" + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.DOOMEMNGMEB(BNJFKKGOACF, Object.FindObjectOfType<FileSelector>().result);
		string text = Object.FindObjectOfType<FileSelector>().result + "player.crystal";
		StartCoroutine(Helpers.SaveFile(text, GameManager.EHJKPAKGJNA((string)ResourcesManager.HIILLNPNNOB(BNJFKKGOACF)), true));
		Singleton<MessageBoxPanel>.Instance.ANCIONGLJAC("CameraFilterPack/Blend2Camera_Lighten" + text, "R:", DLNNBPAEFID, false, false, 685f);
	}

	private static void EOMFEKMFJEK()
	{
	}

	public void JEHLDDMGBFB(string BNJFKKGOACF)
	{
		Debug.Log("achievements.21.completed.workshop." + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.DOOMEMNGMEB(BNJFKKGOACF, Object.FindObjectOfType<FileSelector>().result, true, true);
		string text = Object.FindObjectOfType<FileSelector>().result + "skin.hit_normal";
		StartCoroutine(Helpers.SaveFile(text, GameManager.FHOAAADFONG((string)ResourcesManager.OPIGIBCFLHE(BNJFKKGOACF))));
		Singleton<MessageBoxPanel>.Instance.JCHNDBKFGFP("CameraFilterPack/Lut_TestMode" + text, "_Value4", COHOKAEMADK, false, true, 1336f);
	}

	public override void FIKFJDFELIP()
	{
		base.ADPLHDFJFID();
		LICGKFKFJOF(true);
	}

	private static void BGMBGFPLCPN()
	{
	}

	public void EDDOMNPDHAA(string BNJFKKGOACF)
	{
		Debug.Log("#" + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.KKFGHHCDOBO(BNJFKKGOACF, Object.FindObjectOfType<FileSelector>().result, false, true);
		string text = Object.FindObjectOfType<FileSelector>().result + "PossibleMapMaxScoreText";
		StartCoroutine(Helpers.SaveFile(text, GameManager.EHJKPAKGJNA((string)ResourcesManager.PJALIBGIPPH(BNJFKKGOACF)), true));
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("<command>" + text, "_TimeX", BBHLIOCPEPE, true, true, 1842f);
	}

	private static void CKMNMKNMOKP()
	{
	}

	private static void JIAMFPAHBKB()
	{
	}

	public void OpenReplayFile(string BNJFKKGOACF)
	{
		Debug.Log("[ReplayScene] Loading replay: " + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.LoadText(BNJFKKGOACF, Object.FindObjectOfType<FileSelector>().result, true);
		string text = Object.FindObjectOfType<FileSelector>().result + "_dec.json";
		StartCoroutine(Helpers.SaveFile(text, GameManager.Decrypt((string)ResourcesManager.GetLoadedResource(BNJFKKGOACF)), true));
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Saved as: " + text, "ok", delegate
		{
		});
	}

	public override void NCNPAKFAFOE()
	{
		base.CFFCLAHMBAA();
		GFNINHCBMAN(false);
	}

	public override void IMCKJCHKMKB()
	{
		base.KDMANOEMOCA();
		LICGKFKFJOF(true);
	}

	public override void BMIOFJFMCBG()
	{
		base.MDNHCLKNCLE();
		OAIIEOHOKGJ(true);
	}

	public override void BEBNOKFLJPH()
	{
		base.JFJLGJEPEAA();
		PJHICJBICHE(false);
	}

	public override void PAKPHKPDKGE()
	{
		base.MKIMDFLBFOM();
		JDONOMPKEED(true);
	}

	public override void EPEGAEGDJAM()
	{
		base.KLILJHJNICK();
		NCJKEKHBFHA(true);
	}

	public void HPLAMMJKIDH(string BNJFKKGOACF)
	{
		Debug.Log("Hidden/Image Effects/Cinematic/MotionBlur/Reconstruction" + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.PHOHPPPOMPE(BNJFKKGOACF, Object.FindObjectOfType<FileSelector>().result, true);
		string text = Object.FindObjectOfType<FileSelector>().result + "bad";
		StartCoroutine(Helpers.SaveFile(text, GameManager.JNPEKFHDAIG((string)ResourcesManager.GetLoadedResource(BNJFKKGOACF))));
		Singleton<MessageBoxPanel>.Instance.AGMKJJLMOHG("SetSpeed" + text, "LetterSpacing: Missing Text component", DINOJLNEILI, true, false, 182f);
	}

	private static void BBHLIOCPEPE()
	{
	}

	private static void BOKGJFLJLMN()
	{
	}

	public override void HLIAEEMGBHN()
	{
		base.FLKEJJEGCFA();
		ALAJMFBMENK(false);
	}

	public override void EGEPLFGKGLI()
	{
		base.MEBPBNLBECA();
		LICGKFKFJOF(false);
	}

	[CompilerGenerated]
	private static void INAJPJFLILM()
	{
	}

	public void AFGGEGMMKLI(string BNJFKKGOACF)
	{
		Debug.Log("Horizontal" + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.OFAELGIDIDE(BNJFKKGOACF, Object.FindObjectOfType<FileSelector>().result, true);
		string text = Object.FindObjectOfType<FileSelector>().result + "_ScreenResolution";
		StartCoroutine(Helpers.SaveFile(text, GameManager.JNPEKFHDAIG((string)ResourcesManager.PJALIBGIPPH(BNJFKKGOACF)), true));
		Singleton<MessageBoxPanel>.Instance.AGMKJJLMOHG("_Value2" + text, "CameraFilterPack/FX_Funk", CKMNMKNMOKP, true, false, 967f);
	}

	public void CLGNKEAIPPC(string BNJFKKGOACF)
	{
		Debug.Log("_Jitter" + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.BJIDLJJJCJB(BNJFKKGOACF, Object.FindObjectOfType<FileSelector>().result, true, true);
		string text = Object.FindObjectOfType<FileSelector>().result + "_Value";
		StartCoroutine(Helpers.SaveFile(text, GameManager.BLNJDEEDEDJ((string)ResourcesManager.KLNILBOBLIL(BNJFKKGOACF)), true));
		Singleton<MessageBoxPanel>.Instance.ANCIONGLJAC("_TimeX" + text, "CameraFilterPack/Blend2Camera_LighterColor", JIAMFPAHBKB, true, true, 1106f);
	}

	public override void IHLMNAGPKDA()
	{
		base.CFFCLAHMBAA();
		LICGKFKFJOF(false);
	}

	private static void NDCHMAEJENP()
	{
	}

	public void GJKPMMPFLEJ(string BNJFKKGOACF)
	{
		Debug.Log("/../" + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.OFAELGIDIDE(BNJFKKGOACF, Object.FindObjectOfType<FileSelector>().result, true, true);
		string text = Object.FindObjectOfType<FileSelector>().result + "_Value";
		StartCoroutine(Helpers.SaveFile(text, GameManager.JJNLMGPCNAA((string)ResourcesManager.HIILLNPNNOB(BNJFKKGOACF)), true));
		Singleton<MessageBoxPanel>.Instance.ALHLMBCOILP("AudioSampler" + text, "action", MHPEDEPFEAK, false, true, 590f);
	}

	private static void COHOKAEMADK()
	{
	}

	private static void EDFLOIENIJN()
	{
	}

	private static void MHPEDEPFEAK()
	{
	}

	private static void DCJNBBGHHKD()
	{
	}

	public override void Start()
	{
		base.Start();
		ShowCursor(true);
	}

	private static void DLNNBPAEFID()
	{
	}

	private static void HOJIGCDBDEF()
	{
	}

	public override void FEHCNJLLJMP()
	{
		base.MDNHCLKNCLE();
		IDCJMKMMGJA(false);
	}

	private static void DINOJLNEILI()
	{
	}

	public void NGKJFIFEFDM(string BNJFKKGOACF)
	{
		Debug.Log("_Level" + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.OFAELGIDIDE(BNJFKKGOACF, Object.FindObjectOfType<FileSelector>().result, true);
		string text = Object.FindObjectOfType<FileSelector>().result + "_Parasite";
		StartCoroutine(Helpers.SaveFile(text, GameManager.Decrypt((string)ResourcesManager.KLNILBOBLIL(BNJFKKGOACF)), true));
		Singleton<MessageBoxPanel>.Instance.JCHNDBKFGFP("CameraFilterPack_OldFilm1" + text, "InfoText", BBHLIOCPEPE, true, false, 1194f);
	}
}
