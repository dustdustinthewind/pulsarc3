// CameraFilterPack_OldFilm_Cutting2
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Old Film/Cutting 2")]
[ExecuteInEditMode]
public class CameraFilterPack_OldFilm_Cutting2 : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	[Range(0f, 10f)]
	public float Speed = 5f;

	[Range(0f, 2f)]
	public float Luminosity = 1f;

	[Range(0f, 1f)]
	public float Vignette = 1f;

	[Range(0f, 1f)]
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

	private void ALMGMOOHLMA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material KDMBOKLMADJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-85);
		}
		return BJFKDHHMLJH;
	}

	private void IEFMONDKKJN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material EOCCJGIGEGJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-97);
		}
		return BJFKDHHMLJH;
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1177f)
			{
				HBJJOCHGOPH = 1593f;
			}
			HNICHJCGJOC().SetFloat("/Segment-[Down]", HBJJOCHGOPH);
			KDMBOKLMADJ().SetFloat("_Value", 97f - Luminosity);
			NBMPPNFKFLB().SetFloat("offsets", 1226f - Vignette);
			EOCCJGIGEGJ().SetFloat("CameraFilterPack/Distortion_ShockWave", Negative);
			OLHDPICFBOF().SetFloat("BloomShaderValueSlider", Speed);
			EOCCJGIGEGJ().SetTexture("_TimeX", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PLIKADJCEPO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BGFJOEPFOPM()
	{
	}

	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1803f)
			{
				HBJJOCHGOPH = 700f;
			}
			DBOLLHHMKKN().SetFloat("_TimeX", HBJJOCHGOPH);
			FEAEGGCNIAA().SetFloat("resource", 1208f - Luminosity);
			KBOPGONOCNP().SetFloat("Room: '{0}' {1},{2} {4}/{3} players.\ncustomProps: {5}", 1273f - Vignette);
			KJMECMIGJJA().SetFloat("CameraFilterPack/TV_Tiles", Negative);
			CECJJMKLEAK().SetFloat("_Value2", Speed);
			EOCCJGIGEGJ().SetTexture("Crosshair", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FEHCNJLLJMP()
	{
		FPHEBLMINDA = Resources.Load("_ScreenResolution") as Texture2D;
		SCShader = Shader.Find(" not exist");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DPFOEBCADNP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material DBOLLHHMKKN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 386f)
			{
				HBJJOCHGOPH = 1023f;
			}
			MLMKCOINOOH().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			MLMKCOINOOH().SetFloat("_SearchTex", 1992f - Luminosity);
			PGPEMMBJOOG().SetFloat("_NeighborMaxTex", 516f - Vignette);
			HHIFMIPPMPF().SetFloat("settings.shaders", Negative);
			MFHPKGICPIO().SetFloat("shader.sunny", Speed);
			PGPEMMBJOOG().SetTexture("_Value", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material NFKFAAHHLLM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)127;
		}
		return BJFKDHHMLJH;
	}

	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1414f)
			{
				HBJJOCHGOPH = 983f;
			}
			LPCHMEKDCHI().SetFloat("[SERVER] Kicked ", HBJJOCHGOPH);
			LPCHMEKDCHI().SetFloat("CameraFilterPack/AAA_Super_Hexagon", 1084f - Luminosity);
			KEMAALEODNH().SetFloat("' has been reset to the fault value", 272f - Vignette);
			KEMAALEODNH().SetFloat("_Distortion", Negative);
			MLMKCOINOOH().SetFloat("PossibleMapPointsText", Speed);
			PGPEMMBJOOG().SetTexture("_Glitch", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material KAFBNOBOIAJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)125;
		}
		return BJFKDHHMLJH;
	}

	private void ODGMCJILIHF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KDMANOEMOCA()
	{
		FPHEBLMINDA = Resources.Load(",") as Texture2D;
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OKLAJINHPAN()
	{
		FPHEBLMINDA = Resources.Load("Tab1Content") as Texture2D;
		SCShader = Shader.Find("[Up]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MDCFIHDPLIG()
	{
	}

	[SpecialName]
	private Material EMDFHOKEGNG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void EJJEDJIOFAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material MLMKCOINOOH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void JILOMOBDPIA()
	{
		FPHEBLMINDA = Resources.Load("VisionBlur") as Texture2D;
		SCShader = Shader.Find("ScreenResolutionPanel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material NBMPPNFKFLB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return BJFKDHHMLJH;
	}

	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 762f)
			{
				HBJJOCHGOPH = 880f;
			}
			KBOPGONOCNP().SetFloat("menu.selectedlevelid", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat("DPADVER", 873f - Luminosity);
			FEAEGGCNIAA().SetFloat("CameraFilterPack/Color_Chromatic_Aberration", 570f - Vignette);
			LPCHMEKDCHI().SetFloat("CameraFilterPack/Deep_OilPaintHQ", Negative);
			KDMBOKLMADJ().SetFloat("DPADHOR", Speed);
			KBOPGONOCNP().SetTexture("LoadingStatusText", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IFMAPIDFNLI());
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

	private void NAALCEPIHCH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MKIMDFLBFOM()
	{
		FPHEBLMINDA = Resources.Load("_ScreenResolution") as Texture2D;
		SCShader = Shader.Find(".completedMaps");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EDBEHEKMGFH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
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

	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1467f)
			{
				HBJJOCHGOPH = 1117f;
			}
			LPCHMEKDCHI().SetFloat("menu.tabid", HBJJOCHGOPH);
			EMDFHOKEGNG().SetFloat("_TimeX", 1924f - Luminosity);
			EOCCJGIGEGJ().SetFloat("ShowTitle", 333f - Vignette);
			LNLKMDPHDCC().SetFloat("LevelEditor/icons", Negative);
			EOCCJGIGEGJ().SetFloat("_BgFade", Speed);
			IFMAPIDFNLI().SetTexture("_Value4", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1486f)
			{
				HBJJOCHGOPH = 1154f;
			}
			PGPEMMBJOOG().SetFloat("SetPlayerDistance", HBJJOCHGOPH);
			MLMKCOINOOH().SetFloat("ConfigVersionSlider", 1877f - Luminosity);
			NBPKMLMCHFN.SetFloat(":", 733f - Vignette);
			LNLKMDPHDCC().SetFloat("shader.sunny", Negative);
			KAFBNOBOIAJ().SetFloat("CameraFilterPack/Color_Chromatic_Aberration", Speed);
			NBPKMLMCHFN.SetTexture("bloomintencity:", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LNLKMDPHDCC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material MFHPKGICPIO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void OHFOLGANOLC()
	{
		FPHEBLMINDA = Resources.Load("_BlurDistance") as Texture2D;
		SCShader = Shader.Find(".");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material PGPEMMBJOOG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void NNPBKKBFDHH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MFMIODIAKNI()
	{
	}

	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 240f)
			{
				HBJJOCHGOPH = 1606f;
			}
			DOHGBNPMBKG().SetFloat("[MapEditor] Exported to ", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("[PlayerBase] SetSpeed error: ", 1707f - Luminosity);
			HNICHJCGJOC().SetFloat("Crosshair2", 1579f - Vignette);
			NBPKMLMCHFN.SetFloat("_ReflectionTexture0", Negative);
			DOHGBNPMBKG().SetFloat("error", Speed);
			NBMPPNFKFLB().SetTexture(" #", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IFMAPIDFNLI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CBIBDOIBJAI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HGDDCINLDAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LPMINJJPDCH()
	{
	}

	private void GNMGIHFKJIJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JOONHGHGKKF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PKLOBJHKFEO()
	{
		FPHEBLMINDA = Resources.Load("MenuScene") as Texture2D;
		SCShader = Shader.Find("finished");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OCMKCBBCEFG()
	{
	}

	[SpecialName]
	private Material DOHGBNPMBKG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return BJFKDHHMLJH;
	}

	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 594f)
			{
				HBJJOCHGOPH = 1411f;
			}
			MLMKCOINOOH().SetFloat("float,0", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("_ScreenResolution", 1458f - Luminosity);
			NFKFAAHHLLM().SetFloat("settings_bindings_", 424f - Vignette);
			EMDFHOKEGNG().SetFloat("#currentbpm: ", Negative);
			MFHPKGICPIO().SetFloat("Connected to NameServer.", Speed);
			DBOLLHHMKKN().SetTexture("x", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GPHPJIDGEPI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HHIFMIPPMPF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void LMADKINICIN()
	{
	}

	private void DAHFFNNIGML()
	{
		FPHEBLMINDA = Resources.Load("\n\n#") as Texture2D;
		SCShader = Shader.Find("Tab2Content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ABIOAMNCEOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 172f)
			{
				HBJJOCHGOPH = 325f;
			}
			EMDFHOKEGNG().SetFloat("DPADHOR", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("<b>[", 1266f - Luminosity);
			CECJJMKLEAK().SetFloat("SetTrailZoomSpeed", 1530f - Vignette);
			KEMAALEODNH().SetFloat("Ignored PU RPC, cause item is inactive. ", Negative);
			EMDFHOKEGNG().SetFloat("masterSteamID", Speed);
			CECJJMKLEAK().SetTexture("_EmissionColor", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LPCHMEKDCHI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void OFIMMFHFHDD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ILCFPCIPENO()
	{
		FPHEBLMINDA = Resources.Load("R2") as Texture2D;
		SCShader = Shader.Find("LoadingStatusText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ODAIMOJLJOF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CFFCLAHMBAA()
	{
		FPHEBLMINDA = Resources.Load("menutheme.summerbreeze") as Texture2D;
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LINKAMEPKGM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JBNPEHMDCMI()
	{
	}

	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1927f)
			{
				HBJJOCHGOPH = 735f;
			}
			NFKFAAHHLLM().SetFloat("Authentication failed: '{0}' Code: {1}", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("PublishButton", 348f - Luminosity);
			OLHDPICFBOF().SetFloat("OnSerialize", 599f - Vignette);
			DBOLLHHMKKN().SetFloat("[PlayerController] ", Negative);
			MFHPKGICPIO().SetFloat("CameraFilterPack/Blend2Camera_HardMix", Speed);
			NBMPPNFKFLB().SetTexture(";", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EODOHEAKJFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FODKODGPPDA()
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
			BJFKDHHMLJH.hideFlags = (HideFlags)99;
		}
		return BJFKDHHMLJH;
	}

	private void LBIOIEANMGI()
	{
	}

	[SpecialName]
	private Material CECJJMKLEAK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-78);
		}
		return BJFKDHHMLJH;
	}

	private void CGBHOELMAOC()
	{
	}

	private void CHOPDIGHJNH()
	{
		FPHEBLMINDA = Resources.Load("ready") as Texture2D;
		SCShader = Shader.Find("UndoButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FDMAEPOHDMK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1696f)
			{
				HBJJOCHGOPH = 507f;
			}
			KBOPGONOCNP().SetFloat(".lastCheckpoint.perfectHits", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat("_TimeX", 816f - Luminosity);
			OLHDPICFBOF().SetFloat("workshop.", 1425f - Vignette);
			KAFBNOBOIAJ().SetFloat("_Value2", Negative);
			MFHPKGICPIO().SetFloat("maps.", Speed);
			FEAEGGCNIAA().SetTexture("settings.volume.editor", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CECJJMKLEAK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BLKGOMCPEKI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HDDECCMEJKA()
	{
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-72);
		}
		return BJFKDHHMLJH;
	}

	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1367f)
			{
				HBJJOCHGOPH = 1125f;
			}
			NBMPPNFKFLB().SetFloat("_Smooth", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("OK", 864f - Luminosity);
			DOHGBNPMBKG().SetFloat("ENABLE_EYE_ADAPTATION", 1536f - Vignette);
			MLMKCOINOOH().SetFloat("score:", Negative);
			OLHDPICFBOF().SetFloat("\\n", Speed);
			HNICHJCGJOC().SetTexture("#scoresubmitionfailed: ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPCHMEKDCHI());
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void OIBMHPIFAKK()
	{
	}

	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 632f)
			{
				HBJJOCHGOPH = 634f;
			}
			MFHPKGICPIO().SetFloat("settings.shaders", HBJJOCHGOPH);
			LPCHMEKDCHI().SetFloat("gold", 1874f - Luminosity);
			MFHPKGICPIO().SetFloat("CameraFilterPack/Gradients_FireGradient", 1567f - Vignette);
			DOHGBNPMBKG().SetFloat("SpawnObj", Negative);
			NBMPPNFKFLB().SetFloat("_ScreenResolution", Speed);
			EMDFHOKEGNG().SetTexture("VIGNETTE_DESAT", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KLOLKEBAPFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1425f)
			{
				HBJJOCHGOPH = 1146f;
			}
			EMDFHOKEGNG().SetFloat("Down ", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("_Value4", 1864f - Luminosity);
			LNLKMDPHDCC().SetFloat("CameraFilterPack/TV_Vignetting", 129f - Vignette);
			NFKFAAHHLLM().SetFloat("EventConfigButton", Negative);
			KBOPGONOCNP().SetFloat("CameraFilterPack/Film_Grain", Speed);
			LPCHMEKDCHI().SetTexture("SetSunColors", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PKBENONAOOL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FGBDGGCBFLP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 728f)
			{
				HBJJOCHGOPH = 194f;
			}
			KAFBNOBOIAJ().SetFloat("logc", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("_Value6", 1625f - Luminosity);
			EMDFHOKEGNG().SetFloat("SpawnObj", 1884f - Vignette);
			FEAEGGCNIAA().SetFloat("_Speed", Negative);
			KDMBOKLMADJ().SetFloat("_Offsets", Speed);
			NFKFAAHHLLM().SetTexture(". Check if the server is available.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IFMAPIDFNLI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1669f)
			{
				HBJJOCHGOPH = 762f;
			}
			EOCCJGIGEGJ().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("[ItemsHandler] All in-game items loaded", 1757f - Luminosity);
			KBOPGONOCNP().SetFloat(".lastCheckpoint.powerupsScore", 193f - Vignette);
			IFMAPIDFNLI().SetFloat("CountEventsGoal", Negative);
			NBPKMLMCHFN.SetFloat(" ", Speed);
			HNICHJCGJOC().SetTexture("mapselector.filter.subscribedonly", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Start()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_OldFilm2") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/OldFilm_Cutting2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FIKFJDFELIP()
	{
		FPHEBLMINDA = Resources.Load("VoteDownToggle") as Texture2D;
		SCShader = Shader.Find("EventData0DropDownList");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HLLHJIDOOGA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material FEAEGGCNIAA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-114);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KJMECMIGJJA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)105;
		}
		return BJFKDHHMLJH;
	}

	private void CNDACAHCCOI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material CFEDGDGBCHE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-119);
		}
		return BJFKDHHMLJH;
	}

	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1225f)
			{
				HBJJOCHGOPH = 1263f;
			}
			MFHPKGICPIO().SetFloat("_DistortionLevel", HBJJOCHGOPH);
			IFMAPIDFNLI().SetFloat("_TimeX", 1465f - Luminosity);
			FEAEGGCNIAA().SetFloat("CameraMovementSlider", 1985f - Vignette);
			KAFBNOBOIAJ().SetFloat("_DistAmount", Negative);
			KBOPGONOCNP().SetFloat("_MainTex", Speed);
			DBOLLHHMKKN().SetTexture("player.licenceaccepted", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LOMDIOLNFHI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material OLHDPICFBOF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-117);
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
			NBPKMLMCHFN.SetFloat("_Value", 2f - Luminosity);
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

	[SpecialName]
	private Material IFMAPIDFNLI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)126;
		}
		return BJFKDHHMLJH;
	}

	private void FHPFJBFCOOF()
	{
		FPHEBLMINDA = Resources.Load("Is it practically possible?") as Texture2D;
		SCShader = Shader.Find("_MainTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
