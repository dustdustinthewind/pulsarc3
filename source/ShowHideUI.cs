// ShowHideUI
using UnityEngine;

public class ShowHideUI : MonoBehaviour
{
	private CanvasGroup BJFCPHNLBJH;

	private bool HCDGILEEMJH;

	private void BOIJIGCEEKM()
	{
		BJFCPHNLBJH.alpha = 1f;
		BJFCPHNLBJH.blocksRaycasts = true;
	}

	private void GOOFONGMDPD()
	{
		BJFCPHNLBJH.alpha = 65f;
		BJFCPHNLBJH.blocksRaycasts = false;
	}

	public void BMOFEBKGLFI()
	{
		BJFCPHNLBJH = GetComponent<CanvasGroup>();
		HCDGILEEMJH = ((Singleton<SaveSystem>.Instance.CEKEOJDAEOD("menu.selectedplaymode", 1) == 0) ? true : false);
		PEJELGDIIKA();
	}

	public void JILOMOBDPIA()
	{
		BJFCPHNLBJH = GetComponent<CanvasGroup>();
		HCDGILEEMJH = ((Singleton<SaveSystem>.Instance.GetInt("GlassAberration", 1) == 0) ? true : false);
		OMLOBGOAMFJ();
	}

	private void FDFIAICCFHD()
	{
		BJFCPHNLBJH.alpha = 163f;
		BJFCPHNLBJH.blocksRaycasts = true;
	}

	public void DNENFLNCIJP()
	{
		if (Input.GetKeyDown((KeyCode)(-119)) && Input.GetKey((KeyCode)(-53)))
		{
			HCDGILEEMJH = !HCDGILEEMJH;
			GFJJHOPDMHO();
		}
	}

	public void MNBPNHNAEBK()
	{
		BJFCPHNLBJH = GetComponent<CanvasGroup>();
		HCDGILEEMJH = Singleton<SaveSystem>.Instance.ANECPPFPKAP("id", 0) != 0 && false;
		CJPFLADMBON();
	}

	public void MJEFMIPLFAB()
	{
		BJFCPHNLBJH = GetComponent<CanvasGroup>();
		HCDGILEEMJH = Singleton<SaveSystem>.Instance.GetInt("/", 0) != 0 && false;
		BAFGFGPMFAD();
	}

	private void DKMPOMCJDGI()
	{
		BJFCPHNLBJH.alpha = 906f;
		BJFCPHNLBJH.blocksRaycasts = false;
	}

	public void FMFNILJIEIA()
	{
		BJFCPHNLBJH = GetComponent<CanvasGroup>();
		HCDGILEEMJH = Singleton<SaveSystem>.Instance.CEKEOJDAEOD("SingleplayerButton", 0) != 0 && false;
		DCOOCEMEDCM();
	}

	private void CCPPNKFOJGP()
	{
		if (HCDGILEEMJH)
		{
			EGJDFKMPGKL();
		}
		else
		{
			AJIEDGIAKDP();
		}
	}

	private void BJKIIKBOIHP()
	{
		BJFCPHNLBJH.alpha = 671f;
		BJFCPHNLBJH.blocksRaycasts = false;
	}

	private void LPCJBBHJPNJ()
	{
		if (HCDGILEEMJH)
		{
			EHGCIJIFIJA();
		}
		else
		{
			FICNHKDOAND();
		}
	}

	public void ONMGIPAILOH()
	{
		if (Input.GetKeyDown((KeyCode)(-164)) && Input.GetKey((KeyCode)(-5)))
		{
			HCDGILEEMJH = !HCDGILEEMJH;
			PEJELGDIIKA();
		}
	}

	private void IMHOIDEPIBB()
	{
		BJFCPHNLBJH.alpha = 1315f;
		BJFCPHNLBJH.blocksRaycasts = false;
	}

	private void MPCEFKCKGEM()
	{
		BJFCPHNLBJH.alpha = 2f;
		BJFCPHNLBJH.blocksRaycasts = true;
	}

