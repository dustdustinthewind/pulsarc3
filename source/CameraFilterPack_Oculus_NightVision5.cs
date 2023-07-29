// CameraFilterPack_Oculus_NightVision5
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Night Vision/Night Vision 5")]
[ExecuteInEditMode]
public class CameraFilterPack_Oculus_NightVision5 : MonoBehaviour
{
	private string ELOFMLPCCEA = "CameraFilterPack/Oculus_NightVision5";

	public Shader SCShader;

	[Range(0f, 1f)]
	public float FadeFX = 1f;

	[Range(0f, 1f)]
	public float _Size = 0.37f;

	[Range(0f, 1f)]
	public float _Smooth = 0.15f;

	[Range(0f, 1f)]
	public float _Dist = 0.285f;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	private float[] PLKFKNHPEHE;

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

	private void ODMPMJPALID()
	{
		MIPGPMKJELI();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material MNLKBFFKHIE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideAndDontSave;
		}
		return BJFKDHHMLJH;
	}

	private void OnValidate()
	{
		MIPGPMKJELI();
	}

	private void AEMGPJDJGBJ()
	{
		MIPGPMKJELI();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DDBOODLPCAM()
	{
	}

	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 644f)
			{
				HBJJOCHGOPH = 1602f;
			}
			CECICEGFHKL().SetFloat("_BlurTex", HBJJOCHGOPH);
			HEHKGPKLAKK().SetFloat("</color>", PLKFKNHPEHE[1] / 480f);
			HEHKGPKLAKK().SetFloat("_EmissionColor", PLKFKNHPEHE[0] / 463f);
			HEHKGPKLAKK().SetFloat(".", PLKFKNHPEHE[1] / 137f);
			CECICEGFHKL().SetFloat("Preparing content", PLKFKNHPEHE[0] / 624f);
			DOMEEFLPEPJ().SetFloat("GlassColor", PLKFKNHPEHE[1] / 793f);
			MHBAIEKFBIJ().SetFloat("in seconds. 0 - forever", PLKFKNHPEHE[2] / 115f);
			OCMBHMLNCEK().SetFloat("/../", PLKFKNHPEHE[3] / 273f);
			CFEDGDGBCHE().SetFloat(" not exist", PLKFKNHPEHE[4] / 1504f);
			KJMECMIGJJA().SetFloat("_TimeX", PLKFKNHPEHE[1] / 1893f);
			KJMECMIGJJA().SetFloat("_LightIntensity", PLKFKNHPEHE[-75] / 439f);
			MHBAIEKFBIJ().SetFloat("SpectateButton", PLKFKNHPEHE[-16] / 1410f);
			MCDGIILBNIF().SetFloat("Vertical", PLKFKNHPEHE[53] / 1143f);
			DOMEEFLPEPJ().SetFloat("SpawnObj", FadeFX);
			NMDBCDFPGOK().SetFloat("BitsData", _Size);
			HEHKGPKLAKK().SetFloat("_Value2", _Dist);
			LDNADDJMIPK().SetFloat("#alreadystarted", _Smooth);
			NBPKMLMCHFN.SetVector("_Offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 828f, 754f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MHBAIEKFBIJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KCDBBPKIFNJ()
	{
	}

	private void FJHFOBHJEHL()
	{
	}

	private void ELJEHKEHFLM()
	{
		NBOEFDOKHLE();
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
			NBPKMLMCHFN.SetFloat("_Red_R", PLKFKNHPEHE[0] / 100f);
			NBPKMLMCHFN.SetFloat("_Red_G", PLKFKNHPEHE[1] / 100f);
			NBPKMLMCHFN.SetFloat("_Red_B", PLKFKNHPEHE[2] / 100f);
			NBPKMLMCHFN.SetFloat("_Green_R", PLKFKNHPEHE[3] / 100f);
			NBPKMLMCHFN.SetFloat("_Green_G", PLKFKNHPEHE[4] / 100f);
			NBPKMLMCHFN.SetFloat("_Green_B", PLKFKNHPEHE[5] / 100f);
			NBPKMLMCHFN.SetFloat("_Blue_R", PLKFKNHPEHE[6] / 100f);
			NBPKMLMCHFN.SetFloat("_Blue_G", PLKFKNHPEHE[7] / 100f);
			NBPKMLMCHFN.SetFloat("_Blue_B", PLKFKNHPEHE[8] / 100f);
			NBPKMLMCHFN.SetFloat("_Red_C", PLKFKNHPEHE[9] / 100f);
			NBPKMLMCHFN.SetFloat("_Green_C", PLKFKNHPEHE[10] / 100f);
			NBPKMLMCHFN.SetFloat("_Blue_C", PLKFKNHPEHE[11] / 100f);
			NBPKMLMCHFN.SetFloat("_FadeFX", FadeFX);
			NBPKMLMCHFN.SetFloat("_Size", _Size);
			NBPKMLMCHFN.SetFloat("_Dist", _Dist);
			NBPKMLMCHFN.SetFloat("_Smooth", _Smooth);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BKIGIIINEDH()
	{
		FALHNNJBOEM();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NPLCENPNJBM()
	{
		GKNPHGOHOAE();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FALHNNJBOEM()
	{
		float[] array = new float[-37];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void PBKELEKDBIC()
	{
		float[] array = new float[-50];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 122f)
			{
				HBJJOCHGOPH = 1739f;
			}
			MCDGIILBNIF().SetFloat("CameraFilterPack/TV_Chromatical2", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat(".played", PLKFKNHPEHE[0] / 1338f);
			HEHKGPKLAKK().SetFloat("type", PLKFKNHPEHE[0] / 447f);
			CFEDGDGBCHE().SetFloat("_BlurredColor", PLKFKNHPEHE[5] / 1160f);
			KJMECMIGJJA().SetFloat(" not exist", PLKFKNHPEHE[5] / 1163f);
			HEHKGPKLAKK().SetFloat("_Value6", PLKFKNHPEHE[8] / 648f);
			MCDGIILBNIF().SetFloat("</color>", PLKFKNHPEHE[2] / 832f);
			NJDIODJNGGA().SetFloat("Fade", PLKFKNHPEHE[6] / 1476f);
			KLKILLCHJHO().SetFloat("1", PLKFKNHPEHE[8] / 691f);
			DOMEEFLPEPJ().SetFloat("_TimeX", PLKFKNHPEHE[6] / 220f);
			MCDGIILBNIF().SetFloat("GlassDistortion", PLKFKNHPEHE[18] / 1095f);
			CFEDGDGBCHE().SetFloat("a", PLKFKNHPEHE[-37] / 1193f);
			DOMEEFLPEPJ().SetFloat("Data/Skins/", PLKFKNHPEHE[-15] / 1637f);
			KOHGPKOFEJO().SetFloat("Unsupported type: ", FadeFX);
			KOHGPKOFEJO().SetFloat("CameraFilterPack/Distortion_FishEye", _Size);
			DIOAAHJDMLK().SetFloat("_ColorRGB", _Dist);
			ABHDNGIHBKE().SetFloat("SlidingArea", _Smooth);
			HNFFHCLNBDN().SetVector("#close", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1369f, 943f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material CFEDGDGBCHE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-112);
		}
		return BJFKDHHMLJH;
	}

	private void DHEHFFJDFCD()
	{
		LGHFFANDDCM();
	}

	[SpecialName]
	private Material DIOAAHJDMLK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)104;
		}
		return BJFKDHHMLJH;
	}

	private void MNHCBAKPBCF()
	{
		MPJAFNJLBEF();
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DGEAFNJFHHA()
	{
		IKNKJMNFFOG();
	}

	private void KKDDHFJOAAD()
	{
		FALHNNJBOEM();
	}

	private void CBIBDOIBJAI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KOJKBFDNGDK()
	{
		PEKADICCGAG();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DIPDEHOOBPG()
	{
		KNLDBHHKFPF();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NNBCLMJGFEN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DFENCIHAADO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NBOEFDOKHLE()
	{
		float[] array = new float[-64];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	[SpecialName]
	private Material KOHGPKOFEJO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return BJFKDHHMLJH;
	}

	private void IPJFFIDBPFE()
	{
		NBOEFDOKHLE();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PPBFGGFIDKP()
	{
		float[] array = new float[-99];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void MDNHCLKNCLE()
	{
		PPBFGGFIDKP();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OEGEBCOIAHN()
	{
		MGGFMCIGOAF();
	}

	[SpecialName]
	private Material NJDIODJNGGA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-95);
		}
		return BJFKDHHMLJH;
	}

	private void JAFOCEDILNK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BJOHDLNDFAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1567f)
			{
				HBJJOCHGOPH = 511f;
			}
			CFEDGDGBCHE().SetFloat("Error: you cannot read this stream that you are writing!", HBJJOCHGOPH);
			LDNADDJMIPK().SetFloat("maps.", PLKFKNHPEHE[1] / 759f);
			NJDIODJNGGA().SetFloat(" GameServer:", PLKFKNHPEHE[0] / 341f);
			KLKILLCHJHO().SetFloat("CameraFilterPack/Blend2Camera_Screen", PLKFKNHPEHE[1] / 1295f);
			OCMBHMLNCEK().SetFloat("NetworkCanvas", PLKFKNHPEHE[7] / 1798f);
			NJDIODJNGGA().SetFloat("_Fade", PLKFKNHPEHE[3] / 713f);
			NJDIODJNGGA().SetFloat("[MapsStats] Hash: ", PLKFKNHPEHE[1] / 829f);
			NBPKMLMCHFN.SetFloat("The other scroll rect doesnt support scrolling horizontally", PLKFKNHPEHE[8] / 1823f);
			ABHDNGIHBKE().SetFloat("_ScreenResolution", PLKFKNHPEHE[6] / 1319f);
			DOMEEFLPEPJ().SetFloat("OnPickedUp", PLKFKNHPEHE[8] / 590f);
			NMDBCDFPGOK().SetFloat("mapselector.lastSearch", PLKFKNHPEHE[-51] / 1495f);
			HEHKGPKLAKK().SetFloat("Bad parameters for setbool! Use <key> <value>", PLKFKNHPEHE[-20] / 509f);
			MHBAIEKFBIJ().SetFloat("bad", PLKFKNHPEHE[-2] / 1888f);
			HEHKGPKLAKK().SetFloat("_ScreenResolution", FadeFX);
			MNLKBFFKHIE().SetFloat("Tab2Content", _Size);
			LDNADDJMIPK().SetFloat("offsets", _Dist);
			MHBAIEKFBIJ().SetFloat("_NoiseTex", _Smooth);
			CECICEGFHKL().SetVector("max. lives color", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1996f, 129f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NMDBCDFPGOK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BEKMLIFILFP()
	{
		KNLDBHHKFPF();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material KLKILLCHJHO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void Start()
	{
		MIPGPMKJELI();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LOMDIOLNFHI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MPHAMHBNCJF()
	{
		GDPAIILEEFC();
	}

	private void MODENHKMKOC()
	{
		NBOEFDOKHLE();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 819f)
			{
				HBJJOCHGOPH = 547f;
			}
			NBPKMLMCHFN.SetFloat("G:", HBJJOCHGOPH);
			HNFFHCLNBDN().SetFloat("DPADHOR", PLKFKNHPEHE[0] / 563f);
			HEHKGPKLAKK().SetFloat("System.Boolean", PLKFKNHPEHE[0] / 676f);
			CFEDGDGBCHE().SetFloat("Updated!", PLKFKNHPEHE[3] / 1221f);
			LDNADDJMIPK().SetFloat("OK", PLKFKNHPEHE[1] / 953f);
			CFEDGDGBCHE().SetFloat("Stream did not contain properly formatted byte array", PLKFKNHPEHE[0] / 541f);
			KOHGPKOFEJO().SetFloat("FPSToggle", PLKFKNHPEHE[2] / 74f);
			NMDBCDFPGOK().SetFloat("ItemTemplate", PLKFKNHPEHE[1] / 1624f);
			MHBAIEKFBIJ().SetFloat("_Alpha", PLKFKNHPEHE[2] / 720f);
			KLKILLCHJHO().SetFloat("maps.", PLKFKNHPEHE[6] / 937f);
			MHBAIEKFBIJ().SetFloat("PlayMusic", PLKFKNHPEHE[48] / 255f);
			DKNJGHFLAIF().SetFloat("#startofflinemessage", PLKFKNHPEHE[58] / 858f);
			ABHDNGIHBKE().SetFloat("Failed!", PLKFKNHPEHE[48] / 948f);
			MHBAIEKFBIJ().SetFloat("_color", FadeFX);
			NBPKMLMCHFN.SetFloat("MenuScene", _Size);
			ABHDNGIHBKE().SetFloat("_PositionY", _Dist);
			NMDBCDFPGOK().SetFloat("\" gets executed locally only, if at all.", _Smooth);
			KLKILLCHJHO().SetVector(" : ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 432f, 1073f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EGEGNHLODAA()
	{
	}

	private void DLIJFEGIEKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1332f)
			{
				HBJJOCHGOPH = 1691f;
			}
			NBPKMLMCHFN.SetFloat("_TimeX", HBJJOCHGOPH);
			NMDBCDFPGOK().SetFloat("_AlphaHexa", PLKFKNHPEHE[0] / 1617f);
			OCMBHMLNCEK().SetFloat("shader.none", PLKFKNHPEHE[0] / 1592f);
			LDNADDJMIPK().SetFloat("CameraFilterPack/Vision_Blood_Fast", PLKFKNHPEHE[7] / 904f);
			MCDGIILBNIF().SetFloat("Joystick1Button5", PLKFKNHPEHE[5] / 263f);
			KJMECMIGJJA().SetFloat("[DiscordController] Join request {0}#{1}: {2}", PLKFKNHPEHE[8] / 721f);
			KOHGPKOFEJO().SetFloat("_ScreenResolution", PLKFKNHPEHE[4] / 1793f);
			LDNADDJMIPK().SetFloat("_ScreenResolution", PLKFKNHPEHE[2] / 1771f);
			MNLKBFFKHIE().SetFloat("_Amount", PLKFKNHPEHE[1] / 946f);
			KOHGPKOFEJO().SetFloat("_NeutralTonemapperParams1", PLKFKNHPEHE[1] / 426f);
			HEHKGPKLAKK().SetFloat("_Value", PLKFKNHPEHE[109] / 220f);
			CECICEGFHKL().SetFloat("_EmissionGain", PLKFKNHPEHE[-118] / 639f);
			HNFFHCLNBDN().SetFloat("_MaxBlurRadius", PLKFKNHPEHE[-6] / 866f);
			CECICEGFHKL().SetFloat("float,2", FadeFX);
			CECICEGFHKL().SetFloat("sfxVolume", _Size);
			NBPKMLMCHFN.SetFloat("1159514800", _Dist);
			HNFFHCLNBDN().SetFloat("_TileMaxOffs", _Smooth);
			LDNADDJMIPK().SetVector("Winter2020", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 420f, 1266f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HNFFHCLNBDN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void FGNFILLNPJK()
	{
	}

	private void LONLHFLPEJD()
	{
		NBOEFDOKHLE();
	}

	private void MIPGPMKJELI()
	{
		PLKFKNHPEHE = new float[12]
		{
			200f, -200f, -200f, 195f, 4f, -160f, 200f, -200f, -200f, -200f,
			10f, -200f
		};
	}

	private void IMEPOCMPHDL()
	{
		PPBFGGFIDKP();
	}

	private void CPAJLKHMOJB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BOPKKCAFODF()
	{
		IKNKJMNFFOG();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AGFGKIBHCBE()
	{
		IAIAGCGJGHI();
	}

	private void JILOMOBDPIA()
	{
		IAIAGCGJGHI();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DCGFEIBKOBB()
	{
		JGMPDINHNKD();
	}

	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 168f)
			{
				HBJJOCHGOPH = 380f;
			}
			KOHGPKOFEJO().SetFloat("Set particles size", HBJJOCHGOPH);
			MNLKBFFKHIE().SetFloat("Right", PLKFKNHPEHE[1] / 599f);
			KLKILLCHJHO().SetFloat("Chat", PLKFKNHPEHE[0] / 391f);
			CECICEGFHKL().SetFloat("LevelEditor/CustomEventEditor-", PLKFKNHPEHE[6] / 1870f);
			DKNJGHFLAIF().SetFloat("UpdateDownloadingProgress", PLKFKNHPEHE[1] / 1524f);
			DIOAAHJDMLK().SetFloat("maps.", PLKFKNHPEHE[8] / 213f);
			CECICEGFHKL().SetFloat("_DotSize", PLKFKNHPEHE[8] / 1768f);
			HNFFHCLNBDN().SetFloat("ConnectToMaster() failed. Can only connect while in state 'Disconnected'. Current state: ", PLKFKNHPEHE[8] / 484f);
			NBPKMLMCHFN.SetFloat("_TimeX", PLKFKNHPEHE[0] / 461f);
			LDNADDJMIPK().SetFloat("SetScale", PLKFKNHPEHE[3] / 1839f);
			HNFFHCLNBDN().SetFloat("_Saturation", PLKFKNHPEHE[-48] / 1019f);
			DOMEEFLPEPJ().SetFloat("ItemsUploader", PLKFKNHPEHE[-125] / 1272f);
			NMDBCDFPGOK().SetFloat("_CenterX", PLKFKNHPEHE[60] / 531f);
			OCMBHMLNCEK().SetFloat("_Value", FadeFX);
			NMDBCDFPGOK().SetFloat("_FgCocMask", _Size);
			OCMBHMLNCEK().SetFloat("STICKRVER", _Dist);
			DOMEEFLPEPJ().SetFloat("_Value2", _Smooth);
			NBPKMLMCHFN.SetVector("_FarCorner", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 212f, 277f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOMEEFLPEPJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EFNBMCKBNAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1221f)
			{
				HBJJOCHGOPH = 1805f;
			}
			ABHDNGIHBKE().SetFloat("CameraFilterPack/Vision_Tunnel", HBJJOCHGOPH);
			NJDIODJNGGA().SetFloat("loadscene", PLKFKNHPEHE[0] / 1839f);
			NBPKMLMCHFN.SetFloat("settings_bindings_", PLKFKNHPEHE[1] / 684f);
			NJDIODJNGGA().SetFloat("_StretchWidth", PLKFKNHPEHE[1] / 284f);
			CFEDGDGBCHE().SetFloat("_Bullet_8", PLKFKNHPEHE[4] / 407f);
			CECICEGFHKL().SetFloat("EnableRankedNotificationsToggle", PLKFKNHPEHE[4] / 1445f);
			MNLKBFFKHIE().SetFloat("EnableRankedNotificationsToggle", PLKFKNHPEHE[8] / 870f);
			NJDIODJNGGA().SetFloat("_Fade", PLKFKNHPEHE[4] / 283f);
			KOHGPKOFEJO().SetFloat("_Brightness", PLKFKNHPEHE[5] / 1908f);
			MNLKBFFKHIE().SetFloat("EnvironmentSlider", PLKFKNHPEHE[4] / 231f);
			DOMEEFLPEPJ().SetFloat("note.3", PLKFKNHPEHE[39] / 1125f);
			HEHKGPKLAKK().SetFloat("BitsData", PLKFKNHPEHE[12] / 1536f);
			KLKILLCHJHO().SetFloat("CameraFilterPack_OldFilm1", PLKFKNHPEHE[42] / 1831f);
			OCMBHMLNCEK().SetFloat("_TimeX", FadeFX);
			CFEDGDGBCHE().SetFloat("#tryagain", _Size);
			DIOAAHJDMLK().SetFloat("editor.", _Dist);
			LDNADDJMIPK().SetFloat("_TimeX", _Smooth);
			DOMEEFLPEPJ().SetVector("00", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1993f, 822f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material KJMECMIGJJA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-66);
		}
		return BJFKDHHMLJH;
	}

	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 200f)
			{
				HBJJOCHGOPH = 1246f;
			}
			HNFFHCLNBDN().SetFloat(" failed in a server-side plugin. Check the configuration in the Dashboard. Message from server-plugin: ", HBJJOCHGOPH);
			CECICEGFHKL().SetFloat("\\", PLKFKNHPEHE[0] / 1935f);
			NJDIODJNGGA().SetFloat("[ResourcesManager] Load text error: not found", PLKFKNHPEHE[0] / 1642f);
			KOHGPKOFEJO().SetFloat("Forward", PLKFKNHPEHE[0] / 652f);
			NMDBCDFPGOK().SetFloat("/../", PLKFKNHPEHE[4] / 1975f);
			KOHGPKOFEJO().SetFloat("Left ", PLKFKNHPEHE[6] / 1184f);
			OCMBHMLNCEK().SetFloat(" in SaveLoadMenu.prefabDictionary!", PLKFKNHPEHE[5] / 1580f);
			OCMBHMLNCEK().SetFloat("CompletedLevel", PLKFKNHPEHE[8] / 1294f);
			ABHDNGIHBKE().SetFloat("steamid", PLKFKNHPEHE[5] / 1629f);
			KLKILLCHJHO().SetFloat("ConnectToBestCloudServer() failed. Can only connect while in state 'Disconnected'. Current state: ", PLKFKNHPEHE[0] / 530f);
			MNLKBFFKHIE().SetFloat("#ok", PLKFKNHPEHE[94] / 634f);
			ABHDNGIHBKE().SetFloat("/", PLKFKNHPEHE[126] / 1055f);
			KLKILLCHJHO().SetFloat("#no", PLKFKNHPEHE[52] / 1319f);
			MNLKBFFKHIE().SetFloat("stretchWidth", FadeFX);
			MCDGIILBNIF().SetFloat("/", _Size);
			LDNADDJMIPK().SetFloat(",", _Dist);
			MHBAIEKFBIJ().SetFloat("Joystick1Button1", _Smooth);
			ABHDNGIHBKE().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1917f, 1986f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JONGNKNLLND()
	{
		JGMPDINHNKD();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AGMHAIFOAAO()
	{
		float[] array = new float[-81];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void FDPOFMCFBMF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GFACKFCEIBC()
	{
	}

	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 283f)
			{
				HBJJOCHGOPH = 805f;
			}
			MHBAIEKFBIJ().SetFloat("CameraFilterPack/Blend2Camera_Luminosity", HBJJOCHGOPH);
			DIOAAHJDMLK().SetFloat("settings.cameramovements", PLKFKNHPEHE[0] / 1410f);
			NJDIODJNGGA().SetFloat("_TimeX", PLKFKNHPEHE[1] / 771f);
			DOMEEFLPEPJ().SetFloat("CameraFilterPack/Blend2Camera_Divide", PLKFKNHPEHE[7] / 572f);
			NBPKMLMCHFN.SetFloat("{0}", PLKFKNHPEHE[0] / 572f);
			NJDIODJNGGA().SetFloat("setAF", PLKFKNHPEHE[6] / 1603f);
			HNFFHCLNBDN().SetFloat("maps.", PLKFKNHPEHE[8] / 1658f);
			KLKILLCHJHO().SetFloat("0", PLKFKNHPEHE[7] / 1461f);
			CFEDGDGBCHE().SetFloat(">", PLKFKNHPEHE[7] / 1926f);
			NMDBCDFPGOK().SetFloat("CameraFilterPack/FX_Glitch3", PLKFKNHPEHE[3] / 95f);
			CFEDGDGBCHE().SetFloat("No valid adaptive tonemapper type found!", PLKFKNHPEHE[107] / 91f);
			CECICEGFHKL().SetFloat("HandleEventLeave for player ID: ", PLKFKNHPEHE[-112] / 1720f);
			CFEDGDGBCHE().SetFloat("CameraFilterPack_Broken_Screen1", PLKFKNHPEHE[41] / 963f);
			HEHKGPKLAKK().SetFloat("Join failed on GameServer. Changing back to MasterServer. Msg: ", FadeFX);
			HNFFHCLNBDN().SetFloat("true", _Size);
			CECICEGFHKL().SetFloat("_ScreenResolution", _Dist);
			HEHKGPKLAKK().SetFloat("EnableRankingToggle", _Smooth);
			ABHDNGIHBKE().SetVector("CameraFilterPack_TV_BrokenGlass_2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1678f, 1052f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JHANGPCOCIG()
	{
		IKNKJMNFFOG();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EALEEMOPJNO()
	{
		float[] array = new float[-62];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void KOFOBHNODCH()
	{
		float[] array = new float[125];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void HIFLPHLGLFG()
	{
	}

	private void DHNGNHGDPLM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DPFOEBCADNP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PAAMLLNPGBD()
	{
		FALHNNJBOEM();
	}

	private void MKFFLJGJMLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1660f)
			{
				HBJJOCHGOPH = 1040f;
			}
			LDNADDJMIPK().SetFloat("_HSV", HBJJOCHGOPH);
			OCMBHMLNCEK().SetFloat("caret", PLKFKNHPEHE[0] / 1739f);
			CFEDGDGBCHE().SetFloat("settings.fps", PLKFKNHPEHE[1] / 1617f);
			HEHKGPKLAKK().SetFloat("_TimeX", PLKFKNHPEHE[1] / 277f);
			KLKILLCHJHO().SetFloat("_Luminance", PLKFKNHPEHE[4] / 1628f);
			DKNJGHFLAIF().SetFloat("_Value", PLKFKNHPEHE[5] / 1425f);
			DIOAAHJDMLK().SetFloat("OnAwakeRPC", PLKFKNHPEHE[2] / 211f);
			NBPKMLMCHFN.SetFloat("[LevelEditorScene] Item creation successful! Published Item ID: ", PLKFKNHPEHE[0] / 1949f);
			MNLKBFFKHIE().SetFloat("_StretchWidth", PLKFKNHPEHE[8] / 613f);
			NJDIODJNGGA().SetFloat("Set Object Position", PLKFKNHPEHE[8] / 965f);
			HNFFHCLNBDN().SetFloat("_ScreenResolution", PLKFKNHPEHE[-98] / 355f);
			NJDIODJNGGA().SetFloat("_MainTex2", PLKFKNHPEHE[44] / 238f);
			DOMEEFLPEPJ().SetFloat(": ", PLKFKNHPEHE[-18] / 1025f);
			OCMBHMLNCEK().SetFloat("#ok", FadeFX);
			OCMBHMLNCEK().SetFloat("SetSatelliteColor", _Size);
			MCDGIILBNIF().SetFloat("{0}{1}:{2}", _Dist);
			DKNJGHFLAIF().SetFloat("_TimeX", _Smooth);
			HNFFHCLNBDN().SetVector("SaveGameName is null or empty!", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 138f, 1425f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOMEEFLPEPJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AOGCKKLFGPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 990f)
			{
				HBJJOCHGOPH = 1587f;
			}
			KLKILLCHJHO().SetFloat("_Amount", HBJJOCHGOPH);
			OCMBHMLNCEK().SetFloat("/", PLKFKNHPEHE[1] / 1892f);
			CFEDGDGBCHE().SetFloat("Coroutine container not configured... did you forget to call Init?", PLKFKNHPEHE[1] / 1733f);
			NBPKMLMCHFN.SetFloat("_BlurVector", PLKFKNHPEHE[5] / 1374f);
			MCDGIILBNIF().SetFloat(": ", PLKFKNHPEHE[0] / 429f);
			MHBAIEKFBIJ().SetFloat("CameraFilterPack/OldFilm_Cutting2", PLKFKNHPEHE[0] / 1261f);
			KLKILLCHJHO().SetFloat("https://steamcommunity.com/sharedfiles/filedetails/?id=", PLKFKNHPEHE[7] / 1682f);
			NMDBCDFPGOK().SetFloat(".message", PLKFKNHPEHE[2] / 341f);
			KLKILLCHJHO().SetFloat("_TimeX", PLKFKNHPEHE[3] / 844f);
			NJDIODJNGGA().SetFloat("LobbyCanvas", PLKFKNHPEHE[5] / 270f);
			DOMEEFLPEPJ().SetFloat("Using constructor for new PingNativeDynamic()", PLKFKNHPEHE[-96] / 1752f);
			HEHKGPKLAKK().SetFloat(" not found", PLKFKNHPEHE[126] / 1067f);
			MHBAIEKFBIJ().SetFloat("_Green_B", PLKFKNHPEHE[7] / 1513f);
			HNFFHCLNBDN().SetFloat("_TimeX", FadeFX);
			OCMBHMLNCEK().SetFloat("Loading...", _Size);
			DOMEEFLPEPJ().SetFloat("_DistortionLevel", _Dist);
			MNLKBFFKHIE().SetFloat("Submit", _Smooth);
			MNLKBFFKHIE().SetVector("[Down-Left]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1170f, 1166f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GDPAIILEEFC()
	{
		float[] array = new float[-81];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void MBFNACDMEEK()
	{
		FMEFPOILMDI();
	}

	private void EDPDMBFLHLP()
	{
		GDPAIILEEFC();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DOFDGBGEDFI()
	{
		MIPGPMKJELI();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LMBDNPLDGIJ()
	{
	}

	private void HJPCJGOEKMF()
	{
		FALHNNJBOEM();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EJJEDJIOFAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material OCMBHMLNCEK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-124);
		}
		return BJFKDHHMLJH;
	}

	private void KKLMPKLKAEM()
	{
	}

	private void IAIAGCGJGHI()
	{
		float[] array = new float[80];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void OCCGJMPAJIK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material DKNJGHFLAIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void FDMAEPOHDMK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AEIJFLJEABG()
	{
	}

	private void LMKMEJMGDFO()
	{
		JBBKKKJOJMJ();
	}

	private void FAMLCFNDGNI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Update()
	{
	}

	[SpecialName]
	private Material NMDBCDFPGOK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void NKLIHNJCHOG()
	{
	}

	private void LAMEHAHJKMI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LGHFFANDDCM()
	{
		float[] array = new float[-82];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void KDCLNBBODBO()
	{
		JGMPDINHNKD();
	}

	private void PODKOCOPGLC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1035f)
			{
				HBJJOCHGOPH = 1267f;
			}
			ABHDNGIHBKE().SetFloat("ConfigVersionSlider", HBJJOCHGOPH);
			HNFFHCLNBDN().SetFloat("_Value4", PLKFKNHPEHE[0] / 1622f);
			DIOAAHJDMLK().SetFloat("_Value5", PLKFKNHPEHE[1] / 955f);
			DOMEEFLPEPJ().SetFloat(" scene view IDs from last level.", PLKFKNHPEHE[5] / 1326f);
			MNLKBFFKHIE().SetFloat("ItemTemplate", PLKFKNHPEHE[8] / 92f);
			DKNJGHFLAIF().SetFloat("_TimeX", PLKFKNHPEHE[5] / 904f);
			OCMBHMLNCEK().SetFloat(".ogg", PLKFKNHPEHE[1] / 1572f);
			KOHGPKOFEJO().SetFloat("_ScreenResolution", PLKFKNHPEHE[2] / 316f);
			OCMBHMLNCEK().SetFloat("musicVolume", PLKFKNHPEHE[6] / 1842f);
			MNLKBFFKHIE().SetFloat("_MainTex2", PLKFKNHPEHE[6] / 1752f);
			ABHDNGIHBKE().SetFloat("EnableRankedNotificationsToggle", PLKFKNHPEHE[-53] / 194f);
			MNLKBFFKHIE().SetFloat("wss://", PLKFKNHPEHE[70] / 545f);
			DOMEEFLPEPJ().SetFloat("Drop_Near", PLKFKNHPEHE[-95] / 638f);
			DIOAAHJDMLK().SetFloat("_Value3", FadeFX);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Blend2Camera_HardLight", _Size);
			OCMBHMLNCEK().SetFloat("UNDISTORT", _Dist);
			KOHGPKOFEJO().SetFloat(": ", _Smooth);
			KJMECMIGJJA().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 799f, 1397f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MNLKBFFKHIE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HONBLGFDMLL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OMCLOFCJMPG()
	{
	}

	private void JBNPEHMDCMI()
	{
	}

	private void IKNKJMNFFOG()
	{
		float[] array = new float[-83];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void MEBPBNLBECA()
	{
		FMEFPOILMDI();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OIKAPFGPLML(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 507f)
			{
				HBJJOCHGOPH = 489f;
			}
			MHBAIEKFBIJ().SetFloat("Ev Destroy Failed. Could not find PhotonView with instantiationId ", HBJJOCHGOPH);
			DIOAAHJDMLK().SetFloat("Editor/", PLKFKNHPEHE[1] / 679f);
			CECICEGFHKL().SetFloat("file://", PLKFKNHPEHE[1] / 1381f);
			HNFFHCLNBDN().SetFloat("float,0", PLKFKNHPEHE[5] / 1589f);
			ABHDNGIHBKE().SetFloat("CameraFilterPack/Drawing_Laplacian", PLKFKNHPEHE[7] / 372f);
			OCMBHMLNCEK().SetFloat(" beatThreshold: ", PLKFKNHPEHE[5] / 1099f);
			MHBAIEKFBIJ().SetFloat(".", PLKFKNHPEHE[5] / 1887f);
			DIOAAHJDMLK().SetFloat("_Offsets", PLKFKNHPEHE[3] / 914f);
			DKNJGHFLAIF().SetFloat("CameraFilterPack/FX_Psycho", PLKFKNHPEHE[7] / 1968f);
			ABHDNGIHBKE().SetFloat("DPADHOR", PLKFKNHPEHE[1] / 567f);
			ABHDNGIHBKE().SetFloat("[PlayerController] ", PLKFKNHPEHE[-110] / 1554f);
			DIOAAHJDMLK().SetFloat("MainButton", PLKFKNHPEHE[122] / 1715f);
			HNFFHCLNBDN().SetFloat("[SteamManager] Connection established, authorization", PLKFKNHPEHE[-95] / 723f);
			KLKILLCHJHO().SetFloat("AudioClip", FadeFX);
			NMDBCDFPGOK().SetFloat("bloomintencity:", _Size);
			CECICEGFHKL().SetFloat("_ScreenResolution", _Dist);
			ABHDNGIHBKE().SetFloat("CameraFilterPack/Distortion_Dissipation", _Smooth);
			ABHDNGIHBKE().SetVector(".lastCheckpoint.powerupsScore", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1215f, 1176f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JDCJBNHAFCI()
	{
		PPBFGGFIDKP();
	}

	private void FMEFPOILMDI()
	{
		float[] array = new float[91];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void IIKCMDMMJJI()
	{
		NBOEFDOKHLE();
	}

	private void HLIAEEMGBHN()
	{
		GKNPHGOHOAE();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material MHBAIEKFBIJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void MABCDJDPGNA()
	{
		PEKADICCGAG();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void APMCFBKLDBD()
	{
		FALHNNJBOEM();
	}

	private void LGJAHGCLMLE()
	{
		KNLDBHHKFPF();
	}

	[SpecialName]
	private Material DOMEEFLPEPJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void MGGFMCIGOAF()
	{
		float[] array = new float[97];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	[SpecialName]
	private Material ABHDNGIHBKE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-103);
		}
		return BJFKDHHMLJH;
	}

	private void GAAPMFBPJNH()
	{
		MGGFMCIGOAF();
	}

	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1251f)
			{
				HBJJOCHGOPH = 945f;
			}
			DOMEEFLPEPJ().SetFloat("LivesSlider", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("_Cible", PLKFKNHPEHE[0] / 1028f);
			KJMECMIGJJA().SetFloat("Preparing content...", PLKFKNHPEHE[1] / 1668f);
			CFEDGDGBCHE().SetFloat("SetSunMaxSize", PLKFKNHPEHE[5] / 1422f);
			MCDGIILBNIF().SetFloat("Received RPC \"", PLKFKNHPEHE[3] / 1321f);
			NJDIODJNGGA().SetFloat("Outdated version. Please restart the game to get lastest updates.", PLKFKNHPEHE[1] / 1684f);
			LDNADDJMIPK().SetFloat("maps.", PLKFKNHPEHE[2] / 1825f);
			OCMBHMLNCEK().SetFloat(" cannot be used as a 3D LUT.", PLKFKNHPEHE[0] / 1646f);
			MNLKBFFKHIE().SetFloat("JoinButton", PLKFKNHPEHE[6] / 1289f);
			NBPKMLMCHFN.SetFloat("_FlipAlphaMask", PLKFKNHPEHE[3] / 1084f);
			HEHKGPKLAKK().SetFloat("System.Int64", PLKFKNHPEHE[-91] / 1534f);
			CECICEGFHKL().SetFloat("Hex value #RRGGBB", PLKFKNHPEHE[68] / 1509f);
			MHBAIEKFBIJ().SetFloat("Year_", PLKFKNHPEHE[122] / 1151f);
			DIOAAHJDMLK().SetFloat("CameraFilterPack/FX_DarkMatter", FadeFX);
			NMDBCDFPGOK().SetFloat("0 seconds", _Size);
			DKNJGHFLAIF().SetFloat("DPADHOR", _Dist);
			MCDGIILBNIF().SetFloat("error", _Smooth);
			DKNJGHFLAIF().SetVector("No problem found, so far", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1281f, 123f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PJHBFAFOEEN()
	{
		FALHNNJBOEM();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 348f)
			{
				HBJJOCHGOPH = 915f;
			}
			KJMECMIGJJA().SetFloat("_TimeX", HBJJOCHGOPH);
			CECICEGFHKL().SetFloat(" ", PLKFKNHPEHE[1] / 1823f);
			DIOAAHJDMLK().SetFloat("_MainTex2", PLKFKNHPEHE[1] / 929f);
			HNFFHCLNBDN().SetFloat("Submition failed", PLKFKNHPEHE[6] / 1350f);
			NMDBCDFPGOK().SetFloat("NEW_ACHIEVEMENT_1_21", PLKFKNHPEHE[3] / 836f);
			LDNADDJMIPK().SetFloat("Set satellite MinVertexDistance - how much distance should be between to points of the trail line", PLKFKNHPEHE[3] / 1133f);
			KLKILLCHJHO().SetFloat("_PositionY", PLKFKNHPEHE[2] / 378f);
			KLKILLCHJHO().SetFloat("_EmissionGain", PLKFKNHPEHE[4] / 1785f);
			OCMBHMLNCEK().SetFloat("https://steamcdn-a.akamaihd.net/steamcommunity/public/images/clans/", PLKFKNHPEHE[1] / 256f);
			KLKILLCHJHO().SetFloat("\"", PLKFKNHPEHE[6] / 762f);
			ABHDNGIHBKE().SetFloat("0x", PLKFKNHPEHE[107] / 1934f);
			DIOAAHJDMLK().SetFloat("SpawnObj", PLKFKNHPEHE[103] / 1011f);
			MHBAIEKFBIJ().SetFloat("_SoftZDistance", PLKFKNHPEHE[88] / 762f);
			DOMEEFLPEPJ().SetFloat("offsets", FadeFX);
			KLKILLCHJHO().SetFloat(":\n", _Size);
			CECICEGFHKL().SetFloat("_TimeX", _Dist);
			OCMBHMLNCEK().SetFloat("ShowTitle", _Smooth);
			NMDBCDFPGOK().SetVector("_FresnelFade", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1022f, 322f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AMIMHHGLPIN()
	{
		FMEFPOILMDI();
	}

	private void OKHBBIKDIEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1667f)
			{
				HBJJOCHGOPH = 848f;
			}
			DKNJGHFLAIF().SetFloat("value", HBJJOCHGOPH);
			MHBAIEKFBIJ().SetFloat("ready", PLKFKNHPEHE[1] / 1224f);
			DOMEEFLPEPJ().SetFloat("_Exponent", PLKFKNHPEHE[1] / 500f);
			NBPKMLMCHFN.SetFloat("Editor/", PLKFKNHPEHE[4] / 1263f);
			DKNJGHFLAIF().SetFloat("_ScreenResolution", PLKFKNHPEHE[3] / 1125f);
			KJMECMIGJJA().SetFloat("CameraFilterPack/3D_Mirror", PLKFKNHPEHE[4] / 1128f);
			NBPKMLMCHFN.SetFloat("_Value2", PLKFKNHPEHE[4] / 317f);
			DIOAAHJDMLK().SetFloat("Set Sun Sensitivity", PLKFKNHPEHE[4] / 1950f);
			ABHDNGIHBKE().SetFloat("Fade", PLKFKNHPEHE[1] / 835f);
			MHBAIEKFBIJ().SetFloat(": ", PLKFKNHPEHE[2] / 527f);
			LDNADDJMIPK().SetFloat("tintColor", PLKFKNHPEHE[-18] / 566f);
			CFEDGDGBCHE().SetFloat("_ExtraColor", PLKFKNHPEHE[-121] / 249f);
			ABHDNGIHBKE().SetFloat("_Value2", PLKFKNHPEHE[25] / 892f);
			HEHKGPKLAKK().SetFloat("_ToneCurve", FadeFX);
			DIOAAHJDMLK().SetFloat("_Red_R", _Size);
			OCMBHMLNCEK().SetFloat("_Near", _Dist);
			KLKILLCHJHO().SetFloat("[Steamworks.NET] Packsize Test returned false, the wrong version of Steamworks.NET is being run in this platform.", _Smooth);
			DKNJGHFLAIF().SetVector("[Left]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1159f, 744f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MNLKBFFKHIE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JGMPDINHNKD()
	{
		float[] array = new float[15];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void IBBFFKEAOCE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 917f)
			{
				HBJJOCHGOPH = 1626f;
			}
			OCMBHMLNCEK().SetFloat("SetSatelliteRadius", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("_ScreenResolution", PLKFKNHPEHE[0] / 443f);
			KJMECMIGJJA().SetFloat(" connected: ", PLKFKNHPEHE[0] / 781f);
			CFEDGDGBCHE().SetFloat("_ScreenResolution", PLKFKNHPEHE[7] / 81f);
			CECICEGFHKL().SetFloat("Changed config", PLKFKNHPEHE[3] / 824f);
			HNFFHCLNBDN().SetFloat("_ScreenResolution", PLKFKNHPEHE[0] / 336f);
			MNLKBFFKHIE().SetFloat("Can't set visible when not in that room.", PLKFKNHPEHE[3] / 1272f);
			HNFFHCLNBDN().SetFloat("_TimeX", PLKFKNHPEHE[6] / 494f);
			KLKILLCHJHO().SetFloat("color", PLKFKNHPEHE[8] / 1133f);
			NBPKMLMCHFN.SetFloat("VHS", PLKFKNHPEHE[6] / 1117f);
			KOHGPKOFEJO().SetFloat("CameraFilterPack/Gradients_Stripe", PLKFKNHPEHE[31] / 1362f);
			OCMBHMLNCEK().SetFloat("[Right]", PLKFKNHPEHE[-108] / 1874f);
			HNFFHCLNBDN().SetFloat("menutheme.fragout", PLKFKNHPEHE[62] / 202f);
			LDNADDJMIPK().SetFloat("#random #common #item", FadeFX);
			KJMECMIGJJA().SetFloat("_Value", _Size);
			LDNADDJMIPK().SetFloat("mapselector.filter.favoriteonly", _Dist);
			KOHGPKOFEJO().SetFloat("[PlayerController] ", _Smooth);
			NJDIODJNGGA().SetVector("Scene", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 974f, 127f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MHBAIEKFBIJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OMIHEBMMCPG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1578f)
			{
				HBJJOCHGOPH = 231f;
			}
			MHBAIEKFBIJ().SetFloat("[LevelEditorScene] Print Audio Wave: Done", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat("player.lollipop", PLKFKNHPEHE[0] / 423f);
			HEHKGPKLAKK().SetFloat("#{0:X2}{1:X2}{2:X2}", PLKFKNHPEHE[1] / 381f);
			NMDBCDFPGOK().SetFloat("SetCrosshairEmission", PLKFKNHPEHE[0] / 617f);
			DKNJGHFLAIF().SetFloat("menu.enableselectormusic", PLKFKNHPEHE[0] / 1529f);
			KOHGPKOFEJO().SetFloat(": ", PLKFKNHPEHE[7] / 1788f);
			HEHKGPKLAKK().SetFloat(": ", PLKFKNHPEHE[0] / 1968f);
			DKNJGHFLAIF().SetFloat("music.ogg", PLKFKNHPEHE[5] / 1598f);
			KOHGPKOFEJO().SetFloat("yyyy-MM-dd HH:mm:ss", PLKFKNHPEHE[2] / 898f);
			MHBAIEKFBIJ().SetFloat("itemid", PLKFKNHPEHE[4] / 1826f);
			LDNADDJMIPK().SetFloat("value", PLKFKNHPEHE[80] / 511f);
			LDNADDJMIPK().SetFloat("restrictions\n\n#until: ", PLKFKNHPEHE[-78] / 1424f);
			KLKILLCHJHO().SetFloat(",", PLKFKNHPEHE[32] / 1630f);
			DIOAAHJDMLK().SetFloat("RateButton", FadeFX);
			NMDBCDFPGOK().SetFloat("_EmissionGain", _Size);
			DKNJGHFLAIF().SetFloat(".completedCount", _Dist);
			KJMECMIGJJA().SetFloat("#tryagain", _Smooth);
			KJMECMIGJJA().SetVector("_Blue_R", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 848f, 1285f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DIOAAHJDMLK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GKNPHGOHOAE()
	{
		float[] array = new float[-72];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	[SpecialName]
	private Material HEHKGPKLAKK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 703f)
			{
				HBJJOCHGOPH = 1122f;
			}
			HNFFHCLNBDN().SetFloat("_DepthLevel", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("_Value", PLKFKNHPEHE[1] / 1989f);
			DKNJGHFLAIF().SetFloat("_Blue_R", PLKFKNHPEHE[0] / 896f);
			DOMEEFLPEPJ().SetFloat("_Value4", PLKFKNHPEHE[4] / 220f);
			CECICEGFHKL().SetFloat("1087340967", PLKFKNHPEHE[4] / 1658f);
			NJDIODJNGGA().SetFloat("Hidden/Image Effects/Cinematic/MotionBlur/FrameBlending", PLKFKNHPEHE[3] / 339f);
			HEHKGPKLAKK().SetFloat("SetCrosshairEmission", PLKFKNHPEHE[2] / 258f);
			CFEDGDGBCHE().SetFloat("Reset XP", PLKFKNHPEHE[2] / 1723f);
			ABHDNGIHBKE().SetFloat("OperationResponse unhandled: {0}", PLKFKNHPEHE[3] / 1042f);
			OCMBHMLNCEK().SetFloat("AudioSampler", PLKFKNHPEHE[1] / 1330f);
			CFEDGDGBCHE().SetFloat("CameraFilterPack/TV_Distorted", PLKFKNHPEHE[76] / 192f);
			DIOAAHJDMLK().SetFloat("_SpotSize", PLKFKNHPEHE[22] / 1696f);
			MNLKBFFKHIE().SetFloat("Hex value #RRGGBB", PLKFKNHPEHE[51] / 1464f);
			MNLKBFFKHIE().SetFloat("inventory.lastitemscount", FadeFX);
			ABHDNGIHBKE().SetFloat("System.String", _Size);
			KOHGPKOFEJO().SetFloat("SetPlayerDistance", _Dist);
			ABHDNGIHBKE().SetFloat("_Value2", _Smooth);
			HNFFHCLNBDN().SetVector("Source: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 616f, 516f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material MCDGIILBNIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)69;
		}
		return BJFKDHHMLJH;
	}

	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 9f)
			{
				HBJJOCHGOPH = 226f;
			}
			DIOAAHJDMLK().SetFloat("offsets", HBJJOCHGOPH);
			MNLKBFFKHIE().SetFloat(".workshop.json", PLKFKNHPEHE[1] / 291f);
			NBPKMLMCHFN.SetFloat("FrostCanvas", PLKFKNHPEHE[1] / 1155f);
			HNFFHCLNBDN().SetFloat("USE_UV_BASED_REPROJECTION", PLKFKNHPEHE[1] / 1666f);
			DOMEEFLPEPJ().SetFloat("_Value2", PLKFKNHPEHE[0] / 389f);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Color_Noise", PLKFKNHPEHE[0] / 8f);
			MNLKBFFKHIE().SetFloat("caret", PLKFKNHPEHE[5] / 1793f);
			HNFFHCLNBDN().SetFloat("_Far", PLKFKNHPEHE[4] / 1435f);
			MHBAIEKFBIJ().SetFloat("CameraFilterPack_AAA_Blood2", PLKFKNHPEHE[2] / 1639f);
			CFEDGDGBCHE().SetFloat("_FixDistance", PLKFKNHPEHE[3] / 272f);
			HNFFHCLNBDN().SetFloat("Right", PLKFKNHPEHE[-125] / 232f);
			CECICEGFHKL().SetFloat("CameraFilterPack/Colors_DarkColor", PLKFKNHPEHE[13] / 1710f);
			KOHGPKOFEJO().SetFloat("CameraMovementSlider", PLKFKNHPEHE[14] / 1069f);
			KJMECMIGJJA().SetFloat("X", FadeFX);
			MNLKBFFKHIE().SetFloat("\\", _Size);
			NJDIODJNGGA().SetFloat("Spawn new environment object (sun, satellite etc) and sets its id", _Dist);
			DKNJGHFLAIF().SetFloat("Turn", _Smooth);
			DKNJGHFLAIF().SetVector("team", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1911f, 327f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JLNNHKPHMAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material LDNADDJMIPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-82);
		}
		return BJFKDHHMLJH;
	}

	private void FKEJGBFDCAH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void COMNAPAAPDO()
	{
	}

	private void HGPLPMCJNLL()
	{
		JBBKKKJOJMJ();
	}

	private void HIKKPDACJGI()
	{
	}

	private void DPIPGGDNGHN()
	{
	}

	private void PLEOOAJIMEE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 433f)
			{
				HBJJOCHGOPH = 195f;
			}
			OCMBHMLNCEK().SetFloat("note.3", HBJJOCHGOPH);
			CECICEGFHKL().SetFloat("You did not select a Hosting Type in your PhotonServerSettings. Please set it up or don't use ConnectUsingSettings().", PLKFKNHPEHE[1] / 1470f);
			CECICEGFHKL().SetFloat("EventTimeInputField", PLKFKNHPEHE[1] / 1868f);
			MHBAIEKFBIJ().SetFloat("DISTORT", PLKFKNHPEHE[2] / 1555f);
			DKNJGHFLAIF().SetFloat("_TimeX", PLKFKNHPEHE[4] / 976f);
			NJDIODJNGGA().SetFloat("_Value6", PLKFKNHPEHE[5] / 707f);
			MHBAIEKFBIJ().SetFloat("ConnectToRegion: ", PLKFKNHPEHE[2] / 1163f);
			NMDBCDFPGOK().SetFloat("Set Particles Speed", PLKFKNHPEHE[5] / 113f);
			NBPKMLMCHFN.SetFloat("Show text at the center of the screen. Usefull for quick messages like 'Thanks for playing!'", PLKFKNHPEHE[0] / 1202f);
			DIOAAHJDMLK().SetFloat("_NoisePerChannel", PLKFKNHPEHE[3] / 932f);
			ABHDNGIHBKE().SetFloat("EditMenu", PLKFKNHPEHE[-21] / 472f);
			MHBAIEKFBIJ().SetFloat("[Right]", PLKFKNHPEHE[76] / 296f);
			DOMEEFLPEPJ().SetFloat("CameraFilterPack/3D_Scan_Scene", PLKFKNHPEHE[-108] / 1107f);
			MHBAIEKFBIJ().SetFloat("_Value3", FadeFX);
			ABHDNGIHBKE().SetFloat("BadgeText", _Size);
			ABHDNGIHBKE().SetFloat("_ScreenResolution", _Dist);
			OCMBHMLNCEK().SetFloat("Tab1Content", _Smooth);
			MNLKBFFKHIE().SetVector(" from: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 405f, 1150f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HNILMGEKDEC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PCGODOELOHG()
	{
		FMEFPOILMDI();
	}

	private void PHINJDJEFLI()
	{
		float[] array = new float[-22];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void EHJJFJCKGAJ()
	{
	}

	private void MPADDMNGJNC()
	{
		GDPAIILEEFC();
	}

	private void GOCIGGGHANF()
	{
		float[] array = new float[-29];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void JBBKKKJOJMJ()
	{
		float[] array = new float[-101];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void KNLDBHHKFPF()
	{
		float[] array = new float[125];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void MPJAFNJLBEF()
	{
		float[] array = new float[-67];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void DPKJPFEIHOB()
	{
		MGGFMCIGOAF();
	}

	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1709f)
			{
				HBJJOCHGOPH = 1009f;
			}
			DKNJGHFLAIF().SetFloat("_TimeX", HBJJOCHGOPH);
			HEHKGPKLAKK().SetFloat("Hex value #RRGGBB", PLKFKNHPEHE[1] / 642f);
			MHBAIEKFBIJ().SetFloat("  |  Events Count: ", PLKFKNHPEHE[1] / 1949f);
			MCDGIILBNIF().SetFloat("[NetworkManager] Updating current room...", PLKFKNHPEHE[0] / 1064f);
			CECICEGFHKL().SetFloat("source", PLKFKNHPEHE[6] / 1611f);
			HEHKGPKLAKK().SetFloat("SelectorMusicToggle", PLKFKNHPEHE[3] / 73f);
			MCDGIILBNIF().SetFloat(". Check if the server is available.", PLKFKNHPEHE[6] / 1741f);
			ABHDNGIHBKE().SetFloat(": ", PLKFKNHPEHE[1] / 208f);
			CECICEGFHKL().SetFloat("menu.relaxinfo", PLKFKNHPEHE[3] / 1060f);
			DIOAAHJDMLK().SetFloat("_Saturation", PLKFKNHPEHE[0] / 859f);
			NJDIODJNGGA().SetFloat("[MapsData] Found ", PLKFKNHPEHE[-117] / 1203f);
			DKNJGHFLAIF().SetFloat("y", PLKFKNHPEHE[-20] / 43f);
			HNFFHCLNBDN().SetFloat("FrostCanvas", PLKFKNHPEHE[-93] / 1813f);
			KJMECMIGJJA().SetFloat("mapselector.tags.", FadeFX);
			MCDGIILBNIF().SetFloat("/", _Size);
			DIOAAHJDMLK().SetFloat("[ResourcesManager] Load audio error: ", _Dist);
			KJMECMIGJJA().SetFloat("speed", _Smooth);
			DOMEEFLPEPJ().SetVector("_Speed", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1130f, 18f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MNLKBFFKHIE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1015f)
			{
				HBJJOCHGOPH = 1206f;
			}
			DOMEEFLPEPJ().SetFloat("_Value3", HBJJOCHGOPH);
			KLKILLCHJHO().SetFloat("_TileMaxOffs", PLKFKNHPEHE[1] / 92f);
			LDNADDJMIPK().SetFloat("_ReflectionBufferSize", PLKFKNHPEHE[0] / 274f);
			KLKILLCHJHO().SetFloat("https://bitbucket.org/khb-soft/intralismarcsviewer/", PLKFKNHPEHE[2] / 347f);
			LDNADDJMIPK().SetFloat(":", PLKFKNHPEHE[7] / 168f);
			LDNADDJMIPK().SetFloat("_Value2", PLKFKNHPEHE[4] / 877f);
			ABHDNGIHBKE().SetFloat("[NetworkManager] Connected to ", PLKFKNHPEHE[0] / 1218f);
			KJMECMIGJJA().SetFloat("Case-Sensitive", PLKFKNHPEHE[1] / 1256f);
			NJDIODJNGGA().SetFloat("_Value3", PLKFKNHPEHE[0] / 707f);
			CECICEGFHKL().SetFloat("CreateRoom failed. In offline mode you still have to leave a room to enter another.", PLKFKNHPEHE[5] / 1591f);
			NJDIODJNGGA().SetFloat(": ", PLKFKNHPEHE[51] / 1500f);
			KJMECMIGJJA().SetFloat("[MapsStats] Map ID: ", PLKFKNHPEHE[127] / 932f);
			DKNJGHFLAIF().SetFloat("[PlayerController] ", PLKFKNHPEHE[-100] / 80f);
			OCMBHMLNCEK().SetFloat("[NetworkMenu] Joining ", FadeFX);
			NMDBCDFPGOK().SetFloat("achievements.21.progress", _Size);
			OCMBHMLNCEK().SetFloat("IconFileSelector", _Dist);
			OCMBHMLNCEK().SetFloat("maps.", _Smooth);
			OCMBHMLNCEK().SetVector("EventTimeInputField", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 910f, 946f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DIOAAHJDMLK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LCDJFJIBADI()
	{
	}

	private void AIKDNGCEDAB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 774f)
			{
				HBJJOCHGOPH = 512f;
			}
			LDNADDJMIPK().SetFloat("_Extra", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("_Parasite", PLKFKNHPEHE[1] / 360f);
			NMDBCDFPGOK().SetFloat("Custom Authentication failed (either due to user-input or configuration or AuthParameter string format). Calling: OnCustomAuthenticationFailed()", PLKFKNHPEHE[0] / 1716f);
			KLKILLCHJHO().SetFloat("CameraFilterPack/BlurTiltShift_V", PLKFKNHPEHE[8] / 417f);
			ABHDNGIHBKE().SetFloat("_Offsets", PLKFKNHPEHE[8] / 85f);
			KJMECMIGJJA().SetFloat("challengeid", PLKFKNHPEHE[6] / 1096f);
			CFEDGDGBCHE().SetFloat("_Value2", PLKFKNHPEHE[5] / 595f);
			KJMECMIGJJA().SetFloat("_LrDepthTex", PLKFKNHPEHE[6] / 475f);
			LDNADDJMIPK().SetFloat("_Light2", PLKFKNHPEHE[6] / 296f);
			CFEDGDGBCHE().SetFloat("CameraFilterPack/FX_superDot", PLKFKNHPEHE[5] / 2f);
			DIOAAHJDMLK().SetFloat("_RotationMatrix", PLKFKNHPEHE[111] / 889f);
			ABHDNGIHBKE().SetFloat("_Near", PLKFKNHPEHE[-35] / 808f);
			CFEDGDGBCHE().SetFloat("SetSunEmission", PLKFKNHPEHE[90] / 770f);
			CECICEGFHKL().SetFloat("_YCrop", FadeFX);
			CFEDGDGBCHE().SetFloat("_TimeX", _Size);
			KOHGPKOFEJO().SetFloat("JoinButton", _Dist);
			OCMBHMLNCEK().SetFloat("Failed!", _Smooth);
			DIOAAHJDMLK().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 940f, 538f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NMDBCDFPGOK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PEKADICCGAG()
	{
		float[] array = new float[-13];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void AAPKKMKDOFO()
	{
		PPBFGGFIDKP();
	}
}
