// CameraFilterPack_3D_Computer
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/3D/Computer")]
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
			HKHBBBFLGJH().SetFloat("_LutTex", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("z", Fade);
			HHIAIGCAHDA().SetFloat("/../", _FixDistance);
			ACHNOHCLGOO().SetFloat("[Left]", MatrixSize);
			KGOLDDBHIFN().SetColor("checkpoint", _MatrixColor);
			HHIAIGCAHDA().SetFloat("RoomPlayersCountText", MatrixSpeed * 1627f);
			ADBKPGFMNKO().SetFloat("SpawnObj", (!_Visualize) ? 1 : 0);
			NFKFAAHHLLM().SetFloat("inventory.selected.", LightIntensity);
			DOHGBNPMBKG().SetTexture("GetLive", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			AELJLBOJAIL().SetFloat("settings.volume.editor", 1168f / farClipPlane);
			IGKFMCPDNOI().SetVector("[CraftingPanel] Init", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 82f, 91f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
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
			DBOLLHHMKKN().SetFloat("#checkpoint", HBJJOCHGOPH);
			HHIAIGCAHDA().SetFloat("_BlurVector", Fade);
			ACHNOHCLGOO().SetFloat("MenuScene", _FixDistance);
			AELJLBOJAIL().SetFloat("SetParticlesParticleSpeed", MatrixSize);
			IGKFMCPDNOI().SetColor(".played", _MatrixColor);
			HFBJAOFLCJI().SetFloat("_FadeShield", MatrixSpeed * 173f);
			DKKBFFHBHJE().SetFloat("Using Stopwatch as precision timer for PUN.", (!_Visualize) ? 1 : 0);
			HFBJAOFLCJI().SetFloat("SupportLogger OnJoinedRoom(", LightIntensity);
			ADBKPGFMNKO().SetTexture("#savemapbeforeuploading", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			DKKBFFHBHJE().SetFloat("ItemsCountText", 1694f / farClipPlane);
			NFKFAAHHLLM().SetVector("string", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1535f, 1473f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MKIMDFLBFOM()
	{
		FPHEBLMINDA = Resources.Load(".mp3") as Texture2D;
		SCShader = Shader.Find("#,0.00");
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
		FPHEBLMINDA = Resources.Load("_BlurRadius4") as Texture2D;
		SCShader = Shader.Find("CorrectHitsScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CCLNNLCOPBL()
	{
		FPHEBLMINDA = Resources.Load("Editor") as Texture2D;
		SCShader = Shader.Find("-");
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
			DOHGBNPMBKG().SetFloat("Data/Editor/leveltemplate", HBJJOCHGOPH);
			EFMCNLELMDO().SetFloat(" not exist", Fade);
			KGOLDDBHIFN().SetFloat("LevelConfigButton", _FixDistance);
			EFMCNLELMDO().SetFloat("PerfectHitsScoreText", MatrixSize);
			KEMAALEODNH().SetColor("USE_UV_BASED_REPROJECTION", _MatrixColor);
			FAIFBBGFAIB().SetFloat("RPC: 'OnAwakeRPC' PhotonView: ", MatrixSpeed * 1455f);
			DOHGBNPMBKG().SetFloat("skin.no_hit", (!_Visualize) ? 0 : 0);
			ACHNOHCLGOO().SetFloat("_Value3", LightIntensity);
			FAIFBBGFAIB().SetTexture("Set satellite MinVertexDistance - how much distance should be between to points of the trail line", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			KGOLDDBHIFN().SetFloat("Zoom speed. Base 1.5", 143f / farClipPlane);
			NBMPPNFKFLB().SetVector("Joystick1Button10", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1194f, 1399f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
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
		FPHEBLMINDA = Resources.Load("true") as Texture2D;
		SCShader = Shader.Find("time");
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
			DOHGBNPMBKG().SetFloat("float,50", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("CameraFilterPack/Blend2Camera_Darken", Fade);
			IIJMIPBMMBF().SetFloat("_ExposureAdjustment", _FixDistance);
			HFBJAOFLCJI().SetFloat("ChallengesButton", MatrixSize);
			OLHDPICFBOF().SetColor("Item creation successful! Published Item ID: ", _MatrixColor);
			HHIAIGCAHDA().SetFloat("GameModeText", MatrixSpeed * 1769f);
			NBMPPNFKFLB().SetFloat("/", (!_Visualize) ? 1 : 1);
			IGKFMCPDNOI().SetFloat("_ScreenResolution", LightIntensity);
			LNLKMDPHDCC().SetTexture("CameraFilterPack/Blend2Camera_LinearLight", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			OLHDPICFBOF().SetFloat("EnableRankingToggle", 79f / farClipPlane);
			DBOLLHHMKKN().SetVector("[GameScene] Submiting rank", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1256f, 1181f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
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
			LNLKMDPHDCC().SetFloat("x", HBJJOCHGOPH);
			NFKFAAHHLLM().SetFloat("_PixelsPerMeterAtOneMeter", Fade);
			AELJLBOJAIL().SetFloat("ZoomFade", _FixDistance);
			NBMPPNFKFLB().SetFloat("Circle", MatrixSize);
			AELJLBOJAIL().SetColor("default", _MatrixColor);
			NBPKMLMCHFN.SetFloat("_CurveParams", MatrixSpeed * 198f);
			AELJLBOJAIL().SetFloat("RecieveChatActionMessage", _Visualize ? 1 : 0);
			LNLKMDPHDCC().SetFloat("wss://", LightIntensity);
			HCGJCMDJPGD().SetTexture("menu.selectedplaymode", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			KGOLDDBHIFN().SetFloat("Keypad", 57f / farClipPlane);
			KEMAALEODNH().SetVector("FinalScoreText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 442f, 1890f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PDHKMDBNGGN()
	{
		FPHEBLMINDA = Resources.Load("[SaveSystem] Outdated savefile found") as Texture2D;
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LBAJLLFMMMP()
	{
		FPHEBLMINDA = Resources.Load("TotalTimeLabel") as Texture2D;
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
			IIJMIPBMMBF().SetFloat("_TimeX", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("BadgeText", Fade);
			DKKBFFHBHJE().SetFloat("_Fade", _FixDistance);
			ACHNOHCLGOO().SetFloat("1,30,true,0", MatrixSize);
			HKHBBBFLGJH().SetColor("_ScreenResolution", _MatrixColor);
			NFKFAAHHLLM().SetFloat("settings_bindings_controller_type", MatrixSpeed * 1880f);
			NFKFAAHHLLM().SetFloat("ChallengesButton", _Visualize ? 1 : 0);
			DKKBFFHBHJE().SetFloat("Right", LightIntensity);
			NBMPPNFKFLB().SetTexture("_Far", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			NBMPPNFKFLB().SetFloat("_TimeX", 836f / farClipPlane);
			EFMCNLELMDO().SetVector("Loaded Game: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 127f, 1018f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
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
		FPHEBLMINDA = Resources.Load("RenderTextureUtilityTempTexture") as Texture2D;
		SCShader = Shader.Find("RT");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AEDDNDHCLNN()
	{
		FPHEBLMINDA = Resources.Load("_TimeX") as Texture2D;
		SCShader = Shader.Find("AddEnvironmentSprite");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IDJKNBDKHBD()
	{
		FPHEBLMINDA = Resources.Load("Use ticket: ") as Texture2D;
		SCShader = Shader.Find("Aug");
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
			DKKBFFHBHJE().SetFloat("_BlurTex", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("#close", Fade);
			HFBJAOFLCJI().SetFloat("_BlurRadius4", _FixDistance);
			IIJMIPBMMBF().SetFloat("#currentbpm: ", MatrixSize);
			LNLKMDPHDCC().SetColor("Created", _MatrixColor);
			IIJMIPBMMBF().SetFloat("shader.invert", MatrixSpeed * 736f);
			IIJMIPBMMBF().SetFloat("Hex value #RRGGBB", _Visualize ? 1 : 0);
			HKHBBBFLGJH().SetFloat("FToA", LightIntensity);
			NBPKMLMCHFN.SetTexture("CameraFilterPack_Paper4", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			NBMPPNFKFLB().SetFloat("ShowSprite", 1714f / farClipPlane);
			KEMAALEODNH().SetVector("mainmenu", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1734f, 1755f));
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
		FPHEBLMINDA = Resources.Load("_MainTex2") as Texture2D;
		SCShader = Shader.Find("_TimeX");
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
			HFBJAOFLCJI().SetFloat(". Sent by actorNr: ", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("Set particles start speed", Fade);
			EFMCNLELMDO().SetFloat("[Left]", _FixDistance);
			JIBOKBCPDLC().SetFloat(".b", MatrixSize);
			HFBJAOFLCJI().SetColor(". Should be just one?", _MatrixColor);
			LNLKMDPHDCC().SetFloat("_FrustumCornersWS", MatrixSpeed * 417f);
			ACHNOHCLGOO().SetFloat("float,10", _Visualize ? 1 : 0);
			EFMCNLELMDO().SetFloat("_Intensity", LightIntensity);
			HFBJAOFLCJI().SetTexture("Up", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HKHBBBFLGJH().SetFloat(".b", 1388f / farClipPlane);
			EFMCNLELMDO().SetVector("<color=#", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 398f, 786f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
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
		FPHEBLMINDA = Resources.Load("All bindings reset to default values. PlayerPrefs have been removed for each key.") as Texture2D;
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CGDMLHLJIDK()
	{
		FPHEBLMINDA = Resources.Load("]") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/TV_Old");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HDMDKOKOOJC()
	{
		FPHEBLMINDA = Resources.Load("/music") as Texture2D;
		SCShader = Shader.Find("_Far");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MGMAOBPPOBJ()
	{
		FPHEBLMINDA = Resources.Load("_PosY") as Texture2D;
		SCShader = Shader.Find("id");
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
			NBMPPNFKFLB().SetFloat("Paste events", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("1", Fade);
			FAIFBBGFAIB().SetFloat("Incoming: \n", _FixDistance);
			HHIAIGCAHDA().SetFloat("Fade", MatrixSize);
			NFKFAAHHLLM().SetColor("Sent count: ", _MatrixColor);
			NFKFAAHHLLM().SetFloat("settings.crosshairopacity", MatrixSpeed * 897f);
			NFKFAAHHLLM().SetFloat("You must complete your map before submiting it to Workshop", (!_Visualize) ? 1 : 1);
			HKHBBBFLGJH().SetFloat("Editor/", LightIntensity);
			KEMAALEODNH().SetTexture("Missing shader in ", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			DBOLLHHMKKN().SetFloat("_TimeX", 1642f / farClipPlane);
			DKKBFFHBHJE().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1597f, 1217f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
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
			HKHBBBFLGJH().SetFloat("Left Stick Click", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("_Value4", Fade);
			ACHNOHCLGOO().SetFloat("2;13;14;15;16", _FixDistance);
			KGOLDDBHIFN().SetFloat("ResetSpeed", MatrixSize);
			HCGJCMDJPGD().SetColor("_EmissionColor", _MatrixColor);
			HFBJAOFLCJI().SetFloat("MultiplayerButton", MatrixSpeed * 1780f);
			IGKFMCPDNOI().SetFloat("Most likely the game became empty during the switch to GameServer.", (!_Visualize) ? 1 : 0);
			KEMAALEODNH().SetFloat("CameraFilterPack_3D_Computer1", LightIntensity);
			LNLKMDPHDCC().SetTexture("y", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HCGJCMDJPGD().SetFloat("HighScaleShot", 643f / farClipPlane);
			EFMCNLELMDO().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1909f, 1799f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
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
		SCShader = Shader.Find("[Down]");
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
			HHIAIGCAHDA().SetFloat("_Alpha2", HBJJOCHGOPH);
			DOHGBNPMBKG().SetFloat("settings.volume.menu", Fade);
			IIJMIPBMMBF().SetFloat("ItemsCountText", _FixDistance);
			HKHBBBFLGJH().SetFloat("_PositionX", MatrixSize);
			NBMPPNFKFLB().SetColor("_TimeX", _MatrixColor);
			NFKFAAHHLLM().SetFloat("<b>", MatrixSpeed * 0f);
			DKKBFFHBHJE().SetFloat("#task", _Visualize ? 1 : 0);
			HFBJAOFLCJI().SetFloat("[", LightIntensity);
			LNLKMDPHDCC().SetTexture("Custom Authentication failed (either due to user-input or configuration or AuthParameter string format). Calling: OnCustomAuthenticationFailed()", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FAIFBBGFAIB().SetFloat("OK", 1604f / farClipPlane);
			OLHDPICFBOF().SetVector("s", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1778f, 778f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
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
			HFBJAOFLCJI().SetFloat("CameraFilterPack/Drawing_Comics", HBJJOCHGOPH);
			EFMCNLELMDO().SetFloat("maps.", Fade);
			HKHBBBFLGJH().SetFloat("NewIconFileSelector", _FixDistance);
			KGOLDDBHIFN().SetFloat("Set particless emission (glow)", MatrixSize);
			HCGJCMDJPGD().SetColor("Set object anchor to another object", _MatrixColor);
			ACHNOHCLGOO().SetFloat("Object ID. Case-Sensitive", MatrixSpeed * 335f);
			EFMCNLELMDO().SetFloat("_FixDistance", (!_Visualize) ? 1 : 1);
			NBMPPNFKFLB().SetFloat(": ", LightIntensity);
			HCGJCMDJPGD().SetTexture("The given 2D texture ", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			ACHNOHCLGOO().SetFloat("_MainTex2", 921f / farClipPlane);
			HFBJAOFLCJI().SetVector("#reward: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1853f, 1816f));
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
		SCShader = Shader.Find("_ScreenResolution");
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
		SCShader = Shader.Find("SetSatelliteRadius");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KDMANOEMOCA()
	{
		FPHEBLMINDA = Resources.Load(". Prefab must have a PhotonView component.") as Texture2D;
		SCShader = Shader.Find("SlidingArea");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LIBGAKMKHJJ()
	{
		FPHEBLMINDA = Resources.Load("#submit") as Texture2D;
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
			DOHGBNPMBKG().SetFloat("&page=", HBJJOCHGOPH);
			OLHDPICFBOF().SetFloat("Clears all text from the debug console", Fade);
			DBOLLHHMKKN().SetFloat("1234332714", _FixDistance);
			OLHDPICFBOF().SetFloat("================================", MatrixSize);
			JIBOKBCPDLC().SetColor("settings.customdataskin", _MatrixColor);
			DBOLLHHMKKN().SetFloat("[NetworkMenu] Joining ", MatrixSpeed * 1037f);
			NBMPPNFKFLB().SetFloat("winter2020", (!_Visualize) ? 1 : 1);
			KEMAALEODNH().SetFloat("_Value", LightIntensity);
			LNLKMDPHDCC().SetTexture("GlassesColor2", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			KGOLDDBHIFN().SetFloat("_Value", 1957f / farClipPlane);
			NFKFAAHHLLM().SetVector("Image", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1478f, 343f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
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
		SCShader = Shader.Find("fetch");
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
			DKKBFFHBHJE().SetFloat("#forever", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("Mouse Wheel Down", Fade);
			HCGJCMDJPGD().SetFloat("SpeedSlider", _FixDistance);
			NFKFAAHHLLM().SetFloat("CameraFilterPack/AAA_Super_Computer", MatrixSize);
			KGOLDDBHIFN().SetColor("_TexelOffsetScale", _MatrixColor);
			KGOLDDBHIFN().SetFloat("[Right]", MatrixSpeed * 30f);
			DBOLLHHMKKN().SetFloat("_Value4", (!_Visualize) ? 1 : 1);
			NBMPPNFKFLB().SetFloat("float,50", LightIntensity);
			IIJMIPBMMBF().SetTexture("[PlayerController] ", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			EFMCNLELMDO().SetFloat("ScreenResolutionPanel", 1337f / farClipPlane);
			NBPKMLMCHFN.SetVector("ChatInput", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1890f, 1970f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF());
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
		SCShader = Shader.Find("Set Particle Size");
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
			KGOLDDBHIFN().SetFloat("Object ID. Case-Sensitive", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("rarity", Fade);
			FAIFBBGFAIB().SetFloat("DPADHOR", _FixDistance);
			FAIFBBGFAIB().SetFloat("_TimeX", MatrixSize);
			LNLKMDPHDCC().SetColor("Exception while connecting to: ", _MatrixColor);
			IIJMIPBMMBF().SetFloat("settings.disablestoryboard", MatrixSpeed * 481f);
			LNLKMDPHDCC().SetFloat("Lightning", (!_Visualize) ? 1 : 1);
			HFBJAOFLCJI().SetFloat("_Red_G", LightIntensity);
			JIBOKBCPDLC().SetTexture("UseScanLine", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			AELJLBOJAIL().SetFloat("EndlessLoopsScoreText", 1006f / farClipPlane);
			EFMCNLELMDO().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 854f, 1103f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
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
		SCShader = Shader.Find("_ScreenResolution");
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
			OLHDPICFBOF().SetFloat("Events Moved", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("maps.", Fade);
			ACHNOHCLGOO().SetFloat("Gameplay/satellite", _FixDistance);
			KEMAALEODNH().SetFloat("Joystick1Button2", MatrixSize);
			NBPKMLMCHFN.SetColor("SetLives", _MatrixColor);
			FAIFBBGFAIB().SetFloat("InfoText", MatrixSpeed * 509f);
			FAIFBBGFAIB().SetFloat("_ScreenResolution", _Visualize ? 1 : 0);
			DBOLLHHMKKN().SetFloat("/Saved Games/", LightIntensity);
			DOHGBNPMBKG().SetTexture("4,28,true,0", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HHIAIGCAHDA().SetFloat("menu.enableselectormusic", 54f / farClipPlane);
			ADBKPGFMNKO().SetVector("Reset XP", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1294f, 1723f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
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
