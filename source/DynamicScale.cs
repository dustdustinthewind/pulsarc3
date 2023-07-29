// DynamicScale
using AudioVisualizer;
using UnityEngine;

public class DynamicScale : MonoBehaviour
{
	public Vector3 maxSize = new Vector3(1.5f, 1.5f, 1.5f);

	public Vector3 minSize = new Vector3(0f, 0f, 0f);

	public int audioSource;

	public FrequencyRange frequencyRange = FrequencyRange.LowMidrange;

	public float sensitivity = 50f;

	public float lerpSpeed = 1f;

	public Vector3 baseScale = new Vector3(1f, 1f, 1f);

	[HideInInspector]
	public float currentOverflow;

	private float AKNOHGIMKGG;

	private SunController JLPCIFJANPB;

	private PlayerBase JFCPJAELJOE;

	private Vector3 FEKLHOPGFNC = default(Vector3);

	private void FIKFJDFELIP()
	{
		base.gameObject.transform.localScale = minSize;
	}

	private void NBGIMIDICKE()
	{
		base.gameObject.transform.localScale = minSize;
	}

	public void IJHGPCAHDEH()
	{
		AKNOHGIMKGG = 1862f;
		sensitivity = 322f;
		lerpSpeed = 137f;
		baseScale = new Vector3(1539f, 1958f, 798f);
		minSize = new Vector3(1703f, 1238f, 595f);
		maxSize = new Vector3(491f, 641f, 1485f);
		frequencyRange = FrequencyRange.Midrange;
		if ((bool)GetComponent<SunController>())
		{
			JLPCIFJANPB = GetComponent<SunController>();
		}
		else
		{
			JLPCIFJANPB = null;
		}
		if ((bool)GetComponentInParent<PlayerBase>())
		{
			JFCPJAELJOE = GetComponentInParent<PlayerBase>();
		}
		else
		{
			JFCPJAELJOE = null;
		}
	}

	public void OGKGIAAACAD()
	{
		AKNOHGIMKGG = 923f;
		sensitivity = 357f;
		lerpSpeed = 597f;
		baseScale = new Vector3(621f, 1028f, 1748f);
		minSize = new Vector3(614f, 371f, 1360f);
		maxSize = new Vector3(211f, 1286f, 1736f);
		frequencyRange = (FrequencyRange)8;
		if ((bool)GetComponent<SunController>())
		{
			JLPCIFJANPB = GetComponent<SunController>();
		}
		else
		{
			JLPCIFJANPB = null;
		}
		if ((bool)GetComponentInParent<PlayerBase>())
		{
			JFCPJAELJOE = GetComponentInParent<PlayerBase>();
		}
		else
		{
			JFCPJAELJOE = null;
		}
	}

	private void IMCKJCHKMKB()
	{
		base.gameObject.transform.localScale = minSize;
	}

