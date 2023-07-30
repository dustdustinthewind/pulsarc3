// CameraFilterPack_AAA_Blood_Plus
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/AAA/Blood_Plus")]
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
			GCDFNHMJMIP().SetFloat("_Value4", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("AudioSampler", LightReflect);
			PDEAHJPOMEF().SetFloat("SetSatelliteTrailWidth", Mathf.Clamp(Blood_1, 1514f, 1579f));
			KGOLDDBHIFN().SetFloat("_Value5", Mathf.Clamp(Blood_2, 1463f, 188f));
			NFMGLIKNOOC().SetFloat("_Curve", Mathf.Clamp(Blood_3, 442f, 723f));
			GCDFNHMJMIP().SetFloat("StartTime already set: ", Mathf.Clamp(Blood_4, 70f, 1842f));
			GCDFNHMJMIP().SetFloat("_MatrixSize", Mathf.Clamp(Blood_5, 775f, 1100f));
			NFMGLIKNOOC().SetFloat("y", Mathf.Clamp(Blood_6, 1821f, 1251f));
			GCDFNHMJMIP().SetFloat("Use ticket: ", Mathf.Clamp(Blood_7, 680f, 1603f));
			EFDEIFCDAFG().SetFloat("DISTORT", Mathf.Clamp(Blood_8, 198f, 280f));
			GCDFNHMJMIP().SetFloat("Preparing content...", Mathf.Clamp(Blood_9, 166f, 1739f));
			EFDEIFCDAFG().SetFloat("Hidden/DepthOfField/DepthOfField", Mathf.Clamp(Blood_10, 1006f, 1579f));
			PGPEMMBJOOG().SetFloat("#close", Mathf.Clamp(Blood_11, 1564f, 920f));
			PDEAHJPOMEF().SetFloat("_Value3", Mathf.Clamp(Blood_12, 664f, 219f));
			HNICHJCGJOC().SetTexture("ConfigVersionSlider", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			NBPKMLMCHFN.SetFloat("Year_", HBJJOCHGOPH);
			PGPEMMBJOOG().SetFloat("_Value5", LightReflect);
			PGPEMMBJOOG().SetFloat("CameraFilterPack/Antialiasing_FXAA", Mathf.Clamp(Blood_1, 246f, 1429f));
			GCDFNHMJMIP().SetFloat("ConnectToMaster() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", Mathf.Clamp(Blood_2, 1765f, 1951f));
			EFDEIFCDAFG().SetFloat("MapperNameText", Mathf.Clamp(Blood_3, 1912f, 258f));
			GCDFNHMJMIP().SetFloat("_ScreenResolution", Mathf.Clamp(Blood_4, 965f, 1795f));
			GCDFNHMJMIP().SetFloat("SfxVolumeSlider", Mathf.Clamp(Blood_5, 1932f, 1149f));
			HNICHJCGJOC().SetFloat("RespawnAfter", Mathf.Clamp(Blood_6, 1233f, 1515f));
			GCDFNHMJMIP().SetFloat("SetCrosshairEmission", Mathf.Clamp(Blood_7, 1520f, 1533f));
			HNICHJCGJOC().SetFloat("[PlayerController] ", Mathf.Clamp(Blood_8, 1924f, 223f));
			EFDEIFCDAFG().SetFloat("ZoomFade", Mathf.Clamp(Blood_9, 725f, 1417f));
			HNICHJCGJOC().SetFloat("CameraFilterPack/Blend2Camera_VividLight", Mathf.Clamp(Blood_10, 1972f, 329f));
			IONHGBPGCHK().SetFloat("settings.customdataskin", Mathf.Clamp(Blood_11, 1669f, 1893f));
			PGPEMMBJOOG().SetFloat("id", Mathf.Clamp(Blood_12, 152f, 1384f));
			IONHGBPGCHK().SetTexture("maps.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
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
		FPHEBLMINDA = Resources.Load("Joystick1Button1") as Texture2D;
		SCShader = Shader.Find("In Network lobby");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JILOMOBDPIA()
	{
		FPHEBLMINDA = Resources.Load("mapselector.filter.favoriteonly") as Texture2D;
		SCShader = Shader.Find("Options");
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
		SCShader = Shader.Find("Hidden/Image Effects/Cinematic/MotionBlur/Reconstruction");
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
			IONHGBPGCHK().SetFloat("_Value2", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("HightScoreMaxPointsText", LightReflect);
			NFMGLIKNOOC().SetFloat("duration", Mathf.Clamp(Blood_1, 312f, 966f));
			NFMGLIKNOOC().SetFloat("float,1.5", Mathf.Clamp(Blood_2, 1158f, 721f));
			EFDEIFCDAFG().SetFloat(" not exist", Mathf.Clamp(Blood_3, 1525f, 1828f));
			NFMGLIKNOOC().SetFloat("Alpha", Mathf.Clamp(Blood_4, 75f, 289f));
			NBPKMLMCHFN.SetFloat("[PlayerBase] SetSpeed error: ", Mathf.Clamp(Blood_5, 642f, 1649f));
			GCDFNHMJMIP().SetFloat("_Vignette", Mathf.Clamp(Blood_6, 465f, 1730f));
			NBPKMLMCHFN.SetFloat("#alreadystarted", Mathf.Clamp(Blood_7, 1388f, 1332f));
			EFDEIFCDAFG().SetFloat("PunPickup", Mathf.Clamp(Blood_8, 1531f, 198f));
			EFDEIFCDAFG().SetFloat("mapselector.filter.favoriteonly", Mathf.Clamp(Blood_9, 744f, 1425f));
			PDEAHJPOMEF().SetFloat("Error; Only the MasterClient can call RemoveRPCs for other players.", Mathf.Clamp(Blood_10, 1680f, 1319f));
			NFMGLIKNOOC().SetFloat("SetSunEmission", Mathf.Clamp(Blood_11, 469f, 1767f));
			PGPEMMBJOOG().SetFloat("OnMastedChangeScene", Mathf.Clamp(Blood_12, 7f, 1644f));
			KGOLDDBHIFN().SetTexture("[Right]", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MKIMDFLBFOM()
	{
		FPHEBLMINDA = Resources.Load("_ScreenResolution") as Texture2D;
		SCShader = Shader.Find("Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KDMKDEKCELE()
	{
		FPHEBLMINDA = Resources.Load("_Value2") as Texture2D;
		SCShader = Shader.Find("checkpoint");
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
			NFMGLIKNOOC().SetFloat(" not exist", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("EditMenu", LightReflect);
			EFDEIFCDAFG().SetFloat("Lag ", Mathf.Clamp(Blood_1, 1438f, 1599f));
			EFDEIFCDAFG().SetFloat("ENABLE_COLOR_GRADING", Mathf.Clamp(Blood_2, 547f, 511f));
			IONHGBPGCHK().SetFloat("_ScreenResolution", Mathf.Clamp(Blood_3, 353f, 54f));
			HNICHJCGJOC().SetFloat("Tried to Initialize the SteamAPI twice in one session!", Mathf.Clamp(Blood_4, 380f, 424f));
			PGPEMMBJOOG().SetFloat("[TextSaver] Text saved to ", Mathf.Clamp(Blood_5, 1702f, 5f));
			NFMGLIKNOOC().SetFloat("<color=white>PhotonView Group: ", Mathf.Clamp(Blood_6, 1057f, 392f));
			PDEAHJPOMEF().SetFloat("_TimeX", Mathf.Clamp(Blood_7, 839f, 40f));
			PDEAHJPOMEF().SetFloat("_TimeX", Mathf.Clamp(Blood_8, 1995f, 1596f));
			NFMGLIKNOOC().SetFloat("_Vignette_Alpha", Mathf.Clamp(Blood_9, 82f, 1933f));
			PDEAHJPOMEF().SetFloat("_MainTex2", Mathf.Clamp(Blood_10, 1377f, 1711f));
			NFMGLIKNOOC().SetFloat("_TimeX", Mathf.Clamp(Blood_11, 371f, 1362f));
			EFDEIFCDAFG().SetFloat("received</b>\n#reason: ", Mathf.Clamp(Blood_12, 1591f, 1904f));
			IONHGBPGCHK().SetTexture("Default UI Material", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			PGPEMMBJOOG().SetFloat("_Value", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("Set particles count per one beat", LightReflect);
			NBPKMLMCHFN.SetFloat("SaveButton", Mathf.Clamp(Blood_1, 1075f, 1367f));
			PDEAHJPOMEF().SetFloat("CameraFilterPack/Noise_TV", Mathf.Clamp(Blood_2, 1251f, 926f));
			NBPKMLMCHFN.SetFloat("PlayButton", Mathf.Clamp(Blood_3, 558f, 1372f));
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Blur_Movie", Mathf.Clamp(Blood_4, 364f, 890f));
			IONHGBPGCHK().SetFloat("OpSetPropertiesOfRoom()", Mathf.Clamp(Blood_5, 1039f, 751f));
			IONHGBPGCHK().SetFloat("_Value2", Mathf.Clamp(Blood_6, 853f, 1004f));
			GCDFNHMJMIP().SetFloat("_MainTex2", Mathf.Clamp(Blood_7, 1948f, 498f));
			NFMGLIKNOOC().SetFloat("_Value4", Mathf.Clamp(Blood_8, 226f, 43f));
			KGOLDDBHIFN().SetFloat("EventMenu", Mathf.Clamp(Blood_9, 168f, 1193f));
			PGPEMMBJOOG().SetFloat("LevelEditor/icons", Mathf.Clamp(Blood_10, 658f, 1627f));
			PDEAHJPOMEF().SetFloat("_TileMaxOffs", Mathf.Clamp(Blood_11, 190f, 1771f));
			HNICHJCGJOC().SetFloat("_Value", Mathf.Clamp(Blood_12, 325f, 389f));
			IONHGBPGCHK().SetTexture("_MainTex2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
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
		FPHEBLMINDA = Resources.Load("_TimeX") as Texture2D;
		SCShader = Shader.Find("_Value3");
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
			HNICHJCGJOC().SetFloat("GlassAberration", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("SetSpeed", LightReflect);
			PGPEMMBJOOG().SetFloat("_BlurVector", Mathf.Clamp(Blood_1, 1754f, 85f));
			NBPKMLMCHFN.SetFloat("achievements.26.progress", Mathf.Clamp(Blood_2, 151f, 1286f));
			EFDEIFCDAFG().SetFloat("_TimeX", Mathf.Clamp(Blood_3, 1780f, 1111f));
			PDEAHJPOMEF().SetFloat("LevelInfoInputField", Mathf.Clamp(Blood_4, 1879f, 966f));
			IONHGBPGCHK().SetFloat("_Visualize", Mathf.Clamp(Blood_5, 1853f, 593f));
			HNICHJCGJOC().SetFloat("RarityImage", Mathf.Clamp(Blood_6, 1834f, 1244f));
			GCDFNHMJMIP().SetFloat("CameraFilterPack/Vision_Psycho", Mathf.Clamp(Blood_7, 1577f, 1910f));
			NFMGLIKNOOC().SetFloat("_ScreenResolution", Mathf.Clamp(Blood_8, 660f, 749f));
			PDEAHJPOMEF().SetFloat("_EmissionGain", Mathf.Clamp(Blood_9, 259f, 689f));
			KGOLDDBHIFN().SetFloat("#scoresubmitionfailed: ", Mathf.Clamp(Blood_10, 1243f, 534f));
			HNICHJCGJOC().SetFloat("_Offsets", Mathf.Clamp(Blood_11, 1326f, 1569f));
			IONHGBPGCHK().SetFloat("ready", Mathf.Clamp(Blood_12, 929f, 1232f));
			HNICHJCGJOC().SetTexture("_Value2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
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
