// CameraFilterPack_Vision_Drost
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Vision/Drost")]
[ExecuteInEditMode]
public class CameraFilterPack_Vision_Drost : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 0.4f)]
	public float Intensity = 0.4f;

	[Range(0f, 10f)]
	public float Speed = 1f;

	[Range(0f, 10f)]
	private float ILHJFHFPGBB = 1f;

	[Range(0f, 10f)]
	private float CCIENBFIKKH = 1f;

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

	private void CNGAJDBOCLJ()
	{
		SCShader = Shader.Find("elapsed: {0:0.000}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BNEJMABFKJE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FOMNCPKKCFN()
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
			NBPKMLMCHFN.SetFloat("_Value", Intensity);
			NBPKMLMCHFN.SetFloat("_Value2", Speed);
			NBPKMLMCHFN.SetFloat("_Value3", ILHJFHFPGBB);
			NBPKMLMCHFN.SetFloat("_Value4", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JOJFHFHOCHO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material KEMAALEODNH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return BJFKDHHMLJH;
	}

	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 76f)
			{
				HBJJOCHGOPH = 168f;
			}
			KBOPGONOCNP().SetFloat("position", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("[MapEditor] Loaded music file: ", Intensity);
			IIBLJCKLGFG().SetFloat(":", Speed);
			IIBLJCKLGFG().SetFloat("_Amount", ILHJFHFPGBB);
			KBOPGONOCNP().SetFloat("ChatHistoryInputField", CCIENBFIKKH);
			IIBLJCKLGFG().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1833f, 522f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
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
			if (HBJJOCHGOPH > 855f)
			{
				HBJJOCHGOPH = 1374f;
			}
			IIBLJCKLGFG().SetFloat(" not exist", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("_Value3", Intensity);
			DNLMFEGJJDD().SetFloat("st", Speed);
			DEFBJOCJJKF().SetFloat("_BorderSize", ILHJFHFPGBB);
			NBPKMLMCHFN.SetFloat("ERROR: preview file name is empty in modName.workshop.json", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector(" (", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1649f, 719f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PHJLHCMCCKE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AAPKBNDHBLI()
	{
	}

	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1561f)
			{
				HBJJOCHGOPH = 1149f;
			}
			KEMAALEODNH().SetFloat("[LevelEditorScene] Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_TimeX", Intensity);
			KBOPGONOCNP().SetFloat("ok", Speed);
			EPCGJFCCAFH().SetFloat(" Loaded: ", ILHJFHFPGBB);
			NBPKMLMCHFN.SetFloat("RarityImage", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("_FixDistance", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 671f, 652f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
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

	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1875f)
			{
				HBJJOCHGOPH = 998f;
			}
			KEMAALEODNH().SetFloat("_Color", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("PS Home", Intensity);
			DNLMFEGJJDD().SetFloat("_EmissionColor", Speed);
			DEFBJOCJJKF().SetFloat("CameraFilterPack/EXTRA_Rotation", ILHJFHFPGBB);
			KEMAALEODNH().SetFloat("caret", CCIENBFIKKH);
			EPCGJFCCAFH().SetVector("Object ID. Case-Sensitive", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1918f, 570f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	private void AEIJFLJEABG()
	{
	}

	private void KMCPMOGKDEH()
	{
		SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DFENCIHAADO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1147f)
			{
				HBJJOCHGOPH = 1229f;
			}
			KEMAALEODNH().SetFloat("_Offsets", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("_AdditiveReflection", Intensity);
			NBPKMLMCHFN.SetFloat("AudioSampler", Speed);
			DEFBJOCJJKF().SetFloat("_SpawnHeuristic", ILHJFHFPGBB);
			IIBLJCKLGFG().SetFloat("CameraFilterPack_Atmosphere_Rain_FX", CCIENBFIKKH);
			DEFBJOCJJKF().SetVector("Result for ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 219f, 26f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DEFBJOCJJKF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-128);
		}
		return BJFKDHHMLJH;
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Vision_Drost");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MFMIODIAKNI()
	{
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-125);
		}
		return BJFKDHHMLJH;
	}

	private void BGDPIHMAACO()
	{
		SCShader = Shader.Find("UseFinalGlassColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DIPDEHOOBPG()
	{
		SCShader = Shader.Find("MessageText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EPEGAEGDJAM()
	{
		SCShader = Shader.Find("_ScratchOffsetScale");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HNILMGEKDEC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material IIBLJCKLGFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void IDIIELPAMCJ()
	{
	}

	private void ICDBMJKMIKC()
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

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 973f)
			{
				HBJJOCHGOPH = 1240f;
			}
			DEFBJOCJJKF().SetFloat("Waiting to start", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat(",", Intensity);
			EPCGJFCCAFH().SetFloat("STICKLVER", Speed);
			DEFBJOCJJKF().SetFloat("_MainTex2", ILHJFHFPGBB);
			IIBLJCKLGFG().SetFloat("_TimeX", CCIENBFIKKH);
			IIBLJCKLGFG().SetVector("_Blue_C", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 101f, 1106f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DNLMFEGJJDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return BJFKDHHMLJH;
	}

	private void IHLMNAGPKDA()
	{
		SCShader = Shader.Find("MenuPlayButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material EPCGJFCCAFH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-93);
		}
		return BJFKDHHMLJH;
	}
}
