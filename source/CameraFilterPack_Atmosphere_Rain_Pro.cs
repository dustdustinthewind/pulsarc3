// CameraFilterPack_Atmosphere_Rain_Pro
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Weather/Rain_Pro")]
[ExecuteInEditMode]
public class CameraFilterPack_Atmosphere_Rain_Pro : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 1f)]
	public float Fade = 1f;

	[Range(0f, 2f)]
	public float Intensity = 0.5f;

	[Range(-0.25f, 0.25f)]
	public float DirectionX = 0.12f;

	[Range(0.4f, 2f)]
	public float Size = 1.5f;

	[Range(0f, 0.5f)]
	public float Speed = 0.275f;

	[Range(0f, 0.5f)]
	public float Distortion = 0.025f;

	[Range(0f, 1f)]
	public float StormFlashOnOff = 1f;

	[Range(0f, 1f)]
	public float DropOnOff = 1f;

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

	private void EDBEHEKMGFH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1731f)
			{
				HBJJOCHGOPH = 1107f;
			}
			KEMAALEODNH().SetFloat("_Intensity", HBJJOCHGOPH);
			LDNADDJMIPK().SetFloat("_Color2", Fade);
			HHIFMIPPMPF().SetFloat("CameraFilterPack_Paper3", Intensity);
			LONNIJMNKFB().SetFloat("0.00", DirectionX);
			ABHDNGIHBKE().SetFloat("#,0", Speed);
			HHIFMIPPMPF().SetFloat("rarity", Size);
			KAFBNOBOIAJ().SetFloat("_Value7", Distortion);
			NBPKMLMCHFN.SetFloat("RequestOwnership(): ", StormFlashOnOff);
			LDNADDJMIPK().SetFloat("menu.playedsolo", DropOnOff);
			HNICHJCGJOC().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1082f, 541f));
			KEMAALEODNH().SetTexture("[DiscordController] Init", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JONGNKNLLND()
	{
		FPHEBLMINDA = Resources.Load("_EmissionColor") as Texture2D;
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material KAFBNOBOIAJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-113);
		}
		return BJFKDHHMLJH;
	}

	private void EFJDNLGNACH()
	{
		FPHEBLMINDA = Resources.Load("Netw. Sim.") as Texture2D;
		SCShader = Shader.Find("GraphicsQualitySlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JHJFBCFBKLD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JOACBIEHHCE()
	{
	}

	private void KIEJKBNBHMD()
	{
	}

	private void OIBMHPIFAKK()
	{
	}

	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1556f)
			{
				HBJJOCHGOPH = 1536f;
			}
			NBPKMLMCHFN.SetFloat("Set Satellite Radius", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("_EdgeThresholdMin", Fade);
			EMDFHOKEGNG().SetFloat("_Value", Intensity);
			NBPKMLMCHFN.SetFloat("_TimeX", DirectionX);
			ABHDNGIHBKE().SetFloat("GroupNameText", Speed);
			KAFBNOBOIAJ().SetFloat("SetSunMaxSize", Size);
			ABHDNGIHBKE().SetFloat("Left Stick Click", Distortion);
			LONNIJMNKFB().SetFloat("settings.disablestoryboard", StormFlashOnOff);
			KGOLDDBHIFN().SetFloat("_History4ChromaTex", DropOnOff);
			LONNIJMNKFB().SetVector("BloodAlternative1", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1723f, 1267f));
			IIJMIPBMMBF().SetTexture("Protocol switch from: ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1816f)
			{
				HBJJOCHGOPH = 826f;
			}
			JLHLHKPHDFO().SetFloat("D-Pad Down", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("player.xp", Fade);
			DNLMFEGJJDD().SetFloat("\r", Intensity);
			HHIFMIPPMPF().SetFloat("yes", DirectionX);
			OLHDPICFBOF().SetFloat(" at ", Speed);
			EMDFHOKEGNG().SetFloat("ResourceIDInputField", Size);
			IIJMIPBMMBF().SetFloat("float,1", Distortion);
			LDNADDJMIPK().SetFloat("\" error: ", StormFlashOnOff);
			JLHLHKPHDFO().SetFloat("\\", DropOnOff);
			NBPKMLMCHFN.SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1129f, 1050f));
			EMDFHOKEGNG().SetTexture("_MainTex2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1623f)
			{
				HBJJOCHGOPH = 1630f;
			}
			LDNADDJMIPK().SetFloat("FinalScoreText", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat(" SecondsBeforeRespawn: ", Fade);
			HHIFMIPPMPF().SetFloat(". The RPC has been ignored.", Intensity);
			KEMAALEODNH().SetFloat("id", DirectionX);
			LDNADDJMIPK().SetFloat("_Value3", Speed);
			IIJMIPBMMBF().SetFloat("/", Size);
			JLHLHKPHDFO().SetFloat("#checkpoint", Distortion);
			EMDFHOKEGNG().SetFloat("workshop.", StormFlashOnOff);
			HHIFMIPPMPF().SetFloat("SetEnvSpriteColor", DropOnOff);
			LDNADDJMIPK().SetVector("SetSunSensitivity", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1394f, 728f));
			DNLMFEGJJDD().SetTexture("ok", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
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
			if (HBJJOCHGOPH > 248f)
			{
				HBJJOCHGOPH = 786f;
			}
			EMDFHOKEGNG().SetFloat("Reload Maps", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("BitsData", Fade);
			KEMAALEODNH().SetFloat("[SERVER] Player ", Intensity);
			KAFBNOBOIAJ().SetFloat("fade out duration", DirectionX);
			KAFBNOBOIAJ().SetFloat("_Value3", Speed);
			HHIFMIPPMPF().SetFloat("_TimeX", Size);
			LONNIJMNKFB().SetFloat("FileMenu", Distortion);
			LDNADDJMIPK().SetFloat("_Value11", StormFlashOnOff);
			OLHDPICFBOF().SetFloat("_Amount", DropOnOff);
			LDNADDJMIPK().SetVector("SetPlayerDistance", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 235f, 911f));
			LDNADDJMIPK().SetTexture("Operation ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LPMINJJPDCH()
	{
	}

	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1547f)
			{
				HBJJOCHGOPH = 1634f;
			}
			KGOLDDBHIFN().SetFloat("PopulateMapsList", HBJJOCHGOPH);
			EMDFHOKEGNG().SetFloat("UseScanLine", Fade);
			NBPKMLMCHFN.SetFloat("Error: PhotonNetwork.SetInterestGroups was called with an illegal group number: ", Intensity);
			ABHDNGIHBKE().SetFloat("_Near", DirectionX);
			DNLMFEGJJDD().SetFloat(".r", Speed);
			DKKBFFHBHJE().SetFloat("workshop.", Size);
			IIJMIPBMMBF().SetFloat("#activechallenges", Distortion);
			JLHLHKPHDFO().SetFloat("other.dust1", StormFlashOnOff);
			NBPKMLMCHFN.SetFloat("Right Stick Click", DropOnOff);
			IIJMIPBMMBF().SetVector("<b>", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1725f, 351f));
			KEMAALEODNH().SetTexture("_TimeX", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1099f)
			{
				HBJJOCHGOPH = 1137f;
			}
			JLHLHKPHDFO().SetFloat("offline room", HBJJOCHGOPH);
			EMDFHOKEGNG().SetFloat("[ResourcesManager] Load audio error: ", Fade);
			NBPKMLMCHFN.SetFloat("X", Intensity);
			HNICHJCGJOC().SetFloat("_BgFade", DirectionX);
			HNICHJCGJOC().SetFloat("StartTime already set: ", Speed);
			KEMAALEODNH().SetFloat("StartButton", Size);
			HNICHJCGJOC().SetFloat("settings.customdataskin", Distortion);
			KEMAALEODNH().SetFloat("_Value2", StormFlashOnOff);
			KAFBNOBOIAJ().SetFloat("_ScreenResolution", DropOnOff);
			KAFBNOBOIAJ().SetVector("[EditorEvent] Exception: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 648f, 1437f));
			NBPKMLMCHFN.SetTexture("_Value", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 403f)
			{
				HBJJOCHGOPH = 1047f;
			}
			NBPKMLMCHFN.SetFloat("_Value5", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("_Visualize", Fade);
			KEMAALEODNH().SetFloat("settings.arcshitsoundtimedelay", Intensity);
			OLHDPICFBOF().SetFloat("Menu", DirectionX);
			KEMAALEODNH().SetFloat("LevelNameInputField", Speed);
			KAFBNOBOIAJ().SetFloat(". Prefab must have a PhotonView component.", Size);
			KEMAALEODNH().SetFloat("CameraFilterPack/BlurHole", Distortion);
			DKKBFFHBHJE().SetFloat("/", StormFlashOnOff);
			KAFBNOBOIAJ().SetFloat("CameraFilterPack/Oculus_NightVision1", DropOnOff);
			KAFBNOBOIAJ().SetVector("RecieveChatActionMessage", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1446f, 434f));
			KAFBNOBOIAJ().SetTexture("_Value", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KOJKBFDNGDK()
	{
		FPHEBLMINDA = Resources.Load("colorA") as Texture2D;
		SCShader = Shader.Find("Please specify a map name or buildID");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 530f)
			{
				HBJJOCHGOPH = 1237f;
			}
			LDNADDJMIPK().SetFloat("https://bitbucket.org/khb-soft/intralismarcsviewer/", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("RecieveChatActionMessage", Fade);
			LDNADDJMIPK().SetFloat("DPADVER", Intensity);
			LDNADDJMIPK().SetFloat(",", DirectionX);
			LONNIJMNKFB().SetFloat("CameraFilterPack/Color_Contrast", Speed);
			KEMAALEODNH().SetFloat("\r", Size);
			LDNADDJMIPK().SetFloat("_Value2", Distortion);
			HHIFMIPPMPF().SetFloat(": ", StormFlashOnOff);
			IIJMIPBMMBF().SetFloat("_Value1", DropOnOff);
			IIJMIPBMMBF().SetVector("AllocateViewID() failed. Room (user {0}) is out of 'scene' viewIDs. It seems all available are in use.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1195f, 133f));
			EMDFHOKEGNG().SetTexture("Cannot remove cached RPCs on a PhotonView thats not ours! ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NBGIMIDICKE()
	{
		FPHEBLMINDA = Resources.Load("_TimeX") as Texture2D;
		SCShader = Shader.Find("DPADHOR");
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
			if (HBJJOCHGOPH > 1976f)
			{
				HBJJOCHGOPH = 1741f;
			}
			HNICHJCGJOC().SetFloat("CameraFilterPack/EXTRA_Rotation", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat("...", Fade);
			EMDFHOKEGNG().SetFloat("_Value", Intensity);
			EMDFHOKEGNG().SetFloat("_Skybox", DirectionX);
			LDNADDJMIPK().SetFloat("_Vignette", Speed);
			ABHDNGIHBKE().SetFloat(": ", Size);
			EMDFHOKEGNG().SetFloat("<size=24>", Distortion);
			DNLMFEGJJDD().SetFloat("/icon", StormFlashOnOff);
			KGOLDDBHIFN().SetFloat("settings.shaders.bloomintencity", DropOnOff);
			DKKBFFHBHJE().SetVector("BitsData", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1954f, 276f));
			IIJMIPBMMBF().SetTexture(".png", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Start()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_Atmosphere_Rain_FX") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Atmosphere_Rain_Pro");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1430f)
			{
				HBJJOCHGOPH = 1502f;
			}
			HNICHJCGJOC().SetFloat("D-Pad Up", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("n/a", Fade);
			NBPKMLMCHFN.SetFloat("_Value", Intensity);
			IIJMIPBMMBF().SetFloat("Mouse", DirectionX);
			HNICHJCGJOC().SetFloat("menu.enableselectormusic", Speed);
			KEMAALEODNH().SetFloat("}", Size);
			EMDFHOKEGNG().SetFloat("Zoom speed. Base 1.5", Distortion);
			KEMAALEODNH().SetFloat("_Value2", StormFlashOnOff);
			DNLMFEGJJDD().SetFloat("Malformed RPC; this should never occur. Content: ", DropOnOff);
			LDNADDJMIPK().SetVector("_dec.json", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 283f, 459f));
			DKKBFFHBHJE().SetTexture("float,1.5", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FNCDAPDOBBI()
	{
		FPHEBLMINDA = Resources.Load("Sending vacant view IDs. Length: ") as Texture2D;
		SCShader = Shader.Find("PossibleMapMaxScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JKFDDNMPOJH()
	{
		FPHEBLMINDA = Resources.Load("SetBGColor") as Texture2D;
		SCShader = Shader.Find(" Owner called.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LCJHDLKJEOM()
	{
	}

	[SpecialName]
	private Material KEMAALEODNH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
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

	private void FABKIGNFECE()
	{
	}

	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1596f)
			{
				HBJJOCHGOPH = 1465f;
			}
			HNICHJCGJOC().SetFloat("ready", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("offsets", Fade);
			IIJMIPBMMBF().SetFloat("--------------------------------", Intensity);
			JLHLHKPHDFO().SetFloat("_Contrast", DirectionX);
			ABHDNGIHBKE().SetFloat("Keypad", Speed);
			JLHLHKPHDFO().SetFloat("note.4", Size);
			OLHDPICFBOF().SetFloat("_Glow", Distortion);
			DKKBFFHBHJE().SetFloat("keys", StormFlashOnOff);
			KAFBNOBOIAJ().SetFloat("TestMapButton", DropOnOff);
			LONNIJMNKFB().SetVector("CameraFilterPack_Glasses_On3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1662f, 75f));
			KEMAALEODNH().SetTexture("LostLive", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
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
			if (HBJJOCHGOPH > 1005f)
			{
				HBJJOCHGOPH = 539f;
			}
			DNLMFEGJJDD().SetFloat("CameraFilterPack/Colors_Brightness", HBJJOCHGOPH);
			JLHLHKPHDFO().SetFloat("_TimeX", Fade);
			LONNIJMNKFB().SetFloat("_History3ChromaTex", Intensity);
			DKKBFFHBHJE().SetFloat("_ProjectionInv", DirectionX);
			DKKBFFHBHJE().SetFloat("menutheme.deleted", Speed);
			OLHDPICFBOF().SetFloat("_Value5", Size);
			OLHDPICFBOF().SetFloat(".lastCheckpoint.powerupsScore", Distortion);
			KGOLDDBHIFN().SetFloat("skin.", StormFlashOnOff);
			LDNADDJMIPK().SetFloat(" - StoreAuthURLResponse] - ", DropOnOff);
			KEMAALEODNH().SetVector("_Value4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 351f, 474f));
			OLHDPICFBOF().SetTexture("settings.enablehitsoundsinnormal", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material EMDFHOKEGNG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void DLBODOFAJGM()
	{
		FPHEBLMINDA = Resources.Load("Print the list of scenes, avalable in game.") as Texture2D;
		SCShader = Shader.Find("_Value2");
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
			if (HBJJOCHGOPH > 1808f)
			{
				HBJJOCHGOPH = 1527f;
			}
			JLHLHKPHDFO().SetFloat("No peer to communicate with. ", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("[MapEditor] Prepairing map editor...", Fade);
			IIJMIPBMMBF().SetFloat("_Offsets", Intensity);
			EMDFHOKEGNG().SetFloat("_ReflectionTexture3", DirectionX);
			DNLMFEGJJDD().SetFloat("_FarCamera", Speed);
			JLHLHKPHDFO().SetFloat("green", Size);
			ABHDNGIHBKE().SetFloat("AddEnvironmentSprite", Distortion);
			LDNADDJMIPK().SetFloat("FinalScoreSmallText", StormFlashOnOff);
			KAFBNOBOIAJ().SetFloat("traffic", DropOnOff);
			JLHLHKPHDFO().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 361f, 468f));
			KEMAALEODNH().SetTexture("_TileTexDebug", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1655f)
			{
				HBJJOCHGOPH = 1809f;
			}
			LDNADDJMIPK().SetFloat("MenuPlayButton", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("challenges.", Fade);
			JLHLHKPHDFO().SetFloat("CameraFilterPack/FX_Hypno", Intensity);
			KEMAALEODNH().SetFloat("_Value", DirectionX);
			DKKBFFHBHJE().SetFloat("_TimeX", Speed);
			JLHLHKPHDFO().SetFloat("/../", Size);
			KGOLDDBHIFN().SetFloat("Editor/", Distortion);
			KAFBNOBOIAJ().SetFloat("[SERVER] Player ", StormFlashOnOff);
			IIJMIPBMMBF().SetFloat("EnvironmentSlider", DropOnOff);
			DNLMFEGJJDD().SetVector("a minute ago", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 824f, 431f));
			IIJMIPBMMBF().SetTexture("CameraFilterPack/Gradients_Desert", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GHILDCBCDJI()
	{
	}

	private void FKEJGBFDCAH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 941f)
			{
				HBJJOCHGOPH = 1286f;
			}
			LDNADDJMIPK().SetFloat("Avoid using this directly. Thanks.", HBJJOCHGOPH);
			LDNADDJMIPK().SetFloat("Added event", Fade);
			LDNADDJMIPK().SetFloat("EventTimeInputField", Intensity);
			OLHDPICFBOF().SetFloat("settings.volume.sfx", DirectionX);
			HHIFMIPPMPF().SetFloat("Rotate environment object to the rotation", Speed);
			LONNIJMNKFB().SetFloat("MessageText", Size);
			IIJMIPBMMBF().SetFloat("Left Stick Click", Distortion);
			DNLMFEGJJDD().SetFloat("_color", StormFlashOnOff);
			EMDFHOKEGNG().SetFloat("VHS", DropOnOff);
			EMDFHOKEGNG().SetVector("settings.hitvariation", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 145f, 1584f));
			OLHDPICFBOF().SetTexture(":", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MECJHOJPODB()
	{
	}

	private void OFIMMFHFHDD()
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-65);
		}
		return BJFKDHHMLJH;
	}

	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 797f)
			{
				HBJJOCHGOPH = 335f;
			}
			ABHDNGIHBKE().SetFloat("[PlayerBase] Config error: musicTime <= 0", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("event", Fade);
			DNLMFEGJJDD().SetFloat("null", Intensity);
			OLHDPICFBOF().SetFloat("_Distortion", DirectionX);
			DNLMFEGJJDD().SetFloat("_MainTex2", Speed);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", Size);
			ABHDNGIHBKE().SetFloat("SupportLogger ", Distortion);
			JLHLHKPHDFO().SetFloat("Couldn't color correct with 3D LUT texture. Image Effect will be disabled.", StormFlashOnOff);
			DKKBFFHBHJE().SetFloat(".", DropOnOff);
			KGOLDDBHIFN().SetVector("settings.enablehitsoundsinrelax", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 381f, 1534f));
			LDNADDJMIPK().SetTexture("bad", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DNLMFEGJJDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.HideInHierarchy;
		}
		return BJFKDHHMLJH;
	}

	private void HDMDKOKOOJC()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack/TV_50") as Texture2D;
		SCShader = Shader.Find("_FadeFX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material HHIFMIPPMPF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)98;
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
			NBPKMLMCHFN.SetFloat("_Value", Fade);
			NBPKMLMCHFN.SetFloat("_Value2", Intensity);
			NBPKMLMCHFN.SetFloat("_Value3", DirectionX);
			NBPKMLMCHFN.SetFloat("_Value4", Speed);
			NBPKMLMCHFN.SetFloat("_Value5", Size);
			NBPKMLMCHFN.SetFloat("_Value6", Distortion);
			NBPKMLMCHFN.SetFloat("_Value7", StormFlashOnOff);
			NBPKMLMCHFN.SetFloat("_Value8", DropOnOff);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			NBPKMLMCHFN.SetTexture("Texture2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1281f)
			{
				HBJJOCHGOPH = 88f;
			}
			KAFBNOBOIAJ().SetFloat("{0:0} day{1}, ", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("/Segment-[Up]", Fade);
			LDNADDJMIPK().SetFloat("_TimeX", Intensity);
			DKKBFFHBHJE().SetFloat("_Value4", DirectionX);
			IIJMIPBMMBF().SetFloat("#md5submitionfailed: ", Speed);
			JLHLHKPHDFO().SetFloat("mapselector.orderby", Size);
			HHIFMIPPMPF().SetFloat("_Red_C", Distortion);
			LONNIJMNKFB().SetFloat("_Value3", StormFlashOnOff);
			LONNIJMNKFB().SetFloat("_Value", DropOnOff);
			KEMAALEODNH().SetVector("EnableRankingToggle", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1855f, 1982f));
			KGOLDDBHIFN().SetTexture("kick", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1090f)
			{
				HBJJOCHGOPH = 1285f;
			}
			LONNIJMNKFB().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			LDNADDJMIPK().SetFloat("#combo", Fade);
			NBPKMLMCHFN.SetFloat("_TexelOffsetScale", Intensity);
			LDNADDJMIPK().SetFloat("Custom Authentication failed (either due to user-input or configuration or AuthParameter string format). Calling: OnCustomAuthenticationFailed()", DirectionX);
			JLHLHKPHDFO().SetFloat("_Intensity", Speed);
			DKKBFFHBHJE().SetFloat("_Value4", Size);
			KEMAALEODNH().SetFloat("STICKRHOR", Distortion);
			OLHDPICFBOF().SetFloat("#combo", StormFlashOnOff);
			LONNIJMNKFB().SetFloat("<color=#{0}>{1}</color>", DropOnOff);
			HNICHJCGJOC().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 480f, 1064f));
			DNLMFEGJJDD().SetTexture("LevelInfoInputField", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material KGOLDDBHIFN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material ABHDNGIHBKE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)116;
		}
		return BJFKDHHMLJH;
	}

	private void MFLBEJHMEMO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DBEMDAJDDDA()
	{
		FPHEBLMINDA = Resources.Load("achievements.26.progress") as Texture2D;
		SCShader = Shader.Find("event");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KFACDBHDAOD()
	{
	}

	[SpecialName]
	private Material HNICHJCGJOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)77;
		}
		return BJFKDHHMLJH;
	}

	private void FPHLDMMAOEF()
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void LECCHIAFGGE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CIPKEPDELJB()
	{
		FPHEBLMINDA = Resources.Load("Object ID. Case-Sensitive") as Texture2D;
		SCShader = Shader.Find("AccuracyScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 466f)
			{
				HBJJOCHGOPH = 1793f;
			}
			IIJMIPBMMBF().SetFloat("player.goldlollipop", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("CameraFilterPack/Color_Convert_Normal", Fade);
			LDNADDJMIPK().SetFloat(" ", Intensity);
			LDNADDJMIPK().SetFloat("_PrevViewProj", DirectionX);
			OLHDPICFBOF().SetFloat("\n", Speed);
			KGOLDDBHIFN().SetFloat("Need to specify a start index and end index.", Size);
			JLHLHKPHDFO().SetFloat("id", Distortion);
			LONNIJMNKFB().SetFloat("nogamesfound", StormFlashOnOff);
			LONNIJMNKFB().SetFloat("Noise & Grain effect failing as noise texture is not assigned. please assign.", DropOnOff);
			NBPKMLMCHFN.SetVector("CameraFilterPack/Glasses_On", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1096f, 1864f));
			HNICHJCGJOC().SetTexture("_Amount", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
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
	private Material LONNIJMNKFB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 860f)
			{
				HBJJOCHGOPH = 1123f;
			}
			NBPKMLMCHFN.SetFloat("FullscreenToggle", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("_TimeX", Fade);
			DKKBFFHBHJE().SetFloat("[Up-Right-Down-Left]", Intensity);
			DKKBFFHBHJE().SetFloat("...", DirectionX);
			ABHDNGIHBKE().SetFloat(".lastCheckpoint.incorrectScore", Speed);
			ABHDNGIHBKE().SetFloat("PointsScoreText", Size);
			ABHDNGIHBKE().SetFloat("achievements.21.completed.", Distortion);
			OLHDPICFBOF().SetFloat("_CenterX", StormFlashOnOff);
			IIJMIPBMMBF().SetFloat("CameraFilterPack_Atmosphere_Rain_FX", DropOnOff);
			LDNADDJMIPK().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1297f, 229f));
			KAFBNOBOIAJ().SetTexture("settings.volume.editor", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1030f)
			{
				HBJJOCHGOPH = 1670f;
			}
			DKKBFFHBHJE().SetFloat("setfloat", HBJJOCHGOPH);
			JLHLHKPHDFO().SetFloat("achievements.21.completed.", Fade);
			HNICHJCGJOC().SetFloat("Set Arcs Speed", Intensity);
			KAFBNOBOIAJ().SetFloat(" registered.", DirectionX);
			HNICHJCGJOC().SetFloat("Room: '{0}' {1},{2} {4}/{3} players.", Speed);
			HNICHJCGJOC().SetFloat("SetParent", Size);
			HNICHJCGJOC().SetFloat("PublishMapButton", Distortion);
			ABHDNGIHBKE().SetFloat("[MapsData] Key ", StormFlashOnOff);
			LONNIJMNKFB().SetFloat("InfoCanvas", DropOnOff);
			HHIFMIPPMPF().SetVector("[NetworkManager] Join failed", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1099f, 598f));
			LDNADDJMIPK().SetTexture("_Value2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JHANGPCOCIG()
	{
		FPHEBLMINDA = Resources.Load("_Shadow") as Texture2D;
		SCShader = Shader.Find("_BlendTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NFEDLAOPHML()
	{
	}

	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1722f)
			{
				HBJJOCHGOPH = 1055f;
			}
			LONNIJMNKFB().SetFloat("_MainTex2", HBJJOCHGOPH);
			JLHLHKPHDFO().SetFloat("_Value10", Fade);
			KEMAALEODNH().SetFloat("SpawnObj", Intensity);
			DNLMFEGJJDD().SetFloat("OPEN FILE", DirectionX);
			LONNIJMNKFB().SetFloat("0.00", Speed);
			HHIFMIPPMPF().SetFloat("TotalHitsScoreText", Size);
			JLHLHKPHDFO().SetFloat("_Value5", Distortion);
			HNICHJCGJOC().SetFloat("loadscene", StormFlashOnOff);
			DKKBFFHBHJE().SetFloat("_Value", DropOnOff);
			JLHLHKPHDFO().SetVector("_Red_R", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 551f, 438f));
			LDNADDJMIPK().SetTexture("NameText", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material JLHLHKPHDFO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void HNDNDPECBPL()
	{
	}

	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 280f)
			{
				HBJJOCHGOPH = 437f;
			}
			JLHLHKPHDFO().SetFloat("settings.volume.game", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("FullscreenToggle", Fade);
			HNICHJCGJOC().SetFloat("ReconnectAndRejoin() failed. It seems the client wasn't connected to a game server before (no address).", Intensity);
			DNLMFEGJJDD().SetFloat("player.egglipszerotwo", DirectionX);
			HHIFMIPPMPF().SetFloat("Protocol switch from: ", Speed);
			EMDFHOKEGNG().SetFloat("CameraFilterPack/Blur_Bloom", Size);
			NBPKMLMCHFN.SetFloat("Edited event", Distortion);
			IIJMIPBMMBF().SetFloat("Down ", StormFlashOnOff);
			NBPKMLMCHFN.SetFloat("Error: I/O Failure! :(", DropOnOff);
			OLHDPICFBOF().SetVector("[Down]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 594f, 5f));
			JLHLHKPHDFO().SetTexture("[Left]", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material IIJMIPBMMBF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return BJFKDHHMLJH;
	}

	private void Update()
	{
	}

	private void FBMDHDBELEK()
	{
	}

	private void PLIKADJCEPO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 616f)
			{
				HBJJOCHGOPH = 164f;
			}
			HHIFMIPPMPF().SetFloat("ConfigVersionSlider", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("|", Fade);
			ABHDNGIHBKE().SetFloat("Joystick1Button8", Intensity);
			NBPKMLMCHFN.SetFloat(" - ", DirectionX);
			DKKBFFHBHJE().SetFloat("_SSAO", Speed);
			DNLMFEGJJDD().SetFloat("_TimeX", Size);
			JLHLHKPHDFO().SetFloat("\r", Distortion);
			HNICHJCGJOC().SetFloat("JoystickButton13", StormFlashOnOff);
			DNLMFEGJJDD().SetFloat("Jul", DropOnOff);
			NBPKMLMCHFN.SetVector("Jan", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 938f, 552f));
			LDNADDJMIPK().SetTexture("HighScaleShot", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DHNGNHGDPLM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KCCIEMBMOBA()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack/Colors_Brightness") as Texture2D;
		SCShader = Shader.Find("Intensity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DGCGGKMNPLD()
	{
	}

	private void BOLBPPHJBMI()
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
			if (HBJJOCHGOPH > 254f)
			{
				HBJJOCHGOPH = 124f;
			}
			HHIFMIPPMPF().SetFloat("_Value2", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("#ok", Fade);
			LDNADDJMIPK().SetFloat("_FarCamera", Intensity);
			ABHDNGIHBKE().SetFloat("[PlayerController] ", DirectionX);
			JLHLHKPHDFO().SetFloat("Status: ", Speed);
			KAFBNOBOIAJ().SetFloat("Cannot send messages when not connected. Either connect to Photon OR use offline mode!", Size);
			HHIFMIPPMPF().SetFloat("_Value4", Distortion);
			JLHLHKPHDFO().SetFloat(". Verify the Prefab is in a Resources folder (and not in a subfolder)", StormFlashOnOff);
			LDNADDJMIPK().SetFloat("Overlay", DropOnOff);
			HNICHJCGJOC().SetVector("_Bullet_2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 799f, 1992f));
			IIJMIPBMMBF().SetTexture("received</b>\n#reason: ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
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
	private Material LDNADDJMIPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}
}
