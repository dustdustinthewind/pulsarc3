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

	private void HMNLHMLILKD()
	{
		float num = ANAFAMFOBED() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 1293f * num, 938f, 117f), Time.deltaTime * lerpSpeed);
	}

	private void Start()
	{
	}

	private void KMCPMOGKDEH()
	{
	}

	private float PBDIGPCJHEL()
	{
		if (frequencyRange == FrequencyRange.Bass)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * sensitivity;
	}

	private void BEBNOKFLJPH()
	{
	}

	private void BMIOFJFMCBG()
	{
	}

	private void FABKIGNFECE()
	{
		float num = OGGFMBADHJN() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 836f * num, 610f, 1829f), Time.deltaTime * lerpSpeed);
	}

	private void CIPKEPDELJB()
	{
	}

	private void CCLNNLCOPBL()
	{
	}

	private void FBMDHDBELEK()
	{
		float num = ANJLHEHDPBF() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 1038f * num, 394f, 582f), Time.deltaTime * lerpSpeed);
	}

	private float CDMDCPCCEJI()
	{
		if (frequencyRange == FrequencyRange.High)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.FBHJCLBAGJD(audioSource, frequencyRange) * sensitivity;
	}

	private void LPMINJJPDCH()
	{
		float num = MOLMNFDBFCP() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 567f * num, 763f, 1006f), Time.deltaTime * lerpSpeed);
	}

	private void Update()
	{
		float num = DDJDIGFKBHH() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 1f * num, 0f, 0f), Time.deltaTime * lerpSpeed);
	}

	private void NBGIMIDICKE()
	{
	}

	private void JMEOGJHCONJ()
	{
	}

	private float OGGFMBADHJN()
	{
		if (frequencyRange == FrequencyRange.LowMidrange)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.FBHJCLBAGJD(audioSource, frequencyRange) * sensitivity;
	}

	private void DNNFHBOOPIN()
	{
	}

	private void FANADGBGCPI()
	{
	}

	private float FIIHFDHCLEN()
	{
		if (frequencyRange == FrequencyRange.Decibal)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * sensitivity;
	}

	private void CNGAJDBOCLJ()
	{
	}

	private float ANJLHEHDPBF()
	{
		if (frequencyRange == FrequencyRange.SubBase)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.ADDDJBDBFBJ(audioSource, frequencyRange) * sensitivity;
	}

	private void IMCKJCHKMKB()
	{
	}

	private float DDJDIGFKBHH()
	{
		if (frequencyRange == FrequencyRange.Decibal)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * sensitivity;
	}

	private void EJFJENFKLND()
	{
		float num = ANAFAMFOBED() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 1192f * num, 1283f, 1589f), Time.deltaTime * lerpSpeed);
	}

	private void AGEJKLMJGDO()
	{
	}

	private void BGFJOEPFOPM()
	{
		float num = PBDIGPCJHEL() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 856f * num, 1475f, 1398f), Time.deltaTime * lerpSpeed);
	}

	private void PAKPHKPDKGE()
	{
	}

	private void MMOKKAPFGAK()
	{
	}

	private float BIAMHJCOIHE()
	{
		if (frequencyRange == FrequencyRange.Decibal)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.ADDDJBDBFBJ(audioSource, frequencyRange) * sensitivity;
	}

	private void KDMKDEKCELE()
	{
	}

	private void JHANGPCOCIG()
	{
	}

	private void CFIAKIJAILI()
	{
		float num = ANJLHEHDPBF() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 1582f * num, 1807f, 1629f), Time.deltaTime * lerpSpeed);
	}

	private float HFKLBPPPAEI()
	{
		if (frequencyRange == FrequencyRange.High)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * sensitivity;
	}

	private void BMOFEBKGLFI()
	{
	}

	private void GPFJMKCGHGB()
	{
		float num = MOLMNFDBFCP() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 1931f * num, 1580f, 915f), Time.deltaTime * lerpSpeed);
	}

	private void NKLIHNJCHOG()
	{
		float num = CDMDCPCCEJI() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 1813f * num, 435f, 1316f), Time.deltaTime * lerpSpeed);
	}

	private void FHGKIOOMMOH()
	{
	}

	private void JOACBIEHHCE()
	{
		float num = OBOLJGENPFN() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 1050f * num, 179f, 1007f), Time.deltaTime * lerpSpeed);
	}

	private void ONMGIPAILOH()
	{
		float num = BIAMHJCOIHE() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 1292f * num, 450f, 40f), Time.deltaTime * lerpSpeed);
	}

	private void FABMDEHEDNO()
	{
		float num = FIIHFDHCLEN() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 843f * num, 228f, 29f), Time.deltaTime * lerpSpeed);
	}

	private float OBOLJGENPFN()
	{
		if (frequencyRange == FrequencyRange.VeryHigh)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.FBHJCLBAGJD(audioSource, frequencyRange) * sensitivity;
	}

	private void FIKFJDFELIP()
	{
	}

	private float ANAFAMFOBED()
	{
		if (frequencyRange == FrequencyRange.UpperMidrange)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.FBHJCLBAGJD(audioSource, frequencyRange) * sensitivity;
	}

	private float IFBOJAHDACO()
	{
		if (frequencyRange == FrequencyRange.High)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * sensitivity;
	}

	private void OCMKCBBCEFG()
	{
		float num = OBOLJGENPFN() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 1951f * num, 118f, 1144f), Time.deltaTime * lerpSpeed);
	}

	private void FHPFJBFCOOF()
	{
	}

	private void NDAJBJFJGCF()
	{
		float num = OBOLJGENPFN() * sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(radius + 1877f * num, 105f, 1134f), Time.deltaTime * lerpSpeed);
	}

	private float MOLMNFDBFCP()
	{
		if (frequencyRange == FrequencyRange.VeryHigh)
		{
			return AudioSampler.instance.GetRMS(audioSource) * sensitivity;
		}
		return AudioSampler.instance.FBHJCLBAGJD(audioSource, frequencyRange) * sensitivity;
	}
}