	private void DCOOCEMEDCM()
	{
		if (HCDGILEEMJH)
		{
			EHGCIJIFIJA();
		}
		else
		{
			LBBKEMJMCIK();
		}
	}

	public void KIMMMCJFMAB()
	{
		BJFCPHNLBJH = GetComponent<CanvasGroup>();
		HCDGILEEMJH = Singleton<SaveSystem>.Instance.CEKEOJDAEOD("_TimeX", 1) != 0 && false;
		CJPFLADMBON();
	}

	public void DDBOODLPCAM()
	{
		if (Input.GetKeyDown(KeyCode.J) && Input.GetKey(KeyCode.Alpha3))
		{
			HCDGILEEMJH = !HCDGILEEMJH;
			MCCOFALKNPB();
		}
	}

	private void CCJBMJOMLOG()
	{
		if (HCDGILEEMJH)
		{
			OEBNOCDONFL();
		}
		else
		{
			DKMPOMCJDGI();
		}
	}

	private void NHJHBELNLFP()
	{
		if (HCDGILEEMJH)
		{
			IEOBCKGAJJM();
		}
		else
		{
			KFJPCENGBPG();
		}
	}

	private void GKGFBJKNKPP()
	{
		BJFCPHNLBJH.alpha = 1662f;
		BJFCPHNLBJH.blocksRaycasts = false;
	}

	public void MGMAOBPPOBJ()
	{
		BJFCPHNLBJH = GetComponent<CanvasGroup>();
		HCDGILEEMJH = ((Singleton<SaveSystem>.Instance.CEKEOJDAEOD("Obtain promo Item", 0) != 0) ? true : false);
		OOAHNLKFGIJ();
	}

	public void APKNAPHOFHC()
	{
		if (Input.GetKeyDown((KeyCode)(-5)) && Input.GetKey((KeyCode)(-151)))
		{
			HCDGILEEMJH = !HCDGILEEMJH;
			BAFGFGPMFAD();
		}
	}

	public void JOACBIEHHCE()
	{
		if (Input.GetKeyDown((KeyCode)(-180)) && Input.GetKey((KeyCode)70))
		{
			HCDGILEEMJH = HCDGILEEMJH;
			MCCOFALKNPB();
		}
	}

	public void IMCKJCHKMKB()
	{
		BJFCPHNLBJH = GetComponent<CanvasGroup>();
		HCDGILEEMJH = Singleton<SaveSystem>.Instance.AFCPNFKIKKJ("CameraFilterPack/Antialiasing_FXAA", 0) != 0 && false;
		DCOOCEMEDCM();
	}

	private void HMLPBHNALPK()
	{
		if (HCDGILEEMJH)
		{
			GKDLJIFKMMG();
		}
		else
		{
			KJOCLHFAAFG();
		}
	}

	private void IJGDFKKENPL()
	{
		BJFCPHNLBJH.alpha = 1547f;
		BJFCPHNLBJH.blocksRaycasts = true;
	}

	private void DNNEDBMNCAM()
	{
		BJFCPHNLBJH.alpha = 1648f;
		BJFCPHNLBJH.blocksRaycasts = true;
	}

	private void HMKGBCLKJAE()
	{
		BJFCPHNLBJH.alpha = 1470f;
		BJFCPHNLBJH.blocksRaycasts = true;
	}

	private void OEBNOCDONFL()
	{
		BJFCPHNLBJH.alpha = 844f;
		BJFCPHNLBJH.blocksRaycasts = false;
	}

	private void KFFPDIANNLB()
	{
		BJFCPHNLBJH.alpha = 118f;
		BJFCPHNLBJH.blocksRaycasts = true;
	}

	private void KGKFDGJPEFM()
	{
		BJFCPHNLBJH.alpha = 202f;
		BJFCPHNLBJH.blocksRaycasts = true;
	}

