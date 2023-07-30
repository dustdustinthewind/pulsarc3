// CameraFilterPack_Drawing_Paper2
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Drawing/Paper2")]
[ExecuteInEditMode]
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
			NFKFAAHHLLM().SetFloat("workshop.", HBJJOCHGOPH);
			HKHBBBFLGJH().SetColor("settings.disablestoryboard", Pencil_Color);
			ACHNOHCLGOO().SetFloat("Object ID. Case-Sensitive", Pencil_Size);
			EJDPNJAEAKJ().SetFloat("OxOD.lastPath", Pencil_Correction);
			ACHNOHCLGOO().SetFloat("_TimeX", Intensity);
			ENKPNJMPDEB().SetFloat("_Distortion", Speed_Animation);
			KAFBNOBOIAJ().SetFloat(".status", Corner_Lose);
			LPCHMEKDCHI().SetFloat("CameraFilterPack/Drawing_Paper2", Fade_Paper_to_BackColor);
			KAFBNOBOIAJ().SetFloat("inventory.selected.", Fade_With_Original);
			NFKFAAHHLLM().SetColor("CameraFilterPack_Paper3", Back_Color);
			HNFFHCLNBDN().SetTexture("_Value4", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOMEEFLPEPJ());
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
			HCGJCMDJPGD().SetFloat("CameraFilterPack/Vision_Hell_Blood", HBJJOCHGOPH);
			EFMCNLELMDO().SetColor("Metal", Pencil_Color);
			FGENHBKMPDA().SetFloat("_Value2", Pencil_Size);
			HNFFHCLNBDN().SetFloat("challenges.", Pencil_Correction);
			NBPKMLMCHFN.SetFloat("_Amount", Intensity);
			HNFFHCLNBDN().SetFloat("shader.frost", Speed_Animation);
			ADBKPGFMNKO().SetFloat("maps.", Corner_Lose);
			HNFFHCLNBDN().SetFloat("_Value3", Fade_Paper_to_BackColor);
			HCGJCMDJPGD().SetFloat("InfoCanvas", Fade_With_Original);
			DOMEEFLPEPJ().SetColor("MultiplayerButton", Back_Color);
			HKHBBBFLGJH().SetTexture("RPC can't be sent to target PhotonPlayer being null! Did not send \"", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
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
			ENKPNJMPDEB().SetFloat("_NoisePerChannel", HBJJOCHGOPH);
			HNFFHCLNBDN().SetColor("SetParticlesGravity", Pencil_Color);
			KAFBNOBOIAJ().SetFloat("_MainTex2", Pencil_Size);
			ADGHJOHKEHG().SetFloat("OnJoinedLobby(). This client is connected and does get a room-list, which gets stored as PhotonNetwork.GetRoomList(). This script now calls: PhotonNetwork.JoinRandomRoom();", Pencil_Correction);
			KAFBNOBOIAJ().SetFloat("distance", Intensity);
			ACHNOHCLGOO().SetFloat("_Bloom", Speed_Animation);
			DKKBFFHBHJE().SetFloat("ItemNameText", Corner_Lose);
			BAGICADFBAB().SetFloat("Creating new item...", Fade_Paper_to_BackColor);
			NBPKMLMCHFN.SetFloat("View ({3}){0} on {1} {2}", Fade_With_Original);
			ADBKPGFMNKO().SetColor("\n", Back_Color);
			FGENHBKMPDA().SetTexture("_TimeX", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LGHCJCFHEMF()
	{
		FPHEBLMINDA = Resources.Load(".sawoutdatedmessage") as Texture2D;
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
		SCShader = Shader.Find("_Value2");
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
			DOMEEFLPEPJ().SetFloat(",", HBJJOCHGOPH);
			DIOAAHJDMLK().SetColor("_ScreenResolution", Pencil_Color);
			DIOAAHJDMLK().SetFloat("_Value7", Pencil_Size);
			FKEOGPDLBDD().SetFloat("OnAwakeRPC", Pencil_Correction);
			KAFBNOBOIAJ().SetFloat("[PlayerController] ", Intensity);
			EFMCNLELMDO().SetFloat("_Value", Speed_Animation);
			EJDPNJAEAKJ().SetFloat("_ScreenResolution", Corner_Lose);
			MLMKCOINOOH().SetFloat("settings.crosshairopacity", Fade_Paper_to_BackColor);
			CEKJODEAMGB().SetFloat("MenuScene", Fade_With_Original);
			NBPKMLMCHFN.SetColor("MenuScene", Back_Color);
			CEKJODEAMGB().SetTexture("action", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KHCLIAMBBNC());
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
			DKKBFFHBHJE().SetFloat("#", HBJJOCHGOPH);
			ACHNOHCLGOO().SetColor("SetSatelliteInput", Pencil_Color);
			ENKPNJMPDEB().SetFloat(":", Pencil_Size);
			MLMKCOINOOH().SetFloat("[SaveSystem] Outdated savefile found", Pencil_Correction);
			ENKPNJMPDEB().SetFloat("Data/Editor/leveltemplate", Intensity);
			DKKBFFHBHJE().SetFloat("Speed is a lerp speed of color changing. Greater values means faster changing. 0 - intant change", Speed_Animation);
			EFMCNLELMDO().SetFloat("UsernameText", Corner_Lose);
			NFKFAAHHLLM().SetFloat("1278033234", Fade_Paper_to_BackColor);
			LPCHMEKDCHI().SetFloat("InputField", Fade_With_Original);
			MICHFGAOPKM().SetColor("BitsData", Back_Color);
			DOMEEFLPEPJ().SetTexture("#forever", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
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
			KHCLIAMBBNC().SetFloat("shaders", HBJJOCHGOPH);
			ADGHJOHKEHG().SetColor("settings.shaders", Pencil_Color);
			EJDPNJAEAKJ().SetFloat("Soundtrack", Pencil_Size);
			DOMEEFLPEPJ().SetFloat(". Client should be in a room. Current connectionStateDetailed: ", Pencil_Correction);
			KEMAALEODNH().SetFloat("Hidden/Fast Approximate Anti-aliasing", Intensity);
			FGENHBKMPDA().SetFloat("_Value", Speed_Animation);
			FKEOGPDLBDD().SetFloat("_Value", Corner_Lose);
			MLMKCOINOOH().SetFloat("MascotChallenge2019", Fade_Paper_to_BackColor);
			KEMAALEODNH().SetFloat("speed", Fade_With_Original);
			MICHFGAOPKM().SetColor("_EmissionColor", Back_Color);
			ADGHJOHKEHG().SetTexture("_EmissionGain", FPHEBLMINDA);
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
		FPHEBLMINDA = Resources.Load("#yes") as Texture2D;
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
			DIOAAHJDMLK().SetFloat("CameraFilterPack/Vision_Tunnel", HBJJOCHGOPH);
			CEKJODEAMGB().SetColor("shader.pixel", Pencil_Color);
			DIOAAHJDMLK().SetFloat("_Value2", Pencil_Size);
			PLBEJJIHFPB().SetFloat("CameraFilterPack/Glasses_On", Pencil_Correction);
			ACHNOHCLGOO().SetFloat("ws://", Intensity);
			DOMEEFLPEPJ().SetFloat("_MainTex2", Speed_Animation);
			FGENHBKMPDA().SetFloat("[Left]", Corner_Lose);
			FKEOGPDLBDD().SetFloat("_ScreenResolution", Fade_Paper_to_BackColor);
			DIOAAHJDMLK().SetFloat("_Value2", Fade_With_Original);
			EJDPNJAEAKJ().SetColor("_Intensity", Back_Color);
			EJDPNJAEAKJ().SetTexture("wss://", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
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
			MICHFGAOPKM().SetFloat("ItemNameBGImage", HBJJOCHGOPH);
			HCGJCMDJPGD().SetColor("/files/editor_manual.pdf", Pencil_Color);
			ENKPNJMPDEB().SetFloat("_Value", Pencil_Size);
			KAFBNOBOIAJ().SetFloat("_Value2", Pencil_Correction);
			CEKJODEAMGB().SetFloat("player.licenceaccepted", Intensity);
			MICHFGAOPKM().SetFloat("ItemNameText", Speed_Animation);
			LPCHMEKDCHI().SetFloat("CameraFilterPack_AAA_BloodOnScreen1", Corner_Lose);
			BAGICADFBAB().SetFloat("menuVolume", Fade_Paper_to_BackColor);
			EJDPNJAEAKJ().SetFloat(". local RequestedView.ownerId: ", Fade_With_Original);
			FOOCJIDNGBB().SetColor("\" on viewID ", Back_Color);
			EJDPNJAEAKJ().SetTexture("_Intensity", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
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
		FPHEBLMINDA = Resources.Load("No Name") as Texture2D;
		SCShader = Shader.Find("settings.arcsnohitsoundtimedelay");
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
			ENKPNJMPDEB().SetFloat("menu.playedsolo", HBJJOCHGOPH);
			ADBKPGFMNKO().SetColor("UseScanLine", Pencil_Color);
			FGENHBKMPDA().SetFloat("http", Pencil_Size);
			PLBEJJIHFPB().SetFloat("_Intensity", Pencil_Correction);
			LPCHMEKDCHI().SetFloat(" url: ", Intensity);
			EJDPNJAEAKJ().SetFloat("mapselector.orderby", Speed_Animation);
			KEMAALEODNH().SetFloat("Fade", Corner_Lose);
			DOMEEFLPEPJ().SetFloat("GetLive", Fade_Paper_to_BackColor);
			KEMAALEODNH().SetFloat("_RgbTex", Fade_With_Original);
			EFMCNLELMDO().SetColor(" cannot be used as a 3D LUT.", Back_Color);
			KAFBNOBOIAJ().SetTexture(",", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MLMKCOINOOH());
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
			EFMCNLELMDO().SetFloat("Start index must in an integer.", HBJJOCHGOPH);
			KEMAALEODNH().SetColor("null", Pencil_Color);
			FGENHBKMPDA().SetFloat(".mp3", Pencil_Size);
			CEKJODEAMGB().SetFloat("keys", Pencil_Correction);
			KEMAALEODNH().SetFloat("Edited unlock conditions", Intensity);
			ADBKPGFMNKO().SetFloat("ScrollPanel", Speed_Animation);
			ENKPNJMPDEB().SetFloat(", ", Corner_Lose);
			MICHFGAOPKM().SetFloat("Offline", Fade_Paper_to_BackColor);
			KAFBNOBOIAJ().SetFloat("SelectorMusicToggle", Fade_With_Original);
			ACHNOHCLGOO().SetColor("_ScreenResolution", Back_Color);
			KHCLIAMBBNC().SetTexture("_FixDistance", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CNGAJDBOCLJ()
	{
		FPHEBLMINDA = Resources.Load("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data") as Texture2D;
		SCShader = Shader.Find("arcs");
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
			FKEOGPDLBDD().SetFloat("Turn", HBJJOCHGOPH);
			ADBKPGFMNKO().SetColor("player.licenceaccepted", Pencil_Color);
			KHCLIAMBBNC().SetFloat("maps.", Pencil_Size);
			HCGJCMDJPGD().SetFloat("LevelURLInputField", Pencil_Correction);
			HNFFHCLNBDN().SetFloat("Error: you cannot write/send to this stream that you are reading!", Intensity);
			HKHBBBFLGJH().SetFloat("_SweaterSize", Speed_Animation);
			PLBEJJIHFPB().SetFloat("_AreaTex", Corner_Lose);
			HNFFHCLNBDN().SetFloat("skin.hit_wrong", Fade_Paper_to_BackColor);
			KHCLIAMBBNC().SetFloat("PLEASE WAIT", Fade_With_Original);
			KHCLIAMBBNC().SetColor("SetParticlesCountPerBeat", Back_Color);
			EJDPNJAEAKJ().SetTexture("_Sat", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
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
		FPHEBLMINDA = Resources.Load("/") as Texture2D;
		SCShader = Shader.Find("1332644700");
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
			ADGHJOHKEHG().SetFloat("maphash", HBJJOCHGOPH);
			ENKPNJMPDEB().SetColor("saveGameName ", Pencil_Color);
			DKKBFFHBHJE().SetFloat("[MapEditor] Loading map: ", Pencil_Size);
			KAFBNOBOIAJ().SetFloat("[MapEditor] Prepairing map editor...", Pencil_Correction);
			HKHBBBFLGJH().SetFloat("offline room", Intensity);
			PLBEJJIHFPB().SetFloat(".png", Speed_Animation);
			HKHBBBFLGJH().SetFloat("Messages (shift+tab)", Corner_Lose);
			KEMAALEODNH().SetFloat("Error: Can not set the OnSerialize rate higher than the overall SendRate.", Fade_Paper_to_BackColor);
			LPCHMEKDCHI().SetFloat(": ", Fade_With_Original);
			HKHBBBFLGJH().SetColor("KickThePlayer", Back_Color);
			NFKFAAHHLLM().SetTexture("mapselector.tags.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DNNFHBOOPIN()
	{
		FPHEBLMINDA = Resources.Load("_RangeScale") as Texture2D;
		SCShader = Shader.Find("[PlayerBase] New highscore");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IBLGHLNNAHN()
	{
		FPHEBLMINDA = Resources.Load("y") as Texture2D;
		SCShader = Shader.Find("[EditorEvent] Exception: ");
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
			BAGICADFBAB().SetFloat("settings.enablehitsoundsinrelax", HBJJOCHGOPH);
			CEKJODEAMGB().SetColor("player.goldarc", Pencil_Color);
			DOMEEFLPEPJ().SetFloat("VeryHigh", Pencil_Size);
			ACHNOHCLGOO().SetFloat("violet", Pencil_Correction);
			BAGICADFBAB().SetFloat("CameraFilterPack_AAA_BloodOnScreen1", Intensity);
			DKKBFFHBHJE().SetFloat("Set Satellite Input", Speed_Animation);
			CEKJODEAMGB().SetFloat("Using WebSocket to connect NameServer (AuthMode is AuthOnceWss).", Corner_Lose);
			HCGJCMDJPGD().SetFloat("Subscribed cells:\n", Fade_Paper_to_BackColor);
			FKEOGPDLBDD().SetFloat("_ScreenResolution", Fade_With_Original);
			ADBKPGFMNKO().SetColor("_Value", Back_Color);
			ACHNOHCLGOO().SetTexture("_ReprojectionMatrix", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BAGICADFBAB());
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
			FKEOGPDLBDD().SetFloat("CameraFilterPack/Blur_Noise", HBJJOCHGOPH);
			MICHFGAOPKM().SetColor("ERROR: Make sure your mod contains at leats one file!", Pencil_Color);
			HNFFHCLNBDN().SetFloat("SetEnvSpriteImage", Pencil_Size);
			MLMKCOINOOH().SetFloat("[Up]", Pencil_Correction);
			ENKPNJMPDEB().SetFloat("). ", Intensity);
			LPCHMEKDCHI().SetFloat("Result for ", Speed_Animation);
			EFMCNLELMDO().SetFloat("init", Corner_Lose);
			KEMAALEODNH().SetFloat("CameraFilterPack/FX_Glitch1", Fade_Paper_to_BackColor);
			EJDPNJAEAKJ().SetFloat("BitsData", Fade_With_Original);
			FGENHBKMPDA().SetColor("HightScoreMaxPointsText", Back_Color);
			NFKFAAHHLLM().SetTexture("float,1", FPHEBLMINDA);
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
		SCShader = Shader.Find("yes");
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
			ADBKPGFMNKO().SetFloat(".lastCheckpoint.comboScore", HBJJOCHGOPH);
			NFKFAAHHLLM().SetColor("_Bullet_2", Pencil_Color);
			HKHBBBFLGJH().SetFloat("_BlurVector", Pencil_Size);
			EJDPNJAEAKJ().SetFloat("_SphereSize", Pencil_Correction);
			KEMAALEODNH().SetFloat("master", Intensity);
			KEMAALEODNH().SetFloat("_Offset", Speed_Animation);
			BAGICADFBAB().SetFloat("CameraFilterPack/TV_Vintage", Corner_Lose);
			HCGJCMDJPGD().SetFloat("_Offsets", Fade_Paper_to_BackColor);
			NBPKMLMCHFN.SetFloat("Data/Skins/", Fade_With_Original);
			FKEOGPDLBDD().SetColor("_Distortion", Back_Color);
			FKEOGPDLBDD().SetTexture(". The group number should be at least 1.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ENKPNJMPDEB());
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
			ACHNOHCLGOO().SetFloat("Object ID. Case-Sensitive", HBJJOCHGOPH);
			FKEOGPDLBDD().SetColor(" not exist", Pencil_Color);
			ADBKPGFMNKO().SetFloat("Drop_Near", Pencil_Size);
			ACHNOHCLGOO().SetFloat(" scene: ", Pencil_Correction);
			FGENHBKMPDA().SetFloat("Vignette", Intensity);
			NBPKMLMCHFN.SetFloat("float,0", Speed_Animation);
			EFMCNLELMDO().SetFloat("_TimeX", Corner_Lose);
			HCGJCMDJPGD().SetFloat("SetSatelliteSensitivity", Fade_Paper_to_BackColor);
			DIOAAHJDMLK().SetFloat("SaveButton", Fade_With_Original);
			MLMKCOINOOH().SetColor("Back", Back_Color);
			NBPKMLMCHFN.SetTexture("Mouse", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MICHFGAOPKM());
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
		FPHEBLMINDA = Resources.Load("RPC: 'OnAwakeRPC' PhotonView: ") as Texture2D;
		SCShader = Shader.Find("_TimeX");
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
		FPHEBLMINDA = Resources.Load("_Value2") as Texture2D;
		SCShader = Shader.Find(" [");
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
		FPHEBLMINDA = Resources.Load("\" that takes ") as Texture2D;
		SCShader = Shader.Find("{0:0} day{1}, ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NNFMIAFHMJM()
	{
		FPHEBLMINDA = Resources.Load("ReplyMatch is false! ") as Texture2D;
		SCShader = Shader.Find("_EmissionColor");
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
			KAFBNOBOIAJ().SetFloat("OpAuthenticate() failed. When you want Custom Authentication encryption is mandatory.", HBJJOCHGOPH);
			MICHFGAOPKM().SetColor("editor.", Pencil_Color);
			HKHBBBFLGJH().SetFloat("_Offsets", Pencil_Size);
			KAFBNOBOIAJ().SetFloat("threshold", Pencil_Correction);
			HCGJCMDJPGD().SetFloat("STICKRHOR", Intensity);
			ENKPNJMPDEB().SetFloat("#onfirstranktext", Speed_Animation);
			ADGHJOHKEHG().SetFloat("_Radius", Corner_Lose);
			MLMKCOINOOH().SetFloat("_ScreenResolution", Fade_Paper_to_BackColor);
			KHCLIAMBBNC().SetFloat("[PlayerBase] Highscore: ", Fade_With_Original);
			HKHBBBFLGJH().SetColor("PossibleMapMaxScoreText", Back_Color);
			BAGICADFBAB().SetTexture("BadgeText", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EJDPNJAEAKJ());
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
			CEKJODEAMGB().SetFloat("_Blue_G", HBJJOCHGOPH);
			LPCHMEKDCHI().SetColor("BadgeImage", Pencil_Color);
			NBPKMLMCHFN.SetFloat("/Assets/MyImage", Pencil_Size);
			ADBKPGFMNKO().SetFloat(",viewkeys", Pencil_Correction);
			LPCHMEKDCHI().SetFloat("DPADVER", Intensity);
			KHCLIAMBBNC().SetFloat("_Offsets", Speed_Animation);
			ENKPNJMPDEB().SetFloat("IconImage", Corner_Lose);
			HNFFHCLNBDN().SetFloat("_HitPointTexture", Fade_Paper_to_BackColor);
			FKEOGPDLBDD().SetFloat(" not exist", Fade_With_Original);
			EJDPNJAEAKJ().SetColor(": ", Back_Color);
			EFMCNLELMDO().SetTexture("[Steamworks.NET] DllCheck Test returned false, One or more of the Steamworks binaries seems to be the wrong version.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
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
			KHCLIAMBBNC().SetFloat("_Red_B", HBJJOCHGOPH);
			ACHNOHCLGOO().SetColor("_Value5", Pencil_Color);
			KHCLIAMBBNC().SetFloat("CameraFilterPack/Blend2Camera_HardLight", Pencil_Size);
			KEMAALEODNH().SetFloat("CameraFilterPack/Edge_Golden", Pencil_Correction);
			DOMEEFLPEPJ().SetFloat("LeaderboardsButton", Intensity);
			DOMEEFLPEPJ().SetFloat("_Value3", Speed_Animation);
			CEKJODEAMGB().SetFloat("Player", Corner_Lose);
			CEKJODEAMGB().SetFloat("PUN-instantiated '", Fade_Paper_to_BackColor);
			HKHBBBFLGJH().SetFloat("Jan", Fade_With_Original);
			HNFFHCLNBDN().SetColor("workshop.", Back_Color);
			MICHFGAOPKM().SetTexture("error", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPCHMEKDCHI());
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
			DKKBFFHBHJE().SetFloat("_Value4", HBJJOCHGOPH);
			ACHNOHCLGOO().SetColor("_Scale", Pencil_Color);
			BAGICADFBAB().SetFloat("OxOD.lastPath", Pencil_Size);
			KAFBNOBOIAJ().SetFloat(". Check if the server is available.", Pencil_Correction);
			NFKFAAHHLLM().SetFloat("You need to have a Graphic control (such as an Image) for the list [", Intensity);
			HKHBBBFLGJH().SetFloat("CameraFilterPack/Blend2Camera_LinearLight", Speed_Animation);
			ADGHJOHKEHG().SetFloat("It seems some instantiation is not completed, as instantiation data is used. You should make sure instantiations are paused when calling this method. Cleaning now, despite this.", Corner_Lose);
			ADBKPGFMNKO().SetFloat("settings_bindings_sec_", Fade_Paper_to_BackColor);
			HKHBBBFLGJH().SetFloat("2;13;14;15;16", Fade_With_Original);
			MLMKCOINOOH().SetColor("settings_bindings_controller_type", Back_Color);
			ENKPNJMPDEB().SetTexture("yes", FPHEBLMINDA);
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
			EJDPNJAEAKJ().SetFloat("ItemsCountText", HBJJOCHGOPH);
			ADBKPGFMNKO().SetColor("_Value6", Pencil_Color);
			HNFFHCLNBDN().SetFloat("_ScreenResolution", Pencil_Size);
			FKEOGPDLBDD().SetFloat("_Intensity", Pencil_Correction);
			DKKBFFHBHJE().SetFloat("DPADHOR", Intensity);
			BAGICADFBAB().SetFloat("_Value", Speed_Animation);
			DOMEEFLPEPJ().SetFloat("\nCreated by Oxy949", Corner_Lose);
			FOOCJIDNGBB().SetFloat("CameraFilterPack/TV_WideScreenHorizontal", Fade_Paper_to_BackColor);
			KHCLIAMBBNC().SetFloat(" is not supported on this platform!", Fade_With_Original);
			KAFBNOBOIAJ().SetColor("CameraFilterPack_RainFX_Anm", Back_Color);
			ADBKPGFMNKO().SetTexture("_Visualize", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
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
		FPHEBLMINDA = Resources.Load("MenuScene") as Texture2D;
		SCShader = Shader.Find("action");
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
			DKKBFFHBHJE().SetFloat("FileMenu", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetColor("_TimeX", Pencil_Color);
			ENKPNJMPDEB().SetFloat("_ScreenResolution", Pencil_Size);
			EJDPNJAEAKJ().SetFloat("/../", Pencil_Correction);
			ENKPNJMPDEB().SetFloat("_Bullet_5", Intensity);
			DIOAAHJDMLK().SetFloat("Submit", Speed_Animation);
			NBPKMLMCHFN.SetFloat(":", Corner_Lose);
			PLBEJJIHFPB().SetFloat(": ", Fade_Paper_to_BackColor);
			LPCHMEKDCHI().SetFloat(": ", Fade_With_Original);
			ADGHJOHKEHG().SetColor("[NetworkManager] Joined main lobby", Back_Color);
			HKHBBBFLGJH().SetTexture("_TimeX", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
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
		FPHEBLMINDA = Resources.Load("CameraFilterPack_Fly_VisionFX") as Texture2D;
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
		FPHEBLMINDA = Resources.Load("#no") as Texture2D;
		SCShader = Shader.Find("_Value");
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
		FPHEBLMINDA = Resources.Load("gameVolume") as Texture2D;
		SCShader = Shader.Find("_TimeX");
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
		FPHEBLMINDA = Resources.Load(".lastCheckpoint.penaltyScore") as Texture2D;
		SCShader = Shader.Find("_MainTex2");
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
			KHCLIAMBBNC().SetFloat("_Threshold", HBJJOCHGOPH);
			NFKFAAHHLLM().SetColor("Can not SetMasterClient(). Not in room or in offlineMode.", Pencil_Color);
			MLMKCOINOOH().SetFloat("_Offsets", Pencil_Size);
			KEMAALEODNH().SetFloat("5;6;7;8;11;12;18;19;20;22x6;44x1", Pencil_Correction);
			KHCLIAMBBNC().SetFloat("BadgeText", Intensity);
			KHCLIAMBBNC().SetFloat("' got destroyed by engine. This is OK when loading levels. Otherwise use: PhotonNetwork.Destroy().", Speed_Animation);
			EJDPNJAEAKJ().SetFloat("RT", Corner_Lose);
			EJDPNJAEAKJ().SetFloat("Save Path: ", Fade_Paper_to_BackColor);
			FGENHBKMPDA().SetFloat("_NormalAndRoughnessTexture", Fade_With_Original);
			EFMCNLELMDO().SetColor("CameraFilterPack/Distortion_ShockWave", Back_Color);
			HCGJCMDJPGD().SetTexture(".lastCheckpoint.playerdistance", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
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
			DOMEEFLPEPJ().SetFloat("EnableRankedNotificationsToggle", HBJJOCHGOPH);
			DIOAAHJDMLK().SetColor(",", Pencil_Color);
			ENKPNJMPDEB().SetFloat("_ScreenResolution", Pencil_Size);
			ACHNOHCLGOO().SetFloat("CameraFilterPack/Distortion_Dream", Pencil_Correction);
			NBPKMLMCHFN.SetFloat("_Offsets", Intensity);
			CEKJODEAMGB().SetFloat("#,0.00", Speed_Animation);
			KAFBNOBOIAJ().SetFloat("No Description", Corner_Lose);
			CEKJODEAMGB().SetFloat("_Value2", Fade_Paper_to_BackColor);
			LPCHMEKDCHI().SetFloat("_Value4", Fade_With_Original);
			HCGJCMDJPGD().SetColor("InfoCanvas", Back_Color);
			FGENHBKMPDA().SetTexture("time: ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CEKJODEAMGB());
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
			EFMCNLELMDO().SetFloat("GraphicsQualitySlider", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetColor("/icon", Pencil_Color);
			DIOAAHJDMLK().SetFloat("ArcsDestroyDelaySlider", Pencil_Size);
			CEKJODEAMGB().SetFloat("maps.", Pencil_Correction);
			MLMKCOINOOH().SetFloat("CameraFilterPack/Blend2Camera_LinearBurn", Intensity);
			ACHNOHCLGOO().SetFloat("_Value1", Speed_Animation);
			HKHBBBFLGJH().SetFloat("_Value5", Corner_Lose);
			PLBEJJIHFPB().SetFloat(",", Fade_Paper_to_BackColor);
			MICHFGAOPKM().SetFloat("[MapsData] Caching ", Fade_With_Original);
			ACHNOHCLGOO().SetColor("_Val", Back_Color);
			DIOAAHJDMLK().SetTexture("_TimeX", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HJPCJGOEKMF()
	{
		FPHEBLMINDA = Resources.Load("Connection error: ") as Texture2D;
		SCShader = Shader.Find("_NoiseScale");
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
			ADBKPGFMNKO().SetFloat(" - ", HBJJOCHGOPH);
			HKHBBBFLGJH().SetColor("_Near", Pencil_Color);
			HNFFHCLNBDN().SetFloat("_TimeX", Pencil_Size);
			ADBKPGFMNKO().SetFloat("Fade", Pencil_Correction);
			EJDPNJAEAKJ().SetFloat("[Right]", Intensity);
			HKHBBBFLGJH().SetFloat("_TimeX", Speed_Animation);
			FGENHBKMPDA().SetFloat("blue", Corner_Lose);
			EFMCNLELMDO().SetFloat("#yes", Fade_Paper_to_BackColor);
			KHCLIAMBBNC().SetFloat("HighScaleShot", Fade_With_Original);
			HNFFHCLNBDN().SetColor("[PlayerController] ", Back_Color);
			ADGHJOHKEHG().SetTexture("float,0", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DIOAAHJDMLK());
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
			CEKJODEAMGB().SetFloat("[MapEditor] Reset", HBJJOCHGOPH);
			HNFFHCLNBDN().SetColor("_FadeFX", Pencil_Color);
			EJDPNJAEAKJ().SetFloat("GlassDistortion", Pencil_Size);
			KAFBNOBOIAJ().SetFloat("_GrainTex", Pencil_Correction);
			BAGICADFBAB().SetFloat("settings.enableranking", Intensity);
			KEMAALEODNH().SetFloat("_Level", Speed_Animation);
			BAGICADFBAB().SetFloat("_TimeX", Corner_Lose);
			NBPKMLMCHFN.SetFloat("_Value", Fade_Paper_to_BackColor);
			CEKJODEAMGB().SetFloat("RestartButton", Fade_With_Original);
			DOMEEFLPEPJ().SetColor("achievements.21.completed.", Back_Color);
			CEKJODEAMGB().SetTexture("You must complete your map before submiting it to Workshop", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
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
			KAFBNOBOIAJ().SetFloat("_Max", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetColor("CameraFilterPack/EyesVision_1", Pencil_Color);
			HCGJCMDJPGD().SetFloat("Reading preview file failed!: \"{0}\"", Pencil_Size);
			ENKPNJMPDEB().SetFloat("00", Pencil_Correction);
			MICHFGAOPKM().SetFloat("BloodAlternative2", Intensity);
			BAGICADFBAB().SetFloat("_Color_B", Speed_Animation);
			HKHBBBFLGJH().SetFloat("_ScreenResolution", Corner_Lose);
			CEKJODEAMGB().SetFloat("_ScreenResolution", Fade_Paper_to_BackColor);
			HCGJCMDJPGD().SetFloat("id", Fade_With_Original);
			ADBKPGFMNKO().SetColor("_Value2", Back_Color);
			MLMKCOINOOH().SetTexture(" scene view IDs from last level.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNFFHCLNBDN());
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
		SCShader = Shader.Find("_Value");
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
			FOOCJIDNGBB().SetFloat("_FixDistance", HBJJOCHGOPH);
			BAGICADFBAB().SetColor(": ", Pencil_Color);
			NFKFAAHHLLM().SetFloat("/", Pencil_Size);
			KHCLIAMBBNC().SetFloat("ComboText", Pencil_Correction);
			LPCHMEKDCHI().SetFloat("achievements.21.progress", Intensity);
			CEKJODEAMGB().SetFloat("_VignetteCenter", Speed_Animation);
			ADBKPGFMNKO().SetFloat("SetSatelliteRadius", Corner_Lose);
			ADGHJOHKEHG().SetFloat("_Gain", Fade_Paper_to_BackColor);
			NFKFAAHHLLM().SetFloat(".wav", Fade_With_Original);
			BAGICADFBAB().SetColor("Joystick1Button6", Back_Color);
			DIOAAHJDMLK().SetTexture("AuthenticationValues UserId: {0}, GetParameters: {1} Token available: {2}", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MLMKCOINOOH());
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
