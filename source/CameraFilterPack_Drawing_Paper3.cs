// CameraFilterPack_Drawing_Paper3
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Drawing/Paper3")]
public class CameraFilterPack_Drawing_Paper3 : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	public Color Pencil_Color = new Color(0f, 0f, 0f, 0f);

	[Range(0.0001f, 0.0022f)]
	public float Pencil_Size = 0.00125f;

	[Range(0f, 2f)]
	public float Pencil_Correction = 0.35f;

	[Range(0f, 1f)]
	public float Intensity = 1f;

	[Range(0f, 2f)]
	public float Speed_Animation = 1f;

	[Range(0f, 1f)]
	public float Corner_Lose = 1f;

	[Range(0f, 1f)]
	public float Fade_Paper_to_BackColor;

	[Range(0f, 1f)]
	public float Fade_With_Original = 1f;

	public Color Back_Color = new Color(1f, 1f, 1f, 1f);

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

	private void OHFOLGANOLC()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack/Blend2Camera_Subtract") as Texture2D;
		SCShader = Shader.Find("0 seconds");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 926f)
			{
				HBJJOCHGOPH = 918f;
			}
			IONHGBPGCHK().SetFloat("_TimeX", HBJJOCHGOPH);
			CFEDGDGBCHE().SetColor("_ScreenResolution", Pencil_Color);
			PDEAHJPOMEF().SetFloat("PointsScoreText", Pencil_Size);
			CFEDGDGBCHE().SetFloat("DPADVER", Pencil_Correction);
			MMOODGIODPC().SetFloat("settings_bindings_controller_type", Intensity);
			PDEAHJPOMEF().SetFloat("The given 2D texture ", Speed_Animation);
			MMOODGIODPC().SetFloat("Result for ", Corner_Lose);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/TV_Noise", Fade_Paper_to_BackColor);
			IONHGBPGCHK().SetFloat("_VignetteTex", Fade_With_Original);
			GCDFNHMJMIP().SetColor("Selection Box", Back_Color);
			NBPKMLMCHFN.SetTexture("/", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IFIHBNJKEKD()
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

	private void PMPKMGKAAJH()
	{
		FPHEBLMINDA = Resources.Load("0x") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Distortion_BlackHole");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void Update()
	{
	}

	private void JILOMOBDPIA()
	{
		FPHEBLMINDA = Resources.Load("_Radius2") as Texture2D;
		SCShader = Shader.Find("players");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material OIMMPLPBLBK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)85;
		}
		return BJFKDHHMLJH;
	}

	private void Start()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_Paper4") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Drawing_Paper3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material MMOODGIODPC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void ALMGMOOHLMA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NKLIHNJCHOG()
	{
	}

	[SpecialName]
	private Material MFHPKGICPIO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-101);
		}
		return BJFKDHHMLJH;
	}

	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 820f)
			{
				HBJJOCHGOPH = 1062f;
			}
			IONHGBPGCHK().SetFloat("_Alpha", HBJJOCHGOPH);
			NBPKMLMCHFN.SetColor("_Value4", Pencil_Color);
			OIMMPLPBLBK().SetFloat("settings.hideui", Pencil_Size);
			HEHKGPKLAKK().SetFloat("_Value4", Pencil_Correction);
			IONHGBPGCHK().SetFloat("maps.", Intensity);
			NBPKMLMCHFN.SetFloat("_Value2", Speed_Animation);
			MMOODGIODPC().SetFloat("id", Corner_Lose);
			OIMMPLPBLBK().SetFloat("_MainTex", Fade_Paper_to_BackColor);
			MFHPKGICPIO().SetFloat("_ScreenResolution", Fade_With_Original);
			NBPKMLMCHFN.SetColor("_Fade", Back_Color);
			NBPKMLMCHFN.SetTexture("_Glitch", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1735f)
			{
				HBJJOCHGOPH = 1484f;
			}
			NBPKMLMCHFN.SetFloat("_SizeY", HBJJOCHGOPH);
			NBPKMLMCHFN.SetColor("_EmissionGain", Pencil_Color);
			OIMMPLPBLBK().SetFloat("_Value2", Pencil_Size);
			IONHGBPGCHK().SetFloat("DISTORT", Pencil_Correction);
			IONHGBPGCHK().SetFloat(".lastCheckpoint.powerupsScore", Intensity);
			MFHPKGICPIO().SetFloat("_ReflectionTexture2", Speed_Animation);
			OIMMPLPBLBK().SetFloat("SpectatingUserInfo", Corner_Lose);
			OIMMPLPBLBK().SetFloat("Checkpoint", Fade_Paper_to_BackColor);
			OIMMPLPBLBK().SetFloat("1248864821", Fade_With_Original);
			OIMMPLPBLBK().SetColor("_Parameter", Back_Color);
			GCDFNHMJMIP().SetTexture("In Main Menu", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IMCKJCHKMKB()
	{
		FPHEBLMINDA = Resources.Load("_ScreenResolution") as Texture2D;
		SCShader = Shader.Find("_FinalReflectionTexture");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void FPHLDMMAOEF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DAHFFNNIGML()
	{
		FPHEBLMINDA = Resources.Load(". Check if the server is available.") as Texture2D;
		SCShader = Shader.Find("_SSAO");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FBMDHDBELEK()
	{
	}

	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 144f)
			{
				HBJJOCHGOPH = 680f;
			}
			MMOODGIODPC().SetFloat("_ChannelMixerGreen", HBJJOCHGOPH);
			HNICHJCGJOC().SetColor("<b>Max Score</b>:", Pencil_Color);
			PDEAHJPOMEF().SetFloat("_Value", Pencil_Size);
			IONHGBPGCHK().SetFloat("OpCreateRoom()", Pencil_Correction);
			NBPKMLMCHFN.SetFloat("_Value3", Intensity);
			MFHPKGICPIO().SetFloat("GUICamera", Speed_Animation);
			HNICHJCGJOC().SetFloat("PLEASE WAIT", Corner_Lose);
			MMOODGIODPC().SetFloat("\nCreated by Oxy949", Fade_Paper_to_BackColor);
			MFHPKGICPIO().SetFloat("[Steamworks.NET] SteamAPI_Init() failed. Refer to Valve's documentation or the comment above this line for more information.", Fade_With_Original);
			OIMMPLPBLBK().SetColor(". Our prefix is ", Back_Color);
			NBPKMLMCHFN.SetTexture("]. Please verify you have this gameobject in a Resources folder.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material CFEDGDGBCHE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)78;
		}
		return BJFKDHHMLJH;
	}

	private void BGDPIHMAACO()
	{
		FPHEBLMINDA = Resources.Load("received</b>\n#reason: ") as Texture2D;
		SCShader = Shader.Find("_PrefilterOffs");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PKLOBJHKFEO()
	{
		FPHEBLMINDA = Resources.Load("_SmoothEnd") as Texture2D;
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material HEHKGPKLAKK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-117);
		}
		return BJFKDHHMLJH;
	}

	private void DGCGGKMNPLD()
	{
	}

	[SpecialName]
	private Material HNICHJCGJOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-91);
		}
		return BJFKDHHMLJH;
	}

	private void HLIAEEMGBHN()
	{
		FPHEBLMINDA = Resources.Load("Object ID. Case-Sensitive") as Texture2D;
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AAPKBNDHBLI()
	{
	}

	private void OCCGJMPAJIK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FOMNCPKKCFN()
	{
	}

	[SpecialName]
	private Material GCDFNHMJMIP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1653f)
			{
				HBJJOCHGOPH = 1255f;
			}
			CFEDGDGBCHE().SetFloat("\t", HBJJOCHGOPH);
			OIMMPLPBLBK().SetColor("_DistortionLevel", Pencil_Color);
			MFHPKGICPIO().SetFloat("Joystick1Button10", Pencil_Size);
			NBPKMLMCHFN.SetFloat("Clears all text from the debug console", Pencil_Correction);
			HNICHJCGJOC().SetFloat("OK", Intensity);
			MFHPKGICPIO().SetFloat("UI", Speed_Animation);
			IONHGBPGCHK().SetFloat("_FarCamera", Corner_Lose);
			HNICHJCGJOC().SetFloat("Observed type is not serializable: ", Fade_Paper_to_BackColor);
			MFHPKGICPIO().SetFloat("menutheme.27thfloor", Fade_With_Original);
			OIMMPLPBLBK().SetColor(" from: ", Back_Color);
			MMOODGIODPC().SetTexture("CameraFilterPack/Vision_Psycho", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HLDFOJMHKNL()
	{
	}

	private void CIPKEPDELJB()
	{
		FPHEBLMINDA = Resources.Load("_Max") as Texture2D;
		SCShader = Shader.Find("^");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BMOFEBKGLFI()
	{
		FPHEBLMINDA = Resources.Load("</color>") as Texture2D;
		SCShader = Shader.Find("<start_index> <end_index>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-86);
		}
		return BJFKDHHMLJH;
	}

	private void HGDDCINLDAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DHNGNHGDPLM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OEENOOGEEHD()
	{
	}

	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 381f)
			{
				HBJJOCHGOPH = 721f;
			}
			CFEDGDGBCHE().SetFloat("CameraFilterPack_Glasses_On2", HBJJOCHGOPH);
			MMOODGIODPC().SetColor("Closes the app", Pencil_Color);
			IONHGBPGCHK().SetFloat("_Distortion", Pencil_Size);
			IONHGBPGCHK().SetFloat("_Value2", Pencil_Correction);
			HEHKGPKLAKK().SetFloat("_ScreenResolution", Intensity);
			IONHGBPGCHK().SetFloat("Working.\nPlease wait..", Speed_Animation);
			PDEAHJPOMEF().SetFloat("GameScene", Corner_Lose);
			IONHGBPGCHK().SetFloat("Tab1Content", Fade_Paper_to_BackColor);
			GCDFNHMJMIP().SetFloat("-1", Fade_With_Original);
			CFEDGDGBCHE().SetColor(".lastCheckpoint.currentCombo", Back_Color);
			OIMMPLPBLBK().SetTexture("Description goes here", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK());
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
			if (HBJJOCHGOPH > 916f)
			{
				HBJJOCHGOPH = 905f;
			}
			HEHKGPKLAKK().SetFloat("_Value2", HBJJOCHGOPH);
			IONHGBPGCHK().SetColor("Image", Pencil_Color);
			MMOODGIODPC().SetFloat("(\\[ */ *h1 *\\])", Pencil_Size);
			CFEDGDGBCHE().SetFloat(".lastCheckpoint.lives", Pencil_Correction);
			IONHGBPGCHK().SetFloat("_Visualize", Intensity);
			MMOODGIODPC().SetFloat("_Value2", Speed_Animation);
			IONHGBPGCHK().SetFloat("TotalHitsScoreText", Corner_Lose);
			MMOODGIODPC().SetFloat("No info", Fade_Paper_to_BackColor);
			CFEDGDGBCHE().SetFloat("-", Fade_With_Original);
			OIMMPLPBLBK().SetColor("[Right]", Back_Color);
			NBPKMLMCHFN.SetTexture("_ChromaticAberration", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FBPHNEJBDJN()
	{
		FPHEBLMINDA = Resources.Load("_ScreenResolution") as Texture2D;
		SCShader = Shader.Find("#");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 919f)
			{
				HBJJOCHGOPH = 1894f;
			}
			CFEDGDGBCHE().SetFloat("#pleasewait", HBJJOCHGOPH);
			OIMMPLPBLBK().SetColor(" ", Pencil_Color);
			MMOODGIODPC().SetFloat("_Value6", Pencil_Size);
			IONHGBPGCHK().SetFloat("[LevelEditorScene] Error: I/O Failure! :(", Pencil_Correction);
			HNICHJCGJOC().SetFloat("SpawnObj", Intensity);
			NBPKMLMCHFN.SetFloat("received</b>\n#reason: ", Speed_Animation);
			HNICHJCGJOC().SetFloat("editor.", Corner_Lose);
			OIMMPLPBLBK().SetFloat("_Saturation", Fade_Paper_to_BackColor);
			MFHPKGICPIO().SetFloat("Default UI Material", Fade_With_Original);
			IONHGBPGCHK().SetColor(".lastCheckpoint.playerdistance", Back_Color);
			PDEAHJPOMEF().SetTexture("AudioSampler", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IFJDKDFLGBG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LCHBFNIPBHB()
	{
	}

	private void CHOPDIGHJNH()
	{
		FPHEBLMINDA = Resources.Load("NEW") as Texture2D;
		SCShader = Shader.Find("{\"items\":");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JHPOIOELNCG()
	{
	}

	private void EHCGBJDFMHG()
	{
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
			NBPKMLMCHFN.SetColor("_PColor", Pencil_Color);
			NBPKMLMCHFN.SetFloat("_Value1", Pencil_Size);
			NBPKMLMCHFN.SetFloat("_Value2", Pencil_Correction);
			NBPKMLMCHFN.SetFloat("_Value3", Intensity);
			NBPKMLMCHFN.SetFloat("_Value4", Speed_Animation);
			NBPKMLMCHFN.SetFloat("_Value5", Corner_Lose);
			NBPKMLMCHFN.SetFloat("_Value6", Fade_Paper_to_BackColor);
			NBPKMLMCHFN.SetFloat("_Value7", Fade_With_Original);
			NBPKMLMCHFN.SetColor("_PColor2", Back_Color);
			NBPKMLMCHFN.SetTexture("_MainTex2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IKIDIJLIGOH()
	{
	}

	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 276f)
			{
				HBJJOCHGOPH = 635f;
			}
			HEHKGPKLAKK().SetFloat("?", HBJJOCHGOPH);
			IONHGBPGCHK().SetColor("/icon", Pencil_Color);
			OIMMPLPBLBK().SetFloat("Connected to masterserver.", Pencil_Size);
			PDEAHJPOMEF().SetFloat("[PlayerController] ", Pencil_Correction);
			MMOODGIODPC().SetFloat("Editor/", Intensity);
			IONHGBPGCHK().SetFloat("_EmissionColor", Speed_Animation);
			NBPKMLMCHFN.SetFloat(": ", Corner_Lose);
			GCDFNHMJMIP().SetFloat("shader.crispwinter", Fade_Paper_to_BackColor);
			GCDFNHMJMIP().SetFloat("SpeedSlider", Fade_With_Original);
			HEHKGPKLAKK().SetColor(":", Back_Color);
			HEHKGPKLAKK().SetTexture("/icon", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ANCKKLFPGDI()
	{
		FPHEBLMINDA = Resources.Load("_Value3") as Texture2D;
		SCShader = Shader.Find("[MapsData] Bad map: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PAKPHKPDKGE()
	{
		FPHEBLMINDA = Resources.Load("_TimeX") as Texture2D;
		SCShader = Shader.Find("http://steamcommunity.com/sharedfiles/filedetails/?id=");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1174f)
			{
				HBJJOCHGOPH = 1132f;
			}
			HEHKGPKLAKK().SetFloat("UseScanLine", HBJJOCHGOPH);
			NBPKMLMCHFN.SetColor("New level loaded. Removed ", Pencil_Color);
			OIMMPLPBLBK().SetFloat("_InternalLutTex", Pencil_Size);
			HEHKGPKLAKK().SetFloat("_ScreenResolution", Pencil_Correction);
			MMOODGIODPC().SetFloat("End index must in an integer.", Intensity);
			PDEAHJPOMEF().SetFloat("_Value1", Speed_Animation);
			HNICHJCGJOC().SetFloat(": ", Corner_Lose);
			MFHPKGICPIO().SetFloat("_Far", Fade_Paper_to_BackColor);
			GCDFNHMJMIP().SetFloat("Drop_With_Obj", Fade_With_Original);
			HNICHJCGJOC().SetColor("_Value4", Back_Color);
			MFHPKGICPIO().SetTexture("mapselector.tags.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GPFJMKCGHGB()
	{
	}

	private void KIMMMCJFMAB()
	{
		FPHEBLMINDA = Resources.Load("\n - NetID: ") as Texture2D;
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EGEGNHLODAA()
	{
	}

	private void MMBPLGGLPDB()
	{
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 143f)
			{
				HBJJOCHGOPH = 251f;
			}
			HEHKGPKLAKK().SetFloat("[SERVER] Kicked ", HBJJOCHGOPH);
			HEHKGPKLAKK().SetColor("_Quality", Pencil_Color);
			HNICHJCGJOC().SetFloat("maps.", Pencil_Size);
			GCDFNHMJMIP().SetFloat("_BlurRadius4", Pencil_Correction);
			MMOODGIODPC().SetFloat("player.redarc", Intensity);
			HNICHJCGJOC().SetFloat("_MotionBlurTmpCam", Speed_Animation);
			IONHGBPGCHK().SetFloat("bad", Corner_Lose);
			OIMMPLPBLBK().SetFloat("CameraFilterPack/TV_Noise", Fade_Paper_to_BackColor);
			HEHKGPKLAKK().SetFloat("Hidden/Fast Approximate Anti-aliasing", Fade_With_Original);
			MMOODGIODPC().SetColor("[PlayerController] ", Back_Color);
			HNICHJCGJOC().SetTexture("IconFileSelector", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FJIKDJAMOHA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MGFFNGEGFDC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 678f)
			{
				HBJJOCHGOPH = 1139f;
			}
			NBPKMLMCHFN.SetFloat("_FadeDistance", HBJJOCHGOPH);
			GCDFNHMJMIP().SetColor("Parameter levelId can't be null!", Pencil_Color);
			OIMMPLPBLBK().SetFloat("OperationResponse ignored while disconnecting. Code: ", Pencil_Size);
			HNICHJCGJOC().SetFloat("UI Extensions/UIScreen", Pencil_Correction);
			MMOODGIODPC().SetFloat("LoadMapCanvas", Intensity);
			OIMMPLPBLBK().SetFloat("cancel", Speed_Animation);
			PDEAHJPOMEF().SetFloat("[PlayerBase] Loaded custom model: ", Corner_Lose);
			MFHPKGICPIO().SetFloat("0", Fade_Paper_to_BackColor);
			IONHGBPGCHK().SetFloat("settings_bindings_", Fade_With_Original);
			HNICHJCGJOC().SetColor("OnPhotonRandomJoinFailed() was called by PUN. No random room available, so we create one. Calling: PhotonNetwork.CreateRoom(null, new RoomOptions() {maxPlayers = 4}, null);", Back_Color);
			GCDFNHMJMIP().SetTexture("Fill Area", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 64f)
			{
				HBJJOCHGOPH = 1020f;
			}
			MMOODGIODPC().SetFloat("[DiscordController] Error {0}: {1}", HBJJOCHGOPH);
			IONHGBPGCHK().SetColor("shader.ghost", Pencil_Color);
			CFEDGDGBCHE().SetFloat("CameraFilterPack/Blend2Camera_Color", Pencil_Size);
			MMOODGIODPC().SetFloat("Tab2Content", Pencil_Correction);
			GCDFNHMJMIP().SetFloat("stretchWidth", Intensity);
			CFEDGDGBCHE().SetFloat("Myst", Speed_Animation);
			HEHKGPKLAKK().SetFloat("float,0", Corner_Lose);
			HNICHJCGJOC().SetFloat("note.2", Fade_Paper_to_BackColor);
			IONHGBPGCHK().SetFloat("[PlayerController] ", Fade_With_Original);
			OIMMPLPBLBK().SetColor("file://", Back_Color);
			CFEDGDGBCHE().SetTexture("maps.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DOEPOGLEGLE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}
}
