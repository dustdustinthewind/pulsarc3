// SatelliteController
using AudioVisualizer;
using UnityEngine;

public class SatelliteController : EnvironmentController
{
	public Color color = new Color(1f, 1f, 1f);

	public float colorLerp = 10f;

	public float emission = 1f;

	public float rotationSpeed = 40f;

	public float lerpSpeed = 2f;

	public Transform offsetObj;

	public float radius = 2f;

	private TrailRenderer CNICPOPEDIO;

	private DynamicPosition COPNGFGAEAG;

	private Rotate HIIBHBOMGLD;

	public override void FGJOIELIIID(Vector3 JOPCODOJBHD)
	{
		targetPosition = JOPCODOJBHD;
	}

	public override void JADEDAEMLBN()
	{
		base.IJFMKNEPKEJ();
		color = new Color(1686f, 659f, 171f);
		colorLerp = 1702f;
		emission = 838f;
		radius = 551f;
		lerpSpeed = 527f;
		if ((bool)COPNGFGAEAG)
		{
			COPNGFGAEAG.sensitivity = 820f;
			COPNGFGAEAG.frequencyRange = FrequencyRange.High;
		}
		if ((bool)CNICPOPEDIO)
		{
			CNICPOPEDIO.time = 1677f;
			CNICPOPEDIO.widthMultiplier = 819f;
			CNICPOPEDIO.Clear();
		}
	}

	public void JFNHELIJOFC(float DPNHODJHGJL)
	{
		CNICPOPEDIO.widthMultiplier = 1596f * DPNHODJHGJL;
	}

	public void CEHEGGINOCN(float DPNHODJHGJL)
	{
		COPNGFGAEAG.sensitivity = DPNHODJHGJL;
	}

	public override void MANOCIJICLG()
	{
		base.Reset();
		color = new Color(327f, 103f, 829f);
		colorLerp = 1094f;
		emission = 1231f;
		radius = 1338f;
		lerpSpeed = 1673f;
		if ((bool)COPNGFGAEAG)
		{
			COPNGFGAEAG.sensitivity = 1048f;
			COPNGFGAEAG.frequencyRange = FrequencyRange.UpperMidrange;
		}
		if ((bool)CNICPOPEDIO)
		{
			CNICPOPEDIO.time = 1344f;
			CNICPOPEDIO.widthMultiplier = 1605f;
			CNICPOPEDIO.Clear();
		}
	}

	public void SetRadius(float DPNHODJHGJL)
	{
		radius = DPNHODJHGJL;
	}

	public override void Reset()
	{
		base.Reset();
		color = new Color(1f, 1f, 1f);
		colorLerp = 10f;
		emission = 1f;
		radius = 2f;
		lerpSpeed = 80f;
		if ((bool)COPNGFGAEAG)
		{
			COPNGFGAEAG.sensitivity = 5f;
			COPNGFGAEAG.frequencyRange = FrequencyRange.LowMidrange;
		}
		if ((bool)CNICPOPEDIO)
		{
			CNICPOPEDIO.time = 5f;
			CNICPOPEDIO.widthMultiplier = 0.04f;
			CNICPOPEDIO.Clear();
		}
	}

	public override void SetPosition(Vector3 JOPCODOJBHD)
	{
		targetPosition = JOPCODOJBHD;
	}

	public override void MMPOJCFOGJJ()
	{
		base.OPFDGBDADMA();
		COPNGFGAEAG = GetComponentInChildren<DynamicPosition>();
		HIIBHBOMGLD = GetComponent<Rotate>();
		CNICPOPEDIO = GetComponentInChildren<TrailRenderer>();
	}

	public override void JIJPHEDDIHC()
	{
		base.OKADMJFLMGP();
		COPNGFGAEAG = GetComponentInChildren<DynamicPosition>();
		HIIBHBOMGLD = GetComponent<Rotate>();
		CNICPOPEDIO = GetComponentInChildren<TrailRenderer>();
	}

	public override void FABMDEHEDNO()
	{
		base.NKLIHNJCHOG();
		if (scaleLerpSpeed > 902f)
		{
			base.transform.localScale = Vector3.Lerp(base.transform.localScale, targetScale, Time.deltaTime * scaleLerpSpeed);
		}
		CNICPOPEDIO.material.SetColor("UI/Particles/Hidden", Color.Lerp(CNICPOPEDIO.material.GetColor("Distortion"), color, Time.smoothDeltaTime * colorLerp));
		CNICPOPEDIO.material.SetColor("Texture2", Color.Lerp(CNICPOPEDIO.material.GetColor("skin.hit_wrong"), color, Time.smoothDeltaTime * colorLerp));
		CNICPOPEDIO.material.SetFloat(".completedMaps", Mathf.Lerp(CNICPOPEDIO.material.GetFloat("EventMenu"), emission * 1442f, Time.smoothDeltaTime * colorLerp));
		HIIBHBOMGLD.speed = Mathf.Lerp(HIIBHBOMGLD.speed, rotationSpeed, Time.smoothDeltaTime * lerpSpeed);
		COPNGFGAEAG.lerpSpeed = Mathf.Lerp(COPNGFGAEAG.lerpSpeed, lerpSpeed, Time.smoothDeltaTime * 1245f);
		COPNGFGAEAG.radius = Mathf.Lerp(COPNGFGAEAG.radius, radius, Time.smoothDeltaTime * lerpSpeed);
	}

