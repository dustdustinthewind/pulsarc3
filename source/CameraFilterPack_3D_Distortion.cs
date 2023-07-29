// CameraFilterPack_3D_Distortion
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/3D/Distortion")]
[ExecuteInEditMode]
public class CameraFilterPack_3D_Distortion : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	public bool _Visualize;

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

	private void PHJLHCMCCKE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1408f)
			{
				HBJJOCHGOPH = 740f;
			}
			ADBKPGFMNKO().SetFloat("_Value3", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1227f)
				{
					_Distance = 35f;
				}
				if (_Distance < 1763f)
				{
					_Distance = 694f;
				}
				IIBLJCKLGFG().SetFloat("element", _Distance);
			}
			else
			{
				GCDFNHMJMIP().SetFloat("#task", _Distance);
			}
			HFBJAOFLCJI().SetFloat("maps.", _Size);
			EPCGJFCCAFH().SetFloat("Working.\nPlease wait..", _FixDistance);
			PLBEJJIHFPB().SetFloat("CameraFilterPack/Edge_Sigmoid", DistortionLevel * 1926f);
			KGOLDDBHIFN().SetFloat("Join failed on GameServer. Changing back to MasterServer. Msg: ", DistortionSize * 404f);
			ADBKPGFMNKO().SetFloat("Keypad", LightIntensity * 991f);
			ACHNOHCLGOO().SetFloat("_TimeX", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			IIBLJCKLGFG().SetFloat("return ", 725f / farClipPlane);
			ADBKPGFMNKO().SetVector("GroupNameText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1220f, 986f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 621f)
			{
				HBJJOCHGOPH = 931f;
			}
			NBPKMLMCHFN.SetFloat("masterVolume", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 115f)
				{
					_Distance = 260f;
				}
				if (_Distance < 91f)
				{
					_Distance = 104f;
				}
				IONHGBPGCHK().SetFloat("Please wait..", _Distance);
			}
			else
			{
				NBPKMLMCHFN.SetFloat("seconds", _Distance);
			}
			IONHGBPGCHK().SetFloat("PhotonView with ID ", _Size);
			OIMMPLPBLBK().SetFloat("0.00", _FixDistance);
			IONHGBPGCHK().SetFloat("_TimeX", DistortionLevel * 838f);
			MMOODGIODPC().SetFloat("_ScreenResolution", DistortionSize * 1821f);
			ADBKPGFMNKO().SetFloat("Could not execute RPC ", LightIntensity * 812f);
			MMOODGIODPC().SetFloat("note.5", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HFBJAOFLCJI().SetFloat(".lastCheckpoint.currentCombo", 437f / farClipPlane);
			PLBEJJIHFPB().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 387f, 1609f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HMPGIFBJFIK()
	{
		SCShader = Shader.Find("FullscreenToggle");
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

	private void KIMMMCJFMAB()
	{
		SCShader = Shader.Find("Set Particles Emission");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material OIMMPLPBLBK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)111;
		}
		return BJFKDHHMLJH;
	}

	private void IHLMNAGPKDA()
	{
		SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material MMOODGIODPC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void NEKCPLGFOFD()
	{
	}

	private void CFIAKIJAILI()
	{
	}

	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 505f)
			{
				HBJJOCHGOPH = 825f;
			}
			OIMMPLPBLBK().SetFloat("LivesSlider", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 977f)
				{
					_Distance = 1219f;
				}
				if (_Distance < 1060f)
				{
					_Distance = 1735f;
				}
				IONHGBPGCHK().SetFloat("CameraFilterPack/TV_BrokenGlass2", _Distance);
			}
			else
			{
				OIMMPLPBLBK().SetFloat("d264dbba9c2410771b4ad918903b3f4cd9e276a9", _Distance);
			}
			PLBEJJIHFPB().SetFloat(". Stopping handling if inactive.", _Size);
			MMOODGIODPC().SetFloat("CameraFilterPack/TV_50", _FixDistance);
			PLBEJJIHFPB().SetFloat("Start Color's hex value #RRGGBBAA", DistortionLevel * 940f);
			ADBKPGFMNKO().SetFloat("_BlurVector", DistortionSize * 1632f);
			EPCGJFCCAFH().SetFloat("<color=white>PhotonView Group: ", LightIntensity * 1936f);
			NBPKMLMCHFN.SetFloat("return ", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			EPCGJFCCAFH().SetFloat("PunRespawn", 1856f / farClipPlane);
			HFBJAOFLCJI().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 751f, 600f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JKFDDNMPOJH()
	{
		SCShader = Shader.Find("CameraFilterPack/Gradients_Desert");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JILOMOBDPIA()
	{
		SCShader = Shader.Find("Backward");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
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
			NBPKMLMCHFN.SetFloat("_FixDistance", _FixDistance);
			NBPKMLMCHFN.SetFloat("_DistortionLevel", DistortionLevel * 28f);
			NBPKMLMCHFN.SetFloat("_DistortionSize", DistortionSize * 16f);
			NBPKMLMCHFN.SetFloat("_LightIntensity", LightIntensity * 64f);
			NBPKMLMCHFN.SetFloat("_Visualize", _Visualize ? 1 : 0);
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

	private void JHLGHODFJOO()
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return BJFKDHHMLJH;
	}

	private void NPLCENPNJBM()
	{
		SCShader = Shader.Find("SetSatelliteSensitivity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material EPCGJFCCAFH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void FOMNCPKKCFN()
	{
	}

	private void OCCGJMPAJIK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Update()
	{
	}

	[SpecialName]
	private Material GCDFNHMJMIP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)92;
		}
		return BJFKDHHMLJH;
	}

	private void KCDOMIJBFLL()
	{
	}

	[SpecialName]
	private Material ACHNOHCLGOO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void KMKLDAJLCNM()
	{
	}

	private void JNGMIAFLBDL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/3D_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1091f)
			{
				HBJJOCHGOPH = 85f;
			}
			PLBEJJIHFPB().SetFloat("[Right]", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1411f)
				{
					_Distance = 861f;
				}
				if (_Distance < 1201f)
				{
					_Distance = 403f;
				}
				NBPKMLMCHFN.SetFloat("UseScanLine", _Distance);
			}
			else
			{
				MMOODGIODPC().SetFloat("_MainTex2", _Distance);
			}
			PLBEJJIHFPB().SetFloat("difficulty", _Size);
			ADBKPGFMNKO().SetFloat("[MapsData] Preloading workshop", _FixDistance);
			HFBJAOFLCJI().SetFloat("DISTORT", DistortionLevel * 973f);
			HFBJAOFLCJI().SetFloat("_Linecount", DistortionSize * 1641f);
			KGOLDDBHIFN().SetFloat(".lastCheckpoint.currentCombo", LightIntensity * 1139f);
			GCDFNHMJMIP().SetFloat("DPADVER", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			KGOLDDBHIFN().SetFloat(".", 86f / farClipPlane);
			NBPKMLMCHFN.SetVector("Tab1Content", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1416f, 1734f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material PLBEJJIHFPB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void NCNPAKFAFOE()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material HFBJAOFLCJI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-69);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IIBLJCKLGFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void CBIBDOIBJAI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 419f)
			{
				HBJJOCHGOPH = 0f;
			}
			PLBEJJIHFPB().SetFloat("CameraFilterPack/Distortion_ShockWave", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1957f)
				{
					_Distance = 1663f;
				}
				if (_Distance < 884f)
				{
					_Distance = 1588f;
				}
				PLBEJJIHFPB().SetFloat("_Value", _Distance);
			}
			else
			{
				NBPKMLMCHFN.SetFloat("Reset", _Distance);
			}
			ACHNOHCLGOO().SetFloat("CameraFilterPack/Blend2Camera_Color", _Size);
			PLBEJJIHFPB().SetFloat("Item ", _FixDistance);
			ADBKPGFMNKO().SetFloat("IncorrectHitsScoreText", DistortionLevel * 1900f);
			NBPKMLMCHFN.SetFloat("_LightIntensity", DistortionSize * 1445f);
			GCDFNHMJMIP().SetFloat("_MainTex2", LightIntensity * 771f);
			IIBLJCKLGFG().SetFloat("Set Player Distance", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			NBPKMLMCHFN.SetFloat("_Value4", 844f / farClipPlane);
			MMOODGIODPC().SetVector("ArcsDestroyDelaySlider", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1740f, 199f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OFIMMFHFHDD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1818f)
			{
				HBJJOCHGOPH = 426f;
			}
			KGOLDDBHIFN().SetFloat(": ", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1787f)
				{
					_Distance = 355f;
				}
				if (_Distance < 1701f)
				{
					_Distance = 137f;
				}
				KGOLDDBHIFN().SetFloat("%", _Distance);
			}
			else
			{
				MMOODGIODPC().SetFloat("_Value", _Distance);
			}
			HFBJAOFLCJI().SetFloat("Checkpoint", _Size);
			EPCGJFCCAFH().SetFloat("_FarCamera", _FixDistance);
			NBPKMLMCHFN.SetFloat("Show Image", DistortionLevel * 10f);
			ADBKPGFMNKO().SetFloat("MainButton", DistortionSize * 685f);
			KGOLDDBHIFN().SetFloat("_Vignetting2", LightIntensity * 449f);
			MMOODGIODPC().SetFloat("Out {0,4} | In {1,4} | Sum {2,4}", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			KGOLDDBHIFN().SetFloat("_TimeX", 815f / farClipPlane);
			IONHGBPGCHK().SetVector("player.circle", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1032f, 441f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material KGOLDDBHIFN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 303f)
			{
				HBJJOCHGOPH = 769f;
			}
			HFBJAOFLCJI().SetFloat("SetParent", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1754f)
				{
					_Distance = 525f;
				}
				if (_Distance < 115f)
				{
					_Distance = 1955f;
				}
				MMOODGIODPC().SetFloat("_RgbTex", _Distance);
			}
			else
			{
				NBPKMLMCHFN.SetFloat("_DotSize", _Distance);
			}
			HFBJAOFLCJI().SetFloat("SetTrailZoomSpeed", _Size);
			NBPKMLMCHFN.SetFloat("_Value", _FixDistance);
			GCDFNHMJMIP().SetFloat("workshop.", DistortionLevel * 1054f);
			KGOLDDBHIFN().SetFloat(" cannot be used as a 3D LUT.", DistortionSize * 1551f);
			HFBJAOFLCJI().SetFloat("_Value3", LightIntensity * 949f);
			ADBKPGFMNKO().SetFloat("_Value1", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			IIBLJCKLGFG().SetFloat("Year_", 1922f / farClipPlane);
			ACHNOHCLGOO().SetVector("[MapsStats] Hash: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 302f, 1608f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
