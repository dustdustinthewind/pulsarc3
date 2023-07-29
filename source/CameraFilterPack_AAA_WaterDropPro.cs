// CameraFilterPack_AAA_WaterDropPro
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/AAA/WaterDropPro")]
[ExecuteInEditMode]
public class CameraFilterPack_AAA_WaterDropPro : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	[Range(8f, 64f)]
	public float Distortion = 8f;

	[Range(0f, 7f)]
	public float SizeX = 1f;

	[Range(0f, 7f)]
	public float SizeY = 0.5f;

	[Range(0f, 10f)]
	public float Speed = 1f;

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

	private void PHJLHCMCCKE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OCMKCBBCEFG()
	{
	}

	private void DIPDEHOOBPG()
	{
		FPHEBLMINDA = Resources.Load("EnvironmentSlider") as Texture2D;
		SCShader = Shader.Find("workshop.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PLIKADJCEPO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Start()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_WaterDrop") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/AAA_WaterDropPro");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LCJHDLKJEOM()
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
			NBPKMLMCHFN.SetFloat("_Distortion", Distortion);
			NBPKMLMCHFN.SetFloat("_SizeX", SizeX);
			NBPKMLMCHFN.SetFloat("_SizeY", SizeY);
			NBPKMLMCHFN.SetFloat("_Speed", Speed);
			NBPKMLMCHFN.SetTexture("_MainTex2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1453f)
			{
				HBJJOCHGOPH = 378f;
			}
			HFBJAOFLCJI().SetFloat("open", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("_SSAO", Distortion);
			HNICHJCGJOC().SetFloat("_Value", SizeX);
			HFBJAOFLCJI().SetFloat("_Value3", SizeY);
			HFBJAOFLCJI().SetFloat("--------------------------------", Speed);
			DNLMFEGJJDD().SetTexture("_QualitySettings", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 39f)
			{
				HBJJOCHGOPH = 982f;
			}
			EFDEIFCDAFG().SetFloat(": ", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("_FgOverlap", Distortion);
			HFBJAOFLCJI().SetFloat(".a", SizeX);
			HNICHJCGJOC().SetFloat("{0}", SizeY);
			HNICHJCGJOC().SetFloat("_Glitch", Speed);
			EFDEIFCDAFG().SetTexture("Scale environment object by the values", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
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
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1395f)
			{
				HBJJOCHGOPH = 1092f;
			}
			NBPKMLMCHFN.SetFloat("achievements.26.progress", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("id", Distortion);
			EFDEIFCDAFG().SetFloat("float,1", SizeX);
			DNLMFEGJJDD().SetFloat("_ScreenResolution", SizeY);
			EFDEIFCDAFG().SetFloat("_ScreenResolution", Speed);
			NBPKMLMCHFN.SetTexture("CameraFilterPack/FX_Funk", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
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
			BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 737f)
			{
				HBJJOCHGOPH = 1614f;
			}
			HNICHJCGJOC().SetFloat("/", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("master", Distortion);
			HFBJAOFLCJI().SetFloat("RT", SizeX);
			NBPKMLMCHFN.SetFloat("Testing, a toggle has toggled [", SizeY);
			DNLMFEGJJDD().SetFloat("NetworkCanvas", Speed);
			HFBJAOFLCJI().SetTexture("_Value2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EGEPLFGKGLI()
	{
		FPHEBLMINDA = Resources.Load("_TimeX") as Texture2D;
		SCShader = Shader.Find("OneHand");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FKEJGBFDCAH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material EFDEIFCDAFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void HLDFOJMHKNL()
	{
	}

	private void NPLCENPNJBM()
	{
		FPHEBLMINDA = Resources.Load("_Value2") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Lut_TestMode");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JILOMOBDPIA()
	{
		FPHEBLMINDA = Resources.Load("_LightIntensity") as Texture2D;
		SCShader = Shader.Find("<color=#{0}>{1}</color>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void Update()
	{
	}

	private void GAOOPEEBGJA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1073f)
			{
				HBJJOCHGOPH = 1503f;
			}
			EFDEIFCDAFG().SetFloat("_Value4", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("_TimeX", Distortion);
			DNLMFEGJJDD().SetFloat("/512px-512px.png", SizeX);
			EFDEIFCDAFG().SetFloat("NEW_ACHIEVEMENT_1_26", SizeY);
			DNLMFEGJJDD().SetFloat("IconImage", Speed);
			HNICHJCGJOC().SetTexture("settings.enablehitsoundsinrelax", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
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
			if (HBJJOCHGOPH > 1634f)
			{
				HBJJOCHGOPH = 567f;
			}
			DNLMFEGJJDD().SetFloat("Tab2Content", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("InstantiateRpc", Distortion);
			DNLMFEGJJDD().SetFloat("RanksButton", SizeX);
			HFBJAOFLCJI().SetFloat("plogs", SizeY);
			NBPKMLMCHFN.SetFloat("\\", Speed);
			HNICHJCGJOC().SetTexture("ICollection", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IDIIELPAMCJ()
	{
	}

	private void FIKFJDFELIP()
	{
		FPHEBLMINDA = Resources.Load("Texture2") as Texture2D;
		SCShader = Shader.Find("[MapsData] Caching ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DKOPKPBLDHH()
	{
		FPHEBLMINDA = Resources.Load("_NoisePerChannel") as Texture2D;
		SCShader = Shader.Find("SubBass");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KDMANOEMOCA()
	{
		FPHEBLMINDA = Resources.Load("#,0.00") as Texture2D;
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1234f)
			{
				HBJJOCHGOPH = 1196f;
			}
			HNICHJCGJOC().SetFloat("id", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("OK", Distortion);
			HFBJAOFLCJI().SetFloat("Gameplay/sun", SizeX);
			EFDEIFCDAFG().SetFloat("ItemsCountText", SizeY);
			NBPKMLMCHFN.SetFloat("settings.enableselectormusic", Speed);
			NBPKMLMCHFN.SetTexture("Scrollbar", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MFMIODIAKNI()
	{
	}

	private void ICDBMJKMIKC()
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
			BJFKDHHMLJH.hideFlags = (HideFlags)69;
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
}
