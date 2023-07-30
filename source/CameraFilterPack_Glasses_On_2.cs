// CameraFilterPack_Glasses_On_2
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Glasses/Vampire")]
[ExecuteInEditMode]
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
			HHIFMIPPMPF().SetFloat("_AdaptionSpeed", HBJJOCHGOPH);
			JIBOKBCPDLC().SetFloat("ACCEPT", UseFinalGlassColor);
			NBPKMLMCHFN.SetFloat("BitsData", Fade);
			NBPKMLMCHFN.SetFloat("menutheme.jamaicanorcdub", VisionBlur);
			HHIFMIPPMPF().SetFloat("IncorrectHitsScoreText", GlassDistortion);
			NBPKMLMCHFN.SetFloat(".", GlassAberration);
			NBPKMLMCHFN.SetColor("_ScreenResolution", GlassesColor);
			NBPKMLMCHFN.SetColor("_Value3", GlassesColor2);
			NBPKMLMCHFN.SetColor("Couldn't call DestroyAll() as only the master client is allowed to call this.", GlassColor);
			JIBOKBCPDLC().SetFloat("_Distortion", UseScanLineSize);
			PLBEJJIHFPB().SetFloat("restrictions\n\n#until: ", UseScanLine);
			NBPKMLMCHFN.SetTexture(" By: ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
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
			NBPKMLMCHFN.SetFloat("<color=#{0}>{1}</color>", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Texture2", UseFinalGlassColor);
			HHIFMIPPMPF().SetFloat("menu.selectedlevelid", Fade);
			PLBEJJIHFPB().SetFloat("settings_bindings_controller_type", VisionBlur);
			PLBEJJIHFPB().SetFloat(".ogg", GlassDistortion);
			JIBOKBCPDLC().SetFloat("id", GlassAberration);
			HHIFMIPPMPF().SetColor("FinalScoreSmallText", GlassesColor);
			NBPKMLMCHFN.SetColor("\" error: ", GlassesColor2);
			JIBOKBCPDLC().SetColor("Type of observed is unknown when receiving.", GlassColor);
			PLBEJJIHFPB().SetFloat("TotalHitsScoreText", UseScanLineSize);
			HHIFMIPPMPF().SetFloat("#newhighscore", UseScanLine);
			JIBOKBCPDLC().SetTexture("{0}", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
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
			JIBOKBCPDLC().SetFloat("CameraFilterPack/Drawing_Lines", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_TileTexDebug", UseFinalGlassColor);
			NBPKMLMCHFN.SetFloat("_FixDistance", Fade);
			HHIFMIPPMPF().SetFloat("_Fade", VisionBlur);
			PLBEJJIHFPB().SetFloat("_Value2", GlassDistortion);
			NBPKMLMCHFN.SetFloat("SetPlayerDistance", GlassAberration);
			HHIFMIPPMPF().SetColor("USE_PREDICATION", GlassesColor);
			HHIFMIPPMPF().SetColor("ready", GlassesColor2);
			JIBOKBCPDLC().SetColor("_MainTex2", GlassColor);
			JIBOKBCPDLC().SetFloat("_Vignetting2", UseScanLineSize);
			HHIFMIPPMPF().SetFloat("[Down]", UseScanLine);
			NBPKMLMCHFN.SetTexture("_Level", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			PLBEJJIHFPB().SetFloat("_Intensity", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("CameraFilterPack/Drawing_Paper2", UseFinalGlassColor);
			PLBEJJIHFPB().SetFloat("ViewMenu", Fade);
			HHIFMIPPMPF().SetFloat("#ok", VisionBlur);
			HHIFMIPPMPF().SetFloat("?", GlassDistortion);
			PLBEJJIHFPB().SetFloat("useSrcAlphaAsMask", GlassAberration);
			NBPKMLMCHFN.SetColor(".lastCheckpoint.incorrectScore", GlassesColor);
			HHIFMIPPMPF().SetColor("#close", GlassesColor2);
			JIBOKBCPDLC().SetColor("'{0}'{1}{2}", GlassColor);
			NBPKMLMCHFN.SetFloat("[MenuScene] Error: ", UseScanLineSize);
			HHIFMIPPMPF().SetFloat("_Value4", UseScanLine);
			PLBEJJIHFPB().SetTexture("Mar", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KMCPMOGKDEH()
	{
		FPHEBLMINDA = Resources.Load("1159514800") as Texture2D;
		SCShader = Shader.Find("#done");
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
			NBPKMLMCHFN.SetFloat("_TimeX", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat(".lastCheckpoint.powerupsScore", UseFinalGlassColor);
			JIBOKBCPDLC().SetFloat("#tryagain", Fade);
			HHIFMIPPMPF().SetFloat("[Up-Right-Down-Left]", VisionBlur);
			HHIFMIPPMPF().SetFloat("menu.enableselectormusic", GlassDistortion);
			HHIFMIPPMPF().SetFloat("Tab2Content", GlassAberration);
			NBPKMLMCHFN.SetColor("}", GlassesColor);
			HHIFMIPPMPF().SetColor("[Up]", GlassesColor2);
			PLBEJJIHFPB().SetColor("_Size", GlassColor);
			JIBOKBCPDLC().SetFloat("float,1.5", UseScanLineSize);
			JIBOKBCPDLC().SetFloat("[SERVER] Player ", UseScanLine);
			JIBOKBCPDLC().SetTexture("_Radius", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
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
		FPHEBLMINDA = Resources.Load("_Distortion") as Texture2D;
		SCShader = Shader.Find("<b>#");
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
		FPHEBLMINDA = Resources.Load("_HitPointTexture") as Texture2D;
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
			HHIFMIPPMPF().SetFloat("OpSetPropertiesOfActor not sent. ActorNr must be > 0 and actorProperties != null.", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat(" GO:", UseFinalGlassColor);
			NBPKMLMCHFN.SetFloat("_MainTex2", Fade);
			PLBEJJIHFPB().SetFloat("_TimeX", VisionBlur);
			JIBOKBCPDLC().SetFloat("ConfigVersionSlider", GlassDistortion);
			NBPKMLMCHFN.SetFloat("_Color", GlassAberration);
			JIBOKBCPDLC().SetColor("<b>", GlassesColor);
			PLBEJJIHFPB().SetColor("sfxVolume", GlassesColor2);
			JIBOKBCPDLC().SetColor("_Near", GlassColor);
			JIBOKBCPDLC().SetFloat("_TimeX", UseScanLineSize);
			NBPKMLMCHFN.SetFloat("_ReflectionTexture3", UseScanLine);
			NBPKMLMCHFN.SetTexture("_Offsets", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CCLNNLCOPBL()
	{
		FPHEBLMINDA = Resources.Load("_Value3") as Texture2D;
		SCShader = Shader.Find("_ScreenEdgeFading");
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
			NBPKMLMCHFN.SetFloat("Tab2Content", HBJJOCHGOPH);
			JIBOKBCPDLC().SetFloat("CameraFilterPack/Distortion_Aspiration", UseFinalGlassColor);
			JIBOKBCPDLC().SetFloat("_Value3", Fade);
			HHIFMIPPMPF().SetFloat("[PhotonMessageInfo: Sender='{1}' Senttime={0}]", VisionBlur);
			NBPKMLMCHFN.SetFloat("SetSatelliteTrailMinVertexDistance", GlassDistortion);
			HHIFMIPPMPF().SetFloat("================================", GlassAberration);
			NBPKMLMCHFN.SetColor("[LevelEditorScene] Exported to ", GlassesColor);
			HHIFMIPPMPF().SetColor("\" on viewID ", GlassesColor2);
			PLBEJJIHFPB().SetColor("f", GlassColor);
			NBPKMLMCHFN.SetFloat("Achievement 21 progress reseted", UseScanLineSize);
			PLBEJJIHFPB().SetFloat("Left", UseScanLine);
			PLBEJJIHFPB().SetTexture("SetSatelliteColor", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
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
			PLBEJJIHFPB().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_BaseTex", UseFinalGlassColor);
			PLBEJJIHFPB().SetFloat("[EditorEvent] Exception: ", Fade);
			JIBOKBCPDLC().SetFloat("sfxVolume", VisionBlur);
			JIBOKBCPDLC().SetFloat("Scale environment object by the values", GlassDistortion);
			HHIFMIPPMPF().SetFloat("_ScreenResolution", GlassAberration);
			PLBEJJIHFPB().SetColor(" is set to dontSave = true, continuing loop.", GlassesColor);
			JIBOKBCPDLC().SetColor("skin.hit_normal", GlassesColor2);
			HHIFMIPPMPF().SetColor("shader.invert", GlassColor);
			JIBOKBCPDLC().SetFloat("CameraFilterPack_3D_Myst1", UseScanLineSize);
			PLBEJJIHFPB().SetFloat("_Intensity", UseScanLine);
			NBPKMLMCHFN.SetTexture("id", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
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
