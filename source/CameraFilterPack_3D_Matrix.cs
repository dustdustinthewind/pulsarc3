// CameraFilterPack_3D_Matrix
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/3D/Matrix")]
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
			EOCCJGIGEGJ().SetFloat("Bad parameters for getbool! Use <key> <value>", HBJJOCHGOPH);
			HNFFHCLNBDN().SetFloat("Triangle", Fade);
			HKGAONMOBMH().SetFloat("Chat", _FixDistance);
			OJMHIMIPKME().SetFloat(" registered.", MatrixSize);
			IONHGBPGCHK().SetColor("_Value", _MatrixColor);
			DKNJGHFLAIF().SetFloat("Vignette", MatrixSpeed * 308f);
			FGENHBKMPDA().SetFloat("BitsData", _Visualize ? 1 : 0);
			CECICEGFHKL().SetFloat("offsets", LightIntensity);
			DKNJGHFLAIF().SetTexture("_TimeX", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			DNLMFEGJJDD().SetFloat("MapEnd", 1932f / farClipPlane);
			FGENHBKMPDA().SetVector(".sawoutdatedmessage", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1962f, 385f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CBCNOEIALHB());
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
			CBCNOEIALHB().SetFloat("_Distortion", HBJJOCHGOPH);
			DONENAMLFLF().SetFloat("menu.tabid", Fade);
			CECICEGFHKL().SetFloat("_Value3", _FixDistance);
			NBPKMLMCHFN.SetFloat("Y", MatrixSize);
			PGPEMMBJOOG().SetColor("Joystick1Button7", _MatrixColor);
			FHFLKLMFHOI().SetFloat("Received your NickName from server. Updating local value to: {0}", MatrixSpeed * 1960f);
			ABHDNGIHBKE().SetFloat("_TimeX", (!_Visualize) ? 0 : 0);
			GHHPOGODBHB().SetFloat("_FadeFX", LightIntensity);
			HKGAONMOBMH().SetTexture("offsets", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			MHBAIEKFBIJ().SetFloat("_Value4", 381f / farClipPlane);
			DKNJGHFLAIF().SetVector("menu.hardcoreinfo", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1785f, 1793f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
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
			GHHPOGODBHB().SetFloat("_Light", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("y", Fade);
			DONENAMLFLF().SetFloat("_MatrixSize", _FixDistance);
			DNLMFEGJJDD().SetFloat("Set particles size", MatrixSize);
			NBPKMLMCHFN.SetColor("Expected protocol set to UDP, due to encryption mode DatagramEncryption. Changing protocol in PhotonServerSettings from: ", _MatrixColor);
			OJMHIMIPKME().SetFloat("ItemNameText", MatrixSpeed * 250f);
			ABHDNGIHBKE().SetFloat("_Bloom", _Visualize ? 1 : 0);
			ECCPAOBFDKP().SetFloat("_Value2", LightIntensity);
			NBPKMLMCHFN.SetTexture("Joystick1Button9", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			GHHPOGODBHB().SetFloat(".sav", 283f / farClipPlane);
			HNFFHCLNBDN().SetVector("settings.enablehitsoundsinnormal", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 549f, 544f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MHBAIEKFBIJ());
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
			OJMHIMIPKME().SetFloat("LostLive", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("_Threshold", Fade);
			CECICEGFHKL().SetFloat("_History3Weight", _FixDistance);
			EOCCJGIGEGJ().SetFloat("_TimeX", MatrixSize);
			ABHDNGIHBKE().SetColor("Joystick1Button9", _MatrixColor);
			PDEAHJPOMEF().SetFloat("settings.cameramovements", MatrixSpeed * 359f);
			PDEAHJPOMEF().SetFloat("_OnOff", (!_Visualize) ? 1 : 0);
			JFDGLLEOPGB().SetFloat("_BlurPass", LightIntensity);
			CBCNOEIALHB().SetTexture("DPADHOR", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			OJMHIMIPKME().SetFloat("_AxialAberration", 181f / farClipPlane);
			DONENAMLFLF().SetVector(".completed", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1880f, 1135f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CCFEDENFNEF()
	{
		FPHEBLMINDA = Resources.Load("_Value3") as Texture2D;
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
			HEINDEMCGIK().SetFloat("IntraSig", HBJJOCHGOPH);
			HKGAONMOBMH().SetFloat("_ScreenResolution", Fade);
			GHHPOGODBHB().SetFloat("OxOD.lastPath", _FixDistance);
			PGPEMMBJOOG().SetFloat("mapselector.orderby", MatrixSize);
			JFDGLLEOPGB().SetColor("_TimeX", _MatrixColor);
			DONENAMLFLF().SetFloat("_TimeX", MatrixSpeed * 1935f);
			PDEAHJPOMEF().SetFloat("Beat Detected", _Visualize ? 1 : 0);
			HKGAONMOBMH().SetFloat("_Value5", LightIntensity);
			CEKJODEAMGB().SetTexture("ResetButton", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			GHHPOGODBHB().SetFloat("_TimeX", 1279f / farClipPlane);
			IONHGBPGCHK().SetVector("Playing ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 443f, 999f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FHGKIOOMMOH()
	{
		FPHEBLMINDA = Resources.Load("_EmissionGain") as Texture2D;
		SCShader = Shader.Find("_Value2");
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
			HHIFMIPPMPF().SetFloat("/", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("_TimeX", Fade);
			HNFFHCLNBDN().SetFloat("settings.crosshairopacity", _FixDistance);
			NBPKMLMCHFN.SetFloat("r", MatrixSize);
			IGKFMCPDNOI().SetColor("Items/", _MatrixColor);
			GHHPOGODBHB().SetFloat("gameVolume", MatrixSpeed * 769f);
			BBIMPFGLDCP().SetFloat("#rt", (!_Visualize) ? 0 : 0);
			CEKJODEAMGB().SetFloat("CameraFilterPack/TV_BrokenGlass2", LightIntensity);
			IIJMIPBMMBF().SetTexture("_Bullet_3", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			GBFOAHKAJEK().SetFloat("SaveButton", 1200f / farClipPlane);
			ABHDNGIHBKE().SetVector("Failed to 'network-remove' GameObject because has no PhotonView components: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 115f, 1630f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
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
			DNLMFEGJJDD().SetFloat("value", HBJJOCHGOPH);
			FKEOGPDLBDD().SetFloat("_Value2", Fade);
			IONHGBPGCHK().SetFloat("LivesSlider", _FixDistance);
			JFDGLLEOPGB().SetFloat("You must complete your map before submiting it to Workshop", MatrixSize);
			NBPKMLMCHFN.SetColor("Square", _MatrixColor);
			CBCNOEIALHB().SetFloat("y", MatrixSpeed * 1431f);
			HILDKDFEBPF().SetFloat("CameraFilterPack/TV_ARCADE_2", (!_Visualize) ? 0 : 0);
			HILDKDFEBPF().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", LightIntensity);
			PDEAHJPOMEF().SetTexture("SetRotation", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			NBPKMLMCHFN.SetFloat("_ScreenResolution", 1037f / farClipPlane);
			PGPEMMBJOOG().SetVector("z", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 369f, 1296f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
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
		FPHEBLMINDA = Resources.Load(": ") as Texture2D;
		SCShader = Shader.Find(".played");
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
		FPHEBLMINDA = Resources.Load("checkpoint") as Texture2D;
		SCShader = Shader.Find("_Distortion");
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
		FPHEBLMINDA = Resources.Load("Failed to 'network-remove' GameObject because it's null.") as Texture2D;
		SCShader = Shader.Find("_Value2");
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
			CECICEGFHKL().SetFloat("_Bloom0", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("Created", Fade);
			DKNJGHFLAIF().SetFloat("_TimeX", _FixDistance);
			HHIFMIPPMPF().SetFloat("880078120", MatrixSize);
			FKEOGPDLBDD().SetColor("targetColor", _MatrixColor);
			FGENHBKMPDA().SetFloat("_ScreenResolution", MatrixSpeed * 475f);
			GHHPOGODBHB().SetFloat("_ScreenResolution", (!_Visualize) ? 1 : 1);
			BBIMPFGLDCP().SetFloat("_BlurVector", LightIntensity);
			PDEAHJPOMEF().SetTexture("ticket", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HILDKDFEBPF().SetFloat("offsets", 763f / farClipPlane);
			GHHPOGODBHB().SetVector("SetParticlesParticleSpeed", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 464f, 1403f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FHFLKLMFHOI());
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
			HILDKDFEBPF().SetFloat("[LevelEditorScene] Error: I/O Failure! :(", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("Player", Fade);
			ECCPAOBFDKP().SetFloat("Finished", _FixDistance);
			MHBAIEKFBIJ().SetFloat("_Value3", MatrixSize);
			ECCPAOBFDKP().SetColor("_ScreenResolution", _MatrixColor);
			HHIFMIPPMPF().SetFloat("_Value6", MatrixSpeed * 1202f);
			OJMHIMIPKME().SetFloat("_TimeX", (!_Visualize) ? 0 : 0);
			HKGAONMOBMH().SetFloat("menu.relaxinfo", LightIntensity);
			ADGHJOHKEHG().SetTexture("\\", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			MHBAIEKFBIJ().SetFloat("#,0.00", 527f / farClipPlane);
			FGENHBKMPDA().SetVector("menutheme", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1461f, 1154f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MHBAIEKFBIJ());
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
			DONENAMLFLF().SetFloat("CameraFilterPack/Blend2Camera_Screen", HBJJOCHGOPH);
			DONENAMLFLF().SetFloat("#,0.00", Fade);
			HILDKDFEBPF().SetFloat("_NeutralTonemapperParams1", _FixDistance);
			OJMHIMIPKME().SetFloat("Needs to be attached to the Event System component in the scene", MatrixSize);
			HNFFHCLNBDN().SetColor("offsets", _MatrixColor);
			BBIMPFGLDCP().SetFloat("settings.volume.editor", MatrixSpeed * 1345f);
			FKEOGPDLBDD().SetFloat(" ", _Visualize ? 1 : 0);
			HHIFMIPPMPF().SetFloat("Object ID. Case-Sensitive", LightIntensity);
			IGKFMCPDNOI().SetTexture("_Value4", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			CECICEGFHKL().SetFloat("\n", 751f / farClipPlane);
			FKEOGPDLBDD().SetVector("Clears the console and prints the logs in the specified range", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1798f, 736f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JHANGPCOCIG()
	{
		FPHEBLMINDA = Resources.Load("maps.") as Texture2D;
		SCShader = Shader.Find("HandsCountSlider");
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
		FPHEBLMINDA = Resources.Load("settings.selectormapsperpage") as Texture2D;
		SCShader = Shader.Find("/?player=");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HIPEHGNBJMN()
	{
		FPHEBLMINDA = Resources.Load("BadgeText") as Texture2D;
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
			GBFOAHKAJEK().SetFloat("_Parameter", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("menuVolume", Fade);
			OJMHIMIPKME().SetFloat("#currentbpm: ", _FixDistance);
			JFDGLLEOPGB().SetFloat("Using constructor for new PingNativeStatic()", MatrixSize);
			CEKJODEAMGB().SetColor("CameraFilterPack/FX_Drunk", _MatrixColor);
			NBPKMLMCHFN.SetFloat("RenderTextureUtilityTempTexture", MatrixSpeed * 716f);
			IIJMIPBMMBF().SetFloat("GenerationMenu", (!_Visualize) ? 1 : 0);
			GHHPOGODBHB().SetFloat("Exception while connecting to: ", LightIntensity);
			ECCPAOBFDKP().SetTexture("PlayMapsSeriesGoal", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HHIFMIPPMPF().SetFloat("_MainTex2", 284f / farClipPlane);
			FKEOGPDLBDD().SetVector("SpawnObj", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1883f, 181f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
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
			FGENHBKMPDA().SetFloat("CameraFilterPack/Blend2Camera_SoftLight", HBJJOCHGOPH);
			BBIMPFGLDCP().SetFloat("Fade", Fade);
			IGKFMCPDNOI().SetFloat("CameraFilterPack/FX_Psycho", _FixDistance);
			FGENHBKMPDA().SetFloat(":", MatrixSize);
			OJMHIMIPKME().SetColor("_Factor", _MatrixColor);
			GHHPOGODBHB().SetFloat("player.egglipszerotwo", MatrixSpeed * 741f);
			FKEOGPDLBDD().SetFloat("/", _Visualize ? 1 : 0);
			JFDGLLEOPGB().SetFloat("intensity", LightIntensity);
			BBIMPFGLDCP().SetTexture("threshold", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HKGAONMOBMH().SetFloat("<color=white>", 1360f / farClipPlane);
			PGPEMMBJOOG().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1705f, 898f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNFFHCLNBDN());
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
			BBIMPFGLDCP().SetFloat("UI Extensions/SoftMaskShader", HBJJOCHGOPH);
			CECICEGFHKL().SetFloat("true", Fade);
			HILDKDFEBPF().SetFloat("DPADHOR", _FixDistance);
			HHIFMIPPMPF().SetFloat("Jan", MatrixSize);
			OJMHIMIPKME().SetColor("Color's hex value #RRGGBBAA", _MatrixColor);
			DNLMFEGJJDD().SetFloat("_Value4", MatrixSpeed * 845f);
			GBFOAHKAJEK().SetFloat("ConnectToMaster() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", (!_Visualize) ? 1 : 0);
			IONHGBPGCHK().SetFloat("_TimeX", LightIntensity);
			IIJMIPBMMBF().SetTexture("_PColor", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			PDEAHJPOMEF().SetFloat("Y", 1243f / farClipPlane);
			JFDGLLEOPGB().SetVector("player", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 71f, 1634f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
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
			JFDGLLEOPGB().SetFloat("_FarCamera", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("InstantiateRpc", Fade);
			ABHDNGIHBKE().SetFloat("_BorderSize", _FixDistance);
			ABHDNGIHBKE().SetFloat("PublishButton", MatrixSize);
			MHBAIEKFBIJ().SetColor("_ScreenResolution", _MatrixColor);
			GHHPOGODBHB().SetFloat("menu.playedpage", MatrixSpeed * 103f);
			HEINDEMCGIK().SetFloat("_Value2", (!_Visualize) ? 1 : 1);
			OJMHIMIPKME().SetFloat("_ScreenResolution", LightIntensity);
			IIJMIPBMMBF().SetTexture("LevelInfoInputField", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			JFDGLLEOPGB().SetFloat("offsets", 1391f / farClipPlane);
			GBFOAHKAJEK().SetVector("_Parasite", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 136f, 1792f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PGPEMMBJOOG());
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
			FHFLKLMFHOI().SetFloat(" could not be executed (yet). Wait for state JoinedLobby or ConnectedToMaster and their callbacks before calling operations. WebRPCs need a server-side configuration. Enum OperationCode helps identify the operation.", HBJJOCHGOPH);
			FKEOGPDLBDD().SetFloat("CameraFilterPack/TV_WideScreenVertical", Fade);
			CBCNOEIALHB().SetFloat("Run a command for the Localization Servise", _FixDistance);
			FKEOGPDLBDD().SetFloat("Xbox Home", MatrixSize);
			DNLMFEGJJDD().SetColor("_MainTex2", _MatrixColor);
			PGPEMMBJOOG().SetFloat("offsets", MatrixSpeed * 959f);
			JFDGLLEOPGB().SetFloat("[MenuScene] Error: ", _Visualize ? 1 : 0);
			OJMHIMIPKME().SetFloat("[SoundManager] Loaded skin audio", LightIntensity);
			ABHDNGIHBKE().SetTexture(": ", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			IIJMIPBMMBF().SetFloat("#kicked", 191f / farClipPlane);
			HHIFMIPPMPF().SetVector("_ArScale", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1431f, 390f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GBFOAHKAJEK());
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
			HILDKDFEBPF().SetFloat(".GoalProgress", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("_Value6", Fade);
			ADGHJOHKEHG().SetFloat("colorD", _FixDistance);
			IIJMIPBMMBF().SetFloat("_Value5", MatrixSize);
			ECCPAOBFDKP().SetColor("IconImage", _MatrixColor);
			FKEOGPDLBDD().SetFloat("_Value4", MatrixSpeed * 1612f);
			MHBAIEKFBIJ().SetFloat("Map: ", _Visualize ? 1 : 0);
			ABHDNGIHBKE().SetFloat("DISTORT", LightIntensity);
			IONHGBPGCHK().SetTexture("AreaTex", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			BBIMPFGLDCP().SetFloat("https://steamcdn-a.akamaihd.net/steamcommunity/public/images/clans/", 1498f / farClipPlane);
			HEINDEMCGIK().SetVector("x", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 271f, 1967f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
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
			PGPEMMBJOOG().SetFloat("_Value", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("colorB", Fade);
			OJMHIMIPKME().SetFloat("_TimeX", _FixDistance);
			DKNJGHFLAIF().SetFloat("_Color", MatrixSize);
			EOCCJGIGEGJ().SetColor("_Blurred", _MatrixColor);
			BBIMPFGLDCP().SetFloat("_MainTex2", MatrixSpeed * 1221f);
			ADGHJOHKEHG().SetFloat("_Value4", (!_Visualize) ? 1 : 0);
			DKNJGHFLAIF().SetFloat("_Distortion", LightIntensity);
			CECICEGFHKL().SetTexture("OK", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			GHHPOGODBHB().SetFloat("CameraFilterPack/Blend2Camera_Lighten", 295f / farClipPlane);
			HHIFMIPPMPF().SetVector("AudioSampler", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 743f, 1879f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BBIMPFGLDCP());
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
			IGKFMCPDNOI().SetFloat("Tab2Content", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("_ScreenResolution", Fade);
			IGKFMCPDNOI().SetFloat("_SoftZDistance", _FixDistance);
			FHFLKLMFHOI().SetFloat("Triangle", MatrixSize);
			FGENHBKMPDA().SetColor("UseFinalGlassColor", _MatrixColor);
			HHIFMIPPMPF().SetFloat("\n", MatrixSpeed * 832f);
			DONENAMLFLF().SetFloat("Color", _Visualize ? 1 : 0);
			IONHGBPGCHK().SetFloat("mapselector.filter.rateduponly", LightIntensity);
			CECICEGFHKL().SetTexture("_Red_G", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			CEKJODEAMGB().SetFloat("_TimeX", 1683f / farClipPlane);
			HILDKDFEBPF().SetVector("R2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1639f, 1676f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
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
			FGENHBKMPDA().SetFloat("ShineEffect", HBJJOCHGOPH);
			ECCPAOBFDKP().SetFloat("DifficultyBG", Fade);
			IGKFMCPDNOI().SetFloat("id", _FixDistance);
			PGPEMMBJOOG().SetFloat("ZoomSpeed", MatrixSize);
			DNLMFEGJJDD().SetColor("CameraFilterPack/Blend2Camera_Screen", _MatrixColor);
			HEINDEMCGIK().SetFloat("PublishButton", MatrixSpeed * 1554f);
			ECCPAOBFDKP().SetFloat("{0}{1}{2}", _Visualize ? 1 : 0);
			HILDKDFEBPF().SetFloat("_ScreenSize", LightIntensity);
			CEKJODEAMGB().SetTexture("Current xp: ", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			DNLMFEGJJDD().SetFloat("DISTORT", 1461f / farClipPlane);
			FHFLKLMFHOI().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 548f, 1744f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DONENAMLFLF());
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
			GBFOAHKAJEK().SetFloat("settings.volume.game", HBJJOCHGOPH);
			PGPEMMBJOOG().SetFloat("CameraFilterPack/Distortion_Dream", Fade);
			MHBAIEKFBIJ().SetFloat("_TimeX", _FixDistance);
			IONHGBPGCHK().SetFloat("_ScreenResolution", MatrixSize);
			PDEAHJPOMEF().SetColor("DPADHOR", _MatrixColor);
			NBPKMLMCHFN.SetFloat("_TimeX", MatrixSpeed * 1608f);
			GBFOAHKAJEK().SetFloat("#", _Visualize ? 1 : 0);
			IIJMIPBMMBF().SetFloat("_CenterY", LightIntensity);
			DONENAMLFLF().SetTexture("ticket", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FGENHBKMPDA().SetFloat("#ok", 277f / farClipPlane);
			MHBAIEKFBIJ().SetVector("Item invalid. No idea why.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 949f, 198f));
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
			HHIFMIPPMPF().SetFloat("OnRenderImage in Helper called ...", HBJJOCHGOPH);
			HEINDEMCGIK().SetFloat("_ColorRGB", Fade);
			HEINDEMCGIK().SetFloat("GameScene", _FixDistance);
			ABHDNGIHBKE().SetFloat(".workshop.json", MatrixSize);
			CBCNOEIALHB().SetColor("Clear Environment", _MatrixColor);
			HKGAONMOBMH().SetFloat("#no", MatrixSpeed * 711f);
			IONHGBPGCHK().SetFloat("#failed!", (!_Visualize) ? 1 : 0);
			IONHGBPGCHK().SetFloat("B:", LightIntensity);
			IGKFMCPDNOI().SetTexture("x", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FHFLKLMFHOI().SetFloat("kick", 1279f / farClipPlane);
			EOCCJGIGEGJ().SetVector("player.lollipop", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 21f, 882f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
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
			LPDOGGFOBDH().SetFloat("Up ", HBJJOCHGOPH);
			CEKJODEAMGB().SetFloat("\r", Fade);
			GHHPOGODBHB().SetFloat("_Fade", _FixDistance);
			GHHPOGODBHB().SetFloat("_History1LumaTex", MatrixSize);
			EOCCJGIGEGJ().SetColor("Cannot send messages when not connected. Either connect to Photon OR use offline mode!", _MatrixColor);
			NBPKMLMCHFN.SetFloat("Save level before uploading?", MatrixSpeed * 1586f);
			FHFLKLMFHOI().SetFloat("DifficultyBG", (!_Visualize) ? 1 : 0);
			FKEOGPDLBDD().SetFloat("_BorderColor", LightIntensity);
			CEKJODEAMGB().SetTexture("https://www.youtube.com/watch?v=cDVXukrKo74", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			CECICEGFHKL().SetFloat("/", 618f / farClipPlane);
			EOCCJGIGEGJ().SetVector("curScn", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 173f, 121f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FDNONDCGGCG()
	{
		FPHEBLMINDA = Resources.Load("mapselector.filter.rateduponly") as Texture2D;
		SCShader = Shader.Find("<color=white>PhotonView Group: ");
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
		FPHEBLMINDA = Resources.Load("_Min") as Texture2D;
		SCShader = Shader.Find(";");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ODMPMJPALID()
	{
		FPHEBLMINDA = Resources.Load("_TimeX") as Texture2D;
		SCShader = Shader.Find(" cannot be used as a 3D LUT.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PAKPHKPDKGE()
	{
		FPHEBLMINDA = Resources.Load("\" gets executed locally only, if at all.") as Texture2D;
		SCShader = Shader.Find(": ");
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
		FPHEBLMINDA = Resources.Load("Left Stick Click") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/VHS_Tracking");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MEBPBNLBECA()
	{
		FPHEBLMINDA = Resources.Load("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.") as Texture2D;
		SCShader = Shader.Find("Unsupported type: ");
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
		FPHEBLMINDA = Resources.Load("_Value") as Texture2D;
		SCShader = Shader.Find("_ScreenResolution");
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
		FPHEBLMINDA = Resources.Load("bad") as Texture2D;
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
			IGKFMCPDNOI().SetFloat("_Value7", HBJJOCHGOPH);
			HILDKDFEBPF().SetFloat("MapperNameText", Fade);
			BBIMPFGLDCP().SetFloat("unsubscribemap", _FixDistance);
			FGENHBKMPDA().SetFloat("\"", MatrixSize);
			FKEOGPDLBDD().SetColor("(\\[ *url=)((?:https\\:\\/\\/)|(?:http\\:\\/\\/)|(?:www\\.))?([a-zA-Z0-9\\-\\.]+\\.[a-zA-Z]{2,3}(?:\\??)[a-zA-Z0-9\\-\\._\\?\\,\\'\\/\\\\\\+&%\\$#\\=~]+)(\\])", _MatrixColor);
			CECICEGFHKL().SetFloat("[ItemsHandler] Found ", MatrixSpeed * 1744f);
			FKEOGPDLBDD().SetFloat("Horizontal", _Visualize ? 1 : 0);
			GHHPOGODBHB().SetFloat("MultiplayerButton", LightIntensity);
			HEINDEMCGIK().SetTexture("<b>", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			PDEAHJPOMEF().SetFloat("ResetButton", 803f / farClipPlane);
			HEINDEMCGIK().SetVector("_Distortion", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 508f, 1492f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ALJEJJCIMJN()
	{
		FPHEBLMINDA = Resources.Load("effector") as Texture2D;
		SCShader = Shader.Find("Unable to get a reward! Try again?");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KDMKDEKCELE()
	{
		FPHEBLMINDA = Resources.Load("_Metrics") as Texture2D;
		SCShader = Shader.Find("x");
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
			HHIFMIPPMPF().SetFloat("_Value2", HBJJOCHGOPH);
			GBFOAHKAJEK().SetFloat("_ScreenResolution", Fade);
			FHFLKLMFHOI().SetFloat("_StretchWidth", _FixDistance);
			DKNJGHFLAIF().SetFloat("name", MatrixSize);
			HHIFMIPPMPF().SetColor("_Value", _MatrixColor);
			DONENAMLFLF().SetFloat("Case-Sensitive", MatrixSpeed * 412f);
			OJMHIMIPKME().SetFloat("00", (!_Visualize) ? 0 : 0);
			ADGHJOHKEHG().SetFloat("FindFriends failed to apply the result, as a required value wasn't provided or the friend list length differed from result.", LightIntensity);
			MHBAIEKFBIJ().SetTexture("_Parameter", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			IGKFMCPDNOI().SetFloat("#ok", 363f / farClipPlane);
			BBIMPFGLDCP().SetVector("Operation ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 316f, 1109f));
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
			IIJMIPBMMBF().SetFloat("Mouse X", HBJJOCHGOPH);
			GHHPOGODBHB().SetFloat("_TimeX", Fade);
			NBPKMLMCHFN.SetFloat("[MenuScene] Error: ", _FixDistance);
			ECCPAOBFDKP().SetFloat("Gameplay/Base", MatrixSize);
			ADGHJOHKEHG().SetColor("Tab1Content", _MatrixColor);
			CEKJODEAMGB().SetFloat("_FilteredReflections", MatrixSpeed * 1575f);
			CBCNOEIALHB().SetFloat("menutheme.deleted", (!_Visualize) ? 1 : 0);
			IIJMIPBMMBF().SetFloat("Created", LightIntensity);
			DONENAMLFLF().SetTexture("_ScreenResolution", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FHFLKLMFHOI().SetFloat(", data: ", 1104f / farClipPlane);
			GBFOAHKAJEK().SetVector("No Camera attached!", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1902f, 219f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
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
			FKEOGPDLBDD().SetFloat("_Visualize", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("X2", Fade);
			FHFLKLMFHOI().SetFloat("maps.", _FixDistance);
			CECICEGFHKL().SetFloat("time", MatrixSize);
			ECCPAOBFDKP().SetColor("_Value", _MatrixColor);
			ECCPAOBFDKP().SetFloat("[PlayerBase] Saveing checkpoint data", MatrixSpeed * 1425f);
			BBIMPFGLDCP().SetFloat("Set Sun Sensitivity", _Visualize ? 1 : 0);
			ADGHJOHKEHG().SetFloat("CameraFilterPack_Fly_VisionFX", LightIntensity);
			BBIMPFGLDCP().SetTexture("[", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			ECCPAOBFDKP().SetFloat("_TimeX", 1587f / farClipPlane);
			FHFLKLMFHOI().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 916f, 1201f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
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
		FPHEBLMINDA = Resources.Load("SetEnvSpriteColor") as Texture2D;
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
			CEKJODEAMGB().SetFloat("CameraFilterPack/Distortion_Half_Sphere", HBJJOCHGOPH);
			HEINDEMCGIK().SetFloat("settings.fps", Fade);
			BBIMPFGLDCP().SetFloat("[", _FixDistance);
			HNFFHCLNBDN().SetFloat("Drop_Far", MatrixSize);
			DKNJGHFLAIF().SetColor("ControllerRightX", _MatrixColor);
			HKGAONMOBMH().SetFloat("127.0.0.1", MatrixSpeed * 1974f);
			FHFLKLMFHOI().SetFloat("note.3", (!_Visualize) ? 1 : 0);
			CBCNOEIALHB().SetFloat("OpGetGameList not sent. LobbyType must be SqlLobby.", LightIntensity);
			CBCNOEIALHB().SetTexture("_Value7", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FHFLKLMFHOI().SetFloat("_TimeX", 839f / farClipPlane);
			BBIMPFGLDCP().SetVector("[Right]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 9f, 1788f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JONGNKNLLND()
	{
		FPHEBLMINDA = Resources.Load("1248864821") as Texture2D;
		SCShader = Shader.Find(".highscore");
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
		FPHEBLMINDA = Resources.Load("mapid") as Texture2D;
		SCShader = Shader.Find("_Noise");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MKOMIDCPCDC()
	{
		FPHEBLMINDA = Resources.Load("_Extra2") as Texture2D;
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
			OJMHIMIPKME().SetFloat("Please attach component to a Graphical UI component", HBJJOCHGOPH);
			FKEOGPDLBDD().SetFloat("Result for ", Fade);
			HNFFHCLNBDN().SetFloat("Tab2Content", _FixDistance);
			EOCCJGIGEGJ().SetFloat("_TimeX", MatrixSize);
			CEKJODEAMGB().SetColor("_ScreenResolution", _MatrixColor);
			CEKJODEAMGB().SetFloat("/icon", MatrixSpeed * 211f);
			EOCCJGIGEGJ().SetFloat("offsets", (!_Visualize) ? 1 : 0);
			CBCNOEIALHB().SetFloat("Tab2Content", LightIntensity);
			PDEAHJPOMEF().SetTexture("[ImageLoader] Loaded image from ", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			EOCCJGIGEGJ().SetFloat("Set Sun Emission", 1801f / farClipPlane);
			PGPEMMBJOOG().SetVector("input", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1234f, 253f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
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
		FPHEBLMINDA = Resources.Load("ResourcesConfig") as Texture2D;
		SCShader = Shader.Find("LevelInfoInputField");
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
		SCShader = Shader.Find("IntraSig");
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
			HKGAONMOBMH().SetFloat("CurrentTimeLabel", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("InfoText", Fade);
			HNFFHCLNBDN().SetFloat("id", _FixDistance);
			EOCCJGIGEGJ().SetFloat(". The group number should be at least 1.", MatrixSize);
			FGENHBKMPDA().SetColor("_ScreenResolution", _MatrixColor);
			PDEAHJPOMEF().SetFloat("Tab2Content", MatrixSpeed * 948f);
			HKGAONMOBMH().SetFloat("' has been reset to the fault value", (!_Visualize) ? 0 : 0);
			FHFLKLMFHOI().SetFloat("<b>Commands:</b>\n/help\n/players\n/kick\n/table\n/clear", LightIntensity);
			ADGHJOHKEHG().SetTexture("AllocateViewID() failed. Room (user {0}) is out of 'scene' viewIDs. It seems all available are in use.", FPHEBLMINDA);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			GHHPOGODBHB().SetFloat("PLEASE WAIT", 31f / farClipPlane);
			CBCNOEIALHB().SetVector("_MainTex2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 660f, 155f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
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
		FPHEBLMINDA = Resources.Load(".completed") as Texture2D;
		SCShader = Shader.Find("_Value");
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
