// CameraFilterPack_3D_Myst
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/3D/Myst")]
[ExecuteInEditMode]
public class CameraFilterPack_3D_Myst : MonoBehaviour
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

	[SpecialName]
	private Material GCDFNHMJMIP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void FJHFOBHJEHL()
	{
	}

	private void BMIOFJFMCBG()
	{
		FPHEBLMINDA = Resources.Load(" not exist") as Texture2D;
		SCShader = Shader.Find("Working commands:\nreset <challengeid>\nresetall");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KOJKBFDNGDK()
	{
		FPHEBLMINDA = Resources.Load("_DistortionLevel") as Texture2D;
		SCShader = Shader.Find("OxOD.lastPath");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 230f)
			{
				HBJJOCHGOPH = 657f;
			}
			OCMBHMLNCEK().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 784f)
				{
					_Distance = 1735f;
				}
				if (_Distance < 1301f)
				{
					_Distance = 1762f;
				}
				CECICEGFHKL().SetFloat("SetSpeed", _Distance);
			}
			else
			{
				HKHBBBFLGJH().SetFloat("Reload Maps", _Distance);
			}
			HKIMAANBGMJ().SetFloat("_FarCamera", _Size);
			FEAEGGCNIAA().SetFloat("HPToggle", (!_Visualize) ? 0 : 0);
			KEMJNOMIPHN().SetFloat("levelcompleted", _FixDistance);
			HKIMAANBGMJ().SetFloat(". Check if the server is available.", DistortionLevel * 1426f);
			LMLENGFLEBD().SetFloat("\n", DistortionSize * 319f);
			EOCCJGIGEGJ().SetFloat("LB", LightIntensity * 130f);
			EFDEIFCDAFG().SetTexture("Hex value #RRGGBB", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			MFHPKGICPIO().SetFloat("y", 679f / farClipPlane);
			LMLENGFLEBD().SetVector("[UI] ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1437f, 280f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADAFMBOGPLN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	private void OFMNDBNFBDJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 623f)
			{
				HBJJOCHGOPH = 1684f;
			}
			ADBKPGFMNKO().SetFloat("music", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 730f)
				{
					_Distance = 1828f;
				}
				if (_Distance < 5f)
				{
					_Distance = 559f;
				}
				HHLFDHNEIAH().SetFloat("_ScreenResolution", _Distance);
			}
			else
			{
				HFBJAOFLCJI().SetFloat("_ScreenResolution", _Distance);
			}
			FEAEGGCNIAA().SetFloat("GraphicsQualitySlider", _Size);
			HKHBBBFLGJH().SetFloat("_Value", (!_Visualize) ? 0 : 0);
			NBPKMLMCHFN.SetFloat("Please specify either t or f.", _FixDistance);
			HKIMAANBGMJ().SetFloat("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", DistortionLevel * 1004f);
			MFHPKGICPIO().SetFloat("/Assets/MyImage", DistortionSize * 1218f);
			HFBJAOFLCJI().SetFloat("_MainTex2", LightIntensity * 1123f);
			HKIMAANBGMJ().SetTexture("[Left]", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			NBPKMLMCHFN.SetFloat("Tab2Content", 1755f / farClipPlane);
			KEMJNOMIPHN().SetVector("restart", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1082f, 937f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IMGGCJICLHK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LFAFJKJAEEL()
	{
		FPHEBLMINDA = Resources.Load("_Value") as Texture2D;
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PJIFJFENPJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1649f)
			{
				HBJJOCHGOPH = 1668f;
			}
			ADAFMBOGPLN().SetFloat("Waiting to start", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1331f)
				{
					_Distance = 222f;
				}
				if (_Distance < 848f)
				{
					_Distance = 481f;
				}
				EOCCJGIGEGJ().SetFloat("sounds/hit_perfect", _Distance);
			}
			else
			{
				EOCCJGIGEGJ().SetFloat("settings.gamemessagesduration", _Distance);
			}
			GCDFNHMJMIP().SetFloat("ResetButton", _Size);
			HKHBBBFLGJH().SetFloat("Exit to Windows", (!_Visualize) ? 1 : 0);
			JLHLHKPHDFO().SetFloat("_Value4", _FixDistance);
			ADBKPGFMNKO().SetFloat("maps.", DistortionLevel * 723f);
			NBPKMLMCHFN.SetFloat("menu.tabid", DistortionSize * 110f);
			HHLFDHNEIAH().SetFloat("_NoiseTilingPerChannel", LightIntensity * 1332f);
			FEAEGGCNIAA().SetTexture("checkpoint", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			CFEDGDGBCHE().SetFloat("curScn", 1789f / farClipPlane);
			NMDBCDFPGOK().SetVector("player.quantum", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 741f, 1412f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material CFEDGDGBCHE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return BJFKDHHMLJH;
	}

	private void EDCMIPNCPLB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DLMPALHKMON()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MFMIODIAKNI()
	{
	}

	[SpecialName]
	private Material ADBKPGFMNKO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-112);
		}
		return BJFKDHHMLJH;
	}

	private void KKEOHFGKCIK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LFBGJIIECLD()
	{
		FPHEBLMINDA = Resources.Load("_Value8") as Texture2D;
		SCShader = Shader.Find("\\n");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BMODOIJGIOO()
	{
	}

	private void EHJJFJCKGAJ()
	{
	}

	private void ANBIJFCCANE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 651f)
			{
				HBJJOCHGOPH = 1450f;
			}
			OCMBHMLNCEK().SetFloat("_TimeX", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 307f)
				{
					_Distance = 1644f;
				}
				if (_Distance < 1254f)
				{
					_Distance = 1004f;
				}
				NMDBCDFPGOK().SetFloat("[EMPTY]", _Distance);
			}
			else
			{
				GHHPOGODBHB().SetFloat("#000000CC", _Distance);
			}
			NMDBCDFPGOK().SetFloat("_Speed", _Size);
			GHHPOGODBHB().SetFloat("[NetworkManager] Joined room with ", (!_Visualize) ? 1 : 0);
			CFEDGDGBCHE().SetFloat("_FarCamera", _FixDistance);
			MFHPKGICPIO().SetFloat("_TimeX", DistortionLevel * 177f);
			CFEDGDGBCHE().SetFloat("maps.", DistortionSize * 53f);
			HFBJAOFLCJI().SetFloat("CameraFilterPack_3D_Matrix1", LightIntensity * 694f);
			HKHBBBFLGJH().SetTexture("_EmissionColor", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			KEMJNOMIPHN().SetFloat("_Near", 796f / farClipPlane);
			OCMBHMLNCEK().SetVector("settings.fps", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 959f, 762f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 19f)
			{
				HBJJOCHGOPH = 1671f;
			}
			FEAEGGCNIAA().SetFloat("_OcclusionBlurTexture", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 171f)
				{
					_Distance = 1971f;
				}
				if (_Distance < 695f)
				{
					_Distance = 1715f;
				}
				HKHBBBFLGJH().SetFloat("Ownership mode == fixed. Ignoring request.", _Distance);
			}
			else
			{
				EOCCJGIGEGJ().SetFloat("CameraFilterPack/TV_WideScreenVertical", _Distance);
			}
			FEAEGGCNIAA().SetFloat("SettingsCanvas", _Size);
			FEAEGGCNIAA().SetFloat("_DiffuseColor", (!_Visualize) ? 1 : 0);
			CFEDGDGBCHE().SetFloat("_TimeX", _FixDistance);
			HFBJAOFLCJI().SetFloat("GUICamera", DistortionLevel * 11f);
			MFHPKGICPIO().SetFloat("/../", DistortionSize * 735f);
			NBPKMLMCHFN.SetFloat("Curve texture", LightIntensity * 1198f);
			HHLFDHNEIAH().SetTexture("note.2", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			EFDEIFCDAFG().SetFloat("_Speed", 1133f / farClipPlane);
			EFDEIFCDAFG().SetVector("_Near", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1092f, 425f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHLFDHNEIAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DBLILJGKGHJ()
	{
		FPHEBLMINDA = Resources.Load("points:") as Texture2D;
		SCShader = Shader.Find("_Min");
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

	private void HJPCJGOEKMF()
	{
		FPHEBLMINDA = Resources.Load("_Heigh") as Texture2D;
		SCShader = Shader.Find("VIGNETTE_FILMIC");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NEFHGMNAPEP()
	{
		FPHEBLMINDA = Resources.Load("set id") as Texture2D;
		SCShader = Shader.Find("View");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NJHJHBOJKIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HLHJBJGEEEA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 254f)
			{
				HBJJOCHGOPH = 1682f;
			}
			GHHPOGODBHB().SetFloat("Tab1Content", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 260f)
				{
					_Distance = 832f;
				}
				if (_Distance < 1454f)
				{
					_Distance = 409f;
				}
				EOCCJGIGEGJ().SetFloat("z", _Distance);
			}
			else
			{
				HFBJAOFLCJI().SetFloat("player.mysteryitem", _Distance);
			}
			GHHPOGODBHB().SetFloat("LivesSlider", _Size);
			CECICEGFHKL().SetFloat("_ScreenResolution", (!_Visualize) ? 1 : 1);
			HKIMAANBGMJ().SetFloat("14", _FixDistance);
			GHHPOGODBHB().SetFloat("Created by ", DistortionLevel * 615f);
			HKHBBBFLGJH().SetFloat("ResourceFileSelector", DistortionSize * 1246f);
			LMLENGFLEBD().SetFloat("_Value2", LightIntensity * 1673f);
			EOCCJGIGEGJ().SetTexture("ZoomFade", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HHLFDHNEIAH().SetFloat("CameraFilterPack/Alien_Vision", 1139f / farClipPlane);
			MFHPKGICPIO().SetVector("_InvViewProj", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1703f, 53f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OPKNFOGMGII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1287f)
			{
				HBJJOCHGOPH = 894f;
			}
			HKHBBBFLGJH().SetFloat("Scrollbar", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 356f)
				{
					_Distance = 789f;
				}
				if (_Distance < 848f)
				{
					_Distance = 1839f;
				}
				JLHLHKPHDFO().SetFloat("CameraFilterPack/Blend2Camera_LinearBurn", _Distance);
			}
			else
			{
				FEAEGGCNIAA().SetFloat("CameraFilterPack_VHS2", _Distance);
			}
			HKIMAANBGMJ().SetFloat("/", _Size);
			LMLENGFLEBD().SetFloat("_Value", (!_Visualize) ? 0 : 0);
			CFEDGDGBCHE().SetFloat("_Value6", _FixDistance);
			ADBKPGFMNKO().SetFloat(": ", DistortionLevel * 928f);
			GCDFNHMJMIP().SetFloat("LastNewsButton", DistortionSize * 1001f);
			OCMBHMLNCEK().SetFloat("position", LightIntensity * 797f);
			NBPKMLMCHFN.SetTexture("_Value4", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			KEMJNOMIPHN().SetFloat("settings.cameramovements", 1349f / farClipPlane);
			MFHPKGICPIO().SetVector("System.Int64", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1981f, 1584f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OEIBFOHPOPD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material GHHPOGODBHB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void FDMAEPOHDMK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material KEMJNOMIPHN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void EPJJDKJEDMM()
	{
	}

	private void JILOMOBDPIA()
	{
		FPHEBLMINDA = Resources.Load("Multiplayer") as Texture2D;
		SCShader = Shader.Find("GameModeText");
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
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable;
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

	private void LNOOFNGHNEL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 662f)
			{
				HBJJOCHGOPH = 390f;
			}
			MFHPKGICPIO().SetFloat("#task", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 534f)
				{
					_Distance = 283f;
				}
				if (_Distance < 156f)
				{
					_Distance = 1902f;
				}
				EFDEIFCDAFG().SetFloat("SetParent", _Distance);
			}
			else
			{
				OCMBHMLNCEK().SetFloat("\n", _Distance);
			}
			KEMJNOMIPHN().SetFloat(": ", _Size);
			NBPKMLMCHFN.SetFloat("colorA", _Visualize ? 1 : 0);
			NMDBCDFPGOK().SetFloat("PerfectHitsScoreText", _FixDistance);
			JLHLHKPHDFO().SetFloat("_MainTex2", DistortionLevel * 898f);
			ADAFMBOGPLN().SetFloat("<color=#{0}>{1}</color>", DistortionSize * 1458f);
			JLHLHKPHDFO().SetFloat(" takes from: ", LightIntensity * 1723f);
			FEAEGGCNIAA().SetTexture("win", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			MFHPKGICPIO().SetFloat("CameraFilterPack/Blend2Camera_VividLight", 769f / farClipPlane);
			HHLFDHNEIAH().SetVector("RequestForPickupItems", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 893f, 1989f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1814f)
			{
				HBJJOCHGOPH = 1896f;
			}
			NBPKMLMCHFN.SetFloat("CameraFilterPack/3D_Binary", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1358f)
				{
					_Distance = 1873f;
				}
				if (_Distance < 1647f)
				{
					_Distance = 1048f;
				}
				EFDEIFCDAFG().SetFloat("ConnectUsingSettings() disabled the offline mode. No longer offline.", _Distance);
			}
			else
			{
				HFBJAOFLCJI().SetFloat("CameraFilterPack/TV_Chromatical2", _Distance);
			}
			EOCCJGIGEGJ().SetFloat("Bad parameters for setstring! Use <key> <value>", _Size);
			KEMJNOMIPHN().SetFloat("[ResourcesManager] Load text error: not found", (!_Visualize) ? 0 : 0);
			EFDEIFCDAFG().SetFloat("_Intensity", _FixDistance);
			FEAEGGCNIAA().SetFloat("[ResourcesManager] Load audio error: ", DistortionLevel * 1048f);
			JLHLHKPHDFO().SetFloat("Set satellite emission (glow)", DistortionSize * 1915f);
			HFBJAOFLCJI().SetFloat("PlayMusic", LightIntensity * 1437f);
			EOCCJGIGEGJ().SetTexture("Joystick1Button2", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			ADBKPGFMNKO().SetFloat("offsets", 1718f / farClipPlane);
			HKIMAANBGMJ().SetVector("[MapsSystem] Unloading maps resources...", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 997f, 387f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HPFIHLMKIPF()
	{
		FPHEBLMINDA = Resources.Load("DifficultyBG") as Texture2D;
		SCShader = Shader.Find("challenges.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JFJLGJEPEAA()
	{
		FPHEBLMINDA = Resources.Load("NO") as Texture2D;
		SCShader = Shader.Find("Run a command for the Localization Servise");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EKCKJLFFAID()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CFFCLAHMBAA()
	{
		FPHEBLMINDA = Resources.Load("in seconds. 0 - forever") as Texture2D;
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DKOPKPBLDHH()
	{
		FPHEBLMINDA = Resources.Load("_NormalAndRoughnessTexture") as Texture2D;
		SCShader = Shader.Find("RecieveChatActionMessage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 193f)
			{
				HBJJOCHGOPH = 861f;
			}
			JLHLHKPHDFO().SetFloat("MenuScene", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 621f)
				{
					_Distance = 1161f;
				}
				if (_Distance < 1429f)
				{
					_Distance = 619f;
				}
				HFBJAOFLCJI().SetFloat("threshold", _Distance);
			}
			else
			{
				JLHLHKPHDFO().SetFloat("Result for ", _Distance);
			}
			ADAFMBOGPLN().SetFloat("_ProjInfo", _Size);
			CFEDGDGBCHE().SetFloat("00", (!_Visualize) ? 1 : 0);
			NMDBCDFPGOK().SetFloat("Submit", _FixDistance);
			HKHBBBFLGJH().SetFloat(".", DistortionLevel * 259f);
			JLHLHKPHDFO().SetFloat("_MainTex2", DistortionSize * 9f);
			ADAFMBOGPLN().SetFloat("[NetworkManager] Exited", LightIntensity * 1635f);
			NBPKMLMCHFN.SetTexture("USE_DIAG_SEARCH", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HFBJAOFLCJI().SetFloat("_Threshold", 226f / farClipPlane);
			EOCCJGIGEGJ().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 680f, 1854f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FDNONDCGGCG()
	{
		FPHEBLMINDA = Resources.Load("Set satellite trail width") as Texture2D;
		SCShader = Shader.Find("PointsScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 759f)
			{
				HBJJOCHGOPH = 353f;
			}
			MFHPKGICPIO().SetFloat("ConfigVersionSlider", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 221f)
				{
					_Distance = 704f;
				}
				if (_Distance < 1545f)
				{
					_Distance = 1748f;
				}
				HKIMAANBGMJ().SetFloat("_BorderColor", _Distance);
			}
			else
			{
				CECICEGFHKL().SetFloat("Done! You are a contributor until: ", _Distance);
			}
			NMDBCDFPGOK().SetFloat("restart", _Size);
			GCDFNHMJMIP().SetFloat("2", (!_Visualize) ? 1 : 1);
			NMDBCDFPGOK().SetFloat("Submition failed", _FixDistance);
			MFHPKGICPIO().SetFloat("KickThePlayer", DistortionLevel * 589f);
			NMDBCDFPGOK().SetFloat("You need to have a Graphic control (such as an Image) for the list [", DistortionSize * 294f);
			NBPKMLMCHFN.SetFloat("OnJoinedRoom() called by PUN. Now this client is in a room. From here on, your game would be running. For reference, all callbacks are listed in enum: PhotonNetworkingMessage", LightIntensity * 1242f);
			EOCCJGIGEGJ().SetTexture("_MainTex2", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			ADAFMBOGPLN().SetFloat("_Value5", 1961f / farClipPlane);
			KEMJNOMIPHN().SetVector("(master)", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 262f, 98f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GBGAMCPNBCC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MMMDPANNAIO()
	{
		FPHEBLMINDA = Resources.Load("[NetworkManager] Connected to ") as Texture2D;
		SCShader = Shader.Find("SetEnvSpriteImage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material HKHBBBFLGJH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)103;
		}
		return BJFKDHHMLJH;
	}

	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1002f)
			{
				HBJJOCHGOPH = 221f;
			}
			HHLFDHNEIAH().SetFloat("[ItemsHandler] Loading ", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 40f)
				{
					_Distance = 65f;
				}
				if (_Distance < 400f)
				{
					_Distance = 1020f;
				}
				GHHPOGODBHB().SetFloat("_Value", _Distance);
			}
			else
			{
				NMDBCDFPGOK().SetFloat("Gameplay/Base", _Distance);
			}
			GHHPOGODBHB().SetFloat("_Value2", _Size);
			ADBKPGFMNKO().SetFloat("_PrevViewProj", (!_Visualize) ? 0 : 0);
			FEAEGGCNIAA().SetFloat("settings.fps", _FixDistance);
			EFDEIFCDAFG().SetFloat("settings.volume.menu", DistortionLevel * 454f);
			EFDEIFCDAFG().SetFloat(".", DistortionSize * 216f);
			HKIMAANBGMJ().SetFloat("CameraFilterPack/Gradients_NeonGradient", LightIntensity * 359f);
			HFBJAOFLCJI().SetTexture(" not exist", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			KEMJNOMIPHN().SetFloat("StartButton", 1444f / farClipPlane);
			HHLFDHNEIAH().SetVector("restrictions\n\n#until: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 319f, 1192f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NMDBCDFPGOK());
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
			if (HBJJOCHGOPH > 460f)
			{
				HBJJOCHGOPH = 391f;
			}
			HKIMAANBGMJ().SetFloat("Unsupported type: ", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 688f)
				{
					_Distance = 849f;
				}
				if (_Distance < 1895f)
				{
					_Distance = 960f;
				}
				EOCCJGIGEGJ().SetFloat("HightScoreMaxPointsText", _Distance);
			}
			else
			{
				HKIMAANBGMJ().SetFloat("_TimeX", _Distance);
			}
			HKIMAANBGMJ().SetFloat("selector", _Size);
			ADBKPGFMNKO().SetFloat(",0", (!_Visualize) ? 0 : 0);
			KEMJNOMIPHN().SetFloat(" ", _FixDistance);
			FEAEGGCNIAA().SetFloat("_TimeX", DistortionLevel * 1414f);
			EFDEIFCDAFG().SetFloat("_Visualize", DistortionSize * 138f);
			HKHBBBFLGJH().SetFloat(".lastCheckpoint.longestComboScore", LightIntensity * 12f);
			LMLENGFLEBD().SetTexture("SSAARenderTargetCamera", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			CECICEGFHKL().SetFloat("AddEnvironmentObject", 1700f / farClipPlane);
			MFHPKGICPIO().SetVector("_EmissionColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1638f, 1467f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHLFDHNEIAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DHENLPJJOEN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JDKHBGDEONK()
	{
		FPHEBLMINDA = Resources.Load("_FrustumCornersWS") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Blend2Camera_Overlay");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EDPDMBFLHLP()
	{
		FPHEBLMINDA = Resources.Load("[PlayerBase] SetBGColor error: ") as Texture2D;
		SCShader = Shader.Find("EventSystem");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NNCCPEBIAKH()
	{
		FPHEBLMINDA = Resources.Load("Tab2Content") as Texture2D;
		SCShader = Shader.Find("MenuScene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HPFOFGJPNCI()
	{
		FPHEBLMINDA = Resources.Load("BadgeText") as Texture2D;
		SCShader = Shader.Find("settings.showHP");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JOONHGHGKKF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IBLGHLNNAHN()
	{
		FPHEBLMINDA = Resources.Load("Received RPC: ") as Texture2D;
		SCShader = Shader.Find("#close");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material FEAEGGCNIAA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	private void JOHOFNKJDEB()
	{
		FPHEBLMINDA = Resources.Load("OneHand") as Texture2D;
		SCShader = Shader.Find("Bad parameters for set! Use <language>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GMELGGJOPBB()
	{
	}

	private void CBIBDOIBJAI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MMPHNFPPEHO()
	{
		FPHEBLMINDA = Resources.Load("DontDestroy") as Texture2D;
		SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OKLAJINHPAN()
	{
		FPHEBLMINDA = Resources.Load("menu.playedsolo") as Texture2D;
		SCShader = Shader.Find("Set particles start speed");
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void GLEJGFLCLPJ()
	{
		FPHEBLMINDA = Resources.Load("#roomname") as Texture2D;
		SCShader = Shader.Find("Received unknown status code: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AIBNKIDADPI()
	{
		FPHEBLMINDA = Resources.Load("RecieveChatActionMessage") as Texture2D;
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BOPKKCAFODF()
	{
		FPHEBLMINDA = Resources.Load("Joystick1Button9") as Texture2D;
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 195f)
			{
				HBJJOCHGOPH = 950f;
			}
			LMLENGFLEBD().SetFloat("_TimeX", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 97f)
				{
					_Distance = 1558f;
				}
				if (_Distance < 1036f)
				{
					_Distance = 587f;
				}
				OCMBHMLNCEK().SetFloat("OK", _Distance);
			}
			else
			{
				HKHBBBFLGJH().SetFloat("Tab2Content", _Distance);
			}
			LMLENGFLEBD().SetFloat("[Singleton] An instance of '", _Size);
			NMDBCDFPGOK().SetFloat("_TimeX", (!_Visualize) ? 1 : 1);
			HHLFDHNEIAH().SetFloat("event", _FixDistance);
			EFDEIFCDAFG().SetFloat("Sets the boolean value of the Auto Focus Input Field property.", DistortionLevel * 1021f);
			KEMJNOMIPHN().SetFloat("_ClutTex", DistortionSize * 1017f);
			KEMJNOMIPHN().SetFloat("_MainTex2", LightIntensity * 1323f);
			KEMJNOMIPHN().SetTexture("_Value", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			EFDEIFCDAFG().SetFloat("CameraFilterPack/FX_EarthQuake", 1114f / farClipPlane);
			NMDBCDFPGOK().SetVector("TwoHands", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1976f, 1021f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GHHPOGODBHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PAKPHKPDKGE()
	{
		FPHEBLMINDA = Resources.Load("ShowTitle") as Texture2D;
		SCShader = Shader.Find("_EmissionGain");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material EOCCJGIGEGJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	private void DNNFHBOOPIN()
	{
		FPHEBLMINDA = Resources.Load("finished") as Texture2D;
		SCShader = Shader.Find("_Value1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NDAJBJFJGCF()
	{
	}

	private void CNPINCHINJA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JBNPEHMDCMI()
	{
	}

	private void HPNNCNNFMGK()
	{
	}

	private void ALNNIDLFILB()
	{
		FPHEBLMINDA = Resources.Load("settings_bindings_controller_type") as Texture2D;
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GENCBNFIILN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1933f)
			{
				HBJJOCHGOPH = 1053f;
			}
			OCMBHMLNCEK().SetFloat("QuickSave", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1324f)
				{
					_Distance = 1284f;
				}
				if (_Distance < 945f)
				{
					_Distance = 840f;
				}
				FEAEGGCNIAA().SetFloat("mapselector.filter.subscribedonly", _Distance);
			}
			else
			{
				OCMBHMLNCEK().SetFloat("_Value2", _Distance);
			}
			HFBJAOFLCJI().SetFloat("bpmgrid", _Size);
			CFEDGDGBCHE().SetFloat("SetPosition", (!_Visualize) ? 1 : 1);
			NMDBCDFPGOK().SetFloat("ENABLE_DITHERING", _FixDistance);
			CFEDGDGBCHE().SetFloat("Connected to gameserver.", DistortionLevel * 1825f);
			EFDEIFCDAFG().SetFloat("_Value2", DistortionSize * 1790f);
			OCMBHMLNCEK().SetFloat("#FFDA44CC", LightIntensity * 1427f);
			LMLENGFLEBD().SetTexture("[PlayerBase] MapEnd error: ", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			GCDFNHMJMIP().SetFloat("NOISE", 423f / farClipPlane);
			EOCCJGIGEGJ().SetVector("AddEnvironmentObject", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 870f, 155f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LMLENGFLEBD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 703f)
			{
				HBJJOCHGOPH = 1278f;
			}
			ADAFMBOGPLN().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 410f)
				{
					_Distance = 1264f;
				}
				if (_Distance < 1192f)
				{
					_Distance = 1775f;
				}
				NMDBCDFPGOK().SetFloat("SpawnObj", _Distance);
			}
			else
			{
				HKIMAANBGMJ().SetFloat("BloomShaderValueSlider", _Distance);
			}
			HFBJAOFLCJI().SetFloat("settings_bindings_controller_type", _Size);
			ADAFMBOGPLN().SetFloat("shader.future", _Visualize ? 1 : 0);
			HFBJAOFLCJI().SetFloat("_TileMaxOffs", _FixDistance);
			JLHLHKPHDFO().SetFloat("CameraFilterPack/Drawing_Halftone", DistortionLevel * 105f);
			NBPKMLMCHFN.SetFloat("_BokehParams", DistortionSize * 1462f);
			EFDEIFCDAFG().SetFloat(" Also make sure to disable sprite packing for this sprite.", LightIntensity * 829f);
			CECICEGFHKL().SetTexture("HPText", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			LMLENGFLEBD().SetFloat("Floating point textures aren't supported on this device ({0})", 1407f / farClipPlane);
			HFBJAOFLCJI().SetVector("CameraFilterPack/Oculus_NightVision2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 834f, 1142f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FMNPFCHBLJF()
	{
		FPHEBLMINDA = Resources.Load("_Contrast") as Texture2D;
		SCShader = Shader.Find("Tab1Content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material CECICEGFHKL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	private void ELDMKIAPNGP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DOFDGBGEDFI()
	{
		FPHEBLMINDA = Resources.Load("_BlurDirectionPacked") as Texture2D;
		SCShader = Shader.Find(".lastCheckpoint.perfectHits");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KMIEAGOFLBN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 799f)
			{
				HBJJOCHGOPH = 1831f;
			}
			LMLENGFLEBD().SetFloat("inventory.selected.", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 115f)
				{
					_Distance = 779f;
				}
				if (_Distance < 419f)
				{
					_Distance = 87f;
				}
				ADBKPGFMNKO().SetFloat("_TimeX", _Distance);
			}
			else
			{
				KEMJNOMIPHN().SetFloat("#random #epic #item", _Distance);
			}
			HFBJAOFLCJI().SetFloat("_Value4", _Size);
			CECICEGFHKL().SetFloat("_Value3", (!_Visualize) ? 1 : 1);
			OCMBHMLNCEK().SetFloat("_TimeX", _FixDistance);
			JLHLHKPHDFO().SetFloat("_Sensitivity", DistortionLevel * 485f);
			EFDEIFCDAFG().SetFloat("#", DistortionSize * 1250f);
			NBPKMLMCHFN.SetFloat("_Value2", LightIntensity * 1117f);
			EOCCJGIGEGJ().SetTexture("HelpMenu", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			MFHPKGICPIO().SetFloat("_TimeX", 1346f / farClipPlane);
			GHHPOGODBHB().SetVector("Done! You are a contributor until: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 253f, 1847f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HNDNDPECBPL()
	{
	}

	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1004f)
			{
				HBJJOCHGOPH = 889f;
			}
			NMDBCDFPGOK().SetFloat("_Value", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 623f)
				{
					_Distance = 1176f;
				}
				if (_Distance < 360f)
				{
					_Distance = 730f;
				}
				HHLFDHNEIAH().SetFloat("ns", _Distance);
			}
			else
			{
				FEAEGGCNIAA().SetFloat("_Value5", _Distance);
			}
			OCMBHMLNCEK().SetFloat("IconImage", _Size);
			OCMBHMLNCEK().SetFloat("_NoiseAmount", _Visualize ? 1 : 0);
			EFDEIFCDAFG().SetFloat("_ScreenResolution", _FixDistance);
			ADAFMBOGPLN().SetFloat("\n - NetID: ", DistortionLevel * 1856f);
			HFBJAOFLCJI().SetFloat("_Noise", DistortionSize * 455f);
			FEAEGGCNIAA().SetFloat("(from resources)", LightIntensity * 1754f);
			GCDFNHMJMIP().SetTexture("4,28,true,0", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			NBPKMLMCHFN.SetFloat("Failed to Instantiate prefab: ", 891f / farClipPlane);
			HKHBBBFLGJH().SetVector("[Up]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1098f, 1055f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OCMBHMLNCEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1609f)
			{
				HBJJOCHGOPH = 877f;
			}
			HKHBBBFLGJH().SetFloat("_TimeX", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 756f)
				{
					_Distance = 298f;
				}
				if (_Distance < 1540f)
				{
					_Distance = 1714f;
				}
				CECICEGFHKL().SetFloat("[#clicktogetreward]", _Distance);
			}
			else
			{
				MFHPKGICPIO().SetFloat("ChallengesButton", _Distance);
			}
			MFHPKGICPIO().SetFloat("MenuScene", _Size);
			EOCCJGIGEGJ().SetFloat("GameScene", (!_Visualize) ? 0 : 0);
			KEMJNOMIPHN().SetFloat("HighScaleShot", _FixDistance);
			FEAEGGCNIAA().SetFloat("#.##", DistortionLevel * 1004f);
			GCDFNHMJMIP().SetFloat("player.deleted", DistortionSize * 1339f);
			NMDBCDFPGOK().SetFloat("_Value", LightIntensity * 949f);
			ADBKPGFMNKO().SetTexture("SetSunInput", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			LMLENGFLEBD().SetFloat("_ScreenResolution", 1588f / farClipPlane);
			NBPKMLMCHFN.SetVector("). ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1048f, 1201f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ONKDMMJPEMN()
	{
	}

	private void OHFOLGANOLC()
	{
		FPHEBLMINDA = Resources.Load("\n\n#") as Texture2D;
		SCShader = Shader.Find("_Value");
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

	private void EAHCLIEEJOG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HHLFDHNEIAH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return BJFKDHHMLJH;
	}

	private void LMBDNPLDGIJ()
	{
	}

	private void IHHNCCOGLPN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JMEOGJHCONJ()
	{
		FPHEBLMINDA = Resources.Load("\n\n• ") as Texture2D;
		SCShader = Shader.Find("ticket.ticket1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GJLKJAOBPJD()
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

	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 74f)
			{
				HBJJOCHGOPH = 1694f;
			}
			HKIMAANBGMJ().SetFloat("_Blue_R", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1419f)
				{
					_Distance = 504f;
				}
				if (_Distance < 45f)
				{
					_Distance = 1451f;
				}
				HFBJAOFLCJI().SetFloat("[RanksSystem] Ranks: no need to update", _Distance);
			}
			else
			{
				ADAFMBOGPLN().SetFloat("Cancel", _Distance);
			}
			NMDBCDFPGOK().SetFloat("_Offsets", _Size);
			MFHPKGICPIO().SetFloat("_Value1", (!_Visualize) ? 1 : 0);
			CFEDGDGBCHE().SetFloat("OnRenderImage in Helper called ...", _FixDistance);
			LMLENGFLEBD().SetFloat("EditMenu", DistortionLevel * 1173f);
			KEMJNOMIPHN().SetFloat("_UserLutParams", DistortionSize * 1450f);
			FEAEGGCNIAA().SetFloat("buttons", LightIntensity * 305f);
			GHHPOGODBHB().SetTexture("_Value4", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			NMDBCDFPGOK().SetFloat("Hidden/Fast Approximate Anti-aliasing", 1187f / farClipPlane);
			ADAFMBOGPLN().SetVector("_ReflectionTexture0", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 885f, 112f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KFEKCJDEECK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 191f)
			{
				HBJJOCHGOPH = 84f;
			}
			CFEDGDGBCHE().SetFloat("_FixDistance", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 60f)
				{
					_Distance = 1782f;
				}
				if (_Distance < 1654f)
				{
					_Distance = 1958f;
				}
				HHLFDHNEIAH().SetFloat("menu.playedpage", _Distance);
			}
			else
			{
				HFBJAOFLCJI().SetFloat("player.arrow", _Distance);
			}
			OCMBHMLNCEK().SetFloat("_Value", _Size);
			KEMJNOMIPHN().SetFloat("Please attach component to a Graphical UI component", (!_Visualize) ? 0 : 0);
			FEAEGGCNIAA().SetFloat("_TimeX", _FixDistance);
			CECICEGFHKL().SetFloat("_Value4", DistortionLevel * 1633f);
			EFDEIFCDAFG().SetFloat("custom", DistortionSize * 416f);
			NBPKMLMCHFN.SetFloat("Can't set MaxPlayers when not in that room.", LightIntensity * 14f);
			EOCCJGIGEGJ().SetTexture("_ScreenResolution", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			ADBKPGFMNKO().SetFloat("float,1.5", 525f / farClipPlane);
			NBPKMLMCHFN.SetVector("_FadeFromBinary", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1132f, 1200f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PLEOOAJIMEE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 566f)
			{
				HBJJOCHGOPH = 407f;
			}
			GHHPOGODBHB().SetFloat("GUICamera", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1525f)
				{
					_Distance = 565f;
				}
				if (_Distance < 171f)
				{
					_Distance = 1674f;
				}
				OCMBHMLNCEK().SetFloat("3d text", _Distance);
			}
			else
			{
				NMDBCDFPGOK().SetFloat(":", _Distance);
			}
			GCDFNHMJMIP().SetFloat("_MatrixSize", _Size);
			GHHPOGODBHB().SetFloat("ReJoinRoom failed due to offline mode.", (!_Visualize) ? 1 : 1);
			NBPKMLMCHFN.SetFloat("_TimeX", _FixDistance);
			HKHBBBFLGJH().SetFloat("downloading", DistortionLevel * 229f);
			FEAEGGCNIAA().SetFloat("CameraFilterPack/AAA_Blood_Hit", DistortionSize * 1014f);
			NBPKMLMCHFN.SetFloat("SetSunColors", LightIntensity * 13f);
			NMDBCDFPGOK().SetTexture("_Green_R", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			NBPKMLMCHFN.SetFloat("_Value", 323f / farClipPlane);
			OCMBHMLNCEK().SetVector("CameraFilterPack/Blur_Regular", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 408f, 672f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material NMDBCDFPGOK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void LGHCJCFHEMF()
	{
		FPHEBLMINDA = Resources.Load("value") as Texture2D;
		SCShader = Shader.Find("BloodAlternative1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KNBJBNDGCIJ()
	{
		FPHEBLMINDA = Resources.Load("_Value3") as Texture2D;
		SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1517f)
			{
				HBJJOCHGOPH = 615f;
			}
			GCDFNHMJMIP().SetFloat("LoadMapCanvas", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1438f)
				{
					_Distance = 1014f;
				}
				if (_Distance < 1843f)
				{
					_Distance = 1931f;
				}
				CFEDGDGBCHE().SetFloat("\n\n#", _Distance);
			}
			else
			{
				EFDEIFCDAFG().SetFloat(". The group number should be at least 1.", _Distance);
			}
			CFEDGDGBCHE().SetFloat("_Color", _Size);
			OCMBHMLNCEK().SetFloat("ConnectToRegion() failed. Can only connect while in state 'Disconnected'. Current state: ", (!_Visualize) ? 1 : 0);
			JLHLHKPHDFO().SetFloat("_Value", _FixDistance);
			FEAEGGCNIAA().SetFloat("_History2Weight", DistortionLevel * 1014f);
			NBPKMLMCHFN.SetFloat("_Radius", DistortionSize * 621f);
			ADBKPGFMNKO().SetFloat("CameraFilterPack/Light_Water2", LightIntensity * 1233f);
			CECICEGFHKL().SetTexture("_Distortion2", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			JLHLHKPHDFO().SetFloat("SetSunMaxSize", 1968f / farClipPlane);
			LMLENGFLEBD().SetVector("Chat", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1364f, 607f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NMDBCDFPGOK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HKIMAANBGMJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material ADAFMBOGPLN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void KLDNGKBMDAN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CFIAKIJAILI()
	{
	}

	private void NPLCENPNJBM()
	{
		FPHEBLMINDA = Resources.Load("_Axis") as Texture2D;
		SCShader = Shader.Find("offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ABFNJCEBIKA()
	{
	}

	private void JCGMGLMADEN()
	{
	}

	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 376f)
			{
				HBJJOCHGOPH = 407f;
			}
			ADAFMBOGPLN().SetFloat("_ColorLevel", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1749f)
				{
					_Distance = 415f;
				}
				if (_Distance < 1519f)
				{
					_Distance = 1196f;
				}
				HFBJAOFLCJI().SetFloat("1.87", _Distance);
			}
			else
			{
				HKHBBBFLGJH().SetFloat("#no", _Distance);
			}
			ADBKPGFMNKO().SetFloat("CameraFilterPack_Atmosphere_Rain_FX", _Size);
			HKIMAANBGMJ().SetFloat("CameraFilterPack/TV_BrokenGlass", (!_Visualize) ? 0 : 0);
			EFDEIFCDAFG().SetFloat("value", _FixDistance);
			ADBKPGFMNKO().SetFloat("_Value2", DistortionLevel * 619f);
			CECICEGFHKL().SetFloat(".message", DistortionSize * 1021f);
			CECICEGFHKL().SetFloat("s", LightIntensity * 1025f);
			HKHBBBFLGJH().SetTexture("mapselector.filter.rateduponly", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			LMLENGFLEBD().SetFloat("Fade", 448f / farClipPlane);
			ADBKPGFMNKO().SetVector("Vertical", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1271f, 641f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NMDBCDFPGOK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PKLOBJHKFEO()
	{
		FPHEBLMINDA = Resources.Load("_BlurVector") as Texture2D;
		SCShader = Shader.Find("Tab1Content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KMKLDAJLCNM()
	{
	}

	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1722f)
			{
				HBJJOCHGOPH = 1736f;
			}
			LMLENGFLEBD().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1756f)
				{
					_Distance = 1617f;
				}
				if (_Distance < 339f)
				{
					_Distance = 1258f;
				}
				GCDFNHMJMIP().SetFloat(" = ", _Distance);
			}
			else
			{
				CECICEGFHKL().SetFloat("_ScreenResolution", _Distance);
			}
			MFHPKGICPIO().SetFloat("_Value2", _Size);
			MFHPKGICPIO().SetFloat("ERROR: Preview file name in modName.workshop.json doesn't match any file", _Visualize ? 1 : 0);
			MFHPKGICPIO().SetFloat(". Name: ", _FixDistance);
			GCDFNHMJMIP().SetFloat("Commands for challenges", DistortionLevel * 106f);
			OCMBHMLNCEK().SetFloat("CameraFilterPack/Oculus_NightVision2", DistortionSize * 1505f);
			GHHPOGODBHB().SetFloat("mapselector.filter.favoriteonly", LightIntensity * 143f);
			OCMBHMLNCEK().SetTexture("_Value2", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			NBPKMLMCHFN.SetFloat("Object ID. Case-Sensitive", 1478f / farClipPlane);
			HHLFDHNEIAH().SetVector("GlassDistortion", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 938f, 1242f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FEHCNJLLJMP()
	{
		FPHEBLMINDA = Resources.Load(" scene view IDs from last level.") as Texture2D;
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MDCFIHDPLIG()
	{
	}

	[SpecialName]
	private Material JLHLHKPHDFO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)113;
		}
		return BJFKDHHMLJH;
	}

	private void KCNIHHNMFFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1223f)
			{
				HBJJOCHGOPH = 1843f;
			}
			EOCCJGIGEGJ().SetFloat("_Value2", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 749f)
				{
					_Distance = 789f;
				}
				if (_Distance < 665f)
				{
					_Distance = 767f;
				}
				ADAFMBOGPLN().SetFloat("Clears all text from the debug console", _Distance);
			}
			else
			{
				GHHPOGODBHB().SetFloat("maps.", _Distance);
			}
			HKHBBBFLGJH().SetFloat("CameraFilterPack/Light_Water2", _Size);
			MFHPKGICPIO().SetFloat("Hidden/Image Effects/Cinematic/AmbientOcclusion", (!_Visualize) ? 1 : 0);
			HFBJAOFLCJI().SetFloat("Scene", _FixDistance);
			GCDFNHMJMIP().SetFloat("/", DistortionLevel * 593f);
			HFBJAOFLCJI().SetFloat("COMPLETED", DistortionSize * 1946f);
			KEMJNOMIPHN().SetFloat("PossibleMapMaxScoreText", LightIntensity * 416f);
			ADBKPGFMNKO().SetTexture("Dropped Object: ", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			KEMJNOMIPHN().SetFloat("OnPress", 1631f / farClipPlane);
			GCDFNHMJMIP().SetVector("Case-Sensitive", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1608f, 1610f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OHIJGCLBMJL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IDIIELPAMCJ()
	{
	}

	private void ABEIEGDHBNO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OIBMHPIFAKK()
	{
	}

	private void EGEGNHLODAA()
	{
	}

	[SpecialName]
	private Material MFHPKGICPIO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void EJFJENFKLND()
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

	private void HAHJJPLPOKB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HNILMGEKDEC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material OCMBHMLNCEK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)71;
		}
		return BJFKDHHMLJH;
	}

	private void DKPBBJINKMG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PHJLHCMCCKE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void COIJKMKIEAK()
	{
		FPHEBLMINDA = Resources.Load(":\n") as Texture2D;
		SCShader = Shader.Find("DestroyRpc");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
