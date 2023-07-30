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
			IONHGBPGCHK().SetFloat("_Value6", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("CameraFilterPack/Blend2Camera_LighterColor", LightReflect);
			NBPKMLMCHFN.SetFloat("true", Blood1);
			HNICHJCGJOC().SetFloat("_Amount", Blood2);
			FHFLKLMFHOI().SetFloat("Failed to Destroy objects of playerId: ", Blood3);
			IONHGBPGCHK().SetFloat("InputField", Blood4);
			FHFLKLMFHOI().SetTexture("float,0", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
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
			HCGJCMDJPGD().SetFloat("_Vignette", HBJJOCHGOPH);
			NDMPCDHADMJ().SetFloat("<b>#", LightReflect);
			JFDGLLEOPGB().SetFloat("maps.", Blood1);
			NBPKMLMCHFN.SetFloat("_DiffuseColor", Blood2);
			LNLKMDPHDCC().SetFloat("_Fade", Blood3);
			JFDGLLEOPGB().SetFloat("SetScale", Blood4);
			HCGJCMDJPGD().SetTexture("DPADHOR", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DLBODOFAJGM()
	{
		FPHEBLMINDA = Resources.Load("\" gets executed locally only, if at all.") as Texture2D;
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
			JFDGLLEOPGB().SetFloat("Joystick1Button9", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat("1", LightReflect);
			FHFLKLMFHOI().SetFloat("[PhotonMessageInfo: Sender='{1}' Senttime={0}]", Blood1);
			FHFLKLMFHOI().SetFloat("duration", Blood2);
			JFDGLLEOPGB().SetFloat("1177138211", Blood3);
			HNICHJCGJOC().SetFloat("_Intensity", Blood4);
			HNICHJCGJOC().SetTexture("_ScreenResolution", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FHFLKLMFHOI());
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
			HNICHJCGJOC().SetFloat("_Glitch", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("settings.fps", LightReflect);
			NBPKMLMCHFN.SetFloat("AccuracyScoreText", Blood1);
			FHFLKLMFHOI().SetFloat("HandsCountSlider", Blood2);
			HCGJCMDJPGD().SetFloat("maps.", Blood3);
			LNLKMDPHDCC().SetFloat("_Value4", Blood4);
			NBPKMLMCHFN.SetTexture("_LightIntensity", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			NDMPCDHADMJ().SetFloat("SSAARenderTargetCamera", LightReflect);
			IONHGBPGCHK().SetFloat("steamid", Blood1);
			FHFLKLMFHOI().SetFloat("[PlayerController] ", Blood2);
			NDMPCDHADMJ().SetFloat("_Heigh", Blood3);
			NBPKMLMCHFN.SetFloat("Remove Environment Object", Blood4);
			NDMPCDHADMJ().SetTexture("_ScreenResolution", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
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
		SCShader = Shader.Find("_Value3");
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
			NDMPCDHADMJ().SetFloat("win", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("/music", LightReflect);
			LNLKMDPHDCC().SetFloat("CameraFilterPack/Pixelisation_OilPaint", Blood1);
			NDMPCDHADMJ().SetFloat("{0}", Blood2);
			NBPKMLMCHFN.SetFloat(": ", Blood3);
			FHFLKLMFHOI().SetFloat(" ", Blood4);
			NBPKMLMCHFN.SetTexture("musicVolume", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CHOPDIGHJNH()
	{
		FPHEBLMINDA = Resources.Load("CurrentTimeLabel") as Texture2D;
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
		SCShader = Shader.Find("L2");
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
		FPHEBLMINDA = Resources.Load(".lastCheckpoint.bgcolor") as Texture2D;
		SCShader = Shader.Find("L1");
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
		FPHEBLMINDA = Resources.Load("skin.") as Texture2D;
		SCShader = Shader.Find("Joystick1Button11");
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
			IONHGBPGCHK().SetFloat("[PlayerController] ", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat("/", LightReflect);
			HCGJCMDJPGD().SetFloat("ShowTitle", Blood1);
			HNICHJCGJOC().SetFloat("Set particles count per one beat", Blood2);
			NBPKMLMCHFN.SetFloat("_Value2", Blood3);
			NDMPCDHADMJ().SetFloat("_ScreenResolution", Blood4);
			HCGJCMDJPGD().SetTexture("Set Sun MaxSize", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
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
		FPHEBLMINDA = Resources.Load("cameramovements:") as Texture2D;
		SCShader = Shader.Find("RemoveHighlight");
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
			IONHGBPGCHK().SetFloat("settings.hitvariation", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("Failed to 'network-remove' GameObject because has no PhotonView components: ", LightReflect);
			HNICHJCGJOC().SetFloat("_MainTex2", Blood1);
			JFDGLLEOPGB().SetFloat("CreateRoom failed, client stays on masterserver: {0}.", Blood2);
			HNICHJCGJOC().SetFloat("CameraFilterPack/Colors_Brightness", Blood3);
			NDMPCDHADMJ().SetFloat("finished", Blood4);
			LNLKMDPHDCC().SetTexture("_NeighborMaxTex", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FANADGBGCPI()
	{
		FPHEBLMINDA = Resources.Load("Horizontal") as Texture2D;
		SCShader = Shader.Find(",viewkeys");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MKIMDFLBFOM()
	{
		FPHEBLMINDA = Resources.Load("1 Kb") as Texture2D;
		SCShader = Shader.Find("_Saturation");
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
			IONHGBPGCHK().SetFloat("CameraFilterPack/Vision_AuraDistortion", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("OpSetPropertiesOfActor()", LightReflect);
			NBPKMLMCHFN.SetFloat("SetParticlesEmission", Blood1);
			HNICHJCGJOC().SetFloat("https://www.youtube.com/watch?v=cDVXukrKo74", Blood2);
			FHFLKLMFHOI().SetFloat("PossibleMapMaxScoreText", Blood3);
			NDMPCDHADMJ().SetFloat("RB", Blood4);
			LNLKMDPHDCC().SetTexture(".highscore", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FHFLKLMFHOI());
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
			HNICHJCGJOC().SetFloat("OK", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat(".lastCheckpoint.comboScore", LightReflect);
			LNLKMDPHDCC().SetFloat("_Value3", Blood1);
			HCGJCMDJPGD().SetFloat("UseScanLineSize", Blood2);
			JFDGLLEOPGB().SetFloat("_Visualize", Blood3);
			HCGJCMDJPGD().SetFloat("_Value", Blood4);
			HNICHJCGJOC().SetTexture("LeaderboardsButton", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
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
		SCShader = Shader.Find("shader.future");
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
			IONHGBPGCHK().SetFloat("0.00", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat("Mid", LightReflect);
			HCGJCMDJPGD().SetFloat("EventSystem", Blood1);
			HCGJCMDJPGD().SetFloat("_TapMedium", Blood2);
			IONHGBPGCHK().SetFloat("ready", Blood3);
			JFDGLLEOPGB().SetFloat("CameraFilterPack/Drawing_Lines", Blood4);
			JFDGLLEOPGB().SetTexture("#rt", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
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
			LNLKMDPHDCC().SetFloat("Mouse", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("music", LightReflect);
			HCGJCMDJPGD().SetFloat("_NoiseScale", Blood1);
			HNICHJCGJOC().SetFloat("CameraFilterPack/FX_superDot", Blood2);
			HNICHJCGJOC().SetFloat("itemdefid[0]", Blood3);
			IONHGBPGCHK().SetFloat("CameraFilterPack/3D_Mirror", Blood4);
			HCGJCMDJPGD().SetTexture("You need to have a Graphic control (such as an Image) for the list [", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
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
