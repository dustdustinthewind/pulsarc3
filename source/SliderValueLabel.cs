// SliderValueLabel
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.UI;

public class SliderValueLabel : MonoBehaviour
{
	[Serializable]
	public class SliderKeyValue
	{
		public string key;

		public string value;
	}

	[CompilerGenerated]
	private sealed class DMGPIKIKABE
	{
		internal string IHIAMPBEFEE;

		internal bool DGDCNDCGPCP(SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == IHIAMPBEFEE;
		}

		internal bool OFHCGKJFGDI(SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == IHIAMPBEFEE;
		}

		internal bool FFEGPHJKMFK(SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == IHIAMPBEFEE;
		}

		internal bool LGKMMLGKBEF(SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == IHIAMPBEFEE;
		}

		internal bool LKLABDAJAEH(SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == IHIAMPBEFEE;
		}

		internal bool DAICIOGOPNL(SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == IHIAMPBEFEE;
		}

		internal bool GMLFBOMLINM(SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == IHIAMPBEFEE;
		}

		internal bool LLGBONGFMBH(SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == IHIAMPBEFEE;
		}

		internal bool HBJFIOJFBHC(SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == IHIAMPBEFEE;
		}

		internal bool BDGDIDPDBHG(SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == IHIAMPBEFEE;
		}

		internal bool JKEDCEOCPJO(SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == IHIAMPBEFEE;
		}

		internal bool AGJKEBOPIOC(SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == IHIAMPBEFEE;
		}

		internal bool GBKBDKHPLKG(SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == IHIAMPBEFEE;
		}

		internal bool KFNPHCCAJFD(SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == IHIAMPBEFEE;
		}

		internal bool IGFOBPKFCDJ(SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == IHIAMPBEFEE;
		}

		internal bool KFNBKFELFLH(SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == IHIAMPBEFEE;
		}

		internal bool HMMBBDJNGGL(SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == IHIAMPBEFEE;
		}

		internal bool BFEABMIFIEE(SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == IHIAMPBEFEE;
		}

		internal bool DIOBKCECBCH(SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == IHIAMPBEFEE;
		}

		internal bool FIPCLHEKKCA(SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == IHIAMPBEFEE;
		}

		internal bool HNMFCOHLALO(SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == IHIAMPBEFEE;
		}

		internal bool ONEPCCGOEKI(SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == IHIAMPBEFEE;
		}

		internal bool EGKGJJGAPMN(SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == IHIAMPBEFEE;
		}

		internal bool BKNHHGBPLGH(SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == IHIAMPBEFEE;
		}

		internal bool MMJGKBNKFGM(SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == IHIAMPBEFEE;
		}

		internal bool BMAOCLKPNNC(SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == IHIAMPBEFEE;
		}

		internal bool HCFLGKJFKFE(SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == IHIAMPBEFEE;
		}

		internal bool MEMPOPNAEDN(SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == IHIAMPBEFEE;
		}

		internal bool LNDGINDKPFA(SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == IHIAMPBEFEE;
		}

		internal bool KGKMOLCPDIH(SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == IHIAMPBEFEE;
		}
	}

	public float multiply = 1f;

	public bool cut = true;

	public string cutFormat = "0";

	public string textBefore = string.Empty;

	public string textAfter = string.Empty;

	public List<SliderKeyValue> customKeyValues = new List<SliderKeyValue>();

	private void MKIMDFLBFOM()
	{
		MPNBGMNPFNJ();
	}

	private void KKLMPKLKAEM()
	{
		ILBEEBHIDEG();
	}

	private void AKHCOBHHGJP()
	{
		FAGCFADJMDI();
	}

	private void JMEOGJHCONJ()
	{
		OIBELCAKKHH();
	}

	private void CGDMLHLJIDK()
	{
		DHECOKJKOIG();
	}

	private void MJNPIDGNJMK()
	{
		JOLJFGLFNCK();
	}

