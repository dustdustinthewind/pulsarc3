// CameraFilterPack_3D_Inverse
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/3D/Inverse")]
[ExecuteInEditMode]
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
		SCShader = Shader.Find("RateButton");
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
			FNAFGEMJBDA().SetFloat("_Value", HBJJOCHGOPH);
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
				EFDEIFCDAFG().SetFloat("CameraFilterPack/AAA_Blood_Plus", _Distance);
			}
			else
			{
				EFDEIFCDAFG().SetFloat("_Value2", _Distance);
			}
			JFDGLLEOPGB().SetFloat("Texture2", _Size);
			OLHDPICFBOF().SetFloat("Data/Localization", _FixDistance);
			EJDPNJAEAKJ().SetFloat("LivesSlider", LightIntensity);
			BBIMPFGLDCP().SetFloat("#pleasewait", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			CFEDGDGBCHE().SetFloat("[DiscordController] Join ({0})", 1195f / farClipPlane);
			MALMMJNPILJ().SetVector("[MapsData] Caching ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 35f, 1294f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB());
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
			HBLDMJCOAHA().SetFloat("#yes", HBJJOCHGOPH);
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
				OIMMPLPBLBK().SetFloat("VIGNETTE_FILMIC", _Distance);
			}
			else
			{
				MALMMJNPILJ().SetFloat("_Blend", _Distance);
			}
			GCDFNHMJMIP().SetFloat("skin.hit_perfect", _Size);
			LPMLLJKMAMP().SetFloat("CameraFilterPack/Edge_Sigmoid", _FixDistance);
			FLGPDBBKAIP().SetFloat("OnPhotonRandomJoinFailed() was called by PUN. No random room available, so we create one. Calling: PhotonNetwork.CreateRoom(null, new RoomOptions() {maxPlayers = 4}, null);", LightIntensity);
			MCDGIILBNIF().SetFloat("0.00", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			LONNIJMNKFB().SetFloat(" ", 518f / farClipPlane);
			MALMMJNPILJ().SetVector(";", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1749f, 1436f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BBIMPFGLDCP());
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
		SCShader = Shader.Find("Cancel");
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
		SCShader = Shader.Find(" Also make sure to disable sprite packing for this sprite.");
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
		SCShader = Shader.Find("_AllowBackwardsRays");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IBJIBLHJKMG()
	{
		SCShader = Shader.Find("player.redlifering");
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
		SCShader = Shader.Find("_BgFade");
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
		SCShader = Shader.Find("[PlayerController] ");
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
		SCShader = Shader.Find("/");
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
		SCShader = Shader.Find("[MapEditor] Updating map assets");
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
			LELKBCALFCF().SetFloat("_ScreenResolution", HBJJOCHGOPH);
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
				GCDFNHMJMIP().SetFloat(".progress", _Distance);
			}
			else
			{
				MALMMJNPILJ().SetFloat("LoadingStatusText", _Distance);
			}
			JFDGLLEOPGB().SetFloat("#ok", _Size);
			EJDPNJAEAKJ().SetFloat("Tab2Content", _FixDistance);
			CEKJODEAMGB().SetFloat("_LightIntensity", LightIntensity);
			FAIFBBGFAIB().SetFloat("NewIconFileSelector", (!_Visualize) ? 0 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			MMOODGIODPC().SetFloat("_MaxRadiusOrKInPaper", 915f / farClipPlane);
			LPMLLJKMAMP().SetVector("OnPress", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 78f, 616f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
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
			FEAEGGCNIAA().SetFloat(" cannot be used as a 3D LUT.", HBJJOCHGOPH);
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
				EJDPNJAEAKJ().SetFloat("CameraFilterPack/FX_Glitch2", _Distance);
			}
			else
			{
				FLGPDBBKAIP().SetFloat(" base map(s)", _Distance);
			}
			LONNIJMNKFB().SetFloat("EnableRankingToggle", _Size);
			BBIMPFGLDCP().SetFloat(":</b> ", _FixDistance);
			FEAEGGCNIAA().SetFloat("_Glitch", LightIntensity);
			OLHDPICFBOF().SetFloat("Cant ask anyone else for PickupItem spawn times.", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			OLHDPICFBOF().SetFloat("BloodAlternative1", 1939f / farClipPlane);
			LONNIJMNKFB().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 304f, 59f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
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
		SCShader = Shader.Find("_ForceYSwap");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FEGJMDDIDIC()
	{
		SCShader = Shader.Find("couldn't be found!");
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
			LELKBCALFCF().SetFloat("LoadingStatusText", HBJJOCHGOPH);
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
				OIIDAKBILMI().SetFloat("bool", _Distance);
			}
			else
			{
				CFEDGDGBCHE().SetFloat("_ScreenResolution", _Distance);
			}
			IGKFMCPDNOI().SetFloat("y", _Size);
			HHIAIGCAHDA().SetFloat("PlayersScrollRectContent", _FixDistance);
			ADGHJOHKEHG().SetFloat("/icon", LightIntensity);
			OLHDPICFBOF().SetFloat("AudioSampler", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			MMOODGIODPC().SetFloat(" ", 15f / farClipPlane);
			LPMLLJKMAMP().SetVector("<b>Speed</b>:", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1949f, 1322f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BOPKKCAFODF()
	{
		SCShader = Shader.Find("_ScreenResolution");
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
		SCShader = Shader.Find("settings.arcsdestroydelay");
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
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FNCDAPDOBBI()
	{
		SCShader = Shader.Find("settings.disablestoryboard");
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
		SCShader = Shader.Find("[PlayerBase] Loading checkpoint data");
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
		SCShader = Shader.Find("[LevelEditorScene] Map submitted!");
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
			JFDGLLEOPGB().SetFloat("Run a command for the Localization Servise", HBJJOCHGOPH);
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
				EFDEIFCDAFG().SetFloat("mapselector.filter.subscribedonly", _Distance);
			}
			else
			{
				LPPEPKGFOEM().SetFloat("color", _Distance);
			}
			HHIAIGCAHDA().SetFloat("_NeighbourMaxTex", _Size);
			OIIDAKBILMI().SetFloat("_TimeX", _FixDistance);
			ADGHJOHKEHG().SetFloat("_ScreenResolution", LightIntensity);
			CFEDGDGBCHE().SetFloat("EventSystem", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			ADBKPGFMNKO().SetFloat("input", 1551f / farClipPlane);
			IGKFMCPDNOI().SetVector("_Intensity", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 274f, 1406f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CIAFLBFJLEJ());
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
		SCShader = Shader.Find("_BlurVector");
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
			HHIAIGCAHDA().SetFloat("Start", HBJJOCHGOPH);
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
				BBIMPFGLDCP().SetFloat("mapselector.orderby", _Distance);
			}
			else
			{
				FEAEGGCNIAA().SetFloat("_ScreenResolution", _Distance);
			}
			FEAEGGCNIAA().SetFloat("</color>", _Size);
			EFDEIFCDAFG().SetFloat("Right", _FixDistance);
			CEKJODEAMGB().SetFloat("Horizontal", LightIntensity);
			OIMMPLPBLBK().SetFloat(".lastCheckpoint.isMapCompleted", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			OLHDPICFBOF().SetFloat("/", 1878f / farClipPlane);
			CEKJODEAMGB().SetVector("_CenterX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 542f, 1182f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
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
		SCShader = Shader.Find("{0:0.0} ms ({1:0.} fps)");
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
			IGIAPKPKGPK().SetFloat("0,1,false", HBJJOCHGOPH);
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
				OIIDAKBILMI().SetFloat("_Bloom0", _Distance);
			}
			else
			{
				FEAEGGCNIAA().SetFloat("_Value2", _Distance);
			}
			OLHDPICFBOF().SetFloat("_Red_B", _Size);
			FAIFBBGFAIB().SetFloat("unsubscribemap", _FixDistance);
			GCDFNHMJMIP().SetFloat("_TimeX", LightIntensity);
			EJDPNJAEAKJ().SetFloat("menu.enableselectormusic", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			LPPEPKGFOEM().SetFloat("_TapMedium", 1921f / farClipPlane);
			FLGPDBBKAIP().SetVector("_Threshhold", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 273f, 768f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EJDPNJAEAKJ());
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
			EFDEIFCDAFG().SetFloat("_Value3", HBJJOCHGOPH);
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
				CFEDGDGBCHE().SetFloat("{0:0} hour{1}, ", _Distance);
			}
			else
			{
				LPMLLJKMAMP().SetFloat(" canvas not found", _Distance);
			}
			FAIFBBGFAIB().SetFloat("#restart", _Size);
			FEAEGGCNIAA().SetFloat(" has been disabled as it's not supported on the current platform.", _FixDistance);
			LPMLLJKMAMP().SetFloat("_TimeX", LightIntensity);
			FAIFBBGFAIB().SetFloat("_Value4", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			LPMLLJKMAMP().SetFloat("_Bullet_9", 1462f / farClipPlane);
			LPPEPKGFOEM().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 900f, 727f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
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
			MMOODGIODPC().SetFloat("cancel", HBJJOCHGOPH);
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
				IGKFMCPDNOI().SetFloat("_CameraToWorldMatrix", _Distance);
			}
			else
			{
				CIAFLBFJLEJ().SetFloat("_Value3", _Distance);
			}
			LONNIJMNKFB().SetFloat("/", _Size);
			LPPEPKGFOEM().SetFloat("_Distortion", _FixDistance);
			FLGPDBBKAIP().SetFloat("#8E8E8EFF", LightIntensity);
			OLHDPICFBOF().SetFloat("ConfigVersionSlider", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FLGPDBBKAIP().SetFloat("_Gamma", 1459f / farClipPlane);
			BBIMPFGLDCP().SetVector("selector", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 887f, 1498f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHLFDHNEIAH());
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
			EFDEIFCDAFG().SetFloat("time", HBJJOCHGOPH);
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
				OLHDPICFBOF().SetFloat(".lastCheckpoint.lives", _Distance);
			}
			else
			{
				CEKJODEAMGB().SetFloat("player.licenceaccepted", _Distance);
			}
			EFDEIFCDAFG().SetFloat("_Threshold", _Size);
			HHLFDHNEIAH().SetFloat("<b>Kick player by NetID</b>\nuse: /kick {NetID}\nUse \"/players\" command to get all NetIDs\nRoom owner only can kick the players", _FixDistance);
			LELKBCALFCF().SetFloat("#tryagain", LightIntensity);
			ADBKPGFMNKO().SetFloat("#outdatedmap! Challenges will not work!", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			ELBMIEOIABA().SetFloat("float,10", 48f / farClipPlane);
			JFDGLLEOPGB().SetVector("settings.gamemessagesduration", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1395f, 1845f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
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
			IGKFMCPDNOI().SetFloat("SaveButton", HBJJOCHGOPH);
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
				HHLFDHNEIAH().SetFloat("[PlayerController] ", _Distance);
			}
			else
			{
				BBIMPFGLDCP().SetFloat("downloading", _Distance);
			}
			JFDGLLEOPGB().SetFloat("_EmissionGain", _Size);
			MCDGIILBNIF().SetFloat("_ScreenResolution", _FixDistance);
			HHLFDHNEIAH().SetFloat("/", LightIntensity);
			FNAFGEMJBDA().SetFloat("_Value5", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			LPMLLJKMAMP().SetFloat("[DiscordController] Sectate ({0})", 776f / farClipPlane);
			GCDFNHMJMIP().SetVector("GridDataStoryboard", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1855f, 554f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
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
			LPPEPKGFOEM().SetFloat("MenuScene", HBJJOCHGOPH);
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
				LDNADDJMIPK().SetFloat(" cannot be used as a 3D LUT.", _Distance);
			}
			else
			{
				HHIAIGCAHDA().SetFloat("id", _Distance);
			}
			FNAFGEMJBDA().SetFloat("_Saturation", _Size);
			LELKBCALFCF().SetFloat("CameraFilterPack/Color_Chromatic_Plus", _FixDistance);
			LPPEPKGFOEM().SetFloat("Run a command for the Localization Servise", LightIntensity);
			MALMMJNPILJ().SetFloat("_TimeX", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HHLFDHNEIAH().SetFloat("PAUSE [SPACE]", 1998f / farClipPlane);
			HHLFDHNEIAH().SetVector("CameraFilterPack_AAA_Blood2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1738f, 1842f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FNAFGEMJBDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HPFIHLMKIPF()
	{
		SCShader = Shader.Find("_LensDirt");
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
			NBPKMLMCHFN.SetFloat(". Client should be in a room. Current connectionStateDetailed: ", HBJJOCHGOPH);
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
				MMOODGIODPC().SetFloat(": ", _Distance);
			}
			else
			{
				IGIAPKPKGPK().SetFloat("editorVolume", _Distance);
			}
			BBIMPFGLDCP().SetFloat("CameraFilterPack/Drawing_NewCellShading", _Size);
			LONNIJMNKFB().SetFloat("BitsData", _FixDistance);
			ELBMIEOIABA().SetFloat("blue", LightIntensity);
			EJDPNJAEAKJ().SetFloat("skin.", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			OIMMPLPBLBK().SetFloat("OK", 1862f / farClipPlane);
			HHIAIGCAHDA().SetVector("Aug", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1371f, 1265f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GLEJGFLCLPJ()
	{
		SCShader = Shader.Find("settings.arcsdestroydelay");
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
		SCShader = Shader.Find("_ChromaticAberration");
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
			LDNADDJMIPK().SetFloat("misses", HBJJOCHGOPH);
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
				ADBKPGFMNKO().SetFloat("OK", _Distance);
			}
			else
			{
				LONNIJMNKFB().SetFloat("DisableStoryboardToggle", _Distance);
			}
			IGKFMCPDNOI().SetFloat("PunPickupSimple", _Size);
			OIIDAKBILMI().SetFloat("/", _FixDistance);
			EFDEIFCDAFG().SetFloat("_TimeX", LightIntensity);
			ELBMIEOIABA().SetFloat("set environment id", (!_Visualize) ? 0 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			LELKBCALFCF().SetFloat("_Value2", 1096f / farClipPlane);
			LELKBCALFCF().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 306f, 23f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LELKBCALFCF());
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
			LPPEPKGFOEM().SetFloat("_DotSize", HBJJOCHGOPH);
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
				IGIAPKPKGPK().SetFloat("{0}{1}{2}={3}", _Distance);
			}
			else
			{
				EJDPNJAEAKJ().SetFloat("_Distortion", _Distance);
			}
			OLHDPICFBOF().SetFloat("ReJoinRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", _Size);
			CIAFLBFJLEJ().SetFloat("0.00", _FixDistance);
			EJDPNJAEAKJ().SetFloat("Editor/", LightIntensity);
			HBLDMJCOAHA().SetFloat("_TimeX", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HHLFDHNEIAH().SetFloat(" cannot be used as a 3D LUT.", 117f / farClipPlane);
			CIAFLBFJLEJ().SetVector("offline", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1579f, 437f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
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
		SCShader = Shader.Find("This might be a misconfiguration in the game server config. You need to edit it to a (public) address.");
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
			LELKBCALFCF().SetFloat("_TimeX", HBJJOCHGOPH);
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
				MCDGIILBNIF().SetFloat("CameraFilterPack/3D_Scan_Scene", _Distance);
			}
			else
			{
				CFEDGDGBCHE().SetFloat("/", _Distance);
			}
			BBIMPFGLDCP().SetFloat("Updated!", _Size);
			ADGHJOHKEHG().SetFloat(",", _FixDistance);
			FLGPDBBKAIP().SetFloat("inventory.selected.", LightIntensity);
			ELBMIEOIABA().SetFloat("CameraFilterPack/Blur_Blurry", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			IGKFMCPDNOI().SetFloat("float,1", 692f / farClipPlane);
			HHIAIGCAHDA().SetVector("0.00/0.00", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1100f, 1624f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			MALMMJNPILJ().SetFloat("Object ID. Case-Sensitive", HBJJOCHGOPH);
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
				LELKBCALFCF().SetFloat("settings.gamemessagesduration", _Distance);
			}
			else
			{
				LELKBCALFCF().SetFloat("The observed monobehaviour (", _Distance);
			}
			IGKFMCPDNOI().SetFloat("[PlayerBase] Game mode: ", _Size);
			IGKFMCPDNOI().SetFloat("_Red_B", _FixDistance);
			CEKJODEAMGB().SetFloat("#FFFFFFFF", LightIntensity);
			EJDPNJAEAKJ().SetFloat("_ScreenResolution", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			CEKJODEAMGB().SetFloat("In Main Menu", 499f / farClipPlane);
			ADGHJOHKEHG().SetVector("GhostSize", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1239f, 759f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHLFDHNEIAH());
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
			GCDFNHMJMIP().SetFloat("settings.shaders", HBJJOCHGOPH);
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
				IGKFMCPDNOI().SetFloat("Circle", _Distance);
			}
			else
			{
				LELKBCALFCF().SetFloat("0 - background, 1 - foreground", _Distance);
			}
			MMOODGIODPC().SetFloat("GetGameList failed: ", _Size);
			FAIFBBGFAIB().SetFloat("float,0", _FixDistance);
			EJDPNJAEAKJ().SetFloat("no lives color", LightIntensity);
			CFEDGDGBCHE().SetFloat("CameraFilterPack/Distortion_Heat", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HHLFDHNEIAH().SetFloat("[MapsData] Caching ", 757f / farClipPlane);
			EJDPNJAEAKJ().SetVector("settings.arcshitsoundtimedelay", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1508f, 1127f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
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
			EFDEIFCDAFG().SetFloat("_Value13", HBJJOCHGOPH);
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
				FEAEGGCNIAA().SetFloat(":\n", _Distance);
			}
			else
			{
				HHIAIGCAHDA().SetFloat("turn", _Distance);
			}
			HHIAIGCAHDA().SetFloat("_TimeX", _Size);
			IGKFMCPDNOI().SetFloat("settings.shaders", _FixDistance);
			CIAFLBFJLEJ().SetFloat(" ", LightIntensity);
			HBLDMJCOAHA().SetFloat("_PrevViewProj", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			ELBMIEOIABA().SetFloat("menutheme.27thfloor", 879f / farClipPlane);
			LPMLLJKMAMP().SetVector("CameraFilterPack/Blur_Noise", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1174f, 787f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CIAFLBFJLEJ());
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
			MALMMJNPILJ().SetFloat("settings.disablestoryboard", HBJJOCHGOPH);
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
				HHLFDHNEIAH().SetFloat("_TimeX", _Distance);
			}
			else
			{
				CIAFLBFJLEJ().SetFloat("_BaseTex", _Distance);
			}
			MALMMJNPILJ().SetFloat("_MainTex2", _Size);
			CIAFLBFJLEJ().SetFloat("_ScreenResolution", _FixDistance);
			EFDEIFCDAFG().SetFloat("_Value3", LightIntensity);
			LPPEPKGFOEM().SetFloat("_PositionX", (!_Visualize) ? 0 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			EFDEIFCDAFG().SetFloat("GlassesColor", 1084f / farClipPlane);
			OIMMPLPBLBK().SetVector("_DiffuseColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 539f, 46f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
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
			LPPEPKGFOEM().SetFloat("#{0}", HBJJOCHGOPH);
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
				LPMLLJKMAMP().SetFloat("OK", _Distance);
			}
			else
			{
				LPMLLJKMAMP().SetFloat("_Value3", _Distance);
			}
			CFEDGDGBCHE().SetFloat("/", _Size);
			ADBKPGFMNKO().SetFloat("NEW_ACHIEVEMENT_1_26", _FixDistance);
			JFDGLLEOPGB().SetFloat("GhostPosX", LightIntensity);
			GCDFNHMJMIP().SetFloat("\n", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			EFDEIFCDAFG().SetFloat("_Intensity", 217f / farClipPlane);
			LDNADDJMIPK().SetVector("SetSunMaxSize", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1426f, 1624f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
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
			JFDGLLEOPGB().SetFloat("_CurrentMipLevel", HBJJOCHGOPH);
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
				FLGPDBBKAIP().SetFloat("_Value2", _Distance);
			}
			else
			{
				EJDPNJAEAKJ().SetFloat(" left", _Distance);
			}
			EFDEIFCDAFG().SetFloat("g", _Size);
			CFEDGDGBCHE().SetFloat("_SpotSize", _FixDistance);
			NBPKMLMCHFN.SetFloat("_Intensity", LightIntensity);
			OLHDPICFBOF().SetFloat("23x3", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			MALMMJNPILJ().SetFloat("\n", 1196f / farClipPlane);
			EJDPNJAEAKJ().SetVector("CameraFilterPack/Blend2Camera_Overlay", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 993f, 934f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPPEPKGFOEM());
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
			CEKJODEAMGB().SetFloat("{0}", HBJJOCHGOPH);
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
				CFEDGDGBCHE().SetFloat("inventory.selected.", _Distance);
			}
			else
			{
				HBLDMJCOAHA().SetFloat("#kicked", _Distance);
			}
			IGIAPKPKGPK().SetFloat("Year_", _Size);
			MALMMJNPILJ().SetFloat("value", _FixDistance);
			FLGPDBBKAIP().SetFloat(". Client should be in a room. Current connectionStateDetailed: ", LightIntensity);
			EFDEIFCDAFG().SetFloat("player.dragon", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FNAFGEMJBDA().SetFloat("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", 742f / farClipPlane);
			OLHDPICFBOF().SetVector("Gameplay/particles", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1046f, 929f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPPEPKGFOEM());
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
			IGKFMCPDNOI().SetFloat("_BlurParams", HBJJOCHGOPH);
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
				LELKBCALFCF().SetFloat("_RangeScale", _Distance);
			}
			else
			{
				MMOODGIODPC().SetFloat("Joystick1Button2", _Distance);
			}
			CEKJODEAMGB().SetFloat("steamid", _Size);
			HBLDMJCOAHA().SetFloat("Done!", _FixDistance);
			FLGPDBBKAIP().SetFloat("_Value2", LightIntensity);
			CFEDGDGBCHE().SetFloat("CameraFilterPack/OldFilm_Cutting1", (!_Visualize) ? 0 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			MCDGIILBNIF().SetFloat("NEW_ACHIEVEMENT_1_", 817f / farClipPlane);
			CFEDGDGBCHE().SetVector("[MenuScene] Error: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 13f, 1885f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
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
			FAIFBBGFAIB().SetFloat("maps.", HBJJOCHGOPH);
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
				ADGHJOHKEHG().SetFloat("_ScreenResolution", _Distance);
			}
			else
			{
				FEAEGGCNIAA().SetFloat("PopulateMapsList", _Distance);
			}
			FEAEGGCNIAA().SetFloat("lobby '{0}'[{1}]", _Size);
			ADBKPGFMNKO().SetFloat("CameraFilterPack/Drawing_Crosshatch", _FixDistance);
			LPPEPKGFOEM().SetFloat("_Value", LightIntensity);
			HHLFDHNEIAH().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			ADBKPGFMNKO().SetFloat("00", 121f / farClipPlane);
			GCDFNHMJMIP().SetVector("_FixDistance", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1241f, 325f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MALMMJNPILJ());
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
			ADBKPGFMNKO().SetFloat("UI Extensions/UI Image Crop", HBJJOCHGOPH);
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
				HHLFDHNEIAH().SetFloat("Achievement 21 progress reseted", _Distance);
			}
			else
			{
				LDNADDJMIPK().SetFloat("powerup.1", _Distance);
			}
			IGIAPKPKGPK().SetFloat("_TimeX", _Size);
			HHLFDHNEIAH().SetFloat("Electronic", _FixDistance);
			HHLFDHNEIAH().SetFloat("z", LightIntensity);
			MMOODGIODPC().SetFloat("/", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			IGKFMCPDNOI().SetFloat("(scene)", 504f / farClipPlane);
			MCDGIILBNIF().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1847f, 1775f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
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
			MCDGIILBNIF().SetFloat("setstring", HBJJOCHGOPH);
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
				LPMLLJKMAMP().SetFloat("Set Satellite Emission", _Distance);
			}
			else
			{
				LDNADDJMIPK().SetFloat("_Value", _Distance);
			}
			FAIFBBGFAIB().SetFloat("float,2", _Size);
			CIAFLBFJLEJ().SetFloat("_Value", _FixDistance);
			JFDGLLEOPGB().SetFloat("shader.sunny", LightIntensity);
			FEAEGGCNIAA().SetFloat("Received RPC \"", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FAIFBBGFAIB().SetFloat("Editor/", 1395f / farClipPlane);
			CFEDGDGBCHE().SetVector("UseFinalGlassColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1972f, 150f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
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
