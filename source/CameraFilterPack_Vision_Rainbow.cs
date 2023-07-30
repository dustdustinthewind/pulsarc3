// CameraFilterPack_Vision_Rainbow
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Vision/Rainbow")]
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
		SCShader = Shader.Find("steamid");
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
			PLBEJJIHFPB().SetFloat("LoadPlayerSkin", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat("menu.tabid", Speed);
			PLBEJJIHFPB().SetFloat("_Cible", PosX);
			DONENAMLFLF().SetFloat("#", PosY);
			GKILCDHJFEG().SetFloat("_ScreenResolution", Colors);
			MICHFGAOPKM().SetFloat("http://steamcommunity.com/sharedfiles/filedetails/?id=", Vision);
			PDEAHJPOMEF().SetVector("bool", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 623f, 453f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			PDEAHJPOMEF().SetFloat("Start index must in an integer.", HBJJOCHGOPH);
			HHIAIGCAHDA().SetFloat("\n\n#", Speed);
			NBPKMLMCHFN.SetFloat("_Value4", PosX);
			MFHPKGICPIO().SetFloat("MaxLivesSlider", PosY);
			GKILCDHJFEG().SetFloat("_EmissionColor", Colors);
			AELJLBOJAIL().SetFloat(":", Vision);
			KEMAALEODNH().SetVector("seconds", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1497f, 303f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
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
			KEMAALEODNH().SetFloat("_Value1", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("Preparing content", Speed);
			IGKFMCPDNOI().SetFloat("_TimeX", PosX);
			MICHFGAOPKM().SetFloat("Done!", PosY);
			KEMAALEODNH().SetFloat("data", Colors);
			MICHFGAOPKM().SetFloat("}", Vision);
			MICHFGAOPKM().SetVector(": ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1569f, 1389f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
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
			GKILCDHJFEG().SetFloat("0.00/0.00", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("settings.fps", Speed);
			KEMAALEODNH().SetFloat("Set Sun MinSize", PosX);
			DNLMFEGJJDD().SetFloat("https://store.steampowered.com/recommended/recommendgame/", PosY);
			DNLMFEGJJDD().SetFloat("Editor/", Colors);
			PLBEJJIHFPB().SetFloat("_Offsets", Vision);
			PDEAHJPOMEF().SetVector("intensity", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1368f, 1717f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			GKILCDHJFEG().SetFloat("Speed is a lerp speed of color changing. Greater values means faster changing. 0 - intant change", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat("/", Speed);
			GKILCDHJFEG().SetFloat("/", PosX);
			MICHFGAOPKM().SetFloat("/../", PosY);
			IGKFMCPDNOI().SetFloat("Gameplay/sun", Colors);
			DONENAMLFLF().SetFloat("_MainTex", Vision);
			HHIAIGCAHDA().SetVector("[Up-Right-Down]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 652f, 1893f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
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
			DONENAMLFLF().SetFloat("Out {0,4} | In {1,4} | Sum {2,4}", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("/", Speed);
			IGKFMCPDNOI().SetFloat("Pop", PosX);
			PLBEJJIHFPB().SetFloat("CheckpointsScoreText", PosY);
			HHIAIGCAHDA().SetFloat("You must complete your map before submiting it to Workshop", Colors);
			MFHPKGICPIO().SetFloat("cipherText", Vision);
			MFHPKGICPIO().SetVector("STICKLHOR", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 43f, 176f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
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
			AELJLBOJAIL().SetFloat("_TimeX", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat(",", Speed);
			NBPKMLMCHFN.SetFloat("settings.shaders", PosX);
			GKILCDHJFEG().SetFloat("_TimeX", PosY);
			MFHPKGICPIO().SetFloat("#orderby:", Colors);
			GKILCDHJFEG().SetFloat("RecieveChatActionMessage", Vision);
			GKILCDHJFEG().SetVector("Image", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1961f, 1797f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
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
			AELJLBOJAIL().SetFloat("<b>Kick player by NetID</b>\nuse: /kick {NetID}\nUse \"/players\" command to get all NetIDs\nRoom owner only can kick the players", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("AddEnvironmentSprite", Speed);
			DNLMFEGJJDD().SetFloat("_TimeX", PosX);
			NBPKMLMCHFN.SetFloat("_EmissionColor", PosY);
			DONENAMLFLF().SetFloat("_Value3", Colors);
			MFHPKGICPIO().SetFloat("_TimeX", Vision);
			PDEAHJPOMEF().SetVector("BitsData", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 691f, 1387f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MMMDPANNAIO()
	{
		SCShader = Shader.Find("_ScreenResolution");
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
		SCShader = Shader.Find("settings.cameramovements");
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
		SCShader = Shader.Find(".ogg");
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
		SCShader = Shader.Find("Joystick1Button4");
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
			KEMAALEODNH().SetFloat("]", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("FileLabel", Speed);
			KEMAALEODNH().SetFloat("maps.", PosX);
			PDEAHJPOMEF().SetFloat("_LightIntensity", PosY);
			PLBEJJIHFPB().SetFloat("Electronic", Colors);
			PLBEJJIHFPB().SetFloat("maps.", Vision);
			NBPKMLMCHFN.SetVector("_SoftZDistance", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 660f, 1592f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			IGKFMCPDNOI().SetFloat("You need to have a child LayoutGroup content set for the list: ", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_HalfResolution", Speed);
			DNLMFEGJJDD().SetFloat("ConfigVersionSlider", PosX);
			MFHPKGICPIO().SetFloat("_Green_R", PosY);
			AELJLBOJAIL().SetFloat("HitInRelaxMusicToggle", Colors);
			AELJLBOJAIL().SetFloat("LT", Vision);
			IGKFMCPDNOI().SetVector("CameraFilterPack_Atmosphere_Rain_FX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1596f, 1032f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FHGKIOOMMOH()
	{
		SCShader = Shader.Find("_MaxSteps");
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
			IGKFMCPDNOI().SetFloat("\n", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("CameraFilterPack/TV_CompressionFX", Speed);
			MFHPKGICPIO().SetFloat("_Value4", PosX);
			MFHPKGICPIO().SetFloat("LevelEditor/CustomEventEditor-Text", PosY);
			AELJLBOJAIL().SetFloat("error", Colors);
			HHIAIGCAHDA().SetFloat("SetParticlesGravity", Vision);
			DNLMFEGJJDD().SetVector("CameraFilterPack_AAA_Blood1", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1172f, 192f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EFJDNLGNACH()
	{
		SCShader = Shader.Find("_History3LumaTex");
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
			NBPKMLMCHFN.SetFloat("y", HBJJOCHGOPH);
			DONENAMLFLF().SetFloat("Remove Environment Object", Speed);
			HHIAIGCAHDA().SetFloat("_Value3", PosX);
			PDEAHJPOMEF().SetFloat("CameraFilterPack/Blend2Camera_Hue", PosY);
			DNLMFEGJJDD().SetFloat(".completed", Colors);
			DONENAMLFLF().SetFloat("player.xp", Vision);
			IGKFMCPDNOI().SetVector("RoomDescriptionText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1569f, 1774f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GPNAOAKCMHC()
	{
		SCShader = Shader.Find("CameraFilterPack/Colors_BleachBypass");
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
			PLBEJJIHFPB().SetFloat("_Value2", HBJJOCHGOPH);
			HHIAIGCAHDA().SetFloat("_Value", Speed);
			MFHPKGICPIO().SetFloat("_Value6", PosX);
			HHIAIGCAHDA().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", PosY);
			PDEAHJPOMEF().SetFloat("<color=#{0}>{1}</color>", Colors);
			AELJLBOJAIL().SetFloat(":", Vision);
			AELJLBOJAIL().SetVector("SpectatingUserInfo", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1993f, 768f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
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
			MFHPKGICPIO().SetFloat("_Exponent", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("bloomintencity:", Speed);
			NBPKMLMCHFN.SetFloat("<b>", PosX);
			DNLMFEGJJDD().SetFloat("Room: '{0}' {1},{2} {4}/{3} players.", PosY);
			PLBEJJIHFPB().SetFloat("GenerationMenu", Colors);
			HHIAIGCAHDA().SetFloat("_ScreenResolution", Vision);
			GKILCDHJFEG().SetVector("HPToggle", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1658f, 348f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
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
			GKILCDHJFEG().SetFloat("ReconnectAndRejoin() disabled the offline mode. No longer offline.", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("_FixDistance", Speed);
			DONENAMLFLF().SetFloat("_EmissionColor", PosX);
			IGKFMCPDNOI().SetFloat("mapselector.lastSearch", PosY);
			IGKFMCPDNOI().SetFloat("[Down]", Colors);
			GKILCDHJFEG().SetFloat("sounds/hit_perfect", Vision);
			MICHFGAOPKM().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1151f, 325f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
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
			PDEAHJPOMEF().SetFloat("_threshold", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat(":", Speed);
			MFHPKGICPIO().SetFloat("[Down]", PosX);
			IGKFMCPDNOI().SetFloat("IconImage", PosY);
			PDEAHJPOMEF().SetFloat("_FarCamera", Colors);
			PDEAHJPOMEF().SetFloat("ok", Vision);
			AELJLBOJAIL().SetVector("CameraFilterPack/TV_Video3D", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 654f, 584f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
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
			KEMAALEODNH().SetFloat("_TimeX", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("BitsData", Speed);
			HHIAIGCAHDA().SetFloat("In Main Menu", PosX);
			GKILCDHJFEG().SetFloat("Bass", PosY);
			DONENAMLFLF().SetFloat("#yes", Colors);
			GKILCDHJFEG().SetFloat("_Offsets", Vision);
			MFHPKGICPIO().SetVector(" / ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 943f, 1268f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DONENAMLFLF());
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
			PDEAHJPOMEF().SetFloat("#savemapbeforeuploading", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("_Value2", Speed);
			KEMAALEODNH().SetFloat(" not exist", PosX);
			DNLMFEGJJDD().SetFloat("_MainTex2", PosY);
			DNLMFEGJJDD().SetFloat("shader.pixel", Colors);
			DNLMFEGJJDD().SetFloat("_Distortion", Vision);
			IGKFMCPDNOI().SetVector("Tab2Content", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 598f, 1287f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			DONENAMLFLF().SetFloat("0.00", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat("GlassDistortion", Speed);
			KEMAALEODNH().SetFloat("_ScreenResolution", PosX);
			AELJLBOJAIL().SetFloat("ComboScoreText", PosY);
			MICHFGAOPKM().SetFloat("_Jitter", Colors);
			IGKFMCPDNOI().SetFloat("win", Vision);
			DNLMFEGJJDD().SetVector("y", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1931f, 286f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			MFHPKGICPIO().SetFloat(":", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("_TimeX", Speed);
			PLBEJJIHFPB().SetFloat("value", PosX);
			DONENAMLFLF().SetFloat("Tab1Content", PosY);
			DNLMFEGJJDD().SetFloat("settings.enablehitsoundsinrelax", Colors);
			GKILCDHJFEG().SetFloat("ConnectToRegion() failed. Can only connect while in state 'Disconnected'. Current state: ", Vision);
			IGKFMCPDNOI().SetVector("red", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1639f, 280f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
