// CameraFilterPack_Atmosphere_Rain_Pro
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Weather/Rain_Pro")]
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
			ABHDNGIHBKE().SetFloat("_Value4", HBJJOCHGOPH);
			OLHDPICFBOF().SetFloat("_Color2", Fade);
			NBPKMLMCHFN.SetFloat("CameraFilterPack_Paper3", Intensity);
			ABHDNGIHBKE().SetFloat("FileMenu", DirectionX);
			KAFBNOBOIAJ().SetFloat("/?player=", Speed);
			ABHDNGIHBKE().SetFloat("RarityImage", Size);
			KAFBNOBOIAJ().SetFloat("_Value7", Distortion);
			IIJMIPBMMBF().SetFloat("Network destroy Instantiated GO: ", StormFlashOnOff);
			NBPKMLMCHFN.SetFloat("menu.playedsolo", DropOnOff);
			HHIFMIPPMPF().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1082f, 541f));
			LONNIJMNKFB().SetTexture("[DiscordController] Join request {0}#{1}: {2}", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JONGNKNLLND()
	{
		FPHEBLMINDA = Resources.Load("#,0.00") as Texture2D;
		SCShader = Shader.Find("_MainTex2");
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
		FPHEBLMINDA = Resources.Load("' ping: ") as Texture2D;
		SCShader = Shader.Find("settings.shaders.bloomintencity");
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
			KAFBNOBOIAJ().SetFloat("Set Satellite Radius", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("_ThirdTex", Fade);
			DNLMFEGJJDD().SetFloat("_TimeX", Intensity);
			OLHDPICFBOF().SetFloat("_TimeX", DirectionX);
			KAFBNOBOIAJ().SetFloat("InventoryContent", Speed);
			JLHLHKPHDFO().SetFloat("SetSunMaxSize", Size);
			OLHDPICFBOF().SetFloat("Start", Distortion);
			DNLMFEGJJDD().SetFloat("settings.disablestoryboard", StormFlashOnOff);
			EMDFHOKEGNG().SetFloat("_History2ChromaTex", DropOnOff);
			LDNADDJMIPK().SetVector("_Value4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1723f, 1267f));
			EMDFHOKEGNG().SetTexture("ExitGames.Client.Photon.SocketWebTcp, Assembly-CSharp", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
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
			JLHLHKPHDFO().SetFloat("Xbox Home", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("isBunned", Fade);
			LDNADDJMIPK().SetFloat("\r", Intensity);
			EMDFHOKEGNG().SetFloat("OpenButton", DirectionX);
			KAFBNOBOIAJ().SetFloat("\r", Speed);
			KGOLDDBHIFN().SetFloat("[LevelEditorScene] Error: I/O Failure! :(", Size);
			HHIFMIPPMPF().SetFloat("value", Distortion);
			KEMAALEODNH().SetFloat("#checkpoint", StormFlashOnOff);
			DKKBFFHBHJE().SetFloat(" elements", DropOnOff);
			IIJMIPBMMBF().SetVector("Map id for", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1129f, 1050f));
			NBPKMLMCHFN.SetTexture("_Value4", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EMDFHOKEGNG());
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
			KGOLDDBHIFN().SetFloat("FinalScoreText", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("PunRespawn", Fade);
			KGOLDDBHIFN().SetFloat(" with a prefix of ", Intensity);
			DNLMFEGJJDD().SetFloat("id", DirectionX);
			EMDFHOKEGNG().SetFloat("_Value3", Speed);
			KGOLDDBHIFN().SetFloat("/", Size);
			LONNIJMNKFB().SetFloat("[PlayerBase] SpawnObj error: ", Distortion);
			DKKBFFHBHJE().SetFloat("workshop.", StormFlashOnOff);
			LDNADDJMIPK().SetFloat("Switch environment sprite image", DropOnOff);
			OLHDPICFBOF().SetVector("Set sun lerp speed", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1394f, 728f));
			DNLMFEGJJDD().SetTexture("bad", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
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
			KGOLDDBHIFN().SetFloat("Reset XP", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("event", Fade);
			KEMAALEODNH().SetFloat("RecieveChatActionMessage", Intensity);
			OLHDPICFBOF().SetFloat("fade out duration", DirectionX);
			OLHDPICFBOF().SetFloat("_Value3", Speed);
			LDNADDJMIPK().SetFloat("CameraFilterPack/Colors_RgbClamp", Size);
			KGOLDDBHIFN().SetFloat("EditMenu", Distortion);
			DNLMFEGJJDD().SetFloat("_Value10", StormFlashOnOff);
			ABHDNGIHBKE().SetFloat("_TimeX", DropOnOff);
			KAFBNOBOIAJ().SetVector("SetPlayerDistance", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 235f, 911f));
			OLHDPICFBOF().SetTexture(". Stopping handling if inactive.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
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
			LONNIJMNKFB().SetFloat("mapselector.filter.subscribedonly", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("UseScanLineSize", Fade);
			LONNIJMNKFB().SetFloat(" or player:", Intensity);
			ABHDNGIHBKE().SetFloat("_Near", DirectionX);
			HHIFMIPPMPF().SetFloat(".r", Speed);
			DNLMFEGJJDD().SetFloat("workshop.", Size);
			HHIFMIPPMPF().SetFloat("<b>", Distortion);
			KAFBNOBOIAJ().SetFloat("other.dust0", StormFlashOnOff);
			NBPKMLMCHFN.SetFloat("Joystick1Button11", DropOnOff);
			KGOLDDBHIFN().SetVector("<b>", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1725f, 351f));
			IIJMIPBMMBF().SetTexture("CameraFilterPack/Light_Rainbow2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
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
			HNICHJCGJOC().SetFloat("JoinOrCreateRoom failed. A roomname is required. If you don't know one, how will you join?", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("[ResourcesManager] Load audio error: ", Fade);
			NBPKMLMCHFN.SetFloat("DeleteButton", Intensity);
			ABHDNGIHBKE().SetFloat("_Intensity", DirectionX);
			KAFBNOBOIAJ().SetFloat("Chat", Speed);
			ABHDNGIHBKE().SetFloat("ready", Size);
			DNLMFEGJJDD().SetFloat("/", Distortion);
			ABHDNGIHBKE().SetFloat("_Value", StormFlashOnOff);
			NBPKMLMCHFN.SetFloat("_Value4", DropOnOff);
			DNLMFEGJJDD().SetVector("[EditorEvent] Exception: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 648f, 1437f));
			LDNADDJMIPK().SetTexture("_TimeX", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
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
			LDNADDJMIPK().SetFloat("_Value4", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("_Visualize", Fade);
			NBPKMLMCHFN.SetFloat("settings.arcsnohitsoundtimedelay", Intensity);
			DKKBFFHBHJE().SetFloat("View", DirectionX);
			DNLMFEGJJDD().SetFloat("LevelInfoInputField", Speed);
			KEMAALEODNH().SetFloat(". Verify the Prefab is in a Resources folder (and not in a subfolder)", Size);
			HHIFMIPPMPF().SetFloat("_ScreenResolution", Distortion);
			HNICHJCGJOC().SetFloat("/", StormFlashOnOff);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", DropOnOff);
			LDNADDJMIPK().SetVector("RecieveChatActionMessage", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1446f, 434f));
			OLHDPICFBOF().SetTexture("_TimeX", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KOJKBFDNGDK()
	{
		FPHEBLMINDA = Resources.Load("_ColorBuffer") as Texture2D;
		SCShader = Shader.Find("There are {0} reported logs.");
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
			IIJMIPBMMBF().SetFloat("/", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("RecieveChatActionMessage", Fade);
			LDNADDJMIPK().SetFloat("DPADHOR", Intensity);
			KEMAALEODNH().SetFloat("true", DirectionX);
			HHIFMIPPMPF().SetFloat("_ScreenResolution", Speed);
			IIJMIPBMMBF().SetFloat("\t", Size);
			KEMAALEODNH().SetFloat("_Value2", Distortion);
			KEMAALEODNH().SetFloat("[PlayerController] ", StormFlashOnOff);
			EMDFHOKEGNG().SetFloat("_Value1", DropOnOff);
			OLHDPICFBOF().SetVector("PhotonNetwork.room is null. You don't have to call LeaveRoom() when you're not in one. State: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1195f, 133f));
			KAFBNOBOIAJ().SetTexture("PhotonView ID duplicate found: {0}. New: {1} old: {2}. Maybe one wasn't destroyed on scene load?! Check for 'DontDestroyOnLoad'. Destroying old entry, adding new.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NBGIMIDICKE()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack/Distortion_ShockWaveManual") as Texture2D;
		SCShader = Shader.Find("DPADVER");
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
			DKKBFFHBHJE().SetFloat("CameraFilterPack/EXTRA_Rotation", HBJJOCHGOPH);
			JLHLHKPHDFO().SetFloat("...", Fade);
			JLHLHKPHDFO().SetFloat("_TimeX", Intensity);
			HHIFMIPPMPF().SetFloat("_SunPosition", DirectionX);
			HHIFMIPPMPF().SetFloat("_Greenness", Speed);
			DNLMFEGJJDD().SetFloat("BestScoreText", Size);
			DNLMFEGJJDD().SetFloat("<size=24>", Distortion);
			JLHLHKPHDFO().SetFloat("/icon", StormFlashOnOff);
			HNICHJCGJOC().SetFloat("BloomShaderValueSlider", DropOnOff);
			KEMAALEODNH().SetVector("BitsData", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1954f, 276f));
			LDNADDJMIPK().SetTexture(".jpg", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF());
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
			HNICHJCGJOC().SetFloat("Joystick1Button12", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("player", Fade);
			LONNIJMNKFB().SetFloat("_TimeX", Intensity);
			EMDFHOKEGNG().SetFloat("Mouse", DirectionX);
			HNICHJCGJOC().SetFloat("settings.fps", Speed);
			OLHDPICFBOF().SetFloat("Yes", Size);
			JLHLHKPHDFO().SetFloat("Zoom speed. Base 1.5", Distortion);
			LONNIJMNKFB().SetFloat("_Value2", StormFlashOnOff);
			DNLMFEGJJDD().SetFloat(" with a prefix of ", DropOnOff);
			NBPKMLMCHFN.SetVector("_dec.json", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 283f, 459f));
			KEMAALEODNH().SetTexture("float,1.5", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FNCDAPDOBBI()
	{
		FPHEBLMINDA = Resources.Load("SetupEncryption() called but ignored. Not XB1 compiled. EncryptionData: ") as Texture2D;
		SCShader = Shader.Find("PossibleMapMaxScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JKFDDNMPOJH()
	{
		FPHEBLMINDA = Resources.Load("SetBGColor") as Texture2D;
		SCShader = Shader.Find("Received RPC \"");
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
			LDNADDJMIPK().SetFloat("_EmissionGain", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("offsets", Fade);
			EMDFHOKEGNG().SetFloat("<b>Time</b>:", Intensity);
			IIJMIPBMMBF().SetFloat("_Contrast", DirectionX);
			LONNIJMNKFB().SetFloat("Alpha", Speed);
			KAFBNOBOIAJ().SetFloat("note.0", Size);
			OLHDPICFBOF().SetFloat("_Amount", Distortion);
			OLHDPICFBOF().SetFloat("set", StormFlashOnOff);
			HNICHJCGJOC().SetFloat("EventMenu", DropOnOff);
			DKKBFFHBHJE().SetVector("_MainTex2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1662f, 75f));
			HHIFMIPPMPF().SetTexture("_EmissionGain", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF());
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
			KAFBNOBOIAJ().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("_TimeX", Fade);
			IIJMIPBMMBF().SetFloat("_History1ChromaTex", Intensity);
			KGOLDDBHIFN().SetFloat("_Overlay", DirectionX);
			DKKBFFHBHJE().SetFloat("menutheme.jamaicanorcdub", Speed);
			HHIFMIPPMPF().SetFloat("_Value2", Size);
			HHIFMIPPMPF().SetFloat("maps.", Distortion);
			LONNIJMNKFB().SetFloat("local CheckCondition = function()", StormFlashOnOff);
			IIJMIPBMMBF().SetFloat(" - GameWebCallback] - ", DropOnOff);
			JLHLHKPHDFO().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 351f, 474f));
			NBPKMLMCHFN.SetTexture("settings.disablestoryboard", FPHEBLMINDA);
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
		FPHEBLMINDA = Resources.Load("scenes") as Texture2D;
		SCShader = Shader.Find("_Value");
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
			HNICHJCGJOC().SetFloat("Netw. Sim.", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("Init", Fade);
			HNICHJCGJOC().SetFloat("intensity", Intensity);
			KGOLDDBHIFN().SetFloat("_ReflectionTexture1", DirectionX);
			DNLMFEGJJDD().SetFloat("_FarCamera", Speed);
			NBPKMLMCHFN.SetFloat("green", Size);
			KGOLDDBHIFN().SetFloat("AddEnvironmentSprite", Distortion);
			ABHDNGIHBKE().SetFloat("FinalScoreSmallText", StormFlashOnOff);
			IIJMIPBMMBF().SetFloat("Messages (shift+tab)", DropOnOff);
			HHIFMIPPMPF().SetVector("_Colored", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 361f, 468f));
			NBPKMLMCHFN.SetTexture("_VelTex", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
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
			JLHLHKPHDFO().SetFloat("EventSystem", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat(".icon", Fade);
			DNLMFEGJJDD().SetFloat("_ScreenResolution", Intensity);
			KAFBNOBOIAJ().SetFloat("_TimeX", DirectionX);
			ABHDNGIHBKE().SetFloat("_TimeX", Speed);
			NBPKMLMCHFN.SetFloat("/", Size);
			NBPKMLMCHFN.SetFloat("Editor/", Distortion);
			LDNADDJMIPK().SetFloat("[SERVER] Player ", StormFlashOnOff);
			LONNIJMNKFB().SetFloat("EnvironmentSlider", DropOnOff);
			LDNADDJMIPK().SetVector("{0} minutes ago", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 824f, 431f));
			HNICHJCGJOC().SetTexture("_ScreenResolution", FPHEBLMINDA);
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
			KEMAALEODNH().SetFloat("{0}{1}:{2}", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("checkpoint", Fade);
			EMDFHOKEGNG().SetFloat("ResourceIDInputField", Intensity);
			LONNIJMNKFB().SetFloat("ItemNameText", DirectionX);
			DKKBFFHBHJE().SetFloat("Rotate environment object to the rotation", Speed);
			LDNADDJMIPK().SetFloat("MessageText", Size);
			KGOLDDBHIFN().SetFloat("Joystick1Button10", Distortion);
			OLHDPICFBOF().SetFloat("_Value4", StormFlashOnOff);
			HHIFMIPPMPF().SetFloat("CameraFilterPack_VHS2", DropOnOff);
			HNICHJCGJOC().SetVector("settings.selectormapsperpage", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 145f, 1584f));
			JLHLHKPHDFO().SetTexture(".", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
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
			IIJMIPBMMBF().SetFloat("sprite", HBJJOCHGOPH);
			JLHLHKPHDFO().SetFloat("BitsData", Fade);
			KGOLDDBHIFN().SetFloat("Received RPC: ", Intensity);
			LONNIJMNKFB().SetFloat("_CenterY", DirectionX);
			EMDFHOKEGNG().SetFloat("_MainTex2", Speed);
			HNICHJCGJOC().SetFloat("_ScreenResolution", Size);
			DKKBFFHBHJE().SetFloat("SupportLogger OnApplicationPause: ", Distortion);
			NBPKMLMCHFN.SetFloat("The given 2D texture ", StormFlashOnOff);
			HNICHJCGJOC().SetFloat("maps.", DropOnOff);
			LDNADDJMIPK().SetVector("menu.enableselectormusic", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 381f, 1534f));
			EMDFHOKEGNG().SetTexture("#tryagain", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
		FPHEBLMINDA = Resources.Load("_Value4") as Texture2D;
		SCShader = Shader.Find("_Blue_C");
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
			KGOLDDBHIFN().SetFloat("{0:0} day{1}, ", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("[PlayerBase] Current attempt: ", Fade);
			KEMAALEODNH().SetFloat("CameraFilterPack/Special_Bubble", Intensity);
			NBPKMLMCHFN.SetFloat("_Value3", DirectionX);
			HNICHJCGJOC().SetFloat("maxScore", Speed);
			HNICHJCGJOC().SetFloat("mapselector.orderby", Size);
			DNLMFEGJJDD().SetFloat("_Red_C", Distortion);
			NBPKMLMCHFN.SetFloat("_Value2", StormFlashOnOff);
			JLHLHKPHDFO().SetFloat("_Value", DropOnOff);
			LONNIJMNKFB().SetVector("EnableRankingToggle", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1855f, 1982f));
			KAFBNOBOIAJ().SetTexture("kick", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			IIJMIPBMMBF().SetFloat("_FarCamera", HBJJOCHGOPH);
			LDNADDJMIPK().SetFloat("#combo", Fade);
			DKKBFFHBHJE().SetFloat("_TexelOffsetScale", Intensity);
			KGOLDDBHIFN().SetFloat("If you host Photon yourself, make sure to start the 'Instance LoadBalancing' ", DirectionX);
			NBPKMLMCHFN.SetFloat("_Blend", Speed);
			DKKBFFHBHJE().SetFloat("_Value3", Size);
			KAFBNOBOIAJ().SetFloat("STICKLVER", Distortion);
			KGOLDDBHIFN().SetFloat("#combo", StormFlashOnOff);
			IIJMIPBMMBF().SetFloat("Type \"help\" for list of commands", DropOnOff);
			KGOLDDBHIFN().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 480f, 1064f));
			DNLMFEGJJDD().SetTexture("Tab1Content", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
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
		SCShader = Shader.Find("checkpoint");
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
			KAFBNOBOIAJ().SetFloat("player.greenlollipop", HBJJOCHGOPH);
			OLHDPICFBOF().SetFloat("CameraFilterPack/Color_Convert_Normal", Fade);
			LDNADDJMIPK().SetFloat("#{0:00}{1}{2}", Intensity);
			KAFBNOBOIAJ().SetFloat("_TileTexDebug", DirectionX);
			KAFBNOBOIAJ().SetFloat(":", Speed);
			KGOLDDBHIFN().SetFloat("X2", Size);
			JLHLHKPHDFO().SetFloat("id", Distortion);
			DNLMFEGJJDD().SetFloat("nogamesfound", StormFlashOnOff);
			KAFBNOBOIAJ().SetFloat("_MainTex", DropOnOff);
			LDNADDJMIPK().SetVector("CameraFilterPack_Glasses_On6", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1096f, 1864f));
			OLHDPICFBOF().SetTexture("_TimeX", FPHEBLMINDA);
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
			EMDFHOKEGNG().SetFloat("SettingsCanvas", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("CameraFilterPack/TV_BrokenGlass2", Fade);
			HHIFMIPPMPF().SetFloat("[Up-Down-Left]", Intensity);
			IIJMIPBMMBF().SetFloat("...", DirectionX);
			HHIFMIPPMPF().SetFloat(".lastCheckpoint.powerupsScore", Speed);
			LDNADDJMIPK().SetFloat("PossibleMapPointsText", Size);
			KGOLDDBHIFN().SetFloat("achievements.21.completed.", Distortion);
			EMDFHOKEGNG().SetFloat("_TimeX", StormFlashOnOff);
			DNLMFEGJJDD().SetFloat("CameraFilterPack_Atmosphere_Rain_FX", DropOnOff);
			IIJMIPBMMBF().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1297f, 229f));
			JLHLHKPHDFO().SetTexture("ItemNameText", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JLHLHKPHDFO());
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
			KEMAALEODNH().SetFloat(" : ", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat(".completed", Fade);
			EMDFHOKEGNG().SetFloat("SetSpeed", Intensity);
			IIJMIPBMMBF().SetFloat("Vertical", DirectionX);
			JLHLHKPHDFO().SetFloat("Can't set MaxPlayers when not in that room.", Speed);
			KGOLDDBHIFN().SetFloat("ClearEnvironment", Size);
			OLHDPICFBOF().SetFloat("TestMapButton", Distortion);
			OLHDPICFBOF().SetFloat(".completed", StormFlashOnOff);
			DNLMFEGJJDD().SetFloat("DifficultyBG", DropOnOff);
			OLHDPICFBOF().SetVector("[NetworkManager] Join failed", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1099f, 598f));
			NBPKMLMCHFN.SetTexture("_Value", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JHANGPCOCIG()
	{
		FPHEBLMINDA = Resources.Load("_Fade") as Texture2D;
		SCShader = Shader.Find("USE_UV_BASED_REPROJECTION");
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
			IIJMIPBMMBF().SetFloat("_MainTex2", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("_Value10", Fade);
			OLHDPICFBOF().SetFloat("[Right]", Intensity);
			JLHLHKPHDFO().SetFloat("_LensDirt", DirectionX);
			HHIFMIPPMPF().SetFloat("CurrentTimeLabel", Speed);
			NBPKMLMCHFN.SetFloat("TotalHitsScoreText", Size);
			KGOLDDBHIFN().SetFloat("_Value4", Distortion);
			HHIFMIPPMPF().SetFloat("scenes", StormFlashOnOff);
			EMDFHOKEGNG().SetFloat("_Value", DropOnOff);
			DKKBFFHBHJE().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 551f, 438f));
			KGOLDDBHIFN().SetTexture("NameText", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
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
			IIJMIPBMMBF().SetFloat("settings.volume.menu", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("SettingsCanvas", Fade);
			HHIFMIPPMPF().SetFloat("Reconnect() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", Intensity);
			NBPKMLMCHFN.SetFloat("player.redabstract", DirectionX);
			LDNADDJMIPK().SetFloat("ExitGames.Client.Photon.SocketWebTcp, Assembly-CSharp", Speed);
			DKKBFFHBHJE().SetFloat("CameraFilterPack/Blur_Bloom", Size);
			KEMAALEODNH().SetFloat("ResourceFileSelector", Distortion);
			KEMAALEODNH().SetFloat("Down", StormFlashOnOff);
			KGOLDDBHIFN().SetFloat("https://steamcommunity.com/sharedfiles/filedetails/?id=", DropOnOff);
			LDNADDJMIPK().SetVector("[Down]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 594f, 5f));
			DNLMFEGJJDD().SetTexture("[Left]", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
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
			NBPKMLMCHFN.SetFloat("ConfigVersionSlider", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat(";", Fade);
			DNLMFEGJJDD().SetFloat("RT", Intensity);
			DKKBFFHBHJE().SetFloat(" - ", DirectionX);
			DKKBFFHBHJE().SetFloat("_TexelOffsetScale", Speed);
			KEMAALEODNH().SetFloat("CameraFilterPack/TV_WideScreenHV", Size);
			HNICHJCGJOC().SetFloat("\r", Distortion);
			KGOLDDBHIFN().SetFloat("Joystick1Button12", StormFlashOnOff);
			HHIFMIPPMPF().SetFloat("May", DropOnOff);
			JLHLHKPHDFO().SetVector("No child content found, exiting..", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 938f, 552f));
			HHIFMIPPMPF().SetTexture("HighScaleShot", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
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
		FPHEBLMINDA = Resources.Load("_ScreenResolution") as Texture2D;
		SCShader = Shader.Find("Fade");
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
			HNICHJCGJOC().SetFloat("_Value2", HBJJOCHGOPH);
			EMDFHOKEGNG().SetFloat("#forever", Fade);
			HHIFMIPPMPF().SetFloat("_FarCamera", Intensity);
			KEMAALEODNH().SetFloat(": ", DirectionX);
			HHIFMIPPMPF().SetFloat("n/a", Speed);
			EMDFHOKEGNG().SetFloat("ConnectToRegion: ", Size);
			OLHDPICFBOF().SetFloat("_Value2", Distortion);
			DNLMFEGJJDD().SetFloat(". Client is not the MasterClient in this room.", StormFlashOnOff);
			LONNIJMNKFB().SetFloat("Text", DropOnOff);
			KAFBNOBOIAJ().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 799f, 1992f));
			DNLMFEGJJDD().SetTexture("received</b>\n#reason: ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
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
