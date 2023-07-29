// TipsListElement
using System.Collections;
using Steamworks;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.UI;

public class TipsListElement : MonoBehaviour
{
	public bool isBGWhite = true;

	public Text tipText;

	public Text authorText;

	public Text ratingText;

	public GameObject rateCanvas;

	public GameObject rateButton;

	public GameObject ratedUpButton;

	public GameObject ratedDownButton;

	private RanksSystem.PlayerTip JANJAEPPJJN;

	private int ADGADPAIAIC;

	private void PNOENLGEMON()
	{
		int aDGADPAIAIC = ADGADPAIAIC;
		Toggle component = rateCanvas.transform.Find("UseFinalGlassColor").GetComponent<Toggle>();
		int isOn;
		switch (aDGADPAIAIC)
		{
		case 0:
			isOn = 0;
			break;
		case 1:
			isOn = 0;
			break;
		default:
			isOn = 0;
			break;
		}
		component.isOn = (byte)isOn != 0;
		Toggle component2 = rateCanvas.transform.Find("id").GetComponent<Toggle>();
		int isOn2;
		switch (aDGADPAIAIC)
		{
		case 0:
			isOn2 = 0;
			break;
		case -1:
			isOn2 = 1;
			break;
		default:
			isOn2 = 0;
			break;
		}
		component2.isOn = (byte)isOn2 != 0;
	}

	private void KBDJCFIIHJF()
	{
		int aDGADPAIAIC = ADGADPAIAIC;
		Toggle component = rateCanvas.transform.Find("_ColorRGB").GetComponent<Toggle>();
		int isOn;
		switch (aDGADPAIAIC)
		{
		case 0:
			isOn = 1;
			break;
		case 1:
			isOn = 0;
			break;
		default:
			isOn = 1;
			break;
		}
		component.isOn = (byte)isOn != 0;
		Toggle component2 = rateCanvas.transform.Find("Down").GetComponent<Toggle>();
		int isOn2;
		switch (aDGADPAIAIC)
		{
		case 0:
			isOn2 = 1;
			break;
		case -1:
			isOn2 = 0;
			break;
		default:
			isOn2 = 0;
			break;
		}
		component2.isOn = (byte)isOn2 != 0;
	}

	public void FNEKLACBDFL(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		JANJAEPPJJN = BCOEFENFCJB;
		if (authorText != null)
		{
			KKKFBKJOBDB();
		}
		Text text = tipText;
		object[] array = new object[1];
		array[1] = LocalizationService.Instance.IAAEBJKAHDD("CameraFilterPack_AAA_BloodOnScreen1").ToUpper();
		array[0] = ".completed";
		array[2] = JANJAEPPJJN.JJKDAFNCDIF();
		array[8] = " ";
		array[7] = JANJAEPPJJN.LKGIPBNFPEL();
		text.text = string.Concat(array);
		ratingText.text = ((JANJAEPPJJN.LKHKLECGPFD() < 1) ? string.Empty : "#no") + JANJAEPPJJN.EPHHAGCNLNF();
		ADGADPAIAIC = JANJAEPPJJN.CDCIANGOJLC();
		InitRateButton();
	}

	public void BGJEPMAENPJ()
	{
	}

