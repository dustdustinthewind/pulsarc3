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
			ILKALHDJBFE().SetFloat("SpawnObj", HBJJOCHGOPH);
			DABHAJNHOAL().SetFloat("on master", Fade);
			MFHPKGICPIO().SetFloat("_MidGrey", EOKMJCIDCDB);
			LELKBCALFCF().SetFloat("CameraFilterPack/3D_Shield", ILHJFHFPGBB);
			KJMECMIGJJA().SetFloat("{0}\n{1}\n{2}\n{3}\n{4}\n{5}", CCIENBFIKKH);
			BAGICADFBAB().SetVector("_BlurVector", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1234f, 1138f));
			ILKALHDJBFE().SetTexture(".icon", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EHDJJANLINB());
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
			ILKALHDJBFE().SetFloat("Reload Maps", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("#alreadyexist", Fade);
			BAGICADFBAB().SetFloat(": ", EOKMJCIDCDB);
			GCDFNHMJMIP().SetFloat("RecieveChatMessage", ILHJFHFPGBB);
			IONHGBPGCHK().SetFloat("DPADVER", CCIENBFIKKH);
			PDEAHJPOMEF().SetVector("Joystick1Button9", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1901f, 4f));
			DABHAJNHOAL().SetTexture(";", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
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
			DOHGBNPMBKG().SetFloat("#exit", HBJJOCHGOPH);
			DABHAJNHOAL().SetFloat("player.goldbat", Fade);
			PDEAHJPOMEF().SetFloat("Value", EOKMJCIDCDB);
			MFHPKGICPIO().SetFloat("_Value", ILHJFHFPGBB);
			IKAIDLJKLFC().SetFloat("PossibleMapPointsText", CCIENBFIKKH);
			HJGEHJDMCGI().SetVector("Particles/Additive", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1067f, 990f));
			DABHAJNHOAL().SetTexture("_Intensity", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IKBJACCLPCL());
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
			GKILCDHJFEG().SetFloat("gamemode", HBJJOCHGOPH);
			ILKALHDJBFE().SetFloat("CameraFilterPack/Distortion_BlackHole", Fade);
			GJHPODJOBHL().SetFloat("_TimeX", EOKMJCIDCDB);
			EFDEIFCDAFG().SetFloat("_Value3", ILHJFHFPGBB);
			KJMECMIGJJA().SetFloat("_Value3", CCIENBFIKKH);
			DOHGBNPMBKG().SetVector("LevelConfigButton", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 896f, 1073f));
			ADAFMBOGPLN().SetTexture("ConnectToBestCloudServer() failed. Can only connect while in state 'Disconnected'. Current state: ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NKFDNIAKGEO()
	{
		FPHEBLMINDA = Resources.Load("_TimeX") as Texture2D;
		SCShader = Shader.Find("[LobbyPlayerElement] Created lpe for ");
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
		FPHEBLMINDA = Resources.Load("{0}sec average:") as Texture2D;
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
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Sharpen_Sharpen", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("CameraFilterPack/Glasses_On", Fade);
			IONHGBPGCHK().SetFloat("Alpha", EOKMJCIDCDB);
			BAGICADFBAB().SetFloat("MenuScene", ILHJFHFPGBB);
			CECICEGFHKL().SetFloat(" | ", CCIENBFIKKH);
			IONHGBPGCHK().SetVector("CameraFilterPack/Blend2Camera_LinearDodge", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1104f, 850f));
			JFDGLLEOPGB().SetTexture(" ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CECICEGFHKL());
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
		FPHEBLMINDA = Resources.Load("SelectorMusicToggle") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/BlurHole");
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
		FPHEBLMINDA = Resources.Load("OpSetPropertiesOfActor not sent. ActorNr must be > 0 and actorProperties != null.") as Texture2D;
		SCShader = Shader.Find("/");
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
		FPHEBLMINDA = Resources.Load("[MapEditor] Loaded music file: ") as Texture2D;
		SCShader = Shader.Find("_TimeX");
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
		FPHEBLMINDA = Resources.Load(" not exist") as Texture2D;
		SCShader = Shader.Find("Loading...");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GIGMHPHPCHJ()
	{
		FPHEBLMINDA = Resources.Load("[NetworkManager] Joined room with ") as Texture2D;
		SCShader = Shader.Find("Alpha");
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
		FPHEBLMINDA = Resources.Load("_Size") as Texture2D;
		SCShader = Shader.Find(".");
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
		FPHEBLMINDA = Resources.Load(".") as Texture2D;
		SCShader = Shader.Find("back");
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
		FPHEBLMINDA = Resources.Load("Added event") as Texture2D;
		SCShader = Shader.Find(".lastCheckpoint.perfectHits");
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
			EFDEIFCDAFG().SetFloat("Item invalid. No idea why.", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat("CameraFilterPack/Drawing_Laplacian", Fade);
			EHDJJANLINB().SetFloat("Tab2Content", EOKMJCIDCDB);
			MCDGIILBNIF().SetFloat("ScrollPanel", ILHJFHFPGBB);
			CECICEGFHKL().SetFloat("Object ID. Case-Sensitive", CCIENBFIKKH);
			CECICEGFHKL().SetVector("[LobbyPlayerElement] On ready click", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1758f, 571f));
			MFHPKGICPIO().SetTexture("OPEN", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CECICEGFHKL());
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
			HJGEHJDMCGI().SetFloat("_Value6", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("AddEnvironmentSprite", Fade);
			CECICEGFHKL().SetFloat("_NoiseTex", EOKMJCIDCDB);
			IKBJACCLPCL().SetFloat("settings.enableranking", ILHJFHFPGBB);
			BAGICADFBAB().SetFloat("CameraFilterPack/3D_Myst", CCIENBFIKKH);
			DABHAJNHOAL().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1211f, 1304f));
			DABHAJNHOAL().SetTexture("UseFinalGlassColor", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
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
		SCShader = Shader.Find("UI Extensions/UIAdditive");
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
			BAGICADFBAB().SetFloat("_BlurPass", HBJJOCHGOPH);
			BAGICADFBAB().SetFloat("menutheme.deleted", Fade);
			PDEAHJPOMEF().SetFloat("[RanksSystem] Ranks: no need to update", EOKMJCIDCDB);
			GJHPODJOBHL().SetFloat(".completedCount", ILHJFHFPGBB);
			MCDGIILBNIF().SetFloat("_NoiseTex", CCIENBFIKKH);
			IONHGBPGCHK().SetVector("EditMenu", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 984f, 703f));
			NBPKMLMCHFN.SetTexture("RespawnAfter", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
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
		FPHEBLMINDA = Resources.Load("[ItemsHandler] Inventory has changed") as Texture2D;
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
			DOHGBNPMBKG().SetFloat("BitsData", HBJJOCHGOPH);
			IKBJACCLPCL().SetFloat("_LensDirtIntensity", Fade);
			LELKBCALFCF().SetFloat(",viewkeys", EOKMJCIDCDB);
			HJGEHJDMCGI().SetFloat(" not exist", ILHJFHFPGBB);
			NBPKMLMCHFN.SetFloat(";", CCIENBFIKKH);
			GJHPODJOBHL().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1285f, 1971f));
			NBPKMLMCHFN.SetTexture("#yes", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FBPHNEJBDJN()
	{
		FPHEBLMINDA = Resources.Load("settings.gamemessagesduration") as Texture2D;
		SCShader = Shader.Find("Joystick1Button1");
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
			IKAIDLJKLFC().SetFloat("Bad modpack name: {0}", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat("\n", Fade);
			EBJKJPAIAAM().SetFloat(".message", EOKMJCIDCDB);
			GKILCDHJFEG().SetFloat("No Dispatcher exists in the scene. Actions will not be invoked!", ILHJFHFPGBB);
			MCDGIILBNIF().SetFloat("_Level", CCIENBFIKKH);
			PDEAHJPOMEF().SetVector("0,1,false", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 361f, 933f));
			IONHGBPGCHK().SetTexture("EventSystem", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ILKALHDJBFE());
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
			CECICEGFHKL().SetFloat("Yes", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat("CameraFilterPack/Distortion_Lens", Fade);
			MFHPKGICPIO().SetFloat(" x ", EOKMJCIDCDB);
			PDEAHJPOMEF().SetFloat("CameraFilterPack/Drawing_Manga_FlashWhite", ILHJFHFPGBB);
			IONHGBPGCHK().SetFloat("_Color2", CCIENBFIKKH);
			IONHGBPGCHK().SetVector("rarity", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1250f, 1678f));
			JFDGLLEOPGB().SetTexture("_History1LumaTex", FPHEBLMINDA);
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
			DABHAJNHOAL().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			EBJKJPAIAAM().SetFloat("Submition failed", Fade);
			EHDJJANLINB().SetFloat("_AdaptTex", EOKMJCIDCDB);
			ADAFMBOGPLN().SetFloat("Other", ILHJFHFPGBB);
			KJMECMIGJJA().SetFloat("set id", CCIENBFIKKH);
			CECICEGFHKL().SetVector("DifficultyBG", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1409f, 422f));
			ADAFMBOGPLN().SetTexture("_TimeX", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ILKALHDJBFE());
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
			EFDEIFCDAFG().SetFloat("mainmenu", HBJJOCHGOPH);
			EBJKJPAIAAM().SetFloat("STICKRVER", Fade);
			NBPKMLMCHFN.SetFloat("No", EOKMJCIDCDB);
			GCDFNHMJMIP().SetFloat("resource", ILHJFHFPGBB);
			BAGICADFBAB().SetFloat("_MainTex2", CCIENBFIKKH);
			DOHGBNPMBKG().SetVector("JoinButton", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1214f, 220f));
			NBPKMLMCHFN.SetTexture("inventory.selected.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LELKBCALFCF());
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
		FPHEBLMINDA = Resources.Load("GUICamera") as Texture2D;
		SCShader = Shader.Find("w");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EFJDNLGNACH()
	{
		FPHEBLMINDA = Resources.Load(".sawoutdatedmessage") as Texture2D;
		SCShader = Shader.Find("wss://");
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
			LELKBCALFCF().SetFloat("ConnectUsingSettings() disabled the offline mode. No longer offline.", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("menu.playedpage", Fade);
			DABHAJNHOAL().SetFloat("steamid", EOKMJCIDCDB);
			CECICEGFHKL().SetFloat("/", ILHJFHFPGBB);
			BAGICADFBAB().SetFloat("_Size", CCIENBFIKKH);
			PDEAHJPOMEF().SetVector("CameraFilterPack/Drawing_Curve", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 53f, 601f));
			EBJKJPAIAAM().SetTexture("ReconnectAndRejoin() disabled the offline mode. No longer offline.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
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
			GJHPODJOBHL().SetFloat("float,1", HBJJOCHGOPH);
			IKBJACCLPCL().SetFloat("Set Particles Gravity", Fade);
			HJGEHJDMCGI().SetFloat("#ok", EOKMJCIDCDB);
			DABHAJNHOAL().SetFloat("<command>", ILHJFHFPGBB);
			LELKBCALFCF().SetFloat("_Value3", CCIENBFIKKH);
			EHDJJANLINB().SetVector("_ChromaticAberration", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 65f, 476f));
			IKBJACCLPCL().SetTexture("Reconnect() failed. It seems the client wasn't connected before?! Current state: ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PCHCFIOHIKK()
	{
		FPHEBLMINDA = Resources.Load("</color>") as Texture2D;
		SCShader = Shader.Find("SupportLogger OnDisconnectedFromPhoton().");
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
			HJGEHJDMCGI().SetFloat("#tryagain", HBJJOCHGOPH);
			CECICEGFHKL().SetFloat("_Blue_C", Fade);
			GKILCDHJFEG().SetFloat("PLEASE WAIT", EOKMJCIDCDB);
			ADAFMBOGPLN().SetFloat("open", ILHJFHFPGBB);
			ADAFMBOGPLN().SetFloat("_DistortionSize", CCIENBFIKKH);
			CECICEGFHKL().SetVector("downloading", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 412f, 715f));
			EBJKJPAIAAM().SetTexture("inventory.selected.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LELKBCALFCF());
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
			IKAIDLJKLFC().SetFloat("value", HBJJOCHGOPH);
			IKAIDLJKLFC().SetFloat("_TimeX", Fade);
			CECICEGFHKL().SetFloat("BitsData", EOKMJCIDCDB);
			ADAFMBOGPLN().SetFloat("/", ILHJFHFPGBB);
			CECICEGFHKL().SetFloat("GlassDistortion", CCIENBFIKKH);
			EFDEIFCDAFG().SetVector("_EmissionGain", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1382f, 1793f));
			KJMECMIGJJA().SetTexture("SetSatelliteRotationSpeed", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BAGICADFBAB());
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
			EBJKJPAIAAM().SetFloat("SetCrosshairEmission", HBJJOCHGOPH);
			HJGEHJDMCGI().SetFloat(" not exist", Fade);
			GCDFNHMJMIP().SetFloat("_Factor", EOKMJCIDCDB);
			DABHAJNHOAL().SetFloat("_ScreenResolution", ILHJFHFPGBB);
			GCDFNHMJMIP().SetFloat("[EMPTY]", CCIENBFIKKH);
			KJMECMIGJJA().SetVector("Tab1Content", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1863f, 1507f));
			GKILCDHJFEG().SetTexture("_ScreenResolution", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DIOAAHJDMLK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MMOKKAPFGAK()
	{
		FPHEBLMINDA = Resources.Load("Sprite") as Texture2D;
		SCShader = Shader.Find("\nv.");
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
		SCShader = Shader.Find("_Extra2");
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
			GKILCDHJFEG().SetFloat("EnableRankingToggle", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat("_Value4", Fade);
			LELKBCALFCF().SetFloat("_NoiseTex", EOKMJCIDCDB);
			GKILCDHJFEG().SetFloat("Triangle", ILHJFHFPGBB);
			LELKBCALFCF().SetFloat("inventory.itemscash", CCIENBFIKKH);
			ILKALHDJBFE().SetVector("_Blue_G", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 931f, 1624f));
			MCDGIILBNIF().SetTexture("Connecting", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LELKBCALFCF());
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
			GJHPODJOBHL().SetFloat("NetworkCanvas", HBJJOCHGOPH);
			EBJKJPAIAAM().SetFloat("isVisible", Fade);
			BAGICADFBAB().SetFloat("CameraFilterPack/Blend2Camera_Saturation", EOKMJCIDCDB);
			JFDGLLEOPGB().SetFloat("Editor/", ILHJFHFPGBB);
			BAGICADFBAB().SetFloat("Mine", CCIENBFIKKH);
			IKAIDLJKLFC().SetVector(".", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1389f, 473f));
			IKAIDLJKLFC().SetTexture("X", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
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
		SCShader = Shader.Find("|");
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
			MCDGIILBNIF().SetFloat(". Name: ", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("Added event", Fade);
			DIOAAHJDMLK().SetFloat("distance", EOKMJCIDCDB);
			MFHPKGICPIO().SetFloat("/../", ILHJFHFPGBB);
			ADAFMBOGPLN().SetFloat("menu.selectedlevelid", CCIENBFIKKH);
			DOHGBNPMBKG().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1059f, 792f));
			HJGEHJDMCGI().SetTexture("Updating...", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHPODJOBHL());
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
		FPHEBLMINDA = Resources.Load("OpLeaveLobby()") as Texture2D;
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
			DOHGBNPMBKG().SetFloat("_PColor2", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("_TimeX", Fade);
			IKAIDLJKLFC().SetFloat("_TimeX", EOKMJCIDCDB);
			DABHAJNHOAL().SetFloat("http", ILHJFHFPGBB);
			IONHGBPGCHK().SetFloat("id", CCIENBFIKKH);
			HJGEHJDMCGI().SetVector("SetParticlesInput", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 300f, 148f));
			GJHPODJOBHL().SetTexture("\" to target: ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BOPKKCAFODF()
	{
		FPHEBLMINDA = Resources.Load("Items/") as Texture2D;
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
			MCDGIILBNIF().SetFloat("useSrcAlphaAsMask", HBJJOCHGOPH);
			LELKBCALFCF().SetFloat("Mid", Fade);
			ILKALHDJBFE().SetFloat("Protocol switch from: ", EOKMJCIDCDB);
			DIOAAHJDMLK().SetFloat("settings_bindings_", ILHJFHFPGBB);
			EBJKJPAIAAM().SetFloat("achievements.21.progress", CCIENBFIKKH);
			GCDFNHMJMIP().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 747f, 225f));
			CECICEGFHKL().SetTexture("_Green_R", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DABHAJNHOAL());
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
		SCShader = Shader.Find("icon");
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
			DABHAJNHOAL().SetFloat("[GameEvent] Exeption:", HBJJOCHGOPH);
			LELKBCALFCF().SetFloat("#TBD", Fade);
			CECICEGFHKL().SetFloat(".status", EOKMJCIDCDB);
			ADAFMBOGPLN().SetFloat("ViewMenu", ILHJFHFPGBB);
			JFDGLLEOPGB().SetFloat("_HrDepthTex", CCIENBFIKKH);
			GCDFNHMJMIP().SetVector("ShadersToggle", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 481f, 1461f));
			KJMECMIGJJA().SetTexture("[Down]", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DIOAAHJDMLK());
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
		SCShader = Shader.Find("<color=white>");
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
			GCDFNHMJMIP().SetFloat("#news", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("No Name", Fade);
			GKILCDHJFEG().SetFloat("Object ID. Case-Sensitive", EOKMJCIDCDB);
			JFDGLLEOPGB().SetFloat("#ok", ILHJFHFPGBB);
			BAGICADFBAB().SetFloat("_Green_R", CCIENBFIKKH);
			DABHAJNHOAL().SetVector("D-Pad Right", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 941f, 523f));
			MCDGIILBNIF().SetTexture("Print the list of scenes, avalable in game.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
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
		FPHEBLMINDA = Resources.Load("CameraFilterPack/Gradients_Therma") as Texture2D;
		SCShader = Shader.Find("SetSpeed");
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
		FPHEBLMINDA = Resources.Load("_TapMedium") as Texture2D;
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
			IKAIDLJKLFC().SetFloat("_HighlightSuppression", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("'{0}' \t{1}ms \t{2}", Fade);
			EHDJJANLINB().SetFloat(".lastCheckpoint.checkpointsUsed", EOKMJCIDCDB);
			DABHAJNHOAL().SetFloat("Fade", ILHJFHFPGBB);
			JFDGLLEOPGB().SetFloat("Can't set visible when not in that room.", CCIENBFIKKH);
			EBJKJPAIAAM().SetVector("] Suggested ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 188f, 192f));
			JFDGLLEOPGB().SetTexture(" is set to dontSave = true, continuing loop.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HJGEHJDMCGI());
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
			CECICEGFHKL().SetFloat("Items/", Fade);
			GCDFNHMJMIP().SetFloat("Right ", EOKMJCIDCDB);
			GJHPODJOBHL().SetFloat("Missing shader in ", ILHJFHFPGBB);
			GJHPODJOBHL().SetFloat("Joystick1Button7", CCIENBFIKKH);
			JFDGLLEOPGB().SetVector("ItemNameText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1558f, 416f));
			LELKBCALFCF().SetTexture("ChangeSelectedLevel", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DIOAAHJDMLK());
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
			ADAFMBOGPLN().SetFloat("BitsData", HBJJOCHGOPH);
			ADAFMBOGPLN().SetFloat("SelectorMusicToggle", Fade);
			HJGEHJDMCGI().SetFloat("_ScreenResolution", EOKMJCIDCDB);
			KJMECMIGJJA().SetFloat("CameraFilterPack/Drawing_Manga_Flash_Color", ILHJFHFPGBB);
			KJMECMIGJJA().SetFloat("music.ogg", CCIENBFIKKH);
			GJHPODJOBHL().SetVector("shader.frost", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 188f, 923f));
			HJGEHJDMCGI().SetTexture("z", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			EHDJJANLINB().SetFloat("Joystick1Button5", HBJJOCHGOPH);
			IKBJACCLPCL().SetFloat("Coroutine container not configured... did you forget to call Init?", Fade);
			DIOAAHJDMLK().SetFloat("ExitGames.Client.Photon.SocketWebTcp, Assembly-CSharp-firstpass", EOKMJCIDCDB);
			EBJKJPAIAAM().SetFloat("_Noise", ILHJFHFPGBB);
			MFHPKGICPIO().SetFloat("#yes", CCIENBFIKKH);
			DIOAAHJDMLK().SetVector("STICKRHOR", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 452f, 1786f));
			ILKALHDJBFE().SetTexture("InfoText", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHPODJOBHL());
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
			IKAIDLJKLFC().SetFloat("RedoButton", HBJJOCHGOPH);
			DIOAAHJDMLK().SetFloat("_TimeX", Fade);
			GJHPODJOBHL().SetFloat("_SunColor", EOKMJCIDCDB);
			GCDFNHMJMIP().SetFloat("{0}\t is: {1}", ILHJFHFPGBB);
			JFDGLLEOPGB().SetFloat("_ScreenResolution", CCIENBFIKKH);
			CECICEGFHKL().SetVector("value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 462f, 1997f));
			NBPKMLMCHFN.SetTexture("[ItemsHandler] No connection to item server: ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
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
			ILKALHDJBFE().SetFloat("settings.arcsnohitsoundtimedelay", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("HostType: {0} ", Fade);
			DOHGBNPMBKG().SetFloat("_TileTexDebug", EOKMJCIDCDB);
			HJGEHJDMCGI().SetFloat("SetCrosshairEmission", ILHJFHFPGBB);
			ILKALHDJBFE().SetFloat("Write me to get one for testing :)", CCIENBFIKKH);
			BAGICADFBAB().SetVector("menu.selectedplaymode", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1669f, 1392f));
			EBJKJPAIAAM().SetTexture("_Value2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHPODJOBHL());
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
		FPHEBLMINDA = Resources.Load("CameraFilterPack/Drawing_Lines") as Texture2D;
		SCShader = Shader.Find(" now: ");
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
		FPHEBLMINDA = Resources.Load("_Value") as Texture2D;
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
			PDEAHJPOMEF().SetFloat("_FarCamera", HBJJOCHGOPH);
			ADAFMBOGPLN().SetFloat(". Should be just one?", Fade);
			NBPKMLMCHFN.SetFloat("achievements.21.progress", EOKMJCIDCDB);
			HJGEHJDMCGI().SetFloat("_Params2", ILHJFHFPGBB);
			DABHAJNHOAL().SetFloat("_TimeX", CCIENBFIKKH);
			CECICEGFHKL().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1808f, 763f));
			DABHAJNHOAL().SetTexture("[Steamworks.NET] Packsize Test returned false, the wrong version of Steamworks.NET is being run in this platform.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DIOAAHJDMLK());
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
