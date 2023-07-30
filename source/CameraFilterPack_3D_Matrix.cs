// CameraFilterPack_3D_Matrix
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/3D/Matrix")]
[ExecuteInEditMode]
public class CameraFilterPack_3D_Matrix : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	public bool _Visualize;

	[Range(0f, 100f)]
	public float _FixDistance = 1f;

	[Range(-5f, 5f)]
	public float LightIntensity = 1f;

	[Range(0f, 6f)]
	public float MatrixSize = 1f;

	[Range(-4f, 4f)]
	public float MatrixSpeed = 1f;

	[Range(0f, 1f)]
	public float Fade = 1f;

	public Color _MatrixColor = new Color(0f, 1f, 0f, 1f);

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

	private void GENCBNFIILN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1332f)
			{
				HBJJOCHGOPH = 1316f;
			}
			HKGAONMOBMH().SetFloat("Bad parameters for getbool! Use <key> <value>", HBJJOCHGOPH);
			FKEOGPDLBDD().SetFloat("Joystick1Button3", Fade);
			FGENHBKMPDA().SetFloat("player ", _FixDistance);
			FHFLKLMFHOI().SetFloat("Vertical", MatrixSize);
			DNLMFEGJJDD().SetColor("_Value", _MatrixColor);
			NBPKMLMCHFN.SetFloat("CameraFilterPack_TV_Vignetting1", MatrixSpeed * 308f);
			IGKFMCPDNOI().SetFloat("BitsData", _Visualize ? 1 : 0);
			LPDOGGFOBDH().SetFloat("_CurTex", LightIntensity);
			DKNJGHFLAIF().SetTexture("_TimeX", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			CECICEGFHKL().SetFloat("MapEnd", 1932f / farClipPlane);
			DNLMFEGJJDD().SetVector("[MapEditor] Openning ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1962f, 385f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PBEPCAPAKLG()
	{
	}

	[SpecialName]
	private Material HNFFHCLNBDN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void PAEGLMEOKHP()
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
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void BGFJOEPFOPM()
	{
	}

	private void MJNPIDGNJMK()
	{
	}

	private void EPJJDKJEDMM()
	{
	}

	private void MECJHOJPODB()
	{
	}

	private void JOONHGHGKKF()
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
			if (HBJJOCHGOPH > 1030f)
			{
				HBJJOCHGOPH = 1972f;
			}
			HHIFMIPPMPF().SetFloat("_TimeX", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("mapselector.filter.favoriteonly", Fade);
			GBFOAHKAJEK().SetFloat("_Value3", _FixDistance);
			FKEOGPDLBDD().SetFloat("Joystick1Button3", MatrixSize);
			PDEAHJPOMEF().SetColor("Joystick1Button6", _MatrixColor);
			HNFFHCLNBDN().SetFloat("The authentication ticket expired. You need to connect (and authenticate) again. Disconnecting.", MatrixSpeed * 1960f);
			OJMHIMIPKME().SetFloat("CameraFilterPack/Blur_Focus", (!_Visualize) ? 0 : 0);
			CECICEGFHKL().SetFloat("_Blue_C", LightIntensity);
			IIJMIPBMMBF().SetTexture("offsets", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			IONHGBPGCHK().SetFloat("_Value3", 381f / farClipPlane);
			DNLMFEGJJDD().SetVector("OK", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1785f, 1793f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ECCPAOBFDKP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GPHPJIDGEPI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KIEJKBNBHMD()
	{
	}

	[SpecialName]
	private Material ADGHJOHKEHG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material FHFLKLMFHOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-76);
		}
		return BJFKDHHMLJH;
	}

	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 831f)
			{
				HBJJOCHGOPH = 1976f;
			}
			CECICEGFHKL().SetFloat("_Intensity", HBJJOCHGOPH);
			OJMHIMIPKME().SetFloat("y", Fade);
			PGPEMMBJOOG().SetFloat("_MatrixSize", _FixDistance);
			DONENAMLFLF().SetFloat("Set particles size", MatrixSize);
			IGKFMCPDNOI().SetColor("OpAuthenticate() failed. When you want Custom Authentication encryption is mandatory.", _MatrixColor);
			HEINDEMCGIK().SetFloat("ItemsCountText", MatrixSpeed * 250f);
			HEINDEMCGIK().SetFloat("_Parameter", _Visualize ? 1 : 0);
			CECICEGFHKL().SetFloat("_Value", LightIntensity);
			OJMHIMIPKME().SetTexture("Share", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			IGKFMCPDNOI().SetFloat("Hello", 283f / farClipPlane);
			NBPKMLMCHFN.SetVector("powerup.0", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 549f, 544f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1667f)
			{
				HBJJOCHGOPH = 200f;
			}
			HNFFHCLNBDN().SetFloat("_EmissionGain", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("_AccumulationTex", Fade);
			FGENHBKMPDA().SetFloat("_History1Weight", _FixDistance);
			MHBAIEKFBIJ().SetFloat("CameraFilterPack/TV_Noise", MatrixSize);
			DKNJGHFLAIF().SetColor("Joystick1Button8", _MatrixColor);
			HNFFHCLNBDN().SetFloat("cameramovements:", MatrixSpeed * 359f);
			FHFLKLMFHOI().SetFloat("CameraFilterPack/NightVisionFX", (!_Visualize) ? 1 : 0);
			FGENHBKMPDA().SetFloat("DISTORT", LightIntensity);
			ABHDNGIHBKE().SetTexture("DPADHOR", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			ADGHJOHKEHG().SetFloat("_VignetteTex", 181f / farClipPlane);
			HEINDEMCGIK().SetVector("COMPLETED", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1880f, 1135f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CCFEDENFNEF()
	{
		FPHEBLMINDA = Resources.Load("_Value2") as Texture2D;
		SCShader = Shader.Find("_StretchWidth");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BNEJMABFKJE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material DKNJGHFLAIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void LBPCODPOJAH()
	{
	}

	private void FOLDLDLFFLM()
	{
	}

	[SpecialName]
	private Material OJMHIMIPKME()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-65);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material CBCNOEIALHB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return BJFKDHHMLJH;
	}

	private void EHJJFJCKGAJ()
	{
	}

	private void NJBMCJOOMMP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 375f)
			{
				HBJJOCHGOPH = 1410f;
			}
			ADGHJOHKEHG().SetFloat("ticket", HBJJOCHGOPH);
			HNFFHCLNBDN().SetFloat("_Value4", Fade);
			GHHPOGODBHB().SetFloat("/", _FixDistance);
			HNFFHCLNBDN().SetFloat("mapselector.orderby", MatrixSize);
			FHFLKLMFHOI().SetColor("_TimeX", _MatrixColor);
			BBIMPFGLDCP().SetFloat("CameraFilterPack/TV_BrokenGlass2", MatrixSpeed * 1935f);
			CEKJODEAMGB().SetFloat("Beat Detected", _Visualize ? 1 : 0);
			ADGHJOHKEHG().SetFloat("_Value5", LightIntensity);
			HKGAONMOBMH().SetTexture("leave", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			CBCNOEIALHB().SetFloat("CameraFilterPack/Edge_Sigmoid", 1279f / farClipPlane);
			CBCNOEIALHB().SetVector("Gameplay/Base", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 443f, 999f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FHGKIOOMMOH()
	{
		FPHEBLMINDA = Resources.Load("[Down]") as Texture2D;
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1296f)
			{
				HBJJOCHGOPH = 316f;
			}
			IGKFMCPDNOI().SetFloat("2", HBJJOCHGOPH);
			HEINDEMCGIK().SetFloat("CameraFilterPack/Drawing_Manga_Flash_Color", Fade);
			ADGHJOHKEHG().SetFloat("settings.cameramovements", _FixDistance);
			FGENHBKMPDA().SetFloat("Can't find key ", MatrixSize);
			OJMHIMIPKME().SetColor("Connecting to server", _MatrixColor);
			GHHPOGODBHB().SetFloat("editorVolume", MatrixSpeed * 769f);
			CBCNOEIALHB().SetFloat("SetRoomStartTimestamp", (!_Visualize) ? 0 : 0);
			MHBAIEKFBIJ().SetFloat("CameraFilterPack_TV_BrokenGlass_2", LightIntensity);
			HHIFMIPPMPF().SetTexture("_Bullet_2", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			ADGHJOHKEHG().SetFloat("ViewMenu", 1200f / farClipPlane);
			IGKFMCPDNOI().SetVector("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 115f, 1630f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EJFJENFKLND()
	{
	}

	private void IFJDKDFLGBG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HLDFOJMHKNL()
	{
	}

	private void MFBCLNAHEFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 285f)
			{
				HBJJOCHGOPH = 956f;
			}
			DONENAMLFLF().SetFloat("Object ID. Case-Sensitive", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("_Value", Fade);
			FGENHBKMPDA().SetFloat("MaxLivesSlider", _FixDistance);
			HEINDEMCGIK().SetFloat("SUBMIT", MatrixSize);
			HHIFMIPPMPF().SetColor("Joystick1Button0", _MatrixColor);
			LPDOGGFOBDH().SetFloat("float,1", MatrixSpeed * 1431f);
			LPDOGGFOBDH().SetFloat("_ScreenResolution", (!_Visualize) ? 0 : 0);
			CBCNOEIALHB().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", LightIntensity);
			JFDGLLEOPGB().SetTexture("AddEnvironmentObject", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			GBFOAHKAJEK().SetFloat("_Value2", 1037f / farClipPlane);
			DONENAMLFLF().SetVector("y", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 369f, 1296f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material CECICEGFHKL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)103;
		}
		return BJFKDHHMLJH;
	}

	private void IGPCNCJIEOJ()
	{
		FPHEBLMINDA = Resources.Load("[PlayerController] ") as Texture2D;
		SCShader = Shader.Find("float");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MFLBEJHMEMO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ANCKKLFPGDI()
	{
		FPHEBLMINDA = Resources.Load("Edited unlock conditions") as Texture2D;
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DPIPGGDNGHN()
	{
	}

	private void GPNAOAKCMHC()
	{
		FPHEBLMINDA = Resources.Load("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.") as Texture2D;
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void Update()
	{
	}

	private void EKCKJLFFAID()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MPJCMKFFKHH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1984f)
			{
				HBJJOCHGOPH = 1211f;
			}
			CBCNOEIALHB().SetFloat("_LensDirtIntensity", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("/", Fade);
			DONENAMLFLF().SetFloat("CameraFilterPack/Oculus_NightVision3", _FixDistance);
			FGENHBKMPDA().SetFloat("1427616858", MatrixSize);
			CECICEGFHKL().SetColor("_Saturation", _MatrixColor);
			ADGHJOHKEHG().SetFloat("_Value2", MatrixSpeed * 475f);
			FHFLKLMFHOI().SetFloat("_Distortion", (!_Visualize) ? 1 : 1);
			LPDOGGFOBDH().SetFloat("_BlurVector", LightIntensity);
			GHHPOGODBHB().SetTexture("#close", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FKEOGPDLBDD().SetFloat("_Threshhold", 763f / farClipPlane);
			DONENAMLFLF().SetVector("Set particles gravity", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 464f, 1403f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material CEKJODEAMGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-76);
		}
		return BJFKDHHMLJH;
	}

	private void Start()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_3D_Matrix1") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/3D_Matrix");
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
			if (HBJJOCHGOPH > 563f)
			{
				HBJJOCHGOPH = 1694f;
			}
			FHFLKLMFHOI().SetFloat("[LevelEditorScene] Error: Timeout :S", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("UpdateNewsTileStart", Fade);
			GBFOAHKAJEK().SetFloat("OnPlayerGameMessage", _FixDistance);
			FGENHBKMPDA().SetFloat("_Value2", MatrixSize);
			IONHGBPGCHK().SetColor("_Value2", _MatrixColor);
			LPDOGGFOBDH().SetFloat("_Value5", MatrixSpeed * 1202f);
			HKGAONMOBMH().SetFloat("CameraFilterPack/Gradients_Therma", (!_Visualize) ? 0 : 0);
			FHFLKLMFHOI().SetFloat("menu.relaxinfo", LightIntensity);
			IGKFMCPDNOI().SetTexture("\\", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			ECCPAOBFDKP().SetFloat("yyyy-MM-dd HH:mm:ss", 527f / farClipPlane);
			ECCPAOBFDKP().SetVector("Error: I/O Failure! :(", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1461f, 1154f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material PGPEMMBJOOG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-118);
		}
		return BJFKDHHMLJH;
	}

	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 491f)
			{
				HBJJOCHGOPH = 268f;
			}
			ADGHJOHKEHG().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("#,0", Fade);
			GBFOAHKAJEK().SetFloat("_ToneCurveRange", _FixDistance);
			CEKJODEAMGB().SetFloat("SelectionBox component is on a gameObject with a Canvas Scaler component. As of now, Canvas Scalers without the default settings throw off the coordinates of the selection box. Canvas Scaler has been removed.", MatrixSize);
			DKNJGHFLAIF().SetColor("offsets", _MatrixColor);
			IONHGBPGCHK().SetFloat("settings.volume.game", MatrixSpeed * 1345f);
			FGENHBKMPDA().SetFloat("master", _Visualize ? 1 : 0);
			HHIFMIPPMPF().SetFloat("Object ID. Case-Sensitive", LightIntensity);
			OJMHIMIPKME().SetTexture("_Value3", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HILDKDFEBPF().SetFloat("menu.copyright", 751f / farClipPlane);
			GHHPOGODBHB().SetVector("plogs", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1798f, 736f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JHANGPCOCIG()
	{
		FPHEBLMINDA = Resources.Load("maps.") as Texture2D;
		SCShader = Shader.Find("EnvironmentSlider");
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void POIMNOBDBBN()
	{
	}

	private void HEBOIFKBLGD()
	{
	}

	[SpecialName]
	private Material IIJMIPBMMBF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)74;
		}
		return BJFKDHHMLJH;
	}

	private void AKHCOBHHGJP()
	{
		FPHEBLMINDA = Resources.Load("settings.arcshitsoundtimedelay") as Texture2D;
		SCShader = Shader.Find("/?player=");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HIPEHGNBJMN()
	{
		FPHEBLMINDA = Resources.Load("BadgeImage") as Texture2D;
		SCShader = Shader.Find("_Value6");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DKOPKPBLDHH()
	{
		FPHEBLMINDA = Resources.Load("SaveButton") as Texture2D;
		SCShader = Shader.Find("FullscreenToggle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 842f)
			{
				HBJJOCHGOPH = 1172f;
			}
			HEINDEMCGIK().SetFloat("_ColorBuffer", HBJJOCHGOPH);
			GHHPOGODBHB().SetFloat("sfxVolume", Fade);
			DNLMFEGJJDD().SetFloat("[MapEditor] Reset", _FixDistance);
			HHIFMIPPMPF().SetFloat(" Message: ", MatrixSize);
			GBFOAHKAJEK().SetColor("_Value", _MatrixColor);
			CBCNOEIALHB().SetFloat("Floating point textures aren't supported on this device ({0})", MatrixSpeed * 716f);
			ABHDNGIHBKE().SetFloat("GenerationMenu", (!_Visualize) ? 1 : 0);
			ADGHJOHKEHG().SetFloat("Encryption wasn't established: ", LightIntensity);
			IIJMIPBMMBF().SetTexture(".status", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HNFFHCLNBDN().SetFloat("UseScanLine", 284f / farClipPlane);
			GBFOAHKAJEK().SetVector("event", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1883f, 181f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material IGKFMCPDNOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void INLDEHPAMJC()
	{
	}

	[SpecialName]
	private Material LPDOGGFOBDH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)74;
		}
		return BJFKDHHMLJH;
	}

	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 371f)
			{
				HBJJOCHGOPH = 1693f;
			}
			HNFFHCLNBDN().SetFloat("CameraFilterPack/Blend2Camera_SoftLight", HBJJOCHGOPH);
			DONENAMLFLF().SetFloat("_TimeX", Fade);
			HEINDEMCGIK().SetFloat("_ScreenResolution", _FixDistance);
			IIJMIPBMMBF().SetFloat("00", MatrixSize);
			MHBAIEKFBIJ().SetColor("_Factor", _MatrixColor);
			DONENAMLFLF().SetFloat("player.redabstract", MatrixSpeed * 741f);
			CECICEGFHKL().SetFloat("/", _Visualize ? 1 : 0);
			GHHPOGODBHB().SetFloat("_LrDepthTex", LightIntensity);
			DNLMFEGJJDD().SetTexture("colorC", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			OJMHIMIPKME().SetFloat("</color>", 1360f / farClipPlane);
			DNLMFEGJJDD().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1705f, 898f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KDJEJBBDILE()
	{
	}

	private void FDPOFMCFBMF()
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-117);
		}
		return BJFKDHHMLJH;
	}

	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 810f)
			{
				HBJJOCHGOPH = 1513f;
			}
			PGPEMMBJOOG().SetFloat("ShineEffect", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("t", Fade);
			HEINDEMCGIK().SetFloat("DPADVER", _FixDistance);
			OJMHIMIPKME().SetFloat("yyyy", MatrixSize);
			HEINDEMCGIK().SetColor("color", _MatrixColor);
			MHBAIEKFBIJ().SetFloat("_Value4", MatrixSpeed * 845f);
			DNLMFEGJJDD().SetFloat("ConnectToMaster() failed. Can only connect while in state 'Disconnected'. Current state: ", (!_Visualize) ? 1 : 0);
			ABHDNGIHBKE().SetFloat("_TimeX", LightIntensity);
			JFDGLLEOPGB().SetTexture("_TimeX", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HILDKDFEBPF().SetFloat("B", 1243f / farClipPlane);
			CEKJODEAMGB().SetVector("fetch", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 71f, 1634f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KPOCGNOKNOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 324f)
			{
				HBJJOCHGOPH = 665f;
			}
			PDEAHJPOMEF().SetFloat("_FarCamera", HBJJOCHGOPH);
			CBCNOEIALHB().SetFloat("#rt", Fade);
			IONHGBPGCHK().SetFloat("_BorderSize", _FixDistance);
			LPDOGGFOBDH().SetFloat("LevelConfigButton", MatrixSize);
			HKGAONMOBMH().SetColor("_ScreenResolution", _MatrixColor);
			IONHGBPGCHK().SetFloat("menu.tabid", MatrixSpeed * 103f);
			EOCCJGIGEGJ().SetFloat("_Value2", (!_Visualize) ? 1 : 1);
			JFDGLLEOPGB().SetFloat("_Value4", LightIntensity);
			ADGHJOHKEHG().SetTexture("LevelInfoInputField", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			GBFOAHKAJEK().SetFloat("offsets", 1391f / farClipPlane);
			LPDOGGFOBDH().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 136f, 1792f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
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
			if (HBJJOCHGOPH > 1606f)
			{
				HBJJOCHGOPH = 1955f;
			}
			CBCNOEIALHB().SetFloat("OperationResponse ignored while disconnecting. Code: ", HBJJOCHGOPH);
			ECCPAOBFDKP().SetFloat("_ScreenResolution", Fade);
			EOCCJGIGEGJ().SetFloat("en", _FixDistance);
			EOCCJGIGEGJ().SetFloat("Right Stick Click", MatrixSize);
			FHFLKLMFHOI().SetColor("_MainTex2", _MatrixColor);
			CEKJODEAMGB().SetFloat("offsets", MatrixSpeed * 959f);
			HKGAONMOBMH().SetFloat("/theme", _Visualize ? 1 : 0);
			HKGAONMOBMH().SetFloat("action", LightIntensity);
			DNLMFEGJJDD().SetTexture(" not exist", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HEINDEMCGIK().SetFloat("#kicked", 191f / farClipPlane);
			FKEOGPDLBDD().SetVector("_Source", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1431f, 390f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OJMHIMIPKME());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-104);
		}
		return BJFKDHHMLJH;
	}

	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1809f)
			{
				HBJJOCHGOPH = 1878f;
			}
			CEKJODEAMGB().SetFloat("challenges.", HBJJOCHGOPH);
			FHFLKLMFHOI().SetFloat("_Value6", Fade);
			HHIFMIPPMPF().SetFloat("colorB", _FixDistance);
			FGENHBKMPDA().SetFloat("_Value4", MatrixSize);
			IGKFMCPDNOI().SetColor("inventory.selected.", _MatrixColor);
			JFDGLLEOPGB().SetFloat("_Value4", MatrixSpeed * 1612f);
			HILDKDFEBPF().SetFloat("Multiplayer", _Visualize ? 1 : 0);
			CBCNOEIALHB().SetFloat("_Luminance", LightIntensity);
			PDEAHJPOMEF().SetTexture("_ConsoleSettings", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			OJMHIMIPKME().SetFloat("https://steamcdn-a.akamaihd.net/steamcommunity/public/images/clans/", 1498f / farClipPlane);
			HILDKDFEBPF().SetVector("InfoCanvas", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 271f, 1967f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LOMDIOLNFHI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 849f)
			{
				HBJJOCHGOPH = 814f;
			}
			CECICEGFHKL().SetFloat("_Value", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat("_Intensity", Fade);
			HHIFMIPPMPF().SetFloat("CameraFilterPack/TV_CompressionFX", _FixDistance);
			GBFOAHKAJEK().SetFloat("SupportLogger OnDisconnectedFromPhoton().", MatrixSize);
			JFDGLLEOPGB().SetColor("_BlurSize", _MatrixColor);
			NBPKMLMCHFN.SetFloat("_MainTex2", MatrixSpeed * 1221f);
			OJMHIMIPKME().SetFloat("_Value4", (!_Visualize) ? 1 : 0);
			GBFOAHKAJEK().SetFloat("_Distortion", LightIntensity);
			HNFFHCLNBDN().SetTexture("Done!", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			DNLMFEGJJDD().SetFloat("CameraFilterPack/Blend2Camera_Lighten", 295f / farClipPlane);
			ADGHJOHKEHG().SetVector("AudioSampler", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 743f, 1879f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HEINDEMCGIK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return BJFKDHHMLJH;
	}

	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 941f)
			{
				HBJJOCHGOPH = 1929f;
			}
			MHBAIEKFBIJ().SetFloat("EnvironmentSlider", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("_Value4", Fade);
			CECICEGFHKL().SetFloat("_VelTex", _FixDistance);
			CECICEGFHKL().SetFloat("Circle", MatrixSize);
			BBIMPFGLDCP().SetColor("_TimeX", _MatrixColor);
			IONHGBPGCHK().SetFloat("Joystick", MatrixSpeed * 832f);
			PGPEMMBJOOG().SetFloat("_Intensity", _Visualize ? 1 : 0);
			LPDOGGFOBDH().SetFloat("mapselector.filter.rateduponly", LightIntensity);
			EOCCJGIGEGJ().SetTexture("_Red_R", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			EOCCJGIGEGJ().SetFloat("CameraFilterPack/EXTRA_Rotation", 1683f / farClipPlane);
			ABHDNGIHBKE().SetVector("Joystick1Button7", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1639f, 1676f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LMBDNPLDGIJ()
	{
	}

	private void OPHBLNNGFKG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1532f)
			{
				HBJJOCHGOPH = 1348f;
			}
			IIJMIPBMMBF().SetFloat("ShineEffect", HBJJOCHGOPH);
			LPDOGGFOBDH().SetFloat("DifficultyBG", Fade);
			ECCPAOBFDKP().SetFloat("Set Particles Input", _FixDistance);
			ADGHJOHKEHG().SetFloat("Fade", MatrixSize);
			HKGAONMOBMH().SetColor("_ScreenResolution", _MatrixColor);
			HILDKDFEBPF().SetFloat("PublishButton", MatrixSpeed * 1554f);
			HHIFMIPPMPF().SetFloat("{0}{1}{2}", _Visualize ? 1 : 0);
			CBCNOEIALHB().SetFloat("_FresnelFadePower", LightIntensity);
			DONENAMLFLF().SetTexture("-help", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HKGAONMOBMH().SetFloat("_Luminance", 1461f / farClipPlane);
			BBIMPFGLDCP().SetVector("CameraFilterPack/Glow_Glow_Color", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 548f, 1744f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MHBAIEKFBIJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material MHBAIEKFBIJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1177f)
			{
				HBJJOCHGOPH = 500f;
			}
			CEKJODEAMGB().SetFloat("settings.volume.menu", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("CameraFilterPack/Distortion_Dream", Fade);
			DNLMFEGJJDD().SetFloat("CameraFilterPack/TV_Distorted", _FixDistance);
			HHIFMIPPMPF().SetFloat("_Value4", MatrixSize);
			OJMHIMIPKME().SetColor("' has been reset to the fault value", _MatrixColor);
			IGKFMCPDNOI().SetFloat("CameraFilterPack/TV_Old", MatrixSpeed * 1608f);
			IGKFMCPDNOI().SetFloat("0x", _Visualize ? 1 : 0);
			DKNJGHFLAIF().SetFloat("_CenterX", LightIntensity);
			GBFOAHKAJEK().SetTexture("Subscribe: ", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			DONENAMLFLF().SetFloat("#exit", 277f / farClipPlane);
			PDEAHJPOMEF().SetVector("Uploading content...", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 949f, 198f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 74f)
			{
				HBJJOCHGOPH = 335f;
			}
			CECICEGFHKL().SetFloat(" on effect ", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat("_ColorRGB", Fade);
			HKGAONMOBMH().SetFloat("GameScene", _FixDistance);
			DONENAMLFLF().SetFloat("https://bitbucket.org/khb-soft/intralismarcsviewer/", MatrixSize);
			ABHDNGIHBKE().SetColor("ClearEnvironment", _MatrixColor);
			CEKJODEAMGB().SetFloat(".completed", MatrixSpeed * 711f);
			PDEAHJPOMEF().SetFloat("Uploading preview image", (!_Visualize) ? 1 : 0);
			DKNJGHFLAIF().SetFloat("R:", LightIntensity);
			JFDGLLEOPGB().SetTexture("b", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			DONENAMLFLF().SetFloat("table", 1279f / farClipPlane);
			GBFOAHKAJEK().SetVector("other.dust2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 21f, 882f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OJMHIMIPKME());
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
			if (HBJJOCHGOPH > 1832f)
			{
				HBJJOCHGOPH = 169f;
			}
			IGKFMCPDNOI().SetFloat("Up", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("\r", Fade);
			JFDGLLEOPGB().SetFloat("_TimeX", _FixDistance);
			GBFOAHKAJEK().SetFloat("_VelocityTex", MatrixSize);
			NBPKMLMCHFN.SetColor("ConnectToRegion: ", _MatrixColor);
			HNFFHCLNBDN().SetFloat("Save level before uploading?", MatrixSpeed * 1586f);
			OJMHIMIPKME().SetFloat("http://steamcommunity.com/sharedfiles/filedetails/?id=", (!_Visualize) ? 1 : 0);
			HKGAONMOBMH().SetFloat("_BorderColor", LightIntensity);
			PGPEMMBJOOG().SetTexture("https://www.youtube.com/watch?v=cDVXukrKo74", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			NBPKMLMCHFN.SetFloat(".png", 618f / farClipPlane);
			DKNJGHFLAIF().SetVector("] as we haven't received a full packet for delta compression yet. This is OK if it happens for the first few frames after joining a game.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 173f, 121f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FDNONDCGGCG()
	{
		FPHEBLMINDA = Resources.Load("mapselector.orderby") as Texture2D;
		SCShader = Shader.Find("Subscribed cells:\n");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GNMGIHFKJIJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OKLAJINHPAN()
	{
		FPHEBLMINDA = Resources.Load("UI Extensions/SoftMaskShaderText") as Texture2D;
		SCShader = Shader.Find("|");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ODMPMJPALID()
	{
		FPHEBLMINDA = Resources.Load("_TimeX") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Lut_Simple");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PAKPHKPDKGE()
	{
		FPHEBLMINDA = Resources.Load("Could not execute RPC ") as Texture2D;
		SCShader = Shader.Find(" / ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material BBIMPFGLDCP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HHIFMIPPMPF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-117);
		}
		return BJFKDHHMLJH;
	}

	private void CHOPDIGHJNH()
	{
		FPHEBLMINDA = Resources.Load("Start") as Texture2D;
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MEBPBNLBECA()
	{
		FPHEBLMINDA = Resources.Load("\" that takes ") as Texture2D;
		SCShader = Shader.Find("System.Int64");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material DNLMFEGJJDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)122;
		}
		return BJFKDHHMLJH;
	}

	private void CEDFFAOOPOG()
	{
		FPHEBLMINDA = Resources.Load("_TimeX") as Texture2D;
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EDDPLJGKLKJ()
	{
	}

	[SpecialName]
	private Material GBFOAHKAJEK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void HLIAEEMGBHN()
	{
		FPHEBLMINDA = Resources.Load("#tryagain") as Texture2D;
		SCShader = Shader.Find("LastHighScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1721f)
			{
				HBJJOCHGOPH = 985f;
			}
			LPDOGGFOBDH().SetFloat("_Value7", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("yes", Fade);
			EOCCJGIGEGJ().SetFloat("http://steamcommunity.com/sharedfiles/filedetails/?id=", _FixDistance);
			DKNJGHFLAIF().SetFloat("\n", MatrixSize);
			CECICEGFHKL().SetColor("(\\[ *url=)((?:https\\:\\/\\/)|(?:http\\:\\/\\/)|(?:www\\.))?([a-zA-Z0-9\\-\\.]+\\.[a-zA-Z]{2,3}(?:\\??)[a-zA-Z0-9\\-\\._\\?\\,\\'\\/\\\\\\+&%\\$#\\=~]+)(\\])", _MatrixColor);
			MHBAIEKFBIJ().SetFloat("[ItemsHandler] All in-game items loaded", MatrixSpeed * 1744f);
			FKEOGPDLBDD().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", _Visualize ? 1 : 0);
			EOCCJGIGEGJ().SetFloat("MultiplayerButton", LightIntensity);
			GBFOAHKAJEK().SetTexture("<b>", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			LPDOGGFOBDH().SetFloat("RestartButton", 803f / farClipPlane);
			OJMHIMIPKME().SetVector("_PositionY", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 508f, 1492f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CBCNOEIALHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ALJEJJCIMJN()
	{
		FPHEBLMINDA = Resources.Load("Please attach component to a Graphical UI component") as Texture2D;
		SCShader = Shader.Find("No");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KDMKDEKCELE()
	{
		FPHEBLMINDA = Resources.Load("_AreaTex") as Texture2D;
		SCShader = Shader.Find("w");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DHLCNIINMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1121f)
			{
				HBJJOCHGOPH = 1491f;
			}
			CBCNOEIALHB().SetFloat("_TimeX", HBJJOCHGOPH);
			FGENHBKMPDA().SetFloat("_Value2", Fade);
			LPDOGGFOBDH().SetFloat("_Offsets", _FixDistance);
			NBPKMLMCHFN.SetFloat("Horizontal", MatrixSize);
			CECICEGFHKL().SetColor("_Value", _MatrixColor);
			LPDOGGFOBDH().SetFloat("Case-Sensitive", MatrixSpeed * 412f);
			MHBAIEKFBIJ().SetFloat("00", (!_Visualize) ? 0 : 0);
			IIJMIPBMMBF().SetFloat("JoinRandom failed: {0}.", LightIntensity);
			FGENHBKMPDA().SetTexture("_ColorBuffer", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			NBPKMLMCHFN.SetFloat("{\"items\":", 363f / farClipPlane);
			HILDKDFEBPF().SetVector("OperationResponse ignored while disconnecting. Code: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 316f, 1109f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MHBAIEKFBIJ());
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

	private void DOOIKOEBBJB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 45f)
			{
				HBJJOCHGOPH = 1568f;
			}
			CEKJODEAMGB().SetFloat("Mouse Wheel Up", HBJJOCHGOPH);
			MHBAIEKFBIJ().SetFloat("CameraFilterPack/Gradients_Stripe", Fade);
			MHBAIEKFBIJ().SetFloat("[MenuScene] Error: ", _FixDistance);
			CECICEGFHKL().SetFloat("#combo", MatrixSize);
			CBCNOEIALHB().SetColor("Tab1Content", _MatrixColor);
			MHBAIEKFBIJ().SetFloat("_ReflectionTexture3", MatrixSpeed * 1575f);
			IGKFMCPDNOI().SetFloat("menutheme.deleted", (!_Visualize) ? 1 : 0);
			IIJMIPBMMBF().SetFloat("/", LightIntensity);
			IONHGBPGCHK().SetTexture("_Value4", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			OJMHIMIPKME().SetFloat("No Name", 1104f / farClipPlane);
			GBFOAHKAJEK().SetVector("ConnectionTimeout", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1902f, 219f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HILDKDFEBPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NEKCPLGFOFD()
	{
	}

	private void PKGJJFIFLII()
	{
	}

	[SpecialName]
	private Material HILDKDFEBPF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-123);
		}
		return BJFKDHHMLJH;
	}

	private void HLHJBJGEEEA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AKCADICOFDD()
	{
	}

	[SpecialName]
	private Material JFDGLLEOPGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)124;
		}
		return BJFKDHHMLJH;
	}

	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1897f)
			{
				HBJJOCHGOPH = 374f;
			}
			OJMHIMIPKME().SetFloat("_Visualize", HBJJOCHGOPH);
			MHBAIEKFBIJ().SetFloat("X2", Fade);
			IIJMIPBMMBF().SetFloat("maps.", _FixDistance);
			DONENAMLFLF().SetFloat("{0:0.0} ms ({1:0.} fps)", MatrixSize);
			FGENHBKMPDA().SetColor("CameraFilterPack/Gradients_Rainbow", _MatrixColor);
			HKGAONMOBMH().SetFloat("FinishMap", MatrixSpeed * 1425f);
			BBIMPFGLDCP().SetFloat("Set Sun Sensitivity", _Visualize ? 1 : 0);
			BBIMPFGLDCP().SetFloat("_ScreenResolution", LightIntensity);
			EOCCJGIGEGJ().SetTexture("menu.copyright", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FHFLKLMFHOI().SetFloat("CameraFilterPack/TV_Vcr", 1587f / farClipPlane);
			IONHGBPGCHK().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 916f, 1201f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DONENAMLFLF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material ECCPAOBFDKP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return BJFKDHHMLJH;
	}

	private void KLILJHJNICK()
	{
		FPHEBLMINDA = Resources.Load("SetParticlesCountPerBeat") as Texture2D;
		SCShader = Shader.Find("Freq: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1612f)
			{
				HBJJOCHGOPH = 31f;
			}
			ECCPAOBFDKP().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			HEINDEMCGIK().SetFloat("settings.fps", Fade);
			FKEOGPDLBDD().SetFloat("settings.arcsdestroydelay", _FixDistance);
			NBPKMLMCHFN.SetFloat("Drop_Far", MatrixSize);
			IONHGBPGCHK().SetColor("MouseX", _MatrixColor);
			FGENHBKMPDA().SetFloat("Exception while connecting to: ", MatrixSpeed * 1974f);
			ABHDNGIHBKE().SetFloat("note.1", (!_Visualize) ? 1 : 0);
			LPDOGGFOBDH().SetFloat("OpJoinRandomRoom()", LightIntensity);
			PGPEMMBJOOG().SetTexture("_Value7", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			JFDGLLEOPGB().SetFloat("CameraFilterPack/Drawing_BluePrint", 839f / farClipPlane);
			ECCPAOBFDKP().SetVector("[Left]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 9f, 1788f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JONGNKNLLND()
	{
		FPHEBLMINDA = Resources.Load("896296812") as Texture2D;
		SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AOKOLPEGHDD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IKMELABKBHO()
	{
	}

	private void CGDMLHLJIDK()
	{
		FPHEBLMINDA = Resources.Load("steamid") as Texture2D;
		SCShader = Shader.Find("_Colorisation");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MKOMIDCPCDC()
	{
		FPHEBLMINDA = Resources.Load("_Extra") as Texture2D;
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BEBNOKFLJPH()
	{
		FPHEBLMINDA = Resources.Load("_MainTex2") as Texture2D;
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KCDOMIJBFLL()
	{
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1117f)
			{
				HBJJOCHGOPH = 291f;
			}
			FHFLKLMFHOI().SetFloat("Default UI Material", HBJJOCHGOPH);
			HNFFHCLNBDN().SetFloat("Bad parameters for getbool! Use <key> <value>", Fade);
			HNFFHCLNBDN().SetFloat("Tab2Content", _FixDistance);
			ADGHJOHKEHG().SetFloat("_MainTex2", MatrixSize);
			PGPEMMBJOOG().SetColor("_Threshold", _MatrixColor);
			IONHGBPGCHK().SetFloat("/icon", MatrixSpeed * 211f);
			OJMHIMIPKME().SetFloat("stretchWidth", (!_Visualize) ? 1 : 0);
			DKNJGHFLAIF().SetFloat("Tab2Content", LightIntensity);
			ADGHJOHKEHG().SetTexture("file://", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FGENHBKMPDA().SetFloat("Set Sun Emission", 1801f / farClipPlane);
			HKGAONMOBMH().SetVector("input", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1234f, 253f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FOAGAKFBIGD()
	{
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EFJDNLGNACH()
	{
		FPHEBLMINDA = Resources.Load("MapEditor v.") as Texture2D;
		SCShader = Shader.Find("Tab1Content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void APKNAPHOFHC()
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
			NBPKMLMCHFN.SetFloat("_FixDistance", _FixDistance);
			NBPKMLMCHFN.SetFloat("_MatrixSize", MatrixSize);
			NBPKMLMCHFN.SetColor("_MatrixColor", _MatrixColor);
			NBPKMLMCHFN.SetFloat("_MatrixSpeed", MatrixSpeed * 2f);
			NBPKMLMCHFN.SetFloat("_Visualize", _Visualize ? 1 : 0);
			NBPKMLMCHFN.SetFloat("_LightIntensity", LightIntensity);
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

	private void DIGHKAJILJH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CFFCLAHMBAA()
	{
		FPHEBLMINDA = Resources.Load("settings.enableranking") as Texture2D;
		SCShader = Shader.Find("replayData");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EIDKCANPHJE()
	{
	}

	private void EODOHEAKJFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GAOOPEEBGJA()
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

	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 631f)
			{
				HBJJOCHGOPH = 927f;
			}
			ABHDNGIHBKE().SetFloat("CurrentTimeLabel", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("DifficultyBG", Fade);
			LPDOGGFOBDH().SetFloat("Set Particles Count Per Beat", _FixDistance);
			LPDOGGFOBDH().SetFloat(". The group number should be at least 1.", MatrixSize);
			FHFLKLMFHOI().SetColor("_ScreenResolution", _MatrixColor);
			HEINDEMCGIK().SetFloat("HandsCountSlider", MatrixSpeed * 948f);
			HHIFMIPPMPF().SetFloat("The binding '", (!_Visualize) ? 0 : 0);
			CBCNOEIALHB().SetFloat("<b>Commands:</b>\n/help\n/players\n/kick\n/table\n/clear", LightIntensity);
			HKGAONMOBMH().SetTexture("PhotonNetwork.room is null. You don't have to call LeaveRoom() when you're not in one. State: ", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			CBCNOEIALHB().SetFloat("Preparing configuration", 31f / farClipPlane);
			EOCCJGIGEGJ().SetVector("_MainTex2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 660f, 155f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material ABHDNGIHBKE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
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

	private void DAHFFNNIGML()
	{
		FPHEBLMINDA = Resources.Load("COMPLETED") as Texture2D;
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GBGAMCPNBCC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HKGAONMOBMH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}
}
