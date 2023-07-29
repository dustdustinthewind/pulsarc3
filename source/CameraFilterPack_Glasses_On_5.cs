// CameraFilterPack_Glasses_On_5
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Glasses/Futuristic Montain")]
public class CameraFilterPack_Glasses_On_5 : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	[Range(0f, 1f)]
	public float Fade = 0.2f;

	[Range(0f, 0.1f)]
	public float VisionBlur = 0.005f;

	public Color GlassesColor = new Color(0.1f, 0.1f, 0.1f, 1f);

	public Color GlassesColor2 = new Color(0.45f, 0.45f, 0.45f, 0.25f);

	[Range(0f, 1f)]
	public float GlassDistortion = 0.6f;

	[Range(0f, 1f)]
	public float GlassAberration = 0.3f;

	[Range(0f, 1f)]
	public float UseFinalGlassColor;

	[Range(0f, 1f)]
	public float UseScanLine = 0.4f;

	[Range(1f, 512f)]
	public float UseScanLineSize = 358f;

	public Color GlassColor = new Color(0.1f, 0.3f, 1f, 1f);

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

	private void BEBNOKFLJPH()
	{
		FPHEBLMINDA = Resources.Load("/") as Texture2D;
		SCShader = Shader.Find("Editor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JOACBIEHHCE()
	{
	}

	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 867f)
			{
				HBJJOCHGOPH = 531f;
			}
			NBPKMLMCHFN.SetFloat(".lastCheckpoint.lives", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat(" not exist", UseFinalGlassColor);
			NBPKMLMCHFN.SetFloat("offsets", Fade);
			HNICHJCGJOC().SetFloat("-", VisionBlur);
			HHIFMIPPMPF().SetFloat("mapselector.filter.favoriteonly", GlassDistortion);
			KGOLDDBHIFN().SetFloat("#savemapchanges?", GlassAberration);
			HFBJAOFLCJI().SetColor("scn", GlassesColor);
			HFBJAOFLCJI().SetColor("ChatInput", GlassesColor2);
			NBPKMLMCHFN.SetColor("IconImage", GlassColor);
			NBPKMLMCHFN.SetFloat("_Green_G", UseScanLineSize);
			HNICHJCGJOC().SetFloat("_TimeX", UseScanLine);
			HNICHJCGJOC().SetTexture("plogs", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HFBJAOFLCJI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)66;
		}
		return BJFKDHHMLJH;
	}

	private void Update()
	{
	}

	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 860f)
			{
				HBJJOCHGOPH = 123f;
			}
			HHIFMIPPMPF().SetFloat("Missing shader for image effect {0}", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat(" SecondsBeforeRespawn: ", UseFinalGlassColor);
			NBPKMLMCHFN.SetFloat("_Far", Fade);
			HNICHJCGJOC().SetFloat("Cant ask anyone else for PickupItem spawn times.", VisionBlur);
			HFBJAOFLCJI().SetFloat("Drop_Far", GlassDistortion);
			KGOLDDBHIFN().SetFloat("hidden", GlassAberration);
			OIMMPLPBLBK().SetColor("_Value", GlassesColor);
			HFBJAOFLCJI().SetColor("_Distortion", GlassesColor2);
			OIMMPLPBLBK().SetColor("float,1", GlassColor);
			KGOLDDBHIFN().SetFloat("_TexelOffsetScale", UseScanLineSize);
			HNICHJCGJOC().SetFloat("_Vignette", UseScanLine);
			OIMMPLPBLBK().SetTexture("_TimeX", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KDMANOEMOCA()
	{
		FPHEBLMINDA = Resources.Load(" workshop map(s)") as Texture2D;
		SCShader = Shader.Find("Joystick1Button4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1772f)
			{
				HBJJOCHGOPH = 582f;
			}
			HNICHJCGJOC().SetFloat("_Value3", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_HighlightSuppression", UseFinalGlassColor);
			NBPKMLMCHFN.SetFloat("<b>Intralism Items Uploader</b> by Oxy949", Fade);
			HHIFMIPPMPF().SetFloat("_Bullet_9", VisionBlur);
			HHIFMIPPMPF().SetFloat("Items/", GlassDistortion);
			OIMMPLPBLBK().SetFloat("player.redlifering", GlassAberration);
			HNICHJCGJOC().SetColor("SetSatelliteTrailLength", GlassesColor);
			HNICHJCGJOC().SetColor("_Value4", GlassesColor2);
			KGOLDDBHIFN().SetColor(" not exist", GlassColor);
			HHIFMIPPMPF().SetFloat("================================", UseScanLineSize);
			OIMMPLPBLBK().SetFloat("mapselector.filter.rateduponly", UseScanLine);
			HFBJAOFLCJI().SetTexture("yesterday", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FABKIGNFECE()
	{
	}

	private void CIPKEPDELJB()
	{
		FPHEBLMINDA = Resources.Load("Fill") as Texture2D;
		SCShader = Shader.Find("Beat Detected");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void Start()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_Glasses_On6") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Glasses_On");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LEAHIBJDMBI()
	{
	}

	private void KLILJHJNICK()
	{
		FPHEBLMINDA = Resources.Load("Tonemapper curve texture") as Texture2D;
		SCShader = Shader.Find("image");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LLJLDLLNFBH()
	{
	}

	[SpecialName]
	private Material KGOLDDBHIFN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-114);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HHIFMIPPMPF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
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

	private void CCLNNLCOPBL()
	{
		FPHEBLMINDA = Resources.Load("[LevelEditorScene] Print Audio Wave: Done") as Texture2D;
		SCShader = Shader.Find("2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JOJFHFHOCHO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HNICHJCGJOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 525f)
			{
				HBJJOCHGOPH = 837f;
			}
			OIMMPLPBLBK().SetFloat("Texture2", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat(" beatThreshold: ", UseFinalGlassColor);
			HHIFMIPPMPF().SetFloat(" region", Fade);
			HFBJAOFLCJI().SetFloat("_Color", VisionBlur);
			HHIFMIPPMPF().SetFloat("_TimeX", GlassDistortion);
			OIMMPLPBLBK().SetFloat(".", GlassAberration);
			OIMMPLPBLBK().SetColor("Object ID. Case-Sensitive", GlassesColor);
			HNICHJCGJOC().SetColor(".lastCheckpoint.powerupsScore", GlassesColor2);
			HNICHJCGJOC().SetColor("_Value3", GlassColor);
			KGOLDDBHIFN().SetFloat("float,0.5", UseScanLineSize);
			OIMMPLPBLBK().SetFloat("Closes the app", UseScanLine);
			OIMMPLPBLBK().SetTexture("nd", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ONMGIPAILOH()
	{
	}

	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 927f)
			{
				HBJJOCHGOPH = 792f;
			}
			HNICHJCGJOC().SetFloat("_Level", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("Skipping packet for ", UseFinalGlassColor);
			NBPKMLMCHFN.SetFloat("_ReprojectionMatrix", Fade);
			NBPKMLMCHFN.SetFloat("Gameplay/Base", VisionBlur);
			HFBJAOFLCJI().SetFloat("New resource ID. Case-Sensitive", GlassDistortion);
			KGOLDDBHIFN().SetFloat("{0} hours ago", GlassAberration);
			KGOLDDBHIFN().SetColor("UndoButton", GlassesColor);
			HFBJAOFLCJI().SetColor("_LutTex", GlassesColor2);
			NBPKMLMCHFN.SetColor("ready", GlassColor);
			OIMMPLPBLBK().SetFloat("Vertical", UseScanLineSize);
			NBPKMLMCHFN.SetFloat("_LrDepthTex", UseScanLine);
			HNICHJCGJOC().SetTexture("request", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1258f)
			{
				HBJJOCHGOPH = 535f;
			}
			HNICHJCGJOC().SetFloat(" not found", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("Init", UseFinalGlassColor);
			HFBJAOFLCJI().SetFloat("_LoopCount", Fade);
			HHIFMIPPMPF().SetFloat("_History3ChromaTex", VisionBlur);
			NBPKMLMCHFN.SetFloat("Please wait..", GlassDistortion);
			KGOLDDBHIFN().SetFloat("traffic", GlassAberration);
			KGOLDDBHIFN().SetColor("#yes", GlassesColor);
			HNICHJCGJOC().SetColor("_Value8", GlassesColor2);
			NBPKMLMCHFN.SetColor("player.xp", GlassColor);
			HHIFMIPPMPF().SetFloat("challenges/", UseScanLineSize);
			HHIFMIPPMPF().SetFloat("GameScene", UseScanLine);
			NBPKMLMCHFN.SetTexture("MapperNameText", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EGEPLFGKGLI()
	{
		FPHEBLMINDA = Resources.Load("Preparing content") as Texture2D;
		SCShader = Shader.Find(".lastCheckpoint.correctScore");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material OIMMPLPBLBK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
		}
		return BJFKDHHMLJH;
	}

	private void CNGAJDBOCLJ()
	{
		FPHEBLMINDA = Resources.Load("bans.viewed.") as Texture2D;
		SCShader = Shader.Find("SetupEncryption() got called. ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
