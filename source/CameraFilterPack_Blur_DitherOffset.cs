// CameraFilterPack_Blur_DitherOffset
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Blur/DitherOffset")]
[ExecuteInEditMode]
public class CameraFilterPack_Blur_DitherOffset : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(1f, 16f)]
	public int Level = 4;

	public Vector2 Distance = new Vector2(30f, 0f);

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

	private void MAOCOEGAFND()
	{
	}

	private void KCCIEMBMOBA()
	{
		SCShader = Shader.Find("restrictions\n\n#until: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void Update()
	{
	}

	private void HMPGIFBJFIK()
	{
		SCShader = Shader.Find("#alreadystarted");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DFENCIHAADO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AGEJKLMJGDO()
	{
		SCShader = Shader.Find("Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HLIAEEMGBHN()
	{
		SCShader = Shader.Find("_Distance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MMMDPANNAIO()
	{
		SCShader = Shader.Find("[Steamworks.NET] SteamAPI_Init() failed. Refer to Valve's documentation or the comment above this line for more information.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BJOHDLNDFAD()
	{
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
			if (HBJJOCHGOPH > 1856f)
			{
				HBJJOCHGOPH = 737f;
			}
			DNLMFEGJJDD().SetFloat("/icon", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("_Value4", Level);
			IONHGBPGCHK().SetVector("] Suggested ", Distance);
			DNLMFEGJJDD().SetVector("CameraFilterPack/Glasses_On", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1563f, 1980f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
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
			if (HBJJOCHGOPH > 1473f)
			{
				HBJJOCHGOPH = 363f;
			}
			HNICHJCGJOC().SetFloat("_HexaColor", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("Tab2Content", Level);
			IONHGBPGCHK().SetVector("_ScreenResolution", Distance);
			NBPKMLMCHFN.SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1543f, 1397f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 209f)
			{
				HBJJOCHGOPH = 1571f;
			}
			LONNIJMNKFB().SetFloat("settings.cameramovements", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_TimeX", Level);
			LONNIJMNKFB().SetVector("Joystick1Button4", Distance);
			HNICHJCGJOC().SetVector(",", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 83f, 1643f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LOMDIOLNFHI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GHILDCBCDJI()
	{
	}

	[SpecialName]
	private Material LONNIJMNKFB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 542f)
			{
				HBJJOCHGOPH = 426f;
			}
			LNLKMDPHDCC().SetFloat("Object ID. Case-Sensitive", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("Joystick1Button5", Level);
			LONNIJMNKFB().SetVector("[Up]", Distance);
			LNLKMDPHDCC().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 487f, 1804f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1315f)
			{
				HBJJOCHGOPH = 1359f;
			}
			LNLKMDPHDCC().SetFloat("shader.none", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("_MainTex2", Level);
			DNLMFEGJJDD().SetVector("Created", Distance);
			NBPKMLMCHFN.SetVector(",", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1410f, 1739f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LECCHIAFGGE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DLBODOFAJGM()
	{
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Blur_DitherOffset");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NAOLAJPDGIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FEHCNJLLJMP()
	{
		SCShader = Shader.Find("EnvironmentSlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JHLGHODFJOO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material DNLMFEGJJDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)85;
		}
		return BJFKDHHMLJH;
	}

	private void IIFCIDDJHPM()
	{
	}

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-78);
		}
		return BJFKDHHMLJH;
	}

	private void NCNPAKFAFOE()
	{
		SCShader = Shader.Find("[PlayerBase] ShowImage \"");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BMIOFJFMCBG()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 348f)
			{
				HBJJOCHGOPH = 1999f;
			}
			IONHGBPGCHK().SetFloat("path", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("_Value3", Level);
			DNLMFEGJJDD().SetVector(" This is not possible to be called for standalone input. Please check your platform and code where this is called", Distance);
			LNLKMDPHDCC().SetVector("Hidden/Image Effects/Cinematic/AmbientOcclusion", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 727f, 228f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 878f)
			{
				HBJJOCHGOPH = 1781f;
			}
			NBPKMLMCHFN.SetFloat("menu.enableselectormusic", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("_Green_B", Level);
			LONNIJMNKFB().SetVector("Dropped Object: ", Distance);
			DNLMFEGJJDD().SetVector("???", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 150f, 1168f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HNICHJCGJOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)104;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material LNLKMDPHDCC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.NotEditable);
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
			NBPKMLMCHFN.SetFloat("_Level", Level);
			NBPKMLMCHFN.SetVector("_Distance", Distance);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FDPOFMCFBMF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 438f)
			{
				HBJJOCHGOPH = 432f;
			}
			HNICHJCGJOC().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("_TimeX", Level);
			DNLMFEGJJDD().SetVector("_TimeX", Distance);
			LONNIJMNKFB().SetVector("CameraFilterPack/Blend2Camera_DarkerColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1667f, 1080f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ALMGMOOHLMA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FABKIGNFECE()
	{
	}

	private void AGMJDGHLBMN()
	{
	}

	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 531f)
			{
				HBJJOCHGOPH = 2f;
			}
			DNLMFEGJJDD().SetFloat("maps.", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value", Level);
			DNLMFEGJJDD().SetVector("_Value", Distance);
			DNLMFEGJJDD().SetVector("SupportLogger Info: PUN {0}: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1369f, 1734f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OFPPIKHNJOD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1958f)
			{
				HBJJOCHGOPH = 1077f;
			}
			HNICHJCGJOC().SetFloat("Editor/", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("[SteamManager] Connecting to server", Level);
			HNICHJCGJOC().SetVector("CameraFilterPack/RainFX", Distance);
			IONHGBPGCHK().SetVector("_Offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 364f, 762f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 192f)
			{
				HBJJOCHGOPH = 1722f;
			}
			LNLKMDPHDCC().SetFloat("_Value", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat(". Check if the server is available.", Level);
			HNICHJCGJOC().SetVector("_Blue_C", Distance);
			LONNIJMNKFB().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 879f, 464f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CFIAKIJAILI()
	{
	}
}
