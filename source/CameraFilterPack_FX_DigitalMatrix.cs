// CameraFilterPack_FX_DigitalMatrix
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/FX/DigitalMatrix")]
[ExecuteInEditMode]
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
			DKKBFFHBHJE().SetFloat("turn: {0:0}", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("shader.crispwinter", Size);
			EOCCJGIGEGJ().SetFloat("Joystick1Button3", ColorR);
			EPCGJFCCAFH().SetFloat("/?player=", ColorG);
			CFEDGDGBCHE().SetFloat("{0}", ColorB);
			KGOLDDBHIFN().SetFloat("Start index must in an integer.", Speed);
			HNFFHCLNBDN().SetVector("NewMapHandsCountSlider", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 849f, 538f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
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
			FKEOGPDLBDD().SetFloat("Object ID. Case-Sensitive", HBJJOCHGOPH);
			CECJJMKLEAK().SetFloat("_NeighbourMaxTex", Size);
			NBMPPNFKFLB().SetFloat("_Blue_R", ColorR);
			HKGAONMOBMH().SetFloat("_ScreenResolution", ColorG);
			FGENHBKMPDA().SetFloat("float,0", ColorB);
			LPMLLJKMAMP().SetFloat("_TimeX", Speed);
			HKGAONMOBMH().SetVector(",", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 47f, 1469f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
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
		SCShader = Shader.Find("_Value2");
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
			HKHBBBFLGJH().SetFloat("RecieveChatActionMessage", HBJJOCHGOPH);
			LPMLLJKMAMP().SetFloat("Text", Size);
			CECJJMKLEAK().SetFloat("keep aspect ratio", ColorR);
			KGOLDDBHIFN().SetFloat("_MainTex", ColorG);
			IONHGBPGCHK().SetFloat("The binding '", ColorB);
			IFMAPIDFNLI().SetFloat("_Value2", Speed);
			CFEDGDGBCHE().SetVector("_BlurRadius4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1500f, 459f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
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
			DKNJGHFLAIF().SetFloat(" - LOCAL", HBJJOCHGOPH);
			HKHBBBFLGJH().SetFloat("#close", Size);
			FKEOGPDLBDD().SetFloat("OnPress", ColorR);
			EFDEIFCDAFG().SetFloat("[NetworkManager] Updating current room...", ColorG);
			NBMPPNFKFLB().SetFloat("UseFinalGlassColor", ColorB);
			EPCGJFCCAFH().SetFloat("_Green_B", Speed);
			NBMPPNFKFLB().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1497f, 1527f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHLADDCMFF());
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
			PLBEJJIHFPB().SetFloat("Editor/", HBJJOCHGOPH);
			IFMAPIDFNLI().SetFloat("COMPLETED", Size);
			KGOLDDBHIFN().SetFloat("http://steamcommunity.com/sharedfiles/filedetails/?id=", ColorR);
			LONNIJMNKFB().SetFloat("BitsData", ColorG);
			NBPKMLMCHFN.SetFloat("_SoftZDistance", ColorB);
			EOCCJGIGEGJ().SetFloat("_Offsets", Speed);
			KGOLDDBHIFN().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1422f, 389f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
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
			HCGJCMDJPGD().SetFloat("settings.volume.sfx", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("_ScreenResolution", Size);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Film_ColorPerfection", ColorR);
			IFMAPIDFNLI().SetFloat("SupportLogger ", ColorG);
			IFMAPIDFNLI().SetFloat("_TimeX", ColorB);
			HKGAONMOBMH().SetFloat("Joystick1Button8", Speed);
			DKNJGHFLAIF().SetVector("Anomaly_Distortion", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 936f, 1801f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CECJJMKLEAK());
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
			GJHLADDCMFF().SetFloat("_MatrixSize", HBJJOCHGOPH);
			FKEOGPDLBDD().SetFloat("_VignettingColor", Size);
			EFDEIFCDAFG().SetFloat("UI Extensions/UISoftAdditive", ColorR);
			HNFFHCLNBDN().SetFloat("ResetSpeed", ColorG);
			FKEOGPDLBDD().SetFloat("_TimeX", ColorB);
			EOCCJGIGEGJ().SetFloat("_Value", Speed);
			IONHGBPGCHK().SetVector("_PosY", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1011f, 736f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			CECJJMKLEAK().SetFloat("_Value3", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("BitsData", Size);
			NBPKMLMCHFN.SetFloat(".ogg", ColorR);
			HKGAONMOBMH().SetFloat("Right Stick Click", ColorG);
			NBMPPNFKFLB().SetFloat("_InvScreenSize", ColorB);
			IFMAPIDFNLI().SetFloat("Sequence contains no elements", Speed);
			HKHBBBFLGJH().SetVector("#timeuntilend: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 719f, 873f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IDJKNBDKHBD()
	{
		SCShader = Shader.Find("Received RPC \"");
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
			HKHBBBFLGJH().SetFloat("#mapby", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("_Value4", Size);
			DKNJGHFLAIF().SetFloat("received</b>\n#reason: ", ColorR);
			DKKBFFHBHJE().SetFloat("_Visualize", ColorG);
			NBMPPNFKFLB().SetFloat("Mask texture not readable, set your sprite to Texture Type 'Advanced' and check 'Read/Write Enabled'", ColorB);
			NBPKMLMCHFN.SetFloat("R2", Speed);
			IONHGBPGCHK().SetVector("Distortion", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 686f, 889f));
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
		SCShader = Shader.Find("SetTrailZoomSpeed");
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
			FGENHBKMPDA().SetFloat(" in-game items", HBJJOCHGOPH);
			HKGAONMOBMH().SetFloat("n/a", Size);
			EFDEIFCDAFG().SetFloat("[Left]", ColorR);
			HKHBBBFLGJH().SetFloat("ItemsCountText", ColorG);
			HNFFHCLNBDN().SetFloat(" not exist", ColorB);
			HNFFHCLNBDN().SetFloat("\n - NetID: ", Speed);
			LPMLLJKMAMP().SetVector("https://www.youtube.com/watch?v=cDVXukrKo74", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 541f, 1541f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
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
			HKGAONMOBMH().SetFloat("CameraFilterPack_TV_BrokenGlass1", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("MainCamera", Size);
			LPMLLJKMAMP().SetFloat("#outdatedmap! Challenges will not work!", ColorR);
			FKEOGPDLBDD().SetFloat("_ScreenResolution", ColorG);
			HKHBBBFLGJH().SetFloat("CameraFilterPack/Vision_Aura", ColorB);
			EPCGJFCCAFH().SetFloat("Obtain promo Item", Speed);
			HNFFHCLNBDN().SetVector("_Value4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1818f, 974f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CECJJMKLEAK());
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
		SCShader = Shader.Find("_Value4");
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
		SCShader = Shader.Find(":");
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
			IONHGBPGCHK().SetFloat("Image effects aren't supported on this device ({0})", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("Image", Size);
			EFDEIFCDAFG().SetFloat("PhotonView register is ignored, because viewID is 0. No id assigned yet to: ", ColorR);
			LPMLLJKMAMP().SetFloat("CameraFilterPack/Atmosphere_Rain", ColorG);
			NBPKMLMCHFN.SetFloat("skin.", ColorB);
			LPMLLJKMAMP().SetFloat("_MainTex2", Speed);
			HNFFHCLNBDN().SetVector("Triangle", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 371f, 419f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
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
		SCShader = Shader.Find("#pleasewait");
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
			DKNJGHFLAIF().SetFloat("settings.hitvariation", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("TwoHands", Size);
			KGOLDDBHIFN().SetFloat("22x3", ColorR);
			HNFFHCLNBDN().SetFloat("/", ColorG);
			EFDEIFCDAFG().SetFloat("pointBuffer", ColorB);
			HCGJCMDJPGD().SetFloat("DataText", Speed);
			KGOLDDBHIFN().SetVector("note.4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1246f, 1441f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHLADDCMFF());
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
			LONNIJMNKFB().SetFloat("_Speed", HBJJOCHGOPH);
			CECJJMKLEAK().SetFloat("#forever", Size);
			NBMPPNFKFLB().SetFloat("[SaveSystem] Outdated savefile found", ColorR);
			OKJOKHGJHGF().SetFloat("B:", ColorG);
			GJHLADDCMFF().SetFloat("_Red_C", ColorB);
			PLBEJJIHFPB().SetFloat("Vertical", Speed);
			HKGAONMOBMH().SetVector("DestroyPlayerObjects() failed, cause players can only destroy their own GameObjects. A Master Client can destroy anyone's. This is master: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 711f, 1470f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
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
		SCShader = Shader.Find("_EmissionColor");
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
		SCShader = Shader.Find("_TimeX");
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
			KGOLDDBHIFN().SetFloat("OnAwakeRPC", HBJJOCHGOPH);
			GJHLADDCMFF().SetFloat("_Level", Size);
			HKHBBBFLGJH().SetFloat("CameraFilterPack/Drawing_Laplacian", ColorR);
			LONNIJMNKFB().SetFloat("Drop_Near", ColorG);
			LPMLLJKMAMP().SetFloat("CameraFilterPack/FX_Mirror", ColorB);
			CECJJMKLEAK().SetFloat("DISTORT", Speed);
			HKGAONMOBMH().SetVector("X2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1100f, 606f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
		SCShader = Shader.Find("[MapEditor] Exported to ");
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
			DKNJGHFLAIF().SetFloat("_Near", HBJJOCHGOPH);
			HNFFHCLNBDN().SetFloat("USE_PREDICATION", Size);
			KGOLDDBHIFN().SetFloat("_Value", ColorR);
			DKNJGHFLAIF().SetFloat("_TimeX", ColorG);
			LPMLLJKMAMP().SetFloat("LevelConfigButton", ColorB);
			LPMLLJKMAMP().SetFloat("_Value8", Speed);
			OKJOKHGJHGF().SetVector("mapselector.filter.subscribedonly", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 220f, 213f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
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
			EOCCJGIGEGJ().SetFloat("_TimeX", HBJJOCHGOPH);
			GJHLADDCMFF().SetFloat("_Value3", Size);
			CECJJMKLEAK().SetFloat("float,0", ColorR);
			CECJJMKLEAK().SetFloat("The number of players playing your game: ", ColorG);
			CFEDGDGBCHE().SetFloat("settings.enablerankingnotifications", ColorB);
			NBMPPNFKFLB().SetFloat("#E14FFF", Speed);
			LPMLLJKMAMP().SetVector("Set Particle Size", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 710f, 1831f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CECJJMKLEAK());
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
			OKJOKHGJHGF().SetFloat("USE_CORNER_DETECTION", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("Anomaly_Far", Size);
			HKHBBBFLGJH().SetFloat("resource id", ColorR);
			FKEOGPDLBDD().SetFloat("CameraFilterPack/TV_WideScreenHV", ColorG);
			KGOLDDBHIFN().SetFloat(" ", ColorB);
			IONHGBPGCHK().SetFloat("' got destroyed by engine. This is OK when loading levels. Otherwise use: PhotonNetwork.Destroy().", Speed);
			OKJOKHGJHGF().SetVector("Please specify a map name or buildID", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1462f, 1880f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
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
			FKEOGPDLBDD().SetFloat("]", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("[ResourcesManager] Unloading data resources", Size);
			HCGJCMDJPGD().SetFloat("[MapEditor] Loading events...", ColorR);
			PLBEJJIHFPB().SetFloat("_MatrixSpeed", ColorG);
			IFMAPIDFNLI().SetFloat("settings.shaders.bloomintencity", ColorB);
			IONHGBPGCHK().SetFloat(" base map(s)", Speed);
			DKNJGHFLAIF().SetVector("PlayButton", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1899f, 493f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KMCPMOGKDEH()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}
}