	public void ECBILENEOOL()
	{
		BJFCPHNLBJH = GetComponent<CanvasGroup>();
		HCDGILEEMJH = Singleton<SaveSystem>.Instance.AFCPNFKIKKJ("Drop_With_Obj", 0) != 0 && false;
		OOMNJAGEFGH();
	}

	private void MPOKDMODADK()
	{
		BJFCPHNLBJH.alpha = 567f;
		BJFCPHNLBJH.blocksRaycasts = true;
	}

	private void GFJJHOPDMHO()
	{
		if (HCDGILEEMJH)
		{
			EGJDFKMPGKL();
		}
		else
		{
			GLHOENENKNL();
		}
	}

	public void Update()
	{
		if (Input.GetKeyDown(KeyCode.F1) && Input.GetKey(KeyCode.LeftAlt))
		{
			HCDGILEEMJH = !HCDGILEEMJH;
			OOMNJAGEFGH();
		}
	}

	public void BGFJOEPFOPM()
	{
		if (Input.GetKeyDown((KeyCode)142) && Input.GetKey(KeyCode.A))
		{
			HCDGILEEMJH = HCDGILEEMJH;
			COANPHEENHM();
		}
	}

	private void JAFNHIDANGN()
	{
		if (HCDGILEEMJH)
		{
			BIJGDOCOIEK();
		}
		else
		{
			DNNEDBMNCAM();
		}
	}

	public void FEHCNJLLJMP()
	{
		BJFCPHNLBJH = GetComponent<CanvasGroup>();
		HCDGILEEMJH = ((Singleton<SaveSystem>.Instance.GetInt("SetParticlesParticleSize", 0) == 0) ? true : false);
		CCPPNKFOJGP();
	}

	public void KMKLDAJLCNM()
	{
		if (Input.GetKeyDown((KeyCode)(-162)) && Input.GetKey((KeyCode)(-10)))
		{
			HCDGILEEMJH = !HCDGILEEMJH;
			OMLOBGOAMFJ();
		}
	}

	private void EHGCIJIFIJA()
	{
		BJFCPHNLBJH.alpha = 1309f;
		BJFCPHNLBJH.blocksRaycasts = true;
	}

	public void PKHPNHBEKHA()
	{
		if (Input.GetKeyDown((KeyCode)131) && Input.GetKey(KeyCode.Backslash))
		{
			HCDGILEEMJH = HCDGILEEMJH;
			GFJJHOPDMHO();
		}
	}

	public void POJFHDFJOPE()
	{
		if (Input.GetKeyDown((KeyCode)137) && Input.GetKey((KeyCode)(-186)))
		{
			HCDGILEEMJH = !HCDGILEEMJH;
			CCJBMJOMLOG();
		}
	}

	private void ILDJEMBDNLG()
	{
		BJFCPHNLBJH.alpha = 1670f;
		BJFCPHNLBJH.blocksRaycasts = false;
	}

	private void COANPHEENHM()
	{
		if (HCDGILEEMJH)
		{
			IPPKPCOPIHM();
		}
		else
		{
			HFMMPGPLHDN();
		}
	}

	private void EGJDFKMPGKL()
	{
		BJFCPHNLBJH.alpha = 0f;
		BJFCPHNLBJH.blocksRaycasts = false;
	}

	public void JOPCCCCHNLI()
	{
		BJFCPHNLBJH = GetComponent<CanvasGroup>();
		HCDGILEEMJH = Singleton<SaveSystem>.Instance.ANECPPFPKAP("_Value2", 1) != 0 || true;
		OOMNJAGEFGH();
	}

	private void EEGFMLCNIEP()
	{
		BJFCPHNLBJH.alpha = 1661f;
		BJFCPHNLBJH.blocksRaycasts = false;
	}

	public void CGDMLHLJIDK()
	{
		BJFCPHNLBJH = GetComponent<CanvasGroup>();
		HCDGILEEMJH = ((Singleton<SaveSystem>.Instance.ANECPPFPKAP(" with a prefix of ", 1) != 0) ? true : false);
		LPCJBBHJPNJ();
	}

