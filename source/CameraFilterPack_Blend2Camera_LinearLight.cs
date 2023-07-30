// CameraFilterPack_Blend2Camera_LinearLight
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/LinearLight")]
[ExecuteInEditMode]
public class CameraFilterPack_Blend2Camera_LinearLight : MonoBehaviour
{
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_LinearLight";

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

	private void BJOHDLNDFAD()
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

	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 469f)
			{
				HBJJOCHGOPH = 1778f;
			}
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture("-1", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat("CameraFilterPack_AAA_Blood2", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("Edited event", BlendFX);
			PDEAHJPOMEF().SetFloat("_Green_B", SwitchCameraToCamera2);
			EPCGJFCCAFH().SetVector("QuickSave", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1288f, 1225f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FOMNCPKKCFN()
	{
	}

	[SpecialName]
	private Material ABHDNGIHBKE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)107;
		}
		return BJFKDHHMLJH;
	}

	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 483f)
			{
				HBJJOCHGOPH = 1523f;
			}
			if (Camera2 != null)
			{
				MCDGIILBNIF().SetTexture("_Value2", JDMCFBKJHDD);
			}
			PLBEJJIHFPB().SetFloat("HandsCountSlider", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("_Value", BlendFX);
			ABHDNGIHBKE().SetFloat("_Bullet_11", SwitchCameraToCamera2);
			NBPKMLMCHFN.SetVector("_Red_C", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1208f, 1759f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DNNFHBOOPIN()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -92);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OHFOLGANOLC()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 26);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material OGMEGHKECAH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void KLILJHJNICK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 48);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IDIIELPAMCJ()
	{
	}

	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1630f)
			{
				HBJJOCHGOPH = 980f;
			}
			if (Camera2 != null)
			{
				PLBEJJIHFPB().SetTexture("CameraFilterPack/TV_ARCADE_Fast", JDMCFBKJHDD);
			}
			EPCGJFCCAFH().SetFloat("value", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("_Offsets", BlendFX);
			PDEAHJPOMEF().SetFloat("_Offsets", SwitchCameraToCamera2);
			EPCGJFCCAFH().SetVector("_DotSize", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1072f, 1410f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HLLHJIDOOGA()
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

	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 602f)
			{
				HBJJOCHGOPH = 729f;
			}
			if (Camera2 != null)
			{
				PDEAHJPOMEF().SetTexture("Bad parameters for getstring! Use <key> <value>", JDMCFBKJHDD);
			}
			EPCGJFCCAFH().SetFloat("CameraFilterPack/AAA_Super_Computer", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("settings.disablestoryboard", BlendFX);
			EPCGJFCCAFH().SetFloat("_FresnelFade", SwitchCameraToCamera2);
			HNICHJCGJOC().SetVector("Arc", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1395f, 930f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
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
			if (HBJJOCHGOPH > 414f)
			{
				HBJJOCHGOPH = 1915f;
			}
			if (Camera2 != null)
			{
				OGMEGHKECAH().SetTexture("_SunPosition", JDMCFBKJHDD);
			}
			MCDGIILBNIF().SetFloat("HiddenToggle", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("_ScreenResolution", BlendFX);
			OGMEGHKECAH().SetFloat("_BlurCoe", SwitchCameraToCamera2);
			ABHDNGIHBKE().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 575f, 649f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FELENDJEOGA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 78);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void PBEPCAPAKLG()
	{
	}

	[SpecialName]
	private Material KGOLDDBHIFN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void KIEJKBNBHMD()
	{
	}

	private void FBMDHDBELEK()
	{
	}

	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1813f)
			{
				HBJJOCHGOPH = 409f;
			}
			if (Camera2 != null)
			{
				EPCGJFCCAFH().SetTexture("menutheme.letitbe", JDMCFBKJHDD);
			}
			OGMEGHKECAH().SetFloat("other", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("isVisible", BlendFX);
			MCDGIILBNIF().SetFloat("USE_CORNER_DETECTION", SwitchCameraToCamera2);
			EPCGJFCCAFH().SetVector("_Value5", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1397f, 368f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LLAJPKFNDIG()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -109);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void MMOKKAPFGAK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 121);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FHPFJBFCOOF()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 23);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DKGBFNCOAEO()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 54);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EFJDNLGNACH()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 9);
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
			NBPKMLMCHFN.SetFloat("_Value2", SwitchCameraToCamera2);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1494f)
			{
				HBJJOCHGOPH = 99f;
			}
			if (Camera2 != null)
			{
				ABHDNGIHBKE().SetTexture("_Screen", JDMCFBKJHDD);
			}
			PLBEJJIHFPB().SetFloat("EndlessLoopsScoreText", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("No Name", BlendFX);
			NBPKMLMCHFN.SetFloat("Left ", SwitchCameraToCamera2);
			EPCGJFCCAFH().SetVector("Gameplay/sprite", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1183f, 361f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GHMDNIFLGOB()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -105);
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

	private void IIJAPKAADNH()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -56);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1201f)
			{
				HBJJOCHGOPH = 1409f;
			}
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture("_ColoredChange", JDMCFBKJHDD);
			}
			EPCGJFCCAFH().SetFloat("_EmissionColor", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("[PlayerController] ", BlendFX);
			EPCGJFCCAFH().SetFloat("OxOD.lastPath", SwitchCameraToCamera2);
			NBPKMLMCHFN.SetVector("_Fade", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 232f, 612f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OnEnable()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
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

	[SpecialName]
	private Material PLBEJJIHFPB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void MOMGJJDIFFI()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -70);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 827f)
			{
				HBJJOCHGOPH = 132f;
			}
			if (Camera2 != null)
			{
				PLBEJJIHFPB().SetTexture("_Value2", JDMCFBKJHDD);
			}
			OGMEGHKECAH().SetFloat("_TimeX", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("_TimeX", BlendFX);
			ABHDNGIHBKE().SetFloat("_Value3", SwitchCameraToCamera2);
			EPCGJFCCAFH().SetVector("[LevelEditorScene] Map submitted!", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1819f, 980f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1807f)
			{
				HBJJOCHGOPH = 132f;
			}
			if (Camera2 != null)
			{
				MCDGIILBNIF().SetTexture("TStart", JDMCFBKJHDD);
			}
			ABHDNGIHBKE().SetFloat(" [", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("/", BlendFX);
			PLBEJJIHFPB().SetFloat(", ", SwitchCameraToCamera2);
			EPCGJFCCAFH().SetVector("ItemsCountText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1740f, 1702f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KMKLDAJLCNM()
	{
	}

	[SpecialName]
	private Material EPCGJFCCAFH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-85);
		}
		return BJFKDHHMLJH;
	}

	private void FDIJLKIIMLL()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -57);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1303f)
			{
				HBJJOCHGOPH = 1343f;
			}
			if (Camera2 != null)
			{
				ABHDNGIHBKE().SetTexture("PerfectHitsScoreText", JDMCFBKJHDD);
			}
			PDEAHJPOMEF().SetFloat("[MapEditor] Updating top menu", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("_TimeX", BlendFX);
			HNICHJCGJOC().SetFloat("_Value9", SwitchCameraToCamera2);
			EPCGJFCCAFH().SetVector("Added event", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 531f, 537f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FKDKJKCAHJC()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 104);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material HNICHJCGJOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void LCJHDLKJEOM()
	{
	}

	private void EJJEDJIOFAB()
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

	private void FKEJGBFDCAH()
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

	private void Update()
	{
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

	private void PDILBLLIPFJ()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 22);
			Camera2.targetTexture = JDMCFBKJHDD;
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

	private void GAAPMFBPJNH()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -77);
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

	private void KOCPGJCINKD()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 50);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void ALMGMOOHLMA()
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

	private void HPNNCNNFMGK()
	{
	}

	private void IJCBBIJOCAH()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -96);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void GPHPJIDGEPI()
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

	private void OCCGJMPAJIK()
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
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -97);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JHBPINEKDPE()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 61);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void HAIAHJPCPAG()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 41);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NAOLAJPDGIC()
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

	private void MBNMADBPDLL()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 49);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1557f)
			{
				HBJJOCHGOPH = 1899f;
			}
			if (Camera2 != null)
			{
				EPCGJFCCAFH().SetTexture("Set Sun Lerp Speed", JDMCFBKJHDD);
			}
			HNICHJCGJOC().SetFloat("[MapsData] Installed: ", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("Connected to gameserver.", BlendFX);
			EPCGJFCCAFH().SetFloat("inventory.selected.", SwitchCameraToCamera2);
			OGMEGHKECAH().SetVector("MapEditorScene", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 772f, 788f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideAndDontSave;
		}
		return BJFKDHHMLJH;
	}

	private void JOACBIEHHCE()
	{
	}

	private void MBFNACDMEEK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -69);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material MCDGIILBNIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-96);
		}
		return BJFKDHHMLJH;
	}

	private void BNEJMABFKJE()
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

	private void HIFPDKKBDHJ()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 125);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1322f)
			{
				HBJJOCHGOPH = 316f;
			}
			if (Camera2 != null)
			{
				ABHDNGIHBKE().SetTexture("SpawnObj", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat("HH:mm:ss", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("LevelNameInputField", BlendFX);
			KGOLDDBHIFN().SetFloat(":", SwitchCameraToCamera2);
			EPCGJFCCAFH().SetVector("_Distortion", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1887f, 128f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
