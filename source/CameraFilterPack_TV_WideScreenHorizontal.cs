// CameraFilterPack_TV_WideScreenHorizontal
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/TV/WideScreenHorizontal")]
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
			LPCHMEKDCHI().SetFloat("D-Pad Right", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("offsets", Size);
			IGKFMCPDNOI().SetFloat("CameraFilterPack/Vision_Blood", Smooth);
			LPCHMEKDCHI().SetFloat(": ", ICABEDDNGIH);
			FAIFBBGFAIB().SetFloat("value", LHOMPJOPKHE);
			KBOPGONOCNP().SetVector("ws://", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1076f, 117f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB());
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
			MMOODGIODPC().SetFloat("Mouse2", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("AmbientOcclusion", Size);
			LPCHMEKDCHI().SetFloat("float,2", Smooth);
			EOCCJGIGEGJ().SetFloat("_BlurRadius4", ICABEDDNGIH);
			KEMAALEODNH().SetFloat("Fade", LHOMPJOPKHE);
			DBOLLHHMKKN().SetVector("_Red_R", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1744f, 575f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NDMPCDHADMJ());
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
			KBOPGONOCNP().SetFloat(": ", HBJJOCHGOPH);
			LPCHMEKDCHI().SetFloat("|", Size);
			KEMJNOMIPHN().SetFloat("CameraFilterPack/3D_Computer", Smooth);
			FAIFBBGFAIB().SetFloat("UnityEngine.MonoBehaviour", ICABEDDNGIH);
			CFCPHFMKHII().SetFloat("Tab1Content", LHOMPJOPKHE);
			KEMJNOMIPHN().SetVector("score", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1938f, 1454f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HMPGIFBJFIK()
	{
		SCShader = Shader.Find("value");
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
			KHCLIAMBBNC().SetFloat("0.00", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat("#FFFFFFFF", Size);
			NLFJGMBCICG().SetFloat("_Value4", Smooth);
			KHCLIAMBBNC().SetFloat("[Left]", ICABEDDNGIH);
			LPCHMEKDCHI().SetFloat("GlassesColor2", LHOMPJOPKHE);
			JFDGLLEOPGB().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1684f, 1812f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KHCLIAMBBNC());
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
		SCShader = Shader.Find("Warning: Unhandled event ");
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
			NFKFAAHHLLM().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			MMOODGIODPC().SetFloat("FavoriteButton", Size);
			GHHPOGODBHB().SetFloat("_Value2", Smooth);
			KEMAALEODNH().SetFloat("y", ICABEDDNGIH);
			KHCLIAMBBNC().SetFloat("ComboScoreText", LHOMPJOPKHE);
			KBOPGONOCNP().SetVector(".lastCheckpoint.bgcolor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1424f, 367f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
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
			NBPKMLMCHFN.SetFloat("_Green_B", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("_TimeX", Size);
			LONNIJMNKFB().SetFloat(":", Smooth);
			LONNIJMNKFB().SetFloat("buttons", ICABEDDNGIH);
			IGKFMCPDNOI().SetFloat("_TimeX", LHOMPJOPKHE);
			KBOPGONOCNP().SetVector("_UserLutParams", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 386f, 1893f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
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
			KHCLIAMBBNC().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			OHKGGPFGLFD().SetFloat("[PlayerController] ", Size);
			ABHDNGIHBKE().SetFloat(":\n", Smooth);
			HHLFDHNEIAH().SetFloat("\\n", ICABEDDNGIH);
			IGKFMCPDNOI().SetFloat("menu.selectedplaymode", LHOMPJOPKHE);
			MMOODGIODPC().SetVector("DPADVER", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 335f, 766f));
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
			AELJLBOJAIL().SetFloat("mapselector.lastSearch", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_MainTex2", Size);
			JFDGLLEOPGB().SetFloat("[MenuScene] Error: ", Smooth);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/FX_Glitch1", ICABEDDNGIH);
			NDMPCDHADMJ().SetFloat("_TimeX", LHOMPJOPKHE);
			NDMPCDHADMJ().SetVector("AskForPickupItemSpawnTimes", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 814f, 938f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
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
		SCShader = Shader.Find("return ");
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
		SCShader = Shader.Find("_TimeX");
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
			JFDGLLEOPGB().SetFloat("_AlphaUV", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value4", Size);
			EOCCJGIGEGJ().SetFloat("Noise & Grain effect failing as noise texture is not assigned. please assign.", Smooth);
			EOCCJGIGEGJ().SetFloat("_ScreenResolution", ICABEDDNGIH);
			MMOODGIODPC().SetFloat("[PlayerController] ", LHOMPJOPKHE);
			ABHDNGIHBKE().SetVector("_BlurVector", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 8f, 921f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
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
			JFDGLLEOPGB().SetFloat("set environment id", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("masterSteamID", Size);
			DONENAMLFLF().SetFloat("Vignette", Smooth);
			GHHPOGODBHB().SetFloat("_ScreenResolution", ICABEDDNGIH);
			IIJMIPBMMBF().SetFloat("settings.enablerankingnotifications", LHOMPJOPKHE);
			NFKFAAHHLLM().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 148f, 146f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LMLENGFLEBD());
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
			MMOODGIODPC().SetFloat("_MainTex2", HBJJOCHGOPH);
			LMLENGFLEBD().SetFloat(".workshop.json", Size);
			KHCLIAMBBNC().SetFloat("CloseConnection: No such player connected!", Smooth);
			AELJLBOJAIL().SetFloat("Day_", ICABEDDNGIH);
			NBPKMLMCHFN.SetFloat("_LoopCount", LHOMPJOPKHE);
			DONENAMLFLF().SetVector("<b>Max Score</b>:", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 250f, 1976f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NKFDNIAKGEO()
	{
		SCShader = Shader.Find("/");
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
		SCShader = Shader.Find("_TimeX");
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
			DONENAMLFLF().SetFloat("custom", HBJJOCHGOPH);
			HHLFDHNEIAH().SetFloat("SpeedSlider", Size);
			LONNIJMNKFB().SetFloat("y", Smooth);
			LMLENGFLEBD().SetFloat("_AdaptParams", ICABEDDNGIH);
			NLFJGMBCICG().SetFloat("_MainTex2", LHOMPJOPKHE);
			HFBJAOFLCJI().SetVector("Tab1Content", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1610f, 1742f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
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
			IGKFMCPDNOI().SetFloat("_Value", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat(".lastCheckpoint.checkpointsUsed", Size);
			ABHDNGIHBKE().SetFloat("CameraFilterPack/Colors_BleachBypass", Smooth);
			MMOODGIODPC().SetFloat("https://steamcommunity.com/sharedfiles/filedetails/?id=", ICABEDDNGIH);
			NBPKMLMCHFN.SetFloat("-1", LHOMPJOPKHE);
			HFBJAOFLCJI().SetVector("CameraFilterPack/FX_Psycho", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 964f, 127f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DFFKKLAPHCC()
	{
		SCShader = Shader.Find("[MapEditor] Loading events...");
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
			DONENAMLFLF().SetFloat(" - LOCAL", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("/", Size);
			ACHNOHCLGOO().SetFloat("LoadingStatusText", Smooth);
			MMOODGIODPC().SetFloat("_Value4", ICABEDDNGIH);
			KEMAALEODNH().SetFloat("_Value2", LHOMPJOPKHE);
			HHLFDHNEIAH().SetVector("menu.tabid", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1892f, 131f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
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
			NDMPCDHADMJ().SetFloat("...", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("MascotChallenge2019", Size);
			KJMECMIGJJA().SetFloat("color", Smooth);
			NDMPCDHADMJ().SetFloat("MapFolderInputField", ICABEDDNGIH);
			KEMAALEODNH().SetFloat("\n", LHOMPJOPKHE);
			LPCHMEKDCHI().SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 328f, 802f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DONENAMLFLF());
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
			NDMPCDHADMJ().SetFloat("</color>", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", Size);
			KJMECMIGJJA().SetFloat("_Blend", Smooth);
			NDMPCDHADMJ().SetFloat(".lastCheckpoint.perfectHits", ICABEDDNGIH);
			ABHDNGIHBKE().SetFloat("_Distortion", LHOMPJOPKHE);
			NBPKMLMCHFN.SetVector("1.87", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1385f, 995f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
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
		SCShader = Shader.Find("_ScreenResolution");
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
			ACHNOHCLGOO().SetFloat("SetSpeed", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("_TimeX", Size);
			JFDGLLEOPGB().SetFloat("-1", Smooth);
			DKNJGHFLAIF().SetFloat("[Right]", ICABEDDNGIH);
			KHCLIAMBBNC().SetFloat("#close", LHOMPJOPKHE);
			MMOODGIODPC().SetVector("_Value4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1797f, 678f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
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
		SCShader = Shader.Find("[PlayerBase] SetSpeed error: ");
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
			ABHDNGIHBKE().SetFloat("_Gain", HBJJOCHGOPH);
			NFKFAAHHLLM().SetFloat("action", Size);
			KJMECMIGJJA().SetFloat("HPText", Smooth);
			GHHPOGODBHB().SetFloat("#91CCFF", ICABEDDNGIH);
			JFDGLLEOPGB().SetFloat("_Fade", LHOMPJOPKHE);
			LPCHMEKDCHI().SetVector("#savemapbeforeuploading", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 444f, 584f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHLFDHNEIAH());
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
			KHCLIAMBBNC().SetFloat("y", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("SpawnObj", Size);
			KHCLIAMBBNC().SetFloat("Object ID. Case-Sensitive", Smooth);
			EOCCJGIGEGJ().SetFloat("_MainTex2", ICABEDDNGIH);
			KEMAALEODNH().SetFloat("_TapLowBackground", LHOMPJOPKHE);
			NFKFAAHHLLM().SetVector("player.bluelifering", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 199f, 1625f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
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
			EOCCJGIGEGJ().SetFloat("_Tint", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat("/", Size);
			DBOLLHHMKKN().SetFloat("CameraFilterPack/Blur_Movie", Smooth);
			EOCCJGIGEGJ().SetFloat("CheckCombo", ICABEDDNGIH);
			FAIFBBGFAIB().SetFloat("Fill Area", LHOMPJOPKHE);
			KJMECMIGJJA().SetVector("_Fade", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1305f, 807f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
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
			AELJLBOJAIL().SetFloat("Object ID", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("STICKRVER", Size);
			EOCCJGIGEGJ().SetFloat("GameScene", Smooth);
			GHHPOGODBHB().SetFloat("_TimeX", ICABEDDNGIH);
			NLFJGMBCICG().SetFloat(".highscore", LHOMPJOPKHE);
			NLFJGMBCICG().SetVector("_SprTex", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1287f, 10f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LMLENGFLEBD());
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
		SCShader = Shader.Find(".completed");
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
		SCShader = Shader.Find("Localization Servise\nWorking commands:\nset <language>\nlist\nkeys");
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
			DONENAMLFLF().SetFloat("Did not read byte array properly", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat("[", Size);
			FAIFBBGFAIB().SetFloat("TwoHands", Smooth);
			LPCHMEKDCHI().SetFloat("_MainTex2", ICABEDDNGIH);
			ABHDNGIHBKE().SetFloat("_Value4", LHOMPJOPKHE);
			KJMECMIGJJA().SetVector("?page=addtip", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1727f, 699f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OHKGGPFGLFD());
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
			IIJMIPBMMBF().SetFloat("/music", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("UI Extensions/SoftMaskShaderText", Size);
			NBPKMLMCHFN.SetFloat("ItemsCountText", Smooth);
			LONNIJMNKFB().SetFloat("_Value", ICABEDDNGIH);
			KEMJNOMIPHN().SetFloat("_Value3", LHOMPJOPKHE);
			EOCCJGIGEGJ().SetVector(".completedMaps", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 774f, 477f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OHKGGPFGLFD());
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
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JOPCCCCHNLI()
	{
		SCShader = Shader.Find("[MapEditor] Openning ");
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
		SCShader = Shader.Find("Bad parameters for getbool! Use <key> <value>");
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
		SCShader = Shader.Find("&search=");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ECBILENEOOL()
	{
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
