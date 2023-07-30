// CameraFilterPack_TV_Horror
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/TV/Horror")]
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
		FPHEBLMINDA = Resources.Load("No peer to communicate with. ") as Texture2D;
		SCShader = Shader.Find(" has no method \"");
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
		SCShader = Shader.Find("_TimeX");
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
			IIBLJCKLGFG().SetFloat("ChangeSelectedLevel", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat(".status", Fade);
			NDMPCDHADMJ().SetFloat("\\n", Distortion);
			DBOLLHHMKKN().SetVector("_Red_B", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 396f, 1283f));
			NFMGLIKNOOC().SetTexture("Warning, using scrollbors with the Scroll Snap controls is not advised as it causes unpredictable results", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIBLJCKLGFG());
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
			FAIFBBGFAIB().SetFloat("Loading inventory", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat("\" for viewID ", Fade);
			KBOPGONOCNP().SetFloat(" ", Distortion);
			IIBLJCKLGFG().SetVector("\0\0", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 135f, 281f));
			DBOLLHHMKKN().SetTexture("finished", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CNGAJDBOCLJ()
	{
		FPHEBLMINDA = Resources.Load("Outdated version. Please restart the game to get lastest updates.") as Texture2D;
		SCShader = Shader.Find("_Value");
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
			HFBJAOFLCJI().SetFloat("[MapsData] Key ", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat("shader.sunny", Fade);
			DBOLLHHMKKN().SetFloat("_Value8", Distortion);
			JFDGLLEOPGB().SetVector("PossibleMapMaxScoreText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 786f, 1457f));
			MICHFGAOPKM().SetTexture("Waiting to start", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
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
			HFBJAOFLCJI().SetFloat("LT", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat("_Visualize", Fade);
			NBPKMLMCHFN.SetFloat(".lastCheckpoint.lives", Distortion);
			NFMGLIKNOOC().SetVector("#failed", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 583f, 705f));
			NFMGLIKNOOC().SetTexture("CameraFilterPack/Blend2Camera_ColorDodge", FPHEBLMINDA);
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
			MICHFGAOPKM().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("New level loaded. Removed ", Fade);
			DBOLLHHMKKN().SetFloat("x", Distortion);
			JFDGLLEOPGB().SetVector("RaiseEvent() failed. Your event is not being sent! Check if your are in a Room and the eventCode must be less than 200 (0..199).", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1698f, 543f));
			IIBLJCKLGFG().SetTexture("GameScene", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
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
			HFBJAOFLCJI().SetFloat("_Bullet_3", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("_MainTex2", Fade);
			MICHFGAOPKM().SetFloat("_BlurDistance", Distortion);
			NFMGLIKNOOC().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 558f, 764f));
			MICHFGAOPKM().SetTexture("Connected to NameServer.", FPHEBLMINDA);
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
			NFMGLIKNOOC().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("colorD", Fade);
			MICHFGAOPKM().SetFloat("_MainTex2", Distortion);
			NFMGLIKNOOC().SetVector("workshop.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1104f, 1647f));
			JFDGLLEOPGB().SetTexture("Can't connect: Loading settings failed. ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MKIMDFLBFOM()
	{
		FPHEBLMINDA = Resources.Load("LoadMapCanvas") as Texture2D;
		SCShader = Shader.Find("_Offsets");
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
		FPHEBLMINDA = Resources.Load("_TimeX") as Texture2D;
		SCShader = Shader.Find("checkpoint");
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
			NBPKMLMCHFN.SetFloat(" at ", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("PointerEnter ", Fade);
			NFMGLIKNOOC().SetFloat("DPADHOR", Distortion);
			NDMPCDHADMJ().SetVector("y", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 294f, 431f));
			JFDGLLEOPGB().SetTexture("inventory.selected.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DAHFFNNIGML()
	{
		FPHEBLMINDA = Resources.Load("Item ") as Texture2D;
		SCShader = Shader.Find("{");
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
			DBOLLHHMKKN().SetFloat("_Intensity", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("BadgeText", Fade);
			FAIFBBGFAIB().SetFloat("OpJoinRandomRoom()", Distortion);
			JFDGLLEOPGB().SetVector("{0:x2}", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 238f, 755f));
			DBOLLHHMKKN().SetTexture("0,1,false", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MICHFGAOPKM());
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
			MICHFGAOPKM().SetFloat(" in-game items", HBJJOCHGOPH);
			IIBLJCKLGFG().SetFloat("_Distortion", Fade);
			FAIFBBGFAIB().SetFloat("/files/editor_manual.pdf", Distortion);
			NBPKMLMCHFN.SetVector("[MapEditor] Importing map: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 725f, 57f));
			NDMPCDHADMJ().SetTexture("_Value2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
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
			IIBLJCKLGFG().SetFloat("HandsCountSlider", Fade);
			NBPKMLMCHFN.SetFloat("float,2", Distortion);
			IIBLJCKLGFG().SetVector("settings.arcsnohitsoundtimedelay", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 394f, 261f));
			NBPKMLMCHFN.SetTexture("?", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
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
			FAIFBBGFAIB().SetFloat("0.00/0.00", HBJJOCHGOPH);
			NDMPCDHADMJ().SetFloat("CameraFilterPack/Blend2Camera_Luminosity", Fade);
			NFMGLIKNOOC().SetFloat("Dec", Distortion);
			MICHFGAOPKM().SetVector("OnEvent: {0}", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1340f, 578f));
			JFDGLLEOPGB().SetTexture("_TimeX", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
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
