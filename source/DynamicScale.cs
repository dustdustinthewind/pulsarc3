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

	private void PBEPCAPAKLG()
	{
		float num = sensitivity;
		if (JFCPJAELJOE != null)
		{
			num = sensitivity * JFCPJAELJOE.PNBDCKLMJKA();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.FBHJCLBAGJD(audioSource, frequencyRange) * num, 1718f, 972f), Time.deltaTime * lerpSpeed);
		float num2 = 1767f;
		float num3 = 391f;
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

	private void IDIIELPAMCJ()
	{
		float num = sensitivity;
		if (JFCPJAELJOE != null)
		{
			num = sensitivity * JFCPJAELJOE.PKPBMPFIGBL();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * num, 1502f, 1822f), Time.deltaTime * lerpSpeed);
		float num2 = 803f;
		float num3 = 552f;
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

	private void LEAHIBJDMBI()
	{
		float num = sensitivity;
		if (JFCPJAELJOE != null)
		{
			num = sensitivity * JFCPJAELJOE.PKPBMPFIGBL();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.FBHJCLBAGJD(audioSource, frequencyRange) * num, 787f, 740f), Time.deltaTime * lerpSpeed);
		float num2 = 533f;
		float num3 = 1989f;
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

	private void HIKKPDACJGI()
	{
		float num = sensitivity;
		if (JFCPJAELJOE != null)
		{
			num = sensitivity * JFCPJAELJOE.PNBDCKLMJKA();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * num, 1007f, 1885f), Time.deltaTime * lerpSpeed);
		float num2 = 245f;
		float num3 = 1429f;
		FEKLHOPGFNC.x = Mathf.Clamp(currentOverflow * num3 + baseScale.x * AKNOHGIMKGG, minSize.x, maxSize.x * num2);
		FEKLHOPGFNC.y = Mathf.Clamp(currentOverflow * num3 + baseScale.y * AKNOHGIMKGG, minSize.y, maxSize.y * num2);
		FEKLHOPGFNC.z = Mathf.Clamp(currentOverflow * num3 + baseScale.z * AKNOHGIMKGG, minSize.z, maxSize.z * num2);
		if (JFCPJAELJOE != null)
		{
			currentOverflow = JFCPJAELJOE.comboTimer;
		}
		if (JLPCIFJANPB != null)
		{
			JLPCIFJANPB.GFINDLLGLOA(FEKLHOPGFNC);
		}
		else
		{
			base.gameObject.transform.localScale = FEKLHOPGFNC;
		}
	}

	private void LPMINJJPDCH()
	{
		float num = sensitivity;
		if (JFCPJAELJOE != null)
		{
			num = sensitivity * JFCPJAELJOE.GetLifesProgrees();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * num, 1919f, 1624f), Time.deltaTime * lerpSpeed);
		float num2 = 440f;
		float num3 = 1212f;
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

	private void JBNPEHMDCMI()
	{
		float num = sensitivity;
		if (JFCPJAELJOE != null)
		{
			num = sensitivity * JFCPJAELJOE.PKPBMPFIGBL();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.ADDDJBDBFBJ(audioSource, frequencyRange) * num, 630f, 1135f), Time.deltaTime * lerpSpeed);
		float num2 = 731f;
		float num3 = 109f;
		FEKLHOPGFNC.x = Mathf.Clamp(currentOverflow * num3 + baseScale.x * AKNOHGIMKGG, minSize.x, maxSize.x * num2);
		FEKLHOPGFNC.y = Mathf.Clamp(currentOverflow * num3 + baseScale.y * AKNOHGIMKGG, minSize.y, maxSize.y * num2);
		FEKLHOPGFNC.z = Mathf.Clamp(currentOverflow * num3 + baseScale.z * AKNOHGIMKGG, minSize.z, maxSize.z * num2);
		if (JFCPJAELJOE != null)
		{
			currentOverflow = JFCPJAELJOE.comboTimer;
		}
		if (JLPCIFJANPB != null)
		{
			JLPCIFJANPB.GFINDLLGLOA(FEKLHOPGFNC);
		}
		else
		{
			base.gameObject.transform.localScale = FEKLHOPGFNC;
		}
	}

	private void KOJKBFDNGDK()
	{
		base.gameObject.transform.localScale = minSize;
	}

	public void BBBNLHALLBN()
	{
		AKNOHGIMKGG = 1229f;
		sensitivity = 1263f;
		lerpSpeed = 1619f;
		baseScale = new Vector3(158f, 1936f, 687f);
		minSize = new Vector3(353f, 8f, 776f);
		maxSize = new Vector3(1816f, 561f, 326f);
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

	private void OCMKCBBCEFG()
	{
		float num = sensitivity;
		if (JFCPJAELJOE != null)
		{
			num = sensitivity * JFCPJAELJOE.GetLifesProgrees();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * num, 1928f, 1236f), Time.deltaTime * lerpSpeed);
		float num2 = 1531f;
		float num3 = 1244f;
		FEKLHOPGFNC.x = Mathf.Clamp(currentOverflow * num3 + baseScale.x * AKNOHGIMKGG, minSize.x, maxSize.x * num2);
		FEKLHOPGFNC.y = Mathf.Clamp(currentOverflow * num3 + baseScale.y * AKNOHGIMKGG, minSize.y, maxSize.y * num2);
		FEKLHOPGFNC.z = Mathf.Clamp(currentOverflow * num3 + baseScale.z * AKNOHGIMKGG, minSize.z, maxSize.z * num2);
		if (JFCPJAELJOE != null)
		{
			currentOverflow = JFCPJAELJOE.comboTimer;
		}
		if (JLPCIFJANPB != null)
		{
			JLPCIFJANPB.GFINDLLGLOA(FEKLHOPGFNC);
		}
		else
		{
			base.gameObject.transform.localScale = FEKLHOPGFNC;
		}
	}

	public void NELFFHHCADM()
	{
		AKNOHGIMKGG = 1643f;
		sensitivity = 1363f;
		lerpSpeed = 816f;
		baseScale = new Vector3(1748f, 1402f, 325f);
		minSize = new Vector3(653f, 782f, 1245f);
		maxSize = new Vector3(1975f, 1654f, 377f);
		frequencyRange = FrequencyRange.SubBase;
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

	private void IEMEHGCFAPD()
	{
		float num = sensitivity;
		if (JFCPJAELJOE != null)
		{
			num = sensitivity * JFCPJAELJOE.GetLifesProgrees();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.FBHJCLBAGJD(audioSource, frequencyRange) * num, 758f, 1578f), Time.deltaTime * lerpSpeed);
		float num2 = 771f;
		float num3 = 1070f;
		FEKLHOPGFNC.x = Mathf.Clamp(currentOverflow * num3 + baseScale.x * AKNOHGIMKGG, minSize.x, maxSize.x * num2);
		FEKLHOPGFNC.y = Mathf.Clamp(currentOverflow * num3 + baseScale.y * AKNOHGIMKGG, minSize.y, maxSize.y * num2);
		FEKLHOPGFNC.z = Mathf.Clamp(currentOverflow * num3 + baseScale.z * AKNOHGIMKGG, minSize.z, maxSize.z * num2);
		if (JFCPJAELJOE != null)
		{
			currentOverflow = JFCPJAELJOE.comboTimer;
		}
		if (JLPCIFJANPB != null)
		{
			JLPCIFJANPB.GFINDLLGLOA(FEKLHOPGFNC);
		}
		else
		{
			base.gameObject.transform.localScale = FEKLHOPGFNC;
		}
	}

	private void ANCKKLFPGDI()
	{
		base.gameObject.transform.localScale = minSize;
	}

	public void FPKJJBAENGF()
	{
		AKNOHGIMKGG = 395f;
		sensitivity = 316f;
		lerpSpeed = 1632f;
		baseScale = new Vector3(1850f, 706f, 1553f);
		minSize = new Vector3(862f, 1473f, 788f);
		maxSize = new Vector3(1679f, 531f, 1655f);
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

	private void IDJKNBDKHBD()
	{
		base.gameObject.transform.localScale = minSize;
	}

	public void KOBJAEPJJJM()
	{
		AKNOHGIMKGG = 947f;
		sensitivity = 544f;
		lerpSpeed = 887f;
		baseScale = new Vector3(924f, 1562f, 1792f);
		minSize = new Vector3(553f, 314f, 153f);
		maxSize = new Vector3(65f, 1594f, 1453f);
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

	private void JECMJNFGBGC()
	{
		base.gameObject.transform.localScale = minSize;
	}

	public void JADEDAEMLBN()
	{
		AKNOHGIMKGG = 1158f;
		sensitivity = 1227f;
		lerpSpeed = 1451f;
		baseScale = new Vector3(1460f, 1007f, 1579f);
		minSize = new Vector3(377f, 1801f, 625f);
		maxSize = new Vector3(89f, 1571f, 1051f);
		frequencyRange = FrequencyRange.SubBase;
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
			num = sensitivity * JFCPJAELJOE.PNBDCKLMJKA();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * num, 495f, 1574f), Time.deltaTime * lerpSpeed);
		float num2 = 681f;
		float num3 = 499f;
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

	private void FIKFJDFELIP()
	{
		base.gameObject.transform.localScale = minSize;
	}

	private void FJHFOBHJEHL()
	{
		float num = sensitivity;
		if (JFCPJAELJOE != null)
		{
			num = sensitivity * JFCPJAELJOE.GetLifesProgrees();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.FBHJCLBAGJD(audioSource, frequencyRange) * num, 380f, 264f), Time.deltaTime * lerpSpeed);
		float num2 = 8f;
		float num3 = 219f;
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

	public void FHPPMBEEKBL()
	{
		AKNOHGIMKGG = 28f;
		sensitivity = 1403f;
		lerpSpeed = 1633f;
		baseScale = new Vector3(814f, 1271f, 1265f);
		minSize = new Vector3(677f, 1479f, 669f);
		maxSize = new Vector3(1551f, 1482f, 273f);
		frequencyRange = FrequencyRange.UpperMidrange;
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

	private void FBMDHDBELEK()
	{
		float num = sensitivity;
		if (JFCPJAELJOE != null)
		{
			num = sensitivity * JFCPJAELJOE.PNBDCKLMJKA();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.ADDDJBDBFBJ(audioSource, frequencyRange) * num, 1042f, 1339f), Time.deltaTime * lerpSpeed);
		float num2 = 669f;
		float num3 = 69f;
		FEKLHOPGFNC.x = Mathf.Clamp(currentOverflow * num3 + baseScale.x * AKNOHGIMKGG, minSize.x, maxSize.x * num2);
		FEKLHOPGFNC.y = Mathf.Clamp(currentOverflow * num3 + baseScale.y * AKNOHGIMKGG, minSize.y, maxSize.y * num2);
		FEKLHOPGFNC.z = Mathf.Clamp(currentOverflow * num3 + baseScale.z * AKNOHGIMKGG, minSize.z, maxSize.z * num2);
		if (JFCPJAELJOE != null)
		{
			currentOverflow = JFCPJAELJOE.comboTimer;
		}
		if (JLPCIFJANPB != null)
		{
			JLPCIFJANPB.GFINDLLGLOA(FEKLHOPGFNC);
		}
		else
		{
			base.gameObject.transform.localScale = FEKLHOPGFNC;
		}
	}

	private void KMKLDAJLCNM()
	{
		float num = sensitivity;
		if (JFCPJAELJOE != null)
		{
			num = sensitivity * JFCPJAELJOE.PNBDCKLMJKA();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.FBHJCLBAGJD(audioSource, frequencyRange) * num, 476f, 1196f), Time.deltaTime * lerpSpeed);
		float num2 = 1281f;
		float num3 = 133f;
		FEKLHOPGFNC.x = Mathf.Clamp(currentOverflow * num3 + baseScale.x * AKNOHGIMKGG, minSize.x, maxSize.x * num2);
		FEKLHOPGFNC.y = Mathf.Clamp(currentOverflow * num3 + baseScale.y * AKNOHGIMKGG, minSize.y, maxSize.y * num2);
		FEKLHOPGFNC.z = Mathf.Clamp(currentOverflow * num3 + baseScale.z * AKNOHGIMKGG, minSize.z, maxSize.z * num2);
		if (JFCPJAELJOE != null)
		{
			currentOverflow = JFCPJAELJOE.comboTimer;
		}
		if (JLPCIFJANPB != null)
		{
			JLPCIFJANPB.GFINDLLGLOA(FEKLHOPGFNC);
		}
		else
		{
			base.gameObject.transform.localScale = FEKLHOPGFNC;
		}
	}

	private void JILOMOBDPIA()
	{
		base.gameObject.transform.localScale = minSize;
	}

	public void GOFMABPMLKF()
	{
		AKNOHGIMKGG = 642f;
		sensitivity = 1724f;
		lerpSpeed = 379f;
		baseScale = new Vector3(1190f, 1961f, 1143f);
		minSize = new Vector3(305f, 138f, 1058f);
		maxSize = new Vector3(486f, 382f, 1833f);
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

	private void PDHKMDBNGGN()
	{
		base.gameObject.transform.localScale = minSize;
	}

	public void FEAPMDENLBN()
	{
		AKNOHGIMKGG = 1095f;
		sensitivity = 1145f;
		lerpSpeed = 387f;
		baseScale = new Vector3(564f, 713f, 580f);
		minSize = new Vector3(826f, 734f, 475f);
		maxSize = new Vector3(503f, 163f, 1238f);
		frequencyRange = FrequencyRange.UpperMidrange;
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

	private void FOMNCPKKCFN()
	{
		float num = sensitivity;
		if (JFCPJAELJOE != null)
		{
			num = sensitivity * JFCPJAELJOE.PKPBMPFIGBL();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.ADDDJBDBFBJ(audioSource, frequencyRange) * num, 206f, 227f), Time.deltaTime * lerpSpeed);
		float num2 = 1150f;
		float num3 = 808f;
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

	public void BJIKAHNJNEB()
	{
		AKNOHGIMKGG = 1751f;
		sensitivity = 1294f;
		lerpSpeed = 123f;
		baseScale = new Vector3(623f, 952f, 1192f);
		minSize = new Vector3(690f, 267f, 1408f);
		maxSize = new Vector3(896f, 1618f, 1541f);
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

	private void Start()
	{
		base.gameObject.transform.localScale = minSize;
	}

	public void LDGJGONCEND()
	{
		AKNOHGIMKGG = 1039f;
		sensitivity = 41f;
		lerpSpeed = 656f;
		baseScale = new Vector3(534f, 375f, 505f);
		minSize = new Vector3(1272f, 265f, 737f);
		maxSize = new Vector3(370f, 1199f, 1035f);
		frequencyRange = FrequencyRange.VeryHigh;
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

	private void NCPAFCKGJEA()
	{
		float num = sensitivity;
		if (JFCPJAELJOE != null)
		{
			num = sensitivity * JFCPJAELJOE.PNBDCKLMJKA();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * num, 1805f, 587f), Time.deltaTime * lerpSpeed);
		float num2 = 993f;
		float num3 = 868f;
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

	private void BGFJOEPFOPM()
	{
		float num = sensitivity;
		if (JFCPJAELJOE != null)
		{
			num = sensitivity * JFCPJAELJOE.GetLifesProgrees();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.FBHJCLBAGJD(audioSource, frequencyRange) * num, 1919f, 812f), Time.deltaTime * lerpSpeed);
		float num2 = 328f;
		float num3 = 1484f;
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

	private void OHFOLGANOLC()
	{
		base.gameObject.transform.localScale = minSize;
	}

	private void EFJDNLGNACH()
	{
		base.gameObject.transform.localScale = minSize;
	}

	public void LBMLGIAKJCH()
	{
		AKNOHGIMKGG = 1382f;
		sensitivity = 1037f;
		lerpSpeed = 1274f;
		baseScale = new Vector3(1234f, 733f, 946f);
		minSize = new Vector3(1643f, 1010f, 1752f);
		maxSize = new Vector3(825f, 1477f, 1365f);
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

	private void DNENFLNCIJP()
	{
		float num = sensitivity;
		if (JFCPJAELJOE != null)
		{
			num = sensitivity * JFCPJAELJOE.PKPBMPFIGBL();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.FBHJCLBAGJD(audioSource, frequencyRange) * num, 791f, 344f), Time.deltaTime * lerpSpeed);
		float num2 = 1062f;
		float num3 = 1921f;
		FEKLHOPGFNC.x = Mathf.Clamp(currentOverflow * num3 + baseScale.x * AKNOHGIMKGG, minSize.x, maxSize.x * num2);
		FEKLHOPGFNC.y = Mathf.Clamp(currentOverflow * num3 + baseScale.y * AKNOHGIMKGG, minSize.y, maxSize.y * num2);
		FEKLHOPGFNC.z = Mathf.Clamp(currentOverflow * num3 + baseScale.z * AKNOHGIMKGG, minSize.z, maxSize.z * num2);
		if (JFCPJAELJOE != null)
		{
			currentOverflow = JFCPJAELJOE.comboTimer;
		}
		if (JLPCIFJANPB != null)
		{
			JLPCIFJANPB.GFINDLLGLOA(FEKLHOPGFNC);
		}
		else
		{
			base.gameObject.transform.localScale = FEKLHOPGFNC;
		}
	}

	public void DGNLHKLGAMC()
	{
		AKNOHGIMKGG = 1432f;
		sensitivity = 521f;
		lerpSpeed = 1548f;
		baseScale = new Vector3(725f, 1628f, 73f);
		minSize = new Vector3(560f, 1148f, 1882f);
		maxSize = new Vector3(6f, 470f, 1157f);
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

	private void GPNAOAKCMHC()
	{
		base.gameObject.transform.localScale = minSize;
	}

	public void IDOFOCOFEIE()
	{
		AKNOHGIMKGG = 386f;
		sensitivity = 1446f;
		lerpSpeed = 346f;
		baseScale = new Vector3(281f, 234f, 1361f);
		minSize = new Vector3(1189f, 1106f, 532f);
		maxSize = new Vector3(1710f, 458f, 1237f);
		frequencyRange = FrequencyRange.SubBase;
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

	private void HNDNDPECBPL()
	{
		float num = sensitivity;
		if (JFCPJAELJOE != null)
		{
			num = sensitivity * JFCPJAELJOE.PNBDCKLMJKA();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.ADDDJBDBFBJ(audioSource, frequencyRange) * num, 570f, 1738f), Time.deltaTime * lerpSpeed);
		float num2 = 1897f;
		float num3 = 923f;
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

	private void DKOPKPBLDHH()
	{
		base.gameObject.transform.localScale = minSize;
	}

	private void LCJHDLKJEOM()
	{
		float num = sensitivity;
		if (JFCPJAELJOE != null)
		{
			num = sensitivity * JFCPJAELJOE.GetLifesProgrees();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.ADDDJBDBFBJ(audioSource, frequencyRange) * num, 4f, 1860f), Time.deltaTime * lerpSpeed);
		float num2 = 893f;
		float num3 = 1140f;
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

	private void HDDECCMEJKA()
	{
		float num = sensitivity;
		if (JFCPJAELJOE != null)
		{
			num = sensitivity * JFCPJAELJOE.GetLifesProgrees();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * num, 703f, 633f), Time.deltaTime * lerpSpeed);
		float num2 = 1208f;
		float num3 = 973f;
		FEKLHOPGFNC.x = Mathf.Clamp(currentOverflow * num3 + baseScale.x * AKNOHGIMKGG, minSize.x, maxSize.x * num2);
		FEKLHOPGFNC.y = Mathf.Clamp(currentOverflow * num3 + baseScale.y * AKNOHGIMKGG, minSize.y, maxSize.y * num2);
		FEKLHOPGFNC.z = Mathf.Clamp(currentOverflow * num3 + baseScale.z * AKNOHGIMKGG, minSize.z, maxSize.z * num2);
		if (JFCPJAELJOE != null)
		{
			currentOverflow = JFCPJAELJOE.comboTimer;
		}
		if (JLPCIFJANPB != null)
		{
			JLPCIFJANPB.GFINDLLGLOA(FEKLHOPGFNC);
		}
		else
		{
			base.gameObject.transform.localScale = FEKLHOPGFNC;
		}
	}

	public void DEDANNMJNOC()
	{
		AKNOHGIMKGG = 1284f;
		sensitivity = 424f;
		lerpSpeed = 1951f;
		baseScale = new Vector3(271f, 1821f, 604f);
		minSize = new Vector3(1597f, 215f, 1534f);
		maxSize = new Vector3(1212f, 1546f, 598f);
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

	private void KCCIEMBMOBA()
	{
		base.gameObject.transform.localScale = minSize;
	}

	private void FHGKIOOMMOH()
	{
		base.gameObject.transform.localScale = minSize;
	}

	private void CGBHOELMAOC()
	{
		float num = sensitivity;
		if (JFCPJAELJOE != null)
		{
			num = sensitivity * JFCPJAELJOE.PNBDCKLMJKA();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.FBHJCLBAGJD(audioSource, frequencyRange) * num, 1820f, 1436f), Time.deltaTime * lerpSpeed);
		float num2 = 352f;
		float num3 = 967f;
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

	public void CEACMFGNDEB()
	{
		AKNOHGIMKGG = 987f;
		sensitivity = 398f;
		lerpSpeed = 1784f;
		baseScale = new Vector3(928f, 764f, 1688f);
		minSize = new Vector3(617f, 1778f, 1773f);
		maxSize = new Vector3(1127f, 1380f, 551f);
		frequencyRange = FrequencyRange.Decibal;
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

	private void PKLOBJHKFEO()
	{
		base.gameObject.transform.localScale = minSize;
	}

	private void JONGNKNLLND()
	{
		base.gameObject.transform.localScale = minSize;
	}

	public void LOKKIADJAFE()
	{
		AKNOHGIMKGG = 1617f;
		sensitivity = 641f;
		lerpSpeed = 1298f;
		baseScale = new Vector3(1134f, 775f, 1148f);
		minSize = new Vector3(1242f, 1024f, 1420f);
		maxSize = new Vector3(1479f, 963f, 1268f);
		frequencyRange = FrequencyRange.SubBase;
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

	public void KMEFHCDNDNF()
	{
		AKNOHGIMKGG = 1321f;
		sensitivity = 1949f;
		lerpSpeed = 1093f;
		baseScale = new Vector3(1995f, 1968f, 1357f);
		minSize = new Vector3(691f, 1651f, 1427f);
		maxSize = new Vector3(1661f, 231f, 68f);
		frequencyRange = FrequencyRange.UpperMidrange;
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

	private void JKBMKPDGCHG()
	{
		base.gameObject.transform.localScale = minSize;
	}

	public void EMKKGIEFKML()
	{
		AKNOHGIMKGG = 1696f;
		sensitivity = 1589f;
		lerpSpeed = 1368f;
		baseScale = new Vector3(1389f, 943f, 787f);
		minSize = new Vector3(621f, 1670f, 566f);
		maxSize = new Vector3(1248f, 1652f, 25f);
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

	public void EEBGCGFNELO()
	{
		AKNOHGIMKGG = 924f;
		sensitivity = 1943f;
		lerpSpeed = 1272f;
		baseScale = new Vector3(124f, 814f, 1417f);
		minSize = new Vector3(1254f, 1822f, 1155f);
		maxSize = new Vector3(1166f, 641f, 1178f);
		frequencyRange = FrequencyRange.UpperMidrange;
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

	private void BMIOFJFMCBG()
	{
		base.gameObject.transform.localScale = minSize;
	}

	private void OKLAJINHPAN()
	{
		base.gameObject.transform.localScale = minSize;
	}

	public void LECPHJOIGKN()
	{
		AKNOHGIMKGG = 733f;
		sensitivity = 1832f;
		lerpSpeed = 1599f;
		baseScale = new Vector3(588f, 1292f, 1743f);
		minSize = new Vector3(1541f, 1431f, 1512f);
		maxSize = new Vector3(1928f, 298f, 1430f);
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

	private void LDDKCCMHMIC()
	{
		float num = sensitivity;
		if (JFCPJAELJOE != null)
		{
			num = sensitivity * JFCPJAELJOE.PKPBMPFIGBL();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.ADDDJBDBFBJ(audioSource, frequencyRange) * num, 929f, 65f), Time.deltaTime * lerpSpeed);
		float num2 = 220f;
		float num3 = 909f;
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

	public void GLJIDEPMMFO()
	{
		AKNOHGIMKGG = 1796f;
		sensitivity = 1460f;
		lerpSpeed = 1264f;
		baseScale = new Vector3(227f, 696f, 30f);
		minSize = new Vector3(1355f, 20f, 330f);
		maxSize = new Vector3(797f, 341f, 1421f);
		frequencyRange = FrequencyRange.SubBase;
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

	private void AEIJFLJEABG()
	{
		float num = sensitivity;
		if (JFCPJAELJOE != null)
		{
			num = sensitivity * JFCPJAELJOE.PNBDCKLMJKA();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.FBHJCLBAGJD(audioSource, frequencyRange) * num, 318f, 853f), Time.deltaTime * lerpSpeed);
		float num2 = 1179f;
		float num3 = 803f;
		FEKLHOPGFNC.x = Mathf.Clamp(currentOverflow * num3 + baseScale.x * AKNOHGIMKGG, minSize.x, maxSize.x * num2);
		FEKLHOPGFNC.y = Mathf.Clamp(currentOverflow * num3 + baseScale.y * AKNOHGIMKGG, minSize.y, maxSize.y * num2);
		FEKLHOPGFNC.z = Mathf.Clamp(currentOverflow * num3 + baseScale.z * AKNOHGIMKGG, minSize.z, maxSize.z * num2);
		if (JFCPJAELJOE != null)
		{
			currentOverflow = JFCPJAELJOE.comboTimer;
		}
		if (JLPCIFJANPB != null)
		{
			JLPCIFJANPB.GFINDLLGLOA(FEKLHOPGFNC);
		}
		else
		{
			base.gameObject.transform.localScale = FEKLHOPGFNC;
		}
	}

	private void MMBPLGGLPDB()
	{
		float num = sensitivity;
		if (JFCPJAELJOE != null)
		{
			num = sensitivity * JFCPJAELJOE.PNBDCKLMJKA();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.ADDDJBDBFBJ(audioSource, frequencyRange) * num, 1542f, 1147f), Time.deltaTime * lerpSpeed);
		float num2 = 450f;
		float num3 = 1260f;
		FEKLHOPGFNC.x = Mathf.Clamp(currentOverflow * num3 + baseScale.x * AKNOHGIMKGG, minSize.x, maxSize.x * num2);
		FEKLHOPGFNC.y = Mathf.Clamp(currentOverflow * num3 + baseScale.y * AKNOHGIMKGG, minSize.y, maxSize.y * num2);
		FEKLHOPGFNC.z = Mathf.Clamp(currentOverflow * num3 + baseScale.z * AKNOHGIMKGG, minSize.z, maxSize.z * num2);
		if (JFCPJAELJOE != null)
		{
			currentOverflow = JFCPJAELJOE.comboTimer;
		}
		if (JLPCIFJANPB != null)
		{
			JLPCIFJANPB.GFINDLLGLOA(FEKLHOPGFNC);
		}
		else
		{
			base.gameObject.transform.localScale = FEKLHOPGFNC;
		}
	}

	private void KMEONPMCNJG()
	{
		float num = sensitivity;
		if (JFCPJAELJOE != null)
		{
			num = sensitivity * JFCPJAELJOE.PNBDCKLMJKA();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * num, 1647f, 1065f), Time.deltaTime * lerpSpeed);
		float num2 = 1957f;
		float num3 = 1618f;
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

	private void HLDFOJMHKNL()
	{
		float num = sensitivity;
		if (JFCPJAELJOE != null)
		{
			num = sensitivity * JFCPJAELJOE.GetLifesProgrees();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.ADDDJBDBFBJ(audioSource, frequencyRange) * num, 1457f, 1333f), Time.deltaTime * lerpSpeed);
		float num2 = 44f;
		float num3 = 775f;
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

	private void OPCLBGHAPMG()
	{
		float num = sensitivity;
		if (JFCPJAELJOE != null)
		{
			num = sensitivity * JFCPJAELJOE.PNBDCKLMJKA();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * num, 740f, 1108f), Time.deltaTime * lerpSpeed);
		float num2 = 1761f;
		float num3 = 707f;
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

	private void JMEOGJHCONJ()
	{
		base.gameObject.transform.localScale = minSize;
	}

	private void FMFNILJIEIA()
	{
		base.gameObject.transform.localScale = minSize;
	}

	public void PMLPJADKFMG()
	{
		AKNOHGIMKGG = 403f;
		sensitivity = 999f;
		lerpSpeed = 709f;
		baseScale = new Vector3(1235f, 893f, 1000f);
		minSize = new Vector3(1196f, 1439f, 759f);
		maxSize = new Vector3(1701f, 1754f, 1573f);
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

	private void IMCKJCHKMKB()
	{
		base.gameObject.transform.localScale = minSize;
	}

	private void IKIDIJLIGOH()
	{
		float num = sensitivity;
		if (JFCPJAELJOE != null)
		{
			num = sensitivity * JFCPJAELJOE.PNBDCKLMJKA();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.FBHJCLBAGJD(audioSource, frequencyRange) * num, 685f, 1779f), Time.deltaTime * lerpSpeed);
		float num2 = 104f;
		float num3 = 1785f;
		FEKLHOPGFNC.x = Mathf.Clamp(currentOverflow * num3 + baseScale.x * AKNOHGIMKGG, minSize.x, maxSize.x * num2);
		FEKLHOPGFNC.y = Mathf.Clamp(currentOverflow * num3 + baseScale.y * AKNOHGIMKGG, minSize.y, maxSize.y * num2);
		FEKLHOPGFNC.z = Mathf.Clamp(currentOverflow * num3 + baseScale.z * AKNOHGIMKGG, minSize.z, maxSize.z * num2);
		if (JFCPJAELJOE != null)
		{
			currentOverflow = JFCPJAELJOE.comboTimer;
		}
		if (JLPCIFJANPB != null)
		{
			JLPCIFJANPB.GFINDLLGLOA(FEKLHOPGFNC);
		}
		else
		{
			base.gameObject.transform.localScale = FEKLHOPGFNC;
		}
	}

	private void IBHACCEEFFI()
	{
		float num = sensitivity;
		if (JFCPJAELJOE != null)
		{
			num = sensitivity * JFCPJAELJOE.PNBDCKLMJKA();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.FBHJCLBAGJD(audioSource, frequencyRange) * num, 1848f, 1122f), Time.deltaTime * lerpSpeed);
		float num2 = 26f;
		float num3 = 256f;
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

	private void CIPKEPDELJB()
	{
		base.gameObject.transform.localScale = minSize;
	}

	private void ONMGIPAILOH()
	{
		float num = sensitivity;
		if (JFCPJAELJOE != null)
		{
			num = sensitivity * JFCPJAELJOE.PKPBMPFIGBL();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.ADDDJBDBFBJ(audioSource, frequencyRange) * num, 1176f, 346f), Time.deltaTime * lerpSpeed);
		float num2 = 206f;
		float num3 = 33f;
		FEKLHOPGFNC.x = Mathf.Clamp(currentOverflow * num3 + baseScale.x * AKNOHGIMKGG, minSize.x, maxSize.x * num2);
		FEKLHOPGFNC.y = Mathf.Clamp(currentOverflow * num3 + baseScale.y * AKNOHGIMKGG, minSize.y, maxSize.y * num2);
		FEKLHOPGFNC.z = Mathf.Clamp(currentOverflow * num3 + baseScale.z * AKNOHGIMKGG, minSize.z, maxSize.z * num2);
		if (JFCPJAELJOE != null)
		{
			currentOverflow = JFCPJAELJOE.comboTimer;
		}
		if (JLPCIFJANPB != null)
		{
			JLPCIFJANPB.GFINDLLGLOA(FEKLHOPGFNC);
		}
		else
		{
			base.gameObject.transform.localScale = FEKLHOPGFNC;
		}
	}

	private void ODBNMPGBCGO()
	{
		base.gameObject.transform.localScale = minSize;
	}

	private void OIBMHPIFAKK()
	{
		float num = sensitivity;
		if (JFCPJAELJOE != null)
		{
			num = sensitivity * JFCPJAELJOE.PKPBMPFIGBL();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * num, 1036f, 1079f), Time.deltaTime * lerpSpeed);
		float num2 = 38f;
		float num3 = 797f;
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

	public void CAPPKCBFILL()
	{
		AKNOHGIMKGG = 1839f;
		sensitivity = 692f;
		lerpSpeed = 745f;
		baseScale = new Vector3(1641f, 747f, 856f);
		minSize = new Vector3(617f, 1868f, 1719f);
		maxSize = new Vector3(1374f, 1983f, 1276f);
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

	public void GGHCBIAEBBH()
	{
		AKNOHGIMKGG = 1664f;
		sensitivity = 1336f;
		lerpSpeed = 1775f;
		baseScale = new Vector3(650f, 1349f, 459f);
		minSize = new Vector3(907f, 1484f, 337f);
		maxSize = new Vector3(1567f, 1615f, 1494f);
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

	private void ILCFPCIPENO()
	{
		base.gameObject.transform.localScale = minSize;
	}

	private void LLJLDLLNFBH()
	{
		float num = sensitivity;
		if (JFCPJAELJOE != null)
		{
			num = sensitivity * JFCPJAELJOE.PKPBMPFIGBL();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.GetFrequencyVol(audioSource, frequencyRange) * num, 32f, 456f), Time.deltaTime * lerpSpeed);
		float num2 = 1295f;
		float num3 = 479f;
		FEKLHOPGFNC.x = Mathf.Clamp(currentOverflow * num3 + baseScale.x * AKNOHGIMKGG, minSize.x, maxSize.x * num2);
		FEKLHOPGFNC.y = Mathf.Clamp(currentOverflow * num3 + baseScale.y * AKNOHGIMKGG, minSize.y, maxSize.y * num2);
		FEKLHOPGFNC.z = Mathf.Clamp(currentOverflow * num3 + baseScale.z * AKNOHGIMKGG, minSize.z, maxSize.z * num2);
		if (JFCPJAELJOE != null)
		{
			currentOverflow = JFCPJAELJOE.comboTimer;
		}
		if (JLPCIFJANPB != null)
		{
			JLPCIFJANPB.GFINDLLGLOA(FEKLHOPGFNC);
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
			num = sensitivity * JFCPJAELJOE.PNBDCKLMJKA();
		}
		AKNOHGIMKGG = Mathf.Lerp(AKNOHGIMKGG, Mathf.Clamp(AudioSampler.instance.ADDDJBDBFBJ(audioSource, frequencyRange) * num, 703f, 404f), Time.deltaTime * lerpSpeed);
		float num2 = 346f;
		float num3 = 256f;
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
}
