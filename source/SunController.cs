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

	public void MLLKGJCGMOD(float DPNHODJHGJL)
	{
		CBNKJGPOLMG.sensitivity = DPNHODJHGJL;
	}

	public override void JEKEBJCHOHO()
	{
		base.Reset();
		CBNKJGPOLMG.LOKKIADJAFE();
		progress = 1089f;
		color1 = new Color(1160f, 1765f, 525f);
		color2 = new Color(700f, 1233f, 695f);
		colorLerp = 813f;
		emission = 844f;
	}

	public override void LLJLDLLNFBH()
	{
		base.LEAHIBJDMBI();
		progress = JFCPJAELJOE.GetLifesProgrees();
		HKIDNEAKGNO.material.SetColor("_EmissionColor", Color.Lerp(HKIDNEAKGNO.material.GetColor("player.goldbat"), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetColor("_ScreenResolution", Color.Lerp(HKIDNEAKGNO.material.GetColor("addNewButton"), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetFloat("_ScreenResolution", Mathf.Lerp(HKIDNEAKGNO.material.GetFloat("\" that takes "), emission * 1888f, Time.smoothDeltaTime * colorLerp));
	}

	public void PGIDHLPAOAJ(Vector3 GNIJKBCHEPG)
	{
		CBNKJGPOLMG.minSize = GNIJKBCHEPG;
	}

	public void CEOJCIBAPIF(Vector3 JJIJODIEBFP)
	{
		CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	public override void NNNCKCELBCE()
	{
		base.Reset();
		CBNKJGPOLMG.LBMLGIAKJCH();
		progress = 1700f;
		color1 = new Color(1409f, 1559f, 640f);
		color2 = new Color(301f, 1440f, 1451f);
		colorLerp = 1648f;
		emission = 888f;
	}

	public void BHCDCNCDOCE(Vector3 LPIMAGMABLC)
	{
		CBNKJGPOLMG.baseScale = LPIMAGMABLC;
	}

	public override void KIEJKBNBHMD()
	{
		base.BGFJOEPFOPM();
		progress = JFCPJAELJOE.PNBDCKLMJKA();
		HKIDNEAKGNO.material.SetColor("_TimeX", Color.Lerp(HKIDNEAKGNO.material.GetColor("[EditorEvent] Exception: "), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetColor(" By: ", Color.Lerp(HKIDNEAKGNO.material.GetColor("[PlayerController] "), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetFloat("OnJoinedRoom() called by PUN. Now this client is in a room. From here on, your game would be running. For reference, all callbacks are listed in enum: PhotonNetworkingMessage", Mathf.Lerp(HKIDNEAKGNO.material.GetFloat("_ScratchOffsetScale"), emission * 116f, Time.smoothDeltaTime * colorLerp));
	}

	public void HNGCLAICCCG(float DPNHODJHGJL)
	{
		CBNKJGPOLMG.sensitivity = DPNHODJHGJL;
	}

	public void EEMONPABGNA(Vector3 JJIJODIEBFP)
	{
		CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	public override void OPCLBGHAPMG()
	{
		base.BGFJOEPFOPM();
		progress = JFCPJAELJOE.GetLifesProgrees();
		HKIDNEAKGNO.material.SetColor("[PlayerBase] Saveing checkpoint data", Color.Lerp(HKIDNEAKGNO.material.GetColor("_Size"), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetColor("R2", Color.Lerp(HKIDNEAKGNO.material.GetColor("Submit"), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetFloat("_Value3", Mathf.Lerp(HKIDNEAKGNO.material.GetFloat("Horizontal"), emission * 1946f, Time.smoothDeltaTime * colorLerp));
	}

	public void KKLHBMDCPDH(Color MGHJCGBNEPL, Color NBPMHDANECK, float MNHBOECHFEG)
	{
		color1 = MGHJCGBNEPL;
		color2 = NBPMHDANECK;
		colorLerp = MNHBOECHFEG;
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

	public override void LEAHIBJDMBI()
	{
		base.LEAHIBJDMBI();
		progress = JFCPJAELJOE.PKPBMPFIGBL();
		HKIDNEAKGNO.material.SetColor("file://", Color.Lerp(HKIDNEAKGNO.material.GetColor("Joystick1Button5"), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetColor("_Value4", Color.Lerp(HKIDNEAKGNO.material.GetColor("HiddenToggle"), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetFloat("_MainTex", Mathf.Lerp(HKIDNEAKGNO.material.GetFloat(" "), emission * 1655f, Time.smoothDeltaTime * colorLerp));
	}

	public void CLGELDPAGAP(Vector3 GNIJKBCHEPG)
	{
		CBNKJGPOLMG.minSize = GNIJKBCHEPG;
	}

	public void GPJJDCMBPFJ(int CDPLIMAJBGF)
	{
		CBNKJGPOLMG.frequencyRange = (FrequencyRange)CDPLIMAJBGF;
	}

	public void SetSensitivity(float DPNHODJHGJL)
	{
		CBNKJGPOLMG.sensitivity = DPNHODJHGJL;
	}

	public void BDCIJFPFACO(float KEDDLFDAIDE)
	{
		CBNKJGPOLMG.lerpSpeed = KEDDLFDAIDE;
	}

	public void NFKMLLAKHBB(float DPNHODJHGJL)
	{
		CBNKJGPOLMG.sensitivity = DPNHODJHGJL;
	}

	public void BKAFHKNOODF(Vector3 JJIJODIEBFP)
	{
		CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	public void IPCKGANFILN(int CDPLIMAJBGF)
	{
		CBNKJGPOLMG.frequencyRange = (FrequencyRange)CDPLIMAJBGF;
	}

	public void JCJDHJDJBGO(int CDPLIMAJBGF)
	{
		CBNKJGPOLMG.frequencyRange = (FrequencyRange)CDPLIMAJBGF;
	}

	public void LBBOKJEFGIK(Color MGHJCGBNEPL, Color NBPMHDANECK, float MNHBOECHFEG)
	{
		color1 = MGHJCGBNEPL;
		color2 = NBPMHDANECK;
		colorLerp = MNHBOECHFEG;
	}

	public void FKMAMJECKAP(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public void GLKGFPGHEAG(int CDPLIMAJBGF)
	{
		CBNKJGPOLMG.frequencyRange = (FrequencyRange)CDPLIMAJBGF;
	}

	public void JHNFNOOLMDB(int CDPLIMAJBGF)
	{
		CBNKJGPOLMG.frequencyRange = (FrequencyRange)CDPLIMAJBGF;
	}

	public void GAOENJHFCOJ(Vector3 LPIMAGMABLC)
	{
		CBNKJGPOLMG.baseScale = LPIMAGMABLC;
	}

	public void BAAIMFPJANF(Color MGHJCGBNEPL, Color NBPMHDANECK, float MNHBOECHFEG)
	{
		color1 = MGHJCGBNEPL;
		color2 = NBPMHDANECK;
		colorLerp = MNHBOECHFEG;
	}

	public void SetColors(Color MGHJCGBNEPL, Color NBPMHDANECK, float MNHBOECHFEG)
	{
		color1 = MGHJCGBNEPL;
		color2 = NBPMHDANECK;
		colorLerp = MNHBOECHFEG;
	}

	public override void DAHIMKKFNPH()
	{
		base.POHMFMNEPKK();
		HKIDNEAKGNO = GetComponent<Renderer>();
		CBNKJGPOLMG = GetComponent<DynamicScale>();
		JFCPJAELJOE = GetComponentInParent<PlayerBase>();
	}

	public override void IKIDIJLIGOH()
	{
		base.LEAHIBJDMBI();
		progress = JFCPJAELJOE.PKPBMPFIGBL();
		HKIDNEAKGNO.material.SetColor("runas", Color.Lerp(HKIDNEAKGNO.material.GetColor("\n"), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetColor("Failed to InstantiateSceneObject prefab: ", Color.Lerp(HKIDNEAKGNO.material.GetColor("ScoreText"), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetFloat(" scene: ", Mathf.Lerp(HKIDNEAKGNO.material.GetFloat("_Value"), emission * 171f, Time.smoothDeltaTime * colorLerp));
	}

	public void DOMMEBBONIL(Vector3 LPIMAGMABLC)
	{
		CBNKJGPOLMG.baseScale = LPIMAGMABLC;
	}

	public void HNLFGIGAODP(Color MGHJCGBNEPL, Color NBPMHDANECK, float MNHBOECHFEG)
	{
		color1 = MGHJCGBNEPL;
		color2 = NBPMHDANECK;
		colorLerp = MNHBOECHFEG;
	}

	public void SetInput(int CDPLIMAJBGF)
	{
		CBNKJGPOLMG.frequencyRange = (FrequencyRange)CDPLIMAJBGF;
	}

	public override void KOBJAEPJJJM()
	{
		base.OGAMGLEAOAF();
		CBNKJGPOLMG.LECPHJOIGKN();
		progress = 1513f;
		color1 = new Color(143f, 1054f, 1992f);
		color2 = new Color(318f, 1752f, 903f);
		colorLerp = 759f;
		emission = 1955f;
	}

	public override void OCMKCBBCEFG()
	{
		base.Update();
		progress = JFCPJAELJOE.PKPBMPFIGBL();
		HKIDNEAKGNO.material.SetColor(".status", Color.Lerp(HKIDNEAKGNO.material.GetColor("Mask texture not readable, set your sprite to Texture Type 'Advanced' and check 'Read/Write Enabled'"), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetColor("music", Color.Lerp(HKIDNEAKGNO.material.GetColor("_Value2"), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetFloat("_ScreenResolution", Mathf.Lerp(HKIDNEAKGNO.material.GetFloat("StartButton"), emission * 554f, Time.smoothDeltaTime * colorLerp));
	}

	public void GMAMAPAADPE(Vector3 GNIJKBCHEPG)
	{
		CBNKJGPOLMG.minSize = GNIJKBCHEPG;
	}

	public void GKFKHJJFIID(Color MGHJCGBNEPL, Color NBPMHDANECK, float MNHBOECHFEG)
	{
		color1 = MGHJCGBNEPL;
		color2 = NBPMHDANECK;
		colorLerp = MNHBOECHFEG;
	}

	public override void Awake()
	{
		base.Awake();
		HKIDNEAKGNO = GetComponent<Renderer>();
		CBNKJGPOLMG = GetComponent<DynamicScale>();
		JFCPJAELJOE = GetComponentInParent<PlayerBase>();
	}

	public void PODPPHEJDBO(int CDPLIMAJBGF)
	{
		CBNKJGPOLMG.frequencyRange = (FrequencyRange)CDPLIMAJBGF;
	}

	public void SetMinSize(Vector3 GNIJKBCHEPG)
	{
		CBNKJGPOLMG.minSize = GNIJKBCHEPG;
	}

	public void KFHBKGHBNEB(int CDPLIMAJBGF)
	{
		CBNKJGPOLMG.frequencyRange = (FrequencyRange)CDPLIMAJBGF;
	}

	public void KOENDMEKKNN(Vector3 LPIMAGMABLC)
	{
		CBNKJGPOLMG.baseScale = LPIMAGMABLC;
	}

	public override void AIFAGDOHAGD()
	{
		base.OGAMGLEAOAF();
		CBNKJGPOLMG.Reset();
		progress = 1121f;
		color1 = new Color(1698f, 744f, 128f);
		color2 = new Color(744f, 1954f, 940f);
		colorLerp = 1197f;
		emission = 37f;
	}

	public void BABLMFPOAJN(Vector3 JJIJODIEBFP)
	{
		CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	public void GFIHBDOJPKB(Color MGHJCGBNEPL, Color NBPMHDANECK, float MNHBOECHFEG)
	{
		color1 = MGHJCGBNEPL;
		color2 = NBPMHDANECK;
		colorLerp = MNHBOECHFEG;
	}

	public void GJGHAKPNOGJ(Vector3 GNIJKBCHEPG)
	{
		CBNKJGPOLMG.minSize = GNIJKBCHEPG;
	}

	public void NKCPOLPIMFI(Color MGHJCGBNEPL, Color NBPMHDANECK, float MNHBOECHFEG)
	{
		color1 = MGHJCGBNEPL;
		color2 = NBPMHDANECK;
		colorLerp = MNHBOECHFEG;
	}

	public void FNNHAAJNAHN(Vector3 GNIJKBCHEPG)
	{
		CBNKJGPOLMG.minSize = GNIJKBCHEPG;
	}

	public void KHIACDAFEOJ(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public void AKGBJFJLELA(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public void KOKIEABANDK(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public void HLHAFCDNMEJ(Color MGHJCGBNEPL, Color NBPMHDANECK, float MNHBOECHFEG)
	{
		color1 = MGHJCGBNEPL;
		color2 = NBPMHDANECK;
		colorLerp = MNHBOECHFEG;
	}

	public void SetDirectionVector(Vector3 LPIMAGMABLC)
	{
		CBNKJGPOLMG.baseScale = LPIMAGMABLC;
	}

	public override void IKMELABKBHO()
	{
		base.AEIJFLJEABG();
		progress = JFCPJAELJOE.GetLifesProgrees();
		HKIDNEAKGNO.material.SetColor("GlassDistortion", Color.Lerp(HKIDNEAKGNO.material.GetColor("_TimeX"), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetColor("_Value3", Color.Lerp(HKIDNEAKGNO.material.GetColor("_Saturation"), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetFloat("Offline", Mathf.Lerp(HKIDNEAKGNO.material.GetFloat("_TimeX"), emission * 1871f, Time.smoothDeltaTime * colorLerp));
	}

	public void IIIJKFBNNEI(Vector3 JJIJODIEBFP)
	{
		CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	public override void MBBHOJMLCBC()
	{
		base.OGAMGLEAOAF();
		CBNKJGPOLMG.DEDANNMJNOC();
		progress = 1824f;
		color1 = new Color(32f, 893f, 134f);
		color2 = new Color(135f, 684f, 1097f);
		colorLerp = 1010f;
		emission = 747f;
	}

	public void LPNMGHEPBKK(Vector3 JJIJODIEBFP)
	{
		CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	public void JBPGEJDFBEI(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public void GDBNLFPGFGH(Vector3 LPIMAGMABLC)
	{
		CBNKJGPOLMG.baseScale = LPIMAGMABLC;
	}

	public override void HIKKPDACJGI()
	{
		base.AEIJFLJEABG();
		progress = JFCPJAELJOE.GetLifesProgrees();
		HKIDNEAKGNO.material.SetColor("BitsData", Color.Lerp(HKIDNEAKGNO.material.GetColor("_ScreenResolution"), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetColor("SetEnvSpriteColor", Color.Lerp(HKIDNEAKGNO.material.GetColor("TotalHitsScoreText"), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetFloat("<color=#", Mathf.Lerp(HKIDNEAKGNO.material.GetFloat("Object ID. Case-Sensitive"), emission * 1514f, Time.smoothDeltaTime * colorLerp));
	}

	public void CKMKADBMLKG(float KEDDLFDAIDE)
	{
		CBNKJGPOLMG.lerpSpeed = KEDDLFDAIDE;
	}

	public void CNGIFFAFGOE(Vector3 GNIJKBCHEPG)
	{
		CBNKJGPOLMG.minSize = GNIJKBCHEPG;
	}

	public void DFMPKPLDLND(float DPNHODJHGJL)
	{
		CBNKJGPOLMG.sensitivity = DPNHODJHGJL;
	}

	public void AGMFLHGKOLI(Color MGHJCGBNEPL, Color NBPMHDANECK, float MNHBOECHFEG)
	{
		color1 = MGHJCGBNEPL;
		color2 = NBPMHDANECK;
		colorLerp = MNHBOECHFEG;
	}

	public void EMGODKHIOAO(float KEDDLFDAIDE)
	{
		CBNKJGPOLMG.lerpSpeed = KEDDLFDAIDE;
	}

	public override void LOMHIIKFFEP()
	{
		base.Awake();
		HKIDNEAKGNO = GetComponent<Renderer>();
		CBNKJGPOLMG = GetComponent<DynamicScale>();
		JFCPJAELJOE = GetComponentInParent<PlayerBase>();
	}

	public void FJILNOMKAAN(Vector3 JJIJODIEBFP)
	{
		CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	public void LAJAHJOMMGA(Vector3 JJIJODIEBFP)
	{
		CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	public void AHMDAMKFGML(Color MGHJCGBNEPL, Color NBPMHDANECK, float MNHBOECHFEG)
	{
		color1 = MGHJCGBNEPL;
		color2 = NBPMHDANECK;
		colorLerp = MNHBOECHFEG;
	}

	public override void EHMMNELHAPJ()
	{
		base.Reset();
		CBNKJGPOLMG.KOBJAEPJJJM();
		progress = 788f;
		color1 = new Color(709f, 743f, 758f);
		color2 = new Color(1497f, 976f, 854f);
		colorLerp = 1401f;
		emission = 1336f;
	}

	public void KCLJACBKFFI(Vector3 JJIJODIEBFP)
	{
		CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	public void GFEDMFLPAHH(Color MGHJCGBNEPL, Color NBPMHDANECK, float MNHBOECHFEG)
	{
		color1 = MGHJCGBNEPL;
		color2 = NBPMHDANECK;
		colorLerp = MNHBOECHFEG;
	}

	public void SetMaxSize(Vector3 JJIJODIEBFP)
	{
		CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	public void HKBEDCMPMLO(Color MGHJCGBNEPL, Color NBPMHDANECK, float MNHBOECHFEG)
	{
		color1 = MGHJCGBNEPL;
		color2 = NBPMHDANECK;
		colorLerp = MNHBOECHFEG;
	}

	public override void Update()
	{
		base.Update();
		progress = JFCPJAELJOE.GetLifesProgrees();
		HKIDNEAKGNO.material.SetColor("_DiffuseColor", Color.Lerp(HKIDNEAKGNO.material.GetColor("_DiffuseColor"), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetColor("_EmissionColor", Color.Lerp(HKIDNEAKGNO.material.GetColor("_EmissionColor"), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetFloat("_EmissionGain", Mathf.Lerp(HKIDNEAKGNO.material.GetFloat("_EmissionGain"), emission * 0.2f, Time.smoothDeltaTime * colorLerp));
	}

	public void CNBDMLPNFJC(Vector3 LPIMAGMABLC)
	{
		CBNKJGPOLMG.baseScale = LPIMAGMABLC;
	}

	public void ANLOKKIFJGC(Vector3 LPIMAGMABLC)
	{
		CBNKJGPOLMG.baseScale = LPIMAGMABLC;
	}

	public void NABBOMFEGAF(int CDPLIMAJBGF)
	{
		CBNKJGPOLMG.frequencyRange = (FrequencyRange)CDPLIMAJBGF;
	}

	public void SetLerpSpeed(float KEDDLFDAIDE)
	{
		CBNKJGPOLMG.lerpSpeed = KEDDLFDAIDE;
	}

	public void NNOEKDEACNP(float DPNHODJHGJL)
	{
		CBNKJGPOLMG.sensitivity = DPNHODJHGJL;
	}

	public override void JBIFKBNPHJE()
	{
		base.BODPLDJLFCF();
		HKIDNEAKGNO = GetComponent<Renderer>();
		CBNKJGPOLMG = GetComponent<DynamicScale>();
		JFCPJAELJOE = GetComponentInParent<PlayerBase>();
	}

	public void OGCEBFAEBGO(Vector3 JJIJODIEBFP)
	{
		CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	public override void OIBMHPIFAKK()
	{
		base.LEAHIBJDMBI();
		progress = JFCPJAELJOE.PNBDCKLMJKA();
		HKIDNEAKGNO.material.SetColor("Warning: No Shape Curve set for CurveWaveform.cs on ", Color.Lerp(HKIDNEAKGNO.material.GetColor("_AxialAberration"), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetColor("[Steamworks.NET] DllCheck Test returned false, One or more of the Steamworks binaries seems to be the wrong version.", Color.Lerp(HKIDNEAKGNO.material.GetColor("Set particles start speed"), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetFloat("PointerEnter ", Mathf.Lerp(HKIDNEAKGNO.material.GetFloat("ResetButton"), emission * 435f, Time.smoothDeltaTime * colorLerp));
	}

	public void DBDKCIDEGLA(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public override void CJEDMGCKHBI()
	{
		base.FMAFBLKAJDF();
		HKIDNEAKGNO = GetComponent<Renderer>();
		CBNKJGPOLMG = GetComponent<DynamicScale>();
		JFCPJAELJOE = GetComponentInParent<PlayerBase>();
	}

	public override void GEPELODHBFN()
	{
		base.POHMFMNEPKK();
		HKIDNEAKGNO = GetComponent<Renderer>();
		CBNKJGPOLMG = GetComponent<DynamicScale>();
		JFCPJAELJOE = GetComponentInParent<PlayerBase>();
	}

	public void FLOJNPNNIPA(Vector3 LPIMAGMABLC)
	{
		CBNKJGPOLMG.baseScale = LPIMAGMABLC;
	}

	public void OIBBHPEIBCN(float KEDDLFDAIDE)
	{
		CBNKJGPOLMG.lerpSpeed = KEDDLFDAIDE;
	}

	public void ACMENOHGOKD(Vector3 LPIMAGMABLC)
	{
		CBNKJGPOLMG.baseScale = LPIMAGMABLC;
	}

	public override void EPJJDKJEDMM()
	{
		base.LEAHIBJDMBI();
		progress = JFCPJAELJOE.PKPBMPFIGBL();
		HKIDNEAKGNO.material.SetColor("Saved Game: ", Color.Lerp(HKIDNEAKGNO.material.GetColor("_TimeX"), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetColor("Failed to InstantiateSceneObject prefab: ", Color.Lerp(HKIDNEAKGNO.material.GetColor(".mp3"), Helpers.ColorGradient(color1, color2, progress), Time.smoothDeltaTime * colorLerp));
		HKIDNEAKGNO.material.SetFloat("_Value4", Mathf.Lerp(HKIDNEAKGNO.material.GetFloat("_Value2"), emission * 1864f, Time.smoothDeltaTime * colorLerp));
	}

	public void BCABFMAINCH(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public void OBELOEDCBFF(Vector3 GNIJKBCHEPG)
	{
		CBNKJGPOLMG.minSize = GNIJKBCHEPG;
	}

	public void SetEmission(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public void DAGEPMALDFC(int CDPLIMAJBGF)
	{
		CBNKJGPOLMG.frequencyRange = (FrequencyRange)CDPLIMAJBGF;
	}

	public void MHLOFLAEADE(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public void OICBJGJMJNB(Vector3 LPIMAGMABLC)
	{
		CBNKJGPOLMG.baseScale = LPIMAGMABLC;
	}

	public void LBEIGHGIMKL(int CDPLIMAJBGF)
	{
		CBNKJGPOLMG.frequencyRange = (FrequencyRange)CDPLIMAJBGF;
	}

	public void AHANBDADILD(float DPNHODJHGJL)
	{
		CBNKJGPOLMG.sensitivity = DPNHODJHGJL;
	}

	public void IOOEGDEGFGN(Color MGHJCGBNEPL, Color NBPMHDANECK, float MNHBOECHFEG)
	{
		color1 = MGHJCGBNEPL;
		color2 = NBPMHDANECK;
		colorLerp = MNHBOECHFEG;
	}

	public void BNCHCHKICDA(Vector3 LPIMAGMABLC)
	{
		CBNKJGPOLMG.baseScale = LPIMAGMABLC;
	}

	public void HAEJHIPADOB(float DPNHODJHGJL)
	{
		emission = DPNHODJHGJL;
	}

	public void BCFJDLOJCAM(Vector3 LPIMAGMABLC)
	{
		CBNKJGPOLMG.baseScale = LPIMAGMABLC;
	}

	public override void MFCCNPEIOGP()
	{
		base.BODPLDJLFCF();
		HKIDNEAKGNO = GetComponent<Renderer>();
		CBNKJGPOLMG = GetComponent<DynamicScale>();
		JFCPJAELJOE = GetComponentInParent<PlayerBase>();
	}

	public override void GEGFJJBCHPE()
	{
		base.FMAFBLKAJDF();
		HKIDNEAKGNO = GetComponent<Renderer>();
		CBNKJGPOLMG = GetComponent<DynamicScale>();
		JFCPJAELJOE = GetComponentInParent<PlayerBase>();
	}

	public void LNJOPHINMHB(int CDPLIMAJBGF)
	{
		CBNKJGPOLMG.frequencyRange = (FrequencyRange)CDPLIMAJBGF;
	}

	public override void MNBMLBLLDGL()
	{
		base.Reset();
		CBNKJGPOLMG.KOBJAEPJJJM();
		progress = 1675f;
		color1 = new Color(1355f, 264f, 437f);
		color2 = new Color(1922f, 967f, 1779f);
		colorLerp = 1705f;
		emission = 907f;
	}

	public void CHOKKIPDAPF(Color MGHJCGBNEPL, Color NBPMHDANECK, float MNHBOECHFEG)
	{
		color1 = MGHJCGBNEPL;
		color2 = NBPMHDANECK;
		colorLerp = MNHBOECHFEG;
	}

	public void CDJIHKHOJIA(int CDPLIMAJBGF)
	{
		CBNKJGPOLMG.frequencyRange = (FrequencyRange)CDPLIMAJBGF;
	}

	public void JDHPAAOGKOC(Vector3 LPIMAGMABLC)
	{
		CBNKJGPOLMG.baseScale = LPIMAGMABLC;
	}

	public void CNFKMAINEEB(Vector3 JJIJODIEBFP)
	{
		CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}
}
