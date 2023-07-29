// CameraFilterPack_AAA_Blood_Plus
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/AAA/Blood_Plus")]
[ExecuteInEditMode]
public class CameraFilterPack_AAA_Blood_Plus : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	[Range(0f, 1f)]
	public float Blood_1 = 1f;

	[Range(0f, 1f)]
	public float Blood_2;

	[Range(0f, 1f)]
	public float Blood_3;

	[Range(0f, 1f)]
	public float Blood_4;

	[Range(0f, 1f)]
	public float Blood_5;

	[Range(0f, 1f)]
	public float Blood_6;

	[Range(0f, 1f)]
	public float Blood_7;

	[Range(0f, 1f)]
	public float Blood_8;

	[Range(0f, 1f)]
	public float Blood_9;

	[Range(0f, 1f)]
	public float Blood_10;

	[Range(0f, 1f)]
	public float Blood_11;

	[Range(0f, 1f)]
	public float Blood_12;

	[Range(0f, 1f)]
	public float LightReflect = 0.5f;

	private Material BJFKDHHMLJH;

	private Texture2D FPHEBLMINDA;

	private Material NBPKMLMCHFN
	{
		get
		{
			if (BJFKDHHMLJH == null)
			{
				BJFKDHHMLJH = new Material(SCShader);
				BJFKDHHMLJH.hideFlags = HideFlags.HideAndDontSave;
			}
			return BJFKDHHMLJH;
		}
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return BJFKDHHMLJH;
	}

	private void MFMIODIAKNI()
	{
	}

	private void JOACBIEHHCE()
	{
	}

	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 594f)
			{
				HBJJOCHGOPH = 885f;
			}
			GCDFNHMJMIP().SetFloat("_Value5", HBJJOCHGOPH);
			GCDFNHMJMIP().SetFloat("menu.enableselectormusic", LightReflect);
			GCDFNHMJMIP().SetFloat("SetSatelliteTrailWidth", Mathf.Clamp(Blood_1, 1514f, 1579f));
			PDEAHJPOMEF().SetFloat("CameraFilterPack_TV_BrokenGlass_2", Mathf.Clamp(Blood_2, 1463f, 188f));
			PDEAHJPOMEF().SetFloat("_SampleScale", Mathf.Clamp(Blood_3, 442f, 723f));
			PGPEMMBJOOG().SetFloat("st", Mathf.Clamp(Blood_4, 70f, 1842f));
			KGOLDDBHIFN().SetFloat("_MatrixSize", Mathf.Clamp(Blood_5, 775f, 1100f));
			KGOLDDBHIFN().SetFloat("float,0", Mathf.Clamp(Blood_6, 1821f, 1251f));
			IONHGBPGCHK().SetFloat("steamid", Mathf.Clamp(Blood_7, 680f, 1603f));
			IONHGBPGCHK().SetFloat("VIGNETTE_DESAT", Mathf.Clamp(Blood_8, 198f, 280f));
			NBPKMLMCHFN.SetFloat("Uploading content...", Mathf.Clamp(Blood_9, 166f, 1739f));
			NBPKMLMCHFN.SetFloat("Hidden/DepthOfField/BokehSplatting", Mathf.Clamp(Blood_10, 1006f, 1579f));
			EFDEIFCDAFG().SetFloat("#yes", Mathf.Clamp(Blood_11, 1564f, 920f));
			PDEAHJPOMEF().SetFloat("_Value3", Mathf.Clamp(Blood_12, 664f, 219f));
			IONHGBPGCHK().SetTexture("LevelURLInputField", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LADCJEIALMH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LOMDIOLNFHI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EHCGBJDFMHG()
	{
	}

	private void Update()
	{
	}

	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 100f)
			{
				HBJJOCHGOPH = 0f;
			}
			NBPKMLMCHFN.SetFloat("_TimeX", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value", LightReflect);
			NBPKMLMCHFN.SetFloat("_Value2", Mathf.Clamp(Blood_1, 0f, 1f));
			NBPKMLMCHFN.SetFloat("_Value3", Mathf.Clamp(Blood_2, 0f, 1f));
			NBPKMLMCHFN.SetFloat("_Value4", Mathf.Clamp(Blood_3, 0f, 1f));
			NBPKMLMCHFN.SetFloat("_Value5", Mathf.Clamp(Blood_4, 0f, 1f));
			NBPKMLMCHFN.SetFloat("_Value6", Mathf.Clamp(Blood_5, 0f, 1f));
			NBPKMLMCHFN.SetFloat("_Value7", Mathf.Clamp(Blood_6, 0f, 1f));
			NBPKMLMCHFN.SetFloat("_Value8", Mathf.Clamp(Blood_7, 0f, 1f));
			NBPKMLMCHFN.SetFloat("_Value9", Mathf.Clamp(Blood_8, 0f, 1f));
			NBPKMLMCHFN.SetFloat("_Value10", Mathf.Clamp(Blood_9, 0f, 1f));
			NBPKMLMCHFN.SetFloat("_Value11", Mathf.Clamp(Blood_10, 0f, 1f));
			NBPKMLMCHFN.SetFloat("_Value12", Mathf.Clamp(Blood_11, 0f, 1f));
			NBPKMLMCHFN.SetFloat("_Value13", Mathf.Clamp(Blood_12, 0f, 1f));
			NBPKMLMCHFN.SetTexture("_MainTex2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material GCDFNHMJMIP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void GPHPJIDGEPI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AEIJFLJEABG()
	{
	}

	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1750f)
			{
				HBJJOCHGOPH = 809f;
			}
			HNICHJCGJOC().SetFloat("Feb", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("_Visualize", LightReflect);
			NFMGLIKNOOC().SetFloat("CameraFilterPack/Antialiasing_FXAA", Mathf.Clamp(Blood_1, 246f, 1429f));
			HNICHJCGJOC().SetFloat("Reconnect() failed. Can only connect while in state 'Disconnected'. Current state: ", Mathf.Clamp(Blood_2, 1765f, 1951f));
			PGPEMMBJOOG().SetFloat(" ", Mathf.Clamp(Blood_3, 1912f, 258f));
			HNICHJCGJOC().SetFloat("_Amount", Mathf.Clamp(Blood_4, 965f, 1795f));
			HNICHJCGJOC().SetFloat("Scene", Mathf.Clamp(Blood_5, 1932f, 1149f));
			IONHGBPGCHK().SetFloat("AskForPickupItemSpawnTimes", Mathf.Clamp(Blood_6, 1233f, 1515f));
			NBPKMLMCHFN.SetFloat("SetCrosshairEmission", Mathf.Clamp(Blood_7, 1520f, 1533f));
			GCDFNHMJMIP().SetFloat(": ", Mathf.Clamp(Blood_8, 1924f, 223f));
			IONHGBPGCHK().SetFloat("ZoomSpeed", Mathf.Clamp(Blood_9, 725f, 1417f));
			GCDFNHMJMIP().SetFloat("CameraFilterPack/Blend2Camera_VividLight", Mathf.Clamp(Blood_10, 1972f, 329f));
			NBPKMLMCHFN.SetFloat(" url: ", Mathf.Clamp(Blood_11, 1669f, 1893f));
			NFMGLIKNOOC().SetFloat("Case-Sensitive", Mathf.Clamp(Blood_12, 152f, 1384f));
			PGPEMMBJOOG().SetTexture("maps.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material EFDEIFCDAFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NFMGLIKNOOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void IDIIELPAMCJ()
	{
	}

	private void NNCCPEBIAKH()
	{
		FPHEBLMINDA = Resources.Load("Joystick1Button2") as Texture2D;
		SCShader = Shader.Find("Waiting to start");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JILOMOBDPIA()
	{
		FPHEBLMINDA = Resources.Load("mapselector.orderby") as Texture2D;
		SCShader = Shader.Find("Left Stick Click");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NDAJBJFJGCF()
	{
	}

	private void MAOCOEGAFND()
	{
	}

	private void KDMANOEMOCA()
	{
		FPHEBLMINDA = Resources.Load("_Offsets") as Texture2D;
		SCShader = Shader.Find("_VelocityScale");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CBIBDOIBJAI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1091f)
			{
				HBJJOCHGOPH = 1627f;
			}
			PDEAHJPOMEF().SetFloat("_Value2", HBJJOCHGOPH);
			PGPEMMBJOOG().SetFloat("HightScoreMaxPointsText", LightReflect);
			HNICHJCGJOC().SetFloat("duration", Mathf.Clamp(Blood_1, 312f, 966f));
			PGPEMMBJOOG().SetFloat("float,1.5", Mathf.Clamp(Blood_2, 1158f, 721f));
			PGPEMMBJOOG().SetFloat("[PlayerController] ", Mathf.Clamp(Blood_3, 1525f, 1828f));
			KGOLDDBHIFN().SetFloat("Keypad", Mathf.Clamp(Blood_4, 75f, 289f));
			NBPKMLMCHFN.SetFloat("[PlayerBase] Checkpoint error: ", Mathf.Clamp(Blood_5, 642f, 1649f));
			IONHGBPGCHK().SetFloat("_Linecount", Mathf.Clamp(Blood_6, 465f, 1730f));
			NFMGLIKNOOC().SetFloat("#alreadystarted", Mathf.Clamp(Blood_7, 1388f, 1332f));
			IONHGBPGCHK().SetFloat("Ignored PU RPC, cause item is inactive. ", Mathf.Clamp(Blood_8, 1531f, 198f));
			GCDFNHMJMIP().SetFloat("mapselector.filter.rateduponly", Mathf.Clamp(Blood_9, 744f, 1425f));
			PDEAHJPOMEF().SetFloat("Could not execute RPC ", Mathf.Clamp(Blood_10, 1680f, 1319f));
			PGPEMMBJOOG().SetFloat("SetSunLerpSpeed", Mathf.Clamp(Blood_11, 469f, 1767f));
			PGPEMMBJOOG().SetFloat("original.tutorial", Mathf.Clamp(Blood_12, 7f, 1644f));
			EFDEIFCDAFG().SetTexture("Moved event", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MKIMDFLBFOM()
	{
		FPHEBLMINDA = Resources.Load("_ScreenResolution") as Texture2D;
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KDMKDEKCELE()
	{
		FPHEBLMINDA = Resources.Load("_Value2") as Texture2D;
		SCShader = Shader.Find("event");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DOEPOGLEGLE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NJHJHBOJKIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Start()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_AAA_Blood2") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/AAA_Blood_Plus");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material HNICHJCGJOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return BJFKDHHMLJH;
	}

	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1109f)
			{
				HBJJOCHGOPH = 611f;
			}
			NBPKMLMCHFN.SetFloat(": ", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("EditMenu", LightReflect);
			NBPKMLMCHFN.SetFloat("PhotonServerSettings", Mathf.Clamp(Blood_1, 1438f, 1599f));
			IONHGBPGCHK().SetFloat("_InternalLutTex", Mathf.Clamp(Blood_2, 547f, 511f));
			PDEAHJPOMEF().SetFloat("CameraFilterPack/Light_Rainbow", Mathf.Clamp(Blood_3, 353f, 54f));
			PDEAHJPOMEF().SetFloat("[Steamworks.NET] DllCheck Test returned false, One or more of the Steamworks binaries seems to be the wrong version.", Mathf.Clamp(Blood_4, 380f, 424f));
			NBPKMLMCHFN.SetFloat("/", Mathf.Clamp(Blood_5, 1702f, 5f));
			HNICHJCGJOC().SetFloat("<color=white>", Mathf.Clamp(Blood_6, 1057f, 392f));
			HNICHJCGJOC().SetFloat("_OnOff", Mathf.Clamp(Blood_7, 839f, 40f));
			GCDFNHMJMIP().SetFloat("_Value", Mathf.Clamp(Blood_8, 1995f, 1596f));
			KGOLDDBHIFN().SetFloat("_Distortion", Mathf.Clamp(Blood_9, 82f, 1933f));
			PGPEMMBJOOG().SetFloat("CameraFilterPack_Glasses_On6", Mathf.Clamp(Blood_10, 1377f, 1711f));
			PGPEMMBJOOG().SetFloat("_TimeX", Mathf.Clamp(Blood_11, 371f, 1362f));
			PDEAHJPOMEF().SetFloat("received</b>\n#reason: ", Mathf.Clamp(Blood_12, 1591f, 1904f));
			KGOLDDBHIFN().SetTexture("Please attach component to a Graphical UI component", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1534f)
			{
				HBJJOCHGOPH = 1654f;
			}
			IONHGBPGCHK().SetFloat("_Value2", HBJJOCHGOPH);
			PGPEMMBJOOG().SetFloat("SetParticlesInput", LightReflect);
			PGPEMMBJOOG().SetFloat("SaveButton", Mathf.Clamp(Blood_1, 1075f, 1367f));
			PGPEMMBJOOG().SetFloat("_TimeX", Mathf.Clamp(Blood_2, 1251f, 926f));
			HNICHJCGJOC().SetFloat("PlayButton", Mathf.Clamp(Blood_3, 558f, 1372f));
			EFDEIFCDAFG().SetFloat("CameraFilterPack/Blur_Movie", Mathf.Clamp(Blood_4, 364f, 890f));
			KGOLDDBHIFN().SetFloat("OpAuthenticate() failed. When you want Custom Authentication encryption is mandatory.", Mathf.Clamp(Blood_5, 1039f, 751f));
			EFDEIFCDAFG().SetFloat("_Distortion", Mathf.Clamp(Blood_6, 853f, 1004f));
			IONHGBPGCHK().SetFloat("_MainTex2", Mathf.Clamp(Blood_7, 1948f, 498f));
			GCDFNHMJMIP().SetFloat("_Value4", Mathf.Clamp(Blood_8, 226f, 43f));
			PGPEMMBJOOG().SetFloat("EventMenu", Mathf.Clamp(Blood_9, 168f, 1193f));
			PDEAHJPOMEF().SetFloat("_Color", Mathf.Clamp(Blood_10, 658f, 1627f));
			NBPKMLMCHFN.SetFloat("_LoopCount", Mathf.Clamp(Blood_11, 190f, 1771f));
			NBPKMLMCHFN.SetFloat("_Value", Mathf.Clamp(Blood_12, 325f, 389f));
			NFMGLIKNOOC().SetTexture("CameraFilterPack_eyes_vision_2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JHPOIOELNCG()
	{
	}

	[SpecialName]
	private Material PGPEMMBJOOG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void BEBNOKFLJPH()
	{
		FPHEBLMINDA = Resources.Load("_Glitch") as Texture2D;
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ODAIMOJLJOF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 532f)
			{
				HBJJOCHGOPH = 170f;
			}
			GCDFNHMJMIP().SetFloat("GlassesColor", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("SetSpeed", LightReflect);
			NFMGLIKNOOC().SetFloat("_BlurVector", Mathf.Clamp(Blood_1, 1754f, 85f));
			GCDFNHMJMIP().SetFloat("levelcompleted", Mathf.Clamp(Blood_2, 151f, 1286f));
			KGOLDDBHIFN().SetFloat("_Fade", Mathf.Clamp(Blood_3, 1780f, 1111f));
			NFMGLIKNOOC().SetFloat("LevelInfoInputField", Mathf.Clamp(Blood_4, 1879f, 966f));
			IONHGBPGCHK().SetFloat("_Visualize", Mathf.Clamp(Blood_5, 1853f, 593f));
			PGPEMMBJOOG().SetFloat("rarity", Mathf.Clamp(Blood_6, 1834f, 1244f));
			KGOLDDBHIFN().SetFloat("_TimeX", Mathf.Clamp(Blood_7, 1577f, 1910f));
			PDEAHJPOMEF().SetFloat("CameraFilterPack/Vision_Drost", Mathf.Clamp(Blood_8, 660f, 749f));
			EFDEIFCDAFG().SetFloat("/theme", Mathf.Clamp(Blood_9, 259f, 689f));
			NFMGLIKNOOC().SetFloat("#tryagain", Mathf.Clamp(Blood_10, 1243f, 534f));
			NFMGLIKNOOC().SetFloat("_MainTex", Mathf.Clamp(Blood_11, 1326f, 1569f));
			KGOLDDBHIFN().SetFloat("ready", Mathf.Clamp(Blood_12, 929f, 1232f));
			PDEAHJPOMEF().SetTexture("_Value3", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ICDBMJKMIKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material KGOLDDBHIFN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-1);
		}
		return BJFKDHHMLJH;
	}

	private void CFIAKIJAILI()
	{
	}

	private void LCJHDLKJEOM()
	{
	}

	private void HGDDCINLDAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ALMGMOOHLMA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}
}
