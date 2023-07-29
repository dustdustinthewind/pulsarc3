// CameraFilterPack_Drawing_Paper2
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Drawing/Paper2")]
public class CameraFilterPack_Drawing_Paper2 : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	public Color Pencil_Color = new Color(0f, 0.371f, 0.78f, 1f);

	[Range(0.0001f, 0.0022f)]
	public float Pencil_Size = 0.0008f;

	[Range(0f, 2f)]
	public float Pencil_Correction = 0.76f;

	[Range(0f, 1f)]
	public float Intensity = 1f;

	[Range(0f, 2f)]
	public float Speed_Animation = 1f;

	[Range(0f, 1f)]
	public float Corner_Lose = 0.85f;

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

	private void DOEPOGLEGLE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EHJJFJCKGAJ()
	{
	}

	private void HNGHDAPKEJG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Update()
	{
	}

	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 949f)
			{
				HBJJOCHGOPH = 579f;
			}
			MLMKCOINOOH().SetFloat("LeaderboardsButton", HBJJOCHGOPH);
			MICHFGAOPKM().SetColor("settings.enableselectormusic", Pencil_Color);
			KAFBNOBOIAJ().SetFloat("Object ID. Case-Sensitive", Pencil_Size);
			DIOAAHJDMLK().SetFloat("/../", Pencil_Correction);
			EJDPNJAEAKJ().SetFloat("_Red_R", Intensity);
			DIOAAHJDMLK().SetFloat("_ScreenResolution", Speed_Animation);
			HCGJCMDJPGD().SetFloat("challenges", Corner_Lose);
			CEKJODEAMGB().SetFloat("_TimeX", Fade_Paper_to_BackColor);
			ADBKPGFMNKO().SetFloat("IconImage", Fade_With_Original);
			HKHBBBFLGJH().SetColor("CameraFilterPack_Paper3", Back_Color);
			BAGICADFBAB().SetTexture("_Value4", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 627f)
			{
				HBJJOCHGOPH = 290f;
			}
			ACHNOHCLGOO().SetFloat("_TimeX", HBJJOCHGOPH);
			PLBEJJIHFPB().SetColor("Metal", Pencil_Color);
			HCGJCMDJPGD().SetFloat("_Value2", Pencil_Size);
			ACHNOHCLGOO().SetFloat(".GoalProgress", Pencil_Correction);
			EFMCNLELMDO().SetFloat("_Value1", Intensity);
			ACHNOHCLGOO().SetFloat("FrostCanvas", Speed_Animation);
			FKEOGPDLBDD().SetFloat("maps.", Corner_Lose);
			MLMKCOINOOH().SetFloat("_Value4", Fade_Paper_to_BackColor);
			KHCLIAMBBNC().SetFloat("x", Fade_With_Original);
			ADGHJOHKEHG().SetColor("MultiplayerButton", Back_Color);
			EFMCNLELMDO().SetTexture(". Possible scene loading in progress?", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HNFFHCLNBDN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
		}
		return BJFKDHHMLJH;
	}

	private void LNOOFNGHNEL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 484f)
			{
				HBJJOCHGOPH = 932f;
			}
			ACHNOHCLGOO().SetFloat("_MidGrey", HBJJOCHGOPH);
			FOOCJIDNGBB().SetColor("AddEnvironmentSprite", Pencil_Color);
			NFKFAAHHLLM().SetFloat("_MainTex2", Pencil_Size);
			LPCHMEKDCHI().SetFloat("OnJoinedRoom() called by PUN. Now this client is in a room. From here on, your game would be running. For reference, all callbacks are listed in enum: PhotonNetworkingMessage", Pencil_Correction);
			ADGHJOHKEHG().SetFloat("distance", Intensity);
			DKKBFFHBHJE().SetFloat("_Parameter", Speed_Animation);
			CEKJODEAMGB().SetFloat("#91CCFF", Corner_Lose);
			EJDPNJAEAKJ().SetFloat("MenuScene", Fade_Paper_to_BackColor);
			KHCLIAMBBNC().SetFloat(".", Fade_With_Original);
			HNFFHCLNBDN().SetColor("\t", Back_Color);
			ADBKPGFMNKO().SetTexture("_ScreenResolution", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LGHCJCFHEMF()
	{
		FPHEBLMINDA = Resources.Load(".lastCheckpoint.bgcolor") as Texture2D;
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material FOOCJIDNGBB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void LCDJFJIBADI()
	{
	}

	private void KOFAMEKHHGD()
	{
		FPHEBLMINDA = Resources.Load("#alreadystarted") as Texture2D;
		SCShader = Shader.Find("tagElement");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MDNHCLKNCLE()
	{
		FPHEBLMINDA = Resources.Load("_Radius") as Texture2D;
		SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BGDONBMDPGM()
	{
	}

	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1487f)
			{
				HBJJOCHGOPH = 790f;
			}
			HKHBBBFLGJH().SetFloat("CountEventsGoal", HBJJOCHGOPH);
			MICHFGAOPKM().SetColor("CameraFilterPack/TV_ARCADE_2", Pencil_Color);
			FOOCJIDNGBB().SetFloat("_Value7", Pencil_Size);
			FKEOGPDLBDD().SetFloat("RPC: 'OnAwakeRPC' PhotonView: ", Pencil_Correction);
			EFMCNLELMDO().SetFloat(" not exist", Intensity);
			KEMAALEODNH().SetFloat("_Value2", Speed_Animation);
			HNFFHCLNBDN().SetFloat("_ScreenResolution", Corner_Lose);
			FOOCJIDNGBB().SetFloat("_EmissionColor", Fade_Paper_to_BackColor);
			NBPKMLMCHFN.SetFloat("EventTimeInputField", Fade_With_Original);
			NBPKMLMCHFN.SetColor("#close", Back_Color);
			PLBEJJIHFPB().SetTexture("MainThreadExecuter", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OEIBFOHPOPD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BFEILOMHNPC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1353f)
			{
				HBJJOCHGOPH = 108f;
			}
			HCGJCMDJPGD().SetFloat("#timeuntilchallenge: ", HBJJOCHGOPH);
			ACHNOHCLGOO().SetColor("SetSatelliteSensitivity", Pencil_Color);
			PLBEJJIHFPB().SetFloat("EventData0DropDownList", Pencil_Size);
			MICHFGAOPKM().SetFloat("[SaveSystem] Outdated savefile found", Pencil_Correction);
			DIOAAHJDMLK().SetFloat("LoadMapCanvas", Intensity);
			MICHFGAOPKM().SetFloat("float,10", Speed_Animation);
			MICHFGAOPKM().SetFloat("UsernameText", Corner_Lose);
			ENKPNJMPDEB().SetFloat("1332644700", Fade_Paper_to_BackColor);
			KHCLIAMBBNC().SetFloat("ScrollPanel", Fade_With_Original);
			PLBEJJIHFPB().SetColor("BitsData", Back_Color);
			ACHNOHCLGOO().SetTexture("restrictions\n\n#until: ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 163f)
			{
				HBJJOCHGOPH = 66f;
			}
			ADGHJOHKEHG().SetFloat("menuthemes", HBJJOCHGOPH);
			DKKBFFHBHJE().SetColor("settings.shaders", Pencil_Color);
			HCGJCMDJPGD().SetFloat("Other", Pencil_Size);
			FOOCJIDNGBB().SetFloat("Failed to InstantiateSceneObject prefab: ", Pencil_Correction);
			KEMAALEODNH().SetFloat("_ConsoleSettings", Intensity);
			HCGJCMDJPGD().SetFloat("_Value2", Speed_Animation);
			MICHFGAOPKM().SetFloat("_Value2", Corner_Lose);
			NFKFAAHHLLM().SetFloat("arcs", Fade_Paper_to_BackColor);
			EFMCNLELMDO().SetFloat("speed", Fade_With_Original);
			KHCLIAMBBNC().SetColor("[EditorEvent] Exception: ", Back_Color);
			CEKJODEAMGB().SetTexture("ready", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LECCHIAFGGE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MJNPIDGNJMK()
	{
	}

	[SpecialName]
	private Material DOMEEFLPEPJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-99);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material DIOAAHJDMLK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void NKFDNIAKGEO()
	{
		FPHEBLMINDA = Resources.Load("[LevelEditorScene] Print Audio Wave: Done") as Texture2D;
		SCShader = Shader.Find("float,0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FAKGFMFAPDG()
	{
	}

	[SpecialName]
	private Material KHCLIAMBBNC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1485f)
			{
				HBJJOCHGOPH = 619f;
			}
			FOOCJIDNGBB().SetFloat("_TimeX", HBJJOCHGOPH);
			ADGHJOHKEHG().SetColor("shader.none", Pencil_Color);
			FOOCJIDNGBB().SetFloat("_ScreenResolution", Pencil_Size);
			NBPKMLMCHFN.SetFloat("_TimeX", Pencil_Correction);
			ADGHJOHKEHG().SetFloat("{0}{1}:{2}", Intensity);
			MLMKCOINOOH().SetFloat("_TimeX", Speed_Animation);
			HCGJCMDJPGD().SetFloat("[Left]", Corner_Lose);
			NFKFAAHHLLM().SetFloat("_ScreenResolution", Fade_Paper_to_BackColor);
			MICHFGAOPKM().SetFloat("_Value3", Fade_With_Original);
			LPCHMEKDCHI().SetColor("_ScreenResolution", Back_Color);
			BAGICADFBAB().SetTexture("ns.exitgames.com", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1078f)
			{
				HBJJOCHGOPH = 1239f;
			}
			DKKBFFHBHJE().SetFloat("ItemNameText", HBJJOCHGOPH);
			MICHFGAOPKM().SetColor("https://www.youtube.com/watch?v=cDVXukrKo74", Pencil_Color);
			KAFBNOBOIAJ().SetFloat("_Value3", Pencil_Size);
			ADBKPGFMNKO().SetFloat("_Value2", Pencil_Correction);
			KAFBNOBOIAJ().SetFloat("player.licenceaccepted", Intensity);
			ADBKPGFMNKO().SetFloat("settings.volume.sfx", Speed_Animation);
			FOOCJIDNGBB().SetFloat("CameraFilterPack/AAA_BloodOnScreen", Corner_Lose);
			HKHBBBFLGJH().SetFloat("action", Fade_Paper_to_BackColor);
			DOMEEFLPEPJ().SetFloat(". MasterClient: ", Fade_With_Original);
			ACHNOHCLGOO().SetColor(". The RPC has been ignored.", Back_Color);
			CEKJODEAMGB().SetTexture("_ProjInfo", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
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

	private void OHFOLGANOLC()
	{
		FPHEBLMINDA = Resources.Load(", data: ") as Texture2D;
		SCShader = Shader.Find("settings.arcshitsoundtimedelay");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1070f)
			{
				HBJJOCHGOPH = 1932f;
			}
			DIOAAHJDMLK().SetFloat("MapEnd", HBJJOCHGOPH);
			HNFFHCLNBDN().SetColor("_MainTex2", Pencil_Color);
			HKHBBBFLGJH().SetFloat("skin.", Pencil_Size);
			HCGJCMDJPGD().SetFloat("_ScreenResolution", Pencil_Correction);
			ADBKPGFMNKO().SetFloat("[ResourcesManager] Load audio error: ", Intensity);
			DKKBFFHBHJE().SetFloat("mapselector.orderby", Speed_Animation);
			ADBKPGFMNKO().SetFloat("CameraFilterPack/TV_ARCADE_2", Corner_Lose);
			NFKFAAHHLLM().SetFloat("Down", Fade_Paper_to_BackColor);
			HCGJCMDJPGD().SetFloat("_ZCurve", Fade_With_Original);
			ADGHJOHKEHG().SetColor("_LutTex", Back_Color);
			DIOAAHJDMLK().SetTexture("maps.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IEMEHGCFAPD()
	{
	}

	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1133f)
			{
				HBJJOCHGOPH = 309f;
			}
			EJDPNJAEAKJ().SetFloat("End index must in an integer.", HBJJOCHGOPH);
			ENKPNJMPDEB().SetColor(" has no method \"", Pencil_Color);
			ACHNOHCLGOO().SetFloat(".ogg", Pencil_Size);
			FOOCJIDNGBB().SetFloat("Bad parameters for set! Use <language>", Pencil_Correction);
			ENKPNJMPDEB().SetFloat("checkpoint", Intensity);
			FGENHBKMPDA().SetFloat("Items", Speed_Animation);
			HCGJCMDJPGD().SetFloat(", ", Corner_Lose);
			DKKBFFHBHJE().SetFloat("Offline", Fade_Paper_to_BackColor);
			CEKJODEAMGB().SetFloat("SelectorMusicToggle", Fade_With_Original);
			FKEOGPDLBDD().SetColor("CameraFilterPack/TV_Artefact", Back_Color);
			DKKBFFHBHJE().SetTexture("_FixDistance", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CNGAJDBOCLJ()
	{
		FPHEBLMINDA = Resources.Load("0,7,true,0") as Texture2D;
		SCShader = Shader.Find("Creating new item...");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 45f)
			{
				HBJJOCHGOPH = 899f;
			}
			HNFFHCLNBDN().SetFloat("TStart", HBJJOCHGOPH);
			HKHBBBFLGJH().SetColor("player.licenceaccepted", Pencil_Color);
			EJDPNJAEAKJ().SetFloat("[MapsData] Key ", Pencil_Size);
			CEKJODEAMGB().SetFloat("Tab2Content", Pencil_Correction);
			MLMKCOINOOH().SetFloat("NetworkPeer broke!", Intensity);
			HKHBBBFLGJH().SetFloat("_Intensity", Speed_Animation);
			BAGICADFBAB().SetFloat("_Metrics", Corner_Lose);
			HKHBBBFLGJH().SetFloat("sounds/hit_perfect", Fade_Paper_to_BackColor);
			KHCLIAMBBNC().SetFloat("PLEASE WAIT", Fade_With_Original);
			DKKBFFHBHJE().SetColor("SetEnvSpriteColor", Back_Color);
			ADBKPGFMNKO().SetTexture("_Val", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MECJHOJPODB()
	{
	}

	private void JKBMKPDGCHG()
	{
		FPHEBLMINDA = Resources.Load("[MapEditor] Loaded music file: ") as Texture2D;
		SCShader = Shader.Find("achievements.21.completed.workshop.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 888f)
			{
				HBJJOCHGOPH = 1573f;
			}
			PLBEJJIHFPB().SetFloat("difficulty", HBJJOCHGOPH);
			ADGHJOHKEHG().SetColor("OnDeserialize", Pencil_Color);
			HCGJCMDJPGD().SetFloat("Init", Pencil_Size);
			DOMEEFLPEPJ().SetFloat("[MapEditor] Loading music...", Pencil_Correction);
			DOMEEFLPEPJ().SetFloat("ReJoinRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", Intensity);
			CEKJODEAMGB().SetFloat("default", Speed_Animation);
			PLBEJJIHFPB().SetFloat("health", Corner_Lose);
			ACHNOHCLGOO().SetFloat("Can't connect: Loading settings failed. ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings", Fade_Paper_to_BackColor);
			MICHFGAOPKM().SetFloat(" not exist", Fade_With_Original);
			PLBEJJIHFPB().SetColor("KickThePlayer", Back_Color);
			BAGICADFBAB().SetTexture("mapselector.tags.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ENKPNJMPDEB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DNNFHBOOPIN()
	{
		FPHEBLMINDA = Resources.Load("_ExposureAdjustment") as Texture2D;
		SCShader = Shader.Find("[PlayerBase] New highscore");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IBLGHLNNAHN()
	{
		FPHEBLMINDA = Resources.Load("y") as Texture2D;
		SCShader = Shader.Find("_Color");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material FGENHBKMPDA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void GENCBNFIILN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 550f)
			{
				HBJJOCHGOPH = 709f;
			}
			FGENHBKMPDA().SetFloat("settings.disablestoryboard", HBJJOCHGOPH);
			FKEOGPDLBDD().SetColor("player.dragon", Pencil_Color);
			MICHFGAOPKM().SetFloat("VeryHigh", Pencil_Size);
			HCGJCMDJPGD().SetFloat("blue", Pencil_Correction);
			ADGHJOHKEHG().SetFloat("CameraFilterPack_AAA_BloodOnScreen1", Intensity);
			MLMKCOINOOH().SetFloat("Set Satellite Input", Speed_Animation);
			ADBKPGFMNKO().SetFloat("ExitGames.Client.Photon.SocketWebTcp, Assembly-CSharp-firstpass", Corner_Lose);
			MICHFGAOPKM().SetFloat("<color=white>PhotonView Group: ", Fade_Paper_to_BackColor);
			CEKJODEAMGB().SetFloat("CameraFilterPack/Distortion_BigFace", Fade_With_Original);
			KAFBNOBOIAJ().SetColor("_Value", Back_Color);
			FGENHBKMPDA().SetTexture("_SubsampleIndices", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EHCGBJDFMHG()
	{
	}

	private void JKFDDNMPOJH()
	{
		FPHEBLMINDA = Resources.Load("_Value2") as Texture2D;
		SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material ADBKPGFMNKO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void DGCGGKMNPLD()
	{
	}

	private void HGDDCINLDAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
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

	[SpecialName]
	private Material ENKPNJMPDEB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-107);
		}
		return BJFKDHHMLJH;
	}

	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1443f)
			{
				HBJJOCHGOPH = 746f;
			}
			DOMEEFLPEPJ().SetFloat("CameraFilterPack/Blur_Noise", HBJJOCHGOPH);
			HCGJCMDJPGD().SetColor("ERROR: Preview file must be <1MB!", Pencil_Color);
			ADGHJOHKEHG().SetFloat(": ", Pencil_Size);
			DOMEEFLPEPJ().SetFloat("SpawnObj", Pencil_Correction);
			ADGHJOHKEHG().SetFloat("SupportLogger OnDisconnectedFromPhoton().", Intensity);
			KAFBNOBOIAJ().SetFloat(" : ", Speed_Animation);
			FKEOGPDLBDD().SetFloat("init", Corner_Lose);
			KAFBNOBOIAJ().SetFloat("_TimeX", Fade_Paper_to_BackColor);
			HNFFHCLNBDN().SetFloat("BitsData", Fade_With_Original);
			ENKPNJMPDEB().SetColor("PossibleMapPointsText", Back_Color);
			FGENHBKMPDA().SetTexture("float,1", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ENKPNJMPDEB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JFJLGJEPEAA()
	{
		FPHEBLMINDA = Resources.Load("inventory.selected.") as Texture2D;
		SCShader = Shader.Find("yyyy-MM-dd HH:mm:ss");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JLNNHKPHMAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material ADGHJOHKEHG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-118);
		}
		return BJFKDHHMLJH;
	}

	private void Start()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_Paper3") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Drawing_Paper2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1005f)
			{
				HBJJOCHGOPH = 1743f;
			}
			HNFFHCLNBDN().SetFloat(".lastCheckpoint.playerdistance", HBJJOCHGOPH);
			HKHBBBFLGJH().SetColor("_Bullet_3", Pencil_Color);
			LPCHMEKDCHI().SetFloat("_BlurVector", Pencil_Size);
			NBPKMLMCHFN.SetFloat("_SpherePositionX", Pencil_Correction);
			ACHNOHCLGOO().SetFloat(" ", Intensity);
			KEMAALEODNH().SetFloat("_RampTex", Speed_Animation);
			MLMKCOINOOH().SetFloat("_Distortion", Corner_Lose);
			HNFFHCLNBDN().SetFloat("_FgOverlap", Fade_Paper_to_BackColor);
			EJDPNJAEAKJ().SetFloat(".mp3", Fade_With_Original);
			ENKPNJMPDEB().SetColor("_Distortion", Back_Color);
			BAGICADFBAB().SetTexture("PhotonView with ID {0} wasn't properly unregistered! Please report this case to developer@photonengine.com", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CFIAKIJAILI()
	{
	}

	private void GMELGGJOPBB()
	{
	}

	private void DOOIKOEBBJB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1689f)
			{
				HBJJOCHGOPH = 1751f;
			}
			ACHNOHCLGOO().SetFloat("input", HBJJOCHGOPH);
			FKEOGPDLBDD().SetColor("[PlayerController] ", Pencil_Color);
			KEMAALEODNH().SetFloat("Drop_Near", Pencil_Size);
			LPCHMEKDCHI().SetFloat(" method: ", Pencil_Correction);
			MICHFGAOPKM().SetFloat("_Vignetting2", Intensity);
			KHCLIAMBBNC().SetFloat("float,0", Speed_Animation);
			FGENHBKMPDA().SetFloat("_Value", Corner_Lose);
			LPCHMEKDCHI().SetFloat("SetParticlesColor", Fade_Paper_to_BackColor);
			DKKBFFHBHJE().SetFloat("SaveButton", Fade_With_Original);
			PLBEJJIHFPB().SetColor("Start", Back_Color);
			CEKJODEAMGB().SetTexture("Mouse ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CEKJODEAMGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HLDFOJMHKNL()
	{
	}

	private void ILCFPCIPENO()
	{
		FPHEBLMINDA = Resources.Load("DestroyRpc") as Texture2D;
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JHLGHODFJOO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FLKEJJEGCFA()
	{
		FPHEBLMINDA = Resources.Load("_Value3") as Texture2D;
		SCShader = Shader.Find("curScn");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JNALDALAJLG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BDBJEDIOKBN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EJJEDJIOFAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IKDNLHLBHID()
	{
		FPHEBLMINDA = Resources.Load(". Should be just one?") as Texture2D;
		SCShader = Shader.Find("{0:0} day{1}, ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NNFMIAFHMJM()
	{
		FPHEBLMINDA = Resources.Load("Exception caught! ") as Texture2D;
		SCShader = Shader.Find("LevelEditor/icons");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HIKKPDACJGI()
	{
	}

	private void LOMDIOLNFHI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1696f)
			{
				HBJJOCHGOPH = 1445f;
			}
			HKHBBBFLGJH().SetFloat("Expected protocol set to UDP, due to encryption mode DatagramEncryption. Changing protocol in PhotonServerSettings from: ", HBJJOCHGOPH);
			FKEOGPDLBDD().SetColor("Editor/", Pencil_Color);
			PLBEJJIHFPB().SetFloat("_Offsets", Pencil_Size);
			NFKFAAHHLLM().SetFloat("threshold", Pencil_Correction);
			CEKJODEAMGB().SetFloat("STICKRVER", Intensity);
			DKKBFFHBHJE().SetFloat("#onrankchangeuptext", Speed_Animation);
			KAFBNOBOIAJ().SetFloat("_Radius", Corner_Lose);
			BAGICADFBAB().SetFloat("Texture2", Fade_Paper_to_BackColor);
			BAGICADFBAB().SetFloat("LoadPlayerSkin", Fade_With_Original);
			CEKJODEAMGB().SetColor("PossibleMapMaxScoreText", Back_Color);
			NFKFAAHHLLM().SetTexture("BadgeText", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOMEEFLPEPJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NPBDIMJDMGA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 732f)
			{
				HBJJOCHGOPH = 1880f;
			}
			ADBKPGFMNKO().SetFloat("_Blue_B", HBJJOCHGOPH);
			KHCLIAMBBNC().SetColor("BadgeText", Pencil_Color);
			KEMAALEODNH().SetFloat(".png", Pencil_Size);
			FOOCJIDNGBB().SetFloat("[ResourcesManager] Unloading data resources", Pencil_Correction);
			HKHBBBFLGJH().SetFloat("DPADVER", Intensity);
			NBPKMLMCHFN.SetFloat("_Offsets", Speed_Animation);
			DIOAAHJDMLK().SetFloat("ItemNameBGImage", Corner_Lose);
			CEKJODEAMGB().SetFloat("_ReflectionTexture1", Fade_Paper_to_BackColor);
			FGENHBKMPDA().SetFloat("[PlayerController] ", Fade_With_Original);
			DKKBFFHBHJE().SetColor(" or ", Back_Color);
			DOMEEFLPEPJ().SetTexture("[Steamworks.NET] SteamAPI_Init() failed. Refer to Valve's documentation or the comment above this line for more information.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LCJHDLKJEOM()
	{
	}

	private void BOLBPPHJBMI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FPHLDMMAOEF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 275f)
			{
				HBJJOCHGOPH = 1074f;
			}
			KAFBNOBOIAJ().SetFloat("_Green_R", HBJJOCHGOPH);
			HNFFHCLNBDN().SetColor("_Value5", Pencil_Color);
			PLBEJJIHFPB().SetFloat("_MainTex2", Pencil_Size);
			EFMCNLELMDO().SetFloat("_TimeX", Pencil_Correction);
			EFMCNLELMDO().SetFloat("BadgeImage", Intensity);
			KHCLIAMBBNC().SetFloat("_Value3", Speed_Animation);
			NBPKMLMCHFN.SetFloat("https://steamcommunity.com/app/513510/workshop/", Corner_Lose);
			KEMAALEODNH().SetFloat("Observed type is not serializable: ", Fade_Paper_to_BackColor);
			HCGJCMDJPGD().SetFloat("Mar", Fade_With_Original);
			ADGHJOHKEHG().SetColor("workshop.", Back_Color);
			KEMAALEODNH().SetTexture("Done! You are a contributor until: ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OIBMHPIFAKK()
	{
	}

	private void KPOCGNOKNOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1366f)
			{
				HBJJOCHGOPH = 1178f;
			}
			DIOAAHJDMLK().SetFloat("_Value5", HBJJOCHGOPH);
			HCGJCMDJPGD().SetColor("_ClutTex", Pencil_Color);
			FGENHBKMPDA().SetFloat("attempted to spawn go (", Pencil_Size);
			LPCHMEKDCHI().SetFloat("Can't find PhotonView of incoming OwnershipRequest. ViewId not found: ", Pencil_Correction);
			EJDPNJAEAKJ().SetFloat("Event Received", Intensity);
			ACHNOHCLGOO().SetFloat("_MainTex2", Speed_Animation);
			LPCHMEKDCHI().SetFloat("Most likely the game became empty during the switch to GameServer.", Corner_Lose);
			DKKBFFHBHJE().SetFloat("settings_bindings_controller_type", Fade_Paper_to_BackColor);
			NFKFAAHHLLM().SetFloat("22x3", Fade_With_Original);
			LPCHMEKDCHI().SetColor("settings_bindings_", Back_Color);
			DKKBFFHBHJE().SetTexture("yes", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EFECEKPFOEM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MPJCMKFFKHH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1044f)
			{
				HBJJOCHGOPH = 1912f;
			}
			NBPKMLMCHFN.SetFloat("ItemsCountText", HBJJOCHGOPH);
			EFMCNLELMDO().SetColor("_Value7", Pencil_Color);
			FOOCJIDNGBB().SetFloat("CameraFilterPack/Oculus_ThermaVision", Pencil_Size);
			EFMCNLELMDO().SetFloat("colorB", Pencil_Correction);
			EJDPNJAEAKJ().SetFloat("DPADHOR", Intensity);
			NFKFAAHHLLM().SetFloat("_Value", Speed_Animation);
			MICHFGAOPKM().SetFloat("OK", Corner_Lose);
			HKHBBBFLGJH().SetFloat("_TimeX", Fade_Paper_to_BackColor);
			ENKPNJMPDEB().SetFloat("CheckResources () for ", Fade_With_Original);
			HKHBBBFLGJH().SetColor("CameraFilterPack/RainFX", Back_Color);
			ENKPNJMPDEB().SetTexture("_Visualize", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FOOCJIDNGBB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AIJGAJIOJDJ()
	{
	}

	[SpecialName]
	private Material HKHBBBFLGJH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-109);
		}
		return BJFKDHHMLJH;
	}

	private void LFBGJIIECLD()
	{
		FPHEBLMINDA = Resources.Load("#close") as Texture2D;
		SCShader = Shader.Find("MainThreadExecuter");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BNEJMABFKJE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EJFJENFKLND()
	{
	}

	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1284f)
			{
				HBJJOCHGOPH = 866f;
			}
			DIOAAHJDMLK().SetFloat("FileMenu", HBJJOCHGOPH);
			HNFFHCLNBDN().SetColor("_Value", Pencil_Color);
			MLMKCOINOOH().SetFloat("CameraFilterPack/TV_Old", Pencil_Size);
			FGENHBKMPDA().SetFloat("OxOD.lastPath", Pencil_Correction);
			NBPKMLMCHFN.SetFloat("_Bullet_7", Intensity);
			EJDPNJAEAKJ().SetFloat("Vertical", Speed_Animation);
			KEMAALEODNH().SetFloat(",", Corner_Lose);
			EJDPNJAEAKJ().SetFloat(" not exist", Fade_Paper_to_BackColor);
			CEKJODEAMGB().SetFloat(" not exist", Fade_With_Original);
			HCGJCMDJPGD().SetColor("[NetworkManager] Joined main lobby", Back_Color);
			ACHNOHCLGOO().SetTexture("_Value", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material EFMCNLELMDO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
		}
		return BJFKDHHMLJH;
	}

	private void BMOFEBKGLFI()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack/Fly_Vision") as Texture2D;
		SCShader = Shader.Find("_Size");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KFMEAMBLODG()
	{
	}

	private void PHJJHFBLICM()
	{
	}

	private void OCMKCBBCEFG()
	{
	}

	[SpecialName]
	private Material BAGICADFBAB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)108;
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

	[SpecialName]
	private Material MLMKCOINOOH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material ACHNOHCLGOO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return BJFKDHHMLJH;
	}

	private void FANADGBGCPI()
	{
		FPHEBLMINDA = Resources.Load("#rate!") as Texture2D;
		SCShader = Shader.Find("_Value2");
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

	private void FIKFJDFELIP()
	{
		FPHEBLMINDA = Resources.Load("settings.volume.sfx") as Texture2D;
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BKGJOECFMID()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material KAFBNOBOIAJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInHierarchy);
		}
		return BJFKDHHMLJH;
	}

	private void IMCKJCHKMKB()
	{
		FPHEBLMINDA = Resources.Load(".lastCheckpoint.currentCombo") as Texture2D;
		SCShader = Shader.Find("_FarCamera");
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
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KEMAALEODNH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)113;
		}
		return BJFKDHHMLJH;
	}

	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1941f)
			{
				HBJJOCHGOPH = 534f;
			}
			DOMEEFLPEPJ().SetFloat("_FrustumCornersWS", HBJJOCHGOPH);
			NBPKMLMCHFN.SetColor("DestroyPlayerObjects() failed, cause players can only destroy their own GameObjects. A Master Client can destroy anyone's. This is master: ", Pencil_Color);
			MLMKCOINOOH().SetFloat("_BlurredColor", Pencil_Size);
			KEMAALEODNH().SetFloat("2;13;14;15;16", Pencil_Correction);
			BAGICADFBAB().SetFloat("NEW", Intensity);
			ENKPNJMPDEB().SetFloat("The observed monobehaviour (", Speed_Animation);
			KEMAALEODNH().SetFloat("View", Corner_Lose);
			KEMAALEODNH().SetFloat(";", Fade_Paper_to_BackColor);
			DOMEEFLPEPJ().SetFloat("_ReflectionTexture0", Fade_With_Original);
			NBPKMLMCHFN.SetColor("_TimeX", Back_Color);
			FGENHBKMPDA().SetTexture(".", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PFNFPINPCMH()
	{
	}

	[SpecialName]
	private Material EJDPNJAEAKJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-101);
		}
		return BJFKDHHMLJH;
	}

	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1904f)
			{
				HBJJOCHGOPH = 1732f;
			}
			KAFBNOBOIAJ().SetFloat("EnableRankedNotificationsToggle", HBJJOCHGOPH);
			ADBKPGFMNKO().SetColor("maps.", Pencil_Color);
			FGENHBKMPDA().SetFloat("_TimeX", Pencil_Size);
			MICHFGAOPKM().SetFloat("_TimeX", Pencil_Correction);
			BAGICADFBAB().SetFloat("_Offsets", Intensity);
			KHCLIAMBBNC().SetFloat("yyyy-MM-dd HH:mm:ss", Speed_Animation);
			KEMAALEODNH().SetFloat("No Description", Corner_Lose);
			MICHFGAOPKM().SetFloat("_ScreenResolution", Fade_Paper_to_BackColor);
			NBPKMLMCHFN.SetFloat("_Value5", Fade_With_Original);
			DKKBFFHBHJE().SetColor("InfoCanvas", Back_Color);
			EFMCNLELMDO().SetTexture("play", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1807f)
			{
				HBJJOCHGOPH = 1761f;
			}
			FOOCJIDNGBB().SetFloat("ShadersToggle", HBJJOCHGOPH);
			FGENHBKMPDA().SetColor("player.redarc", Pencil_Color);
			ENKPNJMPDEB().SetFloat("settings.arcsdestroydelay", Pencil_Size);
			FKEOGPDLBDD().SetFloat("Tab1Content", Pencil_Correction);
			FGENHBKMPDA().SetFloat("_MainTex2", Intensity);
			KAFBNOBOIAJ().SetFloat("_Value1", Speed_Animation);
			ADGHJOHKEHG().SetFloat("CameraFilterPack_TV_BrokenGlass_2", Corner_Lose);
			DOMEEFLPEPJ().SetFloat(",", Fade_Paper_to_BackColor);
			NBPKMLMCHFN.SetFloat("LoadingStatusText", Fade_With_Original);
			MLMKCOINOOH().SetColor("CameraFilterPack/Colors_DarkColor", Back_Color);
			HKHBBBFLGJH().SetTexture("_Distortion", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HJPCJGOEKMF()
	{
		FPHEBLMINDA = Resources.Load("workshop.") as Texture2D;
		SCShader = Shader.Find("_TexelOffsetScale");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CPCDFMMLHLO()
	{
	}

	private void JOONHGHGKKF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material MICHFGAOPKM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material FKEOGPDLBDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NFKFAAHHLLM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 105f)
			{
				HBJJOCHGOPH = 749f;
			}
			ADGHJOHKEHG().SetFloat("My New Mod Pack", HBJJOCHGOPH);
			MICHFGAOPKM().SetColor("_Near", Pencil_Color);
			DIOAAHJDMLK().SetFloat("_ScreenResolution", Pencil_Size);
			ADGHJOHKEHG().SetFloat("_ScreenResolution", Pencil_Correction);
			DKKBFFHBHJE().SetFloat("ready", Intensity);
			KEMAALEODNH().SetFloat("_TimeX", Speed_Animation);
			ACHNOHCLGOO().SetFloat("[DiscordController] Responding no to Ask to Join request", Corner_Lose);
			KHCLIAMBBNC().SetFloat("#yes", Fade_Paper_to_BackColor);
			EJDPNJAEAKJ().SetFloat("HighScaleShot", Fade_With_Original);
			FKEOGPDLBDD().SetColor(": ", Back_Color);
			ACHNOHCLGOO().SetTexture("float,0", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JOJFHFHOCHO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material CEKJODEAMGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInHierarchy);
		}
		return BJFKDHHMLJH;
	}

	private void FJKJGBLPDGG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1483f)
			{
				HBJJOCHGOPH = 1473f;
			}
			KHCLIAMBBNC().SetFloat("#currentbpm: ", HBJJOCHGOPH);
			HCGJCMDJPGD().SetColor("_ScreenResolution", Pencil_Color);
			PLBEJJIHFPB().SetFloat("GlassAberration", Pencil_Size);
			DOMEEFLPEPJ().SetFloat("_GrainOffsetScale", Pencil_Correction);
			MICHFGAOPKM().SetFloat("settings.enableranking", Intensity);
			KEMAALEODNH().SetFloat("_Distance", Speed_Animation);
			ENKPNJMPDEB().SetFloat("_Value", Corner_Lose);
			ADGHJOHKEHG().SetFloat("_Value2", Fade_Paper_to_BackColor);
			PLBEJJIHFPB().SetFloat("RestartButton", Fade_With_Original);
			HNFFHCLNBDN().SetColor("achievements.21.completed.", Back_Color);
			EFMCNLELMDO().SetTexture("OK", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
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
			if (HBJJOCHGOPH > 1586f)
			{
				HBJJOCHGOPH = 1174f;
			}
			ADBKPGFMNKO().SetFloat("_AlphaMask", HBJJOCHGOPH);
			DIOAAHJDMLK().SetColor("_TimeX", Pencil_Color);
			DKKBFFHBHJE().SetFloat(" - ", Pencil_Size);
			BAGICADFBAB().SetFloat("00", Pencil_Correction);
			HNFFHCLNBDN().SetFloat("BloodAlternative3", Intensity);
			NBPKMLMCHFN.SetFloat("_Size", Speed_Animation);
			EFMCNLELMDO().SetFloat("_ScreenResolution", Corner_Lose);
			ADGHJOHKEHG().SetFloat("_ScreenResolution", Fade_Paper_to_BackColor);
			FKEOGPDLBDD().SetFloat("id", Fade_With_Original);
			KEMAALEODNH().SetColor("_Value2", Back_Color);
			CEKJODEAMGB().SetTexture(". We have no such PhotonView! Ignored this if you're leaving a room. State: ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FOOCJIDNGBB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LPCHMEKDCHI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)97;
		}
		return BJFKDHHMLJH;
	}

	private void PMPKMGKAAJH()
	{
		FPHEBLMINDA = Resources.Load("[Up]") as Texture2D;
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material HCGJCMDJPGD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void AEIJFLJEABG()
	{
	}

	private void NDAJBJFJGCF()
	{
	}

	private void EDBEHEKMGFH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GOANCMNGDLE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 124f)
			{
				HBJJOCHGOPH = 1569f;
			}
			HNFFHCLNBDN().SetFloat("_FixDistance", HBJJOCHGOPH);
			FGENHBKMPDA().SetColor(" not exist", Pencil_Color);
			NFKFAAHHLLM().SetFloat("[MapEditor] Updating map assets", Pencil_Size);
			HCGJCMDJPGD().SetFloat("ComboText", Pencil_Correction);
			PLBEJJIHFPB().SetFloat("UpdateNewsTileStart", Intensity);
			HNFFHCLNBDN().SetFloat("_VignetteSettings", Speed_Animation);
			ACHNOHCLGOO().SetFloat("SetSatelliteTrailWidth", Corner_Lose);
			FKEOGPDLBDD().SetFloat("_Vibrance", Fade_Paper_to_BackColor);
			FOOCJIDNGBB().SetFloat("default", Fade_With_Original);
			NFKFAAHHLLM().SetColor("LT", Back_Color);
			KEMAALEODNH().SetTexture("ws://", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LMBDNPLDGIJ()
	{
	}

	[SpecialName]
	private Material DKKBFFHBHJE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
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
}
