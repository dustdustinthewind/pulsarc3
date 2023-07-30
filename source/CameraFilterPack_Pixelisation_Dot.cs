// CameraFilterPack_Pixelisation_Dot
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Pixelisation/Dot")]
public class CameraFilterPack_Pixelisation_Dot : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0.0001f, 0.5f)]
	public float Size = 0.005f;

	[Range(0f, 1f)]
	public float LightBackGround = 0.3f;

	[Range(0f, 10f)]
	private float PAGBLHHLIGC = 1f;

	[Range(0f, 10f)]
	private float JBLCJOHIFGG = 1f;

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

	private void BFGIMALGMAJ()
	{
	}

	private void NBGIMIDICKE()
	{
		SCShader = Shader.Find("\" marked with the [PunRPC](C#) or @PunRPC(JS) property! Args: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 193f)
			{
				HBJJOCHGOPH = 1999f;
			}
			NBPKMLMCHFN.SetFloat("\" that takes ", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("[NetworkManager] Connection failed: ", Size);
			GJHPODJOBHL().SetFloat("ComboScoreText", LightBackGround);
			LPMLLJKMAMP().SetFloat("_TimeX", PAGBLHHLIGC);
			LONNIJMNKFB().SetFloat("EnvironmentSlider", JBLCJOHIFGG);
			OIBHFCLJKDB().SetVector("Gameplay/satellite", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 350f, 16f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MKFLBEGJJDC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HLDFOJMHKNL()
	{
	}

	private void HAIAHJPCPAG()
	{
		SCShader = Shader.Find("LevelProgressBar");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NKLIHNJCHOG()
	{
	}

	private void ABEIEGDHBNO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material KAFBNOBOIAJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)120;
		}
		return BJFKDHHMLJH;
	}

	private void FMFNILJIEIA()
	{
		SCShader = Shader.Find("RemoveEnvironmentObject");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void POIMNOBDBBN()
	{
	}

	private void DFENCIHAADO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 384f)
			{
				HBJJOCHGOPH = 1861f;
			}
			NLFJGMBCICG().SetFloat("[EditorEvent] Exception: ", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("[Up-Right]", Size);
			NJDIODJNGGA().SetFloat("OK", LightBackGround);
			NBPKMLMCHFN.SetFloat("EditMenu", PAGBLHHLIGC);
			INOBFNCKFGK().SetFloat("scenes", JBLCJOHIFGG);
			KAFBNOBOIAJ().SetVector("settings.volume.menu", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 419f, 1038f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FHGKIOOMMOH()
	{
		SCShader = Shader.Find("icon.png");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PLEOOAJIMEE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1431f)
			{
				HBJJOCHGOPH = 1938f;
			}
			KOHGPKOFEJO().SetFloat("[PlayerBase] SetPlayerDistance error: ", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("_Value2", Size);
			CFEDGDGBCHE().SetFloat("http", LightBackGround);
			INOBFNCKFGK().SetFloat("#kicked", PAGBLHHLIGC);
			OGMEGHKECAH().SetFloat("float,0", JBLCJOHIFGG);
			GKILCDHJFEG().SetVector("VisionBlur", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 452f, 798f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DHNGNHGDPLM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 62f)
			{
				HBJJOCHGOPH = 425f;
			}
			INOBFNCKFGK().SetFloat("LevelNameText", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("Submit", Size);
			KOHGPKOFEJO().SetFloat("DPADVER", LightBackGround);
			IGKFMCPDNOI().SetFloat("GameScene", PAGBLHHLIGC);
			INOBFNCKFGK().SetFloat("_TimeX", JBLCJOHIFGG);
			DEFBJOCJJKF().SetVector("0,1,false", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 270f, 1682f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHPODJOBHL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material FGENHBKMPDA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	private void FANADGBGCPI()
	{
		SCShader = Shader.Find("ItemNameBGImage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 545f)
			{
				HBJJOCHGOPH = 942f;
			}
			IGKFMCPDNOI().SetFloat("[Right-Down]", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("0,1,false", Size);
			IGKFMCPDNOI().SetFloat("couldn't be found!", LightBackGround);
			NBPKMLMCHFN.SetFloat("_SunColor", PAGBLHHLIGC);
			DEFBJOCJJKF().SetFloat("_ScreenResolution", JBLCJOHIFGG);
			LDNADDJMIPK().SetVector("id", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 282f, 109f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BKKJJJGADLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1916f)
			{
				HBJJOCHGOPH = 1366f;
			}
			KAFBNOBOIAJ().SetFloat("Missing shader in ", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("workshop.", Size);
			LONNIJMNKFB().SetFloat("player.greenlifering", LightBackGround);
			DNLMFEGJJDD().SetFloat("_Value2", PAGBLHHLIGC);
			IGKFMCPDNOI().SetFloat("GlassDistortion", JBLCJOHIFGG);
			INOBFNCKFGK().SetVector("_EmissionGain", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 866f, 1125f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material NLFJGMBCICG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideAndDontSave | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1211f)
			{
				HBJJOCHGOPH = 245f;
			}
			NJDIODJNGGA().SetFloat("Items", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("_Value2", Size);
			NLFJGMBCICG().SetFloat("\n", LightBackGround);
			BKKJJJGADLM().SetFloat("settings.arcsnohitsoundtimedelay", PAGBLHHLIGC);
			KOHGPKOFEJO().SetFloat("ViewMenu", JBLCJOHIFGG);
			LPMLLJKMAMP().SetVector("menu.selectedlevelid", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 116f, 535f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FDNONDCGGCG()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 836f)
			{
				HBJJOCHGOPH = 433f;
			}
			GKILCDHJFEG().SetFloat("ResourceFileSelector", HBJJOCHGOPH);
			GJHPODJOBHL().SetFloat("_MainTex2", Size);
			DNLMFEGJJDD().SetFloat("#91CCFF", LightBackGround);
			LONNIJMNKFB().SetFloat("_HdrParams", PAGBLHHLIGC);
			IGKFMCPDNOI().SetFloat("_Value2", JBLCJOHIFGG);
			LDNADDJMIPK().SetVector("note.6", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 95f, 528f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FIKFJDFELIP()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FJNCHGLIEMA()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1133f)
			{
				HBJJOCHGOPH = 1217f;
			}
			BKKJJJGADLM().SetFloat("[ItemsHandler] Found ", HBJJOCHGOPH);
			GJHPODJOBHL().SetFloat("_Value3", Size);
			OIBHFCLJKDB().SetFloat("ticket", LightBackGround);
			NLFJGMBCICG().SetFloat("SupportLogger OnCreatedRoom(", PAGBLHHLIGC);
			BKKJJJGADLM().SetFloat("[Singleton] Using instance of '", JBLCJOHIFGG);
			LDNADDJMIPK().SetVector("A", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1797f, 1053f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BKKJJJGADLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material BKKJJJGADLM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)83;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IGKFMCPDNOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)122;
		}
		return BJFKDHHMLJH;
	}

	private void IBFJAOINHMK()
	{
	}

	[SpecialName]
	private Material OIBHFCLJKDB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)67;
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

	private void LFBGJIIECLD()
	{
		SCShader = Shader.Find("Loading inventory");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MANDOGNJJBD()
	{
	}

	[SpecialName]
	private Material LONNIJMNKFB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KOHGPKOFEJO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material INOBFNCKFGK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)93;
		}
		return BJFKDHHMLJH;
	}

	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 105f)
			{
				HBJJOCHGOPH = 776f;
			}
			KOHGPKOFEJO().SetFloat("_ColorR", HBJJOCHGOPH);
			FGENHBKMPDA().SetFloat("_TimeX", Size);
			OGMEGHKECAH().SetFloat("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.", LightBackGround);
			GJHLADDCMFF().SetFloat(" ", PAGBLHHLIGC);
			BKKJJJGADLM().SetFloat("Type of observed is unknown when receiving.", JBLCJOHIFGG);
			GKILCDHJFEG().SetVector("896296812", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 841f, 1140f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GLEJGFLCLPJ()
	{
		SCShader = Shader.Find("#FFFFFFFF");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LIEGJOHINGC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NKFDNIAKGEO()
	{
		SCShader = Shader.Find(">");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
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
			NBPKMLMCHFN.SetFloat("_Value", Size);
			NBPKMLMCHFN.SetFloat("_Value2", LightBackGround);
			NBPKMLMCHFN.SetFloat("_Value3", PAGBLHHLIGC);
			NBPKMLMCHFN.SetFloat("_Value4", JBLCJOHIFGG);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JBCNIPJDPJB()
	{
	}

	private void FHPFJBFCOOF()
	{
		SCShader = Shader.Find("Parameter levelId can't be null!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material DNLMFEGJJDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)92;
		}
		return BJFKDHHMLJH;
	}

	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 546f)
			{
				HBJJOCHGOPH = 916f;
			}
			LPMLLJKMAMP().SetFloat("#tryagain", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat("id", Size);
			KOHGPKOFEJO().SetFloat("[PlayerController] ", LightBackGround);
			GKILCDHJFEG().SetFloat("Set Particles Input", PAGBLHHLIGC);
			FGENHBKMPDA().SetFloat("PlayButton", JBLCJOHIFGG);
			BKKJJJGADLM().SetVector("EventMenu", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1733f, 81f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MMOKKAPFGAK()
	{
		SCShader = Shader.Find("InfoCanvas");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AGMJDGHLBMN()
	{
	}

	private void ABIOAMNCEOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 873f)
			{
				HBJJOCHGOPH = 483f;
			}
			FGENHBKMPDA().SetFloat("HightScoreMaxPointsText", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("_WhiteBalance", Size);
			GJHPODJOBHL().SetFloat("_TimeX", LightBackGround);
			LDNADDJMIPK().SetFloat("workshop.", PAGBLHHLIGC);
			IGKFMCPDNOI().SetFloat("_Value5", JBLCJOHIFGG);
			LONNIJMNKFB().SetVector("_Value4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 505f, 1241f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IABLKKAALGI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
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

	private void PHJJHFBLICM()
	{
	}

	[SpecialName]
	private Material LDNADDJMIPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-1);
		}
		return BJFKDHHMLJH;
	}

	private void GKNKIIEALCH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MKOMIDCPCDC()
	{
		SCShader = Shader.Find("DPADHOR");
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

	private void MMMDPANNAIO()
	{
		SCShader = Shader.Find("position");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1923f)
			{
				HBJJOCHGOPH = 1422f;
			}
			LONNIJMNKFB().SetFloat("Hidden/Image Effects/Cinematic/MotionBlur/FrameBlending", HBJJOCHGOPH);
			FGENHBKMPDA().SetFloat("). ", Size);
			OGMEGHKECAH().SetFloat("</color>", LightBackGround);
			CFEDGDGBCHE().SetFloat("<b>Speed</b>:", PAGBLHHLIGC);
			DEFBJOCJJKF().SetFloat("[", JBLCJOHIFGG);
			NLFJGMBCICG().SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1922f, 1956f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NDBPCNICGLC()
	{
		SCShader = Shader.Find("gamemode");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OKHBBIKDIEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1583f)
			{
				HBJJOCHGOPH = 1105f;
			}
			NJDIODJNGGA().SetFloat("_Visualize", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("CameraFilterPack/Distortion_Twist_Square", Size);
			KOHGPKOFEJO().SetFloat("_Intensity", LightBackGround);
			GJHPODJOBHL().SetFloat("_Vignette_Alpha", PAGBLHHLIGC);
			NBPKMLMCHFN.SetFloat("/GetNews/pinnednewsid", JBLCJOHIFGG);
			CFEDGDGBCHE().SetVector("OnEvent: {0}", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1657f, 714f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KNBJBNDGCIJ()
	{
		SCShader = Shader.Find("_Contrast");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ADPLHDFJFID()
	{
		SCShader = Shader.Find("] to be droppable");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EAHCLIEEJOG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JNBPKNNBMDI()
	{
	}

	private void DIPDEHOOBPG()
	{
		SCShader = Shader.Find("_MaxRayTraceDistance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CACCPBENDAP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1692f)
			{
				HBJJOCHGOPH = 824f;
			}
			NLFJGMBCICG().SetFloat("ticket.ticket1", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("GraphicsQualitySlider", Size);
			DEFBJOCJJKF().SetFloat("Tab2Content", LightBackGround);
			KOHGPKOFEJO().SetFloat("itemid", PAGBLHHLIGC);
			IGKFMCPDNOI().SetFloat("#onfirstranktext", JBLCJOHIFGG);
			INOBFNCKFGK().SetVector("CameraFilterPack/Drawing_Manga_FlashWhite", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 984f, 274f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PDHKMDBNGGN()
	{
		SCShader = Shader.Find("CameraFilterPack/Blend2Camera_SplitScreen3D");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LPMINJJPDCH()
	{
	}

	private void ODBNMPGBCGO()
	{
		SCShader = Shader.Find("Image");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IBHACCEEFFI()
	{
	}

	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 193f)
			{
				HBJJOCHGOPH = 138f;
			}
			OIBHFCLJKDB().SetFloat("Scrollbar", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat(" from: ", Size);
			LPMLLJKMAMP().SetFloat("event", LightBackGround);
			FGENHBKMPDA().SetFloat("_TimeX", PAGBLHHLIGC);
			INOBFNCKFGK().SetFloat("_Value4", JBLCJOHIFGG);
			NBPKMLMCHFN.SetVector("No regions available. Are you sure your appid is valid and setup?", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1373f, 1894f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1f)
			{
				HBJJOCHGOPH = 606f;
			}
			KAFBNOBOIAJ().SetFloat("Texture2", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat(".", Size);
			NJDIODJNGGA().SetFloat("settings.volume.sfx", LightBackGround);
			KOHGPKOFEJO().SetFloat("<color=#{0}>{1}</color>", PAGBLHHLIGC);
			GJHPODJOBHL().SetFloat("value", JBLCJOHIFGG);
			DNLMFEGJJDD().SetVector("ShowSprite", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 439f, 1322f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ECBILENEOOL()
	{
		SCShader = Shader.Find("s");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NAOLAJPDGIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JEBIBKLHFLB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material DEFBJOCJJKF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-103);
		}
		return BJFKDHHMLJH;
	}

	private void MKIFJMPELJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1150f)
			{
				HBJJOCHGOPH = 1988f;
			}
			CFEDGDGBCHE().SetFloat("_TimeX", HBJJOCHGOPH);
			INOBFNCKFGK().SetFloat("Joystick1Button10", Size);
			BKKJJJGADLM().SetFloat(".lastCheckpoint.time", LightBackGround);
			DNLMFEGJJDD().SetFloat("_Value5", PAGBLHHLIGC);
			GKILCDHJFEG().SetFloat("_TimeX", JBLCJOHIFGG);
			LDNADDJMIPK().SetVector("offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 497f, 1654f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FGNFILLNPJK()
	{
	}

	private void JBNPEHMDCMI()
	{
	}

	[SpecialName]
	private Material CFEDGDGBCHE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave;
		}
		return BJFKDHHMLJH;
	}

	private void EDPDMBFLHLP()
	{
		SCShader = Shader.Find("Loading...");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AIJGAJIOJDJ()
	{
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Pixelisation_Dot");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material LPMLLJKMAMP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)80;
		}
		return BJFKDHHMLJH;
	}

	private void GAOOPEEBGJA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material GJHPODJOBHL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)66;
		}
		return BJFKDHHMLJH;
	}

	private void HIPEHGNBJMN()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KCDOMIJBFLL()
	{
	}

	private void PBEPCAPAKLG()
	{
	}

	[SpecialName]
	private Material GJHLADDCMFF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-69);
		}
		return BJFKDHHMLJH;
	}

	private void MECJHOJPODB()
	{
	}

	private void DKOPKPBLDHH()
	{
		SCShader = Shader.Find("settings.disablestoryboard");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void Update()
	{
	}

	private void LCHBFNIPBHB()
	{
	}

	[SpecialName]
	private Material NJDIODJNGGA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void JFJLGJEPEAA()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FOMNCPKKCFN()
	{
	}

	private void HIKKPDACJGI()
	{
	}

	private void ALJEJJCIMJN()
	{
		SCShader = Shader.Find("LastNewsButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GPFJMKCGHGB()
	{
	}

	[SpecialName]
	private Material OGMEGHKECAH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)102;
		}
		return BJFKDHHMLJH;
	}

	private void CNGAJDBOCLJ()
	{
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1798f)
			{
				HBJJOCHGOPH = 1262f;
			}
			FGENHBKMPDA().SetFloat("maphash", HBJJOCHGOPH);
			NJDIODJNGGA().SetFloat("_Value4", Size);
			LPMLLJKMAMP().SetFloat("_ScreenResolution", LightBackGround);
			CFEDGDGBCHE().SetFloat("_Visualize", PAGBLHHLIGC);
			KAFBNOBOIAJ().SetFloat("\" error: ", JBLCJOHIFGG);
			DEFBJOCJJKF().SetVector("{\"items\":", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 543f, 20f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HMNLHMLILKD()
	{
	}

	private void DDFCIOMKEEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1693f)
			{
				HBJJOCHGOPH = 1917f;
			}
			KAFBNOBOIAJ().SetFloat("]", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("PhotonNetwork error: Could not Instantiate the prefab [", Size);
			GJHLADDCMFF().SetFloat("_TimeX", LightBackGround);
			LONNIJMNKFB().SetFloat("value", PAGBLHHLIGC);
			LDNADDJMIPK().SetFloat("RarityImage", JBLCJOHIFGG);
			CFEDGDGBCHE().SetVector("CameraFilterPack/NightVisionFX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1440f, 1883f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1123f)
			{
				HBJJOCHGOPH = 1493f;
			}
			FGENHBKMPDA().SetFloat("_MainTex2", HBJJOCHGOPH);
			LPMLLJKMAMP().SetFloat("Jazz", Size);
			NBPKMLMCHFN.SetFloat("_FarCamera", LightBackGround);
			NLFJGMBCICG().SetFloat("_TimeX", PAGBLHHLIGC);
			OGMEGHKECAH().SetFloat("_Value3", JBLCJOHIFGG);
			OGMEGHKECAH().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1783f, 223f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ODAIMOJLJOF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 631f)
			{
				HBJJOCHGOPH = 809f;
			}
			BKKJJJGADLM().SetFloat("PointsScoreText", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value3", Size);
			NJDIODJNGGA().SetFloat("' has been reset to the fault value", LightBackGround);
			INOBFNCKFGK().SetFloat("#tryagain", PAGBLHHLIGC);
			DNLMFEGJJDD().SetFloat(": ", JBLCJOHIFGG);
			CFEDGDGBCHE().SetVector("_ToneCurveRange", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1609f, 1083f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HNGHDAPKEJG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MNBPNHNAEBK()
	{
		SCShader = Shader.Find("CameraFilterPack/Blend2Camera_Subtract");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DDBOODLPCAM()
	{
	}

	[SpecialName]
	private Material GKILCDHJFEG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInHierarchy);
		}
		return BJFKDHHMLJH;
	}

	private void LBPHCAMMAPB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KOJKBFDNGDK()
	{
		SCShader = Shader.Find("AvatarImage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JCGMGLMADEN()
	{
	}

	private void DOKAKEMDALN()
	{
		SCShader = Shader.Find("Netw. Sim.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JOACBIEHHCE()
	{
	}

	private void ABFNJCEBIKA()
	{
	}

	private void LINKAMEPKGM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IIFCIDDJHPM()
	{
	}

	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1006f)
			{
				HBJJOCHGOPH = 1127f;
			}
			NBPKMLMCHFN.SetFloat("_MainTex2", HBJJOCHGOPH);
			LDNADDJMIPK().SetFloat("_SubsampleIndices", Size);
			OIBHFCLJKDB().SetFloat(".", LightBackGround);
			LONNIJMNKFB().SetFloat("https://steamcommunity.com/sharedfiles/filedetails/?id=", PAGBLHHLIGC);
			INOBFNCKFGK().SetFloat(" TimeOfRespawn: ", JBLCJOHIFGG);
			BKKJJJGADLM().SetVector("Tab2Content", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 990f, 47f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CCFEDENFNEF()
	{
		SCShader = Shader.Find("open");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}
}
