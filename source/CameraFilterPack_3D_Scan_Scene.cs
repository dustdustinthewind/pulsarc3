// CameraFilterPack_3D_Scan_Scene
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/3D/Scan_Scene")]
[ExecuteInEditMode]
public class CameraFilterPack_3D_Scan_Scene : MonoBehaviour
{
	public Shader SCShader;

	public bool _Visualize;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 100f)]
	public float _FixDistance = 1f;

	[Range(0f, 0.99f)]
	public float _Distance = 1f;

	[Range(0f, 0.1f)]
	public float _Size = 0.01f;

	public bool AutoAnimatedNear;

	[Range(-5f, 5f)]
	public float AutoAnimatedNearSpeed = 1f;

	public Color ScanColor = new Color(2f, 0f, 0f, 1f);

	[Range(0f, 1f)]
	public float Fade = 1f;

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

	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 709f)
			{
				HBJJOCHGOPH = 1776f;
			}
			BFGNMFCNDBC().SetFloat("[ResourcesManager] Load text error: not found", HBJJOCHGOPH);
			OLHDPICFBOF().SetFloat("bad", Fade);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 184f)
				{
					_Distance = 1078f;
				}
				if (_Distance < 1617f)
				{
					_Distance = 43f;
				}
				FGENHBKMPDA().SetFloat("Player Connected", _Distance);
			}
			else
			{
				IIBLJCKLGFG().SetFloat("_SprTex", _Distance);
			}
			HEINDEMCGIK().SetFloat(". Calling ConnectToRegionMaster() is: ", _Size);
			FGENHBKMPDA().SetColor("Run a command for the Localization Servise", ScanColor);
			GCDFNHMJMIP().SetFloat("_TimeX", _FixDistance);
			KEMAALEODNH().SetFloat("1427616858", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			BAGICADFBAB().SetFloat("GlassesColor2", 1925f / farClipPlane);
			OGMEGHKECAH().SetVector("PointsScoreText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 708f, 144f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DOEPOGLEGLE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material GCDFNHMJMIP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)97;
		}
		return BJFKDHHMLJH;
	}

	private void PKLOBJHKFEO()
	{
		SCShader = Shader.Find("Rtt:{0,4} +/-{1,3}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GFACKFCEIBC()
	{
	}

	private void MAOCOEGAFND()
	{
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
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1f)
				{
					_Distance = 0f;
				}
				if (_Distance < 0f)
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
			NBPKMLMCHFN.SetColor("_ColorRGB", ScanColor);
			NBPKMLMCHFN.SetFloat("_FixDistance", _FixDistance);
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

	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 286f)
			{
				HBJJOCHGOPH = 906f;
			}
			IIBLJCKLGFG().SetFloat("_Jitter", HBJJOCHGOPH);
			FGENHBKMPDA().SetFloat("Tab2Content", Fade);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1604f)
				{
					_Distance = 785f;
				}
				if (_Distance < 1695f)
				{
					_Distance = 864f;
				}
				IGKFMCPDNOI().SetFloat(".lastCheckpoint.comboScore", _Distance);
			}
			else
			{
				BAGICADFBAB().SetFloat(",0", _Distance);
			}
			GKILCDHJFEG().SetFloat(".lastCheckpoint.penaltyScore", _Size);
			BLMPMOIDGMG().SetColor("Can't start OFFLINE mode while connected!", ScanColor);
			IIBLJCKLGFG().SetFloat("id", _FixDistance);
			FLOHGDECHHH().SetFloat("_TimeX", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			OLHDPICFBOF().SetFloat("0", 1348f / farClipPlane);
			IFMAPIDFNLI().SetVector("SetSatelliteRotationSpeed", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 878f, 550f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 779f)
			{
				HBJJOCHGOPH = 1693f;
			}
			IFMAPIDFNLI().SetFloat("_MainTex2", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("/", Fade);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1183f)
				{
					_Distance = 269f;
				}
				if (_Distance < 1572f)
				{
					_Distance = 986f;
				}
				NBPKMLMCHFN.SetFloat("[NetworkManager] Joined main lobby", _Distance);
			}
			else
			{
				HFBJAOFLCJI().SetFloat(" [", _Distance);
			}
			OLHDPICFBOF().SetFloat("_Fade", _Size);
			BAGICADFBAB().SetColor("[PlayerBase] Loaded music", ScanColor);
			PGPEMMBJOOG().SetFloat("_Value3", _FixDistance);
			FGENHBKMPDA().SetFloat("sounds/hit_perfect", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FGENHBKMPDA().SetFloat("settings.shaders.bloomintencity", 502f / farClipPlane);
			PGPEMMBJOOG().SetVector("CameraFilterPack/Blend2Camera_Luminosity", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 89f, 906f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1209f)
			{
				HBJJOCHGOPH = 25f;
			}
			BLMPMOIDGMG().SetFloat("CameraFilterPack/Blend2Camera_Multiply", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat(" GO:", Fade);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1794f)
				{
					_Distance = 1801f;
				}
				if (_Distance < 29f)
				{
					_Distance = 1131f;
				}
				DEFBJOCJJKF().SetFloat("_Value3", _Distance);
			}
			else
			{
				OGMEGHKECAH().SetFloat("AudioSampler", _Distance);
			}
			GCDFNHMJMIP().SetFloat("name", _Size);
			OGMEGHKECAH().SetColor("]. Please verify you have this gameobject in a Resources folder.", ScanColor);
			BFGNMFCNDBC().SetFloat(".jpg", _FixDistance);
			LPCHMEKDCHI().SetFloat("[PlayerController] ", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HEINDEMCGIK().SetFloat("JITTER", 1556f / farClipPlane);
			JFDGLLEOPGB().SetVector("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 513f, 989f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BAGICADFBAB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HFBJAOFLCJI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void HAIAHJPCPAG()
	{
		SCShader = Shader.Find("No peer to communicate with. ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LBAJLLFMMMP()
	{
		SCShader = Shader.Find("[PlayerController] ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OBAEDJJDCPN()
	{
	}

	private void NEFHGMNAPEP()
	{
		SCShader = Shader.Find("SUBMIT '{0}' FILES");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1096f)
			{
				HBJJOCHGOPH = 56f;
			}
			IGKFMCPDNOI().SetFloat("Bad modpack name: {0}", HBJJOCHGOPH);
			BAGICADFBAB().SetFloat("_Value7", Fade);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1951f)
				{
					_Distance = 131f;
				}
				if (_Distance < 955f)
				{
					_Distance = 934f;
				}
				FGENHBKMPDA().SetFloat("settings.arcsdestroydelay", _Distance);
			}
			else
			{
				FLOHGDECHHH().SetFloat("CameraFilterPack_Atmosphere_Rain_FX", _Distance);
			}
			OGMEGHKECAH().SetFloat("ItemTemplate", _Size);
			PGPEMMBJOOG().SetColor("_Sat", ScanColor);
			NBPKMLMCHFN.SetFloat(" : ", _FixDistance);
			IFMAPIDFNLI().SetFloat("_Value", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FLOHGDECHHH().SetFloat("#failed: ", 245f / farClipPlane);
			DEFBJOCJJKF().SetVector("_LensDirtIntensity", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 584f, 1389f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 75f)
			{
				HBJJOCHGOPH = 1988f;
			}
			HEINDEMCGIK().SetFloat("_TreatBackfaceHitAsMiss", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat("GroupNameText", Fade);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 962f)
				{
					_Distance = 249f;
				}
				if (_Distance < 804f)
				{
					_Distance = 199f;
				}
				FGENHBKMPDA().SetFloat("PublishButton", _Distance);
			}
			else
			{
				HFBJAOFLCJI().SetFloat("No Description", _Distance);
			}
			GCDFNHMJMIP().SetFloat("CameraFilterPack/Distortion_Dream", _Size);
			AELJLBOJAIL().SetColor("SearchTex", ScanColor);
			BLMPMOIDGMG().SetFloat("PLEASE WAIT", _FixDistance);
			FGENHBKMPDA().SetFloat("_Value", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			OGMEGHKECAH().SetFloat(" not exist", 1372f / farClipPlane);
			IIBLJCKLGFG().SetVector("EditMenu", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1551f, 147f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KNBJBNDGCIJ()
	{
		SCShader = Shader.Find(". Client is not the MasterClient in this room.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EPEGAEGDJAM()
	{
		SCShader = Shader.Find("InputField");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 509f)
			{
				HBJJOCHGOPH = 1383f;
			}
			GCDFNHMJMIP().SetFloat(":", HBJJOCHGOPH);
			BAGICADFBAB().SetFloat("<color=#{0}>{1}</color>", Fade);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 800f)
				{
					_Distance = 1230f;
				}
				if (_Distance < 900f)
				{
					_Distance = 1358f;
				}
				FGENHBKMPDA().SetFloat("SetSatelliteTrailLength", _Distance);
			}
			else
			{
				IGKFMCPDNOI().SetFloat("maps.", _Distance);
			}
			DEFBJOCJJKF().SetFloat("SupportLogger OnJoinedRoom(", _Size);
			BLMPMOIDGMG().SetColor("R1", ScanColor);
			OLHDPICFBOF().SetFloat("sfxVolume", _FixDistance);
			DEFBJOCJJKF().SetFloat("_ScreenResolution", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			BLMPMOIDGMG().SetFloat(".lastCheckpoint.bgcolor", 1307f / farClipPlane);
			IGKFMCPDNOI().SetVector("SetBGColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 506f, 1026f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DFFKKLAPHCC()
	{
		SCShader = Shader.Find("CameraFilterPack/TV_Noise");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material KEMAALEODNH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1874f)
			{
				HBJJOCHGOPH = 954f;
			}
			JFDGLLEOPGB().SetFloat("Error: Timeout :S", HBJJOCHGOPH);
			LPCHMEKDCHI().SetFloat("1278033234", Fade);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1816f)
				{
					_Distance = 161f;
				}
				if (_Distance < 1843f)
				{
					_Distance = 129f;
				}
				OGMEGHKECAH().SetFloat("maps.", _Distance);
			}
			else
			{
				DKKBFFHBHJE().SetFloat("_Value6", _Distance);
			}
			AELJLBOJAIL().SetFloat("_TimeX", _Size);
			BFGNMFCNDBC().SetColor("settings.disablestoryboard", ScanColor);
			IGKFMCPDNOI().SetFloat("ServerSettings: ", _FixDistance);
			BFGNMFCNDBC().SetFloat("Object ID. Case-Sensitive", (!_Visualize) ? 0 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			KEMAALEODNH().SetFloat("[PlayerController] ", 1512f / farClipPlane);
			BFGNMFCNDBC().SetVector("menuVolume", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 364f, 1203f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FEHCNJLLJMP()
	{
		SCShader = Shader.Find("CameraFilterPack/3D_Myst");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1233f)
			{
				HBJJOCHGOPH = 1483f;
			}
			PGPEMMBJOOG().SetFloat("GlassColor", HBJJOCHGOPH);
			FLOHGDECHHH().SetFloat("Tab2Content", Fade);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1229f)
				{
					_Distance = 1926f;
				}
				if (_Distance < 368f)
				{
					_Distance = 341f;
				}
				IFMAPIDFNLI().SetFloat("_LutTex", _Distance);
			}
			else
			{
				GCDFNHMJMIP().SetFloat("/", _Distance);
			}
			NBPKMLMCHFN.SetFloat("[Steamworks.NET] Could not load [lib]steam_api.dll/so/dylib. It's likely not in the correct location. Refer to the README for more details.\n", _Size);
			JFDGLLEOPGB().SetColor("_MainTex2", ScanColor);
			GKILCDHJFEG().SetFloat("_ScratchOffsetScale", _FixDistance);
			OGMEGHKECAH().SetFloat("useSrcAlphaAsMask", (!_Visualize) ? 0 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			DKKBFFHBHJE().SetFloat("_History2ChromaTex", 1536f / farClipPlane);
			FLOHGDECHHH().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 965f, 978f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material BFGNMFCNDBC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-107);
		}
		return BJFKDHHMLJH;
	}

	private void ODAIMOJLJOF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 598f)
			{
				HBJJOCHGOPH = 1794f;
			}
			OLHDPICFBOF().SetFloat("[LevelEditorScene] Reloaded config for \"", HBJJOCHGOPH);
			FGENHBKMPDA().SetFloat("/files/editor_manual.pdf", Fade);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1803f)
				{
					_Distance = 29f;
				}
				if (_Distance < 1306f)
				{
					_Distance = 54f;
				}
				FGENHBKMPDA().SetFloat("_MainTex2", _Distance);
			}
			else
			{
				IFMAPIDFNLI().SetFloat("_Bullet_12", _Distance);
			}
			GCDFNHMJMIP().SetFloat("_Value7", _Size);
			BFGNMFCNDBC().SetColor("_MainTex2", ScanColor);
			GCDFNHMJMIP().SetFloat("menutheme.jamaicanorcdub", _FixDistance);
			IGKFMCPDNOI().SetFloat("Hex value #RRGGBB", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			BLMPMOIDGMG().SetFloat("] ", 279f / farClipPlane);
			IIBLJCKLGFG().SetVector("Set satellite radius (offset)", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 468f, 1780f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DHNGNHGDPLM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BMODOIJGIOO()
	{
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/3D_Scan_Scene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material IGKFMCPDNOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)86;
		}
		return BJFKDHHMLJH;
	}

	private void FIKFJDFELIP()
	{
		SCShader = Shader.Find("_OnOff");
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

	private void FBPHNEJBDJN()
	{
		SCShader = Shader.Find("\t");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DLIJFEGIEKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1746f)
			{
				HBJJOCHGOPH = 1634f;
			}
			GKILCDHJFEG().SetFloat("#no", HBJJOCHGOPH);
			IIBLJCKLGFG().SetFloat("_Value4", Fade);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 267f)
				{
					_Distance = 1683f;
				}
				if (_Distance < 39f)
				{
					_Distance = 1417f;
				}
				DKKBFFHBHJE().SetFloat("_Value", _Distance);
			}
			else
			{
				GKILCDHJFEG().SetFloat("editor.", _Distance);
			}
			LPCHMEKDCHI().SetFloat("DPADHOR", _Size);
			BAGICADFBAB().SetColor("_TimeX", ScanColor);
			BLMPMOIDGMG().SetFloat("restrictions\n\n#until: ", _FixDistance);
			BLMPMOIDGMG().SetFloat("mapselector.orderby", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HFBJAOFLCJI().SetFloat("Failed to InstantiateSceneObject prefab:", 1141f / farClipPlane);
			JFDGLLEOPGB().SetVector("EnvironmentSlider", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1346f, 1345f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GCDLIKEDMCF()
	{
	}

	[SpecialName]
	private Material AELJLBOJAIL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void MGMAOBPPOBJ()
	{
		SCShader = Shader.Find("other.dust2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 283f)
			{
				HBJJOCHGOPH = 909f;
			}
			BAGICADFBAB().SetFloat("PLAY [SPACE]", HBJJOCHGOPH);
			FGENHBKMPDA().SetFloat("_Extra", Fade);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1042f)
				{
					_Distance = 971f;
				}
				if (_Distance < 621f)
				{
					_Distance = 1651f;
				}
				KEMAALEODNH().SetFloat("_ScreenResolution", _Distance);
			}
			else
			{
				FLOHGDECHHH().SetFloat("menu.tabid", _Distance);
			}
			OGMEGHKECAH().SetFloat("_Value4", _Size);
			BAGICADFBAB().SetColor("_Distortion", ScanColor);
			OGMEGHKECAH().SetFloat("CameraFilterPack/Drawing_Curve", _FixDistance);
			GKILCDHJFEG().SetFloat("_MainTex2", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			PGPEMMBJOOG().SetFloat("Editor/", 752f / farClipPlane);
			FGENHBKMPDA().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1161f, 1566f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material FLOHGDECHHH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)112;
		}
		return BJFKDHHMLJH;
	}

	private void EFJDNLGNACH()
	{
		SCShader = Shader.Find("skin.hit_wrong");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LLJLDLLNFBH()
	{
	}

	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 374f)
			{
				HBJJOCHGOPH = 218f;
			}
			OGMEGHKECAH().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			IIBLJCKLGFG().SetFloat("#mapmustbecompletebeforesubmit", Fade);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 134f)
				{
					_Distance = 836f;
				}
				if (_Distance < 737f)
				{
					_Distance = 246f;
				}
				GKILCDHJFEG().SetFloat("\\[ *im.*\\](\\n\\n\\n|\\n\\n|\\n|)", _Distance);
			}
			else
			{
				KEMAALEODNH().SetFloat(" | ", _Distance);
			}
			IFMAPIDFNLI().SetFloat("ERROR You should never change PhotonPlayer IDs!", _Size);
			DKKBFFHBHJE().SetColor("Did not read byte array properly", ScanColor);
			IIBLJCKLGFG().SetFloat("</b>", _FixDistance);
			FLOHGDECHHH().SetFloat("w", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			IFMAPIDFNLI().SetFloat("Set sun min/max size", 338f / farClipPlane);
			DKKBFFHBHJE().SetVector("Tab1Content", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1378f, 140f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KDJEJBBDILE()
	{
	}

	private void COIJKMKIEAK()
	{
		SCShader = Shader.Find("No Description");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ONKDMMJPEMN()
	{
	}

	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 382f)
			{
				HBJJOCHGOPH = 1534f;
			}
			BLMPMOIDGMG().SetFloat("_Intensity", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("settings.hitvariation", Fade);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 402f)
				{
					_Distance = 1682f;
				}
				if (_Distance < 783f)
				{
					_Distance = 506f;
				}
				GKILCDHJFEG().SetFloat("SetSunSensitivity", _Distance);
			}
			else
			{
				DEFBJOCJJKF().SetFloat("start", _Distance);
			}
			OLHDPICFBOF().SetFloat("_MainTex2", _Size);
			GKILCDHJFEG().SetColor("_EmissionGain", ScanColor);
			LPCHMEKDCHI().SetFloat("Set Player Distance", _FixDistance);
			BFGNMFCNDBC().SetFloat("{0:0.0} ms ({1:0.} fps)", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			DEFBJOCJJKF().SetFloat("_Gain", 1201f / farClipPlane);
			OLHDPICFBOF().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1052f, 929f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material GKILCDHJFEG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)88;
		}
		return BJFKDHHMLJH;
	}

	private void DKGBFNCOAEO()
	{
		SCShader = Shader.Find("_TileTexDebug");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JFJLGJEPEAA()
	{
		SCShader = Shader.Find("Object ID. Case-Sensitive");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AEOLJEIDMDB()
	{
		SCShader = Shader.Find("UpperMid");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IFJDKDFLGBG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material FGENHBKMPDA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)90;
		}
		return BJFKDHHMLJH;
	}

	private void NPLCENPNJBM()
	{
		SCShader = Shader.Find("LivesSlider");
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
			BJFKDHHMLJH.hideFlags = (HideFlags)114;
		}
		return BJFKDHHMLJH;
	}

	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1087f)
			{
				HBJJOCHGOPH = 212f;
			}
			GCDFNHMJMIP().SetFloat("InventoryGrid", HBJJOCHGOPH);
			HEINDEMCGIK().SetFloat("maps.", Fade);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 155f)
				{
					_Distance = 1951f;
				}
				if (_Distance < 1806f)
				{
					_Distance = 1676f;
				}
				OGMEGHKECAH().SetFloat("LeaderboardsButton", _Distance);
			}
			else
			{
				LPCHMEKDCHI().SetFloat("Connecting to server", _Distance);
			}
			AELJLBOJAIL().SetFloat("player.bluelifering", _Size);
			DEFBJOCJJKF().SetColor(".completedCount", ScanColor);
			BLMPMOIDGMG().SetFloat("_NoiseAmount", _FixDistance);
			OGMEGHKECAH().SetFloat("CameraFilterPack/Vision_AuraDistortion", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HEINDEMCGIK().SetFloat("menu.enableselectormusic", 1619f / farClipPlane);
			HEINDEMCGIK().SetVector("Default UI Material", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1137f, 426f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BGFJOEPFOPM()
	{
	}

	private void LCJHDLKJEOM()
	{
	}

	private void GNMGIHFKJIJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void COGBDFKOHKK()
	{
	}

	private void NKFDNIAKGEO()
	{
		SCShader = Shader.Find(".progress");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1337f)
			{
				HBJJOCHGOPH = 1070f;
			}
			PGPEMMBJOOG().SetFloat("note.7", HBJJOCHGOPH);
			LPCHMEKDCHI().SetFloat("_Offset", Fade);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 843f)
				{
					_Distance = 1249f;
				}
				if (_Distance < 387f)
				{
					_Distance = 1851f;
				}
				GKILCDHJFEG().SetFloat("_Value4", _Distance);
			}
			else
			{
				OGMEGHKECAH().SetFloat(" not exist", _Distance);
			}
			BAGICADFBAB().SetFloat("RECORD [R]", _Size);
			LPCHMEKDCHI().SetColor("_DistortionWave", ScanColor);
			NBPKMLMCHFN.SetFloat("OK", _FixDistance);
			KEMAALEODNH().SetFloat(".lastCheckpoint.powerupsScore", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			BAGICADFBAB().SetFloat("_Bullet_7", 1159f / farClipPlane);
			DEFBJOCJJKF().SetVector("_Bloom4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1566f, 1812f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LPCHMEKDCHI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)127;
		}
		return BJFKDHHMLJH;
	}

	private void HPNNCNNFMGK()
	{
	}

	private void NFEDLAOPHML()
	{
	}

	private void HDDECCMEJKA()
	{
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

	private void HIFLPHLGLFG()
	{
	}

	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1973f)
			{
				HBJJOCHGOPH = 243f;
			}
			HFBJAOFLCJI().SetFloat("float,10", HBJJOCHGOPH);
			HEINDEMCGIK().SetFloat("_TimeX", Fade);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1919f)
				{
					_Distance = 1176f;
				}
				if (_Distance < 484f)
				{
					_Distance = 121f;
				}
				JFDGLLEOPGB().SetFloat(".save", _Distance);
			}
			else
			{
				BLMPMOIDGMG().SetFloat("[Right]", _Distance);
			}
			DEFBJOCJJKF().SetFloat("SetParticlesGravity", _Size);
			BLMPMOIDGMG().SetColor("_Glitch", ScanColor);
			FLOHGDECHHH().SetFloat("RoomPlayersCountText", _FixDistance);
			FGENHBKMPDA().SetFloat("?", (!_Visualize) ? 0 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			BLMPMOIDGMG().SetFloat("_LutTex", 1360f / farClipPlane);
			GKILCDHJFEG().SetVector("HelpMenu", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1213f, 98f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material BLMPMOIDGMG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-77);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HEINDEMCGIK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)74;
		}
		return BJFKDHHMLJH;
	}

	private void LCHBFNIPBHB()
	{
	}

	private void IDIIELPAMCJ()
	{
	}

	private void FDPOFMCFBMF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JONGNKNLLND()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KOJKBFDNGDK()
	{
		SCShader = Shader.Find("LevelNameInputField");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1748f)
			{
				HBJJOCHGOPH = 1421f;
			}
			KEMAALEODNH().SetFloat("_TimeX", HBJJOCHGOPH);
			HEINDEMCGIK().SetFloat("SearchTex", Fade);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1686f)
				{
					_Distance = 1175f;
				}
				if (_Distance < 1449f)
				{
					_Distance = 1266f;
				}
				IGKFMCPDNOI().SetFloat("(scene)", _Distance);
			}
			else
			{
				AELJLBOJAIL().SetFloat("arc", _Distance);
			}
			FLOHGDECHHH().SetFloat("_Near", _Size);
			HFBJAOFLCJI().SetColor("CompletedLevel", ScanColor);
			NBPKMLMCHFN.SetFloat("nd", _FixDistance);
			HFBJAOFLCJI().SetFloat("shader.sunny", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			JFDGLLEOPGB().SetFloat("_TimeX", 1185f / farClipPlane);
			KEMAALEODNH().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 729f, 1564f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HOMNAHDDNHJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material IIBLJCKLGFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInHierarchy);
		}
		return BJFKDHHMLJH;
	}

	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1541f)
			{
				HBJJOCHGOPH = 171f;
			}
			PGPEMMBJOOG().SetFloat("_Value", HBJJOCHGOPH);
			IIBLJCKLGFG().SetFloat("OnReadyClick", Fade);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1707f)
				{
					_Distance = 1007f;
				}
				if (_Distance < 678f)
				{
					_Distance = 893f;
				}
				GKILCDHJFEG().SetFloat("TestTicket", _Distance);
			}
			else
			{
				OGMEGHKECAH().SetFloat("mapselector.lastSearch", _Distance);
			}
			GCDFNHMJMIP().SetFloat("StartButton", _Size);
			JFDGLLEOPGB().SetColor("SetSpeed", ScanColor);
			LPCHMEKDCHI().SetFloat(". Sent by actorNr: ", _FixDistance);
			GCDFNHMJMIP().SetFloat("ConfigVersionSlider", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			PGPEMMBJOOG().SetFloat("_Value4", 1380f / farClipPlane);
			IIBLJCKLGFG().SetVector("HiddenToggle", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1430f, 1229f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DEFBJOCJJKF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	private void FNCDAPDOBBI()
	{
		SCShader = Shader.Find("_HdrParams");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 753f)
			{
				HBJJOCHGOPH = 733f;
			}
			DKKBFFHBHJE().SetFloat("Data", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("DPADVER", Fade);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1447f)
				{
					_Distance = 1231f;
				}
				if (_Distance < 1839f)
				{
					_Distance = 1429f;
				}
				OGMEGHKECAH().SetFloat("#mapnotloaded", _Distance);
			}
			else
			{
				BFGNMFCNDBC().SetFloat("_Dist", _Distance);
			}
			BFGNMFCNDBC().SetFloat("Line", _Size);
			NBPKMLMCHFN.SetColor("id", ScanColor);
			LPCHMEKDCHI().SetFloat("_TimeX", _FixDistance);
			LPCHMEKDCHI().SetFloat("_U", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			LPCHMEKDCHI().SetFloat("Selection Box", 1306f / farClipPlane);
			IFMAPIDFNLI().SetVector("Bad parameters for set! Use <language>", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 542f, 446f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IFMAPIDFNLI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IFIHBNJKEKD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KLDNGKBMDAN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1775f)
			{
				HBJJOCHGOPH = 791f;
			}
			GCDFNHMJMIP().SetFloat("_Speed", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat("Tab1Content", Fade);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1052f)
				{
					_Distance = 1069f;
				}
				if (_Distance < 418f)
				{
					_Distance = 818f;
				}
				LPCHMEKDCHI().SetFloat("Reset 21 achievement progress", _Distance);
			}
			else
			{
				KEMAALEODNH().SetFloat(" has ", _Distance);
			}
			KEMAALEODNH().SetFloat(".lastCheckpoint.currentCombo", _Size);
			OLHDPICFBOF().SetColor("green", ScanColor);
			NBPKMLMCHFN.SetFloat("_TimeX", _FixDistance);
			IFMAPIDFNLI().SetFloat("_Value2", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			GCDFNHMJMIP().SetFloat(" GO:", 1499f / farClipPlane);
			BAGICADFBAB().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 790f, 1468f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NCPAFCKGJEA()
	{
	}

	[SpecialName]
	private Material PGPEMMBJOOG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 142f)
			{
				HBJJOCHGOPH = 1873f;
			}
			LPCHMEKDCHI().SetFloat("MouseX", HBJJOCHGOPH);
			FGENHBKMPDA().SetFloat("[MapEditor] Loaded music file: ", Fade);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1395f)
				{
					_Distance = 1577f;
				}
				if (_Distance < 626f)
				{
					_Distance = 1390f;
				}
				GKILCDHJFEG().SetFloat("value", _Distance);
			}
			else
			{
				DEFBJOCJJKF().SetFloat("GlassDistortion", _Distance);
			}
			GKILCDHJFEG().SetFloat("_BlueAmplifier", _Size);
			FLOHGDECHHH().SetColor("PLEASE WAIT", ScanColor);
			GKILCDHJFEG().SetFloat("\n", _FixDistance);
			IFMAPIDFNLI().SetFloat("You need to have a Graphic control (such as an Image) for the list [", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			IGKFMCPDNOI().SetFloat("_GrainTex", 1932f / farClipPlane);
			AELJLBOJAIL().SetVector("green", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 798f, 1949f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IABLKKAALGI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material BAGICADFBAB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-123);
		}
		return BJFKDHHMLJH;
	}

	private void MNBPNHNAEBK()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material OGMEGHKECAH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-1);
		}
		return BJFKDHHMLJH;
	}

	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1694f)
			{
				HBJJOCHGOPH = 1267f;
			}
			LPCHMEKDCHI().SetFloat("SetSunEmission", HBJJOCHGOPH);
			FGENHBKMPDA().SetFloat("maps.", Fade);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 177f)
				{
					_Distance = 335f;
				}
				if (_Distance < 1719f)
				{
					_Distance = 725f;
				}
				LPCHMEKDCHI().SetFloat("maps.", _Distance);
			}
			else
			{
				JFDGLLEOPGB().SetFloat("_Value2", _Distance);
			}
			GCDFNHMJMIP().SetFloat("]", _Size);
			OGMEGHKECAH().SetColor("Incoming: \n", ScanColor);
			OGMEGHKECAH().SetFloat("GameScene", _FixDistance);
			BFGNMFCNDBC().SetFloat("Set Crosshair Emission", (!_Visualize) ? 0 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			JFDGLLEOPGB().SetFloat("SpawnObj", 1760f / farClipPlane);
			BAGICADFBAB().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1307f, 1797f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DBEMDAJDDDA()
	{
		SCShader = Shader.Find("_Bloom1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material DKKBFFHBHJE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void DGCGGKMNPLD()
	{
	}

	private void NNCCPEBIAKH()
	{
		SCShader = Shader.Find("z");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 408f)
			{
				HBJJOCHGOPH = 833f;
			}
			IFMAPIDFNLI().SetFloat("CameraFilterPack/Vision_Plasma", HBJJOCHGOPH);
			HEINDEMCGIK().SetFloat("appid", Fade);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 953f)
				{
					_Distance = 1447f;
				}
				if (_Distance < 1501f)
				{
					_Distance = 1527f;
				}
				OGMEGHKECAH().SetFloat("CameraFilterPack/Blend2Camera_Subtract", _Distance);
			}
			else
			{
				IIBLJCKLGFG().SetFloat("_Value", _Distance);
			}
			DEFBJOCJJKF().SetFloat("_Value3", _Size);
			HEINDEMCGIK().SetColor("_TimeX", ScanColor);
			OLHDPICFBOF().SetFloat("pointBuffer", _FixDistance);
			GCDFNHMJMIP().SetFloat("Overlay", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			KEMAALEODNH().SetFloat("/", 1658f / farClipPlane);
			IGKFMCPDNOI().SetVector("_Vignetting2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 819f, 1867f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JLNNHKPHMAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LADCJEIALMH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BKGJOECFMID()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LINKAMEPKGM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FODKODGPPDA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JHPOIOELNCG()
	{
	}

	[SpecialName]
	private Material IFMAPIDFNLI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)113;
		}
		return BJFKDHHMLJH;
	}
}
