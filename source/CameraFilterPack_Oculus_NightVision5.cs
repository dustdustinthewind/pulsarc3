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
		IKNKJMNFFOG();
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
		JBBKKKJOJMJ();
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
			CECICEGFHKL().SetFloat("_BlurPass", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat("<color=white>PhotonView Group: ", PLKFKNHPEHE[1] / 480f);
			KOHGPKOFEJO().SetFloat("\\n", PLKFKNHPEHE[0] / 463f);
			NJDIODJNGGA().SetFloat("Protocol switch from: ", PLKFKNHPEHE[1] / 137f);
			HNFFHCLNBDN().SetFloat("Preparing content", PLKFKNHPEHE[0] / 624f);
			ABHDNGIHBKE().SetFloat("GlassesColor2", PLKFKNHPEHE[1] / 793f);
			NBPKMLMCHFN.SetFloat("duration", PLKFKNHPEHE[2] / 115f);
			MCDGIILBNIF().SetFloat("OPEN", PLKFKNHPEHE[3] / 273f);
			NJDIODJNGGA().SetFloat("SetEnvSpriteColor", PLKFKNHPEHE[4] / 1504f);
			DKNJGHFLAIF().SetFloat("CameraFilterPack/FX_Plasma", PLKFKNHPEHE[1] / 1893f);
			NJDIODJNGGA().SetFloat("_FixDistance", PLKFKNHPEHE[-75] / 439f);
			NBPKMLMCHFN.SetFloat("SpectateButton", PLKFKNHPEHE[-16] / 1410f);
			NMDBCDFPGOK().SetFloat("Horizontal", PLKFKNHPEHE[53] / 1143f);
			OCMBHMLNCEK().SetFloat("SpawnObj", FadeFX);
			NMDBCDFPGOK().SetFloat("BitsData", _Size);
			DIOAAHJDMLK().SetFloat("_Value2", _Dist);
			HEHKGPKLAKK().SetFloat("#alreadystarted", _Smooth);
			DKNJGHFLAIF().SetVector("_Offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 828f, 754f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KJMECMIGJJA());
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
		PPBFGGFIDKP();
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
		AGMHAIFOAAO();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NPLCENPNJBM()
	{
		GOCIGGGHANF();
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
			NMDBCDFPGOK().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat(".highscore", PLKFKNHPEHE[0] / 1338f);
			NJDIODJNGGA().SetFloat("Add Environment Object", PLKFKNHPEHE[0] / 447f);
			LDNADDJMIPK().SetFloat("_Offsets", PLKFKNHPEHE[5] / 1160f);
			MHBAIEKFBIJ().SetFloat(": ", PLKFKNHPEHE[5] / 1163f);
			MCDGIILBNIF().SetFloat("_Value6", PLKFKNHPEHE[8] / 648f);
			KJMECMIGJJA().SetFloat("#", PLKFKNHPEHE[2] / 832f);
			OCMBHMLNCEK().SetFloat("UseFinalGlassColor", PLKFKNHPEHE[6] / 1476f);
			NMDBCDFPGOK().SetFloat("win", PLKFKNHPEHE[8] / 691f);
			NMDBCDFPGOK().SetFloat("CameraFilterPack/Edge_BlackLine", PLKFKNHPEHE[6] / 220f);
			CFEDGDGBCHE().SetFloat("VisionBlur", PLKFKNHPEHE[18] / 1095f);
			MNLKBFFKHIE().SetFloat("g", PLKFKNHPEHE[-37] / 1193f);
			KOHGPKOFEJO().SetFloat("default", PLKFKNHPEHE[-15] / 1637f);
			KJMECMIGJJA().SetFloat("System.Int64", FadeFX);
			DIOAAHJDMLK().SetFloat("CameraFilterPack/Distortion_FishEye", _Size);
			MNLKBFFKHIE().SetFloat("_ColorRGB", _Dist);
			NJDIODJNGGA().SetFloat("ScrollPanel", _Smooth);
			CECICEGFHKL().SetVector("IntraTime", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1369f, 943f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KOHGPKOFEJO());
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
		MIPGPMKJELI();
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
		MGGFMCIGOAF();
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
		PHINJDJEFLI();
	}

	private void KKDDHFJOAAD()
	{
		GOCIGGGHANF();
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
		EALEEMOPJNO();
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
		MIPGPMKJELI();
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
		JBBKKKJOJMJ();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OEGEBCOIAHN()
	{
		KNLDBHHKFPF();
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
			HNFFHCLNBDN().SetFloat("Parameter levelId must be int or string!", HBJJOCHGOPH);
			HEHKGPKLAKK().SetFloat("maps.", PLKFKNHPEHE[1] / 759f);
			DKNJGHFLAIF().SetFloat(" GameServer:", PLKFKNHPEHE[0] / 341f);
			MHBAIEKFBIJ().SetFloat("_ScreenResolution", PLKFKNHPEHE[1] / 1295f);
			DKNJGHFLAIF().SetFloat("In Main Menu", PLKFKNHPEHE[7] / 1798f);
			LDNADDJMIPK().SetFloat("_TimeX", PLKFKNHPEHE[3] / 713f);
			CECICEGFHKL().SetFloat(" - ", PLKFKNHPEHE[1] / 829f);
			KOHGPKOFEJO().SetFloat("RemoveHighlight", PLKFKNHPEHE[8] / 1823f);
			CFEDGDGBCHE().SetFloat("_V", PLKFKNHPEHE[6] / 1319f);
			LDNADDJMIPK().SetFloat(" SecondsBeforeRespawn: ", PLKFKNHPEHE[8] / 590f);
			KLKILLCHJHO().SetFloat("mapselector.filter.officialsortmode", PLKFKNHPEHE[-51] / 1495f);
			KJMECMIGJJA().SetFloat("setfloat", PLKFKNHPEHE[-20] / 509f);
			OCMBHMLNCEK().SetFloat("error", PLKFKNHPEHE[-2] / 1888f);
			KJMECMIGJJA().SetFloat("_ScreenResolution", FadeFX);
			DIOAAHJDMLK().SetFloat("LivesSlider", _Size);
			KLKILLCHJHO().SetFloat("offsets", _Dist);
			CECICEGFHKL().SetFloat("Noise & Grain effect failing as noise texture is not assigned. please assign.", _Smooth);
			DKNJGHFLAIF().SetVector("Object ID. Case-Sensitive", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1996f, 129f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BEKMLIFILFP()
	{
		GKNPHGOHOAE();
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
		PBKELEKDBIC();
	}

	private void MODENHKMKOC()
	{
		KOFOBHNODCH();
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
			MCDGIILBNIF().SetFloat("B:", HBJJOCHGOPH);
			MNLKBFFKHIE().SetFloat("DPADHOR", PLKFKNHPEHE[0] / 563f);
			MNLKBFFKHIE().SetFloat("System.Boolean", PLKFKNHPEHE[0] / 676f);
			HNFFHCLNBDN().SetFloat("[LevelEditorScene] Updated", PLKFKNHPEHE[3] / 1221f);
			ABHDNGIHBKE().SetFloat("Error: I/O Failure", PLKFKNHPEHE[1] / 953f);
			DIOAAHJDMLK().SetFloat("cipherText", PLKFKNHPEHE[0] / 541f);
			CFEDGDGBCHE().SetFloat("FPSToggle", PLKFKNHPEHE[2] / 74f);
			NMDBCDFPGOK().SetFloat("SlidingArea", PLKFKNHPEHE[1] / 1624f);
			DOMEEFLPEPJ().SetFloat("_CenterY", PLKFKNHPEHE[2] / 720f);
			CFEDGDGBCHE().SetFloat(".", PLKFKNHPEHE[6] / 937f);
			MHBAIEKFBIJ().SetFloat("event", PLKFKNHPEHE[48] / 255f);
			NBPKMLMCHFN.SetFloat("#startofflinemessage", PLKFKNHPEHE[58] / 858f);
			NMDBCDFPGOK().SetFloat("/", PLKFKNHPEHE[48] / 948f);
			LDNADDJMIPK().SetFloat("_Value4", FadeFX);
			NBPKMLMCHFN.SetFloat("MenuScene", _Size);
			DOMEEFLPEPJ().SetFloat("_PositionX", _Dist);
			NBPKMLMCHFN.SetFloat("Couldn't call DestroyAll() as only the master client is allowed to call this.", _Smooth);
			DIOAAHJDMLK().SetVector(" : ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 432f, 1073f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NJDIODJNGGA());
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
			KOHGPKOFEJO().SetFloat("CameraFilterPack/Distortion_Lens", HBJJOCHGOPH);
			MHBAIEKFBIJ().SetFloat("_AlphaHexa", PLKFKNHPEHE[0] / 1617f);
			KOHGPKOFEJO().SetFloat("menutheme.coldheat", PLKFKNHPEHE[0] / 1592f);
			MCDGIILBNIF().SetFloat("_ScreenResolution", PLKFKNHPEHE[7] / 904f);
			CECICEGFHKL().SetFloat("L1", PLKFKNHPEHE[5] / 263f);
			MHBAIEKFBIJ().SetFloat("[DiscordController] Join ({0})", PLKFKNHPEHE[8] / 721f);
			ABHDNGIHBKE().SetFloat("_TimeX", PLKFKNHPEHE[4] / 1793f);
			MNLKBFFKHIE().SetFloat("_Fade", PLKFKNHPEHE[2] / 1771f);
			DOMEEFLPEPJ().SetFloat("_Amount", PLKFKNHPEHE[1] / 946f);
			KJMECMIGJJA().SetFloat("_ToneCurveRange", PLKFKNHPEHE[1] / 426f);
			NMDBCDFPGOK().SetFloat("_TimeX", PLKFKNHPEHE[109] / 220f);
			OCMBHMLNCEK().SetFloat("[Down]", PLKFKNHPEHE[-118] / 639f);
			LDNADDJMIPK().SetFloat("_TileMaxLoop", PLKFKNHPEHE[-6] / 866f);
			KOHGPKOFEJO().SetFloat("float,2", FadeFX);
			MHBAIEKFBIJ().SetFloat("menuVolume", _Size);
			KLKILLCHJHO().SetFloat("1332644700", _Dist);
			NMDBCDFPGOK().SetFloat("_VelocityScale", _Smooth);
			LDNADDJMIPK().SetVector("Winter2020", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 420f, 1266f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KOHGPKOFEJO());
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
		MIPGPMKJELI();
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
		MPJAFNJLBEF();
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
		PPBFGGFIDKP();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AGFGKIBHCBE()
	{
		KNLDBHHKFPF();
	}

	private void JILOMOBDPIA()
	{
		PHINJDJEFLI();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DCGFEIBKOBB()
	{
		KNLDBHHKFPF();
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
			NBPKMLMCHFN.SetFloat("Set particles size", HBJJOCHGOPH);
			DOMEEFLPEPJ().SetFloat("GameScene", PLKFKNHPEHE[1] / 599f);
			HEHKGPKLAKK().SetFloat("OnClick", PLKFKNHPEHE[0] / 391f);
			DKNJGHFLAIF().SetFloat("LevelEditor/CustomEventEditor-Text", PLKFKNHPEHE[6] / 1870f);
			NMDBCDFPGOK().SetFloat("MapperNameText", PLKFKNHPEHE[1] / 1524f);
			DOMEEFLPEPJ().SetFloat("_EmissionColor", PLKFKNHPEHE[8] / 213f);
			KLKILLCHJHO().SetFloat("_TimeX", PLKFKNHPEHE[8] / 1768f);
			KOHGPKOFEJO().SetFloat("ConnectUsingSettings() disabled the offline mode. No longer offline.", PLKFKNHPEHE[8] / 484f);
			CECICEGFHKL().SetFloat("_TimeX", PLKFKNHPEHE[0] / 461f);
			OCMBHMLNCEK().SetFloat("RemoveEnvironmentObject", PLKFKNHPEHE[3] / 1839f);
			DKNJGHFLAIF().SetFloat("_Saturation", PLKFKNHPEHE[-48] / 1019f);
			MHBAIEKFBIJ().SetFloat("MapEditorScene", PLKFKNHPEHE[-125] / 1272f);
			MNLKBFFKHIE().SetFloat("_TimeX", PLKFKNHPEHE[60] / 531f);
			KOHGPKOFEJO().SetFloat("_TimeX", FadeFX);
			OCMBHMLNCEK().SetFloat("_SpawnHeuristic", _Size);
			OCMBHMLNCEK().SetFloat("STICKRHOR", _Dist);
			ABHDNGIHBKE().SetFloat("_Value", _Smooth);
			NBPKMLMCHFN.SetVector("_AOTex", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 212f, 277f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
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
			CFEDGDGBCHE().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			LDNADDJMIPK().SetFloat("Print the list of scenes, avalable in game.", PLKFKNHPEHE[0] / 1839f);
			KJMECMIGJJA().SetFloat("settings_bindings_controller_type", PLKFKNHPEHE[1] / 684f);
			NBPKMLMCHFN.SetFloat("_StretchWidth", PLKFKNHPEHE[1] / 284f);
			NJDIODJNGGA().SetFloat("_Bullet_7", PLKFKNHPEHE[4] / 407f);
			NJDIODJNGGA().SetFloat("EnableRankedNotificationsToggle", PLKFKNHPEHE[4] / 1445f);
			DIOAAHJDMLK().SetFloat("EnableRankingToggle", PLKFKNHPEHE[8] / 870f);
			ABHDNGIHBKE().SetFloat("_TimeX", PLKFKNHPEHE[4] / 283f);
			HEHKGPKLAKK().SetFloat("_Brightness", PLKFKNHPEHE[5] / 1908f);
			KJMECMIGJJA().SetFloat("HiddenToggle", PLKFKNHPEHE[4] / 231f);
			NMDBCDFPGOK().SetFloat("note.2", PLKFKNHPEHE[39] / 1125f);
			DOMEEFLPEPJ().SetFloat("TwoHands", PLKFKNHPEHE[12] / 1536f);
			DKNJGHFLAIF().SetFloat("_ScreenResolution", PLKFKNHPEHE[42] / 1831f);
			CFEDGDGBCHE().SetFloat("CameraFilterPack/Glow_Glow_Color", FadeFX);
			MHBAIEKFBIJ().SetFloat("bad", _Size);
			NMDBCDFPGOK().SetFloat("Editor/", _Dist);
			DKNJGHFLAIF().SetFloat("CameraFilterPack/Drawing_Halftone", _Smooth);
			CECICEGFHKL().SetVector("00", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1993f, 822f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MHBAIEKFBIJ());
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
			DIOAAHJDMLK().SetFloat(" could not be executed (yet). Wait for state JoinedLobby or ConnectedToMaster and their callbacks before calling operations. WebRPCs need a server-side configuration. Enum OperationCode helps identify the operation.", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("\\\\", PLKFKNHPEHE[0] / 1935f);
			KJMECMIGJJA().SetFloat("#TBD", PLKFKNHPEHE[0] / 1642f);
			OCMBHMLNCEK().SetFloat("Left", PLKFKNHPEHE[0] / 652f);
			LDNADDJMIPK().SetFloat("/../", PLKFKNHPEHE[4] / 1975f);
			OCMBHMLNCEK().SetFloat("Left", PLKFKNHPEHE[6] / 1184f);
			LDNADDJMIPK().SetFloat("UnityEngine.MonoBehaviour", PLKFKNHPEHE[5] / 1580f);
			MHBAIEKFBIJ().SetFloat("\" error: ", PLKFKNHPEHE[8] / 1294f);
			KLKILLCHJHO().SetFloat("ticket", PLKFKNHPEHE[5] / 1629f);
			KOHGPKOFEJO().SetFloat("ReconnectAndRejoin() failed. It seems the client wasn't connected to a game server before (no address).", PLKFKNHPEHE[0] / 530f);
			MHBAIEKFBIJ().SetFloat("[PlayerBase] Config error: musicTime <= 0", PLKFKNHPEHE[94] / 634f);
			DIOAAHJDMLK().SetFloat("#failed!", PLKFKNHPEHE[126] / 1055f);
			DOMEEFLPEPJ().SetFloat("maps.", PLKFKNHPEHE[52] / 1319f);
			OCMBHMLNCEK().SetFloat("tintColor", FadeFX);
			MHBAIEKFBIJ().SetFloat("/icon", _Size);
			MHBAIEKFBIJ().SetFloat(".GoalProgress", _Dist);
			NMDBCDFPGOK().SetFloat("Joystick1Button0", _Smooth);
			CFEDGDGBCHE().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1917f, 1986f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JONGNKNLLND()
	{
		FALHNNJBOEM();
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
			HNFFHCLNBDN().SetFloat("CameraFilterPack/Blend2Camera_Luminosity", HBJJOCHGOPH);
			OCMBHMLNCEK().SetFloat("settings.shaders.bloomintencity", PLKFKNHPEHE[0] / 1410f);
			DIOAAHJDMLK().SetFloat("_ScreenResolution", PLKFKNHPEHE[1] / 771f);
			NJDIODJNGGA().SetFloat("CameraFilterPack/Blend2Camera_Subtract", PLKFKNHPEHE[7] / 572f);
			HNFFHCLNBDN().SetFloat("{0}", PLKFKNHPEHE[0] / 572f);
			MCDGIILBNIF().SetFloat("Clears the console and prints the logs in the specified range", PLKFKNHPEHE[6] / 1603f);
			MNLKBFFKHIE().SetFloat("maps.", PLKFKNHPEHE[8] / 1658f);
			HNFFHCLNBDN().SetFloat("masterVolume", PLKFKNHPEHE[7] / 1461f);
			OCMBHMLNCEK().SetFloat("file://", PLKFKNHPEHE[7] / 1926f);
			NJDIODJNGGA().SetFloat("_ScreenResolution", PLKFKNHPEHE[3] / 95f);
			DKNJGHFLAIF().SetFloat("_HdrParams", PLKFKNHPEHE[107] / 91f);
			DKNJGHFLAIF().SetFloat("Join failed on GameServer. Changing back to MasterServer. Msg: ", PLKFKNHPEHE[-112] / 1720f);
			DOMEEFLPEPJ().SetFloat("_MainTex2", PLKFKNHPEHE[41] / 963f);
			MHBAIEKFBIJ().SetFloat("Join failed on GameServer. Changing back to MasterServer. Msg: ", FadeFX);
			LDNADDJMIPK().SetFloat("[MapsData] Key ", _Size);
			DOMEEFLPEPJ().SetFloat("_Glitch", _Dist);
			MCDGIILBNIF().SetFloat("settings.enableranking", _Smooth);
			ABHDNGIHBKE().SetVector("_Value5", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1678f, 1052f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JHANGPCOCIG()
	{
		GDPAIILEEFC();
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
		MIPGPMKJELI();
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
			NBPKMLMCHFN.SetFloat("_ContrastGainGamma", HBJJOCHGOPH);
			DOMEEFLPEPJ().SetFloat("Tab1Content", PLKFKNHPEHE[0] / 1739f);
			MNLKBFFKHIE().SetFloat("settings.shaders.bloomintencity", PLKFKNHPEHE[1] / 1617f);
			NJDIODJNGGA().SetFloat("CameraFilterPack/Gradients_Hue", PLKFKNHPEHE[1] / 277f);
			MCDGIILBNIF().SetFloat("_AxialAberration", PLKFKNHPEHE[4] / 1628f);
			HEHKGPKLAKK().SetFloat("_Value", PLKFKNHPEHE[5] / 1425f);
			NMDBCDFPGOK().SetFloat("</color>", PLKFKNHPEHE[2] / 211f);
			HEHKGPKLAKK().SetFloat("[LevelEditorScene] Error: You're not logged into Steam!", PLKFKNHPEHE[0] / 1949f);
			HNFFHCLNBDN().SetFloat("_StretchWidth", PLKFKNHPEHE[8] / 613f);
			HNFFHCLNBDN().SetFloat("SetPosition", PLKFKNHPEHE[8] / 965f);
			DKNJGHFLAIF().SetFloat("_Value4", PLKFKNHPEHE[-98] / 355f);
			KOHGPKOFEJO().SetFloat("_MainTex2", PLKFKNHPEHE[44] / 238f);
			HNFFHCLNBDN().SetFloat(" not exist", PLKFKNHPEHE[-18] / 1025f);
			LDNADDJMIPK().SetFloat("#savemapbeforeuploading", FadeFX);
			CECICEGFHKL().SetFloat("Set sun directionVector - in which direction sun will grow on beat", _Size);
			CECICEGFHKL().SetFloat("ws://", _Dist);
			ABHDNGIHBKE().SetFloat("CameraFilterPack/EyesVision_1", _Smooth);
			DIOAAHJDMLK().SetVector("Save Game", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 138f, 1425f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
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
			NJDIODJNGGA().SetFloat("_TimeX", HBJJOCHGOPH);
			HNFFHCLNBDN().SetFloat("/icon", PLKFKNHPEHE[1] / 1892f);
			DIOAAHJDMLK().SetFloat("HighScaleShot", PLKFKNHPEHE[1] / 1733f);
			NMDBCDFPGOK().SetFloat("_OcclusionTexture", PLKFKNHPEHE[5] / 1374f);
			NMDBCDFPGOK().SetFloat("[PlayerController] ", PLKFKNHPEHE[0] / 429f);
			NBPKMLMCHFN.SetFloat("_MainTex2", PLKFKNHPEHE[0] / 1261f);
			MHBAIEKFBIJ().SetFloat("OK", PLKFKNHPEHE[7] / 1682f);
			HEHKGPKLAKK().SetFloat("MenuScene", PLKFKNHPEHE[2] / 341f);
			MCDGIILBNIF().SetFloat("_TimeX", PLKFKNHPEHE[3] / 844f);
			DIOAAHJDMLK().SetFloat("LobbyCanvas", PLKFKNHPEHE[5] / 270f);
			CFEDGDGBCHE().SetFloat(":", PLKFKNHPEHE[-96] / 1752f);
			ABHDNGIHBKE().SetFloat(".completed", PLKFKNHPEHE[126] / 1067f);
			LDNADDJMIPK().SetFloat("_Green_G", PLKFKNHPEHE[7] / 1513f);
			MHBAIEKFBIJ().SetFloat("CameraFilterPack/TV_Distorted", FadeFX);
			DKNJGHFLAIF().SetFloat("[MenuScene] Inited", _Size);
			KJMECMIGJJA().SetFloat("_DistortionLevel", _Dist);
			MCDGIILBNIF().SetFloat("Horizontal", _Smooth);
			DKNJGHFLAIF().SetVector("[Down-Left]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1170f, 1166f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOMEEFLPEPJ());
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
		MGGFMCIGOAF();
	}

	private void EDPDMBFLHLP()
	{
		FALHNNJBOEM();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DOFDGBGEDFI()
	{
		MPJAFNJLBEF();
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
		KOFOBHNODCH();
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
		MIPGPMKJELI();
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
		NBOEFDOKHLE();
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
			CFEDGDGBCHE().SetFloat("ConfigVersionSlider", HBJJOCHGOPH);
			LDNADDJMIPK().SetFloat("_Value3", PLKFKNHPEHE[0] / 1622f);
			HNFFHCLNBDN().SetFloat("_Value2", PLKFKNHPEHE[1] / 955f);
			DIOAAHJDMLK().SetFloat(". The group number should be at least 1.", PLKFKNHPEHE[5] / 1326f);
			MCDGIILBNIF().SetFloat("Scrollbar", PLKFKNHPEHE[8] / 92f);
			LDNADDJMIPK().SetFloat("CameraFilterPack/Vision_Psycho", PLKFKNHPEHE[5] / 904f);
			NJDIODJNGGA().SetFloat(".mp3", PLKFKNHPEHE[1] / 1572f);
			MHBAIEKFBIJ().SetFloat("_Colored", PLKFKNHPEHE[2] / 316f);
			KJMECMIGJJA().SetFloat("sfxVolume", PLKFKNHPEHE[6] / 1842f);
			HNFFHCLNBDN().SetFloat("CameraFilterPack/Blend2Camera_Multiply", PLKFKNHPEHE[6] / 1752f);
			CECICEGFHKL().SetFloat("EnableRankedNotificationsToggle", PLKFKNHPEHE[-53] / 194f);
			MHBAIEKFBIJ().SetFloat("Using constructor for new PingNativeStatic()", PLKFKNHPEHE[70] / 545f);
			LDNADDJMIPK().SetFloat("Drop_Near", PLKFKNHPEHE[-95] / 638f);
			DOMEEFLPEPJ().SetFloat("_Value2", FadeFX);
			HNFFHCLNBDN().SetFloat("CameraFilterPack/Blend2Camera_HardLight", _Size);
			KLKILLCHJHO().SetFloat("Hidden/LensAberrations", _Dist);
			DKNJGHFLAIF().SetFloat(":", _Smooth);
			DIOAAHJDMLK().SetVector("CameraFilterPack/TV_PlanetMars", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 799f, 1397f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OCMBHMLNCEK());
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
		FALHNNJBOEM();
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
			KLKILLCHJHO().SetFloat("Error: Someone else(", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Editor", PLKFKNHPEHE[1] / 679f);
			NBPKMLMCHFN.SetFloat("[FileSelector] Dialog ended, result: ", PLKFKNHPEHE[1] / 1381f);
			ABHDNGIHBKE().SetFloat("z", PLKFKNHPEHE[5] / 1589f);
			NJDIODJNGGA().SetFloat("_DotSize", PLKFKNHPEHE[7] / 372f);
			ABHDNGIHBKE().SetFloat(" beatThreshold: ", PLKFKNHPEHE[5] / 1099f);
			OCMBHMLNCEK().SetFloat(".workshop.json", PLKFKNHPEHE[5] / 1887f);
			NBPKMLMCHFN.SetFloat("_Offsets", PLKFKNHPEHE[3] / 914f);
			OCMBHMLNCEK().SetFloat("_ScreenResolution", PLKFKNHPEHE[7] / 1968f);
			CECICEGFHKL().SetFloat("DPADVER", PLKFKNHPEHE[1] / 567f);
			NBPKMLMCHFN.SetFloat(" not exist", PLKFKNHPEHE[-110] / 1554f);
			DOMEEFLPEPJ().SetFloat(" ", PLKFKNHPEHE[122] / 1715f);
			OCMBHMLNCEK().SetFloat("[Steamworks.NET] SteamAPI_Init() failed. Refer to Valve's documentation or the comment above this line for more information.", PLKFKNHPEHE[-95] / 723f);
			DOMEEFLPEPJ().SetFloat("MenuScene", FadeFX);
			DKNJGHFLAIF().SetFloat("powerup.1", _Size);
			CECICEGFHKL().SetFloat("_ScreenResolution", _Dist);
			OCMBHMLNCEK().SetFloat("_ScreenResolution", _Smooth);
			DOMEEFLPEPJ().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1215f, 1176f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNFFHCLNBDN());
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
		FALHNNJBOEM();
	}

	private void HLIAEEMGBHN()
	{
		FMEFPOILMDI();
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
		KNLDBHHKFPF();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void APMCFBKLDBD()
	{
		FMEFPOILMDI();
	}

	private void LGJAHGCLMLE()
	{
		GDPAIILEEFC();
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
		AGMHAIFOAAO();
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
			MHBAIEKFBIJ().SetFloat("Tab2Content", HBJJOCHGOPH);
			DIOAAHJDMLK().SetFloat("_Value3", PLKFKNHPEHE[0] / 1028f);
			CECICEGFHKL().SetFloat("The number of players playing your game: ", PLKFKNHPEHE[1] / 1668f);
			DIOAAHJDMLK().SetFloat("SetSunMaxSize", PLKFKNHPEHE[5] / 1422f);
			KJMECMIGJJA().SetFloat("Could not find RPC with index: ", PLKFKNHPEHE[3] / 1321f);
			NMDBCDFPGOK().SetFloat("#exit", PLKFKNHPEHE[1] / 1684f);
			MNLKBFFKHIE().SetFloat("maps.", PLKFKNHPEHE[2] / 1825f);
			CECICEGFHKL().SetFloat("The given 2D texture ", PLKFKNHPEHE[0] / 1646f);
			HEHKGPKLAKK().SetFloat("JoinButton", PLKFKNHPEHE[6] / 1289f);
			DOMEEFLPEPJ().SetFloat("_Min", PLKFKNHPEHE[3] / 1084f);
			KJMECMIGJJA().SetFloat("System.Int64", PLKFKNHPEHE[-91] / 1534f);
			CECICEGFHKL().SetFloat("Hex value #RRGGBB", PLKFKNHPEHE[68] / 1509f);
			DOMEEFLPEPJ().SetFloat("No child content found, exiting..", PLKFKNHPEHE[122] / 1151f);
			KJMECMIGJJA().SetFloat("_ScreenResolution", FadeFX);
			HNFFHCLNBDN().SetFloat(", ", _Size);
			HNFFHCLNBDN().SetFloat("DPADVER", _Dist);
			DKNJGHFLAIF().SetFloat("[", _Smooth);
			OCMBHMLNCEK().SetVector("icon", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1281f, 123f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CECICEGFHKL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PJHBFAFOEEN()
	{
		GOCIGGGHANF();
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
			MHBAIEKFBIJ().SetFloat("CameraFilterPack/Gradients_ElectricGradient", HBJJOCHGOPH);
			MNLKBFFKHIE().SetFloat(":\n", PLKFKNHPEHE[1] / 1823f);
			NBPKMLMCHFN.SetFloat("_Amount", PLKFKNHPEHE[1] / 929f);
			HNFFHCLNBDN().SetFloat("Submition failed", PLKFKNHPEHE[6] / 1350f);
			KLKILLCHJHO().SetFloat("achievements.21.completed.workshop.", PLKFKNHPEHE[3] / 836f);
			OCMBHMLNCEK().SetFloat("float,2", PLKFKNHPEHE[3] / 1133f);
			KJMECMIGJJA().SetFloat("_PositionY", PLKFKNHPEHE[2] / 378f);
			NMDBCDFPGOK().SetFloat("[Left]", PLKFKNHPEHE[4] / 1785f);
			CFEDGDGBCHE().SetFloat("https://steamcdn-a.akamaihd.net/steamcommunity/public/images/clans/", PLKFKNHPEHE[1] / 256f);
			OCMBHMLNCEK().SetFloat("]", PLKFKNHPEHE[6] / 762f);
			DKNJGHFLAIF().SetFloat("SetSpeed", PLKFKNHPEHE[107] / 1934f);
			CFEDGDGBCHE().SetFloat(".lastCheckpoint.bgcolor", PLKFKNHPEHE[103] / 1011f);
			NBPKMLMCHFN.SetFloat("_SoftZDistance", PLKFKNHPEHE[88] / 762f);
			NJDIODJNGGA().SetFloat("offsets", FadeFX);
			ABHDNGIHBKE().SetFloat("ItemNameText", _Size);
			MCDGIILBNIF().SetFloat("_TimeX", _Dist);
			HNFFHCLNBDN().SetFloat("Delete events", _Smooth);
			NMDBCDFPGOK().SetVector("_LayerThickness", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1022f, 322f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AMIMHHGLPIN()
	{
		LGHFFANDDCM();
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
			KOHGPKOFEJO().SetFloat("value", HBJJOCHGOPH);
			LDNADDJMIPK().SetFloat("ready", PLKFKNHPEHE[1] / 1224f);
			ABHDNGIHBKE().SetFloat("_SampleDistance", PLKFKNHPEHE[1] / 500f);
			DIOAAHJDMLK().SetFloat("Please wait..", PLKFKNHPEHE[4] / 1263f);
			ABHDNGIHBKE().SetFloat("_Fade", PLKFKNHPEHE[3] / 1125f);
			KOHGPKOFEJO().SetFloat("CameraFilterPack/3D_Mirror", PLKFKNHPEHE[4] / 1128f);
			NBPKMLMCHFN.SetFloat("_Value", PLKFKNHPEHE[4] / 317f);
			DIOAAHJDMLK().SetFloat("Set Sun Sensitivity", PLKFKNHPEHE[4] / 1950f);
			MCDGIILBNIF().SetFloat("Fade", PLKFKNHPEHE[1] / 835f);
			OCMBHMLNCEK().SetFloat("[PlayerController] ", PLKFKNHPEHE[2] / 527f);
			LDNADDJMIPK().SetFloat("offsets", PLKFKNHPEHE[-18] / 566f);
			LDNADDJMIPK().SetFloat("_Value4", PLKFKNHPEHE[-121] / 249f);
			NJDIODJNGGA().SetFloat("_Value", PLKFKNHPEHE[25] / 892f);
			HNFFHCLNBDN().SetFloat("ENABLE_EYE_ADAPTATION", FadeFX);
			MHBAIEKFBIJ().SetFloat("_TimeX", _Size);
			KLKILLCHJHO().SetFloat("_Near", _Dist);
			DOMEEFLPEPJ().SetFloat("???", _Smooth);
			HNFFHCLNBDN().SetVector("[Left]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1159f, 744f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			MHBAIEKFBIJ().SetFloat("SetSunDirectionVector", HBJJOCHGOPH);
			HNFFHCLNBDN().SetFloat("_ScreenResolution", PLKFKNHPEHE[0] / 443f);
			KLKILLCHJHO().SetFloat("PunSupportLogger", PLKFKNHPEHE[0] / 781f);
			LDNADDJMIPK().SetFloat("_ScreenResolution", PLKFKNHPEHE[7] / 81f);
			KJMECMIGJJA().SetFloat("[EditorEvent] Exception: ", PLKFKNHPEHE[3] / 824f);
			OCMBHMLNCEK().SetFloat("_Value4", PLKFKNHPEHE[0] / 336f);
			MNLKBFFKHIE().SetFloat("catched: ", PLKFKNHPEHE[3] / 1272f);
			NJDIODJNGGA().SetFloat("_TimeX", PLKFKNHPEHE[6] / 494f);
			MCDGIILBNIF().SetFloat("color", PLKFKNHPEHE[8] / 1133f);
			DKNJGHFLAIF().SetFloat("CameraFilterPack_VHS1", PLKFKNHPEHE[6] / 1117f);
			MNLKBFFKHIE().SetFloat("_ScreenResolution", PLKFKNHPEHE[31] / 1362f);
			KOHGPKOFEJO().SetFloat("Gameplay/particles", PLKFKNHPEHE[-108] / 1874f);
			DIOAAHJDMLK().SetFloat("player.redarc", PLKFKNHPEHE[62] / 202f);
			KJMECMIGJJA().SetFloat("close", FadeFX);
			DKNJGHFLAIF().SetFloat("_TimeX", _Size);
			KLKILLCHJHO().SetFloat("mapselector.filter.favoriteonly", _Dist);
			NBPKMLMCHFN.SetFloat(" not exist", _Smooth);
			MCDGIILBNIF().SetVector("SfxVolumeSlider", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 974f, 127f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK());
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
			DKNJGHFLAIF().SetFloat("#yes", HBJJOCHGOPH);
			DOMEEFLPEPJ().SetFloat("other.dust2", PLKFKNHPEHE[0] / 423f);
			KOHGPKOFEJO().SetFloat("_MainTex", PLKFKNHPEHE[1] / 381f);
			HNFFHCLNBDN().SetFloat("SetSatelliteTrailWidth", PLKFKNHPEHE[0] / 617f);
			MCDGIILBNIF().SetFloat("SingleplayerButton", PLKFKNHPEHE[0] / 1529f);
			MCDGIILBNIF().SetFloat("[PlayerController] ", PLKFKNHPEHE[7] / 1788f);
			MCDGIILBNIF().SetFloat("[PlayerController] ", PLKFKNHPEHE[0] / 1968f);
			LDNADDJMIPK().SetFloat(".played", PLKFKNHPEHE[5] / 1598f);
			LDNADDJMIPK().SetFloat("yes", PLKFKNHPEHE[2] / 898f);
			CECICEGFHKL().SetFloat("PLEASE WAIT", PLKFKNHPEHE[4] / 1826f);
			MHBAIEKFBIJ().SetFloat("Set Crosshair Emission", PLKFKNHPEHE[80] / 511f);
			HNFFHCLNBDN().SetFloat("#forever", PLKFKNHPEHE[-78] / 1424f);
			DOMEEFLPEPJ().SetFloat("B:", PLKFKNHPEHE[32] / 1630f);
			HNFFHCLNBDN().SetFloat("FavoriteButton", FadeFX);
			HEHKGPKLAKK().SetFloat("Moved event", _Size);
			MCDGIILBNIF().SetFloat(".completedCount", _Dist);
			HEHKGPKLAKK().SetFloat("#md5submitionfailed: ", _Smooth);
			NBPKMLMCHFN.SetVector("_Green_B", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 848f, 1285f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
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
			DKNJGHFLAIF().SetFloat("_DepthLevel", HBJJOCHGOPH);
			HNFFHCLNBDN().SetFloat("_TimeX", PLKFKNHPEHE[1] / 1989f);
			KOHGPKOFEJO().SetFloat("_Green_B", PLKFKNHPEHE[0] / 896f);
			ABHDNGIHBKE().SetFloat("_Value3", PLKFKNHPEHE[4] / 220f);
			KLKILLCHJHO().SetFloat("896296812", PLKFKNHPEHE[4] / 1658f);
			KJMECMIGJJA().SetFloat("_NeighborMaxTex", PLKFKNHPEHE[3] / 339f);
			HEHKGPKLAKK().SetFloat("SetSatelliteTrailWidth", PLKFKNHPEHE[2] / 258f);
			CECICEGFHKL().SetFloat("player.xp", PLKFKNHPEHE[2] / 1723f);
			HNFFHCLNBDN().SetFloat("JoinRandom failed: {0}.", PLKFKNHPEHE[3] / 1042f);
			NBPKMLMCHFN.SetFloat("AudioSampler", PLKFKNHPEHE[1] / 1330f);
			DIOAAHJDMLK().SetFloat("_ScreenResolution", PLKFKNHPEHE[76] / 192f);
			MNLKBFFKHIE().SetFloat("_SpotSize", PLKFKNHPEHE[22] / 1696f);
			CFEDGDGBCHE().SetFloat("color", PLKFKNHPEHE[51] / 1464f);
			CFEDGDGBCHE().SetFloat("Image", FadeFX);
			CECICEGFHKL().SetFloat("System.String", _Size);
			DIOAAHJDMLK().SetFloat("Edited event", _Dist);
			NMDBCDFPGOK().SetFloat("_Value", _Smooth);
			DKNJGHFLAIF().SetVector("Source: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 616f, 516f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KLKILLCHJHO());
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
			NMDBCDFPGOK().SetFloat("offsets", HBJJOCHGOPH);
			CECICEGFHKL().SetFloat("https://bitbucket.org/khb-soft/intralismarcsviewer/", PLKFKNHPEHE[1] / 291f);
			LDNADDJMIPK().SetFloat("shader.frost", PLKFKNHPEHE[1] / 1155f);
			DKNJGHFLAIF().SetFloat("USE_DIAG_SEARCH", PLKFKNHPEHE[1] / 1666f);
			MHBAIEKFBIJ().SetFloat("_Value1", PLKFKNHPEHE[0] / 389f);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", PLKFKNHPEHE[0] / 8f);
			ABHDNGIHBKE().SetFloat("RedoButton", PLKFKNHPEHE[5] / 1793f);
			KOHGPKOFEJO().SetFloat("_Far", PLKFKNHPEHE[4] / 1435f);
			MCDGIILBNIF().SetFloat("CameraFilterPack_AAA_Blood2", PLKFKNHPEHE[2] / 1639f);
			KOHGPKOFEJO().SetFloat("_FixDistance", PLKFKNHPEHE[3] / 272f);
			CFEDGDGBCHE().SetFloat(",", PLKFKNHPEHE[-125] / 232f);
			NJDIODJNGGA().SetFloat("CameraFilterPack/Colors_DarkColor", PLKFKNHPEHE[13] / 1710f);
			HEHKGPKLAKK().SetFloat("CameraMovementSlider", PLKFKNHPEHE[14] / 1069f);
			HEHKGPKLAKK().SetFloat("Xbox Home", FadeFX);
			MNLKBFFKHIE().SetFloat("\\", _Size);
			MNLKBFFKHIE().SetFloat("Case-Sensitive", _Dist);
			KOHGPKOFEJO().SetFloat("move", _Smooth);
			MCDGIILBNIF().SetVector("JoinTeam was called in state: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1911f, 327f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
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
		GOCIGGGHANF();
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
			OCMBHMLNCEK().SetFloat("note.2", HBJJOCHGOPH);
			DIOAAHJDMLK().SetFloat("ConnectUsingSettings() failed. Can only connect while in state 'Disconnected'. Current state: ", PLKFKNHPEHE[1] / 1470f);
			HEHKGPKLAKK().SetFloat("LevelEditor/CustomEventEditor-", PLKFKNHPEHE[1] / 1868f);
			NMDBCDFPGOK().SetFloat("_Luminance", PLKFKNHPEHE[2] / 1555f);
			KLKILLCHJHO().SetFloat("_TimeX", PLKFKNHPEHE[4] / 976f);
			OCMBHMLNCEK().SetFloat("_Value5", PLKFKNHPEHE[5] / 707f);
			HNFFHCLNBDN().SetFloat("Best region found in PlayerPrefs. Connecting to: ", PLKFKNHPEHE[2] / 1163f);
			KLKILLCHJHO().SetFloat("Set Particles Speed", PLKFKNHPEHE[5] / 113f);
			DKNJGHFLAIF().SetFloat("Show text at the center of the screen. Usefull for quick messages like 'Thanks for playing!'", PLKFKNHPEHE[0] / 1202f);
			DOMEEFLPEPJ().SetFloat("_NoiseTex", PLKFKNHPEHE[3] / 932f);
			LDNADDJMIPK().SetFloat("EditMenu", PLKFKNHPEHE[-21] / 472f);
			KOHGPKOFEJO().SetFloat("[Left]", PLKFKNHPEHE[76] / 296f);
			DKNJGHFLAIF().SetFloat("CameraFilterPack/3D_Scan_Scene", PLKFKNHPEHE[-108] / 1107f);
			NMDBCDFPGOK().SetFloat("_Value2", FadeFX);
			NMDBCDFPGOK().SetFloat("BadgeText", _Size);
			DKNJGHFLAIF().SetFloat("_Distortion2", _Dist);
			KOHGPKOFEJO().SetFloat("LevelInfoInputField", _Smooth);
			HEHKGPKLAKK().SetVector("Network destroy Instantiated GO: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 405f, 1150f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DIOAAHJDMLK());
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
		JGMPDINHNKD();
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
		KNLDBHHKFPF();
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
		KOFOBHNODCH();
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
			KOHGPKOFEJO().SetFloat("_TimeX", HBJJOCHGOPH);
			CECICEGFHKL().SetFloat("Hex value #RRGGBB", PLKFKNHPEHE[1] / 642f);
			CFEDGDGBCHE().SetFloat("PlayButton", PLKFKNHPEHE[1] / 1949f);
			KJMECMIGJJA().SetFloat("[NetworkManager] Updating current room...", PLKFKNHPEHE[0] / 1064f);
			DOMEEFLPEPJ().SetFloat("Sequence contains no elements", PLKFKNHPEHE[6] / 1611f);
			DIOAAHJDMLK().SetFloat("SelectorMusicToggle", PLKFKNHPEHE[3] / 73f);
			NMDBCDFPGOK().SetFloat(". Check if the server is available.", PLKFKNHPEHE[6] / 1741f);
			MHBAIEKFBIJ().SetFloat("[PlayerController] ", PLKFKNHPEHE[1] / 208f);
			MHBAIEKFBIJ().SetFloat("menu.relaxinfo", PLKFKNHPEHE[3] / 1060f);
			CFEDGDGBCHE().SetFloat("_RgbTex", PLKFKNHPEHE[0] / 859f);
			MNLKBFFKHIE().SetFloat("[MapsData] Workshop maps was loaded", PLKFKNHPEHE[-117] / 1203f);
			DKNJGHFLAIF().SetFloat("z", PLKFKNHPEHE[-20] / 43f);
			ABHDNGIHBKE().SetFloat("shader.frost", PLKFKNHPEHE[-93] / 1813f);
			NJDIODJNGGA().SetFloat("mapselector.tags.", FadeFX);
			DKNJGHFLAIF().SetFloat("Created", _Size);
			DIOAAHJDMLK().SetFloat("file://", _Dist);
			CFEDGDGBCHE().SetFloat("#FFFFFFFF", _Smooth);
			MHBAIEKFBIJ().SetVector("_SizeY", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1130f, 18f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNFFHCLNBDN());
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
			OCMBHMLNCEK().SetFloat("_Value2", HBJJOCHGOPH);
			LDNADDJMIPK().SetFloat("_VelocityScale", PLKFKNHPEHE[1] / 92f);
			MCDGIILBNIF().SetFloat("_FresnelFade", PLKFKNHPEHE[0] / 274f);
			DIOAAHJDMLK().SetFloat("/", PLKFKNHPEHE[2] / 347f);
			NBPKMLMCHFN.SetFloat(":", PLKFKNHPEHE[7] / 168f);
			KJMECMIGJJA().SetFloat("_Value2", PLKFKNHPEHE[4] / 877f);
			NJDIODJNGGA().SetFloat("[NetworkManager] Connected to ", PLKFKNHPEHE[0] / 1218f);
			NMDBCDFPGOK().SetFloat("id", PLKFKNHPEHE[1] / 1256f);
			MCDGIILBNIF().SetFloat("_Value", PLKFKNHPEHE[0] / 707f);
			HNFFHCLNBDN().SetFloat("Offline or in OfflineMode. No VitalStats available.", PLKFKNHPEHE[5] / 1591f);
			CFEDGDGBCHE().SetFloat("#score", PLKFKNHPEHE[51] / 1500f);
			KOHGPKOFEJO().SetFloat("SubmitUserVote:", PLKFKNHPEHE[127] / 932f);
			DIOAAHJDMLK().SetFloat(" not exist", PLKFKNHPEHE[-100] / 80f);
			KLKILLCHJHO().SetFloat("[NetworkMenu] Joining ", FadeFX);
			NMDBCDFPGOK().SetFloat("achievements.21.progress", _Size);
			DOMEEFLPEPJ().SetFloat("LevelFolderInputField", _Dist);
			ABHDNGIHBKE().SetFloat("Loading", _Smooth);
			KLKILLCHJHO().SetVector("MenuScene", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 910f, 946f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
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
			ABHDNGIHBKE().SetFloat("_Intensity", HBJJOCHGOPH);
			KLKILLCHJHO().SetFloat("CameraFilterPack/TV_CompressionFX", PLKFKNHPEHE[1] / 360f);
			CECICEGFHKL().SetFloat(" Server: ", PLKFKNHPEHE[0] / 1716f);
			MCDGIILBNIF().SetFloat("CameraFilterPack/BlurTiltShift_V", PLKFKNHPEHE[8] / 417f);
			CFEDGDGBCHE().SetFloat("_Offsets", PLKFKNHPEHE[8] / 85f);
			KJMECMIGJJA().SetFloat("#pleasewait", PLKFKNHPEHE[6] / 1096f);
			MHBAIEKFBIJ().SetFloat("_Value", PLKFKNHPEHE[5] / 595f);
			HNFFHCLNBDN().SetFloat("offsets", PLKFKNHPEHE[6] / 475f);
			CFEDGDGBCHE().SetFloat("_Light", PLKFKNHPEHE[6] / 296f);
			MNLKBFFKHIE().SetFloat("_ScreenResolution", PLKFKNHPEHE[5] / 2f);
			MCDGIILBNIF().SetFloat("_RampTex", PLKFKNHPEHE[111] / 889f);
			KOHGPKOFEJO().SetFloat("_Near", PLKFKNHPEHE[-35] / 808f);
			CECICEGFHKL().SetFloat("Set sun colors", PLKFKNHPEHE[90] / 770f);
			CFEDGDGBCHE().SetFloat("Please attach component to a Graphical UI component", FadeFX);
			NJDIODJNGGA().SetFloat("CameraFilterPack/Glasses_On", _Size);
			DIOAAHJDMLK().SetFloat("JoinButton", _Dist);
			KLKILLCHJHO().SetFloat("/", _Smooth);
			MCDGIILBNIF().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 940f, 538f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NJDIODJNGGA());
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
		MGGFMCIGOAF();
	}
}
