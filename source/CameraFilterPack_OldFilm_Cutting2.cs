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
			LNLKMDPHDCC().SetFloat("/Segment-[Up]", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value", 97f - Luminosity);
			KAFBNOBOIAJ().SetFloat("_SmallTex", 1226f - Vignette);
			NBMPPNFKFLB().SetFloat("CameraFilterPack/Distortion_ShockWave", Negative);
			HNICHJCGJOC().SetFloat("BloomShaderValueSlider", Speed);
			OLHDPICFBOF().SetTexture("CameraFilterPack/Blur_Regular", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
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
			DBOLLHHMKKN().SetFloat("CameraFilterPack/Drawing_Crosshatch", HBJJOCHGOPH);
			PGPEMMBJOOG().SetFloat("LevelNameInputField", 1208f - Luminosity);
			PGPEMMBJOOG().SetFloat("open", 1273f - Vignette);
			IFMAPIDFNLI().SetFloat("_ScreenResolution", Negative);
			DOHGBNPMBKG().SetFloat("_Value", Speed);
			MFHPKGICPIO().SetTexture("[PlayerBase] Loaded environment: ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FEHCNJLLJMP()
	{
		FPHEBLMINDA = Resources.Load("_Value3") as Texture2D;
		SCShader = Shader.Find(": ");
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
			KDMBOKLMADJ().SetFloat("_Speed", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat("SearchTex", 1992f - Luminosity);
			KDMBOKLMADJ().SetFloat("_LoopCount", 516f - Vignette);
			KJMECMIGJJA().SetFloat("settings.hideui", Negative);
			KEMAALEODNH().SetFloat("shader.sunny", Speed);
			NBPKMLMCHFN.SetTexture("_Value", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
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
			HNICHJCGJOC().SetFloat("[SERVER] Kicked ", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat("CameraFilterPack/AAA_Super_Hexagon", 1084f - Luminosity);
			KBOPGONOCNP().SetFloat("settings_bindings_sec_", 272f - Vignette);
			LNLKMDPHDCC().SetFloat("_CenterY", Negative);
			NBMPPNFKFLB().SetFloat("PossibleMapPointsText", Speed);
			FEAEGGCNIAA().SetTexture("_Glitch", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPCHMEKDCHI());
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
		FPHEBLMINDA = Resources.Load("hitsounds:") as Texture2D;
		SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OKLAJINHPAN()
	{
		FPHEBLMINDA = Resources.Load("Tab1Content") as Texture2D;
		SCShader = Shader.Find(",0");
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
		FPHEBLMINDA = Resources.Load("Fade") as Texture2D;
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
			HNICHJCGJOC().SetFloat("menu.selectedlevelid", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("DPADHOR", 873f - Luminosity);
			MLMKCOINOOH().SetFloat("_ScreenResolution", 570f - Vignette);
			KBOPGONOCNP().SetFloat("_Val3", Negative);
			HNICHJCGJOC().SetFloat("DPADVER", Speed);
			EOCCJGIGEGJ().SetTexture("LoadingStatusText", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOHGBNPMBKG());
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
		FPHEBLMINDA = Resources.Load("_Value") as Texture2D;
		SCShader = Shader.Find(".GoalProgress");
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
			KBOPGONOCNP().SetFloat("menu.tabid", HBJJOCHGOPH);
			OLHDPICFBOF().SetFloat("CameraFilterPack/FX_Hypno", 1924f - Luminosity);
			HNICHJCGJOC().SetFloat("[GameEvent] Exeption:", 333f - Vignette);
			LPCHMEKDCHI().SetFloat("LevelEditor/patterns", Negative);
			PGPEMMBJOOG().SetFloat("_Intensity", Speed);
			DBOLLHHMKKN().SetTexture("_Value2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
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
			EMDFHOKEGNG().SetFloat(".lastCheckpoint.time", HBJJOCHGOPH);
			CECJJMKLEAK().SetFloat("SpeedSlider", 1877f - Luminosity);
			LPCHMEKDCHI().SetFloat(":", 733f - Vignette);
			KEMAALEODNH().SetFloat("shader.sunny", Negative);
			NFKFAAHHLLM().SetFloat("CameraFilterPack/Color_Chromatic_Aberration", Speed);
			HNICHJCGJOC().SetTexture("powerup.1", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PGPEMMBJOOG());
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
		FPHEBLMINDA = Resources.Load("_ChromaticAberration") as Texture2D;
		SCShader = Shader.Find(".lastCheckpoint.playerdistance");
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
			HNICHJCGJOC().SetFloat("#ok", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("[PlayerBase] Invoke event ", 1707f - Luminosity);
			KEMAALEODNH().SetFloat("Crosshair1", 1579f - Vignette);
			MFHPKGICPIO().SetFloat("_NormalAndRoughnessTexture", Negative);
			DOHGBNPMBKG().SetFloat("ticket", Speed);
			KDMBOKLMADJ().SetTexture("tip", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KJMECMIGJJA());
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
		FPHEBLMINDA = Resources.Load("<b>Commands:</b>\n/help\n/players\n/kick\n/table\n/clear") as Texture2D;
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
			NFKFAAHHLLM().SetFloat("float,0", HBJJOCHGOPH);
			CECJJMKLEAK().SetFloat("_Value4", 1458f - Luminosity);
			DBOLLHHMKKN().SetFloat("settings_bindings_", 424f - Vignette);
			NBMPPNFKFLB().SetFloat("[MapEditor] Reset", Negative);
			PGPEMMBJOOG().SetFloat("OperationResponse unhandled: {0}", Speed);
			DOHGBNPMBKG().SetTexture("x", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PGPEMMBJOOG());
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
		FPHEBLMINDA = Resources.Load("-1") as Texture2D;
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
			EOCCJGIGEGJ().SetFloat("DPADVER", HBJJOCHGOPH);
			FEAEGGCNIAA().SetFloat(":</b> ", 1266f - Luminosity);
			EMDFHOKEGNG().SetFloat("SetTrailZoomSpeed", 1530f - Vignette);
			FEAEGGCNIAA().SetFloat("PunRespawn with Position.", Negative);
			DBOLLHHMKKN().SetFloat("masterSteamID", Speed);
			NFKFAAHHLLM().SetTexture("_DiffuseColor", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
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
		FPHEBLMINDA = Resources.Load("Joystick1Button7") as Texture2D;
		SCShader = Shader.Find("inventory.selected.");
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
		SCShader = Shader.Find("CameraFilterPack/TV_Tiles");
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
			CFEDGDGBCHE().SetFloat("If you host Photon yourself, make sure to start the 'Instance LoadBalancing' ", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("PublishButton", 348f - Luminosity);
			EMDFHOKEGNG().SetFloat("SaveGameName is null or empty!", 599f - Vignette);
			MLMKCOINOOH().SetFloat(" not exist", Negative);
			EOCCJGIGEGJ().SetFloat("CameraFilterPack/Blend2Camera_HardMix", Speed);
			HNICHJCGJOC().SetTexture("Save Path: ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PGPEMMBJOOG());
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
		SCShader = Shader.Find("checkpoint");
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
			KDMBOKLMADJ().SetFloat(".lastCheckpoint.powerupsScore", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("CameraFilterPack/Drawing_EnhancedComics", 816f - Luminosity);
			DBOLLHHMKKN().SetFloat("workshop.", 1425f - Vignette);
			LPCHMEKDCHI().SetFloat("_Value", Negative);
			LPCHMEKDCHI().SetFloat("maps.", Speed);
			EOCCJGIGEGJ().SetTexture("settings.volume.sfx", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
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
			OLHDPICFBOF().SetFloat("_Dist", HBJJOCHGOPH);
			CECJJMKLEAK().SetFloat("Done!", 864f - Luminosity);
			HNICHJCGJOC().SetFloat("_AdaptationMax", 1536f - Vignette);
			CECJJMKLEAK().SetFloat("ScoreText", Negative);
			OLHDPICFBOF().SetFloat("#", Speed);
			LPCHMEKDCHI().SetTexture("bad", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
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
			DOHGBNPMBKG().SetFloat("Player", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat("white", 1874f - Luminosity);
			NBMPPNFKFLB().SetFloat("_ScreenResolution", 1567f - Vignette);
			LNLKMDPHDCC().SetFloat("[Up]", Negative);
			KBOPGONOCNP().SetFloat("_ScreenResolution", Speed);
			IFMAPIDFNLI().SetTexture("DISTORT", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PGPEMMBJOOG());
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
			KBOPGONOCNP().SetFloat("Down", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value3", 1864f - Luminosity);
			NFKFAAHHLLM().SetFloat("_ScreenResolution", 129f - Vignette);
			IFMAPIDFNLI().SetFloat("EventConfigButton", Negative);
			KBOPGONOCNP().SetFloat("_ScreenResolution", Speed);
			KBOPGONOCNP().SetTexture("Set object anchor to another object", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
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
			KAFBNOBOIAJ().SetFloat("Prints list of all previous commands", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat("_Value6", 1625f - Luminosity);
			EMDFHOKEGNG().SetFloat("[Left]", 1884f - Vignette);
			CFEDGDGBCHE().SetFloat("_Speed", Negative);
			HNICHJCGJOC().SetFloat("_FgCocMask", Speed);
			HNICHJCGJOC().SetTexture("This might be a misconfiguration in the game server config. You need to edit it to a (public) address.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EMDFHOKEGNG());
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
			IFMAPIDFNLI().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			OLHDPICFBOF().SetFloat("ERROR", 1757f - Luminosity);
			NFKFAAHHLLM().SetFloat(".lastCheckpoint.maxLongestCombo", 193f - Vignette);
			MFHPKGICPIO().SetFloat(",", Negative);
			FEAEGGCNIAA().SetFloat("rd", Speed);
			HNICHJCGJOC().SetTexture("mapselector.filter.subscribedonly", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KJMECMIGJJA());
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
		FPHEBLMINDA = Resources.Load("+") as Texture2D;
		SCShader = Shader.Find("#yes");
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
			KAFBNOBOIAJ().SetFloat("_DistortionLevel", HBJJOCHGOPH);
			MLMKCOINOOH().SetFloat("CameraFilterPack/Gradients_Hue", 1465f - Luminosity);
			EMDFHOKEGNG().SetFloat("GraphicsQualitySlider", 1985f - Vignette);
			KBOPGONOCNP().SetFloat("UNDISTORT", Negative);
			NFKFAAHHLLM().SetFloat("OnRenderImage in Helper called ...", Speed);
			NBPKMLMCHFN.SetTexture("player.licenceaccepted", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
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
		FPHEBLMINDA = Resources.Load("GUICamera") as Texture2D;
		SCShader = Shader.Find("_SceneFogParams");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