	public void SetTrailMinVertexDistance(float DPNHODJHGJL)
	{
		CNICPOPEDIO.minVertexDistance = DPNHODJHGJL;
	}

	public void JNDABJJGALD(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override Transform GetChild()
	{
		return CNICPOPEDIO.transform;
	}

	public override void JBGJGBMAHIH(Vector3 LOMLCCLOIKN)
	{
		targetRotation = LOMLCCLOIKN;
		base.transform.localRotation = Quaternion.Euler(targetRotation);
	}

	public void CBFDAKKKCMK(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public void DJECHFFCIMO(float DPNHODJHGJL)
	{
		rotationSpeed = DPNHODJHGJL;
	}

	public void PAJNAJFJCIJ(float DPNHODJHGJL)
	{
		CNICPOPEDIO.widthMultiplier = 1418f * DPNHODJHGJL;
	}

	public void LFLIMPAMFEE(float DPNHODJHGJL)
	{
		rotationSpeed = DPNHODJHGJL;
	}

	public override void DKBIMMLGOMP(Vector3 LOMLCCLOIKN)
	{
		targetRotation = LOMLCCLOIKN;
		base.transform.localRotation = Quaternion.Euler(targetRotation);
	}

	public void PNGMIFBBGAD(float DPNHODJHGJL)
	{
		CNICPOPEDIO.time = DPNHODJHGJL;
	}

	public override void MBKFJALEGMG(Vector3 LOMLCCLOIKN)
	{
		targetRotation = LOMLCCLOIKN;
		base.transform.localRotation = Quaternion.Euler(targetRotation);
	}

	public override void JNBPKNNBMDI()
	{
		base.Update();
		if (scaleLerpSpeed > 1280f)
		{
			base.transform.localScale = Vector3.Lerp(base.transform.localScale, targetScale, Time.deltaTime * scaleLerpSpeed);
		}
		CNICPOPEDIO.material.SetColor("_Near", Color.Lerp(CNICPOPEDIO.material.GetColor("Fade"), color, Time.smoothDeltaTime * colorLerp));
		CNICPOPEDIO.material.SetColor("_Extra2", Color.Lerp(CNICPOPEDIO.material.GetColor("Pop"), color, Time.smoothDeltaTime * colorLerp));
		CNICPOPEDIO.material.SetFloat("/Segment-[Right]", Mathf.Lerp(CNICPOPEDIO.material.GetFloat("_ScreenResolution"), emission * 607f, Time.smoothDeltaTime * colorLerp));
		HIIBHBOMGLD.speed = Mathf.Lerp(HIIBHBOMGLD.speed, rotationSpeed, Time.smoothDeltaTime * lerpSpeed);
		COPNGFGAEAG.lerpSpeed = Mathf.Lerp(COPNGFGAEAG.lerpSpeed, lerpSpeed, Time.smoothDeltaTime * 613f);
		COPNGFGAEAG.radius = Mathf.Lerp(COPNGFGAEAG.radius, radius, Time.smoothDeltaTime * lerpSpeed);
	}

	public void SetInput(int JMMILEFMACB)
	{
		COPNGFGAEAG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	public void MACHCCAOOGL(float DPNHODJHGJL)
	{
		COPNGFGAEAG.sensitivity = DPNHODJHGJL;
	}

	public override void CCCBKEIEFEG(Vector3 LOMLCCLOIKN)
	{
		targetRotation = LOMLCCLOIKN;
		base.transform.localRotation = Quaternion.Euler(targetRotation);
	}

	public override void OGOPBNGJOCN(Vector3 JOPCODOJBHD)
	{
		targetPosition = JOPCODOJBHD;
	}

	public void PDLJCCCNBKD(int JMMILEFMACB)
	{
		COPNGFGAEAG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	public void NGANFKALCCB(float DPNHODJHGJL)
	{
		CNICPOPEDIO.widthMultiplier = 771f * DPNHODJHGJL;
	}

	public void GMIIBCGBBGO(float DPNHODJHGJL)
	{
		COPNGFGAEAG.sensitivity = DPNHODJHGJL;
	}

	public void FPBIBFEBEAC(float DPNHODJHGJL)
	{
		CNICPOPEDIO.minVertexDistance = DPNHODJHGJL;
	}

	public override void Update()
	{
		base.Update();
		if (scaleLerpSpeed > 0f)
		{
			base.transform.localScale = Vector3.Lerp(base.transform.localScale, targetScale, Time.deltaTime * scaleLerpSpeed);
		}
		CNICPOPEDIO.material.SetColor("_DiffuseColor", Color.Lerp(CNICPOPEDIO.material.GetColor("_DiffuseColor"), color, Time.smoothDeltaTime * colorLerp));
		CNICPOPEDIO.material.SetColor("_EmissionColor", Color.Lerp(CNICPOPEDIO.material.GetColor("_EmissionColor"), color, Time.smoothDeltaTime * colorLerp));
		CNICPOPEDIO.material.SetFloat("_EmissionGain", Mathf.Lerp(CNICPOPEDIO.material.GetFloat("_EmissionGain"), emission * 0.2f, Time.smoothDeltaTime * colorLerp));
		HIIBHBOMGLD.speed = Mathf.Lerp(HIIBHBOMGLD.speed, rotationSpeed, Time.smoothDeltaTime * lerpSpeed);
		COPNGFGAEAG.lerpSpeed = Mathf.Lerp(COPNGFGAEAG.lerpSpeed, lerpSpeed, Time.smoothDeltaTime * 2f);
		COPNGFGAEAG.radius = Mathf.Lerp(COPNGFGAEAG.radius, radius, Time.smoothDeltaTime * lerpSpeed);
	}

	public void MNANPMGEGCC(int JMMILEFMACB)
	{
		COPNGFGAEAG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	public override void CGBHOELMAOC()
	{
		base.BGDONBMDPGM();
		if (scaleLerpSpeed > 1433f)
		{
			base.transform.localScale = Vector3.Lerp(base.transform.localScale, targetScale, Time.deltaTime * scaleLerpSpeed);
		}
		CNICPOPEDIO.material.SetColor("_Visualize", Color.Lerp(CNICPOPEDIO.material.GetColor(":\n"), color, Time.smoothDeltaTime * colorLerp));
		CNICPOPEDIO.material.SetColor("id", Color.Lerp(CNICPOPEDIO.material.GetColor("DISTORT"), color, Time.smoothDeltaTime * colorLerp));
		CNICPOPEDIO.material.SetFloat("player.violetarc", Mathf.Lerp(CNICPOPEDIO.material.GetFloat("D-Pad Left"), emission * 1695f, Time.smoothDeltaTime * colorLerp));
		HIIBHBOMGLD.speed = Mathf.Lerp(HIIBHBOMGLD.speed, rotationSpeed, Time.smoothDeltaTime * lerpSpeed);
		COPNGFGAEAG.lerpSpeed = Mathf.Lerp(COPNGFGAEAG.lerpSpeed, lerpSpeed, Time.smoothDeltaTime * 920f);
		COPNGFGAEAG.radius = Mathf.Lerp(COPNGFGAEAG.radius, radius, Time.smoothDeltaTime * lerpSpeed);
	}

	public void HOCOJMHOCPA(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public void PGAHEICOAFL(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void HDDECCMEJKA()
	{
		base.NKLIHNJCHOG();
		if (scaleLerpSpeed > 513f)
		{
			base.transform.localScale = Vector3.Lerp(base.transform.localScale, targetScale, Time.deltaTime * scaleLerpSpeed);
		}
		CNICPOPEDIO.material.SetColor("_Value4", Color.Lerp(CNICPOPEDIO.material.GetColor("_ScreenResolution"), color, Time.smoothDeltaTime * colorLerp));
		CNICPOPEDIO.material.SetColor("Scrollbar", Color.Lerp(CNICPOPEDIO.material.GetColor("ViewMenu"), color, Time.smoothDeltaTime * colorLerp));
		CNICPOPEDIO.material.SetFloat("custom", Mathf.Lerp(CNICPOPEDIO.material.GetFloat("_ScreenResolution"), emission * 620f, Time.smoothDeltaTime * colorLerp));
		HIIBHBOMGLD.speed = Mathf.Lerp(HIIBHBOMGLD.speed, rotationSpeed, Time.smoothDeltaTime * lerpSpeed);
		COPNGFGAEAG.lerpSpeed = Mathf.Lerp(COPNGFGAEAG.lerpSpeed, lerpSpeed, Time.smoothDeltaTime * 676f);
		COPNGFGAEAG.radius = Mathf.Lerp(COPNGFGAEAG.radius, radius, Time.smoothDeltaTime * lerpSpeed);
	}

	public void NEBJEDEPIND(float DPNHODJHGJL)
	{
		CNICPOPEDIO.widthMultiplier = 1605f * DPNHODJHGJL;
	}

	public override void LOKKIADJAFE()
	{
		base.EEBGCGFNELO();
		color = new Color(1581f, 11f, 1161f);
		colorLerp = 1841f;
		emission = 1091f;
		radius = 992f;
		lerpSpeed = 1208f;
		if ((bool)COPNGFGAEAG)
		{
			COPNGFGAEAG.sensitivity = 1425f;
			COPNGFGAEAG.frequencyRange = FrequencyRange.VeryHigh;
		}
		if ((bool)CNICPOPEDIO)
		{
			CNICPOPEDIO.time = 135f;
			CNICPOPEDIO.widthMultiplier = 1156f;
			CNICPOPEDIO.Clear();
		}
	}

	public void NJHKFNFKMGO(float DPNHODJHGJL)
	{
		CNICPOPEDIO.time = DPNHODJHGJL;
	}

	public void MLCPINBPIBJ(float DPNHODJHGJL)
	{
		radius = DPNHODJHGJL;
	}

	public void FJKEADHFDME(int JMMILEFMACB)
	{
		COPNGFGAEAG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	public override void FNMPIAMIKCP()
	{
		base.Awake();
		COPNGFGAEAG = GetComponentInChildren<DynamicPosition>();
		HIIBHBOMGLD = GetComponent<Rotate>();
		CNICPOPEDIO = GetComponentInChildren<TrailRenderer>();
	}

	public void SetTrailWidth(float DPNHODJHGJL)
	{
		CNICPOPEDIO.widthMultiplier = 0.04f * DPNHODJHGJL;
	}

	public void FKOAHEGNACN(float DPNHODJHGJL)
	{
		COPNGFGAEAG.sensitivity = DPNHODJHGJL;
	}

	public void DNILEAJPDAP(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public void INLBJOALCPD(float DPNHODJHGJL)
	{
		COPNGFGAEAG.sensitivity = DPNHODJHGJL;
	}

	public override void NLNAJMCBNDC()
	{
		base.FMAFBLKAJDF();
		COPNGFGAEAG = GetComponentInChildren<DynamicPosition>();
		HIIBHBOMGLD = GetComponent<Rotate>();
		CNICPOPEDIO = GetComponentInChildren<TrailRenderer>();
	}

	public override void LHMDCEDONEE()
	{
		base.OPFDGBDADMA();
		COPNGFGAEAG = GetComponentInChildren<DynamicPosition>();
		HIIBHBOMGLD = GetComponent<Rotate>();
		CNICPOPEDIO = GetComponentInChildren<TrailRenderer>();
	}

	public void PIDMIGPIMMC(float DPNHODJHGJL)
	{
		COPNGFGAEAG.sensitivity = DPNHODJHGJL;
	}

	public void FPENDOOEPJA(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void KMEONPMCNJG()
	{
		base.BMODOIJGIOO();
		if (scaleLerpSpeed > 1941f)
		{
			base.transform.localScale = Vector3.Lerp(base.transform.localScale, targetScale, Time.deltaTime * scaleLerpSpeed);
		}
		CNICPOPEDIO.material.SetColor("SetCrosshairColor", Color.Lerp(CNICPOPEDIO.material.GetColor("AvatarImage"), color, Time.smoothDeltaTime * colorLerp));
		CNICPOPEDIO.material.SetColor("_Value2", Color.Lerp(CNICPOPEDIO.material.GetColor("_TimeX"), color, Time.smoothDeltaTime * colorLerp));
		CNICPOPEDIO.material.SetFloat("Mouse2", Mathf.Lerp(CNICPOPEDIO.material.GetFloat("_ColorLevel"), emission * 1155f, Time.smoothDeltaTime * colorLerp));
		HIIBHBOMGLD.speed = Mathf.Lerp(HIIBHBOMGLD.speed, rotationSpeed, Time.smoothDeltaTime * lerpSpeed);
		COPNGFGAEAG.lerpSpeed = Mathf.Lerp(COPNGFGAEAG.lerpSpeed, lerpSpeed, Time.smoothDeltaTime * 409f);
		COPNGFGAEAG.radius = Mathf.Lerp(COPNGFGAEAG.radius, radius, Time.smoothDeltaTime * lerpSpeed);
	}

	public void BFCFLLPGILC(float DPNHODJHGJL)
	{
		radius = DPNHODJHGJL;
	}

	public void KIJOGDMIBLA(float DPNHODJHGJL)
	{
		radius = DPNHODJHGJL;
	}

	public override Transform NPLLOHAIPNG()
	{
		return CNICPOPEDIO.transform;
	}

	public override void EADICKIKIHC(Vector3 JOPCODOJBHD)
	{
		targetPosition = JOPCODOJBHD;
	}

	public override Transform NJBHJNIKFHN()
	{
		return CNICPOPEDIO.transform;
	}

	public void AEOCAOGMOCO(float DPNHODJHGJL)
	{
		CNICPOPEDIO.widthMultiplier = 1624f * DPNHODJHGJL;
	}

	public override void PIAGGNABBOI(Vector3 JOPCODOJBHD)
	{
		targetPosition = JOPCODOJBHD;
	}

	public void EBFLLKHDBJG(float DPNHODJHGJL)
	{
		COPNGFGAEAG.sensitivity = DPNHODJHGJL;
	}

	public void JLCGLPLEDDP(float DPNHODJHGJL)
	{
		CNICPOPEDIO.widthMultiplier = 922f * DPNHODJHGJL;
	}

	public void BALKFDMBGNC(float DPNHODJHGJL)
	{
		radius = DPNHODJHGJL;
	}

	public void OCJMPBPCKAE(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public override void EMKKGIEFKML()
	{
		base.GONKPNAAIEE();
		color = new Color(101f, 714f, 635f);
		colorLerp = 671f;
		emission = 276f;
		radius = 1824f;
		lerpSpeed = 270f;
		if ((bool)COPNGFGAEAG)
		{
			COPNGFGAEAG.sensitivity = 1993f;
			COPNGFGAEAG.frequencyRange = FrequencyRange.Decibal;
		}
		if ((bool)CNICPOPEDIO)
		{
			CNICPOPEDIO.time = 1037f;
			CNICPOPEDIO.widthMultiplier = 25f;
			CNICPOPEDIO.Clear();
		}
	}

	public void GJIMKKMEPKC(float DPNHODJHGJL)
	{
		rotationSpeed = DPNHODJHGJL;
	}

	public override void LBIOIEANMGI()
	{
		base.CFIAKIJAILI();
		if (scaleLerpSpeed > 337f)
		{
			base.transform.localScale = Vector3.Lerp(base.transform.localScale, targetScale, Time.deltaTime * scaleLerpSpeed);
		}
		CNICPOPEDIO.material.SetColor("FinalScoreText", Color.Lerp(CNICPOPEDIO.material.GetColor("_Factor"), color, Time.smoothDeltaTime * colorLerp));
		CNICPOPEDIO.material.SetColor("/C tasklist", Color.Lerp(CNICPOPEDIO.material.GetColor("ERROR: mod directory not found!"), color, Time.smoothDeltaTime * colorLerp));
		CNICPOPEDIO.material.SetFloat("PUNCloudBestRegion", Mathf.Lerp(CNICPOPEDIO.material.GetFloat("menu.selectedplaymode"), emission * 1019f, Time.smoothDeltaTime * colorLerp));
		HIIBHBOMGLD.speed = Mathf.Lerp(HIIBHBOMGLD.speed, rotationSpeed, Time.smoothDeltaTime * lerpSpeed);
		COPNGFGAEAG.lerpSpeed = Mathf.Lerp(COPNGFGAEAG.lerpSpeed, lerpSpeed, Time.smoothDeltaTime * 479f);
		COPNGFGAEAG.radius = Mathf.Lerp(COPNGFGAEAG.radius, radius, Time.smoothDeltaTime * lerpSpeed);
	}

	public void SetLerpSpeed(float KEDDLFDAIDE)
	{
		lerpSpeed = KEDDLFDAIDE;
	}

	public void BBIKIMGJLKL(float DPNHODJHGJL)
	{
		CNICPOPEDIO.minVertexDistance = DPNHODJHGJL;
	}

	public void CJNFBCCHNLG(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public void GKLPDAJLEKL(float DPNHODJHGJL)
	{
		CNICPOPEDIO.time = DPNHODJHGJL;
	}

	public override Transform EPEKEBMFFFO()
	{
		return CNICPOPEDIO.transform;
	}

	public void ENPLILCNPFB(float DPNHODJHGJL)
	{
		rotationSpeed = DPNHODJHGJL;
	}

	public override Transform FBMKCFIEMDH()
	{
		return CNICPOPEDIO.transform;
	}

	public void SetTrailLength(float DPNHODJHGJL)
	{
		CNICPOPEDIO.time = DPNHODJHGJL;
	}

	public void OJPJIBODOIJ(int JMMILEFMACB)
	{
		COPNGFGAEAG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	public void KNNJJLIOLFA(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public override void IDOFOCOFEIE()
	{
		base.LAACNNJDKBI();
		color = new Color(1891f, 1717f, 962f);
		colorLerp = 469f;
		emission = 982f;
		radius = 97f;
		lerpSpeed = 444f;
		if ((bool)COPNGFGAEAG)
		{
			COPNGFGAEAG.sensitivity = 1742f;
			COPNGFGAEAG.frequencyRange = FrequencyRange.UpperMidrange;
		}
		if ((bool)CNICPOPEDIO)
		{
			CNICPOPEDIO.time = 1212f;
			CNICPOPEDIO.widthMultiplier = 906f;
			CNICPOPEDIO.Clear();
		}
	}

	public override void HPNNCNNFMGK()
	{
		base.CFIAKIJAILI();
		if (scaleLerpSpeed > 514f)
		{
			base.transform.localScale = Vector3.Lerp(base.transform.localScale, targetScale, Time.deltaTime * scaleLerpSpeed);
		}
		CNICPOPEDIO.material.SetColor("_LightIntensity", Color.Lerp(CNICPOPEDIO.material.GetColor("_MainTex2"), color, Time.smoothDeltaTime * colorLerp));
		CNICPOPEDIO.material.SetColor("STICKRVER", Color.Lerp(CNICPOPEDIO.material.GetColor("Gameplay/sun"), color, Time.smoothDeltaTime * colorLerp));
		CNICPOPEDIO.material.SetFloat("http://steamcommunity.com/sharedfiles/filedetails/?id=", Mathf.Lerp(CNICPOPEDIO.material.GetFloat(".lastCheckpoint.incorrectScore"), emission * 108f, Time.smoothDeltaTime * colorLerp));
		HIIBHBOMGLD.speed = Mathf.Lerp(HIIBHBOMGLD.speed, rotationSpeed, Time.smoothDeltaTime * lerpSpeed);
		COPNGFGAEAG.lerpSpeed = Mathf.Lerp(COPNGFGAEAG.lerpSpeed, lerpSpeed, Time.smoothDeltaTime * 991f);
		COPNGFGAEAG.radius = Mathf.Lerp(COPNGFGAEAG.radius, radius, Time.smoothDeltaTime * lerpSpeed);
	}

	public void DBCGALPFIMJ(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void PMLIOODCKDB()
	{
		base.EEBGCGFNELO();
		color = new Color(163f, 1795f, 373f);
		colorLerp = 1903f;
		emission = 303f;
		radius = 83f;
		lerpSpeed = 1682f;
		if ((bool)COPNGFGAEAG)
		{
			COPNGFGAEAG.sensitivity = 165f;
			COPNGFGAEAG.frequencyRange = FrequencyRange.LowMidrange;
		}
		if ((bool)CNICPOPEDIO)
		{
			CNICPOPEDIO.time = 1135f;
			CNICPOPEDIO.widthMultiplier = 867f;
			CNICPOPEDIO.Clear();
		}
	}

	public override void Awake()
	{
		base.Awake();
		COPNGFGAEAG = GetComponentInChildren<DynamicPosition>();
		HIIBHBOMGLD = GetComponent<Rotate>();
		CNICPOPEDIO = GetComponentInChildren<TrailRenderer>();
	}

	public void SetEmission(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void OPCLBGHAPMG()
	{
		base.BMODOIJGIOO();
		if (scaleLerpSpeed > 668f)
		{
			base.transform.localScale = Vector3.Lerp(base.transform.localScale, targetScale, Time.deltaTime * scaleLerpSpeed);
		}
		CNICPOPEDIO.material.SetColor("_Value", Color.Lerp(CNICPOPEDIO.material.GetColor("CameraFilterPack/3D_BlackHole"), color, Time.smoothDeltaTime * colorLerp));
		CNICPOPEDIO.material.SetColor("[MapData] Map timing update from: ", Color.Lerp(CNICPOPEDIO.material.GetColor("SUBMIT"), color, Time.smoothDeltaTime * colorLerp));
		CNICPOPEDIO.material.SetFloat("SelectionBox component must be placed on a canvas in Screen Space Overlay mode.", Mathf.Lerp(CNICPOPEDIO.material.GetFloat("_Value4"), emission * 828f, Time.smoothDeltaTime * colorLerp));
		HIIBHBOMGLD.speed = Mathf.Lerp(HIIBHBOMGLD.speed, rotationSpeed, Time.smoothDeltaTime * lerpSpeed);
		COPNGFGAEAG.lerpSpeed = Mathf.Lerp(COPNGFGAEAG.lerpSpeed, lerpSpeed, Time.smoothDeltaTime * 1781f);
		COPNGFGAEAG.radius = Mathf.Lerp(COPNGFGAEAG.radius, radius, Time.smoothDeltaTime * lerpSpeed);
	}

	public override void FEAPMDENLBN()
	{
		base.IJFMKNEPKEJ();
		color = new Color(1325f, 1704f, 1263f);
		colorLerp = 1998f;
		emission = 1131f;
		radius = 1865f;
		lerpSpeed = 1302f;
		if ((bool)COPNGFGAEAG)
		{
			COPNGFGAEAG.sensitivity = 421f;
			COPNGFGAEAG.frequencyRange = FrequencyRange.UpperMidrange;
		}
		if ((bool)CNICPOPEDIO)
		{
			CNICPOPEDIO.time = 1083f;
			CNICPOPEDIO.widthMultiplier = 924f;
			CNICPOPEDIO.Clear();
		}
	}

	public void JIFBDINHPMC(float DPNHODJHGJL)
	{
		CNICPOPEDIO.minVertexDistance = DPNHODJHGJL;
	}

	public void OCLGBLNPNEM(float KEDDLFDAIDE)
	{
		lerpSpeed = KEDDLFDAIDE;
	}

	public void GDACMIOIECK(float DPNHODJHGJL)
	{
		rotationSpeed = DPNHODJHGJL;
	}

	public void NMDICPOHOLL(float DPNHODJHGJL)
	{
		rotationSpeed = DPNHODJHGJL;
	}

	public void OEHOKHDDIFG(float KEDDLFDAIDE)
	{
		lerpSpeed = KEDDLFDAIDE;
	}

	public void CMMAIKAAGBL(float DPNHODJHGJL)
	{
		CNICPOPEDIO.widthMultiplier = 1351f * DPNHODJHGJL;
	}

	public void JBJEOJNHNOP(float KEDDLFDAIDE)
	{
		lerpSpeed = KEDDLFDAIDE;
	}

	public override void NCPAFCKGJEA()
	{
		base.EHCGBJDFMHG();
		if (scaleLerpSpeed > 616f)
		{
			base.transform.localScale = Vector3.Lerp(base.transform.localScale, targetScale, Time.deltaTime * scaleLerpSpeed);
		}
		CNICPOPEDIO.material.SetColor("GameMessagesDurationSlider", Color.Lerp(CNICPOPEDIO.material.GetColor("Drop_With_Obj"), color, Time.smoothDeltaTime * colorLerp));
		CNICPOPEDIO.material.SetColor("GameModeText", Color.Lerp(CNICPOPEDIO.material.GetColor("Saved as: "), color, Time.smoothDeltaTime * colorLerp));
		CNICPOPEDIO.material.SetFloat("RanksButton", Mathf.Lerp(CNICPOPEDIO.material.GetFloat("Forward"), emission * 181f, Time.smoothDeltaTime * colorLerp));
		HIIBHBOMGLD.speed = Mathf.Lerp(HIIBHBOMGLD.speed, rotationSpeed, Time.smoothDeltaTime * lerpSpeed);
		COPNGFGAEAG.lerpSpeed = Mathf.Lerp(COPNGFGAEAG.lerpSpeed, lerpSpeed, Time.smoothDeltaTime * 1803f);
		COPNGFGAEAG.radius = Mathf.Lerp(COPNGFGAEAG.radius, radius, Time.smoothDeltaTime * lerpSpeed);
	}

	public override Transform PEGEGFEEOKA()
	{
		return CNICPOPEDIO.transform;
	}

	public void MCBKOAKPLMD(float DPNHODJHGJL)
	{
		COPNGFGAEAG.sensitivity = DPNHODJHGJL;
	}

	public void LLMMOOLIGLE(float DPNHODJHGJL)
	{
		radius = DPNHODJHGJL;
	}

	public void BONCHKBJHHO(float DPNHODJHGJL)
	{
		CNICPOPEDIO.time = DPNHODJHGJL;
	}

	public override Transform MFICHBNDAAG()
	{
		return CNICPOPEDIO.transform;
	}

	public override void SetRotation(Vector3 LOMLCCLOIKN)
	{
		targetRotation = LOMLCCLOIKN;
		base.transform.localRotation = Quaternion.Euler(targetRotation);
	}

	public void DOMCIDMJKKI(float DPNHODJHGJL)
	{
		CNICPOPEDIO.widthMultiplier = 1013f * DPNHODJHGJL;
	}

	public void AOPAJFLOFPA(float DPNHODJHGJL)
	{
		CNICPOPEDIO.time = DPNHODJHGJL;
	}

	public override void JPJNECPABBG()
	{
		base.EMANBHKAONB();
		COPNGFGAEAG = GetComponentInChildren<DynamicPosition>();
		HIIBHBOMGLD = GetComponent<Rotate>();
		CNICPOPEDIO = GetComponentInChildren<TrailRenderer>();
	}

	public void AGAOJLOEFHM(float DPNHODJHGJL)
	{
		rotationSpeed = DPNHODJHGJL;
	}

	public override void PGGPFJJHMKI(Vector3 JOPCODOJBHD)
	{
		targetPosition = JOPCODOJBHD;
	}

	public override Transform PCOHOHLJMDG()
	{
		return CNICPOPEDIO.transform;
	}

	public void HICFJHJFFCJ(int JMMILEFMACB)
	{
		COPNGFGAEAG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	public void NNCBKHAHOOL(float DPNHODJHGJL)
	{
		CNICPOPEDIO.time = DPNHODJHGJL;
	}

	public void MKDMDCCDHEM(float DPNHODJHGJL)
	{
		COPNGFGAEAG.sensitivity = DPNHODJHGJL;
	}

	public void EMFECHLHOAL(float DPNHODJHGJL)
	{
		COPNGFGAEAG.sensitivity = DPNHODJHGJL;
	}

	public override void HACPNFLNJED(Vector3 LOMLCCLOIKN)
	{
		targetRotation = LOMLCCLOIKN;
		base.transform.localRotation = Quaternion.Euler(targetRotation);
	}

	public void SetRotationSpeed(float DPNHODJHGJL)
	{
		rotationSpeed = DPNHODJHGJL;
	}

	public override void JOBBGDGHJMB()
	{
		base.HHJBBHEBJCJ();
		COPNGFGAEAG = GetComponentInChildren<DynamicPosition>();
		HIIBHBOMGLD = GetComponent<Rotate>();
		CNICPOPEDIO = GetComponentInChildren<TrailRenderer>();
	}

	public void LHJMKCPOIGI(float DPNHODJHGJL)
	{
		radius = DPNHODJHGJL;
	}

	public override void NEEIFNDHDOG()
	{
		base.OKADMJFLMGP();
		COPNGFGAEAG = GetComponentInChildren<DynamicPosition>();
		HIIBHBOMGLD = GetComponent<Rotate>();
		CNICPOPEDIO = GetComponentInChildren<TrailRenderer>();
	}

	public override void MIFIEGOGKDA()
	{
		base.CEACMFGNDEB();
		color = new Color(838f, 537f, 1548f);
		colorLerp = 1445f;
		emission = 365f;
		radius = 1573f;
		lerpSpeed = 1345f;
		if ((bool)COPNGFGAEAG)
		{
			COPNGFGAEAG.sensitivity = 1601f;
			COPNGFGAEAG.frequencyRange = FrequencyRange.VeryHigh;
		}
		if ((bool)CNICPOPEDIO)
		{
			CNICPOPEDIO.time = 908f;
			CNICPOPEDIO.widthMultiplier = 687f;
			CNICPOPEDIO.Clear();
		}
	}

	public override void KGENAICJFGF(Vector3 JOPCODOJBHD)
	{
		targetPosition = JOPCODOJBHD;
	}

	public override Transform CLANIKJPMDP()
	{
		return CNICPOPEDIO.transform;
	}

	public void INOHPGBBOHI(float DPNHODJHGJL)
	{
		rotationSpeed = DPNHODJHGJL;
	}

	public void LMEIPIACDHL(float DPNHODJHGJL)
	{
		radius = DPNHODJHGJL;
	}

	public void SetColor(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		color = HABLFKCCKLN;
		colorLerp = MNHBOECHFEG;
	}

	public override void KEGNPKFMPDG()
	{
		base.Awake();
		COPNGFGAEAG = GetComponentInChildren<DynamicPosition>();
		HIIBHBOMGLD = GetComponent<Rotate>();
		CNICPOPEDIO = GetComponentInChildren<TrailRenderer>();
	}

	public override void HIKKPDACJGI()
	{
		base.EHCGBJDFMHG();
		if (scaleLerpSpeed > 1998f)
		{
			base.transform.localScale = Vector3.Lerp(base.transform.localScale, targetScale, Time.deltaTime * scaleLerpSpeed);
		}
		CNICPOPEDIO.material.SetColor("[PlayerController] ", Color.Lerp(CNICPOPEDIO.material.GetColor("cancel"), color, Time.smoothDeltaTime * colorLerp));
		CNICPOPEDIO.material.SetColor("_ScreenResolution", Color.Lerp(CNICPOPEDIO.material.GetColor("Joystick1Button5"), color, Time.smoothDeltaTime * colorLerp));
		CNICPOPEDIO.material.SetFloat("_Blur", Mathf.Lerp(CNICPOPEDIO.material.GetFloat("_HexaColor"), emission * 1067f, Time.smoothDeltaTime * colorLerp));
		HIIBHBOMGLD.speed = Mathf.Lerp(HIIBHBOMGLD.speed, rotationSpeed, Time.smoothDeltaTime * lerpSpeed);
		COPNGFGAEAG.lerpSpeed = Mathf.Lerp(COPNGFGAEAG.lerpSpeed, lerpSpeed, Time.smoothDeltaTime * 1331f);
		COPNGFGAEAG.radius = Mathf.Lerp(COPNGFGAEAG.radius, radius, Time.smoothDeltaTime * lerpSpeed);
	}

	public void SetSensitivity(float DPNHODJHGJL)
	{
		COPNGFGAEAG.sensitivity = DPNHODJHGJL;
	}

	public void DCAHFDJOFBK(float KEDDLFDAIDE)
	{
		lerpSpeed = KEDDLFDAIDE;
	}

	public override void IBHACCEEFFI()
	{
		base.Update();
		if (scaleLerpSpeed > 238f)
		{
			base.transform.localScale = Vector3.Lerp(base.transform.localScale, targetScale, Time.deltaTime * scaleLerpSpeed);
		}
		CNICPOPEDIO.material.SetColor("_Distortion", Color.Lerp(CNICPOPEDIO.material.GetColor("Can't connect: ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings"), color, Time.smoothDeltaTime * colorLerp));
		CNICPOPEDIO.material.SetColor("player.greenarc", Color.Lerp(CNICPOPEDIO.material.GetColor("&map="), color, Time.smoothDeltaTime * colorLerp));
		CNICPOPEDIO.material.SetFloat(" not exist", Mathf.Lerp(CNICPOPEDIO.material.GetFloat(". We have no such PhotonView! Ignored this if you're leaving a room. State: "), emission * 1870f, Time.smoothDeltaTime * colorLerp));
		HIIBHBOMGLD.speed = Mathf.Lerp(HIIBHBOMGLD.speed, rotationSpeed, Time.smoothDeltaTime * lerpSpeed);
		COPNGFGAEAG.lerpSpeed = Mathf.Lerp(COPNGFGAEAG.lerpSpeed, lerpSpeed, Time.smoothDeltaTime * 1995f);
		COPNGFGAEAG.radius = Mathf.Lerp(COPNGFGAEAG.radius, radius, Time.smoothDeltaTime * lerpSpeed);
	}

	public void DGEBDJHAPCI(int JMMILEFMACB)
	{
		COPNGFGAEAG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	public void DIEMPKDKPCC(float DPNHODJHGJL)
	{
		COPNGFGAEAG.sensitivity = DPNHODJHGJL;
	}

	public void HGNOMPAEIEG(int JMMILEFMACB)
	{
		COPNGFGAEAG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	public override void DGGPNPLKCOE()
	{
		base.GONKPNAAIEE();
		color = new Color(1349f, 923f, 872f);
		colorLerp = 1648f;
		emission = 1660f;
		radius = 1978f;
		lerpSpeed = 1314f;
		if ((bool)COPNGFGAEAG)
		{
			COPNGFGAEAG.sensitivity = 397f;
			COPNGFGAEAG.frequencyRange = FrequencyRange.UpperMidrange;
		}
		if ((bool)CNICPOPEDIO)
		{
			CNICPOPEDIO.time = 754f;
			CNICPOPEDIO.widthMultiplier = 1856f;
			CNICPOPEDIO.Clear();
		}
	}

	public void FCLOFNOFCPP(int JMMILEFMACB)
	{
		COPNGFGAEAG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	public override void NELGLIKDNLH(Vector3 LOMLCCLOIKN)
	{
		targetRotation = LOMLCCLOIKN;
		base.transform.localRotation = Quaternion.Euler(targetRotation);
	}
}