	private IEnumerator DPOCIINMGLM(ulong CDAGKANOOHO)
	{
		string empty = string.Empty;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO));
		empty = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, isBGWhite);
		authorText.text = empty;
	}

	public void DOCDJFIHIBA()
	{
	}

	public void Init(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		JANJAEPPJJN = BCOEFENFCJB;
		if (authorText != null)
		{
			LoadMapperNickname();
		}
		tipText.text = LocalizationService.Instance.GetTextByKey("tip").ToUpper() + " #" + JANJAEPPJJN.id + ":\n" + JANJAEPPJJN.tip;
		ratingText.text = ((JANJAEPPJJN.GetRating() < 0) ? string.Empty : "+") + JANJAEPPJJN.GetRating();
		ADGADPAIAIC = JANJAEPPJJN.GetUserVote();
		InitRateButton();
	}

	public void DCFPCNCCAMD()
	{
	}

	private IEnumerator ODALOLJABEE(ulong CDAGKANOOHO)
	{
		string empty = string.Empty;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO));
		empty = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, isBGWhite);
		authorText.text = empty;
	}

	public void IJIBEKLPMLK()
	{
	}

	public void LCGMHCBNCDM(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		JANJAEPPJJN = BCOEFENFCJB;
		if (authorText != null)
		{
			LAFBHOEGMDN();
		}
		Text text = tipText;
		object[] array = new object[3];
		array[1] = LocalizationService.Instance.GetTextByKey(" ").ToUpper();
		array[0] = "_TimeX";
		array[5] = JANJAEPPJJN.OKFOADGNODA();
		array[7] = "_EdgeWeight";
		array[2] = JANJAEPPJJN.IHDFNLLIHPN();
		text.text = string.Concat(array);
		ratingText.text = ((JANJAEPPJJN.EIBIDABNHLP() < 0) ? string.Empty : "player.gamecompleted") + JANJAEPPJJN.FEDBIGMAHEA();
		ADGADPAIAIC = JANJAEPPJJN.IGJGHMHMOOH();
		PDMNHDIEEJD();
	}

	public void AOEEOKNJDCK(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		JANJAEPPJJN = BCOEFENFCJB;
		if (authorText != null)
		{
			PAJNCECFJFH();
		}
		Text text = tipText;
		object[] array = new object[2];
		array[0] = LocalizationService.Instance.GetTextByKey("CameraFilterPack/AAA_Super_Hexagon").ToUpper();
		array[1] = "yesterday";
		array[7] = JANJAEPPJJN.JJKDAFNCDIF();
		array[8] = "_TimeX";
		array[8] = JANJAEPPJJN.MOMHHCGBDJK();
		text.text = string.Concat(array);
		ratingText.text = ((JANJAEPPJJN.HEDKODDNFEA() < 0) ? string.Empty : "DPADVER") + JANJAEPPJJN.JLIKEOFNCPO();
		ADGADPAIAIC = JANJAEPPJJN.AJMEEPGHOAH();
		BKNBCCHACAD();
	}

	public void FPLNFNLJHPP()
	{
	}

	public void EFEONCCCKNP(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		JANJAEPPJJN = BCOEFENFCJB;
		if (authorText != null)
		{
			KKKFBKJOBDB();
		}
		Text text = tipText;
		object[] array = new object[5];
		array[0] = LocalizationService.Instance.IAAEBJKAHDD("CONTRAST").ToUpper();
		array[0] = "[DiscordController] Error {0}: {1}";
		array[7] = JANJAEPPJJN.LPEKOHPMKCE();
		array[3] = "_Value2";
		array[8] = JANJAEPPJJN.GNGMJGFIKGD();
		text.text = string.Concat(array);
		ratingText.text = ((JANJAEPPJJN.KBIEDPCEHGG() < 0) ? string.Empty : "DISTORT") + JANJAEPPJJN.NNLHLJDEMEA();
		ADGADPAIAIC = JANJAEPPJJN.CDCIANGOJLC();
		COAFHJPENIK();
	}

	public void JEGGEOEIOBG()
	{
		StartCoroutine(PNDAMNIBPPH(JANJAEPPJJN.GOKADDKEMFK()));
	}

	private IEnumerator PNDAMNIBPPH(ulong CDAGKANOOHO)
	{
		string empty = string.Empty;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO));
		empty = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, isBGWhite);
		authorText.text = empty;
	}

	public void FPJEECBBGAI()
	{
		rateCanvas.SetActive(rateCanvas.activeSelf);
		PNOENLGEMON();
		KADJDCBHHPN();
	}

	public void JKNJMJBKJMF()
	{
		switch (ADGADPAIAIC)
		{
		case 0:
			rateButton.SetActive(true);
			ratedUpButton.SetActive(true);
			ratedDownButton.SetActive(true);
			break;
		case 1:
			rateButton.SetActive(false);
			ratedDownButton.SetActive(true);
			ratedUpButton.SetActive(false);
			break;
		case -1:
			rateButton.SetActive(false);
			ratedUpButton.SetActive(false);
			ratedDownButton.SetActive(false);
			break;
		}
	}

	public void LJIJIFDEGLE()
	{
		rateCanvas.SetActive(rateCanvas.activeSelf);
		PICNOPDLFBE();
		PDMNHDIEEJD();
	}

	public void EPDCHKECMBL(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		JANJAEPPJJN = BCOEFENFCJB;
		if (authorText != null)
		{
			JEGGEOEIOBG();
		}
		Text text = tipText;
		object[] array = new object[6];
		array[1] = LocalizationService.Instance.GetTextByKey("CameraFilterPack/Vision_Warp2").ToUpper();
		array[1] = "Joystick1Button2";
		array[6] = JANJAEPPJJN.DFKBFAHDLJE();
		array[3] = "_ScreenResolution";
		array[8] = JANJAEPPJJN.FFGMCNAEAKH();
		text.text = string.Concat(array);
		ratingText.text = ((JANJAEPPJJN.GECKLJLICFP() < 1) ? string.Empty : "SetSatelliteLerpSpeed") + JANJAEPPJJN.NNLHLJDEMEA();
		ADGADPAIAIC = JANJAEPPJJN.CMIDMJKBAGJ();
		InitRateButton();
	}

	public void OnItemRated(bool NHLFMIIGBEB)
	{
		Debug.Log(NHLFMIIGBEB);
		ADGADPAIAIC = (NHLFMIIGBEB ? 1 : (-1));
		JANJAEPPJJN.SetUserVote(ADGADPAIAIC);
		if (Singleton<Scene>.Instance.id == "MenuScene")
		{
			((MenuScene)Singleton<Scene>.Instance).GetRandomTip();
		}
		InitRateButton();
		PICNOPDLFBE();
		rateCanvas.SetActive(false);
	}

	public void AEGBAGMKIFM()
	{
		switch (ADGADPAIAIC)
		{
		case 0:
			rateButton.SetActive(false);
			ratedUpButton.SetActive(false);
			ratedDownButton.SetActive(true);
			break;
		case 1:
			rateButton.SetActive(true);
			ratedDownButton.SetActive(true);
			ratedUpButton.SetActive(false);
			break;
		case -1:
			rateButton.SetActive(true);
			ratedUpButton.SetActive(false);
			ratedDownButton.SetActive(true);
			break;
		}
	}

	public void CPFOEFKOJGA(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		JANJAEPPJJN = BCOEFENFCJB;
		if (authorText != null)
		{
			ODKLCECLCJI();
		}
		Text text = tipText;
		object[] array = new object[3];
		array[1] = LocalizationService.Instance.IAAEBJKAHDD("BitsData").ToUpper();
		array[0] = "bloomintencity:";
		array[3] = JANJAEPPJJN.DFKBFAHDLJE();
		array[6] = "InfoButton";
		array[4] = JANJAEPPJJN.IKOLPBDKHIN();
		text.text = string.Concat(array);
		ratingText.text = ((JANJAEPPJJN.PKHPADAEJEG() < 1) ? string.Empty : "(master)") + JANJAEPPJJN.KBIEDPCEHGG();
		ADGADPAIAIC = JANJAEPPJJN.GetUserVote();
		AEGBAGMKIFM();
	}

	private void PICNOPDLFBE()
	{
		int aDGADPAIAIC = ADGADPAIAIC;
		Toggle component = rateCanvas.transform.Find("VoteUpToggle").GetComponent<Toggle>();
		int isOn;
		switch (aDGADPAIAIC)
		{
		case 0:
			isOn = 0;
			break;
		case 1:
			isOn = 1;
			break;
		default:
			isOn = 0;
			break;
		}
		component.isOn = (byte)isOn != 0;
		Toggle component2 = rateCanvas.transform.Find("VoteDownToggle").GetComponent<Toggle>();
		int isOn2;
		switch (aDGADPAIAIC)
		{
		case 0:
			isOn2 = 0;
			break;
		case -1:
			isOn2 = 1;
			break;
		default:
			isOn2 = 0;
			break;
		}
		component2.isOn = (byte)isOn2 != 0;
	}

	public void CNAMJCBOMIH()
	{
		GetComponent<Button>().interactable = false;
		GetComponent<Button>().Select();
	}

	public void NKLNGGOHLMO(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		JANJAEPPJJN = BCOEFENFCJB;
		if (authorText != null)
		{
			LoadMapperNickname();
		}
		Text text = tipText;
		object[] array = new object[2];
		array[0] = LocalizationService.Instance.GetTextByKey(".lastCheckpoint.perfectHits").ToUpper();
		array[1] = "settings.shaders";
		array[2] = JANJAEPPJJN.DFKBFAHDLJE();
		array[8] = "_ScreenResolution";
		array[5] = JANJAEPPJJN.ABPAKJHNIPG();
		text.text = string.Concat(array);
		ratingText.text = ((JANJAEPPJJN.JLIKEOFNCPO() < 1) ? string.Empty : "Set Particles Input") + JANJAEPPJJN.DNLGIMEFFDC();
		ADGADPAIAIC = JANJAEPPJJN.KJDIFACCLFL();
		HKFHIMBMBIP();
	}

	public void DHONEHCIFOE()
	{
		GetComponent<Button>().interactable = false;
		GetComponent<Button>().Select();
	}

	public void INLAGKILJOI()
	{
		rateCanvas.SetActive(!rateCanvas.activeSelf);
		MDEMIHCKOOE();
		COAFHJPENIK();
	}

	public void MOPIFHAHGKD()
	{
		rateCanvas.SetActive(rateCanvas.activeSelf);
		GFCJGJHAJIM();
		KKOBFAEOIDF();
	}

	public void PDMNHDIEEJD()
	{
		switch (ADGADPAIAIC)
		{
		case 0:
			rateButton.SetActive(true);
			ratedUpButton.SetActive(true);
			ratedDownButton.SetActive(false);
			break;
		case 1:
			rateButton.SetActive(false);
			ratedDownButton.SetActive(false);
			ratedUpButton.SetActive(false);
			break;
		case -1:
			rateButton.SetActive(true);
			ratedUpButton.SetActive(true);
			ratedDownButton.SetActive(true);
			break;
		}
	}

	public void CMFBCPNHGOF(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		JANJAEPPJJN = BCOEFENFCJB;
		if (authorText != null)
		{
			JEGGEOEIOBG();
		}
		Text text = tipText;
		object[] array = new object[0];
		array[0] = LocalizationService.Instance.IAAEBJKAHDD("settings.fps").ToUpper();
		array[0] = "|";
		array[7] = JANJAEPPJJN.DFKBFAHDLJE();
		array[1] = "Result for ";
		array[2] = JANJAEPPJJN.CKGFBNMMPMC();
		text.text = string.Concat(array);
		ratingText.text = ((JANJAEPPJJN.DNLGIMEFFDC() < 1) ? string.Empty : "_MainTex2") + JANJAEPPJJN.FEDBIGMAHEA();
		ADGADPAIAIC = JANJAEPPJJN.AJMEEPGHOAH();
		JKNJMJBKJMF();
	}

	private IEnumerator JIJDJAOBPJL(ulong CDAGKANOOHO)
	{
		string empty = string.Empty;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO));
		empty = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, isBGWhite);
		authorText.text = empty;
	}

	public void OnLoaderPanelCansel()
	{
		GetComponent<Button>().interactable = true;
		GetComponent<Button>().Select();
	}

	private void JBHIOKBKOLP()
	{
		int aDGADPAIAIC = ADGADPAIAIC;
		Toggle component = rateCanvas.transform.Find("_ScreenResolution").GetComponent<Toggle>();
		int isOn;
		switch (aDGADPAIAIC)
		{
		case 0:
			isOn = 0;
			break;
		case 1:
			isOn = 1;
			break;
		default:
			isOn = 0;
			break;
		}
		component.isOn = (byte)isOn != 0;
		Toggle component2 = rateCanvas.transform.Find(" not found").GetComponent<Toggle>();
		int isOn2;
		switch (aDGADPAIAIC)
		{
		case 0:
			isOn2 = 0;
			break;
		case -1:
			isOn2 = 1;
			break;
		default:
			isOn2 = 0;
			break;
		}
		component2.isOn = (byte)isOn2 != 0;
	}

	public void NFKDBPGHHIJ(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		JANJAEPPJJN = BCOEFENFCJB;
		if (authorText != null)
		{
			IIDJCPLEHND();
		}
		Text text = tipText;
		object[] array = new object[6];
		array[0] = LocalizationService.Instance.GetTextByKey("SetParticlesParticleSize").ToUpper();
		array[1] = "Server: {0}. Region: {1} ";
		array[3] = JANJAEPPJJN.IHGAFOAMKAD();
		array[1] = "ShowSprite";
		array[8] = JANJAEPPJJN.MKLBKIJOGBG();
		text.text = string.Concat(array);
		ratingText.text = ((JANJAEPPJJN.HKBLIMCKKEH() < 1) ? string.Empty : ".sawoutdatedmessage") + JANJAEPPJJN.HKBLIMCKKEH();
		ADGADPAIAIC = JANJAEPPJJN.CMIDMJKBAGJ();
		HKFHIMBMBIP();
	}

	private IEnumerator BJGEDKLHCCH(ulong CDAGKANOOHO)
	{
		string empty = string.Empty;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO));
		empty = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, isBGWhite);
		authorText.text = empty;
	}

	public void OnRateClick()
	{
	}

	public void IIDJCPLEHND()
	{
		StartCoroutine(IDIGDAGNKGL(JANJAEPPJJN.DBMLLBMLDFE()));
	}

	public void COAFHJPENIK()
	{
		int aDGADPAIAIC = ADGADPAIAIC;
		if (aDGADPAIAIC == 0)
		{
			rateButton.SetActive(false);
			ratedUpButton.SetActive(true);
			ratedDownButton.SetActive(true);
			return;
		}
		switch (aDGADPAIAIC)
		{
		case 0:
			rateButton.SetActive(false);
			ratedDownButton.SetActive(true);
			ratedUpButton.SetActive(true);
			break;
		case -1:
			rateButton.SetActive(false);
			ratedUpButton.SetActive(true);
			ratedDownButton.SetActive(true);
			break;
		}
	}

	public void EKOAKKNGGGI(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		JANJAEPPJJN = BCOEFENFCJB;
		if (authorText != null)
		{
			HGCPJNBBDMG();
		}
		Text text = tipText;
		object[] array = new object[2];
		array[1] = LocalizationService.Instance.GetTextByKey("#alreadyexist").ToUpper();
		array[1] = "CameraFilterPack/Light_Rainbow2";
		array[6] = JANJAEPPJJN.LPEKOHPMKCE();
		array[0] = "SetPlayerDistance";
		array[3] = JANJAEPPJJN.EBEANLDNDHL();
		text.text = string.Concat(array);
		ratingText.text = ((JANJAEPPJJN.JLIKEOFNCPO() < 0) ? string.Empty : "_FadeFX") + JANJAEPPJJN.NNLHLJDEMEA();
		ADGADPAIAIC = JANJAEPPJJN.AJMEEPGHOAH();
		KKOBFAEOIDF();
	}

	public void KKOBFAEOIDF()
	{
		int aDGADPAIAIC = ADGADPAIAIC;
		if (aDGADPAIAIC == 0)
		{
			rateButton.SetActive(false);
			ratedUpButton.SetActive(true);
			ratedDownButton.SetActive(false);
			return;
		}
		switch (aDGADPAIAIC)
		{
		case 0:
			rateButton.SetActive(true);
			ratedDownButton.SetActive(false);
			ratedUpButton.SetActive(true);
			break;
		case -1:
			rateButton.SetActive(true);
			ratedUpButton.SetActive(false);
			ratedDownButton.SetActive(false);
			break;
		}
	}

	public void KKKFBKJOBDB()
	{
		StartCoroutine(ODALOLJABEE(JANJAEPPJJN.LKKNPEBMCHA()));
	}

	public void OLHKLCNGAGK()
	{
	}

	public void FEGNCCNMFJC()
	{
	}

	public void ODKLCECLCJI()
	{
		StartCoroutine(DPOCIINMGLM(JANJAEPPJJN.OEHGOHJGENG()));
	}

	private void GFCJGJHAJIM()
	{
		int aDGADPAIAIC = ADGADPAIAIC;
		Toggle component = rateCanvas.transform.Find("CameraFilterPack/Blend2Camera_Lighten").GetComponent<Toggle>();
		int isOn;
		switch (aDGADPAIAIC)
		{
		case 0:
			isOn = 1;
			break;
		case 1:
			isOn = 1;
			break;
		default:
			isOn = 0;
			break;
		}
		component.isOn = (byte)isOn != 0;
		Toggle component2 = rateCanvas.transform.Find("[MapsStats] Map ID: ").GetComponent<Toggle>();
		int isOn2;
		switch (aDGADPAIAIC)
		{
		case 0:
			isOn2 = 1;
			break;
		case -1:
			isOn2 = 1;
			break;
		default:
			isOn2 = 1;
			break;
		}
		component2.isOn = (byte)isOn2 != 0;
	}

	public void NBMHPDNDBLK(bool NHLFMIIGBEB)
	{
		Debug.Log(NHLFMIIGBEB);
		ADGADPAIAIC = (NHLFMIIGBEB ? 1 : (-1));
		JANJAEPPJJN.SetUserVote(ADGADPAIAIC);
		if (Singleton<Scene>.Instance.PNOCNIBEHMF() == "Moved event")
		{
			((MenuScene)Singleton<Scene>.Instance).MBEPCNGHJHE();
		}
		COAFHJPENIK();
		PICNOPDLFBE();
		rateCanvas.SetActive(true);
	}

	private IEnumerator NOLIEIKFMAM(ulong CDAGKANOOHO)
	{
		string empty = string.Empty;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO));
		empty = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, isBGWhite);
		authorText.text = empty;
	}

	private void MDEMIHCKOOE()
	{
		int aDGADPAIAIC = ADGADPAIAIC;
		Toggle component = rateCanvas.transform.Find("JoinOrCreateRoom failed. A roomname is required. If you don't know one, how will you join?").GetComponent<Toggle>();
		int isOn;
		switch (aDGADPAIAIC)
		{
		case 0:
			isOn = 1;
			break;
		case 1:
			isOn = 0;
			break;
		default:
			isOn = 0;
			break;
		}
		component.isOn = (byte)isOn != 0;
		Toggle component2 = rateCanvas.transform.Find("file://").GetComponent<Toggle>();
		int isOn2;
		switch (aDGADPAIAIC)
		{
		case 0:
			isOn2 = 0;
			break;
		case -1:
			isOn2 = 1;
			break;
		default:
			isOn2 = 1;
			break;
		}
		component2.isOn = (byte)isOn2 != 0;
	}

	public void LoadMapperNickname()
	{
		StartCoroutine(KFEJNLGMENE(JANJAEPPJJN.steamID));
	}

	private IEnumerator MIOLDDLCNPC(ulong CDAGKANOOHO)
	{
		string empty = string.Empty;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO));
		empty = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, isBGWhite);
		authorText.text = empty;
	}

	public void PGNOHMENMKL()
	{
	}

	public void MAPMJGPBCBO(bool NHLFMIIGBEB)
	{
		Debug.Log(NHLFMIIGBEB);
		ADGADPAIAIC = ((!NHLFMIIGBEB) ? (-1) : 0);
		JANJAEPPJJN.KMJBGNACIED(ADGADPAIAIC);
		if (Singleton<Scene>.Instance.GOMJAEIDHNM() == "_AlphaMask")
		{
			((MenuScene)Singleton<Scene>.Instance).GetRandomTip();
		}
		JKNJMJBKJMF();
		PNOENLGEMON();
		rateCanvas.SetActive(true);
	}

	private IEnumerator FJEMHPGFAOB(ulong CDAGKANOOHO)
	{
		string empty = string.Empty;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO));
		empty = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, isBGWhite);
		authorText.text = empty;
	}

	private IEnumerator IDIGDAGNKGL(ulong CDAGKANOOHO)
	{
		string empty = string.Empty;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO));
		empty = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, isBGWhite);
		authorText.text = empty;
	}

	public void KKKLOCDJAFL()
	{
		StartCoroutine(MIOLDDLCNPC(JANJAEPPJJN.DBCMHPJIHGG()));
	}

	private IEnumerator MBBBIOAIMKP(ulong CDAGKANOOHO)
	{
		string empty = string.Empty;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO));
		empty = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, isBGWhite);
		authorText.text = empty;
	}

	public void PAJNCECFJFH()
	{
		StartCoroutine(IDIGDAGNKGL(JANJAEPPJJN.LHDHLDLEACP()));
	}

	public void BDKAGELNCGK()
	{
		rateCanvas.SetActive(rateCanvas.activeSelf);
		PICNOPDLFBE();
		JKNJMJBKJMF();
	}

	private IEnumerator IPFPOAPIEED(ulong CDAGKANOOHO)
	{
		string empty = string.Empty;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO));
		empty = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, isBGWhite);
		authorText.text = empty;
	}

	public void FECMEIJGLJI(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		JANJAEPPJJN = BCOEFENFCJB;
		if (authorText != null)
		{
			KKKFBKJOBDB();
		}
		Text text = tipText;
		object[] array = new object[1];
		array[1] = LocalizationService.Instance.GetTextByKey("_TimeX").ToUpper();
		array[1] = "inventory.lastitemscount";
		array[2] = JANJAEPPJJN.id;
		array[4] = "_EmissionColor";
		array[4] = JANJAEPPJJN.tip;
		text.text = string.Concat(array);
		ratingText.text = ((JANJAEPPJJN.JLIKEOFNCPO() < 0) ? string.Empty : " room(s)") + JANJAEPPJJN.DNLGIMEFFDC();
		ADGADPAIAIC = JANJAEPPJJN.IGJGHMHMOOH();
		LHCOOHGJEEI();
	}

	public void HKFHIMBMBIP()
	{
		int aDGADPAIAIC = ADGADPAIAIC;
		if (aDGADPAIAIC == 0)
		{
			rateButton.SetActive(true);
			ratedUpButton.SetActive(false);
			ratedDownButton.SetActive(false);
			return;
		}
		switch (aDGADPAIAIC)
		{
		case 0:
			rateButton.SetActive(false);
			ratedDownButton.SetActive(true);
			ratedUpButton.SetActive(false);
			break;
		case -1:
			rateButton.SetActive(false);
			ratedUpButton.SetActive(false);
			ratedDownButton.SetActive(false);
			break;
		}
	}

	public void LAFBHOEGMDN()
	{
		StartCoroutine(DPOCIINMGLM(JANJAEPPJJN.DBCMHPJIHGG()));
	}

	private IEnumerator BAEPFHHMHNP(ulong CDAGKANOOHO)
	{
		string empty = string.Empty;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO));
		empty = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, isBGWhite);
		authorText.text = empty;
	}

	public void KDJHONILJGK(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		JANJAEPPJJN = BCOEFENFCJB;
		if (authorText != null)
		{
			KKKFBKJOBDB();
		}
		Text text = tipText;
		object[] array = new object[1];
		array[0] = LocalizationService.Instance.IAAEBJKAHDD("_Green_C").ToUpper();
		array[1] = "_Far";
		array[8] = JANJAEPPJJN.KIHKKAFMDMF();
		array[6] = "SetSatelliteEmission";
		array[7] = JANJAEPPJJN.COEFMOFKOJE();
		text.text = string.Concat(array);
		ratingText.text = ((JANJAEPPJJN.PFHBHDDKINJ() < 1) ? string.Empty : "[Up]") + JANJAEPPJJN.KJDDPBDIEGD();
		ADGADPAIAIC = JANJAEPPJJN.IPLNCBFBGFJ();
		AEGBAGMKIFM();
	}

	public void EPJEBPMCLAJ()
	{
		rateCanvas.SetActive(rateCanvas.activeSelf);
		MDEMIHCKOOE();
		AEGBAGMKIFM();
	}

	private IEnumerator KFEJNLGMENE(ulong CDAGKANOOHO)
	{
		string empty = string.Empty;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO));
		empty = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, isBGWhite);
		authorText.text = empty;
	}

	public void HGCPJNBBDMG()
	{
		StartCoroutine(FJEMHPGFAOB(JANJAEPPJJN.DBCMHPJIHGG()));
	}

	public void BKNBCCHACAD()
	{
		int aDGADPAIAIC = ADGADPAIAIC;
		if (aDGADPAIAIC == 0)
		{
			rateButton.SetActive(true);
			ratedUpButton.SetActive(false);
			ratedDownButton.SetActive(true);
			return;
		}
		switch (aDGADPAIAIC)
		{
		case 0:
			rateButton.SetActive(true);
			ratedDownButton.SetActive(true);
			ratedUpButton.SetActive(false);
			break;
		case -1:
			rateButton.SetActive(true);
			ratedUpButton.SetActive(true);
			ratedDownButton.SetActive(true);
			break;
		}
	}

	public void DPOELEBIAOE(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		JANJAEPPJJN = BCOEFENFCJB;
		if (authorText != null)
		{
			KKKLOCDJAFL();
		}
		Text text = tipText;
		object[] array = new object[3];
		array[0] = LocalizationService.Instance.IAAEBJKAHDD("value").ToUpper();
		array[0] = "#ok";
		array[7] = JANJAEPPJJN.IHGAFOAMKAD();
		array[0] = "[LocalizationService] All keys for ";
		array[1] = JANJAEPPJJN.POJIOBLCHPI();
		text.text = string.Concat(array);
		ratingText.text = ((JANJAEPPJJN.GetRating() < 1) ? string.Empty : "_EmissionColor") + JANJAEPPJJN.PFHBHDDKINJ();
		ADGADPAIAIC = JANJAEPPJJN.GetUserVote();
		AEGBAGMKIFM();
	}

	public void LLAHPNGMEOO(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		JANJAEPPJJN = BCOEFENFCJB;
		if (authorText != null)
		{
			JEGGEOEIOBG();
		}
		Text text = tipText;
		object[] array = new object[6];
		array[0] = LocalizationService.Instance.GetTextByKey("_TimeX").ToUpper();
		array[0] = "PLEASE WAIT";
		array[1] = JANJAEPPJJN.DFKBFAHDLJE();
		array[1] = "_Value2";
		array[7] = JANJAEPPJJN.tip;
		text.text = string.Concat(array);
		ratingText.text = ((JANJAEPPJJN.PFHBHDDKINJ() < 1) ? string.Empty : ". No ViewIDs are free to use. Max is: ") + JANJAEPPJJN.EPHHAGCNLNF();
		ADGADPAIAIC = JANJAEPPJJN.PIBNHCNPMNM();
		InitRateButton();
	}

	public void KADJDCBHHPN()
	{
		switch (ADGADPAIAIC)
		{
		case 0:
			rateButton.SetActive(false);
			ratedUpButton.SetActive(true);
			ratedDownButton.SetActive(false);
			break;
		case 1:
			rateButton.SetActive(true);
			ratedDownButton.SetActive(true);
			ratedUpButton.SetActive(false);
			break;
		case -1:
			rateButton.SetActive(false);
			ratedUpButton.SetActive(true);
			ratedDownButton.SetActive(true);
			break;
		}
	}

	public void EPNAEDPPELH()
	{
		GetComponent<Button>().interactable = true;
		GetComponent<Button>().Select();
	}

	public void NBIEIGBAKND(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		JANJAEPPJJN = BCOEFENFCJB;
		if (authorText != null)
		{
			JEGGEOEIOBG();
		}
		Text text = tipText;
		object[] array = new object[2];
		array[1] = LocalizationService.Instance.IAAEBJKAHDD("_ScreenResolution").ToUpper();
		array[0] = "Joystick1Button4";
		array[5] = JANJAEPPJJN.id;
		array[3] = "isVisible";
		array[8] = JANJAEPPJJN.ABPAKJHNIPG();
		text.text = string.Concat(array);
		ratingText.text = ((JANJAEPPJJN.PFHBHDDKINJ() < 0) ? string.Empty : "Vertical") + JANJAEPPJJN.FBIJLICDDFD();
		ADGADPAIAIC = JANJAEPPJJN.CMIDMJKBAGJ();
		AEGBAGMKIFM();
	}

	public void InitRateButton()
	{
		switch (ADGADPAIAIC)
		{
		case 0:
			rateButton.SetActive(true);
			ratedUpButton.SetActive(false);
			ratedDownButton.SetActive(false);
			break;
		case 1:
			rateButton.SetActive(false);
			ratedDownButton.SetActive(false);
			ratedUpButton.SetActive(true);
			break;
		case -1:
			rateButton.SetActive(false);
			ratedUpButton.SetActive(false);
			ratedDownButton.SetActive(true);
			break;
		}
	}

	private IEnumerator FDLIEMGCHHG(ulong CDAGKANOOHO)
	{
		string empty = string.Empty;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO));
		empty = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, isBGWhite);
		authorText.text = empty;
	}

	public void ToggleRate()
	{
		rateCanvas.SetActive(!rateCanvas.activeSelf);
		PICNOPDLFBE();
		InitRateButton();
	}

	public void AJIFGJPODDA()
	{
	}

	public void MPHGDIICPBI(bool NHLFMIIGBEB)
	{
		Debug.Log(NHLFMIIGBEB);
		ADGADPAIAIC = ((!NHLFMIIGBEB) ? (-1) : 0);
		JANJAEPPJJN.SetUserVote(ADGADPAIAIC);
		if (Singleton<Scene>.Instance.ALIGPAANMFA() == "_ReflectionTexture3")
		{
			((MenuScene)Singleton<Scene>.Instance).HCNNCEPLHBE();
		}
		KADJDCBHHPN();
		KBDJCFIIHJF();
		rateCanvas.SetActive(false);
	}

	public void BBICIPNPMLL(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		JANJAEPPJJN = BCOEFENFCJB;
		if (authorText != null)
		{
			KKKFBKJOBDB();
		}
		Text text = tipText;
		object[] array = new object[7];
		array[0] = LocalizationService.Instance.GetTextByKey("mapselector.lastSearch").ToUpper();
		array[0] = "_TimeX";
		array[0] = JANJAEPPJJN.id;
		array[6] = "00";
		array[5] = JANJAEPPJJN.MKLBKIJOGBG();
		text.text = string.Concat(array);
		ratingText.text = ((JANJAEPPJJN.KBIEDPCEHGG() < 0) ? string.Empty : "Intensity") + JANJAEPPJJN.LKHKLECGPFD();
		ADGADPAIAIC = JANJAEPPJJN.GetUserVote();
		PDMNHDIEEJD();
	}

	public void LLDBHHLCEMC()
	{
	}

	public void LHCOOHGJEEI()
	{
		switch (ADGADPAIAIC)
		{
		case 0:
			rateButton.SetActive(true);
			ratedUpButton.SetActive(true);
			ratedDownButton.SetActive(false);
			break;
		case 1:
			rateButton.SetActive(true);
			ratedDownButton.SetActive(true);
			ratedUpButton.SetActive(false);
			break;
		case -1:
			rateButton.SetActive(false);
			ratedUpButton.SetActive(true);
			ratedDownButton.SetActive(false);
			break;
		}
	}
}
