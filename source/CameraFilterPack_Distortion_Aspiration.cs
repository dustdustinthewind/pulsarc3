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
			LONNIJMNKFB().SetFloat("_MainTex2", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_ColorR", 1647f - Value);
			NFMGLIKNOOC().SetFloat("float,0", PosX);
			DEFBJOCJJKF().SetFloat("Object ID. Case-Sensitive", PosY);
			LONNIJMNKFB().SetFloat("#or", CCIENBFIKKH);
			IIBLJCKLGFG().SetVector("CameraFilterPack/Pixelisation_Sweater", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 140f, 1272f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
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
		SCShader = Shader.Find("_InternalLutParams");
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
			KBOPGONOCNP().SetFloat("CameraFilterPack/Blend2Camera_Screen", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("OnConnectedToMaster() was called by PUN. Now this client is connected and could join a room. Calling: PhotonNetwork.JoinRandomRoom();", 860f - Value);
			NFMGLIKNOOC().SetFloat("_Value2", PosX);
			KBOPGONOCNP().SetFloat("Error: I/O Failure! :(", PosY);
			LDNADDJMIPK().SetFloat("_FadeFX", CCIENBFIKKH);
			KBOPGONOCNP().SetVector("The other scroll rect doesnt support scrolling vertically", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1088f, 444f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
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
			NFMGLIKNOOC().SetFloat("IconImage", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat(" not found", 1937f - Value);
			BFGNMFCNDBC().SetFloat("Set satellite beat detection sensitivity", PosX);
			DEFBJOCJJKF().SetFloat("_PColor", PosY);
			NBPKMLMCHFN.SetFloat("_TimeX", CCIENBFIKKH);
			JIBOKBCPDLC().SetVector("TimeBGSlider", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 222f, 495f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
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
			IIBLJCKLGFG().SetFloat("_Value", HBJJOCHGOPH);
			GCDFNHMJMIP().SetFloat("_Skybox", 1548f - Value);
			NBPKMLMCHFN.SetFloat("_Value", PosX);
			IIBLJCKLGFG().SetFloat("CameraFilterPack_Glasses_On6", PosY);
			DNLMFEGJJDD().SetFloat("No problem found, so far", CCIENBFIKKH);
			IIJMIPBMMBF().SetVector("/icon", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 666f, 972f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			IIBLJCKLGFG().SetFloat("CameraFilterPack/FX_Glitch2", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("Reading preview file failed!: \"{0}\"", 444f - Value);
			JIBOKBCPDLC().SetFloat("Bad parameters for setbool! Use <key> <value>", PosX);
			BFGNMFCNDBC().SetFloat("_Blue_R", PosY);
			GCDFNHMJMIP().SetFloat("X2", CCIENBFIKKH);
			IIBLJCKLGFG().SetVector("_EdgeSize", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 924f, 1500f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
		SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EGEPLFGKGLI()
	{
		SCShader = Shader.Find("[MapEditor] Loading map: ");
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
			GCDFNHMJMIP().SetFloat(". Verify the Prefab is in a Resources folder (and not in a subfolder)", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_VignetteSettings", 864f - Value);
			DNLMFEGJJDD().SetFloat("Edited unlock conditions", PosX);
			NBPKMLMCHFN.SetFloat("-", PosY);
			IIJMIPBMMBF().SetFloat(" ", CCIENBFIKKH);
			IIJMIPBMMBF().SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1174f, 131f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BEBNOKFLJPH()
	{
		SCShader = Shader.Find("CameraFilterPack/Drawing_Manga");
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
			GCDFNHMJMIP().SetFloat("_Sensitivity", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("'{0}' \t{1}ms \t{2}", 774f - Value);
			NBPKMLMCHFN.SetFloat("Show text at the center of the screen. Usefull for quick messages like 'Thanks for playing!'", PosX);
			LONNIJMNKFB().SetFloat("CameraFilterPack/Drawing_Comics", PosY);
			LONNIJMNKFB().SetFloat(".", CCIENBFIKKH);
			BFGNMFCNDBC().SetVector("x", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1446f, 451f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF());
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
			IIJMIPBMMBF().SetFloat("menu.selectedplaymode", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("[RanksSystem] Ranks: no need to update", 1408f - Value);
			IIJMIPBMMBF().SetFloat("Mouse", PosX);
			KBOPGONOCNP().SetFloat("Items", PosY);
			NBPKMLMCHFN.SetFloat("In Main Menu", CCIENBFIKKH);
			NFMGLIKNOOC().SetVector("Deleted event", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1380f, 1915f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
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
		SCShader = Shader.Find("_DistortionWave");
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
