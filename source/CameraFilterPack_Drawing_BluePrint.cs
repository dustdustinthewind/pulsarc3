// CameraFilterPack_Drawing_BluePrint
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Drawing/BluePrint")]
[ExecuteInEditMode]
public class CameraFilterPack_Drawing_BluePrint : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	public Color Pencil_Color = new Color(1f, 1f, 1f, 1f);

	[Range(0.0001f, 0.0022f)]
	public float Pencil_Size = 0.0008f;

	[Range(0f, 2f)]
	public float Pencil_Correction = 0.76f;

	[Range(0f, 1f)]
	public float Intensity = 1f;

	[Range(0f, 2f)]
	public float Speed_Animation = 1f;

	[Range(0f, 1f)]
	public float Corner_Lose = 0.5f;

	[Range(0f, 1f)]
	public float Fade_Paper_to_BackColor = 0.2f;

	[Range(0f, 1f)]
	public float Fade_With_Original = 1f;

	public Color Back_Color = new Color(0.175f, 0.402f, 0.687f, 1f);

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

	private void OPCLBGHAPMG()
	{
	}

	private void NNPBKKBFDHH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Update()
	{
	}

	private void KCDOMIJBFLL()
	{
	}

	[SpecialName]
	private Material EJDPNJAEAKJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)115;
		}
		return BJFKDHHMLJH;
	}

	private void KFEKCJDEECK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DAHFFNNIGML()
	{
		FPHEBLMINDA = Resources.Load("offsets") as Texture2D;
		SCShader = Shader.Find("BitsData");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material PLBEJJIHFPB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return BJFKDHHMLJH;
	}

	private void KOJKBFDNGDK()
	{
		FPHEBLMINDA = Resources.Load("_Offsets") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/FX_Spot");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material EMDFHOKEGNG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void KDMANOEMOCA()
	{
		FPHEBLMINDA = Resources.Load("_TimeX") as Texture2D;
		SCShader = Shader.Find("BitsData");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CMIBEOJGAIL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1522f)
			{
				HBJJOCHGOPH = 1581f;
			}
			NBPKMLMCHFN.SetFloat("_Value3", HBJJOCHGOPH);
			EJDPNJAEAKJ().SetColor("Unsupported target enum: ", Pencil_Color);
			NLFJGMBCICG().SetFloat("_Value5", Pencil_Size);
			AELJLBOJAIL().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", Pencil_Correction);
			EMDFHOKEGNG().SetFloat(": ", Intensity);
			BFGNMFCNDBC().SetFloat("CameraFilterPack/Atmosphere_Snow_8bits", Speed_Animation);
			NLFJGMBCICG().SetFloat("Crosshair2", Corner_Lose);
			DKNJGHFLAIF().SetFloat("CameraFilterPack/Blend2Camera_Subtract", Fade_Paper_to_BackColor);
			NBMPPNFKFLB().SetFloat("Set Particles Gravity", Fade_With_Original);
			CIAFLBFJLEJ().SetColor("CameraFilterPack/Blur_Dithering2x2", Back_Color);
			AELJLBOJAIL().SetTexture("CountEventsGoal", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HIKKPDACJGI()
	{
	}

	private void NPLCENPNJBM()
	{
		FPHEBLMINDA = Resources.Load("Editor") as Texture2D;
		SCShader = Shader.Find("StandAloneInputSystem should not be used with the GamePadInputModule, please remove it from the Event System in this scene or disable it when this module is in use");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FLKEJJEGCFA()
	{
		FPHEBLMINDA = Resources.Load("settings.enablerankingnotifications") as Texture2D;
		SCShader = Shader.Find("checkpoint");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PLIKADJCEPO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LCHBFNIPBHB()
	{
	}

	[SpecialName]
	private Material CIAFLBFJLEJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)122;
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

	private void DFENCIHAADO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 761f)
			{
				HBJJOCHGOPH = 807f;
			}
			PLBEJJIHFPB().SetFloat("[MapsData] Caching ", HBJJOCHGOPH);
			MMOODGIODPC().SetColor("InventoryButton", Pencil_Color);
			IONHGBPGCHK().SetFloat("ShineEffect", Pencil_Size);
			AELJLBOJAIL().SetFloat("[PlayerController] ", Pencil_Correction);
			AELJLBOJAIL().SetFloat("_Value", Intensity);
			DBOLLHHMKKN().SetFloat("_Distortion", Speed_Animation);
			CIAFLBFJLEJ().SetFloat("_TimeX", Corner_Lose);
			AELJLBOJAIL().SetFloat("fade in duration", Fade_Paper_to_BackColor);
			PLBEJJIHFPB().SetFloat("_Value", Fade_With_Original);
			PLBEJJIHFPB().SetColor("Testing, a toggle has toggled [", Back_Color);
			EMDFHOKEGNG().SetTexture("false", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JNGMIAFLBDL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PNLKFANNOKO()
	{
	}

	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 192f)
			{
				HBJJOCHGOPH = 1957f;
			}
			GKILCDHJFEG().SetFloat("_Parameter", HBJJOCHGOPH);
			NBMPPNFKFLB().SetColor("ReJoinRoom failed. A roomname is required. If you don't know one, how will you join?", Pencil_Color);
			DKNJGHFLAIF().SetFloat("Avoid using this directly. Thanks.", Pencil_Size);
			CFEDGDGBCHE().SetFloat("resource", Pencil_Correction);
			NLFJGMBCICG().SetFloat(". Calling ConnectToRegionMaster() is: ", Intensity);
			CFEDGDGBCHE().SetFloat("Added checkpoint", Speed_Animation);
			CIAFLBFJLEJ().SetFloat("Y", Corner_Lose);
			DKNJGHFLAIF().SetFloat("FPSToggle", Fade_Paper_to_BackColor);
			NBMPPNFKFLB().SetFloat("_LightIntensity", Fade_With_Original);
			EMDFHOKEGNG().SetColor("_DotSize", Back_Color);
			NBMPPNFKFLB().SetTexture("_Value12", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IHHNCCOGLPN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LLJLDLLNFBH()
	{
	}

	private void GBGAMCPNBCC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1490f)
			{
				HBJJOCHGOPH = 1459f;
			}
			EJDPNJAEAKJ().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			BFGNMFCNDBC().SetColor("CountEventsGoal", Pencil_Color);
			PLBEJJIHFPB().SetFloat("[PlayerController] ", Pencil_Size);
			BFGNMFCNDBC().SetFloat("CameraFilterPack/Light_Water2", Pencil_Correction);
			CFCPHFMKHII().SetFloat("_Smooth", Intensity);
			MMOODGIODPC().SetFloat("ItemsUploader", Speed_Animation);
			AELJLBOJAIL().SetFloat("type", Corner_Lose);
			DKNJGHFLAIF().SetFloat("settings.enablehitsoundsinnormal", Fade_Paper_to_BackColor);
			NBMPPNFKFLB().SetFloat("OxOD.lastPath", Fade_With_Original);
			CFCPHFMKHII().SetColor("AudioSampler", Back_Color);
			DKNJGHFLAIF().SetTexture("_Color2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material CFCPHFMKHII()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-123);
		}
		return BJFKDHHMLJH;
	}

	private void EGEGNHLODAA()
	{
	}

	private void MGMAOBPPOBJ()
	{
		FPHEBLMINDA = Resources.Load("_ScreenResolution") as Texture2D;
		SCShader = Shader.Find("id");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material PGPEMMBJOOG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)74;
		}
		return BJFKDHHMLJH;
	}

	private void EGEPLFGKGLI()
	{
		FPHEBLMINDA = Resources.Load("SubmitUserVote:") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/NightVisionFX");
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

	[SpecialName]
	private Material GKILCDHJFEG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1047f)
			{
				HBJJOCHGOPH = 1025f;
			}
			DKNJGHFLAIF().SetFloat("_EmissionGain", HBJJOCHGOPH);
			NBMPPNFKFLB().SetColor(" to: ", Pencil_Color);
			NBPKMLMCHFN.SetFloat("Clears the console and prints the logs in the specified range", Pencil_Size);
			NLFJGMBCICG().SetFloat("[PlayerBase] Loaded spawner data", Pencil_Correction);
			IONHGBPGCHK().SetFloat("menu.tabid", Intensity);
			EMDFHOKEGNG().SetFloat("CameraFilterPack/Blend2Camera_SoftLight", Speed_Animation);
			GKILCDHJFEG().SetFloat("[DiscordController] Shutdown", Corner_Lose);
			IONHGBPGCHK().SetFloat("mapselector.tags.", Fade_Paper_to_BackColor);
			CFEDGDGBCHE().SetFloat(".lastCheckpoint.powerupsScore", Fade_With_Original);
			NBMPPNFKFLB().SetColor("The used master server address is not available with the subscription currently used. Got to Photon Cloud Dashboard or change URL. Disconnecting.", Back_Color);
			EMDFHOKEGNG().SetTexture("#mapmustbecompletebeforesubmit", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EJDPNJAEAKJ());
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

	private void FNCDAPDOBBI()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack/TV_50") as Texture2D;
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HJPCJGOEKMF()
	{
		FPHEBLMINDA = Resources.Load("[Right-Left]") as Texture2D;
		SCShader = Shader.Find("Editor/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1713f)
			{
				HBJJOCHGOPH = 1598f;
			}
			MMOODGIODPC().SetFloat("_Far", HBJJOCHGOPH);
			PLBEJJIHFPB().SetColor("[", Pencil_Color);
			AELJLBOJAIL().SetFloat("menutheme.deleted", Pencil_Size);
			GKILCDHJFEG().SetFloat("_FarCamera", Pencil_Correction);
			BFGNMFCNDBC().SetFloat("Added checkpoint", Intensity);
			EJDPNJAEAKJ().SetFloat("X", Speed_Animation);
			NBMPPNFKFLB().SetFloat("Reset", Corner_Lose);
			IONHGBPGCHK().SetFloat("Start", Fade_Paper_to_BackColor);
			NLFJGMBCICG().SetFloat("CameraFilterPack/Drawing_Halftone", Fade_With_Original);
			IONHGBPGCHK().SetColor("Tab1Content", Back_Color);
			PLBEJJIHFPB().SetTexture("[PlayerController] ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material NLFJGMBCICG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-110);
		}
		return BJFKDHHMLJH;
	}

	private void DPIPGGDNGHN()
	{
	}

	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 212f)
			{
				HBJJOCHGOPH = 1691f;
			}
			DBOLLHHMKKN().SetFloat("In Main Menu", HBJJOCHGOPH);
			MMOODGIODPC().SetColor("_ScreenResolution", Pencil_Color);
			AELJLBOJAIL().SetFloat("_Value2", Pencil_Size);
			EJDPNJAEAKJ().SetFloat("CameraFilterPack/Atmosphere_Rain", Pencil_Correction);
			GKILCDHJFEG().SetFloat("float,0", Intensity);
			EMDFHOKEGNG().SetFloat("OpJoinRoom()", Speed_Animation);
			EJDPNJAEAKJ().SetFloat("Stream did not contain properly formatted byte array", Corner_Lose);
			MMOODGIODPC().SetFloat("_Value4", Fade_Paper_to_BackColor);
			DBOLLHHMKKN().SetFloat("SetupEncryption() got called. ", Fade_With_Original);
			BFGNMFCNDBC().SetColor("/", Back_Color);
			DBOLLHHMKKN().SetTexture("_TimeX", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HNDNDPECBPL()
	{
	}

	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1164f)
			{
				HBJJOCHGOPH = 453f;
			}
			AELJLBOJAIL().SetFloat("CameraFilterPack/Color_Chromatic_Plus", HBJJOCHGOPH);
			MMOODGIODPC().SetColor(".g", Pencil_Color);
			BFGNMFCNDBC().SetFloat("Forward", Pencil_Size);
			EJDPNJAEAKJ().SetFloat("event", Pencil_Correction);
			PGPEMMBJOOG().SetFloat("CameraFilterPack/Colors_Brightness", Intensity);
			MMOODGIODPC().SetFloat("CameraFilterPack/Color_Switching", Speed_Animation);
			NLFJGMBCICG().SetFloat("_FixDistance", Corner_Lose);
			CFEDGDGBCHE().SetFloat("_BorderSize", Fade_Paper_to_BackColor);
			CFCPHFMKHII().SetFloat("_ScreenResolution", Fade_With_Original);
			PGPEMMBJOOG().SetColor("Mouse1", Back_Color);
			BFGNMFCNDBC().SetTexture("Checkpoint", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PAEGLMEOKHP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material NBMPPNFKFLB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void FJIKDJAMOHA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void POJFHDFJOPE()
	{
	}

	private void GAOOPEEBGJA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material MMOODGIODPC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-99);
		}
		return BJFKDHHMLJH;
	}

	private void CCPEDDLAMIB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LDDKCCMHMIC()
	{
	}

	private void BGFJOEPFOPM()
	{
	}

	private void FEHCNJLLJMP()
	{
		FPHEBLMINDA = Resources.Load("/") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Blur_Focus");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1442f)
			{
				HBJJOCHGOPH = 961f;
			}
			NLFJGMBCICG().SetFloat("Emergency Help:", HBJJOCHGOPH);
			NBPKMLMCHFN.SetColor("_Value7", Pencil_Color);
			IONHGBPGCHK().SetFloat("#{0:00} '{1}'{2} {3}", Pencil_Size);
			DBOLLHHMKKN().SetFloat("#exitmapeditor", Pencil_Correction);
			DBOLLHHMKKN().SetFloat("_FixDistance", Intensity);
			GKILCDHJFEG().SetFloat(" ", Speed_Animation);
			CIAFLBFJLEJ().SetFloat("true", Corner_Lose);
			DBOLLHHMKKN().SetFloat("Reconnect() failed. It seems the client wasn't connected before?! Current state: ", Fade_Paper_to_BackColor);
			DKNJGHFLAIF().SetFloat("#FFFFFFFF", Fade_With_Original);
			EMDFHOKEGNG().SetColor("_Visualize", Back_Color);
			EMDFHOKEGNG().SetTexture("_Value2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CCLNNLCOPBL()
	{
		FPHEBLMINDA = Resources.Load("Object ID. Case-Sensitive") as Texture2D;
		SCShader = Shader.Find("PublishButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IIFCIDDJHPM()
	{
	}

	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 416f)
			{
				HBJJOCHGOPH = 1301f;
			}
			NLFJGMBCICG().SetFloat("_TimeX", HBJJOCHGOPH);
			NBMPPNFKFLB().SetColor("#loopnumber ", Pencil_Color);
			DKNJGHFLAIF().SetFloat(" GameServer:", Pencil_Size);
			PLBEJJIHFPB().SetFloat("IconImage", Pencil_Correction);
			MMOODGIODPC().SetFloat("Object ID. Case-Sensitive", Intensity);
			CFCPHFMKHII().SetFloat("PhotonNetwork.room is null. You don't have to call LeaveRoom() when you're not in one. State: ", Speed_Animation);
			NBPKMLMCHFN.SetFloat("cameramovements:", Corner_Lose);
			DBOLLHHMKKN().SetFloat("_TimeX", Fade_Paper_to_BackColor);
			DBOLLHHMKKN().SetFloat("_Angle", Fade_With_Original);
			MMOODGIODPC().SetColor("[CraftingPanel] Init", Back_Color);
			NBMPPNFKFLB().SetTexture("\t", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFCPHFMKHII());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KKEOHFGKCIK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 355f)
			{
				HBJJOCHGOPH = 816f;
			}
			MMOODGIODPC().SetFloat(": ", HBJJOCHGOPH);
			NLFJGMBCICG().SetColor("AllocateViewID() failed. User {0} is out of subIds, as all viewIDs are used.", Pencil_Color);
			EMDFHOKEGNG().SetFloat("maps.", Pencil_Size);
			DKNJGHFLAIF().SetFloat("return ", Pencil_Correction);
			AELJLBOJAIL().SetFloat("_Dist", Intensity);
			PLBEJJIHFPB().SetFloat("_TimeX", Speed_Animation);
			DKNJGHFLAIF().SetFloat("{0}", Corner_Lose);
			GKILCDHJFEG().SetFloat("'{0}' \t{1}ms \t{2}", Fade_Paper_to_BackColor);
			MMOODGIODPC().SetFloat("_TintColor", Fade_With_Original);
			NBMPPNFKFLB().SetColor("_LutTex", Back_Color);
			PLBEJJIHFPB().SetTexture("editor.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1536f)
			{
				HBJJOCHGOPH = 297f;
			}
			CIAFLBFJLEJ().SetFloat("turn", HBJJOCHGOPH);
			AELJLBOJAIL().SetColor("settings.shaders", Pencil_Color);
			NBPKMLMCHFN.SetFloat("Clears the console and prints the logs in the specified range", Pencil_Size);
			PGPEMMBJOOG().SetFloat("CameraFilterPack/Drawing_Manga2", Pencil_Correction);
			CFCPHFMKHII().SetFloat("CameraFilterPack/Real_VHS", Intensity);
			AELJLBOJAIL().SetFloat("help", Speed_Animation);
			NBMPPNFKFLB().SetFloat("_Color2", Corner_Lose);
			NBPKMLMCHFN.SetFloat("SupportLogger OnJoinedLobby(", Fade_Paper_to_BackColor);
			PLBEJJIHFPB().SetFloat("LevelURLInputField", Fade_With_Original);
			AELJLBOJAIL().SetColor("offsets", Back_Color);
			CFCPHFMKHII().SetTexture("getbool", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FBPHNEJBDJN()
	{
		FPHEBLMINDA = Resources.Load(":\n") as Texture2D;
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1496f)
			{
				HBJJOCHGOPH = 488f;
			}
			EJDPNJAEAKJ().SetFloat("OpLeaveLobby()", HBJJOCHGOPH);
			CFCPHFMKHII().SetColor("skin.hit_wrong", Pencil_Color);
			NLFJGMBCICG().SetFloat("mapid", Pencil_Size);
			AELJLBOJAIL().SetFloat("/", Pencil_Correction);
			CIAFLBFJLEJ().SetFloat("_MainTex2", Intensity);
			AELJLBOJAIL().SetFloat("maps.", Speed_Animation);
			NLFJGMBCICG().SetFloat("CameraFilterPack/Drawing_NewCellShading", Corner_Lose);
			EJDPNJAEAKJ().SetFloat("'{0}' \t{1}ms \t{2}", Fade_Paper_to_BackColor);
			AELJLBOJAIL().SetFloat("_TimeX", Fade_With_Original);
			NBPKMLMCHFN.SetColor("Right ", Back_Color);
			CFEDGDGBCHE().SetTexture("[MapsStats] Hash: ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
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
			if (HBJJOCHGOPH > 1703f)
			{
				HBJJOCHGOPH = 195f;
			}
			PGPEMMBJOOG().SetFloat("Crosshair1", HBJJOCHGOPH);
			NBPKMLMCHFN.SetColor("#", Pencil_Color);
			CFCPHFMKHII().SetFloat("_Value3", Pencil_Size);
			AELJLBOJAIL().SetFloat("_ScreenResolution", Pencil_Correction);
			EMDFHOKEGNG().SetFloat("ItemNameText", Intensity);
			AELJLBOJAIL().SetFloat("Fade", Speed_Animation);
			DBOLLHHMKKN().SetFloat("_FarCamera", Corner_Lose);
			PLBEJJIHFPB().SetFloat("[PlayerBase] SetPlayerDistance error: ", Fade_Paper_to_BackColor);
			NLFJGMBCICG().SetFloat("OnReadyClick", Fade_With_Original);
			NLFJGMBCICG().SetColor("HandsCountSlider", Back_Color);
			CFCPHFMKHII().SetTexture("ERROR: Make sure your mod contains at leats one file!", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFCPHFMKHII());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AGMJDGHLBMN()
	{
	}

	private void HPNNCNNFMGK()
	{
	}

	private void JNBPKNNBMDI()
	{
	}

	private void OKLAJINHPAN()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack/FX_Scan") as Texture2D;
		SCShader = Shader.Find("workshop.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KIMMMCJFMAB()
	{
		FPHEBLMINDA = Resources.Load("11") as Texture2D;
		SCShader = Shader.Find("misses");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OFIMMFHFHDD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FDNONDCGGCG()
	{
		FPHEBLMINDA = Resources.Load("Parent ID") as Texture2D;
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 623f)
			{
				HBJJOCHGOPH = 1772f;
			}
			DBOLLHHMKKN().SetFloat("player.goldlollipop", HBJJOCHGOPH);
			AELJLBOJAIL().SetColor("Room: '{0}' {1},{2} {4}/{3} players.\ncustomProps: {5}", Pencil_Color);
			AELJLBOJAIL().SetFloat("_MainTex2", Pencil_Size);
			NLFJGMBCICG().SetFloat("maps.", Pencil_Correction);
			NBMPPNFKFLB().SetFloat("GlassesColor", Intensity);
			PGPEMMBJOOG().SetFloat("GameScene", Speed_Animation);
			CIAFLBFJLEJ().SetFloat("_Value4", Corner_Lose);
			AELJLBOJAIL().SetFloat("_Value1", Fade_Paper_to_BackColor);
			NBPKMLMCHFN.SetFloat("[PlayerBase] SetBGColor error: ", Fade_With_Original);
			NBPKMLMCHFN.SetColor("_MainTex2", Back_Color);
			EJDPNJAEAKJ().SetTexture(".lastCheckpoint.powerupsScore", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)75;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material DKNJGHFLAIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void CIPKEPDELJB()
	{
		FPHEBLMINDA = Resources.Load("EventMenu") as Texture2D;
		SCShader = Shader.Find("OK");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HONBLGFDMLL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JEBIBKLHFLB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OHFOLGANOLC()
	{
		FPHEBLMINDA = Resources.Load("maps.") as Texture2D;
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GNMGIHFKJIJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OFMNDBNFBDJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Start()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_Paper2") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Drawing_BluePrint");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
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
	private Material BFGNMFCNDBC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)76;
		}
		return BJFKDHHMLJH;
	}

	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1068f)
			{
				HBJJOCHGOPH = 404f;
			}
			DKNJGHFLAIF().SetFloat("ArcsNoHitsoundTimeDelaySlider", HBJJOCHGOPH);
			CFEDGDGBCHE().SetColor("/", Pencil_Color);
			CIAFLBFJLEJ().SetFloat(".g", Pencil_Size);
			GKILCDHJFEG().SetFloat("JoinRandomRoom failed. In offline mode you still have to leave a room to enter another.", Pencil_Correction);
			CIAFLBFJLEJ().SetFloat("CameraFilterPack/TV_WideScreenHorizontal", Intensity);
			AELJLBOJAIL().SetFloat("SelectorMapsCountSlider", Speed_Animation);
			PGPEMMBJOOG().SetFloat("In Main Menu", Corner_Lose);
			MMOODGIODPC().SetFloat("maps.", Fade_Paper_to_BackColor);
			CIAFLBFJLEJ().SetFloat("Joystick1Button5", Fade_With_Original);
			EMDFHOKEGNG().SetColor("bpmgrid", Back_Color);
			CIAFLBFJLEJ().SetTexture("_ScreenResolution", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFCPHFMKHII());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EKCDEFDELMP()
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

	[SpecialName]
	private Material AELJLBOJAIL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material DBOLLHHMKKN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void GCHBGCGBMCK()
	{
	}

	private void JHANGPCOCIG()
	{
		FPHEBLMINDA = Resources.Load("UseScanLineSize") as Texture2D;
		SCShader = Shader.Find("settings.volume.editor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IMGGCJICLHK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-106);
		}
		return BJFKDHHMLJH;
	}
}