	private void MMBPLGGLPDB()
	{
		float num = sensitivity;
		if (JFCPJAELJOE != null)
		{
			num = sensitivity * JFCPJAELJOE.GetLifesProgrees();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.FBHJCLBAGJD(audioSource, frequencyRange) * num, 1719f, 1808f), Time.deltaTime * lerpSpeed);
		float num2 = 1505f;
		float num3 = 395f;
		FEKLHOPGFNC.x = Mathf.Clamp(currentOverflow * num3 + baseScale.x * AKNOHGIMKGG, minSize.x, maxSize.x * num2);
		FEKLHOPGFNC.y = Mathf.Clamp(currentOverflow * num3 + baseScale.y * AKNOHGIMKGG, minSize.y, maxSize.y * num2);
		FEKLHOPGFNC.z = Mathf.Clamp(currentOverflow * num3 + baseScale.z * AKNOHGIMKGG, minSize.z, maxSize.z * num2);
		if (JFCPJAELJOE != null)
		{
			currentOverflow = JFCPJAELJOE.comboTimer;
		}
		if (JLPCIFJANPB != null)
		{
			JLPCIFJANPB.DDBIHOGBDKM(FEKLHOPGFNC);
		}
		else
		{
			base.gameObject.transform.localScale = FEKLHOPGFNC;
		}
	}

	private void DNNFHBOOPIN()
	{
		base.gameObject.transform.localScale = minSize;
	}

	private void ONMGIPAILOH()
	{
		float num = sensitivity;
		if (JFCPJAELJOE != null)
		{
			num = sensitivity * JFCPJAELJOE.GetLifesProgrees();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * num, 763f, 1383f), Time.deltaTime * lerpSpeed);
		float num2 = 107f;
		float num3 = 1778f;
		FEKLHOPGFNC.x = Mathf.Clamp(currentOverflow * num3 + baseScale.x * AKNOHGIMKGG, minSize.x, maxSize.x * num2);
		FEKLHOPGFNC.y = Mathf.Clamp(currentOverflow * num3 + baseScale.y * AKNOHGIMKGG, minSize.y, maxSize.y * num2);
		FEKLHOPGFNC.z = Mathf.Clamp(currentOverflow * num3 + baseScale.z * AKNOHGIMKGG, minSize.z, maxSize.z * num2);
		if (JFCPJAELJOE != null)
		{
			currentOverflow = JFCPJAELJOE.comboTimer;
		}
		if (JLPCIFJANPB != null)
		{
			JLPCIFJANPB.SetScale(FEKLHOPGFNC);
		}
		else
		{
			base.gameObject.transform.localScale = FEKLHOPGFNC;
		}
	}

	private void MFMIODIAKNI()
	{
		float num = sensitivity;
		if (JFCPJAELJOE != null)
		{
			num = sensitivity * JFCPJAELJOE.GetLifesProgrees();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.FBHJCLBAGJD(audioSource, frequencyRange) * num, 1408f, 506f), Time.deltaTime * lerpSpeed);
		float num2 = 1560f;
		float num3 = 314f;
		FEKLHOPGFNC.x = Mathf.Clamp(currentOverflow * num3 + baseScale.x * AKNOHGIMKGG, minSize.x, maxSize.x * num2);
		FEKLHOPGFNC.y = Mathf.Clamp(currentOverflow * num3 + baseScale.y * AKNOHGIMKGG, minSize.y, maxSize.y * num2);
		FEKLHOPGFNC.z = Mathf.Clamp(currentOverflow * num3 + baseScale.z * AKNOHGIMKGG, minSize.z, maxSize.z * num2);
		if (JFCPJAELJOE != null)
		{
			currentOverflow = JFCPJAELJOE.comboTimer;
		}
		if (JLPCIFJANPB != null)
		{
			JLPCIFJANPB.JDLABNJGJIB(FEKLHOPGFNC);
		}
		else
		{
			base.gameObject.transform.localScale = FEKLHOPGFNC;
		}
	}

	private void OCMKCBBCEFG()
	{
		float num = sensitivity;
		if (JFCPJAELJOE != null)
		{
			num = sensitivity * JFCPJAELJOE.GetLifesProgrees();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.ADDDJBDBFBJ(audioSource, frequencyRange) * num, 1499f, 902f), Time.deltaTime * lerpSpeed);
		float num2 = 703f;
		float num3 = 629f;
		FEKLHOPGFNC.x = Mathf.Clamp(currentOverflow * num3 + baseScale.x * AKNOHGIMKGG, minSize.x, maxSize.x * num2);
		FEKLHOPGFNC.y = Mathf.Clamp(currentOverflow * num3 + baseScale.y * AKNOHGIMKGG, minSize.y, maxSize.y * num2);
		FEKLHOPGFNC.z = Mathf.Clamp(currentOverflow * num3 + baseScale.z * AKNOHGIMKGG, minSize.z, maxSize.z * num2);
		if (JFCPJAELJOE != null)
		{
			currentOverflow = JFCPJAELJOE.comboTimer;
		}
		if (JLPCIFJANPB != null)
		{
			JLPCIFJANPB.EOEOCMANAMH(FEKLHOPGFNC);
		}
		else
		{
			base.gameObject.transform.localScale = FEKLHOPGFNC;
		}
	}

	private void GHILDCBCDJI()
	{
		float num = sensitivity;
		if (JFCPJAELJOE != null)
		{
			num = sensitivity * JFCPJAELJOE.GetLifesProgrees();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.ADDDJBDBFBJ(audioSource, frequencyRange) * num, 161f, 1358f), Time.deltaTime * lerpSpeed);
		float num2 = 1799f;
		float num3 = 1169f;
		FEKLHOPGFNC.x = Mathf.Clamp(currentOverflow * num3 + baseScale.x * AKNOHGIMKGG, minSize.x, maxSize.x * num2);
		FEKLHOPGFNC.y = Mathf.Clamp(currentOverflow * num3 + baseScale.y * AKNOHGIMKGG, minSize.y, maxSize.y * num2);
		FEKLHOPGFNC.z = Mathf.Clamp(currentOverflow * num3 + baseScale.z * AKNOHGIMKGG, minSize.z, maxSize.z * num2);
		if (JFCPJAELJOE != null)
		{
			currentOverflow = JFCPJAELJOE.comboTimer;
		}
		if (JLPCIFJANPB != null)
		{
			JLPCIFJANPB.EOEOCMANAMH(FEKLHOPGFNC);
		}
		else
		{
			base.gameObject.transform.localScale = FEKLHOPGFNC;
		}
	}

	private void AIJGAJIOJDJ()
	{
		float num = sensitivity;
		if (JFCPJAELJOE != null)
		{
			num = sensitivity * JFCPJAELJOE.GetLifesProgrees();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * num, 136f, 245f), Time.deltaTime * lerpSpeed);
		float num2 = 1349f;
		float num3 = 818f;
		FEKLHOPGFNC.x = Mathf.Clamp(currentOverflow * num3 + baseScale.x * AKNOHGIMKGG, minSize.x, maxSize.x * num2);
		FEKLHOPGFNC.y = Mathf.Clamp(currentOverflow * num3 + baseScale.y * AKNOHGIMKGG, minSize.y, maxSize.y * num2);
		FEKLHOPGFNC.z = Mathf.Clamp(currentOverflow * num3 + baseScale.z * AKNOHGIMKGG, minSize.z, maxSize.z * num2);
		if (JFCPJAELJOE != null)
		{
			currentOverflow = JFCPJAELJOE.comboTimer;
		}
		if (JLPCIFJANPB != null)
		{
			JLPCIFJANPB.JDLABNJGJIB(FEKLHOPGFNC);
		}
		else
		{
			base.gameObject.transform.localScale = FEKLHOPGFNC;
		}
	}

	public void IDOFOCOFEIE()
	{
		AKNOHGIMKGG = 694f;
		sensitivity = 240f;
		lerpSpeed = 1021f;
		baseScale = new Vector3(896f, 1746f, 91f);
		minSize = new Vector3(584f, 1574f, 1538f);
		maxSize = new Vector3(1275f, 1697f, 1146f);
		frequencyRange = FrequencyRange.LowMidrange;
		if ((bool)GetComponent<SunController>())
		{
			JLPCIFJANPB = GetComponent<SunController>();
		}
		else
		{
			JLPCIFJANPB = null;
		}
		if ((bool)GetComponentInParent<PlayerBase>())
		{
			JFCPJAELJOE = GetComponentInParent<PlayerBase>();
		}
		else
		{
			JFCPJAELJOE = null;
		}
	}

	public void BJIKAHNJNEB()
	{
		AKNOHGIMKGG = 767f;
		sensitivity = 1021f;
		lerpSpeed = 863f;
		baseScale = new Vector3(424f, 1022f, 1101f);
		minSize = new Vector3(357f, 253f, 1636f);
		maxSize = new Vector3(1362f, 463f, 1227f);
		frequencyRange = FrequencyRange.High;
		if ((bool)GetComponent<SunController>())
		{
			JLPCIFJANPB = GetComponent<SunController>();
		}
		else
		{
			JLPCIFJANPB = null;
		}
		if ((bool)GetComponentInParent<PlayerBase>())
		{
			JFCPJAELJOE = GetComponentInParent<PlayerBase>();
		}
		else
		{
			JFCPJAELJOE = null;
		}
	}

	private void NKLIHNJCHOG()
	{
		float num = sensitivity;
		if (JFCPJAELJOE != null)
		{
			num = sensitivity * JFCPJAELJOE.GetLifesProgrees();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * num, 832f, 81f), Time.deltaTime * lerpSpeed);
		float num2 = 210f;
		float num3 = 1590f;
		FEKLHOPGFNC.x = Mathf.Clamp(currentOverflow * num3 + baseScale.x * AKNOHGIMKGG, minSize.x, maxSize.x * num2);
		FEKLHOPGFNC.y = Mathf.Clamp(currentOverflow * num3 + baseScale.y * AKNOHGIMKGG, minSize.y, maxSize.y * num2);
		FEKLHOPGFNC.z = Mathf.Clamp(currentOverflow * num3 + baseScale.z * AKNOHGIMKGG, minSize.z, maxSize.z * num2);
		if (JFCPJAELJOE != null)
		{
			currentOverflow = JFCPJAELJOE.comboTimer;
		}
		if (JLPCIFJANPB != null)
		{
			JLPCIFJANPB.JDLABNJGJIB(FEKLHOPGFNC);
		}
		else
		{
			base.gameObject.transform.localScale = FEKLHOPGFNC;
		}
	}

	private void Start()
	{
		base.gameObject.transform.localScale = minSize;
	}

	public void MANOCIJICLG()
	{
		AKNOHGIMKGG = 1460f;
		sensitivity = 1522f;
		lerpSpeed = 1755f;
		baseScale = new Vector3(948f, 465f, 358f);
		minSize = new Vector3(17f, 1760f, 599f);
		maxSize = new Vector3(1551f, 1524f, 230f);
		frequencyRange = FrequencyRange.Midrange;
		if ((bool)GetComponent<SunController>())
		{
			JLPCIFJANPB = GetComponent<SunController>();
		}
		else
		{
			JLPCIFJANPB = null;
		}
		if ((bool)GetComponentInParent<PlayerBase>())
		{
			JFCPJAELJOE = GetComponentInParent<PlayerBase>();
		}
		else
		{
			JFCPJAELJOE = null;
		}
	}

	private void Update()
	{
		float num = sensitivity;
		if (JFCPJAELJOE != null)
		{
			num = sensitivity * JFCPJAELJOE.GetLifesProgrees();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * num, 0f, 2.2f), Time.deltaTime * lerpSpeed);
		float num2 = 1f;
		float num3 = 0.2f;
		FEKLHOPGFNC.x = Mathf.Clamp(currentOverflow * num3 + baseScale.x * AKNOHGIMKGG, minSize.x, maxSize.x * num2);
		FEKLHOPGFNC.y = Mathf.Clamp(currentOverflow * num3 + baseScale.y * AKNOHGIMKGG, minSize.y, maxSize.y * num2);
		FEKLHOPGFNC.z = Mathf.Clamp(currentOverflow * num3 + baseScale.z * AKNOHGIMKGG, minSize.z, maxSize.z * num2);
		if (JFCPJAELJOE != null)
		{
			currentOverflow = JFCPJAELJOE.comboTimer;
		}
		if (JLPCIFJANPB != null)
		{
			JLPCIFJANPB.SetScale(FEKLHOPGFNC);
		}
		else
		{
			base.gameObject.transform.localScale = FEKLHOPGFNC;
		}
	}

	public void LDGJGONCEND()
	{
		AKNOHGIMKGG = 676f;
		sensitivity = 1523f;
		lerpSpeed = 991f;
		baseScale = new Vector3(1612f, 1343f, 215f);
		minSize = new Vector3(1430f, 1804f, 657f);
		maxSize = new Vector3(121f, 801f, 441f);
		frequencyRange = FrequencyRange.Bass;
		if ((bool)GetComponent<SunController>())
		{
			JLPCIFJANPB = GetComponent<SunController>();
		}
		else
		{
			JLPCIFJANPB = null;
		}
		if ((bool)GetComponentInParent<PlayerBase>())
		{
			JFCPJAELJOE = GetComponentInParent<PlayerBase>();
		}
		else
		{
			JFCPJAELJOE = null;
		}
	}

	private void KIMMMCJFMAB()
	{
		base.gameObject.transform.localScale = minSize;
	}

	public void JEKEBJCHOHO()
	{
		AKNOHGIMKGG = 737f;
		sensitivity = 296f;
		lerpSpeed = 191f;
		baseScale = new Vector3(241f, 1812f, 565f);
		minSize = new Vector3(1278f, 934f, 854f);
		maxSize = new Vector3(1522f, 720f, 1204f);
		frequencyRange = FrequencyRange.High;
		if ((bool)GetComponent<SunController>())
		{
			JLPCIFJANPB = GetComponent<SunController>();
		}
		else
		{
			JLPCIFJANPB = null;
		}
		if ((bool)GetComponentInParent<PlayerBase>())
		{
			JFCPJAELJOE = GetComponentInParent<PlayerBase>();
		}
		else
		{
			JFCPJAELJOE = null;
		}
	}

	public void Reset()
	{
		AKNOHGIMKGG = 0f;
		sensitivity = 50f;
		lerpSpeed = 1f;
		baseScale = new Vector3(1f, 1f, 1f);
		minSize = new Vector3(0f, 0f, 0f);
		maxSize = new Vector3(1.5f, 1.5f, 1.5f);
		frequencyRange = FrequencyRange.LowMidrange;
		if ((bool)GetComponent<SunController>())
		{
			JLPCIFJANPB = GetComponent<SunController>();
		}
		else
		{
			JLPCIFJANPB = null;
		}
		if ((bool)GetComponentInParent<PlayerBase>())
		{
			JFCPJAELJOE = GetComponentInParent<PlayerBase>();
		}
		else
		{
			JFCPJAELJOE = null;
		}
	}

	public void ABDHDGNIHHI()
	{
		AKNOHGIMKGG = 882f;
		sensitivity = 745f;
		lerpSpeed = 39f;
		baseScale = new Vector3(1986f, 219f, 906f);
		minSize = new Vector3(801f, 1765f, 1079f);
		maxSize = new Vector3(139f, 12f, 1509f);
		frequencyRange = FrequencyRange.Midrange;
		if ((bool)GetComponent<SunController>())
		{
			JLPCIFJANPB = GetComponent<SunController>();
		}
		else
		{
			JLPCIFJANPB = null;
		}
		if ((bool)GetComponentInParent<PlayerBase>())
		{
			JFCPJAELJOE = GetComponentInParent<PlayerBase>();
		}
		else
		{
			JFCPJAELJOE = null;
		}
	}

	public void LOKKIADJAFE()
	{
		AKNOHGIMKGG = 924f;
		sensitivity = 1881f;
		lerpSpeed = 1202f;
		baseScale = new Vector3(655f, 209f, 2f);
		minSize = new Vector3(411f, 117f, 802f);
		maxSize = new Vector3(1165f, 1590f, 1399f);
		frequencyRange = FrequencyRange.Bass;
		if ((bool)GetComponent<SunController>())
		{
			JLPCIFJANPB = GetComponent<SunController>();
		}
		else
		{
			JLPCIFJANPB = null;
		}
		if ((bool)GetComponentInParent<PlayerBase>())
		{
			JFCPJAELJOE = GetComponentInParent<PlayerBase>();
		}
		else
		{
			JFCPJAELJOE = null;
		}
	}

	private void KCDOMIJBFLL()
	{
		float num = sensitivity;
		if (JFCPJAELJOE != null)
		{
			num = sensitivity * JFCPJAELJOE.GetLifesProgrees();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.ADDDJBDBFBJ(audioSource, frequencyRange) * num, 1956f, 1750f), Time.deltaTime * lerpSpeed);
		float num2 = 1268f;
		float num3 = 812f;
		FEKLHOPGFNC.x = Mathf.Clamp(currentOverflow * num3 + baseScale.x * AKNOHGIMKGG, minSize.x, maxSize.x * num2);
		FEKLHOPGFNC.y = Mathf.Clamp(currentOverflow * num3 + baseScale.y * AKNOHGIMKGG, minSize.y, maxSize.y * num2);
		FEKLHOPGFNC.z = Mathf.Clamp(currentOverflow * num3 + baseScale.z * AKNOHGIMKGG, minSize.z, maxSize.z * num2);
		if (JFCPJAELJOE != null)
		{
			currentOverflow = JFCPJAELJOE.comboTimer;
		}
		if (JLPCIFJANPB != null)
		{
			JLPCIFJANPB.PLPOEHKKKJH(FEKLHOPGFNC);
		}
		else
		{
			base.gameObject.transform.localScale = FEKLHOPGFNC;
		}
	}

	public void FPKJJBAENGF()
	{
		AKNOHGIMKGG = 1535f;
		sensitivity = 501f;
		lerpSpeed = 298f;
		baseScale = new Vector3(386f, 78f, 1752f);
		minSize = new Vector3(1942f, 197f, 80f);
		maxSize = new Vector3(1600f, 144f, 1597f);
		frequencyRange = FrequencyRange.High;
		if ((bool)GetComponent<SunController>())
		{
			JLPCIFJANPB = GetComponent<SunController>();
		}
		else
		{
			JLPCIFJANPB = null;
		}
		if ((bool)GetComponentInParent<PlayerBase>())
		{
			JFCPJAELJOE = GetComponentInParent<PlayerBase>();
		}
		else
		{
			JFCPJAELJOE = null;
		}
	}

	private void IDIIELPAMCJ()
	{
		float num = sensitivity;
		if (JFCPJAELJOE != null)
		{
			num = sensitivity * JFCPJAELJOE.GetLifesProgrees();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.FBHJCLBAGJD(audioSource, frequencyRange) * num, 1590f, 681f), Time.deltaTime * lerpSpeed);
		float num2 = 825f;
		float num3 = 1259f;
		FEKLHOPGFNC.x = Mathf.Clamp(currentOverflow * num3 + baseScale.x * AKNOHGIMKGG, minSize.x, maxSize.x * num2);
		FEKLHOPGFNC.y = Mathf.Clamp(currentOverflow * num3 + baseScale.y * AKNOHGIMKGG, minSize.y, maxSize.y * num2);
		FEKLHOPGFNC.z = Mathf.Clamp(currentOverflow * num3 + baseScale.z * AKNOHGIMKGG, minSize.z, maxSize.z * num2);
		if (JFCPJAELJOE != null)
		{
			currentOverflow = JFCPJAELJOE.comboTimer;
		}
		if (JLPCIFJANPB != null)
		{
			JLPCIFJANPB.EOEOCMANAMH(FEKLHOPGFNC);
		}
		else
		{
			base.gameObject.transform.localScale = FEKLHOPGFNC;
		}
	}
}
