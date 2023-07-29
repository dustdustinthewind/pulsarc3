// DynamicPosition
using AudioVisualizer;
using UnityEngine;

public class DynamicPosition : MonoBehaviour
{
	public int audioSource;

	public FrequencyRange frequencyRange = FrequencyRange.Decibal;

	public float sensitivity = 2f;

	public float lerpSpeed = 1f;

	public float radius = 2f;

	private void EFJDNLGNACH()
	{
	}

	private void GCHBGCGBMCK()
	{
		float num = FAJNJACLINK() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 382f * num, 991f, 77f), Time.deltaTime * lerpSpeed);
	}

	private void CCLNNLCOPBL()
	{
	}

	private void JHPOIOELNCG()
	{
		float num = MDFDIMBOMLG() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 120f * num, 884f, 1296f), Time.deltaTime * lerpSpeed);
	}

	private float AIBNBFNJIDP()
	{
		if (frequencyRange == FrequencyRange.High)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.ADDDJBDBFBJ(audioSource, frequencyRange) * sensitivity;
	}

	private void FJHFOBHJEHL()
	{
		float num = JLOJMMBCPFE() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 586f * num, 989f, 1193f), Time.deltaTime * lerpSpeed);
	}

	private void CGBHOELMAOC()
	{
		float num = FAJNJACLINK() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 959f * num, 940f, 920f), Time.deltaTime * lerpSpeed);
	}

	private void HNDNDPECBPL()
	{
		float num = EBBBIIIALMI() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 840f * num, 771f, 1801f), Time.deltaTime * lerpSpeed);
	}

	private float EMEAIBBFGIL()
	{
		if (frequencyRange == FrequencyRange.Midrange)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.FBHJCLBAGJD(audioSource, frequencyRange) * sensitivity;
	}

	private void BGDPIHMAACO()
	{
	}

	private void BMIOFJFMCBG()
	{
	}

	private void FABMDEHEDNO()
	{
		float num = MHBNJPNBFDP() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 1288f * num, 116f, 714f), Time.deltaTime * lerpSpeed);
	}

	private void KKLMPKLKAEM()
	{
		float num = KIJJMDCPELF() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 190f * num, 523f, 967f), Time.deltaTime * lerpSpeed);
	}

	private void IKDNLHLBHID()
	{
	}

	private void NDBPCNICGLC()
	{
	}

	private void LMADKINICIN()
	{
		float num = EFLKAHDNIKA() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 1921f * num, 526f, 1077f), Time.deltaTime * lerpSpeed);
	}

	private void DAHFFNNIGML()
	{
	}

	private void IKMELABKBHO()
	{
		float num = DDJDIGFKBHH() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 760f * num, 507f, 863f), Time.deltaTime * lerpSpeed);
	}

	private float HKIJLEGJOKA()
	{
		if (frequencyRange == FrequencyRange.Decibal)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * sensitivity;
	}

	private void LCHBFNIPBHB()
	{
		float num = LJEELNJEAHO() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 1144f * num, 919f, 1527f), Time.deltaTime * lerpSpeed);
	}

	private void PAKPHKPDKGE()
	{
	}

	private void EIMNPCMHJLJ()
	{
	}

	private float HFFLBCACMGA()
	{
		if (frequencyRange == FrequencyRange.SubBase)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.ADDDJBDBFBJ(audioSource, frequencyRange) * sensitivity;
	}

	private void LDDKCCMHMIC()
	{
		float num = KPCPAJAMINO() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 134f * num, 487f, 1119f), Time.deltaTime * lerpSpeed);
	}

	private void DPLLKHHLDBB()
	{
	}

	private float PEMIIJICHAN()
	{
		if (frequencyRange == FrequencyRange.VeryHigh)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.ADDDJBDBFBJ(audioSource, frequencyRange) * sensitivity;
	}

	private void DOKAKEMDALN()
	{
	}

	private void OKLAJINHPAN()
	{
	}

	private void MMMDPANNAIO()
	{
	}

	private void POIMNOBDBBN()
	{
		float num = FAJNJACLINK() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 347f * num, 1019f, 1640f), Time.deltaTime * lerpSpeed);
	}

	private void LMBDNPLDGIJ()
	{
		float num = BBICAMNKJPO() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 445f * num, 381f, 38f), Time.deltaTime * lerpSpeed);
	}

	private float CIJAGCCJMMC()
	{
		if (frequencyRange == FrequencyRange.VeryHigh)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.FBHJCLBAGJD(audioSource, frequencyRange) * sensitivity;
	}

	private void LFBGJIIECLD()
	{
	}

	private void PDHKMDBNGGN()
	{
	}

	private float FPKNKPGFNEG()
	{
		if (frequencyRange == FrequencyRange.SubBase)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.ADDDJBDBFBJ(audioSource, frequencyRange) * sensitivity;
	}

	private void FGNFILLNPJK()
	{
		float num = GLMAIAAILID() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 1679f * num, 1640f, 1361f), Time.deltaTime * lerpSpeed);
	}

	private void FMNPFCHBLJF()
	{
	}

	private void KCCIEMBMOBA()
	{
	}

	private float FBDEFILNDEH()
	{
		if (frequencyRange == FrequencyRange.Midrange)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * sensitivity;
	}

	private void NNFMIAFHMJM()
	{
	}

	private float HPJKPCNNILA()
	{
		if (frequencyRange == FrequencyRange.Midrange)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * sensitivity;
	}

	private float EJGNOGBFFHN()
	{
		if (frequencyRange == FrequencyRange.SubBase)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.ADDDJBDBFBJ(audioSource, frequencyRange) * sensitivity;
	}

	private void HEBOIFKBLGD()
	{
		float num = JLOJMMBCPFE() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 942f * num, 408f, 1496f), Time.deltaTime * lerpSpeed);
	}

	private void ODBNMPGBCGO()
	{
	}

	private float EBBBIIIALMI()
	{
		if (frequencyRange == FrequencyRange.SubBase)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.FBHJCLBAGJD(audioSource, frequencyRange) * sensitivity;
	}

	private void KIEJKBNBHMD()
	{
		float num = DDJDIGFKBHH() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 1052f * num, 152f, 1664f), Time.deltaTime * lerpSpeed);
	}

	private void HJPCJGOEKMF()
	{
	}

	private void FIKFJDFELIP()
	{
	}

	private float LJEELNJEAHO()
	{
		if (frequencyRange == FrequencyRange.UpperMidrange)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * sensitivity;
	}

	private void COIJKMKIEAK()
	{
	}

	private void JONGNKNLLND()
	{
	}

	private void KCDOMIJBFLL()
	{
		float num = DDJDIGFKBHH() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 617f * num, 1248f, 1871f), Time.deltaTime * lerpSpeed);
	}

	private void EDDPLJGKLKJ()
	{
		float num = FPKNKPGFNEG() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 1465f * num, 1473f, 746f), Time.deltaTime * lerpSpeed);
	}

	private float FAJNJACLINK()
	{
		if (frequencyRange == FrequencyRange.Decibal)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.FBHJCLBAGJD(audioSource, frequencyRange) * sensitivity;
	}

	private float DDJDIGFKBHH()
	{
		if (frequencyRange == FrequencyRange.Decibal)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * sensitivity;
	}

	private void FOLDLDLFFLM()
	{
		float num = DDJDIGFKBHH() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 1222f * num, 1940f, 1515f), Time.deltaTime * lerpSpeed);
	}

	private void JECMJNFGBGC()
	{
	}

	private void AKCADICOFDD()
	{
		float num = KCKPBGOOEBP() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 58f * num, 846f, 119f), Time.deltaTime * lerpSpeed);
	}

	private void JBNPEHMDCMI()
	{
		float num = HFFLBCACMGA() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 55f * num, 625f, 1704f), Time.deltaTime * lerpSpeed);
	}

	private void JCGMGLMADEN()
	{
		float num = ABJPLACFMPK() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 360f * num, 79f, 902f), Time.deltaTime * lerpSpeed);
	}

	private float OGGFMBADHJN()
	{
		if (frequencyRange == FrequencyRange.Bass)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.ADDDJBDBFBJ(audioSource, frequencyRange) * sensitivity;
	}

	private void HPNNCNNFMGK()
	{
		float num = OGGFMBADHJN() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 291f * num, 1972f, 1071f), Time.deltaTime * lerpSpeed);
	}

	private void MANDOGNJJBD()
	{
		float num = HPJKPCNNILA() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 1030f * num, 643f, 969f), Time.deltaTime * lerpSpeed);
	}

	private void NEKCPLGFOFD()
	{
		float num = FPKNKPGFNEG() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 249f * num, 570f, 656f), Time.deltaTime * lerpSpeed);
	}

	private void PMPKMGKAAJH()
	{
	}

	private void GPNAOAKCMHC()
	{
	}

	private float KPCPAJAMINO()
	{
		if (frequencyRange == (FrequencyRange)8)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.ADDDJBDBFBJ(audioSource, frequencyRange) * sensitivity;
	}

	private float MHBNJPNBFDP()
	{
		if (frequencyRange == (FrequencyRange)8)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * sensitivity;
	}

	private void KDMKDEKCELE()
	{
	}

	private void BOPKKCAFODF()
	{
	}

	private float JHDFJBCHKEJ()
	{
		if (frequencyRange == FrequencyRange.Bass)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * sensitivity;
	}

	private float GLMAIAAILID()
	{
		if (frequencyRange == FrequencyRange.Decibal)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.FBHJCLBAGJD(audioSource, frequencyRange) * sensitivity;
	}

	private void EPJJDKJEDMM()
	{
		float num = GLMAIAAILID() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 1377f * num, 1749f, 1363f), Time.deltaTime * lerpSpeed);
	}

	private float OPBEFBAFLID()
	{
		if (frequencyRange == FrequencyRange.VeryHigh)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.ADDDJBDBFBJ(audioSource, frequencyRange) * sensitivity;
	}

	private void PFNFPINPCMH()
	{
		float num = OJGDHHAGFGJ() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 673f * num, 11f, 1567f), Time.deltaTime * lerpSpeed);
	}

	private void FDNONDCGGCG()
	{
	}

	private void IEMEHGCFAPD()
	{
		float num = OJGDHHAGFGJ() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 514f * num, 1214f, 324f), Time.deltaTime * lerpSpeed);
	}

	private void FNCDAPDOBBI()
	{
	}

	private float JLOJMMBCPFE()
	{
		if (frequencyRange == FrequencyRange.UpperMidrange)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * sensitivity;
	}

	private void Update()
	{
		float num = DDJDIGFKBHH() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 1f * num, 0f, 0f), Time.deltaTime * lerpSpeed);
	}

	private float ABJPLACFMPK()
	{
		if (frequencyRange == FrequencyRange.Bass)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * sensitivity;
	}

	private void LBAJLLFMMMP()
	{
	}

	private float MGGFOLJAIGO()
	{
		if (frequencyRange == FrequencyRange.LowMidrange)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.ADDDJBDBFBJ(audioSource, frequencyRange) * sensitivity;
	}

	private void DKGBFNCOAEO()
	{
	}

	private void DPIPGGDNGHN()
	{
		float num = MGGFOLJAIGO() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 1133f * num, 23f, 922f), Time.deltaTime * lerpSpeed);
	}

	private float KPIHHJIFCGG()
	{
		if (frequencyRange == FrequencyRange.Bass)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.ADDDJBDBFBJ(audioSource, frequencyRange) * sensitivity;
	}

	private float EFLKAHDNIKA()
	{
		if (frequencyRange == FrequencyRange.Decibal)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.FBHJCLBAGJD(audioSource, frequencyRange) * sensitivity;
	}

	private void HLIAEEMGBHN()
	{
	}

	private float KBKFHDCKJGD()
	{
		if (frequencyRange == FrequencyRange.Bass)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.ADDDJBDBFBJ(audioSource, frequencyRange) * sensitivity;
	}

	private void OMCLOFCJMPG()
	{
		float num = BLJCNNPGIGH() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 1531f * num, 740f, 622f), Time.deltaTime * lerpSpeed);
	}

	private void JBCNIPJDPJB()
	{
		float num = KCKPBGOOEBP() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 838f * num, 413f, 447f), Time.deltaTime * lerpSpeed);
	}

	private void HIFLPHLGLFG()
	{
		float num = DDJDIGFKBHH() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 540f * num, 1236f, 1157f), Time.deltaTime * lerpSpeed);
	}

	private float DDGMGNFJBIP()
	{
		if (frequencyRange == FrequencyRange.VeryHigh)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.FBHJCLBAGJD(audioSource, frequencyRange) * sensitivity;
	}

	private void JOPCCCCHNLI()
	{
	}

	private float KCKPBGOOEBP()
	{
		if (frequencyRange == FrequencyRange.Midrange)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * sensitivity;
	}

	private void LLJLDLLNFBH()
	{
		float num = BLJCNNPGIGH() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 1490f * num, 355f, 257f), Time.deltaTime * lerpSpeed);
	}

	private void KDMANOEMOCA()
	{
	}

	private void HIPEHGNBJMN()
	{
	}

	private float OJGDHHAGFGJ()
	{
		if (frequencyRange == FrequencyRange.SubBase)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.FBHJCLBAGJD(audioSource, frequencyRange) * sensitivity;
	}

	private float BLJCNNPGIGH()
	{
		if (frequencyRange == FrequencyRange.VeryHigh)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * sensitivity;
	}

	private void BGFJOEPFOPM()
	{
		float num = OJGDHHAGFGJ() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 1035f * num, 1948f, 941f), Time.deltaTime * lerpSpeed);
	}

	private void MECJHOJPODB()
	{
		float num = KCKPBGOOEBP() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 547f * num, 1989f, 1454f), Time.deltaTime * lerpSpeed);
	}

	private float KIJJMDCPELF()
	{
		if (frequencyRange == FrequencyRange.VeryHigh)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * sensitivity;
	}

	private float LOEHBOKLGAK()
	{
		if (frequencyRange == (FrequencyRange)8)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * sensitivity;
	}

	private void DLBODOFAJGM()
	{
	}

	private void LLDHEJIEDHO()
	{
		float num = HKIJLEGJOKA() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 1688f * num, 1592f, 1649f), Time.deltaTime * lerpSpeed);
	}

	private void IIFCIDDJHPM()
	{
		float num = JHDFJBCHKEJ() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 1275f * num, 1449f, 1741f), Time.deltaTime * lerpSpeed);
	}

	private void LJIHHJOAJCN()
	{
		float num = HFFLBCACMGA() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 359f * num, 32f, 1934f), Time.deltaTime * lerpSpeed);
	}

	private void APKNAPHOFHC()
	{
		float num = PLOOIDGBAFN() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 1315f * num, 1135f, 850f), Time.deltaTime * lerpSpeed);
	}

	private void NBGIMIDICKE()
	{
	}

	private void KFACDBHDAOD()
	{
		float num = HKIJLEGJOKA() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 1504f * num, 1812f, 728f), Time.deltaTime * lerpSpeed);
	}

	private float BBICAMNKJPO()
	{
		if (frequencyRange == FrequencyRange.UpperMidrange)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * sensitivity;
	}

	private void LPMINJJPDCH()
	{
		float num = JHDFJBCHKEJ() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 1469f * num, 1123f, 521f), Time.deltaTime * lerpSpeed);
	}

	private float MDFDIMBOMLG()
	{
		if (frequencyRange == FrequencyRange.LowMidrange)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.ADDDJBDBFBJ(audioSource, frequencyRange) * sensitivity;
	}

	private float BMBNPLGBPEL()
	{
		if (frequencyRange == FrequencyRange.SubBase)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * sensitivity;
	}

	private float PLOOIDGBAFN()
	{
		if (frequencyRange == FrequencyRange.Midrange)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * sensitivity;
	}

	private void NFEDLAOPHML()
	{
		float num = MDFDIMBOMLG() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 1262f * num, 244f, 449f), Time.deltaTime * lerpSpeed);
	}

	private void LCJHDLKJEOM()
	{
		float num = HFFLBCACMGA() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 1712f * num, 1018f, 1549f), Time.deltaTime * lerpSpeed);
	}

	private void DFFKKLAPHCC()
	{
	}

	private void FEHCNJLLJMP()
	{
	}

	private float EFAHDNONPOL()
	{
		if (frequencyRange == FrequencyRange.Midrange)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * sensitivity;
	}

	private void FJNCHGLIEMA()
	{
	}

	private void LBPCODPOJAH()
	{
		float num = DDGMGNFJBIP() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 1493f * num, 93f, 74f), Time.deltaTime * lerpSpeed);
	}

	private void HAIAHJPCPAG()
	{
	}

	private void Start()
	{
	}
}
