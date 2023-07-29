// CameraFilterPack_Vision_Blood
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Vision/Blood")]
public class CameraFilterPack_Vision_Blood : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0.01f, 1f)]
	public float HoleSize = 0.6f;

	[Range(-1f, 1f)]
	public float HoleSmooth = 0.3f;

	[Range(-2f, 2f)]
	public float Color1 = 0.2f;

	[Range(-2f, 2f)]
	public float Color2 = 0.9f;

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

	private void OKLAJINHPAN()
	{
		SCShader = Shader.Find("_EmissionColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IKMELABKBHO()
	{
	}

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void KOFAMEKHHGD()
	{
		SCShader = Shader.Find("finished");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material NFKFAAHHLLM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KEMAALEODNH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-101);
		}
		return BJFKDHHMLJH;
	}

	private void IEMEHGCFAPD()
	{
	}

	private void GHILDCBCDJI()
	{
	}

	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 873f)
			{
				HBJJOCHGOPH = 435f;
			}
			MJJIEHANFJA().SetFloat("[GameScene] Submiting rank", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("GenerationMenu", HoleSize);
			OLHDPICFBOF().SetFloat("_MainTex2", HoleSmooth);
			EFMCNLELMDO().SetFloat("_EmissionColor", Color1);
			HEHKGPKLAKK().SetFloat("DPADHOR", Color2);
			IONHGBPGCHK().SetVector("_Noise", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 836f, 1055f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFMCNLELMDO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KIEJKBNBHMD()
	{
	}

	private void LCJHDLKJEOM()
	{
	}

	private void KLILJHJNICK()
	{
		SCShader = Shader.Find("_VignetteSettings");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HNDNDPECBPL()
	{
	}

	[SpecialName]
	private Material KOHGPKOFEJO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void JNGMIAFLBDL()
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
			if (HBJJOCHGOPH > 1191f)
			{
				HBJJOCHGOPH = 1614f;
			}
			HHIAIGCAHDA().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("InfoCanvas", HoleSize);
			NBPKMLMCHFN.SetFloat("color", HoleSmooth);
			NFKFAAHHLLM().SetFloat("Set Arcs Speed", Color1);
			IONHGBPGCHK().SetFloat("LevelEditor/patterns", Color2);
			IONHGBPGCHK().SetVector("settings.cameramovements", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 864f, 1378f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DOEPOGLEGLE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1857f)
			{
				HBJJOCHGOPH = 1969f;
			}
			OGMEGHKECAH().SetFloat("CameraFilterPack_Paper3", HBJJOCHGOPH);
			DOHGBNPMBKG().SetFloat("ShowTitle", HoleSize);
			GKILCDHJFEG().SetFloat("settings.showHP", HoleSmooth);
			AELJLBOJAIL().SetFloat("[ResourcesManager] Load text error: not found", Color1);
			DOHGBNPMBKG().SetFloat(";", Color2);
			KAFBNOBOIAJ().SetVector("Using PhotonServerSettings.Protocol when leaving the NameServer (AuthMode is AuthOnceWss): ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1668f, 1839f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1640f)
			{
				HBJJOCHGOPH = 347f;
			}
			JLHLHKPHDFO().SetFloat("_Value", HBJJOCHGOPH);
			FEAEGGCNIAA().SetFloat("Editor", HoleSize);
			GKILCDHJFEG().SetFloat("Fade", HoleSmooth);
			OGMEGHKECAH().SetFloat("back", Color1);
			FEAEGGCNIAA().SetFloat("Set Satellite Lerp Speed", Color2);
			NFKFAAHHLLM().SetVector("TimeBGSlider", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 847f, 296f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KMOCDAOKGLI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material ABHDNGIHBKE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void BMOFEBKGLFI()
	{
		SCShader = Shader.Find("Share");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Vision_Blood");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 271f)
			{
				HBJJOCHGOPH = 1879f;
			}
			JIBOKBCPDLC().SetFloat("_TimeX", HBJJOCHGOPH);
			NFKFAAHHLLM().SetFloat("No Name", HoleSize);
			NBPKMLMCHFN.SetFloat("setbool", HoleSmooth);
			IONHGBPGCHK().SetFloat("Map: ", Color1);
			GKILCDHJFEG().SetFloat("settings.arcsdestroydelay", Color2);
			NJDIODJNGGA().SetVector("TestMapButton", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 777f, 244f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GPHPJIDGEPI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IBPAMDEAGJL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CGBHOELMAOC()
	{
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
			NBPKMLMCHFN.SetFloat("_Value", HoleSize);
			NBPKMLMCHFN.SetFloat("_Value2", HoleSmooth);
			NBPKMLMCHFN.SetFloat("_Value3", Color1);
			NBPKMLMCHFN.SetFloat("_Value4", Color2);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ILCFPCIPENO()
	{
		SCShader = Shader.Find("Reset All");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material CIAFLBFJLEJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)112;
		}
		return BJFKDHHMLJH;
	}

	private void LOMDIOLNFHI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PNLKFANNOKO()
	{
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EDBEHEKMGFH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material NJDIODJNGGA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)89;
		}
		return BJFKDHHMLJH;
	}

	private void HMPGIFBJFIK()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PHJLHCMCCKE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HLDFOJMHKNL()
	{
	}

	private void GNMGIHFKJIJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material ADBKPGFMNKO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)86;
		}
		return BJFKDHHMLJH;
	}

	private void EKCKJLFFAID()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1203f)
			{
				HBJJOCHGOPH = 240f;
			}
			ADBKPGFMNKO().SetFloat("maps.", HBJJOCHGOPH);
			ADBKPGFMNKO().SetFloat("' ping: ", HoleSize);
			ADBKPGFMNKO().SetFloat("New SaveGame", HoleSmooth);
			EFMCNLELMDO().SetFloat("ItemTemplate", Color1);
			ABHDNGIHBKE().SetFloat("  |  Events Count: ", Color2);
			HHIAIGCAHDA().SetVector("]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1661f, 1403f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CIAFLBFJLEJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FODKODGPPDA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MMMDPANNAIO()
	{
		SCShader = Shader.Find("_Gamma");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JKBMKPDGCHG()
	{
		SCShader = Shader.Find("\n");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NNPBKKBFDHH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KCDOMIJBFLL()
	{
	}

	[SpecialName]
	private Material OLHDPICFBOF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideAndDontSave | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1251f)
			{
				HBJJOCHGOPH = 1127f;
			}
			KEMAALEODNH().SetFloat("[LevelEditorScene] Creating new item...", HBJJOCHGOPH);
			JIBOKBCPDLC().SetFloat("_ScreenResolution", HoleSize);
			NJDIODJNGGA().SetFloat("_Value5", HoleSmooth);
			ABHDNGIHBKE().SetFloat("SetParticlesParticleSpeed", Color1);
			HHIAIGCAHDA().SetFloat("No Dispatcher exists in the scene. Actions will not be invoked!", Color2);
			JIBOKBCPDLC().SetVector("Uploading preview image", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1931f, 1721f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KMKLDAJLCNM()
	{
	}

	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 720f)
			{
				HBJJOCHGOPH = 233f;
			}
			JIBOKBCPDLC().SetFloat("#availablechallenges", HBJJOCHGOPH);
			HHIAIGCAHDA().SetFloat("Can't connect: Loading settings failed. ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings", HoleSize);
			JLHLHKPHDFO().SetFloat("CrosshairOpacitySlider", HoleSmooth);
			OLHDPICFBOF().SetFloat("note.0", Color1);
			IONHGBPGCHK().SetFloat("_Value", Color2);
			ABHDNGIHBKE().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 214f, 1786f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ABIOAMNCEOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1105f)
			{
				HBJJOCHGOPH = 726f;
			}
			HHIAIGCAHDA().SetFloat("_YCrop", HBJJOCHGOPH);
			EFMCNLELMDO().SetFloat("workshop.", HoleSize);
			DOHGBNPMBKG().SetFloat("#creatingnewitem", HoleSmooth);
			CIAFLBFJLEJ().SetFloat("RootCanvas", Color1);
			KOHGPKOFEJO().SetFloat("MenuScene", Color2);
			NJDIODJNGGA().SetVector("CheckResources () for ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 860f, 457f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material FEAEGGCNIAA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void HJPCJGOEKMF()
	{
		SCShader = Shader.Find("CameraFilterPack/Atmosphere_Fog");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GJAJBMGGPFB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OCMKCBBCEFG()
	{
	}

	private void EAHCLIEEJOG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void COIJKMKIEAK()
	{
		SCShader = Shader.Find("colorD");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AEOLJEIDMDB()
	{
		SCShader = Shader.Find("_History2ChromaTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1985f)
			{
				HBJJOCHGOPH = 702f;
			}
			GKILCDHJFEG().SetFloat("_CenterX", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("Other", HoleSize);
			AELJLBOJAIL().SetFloat("_Value3", HoleSmooth);
			KOHGPKOFEJO().SetFloat("CameraFilterPack/TV_LED", Color1);
			KOHGPKOFEJO().SetFloat("https://steamcommunity.com/app/513510/workshop/", Color2);
			NFKFAAHHLLM().SetVector("float,1", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1962f, 1994f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HEHKGPKLAKK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)85;
		}
		return BJFKDHHMLJH;
	}

	private void LBAJLLFMMMP()
	{
		SCShader = Shader.Find("settings.volume.game");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 84f)
			{
				HBJJOCHGOPH = 798f;
			}
			NBPKMLMCHFN.SetFloat("_Value3", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("inventory.selected.", HoleSize);
			DOHGBNPMBKG().SetFloat("_Value6", HoleSmooth);
			OGMEGHKECAH().SetFloat("settings.enablerankingnotifications", Color1);
			ABHDNGIHBKE().SetFloat("_Value4", Color2);
			IONHGBPGCHK().SetVector("[MapEditor] Prepairing map editor...", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1303f, 538f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material JLHLHKPHDFO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)117;
		}
		return BJFKDHHMLJH;
	}

	private void LJIHHJOAJCN()
	{
	}

	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 584f)
			{
				HBJJOCHGOPH = 1420f;
			}
			JLHLHKPHDFO().SetFloat("GameScene", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("z", HoleSize);
			HHIAIGCAHDA().SetFloat("_MainTex2", HoleSmooth);
			MJJIEHANFJA().SetFloat("LoadMapCanvas", Color1);
			KEMAALEODNH().SetFloat("Changed config", Color2);
			EFMCNLELMDO().SetVector("offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1589f, 1046f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MDCFIHDPLIG()
	{
	}

	[SpecialName]
	private Material AELJLBOJAIL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)88;
		}
		return BJFKDHHMLJH;
	}

	private void NEKCPLGFOFD()
	{
	}

	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 993f)
			{
				HBJJOCHGOPH = 200f;
			}
			ABHDNGIHBKE().SetFloat("_MatrixColor", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("CameraFilterPack/Distortion_Flag", HoleSize);
			JIBOKBCPDLC().SetFloat("icon.png", HoleSmooth);
			NFMGLIKNOOC().SetFloat("cameramovements:", Color1);
			EFMCNLELMDO().SetFloat("[LevelEditorScene] Print Audio Wave: Done", Color2);
			NJDIODJNGGA().SetVector("_Intensity", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1138f, 479f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material EFMCNLELMDO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return BJFKDHHMLJH;
	}

	private void JOPCCCCHNLI()
	{
		SCShader = Shader.Find("BitsData");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BGFJOEPFOPM()
	{
	}

	[SpecialName]
	private Material OGMEGHKECAH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)70;
		}
		return BJFKDHHMLJH;
	}

	private void BMIOFJFMCBG()
	{
		SCShader = Shader.Find("_U");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DGCGGKMNPLD()
	{
	}

	private void CKCPPNHANAA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 268f)
			{
				HBJJOCHGOPH = 1181f;
			}
			NJDIODJNGGA().SetFloat("_TimeX", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("_Value2", HoleSize);
			DOHGBNPMBKG().SetFloat("ItemNameText", HoleSmooth);
			ADBKPGFMNKO().SetFloat("settings.selectormapsperpage", Color1);
			FEAEGGCNIAA().SetFloat("CameraFilterPack_TV_Arcade1", Color2);
			ABHDNGIHBKE().SetVector("Chat", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1201f, 288f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 329f)
			{
				HBJJOCHGOPH = 1568f;
			}
			ABHDNGIHBKE().SetFloat("_RgbDepthTex", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("_Value2", HoleSize);
			EFMCNLELMDO().SetFloat("/?player=", HoleSmooth);
			IONHGBPGCHK().SetFloat("AskForPickupItemSpawnTimes", Color1);
			IONHGBPGCHK().SetFloat("_Value6", Color2);
			OLHDPICFBOF().SetVector("Joystick1Button8", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1182f, 872f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FANADGBGCPI()
	{
		SCShader = Shader.Find("Can't connect: ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material NFMGLIKNOOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-76);
		}
		return BJFKDHHMLJH;
	}

	private void HDMDKOKOOJC()
	{
		SCShader = Shader.Find("OK");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1348f)
			{
				HBJJOCHGOPH = 753f;
			}
			ABHDNGIHBKE().SetFloat("Creating new item...", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat("<b>#", HoleSize);
			NFMGLIKNOOC().SetFloat(".g", HoleSmooth);
			NBPKMLMCHFN.SetFloat("_MaxRadiusOrKInPaper", Color1);
			KEMAALEODNH().SetFloat("_SampleCount", Color2);
			HEHKGPKLAKK().SetVector("[GameScene] Events count: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1242f, 343f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material JIBOKBCPDLC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-92);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material MJJIEHANFJA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)85;
		}
		return BJFKDHHMLJH;
	}

	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1257f)
			{
				HBJJOCHGOPH = 909f;
			}
			GKILCDHJFEG().SetFloat("_TimeX", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Bloom1", HoleSize);
			MJJIEHANFJA().SetFloat("menu.playedsolo", HoleSmooth);
			MJJIEHANFJA().SetFloat("Error0", Color1);
			CIAFLBFJLEJ().SetFloat("offline", Color2);
			FEAEGGCNIAA().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1921f, 730f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DNENFLNCIJP()
	{
	}

	[SpecialName]
	private Material HHIAIGCAHDA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material GKILCDHJFEG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-119);
		}
		return BJFKDHHMLJH;
	}

	private void KOJKBFDNGDK()
	{
		SCShader = Shader.Find("Set crosshair color");
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
			if (HBJJOCHGOPH > 1725f)
			{
				HBJJOCHGOPH = 1682f;
			}
			HHIAIGCAHDA().SetFloat("/", HBJJOCHGOPH);
			EFMCNLELMDO().SetFloat("OnReadyClick", HoleSize);
			NJDIODJNGGA().SetFloat("ACCEPT", HoleSmooth);
			NFMGLIKNOOC().SetFloat("Scene", Color1);
			AELJLBOJAIL().SetFloat("...", Color2);
			HEHKGPKLAKK().SetVector("_Red_C", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1963f, 1246f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1955f)
			{
				HBJJOCHGOPH = 663f;
			}
			GKILCDHJFEG().SetFloat("isVisible", HBJJOCHGOPH);
			EFMCNLELMDO().SetFloat("_Bloom0", HoleSize);
			NJDIODJNGGA().SetFloat("]", HoleSmooth);
			MJJIEHANFJA().SetFloat("ChangeSelectedLevel", Color1);
			NFKFAAHHLLM().SetFloat("_TimeX", Color2);
			GKILCDHJFEG().SetVector("CameraFilterPack_WaterDrop", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 125f, 648f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	private void PKHPNHBEKHA()
	{
	}

	private void ODAIMOJLJOF()
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
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void PAKPHKPDKGE()
	{
		SCShader = Shader.Find("Joystick1Button11");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1480f)
			{
				HBJJOCHGOPH = 1003f;
			}
			HEHKGPKLAKK().SetFloat("ScrollPanel", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("RateButton", HoleSize);
			NJDIODJNGGA().SetFloat("mapselector.lastSearch", HoleSmooth);
			NFMGLIKNOOC().SetFloat("_TimeX", Color1);
			AELJLBOJAIL().SetFloat("GameScene", Color2);
			IONHGBPGCHK().SetVector("music", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1973f, 1725f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DOHGBNPMBKG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)75;
		}
		return BJFKDHHMLJH;
	}

	private void JDGFCEPDKAJ()
	{
	}
}
