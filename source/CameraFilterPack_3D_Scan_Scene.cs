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
			OLHDPICFBOF().SetFloat("cancel", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("No Camera attached!", Fade);
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
				BFGNMFCNDBC().SetFloat("Player Connected", _Distance);
			}
			else
			{
				AELJLBOJAIL().SetFloat("BlockSize", _Distance);
			}
			FLOHGDECHHH().SetFloat("No peer to communicate with. ", _Size);
			DEFBJOCJJKF().SetColor("<command>", ScanColor);
			IFMAPIDFNLI().SetFloat("_Value", _FixDistance);
			IGKFMCPDNOI().SetFloat("880078120", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			BLMPMOIDGMG().SetFloat("GlassColor", 1925f / farClipPlane);
			BFGNMFCNDBC().SetVector("PointsScoreText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 708f, 144f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
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
		SCShader = Shader.Find("Jit ");
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
			HEINDEMCGIK().SetFloat("_VelTex", HBJJOCHGOPH);
			BAGICADFBAB().SetFloat("Tab2Content", Fade);
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
				JFDGLLEOPGB().SetFloat(".lastCheckpoint.playerdistance", _Distance);
			}
			else
			{
				OLHDPICFBOF().SetFloat("[Up]", _Distance);
			}
			FGENHBKMPDA().SetFloat(".lastCheckpoint.playerdistance", _Size);
			PGPEMMBJOOG().SetColor("Error: Can not set the OnSerialize rate higher than the overall SendRate.", ScanColor);
			KEMAALEODNH().SetFloat("Object ID. Case-Sensitive", _FixDistance);
			IFMAPIDFNLI().SetFloat("_TimeX", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			IGKFMCPDNOI().SetFloat("[PlayerBase] Loaded music", 1348f / farClipPlane);
			IIBLJCKLGFG().SetVector("id", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 878f, 550f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
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
			GKILCDHJFEG().SetFloat("CameraFilterPack_Glasses_On6", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("/", Fade);
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
				HFBJAOFLCJI().SetFloat("[NetworkManager] Joined main lobby", _Distance);
			}
			else
			{
				IIBLJCKLGFG().SetFloat("curScn", _Distance);
			}
			OLHDPICFBOF().SetFloat("_ScreenResolution", _Size);
			FGENHBKMPDA().SetColor("CheckCombo", ScanColor);
			IFMAPIDFNLI().SetFloat("_Value4", _FixDistance);
			FGENHBKMPDA().SetFloat("skin.hit_normal", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			OGMEGHKECAH().SetFloat("cameramovements:", 502f / farClipPlane);
			OLHDPICFBOF().SetVector("CameraFilterPack/Blend2Camera_Luminosity", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 89f, 906f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
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
			HFBJAOFLCJI().SetFloat("CameraFilterPack/Blend2Camera_ColorBurn", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat(" or player:", Fade);
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
				BFGNMFCNDBC().SetFloat("_ScreenResolution", _Distance);
			}
			else
			{
				IGKFMCPDNOI().SetFloat("AudioSampler", _Distance);
			}
			IFMAPIDFNLI().SetFloat("Vertical", _Size);
			HFBJAOFLCJI().SetColor("Failed to Destroy objects of playerId: ", ScanColor);
			BLMPMOIDGMG().SetFloat(".png", _FixDistance);
			GCDFNHMJMIP().SetFloat(": ", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			KEMAALEODNH().SetFloat("GLITCH", 1556f / farClipPlane);
			BFGNMFCNDBC().SetVector("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 513f, 989f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIBLJCKLGFG());
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
		SCShader = Shader.Find("Lag ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LBAJLLFMMMP()
	{
		SCShader = Shader.Find(" not exist");
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
		SCShader = Shader.Find("*.workshop.json");
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
			FGENHBKMPDA().SetFloat(" to ", HBJJOCHGOPH);
			HEINDEMCGIK().SetFloat("_Value7", Fade);
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
				IIBLJCKLGFG().SetFloat("settings.arcsnohitsoundtimedelay", _Distance);
			}
			else
			{
				PGPEMMBJOOG().SetFloat("CameraFilterPack_Atmosphere_Rain_FX", _Distance);
			}
			HEINDEMCGIK().SetFloat("Item ", _Size);
			IIBLJCKLGFG().SetColor("_Val", ScanColor);
			OGMEGHKECAH().SetFloat(" : ", _FixDistance);
			DEFBJOCJJKF().SetFloat("_Value2", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			DKKBFFHBHJE().SetFloat("#useticket", 245f / farClipPlane);
			BFGNMFCNDBC().SetVector("_Bloom0", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 584f, 1389f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPCHMEKDCHI());
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
			FLOHGDECHHH().SetFloat("_TraceBehindObjects", HBJJOCHGOPH);
			IFMAPIDFNLI().SetFloat("menuthemes", Fade);
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
				OLHDPICFBOF().SetFloat("PublishButton", _Distance);
			}
			else
			{
				HEINDEMCGIK().SetFloat("No Description", _Distance);
			}
			GKILCDHJFEG().SetFloat("_TimeX", _Size);
			FGENHBKMPDA().SetColor("_SearchTex", ScanColor);
			IFMAPIDFNLI().SetFloat("PLEASE WAIT", _FixDistance);
			PGPEMMBJOOG().SetFloat("_Value2", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FGENHBKMPDA().SetFloat("[PlayerBase] Unknown event: ", 1372f / farClipPlane);
			GCDFNHMJMIP().SetVector("EditMenu", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1551f, 147f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KNBJBNDGCIJ()
	{
		SCShader = Shader.Find(". Verify the Prefab is in a Resources folder (and not in a subfolder)");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EPEGAEGDJAM()
	{
		SCShader = Shader.Find("ScrollPanel");
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
			IGKFMCPDNOI().SetFloat(": ", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("Type \"help\" for list of commands", Fade);
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
				BFGNMFCNDBC().SetFloat("SetCrosshairColor", _Distance);
			}
			else
			{
				BFGNMFCNDBC().SetFloat("maps.", _Distance);
			}
			BLMPMOIDGMG().SetFloat("SupportLogger OnCreatedRoom(", _Size);
			IGKFMCPDNOI().SetColor("L2", ScanColor);
			GCDFNHMJMIP().SetFloat("musicVolume", _FixDistance);
			NBPKMLMCHFN.SetFloat("_TimeX", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			GCDFNHMJMIP().SetFloat(".lastCheckpoint.isMapCompleted", 1307f / farClipPlane);
			GKILCDHJFEG().SetVector("RemoveEnvironmentObject", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 506f, 1026f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DFFKKLAPHCC()
	{
		SCShader = Shader.Find("_TimeX");
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
			GCDFNHMJMIP().SetFloat("Error: I/O Failure! :(", HBJJOCHGOPH);
			HEINDEMCGIK().SetFloat("1332644700", Fade);
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
				IFMAPIDFNLI().SetFloat(".played", _Distance);
			}
			else
			{
				IGKFMCPDNOI().SetFloat("_Value7", _Distance);
			}
			BLMPMOIDGMG().SetFloat("_TimeX", _Size);
			GCDFNHMJMIP().SetColor("settings.disablestoryboard", ScanColor);
			DEFBJOCJJKF().SetFloat(".", _FixDistance);
			PGPEMMBJOOG().SetFloat("Object ID. Case-Sensitive", (!_Visualize) ? 0 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			NBPKMLMCHFN.SetFloat(" not exist", 1512f / farClipPlane);
			BAGICADFBAB().SetVector("action", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 364f, 1203f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPCHMEKDCHI());
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
			HFBJAOFLCJI().SetFloat("UseScanLineSize", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("MaxLivesSlider", Fade);
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
				DEFBJOCJJKF().SetFloat("_Blend", _Distance);
			}
			else
			{
				JFDGLLEOPGB().SetFloat("/", _Distance);
			}
			HFBJAOFLCJI().SetFloat("[SteamManager] Connecting to server", _Size);
			IFMAPIDFNLI().SetColor("CameraFilterPack/Blur_Bloom", ScanColor);
			IIBLJCKLGFG().SetFloat("Missing shader in ", _FixDistance);
			BFGNMFCNDBC().SetFloat("vignetteIntensity", (!_Visualize) ? 0 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			IFMAPIDFNLI().SetFloat("_History4ChromaTex", 1536f / farClipPlane);
			JFDGLLEOPGB().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 965f, 978f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
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
			KEMAALEODNH().SetFloat("\"", HBJJOCHGOPH);
			HEINDEMCGIK().SetFloat("\nCreated by Oxy949", Fade);
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
				GCDFNHMJMIP().SetFloat("_MainTex2", _Distance);
			}
			else
			{
				BLMPMOIDGMG().SetFloat("_MainTex2", _Distance);
			}
			OLHDPICFBOF().SetFloat("_Value7", _Size);
			AELJLBOJAIL().SetColor("_MainTex2", ScanColor);
			FGENHBKMPDA().SetFloat("menutheme.jamaicanorcdub", _FixDistance);
			IIBLJCKLGFG().SetFloat("Set satellite color", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FGENHBKMPDA().SetFloat("settings.fps", 279f / farClipPlane);
			FGENHBKMPDA().SetVector("SetSatelliteTrailLength", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 468f, 1780f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
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
		SCShader = Shader.Find("_Greenness");
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
			KEMAALEODNH().SetFloat("#mapalreadyexistupdate", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("_ScreenResolution", Fade);
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
				FLOHGDECHHH().SetFloat("_Value2", _Distance);
			}
			else
			{
				GCDFNHMJMIP().SetFloat("Editor/", _Distance);
			}
			AELJLBOJAIL().SetFloat("DPADVER", _Size);
			BLMPMOIDGMG().SetColor("_Glitch", ScanColor);
			NBPKMLMCHFN.SetFloat("restrictions\n\n#until: ", _FixDistance);
			DKKBFFHBHJE().SetFloat("mapselector.orderby", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			BAGICADFBAB().SetFloat(". No ViewIDs are free to use. Max is: ", 1141f / farClipPlane);
			IIBLJCKLGFG().SetVector("Tab2Content", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1346f, 1345f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
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
			BLMPMOIDGMG().SetFloat("PlayButton", HBJJOCHGOPH);
			IIBLJCKLGFG().SetFloat("_Extra2", Fade);
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
				BLMPMOIDGMG().SetFloat("CameraFilterPack/TV_Videoflip", _Distance);
			}
			else
			{
				IFMAPIDFNLI().SetFloat("menu.tabid", _Distance);
			}
			JFDGLLEOPGB().SetFloat("_Value5", _Size);
			DEFBJOCJJKF().SetColor("_Distortion", ScanColor);
			BLMPMOIDGMG().SetFloat("_TimeX", _FixDistance);
			OLHDPICFBOF().SetFloat("_MainTex2", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			DEFBJOCJJKF().SetFloat("Editor/", 752f / farClipPlane);
			JFDGLLEOPGB().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1161f, 1566f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BAGICADFBAB());
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
		SCShader = Shader.Find("sounds/hit_perfect");
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
			PGPEMMBJOOG().SetFloat("CameraFilterPack/FX_Screens", HBJJOCHGOPH);
			FLOHGDECHHH().SetFloat("#changenote", Fade);
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
				PGPEMMBJOOG().SetFloat("\\[ *im.*\\](\\n\\n\\n|\\n\\n|\\n|)", _Distance);
			}
			else
			{
				AELJLBOJAIL().SetFloat("<color=white>", _Distance);
			}
			JFDGLLEOPGB().SetFloat(" ", _Size);
			PGPEMMBJOOG().SetColor("88f00bdf0ad61b16b803971ebe071962", ScanColor);
			BAGICADFBAB().SetFloat("</b>", _FixDistance);
			HEINDEMCGIK().SetFloat("ICollection", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HEINDEMCGIK().SetFloat("SetSunMaxSize", 338f / farClipPlane);
			HEINDEMCGIK().SetVector("Edited unlock conditions", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1378f, 140f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BLMPMOIDGMG());
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
		SCShader = Shader.Find("No Name");
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
			LPCHMEKDCHI().SetFloat("_Intensity", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat("[", Fade);
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
				LPCHMEKDCHI().SetFloat("Set Sun Sensitivity", _Distance);
			}
			else
			{
				LPCHMEKDCHI().SetFloat("ready", _Distance);
			}
			NBPKMLMCHFN.SetFloat("CameraFilterPack_Glasses_On5", _Size);
			LPCHMEKDCHI().SetColor("LostLive", ScanColor);
			AELJLBOJAIL().SetFloat("distance", _FixDistance);
			DKKBFFHBHJE().SetFloat("time", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			IFMAPIDFNLI().SetFloat("_ScreenResolution", 1201f / farClipPlane);
			BAGICADFBAB().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1052f, 929f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PGPEMMBJOOG());
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
		SCShader = Shader.Find("_ToPrevViewProjCombined");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JFJLGJEPEAA()
	{
		SCShader = Shader.Find("input");
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
			JFDGLLEOPGB().SetFloat("Image", HBJJOCHGOPH);
			IFMAPIDFNLI().SetFloat("maps.", Fade);
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
				OLHDPICFBOF().SetFloat("FavoriteButton", _Distance);
			}
			else
			{
				BFGNMFCNDBC().SetFloat("Items/", _Distance);
			}
			BFGNMFCNDBC().SetFloat("player.bluelifering", _Size);
			FLOHGDECHHH().SetColor(".status", ScanColor);
			HEINDEMCGIK().SetFloat("_NoiseTex", _FixDistance);
			DKKBFFHBHJE().SetFloat("_Value", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			JFDGLLEOPGB().SetFloat("menu.enableselectormusic", 1619f / farClipPlane);
			HFBJAOFLCJI().SetVector("Please attach component to a Graphical UI component", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1137f, 426f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BAGICADFBAB());
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
		SCShader = Shader.Find(",");
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
			JFDGLLEOPGB().SetFloat("powerup.0", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_RampTex", Fade);
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
				HEINDEMCGIK().SetFloat("_ScreenResolution", _Distance);
			}
			else
			{
				AELJLBOJAIL().SetFloat("[PlayerController] ", _Distance);
			}
			IGKFMCPDNOI().SetFloat("STOP [R]", _Size);
			IFMAPIDFNLI().SetColor("_Wavy", ScanColor);
			HEINDEMCGIK().SetFloat("There are a few rules that you must accept before submitting your work. Please select \"RULES\" button, if you haven't read them yet.", _FixDistance);
			OLHDPICFBOF().SetFloat(".lastCheckpoint.perfectHits", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			OGMEGHKECAH().SetFloat("_Bullet_8", 1159f / farClipPlane);
			IGKFMCPDNOI().SetVector("_LensDirt", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1566f, 1812f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
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
			LPCHMEKDCHI().SetFloat("Set crosshair color", HBJJOCHGOPH);
			OLHDPICFBOF().SetFloat("_TimeX", Fade);
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
				IFMAPIDFNLI().SetFloat("data", _Distance);
			}
			else
			{
				JFDGLLEOPGB().SetFloat("SpawnObj", _Distance);
			}
			GCDFNHMJMIP().SetFloat("Set Particles Gravity", _Size);
			FLOHGDECHHH().SetColor("_Glitch", ScanColor);
			AELJLBOJAIL().SetFloat("RoomPlayersCountText", _FixDistance);
			AELJLBOJAIL().SetFloat("?", (!_Visualize) ? 0 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			BAGICADFBAB().SetFloat("_Blend", 1360f / farClipPlane);
			HEINDEMCGIK().SetVector("EventMenu", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1213f, 98f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PGPEMMBJOOG());
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
			AELJLBOJAIL().SetFloat("_TimeX", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("_SearchTex", Fade);
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
				KEMAALEODNH().SetFloat("BestRegion checks region: ", _Distance);
			}
			else
			{
				GCDFNHMJMIP().SetFloat("arc", _Distance);
			}
			LPCHMEKDCHI().SetFloat("_Near", _Size);
			BAGICADFBAB().SetColor("settings.enableranking", ScanColor);
			GKILCDHJFEG().SetFloat("13", _FixDistance);
			JFDGLLEOPGB().SetFloat("shader.sunny", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			GCDFNHMJMIP().SetFloat("_Value", 1185f / farClipPlane);
			BFGNMFCNDBC().SetVector("CameraFilterPack/Colors_Adjust_FullColors", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 729f, 1564f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
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
			LPCHMEKDCHI().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("OnReadyClick", Fade);
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
				NBPKMLMCHFN.SetFloat("{0:x2}", _Distance);
			}
			else
			{
				BFGNMFCNDBC().SetFloat("mapselector.lastSearch", _Distance);
			}
			GCDFNHMJMIP().SetFloat("StartButton", _Size);
			IGKFMCPDNOI().SetColor("SetSpeed", ScanColor);
			BAGICADFBAB().SetFloat("Warning: Unhandled event ", _FixDistance);
			NBPKMLMCHFN.SetFloat("Tab1Content", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FLOHGDECHHH().SetFloat("_ScreenResolution", 1380f / farClipPlane);
			FLOHGDECHHH().SetVector("tagElement", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1430f, 1229f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
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
		SCShader = Shader.Find("No valid adaptive tonemapper type found!");
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
			FLOHGDECHHH().SetFloat("Data", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("DPADHOR", Fade);
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
				LPCHMEKDCHI().SetFloat("ViewMenu", _Distance);
			}
			else
			{
				DEFBJOCJJKF().SetFloat("_Smooth", _Distance);
			}
			DEFBJOCJJKF().SetFloat("Line", _Size);
			FGENHBKMPDA().SetColor("Object ID. Case-Sensitive", ScanColor);
			HFBJAOFLCJI().SetFloat("_Value", _FixDistance);
			FLOHGDECHHH().SetFloat("_V", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			IFMAPIDFNLI().SetFloat("GUICamera", 1306f / farClipPlane);
			IFMAPIDFNLI().SetVector("list", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 542f, 446f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
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
			IGKFMCPDNOI().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			FGENHBKMPDA().SetFloat("Tab1Content", Fade);
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
				IFMAPIDFNLI().SetFloat("896296812", _Distance);
			}
			else
			{
				GKILCDHJFEG().SetFloat("\" that takes ", _Distance);
			}
			BAGICADFBAB().SetFloat(".lastCheckpoint.comboScore", _Size);
			JFDGLLEOPGB().SetColor("green", ScanColor);
			PGPEMMBJOOG().SetFloat("_RedAmplifier", _FixDistance);
			HEINDEMCGIK().SetFloat("_Value3", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			BAGICADFBAB().SetFloat("\" to target: ", 1499f / farClipPlane);
			HFBJAOFLCJI().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 790f, 1468f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
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
			DKKBFFHBHJE().SetFloat("Right", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("CurrentTimeLabel", Fade);
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
				OLHDPICFBOF().SetFloat("float,2", _Distance);
			}
			else
			{
				IIBLJCKLGFG().SetFloat("GlassAberration", _Distance);
			}
			BLMPMOIDGMG().SetFloat("_ScreenResolution", _Size);
			FLOHGDECHHH().SetColor("itemid", ScanColor);
			AELJLBOJAIL().SetFloat("Toggle {0} is not part of ToggleGroup {1}", _FixDistance);
			OGMEGHKECAH().SetFloat("Hello World, is my item a clone? [", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			OGMEGHKECAH().SetFloat("_GrainOffsetScale", 1932f / farClipPlane);
			IGKFMCPDNOI().SetVector("green", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 798f, 1949f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
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
			PGPEMMBJOOG().SetFloat("Set Sun Emission", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("maps.", Fade);
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
				HEINDEMCGIK().SetFloat("maps.", _Distance);
			}
			else
			{
				BAGICADFBAB().SetFloat("_Value2", _Distance);
			}
			KEMAALEODNH().SetFloat("\n", _Size);
			AELJLBOJAIL().SetColor("ping: {6}[+/-{7}]ms resent:{8} \n\nmax ms between\nsend: {0,4} \ndispatch: {1,4} \n\nlongest dispatch for: \nev({3}):{2,3}ms \nop({5}):{4,3}ms", ScanColor);
			JFDGLLEOPGB().SetFloat("GameScene", _FixDistance);
			GKILCDHJFEG().SetFloat("Set Crosshair Emission", (!_Visualize) ? 0 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			DKKBFFHBHJE().SetFloat("SpawnObj", 1760f / farClipPlane);
			IGKFMCPDNOI().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1307f, 1797f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DBEMDAJDDDA()
	{
		SCShader = Shader.Find("_Bloom2");
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
		SCShader = Shader.Find("w");
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
			LPCHMEKDCHI().SetFloat("_TimeX", HBJJOCHGOPH);
			OLHDPICFBOF().SetFloat("76561198041679481", Fade);
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
				HFBJAOFLCJI().SetFloat("_MainTex2", _Distance);
			}
			else
			{
				GKILCDHJFEG().SetFloat("_Value2", _Distance);
			}
			IGKFMCPDNOI().SetFloat("_Value4", _Size);
			AELJLBOJAIL().SetColor("_Value", ScanColor);
			HFBJAOFLCJI().SetFloat("_Screen", _FixDistance);
			IGKFMCPDNOI().SetFloat("Scrollbar", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			OGMEGHKECAH().SetFloat("winter2020_official", 1658f / farClipPlane);
			BFGNMFCNDBC().SetVector("_VignettingColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 819f, 1867f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
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
