// CameraFilterPack_Vision_Warp
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Vision/Warp")]
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
			EPCGJFCCAFH().SetFloat("IncorrectHitsScoreText", HBJJOCHGOPH);
			FHFLKLMFHOI().SetFloat("[ResourcesManager] Load image error: ", Value);
			GKILCDHJFEG().SetFloat("_ScreenResolution", Value2);
			LNLKMDPHDCC().SetFloat("CameraFilterPack/Atmosphere_Rain_Pro_3D", ILHJFHFPGBB);
			IIBLJCKLGFG().SetFloat("settings.showHP", CCIENBFIKKH);
			FHFLKLMFHOI().SetVector("[Up]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 96f, 1284f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FEHCNJLLJMP()
	{
		SCShader = Shader.Find("OK");
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
		SCShader = Shader.Find("CameraFilterPack/Blend2Camera_GreenScreen");
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
			HCGJCMDJPGD().SetFloat("' ping: ", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("The directory was created successfully at ", Value);
			NBMPPNFKFLB().SetFloat("MissesText", Value2);
			HFBJAOFLCJI().SetFloat("_Offsets", ILHJFHFPGBB);
			IIBLJCKLGFG().SetFloat("#mapmustbecompletebeforesubmit", CCIENBFIKKH);
			NBMPPNFKFLB().SetVector("{0:x2}", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1589f, 1246f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
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
			HFBJAOFLCJI().SetFloat("_Near", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("_Overlay", Value);
			HFBJAOFLCJI().SetFloat("_FgCocMask", Value2);
			IIBLJCKLGFG().SetFloat("(\\[ */ *h1 *\\])", ILHJFHFPGBB);
			FHFLKLMFHOI().SetFloat("_ScreenResolution", CCIENBFIKKH);
			HFBJAOFLCJI().SetVector("CameraFilterPack/Blend2Camera_ColorDodge", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 304f, 761f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
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
			IIBLJCKLGFG().SetFloat("OpGetGameList not sent. LobbyType must be SqlLobby.", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("_Value3", Value);
			NBPKMLMCHFN.SetFloat("_FixDistance", Value2);
			JFDGLLEOPGB().SetFloat("_TimeX", ILHJFHFPGBB);
			JFDGLLEOPGB().SetFloat(":</b> ", CCIENBFIKKH);
			EPCGJFCCAFH().SetVector("player.licenceaccepted", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 350f, 1246f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FHFLKLMFHOI());
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
		SCShader = Shader.Find("[Up]");
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
			IIBLJCKLGFG().SetFloat("_MainTex2", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("_Value", Value);
			JFDGLLEOPGB().SetFloat("PublishButton", Value2);
			JFDGLLEOPGB().SetFloat("Month_", ILHJFHFPGBB);
			LNLKMDPHDCC().SetFloat("Joystick1Button1", CCIENBFIKKH);
			IIBLJCKLGFG().SetVector("event", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 688f, 1301f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
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
			GKILCDHJFEG().SetFloat("_Value3", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("/Segment-[Right]", Value);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Blend2Camera_Multiply", Value2);
			HCGJCMDJPGD().SetFloat(" Server: ", ILHJFHFPGBB);
			HCGJCMDJPGD().SetFloat("_LutTex", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("GhostSize", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1098f, 786f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			NBMPPNFKFLB().SetFloat("true", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("/files/editor_manual.pdf", Value);
			NBPKMLMCHFN.SetFloat("?", Value2);
			NBPKMLMCHFN.SetFloat("_BlendTex", ILHJFHFPGBB);
			FHFLKLMFHOI().SetFloat("maps.", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("menutheme.melancholicose", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1049f, 1885f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FHFLKLMFHOI());
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
		SCShader = Shader.Find("_Contrast");
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
			NBMPPNFKFLB().SetFloat("Screen Space Reflections", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("PlayMapsSeriesGoal", Value);
			NBPKMLMCHFN.SetFloat("Use ticket: ", Value2);
			NBPKMLMCHFN.SetFloat("The region arrays from Name Server are not ok. Must be non-null and same length. ", ILHJFHFPGBB);
			JFDGLLEOPGB().SetFloat("restrictions\n\n#until: ", CCIENBFIKKH);
			JFDGLLEOPGB().SetVector("CameraFilterPack/Blend2Camera_SoftLight", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1264f, 1913f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JKFDDNMPOJH()
	{
		SCShader = Shader.Find(".lastCheckpoint.lives");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FHPFJBFCOOF()
	{
		SCShader = Shader.Find("_ReflectionBufferSize");
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
			FHFLKLMFHOI().SetFloat(".lastCheckpoint.playerdistance", HBJJOCHGOPH);
			FHFLKLMFHOI().SetFloat("_Value5", Value);
			NBPKMLMCHFN.SetFloat("_DepthLevel", Value2);
			HFBJAOFLCJI().SetFloat("player.gamecompleted", ILHJFHFPGBB);
			JFDGLLEOPGB().SetFloat("id", CCIENBFIKKH);
			LNLKMDPHDCC().SetVector("_EmissionColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1954f, 1381f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
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
			NBMPPNFKFLB().SetFloat("_TimeX", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("View", Value);
			FHFLKLMFHOI().SetFloat("GlassAberration", Value2);
			FHFLKLMFHOI().SetFloat("_DistanceParams", ILHJFHFPGBB);
			JFDGLLEOPGB().SetFloat("_ScreenResolution", CCIENBFIKKH);
			HFBJAOFLCJI().SetVector("GlassesColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 987f, 704f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIBLJCKLGFG());
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
			NBMPPNFKFLB().SetFloat("ArcsHitsoundTimeDelaySlider", HBJJOCHGOPH);
			FHFLKLMFHOI().SetFloat(".lastCheckpoint.bgcolor", Value);
			NBPKMLMCHFN.SetFloat("Can't SendMove. Turn is finished by this player.", Value2);
			FHFLKLMFHOI().SetFloat("_Gain", ILHJFHFPGBB);
			GKILCDHJFEG().SetFloat("SetSpeed", CCIENBFIKKH);
			FHFLKLMFHOI().SetVector("00", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 470f, 802f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NCNPAKFAFOE()
	{
		SCShader = Shader.Find("_Bullet_10");
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
			JFDGLLEOPGB().SetFloat("_Value3", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("[LevelEditorScene] Exported to ", Value);
			JFDGLLEOPGB().SetFloat("#startofflinemessage", Value2);
			FHFLKLMFHOI().SetFloat("Error! no audio sources attached to AudioSampler.css", ILHJFHFPGBB);
			FHFLKLMFHOI().SetFloat("_Near", CCIENBFIKKH);
			JFDGLLEOPGB().SetVector("duration", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 666f, 115f));
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
			NBMPPNFKFLB().SetFloat("settings.fps", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("LostLive", Value);
			LNLKMDPHDCC().SetFloat("[", Value2);
			NBPKMLMCHFN.SetFloat("PPI: ", ILHJFHFPGBB);
			EPCGJFCCAFH().SetFloat("_CenterX", CCIENBFIKKH);
			LNLKMDPHDCC().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 251f, 1231f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
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
			FHFLKLMFHOI().SetFloat("id", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat(" while connecting to: ", Value);
			FHFLKLMFHOI().SetFloat("colorB", Value2);
			NBPKMLMCHFN.SetFloat("New SaveGame", ILHJFHFPGBB);
			EPCGJFCCAFH().SetFloat("icon.png", CCIENBFIKKH);
			LNLKMDPHDCC().SetVector("#ok", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 249f, 1558f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
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
			LNLKMDPHDCC().SetFloat("_TimeX", HBJJOCHGOPH);
			FHFLKLMFHOI().SetFloat("type", Value);
			EPCGJFCCAFH().SetFloat("_TimeX", Value2);
			FHFLKLMFHOI().SetFloat("_Value7", ILHJFHFPGBB);
			NBMPPNFKFLB().SetFloat("_Value2", CCIENBFIKKH);
			IIBLJCKLGFG().SetVector("2hands", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1576f, 853f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FHFLKLMFHOI());
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
