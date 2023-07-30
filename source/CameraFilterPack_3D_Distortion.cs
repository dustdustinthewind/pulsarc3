// CameraFilterPack_3D_Distortion
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/3D/Distortion")]
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
			KGOLDDBHIFN().SetFloat("_Value2", HBJJOCHGOPH);
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
				PLBEJJIHFPB().SetFloat(",", _Distance);
			}
			else
			{
				IIBLJCKLGFG().SetFloat("[#clicktoacceptchallenge]", _Distance);
			}
			ADBKPGFMNKO().SetFloat("[PlayerBase] Saveing checkpoint data", _Size);
			ADBKPGFMNKO().SetFloat("14", _FixDistance);
			IIBLJCKLGFG().SetFloat("_ScreenResolution", DistortionLevel * 1926f);
			KGOLDDBHIFN().SetFloat("Join failed on GameServer. Changing back to MasterServer. Msg: ", DistortionSize * 404f);
			KGOLDDBHIFN().SetFloat("Keypad", LightIntensity * 991f);
			KGOLDDBHIFN().SetFloat("CameraFilterPack/Blur_Focus", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			ACHNOHCLGOO().SetFloat(", data: ", 725f / farClipPlane);
			GCDFNHMJMIP().SetVector("InventoryGrid", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1220f, 986f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
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
			EPCGJFCCAFH().SetFloat("musicVolume", HBJJOCHGOPH);
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
				ADBKPGFMNKO().SetFloat("Please wait..", _Distance);
			}
			else
			{
				NBPKMLMCHFN.SetFloat("seconds", _Distance);
			}
			PLBEJJIHFPB().SetFloat(" has no method \"", _Size);
			NBPKMLMCHFN.SetFloat(": ", _FixDistance);
			IONHGBPGCHK().SetFloat("_TimeX", DistortionLevel * 838f);
			ACHNOHCLGOO().SetFloat("_Parasite", DistortionSize * 1821f);
			HFBJAOFLCJI().SetFloat("\" gets executed locally only, if at all.", LightIntensity * 812f);
			NBPKMLMCHFN.SetFloat("note.4", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			PLBEJJIHFPB().SetFloat(".lastCheckpoint.penaltyScore", 437f / farClipPlane);
			PLBEJJIHFPB().SetVector("CameraFilterPack/Gradients_Ansi", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 387f, 1609f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
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
		SCShader = Shader.Find("SetParticlesEmission");
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
			PLBEJJIHFPB().SetFloat("Tab2Content", HBJJOCHGOPH);
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
				OIMMPLPBLBK().SetFloat("CameraFilterPack_TV_BrokenGlass_2", _Distance);
			}
			else
			{
				NBPKMLMCHFN.SetFloat("88f00bdf0ad61b16b803971ebe071962", _Distance);
			}
			OIMMPLPBLBK().SetFloat("Received event Leave for unknown player ID: {0}", _Size);
			OIMMPLPBLBK().SetFloat("_ScreenResolution", _FixDistance);
			KGOLDDBHIFN().SetFloat("color", DistortionLevel * 940f);
			ACHNOHCLGOO().SetFloat("_BlurVector", DistortionSize * 1632f);
			PLBEJJIHFPB().SetFloat("Subscribed cells:\n", LightIntensity * 1936f);
			NBPKMLMCHFN.SetFloat(", data: ", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			EPCGJFCCAFH().SetFloat("Instantiating: ", 1856f / farClipPlane);
			IIBLJCKLGFG().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 751f, 600f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JKFDDNMPOJH()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JILOMOBDPIA()
	{
		SCShader = Shader.Find("Forward");
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
		SCShader = Shader.Find("SetSatelliteInput");
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
			IONHGBPGCHK().SetFloat("[Left]", HBJJOCHGOPH);
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
				EPCGJFCCAFH().SetFloat("UseScanLineSize", _Distance);
			}
			else
			{
				IONHGBPGCHK().SetFloat("_MainTex2", _Distance);
			}
			EPCGJFCCAFH().SetFloat("maphash", _Size);
			OIMMPLPBLBK().SetFloat("/", _FixDistance);
			EPCGJFCCAFH().SetFloat("_Luminance", DistortionLevel * 973f);
			IONHGBPGCHK().SetFloat("_Vignette", DistortionSize * 1641f);
			NBPKMLMCHFN.SetFloat(".lastCheckpoint.penaltyScore", LightIntensity * 1139f);
			MMOODGIODPC().SetFloat("DPADVER", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			ACHNOHCLGOO().SetFloat("[PlayerBase] Loaded spawner data", 86f / farClipPlane);
			EPCGJFCCAFH().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1416f, 1734f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
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
			GCDFNHMJMIP().SetFloat("_ScreenResolution", HBJJOCHGOPH);
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
				OIMMPLPBLBK().SetFloat("_TimeX", _Distance);
			}
			else
			{
				MMOODGIODPC().SetFloat("Out {0,4} | In {1,4} | Sum {2,4}", _Distance);
			}
			PLBEJJIHFPB().SetFloat("CameraFilterPack/Blend2Camera_Color", _Size);
			KGOLDDBHIFN().SetFloat("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception", _FixDistance);
			ADBKPGFMNKO().SetFloat("CorrectHitsScoreText", DistortionLevel * 1900f);
			IIBLJCKLGFG().SetFloat("_LightIntensity", DistortionSize * 1445f);
			PLBEJJIHFPB().SetFloat("_MainTex2", LightIntensity * 771f);
			IIBLJCKLGFG().SetFloat("SetPlayerDistance", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			NBPKMLMCHFN.SetFloat("_Value3", 844f / farClipPlane);
			ADBKPGFMNKO().SetVector("settings.gamemessagesduration", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1740f, 199f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
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
			OIMMPLPBLBK().SetFloat(": ", HBJJOCHGOPH);
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
				MMOODGIODPC().SetFloat("%", _Distance);
			}
			else
			{
				EPCGJFCCAFH().SetFloat("CameraFilterPack/TV_WideScreenHorizontal", _Distance);
			}
			ACHNOHCLGOO().SetFloat("ShowSprite", _Size);
			KGOLDDBHIFN().SetFloat("_FarCamera", _FixDistance);
			HFBJAOFLCJI().SetFloat("Show Image", DistortionLevel * 10f);
			ACHNOHCLGOO().SetFloat(" ", DistortionSize * 685f);
			EPCGJFCCAFH().SetFloat("_Vignetting", LightIntensity * 449f);
			GCDFNHMJMIP().SetFloat("health", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			MMOODGIODPC().SetFloat("_TimeX", 815f / farClipPlane);
			MMOODGIODPC().SetVector("menutheme.27thfloor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1032f, 441f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
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
			ADBKPGFMNKO().SetFloat("ClearEnvironment", HBJJOCHGOPH);
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
				GCDFNHMJMIP().SetFloat("_", _Distance);
			}
			else
			{
				EPCGJFCCAFH().SetFloat("_TimeX", _Distance);
			}
			PLBEJJIHFPB().SetFloat("Set camera (or player) distance. Base player distance - 14", _Size);
			PLBEJJIHFPB().SetFloat("_TimeX", _FixDistance);
			IONHGBPGCHK().SetFloat("MapperNameText", DistortionLevel * 1054f);
			NBPKMLMCHFN.SetFloat("The given 2D texture ", DistortionSize * 1551f);
			GCDFNHMJMIP().SetFloat("_Value2", LightIntensity * 949f);
			KGOLDDBHIFN().SetFloat("_Value1", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HFBJAOFLCJI().SetFloat("No child content found, exiting..", 1922f / farClipPlane);
			MMOODGIODPC().SetVector(" - ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 302f, 1608f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
