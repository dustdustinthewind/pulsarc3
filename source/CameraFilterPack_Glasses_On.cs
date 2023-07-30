// CameraFilterPack_Glasses_On
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Glasses/Classic Glasses")]
[ExecuteInEditMode]
public class CameraFilterPack_Glasses_On : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	[Range(0f, 1f)]
	public float Fade = 0.2f;

	[Range(0f, 0.1f)]
	public float VisionBlur = 0.0095f;

	public Color GlassesColor = new Color(0f, 0f, 0f, 1f);

	public Color GlassesColor2 = new Color(0.25f, 0.25f, 0.25f, 0.25f);

	[Range(0f, 1f)]
	public float GlassDistortion = 0.45f;

	[Range(0f, 1f)]
	public float GlassAberration = 0.5f;

	[Range(0f, 1f)]
	public float UseFinalGlassColor;

	[Range(0f, 1f)]
	public float UseScanLine;

	[Range(1f, 512f)]
	public float UseScanLineSize = 1f;

	public Color GlassColor = new Color(0f, 0f, 0f, 1f);

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

	private void GAOOPEEBGJA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BMODOIJGIOO()
	{
	}

	private void JDKHBGDEONK()
	{
		FPHEBLMINDA = Resources.Load("_FgOverlap") as Texture2D;
		SCShader = Shader.Find("UsernameText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GHILDCBCDJI()
	{
	}

	[SpecialName]
	private Material MLMKCOINOOH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-119);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void JKFDDNMPOJH()
	{
		FPHEBLMINDA = Resources.Load("roomDescription") as Texture2D;
		SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HGDDCINLDAD()
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
			if (HBJJOCHGOPH > 1829f)
			{
				HBJJOCHGOPH = 966f;
			}
			LMLENGFLEBD().SetFloat("Texture2", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("Missing shader in ", UseFinalGlassColor);
			FEAEGGCNIAA().SetFloat("move", Fade);
			OKJOKHGJHGF().SetFloat(" ", VisionBlur);
			HNFFHCLNBDN().SetFloat("SpawnObj", GlassDistortion);
			NBPKMLMCHFN.SetFloat("[LevelEditorScene] Updated", GlassAberration);
			IONHGBPGCHK().SetColor(" cannot be used as a 3D LUT.", GlassesColor);
			NBMPPNFKFLB().SetColor("Checkpoint", GlassesColor2);
			LMLENGFLEBD().SetColor("_History1ChromaTex", GlassColor);
			IONHGBPGCHK().SetFloat("challenges/", UseScanLineSize);
			HNFFHCLNBDN().SetFloat("_ScreenResolution", UseScanLine);
			FEAEGGCNIAA().SetTexture("_Value3", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLOHGDECHHH());
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
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void PNLKFANNOKO()
	{
	}

	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 760f)
			{
				HBJJOCHGOPH = 22f;
			}
			LPMLLJKMAMP().SetFloat("_History4Weight", HBJJOCHGOPH);
			HKGAONMOBMH().SetFloat("#yes", UseFinalGlassColor);
			MICHFGAOPKM().SetFloat(" has ", Fade);
			FEAEGGCNIAA().SetFloat("checkpoint", VisionBlur);
			PGPEMMBJOOG().SetFloat("LevelNameInputField", GlassDistortion);
			MFHPKGICPIO().SetFloat("StartButton", GlassAberration);
			PGPEMMBJOOG().SetColor("_Value2", GlassesColor);
			MFHPKGICPIO().SetColor("ticket", GlassesColor2);
			HNFFHCLNBDN().SetColor("HiddenToggle", GlassColor);
			FEAEGGCNIAA().SetFloat("In Main Menu", UseScanLineSize);
			MICHFGAOPKM().SetFloat("#turnoninternet", UseScanLine);
			GHHPOGODBHB().SetTexture("player.currentrank", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IMCKJCHKMKB()
	{
		FPHEBLMINDA = Resources.Load("The authentication ticket expired. You need to connect (and authenticate) again. Disconnecting.") as Texture2D;
		SCShader = Shader.Find("https://twitch.tv/intralism");
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

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1441f)
			{
				HBJJOCHGOPH = 402f;
			}
			HEHKGPKLAKK().SetFloat("_FarCamera", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("SetScale", UseFinalGlassColor);
			LPMLLJKMAMP().SetFloat("System.Int32", Fade);
			FLOHGDECHHH().SetFloat("_Value2", VisionBlur);
			MFHPKGICPIO().SetFloat("_TimeX", GlassDistortion);
			FEAEGGCNIAA().SetFloat("SetSpeed", GlassAberration);
			GHHPOGODBHB().SetColor("_TimeX", GlassesColor);
			HNFFHCLNBDN().SetColor("workshop.txt", GlassesColor2);
			MFHPKGICPIO().SetColor("green", GlassColor);
			OLHDPICFBOF().SetFloat("OnJoinedRoom() called by PUN. Now this client is in a room. From here on, your game would be running. For reference, all callbacks are listed in enum: PhotonNetworkingMessage", UseScanLineSize);
			IONHGBPGCHK().SetFloat("curScn", UseScanLine);
			PGPEMMBJOOG().SetTexture("Tab2Content", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	private void KMOCDAOKGLI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ABEIEGDHBNO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material GHHPOGODBHB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-111);
		}
		return BJFKDHHMLJH;
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
			NBPKMLMCHFN.SetFloat("UseFinalGlassColor", UseFinalGlassColor);
			NBPKMLMCHFN.SetFloat("Fade", Fade);
			NBPKMLMCHFN.SetFloat("VisionBlur", VisionBlur);
			NBPKMLMCHFN.SetFloat("GlassDistortion", GlassDistortion);
			NBPKMLMCHFN.SetFloat("GlassAberration", GlassAberration);
			NBPKMLMCHFN.SetColor("GlassesColor", GlassesColor);
			NBPKMLMCHFN.SetColor("GlassesColor2", GlassesColor2);
			NBPKMLMCHFN.SetColor("GlassColor", GlassColor);
			NBPKMLMCHFN.SetFloat("UseScanLineSize", UseScanLineSize);
			NBPKMLMCHFN.SetFloat("UseScanLine", UseScanLine);
			NBPKMLMCHFN.SetTexture("_MainTex2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HIPEHGNBJMN()
	{
		FPHEBLMINDA = Resources.Load("_RangeScale") as Texture2D;
		SCShader = Shader.Find("_Value");
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

	private void HLLHJIDOOGA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OIBMHPIFAKK()
	{
	}

	private void JHJGJJKELJM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 44f)
			{
				HBJJOCHGOPH = 1760f;
			}
			NBPKMLMCHFN.SetFloat("LoadMapCanvas", HBJJOCHGOPH);
			LENEJAGLCNL().SetFloat("Error: I/O Failure! :(", UseFinalGlassColor);
			FLOHGDECHHH().SetFloat("CameraFilterPack/FX_Psycho", Fade);
			HKGAONMOBMH().SetFloat("_UserLutParams", VisionBlur);
			MICHFGAOPKM().SetFloat("_TimeX", GlassDistortion);
			MICHFGAOPKM().SetFloat("_Amount", GlassAberration);
			MLMKCOINOOH().SetColor("_Blue_G", GlassesColor);
			FLOHGDECHHH().SetColor("BitsData", GlassesColor2);
			MLMKCOINOOH().SetColor("Failed to 'network-remove' GameObject because has no PhotonView components: ", GlassColor);
			FLOHGDECHHH().SetFloat(" - ", UseScanLineSize);
			KEMJNOMIPHN().SetFloat("Brightness", UseScanLine);
			PGPEMMBJOOG().SetTexture("materialsitemid[", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GPNAOAKCMHC()
	{
		FPHEBLMINDA = Resources.Load("Case-Sensitive") as Texture2D;
		SCShader = Shader.Find("#onfirstranktext");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LGHCJCFHEMF()
	{
		FPHEBLMINDA = Resources.Load("[MenuScene] Error: ") as Texture2D;
		SCShader = Shader.Find("_Visualize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FBMDHDBELEK()
	{
	}

	private void LCHBFNIPBHB()
	{
	}

	private void HLIAEEMGBHN()
	{
		FPHEBLMINDA = Resources.Load("0") as Texture2D;
		SCShader = Shader.Find("{0}\t is: {1}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IHLMNAGPKDA()
	{
		FPHEBLMINDA = Resources.Load("settings.volume.game") as Texture2D;
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BJOHDLNDFAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KOJKBFDNGDK()
	{
		FPHEBLMINDA = Resources.Load("</size>") as Texture2D;
		SCShader = Shader.Find("_Bullet_4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material LENEJAGLCNL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void EJFJENFKLND()
	{
	}

	[SpecialName]
	private Material HEHKGPKLAKK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void MCKCCPLJIFE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material MFHPKGICPIO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return BJFKDHHMLJH;
	}

	private void BMIOFJFMCBG()
	{
		FPHEBLMINDA = Resources.Load("Brightness") as Texture2D;
		SCShader = Shader.Find("SetSunDirectionVector");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EPEGAEGDJAM()
	{
		FPHEBLMINDA = Resources.Load("Joystick1Button9") as Texture2D;
		SCShader = Shader.Find("#,0.00");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IBPAMDEAGJL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EDCMIPNCPLB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ODAIMOJLJOF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KIMMMCJFMAB()
	{
		FPHEBLMINDA = Resources.Load("Toggle {0} is not part of ToggleGroup {1}") as Texture2D;
		SCShader = Shader.Find("mapselector.lastSearch");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PHJJHFBLICM()
	{
	}

	private void IENKPJEBMFM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FJIKDJAMOHA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DOEPOGLEGLE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FGBDGGCBFLP()
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
			if (HBJJOCHGOPH > 663f)
			{
				HBJJOCHGOPH = 907f;
			}
			MICHFGAOPKM().SetFloat("Tab1Content", HBJJOCHGOPH);
			OKJOKHGJHGF().SetFloat("_VelTex", UseFinalGlassColor);
			MFHPKGICPIO().SetFloat("shader.pixel", Fade);
			PGPEMMBJOOG().SetFloat("https://store.steampowered.com/itemstore/513510/", VisionBlur);
			FLOHGDECHHH().SetFloat("other", GlassDistortion);
			HEHKGPKLAKK().SetFloat("StandAloneInputSystem should not be used with the GamePadInputModule, please remove it from the Event System in this scene or disable it when this module is in use", GlassAberration);
			MFHPKGICPIO().SetColor("-", GlassesColor);
			OKJOKHGJHGF().SetColor("_Green_R", GlassesColor2);
			MICHFGAOPKM().SetColor("_ScreenResolution", GlassColor);
			LENEJAGLCNL().SetFloat("???", UseScanLineSize);
			NBPKMLMCHFN.SetFloat("FToA", UseScanLine);
			HEHKGPKLAKK().SetTexture("string", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
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
			if (HBJJOCHGOPH > 793f)
			{
				HBJJOCHGOPH = 1346f;
			}
			OKJOKHGJHGF().SetFloat("NetworkCanvas", HBJJOCHGOPH);
			LMLENGFLEBD().SetFloat("GenerationMenu", UseFinalGlassColor);
			OKJOKHGJHGF().SetFloat("MenuScene", Fade);
			LMLENGFLEBD().SetFloat("Tab2Content", VisionBlur);
			OLHDPICFBOF().SetFloat("_History3ChromaTex", GlassDistortion);
			HEHKGPKLAKK().SetFloat(".progress", GlassAberration);
			KEMJNOMIPHN().SetColor("SetCrosshairEmission", GlassesColor);
			LPMLLJKMAMP().SetColor(" - ", GlassesColor2);
			KEMJNOMIPHN().SetColor("_ScreenResolution", GlassColor);
			OKJOKHGJHGF().SetFloat("Set satellite trail length in seconds", UseScanLineSize);
			IONHGBPGCHK().SetFloat("_BorderColor", UseScanLine);
			OKJOKHGJHGF().SetTexture("0.00/0.00", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HIFLPHLGLFG()
	{
	}

	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1226f)
			{
				HBJJOCHGOPH = 1159f;
			}
			HNFFHCLNBDN().SetFloat("_BaseTex", HBJJOCHGOPH);
			HEHKGPKLAKK().SetFloat("_Red_R", UseFinalGlassColor);
			FEAEGGCNIAA().SetFloat("TRACKING", Fade);
			LENEJAGLCNL().SetFloat("float", VisionBlur);
			KEMJNOMIPHN().SetFloat("_FixDistance", GlassDistortion);
			MICHFGAOPKM().SetFloat(",", GlassAberration);
			LMLENGFLEBD().SetColor("ColorBlood", GlassesColor);
			HEHKGPKLAKK().SetColor("You must complete your map before submiting it to Workshop", GlassesColor2);
			PGPEMMBJOOG().SetColor("JoinOrCreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", GlassColor);
			LMLENGFLEBD().SetFloat("CameraFilterPack_eyes_vision_2", UseScanLineSize);
			DKKBFFHBHJE().SetFloat("_TimeX", UseScanLine);
			LMLENGFLEBD().SetTexture("_TimeX", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Start()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_Glasses_On2") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Glasses_On");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HIKKPDACJGI()
	{
	}

	private void DAHFFNNIGML()
	{
		FPHEBLMINDA = Resources.Load("init") as Texture2D;
		SCShader = Shader.Find("\\");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1469f)
			{
				HBJJOCHGOPH = 1381f;
			}
			LPMLLJKMAMP().SetFloat("_Amount", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("_BlurRadius4", UseFinalGlassColor);
			OKJOKHGJHGF().SetFloat("_BlurArea", Fade);
			FEAEGGCNIAA().SetFloat("OpChangeGroups()", VisionBlur);
			MLMKCOINOOH().SetFloat("maps.", GlassDistortion);
			FLOHGDECHHH().SetFloat("<command>", GlassAberration);
			FEAEGGCNIAA().SetColor("[SERVER] Player ", GlassesColor);
			MLMKCOINOOH().SetColor("Init", GlassesColor2);
			MICHFGAOPKM().SetColor("_NeighborMaxTex", GlassColor);
			DKKBFFHBHJE().SetFloat("CameraFilterPack/FX_Glitch2", UseScanLineSize);
			MLMKCOINOOH().SetFloat("restrictions\n\n#until: ", UseScanLine);
			OLHDPICFBOF().SetTexture("LevelNameText", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GJAJBMGGPFB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JBCNIPJDPJB()
	{
	}

	private void JECMJNFGBGC()
	{
		FPHEBLMINDA = Resources.Load("mapselector.filter.rateduponly") as Texture2D;
		SCShader = Shader.Find("Other");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 439f)
			{
				HBJJOCHGOPH = 1784f;
			}
			LENEJAGLCNL().SetFloat("_Value", HBJJOCHGOPH);
			OLHDPICFBOF().SetFloat("Please specify a map name or buildID", UseFinalGlassColor);
			MFHPKGICPIO().SetFloat("[NetworkManager] Updating current room...", Fade);
			LENEJAGLCNL().SetFloat("_Convolved_TexelSize", VisionBlur);
			OLHDPICFBOF().SetFloat("-", GlassDistortion);
			NBMPPNFKFLB().SetFloat("Copy from ", GlassAberration);
			FLOHGDECHHH().SetColor("_Value2", GlassesColor);
			DKKBFFHBHJE().SetColor("stretchWidth", GlassesColor2);
			IONHGBPGCHK().SetColor("_Far", GlassColor);
			HKGAONMOBMH().SetFloat("materialsitemid[", UseScanLineSize);
			PGPEMMBJOOG().SetFloat("_Saturation", UseScanLine);
			MFHPKGICPIO().SetTexture("EditMenu", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 305f)
			{
				HBJJOCHGOPH = 1987f;
			}
			GHHPOGODBHB().SetFloat("_Value2", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat(" user's map(s)", UseFinalGlassColor);
			NBMPPNFKFLB().SetFloat("_Value", Fade);
			IONHGBPGCHK().SetFloat("GameScene", VisionBlur);
			IONHGBPGCHK().SetFloat("_Value2", GlassDistortion);
			HKGAONMOBMH().SetFloat("[PlayerController] ", GlassAberration);
			DKKBFFHBHJE().SetColor("_Value3", GlassesColor);
			MFHPKGICPIO().SetColor("\n\n#", GlassesColor2);
			LENEJAGLCNL().SetColor("player.redarc", GlassColor);
			GHHPOGODBHB().SetFloat("Scenes List:", UseScanLineSize);
			LMLENGFLEBD().SetFloat("CameraFilterPack/Blend2Camera_Darken", UseScanLine);
			NBMPPNFKFLB().SetTexture("Set satellite MinVertexDistance - how much distance should be between to points of the trail line", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)65;
		}
		return BJFKDHHMLJH;
	}

	private void CIPKEPDELJB()
	{
		FPHEBLMINDA = Resources.Load("cipherText") as Texture2D;
		SCShader = Shader.Find("Instantiating: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FKEJGBFDCAH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NCPAFCKGJEA()
	{
	}

	[SpecialName]
	private Material LMLENGFLEBD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material PGPEMMBJOOG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void KDMKDEKCELE()
	{
		FPHEBLMINDA = Resources.Load("_Value4") as Texture2D;
		SCShader = Shader.Find("Set arcs speed. Base value - 15");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OCMKCBBCEFG()
	{
	}

	private void DLBODOFAJGM()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack/Distortion_Wave_Horizontal") as Texture2D;
		SCShader = Shader.Find(" Message: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NFEDLAOPHML()
	{
	}

	[SpecialName]
	private Material HNFFHCLNBDN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void ONKDMMJPEMN()
	{
	}

	private void HLDFOJMHKNL()
	{
	}

	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 705f)
			{
				HBJJOCHGOPH = 1730f;
			}
			LMLENGFLEBD().SetFloat("_Value", HBJJOCHGOPH);
			KEMJNOMIPHN().SetFloat("[Up]", UseFinalGlassColor);
			HNFFHCLNBDN().SetFloat("menu.enableselectormusic", Fade);
			MFHPKGICPIO().SetFloat("Texture2", VisionBlur);
			OKJOKHGJHGF().SetFloat("_MainTex", GlassDistortion);
			OLHDPICFBOF().SetFloat("Set Particles Color", GlassAberration);
			HKGAONMOBMH().SetColor("LoadingStatusText", GlassesColor);
			FLOHGDECHHH().SetColor("GameScene", GlassesColor2);
			MLMKCOINOOH().SetColor("#8E8E8EFF", GlassColor);
			OKJOKHGJHGF().SetFloat(".icon", UseScanLineSize);
			HNFFHCLNBDN().SetFloat("_FadeFX", UseScanLine);
			HNFFHCLNBDN().SetTexture("Can't do manual instantiation without PhotonView component.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material OLHDPICFBOF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void GJLKJAOBPJD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BOLBPPHJBMI()
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void OMCLOFCJMPG()
	{
	}

	private void HDMDKOKOOJC()
	{
		FPHEBLMINDA = Resources.Load("Did not read byte array properly") as Texture2D;
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1132f)
			{
				HBJJOCHGOPH = 1397f;
			}
			GHHPOGODBHB().SetFloat("RemoveEnvironmentObject", HBJJOCHGOPH);
			OLHDPICFBOF().SetFloat("offsets", UseFinalGlassColor);
			LENEJAGLCNL().SetFloat("ns", Fade);
			MFHPKGICPIO().SetFloat("scenes", VisionBlur);
			NBPKMLMCHFN.SetFloat("_TimeX", GlassDistortion);
			HNFFHCLNBDN().SetFloat("ConfigVersionSlider", GlassAberration);
			IONHGBPGCHK().SetColor("[", GlassesColor);
			HKGAONMOBMH().SetColor("_Value2", GlassesColor2);
			OKJOKHGJHGF().SetColor("_Value3", GlassColor);
			HEHKGPKLAKK().SetFloat("CameraFilterPack/3D_Distortion", UseScanLineSize);
			NBPKMLMCHFN.SetFloat("#scoresubmitionfailed: ", UseScanLine);
			HEHKGPKLAKK().SetTexture("_ScreenResolution", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MAOCOEGAFND()
	{
	}

	private void KFACDBHDAOD()
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
	private Material OKJOKHGJHGF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)70;
		}
		return BJFKDHHMLJH;
	}

	private void IDJKNBDKHBD()
	{
		FPHEBLMINDA = Resources.Load("_Smooth") as Texture2D;
		SCShader = Shader.Find("Object ID. Case-Sensitive");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EHJJFJCKGAJ()
	{
	}

	[SpecialName]
	private Material FEAEGGCNIAA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void OKLAJINHPAN()
	{
		FPHEBLMINDA = Resources.Load("\t") as Texture2D;
		SCShader = Shader.Find("shader.frost");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KCCIEMBMOBA()
	{
		FPHEBLMINDA = Resources.Load("</color>") as Texture2D;
		SCShader = Shader.Find("_Intensity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material NBMPPNFKFLB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void BFEILOMHNPC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DLMPALHKMON()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material FLOHGDECHHH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
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

	[SpecialName]
	private Material DKKBFFHBHJE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return BJFKDHHMLJH;
	}

	private void LBIOIEANMGI()
	{
	}

	private void CNDACAHCCOI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material KEMJNOMIPHN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)122;
		}
		return BJFKDHHMLJH;
	}

	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1082f)
			{
				HBJJOCHGOPH = 1324f;
			}
			GHHPOGODBHB().SetFloat("SpawnObj", HBJJOCHGOPH);
			LMLENGFLEBD().SetFloat("STICKRHOR", UseFinalGlassColor);
			MFHPKGICPIO().SetFloat("offsets", Fade);
			FEAEGGCNIAA().SetFloat("_BlurRadius4", VisionBlur);
			PGPEMMBJOOG().SetFloat("CameraFilterPack/Colors_Threshold", GlassDistortion);
			DKKBFFHBHJE().SetFloat("CameraFilterPack_3D_Myst1", GlassAberration);
			NBPKMLMCHFN.SetColor("_TraceBehindObjects", GlassesColor);
			NBMPPNFKFLB().SetColor("_TimeX", GlassesColor2);
			FEAEGGCNIAA().SetColor("#mapalreadyexistupdate", GlassColor);
			HNFFHCLNBDN().SetFloat("CheckCombo", UseScanLineSize);
			NBPKMLMCHFN.SetFloat("Down", UseScanLine);
			MICHFGAOPKM().SetTexture("selector", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HMNLHMLILKD()
	{
	}
}
