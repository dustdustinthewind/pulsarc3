// CameraFilterPack_Vision_Rainbow
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Vision/Rainbow")]
[ExecuteInEditMode]
public class CameraFilterPack_Vision_Rainbow : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 10f)]
	public float Speed = 1f;

	[Range(0f, 1f)]
	public float PosX = 0.5f;

	[Range(0f, 1f)]
	public float PosY = 0.5f;

	[Range(0f, 5f)]
	public float Colors = 0.5f;

	[Range(0f, 1f)]
	public float Vision = 0.5f;

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

	private void FJNCHGLIEMA()
	{
		SCShader = Shader.Find("[ItemsHandler] Loading ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DPIPGGDNGHN()
	{
	}

	private void FGOPJMGNHGO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material DONENAMLFLF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void GPFJMKCGHGB()
	{
	}

	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 715f)
			{
				HBJJOCHGOPH = 224f;
			}
			KEMAALEODNH().SetFloat("/Segment-[Right]", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("/", Speed);
			PLBEJJIHFPB().SetFloat("_Distortion", PosX);
			HHIAIGCAHDA().SetFloat("G:", PosY);
			PDEAHJPOMEF().SetFloat("CameraFilterPack/BlurTiltShift", Colors);
			MICHFGAOPKM().SetFloat("DifficultyBG", Vision);
			MFHPKGICPIO().SetVector("string", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 623f, 453f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material GKILCDHJFEG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void LEAHIBJDMBI()
	{
	}

	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1830f)
			{
				HBJJOCHGOPH = 1665f;
			}
			PDEAHJPOMEF().SetFloat(":", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("\n\n#", Speed);
			PDEAHJPOMEF().SetFloat("Fade", PosX);
			MICHFGAOPKM().SetFloat("LivesSlider", PosY);
			MFHPKGICPIO().SetFloat("SetLives", Colors);
			IGKFMCPDNOI().SetFloat(":", Vision);
			PDEAHJPOMEF().SetVector("float,0.5", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1497f, 303f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FDPOFMCFBMF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OMCLOFCJMPG()
	{
	}

	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 860f)
			{
				HBJJOCHGOPH = 61f;
			}
			DONENAMLFLF().SetFloat("_Value2", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("PLEASE WAIT", Speed);
			PDEAHJPOMEF().SetFloat("_TimeX", PosX);
			HHIAIGCAHDA().SetFloat("OK", PosY);
			AELJLBOJAIL().SetFloat("data", Colors);
			MFHPKGICPIO().SetFloat("settings.crosshairopacity", Vision);
			IGKFMCPDNOI().SetVector(" not exist", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1569f, 1389f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-126);
		}
		return BJFKDHHMLJH;
	}

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 8f)
			{
				HBJJOCHGOPH = 392f;
			}
			PLBEJJIHFPB().SetFloat("Preparing content", HBJJOCHGOPH);
			DONENAMLFLF().SetFloat("menu.enableselectormusic", Speed);
			GKILCDHJFEG().SetFloat("Set Sun MinSize", PosX);
			GKILCDHJFEG().SetFloat("player.playedtutorial", PosY);
			IGKFMCPDNOI().SetFloat("NewMapHandsCountSlider", Colors);
			PLBEJJIHFPB().SetFloat("_Offsets", Vision);
			PLBEJJIHFPB().SetVector("_AdaptTex", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1368f, 1717f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1799f)
			{
				HBJJOCHGOPH = 1943f;
			}
			PDEAHJPOMEF().SetFloat("Speed is a lerp speed of color changing. Greater values means faster changing. 0 - intant change", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("1 Kb", Speed);
			KEMAALEODNH().SetFloat("/", PosX);
			MICHFGAOPKM().SetFloat("/", PosY);
			PDEAHJPOMEF().SetFloat("[PlayerBase] Loaded custom model: ", Colors);
			IGKFMCPDNOI().SetFloat("_RampOffset", Vision);
			PLBEJJIHFPB().SetVector("[Up-Right-Down]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 652f, 1893f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1866f)
			{
				HBJJOCHGOPH = 40f;
			}
			IGKFMCPDNOI().SetFloat("stats on", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("NewMusicFileSelector", Speed);
			PLBEJJIHFPB().SetFloat("Rap", PosX);
			HHIAIGCAHDA().SetFloat("EndlessLoopsScoreText", PosY);
			PDEAHJPOMEF().SetFloat("OK", Colors);
			DNLMFEGJJDD().SetFloat("Stream did not contain properly formatted byte array", Vision);
			GKILCDHJFEG().SetVector("STICKLVER", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 43f, 176f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1464f)
			{
				HBJJOCHGOPH = 1314f;
			}
			PLBEJJIHFPB().SetFloat("_Fade", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat(",", Speed);
			AELJLBOJAIL().SetFloat("FrostCanvas", PosX);
			DONENAMLFLF().SetFloat("_Level", PosY);
			DNLMFEGJJDD().SetFloat("#orderby:", Colors);
			HHIAIGCAHDA().SetFloat("RecieveChatActionMessage", Vision);
			MFHPKGICPIO().SetVector("Image", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1961f, 1797f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 450f)
			{
				HBJJOCHGOPH = 980f;
			}
			HHIAIGCAHDA().SetFloat("Players NetIDs:", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("AddEnvironmentSprite", Speed);
			AELJLBOJAIL().SetFloat("_TimeX", PosX);
			DNLMFEGJJDD().SetFloat("_EmissionColor", PosY);
			GKILCDHJFEG().SetFloat("_Value3", Colors);
			PDEAHJPOMEF().SetFloat("_TimeX", Vision);
			DONENAMLFLF().SetVector("BitsData", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 691f, 1387f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MMMDPANNAIO()
	{
		SCShader = Shader.Find("CameraFilterPack/Blur_Noise");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AEEGKLABFLN()
	{
	}

	private void ICDBMJKMIKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FMNPFCHBLJF()
	{
		SCShader = Shader.Find("settings.crosshairopacity");
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

	private void FLKEJJEGCFA()
	{
		SCShader = Shader.Find(".wav");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material AELJLBOJAIL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)120;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)120;
		}
		return BJFKDHHMLJH;
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material KEMAALEODNH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)113;
		}
		return BJFKDHHMLJH;
	}

	private void KLILJHJNICK()
	{
		SCShader = Shader.Find("Joystick1Button5");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JOPCCCCHNLI()
	{
		SCShader = Shader.Find("ok");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PKBENONAOOL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1656f)
			{
				HBJJOCHGOPH = 1349f;
			}
			PLBEJJIHFPB().SetFloat("LostLive", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("/", Speed);
			NBPKMLMCHFN.SetFloat("maps.", PosX);
			KEMAALEODNH().SetFloat("_LightIntensity", PosY);
			IGKFMCPDNOI().SetFloat("Folk", Colors);
			AELJLBOJAIL().SetFloat("maps.", Vision);
			MFHPKGICPIO().SetVector("_MaxRadiusOrKInPaper", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 660f, 1592f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HHIAIGCAHDA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1605f)
			{
				HBJJOCHGOPH = 298f;
			}
			NBPKMLMCHFN.SetFloat("You need to have a Graphic control (such as an Image) for the list [", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("_PixelsPerMeterAtOneMeter", Speed);
			HHIAIGCAHDA().SetFloat("ConfigVersionSlider", PosX);
			DONENAMLFLF().SetFloat("_Green_G", PosY);
			MICHFGAOPKM().SetFloat("HitInRelaxMusicToggle", Colors);
			PLBEJJIHFPB().SetFloat("RT", Vision);
			GKILCDHJFEG().SetVector("CameraFilterPack_Atmosphere_Rain_FX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1596f, 1032f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FHGKIOOMMOH()
	{
		SCShader = Shader.Find("_HalfResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FBPHNEJBDJN()
	{
		SCShader = Shader.Find("Hex value #RRGGBB");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JOACBIEHHCE()
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
			NBPKMLMCHFN.SetFloat("_Value", Speed);
			NBPKMLMCHFN.SetFloat("_Value2", PosX);
			NBPKMLMCHFN.SetFloat("_Value3", PosY);
			NBPKMLMCHFN.SetFloat("_Value4", Colors);
			NBPKMLMCHFN.SetFloat("_Value5", Vision);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EGEGNHLODAA()
	{
	}

	private void GHILDCBCDJI()
	{
	}

	private void JHPOIOELNCG()
	{
	}

	[SpecialName]
	private Material DNLMFEGJJDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)86;
		}
		return BJFKDHHMLJH;
	}

	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1763f)
			{
				HBJJOCHGOPH = 1070f;
			}
			HHIAIGCAHDA().SetFloat("From {0} at Index {1} \n", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("_TimeX", Speed);
			DNLMFEGJJDD().SetFloat("_ScreenResolution", PosX);
			IGKFMCPDNOI().SetFloat(":", PosY);
			GKILCDHJFEG().SetFloat("Done! You are a contributor until: ", Colors);
			IGKFMCPDNOI().SetFloat("Set Particles Gravity", Vision);
			KEMAALEODNH().SetVector("CameraFilterPack_AAA_Blood1", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1172f, 192f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EFJDNLGNACH()
	{
		SCShader = Shader.Find("_History1ChromaTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1761f)
			{
				HBJJOCHGOPH = 283f;
			}
			MICHFGAOPKM().SetFloat("y", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("id", Speed);
			PLBEJJIHFPB().SetFloat("_GlowColor", PosX);
			MICHFGAOPKM().SetFloat("CameraFilterPack/Blend2Camera_Hue", PosY);
			NBPKMLMCHFN.SetFloat("#no", Colors);
			KEMAALEODNH().SetFloat("player.xp", Vision);
			PDEAHJPOMEF().SetVector("roomDescription", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1569f, 1774f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GPNAOAKCMHC()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BJOHDLNDFAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AEIJFLJEABG()
	{
	}

	private void KIEJKBNBHMD()
	{
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Vision_Rainbow");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LADCJEIALMH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AAPKBNDHBLI()
	{
	}

	private void EDBEHEKMGFH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BFEILOMHNPC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material PLBEJJIHFPB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-87);
		}
		return BJFKDHHMLJH;
	}

	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 560f)
			{
				HBJJOCHGOPH = 1986f;
			}
			AELJLBOJAIL().SetFloat("_Value2", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("_Value2", Speed);
			PDEAHJPOMEF().SetFloat("_Value6", PosX);
			MFHPKGICPIO().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", PosY);
			DNLMFEGJJDD().SetFloat("Game Version: ", Colors);
			DNLMFEGJJDD().SetFloat("ConnectToMaster() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", Vision);
			AELJLBOJAIL().SetVector("SpectatingUserInfo", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1993f, 768f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FDMAEPOHDMK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1798f)
			{
				HBJJOCHGOPH = 723f;
			}
			NBPKMLMCHFN.SetFloat("_Threshold", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("settings.shaders.bloomintencity", Speed);
			HHIAIGCAHDA().SetFloat("#availablechallenges", PosX);
			MICHFGAOPKM().SetFloat("open", PosY);
			PDEAHJPOMEF().SetFloat("ViewMenu", Colors);
			KEMAALEODNH().SetFloat("CameraFilterPack/FX_InverChromiLum", Vision);
			NBPKMLMCHFN.SetVector("settings.enableranking", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1658f, 348f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1611f)
			{
				HBJJOCHGOPH = 1912f;
			}
			IGKFMCPDNOI().SetFloat("ReconnectAndRejoin() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("_FixDistance", Speed);
			KEMAALEODNH().SetFloat("_EmissionGain", PosX);
			DONENAMLFLF().SetFloat("mapselector.filter.favoriteonly", PosY);
			IGKFMCPDNOI().SetFloat("SpawnObj", Colors);
			AELJLBOJAIL().SetFloat("skin.hit_normal", Vision);
			GKILCDHJFEG().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1151f, 325f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 493f)
			{
				HBJJOCHGOPH = 109f;
			}
			KEMAALEODNH().SetFloat("offsets", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("EventData0DropDownList", Speed);
			PLBEJJIHFPB().SetFloat("[Down]", PosX);
			PLBEJJIHFPB().SetFloat("ItemNameBGImage", PosY);
			PDEAHJPOMEF().SetFloat("_FarCamera", Colors);
			IGKFMCPDNOI().SetFloat("ok", Vision);
			DONENAMLFLF().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 654f, 584f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1964f)
			{
				HBJJOCHGOPH = 1753f;
			}
			MFHPKGICPIO().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("BitsData", Speed);
			DNLMFEGJJDD().SetFloat("In Main Menu", PosX);
			IGKFMCPDNOI().SetFloat("Bass", PosY);
			KEMAALEODNH().SetFloat("[MapsEditor] Creating new item...", Colors);
			MICHFGAOPKM().SetFloat("_Offsets", Vision);
			HHIAIGCAHDA().SetVector(": ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 943f, 1268f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1013f)
			{
				HBJJOCHGOPH = 1253f;
			}
			PDEAHJPOMEF().SetFloat("#done", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("_Value3", Speed);
			MFHPKGICPIO().SetFloat("[PlayerController] ", PosX);
			IGKFMCPDNOI().SetFloat("_MainTex2", PosY);
			DNLMFEGJJDD().SetFloat("shader.none", Colors);
			MICHFGAOPKM().SetFloat("_TimeX", Vision);
			GKILCDHJFEG().SetVector("LivesSlider", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 598f, 1287f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LCJHDLKJEOM()
	{
	}

	private void JOJFHFHOCHO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FPHLDMMAOEF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material MICHFGAOPKM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-112);
		}
		return BJFKDHHMLJH;
	}

	private void OEENOOGEEHD()
	{
	}

	private void OFPPIKHNJOD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material MFHPKGICPIO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void JBCNIPJDPJB()
	{
	}

	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 189f)
			{
				HBJJOCHGOPH = 253f;
			}
			IGKFMCPDNOI().SetFloat("PossibleMapPointsText", HBJJOCHGOPH);
			DONENAMLFLF().SetFloat("GlassAberration", Speed);
			KEMAALEODNH().SetFloat("CameraFilterPack/Drawing_Curve", PosX);
			NBPKMLMCHFN.SetFloat("ComboScoreText", PosY);
			AELJLBOJAIL().SetFloat("_VelTex", Colors);
			PDEAHJPOMEF().SetFloat("win", Vision);
			GKILCDHJFEG().SetVector("float,0", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1931f, 286f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
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

	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 258f)
			{
				HBJJOCHGOPH = 1899f;
			}
			DONENAMLFLF().SetFloat("ConnectToMaster() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat("_TimeX", Speed);
			KEMAALEODNH().SetFloat("float,1", PosX);
			IGKFMCPDNOI().SetFloat("Tab1Content", PosY);
			MICHFGAOPKM().SetFloat("DisableStoryboardToggle", Colors);
			AELJLBOJAIL().SetFloat("ConnectToRegion: ", Vision);
			DONENAMLFLF().SetVector("red", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1639f, 280f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
