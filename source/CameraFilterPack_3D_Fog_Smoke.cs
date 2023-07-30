// CameraFilterPack_3D_Fog_Smoke
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/3D/Fog_Smoke")]
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
		FPHEBLMINDA = Resources.Load(".sav") as Texture2D;
		SCShader = Shader.Find("_Value4");
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
			NBPKMLMCHFN.SetFloat("#,0.00", HBJJOCHGOPH);
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
				GCDFNHMJMIP().SetFloat("InstantiateRpc", _Distance);
			}
			else
			{
				ADBKPGFMNKO().SetFloat("ItemNameText", _Distance);
			}
			HFBJAOFLCJI().SetFloat("#ok", _Size);
			EFDEIFCDAFG().SetFloat("CameraFilterPack/3D_Mirror", (!_Visualize) ? 1 : 0);
			EFDEIFCDAFG().SetFloat("_Value", _FixDistance);
			HHIAIGCAHDA().SetFloat("Set sun audio input", DistortionLevel * 1672f);
			HCGJCMDJPGD().SetFloat("PublishButton", DistortionSize * 1147f);
			NDMPCDHADMJ().SetFloat("_BokehParams", LightIntensity * 221f);
			KAFBNOBOIAJ().SetTexture("VIGNETTE_BLUR", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			EFDEIFCDAFG().SetFloat("_Val2", 1475f / farClipPlane);
			AELJLBOJAIL().SetVector("achievements.21.progress", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 807f, 1651f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
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
		SCShader = Shader.Find("_Value");
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
			EFDEIFCDAFG().SetFloat("getfloat", HBJJOCHGOPH);
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
				JIBOKBCPDLC().SetFloat("_AdaptationSpeed", _Distance);
			}
			else
			{
				MMOODGIODPC().SetFloat("_Value2", _Distance);
			}
			JIBOKBCPDLC().SetFloat("-1", _Size);
			LPMLLJKMAMP().SetFloat("/", (!_Visualize) ? 0 : 0);
			NBPKMLMCHFN.SetFloat("_Value", _FixDistance);
			HCGJCMDJPGD().SetFloat("X", DistortionLevel * 166f);
			GCDFNHMJMIP().SetFloat("Left Stick Click", DistortionSize * 508f);
			HFBJAOFLCJI().SetFloat("CameraFilterPack_3D_Myst1", LightIntensity * 397f);
			HCGJCMDJPGD().SetTexture("CameraFilterPack/Deep_OilPaintHQ", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			KAFBNOBOIAJ().SetFloat("cancel", 1013f / farClipPlane);
			KAFBNOBOIAJ().SetVector("' ping: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 400f, 1463f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
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
		FPHEBLMINDA = Resources.Load("Connected to NameServer.") as Texture2D;
		SCShader = Shader.Find("#status");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KLILJHJNICK()
	{
		FPHEBLMINDA = Resources.Load("[") as Texture2D;
		SCShader = Shader.Find("player.goldlollipop");
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
			EPCGJFCCAFH().SetFloat("winter2020", HBJJOCHGOPH);
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
				EPCGJFCCAFH().SetFloat("CameraFilterPack/Blend2Camera_HardLight", _Distance);
			}
			else
			{
				HCGJCMDJPGD().SetFloat("_ChangeBlue", _Distance);
			}
			HFBJAOFLCJI().SetFloat("offsets", _Size);
			KAFBNOBOIAJ().SetFloat("_Value", _Visualize ? 1 : 0);
			HFBJAOFLCJI().SetFloat("CameraFilterPack/TV_Distorted", _FixDistance);
			JIBOKBCPDLC().SetFloat(" not exist", DistortionLevel * 1185f);
			NBPKMLMCHFN.SetFloat("Hex value #RRGGBB", DistortionSize * 1955f);
			NBPKMLMCHFN.SetFloat(": ", LightIntensity * 748f);
			HCGJCMDJPGD().SetTexture("GameMessagesDurationSlider", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			EFDEIFCDAFG().SetFloat("PunRespawn", 1131f / farClipPlane);
			JIBOKBCPDLC().SetVector("[MenuScene] Error: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 75f, 1002f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
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
			ADBKPGFMNKO().SetFloat("CameraFilterPack_Paper2", HBJJOCHGOPH);
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
				JIBOKBCPDLC().SetFloat("_ReflectionBufferSize", _Distance);
			}
			else
			{
				MMOODGIODPC().SetFloat("Cancel", _Distance);
			}
			AELJLBOJAIL().SetFloat("#accuracy", _Size);
			IIJMIPBMMBF().SetFloat("_TimeX", (!_Visualize) ? 1 : 0);
			ACHNOHCLGOO().SetFloat("[EditorEvent] Exception: ", _FixDistance);
			EFDEIFCDAFG().SetFloat("stretchWidth", DistortionLevel * 1884f);
			NBPKMLMCHFN.SetFloat("sounds/hit_perfect", DistortionSize * 327f);
			EFDEIFCDAFG().SetFloat("CameraFilterPack/Atmosphere_Snow_8bits", LightIntensity * 1614f);
			LPMLLJKMAMP().SetTexture("CHROMATIC_ABERRATION", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			EFDEIFCDAFG().SetFloat("_BilateralUpsampling", 1480f / farClipPlane);
			KAFBNOBOIAJ().SetVector("[PlayerController] ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 629f, 1827f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
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
		SCShader = Shader.Find("The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.");
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
		FPHEBLMINDA = Resources.Load("_ScreenResolution") as Texture2D;
		SCShader = Shader.Find("] as we haven't received a full packet for delta compression yet. This is OK if it happens for the first few frames after joining a game.");
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
		FPHEBLMINDA = Resources.Load("challenges.") as Texture2D;
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
			HHIAIGCAHDA().SetFloat("_Value3", HBJJOCHGOPH);
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
				GCDFNHMJMIP().SetFloat("player.xp", _Distance);
			}
			else
			{
				NBPKMLMCHFN.SetFloat("r", _Distance);
			}
			NBPKMLMCHFN.SetFloat(":</b> ", _Size);
			ADBKPGFMNKO().SetFloat("input", (!_Visualize) ? 1 : 0);
			HFBJAOFLCJI().SetFloat("/music", _FixDistance);
			KAFBNOBOIAJ().SetFloat("colorC", DistortionLevel * 68f);
			ADBKPGFMNKO().SetFloat(": ", DistortionSize * 1145f);
			MMOODGIODPC().SetFloat("maps.", LightIntensity * 262f);
			HCGJCMDJPGD().SetTexture("z", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HCGJCMDJPGD().SetFloat("[Left]", 1279f / farClipPlane);
			AELJLBOJAIL().SetVector("EXCEPTION:", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 155f, 418f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NDMPCDHADMJ());
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
		SCShader = Shader.Find("NetworkScene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BMIOFJFMCBG()
	{
		FPHEBLMINDA = Resources.Load("Mouse ") as Texture2D;
		SCShader = Shader.Find("curScn");
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
		SCShader = Shader.Find(" isInactive: ");
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
			ACHNOHCLGOO().SetFloat("/", HBJJOCHGOPH);
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
				EPCGJFCCAFH().SetFloat("</size>", _Distance);
			}
			else
			{
				EFDEIFCDAFG().SetFloat("position", _Distance);
			}
			JIBOKBCPDLC().SetFloat("settings_bindings_sec_", _Size);
			LPMLLJKMAMP().SetFloat("_ReflectionTexture0", (!_Visualize) ? 0 : 0);
			HHIAIGCAHDA().SetFloat("https://steamcommunity.com/sharedfiles/filedetails/?id=", _FixDistance);
			HHIAIGCAHDA().SetFloat("Drop_With_Obj", DistortionLevel * 1282f);
			MMOODGIODPC().SetFloat("_EmissionColor", DistortionSize * 656f);
			HCGJCMDJPGD().SetFloat("menu.hardcoreinfo", LightIntensity * 690f);
			ACHNOHCLGOO().SetTexture("_FixDistance", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HCGJCMDJPGD().SetFloat("DestroyPlayerObjects() failed, cause players can only destroy their own GameObjects. A Master Client can destroy anyone's. This is master: ", 1887f / farClipPlane);
			GCDFNHMJMIP().SetVector("y", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 720f, 887f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
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
			EFDEIFCDAFG().SetFloat("Editor/", HBJJOCHGOPH);
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
				ADBKPGFMNKO().SetFloat("_MainTex2", _Distance);
			}
			else
			{
				ADBKPGFMNKO().SetFloat(".r", _Distance);
			}
			EFDEIFCDAFG().SetFloat("_TimeX", _Size);
			ACHNOHCLGOO().SetFloat(".lastCheckpoint.time", (!_Visualize) ? 1 : 1);
			ADBKPGFMNKO().SetFloat("SAVE FILE", _FixDistance);
			GCDFNHMJMIP().SetFloat("#close", DistortionLevel * 334f);
			HHIAIGCAHDA().SetFloat("/", DistortionSize * 874f);
			ACHNOHCLGOO().SetFloat("CameraFilterPack/Color_GrayScale", LightIntensity * 1891f);
			EPCGJFCCAFH().SetTexture(". Check if the server is available.", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HCGJCMDJPGD().SetFloat("settings.fps", 471f / farClipPlane);
			ADBKPGFMNKO().SetVector("_Radius", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 23f, 604f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
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
		FPHEBLMINDA = Resources.Load("Clears the console and prints the logs in the specified range") as Texture2D;
		SCShader = Shader.Find("SupportLogger OnJoinedLobby(");
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
		FPHEBLMINDA = Resources.Load(".highscore") as Texture2D;
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
