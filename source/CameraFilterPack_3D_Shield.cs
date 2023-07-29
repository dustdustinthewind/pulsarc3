// CameraFilterPack_3D_Shield
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/3D/Shield")]
public class CameraFilterPack_3D_Shield : MonoBehaviour
{
	public Shader SCShader;

	public bool _Visualize;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 100f)]
	public float _FixDistance = 1.5f;

	[Range(-0.99f, 0.99f)]
	public float _Distance = 0.4f;

	[Range(0f, 0.5f)]
	public float _Size = 0.5f;

	[Range(0f, 1f)]
	public float _FadeShield = 0.75f;

	[Range(-0.2f, 0.2f)]
	public float LightIntensity = 0.025f;

	public bool AutoAnimatedNear;

	[Range(-5f, 5f)]
	public float AutoAnimatedNearSpeed = 0.5f;

	[Range(0f, 10f)]
	public float Speed = 0.2f;

	[Range(0f, 10f)]
	public float Speed_X = 0.2f;

	[Range(0f, 1f)]
	public float Speed_Y = 0.3f;

	[Range(0f, 10f)]
	public float Intensity = 2.4f;

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
	private Material LPPEPKGFOEM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material PGPEMMBJOOG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material DCCHGBHLAAF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void JNALDALAJLG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CKECPMDEBLL()
	{
	}

	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1291f)
			{
				HBJJOCHGOPH = 1553f;
			}
			KEMAALEODNH().SetFloat("_Distortion", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 979f)
				{
					_Distance = 1687f;
				}
				if (_Distance < 675f)
				{
					_Distance = 38f;
				}
				CECJJMKLEAK().SetFloat("Bad parameters for getstring! Use <key> <value>", _Distance);
			}
			else
			{
				FEAEGGCNIAA().SetFloat("ItemsCountText", _Distance);
			}
			MJJIEHANFJA().SetFloat("recipes", _Size);
			PLBEJJIHFPB().SetFloat("x", _FixDistance);
			LPPEPKGFOEM().SetFloat("Drop_With_Obj", LightIntensity * 366f);
			FGENHBKMPDA().SetFloat("_MainTex2", (!_Visualize) ? 1 : 1);
			IIBLJCKLGFG().SetFloat("Error: Timeout :S", _FadeShield);
			CIAFLBFJLEJ().SetFloat("00", Speed);
			FEAEGGCNIAA().SetFloat("_Value8", Speed_X);
			CIAFLBFJLEJ().SetFloat("OnSerialize", Speed_Y);
			GJHPODJOBHL().SetFloat("Internal LUT", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FLGPDBBKAIP().SetFloat("_TimeX", 562f / farClipPlane);
			ACHNOHCLGOO().SetVector("_CenterX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1576f, 846f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ALJEJJCIMJN()
	{
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JOPCCCCHNLI()
	{
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JGMEKCFHGLE()
	{
	}

	private void MJEFMIPLFAB()
	{
		SCShader = Shader.Find("SetSpeed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OOGIHDLBBLM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material MJJIEHANFJA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material PLBEJJIHFPB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material BFGNMFCNDBC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)108;
		}
		return BJFKDHHMLJH;
	}

	private void DNNFHBOOPIN()
	{
		SCShader = Shader.Find("Updating...");
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
			if (HBJJOCHGOPH > 191f)
			{
				HBJJOCHGOPH = 1974f;
			}
			HNICHJCGJOC().SetFloat("[GameScene] Checkpoints count: ", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 951f)
				{
					_Distance = 1486f;
				}
				if (_Distance < 412f)
				{
					_Distance = 50f;
				}
				DCCHGBHLAAF().SetFloat("HightScoreMaxPointsText", _Distance);
			}
			else
			{
				DCCHGBHLAAF().SetFloat("Using Stopwatch as precision timer for PUN.", _Distance);
			}
			BFGNMFCNDBC().SetFloat("#{0:X2}{1:X2}{2:X2}", _Size);
			KOHGPKOFEJO().SetFloat("/", _FixDistance);
			HJGEHJDMCGI().SetFloat("\n", LightIntensity * 756f);
			DEFBJOCJJKF().SetFloat("_StretchWidth", (!_Visualize) ? 1 : 1);
			PLBEJJIHFPB().SetFloat(".lastCheckpoint.correctScore", _FadeShield);
			LELKBCALFCF().SetFloat("_Value", Speed);
			DEFBJOCJJKF().SetFloat("No Name", Speed_X);
			FGENHBKMPDA().SetFloat("CameraFilterPack/FX_DigitalMatrixDistortion", Speed_Y);
			BFGNMFCNDBC().SetFloat("_Threshold", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HEINDEMCGIK().SetFloat("_PositionX", 1230f / farClipPlane);
			HNICHJCGJOC().SetVector("_Intensity", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 550f, 856f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CECJJMKLEAK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KHIGHFJKPFG()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LIBGAKMKHJJ()
	{
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DBEMDAJDDDA()
	{
		SCShader = Shader.Find("https://twitch.tv/intralism");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DPLLKHHLDBB()
	{
		SCShader = Shader.Find("musicVolume");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DIGHKAJILJH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IKIDIJLIGOH()
	{
	}

	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 353f)
			{
				HBJJOCHGOPH = 786f;
			}
			DEFBJOCJJKF().SetFloat("CameraFilterPack/OldFilm_Cutting1", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 317f)
				{
					_Distance = 317f;
				}
				if (_Distance < 1864f)
				{
					_Distance = 634f;
				}
				PLBEJJIHFPB().SetFloat("HiddenToggle", _Distance);
			}
			else
			{
				FLGPDBBKAIP().SetFloat("_ScreenResolution", _Distance);
			}
			NBPKMLMCHFN.SetFloat("mapselector.filter.favoriteonly", _Size);
			KEMAALEODNH().SetFloat("_Vignette", _FixDistance);
			LPPEPKGFOEM().SetFloat("ViewMenu", LightIntensity * 1352f);
			PLBEJJIHFPB().SetFloat("_TimeX", (!_Visualize) ? 0 : 0);
			OKJOKHGJHGF().SetFloat(".lastCheckpoint.correctScore", _FadeShield);
			DEFBJOCJJKF().SetFloat(".lastCheckpoint.incorrectScore", Speed);
			NBMPPNFKFLB().SetFloat("_BlurTexture", Speed_X);
			PLBEJJIHFPB().SetFloat("HPText", Speed_Y);
			PLBEJJIHFPB().SetFloat("_Threshhold", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FGENHBKMPDA().SetFloat("Metal", 291f / farClipPlane);
			MJJIEHANFJA().SetVector("Init", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 228f, 1505f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material CIAFLBFJLEJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void MMPHNFPPEHO()
	{
		SCShader = Shader.Find("_BlurCoe");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material ACHNOHCLGOO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void LECCHIAFGGE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LJIHHJOAJCN()
	{
	}

	private void ICDBMJKMIKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FKEJGBFDCAH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FHPFJBFCOOF()
	{
		SCShader = Shader.Find("[Sound Manager] Audio clip is null, cannot play sound");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 421f)
			{
				HBJJOCHGOPH = 1944f;
			}
			HNICHJCGJOC().SetFloat("_NoisePerChannel", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1003f)
				{
					_Distance = 27f;
				}
				if (_Distance < 1436f)
				{
					_Distance = 1100f;
				}
				CIAFLBFJLEJ().SetFloat("[SERVER] Selected mode: ", _Distance);
			}
			else
			{
				PGPEMMBJOOG().SetFloat("roomDescription", _Distance);
			}
			FLGPDBBKAIP().SetFloat("HighScaleShot", _Size);
			FKEOGPDLBDD().SetFloat("_Fade", _FixDistance);
			IIBLJCKLGFG().SetFloat("RestartButton", LightIntensity * 948f);
			MJJIEHANFJA().SetFloat("2hands", (!_Visualize) ? 0 : 0);
			FLGPDBBKAIP().SetFloat("menu.tabid", _FadeShield);
			HEINDEMCGIK().SetFloat("_Offsets", Speed);
			MJJIEHANFJA().SetFloat("11", Speed_X);
			LELKBCALFCF().SetFloat("Object ID. Case-Sensitive", Speed_Y);
			GJHPODJOBHL().SetFloat("ConnectUsingSettings() disabled the offline mode. No longer offline.", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			NBPKMLMCHFN.SetFloat("_GlowColor", 1988f / farClipPlane);
			FEAEGGCNIAA().SetVector("_MinVelocity", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 970f, 1074f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLGPDBBKAIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material OKJOKHGJHGF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void KFACDBHDAOD()
	{
	}

	[SpecialName]
	private Material IIBLJCKLGFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return BJFKDHHMLJH;
	}

	private void HLLHJIDOOGA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 445f)
			{
				HBJJOCHGOPH = 1000f;
			}
			ACHNOHCLGOO().SetFloat("Gameplay/particles", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1281f)
				{
					_Distance = 1006f;
				}
				if (_Distance < 1855f)
				{
					_Distance = 293f;
				}
				IIBLJCKLGFG().SetFloat("GlassColor", _Distance);
			}
			else
			{
				FEAEGGCNIAA().SetFloat("CameraFilterPack/Edge_Sigmoid", _Distance);
			}
			KEMAALEODNH().SetFloat("/", _Size);
			FEAEGGCNIAA().SetFloat("_Val", _FixDistance);
			DCCHGBHLAAF().SetFloat("CameraFilterPack/Distortion_Flush", LightIntensity * 1304f);
			CECJJMKLEAK().SetFloat("HPText", (!_Visualize) ? 1 : 0);
			PLBEJJIHFPB().SetFloat("ready", _FadeShield);
			OIIDAKBILMI().SetFloat("menutheme.deleted", Speed);
			FLGPDBBKAIP().SetFloat("Winter2020", Speed_X);
			OKJOKHGJHGF().SetFloat("ItemNameText", Speed_Y);
			LELKBCALFCF().SetFloat("/", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			GJHPODJOBHL().SetFloat("editor.", 1842f / farClipPlane);
			IIJMIPBMMBF().SetVector("_MainTex2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 14f, 72f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material FKEOGPDLBDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void CEAGPJBGBMH()
	{
		SCShader = Shader.Find("Joystick1Button0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material IGKFMCPDNOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)82;
		}
		return BJFKDHHMLJH;
	}

	private void CNDACAHCCOI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KOJKBFDNGDK()
	{
		SCShader = Shader.Find("settings.volume.game");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IDIIELPAMCJ()
	{
	}

	private void FMFNILJIEIA()
	{
		SCShader = Shader.Find("HandsCountSlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ODCJJFBJJNF()
	{
	}

	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1429f)
			{
				HBJJOCHGOPH = 1963f;
			}
			OIIDAKBILMI().SetFloat("_Value3", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1601f)
				{
					_Distance = 1391f;
				}
				if (_Distance < 1019f)
				{
					_Distance = 0f;
				}
				JFDGLLEOPGB().SetFloat("player.xp", _Distance);
			}
			else
			{
				BFGNMFCNDBC().SetFloat("ConfigVersionSlider", _Distance);
			}
			FLGPDBBKAIP().SetFloat("#TBD", _Size);
			FGENHBKMPDA().SetFloat("menu.relaxinfo", _FixDistance);
			JFDGLLEOPGB().SetFloat("/", LightIntensity * 320f);
			IIJMIPBMMBF().SetFloat("YES", (!_Visualize) ? 0 : 0);
			NBPKMLMCHFN.SetFloat("ComboText", _FadeShield);
			CIAFLBFJLEJ().SetFloat("menu.tabid", Speed);
			PGPEMMBJOOG().SetFloat("_Value4", Speed_X);
			CECJJMKLEAK().SetFloat("seconds", Speed_Y);
			BFGNMFCNDBC().SetFloat("Outgoing: \n", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			IIBLJCKLGFG().SetFloat("_ScreenResolution", 476f / farClipPlane);
			PGPEMMBJOOG().SetVector("UseScanLine", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 373f, 1925f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIBLJCKLGFG());
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
			if (HBJJOCHGOPH > 460f)
			{
				HBJJOCHGOPH = 1072f;
			}
			DCCHGBHLAAF().SetFloat("_Green_C", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 53f)
				{
					_Distance = 1682f;
				}
				if (_Distance < 973f)
				{
					_Distance = 233f;
				}
				HEINDEMCGIK().SetFloat("maps.", _Distance);
			}
			else
			{
				PGPEMMBJOOG().SetFloat(" isInactive: ", _Distance);
			}
			CIAFLBFJLEJ().SetFloat("settings_bindings_", _Size);
			PGPEMMBJOOG().SetFloat("Case-Sensitive", _FixDistance);
			PGPEMMBJOOG().SetFloat("_TimeX", LightIntensity * 1941f);
			JFDGLLEOPGB().SetFloat("seconds", (!_Visualize) ? 0 : 0);
			GJHPODJOBHL().SetFloat(" [", _FadeShield);
			OKJOKHGJHGF().SetFloat("_Value5", Speed);
			PLBEJJIHFPB().SetFloat("TimeBGSlider", Speed_X);
			LPPEPKGFOEM().SetFloat("_Intensity", Speed_Y);
			IIBLJCKLGFG().SetFloat("Expected protocol set to UDP, due to encryption mode DatagramEncryption. Changing protocol in PhotonServerSettings from: ", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			GJHPODJOBHL().SetFloat("1.87", 483f / farClipPlane);
			DEFBJOCJJKF().SetVector("_FadeDistance", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1735f, 81f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ILCFPCIPENO()
	{
		SCShader = Shader.Find("Health Stats");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NCPAFCKGJEA()
	{
	}

	private void NNBCLMJGFEN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1755f)
			{
				HBJJOCHGOPH = 618f;
			}
			PGPEMMBJOOG().SetFloat("SetSunColors", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1801f)
				{
					_Distance = 1985f;
				}
				if (_Distance < 513f)
				{
					_Distance = 839f;
				}
				NBPKMLMCHFN.SetFloat("B:", _Distance);
			}
			else
			{
				OKJOKHGJHGF().SetFloat("_ReflectionTexture4", _Distance);
			}
			DEFBJOCJJKF().SetFloat("ChallengesButton", _Size);
			JFDGLLEOPGB().SetFloat("Case-Sensitive", _FixDistance);
			LELKBCALFCF().SetFloat("If you host Photon yourself, make sure to start the 'Instance LoadBalancing' ", LightIntensity * 921f);
			FKEOGPDLBDD().SetFloat("SetLives", (!_Visualize) ? 1 : 0);
			LPPEPKGFOEM().SetFloat("BloomShaderValueSlider", _FadeShield);
			FLGPDBBKAIP().SetFloat(":", Speed);
			DCCHGBHLAAF().SetFloat("_Bullet_12", Speed_X);
			JFDGLLEOPGB().SetFloat("_ScreenResolution", Speed_Y);
			OIIDAKBILMI().SetFloat("colorB", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			NBPKMLMCHFN.SetFloat(" ", 1748f / farClipPlane);
			FEAEGGCNIAA().SetVector("curScn", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 746f, 1198f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPPEPKGFOEM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1111f)
			{
				HBJJOCHGOPH = 781f;
			}
			KEMAALEODNH().SetFloat("_TimeX", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 981f)
				{
					_Distance = 884f;
				}
				if (_Distance < 1824f)
				{
					_Distance = 1752f;
				}
				FGENHBKMPDA().SetFloat("f", _Distance);
			}
			else
			{
				ACHNOHCLGOO().SetFloat("#", _Distance);
			}
			OKJOKHGJHGF().SetFloat("{0} seconds ago", _Size);
			KEMAALEODNH().SetFloat("GhostPosY", _FixDistance);
			OKJOKHGJHGF().SetFloat(".", LightIntensity * 160f);
			JFDGLLEOPGB().SetFloat("_FlipAlphaMask", _Visualize ? 1 : 0);
			GJHPODJOBHL().SetFloat("_EmissionColor", _FadeShield);
			FKEOGPDLBDD().SetFloat(":", Speed);
			CIAFLBFJLEJ().SetFloat("Moved event", Speed_X);
			HEINDEMCGIK().SetFloat("Hex value #RRGGBB", Speed_Y);
			MJJIEHANFJA().SetFloat("[MenuScene] Error: ", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			LELKBCALFCF().SetFloat("CameraFilterPack/Vision_SniperScore", 1312f / farClipPlane);
			FGENHBKMPDA().SetVector("checkpoint", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1708f, 1200f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LELKBCALFCF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HAAFIECGECG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 801f)
			{
				HBJJOCHGOPH = 1973f;
			}
			FEAEGGCNIAA().SetFloat("_Value2", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1568f)
				{
					_Distance = 190f;
				}
				if (_Distance < 840f)
				{
					_Distance = 332f;
				}
				FGENHBKMPDA().SetFloat(" x ", _Distance);
			}
			else
			{
				HEINDEMCGIK().SetFloat(".", _Distance);
			}
			IGKFMCPDNOI().SetFloat("CameraFilterPack/FX_Mirror", _Size);
			MJJIEHANFJA().SetFloat("No", _FixDistance);
			CIAFLBFJLEJ().SetFloat("Items/", LightIntensity * 382f);
			DEFBJOCJJKF().SetFloat("_ScreenResolution", (!_Visualize) ? 1 : 1);
			IGKFMCPDNOI().SetFloat(".highscore", _FadeShield);
			HJGEHJDMCGI().SetFloat("RPC: 'OnAwakeRPC' PhotonView: ", Speed);
			PLBEJJIHFPB().SetFloat("y", Speed_X);
			HEINDEMCGIK().SetFloat("#obtained", Speed_Y);
			OKJOKHGJHGF().SetFloat("_LoopCount", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			BFGNMFCNDBC().SetFloat("EXCEPTION:", 633f / farClipPlane);
			LELKBCALFCF().SetVector("saveGameName ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 761f, 1873f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 206f)
			{
				HBJJOCHGOPH = 203f;
			}
			FKEOGPDLBDD().SetFloat("_ArScale", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1706f)
				{
					_Distance = 1121f;
				}
				if (_Distance < 1598f)
				{
					_Distance = 32f;
				}
				LELKBCALFCF().SetFloat("_Value4", _Distance);
			}
			else
			{
				IGKFMCPDNOI().SetFloat("_Contrast", _Distance);
			}
			IGKFMCPDNOI().SetFloat("ResourceFileSelector", _Size);
			HNICHJCGJOC().SetFloat("maps.", _FixDistance);
			IGKFMCPDNOI().SetFloat("LevelInfoInputField", LightIntensity * 1874f);
			DEFBJOCJJKF().SetFloat("_ScreenResolution", (!_Visualize) ? 1 : 0);
			IIBLJCKLGFG().SetFloat("_ScreenResolution", _FadeShield);
			IIJMIPBMMBF().SetFloat("tagElement", Speed);
			DEFBJOCJJKF().SetFloat("CameraFilterPack/Blend2Camera_Overlay", Speed_X);
			CIAFLBFJLEJ().SetFloat(".lastCheckpoint.bgcolor", Speed_Y);
			MJJIEHANFJA().SetFloat("shader.future", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			NBMPPNFKFLB().SetFloat("_Value4", 1846f / farClipPlane);
			FGENHBKMPDA().SetVector("mapid", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1083f, 980f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CIAFLBFJLEJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/3D_Shield");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OMIHEBMMCPG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 638f)
			{
				HBJJOCHGOPH = 933f;
			}
			MJJIEHANFJA().SetFloat("[Left]", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1054f)
				{
					_Distance = 855f;
				}
				if (_Distance < 202f)
				{
					_Distance = 1727f;
				}
				OIIDAKBILMI().SetFloat("CameraFilterPack/Drawing_BluePrint", _Distance);
			}
			else
			{
				HNICHJCGJOC().SetFloat("PlayButton", _Distance);
			}
			PLBEJJIHFPB().SetFloat("settings_bindings_controller_type", _Size);
			ACHNOHCLGOO().SetFloat("_BlurVector", _FixDistance);
			LELKBCALFCF().SetFloat(" SphereWaveform.cs", LightIntensity * 499f);
			KEMAALEODNH().SetFloat("_ReflectionTexture0", (!_Visualize) ? 1 : 1);
			HJGEHJDMCGI().SetFloat("replayData", _FadeShield);
			IGKFMCPDNOI().SetFloat("ok", Speed);
			NBMPPNFKFLB().SetFloat("_Value", Speed_X);
			IIJMIPBMMBF().SetFloat("There are a few rules that you must accept before submitting your work. Please select \"RULES\" button, if you haven't read them yet.", Speed_Y);
			CECJJMKLEAK().SetFloat("_TimeX", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			CIAFLBFJLEJ().SetFloat("Joystick1Button2", 1954f / farClipPlane);
			FEAEGGCNIAA().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1690f, 1609f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material FEAEGGCNIAA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-73);
		}
		return BJFKDHHMLJH;
	}

	private void OFMNDBNFBDJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CFFCLAHMBAA()
	{
		SCShader = Shader.Find("wss://");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 749f)
			{
				HBJJOCHGOPH = 780f;
			}
			FLGPDBBKAIP().SetFloat("FavoriteButton", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 890f)
				{
					_Distance = 335f;
				}
				if (_Distance < 1578f)
				{
					_Distance = 815f;
				}
				LPPEPKGFOEM().SetFloat("1248864821", _Distance);
			}
			else
			{
				IIJMIPBMMBF().SetFloat("_Value3", _Distance);
			}
			LELKBCALFCF().SetFloat("[FileSelector] Dialog canceled", _Size);
			NBPKMLMCHFN.SetFloat("DestroyPlayerObjects() failed, cause parameter 'targetPlayer' was null.", _FixDistance);
			ACHNOHCLGOO().SetFloat("InfoCanvas", LightIntensity * 1262f);
			PLBEJJIHFPB().SetFloat("_ChannelMixerRed", (!_Visualize) ? 0 : 0);
			IIJMIPBMMBF().SetFloat("Sending RPC \"", _FadeShield);
			HNICHJCGJOC().SetFloat("#no", Speed);
			FEAEGGCNIAA().SetFloat("GlassAberration", Speed_X);
			HNICHJCGJOC().SetFloat("#highscore", Speed_Y);
			HNICHJCGJOC().SetFloat(".", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			CIAFLBFJLEJ().SetFloat("TypedLobbyInfo '{0}'[{1}] rooms: {2} players: {3}", 741f / farClipPlane);
			HNICHJCGJOC().SetVector("Alpha", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 954f, 1416f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AEEGKLABFLN()
	{
	}

	[SpecialName]
	private Material NBMPPNFKFLB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)86;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material CECJJMKLEAK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material FGENHBKMPDA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-117);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IIJMIPBMMBF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	private void ABEIEGDHBNO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HHKBBEFJEBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 194f)
			{
				HBJJOCHGOPH = 313f;
			}
			KEMAALEODNH().SetFloat("menu.tabid", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1335f)
				{
					_Distance = 479f;
				}
				if (_Distance < 91f)
				{
					_Distance = 1495f;
				}
				MJJIEHANFJA().SetFloat("_Value6", _Distance);
			}
			else
			{
				DEFBJOCJJKF().SetFloat("CameraFilterPack/Oculus_ThermaVision", _Distance);
			}
			NBMPPNFKFLB().SetFloat("EnableRankedNotificationsToggle", _Size);
			IGKFMCPDNOI().SetFloat("STICKLVER", _FixDistance);
			GJHPODJOBHL().SetFloat("The region arrays from Name Server are not ok. Must be non-null and same length. ", LightIntensity * 1990f);
			JFDGLLEOPGB().SetFloat("1", (!_Visualize) ? 1 : 1);
			NBPKMLMCHFN.SetFloat("\nCreated by Oxy949", _FadeShield);
			BFGNMFCNDBC().SetFloat("UseScanLineSize", Speed);
			DCCHGBHLAAF().SetFloat("]", Speed_X);
			LELKBCALFCF().SetFloat("#outdatedmap! Challenges will not work!", Speed_Y);
			HNICHJCGJOC().SetFloat("_Curve", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			KEMAALEODNH().SetFloat("_SpawnHeuristic", 359f / farClipPlane);
			OKJOKHGJHGF().SetVector("_PrefilterOffs", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 438f, 586f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PJIFJFENPJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1661f)
			{
				HBJJOCHGOPH = 1430f;
			}
			GJHPODJOBHL().SetFloat("_Value3", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 542f)
				{
					_Distance = 1226f;
				}
				if (_Distance < 1150f)
				{
					_Distance = 654f;
				}
				LELKBCALFCF().SetFloat("Children", _Distance);
			}
			else
			{
				DCCHGBHLAAF().SetFloat("_ScreenResolution", _Distance);
			}
			KOHGPKOFEJO().SetFloat("Delete events", _Size);
			NBPKMLMCHFN.SetFloat("bpmgrid", _FixDistance);
			CIAFLBFJLEJ().SetFloat("SetEnvSpriteColor", LightIntensity * 511f);
			OKJOKHGJHGF().SetFloat("masterSteamID", (!_Visualize) ? 1 : 0);
			DEFBJOCJJKF().SetFloat("_ForceYSwap", _FadeShield);
			KEMAALEODNH().SetFloat("[NetworkManager] Joined main lobby", Speed);
			CIAFLBFJLEJ().SetFloat("EventMenu", Speed_X);
			PGPEMMBJOOG().SetFloat("#ok", Speed_Y);
			FKEOGPDLBDD().SetFloat("ChangeSelectedLevel", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			BFGNMFCNDBC().SetFloat("_Green_C", 908f / farClipPlane);
			NBMPPNFKFLB().SetVector("_FullResolutionFiltering", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1271f, 839f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPPEPKGFOEM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OHFOLGANOLC()
	{
		SCShader = Shader.Find("VIGNETTE_BLUR");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HIPBNBKNICE()
	{
	}

	private void BFGIMALGMAJ()
	{
	}

	[SpecialName]
	private Material KEMAALEODNH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void IMCKJCHKMKB()
	{
		SCShader = Shader.Find("maps.");
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

	private void LFBGJIIECLD()
	{
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FJKJGBLPDGG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 55f)
			{
				HBJJOCHGOPH = 1157f;
			}
			KEMAALEODNH().SetFloat("_TimeX", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 913f)
				{
					_Distance = 1486f;
				}
				if (_Distance < 1007f)
				{
					_Distance = 1047f;
				}
				PLBEJJIHFPB().SetFloat("_FixDistance", _Distance);
			}
			else
			{
				LPPEPKGFOEM().SetFloat("UseScanLine", _Distance);
			}
			JFDGLLEOPGB().SetFloat("_FarCamera", _Size);
			DCCHGBHLAAF().SetFloat("CameraFilterPack/TV_WideScreenHorizontal", _FixDistance);
			LELKBCALFCF().SetFloat("_TimeX", LightIntensity * 964f);
			NBPKMLMCHFN.SetFloat("settings.enablehitsoundsinnormal", _Visualize ? 1 : 0);
			NBMPPNFKFLB().SetFloat("_TimeX", _FadeShield);
			HNICHJCGJOC().SetFloat("_FixDistance", Speed);
			LPPEPKGFOEM().SetFloat("_Intensity", Speed_X);
			PLBEJJIHFPB().SetFloat("Drop_With_Obj", Speed_Y);
			FKEOGPDLBDD().SetFloat("/", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			NBMPPNFKFLB().SetFloat("maps.", 1047f / farClipPlane);
			NBMPPNFKFLB().SetVector("Can not SetMasterClient(). Not in room or in offlineMode.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 257f, 530f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JONGNKNLLND()
	{
		SCShader = Shader.Find("\" for viewID ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JIAAFKOPEKO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 411f)
			{
				HBJJOCHGOPH = 1348f;
			}
			IIJMIPBMMBF().SetFloat("masterSteamID", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 787f)
				{
					_Distance = 1812f;
				}
				if (_Distance < 1740f)
				{
					_Distance = 1785f;
				}
				IIBLJCKLGFG().SetFloat("_Bullet_6", _Distance);
			}
			else
			{
				FLGPDBBKAIP().SetFloat("#random #rare #item", _Distance);
			}
			CECJJMKLEAK().SetFloat("_Value4", _Size);
			MJJIEHANFJA().SetFloat("LT", _FixDistance);
			PLBEJJIHFPB().SetFloat("{0}", LightIntensity * 1389f);
			LELKBCALFCF().SetFloat("_ScreenResolution", (!_Visualize) ? 0 : 0);
			OIIDAKBILMI().SetFloat("#exit", _FadeShield);
			CECJJMKLEAK().SetFloat("CameraFilterPack/Drawing_Crosshatch", Speed);
			CECJJMKLEAK().SetFloat("Drop_With_Obj", Speed_X);
			FEAEGGCNIAA().SetFloat("help", Speed_Y);
			HJGEHJDMCGI().SetFloat("inventory.itemscash", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			OIIDAKBILMI().SetFloat("_Value", 740f / farClipPlane);
			HNICHJCGJOC().SetVector("_PosY", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 458f, 1289f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DFFKKLAPHCC()
	{
		SCShader = Shader.Find("Paste events");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1053f)
			{
				HBJJOCHGOPH = 623f;
			}
			KEMAALEODNH().SetFloat("SettingsCanvas", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 472f)
				{
					_Distance = 1387f;
				}
				if (_Distance < 574f)
				{
					_Distance = 880f;
				}
				PLBEJJIHFPB().SetFloat("_Value5", _Distance);
			}
			else
			{
				IGKFMCPDNOI().SetFloat("_TimeX", _Distance);
			}
			FGENHBKMPDA().SetFloat("  |  Events Count: ", _Size);
			BFGNMFCNDBC().SetFloat("_Value2", _FixDistance);
			NBMPPNFKFLB().SetFloat("offsets", LightIntensity * 1006f);
			FLGPDBBKAIP().SetFloat("_Visualize", (!_Visualize) ? 0 : 0);
			IIBLJCKLGFG().SetFloat("offsets", _FadeShield);
			FGENHBKMPDA().SetFloat("LivesSlider", Speed);
			PGPEMMBJOOG().SetFloat("UI/Particles/Hidden", Speed_X);
			OIIDAKBILMI().SetFloat("/config", Speed_Y);
			DCCHGBHLAAF().SetFloat("_Value6", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FEAEGGCNIAA().SetFloat("Have you fully accept the terms?", 194f / farClipPlane);
			JFDGLLEOPGB().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 57f, 157f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DCCHGBHLAAF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LELKBCALFCF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)102;
		}
		return BJFKDHHMLJH;
	}

	private void AEMGPJDJGBJ()
	{
		SCShader = Shader.Find("[");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material HJGEHJDMCGI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-74);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material GJHPODJOBHL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material OIIDAKBILMI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void PHJJHFBLICM()
	{
	}

	private void Update()
	{
	}

	private void AGEJKLMJGDO()
	{
		SCShader = Shader.Find("BitsData");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CMIBEOJGAIL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FMNPFCHBLJF()
	{
		SCShader = Shader.Find("SetParticlesCountPerBeat");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BMOFEBKGLFI()
	{
		SCShader = Shader.Find("CameraFilterPack/Atmosphere_Rain");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FANADGBGCPI()
	{
		SCShader = Shader.Find("_SSAO");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ODMPMJPALID()
	{
		SCShader = Shader.Find("_SoftZDistance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material KOHGPKOFEJO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-1);
		}
		return BJFKDHHMLJH;
	}

	private void ALMGMOOHLMA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CCPEDDLAMIB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
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
			NBPKMLMCHFN.SetFloat("_LightIntensity", LightIntensity * 64f);
			NBPKMLMCHFN.SetFloat("_Visualize", _Visualize ? 1 : 0);
			NBPKMLMCHFN.SetFloat("_FadeShield", _FadeShield);
			NBPKMLMCHFN.SetFloat("_Value", Speed);
			NBPKMLMCHFN.SetFloat("_Value2", Speed_X);
			NBPKMLMCHFN.SetFloat("_Value3", Speed_Y);
			NBPKMLMCHFN.SetFloat("_Value4", Intensity);
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

	private void DDFCIOMKEEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1192f)
			{
				HBJJOCHGOPH = 852f;
			}
			CECJJMKLEAK().SetFloat(", ", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 372f)
				{
					_Distance = 589f;
				}
				if (_Distance < 992f)
				{
					_Distance = 312f;
				}
				IIBLJCKLGFG().SetFloat("_Value2", _Distance);
			}
			else
			{
				IIJMIPBMMBF().SetFloat("_Value2", _Distance);
			}
			IIBLJCKLGFG().SetFloat("_TimeX", _Size);
			GJHPODJOBHL().SetFloat("_PixelsPerMeterAtOneMeter", _FixDistance);
			PGPEMMBJOOG().SetFloat("Spawn new environment sprite (image) and sets its id", LightIntensity * 1613f);
			OKJOKHGJHGF().SetFloat("[PlayerBase] MapEnd error: ", (!_Visualize) ? 1 : 0);
			GJHPODJOBHL().SetFloat("[ResourcesManager] Load text error: not found", _FadeShield);
			CIAFLBFJLEJ().SetFloat("Identity LUT", Speed);
			ACHNOHCLGOO().SetFloat("status", Speed_X);
			FEAEGGCNIAA().SetFloat("New resource ID. Case-Sensitive", Speed_Y);
			LPPEPKGFOEM().SetFloat("settings.arcsnohitsoundtimedelay", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			OKJOKHGJHGF().SetFloat("Data", 692f / farClipPlane);
			FGENHBKMPDA().SetVector("Editor/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1993f, 1354f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CEDFFAOOPOG()
	{
		SCShader = Shader.Find("CameraFilterPack/FX_Drunk2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material FLGPDBBKAIP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void EFJDNLGNACH()
	{
		SCShader = Shader.Find("workshop.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PKGJJFIFLII()
	{
	}

	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1886f)
			{
				HBJJOCHGOPH = 742f;
			}
			HEINDEMCGIK().SetFloat("_AdaptationMin", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 568f)
				{
					_Distance = 1850f;
				}
				if (_Distance < 1242f)
				{
					_Distance = 1030f;
				}
				IIBLJCKLGFG().SetFloat("/?player=", _Distance);
			}
			else
			{
				HJGEHJDMCGI().SetFloat("Paste events", _Distance);
			}
			FKEOGPDLBDD().SetFloat("Unsupported target enum: ", _Size);
			OIIDAKBILMI().SetFloat("Set object anchor to another object", _FixDistance);
			LPPEPKGFOEM().SetFloat(".highscore", LightIntensity * 628f);
			DCCHGBHLAAF().SetFloat("ItemNameBGImage", (!_Visualize) ? 1 : 0);
			IIJMIPBMMBF().SetFloat("_TimeX", _FadeShield);
			OKJOKHGJHGF().SetFloat("_TimeX", Speed);
			HEINDEMCGIK().SetFloat(" player(s)", Speed_X);
			DEFBJOCJJKF().SetFloat("_Value2", Speed_Y);
			FLGPDBBKAIP().SetFloat("#rategameinfo", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			CIAFLBFJLEJ().SetFloat("CameraFilterPack/Distortion_BlackHole", 1368f / farClipPlane);
			IGKFMCPDNOI().SetVector("[NetworkManager] Join failed", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1117f, 1285f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FOAGAKFBIGD()
	{
	}

	private void CGBHOELMAOC()
	{
	}

	private void ONMGIPAILOH()
	{
	}

	[SpecialName]
	private Material HNICHJCGJOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void DEEPMOLMGED()
	{
	}

	private void GNJDKAECPKA()
	{
		SCShader = Shader.Find("EventData0DropDownList");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material DEFBJOCJJKF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.HideInHierarchy | HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void DKGBFNCOAEO()
	{
		SCShader = Shader.Find("[PlayerBase] Loading checkpoint data");
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
			BJFKDHHMLJH.hideFlags = (HideFlags)126;
		}
		return BJFKDHHMLJH;
	}

	private void AAEEHINDPNC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ANDELGODEOC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EIDKCANPHJE()
	{
	}

	private void EIMNPCMHJLJ()
	{
		SCShader = Shader.Find("_TileTexDebug");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material HEINDEMCGIK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)116;
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

	private void ADPLHDFJFID()
	{
		SCShader = Shader.Find("_Value7");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JKFDDNMPOJH()
	{
		SCShader = Shader.Find("PlayMusic");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ELDMKIAPNGP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JHPOIOELNCG()
	{
	}

	private void KMOCDAOKGLI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JOACBIEHHCE()
	{
	}

	private void JECMJNFGBGC()
	{
		SCShader = Shader.Find("_EmissionColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EGEGNHLODAA()
	{
	}

	private void ONKDMMJPEMN()
	{
	}

	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1920f)
			{
				HBJJOCHGOPH = 1069f;
			}
			OIIDAKBILMI().SetFloat("[Down]", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1641f)
				{
					_Distance = 1760f;
				}
				if (_Distance < 1434f)
				{
					_Distance = 1877f;
				}
				HNICHJCGJOC().SetFloat("_MiddleGrey", _Distance);
			}
			else
			{
				OKJOKHGJHGF().SetFloat("_Value", _Distance);
			}
			KEMAALEODNH().SetFloat("_ScreenResolution", _Size);
			HEINDEMCGIK().SetFloat("[ERROR KEY {0}]", _FixDistance);
			LELKBCALFCF().SetFloat(": ", LightIntensity * 558f);
			LPPEPKGFOEM().SetFloat("SetParticlesParticleSize", (!_Visualize) ? 0 : 0);
			OKJOKHGJHGF().SetFloat("bad", _FadeShield);
			DCCHGBHLAAF().SetFloat("SpawnObj", Speed);
			PGPEMMBJOOG().SetFloat("_Value", Speed_X);
			CECJJMKLEAK().SetFloat("_CenterX", Speed_Y);
			DEFBJOCJJKF().SetFloat("{0:0} day{1}, ", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HEINDEMCGIK().SetFloat("[ResourcesManager] Load text error: not found", 401f / farClipPlane);
			CECJJMKLEAK().SetVector("offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 307f, 435f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IFJDKDFLGBG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1599f)
			{
				HBJJOCHGOPH = 1084f;
			}
			DCCHGBHLAAF().SetFloat("[SERVER] Selected mode: ", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 273f)
				{
					_Distance = 1339f;
				}
				if (_Distance < 945f)
				{
					_Distance = 1105f;
				}
				IGKFMCPDNOI().SetFloat("true", _Distance);
			}
			else
			{
				IGKFMCPDNOI().SetFloat("[PlayerController] ", _Distance);
			}
			MJJIEHANFJA().SetFloat("_MatrixColor", _Size);
			GJHPODJOBHL().SetFloat("_SSAO", _FixDistance);
			LPPEPKGFOEM().SetFloat(" / ", LightIntensity * 726f);
			FEAEGGCNIAA().SetFloat("z", (!_Visualize) ? 1 : 1);
			OIIDAKBILMI().SetFloat("_VignettingDirt", _FadeShield);
			FGENHBKMPDA().SetFloat("ItemsCountText", Speed);
			FKEOGPDLBDD().SetFloat("_Offsets", Speed_X);
			ACHNOHCLGOO().SetFloat("player.bat", Speed_Y);
			FEAEGGCNIAA().SetFloat("_TimeX", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			CECJJMKLEAK().SetFloat("Cant send PickupItem spawn times to unknown targetPlayer.", 1818f / farClipPlane);
			IIJMIPBMMBF().SetVector("Hidden/DepthOfField/MedianFilter", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1933f, 346f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 353f)
			{
				HBJJOCHGOPH = 1128f;
			}
			CECJJMKLEAK().SetFloat("StartButton", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1857f)
				{
					_Distance = 195f;
				}
				if (_Distance < 1153f)
				{
					_Distance = 810f;
				}
				PGPEMMBJOOG().SetFloat("_Luminance", _Distance);
			}
			else
			{
				NBMPPNFKFLB().SetFloat("menu.selectedplaymode", _Distance);
			}
			IIJMIPBMMBF().SetFloat("_PositionX", _Size);
			KOHGPKOFEJO().SetFloat("[Right]", _FixDistance);
			FLGPDBBKAIP().SetFloat("_Value3", LightIntensity * 1933f);
			KOHGPKOFEJO().SetFloat("SaveButton", (!_Visualize) ? 1 : 0);
			DEFBJOCJJKF().SetFloat("FinalScoreSmallText", _FadeShield);
			IGKFMCPDNOI().SetFloat("Editor", Speed);
			MJJIEHANFJA().SetFloat("StartTime already set: ", Speed_X);
			IIBLJCKLGFG().SetFloat("_Value3", Speed_Y);
			MJJIEHANFJA().SetFloat("SetEnvSpriteImage", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			DCCHGBHLAAF().SetFloat("_Value", 82f / farClipPlane);
			FKEOGPDLBDD().SetVector("_MainTex2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 699f, 1494f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LELKBCALFCF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IBPAMDEAGJL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LBAJLLFMMMP()
	{
		SCShader = Shader.Find("SpawnObj");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PGMMBADJIKH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LIEGJOHINGC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void POJFHDFJOPE()
	{
	}

	private void BMBIGILMLLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1241f)
			{
				HBJJOCHGOPH = 1114f;
			}
			FKEOGPDLBDD().SetFloat("CameraFilterPack/Light_Rainbow", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1225f)
				{
					_Distance = 1142f;
				}
				if (_Distance < 1545f)
				{
					_Distance = 15f;
				}
				DEFBJOCJJKF().SetFloat("_Value", _Distance);
			}
			else
			{
				ACHNOHCLGOO().SetFloat("Up", _Distance);
			}
			GJHPODJOBHL().SetFloat("_ScreenResolution", _Size);
			HEINDEMCGIK().SetFloat("_Near", _FixDistance);
			FEAEGGCNIAA().SetFloat("_UserLutTex", LightIntensity * 93f);
			PLBEJJIHFPB().SetFloat("JoinOrCreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", (!_Visualize) ? 1 : 1);
			DCCHGBHLAAF().SetFloat("_Color_R", _FadeShield);
			MJJIEHANFJA().SetFloat("CameraFilterPack/Blend2Camera_Subtract", Speed);
			JFDGLLEOPGB().SetFloat("Tab2Content", Speed_X);
			CIAFLBFJLEJ().SetFloat("value", Speed_Y);
			DCCHGBHLAAF().SetFloat("Texture2", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			JFDGLLEOPGB().SetFloat("_Amount", 425f / farClipPlane);
			LPPEPKGFOEM().SetVector("_ColorR", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 854f, 684f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LELKBCALFCF());
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
			if (HBJJOCHGOPH > 213f)
			{
				HBJJOCHGOPH = 1571f;
			}
			LELKBCALFCF().SetFloat("MaxLivesSlider", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1095f)
				{
					_Distance = 1446f;
				}
				if (_Distance < 17f)
				{
					_Distance = 977f;
				}
				HJGEHJDMCGI().SetFloat("/", _Distance);
			}
			else
			{
				FGENHBKMPDA().SetFloat("_Value1", _Distance);
			}
			LPPEPKGFOEM().SetFloat("Editor/", _Size);
			KOHGPKOFEJO().SetFloat("\n", _FixDistance);
			LPPEPKGFOEM().SetFloat("closed", LightIntensity * 1931f);
			FKEOGPDLBDD().SetFloat("_FixDistance", (!_Visualize) ? 0 : 0);
			NBMPPNFKFLB().SetFloat("_BlurRadius4", _FadeShield);
			PGPEMMBJOOG().SetFloat("DestroyPlayerObjects() failed, cause parameter 'targetPlayer' was null.", Speed);
			MJJIEHANFJA().SetFloat("#task", Speed_X);
			BFGNMFCNDBC().SetFloat("CameraFilterPack/Blend2Camera_Darken", Speed_Y);
			GJHPODJOBHL().SetFloat("_Light2", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			MJJIEHANFJA().SetFloat("_TimeX", 910f / farClipPlane);
			IGKFMCPDNOI().SetVector("BloodAlternative3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 633f, 1029f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NBGIMIDICKE()
	{
		SCShader = Shader.Find("_PColor2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DIPDEHOOBPG()
	{
		SCShader = Shader.Find("\\n");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}
}
