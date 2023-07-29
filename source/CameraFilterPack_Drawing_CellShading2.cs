// CameraFilterPack_Drawing_CellShading2
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Drawing/CellShading2")]
[ExecuteInEditMode]
public class CameraFilterPack_Drawing_CellShading2 : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 1f)]
	public float EdgeSize = 0.1f;

	[Range(0f, 10f)]
	public float ColorLevel = 4f;

	[Range(0f, 1f)]
	public float Blur = 1f;

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
	private Material NBMPPNFKFLB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-111);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IIJMIPBMMBF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)111;
		}
		return BJFKDHHMLJH;
	}

	private void IDJKNBDKHBD()
	{
		SCShader = Shader.Find("UseScanLineSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OPCLBGHAPMG()
	{
	}

	private void FJKJGBLPDGG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 894f)
			{
				HBJJOCHGOPH = 1923f;
			}
			MCDGIILBNIF().SetFloat("VIGNETTE_DESAT", HBJJOCHGOPH);
			HEHKGPKLAKK().SetFloat("_TimeX", EdgeSize);
			NBPKMLMCHFN.SetFloat("_Value", ColorLevel);
			JFDGLLEOPGB().SetFloat("{0:0} minute{1}, ", Blur);
			MCDGIILBNIF().SetVector("_UV_Transform", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LKJMIODJGCM()
	{
	}

	private void KLOLKEBAPFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BJOHDLNDFAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1285f)
			{
				HBJJOCHGOPH = 1815f;
			}
			CECJJMKLEAK().SetFloat("_Value2", HBJJOCHGOPH);
			HKGAONMOBMH().SetFloat("return ", EdgeSize);
			IIJMIPBMMBF().SetFloat("CameraFilterPack/Blur_Movie", ColorLevel);
			HFBJAOFLCJI().SetFloat("offline", Blur);
			NLFJGMBCICG().SetVector(".message", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	private void APKNAPHOFHC()
	{
	}

	[SpecialName]
	private Material OKJOKHGJHGF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-87);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material BAGICADFBAB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)111;
		}
		return BJFKDHHMLJH;
	}

	private void EJFJENFKLND()
	{
	}

	private void HONBLGFDMLL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1333f)
			{
				HBJJOCHGOPH = 422f;
			}
			CECJJMKLEAK().SetFloat("_DotSize", HBJJOCHGOPH);
			BKKJJJGADLM().SetFloat("_History2LumaTex", EdgeSize);
			LENEJAGLCNL().SetFloat("_MainTex2", ColorLevel);
			KDMBOKLMADJ().SetFloat("CreateRoom failed, client stays on masterserver: {0}.", Blur);
			HFBJAOFLCJI().SetVector("Year_", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NNBCLMJGFEN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LMBDNPLDGIJ()
	{
	}

	private void JBMBNKOOENB()
	{
	}

	private void IFJDKDFLGBG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1701f)
			{
				HBJJOCHGOPH = 1023f;
			}
			JFDGLLEOPGB().SetFloat(" / ", HBJJOCHGOPH);
			CECJJMKLEAK().SetFloat("_Offsets", EdgeSize);
			BLMPMOIDGMG().SetFloat("OK", ColorLevel);
			NBPKMLMCHFN.SetFloat("Preparing content", Blur);
			JFDGLLEOPGB().SetVector("_Overlay", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material BKKJJJGADLM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void GLEJGFLCLPJ()
	{
		SCShader = Shader.Find("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material LENEJAGLCNL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	private void OBAEDJJDCPN()
	{
	}

	private void KKLMPKLKAEM()
	{
	}

	private void LADCJEIALMH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MKOMIDCPCDC()
	{
		SCShader = Shader.Find("Hex value #RRGGBB");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material HEHKGPKLAKK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void OPKNFOGMGII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1383f)
			{
				HBJJOCHGOPH = 333f;
			}
			ADBKPGFMNKO().SetFloat("_SizeY", HBJJOCHGOPH);
			ADAFMBOGPLN().SetFloat("InputField", EdgeSize);
			ADAFMBOGPLN().SetFloat("Case-Sensitive", ColorLevel);
			MMOODGIODPC().SetFloat("Can't change CrcCheckEnabled while being connected. CrcCheckEnabled stays ", Blur);
			NBMPPNFKFLB().SetVector("FPSToggle", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material BLMPMOIDGMG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void NNCCPEBIAKH()
	{
		SCShader = Shader.Find("bool");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LPMINJJPDCH()
	{
	}

	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1728f)
			{
				HBJJOCHGOPH = 1503f;
			}
			DOHGBNPMBKG().SetFloat("LeaderboardsButton", HBJJOCHGOPH);
			LEIAFCPJMDP().SetFloat("DISTORT", EdgeSize);
			IIJMIPBMMBF().SetFloat("-", ColorLevel);
			LEIAFCPJMDP().SetFloat("request", Blur);
			KDMBOKLMADJ().SetVector("[NetworkManager] Connection failed: ", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JMEOGJHCONJ()
	{
		SCShader = Shader.Find("_Value7");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NCPAFCKGJEA()
	{
	}

	[SpecialName]
	private Material HKGAONMOBMH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
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
			NBPKMLMCHFN.SetFloat("_EdgeSize", EdgeSize);
			NBPKMLMCHFN.SetFloat("_ColorLevel", ColorLevel);
			NBPKMLMCHFN.SetFloat("_Distortion", Blur);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 279f)
			{
				HBJJOCHGOPH = 1477f;
			}
			LEIAFCPJMDP().SetFloat(",", HBJJOCHGOPH);
			LENEJAGLCNL().SetFloat("GlassesColor2", EdgeSize);
			HKGAONMOBMH().SetFloat("_Gamma", ColorLevel);
			KDMBOKLMADJ().SetFloat("<color=#{0}>{1}</color>", Blur);
			NBPKMLMCHFN.SetVector("SpawnObj", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FIKNBPAIFBI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 108f)
			{
				HBJJOCHGOPH = 1022f;
			}
			ADAFMBOGPLN().SetFloat(" cannot be used as a 3D LUT.", HBJJOCHGOPH);
			HKGAONMOBMH().SetFloat("settings_bindings_", EdgeSize);
			IIJMIPBMMBF().SetFloat("================================", ColorLevel);
			ADBKPGFMNKO().SetFloat("_NormalAndRoughnessTexture", Blur);
			BAGICADFBAB().SetVector("position", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GNPDGBNDCPL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material DOHGBNPMBKG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void MFMIODIAKNI()
	{
	}

	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 498f)
			{
				HBJJOCHGOPH = 82f;
			}
			OKJOKHGJHGF().SetFloat("float,10", HBJJOCHGOPH);
			GJHPODJOBHL().SetFloat("skin.hit_normal", EdgeSize);
			NBPKMLMCHFN.SetFloat("_BlurFilterDistance", ColorLevel);
			MMOODGIODPC().SetFloat("_SecondTex", Blur);
			JFDGLLEOPGB().SetVector("CameraFilterPack/Edge_Edge_filter", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IAJKLKJJKEJ()
	{
	}

	private void ANCKKLFPGDI()
	{
		SCShader = Shader.Find("_Params1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ICDBMJKMIKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IKDNLHLBHID()
	{
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 925f)
			{
				HBJJOCHGOPH = 842f;
			}
			HKGAONMOBMH().SetFloat("EventTimeInputField", HBJJOCHGOPH);
			ADAFMBOGPLN().SetFloat("Fade", EdgeSize);
			CFCPHFMKHII().SetFloat("_Bloom5", ColorLevel);
			NBPKMLMCHFN.SetFloat("Preparing configuration", Blur);
			LEIAFCPJMDP().SetVector("Xbox Home", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HLLHJIDOOGA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NNPBKKBFDHH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BKGJOECFMID()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material ADAFMBOGPLN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)97;
		}
		return BJFKDHHMLJH;
	}

	private void FHGKIOOMMOH()
	{
		SCShader = Shader.Find("_Offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LCDJFJIBADI()
	{
	}

	[SpecialName]
	private Material NLFJGMBCICG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)116;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material GJHPODJOBHL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void OFPPIKHNJOD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FMFNILJIEIA()
	{
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1696f)
			{
				HBJJOCHGOPH = 955f;
			}
			NBPKMLMCHFN.SetFloat(" PhotonView: ", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("PunRespawn", EdgeSize);
			CECJJMKLEAK().SetFloat("maps.", ColorLevel);
			KDMBOKLMADJ().SetFloat("_LutTex", Blur);
			DOHGBNPMBKG().SetVector("CameraFilterPack/Drawing_Paper", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KDMKDEKCELE()
	{
		SCShader = Shader.Find("_Fade");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 745f)
			{
				HBJJOCHGOPH = 1665f;
			}
			OKJOKHGJHGF().SetFloat("Curve texture", HBJJOCHGOPH);
			LEIAFCPJMDP().SetFloat("_TimeX", EdgeSize);
			IIJMIPBMMBF().SetFloat("ViewMenu", ColorLevel);
			HKGAONMOBMH().SetFloat("itemdefid[0]", Blur);
			NLFJGMBCICG().SetVector("Down", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CFIAKIJAILI()
	{
	}

	private void LEAHIBJDMBI()
	{
	}

	private void CEDFFAOOPOG()
	{
		SCShader = Shader.Find("_Curve");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DNENFLNCIJP()
	{
	}

	[SpecialName]
	private Material CECJJMKLEAK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void PHJLHCMCCKE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HDDECCMEJKA()
	{
	}

	private void KDMANOEMOCA()
	{
		SCShader = Shader.Find("Soundtrack");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material KDMBOKLMADJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void OMIHEBMMCPG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1359f)
			{
				HBJJOCHGOPH = 1310f;
			}
			OKJOKHGJHGF().SetFloat("_Value13", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("Object ID. Case-Sensitive", EdgeSize);
			HFBJAOFLCJI().SetFloat("CameraFilterPack/Colors_RgbClamp", ColorLevel);
			NBMPPNFKFLB().SetFloat("#no", Blur);
			GJHPODJOBHL().SetVector("_Value4", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material MCDGIILBNIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 456f)
			{
				HBJJOCHGOPH = 970f;
			}
			IIJMIPBMMBF().SetFloat("ResourcesConfig", HBJJOCHGOPH);
			HEHKGPKLAKK().SetFloat("[Down]", EdgeSize);
			NBPKMLMCHFN.SetFloat("tagElement", ColorLevel);
			OKJOKHGJHGF().SetFloat("Called GetNumberOfCurrentPlayers()", Blur);
			GJHPODJOBHL().SetVector("Joystick1Button", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BKKJJJGADLM());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-90);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material ADBKPGFMNKO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-103);
		}
		return BJFKDHHMLJH;
	}

	private void JABNHMIHBHC()
	{
		SCShader = Shader.Find("CameraFilterPack/FX_DigitalMatrix");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OCCGJMPAJIK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LLDHEJIEDHO()
	{
	}

	private void BGDPIHMAACO()
	{
		SCShader = Shader.Find("Texture2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LBIOIEANMGI()
	{
	}

	private void MANDOGNJJBD()
	{
	}

	private void BFGIMALGMAJ()
	{
	}

	private void BOPKKCAFODF()
	{
		SCShader = Shader.Find("CheckCombo");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HCIPECAOGIA()
	{
	}

	private void EODOHEAKJFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EIDKCANPHJE()
	{
	}

	private void OFIMMFHFHDD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ONPFGCEFMML()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AKCADICOFDD()
	{
	}

	[SpecialName]
	private Material JFDGLLEOPGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-94);
		}
		return BJFKDHHMLJH;
	}

	private void NKFDNIAKGEO()
	{
		SCShader = Shader.Find("player.linea");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void POJFHDFJOPE()
	{
	}

	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1733f)
			{
				HBJJOCHGOPH = 1398f;
			}
			BLMPMOIDGMG().SetFloat("_Contrast", HBJJOCHGOPH);
			LEIAFCPJMDP().SetFloat(" left", EdgeSize);
			HEHKGPKLAKK().SetFloat("All bindings reset to default values. PlayerPrefs have been removed for each key.", ColorLevel);
			MMOODGIODPC().SetFloat("#failed!", Blur);
			DOHGBNPMBKG().SetVector("_ScreenResolution", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BLMPMOIDGMG());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)116;
		}
		return BJFKDHHMLJH;
	}

	private void GOIMKCCICFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 339f)
			{
				HBJJOCHGOPH = 453f;
			}
			NBMPPNFKFLB().SetFloat("_Offsets", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("_MainTex2", EdgeSize);
			LENEJAGLCNL().SetFloat("workshop.", ColorLevel);
			DOHGBNPMBKG().SetFloat("_Axis", Blur);
			CFCPHFMKHII().SetVector("_ScreenResolution", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BAGICADFBAB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KMKLDAJLCNM()
	{
	}

	private void LAMEHAHJKMI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EKCJHNJGGAB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1381f)
			{
				HBJJOCHGOPH = 1951f;
			}
			OKJOKHGJHGF().SetFloat("CameraFilterPack/TV_Chromatical2", HBJJOCHGOPH);
			CECJJMKLEAK().SetFloat("https://store.steampowered.com/itemstore/513510/", EdgeSize);
			NBPKMLMCHFN.SetFloat("%", ColorLevel);
			ADBKPGFMNKO().SetFloat("settings.volume.editor", Blur);
			LEIAFCPJMDP().SetVector("inventory.selected.", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PKGJJFIFLII()
	{
	}

	private void AAEEHINDPNC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 308f)
			{
				HBJJOCHGOPH = 627f;
			}
			BAGICADFBAB().SetFloat("_DiffuseColor", HBJJOCHGOPH);
			HKGAONMOBMH().SetFloat("_ScreenSize", EdgeSize);
			CECJJMKLEAK().SetFloat("player.greenarc", ColorLevel);
			GJHPODJOBHL().SetFloat("_ScreenResolution", Blur);
			ADAFMBOGPLN().SetVector(". The group number should be at least 1.", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1135f)
			{
				HBJJOCHGOPH = 515f;
			}
			BKKJJJGADLM().SetFloat("_Value4", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("_Linecount", EdgeSize);
			MMOODGIODPC().SetFloat("/", ColorLevel);
			NBMPPNFKFLB().SetFloat("<b>Max Score</b>:", Blur);
			JFDGLLEOPGB().SetVector(": ", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void POEMOLBJDLG()
	{
	}

	private void FOAGAKFBIGD()
	{
	}

	private void MDNHCLKNCLE()
	{
		SCShader = Shader.Find("https://store.steampowered.com/itemstore/513510/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NAOLAJPDGIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 274f)
			{
				HBJJOCHGOPH = 1994f;
			}
			IIJMIPBMMBF().SetFloat("NameText", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat(" region", EdgeSize);
			LEIAFCPJMDP().SetFloat("[CraftingPanel] Init", ColorLevel);
			NLFJGMBCICG().SetFloat("y", Blur);
			HEHKGPKLAKK().SetVector("#highscore", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OEENOOGEEHD()
	{
	}

	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 815f)
			{
				HBJJOCHGOPH = 862f;
			}
			CFCPHFMKHII().SetFloat("CameraFilterPack/Blend2Camera_Multiply", HBJJOCHGOPH);
			BKKJJJGADLM().SetFloat("_ScreenResolution", EdgeSize);
			JFDGLLEOPGB().SetFloat("settings.volume.game", ColorLevel);
			DOHGBNPMBKG().SetFloat("tintColor", Blur);
			MCDGIILBNIF().SetVector("CameraFilterPack/Blend2Camera_SplitScreen", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 928f)
			{
				HBJJOCHGOPH = 1343f;
			}
			NBMPPNFKFLB().SetFloat("NEW_ACHIEVEMENT_1_26", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat("https://www.youtube.com/watch?v=cDVXukrKo74", EdgeSize);
			BAGICADFBAB().SetFloat("Bad parameters for set! Use <language>", ColorLevel);
			CFCPHFMKHII().SetFloat("MenuScene", Blur);
			NBPKMLMCHFN.SetVector("\\n", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KIEJKBNBHMD()
	{
	}

	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 212f)
			{
				HBJJOCHGOPH = 209f;
			}
			LENEJAGLCNL().SetFloat("Failed!", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("Scene", EdgeSize);
			IIJMIPBMMBF().SetFloat("Set Object Rotation", ColorLevel);
			LEIAFCPJMDP().SetFloat("_TimeX", Blur);
			LENEJAGLCNL().SetVector("[ERROR KEY {0}]", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JDGFCEPDKAJ()
	{
	}

	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 294f)
			{
				HBJJOCHGOPH = 826f;
			}
			NBMPPNFKFLB().SetFloat("_Value", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("<color=white>PhotonView Group: ", EdgeSize);
			JFDGLLEOPGB().SetFloat("  |  Events Count: ", ColorLevel);
			CECJJMKLEAK().SetFloat("AudioSampler", Blur);
			GJHPODJOBHL().SetVector("CameraFilterPack/Light_Water", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PHJJHFBLICM()
	{
	}

	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 278f)
			{
				HBJJOCHGOPH = 1969f;
			}
			NBPKMLMCHFN.SetFloat("_Value4", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/BlurTiltShift_V", EdgeSize);
			JFDGLLEOPGB().SetFloat("_Value13", ColorLevel);
			DOHGBNPMBKG().SetFloat("%]</b> ", Blur);
			NLFJGMBCICG().SetVector("Exit to menu?", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EIMNPCMHJLJ()
	{
		SCShader = Shader.Find("_Value6");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HHKBBEFJEBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1613f)
			{
				HBJJOCHGOPH = 398f;
			}
			JFDGLLEOPGB().SetFloat("_Distortion", HBJJOCHGOPH);
			LEIAFCPJMDP().SetFloat("CameraFilterPack/Blend2Camera_SoftLight", EdgeSize);
			CFCPHFMKHII().SetFloat(": ", ColorLevel);
			HFBJAOFLCJI().SetFloat("reset", Blur);
			DOHGBNPMBKG().SetVector("_AlphaHexa", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ODGMCJILIHF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FEKECCBFGMI()
	{
		SCShader = Shader.Find("PhotonNetwork.room is null. You don't have to call LeaveRoom() when you're not in one. State: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FHPFJBFCOOF()
	{
		SCShader = Shader.Find("LevelEditor/patterns");
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
			BJFKDHHMLJH.hideFlags = (HideFlags)107;
		}
		return BJFKDHHMLJH;
	}

	private void FJIKDJAMOHA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JNALDALAJLG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material LEIAFCPJMDP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.HideInInspector | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 517f)
			{
				HBJJOCHGOPH = 535f;
			}
			MCDGIILBNIF().SetFloat("inventory.selected.", HBJJOCHGOPH);
			HKGAONMOBMH().SetFloat("/", EdgeSize);
			JFDGLLEOPGB().SetFloat("Texture2", ColorLevel);
			OKJOKHGJHGF().SetFloat("/icon", Blur);
			NBMPPNFKFLB().SetVector("_MiddleGrey", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BAGICADFBAB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GPFJMKCGHGB()
	{
	}

	private void CHOPDIGHJNH()
	{
		SCShader = Shader.Find("SpeedSlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 780f)
			{
				HBJJOCHGOPH = 919f;
			}
			CECJJMKLEAK().SetFloat("CameraFilterPack/Vision_Plasma", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("[PlayerController] ", EdgeSize);
			ADAFMBOGPLN().SetFloat("CameraFilterPack/TV_Distorted", ColorLevel);
			ADAFMBOGPLN().SetFloat("_ScreenResolution", Blur);
			CECJJMKLEAK().SetVector("_Intensity", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HAHJJPLPOKB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GJCOELHNLJE()
	{
	}

	private void DKOPKPBLDHH()
	{
		SCShader = Shader.Find("Waiting to start");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Drawing_CellShading2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
