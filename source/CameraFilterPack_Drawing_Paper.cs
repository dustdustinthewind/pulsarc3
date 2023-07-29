// CameraFilterPack_Drawing_Paper
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Drawing/Paper")]
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
			NBPKMLMCHFN.SetFloat("_ScratchOffsetScale", HBJJOCHGOPH);
			FNAFGEMJBDA().SetColor("ResetSpeed", Pencil_Color);
			NBMPPNFKFLB().SetFloat("&map=", Pencil_Size);
			DEFBJOCJJKF().SetFloat("yyyy-MM-dd HH:mm:ss", Pencil_Correction);
			KGOLDDBHIFN().SetFloat("player.xp", Intensity);
			MCDGIILBNIF().SetFloat("SupportLogger OnJoinedRoom(", Speed_Animation);
			KGOLDDBHIFN().SetFloat("SpawnObj", Corner_Lose);
			PLBEJJIHFPB().SetFloat(" item(s) in inventory", Fade_Paper_to_BackColor);
			NBPKMLMCHFN.SetFloat("_BlendTex", Fade_With_Original);
			EMDFHOKEGNG().SetColor(" registered.", Back_Color);
			ILKALHDJBFE().SetTexture("mapid", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EMDFHOKEGNG());
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
		FPHEBLMINDA = Resources.Load("_ScreenResolution") as Texture2D;
		SCShader = Shader.Find("3;4;9;10;21x6");
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
			EMDFHOKEGNG().SetFloat("AllocateViewID() failed. Room (user {0}) is out of 'scene' viewIDs. It seems all available are in use.", HBJJOCHGOPH);
			HKGAONMOBMH().SetColor("_MainTex2", Pencil_Color);
			KGOLDDBHIFN().SetFloat("_Value", Pencil_Size);
			FKEOGPDLBDD().SetFloat("_Value3", Pencil_Correction);
			NBPKMLMCHFN.SetFloat("_Value4", Intensity);
			JDMJJGEHMJO().SetFloat("_Value4", Speed_Animation);
			DEFBJOCJJKF().SetFloat("menutheme.deleted", Corner_Lose);
			OIIDAKBILMI().SetFloat("_TimeX", Fade_Paper_to_BackColor);
			BKKJJJGADLM().SetFloat("OpJoinRoom()", Fade_With_Original);
			LPDOGGFOBDH().SetColor("_Value3", Back_Color);
			LEIAFCPJMDP().SetTexture("SUCCESS! Item submitted! :D :D :D", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KNBJBNDGCIJ()
	{
		FPHEBLMINDA = Resources.Load("_TimeX") as Texture2D;
		SCShader = Shader.Find("<b>(╯°□°）╯︵ ┻━┻</b>");
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
			HKGAONMOBMH().SetFloat("[RanksSystem] Ranks: no need to update", HBJJOCHGOPH);
			PLBEJJIHFPB().SetColor("inventory.lastitemscount", Pencil_Color);
			CECICEGFHKL().SetFloat("Edited unlock conditions", Pencil_Size);
			FNAFGEMJBDA().SetFloat("FrostCanvas", Pencil_Correction);
			LEIAFCPJMDP().SetFloat(" - PUBLISHED #", Intensity);
			OGMEGHKECAH().SetFloat("AllocateViewID() failed. User {0} is out of subIds, as all viewIDs are used.", Speed_Animation);
			MCDGIILBNIF().SetFloat("_MainTex2", Corner_Lose);
			LPMLLJKMAMP().SetFloat("Myst_Color", Fade_Paper_to_BackColor);
			LPMLLJKMAMP().SetFloat("menutheme.hunter", Fade_With_Original);
			FNAFGEMJBDA().SetColor("CameraFilterPack/Lut_TestMode", Back_Color);
			DEFBJOCJJKF().SetTexture("SpeedSlider", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CECICEGFHKL());
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
			FLGPDBBKAIP().SetFloat("maps.", HBJJOCHGOPH);
			EMDFHOKEGNG().SetColor("didAuthenticate ", Pencil_Color);
			KGOLDDBHIFN().SetFloat("_Value", Pencil_Size);
			LPDOGGFOBDH().SetFloat("_Value", Pencil_Correction);
			DCCHGBHLAAF().SetFloat("_Saturation", Intensity);
			PLBEJJIHFPB().SetFloat("RPCs can only be sent in rooms. Call of \"", Speed_Animation);
			CECICEGFHKL().SetFloat("_Color", Corner_Lose);
			LPMLLJKMAMP().SetFloat("_Value", Fade_Paper_to_BackColor);
			PLBEJJIHFPB().SetFloat("/", Fade_With_Original);
			EMDFHOKEGNG().SetColor("Chat", Back_Color);
			OPMDBHHACME().SetTexture("The used master server address is not available with the subscription currently used. Got to Photon Cloud Dashboard or change URL. Disconnecting.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OPMDBHHACME());
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
		FPHEBLMINDA = Resources.Load(".completed") as Texture2D;
		SCShader = Shader.Find("_Exposure");
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
		FPHEBLMINDA = Resources.Load("_Value5") as Texture2D;
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
			LEIAFCPJMDP().SetFloat("PopulateMapsList", HBJJOCHGOPH);
			OPMDBHHACME().SetColor("masterSteamID", Pencil_Color);
			KOHGPKOFEJO().SetFloat("_MainTex2", Pencil_Size);
			MJJIEHANFJA().SetFloat("_TimeX", Pencil_Correction);
			EMDFHOKEGNG().SetFloat("<command>", Intensity);
			PLBEJJIHFPB().SetFloat("_SpotSize", Speed_Animation);
			NBMPPNFKFLB().SetFloat("_Distortion", Corner_Lose);
			FKEOGPDLBDD().SetFloat("_FlipAlphaMask", Fade_Paper_to_BackColor);
			LPDOGGFOBDH().SetFloat("_Value3", Fade_With_Original);
			BKKJJJGADLM().SetColor("This might be a misconfiguration in the game server config. You need to edit it to a (public) address.", Back_Color);
			OGMEGHKECAH().SetTexture("ReconnectAndRejoin() failed. It seems the client wasn't connected to a game server before (no address).", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BKIGIIINEDH()
	{
		FPHEBLMINDA = Resources.Load("menu.tabid") as Texture2D;
		SCShader = Shader.Find("note.7");
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
		FPHEBLMINDA = Resources.Load("_Value4") as Texture2D;
		SCShader = Shader.Find("_BlurVector");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void COIJKMKIEAK()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack/FX_Screens") as Texture2D;
		SCShader = Shader.Find("settings.selectormapsperpage");
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
		FPHEBLMINDA = Resources.Load("maps.") as Texture2D;
		SCShader = Shader.Find("_U");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KHIGHFJKPFG()
	{
		FPHEBLMINDA = Resources.Load("selector") as Texture2D;
		SCShader = Shader.Find("AVG Misses:");
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
		FPHEBLMINDA = Resources.Load("Crosshair1") as Texture2D;
		SCShader = Shader.Find("SpectateButton");
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
		SCShader = Shader.Find("_Value3");
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
			CECICEGFHKL().SetFloat("JoinButton", HBJJOCHGOPH);
			PLBEJJIHFPB().SetColor("_Value2", Pencil_Color);
			FLGPDBBKAIP().SetFloat("AudioSampler", Pencil_Size);
			JDMJJGEHMJO().SetFloat("menu.playedsolo", Pencil_Correction);
			KOHGPKOFEJO().SetFloat("settings.crosshairopacity", Intensity);
			CECICEGFHKL().SetFloat("LivesSlider", Speed_Animation);
			FLGPDBBKAIP().SetFloat("Uploading content", Corner_Lose);
			KOHGPKOFEJO().SetFloat("CameraFilterPack/Vision_AuraDistortion", Fade_Paper_to_BackColor);
			MCDGIILBNIF().SetFloat("/", Fade_With_Original);
			OIIDAKBILMI().SetColor(" not exist", Back_Color);
			HKGAONMOBMH().SetTexture("\n\n• ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
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
			LEIAFCPJMDP().SetFloat("_SSRMultiplier", HBJJOCHGOPH);
			DEFBJOCJJKF().SetColor(" : ", Pencil_Color);
			PLBEJJIHFPB().SetFloat("ready", Pencil_Size);
			KOHGPKOFEJO().SetFloat(".", Pencil_Correction);
			NBPKMLMCHFN.SetFloat("[Down]", Intensity);
			NBMPPNFKFLB().SetFloat("GlassAberration", Speed_Animation);
			FLGPDBBKAIP().SetFloat("[Up]", Corner_Lose);
			PLBEJJIHFPB().SetFloat("OperationResponse ignored while disconnecting. Code: ", Fade_Paper_to_BackColor);
			PLBEJJIHFPB().SetFloat("LivesSlider", Fade_With_Original);
			HKGAONMOBMH().SetColor("Image", Back_Color);
			KGOLDDBHIFN().SetTexture("Room: '{0}' {1},{2} {4}/{3} players.\ncustomProps: {5}", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DCCHGBHLAAF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IHLMNAGPKDA()
	{
		FPHEBLMINDA = Resources.Load("_Visualize") as Texture2D;
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ECBILENEOOL()
	{
		FPHEBLMINDA = Resources.Load("_FarCamera") as Texture2D;
		SCShader = Shader.Find("#{0:00}{1}{2}");
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
		FPHEBLMINDA = Resources.Load("#exit") as Texture2D;
		SCShader = Shader.Find("MapConfig");
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
			PLBEJJIHFPB().SetFloat("Dance", HBJJOCHGOPH);
			NBPKMLMCHFN.SetColor("[LocalizationService] All languages: ", Pencil_Color);
			CECICEGFHKL().SetFloat("Please attach component to a Graphical UI component", Pencil_Size);
			FKEOGPDLBDD().SetFloat(" ownership transfered to: ", Pencil_Correction);
			HKGAONMOBMH().SetFloat("_BlurParams", Intensity);
			FNAFGEMJBDA().SetFloat("Received unknown status code: ", Speed_Animation);
			NBPKMLMCHFN.SetFloat("_RampTex", Corner_Lose);
			PLBEJJIHFPB().SetFloat("_ScreenResolution", Fade_Paper_to_BackColor);
			FKEOGPDLBDD().SetFloat("_ScreenResolution", Fade_With_Original);
			MJJIEHANFJA().SetColor("_RampTex", Back_Color);
			LPMLLJKMAMP().SetTexture("maps.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ILKALHDJBFE());
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
			MCDGIILBNIF().SetFloat("ViewMenu", HBJJOCHGOPH);
			DOHGBNPMBKG().SetColor("Pop", Pencil_Color);
			JDMJJGEHMJO().SetFloat("[PlayerBase] Starting game from: ", Pencil_Size);
			ILKALHDJBFE().SetFloat("SfxVolumeSlider", Pencil_Correction);
			LPMLLJKMAMP().SetFloat("{0}{1}:{2}", Intensity);
			KOHGPKOFEJO().SetFloat("[ERROR KEY {0}]", Speed_Animation);
			DOHGBNPMBKG().SetFloat("_Value", Corner_Lose);
			PLBEJJIHFPB().SetFloat("http://steamcommunity.com/sharedfiles/filedetails/?id=", Fade_Paper_to_BackColor);
			DCCHGBHLAAF().SetFloat("Item ", Fade_With_Original);
			CECICEGFHKL().SetColor("LevelEditor/CustomEventEditor-", Back_Color);
			KOHGPKOFEJO().SetTexture("_TimeX", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
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
		FPHEBLMINDA = Resources.Load(" ") as Texture2D;
		SCShader = Shader.Find("_Extra");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IDJKNBDKHBD()
	{
		FPHEBLMINDA = Resources.Load(" has ") as Texture2D;
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
			NBPKMLMCHFN.SetFloat("maps.", HBJJOCHGOPH);
			DCCHGBHLAAF().SetColor("#savemapchanges?", Pencil_Color);
			NBMPPNFKFLB().SetFloat("checkpoint", Pencil_Size);
			JDMJJGEHMJO().SetFloat("_InternalLutTex", Pencil_Correction);
			BKKJJJGADLM().SetFloat("MenuPlayButton", Intensity);
			DEFBJOCJJKF().SetFloat("_Distance", Speed_Animation);
			OPMDBHHACME().SetFloat("offline room", Corner_Lose);
			FNAFGEMJBDA().SetFloat(".wav", Fade_Paper_to_BackColor);
			CECICEGFHKL().SetFloat(" ", Fade_With_Original);
			NBMPPNFKFLB().SetColor("Hex value #RRGGBB", Back_Color);
			FKEOGPDLBDD().SetTexture("_ScreenResolution", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
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
		FPHEBLMINDA = Resources.Load("Messages (shift+tab)") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Colors_BleachBypass");
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
		SCShader = Shader.Find("The process failed: ");
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
		SCShader = Shader.Find("[EditorEvent] Exception: ");
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
		FPHEBLMINDA = Resources.Load("Joined Room. isMasterClient: ") as Texture2D;
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
			FLGPDBBKAIP().SetFloat("]", HBJJOCHGOPH);
			LPMLLJKMAMP().SetColor("z", Pencil_Color);
			NBMPPNFKFLB().SetFloat("\n\n#", Pencil_Size);
			KOHGPKOFEJO().SetFloat("System.Int64", Pencil_Correction);
			DEFBJOCJJKF().SetFloat("_Offsets", Intensity);
			NBPKMLMCHFN.SetFloat(":</b> ", Speed_Animation);
			FNAFGEMJBDA().SetFloat(": ", Corner_Lose);
			DOHGBNPMBKG().SetFloat("_Size", Fade_Paper_to_BackColor);
			EMDFHOKEGNG().SetFloat("_ScreenResolution", Fade_With_Original);
			NBMPPNFKFLB().SetColor("VeryHigh", Back_Color);
			KGOLDDBHIFN().SetTexture("ws://", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
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
		FPHEBLMINDA = Resources.Load("#currentbpm: ") as Texture2D;
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
			OGMEGHKECAH().SetFloat("The authentication ticket expired. You need to connect (and authenticate) again. Disconnecting.", HBJJOCHGOPH);
			OPMDBHHACME().SetColor("May", Pencil_Color);
			NBPKMLMCHFN.SetFloat("_PositionY", Pencil_Size);
			LPMLLJKMAMP().SetFloat("1.87", Pencil_Correction);
			PLBEJJIHFPB().SetFloat("_Green_C", Intensity);
			DEFBJOCJJKF().SetFloat("_Value", Speed_Animation);
			FLGPDBBKAIP().SetFloat("_Value6", Corner_Lose);
			HKGAONMOBMH().SetFloat("#or", Fade_Paper_to_BackColor);
			KGOLDDBHIFN().SetFloat("Joystick1Button5", Fade_With_Original);
			BKKJJJGADLM().SetColor("value", Back_Color);
			KGOLDDBHIFN().SetTexture("_Parameter", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
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
			PLBEJJIHFPB().SetFloat("OnSerialize", HBJJOCHGOPH);
			KOHGPKOFEJO().SetColor("Added GameObject to prefabDictionary: ", Pencil_Color);
			DEFBJOCJJKF().SetFloat("yes", Pencil_Size);
			NBPKMLMCHFN.SetFloat("Set Crosshair Color", Pencil_Correction);
			DCCHGBHLAAF().SetFloat("event", Intensity);
			CECICEGFHKL().SetFloat("_Value2", Speed_Animation);
			NBPKMLMCHFN.SetFloat("Scene", Corner_Lose);
			FNAFGEMJBDA().SetFloat("_ScreenResolution", Fade_Paper_to_BackColor);
			ILKALHDJBFE().SetFloat("Out {0,4} | In {1,4} | Sum {2,4}", Fade_With_Original);
			ILKALHDJBFE().SetColor("SetRoomStartTimestamp", Back_Color);
			DCCHGBHLAAF().SetTexture("RECORD [R]", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
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
			EMDFHOKEGNG().SetFloat("RateButton", HBJJOCHGOPH);
			DOHGBNPMBKG().SetColor("#failed!", Pencil_Color);
			KGOLDDBHIFN().SetFloat("_Intensity", Pencil_Size);
			FLGPDBBKAIP().SetFloat("Lightning", Pencil_Correction);
			FNAFGEMJBDA().SetFloat("CameraFilterPack/Blend2Camera_SplitScreen3D", Intensity);
			CECICEGFHKL().SetFloat("}", Speed_Animation);
			DEFBJOCJJKF().SetFloat(". The group number should be at least 1.", Corner_Lose);
			JDMJJGEHMJO().SetFloat("[PlayerController] ", Fade_Paper_to_BackColor);
			LEIAFCPJMDP().SetFloat("_Intensity", Fade_With_Original);
			NBPKMLMCHFN.SetColor(".lastCheckpoint.time", Back_Color);
			OPMDBHHACME().SetTexture("BackButton", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FNAFGEMJBDA());
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
			EMDFHOKEGNG().SetFloat("_Value3", HBJJOCHGOPH);
			DEFBJOCJJKF().SetColor("_TimeX", Pencil_Color);
			DCCHGBHLAAF().SetFloat("cancel", Pencil_Size);
			KGOLDDBHIFN().SetFloat("#scoresubmitionfailed: ", Pencil_Correction);
			OIIDAKBILMI().SetFloat("CameraFilterPack/Blend2Camera_Blend", Intensity);
			EMDFHOKEGNG().SetFloat("PUNCloudBestRegion", Speed_Animation);
			KOHGPKOFEJO().SetFloat("Crosshair2", Corner_Lose);
			ILKALHDJBFE().SetFloat("_Red_R", Fade_Paper_to_BackColor);
			OIIDAKBILMI().SetFloat("_FixDistance", Fade_With_Original);
			DEFBJOCJJKF().SetColor("Editor", Back_Color);
			OIIDAKBILMI().SetTexture("BitsData", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
		SCShader = Shader.Find("[PlayerController] ");
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
			NBPKMLMCHFN.SetFloat("Object ID", HBJJOCHGOPH);
			LPMLLJKMAMP().SetColor("_TimeX", Pencil_Color);
			OGMEGHKECAH().SetFloat("steamid", Pencil_Size);
			NBMPPNFKFLB().SetFloat("_Value9", Pencil_Correction);
			MCDGIILBNIF().SetFloat("error", Intensity);
			HKGAONMOBMH().SetFloat("_ScreenResolution", Speed_Animation);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/AAA_Blood_Hit", Corner_Lose);
			OPMDBHHACME().SetFloat("Left Stick Click", Fade_Paper_to_BackColor);
			ILKALHDJBFE().SetFloat("[Up]", Fade_With_Original);
			DOHGBNPMBKG().SetColor("_MainTex2", Back_Color);
			KOHGPKOFEJO().SetTexture("Joystick1Button6", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MMOKKAPFGAK()
	{
		FPHEBLMINDA = Resources.Load("ItemNameText") as Texture2D;
		SCShader = Shader.Find("#,0.00");
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
		SCShader = Shader.Find(".lastCheckpoint.longestComboScore");
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
			ILKALHDJBFE().SetFloat("_VignetteCenter", HBJJOCHGOPH);
			MJJIEHANFJA().SetColor("(singleton) ", Pencil_Color);
			JDMJJGEHMJO().SetFloat("0 - sun, 1 - satellite, 2 - particles emitter", Pencil_Size);
			PLBEJJIHFPB().SetFloat("CameraFilterPack/Lut_TestMode", Pencil_Correction);
			NBPKMLMCHFN.SetFloat(".", Intensity);
			BKKJJJGADLM().SetFloat("[PlayerController] ", Speed_Animation);
			EMDFHOKEGNG().SetFloat("CameraFilterPack/FX_Hexagon_Black", Corner_Lose);
			ILKALHDJBFE().SetFloat("_Value", Fade_Paper_to_BackColor);
			OIIDAKBILMI().SetFloat("_ScreenResolution", Fade_With_Original);
			MJJIEHANFJA().SetColor("ResourcesConfig", Back_Color);
			KGOLDDBHIFN().SetTexture("Prints list of commands", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
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
			DOHGBNPMBKG().SetFloat("???", HBJJOCHGOPH);
			FNAFGEMJBDA().SetColor("(\\[ */ *i *\\])", Pencil_Color);
			PLBEJJIHFPB().SetFloat("LevelConfigButton", Pencil_Size);
			NBMPPNFKFLB().SetFloat("UseScanLine", Pencil_Correction);
			CECICEGFHKL().SetFloat(". The group number should be at least 1.", Intensity);
			BKKJJJGADLM().SetFloat("Clear Environment", Speed_Animation);
			HKGAONMOBMH().SetFloat("_TimeX", Corner_Lose);
			LPDOGGFOBDH().SetFloat("RecordButton", Fade_Paper_to_BackColor);
			MCDGIILBNIF().SetFloat("_Value4", Fade_With_Original);
			LPDOGGFOBDH().SetColor("There are {0} reported logs.", Back_Color);
			OGMEGHKECAH().SetTexture("GameScene", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EDPDMBFLHLP()
	{
		FPHEBLMINDA = Resources.Load("setfloat") as Texture2D;
		SCShader = Shader.Find("automaticallyRecycleParticleSystems is true but there is no ParticleSystem on this GameObject!");
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
			FKEOGPDLBDD().SetFloat("clicked ", HBJJOCHGOPH);
			DEFBJOCJJKF().SetColor("23x3", Pencil_Color);
			NBMPPNFKFLB().SetFloat("_ZCurve", Pencil_Size);
			KGOLDDBHIFN().SetFloat(" base map(s)", Pencil_Correction);
			ILKALHDJBFE().SetFloat("SpawnObj", Intensity);
			DOHGBNPMBKG().SetFloat("ResourceFileSelector", Speed_Animation);
			FNAFGEMJBDA().SetFloat("_Axis", Corner_Lose);
			KGOLDDBHIFN().SetFloat("<b>Kick player by NetID</b>\nuse: /kick {NetID}\nUse \"/players\" command to get all NetIDs\nRoom owner only can kick the players", Fade_Paper_to_BackColor);
			FLGPDBBKAIP().SetFloat("#ok", Fade_With_Original);
			MJJIEHANFJA().SetColor("LowMid", Back_Color);
			OIIDAKBILMI().SetTexture("Down", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
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
		FPHEBLMINDA = Resources.Load("Lerp speed. Recomended 10") as Texture2D;
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
		FPHEBLMINDA = Resources.Load("checkpoint") as Texture2D;
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
			FKEOGPDLBDD().SetFloat("x", HBJJOCHGOPH);
			MCDGIILBNIF().SetColor(".workshop.json", Pencil_Color);
			NBPKMLMCHFN.SetFloat("GlassDistortion", Pencil_Size);
			MJJIEHANFJA().SetFloat("#getrewardfailed: ", Pencil_Correction);
			NBMPPNFKFLB().SetFloat("In Network lobby", Intensity);
			OPMDBHHACME().SetFloat("player.xp", Speed_Animation);
			BKKJJJGADLM().SetFloat("_TimeX", Corner_Lose);
			JDMJJGEHMJO().SetFloat("Lag ", Fade_Paper_to_BackColor);
			JDMJJGEHMJO().SetFloat("_Greenness", Fade_With_Original);
			HKGAONMOBMH().SetColor("_TimeX", Back_Color);
			LPDOGGFOBDH().SetTexture("_TimeX", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIIDAKBILMI());
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
			DEFBJOCJJKF().SetFloat("Default color's lerp speed of color changing. Greater values means faster changing. 0 - intant change.", HBJJOCHGOPH);
			FNAFGEMJBDA().SetColor("shader.frost", Pencil_Color);
			KGOLDDBHIFN().SetFloat("_Value4", Pencil_Size);
			OPMDBHHACME().SetFloat("/", Pencil_Correction);
			BKKJJJGADLM().SetFloat("_Value2", Intensity);
			OIIDAKBILMI().SetFloat("0.00", Speed_Animation);
			FKEOGPDLBDD().SetFloat("\r", Corner_Lose);
			BKKJJJGADLM().SetFloat("-help", Fade_Paper_to_BackColor);
			MCDGIILBNIF().SetFloat("DPADHOR", Fade_With_Original);
			FLGPDBBKAIP().SetColor("Committing changes...", Back_Color);
			CECICEGFHKL().SetTexture("menutheme.hunter", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OPMDBHHACME());
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
			OPMDBHHACME().SetFloat("sounds/hit_normal", HBJJOCHGOPH);
			KGOLDDBHIFN().SetColor("_Value5", Pencil_Color);
			OIIDAKBILMI().SetFloat("OPEN FILE", Pencil_Size);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Color_GrayScale", Pencil_Correction);
			LPMLLJKMAMP().SetFloat("Down", Intensity);
			NBPKMLMCHFN.SetFloat(" b.", Speed_Animation);
			NBPKMLMCHFN.SetFloat("_Glow", Corner_Lose);
			DOHGBNPMBKG().SetFloat("\\\\", Fade_Paper_to_BackColor);
			CECICEGFHKL().SetFloat("_ReflectionTexture4", Fade_With_Original);
			DOHGBNPMBKG().SetColor("_Value2", Back_Color);
			HKGAONMOBMH().SetTexture("UseFinalGlassColor", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EIMNPCMHJLJ()
	{
		FPHEBLMINDA = Resources.Load("Received RPC \"") as Texture2D;
		SCShader = Shader.Find("/icon");
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
		FPHEBLMINDA = Resources.Load("_Bullet_2") as Texture2D;
		SCShader = Shader.Find("VisionBlur");
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
		FPHEBLMINDA = Resources.Load("_ScreenResolution") as Texture2D;
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
			PLBEJJIHFPB().SetFloat("EditMenu", HBJJOCHGOPH);
			FNAFGEMJBDA().SetColor("Switch environment sprite image", Pencil_Color);
			MCDGIILBNIF().SetFloat("StartButton", Pencil_Size);
			CECICEGFHKL().SetFloat("[LevelEditorScene] Creating new item...", Pencil_Correction);
			NBMPPNFKFLB().SetFloat("Search: ", Intensity);
			FKEOGPDLBDD().SetFloat("<b>(╯°□°）╯︵ ┻━┻</b>", Speed_Animation);
			DEFBJOCJJKF().SetFloat("<b>#", Corner_Lose);
			LEIAFCPJMDP().SetFloat("R1", Fade_Paper_to_BackColor);
			MCDGIILBNIF().SetFloat("CameraFilterPack_Paper3", Fade_With_Original);
			OIIDAKBILMI().SetColor("Tab2Content", Back_Color);
			LEIAFCPJMDP().SetTexture("CameraFilterPack_AAA_Blood2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OPMDBHHACME());
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
			KOHGPKOFEJO().SetFloat("_Value4", HBJJOCHGOPH);
			PLBEJJIHFPB().SetColor("CameraFilterPack/FX_ZebraColor", Pencil_Color);
			FLGPDBBKAIP().SetFloat("CameraFilterPack_Glasses_On6", Pencil_Size);
			DEFBJOCJJKF().SetFloat("CameraFilterPack/Blend2Camera_Screen", Pencil_Correction);
			BKKJJJGADLM().SetFloat("Tab1Content", Intensity);
			OIIDAKBILMI().SetFloat("_TimeX", Speed_Animation);
			EMDFHOKEGNG().SetFloat("[PlayerController] ", Corner_Lose);
			NBMPPNFKFLB().SetFloat("Texture3", Fade_Paper_to_BackColor);
			OIIDAKBILMI().SetFloat("_Value7", Fade_With_Original);
			HKGAONMOBMH().SetColor("mapselector.filter.rateduponly", Back_Color);
			KOHGPKOFEJO().SetTexture("_EmissionColor", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BKKJJJGADLM());
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
		FPHEBLMINDA = Resources.Load(" ") as Texture2D;
		SCShader = Shader.Find(".lastCheckpoint.checkpointsUsed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MMPHNFPPEHO()
	{
		FPHEBLMINDA = Resources.Load("#,0.00") as Texture2D;
		SCShader = Shader.Find("GroupNameText");
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
		SCShader = Shader.Find("_Smooth");
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
		FPHEBLMINDA = Resources.Load("#FFDA44CC") as Texture2D;
		SCShader = Shader.Find(" x ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MMMDPANNAIO()
	{
		FPHEBLMINDA = Resources.Load("...") as Texture2D;
		SCShader = Shader.Find("Error: You're not logged into Steam!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CEAGPJBGBMH()
	{
		FPHEBLMINDA = Resources.Load("Skipping region because it's not in PhotonServerSettings.EnabledRegions: ") as Texture2D;
		SCShader = Shader.Find("float,0");
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
			DEFBJOCJJKF().SetFloat("_Value4", HBJJOCHGOPH);
			FNAFGEMJBDA().SetColor("_SunPosition", Pencil_Color);
			LPDOGGFOBDH().SetFloat("NewIconFileSelector", Pencil_Size);
			EMDFHOKEGNG().SetFloat("Testing, a toggle has toggled [", Pencil_Correction);
			DCCHGBHLAAF().SetFloat(".highscore", Intensity);
			DEFBJOCJJKF().SetFloat("#", Speed_Animation);
			PLBEJJIHFPB().SetFloat("_ReflectionBlur", Corner_Lose);
			DEFBJOCJJKF().SetFloat("CurrentTimeLabel", Fade_Paper_to_BackColor);
			PLBEJJIHFPB().SetFloat("Fade", Fade_With_Original);
			KOHGPKOFEJO().SetColor("[PlayerController] ", Back_Color);
			LPDOGGFOBDH().SetTexture("tagElement", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ILKALHDJBFE());
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
			LPDOGGFOBDH().SetFloat(".jpg", HBJJOCHGOPH);
			KOHGPKOFEJO().SetColor("_MainTexBlurred", Pencil_Color);
			NBPKMLMCHFN.SetFloat("'{0}'{1}{2}", Pencil_Size);
			DOHGBNPMBKG().SetFloat("_Value2", Pencil_Correction);
			FNAFGEMJBDA().SetFloat(".completedCount", Intensity);
			NBMPPNFKFLB().SetFloat("_Level", Speed_Animation);
			LPDOGGFOBDH().SetFloat("_EmissionGain", Corner_Lose);
			LPDOGGFOBDH().SetFloat("_SpawnHeuristic", Fade_Paper_to_BackColor);
			EMDFHOKEGNG().SetFloat("_Value", Fade_With_Original);
			LPMLLJKMAMP().SetColor("maps.", Back_Color);
			NBPKMLMCHFN.SetTexture("StartButton", FPHEBLMINDA);
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
		FPHEBLMINDA = Resources.Load("Received OnSerialization for view ID ") as Texture2D;
		SCShader = Shader.Find("Reset XP");
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
			JDMJJGEHMJO().SetFloat("CameraFilterPack/Drawing_Halftone", HBJJOCHGOPH);
			LEIAFCPJMDP().SetColor("maps.", Pencil_Color);
			PLBEJJIHFPB().SetFloat("resource", Pencil_Size);
			FNAFGEMJBDA().SetFloat("_TimeX", Pencil_Correction);
			MCDGIILBNIF().SetFloat("curScn", Intensity);
			OIIDAKBILMI().SetFloat("_Value3", Speed_Animation);
			CECICEGFHKL().SetFloat("_ChangeRed", Corner_Lose);
			JDMJJGEHMJO().SetFloat("player.currentrank", Fade_Paper_to_BackColor);
			FNAFGEMJBDA().SetFloat("SupportLogger OnApplicationPause: ", Fade_With_Original);
			MJJIEHANFJA().SetColor("Fade", Back_Color);
			ILKALHDJBFE().SetTexture(".GoalProgress", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLGPDBBKAIP());
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
			LPMLLJKMAMP().SetFloat("settings.arcsnohitsoundtimedelay", HBJJOCHGOPH);
			OIIDAKBILMI().SetColor("_MainTex2", Pencil_Color);
			LEIAFCPJMDP().SetFloat("_Value5", Pencil_Size);
			LPMLLJKMAMP().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", Pencil_Correction);
			DOHGBNPMBKG().SetFloat("/", Intensity);
			LEIAFCPJMDP().SetFloat("offline", Speed_Animation);
			EMDFHOKEGNG().SetFloat("_Value2", Corner_Lose);
			LPDOGGFOBDH().SetFloat("No Description", Fade_Paper_to_BackColor);
			ILKALHDJBFE().SetFloat("settings.enableranking", Fade_With_Original);
			NBPKMLMCHFN.SetColor("CameraFilterPack/Blend2Camera_Luminosity", Back_Color);
			NBPKMLMCHFN.SetTexture("[Steamworks.NET] SteamAPI_Init() failed. Refer to Valve's documentation or the comment above this line for more information.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
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
