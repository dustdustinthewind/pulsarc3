// CameraFilterPack_Drawing_Paper
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Drawing/Paper")]
[ExecuteInEditMode]
public class CameraFilterPack_Drawing_Paper : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	public Color Pencil_Color = new Color(0.156f, 0.3f, 0.738f, 1f);

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

	private void GNPDGBNDCPL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material OGMEGHKECAH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void NFBPKPPECMC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material JDMJJGEHMJO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)67;
		}
		return BJFKDHHMLJH;
	}

	private void PHJLHCMCCKE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 8f)
			{
				HBJJOCHGOPH = 1103f;
			}
			KOHGPKOFEJO().SetFloat("_ScratchTex", HBJJOCHGOPH);
			EMDFHOKEGNG().SetColor("ResetSpeed", Pencil_Color);
			NBPKMLMCHFN.SetFloat("&map=", Pencil_Size);
			FKEOGPDLBDD().SetFloat("yes", Pencil_Correction);
			KGOLDDBHIFN().SetFloat(" | Level: ", Intensity);
			FLGPDBBKAIP().SetFloat("SupportLogger OnJoinedLobby(", Speed_Animation);
			NBPKMLMCHFN.SetFloat("[PlayerBase] Starting game from: ", Corner_Lose);
			OIIDAKBILMI().SetFloat("|", Fade_Paper_to_BackColor);
			NBMPPNFKFLB().SetFloat("USE_UV_BASED_REPROJECTION", Fade_With_Original);
			ILKALHDJBFE().SetColor("There is already a virtual axis named ", Back_Color);
			HKGAONMOBMH().SetTexture("steamid", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LEIAFCPJMDP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AOKOLPEGHDD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CGDMLHLJIDK()
	{
		FPHEBLMINDA = Resources.Load("_Value4") as Texture2D;
		SCShader = Shader.Find("[ItemsHandler] Found ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1278f)
			{
				HBJJOCHGOPH = 148f;
			}
			OGMEGHKECAH().SetFloat("PhotonNetwork.room is null. You don't have to call LeaveRoom() when you're not in one. State: ", HBJJOCHGOPH);
			FLGPDBBKAIP().SetColor("_MainTex2", Pencil_Color);
			LPMLLJKMAMP().SetFloat("_TimeX", Pencil_Size);
			FNAFGEMJBDA().SetFloat("_Value2", Pencil_Correction);
			DEFBJOCJJKF().SetFloat("_Value2", Intensity);
			KOHGPKOFEJO().SetFloat("_Value3", Speed_Animation);
			LPMLLJKMAMP().SetFloat("menutheme.jamaicanorcdub", Corner_Lose);
			MCDGIILBNIF().SetFloat("CameraFilterPack/Glasses_On", Fade_Paper_to_BackColor);
			KOHGPKOFEJO().SetFloat("OpLeaveLobby()", Fade_With_Original);
			ILKALHDJBFE().SetColor("_Value2", Back_Color);
			HKGAONMOBMH().SetTexture("Committing changes...", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KNBJBNDGCIJ()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack/FX_Glitch1") as Texture2D;
		SCShader = Shader.Find("MenuScene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AAEEHINDPNC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material EMDFHOKEGNG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void MIKOICBNGPI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EKPLGFAEOBE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LKBOEPPBLIF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1879f)
			{
				HBJJOCHGOPH = 1058f;
			}
			FKEOGPDLBDD().SetFloat("Connection error: ", HBJJOCHGOPH);
			LEIAFCPJMDP().SetColor("LoadingStatusText", Pencil_Color);
			LPMLLJKMAMP().SetFloat("[LevelEditorScene] Print Audio Wave: Done", Pencil_Size);
			KGOLDDBHIFN().SetFloat("shader.frost", Pencil_Correction);
			JDMJJGEHMJO().SetFloat(" - LOCAL", Intensity);
			PLBEJJIHFPB().SetFloat("RaiseEvent() failed. Your event is not being sent! Check if your are in a Room and the eventCode must be less than 200 (0..199).", Speed_Animation);
			FNAFGEMJBDA().SetFloat("CameraFilterPack/Blend2Camera_SplitScreen3D", Corner_Lose);
			PLBEJJIHFPB().SetFloat("Myst_Color", Fade_Paper_to_BackColor);
			LEIAFCPJMDP().SetFloat("player.goldbat", Fade_With_Original);
			HKGAONMOBMH().SetColor("_LutTex", Back_Color);
			CECICEGFHKL().SetTexture("Tab2Content", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLGPDBBKAIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HLLHJIDOOGA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LKMIFJEBIEC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 669f)
			{
				HBJJOCHGOPH = 690f;
			}
			MCDGIILBNIF().SetFloat("maps.", HBJJOCHGOPH);
			EMDFHOKEGNG().SetColor("Connected to masterserver.", Pencil_Color);
			JDMJJGEHMJO().SetFloat("_Value", Pencil_Size);
			LPDOGGFOBDH().SetFloat("_TimeX", Pencil_Correction);
			FNAFGEMJBDA().SetFloat("_RgbTex", Intensity);
			HKGAONMOBMH().SetFloat("Couldn't call DestroyAll() as only the master client is allowed to call this.", Speed_Animation);
			DCCHGBHLAAF().SetFloat("_EmissionColor", Corner_Lose);
			NBMPPNFKFLB().SetFloat("CameraFilterPack/RainFX", Fade_Paper_to_BackColor);
			LPDOGGFOBDH().SetFloat("/", Fade_With_Original);
			CECICEGFHKL().SetColor("ChatInput", Back_Color);
			FLGPDBBKAIP().SetTexture("Custom Authentication failed (either due to user-input or configuration or AuthParameter string format). Calling: OnCustomAuthenticationFailed()", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HIKKPDACJGI()
	{
	}

	private void HMKBLLMIKAB()
	{
	}

	private void HPFIHLMKIPF()
	{
		FPHEBLMINDA = Resources.Load("[MapsEditor] Creating new item...") as Texture2D;
		SCShader = Shader.Find("_NeutralTonemapperParams1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NHHCGPAMLAJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ALNNIDLFILB()
	{
		FPHEBLMINDA = Resources.Load("_Value4") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/FX_Psycho");
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
			if (HBJJOCHGOPH > 1835f)
			{
				HBJJOCHGOPH = 1875f;
			}
			CECICEGFHKL().SetFloat("1", HBJJOCHGOPH);
			MCDGIILBNIF().SetColor("Player Connected", Pencil_Color);
			FNAFGEMJBDA().SetFloat("_MainTex2", Pencil_Size);
			JDMJJGEHMJO().SetFloat("CameraFilterPack/Drawing_CellShading2", Pencil_Correction);
			DOHGBNPMBKG().SetFloat("ls", Intensity);
			OIIDAKBILMI().SetFloat("_Radius", Speed_Animation);
			HKGAONMOBMH().SetFloat("_ColorLevel", Corner_Lose);
			OGMEGHKECAH().SetFloat("_Min", Fade_Paper_to_BackColor);
			FNAFGEMJBDA().SetFloat("_Value3", Fade_With_Original);
			LPMLLJKMAMP().SetColor(". Check if the server is available.", Back_Color);
			NBPKMLMCHFN.SetTexture("Reconnect() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BKIGIIINEDH()
	{
		FPHEBLMINDA = Resources.Load("mapselector.filter.subscribedonly") as Texture2D;
		SCShader = Shader.Find("note.6");
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

	private void JKFDDNMPOJH()
	{
		FPHEBLMINDA = Resources.Load("_Value3") as Texture2D;
		SCShader = Shader.Find("_BlurVector");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void COIJKMKIEAK()
	{
		FPHEBLMINDA = Resources.Load("_ScreenResolution") as Texture2D;
		SCShader = Shader.Find("Search: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FKEJGBFDCAH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HAIAHJPCPAG()
	{
		FPHEBLMINDA = Resources.Load("[PlayerBase] Loading checkpoint data") as Texture2D;
		SCShader = Shader.Find("_Y");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KHIGHFJKPFG()
	{
		FPHEBLMINDA = Resources.Load("source") as Texture2D;
		SCShader = Shader.Find("Misses:");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material DOHGBNPMBKG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material MJJIEHANFJA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)118;
		}
		return BJFKDHHMLJH;
	}

	private void IPJFFIDBPFE()
	{
		FPHEBLMINDA = Resources.Load("Environment/SunBase_") as Texture2D;
		SCShader = Shader.Find("BestScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GMELGGJOPBB()
	{
	}

	private void BLKGOMCPEKI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LBAJLLFMMMP()
	{
		FPHEBLMINDA = Resources.Load("NEW_ACHIEVEMENT_1_21") as Texture2D;
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PLEOOAJIMEE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 816f)
			{
				HBJJOCHGOPH = 1399f;
			}
			ILKALHDJBFE().SetFloat("JoinButton", HBJJOCHGOPH);
			KOHGPKOFEJO().SetColor("_Value", Pencil_Color);
			LPMLLJKMAMP().SetFloat("AudioSampler", Pencil_Size);
			PLBEJJIHFPB().SetFloat("menu.playedsolo", Pencil_Correction);
			DCCHGBHLAAF().SetFloat("2hands", Intensity);
			EMDFHOKEGNG().SetFloat("Tab2Content", Speed_Animation);
			JDMJJGEHMJO().SetFloat("Uploading content", Corner_Lose);
			EMDFHOKEGNG().SetFloat("_ScreenResolution", Fade_Paper_to_BackColor);
			KGOLDDBHIFN().SetFloat("[MapEditor] Updating top menu", Fade_With_Original);
			CECICEGFHKL().SetColor(": ", Back_Color);
			PLBEJJIHFPB().SetTexture(":\n", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LEIAFCPJMDP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Start()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_Paper1") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Drawing_Paper");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PLBOFEPBPKC()
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
			if (HBJJOCHGOPH > 1610f)
			{
				HBJJOCHGOPH = 288f;
			}
			NBPKMLMCHFN.SetFloat("_FadeDistance", HBJJOCHGOPH);
			OPMDBHHACME().SetColor(" : ", Pencil_Color);
			NBMPPNFKFLB().SetFloat("ready", Pencil_Size);
			NBMPPNFKFLB().SetFloat("View ({3}){0} on {1} {2}", Pencil_Correction);
			PLBEJJIHFPB().SetFloat(",", Intensity);
			DOHGBNPMBKG().SetFloat("GlassDistortion", Speed_Animation);
			OPMDBHHACME().SetFloat("[Down]", Corner_Lose);
			DOHGBNPMBKG().SetFloat("HandleEventLeave for player ID: ", Fade_Paper_to_BackColor);
			DOHGBNPMBKG().SetFloat("MaxLivesSlider", Fade_With_Original);
			OPMDBHHACME().SetColor("Item ", Back_Color);
			PLBEJJIHFPB().SetTexture("hidden", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FNAFGEMJBDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IHLMNAGPKDA()
	{
		FPHEBLMINDA = Resources.Load("_Visualize") as Texture2D;
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ECBILENEOOL()
	{
		FPHEBLMINDA = Resources.Load("_FarCamera") as Texture2D;
		SCShader = Shader.Find(". Possible scene loading in progress?");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ALMGMOOHLMA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FANADGBGCPI()
	{
		FPHEBLMINDA = Resources.Load("#tryagain") as Texture2D;
		SCShader = Shader.Find("Editor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MAOCOEGAFND()
	{
	}

	private void DLMPALHKMON()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DDFCIOMKEEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1017f)
			{
				HBJJOCHGOPH = 71f;
			}
			ILKALHDJBFE().SetFloat("Dance", HBJJOCHGOPH);
			LEIAFCPJMDP().SetColor("Bad parameters for set! Use <language>", Pencil_Color);
			MCDGIILBNIF().SetFloat("Default UI Material", Pencil_Size);
			ILKALHDJBFE().SetFloat(". This client's player: ", Pencil_Correction);
			MCDGIILBNIF().SetFloat("_SpawnHeuristic", Intensity);
			OGMEGHKECAH().SetFloat(". Check if the server is available.", Speed_Animation);
			DCCHGBHLAAF().SetFloat("_Offset", Corner_Lose);
			JDMJJGEHMJO().SetFloat("_ScreenResolution", Fade_Paper_to_BackColor);
			DEFBJOCJJKF().SetFloat("_Value4", Fade_With_Original);
			OIIDAKBILMI().SetColor("_SceneFogMode", Back_Color);
			OPMDBHHACME().SetTexture("maps.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HGDDCINLDAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material DCCHGBHLAAF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.HideInInspector | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material LPDOGGFOBDH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void LINKAMEPKGM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IHHNCCOGLPN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1399f)
			{
				HBJJOCHGOPH = 1853f;
			}
			OGMEGHKECAH().SetFloat("ViewMenu", HBJJOCHGOPH);
			CECICEGFHKL().SetColor("Metal", Pencil_Color);
			MCDGIILBNIF().SetFloat(",", Pencil_Size);
			BKKJJJGADLM().SetFloat("SfxVolumeSlider", Pencil_Correction);
			NBPKMLMCHFN.SetFloat("ws://", Intensity);
			CECICEGFHKL().SetFloat("\\n", Speed_Animation);
			KOHGPKOFEJO().SetFloat("_TimeX", Corner_Lose);
			DCCHGBHLAAF().SetFloat("menu.enableselectormusic", Fade_Paper_to_BackColor);
			KGOLDDBHIFN().SetFloat("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception", Fade_With_Original);
			CECICEGFHKL().SetColor("LevelEditor/CustomEventEditor-Text", Back_Color);
			LPDOGGFOBDH().SetTexture("CameraFilterPack/TV_BrokenGlass", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BKKJJJGADLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CPAJLKHMOJB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FJABOCDLCAI()
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

	private void ICILLMAKLMI()
	{
		FPHEBLMINDA = Resources.Load("settings.selectormapsperpage") as Texture2D;
		SCShader = Shader.Find("_Intensity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IDJKNBDKHBD()
	{
		FPHEBLMINDA = Resources.Load(" argument(s): ") as Texture2D;
		SCShader = Shader.Find("DPADHOR");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KMEONPMCNJG()
	{
	}

	private void DOOIKOEBBJB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1488f)
			{
				HBJJOCHGOPH = 1133f;
			}
			PLBEJJIHFPB().SetFloat("maps.", HBJJOCHGOPH);
			LPDOGGFOBDH().SetColor("#yes", Pencil_Color);
			LEIAFCPJMDP().SetFloat("checkpoint", Pencil_Size);
			NBMPPNFKFLB().SetFloat("ENABLE_COLOR_GRADING", Pencil_Correction);
			KGOLDDBHIFN().SetFloat("MenuPlayButton", Intensity);
			ILKALHDJBFE().SetFloat("_Distance", Speed_Animation);
			OPMDBHHACME().SetFloat("JoinOrCreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", Corner_Lose);
			LPMLLJKMAMP().SetFloat(".ogg", Fade_Paper_to_BackColor);
			LEIAFCPJMDP().SetFloat(" ", Fade_With_Original);
			LEIAFCPJMDP().SetColor("max. lives color", Back_Color);
			FNAFGEMJBDA().SetTexture("_Glitch", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material FKEOGPDLBDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-103);
		}
		return BJFKDHHMLJH;
	}

	private void ADPLHDFJFID()
	{
		FPHEBLMINDA = Resources.Load("(master)") as Texture2D;
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material FLGPDBBKAIP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)88;
		}
		return BJFKDHHMLJH;
	}

	private void JOHOFNKJDEB()
	{
		FPHEBLMINDA = Resources.Load("maps.") as Texture2D;
		SCShader = Shader.Find(" does not exist!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EDBEHEKMGFH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MKIMDFLBFOM()
	{
		FPHEBLMINDA = Resources.Load("Gameplay/LobbyPlayerIconElement") as Texture2D;
		SCShader = Shader.Find("_EmissionColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GAOOPEEBGJA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IBFJAOINHMK()
	{
	}

	private void LFBGJIIECLD()
	{
		FPHEBLMINDA = Resources.Load("Ignored PU RPC, cause item is inactive. ") as Texture2D;
		SCShader = Shader.Find("_SSAO");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1229f)
			{
				HBJJOCHGOPH = 1785f;
			}
			OGMEGHKECAH().SetFloat("materialsitemid[", HBJJOCHGOPH);
			LEIAFCPJMDP().SetColor("w", Pencil_Color);
			KOHGPKOFEJO().SetFloat("\n\n#", Pencil_Size);
			LPDOGGFOBDH().SetFloat("System.Int64", Pencil_Correction);
			LPDOGGFOBDH().SetFloat("_FgOverlap", Intensity);
			ILKALHDJBFE().SetFloat("#activechallenges", Speed_Animation);
			OGMEGHKECAH().SetFloat("[PlayerController] ", Corner_Lose);
			MCDGIILBNIF().SetFloat("_Size", Fade_Paper_to_BackColor);
			EMDFHOKEGNG().SetFloat("_Value2", Fade_With_Original);
			EMDFHOKEGNG().SetColor("VeryHigh", Back_Color);
			NBMPPNFKFLB().SetTexture("AuthenticationValues UserId: {0}, GetParameters: {1} Token available: {2}", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LEIAFCPJMDP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MANDOGNJJBD()
	{
	}

	private void CAKNMILHHNE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KOFAMEKHHGD()
	{
		FPHEBLMINDA = Resources.Load("[MapEditor] Reset") as Texture2D;
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 763f)
			{
				HBJJOCHGOPH = 1761f;
			}
			OPMDBHHACME().SetFloat("Currently, the limit of users is reached for this title. Try again later. Disconnecting", HBJJOCHGOPH);
			DOHGBNPMBKG().SetColor("Feb", Pencil_Color);
			FLGPDBBKAIP().SetFloat("_PositionX", Pencil_Size);
			LEIAFCPJMDP().SetFloat(" connected: ", Pencil_Correction);
			KOHGPKOFEJO().SetFloat("_Red_C", Intensity);
			NBPKMLMCHFN.SetFloat("_TimeX", Speed_Animation);
			OIIDAKBILMI().SetFloat("_Value5", Corner_Lose);
			FKEOGPDLBDD().SetFloat("\"", Fade_Paper_to_BackColor);
			MJJIEHANFJA().SetFloat("Joystick1Button4", Fade_With_Original);
			EMDFHOKEGNG().SetColor("value", Back_Color);
			FLGPDBBKAIP().SetTexture("vignetteIntensity", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CECICEGFHKL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HKGAONMOBMH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void KMOCDAOKGLI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 53f)
			{
				HBJJOCHGOPH = 1217f;
			}
			OGMEGHKECAH().SetFloat("GameObject ", HBJJOCHGOPH);
			BKKJJJGADLM().SetColor("The process failed: ", Pencil_Color);
			CECICEGFHKL().SetFloat("menu.resetlevelcheckpoint", Pencil_Size);
			MJJIEHANFJA().SetFloat("Set Crosshair Color", Pencil_Correction);
			KOHGPKOFEJO().SetFloat("checkpoint", Intensity);
			OPMDBHHACME().SetFloat("_Value", Speed_Animation);
			FNAFGEMJBDA().SetFloat("MenuVolumeSlider", Corner_Lose);
			KGOLDDBHIFN().SetFloat("_Fade", Fade_Paper_to_BackColor);
			OGMEGHKECAH().SetFloat("buttons", Fade_With_Original);
			DCCHGBHLAAF().SetColor("#rt", Back_Color);
			KGOLDDBHIFN().SetTexture("RECORD [R]", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DCCHGBHLAAF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LNOOFNGHNEL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1783f)
			{
				HBJJOCHGOPH = 1191f;
			}
			LPDOGGFOBDH().SetFloat("FavoriteButton", HBJJOCHGOPH);
			OGMEGHKECAH().SetColor("https://steamcommunity.com/sharedfiles/filedetails/?id=", Pencil_Color);
			FNAFGEMJBDA().SetFloat("_MainTex", Pencil_Size);
			FKEOGPDLBDD().SetFloat("Lightning", Pencil_Correction);
			JDMJJGEHMJO().SetFloat("_ForceYSwap", Intensity);
			FKEOGPDLBDD().SetFloat("No", Speed_Animation);
			DCCHGBHLAAF().SetFloat("Unsupported target enum: ", Corner_Lose);
			HKGAONMOBMH().SetFloat(": ", Fade_Paper_to_BackColor);
			OPMDBHHACME().SetFloat("offsets", Fade_With_Original);
			PLBEJJIHFPB().SetColor("LoadPlayerEnvironment", Back_Color);
			EMDFHOKEGNG().SetTexture("BackButton", FPHEBLMINDA);
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

	private void AGDIBDLHMKF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 28f)
			{
				HBJJOCHGOPH = 1029f;
			}
			KOHGPKOFEJO().SetFloat("_Value2", HBJJOCHGOPH);
			FKEOGPDLBDD().SetColor("CameraFilterPack/Colors_BleachBypass", Pencil_Color);
			LPMLLJKMAMP().SetFloat("cancel", Pencil_Size);
			NBPKMLMCHFN.SetFloat("bad", Pencil_Correction);
			JDMJJGEHMJO().SetFloat("_ScreenResolution", Intensity);
			DOHGBNPMBKG().SetFloat("{0}={2}: {1} \"{3}\"", Speed_Animation);
			DOHGBNPMBKG().SetFloat("settings.crosshairopacity", Corner_Lose);
			NBMPPNFKFLB().SetFloat("_TimeX", Fade_Paper_to_BackColor);
			OGMEGHKECAH().SetFloat("_FixDistance", Fade_With_Original);
			CECICEGFHKL().SetColor("\nCreated by Oxy949", Back_Color);
			EMDFHOKEGNG().SetTexture("BitsData", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LEIAFCPJMDP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ANKIJGCGCBF()
	{
	}

	private void BEKMLIFILFP()
	{
		FPHEBLMINDA = Resources.Load("_Value6") as Texture2D;
		SCShader = Shader.Find(" not exist");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NFEDLAOPHML()
	{
	}

	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 911f)
			{
				HBJJOCHGOPH = 492f;
			}
			OPMDBHHACME().SetFloat("Object ID", HBJJOCHGOPH);
			LPMLLJKMAMP().SetColor("CameraFilterPack/Blur_Focus", Pencil_Color);
			MCDGIILBNIF().SetFloat("#useticket", Pencil_Size);
			NBPKMLMCHFN.SetFloat("_Value9", Pencil_Correction);
			MCDGIILBNIF().SetFloat("#close", Intensity);
			ILKALHDJBFE().SetFloat("_ScreenResolution", Speed_Animation);
			NBMPPNFKFLB().SetFloat("CameraFilterPack/AAA_Blood_Hit", Corner_Lose);
			DEFBJOCJJKF().SetFloat("Joystick1Button10", Fade_Paper_to_BackColor);
			NBMPPNFKFLB().SetFloat("_DiffuseColor", Fade_With_Original);
			JDMJJGEHMJO().SetColor("_LightIntensity", Back_Color);
			OPMDBHHACME().SetTexture("Joystick1Button5", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ILKALHDJBFE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MMOKKAPFGAK()
	{
		FPHEBLMINDA = Resources.Load("RarityImage") as Texture2D;
		SCShader = Shader.Find(" ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material LPMLLJKMAMP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material FNAFGEMJBDA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.HideInHierarchy | HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void NAOLAJPDGIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OHFOLGANOLC()
	{
		FPHEBLMINDA = Resources.Load("Drop_Near") as Texture2D;
		SCShader = Shader.Find(".lastCheckpoint.playerdistance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NEKCPLGFOFD()
	{
	}

	private void POJFHDFJOPE()
	{
	}

	private void KLCAJPOCMPF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 361f)
			{
				HBJJOCHGOPH = 1413f;
			}
			DOHGBNPMBKG().SetFloat("VIGNETTE_DESAT", HBJJOCHGOPH);
			BKKJJJGADLM().SetColor("' was created: ", Pencil_Color);
			CECICEGFHKL().SetFloat("type", Pencil_Size);
			NBPKMLMCHFN.SetFloat(" cannot be used as a 3D LUT.", Pencil_Correction);
			OIIDAKBILMI().SetFloat("[MapsData] Found ", Intensity);
			DOHGBNPMBKG().SetFloat(" not exist", Speed_Animation);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/FX_Hexagon_Black", Corner_Lose);
			EMDFHOKEGNG().SetFloat("_TimeX", Fade_Paper_to_BackColor);
			FKEOGPDLBDD().SetFloat("_ScreenResolution", Fade_With_Original);
			ILKALHDJBFE().SetColor("MapEditor v.", Back_Color);
			ILKALHDJBFE().SetTexture("help", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLGPDBBKAIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OFIMMFHFHDD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material BKKJJJGADLM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-104);
		}
		return BJFKDHHMLJH;
	}

	private void OBAEDJJDCPN()
	{
	}

	[SpecialName]
	private Material OPMDBHHACME()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material CECICEGFHKL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KGOLDDBHIFN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void OOGIHDLBBLM()
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

	[SpecialName]
	private Material ILKALHDJBFE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)106;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material DEFBJOCJJKF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-83);
		}
		return BJFKDHHMLJH;
	}

	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 20f)
			{
				HBJJOCHGOPH = 1337f;
			}
			BKKJJJGADLM().SetFloat("CountEventsGoal", HBJJOCHGOPH);
			FKEOGPDLBDD().SetColor("(\\[ */ *i *\\])", Pencil_Color);
			BKKJJJGADLM().SetFloat("LevelConfigButton", Pencil_Size);
			PLBEJJIHFPB().SetFloat("UseScanLineSize", Pencil_Correction);
			FLGPDBBKAIP().SetFloat(". The group number should be at least 1.", Intensity);
			NBMPPNFKFLB().SetFloat("Clear Environment", Speed_Animation);
			DOHGBNPMBKG().SetFloat("CameraFilterPack/TV_Video3D", Corner_Lose);
			HKGAONMOBMH().SetFloat("#8E8E8EFF", Fade_Paper_to_BackColor);
			OPMDBHHACME().SetFloat("_Value4", Fade_With_Original);
			FNAFGEMJBDA().SetColor(" - {0}", Back_Color);
			FLGPDBBKAIP().SetTexture("GameScene", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EDPDMBFLHLP()
	{
		FPHEBLMINDA = Resources.Load(" : ") as Texture2D;
		SCShader = Shader.Find(") but there is no recycle bin setup for it");
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
			if (HBJJOCHGOPH > 1546f)
			{
				HBJJOCHGOPH = 1062f;
			}
			DCCHGBHLAAF().SetFloat("IEnumerable", HBJJOCHGOPH);
			NBMPPNFKFLB().SetColor("3;4;9;10;21x6", Pencil_Color);
			DCCHGBHLAAF().SetFloat("_MotionBlurTmpCam", Pencil_Size);
			NBMPPNFKFLB().SetFloat("[MapsData] Found ", Pencil_Correction);
			CECICEGFHKL().SetFloat("ShowTitle", Intensity);
			OPMDBHHACME().SetFloat("[LevelEditorScene] Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(", Speed_Animation);
			LPMLLJKMAMP().SetFloat("_Axis", Corner_Lose);
			LPMLLJKMAMP().SetFloat("<b>Kick player by NetID</b>\nuse: /kick {NetID}\nUse \"/players\" command to get all NetIDs\nRoom owner only can kick the players", Fade_Paper_to_BackColor);
			LPMLLJKMAMP().SetFloat("#forever", Fade_With_Original);
			NBMPPNFKFLB().SetColor("LowMid", Back_Color);
			OIIDAKBILMI().SetTexture("Up ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CECICEGFHKL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	private void CHOPDIGHJNH()
	{
		FPHEBLMINDA = Resources.Load("speed") as Texture2D;
		SCShader = Shader.Find("_Glow");
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
			BJFKDHHMLJH.hideFlags = (HideFlags)88;
		}
		return BJFKDHHMLJH;
	}

	private void IEMEHGCFAPD()
	{
	}

	private void KDMKDEKCELE()
	{
		FPHEBLMINDA = Resources.Load("SetBGColor") as Texture2D;
		SCShader = Shader.Find("_FixDistance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1265f)
			{
				HBJJOCHGOPH = 479f;
			}
			FLGPDBBKAIP().SetFloat("x", HBJJOCHGOPH);
			LPDOGGFOBDH().SetColor("https://bitbucket.org/khb-soft/intralismarcsviewer/", Pencil_Color);
			JDMJJGEHMJO().SetFloat("VisionBlur", Pencil_Size);
			PLBEJJIHFPB().SetFloat("IntraSig", Pencil_Correction);
			CECICEGFHKL().SetFloat("In Network lobby", Intensity);
			CECICEGFHKL().SetFloat("player.xp", Speed_Animation);
			MCDGIILBNIF().SetFloat("_TimeX", Corner_Lose);
			ILKALHDJBFE().SetFloat("No peer to communicate with. ", Fade_Paper_to_BackColor);
			HKGAONMOBMH().SetFloat("CameraFilterPack/Oculus_NightVision3", Fade_With_Original);
			ILKALHDJBFE().SetColor("CameraFilterPack/Vision_Plasma", Back_Color);
			FKEOGPDLBDD().SetTexture("CameraFilterPack/Drawing_Manga2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FABMDEHEDNO()
	{
	}

	private void CBIBDOIBJAI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1711f)
			{
				HBJJOCHGOPH = 182f;
			}
			LEIAFCPJMDP().SetFloat("Default color's lerp speed of color changing. Greater values means faster changing. 0 - intant change.", HBJJOCHGOPH);
			OGMEGHKECAH().SetColor("settings.shaders", Pencil_Color);
			LEIAFCPJMDP().SetFloat("_Value3", Pencil_Size);
			OPMDBHHACME().SetFloat("menu.tabid", Pencil_Correction);
			EMDFHOKEGNG().SetFloat("_TimeX", Intensity);
			NBPKMLMCHFN.SetFloat("0.00", Speed_Animation);
			CECICEGFHKL().SetFloat("\t", Corner_Lose);
			DOHGBNPMBKG().SetFloat("float", Fade_Paper_to_BackColor);
			OGMEGHKECAH().SetFloat("DPADVER", Fade_With_Original);
			DOHGBNPMBKG().SetColor("Item invalid. No idea why.", Back_Color);
			JDMJJGEHMJO().SetTexture("menutheme.hunter", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HCIPECAOGIA()
	{
	}

	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 872f)
			{
				HBJJOCHGOPH = 1533f;
			}
			MCDGIILBNIF().SetFloat("skin.hit_perfect", HBJJOCHGOPH);
			JDMJJGEHMJO().SetColor("_Value4", Pencil_Color);
			FNAFGEMJBDA().SetFloat("_LensDirt", Pencil_Size);
			BKKJJJGADLM().SetFloat("_ScreenResolution", Pencil_Correction);
			MCDGIILBNIF().SetFloat("Up", Intensity);
			JDMJJGEHMJO().SetFloat("MenuScene", Speed_Animation);
			KGOLDDBHIFN().SetFloat("_Glow", Corner_Lose);
			JDMJJGEHMJO().SetFloat("\\", Fade_Paper_to_BackColor);
			DCCHGBHLAAF().SetFloat("_ReflectionTexture2", Fade_With_Original);
			BKKJJJGADLM().SetColor("_Value", Back_Color);
			DOHGBNPMBKG().SetTexture("_TimeX", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EIMNPCMHJLJ()
	{
		FPHEBLMINDA = Resources.Load(" By: ") as Texture2D;
		SCShader = Shader.Find("NewMusicFileSelector");
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
			BJFKDHHMLJH.hideFlags = (HideFlags)77;
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

	private void JOPCCCCHNLI()
	{
		FPHEBLMINDA = Resources.Load("_Bullet_1") as Texture2D;
		SCShader = Shader.Find("Fade");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JBNPEHMDCMI()
	{
	}

	[SpecialName]
	private Material LEIAFCPJMDP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)79;
		}
		return BJFKDHHMLJH;
	}

	private void AIJGAJIOJDJ()
	{
	}

	private void KMCPMOGKDEH()
	{
		FPHEBLMINDA = Resources.Load("_Value2") as Texture2D;
		SCShader = Shader.Find("_Amount");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JBMBNKOOENB()
	{
	}

	private void OBDEJFCNOBF()
	{
	}

	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1050f)
			{
				HBJJOCHGOPH = 605f;
			}
			LPDOGGFOBDH().SetFloat("Init", HBJJOCHGOPH);
			LPDOGGFOBDH().SetColor("New resource ID. Case-Sensitive", Pencil_Color);
			MJJIEHANFJA().SetFloat(" joined", Pencil_Size);
			OPMDBHHACME().SetFloat("OK", Pencil_Correction);
			CECICEGFHKL().SetFloat("EventSystem", Intensity);
			FLGPDBBKAIP().SetFloat("<b>(╯°□°）╯︵ ┻━┻</b>", Speed_Animation);
			FLGPDBBKAIP().SetFloat("\n\n#", Corner_Lose);
			JDMJJGEHMJO().SetFloat("L1", Fade_Paper_to_BackColor);
			LPDOGGFOBDH().SetFloat("_MainTex2", Fade_With_Original);
			JDMJJGEHMJO().SetColor("HandsCountSlider", Back_Color);
			DEFBJOCJJKF().SetTexture("CameraFilterPack_AAA_Blood2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BDBJEDIOKBN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FGNFILLNPJK()
	{
	}

	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1041f)
			{
				HBJJOCHGOPH = 88f;
			}
			CECICEGFHKL().SetFloat("_Value3", HBJJOCHGOPH);
			FKEOGPDLBDD().SetColor("_ScreenResolution", Pencil_Color);
			HKGAONMOBMH().SetFloat("_MainTex2", Pencil_Size);
			FNAFGEMJBDA().SetFloat("CameraFilterPack/Blend2Camera_Screen", Pencil_Correction);
			OIIDAKBILMI().SetFloat("SpeedSlider", Intensity);
			DEFBJOCJJKF().SetFloat("CameraFilterPack/Sharpen_Sharpen", Speed_Animation);
			ILKALHDJBFE().SetFloat(" not exist", Corner_Lose);
			FNAFGEMJBDA().SetFloat("Texture2", Fade_Paper_to_BackColor);
			CECICEGFHKL().SetFloat("_Value6", Fade_With_Original);
			ILKALHDJBFE().SetColor("mapselector.filter.favoriteonly", Back_Color);
			BKKJJJGADLM().SetTexture("_DiffuseColor", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LIEGJOHINGC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material OIIDAKBILMI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-119);
		}
		return BJFKDHHMLJH;
	}

	private void CFFCLAHMBAA()
	{
		FPHEBLMINDA = Resources.Load(":") as Texture2D;
		SCShader = Shader.Find(".lastCheckpoint.correctScore");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MMPHNFPPEHO()
	{
		FPHEBLMINDA = Resources.Load("yyyy-MM-dd HH:mm:ss") as Texture2D;
		SCShader = Shader.Find("Image");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material MCDGIILBNIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-90);
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

	private void PMPKMGKAAJH()
	{
		FPHEBLMINDA = Resources.Load("EnableRankingToggle") as Texture2D;
		SCShader = Shader.Find("_Dist");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void POEMOLBJDLG()
	{
	}

	private void OKLAJINHPAN()
	{
		FPHEBLMINDA = Resources.Load("#000000CC") as Texture2D;
		SCShader = Shader.Find("Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MMMDPANNAIO()
	{
		FPHEBLMINDA = Resources.Load("...") as Texture2D;
		SCShader = Shader.Find("Item created: Id: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CEAGPJBGBMH()
	{
		FPHEBLMINDA = Resources.Load("The region arrays from Name Server are not ok. Must be non-null and same length. ") as Texture2D;
		SCShader = Shader.Find("y");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1543f)
			{
				HBJJOCHGOPH = 1922f;
			}
			LPMLLJKMAMP().SetFloat("_Value2", HBJJOCHGOPH);
			MCDGIILBNIF().SetColor("_Skybox", Pencil_Color);
			MJJIEHANFJA().SetFloat("/", Pencil_Size);
			DCCHGBHLAAF().SetFloat("Testing, the group has toggled [", Pencil_Correction);
			DCCHGBHLAAF().SetFloat(".lastCheckpoint.time", Intensity);
			EMDFHOKEGNG().SetFloat("#", Speed_Animation);
			LEIAFCPJMDP().SetFloat("_PixelsPerMeterAtOneMeter", Corner_Lose);
			FKEOGPDLBDD().SetFloat("Creating awesome map", Fade_Paper_to_BackColor);
			LEIAFCPJMDP().SetFloat("UseFinalGlassColor", Fade_With_Original);
			DOHGBNPMBKG().SetColor("[PlayerController] ", Back_Color);
			FNAFGEMJBDA().SetTexture("tagElement", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IBFMJGJOPMM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HMNLHMLILKD()
	{
	}

	private void GHILDCBCDJI()
	{
	}

	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1668f)
			{
				HBJJOCHGOPH = 1738f;
			}
			BKKJJJGADLM().SetFloat("[ResourcesManager] Load image error: ", HBJJOCHGOPH);
			FLGPDBBKAIP().SetColor("offsets", Pencil_Color);
			KOHGPKOFEJO().SetFloat(" (inactive)", Pencil_Size);
			ILKALHDJBFE().SetFloat("_Value", Pencil_Correction);
			ILKALHDJBFE().SetFloat(".completedMaps", Intensity);
			FNAFGEMJBDA().SetFloat("_TimeX", Speed_Animation);
			DCCHGBHLAAF().SetFloat("_EmissionGain", Corner_Lose);
			PLBEJJIHFPB().SetFloat("_Offsets", Fade_Paper_to_BackColor);
			JDMJJGEHMJO().SetFloat("_Value", Fade_With_Original);
			BKKJJJGADLM().SetColor("settings.disablestoryboard", Back_Color);
			FLGPDBBKAIP().SetTexture("StartButton", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LEIAFCPJMDP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KMIEAGOFLBN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JNALDALAJLG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MNBPNHNAEBK()
	{
		FPHEBLMINDA = Resources.Load("New level loaded. Removed ") as Texture2D;
		SCShader = Shader.Find(" | Level: ");
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
			BJFKDHHMLJH.hideFlags = (HideFlags)92;
		}
		return BJFKDHHMLJH;
	}

	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 987f)
			{
				HBJJOCHGOPH = 1226f;
			}
			EMDFHOKEGNG().SetFloat("_SmoothEnd", HBJJOCHGOPH);
			OGMEGHKECAH().SetColor("settings.disablestoryboard", Pencil_Color);
			HKGAONMOBMH().SetFloat("resource", Pencil_Size);
			MCDGIILBNIF().SetFloat("CameraFilterPack/TV_PlanetMars", Pencil_Correction);
			NBPKMLMCHFN.SetFloat("curScn", Intensity);
			KOHGPKOFEJO().SetFloat("_Value3", Speed_Animation);
			FNAFGEMJBDA().SetFloat("_ColoredChange", Corner_Lose);
			NBMPPNFKFLB().SetFloat("settings.enablerankingnotifications", Fade_Paper_to_BackColor);
			DCCHGBHLAAF().SetFloat("PunSupportLogger", Fade_With_Original);
			NBPKMLMCHFN.SetColor("UseFinalGlassColor", Back_Color);
			ILKALHDJBFE().SetTexture(".", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1420f)
			{
				HBJJOCHGOPH = 1904f;
			}
			LPDOGGFOBDH().SetFloat("settings.arcsnohitsoundtimedelay", HBJJOCHGOPH);
			EMDFHOKEGNG().SetColor("_Value5", Pencil_Color);
			KGOLDDBHIFN().SetFloat("_Value3", Pencil_Size);
			NBMPPNFKFLB().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", Pencil_Correction);
			PLBEJJIHFPB().SetFloat("OK", Intensity);
			DEFBJOCJJKF().SetFloat("offline", Speed_Animation);
			JDMJJGEHMJO().SetFloat("_Value", Corner_Lose);
			MCDGIILBNIF().SetFloat("No Description", Fade_Paper_to_BackColor);
			OPMDBHHACME().SetFloat("settings.enableranking", Fade_With_Original);
			MJJIEHANFJA().SetColor("CameraFilterPack/Blend2Camera_Luminosity", Back_Color);
			KGOLDDBHIFN().SetTexture("[Steamworks.NET] DllCheck Test returned false, One or more of the Steamworks binaries seems to be the wrong version.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HNDNDPECBPL()
	{
	}

	private void AOLABBMIEIM()
	{
	}
}
