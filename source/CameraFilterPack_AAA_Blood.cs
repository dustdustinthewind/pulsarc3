// CameraFilterPack_AAA_Blood
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/AAA/Blood")]
[ExecuteInEditMode]
public class CameraFilterPack_AAA_Blood : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	[Range(0f, 128f)]
	public float Blood1;

	[Range(0f, 128f)]
	public float Blood2;

	[Range(0f, 128f)]
	public float Blood3;

	[Range(0f, 128f)]
	public float Blood4 = 1f;

	[Range(0f, 0.004f)]
	public float LightReflect = 0.002f;

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

	private void DFENCIHAADO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 433f)
			{
				HBJJOCHGOPH = 1285f;
			}
			HCGJCMDJPGD().SetFloat("_Value6", HBJJOCHGOPH);
			NDMPCDHADMJ().SetFloat("CameraFilterPack/Blend2Camera_Overlay", LightReflect);
			LNLKMDPHDCC().SetFloat(".completedMaps", Blood1);
			FHFLKLMFHOI().SetFloat("_MainTex2", Blood2);
			IONHGBPGCHK().SetFloat("Failed to 'network-remove' GameObject. Client is neither owner nor masterClient taking over for owner who left: ", Blood3);
			IONHGBPGCHK().SetFloat("ScrollPanel", Blood4);
			HCGJCMDJPGD().SetTexture("Scale environment object by the values", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1131f)
			{
				HBJJOCHGOPH = 395f;
			}
			HNICHJCGJOC().SetFloat("CameraFilterPack/Oculus_NightVision2", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("/files/editor_manual.pdf", LightReflect);
			NDMPCDHADMJ().SetFloat(".highscore", Blood1);
			NBPKMLMCHFN.SetFloat("FinishMap", Blood2);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", Blood3);
			NDMPCDHADMJ().SetFloat("Set Object Scale", Blood4);
			LNLKMDPHDCC().SetTexture("Mouse X", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DLBODOFAJGM()
	{
		FPHEBLMINDA = Resources.Load("RPCs can only be sent in rooms. Call of \"") as Texture2D;
		SCShader = Shader.Find("settings_bindings_controller_type");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HMPGIFBJFIK()
	{
		FPHEBLMINDA = Resources.Load("_TimeX") as Texture2D;
		SCShader = Shader.Find("Instrumental");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 964f)
			{
				HBJJOCHGOPH = 1487f;
			}
			JFDGLLEOPGB().SetFloat("Joystick1Button10", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("ScoreText", LightReflect);
			LNLKMDPHDCC().SetFloat("Error: you cannot write/send to this stream that you are reading!", Blood1);
			IONHGBPGCHK().SetFloat("in seconds. 0 - forever", Blood2);
			NDMPCDHADMJ().SetFloat("1234332714", Blood3);
			FHFLKLMFHOI().SetFloat("_BgFade", Blood4);
			HCGJCMDJPGD().SetTexture("CameraFilterPack/Drawing_Curve", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HCGJCMDJPGD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)77;
		}
		return BJFKDHHMLJH;
	}

	private void MAOCOEGAFND()
	{
	}

	private void DLMPALHKMON()
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
			if (HBJJOCHGOPH > 1066f)
			{
				HBJJOCHGOPH = 1892f;
			}
			NDMPCDHADMJ().SetFloat("_Noise", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("settings.fps", LightReflect);
			NBPKMLMCHFN.SetFloat("AccuracyScoreText", Blood1);
			NDMPCDHADMJ().SetFloat("Tab2Content", Blood2);
			HNICHJCGJOC().SetFloat(".played", Blood3);
			JFDGLLEOPGB().SetFloat("_ScreenResolution", Blood4);
			JFDGLLEOPGB().SetTexture("_LightIntensity", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FHFLKLMFHOI());
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
			NBPKMLMCHFN.SetFloat("_Value", LightReflect);
			NBPKMLMCHFN.SetFloat("_Value2", Blood1);
			NBPKMLMCHFN.SetFloat("_Value3", Blood2);
			NBPKMLMCHFN.SetFloat("_Value4", Blood3);
			NBPKMLMCHFN.SetFloat("_Value5", Blood4);
			NBPKMLMCHFN.SetTexture("_MainTex2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1372f)
			{
				HBJJOCHGOPH = 1857f;
			}
			NBPKMLMCHFN.SetFloat("_Value2", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Coroutine container not configured... did you forget to call Init?", LightReflect);
			FHFLKLMFHOI().SetFloat("mapid", Blood1);
			LNLKMDPHDCC().SetFloat(": ", Blood2);
			HCGJCMDJPGD().SetFloat("_Intervale", Blood3);
			FHFLKLMFHOI().SetFloat("Remove Environment Object", Blood4);
			IONHGBPGCHK().SetTexture("CameraFilterPack/Gradients_Hue", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LECCHIAFGGE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PLIKADJCEPO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material FHFLKLMFHOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)89;
		}
		return BJFKDHHMLJH;
	}

	private void FNCDAPDOBBI()
	{
		FPHEBLMINDA = Resources.Load("[GameScene] Checkpoints count: ") as Texture2D;
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1743f)
			{
				HBJJOCHGOPH = 562f;
			}
			LNLKMDPHDCC().SetFloat("settings.enablehitsoundsinrelax", HBJJOCHGOPH);
			NDMPCDHADMJ().SetFloat("music", LightReflect);
			LNLKMDPHDCC().SetFloat("_TimeX", Blood1);
			NBPKMLMCHFN.SetFloat(" - {0}", Blood2);
			LNLKMDPHDCC().SetFloat("x", Blood3);
			LNLKMDPHDCC().SetFloat(" ", Blood4);
			HCGJCMDJPGD().SetTexture("masterVolume", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CHOPDIGHJNH()
	{
		FPHEBLMINDA = Resources.Load("0.00") as Texture2D;
		SCShader = Shader.Find("DPADHOR");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void Update()
	{
	}

	private void FDPOFMCFBMF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LEAHIBJDMBI()
	{
	}

	private void ILCFPCIPENO()
	{
		FPHEBLMINDA = Resources.Load("/") as Texture2D;
		SCShader = Shader.Find("R2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FBMDHDBELEK()
	{
	}

	private void DNENFLNCIJP()
	{
	}

	private void DHENLPJJOEN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FKEJGBFDCAH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FGOPJMGNHGO()
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

	private void JDGFCEPDKAJ()
	{
	}

	private void Start()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_AAA_Blood1") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/AAA_Blood");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MMOKKAPFGAK()
	{
		FPHEBLMINDA = Resources.Load("maps.") as Texture2D;
		SCShader = Shader.Find("R1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BGFJOEPFOPM()
	{
	}

	private void BMIOFJFMCBG()
	{
		FPHEBLMINDA = Resources.Load(".icon") as Texture2D;
		SCShader = Shader.Find("Joystick1Button12");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.HideInInspector | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void BGDONBMDPGM()
	{
	}

	[SpecialName]
	private Material LNLKMDPHDCC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void EODOHEAKJFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1979f)
			{
				HBJJOCHGOPH = 148f;
			}
			HNICHJCGJOC().SetFloat(": ", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("https://bitbucket.org/khb-soft/intralismarcsviewer/", LightReflect);
			FHFLKLMFHOI().SetFloat("_DiffuseColor", Blood1);
			HCGJCMDJPGD().SetFloat("SetParticlesInput", Blood2);
			HNICHJCGJOC().SetFloat("_Value2", Blood3);
			NDMPCDHADMJ().SetFloat("_Value", Blood4);
			LNLKMDPHDCC().SetTexture("Set Sun MaxSize", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material NDMPCDHADMJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material JFDGLLEOPGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)81;
		}
		return BJFKDHHMLJH;
	}

	private void LADCJEIALMH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GPHPJIDGEPI()
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void PAKPHKPDKGE()
	{
		FPHEBLMINDA = Resources.Load("settings.cameramovements") as Texture2D;
		SCShader = Shader.Find("The other scroll rect doesnt support scrolling horizontally");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MJNPIDGNJMK()
	{
	}

	private void CCPEDDLAMIB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1427f)
			{
				HBJJOCHGOPH = 209f;
			}
			NDMPCDHADMJ().SetFloat("]", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("Failed to 'network-remove' GameObject because it is missing a valid InstantiationId on view: ", LightReflect);
			HCGJCMDJPGD().SetFloat("CameraFilterPack_Glasses_On6", Blood1);
			FHFLKLMFHOI().SetFloat("JoinRandom failed: No open game. Calling: OnPhotonRandomJoinFailed() and staying on master server.", Blood2);
			NBPKMLMCHFN.SetFloat("_Val", Blood3);
			HNICHJCGJOC().SetFloat("ShowSprite", Blood4);
			LNLKMDPHDCC().SetTexture("Hidden/Image Effects/Cinematic/MotionBlur/FrameBlending", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FANADGBGCPI()
	{
		FPHEBLMINDA = Resources.Load("There is already a virtual axis named ") as Texture2D;
		SCShader = Shader.Find("[ResourcesManager] Unloading data resources");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MKIMDFLBFOM()
	{
		FPHEBLMINDA = Resources.Load(" Kb") as Texture2D;
		SCShader = Shader.Find("_StretchWidth");
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
			if (HBJJOCHGOPH > 927f)
			{
				HBJJOCHGOPH = 1099f;
			}
			FHFLKLMFHOI().SetFloat("_TimeX", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("OpAuthenticate()", LightReflect);
			JFDGLLEOPGB().SetFloat("Set Particles Emission", Blood1);
			NBPKMLMCHFN.SetFloat("#ok", Blood2);
			IONHGBPGCHK().SetFloat("PossibleMapMaxScoreText", Blood3);
			NBPKMLMCHFN.SetFloat("LT", Blood4);
			HNICHJCGJOC().SetTexture("[PlayerBase] Highscore: ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1126f)
			{
				HBJJOCHGOPH = 1604f;
			}
			HNICHJCGJOC().SetFloat("EventSystem", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat(".lastCheckpoint.playerdistance", LightReflect);
			HCGJCMDJPGD().SetFloat("_Value3", Blood1);
			HNICHJCGJOC().SetFloat("UseScanLine", Blood2);
			NDMPCDHADMJ().SetFloat("_Visualize", Blood3);
			JFDGLLEOPGB().SetFloat("_Value2", Blood4);
			LNLKMDPHDCC().SetTexture("FavoriteButton", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IFJDKDFLGBG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GHILDCBCDJI()
	{
	}

	private void NJHJHBOJKIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ANCKKLFPGDI()
	{
		FPHEBLMINDA = Resources.Load("Drop_Far") as Texture2D;
		SCShader = Shader.Find("shader.invert");
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
			if (HBJJOCHGOPH > 1283f)
			{
				HBJJOCHGOPH = 782f;
			}
			FHFLKLMFHOI().SetFloat("[MapEditor] Loading map: ", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("Mid", LightReflect);
			HCGJCMDJPGD().SetFloat("EventSystem", Blood1);
			NDMPCDHADMJ().SetFloat("_TapMedium", Blood2);
			JFDGLLEOPGB().SetFloat("ready", Blood3);
			FHFLKLMFHOI().SetFloat("CameraFilterPack/Drawing_Lines", Blood4);
			FHFLKLMFHOI().SetTexture("Horizontal", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LLJLDLLNFBH()
	{
	}

	private void HGDDCINLDAD()
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

	private void IMGGCJICLHK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 846f)
			{
				HBJJOCHGOPH = 137f;
			}
			IONHGBPGCHK().SetFloat("Mouse", HBJJOCHGOPH);
			FHFLKLMFHOI().SetFloat("/", LightReflect);
			JFDGLLEOPGB().SetFloat("_TexelOffsetScale", Blood1);
			HNICHJCGJOC().SetFloat("_TimeX", Blood2);
			HCGJCMDJPGD().SetFloat("[ItemsHandler] All in-game items loaded", Blood3);
			HNICHJCGJOC().SetFloat("CameraFilterPack/3D_Mirror", Blood4);
			LNLKMDPHDCC().SetTexture("Event Received", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FABMDEHEDNO()
	{
	}

	private void JHLGHODFJOO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}
}
