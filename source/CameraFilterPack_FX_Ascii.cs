// CameraFilterPack_FX_Ascii
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/FX/Ascii")]
[ExecuteInEditMode]
public class CameraFilterPack_FX_Ascii : MonoBehaviour
{
	public Shader SCShader;

	[Range(0f, 2f)]
	public float Value = 1f;

	[Range(0.01f, 1f)]
	public float Fade = 1f;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

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

	private void KMCPMOGKDEH()
	{
		SCShader = Shader.Find("GameScene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JOJFHFHOCHO()
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
			if (HBJJOCHGOPH > 1258f)
			{
				HBJJOCHGOPH = 1124f;
			}
			DNLMFEGJJDD().SetFloat("ResourceFileSelector", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("#rt", Value);
			DEFBJOCJJKF().SetFloat("recipes", Fade);
			NBPKMLMCHFN.SetVector("Ev OwnershipRequest ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 865f, 297f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 654f)
			{
				HBJJOCHGOPH = 183f;
			}
			DEFBJOCJJKF().SetFloat("System.Boolean", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Instrumental", Value);
			KAFBNOBOIAJ().SetFloat("_ScreenResolution", Fade);
			DEFBJOCJJKF().SetVector("Joystick1Button6", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1862f, 1432f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1903f)
			{
				HBJJOCHGOPH = 424f;
			}
			DNLMFEGJJDD().SetFloat(" not exist", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("restrictions", Value);
			DEFBJOCJJKF().SetFloat("_DistortionLevel", Fade);
			DEFBJOCJJKF().SetVector("Joystick1Button4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1728f, 1842f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
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

	private void KIMMMCJFMAB()
	{
		SCShader = Shader.Find("name");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material HFBJAOFLCJI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material DEFBJOCJJKF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void PAEGLMEOKHP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
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
			NBPKMLMCHFN.SetFloat("Value", Value);
			NBPKMLMCHFN.SetFloat("Fade", Fade);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 572f)
			{
				HBJJOCHGOPH = 492f;
			}
			DNLMFEGJJDD().SetFloat("Load Game", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("MenuScene", Value);
			HFBJAOFLCJI().SetFloat(",viewkeys", Fade);
			DNLMFEGJJDD().SetVector("STICKLHOR", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 893f, 1332f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/FX_Ascii");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1586f)
			{
				HBJJOCHGOPH = 1293f;
			}
			NBPKMLMCHFN.SetFloat("_EmissionGain", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("#tryagain", Value);
			KBOPGONOCNP().SetFloat("_Value2", Fade);
			NBPKMLMCHFN.SetVector("BestScoreText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 187f, 973f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DNNFHBOOPIN()
	{
		SCShader = Shader.Find("_Value2");
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
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1610f)
			{
				HBJJOCHGOPH = 1555f;
			}
			KBOPGONOCNP().SetFloat("SpawnObj", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("MenuScene", Value);
			DEFBJOCJJKF().SetFloat("_Value5", Fade);
			KAFBNOBOIAJ().SetVector("achievements.21.progress", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 780f, 1258f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LLJLDLLNFBH()
	{
	}

	private void OFPPIKHNJOD()
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
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-80);
		}
		return BJFKDHHMLJH;
	}

	private void FABMDEHEDNO()
	{
	}

	[SpecialName]
	private Material KAFBNOBOIAJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void CNGAJDBOCLJ()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NBGIMIDICKE()
	{
		SCShader = Shader.Find("Waiting to start");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MFMIODIAKNI()
	{
	}

	private void DLMPALHKMON()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Update()
	{
	}

	private void ODAIMOJLJOF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FBMDHDBELEK()
	{
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 950f)
			{
				HBJJOCHGOPH = 1748f;
			}
			HFBJAOFLCJI().SetFloat("curScn", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat(":\n", Value);
			NBPKMLMCHFN.SetFloat("_BlurPass", Fade);
			DEFBJOCJJKF().SetVector("id", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1666f, 1486f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 49f)
			{
				HBJJOCHGOPH = 1118f;
			}
			KBOPGONOCNP().SetFloat("_Fade", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("float,50", Value);
			FAIFBBGFAIB().SetFloat("ArcsNoHitsoundTimeDelaySlider", Fade);
			HFBJAOFLCJI().SetVector("SaveButton", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 548f, 1455f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EJJEDJIOFAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}
}