	public void NGLIPNLHBFK()
	{
		string IHIAMPBEFEE = ((!cut) ? (GetComponentInParent<Slider>().value * multiply).ToString() : (GetComponentInParent<Slider>().value * multiply).ToString(cutFormat));
		GetComponent<Text>().text = textBefore + IHIAMPBEFEE + textAfter;
		if (customKeyValues.Count > 0 && customKeyValues.Exists((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE))
		{
			GetComponent<Text>().text = textBefore + LocalizationService.Instance.HOPMEAJKPHL(customKeyValues.Find((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE).value) + textAfter;
		}
	}

	public void OIBELCAKKHH()
	{
		string IHIAMPBEFEE = ((!cut) ? (GetComponentInParent<Slider>().value * multiply).ToString() : (GetComponentInParent<Slider>().value * multiply).ToString(cutFormat));
		GetComponent<Text>().text = textBefore + IHIAMPBEFEE + textAfter;
		if (customKeyValues.Count > 0 && customKeyValues.Exists((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE))
		{
			GetComponent<Text>().text = textBefore + LocalizationService.Instance.GetLocalizatedText(customKeyValues.Find((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE).value) + textAfter;
		}
	}

	public void FJMDFKMLIJC()
	{
		string IHIAMPBEFEE = ((!cut) ? (GetComponentInParent<Slider>().value * multiply).ToString() : (GetComponentInParent<Slider>().value * multiply).ToString(cutFormat));
		GetComponent<Text>().text = textBefore + IHIAMPBEFEE + textAfter;
		if (customKeyValues.Count > 1 && customKeyValues.Exists((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE))
		{
			GetComponent<Text>().text = textBefore + LocalizationService.Instance.GetLocalizatedText(customKeyValues.Find((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE).value) + textAfter;
		}
	}

	private void PFNFPINPCMH()
	{
		ILBEEBHIDEG();
	}

	private void LCDJFJIBADI()
	{
		FAODNNBJEML();
	}

	private void EHCGBJDFMHG()
	{
		IOMCOLOEHFL();
	}

	private void AEEGKLABFLN()
	{
		POFHAJFLAPK();
	}

	private void GMELGGJOPBB()
	{
		NGLIPNLHBFK();
	}

	private void BGDPIHMAACO()
	{
		FAGCFADJMDI();
	}

	private void MDCFIHDPLIG()
	{
		NNFCMCBGICF();
	}

	private void JKFDDNMPOJH()
	{
		LMJPEEKJGPK();
	}

	public void HMFLACFDMAA()
	{
		string IHIAMPBEFEE = ((!cut) ? (GetComponentInParent<Slider>().value * multiply).ToString() : (GetComponentInParent<Slider>().value * multiply).ToString(cutFormat));
		GetComponent<Text>().text = textBefore + IHIAMPBEFEE + textAfter;
		if (customKeyValues.Count > 1 && customKeyValues.Exists((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE))
		{
			GetComponent<Text>().text = textBefore + LocalizationService.Instance.HOPMEAJKPHL(customKeyValues.Find((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE).value) + textAfter;
		}
	}

	private void JOACBIEHHCE()
	{
		POFHAJFLAPK();
	}

	public void FAGCFADJMDI()
	{
		string IHIAMPBEFEE = ((!cut) ? (GetComponentInParent<Slider>().value * multiply).ToString() : (GetComponentInParent<Slider>().value * multiply).ToString(cutFormat));
		GetComponent<Text>().text = textBefore + IHIAMPBEFEE + textAfter;
		if (customKeyValues.Count > 1 && customKeyValues.Exists((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE))
		{
			GetComponent<Text>().text = textBefore + LocalizationService.Instance.GetLocalizatedText(customKeyValues.Find((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE).value) + textAfter;
		}
	}

	private void HLDFOJMHKNL()
	{
		IODAIHCJOMN();
	}

	public void NKDIBKDAENF()
	{
		string IHIAMPBEFEE = ((!cut) ? (GetComponentInParent<Slider>().value * multiply).ToString() : (GetComponentInParent<Slider>().value * multiply).ToString(cutFormat));
		GetComponent<Text>().text = textBefore + IHIAMPBEFEE + textAfter;
		if (customKeyValues.Count > 1 && customKeyValues.Exists((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE))
		{
			GetComponent<Text>().text = textBefore + LocalizationService.Instance.HOPMEAJKPHL(customKeyValues.Find((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE).value) + textAfter;
		}
	}

	public void HOHFDDNCGCC()
	{
		string IHIAMPBEFEE = ((!cut) ? (GetComponentInParent<Slider>().value * multiply).ToString() : (GetComponentInParent<Slider>().value * multiply).ToString(cutFormat));
		GetComponent<Text>().text = textBefore + IHIAMPBEFEE + textAfter;
		if (customKeyValues.Count > 1 && customKeyValues.Exists((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE))
		{
			GetComponent<Text>().text = textBefore + LocalizationService.Instance.HOPMEAJKPHL(customKeyValues.Find((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE).value) + textAfter;
		}
	}

	private void DPLLKHHLDBB()
	{
		IOMCOLOEHFL();
	}

	private void AEMGPJDJGBJ()
	{
		IEAMEOBKGBP();
	}

	private void LBIOIEANMGI()
	{
		NNFCMCBGICF();
	}

	private void FOLDLDLFFLM()
	{
		MOAGIBHBDGJ();
	}

	private void MAOCOEGAFND()
	{
		DLHNBKDMPIO();
	}

	private void KDMKDEKCELE()
	{
		EKMAGCOPLPD();
	}

	private void IKMELABKBHO()
	{
		LMJPEEKJGPK();
	}

	private void IEMEHGCFAPD()
	{
		GCFNHPDPOOL();
	}

	public void DLHNBKDMPIO()
	{
		string IHIAMPBEFEE = ((!cut) ? (GetComponentInParent<Slider>().value * multiply).ToString() : (GetComponentInParent<Slider>().value * multiply).ToString(cutFormat));
		GetComponent<Text>().text = textBefore + IHIAMPBEFEE + textAfter;
		if (customKeyValues.Count > 1 && customKeyValues.Exists((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE))
		{
			GetComponent<Text>().text = textBefore + LocalizationService.Instance.GetLocalizatedText(customKeyValues.Find((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE).value) + textAfter;
		}
	}

	private void DKOPKPBLDHH()
	{
		GFMKDMAKECF();
	}

	private void EIMNPCMHJLJ()
	{
		OIBELCAKKHH();
	}

	public void DFMLOIEKHLG()
	{
		string IHIAMPBEFEE = ((!cut) ? (GetComponentInParent<Slider>().value * multiply).ToString() : (GetComponentInParent<Slider>().value * multiply).ToString(cutFormat));
		GetComponent<Text>().text = textBefore + IHIAMPBEFEE + textAfter;
		if (customKeyValues.Count > 0 && customKeyValues.Exists((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE))
		{
			GetComponent<Text>().text = textBefore + LocalizationService.Instance.GetLocalizatedText(customKeyValues.Find((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE).value) + textAfter;
		}
	}

	private void DLBODOFAJGM()
	{
		KCOBKOMDIKN();
	}

	private void PHJJHFBLICM()
	{
		FJMDFKMLIJC();
	}

	private void FJNCHGLIEMA()
	{
		NNFCMCBGICF();
	}

	private void KOFAMEKHHGD()
	{
		OIBELCAKKHH();
	}

	public void PBCNOANNNBP()
	{
		string IHIAMPBEFEE = ((!cut) ? (GetComponentInParent<Slider>().value * multiply).ToString() : (GetComponentInParent<Slider>().value * multiply).ToString(cutFormat));
		GetComponent<Text>().text = textBefore + IHIAMPBEFEE + textAfter;
		if (customKeyValues.Count > 1 && customKeyValues.Exists((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE))
		{
			GetComponent<Text>().text = textBefore + LocalizationService.Instance.HOPMEAJKPHL(customKeyValues.Find((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE).value) + textAfter;
		}
	}

	private void LEAHIBJDMBI()
	{
		EKMAGCOPLPD();
	}

	public void IELBCJHEAFL()
	{
		string IHIAMPBEFEE = ((!cut) ? (GetComponentInParent<Slider>().value * multiply).ToString() : (GetComponentInParent<Slider>().value * multiply).ToString(cutFormat));
		GetComponent<Text>().text = textBefore + IHIAMPBEFEE + textAfter;
		if (customKeyValues.Count > 1 && customKeyValues.Exists((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE))
		{
			GetComponent<Text>().text = textBefore + LocalizationService.Instance.GetLocalizatedText(customKeyValues.Find((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE).value) + textAfter;
		}
	}

	public void GCFNHPDPOOL()
	{
		string IHIAMPBEFEE = ((!cut) ? (GetComponentInParent<Slider>().value * multiply).ToString() : (GetComponentInParent<Slider>().value * multiply).ToString(cutFormat));
		GetComponent<Text>().text = textBefore + IHIAMPBEFEE + textAfter;
		if (customKeyValues.Count > 0 && customKeyValues.Exists((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE))
		{
			GetComponent<Text>().text = textBefore + LocalizationService.Instance.HOPMEAJKPHL(customKeyValues.Find((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE).value) + textAfter;
		}
	}

	private void IBFJAOINHMK()
	{
		NGLIPNLHBFK();
	}

	private void GCHBGCGBMCK()
	{
		EKMAGCOPLPD();
	}

	public void GFMKDMAKECF()
	{
		string IHIAMPBEFEE = ((!cut) ? (GetComponentInParent<Slider>().value * multiply).ToString() : (GetComponentInParent<Slider>().value * multiply).ToString(cutFormat));
		GetComponent<Text>().text = textBefore + IHIAMPBEFEE + textAfter;
		if (customKeyValues.Count > 1 && customKeyValues.Exists((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE))
		{
			GetComponent<Text>().text = textBefore + LocalizationService.Instance.GetLocalizatedText(customKeyValues.Find((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE).value) + textAfter;
		}
	}

	public void IEAMEOBKGBP()
	{
		string IHIAMPBEFEE = ((!cut) ? (GetComponentInParent<Slider>().value * multiply).ToString() : (GetComponentInParent<Slider>().value * multiply).ToString(cutFormat));
		GetComponent<Text>().text = textBefore + IHIAMPBEFEE + textAfter;
		if (customKeyValues.Count > 1 && customKeyValues.Exists((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE))
		{
			GetComponent<Text>().text = textBefore + LocalizationService.Instance.GetLocalizatedText(customKeyValues.Find((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE).value) + textAfter;
		}
	}

	public void MOAGIBHBDGJ()
	{
		string IHIAMPBEFEE = ((!cut) ? (GetComponentInParent<Slider>().value * multiply).ToString() : (GetComponentInParent<Slider>().value * multiply).ToString(cutFormat));
		GetComponent<Text>().text = textBefore + IHIAMPBEFEE + textAfter;
		if (customKeyValues.Count > 1 && customKeyValues.Exists((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE))
		{
			GetComponent<Text>().text = textBefore + LocalizationService.Instance.GetLocalizatedText(customKeyValues.Find((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE).value) + textAfter;
		}
	}

	private void KIEJKBNBHMD()
	{
		NKDIBKDAENF();
	}

	private void FIKFJDFELIP()
	{
		NFBCALMKMLN();
	}

	private void JOPCCCCHNLI()
	{
		FAGCFADJMDI();
	}

	private void KLILJHJNICK()
	{
		GCFNHPDPOOL();
	}

	private void KIMMMCJFMAB()
	{
		IODAIHCJOMN();
	}

	public void DHECOKJKOIG()
	{
		string IHIAMPBEFEE = ((!cut) ? (GetComponentInParent<Slider>().value * multiply).ToString() : (GetComponentInParent<Slider>().value * multiply).ToString(cutFormat));
		GetComponent<Text>().text = textBefore + IHIAMPBEFEE + textAfter;
		if (customKeyValues.Count > 1 && customKeyValues.Exists((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE))
		{
			GetComponent<Text>().text = textBefore + LocalizationService.Instance.HOPMEAJKPHL(customKeyValues.Find((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE).value) + textAfter;
		}
	}

	private void MECJHOJPODB()
	{
		GMOHNBFKLPG();
	}

	public void NFBCALMKMLN()
	{
		string IHIAMPBEFEE = ((!cut) ? (GetComponentInParent<Slider>().value * multiply).ToString() : (GetComponentInParent<Slider>().value * multiply).ToString(cutFormat));
		GetComponent<Text>().text = textBefore + IHIAMPBEFEE + textAfter;
		if (customKeyValues.Count > 0 && customKeyValues.Exists((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE))
		{
			GetComponent<Text>().text = textBefore + LocalizationService.Instance.HOPMEAJKPHL(customKeyValues.Find((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE).value) + textAfter;
		}
	}

	private void ICILLMAKLMI()
	{
		NGLIPNLHBFK();
	}

	private void GJCOELHNLJE()
	{
		DLHNBKDMPIO();
	}

	public void FCNEBPDNKGH()
	{
		string IHIAMPBEFEE = ((!cut) ? (GetComponentInParent<Slider>().value * multiply).ToString() : (GetComponentInParent<Slider>().value * multiply).ToString(cutFormat));
		GetComponent<Text>().text = textBefore + IHIAMPBEFEE + textAfter;
		if (customKeyValues.Count > 1 && customKeyValues.Exists((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE))
		{
			GetComponent<Text>().text = textBefore + LocalizationService.Instance.GetLocalizatedText(customKeyValues.Find((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE).value) + textAfter;
		}
	}

	public void KCOBKOMDIKN()
	{
		string IHIAMPBEFEE = ((!cut) ? (GetComponentInParent<Slider>().value * multiply).ToString() : (GetComponentInParent<Slider>().value * multiply).ToString(cutFormat));
		GetComponent<Text>().text = textBefore + IHIAMPBEFEE + textAfter;
		if (customKeyValues.Count > 0 && customKeyValues.Exists((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE))
		{
			GetComponent<Text>().text = textBefore + LocalizationService.Instance.GetLocalizatedText(customKeyValues.Find((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE).value) + textAfter;
		}
	}

	private void DFFKKLAPHCC()
	{
		NKDIBKDAENF();
	}

	public void FALFNOMDNAA()
	{
		string IHIAMPBEFEE = ((!cut) ? (GetComponentInParent<Slider>().value * multiply).ToString() : (GetComponentInParent<Slider>().value * multiply).ToString(cutFormat));
		GetComponent<Text>().text = textBefore + IHIAMPBEFEE + textAfter;
		if (customKeyValues.Count > 0 && customKeyValues.Exists((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE))
		{
			GetComponent<Text>().text = textBefore + LocalizationService.Instance.HOPMEAJKPHL(customKeyValues.Find((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE).value) + textAfter;
		}
	}

	private void GHILDCBCDJI()
	{
		UpdateText();
	}

	public void LMJPEEKJGPK()
	{
		string IHIAMPBEFEE = ((!cut) ? (GetComponentInParent<Slider>().value * multiply).ToString() : (GetComponentInParent<Slider>().value * multiply).ToString(cutFormat));
		GetComponent<Text>().text = textBefore + IHIAMPBEFEE + textAfter;
		if (customKeyValues.Count > 0 && customKeyValues.Exists((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE))
		{
			GetComponent<Text>().text = textBefore + LocalizationService.Instance.GetLocalizatedText(customKeyValues.Find((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE).value) + textAfter;
		}
	}

	private void IDJKNBDKHBD()
	{
		EOMBIGCLDDO();
	}

	private void POIMNOBDBBN()
	{
		DFMLOIEKHLG();
	}

	private void FJHFOBHJEHL()
	{
		FCNEBPDNKGH();
	}

	private void Start()
	{
		UpdateText();
	}

	public void MPNBGMNPFNJ()
	{
		string IHIAMPBEFEE = ((!cut) ? (GetComponentInParent<Slider>().value * multiply).ToString() : (GetComponentInParent<Slider>().value * multiply).ToString(cutFormat));
		GetComponent<Text>().text = textBefore + IHIAMPBEFEE + textAfter;
		if (customKeyValues.Count > 1 && customKeyValues.Exists((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE))
		{
			GetComponent<Text>().text = textBefore + LocalizationService.Instance.HOPMEAJKPHL(customKeyValues.Find((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE).value) + textAfter;
		}
	}

	private void EHJJFJCKGAJ()
	{
		JANGLKBLHEF();
	}

	private void AGMJDGHLBMN()
	{
		GMOHNBFKLPG();
	}

	private void EDPDMBFLHLP()
	{
		IODAIHCJOMN();
	}

	private void ONMGIPAILOH()
	{
		POFHAJFLAPK();
	}

	public void DKDHEBFIHEP()
	{
		string IHIAMPBEFEE = ((!cut) ? (GetComponentInParent<Slider>().value * multiply).ToString() : (GetComponentInParent<Slider>().value * multiply).ToString(cutFormat));
		GetComponent<Text>().text = textBefore + IHIAMPBEFEE + textAfter;
		if (customKeyValues.Count > 1 && customKeyValues.Exists((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE))
		{
			GetComponent<Text>().text = textBefore + LocalizationService.Instance.HOPMEAJKPHL(customKeyValues.Find((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE).value) + textAfter;
		}
	}

	private void IDIIELPAMCJ()
	{
		OIBELCAKKHH();
	}

	private void NNCCPEBIAKH()
	{
		PBCNOANNNBP();
	}

	public void GMOHNBFKLPG()
	{
		string IHIAMPBEFEE = ((!cut) ? (GetComponentInParent<Slider>().value * multiply).ToString() : (GetComponentInParent<Slider>().value * multiply).ToString(cutFormat));
		GetComponent<Text>().text = textBefore + IHIAMPBEFEE + textAfter;
		if (customKeyValues.Count > 1 && customKeyValues.Exists((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE))
		{
			GetComponent<Text>().text = textBefore + LocalizationService.Instance.GetLocalizatedText(customKeyValues.Find((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE).value) + textAfter;
		}
	}

	private void NNFMIAFHMJM()
	{
		ILBEEBHIDEG();
	}

	private void MNBPNHNAEBK()
	{
		IODAIHCJOMN();
	}

	private void EPEGAEGDJAM()
	{
		GCFNHPDPOOL();
	}

	public void NNFCMCBGICF()
	{
		string IHIAMPBEFEE = ((!cut) ? (GetComponentInParent<Slider>().value * multiply).ToString() : (GetComponentInParent<Slider>().value * multiply).ToString(cutFormat));
		GetComponent<Text>().text = textBefore + IHIAMPBEFEE + textAfter;
		if (customKeyValues.Count > 1 && customKeyValues.Exists((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE))
		{
			GetComponent<Text>().text = textBefore + LocalizationService.Instance.HOPMEAJKPHL(customKeyValues.Find((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE).value) + textAfter;
		}
	}

	private void OMCLOFCJMPG()
	{
		FCNEBPDNKGH();
	}

	public void POFHAJFLAPK()
	{
		string IHIAMPBEFEE = ((!cut) ? (GetComponentInParent<Slider>().value * multiply).ToString() : (GetComponentInParent<Slider>().value * multiply).ToString(cutFormat));
		GetComponent<Text>().text = textBefore + IHIAMPBEFEE + textAfter;
		if (customKeyValues.Count > 1 && customKeyValues.Exists((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE))
		{
			GetComponent<Text>().text = textBefore + LocalizationService.Instance.GetLocalizatedText(customKeyValues.Find((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE).value) + textAfter;
		}
	}

	private void BGFJOEPFOPM()
	{
		IEAMEOBKGBP();
	}

	public void FAODNNBJEML()
	{
		string IHIAMPBEFEE = ((!cut) ? (GetComponentInParent<Slider>().value * multiply).ToString() : (GetComponentInParent<Slider>().value * multiply).ToString(cutFormat));
		GetComponent<Text>().text = textBefore + IHIAMPBEFEE + textAfter;
		if (customKeyValues.Count > 1 && customKeyValues.Exists((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE))
		{
			GetComponent<Text>().text = textBefore + LocalizationService.Instance.HOPMEAJKPHL(customKeyValues.Find((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE).value) + textAfter;
		}
	}

	public void JAGHOBNOKLN()
	{
		string IHIAMPBEFEE = ((!cut) ? (GetComponentInParent<Slider>().value * multiply).ToString() : (GetComponentInParent<Slider>().value * multiply).ToString(cutFormat));
		GetComponent<Text>().text = textBefore + IHIAMPBEFEE + textAfter;
		if (customKeyValues.Count > 1 && customKeyValues.Exists((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE))
		{
			GetComponent<Text>().text = textBefore + LocalizationService.Instance.HOPMEAJKPHL(customKeyValues.Find((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE).value) + textAfter;
		}
	}

	private void JHANGPCOCIG()
	{
		JAGHOBNOKLN();
	}

	public void IOMCOLOEHFL()
	{
		string IHIAMPBEFEE = ((!cut) ? (GetComponentInParent<Slider>().value * multiply).ToString() : (GetComponentInParent<Slider>().value * multiply).ToString(cutFormat));
		GetComponent<Text>().text = textBefore + IHIAMPBEFEE + textAfter;
		if (customKeyValues.Count > 0 && customKeyValues.Exists((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE))
		{
			GetComponent<Text>().text = textBefore + LocalizationService.Instance.HOPMEAJKPHL(customKeyValues.Find((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE).value) + textAfter;
		}
	}

	public void OAFDLPIGMEO()
	{
		string IHIAMPBEFEE = ((!cut) ? (GetComponentInParent<Slider>().value * multiply).ToString() : (GetComponentInParent<Slider>().value * multiply).ToString(cutFormat));
		GetComponent<Text>().text = textBefore + IHIAMPBEFEE + textAfter;
		if (customKeyValues.Count > 0 && customKeyValues.Exists((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE))
		{
			GetComponent<Text>().text = textBefore + LocalizationService.Instance.GetLocalizatedText(customKeyValues.Find((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE).value) + textAfter;
		}
	}

	private void OBAEDJJDCPN()
	{
		UpdateText();
	}

	private void FHPFJBFCOOF()
	{
		AEHOKFIKFMB();
	}

	private void DDBOODLPCAM()
	{
		FJMDFKMLIJC();
	}

	private void PBEPCAPAKLG()
	{
		DKDHEBFIHEP();
	}

	private void PKGJJFIFLII()
	{
		FAGCFADJMDI();
	}

	public void EOMBIGCLDDO()
	{
		string IHIAMPBEFEE = ((!cut) ? (GetComponentInParent<Slider>().value * multiply).ToString() : (GetComponentInParent<Slider>().value * multiply).ToString(cutFormat));
		GetComponent<Text>().text = textBefore + IHIAMPBEFEE + textAfter;
		if (customKeyValues.Count > 0 && customKeyValues.Exists((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE))
		{
			GetComponent<Text>().text = textBefore + LocalizationService.Instance.HOPMEAJKPHL(customKeyValues.Find((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE).value) + textAfter;
		}
	}

	public void ILBEEBHIDEG()
	{
		string IHIAMPBEFEE = ((!cut) ? (GetComponentInParent<Slider>().value * multiply).ToString() : (GetComponentInParent<Slider>().value * multiply).ToString(cutFormat));
		GetComponent<Text>().text = textBefore + IHIAMPBEFEE + textAfter;
		if (customKeyValues.Count > 1 && customKeyValues.Exists((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE))
		{
			GetComponent<Text>().text = textBefore + LocalizationService.Instance.GetLocalizatedText(customKeyValues.Find((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE).value) + textAfter;
		}
	}

	public void EKMAGCOPLPD()
	{
		string IHIAMPBEFEE = ((!cut) ? (GetComponentInParent<Slider>().value * multiply).ToString() : (GetComponentInParent<Slider>().value * multiply).ToString(cutFormat));
		GetComponent<Text>().text = textBefore + IHIAMPBEFEE + textAfter;
		if (customKeyValues.Count > 0 && customKeyValues.Exists((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE))
		{
			GetComponent<Text>().text = textBefore + LocalizationService.Instance.GetLocalizatedText(customKeyValues.Find((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE).value) + textAfter;
		}
	}

	private void LIBGAKMKHJJ()
	{
		LMJPEEKJGPK();
	}

	public void JANGLKBLHEF()
	{
		string IHIAMPBEFEE = ((!cut) ? (GetComponentInParent<Slider>().value * multiply).ToString() : (GetComponentInParent<Slider>().value * multiply).ToString(cutFormat));
		GetComponent<Text>().text = textBefore + IHIAMPBEFEE + textAfter;
		if (customKeyValues.Count > 0 && customKeyValues.Exists((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE))
		{
			GetComponent<Text>().text = textBefore + LocalizationService.Instance.HOPMEAJKPHL(customKeyValues.Find((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE).value) + textAfter;
		}
	}

	public void IODAIHCJOMN()
	{
		string IHIAMPBEFEE = ((!cut) ? (GetComponentInParent<Slider>().value * multiply).ToString() : (GetComponentInParent<Slider>().value * multiply).ToString(cutFormat));
		GetComponent<Text>().text = textBefore + IHIAMPBEFEE + textAfter;
		if (customKeyValues.Count > 1 && customKeyValues.Exists((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE))
		{
			GetComponent<Text>().text = textBefore + LocalizationService.Instance.GetLocalizatedText(customKeyValues.Find((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE).value) + textAfter;
		}
	}

	private void GFACKFCEIBC()
	{
		IELBCJHEAFL();
	}

	private void ONKDMMJPEMN()
	{
		OAFDLPIGMEO();
	}

	private void CCLNNLCOPBL()
	{
		IELBCJHEAFL();
	}

	private void ADPLHDFJFID()
	{
		IEAMEOBKGBP();
	}

	private void DBLILJGKGHJ()
	{
		KCOBKOMDIKN();
	}

	private void ANKIJGCGCBF()
	{
		FCNEBPDNKGH();
	}

	private void Update()
	{
		UpdateText();
	}

	private void JBCNIPJDPJB()
	{
		FALFNOMDNAA();
	}

	public void GLOHOBECDHL()
	{
		string IHIAMPBEFEE = ((!cut) ? (GetComponentInParent<Slider>().value * multiply).ToString() : (GetComponentInParent<Slider>().value * multiply).ToString(cutFormat));
		GetComponent<Text>().text = textBefore + IHIAMPBEFEE + textAfter;
		if (customKeyValues.Count > 1 && customKeyValues.Exists((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE))
		{
			GetComponent<Text>().text = textBefore + LocalizationService.Instance.GetLocalizatedText(customKeyValues.Find((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE).value) + textAfter;
		}
	}

	public void JOLJFGLFNCK()
	{
		string IHIAMPBEFEE = ((!cut) ? (GetComponentInParent<Slider>().value * multiply).ToString() : (GetComponentInParent<Slider>().value * multiply).ToString(cutFormat));
		GetComponent<Text>().text = textBefore + IHIAMPBEFEE + textAfter;
		if (customKeyValues.Count > 1 && customKeyValues.Exists((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE))
		{
			GetComponent<Text>().text = textBefore + LocalizationService.Instance.GetLocalizatedText(customKeyValues.Find((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE).value) + textAfter;
		}
	}

	private void LCJHDLKJEOM()
	{
		AEHOKFIKFMB();
	}

	public void DBJELEPPKEP()
	{
		string IHIAMPBEFEE = ((!cut) ? (GetComponentInParent<Slider>().value * multiply).ToString() : (GetComponentInParent<Slider>().value * multiply).ToString(cutFormat));
		GetComponent<Text>().text = textBefore + IHIAMPBEFEE + textAfter;
		if (customKeyValues.Count > 0 && customKeyValues.Exists((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE))
		{
			GetComponent<Text>().text = textBefore + LocalizationService.Instance.HOPMEAJKPHL(customKeyValues.Find((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE).value) + textAfter;
		}
	}

	public void AEHOKFIKFMB()
	{
		string IHIAMPBEFEE = ((!cut) ? (GetComponentInParent<Slider>().value * multiply).ToString() : (GetComponentInParent<Slider>().value * multiply).ToString(cutFormat));
		GetComponent<Text>().text = textBefore + IHIAMPBEFEE + textAfter;
		if (customKeyValues.Count > 1 && customKeyValues.Exists((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE))
		{
			GetComponent<Text>().text = textBefore + LocalizationService.Instance.HOPMEAJKPHL(customKeyValues.Find((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE).value) + textAfter;
		}
	}

	private void MBLDJEFBLFL()
	{
		GMOHNBFKLPG();
	}

	private void KNBJBNDGCIJ()
	{
		GMOHNBFKLPG();
	}

	private void FMNPFCHBLJF()
	{
		NKDIBKDAENF();
	}

	private void MDNHCLKNCLE()
	{
		HMFLACFDMAA();
	}

	private void KCDOMIJBFLL()
	{
		FAGCFADJMDI();
	}

	public void UpdateText()
	{
		string IHIAMPBEFEE = ((!cut) ? (GetComponentInParent<Slider>().value * multiply).ToString() : (GetComponentInParent<Slider>().value * multiply).ToString(cutFormat));
		GetComponent<Text>().text = textBefore + IHIAMPBEFEE + textAfter;
		if (customKeyValues.Count > 0 && customKeyValues.Exists((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE))
		{
			GetComponent<Text>().text = textBefore + LocalizationService.Instance.GetLocalizatedText(customKeyValues.Find((SliderKeyValue IACGDFHKCAE) => IACGDFHKCAE.key == IHIAMPBEFEE).value) + textAfter;
		}
	}

	private void CIPKEPDELJB()
	{
		IELBCJHEAFL();
	}

	private void HMNLHMLILKD()
	{
		UpdateText();
	}
}
