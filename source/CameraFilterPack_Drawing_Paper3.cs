// CameraFilterPack_Drawing_Paper3
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Drawing/Paper3")]
[ExecuteInEditMode]
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
			PDEAHJPOMEF().SetFloat("CameraFilterPack/Color_Noise", HBJJOCHGOPH);
			CFEDGDGBCHE().SetColor("Fade", Pencil_Color);
			HEHKGPKLAKK().SetFloat("PointsScoreText", Pencil_Size);
			PDEAHJPOMEF().SetFloat("DPADHOR", Pencil_Correction);
			NBPKMLMCHFN.SetFloat("settings_bindings_controller_type", Intensity);
			GCDFNHMJMIP().SetFloat("CameraFilterPack/Lut_TestMode", Speed_Animation);
			HEHKGPKLAKK().SetFloat("Result for ", Corner_Lose);
			HNICHJCGJOC().SetFloat("_ScreenResolution", Fade_Paper_to_BackColor);
			OIMMPLPBLBK().SetFloat("_Intensity", Fade_With_Original);
			IONHGBPGCHK().SetColor("SelectionBox component must be placed on a canvas in Screen Space Overlay mode.", Back_Color);
			MFHPKGICPIO().SetTexture("/", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
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
		SCShader = Shader.Find("_ScreenResolution");
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
		FPHEBLMINDA = Resources.Load("_Rand") as Texture2D;
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
			MFHPKGICPIO().SetFloat("_Alpha", HBJJOCHGOPH);
			OIMMPLPBLBK().SetColor("_Value4", Pencil_Color);
			GCDFNHMJMIP().SetFloat("' found!", Pencil_Size);
			HEHKGPKLAKK().SetFloat("_Value3", Pencil_Correction);
			NBPKMLMCHFN.SetFloat("maps.", Intensity);
			IONHGBPGCHK().SetFloat("_Value", Speed_Animation);
			OIMMPLPBLBK().SetFloat("id", Corner_Lose);
			PDEAHJPOMEF().SetFloat("OnRenderImage in Helper called ...", Fade_Paper_to_BackColor);
			GCDFNHMJMIP().SetFloat("_ScreenResolution", Fade_With_Original);
			MFHPKGICPIO().SetColor("CameraFilterPack/Pixelisation_Sweater", Back_Color);
			GCDFNHMJMIP().SetTexture("_TimeX", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
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
			OIMMPLPBLBK().SetColor("_EmissionGain", Pencil_Color);
			PDEAHJPOMEF().SetFloat("_Value2", Pencil_Size);
			MMOODGIODPC().SetFloat("_VignetteColor", Pencil_Correction);
			HEHKGPKLAKK().SetFloat(".lastCheckpoint.incorrectScore", Intensity);
			IONHGBPGCHK().SetFloat("_ReflectionTexture0", Speed_Animation);
			HEHKGPKLAKK().SetFloat("workshop.", Corner_Lose);
			HEHKGPKLAKK().SetFloat("ShowSprite", Fade_Paper_to_BackColor);
			MFHPKGICPIO().SetFloat("Reset 21 achievement progress", Fade_With_Original);
			CFEDGDGBCHE().SetColor("_Parameter", Back_Color);
			OIMMPLPBLBK().SetTexture("In Main Menu", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IMCKJCHKMKB()
	{
		FPHEBLMINDA = Resources.Load("_Value4") as Texture2D;
		SCShader = Shader.Find("_BlurTexture");
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
		SCShader = Shader.Find("_TexelOffsetScale");
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
			PDEAHJPOMEF().SetFloat("_HSV", HBJJOCHGOPH);
			IONHGBPGCHK().SetColor("0.00", Pencil_Color);
			IONHGBPGCHK().SetFloat("_TimeX", Pencil_Size);
			NBPKMLMCHFN.SetFloat("OpJoinLobby()", Pencil_Correction);
			NBPKMLMCHFN.SetFloat("_Value2", Intensity);
			OIMMPLPBLBK().SetFloat("SelectionBox component is on a gameObject with a Canvas Scaler component. As of now, Canvas Scalers without the default settings throw off the coordinates of the selection box. Canvas Scaler has been removed.", Speed_Animation);
			OIMMPLPBLBK().SetFloat("#ok", Corner_Lose);
			OIMMPLPBLBK().SetFloat("Maps Editor v.", Fade_Paper_to_BackColor);
			HEHKGPKLAKK().SetFloat("[Steamworks.NET] DllCheck Test returned false, One or more of the Steamworks binaries seems to be the wrong version.", Fade_With_Original);
			HEHKGPKLAKK().SetColor(". We have no such PhotonView! Ignored this if you're leaving a room. State: ", Back_Color);
			IONHGBPGCHK().SetTexture("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
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
		SCShader = Shader.Find("_Curve");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PKLOBJHKFEO()
	{
		FPHEBLMINDA = Resources.Load("_SmoothStart") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/TV_BrokenGlass");
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
		FPHEBLMINDA = Resources.Load("id") as Texture2D;
		SCShader = Shader.Find("_TimeX");
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
			MMOODGIODPC().SetFloat("\n", HBJJOCHGOPH);
			HNICHJCGJOC().SetColor("_DistortionLevel", Pencil_Color);
			PDEAHJPOMEF().SetFloat("Start", Pencil_Size);
			HEHKGPKLAKK().SetFloat("Prints list of commands", Pencil_Correction);
			MFHPKGICPIO().SetFloat("You must complete your map before submiting it to Workshop", Intensity);
			CFEDGDGBCHE().SetFloat("Right", Speed_Animation);
			HNICHJCGJOC().SetFloat("_FarCamera", Corner_Lose);
			MMOODGIODPC().SetFloat("' got destroyed by engine. This is OK when loading levels. Otherwise use: PhotonNetwork.Destroy().", Fade_Paper_to_BackColor);
			CFEDGDGBCHE().SetFloat("player.blackwhite", Fade_With_Original);
			NBPKMLMCHFN.SetColor("Destroying GO as global. ID: ", Back_Color);
			MMOODGIODPC().SetTexture("_ScreenResolution", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
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
		FPHEBLMINDA = Resources.Load("UI Extensions/SoftMaskShaderText") as Texture2D;
		SCShader = Shader.Find("^");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BMOFEBKGLFI()
	{
		FPHEBLMINDA = Resources.Load("#") as Texture2D;
		SCShader = Shader.Find("plogs");
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
			MFHPKGICPIO().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			HNICHJCGJOC().SetColor("quit", Pencil_Color);
			IONHGBPGCHK().SetFloat("_ColorLevel", Pencil_Size);
			PDEAHJPOMEF().SetFloat("_Value", Pencil_Correction);
			GCDFNHMJMIP().SetFloat("_FadeFX", Intensity);
			OIMMPLPBLBK().SetFloat("14", Speed_Animation);
			MFHPKGICPIO().SetFloat("[", Corner_Lose);
			HNICHJCGJOC().SetFloat("Tab1Content", Fade_Paper_to_BackColor);
			CFEDGDGBCHE().SetFloat("-1", Fade_With_Original);
			HNICHJCGJOC().SetColor(".lastCheckpoint.penaltyScore", Back_Color);
			MFHPKGICPIO().SetTexture("File not found: {0}", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
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
			PDEAHJPOMEF().SetFloat("_Value2", HBJJOCHGOPH);
			HEHKGPKLAKK().SetColor("skins", Pencil_Color);
			GCDFNHMJMIP().SetFloat("(\\[ */ *h1 *\\])", Pencil_Size);
			IONHGBPGCHK().SetFloat(".lastCheckpoint.isMapCompleted", Pencil_Correction);
			CFEDGDGBCHE().SetFloat("_MatrixSpeed", Intensity);
			NBPKMLMCHFN.SetFloat("_Value2", Speed_Animation);
			HEHKGPKLAKK().SetFloat("FinalScoreText", Corner_Lose);
			MMOODGIODPC().SetFloat("icon.png", Fade_Paper_to_BackColor);
			CFEDGDGBCHE().SetFloat("--------------------------------", Fade_With_Original);
			HEHKGPKLAKK().SetColor("[Left]", Back_Color);
			HEHKGPKLAKK().SetTexture("_Blur", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FBPHNEJBDJN()
	{
		FPHEBLMINDA = Resources.Load("_Fade") as Texture2D;
		SCShader = Shader.Find("[LocalizationService] All keys for ");
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
			MFHPKGICPIO().SetFloat("/", HBJJOCHGOPH);
			HEHKGPKLAKK().SetColor("settings.selectormapsperpage", Pencil_Color);
			MFHPKGICPIO().SetFloat("_Value6", Pencil_Size);
			HNICHJCGJOC().SetFloat("Created", Pencil_Correction);
			CFEDGDGBCHE().SetFloat("Error0", Intensity);
			OIMMPLPBLBK().SetFloat("received</b>\n#reason: ", Speed_Animation);
			NBPKMLMCHFN.SetFloat("editor.", Corner_Lose);
			MFHPKGICPIO().SetFloat("_Saturation", Fade_Paper_to_BackColor);
			MMOODGIODPC().SetFloat("UI Extensions/UIMultiply", Fade_With_Original);
			GCDFNHMJMIP().SetColor(".lastCheckpoint.comboScore", Back_Color);
			IONHGBPGCHK().SetTexture("_EmissionGain", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK());
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
		FPHEBLMINDA = Resources.Load("BadgeText") as Texture2D;
		SCShader = Shader.Find("outputitemdefid");
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
			NBPKMLMCHFN.SetFloat("Down", HBJJOCHGOPH);
			NBPKMLMCHFN.SetColor("/icon", Pencil_Color);
			HEHKGPKLAKK().SetFloat("OnStatusChanged: {0} current State: {1}", Pencil_Size);
			IONHGBPGCHK().SetFloat(" not exist", Pencil_Correction);
			HEHKGPKLAKK().SetFloat("MapFolderInputField", Intensity);
			OIMMPLPBLBK().SetFloat("#,0.00", Speed_Animation);
			MMOODGIODPC().SetFloat("Chat", Corner_Lose);
			GCDFNHMJMIP().SetFloat("FrostCanvas", Fade_Paper_to_BackColor);
			PDEAHJPOMEF().SetFloat("LivesSlider", Fade_With_Original);
			PDEAHJPOMEF().SetColor("ConnectToMaster() failed. Can only connect while in state 'Disconnected'. Current state: ", Back_Color);
			IONHGBPGCHK().SetTexture("/icon", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ANCKKLFPGDI()
	{
		FPHEBLMINDA = Resources.Load("_Value2") as Texture2D;
		SCShader = Shader.Find("[MapsData] Caching ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PAKPHKPDKGE()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack/Gradients_Therma") as Texture2D;
		SCShader = Shader.Find("workshop.");
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
			PDEAHJPOMEF().SetFloat("UseScanLineSize", HBJJOCHGOPH);
			HEHKGPKLAKK().SetColor(". The group number should be at least 1.", Pencil_Color);
			NBPKMLMCHFN.SetFloat("_CurveTex", Pencil_Size);
			CFEDGDGBCHE().SetFloat("_ScreenResolution", Pencil_Correction);
			MFHPKGICPIO().SetFloat("Need to specify a start index and end index.", Intensity);
			OIMMPLPBLBK().SetFloat("_Amount", Speed_Animation);
			OIMMPLPBLBK().SetFloat("[LocalizationService] All keys for ", Corner_Lose);
			NBPKMLMCHFN.SetFloat("_Near", Fade_Paper_to_BackColor);
			HNICHJCGJOC().SetFloat("Drop_With_Obj", Fade_With_Original);
			MMOODGIODPC().SetColor("_Value3", Back_Color);
			IONHGBPGCHK().SetTexture("mapselector.tags.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
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
			GCDFNHMJMIP().SetFloat("[SERVER] Kicked ", HBJJOCHGOPH);
			CFEDGDGBCHE().SetColor("_Quality", Pencil_Color);
			HNICHJCGJOC().SetFloat("maps.", Pencil_Size);
			HEHKGPKLAKK().SetFloat("_SSAO", Pencil_Correction);
			MMOODGIODPC().SetFloat("/icon", Intensity);
			NBPKMLMCHFN.SetFloat("_SoftZDistance", Speed_Animation);
			MFHPKGICPIO().SetFloat("#tryagain", Corner_Lose);
			OIMMPLPBLBK().SetFloat("_Fade", Fade_Paper_to_BackColor);
			MMOODGIODPC().SetFloat("_TargetScale", Fade_With_Original);
			PDEAHJPOMEF().SetColor(" not exist", Back_Color);
			OIMMPLPBLBK().SetTexture("NewMapHandsCountSlider", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
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
			PDEAHJPOMEF().SetFloat("_ReflectionBlur", HBJJOCHGOPH);
			MFHPKGICPIO().SetColor("curScn", Pencil_Color);
			OIMMPLPBLBK().SetFloat("HandleEventLeave for player ID: ", Pencil_Size);
			MFHPKGICPIO().SetFloat("UI Extensions/UIMultiply", Pencil_Correction);
			HNICHJCGJOC().SetFloat("Editor", Intensity);
			MMOODGIODPC().SetFloat("cancel", Speed_Animation);
			GCDFNHMJMIP().SetFloat("Gameplay/sun", Corner_Lose);
			IONHGBPGCHK().SetFloat("0", Fade_Paper_to_BackColor);
			PDEAHJPOMEF().SetFloat("settings_bindings_controller_type", Fade_With_Original);
			CFEDGDGBCHE().SetColor(".", Back_Color);
			MMOODGIODPC().SetTexture("Fill Area", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			NBPKMLMCHFN.SetFloat("[DiscordController] Disconnect {0}: {1}", HBJJOCHGOPH);
			PDEAHJPOMEF().SetColor("shader.crispwinter", Pencil_Color);
			HNICHJCGJOC().SetFloat("CameraFilterPack/Blend2Camera_Saturation", Pencil_Size);
			PDEAHJPOMEF().SetFloat("EnvironmentSlider", Pencil_Correction);
			HNICHJCGJOC().SetFloat("tintColor", Intensity);
			CFEDGDGBCHE().SetFloat("Drop_With_Obj", Speed_Animation);
			MMOODGIODPC().SetFloat("float,0", Corner_Lose);
			GCDFNHMJMIP().SetFloat("note.1", Fade_Paper_to_BackColor);
			HNICHJCGJOC().SetFloat("SpawnObj", Fade_With_Original);
			PDEAHJPOMEF().SetColor("[FileSelector] Dialog ended, result: ", Back_Color);
			NBPKMLMCHFN.SetTexture("maps.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK());
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
