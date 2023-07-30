// CameraFilterPack_Film_ColorPerfection
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Film/ColorPerfection")]
[ExecuteInEditMode]
public class CameraFilterPack_Film_ColorPerfection : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 4f)]
	public float Gamma = 0.55f;

	[Range(0f, 10f)]
	private float EOKMJCIDCDB = 1f;

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

	private void NCNPAKFAFOE()
	{
		SCShader = Shader.Find("_Vignette");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CFIAKIJAILI()
	{
	}

	private void HMPGIFBJFIK()
	{
		SCShader = Shader.Find("Uploading content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1413f)
			{
				HBJJOCHGOPH = 1819f;
			}
			JFDGLLEOPGB().SetFloat(" id: ", HBJJOCHGOPH);
			EMDFHOKEGNG().SetFloat("_PositionY", Gamma);
			EPCGJFCCAFH().SetFloat("_ScreenResolution", EOKMJCIDCDB);
			EPCGJFCCAFH().SetFloat("[DiscordController] Join request {0}#{1}: {2}", ILHJFHFPGBB);
			KBOPGONOCNP().SetFloat("[NetworkManager] roomInfo.name: ", CCIENBFIKKH);
			LONNIJMNKFB().SetVector("[NetworkManager] Exited", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1286f, 1331f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BEBNOKFLJPH()
	{
		SCShader = Shader.Find("OnConnectedToMaster() was called by PUN. Now this client is connected and could join a room. Calling: PhotonNetwork.JoinRandomRoom();");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JHANGPCOCIG()
	{
		SCShader = Shader.Find("_MatrixSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KCCIEMBMOBA()
	{
		SCShader = Shader.Find("SpectatingUserInfo");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MKIMDFLBFOM()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material HCGJCMDJPGD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1523f)
			{
				HBJJOCHGOPH = 275f;
			}
			NBPKMLMCHFN.SetFloat("_PColor", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("_Value2", Gamma);
			HCGJCMDJPGD().SetFloat("_ScreenResolution", EOKMJCIDCDB);
			KBOPGONOCNP().SetFloat("SetCrosshairEmission", ILHJFHFPGBB);
			JFDGLLEOPGB().SetFloat("isBunned", CCIENBFIKKH);
			FEAEGGCNIAA().SetVector("GUICamera", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 532f, 1667f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material FEAEGGCNIAA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)117;
		}
		return BJFKDHHMLJH;
	}

	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 204f)
			{
				HBJJOCHGOPH = 1917f;
			}
			LONNIJMNKFB().SetFloat("#,0.00", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat("#yes", Gamma);
			HCGJCMDJPGD().SetFloat("] as we haven't received a full packet for delta compression yet. This is OK if it happens for the first few frames after joining a game.", EOKMJCIDCDB);
			EPCGJFCCAFH().SetFloat("_Level", ILHJFHFPGBB);
			EMDFHOKEGNG().SetFloat("_NoiseTex", CCIENBFIKKH);
			EPCGJFCCAFH().SetVector("HighScaleShot", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1840f, 1875f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JOACBIEHHCE()
	{
	}

	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1215f)
			{
				HBJJOCHGOPH = 1693f;
			}
			EMDFHOKEGNG().SetFloat("_Value5", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("threshold", Gamma);
			NBPKMLMCHFN.SetFloat("907198288", EOKMJCIDCDB);
			JFDGLLEOPGB().SetFloat("[LevelEditorScene] Error: Timeout :S", ILHJFHFPGBB);
			JFDGLLEOPGB().SetFloat("Tab1Content", CCIENBFIKKH);
			EMDFHOKEGNG().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 126f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1277f)
			{
				HBJJOCHGOPH = 1184f;
			}
			LONNIJMNKFB().SetFloat("CameraFilterPack/Blur_Movie", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat("_TimeX", Gamma);
			JFDGLLEOPGB().SetFloat("_ScreenResolution", EOKMJCIDCDB);
			NBPKMLMCHFN.SetFloat("Rotate environment object to the rotation", ILHJFHFPGBB);
			EPCGJFCCAFH().SetFloat("_Value4", CCIENBFIKKH);
			EMDFHOKEGNG().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1102f, 375f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
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
			NBPKMLMCHFN.SetFloat("_Value", Gamma);
			NBPKMLMCHFN.SetFloat("_Value2", EOKMJCIDCDB);
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

	private void BJOHDLNDFAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1387f)
			{
				HBJJOCHGOPH = 1381f;
			}
			NBPKMLMCHFN.SetFloat("<color=#{0}>{1}</color>", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("#ok", Gamma);
			NBPKMLMCHFN.SetFloat("_EmissionColor", EOKMJCIDCDB);
			LONNIJMNKFB().SetFloat("_History4ChromaTex", ILHJFHFPGBB);
			NBPKMLMCHFN.SetFloat("_TimeX", CCIENBFIKKH);
			HCGJCMDJPGD().SetVector("_Exponent", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1056f, 613f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1149f)
			{
				HBJJOCHGOPH = 508f;
			}
			KBOPGONOCNP().SetFloat("Scrollbar", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("value", Gamma);
			EMDFHOKEGNG().SetFloat("_Value", EOKMJCIDCDB);
			KBOPGONOCNP().SetFloat("_Value2", ILHJFHFPGBB);
			JFDGLLEOPGB().SetFloat("_threshold", CCIENBFIKKH);
			HCGJCMDJPGD().SetVector(".g", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 91f, 370f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LPMINJJPDCH()
	{
	}

	private void FBPHNEJBDJN()
	{
		SCShader = Shader.Find("--------------------------------");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FPHLDMMAOEF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FBMDHDBELEK()
	{
	}

	[SpecialName]
	private Material JFDGLLEOPGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 681f)
			{
				HBJJOCHGOPH = 1448f;
			}
			EMDFHOKEGNG().SetFloat("ChangeSelectedLevel", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_MainTex2", Gamma);
			NBPKMLMCHFN.SetFloat("_Value3", EOKMJCIDCDB);
			KBOPGONOCNP().SetFloat("Tab1Content", ILHJFHFPGBB);
			FEAEGGCNIAA().SetFloat("-", CCIENBFIKKH);
			LONNIJMNKFB().SetVector("_CurveParams", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 143f, 1993f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material EMDFHOKEGNG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)103;
		}
		return BJFKDHHMLJH;
	}

	private void ODAIMOJLJOF()
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

	private void NNCCPEBIAKH()
	{
		SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 436f)
			{
				HBJJOCHGOPH = 1028f;
			}
			HCGJCMDJPGD().SetFloat("challenges.", HBJJOCHGOPH);
			EMDFHOKEGNG().SetFloat("/Saved Games/", Gamma);
			NBPKMLMCHFN.SetFloat("_Amount", EOKMJCIDCDB);
			JFDGLLEOPGB().SetFloat(",", ILHJFHFPGBB);
			HCGJCMDJPGD().SetFloat("https://discord.gg/intralism", CCIENBFIKKH);
			KBOPGONOCNP().SetVector("Bad parameters for getbool! Use <key> <value>", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1894f, 1457f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JKFDDNMPOJH()
	{
		SCShader = Shader.Find("LostLive");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CCLNNLCOPBL()
	{
		SCShader = Shader.Find("isVisible");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MAOCOEGAFND()
	{
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Film_ColorPerfection");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JNGMIAFLBDL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HLIAEEMGBHN()
	{
		SCShader = Shader.Find("Editor/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 515f)
			{
				HBJJOCHGOPH = 1142f;
			}
			KBOPGONOCNP().SetFloat("_Fade", HBJJOCHGOPH);
			EMDFHOKEGNG().SetFloat("Received OnSerialization for view ID ", Gamma);
			JFDGLLEOPGB().SetFloat("#yes", EOKMJCIDCDB);
			NBPKMLMCHFN.SetFloat("_Distortion", ILHJFHFPGBB);
			EMDFHOKEGNG().SetFloat("DifficultyBG", CCIENBFIKKH);
			EMDFHOKEGNG().SetVector("MapConfig", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 402f, 710f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OHFOLGANOLC()
	{
		SCShader = Shader.Find("\" marked with the [PunRPC](C#) or @PunRPC(JS) property! Args: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 555f)
			{
				HBJJOCHGOPH = 1803f;
			}
			EMDFHOKEGNG().SetFloat(". Prefab must have a PhotonView component.", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("Gameplay/Base", Gamma);
			LONNIJMNKFB().SetFloat("_Vignetting", EOKMJCIDCDB);
			EMDFHOKEGNG().SetFloat("_BorderColor", ILHJFHFPGBB);
			HCGJCMDJPGD().SetFloat("_Value3", CCIENBFIKKH);
			KBOPGONOCNP().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 303f, 1934f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material EPCGJFCCAFH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)90;
		}
		return BJFKDHHMLJH;
	}

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1286f)
			{
				HBJJOCHGOPH = 879f;
			}
			JFDGLLEOPGB().SetFloat("_Value5", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat("FinalScoreSmallText", Gamma);
			EPCGJFCCAFH().SetFloat("x", EOKMJCIDCDB);
			JFDGLLEOPGB().SetFloat("#ok", ILHJFHFPGBB);
			EMDFHOKEGNG().SetFloat("[PlayerBase] Reset", CCIENBFIKKH);
			FEAEGGCNIAA().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1594f, 1822f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
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

	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1744f)
			{
				HBJJOCHGOPH = 771f;
			}
			KBOPGONOCNP().SetFloat("_Offsets", HBJJOCHGOPH);
			EMDFHOKEGNG().SetFloat("_ThirdTex", Gamma);
			EMDFHOKEGNG().SetFloat(" | ", EOKMJCIDCDB);
			EMDFHOKEGNG().SetFloat("y", ILHJFHFPGBB);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Lut_TestMode", CCIENBFIKKH);
			HCGJCMDJPGD().SetVector(".completedCount", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1076f, 1465f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1509f)
			{
				HBJJOCHGOPH = 986f;
			}
			HCGJCMDJPGD().SetFloat("_Value2", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("ClearEnvironment", Gamma);
			JFDGLLEOPGB().SetFloat("/icon", EOKMJCIDCDB);
			HCGJCMDJPGD().SetFloat("#savemapbeforeuploading", ILHJFHFPGBB);
			NBPKMLMCHFN.SetFloat(",0", CCIENBFIKKH);
			KBOPGONOCNP().SetVector("BadgeText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 988f, 628f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
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
			if (HBJJOCHGOPH > 168f)
			{
				HBJJOCHGOPH = 498f;
			}
			FEAEGGCNIAA().SetFloat("_TimeX", HBJJOCHGOPH);
			EMDFHOKEGNG().SetFloat("_Amount", Gamma);
			EPCGJFCCAFH().SetFloat("ShowTitle", EOKMJCIDCDB);
			KBOPGONOCNP().SetFloat("end", ILHJFHFPGBB);
			FEAEGGCNIAA().SetFloat("#mapby", CCIENBFIKKH);
			KBOPGONOCNP().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 638f, 837f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 69f)
			{
				HBJJOCHGOPH = 554f;
			}
			FEAEGGCNIAA().SetFloat("player.goldbat", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("th", Gamma);
			KBOPGONOCNP().SetFloat("_Value1", EOKMJCIDCDB);
			EMDFHOKEGNG().SetFloat("{0} years ago", ILHJFHFPGBB);
			JFDGLLEOPGB().SetFloat(".", CCIENBFIKKH);
			JFDGLLEOPGB().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 623f, 522f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	private void EHCGBJDFMHG()
	{
	}

	private void HDDECCMEJKA()
	{
	}

	[SpecialName]
	private Material LONNIJMNKFB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void EFJDNLGNACH()
	{
		SCShader = Shader.Find("Players NetIDs:");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DLBODOFAJGM()
	{
		SCShader = Shader.Find("Incoming: \n");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 772f)
			{
				HBJJOCHGOPH = 530f;
			}
			EMDFHOKEGNG().SetFloat("_PColor", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("speed", Gamma);
			KBOPGONOCNP().SetFloat("_Value", EOKMJCIDCDB);
			JFDGLLEOPGB().SetFloat("float,1", ILHJFHFPGBB);
			JFDGLLEOPGB().SetFloat("menu.enableselectormusic", CCIENBFIKKH);
			HCGJCMDJPGD().SetVector("id", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1089f, 1525f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FOMNCPKKCFN()
	{
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy;
		}
		return BJFKDHHMLJH;
	}
}
