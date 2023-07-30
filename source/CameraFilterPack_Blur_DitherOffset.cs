// CameraFilterPack_Blur_DitherOffset
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Blur/DitherOffset")]
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
		SCShader = Shader.Find("#forever");
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
		SCShader = Shader.Find("Text");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HLIAEEMGBHN()
	{
		SCShader = Shader.Find("_Level");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MMMDPANNAIO()
	{
		SCShader = Shader.Find("[Steamworks.NET] DllCheck Test returned false, One or more of the Steamworks binaries seems to be the wrong version.");
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
			LNLKMDPHDCC().SetFloat("/icon", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("_Value3", Level);
			LONNIJMNKFB().SetVector("] Suggested ", Distance);
			HNICHJCGJOC().SetVector("CameraFilterPack_Glasses_On4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1563f, 1980f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
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
			DNLMFEGJJDD().SetFloat("_BorderColor", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("Tab2Content", Level);
			LNLKMDPHDCC().SetVector("_Value2", Distance);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1543f, 1397f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
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
			HNICHJCGJOC().SetFloat("CameraMovementSlider", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("CameraFilterPack/TV_VHS", Level);
			IONHGBPGCHK().SetVector("Y", Distance);
			LONNIJMNKFB().SetVector(",", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 83f, 1643f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
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
			NBPKMLMCHFN.SetFloat("id", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("Joystick1Button4", Level);
			NBPKMLMCHFN.SetVector("[Down]", Distance);
			IONHGBPGCHK().SetVector("_EmissionColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 487f, 1804f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			LONNIJMNKFB().SetFloat("shader.none", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("CameraFilterPack/Blend2Camera_SplitScreen3D", Level);
			LONNIJMNKFB().SetVector("#ok", Distance);
			LNLKMDPHDCC().SetVector(".status", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1410f, 1739f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
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
		SCShader = Shader.Find("_Value3");
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
		SCShader = Shader.Find("Tab2Content");
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
		SCShader = Shader.Find("[PlayerBase] Got checkpoint at ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BMIOFJFMCBG()
	{
		SCShader = Shader.Find("_Value");
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
			NBPKMLMCHFN.SetFloat("path", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("_Value3", Level);
			DNLMFEGJJDD().SetVector("EventSystem", Distance);
			LONNIJMNKFB().SetVector("There is already a virtual button named ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 727f, 228f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			LONNIJMNKFB().SetFloat("SingleplayerButton", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("_Green_G", Level);
			HNICHJCGJOC().SetVector("Hello World, is my item a clone? [", Distance);
			LNLKMDPHDCC().SetVector("challenges.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 150f, 1168f));
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
			LNLKMDPHDCC().SetFloat("_Value4", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("_MainTex2", Level);
			HNICHJCGJOC().SetVector("CameraFilterPack/Vision_Tunnel", Distance);
			NBPKMLMCHFN.SetVector("CameraFilterPack/Blend2Camera_DarkerColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1667f, 1080f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
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
			LONNIJMNKFB().SetFloat("_ScreenResolution", Level);
			HNICHJCGJOC().SetVector("CameraFilterPack/Vision_Blood", Distance);
			NBPKMLMCHFN.SetVector("SupportLogger OnApplicationPause: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1369f, 1734f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
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
			LONNIJMNKFB().SetFloat("Editor/", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("[Steamworks.NET] Could not load [lib]steam_api.dll/so/dylib. It's likely not in the correct location. Refer to the README for more details.\n", Level);
			HNICHJCGJOC().SetVector("CameraFilterPack_RainFX_Anm2", Distance);
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
			HNICHJCGJOC().SetFloat("_Value", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Encryption wasn't established: ", Level);
			IONHGBPGCHK().SetVector("_Blue_C", Distance);
			HNICHJCGJOC().SetVector("CameraFilterPack/FX_Hexagon_Black", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 879f, 464f));
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
