// CameraFilterPack_Blend2Camera_BlueScreen
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Chroma Key/BlueScreen")]
[ExecuteInEditMode]
public class CameraFilterPack_Blend2Camera_BlueScreen : MonoBehaviour
{
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_BlueScreen";

	public Shader SCShader;

	public Camera Camera2;

	private float HBJJOCHGOPH = 1f;

	private Material BJFKDHHMLJH;

	[Range(0f, 1f)]
	public float BlendFX = 1f;

	[Range(-0.2f, 0.2f)]
	public float Adjust;

	[Range(-0.2f, 0.2f)]
	public float Precision;

	[Range(-0.2f, 0.2f)]
	public float Luminosity;

	[Range(-0.3f, 0.3f)]
	public float Change_Red;

	[Range(-0.3f, 0.3f)]
	public float Change_Green;

	[Range(-0.3f, 0.3f)]
	public float Change_Blue;

	private RenderTexture JDMCFBKJHDD;

	private Vector2 FPEMMGKMJGA;

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

	private void Update()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void ANKALNDLHEL()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void PHJLHCMCCKE()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EIMNPCMHJLJ()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -39);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HIFLPHLGLFG()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void DGCGGKMNPLD()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void MLAGEPNCCGM()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void EBBMDDEFNKL()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void FNGDOKOAKLA()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void JGDCNDNCFNG()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void OnEnable()
	{
		Start();
	}

	private void EAHCLIEEJOG()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GFELOCODMPJ()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void HMPGIFBJFIK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -116);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DOOIKOEBBJB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 508f)
			{
				HBJJOCHGOPH = 1326f;
			}
			if (Camera2 != null)
			{
				ADGHJOHKEHG().SetTexture("maps.", JDMCFBKJHDD);
			}
			OLHDPICFBOF().SetFloat("[Down]", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("PopulateMapsList", BlendFX);
			DKKBFFHBHJE().SetFloat("SetParent", Adjust);
			DKKBFFHBHJE().SetFloat("_XCrop", Precision);
			NLFJGMBCICG().SetFloat("player.quantum", Luminosity);
			IFMAPIDFNLI().SetFloat("[MapEditor] Created new map: ", Change_Red);
			OLHDPICFBOF().SetFloat("init", Change_Green);
			DKKBFFHBHJE().SetFloat("maps.", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FGIOPGGPLMB()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 813f)
			{
				HBJJOCHGOPH = 1656f;
			}
			if (Camera2 != null)
			{
				HKIMAANBGMJ().SetTexture(". The RPC has been ignored.", JDMCFBKJHDD);
			}
			NFKFAAHHLLM().SetFloat(" = ", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("_QualitySettings", BlendFX);
			KJMECMIGJJA().SetFloat("_TimeX", Adjust);
			OLHDPICFBOF().SetFloat("/", Precision);
			NLFJGMBCICG().SetFloat("12", Luminosity);
			FLOHGDECHHH().SetFloat("SetSatelliteLerpSpeed", Change_Red);
			OLHDPICFBOF().SetFloat(" SecondsBeforeRespawn: ", Change_Green);
			IIJMIPBMMBF().SetFloat("[Up-Left]", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PKLOBJHKFEO()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -40);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PCGODOELOHG()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void MEJPBKFMAIG()
	{
		KNBJBNDGCIJ();
	}

	private void IEMEHGCFAPD()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void MMBPLGGLPDB()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void HIFPDKKBDHJ()
	{
		MMMDPANNAIO();
	}

	private void FKDEEJFNNJC()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LKJMIODJGCM()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 836f)
			{
				HBJJOCHGOPH = 596f;
			}
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture("Set Object Rotation", JDMCFBKJHDD);
			}
			HKIMAANBGMJ().SetFloat("SetCrosshairEmission", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat("CameraFilterPack_RainFX_Anm", BlendFX);
			LPCHMEKDCHI().SetFloat("LevelConfigButton", Adjust);
			IFMAPIDFNLI().SetFloat("YES", Precision);
			ADGHJOHKEHG().SetFloat("_Value2", Luminosity);
			DKKBFFHBHJE().SetFloat("OperationResponse unhandled: {0}", Change_Red);
			DKKBFFHBHJE().SetFloat("#yes", Change_Green);
			LPCHMEKDCHI().SetFloat("float,2", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JLNNHKPHMAB()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-112);
		}
		return BJFKDHHMLJH;
	}

	private void IBHACCEEFFI()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void FBPHNEJBDJN()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 126);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void APKNAPHOFHC()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void IFIHBNJKEKD()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MMOKKAPFGAK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 21);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NGEGCLCPPCD()
	{
		DNNFHBOOPIN();
	}

	private void KLOLKEBAPFO()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1376f)
			{
				HBJJOCHGOPH = 1651f;
			}
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture("HH:mm:ss", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat("gold", HBJJOCHGOPH);
			HKIMAANBGMJ().SetFloat(" ", BlendFX);
			FLOHGDECHHH().SetFloat("_BlurArea", Adjust);
			HKIMAANBGMJ().SetFloat("Right", Precision);
			NFKFAAHHLLM().SetFloat("speed", Luminosity);
			IFMAPIDFNLI().SetFloat("Data/Maps/", Change_Red);
			NFKFAAHHLLM().SetFloat("&", Change_Green);
			NFKFAAHHLLM().SetFloat("#", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material NLFJGMBCICG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void KCGJMAFGAGH()
	{
		MMMDPANNAIO();
	}

	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 836f)
			{
				HBJJOCHGOPH = 1178f;
			}
			if (Camera2 != null)
			{
				HKIMAANBGMJ().SetTexture("_TimeX", JDMCFBKJHDD);
			}
			ADGHJOHKEHG().SetFloat("LevelConfigButton", HBJJOCHGOPH);
			HKIMAANBGMJ().SetFloat("_ScreenResolution", BlendFX);
			NFKFAAHHLLM().SetFloat("Fade", Adjust);
			DKKBFFHBHJE().SetFloat("menu.selectedplaymode", Precision);
			NBPKMLMCHFN.SetFloat("|", Luminosity);
			HKIMAANBGMJ().SetFloat("CheckResources () for ", Change_Red);
			IIJMIPBMMBF().SetFloat("setstring", Change_Green);
			IONHGBPGCHK().SetFloat("_Value2", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material IFMAPIDFNLI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material ADGHJOHKEHG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
		}
		return BJFKDHHMLJH;
	}

	private void OCMKCBBCEFG()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	[SpecialName]
	private Material HKIMAANBGMJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void KPLKDJFKPDI()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void FDIJLKIIMLL()
	{
		BEBNOKFLJPH();
	}

	private void OnValidate()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	[SpecialName]
	private Material NFKFAAHHLLM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)74;
		}
		return BJFKDHHMLJH;
	}

	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1527f)
			{
				HBJJOCHGOPH = 1909f;
			}
			if (Camera2 != null)
			{
				NFKFAAHHLLM().SetTexture("_Factor", JDMCFBKJHDD);
			}
			IONHGBPGCHK().SetFloat("_TimeX", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("accuracy", BlendFX);
			NBPKMLMCHFN.SetFloat(").png", Adjust);
			ADGHJOHKEHG().SetFloat("#discord{0}joinrequest", Precision);
			ADGHJOHKEHG().SetFloat("CrosshairOpacitySlider", Luminosity);
			NFKFAAHHLLM().SetFloat("_FilteredReflections", Change_Red);
			KJMECMIGJJA().SetFloat("NOISE", Change_Green);
			HKIMAANBGMJ().SetFloat("_ScreenResolution", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material FLOHGDECHHH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-65);
		}
		return BJFKDHHMLJH;
	}

	private void HENBNNAGIKN()
	{
		MMOKKAPFGAK();
	}

	private void MEMKLOMFFJO()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void LINKAMEPKGM()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CNHEENCFCMF()
	{
		EIMNPCMHJLJ();
	}

	private void NEKCPLGFOFD()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void AOKOLPEGHDD()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material DKKBFFHBHJE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)120;
		}
		return BJFKDHHMLJH;
	}

	private void PAKPHKPDKGE()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 4);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LCHBFNIPBHB()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void MBNMADBPDLL()
	{
		PAKPHKPDKGE();
	}

	private void JOONHGHGKKF()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OnDisable()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JOJFHFHOCHO()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GPFJMKCGHGB()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void HIDOPHINPAL()
	{
		MMMDPANNAIO();
	}

	private void HFLHDMPHOJA()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void PNNPDMHLFHE()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MNHCBAKPBCF()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 319f)
			{
				HBJJOCHGOPH = 555f;
			}
			if (Camera2 != null)
			{
				DKKBFFHBHJE().SetTexture("Connected to NameServer.", JDMCFBKJHDD);
			}
			IONHGBPGCHK().SetFloat("ScoreText", HBJJOCHGOPH);
			ADGHJOHKEHG().SetFloat("Lerp speed. Recomended 10", BlendFX);
			OLHDPICFBOF().SetFloat("x", Adjust);
			KJMECMIGJJA().SetFloat(" [", Precision);
			NLFJGMBCICG().SetFloat(" beatThreshold: ", Luminosity);
			IONHGBPGCHK().SetFloat("CameraFilterPack/Blend2Camera_LinearLight", Change_Red);
			DKKBFFHBHJE().SetFloat("Please specify either t or f.", Change_Green);
			ADGHJOHKEHG().SetFloat("[", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JOACBIEHHCE()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void OMIHEBMMCPG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1896f)
			{
				HBJJOCHGOPH = 1790f;
			}
			if (Camera2 != null)
			{
				KJMECMIGJJA().SetTexture("_Value2", JDMCFBKJHDD);
			}
			OLHDPICFBOF().SetFloat("CameraFilterPack/TV_WideScreenHorizontal", HBJJOCHGOPH);
			NFKFAAHHLLM().SetFloat("inventory.selected.", BlendFX);
			LPCHMEKDCHI().SetFloat("_MatrixSpeed", Adjust);
			IFMAPIDFNLI().SetFloat("_BlurDistance", Precision);
			IONHGBPGCHK().SetFloat("SubmitUserVote:", Luminosity);
			HKIMAANBGMJ().SetFloat("CameraFilterPack/FX_Hexagon_Black", Change_Red);
			NFKFAAHHLLM().SetFloat("_Radius", Change_Green);
			HKIMAANBGMJ().SetFloat("_Value", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AAPMAEFHKEO()
	{
		FEKECCBFGMI();
	}

	private void FEKECCBFGMI()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -71);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BDBKIEIIFPB()
	{
		MMOKKAPFGAK();
	}

	private void LAMEHAHJKMI()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 957f)
			{
				HBJJOCHGOPH = 635f;
			}
			if (Camera2 != null)
			{
				IONHGBPGCHK().SetTexture(".message", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat("Object ID. Case-Sensitive", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat("_AlphaHexa", BlendFX);
			NFKFAAHHLLM().SetFloat("player.mysteryitem", Adjust);
			IIJMIPBMMBF().SetFloat("Joystick1Button0", Precision);
			DKKBFFHBHJE().SetFloat("CameraFilterPack/Broken_Screen", Luminosity);
			KJMECMIGJJA().SetFloat("LevelURLInputField", Change_Red);
			IONHGBPGCHK().SetFloat("_Value", Change_Green);
			NLFJGMBCICG().SetFloat("CameraFilterPack/Color_Invert", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DNCADKIOEEG()
	{
		HMPGIFBJFIK();
	}

	private void DNNFHBOOPIN()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -45);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void Start()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 24);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HOLDCFBBHHP()
	{
		FIJHDKIPENG();
	}

	private void GLKJFIOCPLF()
	{
		FEKECCBFGMI();
	}

	[SpecialName]
	private Material LPCHMEKDCHI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)104;
		}
		return BJFKDHHMLJH;
	}

	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1442f)
			{
				HBJJOCHGOPH = 1560f;
			}
			if (Camera2 != null)
			{
				KJMECMIGJJA().SetTexture("maps.", JDMCFBKJHDD);
			}
			NFKFAAHHLLM().SetFloat("CameraFilterPack/FX_InverChromiLum", HBJJOCHGOPH);
			LPCHMEKDCHI().SetFloat("CameraFilterPack/TV_Video3D", BlendFX);
			IONHGBPGCHK().SetFloat("Error calling OpAuthenticate! Did not work. Check log output, AuthValues and if you're connected.", Adjust);
			NBPKMLMCHFN.SetFloat("ready", Precision);
			FLOHGDECHHH().SetFloat("R:", Luminosity);
			IONHGBPGCHK().SetFloat("Attempting to remove texture that was not allocated: {0}", Change_Red);
			HKIMAANBGMJ().SetFloat("#8E8E8EFF", Change_Green);
			LPCHMEKDCHI().SetFloat("_SpotSize", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material OLHDPICFBOF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void KFACDBHDAOD()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void MFOOCOIIIJN()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void DBLILJGKGHJ()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 18);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GJLKJAOBPJD()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LBAJLLFMMMP()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -48);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KLILJHJNICK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -26);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MMMDPANNAIO()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -49);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1657f)
			{
				HBJJOCHGOPH = 1661f;
			}
			if (Camera2 != null)
			{
				ADGHJOHKEHG().SetTexture("_HueShift", JDMCFBKJHDD);
			}
			IFMAPIDFNLI().SetFloat("[PlayerController] ", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat(":", BlendFX);
			NBPKMLMCHFN.SetFloat("SendVacantViewIds()", Adjust);
			DKKBFFHBHJE().SetFloat("SetScale", Precision);
			NLFJGMBCICG().SetFloat("on master", Luminosity);
			KJMECMIGJJA().SetFloat("[PlayerController] ", Change_Red);
			LPCHMEKDCHI().SetFloat(" ", Change_Green);
			IONHGBPGCHK().SetFloat("player.goldcrystal", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LKPBGHGCPKL()
	{
		MMMDPANNAIO();
	}

	private void MHGPANIBBCM()
	{
		FEKECCBFGMI();
	}

	private void OFMNDBNFBDJ()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FAKGFMFAPDG()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void HCIPECAOGIA()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void NNFMIAFHMJM()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 9);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material IIJMIPBMMBF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-72);
		}
		return BJFKDHHMLJH;
	}

	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1028f)
			{
				HBJJOCHGOPH = 1567f;
			}
			if (Camera2 != null)
			{
				OLHDPICFBOF().SetTexture("No Name", JDMCFBKJHDD);
			}
			IIJMIPBMMBF().SetFloat("_Value3", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("_Fade", BlendFX);
			IIJMIPBMMBF().SetFloat("CrosshairOpacitySlider", Adjust);
			DKKBFFHBHJE().SetFloat("Joystick", Precision);
			IIJMIPBMMBF().SetFloat("Joystick1Button9", Luminosity);
			LPCHMEKDCHI().SetFloat("settings.arcshitsoundtimedelay", Change_Red);
			NBPKMLMCHFN.SetFloat("_PositionY", Change_Green);
			KJMECMIGJJA().SetFloat("#scoresubmitionfailed: ", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 911f)
			{
				HBJJOCHGOPH = 1238f;
			}
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture("New resource ID. Case-Sensitive", JDMCFBKJHDD);
			}
			HKIMAANBGMJ().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("max. lives color", BlendFX);
			IIJMIPBMMBF().SetFloat("#tryagain", Adjust);
			NLFJGMBCICG().SetFloat("scn", Precision);
			IONHGBPGCHK().SetFloat("UseFinalGlassColor", Luminosity);
			NLFJGMBCICG().SetFloat("(singleton) ", Change_Red);
			FLOHGDECHHH().SetFloat("ControllerLeftX", Change_Green);
			NBPKMLMCHFN.SetFloat("value", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AMIMHHGLPIN()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1992f)
			{
				HBJJOCHGOPH = 291f;
			}
			if (Camera2 != null)
			{
				ADGHJOHKEHG().SetTexture("_Near", JDMCFBKJHDD);
			}
			IFMAPIDFNLI().SetFloat("CameraFilterPack/TV_WideScreenHV", HBJJOCHGOPH);
			OLHDPICFBOF().SetFloat("_Value2", BlendFX);
			IIJMIPBMMBF().SetFloat("SetCrosshairColor", Adjust);
			LPCHMEKDCHI().SetFloat("Items/", Precision);
			HKIMAANBGMJ().SetFloat("UseScanLine", Luminosity);
			KJMECMIGJJA().SetFloat("_Red_C", Change_Red);
			NLFJGMBCICG().SetFloat("_MainTexBlurred", Change_Green);
			DKKBFFHBHJE().SetFloat("Currently, the limit of users is reached for this title. Try again later. Disconnecting", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CNDACAHCCOI()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KNBJBNDGCIJ()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 122);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
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
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture("_MainTex2", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat("_TimeX", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value", BlendFX);
			NBPKMLMCHFN.SetFloat("_Value2", Adjust);
			NBPKMLMCHFN.SetFloat("_Value3", Precision);
			NBPKMLMCHFN.SetFloat("_Value4", Luminosity);
			NBPKMLMCHFN.SetFloat("_Value5", Change_Red);
			NBPKMLMCHFN.SetFloat("_Value6", Change_Green);
			NBPKMLMCHFN.SetFloat("_Value7", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BFEILOMHNPC()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FIJHDKIPENG()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 63);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 305f)
			{
				HBJJOCHGOPH = 540f;
			}
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture("PhotonView register is ignored, because viewID is 0. No id assigned yet to: ", JDMCFBKJHDD);
			}
			NLFJGMBCICG().SetFloat("_TimeX", HBJJOCHGOPH);
			LPCHMEKDCHI().SetFloat("float,1.5", BlendFX);
			NFKFAAHHLLM().SetFloat("AVG Misses:", Adjust);
			LPCHMEKDCHI().SetFloat("player.orangelifering", Precision);
			ADGHJOHKEHG().SetFloat("<command>", Luminosity);
			IONHGBPGCHK().SetFloat("Save level before uploading?", Change_Red);
			KJMECMIGJJA().SetFloat("1", Change_Green);
			NLFJGMBCICG().SetFloat("_FullResolutionFiltering", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DGEPPDJDBLN()
	{
		LBAJLLFMMMP();
	}

	private void GNMGIHFKJIJ()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BEBNOKFLJPH()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -55);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
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
			if (HBJJOCHGOPH > 671f)
			{
				HBJJOCHGOPH = 1112f;
			}
			if (Camera2 != null)
			{
				NFKFAAHHLLM().SetTexture("IDInputField", JDMCFBKJHDD);
			}
			KJMECMIGJJA().SetFloat("steamid", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("Set Satellite Trail Width", BlendFX);
			OLHDPICFBOF().SetFloat("curScn", Adjust);
			IFMAPIDFNLI().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", Precision);
			NFKFAAHHLLM().SetFloat("Delete events", Luminosity);
			KJMECMIGJJA().SetFloat("[LevelEditorScene] Error: Timeout :S", Change_Red);
			LPCHMEKDCHI().SetFloat("#", Change_Green);
			LPCHMEKDCHI().SetFloat("PUNCloudBestRegion", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OFIMMFHFHDD()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PKNJBBDKJFK()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	[SpecialName]
	private Material KJMECMIGJJA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1092f)
			{
				HBJJOCHGOPH = 783f;
			}
			if (Camera2 != null)
			{
				KJMECMIGJJA().SetTexture("ControllerLeftX", JDMCFBKJHDD);
			}
			KJMECMIGJJA().SetFloat("|", HBJJOCHGOPH);
			ADGHJOHKEHG().SetFloat("(\\[ *i *\\])", BlendFX);
			FLOHGDECHHH().SetFloat("Jit ", Adjust);
			HKIMAANBGMJ().SetFloat("LeaderboardsButton", Precision);
			NFKFAAHHLLM().SetFloat("Set Parent", Luminosity);
			IIJMIPBMMBF().SetFloat("Cannot remove cached RPCs on a PhotonView thats not ours! ", Change_Red);
			NLFJGMBCICG().SetFloat("_Value4", Change_Green);
			IONHGBPGCHK().SetFloat("Tab2Content", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CCLNNLCOPBL()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -3);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NPBDIMJDMGA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1734f)
			{
				HBJJOCHGOPH = 1234f;
			}
			if (Camera2 != null)
			{
				HKIMAANBGMJ().SetTexture("_ScreenResolution", JDMCFBKJHDD);
			}
			FLOHGDECHHH().SetFloat("{0}{1}:{2}", HBJJOCHGOPH);
			NFKFAAHHLLM().SetFloat("player.xp", BlendFX);
			DKKBFFHBHJE().SetFloat("Intensity", Adjust);
			NBPKMLMCHFN.SetFloat("settings.volume.game", Precision);
			DKKBFFHBHJE().SetFloat("pointBuffer", Luminosity);
			DKKBFFHBHJE().SetFloat("HightScoreMaxPointsText", Change_Red);
			NFKFAAHHLLM().SetFloat("Deleted event", Change_Green);
			IFMAPIDFNLI().SetFloat("_Value3", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
