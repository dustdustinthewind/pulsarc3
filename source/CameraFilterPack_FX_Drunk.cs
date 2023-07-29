// CameraFilterPack_FX_Drunk
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/FX/Drunk")]
public class CameraFilterPack_FX_Drunk : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 20f)]
	[HideInInspector]
	public float Value = 6f;

	[Range(0f, 10f)]
	public float Speed = 1f;

	[Range(0f, 1f)]
	public float Wavy = 1f;

	[Range(0f, 1f)]
	public float Distortion;

	[Range(0f, 1f)]
	public float DistortionWave;

	[Range(0f, 1f)]
	public float Fade = 1f;

	[Range(-2f, 2f)]
	public float ColoredSaturate = 1f;

	[Range(-1f, 2f)]
	public float ColoredChange;

	[Range(-1f, 1f)]
	public float ChangeRed;

	[Range(-1f, 1f)]
	public float ChangeGreen;

	[Range(-1f, 1f)]
	public float ChangeBlue;

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
	private Material LPCHMEKDCHI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-110);
		}
		return BJFKDHHMLJH;
	}

	private void PKLOBJHKFEO()
	{
		SCShader = Shader.Find("_ColorRGB");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FLKEJJEGCFA()
	{
		SCShader = Shader.Find("_Far");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material MFHPKGICPIO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)72;
		}
		return BJFKDHHMLJH;
	}

	private void Update()
	{
	}

	private void BGFJOEPFOPM()
	{
	}

	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1423f)
			{
				HBJJOCHGOPH = 1747f;
			}
			NBPKMLMCHFN.SetFloat(": ", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("gamemode", Value);
			BFGNMFCNDBC().SetFloat("[MapEditor] Openning ", Speed);
			HCGJCMDJPGD().SetFloat("[Right-Left]", Distortion);
			KBOPGONOCNP().SetFloat("Tab2Content", DistortionWave);
			KEMJNOMIPHN().SetFloat("-", Wavy);
			KBOPGONOCNP().SetFloat("_Value", Fade);
			NFMGLIKNOOC().SetFloat(" not exist", ColoredChange);
			KEMJNOMIPHN().SetFloat("_Value2", ChangeRed);
			OKJOKHGJHGF().SetFloat("SetSatelliteColor", ChangeGreen);
			LNLKMDPHDCC().SetFloat("_ScreenResolution", ChangeBlue);
			OCHJIMJNEMO().SetFloat("catched: ", ColoredSaturate);
			HKGAONMOBMH().SetVector("1", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1453f, 140f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void POIMNOBDBBN()
	{
	}

	private void LMADKINICIN()
	{
	}

	[SpecialName]
	private Material OLHDPICFBOF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)69;
		}
		return BJFKDHHMLJH;
	}

	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1522f)
			{
				HBJJOCHGOPH = 1694f;
			}
			NLFJGMBCICG().SetFloat("Fill", HBJJOCHGOPH);
			OCHJIMJNEMO().SetFloat("RarityImage", Value);
			MFHPKGICPIO().SetFloat("_Offsets", Speed);
			LNLKMDPHDCC().SetFloat("Object ID. Case-Sensitive", Distortion);
			EPCGJFCCAFH().SetFloat("/", DistortionWave);
			NLFJGMBCICG().SetFloat("CameraFilterPack/3D_Scan_Scene", Wavy);
			LPCHMEKDCHI().SetFloat(": ", Fade);
			NBPKMLMCHFN.SetFloat(" ", ColoredChange);
			LNLKMDPHDCC().SetFloat("RT", ChangeRed);
			HKGAONMOBMH().SetFloat("_MainTex", ChangeGreen);
			BFGNMFCNDBC().SetFloat("_TimeX", ChangeBlue);
			DONENAMLFLF().SetFloat("FPSToggle", ColoredSaturate);
			NFMGLIKNOOC().SetVector("_Radius", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1433f, 853f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
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

	private void IMCKJCHKMKB()
	{
		SCShader = Shader.Find("SetBGColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-101);
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

	private void PAKPHKPDKGE()
	{
		SCShader = Shader.Find("SpawnObj");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material IGKFMCPDNOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-108);
		}
		return BJFKDHHMLJH;
	}

	private void NNCCPEBIAKH()
	{
		SCShader = Shader.Find("MenuScene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)77;
		}
		return BJFKDHHMLJH;
	}

	private void KMCPMOGKDEH()
	{
		SCShader = Shader.Find("MenuScene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material OKJOKHGJHGF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-103);
		}
		return BJFKDHHMLJH;
	}

	private void JECMJNFGBGC()
	{
		SCShader = Shader.Find("' got destroyed by engine. This is OK when loading levels. Otherwise use: PhotonNetwork.Destroy().");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KDMKDEKCELE()
	{
		SCShader = Shader.Find("x");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JHJGJJKELJM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1764f)
			{
				HBJJOCHGOPH = 385f;
			}
			OCHJIMJNEMO().SetFloat("Error: I/O Failure! :(", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("EnableRankedNotificationsToggle", Value);
			IGKFMCPDNOI().SetFloat("_Value2", Speed);
			EHDJJANLINB().SetFloat("CameraFilterPack/Edge_Golden", Distortion);
			OKJOKHGJHGF().SetFloat("ShineEffect", DistortionWave);
			NBPKMLMCHFN.SetFloat("_Value2", Wavy);
			BFGNMFCNDBC().SetFloat("_HdrParams", Fade);
			EPCGJFCCAFH().SetFloat("CameraFilterPack/TV_Rgb", ColoredChange);
			EPCGJFCCAFH().SetFloat("[PlayerBase] Loaded spawner data", ChangeRed);
			OCHJIMJNEMO().SetFloat("_ScreenResolution", ChangeGreen);
			OCHJIMJNEMO().SetFloat("_Bloom5", ChangeBlue);
			OLHDPICFBOF().SetFloat("_ScreenResolution", ColoredSaturate);
			OCHJIMJNEMO().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 538f, 1272f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void FDNONDCGGCG()
	{
		SCShader = Shader.Find("SupportLogger OnCreatedRoom(");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IDIIELPAMCJ()
	{
	}

	private void EGEGNHLODAA()
	{
	}

	private void AEEGKLABFLN()
	{
	}

	private void PKGJJFIFLII()
	{
	}

	private void CNGAJDBOCLJ()
	{
		SCShader = Shader.Find("threshold");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 710f)
			{
				HBJJOCHGOPH = 650f;
			}
			IGKFMCPDNOI().SetFloat("_Value", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("CameraFilterPack/Color_Sepia", Value);
			PDEAHJPOMEF().SetFloat(" [", Speed);
			IGKFMCPDNOI().SetFloat("_BlurredColor", Distortion);
			KBOPGONOCNP().SetFloat("DPADHOR", DistortionWave);
			OKJOKHGJHGF().SetFloat("_BlendTex", Wavy);
			IGKFMCPDNOI().SetFloat("Reconnect() failed. Can only connect while in state 'Disconnected'. Current state: ", Fade);
			HCGJCMDJPGD().SetFloat(" Kb", ColoredChange);
			OKJOKHGJHGF().SetFloat("Editor/", ChangeRed);
			OCHJIMJNEMO().SetFloat("_TimeX", ChangeGreen);
			IGKFMCPDNOI().SetFloat("Horizontal", ChangeBlue);
			DONENAMLFLF().SetFloat("_Value4", ColoredSaturate);
			EPCGJFCCAFH().SetVector("Items", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 305f, 16f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FJNCHGLIEMA()
	{
		SCShader = Shader.Find("LevelConfigButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1314f)
			{
				HBJJOCHGOPH = 1536f;
			}
			PLBEJJIHFPB().SetFloat("OPEN", HBJJOCHGOPH);
			LPCHMEKDCHI().SetFloat("Joystick1Button", Value);
			PDEAHJPOMEF().SetFloat("closed", Speed);
			EPCGJFCCAFH().SetFloat("CameraFilterPack/Colors_Threshold", Distortion);
			PDEAHJPOMEF().SetFloat("id", DistortionWave);
			PLBEJJIHFPB().SetFloat("SingleplayerButton", Wavy);
			KBOPGONOCNP().SetFloat("color", Fade);
			NLFJGMBCICG().SetFloat("LevelEditor/CustomEventEditor-Text", ColoredChange);
			NLFJGMBCICG().SetFloat(": ", ChangeRed);
			LNLKMDPHDCC().SetFloat("_Value2", ChangeGreen);
			LNLKMDPHDCC().SetFloat(" not exist", ChangeBlue);
			EPCGJFCCAFH().SetFloat("The other scroll rect doesnt support scrolling horizontally", ColoredSaturate);
			LPCHMEKDCHI().SetVector("CurrentTimeLabel", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1039f, 1093f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JOPCCCCHNLI()
	{
		SCShader = Shader.Find("#submit");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NFEDLAOPHML()
	{
	}

	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1003f)
			{
				HBJJOCHGOPH = 1352f;
			}
			MFHPKGICPIO().SetFloat("_Parasite", HBJJOCHGOPH);
			BLMPMOIDGMG().SetFloat("_ScreenResolution", Value);
			EHDJJANLINB().SetFloat("Set camera background color", Speed);
			LENEJAGLCNL().SetFloat("SpectatingUserInfo", Distortion);
			LNLKMDPHDCC().SetFloat("_Value", DistortionWave);
			KBOPGONOCNP().SetFloat("_MainTex2", Wavy);
			OKJOKHGJHGF().SetFloat("[PlayerController] ", Fade);
			KEMJNOMIPHN().SetFloat("DPADHOR", ColoredChange);
			IIJMIPBMMBF().SetFloat("_Value11", ChangeRed);
			OKJOKHGJHGF().SetFloat("_History1LumaTex", ChangeGreen);
			BLMPMOIDGMG().SetFloat(",", ChangeBlue);
			OKJOKHGJHGF().SetFloat(" = ", ColoredSaturate);
			MFHPKGICPIO().SetVector("[", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1862f, 82f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1728f)
			{
				HBJJOCHGOPH = 555f;
			}
			MFHPKGICPIO().SetFloat("masterSteamID", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("curScn", Value);
			MFHPKGICPIO().SetFloat("_Colored", Speed);
			PLBEJJIHFPB().SetFloat("SetSatelliteTrailWidth", Distortion);
			NBPKMLMCHFN.SetFloat("buttons", DistortionWave);
			LPCHMEKDCHI().SetFloat("sounds/hit_perfect", Wavy);
			IGKFMCPDNOI().SetFloat("_TimeX", Fade);
			IGKFMCPDNOI().SetFloat("TotalTimeLabel", ColoredChange);
			NLFJGMBCICG().SetFloat("0,2,true,0", ChangeRed);
			NFMGLIKNOOC().SetFloat("Item ", ChangeGreen);
			PDEAHJPOMEF().SetFloat("Current xp: ", ChangeBlue);
			KEMJNOMIPHN().SetFloat("note.4", ColoredSaturate);
			OKJOKHGJHGF().SetVector("input", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 862f, 1208f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 409f)
			{
				HBJJOCHGOPH = 1572f;
			}
			IIJMIPBMMBF().SetFloat("Folk", HBJJOCHGOPH);
			OCHJIMJNEMO().SetFloat("settings.fps", Value);
			LENEJAGLCNL().SetFloat("New SaveGame", Speed);
			OCHJIMJNEMO().SetFloat("AskForPickupItemSpawnTimes", Distortion);
			NFMGLIKNOOC().SetFloat("Sep", DistortionWave);
			IGKFMCPDNOI().SetFloat(" ownership transfered to: ", Wavy);
			LPCHMEKDCHI().SetFloat("Hidden/ScreenSpaceReflection", Fade);
			HKGAONMOBMH().SetFloat("Hello World, is my item a clone? [", ColoredChange);
			NFMGLIKNOOC().SetFloat("CameraFilterPack/TV_Chromatical", ChangeRed);
			EPCGJFCCAFH().SetFloat("challenges.", ChangeGreen);
			NBPKMLMCHFN.SetFloat("_Value2", ChangeBlue);
			NLFJGMBCICG().SetFloat("_Visualize", ColoredSaturate);
			NBPKMLMCHFN.SetVector("EVENT CONFIG [Ctrl+E]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1962f, 490f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material EPCGJFCCAFH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-96);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NFMGLIKNOOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-124);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KEMJNOMIPHN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void ONKDMMJPEMN()
	{
	}

	[SpecialName]
	private Material HKGAONMOBMH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void JOJFHFHOCHO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JAAJECBCCFM()
	{
	}

	private void LCHBFNIPBHB()
	{
	}

	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 668f)
			{
				HBJJOCHGOPH = 1382f;
			}
			NLFJGMBCICG().SetFloat("?", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("DPADVER", Value);
			BFGNMFCNDBC().SetFloat("STICKLHOR", Speed);
			NFMGLIKNOOC().SetFloat("LevelProgressBar", Distortion);
			BFGNMFCNDBC().SetFloat("BitsData", DistortionWave);
			HCGJCMDJPGD().SetFloat("]", Wavy);
			NFMGLIKNOOC().SetFloat("Horizontal", Fade);
			OCHJIMJNEMO().SetFloat("_Value2", ColoredChange);
			PDEAHJPOMEF().SetFloat("settings.cameramovements", ChangeRed);
			OLHDPICFBOF().SetFloat("_DistortionSize", ChangeGreen);
			PDEAHJPOMEF().SetFloat("File not found: {0}", ChangeBlue);
			PDEAHJPOMEF().SetFloat("CameraFilterPack/Drawing_EnhancedComics", ColoredSaturate);
			BFGNMFCNDBC().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 640f, 1748f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GJAJBMGGPFB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BGDONBMDPGM()
	{
	}

	[SpecialName]
	private Material NLFJGMBCICG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void FHGKIOOMMOH()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GCHBGCGBMCK()
	{
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/FX_Drunk");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void POJFHDFJOPE()
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
	private Material LENEJAGLCNL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-68);
		}
		return BJFKDHHMLJH;
	}

	private void HMNLHMLILKD()
	{
	}

	private void ICDBMJKMIKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material IIJMIPBMMBF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material EHDJJANLINB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-66);
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

	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1772f)
			{
				HBJJOCHGOPH = 1425f;
			}
			IGKFMCPDNOI().SetFloat("SpawnObj", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("_Value", Value);
			EPCGJFCCAFH().SetFloat("_Scale", Speed);
			MFHPKGICPIO().SetFloat("file://", Distortion);
			BLMPMOIDGMG().SetFloat("ViewMenu", DistortionWave);
			KBOPGONOCNP().SetFloat("RemoveHighlight", Wavy);
			HCGJCMDJPGD().SetFloat("Joystick1Button", Fade);
			NBPKMLMCHFN.SetFloat("_DotSize", ColoredChange);
			NFMGLIKNOOC().SetFloat("_EmissionColor", ChangeRed);
			MFHPKGICPIO().SetFloat("/", ChangeGreen);
			HKGAONMOBMH().SetFloat("Event Received", ChangeBlue);
			BFGNMFCNDBC().SetFloat("music", ColoredSaturate);
			PDEAHJPOMEF().SetVector("settings_bindings_controller_type", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 933f, 1954f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LPMINJJPDCH()
	{
	}

	private void HIPEHGNBJMN()
	{
		SCShader = Shader.Find("CameraFilterPack/AAA_WaterDropPro");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1137f)
			{
				HBJJOCHGOPH = 1893f;
			}
			OCHJIMJNEMO().SetFloat("value", HBJJOCHGOPH);
			DONENAMLFLF().SetFloat("FindFriends failed to apply the result, as a required value wasn't provided or the friend list length differed from result.", Value);
			EHDJJANLINB().SetFloat("original.tutorial", Speed);
			KBOPGONOCNP().SetFloat("settings.shaders.bloomintencity", Distortion);
			DONENAMLFLF().SetFloat("sfxVolume", DistortionWave);
			BLMPMOIDGMG().SetFloat("Result for ", Wavy);
			KEMJNOMIPHN().SetFloat("[Up-Right-Left]", Fade);
			LNLKMDPHDCC().SetFloat("Overlay", ColoredChange);
			NBPKMLMCHFN.SetFloat(".lastCheckpoint.currentCombo", ChangeRed);
			HCGJCMDJPGD().SetFloat(".completedCount", ChangeGreen);
			LPCHMEKDCHI().SetFloat("id", ChangeBlue);
			NLFJGMBCICG().SetFloat("PowerUp", ColoredSaturate);
			IIJMIPBMMBF().SetVector("The number of objects sent via a PhotonStreamQueue has to be the same each frame", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1840f, 35f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LBIOIEANMGI()
	{
	}

	[SpecialName]
	private Material DONENAMLFLF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)118;
		}
		return BJFKDHHMLJH;
	}

	private void KDMANOEMOCA()
	{
		SCShader = Shader.Find("_Source");
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
			BJFKDHHMLJH.hideFlags = ~HideFlags.HideAndDontSave;
		}
		return BJFKDHHMLJH;
	}

	private void ODGMCJILIHF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KNBJBNDGCIJ()
	{
		SCShader = Shader.Find("Left");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LINKAMEPKGM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1577f)
			{
				HBJJOCHGOPH = 1363f;
			}
			LENEJAGLCNL().SetFloat("Myst", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("FileMenu", Value);
			OLHDPICFBOF().SetFloat("_OcclusionTexture", Speed);
			PLBEJJIHFPB().SetFloat("No Name", Distortion);
			PLBEJJIHFPB().SetFloat("maps.", DistortionWave);
			NLFJGMBCICG().SetFloat("SetPlayerDistance", Wavy);
			HCGJCMDJPGD().SetFloat("#mapby", Fade);
			NFMGLIKNOOC().SetFloat(",", ColoredChange);
			NFMGLIKNOOC().SetFloat("[Right-Left]", ChangeRed);
			OLHDPICFBOF().SetFloat("_BlurredColor", ChangeGreen);
			EHDJJANLINB().SetFloat("_TimeX", ChangeBlue);
			PLBEJJIHFPB().SetFloat("_ScreenResolution", ColoredSaturate);
			OCHJIMJNEMO().SetVector("B", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 411f, 1334f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DLBODOFAJGM()
	{
		SCShader = Shader.Find("settings.shaders");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JDGFCEPDKAJ()
	{
	}

	private void KIMMMCJFMAB()
	{
		SCShader = Shader.Find("Internal LUT");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1882f)
			{
				HBJJOCHGOPH = 1494f;
			}
			LENEJAGLCNL().SetFloat(" not exist", HBJJOCHGOPH);
			HKGAONMOBMH().SetFloat("_Value4", Value);
			EHDJJANLINB().SetFloat("_HdrParams", Speed);
			NFMGLIKNOOC().SetFloat("DifficultyBG", Distortion);
			KEMJNOMIPHN().SetFloat("Yes", DistortionWave);
			EHDJJANLINB().SetFloat("_TimeX", Wavy);
			PLBEJJIHFPB().SetFloat("SetSunColors", Fade);
			OCHJIMJNEMO().SetFloat("Coroutine container not configured... did you forget to call Init?", ColoredChange);
			BFGNMFCNDBC().SetFloat("_Tint", ChangeRed);
			OLHDPICFBOF().SetFloat(".completedMaps", ChangeGreen);
			IGKFMCPDNOI().SetFloat("win", ChangeBlue);
			LPCHMEKDCHI().SetFloat("_Value2", ColoredSaturate);
			IIJMIPBMMBF().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 962f, 582f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
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
			NBPKMLMCHFN.SetFloat("_Value", Value);
			NBPKMLMCHFN.SetFloat("_Speed", Speed);
			NBPKMLMCHFN.SetFloat("_Distortion", Distortion);
			NBPKMLMCHFN.SetFloat("_DistortionWave", DistortionWave);
			NBPKMLMCHFN.SetFloat("_Wavy", Wavy);
			NBPKMLMCHFN.SetFloat("_Fade", Fade);
			NBPKMLMCHFN.SetFloat("_ColoredChange", ColoredChange);
			NBPKMLMCHFN.SetFloat("_ChangeRed", ChangeRed);
			NBPKMLMCHFN.SetFloat("_ChangeGreen", ChangeGreen);
			NBPKMLMCHFN.SetFloat("_ChangeBlue", ChangeBlue);
			NBPKMLMCHFN.SetFloat("_Colored", ColoredSaturate);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1734f)
			{
				HBJJOCHGOPH = 327f;
			}
			LENEJAGLCNL().SetFloat("selector", HBJJOCHGOPH);
			LPCHMEKDCHI().SetFloat("Subscribe: ", Value);
			LNLKMDPHDCC().SetFloat("team", Speed);
			PLBEJJIHFPB().SetFloat("RecieveChatMessage", Distortion);
			IIJMIPBMMBF().SetFloat("EventMenu", DistortionWave);
			LNLKMDPHDCC().SetFloat(" ", Wavy);
			HKGAONMOBMH().SetFloat("CameraFilterPack/FX_Glitch1", Fade);
			LENEJAGLCNL().SetFloat("_Value5", ColoredChange);
			LPCHMEKDCHI().SetFloat("HightScoreMaxPointsText", ChangeRed);
			HCGJCMDJPGD().SetFloat("_Value4", ChangeGreen);
			LENEJAGLCNL().SetFloat(" Maybe GO was destroyed but RPC not cleaned up.", ChangeBlue);
			LENEJAGLCNL().SetFloat("CameraFilterPack/Edge_Golden", ColoredSaturate);
			KEMJNOMIPHN().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 219f, 1259f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LENEJAGLCNL());
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

	[SpecialName]
	private Material LNLKMDPHDCC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)71;
		}
		return BJFKDHHMLJH;
	}

	private void HPNNCNNFMGK()
	{
	}

	[SpecialName]
	private Material HCGJCMDJPGD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	private void CIPKEPDELJB()
	{
		SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material BFGNMFCNDBC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-77);
		}
		return BJFKDHHMLJH;
	}

	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1190f)
			{
				HBJJOCHGOPH = 824f;
			}
			PLBEJJIHFPB().SetFloat("_NumberOfWaves", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("Added GameObject to prefabDictionary: ", Value);
			OLHDPICFBOF().SetFloat("_Max", Speed);
			NLFJGMBCICG().SetFloat("CameraFilterPack/Drawing_Manga_Color", Distortion);
			LNLKMDPHDCC().SetFloat("_History4LumaTex", DistortionWave);
			EPCGJFCCAFH().SetFloat("Exit to Windows", Wavy);
			NBPKMLMCHFN.SetFloat("Joystick1Button3", Fade);
			NBPKMLMCHFN.SetFloat("_Colorisation", ColoredChange);
			NLFJGMBCICG().SetFloat("maps.", ChangeRed);
			PDEAHJPOMEF().SetFloat("inventory.selected.", ChangeGreen);
			BFGNMFCNDBC().SetFloat("_Axis", ChangeBlue);
			NFMGLIKNOOC().SetFloat("OPEN FILE", ColoredSaturate);
			KBOPGONOCNP().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1617f, 1248f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PFNFPINPCMH()
	{
	}

	private void MGMAOBPPOBJ()
	{
		SCShader = Shader.Find("EditMenu");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PHJLHCMCCKE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material BLMPMOIDGMG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)114;
		}
		return BJFKDHHMLJH;
	}
}
