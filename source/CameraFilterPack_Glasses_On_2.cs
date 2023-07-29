// CameraFilterPack_Glasses_On_2
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Glasses/Vampire")]
public class CameraFilterPack_Glasses_On_2 : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	[Range(0f, 1f)]
	public float Fade = 0.2f;

	[Range(0f, 0.1f)]
	public float VisionBlur = 0.005f;

	public Color GlassesColor = new Color(0f, 0f, 0f, 1f);

	public Color GlassesColor2 = new Color(0.25f, 0.25f, 0.25f, 0.25f);

	[Range(0f, 1f)]
	public float GlassDistortion = 0.6f;

	[Range(0f, 1f)]
	public float GlassAberration = 0.5f;

	[Range(0f, 1f)]
	public float UseFinalGlassColor = 1f;

	[Range(0f, 1f)]
	public float UseScanLine;

	[Range(1f, 512f)]
	public float UseScanLineSize = 358f;

	public Color GlassColor = new Color(1f, 0f, 0f, 1f);

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

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BNEJMABFKJE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Start()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_Glasses_On3") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Glasses_OnX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1959f)
			{
				HBJJOCHGOPH = 554f;
			}
			NBPKMLMCHFN.SetFloat("_SmallTex", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("NO", UseFinalGlassColor);
			JIBOKBCPDLC().SetFloat("BitsData", Fade);
			NBPKMLMCHFN.SetFloat("menutheme.jamaicanorcdub", VisionBlur);
			HHIFMIPPMPF().SetFloat("ComboScoreText", GlassDistortion);
			PLBEJJIHFPB().SetFloat(". The group number should be at least 1.", GlassAberration);
			HHIFMIPPMPF().SetColor("_TimeX", GlassesColor);
			JIBOKBCPDLC().SetColor("Fade", GlassesColor2);
			HHIFMIPPMPF().SetColor("RPCs can only be sent in rooms. Call of \"", GlassColor);
			HHIFMIPPMPF().SetFloat("_TimeX", UseScanLineSize);
			JIBOKBCPDLC().SetFloat("restrictions\n\n#until: ", UseScanLine);
			PLBEJJIHFPB().SetTexture(" but this PhotonView does not exist! Was remote PV.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material JIBOKBCPDLC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)73;
		}
		return BJFKDHHMLJH;
	}

	private void OCMKCBBCEFG()
	{
	}

	private void AGMJDGHLBMN()
	{
	}

	[SpecialName]
	private Material PLBEJJIHFPB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1339f)
			{
				HBJJOCHGOPH = 82f;
			}
			JIBOKBCPDLC().SetFloat("X2", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("Texture2", UseFinalGlassColor);
			PLBEJJIHFPB().SetFloat("menu.selectedlevelid", Fade);
			NBPKMLMCHFN.SetFloat("settings_bindings_", VisionBlur);
			HHIFMIPPMPF().SetFloat(".wav", GlassDistortion);
			PLBEJJIHFPB().SetFloat("id", GlassAberration);
			NBPKMLMCHFN.SetColor("FinalScoreSmallText", GlassesColor);
			NBPKMLMCHFN.SetColor("CompletedLevel", GlassesColor2);
			JIBOKBCPDLC().SetColor(") of this PhotonView does not implement OnPhotonSerializeView()!", GlassColor);
			NBPKMLMCHFN.SetFloat("PerfectHitsScoreText", UseScanLineSize);
			HHIFMIPPMPF().SetFloat("#newhighscore", UseScanLine);
			NBPKMLMCHFN.SetTexture("{0}", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HLDFOJMHKNL()
	{
	}

	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1895f)
			{
				HBJJOCHGOPH = 1419f;
			}
			HHIFMIPPMPF().SetFloat("_TimeX", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_ToPrevViewProjCombined", UseFinalGlassColor);
			JIBOKBCPDLC().SetFloat("_DistortionLevel", Fade);
			JIBOKBCPDLC().SetFloat("_ColoredChange", VisionBlur);
			PLBEJJIHFPB().SetFloat("_Value4", GlassDistortion);
			PLBEJJIHFPB().SetFloat("ClearEnvironment", GlassAberration);
			PLBEJJIHFPB().SetColor("USE_DIAG_SEARCH", GlassesColor);
			NBPKMLMCHFN.SetColor("ready", GlassesColor2);
			PLBEJJIHFPB().SetColor("_MainTex2", GlassColor);
			NBPKMLMCHFN.SetFloat("_VignettingColor", UseScanLineSize);
			PLBEJJIHFPB().SetFloat("/", UseScanLine);
			JIBOKBCPDLC().SetTexture("_Level", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1376f)
			{
				HBJJOCHGOPH = 15f;
			}
			PLBEJJIHFPB().SetFloat("_Extra", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("_TimeX", UseFinalGlassColor);
			NBPKMLMCHFN.SetFloat("EditMenu", Fade);
			PLBEJJIHFPB().SetFloat("#ok", VisionBlur);
			PLBEJJIHFPB().SetFloat("?", GlassDistortion);
			NBPKMLMCHFN.SetFloat("vignetteIntensity", GlassAberration);
			HHIFMIPPMPF().SetColor(".lastCheckpoint.powerupsScore", GlassesColor);
			HHIFMIPPMPF().SetColor("bad", GlassesColor2);
			HHIFMIPPMPF().SetColor(" ", GlassColor);
			NBPKMLMCHFN.SetFloat("[MenuScene] Error: ", UseScanLineSize);
			JIBOKBCPDLC().SetFloat("_Value4", UseScanLine);
			PLBEJJIHFPB().SetTexture("Jun", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KMCPMOGKDEH()
	{
		FPHEBLMINDA = Resources.Load("achievements.21.completed.workshop.") as Texture2D;
		SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 493f)
			{
				HBJJOCHGOPH = 1472f;
			}
			HHIFMIPPMPF().SetFloat("_TimeX", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat(".lastCheckpoint.incorrectScore", UseFinalGlassColor);
			PLBEJJIHFPB().SetFloat("error", Fade);
			HHIFMIPPMPF().SetFloat("[Up-Right-Down-Left]", VisionBlur);
			PLBEJJIHFPB().SetFloat("menu.enableselectormusic", GlassDistortion);
			JIBOKBCPDLC().SetFloat("Tab2Content", GlassAberration);
			HHIFMIPPMPF().SetColor("Aimer Input Module is incompatible with the StandAloneInputSystem, please remove it from the Event System in this scene or disable it when this module is in use", GlassesColor);
			PLBEJJIHFPB().SetColor("uploads/Intralism/mods_terms.pdf", GlassesColor2);
			NBPKMLMCHFN.SetColor("_Dist", GlassColor);
			JIBOKBCPDLC().SetFloat("float,1.5", UseScanLineSize);
			JIBOKBCPDLC().SetFloat("[SERVER] Player ", UseScanLine);
			HHIFMIPPMPF().SetTexture("_Quality", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LLJLDLLNFBH()
	{
	}

	private void CIPKEPDELJB()
	{
		FPHEBLMINDA = Resources.Load("_TimeX") as Texture2D;
		SCShader = Shader.Find("received</b>\n#reason: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FABMDEHEDNO()
	{
	}

	private void Update()
	{
	}

	private void GAOOPEEBGJA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OFPPIKHNJOD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AIJGAJIOJDJ()
	{
	}

	private void LCJHDLKJEOM()
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
			NBPKMLMCHFN.SetFloat("UseFinalGlassColor", UseFinalGlassColor);
			NBPKMLMCHFN.SetFloat("Fade", Fade);
			NBPKMLMCHFN.SetFloat("VisionBlur", VisionBlur);
			NBPKMLMCHFN.SetFloat("GlassDistortion", GlassDistortion);
			NBPKMLMCHFN.SetFloat("GlassAberration", GlassAberration);
			NBPKMLMCHFN.SetColor("GlassesColor", GlassesColor);
			NBPKMLMCHFN.SetColor("GlassesColor2", GlassesColor2);
			NBPKMLMCHFN.SetColor("GlassColor", GlassColor);
			NBPKMLMCHFN.SetFloat("UseScanLineSize", UseScanLineSize);
			NBPKMLMCHFN.SetFloat("UseScanLine", UseScanLine);
			NBPKMLMCHFN.SetTexture("_MainTex2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JHJGJJKELJM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HLIAEEMGBHN()
	{
		FPHEBLMINDA = Resources.Load("_ReflectionTexture1") as Texture2D;
		SCShader = Shader.Find("Bad parameters for delete! Use <key>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 147f)
			{
				HBJJOCHGOPH = 1550f;
			}
			HHIFMIPPMPF().SetFloat("OpAuthenticate()", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("\" to target: ", UseFinalGlassColor);
			JIBOKBCPDLC().SetFloat("_MainTex2", Fade);
			HHIFMIPPMPF().SetFloat("_Value2", VisionBlur);
			PLBEJJIHFPB().SetFloat("ConfigVersionSlider", GlassDistortion);
			JIBOKBCPDLC().SetFloat("ShowSprite", GlassAberration);
			HHIFMIPPMPF().SetColor("#", GlassesColor);
			PLBEJJIHFPB().SetColor("menuVolume", GlassesColor2);
			HHIFMIPPMPF().SetColor("_Near", GlassColor);
			NBPKMLMCHFN.SetFloat("_CenterX", UseScanLineSize);
			PLBEJJIHFPB().SetFloat("_BlurTexture", UseScanLine);
			PLBEJJIHFPB().SetTexture("pointBuffer", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CCLNNLCOPBL()
	{
		FPHEBLMINDA = Resources.Load("_Value4") as Texture2D;
		SCShader = Shader.Find("_MaxRayTraceDistance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1548f)
			{
				HBJJOCHGOPH = 538f;
			}
			NBPKMLMCHFN.SetFloat("HiddenToggle", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("_TimeX", UseFinalGlassColor);
			JIBOKBCPDLC().SetFloat("_Value4", Fade);
			JIBOKBCPDLC().SetFloat("Error: you cannot write/send to this stream that you are reading!", VisionBlur);
			NBPKMLMCHFN.SetFloat("Set Satellite Trail MinVertexDistance", GlassDistortion);
			JIBOKBCPDLC().SetFloat("X2", GlassAberration);
			HHIFMIPPMPF().SetColor("Done!", GlassesColor);
			NBPKMLMCHFN.SetColor(". The RPC has been ignored.", GlassesColor2);
			PLBEJJIHFPB().SetColor("Please specify either t or f.", GlassColor);
			PLBEJJIHFPB().SetFloat("plogs", UseScanLineSize);
			JIBOKBCPDLC().SetFloat("Right", UseScanLine);
			NBPKMLMCHFN.SetTexture("SetSatelliteInput", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DPFOEBCADNP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HHIFMIPPMPF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-109);
		}
		return BJFKDHHMLJH;
	}

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1608f)
			{
				HBJJOCHGOPH = 384f;
			}
			NBPKMLMCHFN.SetFloat("_ScreenResolution", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("Missing shader for image effect {0}", UseFinalGlassColor);
			PLBEJJIHFPB().SetFloat("_Color", Fade);
			JIBOKBCPDLC().SetFloat("musicVolume", VisionBlur);
			HHIFMIPPMPF().SetFloat("SetParent", GlassDistortion);
			JIBOKBCPDLC().SetFloat("CameraFilterPack/FX_Glitch3", GlassAberration);
			NBPKMLMCHFN.SetColor("QuickSave", GlassesColor);
			PLBEJJIHFPB().SetColor("skin.hit_normal", GlassesColor2);
			HHIFMIPPMPF().SetColor("shader.invert", GlassColor);
			JIBOKBCPDLC().SetFloat("CameraFilterPack_3D_Myst1", UseScanLineSize);
			PLBEJJIHFPB().SetFloat("The shader ", UseScanLine);
			HHIFMIPPMPF().SetTexture("Object ID. Case-Sensitive", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CFIAKIJAILI()
	{
	}
}
