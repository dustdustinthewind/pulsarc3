// CameraFilterPack_Colors_RgbClamp
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Colors/RgbClamp")]
[ExecuteInEditMode]
public class CameraFilterPack_Colors_RgbClamp : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 1f)]
	public float Red_Start;

	[Range(0f, 1f)]
	public float Red_End = 1f;

	[Range(0f, 1f)]
	public float Green_Start;

	[Range(0f, 1f)]
	public float Green_End = 1f;

	[Range(0f, 1f)]
	public float Blue_Start;

	[Range(0f, 1f)]
	public float Blue_End = 1f;

	[Range(0f, 1f)]
	public float RGB_Start;

	[Range(0f, 1f)]
	public float RGB_End = 1f;

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

	private void GJCOELHNLJE()
	{
	}

	private void MDCFIHDPLIG()
	{
	}

	private void PKBENONAOOL()
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
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void COMNAPAAPDO()
	{
	}

	private void DFFKKLAPHCC()
	{
		SCShader = Shader.Find("TRACKING");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material HFBJAOFLCJI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-94);
		}
		return BJFKDHHMLJH;
	}

	private void ALNNIDLFILB()
	{
		SCShader = Shader.Find("The given 2D texture ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GJAJBMGGPFB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material DONENAMLFLF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void DFENCIHAADO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JMAIIENCEKE()
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
			BJFKDHHMLJH.hideFlags = (HideFlags)86;
		}
		return BJFKDHHMLJH;
	}

	private void AGEJKLMJGDO()
	{
		SCShader = Shader.Find("ItemsCountText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OKHBBIKDIEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1377f)
			{
				HBJJOCHGOPH = 1112f;
			}
			OCHJIMJNEMO().SetFloat("settings.disablestoryboard", HBJJOCHGOPH);
			KEMJNOMIPHN().SetFloat("turn", Red_Start);
			DONENAMLFLF().SetFloat("CompletedLevel", Red_End);
			MJJIEHANFJA().SetFloat("[ResourcesManager] Unloading data resources", Green_Start);
			MICHFGAOPKM().SetFloat("#news", Green_End);
			CBCNOEIALHB().SetFloat("Anomaly_Near", Blue_Start);
			DNLMFEGJJDD().SetFloat("_TimeX", Blue_End);
			MICHFGAOPKM().SetFloat("cameramovements:", RGB_Start);
			KEMJNOMIPHN().SetFloat("[DiscordController] Init", RGB_End);
			MHBAIEKFBIJ().SetVector("Event Received", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1333f, 1844f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ODGMCJILIHF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JHJFBCFBKLD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material CBCNOEIALHB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInInspector);
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

	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 783f)
			{
				HBJJOCHGOPH = 1492f;
			}
			OLHDPICFBOF().SetFloat("OnJoinedRoom() called by PUN. Now this client is in a room. From here on, your game would be running. For reference, all callbacks are listed in enum: PhotonNetworkingMessage", HBJJOCHGOPH);
			OJMHIMIPKME().SetFloat("MapCreationCanvas", Red_Start);
			NBPKMLMCHFN.SetFloat("_TimeX", Red_End);
			HNICHJCGJOC().SetFloat("masterSteamID", Green_Start);
			ENKPNJMPDEB().SetFloat("_GlowColor", Green_End);
			MHBAIEKFBIJ().SetFloat(" ", Blue_Start);
			HFBJAOFLCJI().SetFloat("The binding '", Blue_End);
			CFEDGDGBCHE().SetFloat("Object ID. Case-Sensitive", RGB_Start);
			LNLKMDPHDCC().SetFloat("_Value2", RGB_End);
			NBPKMLMCHFN.SetVector("_MainTex2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1636f, 1795f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JBNPEHMDCMI()
	{
	}

	private void BMIOFJFMCBG()
	{
		SCShader = Shader.Find(".highscore");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IKMELABKBHO()
	{
	}

	private void MFMIODIAKNI()
	{
	}

	private void EGEGNHLODAA()
	{
	}

	private void HONBLGFDMLL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
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
	private Material MMOODGIODPC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 835f)
			{
				HBJJOCHGOPH = 1922f;
			}
			KOHGPKOFEJO().SetFloat("_Blue_G", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("_AdaptationMin", Red_Start);
			LPMLLJKMAMP().SetFloat("\n", Red_End);
			LNLKMDPHDCC().SetFloat(".", Green_Start);
			OLHDPICFBOF().SetFloat("BadgeText", Green_End);
			GJHPODJOBHL().SetFloat("_LoopCount", Blue_Start);
			AELJLBOJAIL().SetFloat("_FgOverlap", Blue_End);
			CFEDGDGBCHE().SetFloat("Reconnect() failed. It seems the client wasn't connected before?! Current state: ", RGB_Start);
			NBPKMLMCHFN.SetFloat("LivesSlider", RGB_End);
			KHCLIAMBBNC().SetVector("checkpoint", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1732f, 1775f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JILOMOBDPIA()
	{
		SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IEFMONDKKJN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KKEOHFGKCIK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BGDONBMDPGM()
	{
	}

	private void JKFDDNMPOJH()
	{
		SCShader = Shader.Find("BlockSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material MICHFGAOPKM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-98);
		}
		return BJFKDHHMLJH;
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Colors_RgbClamp");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MKIFJMPELJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 666f)
			{
				HBJJOCHGOPH = 1313f;
			}
			HFBJAOFLCJI().SetFloat("_Value", HBJJOCHGOPH);
			MMOODGIODPC().SetFloat("float,40", Red_Start);
			OJMHIMIPKME().SetFloat(" elements", Red_End);
			HFBJAOFLCJI().SetFloat("Intensity", Green_Start);
			KOHGPKOFEJO().SetFloat("_ScreenResolution", Green_End);
			DNLMFEGJJDD().SetFloat("SlidingArea", Blue_Start);
			ENKPNJMPDEB().SetFloat("Editor", Blue_End);
			LNLKMDPHDCC().SetFloat("/icon", RGB_Start);
			CFEDGDGBCHE().SetFloat("_MinVelocity", RGB_End);
			DNLMFEGJJDD().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 979f, 847f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHPODJOBHL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LPMLLJKMAMP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-96);
		}
		return BJFKDHHMLJH;
	}

	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 605f)
			{
				HBJJOCHGOPH = 1756f;
			}
			NLFJGMBCICG().SetFloat("ConnectToRegion() failed. Can only connect while in state 'Disconnected'. Current state: ", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("CameraFilterPack_RainFX_Anm2", Red_Start);
			CFEDGDGBCHE().SetFloat("music", Red_End);
			NBPKMLMCHFN.SetFloat("grid", Green_Start);
			MMOODGIODPC().SetFloat(".ogg", Green_End);
			MJJIEHANFJA().SetFloat("Tab1Content", Blue_Start);
			GJHPODJOBHL().SetFloat("key", Blue_End);
			CECICEGFHKL().SetFloat("_Distortion", RGB_Start);
			NLFJGMBCICG().SetFloat(".b", RGB_End);
			KEMJNOMIPHN().SetVector("CameraFilterPack/Vision_Rainbow", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 321f, 1300f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1225f)
			{
				HBJJOCHGOPH = 1764f;
			}
			OJMHIMIPKME().SetFloat("_BlurPass", HBJJOCHGOPH);
			FLOHGDECHHH().SetFloat("AddEnvironmentObject", Red_Start);
			DNLMFEGJJDD().SetFloat("_Value3", Red_End);
			NBPKMLMCHFN.SetFloat("player.xp", Green_Start);
			GJHPODJOBHL().SetFloat("The shader ", Green_End);
			MHBAIEKFBIJ().SetFloat("_Distortion", Blue_Start);
			KEMJNOMIPHN().SetFloat("mine", Blue_End);
			MJJIEHANFJA().SetFloat("_ScreenResolution", RGB_Start);
			MICHFGAOPKM().SetFloat("_BlurVector", RGB_End);
			KOHGPKOFEJO().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 292f, 1252f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material FLOHGDECHHH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void LLKKGGLNIDF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AOGCKKLFGPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 418f)
			{
				HBJJOCHGOPH = 1317f;
			}
			NLFJGMBCICG().SetFloat("_SceneFogMode", HBJJOCHGOPH);
			OLHDPICFBOF().SetFloat("1087340967", Red_Start);
			OJMHIMIPKME().SetFloat("_Value4", Red_End);
			GJHPODJOBHL().SetFloat("Texture2", Green_Start);
			OJMHIMIPKME().SetFloat("RaiseEvent() failed. Your event is not being sent! Check if your are in a Room and the eventCode must be less than 200 (0..199).", Green_End);
			DNLMFEGJJDD().SetFloat("LocalPlayer is null or not in mActors! LocalPlayer: {0} mActors==null: {1} newID: {2}", Blue_Start);
			OLHDPICFBOF().SetFloat("_PositionX", Blue_End);
			GJHPODJOBHL().SetFloat("_Distortion", RGB_Start);
			MICHFGAOPKM().SetFloat("s", RGB_End);
			CFEDGDGBCHE().SetVector("_DistAmount", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1915f, 601f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1784f)
			{
				HBJJOCHGOPH = 1863f;
			}
			OJMHIMIPKME().SetFloat("No child content found, exiting..", HBJJOCHGOPH);
			GJHPODJOBHL().SetFloat("GameScene", Red_Start);
			HFBJAOFLCJI().SetFloat("_Intensity", Red_End);
			LNLKMDPHDCC().SetFloat("Value", Green_Start);
			HNICHJCGJOC().SetFloat("_ScreenResolution", Green_End);
			DNLMFEGJJDD().SetFloat("Create failed on GameServer. Changing back to MasterServer. Msg: ", Blue_Start);
			HNICHJCGJOC().SetFloat("RedoButton", Blue_End);
			KOHGPKOFEJO().SetFloat("CameraFilterPack/Blend2Camera_SoftLight", RGB_Start);
			CECICEGFHKL().SetFloat("settings.hitvariation", RGB_End);
			AELJLBOJAIL().SetVector("Can't set open when not in that room.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1568f, 1535f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IDJKNBDKHBD()
	{
		SCShader = Shader.Find("SupportLogger OnJoinedRoom(");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material ENKPNJMPDEB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)69;
		}
		return BJFKDHHMLJH;
	}

	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 639f)
			{
				HBJJOCHGOPH = 934f;
			}
			CFEDGDGBCHE().SetFloat("menu.tabid", HBJJOCHGOPH);
			CBCNOEIALHB().SetFloat("JoinTeam was called in state: ", Red_Start);
			HFBJAOFLCJI().SetFloat("value", Red_End);
			MMOODGIODPC().SetFloat("[Down]", Green_Start);
			KEMJNOMIPHN().SetFloat("_DiffuseColor", Green_End);
			ENKPNJMPDEB().SetFloat("HightScoreMaxPointsText", Blue_Start);
			OOMFJGPAOKL().SetFloat("Object ID. Case-Sensitive", Blue_End);
			MJJIEHANFJA().SetFloat("#EA4137", RGB_Start);
			LNLKMDPHDCC().SetFloat("_Amount", RGB_End);
			DONENAMLFLF().SetVector("MultiplayerButton", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 528f, 1765f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-1);
		}
		return BJFKDHHMLJH;
	}

	private void BMBIGILMLLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1944f)
			{
				HBJJOCHGOPH = 1590f;
			}
			MMOODGIODPC().SetFloat("menu.enableselectormusic", HBJJOCHGOPH);
			MJJIEHANFJA().SetFloat("D-Pad Up", Red_Start);
			HFBJAOFLCJI().SetFloat("ViewMenu", Red_End);
			AELJLBOJAIL().SetFloat("_ScreenResolution", Green_Start);
			FLOHGDECHHH().SetFloat("_Value3", Green_End);
			FLOHGDECHHH().SetFloat("_ScreenResolution", Blue_Start);
			KHCLIAMBBNC().SetFloat("\"", Blue_End);
			DONENAMLFLF().SetFloat("NO", RGB_Start);
			LNLKMDPHDCC().SetFloat("_ColorKey", RGB_End);
			OLHDPICFBOF().SetVector("[PlayerBase] Reset", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 625f, 422f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
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

	[SpecialName]
	private Material OCHJIMJNEMO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-65);
		}
		return BJFKDHHMLJH;
	}

	private void GNMGIHFKJIJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PBEPCAPAKLG()
	{
	}

	[SpecialName]
	private Material KEMJNOMIPHN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void KDMANOEMOCA()
	{
		SCShader = Shader.Find("Texture2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AEIJFLJEABG()
	{
	}

	[SpecialName]
	private Material LNLKMDPHDCC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-120);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KHCLIAMBBNC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-1);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material OOMFJGPAOKL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
		}
		return BJFKDHHMLJH;
	}

	private void MJEFMIPLFAB()
	{
		SCShader = Shader.Find("CameraFilterPack/Blur_Radial_Fast");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KLOLKEBAPFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material MHBAIEKFBIJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)76;
		}
		return BJFKDHHMLJH;
	}

	private void CIHGFHNNFEE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LLDHEJIEDHO()
	{
	}

	private void AEEGKLABFLN()
	{
	}

	[SpecialName]
	private Material OJMHIMIPKME()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1729f)
			{
				HBJJOCHGOPH = 1724f;
			}
			OJMHIMIPKME().SetFloat("/../", HBJJOCHGOPH);
			MMOODGIODPC().SetFloat("maps.", Red_Start);
			HFBJAOFLCJI().SetFloat("1 Kb", Red_End);
			KHCLIAMBBNC().SetFloat("_TimeX", Green_Start);
			CECICEGFHKL().SetFloat("_color", Green_End);
			OJMHIMIPKME().SetFloat("_Value9", Blue_Start);
			KEMJNOMIPHN().SetFloat("_Value4", Blue_End);
			CECICEGFHKL().SetFloat("_VignettingDirt", RGB_Start);
			MJJIEHANFJA().SetFloat(" [", RGB_End);
			CECICEGFHKL().SetVector(".progress", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 221f, 826f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void COOHIILCOCO()
	{
		SCShader = Shader.Find("AllocateViewID() failed. Room (user {0}) is out of 'scene' viewIDs. It seems all available are in use.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1352f)
			{
				HBJJOCHGOPH = 444f;
			}
			MMOODGIODPC().SetFloat("Set sun audio input", HBJJOCHGOPH);
			KEMJNOMIPHN().SetFloat("settings.enablehitsoundsinrelax", Red_Start);
			NLFJGMBCICG().SetFloat(" argument(s): ", Red_End);
			LNLKMDPHDCC().SetFloat("_ScreenResolution", Green_Start);
			CFEDGDGBCHE().SetFloat("_TimeX", Green_End);
			OJMHIMIPKME().SetFloat("Setting autoCleanUpPlayerObjects while in a room is not supported.", Blue_Start);
			GJHPODJOBHL().SetFloat("Error: I/O Failure! :(", Blue_End);
			LPMLLJKMAMP().SetFloat(" registered.", RGB_Start);
			NLFJGMBCICG().SetFloat("[PlayerController] ", RGB_End);
			NBPKMLMCHFN.SetVector("&search=", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1335f, 565f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JMEOGJHCONJ()
	{
		SCShader = Shader.Find("[ReplayScene] Loading replay: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PKLOBJHKFEO()
	{
		SCShader = Shader.Find("[PlayerController] ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EJJEDJIOFAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JFMIDILENDO()
	{
	}

	private void DOKAKEMDALN()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NDBPCNICGLC()
	{
		SCShader = Shader.Find("_Value11");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DKOPKPBLDHH()
	{
		SCShader = Shader.Find("_Extra");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material GJHPODJOBHL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-66);
		}
		return BJFKDHHMLJH;
	}

	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1983f)
			{
				HBJJOCHGOPH = 1392f;
			}
			OJMHIMIPKME().SetFloat("_Value3", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("_Fade", Red_Start);
			KEMJNOMIPHN().SetFloat("Gameplay/sprite", Red_End);
			OOMFJGPAOKL().SetFloat("_Value3", Green_Start);
			MJJIEHANFJA().SetFloat("Reconnect() failed. It seems the client wasn't connected before?! Current state: ", Green_End);
			LNLKMDPHDCC().SetFloat("_Value", Blue_Start);
			LPMLLJKMAMP().SetFloat("SAVE FILE", Blue_End);
			DNLMFEGJJDD().SetFloat("Join failed on GameServer. Changing back to MasterServer. Msg: ", RGB_Start);
			ENKPNJMPDEB().SetFloat("(\\[ */ *quote *\\])", RGB_End);
			LPMLLJKMAMP().SetVector("ArcsNoHitsoundTimeDelaySlider", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1277f, 554f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FABKIGNFECE()
	{
	}

	[SpecialName]
	private Material CECICEGFHKL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void GBGAMCPNBCC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 329f)
			{
				HBJJOCHGOPH = 1163f;
			}
			CBCNOEIALHB().SetFloat("Connection error: ", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("_Value3", Red_Start);
			MJJIEHANFJA().SetFloat("#score", Red_End);
			OLHDPICFBOF().SetFloat("]", Green_Start);
			HNICHJCGJOC().SetFloat("<start_index> <end_index>", Green_End);
			CBCNOEIALHB().SetFloat("Set satellite clockwise rotattion speed", Blue_Start);
			OLHDPICFBOF().SetFloat("LoadMapCanvas", Blue_End);
			ENKPNJMPDEB().SetFloat("x", RGB_Start);
			GJHPODJOBHL().SetFloat("ERROR: preview file name is empty in modName.workshop.json", RGB_End);
			AELJLBOJAIL().SetVector("The given 2D texture ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1926f, 230f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 713f)
			{
				HBJJOCHGOPH = 1984f;
			}
			OCHJIMJNEMO().SetFloat("ShowSprite", HBJJOCHGOPH);
			DONENAMLFLF().SetFloat("settings.gamemessagesduration", Red_Start);
			MICHFGAOPKM().SetFloat("SaveGameName is null or empty!", Red_End);
			HNICHJCGJOC().SetFloat("/", Green_Start);
			GJHPODJOBHL().SetFloat("UsernameText", Green_End);
			DNLMFEGJJDD().SetFloat("[MenuScene] Error: ", Blue_Start);
			HNICHJCGJOC().SetFloat("LevelEditor/patterns", Blue_End);
			OOMFJGPAOKL().SetFloat("Start index must in an integer.", RGB_Start);
			NBPKMLMCHFN.SetFloat("received</b>\n#reason: ", RGB_End);
			CECICEGFHKL().SetVector("DPADVER", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1047f, 742f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLOHGDECHHH());
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
			NBPKMLMCHFN.SetFloat("_Value", Red_Start);
			NBPKMLMCHFN.SetFloat("_Value2", Red_End);
			NBPKMLMCHFN.SetFloat("_Value3", Green_Start);
			NBPKMLMCHFN.SetFloat("_Value4", Green_End);
			NBPKMLMCHFN.SetFloat("_Value5", Blue_Start);
			NBPKMLMCHFN.SetFloat("_Value6", Blue_End);
			NBPKMLMCHFN.SetFloat("_Value7", RGB_Start);
			NBPKMLMCHFN.SetFloat("_Value8", RGB_End);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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

	private void HMPGIFBJFIK()
	{
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IMGGCJICLHK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EDDPLJGKLKJ()
	{
	}

	private void JLNNHKPHMAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DLIJFEGIEKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1077f)
			{
				HBJJOCHGOPH = 443f;
			}
			KOHGPKOFEJO().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			MJJIEHANFJA().SetFloat("[SERVER] Selected map: ", Red_Start);
			MICHFGAOPKM().SetFloat("_Value2", Red_End);
			OLHDPICFBOF().SetFloat("PLAY [SPACE]", Green_Start);
			CFEDGDGBCHE().SetFloat("_TapMedium", Green_End);
			NLFJGMBCICG().SetFloat("workshop.", Blue_Start);
			LPMLLJKMAMP().SetFloat("Connection error: ", Blue_End);
			CFEDGDGBCHE().SetFloat(",", RGB_Start);
			NBPKMLMCHFN.SetFloat("yyyy", RGB_End);
			OJMHIMIPKME().SetVector(",", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1442f, 347f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BEBNOKFLJPH()
	{
		SCShader = Shader.Find("_CenterX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 206f)
			{
				HBJJOCHGOPH = 1756f;
			}
			MJJIEHANFJA().SetFloat("Set Trail Zoom Speed", HBJJOCHGOPH);
			MJJIEHANFJA().SetFloat("CameraFilterPack/Blend2Camera_VividLight", Red_Start);
			MMOODGIODPC().SetFloat("_FixDistance", Red_End);
			ENKPNJMPDEB().SetFloat("_SSAO", Green_Start);
			MICHFGAOPKM().SetFloat("Gameplay/sun", Green_End);
			LNLKMDPHDCC().SetFloat("clear", Blue_Start);
			NLFJGMBCICG().SetFloat("_ScreenResolution", Blue_End);
			OLHDPICFBOF().SetFloat("bool", RGB_Start);
			OJMHIMIPKME().SetFloat("{0} days ago", RGB_End);
			DONENAMLFLF().SetVector("_ColorR", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 588f, 1774f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OOMFJGPAOKL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PHJLHCMCCKE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Update()
	{
	}

	private void PLIKADJCEPO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KKLMPKLKAEM()
	{
	}

	private void FGOPJMGNHGO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GNPDGBNDCPL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ICDBMJKMIKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KMEONPMCNJG()
	{
	}

	private void ELGOMIMONOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1524f)
			{
				HBJJOCHGOPH = 24f;
			}
			MHBAIEKFBIJ().SetFloat("GlassColor", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/3D_Mirror", Red_Start);
			DONENAMLFLF().SetFloat("Cause: ", Red_End);
			FLOHGDECHHH().SetFloat("There are {0} reported logs.", Green_Start);
			FLOHGDECHHH().SetFloat("_Value8", Green_End);
			OOMFJGPAOKL().SetFloat("Joystick1Button4", Blue_Start);
			OOMFJGPAOKL().SetFloat("CameraFilterPack/3D_Myst", Blue_End);
			MMOODGIODPC().SetFloat("vignetteIntensity", RGB_Start);
			KHCLIAMBBNC().SetFloat("_Colorisation", RGB_End);
			FLOHGDECHHH().SetVector("getstring", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 878f, 1326f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MCKCCPLJIFE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ODBNMPGBCGO()
	{
		SCShader = Shader.Find("mapselector.orderby");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FHGKIOOMMOH()
	{
		SCShader = Shader.Find("CameraFilterPack/Vision_Aura");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IJMAPHMBFJI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 599f)
			{
				HBJJOCHGOPH = 917f;
			}
			HFBJAOFLCJI().SetFloat("Set satellite trail length in seconds", HBJJOCHGOPH);
			MHBAIEKFBIJ().SetFloat("ready", Red_Start);
			CECICEGFHKL().SetFloat("score", Red_End);
			AELJLBOJAIL().SetFloat(".sawoutdatedmessage", Green_Start);
			MHBAIEKFBIJ().SetFloat("R:", Green_End);
			OJMHIMIPKME().SetFloat("_TimeX", Blue_Start);
			HNICHJCGJOC().SetFloat("LoadingStatusText", Blue_End);
			FLOHGDECHHH().SetFloat("_Value4", RGB_Start);
			CECICEGFHKL().SetFloat("st", RGB_End);
			GJHPODJOBHL().SetVector("_DistortionSize", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1156f, 705f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ODMPMJPALID()
	{
		SCShader = Shader.Find("Crosshair");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material MJJIEHANFJA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-85);
		}
		return BJFKDHHMLJH;
	}

	private void OMCLOFCJMPG()
	{
	}

	private void MFLBEJHMEMO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ADPLHDFJFID()
	{
		SCShader = Shader.Find("_Value13");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HEBOIFKBLGD()
	{
	}

	private void HPFOFGJPNCI()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NPLCENPNJBM()
	{
		SCShader = Shader.Find("CameraFilterPack/FX_Spot");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HJPCJGOEKMF()
	{
		SCShader = Shader.Find("NEW_ACHIEVEMENT_1_21");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material KOHGPKOFEJO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return BJFKDHHMLJH;
	}

	private void COGBDFKOHKK()
	{
	}

	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 578f)
			{
				HBJJOCHGOPH = 313f;
			}
			NLFJGMBCICG().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			FLOHGDECHHH().SetFloat("ViewMenu", Red_Start);
			OLHDPICFBOF().SetFloat(",", Red_End);
			KOHGPKOFEJO().SetFloat("mapselector.orderby", Green_Start);
			OCHJIMJNEMO().SetFloat(".a", Green_End);
			AELJLBOJAIL().SetFloat("SetSatelliteSensitivity", Blue_Start);
			NLFJGMBCICG().SetFloat("_MainTex2", Blue_End);
			HNICHJCGJOC().SetFloat("LT", RGB_Start);
			LNLKMDPHDCC().SetFloat("PlayerPrefs::Deserialize() parameterContent has ", RGB_End);
			LPMLLJKMAMP().SetVector("[Right]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 699f, 343f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ABFNJCEBIKA()
	{
	}

	[SpecialName]
	private Material DNLMFEGJJDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)120;
		}
		return BJFKDHHMLJH;
	}

	private void MODENHKMKOC()
	{
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KIEJKBNBHMD()
	{
	}

	[SpecialName]
	private Material AELJLBOJAIL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HNICHJCGJOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)68;
		}
		return BJFKDHHMLJH;
	}

	private void MMPHNFPPEHO()
	{
		SCShader = Shader.Find(" = ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IDIIELPAMCJ()
	{
	}

	private void HDMDKOKOOJC()
	{
		SCShader = Shader.Find("_InvRenderTargetSize");
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

	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1967f)
			{
				HBJJOCHGOPH = 1718f;
			}
			MICHFGAOPKM().SetFloat("_TimeX", HBJJOCHGOPH);
			ENKPNJMPDEB().SetFloat("RestartButton", Red_Start);
			NBPKMLMCHFN.SetFloat("x", Red_End);
			OLHDPICFBOF().SetFloat("&page=", Green_Start);
			DONENAMLFLF().SetFloat("MissesText", Green_End);
			NLFJGMBCICG().SetFloat("CameraFilterPack/FX_DigitalMatrix", Blue_Start);
			CFEDGDGBCHE().SetFloat("cipherText", Blue_End);
			KOHGPKOFEJO().SetFloat("_FinalReflectionTexture", RGB_Start);
			ENKPNJMPDEB().SetFloat("_UserLutTex", RGB_End);
			LPMLLJKMAMP().SetVector("Default UI Material", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1117f, 1321f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HLHJBJGEEEA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1189f)
			{
				HBJJOCHGOPH = 343f;
			}
			AELJLBOJAIL().SetFloat(".lastCheckpoint.powerupsScore", HBJJOCHGOPH);
			MHBAIEKFBIJ().SetFloat("_MainTex2", Red_Start);
			KOHGPKOFEJO().SetFloat("GlassesColor2", Red_End);
			DNLMFEGJJDD().SetFloat("ticket", Green_Start);
			MHBAIEKFBIJ().SetFloat("_ScreenResolution", Green_End);
			DONENAMLFLF().SetFloat("Joystick1Button11", Blue_Start);
			MICHFGAOPKM().SetFloat("/", Blue_End);
			ENKPNJMPDEB().SetFloat("_EmissionColor", RGB_Start);
			OCHJIMJNEMO().SetFloat("_ScreenResolution", RGB_End);
			OCHJIMJNEMO().SetVector("CameraFilterPack/Blur_Radial", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 216f, 770f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 292f)
			{
				HBJJOCHGOPH = 1512f;
			}
			HNICHJCGJOC().SetFloat("\\", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("_ColorBuffer", Red_Start);
			CBCNOEIALHB().SetFloat("settings.gamemessagesduration", Red_End);
			MICHFGAOPKM().SetFloat("CameraFilterPack_AAA_BloodOnScreen1", Green_Start);
			LNLKMDPHDCC().SetFloat("CameraFilterPack/Distortion_Dream2", Green_End);
			OCHJIMJNEMO().SetFloat("[PlayerController] ", Blue_Start);
			NLFJGMBCICG().SetFloat("_Value4", Blue_End);
			OOMFJGPAOKL().SetFloat("Save Path: ", RGB_Start);
			MJJIEHANFJA().SetFloat(" not exist", RGB_End);
			KHCLIAMBBNC().SetVector("z", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1222f, 1928f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LEAHIBJDMBI()
	{
	}
}