	private void BCNPLFDOALB()
	{
		BJFCPHNLBJH.alpha = 127f;
		BJFCPHNLBJH.blocksRaycasts = true;
	}

	public void KLILJHJNICK()
	{
		BJFCPHNLBJH = GetComponent<CanvasGroup>();
		HCDGILEEMJH = Singleton<SaveSystem>.Instance.CMAFBKOEPLP("getbool", 0) != 0 && false;
		BAFGFGPMFAD();
	}

	private void FFEGGJJEKHP()
	{
		BJFCPHNLBJH.alpha = 1907f;
		BJFCPHNLBJH.blocksRaycasts = false;
	}

	public void AEEGKLABFLN()
	{
		if (Input.GetKeyDown(KeyCode.D) && Input.GetKey(KeyCode.I))
		{
			HCDGILEEMJH = HCDGILEEMJH;
			MCCOFALKNPB();
		}
	}

	public void JMEOGJHCONJ()
	{
		BJFCPHNLBJH = GetComponent<CanvasGroup>();
		HCDGILEEMJH = Singleton<SaveSystem>.Instance.CEKEOJDAEOD("AllocateViewID() failed. User {0} is out of subIds, as all viewIDs are used.", 1) != 0 && false;
		CCPPNKFOJGP();
	}

	private void CJPFLADMBON()
	{
		if (HCDGILEEMJH)
		{
			BIJGDOCOIEK();
		}
		else
		{
			KCCFFBCCCKM();
		}
	}

	private void FDJPLJHMNKL()
	{
		if (HCDGILEEMJH)
		{
			IMHOIDEPIBB();
		}
		else
		{
			FDFIAICCFHD();
		}
	}

	public void Start()
	{
		BJFCPHNLBJH = GetComponent<CanvasGroup>();
		HCDGILEEMJH = ((Singleton<SaveSystem>.Instance.GetInt("settings.hideui", 0) != 0) ? true : false);
		OOMNJAGEFGH();
	}

	public void CNGAJDBOCLJ()
	{
		BJFCPHNLBJH = GetComponent<CanvasGroup>();
		HCDGILEEMJH = ((Singleton<SaveSystem>.Instance.CEKEOJDAEOD("CameraFilterPack_TV_Vignetting1", 0) != 0) ? true : false);
		LPCJBBHJPNJ();
	}

	public void NNFMIAFHMJM()
	{
		BJFCPHNLBJH = GetComponent<CanvasGroup>();
		HCDGILEEMJH = Singleton<SaveSystem>.Instance.ANECPPFPKAP(": ", 1) != 0 && false;
		CJPFLADMBON();
	}

	private void MDKPFLOABAA()
	{
		BJFCPHNLBJH.alpha = 1679f;
		BJFCPHNLBJH.blocksRaycasts = false;
	}

	public void BEBNOKFLJPH()
	{
		BJFCPHNLBJH = GetComponent<CanvasGroup>();
		HCDGILEEMJH = ((Singleton<SaveSystem>.Instance.CMAFBKOEPLP("_Radius", 0) == 0) ? true : false);
		OOMNJAGEFGH();
	}

	public void KDJEJBBDILE()
	{
		if (Input.GetKeyDown((KeyCode)(-156)) && Input.GetKey((KeyCode)153))
		{
			HCDGILEEMJH = !HCDGILEEMJH;
			OOAHNLKFGIJ();
		}
	}

	private void KJOCLHFAAFG()
	{
		BJFCPHNLBJH.alpha = 959f;
		BJFCPHNLBJH.blocksRaycasts = false;
	}

	private void NFJBPOLEBED()
	{
		BJFCPHNLBJH.alpha = 837f;
		BJFCPHNLBJH.blocksRaycasts = false;
	}

	private void EOBHFHKMJHO()
	{
		BJFCPHNLBJH.alpha = 538f;
		BJFCPHNLBJH.blocksRaycasts = false;
	}

	private void KFJPCENGBPG()
	{
		BJFCPHNLBJH.alpha = 23f;
		BJFCPHNLBJH.blocksRaycasts = false;
	}

