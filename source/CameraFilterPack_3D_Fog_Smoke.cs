// CameraFilterPack_3D_Fog_Smoke
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/3D/Fog_Smoke")]
[ExecuteInEditMode]
public class CameraFilterPack_3D_Fog_Smoke : MonoBehaviour
{
	public Shader SCShader;

	public bool _Visualize;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 100f)]
	public float _FixDistance = 1f;

	[Range(-0.99f, 0.99f)]
	public float _Distance = 0.5f;

	[Range(0f, 0.5f)]
	public float _Size = 0.1f;

	[Range(0f, 10f)]
	public float DistortionLevel = 1.2f;

	[Range(0.1f, 10f)]
	public float DistortionSize = 1.4f;

	[Range(-2f, 4f)]
	public float LightIntensity = 0.08f;

	public bool AutoAnimatedNear;

	[Range(-5f, 5f)]
	public float AutoAnimatedNearSpeed = 0.5f;

	private Texture2D FPHEBLMINDA;

	public static Color ChangeColorRGB;

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

	private void FIKFJDFELIP()
	{
		FPHEBLMINDA = Resources.Load("Loaded Game: ") as Texture2D;
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MGFFNGEGFDC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1318f)
			{
				HBJJOCHGOPH = 841f;
			}
			EFDEIFCDAFG().SetFloat("_DiffuseColor", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1182f)
				{
					_Distance = 1046f;
				}
				if (_Distance < 987f)
				{
					_Distance = 1652f;
				}
				HFBJAOFLCJI().SetFloat("Horizontal", _Distance);
			}
			else
			{
				HFBJAOFLCJI().SetFloat("#91CCFF", _Distance);
			}
			JIBOKBCPDLC().SetFloat("note.2", _Size);
			KAFBNOBOIAJ().SetFloat("CameraFilterPack/3D_Mirror", (!_Visualize) ? 1 : 0);
			NDMPCDHADMJ().SetFloat("_Value", _FixDistance);
			NBPKMLMCHFN.SetFloat("Set sun audio input", DistortionLevel * 1672f);
			NBPKMLMCHFN.SetFloat("PublishButton", DistortionSize * 1147f);
			HCGJCMDJPGD().SetFloat("_BlurCoe", LightIntensity * 221f);
			KAFBNOBOIAJ().SetTexture("UNDISTORT", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HHIAIGCAHDA().SetFloat("CameraFilterPack/Deep_OilPaintHQ", 1475f / farClipPlane);
			HCGJCMDJPGD().SetVector("plogs", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 807f, 1651f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GKNKIIEALCH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material NDMPCDHADMJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-113);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HHIAIGCAHDA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return BJFKDHHMLJH;
	}

	private void OEENOOGEEHD()
	{
	}

	private void KCDOMIJBFLL()
	{
	}

	[SpecialName]
	private Material EPCGJFCCAFH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-124);
		}
		return BJFKDHHMLJH;
	}

	private void DFENCIHAADO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OFPPIKHNJOD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
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
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void Update()
	{
	}

	[SpecialName]
	private Material HFBJAOFLCJI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return BJFKDHHMLJH;
	}

	private void DLMPALHKMON()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DAHFFNNIGML()
	{
		FPHEBLMINDA = Resources.Load("_Value") as Texture2D;
		SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 299f)
			{
				HBJJOCHGOPH = 1115f;
			}
			LPMLLJKMAMP().SetFloat("getfloat", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1604f)
				{
					_Distance = 207f;
				}
				if (_Distance < 1563f)
				{
					_Distance = 20f;
				}
				EFDEIFCDAFG().SetFloat("_AdaptationMin", _Distance);
			}
			else
			{
				JIBOKBCPDLC().SetFloat("_Value3", _Distance);
			}
			LPMLLJKMAMP().SetFloat("-1", _Size);
			HHIAIGCAHDA().SetFloat("/", (!_Visualize) ? 0 : 0);
			LPMLLJKMAMP().SetFloat("_Value", _FixDistance);
			NDMPCDHADMJ().SetFloat(" ", DistortionLevel * 166f);
			IIJMIPBMMBF().SetFloat("Right Stick Click", DistortionSize * 508f);
			HHIAIGCAHDA().SetFloat("CameraFilterPack_3D_Myst1", LightIntensity * 397f);
			MMOODGIODPC().SetTexture("_TimeX", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			GCDFNHMJMIP().SetFloat("cancel", 1013f / farClipPlane);
			KAFBNOBOIAJ().SetVector("Netw. Sim.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 400f, 1463f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AEEGKLABFLN()
	{
	}

	private void Start()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_3D_Myst1") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/3D_Myst");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GJAJBMGGPFB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CCLNNLCOPBL()
	{
		FPHEBLMINDA = Resources.Load("Skipping EstablishEncryption. Protocol is secure.") as Texture2D;
		SCShader = Shader.Find("#");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KLILJHJNICK()
	{
		FPHEBLMINDA = Resources.Load("GameScene") as Texture2D;
		SCShader = Shader.Find("menutheme.letitbe");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material GCDFNHMJMIP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-73);
		}
		return BJFKDHHMLJH;
	}

	private void MAOCOEGAFND()
	{
	}

	private void IBHACCEEFFI()
	{
	}

	private void LJIHHJOAJCN()
	{
	}

	[SpecialName]
	private Material IIJMIPBMMBF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-107);
		}
		return BJFKDHHMLJH;
	}

	private void ODGMCJILIHF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1499f)
			{
				HBJJOCHGOPH = 250f;
			}
			ADBKPGFMNKO().SetFloat("mapselector.filter.favoriteonly", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 883f)
				{
					_Distance = 1666f;
				}
				if (_Distance < 893f)
				{
					_Distance = 168f;
				}
				ACHNOHCLGOO().SetFloat("CameraFilterPack/Blend2Camera_HardLight", _Distance);
			}
			else
			{
				LPMLLJKMAMP().SetFloat("_Colored", _Distance);
			}
			LPMLLJKMAMP().SetFloat("stretchWidth", _Size);
			KAFBNOBOIAJ().SetFloat("_Value", _Visualize ? 1 : 0);
			HHIAIGCAHDA().SetFloat("_TimeX", _FixDistance);
			JIBOKBCPDLC().SetFloat("[PlayerController] ", DistortionLevel * 1185f);
			NBPKMLMCHFN.SetFloat("Hex value #RRGGBB", DistortionSize * 1955f);
			NDMPCDHADMJ().SetFloat("BestScoreText", LightIntensity * 748f);
			ACHNOHCLGOO().SetTexture("GameMessagesDurationSlider", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			IIJMIPBMMBF().SetFloat("Ignored PU RPC, cause item is inactive. ", 1131f / farClipPlane);
			ADBKPGFMNKO().SetVector("In Main Menu", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 75f, 1002f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OMCLOFCJMPG()
	{
	}

	private void JOACBIEHHCE()
	{
	}

	private void DNENFLNCIJP()
	{
	}

	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 635f)
			{
				HBJJOCHGOPH = 94f;
			}
			GCDFNHMJMIP().SetFloat("CameraFilterPack/Drawing_BluePrint", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 446f)
				{
					_Distance = 547f;
				}
				if (_Distance < 608f)
				{
					_Distance = 1430f;
				}
				MMOODGIODPC().SetFloat("_InvScreenSize", _Distance);
			}
			else
			{
				EFDEIFCDAFG().SetFloat("Warning, using scrollbors with the Scroll Snap controls is not advised as it causes unpredictable results", _Distance);
			}
			HCGJCMDJPGD().SetFloat("#highscore", _Size);
			ADBKPGFMNKO().SetFloat("_TimeX", (!_Visualize) ? 1 : 0);
			IIJMIPBMMBF().SetFloat("[EditorEvent] Exception: ", _FixDistance);
			MMOODGIODPC().SetFloat("offsets", DistortionLevel * 1884f);
			HFBJAOFLCJI().SetFloat("skin.hit_normal", DistortionSize * 327f);
			HHIAIGCAHDA().SetFloat("CameraFilterPack/Atmosphere_Snow_8bits", LightIntensity * 1614f);
			JIBOKBCPDLC().SetTexture("_VignetteColor", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HCGJCMDJPGD().SetFloat("_AllowBackwardsRays", 1480f / farClipPlane);
			ACHNOHCLGOO().SetVector(": ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 629f, 1827f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JOJFHFHOCHO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JKFDDNMPOJH()
	{
		FPHEBLMINDA = Resources.Load("{0}{1}{2}") as Texture2D;
		SCShader = Shader.Find(": ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KIEJKBNBHMD()
	{
	}

	private void JLNNHKPHMAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FABKIGNFECE()
	{
	}

	private void HONBLGFDMLL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BMOFEBKGLFI()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack/Vision_Blood") as Texture2D;
		SCShader = Shader.Find("curScn");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material ACHNOHCLGOO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material ADBKPGFMNKO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInHierarchy | HideFlags.HideInInspector);
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
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1f)
				{
					_Distance = -1f;
				}
				if (_Distance < -1f)
				{
					_Distance = 1f;
				}
				NBPKMLMCHFN.SetFloat("_Near", _Distance);
			}
			else
			{
				NBPKMLMCHFN.SetFloat("_Near", _Distance);
			}
			NBPKMLMCHFN.SetFloat("_Far", _Size);
			NBPKMLMCHFN.SetFloat("_Visualize", _Visualize ? 1 : 0);
			NBPKMLMCHFN.SetFloat("_FixDistance", _FixDistance);
			NBPKMLMCHFN.SetFloat("_DistortionLevel", DistortionLevel * 28f);
			NBPKMLMCHFN.SetFloat("_DistortionSize", DistortionSize * 16f);
			NBPKMLMCHFN.SetFloat("_LightIntensity", LightIntensity * 64f);
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

	private void FBPHNEJBDJN()
	{
		FPHEBLMINDA = Resources.Load(".message") as Texture2D;
		SCShader = Shader.Find("[MenuScene] Error: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material KAFBNOBOIAJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 855f)
			{
				HBJJOCHGOPH = 1234f;
			}
			IIJMIPBMMBF().SetFloat("_Value3", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1265f)
				{
					_Distance = 1921f;
				}
				if (_Distance < 531f)
				{
					_Distance = 1921f;
				}
				MMOODGIODPC().SetFloat("NEW_ACHIEVEMENT_1_", _Distance);
			}
			else
			{
				MMOODGIODPC().SetFloat("b", _Distance);
			}
			AELJLBOJAIL().SetFloat("<b>[", _Size);
			NDMPCDHADMJ().SetFloat("input", (!_Visualize) ? 1 : 0);
			GCDFNHMJMIP().SetFloat("/icon", _FixDistance);
			LPMLLJKMAMP().SetFloat("threshold", DistortionLevel * 68f);
			NDMPCDHADMJ().SetFloat(" not exist", DistortionSize * 1145f);
			LPMLLJKMAMP().SetFloat("maps.", LightIntensity * 262f);
			KAFBNOBOIAJ().SetTexture("y", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			KAFBNOBOIAJ().SetFloat("[PlayerBase] Starting new round", 1279f / farClipPlane);
			HCGJCMDJPGD().SetVector("ERROR: Make sure your mod contains at leats one file!", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 155f, 418f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HMPGIFBJFIK()
	{
		FPHEBLMINDA = Resources.Load("float,0") as Texture2D;
		SCShader = Shader.Find("menu.enableselectormusic");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DKGBFNCOAEO()
	{
		FPHEBLMINDA = Resources.Load("menu.playedpage") as Texture2D;
		SCShader = Shader.Find("SettingsCanvas");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BMIOFJFMCBG()
	{
		FPHEBLMINDA = Resources.Load("Mouse Wheel Up") as Texture2D;
		SCShader = Shader.Find("Parameter levelId must be int or string!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EGEGNHLODAA()
	{
	}

	[SpecialName]
	private Material MMOODGIODPC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void ILCFPCIPENO()
	{
		FPHEBLMINDA = Resources.Load("FileMenu") as Texture2D;
		SCShader = Shader.Find("OperationResponse ignored while disconnecting. Code: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PAEGLMEOKHP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KMOCDAOKGLI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 462f)
			{
				HBJJOCHGOPH = 1010f;
			}
			NBPKMLMCHFN.SetFloat("[MapEditor] Updating map assets", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 623f)
				{
					_Distance = 1106f;
				}
				if (_Distance < 76f)
				{
					_Distance = 801f;
				}
				IIJMIPBMMBF().SetFloat("</size>", _Distance);
			}
			else
			{
				EFDEIFCDAFG().SetFloat("0 - background, 1 - foreground", _Distance);
			}
			ACHNOHCLGOO().SetFloat("Joystick1Button", _Size);
			NBPKMLMCHFN.SetFloat("_ReflectionTexture2", (!_Visualize) ? 0 : 0);
			HFBJAOFLCJI().SetFloat("#failed!", _FixDistance);
			ACHNOHCLGOO().SetFloat("Myst", DistortionLevel * 1282f);
			GCDFNHMJMIP().SetFloat("_TintColor", DistortionSize * 656f);
			HFBJAOFLCJI().SetFloat("menu.selectedplaymode", LightIntensity * 690f);
			LPMLLJKMAMP().SetTexture("_FixDistance", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			NBPKMLMCHFN.SetFloat("Error; Only the MasterClient can call RemoveRPCs for other players.", 1887f / farClipPlane);
			NBPKMLMCHFN.SetVector("z", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 720f, 887f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MMBPLGGLPDB()
	{
	}

	private void AIJGAJIOJDJ()
	{
	}

	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 766f)
			{
				HBJJOCHGOPH = 1905f;
			}
			HFBJAOFLCJI().SetFloat("NewMapHandsCountSlider", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 604f)
				{
					_Distance = 4f;
				}
				if (_Distance < 810f)
				{
					_Distance = 366f;
				}
				NDMPCDHADMJ().SetFloat("_MainTex2", _Distance);
			}
			else
			{
				MMOODGIODPC().SetFloat(".r", _Distance);
			}
			IIJMIPBMMBF().SetFloat("_Value", _Size);
			NDMPCDHADMJ().SetFloat(".lastCheckpoint.isMapCompleted", (!_Visualize) ? 1 : 1);
			NBPKMLMCHFN.SetFloat("[FileSelector] Dialog ended, result: ", _FixDistance);
			EFDEIFCDAFG().SetFloat("ticket", DistortionLevel * 334f);
			LPMLLJKMAMP().SetFloat("OxOD.lastPath", DistortionSize * 874f);
			EPCGJFCCAFH().SetFloat("_TimeX", LightIntensity * 1891f);
			GCDFNHMJMIP().SetTexture(". Check if the server is available.", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HHIAIGCAHDA().SetFloat("settings.fps", 471f / farClipPlane);
			LPMLLJKMAMP().SetVector("_SpotSize", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 23f, 604f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LPMLLJKMAMP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-90);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material AELJLBOJAIL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)113;
		}
		return BJFKDHHMLJH;
	}

	private void OBAEDJJDCPN()
	{
	}

	private void KIMMMCJFMAB()
	{
		FPHEBLMINDA = Resources.Load("setAF") as Texture2D;
		SCShader = Shader.Find("). ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material EFDEIFCDAFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-94);
		}
		return BJFKDHHMLJH;
	}

	private void IMGGCJICLHK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void COIJKMKIEAK()
	{
		FPHEBLMINDA = Resources.Load(".played") as Texture2D;
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material JIBOKBCPDLC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-76);
		}
		return BJFKDHHMLJH;
	}
}
