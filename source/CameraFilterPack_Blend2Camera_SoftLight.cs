// CameraFilterPack_Blend2Camera_SoftLight
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/SoftLight")]
public class CameraFilterPack_Blend2Camera_SoftLight : MonoBehaviour
{
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_SoftLight";

	public Shader SCShader;

	public Camera Camera2;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 1f)]
	public float SwitchCameraToCamera2;

	[Range(0f, 1f)]
	public float BlendFX = 0.5f;

	private RenderTexture JDMCFBKJHDD;

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
	private Material EFDEIFCDAFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void LOOGLMFBJHK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -55);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void FJIKDJAMOHA()
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
	private Material OLHDPICFBOF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)99;
		}
		return BJFKDHHMLJH;
	}

	private void LECCHIAFGGE()
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

	private void Update()
	{
	}

	private void AGEJKLMJGDO()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -112);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IDKPHKOCOLD()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -85);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void MMBPLGGLPDB()
	{
	}

	private void FGIOPGGPLMB()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 65);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 990f)
			{
				HBJJOCHGOPH = 624f;
			}
			if (Camera2 != null)
			{
				LNLKMDPHDCC().SetTexture("_Blue_C", JDMCFBKJHDD);
			}
			EFDEIFCDAFG().SetFloat("[PlayerController] ", HBJJOCHGOPH);
			PGPEMMBJOOG().SetFloat("_Visualize", BlendFX);
			KJMECMIGJJA().SetFloat("_HSV", SwitchCameraToCamera2);
			NBPKMLMCHFN.SetVector("1087340967", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1957f, 988f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void CIPKEPDELJB()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -105);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MPADDMNGJNC()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 66);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material FGENHBKMPDA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-65);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material PGPEMMBJOOG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
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

	private void POIMNOBDBBN()
	{
	}

	private void EJFJENFKLND()
	{
	}

	private void MDMDGKHDPKP()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -116);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void DFENCIHAADO()
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

	private void POIFMMFPELA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -34);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void Start()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 449f)
			{
				HBJJOCHGOPH = 243f;
			}
			if (Camera2 != null)
			{
				HEHKGPKLAKK().SetTexture("/", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat("#", HBJJOCHGOPH);
			FGENHBKMPDA().SetFloat("_DotSize", BlendFX);
			LNLKMDPHDCC().SetFloat("itemdefid[0]", SwitchCameraToCamera2);
			PGPEMMBJOOG().SetVector("history", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 356f, 1489f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KOJKBFDNGDK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -55);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1575f)
			{
				HBJJOCHGOPH = 1911f;
			}
			if (Camera2 != null)
			{
				LNLKMDPHDCC().SetTexture("_Value6", JDMCFBKJHDD);
			}
			DNLMFEGJJDD().SetFloat("Anime", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("3;4;9;10;21x6", BlendFX);
			LNLKMDPHDCC().SetFloat("[ItemsHandler] Loading Steam inventory", SwitchCameraToCamera2);
			PGPEMMBJOOG().SetVector("#getrewardfailed: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1700f, 288f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FDMAEPOHDMK()
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

	private void EDBEHEKMGFH()
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
	private Material EFMCNLELMDO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void FJHFOBHJEHL()
	{
	}

	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1843f)
			{
				HBJJOCHGOPH = 1291f;
			}
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture("_Near", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat("SetTrailZoomSpeed", HBJJOCHGOPH);
			FGENHBKMPDA().SetFloat("icon", BlendFX);
			PGPEMMBJOOG().SetFloat("maps.", SwitchCameraToCamera2);
			HEHKGPKLAKK().SetVector("settings.arcshitsoundtimedelay", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1144f, 229f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFMCNLELMDO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LNLKMDPHDCC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 669f)
			{
				HBJJOCHGOPH = 141f;
			}
			if (Camera2 != null)
			{
				EFMCNLELMDO().SetTexture("\" call.", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat("PossibleMapMaxScoreText", HBJJOCHGOPH);
			HEHKGPKLAKK().SetFloat("Missing shader for image effect {0}", BlendFX);
			HFBJAOFLCJI().SetFloat("_Source", SwitchCameraToCamera2);
			NBPKMLMCHFN.SetVector("_Alpha2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 208f, 197f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-120);
		}
		return BJFKDHHMLJH;
	}

	private void IHAGANPOFDP()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 6);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void OnValidate()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void LCHBFNIPBHB()
	{
	}

	private void PKBENONAOOL()
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

	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1814f)
			{
				HBJJOCHGOPH = 1300f;
			}
			if (Camera2 != null)
			{
				LNLKMDPHDCC().SetTexture("CameraFilterPack_Blizzard1", JDMCFBKJHDD);
			}
			FGENHBKMPDA().SetFloat("_Value3", HBJJOCHGOPH);
			PGPEMMBJOOG().SetFloat("workshop.", BlendFX);
			OLHDPICFBOF().SetFloat("\nv.", SwitchCameraToCamera2);
			EFDEIFCDAFG().SetVector(".a", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1396f, 1827f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFMCNLELMDO());
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
			if (HBJJOCHGOPH > 1965f)
			{
				HBJJOCHGOPH = 58f;
			}
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture(".played", JDMCFBKJHDD);
			}
			HEHKGPKLAKK().SetFloat("GO==null", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("Bad SegmentType passed in to CreateLineCap. Must be SegmentType.Start or SegmentType.End", BlendFX);
			LNLKMDPHDCC().SetFloat("settings.selectormapsperpage", SwitchCameraToCamera2);
			PGPEMMBJOOG().SetVector("skin.hit_normal", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 650f, 1531f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1830f)
			{
				HBJJOCHGOPH = 330f;
			}
			if (Camera2 != null)
			{
				DNLMFEGJJDD().SetTexture("_ScreenResolution", JDMCFBKJHDD);
			}
			KOHGPKOFEJO().SetFloat(",", HBJJOCHGOPH);
			PGPEMMBJOOG().SetFloat("ViewMenu", BlendFX);
			DNLMFEGJJDD().SetFloat("NetworkPeer broke!", SwitchCameraToCamera2);
			OLHDPICFBOF().SetVector("Connected to NameServer.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1586f, 1739f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 726f)
			{
				HBJJOCHGOPH = 741f;
			}
			if (Camera2 != null)
			{
				HFBJAOFLCJI().SetTexture("HitInRelaxMusicToggle", JDMCFBKJHDD);
			}
			KOHGPKOFEJO().SetFloat("BitsData", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat("Missing shader for image effect {0}", BlendFX);
			HFBJAOFLCJI().SetFloat("st", SwitchCameraToCamera2);
			KJMECMIGJJA().SetVector("_FixDistance", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1212f, 1424f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HONBLGFDMLL()
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

	private void IDJKNBDKHBD()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -116);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JHANGPCOCIG()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -34);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BMIOFJFMCBG()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 65);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
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

	private void LONLHFLPEJD()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 5);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void EMAMCDFBGOA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 90);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 777f)
			{
				HBJJOCHGOPH = 1666f;
			}
			if (Camera2 != null)
			{
				KOHGPKOFEJO().SetTexture("PointerEnter ", JDMCFBKJHDD);
			}
			PGPEMMBJOOG().SetFloat("DisableStoryboardToggle", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("_Radius", BlendFX);
			FGENHBKMPDA().SetFloat("_BlurCoe", SwitchCameraToCamera2);
			OLHDPICFBOF().SetVector(".ogg", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 755f, 18f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFMCNLELMDO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 45f)
			{
				HBJJOCHGOPH = 1890f;
			}
			if (Camera2 != null)
			{
				KJMECMIGJJA().SetTexture("_CenterY", JDMCFBKJHDD);
			}
			FGENHBKMPDA().SetFloat("' got destroyed by engine. This is OK when loading levels. Otherwise use: PhotonNetwork.Destroy().", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("G:", BlendFX);
			PGPEMMBJOOG().SetFloat("ClearEnvironment", SwitchCameraToCamera2);
			FGENHBKMPDA().SetVector("PublishButton", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1360f, 1128f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IIJAPKAADNH()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -3);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void MEJPBKFMAIG()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -37);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void IMGGCJICLHK()
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

	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1385f)
			{
				HBJJOCHGOPH = 221f;
			}
			if (Camera2 != null)
			{
				HFBJAOFLCJI().SetTexture("#000000CC", JDMCFBKJHDD);
			}
			PGPEMMBJOOG().SetFloat("Time Offset: {0}", HBJJOCHGOPH);
			HEHKGPKLAKK().SetFloat("<b>Speed</b>:", BlendFX);
			DNLMFEGJJDD().SetFloat("_MainTex2", SwitchCameraToCamera2);
			PGPEMMBJOOG().SetVector("PlaySound", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 307f, 337f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IEFMONDKKJN()
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

	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 702f)
			{
				HBJJOCHGOPH = 869f;
			}
			if (Camera2 != null)
			{
				OLHDPICFBOF().SetTexture("offsets", JDMCFBKJHDD);
			}
			EFDEIFCDAFG().SetFloat("#close", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("english", BlendFX);
			PGPEMMBJOOG().SetFloat("Can't set MaxPlayers when not in that room.", SwitchCameraToCamera2);
			DNLMFEGJJDD().SetVector("settings.gamemessagesduration", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 690f, 1733f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
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
	private Material HEHKGPKLAKK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)103;
		}
		return BJFKDHHMLJH;
	}

	private void FGOPJMGNHGO()
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

	private void FELENDJEOGA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -69);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1561f)
			{
				HBJJOCHGOPH = 1f;
			}
			if (Camera2 != null)
			{
				EFDEIFCDAFG().SetTexture("[ResourcesManager] Load image error: ", JDMCFBKJHDD);
			}
			HFBJAOFLCJI().SetFloat("No Description", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", BlendFX);
			EFDEIFCDAFG().SetFloat("_Value5", SwitchCameraToCamera2);
			HEHKGPKLAKK().SetVector("]. Please verify you have this gameobject in a Resources folder.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 271f, 442f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KCDOMIJBFLL()
	{
	}

	[SpecialName]
	private Material DNLMFEGJJDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void BLDMINMDHPA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -39);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void LJEDJDGPGFG()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -38);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1329f)
			{
				HBJJOCHGOPH = 1730f;
			}
			if (Camera2 != null)
			{
				DNLMFEGJJDD().SetTexture("on master", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat("_Parameter", HBJJOCHGOPH);
			FGENHBKMPDA().SetFloat("_HitPointTexture", BlendFX);
			FGENHBKMPDA().SetFloat("] as we haven't received a full packet for delta compression yet. This is OK if it happens for the first few frames after joining a game.", SwitchCameraToCamera2);
			NBPKMLMCHFN.SetVector(" not exist", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1956f, 601f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KMOCDAOKGLI()
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

	private void CBIBDOIBJAI()
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

	private void LIFBFDKFMMH()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -124);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void CCKABCDEOJC()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 108);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 979f)
			{
				HBJJOCHGOPH = 1196f;
			}
			if (Camera2 != null)
			{
				HEHKGPKLAKK().SetTexture("JoystickButton13", JDMCFBKJHDD);
			}
			LNLKMDPHDCC().SetFloat("CameraFilterPack/3D_Anomaly", HBJJOCHGOPH);
			HEHKGPKLAKK().SetFloat("settings.disablestoryboard", BlendFX);
			OLHDPICFBOF().SetFloat("Can't find key ", SwitchCameraToCamera2);
			EFMCNLELMDO().SetVector("{0}", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 231f, 79f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
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
			NBPKMLMCHFN.SetFloat("_Value2", SwitchCameraToCamera2);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HJPCJGOEKMF()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -16);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
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

	private void JAAJECBCCFM()
	{
	}

	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1985f)
			{
				HBJJOCHGOPH = 1433f;
			}
			if (Camera2 != null)
			{
				LNLKMDPHDCC().SetTexture("CameraFilterPack/FX_DarkMatter", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat("PunPickup", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat("SetupEncryption() got called. ", BlendFX);
			KOHGPKOFEJO().SetFloat("(\\[ *b *\\])", SwitchCameraToCamera2);
			PGPEMMBJOOG().SetVector("id", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 318f, 933f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OMCLOFCJMPG()
	{
	}

	private void DIPDEHOOBPG()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -32);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PBEPCAPAKLG()
	{
	}

	private void OnEnable()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 894f)
			{
				HBJJOCHGOPH = 1667f;
			}
			if (Camera2 != null)
			{
				EFMCNLELMDO().SetTexture("settings.volume.editor", JDMCFBKJHDD);
			}
			PGPEMMBJOOG().SetFloat("settings_bindings_sec_", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat("Unsupported target enum: ", BlendFX);
			FGENHBKMPDA().SetFloat("_DistortionLevel", SwitchCameraToCamera2);
			KOHGPKOFEJO().SetVector("roomDescription", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 329f, 1027f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LKCHMPCHKDM()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 28);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material HFBJAOFLCJI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void PPGEGFMNIKO()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -73);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void HDHHMBEJIMB()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 85);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void IIKCMDMMJJI()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -96);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1175f)
			{
				HBJJOCHGOPH = 1710f;
			}
			if (Camera2 != null)
			{
				EFDEIFCDAFG().SetTexture("Done!", JDMCFBKJHDD);
			}
			OLHDPICFBOF().SetFloat("_Offsets", HBJJOCHGOPH);
			HEHKGPKLAKK().SetFloat("CameraFilterPack/FX_Funk", BlendFX);
			KOHGPKOFEJO().SetFloat(". Stopping handling if inactive.", SwitchCameraToCamera2);
			FGENHBKMPDA().SetVector("\n\n#", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 836f, 1699f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GHILDCBCDJI()
	{
	}

	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1882f)
			{
				HBJJOCHGOPH = 1520f;
			}
			if (Camera2 != null)
			{
				FGENHBKMPDA().SetTexture("Connection error: ", JDMCFBKJHDD);
			}
			LNLKMDPHDCC().SetFloat("OxOD.lastPath", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("PS Home", BlendFX);
			LNLKMDPHDCC().SetFloat("[Down]", SwitchCameraToCamera2);
			HFBJAOFLCJI().SetVector("CameraFilterPack_Atmosphere_Rain_FX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1288f, 1416f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
