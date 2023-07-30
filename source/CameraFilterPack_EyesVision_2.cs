// CameraFilterPack_EyesVision_2
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Vision/Eyes 2")]
[ExecuteInEditMode]
public class CameraFilterPack_EyesVision_2 : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	[Range(1f, 32f)]
	public float _EyeWave = 15f;

	[Range(0f, 10f)]
	public float _EyeSpeed = 1f;

	[Range(0f, 8f)]
	public float _EyeMove = 2f;

	[Range(0f, 1f)]
	public float _EyeBlink = 1f;

	private Material BJFKDHHMLJH;

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

	[SpecialName]
	private Material HNICHJCGJOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1741f)
			{
				HBJJOCHGOPH = 216f;
			}
			MMOODGIODPC().SetFloat("_ColorRGB", HBJJOCHGOPH);
			IFMAPIDFNLI().SetFloat("_MainTex2", _EyeWave);
			LONNIJMNKFB().SetFloat("IconImage", _EyeSpeed);
			OCHJIMJNEMO().SetFloat("1", _EyeMove);
			EJDPNJAEAKJ().SetFloat("_Fade", _EyeBlink);
			NBPKMLMCHFN.SetTexture("CameraFilterPack/Blend2Camera_Saturation", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BGDONBMDPGM()
	{
	}

	private void LCHBFNIPBHB()
	{
	}

	private void BLKGOMCPEKI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LBPHCAMMAPB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material ABHDNGIHBKE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void NFEDLAOPHML()
	{
	}

	private void FHGKIOOMMOH()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack/FX_Glitch3") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/3D_Binary");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material DOHGBNPMBKG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 643f)
			{
				HBJJOCHGOPH = 1787f;
			}
			LONNIJMNKFB().SetFloat(".wav", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat("_ScreenResolution", _EyeWave);
			EJDPNJAEAKJ().SetFloat("Add Environment Sprite", _EyeSpeed);
			EJDPNJAEAKJ().SetFloat("_Value3", _EyeMove);
			HNICHJCGJOC().SetFloat("maps.", _EyeBlink);
			IGIAPKPKGPK().SetTexture("Crosshair", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
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

	private void OEENOOGEEHD()
	{
	}

	private void JDGFCEPDKAJ()
	{
	}

	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 858f)
			{
				HBJJOCHGOPH = 971f;
			}
			ABHDNGIHBKE().SetFloat("Screenshots only supported in PlayMode", HBJJOCHGOPH);
			MMOODGIODPC().SetFloat("intensity", _EyeWave);
			JLHLHKPHDFO().SetFloat(".mp3", _EyeSpeed);
			HNICHJCGJOC().SetFloat(": ", _EyeMove);
			ABHDNGIHBKE().SetFloat("InfoButton", _EyeBlink);
			ABHDNGIHBKE().SetTexture("maps.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OKLAJINHPAN()
	{
		FPHEBLMINDA = Resources.Load("HiddenToggle") as Texture2D;
		SCShader = Shader.Find("_Contrast");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material OCHJIMJNEMO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void PDHKMDBNGGN()
	{
		FPHEBLMINDA = Resources.Load("_Offsets") as Texture2D;
		SCShader = Shader.Find("Items/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FPHLDMMAOEF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CCLNNLCOPBL()
	{
		FPHEBLMINDA = Resources.Load("_Green_B") as Texture2D;
		SCShader = Shader.Find("_Near");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JHJFBCFBKLD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JKFDDNMPOJH()
	{
		FPHEBLMINDA = Resources.Load("request") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Blur_DitherOffset");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KLOLKEBAPFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 239f)
			{
				HBJJOCHGOPH = 1653f;
			}
			HKHBBBFLGJH().SetFloat("Not sending leave operation. State is not 'Joined': ", HBJJOCHGOPH);
			EJDPNJAEAKJ().SetFloat("_Value", _EyeWave);
			IFMAPIDFNLI().SetFloat("z", _EyeSpeed);
			EJDPNJAEAKJ().SetFloat("#.##", _EyeMove);
			ABHDNGIHBKE().SetFloat("Ev DestroyAll! By PlayerId: ", _EyeBlink);
			ABHDNGIHBKE().SetTexture("Set Crosshair Color", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ONKDMMJPEMN()
	{
	}

	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1474f)
			{
				HBJJOCHGOPH = 12f;
			}
			JLHLHKPHDFO().SetFloat("_AlphaUV", HBJJOCHGOPH);
			IGIAPKPKGPK().SetFloat("_VignetteTex", _EyeWave);
			JLHLHKPHDFO().SetFloat("_TimeX", _EyeSpeed);
			JLHLHKPHDFO().SetFloat("maps.", _EyeMove);
			LONNIJMNKFB().SetFloat("_Green_G", _EyeBlink);
			HNICHJCGJOC().SetTexture("[MapsEditor] Creating new item...", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
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

	private void AMHEJBMLFNM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DNENFLNCIJP()
	{
	}

	[SpecialName]
	private Material JLHLHKPHDFO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)79;
		}
		return BJFKDHHMLJH;
	}

	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 306f)
			{
				HBJJOCHGOPH = 616f;
			}
			HNICHJCGJOC().SetFloat("_Exposure", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("tagElement", _EyeWave);
			LNLKMDPHDCC().SetFloat("RaiseEvent() failed. Your event is not being sent! Check if your are in a Room and the eventCode must be less than 200 (0..199).", _EyeSpeed);
			IGIAPKPKGPK().SetFloat("Can't set open when not in that room.", _EyeMove);
			HNICHJCGJOC().SetFloat("Rotate environment object to the rotation", _EyeBlink);
			OKJOKHGJHGF().SetTexture("[Down]", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FKEJGBFDCAH()
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
			if (HBJJOCHGOPH > 1747f)
			{
				HBJJOCHGOPH = 1904f;
			}
			HFBJAOFLCJI().SetFloat("Please attach component to a Graphical UI component", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("Left Click", _EyeWave);
			ACHNOHCLGOO().SetFloat(" not exist", _EyeSpeed);
			HNICHJCGJOC().SetFloat("Up", _EyeMove);
			JLHLHKPHDFO().SetFloat("Playing ", _EyeBlink);
			DOHGBNPMBKG().SetTexture("_Value3", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CNDACAHCCOI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1691f)
			{
				HBJJOCHGOPH = 975f;
			}
			ACHNOHCLGOO().SetFloat("ERROR: Preview file must be <1MB!", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("_SampleScale", _EyeWave);
			IGIAPKPKGPK().SetFloat("/", _EyeSpeed);
			FEAEGGCNIAA().SetFloat("_Value4", _EyeMove);
			IIBLJCKLGFG().SetFloat("_Value2", _EyeBlink);
			IGIAPKPKGPK().SetTexture("Joystick1Button3", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EPEGAEGDJAM()
	{
		FPHEBLMINDA = Resources.Load("Bad parameters for set! Use <language>") as Texture2D;
		SCShader = Shader.Find("resetach21");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material GKILCDHJFEG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideAndDontSave | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	private void KMOCDAOKGLI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material ACHNOHCLGOO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void CPAJLKHMOJB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1030f)
			{
				HBJJOCHGOPH = 1364f;
			}
			JLHLHKPHDFO().SetFloat("[PlayerController] ", HBJJOCHGOPH);
			IFMAPIDFNLI().SetFloat("Hidden/DepthOfField/MedianFilter", _EyeWave);
			FEAEGGCNIAA().SetFloat("Reading preview file failed! Make sure JSON file is filled properly and/or file exists: \"{0}\"", _EyeSpeed);
			OCHJIMJNEMO().SetFloat("_Offsets", _EyeMove);
			OCHJIMJNEMO().SetFloat("/", _EyeBlink);
			MMOODGIODPC().SetTexture("_MainTex2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BKGJOECFMID()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Start()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_eyes_vision_2") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/EyesVision_2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void Update()
	{
	}

	[SpecialName]
	private Material LNLKMDPHDCC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)104;
		}
		return BJFKDHHMLJH;
	}

	private void HNILMGEKDEC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OFMNDBNFBDJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HKHBBBFLGJH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void ODBNMPGBCGO()
	{
		FPHEBLMINDA = Resources.Load("randomdrop") as Texture2D;
		SCShader = Shader.Find("#pleasewait");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LPMINJJPDCH()
	{
	}

	private void EKCDEFDELMP()
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

	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1618f)
			{
				HBJJOCHGOPH = 1291f;
			}
			JLHLHKPHDFO().SetFloat(": ", HBJJOCHGOPH);
			JLHLHKPHDFO().SetFloat(": ", _EyeWave);
			IIBLJCKLGFG().SetFloat("CameraFilterPack/FX_Glitch3", _EyeSpeed);
			HNICHJCGJOC().SetFloat("Operation failed: ", _EyeMove);
			EJDPNJAEAKJ().SetFloat("_Value", _EyeBlink);
			LNLKMDPHDCC().SetTexture("Joystick1Button11", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material IGIAPKPKGPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void KDMKDEKCELE()
	{
		FPHEBLMINDA = Resources.Load("LoadingStatusText") as Texture2D;
		SCShader = Shader.Find("[NetworkManager] Updating rooms...");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GHILDCBCDJI()
	{
	}

	private void BMIOFJFMCBG()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack/Distortion_Noise") as Texture2D;
		SCShader = Shader.Find("EndlessLoopsScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IFJDKDFLGBG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FJIKDJAMOHA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material MMOODGIODPC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-100);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material LONNIJMNKFB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void DIPDEHOOBPG()
	{
		FPHEBLMINDA = Resources.Load(" not exist") as Texture2D;
		SCShader = Shader.Find("Room: '{0}' {1},{2} {4}/{3} players.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DBEMDAJDDDA()
	{
		FPHEBLMINDA = Resources.Load("green") as Texture2D;
		SCShader = Shader.Find("???");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material IFMAPIDFNLI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)94;
		}
		return BJFKDHHMLJH;
	}

	private void DHNGNHGDPLM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OCMKCBBCEFG()
	{
	}

	private void BMOFEBKGLFI()
	{
		FPHEBLMINDA = Resources.Load("offsets") as Texture2D;
		SCShader = Shader.Find("DPADVER");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HLDFOJMHKNL()
	{
	}

	private void NAOLAJPDGIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material OKJOKHGJHGF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1499f)
			{
				HBJJOCHGOPH = 1093f;
			}
			EJDPNJAEAKJ().SetFloat("player.quantum", HBJJOCHGOPH);
			IFMAPIDFNLI().SetFloat("Case-Sensitive", _EyeWave);
			IFMAPIDFNLI().SetFloat("float,1", _EyeSpeed);
			IGIAPKPKGPK().SetFloat("_Value2", _EyeMove);
			ABHDNGIHBKE().SetFloat("_Vignetting2", _EyeBlink);
			DOHGBNPMBKG().SetTexture("CameraFilterPack/Distortion_Flush", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MMBPLGGLPDB()
	{
	}

	private void JDKHBGDEONK()
	{
		FPHEBLMINDA = Resources.Load("<b>Kick player by NetID</b>\nuse: /kick {NetID}\nUse \"/players\" command to get all NetIDs\nRoom owner only can kick the players") as Texture2D;
		SCShader = Shader.Find(") then the masterserver requests a disconnect!");
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
			NBPKMLMCHFN.SetFloat("_Value", _EyeWave);
			NBPKMLMCHFN.SetFloat("_Value2", _EyeSpeed);
			NBPKMLMCHFN.SetFloat("_Value3", _EyeMove);
			NBPKMLMCHFN.SetFloat("_Value4", _EyeBlink);
			NBPKMLMCHFN.SetTexture("_MainTex2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FABKIGNFECE()
	{
	}

	private void ICDBMJKMIKC()
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
			if (HBJJOCHGOPH > 384f)
			{
				HBJJOCHGOPH = 404f;
			}
			ABHDNGIHBKE().SetFloat("_Value", HBJJOCHGOPH);
			JLHLHKPHDFO().SetFloat("&search=", _EyeWave);
			IIBLJCKLGFG().SetFloat("arc", _EyeSpeed);
			MMOODGIODPC().SetFloat("UI Extensions/UI Image Crop", _EyeMove);
			OCHJIMJNEMO().SetFloat("th", _EyeBlink);
			DOHGBNPMBKG().SetTexture("_CenterY", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IDIIELPAMCJ()
	{
	}

	[SpecialName]
	private Material EJDPNJAEAKJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material FEAEGGCNIAA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void GPNAOAKCMHC()
	{
		FPHEBLMINDA = Resources.Load("skin.hit_perfect") as Texture2D;
		SCShader = Shader.Find(".lastCheckpoint.time");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EJJEDJIOFAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HFBJAOFLCJI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void AEEGKLABFLN()
	{
	}

	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 686f)
			{
				HBJJOCHGOPH = 1890f;
			}
			HFBJAOFLCJI().SetFloat("checkpoint", HBJJOCHGOPH);
			IGIAPKPKGPK().SetFloat("Map: ", _EyeWave);
			GKILCDHJFEG().SetFloat("Square", _EyeSpeed);
			EJDPNJAEAKJ().SetFloat("GlassColor", _EyeMove);
			FEAEGGCNIAA().SetFloat("GridDataStoryboard", _EyeBlink);
			HKHBBBFLGJH().SetTexture("note.5", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EJDPNJAEAKJ());
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

	private void CCPEDDLAMIB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JOPCCCCHNLI()
	{
		FPHEBLMINDA = Resources.Load("Joystick1Button2") as Texture2D;
		SCShader = Shader.Find("#useticket");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void COOHIILCOCO()
	{
		FPHEBLMINDA = Resources.Load("player.goldbat") as Texture2D;
		SCShader = Shader.Find("mapselector.filter.subscribedonly");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HJPCJGOEKMF()
	{
		FPHEBLMINDA = Resources.Load("MenuVolumeSlider") as Texture2D;
		SCShader = Shader.Find("Finished");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KLILJHJNICK()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack/Blend2Camera_LinearBurn") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Colors_HUE_Rotate");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HIKKPDACJGI()
	{
	}

	private void MJEFMIPLFAB()
	{
		FPHEBLMINDA = Resources.Load("0") as Texture2D;
		SCShader = Shader.Find("EventSystem");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PHJJHFBLICM()
	{
	}

	[SpecialName]
	private Material IIBLJCKLGFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)101;
		}
		return BJFKDHHMLJH;
	}
}
