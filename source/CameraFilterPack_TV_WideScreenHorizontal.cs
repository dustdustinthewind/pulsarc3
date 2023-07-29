// CameraFilterPack_TV_WideScreenHorizontal
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/TV/WideScreenHorizontal")]
[ExecuteInEditMode]
public class CameraFilterPack_TV_WideScreenHorizontal : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 0.8f)]
	public float Size = 0.55f;

	[Range(0.001f, 0.4f)]
	public float Smooth = 0.01f;

	[Range(0f, 10f)]
	private float ICABEDDNGIH = 1f;

	[Range(0f, 10f)]
	private float LHOMPJOPKHE = 1f;

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
	private Material GHHPOGODBHB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-95);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return BJFKDHHMLJH;
	}

	private void ODCJJFBJJNF()
	{
	}

	private void PNNPDMHLFHE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JKFDDNMPOJH()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material KEMAALEODNH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)95;
		}
		return BJFKDHHMLJH;
	}

	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1825f)
			{
				HBJJOCHGOPH = 912f;
			}
			HHLFDHNEIAH().SetFloat("settings_bindings_", HBJJOCHGOPH);
			CFCPHFMKHII().SetFloat("offsets", Size);
			OHKGGPFGLFD().SetFloat("_Value", Smooth);
			NBPKMLMCHFN.SetFloat("st", ICABEDDNGIH);
			NBPKMLMCHFN.SetFloat("value", LHOMPJOPKHE);
			AELJLBOJAIL().SetVector("{0}{1}:{2}", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1076f, 117f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1745f)
			{
				HBJJOCHGOPH = 1985f;
			}
			IGKFMCPDNOI().SetFloat("Mouse", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("_OcclusionTexture", Size);
			CFCPHFMKHII().SetFloat("Set satellite trail width", Smooth);
			GHHPOGODBHB().SetFloat("_SunThreshold", ICABEDDNGIH);
			JFDGLLEOPGB().SetFloat("Fade", LHOMPJOPKHE);
			DKNJGHFLAIF().SetVector("_Red_G", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1744f, 575f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KIMMMCJFMAB()
	{
		SCShader = Shader.Find("Set particless emission (glow)");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material FAIFBBGFAIB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void HLLHJIDOOGA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ABFNJCEBIKA()
	{
	}

	private void COGBDFKOHKK()
	{
	}

	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 619f)
			{
				HBJJOCHGOPH = 1175f;
			}
			DBOLLHHMKKN().SetFloat(" not exist", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat(" item(s) in inventory", Size);
			ACHNOHCLGOO().SetFloat("CameraFilterPack/3D_Computer", Smooth);
			OHKGGPFGLFD().SetFloat(" in SaveLoadMenu.prefabDictionary!", ICABEDDNGIH);
			ACHNOHCLGOO().SetFloat("Tab1Content", LHOMPJOPKHE);
			NLFJGMBCICG().SetVector("accuracy", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1938f, 1454f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HMPGIFBJFIK()
	{
		SCShader = Shader.Find("float,0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 563f)
			{
				HBJJOCHGOPH = 927f;
			}
			NBPKMLMCHFN.SetFloat("<b>Max Score</b>:", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("speed", Size);
			JFDGLLEOPGB().SetFloat("_Value4", Smooth);
			ACHNOHCLGOO().SetFloat("SpawnObj", ICABEDDNGIH);
			DBOLLHHMKKN().SetFloat("GlassColor", LHOMPJOPKHE);
			KEMAALEODNH().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1684f, 1812f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material OHKGGPFGLFD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void DNNFHBOOPIN()
	{
		SCShader = Shader.Find("{0:0} hour{1}, ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OFPPIKHNJOD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material ACHNOHCLGOO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HHLFDHNEIAH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void EGEGNHLODAA()
	{
	}

	[SpecialName]
	private Material EOCCJGIGEGJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave;
		}
		return BJFKDHHMLJH;
	}

	private void AEDDNDHCLNN()
	{
		SCShader = Shader.Find("SetupEncryption() got called. ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FJIKDJAMOHA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AKHCOBHHGJP()
	{
		SCShader = Shader.Find("CameraFilterPack/3D_Myst");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 591f)
			{
				HBJJOCHGOPH = 723f;
			}
			DKNJGHFLAIF().SetFloat("_Value", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("RateButton", Size);
			LONNIJMNKFB().SetFloat("_Value5", Smooth);
			ACHNOHCLGOO().SetFloat("y", ICABEDDNGIH);
			NFKFAAHHLLM().SetFloat("ComboScoreText", LHOMPJOPKHE);
			OHKGGPFGLFD().SetVector("SpawnObj", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1424f, 367f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/TV_WideScreenHorizontal");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 493f)
			{
				HBJJOCHGOPH = 1435f;
			}
			LONNIJMNKFB().SetFloat("_Blue_R", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat("_Distortion", Size);
			HFBJAOFLCJI().SetFloat("2hands", Smooth);
			KBOPGONOCNP().SetFloat("Out {0,4} | In {1,4} | Sum {2,4}", ICABEDDNGIH);
			EOCCJGIGEGJ().SetFloat("_Value", LHOMPJOPKHE);
			EOCCJGIGEGJ().SetVector("???", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 386f, 1893f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHLFDHNEIAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1882f)
			{
				HBJJOCHGOPH = 1074f;
			}
			NFKFAAHHLLM().SetFloat("_TimeX", HBJJOCHGOPH);
			GHHPOGODBHB().SetFloat("[PlayerController] ", Size);
			KHCLIAMBBNC().SetFloat(" ", Smooth);
			HHLFDHNEIAH().SetFloat("[ERROR KEY {0}]", ICABEDDNGIH);
			KBOPGONOCNP().SetFloat("menu.selectedplaymode", LHOMPJOPKHE);
			AELJLBOJAIL().SetVector("DPADVER", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 335f, 766f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material CFCPHFMKHII()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void MPJCMKFFKHH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1136f)
			{
				HBJJOCHGOPH = 1601f;
			}
			KJMECMIGJJA().SetFloat("mapselector.lastSearch", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("_TimeX", Size);
			LONNIJMNKFB().SetFloat("[MenuScene] Error: ", Smooth);
			GHHPOGODBHB().SetFloat("_TimeX", ICABEDDNGIH);
			HFBJAOFLCJI().SetFloat("_Distortion", LHOMPJOPKHE);
			NLFJGMBCICG().SetVector("No player left to ask", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 814f, 938f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DOEPOGLEGLE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IDJKNBDKHBD()
	{
		SCShader = Shader.Find("event");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CFIAKIJAILI()
	{
	}

	private void PKBENONAOOL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MFLBEJHMEMO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void COIJKMKIEAK()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1642f)
			{
				HBJJOCHGOPH = 214f;
			}
			LPCHMEKDCHI().SetFloat("_MainTex", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("_ScreenResolution", Size);
			NBPKMLMCHFN.SetFloat("_NoiseTex", Smooth);
			FAIFBBGFAIB().SetFloat("CameraFilterPack/Blend2Camera_SoftLight", ICABEDDNGIH);
			HFBJAOFLCJI().SetFloat(": ", LHOMPJOPKHE);
			NFKFAAHHLLM().SetVector("_BlurVector", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 8f, 921f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HFBJAOFLCJI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return BJFKDHHMLJH;
	}

	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1700f)
			{
				HBJJOCHGOPH = 1950f;
			}
			CFCPHFMKHII().SetFloat("set environment id", HBJJOCHGOPH);
			NDMPCDHADMJ().SetFloat("AvatarImage", Size);
			FAIFBBGFAIB().SetFloat("_Vignetting2", Smooth);
			KEMAALEODNH().SetFloat("_ScreenResolution", ICABEDDNGIH);
			KEMAALEODNH().SetFloat("settings.shaders", LHOMPJOPKHE);
			EOCCJGIGEGJ().SetVector("_Value4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 148f, 146f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
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
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void GPNAOAKCMHC()
	{
		SCShader = Shader.Find("ViewMenu");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IEMEHGCFAPD()
	{
	}

	[SpecialName]
	private Material DKNJGHFLAIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IGKFMCPDNOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void DLBODOFAJGM()
	{
		SCShader = Shader.Find("shader.frost");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OPCLBGHAPMG()
	{
	}

	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 923f)
			{
				HBJJOCHGOPH = 1410f;
			}
			GHHPOGODBHB().SetFloat("CameraFilterPack_TV_BrokenGlass_2", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Called GetNumberOfCurrentPlayers()", Size);
			CFCPHFMKHII().SetFloat("Destroy(targetPhotonView) failed, cause targetPhotonView is null.", Smooth);
			ABHDNGIHBKE().SetFloat("11", ICABEDDNGIH);
			KEMJNOMIPHN().SetFloat("_NeighborMaxTex", LHOMPJOPKHE);
			HFBJAOFLCJI().SetVector("0.00", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 250f, 1976f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OHKGGPFGLFD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NKFDNIAKGEO()
	{
		SCShader = Shader.Find("[MapsData] Preloading ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material LMLENGFLEBD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-123);
		}
		return BJFKDHHMLJH;
	}

	private void MNBPNHNAEBK()
	{
		SCShader = Shader.Find("_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GENCBNFIILN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1500f)
			{
				HBJJOCHGOPH = 283f;
			}
			JFDGLLEOPGB().SetFloat("[PlayerBase] Loaded environment: ", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("ConfigVersionSlider", Size);
			DONENAMLFLF().SetFloat("x", Smooth);
			NBPKMLMCHFN.SetFloat("offsets", ICABEDDNGIH);
			MMOODGIODPC().SetFloat("_MainTex2", LHOMPJOPKHE);
			DONENAMLFLF().SetVector("Tab1Content", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1610f, 1742f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 406f)
			{
				HBJJOCHGOPH = 867f;
			}
			OHKGGPFGLFD().SetFloat("_Value2", HBJJOCHGOPH);
			LPCHMEKDCHI().SetFloat(".lastCheckpoint.currentCombo", Size);
			FAIFBBGFAIB().SetFloat("_TimeX", Smooth);
			MMOODGIODPC().SetFloat("#failed!", ICABEDDNGIH);
			KBOPGONOCNP().SetFloat("-1", LHOMPJOPKHE);
			KEMAALEODNH().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 964f, 127f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DFFKKLAPHCC()
	{
		SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material DBOLLHHMKKN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material AELJLBOJAIL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void MCKCCPLJIFE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LGHCJCFHEMF()
	{
		SCShader = Shader.Find("_HueShift");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1034f)
			{
				HBJJOCHGOPH = 659f;
			}
			JFDGLLEOPGB().SetFloat(" - LOCAL", HBJJOCHGOPH);
			DONENAMLFLF().SetFloat("_EmissionColor", Size);
			HFBJAOFLCJI().SetFloat("Loading inventory", Smooth);
			MMOODGIODPC().SetFloat("_ScreenResolution", ICABEDDNGIH);
			JFDGLLEOPGB().SetFloat("_ScreenResolution", LHOMPJOPKHE);
			KEMJNOMIPHN().SetVector("menu.tabid", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1892f, 131f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1904f)
			{
				HBJJOCHGOPH = 301f;
			}
			DONENAMLFLF().SetFloat("...", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("arcs", Size);
			DONENAMLFLF().SetFloat("Start Color's hex value #RRGGBBAA", Smooth);
			NDMPCDHADMJ().SetFloat("Editor/", ICABEDDNGIH);
			IGKFMCPDNOI().SetFloat("CreateRoom failed, client stays on masterserver: {0}.", LHOMPJOPKHE);
			DKNJGHFLAIF().SetVector("0.00/0.00", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 328f, 802f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KMKLDAJLCNM()
	{
	}

	private void JAAJECBCCFM()
	{
	}

	private void MANDOGNJJBD()
	{
	}

	private void PLEOOAJIMEE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1958f)
			{
				HBJJOCHGOPH = 650f;
			}
			ACHNOHCLGOO().SetFloat("</color>", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", Size);
			KBOPGONOCNP().SetFloat("_Intensity", Smooth);
			EOCCJGIGEGJ().SetFloat("win", ICABEDDNGIH);
			DBOLLHHMKKN().SetFloat("_Size", LHOMPJOPKHE);
			MMOODGIODPC().SetVector("HostType: {0} ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1385f, 995f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DBEMDAJDDDA()
	{
		SCShader = Shader.Find("ViewMenu");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material LONNIJMNKFB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-109);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material DONENAMLFLF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void KOFAMEKHHGD()
	{
		SCShader = Shader.Find("event");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JOONHGHGKKF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DPFOEBCADNP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NNCCPEBIAKH()
	{
		SCShader = Shader.Find("CameraFilterPack/Color_Contrast");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1989f)
			{
				HBJJOCHGOPH = 1191f;
			}
			IIJMIPBMMBF().SetFloat("#failed!", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("_Distortion", Size);
			IGKFMCPDNOI().SetFloat("\n\n#", Smooth);
			KEMJNOMIPHN().SetFloat("[Down]", ICABEDDNGIH);
			DBOLLHHMKKN().SetFloat("error", LHOMPJOPKHE);
			NLFJGMBCICG().SetVector("_Value4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1797f, 678f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FABKIGNFECE()
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
			NBPKMLMCHFN.SetFloat("_Value", Size);
			NBPKMLMCHFN.SetFloat("_Value2", Smooth);
			NBPKMLMCHFN.SetFloat("_Value3", ICABEDDNGIH);
			NBPKMLMCHFN.SetFloat("_Value4", LHOMPJOPKHE);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material KEMJNOMIPHN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)66;
		}
		return BJFKDHHMLJH;
	}

	private void FBMDHDBELEK()
	{
	}

	private void IEFMONDKKJN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material LPCHMEKDCHI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)99;
		}
		return BJFKDHHMLJH;
	}

	private void KMCPMOGKDEH()
	{
		SCShader = Shader.Find("[PlayerBase] Checkpoint error: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material JFDGLLEOPGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)80;
		}
		return BJFKDHHMLJH;
	}

	private void HIKKPDACJGI()
	{
	}

	[SpecialName]
	private Material ABHDNGIHBKE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)117;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NFKFAAHHLLM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)111;
		}
		return BJFKDHHMLJH;
	}

	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 677f)
			{
				HBJJOCHGOPH = 1628f;
			}
			KEMAALEODNH().SetFloat("_Vibrance", HBJJOCHGOPH);
			LMLENGFLEBD().SetFloat("[SoundManager] Loaded skin audio", Size);
			KJMECMIGJJA().SetFloat("HPText", Smooth);
			KEMAALEODNH().SetFloat(":\n", ICABEDDNGIH);
			HHLFDHNEIAH().SetFloat("_Fade", LHOMPJOPKHE);
			MMOODGIODPC().SetVector("#done", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 444f, 584f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1628f)
			{
				HBJJOCHGOPH = 973f;
			}
			LMLENGFLEBD().SetFloat("y", HBJJOCHGOPH);
			GHHPOGODBHB().SetFloat("ShowSprite", Size);
			EOCCJGIGEGJ().SetFloat("Object ID. Case-Sensitive", Smooth);
			JFDGLLEOPGB().SetFloat("CameraFilterPack/BlurTiltShift_V", ICABEDDNGIH);
			CFCPHFMKHII().SetFloat("_Threshhold", LHOMPJOPKHE);
			DBOLLHHMKKN().SetVector("player.greenlifering", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 199f, 1625f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 959f)
			{
				HBJJOCHGOPH = 1199f;
			}
			NLFJGMBCICG().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			GHHPOGODBHB().SetFloat("/", Size);
			LONNIJMNKFB().SetFloat("CameraFilterPack/Blur_Movie", Smooth);
			ABHDNGIHBKE().SetFloat("note.3", ICABEDDNGIH);
			DONENAMLFLF().SetFloat("Fill Area", LHOMPJOPKHE);
			HHLFDHNEIAH().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1305f, 807f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MGFFNGEGFDC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LBIOIEANMGI()
	{
	}

	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 336f)
			{
				HBJJOCHGOPH = 1461f;
			}
			KJMECMIGJJA().SetFloat("Object ID", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat("Alpha", Size);
			NLFJGMBCICG().SetFloat("Right", Smooth);
			ABHDNGIHBKE().SetFloat("_TimeX", ICABEDDNGIH);
			NLFJGMBCICG().SetFloat(".highscore", LHOMPJOPKHE);
			GHHPOGODBHB().SetVector("BlockSize", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1287f, 10f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material KHCLIAMBBNC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void ICILLMAKLMI()
	{
		SCShader = Shader.Find("achievements.21.completed.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material MMOODGIODPC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-99);
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

	private void FLKEJJEGCFA()
	{
		SCShader = Shader.Find("Command not found!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material NDMPCDHADMJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IIJMIPBMMBF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1067f)
			{
				HBJJOCHGOPH = 1782f;
			}
			MMOODGIODPC().SetFloat("88f00bdf0ad61b16b803971ebe071962", HBJJOCHGOPH);
			DONENAMLFLF().SetFloat("ticket", Size);
			LMLENGFLEBD().SetFloat("HiddenToggle", Smooth);
			JFDGLLEOPGB().SetFloat("_TimeX", ICABEDDNGIH);
			NFKFAAHHLLM().SetFloat("_ScreenResolution", LHOMPJOPKHE);
			CFCPHFMKHII().SetVector("https://discord.gg/intralism", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1727f, 699f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JDGFCEPDKAJ()
	{
	}

	private void OOGIHDLBBLM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1096f)
			{
				HBJJOCHGOPH = 541f;
			}
			JFDGLLEOPGB().SetFloat("/music", HBJJOCHGOPH);
			CFCPHFMKHII().SetFloat("_Min", Size);
			EOCCJGIGEGJ().SetFloat("ItemNameText", Smooth);
			HFBJAOFLCJI().SetFloat("_Value", ICABEDDNGIH);
			GHHPOGODBHB().SetFloat("_Value3", LHOMPJOPKHE);
			KBOPGONOCNP().SetVector(",", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 774f, 477f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CBIBDOIBJAI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NPLCENPNJBM()
	{
		SCShader = Shader.Find("{STEAM_CLAN_IMAGE}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AMHEJBMLFNM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NEFHGMNAPEP()
	{
		SCShader = Shader.Find("BitsData");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LFAFJKJAEEL()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JOPCCCCHNLI()
	{
		SCShader = Shader.Find(".sawoutdatedmessage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HNILMGEKDEC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JHLGHODFJOO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Update()
	{
	}

	private void MGMAOBPPOBJ()
	{
		SCShader = Shader.Find("Result for ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material NLFJGMBCICG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void PMPKMGKAAJH()
	{
		SCShader = Shader.Find("Connection error: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ECBILENEOOL()
	{
		SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
