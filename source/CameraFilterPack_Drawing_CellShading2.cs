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
		SCShader = Shader.Find("GlassColor");
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
			KDMBOKLMADJ().SetFloat("DISTORT", HBJJOCHGOPH);
			KDMBOKLMADJ().SetFloat("CameraFilterPack/Distortion_FishEye", EdgeSize);
			DOHGBNPMBKG().SetFloat("_TimeX", ColorLevel);
			NBPKMLMCHFN.SetFloat("{0:0} minute{1}, ", Blur);
			HFBJAOFLCJI().SetVector("_MainTex", new Vector2(Screen.width, Screen.height));
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
			ADBKPGFMNKO().SetFloat("_TimeX", HBJJOCHGOPH);
			HEHKGPKLAKK().SetFloat(", data: ", EdgeSize);
			HKGAONMOBMH().SetFloat("CameraFilterPack/Blur_Movie", ColorLevel);
			GJHPODJOBHL().SetFloat(", ", Blur);
			GJHPODJOBHL().SetVector("challenges.", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
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
			ADBKPGFMNKO().SetFloat("_TimeX", HBJJOCHGOPH);
			HEHKGPKLAKK().SetFloat("Hidden/Image Effects/Cinematic/MotionBlur/FrameBlending", EdgeSize);
			CECJJMKLEAK().SetFloat("UseScanLine", ColorLevel);
			MCDGIILBNIF().SetFloat(" ", Blur);
			NBMPPNFKFLB().SetVector("No child content found, exiting..", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BKKJJJGADLM());
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
			KDMBOKLMADJ().SetFloat(": ", HBJJOCHGOPH);
			BLMPMOIDGMG().SetFloat("_BlurRadius", EdgeSize);
			KDMBOKLMADJ().SetFloat("Done!", ColorLevel);
			CFCPHFMKHII().SetFloat("PLEASE WAIT", Blur);
			NLFJGMBCICG().SetVector("_UV_Transform", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CECJJMKLEAK());
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
		SCShader = Shader.Find("Items");
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
			HFBJAOFLCJI().SetFloat("_SizeY", HBJJOCHGOPH);
			CECJJMKLEAK().SetFloat("End Value should be greater than the start value, values not changed", EdgeSize);
			BLMPMOIDGMG().SetFloat("Case-Sensitive", ColorLevel);
			BLMPMOIDGMG().SetFloat("Can't start OFFLINE mode while connected!", Blur);
			CECJJMKLEAK().SetVector("ShadersToggle", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
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
		SCShader = Shader.Find(" not found");
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
			ADAFMBOGPLN().SetFloat("RateButton", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_VignetteColor", EdgeSize);
			KDMBOKLMADJ().SetFloat("--------------------------------", ColorLevel);
			BKKJJJGADLM().SetFloat("IntraSig", Blur);
			HKGAONMOBMH().SetVector("OK", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BKKJJJGADLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JMEOGJHCONJ()
	{
		SCShader = Shader.Find("_Value6");
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
			BAGICADFBAB().SetFloat(".GoalProgress", HBJJOCHGOPH);
			BLMPMOIDGMG().SetFloat("GlassesColor", EdgeSize);
			BKKJJJGADLM().SetFloat("_Exposure", ColorLevel);
			NBMPPNFKFLB().SetFloat("<color=#{0}>{1}</color>", Blur);
			LENEJAGLCNL().SetVector("SpawnObj", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KDMBOKLMADJ());
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
			BAGICADFBAB().SetFloat("The given 2D texture ", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("settings_bindings_controller_type", EdgeSize);
			LEIAFCPJMDP().SetFloat("Type \"help\" for list of commands", ColorLevel);
			BLMPMOIDGMG().SetFloat("_History4Weight", Blur);
			NLFJGMBCICG().SetVector("resource id", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BAGICADFBAB());
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
			CFCPHFMKHII().SetFloat("float,10", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("skin.hit_normal", EdgeSize);
			HFBJAOFLCJI().SetFloat("_Radius2", ColorLevel);
			JFDGLLEOPGB().SetFloat("_Offsets", Blur);
			HFBJAOFLCJI().SetVector("_ScreenResolution", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
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
		SCShader = Shader.Find("_Metrics");
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
		SCShader = Shader.Find("_TimeX");
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
			KDMBOKLMADJ().SetFloat("EventTimeInputField", HBJJOCHGOPH);
			CFCPHFMKHII().SetFloat("Fade", EdgeSize);
			BKKJJJGADLM().SetFloat("_Bloom4", ColorLevel);
			BKKJJJGADLM().SetFloat("PLEASE WAIT", Blur);
			JFDGLLEOPGB().SetVector("Joystick1Button12", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BAGICADFBAB());
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
		SCShader = Shader.Find("_Value3");
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
			IIJMIPBMMBF().SetFloat("OnAwakeRPC", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat(" TimeOfRespawn: ", EdgeSize);
			GJHPODJOBHL().SetFloat("[PlayerBase] Saveing checkpoint data", ColorLevel);
			NBPKMLMCHFN.SetFloat(" cannot be used as a 3D LUT.", Blur);
			MCDGIILBNIF().SetVector("CameraFilterPack_Paper1", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KDMKDEKCELE()
	{
		SCShader = Shader.Find("_TimeX");
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
			HEHKGPKLAKK().SetFloat("_Axis", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("_TimeX", EdgeSize);
			JFDGLLEOPGB().SetFloat("ViewMenu", ColorLevel);
			CECJJMKLEAK().SetFloat("\\\"", Blur);
			BAGICADFBAB().SetVector("PowerUp", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
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
		SCShader = Shader.Find("Hidden/Image Effects/Cinematic/Bloom");
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
			LEIAFCPJMDP().SetFloat("_Value13", HBJJOCHGOPH);
			LENEJAGLCNL().SetFloat("Object ID. Case-Sensitive", EdgeSize);
			BKKJJJGADLM().SetFloat("CameraFilterPack/Colors_RgbClamp", ColorLevel);
			NBPKMLMCHFN.SetFloat("{0}", Blur);
			ADAFMBOGPLN().SetVector("_Value3", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
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
			CFCPHFMKHII().SetFloat("MapEditor v.", HBJJOCHGOPH);
			BLMPMOIDGMG().SetFloat("SpawnObj", EdgeSize);
			OKJOKHGJHGF().SetFloat("tagElement", ColorLevel);
			GJHPODJOBHL().SetFloat("*.workshop.json", Blur);
			DOHGBNPMBKG().SetVector("DPADHOR", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFCPHFMKHII());
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
		SCShader = Shader.Find("[PlayerBase] Loaded music");
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
		SCShader = Shader.Find("player.dragon");
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
			BAGICADFBAB().SetFloat("CameraFilterPack/Color_Contrast", HBJJOCHGOPH);
			HEHKGPKLAKK().SetFloat("[SERVER] Player ", EdgeSize);
			IIJMIPBMMBF().SetFloat("settings_bindings_controller_type", ColorLevel);
			NBPKMLMCHFN.SetFloat("Uploading preview image", Blur);
			NLFJGMBCICG().SetVector("_ScreenResolution", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
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
			OKJOKHGJHGF().SetFloat("_FgCocMask", HBJJOCHGOPH);
			LEIAFCPJMDP().SetFloat("_MainTex2", EdgeSize);
			MMOODGIODPC().SetFloat("workshop.", ColorLevel);
			ADBKPGFMNKO().SetFloat("_CameraToWorldMatrix", Blur);
			ADBKPGFMNKO().SetVector("_Distance", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
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
			IIJMIPBMMBF().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			OKJOKHGJHGF().SetFloat("https://steamcommunity.com/app/513510/workshop/", EdgeSize);
			LENEJAGLCNL().SetFloat(" ", ColorLevel);
			HKGAONMOBMH().SetFloat("settings.volume.sfx", Blur);
			BLMPMOIDGMG().SetVector("shader.invert", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF());
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
			BAGICADFBAB().SetFloat("[PlayerBase] Ready", HBJJOCHGOPH);
			ADAFMBOGPLN().SetFloat("_FresnelFadePower", EdgeSize);
			BAGICADFBAB().SetFloat("player.greenarc", ColorLevel);
			BAGICADFBAB().SetFloat("_Value2", Blur);
			MCDGIILBNIF().SetVector(". The group number should be at least 1.", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADAFMBOGPLN());
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
			CECJJMKLEAK().SetFloat("_Value2", HBJJOCHGOPH);
			CECJJMKLEAK().SetFloat("_Vignette", EdgeSize);
			BKKJJJGADLM().SetFloat("/", ColorLevel);
			BLMPMOIDGMG().SetFloat("0.00", Blur);
			IIJMIPBMMBF().SetVector("[PlayerController] ", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CECJJMKLEAK());
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
		SCShader = Shader.Find("https://steamcommunity.com/app/513510/workshop/");
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
			HKGAONMOBMH().SetFloat("NameText", HBJJOCHGOPH);
			LENEJAGLCNL().SetFloat("[NetworkManager] Connected to ", EdgeSize);
			JFDGLLEOPGB().SetFloat("time", ColorLevel);
			BLMPMOIDGMG().SetFloat("w", Blur);
			KDMBOKLMADJ().SetVector("#highscore", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFCPHFMKHII());
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
			NBMPPNFKFLB().SetFloat("CameraFilterPack/Blend2Camera_Multiply", HBJJOCHGOPH);
			CFCPHFMKHII().SetFloat("_TimeX", EdgeSize);
			ADAFMBOGPLN().SetFloat("settings.volume.menu", ColorLevel);
			ADBKPGFMNKO().SetFloat("offsets", Blur);
			GJHPODJOBHL().SetVector("CameraFilterPack/Blend2Camera_SplitScreen", new Vector2(Screen.width, Screen.height));
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
			NBMPPNFKFLB().SetFloat("achievements.26.progress", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("received</b>\n#reason: ", EdgeSize);
			NLFJGMBCICG().SetFloat("Command not found!", ColorLevel);
			ADAFMBOGPLN().SetFloat("/", Blur);
			BKKJJJGADLM().SetVector("[EMPTY]", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
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
			CECJJMKLEAK().SetFloat("/", HBJJOCHGOPH);
			HKGAONMOBMH().SetFloat("settings.enablerankingnotifications", EdgeSize);
			MMOODGIODPC().SetFloat("Set Object Rotation", ColorLevel);
			OKJOKHGJHGF().SetFloat("_TimeX", Blur);
			HKGAONMOBMH().SetVector("Data/Localization", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BLMPMOIDGMG());
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
			HEHKGPKLAKK().SetFloat("_TimeX", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat(" | ", EdgeSize);
			BKKJJJGADLM().SetFloat("PlayButton", ColorLevel);
			BKKJJJGADLM().SetFloat("AudioSampler", Blur);
			JFDGLLEOPGB().SetVector("_ScreenResolution", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BKKJJJGADLM());
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
			KDMBOKLMADJ().SetFloat("_Value2", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("CameraFilterPack/BlurTiltShift_V", EdgeSize);
			CFCPHFMKHII().SetFloat("_Value12", ColorLevel);
			BKKJJJGADLM().SetFloat("%]</b> ", Blur);
			BLMPMOIDGMG().SetVector("OK", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
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
			HFBJAOFLCJI().SetFloat("_Distortion", HBJJOCHGOPH);
			HKGAONMOBMH().SetFloat("CameraFilterPack/Blend2Camera_SoftLight", EdgeSize);
			KDMBOKLMADJ().SetFloat("[PlayerController] ", ColorLevel);
			GJHPODJOBHL().SetFloat("Please specify a map name or buildID", Blur);
			NBMPPNFKFLB().SetVector("_AlphaHexa", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFCPHFMKHII());
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
		SCShader = Shader.Find("ReJoinRoom failed due to offline mode.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FHPFJBFCOOF()
	{
		SCShader = Shader.Find("Added unlock condition");
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
			CFCPHFMKHII().SetFloat("inventory.selected.", HBJJOCHGOPH);
			GJHPODJOBHL().SetFloat("/", EdgeSize);
			BKKJJJGADLM().SetFloat("_ScreenResolution", ColorLevel);
			MCDGIILBNIF().SetFloat("/icon", Blur);
			BKKJJJGADLM().SetVector("Identity LUT", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BLMPMOIDGMG());
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
		SCShader = Shader.Find("Tab2Content");
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
			ADAFMBOGPLN().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			LEIAFCPJMDP().SetFloat(" not exist", EdgeSize);
			ADAFMBOGPLN().SetFloat("_ScreenResolution", ColorLevel);
			LENEJAGLCNL().SetFloat("_ScreenResolution", Blur);
			LENEJAGLCNL().SetVector("_Intensity", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LEIAFCPJMDP());
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
