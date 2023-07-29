// CameraFilterPack_FX_DigitalMatrix
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/FX/DigitalMatrix")]
public class CameraFilterPack_FX_DigitalMatrix : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0.4f, 5f)]
	public float Size = 1f;

	[Range(-10f, 10f)]
	public float Speed = 1f;

	[Range(-1f, 1f)]
	public float ColorR = -1f;

	[Range(-1f, 1f)]
	public float ColorG = 1f;

	[Range(-1f, 1f)]
	public float ColorB = -1f;

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

	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 899f)
			{
				HBJJOCHGOPH = 928f;
			}
			DKKBFFHBHJE().SetFloat("SetRoomStartTimestamp", HBJJOCHGOPH);
			CECJJMKLEAK().SetFloat("shader.ghost", Size);
			NBMPPNFKFLB().SetFloat("Joystick1Button4", ColorR);
			HCGJCMDJPGD().SetFloat("/?player=", ColorG);
			EFDEIFCDAFG().SetFloat("{0}", ColorB);
			PLBEJJIHFPB().SetFloat("End index must in an integer.", Speed);
			GJHLADDCMFF().SetVector("IconFileSelector", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 849f, 538f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CECJJMKLEAK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FGNFILLNPJK()
	{
	}

	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1376f)
			{
				HBJJOCHGOPH = 695f;
			}
			LPMLLJKMAMP().SetFloat("value", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("_TileTexDebug", Size);
			NBMPPNFKFLB().SetFloat("_Blue_R", ColorR);
			EOCCJGIGEGJ().SetFloat("_ScreenResolution", ColorG);
			EOCCJGIGEGJ().SetFloat("float,0", ColorB);
			CECJJMKLEAK().SetFloat("_TimeX", Speed);
			FKEOGPDLBDD().SetVector(",", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 47f, 1469f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JOACBIEHHCE()
	{
	}

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void AGEJKLMJGDO()
	{
		SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 326f)
			{
				HBJJOCHGOPH = 1697f;
			}
			LONNIJMNKFB().SetFloat("RecieveChatActionMessage", HBJJOCHGOPH);
			HKHBBBFLGJH().SetFloat("Overlay", Size);
			LONNIJMNKFB().SetFloat("duration", ColorR);
			HKGAONMOBMH().SetFloat("_SecondTex", ColorG);
			OKJOKHGJHGF().SetFloat("Failed to 'GetKeyCode' for key: ", ColorB);
			EPCGJFCCAFH().SetFloat("_Value3", Speed);
			FKEOGPDLBDD().SetVector("_SunColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1500f, 459f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CMIBEOJGAIL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OFIMMFHFHDD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MFMIODIAKNI()
	{
	}

	private void LEAHIBJDMBI()
	{
	}

	private void DDBOODLPCAM()
	{
	}

	[SpecialName]
	private Material LPMLLJKMAMP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void KKLMPKLKAEM()
	{
	}

	private void EDBEHEKMGFH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NNFMIAFHMJM()
	{
		SCShader = Shader.Find("SaveButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material CFEDGDGBCHE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material FKEOGPDLBDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1330f)
			{
				HBJJOCHGOPH = 245f;
			}
			PLBEJJIHFPB().SetFloat(" - PUBLISHED #", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("error", Size);
			EFDEIFCDAFG().SetFloat("Chat", ColorR);
			DKKBFFHBHJE().SetFloat("[NetworkManager] Updating current room...", ColorG);
			NBMPPNFKFLB().SetFloat("Fade", ColorB);
			OKJOKHGJHGF().SetFloat("_Blue_R", Speed);
			HNFFHCLNBDN().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1497f, 1527f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material PLBEJJIHFPB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)98;
		}
		return BJFKDHHMLJH;
	}

	private void NAOLAJPDGIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 478f)
			{
				HBJJOCHGOPH = 1098f;
			}
			FGENHBKMPDA().SetFloat("/", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("BadgeText", Size);
			HCGJCMDJPGD().SetFloat("unsubscribemap", ColorR);
			FKEOGPDLBDD().SetFloat("event", ColorG);
			CECJJMKLEAK().SetFloat("_", ColorB);
			HKHBBBFLGJH().SetFloat("_Offsets", Speed);
			IONHGBPGCHK().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1422f, 389f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHLADDCMFF());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-96);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material GJHLADDCMFF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material DKKBFFHBHJE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-68);
		}
		return BJFKDHHMLJH;
	}

	private void HGDDCINLDAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1780f)
			{
				HBJJOCHGOPH = 377f;
			}
			IONHGBPGCHK().SetFloat("settings.enablehitsoundsinrelax", HBJJOCHGOPH);
			LPMLLJKMAMP().SetFloat("Texture2", Size);
			CECJJMKLEAK().SetFloat("_TimeX", ColorR);
			OKJOKHGJHGF().SetFloat("AppID: {0}*** GameVersion: {1} PeerId: {2} ", ColorG);
			HCGJCMDJPGD().SetFloat("_TimeX", ColorB);
			FKEOGPDLBDD().SetFloat("Joystick1Button9", Speed);
			FGENHBKMPDA().SetVector("Anomaly_Distortion", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 936f, 1801f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1382f)
			{
				HBJJOCHGOPH = 618f;
			}
			LONNIJMNKFB().SetFloat("_MatrixSize", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("_VignettingDirt", Size);
			LONNIJMNKFB().SetFloat("effector", ColorR);
			FKEOGPDLBDD().SetFloat("ResetSpeed", ColorG);
			CFEDGDGBCHE().SetFloat("_Value2", ColorB);
			LONNIJMNKFB().SetFloat("_Value2", Speed);
			IONHGBPGCHK().SetVector("_Tint", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1011f, 736f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CGBHOELMAOC()
	{
	}

	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 626f)
			{
				HBJJOCHGOPH = 1849f;
			}
			PLBEJJIHFPB().SetFloat("_Value4", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("checkpoint", Size);
			GJHLADDCMFF().SetFloat(".wav", ColorR);
			HCGJCMDJPGD().SetFloat("Xbox Home", ColorG);
			CFEDGDGBCHE().SetFloat("_ProjectToPixelMatrix", ColorB);
			DKNJGHFLAIF().SetFloat("source", Speed);
			FGENHBKMPDA().SetVector("#finished", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 719f, 873f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IDJKNBDKHBD()
	{
		SCShader = Shader.Find(" Owner called.");
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
			if (HBJJOCHGOPH > 1665f)
			{
				HBJJOCHGOPH = 403f;
			}
			OKJOKHGJHGF().SetFloat("MapperNameText", HBJJOCHGOPH);
			OKJOKHGJHGF().SetFloat("_Value5", Size);
			PLBEJJIHFPB().SetFloat("received</b>\n#reason: ", ColorR);
			FGENHBKMPDA().SetFloat("Drop_Near", ColorG);
			CECJJMKLEAK().SetFloat("UI Extensions/UIAdditive", ColorB);
			HCGJCMDJPGD().SetFloat("Select", Speed);
			DKNJGHFLAIF().SetVector("Texture2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 686f, 889f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EJFJENFKLND()
	{
	}

	private void KLILJHJNICK()
	{
		SCShader = Shader.Find("SetPosition");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1241f)
			{
				HBJJOCHGOPH = 1823f;
			}
			GJHLADDCMFF().SetFloat("5;6;7;8;11;12;18;19;20;22x6;44x1", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("Status: ", Size);
			CECJJMKLEAK().SetFloat("[Right]", ColorR);
			PLBEJJIHFPB().SetFloat("InventoryContent", ColorG);
			DKNJGHFLAIF().SetFloat("[PlayerController] ", ColorB);
			PLBEJJIHFPB().SetFloat("Use \"/help\" for commands list", Speed);
			HCGJCMDJPGD().SetVector("player.licenceaccepted", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 541f, 1541f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ICDBMJKMIKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material LONNIJMNKFB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)66;
		}
		return BJFKDHHMLJH;
	}

	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 286f)
			{
				HBJJOCHGOPH = 777f;
			}
			HKGAONMOBMH().SetFloat("CameraFilterPack/TV_BrokenGlass", HBJJOCHGOPH);
			IFMAPIDFNLI().SetFloat("2hands", Size);
			EOCCJGIGEGJ().SetFloat("note.1", ColorR);
			EOCCJGIGEGJ().SetFloat("CameraFilterPack/Colors_Adjust_ColorRGB", ColorG);
			OKJOKHGJHGF().SetFloat("_TimeX", ColorB);
			LPMLLJKMAMP().SetFloat("key", Speed);
			CFEDGDGBCHE().SetVector("_Value4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1818f, 974f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NJHJHBOJKIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
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
	private Material HNFFHCLNBDN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-94);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IFMAPIDFNLI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-92);
		}
		return BJFKDHHMLJH;
	}

	private void COGBDFKOHKK()
	{
	}

	private void CNGAJDBOCLJ()
	{
		SCShader = Shader.Find("MessageText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LGHCJCFHEMF()
	{
		SCShader = Shader.Find("CameraFilterPack/Vision_Warp2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MAOCOEGAFND()
	{
	}

	[SpecialName]
	private Material FGENHBKMPDA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)103;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HCGJCMDJPGD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void Update()
	{
	}

	private void OCMKCBBCEFG()
	{
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/FX_DigitalMatrix");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NNBCLMJGFEN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PKGJJFIFLII()
	{
	}

	private void CHOPDIGHJNH()
	{
		SCShader = Shader.Find("In Main Menu");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MMOKKAPFGAK()
	{
		SCShader = Shader.Find(",");
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
			NBPKMLMCHFN.SetFloat("_Value", Size);
			NBPKMLMCHFN.SetFloat("_Value2", ColorR);
			NBPKMLMCHFN.SetFloat("_Value3", ColorG);
			NBPKMLMCHFN.SetFloat("_Value4", ColorB);
			NBPKMLMCHFN.SetFloat("_Value5", Speed);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material EFDEIFCDAFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void DLMPALHKMON()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PAEGLMEOKHP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1987f)
			{
				HBJJOCHGOPH = 749f;
			}
			HKGAONMOBMH().SetFloat("Depth textures aren't supported on this device ({0})", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("No connection to item server!", Size);
			DKNJGHFLAIF().SetFloat("Cannot remove cached RPCs on a PhotonView thats not ours! ", ColorR);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Atmosphere_Rain", ColorG);
			HNFFHCLNBDN().SetFloat(".icon", ColorB);
			GJHLADDCMFF().SetFloat("_Near", Speed);
			NBMPPNFKFLB().SetVector("Joystick1Button4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 371f, 419f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DKNJGHFLAIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void OIBMHPIFAKK()
	{
	}

	private void FPHLDMMAOEF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EPEGAEGDJAM()
	{
		SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BMBIGILMLLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1068f)
			{
				HBJJOCHGOPH = 820f;
			}
			FKEOGPDLBDD().SetFloat("BloomShaderValueSlider", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("HiddenToggle", Size);
			DKKBFFHBHJE().SetFloat("22x1", ColorR);
			HCGJCMDJPGD().SetFloat("settings.customdataskin", ColorG);
			EPCGJFCCAFH().SetFloat("_MainTex", ColorB);
			CECJJMKLEAK().SetFloat("DataText", Speed);
			HNFFHCLNBDN().SetVector("powerup.0", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1246f, 1441f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ELDMKIAPNGP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IEFMONDKKJN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GKNKIIEALCH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JOPCCCCHNLI()
	{
		SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 309f)
			{
				HBJJOCHGOPH = 986f;
			}
			HCGJCMDJPGD().SetFloat("_Speed", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("#forever", Size);
			EPCGJFCCAFH().SetFloat("[SaveSystem] Outdated savefile found", ColorR);
			NBPKMLMCHFN.SetFloat(",", ColorG);
			CFEDGDGBCHE().SetFloat("_Green_C", ColorB);
			NBMPPNFKFLB().SetFloat(" registered.", Speed);
			CFEDGDGBCHE().SetVector("RPCs can only be sent in rooms. Call of \"", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 711f, 1470f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KMOCDAOKGLI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GBGAMCPNBCC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PAKPHKPDKGE()
	{
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material EPCGJFCCAFH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NBMPPNFKFLB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)79;
		}
		return BJFKDHHMLJH;
	}

	private void LBAJLLFMMMP()
	{
		SCShader = Shader.Find("_EmissionGain");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JHPOIOELNCG()
	{
	}

	[SpecialName]
	private Material HKHBBBFLGJH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)84;
		}
		return BJFKDHHMLJH;
	}

	private void GPHPJIDGEPI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FNCDAPDOBBI()
	{
		SCShader = Shader.Find("_Value2");
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

	[SpecialName]
	private Material HKGAONMOBMH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void BOLBPPHJBMI()
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

	private void LKBOEPPBLIF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 298f)
			{
				HBJJOCHGOPH = 1160f;
			}
			FGENHBKMPDA().SetFloat("RPC: 'OnAwakeRPC' Parameter: ", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("_Level", Size);
			FGENHBKMPDA().SetFloat("_TimeX", ColorR);
			CFEDGDGBCHE().SetFloat("Drop_Near", ColorG);
			DKKBFFHBHJE().SetFloat("_TimeX", ColorB);
			KGOLDDBHIFN().SetFloat("VIGNETTE_DESAT", Speed);
			NBPKMLMCHFN.SetVector("Start index must in an integer.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1100f, 606f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FOMNCPKKCFN()
	{
	}

	private void BDBJEDIOKBN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MDNHCLKNCLE()
	{
		SCShader = Shader.Find("Editor/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DNENFLNCIJP()
	{
	}

	private void OPCLBGHAPMG()
	{
	}

	private void KLOLKEBAPFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material CECJJMKLEAK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)99;
		}
		return BJFKDHHMLJH;
	}

	private void BGDONBMDPGM()
	{
	}

	[SpecialName]
	private Material EOCCJGIGEGJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KGOLDDBHIFN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1948f)
			{
				HBJJOCHGOPH = 1243f;
			}
			HCGJCMDJPGD().SetFloat("_Near", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("USE_DIAG_SEARCH", Size);
			HNFFHCLNBDN().SetFloat("_Value2", ColorR);
			NBMPPNFKFLB().SetFloat("_Value", ColorG);
			CECJJMKLEAK().SetFloat("PublishButton", ColorB);
			EFDEIFCDAFG().SetFloat("_ScreenResolution", Speed);
			PLBEJJIHFPB().SetVector("1", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 220f, 213f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IFMAPIDFNLI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FMHOHGEAIEA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1446f)
			{
				HBJJOCHGOPH = 1398f;
			}
			HCGJCMDJPGD().SetFloat("_DotSize", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("_ScreenResolution", Size);
			PLBEJJIHFPB().SetFloat("float,0", ColorR);
			DKKBFFHBHJE().SetFloat("Preparing content...", ColorG);
			DKNJGHFLAIF().SetFloat("#FFFFFF", ColorB);
			FGENHBKMPDA().SetFloat("#FFDA44", Speed);
			FKEOGPDLBDD().SetVector("id", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 710f, 1831f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CPAJLKHMOJB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DBLILJGKGHJ()
	{
		SCShader = Shader.Find("{0} minutes ago");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1041f)
			{
				HBJJOCHGOPH = 1082f;
			}
			CFEDGDGBCHE().SetFloat("USE_UV_BASED_REPROJECTION", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("Anomaly_Far", Size);
			IFMAPIDFNLI().SetFloat("position", ColorR);
			LONNIJMNKFB().SetFloat("_Value", ColorG);
			HCGJCMDJPGD().SetFloat("Bad SegmentType passed in to CreateLineCap. Must be SegmentType.Start or SegmentType.End", ColorB);
			OKJOKHGJHGF().SetFloat("The observed monobehaviour (", Speed);
			GJHLADDCMFF().SetVector("reset", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1462f, 1880f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PLBOFEPBPKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ODGMCJILIHF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JEBIBKLHFLB()
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
			if (HBJJOCHGOPH > 1372f)
			{
				HBJJOCHGOPH = 943f;
			}
			EOCCJGIGEGJ().SetFloat("\"", HBJJOCHGOPH);
			GJHLADDCMFF().SetFloat("selector", Size);
			NBPKMLMCHFN.SetFloat("[MapEditor] Prepairing map editor...", ColorR);
			HKGAONMOBMH().SetFloat("_MatrixSpeed", ColorG);
			DKKBFFHBHJE().SetFloat("cameramovements:", ColorB);
			EFDEIFCDAFG().SetFloat("Data/Maps/", Speed);
			CECJJMKLEAK().SetVector("EventSystem", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1899f, 493f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KMCPMOGKDEH()
	{
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}
}
