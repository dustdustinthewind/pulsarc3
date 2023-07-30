// CameraFilterPack_Noise_TV
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Noise/TV")]
public class CameraFilterPack_Noise_TV : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 1f)]
	public float Fade = 1f;

	[Range(0f, 10f)]
	private float EOKMJCIDCDB = 1f;

	[Range(0f, 10f)]
	private float ILHJFHFPGBB = 1f;

	[Range(0f, 10f)]
	private float CCIENBFIKKH = 1f;

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

	private void PKBENONAOOL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material GCDFNHMJMIP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-92);
		}
		return BJFKDHHMLJH;
	}

	private void AGDIBDLHMKF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 255f)
			{
				HBJJOCHGOPH = 1253f;
			}
			EBJKJPAIAAM().SetFloat("SpawnObj", HBJJOCHGOPH);
			EBJKJPAIAAM().SetFloat("offline", Fade);
			MFHPKGICPIO().SetFloat("_NoisePerChannel", EOKMJCIDCDB);
			GJHPODJOBHL().SetFloat("CameraFilterPack/3D_Shield", ILHJFHFPGBB);
			IONHGBPGCHK().SetFloat("Outgoing: \n", CCIENBFIKKH);
			DOHGBNPMBKG().SetVector("_OcclusionBlurTexture", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1234f, 1138f));
			DIOAAHJDMLK().SetTexture("skin.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DIOAAHJDMLK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 210f)
			{
				HBJJOCHGOPH = 1811f;
			}
			DIOAAHJDMLK().SetFloat("Reset XP", HBJJOCHGOPH);
			IKBJACCLPCL().SetFloat("LoadMapCanvas", Fade);
			EFDEIFCDAFG().SetFloat("[PlayerController] ", EOKMJCIDCDB);
			IONHGBPGCHK().SetFloat("RecieveChatMessage", ILHJFHFPGBB);
			GKILCDHJFEG().SetFloat("DPADVER", CCIENBFIKKH);
			GJHPODJOBHL().SetVector("Joystick1Button8", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1901f, 4f));
			KJMECMIGJJA().SetTexture(";", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IKBJACCLPCL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material CECICEGFHKL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void IABLKKAALGI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 739f)
			{
				HBJJOCHGOPH = 809f;
			}
			EHDJJANLINB().SetFloat("#tryagain", HBJJOCHGOPH);
			DIOAAHJDMLK().SetFloat("player.bluebat", Fade);
			MCDGIILBNIF().SetFloat("_TimeX", EOKMJCIDCDB);
			EHDJJANLINB().SetFloat("_TimeX", ILHJFHFPGBB);
			GCDFNHMJMIP().SetFloat("HightScoreMaxPointsText", CCIENBFIKKH);
			ILKALHDJBFE().SetVector("Particles/Additive", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1067f, 990f));
			IKBJACCLPCL().SetTexture("_Blend", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HJGEHJDMCGI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OPIBJIMIOKE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 628f)
			{
				HBJJOCHGOPH = 322f;
			}
			PDEAHJPOMEF().SetFloat("mapid", HBJJOCHGOPH);
			DOHGBNPMBKG().SetFloat("_ScreenResolution", Fade);
			CECICEGFHKL().SetFloat("_MainTex2", EOKMJCIDCDB);
			IONHGBPGCHK().SetFloat("_Value3", ILHJFHFPGBB);
			BAGICADFBAB().SetFloat("_Value2", CCIENBFIKKH);
			DABHAJNHOAL().SetVector("LevelConfigButton", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 896f, 1073f));
			DOHGBNPMBKG().SetTexture("ReconnectAndRejoin() failed. It seems the client wasn't connected to a game server before (no address).", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NKFDNIAKGEO()
	{
		FPHEBLMINDA = Resources.Load("_TimeX") as Texture2D;
		SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FJNJIHCLODK()
	{
	}

	private void LFBGJIIECLD()
	{
		FPHEBLMINDA = Resources.Load("health") as Texture2D;
		SCShader = Shader.Find("VeryHigh");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 734f)
			{
				HBJJOCHGOPH = 62f;
			}
			MCDGIILBNIF().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("CameraFilterPack_Glasses_On5", Fade);
			IKAIDLJKLFC().SetFloat("STICKRHOR", EOKMJCIDCDB);
			CECICEGFHKL().SetFloat("MenuScene", ILHJFHFPGBB);
			IKAIDLJKLFC().SetFloat("Vertical", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("CameraFilterPack/Blend2Camera_LinearDodge", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1104f, 850f));
			KJMECMIGJJA().SetTexture(":", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ILKALHDJBFE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material ILKALHDJBFE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IKBJACCLPCL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)113;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material MFHPKGICPIO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void FGBDGGCBFLP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GNJDKAECPKA()
	{
		FPHEBLMINDA = Resources.Load("settings.disablestoryboard") as Texture2D;
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EODOHEAKJFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material DABHAJNHOAL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-72);
		}
		return BJFKDHHMLJH;
	}

	private void JKBMKPDGCHG()
	{
		FPHEBLMINDA = Resources.Load("OpGetGameList not sent. LobbyType must be SqlLobby.") as Texture2D;
		SCShader = Shader.Find("[TextSaver] Text saved to ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material JFDGLLEOPGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)111;
		}
		return BJFKDHHMLJH;
	}

	private void IFIHBNJKEKD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FNCDAPDOBBI()
	{
		FPHEBLMINDA = Resources.Load("/") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/FX_Hexagon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
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
			NBPKMLMCHFN.SetFloat("_Value", Fade);
			NBPKMLMCHFN.SetFloat("_Value2", EOKMJCIDCDB);
			NBPKMLMCHFN.SetFloat("_Value3", ILHJFHFPGBB);
			NBPKMLMCHFN.SetFloat("_Value4", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			NBPKMLMCHFN.SetTexture("Texture2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JNALDALAJLG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KMEONPMCNJG()
	{
	}

	[SpecialName]
	private Material MCDGIILBNIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)127;
		}
		return BJFKDHHMLJH;
	}

	private void JHLGHODFJOO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NJHJHBOJKIC()
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-105);
		}
		return BJFKDHHMLJH;
	}

	private void ICDBMJKMIKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NEFHGMNAPEP()
	{
		FPHEBLMINDA = Resources.Load("[NetworkManager] Updating rooms...") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Distortion_BlackHole");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FDNONDCGGCG()
	{
		FPHEBLMINDA = Resources.Load("[PlayerController] ") as Texture2D;
		SCShader = Shader.Find("[MenuScene] Inited");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GIGMHPHPCHJ()
	{
		FPHEBLMINDA = Resources.Load("[NetworkManager] Joined room with ") as Texture2D;
		SCShader = Shader.Find("STICKRHOR");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ONMGIPAILOH()
	{
	}

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-92);
		}
		return BJFKDHHMLJH;
	}

	private void HLHJBJGEEEA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BNLENEDAHHL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MNBPNHNAEBK()
	{
		FPHEBLMINDA = Resources.Load("BitsData") as Texture2D;
		SCShader = Shader.Find("ArcsDestroyDelaySlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PNNPDMHLFHE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GKNKIIEALCH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ICILLMAKLMI()
	{
		FPHEBLMINDA = Resources.Load("_Distortion") as Texture2D;
		SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EHCGBJDFMHG()
	{
	}

	private void OFPPIKHNJOD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EIMNPCMHJLJ()
	{
		FPHEBLMINDA = Resources.Load(".lastCheckpoint.playerdistance") as Texture2D;
		SCShader = Shader.Find("mapselector.lastSearch");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void COMNAPAAPDO()
	{
	}

	private void KNBJBNDGCIJ()
	{
		FPHEBLMINDA = Resources.Load("event") as Texture2D;
		SCShader = Shader.Find(".lastCheckpoint.powerupsScore");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1840f)
			{
				HBJJOCHGOPH = 128f;
			}
			MCDGIILBNIF().SetFloat("Uploading content...", HBJJOCHGOPH);
			EBJKJPAIAAM().SetFloat("CameraFilterPack/Drawing_Laplacian", Fade);
			EBJKJPAIAAM().SetFloat("ConfigVersionSlider", EOKMJCIDCDB);
			PDEAHJPOMEF().SetFloat("Coroutine container not configured... did you forget to call Init?", ILHJFHFPGBB);
			GJHPODJOBHL().SetFloat("Object ID. Case-Sensitive", CCIENBFIKKH);
			BAGICADFBAB().SetVector("[LobbyPlayerElement] Created lpe for ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1758f, 571f));
			PDEAHJPOMEF().SetTexture("OxOD.lastPath", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MBLDJEFBLFL()
	{
	}

	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 694f)
			{
				HBJJOCHGOPH = 1120f;
			}
			MCDGIILBNIF().SetFloat("_Value6", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("SetParticlesGravity", Fade);
			ILKALHDJBFE().SetFloat("_NoiseAmount", EOKMJCIDCDB);
			DOHGBNPMBKG().SetFloat("settings.selectormapsperpage", ILHJFHFPGBB);
			GCDFNHMJMIP().SetFloat("CameraFilterPack/3D_Myst", CCIENBFIKKH);
			HJGEHJDMCGI().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1211f, 1304f));
			IONHGBPGCHK().SetTexture("_TimeX", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ABEIEGDHBNO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EDDPLJGKLKJ()
	{
	}

	private void FLKEJJEGCFA()
	{
		FPHEBLMINDA = Resources.Load("DPADVER") as Texture2D;
		SCShader = Shader.Find("Mask texture not readable, set your sprite to Texture Type 'Advanced' and check 'Read/Write Enabled'");
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
			if (HBJJOCHGOPH > 921f)
			{
				HBJJOCHGOPH = 1605f;
			}
			ILKALHDJBFE().SetFloat("DISTORT", HBJJOCHGOPH);
			LELKBCALFCF().SetFloat("menutheme.jamaicanorcdub", Fade);
			EBJKJPAIAAM().SetFloat("[RanksSystem] Ranks updated. Next update: ", EOKMJCIDCDB);
			DOHGBNPMBKG().SetFloat(",", ILHJFHFPGBB);
			LELKBCALFCF().SetFloat("_MidGrey", CCIENBFIKKH);
			PDEAHJPOMEF().SetVector("ViewMenu", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 984f, 703f));
			MCDGIILBNIF().SetTexture("PunRespawn with Position.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HEBOIFKBLGD()
	{
	}

	private void PKGJJFIFLII()
	{
	}

	private void OKLAJINHPAN()
	{
		FPHEBLMINDA = Resources.Load("[ItemsHandler] Inventory not changed") as Texture2D;
		SCShader = Shader.Find("RoomPlayersCountText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void Start()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_TV_Noise") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Noise_TV");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material EBJKJPAIAAM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void OEIBFOHPOPD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MKFLBEGJJDC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CPCDFMMLHLO()
	{
	}

	private void IEFMONDKKJN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material ADAFMBOGPLN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1900f)
			{
				HBJJOCHGOPH = 956f;
			}
			DABHAJNHOAL().SetFloat("TwoHands", HBJJOCHGOPH);
			IKAIDLJKLFC().SetFloat("_TintColor", Fade);
			IKBJACCLPCL().SetFloat("#", EOKMJCIDCDB);
			PDEAHJPOMEF().SetFloat(": ", ILHJFHFPGBB);
			EBJKJPAIAAM().SetFloat(";", CCIENBFIKKH);
			EFDEIFCDAFG().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1285f, 1971f));
			EBJKJPAIAAM().SetTexture("{0}", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FBPHNEJBDJN()
	{
		FPHEBLMINDA = Resources.Load("CompletedLevel") as Texture2D;
		SCShader = Shader.Find("Joystick1Button0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-78);
		}
		return BJFKDHHMLJH;
	}

	private void BMGPBIBPBLA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1788f)
			{
				HBJJOCHGOPH = 1088f;
			}
			BAGICADFBAB().SetFloat("MenuScene", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("] Suggested ", Fade);
			EFDEIFCDAFG().SetFloat("challenges.", EOKMJCIDCDB);
			ILKALHDJBFE().SetFloat("No Dispatcher exists in the scene. Actions will not be invoked!", ILHJFHFPGBB);
			EFDEIFCDAFG().SetFloat("_Level", CCIENBFIKKH);
			GCDFNHMJMIP().SetVector("blue", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 361f, 933f));
			IKAIDLJKLFC().SetTexture("PopulateMapsList", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IKAIDLJKLFC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1026f)
			{
				HBJJOCHGOPH = 339f;
			}
			ADAFMBOGPLN().SetFloat("skin.", HBJJOCHGOPH);
			LELKBCALFCF().SetFloat("_ScreenResolution", Fade);
			ILKALHDJBFE().SetFloat("Value", EOKMJCIDCDB);
			PDEAHJPOMEF().SetFloat("_ScreenResolution", ILHJFHFPGBB);
			IKBJACCLPCL().SetFloat("_Color2", CCIENBFIKKH);
			CECICEGFHKL().SetVector("RarityImage", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1250f, 1678f));
			DOHGBNPMBKG().SetTexture("_VelocityTex", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADAFMBOGPLN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material EFDEIFCDAFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.HideInHierarchy;
		}
		return BJFKDHHMLJH;
	}

	private void EKCJHNJGGAB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 126f)
			{
				HBJJOCHGOPH = 1702f;
			}
			IKBJACCLPCL().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("PLEASE WAIT", Fade);
			IONHGBPGCHK().SetFloat("threshold", EOKMJCIDCDB);
			IKBJACCLPCL().SetFloat("Other", ILHJFHFPGBB);
			LELKBCALFCF().SetFloat("set id", CCIENBFIKKH);
			MCDGIILBNIF().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1409f, 422f));
			BAGICADFBAB().SetTexture("CameraFilterPack/FX_Glitch2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1266f)
			{
				HBJJOCHGOPH = 233f;
			}
			DABHAJNHOAL().SetFloat("mainmenu", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat("STICKRHOR", Fade);
			DIOAAHJDMLK().SetFloat("skin.", EOKMJCIDCDB);
			IKAIDLJKLFC().SetFloat("Tab1Content", ILHJFHFPGBB);
			GJHPODJOBHL().SetFloat("UseScanLine", CCIENBFIKKH);
			PDEAHJPOMEF().SetVector("JoinButton", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1214f, 220f));
			GKILCDHJFEG().SetTexture("inventory.selected.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material BAGICADFBAB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-107);
		}
		return BJFKDHHMLJH;
	}

	private void LFAFJKJAEEL()
	{
		FPHEBLMINDA = Resources.Load("Selection Box") as Texture2D;
		SCShader = Shader.Find("x");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EFJDNLGNACH()
	{
		FPHEBLMINDA = Resources.Load("/") as Texture2D;
		SCShader = Shader.Find("Using constructor for new PingNativeDynamic()");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DOOIKOEBBJB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 428f)
			{
				HBJJOCHGOPH = 96f;
			}
			BAGICADFBAB().SetFloat("ConnectUsingSettings() failed. Can only connect while in state 'Disconnected'. Current state: ", HBJJOCHGOPH);
			ILKALHDJBFE().SetFloat("menu.playedsolo", Fade);
			LELKBCALFCF().SetFloat("ERROR", EOKMJCIDCDB);
			GKILCDHJFEG().SetFloat("#done", ILHJFHFPGBB);
			DIOAAHJDMLK().SetFloat("_Distortion", CCIENBFIKKH);
			IONHGBPGCHK().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 53f, 601f));
			JFDGLLEOPGB().SetTexture("Reconnect() disabled the offline mode. No longer offline.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IKBJACCLPCL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FABMDEHEDNO()
	{
	}

	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 578f)
			{
				HBJJOCHGOPH = 1488f;
			}
			ADAFMBOGPLN().SetFloat("x", HBJJOCHGOPH);
			ILKALHDJBFE().SetFloat("SetParticlesGravity", Fade);
			ILKALHDJBFE().SetFloat("#yes", EOKMJCIDCDB);
			CECICEGFHKL().SetFloat("#challengecomplete", ILHJFHFPGBB);
			EBJKJPAIAAM().SetFloat("_Value3", CCIENBFIKKH);
			DIOAAHJDMLK().SetVector("_DistAmount", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 65f, 476f));
			IKAIDLJKLFC().SetTexture("ConnectToMaster() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHPODJOBHL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PCHCFIOHIKK()
	{
		FPHEBLMINDA = Resources.Load(">") as Texture2D;
		SCShader = Shader.Find("). ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ODGMCJILIHF()
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
			if (HBJJOCHGOPH > 1460f)
			{
				HBJJOCHGOPH = 483f;
			}
			DOHGBNPMBKG().SetFloat("#ok", HBJJOCHGOPH);
			ADAFMBOGPLN().SetFloat("_Blue_C", Fade);
			HJGEHJDMCGI().SetFloat("PLEASE WAIT", EOKMJCIDCDB);
			EBJKJPAIAAM().SetFloat("visible", ILHJFHFPGBB);
			NBPKMLMCHFN.SetFloat("_DistortionSize", CCIENBFIKKH);
			PDEAHJPOMEF().SetVector("downloading", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 412f, 715f));
			IKAIDLJKLFC().SetTexture("inventory.selected.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BAGICADFBAB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1403f)
			{
				HBJJOCHGOPH = 739f;
			}
			KJMECMIGJJA().SetFloat("value", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("CameraFilterPack/TV_LED", Fade);
			DABHAJNHOAL().SetFloat("event", EOKMJCIDCDB);
			EHDJJANLINB().SetFloat("Sprite", ILHJFHFPGBB);
			DOHGBNPMBKG().SetFloat("VisionBlur", CCIENBFIKKH);
			PDEAHJPOMEF().SetVector("_EmissionColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1382f, 1793f));
			IONHGBPGCHK().SetTexture("SetSatelliteRotationSpeed", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DIOAAHJDMLK());
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
			if (HBJJOCHGOPH > 1291f)
			{
				HBJJOCHGOPH = 1128f;
			}
			GCDFNHMJMIP().SetFloat("SetSatelliteTrailWidth", HBJJOCHGOPH);
			DABHAJNHOAL().SetFloat(" not exist", Fade);
			MFHPKGICPIO().SetFloat("_Factor", EOKMJCIDCDB);
			GJHPODJOBHL().SetFloat("_Distortion", ILHJFHFPGBB);
			DOHGBNPMBKG().SetFloat("\\n", CCIENBFIKKH);
			IKBJACCLPCL().SetVector("LevelNameInputField", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1863f, 1507f));
			IONHGBPGCHK().SetTexture("_Circle", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MMOKKAPFGAK()
	{
		FPHEBLMINDA = Resources.Load("Editor/") as Texture2D;
		SCShader = Shader.Find("[BuildInfo] Error: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material DOHGBNPMBKG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void FMHOHGEAIEA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GPNAOAKCMHC()
	{
		FPHEBLMINDA = Resources.Load("_TimeX") as Texture2D;
		SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GNPDGBNDCPL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OMFBGCMHNBM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BLKGOMCPEKI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material IKAIDLJKLFC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void ODBNMPGBCGO()
	{
		FPHEBLMINDA = Resources.Load("_MainTex2") as Texture2D;
		SCShader = Shader.Find("_Extra");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IKIDIJLIGOH()
	{
	}

	private void FAKGFMFAPDG()
	{
	}

	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 769f)
			{
				HBJJOCHGOPH = 1843f;
			}
			ILKALHDJBFE().SetFloat("EnableRankingToggle", HBJJOCHGOPH);
			BAGICADFBAB().SetFloat("_Value3", Fade);
			LELKBCALFCF().SetFloat("_MidGrey", EOKMJCIDCDB);
			DABHAJNHOAL().SetFloat("Joystick1Button3", ILHJFHFPGBB);
			GJHPODJOBHL().SetFloat("[ItemsHandler] Inventory has changed", CCIENBFIKKH);
			MFHPKGICPIO().SetVector("_Blue_G", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 931f, 1624f));
			EBJKJPAIAAM().SetTexture("player", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OCCGJMPAJIK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1922f)
			{
				HBJJOCHGOPH = 1489f;
			}
			PDEAHJPOMEF().SetFloat("In Main Menu", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("isVisible", Fade);
			KJMECMIGJJA().SetFloat("CameraFilterPack/Blend2Camera_Hue", EOKMJCIDCDB);
			BAGICADFBAB().SetFloat("[MapEditor] Exported to ", ILHJFHFPGBB);
			DIOAAHJDMLK().SetFloat("RPC: 'OnAwakeRPC' Parameter: ", CCIENBFIKKH);
			ILKALHDJBFE().SetVector("ServerSettings: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1389f, 473f));
			EFDEIFCDAFG().SetTexture("Xbox Home", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HJGEHJDMCGI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HJGEHJDMCGI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material EHDJJANLINB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-113);
		}
		return BJFKDHHMLJH;
	}

	private void ALNNIDLFILB()
	{
		FPHEBLMINDA = Resources.Load("BadgeText") as Texture2D;
		SCShader = Shader.Find(";");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 911f)
			{
				HBJJOCHGOPH = 2f;
			}
			MCDGIILBNIF().SetFloat("Please specify a map name or buildID", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("event", Fade);
			EHDJJANLINB().SetFloat("distance", EOKMJCIDCDB);
			PDEAHJPOMEF().SetFloat("OPEN", ILHJFHFPGBB);
			EHDJJANLINB().SetFloat("menu.selectedlevelid", CCIENBFIKKH);
			EHDJJANLINB().SetVector("CameraFilterPack/Vision_Drost", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1059f, 792f));
			GCDFNHMJMIP().SetTexture("Write me to get one for testing :)", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FOMNCPKKCFN()
	{
	}

	private void IHLMNAGPKDA()
	{
		FPHEBLMINDA = Resources.Load("on master") as Texture2D;
		SCShader = Shader.Find("BitsData");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MPJCMKFFKHH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1837f)
			{
				HBJJOCHGOPH = 638f;
			}
			EHDJJANLINB().SetFloat("_Value7", HBJJOCHGOPH);
			EHDJJANLINB().SetFloat("_TimeX", Fade);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Drawing_Crosshatch", EOKMJCIDCDB);
			HJGEHJDMCGI().SetFloat("#getrewardfailed: ", ILHJFHFPGBB);
			LELKBCALFCF().SetFloat("Set Particle Size", CCIENBFIKKH);
			LELKBCALFCF().SetVector("SetParticlesParticleSize", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 300f, 148f));
			KJMECMIGJJA().SetTexture(" GO:", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BOPKKCAFODF()
	{
		FPHEBLMINDA = Resources.Load("[PlayerBase] Game mode: ") as Texture2D;
		SCShader = Shader.Find("ResetSpeed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 164f)
			{
				HBJJOCHGOPH = 1649f;
			}
			GKILCDHJFEG().SetFloat("threshold", HBJJOCHGOPH);
			IKAIDLJKLFC().SetFloat("Mid", Fade);
			NBPKMLMCHFN.SetFloat("ExitGames.Client.Photon.SocketWebTcp, Assembly-CSharp", EOKMJCIDCDB);
			GKILCDHJFEG().SetFloat("D-Pad Left", ILHJFHFPGBB);
			IKAIDLJKLFC().SetFloat("NEW_ACHIEVEMENT_1_21", CCIENBFIKKH);
			EHDJJANLINB().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 747f, 225f));
			PDEAHJPOMEF().SetTexture("_Green_R", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ILKALHDJBFE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CNDACAHCCOI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ANCKKLFPGDI()
	{
		FPHEBLMINDA = Resources.Load("_ScreenResolution") as Texture2D;
		SCShader = Shader.Find("/icon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material LELKBCALFCF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void ABIOAMNCEOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 948f)
			{
				HBJJOCHGOPH = 1032f;
			}
			KJMECMIGJJA().SetFloat("maps.", HBJJOCHGOPH);
			ILKALHDJBFE().SetFloat(">", Fade);
			GCDFNHMJMIP().SetFloat("PlayMapsSeriesGoal", EOKMJCIDCDB);
			KJMECMIGJJA().SetFloat("GenerationMenu", ILHJFHFPGBB);
			ILKALHDJBFE().SetFloat("offsets", CCIENBFIKKH);
			EBJKJPAIAAM().SetVector("SettingsCanvas", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 481f, 1461f));
			MFHPKGICPIO().SetTexture("Changed config", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IKBJACCLPCL());
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

	private void JFJLGJEPEAA()
	{
		FPHEBLMINDA = Resources.Load("player.currentrank") as Texture2D;
		SCShader = Shader.Find(" | ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material GJHPODJOBHL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)116;
		}
		return BJFKDHHMLJH;
	}

	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 785f)
			{
				HBJJOCHGOPH = 202f;
			}
			EBJKJPAIAAM().SetFloat("#news", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat("No Name", Fade);
			EFDEIFCDAFG().SetFloat("id", EOKMJCIDCDB);
			DABHAJNHOAL().SetFloat("#ok", ILHJFHFPGBB);
			ADAFMBOGPLN().SetFloat("_Red_B", CCIENBFIKKH);
			DOHGBNPMBKG().SetVector("D-Pad Down", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 941f, 523f));
			NBPKMLMCHFN.SetTexture("< true | false >", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LELKBCALFCF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BKGJOECFMID()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AGEJKLMJGDO()
	{
		FPHEBLMINDA = Resources.Load("_ScreenResolution") as Texture2D;
		SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AEIJFLJEABG()
	{
	}

	private void JEBIBKLHFLB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MECJHOJPODB()
	{
	}

	private void PHJJHFBLICM()
	{
	}

	private void MANDOGNJJBD()
	{
	}

	private void DKGBFNCOAEO()
	{
		FPHEBLMINDA = Resources.Load("_Threshhold") as Texture2D;
		SCShader = Shader.Find("\n\n#");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material KJMECMIGJJA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 268f)
			{
				HBJJOCHGOPH = 1653f;
			}
			DABHAJNHOAL().SetFloat("_FullResolutionFiltering", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat("hidden", Fade);
			EBJKJPAIAAM().SetFloat(".lastCheckpoint.correctScore", EOKMJCIDCDB);
			IKBJACCLPCL().SetFloat("Value", ILHJFHFPGBB);
			GKILCDHJFEG().SetFloat("catched: ", CCIENBFIKKH);
			MCDGIILBNIF().SetVector("[", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 188f, 192f));
			DABHAJNHOAL().SetTexture("SaveGameName is null or empty!", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IKAIDLJKLFC());
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
			if (HBJJOCHGOPH > 1657f)
			{
				HBJJOCHGOPH = 245f;
			}
			EBJKJPAIAAM().SetFloat("_MainTex2", HBJJOCHGOPH);
			BAGICADFBAB().SetFloat("Items/", Fade);
			DOHGBNPMBKG().SetFloat("Right", EOKMJCIDCDB);
			DOHGBNPMBKG().SetFloat(" on effect ", ILHJFHFPGBB);
			EFDEIFCDAFG().SetFloat("Joystick1Button6", CCIENBFIKKH);
			PDEAHJPOMEF().SetVector("ItemNameBGImage", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1558f, 416f));
			DABHAJNHOAL().SetTexture("ChangeSelectedLevel", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 995f)
			{
				HBJJOCHGOPH = 424f;
			}
			EHDJJANLINB().SetFloat("BitsData", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat("SelectorMusicToggle", Fade);
			MFHPKGICPIO().SetFloat("_Value4", EOKMJCIDCDB);
			IONHGBPGCHK().SetFloat("_ScreenResolution", ILHJFHFPGBB);
			CECICEGFHKL().SetFloat(".played", CCIENBFIKKH);
			PDEAHJPOMEF().SetVector("shader.frost", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 188f, 923f));
			ILKALHDJBFE().SetTexture("float,1", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LELKBCALFCF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1843f)
			{
				HBJJOCHGOPH = 545f;
			}
			KJMECMIGJJA().SetFloat("Joystick1Button4", HBJJOCHGOPH);
			BAGICADFBAB().SetFloat("HighScaleShot", Fade);
			PDEAHJPOMEF().SetFloat("Using WebSocket to connect NameServer (AuthMode is AuthOnceWss).", EOKMJCIDCDB);
			KJMECMIGJJA().SetFloat("_Distortion", ILHJFHFPGBB);
			IKAIDLJKLFC().SetFloat("maps.", CCIENBFIKKH);
			EHDJJANLINB().SetVector("STICKLHOR", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 452f, 1786f));
			IONHGBPGCHK().SetTexture("DifficultyBG", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void INLDEHPAMJC()
	{
	}

	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1503f)
			{
				HBJJOCHGOPH = 1222f;
			}
			DABHAJNHOAL().SetFloat("UndoButton", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("CameraFilterPack/TV_Chromatical2", Fade);
			HJGEHJDMCGI().SetFloat("_BlurRadius4", EOKMJCIDCDB);
			IKAIDLJKLFC().SetFloat("null", ILHJFHFPGBB);
			ILKALHDJBFE().SetFloat("_ScreenResolution", CCIENBFIKKH);
			HJGEHJDMCGI().SetVector("Object ID. Case-Sensitive", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 462f, 1997f));
			HJGEHJDMCGI().SetTexture("inventory.lastitemscount", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DIOAAHJDMLK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void DDFCIOMKEEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 541f)
			{
				HBJJOCHGOPH = 737f;
			}
			GKILCDHJFEG().SetFloat("ArcsNoHitsoundTimeDelaySlider", HBJJOCHGOPH);
			DOHGBNPMBKG().SetFloat("1.87", Fade);
			ILKALHDJBFE().SetFloat("_NeighbourMaxTex", EOKMJCIDCDB);
			LELKBCALFCF().SetFloat("SetCrosshairEmission", ILHJFHFPGBB);
			DIOAAHJDMLK().SetFloat(".icon", CCIENBFIKKH);
			GCDFNHMJMIP().SetVector("menu.selectedplaymode", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1669f, 1392f));
			DIOAAHJDMLK().SetTexture("_Value2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CECICEGFHKL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FKDEEJFNNJC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GPHPJIDGEPI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GEHINELAGBI()
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

	private void NCPAFCKGJEA()
	{
	}

	private void Update()
	{
	}

	private void NDAJBJFJGCF()
	{
	}

	private void KCCIEMBMOBA()
	{
		FPHEBLMINDA = Resources.Load("_ScreenResolution") as Texture2D;
		SCShader = Shader.Find(" (now: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DLMPALHKMON()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BGDPIHMAACO()
	{
		FPHEBLMINDA = Resources.Load("_TimeX") as Texture2D;
		SCShader = Shader.Find("In Network lobby");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1232f)
			{
				HBJJOCHGOPH = 25f;
			}
			NBPKMLMCHFN.SetFloat("_FarCamera", HBJJOCHGOPH);
			HJGEHJDMCGI().SetFloat("\" that takes ", Fade);
			DIOAAHJDMLK().SetFloat("achievements.21.completed.workshop.", EOKMJCIDCDB);
			IONHGBPGCHK().SetFloat("_Metrics", ILHJFHFPGBB);
			IKBJACCLPCL().SetFloat("_TimeX", CCIENBFIKKH);
			GKILCDHJFEG().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1808f, 763f));
			DIOAAHJDMLK().SetTexture("SteamManager", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LJIHHJOAJCN()
	{
	}

	private void MOMHHBKAGKG()
	{
	}
}
