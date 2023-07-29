// CameraFilterPack_TV_Horror
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/TV/Horror")]
[ExecuteInEditMode]
public class CameraFilterPack_TV_Horror : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 1f)]
	public float Fade = 1f;

	[Range(0f, 1f)]
	public float Distortion = 1f;

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

	private void FOMNCPKKCFN()
	{
	}

	[SpecialName]
	private Material JFDGLLEOPGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void OFIMMFHFHDD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JMEOGJHCONJ()
	{
		FPHEBLMINDA = Resources.Load("Lag ") as Texture2D;
		SCShader = Shader.Find("PhotonView with ID ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DLMPALHKMON()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BEBNOKFLJPH()
	{
		FPHEBLMINDA = Resources.Load("_Value") as Texture2D;
		SCShader = Shader.Find("_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OCMKCBBCEFG()
	{
	}

	private void OCCGJMPAJIK()
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
			if (HBJJOCHGOPH > 1856f)
			{
				HBJJOCHGOPH = 472f;
			}
			HFBJAOFLCJI().SetFloat("RecieveChatActionMessage", HBJJOCHGOPH);
			NDMPCDHADMJ().SetFloat("challenges", Fade);
			MICHFGAOPKM().SetFloat("[ERROR KEY {0}]", Distortion);
			NBPKMLMCHFN.SetVector("_Green_R", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 396f, 1283f));
			NDMPCDHADMJ().SetTexture("No child content found, exiting..", FPHEBLMINDA);
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
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void OBAEDJJDCPN()
	{
	}

	private void NAOLAJPDGIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KCDOMIJBFLL()
	{
	}

	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 182f)
			{
				HBJJOCHGOPH = 410f;
			}
			HFBJAOFLCJI().SetFloat("LoadingStatusText", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat(" Owner called.", Fade);
			NDMPCDHADMJ().SetFloat(" (inactive)", Distortion);
			NFMGLIKNOOC().SetVector("MouseY", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 135f, 281f));
			MICHFGAOPKM().SetTexture("0", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CNGAJDBOCLJ()
	{
		FPHEBLMINDA = Resources.Load("#restart") as Texture2D;
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1618f)
			{
				HBJJOCHGOPH = 106f;
			}
			NDMPCDHADMJ().SetFloat("true", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("player.watermelon", Fade);
			HFBJAOFLCJI().SetFloat("_Value8", Distortion);
			JFDGLLEOPGB().SetVector("PossibleMapMaxScoreText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 786f, 1457f));
			HFBJAOFLCJI().SetTexture("Waiting to start", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1045f)
			{
				HBJJOCHGOPH = 1170f;
			}
			MICHFGAOPKM().SetFloat("Joystick1Button7", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Visualize", Fade);
			NFMGLIKNOOC().SetFloat(".lastCheckpoint.checkpointsUsed", Distortion);
			KBOPGONOCNP().SetVector("_Color", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 583f, 705f));
			IIBLJCKLGFG().SetTexture("CameraFilterPack/Blend2Camera_ColorDodge", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material NFMGLIKNOOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)69;
		}
		return BJFKDHHMLJH;
	}

	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1365f)
			{
				HBJJOCHGOPH = 756f;
			}
			DBOLLHHMKKN().SetFloat("CameraFilterPack/Edge_Golden", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("Received OnSerialization for view ID ", Fade);
			DBOLLHHMKKN().SetFloat("x", Distortion);
			NBPKMLMCHFN.SetVector("AllocateViewID() failed. Room (user {0}) is out of 'scene' viewIDs. It seems all available are in use.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1698f, 543f));
			MICHFGAOPKM().SetTexture("yes", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1469f)
			{
				HBJJOCHGOPH = 1417f;
			}
			KBOPGONOCNP().SetFloat("_Bullet_5", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_MainTex2", Fade);
			KBOPGONOCNP().SetFloat("Hidden/LensAberrations", Distortion);
			NBPKMLMCHFN.SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 558f, 764f));
			JFDGLLEOPGB().SetTexture("Connected to masterserver.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1836f)
			{
				HBJJOCHGOPH = 1115f;
			}
			FAIFBBGFAIB().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("threshold", Fade);
			NFMGLIKNOOC().SetFloat("CameraFilterPack/BlurTiltShift_V", Distortion);
			MICHFGAOPKM().SetVector(" not found", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1104f, 1647f));
			MICHFGAOPKM().SetTexture("ConnectUsingSettings() disabled the offline mode. No longer offline.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MKIMDFLBFOM()
	{
		FPHEBLMINDA = Resources.Load("/") as Texture2D;
		SCShader = Shader.Find("_BlurredColor");
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

	[SpecialName]
	private Material IIBLJCKLGFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-68);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material FAIFBBGFAIB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return BJFKDHHMLJH;
	}

	private void BGFJOEPFOPM()
	{
	}

	[SpecialName]
	private Material DBOLLHHMKKN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void Start()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_TV_HorrorFX") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/TV_Horror");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-68);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HFBJAOFLCJI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void PLIKADJCEPO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JKFDDNMPOJH()
	{
		FPHEBLMINDA = Resources.Load("_PositionX") as Texture2D;
		SCShader = Shader.Find("event");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BMODOIJGIOO()
	{
	}

	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 784f)
			{
				HBJJOCHGOPH = 1829f;
			}
			JFDGLLEOPGB().SetFloat(" at ", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat(", ", Fade);
			JFDGLLEOPGB().SetFloat("DPADHOR", Distortion);
			IIBLJCKLGFG().SetVector("float,1.5", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 294f, 431f));
			NDMPCDHADMJ().SetTexture("IconImage", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DAHFFNNIGML()
	{
		FPHEBLMINDA = Resources.Load("Image") as Texture2D;
		SCShader = Shader.Find(",");
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
			if (HBJJOCHGOPH > 1648f)
			{
				HBJJOCHGOPH = 863f;
			}
			JFDGLLEOPGB().SetFloat("colorB", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("COMPLETED", Fade);
			MICHFGAOPKM().SetFloat("OpGetGameList not sent. Lobby cannot be null.", Distortion);
			HFBJAOFLCJI().SetVector(" - GameWebCallback] - ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 238f, 755f));
			NDMPCDHADMJ().SetTexture("0,1,false", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JNGMIAFLBDL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1057f)
			{
				HBJJOCHGOPH = 294f;
			}
			NBPKMLMCHFN.SetFloat("5;6;7;8;11;12;18;19;20;22x6;44x1", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("CameraFilterPack/FX_Hexagon", Fade);
			HFBJAOFLCJI().SetFloat("https://www.youtube.com/watch?v=cDVXukrKo74", Distortion);
			JFDGLLEOPGB().SetVector("editor.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 725f, 57f));
			JFDGLLEOPGB().SetTexture("_Value2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material MICHFGAOPKM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)65;
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
			NBPKMLMCHFN.SetFloat("Fade", Fade);
			NBPKMLMCHFN.SetFloat("Distortion", Distortion);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			NBPKMLMCHFN.SetTexture("Texture2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 708f)
			{
				HBJJOCHGOPH = 364f;
			}
			NFMGLIKNOOC().SetFloat("_Value3", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("Tab2Content", Fade);
			IIBLJCKLGFG().SetFloat("Set satellite trail length in seconds", Distortion);
			NFMGLIKNOOC().SetVector("ArcsHitsoundTimeDelaySlider", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 394f, 261f));
			DBOLLHHMKKN().SetTexture("SubmitUserVote:", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 917f)
			{
				HBJJOCHGOPH = 1374f;
			}
			NBPKMLMCHFN.SetFloat("Preparing content", HBJJOCHGOPH);
			NDMPCDHADMJ().SetFloat("_MainTex2", Fade);
			JFDGLLEOPGB().SetFloat("Day_", Distortion);
			MICHFGAOPKM().SetVector(". ActorNr: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1340f, 578f));
			JFDGLLEOPGB().SetTexture("_Amount", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GPFJMKCGHGB()
	{
	}
}
