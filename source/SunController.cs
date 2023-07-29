// SunController
using AudioVisualizer;
using UnityEngine;

public class SunController : EnvironmentController
{
	public float progress = 1f;

	public Color color1;

	public Color color2;

	public float colorLerp = 10f;

	public float emission = 1.5f;

	private Renderer HKIDNEAKGNO;

	private DynamicScale CBNKJGPOLMG;

	private PlayerBase JFCPJAELJOE;

	public void FPFMNEAEMFJ(float DPNHODJHGJL)
	{
		CBNKJGPOLMG.sensitivity = DPNHODJHGJL;
	}

	public void AODCDDKFJHM(Vector3 JJIJODIEBFP)
	{
		CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	public void LIMBPIFKKDK(int CDPLIMAJBGF)
	{
		CBNKJGPOLMG.frequencyRange = (FrequencyRange)CDPLIMAJBGF;
	}

	public void ILOGAHJCLJE(Color MGHJCGBNEPL, Color NBPMHDANECK, float MNHBOECHFEG)
	{
		color1 = MGHJCGBNEPL;
		color2 = NBPMHDANECK;
		colorLerp = MNHBOECHFEG;
	}

	public void KOODDHJPHOI(Vector3 LPIMAGMABLC)
	{
		CBNKJGPOLMG.baseScale = LPIMAGMABLC;
	}

	public void HKPKMPPKPAI(Vector3 GNIJKBCHEPG)
	{
		CBNKJGPOLMG.minSize = GNIJKBCHEPG;
	}

	public void CADMAAOOAGF(Color MGHJCGBNEPL, Color NBPMHDANECK, float MNHBOECHFEG)
	{
		color1 = MGHJCGBNEPL;
		color2 = NBPMHDANECK;
		colorLerp = MNHBOECHFEG;
	}

	public void MNKFLALANBJ(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public void KJNBBODKMCD(Vector3 GNIJKBCHEPG)
	{
		CBNKJGPOLMG.minSize = GNIJKBCHEPG;
	}

	public override void APKNAPHOFHC()
	{
		base.CFIAKIJAILI();
		progress = JFCPJAELJOE.GetLifesProgrees();
		HKIDNEAKGNO.material.SetColor("Myst", Color.Lerp(HKIDNEAKGNO.material.GetColor("CameraFilterPack_VHS2"), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetColor("IEnumerable", Color.Lerp(HKIDNEAKGNO.material.GetColor(":"), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetFloat("Fade", Mathf.Lerp(HKIDNEAKGNO.material.GetFloat("CameraFilterPack/FX_Screens"), emission * 609f, Time.smoothDeltaTime * colorLerp));
	}

	public void PIDMIGPIMMC(float DPNHODJHGJL)
	{
		CBNKJGPOLMG.sensitivity = DPNHODJHGJL;
	}

	public void OAPMDGDCEGO(Vector3 JJIJODIEBFP)
	{
		CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	public override void FGAPIOELJCG()
	{
		base.CEACMFGNDEB();
		CBNKJGPOLMG.LOKKIADJAFE();
		progress = 1934f;
		color1 = new Color(186f, 1233f, 342f);
		color2 = new Color(1019f, 1155f, 1445f);
		colorLerp = 317f;
		emission = 421f;
	}

	public void MFMPKLLLILB(int CDPLIMAJBGF)
	{
		CBNKJGPOLMG.frequencyRange = (FrequencyRange)CDPLIMAJBGF;
	}

	public override void JDGFCEPDKAJ()
	{
		base.EHCGBJDFMHG();
		progress = JFCPJAELJOE.GetLifesProgrees();
		HKIDNEAKGNO.material.SetColor(".lastCheckpoint.playerdistance", Color.Lerp(HKIDNEAKGNO.material.GetColor("_Value4"), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetColor("_ScreenResolution", Color.Lerp(HKIDNEAKGNO.material.GetColor("_Green_R"), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetFloat("threshold", Mathf.Lerp(HKIDNEAKGNO.material.GetFloat("icon.png"), emission * 1736f, Time.smoothDeltaTime * colorLerp));
	}

	public void GBEAKNALDOE(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void Awake()
	{
		base.Awake();
		HKIDNEAKGNO = GetComponent<Renderer>();
		CBNKJGPOLMG = GetComponent<DynamicScale>();
		JFCPJAELJOE = GetComponentInParent<PlayerBase>();
	}

	public override void LECPHJOIGKN()
	{
		base.GONKPNAAIEE();
		CBNKJGPOLMG.IJHGPCAHDEH();
		progress = 85f;
		color1 = new Color(160f, 899f, 69f);
		color2 = new Color(874f, 773f, 934f);
		colorLerp = 1048f;
		emission = 537f;
	}

	public void OBNOLJNCFFO(Color MGHJCGBNEPL, Color NBPMHDANECK, float MNHBOECHFEG)
	{
		color1 = MGHJCGBNEPL;
		color2 = NBPMHDANECK;
		colorLerp = MNHBOECHFEG;
	}

	public void OGCEBFAEBGO(Vector3 JJIJODIEBFP)
	{
		CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	public void SetSensitivity(float DPNHODJHGJL)
	{
		CBNKJGPOLMG.sensitivity = DPNHODJHGJL;
	}

	public void DJGAAJMNGND(Vector3 GNIJKBCHEPG)
	{
		CBNKJGPOLMG.minSize = GNIJKBCHEPG;
	}

	public override void IBFJAOINHMK()
	{
		base.Update();
		progress = JFCPJAELJOE.GetLifesProgrees();
		HKIDNEAKGNO.material.SetColor("_TimeX", Color.Lerp(HKIDNEAKGNO.material.GetColor("/"), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetColor("ticket", Color.Lerp(HKIDNEAKGNO.material.GetColor("_FixDistance"), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetFloat("_RampTex", Mathf.Lerp(HKIDNEAKGNO.material.GetFloat("ResetButton"), emission * 503f, Time.smoothDeltaTime * colorLerp));
	}

	public void KNINICADKDB(Color MGHJCGBNEPL, Color NBPMHDANECK, float MNHBOECHFEG)
	{
		color1 = MGHJCGBNEPL;
		color2 = NBPMHDANECK;
		colorLerp = MNHBOECHFEG;
	}

	public override void KGMCGGIEPDE()
	{
		base.EMANBHKAONB();
		HKIDNEAKGNO = GetComponent<Renderer>();
		CBNKJGPOLMG = GetComponent<DynamicScale>();
		JFCPJAELJOE = GetComponentInParent<PlayerBase>();
	}

	public void JOICINMJKHE(Vector3 LPIMAGMABLC)
	{
		CBNKJGPOLMG.baseScale = LPIMAGMABLC;
	}

	public override void FOLDLDLFFLM()
	{
		base.Update();
		progress = JFCPJAELJOE.GetLifesProgrees();
		HKIDNEAKGNO.material.SetColor("_Value2", Color.Lerp(HKIDNEAKGNO.material.GetColor("/icon"), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetColor("DPADHOR", Color.Lerp(HKIDNEAKGNO.material.GetColor("settings.customdataskin"), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetFloat("ConfigVersionSlider", Mathf.Lerp(HKIDNEAKGNO.material.GetFloat("OPEN"), emission * 53f, Time.smoothDeltaTime * colorLerp));
	}

	public void JMFHNBLFEIE(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public void NJEKLECIGIJ(float KEDDLFDAIDE)
	{
		CBNKJGPOLMG.lerpSpeed = KEDDLFDAIDE;
	}

	public void CNGNBAKGKGB(Color MGHJCGBNEPL, Color NBPMHDANECK, float MNHBOECHFEG)
	{
		color1 = MGHJCGBNEPL;
		color2 = NBPMHDANECK;
		colorLerp = MNHBOECHFEG;
	}

	public void EFMAODCEBPD(float KEDDLFDAIDE)
	{
		CBNKJGPOLMG.lerpSpeed = KEDDLFDAIDE;
	}

	public void PLGPEHKIAHA(Color MGHJCGBNEPL, Color NBPMHDANECK, float MNHBOECHFEG)
	{
		color1 = MGHJCGBNEPL;
		color2 = NBPMHDANECK;
		colorLerp = MNHBOECHFEG;
	}

	public void GEKNJFEGELD(Vector3 GNIJKBCHEPG)
	{
		CBNKJGPOLMG.minSize = GNIJKBCHEPG;
	}

	public void FJCHGDMEGLO(Vector3 JJIJODIEBFP)
	{
		CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	public void LDDBLLHGOCO(Vector3 LPIMAGMABLC)
	{
		CBNKJGPOLMG.baseScale = LPIMAGMABLC;
	}

	public override void KAMMKPFNJJF()
	{
		base.FAAJAMIGJNK();
		HKIDNEAKGNO = GetComponent<Renderer>();
		CBNKJGPOLMG = GetComponent<DynamicScale>();
		JFCPJAELJOE = GetComponentInParent<PlayerBase>();
	}

	public override void PBEPCAPAKLG()
	{
		base.Update();
		progress = JFCPJAELJOE.GetLifesProgrees();
		HKIDNEAKGNO.material.SetColor("RateButton", Color.Lerp(HKIDNEAKGNO.material.GetColor("_ScreenResolution"), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetColor("not available at the moment", Color.Lerp(HKIDNEAKGNO.material.GetColor("UsernameText"), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetFloat("_Value3", Mathf.Lerp(HKIDNEAKGNO.material.GetFloat("================================"), emission * 1189f, Time.smoothDeltaTime * colorLerp));
	}

	public void JKFAGJIBKJF(float DPNHODJHGJL)
	{
		CBNKJGPOLMG.sensitivity = DPNHODJHGJL;
	}

	public void BIBILLGDIBG(Vector3 JJIJODIEBFP)
	{
		CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	public void SetColors(Color MGHJCGBNEPL, Color NBPMHDANECK, float MNHBOECHFEG)
	{
		color1 = MGHJCGBNEPL;
		color2 = NBPMHDANECK;
		colorLerp = MNHBOECHFEG;
	}

	public void IHJGHNLJOGF(Vector3 LPIMAGMABLC)
	{
		CBNKJGPOLMG.baseScale = LPIMAGMABLC;
	}

	public override void KCDOMIJBFLL()
	{
		base.FBMDHDBELEK();
		progress = JFCPJAELJOE.GetLifesProgrees();
		HKIDNEAKGNO.material.SetColor("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", Color.Lerp(HKIDNEAKGNO.material.GetColor("Default UI Material"), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetColor("[Up]", Color.Lerp(HKIDNEAKGNO.material.GetColor(".completedMaps"), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetFloat("LoadMapCanvas", Mathf.Lerp(HKIDNEAKGNO.material.GetFloat("No peer to communicate with. "), emission * 204f, Time.smoothDeltaTime * colorLerp));
	}

	public void CNGIFFAFGOE(Vector3 GNIJKBCHEPG)
	{
		CBNKJGPOLMG.minSize = GNIJKBCHEPG;
	}

	public void ECCFMFNCBIE(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public void PCIPLDNAFCL(float DPNHODJHGJL)
	{
		CBNKJGPOLMG.sensitivity = DPNHODJHGJL;
	}

	public void KPALEBGNCCK(int CDPLIMAJBGF)
	{
		CBNKJGPOLMG.frequencyRange = (FrequencyRange)CDPLIMAJBGF;
	}

	public void CHOKKIPDAPF(Color MGHJCGBNEPL, Color NBPMHDANECK, float MNHBOECHFEG)
	{
		color1 = MGHJCGBNEPL;
		color2 = NBPMHDANECK;
		colorLerp = MNHBOECHFEG;
	}

	public void ICKKICJIHIP(Vector3 LPIMAGMABLC)
	{
		CBNKJGPOLMG.baseScale = LPIMAGMABLC;
	}

	public void DGDLNGADPCP(Vector3 LPIMAGMABLC)
	{
		CBNKJGPOLMG.baseScale = LPIMAGMABLC;
	}

	public void OLDNDBMGMEM(Vector3 LPIMAGMABLC)
	{
		CBNKJGPOLMG.baseScale = LPIMAGMABLC;
	}

	public override void HFFAJNCOJNB()
	{
		base.EGFBPCMCNDJ();
		CBNKJGPOLMG.LOKKIADJAFE();
		progress = 1325f;
		color1 = new Color(681f, 627f, 963f);
		color2 = new Color(43f, 393f, 1251f);
		colorLerp = 1519f;
		emission = 1991f;
	}

	public void KHMMCADJNOE(float KEDDLFDAIDE)
	{
		CBNKJGPOLMG.lerpSpeed = KEDDLFDAIDE;
	}

	public override void Reset()
	{
		base.Reset();
		CBNKJGPOLMG.Reset();
		progress = 1f;
		color1 = new Color(0.8f, 0.8f, 1f);
		color2 = new Color(1f, 0f, 0f);
		colorLerp = 10f;
		emission = 1.5f;
	}

	public override void MNBMLBLLDGL()
	{
		base.LOKKIADJAFE();
		CBNKJGPOLMG.FPKJJBAENGF();
		progress = 1135f;
		color1 = new Color(1594f, 726f, 581f);
		color2 = new Color(1626f, 556f, 1541f);
		colorLerp = 1253f;
		emission = 823f;
	}

	public void BHMCBLOPIDP(Vector3 GNIJKBCHEPG)
	{
		CBNKJGPOLMG.minSize = GNIJKBCHEPG;
	}

	public override void PEMPABLNJHL()
	{
		base.FMAFBLKAJDF();
		HKIDNEAKGNO = GetComponent<Renderer>();
		CBNKJGPOLMG = GetComponent<DynamicScale>();
		JFCPJAELJOE = GetComponentInParent<PlayerBase>();
	}

	public void MCHHNIMHKMG(int CDPLIMAJBGF)
	{
		CBNKJGPOLMG.frequencyRange = (FrequencyRange)CDPLIMAJBGF;
	}

	public void BABLMFPOAJN(Vector3 JJIJODIEBFP)
	{
		CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	public void BELGEMHIJAG(float KEDDLFDAIDE)
	{
		CBNKJGPOLMG.lerpSpeed = KEDDLFDAIDE;
	}

	public override void PDDIOCCBAIL()
	{
		base.BJIKAHNJNEB();
		CBNKJGPOLMG.MANOCIJICLG();
		progress = 395f;
		color1 = new Color(179f, 1f, 1143f);
		color2 = new Color(1275f, 1908f, 122f);
		colorLerp = 1424f;
		emission = 656f;
	}

	public void HMHOIIOKNBL(Vector3 GNIJKBCHEPG)
	{
		CBNKJGPOLMG.minSize = GNIJKBCHEPG;
	}

	public void FGOHDAKFFHF(float DPNHODJHGJL)
	{
		CBNKJGPOLMG.sensitivity = DPNHODJHGJL;
	}

	public void FNKMABBHBPA(Vector3 GNIJKBCHEPG)
	{
		CBNKJGPOLMG.minSize = GNIJKBCHEPG;
	}

	public override void MGGNFEPGIJI()
	{
		base.Awake();
		HKIDNEAKGNO = GetComponent<Renderer>();
		CBNKJGPOLMG = GetComponent<DynamicScale>();
		JFCPJAELJOE = GetComponentInParent<PlayerBase>();
	}

	public void MEEEPDEELKJ(Color MGHJCGBNEPL, Color NBPMHDANECK, float MNHBOECHFEG)
	{
		color1 = MGHJCGBNEPL;
		color2 = NBPMHDANECK;
		colorLerp = MNHBOECHFEG;
	}

	public void FJNPBDEIAEJ(Vector3 JJIJODIEBFP)
	{
		CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	public override void PPGKBEJLBFJ()
	{
		base.NLNAJMCBNDC();
		HKIDNEAKGNO = GetComponent<Renderer>();
		CBNKJGPOLMG = GetComponent<DynamicScale>();
		JFCPJAELJOE = GetComponentInParent<PlayerBase>();
	}

	public void NECMHCAPIIC(Vector3 JJIJODIEBFP)
	{
		CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	public void GAMBCMHFONG(Vector3 GNIJKBCHEPG)
	{
		CBNKJGPOLMG.minSize = GNIJKBCHEPG;
	}

	public void SetMinSize(Vector3 GNIJKBCHEPG)
	{
		CBNKJGPOLMG.minSize = GNIJKBCHEPG;
	}

	public override void PMBIKIBOHOF()
	{
		base.OPFDGBDADMA();
		HKIDNEAKGNO = GetComponent<Renderer>();
		CBNKJGPOLMG = GetComponent<DynamicScale>();
		JFCPJAELJOE = GetComponentInParent<PlayerBase>();
	}

	public void OGIBAKNNLGH(Vector3 JJIJODIEBFP)
	{
		CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	public void PMFPFNMCAPF(Color MGHJCGBNEPL, Color NBPMHDANECK, float MNHBOECHFEG)
	{
		color1 = MGHJCGBNEPL;
		color2 = NBPMHDANECK;
		colorLerp = MNHBOECHFEG;
	}

	public void GBBPDPPAOKP(Vector3 JJIJODIEBFP)
	{
		CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	public override void LBPCODPOJAH()
	{
		base.EHCGBJDFMHG();
		progress = JFCPJAELJOE.GetLifesProgrees();
		HKIDNEAKGNO.material.SetColor("Object ID. Case-Sensitive", Color.Lerp(HKIDNEAKGNO.material.GetColor("Reconnect() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages."), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetColor("curScn", Color.Lerp(HKIDNEAKGNO.material.GetColor("Crosshair"), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetFloat("Delete events", Mathf.Lerp(HKIDNEAKGNO.material.GetFloat("PLEASE WAIT"), emission * 479f, Time.smoothDeltaTime * colorLerp));
	}

	public override void IKIDIJLIGOH()
	{
		base.CFIAKIJAILI();
		progress = JFCPJAELJOE.GetLifesProgrees();
		HKIDNEAKGNO.material.SetColor("_Amount", Color.Lerp(HKIDNEAKGNO.material.GetColor("Connection error: "), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetColor("mapselector.filter.rateduponly", Color.Lerp(HKIDNEAKGNO.material.GetColor("%"), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetFloat("NOISE", Mathf.Lerp(HKIDNEAKGNO.material.GetFloat("_TimeX"), emission * 74f, Time.smoothDeltaTime * colorLerp));
	}

	public override void JLEAKFENJDJ()
	{
		base.EGFBPCMCNDJ();
		CBNKJGPOLMG.LDGJGONCEND();
		progress = 1920f;
		color1 = new Color(600f, 1135f, 1633f);
		color2 = new Color(844f, 377f, 1226f);
		colorLerp = 1779f;
		emission = 1297f;
	}

	public override void GEGFJJBCHPE()
	{
		base.EMANBHKAONB();
		HKIDNEAKGNO = GetComponent<Renderer>();
		CBNKJGPOLMG = GetComponent<DynamicScale>();
		JFCPJAELJOE = GetComponentInParent<PlayerBase>();
	}

	public void MLFMFOBDOED(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void PHHOMLJECOJ()
	{
		base.FAAJAMIGJNK();
		HKIDNEAKGNO = GetComponent<Renderer>();
		CBNKJGPOLMG = GetComponent<DynamicScale>();
		JFCPJAELJOE = GetComponentInParent<PlayerBase>();
	}

	public void HJONHHLOCJM(float KEDDLFDAIDE)
	{
		CBNKJGPOLMG.lerpSpeed = KEDDLFDAIDE;
	}

	public void KOHFHNBPBGG(int CDPLIMAJBGF)
	{
		CBNKJGPOLMG.frequencyRange = (FrequencyRange)CDPLIMAJBGF;
	}

	public override void IJHGPCAHDEH()
	{
		base.EEBGCGFNELO();
		CBNKJGPOLMG.Reset();
		progress = 1343f;
		color1 = new Color(221f, 1734f, 1941f);
		color2 = new Color(857f, 1973f, 1116f);
		colorLerp = 1728f;
		emission = 1701f;
	}

	public override void NCBGPIKDFIA()
	{
		base.Awake();
		HKIDNEAKGNO = GetComponent<Renderer>();
		CBNKJGPOLMG = GetComponent<DynamicScale>();
		JFCPJAELJOE = GetComponentInParent<PlayerBase>();
	}

	public override void GMIOCKFLJAK()
	{
		base.GMIOCKFLJAK();
		HKIDNEAKGNO = GetComponent<Renderer>();
		CBNKJGPOLMG = GetComponent<DynamicScale>();
		JFCPJAELJOE = GetComponentInParent<PlayerBase>();
	}

	public void ECMFHKLEKKL(Vector3 LPIMAGMABLC)
	{
		CBNKJGPOLMG.baseScale = LPIMAGMABLC;
	}

	public void SetDirectionVector(Vector3 LPIMAGMABLC)
	{
		CBNKJGPOLMG.baseScale = LPIMAGMABLC;
	}

	public void FBBLHEJADMH(float KEDDLFDAIDE)
	{
		CBNKJGPOLMG.lerpSpeed = KEDDLFDAIDE;
	}

	public void JCILLLLGEDB(float KEDDLFDAIDE)
	{
		CBNKJGPOLMG.lerpSpeed = KEDDLFDAIDE;
	}

	public void BACLAELPOJJ(Vector3 JJIJODIEBFP)
	{
		CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	public void HLHAFCDNMEJ(Color MGHJCGBNEPL, Color NBPMHDANECK, float MNHBOECHFEG)
	{
		color1 = MGHJCGBNEPL;
		color2 = NBPMHDANECK;
		colorLerp = MNHBOECHFEG;
	}

	public override void MMPOJCFOGJJ()
	{
		base.EMANBHKAONB();
		HKIDNEAKGNO = GetComponent<Renderer>();
		CBNKJGPOLMG = GetComponent<DynamicScale>();
		JFCPJAELJOE = GetComponentInParent<PlayerBase>();
	}

	public void KBAEPPHJJME(Vector3 GNIJKBCHEPG)
	{
		CBNKJGPOLMG.minSize = GNIJKBCHEPG;
	}

	public void ACMENOHGOKD(Vector3 LPIMAGMABLC)
	{
		CBNKJGPOLMG.baseScale = LPIMAGMABLC;
	}

	public void BJJCBNPBKNK(float KEDDLFDAIDE)
	{
		CBNKJGPOLMG.lerpSpeed = KEDDLFDAIDE;
	}

	public void GFGABKGDCOP(int CDPLIMAJBGF)
	{
		CBNKJGPOLMG.frequencyRange = (FrequencyRange)CDPLIMAJBGF;
	}

	public override void MFIMFMCMADK()
	{
		base.IOMCHHBGJEC();
		HKIDNEAKGNO = GetComponent<Renderer>();
		CBNKJGPOLMG = GetComponent<DynamicScale>();
		JFCPJAELJOE = GetComponentInParent<PlayerBase>();
	}

	public void JFLOMHACLFJ(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public void HDIDPJOPIIK(int CDPLIMAJBGF)
	{
		CBNKJGPOLMG.frequencyRange = (FrequencyRange)CDPLIMAJBGF;
	}

	public void MPFAHHOEMLL(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public void SetMaxSize(Vector3 JJIJODIEBFP)
	{
		CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	public override void LHIBPEGLPHM()
	{
		base.EGFBPCMCNDJ();
		CBNKJGPOLMG.MANOCIJICLG();
		progress = 37f;
		color1 = new Color(1552f, 1428f, 349f);
		color2 = new Color(645f, 1267f, 1757f);
		colorLerp = 497f;
		emission = 1173f;
	}

	public void FKOAHEGNACN(float DPNHODJHGJL)
	{
		CBNKJGPOLMG.sensitivity = DPNHODJHGJL;
	}

	public void HKIHBIMMECG(int CDPLIMAJBGF)
	{
		CBNKJGPOLMG.frequencyRange = (FrequencyRange)CDPLIMAJBGF;
	}

	public override void Update()
	{
		base.Update();
		progress = JFCPJAELJOE.GetLifesProgrees();
		HKIDNEAKGNO.material.SetColor("_DiffuseColor", Color.Lerp(HKIDNEAKGNO.material.GetColor("_DiffuseColor"), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetColor("_EmissionColor", Color.Lerp(HKIDNEAKGNO.material.GetColor("_EmissionColor"), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetFloat("_EmissionGain", Mathf.Lerp(HKIDNEAKGNO.material.GetFloat("_EmissionGain"), emission * 0.2f, Time.smoothDeltaTime * colorLerp));
	}

	public void LCEFIHHFECN(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public void PFKOEHEFPDC(float DPNHODJHGJL)
	{
		CBNKJGPOLMG.sensitivity = DPNHODJHGJL;
	}

	public override void GCHBGCGBMCK()
	{
		base.EHCGBJDFMHG();
		progress = JFCPJAELJOE.GetLifesProgrees();
		HKIDNEAKGNO.material.SetColor("OxOD.lastPath", Color.Lerp(HKIDNEAKGNO.material.GetColor(","), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetColor("GlassColor", Color.Lerp(HKIDNEAKGNO.material.GetColor("maps."), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetFloat("_Value2", Mathf.Lerp(HKIDNEAKGNO.material.GetFloat("id"), emission * 858f, Time.smoothDeltaTime * colorLerp));
	}

	public void KADFLOHLAHN(Vector3 LPIMAGMABLC)
	{
		CBNKJGPOLMG.baseScale = LPIMAGMABLC;
	}

	public override void ANKIJGCGCBF()
	{
		base.NKLIHNJCHOG();
		progress = JFCPJAELJOE.GetLifesProgrees();
		HKIDNEAKGNO.material.SetColor(" not exist", Color.Lerp(HKIDNEAKGNO.material.GetColor("_Value"), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetColor("_ZCurve", Color.Lerp(HKIDNEAKGNO.material.GetColor("Instance\nWorking commands:\ninit or init <savepath>\npath\nsetint <key> <value>\ngetint <key> <value>\nsetfloat <key> <value>\ngetfloat <key> <value>\nsetstring <key> <value>\ngetstring <key> <value>\nsetbool <key> <value>\ngetbool <key> <value>\ndelete <key>\ndeleteall"), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetFloat("Drop_Near", Mathf.Lerp(HKIDNEAKGNO.material.GetFloat("settings.arcsdestroydelay"), emission * 1826f, Time.smoothDeltaTime * colorLerp));
	}

	public void PFDKFJNHEBG(float DPNHODJHGJL)
	{
		CBNKJGPOLMG.sensitivity = DPNHODJHGJL;
	}

	public void OOODGNGKHFJ(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public void SetLerpSpeed(float KEDDLFDAIDE)
	{
		CBNKJGPOLMG.lerpSpeed = KEDDLFDAIDE;
	}

	public void HNGCLAICCCG(float DPNHODJHGJL)
	{
		CBNKJGPOLMG.sensitivity = DPNHODJHGJL;
	}

	public void MNOLJMNLCDM(float KEDDLFDAIDE)
	{
		CBNKJGPOLMG.lerpSpeed = KEDDLFDAIDE;
	}

	public void IHCOABDFACH(Vector3 JJIJODIEBFP)
	{
		CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	public override void OFKDKJGIDLH()
	{
		base.CAPPKCBFILL();
		CBNKJGPOLMG.ABDHDGNIHHI();
		progress = 185f;
		color1 = new Color(1272f, 1773f, 445f);
		color2 = new Color(906f, 1274f, 1767f);
		colorLerp = 720f;
		emission = 1310f;
	}

	public void DNDDCKDKKHI(float KEDDLFDAIDE)
	{
		CBNKJGPOLMG.lerpSpeed = KEDDLFDAIDE;
	}

	public void DICHOHBLHAH(Color MGHJCGBNEPL, Color NBPMHDANECK, float MNHBOECHFEG)
	{
		color1 = MGHJCGBNEPL;
		color2 = NBPMHDANECK;
		colorLerp = MNHBOECHFEG;
	}

	public override void MCIEAOAMOIG()
	{
		base.OLFNCABJBHA();
		HKIDNEAKGNO = GetComponent<Renderer>();
		CBNKJGPOLMG = GetComponent<DynamicScale>();
		JFCPJAELJOE = GetComponentInParent<PlayerBase>();
	}

	public override void MFAMHKBMBEI()
	{
		base.OKADMJFLMGP();
		HKIDNEAKGNO = GetComponent<Renderer>();
		CBNKJGPOLMG = GetComponent<DynamicScale>();
		JFCPJAELJOE = GetComponentInParent<PlayerBase>();
	}

	public void GFBAGLKILDG(Vector3 JJIJODIEBFP)
	{
		CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	public void SetEmission(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public void LGDMAKOAICA(int CDPLIMAJBGF)
	{
		CBNKJGPOLMG.frequencyRange = (FrequencyRange)CDPLIMAJBGF;
	}

	public void LPNMGHEPBKK(Vector3 JJIJODIEBFP)
	{
		CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	public override void OMAEOBBHHCP()
	{
		base.LAACNNJDKBI();
		CBNKJGPOLMG.MANOCIJICLG();
		progress = 619f;
		color1 = new Color(365f, 1274f, 916f);
		color2 = new Color(1721f, 814f, 1397f);
		colorLerp = 1192f;
		emission = 1377f;
	}

	public void LGFILNGJAOH(int CDPLIMAJBGF)
	{
		CBNKJGPOLMG.frequencyRange = (FrequencyRange)CDPLIMAJBGF;
	}

	public void SetInput(int CDPLIMAJBGF)
	{
		CBNKJGPOLMG.frequencyRange = (FrequencyRange)CDPLIMAJBGF;
	}
}
