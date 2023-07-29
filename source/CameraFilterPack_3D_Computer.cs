// CameraFilterPack_3D_Computer
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/3D/Computer")]
[ExecuteInEditMode]
public class CameraFilterPack_3D_Computer : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	public bool _Visualize;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 100f)]
	public float _FixDistance = 2f;

	[Range(-5f, 5f)]
	public float LightIntensity = 1f;

	[Range(0f, 8f)]
	public float MatrixSize = 2f;

	[Range(-4f, 4f)]
	public float MatrixSpeed = 0.1f;

	[Range(0f, 1f)]
	public float Fade = 1f;

	public Color _MatrixColor = new Color(0f, 0.5f, 1f, 1f);

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

	private void CFIAKIJAILI()
	{
	}

	private void EAHCLIEEJOG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material FAIFBBGFAIB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1706f)
			{
				HBJJOCHGOPH = 662f;
			}
			DKKBFFHBHJE().SetFloat("CameraFilterPack/Lut_TestMode", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("y", Fade);
			EFMCNLELMDO().SetFloat("OxOD.lastPath", _FixDistance);
			HKHBBBFLGJH().SetFloat("[Left]", MatrixSize);
			IGKFMCPDNOI().SetColor("UndoButton", _MatrixColor);
			KGOLDDBHIFN().SetFloat("/", MatrixSpeed * 1627f);
			HFBJAOFLCJI().SetFloat(",", (!_Visualize) ? 1 : 0);
			IIJMIPBMMBF().SetFloat("IconImage", LightIntensity);
			KGOLDDBHIFN().SetTexture("Down", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			KEMAALEODNH().SetFloat("settings.volume.sfx", 1168f / farClipPlane);
			DKKBFFHBHJE().SetVector("\"x", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 82f, 91f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB());
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
			if (HBJJOCHGOPH > 44f)
			{
				HBJJOCHGOPH = 1874f;
			}
			HCGJCMDJPGD().SetFloat("\" error: ", HBJJOCHGOPH);
			DOHGBNPMBKG().SetFloat("_Intensity", Fade);
			HHIAIGCAHDA().SetFloat("public", _FixDistance);
			FAIFBBGFAIB().SetFloat("SetEnvSpriteImage", MatrixSize);
			DOHGBNPMBKG().SetColor(".completed", _MatrixColor);
			IIJMIPBMMBF().SetFloat("_FadeShield", MatrixSpeed * 173f);
			HHIAIGCAHDA().SetFloat("Setting autoCleanUpPlayerObjects while in a room is not supported.", (!_Visualize) ? 1 : 0);
			KGOLDDBHIFN().SetFloat("SupportLogger OnCreatedRoom(", LightIntensity);
			EFMCNLELMDO().SetTexture("#done", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			OLHDPICFBOF().SetFloat("ItemNameText", 1694f / farClipPlane);
			KGOLDDBHIFN().SetVector("float", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1535f, 1473f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MKIMDFLBFOM()
	{
		FPHEBLMINDA = Resources.Load("file://") as Texture2D;
		SCShader = Shader.Find("yyyy-MM-dd HH:mm:ss");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HONBLGFDMLL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MJEFMIPLFAB()
	{
		FPHEBLMINDA = Resources.Load("_SunColor") as Texture2D;
		SCShader = Shader.Find("CorrectHitsScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CCLNNLCOPBL()
	{
		FPHEBLMINDA = Resources.Load("[MapEditor] Importing map: ") as Texture2D;
		SCShader = Shader.Find("<b>Speed</b>:");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 101f)
			{
				HBJJOCHGOPH = 1999f;
			}
			HFBJAOFLCJI().SetFloat("Data/Editor/leveltemplate", HBJJOCHGOPH);
			OLHDPICFBOF().SetFloat("[PlayerController] ", Fade);
			IGKFMCPDNOI().SetFloat("LevelConfigButton", _FixDistance);
			HFBJAOFLCJI().SetFloat("PerfectHitsScoreText", MatrixSize);
			FAIFBBGFAIB().SetColor("_BlendTex", _MatrixColor);
			ADBKPGFMNKO().SetFloat("DestroyRpc", MatrixSpeed * 1455f);
			NBMPPNFKFLB().SetFloat("skin.no_hit", (!_Visualize) ? 0 : 0);
			IGKFMCPDNOI().SetFloat("_Value4", LightIntensity);
			DBOLLHHMKKN().SetTexture("SetCrosshairColor", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			EFMCNLELMDO().SetFloat("Zoom speed. Base 1.5", 143f / farClipPlane);
			HKHBBBFLGJH().SetVector("Left Stick Click", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1194f, 1399f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HKHBBBFLGJH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)67;
		}
		return BJFKDHHMLJH;
	}

	private void LEAHIBJDMBI()
	{
	}

	private void NCNPAKFAFOE()
	{
		FPHEBLMINDA = Resources.Load("bool") as Texture2D;
		SCShader = Shader.Find("[CraftingPanel] Init");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material IIJMIPBMMBF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)105;
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
			NBPKMLMCHFN.SetFloat("_DepthLevel", Fade);
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

	private void Start()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_3D_Computer1") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/3D_Computer");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1857f)
			{
				HBJJOCHGOPH = 1078f;
			}
			HHIAIGCAHDA().SetFloat("Set satellite beat detection sensitivity", HBJJOCHGOPH);
			HHIAIGCAHDA().SetFloat("CameraFilterPack/Blend2Camera_Darken", Fade);
			DBOLLHHMKKN().SetFloat("_ExposureAdjustment", _FixDistance);
			DKKBFFHBHJE().SetFloat("ChallengesButton", MatrixSize);
			HCGJCMDJPGD().SetColor("Error: Timeout :S", _MatrixColor);
			HKHBBBFLGJH().SetFloat("#", MatrixSpeed * 1769f);
			DOHGBNPMBKG().SetFloat("PopulateMapsList", (!_Visualize) ? 1 : 1);
			KGOLDDBHIFN().SetFloat("_ScreenResolution", LightIntensity);
			ACHNOHCLGOO().SetTexture("CameraFilterPack/Blend2Camera_LinearLight", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			IIJMIPBMMBF().SetFloat("EnableRankingToggle", 79f / farClipPlane);
			JIBOKBCPDLC().SetVector("[GameScene] Submiting rank", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1256f, 1181f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FOLDLDLFFLM()
	{
	}

	[SpecialName]
	private Material DOHGBNPMBKG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1039f)
			{
				HBJJOCHGOPH = 1262f;
			}
			ADBKPGFMNKO().SetFloat("float,1.5", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat("_ReflectionBlur", Fade);
			DOHGBNPMBKG().SetFloat("ZoomSpeed", _FixDistance);
			HKHBBBFLGJH().SetFloat("Triangle", MatrixSize);
			FAIFBBGFAIB().SetColor("Data/Skins/", _MatrixColor);
			EFMCNLELMDO().SetFloat("_Threshhold", MatrixSpeed * 198f);
			KGOLDDBHIFN().SetFloat("RecieveChatActionMessage", _Visualize ? 1 : 0);
			HHIAIGCAHDA().SetFloat("Can't set open when not in that room.", LightIntensity);
			DBOLLHHMKKN().SetTexture("#score", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			LNLKMDPHDCC().SetFloat("Keypad", 57f / farClipPlane);
			HFBJAOFLCJI().SetVector("HightScoreMaxPointsText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 442f, 1890f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PDHKMDBNGGN()
	{
		FPHEBLMINDA = Resources.Load("[SaveSystem] Outdated savefile found") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/TV_PlanetMars");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LBAJLLFMMMP()
	{
		FPHEBLMINDA = Resources.Load("0.00") as Texture2D;
		SCShader = Shader.Find("inventory.selected.");
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

	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1291f)
			{
				HBJJOCHGOPH = 1310f;
			}
			AELJLBOJAIL().SetFloat("_TimeX", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("maps.", Fade);
			ADBKPGFMNKO().SetFloat("_ScreenResolution", _FixDistance);
			ADBKPGFMNKO().SetFloat("Set arcs speed. Base value - 15", MatrixSize);
			KEMAALEODNH().SetColor("_ScreenResolution", _MatrixColor);
			IIJMIPBMMBF().SetFloat("All bindings reset to default values. PlayerPrefs have been removed for each key.", MatrixSpeed * 1880f);
			HKHBBBFLGJH().SetFloat("ChallengesButton", _Visualize ? 1 : 0);
			HCGJCMDJPGD().SetFloat("ControllerLeftX", LightIntensity);
			DBOLLHHMKKN().SetTexture("_Far", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			DKKBFFHBHJE().SetFloat("_EdgeSize", 836f / farClipPlane);
			NBMPPNFKFLB().SetVector("The directory was created successfully at ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 127f, 1018f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DBOLLHHMKKN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)125;
		}
		return BJFKDHHMLJH;
	}

	private void HPNNCNNFMGK()
	{
	}

	private void HJPCJGOEKMF()
	{
		FPHEBLMINDA = Resources.Load("Hidden/DepthOfField/DepthOfField") as Texture2D;
		SCShader = Shader.Find("View");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AEDDNDHCLNN()
	{
		FPHEBLMINDA = Resources.Load("_Value2") as Texture2D;
		SCShader = Shader.Find("AddEnvironmentSprite");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IDJKNBDKHBD()
	{
		FPHEBLMINDA = Resources.Load("PLEASE WAIT") as Texture2D;
		SCShader = Shader.Find("Oct");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JDGFCEPDKAJ()
	{
	}

	private void GMELGGJOPBB()
	{
	}

	[SpecialName]
	private Material KEMAALEODNH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)65;
		}
		return BJFKDHHMLJH;
	}

	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 462f)
			{
				HBJJOCHGOPH = 679f;
			}
			KEMAALEODNH().SetFloat("VIGNETTE_BLUR", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("error", Fade);
			IGKFMCPDNOI().SetFloat("_BlurRadius4", _FixDistance);
			ADBKPGFMNKO().SetFloat("Events Moved", MatrixSize);
			DBOLLHHMKKN().SetColor("Created", _MatrixColor);
			IIJMIPBMMBF().SetFloat("shader.invert", MatrixSpeed * 736f);
			DOHGBNPMBKG().SetFloat("Set sun colors", _Visualize ? 1 : 0);
			HFBJAOFLCJI().SetFloat("No font defined. Found font: ", LightIntensity);
			DKKBFFHBHJE().SetTexture("CameraFilterPack/Drawing_Paper3", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			ADBKPGFMNKO().SetFloat("LevelEditor/patterns", 1714f / farClipPlane);
			JIBOKBCPDLC().SetVector("mainmenu", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1734f, 1755f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OKLAJINHPAN()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack/Pixel_Pixelisation") as Texture2D;
		SCShader = Shader.Find("_Value");
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
			if (HBJJOCHGOPH > 964f)
			{
				HBJJOCHGOPH = 866f;
			}
			IIJMIPBMMBF().SetFloat(". Set PhotonNetwork.OnEventCall.", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat("Set particles start speed", Fade);
			LNLKMDPHDCC().SetFloat("[Right]", _FixDistance);
			HKHBBBFLGJH().SetFloat(".b", MatrixSize);
			NBPKMLMCHFN.SetColor("]. Please verify you have this gameobject in a Resources folder.", _MatrixColor);
			OLHDPICFBOF().SetFloat("_HeightParams", MatrixSpeed * 417f);
			OLHDPICFBOF().SetFloat("float,10", _Visualize ? 1 : 0);
			ADBKPGFMNKO().SetFloat("_Extra", LightIntensity);
			DBOLLHHMKKN().SetTexture("Down", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			DBOLLHHMKKN().SetFloat(".b", 1388f / farClipPlane);
			IGKFMCPDNOI().SetVector(">", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 398f, 786f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
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
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void BMODOIJGIOO()
	{
	}

	private void FDNONDCGGCG()
	{
		FPHEBLMINDA = Resources.Load("settings_bindings_") as Texture2D;
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CGDMLHLJIDK()
	{
		FPHEBLMINDA = Resources.Load("RemoveHighlight") as Texture2D;
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HDMDKOKOOJC()
	{
		FPHEBLMINDA = Resources.Load("/icon") as Texture2D;
		SCShader = Shader.Find("_ColorRGB");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MGMAOBPPOBJ()
	{
		FPHEBLMINDA = Resources.Load("_Tint") as Texture2D;
		SCShader = Shader.Find("Object ID. Case-Sensitive");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1734f)
			{
				HBJJOCHGOPH = 1883f;
			}
			HKHBBBFLGJH().SetFloat("Added unlock condition", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat("st", Fade);
			HFBJAOFLCJI().SetFloat("Health Stats", _FixDistance);
			EFMCNLELMDO().SetFloat("VisionBlur", MatrixSize);
			ADBKPGFMNKO().SetColor(" respawn: ", _MatrixColor);
			HFBJAOFLCJI().SetFloat("settings.gamemessagesduration", MatrixSpeed * 897f);
			NBPKMLMCHFN.SetFloat("OK", (!_Visualize) ? 1 : 1);
			HKHBBBFLGJH().SetFloat("[MapEditor] Importing map: ", LightIntensity);
			DBOLLHHMKKN().SetTexture(" should be overwritten.", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			NBMPPNFKFLB().SetFloat("_TimeX", 1642f / farClipPlane);
			JIBOKBCPDLC().SetVector("_Value6", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1597f, 1217f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KKLMPKLKAEM()
	{
	}

	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 927f)
			{
				HBJJOCHGOPH = 6f;
			}
			EFMCNLELMDO().SetFloat("Right Stick Click", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("_Value5", Fade);
			KGOLDDBHIFN().SetFloat("21x3", _FixDistance);
			FAIFBBGFAIB().SetFloat("ResetSpeed", MatrixSize);
			IIJMIPBMMBF().SetColor("_EmissionGain", _MatrixColor);
			AELJLBOJAIL().SetFloat("MultiplayerButton", MatrixSpeed * 1780f);
			NBPKMLMCHFN.SetFloat("Most likely the game became empty during the switch to GameServer.", (!_Visualize) ? 1 : 0);
			DBOLLHHMKKN().SetFloat("CameraFilterPack_3D_Computer1", LightIntensity);
			KEMAALEODNH().SetTexture("y", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			AELJLBOJAIL().SetFloat("Coroutine container not configured... did you forget to call Init?", 643f / farClipPlane);
			IIJMIPBMMBF().SetVector("CameraFilterPack/Vision_Blood", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1909f, 1799f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFMCNLELMDO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PKGJJFIFLII()
	{
	}

	private void KKEOHFGKCIK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CNGAJDBOCLJ()
	{
		FPHEBLMINDA = Resources.Load("_Offsets") as Texture2D;
		SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material DKKBFFHBHJE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)101;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material AELJLBOJAIL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)85;
		}
		return BJFKDHHMLJH;
	}

	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 773f)
			{
				HBJJOCHGOPH = 1505f;
			}
			HCGJCMDJPGD().SetFloat("_Alpha2", HBJJOCHGOPH);
			ADBKPGFMNKO().SetFloat("settings.volume.game", Fade);
			OLHDPICFBOF().SetFloat("ItemNameText", _FixDistance);
			LNLKMDPHDCC().SetFloat("_PositionX", MatrixSize);
			EFMCNLELMDO().SetColor("_Distortion", _MatrixColor);
			KEMAALEODNH().SetFloat("<b>", MatrixSpeed * 0f);
			IIJMIPBMMBF().SetFloat("#status", _Visualize ? 1 : 0);
			NFKFAAHHLLM().SetFloat("GameScene", LightIntensity);
			NBPKMLMCHFN.SetTexture("Currently, the limit of users is reached for this title. Try again later. Disconnecting", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HKHBBBFLGJH().SetFloat("Edited unlock conditions", 1604f / farClipPlane);
			AELJLBOJAIL().SetVector("{0}", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1778f, 778f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NAOLAJPDGIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IMGGCJICLHK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material LNLKMDPHDCC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)87;
		}
		return BJFKDHHMLJH;
	}

	private void Update()
	{
	}

	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1228f)
			{
				HBJJOCHGOPH = 892f;
			}
			IGKFMCPDNOI().SetFloat("_TimeX", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("#yes", Fade);
			IGKFMCPDNOI().SetFloat("/", _FixDistance);
			NFKFAAHHLLM().SetFloat("SetParticlesParticleSize", MatrixSize);
			KEMAALEODNH().SetColor("Set object anchor to another object", _MatrixColor);
			EFMCNLELMDO().SetFloat("Object ID. Case-Sensitive", MatrixSpeed * 335f);
			HCGJCMDJPGD().SetFloat("_FixDistance", (!_Visualize) ? 1 : 1);
			LNLKMDPHDCC().SetFloat(": ", LightIntensity);
			DBOLLHHMKKN().SetTexture(" cannot be used as a 3D LUT.", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			EFMCNLELMDO().SetFloat("CameraFilterPack_Paper4", 921f / farClipPlane);
			LNLKMDPHDCC().SetVector("#finished", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1853f, 1816f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material OLHDPICFBOF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void ONPFGCEFMML()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material IGKFMCPDNOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)75;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material EFMCNLELMDO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return BJFKDHHMLJH;
	}

	private void KCDOMIJBFLL()
	{
	}

	[SpecialName]
	private Material HFBJAOFLCJI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void KLOLKEBAPFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JBCNIPJDPJB()
	{
	}

	[SpecialName]
	private Material ADBKPGFMNKO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)114;
		}
		return BJFKDHHMLJH;
	}

	private void FABMDEHEDNO()
	{
	}

	private void COOHIILCOCO()
	{
		FPHEBLMINDA = Resources.Load("PointsScoreText") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Blend2Camera_Saturation");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GBGAMCPNBCC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AIJGAJIOJDJ()
	{
	}

	private void FNCDAPDOBBI()
	{
		FPHEBLMINDA = Resources.Load(". The group number should be at least 1.") as Texture2D;
		SCShader = Shader.Find("Set Satellite Radius");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KDMANOEMOCA()
	{
		FPHEBLMINDA = Resources.Load(". No ViewIDs are free to use. Max is: ") as Texture2D;
		SCShader = Shader.Find("ItemTemplate");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LIBGAKMKHJJ()
	{
		FPHEBLMINDA = Resources.Load("#no") as Texture2D;
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 349f)
			{
				HBJJOCHGOPH = 1644f;
			}
			HKHBBBFLGJH().SetFloat("&page=", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("history", Fade);
			HKHBBBFLGJH().SetFloat("1427616858", _FixDistance);
			AELJLBOJAIL().SetFloat("X2", MatrixSize);
			DBOLLHHMKKN().SetColor(" url: ", _MatrixColor);
			DOHGBNPMBKG().SetFloat("[NetworkMenu] Joining ", MatrixSpeed * 1037f);
			NFKFAAHHLLM().SetFloat("mapselector.filter.favoriteonly", (!_Visualize) ? 1 : 1);
			ACHNOHCLGOO().SetFloat("_ScreenResolution", LightIntensity);
			KEMAALEODNH().SetTexture("GlassColor", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HCGJCMDJPGD().SetFloat("_Value", 1957f / farClipPlane);
			HFBJAOFLCJI().SetVector("Image", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1478f, 343f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFMCNLELMDO());
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

	private void FHGKIOOMMOH()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack/Blend2Camera_LighterColor") as Texture2D;
		SCShader = Shader.Find("3d text");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 556f)
			{
				HBJJOCHGOPH = 1254f;
			}
			OLHDPICFBOF().SetFloat("#ok", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Mouse Y", Fade);
			NBPKMLMCHFN.SetFloat("Tab2Content", _FixDistance);
			ADBKPGFMNKO().SetFloat("CameraFilterPack/AAA_Super_Computer", MatrixSize);
			DBOLLHHMKKN().SetColor("_SSAO", _MatrixColor);
			DOHGBNPMBKG().SetFloat("ready", MatrixSpeed * 30f);
			KGOLDDBHIFN().SetFloat("_Value5", (!_Visualize) ? 1 : 1);
			IIJMIPBMMBF().SetFloat("Set sun beat detection sensitivity", LightIntensity);
			DKKBFFHBHJE().SetTexture(": ", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			KGOLDDBHIFN().SetFloat("ScreenResolutionPanel", 1337f / farClipPlane);
			IGKFMCPDNOI().SetVector("Chat", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1890f, 1970f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FJIKDJAMOHA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GPNAOAKCMHC()
	{
		FPHEBLMINDA = Resources.Load("PublishButton") as Texture2D;
		SCShader = Shader.Find("id");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material KGOLDDBHIFN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void KFACDBHDAOD()
	{
	}

	[SpecialName]
	private Material ACHNOHCLGOO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 49f)
			{
				HBJJOCHGOPH = 176f;
			}
			NBMPPNFKFLB().SetFloat("Object ID. Case-Sensitive", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("InfoText", Fade);
			ADBKPGFMNKO().SetFloat("Joystick", _FixDistance);
			EFMCNLELMDO().SetFloat("_Value2", MatrixSize);
			OLHDPICFBOF().SetColor("127.0.0.1", _MatrixColor);
			DOHGBNPMBKG().SetFloat("settings.enablehitsoundsinnormal", MatrixSpeed * 481f);
			OLHDPICFBOF().SetFloat("Lightning", (!_Visualize) ? 1 : 1);
			HKHBBBFLGJH().SetFloat("_Red_G", LightIntensity);
			HHIAIGCAHDA().SetTexture("_MainTex2", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			EFMCNLELMDO().SetFloat("EndlessLoopsScoreText", 1006f / farClipPlane);
			NBMPPNFKFLB().SetVector("_SphereSize", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 854f, 1103f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HLDFOJMHKNL()
	{
	}

	private void PKBENONAOOL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BGDONBMDPGM()
	{
	}

	[SpecialName]
	private Material NFKFAAHHLLM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)99;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NBMPPNFKFLB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)125;
		}
		return BJFKDHHMLJH;
	}

	private void FIKFJDFELIP()
	{
		FPHEBLMINDA = Resources.Load("_Value2") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack_TV_Vignetting1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material HHIAIGCAHDA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void IBHACCEEFFI()
	{
	}

	[SpecialName]
	private Material JIBOKBCPDLC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1719f)
			{
				HBJJOCHGOPH = 502f;
			}
			DKKBFFHBHJE().SetFloat("addNewButton", HBJJOCHGOPH);
			DOHGBNPMBKG().SetFloat("maps.", Fade);
			LNLKMDPHDCC().SetFloat("[Up]", _FixDistance);
			AELJLBOJAIL().SetFloat("Joystick1Button3", MatrixSize);
			KGOLDDBHIFN().SetColor("ready", _MatrixColor);
			KGOLDDBHIFN().SetFloat("InfoCanvas", MatrixSpeed * 509f);
			OLHDPICFBOF().SetFloat("CameraFilterPack_Paper2", _Visualize ? 1 : 0);
			NFKFAAHHLLM().SetFloat("Exit to Windows", LightIntensity);
			KGOLDDBHIFN().SetTexture("4,28,true,0", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			ADBKPGFMNKO().SetFloat("HPToggle", 54f / farClipPlane);
			NBPKMLMCHFN.SetVector("Reload Maps", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1294f, 1723f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MFLBEJHMEMO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DFENCIHAADO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}
}
