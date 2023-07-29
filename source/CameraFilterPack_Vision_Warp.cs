// CameraFilterPack_Vision_Warp
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Vision/Warp")]
[ExecuteInEditMode]
public class CameraFilterPack_Vision_Warp : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 1f)]
	public float Value = 0.6f;

	[Range(0f, 1f)]
	public float Value2 = 0.6f;

	[Range(0f, 10f)]
	private float ILHJFHFPGBB = 1f;

	[Range(0f, 10f)]
	private float CCIENBFIKKH = 1f;

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

	private void PKBENONAOOL()
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

	private void DPFOEBCADNP()
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
			if (HBJJOCHGOPH > 1224f)
			{
				HBJJOCHGOPH = 1085f;
			}
			LNLKMDPHDCC().SetFloat("IncorrectHitsScoreText", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat(".jpg", Value);
			EPCGJFCCAFH().SetFloat("_ScreenResolution", Value2);
			HFBJAOFLCJI().SetFloat("CameraFilterPack/Atmosphere_Rain_Pro_3D", ILHJFHFPGBB);
			FHFLKLMFHOI().SetFloat("settings.showHP", CCIENBFIKKH);
			EPCGJFCCAFH().SetVector("[Up]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 96f, 1284f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FEHCNJLLJMP()
	{
		SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BGDPIHMAACO()
	{
		SCShader = Shader.Find("CameraFilterPack/3D_BlackHole");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JLNNHKPHMAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FJHFOBHJEHL()
	{
	}

	private void NNFMIAFHMJM()
	{
		SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KCCIEMBMOBA()
	{
		SCShader = Shader.Find("USE_PREDICATION");
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

	[SpecialName]
	private Material HCGJCMDJPGD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 523f)
			{
				HBJJOCHGOPH = 135f;
			}
			EPCGJFCCAFH().SetFloat("Netw. Sim.", HBJJOCHGOPH);
			IIBLJCKLGFG().SetFloat("/Saved Games/", Value);
			HCGJCMDJPGD().SetFloat("Misses:", Value2);
			HCGJCMDJPGD().SetFloat("_MainTex", ILHJFHFPGBB);
			LNLKMDPHDCC().SetFloat("#changenote", CCIENBFIKKH);
			FHFLKLMFHOI().SetVector(" - GameWebCallback] - ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1589f, 1246f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LNLKMDPHDCC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)103;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NBMPPNFKFLB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void CCLNNLCOPBL()
	{
		SCShader = Shader.Find("0 seconds");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1641f)
			{
				HBJJOCHGOPH = 392f;
			}
			GKILCDHJFEG().SetFloat("_Near", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("_ProjectionInv", Value);
			HCGJCMDJPGD().SetFloat("_Offsets", Value2);
			HFBJAOFLCJI().SetFloat("(\\[ */ *h1 *\\])", ILHJFHFPGBB);
			HCGJCMDJPGD().SetFloat("_ScreenResolution", CCIENBFIKKH);
			FHFLKLMFHOI().SetVector("CameraFilterPack/Blend2Camera_ColorDodge", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 304f, 761f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material EPCGJFCCAFH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void KIMMMCJFMAB()
	{
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ILCFPCIPENO()
	{
		SCShader = Shader.Find("_Value1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NKLIHNJCHOG()
	{
	}

	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 554f)
			{
				HBJJOCHGOPH = 702f;
			}
			LNLKMDPHDCC().SetFloat("OpSetPropertiesOfRoom()", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("_Value3", Value);
			HCGJCMDJPGD().SetFloat("_FixDistance", Value2);
			NBPKMLMCHFN.SetFloat("_Value2", ILHJFHFPGBB);
			NBMPPNFKFLB().SetFloat("LoadingStatusText", CCIENBFIKKH);
			IIBLJCKLGFG().SetVector("player.licenceaccepted", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 350f, 1246f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material GKILCDHJFEG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-111);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material JFDGLLEOPGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)107;
		}
		return BJFKDHHMLJH;
	}

	private void HAIAHJPCPAG()
	{
		SCShader = Shader.Find("[Left]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 250f)
			{
				HBJJOCHGOPH = 932f;
			}
			EPCGJFCCAFH().SetFloat("_MainTex2", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("_Value2", Value);
			GKILCDHJFEG().SetFloat("PublishButton", Value2);
			HFBJAOFLCJI().SetFloat("1", ILHJFHFPGBB);
			JFDGLLEOPGB().SetFloat("Joystick1Button2", CCIENBFIKKH);
			HFBJAOFLCJI().SetVector("BitsData", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 688f, 1301f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 695f)
			{
				HBJJOCHGOPH = 1046f;
			}
			NBMPPNFKFLB().SetFloat("_Value4", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("/Segment-[Left]", Value);
			NBMPPNFKFLB().SetFloat("_MainTex2", Value2);
			LNLKMDPHDCC().SetFloat("The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.", ILHJFHFPGBB);
			GKILCDHJFEG().SetFloat("_Blend", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("GhostSize", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1098f, 786f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NBGIMIDICKE()
	{
		SCShader = Shader.Find("_FixDistance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EHCGBJDFMHG()
	{
	}

	private void EJJEDJIOFAB()
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
			NBPKMLMCHFN.SetFloat("_Value", Value);
			NBPKMLMCHFN.SetFloat("_Value2", Value2);
			NBPKMLMCHFN.SetFloat("_Value3", ILHJFHFPGBB);
			NBPKMLMCHFN.SetFloat("_Value4", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IBHACCEEFFI()
	{
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 19f)
			{
				HBJJOCHGOPH = 603f;
			}
			EPCGJFCCAFH().SetFloat("float", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("https://www.youtube.com/watch?v=cDVXukrKo74", Value);
			HCGJCMDJPGD().SetFloat("?", Value2);
			IIBLJCKLGFG().SetFloat("Hidden/Image Effects/Cinematic/Bloom", ILHJFHFPGBB);
			JFDGLLEOPGB().SetFloat("maps.", CCIENBFIKKH);
			IIBLJCKLGFG().SetVector("menutheme.jamaicanorcdub", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1049f, 1885f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CPAJLKHMOJB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KCDOMIJBFLL()
	{
	}

	private void LOMDIOLNFHI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HFBJAOFLCJI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-98);
		}
		return BJFKDHHMLJH;
	}

	private void EFJDNLGNACH()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LPMINJJPDCH()
	{
	}

	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1247f)
			{
				HBJJOCHGOPH = 1080f;
			}
			HCGJCMDJPGD().SetFloat("_CurrentMipLevel", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat(".status", Value);
			LNLKMDPHDCC().SetFloat("PLEASE WAIT", Value2);
			NBPKMLMCHFN.SetFloat("\n", ILHJFHFPGBB);
			IIBLJCKLGFG().SetFloat("-1", CCIENBFIKKH);
			LNLKMDPHDCC().SetVector("CameraFilterPack/Blend2Camera_SoftLight", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1264f, 1913f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JKFDDNMPOJH()
	{
		SCShader = Shader.Find(".lastCheckpoint.correctScore");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FHPFJBFCOOF()
	{
		SCShader = Shader.Find("_InvScreenSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material IIBLJCKLGFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void BOLBPPHJBMI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JAAJECBCCFM()
	{
	}

	private void Update()
	{
	}

	private void PHJLHCMCCKE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LJIHHJOAJCN()
	{
	}

	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1501f)
			{
				HBJJOCHGOPH = 1419f;
			}
			LNLKMDPHDCC().SetFloat(".lastCheckpoint.bgcolor", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("_Value5", Value);
			HCGJCMDJPGD().SetFloat("_DepthLevel", Value2);
			NBMPPNFKFLB().SetFloat("player.gamecompleted", ILHJFHFPGBB);
			HFBJAOFLCJI().SetFloat("id", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("_EmissionGain", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1954f, 1381f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
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
			if (HBJJOCHGOPH > 133f)
			{
				HBJJOCHGOPH = 1583f;
			}
			GKILCDHJFEG().SetFloat("_TimeX", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("Joystick1Button9", Value);
			HFBJAOFLCJI().SetFloat("GlassAberration", Value2);
			NBMPPNFKFLB().SetFloat("_SceneFogMode", ILHJFHFPGBB);
			FHFLKLMFHOI().SetFloat("_ScreenResolution", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("GlassesColor2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 987f, 704f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OHFOLGANOLC()
	{
		SCShader = Shader.Find("DataText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 700f)
			{
				HBJJOCHGOPH = 1159f;
			}
			FHFLKLMFHOI().SetFloat("settings.arcshitsoundtimedelay", HBJJOCHGOPH);
			FHFLKLMFHOI().SetFloat(".lastCheckpoint.time", Value);
			NBPKMLMCHFN.SetFloat("move", Value2);
			GKILCDHJFEG().SetFloat("_Vibrance", ILHJFHFPGBB);
			HCGJCMDJPGD().SetFloat("SetSpeed", CCIENBFIKKH);
			GKILCDHJFEG().SetVector("00", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 470f, 802f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NCNPAKFAFOE()
	{
		SCShader = Shader.Find("_Bullet_11");
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
			if (HBJJOCHGOPH > 629f)
			{
				HBJJOCHGOPH = 539f;
			}
			NBPKMLMCHFN.SetFloat("_Value4", HBJJOCHGOPH);
			IIBLJCKLGFG().SetFloat("Done!", Value);
			FHFLKLMFHOI().SetFloat("#startofflinemessage", Value2);
			EPCGJFCCAFH().SetFloat("Error! no audio sources attached to AudioSampler.css", ILHJFHFPGBB);
			EPCGJFCCAFH().SetFloat("_Near", CCIENBFIKKH);
			IIBLJCKLGFG().SetVector("in seconds. 0 - forever", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 666f, 115f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Vision_Warp");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 164f)
			{
				HBJJOCHGOPH = 432f;
			}
			LNLKMDPHDCC().SetFloat("menu.enableselectormusic", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("Left", Value);
			HCGJCMDJPGD().SetFloat("GameScene", Value2);
			JFDGLLEOPGB().SetFloat("You have added the SecondScrollRect to a scroll view that already has both directions selected", ILHJFHFPGBB);
			IIBLJCKLGFG().SetFloat("_CenterX", CCIENBFIKKH);
			FHFLKLMFHOI().SetVector("CameraFilterPack/FX_Hexagon_Black", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 251f, 1231f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BGDONBMDPGM()
	{
	}

	private void KMOCDAOKGLI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1445f)
			{
				HBJJOCHGOPH = 148f;
			}
			JFDGLLEOPGB().SetFloat("Object ID. Case-Sensitive", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("Received unknown status code: ", Value);
			NBMPPNFKFLB().SetFloat("colorC", Value2);
			EPCGJFCCAFH().SetFloat(".sav", ILHJFHFPGBB);
			HFBJAOFLCJI().SetFloat("No Name", CCIENBFIKKH);
			EPCGJFCCAFH().SetVector("_Color", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 249f, 1558f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OBAEDJJDCPN()
	{
	}

	private void JHLGHODFJOO()
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

	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 186f)
			{
				HBJJOCHGOPH = 1928f;
			}
			HCGJCMDJPGD().SetFloat("_Level", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("0 - sun, 1 - satellite, 2 - particles emitter", Value);
			LNLKMDPHDCC().SetFloat("_Value", Value2);
			HCGJCMDJPGD().SetFloat("_Value7", ILHJFHFPGBB);
			GKILCDHJFEG().SetFloat("_Value3", CCIENBFIKKH);
			FHFLKLMFHOI().SetVector("Environment/SunBase_", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1576f, 853f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material FHFLKLMFHOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-112);
		}
		return BJFKDHHMLJH;
	}
}
