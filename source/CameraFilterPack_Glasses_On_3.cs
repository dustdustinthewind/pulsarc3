// CameraFilterPack_Glasses_On_3
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Glasses/Night Glasses")]
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
		FPHEBLMINDA = Resources.Load("threshold") as Texture2D;
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
		SCShader = Shader.Find("selColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FNCDAPDOBBI()
	{
		FPHEBLMINDA = Resources.Load("Player") as Texture2D;
		SCShader = Shader.Find("Mine");
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
			MMOODGIODPC().SetFloat("Error: Timeout :S", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("_ScreenResolution", UseFinalGlassColor);
			KGOLDDBHIFN().SetFloat("settings.hitvariation", Fade);
			JIBOKBCPDLC().SetFloat("/", VisionBlur);
			MMOODGIODPC().SetFloat(".completedCount", GlassDistortion);
			OIMMPLPBLBK().SetFloat("LoadingStatusText", GlassAberration);
			PDEAHJPOMEF().SetColor("' was created: ", GlassesColor);
			JIBOKBCPDLC().SetColor("Checkpoint", GlassesColor2);
			PDEAHJPOMEF().SetColor("_Value2", GlassColor);
			IIBLJCKLGFG().SetFloat("_NumberOfWaves", UseScanLineSize);
			JIBOKBCPDLC().SetFloat("[Down]", UseScanLine);
			NBPKMLMCHFN.SetTexture("#onfirstranktext", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
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
		FPHEBLMINDA = Resources.Load("Object ID. Case-Sensitive") as Texture2D;
		SCShader = Shader.Find("_Value");
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
			NDMPCDHADMJ().SetFloat("#scoresubmitionfailed: ", HBJJOCHGOPH);
			JIBOKBCPDLC().SetFloat("SlidingArea", UseFinalGlassColor);
			HCGJCMDJPGD().SetFloat("x", Fade);
			HCGJCMDJPGD().SetFloat("ReconnectAndRejoin() failed. It seems the client wasn't connected to a game server before (no address).", VisionBlur);
			NDMPCDHADMJ().SetFloat("CameraFilterPack_OldFilm2", GlassDistortion);
			EMDFHOKEGNG().SetFloat("CheckpointsScoreText", GlassAberration);
			KGOLDDBHIFN().SetColor("Spawn new environment sprite (image) and sets its id", GlassesColor);
			OIMMPLPBLBK().SetColor("{0}_{1}", GlassesColor2);
			PDEAHJPOMEF().SetColor(".", GlassColor);
			ADBKPGFMNKO().SetFloat("[PlayerController] ", UseScanLineSize);
			PDEAHJPOMEF().SetFloat("catched: ", UseScanLine);
			NBPKMLMCHFN.SetTexture("CameraFilterPack/Vision_Blood", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
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
			NDMPCDHADMJ().SetFloat("No info", HBJJOCHGOPH);
			JIBOKBCPDLC().SetFloat("/../", UseFinalGlassColor);
			OIMMPLPBLBK().SetFloat(" PhotonView: ", Fade);
			MMOODGIODPC().SetFloat("[NetworkManager] Join failed", VisionBlur);
			ADGHJOHKEHG().SetFloat("CameraFilterPack/Blur_Movie", GlassDistortion);
			EMDFHOKEGNG().SetFloat("_Value", GlassAberration);
			ADBKPGFMNKO().SetColor("LevelEditor/CustomEventEditor-Text", GlassesColor);
			ADGHJOHKEHG().SetColor("<b>Commands:</b>\n/help\n/players\n/kick\n/table\n/clear", GlassesColor2);
			JIBOKBCPDLC().SetColor(" methods \"", GlassColor);
			PDEAHJPOMEF().SetFloat("GenerationMenu", UseScanLineSize);
			LDNADDJMIPK().SetFloat("settings.cameramovements", UseScanLine);
			ADBKPGFMNKO().SetTexture("#FFFFFFFF", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NDMPCDHADMJ());
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
		FPHEBLMINDA = Resources.Load(".icon") as Texture2D;
		SCShader = Shader.Find("ShowSprite");
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
		FPHEBLMINDA = Resources.Load("checkpoint") as Texture2D;
		SCShader = Shader.Find("JoinTeam was called in state: ");
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
			ADGHJOHKEHG().SetFloat("shader.crispwinter", UseFinalGlassColor);
			HCGJCMDJPGD().SetFloat("help", Fade);
			HCGJCMDJPGD().SetFloat("SetParticlesEmission", VisionBlur);
			KGOLDDBHIFN().SetFloat("entering", GlassDistortion);
			JIBOKBCPDLC().SetFloat("(((?<x>(?=[,\\r\\n]+))|\"(?<x>([^\"]|\"\")+)\"|(?<x>[^,\\r\\n]+)),?)", GlassAberration);
			PDEAHJPOMEF().SetColor("y", GlassesColor);
			NBPKMLMCHFN.SetColor("_Saturation", GlassesColor2);
			MMOODGIODPC().SetColor("maps.", GlassColor);
			HCGJCMDJPGD().SetFloat("#submit", UseScanLineSize);
			ADBKPGFMNKO().SetFloat("Data/Skins/", UseScanLine);
			JIBOKBCPDLC().SetTexture("_DiffuseColor", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
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
		SCShader = Shader.Find("'{0}' \t{1}ms \t{2}");
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
			LDNADDJMIPK().SetFloat("_TimeX", HBJJOCHGOPH);
			MMOODGIODPC().SetFloat("_Intensity", UseFinalGlassColor);
			LDNADDJMIPK().SetFloat("_Value5", Fade);
			HCGJCMDJPGD().SetFloat("May", VisionBlur);
			JIBOKBCPDLC().SetFloat("Indie", GlassDistortion);
			MMOODGIODPC().SetFloat("_FarCamera", GlassAberration);
			PDEAHJPOMEF().SetColor("error", GlassesColor);
			MMOODGIODPC().SetColor("FullscreenToggle", GlassesColor2);
			PDEAHJPOMEF().SetColor("Please attach component to a Graphical UI component", GlassColor);
			EMDFHOKEGNG().SetFloat("\r", UseScanLineSize);
			ADBKPGFMNKO().SetFloat("ACCEPT", UseScanLine);
			EMDFHOKEGNG().SetTexture(" at ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
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
			JIBOKBCPDLC().SetFloat(" [", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("Backward", UseFinalGlassColor);
			ADGHJOHKEHG().SetFloat("achievements.21.completed.", Fade);
			PDEAHJPOMEF().SetFloat(" but this PhotonView does not exist! Was remote PV.", VisionBlur);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", GlassDistortion);
			HCGJCMDJPGD().SetFloat("???", GlassAberration);
			PDEAHJPOMEF().SetColor("closed", GlassesColor);
			PDEAHJPOMEF().SetColor("\\\"", GlassesColor2);
			LDNADDJMIPK().SetColor("_FullResolutionFiltering", GlassColor);
			LDNADDJMIPK().SetFloat("CameraFilterPack/Blend2Camera_Multiply", UseScanLineSize);
			ADGHJOHKEHG().SetFloat(".completed", UseScanLine);
			ADGHJOHKEHG().SetTexture("Default UI Material", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
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
		FPHEBLMINDA = Resources.Load("EventConfigButton") as Texture2D;
		SCShader = Shader.Find("OpSetPropertiesOfActor not sent. ActorNr must be > 0 and actorProperties != null.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CIPKEPDELJB()
	{
		FPHEBLMINDA = Resources.Load("In Main Menu") as Texture2D;
		SCShader = Shader.Find(" ");
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
			IIBLJCKLGFG().SetFloat("_Value", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("1 Kb", UseFinalGlassColor);
			KGOLDDBHIFN().SetFloat("Left Stick Click", Fade);
			IIBLJCKLGFG().SetFloat("DifficultyBG", VisionBlur);
			JIBOKBCPDLC().SetFloat("|", GlassDistortion);
			KGOLDDBHIFN().SetFloat("_PColor", GlassAberration);
			NBPKMLMCHFN.SetColor("Hidden/TonemappingColorGrading", GlassesColor);
			ADGHJOHKEHG().SetColor("CameraFilterPack/Atmosphere_Rain_Pro_3D", GlassesColor2);
			NBPKMLMCHFN.SetColor("closed", GlassColor);
			NBPKMLMCHFN.SetFloat("Reset XP", UseScanLineSize);
			NBPKMLMCHFN.SetFloat(".png", UseScanLine);
			PDEAHJPOMEF().SetTexture("CameraFilterPack/FX_DigitalMatrixDistortion", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIBLJCKLGFG());
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
			KGOLDDBHIFN().SetFloat("float,1", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("\\n", UseFinalGlassColor);
			MMOODGIODPC().SetFloat("[Up]", Fade);
			NBPKMLMCHFN.SetFloat("_ConsoleSettings", VisionBlur);
			PDEAHJPOMEF().SetFloat("SpawnObj", GlassDistortion);
			JIBOKBCPDLC().SetFloat("set", GlassAberration);
			KGOLDDBHIFN().SetColor("<color=#", GlassesColor);
			JIBOKBCPDLC().SetColor("offsets", GlassesColor2);
			IIBLJCKLGFG().SetColor("CameraFilterPack/3D_Inverse", GlassColor);
			ADBKPGFMNKO().SetFloat("RT", UseScanLineSize);
			PDEAHJPOMEF().SetFloat("EventMenu", UseScanLine);
			KGOLDDBHIFN().SetTexture("Uploading preview image...", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
