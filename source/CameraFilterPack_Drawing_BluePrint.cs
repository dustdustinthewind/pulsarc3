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
		FPHEBLMINDA = Resources.Load("_ClutTex") as Texture2D;
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
		FPHEBLMINDA = Resources.Load("CameraFilterPack/Color_Sepia") as Texture2D;
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
			PLBEJJIHFPB().SetFloat("_Value2", HBJJOCHGOPH);
			AELJLBOJAIL().SetColor(" or player:", Pencil_Color);
			AELJLBOJAIL().SetFloat("_Value5", Pencil_Size);
			BFGNMFCNDBC().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", Pencil_Correction);
			PLBEJJIHFPB().SetFloat("[PlayerController] ", Intensity);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Atmosphere_Snow_8bits", Speed_Animation);
			NLFJGMBCICG().SetFloat("settings.crosshairopacity", Corner_Lose);
			CFEDGDGBCHE().SetFloat("CameraFilterPack/Blend2Camera_Subtract", Fade_Paper_to_BackColor);
			BFGNMFCNDBC().SetFloat("SetParticlesGravity", Fade_With_Original);
			NLFJGMBCICG().SetColor("CameraFilterPack/Blur_Dithering2x2", Back_Color);
			EMDFHOKEGNG().SetTexture(",", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
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
		FPHEBLMINDA = Resources.Load(".sawoutdatedmessage") as Texture2D;
		SCShader = Shader.Find("Submit");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FLKEJJEGCFA()
	{
		FPHEBLMINDA = Resources.Load("player.currentrank") as Texture2D;
		SCShader = Shader.Find("_EmissionColor");
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
			NBMPPNFKFLB().SetFloat("/", HBJJOCHGOPH);
			GKILCDHJFEG().SetColor("InventoryButton", Pencil_Color);
			EMDFHOKEGNG().SetFloat("ShineEffect", Pencil_Size);
			PLBEJJIHFPB().SetFloat("AddEnvironmentSprite", Pencil_Correction);
			EJDPNJAEAKJ().SetFloat("_TimeX", Intensity);
			IONHGBPGCHK().SetFloat("_TimeX", Speed_Animation);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/TV_Posterize", Corner_Lose);
			EMDFHOKEGNG().SetFloat("fade in duration", Fade_Paper_to_BackColor);
			MMOODGIODPC().SetFloat("_TimeX", Fade_With_Original);
			CFCPHFMKHII().SetColor("Testing, the group has toggled [", Back_Color);
			NBPKMLMCHFN.SetTexture("f", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
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
			CFEDGDGBCHE().SetFloat("_Parameter", HBJJOCHGOPH);
			IONHGBPGCHK().SetColor("ReJoinRoom failed due to offline mode.", Pencil_Color);
			EJDPNJAEAKJ().SetFloat("wss://", Pencil_Size);
			BFGNMFCNDBC().SetFloat("PublishButton", Pencil_Correction);
			GKILCDHJFEG().SetFloat("Found best region: '", Intensity);
			AELJLBOJAIL().SetFloat("caret", Speed_Animation);
			AELJLBOJAIL().SetFloat("B", Corner_Lose);
			BFGNMFCNDBC().SetFloat("ShadersToggle", Fade_Paper_to_BackColor);
			IONHGBPGCHK().SetFloat("_LightIntensity", Fade_With_Original);
			BFGNMFCNDBC().SetColor("_TimeX", Back_Color);
			BFGNMFCNDBC().SetTexture("_Value12", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
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
			EJDPNJAEAKJ().SetFloat("_Value2", HBJJOCHGOPH);
			CFEDGDGBCHE().SetColor(",", Pencil_Color);
			NBMPPNFKFLB().SetFloat(" not exist", Pencil_Size);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", Pencil_Correction);
			CIAFLBFJLEJ().SetFloat("_Size", Intensity);
			PGPEMMBJOOG().SetFloat("MapEditorScene", Speed_Animation);
			DKNJGHFLAIF().SetFloat("Add Environment Object", Corner_Lose);
			NBPKMLMCHFN.SetFloat("powerup.0", Fade_Paper_to_BackColor);
			CFEDGDGBCHE().SetFloat("OxOD.lastPath", Fade_With_Original);
			NBPKMLMCHFN.SetColor("Items/", Back_Color);
			PGPEMMBJOOG().SetTexture("_Color2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
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
		FPHEBLMINDA = Resources.Load("_color") as Texture2D;
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
		FPHEBLMINDA = Resources.Load("?") as Texture2D;
		SCShader = Shader.Find("_ScreenResolution");
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
			MMOODGIODPC().SetFloat("Moved event", HBJJOCHGOPH);
			DKNJGHFLAIF().SetColor(" ownership transfered to: ", Pencil_Color);
			CIAFLBFJLEJ().SetFloat("plogs", Pencil_Size);
			DBOLLHHMKKN().SetFloat("settings.arcshitsoundtimedelay", Pencil_Correction);
			BFGNMFCNDBC().SetFloat("menu.tabid", Intensity);
			NBMPPNFKFLB().SetFloat("CameraFilterPack/Blend2Camera_SoftLight", Speed_Animation);
			NLFJGMBCICG().SetFloat("[DiscordController] Join request {0}#{1}: {2}", Corner_Lose);
			DBOLLHHMKKN().SetFloat("mapselector.tags.", Fade_Paper_to_BackColor);
			MMOODGIODPC().SetFloat(".lastCheckpoint.penaltyScore", Fade_With_Original);
			DKNJGHFLAIF().SetColor("Custom Authentication failed (either due to user-input or configuration or AuthParameter string format). Calling: OnCustomAuthenticationFailed()", Back_Color);
			BFGNMFCNDBC().SetTexture("OK", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
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
		FPHEBLMINDA = Resources.Load("_ScreenResolution") as Texture2D;
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HJPCJGOEKMF()
	{
		FPHEBLMINDA = Resources.Load("[Right-Left]") as Texture2D;
		SCShader = Shader.Find("Data/Editor/leveltemplate");
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
			CIAFLBFJLEJ().SetFloat("_Near", HBJJOCHGOPH);
			PLBEJJIHFPB().SetColor("settings.arcsdestroydelay", Pencil_Color);
			MMOODGIODPC().SetFloat("menutheme.jamaicanorcdub", Pencil_Size);
			NBPKMLMCHFN.SetFloat("_FarCamera", Pencil_Correction);
			GKILCDHJFEG().SetFloat("caret", Intensity);
			CFCPHFMKHII().SetFloat("DeleteButton", Speed_Animation);
			PGPEMMBJOOG().SetFloat("Out {0,4} | In {1,4} | Sum {2,4}", Corner_Lose);
			DBOLLHHMKKN().SetFloat("Back", Fade_Paper_to_BackColor);
			EMDFHOKEGNG().SetFloat("_SmoothEnd", Fade_With_Original);
			NBPKMLMCHFN.SetColor("Tab1Content", Back_Color);
			NBMPPNFKFLB().SetTexture(": ", FPHEBLMINDA);
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
			NBMPPNFKFLB().SetFloat("[MenuScene] Error: ", HBJJOCHGOPH);
			AELJLBOJAIL().SetColor("_TimeX", Pencil_Color);
			CIAFLBFJLEJ().SetFloat("_Value2", Pencil_Size);
			EJDPNJAEAKJ().SetFloat("CameraFilterPack/Atmosphere_Rain", Pencil_Correction);
			BFGNMFCNDBC().SetFloat("float,0", Intensity);
			NBMPPNFKFLB().SetFloat("OpLeaveLobby()", Speed_Animation);
			CFCPHFMKHII().SetFloat("cipherText", Corner_Lose);
			PGPEMMBJOOG().SetFloat("_Value3", Fade_Paper_to_BackColor);
			CFEDGDGBCHE().SetFloat(". Set PhotonNetwork.OnEventCall.", Fade_With_Original);
			CFEDGDGBCHE().SetColor("/../", Back_Color);
			CIAFLBFJLEJ().SetTexture("_Val3", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
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
			DKNJGHFLAIF().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			NBPKMLMCHFN.SetColor(".g", Pencil_Color);
			EJDPNJAEAKJ().SetFloat("ControllerLeftX", Pencil_Size);
			AELJLBOJAIL().SetFloat("return ", Pencil_Correction);
			NLFJGMBCICG().SetFloat("_ScreenResolution", Intensity);
			MMOODGIODPC().SetFloat("CameraFilterPack/Color_Switching", Speed_Animation);
			CIAFLBFJLEJ().SetFloat("_FixDistance", Corner_Lose);
			BFGNMFCNDBC().SetFloat("_BorderSize", Fade_Paper_to_BackColor);
			DKNJGHFLAIF().SetFloat("_ScreenResolution", Fade_With_Original);
			GKILCDHJFEG().SetColor("Mouse0", Back_Color);
			MMOODGIODPC().SetTexture("ShowSprite", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
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
		FPHEBLMINDA = Resources.Load("workshop.") as Texture2D;
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
			BFGNMFCNDBC().SetFloat("-help", HBJJOCHGOPH);
			NBMPPNFKFLB().SetColor("_Value7", Pencil_Color);
			PLBEJJIHFPB().SetFloat(" ", Pencil_Size);
			EMDFHOKEGNG().SetFloat("MenuScene", Pencil_Correction);
			EMDFHOKEGNG().SetFloat("_FixDistance", Intensity);
			DBOLLHHMKKN().SetFloat("X", Speed_Animation);
			CFEDGDGBCHE().SetFloat("t", Corner_Lose);
			NBMPPNFKFLB().SetFloat("ConnectToMaster() disabled the offline mode. No longer offline.", Fade_Paper_to_BackColor);
			PLBEJJIHFPB().SetFloat("Color's hex value #RRGGBBAA", Fade_With_Original);
			DKNJGHFLAIF().SetColor("_Visualize", Back_Color);
			NLFJGMBCICG().SetTexture("_Value", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CCLNNLCOPBL()
	{
		FPHEBLMINDA = Resources.Load("id") as Texture2D;
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
			DKNJGHFLAIF().SetFloat("CameraFilterPack/TV_WideScreenHorizontal", HBJJOCHGOPH);
			NLFJGMBCICG().SetColor("settings.gamemessagesduration", Pencil_Color);
			EJDPNJAEAKJ().SetFloat(" GameServer:", Pencil_Size);
			GKILCDHJFEG().SetFloat("inventory.selected.", Pencil_Correction);
			NBPKMLMCHFN.SetFloat("Object ID. Case-Sensitive", Intensity);
			PLBEJJIHFPB().SetFloat("ReJoinRoom failed due to offline mode.", Speed_Animation);
			PGPEMMBJOOG().SetFloat("bloomintencity:", Corner_Lose);
			IONHGBPGCHK().SetFloat("_TimeX", Fade_Paper_to_BackColor);
			CFCPHFMKHII().SetFloat("_RotationMatrix", Fade_With_Original);
			CFEDGDGBCHE().SetColor("time", Back_Color);
			CFCPHFMKHII().SetTexture("\t", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
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
			DKNJGHFLAIF().SetFloat("[PlayerController] ", HBJJOCHGOPH);
			CFEDGDGBCHE().SetColor("Only the Master Client can AllocateSceneViewID(). Check PhotonNetwork.isMasterClient!", Pencil_Color);
			IONHGBPGCHK().SetFloat("float", Pencil_Size);
			CIAFLBFJLEJ().SetFloat("time: ", Pencil_Correction);
			EJDPNJAEAKJ().SetFloat("_Size", Intensity);
			DKNJGHFLAIF().SetFloat("_TimeX", Speed_Animation);
			NBMPPNFKFLB().SetFloat("{0}", Corner_Lose);
			GKILCDHJFEG().SetFloat("hidden", Fade_Paper_to_BackColor);
			BFGNMFCNDBC().SetFloat("_Offsets", Fade_With_Original);
			PLBEJJIHFPB().SetColor(" cannot be used as a 3D LUT.", Back_Color);
			CFEDGDGBCHE().SetTexture("editor.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
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
			CFCPHFMKHII().SetFloat("turn", HBJJOCHGOPH);
			BFGNMFCNDBC().SetColor("settings.shaders", Pencil_Color);
			CFEDGDGBCHE().SetFloat("Closes the app", Pencil_Size);
			NBMPPNFKFLB().SetFloat("_ScreenResolution", Pencil_Correction);
			CIAFLBFJLEJ().SetFloat("Texture2", Intensity);
			DBOLLHHMKKN().SetFloat("_ScreenResolution", Speed_Animation);
			EMDFHOKEGNG().SetFloat("_Value5", Corner_Lose);
			BFGNMFCNDBC().SetFloat("SupportLogger OnFailedToConnectToPhoton(", Fade_Paper_to_BackColor);
			NBMPPNFKFLB().SetFloat("LevelURLInputField", Fade_With_Original);
			NBPKMLMCHFN.SetColor("_Threshhold", Back_Color);
			NBPKMLMCHFN.SetTexture("Bad parameters for setbool! Use <key> <value>", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFCPHFMKHII());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FBPHNEJBDJN()
	{
		FPHEBLMINDA = Resources.Load("ItemNameText") as Texture2D;
		SCShader = Shader.Find("_Value4");
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
			GKILCDHJFEG().SetFloat("on master", HBJJOCHGOPH);
			CIAFLBFJLEJ().SetColor("skin.hit_wrong", Pencil_Color);
			CFCPHFMKHII().SetFloat("steamid", Pencil_Size);
			EMDFHOKEGNG().SetFloat("[MapsData] Installed: ", Pencil_Correction);
			NBMPPNFKFLB().SetFloat("_MainTex2", Intensity);
			PGPEMMBJOOG().SetFloat("maps.", Speed_Animation);
			CFEDGDGBCHE().SetFloat("_DotSize", Corner_Lose);
			MMOODGIODPC().SetFloat("hidden", Fade_Paper_to_BackColor);
			IONHGBPGCHK().SetFloat("_TimeX", Fade_With_Original);
			GKILCDHJFEG().SetColor("Right", Back_Color);
			NBPKMLMCHFN.SetTexture(" - ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
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
			DBOLLHHMKKN().SetFloat("Crosshair", HBJJOCHGOPH);
			GKILCDHJFEG().SetColor(">", Pencil_Color);
			GKILCDHJFEG().SetFloat("_Value2", Pencil_Size);
			DKNJGHFLAIF().SetFloat("_ScreenResolution", Pencil_Correction);
			EMDFHOKEGNG().SetFloat("ItemsCountText", Intensity);
			CIAFLBFJLEJ().SetFloat("UseFinalGlassColor", Speed_Animation);
			AELJLBOJAIL().SetFloat("_FarCamera", Corner_Lose);
			NLFJGMBCICG().SetFloat("[PlayerBase] Invoke event ", Fade_Paper_to_BackColor);
			GKILCDHJFEG().SetFloat("menu.selectedplaymode", Fade_With_Original);
			DBOLLHHMKKN().SetColor("EnvironmentSlider", Back_Color);
			BFGNMFCNDBC().SetTexture("EXCEPTION:", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
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
		FPHEBLMINDA = Resources.Load("_Distortion") as Texture2D;
		SCShader = Shader.Find("workshop.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KIMMMCJFMAB()
	{
		FPHEBLMINDA = Resources.Load("Day_") as Texture2D;
		SCShader = Shader.Find("score");
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
		SCShader = Shader.Find("_FadeFX");
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
			EJDPNJAEAKJ().SetFloat("player.goldlollipop", HBJJOCHGOPH);
			MMOODGIODPC().SetColor("hidden", Pencil_Color);
			BFGNMFCNDBC().SetFloat("_MainTex2", Pencil_Size);
			IONHGBPGCHK().SetFloat(".", Pencil_Correction);
			IONHGBPGCHK().SetFloat("GlassAberration", Intensity);
			NBMPPNFKFLB().SetFloat("GameScene", Speed_Animation);
			CFEDGDGBCHE().SetFloat("_Value4", Corner_Lose);
			BFGNMFCNDBC().SetFloat("_PColor", Fade_Paper_to_BackColor);
			AELJLBOJAIL().SetFloat("[PlayerBase] Checkpoint error: ", Fade_With_Original);
			IONHGBPGCHK().SetColor("_MainTex2", Back_Color);
			NBMPPNFKFLB().SetTexture(".lastCheckpoint.penaltyScore", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFCPHFMKHII());
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
		FPHEBLMINDA = Resources.Load("EditMenu") as Texture2D;
		SCShader = Shader.Find("Already exist!");
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
		SCShader = Shader.Find("CameraFilterPack/TV_MovieNoise");
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
			BFGNMFCNDBC().SetFloat("settings.arcsdestroydelay", HBJJOCHGOPH);
			DBOLLHHMKKN().SetColor("music", Pencil_Color);
			NBPKMLMCHFN.SetFloat(".g", Pencil_Size);
			AELJLBOJAIL().SetFloat("JoinOrCreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", Pencil_Correction);
			CIAFLBFJLEJ().SetFloat("_ScreenResolution", Intensity);
			EMDFHOKEGNG().SetFloat("SelectorMapsCountSlider", Speed_Animation);
			NBMPPNFKFLB().SetFloat("In Main Menu", Corner_Lose);
			DKNJGHFLAIF().SetFloat("maps.", Fade_Paper_to_BackColor);
			MMOODGIODPC().SetFloat("LB", Fade_With_Original);
			EJDPNJAEAKJ().SetColor("EventData0DropDownList", Back_Color);
			NBPKMLMCHFN.SetTexture("_ScreenResolution", FPHEBLMINDA);
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
		FPHEBLMINDA = Resources.Load("GlassColor") as Texture2D;
		SCShader = Shader.Find("settings.volume.game");
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
