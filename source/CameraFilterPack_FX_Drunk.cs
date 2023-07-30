// CameraFilterPack_FX_Drunk
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/FX/Drunk")]
[ExecuteInEditMode]
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
		SCShader = Shader.Find("_TimeX");
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
			DONENAMLFLF().SetFloat("[PlayerController] ", HBJJOCHGOPH);
			DONENAMLFLF().SetFloat("mapid", Value);
			LPCHMEKDCHI().SetFloat("/", Speed);
			HCGJCMDJPGD().SetFloat("[Right-Left]", Distortion);
			BFGNMFCNDBC().SetFloat("HandsCountSlider", DistortionWave);
			NLFJGMBCICG().SetFloat("-", Wavy);
			LNLKMDPHDCC().SetFloat("_TimeX", Fade);
			KBOPGONOCNP().SetFloat(": ", ColoredChange);
			PDEAHJPOMEF().SetFloat("_TimeX", ChangeRed);
			LNLKMDPHDCC().SetFloat("SetSunMaxSize", ChangeGreen);
			BLMPMOIDGMG().SetFloat("_TimeX", ChangeBlue);
			LENEJAGLCNL().SetFloat("Using constructor for new PingNativeStatic()", ColoredSaturate);
			LNLKMDPHDCC().SetVector("win", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1453f, 140f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
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
			OKJOKHGJHGF().SetFloat("Fill Area", HBJJOCHGOPH);
			LENEJAGLCNL().SetFloat("RarityImage", Value);
			IIJMIPBMMBF().SetFloat("_SecondTex", Speed);
			DONENAMLFLF().SetFloat("Object ID. Case-Sensitive", Distortion);
			EPCGJFCCAFH().SetFloat("/", DistortionWave);
			BFGNMFCNDBC().SetFloat("CameraFilterPack/3D_Scan_Scene", Wavy);
			NBPKMLMCHFN.SetFloat("[PlayerController] ", Fade);
			PLBEJJIHFPB().SetFloat("menu.selectedplaymode", ColoredChange);
			NBPKMLMCHFN.SetFloat("Joystick1Button7", ChangeRed);
			OLHDPICFBOF().SetFloat(" is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package.", ChangeGreen);
			IGKFMCPDNOI().SetFloat("CameraFilterPack/FX_8bits_gb", ChangeBlue);
			HCGJCMDJPGD().SetFloat("FPSToggle", ColoredSaturate);
			OKJOKHGJHGF().SetVector("_ProjectionInv", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1433f, 853f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPCHMEKDCHI());
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
		SCShader = Shader.Find("event");
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
		SCShader = Shader.Find("Creating new item...");
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
		SCShader = Shader.Find("[ItemsHandler] Loading Steam inventory");
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
		SCShader = Shader.Find(" = ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KDMKDEKCELE()
	{
		SCShader = Shader.Find(": ");
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
			HKGAONMOBMH().SetFloat("https://steamcommunity.com/sharedfiles/filedetails/?id=", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("EnableRankedNotificationsToggle", Value);
			PDEAHJPOMEF().SetFloat("_Value", Speed);
			PDEAHJPOMEF().SetFloat("_ScreenResolution", Distortion);
			LPCHMEKDCHI().SetFloat("Please attach component to a Graphical UI component", DistortionWave);
			DONENAMLFLF().SetFloat("_Value2", Wavy);
			DONENAMLFLF().SetFloat("_ExposureAdjustment", Fade);
			HKGAONMOBMH().SetFloat("Fade", ColoredChange);
			LNLKMDPHDCC().SetFloat("settings.arcshitsoundtimedelay", ChangeRed);
			OLHDPICFBOF().SetFloat("_Value4", ChangeGreen);
			BFGNMFCNDBC().SetFloat("_Bloom3", ChangeBlue);
			PLBEJJIHFPB().SetFloat("_ScreenResolution", ColoredSaturate);
			BFGNMFCNDBC().SetVector("_Colored", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 538f, 1272f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EHDJJANLINB());
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
		SCShader = Shader.Find("SupportLogger OnJoinedRoom(");
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
		SCShader = Shader.Find("colorD");
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
			IGKFMCPDNOI().SetFloat("_TimeX", HBJJOCHGOPH);
			EHDJJANLINB().SetFloat("_ScreenResolution", Value);
			NLFJGMBCICG().SetFloat("NameText", Speed);
			OKJOKHGJHGF().SetFloat("_Offsets", Distortion);
			OKJOKHGJHGF().SetFloat("DPADHOR", DistortionWave);
			PDEAHJPOMEF().SetFloat("USE_UV_BASED_REPROJECTION", Wavy);
			EHDJJANLINB().SetFloat(":", Fade);
			OKJOKHGJHGF().SetFloat("#.##", ColoredChange);
			EPCGJFCCAFH().SetFloat(" user's map(s)", ChangeRed);
			MFHPKGICPIO().SetFloat("_ScreenResolution", ChangeGreen);
			OCHJIMJNEMO().SetFloat("Submit", ChangeBlue);
			NLFJGMBCICG().SetFloat("_Value4", ColoredSaturate);
			LNLKMDPHDCC().SetVector("Scrollbar", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 305f, 16f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FJNCHGLIEMA()
	{
		SCShader = Shader.Find("SaveButton");
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
			BFGNMFCNDBC().SetFloat("OxOD.lastPath", HBJJOCHGOPH);
			LENEJAGLCNL().SetFloat("settings_bindings_sec_", Value);
			OLHDPICFBOF().SetFloat("hidden", Speed);
			HKGAONMOBMH().SetFloat("_ScreenResolution", Distortion);
			NLFJGMBCICG().SetFloat("id", DistortionWave);
			BFGNMFCNDBC().SetFloat("SingleplayerButton", Wavy);
			NBPKMLMCHFN.SetFloat("Object ID. Case-Sensitive", Fade);
			PDEAHJPOMEF().SetFloat("steamid", ColoredChange);
			KBOPGONOCNP().SetFloat("[PlayerController] ", ChangeRed);
			IIJMIPBMMBF().SetFloat("_Value", ChangeGreen);
			NFMGLIKNOOC().SetFloat(": ", ChangeBlue);
			PLBEJJIHFPB().SetFloat("RemoveHighlight", ColoredSaturate);
			IGKFMCPDNOI().SetVector("CurrentTimeLabel", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1039f, 1093f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JOPCCCCHNLI()
	{
		SCShader = Shader.Find("OK");
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
			EPCGJFCCAFH().SetFloat("CameraFilterPack/TV_CompressionFX", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("_Value2", Value);
			EHDJJANLINB().SetFloat("float,10", Speed);
			KEMJNOMIPHN().SetFloat("SpectatingUserInfo", Distortion);
			EPCGJFCCAFH().SetFloat("_TimeX", DistortionWave);
			MFHPKGICPIO().SetFloat("_MainTex2", Wavy);
			IGKFMCPDNOI().SetFloat(" not exist", Fade);
			EPCGJFCCAFH().SetFloat("DPADHOR", ColoredChange);
			HCGJCMDJPGD().SetFloat("_Value10", ChangeRed);
			KEMJNOMIPHN().SetFloat("_VelocityTex", ChangeGreen);
			NFMGLIKNOOC().SetFloat("SpawnObj", ChangeBlue);
			IGKFMCPDNOI().SetFloat(": ", ColoredSaturate);
			OCHJIMJNEMO().SetVector("[", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1862f, 82f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BLMPMOIDGMG());
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
			OLHDPICFBOF().SetFloat("masterSteamID", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("Parameter levelId can't be null!", Value);
			LENEJAGLCNL().SetFloat("_Colored", Speed);
			NLFJGMBCICG().SetFloat("Set satellite trail length in seconds", Distortion);
			LPCHMEKDCHI().SetFloat("#{0:00} '{1}'{2} {3}", DistortionWave);
			PDEAHJPOMEF().SetFloat("skin.hit_wrong", Wavy);
			EPCGJFCCAFH().SetFloat("_TimeX", Fade);
			IIJMIPBMMBF().SetFloat("0.00", ColoredChange);
			PLBEJJIHFPB().SetFloat("0,2,true,0", ChangeRed);
			OKJOKHGJHGF().SetFloat("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception", ChangeGreen);
			NBPKMLMCHFN.SetFloat("-help", ChangeBlue);
			OCHJIMJNEMO().SetFloat("note.0", ColoredSaturate);
			OCHJIMJNEMO().SetVector("input", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 862f, 1208f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
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
			LPCHMEKDCHI().SetFloat("Folk", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("settings.fps", Value);
			OKJOKHGJHGF().SetFloat("The other scroll rect doesnt support scrolling vertically", Speed);
			KBOPGONOCNP().SetFloat("RespawnAfter", Distortion);
			LNLKMDPHDCC().SetFloat("Jul", DistortionWave);
			HKGAONMOBMH().SetFloat(". MasterClient: ", Wavy);
			MFHPKGICPIO().SetFloat("_History3Weight", Fade);
			NBPKMLMCHFN.SetFloat("You need to have a Graphic control (such as an Image) for the list [", ColoredChange);
			LNLKMDPHDCC().SetFloat("_MainTex2", ChangeRed);
			PDEAHJPOMEF().SetFloat("PlayMapsSeriesGoal", ChangeGreen);
			KBOPGONOCNP().SetFloat("_Value2", ChangeBlue);
			OCHJIMJNEMO().SetFloat("_Visualize", ColoredSaturate);
			EHDJJANLINB().SetVector("0.00", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1962f, 490f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
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
			IIJMIPBMMBF().SetFloat("Down", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("DPADVER", Value);
			LNLKMDPHDCC().SetFloat("Mouse Y", Speed);
			LENEJAGLCNL().SetFloat("sprite", Distortion);
			OCHJIMJNEMO().SetFloat("BitsData", DistortionWave);
			KEMJNOMIPHN().SetFloat("Is it practically possible?", Wavy);
			DONENAMLFLF().SetFloat(") but there is no recycle bin setup for it", Fade);
			LNLKMDPHDCC().SetFloat("_Value2", ColoredChange);
			NBPKMLMCHFN.SetFloat("settings.hitvariation", ChangeRed);
			OCHJIMJNEMO().SetFloat("_DistortionSize", ChangeGreen);
			HCGJCMDJPGD().SetFloat("Reading preview file failed! Make sure JSON file is filled properly and/or file exists: \"{0}\"", ChangeBlue);
			OLHDPICFBOF().SetFloat("_ScreenResolution", ColoredSaturate);
			NBPKMLMCHFN.SetVector("CameraFilterPack/Blur_Noise", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 640f, 1748f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OCHJIMJNEMO());
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
		SCShader = Shader.Find("_Value4");
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
			KBOPGONOCNP().SetFloat("SetPlayerDistance", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("CameraFilterPack/TV_WideScreenHV", Value);
			IIJMIPBMMBF().SetFloat(" cannot be used as a 3D LUT.", Speed);
			LPCHMEKDCHI().SetFloat("[ResourcesManager] Load image error: ", Distortion);
			EHDJJANLINB().SetFloat("ViewMenu", DistortionWave);
			PLBEJJIHFPB().SetFloat("]", Wavy);
			PDEAHJPOMEF().SetFloat("DPADHOR", Fade);
			HCGJCMDJPGD().SetFloat("_DotSize", ColoredChange);
			LENEJAGLCNL().SetFloat("settings.crosshairopacity", ChangeRed);
			NBPKMLMCHFN.SetFloat("/", ChangeGreen);
			BFGNMFCNDBC().SetFloat("RootCanvas", ChangeBlue);
			NFMGLIKNOOC().SetFloat("/music", ColoredSaturate);
			PLBEJJIHFPB().SetVector("settings_bindings_controller_type", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 933f, 1954f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
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
		SCShader = Shader.Find("CameraFilterPack_WaterDrop");
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
			BLMPMOIDGMG().SetFloat("Object ID. Case-Sensitive", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("JoinRandom failed: {0}.", Value);
			MFHPKGICPIO().SetFloat("OnMastedChangeScene", Speed);
			EHDJJANLINB().SetFloat("settings.shaders", Distortion);
			BFGNMFCNDBC().SetFloat("[Sound Manager] Audio clip is null, cannot play sound", DistortionWave);
			OCHJIMJNEMO().SetFloat("Bad parameters for getbool! Use <key> <value>", Wavy);
			EPCGJFCCAFH().SetFloat("[Up-Right-Left]", Fade);
			IIJMIPBMMBF().SetFloat("Text", ColoredChange);
			HCGJCMDJPGD().SetFloat(".lastCheckpoint.penaltyScore", ChangeRed);
			HCGJCMDJPGD().SetFloat(".completedMaps", ChangeGreen);
			MFHPKGICPIO().SetFloat("Set Particles Gravity", ChangeBlue);
			OCHJIMJNEMO().SetFloat("[", ColoredSaturate);
			OCHJIMJNEMO().SetVector("Health Stats", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1840f, 35f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
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
		SCShader = Shader.Find("offsets");
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
		SCShader = Shader.Find("Right");
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
			OKJOKHGJHGF().SetFloat("Drop_With_Obj", HBJJOCHGOPH);
			EHDJJANLINB().SetFloat("SaveMapButton", Value);
			KBOPGONOCNP().SetFloat("_BlurVector", Speed);
			LENEJAGLCNL().SetFloat("No Description", Distortion);
			MFHPKGICPIO().SetFloat("_EmissionColor", DistortionWave);
			IIJMIPBMMBF().SetFloat("SetPlayerDistance", Wavy);
			PDEAHJPOMEF().SetFloat("MapperNameText", Fade);
			MFHPKGICPIO().SetFloat("/512px-512px.png", ColoredChange);
			OCHJIMJNEMO().SetFloat("[Right-Left]", ChangeRed);
			LPCHMEKDCHI().SetFloat("_Offsets", ChangeGreen);
			KBOPGONOCNP().SetFloat("_TimeX", ChangeBlue);
			KEMJNOMIPHN().SetFloat("_Value4", ColoredSaturate);
			MFHPKGICPIO().SetVector("A", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 411f, 1334f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DLBODOFAJGM()
	{
		SCShader = Shader.Find("settings.enablerankingnotifications");
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
		SCShader = Shader.Find("_CurrentMipLevel");
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
			IGKFMCPDNOI().SetFloat(": ", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("_Value4", Value);
			KBOPGONOCNP().SetFloat("_ExposureAdjustment", Speed);
			NFMGLIKNOOC().SetFloat("DifficultyBG", Distortion);
			IGKFMCPDNOI().SetFloat("skin.", DistortionWave);
			LENEJAGLCNL().SetFloat("_TimeX", Wavy);
			OCHJIMJNEMO().SetFloat("SetPosition", Fade);
			IGKFMCPDNOI().SetFloat("SSAARenderTargetCamera", ColoredChange);
			MFHPKGICPIO().SetFloat("_PosY", ChangeRed);
			KBOPGONOCNP().SetFloat(",", ChangeGreen);
			HCGJCMDJPGD().SetFloat("finished", ChangeBlue);
			BFGNMFCNDBC().SetFloat("_Value1", ColoredSaturate);
			DONENAMLFLF().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 962f, 582f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			BFGNMFCNDBC().SetFloat("cancel", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("<command>", Value);
			NFMGLIKNOOC().SetFloat("score", Speed);
			OCHJIMJNEMO().SetFloat("RecieveChatMessage", Distortion);
			PDEAHJPOMEF().SetFloat("EventMenu", DistortionWave);
			HCGJCMDJPGD().SetFloat("th", Wavy);
			BLMPMOIDGMG().SetFloat("_ScreenResolution", Fade);
			PDEAHJPOMEF().SetFloat("_Value4", ColoredChange);
			PDEAHJPOMEF().SetFloat("HightScoreMaxPointsText", ChangeRed);
			OLHDPICFBOF().SetFloat("_Value3", ChangeGreen);
			BLMPMOIDGMG().SetFloat(" Remote called.", ChangeBlue);
			PDEAHJPOMEF().SetFloat("_ScreenResolution", ColoredSaturate);
			HKGAONMOBMH().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 219f, 1259f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			HCGJCMDJPGD().SetFloat("_WaveIntensity", HBJJOCHGOPH);
			OCHJIMJNEMO().SetFloat("/Saved Games/", Value);
			PLBEJJIHFPB().SetFloat("_HardBlend", Speed);
			EHDJJANLINB().SetFloat("_DotSize", Distortion);
			HKGAONMOBMH().SetFloat("_History2LumaTex", DistortionWave);
			IGKFMCPDNOI().SetFloat("/Saved Games/", Wavy);
			HKGAONMOBMH().SetFloat("Joystick1Button2", Fade);
			PDEAHJPOMEF().SetFloat("_TimeX", ColoredChange);
			IIJMIPBMMBF().SetFloat("_EmissionColor", ChangeRed);
			KEMJNOMIPHN().SetFloat("inventory.selected.", ChangeGreen);
			LNLKMDPHDCC().SetFloat("_Axis", ChangeBlue);
			LNLKMDPHDCC().SetFloat("[FileSelector] Starting file dialog", ColoredSaturate);
			KBOPGONOCNP().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1617f, 1248f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
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
		SCShader = Shader.Find("[LevelEditorScene] Print Audio Wave: Done");
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
