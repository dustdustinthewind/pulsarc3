// CameraFilterPack_Vision_Blood
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Vision/Blood")]
[ExecuteInEditMode]
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
		SCShader = Shader.Find("_Color");
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
		SCShader = Shader.Find("maps.");
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
			NFMGLIKNOOC().SetFloat("[GameScene] Submiting rank", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("GenerationMenu", HoleSize);
			EFMCNLELMDO().SetFloat("CameraFilterPack/Blend2Camera_VividLight", HoleSmooth);
			ABHDNGIHBKE().SetFloat("_DiffuseColor", Color1);
			NFKFAAHHLLM().SetFloat("DPADVER", Color2);
			EFMCNLELMDO().SetVector("_Parasite", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 836f, 1055f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
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
			ADBKPGFMNKO().SetFloat("_Value4", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("\n\n• ", HoleSize);
			KAFBNOBOIAJ().SetFloat("color", HoleSmooth);
			GKILCDHJFEG().SetFloat("Set Arcs Speed", Color1);
			HEHKGPKLAKK().SetFloat("ShowSprite", Color2);
			IONHGBPGCHK().SetVector("settings.shaders.bloomintencity", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 864f, 1378f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
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
			MJJIEHANFJA().SetFloat("_MainTex2", HBJJOCHGOPH);
			JLHLHKPHDFO().SetFloat("[GameEvent] Exeption:", HoleSize);
			NFKFAAHHLLM().SetFloat("settings.showHP", HoleSmooth);
			NFMGLIKNOOC().SetFloat(",", Color1);
			GKILCDHJFEG().SetFloat(";", Color2);
			KOHGPKOFEJO().SetVector("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1668f, 1839f));
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
			JIBOKBCPDLC().SetFloat("_Value", HBJJOCHGOPH);
			HEHKGPKLAKK().SetFloat(".sawoutdatedmessage", HoleSize);
			HEHKGPKLAKK().SetFloat("_TimeX", HoleSmooth);
			EFMCNLELMDO().SetFloat("back", Color1);
			NFKFAAHHLLM().SetFloat("SetSatelliteLerpSpeed", Color2);
			NBPKMLMCHFN.SetVector("TimeBGSlider", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 847f, 296f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
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
		SCShader = Shader.Find("R2");
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
			NJDIODJNGGA().SetFloat("CameraFilterPack/TV_Chromatical2", HBJJOCHGOPH);
			JIBOKBCPDLC().SetFloat("music.ogg", HoleSize);
			KEMAALEODNH().SetFloat("setbool", HoleSmooth);
			HHIAIGCAHDA().SetFloat("Map: ", Color1);
			JIBOKBCPDLC().SetFloat("settings.gamemessagesduration", Color2);
			OGMEGHKECAH().SetVector("EventMenu", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 777f, 244f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
		SCShader = Shader.Find("Reload Maps");
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
			DOHGBNPMBKG().SetFloat("maps.", HBJJOCHGOPH);
			OLHDPICFBOF().SetFloat("No regions available. Are you sure your appid is valid and setup?", HoleSize);
			JLHLHKPHDFO().SetFloat("Hello", HoleSmooth);
			NJDIODJNGGA().SetFloat("SlidingArea", Color1);
			NJDIODJNGGA().SetFloat("PlayButton", Color2);
			NFMGLIKNOOC().SetVector(" [", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1661f, 1403f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
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
		SCShader = Shader.Find("_WhiteBalance");
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
			ADBKPGFMNKO().SetFloat("OK", HBJJOCHGOPH);
			NJDIODJNGGA().SetFloat("_ScreenResolution", HoleSize);
			KAFBNOBOIAJ().SetFloat("_Value4", HoleSmooth);
			GKILCDHJFEG().SetFloat("SetParticlesColor", Color1);
			JLHLHKPHDFO().SetFloat("d264dbba9c2410771b4ad918903b3f4cd9e276a9", Color2);
			HEHKGPKLAKK().SetVector("OK", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1931f, 1721f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			NFKFAAHHLLM().SetFloat("<b>", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("ReconnectAndRejoin() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", HoleSize);
			NBPKMLMCHFN.SetFloat("CrosshairOpacitySlider", HoleSmooth);
			AELJLBOJAIL().SetFloat("#outdatedmap! Challenges will not work!", Color1);
			FEAEGGCNIAA().SetFloat("_TimeX", Color2);
			NFMGLIKNOOC().SetVector("CameraFilterPack/Colors_BleachBypass", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 214f, 1786f));
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
			IONHGBPGCHK().SetFloat("UI Extensions/UIAdditive", HBJJOCHGOPH);
			DOHGBNPMBKG().SetFloat("workshop.", HoleSize);
			GKILCDHJFEG().SetFloat("#mapalreadyexistupdate", HoleSmooth);
			CIAFLBFJLEJ().SetFloat(" Also make sure to disable sprite packing for this sprite.", Color1);
			ADBKPGFMNKO().SetFloat("MenuScene", Color2);
			JIBOKBCPDLC().SetVector(" is not supported on this platform!", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 860f, 457f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
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
		SCShader = Shader.Find("CameraFilterPack_Atmosphere_Rain_FX");
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
		SCShader = Shader.Find("colorB");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AEOLJEIDMDB()
	{
		SCShader = Shader.Find("_History4LumaTex");
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
			DOHGBNPMBKG().SetFloat("_CenterX", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("Other", HoleSize);
			ABHDNGIHBKE().SetFloat("_Value2", HoleSmooth);
			ABHDNGIHBKE().SetFloat("_ScreenResolution", Color1);
			MJJIEHANFJA().SetFloat("Player", Color2);
			NFMGLIKNOOC().SetVector("value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1962f, 1994f));
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
		SCShader = Shader.Find("settings.volume.menu");
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
			MJJIEHANFJA().SetFloat("_Value2", HBJJOCHGOPH);
			NJDIODJNGGA().SetFloat("inventory.selected.", HoleSize);
			OLHDPICFBOF().SetFloat("_Value5", HoleSmooth);
			AELJLBOJAIL().SetFloat("EnableRankedNotificationsToggle", Color1);
			NJDIODJNGGA().SetFloat("_Value3", Color2);
			NFKFAAHHLLM().SetVector("[MapEditor] Loading events...", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1303f, 538f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
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
			ADBKPGFMNKO().SetFloat("GameScene", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat("float,0", HoleSize);
			KOHGPKOFEJO().SetFloat("_MainTex2", HoleSmooth);
			IONHGBPGCHK().SetFloat("Data/Editor/leveltemplate", Color1);
			FEAEGGCNIAA().SetFloat("[EditorEvent] Exception: ", Color2);
			FEAEGGCNIAA().SetVector("offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1589f, 1046f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			HEHKGPKLAKK().SetFloat("_MatrixColor", HBJJOCHGOPH);
			JLHLHKPHDFO().SetFloat("_ScreenResolution", HoleSize);
			HHIAIGCAHDA().SetFloat(".played", HoleSmooth);
			NJDIODJNGGA().SetFloat("bloomintencity:", Color1);
			OLHDPICFBOF().SetFloat("#yes", Color2);
			KOHGPKOFEJO().SetVector("offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1138f, 479f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JLHLHKPHDFO());
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
		SCShader = Shader.Find("Deleted event");
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
			EFMCNLELMDO().SetFloat("_TimeX", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("_Value", HoleSize);
			OGMEGHKECAH().SetFloat("ItemNameBGImage", HoleSmooth);
			KAFBNOBOIAJ().SetFloat("settings.enablehitsoundsinnormal", Color1);
			HHIAIGCAHDA().SetFloat("Fade", Color2);
			DOHGBNPMBKG().SetVector("player ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1201f, 288f));
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
			NBPKMLMCHFN.SetFloat("_RgbTex", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value", HoleSize);
			OGMEGHKECAH().SetFloat("Left", HoleSmooth);
			NJDIODJNGGA().SetFloat("RespawnAfter", Color1);
			DOHGBNPMBKG().SetFloat("_Value3", Color2);
			AELJLBOJAIL().SetVector("Joystick1Button7", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1182f, 872f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FANADGBGCPI()
	{
		SCShader = Shader.Find("Can't connect: Loading settings failed. ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings");
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
		SCShader = Shader.Find("Done!");
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
			EFMCNLELMDO().SetFloat("arcs", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat("<b>#", HoleSize);
			HEHKGPKLAKK().SetFloat(".g", HoleSmooth);
			HEHKGPKLAKK().SetFloat("_ToPrevViewProjCombined", Color1);
			JIBOKBCPDLC().SetFloat("_TargetScale", Color2);
			MJJIEHANFJA().SetVector("[GameScene] Events count: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1242f, 343f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFMCNLELMDO());
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
			NBPKMLMCHFN.SetFloat("_TimeX", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat("_Bloom0", HoleSize);
			NBPKMLMCHFN.SetFloat("original.tutorial", HoleSmooth);
			CIAFLBFJLEJ().SetFloat("runas", Color1);
			HHIAIGCAHDA().SetFloat(", ", Color2);
			KEMAALEODNH().SetVector("CameraFilterPack/Blur_Movie", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1921f, 730f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
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
		SCShader = Shader.Find("float,10");
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
			ADBKPGFMNKO().SetFloat("IconFileSelector", HBJJOCHGOPH);
			HEHKGPKLAKK().SetFloat("OnReadyClick", HoleSize);
			ADBKPGFMNKO().SetFloat("Have you fully accept the terms?", HoleSmooth);
			NFKFAAHHLLM().SetFloat("Scene", Color1);
			NJDIODJNGGA().SetFloat("entering", Color2);
			NFMGLIKNOOC().SetVector("_Blue_B", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1963f, 1246f));
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
			EFMCNLELMDO().SetFloat("isVisible", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat("_LensDirtIntensity", HoleSize);
			ADBKPGFMNKO().SetFloat("#craftng", HoleSmooth);
			NFKFAAHHLLM().SetFloat("ChangeSelectedLevel", Color1);
			KAFBNOBOIAJ().SetFloat("_Distortion", Color2);
			IONHGBPGCHK().SetVector("_MainTex2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 125f, 648f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
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
		SCShader = Shader.Find("Left Stick Click");
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
			NFKFAAHHLLM().SetFloat("MainButton", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("FavoriteButton", HoleSize);
			NFKFAAHHLLM().SetFloat("mapselector.lastSearch", HoleSmooth);
			NFMGLIKNOOC().SetFloat("_TimeX", Color1);
			IONHGBPGCHK().SetFloat("VoteDownToggle", Color2);
			ADBKPGFMNKO().SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1973f, 1725f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
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
