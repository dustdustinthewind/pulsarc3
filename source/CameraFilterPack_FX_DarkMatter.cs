// CameraFilterPack_FX_DarkMatter
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/FX/DarkMatter")]
[ExecuteInEditMode]
public class CameraFilterPack_FX_DarkMatter : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(-10f, 10f)]
	public float Speed = 0.8f;

	[Range(0f, 1f)]
	public float Intensity = 1f;

	[Range(-1f, 2f)]
	public float PosX = 0.5f;

	[Range(-1f, 2f)]
	public float PosY = 0.5f;

	[Range(-2f, 2f)]
	public float Zoom = 0.33f;

	[Range(0f, 5f)]
	public float DarkIntensity = 2f;

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

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KIMMMCJFMAB()
	{
		SCShader = Shader.Find("FinalScoreSmallText");
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void GPHPJIDGEPI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CFIAKIJAILI()
	{
	}

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 767f)
			{
				HBJJOCHGOPH = 1197f;
			}
			DNLMFEGJJDD().SetFloat("F3", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("\n", Speed);
			DBOLLHHMKKN().SetFloat("No child content found, exiting..", Intensity);
			NBPKMLMCHFN.SetFloat("StartButton", PosX);
			OIMMPLPBLBK().SetFloat("_BlurParams", PosY);
			OIMMPLPBLBK().SetFloat("_TimeX", Zoom);
			DNLMFEGJJDD().SetFloat("settings.arcsnohitsoundtimedelay", DarkIntensity);
			DBOLLHHMKKN().SetVector("CameraFilterPack/Blur_Movie", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1855f, 1499f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material OIMMPLPBLBK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-122);
		}
		return BJFKDHHMLJH;
	}

	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 182f)
			{
				HBJJOCHGOPH = 485f;
			}
			DBOLLHHMKKN().SetFloat(": ", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("CameraFilterPack/Blur_Blurry", Speed);
			DNLMFEGJJDD().SetFloat("Tried to Initialize the SteamAPI twice in one session!", Intensity);
			DNLMFEGJJDD().SetFloat("SetParticlesColor", PosX);
			DBOLLHHMKKN().SetFloat("x", PosY);
			DBOLLHHMKKN().SetFloat("#,0.00", Zoom);
			OIMMPLPBLBK().SetFloat("_Visualize", DarkIntensity);
			DBOLLHHMKKN().SetVector("_EmissionColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 884f, 1781f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JHJFBCFBKLD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Update()
	{
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1867f)
			{
				HBJJOCHGOPH = 724f;
			}
			DBOLLHHMKKN().SetFloat("CameraFilterPack/3D_BlackHole", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat(" | Level: ", Speed);
			DBOLLHHMKKN().SetFloat(".icon", Intensity);
			NBPKMLMCHFN.SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", PosX);
			OIMMPLPBLBK().SetFloat("#updateoutdatedmap", PosY);
			OIMMPLPBLBK().SetFloat("TimeBGSlider", Zoom);
			DBOLLHHMKKN().SetFloat("Please attach component to a Graphical UI component", DarkIntensity);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 64f, 1836f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/FX_DarkMatter");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DNNFHBOOPIN()
	{
		SCShader = Shader.Find(" to: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CIPKEPDELJB()
	{
		SCShader = Shader.Find("Have you fully accept the terms?");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EAHCLIEEJOG()
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
			if (HBJJOCHGOPH > 1661f)
			{
				HBJJOCHGOPH = 1862f;
			}
			DNLMFEGJJDD().SetFloat("_MainTex2", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("CameraFilterPack_3D_Computer1", Speed);
			DBOLLHHMKKN().SetFloat("\" for viewID ", Intensity);
			DNLMFEGJJDD().SetFloat("SetSatelliteSensitivity", PosX);
			DBOLLHHMKKN().SetFloat("Texture2", PosY);
			NBPKMLMCHFN.SetFloat("SpawnObj", Zoom);
			DBOLLHHMKKN().SetFloat("#", DarkIntensity);
			OIMMPLPBLBK().SetVector("HightScoreMaxPointsText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 832f, 835f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DBOLLHHMKKN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)127;
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
			NBPKMLMCHFN.SetFloat("_Value", Speed);
			NBPKMLMCHFN.SetFloat("_Value2", Intensity);
			NBPKMLMCHFN.SetFloat("_Value3", PosX);
			NBPKMLMCHFN.SetFloat("_Value4", PosY);
			NBPKMLMCHFN.SetFloat("_Value5", Zoom);
			NBPKMLMCHFN.SetFloat("_Value6", DarkIntensity);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
