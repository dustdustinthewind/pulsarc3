// CameraFilterPack_3D_Inverse
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/3D/Inverse")]
public class CameraFilterPack_3D_Inverse : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	public bool _Visualize;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 100f)]
	public float _FixDistance = 1.5f;

	[Range(-0.99f, 0.99f)]
	public float _Distance = 0.4f;

	[Range(0f, 0.5f)]
	public float _Size = 0.5f;

	[Range(0f, 1f)]
	public float LightIntensity = 1f;

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

	private void FDMAEPOHDMK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HBLDMJCOAHA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)65;
		}
		return BJFKDHHMLJH;
	}

	private void BFGIMALGMAJ()
	{
	}

	[SpecialName]
	private Material LPMLLJKMAMP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void KLILJHJNICK()
	{
		SCShader = Shader.Find("LeaderboardsButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BMGPBIBPBLA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AGEJKLMJGDO()
	{
		SCShader = Shader.Find("curScn");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BOLBPPHJBMI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ODCJJFBJJNF()
	{
	}

	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1245f)
			{
				HBJJOCHGOPH = 1541f;
			}
			ADBKPGFMNKO().SetFloat("_Value", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 480f)
				{
					_Distance = 1384f;
				}
				if (_Distance < 387f)
				{
					_Distance = 1830f;
				}
				ADBKPGFMNKO().SetFloat("CameraFilterPack/AAA_Blood_Plus", _Distance);
			}
			else
			{
				GCDFNHMJMIP().SetFloat("_Value2", _Distance);
			}
			MCDGIILBNIF().SetFloat("Texture2", _Size);
			CFEDGDGBCHE().SetFloat("[ERROR KEY {0}]", _FixDistance);
			CEKJODEAMGB().SetFloat("Tab2Content", LightIntensity);
			LPPEPKGFOEM().SetFloat("steamid", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			IGIAPKPKGPK().SetFloat("[DiscordController] Join request {0}#{1}: {2}", 1195f / farClipPlane);
			LPPEPKGFOEM().SetVector("LoadingStatusText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 35f, 1294f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 750f)
			{
				HBJJOCHGOPH = 782f;
			}
			OLHDPICFBOF().SetFloat("#mapalreadyexistupdate", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1303f)
				{
					_Distance = 1141f;
				}
				if (_Distance < 545f)
				{
					_Distance = 1552f;
				}
				FLGPDBBKAIP().SetFloat("Hidden/Image Effects/Cinematic/MotionBlur/Reconstruction", _Distance);
			}
			else
			{
				CEKJODEAMGB().SetFloat("_Intensity", _Distance);
			}
			HHLFDHNEIAH().SetFloat("sounds/hit_normal", _Size);
			EFDEIFCDAFG().SetFloat("_TimeX", _FixDistance);
			LPPEPKGFOEM().SetFloat("There are too many cells created by your subdivision options. Maximum allowed number of cells is ", LightIntensity);
			FEAEGGCNIAA().SetFloat("PLEASE WAIT", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			CEKJODEAMGB().SetFloat("#{0:00} '{1}'{2} {3}", 518f / farClipPlane);
			LONNIJMNKFB().SetVector(";", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1749f, 1436f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AAEEHINDPNC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HHIAIGCAHDA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void NKFDNIAKGEO()
	{
		SCShader = Shader.Find("Please define the RectTransform for the Center viewport of the scrollable area");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FOMNCPKKCFN()
	{
	}

	private void KMEONPMCNJG()
	{
	}

	private void GGPDKCHEBAG()
	{
	}

	private void BGDPIHMAACO()
	{
		SCShader = Shader.Find("You need to have a Graphic control (such as an Image) for the list [");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material LELKBCALFCF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)69;
		}
		return BJFKDHHMLJH;
	}

	private void FMHOHGEAIEA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FMFNILJIEIA()
	{
		SCShader = Shader.Find("_MaxSteps");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IBJIBLHJKMG()
	{
		SCShader = Shader.Find("player.bluelifering");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void Update()
	{
	}

	private void KOJKBFDNGDK()
	{
		SCShader = Shader.Find("_BgColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CIPKEPDELJB()
	{
		SCShader = Shader.Find("_Circle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MMPHNFPPEHO()
	{
		SCShader = Shader.Find("[PlayerBase] Invoke event ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material EJDPNJAEAKJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-98);
		}
		return BJFKDHHMLJH;
	}

	private void KFEKCJDEECK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DKEHGPPOKEA()
	{
		SCShader = Shader.Find("SAVE");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JAFOCEDILNK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FHPFJBFCOOF()
	{
		SCShader = Shader.Find("music");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JBCNIPJDPJB()
	{
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/3D_Inverse");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material FLGPDBBKAIP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1853f)
			{
				HBJJOCHGOPH = 1392f;
			}
			CIAFLBFJLEJ().SetFloat("Texture2", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1365f)
				{
					_Distance = 770f;
				}
				if (_Distance < 159f)
				{
					_Distance = 666f;
				}
				ADBKPGFMNKO().SetFloat(".progress", _Distance);
			}
			else
			{
				JFDGLLEOPGB().SetFloat("LoadingStatusText", _Distance);
			}
			HBLDMJCOAHA().SetFloat("note.1", _Size);
			LELKBCALFCF().SetFloat("Tab2Content", _FixDistance);
			LDNADDJMIPK().SetFloat("_Visualize", LightIntensity);
			LDNADDJMIPK().SetFloat("/", (!_Visualize) ? 0 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			LPMLLJKMAMP().SetFloat("_SoftZDistance", 915f / farClipPlane);
			LELKBCALFCF().SetVector("OnRelease", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 78f, 616f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AEIJFLJEABG()
	{
	}

	private void JHJFBCFBKLD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void POEMOLBJDLG()
	{
	}

	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1756f)
			{
				HBJJOCHGOPH = 1330f;
			}
			JFDGLLEOPGB().SetFloat("_Blend", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1160f)
				{
					_Distance = 1553f;
				}
				if (_Distance < 1351f)
				{
					_Distance = 1153f;
				}
				CIAFLBFJLEJ().SetFloat("CameraFilterPack/FX_Glitch2", _Distance);
			}
			else
			{
				CIAFLBFJLEJ().SetFloat("Data/Maps/", _Distance);
			}
			JFDGLLEOPGB().SetFloat("EnableRankingToggle", _Size);
			ELBMIEOIABA().SetFloat("#reward: ", _FixDistance);
			IGIAPKPKGPK().SetFloat("_Noise", LightIntensity);
			MCDGIILBNIF().SetFloat("Unknown player asked for PickupItems", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			ELBMIEOIABA().SetFloat("BloodAlternative2", 1939f / farClipPlane);
			NBPKMLMCHFN.SetVector("_ColorRGB", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 304f, 59f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ALMGMOOHLMA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PNLKFANNOKO()
	{
	}

	private void CKECPMDEBLL()
	{
	}

	private void IEMEHGCFAPD()
	{
	}

	private void EPEGAEGDJAM()
	{
		SCShader = Shader.Find("CameraFilterPack/Blend2Camera_Subtract");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FEGJMDDIDIC()
	{
		SCShader = Shader.Find("DontDestroy");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 917f)
			{
				HBJJOCHGOPH = 1851f;
			}
			OIMMPLPBLBK().SetFloat("LoadingStatusText", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1870f)
				{
					_Distance = 1996f;
				}
				if (_Distance < 125f)
				{
					_Distance = 1612f;
				}
				IGIAPKPKGPK().SetFloat("int", _Distance);
			}
			else
			{
				ADGHJOHKEHG().SetFloat("CameraFilterPack/Gradients_Rainbow", _Distance);
			}
			IGKFMCPDNOI().SetFloat("w", _Size);
			CIAFLBFJLEJ().SetFloat("UsernameText", _FixDistance);
			OIMMPLPBLBK().SetFloat("/", LightIntensity);
			LDNADDJMIPK().SetFloat("AudioSampler", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FEAEGGCNIAA().SetFloat(" ", 15f / farClipPlane);
			EJDPNJAEAKJ().SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1949f, 1322f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPPEPKGFOEM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BOPKKCAFODF()
	{
		SCShader = Shader.Find("CameraFilterPack_Blizzard1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KIEJKBNBHMD()
	{
	}

	private void JECMJNFGBGC()
	{
		SCShader = Shader.Find("[");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EODOHEAKJFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MJNPIDGNJMK()
	{
	}

	private void NPLCENPNJBM()
	{
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FNCDAPDOBBI()
	{
		SCShader = Shader.Find("settings.enablehitsoundsinnormal");
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

	private void MKIMDFLBFOM()
	{
		SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GPHPJIDGEPI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material FNAFGEMJBDA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void DIPDEHOOBPG()
	{
		SCShader = Shader.Find("https://steamcommunity.com/sharedfiles/filedetails/?id=");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material LDNADDJMIPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideAndDontSave;
		}
		return BJFKDHHMLJH;
	}

	private void KODKKCOKEPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1490f)
			{
				HBJJOCHGOPH = 330f;
			}
			CIAFLBFJLEJ().SetFloat("Localization Servise\nWorking commands:\nset <language>\nlist\nkeys", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1263f)
				{
					_Distance = 1874f;
				}
				if (_Distance < 1978f)
				{
					_Distance = 1469f;
				}
				OIIDAKBILMI().SetFloat("mapselector.filter.officialsortmode", _Distance);
			}
			else
			{
				MALMMJNPILJ().SetFloat("Hex value #RRGGBB", _Distance);
			}
			LPPEPKGFOEM().SetFloat("_MaxRadiusOrKInPaper", _Size);
			MMOODGIODPC().SetFloat("_Value", _FixDistance);
			MCDGIILBNIF().SetFloat("CameraFilterPack/FX_Glitch3", LightIntensity);
			MMOODGIODPC().SetFloat("EventSystem", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			BBIMPFGLDCP().SetFloat("input", 1551f / farClipPlane);
			LPPEPKGFOEM().SetVector("_BgFade", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 274f, 1406f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ABFNJCEBIKA()
	{
	}

	private void NAALCEPIHCH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LEAHIBJDMBI()
	{
	}

	private void ODGMCJILIHF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LBAJLLFMMMP()
	{
		SCShader = Shader.Find("_OcclusionTexture");
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
			if (HBJJOCHGOPH > 1402f)
			{
				HBJJOCHGOPH = 582f;
			}
			LDNADDJMIPK().SetFloat("Joystick1Button10", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 858f)
				{
					_Distance = 1511f;
				}
				if (_Distance < 26f)
				{
					_Distance = 144f;
				}
				ELBMIEOIABA().SetFloat("mapselector.orderby", _Distance);
			}
			else
			{
				HBLDMJCOAHA().SetFloat("CameraFilterPack_Paper1", _Distance);
			}
			HHLFDHNEIAH().SetFloat("</color>", _Size);
			LPPEPKGFOEM().SetFloat("Left", _FixDistance);
			EFDEIFCDAFG().SetFloat("Vertical", LightIntensity);
			OLHDPICFBOF().SetFloat(".lastCheckpoint.lives", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			EFDEIFCDAFG().SetFloat("#done", 1878f / farClipPlane);
			ELBMIEOIABA().SetVector("_CenterY", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 542f, 1182f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-102);
		}
		return BJFKDHHMLJH;
	}

	private void DKOPKPBLDHH()
	{
		SCShader = Shader.Find("BitsData");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IGPCNCJIEOJ()
	{
		SCShader = Shader.Find("Source: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MKFLBEGJJDC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HIFLPHLGLFG()
	{
	}

	private void OFMNDBNFBDJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MDNHCLKNCLE()
	{
		SCShader = Shader.Find("settings.fps");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material IGIAPKPKGPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)115;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material CFEDGDGBCHE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)101;
		}
		return BJFKDHHMLJH;
	}

	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1328f)
			{
				HBJJOCHGOPH = 758f;
			}
			LDNADDJMIPK().SetFloat("0,1,false", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1963f)
				{
					_Distance = 255f;
				}
				if (_Distance < 712f)
				{
					_Distance = 1609f;
				}
				ADBKPGFMNKO().SetFloat("_Bloom2", _Distance);
			}
			else
			{
				FEAEGGCNIAA().SetFloat("_Value3", _Distance);
			}
			OIMMPLPBLBK().SetFloat("_Green_R", _Size);
			LELKBCALFCF().SetFloat("deletemap", _FixDistance);
			LDNADDJMIPK().SetFloat("_TimeX", LightIntensity);
			EJDPNJAEAKJ().SetFloat("http://steamcommunity.com/sharedfiles/filedetails/?id=", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			BBIMPFGLDCP().SetFloat("_TapMedium", 1921f / farClipPlane);
			LELKBCALFCF().SetVector("_Saturation", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 273f, 768f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ABIOAMNCEOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1173f)
			{
				HBJJOCHGOPH = 856f;
			}
			MMOODGIODPC().SetFloat("_Value4", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 852f)
				{
					_Distance = 1226f;
				}
				if (_Distance < 1568f)
				{
					_Distance = 1311f;
				}
				FLGPDBBKAIP().SetFloat("{0:0} hour{1}, ", _Distance);
			}
			else
			{
				IGKFMCPDNOI().SetFloat(" canvas not found", _Distance);
			}
			JFDGLLEOPGB().SetFloat("[RanksSystem] Ranks updated. Next update: ", _Size);
			ELBMIEOIABA().SetFloat(" on effect ", _FixDistance);
			CFEDGDGBCHE().SetFloat("_Value", LightIntensity);
			CIAFLBFJLEJ().SetFloat("_ScreenResolution", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			LPPEPKGFOEM().SetFloat("_Bullet_11", 1462f / farClipPlane);
			OIIDAKBILMI().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 900f, 727f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FNAFGEMJBDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CBIBDOIBJAI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DOFDGBGEDFI()
	{
		SCShader = Shader.Find("ready");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
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
	private Material MCDGIILBNIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return BJFKDHHMLJH;
	}

	private void HAAFIECGECG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 677f)
			{
				HBJJOCHGOPH = 777f;
			}
			HHIAIGCAHDA().SetFloat("ChangeSelectedLevel", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 220f)
				{
					_Distance = 1576f;
				}
				if (_Distance < 1439f)
				{
					_Distance = 1179f;
				}
				LPPEPKGFOEM().SetFloat("_Axis", _Distance);
			}
			else
			{
				HHIAIGCAHDA().SetFloat("_Value4", _Distance);
			}
			OIMMPLPBLBK().SetFloat("settings.customdataskin", _Size);
			EFDEIFCDAFG().SetFloat("_ScreenResolution", _FixDistance);
			BBIMPFGLDCP().SetFloat("RecordButton", LightIntensity);
			MMOODGIODPC().SetFloat("Tab1Content", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FNAFGEMJBDA().SetFloat("_ContrastGainGamma", 1459f / farClipPlane);
			MALMMJNPILJ().SetVector("Sequence contains no elements", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 887f, 1498f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BNEJMABFKJE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void INLDEHPAMJC()
	{
	}

	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 286f)
			{
				HBJJOCHGOPH = 448f;
			}
			LDNADDJMIPK().SetFloat(":\n", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1219f)
				{
					_Distance = 1303f;
				}
				if (_Distance < 794f)
				{
					_Distance = 484f;
				}
				FAIFBBGFAIB().SetFloat(".lastCheckpoint.checkpointsUsed", _Distance);
			}
			else
			{
				FEAEGGCNIAA().SetFloat("[LevelEditorScene] Error: I/O Failure! :(", _Distance);
			}
			ELBMIEOIABA().SetFloat("_FrustumCornersWS", _Size);
			ADBKPGFMNKO().SetFloat("<b>Kick player by NetID</b>\nuse: /kick {NetID}\nUse \"/players\" command to get all NetIDs\nRoom owner only can kick the players", _FixDistance);
			BBIMPFGLDCP().SetFloat("#exit", LightIntensity);
			HBLDMJCOAHA().SetFloat("note.0", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			LONNIJMNKFB().SetFloat("color", 48f / farClipPlane);
			FLGPDBBKAIP().SetVector("ArcsDestroyDelaySlider", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1395f, 1845f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
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
			if (HBJJOCHGOPH > 1017f)
			{
				HBJJOCHGOPH = 1609f;
			}
			MALMMJNPILJ().SetFloat("SaveButton", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1271f)
				{
					_Distance = 1303f;
				}
				if (_Distance < 859f)
				{
					_Distance = 224f;
				}
				HHIAIGCAHDA().SetFloat(": ", _Distance);
			}
			else
			{
				LPPEPKGFOEM().SetFloat("downloading", _Distance);
			}
			LPMLLJKMAMP().SetFloat("[PlayerBase] Reset", _Size);
			EJDPNJAEAKJ().SetFloat("CameraFilterPack/Gradients_Desert", _FixDistance);
			LPPEPKGFOEM().SetFloat("EXCEPTION:", LightIntensity);
			GCDFNHMJMIP().SetFloat("_Value5", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FEAEGGCNIAA().SetFloat("[DiscordController] Init", 776f / farClipPlane);
			FEAEGGCNIAA().SetVector("grid", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1855f, 554f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LCJHDLKJEOM()
	{
	}

	private void HNGHDAPKEJG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GOIMKCCICFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1327f)
			{
				HBJJOCHGOPH = 1799f;
			}
			BBIMPFGLDCP().SetFloat("Bad modpack name: {0}", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1911f)
				{
					_Distance = 395f;
				}
				if (_Distance < 1383f)
				{
					_Distance = 1858f;
				}
				ADGHJOHKEHG().SetFloat("_Blend", _Distance);
			}
			else
			{
				CIAFLBFJLEJ().SetFloat("id", _Distance);
			}
			CFEDGDGBCHE().SetFloat("targetColor", _Size);
			OIMMPLPBLBK().SetFloat("CameraFilterPack/Color_Chromatic_Plus", _FixDistance);
			CIAFLBFJLEJ().SetFloat("Localization Servise\nWorking commands:\nset <language>\nlist\nkeys", LightIntensity);
			CIAFLBFJLEJ().SetFloat("_Radius", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			GCDFNHMJMIP().SetFloat("PLAY [SPACE]", 1998f / farClipPlane);
			HHIAIGCAHDA().SetVector("CameraFilterPack_AAA_Blood2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1738f, 1842f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HPFIHLMKIPF()
	{
		SCShader = Shader.Find("OPEN FILE");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DLMPALHKMON()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PJIFJFENPJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 770f)
			{
				HBJJOCHGOPH = 1257f;
			}
			ADGHJOHKEHG().SetFloat(". Verify the Prefab is in a Resources folder (and not in a subfolder)", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1387f)
				{
					_Distance = 428f;
				}
				if (_Distance < 1485f)
				{
					_Distance = 143f;
				}
				CIAFLBFJLEJ().SetFloat(" not exist", _Distance);
			}
			else
			{
				LONNIJMNKFB().SetFloat("gameVolume", _Distance);
			}
			IGIAPKPKGPK().SetFloat("_TimeX", _Size);
			OIIDAKBILMI().SetFloat("BitsData", _FixDistance);
			OIIDAKBILMI().SetFloat("blue", LightIntensity);
			EFDEIFCDAFG().SetFloat("challenges.", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			OIMMPLPBLBK().SetFloat("OK", 1862f / farClipPlane);
			FNAFGEMJBDA().SetVector("Oct", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1371f, 1265f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GLEJGFLCLPJ()
	{
		SCShader = Shader.Find("settings.arcsnohitsoundtimedelay");
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
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IGKFMCPDNOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material FAIFBBGFAIB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)90;
		}
		return BJFKDHHMLJH;
	}

	private void DIGHKAJILJH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DBLILJGKGHJ()
	{
		SCShader = Shader.Find("workshop.");
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
			NBPKMLMCHFN.SetFloat("_FixDistance", _FixDistance);
			NBPKMLMCHFN.SetFloat("_LightIntensity", LightIntensity);
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

	private void LFBGJIIECLD()
	{
		SCShader = Shader.Find("_BlurDistance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material EFDEIFCDAFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-99);
		}
		return BJFKDHHMLJH;
	}

	private void HDMDKOKOOJC()
	{
		SCShader = Shader.Find("_CenterY");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1911f)
			{
				HBJJOCHGOPH = 778f;
			}
			ADGHJOHKEHG().SetFloat("IntraSig", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1444f)
				{
					_Distance = 1110f;
				}
				if (_Distance < 983f)
				{
					_Distance = 606f;
				}
				NBPKMLMCHFN.SetFloat("Edited unlock conditions", _Distance);
			}
			else
			{
				BBIMPFGLDCP().SetFloat("settings.disablestoryboard", _Distance);
			}
			LPPEPKGFOEM().SetFloat("RespawnAfter", _Size);
			IGIAPKPKGPK().SetFloat("/", _FixDistance);
			LONNIJMNKFB().SetFloat("_Red_R", LightIntensity);
			BBIMPFGLDCP().SetFloat("set environment id", (!_Visualize) ? 0 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			MALMMJNPILJ().SetFloat("_Value3", 1096f / farClipPlane);
			EFDEIFCDAFG().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 306f, 23f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLGPDBBKAIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 488f)
			{
				HBJJOCHGOPH = 699f;
			}
			MCDGIILBNIF().SetFloat("_DotSize", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 283f)
				{
					_Distance = 143f;
				}
				if (_Distance < 1122f)
				{
					_Distance = 1244f;
				}
				ADBKPGFMNKO().SetFloat("1.87", _Distance);
			}
			else
			{
				LPMLLJKMAMP().SetFloat("CameraFilterPack/TV_Rgb", _Distance);
			}
			IGIAPKPKGPK().SetFloat("RaiseEvent() failed. Your event is not being sent! Check if your are in a Room and the eventCode must be less than 200 (0..199).", _Size);
			MMOODGIODPC().SetFloat("[MapEditor] Loading map: ", _FixDistance);
			CIAFLBFJLEJ().SetFloat("LoadMapCanvas", LightIntensity);
			HBLDMJCOAHA().SetFloat("_TimeX", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			CIAFLBFJLEJ().SetFloat("_LutTex", 117f / farClipPlane);
			OLHDPICFBOF().SetVector("on master", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1579f, 437f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HHLFDHNEIAH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)124;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material OLHDPICFBOF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)119;
		}
		return BJFKDHHMLJH;
	}

	private void MODENHKMKOC()
	{
		SCShader = Shader.Find(". Check if the server is available.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material CEKJODEAMGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-88);
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

	private void GJLKJAOBPJD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EDDPLJGKLKJ()
	{
	}

	private void JHANGPCOCIG()
	{
		SCShader = Shader.Find("[MenuScene] Error: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material JFDGLLEOPGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-120);
		}
		return BJFKDHHMLJH;
	}

	private void FIKNBPAIFBI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1335f)
			{
				HBJJOCHGOPH = 589f;
			}
			NBPKMLMCHFN.SetFloat("_Value", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1762f)
				{
					_Distance = 1850f;
				}
				if (_Distance < 1902f)
				{
					_Distance = 113f;
				}
				FLGPDBBKAIP().SetFloat("CameraFilterPack/3D_Scan_Scene", _Distance);
			}
			else
			{
				OIMMPLPBLBK().SetFloat("Editor/", _Distance);
			}
			IGIAPKPKGPK().SetFloat("OK", _Size);
			CEKJODEAMGB().SetFloat("-", _FixDistance);
			JFDGLLEOPGB().SetFloat("LoadingStatusText", LightIntensity);
			LPMLLJKMAMP().SetFloat("_TimeX", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			CEKJODEAMGB().SetFloat("float,1", 692f / farClipPlane);
			HHLFDHNEIAH().SetVector("Preparing content", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1100f, 1624f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1606f)
			{
				HBJJOCHGOPH = 700f;
			}
			ADBKPGFMNKO().SetFloat("image", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1884f)
				{
					_Distance = 1411f;
				}
				if (_Distance < 347f)
				{
					_Distance = 612f;
				}
				LPMLLJKMAMP().SetFloat("settings.gamemessagesduration", _Distance);
			}
			else
			{
				HHIAIGCAHDA().SetFloat("View ({3}){0} on {1} {2}", _Distance);
			}
			LDNADDJMIPK().SetFloat("Items/", _Size);
			GCDFNHMJMIP().SetFloat("_Green_R", _FixDistance);
			ADBKPGFMNKO().SetFloat("#FFFFFFFF", LightIntensity);
			OIIDAKBILMI().SetFloat("_ScreenResolution", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			LDNADDJMIPK().SetFloat("[NetworkManager] Exited", 499f / farClipPlane);
			FLGPDBBKAIP().SetVector("GhostSize", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1239f, 759f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material MMOODGIODPC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-69);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material ELBMIEOIABA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-110);
		}
		return BJFKDHHMLJH;
	}

	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 468f)
			{
				HBJJOCHGOPH = 123f;
			}
			OIIDAKBILMI().SetFloat("settings.shaders", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 470f)
				{
					_Distance = 1325f;
				}
				if (_Distance < 161f)
				{
					_Distance = 1970f;
				}
				IGKFMCPDNOI().SetFloat("Joystick1Button3", _Distance);
			}
			else
			{
				IGKFMCPDNOI().SetFloat("0 - background, 1 - foreground", _Distance);
			}
			CEKJODEAMGB().SetFloat("OnStatusChanged: {0} current State: {1}", _Size);
			CFEDGDGBCHE().SetFloat("float,0", _FixDistance);
			ADBKPGFMNKO().SetFloat("no lives color", LightIntensity);
			GCDFNHMJMIP().SetFloat("CameraFilterPack/Distortion_Heat", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			LELKBCALFCF().SetFloat("LoadingStatusText", 757f / farClipPlane);
			FAIFBBGFAIB().SetVector("settings.selectormapsperpage", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1508f, 1127f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FNAFGEMJBDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material ADGHJOHKEHG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material LONNIJMNKFB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.HideInHierarchy;
		}
		return BJFKDHHMLJH;
	}

	private void OCCGJMPAJIK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BJOHDLNDFAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NNBCLMJGFEN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CPCDFMMLHLO()
	{
	}

	private void JNBPKNNBMDI()
	{
	}

	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 651f)
			{
				HBJJOCHGOPH = 901f;
			}
			FAIFBBGFAIB().SetFloat("_Value13", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1840f)
				{
					_Distance = 108f;
				}
				if (_Distance < 83f)
				{
					_Distance = 1149f;
				}
				FLGPDBBKAIP().SetFloat("\n\n• ", _Distance);
			}
			else
			{
				IGIAPKPKGPK().SetFloat("Turn", _Distance);
			}
			ELBMIEOIABA().SetFloat("_Value", _Size);
			CIAFLBFJLEJ().SetFloat("shader.frost", _FixDistance);
			FNAFGEMJBDA().SetFloat("MainButton", LightIntensity);
			HBLDMJCOAHA().SetFloat("_BlurDirectionPacked", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			LELKBCALFCF().SetFloat("player.circle", 879f / farClipPlane);
			FNAFGEMJBDA().SetVector("CameraFilterPack/Blur_Noise", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1174f, 787f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LELKBCALFCF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material BBIMPFGLDCP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)112;
		}
		return BJFKDHHMLJH;
	}

	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 526f)
			{
				HBJJOCHGOPH = 822f;
			}
			HHIAIGCAHDA().SetFloat(",", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1631f)
				{
					_Distance = 1920f;
				}
				if (_Distance < 885f)
				{
					_Distance = 748f;
				}
				IGKFMCPDNOI().SetFloat("_ScreenResolution", _Distance);
			}
			else
			{
				HHLFDHNEIAH().SetFloat("Missing shader for image effect {0}", _Distance);
			}
			HBLDMJCOAHA().SetFloat("_TimeX", _Size);
			MMOODGIODPC().SetFloat("_ScreenResolution", _FixDistance);
			LDNADDJMIPK().SetFloat("_Speed", LightIntensity);
			FLGPDBBKAIP().SetFloat("_PositionX", (!_Visualize) ? 0 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			EJDPNJAEAKJ().SetFloat("GlassesColor2", 1084f / farClipPlane);
			CFEDGDGBCHE().SetVector("FinishMap", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 539f, 46f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CIAFLBFJLEJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LPPEPKGFOEM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void KCDOMIJBFLL()
	{
	}

	[SpecialName]
	private Material OIMMPLPBLBK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void EKCJHNJGGAB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1006f)
			{
				HBJJOCHGOPH = 635f;
			}
			CIAFLBFJLEJ().SetFloat("Data/Localization", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 286f)
				{
					_Distance = 1497f;
				}
				if (_Distance < 876f)
				{
					_Distance = 1492f;
				}
				JFDGLLEOPGB().SetFloat("OK", _Distance);
			}
			else
			{
				OLHDPICFBOF().SetFloat("_Value3", _Distance);
			}
			HBLDMJCOAHA().SetFloat("deletemap", _Size);
			HHLFDHNEIAH().SetFloat("achievements.26.progress", _FixDistance);
			FNAFGEMJBDA().SetFloat("GhostPosX", LightIntensity);
			HBLDMJCOAHA().SetFloat("\n", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HHLFDHNEIAH().SetFloat("_ProjInfo", 217f / farClipPlane);
			MMOODGIODPC().SetVector("SetSatelliteColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1426f, 1624f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 667f)
			{
				HBJJOCHGOPH = 766f;
			}
			MMOODGIODPC().SetFloat("Internal LUT", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1429f)
				{
					_Distance = 1180f;
				}
				if (_Distance < 1060f)
				{
					_Distance = 1128f;
				}
				LPMLLJKMAMP().SetFloat("_ScreenResolution", _Distance);
			}
			else
			{
				IGKFMCPDNOI().SetFloat(" left", _Distance);
			}
			HHLFDHNEIAH().SetFloat("x", _Size);
			ADBKPGFMNKO().SetFloat("_CenterX", _FixDistance);
			HBLDMJCOAHA().SetFloat("_Light", LightIntensity);
			CEKJODEAMGB().SetFloat("21x3", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			MMOODGIODPC().SetFloat("connect", 1196f / farClipPlane);
			FAIFBBGFAIB().SetVector("CameraFilterPack/Blend2Camera_Overlay", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 993f, 934f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
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
			BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return BJFKDHHMLJH;
	}

	private void IBPAMDEAGJL()
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
			BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void LNOOFNGHNEL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1996f)
			{
				HBJJOCHGOPH = 1689f;
			}
			EJDPNJAEAKJ().SetFloat(" {0}", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1569f)
				{
					_Distance = 1754f;
				}
				if (_Distance < 1976f)
				{
					_Distance = 833f;
				}
				NBPKMLMCHFN.SetFloat("Items/", _Distance);
			}
			else
			{
				JFDGLLEOPGB().SetFloat("#kicked", _Distance);
			}
			LONNIJMNKFB().SetFloat("Mar", _Size);
			ADGHJOHKEHG().SetFloat("value", _FixDistance);
			CIAFLBFJLEJ().SetFloat("Failed to Instantiate prefab:", LightIntensity);
			CEKJODEAMGB().SetFloat("player.linea", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			EFDEIFCDAFG().SetFloat("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", 742f / farClipPlane);
			ADGHJOHKEHG().SetVector("[Right]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1046f, 929f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HBLDMJCOAHA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GMELGGJOPBB()
	{
	}

	[SpecialName]
	private Material OIIDAKBILMI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)79;
		}
		return BJFKDHHMLJH;
	}

	private void CCLNNLCOPBL()
	{
		SCShader = Shader.Find("CrosshairOpacitySlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KLCAJPOCMPF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1001f)
			{
				HBJJOCHGOPH = 499f;
			}
			BBIMPFGLDCP().SetFloat("_BlurCoe", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 602f)
				{
					_Distance = 447f;
				}
				if (_Distance < 1686f)
				{
					_Distance = 434f;
				}
				JFDGLLEOPGB().SetFloat("_ExposureAdjustment", _Distance);
			}
			else
			{
				GCDFNHMJMIP().SetFloat("B", _Distance);
			}
			LONNIJMNKFB().SetFloat("LevelEditor/CustomEventEditor-Text", _Size);
			FLGPDBBKAIP().SetFloat("OK", _FixDistance);
			LELKBCALFCF().SetFloat("_Value3", LightIntensity);
			FAIFBBGFAIB().SetFloat("_TimeX", (!_Visualize) ? 0 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HBLDMJCOAHA().SetFloat("NEW_ACHIEVEMENT_1_", 817f / farClipPlane);
			MCDGIILBNIF().SetVector("[MenuScene] Error: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 13f, 1885f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void POENGNEMHJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1466f)
			{
				HBJJOCHGOPH = 1822f;
			}
			CIAFLBFJLEJ().SetFloat("ConfigVersionSlider", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 142f)
				{
					_Distance = 1054f;
				}
				if (_Distance < 1933f)
				{
					_Distance = 79f;
				}
				HHIAIGCAHDA().SetFloat("_TimeX", _Distance);
			}
			else
			{
				JFDGLLEOPGB().SetFloat("mapselector.lastSearch", _Distance);
			}
			CFEDGDGBCHE().SetFloat("&", _Size);
			FNAFGEMJBDA().SetFloat("CameraFilterPack/Drawing_Crosshatch", _FixDistance);
			LPPEPKGFOEM().SetFloat("_Value2", LightIntensity);
			OIMMPLPBLBK().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			MMOODGIODPC().SetFloat("00", 121f / farClipPlane);
			CIAFLBFJLEJ().SetVector("_DistortionLevel", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1241f, 325f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 117f)
			{
				HBJJOCHGOPH = 943f;
			}
			LONNIJMNKFB().SetFloat("Default UI Material", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1166f)
				{
					_Distance = 1657f;
				}
				if (_Distance < 793f)
				{
					_Distance = 757f;
				}
				FAIFBBGFAIB().SetFloat("setAF", _Distance);
			}
			else
			{
				LELKBCALFCF().SetFloat("settings.enablehitsoundsinrelax", _Distance);
			}
			LONNIJMNKFB().SetFloat("_Value", _Size);
			GCDFNHMJMIP().SetFloat("Electronic", _FixDistance);
			IGKFMCPDNOI().SetFloat("ICollection", LightIntensity);
			ADGHJOHKEHG().SetFloat("SAVE", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FLGPDBBKAIP().SetFloat("BestRegion checks region: ", 504f / farClipPlane);
			LONNIJMNKFB().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1847f, 1775f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HBLDMJCOAHA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LLDHEJIEDHO()
	{
	}

	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 808f)
			{
				HBJJOCHGOPH = 1105f;
			}
			NBPKMLMCHFN.SetFloat("setstring", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 474f)
				{
					_Distance = 1004f;
				}
				if (_Distance < 1859f)
				{
					_Distance = 1050f;
				}
				MALMMJNPILJ().SetFloat("Set Satellite Emission", _Distance);
			}
			else
			{
				FEAEGGCNIAA().SetFloat("_Value", _Distance);
			}
			EJDPNJAEAKJ().SetFloat("Set satellite MinVertexDistance - how much distance should be between to points of the trail line", _Size);
			LDNADDJMIPK().SetFloat("_Value2", _FixDistance);
			FNAFGEMJBDA().SetFloat("shader.sunny", LightIntensity);
			MALMMJNPILJ().SetFloat(" with a prefix of ", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			OIIDAKBILMI().SetFloat("/", 1395f / farClipPlane);
			ELBMIEOIABA().SetVector("Fade", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1972f, 150f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material MALMMJNPILJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)74;
		}
		return BJFKDHHMLJH;
	}

	private void NCPAFCKGJEA()
	{
	}
}
