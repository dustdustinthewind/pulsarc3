// CameraFilterPack_3D_Myst
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/3D/Myst")]
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
		FPHEBLMINDA = Resources.Load(": ") as Texture2D;
		SCShader = Shader.Find("challenges.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KOJKBFDNGDK()
	{
		FPHEBLMINDA = Resources.Load("_DistortionLevel") as Texture2D;
		SCShader = Shader.Find("/");
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
			HKHBBBFLGJH().SetFloat("_ScreenResolution", HBJJOCHGOPH);
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
				FEAEGGCNIAA().SetFloat("SpawnObj", _Distance);
			}
			else
			{
				KEMJNOMIPHN().SetFloat("Reset XP", _Distance);
			}
			NBPKMLMCHFN.SetFloat("_FarCamera", _Size);
			JLHLHKPHDFO().SetFloat("menu.enableselectormusic", (!_Visualize) ? 0 : 0);
			HKIMAANBGMJ().SetFloat("levelcompleted", _FixDistance);
			ADAFMBOGPLN().SetFloat(". Going to authenticate anyways.", DistortionLevel * 1426f);
			HHLFDHNEIAH().SetFloat("\n", DistortionSize * 319f);
			NMDBCDFPGOK().SetFloat("Y", LightIntensity * 130f);
			OCMBHMLNCEK().SetTexture("Hex value #RRGGBB", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			ADBKPGFMNKO().SetFloat("x", 679f / farClipPlane);
			KEMJNOMIPHN().SetVector("[UI] ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1437f, 280f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKHBBBFLGJH());
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
			ADBKPGFMNKO().SetFloat("/music", HBJJOCHGOPH);
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
				HHLFDHNEIAH().SetFloat("BloodAlternative3", _Distance);
			}
			else
			{
				HKHBBBFLGJH().SetFloat("_ScreenResolution", _Distance);
			}
			OCMBHMLNCEK().SetFloat("GraphicsQualitySlider", _Size);
			CECICEGFHKL().SetFloat("_TimeX", (!_Visualize) ? 0 : 0);
			GHHPOGODBHB().SetFloat(":", _FixDistance);
			LMLENGFLEBD().SetFloat("input", DistortionLevel * 1004f);
			NBPKMLMCHFN.SetFloat("bad", DistortionSize * 1218f);
			ADAFMBOGPLN().SetFloat("_MainTex2", LightIntensity * 1123f);
			HFBJAOFLCJI().SetTexture(",", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			ADAFMBOGPLN().SetFloat("Tab2Content", 1755f / farClipPlane);
			FEAEGGCNIAA().SetVector("x", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1082f, 937f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
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
		FPHEBLMINDA = Resources.Load("CameraFilterPack/TV_ARCADE_2") as Texture2D;
		SCShader = Shader.Find("_Value3");
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
			ADBKPGFMNKO().SetFloat("In Network lobby", HBJJOCHGOPH);
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
				GCDFNHMJMIP().SetFloat("skin.hit_wrong", _Distance);
			}
			else
			{
				KEMJNOMIPHN().SetFloat("GameMessagesDurationSlider", _Distance);
			}
			ADBKPGFMNKO().SetFloat("ResetButton", _Size);
			CECICEGFHKL().SetFloat("/Saved Games/", (!_Visualize) ? 1 : 0);
			CFEDGDGBCHE().SetFloat("_Value3", _FixDistance);
			ADBKPGFMNKO().SetFloat("maps.", DistortionLevel * 723f);
			HKIMAANBGMJ().SetFloat("mapselector.filter.favoriteonly", DistortionSize * 110f);
			HHLFDHNEIAH().SetFloat("_NoiseTex", LightIntensity * 1332f);
			KEMJNOMIPHN().SetTexture("EventTimeInputField", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HKHBBBFLGJH().SetFloat("] as we haven't received a full packet for delta compression yet. This is OK if it happens for the first few frames after joining a game.", 1789f / farClipPlane);
			GCDFNHMJMIP().SetVector("player.quantum", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 741f, 1412f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JLHLHKPHDFO());
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
		SCShader = Shader.Find("[ERROR KEY {0}]");
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
				NMDBCDFPGOK().SetFloat("#", _Distance);
			}
			else
			{
				CECICEGFHKL().SetFloat("#FFDA44", _Distance);
			}
			CFEDGDGBCHE().SetFloat("_Value", _Size);
			ADBKPGFMNKO().SetFloat("[NetworkManager] Joined room with ", (!_Visualize) ? 1 : 0);
			NBPKMLMCHFN.SetFloat("_FarCamera", _FixDistance);
			JLHLHKPHDFO().SetFloat("_TimeX", DistortionLevel * 177f);
			JLHLHKPHDFO().SetFloat("maps.", DistortionSize * 53f);
			HFBJAOFLCJI().SetFloat("_ScreenResolution", LightIntensity * 694f);
			OCMBHMLNCEK().SetTexture("_DiffuseColor", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HKIMAANBGMJ().SetFloat("_MainTex2", 796f / farClipPlane);
			NBPKMLMCHFN.SetVector("settings.fps", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 959f, 762f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
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
			KEMJNOMIPHN().SetFloat("_OcclusionTexture", HBJJOCHGOPH);
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
				KEMJNOMIPHN().SetFloat(" isOwnerActive: ", _Distance);
			}
			else
			{
				GCDFNHMJMIP().SetFloat("_Value4", _Distance);
			}
			EOCCJGIGEGJ().SetFloat("FPSToggle", _Size);
			LMLENGFLEBD().SetFloat("ShowTitle", (!_Visualize) ? 1 : 0);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Drawing_Curve", _FixDistance);
			JLHLHKPHDFO().SetFloat("Selection Box", DistortionLevel * 11f);
			NBPKMLMCHFN.SetFloat("/", DistortionSize * 735f);
			HHLFDHNEIAH().SetFloat("_Axis", LightIntensity * 1198f);
			HKIMAANBGMJ().SetTexture("note.1", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			EOCCJGIGEGJ().SetFloat("_Value2", 1133f / farClipPlane);
			LMLENGFLEBD().SetVector("_Near", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1092f, 425f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GHHPOGODBHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DBLILJGKGHJ()
	{
		FPHEBLMINDA = Resources.Load("points:") as Texture2D;
		SCShader = Shader.Find("UI Extensions/SoftMaskShaderText");
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
		SCShader = Shader.Find("VIGNETTE_CLASSIC");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NEFHGMNAPEP()
	{
		FPHEBLMINDA = Resources.Load("0,2,true,0") as Texture2D;
		SCShader = Shader.Find("Joystick1Button8");
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
			EOCCJGIGEGJ().SetFloat("Tab2Content", HBJJOCHGOPH);
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
				CFEDGDGBCHE().SetFloat("w", _Distance);
			}
			else
			{
				HKIMAANBGMJ().SetFloat("player.mysteryitem", _Distance);
			}
			ADAFMBOGPLN().SetFloat("Tab2Content", _Size);
			HFBJAOFLCJI().SetFloat("_TimeX", (!_Visualize) ? 1 : 1);
			JLHLHKPHDFO().SetFloat("SetPlayerDistance", _FixDistance);
			EFDEIFCDAFG().SetFloat("KickThePlayer", DistortionLevel * 615f);
			HKHBBBFLGJH().SetFloat("ResourceIDInputField", DistortionSize * 1246f);
			CECICEGFHKL().SetFloat("_TimeX", LightIntensity * 1673f);
			GCDFNHMJMIP().SetTexture("_Value", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			GHHPOGODBHB().SetFloat("CameraFilterPack/Alien_Vision", 1139f / farClipPlane);
			JLHLHKPHDFO().SetVector("_Parameter", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1703f, 53f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GHHPOGODBHB());
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
			LMLENGFLEBD().SetFloat("InputField", HBJJOCHGOPH);
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
				FEAEGGCNIAA().SetFloat("CameraFilterPack/Blend2Camera_LinearBurn", _Distance);
			}
			else
			{
				MFHPKGICPIO().SetFloat("CameraFilterPack/Real_VHS", _Distance);
			}
			HKHBBBFLGJH().SetFloat("/icon", _Size);
			NBPKMLMCHFN.SetFloat("_Value", (!_Visualize) ? 0 : 0);
			LMLENGFLEBD().SetFloat("_Value5", _FixDistance);
			CECICEGFHKL().SetFloat("[PlayerController] ", DistortionLevel * 928f);
			GHHPOGODBHB().SetFloat("LastNewsButton", DistortionSize * 1001f);
			HHLFDHNEIAH().SetFloat("resource id", LightIntensity * 797f);
			HKHBBBFLGJH().SetTexture("_Value2", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			GCDFNHMJMIP().SetFloat("CameraMovementSlider", 1349f / farClipPlane);
			EFDEIFCDAFG().SetVector("System.Int64", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1981f, 1584f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
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
		SCShader = Shader.Find("PossibleMapMaxScoreText");
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
			KEMJNOMIPHN().SetFloat("[#clicktoacceptchallenge]", HBJJOCHGOPH);
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
				LMLENGFLEBD().SetFloat("Scale environment object by the values", _Distance);
			}
			else
			{
				ADBKPGFMNKO().SetFloat("\n", _Distance);
			}
			HKHBBBFLGJH().SetFloat("[PlayerController] ", _Size);
			FEAEGGCNIAA().SetFloat("_ColorBuffer", _Visualize ? 1 : 0);
			NBPKMLMCHFN.SetFloat("PerfectHitsScoreText", _FixDistance);
			EFDEIFCDAFG().SetFloat("_MainTex2", DistortionLevel * 898f);
			EOCCJGIGEGJ().SetFloat("$ {0}", DistortionSize * 1458f);
			HHLFDHNEIAH().SetFloat("Ev OwnershipRequest ", LightIntensity * 1723f);
			GHHPOGODBHB().SetTexture("SetLives", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			NMDBCDFPGOK().SetFloat("CameraFilterPack/Blend2Camera_VividLight", 769f / farClipPlane);
			KEMJNOMIPHN().SetVector("AskForPickupItemSpawnTimes", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 893f, 1989f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
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
			MFHPKGICPIO().SetFloat("CameraFilterPack/3D_Binary", HBJJOCHGOPH);
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
				MFHPKGICPIO().SetFloat("ConnectUsingSettings() failed. Can only connect while in state 'Disconnected'. Current state: ", _Distance);
			}
			else
			{
				FEAEGGCNIAA().SetFloat("_ScreenResolution", _Distance);
			}
			CFEDGDGBCHE().SetFloat("Bad parameters for setstring! Use <key> <value>", _Size);
			ADAFMBOGPLN().SetFloat("[ResourcesManager] Load text error: not found", (!_Visualize) ? 0 : 0);
			HKIMAANBGMJ().SetFloat("_GrainOffsetScale", _FixDistance);
			ADBKPGFMNKO().SetFloat("file://", DistortionLevel * 1048f);
			EOCCJGIGEGJ().SetFloat("Set satellite emission (glow)", DistortionSize * 1915f);
			HKIMAANBGMJ().SetFloat("event", LightIntensity * 1437f);
			CFEDGDGBCHE().SetTexture("A", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			KEMJNOMIPHN().SetFloat("offsets", 1718f / farClipPlane);
			JLHLHKPHDFO().SetVector("workshop.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 997f, 387f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HPFIHLMKIPF()
	{
		FPHEBLMINDA = Resources.Load(".played") as Texture2D;
		SCShader = Shader.Find(".completedCount");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JFJLGJEPEAA()
	{
		FPHEBLMINDA = Resources.Load("ACCEPT") as Texture2D;
		SCShader = Shader.Find("en");
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
		FPHEBLMINDA = Resources.Load("_History4Weight") as Texture2D;
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
			KEMJNOMIPHN().SetFloat("<b>(╯°□°）╯︵ ┻━┻</b>", HBJJOCHGOPH);
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
				EFDEIFCDAFG().SetFloat("colorC", _Distance);
			}
			else
			{
				NBPKMLMCHFN.SetFloat("Result for ", _Distance);
			}
			EOCCJGIGEGJ().SetFloat("_ScreenSize", _Size);
			ADAFMBOGPLN().SetFloat("00", (!_Visualize) ? 1 : 0);
			HKIMAANBGMJ().SetFloat(",", _FixDistance);
			GCDFNHMJMIP().SetFloat("_EmissionColor", DistortionLevel * 259f);
			GHHPOGODBHB().SetFloat("_Value4", DistortionSize * 9f);
			LMLENGFLEBD().SetFloat("[NetworkManager] Exited", LightIntensity * 1635f);
			EFDEIFCDAFG().SetTexture("USE_PREDICATION", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HHLFDHNEIAH().SetFloat("_TimeX", 226f / farClipPlane);
			OCMBHMLNCEK().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 680f, 1854f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FDNONDCGGCG()
	{
		FPHEBLMINDA = Resources.Load("float,2") as Texture2D;
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
			EOCCJGIGEGJ().SetFloat("Tab1Content", HBJJOCHGOPH);
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
				OCMBHMLNCEK().SetFloat("error", _Distance);
			}
			HKHBBBFLGJH().SetFloat("x", _Size);
			NMDBCDFPGOK().SetFloat("CompletedLevel", (!_Visualize) ? 1 : 1);
			FEAEGGCNIAA().SetFloat("PLEASE WAIT", _FixDistance);
			KEMJNOMIPHN().SetFloat("KickThePlayer", DistortionLevel * 589f);
			GCDFNHMJMIP().SetFloat("You need to have a child LayoutGroup content set for the list: ", DistortionSize * 294f);
			FEAEGGCNIAA().SetFloat("OnJoinedLobby(). This client is connected and does get a room-list, which gets stored as PhotonNetwork.GetRoomList(). This script now calls: PhotonNetwork.JoinRandomRoom();", LightIntensity * 1242f);
			FEAEGGCNIAA().SetTexture("_MainTex2", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HKIMAANBGMJ().SetFloat("_Value5", 1961f / farClipPlane);
			MFHPKGICPIO().SetVector("'{0}'{1}{2}", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 262f, 98f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
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
			CFEDGDGBCHE().SetFloat("itemdefid[0]", HBJJOCHGOPH);
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
				OCMBHMLNCEK().SetFloat("_Value", _Distance);
			}
			else
			{
				HHLFDHNEIAH().SetFloat("Gameplay/Base", _Distance);
			}
			MFHPKGICPIO().SetFloat("_Value", _Size);
			OCMBHMLNCEK().SetFloat("_NeighbourMaxTex", (!_Visualize) ? 0 : 0);
			HKIMAANBGMJ().SetFloat("settings.fps", _FixDistance);
			GCDFNHMJMIP().SetFloat("settings.showHP", DistortionLevel * 454f);
			HFBJAOFLCJI().SetFloat("[MapsData] Preloading ", DistortionSize * 216f);
			JLHLHKPHDFO().SetFloat("_ScreenResolution", LightIntensity * 359f);
			EFDEIFCDAFG().SetTexture(": ", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			GHHPOGODBHB().SetFloat("StartButton", 1444f / farClipPlane);
			FEAEGGCNIAA().SetVector("restrictions\n\n#until: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 319f, 1192f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
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
			HFBJAOFLCJI().SetFloat("System.Int64", HBJJOCHGOPH);
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
				HKHBBBFLGJH().SetFloat("HightScoreMaxPointsText", _Distance);
			}
			else
			{
				CECICEGFHKL().SetFloat("_TimeX", _Distance);
			}
			ADBKPGFMNKO().SetFloat("[ResourcesManager] Unloading data resources", _Size);
			ADBKPGFMNKO().SetFloat("Delete events", (!_Visualize) ? 0 : 0);
			ADBKPGFMNKO().SetFloat("'{0}' \t{1}ms \t{2}", _FixDistance);
			OCMBHMLNCEK().SetFloat("_ScreenResolution", DistortionLevel * 1414f);
			CFEDGDGBCHE().SetFloat("_Visualize", DistortionSize * 138f);
			EOCCJGIGEGJ().SetFloat(".lastCheckpoint.playerdistance", LightIntensity * 12f);
			CFEDGDGBCHE().SetTexture("Screenshots only supported in PlayMode", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			NMDBCDFPGOK().SetFloat("AddEnvironmentObject", 1700f / farClipPlane);
			EOCCJGIGEGJ().SetVector("_DiffuseColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1638f, 1467f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
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
		FPHEBLMINDA = Resources.Load("_Threshold") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Blend2Camera_Overlay");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EDPDMBFLHLP()
	{
		FPHEBLMINDA = Resources.Load("[PlayerBase] Checkpoint error: ") as Texture2D;
		SCShader = Shader.Find("Deleted data");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NNCCPEBIAKH()
	{
		FPHEBLMINDA = Resources.Load("EnvironmentSlider") as Texture2D;
		SCShader = Shader.Find("MenuScene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HPFOFGJPNCI()
	{
		FPHEBLMINDA = Resources.Load("BadgeText") as Texture2D;
		SCShader = Shader.Find("SettingsCanvas");
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
		FPHEBLMINDA = Resources.Load(". The RPC has been ignored.") as Texture2D;
		SCShader = Shader.Find("ok");
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
		FPHEBLMINDA = Resources.Load("HiddenToggle") as Texture2D;
		SCShader = Shader.Find("keys");
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
		FPHEBLMINDA = Resources.Load("couldn't be found!") as Texture2D;
		SCShader = Shader.Find("_Speed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OKLAJINHPAN()
	{
		FPHEBLMINDA = Resources.Load("menu.playedsolo") as Texture2D;
		SCShader = Shader.Find("float,0");
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
		SCShader = Shader.Find(". Check if the server is available.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AIBNKIDADPI()
	{
		FPHEBLMINDA = Resources.Load("Joined room ") as Texture2D;
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BOPKKCAFODF()
	{
		FPHEBLMINDA = Resources.Load("Joystick1Button8") as Texture2D;
		SCShader = Shader.Find("_TimeX");
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
			MFHPKGICPIO().SetFloat("_TimeX", HBJJOCHGOPH);
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
				ADBKPGFMNKO().SetFloat("Updated!", _Distance);
			}
			else
			{
				HFBJAOFLCJI().SetFloat("ConfigVersionSlider", _Distance);
			}
			EOCCJGIGEGJ().SetFloat("[Singleton] Using instance of '", _Size);
			FEAEGGCNIAA().SetFloat("_TimeX", (!_Visualize) ? 1 : 1);
			CFEDGDGBCHE().SetFloat("checkpoint", _FixDistance);
			HHLFDHNEIAH().SetFloat("<start_index> <end_index>", DistortionLevel * 1021f);
			CFEDGDGBCHE().SetFloat("_Scale", DistortionSize * 1017f);
			EOCCJGIGEGJ().SetFloat("_MainTex2", LightIntensity * 1323f);
			ADBKPGFMNKO().SetTexture("_TimeX", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FEAEGGCNIAA().SetFloat("CameraFilterPack/FX_EarthQuake", 1114f / farClipPlane);
			CFEDGDGBCHE().SetVector("event", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1976f, 1021f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PAKPHKPDKGE()
	{
		FPHEBLMINDA = Resources.Load("Show image from resources by id at the center of the screen at foreground or background") as Texture2D;
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
		FPHEBLMINDA = Resources.Load("Joystick") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Drawing_Manga2");
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
			HKIMAANBGMJ().SetFloat("Save Game", HBJJOCHGOPH);
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
				NBPKMLMCHFN.SetFloat("mapselector.filter.rateduponly", _Distance);
			}
			else
			{
				OCMBHMLNCEK().SetFloat("_Value", _Distance);
			}
			CECICEGFHKL().SetFloat("EventData0DropDownList", _Size);
			GHHPOGODBHB().SetFloat("SetPosition", (!_Visualize) ? 1 : 1);
			LMLENGFLEBD().SetFloat("_CurveTex", _FixDistance);
			JLHLHKPHDFO().SetFloat("OnStatusChanged: {0} current State: {1}", DistortionLevel * 1825f);
			KEMJNOMIPHN().SetFloat("_Value", DistortionSize * 1790f);
			EFDEIFCDAFG().SetFloat("#FFDA44", LightIntensity * 1427f);
			ADBKPGFMNKO().SetTexture("\" error: ", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			ADBKPGFMNKO().SetFloat("GLITCH", 423f / farClipPlane);
			ADBKPGFMNKO().SetVector("AddEnvironmentObject", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 870f, 155f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHLFDHNEIAH());
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
			LMLENGFLEBD().SetFloat("_Value4", HBJJOCHGOPH);
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
				OCMBHMLNCEK().SetFloat("Error0", _Distance);
			}
			else
			{
				GHHPOGODBHB().SetFloat("BloomShaderValueSlider", _Distance);
			}
			ADAFMBOGPLN().SetFloat("Joystick", _Size);
			EOCCJGIGEGJ().SetFloat("shader.invert", _Visualize ? 1 : 0);
			CFEDGDGBCHE().SetFloat("_VelocityScale", _FixDistance);
			NMDBCDFPGOK().SetFloat("_SmoothEnd", DistortionLevel * 105f);
			HFBJAOFLCJI().SetFloat("_SpawnHeuristic", DistortionSize * 1462f);
			HKIMAANBGMJ().SetFloat("Populate Mesh Data", LightIntensity * 829f);
			KEMJNOMIPHN().SetTexture("settings.showHP", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FEAEGGCNIAA().SetFloat("Image effects aren't supported on this device ({0})", 1407f / farClipPlane);
			NBPKMLMCHFN.SetVector("_Linecount", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 834f, 1142f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FMNPFCHBLJF()
	{
		FPHEBLMINDA = Resources.Load("_Saturation") as Texture2D;
		SCShader = Shader.Find("Tab2Content");
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
		FPHEBLMINDA = Resources.Load("_PrevViewProj") as Texture2D;
		SCShader = Shader.Find(".lastCheckpoint.checkpointsUsed");
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
			FEAEGGCNIAA().SetFloat("inventory.selected.", HBJJOCHGOPH);
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
				EOCCJGIGEGJ().SetFloat("CameraFilterPack/OldFilm_Cutting1", _Distance);
			}
			else
			{
				HHLFDHNEIAH().SetFloat("randomdrop", _Distance);
			}
			KEMJNOMIPHN().SetFloat("_Value3", _Size);
			CECICEGFHKL().SetFloat("_Value3", (!_Visualize) ? 1 : 1);
			HHLFDHNEIAH().SetFloat("_TimeX", _FixDistance);
			EOCCJGIGEGJ().SetFloat("_ArScale", DistortionLevel * 485f);
			KEMJNOMIPHN().SetFloat("[LocalizationService] Loading file: ", DistortionSize * 1250f);
			CECICEGFHKL().SetFloat("_Value2", LightIntensity * 1117f);
			EOCCJGIGEGJ().SetTexture("  |  ", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HKHBBBFLGJH().SetFloat("_TimeX", 1346f / farClipPlane);
			NMDBCDFPGOK().SetVector("bad", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 253f, 1847f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
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
			FEAEGGCNIAA().SetFloat("_TimeX", HBJJOCHGOPH);
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
				JLHLHKPHDFO().SetFloat("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.", _Distance);
			}
			else
			{
				JLHLHKPHDFO().SetFloat("_Value5", _Distance);
			}
			HKHBBBFLGJH().SetFloat("inventory.selected.", _Size);
			CFEDGDGBCHE().SetFloat("_NoisePerChannel", _Visualize ? 1 : 0);
			MFHPKGICPIO().SetFloat("ZoomSpeed", _FixDistance);
			FEAEGGCNIAA().SetFloat("\n - NetID: ", DistortionLevel * 1856f);
			ADAFMBOGPLN().SetFloat("_Glitch", DistortionSize * 455f);
			EOCCJGIGEGJ().SetFloat("resource id", LightIntensity * 1754f);
			ADBKPGFMNKO().SetTexture("distance", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			NBPKMLMCHFN.SetFloat("AllocateViewID() failed. User {0} is out of subIds, as all viewIDs are used.", 891f / farClipPlane);
			CFEDGDGBCHE().SetVector("[Down]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1098f, 1055f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
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
			HKHBBBFLGJH().SetFloat("_MainTex2", HBJJOCHGOPH);
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
				ADAFMBOGPLN().SetFloat("BlockCount", _Distance);
			}
			else
			{
				FEAEGGCNIAA().SetFloat("ChallengesButton", _Distance);
			}
			EFDEIFCDAFG().SetFloat("/", _Size);
			HHLFDHNEIAH().SetFloat("GameScene", (!_Visualize) ? 0 : 0);
			EFDEIFCDAFG().SetFloat(").png", _FixDistance);
			NBPKMLMCHFN.SetFloat("OxOD.lastPath", DistortionLevel * 1004f);
			ADAFMBOGPLN().SetFloat("player.deleted", DistortionSize * 1339f);
			HHLFDHNEIAH().SetFloat("_TimeX", LightIntensity * 949f);
			CECICEGFHKL().SetTexture("SetSunInput", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HFBJAOFLCJI().SetFloat("_Value4", 1588f / farClipPlane);
			CFEDGDGBCHE().SetVector("). ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1048f, 1201f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NMDBCDFPGOK());
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
		SCShader = Shader.Find("_TimeX");
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
		FPHEBLMINDA = Resources.Load(":\n") as Texture2D;
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
			GHHPOGODBHB().SetFloat("_Green_B", HBJJOCHGOPH);
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
				EFDEIFCDAFG().SetFloat("[RanksSystem] Ranks updated. Next update: ", _Distance);
			}
			else
			{
				HKIMAANBGMJ().SetFloat("Vertical", _Distance);
			}
			LMLENGFLEBD().SetFloat("_BlurCoe", _Size);
			NMDBCDFPGOK().SetFloat("_PColor", (!_Visualize) ? 1 : 0);
			GHHPOGODBHB().SetFloat(" on effect ", _FixDistance);
			MFHPKGICPIO().SetFloat("EditMenu", DistortionLevel * 1173f);
			GCDFNHMJMIP().SetFloat("_InternalLutParams", DistortionSize * 1450f);
			OCMBHMLNCEK().SetFloat(" (inactive)", LightIntensity * 305f);
			CECICEGFHKL().SetTexture("_Value3", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			CECICEGFHKL().SetFloat("_SampleCount", 1187f / farClipPlane);
			EFDEIFCDAFG().SetVector("_NormalAndRoughnessTexture", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 885f, 112f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKIMAANBGMJ());
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
			EFDEIFCDAFG().SetFloat("_FixDistance", HBJJOCHGOPH);
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
				NBPKMLMCHFN.SetFloat("menu.playedpage", _Distance);
			}
			else
			{
				MFHPKGICPIO().SetFloat("player.arrow", _Distance);
			}
			HKHBBBFLGJH().SetFloat("_TimeX", _Size);
			FEAEGGCNIAA().SetFloat("Default UI Material", (!_Visualize) ? 0 : 0);
			LMLENGFLEBD().SetFloat("CameraFilterPack/Drawing_CellShading", _FixDistance);
			HKIMAANBGMJ().SetFloat("_Value4", DistortionLevel * 1633f);
			JLHLHKPHDFO().SetFloat("UI", DistortionSize * 416f);
			EOCCJGIGEGJ().SetFloat("Can't set open when not in that room.", LightIntensity * 14f);
			ADAFMBOGPLN().SetTexture("_Smooth", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HFBJAOFLCJI().SetFloat("float,1.5", 525f / farClipPlane);
			ADBKPGFMNKO().SetVector("_FadeFromBinary", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1132f, 1200f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKHBBBFLGJH());
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
			NBPKMLMCHFN.SetFloat("Selection Box", HBJJOCHGOPH);
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
				LMLENGFLEBD().SetFloat("fetch", _Distance);
			}
			else
			{
				CFEDGDGBCHE().SetFloat("End index must in an integer.", _Distance);
			}
			CFEDGDGBCHE().SetFloat("_MatrixSize", _Size);
			EFDEIFCDAFG().SetFloat("offline room", (!_Visualize) ? 1 : 1);
			CFEDGDGBCHE().SetFloat("CameraFilterPack/Light_Water2", _FixDistance);
			CFEDGDGBCHE().SetFloat("workshop.", DistortionLevel * 229f);
			FEAEGGCNIAA().SetFloat("CameraFilterPack/AAA_Blood_Hit", DistortionSize * 1014f);
			MFHPKGICPIO().SetFloat("SetPosition", LightIntensity * 13f);
			CFEDGDGBCHE().SetTexture("_Red_G", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			EOCCJGIGEGJ().SetFloat("CameraFilterPack/Gradients_NeonGradient", 323f / farClipPlane);
			JLHLHKPHDFO().SetVector("CameraFilterPack/Blur_Regular", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 408f, 672f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GHHPOGODBHB());
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
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KNBJBNDGCIJ()
	{
		FPHEBLMINDA = Resources.Load("_Value2") as Texture2D;
		SCShader = Shader.Find("_PColor2");
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
			HHLFDHNEIAH().SetFloat("Editor/", HBJJOCHGOPH);
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
				EOCCJGIGEGJ().SetFloat("\n\n#", _Distance);
			}
			else
			{
				FEAEGGCNIAA().SetFloat("Error: PhotonNetwork.SetInterestGroups was called with an illegal group number: ", _Distance);
			}
			GCDFNHMJMIP().SetFloat("BlockCount", _Size);
			ADAFMBOGPLN().SetFloat("ConnectToBestCloudServer() failed. Can only connect while in state 'Disconnected'. Current state: ", (!_Visualize) ? 1 : 0);
			KEMJNOMIPHN().SetFloat("_TimeX", _FixDistance);
			NBPKMLMCHFN.SetFloat("_History4ChromaTex", DistortionLevel * 1014f);
			KEMJNOMIPHN().SetFloat("_TimeX", DistortionSize * 621f);
			HFBJAOFLCJI().SetFloat("_ScreenResolution", LightIntensity * 1233f);
			NBPKMLMCHFN.SetTexture("_Distortion", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			OCMBHMLNCEK().SetFloat("SetSunColors", 1968f / farClipPlane);
			HHLFDHNEIAH().SetVector("ChatInput", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1364f, 607f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
		FPHEBLMINDA = Resources.Load("_Intensity") as Texture2D;
		SCShader = Shader.Find("_Threshhold");
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
			HHLFDHNEIAH().SetFloat("_EdgeSize", HBJJOCHGOPH);
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
				LMLENGFLEBD().SetFloat(" connected: ", _Distance);
			}
			else
			{
				NBPKMLMCHFN.SetFloat("#close", _Distance);
			}
			JLHLHKPHDFO().SetFloat("CameraFilterPack_Atmosphere_Rain_FX", _Size);
			JLHLHKPHDFO().SetFloat("CameraFilterPack_TV_BrokenGlass1", (!_Visualize) ? 0 : 0);
			MFHPKGICPIO().SetFloat("value", _FixDistance);
			KEMJNOMIPHN().SetFloat("_Value", DistortionLevel * 619f);
			MFHPKGICPIO().SetFloat("MenuScene", DistortionSize * 1021f);
			HFBJAOFLCJI().SetFloat("s", LightIntensity * 1025f);
			ADBKPGFMNKO().SetTexture("Return: ", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			NBPKMLMCHFN.SetFloat("UseFinalGlassColor", 448f / farClipPlane);
			HHLFDHNEIAH().SetVector("Horizontal", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1271f, 641f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PKLOBJHKFEO()
	{
		FPHEBLMINDA = Resources.Load("_BlurVector") as Texture2D;
		SCShader = Shader.Find("maps.");
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
			HKHBBBFLGJH().SetFloat("_ScreenResolution", HBJJOCHGOPH);
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
				EOCCJGIGEGJ().SetFloat("#", _Distance);
			}
			else
			{
				HKHBBBFLGJH().SetFloat("_Value4", _Distance);
			}
			CFEDGDGBCHE().SetFloat("_Value", _Size);
			GHHPOGODBHB().SetFloat("ERROR: mod directory not found!", _Visualize ? 1 : 0);
			HHLFDHNEIAH().SetFloat("Scenes List:", _FixDistance);
			LMLENGFLEBD().SetFloat("#challengecomplete", DistortionLevel * 106f);
			MFHPKGICPIO().SetFloat("_Linecount", DistortionSize * 1505f);
			CFEDGDGBCHE().SetFloat("mapselector.filter.subscribedonly", LightIntensity * 143f);
			EFDEIFCDAFG().SetTexture("_Value", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			ADBKPGFMNKO().SetFloat("id", 1478f / farClipPlane);
			HFBJAOFLCJI().SetVector("VisionBlur", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 938f, 1242f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FEHCNJLLJMP()
	{
		FPHEBLMINDA = Resources.Load(". The group number should be at least 1.") as Texture2D;
		SCShader = Shader.Find("_Value");
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
			KEMJNOMIPHN().SetFloat("_Value", HBJJOCHGOPH);
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
				HFBJAOFLCJI().SetFloat("clear", _Distance);
			}
			else
			{
				HFBJAOFLCJI().SetFloat("maps.", _Distance);
			}
			HKHBBBFLGJH().SetFloat("_ScreenResolution", _Size);
			KEMJNOMIPHN().SetFloat("There is already a virtual button named ", (!_Visualize) ? 1 : 0);
			NBPKMLMCHFN.SetFloat("ShadersToggle", _FixDistance);
			NMDBCDFPGOK().SetFloat("/", DistortionLevel * 593f);
			HFBJAOFLCJI().SetFloat("NEW", DistortionSize * 1946f);
			EFDEIFCDAFG().SetFloat("PossibleMapMaxScoreText", LightIntensity * 416f);
			ADBKPGFMNKO().SetTexture("Event Received", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			EOCCJGIGEGJ().SetFloat(".", 1631f / farClipPlane);
			FEAEGGCNIAA().SetVector("Case-Sensitive", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1608f, 1610f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
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
		FPHEBLMINDA = Resources.Load("time") as Texture2D;
		SCShader = Shader.Find("RPC: 'OnAwakeRPC' Parameter: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
