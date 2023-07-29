// CameraFilterPack_Film_ColorPerfection
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Film/ColorPerfection")]
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
		SCShader = Shader.Find("_Vignette_Alpha");
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
		SCShader = Shader.Find("PLEASE WAIT");
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
			EMDFHOKEGNG().SetFloat("Cant ask anyone else for PickupItem spawn times.", HBJJOCHGOPH);
			EMDFHOKEGNG().SetFloat("_PositionY", Gamma);
			LONNIJMNKFB().SetFloat("CameraFilterPack/Drawing_CellShading2", EOKMJCIDCDB);
			NBPKMLMCHFN.SetFloat("[DiscordController] Init", ILHJFHFPGBB);
			NBPKMLMCHFN.SetFloat("masterSteamID", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("[NetworkManager] Exited", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1286f, 1331f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BEBNOKFLJPH()
	{
		SCShader = Shader.Find("Cause: ");
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
			NBPKMLMCHFN.SetFloat("_Value1", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value3", Gamma);
			EPCGJFCCAFH().SetFloat("CameraFilterPack/Vision_Plasma", EOKMJCIDCDB);
			EMDFHOKEGNG().SetFloat("SetParticlesGravity", ILHJFHFPGBB);
			JFDGLLEOPGB().SetFloat("player.xp", CCIENBFIKKH);
			JFDGLLEOPGB().SetVector("Is it practically possible?", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 532f, 1667f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			FEAEGGCNIAA().SetFloat("_EmissionColor", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("\0\0", Gamma);
			NBPKMLMCHFN.SetFloat("curScn", EOKMJCIDCDB);
			EPCGJFCCAFH().SetFloat("_Level", ILHJFHFPGBB);
			EPCGJFCCAFH().SetFloat("_MidGrey", CCIENBFIKKH);
			KBOPGONOCNP().SetVector("Coroutine container not configured... did you forget to call Init?", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1840f, 1875f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			FEAEGGCNIAA().SetFloat("_Value5", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("useSrcAlphaAsMask", Gamma);
			KBOPGONOCNP().SetFloat("1177138211", EOKMJCIDCDB);
			KBOPGONOCNP().SetFloat("[LevelEditorScene] Error: You're not logged into Steam!", ILHJFHFPGBB);
			FEAEGGCNIAA().SetFloat("caret", CCIENBFIKKH);
			HCGJCMDJPGD().SetVector("CameraFilterPack/Gradients_Hue", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 126f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
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
			JFDGLLEOPGB().SetFloat("_TimeX", HBJJOCHGOPH);
			EMDFHOKEGNG().SetFloat("_TimeX", Gamma);
			LONNIJMNKFB().SetFloat("CameraFilterPack/Gradients_Rainbow", EOKMJCIDCDB);
			FEAEGGCNIAA().SetFloat("SetScale", ILHJFHFPGBB);
			JFDGLLEOPGB().SetFloat("_ScreenResolution", CCIENBFIKKH);
			EPCGJFCCAFH().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1102f, 375f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			HCGJCMDJPGD().SetFloat("Game Version: ", HBJJOCHGOPH);
			EMDFHOKEGNG().SetFloat("0", Gamma);
			EMDFHOKEGNG().SetFloat("maps.", EOKMJCIDCDB);
			EMDFHOKEGNG().SetFloat("_History2Weight", ILHJFHFPGBB);
			EMDFHOKEGNG().SetFloat("_TimeX", CCIENBFIKKH);
			KBOPGONOCNP().SetVector("intensity", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1056f, 613f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
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
			EMDFHOKEGNG().SetFloat("Items", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat("float,0", Gamma);
			KBOPGONOCNP().SetFloat("_Value2", EOKMJCIDCDB);
			NBPKMLMCHFN.SetFloat("_Value3", ILHJFHFPGBB);
			EMDFHOKEGNG().SetFloat("offsets", CCIENBFIKKH);
			FEAEGGCNIAA().SetVector(".b", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 91f, 370f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EMDFHOKEGNG());
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
		SCShader = Shader.Find("-");
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
			EMDFHOKEGNG().SetFloat("_MainTex2", Gamma);
			FEAEGGCNIAA().SetFloat("_Value4", EOKMJCIDCDB);
			LONNIJMNKFB().SetFloat("Tab1Content", ILHJFHFPGBB);
			EMDFHOKEGNG().SetFloat("-", CCIENBFIKKH);
			LONNIJMNKFB().SetVector("_Offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 143f, 1993f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
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
		SCShader = Shader.Find("NewMusicFileSelector");
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
			KBOPGONOCNP().SetFloat("#challengecomplete", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("Added GameObject to prefabDictionary: ", Gamma);
			JFDGLLEOPGB().SetFloat("_Value1", EOKMJCIDCDB);
			LONNIJMNKFB().SetFloat("maps.", ILHJFHFPGBB);
			NBPKMLMCHFN.SetFloat("https://twitch.tv/intralism", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("Bad parameters for getbool! Use <key> <value>", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1894f, 1457f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JKFDDNMPOJH()
	{
		SCShader = Shader.Find("Left");
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
		SCShader = Shader.Find("NewMapHandsCountSlider");
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
			EMDFHOKEGNG().SetFloat(" with prefix ", Gamma);
			KBOPGONOCNP().SetFloat("MenuScene", EOKMJCIDCDB);
			NBPKMLMCHFN.SetFloat("_TimeX", ILHJFHFPGBB);
			HCGJCMDJPGD().SetFloat("NameInfoText", CCIENBFIKKH);
			JFDGLLEOPGB().SetVector("--------------------------------", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 402f, 710f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OHFOLGANOLC()
	{
		SCShader = Shader.Find("\" that takes ");
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
			KBOPGONOCNP().SetFloat(". Client should be in a room. Current connectionStateDetailed: ", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("Gameplay/Base", Gamma);
			EMDFHOKEGNG().SetFloat("_Vignetting2", EOKMJCIDCDB);
			JFDGLLEOPGB().SetFloat("_BorderColor", ILHJFHFPGBB);
			JFDGLLEOPGB().SetFloat("_Value3", CCIENBFIKKH);
			KBOPGONOCNP().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 303f, 1934f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
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
			FEAEGGCNIAA().SetFloat("_Value5", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("CheckpointsScoreText", Gamma);
			EPCGJFCCAFH().SetFloat("z", EOKMJCIDCDB);
			LONNIJMNKFB().SetFloat("#ok", ILHJFHFPGBB);
			EPCGJFCCAFH().SetFloat("finished", CCIENBFIKKH);
			JFDGLLEOPGB().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1594f, 1822f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
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
			JFDGLLEOPGB().SetFloat("_Offsets", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat("_Offsets", Gamma);
			NBPKMLMCHFN.SetFloat("<color=white>", EOKMJCIDCDB);
			LONNIJMNKFB().SetFloat("float,1", ILHJFHFPGBB);
			EMDFHOKEGNG().SetFloat("The given 2D texture ", CCIENBFIKKH);
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
			NBPKMLMCHFN.SetFloat("_Value3", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("Clear Environment", Gamma);
			EPCGJFCCAFH().SetFloat("/icon", EOKMJCIDCDB);
			NBPKMLMCHFN.SetFloat("#done", ILHJFHFPGBB);
			LONNIJMNKFB().SetFloat("[Up]", CCIENBFIKKH);
			FEAEGGCNIAA().SetVector("BadgeText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 988f, 628f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
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
			EMDFHOKEGNG().SetFloat("_Value", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("_Amount", Gamma);
			KBOPGONOCNP().SetFloat("SpawnObj", EOKMJCIDCDB);
			HCGJCMDJPGD().SetFloat("skin.", ILHJFHFPGBB);
			HCGJCMDJPGD().SetFloat("/", CCIENBFIKKH);
			LONNIJMNKFB().SetVector("CameraFilterPack/Edge_Sigmoid", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 638f, 837f));
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
			JFDGLLEOPGB().SetFloat("menutheme.hunter", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("Warning, using scrollbors with the Scroll Snap controls is not advised as it causes unpredictable results", Gamma);
			JFDGLLEOPGB().SetFloat("_Value2", EOKMJCIDCDB);
			EMDFHOKEGNG().SetFloat("{0} years ago", ILHJFHFPGBB);
			HCGJCMDJPGD().SetFloat(".lastCheckpoint.lives", CCIENBFIKKH);
			HCGJCMDJPGD().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 623f, 522f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
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
		SCShader = Shader.Find("ping: {6}[+/-{7}]ms resent:{8} \n\nmax ms between\nsend: {0,4} \ndispatch: {1,4} \n\nlongest dispatch for: \nev({3}):{2,3}ms \nop({5}):{4,3}ms");
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
			KBOPGONOCNP().SetFloat("_Value1", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Lerp speed. Recomended 10", Gamma);
			EMDFHOKEGNG().SetFloat("_Speed", EOKMJCIDCDB);
			HCGJCMDJPGD().SetFloat("Set sun lerp speed", ILHJFHFPGBB);
			JFDGLLEOPGB().SetFloat("menu.enableselectormusic", CCIENBFIKKH);
			KBOPGONOCNP().SetVector("Case-Sensitive", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1089f, 1525f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
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
