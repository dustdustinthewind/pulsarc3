// CameraFilterPack_Pixelisation_Dot
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Pixelisation/Dot")]
[ExecuteInEditMode]
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
		SCShader = Shader.Find("\" that takes ");
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
			GJHPODJOBHL().SetFloat(". Should be just one?", HBJJOCHGOPH);
			OIBHFCLJKDB().SetFloat("[NetworkManager] Connection failed: ", Size);
			BKKJJJGADLM().SetFloat("ComboScoreText", LightBackGround);
			LDNADDJMIPK().SetFloat("_TimeX", PAGBLHHLIGC);
			NLFJGMBCICG().SetFloat("HandsCountSlider", JBLCJOHIFGG);
			INOBFNCKFGK().SetVector("[PlayerBase] Loaded custom model: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 350f, 16f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
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
		SCShader = Shader.Find("SetScale");
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
			IGKFMCPDNOI().SetFloat("[EditorEvent] Exception: ", HBJJOCHGOPH);
			GJHLADDCMFF().SetFloat("[Up-Right]", Size);
			DNLMFEGJJDD().SetFloat("OK", LightBackGround);
			GJHPODJOBHL().SetFloat("FileMenu", PAGBLHHLIGC);
			GKILCDHJFEG().SetFloat("loadscene", JBLCJOHIFGG);
			NLFJGMBCICG().SetVector("settings.volume.game", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 419f, 1038f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FHGKIOOMMOH()
	{
		SCShader = Shader.Find("No Name");
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
			DNLMFEGJJDD().SetFloat("[PlayerBase] ShowTitle error: ", HBJJOCHGOPH);
			NJDIODJNGGA().SetFloat("_Value4", Size);
			LDNADDJMIPK().SetFloat("skin.", LightBackGround);
			LPMLLJKMAMP().SetFloat("#ok", PAGBLHHLIGC);
			LDNADDJMIPK().SetFloat("Scale environment object by the values", JBLCJOHIFGG);
			OGMEGHKECAH().SetVector("GlassDistortion", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 452f, 798f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
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
			GJHLADDCMFF().SetFloat("workshop.", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("Warning, using scrollbors with the Scroll Snap controls is not advised as it causes unpredictable results", Size);
			NLFJGMBCICG().SetFloat("DPADHOR", LightBackGround);
			GJHLADDCMFF().SetFloat("GameScene", PAGBLHHLIGC);
			NBPKMLMCHFN.SetFloat("_Value2", JBLCJOHIFGG);
			OIBHFCLJKDB().SetVector("0,1,false", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 270f, 1682f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
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
		SCShader = Shader.Find("ItemNameText");
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
			LONNIJMNKFB().SetFloat("[Right-Down]", HBJJOCHGOPH);
			INOBFNCKFGK().SetFloat("0,1,false", Size);
			OIBHFCLJKDB().SetFloat("DontDestroy", LightBackGround);
			NBPKMLMCHFN.SetFloat("_ColorBuffer", PAGBLHHLIGC);
			GJHPODJOBHL().SetFloat("CameraFilterPack/Distortion_Twist_Square", JBLCJOHIFGG);
			LPMLLJKMAMP().SetVector("id", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 282f, 109f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			GJHPODJOBHL().SetFloat(" on effect ", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat("workshop.", Size);
			BKKJJJGADLM().SetFloat("player.greenlifering", LightBackGround);
			NJDIODJNGGA().SetFloat("_ScreenResolution", PAGBLHHLIGC);
			KOHGPKOFEJO().SetFloat("GlassAberration", JBLCJOHIFGG);
			IGKFMCPDNOI().SetVector("Items/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 866f, 1125f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHPODJOBHL());
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
			FGENHBKMPDA().SetFloat("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("_Value3", Size);
			NJDIODJNGGA().SetFloat("\t", LightBackGround);
			NJDIODJNGGA().SetFloat("settings.arcshitsoundtimedelay", PAGBLHHLIGC);
			NBPKMLMCHFN.SetFloat("ViewMenu", JBLCJOHIFGG);
			OIBHFCLJKDB().SetVector("menu.selectedplaymode", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 116f, 535f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FDNONDCGGCG()
	{
		SCShader = Shader.Find("_Amount");
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
			CFEDGDGBCHE().SetFloat("Edited event", HBJJOCHGOPH);
			GJHPODJOBHL().SetFloat("_Near", Size);
			LDNADDJMIPK().SetFloat(":\n", LightBackGround);
			DEFBJOCJJKF().SetFloat("No valid adaptive tonemapper type found!", PAGBLHHLIGC);
			NLFJGMBCICG().SetFloat("_Value3", JBLCJOHIFGG);
			CFEDGDGBCHE().SetVector("settings.cameramovements", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 95f, 528f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
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
		SCShader = Shader.Find("CameraFilterPack/TV_Noise");
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
			GKILCDHJFEG().SetFloat("3;4;9;10;21x6", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("_Value3", Size);
			GJHLADDCMFF().SetFloat("error", LightBackGround);
			OGMEGHKECAH().SetFloat(" GameServer:", PAGBLHHLIGC);
			IGKFMCPDNOI().SetFloat("[Singleton] An instance of '", JBLCJOHIFGG);
			BKKJJJGADLM().SetVector("Joystick1Button2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1797f, 1053f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NJDIODJNGGA());
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
		SCShader = Shader.Find("LoadingStatusText");
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
			LPMLLJKMAMP().SetFloat("_ColorG", HBJJOCHGOPH);
			FGENHBKMPDA().SetFloat("_Value", Size);
			OGMEGHKECAH().SetFloat("ns", LightBackGround);
			DNLMFEGJJDD().SetFloat("OpenButton", PAGBLHHLIGC);
			CFEDGDGBCHE().SetFloat("The observed monobehaviour (", JBLCJOHIFGG);
			BKKJJJGADLM().SetVector("1087340967", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 841f, 1140f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
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
		SCShader = Shader.Find("</color>");
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
		SCShader = Shader.Find("curScn");
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
			LONNIJMNKFB().SetFloat("bad", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("Object ID. Case-Sensitive", Size);
			NLFJGMBCICG().SetFloat(": ", LightBackGround);
			DNLMFEGJJDD().SetFloat("id", PAGBLHHLIGC);
			IGKFMCPDNOI().SetFloat("PlayButton", JBLCJOHIFGG);
			NJDIODJNGGA().SetVector("ViewMenu", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1733f, 81f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MMOKKAPFGAK()
	{
		SCShader = Shader.Find("ItemsCountText");
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
			LONNIJMNKFB().SetFloat("HightScoreMaxPointsText", HBJJOCHGOPH);
			INOBFNCKFGK().SetFloat("_Gamma", Size);
			OGMEGHKECAH().SetFloat("_TimeX", LightBackGround);
			CFEDGDGBCHE().SetFloat(" not found", PAGBLHHLIGC);
			CFEDGDGBCHE().SetFloat("_ScreenResolution", JBLCJOHIFGG);
			OIBHFCLJKDB().SetVector("CameraFilterPack/Vision_Psycho", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 505f, 1241f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
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
		SCShader = Shader.Find("0 - background, 1 - foreground");
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
			FGENHBKMPDA().SetFloat("_History2LumaTex", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("). ", Size);
			DEFBJOCJJKF().SetFloat("</color>", LightBackGround);
			LPMLLJKMAMP().SetFloat("<b>HP</b>:", PAGBLHHLIGC);
			KOHGPKOFEJO().SetFloat("[", JBLCJOHIFGG);
			LDNADDJMIPK().SetVector("#outdatedmap! Challenges will not work!", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1922f, 1956f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NDBPCNICGLC()
	{
		SCShader = Shader.Find("maphash");
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
			KOHGPKOFEJO().SetFloat("_Visualize", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat("CameraFilterPack/Distortion_Twist_Square", Size);
			NJDIODJNGGA().SetFloat("_Extra", LightBackGround);
			OIBHFCLJKDB().SetFloat("_Distortion", PAGBLHHLIGC);
			LONNIJMNKFB().SetFloat("Winter2020", JBLCJOHIFGG);
			KOHGPKOFEJO().SetVector("Ev OwnershipRequest ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1657f, 714f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
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
		SCShader = Shader.Find("Hello World, is my item a clone? [");
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
		SCShader = Shader.Find("_LayerThickness");
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
			DEFBJOCJJKF().SetFloat("ticket.ticket1", HBJJOCHGOPH);
			NJDIODJNGGA().SetFloat("GraphicsQualitySlider", Size);
			LPMLLJKMAMP().SetFloat("HandsCountSlider", LightBackGround);
			IGKFMCPDNOI().SetFloat("bad", PAGBLHHLIGC);
			GKILCDHJFEG().SetFloat("#onrankchangeuptext", JBLCJOHIFGG);
			GKILCDHJFEG().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 984f, 274f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
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
		SCShader = Shader.Find("[ItemsHandler] No connection to item server: ");
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
			IGKFMCPDNOI().SetFloat("Items", HBJJOCHGOPH);
			BKKJJJGADLM().SetFloat(" to: ", Size);
			DEFBJOCJJKF().SetFloat("event", LightBackGround);
			GJHPODJOBHL().SetFloat("_Value", PAGBLHHLIGC);
			BKKJJJGADLM().SetFloat("_Value4", JBLCJOHIFGG);
			LPMLLJKMAMP().SetVector(". Calling ConnectToRegionMaster() is: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1373f, 1894f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
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
			NLFJGMBCICG().SetFloat("CameraFilterPack_TV_Noise3", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat(".lastCheckpoint.lives", Size);
			CFEDGDGBCHE().SetFloat("settings.enablehitsoundsinrelax", LightBackGround);
			OGMEGHKECAH().SetFloat("<color=#{0}>{1}</color>", PAGBLHHLIGC);
			OGMEGHKECAH().SetFloat("value", JBLCJOHIFGG);
			GJHPODJOBHL().SetVector("Show Image", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 439f, 1322f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, INOBFNCKFGK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ECBILENEOOL()
	{
		SCShader = Shader.Find(", ");
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
			INOBFNCKFGK().SetFloat("_DotSize", HBJJOCHGOPH);
			BKKJJJGADLM().SetFloat("Joystick1Button11", Size);
			KAFBNOBOIAJ().SetFloat(".lastCheckpoint.correctScore", LightBackGround);
			NJDIODJNGGA().SetFloat("_Value6", PAGBLHHLIGC);
			LPMLLJKMAMP().SetFloat("_ScreenResolution", JBLCJOHIFGG);
			INOBFNCKFGK().SetVector("offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 497f, 1654f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
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
		SCShader = Shader.Find("<b>");
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
		SCShader = Shader.Find("_OnOff");
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
		SCShader = Shader.Find("SelectorMusicToggle");
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
		SCShader = Shader.Find("_Value");
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
		SCShader = Shader.Find("_Value2");
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
			INOBFNCKFGK().SetFloat("difficulty", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("_Value5", Size);
			DNLMFEGJJDD().SetFloat("CameraFilterPack/Oculus_ThermaVision", LightBackGround);
			KAFBNOBOIAJ().SetFloat("_Visualize", PAGBLHHLIGC);
			NLFJGMBCICG().SetFloat("CompletedLevel", JBLCJOHIFGG);
			FGENHBKMPDA().SetVector("#ok", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 543f, 20f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
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
			LPMLLJKMAMP().SetFloat("RemoveHighlight", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("Failed to Destroy objects of playerId: ", Size);
			GJHLADDCMFF().SetFloat("_Value", LightBackGround);
			GJHLADDCMFF().SetFloat("float,2", PAGBLHHLIGC);
			LONNIJMNKFB().SetFloat("rarity", JBLCJOHIFGG);
			NJDIODJNGGA().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1440f, 1883f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHPODJOBHL());
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
			GJHPODJOBHL().SetFloat("_MainTex2", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("Jazz", Size);
			KAFBNOBOIAJ().SetFloat("_FarCamera", LightBackGround);
			IGKFMCPDNOI().SetFloat("_ScreenResolution", PAGBLHHLIGC);
			CFEDGDGBCHE().SetFloat("_ScreenResolution", JBLCJOHIFGG);
			CFEDGDGBCHE().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1783f, 223f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
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
			GJHLADDCMFF().SetFloat("PointsScoreText", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("_Value4", Size);
			LDNADDJMIPK().SetFloat("DPADHOR", LightBackGround);
			LPMLLJKMAMP().SetFloat("#close", PAGBLHHLIGC);
			LDNADDJMIPK().SetFloat(" not exist", JBLCJOHIFGG);
			KAFBNOBOIAJ().SetVector("_NeutralTonemapperParams2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1609f, 1083f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
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
		SCShader = Shader.Find("Simulate");
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
			KOHGPKOFEJO().SetFloat("CameraFilterPack_Glasses_On7", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("USE_PREDICATION", Size);
			GJHLADDCMFF().SetFloat(".lastCheckpoint.lives", LightBackGround);
			FGENHBKMPDA().SetFloat("[LevelEditorScene] Map submitted!", PAGBLHHLIGC);
			KAFBNOBOIAJ().SetFloat("PunRespawn", JBLCJOHIFGG);
			DNLMFEGJJDD().SetVector("MaxLivesSlider", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 990f, 47f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CCFEDENFNEF()
	{
		SCShader = Shader.Find("'{0}' \t{1}ms \t{2}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}
}
