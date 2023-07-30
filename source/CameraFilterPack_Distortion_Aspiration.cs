// CameraFilterPack_Distortion_Aspiration
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Distortion/Aspiration")]
[ExecuteInEditMode]
public class CameraFilterPack_Distortion_Aspiration : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 1f)]
	public float Value = 0.8f;

	[Range(-1f, 1f)]
	public float PosX = 0.5f;

	[Range(-1f, 1f)]
	public float PosY = 0.5f;

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

	private void Update()
	{
	}

	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1964f)
			{
				HBJJOCHGOPH = 1428f;
			}
			BFGNMFCNDBC().SetFloat("_MainTex2", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("_DotSize", 1647f - Value);
			KBOPGONOCNP().SetFloat("float,0", PosX);
			BFGNMFCNDBC().SetFloat("id", PosY);
			KBOPGONOCNP().SetFloat("\"", CCIENBFIKKH);
			JIBOKBCPDLC().SetVector("CameraFilterPack_Sweater", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 140f, 1272f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BGFJOEPFOPM()
	{
	}

	private void CIPKEPDELJB()
	{
		SCShader = Shader.Find("ENABLE_DITHERING");
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
			if (HBJJOCHGOPH > 1353f)
			{
				HBJJOCHGOPH = 1869f;
			}
			LONNIJMNKFB().SetFloat("CameraFilterPack/Blend2Camera_Screen", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat(" ", 860f - Value);
			DNLMFEGJJDD().SetFloat("_Value", PosX);
			DEFBJOCJJKF().SetFloat("Error: Timeout :S", PosY);
			LONNIJMNKFB().SetFloat("_Blue_C", CCIENBFIKKH);
			LONNIJMNKFB().SetVector("You have added the SecondScrollRect to a scroll view that already has both directions selected", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1088f, 444f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LDNADDJMIPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 829f)
			{
				HBJJOCHGOPH = 81f;
			}
			IIJMIPBMMBF().SetFloat("_Value1", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("shader.invert", 1937f - Value);
			JIBOKBCPDLC().SetFloat("float,50", PosX);
			NBPKMLMCHFN.SetFloat("_TimeX", PosY);
			NFMGLIKNOOC().SetFloat("_TimeX", CCIENBFIKKH);
			BFGNMFCNDBC().SetVector("TimeBGSlider", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 222f, 495f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF());
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
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NFMGLIKNOOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 142f)
			{
				HBJJOCHGOPH = 262f;
			}
			BFGNMFCNDBC().SetFloat("CameraFilterPack/TV_ARCADE_2", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("_SunPosition", 1548f - Value);
			IIBLJCKLGFG().SetFloat("_TimeX", PosX);
			JIBOKBCPDLC().SetFloat("_MainTex2", PosY);
			NFMGLIKNOOC().SetFloat("icon", CCIENBFIKKH);
			LDNADDJMIPK().SetVector("icon", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 666f, 972f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LONNIJMNKFB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)108;
		}
		return BJFKDHHMLJH;
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Distortion_Aspiration");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JHJGJJKELJM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material IIJMIPBMMBF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)104;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material GCDFNHMJMIP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideAndDontSave | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1773f)
			{
				HBJJOCHGOPH = 1003f;
			}
			JIBOKBCPDLC().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("LevelEditor/patterns", 444f - Value);
			GCDFNHMJMIP().SetFloat("setbool", PosX);
			IIBLJCKLGFG().SetFloat("_Green_B", PosY);
			JIBOKBCPDLC().SetFloat("X2", CCIENBFIKKH);
			NFMGLIKNOOC().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 924f, 1500f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material JIBOKBCPDLC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void FIKFJDFELIP()
	{
		SCShader = Shader.Find("ERROR: Preview file name in modName.workshop.json doesn't match any file");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EGEPLFGKGLI()
	{
		SCShader = Shader.Find("0.00");
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
			if (HBJJOCHGOPH > 533f)
			{
				HBJJOCHGOPH = 1684f;
			}
			DNLMFEGJJDD().SetFloat(". Client should be in a room. Current connectionStateDetailed: ", HBJJOCHGOPH);
			JIBOKBCPDLC().SetFloat("_VignetteSettings", 864f - Value);
			GCDFNHMJMIP().SetFloat("OK", PosX);
			JIBOKBCPDLC().SetFloat("--------------------------------", PosY);
			BFGNMFCNDBC().SetFloat("_ScreenResolution", CCIENBFIKKH);
			LONNIJMNKFB().SetVector("#ok", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1174f, 131f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BEBNOKFLJPH()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material IIBLJCKLGFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void DOEPOGLEGLE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 473f)
			{
				HBJJOCHGOPH = 1383f;
			}
			IIJMIPBMMBF().SetFloat("_ArScale", HBJJOCHGOPH);
			GCDFNHMJMIP().SetFloat("open", 774f - Value);
			IIBLJCKLGFG().SetFloat("float,1", PosX);
			JIBOKBCPDLC().SetFloat("CameraFilterPack/Drawing_Comics", PosY);
			DNLMFEGJJDD().SetFloat("_EmissionColor", CCIENBFIKKH);
			DEFBJOCJJKF().SetVector("x", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1446f, 451f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BFEILOMHNPC()
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

	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 97f)
			{
				HBJJOCHGOPH = 759f;
			}
			JIBOKBCPDLC().SetFloat("menu.hardcoreinfo", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("[RanksSystem] Ranks updated. Next update: ", 1408f - Value);
			KBOPGONOCNP().SetFloat("Mouse2", PosX);
			IIBLJCKLGFG().SetFloat("Scrollbar", PosY);
			JIBOKBCPDLC().SetFloat("In Main Menu", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("Deleted event", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1380f, 1915f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
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
			NBPKMLMCHFN.SetFloat("_Value", 1f - Value);
			NBPKMLMCHFN.SetFloat("_Value2", PosX);
			NBPKMLMCHFN.SetFloat("_Value3", PosY);
			NBPKMLMCHFN.SetFloat("_Value4", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BGDONBMDPGM()
	{
	}

	private void LLJLDLLNFBH()
	{
	}

	private void CGDMLHLJIDK()
	{
		SCShader = Shader.Find("CurrentTimeLabel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material BFGNMFCNDBC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void EDBEHEKMGFH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AGMJDGHLBMN()
	{
	}

	private void MMOKKAPFGAK()
	{
		SCShader = Shader.Find("_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void DHENLPJJOEN()
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-76);
		}
		return BJFKDHHMLJH;
	}

	private void JHPOIOELNCG()
	{
	}

	private void KIMMMCJFMAB()
	{
		SCShader = Shader.Find("PerfectHitsScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NNCCPEBIAKH()
	{
		SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
