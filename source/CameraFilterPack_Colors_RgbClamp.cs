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
		SCShader = Shader.Find("VHS2");
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
		SCShader = Shader.Find("_Extra2");
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
		SCShader = Shader.Find("InfoCanvas");
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
			GJHPODJOBHL().SetFloat("settings.disablestoryboard", HBJJOCHGOPH);
			MMOODGIODPC().SetFloat(". Not connectedAndReady.", Red_Start);
			NBPKMLMCHFN.SetFloat("\" error: ", Red_End);
			NLFJGMBCICG().SetFloat(",viewkeys", Green_Start);
			FLOHGDECHHH().SetFloat("#news", Green_End);
			DNLMFEGJJDD().SetFloat("Anomaly_Near", Blue_Start);
			KEMJNOMIPHN().SetFloat("CameraFilterPack/TV_Old_Movie", Blue_End);
			AELJLBOJAIL().SetFloat("bloomintencity:", RGB_Start);
			MJJIEHANFJA().SetFloat("[DiscordController] Sectate ({0})", RGB_End);
			DONENAMLFLF().SetVector("You need to have a Graphic control (such as an Image) for the list [", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1333f, 1844f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OJMHIMIPKME());
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
			OJMHIMIPKME().SetFloat("OnPhotonRandomJoinFailed() was called by PUN. No random room available, so we create one. Calling: PhotonNetwork.CreateRoom(null, new RoomOptions() {maxPlayers = 4}, null);", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("<b><i>Map's Stats:</i></b>", Red_Start);
			MHBAIEKFBIJ().SetFloat("CameraFilterPack/Glow_Glow", Red_End);
			LPMLLJKMAMP().SetFloat("masterSteamID", Green_Start);
			HFBJAOFLCJI().SetFloat("_Value3", Green_End);
			HNICHJCGJOC().SetFloat(":", Blue_Start);
			DONENAMLFLF().SetFloat("settings_bindings_sec_", Blue_End);
			KOHGPKOFEJO().SetFloat("Object ID. Case-Sensitive", RGB_Start);
			KEMJNOMIPHN().SetFloat("_Value", RGB_End);
			NBPKMLMCHFN.SetVector("_Value13", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1636f, 1795f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
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
		SCShader = Shader.Find(".");
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
			FLOHGDECHHH().SetFloat("_Blue_R", HBJJOCHGOPH);
			OJMHIMIPKME().SetFloat("_AdaptationSpeed", Red_Start);
			GJHPODJOBHL().SetFloat("Selection Box", Red_End);
			ENKPNJMPDEB().SetFloat("GO==null", Green_Start);
			MMOODGIODPC().SetFloat("NEW", Green_End);
			OJMHIMIPKME().SetFloat("_TileMaxOffs", Blue_Start);
			LNLKMDPHDCC().SetFloat("_Screen", Blue_End);
			KHCLIAMBBNC().SetFloat("ConnectToMaster() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", RGB_Start);
			AELJLBOJAIL().SetFloat("LivesSlider", RGB_End);
			MICHFGAOPKM().SetVector("checkpoint", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1732f, 1775f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ENKPNJMPDEB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JILOMOBDPIA()
	{
		SCShader = Shader.Find("CameraFilterPack/Blend2Camera_ColorDodge");
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
		SCShader = Shader.Find("_Color");
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
			MMOODGIODPC().SetFloat("_TimeX", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("float,40", Red_Start);
			CFEDGDGBCHE().SetFloat(" elements", Red_End);
			MMOODGIODPC().SetFloat("Fade", Green_Start);
			MJJIEHANFJA().SetFloat("_TimeX", Green_End);
			MMOODGIODPC().SetFloat("ScrollPanel", Blue_Start);
			KHCLIAMBBNC().SetFloat("LoadMapCanvas", Blue_End);
			LNLKMDPHDCC().SetFloat("/music", RGB_Start);
			NLFJGMBCICG().SetFloat("_MaxVelocity", RGB_End);
			ENKPNJMPDEB().SetVector("_Value4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 979f, 847f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OCHJIMJNEMO());
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
			ENKPNJMPDEB().SetFloat("ConnectToBestCloudServer() failed. Can only connect while in state 'Disconnected'. Current state: ", HBJJOCHGOPH);
			KHCLIAMBBNC().SetFloat("Texture2", Red_Start);
			CFEDGDGBCHE().SetFloat("Editor/", Red_End);
			OLHDPICFBOF().SetFloat("GridDataStoryboard", Green_Start);
			OJMHIMIPKME().SetFloat(".mp3", Green_End);
			HFBJAOFLCJI().SetFloat("LevelURLInputField", Blue_Start);
			DONENAMLFLF().SetFloat("Obtain promo Item", Blue_End);
			ENKPNJMPDEB().SetFloat("_CenterY", RGB_Start);
			ENKPNJMPDEB().SetFloat(".g", RGB_End);
			NLFJGMBCICG().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 321f, 1300f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DONENAMLFLF());
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
			CFEDGDGBCHE().SetFloat("_BlurPass", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("AddEnvironmentObject", Red_Start);
			MJJIEHANFJA().SetFloat("_Value", Red_End);
			DNLMFEGJJDD().SetFloat("player.xp", Green_Start);
			AELJLBOJAIL().SetFloat("The image effect ", Green_End);
			OCHJIMJNEMO().SetFloat("_TimeX", Blue_Start);
			MMOODGIODPC().SetFloat(" SecondsBeforeRespawn: ", Blue_End);
			FLOHGDECHHH().SetFloat("_ScreenResolution", RGB_Start);
			OOMFJGPAOKL().SetFloat("_BlurVector", RGB_End);
			ENKPNJMPDEB().SetVector("CameraFilterPack/Colors_DarkColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 292f, 1252f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
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
			KOHGPKOFEJO().SetFloat("_DistanceParams", HBJJOCHGOPH);
			LPMLLJKMAMP().SetFloat("896296812", Red_Start);
			LNLKMDPHDCC().SetFloat("_Value3", Red_End);
			HNICHJCGJOC().SetFloat("Texture2", Green_Start);
			MJJIEHANFJA().SetFloat("ReJoinRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", Green_End);
			KHCLIAMBBNC().SetFloat(".", Blue_Start);
			MHBAIEKFBIJ().SetFloat("_PositionX", Blue_End);
			AELJLBOJAIL().SetFloat("_Value2", RGB_Start);
			ENKPNJMPDEB().SetFloat("s", RGB_End);
			MMOODGIODPC().SetVector("UNDISTORT", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1915f, 601f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CBCNOEIALHB());
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
			DNLMFEGJJDD().SetFloat("Warning, using scrollbors with the Scroll Snap controls is not advised as it causes unpredictable results", HBJJOCHGOPH);
			CECICEGFHKL().SetFloat("note.7", Red_Start);
			ENKPNJMPDEB().SetFloat("_Offsets", Red_End);
			MMOODGIODPC().SetFloat("ScreenResolutionPanel", Green_Start);
			CFEDGDGBCHE().SetFloat("_Value2", Green_End);
			MMOODGIODPC().SetFloat("Not sending leave operation. State is not 'Joined': ", Blue_Start);
			CECICEGFHKL().SetFloat("RedoButton", Blue_End);
			FLOHGDECHHH().SetFloat("CameraFilterPack/Blend2Camera_SoftLight", RGB_Start);
			AELJLBOJAIL().SetFloat("settings.enableselectormusic", RGB_End);
			DNLMFEGJJDD().SetVector("wss://", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1568f, 1535f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OOMFJGPAOKL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IDJKNBDKHBD()
	{
		SCShader = Shader.Find(").");
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
			OCHJIMJNEMO().SetFloat("menu.tabid", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("score", Red_Start);
			ENKPNJMPDEB().SetFloat("Object ID. Case-Sensitive", Red_End);
			AELJLBOJAIL().SetFloat("SpawnObj", Green_Start);
			OLHDPICFBOF().SetFloat("/", Green_End);
			KHCLIAMBBNC().SetFloat("EndlessLoopsScoreText", Blue_Start);
			MHBAIEKFBIJ().SetFloat("Object ID", Blue_End);
			DONENAMLFLF().SetFloat("#91CCFF", RGB_Start);
			DONENAMLFLF().SetFloat("_ScreenResolution", RGB_End);
			DNLMFEGJJDD().SetVector("MultiplayerButton", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 528f, 1765f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KHCLIAMBBNC());
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
			MJJIEHANFJA().SetFloat("menu.selectedplaymode", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("Xbox Home", Red_Start);
			GJHPODJOBHL().SetFloat("#mapnotloaded", Red_End);
			NBPKMLMCHFN.SetFloat("_Distortion", Green_Start);
			CBCNOEIALHB().SetFloat("_Value2", Green_End);
			CFEDGDGBCHE().SetFloat("_ScreenResolution", Blue_Start);
			KHCLIAMBBNC().SetFloat("]", Blue_End);
			ENKPNJMPDEB().SetFloat("NO", RGB_Start);
			HNICHJCGJOC().SetFloat("_ColorKey", RGB_End);
			NLFJGMBCICG().SetVector("_EmissionGain", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 625f, 422f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLOHGDECHHH());
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
		SCShader = Shader.Find("_ScreenResolution");
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
			CFEDGDGBCHE().SetFloat("OPEN", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("Crosshair1", Red_Start);
			FLOHGDECHHH().SetFloat("#.##", Red_End);
			HFBJAOFLCJI().SetFloat("_MainTex2", Green_Start);
			LPMLLJKMAMP().SetFloat("_color", Green_End);
			FLOHGDECHHH().SetFloat("_Value9", Blue_Start);
			KHCLIAMBBNC().SetFloat("_Value4", Blue_End);
			DNLMFEGJJDD().SetFloat("_VignettingColor", RGB_Start);
			LPMLLJKMAMP().SetFloat(". Our prefix is ", RGB_End);
			CECICEGFHKL().SetVector(".progress", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 221f, 826f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void COOHIILCOCO()
	{
		SCShader = Shader.Find("RaiseEvent() failed. Your event is not being sent! Check if your are in a Room and the eventCode must be less than 200 (0..199).");
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
			ENKPNJMPDEB().SetFloat("Set sun audio input", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("settings.enablehitsoundsinrelax", Red_Start);
			AELJLBOJAIL().SetFloat(" methods \"", Red_End);
			FLOHGDECHHH().SetFloat("_Distortion", Green_Start);
			LPMLLJKMAMP().SetFloat("_TimeX", Green_End);
			HNICHJCGJOC().SetFloat("<not connected>", Blue_Start);
			KEMJNOMIPHN().SetFloat("https://steamcommunity.com/sharedfiles/filedetails/?id=", Blue_End);
			ENKPNJMPDEB().SetFloat(" registered.", RGB_Start);
			HNICHJCGJOC().SetFloat(" not exist", RGB_End);
			NBPKMLMCHFN.SetVector("&search=", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1335f, 565f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
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
		SCShader = Shader.Find(": ");
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
		SCShader = Shader.Find("CameraFilterPack/Drawing_Toon");
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
		SCShader = Shader.Find("_Intensity");
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
			CFEDGDGBCHE().SetFloat("_Value3", HBJJOCHGOPH);
			MHBAIEKFBIJ().SetFloat("CameraFilterPack/Vision_SniperScore", Red_Start);
			KOHGPKOFEJO().SetFloat("Gameplay/Segment-[PowerUp]", Red_End);
			NBPKMLMCHFN.SetFloat("_Value2", Green_Start);
			MHBAIEKFBIJ().SetFloat("ConnectToMaster() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", Green_End);
			DONENAMLFLF().SetFloat("_ScreenResolution", Blue_Start);
			KHCLIAMBBNC().SetFloat("OPEN FILE", Blue_End);
			NBPKMLMCHFN.SetFloat("Join failed on GameServer. Changing back to MasterServer. Msg: ", RGB_Start);
			DNLMFEGJJDD().SetFloat("(\\[ */ *quote *\\])", RGB_End);
			ENKPNJMPDEB().SetVector("settings.arcsdestroydelay", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1277f, 554f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHPODJOBHL());
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
			HFBJAOFLCJI().SetFloat("#", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("_Value2", Red_Start);
			OJMHIMIPKME().SetFloat("menu.selectedplaymode", Red_End);
			CECICEGFHKL().SetFloat("materialsitemid[", Green_Start);
			KOHGPKOFEJO().SetFloat("Clears the console and prints the logs in the specified range", Green_End);
			CECICEGFHKL().SetFloat("float,40", Blue_Start);
			NLFJGMBCICG().SetFloat("Editor/", Blue_End);
			CBCNOEIALHB().SetFloat("y", RGB_Start);
			OCHJIMJNEMO().SetFloat("ERROR: Preview file must be <1MB!", RGB_End);
			AELJLBOJAIL().SetVector("selColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1926f, 230f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
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
			MICHFGAOPKM().SetFloat("Set the end of the map. Use this if you want to cut the long music.", HBJJOCHGOPH);
			ENKPNJMPDEB().SetFloat("settings.crosshairopacity", Red_Start);
			MMOODGIODPC().SetFloat("Load Game", Red_End);
			NBPKMLMCHFN.SetFloat("[MapEditor] Updating top menu", Green_Start);
			NBPKMLMCHFN.SetFloat("UsernameText", Green_End);
			MJJIEHANFJA().SetFloat("[MenuScene] Error: ", Blue_Start);
			KEMJNOMIPHN().SetFloat("Editing: ", Blue_End);
			AELJLBOJAIL().SetFloat("X2", RGB_Start);
			HNICHJCGJOC().SetFloat("restrictions\n\n#until: ", RGB_End);
			CBCNOEIALHB().SetVector("DPADHOR", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1047f, 742f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
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
			HNICHJCGJOC().SetFloat("_Value2", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("[SERVER] Selected map: ", Red_Start);
			LPMLLJKMAMP().SetFloat("_Value", Red_End);
			KEMJNOMIPHN().SetFloat("PAUSE [SPACE]", Green_Start);
			LNLKMDPHDCC().SetFloat("_TapMedium", Green_End);
			HNICHJCGJOC().SetFloat("MapperNameText", Blue_Start);
			OCHJIMJNEMO().SetFloat("Connection error: ", Blue_End);
			LPMLLJKMAMP().SetFloat("settings.disablestoryboard", RGB_Start);
			CFEDGDGBCHE().SetFloat("Please define the RectTransform for the Center viewport of the scrollable area", RGB_End);
			CFEDGDGBCHE().SetVector("EventData0DropDownList", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1442f, 347f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CECICEGFHKL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BEBNOKFLJPH()
	{
		SCShader = Shader.Find("_ScreenResolution");
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
			FLOHGDECHHH().SetFloat("Set Trail Zoom Speed", HBJJOCHGOPH);
			GJHPODJOBHL().SetFloat("CameraFilterPack/Blend2Camera_VividLight", Red_Start);
			NBPKMLMCHFN.SetFloat("_FixDistance", Red_End);
			MJJIEHANFJA().SetFloat("_SSAO", Green_Start);
			OCHJIMJNEMO().SetFloat("/Segment-[Down]", Green_End);
			KOHGPKOFEJO().SetFloat("players", Blue_Start);
			MMOODGIODPC().SetFloat("_ScreenResolution", Blue_End);
			ENKPNJMPDEB().SetFloat("true", RGB_Start);
			DONENAMLFLF().SetFloat("{0} days ago", RGB_End);
			HNICHJCGJOC().SetVector("_DotSize", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 588f, 1774f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
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
			MJJIEHANFJA().SetFloat("GlassesColor2", HBJJOCHGOPH);
			KEMJNOMIPHN().SetFloat("CameraFilterPack/3D_Mirror", Red_Start);
			DNLMFEGJJDD().SetFloat("OnConnectedToMaster() was called by PUN. Now this client is connected and could join a room. Calling: PhotonNetwork.JoinRandomRoom();", Red_End);
			FLOHGDECHHH().SetFloat(" - {0}", Green_Start);
			DNLMFEGJJDD().SetFloat("_Value8", Green_End);
			CFEDGDGBCHE().SetFloat("Joystick1Button3", Blue_Start);
			HFBJAOFLCJI().SetFloat("CameraFilterPack/3D_Myst", Blue_End);
			MMOODGIODPC().SetFloat("useSrcAlphaAsMask", RGB_Start);
			AELJLBOJAIL().SetFloat("_TimeX", RGB_End);
			CBCNOEIALHB().SetVector("getstring", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 878f, 1326f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
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
		SCShader = Shader.Find("mapselector.filter.subscribedonly");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FHGKIOOMMOH()
	{
		SCShader = Shader.Find("_Value");
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
			AELJLBOJAIL().SetFloat("Set satellite trail length in seconds", HBJJOCHGOPH);
			KHCLIAMBBNC().SetFloat("[Right]", Red_Start);
			KOHGPKOFEJO().SetFloat("owner: ", Red_End);
			KEMJNOMIPHN().SetFloat("[MapEditor] Openning ", Green_Start);
			MHBAIEKFBIJ().SetFloat("#{0:X2}{1:X2}{2:X2}", Green_End);
			OJMHIMIPKME().SetFloat("CameraFilterPack/OldFilm_Cutting2", Blue_Start);
			OOMFJGPAOKL().SetFloat("LoadingStatusText", Blue_End);
			MMOODGIODPC().SetFloat("_Value3", RGB_Start);
			AELJLBOJAIL().SetFloat("StartTime already set: ", RGB_End);
			OOMFJGPAOKL().SetVector("_DistortionSize", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1156f, 705f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ODMPMJPALID()
	{
		SCShader = Shader.Find("[PlayerBase] Loaded environment: ");
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
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HJPCJGOEKMF()
	{
		SCShader = Shader.Find("achievements.21.progress");
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
			NBPKMLMCHFN.SetFloat("_Value", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("ViewMenu", Red_Start);
			MMOODGIODPC().SetFloat("#", Red_End);
			MHBAIEKFBIJ().SetFloat("mapselector.orderby", Green_Start);
			NBPKMLMCHFN.SetFloat(".a", Green_End);
			LNLKMDPHDCC().SetFloat("SetSatelliteInput", Blue_Start);
			LNLKMDPHDCC().SetFloat("_MainTex2", Blue_End);
			CECICEGFHKL().SetFloat("RB", RGB_Start);
			FLOHGDECHHH().SetFloat("PlayerPrefs::Deserialize() parameterContent has ", RGB_End);
			KHCLIAMBBNC().SetVector("[Left]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 699f, 343f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CECICEGFHKL());
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
		SCShader = Shader.Find("The number of objects sent via a PhotonStreamQueue has to be the same each frame");
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
		SCShader = Shader.Find("_ForegroundBlurExtrude");
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
			CFEDGDGBCHE().SetFloat("_TimeX", HBJJOCHGOPH);
			MHBAIEKFBIJ().SetFloat("RestartButton", Red_Start);
			HFBJAOFLCJI().SetFloat("x", Red_End);
			KHCLIAMBBNC().SetFloat("&page=", Green_Start);
			FLOHGDECHHH().SetFloat("MissesText", Green_End);
			AELJLBOJAIL().SetFloat("_ScreenResolution", Blue_Start);
			HNICHJCGJOC().SetFloat("plainText", Blue_End);
			OJMHIMIPKME().SetFloat("_BlurTexture", RGB_Start);
			OJMHIMIPKME().SetFloat("_InternalLutTex", RGB_End);
			MHBAIEKFBIJ().SetVector("UI Extensions/UIScreen", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1117f, 1321f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OCHJIMJNEMO());
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
			KOHGPKOFEJO().SetFloat(".lastCheckpoint.maxLongestCombo", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat("_MainTex2", Red_Start);
			CFEDGDGBCHE().SetFloat("GlassesColor", Red_End);
			HNICHJCGJOC().SetFloat("#no", Green_Start);
			OCHJIMJNEMO().SetFloat("_Value4", Green_End);
			HNICHJCGJOC().SetFloat("Joystick1Button10", Blue_Start);
			OLHDPICFBOF().SetFloat("/", Blue_End);
			OOMFJGPAOKL().SetFloat("_Color", RGB_Start);
			DONENAMLFLF().SetFloat("_Value4", RGB_End);
			OJMHIMIPKME().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 216f, 770f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
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
			KOHGPKOFEJO().SetFloat("\\", HBJJOCHGOPH);
			ENKPNJMPDEB().SetFloat("threshold", Red_Start);
			OJMHIMIPKME().SetFloat("settings.gamemessagesduration", Red_End);
			KEMJNOMIPHN().SetFloat("_MainTex2", Green_Start);
			MICHFGAOPKM().SetFloat("_Distortion", Green_End);
			LPMLLJKMAMP().SetFloat(" not exist", Blue_Start);
			NLFJGMBCICG().SetFloat("_Value3", Blue_End);
			AELJLBOJAIL().SetFloat("path", RGB_Start);
			HNICHJCGJOC().SetFloat(": ", RGB_End);
			KOHGPKOFEJO().SetVector("x", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1222f, 1928f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
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
