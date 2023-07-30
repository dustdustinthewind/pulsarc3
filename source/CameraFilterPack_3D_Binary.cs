// CameraFilterPack_3D_Binary
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/3D/Binary")]
[ExecuteInEditMode]
public class CameraFilterPack_3D_Binary : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	public bool _Visualize;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 100f)]
	public float _FixDistance = 2f;

	[Range(-5f, 5f)]
	public float LightIntensity;

	[Range(0f, 8f)]
	public float MatrixSize = 2f;

	[Range(-4f, 4f)]
	public float MatrixSpeed = 1f;

	[Range(0f, 1f)]
	public float Fade = 1f;

	[Range(0f, 1f)]
	public float FadeFromBinary;

	public Color _MatrixColor = new Color(1f, 0.3f, 0.3f, 1f);

	public static Color ChangeColorRGB;

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

	[SpecialName]
	private Material IGIAPKPKGPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return BJFKDHHMLJH;
	}

	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1195f)
			{
				HBJJOCHGOPH = 1492f;
			}
			PGPEMMBJOOG().SetFloat("Connection failed: ", HBJJOCHGOPH);
			LPMLLJKMAMP().SetFloat("_ScreenResolution", Fade);
			JIBOKBCPDLC().SetFloat("event", FadeFromBinary);
			LPMLLJKMAMP().SetFloat("CompletedLevel", _FixDistance);
			HEINDEMCGIK().SetFloat(" ", MatrixSize);
			OCHJIMJNEMO().SetColor("ShadersToggle", _MatrixColor);
			DKNJGHFLAIF().SetFloat(" not exist", MatrixSpeed * 1122f);
			NBPKMLMCHFN.SetFloat("SupportLogger OnApplicationPause: ", (!_Visualize) ? 1 : 0);
			FLOHGDECHHH().SetFloat("workshop.", LightIntensity);
			AELJLBOJAIL().SetTexture("EnvironmentSlider", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FLOHGDECHHH().SetFloat("<command>", 1732f / farClipPlane);
			AELJLBOJAIL().SetVector("inventory.itemscash", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 494f, 371f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1510f)
			{
				HBJJOCHGOPH = 378f;
			}
			FLOHGDECHHH().SetFloat("_Value2", HBJJOCHGOPH);
			LENEJAGLCNL().SetFloat("_Value2", Fade);
			OIMMPLPBLBK().SetFloat("_Value", FadeFromBinary);
			EMDFHOKEGNG().SetFloat("{0:0} hour{1}, ", _FixDistance);
			KGOLDDBHIFN().SetFloat("CameraFilterPack/Gradients_Tech", MatrixSize);
			CEKJODEAMGB().SetColor("_Blue_R", _MatrixColor);
			NBPKMLMCHFN.SetFloat("Image", MatrixSpeed * 152f);
			DKNJGHFLAIF().SetFloat("_Value4", (!_Visualize) ? 0 : 0);
			PGPEMMBJOOG().SetFloat("_ScreenResolution", LightIntensity);
			LENEJAGLCNL().SetTexture("_Value2", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			OIMMPLPBLBK().SetFloat("CameraFilterPack/RainFX", 961f / farClipPlane);
			EMDFHOKEGNG().SetVector("Alpha", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1102f, 1343f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ONKDMMJPEMN()
	{
	}

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 198f)
			{
				HBJJOCHGOPH = 398f;
			}
			KGOLDDBHIFN().SetFloat(" b.", HBJJOCHGOPH);
			HEINDEMCGIK().SetFloat(". Sent by actorNr: ", Fade);
			OCHJIMJNEMO().SetFloat("<command>", FadeFromBinary);
			BFGNMFCNDBC().SetFloat("CameraFilterPack/TV_Posterize", _FixDistance);
			EMDFHOKEGNG().SetFloat("wss://", MatrixSize);
			BFGNMFCNDBC().SetColor("_ColorRGB", _MatrixColor);
			DKNJGHFLAIF().SetFloat("_ScreenResolution", MatrixSpeed * 1322f);
			CEKJODEAMGB().SetFloat("LivesSlider", (!_Visualize) ? 0 : 0);
			CEKJODEAMGB().SetFloat("_FgCocMask", LightIntensity);
			KEMJNOMIPHN().SetTexture("Gameplay/Base", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FLOHGDECHHH().SetFloat("StartButton", 697f / farClipPlane);
			IGIAPKPKGPK().SetVector("_SecondTex", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1231f, 196f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KCDOMIJBFLL()
	{
	}

	private void OBAEDJJDCPN()
	{
	}

	private void IHLMNAGPKDA()
	{
		FPHEBLMINDA = Resources.Load("OpGetGameList()") as Texture2D;
		SCShader = Shader.Find("{0} days ago");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IMGGCJICLHK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DLBODOFAJGM()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack/Gradients_Ansi") as Texture2D;
		SCShader = Shader.Find("RoomDescriptionText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 934f)
			{
				HBJJOCHGOPH = 702f;
			}
			GKILCDHJFEG().SetFloat("End index must in an integer.", HBJJOCHGOPH);
			HEINDEMCGIK().SetFloat("/", Fade);
			MCDGIILBNIF().SetFloat("Tab2Content", FadeFromBinary);
			HFBJAOFLCJI().SetFloat("_Value", _FixDistance);
			MCDGIILBNIF().SetFloat("_ScreenResolution", MatrixSize);
			CEKJODEAMGB().SetColor("CameraFilterPack/EXTRA_SHOWFPS", _MatrixColor);
			IGIAPKPKGPK().SetFloat("Unknown player asked for PickupItems", MatrixSpeed * 1028f);
			DKNJGHFLAIF().SetFloat("CameraFilterPack/Pixelisation_Dot", (!_Visualize) ? 0 : 0);
			OCHJIMJNEMO().SetFloat("_Value1", LightIntensity);
			EPCGJFCCAFH().SetTexture("_Offsets", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			OIMMPLPBLBK().SetFloat("Particles/Additive", 480f / farClipPlane);
			JIBOKBCPDLC().SetVector("PUN-instantiated '", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 662f, 1256f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EGEGNHLODAA()
	{
	}

	private void ODAIMOJLJOF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Start()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_3D_Binary1") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/3D_Binary");
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
			NBPKMLMCHFN.SetFloat("_DepthLevel", Fade);
			NBPKMLMCHFN.SetFloat("_FadeFromBinary", FadeFromBinary);
			NBPKMLMCHFN.SetFloat("_FixDistance", _FixDistance);
			NBPKMLMCHFN.SetFloat("_MatrixSize", MatrixSize);
			NBPKMLMCHFN.SetColor("_MatrixColor", _MatrixColor);
			NBPKMLMCHFN.SetFloat("_MatrixSpeed", MatrixSpeed * 2f);
			NBPKMLMCHFN.SetFloat("_Visualize", _Visualize ? 1 : 0);
			NBPKMLMCHFN.SetFloat("_LightIntensity", LightIntensity);
			NBPKMLMCHFN.SetTexture("_MainTex2", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			NBPKMLMCHFN.SetFloat("_FarCamera", 1000f / farClipPlane);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KIMMMCJFMAB()
	{
		FPHEBLMINDA = Resources.Load("_Value2") as Texture2D;
		SCShader = Shader.Find("1159514800");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1371f)
			{
				HBJJOCHGOPH = 661f;
			}
			NBPKMLMCHFN.SetFloat("ResourceIDInputField", HBJJOCHGOPH);
			JIBOKBCPDLC().SetFloat("SlidingArea", Fade);
			IGIAPKPKGPK().SetFloat("maps.", FadeFromBinary);
			OIMMPLPBLBK().SetFloat("maps.", _FixDistance);
			AELJLBOJAIL().SetFloat("_Value3", MatrixSize);
			GKILCDHJFEG().SetColor("_BorderColor", _MatrixColor);
			LENEJAGLCNL().SetFloat(":", MatrixSpeed * 820f);
			KGOLDDBHIFN().SetFloat(" not exist", (!_Visualize) ? 0 : 0);
			FLOHGDECHHH().SetFloat("_TimeX", LightIntensity);
			JFDGLLEOPGB().SetTexture("EditMenu", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			NBPKMLMCHFN.SetFloat("false", 1987f / farClipPlane);
			LENEJAGLCNL().SetVector("_Value5", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 770f, 1321f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 211f)
			{
				HBJJOCHGOPH = 1646f;
			}
			CEKJODEAMGB().SetFloat("_Green_G", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("CameraFilterPack/Drawing_Comics", Fade);
			AELJLBOJAIL().SetFloat("Please specify a map name or buildID", FadeFromBinary);
			HFBJAOFLCJI().SetFloat("<b>#", _FixDistance);
			DKNJGHFLAIF().SetFloat("maps.", MatrixSize);
			FLOHGDECHHH().SetColor("\" gets executed locally only, if at all.", _MatrixColor);
			MCDGIILBNIF().SetFloat("Tab2Content", MatrixSpeed * 1239f);
			EPCGJFCCAFH().SetFloat("settings.enablehitsoundsinnormal", (!_Visualize) ? 1 : 0);
			DKNJGHFLAIF().SetFloat("_ScreenResolution", LightIntensity);
			HEINDEMCGIK().SetTexture("_FarCamera", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			EPCGJFCCAFH().SetFloat("CameraFilterPack/Broken_Screen", 1793f / farClipPlane);
			OCHJIMJNEMO().SetVector("_HalfResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1475f, 1192f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CEKJODEAMGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material AELJLBOJAIL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material DKNJGHFLAIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	private void MECJHOJPODB()
	{
	}

	private void FANADGBGCPI()
	{
		FPHEBLMINDA = Resources.Load("GhostFade") as Texture2D;
		SCShader = Shader.Find("Can't change CrcCheckEnabled while being connected. CrcCheckEnabled stays ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PMPKMGKAAJH()
	{
		FPHEBLMINDA = Resources.Load("setbool") as Texture2D;
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EDBEHEKMGFH()
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

	private void JOONHGHGKKF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GAOOPEEBGJA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LDDKCCMHMIC()
	{
	}

	private void COIJKMKIEAK()
	{
		FPHEBLMINDA = Resources.Load("menu.selectedlevelid") as Texture2D;
		SCShader = Shader.Find("_VignettingColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NKLIHNJCHOG()
	{
	}

	private void HLLHJIDOOGA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material FLOHGDECHHH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)90;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material LPMLLJKMAMP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material EPCGJFCCAFH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1741f)
			{
				HBJJOCHGOPH = 1370f;
			}
			NBPKMLMCHFN.SetFloat("_ZCurve", HBJJOCHGOPH);
			IGIAPKPKGPK().SetFloat("settings.hitvariation", Fade);
			KGOLDDBHIFN().SetFloat("_Offsets", FadeFromBinary);
			EPCGJFCCAFH().SetFloat("_Blue_G", _FixDistance);
			DKNJGHFLAIF().SetFloat(": ", MatrixSize);
			OCHJIMJNEMO().SetColor(",", _MatrixColor);
			LENEJAGLCNL().SetFloat("Jump", MatrixSpeed * 1235f);
			CEKJODEAMGB().SetFloat("_History1Weight", (!_Visualize) ? 0 : 0);
			HEINDEMCGIK().SetFloat("[Right]", LightIntensity);
			EPCGJFCCAFH().SetTexture("#highscore", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			LPMLLJKMAMP().SetFloat("/icon", 1397f / farClipPlane);
			NBPKMLMCHFN.SetVector("id", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1845f, 1541f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PLIKADJCEPO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ICILLMAKLMI()
	{
		FPHEBLMINDA = Resources.Load("_ScreenResolution") as Texture2D;
		SCShader = Shader.Find("float,1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material PGPEMMBJOOG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)112;
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

	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1942f)
			{
				HBJJOCHGOPH = 81f;
			}
			CEKJODEAMGB().SetFloat("Ev OwnershipTransfer. ViewID ", HBJJOCHGOPH);
			FLOHGDECHHH().SetFloat("[SteamManager] Connection established, authorization", Fade);
			KEMJNOMIPHN().SetFloat("VIGNETTE_CLASSIC", FadeFromBinary);
			DKNJGHFLAIF().SetFloat("CameraFilterPack_Atmosphere_Rain_FX", _FixDistance);
			LENEJAGLCNL().SetFloat("/icon", MatrixSize);
			NBPKMLMCHFN.SetColor("SetParticlesParticleSpeed", _MatrixColor);
			GKILCDHJFEG().SetFloat("CameraFilterPack/Blend2Camera_Darken", MatrixSpeed * 292f);
			CEKJODEAMGB().SetFloat("#C8C8C8FF", _Visualize ? 1 : 0);
			FLOHGDECHHH().SetFloat("mapselector.filter.subscribedonly", LightIntensity);
			JIBOKBCPDLC().SetTexture("CameraFilterPack/Color_RGB", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			CEKJODEAMGB().SetFloat("BadgeText", 995f / farClipPlane);
			OCHJIMJNEMO().SetVector(" : ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1413f, 1611f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LENEJAGLCNL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void JAAJECBCCFM()
	{
	}

	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1557f)
			{
				HBJJOCHGOPH = 789f;
			}
			AELJLBOJAIL().SetFloat("_Value", HBJJOCHGOPH);
			IGIAPKPKGPK().SetFloat("isVisible", Fade);
			HEINDEMCGIK().SetFloat("?", FadeFromBinary);
			KGOLDDBHIFN().SetFloat("_TimeX", _FixDistance);
			HFBJAOFLCJI().SetFloat("VisionBlur", MatrixSize);
			DKNJGHFLAIF().SetColor("_ThirdTex", _MatrixColor);
			KGOLDDBHIFN().SetFloat("Vertical", MatrixSpeed * 780f);
			EMDFHOKEGNG().SetFloat("Init", (!_Visualize) ? 1 : 1);
			PGPEMMBJOOG().SetFloat("DontDestroy", LightIntensity);
			FLOHGDECHHH().SetTexture("Mouse X", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			JFDGLLEOPGB().SetFloat("_ScreenResolution", 187f / farClipPlane);
			MCDGIILBNIF().SetVector("_Vibrance", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1065f, 1332f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GCHBGCGBMCK()
	{
	}

	[SpecialName]
	private Material HFBJAOFLCJI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-80);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material EMDFHOKEGNG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KEMJNOMIPHN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material OIMMPLPBLBK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)71;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material BFGNMFCNDBC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)115;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KGOLDDBHIFN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	private void CCLNNLCOPBL()
	{
		FPHEBLMINDA = Resources.Load("COMPLETED") as Texture2D;
		SCShader = Shader.Find("DPADVER");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material JFDGLLEOPGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-66);
		}
		return BJFKDHHMLJH;
	}

	private void KDMANOEMOCA()
	{
		FPHEBLMINDA = Resources.Load("_ArScale") as Texture2D;
		SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void Update()
	{
	}

	private void AIJGAJIOJDJ()
	{
	}

	private void AEDDNDHCLNN()
	{
		FPHEBLMINDA = Resources.Load("No Dispatcher exists in the scene. Actions will not be invoked!") as Texture2D;
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1715f)
			{
				HBJJOCHGOPH = 949f;
			}
			LENEJAGLCNL().SetFloat("closed", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_AlphaHexa", Fade);
			HEINDEMCGIK().SetFloat("_DotSize", FadeFromBinary);
			JIBOKBCPDLC().SetFloat("_TimeX", _FixDistance);
			KGOLDDBHIFN().SetFloat("Mouse ", MatrixSize);
			OIMMPLPBLBK().SetColor(" PhotonNetwork.networkingPeer.AvailableRegions ", _MatrixColor);
			GKILCDHJFEG().SetFloat("UsernameText", MatrixSpeed * 1201f);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", (!_Visualize) ? 1 : 0);
			OIMMPLPBLBK().SetFloat("CameraFilterPack/Color_YUV", LightIntensity);
			FLOHGDECHHH().SetTexture("InventoryButton", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			NBPKMLMCHFN.SetFloat("Misses:", 1559f / farClipPlane);
			LPMLLJKMAMP().SetVector("tagElement", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 605f, 1727f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 7f)
			{
				HBJJOCHGOPH = 1252f;
			}
			LENEJAGLCNL().SetFloat("#join", HBJJOCHGOPH);
			HEINDEMCGIK().SetFloat("_Distortion", Fade);
			EPCGJFCCAFH().SetFloat("ChatHistoryInputField", FadeFromBinary);
			IGIAPKPKGPK().SetFloat("HandleEventLeave for player ID: ", _FixDistance);
			FLOHGDECHHH().SetFloat("_PrevViewProj", MatrixSize);
			KGOLDDBHIFN().SetColor("Set Trail Zoom (player camera move forward effect). Base value - 1.5", _MatrixColor);
			CEKJODEAMGB().SetFloat("Up ", MatrixSpeed * 719f);
			FLOHGDECHHH().SetFloat("offsets", (!_Visualize) ? 1 : 1);
			PGPEMMBJOOG().SetFloat("settings.disablestoryboard", LightIntensity);
			BFGNMFCNDBC().SetTexture("Source directory does not exist or could not be found: ", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			JFDGLLEOPGB().SetFloat("_MainTex2", 707f / farClipPlane);
			NBPKMLMCHFN.SetVector("_Distortion", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1631f, 25f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LPMINJJPDCH()
	{
	}

	private void LMADKINICIN()
	{
	}

	private void NBGIMIDICKE()
	{
		FPHEBLMINDA = Resources.Load("skin.") as Texture2D;
		SCShader = Shader.Find("[Down]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 181f)
			{
				HBJJOCHGOPH = 1900f;
			}
			JIBOKBCPDLC().SetFloat("_History1LumaTex", HBJJOCHGOPH);
			PGPEMMBJOOG().SetFloat("_TimeX", Fade);
			BFGNMFCNDBC().SetFloat("[Down]", FadeFromBinary);
			GKILCDHJFEG().SetFloat("[LevelEditorScene] Map submitted!", _FixDistance);
			JIBOKBCPDLC().SetFloat("MenuScene", MatrixSize);
			AELJLBOJAIL().SetColor("</color>", _MatrixColor);
			CEKJODEAMGB().SetFloat("#close", MatrixSpeed * 5f);
			LPMLLJKMAMP().SetFloat("_RedAmplifier", _Visualize ? 1 : 0);
			MCDGIILBNIF().SetFloat("Prints the number of logs currently held by DebugLogs", LightIntensity);
			MCDGIILBNIF().SetTexture("#yes", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			DKNJGHFLAIF().SetFloat("#", 1424f / farClipPlane);
			CEKJODEAMGB().SetVector("Item invalid. Make sure your mod contains at leats one file.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1917f, 1244f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CEKJODEAMGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LIEGJOHINGC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HIKKPDACJGI()
	{
	}

	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 295f)
			{
				HBJJOCHGOPH = 1891f;
			}
			EPCGJFCCAFH().SetFloat("USE_UV_BASED_REPROJECTION", HBJJOCHGOPH);
			LENEJAGLCNL().SetFloat("SetupEncryption() called but ignored. Not XB1 compiled. EncryptionData: ", Fade);
			IGIAPKPKGPK().SetFloat("_TimeX", FadeFromBinary);
			HFBJAOFLCJI().SetFloat("other.dust0", _FixDistance);
			LENEJAGLCNL().SetFloat("_Smooth", MatrixSize);
			JIBOKBCPDLC().SetColor("CameraFilterPack/Blend2Camera_HardLight", _MatrixColor);
			OCHJIMJNEMO().SetFloat("1159514800", MatrixSpeed * 1188f);
			KGOLDDBHIFN().SetFloat("_BlurRadius4", _Visualize ? 1 : 0);
			JFDGLLEOPGB().SetFloat("_ScreenResolution", LightIntensity);
			OIMMPLPBLBK().SetTexture("CHROMATIC_ABERRATION", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			JIBOKBCPDLC().SetFloat("_Offsets", 752f / farClipPlane);
			GKILCDHJFEG().SetVector("Cannot send messages when not connected. Either connect to Photon OR use offline mode!", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 186f, 1208f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KNBJBNDGCIJ()
	{
		FPHEBLMINDA = Resources.Load("BackButton") as Texture2D;
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BMIOFJFMCBG()
	{
		FPHEBLMINDA = Resources.Load("_ScreenResolution") as Texture2D;
		SCShader = Shader.Find("SetCrosshairColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FMFNILJIEIA()
	{
		FPHEBLMINDA = Resources.Load("Prints the number of logs currently held by DebugLogs") as Texture2D;
		SCShader = Shader.Find("CreateRoom failed, client stays on masterserver: {0}.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KMEONPMCNJG()
	{
	}

	[SpecialName]
	private Material MCDGIILBNIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)119;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material GKILCDHJFEG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-68);
		}
		return BJFKDHHMLJH;
	}

	private void MFMIODIAKNI()
	{
	}

	private void FGBDGGCBFLP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1422f)
			{
				HBJJOCHGOPH = 384f;
			}
			DKNJGHFLAIF().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			EMDFHOKEGNG().SetFloat("CameraFilterPack/Distortion_Dream", Fade);
			DKNJGHFLAIF().SetFloat("LevelInfoInputField", FadeFromBinary);
			KGOLDDBHIFN().SetFloat("mapselector.filter.subscribedonly", _FixDistance);
			HFBJAOFLCJI().SetFloat("\"", MatrixSize);
			PGPEMMBJOOG().SetColor("#forever", _MatrixColor);
			FLOHGDECHHH().SetFloat("_EmissionColor", MatrixSpeed * 1550f);
			PGPEMMBJOOG().SetFloat("Bad parameters for setbool! Use <key> <value>", _Visualize ? 1 : 0);
			BFGNMFCNDBC().SetFloat("ItemNameBGImage", LightIntensity);
			CEKJODEAMGB().SetTexture("appid", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			JIBOKBCPDLC().SetFloat(":", 1276f / farClipPlane);
			EMDFHOKEGNG().SetVector("CameraFilterPack/Blend2Camera_Hue", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1382f, 1081f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MNBPNHNAEBK()
	{
		FPHEBLMINDA = Resources.Load("_TimeX") as Texture2D;
		SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1026f)
			{
				HBJJOCHGOPH = 414f;
			}
			LPMLLJKMAMP().SetFloat("[MapsData] Found ", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("#random #epic #item", Fade);
			IGIAPKPKGPK().SetFloat("_FadeShield", FadeFromBinary);
			EMDFHOKEGNG().SetFloat("CameraFilterPack_VHS2", _FixDistance);
			JIBOKBCPDLC().SetFloat("fade in duration", MatrixSize);
			BFGNMFCNDBC().SetColor("Delete events", _MatrixColor);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Blend2Camera_Lighten", MatrixSpeed * 1608f);
			HEINDEMCGIK().SetFloat("x", (!_Visualize) ? 0 : 0);
			FLOHGDECHHH().SetFloat("_TimeX", LightIntensity);
			CEKJODEAMGB().SetTexture("Tab1Content", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			AELJLBOJAIL().SetFloat("_Value2", 522f / farClipPlane);
			LENEJAGLCNL().SetVector("Tab1Content", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 289f, 70f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 149f)
			{
				HBJJOCHGOPH = 1152f;
			}
			PGPEMMBJOOG().SetFloat("Texture2", HBJJOCHGOPH);
			LPMLLJKMAMP().SetFloat("_VelTex", Fade);
			IGIAPKPKGPK().SetFloat("_MainTex", FadeFromBinary);
			HFBJAOFLCJI().SetFloat("_MainTex2", _FixDistance);
			HEINDEMCGIK().SetFloat("[ItemsHandler] Found ", MatrixSize);
			BFGNMFCNDBC().SetColor("_SSRMultiplier", _MatrixColor);
			GKILCDHJFEG().SetFloat("Failed to 'network-remove' GameObject because it's null.", MatrixSpeed * 1312f);
			FLOHGDECHHH().SetFloat(".status", (!_Visualize) ? 1 : 0);
			AELJLBOJAIL().SetFloat("Tab1Content", LightIntensity);
			JFDGLLEOPGB().SetTexture("[ItemsHandler] Inventory not changed", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			JIBOKBCPDLC().SetFloat(":", 188f / farClipPlane);
			DKNJGHFLAIF().SetVector("float,10", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1177f, 171f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 211f)
			{
				HBJJOCHGOPH = 227f;
			}
			KGOLDDBHIFN().SetFloat("_Factor", HBJJOCHGOPH);
			OCHJIMJNEMO().SetFloat("error", Fade);
			HFBJAOFLCJI().SetFloat("_Colored", FadeFromBinary);
			DKNJGHFLAIF().SetFloat("maps.", _FixDistance);
			LENEJAGLCNL().SetFloat("_BorderColor", MatrixSize);
			FLOHGDECHHH().SetColor("ResourcesConfig", _MatrixColor);
			FLOHGDECHHH().SetFloat("0.00", MatrixSpeed * 398f);
			HEINDEMCGIK().SetFloat("_Value3", (!_Visualize) ? 1 : 1);
			DKNJGHFLAIF().SetFloat(".lastCheckpoint.longestComboScore", LightIntensity);
			HEINDEMCGIK().SetTexture("CameraFilterPack_TV_Noise3", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			EMDFHOKEGNG().SetFloat("[FileSelector] Dialog ended, result: ", 605f / farClipPlane);
			KGOLDDBHIFN().SetVector("Joystick1Button4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 563f, 1555f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KIEJKBNBHMD()
	{
	}

	private void JHJGJJKELJM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material CEKJODEAMGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-93);
		}
		return BJFKDHHMLJH;
	}

	private void LBAJLLFMMMP()
	{
		FPHEBLMINDA = Resources.Load("_Parasite") as Texture2D;
		SCShader = Shader.Find("<command>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
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
	private Material OCHJIMJNEMO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)79;
		}
		return BJFKDHHMLJH;
	}

	private void ANCKKLFPGDI()
	{
		FPHEBLMINDA = Resources.Load(" ") as Texture2D;
		SCShader = Shader.Find("local CheckCondition = function()");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ALMGMOOHLMA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HEINDEMCGIK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)94;
		}
		return BJFKDHHMLJH;
	}

	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1058f)
			{
				HBJJOCHGOPH = 1890f;
			}
			DKNJGHFLAIF().SetFloat("settings_bindings_sec_", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat(". Using max value: 255.", Fade);
			EMDFHOKEGNG().SetFloat("SetSatelliteColor", FadeFromBinary);
			OIMMPLPBLBK().SetFloat("_Intensity", _FixDistance);
			EMDFHOKEGNG().SetFloat("CameraFilterPack/Fly_Vision", MatrixSize);
			HFBJAOFLCJI().SetColor("Screenshots only supported in PlayMode", _MatrixColor);
			EMDFHOKEGNG().SetFloat("_MainTex2", MatrixSpeed * 502f);
			JFDGLLEOPGB().SetFloat(".r", _Visualize ? 1 : 0);
			OCHJIMJNEMO().SetFloat("CameraFilterPack/Color_GrayScale", LightIntensity);
			OCHJIMJNEMO().SetTexture("PLEASE WAIT", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			KEMJNOMIPHN().SetFloat("BitsData", 1477f / farClipPlane);
			FLOHGDECHHH().SetVector("[Up]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1518f, 768f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 267f)
			{
				HBJJOCHGOPH = 1787f;
			}
			LPMLLJKMAMP().SetFloat("  |  Events Count: ", HBJJOCHGOPH);
			HEINDEMCGIK().SetFloat("_CurrentMipLevel", Fade);
			GKILCDHJFEG().SetFloat("_Red_B", FadeFromBinary);
			JFDGLLEOPGB().SetFloat("CameraFilterPack/AAA_WaterDropPro", _FixDistance);
			HEINDEMCGIK().SetFloat("[PlayerController] ", MatrixSize);
			MCDGIILBNIF().SetColor("CameraFilterPack/Lut_Simple", _MatrixColor);
			AELJLBOJAIL().SetFloat("x", MatrixSpeed * 1707f);
			BFGNMFCNDBC().SetFloat("CameraFilterPack/Distortion_ShockWaveManual", (!_Visualize) ? 0 : 0);
			EPCGJFCCAFH().SetFloat("[Right]", LightIntensity);
			IGIAPKPKGPK().SetTexture("StartButton", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			CEKJODEAMGB().SetFloat("IconFileSelector", 494f / farClipPlane);
			IGIAPKPKGPK().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1491f, 558f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
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
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.HideInInspector | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}
}
