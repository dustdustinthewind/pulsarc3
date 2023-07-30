// CameraFilterPack_Distortion_Flag
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Distortion/Flag")]
[ExecuteInEditMode]
public class CameraFilterPack_Distortion_Flag : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	[Range(0f, 2f)]
	public float Distortion = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	public static float ChangeDistortion;

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

	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 569f)
			{
				HBJJOCHGOPH = 1775f;
			}
			HKGAONMOBMH().SetFloat("_Offsets", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat(" ", Distortion);
			ADGHJOHKEHG().SetVector("OK", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JKFDDNMPOJH()
	{
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material MMOODGIODPC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void DAHFFNNIGML()
	{
		SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DKGBFNCOAEO()
	{
		SCShader = Shader.Find("{0:0} second{1}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FABKIGNFECE()
	{
	}

	private void GPNAOAKCMHC()
	{
		SCShader = Shader.Find("ArcsDestroyDelaySlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JBCNIPJDPJB()
	{
	}

	private void FMNPFCHBLJF()
	{
		SCShader = Shader.Find("roomDescription");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 318f)
			{
				HBJJOCHGOPH = 976f;
			}
			HKHBBBFLGJH().SetFloat("menu.selectedplaymode", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("/", Distortion);
			LPMLLJKMAMP().SetVector("_Offsets", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CNGAJDBOCLJ()
	{
		SCShader = Shader.Find("y");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material OKJOKHGJHGF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 190f)
			{
				HBJJOCHGOPH = 1250f;
			}
			HCGJCMDJPGD().SetFloat("_Intensity", HBJJOCHGOPH);
			OKJOKHGJHGF().SetFloat("Misses:", Distortion);
			DKKBFFHBHJE().SetVector("_Value3", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PAKPHKPDKGE()
	{
		SCShader = Shader.Find("_Value7");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GPFJMKCGHGB()
	{
	}

	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 938f)
			{
				HBJJOCHGOPH = 1379f;
			}
			ADBKPGFMNKO().SetFloat("_Value6", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Aug", Distortion);
			LENEJAGLCNL().SetVector("Deleted data", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
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
			if (HBJJOCHGOPH > 995f)
			{
				HBJJOCHGOPH = 921f;
			}
			ADBKPGFMNKO().SetFloat("22x1", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("Encryption wasn't established: ", Distortion);
			LNLKMDPHDCC().SetVector("_Value3", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HIKKPDACJGI()
	{
	}

	[SpecialName]
	private Material DKKBFFHBHJE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1377f)
			{
				HBJJOCHGOPH = 541f;
			}
			ADGHJOHKEHG().SetFloat("visible", HBJJOCHGOPH);
			HHIAIGCAHDA().SetFloat(" cannot be used as a 3D LUT.", Distortion);
			LPMLLJKMAMP().SetVector("[LevelEditorScene] Print Audio Wave: Start", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KNBJBNDGCIJ()
	{
		SCShader = Shader.Find("#");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Distortion_Flag");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material LENEJAGLCNL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-91);
		}
		return BJFKDHHMLJH;
	}

	private void NFEDLAOPHML()
	{
	}

	[SpecialName]
	private Material HKHBBBFLGJH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)107;
		}
		return BJFKDHHMLJH;
	}

	private void EODOHEAKJFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PKLOBJHKFEO()
	{
		SCShader = Shader.Find("TimeBGSlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material KGOLDDBHIFN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void KLOLKEBAPFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 115f)
			{
				HBJJOCHGOPH = 21f;
			}
			KGOLDDBHIFN().SetFloat("================================", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("_DepthLevel", Distortion);
			KOHGPKOFEJO().SetVector("Hidden/Image Effects/Cinematic/MotionBlur/FrameBlending", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DNNFHBOOPIN()
	{
		SCShader = Shader.Find("_Saturation");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MFMIODIAKNI()
	{
	}

	private void MMMDPANNAIO()
	{
		SCShader = Shader.Find("#orderby:");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JOJFHFHOCHO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LADCJEIALMH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OCMKCBBCEFG()
	{
	}

	private void MGFFNGEGFDC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HGDDCINLDAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BLKGOMCPEKI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JHJGJJKELJM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NCPAFCKGJEA()
	{
	}

	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 156f)
			{
				HBJJOCHGOPH = 714f;
			}
			LNLKMDPHDCC().SetFloat(".lastCheckpoint.currentCombo", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("CameraFilterPack/Colors_Brightness", Distortion);
			LENEJAGLCNL().SetVector("checkpoint", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material KOHGPKOFEJO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void EGEPLFGKGLI()
	{
		SCShader = Shader.Find("\" for viewID ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LJIHHJOAJCN()
	{
	}

	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1309f)
			{
				HBJJOCHGOPH = 1579f;
			}
			LPMLLJKMAMP().SetFloat("LevelURLInputField", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("achievements.21.completed.workshop.", Distortion);
			MFHPKGICPIO().SetVector("LevelEditor/patterns", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-71);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material LPMLLJKMAMP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)86;
		}
		return BJFKDHHMLJH;
	}

	private void MAOCOEGAFND()
	{
	}

	private void HNDNDPECBPL()
	{
	}

	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1179f)
			{
				HBJJOCHGOPH = 882f;
			}
			KOHGPKOFEJO().SetFloat("RanksButton", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("SetSpeed", Distortion);
			HCGJCMDJPGD().SetVector(": ", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 357f)
			{
				HBJJOCHGOPH = 1004f;
			}
			KGOLDDBHIFN().SetFloat("color", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat("_Offsets", Distortion);
			HKHBBBFLGJH().SetVector("note.3", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1820f)
			{
				HBJJOCHGOPH = 536f;
			}
			KOHGPKOFEJO().SetFloat("_Value", HBJJOCHGOPH);
			HHIAIGCAHDA().SetFloat("_DotSize", Distortion);
			LENEJAGLCNL().SetVector("]", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OPCLBGHAPMG()
	{
	}

	[SpecialName]
	private Material ADBKPGFMNKO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return BJFKDHHMLJH;
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
			NBPKMLMCHFN.SetFloat("_Distortion", Distortion);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JDGFCEPDKAJ()
	{
	}

	private void OKLAJINHPAN()
	{
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material HCGJCMDJPGD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)109;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material ADGHJOHKEHG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 310f)
			{
				HBJJOCHGOPH = 800f;
			}
			OKJOKHGJHGF().SetFloat("SetParticlesParticleSpeed", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("AvatarImage", Distortion);
			NBPKMLMCHFN.SetVector("<color=#{0}>{1}</color>", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BMIOFJFMCBG()
	{
		SCShader = Shader.Find("_SunPosition");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1693f)
			{
				HBJJOCHGOPH = 1007f;
			}
			ADGHJOHKEHG().SetFloat("float,1", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("[PlayerController] ", Distortion);
			MFHPKGICPIO().SetVector("/", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
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
			if (HBJJOCHGOPH > 577f)
			{
				HBJJOCHGOPH = 184f;
			}
			KGOLDDBHIFN().SetFloat("LevelNameText", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("[MapsData] Preloading ", Distortion);
			DKKBFFHBHJE().SetVector("/", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 714f)
			{
				HBJJOCHGOPH = 1257f;
			}
			HCGJCMDJPGD().SetFloat("#alreadyexist", HBJJOCHGOPH);
			LENEJAGLCNL().SetFloat("CameraFilterPack/Light_Rainbow2", Distortion);
			MMOODGIODPC().SetVector(".lastCheckpoint.playerdistance", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KMCPMOGKDEH()
	{
		SCShader = Shader.Find("ClearEnvironment");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 562f)
			{
				HBJJOCHGOPH = 1617f;
			}
			LENEJAGLCNL().SetFloat("OK", HBJJOCHGOPH);
			HKHBBBFLGJH().SetFloat("HandleEventLeave for player ID: ", Distortion);
			KGOLDDBHIFN().SetVector("_ScreenResolution", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JAAJECBCCFM()
	{
	}

	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1446f)
			{
				HBJJOCHGOPH = 1928f;
			}
			DKKBFFHBHJE().SetFloat("_Value3", HBJJOCHGOPH);
			OKJOKHGJHGF().SetFloat("ready", Distortion);
			MMOODGIODPC().SetVector("5;6;7;8;11;12;18;19;20;22x6;44x1", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
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

	private void GPHPJIDGEPI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FBMDHDBELEK()
	{
	}

	private void JOONHGHGKKF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KDMANOEMOCA()
	{
		SCShader = Shader.Find("float,0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Update()
	{
	}

	[SpecialName]
	private Material HHIFMIPPMPF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material LNLKMDPHDCC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)99;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HKGAONMOBMH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1135f)
			{
				HBJJOCHGOPH = 373f;
			}
			DKKBFFHBHJE().SetFloat("SetSatelliteInput", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("BadgeText", Distortion);
			NBPKMLMCHFN.SetVector("ItemNameText", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FOMNCPKKCFN()
	{
	}

	private void CBIBDOIBJAI()
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
	private Material MFHPKGICPIO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-84);
		}
		return BJFKDHHMLJH;
	}
}