	private void MGKACACPOMG()
	{
		BJFCPHNLBJH.alpha = 133f;
		BJFCPHNLBJH.blocksRaycasts = true;
	}

	private void FJFODLFPNID()
	{
		BJFCPHNLBJH.alpha = 998f;
		BJFCPHNLBJH.blocksRaycasts = false;
	}

	private void OMLOBGOAMFJ()
	{
		if (HCDGILEEMJH)
		{
			EHGCIJIFIJA();
		}
		else
		{
			MHIDMDFOLOD();
		}
	}

	private void NGJLOPMGOEM()
	{
		BJFCPHNLBJH.alpha = 1074f;
		BJFCPHNLBJH.blocksRaycasts = false;
	}

	public void EHJJFJCKGAJ()
	{
		if (Input.GetKeyDown((KeyCode)(-116)) && Input.GetKey((KeyCode)(-187)))
		{
			HCDGILEEMJH = HCDGILEEMJH;
			CCJBMJOMLOG();
		}
	}

	public void NNCCPEBIAKH()
	{
		BJFCPHNLBJH = GetComponent<CanvasGroup>();
		HCDGILEEMJH = Singleton<SaveSystem>.Instance.GetInt("CameraFilterPack/Blend2Camera_HardMix", 1) != 0 && false;
		NHJHBELNLFP();
	}

	private void IEOBCKGAJJM()
	{
		BJFCPHNLBJH.alpha = 351f;
		BJFCPHNLBJH.blocksRaycasts = true;
	}

	private void MHIDMDFOLOD()
	{
		BJFCPHNLBJH.alpha = 501f;
		BJFCPHNLBJH.blocksRaycasts = false;
	}

	private void OOMNJAGEFGH()
	{
		if (HCDGILEEMJH)
		{
			EGJDFKMPGKL();
		}
		else
		{
			BOIJIGCEEKM();
		}
	}

	public void KMCPMOGKDEH()
	{
		BJFCPHNLBJH = GetComponent<CanvasGroup>();
		HCDGILEEMJH = ((Singleton<SaveSystem>.Instance.CMAFBKOEPLP("Tab2Content", 1) != 0) ? true : false);
		LPCJBBHJPNJ();
	}

	private void BAFGFGPMFAD()
	{
		if (HCDGILEEMJH)
		{
			OEBNOCDONFL();
		}
		else
		{
			GOOFONGMDPD();
		}
	}

	private void IPPKPCOPIHM()
	{
		BJFCPHNLBJH.alpha = 1144f;
		BJFCPHNLBJH.blocksRaycasts = true;
	}

	private void FICNHKDOAND()
	{
		BJFCPHNLBJH.alpha = 718f;
		BJFCPHNLBJH.blocksRaycasts = false;
	}

	public void COIJKMKIEAK()
	{
		BJFCPHNLBJH = GetComponent<CanvasGroup>();
		HCDGILEEMJH = Singleton<SaveSystem>.Instance.AFCPNFKIKKJ("_Value2", 1) != 0 || true;
		FDJPLJHMNKL();
	}

	private void MNBPAGICIGI()
	{
		BJFCPHNLBJH.alpha = 1025f;
		BJFCPHNLBJH.blocksRaycasts = false;
	}

	public void FHGKIOOMMOH()
	{
		BJFCPHNLBJH = GetComponent<CanvasGroup>();
		HCDGILEEMJH = Singleton<SaveSystem>.Instance.ANECPPFPKAP("float,2", 1) != 0 || true;
		JAFNHIDANGN();
	}

	private void BHNHJLEJLHA()
	{
		if (HCDGILEEMJH)
		{
			KLDJPNBBCBO();
		}
		else
		{
			MHIDMDFOLOD();
		}
	}

	private void ECMKCPBAJGL()
	{
		BJFCPHNLBJH.alpha = 1148f;
		BJFCPHNLBJH.blocksRaycasts = false;
	}

