// CameraFilterPack_OldFilm_Cutting1
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Old Film/Cutting 1")]
[ExecuteInEditMode]
public class CameraFilterPack_OldFilm_Cutting1 : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	[Range(0f, 10f)]
	public float Speed = 1f;

	[Range(0f, 2f)]
	public float Luminosity = 1.5f;

	[Range(0f, 1f)]
	public float Vignette = 1f;

	[Range(0f, 2f)]
	public float Negative;

	private Material BJFKDHHMLJH;

	private Texture2D FPHEBLMINDA;

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

	private void DLMPALHKMON()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NCNPAKFAFOE()
	{
		FPHEBLMINDA = Resources.Load("Beat Detected") as Texture2D;
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DAHFFNNIGML()
	{
		FPHEBLMINDA = Resources.Load("_Value") as Texture2D;
		SCShader = Shader.Find("Object ID. Case-Sensitive");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material DNLMFEGJJDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)91;
		}
		return BJFKDHHMLJH;
	}

	private void AAPKBNDHBLI()
	{
	}

	private void DOEPOGLEGLE()
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

	private void OCMKCBBCEFG()
	{
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-1);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HHIFMIPPMPF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material PLBEJJIHFPB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-73);
		}
		return BJFKDHHMLJH;
	}

	private void FEHCNJLLJMP()
	{
		FPHEBLMINDA = Resources.Load("_Value1") as Texture2D;
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 547f)
			{
				HBJJOCHGOPH = 1098f;
			}
			NBPKMLMCHFN.SetFloat("#tryagain", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("_Distortion", Luminosity);
			PDEAHJPOMEF().SetFloat("/", 1393f - Vignette);
			NBPKMLMCHFN.SetFloat(". The RPC has been ignored.", Negative);
			PLBEJJIHFPB().SetFloat("0", Speed);
			NBPKMLMCHFN.SetTexture("_Intensity", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 980f)
			{
				HBJJOCHGOPH = 56f;
			}
			NFMGLIKNOOC().SetFloat("tintColor", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("_Value2", Luminosity);
			PLBEJJIHFPB().SetFloat(":\n", 1109f - Vignette);
			HHIFMIPPMPF().SetFloat(": ", Negative);
			NFMGLIKNOOC().SetFloat("_Val3", Speed);
			NBPKMLMCHFN.SetTexture("_Value9", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	private void JOJFHFHOCHO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IHLMNAGPKDA()
	{
		FPHEBLMINDA = Resources.Load("_Value2") as Texture2D;
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
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
			NBPKMLMCHFN.SetFloat("_TimeX", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value", Luminosity);
			NBPKMLMCHFN.SetFloat("_Value2", 1f - Vignette);
			NBPKMLMCHFN.SetFloat("_Value3", Negative);
			NBPKMLMCHFN.SetFloat("_Speed", Speed);
			NBPKMLMCHFN.SetTexture("_MainTex2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HLIAEEMGBHN()
	{
		FPHEBLMINDA = Resources.Load("_Value4") as Texture2D;
		SCShader = Shader.Find("\\");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GPFJMKCGHGB()
	{
	}

	private void OFPPIKHNJOD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PAKPHKPDKGE()
	{
		FPHEBLMINDA = Resources.Load("d264dbba9c2410771b4ad918903b3f4cd9e276a9") as Texture2D;
		SCShader = Shader.Find("DPADHOR");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material LDNADDJMIPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return BJFKDHHMLJH;
	}

	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1468f)
			{
				HBJJOCHGOPH = 1751f;
			}
			HHIFMIPPMPF().SetFloat("SettingsCanvas", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("player.yellowarc", Luminosity);
			LDNADDJMIPK().SetFloat("GlassDistortion", 1710f - Vignette);
			PLBEJJIHFPB().SetFloat("\n", Negative);
			NBPKMLMCHFN.SetFloat("/", Speed);
			LDNADDJMIPK().SetTexture("_DistortionSize", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Start()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_OldFilm1") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/OldFilm_Cutting1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1372f)
			{
				HBJJOCHGOPH = 1014f;
			}
			NBPKMLMCHFN.SetFloat("#discord{0}joinrequest", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("_ScreenResolution", Luminosity);
			NFMGLIKNOOC().SetFloat("_History4ChromaTex", 592f - Vignette);
			LDNADDJMIPK().SetFloat("RarityImage", Negative);
			NBPKMLMCHFN.SetFloat("SetScale", Speed);
			LDNADDJMIPK().SetTexture("_Near", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CFIAKIJAILI()
	{
	}

	private void MAOCOEGAFND()
	{
	}

	private void JHJFBCFBKLD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material NFMGLIKNOOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return BJFKDHHMLJH;
	}
}
