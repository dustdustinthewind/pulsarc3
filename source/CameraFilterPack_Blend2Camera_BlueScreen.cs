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
				NFKFAAHHLLM().SetTexture("maps.", JDMCFBKJHDD);
			}
			NLFJGMBCICG().SetFloat("[Up]", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("mapselector.lastSearch", BlendFX);
			NBPKMLMCHFN.SetFloat("SetSunMinSize", Adjust);
			HKIMAANBGMJ().SetFloat("Default UI Material", Precision);
			NFKFAAHHLLM().SetFloat("player.rgb", Luminosity);
			IFMAPIDFNLI().SetFloat("Editor/", Change_Red);
			LPCHMEKDCHI().SetFloat("Bad parameters for init! Use \"init\" or \"init <savename>\"", Change_Green);
			OLHDPICFBOF().SetFloat("maps.", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
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
				ADGHJOHKEHG().SetTexture("Received RPC: ", JDMCFBKJHDD);
			}
			ADGHJOHKEHG().SetFloat("[LocalizationService] Error: ", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Hidden/Subpixel Morphological Anti-aliasing", BlendFX);
			FLOHGDECHHH().SetFloat("_OnOff", Adjust);
			KJMECMIGJJA().SetFloat("/", Precision);
			IONHGBPGCHK().SetFloat("3", Luminosity);
			NLFJGMBCICG().SetFloat("SetSatelliteLerpSpeed", Change_Red);
			DKKBFFHBHJE().SetFloat("mine", Change_Green);
			NLFJGMBCICG().SetFloat("[Up-Left]", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPCHMEKDCHI());
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
		FBPHNEJBDJN();
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
		FIJHDKIPENG();
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
				OLHDPICFBOF().SetTexture("Set Object Rotation", JDMCFBKJHDD);
			}
			ADGHJOHKEHG().SetFloat("SetParticlesGravity", HBJJOCHGOPH);
			ADGHJOHKEHG().SetFloat("CameraFilterPack/RainFX", BlendFX);
			FLOHGDECHHH().SetFloat("LevelConfigButton", Adjust);
			FLOHGDECHHH().SetFloat("YES", Precision);
			NLFJGMBCICG().SetFloat("_Value3", Luminosity);
			NBPKMLMCHFN.SetFloat("Connected to NameServer.", Change_Red);
			IFMAPIDFNLI().SetFloat("[MapsEditor] Creating new item...", Change_Green);
			IIJMIPBMMBF().SetFloat("Set satellite radius (offset)", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
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
		Start();
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
				HKIMAANBGMJ().SetTexture("] ", JDMCFBKJHDD);
			}
			NLFJGMBCICG().SetFloat("red", HBJJOCHGOPH);
			LPCHMEKDCHI().SetFloat("%", BlendFX);
			IIJMIPBMMBF().SetFloat("_RangeScale", Adjust);
			KJMECMIGJJA().SetFloat("Right", Precision);
			IIJMIPBMMBF().SetFloat("Default color's lerp speed of color changing. Greater values means faster changing. 0 - intant change.", Luminosity);
			IONHGBPGCHK().SetFloat(".", Change_Red);
			HKIMAANBGMJ().SetFloat("AuthenticationValues UserId: {0}, GetParameters: {1} Token available: {2}", Change_Green);
			IFMAPIDFNLI().SetFloat("english", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IFMAPIDFNLI());
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
		KLILJHJNICK();
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
				IIJMIPBMMBF().SetTexture("_TimeX", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat("PublishButton", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("_ScreenResolution", BlendFX);
			FLOHGDECHHH().SetFloat("Fade", Adjust);
			FLOHGDECHHH().SetFloat("menu.relaxinfo", Precision);
			NFKFAAHHLLM().SetFloat(" item(s) in inventory", Luminosity);
			KJMECMIGJJA().SetFloat("The image effect ", Change_Red);
			LPCHMEKDCHI().SetFloat("Bad parameters for setstring! Use <key> <value>", Change_Green);
			HKIMAANBGMJ().SetFloat("_Value2", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
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
		KLILJHJNICK();
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
				NLFJGMBCICG().SetTexture("_ScreenResolution", JDMCFBKJHDD);
			}
			ADGHJOHKEHG().SetFloat("_TimeX", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat("misses", BlendFX);
			FLOHGDECHHH().SetFloat("HighScaleShot", Adjust);
			HKIMAANBGMJ().SetFloat("{0}", Precision);
			NBPKMLMCHFN.SetFloat("settings.crosshairopacity", Luminosity);
			NFKFAAHHLLM().SetFloat("_TempTexture", Change_Red);
			LPCHMEKDCHI().SetFloat("Brightness", Change_Green);
			KJMECMIGJJA().SetFloat("_ScreenResolution", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
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
		EIMNPCMHJLJ();
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
		FIJHDKIPENG();
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
		CCLNNLCOPBL();
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
		Start();
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
				HKIMAANBGMJ().SetTexture("Connected to masterserver.", JDMCFBKJHDD);
			}
			NLFJGMBCICG().SetFloat("ScoreText", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("Lerp speed. Recomended 10", BlendFX);
			HKIMAANBGMJ().SetFloat("z", Adjust);
			DKKBFFHBHJE().SetFloat("curScn", Precision);
			FLOHGDECHHH().SetFloat(" beatThreshold: ", Luminosity);
			HKIMAANBGMJ().SetFloat("_MainTex2", Change_Red);
			DKKBFFHBHJE().SetFloat("{0}", Change_Green);
			NFKFAAHHLLM().SetFloat("] ", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPCHMEKDCHI());
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
				FLOHGDECHHH().SetTexture("_ScreenResolution", JDMCFBKJHDD);
			}
			ADGHJOHKEHG().SetFloat("_TimeX", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("LoadingStatusText", BlendFX);
			DKKBFFHBHJE().SetFloat("_MatrixSpeed", Adjust);
			HKIMAANBGMJ().SetFloat("Hidden/LensAberrations", Precision);
			LPCHMEKDCHI().SetFloat("[MapsStats] Map ID: ", Luminosity);
			IFMAPIDFNLI().SetFloat("CameraFilterPack/FX_Hexagon_Black", Change_Red);
			FLOHGDECHHH().SetFloat("_Quality", Change_Green);
			NFKFAAHHLLM().SetFloat("_Value", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AAPMAEFHKEO()
	{
		BEBNOKFLJPH();
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
		LBAJLLFMMMP();
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
			KJMECMIGJJA().SetFloat("value", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("_AlphaHexa", BlendFX);
			IFMAPIDFNLI().SetFloat("player.mysteryitem", Adjust);
			ADGHJOHKEHG().SetFloat("Square", Precision);
			OLHDPICFBOF().SetFloat("_TimeX", Luminosity);
			NLFJGMBCICG().SetFloat("LevelInfoInputField", Change_Red);
			HKIMAANBGMJ().SetFloat("_Value2", Change_Green);
			NBPKMLMCHFN.SetFloat("_TimeX", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DNCADKIOEEG()
	{
		MMOKKAPFGAK();
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
		EIMNPCMHJLJ();
	}

	private void GLKJFIOCPLF()
	{
		FBPHNEJBDJN();
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
				FLOHGDECHHH().SetTexture("[GameEvent] Exeption:", JDMCFBKJHDD);
			}
			OLHDPICFBOF().SetFloat("_TimeX", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("_TimeX", BlendFX);
			IIJMIPBMMBF().SetFloat("Expected protocol set to UDP, due to encryption mode DatagramEncryption. Changing protocol in PhotonServerSettings from: ", Adjust);
			NLFJGMBCICG().SetFloat("ready", Precision);
			IFMAPIDFNLI().SetFloat("B:", Luminosity);
			OLHDPICFBOF().SetFloat("Hidden/DepthOfField/MedianFilter", Change_Red);
			NBPKMLMCHFN.SetFloat("#8E8E8EFF", Change_Green);
			NFKFAAHHLLM().SetFloat("_SpotSize", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
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
				NFKFAAHHLLM().SetTexture("_Sat", JDMCFBKJHDD);
			}
			IONHGBPGCHK().SetFloat(": ", HBJJOCHGOPH);
			ADGHJOHKEHG().SetFloat(":", BlendFX);
			IFMAPIDFNLI().SetFloat("Malformed RPC; this should never occur. Content: ", Adjust);
			IIJMIPBMMBF().SetFloat("SetSunInput", Precision);
			HKIMAANBGMJ().SetFloat("OpCreateRoom()", Luminosity);
			IFMAPIDFNLI().SetFloat(": ", Change_Red);
			FLOHGDECHHH().SetFloat("%", Change_Green);
			HKIMAANBGMJ().SetFloat("shader.crispwinter", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LKPBGHGCPKL()
	{
		NNFMIAFHMJM();
	}

	private void MHGPANIBBCM()
	{
		EIMNPCMHJLJ();
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
				FLOHGDECHHH().SetTexture(", data: ", JDMCFBKJHDD);
			}
			NLFJGMBCICG().SetFloat("_Value3", HBJJOCHGOPH);
			NFKFAAHHLLM().SetFloat("_Fade", BlendFX);
			NBPKMLMCHFN.SetFloat("settings.crosshairopacity", Adjust);
			OLHDPICFBOF().SetFloat("_Value1", Precision);
			DKKBFFHBHJE().SetFloat("Joystick1Button10", Luminosity);
			IIJMIPBMMBF().SetFloat("SelectorMapsCountSlider", Change_Red);
			FLOHGDECHHH().SetFloat("_Distortion", Change_Green);
			ADGHJOHKEHG().SetFloat("#close", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
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
				DKKBFFHBHJE().SetTexture("Switch environment sprite image", JDMCFBKJHDD);
			}
			ADGHJOHKEHG().SetFloat("_Vignette", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Hex value #RRGGBB", BlendFX);
			OLHDPICFBOF().SetFloat("#close", Adjust);
			NBPKMLMCHFN.SetFloat("Connecting", Precision);
			NFKFAAHHLLM().SetFloat("Fade", Luminosity);
			NBPKMLMCHFN.SetFloat("[Singleton] multiple instances of '", Change_Red);
			NFKFAAHHLLM().SetFloat("Backward", Change_Green);
			LPCHMEKDCHI().SetFloat("value", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
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
				IIJMIPBMMBF().SetTexture("_Near", JDMCFBKJHDD);
			}
			DKKBFFHBHJE().SetFloat("_Value", HBJJOCHGOPH);
			HKIMAANBGMJ().SetFloat("_Value2", BlendFX);
			NBPKMLMCHFN.SetFloat("SetParticlesParticleSize", Adjust);
			LPCHMEKDCHI().SetFloat("/config", Precision);
			NFKFAAHHLLM().SetFloat("_MainTex2", Luminosity);
			NLFJGMBCICG().SetFloat("_Red_C", Change_Red);
			HKIMAANBGMJ().SetFloat("threshold", Change_Green);
			DKKBFFHBHJE().SetFloat("Received your UserID from server. Updating local value to: {0}", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
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
				HKIMAANBGMJ().SetTexture("Registered PhotonView: ", JDMCFBKJHDD);
			}
			OLHDPICFBOF().SetFloat("_Distortion", HBJJOCHGOPH);
			NFKFAAHHLLM().SetFloat("float,1.5", BlendFX);
			NFKFAAHHLLM().SetFloat("/?page=ranks", Adjust);
			HKIMAANBGMJ().SetFloat("player.orangelifering", Precision);
			IIJMIPBMMBF().SetFloat("Command not found!", Luminosity);
			IONHGBPGCHK().SetFloat("YES", Change_Red);
			IFMAPIDFNLI().SetFloat("sprite", Change_Green);
			FLOHGDECHHH().SetFloat("_HighlightSuppression", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DGEPPDJDBLN()
	{
		DBLILJGKGHJ();
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
				HKIMAANBGMJ().SetTexture("FileLabel", JDMCFBKJHDD);
			}
			LPCHMEKDCHI().SetFloat("quantity", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("id", BlendFX);
			IFMAPIDFNLI().SetFloat("curScn", Adjust);
			KJMECMIGJJA().SetFloat("Vertical", Precision);
			ADGHJOHKEHG().SetFloat("ShowTitle", Luminosity);
			ADGHJOHKEHG().SetFloat("[LevelEditorScene] Error: I/O Failure! :(", Change_Red);
			NFKFAAHHLLM().SetFloat(" = ", Change_Green);
			NLFJGMBCICG().SetFloat("PUNCloudBestRegion", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLOHGDECHHH());
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
				IFMAPIDFNLI().SetTexture("Backward", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat(" item(s) in inventory", HBJJOCHGOPH);
			HKIMAANBGMJ().SetFloat("(\\[ *i *\\])", BlendFX);
			LPCHMEKDCHI().SetFloat("PhotonMono", Adjust);
			IONHGBPGCHK().SetFloat("FavoriteButton", Precision);
			DKKBFFHBHJE().SetFloat("Set Parent", Luminosity);
			IIJMIPBMMBF().SetFloat(" method: ", Change_Red);
			NFKFAAHHLLM().SetFloat("_Value5", Change_Green);
			LPCHMEKDCHI().SetFloat("Tab2Content", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IFMAPIDFNLI());
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
				NFKFAAHHLLM().SetTexture("CameraFilterPack/Blend2Camera_LinearLight", JDMCFBKJHDD);
			}
			OLHDPICFBOF().SetFloat("ReconnectToMaster() with AuthValues == null is not correct!", HBJJOCHGOPH);
			FLOHGDECHHH().SetFloat("Obtain promo Item", BlendFX);
			IFMAPIDFNLI().SetFloat("Speed", Adjust);
			IONHGBPGCHK().SetFloat("settings.volume.sfx", Precision);
			LPCHMEKDCHI().SetFloat("_Screen", Luminosity);
			LPCHMEKDCHI().SetFloat("HightScoreMaxPointsText", Change_Red);
			HKIMAANBGMJ().SetFloat("BitsData", Change_Green);
			IFMAPIDFNLI().SetFloat("_Value3", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