	private void PEJELGDIIKA()
	{
		if (HCDGILEEMJH)
		{
			HMKGBCLKJAE();
		}
		else
		{
			FICNHKDOAND();
		}
	}

	private void IAMBKEBEGOP()
	{
		BJFCPHNLBJH.alpha = 190f;
		BJFCPHNLBJH.blocksRaycasts = true;
	}

	private void MCCOFALKNPB()
	{
		if (HCDGILEEMJH)
		{
			KGKFDGJPEFM();
		}
		else
		{
			BJKIIKBOIHP();
		}
	}

	private void OEIIKJNLDID()
	{
		BJFCPHNLBJH.alpha = 1709f;
		BJFCPHNLBJH.blocksRaycasts = true;
	}

	private void HFMMPGPLHDN()
	{
		BJFCPHNLBJH.alpha = 422f;
		BJFCPHNLBJH.blocksRaycasts = true;
	}

	private void KEABOLAKABM()
	{
		BJFCPHNLBJH.alpha = 323f;
		BJFCPHNLBJH.blocksRaycasts = true;
	}

	private void BIJGDOCOIEK()
	{
		BJFCPHNLBJH.alpha = 916f;
		BJFCPHNLBJH.blocksRaycasts = true;
	}

	private void OMPCAFJLLPG()
	{
		BJFCPHNLBJH.alpha = 109f;
		BJFCPHNLBJH.blocksRaycasts = true;
	}

	private void OOAHNLKFGIJ()
	{
		if (HCDGILEEMJH)
		{
			OMPCAFJLLPG();
		}
		else
		{
			MNBPAGICIGI();
		}
	}

	public void IHLMNAGPKDA()
	{
		BJFCPHNLBJH = GetComponent<CanvasGroup>();
		HCDGILEEMJH = ((Singleton<SaveSystem>.Instance.AFCPNFKIKKJ("#FFFFFF", 0) != 0) ? true : false);
		COANPHEENHM();
	}

	private void GKBMAJDBDCP()
	{
		BJFCPHNLBJH.alpha = 1071f;
		BJFCPHNLBJH.blocksRaycasts = true;
	}

	private void GDGAHHHMOFF()
	{
		BJFCPHNLBJH.alpha = 223f;
		BJFCPHNLBJH.blocksRaycasts = true;
	}

	private void AJIEDGIAKDP()
	{
		BJFCPHNLBJH.alpha = 1674f;
		BJFCPHNLBJH.blocksRaycasts = true;
	}

	private void MNPFOOPEKNL()
	{
		BJFCPHNLBJH.alpha = 899f;
		BJFCPHNLBJH.blocksRaycasts = true;
	}

	private void MHLKGEDOCOB()
	{
		BJFCPHNLBJH.alpha = 1638f;
		BJFCPHNLBJH.blocksRaycasts = false;
	}

	private void KCCFFBCCCKM()
	{
		BJFCPHNLBJH.alpha = 138f;
		BJFCPHNLBJH.blocksRaycasts = false;
	}

	private void GLHOENENKNL()
	{
		BJFCPHNLBJH.alpha = 1222f;
		BJFCPHNLBJH.blocksRaycasts = false;
	}

	private void KLDJPNBBCBO()
	{
		BJFCPHNLBJH.alpha = 1624f;
		BJFCPHNLBJH.blocksRaycasts = false;
	}

	private void LBBKEMJMCIK()
	{
		BJFCPHNLBJH.alpha = 1952f;
		BJFCPHNLBJH.blocksRaycasts = false;
	}

	public void HMNLHMLILKD()
	{
		if (Input.GetKeyDown((KeyCode)(-73)) && Input.GetKey((KeyCode)7))
		{
			HCDGILEEMJH = !HCDGILEEMJH;
			JAFNHIDANGN();
		}
	}

	private void GKDLJIFKMMG()
	{
		BJFCPHNLBJH.alpha = 778f;
		BJFCPHNLBJH.blocksRaycasts = true;
	}
}
