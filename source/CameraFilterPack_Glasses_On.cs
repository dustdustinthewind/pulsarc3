// CameraFilterPack_Glasses_On
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Glasses/Classic Glasses")]
[ExecuteInEditMode]
public class CameraFilterPack_Glasses_On : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	[Range(0f, 1f)]
	public float Fade = 0.2f;

	[Range(0f, 0.1f)]
	public float VisionBlur = 0.0095f;

	public Color GlassesColor = new Color(0f, 0f, 0f, 1f);

	public Color GlassesColor2 = new Color(0.25f, 0.25f, 0.25f, 0.25f);

	[Range(0f, 1f)]
	public float GlassDistortion = 0.45f;

	[Range(0f, 1f)]
	public float GlassAberration = 0.5f;

	[Range(0f, 1f)]
	public float UseFinalGlassColor;

	[Range(0f, 1f)]
	public float UseScanLine;

	[Range(1f, 512f)]
	public float UseScanLineSize = 1f;

	public Color GlassColor = new Color(0f, 0f, 0f, 1f);

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

	private void GAOOPEEBGJA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BMODOIJGIOO()
	{
	}

	private void JDKHBGDEONK()
	{
		FPHEBLMINDA = Resources.Load("_Offsets") as Texture2D;
		SCShader = Shader.Find("DataText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GHILDCBCDJI()
	{
	}

	[SpecialName]
	private Material MLMKCOINOOH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-119);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void JKFDDNMPOJH()
	{
		FPHEBLMINDA = Resources.Load("masterSteamID") as Texture2D;
		SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HGDDCINLDAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DLIJFEGIEKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1829f)
			{
				HBJJOCHGOPH = 966f;
			}
			OLHDPICFBOF().SetFloat("CameraFilterPack_TV_Noise2", HBJJOCHGOPH);
			FLOHGDECHHH().SetFloat(" should be overwritten.", UseFinalGlassColor);
			HEHKGPKLAKK().SetFloat("turn", Fade);
			MFHPKGICPIO().SetFloat(" ", VisionBlur);
			GHHPOGODBHB().SetFloat(",", GlassDistortion);
			MICHFGAOPKM().SetFloat("Updated!", GlassAberration);
			MFHPKGICPIO().SetColor("_Blend", GlassesColor);
			GHHPOGODBHB().SetColor(",", GlassesColor2);
			NBPKMLMCHFN.SetColor("_History3ChromaTex", GlassColor);
			HNFFHCLNBDN().SetFloat("skin.", UseScanLineSize);
			KEMJNOMIPHN().SetFloat("_ScreenResolution", UseScanLine);
			HKGAONMOBMH().SetTexture("_Value4", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HKGAONMOBMH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void PNLKFANNOKO()
	{
	}

	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 760f)
			{
				HBJJOCHGOPH = 22f;
			}
			MLMKCOINOOH().SetFloat("_NormalAndRoughnessTexture", HBJJOCHGOPH);
			LPMLLJKMAMP().SetFloat("\0\0", UseFinalGlassColor);
			HEHKGPKLAKK().SetFloat("\" that takes ", Fade);
			MLMKCOINOOH().SetFloat("[EditorEvent] Exception: ", VisionBlur);
			HEHKGPKLAKK().SetFloat("LevelNameInputField", GlassDistortion);
			LPMLLJKMAMP().SetFloat("StartButton", GlassAberration);
			HEHKGPKLAKK().SetColor("_Value3", GlassesColor);
			DKKBFFHBHJE().SetColor("error", GlassesColor2);
			DKKBFFHBHJE().SetColor("tagElement", GlassColor);
			MLMKCOINOOH().SetFloat("MultiplayerButton", UseScanLineSize);
			OLHDPICFBOF().SetFloat("SingleplayerButton", UseScanLine);
			MICHFGAOPKM().SetTexture("#000000", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IMCKJCHKMKB()
	{
		FPHEBLMINDA = Resources.Load("The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.") as Texture2D;
		SCShader = Shader.Find("https://vk.com/khb.soft");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ALMGMOOHLMA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1441f)
			{
				HBJJOCHGOPH = 402f;
			}
			GHHPOGODBHB().SetFloat("CameraFilterPack/Pixelisation_Dot", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("SetSunInput", UseFinalGlassColor);
			GHHPOGODBHB().SetFloat("System.Boolean", Fade);
			KEMJNOMIPHN().SetFloat("_Value2", VisionBlur);
			OLHDPICFBOF().SetFloat("_Value", GlassDistortion);
			MICHFGAOPKM().SetFloat("SetTrailZoomSpeed", GlassAberration);
			HKGAONMOBMH().SetColor("_TimeX", GlassesColor);
			FEAEGGCNIAA().SetColor("http://api.steampowered.com/ISteamNews/GetNewsForApp/v0002/?format=json&appid=513510", GlassesColor2);
			HKGAONMOBMH().SetColor("0,1,false", GlassColor);
			OLHDPICFBOF().SetFloat(".", UseScanLineSize);
			MFHPKGICPIO().SetFloat("curScn", UseScanLine);
			MFHPKGICPIO().SetTexture("EnvironmentSlider", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	private void KMOCDAOKGLI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ABEIEGDHBNO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material GHHPOGODBHB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-111);
		}
		return BJFKDHHMLJH;
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

	private void HIPEHGNBJMN()
	{
		FPHEBLMINDA = Resources.Load("_ExposureAdjustment") as Texture2D;
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HLLHJIDOOGA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OIBMHPIFAKK()
	{
	}

	private void JHJGJJKELJM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 44f)
			{
				HBJJOCHGOPH = 1760f;
			}
			MFHPKGICPIO().SetFloat("StartCanvas", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("menutheme", UseFinalGlassColor);
			OLHDPICFBOF().SetFloat("_TimeX", Fade);
			LENEJAGLCNL().SetFloat("???", VisionBlur);
			HEHKGPKLAKK().SetFloat("_DotSize", GlassDistortion);
			KEMJNOMIPHN().SetFloat("_Value1", GlassAberration);
			MFHPKGICPIO().SetColor("_Blue_B", GlassesColor);
			FEAEGGCNIAA().SetColor("BitsData", GlassesColor2);
			LMLENGFLEBD().SetColor("Failed to 'network-remove' GameObject because it is missing a valid InstantiationId on view: ", GlassColor);
			HKGAONMOBMH().SetFloat("My New Mod Pack", UseScanLineSize);
			HNFFHCLNBDN().SetFloat("CONTRAST", UseScanLine);
			OLHDPICFBOF().SetTexture("]", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GPNAOAKCMHC()
	{
		FPHEBLMINDA = Resources.Load("Despawn environment object by id") as Texture2D;
		SCShader = Shader.Find("#onrankchangeuptext");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LGHCJCFHEMF()
	{
		FPHEBLMINDA = Resources.Load("[MenuScene] Error: ") as Texture2D;
		SCShader = Shader.Find("_Visualize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FBMDHDBELEK()
	{
	}

	private void LCHBFNIPBHB()
	{
	}

	private void HLIAEEMGBHN()
	{
		FPHEBLMINDA = Resources.Load("Emergency Help:") as Texture2D;
		SCShader = Shader.Find("playing");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IHLMNAGPKDA()
	{
		FPHEBLMINDA = Resources.Load("settings.volume.sfx") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Gradients_NeonGradient");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BJOHDLNDFAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KOJKBFDNGDK()
	{
		FPHEBLMINDA = Resources.Load("</size>") as Texture2D;
		SCShader = Shader.Find("_Bullet_6");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material LENEJAGLCNL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void EJFJENFKLND()
	{
	}

	[SpecialName]
	private Material HEHKGPKLAKK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void MCKCCPLJIFE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material MFHPKGICPIO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return BJFKDHHMLJH;
	}

	private void BMIOFJFMCBG()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack/Retro_Loading") as Texture2D;
		SCShader = Shader.Find("SetSatelliteRadius");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EPEGAEGDJAM()
	{
		FPHEBLMINDA = Resources.Load("Joystick1Button10") as Texture2D;
		SCShader = Shader.Find("#,0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IBPAMDEAGJL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EDCMIPNCPLB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ODAIMOJLJOF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KIMMMCJFMAB()
	{
		FPHEBLMINDA = Resources.Load("]") as Texture2D;
		SCShader = Shader.Find("mapselector.lastSearch");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PHJJHFBLICM()
	{
	}

	private void IENKPJEBMFM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FJIKDJAMOHA()
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

	private void FGBDGGCBFLP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 663f)
			{
				HBJJOCHGOPH = 907f;
			}
			KEMJNOMIPHN().SetFloat("SpeedSlider", HBJJOCHGOPH);
			GHHPOGODBHB().SetFloat("_SoftZDistance", UseFinalGlassColor);
			MICHFGAOPKM().SetFloat("other.dust0", Fade);
			KEMJNOMIPHN().SetFloat("MapEditorScene", VisionBlur);
			LPMLLJKMAMP().SetFloat("shaders", GlassDistortion);
			LENEJAGLCNL().SetFloat("Please define the RectTransform for the Center viewport of the scrollable area", GlassAberration);
			LPMLLJKMAMP().SetColor("<b>Speed</b>:", GlassesColor);
			LMLENGFLEBD().SetColor("_Green_B", GlassesColor2);
			NBMPPNFKFLB().SetColor("CameraFilterPack/Distortion_ShockWaveManual", GlassColor);
			NBMPPNFKFLB().SetFloat("Tried to Initialize the SteamAPI twice in one session!", UseScanLineSize);
			LENEJAGLCNL().SetFloat("No font defined. Found font: ", UseScanLine);
			MFHPKGICPIO().SetTexture("int", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 793f)
			{
				HBJJOCHGOPH = 1346f;
			}
			HEHKGPKLAKK().SetFloat("NetworkCanvas", HBJJOCHGOPH);
			OKJOKHGJHGF().SetFloat("ViewMenu", UseFinalGlassColor);
			LMLENGFLEBD().SetFloat("challenges.", Fade);
			HKGAONMOBMH().SetFloat("Tab2Content", VisionBlur);
			IONHGBPGCHK().SetFloat("_History1Weight", GlassDistortion);
			OKJOKHGJHGF().SetFloat(",", GlassAberration);
			LPMLLJKMAMP().SetColor("SetCrosshairEmission", GlassesColor);
			OLHDPICFBOF().SetColor("My New Mod Pack", GlassesColor2);
			OLHDPICFBOF().SetColor("CameraFilterPack/Vision_Blood_Fast", GlassColor);
			HKGAONMOBMH().SetFloat("Set satellite trail length in seconds", UseScanLineSize);
			MFHPKGICPIO().SetFloat("_BorderColor", UseScanLine);
			DKKBFFHBHJE().SetTexture("Preparing content", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HIFLPHLGLFG()
	{
	}

	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1226f)
			{
				HBJJOCHGOPH = 1159f;
			}
			KEMJNOMIPHN().SetFloat("Missing shader for image effect {0}", HBJJOCHGOPH);
			MLMKCOINOOH().SetFloat("_Red_G", UseFinalGlassColor);
			FLOHGDECHHH().SetFloat("JITTER", Fade);
			OKJOKHGJHGF().SetFloat("-help", VisionBlur);
			MFHPKGICPIO().SetFloat("_FixDistance", GlassDistortion);
			MLMKCOINOOH().SetFloat(".completedMaps", GlassAberration);
			DKKBFFHBHJE().SetColor("_Value4", GlassesColor);
			HNFFHCLNBDN().SetColor("You must complete your map before submiting it to Workshop", GlassesColor2);
			GHHPOGODBHB().SetColor("offline room", GlassColor);
			LENEJAGLCNL().SetFloat("CameraFilterPack/EyesVision_2", UseScanLineSize);
			LMLENGFLEBD().SetFloat("_Value", UseScanLine);
			LENEJAGLCNL().SetTexture("_TimeX", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Start()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_Glasses_On2") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Glasses_On");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HIKKPDACJGI()
	{
	}

	private void DAHFFNNIGML()
	{
		FPHEBLMINDA = Resources.Load("init") as Texture2D;
		SCShader = Shader.Find("\\");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1469f)
			{
				HBJJOCHGOPH = 1381f;
			}
			GHHPOGODBHB().SetFloat("_MainTex2", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_SunColor", UseFinalGlassColor);
			NBMPPNFKFLB().SetFloat("_RangeScale", Fade);
			HNFFHCLNBDN().SetFloat("lobby '{0}'[{1}]", VisionBlur);
			GHHPOGODBHB().SetFloat(".", GlassDistortion);
			MLMKCOINOOH().SetFloat("Please specify a map name or buildID", GlassAberration);
			IONHGBPGCHK().SetColor(" left", GlassesColor);
			HKGAONMOBMH().SetColor("[MapEditor] Prepairing map editor...", GlassesColor2);
			LPMLLJKMAMP().SetColor("Hidden/Image Effects/Cinematic/MotionBlur/FrameBlending", GlassColor);
			MFHPKGICPIO().SetFloat("_TimeX", UseScanLineSize);
			OLHDPICFBOF().SetFloat("received</b>\n#reason: ", UseScanLine);
			MFHPKGICPIO().SetTexture("workshop.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GJAJBMGGPFB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JBCNIPJDPJB()
	{
	}

	private void JECMJNFGBGC()
	{
		FPHEBLMINDA = Resources.Load("mapselector.tags.") as Texture2D;
		SCShader = Shader.Find("[Up]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 439f)
			{
				HBJJOCHGOPH = 1784f;
			}
			MFHPKGICPIO().SetFloat("_Value", HBJJOCHGOPH);
			LENEJAGLCNL().SetFloat("resetall", UseFinalGlassColor);
			FLOHGDECHHH().SetFloat("[NetworkManager] Updating current room...", Fade);
			LENEJAGLCNL().SetFloat("pointBuffer", VisionBlur);
			LENEJAGLCNL().SetFloat("<b>Speed</b>:", GlassDistortion);
			LMLENGFLEBD().SetFloat("icon", GlassAberration);
			LMLENGFLEBD().SetColor("_Value2", GlassesColor);
			KEMJNOMIPHN().SetColor("offsets", GlassesColor2);
			DKKBFFHBHJE().SetColor("_FixDistance", GlassColor);
			NBMPPNFKFLB().SetFloat("]", UseScanLineSize);
			NBPKMLMCHFN.SetFloat("_Saturation", UseScanLine);
			IONHGBPGCHK().SetTexture("EditMenu", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 305f)
			{
				HBJJOCHGOPH = 1987f;
			}
			LMLENGFLEBD().SetFloat("_Value2", HBJJOCHGOPH);
			OKJOKHGJHGF().SetFloat("Editor/", UseFinalGlassColor);
			HNFFHCLNBDN().SetFloat("_Value2", Fade);
			MLMKCOINOOH().SetFloat("GameScene", VisionBlur);
			FLOHGDECHHH().SetFloat("_Value2", GlassDistortion);
			IONHGBPGCHK().SetFloat(": ", GlassAberration);
			PGPEMMBJOOG().SetColor("_Value4", GlassesColor);
			LPMLLJKMAMP().SetColor("restrictions\n\n#until: ", GlassesColor2);
			KEMJNOMIPHN().SetColor("menutheme.fragout", GlassColor);
			LENEJAGLCNL().SetFloat(". Name: ", UseScanLineSize);
			GHHPOGODBHB().SetFloat("CameraFilterPack/Blend2Camera_Darken", UseScanLine);
			GHHPOGODBHB().SetTexture("Set satellite MinVertexDistance - how much distance should be between to points of the trail line", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LPMLLJKMAMP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)65;
		}
		return BJFKDHHMLJH;
	}

	private void CIPKEPDELJB()
	{
		FPHEBLMINDA = Resources.Load("Stream did not contain properly formatted byte array") as Texture2D;
		SCShader = Shader.Find("PunRespawn");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FKEJGBFDCAH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NCPAFCKGJEA()
	{
	}

	[SpecialName]
	private Material LMLENGFLEBD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material PGPEMMBJOOG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void KDMKDEKCELE()
	{
		FPHEBLMINDA = Resources.Load("_Value4") as Texture2D;
		SCShader = Shader.Find("Set arcs speed. Base value - 15");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OCMKCBBCEFG()
	{
	}

	private void DLBODOFAJGM()
	{
		FPHEBLMINDA = Resources.Load("_WaveIntensity") as Texture2D;
		SCShader = Shader.Find("Using constructor for new PingNativeStatic()");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NFEDLAOPHML()
	{
	}

	[SpecialName]
	private Material HNFFHCLNBDN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void ONKDMMJPEMN()
	{
	}

	private void HLDFOJMHKNL()
	{
	}

	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 705f)
			{
				HBJJOCHGOPH = 1730f;
			}
			LPMLLJKMAMP().SetFloat("_Value", HBJJOCHGOPH);
			OLHDPICFBOF().SetFloat("Delete events", UseFinalGlassColor);
			HNFFHCLNBDN().SetFloat("settings.showHP", Fade);
			MICHFGAOPKM().SetFloat("Texture2", VisionBlur);
			GHHPOGODBHB().SetFloat("Noise & Grain effect failing as noise texture is not assigned. please assign.", GlassDistortion);
			KEMJNOMIPHN().SetFloat("id", GlassAberration);
			NBPKMLMCHFN.SetColor("inventory.lastitemscount", GlassesColor);
			OLHDPICFBOF().SetColor("GameScene", GlassesColor2);
			HEHKGPKLAKK().SetColor("#8E8E8EFF", GlassColor);
			IONHGBPGCHK().SetFloat("Write me to get one for testing :)", UseScanLineSize);
			OLHDPICFBOF().SetFloat("_Size", UseScanLine);
			LPMLLJKMAMP().SetTexture("Horizontal", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material OLHDPICFBOF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void GJLKJAOBPJD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BOLBPPHJBMI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material MICHFGAOPKM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void OMCLOFCJMPG()
	{
	}

	private void HDMDKOKOOJC()
	{
		FPHEBLMINDA = Resources.Load("88f00bdf0ad61b16b803971ebe071962") as Texture2D;
		SCShader = Shader.Find("_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1132f)
			{
				HBJJOCHGOPH = 1397f;
			}
			HEHKGPKLAKK().SetFloat("Remove Environment Object", HBJJOCHGOPH);
			MLMKCOINOOH().SetFloat("offsets", UseFinalGlassColor);
			NBMPPNFKFLB().SetFloat("ns", Fade);
			NBPKMLMCHFN.SetFloat("Print the list of scenes, avalable in game.", VisionBlur);
			OKJOKHGJHGF().SetFloat("_Fade", GlassDistortion);
			HKGAONMOBMH().SetFloat("Tab2Content", GlassAberration);
			IONHGBPGCHK().SetColor("GameScene", GlassesColor);
			LPMLLJKMAMP().SetColor("_ScreenResolution", GlassesColor2);
			GHHPOGODBHB().SetColor("_Value3", GlassColor);
			GHHPOGODBHB().SetFloat("_TimeX", UseScanLineSize);
			FLOHGDECHHH().SetFloat("#tryagain", UseScanLine);
			OLHDPICFBOF().SetTexture("_ScreenResolution", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MAOCOEGAFND()
	{
	}

	private void KFACDBHDAOD()
	{
	}

	private void IEFMONDKKJN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material OKJOKHGJHGF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)70;
		}
		return BJFKDHHMLJH;
	}

	private void IDJKNBDKHBD()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_TV_Noise") as Texture2D;
		SCShader = Shader.Find("Object ID. Case-Sensitive");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EHJJFJCKGAJ()
	{
	}

	[SpecialName]
	private Material FEAEGGCNIAA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void OKLAJINHPAN()
	{
		FPHEBLMINDA = Resources.Load("\t") as Texture2D;
		SCShader = Shader.Find("FrostCanvas");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KCCIEMBMOBA()
	{
		FPHEBLMINDA = Resources.Load(">") as Texture2D;
		SCShader = Shader.Find("_Radius");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material NBMPPNFKFLB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void BFEILOMHNPC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DLMPALHKMON()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material FLOHGDECHHH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void OOGIHDLBBLM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material DKKBFFHBHJE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return BJFKDHHMLJH;
	}

	private void LBIOIEANMGI()
	{
	}

	private void CNDACAHCCOI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material KEMJNOMIPHN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)122;
		}
		return BJFKDHHMLJH;
	}

	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1082f)
			{
				HBJJOCHGOPH = 1324f;
			}
			HNFFHCLNBDN().SetFloat("[Down]", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("STICKRVER", UseFinalGlassColor);
			FLOHGDECHHH().SetFloat("_Blur", Fade);
			PGPEMMBJOOG().SetFloat("_SunThreshold", VisionBlur);
			MLMKCOINOOH().SetFloat("_TimeX", GlassDistortion);
			IONHGBPGCHK().SetFloat("CameraFilterPack_3D_Myst1", GlassAberration);
			MFHPKGICPIO().SetColor("_FullResolutionFiltering", GlassesColor);
			OLHDPICFBOF().SetColor("_TimeX", GlassesColor2);
			NBMPPNFKFLB().SetColor("#creatingnewitem", GlassColor);
			FLOHGDECHHH().SetFloat("note.2", UseScanLineSize);
			OLHDPICFBOF().SetFloat("Mouse0", UseScanLine);
			OLHDPICFBOF().SetTexture("/", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HMNLHMLILKD()
	{
	}
}
