// CameraFilterPack_3D_Shield
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/3D/Shield")]
[ExecuteInEditMode]
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
			FLGPDBBKAIP().SetFloat("_TimeX", HBJJOCHGOPH);
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
				MJJIEHANFJA().SetFloat("Bad parameters for getstring! Use <key> <value>", _Distance);
			}
			else
			{
				GJHPODJOBHL().SetFloat("ItemsCountText", _Distance);
			}
			OKJOKHGJHGF().SetFloat("#or", _Size);
			GJHPODJOBHL().SetFloat("y", _FixDistance);
			JFDGLLEOPGB().SetFloat("Drop_With_Obj", LightIntensity * 366f);
			OIIDAKBILMI().SetFloat("_Speed", (!_Visualize) ? 1 : 1);
			OIIDAKBILMI().SetFloat("Item creation successful! Published Item ID: ", _FadeShield);
			FGENHBKMPDA().SetFloat("00", Speed);
			DCCHGBHLAAF().SetFloat("_Value8", Speed_X);
			KOHGPKOFEJO().SetFloat("GameObject ", Speed_Y);
			IIJMIPBMMBF().SetFloat("_CurrentMipLevel", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FKEOGPDLBDD().SetFloat("CameraFilterPack/FX_ZebraColor", 562f / farClipPlane);
			DEFBJOCJJKF().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1576f, 846f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ALJEJJCIMJN()
	{
		SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JOPCCCCHNLI()
	{
		SCShader = Shader.Find("_Value3");
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
		SCShader = Shader.Find("/");
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
		SCShader = Shader.Find("Ok");
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
			OIIDAKBILMI().SetFloat("Map: ", HBJJOCHGOPH);
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
				OIIDAKBILMI().SetFloat("HightScoreMaxPointsText", _Distance);
			}
			else
			{
				MJJIEHANFJA().SetFloat("PhotonServerSettings", _Distance);
			}
			DEFBJOCJJKF().SetFloat("_MainTex", _Size);
			LPPEPKGFOEM().SetFloat("/../", _FixDistance);
			HNICHJCGJOC().SetFloat(":", LightIntensity * 756f);
			NBMPPNFKFLB().SetFloat("_Saturation", (!_Visualize) ? 1 : 1);
			IGKFMCPDNOI().SetFloat(".lastCheckpoint.time", _FadeShield);
			DEFBJOCJJKF().SetFloat("CameraFilterPack/Vision_Plasma", Speed);
			KEMAALEODNH().SetFloat("icon.png", Speed_X);
			OIIDAKBILMI().SetFloat("_ScreenResolution", Speed_Y);
			JFDGLLEOPGB().SetFloat("_TimeX", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FEAEGGCNIAA().SetFloat("_PositionX", 1230f / farClipPlane);
			HNICHJCGJOC().SetVector("offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 550f, 856f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KHIGHFJKPFG()
	{
		SCShader = Shader.Find("_Radius");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LIBGAKMKHJJ()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DBEMDAJDDDA()
	{
		SCShader = Shader.Find("https://discord.gg/intralism");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DPLLKHHLDBB()
	{
		SCShader = Shader.Find("sfxVolume");
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
			FKEOGPDLBDD().SetFloat("CameraFilterPack_OldFilm1", HBJJOCHGOPH);
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
				ACHNOHCLGOO().SetFloat("OneHand", _Distance);
			}
			else
			{
				KEMAALEODNH().SetFloat("_TimeX", _Distance);
			}
			ACHNOHCLGOO().SetFloat("mapselector.filter.officialsortmode", _Size);
			IIBLJCKLGFG().SetFloat("_Greenness", _FixDistance);
			PLBEJJIHFPB().SetFloat("ViewMenu", LightIntensity * 1352f);
			HNICHJCGJOC().SetFloat("CameraFilterPack/Film_Grain", (!_Visualize) ? 0 : 0);
			FKEOGPDLBDD().SetFloat(".lastCheckpoint.isMapCompleted", _FadeShield);
			DCCHGBHLAAF().SetFloat(".lastCheckpoint.checkpointsUsed", Speed);
			CIAFLBFJLEJ().SetFloat("_ReflectionTexture3", Speed_X);
			CIAFLBFJLEJ().SetFloat("HPText", Speed_Y);
			BFGNMFCNDBC().SetFloat("_CurveParams", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FEAEGGCNIAA().SetFloat("Metal", 291f / farClipPlane);
			IIBLJCKLGFG().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 228f, 1505f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHPODJOBHL());
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
		SCShader = Shader.Find("_Offsets");
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
		SCShader = Shader.Find("sounds/hit_normal");
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
			HEINDEMCGIK().SetFloat("_NoiseTex", HBJJOCHGOPH);
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
				FGENHBKMPDA().SetFloat("[SERVER] Selected mode: ", _Distance);
			}
			else
			{
				IIJMIPBMMBF().SetFloat("roomDescription", _Distance);
			}
			FGENHBKMPDA().SetFloat("HighScaleShot", _Size);
			CECJJMKLEAK().SetFloat("_Wavy", _FixDistance);
			LPPEPKGFOEM().SetFloat("RestartButton", LightIntensity * 948f);
			CECJJMKLEAK().SetFloat("MainCamera", (!_Visualize) ? 0 : 0);
			HNICHJCGJOC().SetFloat("menu.tabid", _FadeShield);
			LELKBCALFCF().SetFloat("_Offsets", Speed);
			FKEOGPDLBDD().SetFloat("Day_", Speed_X);
			NBPKMLMCHFN.SetFloat("id", Speed_Y);
			IIJMIPBMMBF().SetFloat("ConnectUsingSettings() failed. Can only connect while in state 'Disconnected'. Current state: ", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			KEMAALEODNH().SetFloat("_Value3", 1988f / farClipPlane);
			KEMAALEODNH().SetVector("_BlurDirectionPacked", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 970f, 1074f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIIDAKBILMI());
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
			KEMAALEODNH().SetFloat("/Segment-[Left]", HBJJOCHGOPH);
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
				NBPKMLMCHFN.SetFloat("GlassesColor2", _Distance);
			}
			else
			{
				FGENHBKMPDA().SetFloat("_ScreenResolution", _Distance);
			}
			HNICHJCGJOC().SetFloat(".png", _Size);
			HNICHJCGJOC().SetFloat("_Sat", _FixDistance);
			NBMPPNFKFLB().SetFloat("_ScreenResolution", LightIntensity * 1304f);
			OIIDAKBILMI().SetFloat("settings.showHP", (!_Visualize) ? 1 : 0);
			GJHPODJOBHL().SetFloat("ready", _FadeShield);
			HJGEHJDMCGI().SetFloat("menutheme.jamaicanorcdub", Speed);
			FGENHBKMPDA().SetFloat("Winter2020", Speed_X);
			OKJOKHGJHGF().SetFloat("RarityImage", Speed_Y);
			PGPEMMBJOOG().SetFloat("/../", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			OIIDAKBILMI().SetFloat("Editor/", 1842f / farClipPlane);
			HNICHJCGJOC().SetVector("CameraFilterPack/Blend2Camera_GreenScreen", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 14f, 72f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HJGEHJDMCGI());
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
		SCShader = Shader.Find("Joystick1Button12");
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
		SCShader = Shader.Find("settings.volume.editor");
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
		SCShader = Shader.Find("EnvironmentSlider");
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
			DCCHGBHLAAF().SetFloat("_Value3", HBJJOCHGOPH);
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
				FKEOGPDLBDD().SetFloat("player.xp", _Distance);
			}
			else
			{
				FKEOGPDLBDD().SetFloat("Tab1Content", _Distance);
			}
			NBPKMLMCHFN.SetFloat(">", _Size);
			DCCHGBHLAAF().SetFloat("menu.selectedplaymode", _FixDistance);
			OKJOKHGJHGF().SetFloat("OK", LightIntensity * 320f);
			HJGEHJDMCGI().SetFloat("YES", (!_Visualize) ? 0 : 0);
			HJGEHJDMCGI().SetFloat("HPText", _FadeShield);
			JFDGLLEOPGB().SetFloat("menu.tabid", Speed);
			MJJIEHANFJA().SetFloat("_Value3", Speed_X);
			LPPEPKGFOEM().SetFloat("seconds", Speed_Y);
			ACHNOHCLGOO().SetFloat("To Log", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FEAEGGCNIAA().SetFloat("_ScreenResolution", 476f / farClipPlane);
			KOHGPKOFEJO().SetVector("UseScanLineSize", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 373f, 1925f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
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
			PGPEMMBJOOG().SetFloat("_Green_C", HBJJOCHGOPH);
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
				PGPEMMBJOOG().SetFloat(".highscore", _Distance);
			}
			else
			{
				NBMPPNFKFLB().SetFloat("Received event Leave for unknown player ID: {0}", _Distance);
			}
			OKJOKHGJHGF().SetFloat("settings_bindings_controller_type", _Size);
			JFDGLLEOPGB().SetFloat("id", _FixDistance);
			NBMPPNFKFLB().SetFloat("_MainTex2", LightIntensity * 1941f);
			DEFBJOCJJKF().SetFloat("fade out duration", (!_Visualize) ? 0 : 0);
			IIJMIPBMMBF().SetFloat("NameText", _FadeShield);
			CECJJMKLEAK().SetFloat("_Value4", Speed);
			PLBEJJIHFPB().SetFloat("TimeBGSlider", Speed_X);
			FLGPDBBKAIP().SetFloat("offsets", Speed_Y);
			GJHPODJOBHL().SetFloat("Error calling OpAuthenticate! Did not work. Check log output, AuthValues and if you're connected.", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HNICHJCGJOC().SetFloat("AuthenticationValues UserId: {0}, GetParameters: {1} Token available: {2}", 483f / farClipPlane);
			FLGPDBBKAIP().SetVector("_ReflectionBlur", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1735f, 81f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ILCFPCIPENO()
	{
		SCShader = Shader.Find("Incoming: \n");
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
			CIAFLBFJLEJ().SetFloat("SetPosition", HBJJOCHGOPH);
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
				NBPKMLMCHFN.SetFloat("R:", _Distance);
			}
			else
			{
				NBPKMLMCHFN.SetFloat("_ReflectionTexture2", _Distance);
			}
			ACHNOHCLGOO().SetFloat("InventoryButton", _Size);
			CECJJMKLEAK().SetFloat("Case-Sensitive", _FixDistance);
			DCCHGBHLAAF().SetFloat("Operation failed: ", LightIntensity * 921f);
			GJHPODJOBHL().SetFloat("_EmissionColor", (!_Visualize) ? 1 : 0);
			IIBLJCKLGFG().SetFloat("settings.hitvariation", _FadeShield);
			GJHPODJOBHL().SetFloat("settings.enablehitsoundsinrelax", Speed);
			FGENHBKMPDA().SetFloat("_Bullet_11", Speed_X);
			HJGEHJDMCGI().SetFloat("_TimeX", Speed_Y);
			HJGEHJDMCGI().SetFloat("colorA", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			JFDGLLEOPGB().SetFloat("RecieveChatActionMessage", 1748f / farClipPlane);
			CECJJMKLEAK().SetVector("Skipping packet for ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 746f, 1198f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
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
			NBMPPNFKFLB().SetFloat("CameraFilterPack/Gradients_Stripe", HBJJOCHGOPH);
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
				IGKFMCPDNOI().SetFloat("t", _Distance);
			}
			else
			{
				IIBLJCKLGFG().SetFloat("#", _Distance);
			}
			FKEOGPDLBDD().SetFloat("{0} seconds ago", _Size);
			DEFBJOCJJKF().SetFloat("GhostPosY", _FixDistance);
			GJHPODJOBHL().SetFloat("Protocol switch from: ", LightIntensity * 160f);
			LPPEPKGFOEM().SetFloat("_Min", _Visualize ? 1 : 0);
			FLGPDBBKAIP().SetFloat("LevelEditor/icons", _FadeShield);
			FKEOGPDLBDD().SetFloat(".", Speed);
			DEFBJOCJJKF().SetFloat("[Right]", Speed_X);
			JFDGLLEOPGB().SetFloat("no lives color", Speed_Y);
			IIJMIPBMMBF().SetFloat("[MenuScene] Error: ", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			OKJOKHGJHGF().SetFloat("_Value5", 1312f / farClipPlane);
			CIAFLBFJLEJ().SetVector("BitsData", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1708f, 1200f));
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
			BFGNMFCNDBC().SetFloat("_Value", HBJJOCHGOPH);
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
				BFGNMFCNDBC().SetFloat("Value", _Distance);
			}
			else
			{
				HJGEHJDMCGI().SetFloat("OnJoinedRoom() called by PUN. Now this client is in a room. From here on, your game would be running. For reference, all callbacks are listed in enum: PhotonNetworkingMessage", _Distance);
			}
			LPPEPKGFOEM().SetFloat("_ScreenResolution", _Size);
			IIBLJCKLGFG().SetFloat("skin.", _FixDistance);
			NBMPPNFKFLB().SetFloat("No Description", LightIntensity * 382f);
			ACHNOHCLGOO().SetFloat("_Quality", (!_Visualize) ? 1 : 1);
			OIIDAKBILMI().SetFloat(".lastCheckpoint.time", _FadeShield);
			LPPEPKGFOEM().SetFloat("OnAwakeRPC", Speed);
			KEMAALEODNH().SetFloat("float,0", Speed_X);
			FKEOGPDLBDD().SetFloat("#timeuntilchallenge: ", Speed_Y);
			NBMPPNFKFLB().SetFloat("_TileMaxOffs", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			IIBLJCKLGFG().SetFloat("/", 633f / farClipPlane);
			KEMAALEODNH().SetVector("OnSerialize", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 761f, 1873f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
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
			JFDGLLEOPGB().SetFloat("_Source", HBJJOCHGOPH);
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
				HEINDEMCGIK().SetFloat("_Value3", _Distance);
			}
			else
			{
				KEMAALEODNH().SetFloat("CameraFilterPack/Color_Contrast", _Distance);
			}
			IIJMIPBMMBF().SetFloat("[LevelEditorScene] Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(", _Size);
			GJHPODJOBHL().SetFloat("maps.", _FixDistance);
			IIBLJCKLGFG().SetFloat("LevelURLInputField", LightIntensity * 1874f);
			IIJMIPBMMBF().SetFloat("_ScreenResolution", (!_Visualize) ? 1 : 0);
			ACHNOHCLGOO().SetFloat("_Glow", _FadeShield);
			LPPEPKGFOEM().SetFloat("checkpoint", Speed);
			FLGPDBBKAIP().SetFloat("CameraFilterPack/Blend2Camera_Overlay", Speed_X);
			IGKFMCPDNOI().SetFloat(".lastCheckpoint.comboScore", Speed_Y);
			IIJMIPBMMBF().SetFloat("shader.ghost", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			CECJJMKLEAK().SetFloat("_Value4", 1846f / farClipPlane);
			KEMAALEODNH().SetVector("steamid", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1083f, 980f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLGPDBBKAIP());
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
			KOHGPKOFEJO().SetFloat(",", HBJJOCHGOPH);
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
				IIJMIPBMMBF().SetFloat("CameraFilterPack_Paper2", _Distance);
			}
			else
			{
				IGKFMCPDNOI().SetFloat("PLAY [SPACE]", _Distance);
			}
			CIAFLBFJLEJ().SetFloat("Joystick", _Size);
			DEFBJOCJJKF().SetFloat("_OcclusionTexture", _FixDistance);
			DCCHGBHLAAF().SetFloat(" SphereWaveform.cs", LightIntensity * 499f);
			LELKBCALFCF().SetFloat("_NormalAndRoughnessTexture", (!_Visualize) ? 1 : 1);
			LPPEPKGFOEM().SetFloat("misses", _FadeShield);
			FKEOGPDLBDD().SetFloat("bad", Speed);
			OIIDAKBILMI().SetFloat("_TimeX", Speed_X);
			OIIDAKBILMI().SetFloat("OK", Speed_Y);
			LELKBCALFCF().SetFloat("_ScreenResolution", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FEAEGGCNIAA().SetFloat("Cross", 1954f / farClipPlane);
			NBMPPNFKFLB().SetVector("CameraFilterPack/Vision_Psycho", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1690f, 1609f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
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
		SCShader = Shader.Find("Using constructor for new PingNativeDynamic()");
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
			HJGEHJDMCGI().SetFloat("LeaderboardsButton", HBJJOCHGOPH);
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
				FKEOGPDLBDD().SetFloat("896296812", _Distance);
			}
			else
			{
				FEAEGGCNIAA().SetFloat("_Value2", _Distance);
			}
			DCCHGBHLAAF().SetFloat("SAVE FILE", _Size);
			CIAFLBFJLEJ().SetFloat("Can not SetMasterClient(). Not in room or in offlineMode.", _FixDistance);
			KOHGPKOFEJO().SetFloat("InfoText", LightIntensity * 1262f);
			ACHNOHCLGOO().SetFloat("_Vibrance", (!_Visualize) ? 0 : 0);
			ACHNOHCLGOO().SetFloat("Illegal view ID:", _FadeShield);
			BFGNMFCNDBC().SetFloat("#tryagain", Speed);
			HNICHJCGJOC().SetFloat("GlassDistortion", Speed_X);
			PGPEMMBJOOG().SetFloat("#accuracy", Speed_Y);
			IIBLJCKLGFG().SetFloat("skin.", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HJGEHJDMCGI().SetFloat("OpSettings()", 741f / farClipPlane);
			PLBEJJIHFPB().SetVector("STICKRVER", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 954f, 1416f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIIDAKBILMI());
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
			ACHNOHCLGOO().SetFloat("mapselector.filter.favoriteonly", HBJJOCHGOPH);
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
				OKJOKHGJHGF().SetFloat("_Value6", _Distance);
			}
			else
			{
				DEFBJOCJJKF().SetFloat("_ScreenResolution", _Distance);
			}
			HNICHJCGJOC().SetFloat("EnableRankedNotificationsToggle", _Size);
			IIJMIPBMMBF().SetFloat("Mouse Y", _FixDistance);
			NBPKMLMCHFN.SetFloat("The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.", LightIntensity * 1990f);
			PLBEJJIHFPB().SetFloat("mapselector.filter.subscribedonly", (!_Visualize) ? 1 : 1);
			PLBEJJIHFPB().SetFloat("/files/editor_manual.pdf", _FadeShield);
			HJGEHJDMCGI().SetFloat("GlassColor", Speed);
			BFGNMFCNDBC().SetFloat("] to be droppable", Speed_X);
			PLBEJJIHFPB().SetFloat("sprite", Speed_Y);
			KEMAALEODNH().SetFloat("_Blurred", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			DCCHGBHLAAF().SetFloat("_Offsets", 359f / farClipPlane);
			KOHGPKOFEJO().SetVector("_Threshold", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 438f, 586f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MJJIEHANFJA());
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
			FKEOGPDLBDD().SetFloat("_Value2", HBJJOCHGOPH);
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
				IGKFMCPDNOI().SetFloat("Children", _Distance);
			}
			else
			{
				MJJIEHANFJA().SetFloat("_ScreenResolution", _Distance);
			}
			CIAFLBFJLEJ().SetFloat("[Right]", _Size);
			GJHPODJOBHL().SetFloat("EventData0DropDownList", _FixDistance);
			FLGPDBBKAIP().SetFloat("SetEnvSpriteColor", LightIntensity * 511f);
			IIBLJCKLGFG().SetFloat("masterSteamID", (!_Visualize) ? 1 : 0);
			KOHGPKOFEJO().SetFloat("_ForceYSwap", _FadeShield);
			NBMPPNFKFLB().SetFloat(" region", Speed);
			IIJMIPBMMBF().SetFloat("EventMenu", Speed_X);
			FGENHBKMPDA().SetFloat("#forever", Speed_Y);
			NBPKMLMCHFN.SetFloat("ChangeSelectedLevel", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FEAEGGCNIAA().SetFloat("_Red_C", 908f / farClipPlane);
			BFGNMFCNDBC().SetVector("_TraceBehindObjects", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1271f, 839f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OHFOLGANOLC()
	{
		SCShader = Shader.Find("_BlurTex");
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
		SCShader = Shader.Find("[PlayerBase] Loading checkpoint data");
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
		SCShader = Shader.Find("_Value3");
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
			FKEOGPDLBDD().SetFloat("_TimeX", HBJJOCHGOPH);
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
				GJHPODJOBHL().SetFloat("_FixDistance", _Distance);
			}
			else
			{
				IGKFMCPDNOI().SetFloat("UseScanLineSize", _Distance);
			}
			KOHGPKOFEJO().SetFloat("_FarCamera", _Size);
			KOHGPKOFEJO().SetFloat("_ScreenResolution", _FixDistance);
			DEFBJOCJJKF().SetFloat("CameraFilterPack/Distortion_Flush", LightIntensity * 964f);
			HJGEHJDMCGI().SetFloat("settings.enablehitsoundsinnormal", _Visualize ? 1 : 0);
			GJHPODJOBHL().SetFloat("_WaveIntensity", _FadeShield);
			PGPEMMBJOOG().SetFloat("_FixDistance", Speed);
			HNICHJCGJOC().SetFloat("_Intensity", Speed_X);
			ACHNOHCLGOO().SetFloat("Drop_With_Obj", Speed_Y);
			LPPEPKGFOEM().SetFloat("/icon", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FGENHBKMPDA().SetFloat("maps.", 1047f / farClipPlane);
			IGKFMCPDNOI().SetVector("CloseConnection: Only the masterclient can kick another player.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 257f, 530f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JONGNKNLLND()
	{
		SCShader = Shader.Find(". Going to ignore! Check PhotonServerSettings.RpcList");
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
			LELKBCALFCF().SetFloat("masterSteamID", HBJJOCHGOPH);
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
				OIIDAKBILMI().SetFloat("_Bullet_4", _Distance);
			}
			else
			{
				FKEOGPDLBDD().SetFloat("randomdrop", _Distance);
			}
			OIIDAKBILMI().SetFloat("_Value3", _Size);
			GJHPODJOBHL().SetFloat("RB", _FixDistance);
			PLBEJJIHFPB().SetFloat("Please specify either t or f.", LightIntensity * 1389f);
			OIIDAKBILMI().SetFloat("_ScreenResolution", (!_Visualize) ? 0 : 0);
			CIAFLBFJLEJ().SetFloat("#startofflinemessage", _FadeShield);
			IGKFMCPDNOI().SetFloat("_DotSize", Speed);
			IIBLJCKLGFG().SetFloat("Drop_With_Obj", Speed_X);
			KOHGPKOFEJO().SetFloat(" ", Speed_Y);
			NBMPPNFKFLB().SetFloat("inventory.itemscash", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FKEOGPDLBDD().SetFloat("_TimeX", 740f / farClipPlane);
			FEAEGGCNIAA().SetVector("_PosX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 458f, 1289f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DFFKKLAPHCC()
	{
		SCShader = Shader.Find("bpmgrid");
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
			LPPEPKGFOEM().SetFloat(" x ", HBJJOCHGOPH);
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
				CECJJMKLEAK().SetFloat("_Value5", _Distance);
			}
			else
			{
				IIBLJCKLGFG().SetFloat("CameraFilterPack/Blur_Regular", _Distance);
			}
			NBMPPNFKFLB().SetFloat("PlayButton", _Size);
			PGPEMMBJOOG().SetFloat("_Value2", _FixDistance);
			ACHNOHCLGOO().SetFloat("stretchWidth", LightIntensity * 1006f);
			MJJIEHANFJA().SetFloat("_Visualize", (!_Visualize) ? 0 : 0);
			OKJOKHGJHGF().SetFloat("offsets", _FadeShield);
			FKEOGPDLBDD().SetFloat("LivesSlider", Speed);
			PGPEMMBJOOG().SetFloat("_CutOff", Speed_X);
			BFGNMFCNDBC().SetFloat("Items/", Speed_Y);
			OKJOKHGJHGF().SetFloat("_Value6", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FLGPDBBKAIP().SetFloat("/files/mods_terms.pdf", 194f / farClipPlane);
			NBPKMLMCHFN.SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 57f, 157f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
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
		SCShader = Shader.Find("RecieveChatActionMessage");
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
		SCShader = Shader.Find("tagElement");
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
		SCShader = Shader.Find("CameraFilterPack_Atmosphere_Rain_FX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FANADGBGCPI()
	{
		SCShader = Shader.Find("_TexelOffsetScale");
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
			HEINDEMCGIK().SetFloat(", ", HBJJOCHGOPH);
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
				FKEOGPDLBDD().SetFloat("_Value2", _Distance);
			}
			else
			{
				LELKBCALFCF().SetFloat("_Value", _Distance);
			}
			IIJMIPBMMBF().SetFloat("_MainTex2", _Size);
			CIAFLBFJLEJ().SetFloat("_HalfResolution", _FixDistance);
			DEFBJOCJJKF().SetFloat("#FFFFFFFF", LightIntensity * 1613f);
			LELKBCALFCF().SetFloat("[PlayerBase] SetBGColor error: ", (!_Visualize) ? 1 : 0);
			CIAFLBFJLEJ().SetFloat(",", _FadeShield);
			FKEOGPDLBDD().SetFloat("Tonemapper curve texture", Speed);
			HNICHJCGJOC().SetFloat("#yes", Speed_X);
			IIJMIPBMMBF().SetFloat("image", Speed_Y);
			CIAFLBFJLEJ().SetFloat("settings.arcsdestroydelay", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			OKJOKHGJHGF().SetFloat("Data", 692f / farClipPlane);
			FLGPDBBKAIP().SetVector("Editor/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1993f, 1354f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CEDFFAOOPOG()
	{
		SCShader = Shader.Find("_ScreenResolution");
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
		SCShader = Shader.Find(".played");
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
			HNICHJCGJOC().SetFloat("Identity LUT", HBJJOCHGOPH);
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
				IIJMIPBMMBF().SetFloat("Left", _Distance);
			}
			else
			{
				FGENHBKMPDA().SetFloat("bpmgrid", _Distance);
			}
			PGPEMMBJOOG().SetFloat(" or player:", _Size);
			GJHPODJOBHL().SetFloat("Set object anchor to another object", _FixDistance);
			HEINDEMCGIK().SetFloat(".", LightIntensity * 628f);
			FLGPDBBKAIP().SetFloat("ItemNameBGImage", (!_Visualize) ? 1 : 0);
			DCCHGBHLAAF().SetFloat("CameraFilterPack/Light_Water2", _FadeShield);
			DCCHGBHLAAF().SetFloat("_MainTex2", Speed);
			HNICHJCGJOC().SetFloat(" player(s)", Speed_X);
			DCCHGBHLAAF().SetFloat("_Value", Speed_Y);
			LELKBCALFCF().SetFloat("#rategameinfo", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			JFDGLLEOPGB().SetFloat("CameraFilterPack/Distortion_BlackHole", 1368f / farClipPlane);
			IIJMIPBMMBF().SetVector("[NetworkManager] Join failed", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1117f, 1285f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIIDAKBILMI());
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
		SCShader = Shader.Find("#yes");
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
		SCShader = Shader.Find("maps.");
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
		SCShader = Shader.Find("_NeighbourMaxTex");
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
		SCShader = Shader.Find("event");
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
		SCShader = Shader.Find("_Color");
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
			KOHGPKOFEJO().SetFloat("Gameplay/sprite", HBJJOCHGOPH);
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
				PLBEJJIHFPB().SetFloat("Identity LUT", _Distance);
			}
			else
			{
				FKEOGPDLBDD().SetFloat("_TimeX", _Distance);
			}
			NBPKMLMCHFN.SetFloat("_Size", _Size);
			OKJOKHGJHGF().SetFloat("Data/Localization", _FixDistance);
			NBMPPNFKFLB().SetFloat("[PlayerController] ", LightIntensity * 558f);
			FLGPDBBKAIP().SetFloat("SetCrosshairColor", (!_Visualize) ? 0 : 0);
			KOHGPKOFEJO().SetFloat("#tryagain", _FadeShield);
			GJHPODJOBHL().SetFloat("[Left]", Speed);
			LPPEPKGFOEM().SetFloat("_TimeX", Speed_X);
			KOHGPKOFEJO().SetFloat("_TimeX", Speed_Y);
			OKJOKHGJHGF().SetFloat("{0}", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FEAEGGCNIAA().SetFloat("#TBD", 401f / farClipPlane);
			CECJJMKLEAK().SetVector("stretchWidth", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 307f, 435f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF());
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
			IGKFMCPDNOI().SetFloat("[SERVER] Selected mode: ", HBJJOCHGOPH);
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
				GJHPODJOBHL().SetFloat("Please specify either t or f.", _Distance);
			}
			else
			{
				NBMPPNFKFLB().SetFloat(" not exist", _Distance);
			}
			GJHPODJOBHL().SetFloat("_MatrixColor", _Size);
			IIJMIPBMMBF().SetFloat("_SSAO", _FixDistance);
			OKJOKHGJHGF().SetFloat(": ", LightIntensity * 726f);
			PLBEJJIHFPB().SetFloat("float,0", (!_Visualize) ? 1 : 1);
			KEMAALEODNH().SetFloat("_VignettingColor", _FadeShield);
			HNICHJCGJOC().SetFloat("x", Speed);
			GJHPODJOBHL().SetFloat("_Offsets", Speed_X);
			HEINDEMCGIK().SetFloat("player.bat", Speed_Y);
			LPPEPKGFOEM().SetFloat("CameraFilterPack/TV_WideScreenHorizontal", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HEINDEMCGIK().SetFloat("RequestForPickupItems", 1818f / farClipPlane);
			KOHGPKOFEJO().SetVector("Hidden/DepthOfField/DepthOfField", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1933f, 346f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
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
			NBMPPNFKFLB().SetFloat("StartButton", HBJJOCHGOPH);
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
				FGENHBKMPDA().SetFloat("_AxialAberration", _Distance);
			}
			else
			{
				CIAFLBFJLEJ().SetFloat("menu.selectedplaymode", _Distance);
			}
			NBPKMLMCHFN.SetFloat("_TimeX", _Size);
			FLGPDBBKAIP().SetFloat("_EmissionColor", _FixDistance);
			FEAEGGCNIAA().SetFloat("_Value2", LightIntensity * 1933f);
			CECJJMKLEAK().SetFloat("SaveButton", (!_Visualize) ? 1 : 0);
			LELKBCALFCF().SetFloat("FinalScoreSmallText", _FadeShield);
			IGKFMCPDNOI().SetFloat("LoadMapCanvas", Speed);
			FGENHBKMPDA().SetFloat("Chat", Speed_X);
			FLGPDBBKAIP().SetFloat("_Value2", Speed_Y);
			LPPEPKGFOEM().SetFloat("SetEnvSpriteImage", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			CIAFLBFJLEJ().SetFloat("CameraFilterPack/TV_WideScreenHV", 82f / farClipPlane);
			CECJJMKLEAK().SetVector("CameraFilterPack/Blend2Camera_BlueScreen", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 699f, 1494f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIIDAKBILMI());
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
			JFDGLLEOPGB().SetFloat("_ScreenResolution", HBJJOCHGOPH);
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
				PLBEJJIHFPB().SetFloat("_Value", _Distance);
			}
			else
			{
				ACHNOHCLGOO().SetFloat("Up", _Distance);
			}
			MJJIEHANFJA().SetFloat("_ScreenResolution", _Size);
			FGENHBKMPDA().SetFloat("_TimeX", _FixDistance);
			HNICHJCGJOC().SetFloat("_InternalLutTex", LightIntensity * 93f);
			IGKFMCPDNOI().SetFloat("JoinRoom failed. A roomname is required. If you don't know one, how will you join?", (!_Visualize) ? 1 : 1);
			PLBEJJIHFPB().SetFloat("_Line", _FadeShield);
			DCCHGBHLAAF().SetFloat("CameraFilterPack/Blend2Camera_Subtract", Speed);
			OKJOKHGJHGF().SetFloat("ConfigVersionSlider", Speed_X);
			KEMAALEODNH().SetFloat("value", Speed_Y);
			MJJIEHANFJA().SetFloat("Texture2", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			NBPKMLMCHFN.SetFloat("_TimeX", 425f / farClipPlane);
			LPPEPKGFOEM().SetVector("_DotSize", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 854f, 684f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIIDAKBILMI());
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
			KOHGPKOFEJO().SetFloat("MaxLivesSlider", HBJJOCHGOPH);
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
				HEINDEMCGIK().SetFloat("menu.tabid", _Distance);
			}
			else
			{
				KOHGPKOFEJO().SetFloat("_Amount", _Distance);
			}
			LELKBCALFCF().SetFloat(" user's map(s)", _Size);
			NBMPPNFKFLB().SetFloat("Dropped Object: ", _FixDistance);
			PLBEJJIHFPB().SetFloat("visible", LightIntensity * 1931f);
			OKJOKHGJHGF().SetFloat("_FixDistance", (!_Visualize) ? 0 : 0);
			OIIDAKBILMI().SetFloat("_SSAO", _FadeShield);
			HEINDEMCGIK().SetFloat("CloseConnection: No such player connected!", Speed);
			FGENHBKMPDA().SetFloat("[#clicktoacceptchallenge]", Speed_X);
			LPPEPKGFOEM().SetFloat("CameraFilterPack/Blend2Camera_Darken", Speed_Y);
			IGKFMCPDNOI().SetFloat("_Light", Intensity);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			KEMAALEODNH().SetFloat("_TimeX", 910f / farClipPlane);
			ACHNOHCLGOO().SetVector("BloodAlternative2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 633f, 1029f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NBGIMIDICKE()
	{
		SCShader = Shader.Find("_Value7");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DIPDEHOOBPG()
	{
		SCShader = Shader.Find("[EMPTY]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}
}
