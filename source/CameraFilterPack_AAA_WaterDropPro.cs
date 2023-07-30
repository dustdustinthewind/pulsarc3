// CameraFilterPack_AAA_WaterDropPro
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/AAA/WaterDropPro")]
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
		FPHEBLMINDA = Resources.Load("Tab2Content") as Texture2D;
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
			HNICHJCGJOC().SetFloat("Room: '{0}' {1},{2} {4}/{3} players.", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("_Params", Distortion);
			EFDEIFCDAFG().SetFloat("_Value", SizeX);
			EFDEIFCDAFG().SetFloat("_Value2", SizeY);
			NBPKMLMCHFN.SetFloat("0.00", Speed);
			NBPKMLMCHFN.SetTexture("_SampleCount", FPHEBLMINDA);
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
			NBPKMLMCHFN.SetFloat(": ", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("_Offsets", Distortion);
			EFDEIFCDAFG().SetFloat(".a", SizeX);
			HNICHJCGJOC().SetFloat("[DiscordController] Shutdown", SizeY);
			DNLMFEGJJDD().SetFloat("_TimeX", Speed);
			DNLMFEGJJDD().SetTexture("Scale environment object by the values", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
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
			HNICHJCGJOC().SetFloat("achievements.26.progress", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("id", Distortion);
			NBPKMLMCHFN.SetFloat("Message duration multiplier. Recomended 1", SizeX);
			HFBJAOFLCJI().SetFloat("_ScreenResolution", SizeY);
			EFDEIFCDAFG().SetFloat("_Noise", Speed);
			HFBJAOFLCJI().SetTexture("_ScreenResolution", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
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
			NBPKMLMCHFN.SetFloat("PublishButton", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("open", Distortion);
			DNLMFEGJJDD().SetFloat("LT", SizeX);
			EFDEIFCDAFG().SetFloat("Testing, the group has toggled [", SizeY);
			HFBJAOFLCJI().SetFloat("NetworkCanvas", Speed);
			NBPKMLMCHFN.SetTexture("_Value", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EGEPLFGKGLI()
	{
		FPHEBLMINDA = Resources.Load("_MainTex2") as Texture2D;
		SCShader = Shader.Find("event");
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
		SCShader = Shader.Find("_LutTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JILOMOBDPIA()
	{
		FPHEBLMINDA = Resources.Load("_LightIntensity") as Texture2D;
		SCShader = Shader.Find("$ {0}");
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
			DNLMFEGJJDD().SetFloat("_TimeX", Distortion);
			HNICHJCGJOC().SetFloat("/", SizeX);
			HFBJAOFLCJI().SetFloat("NEW_ACHIEVEMENT_1_26", SizeY);
			DNLMFEGJJDD().SetFloat("IconImage", Speed);
			HNICHJCGJOC().SetTexture("HitInRelaxMusicToggle", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
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
			EFDEIFCDAFG().SetFloat("ConfigVersionSlider", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("#rt", Distortion);
			NBPKMLMCHFN.SetFloat("RanksButton", SizeX);
			EFDEIFCDAFG().SetFloat("achievements.21.progress", SizeY);
			DNLMFEGJJDD().SetFloat("\\", Speed);
			NBPKMLMCHFN.SetTexture("z", FPHEBLMINDA);
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
		FPHEBLMINDA = Resources.Load("_ScreenResolution") as Texture2D;
		SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DKOPKPBLDHH()
	{
		FPHEBLMINDA = Resources.Load("_DX11NoiseTime") as Texture2D;
		SCShader = Shader.Find("SubBass");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KDMANOEMOCA()
	{
		FPHEBLMINDA = Resources.Load("#,0") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Edge_Edge_filter");
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
			EFDEIFCDAFG().SetFloat("id", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("OK", Distortion);
			EFDEIFCDAFG().SetFloat("/Segment-[Down]", SizeX);
			NBPKMLMCHFN.SetFloat("InfoText", SizeY);
			HNICHJCGJOC().SetFloat("settings.disablestoryboard", Speed);
			HNICHJCGJOC().SetTexture("InputField", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
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
