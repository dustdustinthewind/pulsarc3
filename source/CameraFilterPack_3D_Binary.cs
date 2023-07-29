// CameraFilterPack_3D_Binary
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/3D/Binary")]
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
			EMDFHOKEGNG().SetFloat("Connection failed: ", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("_ScreenResolution", Fade);
			CEKJODEAMGB().SetFloat("StopMusic", FadeFromBinary);
			NBPKMLMCHFN.SetFloat("settings.gamemessagesduration", _FixDistance);
			NBPKMLMCHFN.SetFloat(" ", MatrixSize);
			CEKJODEAMGB().SetColor("FPSToggle", _MatrixColor);
			PGPEMMBJOOG().SetFloat(": ", MatrixSpeed * 1122f);
			EMDFHOKEGNG().SetFloat("SupportLogger Info: PUN {0}: ", (!_Visualize) ? 1 : 0);
			GKILCDHJFEG().SetFloat("http://steamcommunity.com/sharedfiles/filedetails/?id=", LightIntensity);
			JFDGLLEOPGB().SetTexture("HandsCountSlider", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			MCDGIILBNIF().SetFloat("Please specify a map name or buildID", 1732f / farClipPlane);
			GKILCDHJFEG().SetVector("inventory.itemscash", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 494f, 371f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
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
			HFBJAOFLCJI().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			OCHJIMJNEMO().SetFloat("_ScreenResolution", Fade);
			GKILCDHJFEG().SetFloat("_Value2", FadeFromBinary);
			JIBOKBCPDLC().SetFloat("{0:0} hour{1}, ", _FixDistance);
			HFBJAOFLCJI().SetFloat("_TimeX", MatrixSize);
			LENEJAGLCNL().SetColor("_Blue_R", _MatrixColor);
			KGOLDDBHIFN().SetFloat("GroupNameText", MatrixSpeed * 152f);
			NBPKMLMCHFN.SetFloat("_Fade", (!_Visualize) ? 0 : 0);
			DKNJGHFLAIF().SetFloat("_ScreenResolution", LightIntensity);
			NBPKMLMCHFN.SetTexture("_Value2", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			CEKJODEAMGB().SetFloat("_Value", 961f / farClipPlane);
			AELJLBOJAIL().SetVector("Keypad", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1102f, 1343f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
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
			FLOHGDECHHH().SetFloat("\nv.", HBJJOCHGOPH);
			PGPEMMBJOOG().SetFloat("Warning: Unhandled event ", Fade);
			EPCGJFCCAFH().SetFloat("<command>", FadeFromBinary);
			KEMJNOMIPHN().SetFloat("_TimeX", _FixDistance);
			GKILCDHJFEG().SetFloat("catched: ", MatrixSize);
			JIBOKBCPDLC().SetColor("_ColorRGB", _MatrixColor);
			JIBOKBCPDLC().SetFloat("_Value", MatrixSpeed * 1322f);
			JIBOKBCPDLC().SetFloat("LivesSlider", (!_Visualize) ? 0 : 0);
			EMDFHOKEGNG().SetFloat("_Offsets", LightIntensity);
			KEMJNOMIPHN().SetTexture("Gameplay/Base", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			BFGNMFCNDBC().SetFloat("StartButton", 697f / farClipPlane);
			OIMMPLPBLBK().SetVector("_EdgeThreshold", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1231f, 196f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OCHJIMJNEMO());
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
		FPHEBLMINDA = Resources.Load("OpGetGameList not sent. LobbyType must be SqlLobby.") as Texture2D;
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
		FPHEBLMINDA = Resources.Load("_TimeX") as Texture2D;
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
			NBPKMLMCHFN.SetFloat("Please specify either t or f.", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("/", Fade);
			EPCGJFCCAFH().SetFloat("HandsCountSlider", FadeFromBinary);
			JFDGLLEOPGB().SetFloat("_ScreenResolution", _FixDistance);
			DKNJGHFLAIF().SetFloat("CameraFilterPack/FX_InverChromiLum", MatrixSize);
			EMDFHOKEGNG().SetColor("_TimeX", _MatrixColor);
			HFBJAOFLCJI().SetFloat(" timeUntilRespawn: ", MatrixSpeed * 1028f);
			GKILCDHJFEG().SetFloat("_TimeX", (!_Visualize) ? 0 : 0);
			DKNJGHFLAIF().SetFloat("_Value2", LightIntensity);
			HEINDEMCGIK().SetTexture("_Offsets", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			JIBOKBCPDLC().SetFloat("Particles/Additive", 480f / farClipPlane);
			DKNJGHFLAIF().SetVector("Observed type is not serializable: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 662f, 1256f));
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
		FPHEBLMINDA = Resources.Load("_Value3") as Texture2D;
		SCShader = Shader.Find("achievements.21.completed.workshop.");
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
			MCDGIILBNIF().SetFloat("EventTimeInputField", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("ItemTemplate", Fade);
			AELJLBOJAIL().SetFloat("maps.", FadeFromBinary);
			NBPKMLMCHFN.SetFloat("maps.", _FixDistance);
			IGIAPKPKGPK().SetFloat("_Value3", MatrixSize);
			PGPEMMBJOOG().SetColor("_BorderColor", _MatrixColor);
			OIMMPLPBLBK().SetFloat(",", MatrixSpeed * 820f);
			CEKJODEAMGB().SetFloat("[PlayerController] ", (!_Visualize) ? 0 : 0);
			KEMJNOMIPHN().SetFloat("_Value", LightIntensity);
			KGOLDDBHIFN().SetTexture("FileMenu", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			CEKJODEAMGB().SetFloat("Please specify either t or f.", 1987f / farClipPlane);
			LPMLLJKMAMP().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 770f, 1321f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EMDFHOKEGNG());
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
			LENEJAGLCNL().SetFloat("_Green_B", HBJJOCHGOPH);
			EMDFHOKEGNG().SetFloat("_TimeX", Fade);
			AELJLBOJAIL().SetFloat(". Name: ", FadeFromBinary);
			DKNJGHFLAIF().SetFloat("<b>#", _FixDistance);
			CEKJODEAMGB().SetFloat("finished", MatrixSize);
			IGIAPKPKGPK().SetColor(". Possible scene loading in progress?", _MatrixColor);
			BFGNMFCNDBC().SetFloat("Tab2Content", MatrixSpeed * 1239f);
			FLOHGDECHHH().SetFloat("settings.selectormapsperpage", (!_Visualize) ? 1 : 0);
			EPCGJFCCAFH().SetFloat("CameraFilterPack_eyes_vision_1", LightIntensity);
			DKNJGHFLAIF().SetTexture("_FarCamera", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			JIBOKBCPDLC().SetFloat("CameraFilterPack/Broken_Screen", 1793f / farClipPlane);
			HFBJAOFLCJI().SetVector("_PixelsPerMeterAtOneMeter", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1475f, 1192f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
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
		SCShader = Shader.Find("Can't connect: Loading settings failed. ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PMPKMGKAAJH()
	{
		FPHEBLMINDA = Resources.Load("Bad parameters for setbool! Use <key> <value>") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Distortion_Flag");
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
		FPHEBLMINDA = Resources.Load("menu.selectedplaymode") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/TV_Vintage");
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
			EMDFHOKEGNG().SetFloat("_Saturation", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("BloomShaderValueSlider", Fade);
			NBPKMLMCHFN.SetFloat("_FgOverlap", FadeFromBinary);
			LPMLLJKMAMP().SetFloat("_Blue_B", _FixDistance);
			MCDGIILBNIF().SetFloat(" not exist", MatrixSize);
			DKNJGHFLAIF().SetColor("SUBMIT '{0}' FILES", _MatrixColor);
			BFGNMFCNDBC().SetFloat("PRESS A KEY", MatrixSpeed * 1235f);
			BFGNMFCNDBC().SetFloat("_History3Weight", (!_Visualize) ? 0 : 0);
			MCDGIILBNIF().SetFloat("ready", LightIntensity);
			JFDGLLEOPGB().SetTexture("#combo", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			PGPEMMBJOOG().SetFloat("/icon", 1397f / farClipPlane);
			HFBJAOFLCJI().SetVector("id", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1845f, 1541f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
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
		FPHEBLMINDA = Resources.Load("Coord") as Texture2D;
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
			JFDGLLEOPGB().SetFloat(" Time: ", HBJJOCHGOPH);
			LPMLLJKMAMP().SetFloat(" - GameWebCallback] - ", Fade);
			NBPKMLMCHFN.SetFloat("VIGNETTE_FILMIC", FadeFromBinary);
			HEINDEMCGIK().SetFloat("CameraFilterPack_Atmosphere_Rain_FX", _FixDistance);
			JFDGLLEOPGB().SetFloat("/icon", MatrixSize);
			AELJLBOJAIL().SetColor("Set Particles Speed", _MatrixColor);
			KGOLDDBHIFN().SetFloat("CameraFilterPack/Blend2Camera_Darken", MatrixSpeed * 292f);
			GKILCDHJFEG().SetFloat("RecordButton", _Visualize ? 1 : 0);
			DKNJGHFLAIF().SetFloat("mapselector.filter.favoriteonly", LightIntensity);
			EMDFHOKEGNG().SetTexture("CameraFilterPack/Color_RGB", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			OIMMPLPBLBK().SetFloat("BadgeText", 995f / farClipPlane);
			DKNJGHFLAIF().SetVector("setbool", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1413f, 1611f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OCHJIMJNEMO());
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
			EPCGJFCCAFH().SetFloat("_Value", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("isVisible", Fade);
			AELJLBOJAIL().SetFloat("Use ticket: ", FadeFromBinary);
			NBPKMLMCHFN.SetFloat("_Value", _FixDistance);
			OCHJIMJNEMO().SetFloat("GlassDistortion", MatrixSize);
			LPMLLJKMAMP().SetColor("_EdgeThresholdMin", _MatrixColor);
			JFDGLLEOPGB().SetFloat("There is already a virtual axis named ", MatrixSpeed * 780f);
			OCHJIMJNEMO().SetFloat("[MapEditor] Loading events...", (!_Visualize) ? 1 : 1);
			HEINDEMCGIK().SetFloat("Can't find key ", LightIntensity);
			LENEJAGLCNL().SetTexture("Mouse Y", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FLOHGDECHHH().SetFloat("_ScreenResolution", 187f / farClipPlane);
			FLOHGDECHHH().SetVector("_ChannelMixerRed", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1065f, 1332f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EMDFHOKEGNG());
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
		FPHEBLMINDA = Resources.Load("BadgeText") as Texture2D;
		SCShader = Shader.Find("DPADHOR");
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
		FPHEBLMINDA = Resources.Load("_Sensitivity") as Texture2D;
		SCShader = Shader.Find("_Value4");
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
		SCShader = Shader.Find("_ScreenResolution");
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
			OIMMPLPBLBK().SetFloat("visible", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("_AlphaHexa", Fade);
			FLOHGDECHHH().SetFloat("CameraFilterPack/Drawing_Manga_Flash", FadeFromBinary);
			IGIAPKPKGPK().SetFloat("_TimeX", _FixDistance);
			JIBOKBCPDLC().SetFloat("Mouse Wheel Up", MatrixSize);
			JIBOKBCPDLC().SetColor("Found best region: '", _MatrixColor);
			IGIAPKPKGPK().SetFloat("SpectatingUserInfo", MatrixSpeed * 1201f);
			PGPEMMBJOOG().SetFloat("CameraFilterPack/FX_Glitch1", (!_Visualize) ? 1 : 0);
			HFBJAOFLCJI().SetFloat("_TimeX", LightIntensity);
			EMDFHOKEGNG().SetTexture("InventoryButton", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HFBJAOFLCJI().SetFloat("Misses:", 1559f / farClipPlane);
			JFDGLLEOPGB().SetVector("tagElement", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 605f, 1727f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
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
			BFGNMFCNDBC().SetFloat("#join", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("_Distortion", Fade);
			HEINDEMCGIK().SetFloat("ChatHistoryInputField", FadeFromBinary);
			OIMMPLPBLBK().SetFloat("Received event Leave for unknown player ID: {0}", _FixDistance);
			AELJLBOJAIL().SetFloat("_MaxVelocity", MatrixSize);
			LPMLLJKMAMP().SetColor("AddEnvironmentObject", _MatrixColor);
			AELJLBOJAIL().SetFloat("Down", MatrixSpeed * 719f);
			LPMLLJKMAMP().SetFloat("tintColor", (!_Visualize) ? 1 : 1);
			EPCGJFCCAFH().SetFloat("settings.enableselectormusic", LightIntensity);
			IGIAPKPKGPK().SetTexture("Source directory does not exist or could not be found: ", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			NBPKMLMCHFN.SetFloat("_TimeX", 707f / farClipPlane);
			LENEJAGLCNL().SetVector("_Distortion", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1631f, 25f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
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
		FPHEBLMINDA = Resources.Load(".icon") as Texture2D;
		SCShader = Shader.Find("[Up]");
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
			EPCGJFCCAFH().SetFloat("_History3LumaTex", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("_TimeX", Fade);
			OCHJIMJNEMO().SetFloat("[Left]", FadeFromBinary);
			NBPKMLMCHFN.SetFloat("[LevelEditorScene] Map submitted!", _FixDistance);
			HEINDEMCGIK().SetFloat("MenuScene", MatrixSize);
			IGIAPKPKGPK().SetColor("Connection error: ", _MatrixColor);
			JIBOKBCPDLC().SetFloat("#onfirstranktext", MatrixSpeed * 5f);
			KGOLDDBHIFN().SetFloat("_RedAmplifier", _Visualize ? 1 : 0);
			MCDGIILBNIF().SetFloat("quit", LightIntensity);
			IGIAPKPKGPK().SetTexture("[MapsEditor] Creating new item...", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			GKILCDHJFEG().SetFloat("G:", 1424f / farClipPlane);
			KEMJNOMIPHN().SetVector("https://steamcommunity.com/sharedfiles/filedetails/?id=", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1917f, 1244f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
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
			EMDFHOKEGNG().SetFloat("_BlendTex", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("SendVacantViewIds()", Fade);
			FLOHGDECHHH().SetFloat("_TimeX", FadeFromBinary);
			JFDGLLEOPGB().SetFloat("other.dust0", _FixDistance);
			FLOHGDECHHH().SetFloat("_ScreenResolution", MatrixSize);
			BFGNMFCNDBC().SetColor("CameraFilterPack/Blend2Camera_VividLight", _MatrixColor);
			OCHJIMJNEMO().SetFloat("achievements.21.progress", MatrixSpeed * 1188f);
			FLOHGDECHHH().SetFloat("_SunThreshold", _Visualize ? 1 : 0);
			MCDGIILBNIF().SetFloat("_ScreenResolution", LightIntensity);
			HFBJAOFLCJI().SetTexture("_VignetteColor", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			LENEJAGLCNL().SetFloat("_Offsets", 752f / farClipPlane);
			EPCGJFCCAFH().SetVector("CreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 186f, 1208f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KNBJBNDGCIJ()
	{
		FPHEBLMINDA = Resources.Load("BackButton") as Texture2D;
		SCShader = Shader.Find("_Red_R");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BMIOFJFMCBG()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack/FX_Glitch3") as Texture2D;
		SCShader = Shader.Find("SetParticlesParticleSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FMFNILJIEIA()
	{
		FPHEBLMINDA = Resources.Load("quit") as Texture2D;
		SCShader = Shader.Find("JoinRandom failed: {0}.");
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
			KGOLDDBHIFN().SetFloat("CameraFilterPack/FX_Funk", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat("_TimeX", Fade);
			KGOLDDBHIFN().SetFloat("LevelNameInputField", FadeFromBinary);
			FLOHGDECHHH().SetFloat("mapselector.filter.rateduponly", _FixDistance);
			KEMJNOMIPHN().SetFloat("#or", MatrixSize);
			FLOHGDECHHH().SetColor("restrictions\n\n#until: ", _MatrixColor);
			PGPEMMBJOOG().SetFloat("_EmissionColor", MatrixSpeed * 1550f);
			KGOLDDBHIFN().SetFloat("getbool", _Visualize ? 1 : 0);
			PGPEMMBJOOG().SetFloat("ItemNameText", LightIntensity);
			JFDGLLEOPGB().SetTexture("76561198041679481", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			BFGNMFCNDBC().SetFloat(",", 1276f / farClipPlane);
			JIBOKBCPDLC().SetVector("CameraFilterPack/Blend2Camera_Saturation", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1382f, 1081f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MNBPNHNAEBK()
	{
		FPHEBLMINDA = Resources.Load("_Value2") as Texture2D;
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
			DKNJGHFLAIF().SetFloat("[MapsData] Caching ", HBJJOCHGOPH);
			HEINDEMCGIK().SetFloat("materialsitemid[", Fade);
			KGOLDDBHIFN().SetFloat("_FadeShield", FadeFromBinary);
			HEINDEMCGIK().SetFloat("VHS", _FixDistance);
			EMDFHOKEGNG().SetFloat("seconds", MatrixSize);
			JFDGLLEOPGB().SetColor(",0", _MatrixColor);
			AELJLBOJAIL().SetFloat("CameraFilterPack/Blend2Camera_Lighten", MatrixSpeed * 1608f);
			FLOHGDECHHH().SetFloat("w", (!_Visualize) ? 0 : 0);
			HFBJAOFLCJI().SetFloat("_Amount", LightIntensity);
			NBPKMLMCHFN.SetTexture("Tab1Content", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			DKNJGHFLAIF().SetFloat("_Value2", 522f / farClipPlane);
			LENEJAGLCNL().SetVector("LevelURLInputField", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 289f, 70f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLOHGDECHHH());
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
			EPCGJFCCAFH().SetFloat("CameraFilterPack/Real_VHS", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("_TileTexDebug", Fade);
			GKILCDHJFEG().SetFloat("_Intensity", FadeFromBinary);
			HFBJAOFLCJI().SetFloat("_TimeX", _FixDistance);
			JFDGLLEOPGB().SetFloat("player.blackcat", MatrixSize);
			BFGNMFCNDBC().SetColor("_FresnelFadePower", _MatrixColor);
			DKNJGHFLAIF().SetFloat("Failed to 'network-remove' GameObject because it is missing a valid InstantiationId on view: ", MatrixSpeed * 1312f);
			GKILCDHJFEG().SetFloat("resetall", (!_Visualize) ? 1 : 0);
			PGPEMMBJOOG().SetFloat("LevelInfoInputField", LightIntensity);
			NBPKMLMCHFN.SetTexture("inventory.itemscash", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			LPMLLJKMAMP().SetFloat(": ", 188f / farClipPlane);
			CEKJODEAMGB().SetVector("color", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1177f, 171f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			LPMLLJKMAMP().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			IGIAPKPKGPK().SetFloat("#md5submitionfailed: ", Fade);
			BFGNMFCNDBC().SetFloat("_ScreenResolution", FadeFromBinary);
			AELJLBOJAIL().SetFloat("maps.", _FixDistance);
			LENEJAGLCNL().SetFloat("_BorderColor", MatrixSize);
			NBPKMLMCHFN.SetColor("#ok", _MatrixColor);
			KGOLDDBHIFN().SetFloat("EVENT CONFIG [Ctrl+E]", MatrixSpeed * 398f);
			KEMJNOMIPHN().SetFloat("_Value4", (!_Visualize) ? 1 : 1);
			FLOHGDECHHH().SetFloat(".lastCheckpoint.maxLongestCombo", LightIntensity);
			NBPKMLMCHFN.SetTexture("_TimeX", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			NBPKMLMCHFN.SetFloat("[FileSelector] Dialog canceled", 605f / farClipPlane);
			GKILCDHJFEG().SetVector("L1", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 563f, 1555f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
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
		FPHEBLMINDA = Resources.Load("CameraFilterPack/TV_Distorted") as Texture2D;
		SCShader = Shader.Find("Please specify a map name or buildID");
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
		FPHEBLMINDA = Resources.Load(".") as Texture2D;
		SCShader = Shader.Find("skin.");
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
			HFBJAOFLCJI().SetFloat("settings_bindings_controller_type", HBJJOCHGOPH);
			LENEJAGLCNL().SetFloat("visible", Fade);
			LPMLLJKMAMP().SetFloat("SetSatelliteInput", FadeFromBinary);
			EMDFHOKEGNG().SetFloat("_VignetteTex", _FixDistance);
			IGIAPKPKGPK().SetFloat("_TimeX", MatrixSize);
			EPCGJFCCAFH().SetColor("SSAARenderTargetCamera", _MatrixColor);
			OIMMPLPBLBK().SetFloat("_TimeX", MatrixSpeed * 502f);
			BFGNMFCNDBC().SetFloat(".r", _Visualize ? 1 : 0);
			OCHJIMJNEMO().SetFloat("_TimeX", LightIntensity);
			IGIAPKPKGPK().SetTexture("PLEASE WAIT", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			CEKJODEAMGB().SetFloat("BitsData", 1477f / farClipPlane);
			AELJLBOJAIL().SetVector("uploads/Intralism/mods_terms.pdf", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1518f, 768f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
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
			AELJLBOJAIL().SetFloat("#mapnotloaded", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("Internal LUT", Fade);
			LENEJAGLCNL().SetFloat("_Green_R", FadeFromBinary);
			OIMMPLPBLBK().SetFloat("CameraFilterPack/AAA_WaterDropPro", _FixDistance);
			MCDGIILBNIF().SetFloat(": ", MatrixSize);
			CEKJODEAMGB().SetColor("The given 2D texture ", _MatrixColor);
			JFDGLLEOPGB().SetFloat("float,0", MatrixSpeed * 1707f);
			AELJLBOJAIL().SetFloat("_TimeX", (!_Visualize) ? 0 : 0);
			OCHJIMJNEMO().SetFloat("[Right]", LightIntensity);
			CEKJODEAMGB().SetTexture("StartButton", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			EMDFHOKEGNG().SetFloat("MusicFileSelector", 494f / farClipPlane);
			CEKJODEAMGB().SetVector("_Red_R", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1491f, 558f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
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
