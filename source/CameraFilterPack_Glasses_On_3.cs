// CameraFilterPack_Glasses_On_3
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Glasses/Night Glasses")]
[ExecuteInEditMode]
public class CameraFilterPack_Glasses_On_3 : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	[Range(0f, 1f)]
	public float Fade = 0.3f;

	[Range(0f, 0.1f)]
	public float VisionBlur = 0.005f;

	public Color GlassesColor = new Color(0.7f, 0.7f, 0.7f, 1f);

	public Color GlassesColor2 = new Color(1f, 1f, 1f, 1f);

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

	public Color GlassColor = new Color(0f, 0.5f, 0f, 1f);

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

	private void NBGIMIDICKE()
	{
		FPHEBLMINDA = Resources.Load("_ColorBuffer") as Texture2D;
		SCShader = Shader.Find("float,50");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HGDDCINLDAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JHJGJJKELJM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KNBJBNDGCIJ()
	{
		FPHEBLMINDA = Resources.Load("_Speed") as Texture2D;
		SCShader = Shader.Find("The given 2D texture ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FNCDAPDOBBI()
	{
		FPHEBLMINDA = Resources.Load("settings.shaders") as Texture2D;
		SCShader = Shader.Find("PunPickup");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material ADBKPGFMNKO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-82);
		}
		return BJFKDHHMLJH;
	}

	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 189f)
			{
				HBJJOCHGOPH = 1140f;
			}
			PDEAHJPOMEF().SetFloat("Error: I/O Failure! :(", HBJJOCHGOPH);
			EMDFHOKEGNG().SetFloat("CameraFilterPack/Blur_DitherOffset", UseFinalGlassColor);
			NBPKMLMCHFN.SetFloat("BloomShaderValueSlider", Fade);
			ADBKPGFMNKO().SetFloat("/", VisionBlur);
			HCGJCMDJPGD().SetFloat("challenges.", GlassDistortion);
			MMOODGIODPC().SetFloat("[ItemsHandler] Loading Steam inventory", GlassAberration);
			IIBLJCKLGFG().SetColor("(singleton) ", GlassesColor);
			ADBKPGFMNKO().SetColor(",", GlassesColor2);
			PDEAHJPOMEF().SetColor("_Value3", GlassColor);
			KGOLDDBHIFN().SetFloat("CameraFilterPack/Distortion_Wave_Horizontal", UseScanLineSize);
			MMOODGIODPC().SetFloat("SpawnObj", UseScanLine);
			PDEAHJPOMEF().SetTexture("#onrankchangedowntext", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GKNKIIEALCH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OMCLOFCJMPG()
	{
	}

	[SpecialName]
	private Material KGOLDDBHIFN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)120;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HCGJCMDJPGD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)98;
		}
		return BJFKDHHMLJH;
	}

	private void GPFJMKCGHGB()
	{
	}

	private void Start()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_Glasses_On4") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Glasses_On");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PAEGLMEOKHP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CBIBDOIBJAI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NAOLAJPDGIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LECCHIAFGGE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material NDMPCDHADMJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material LDNADDJMIPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)66;
		}
		return BJFKDHHMLJH;
	}

	private void BGDPIHMAACO()
	{
		FPHEBLMINDA = Resources.Load("value") as Texture2D;
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void Update()
	{
	}

	private void DOEPOGLEGLE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JHPOIOELNCG()
	{
	}

	[SpecialName]
	private Material IIBLJCKLGFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material EMDFHOKEGNG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void JBNPEHMDCMI()
	{
	}

	[SpecialName]
	private Material ADGHJOHKEHG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material MMOODGIODPC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)118;
		}
		return BJFKDHHMLJH;
	}

	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1505f)
			{
				HBJJOCHGOPH = 1466f;
			}
			LDNADDJMIPK().SetFloat("#tryagain", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("ItemTemplate", UseFinalGlassColor);
			OIMMPLPBLBK().SetFloat("z", Fade);
			NBPKMLMCHFN.SetFloat("ConnectToBestCloudServer() failed. Can only connect while in state 'Disconnected'. Current state: ", VisionBlur);
			IIBLJCKLGFG().SetFloat("CameraFilterPack/OldFilm_Cutting2", GlassDistortion);
			ADBKPGFMNKO().SetFloat("CheckpointsScoreText", GlassAberration);
			IIBLJCKLGFG().SetColor("SetEnvSpriteImage", GlassesColor);
			HCGJCMDJPGD().SetColor("ws://", GlassesColor2);
			KGOLDDBHIFN().SetColor(".lastCheckpoint.time", GlassColor);
			MMOODGIODPC().SetFloat(": ", UseScanLineSize);
			IIBLJCKLGFG().SetFloat("Can't set visible when not in that room.", UseScanLine);
			OIMMPLPBLBK().SetTexture("_Value", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
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

	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 517f)
			{
				HBJJOCHGOPH = 1487f;
			}
			NDMPCDHADMJ().SetFloat("music.ogg", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("OxOD.lastPath", UseFinalGlassColor);
			IIBLJCKLGFG().SetFloat("Mine", Fade);
			KGOLDDBHIFN().SetFloat("In Main Menu", VisionBlur);
			ADBKPGFMNKO().SetFloat("_TimeX", GlassDistortion);
			JIBOKBCPDLC().SetFloat("_Value2", GlassAberration);
			KGOLDDBHIFN().SetColor(",", GlassesColor);
			JIBOKBCPDLC().SetColor("<b>Commands:</b>\n/help\n/players\n/kick\n/table\n/clear", GlassesColor2);
			ADGHJOHKEHG().SetColor(" argument(s): ", GlassColor);
			OIMMPLPBLBK().SetFloat("GenerationMenu", UseScanLineSize);
			OIMMPLPBLBK().SetFloat("settings.enablehitsoundsinnormal", UseScanLine);
			JIBOKBCPDLC().SetTexture("speed", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material OIMMPLPBLBK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-112);
		}
		return BJFKDHHMLJH;
	}

	private void CFIAKIJAILI()
	{
	}

	private void HLDFOJMHKNL()
	{
	}

	private void DAHFFNNIGML()
	{
		FPHEBLMINDA = Resources.Load(".GoalProgress") as Texture2D;
		SCShader = Shader.Find("Checkpoint");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void HLIAEEMGBHN()
	{
		FPHEBLMINDA = Resources.Load("Added checkpoint") as Texture2D;
		SCShader = Shader.Find("team");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material JIBOKBCPDLC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void EHCGBJDFMHG()
	{
	}

	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 383f)
			{
				HBJJOCHGOPH = 503f;
			}
			ADBKPGFMNKO().SetFloat("_Sat", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("shader.ghost", UseFinalGlassColor);
			KGOLDDBHIFN().SetFloat("Prints list of commands", Fade);
			ADBKPGFMNKO().SetFloat("SetParticlesCountPerBeat", VisionBlur);
			JIBOKBCPDLC().SetFloat("entering", GlassDistortion);
			MMOODGIODPC().SetFloat("en", GlassAberration);
			NBPKMLMCHFN.SetColor("w", GlassesColor);
			HCGJCMDJPGD().SetColor("_Saturation", GlassesColor2);
			NBPKMLMCHFN.SetColor("maps.", GlassColor);
			ADGHJOHKEHG().SetFloat("#no", UseScanLineSize);
			PDEAHJPOMEF().SetFloat("[ResourcesManager] Load image error: ", UseScanLine);
			NBPKMLMCHFN.SetTexture("_DiffuseColor", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LIEGJOHINGC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BMOFEBKGLFI()
	{
		FPHEBLMINDA = Resources.Load("Electronic") as Texture2D;
		SCShader = Shader.Find("ServerSettings: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OCCGJMPAJIK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EFJDNLGNACH()
	{
		FPHEBLMINDA = Resources.Load(" - ") as Texture2D;
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1864f)
			{
				HBJJOCHGOPH = 948f;
			}
			JIBOKBCPDLC().SetFloat("_Value", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("colorB", UseFinalGlassColor);
			ADGHJOHKEHG().SetFloat("_Value6", Fade);
			PDEAHJPOMEF().SetFloat("Aug", VisionBlur);
			HCGJCMDJPGD().SetFloat("Instrumental", GlassDistortion);
			NBPKMLMCHFN.SetFloat("_FarCamera", GlassAberration);
			KGOLDDBHIFN().SetColor("Done! You are a contributor until: ", GlassesColor);
			MMOODGIODPC().SetColor("MenuVolumeSlider", GlassesColor2);
			MMOODGIODPC().SetColor("UI Extensions/UISoftAdditive", GlassColor);
			PDEAHJPOMEF().SetFloat("\r", UseScanLineSize);
			LDNADDJMIPK().SetFloat("NO", UseScanLine);
			HCGJCMDJPGD().SetTexture(" at ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DHENLPJJOEN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 539f)
			{
				HBJJOCHGOPH = 1520f;
			}
			LDNADDJMIPK().SetFloat("curScn", HBJJOCHGOPH);
			MMOODGIODPC().SetFloat("Jump", UseFinalGlassColor);
			OIMMPLPBLBK().SetFloat("achievements.21.completed.", Fade);
			PDEAHJPOMEF().SetFloat(" Remote called.", VisionBlur);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/TV_Vignetting", GlassDistortion);
			JIBOKBCPDLC().SetFloat("Commands for challenges", GlassAberration);
			KGOLDDBHIFN().SetColor("hidden", GlassesColor);
			KGOLDDBHIFN().SetColor("}", GlassesColor2);
			EMDFHOKEGNG().SetColor("_HighlightSuppression", GlassColor);
			NDMPCDHADMJ().SetFloat("CameraFilterPack/Blend2Camera_ColorBurn", UseScanLineSize);
			KGOLDDBHIFN().SetFloat("#no", UseScanLine);
			OIMMPLPBLBK().SetTexture("Please attach component to a Graphical UI component", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JAAJECBCCFM()
	{
	}

	private void NDAJBJFJGCF()
	{
	}

	private void KMCPMOGKDEH()
	{
		FPHEBLMINDA = Resources.Load("EditMenu") as Texture2D;
		SCShader = Shader.Find("OpAuthenticate()");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CIPKEPDELJB()
	{
		FPHEBLMINDA = Resources.Load("Offline") as Texture2D;
		SCShader = Shader.Find("OpenButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 120f)
			{
				HBJJOCHGOPH = 1867f;
			}
			PDEAHJPOMEF().SetFloat("_Value", HBJJOCHGOPH);
			NDMPCDHADMJ().SetFloat(" Kb", UseFinalGlassColor);
			LDNADDJMIPK().SetFloat("Joystick1Button11", Fade);
			PDEAHJPOMEF().SetFloat("DifficultyBG", VisionBlur);
			PDEAHJPOMEF().SetFloat("|", GlassDistortion);
			JIBOKBCPDLC().SetFloat("_Value1", GlassAberration);
			NDMPCDHADMJ().SetColor("_AdaptationSpeed", GlassesColor);
			LDNADDJMIPK().SetColor("CameraFilterPack/Atmosphere_Rain_Pro_3D", GlassesColor2);
			OIMMPLPBLBK().SetColor("ServerSettings: ", GlassColor);
			NBPKMLMCHFN.SetFloat("Reload Maps", UseScanLineSize);
			MMOODGIODPC().SetFloat("/", UseScanLine);
			KGOLDDBHIFN().SetTexture("_TimeX", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1903f)
			{
				HBJJOCHGOPH = 297f;
			}
			NBPKMLMCHFN.SetFloat("float,1", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("_EmissionColor", UseFinalGlassColor);
			HCGJCMDJPGD().SetFloat("[Left]", Fade);
			OIMMPLPBLBK().SetFloat("AreaTex", VisionBlur);
			IIBLJCKLGFG().SetFloat("SetSpeed", GlassDistortion);
			ADGHJOHKEHG().SetFloat("keys", GlassAberration);
			LDNADDJMIPK().SetColor(">", GlassesColor);
			HCGJCMDJPGD().SetColor("_MainTexBlurred", GlassesColor2);
			ADBKPGFMNKO().SetColor("CameraFilterPack/3D_Inverse", GlassColor);
			JIBOKBCPDLC().SetFloat("Back", UseScanLineSize);
			EMDFHOKEGNG().SetFloat("EventMenu", UseScanLine);
			LDNADDJMIPK().SetTexture("Item invalid. Make sure your mod contains at leats one file.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
