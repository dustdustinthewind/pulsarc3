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

	public void GJILIJALJLE()
	{
		StartCoroutine(DLIAPJONLNP(JANJAEPPJJN.HHGBBNFFABK()));
	}

	public void FFDBEEJOJIL()
	{
		switch (ADGADPAIAIC)
		{
		case 0:
			rateButton.SetActive(false);
			ratedUpButton.SetActive(false);
			ratedDownButton.SetActive(false);
			break;
		case 1:
			rateButton.SetActive(true);
			ratedDownButton.SetActive(true);
			ratedUpButton.SetActive(true);
			break;
		case -1:
			rateButton.SetActive(false);
			ratedUpButton.SetActive(true);
			ratedDownButton.SetActive(false);
			break;
		}
	}

	public void OLMJKDPIPLM()
	{
		StartCoroutine(KFEJNLGMENE(JANJAEPPJJN.PGAMGLDIIKK()));
	}

	private void NIDMHFCBIAI()
	{
		int aDGADPAIAIC = ADGADPAIAIC;
		rateCanvas.transform.Find("_Value3").GetComponent<Toggle>().isOn = aDGADPAIAIC == 0 || ((aDGADPAIAIC == 0) ? true : false);
		Toggle component = rateCanvas.transform.Find("IconImage").GetComponent<Toggle>();
		int isOn;
		switch (aDGADPAIAIC)
		{
		case 0:
			isOn = 1;
			break;
		case -1:
			isOn = 1;
			break;
		default:
			isOn = 0;
			break;
		}
		component.isOn = (byte)isOn != 0;
	}

	private void JGLBJKMBOGN()
	{
		int aDGADPAIAIC = ADGADPAIAIC;
		Toggle component = rateCanvas.transform.Find("Items").GetComponent<Toggle>();
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
			isOn = 1;
			break;
		}
		component.isOn = (byte)isOn != 0;
		Toggle component2 = rateCanvas.transform.Find("[MapEditor] Item creation successful! Published Item ID: ").GetComponent<Toggle>();
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

	public void MPBIHAPPGOB()
	{
		StartCoroutine(MBBBIOAIMKP(JANJAEPPJJN.DOKGKLEGKDK()));
	}

	public void LoadMapperNickname()
	{
		StartCoroutine(KFEJNLGMENE(JANJAEPPJJN.steamID));
	}

	public void KCOCKJEGPCF()
	{
		rateCanvas.SetActive(rateCanvas.activeSelf);
		BHFJMGELFOB();
		InitRateButton();
	}

	private IEnumerator GNGNFMMPPGD(ulong CDAGKANOOHO)
	{
		string empty = string.Empty;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO));
		empty = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, isBGWhite);
		authorText.text = empty;
	}

	private void IOMLDJHOJPN()
	{
		int aDGADPAIAIC = ADGADPAIAIC;
		Toggle component = rateCanvas.transform.Find("[Up-Down]").GetComponent<Toggle>();
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
		Toggle component2 = rateCanvas.transform.Find("Chat").GetComponent<Toggle>();
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

	public void LADOJCNDBDA()
	{
		rateCanvas.SetActive(!rateCanvas.activeSelf);
		BHFJMGELFOB();
		FFDBEEJOJIL();
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

	public void GAJGEOMBEMN()
	{
		rateCanvas.SetActive(!rateCanvas.activeSelf);
		NIDMHFCBIAI();
		InitRateButton();
	}

	public void CALJCFBNJID()
	{
		rateCanvas.SetActive(rateCanvas.activeSelf);
		BNHCMJPAAGK();
		FFDBEEJOJIL();
	}

	public void EOPEMLDJAAO(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		JANJAEPPJJN = BCOEFENFCJB;
		if (authorText != null)
		{
			IMDKPJMICEN();
		}
		Text text = tipText;
		object[] array = new object[0];
		array[0] = LocalizationService.Instance.MPHMJLAOHAB("CameraFilterPack/Edge_Edge_filter").ToUpper();
		array[0] = "#kicked";
		array[5] = JANJAEPPJJN.ALBJAEBLABB();
		array[1] = "_Value5";
		array[1] = JANJAEPPJJN.POJIOBLCHPI();
		text.text = string.Concat(array);
		ratingText.text = ((JANJAEPPJJN.FOILACEMICA() < 1) ? string.Empty : "Joystick1Button9") + JANJAEPPJJN.CGENEJIPPEI();
		ADGADPAIAIC = JANJAEPPJJN.GetUserVote();
		AOOJFKPEIPG();
	}

	public void ACDJEEFDDML()
	{
	}

	private void CEJJMCMAPEN()
	{
		int aDGADPAIAIC = ADGADPAIAIC;
		rateCanvas.transform.Find("_Source").GetComponent<Toggle>().isOn = aDGADPAIAIC == 0 || (aDGADPAIAIC != 0 && false);
		Toggle component = rateCanvas.transform.Find("EditMenu").GetComponent<Toggle>();
		int isOn;
		switch (aDGADPAIAIC)
		{
		case 0:
			isOn = 1;
			break;
		case -1:
			isOn = 1;
			break;
		default:
			isOn = 1;
			break;
		}
		component.isOn = (byte)isOn != 0;
	}

	private IEnumerator KFEJNLGMENE(ulong CDAGKANOOHO)
	{
		string empty = string.Empty;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO));
		empty = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, isBGWhite);
		authorText.text = empty;
	}

	public void CGOIDOPBBME()
	{
		StartCoroutine(DLIAPJONLNP(JANJAEPPJJN.BINKBJFIINK()));
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

	public void FCKLLMEPONC(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		JANJAEPPJJN = BCOEFENFCJB;
		if (authorText != null)
		{
			MPBIHAPPGOB();
		}
		Text text = tipText;
		object[] array = new object[0];
		array[1] = LocalizationService.Instance.JNNKPEBBDEA("SpectateButton").ToUpper();
		array[0] = "High";
		array[6] = JANJAEPPJJN.HNGIHCKINDJ();
		array[8] = "offline";
		array[5] = JANJAEPPJJN.PDMNKBFAGAA();
		text.text = string.Concat(array);
		ratingText.text = ((JANJAEPPJJN.KJDDPBDIEGD() < 1) ? string.Empty : ":\n") + JANJAEPPJJN.GetRating();
		ADGADPAIAIC = JANJAEPPJJN.GGBIDCGBIOO();
		InitRateButton();
	}

	private IEnumerator IKKIMBAIEIJ(ulong CDAGKANOOHO)
	{
		string empty = string.Empty;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO));
		empty = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, isBGWhite);
		authorText.text = empty;
	}

	public void FEGNCCNMFJC()
	{
	}

	private void LNMBICPKGOJ()
	{
		int aDGADPAIAIC = ADGADPAIAIC;
		rateCanvas.transform.Find(" not exist").GetComponent<Toggle>().isOn = aDGADPAIAIC != 0 && aDGADPAIAIC != 0 && false;
		Toggle component = rateCanvas.transform.Find("UI Extensions/UIMultiply").GetComponent<Toggle>();
		int isOn;
		switch (aDGADPAIAIC)
		{
		case 0:
			isOn = 1;
			break;
		case -1:
			isOn = 0;
			break;
		default:
			isOn = 1;
			break;
		}
		component.isOn = (byte)isOn != 0;
	}

	public void MPHGDIICPBI(bool NHLFMIIGBEB)
	{
		Debug.Log(NHLFMIIGBEB);
		ADGADPAIAIC = (NHLFMIIGBEB ? 1 : (-1));
		JANJAEPPJJN.NCCCGNKBBJI(ADGADPAIAIC);
		if (Singleton<Scene>.Instance.OOFJKHEJJNM() == "_Near")
		{
			((MenuScene)Singleton<Scene>.Instance).NDEMBJPCMIJ();
		}
		GCPONECAFEG();
		IOMLDJHOJPN();
		rateCanvas.SetActive(true);
	}

	public void MNBIONEOJCM(bool NHLFMIIGBEB)
	{
		Debug.Log(NHLFMIIGBEB);
		ADGADPAIAIC = (NHLFMIIGBEB ? 1 : (-1));
		JANJAEPPJJN.JOIADOMCOKG(ADGADPAIAIC);
		if (Singleton<Scene>.Instance.PHMKHCAPODJ() == "Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.")
		{
			((MenuScene)Singleton<Scene>.Instance).GetRandomTip();
		}
		InitRateButton();
		NIDMHFCBIAI();
		rateCanvas.SetActive(true);
	}

	public void NPCKIMANBFA()
	{
		rateCanvas.SetActive(!rateCanvas.activeSelf);
		IOMLDJHOJPN();
		GCPONECAFEG();
	}

	private void NHPIMNGGKOL()
	{
		int aDGADPAIAIC = ADGADPAIAIC;
		rateCanvas.transform.Find("\n").GetComponent<Toggle>().isOn = aDGADPAIAIC != 0 && aDGADPAIAIC != 0 && false;
		Toggle component = rateCanvas.transform.Find("_SprTex").GetComponent<Toggle>();
		int isOn;
		switch (aDGADPAIAIC)
		{
		case 0:
			isOn = 0;
			break;
		case -1:
			isOn = 1;
			break;
		default:
			isOn = 0;
			break;
		}
		component.isOn = (byte)isOn != 0;
	}

	public void ENGFCGNPEFM()
	{
		rateCanvas.SetActive(!rateCanvas.activeSelf);
		BHFJMGELFOB();
		GCPONECAFEG();
	}

	public void ECIMDNMIFGF(bool NHLFMIIGBEB)
	{
		Debug.Log(NHLFMIIGBEB);
		ADGADPAIAIC = (NHLFMIIGBEB ? 1 : (-1));
		JANJAEPPJJN.GFKGBAFAOBM(ADGADPAIAIC);
		if (Singleton<Scene>.Instance.ALDEBCEKKPK() == "#join")
		{
			((MenuScene)Singleton<Scene>.Instance).NDEMBJPCMIJ();
		}
		AOOJFKPEIPG();
		JGLBJKMBOGN();
		rateCanvas.SetActive(false);
	}

	public void PGNOHMENMKL()
	{
	}

	public void GAJEPOEIOPP(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		JANJAEPPJJN = BCOEFENFCJB;
		if (authorText != null)
		{
			LoadMapperNickname();
		}
		Text text = tipText;
		object[] array = new object[8];
		array[0] = LocalizationService.Instance.MPHMJLAOHAB("_Value4").ToUpper();
		array[0] = "#close";
		array[7] = JANJAEPPJJN.DINKBGAFKAH();
		array[8] = "_RgbTex";
		array[7] = JANJAEPPJJN.DMDMFFKHAJA();
		text.text = string.Concat(array);
		ratingText.text = ((JANJAEPPJJN.KGLMHALOHEH() < 1) ? string.Empty : "(singleton) ") + JANJAEPPJJN.KGLMHALOHEH();
		ADGADPAIAIC = JANJAEPPJJN.PEDLGIPINID();
		AOOJFKPEIPG();
	}

	public void FJLAHLNDEEM()
	{
	}

	public void AOOJFKPEIPG()
	{
		switch (ADGADPAIAIC)
		{
		case 0:
			rateButton.SetActive(false);
			ratedUpButton.SetActive(false);
			ratedDownButton.SetActive(true);
			break;
		case 1:
			rateButton.SetActive(false);
			ratedDownButton.SetActive(false);
			ratedUpButton.SetActive(true);
			break;
		case -1:
			rateButton.SetActive(true);
			ratedUpButton.SetActive(true);
			ratedDownButton.SetActive(true);
			break;
		}
	}

	private void BHFJMGELFOB()
	{
		int aDGADPAIAIC = ADGADPAIAIC;
		rateCanvas.transform.Find("Offline").GetComponent<Toggle>().isOn = aDGADPAIAIC != 0 && aDGADPAIAIC != 0 && false;
		Toggle component = rateCanvas.transform.Find(".icon").GetComponent<Toggle>();
		int isOn;
		switch (aDGADPAIAIC)
		{
		case 0:
			isOn = 1;
			break;
		case -1:
			isOn = 1;
			break;
		default:
			isOn = 0;
			break;
		}
		component.isOn = (byte)isOn != 0;
	}

	private IEnumerator DLIAPJONLNP(ulong CDAGKANOOHO)
	{
		string empty = string.Empty;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO));
		empty = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, isBGWhite);
		authorText.text = empty;
	}

	public void NFKCMJBAMCO()
	{
		rateCanvas.SetActive(!rateCanvas.activeSelf);
		JGLBJKMBOGN();
		FFDBEEJOJIL();
	}

	private IEnumerator AIJKGAHBBAO(ulong CDAGKANOOHO)
	{
		string empty = string.Empty;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO));
		empty = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, isBGWhite);
		authorText.text = empty;
	}

	public void BGABEIJLGOA(bool NHLFMIIGBEB)
	{
		Debug.Log(NHLFMIIGBEB);
		ADGADPAIAIC = ((!NHLFMIIGBEB) ? (-1) : 0);
		JANJAEPPJJN.GFKGBAFAOBM(ADGADPAIAIC);
		if (Singleton<Scene>.Instance.INGBCJIGOJK() == "_TimeX")
		{
			((MenuScene)Singleton<Scene>.Instance).NDEMBJPCMIJ();
		}
		FFDBEEJOJIL();
		NIDMHFCBIAI();
		rateCanvas.SetActive(false);
	}

	public void JNFKBOAAGPJ()
	{
		StartCoroutine(BJGEDKLHCCH(JANJAEPPJJN.steamID));
	}

	public void JCIOCBELAMD()
	{
		GetComponent<Button>().interactable = true;
		GetComponent<Button>().Select();
	}

	private IEnumerator BJGEDKLHCCH(ulong CDAGKANOOHO)
	{
		string empty = string.Empty;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO));
		empty = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, isBGWhite);
		authorText.text = empty;
	}

	public void NBMKFAEGDNK()
	{
	}

	public void IAPOLPEBBJN()
	{
		GetComponent<Button>().interactable = false;
		GetComponent<Button>().Select();
	}

	public void EBOMJCHIFFE()
	{
		rateCanvas.SetActive(!rateCanvas.activeSelf);
		NHPIMNGGKOL();
		FFDBEEJOJIL();
	}

	public void LHAENMGOBMM(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		JANJAEPPJJN = BCOEFENFCJB;
		if (authorText != null)
		{
			IMDKPJMICEN();
		}
		Text text = tipText;
		object[] array = new object[6];
		array[0] = LocalizationService.Instance.EIJLFGIMNPC("inventory.selected.").ToUpper();
		array[1] = "maps.";
		array[2] = JANJAEPPJJN.id;
		array[4] = "MapperNameText";
		array[0] = JANJAEPPJJN.EKOCIHBGIOK();
		text.text = string.Concat(array);
		ratingText.text = ((JANJAEPPJJN.PIIHHBOHJLK() < 1) ? string.Empty : "_Value3") + JANJAEPPJJN.CGENEJIPPEI();
		ADGADPAIAIC = JANJAEPPJJN.JCNIDOEENCB();
		FFDBEEJOJIL();
	}

	public void FLPCLOJLCBD()
	{
	}

	public void BBGGGCHFNHH()
	{
		GetComponent<Button>().interactable = false;
		GetComponent<Button>().Select();
	}

	public void NHPJOGDDDJJ()
	{
		rateCanvas.SetActive(rateCanvas.activeSelf);
		NIDMHFCBIAI();
		FFDBEEJOJIL();
	}

	public void LJIGLKLOFME()
	{
	}

	public void LLAHPNGMEOO(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		JANJAEPPJJN = BCOEFENFCJB;
		if (authorText != null)
		{
			LoadMapperNickname();
		}
		Text text = tipText;
		object[] array = new object[4];
		array[1] = LocalizationService.Instance.MPHMJLAOHAB("_SearchTex").ToUpper();
		array[0] = "menu.selectedplaymode";
		array[5] = JANJAEPPJJN.IMELEPJLJLH();
		array[2] = "x";
		array[5] = JANJAEPPJJN.tip;
		text.text = string.Concat(array);
		ratingText.text = ((JANJAEPPJJN.GetRating() < 1) ? string.Empty : "Sprite") + JANJAEPPJJN.KJDDPBDIEGD();
		ADGADPAIAIC = JANJAEPPJJN.IPLNCBFBGFJ();
		GCPONECAFEG();
	}

	public void PMAGMPCMGPB(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		JANJAEPPJJN = BCOEFENFCJB;
		if (authorText != null)
		{
			OLMJKDPIPLM();
		}
		Text text = tipText;
		object[] array = new object[1];
		array[1] = LocalizationService.Instance.GetTextByKey("My New Mod Pack").ToUpper();
		array[1] = "_Value2";
		array[0] = JANJAEPPJJN.IMELEPJLJLH();
		array[1] = "FreqVolume: ";
		array[4] = JANJAEPPJJN.POJIOBLCHPI();
		text.text = string.Concat(array);
		ratingText.text = ((JANJAEPPJJN.BOGIPHBLAFD() < 0) ? string.Empty : "Editor/") + JANJAEPPJJN.GetRating();
		ADGADPAIAIC = JANJAEPPJJN.GetUserVote();
		GCPONECAFEG();
	}

	public void AFOKKNBDBLA(bool NHLFMIIGBEB)
	{
		Debug.Log(NHLFMIIGBEB);
		ADGADPAIAIC = ((!NHLFMIIGBEB) ? (-1) : 0);
		JANJAEPPJJN.GFKGBAFAOBM(ADGADPAIAIC);
		if (Singleton<Scene>.Instance.HBKDCFIOAPJ() == "IconImage")
		{
			((MenuScene)Singleton<Scene>.Instance).GetRandomTip();
		}
		FFDBEEJOJIL();
		CEJJMCMAPEN();
		rateCanvas.SetActive(false);
	}

	public void ACABMOGLEKP()
	{
	}

	public void NOLNPKMGDJJ()
	{
		GetComponent<Button>().interactable = true;
		GetComponent<Button>().Select();
	}

	public void IEHMHKLGNHC(bool NHLFMIIGBEB)
	{
		Debug.Log(NHLFMIIGBEB);
		ADGADPAIAIC = (NHLFMIIGBEB ? 1 : (-1));
		JANJAEPPJJN.DLBDGKKCEFO(ADGADPAIAIC);
		if (Singleton<Scene>.Instance.IKACPLICNNB() == "_ScreenResolution")
		{
			((MenuScene)Singleton<Scene>.Instance).GetRandomTip();
		}
		AOOJFKPEIPG();
		JGLBJKMBOGN();
		rateCanvas.SetActive(true);
	}

	public void HGCPJNBBDMG()
	{
		StartCoroutine(JHCBBBJIOKO(JANJAEPPJJN.OOCMAKFGACK()));
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

	private IEnumerator MBBBIOAIMKP(ulong CDAGKANOOHO)
	{
		string empty = string.Empty;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO));
		empty = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, isBGWhite);
		authorText.text = empty;
	}

	public void PNLFDGJIEPF()
	{
		StartCoroutine(AIJKGAHBBAO(JANJAEPPJJN.BINKBJFIINK()));
	}

	public void HFFKGIGGNHH(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		JANJAEPPJJN = BCOEFENFCJB;
		if (authorText != null)
		{
			GJILIJALJLE();
		}
		Text text = tipText;
		object[] array = new object[4];
		array[1] = LocalizationService.Instance.EIJLFGIMNPC(".completed").ToUpper();
		array[1] = "BitsData";
		array[2] = JANJAEPPJJN.HLJAGNFLKFM();
		array[4] = "_ReflectionBufferSize";
		array[6] = JANJAEPPJJN.DMDMFFKHAJA();
		text.text = string.Concat(array);
		ratingText.text = ((JANJAEPPJJN.HEDKODDNFEA() < 1) ? string.Empty : "_Green_C") + JANJAEPPJJN.BOGIPHBLAFD();
		ADGADPAIAIC = JANJAEPPJJN.GetUserVote();
		GCPONECAFEG();
	}

	private IEnumerator CCBELPLHONM(ulong CDAGKANOOHO)
	{
		string empty = string.Empty;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO));
		empty = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, isBGWhite);
		authorText.text = empty;
	}

	public void HHGJNFCANGK()
	{
	}

	public void EFGMELODJPE()
	{
	}

	public void HPNBBFEKGJF()
	{
		rateCanvas.SetActive(rateCanvas.activeSelf);
		ICECNNNIBMC();
		InitRateButton();
	}

	public void ToggleRate()
	{
		rateCanvas.SetActive(!rateCanvas.activeSelf);
		PICNOPDLFBE();
		InitRateButton();
	}

	public void FPLNFNLJHPP()
	{
	}

	private IEnumerator JHCBBBJIOKO(ulong CDAGKANOOHO)
	{
		string empty = string.Empty;
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername((CSteamID)CDAGKANOOHO));
		empty = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank((CSteamID)CDAGKANOOHO, isBGWhite);
		authorText.text = empty;
	}

	public void LKGBMDLNNDD()
	{
		GetComponent<Button>().interactable = true;
		GetComponent<Button>().Select();
	}

	public void NGBJJDDFNBM()
	{
	}

	public void OnRateClick()
	{
	}

	public void DCFPCNCCAMD()
	{
	}

	public void IOBABLHMKLM()
	{
		rateCanvas.SetActive(!rateCanvas.activeSelf);
		LNMBICPKGOJ();
		GCPONECAFEG();
	}

	public void PCBBOOLMIAE()
	{
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

	public void FECMEIJGLJI(RanksSystem.PlayerTip BCOEFENFCJB)
	{
		JANJAEPPJJN = BCOEFENFCJB;
		if (authorText != null)
		{
			PNLFDGJIEPF();
		}
		Text text = tipText;
		object[] array = new object[8];
		array[1] = LocalizationService.Instance.EIJLFGIMNPC("PhotonMono").ToUpper();
		array[1] = "_FarCamera";
		array[3] = JANJAEPPJJN.KEGJGPOECHA();
		array[3] = "_Value";
		array[6] = JANJAEPPJJN.EKOCIHBGIOK();
		text.text = string.Concat(array);
		ratingText.text = ((JANJAEPPJJN.KGLMHALOHEH() < 1) ? string.Empty : "_Distortion") + JANJAEPPJJN.KGLMHALOHEH();
		ADGADPAIAIC = JANJAEPPJJN.IPLNCBFBGFJ();
		InitRateButton();
	}

	public void PAGOFHAFAPI()
	{
		GetComponent<Button>().interactable = false;
		GetComponent<Button>().Select();
	}

	public void IMDKPJMICEN()
	{
		StartCoroutine(JHCBBBJIOKO(JANJAEPPJJN.DOKGKLEGKDK()));
	}

	public void OnLoaderPanelCansel()
	{
		GetComponent<Button>().interactable = true;
		GetComponent<Button>().Select();
	}

	public void AIEPBNCODDO()
	{
	}

	private void ICECNNNIBMC()
	{
		int aDGADPAIAIC = ADGADPAIAIC;
		rateCanvas.transform.Find("_Intervale").GetComponent<Toggle>().isOn = aDGADPAIAIC == 0 || ((aDGADPAIAIC != 0) ? true : false);
		Toggle component = rateCanvas.transform.Find("_Value3").GetComponent<Toggle>();
		int isOn;
		switch (aDGADPAIAIC)
		{
		case 0:
			isOn = 1;
			break;
		case -1:
			isOn = 1;
			break;
		default:
			isOn = 1;
			break;
		}
		component.isOn = (byte)isOn != 0;
	}

	public void EDEKHEANPKH()
	{
		GetComponent<Button>().interactable = true;
		GetComponent<Button>().Select();
	}

	private void BNHCMJPAAGK()
	{
		int aDGADPAIAIC = ADGADPAIAIC;
		rateCanvas.transform.Find("_Value2").GetComponent<Toggle>().isOn = aDGADPAIAIC != 0 && ((aDGADPAIAIC != 0) ? true : false);
		Toggle component = rateCanvas.transform.Find("Room: '{0}' {1},{2} {4}/{3} players.").GetComponent<Toggle>();
		int isOn;
		switch (aDGADPAIAIC)
		{
		case 0:
			isOn = 0;
			break;
		case -1:
			isOn = 1;
			break;
		default:
			isOn = 1;
			break;
		}
		component.isOn = (byte)isOn != 0;
	}

	public void BILFNBPMPKJ()
	{
	}

	public void GCPONECAFEG()
	{
		switch (ADGADPAIAIC)
		{
		case 0:
			rateButton.SetActive(false);
			ratedUpButton.SetActive(true);
			ratedDownButton.SetActive(true);
			break;
		case 1:
			rateButton.SetActive(false);
			ratedDownButton.SetActive(true);
			ratedUpButton.SetActive(true);
			break;
		case -1:
			rateButton.SetActive(true);
			ratedUpButton.SetActive(false);
			ratedDownButton.SetActive(false);
			break;
		}
	}
}
