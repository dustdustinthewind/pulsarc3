// CameraFilterPack_Glasses_On_6
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Glasses/Spy")]
public class CameraFilterPack_Glasses_On_6 : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	[Range(0f, 1f)]
	public float Fade = 0.2f;

	[Range(0f, 0.1f)]
	public float VisionBlur = 0.005f;

	public Color GlassesColor = new Color(0f, 0f, 0f, 1f);

	public Color GlassesColor2 = new Color(0.25f, 0.25f, 0.45f, 0.25f);

	[Range(0f, 1f)]
	public float GlassDistortion = 0.6f;

	[Range(0f, 1f)]
	public float GlassAberration = 0.3f;

	[Range(0f, 1f)]
	public float UseFinalGlassColor;

	[Range(0f, 1f)]
	public float UseScanLine = 0.4f;

	[Range(1f, 512f)]
	public float UseScanLineSize = 358f;

	public Color GlassColor = new Color(1f, 0.9f, 0f, 1f);

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

	private void AAEEHINDPNC()
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
			if (HBJJOCHGOPH > 833f)
			{
				HBJJOCHGOPH = 1183f;
			}
			FAIFBBGFAIB().SetFloat("Connecting to server", HBJJOCHGOPH);
			OJMHIMIPKME().SetFloat("<start_index> <end_index>", UseFinalGlassColor);
			OGMEGHKECAH().SetFloat(" beatThreshold: ", Fade);
			BFGNMFCNDBC().SetFloat("Joystick1Button10", VisionBlur);
			MFHPKGICPIO().SetFloat("challenges.", GlassDistortion);
			OKJOKHGJHGF().SetFloat("Creating new item...", GlassAberration);
			ADGHJOHKEHG().SetColor("_TimeX", GlassesColor);
			ADGHJOHKEHG().SetColor("Gameplay/particles", GlassesColor2);
			LPMLLJKMAMP().SetColor("_Red_C", GlassColor);
			ADAFMBOGPLN().SetFloat("_ReflectionTexture1", UseScanLineSize);
			ELBMIEOIABA().SetFloat("_Gain", UseScanLine);
			IIJMIPBMMBF().SetTexture("inventory.selected.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPPEPKGFOEM());
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
			if (HBJJOCHGOPH > 1170f)
			{
				HBJJOCHGOPH = 1984f;
			}
			HJGEHJDMCGI().SetFloat(" canvas not found", HBJJOCHGOPH);
			LPPEPKGFOEM().SetFloat("history", UseFinalGlassColor);
			FAIFBBGFAIB().SetFloat("_ScreenResolution", Fade);
			LPMLLJKMAMP().SetFloat("_SunColor", VisionBlur);
			IIJMIPBMMBF().SetFloat("_Distortion", GlassDistortion);
			IONHGBPGCHK().SetFloat(".message", GlassAberration);
			ADGHJOHKEHG().SetColor("No Name", GlassesColor);
			LPMLLJKMAMP().SetColor("_Value7", GlassesColor2);
			IIJMIPBMMBF().SetColor("ItemNameText", GlassColor);
			OJMHIMIPKME().SetFloat("OK", UseScanLineSize);
			LMLENGFLEBD().SetFloat("ConnectUsingSettings() disabled the offline mode. No longer offline.", UseScanLine);
			MFHPKGICPIO().SetTexture("[PlayerController] ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADAFMBOGPLN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JONGNKNLLND()
	{
		FPHEBLMINDA = Resources.Load("_SecondTex") as Texture2D;
		SCShader = Shader.Find("value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DBEMDAJDDDA()
	{
		FPHEBLMINDA = Resources.Load("set environment id") as Texture2D;
		SCShader = Shader.Find(": ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void Update()
	{
	}

	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 115f)
			{
				HBJJOCHGOPH = 36f;
			}
			ELBMIEOIABA().SetFloat("_PColor2", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat(" on effect ", UseFinalGlassColor);
			LPMLLJKMAMP().SetFloat("LevelNameInputField", Fade);
			EFMCNLELMDO().SetFloat("maps.", VisionBlur);
			ELBMIEOIABA().SetFloat("_ScreenResolution", GlassDistortion);
			MFHPKGICPIO().SetFloat("CameraFilterPack/Blend2Camera_Multiply", GlassAberration);
			LMLENGFLEBD().SetColor("_Value3", GlassesColor);
			FAIFBBGFAIB().SetColor(": ", GlassesColor2);
			ADGHJOHKEHG().SetColor("value", GlassColor);
			NBPKMLMCHFN.SetFloat("Mouse2", UseScanLineSize);
			FAIFBBGFAIB().SetFloat("Joystick1Button7", UseScanLine);
			NBPKMLMCHFN.SetTexture("_Intensity", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GFACKFCEIBC()
	{
	}

	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 857f)
			{
				HBJJOCHGOPH = 1951f;
			}
			HJGEHJDMCGI().SetFloat(" ", HBJJOCHGOPH);
			HJGEHJDMCGI().SetFloat("CameraFilterPack/Blend2Camera_HardLight", UseFinalGlassColor);
			PLBEJJIHFPB().SetFloat(" is muted", Fade);
			ELBMIEOIABA().SetFloat("_MainTexBlurred", VisionBlur);
			OKJOKHGJHGF().SetFloat("{0:0} hour{1}, ", GlassDistortion);
			EFMCNLELMDO().SetFloat("CameraFilterPack/Blur_Blurry", GlassAberration);
			OKJOKHGJHGF().SetColor("/", GlassesColor);
			KLKILLCHJHO().SetColor("<b>Kick player by NetID</b>\nuse: /kick {NetID}\nUse \"/players\" command to get all NetIDs\nRoom owner only can kick the players", GlassesColor2);
			KLKILLCHJHO().SetColor("/", GlassColor);
			LPPEPKGFOEM().SetFloat("/", UseScanLineSize);
			MFHPKGICPIO().SetFloat("_Bloom3", UseScanLine);
			IIJMIPBMMBF().SetTexture("Edited unlock conditions", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KIMMMCJFMAB()
	{
		FPHEBLMINDA = Resources.Load("Received your UserID from server. Updating local value to: {0}") as Texture2D;
		SCShader = Shader.Find("EndlessLoopsScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FNCDAPDOBBI()
	{
		FPHEBLMINDA = Resources.Load("Hidden/Image Effects/Cinematic/MotionBlur/Reconstruction") as Texture2D;
		SCShader = Shader.Find("[PlayerController] ");
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
			if (HBJJOCHGOPH > 278f)
			{
				HBJJOCHGOPH = 567f;
			}
			ADAFMBOGPLN().SetFloat("id", HBJJOCHGOPH);
			EFMCNLELMDO().SetFloat("_Amount", UseFinalGlassColor);
			KLKILLCHJHO().SetFloat("y", Fade);
			NBPKMLMCHFN.SetFloat("Sending vacant view IDs. Length: ", VisionBlur);
			OJMHIMIPKME().SetFloat("settings_bindings_sec_", GlassDistortion);
			ELBMIEOIABA().SetFloat("ResourcesConfig", GlassAberration);
			LPPEPKGFOEM().SetColor("score", GlassesColor);
			IONHGBPGCHK().SetColor("_Value6", GlassesColor2);
			EFMCNLELMDO().SetColor("Authentication failed: '{0}' Code: {1}", GlassColor);
			BFGNMFCNDBC().SetFloat(".highscore", UseScanLineSize);
			IONHGBPGCHK().SetFloat("GlassColor", UseScanLine);
			LMLENGFLEBD().SetTexture("MultiplayerButton", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ELBMIEOIABA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ALMGMOOHLMA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1746f)
			{
				HBJJOCHGOPH = 1417f;
			}
			ADAFMBOGPLN().SetFloat("Load Game", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("Default UI Material", UseFinalGlassColor);
			BFGNMFCNDBC().SetFloat("_Value2", Fade);
			OGMEGHKECAH().SetFloat("skin.", VisionBlur);
			HJGEHJDMCGI().SetFloat("_Value5", GlassDistortion);
			ADGHJOHKEHG().SetFloat("maps.", GlassAberration);
			LMLENGFLEBD().SetColor(" Maybe GO was destroyed but RPC not cleaned up.", GlassesColor);
			IONHGBPGCHK().SetColor("[NetworkManager] Connected to ", GlassesColor2);
			OKJOKHGJHGF().SetColor("_MainTex2", GlassColor);
			LPPEPKGFOEM().SetFloat("Reload Maps", UseScanLineSize);
			OJMHIMIPKME().SetFloat("EndlessLoopsScoreText", UseScanLine);
			PLBEJJIHFPB().SetTexture(" beatThreshold: ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NKFDNIAKGEO()
	{
		FPHEBLMINDA = Resources.Load("ShowTitle") as Texture2D;
		SCShader = Shader.Find("The authentication ticket expired. You need to connect (and authenticate) again. Disconnecting.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ANCKKLFPGDI()
	{
		FPHEBLMINDA = Resources.Load("Data") as Texture2D;
		SCShader = Shader.Find("_LowRez");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material OKJOKHGJHGF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 945f)
			{
				HBJJOCHGOPH = 1598f;
			}
			FAIFBBGFAIB().SetFloat("_MainTex2", HBJJOCHGOPH);
			OKJOKHGJHGF().SetFloat("settings_bindings_sec_", UseFinalGlassColor);
			LPPEPKGFOEM().SetFloat(".lastCheckpoint.lives", Fade);
			KLKILLCHJHO().SetFloat("PhotonView with ID {0} wasn't properly unregistered! Please report this case to developer@photonengine.com", VisionBlur);
			IIJMIPBMMBF().SetFloat("Please define the RectTransform for the Center viewport of the scrollable area", GlassDistortion);
			KLKILLCHJHO().SetFloat(" ", GlassAberration);
			ADGHJOHKEHG().SetColor("CameraFilterPack/Distortion_Lens", GlassesColor);
			BFGNMFCNDBC().SetColor("[Sound Manager] Audio clip is null, cannot play music", GlassesColor2);
			BFGNMFCNDBC().SetColor("Skipping EstablishEncryption. Protocol is secure.", GlassColor);
			IONHGBPGCHK().SetFloat("DPADHOR", UseScanLineSize);
			OGMEGHKECAH().SetFloat("Stream did not contain properly formatted byte array", UseScanLine);
			ELBMIEOIABA().SetTexture(" or player:", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPPEPKGFOEM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LADCJEIALMH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Start()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_Glasses_On7") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Glasses_On");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HOMNAHDDNHJ()
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

	private void ILCFPCIPENO()
	{
		FPHEBLMINDA = Resources.Load("#") as Texture2D;
		SCShader = Shader.Find("PLEASE WAIT");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FJKJGBLPDGG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1311f)
			{
				HBJJOCHGOPH = 1596f;
			}
			OKJOKHGJHGF().SetFloat("_Value2", HBJJOCHGOPH);
			LPPEPKGFOEM().SetFloat("BadgeText", UseFinalGlassColor);
			NBPKMLMCHFN.SetFloat("[PlayerBase] Starting game from: ", Fade);
			BFGNMFCNDBC().SetFloat("HitVariationSlider", VisionBlur);
			EFMCNLELMDO().SetFloat("_Visualize", GlassDistortion);
			OKJOKHGJHGF().SetFloat("_MainTex2", GlassAberration);
			OKJOKHGJHGF().SetColor("_Blue_R", GlassesColor);
			LPMLLJKMAMP().SetColor("CameraFilterPack/Gradients_Desert", GlassesColor2);
			BFGNMFCNDBC().SetColor(".jpg", GlassColor);
			PLBEJJIHFPB().SetFloat("checkpoint", UseScanLineSize);
			PLBEJJIHFPB().SetFloat("maps.", UseScanLine);
			HJGEHJDMCGI().SetTexture("_Value5", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HAIAHJPCPAG()
	{
		FPHEBLMINDA = Resources.Load("_MainTex2") as Texture2D;
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1249f)
			{
				HBJJOCHGOPH = 1378f;
			}
			OJMHIMIPKME().SetFloat("file://", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("HPToggle", UseFinalGlassColor);
			EFMCNLELMDO().SetFloat("menu.selectedmode", Fade);
			KLKILLCHJHO().SetFloat("_ColoredChange", VisionBlur);
			ELBMIEOIABA().SetFloat("Tab1Content", GlassDistortion);
			ADAFMBOGPLN().SetFloat("CreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", GlassAberration);
			NBPKMLMCHFN.SetColor("_History2ChromaTex", GlassesColor);
			LPMLLJKMAMP().SetColor("_VelTex", GlassesColor2);
			LPPEPKGFOEM().SetColor("achievements.21.progress", GlassColor);
			OGMEGHKECAH().SetFloat("y", UseScanLineSize);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Distortion_Wave_Horizontal", UseScanLine);
			MFHPKGICPIO().SetTexture("Tab1Content", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OCMKCBBCEFG()
	{
	}

	private void LFAFJKJAEEL()
	{
		FPHEBLMINDA = Resources.Load("/") as Texture2D;
		SCShader = Shader.Find("icon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CCLNNLCOPBL()
	{
		FPHEBLMINDA = Resources.Load("_ScreenResolution") as Texture2D;
		SCShader = Shader.Find("ACCEPT");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material OJMHIMIPKME()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IIJMIPBMMBF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void HDMDKOKOOJC()
	{
		FPHEBLMINDA = Resources.Load("Player Disconnected") as Texture2D;
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HONBLGFDMLL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GJLKJAOBPJD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1750f)
			{
				HBJJOCHGOPH = 1437f;
			}
			OKJOKHGJHGF().SetFloat("_Value", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Noise_TV_2", UseFinalGlassColor);
			FAIFBBGFAIB().SetFloat("Hidden/ScreenSpaceReflection", Fade);
			FAIFBBGFAIB().SetFloat("value", VisionBlur);
			HJGEHJDMCGI().SetFloat("...", GlassDistortion);
			ADGHJOHKEHG().SetFloat("[PlayerController] ", GlassAberration);
			OGMEGHKECAH().SetColor("maps.", GlassesColor);
			LPPEPKGFOEM().SetColor("The process failed: ", GlassesColor2);
			MFHPKGICPIO().SetColor("VHS", GlassColor);
			PLBEJJIHFPB().SetFloat("Object ID. Case-Sensitive", UseScanLineSize);
			LPMLLJKMAMP().SetFloat("_TimeX", UseScanLine);
			EFMCNLELMDO().SetTexture("randomdrop", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AGMJDGHLBMN()
	{
	}

	private void DLIJFEGIEKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 472f)
			{
				HBJJOCHGOPH = 506f;
			}
			ADGHJOHKEHG().SetFloat("Adreno", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("skin.no_hit", UseFinalGlassColor);
			IONHGBPGCHK().SetFloat("true", Fade);
			LPPEPKGFOEM().SetFloat("BadgeText", VisionBlur);
			PLBEJJIHFPB().SetFloat("_Speed", GlassDistortion);
			OGMEGHKECAH().SetFloat("id", GlassAberration);
			HJGEHJDMCGI().SetColor("value", GlassesColor);
			IONHGBPGCHK().SetColor("UseFinalGlassColor", GlassesColor2);
			PLBEJJIHFPB().SetColor("_TimeX", GlassColor);
			LMLENGFLEBD().SetFloat("_TimeX", UseScanLineSize);
			ADAFMBOGPLN().SetFloat("AllocateViewID() failed. Room (user {0}) is out of 'scene' viewIDs. It seems all available are in use.", UseScanLine);
			PLBEJJIHFPB().SetTexture("CameraFilterPack/FX_Glitch2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LMBDNPLDGIJ()
	{
	}

	private void OPCLBGHAPMG()
	{
	}

	private void KKLMPKLKAEM()
	{
	}

	private void BNEJMABFKJE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DOFDGBGEDFI()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack/Colors_BleachBypass") as Texture2D;
		SCShader = Shader.Find("PlayerBase_");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LBPHCAMMAPB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HNDNDPECBPL()
	{
	}

	private void JOJFHFHOCHO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LECCHIAFGGE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MGMAOBPPOBJ()
	{
		FPHEBLMINDA = Resources.Load("_Value") as Texture2D;
		SCShader = Shader.Find("SettingsCanvas");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MKIFJMPELJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 848f)
			{
				HBJJOCHGOPH = 1467f;
			}
			NBPKMLMCHFN.SetFloat("Item ", HBJJOCHGOPH);
			LPPEPKGFOEM().SetFloat("SetSatelliteLerpSpeed", UseFinalGlassColor);
			LMLENGFLEBD().SetFloat("CameraFilterPack/Vision_Warp", Fade);
			LPPEPKGFOEM().SetFloat("0,7,true,0", VisionBlur);
			HJGEHJDMCGI().SetFloat("ItemNameText", GlassDistortion);
			OGMEGHKECAH().SetFloat("ExitButton", GlassAberration);
			ADGHJOHKEHG().SetColor("Keypad", GlassesColor);
			KLKILLCHJHO().SetColor("Data/Skins/", GlassesColor2);
			IIJMIPBMMBF().SetColor(".", GlassColor);
			BFGNMFCNDBC().SetFloat("settings.enablerankingnotifications", UseScanLineSize);
			PLBEJJIHFPB().SetFloat("_TimeX", UseScanLine);
			IIJMIPBMMBF().SetTexture("\\n", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADAFMBOGPLN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KMOCDAOKGLI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 440f)
			{
				HBJJOCHGOPH = 219f;
			}
			ADGHJOHKEHG().SetFloat("menu.tabid", HBJJOCHGOPH);
			OKJOKHGJHGF().SetFloat("_ScreenResolution", UseFinalGlassColor);
			BFGNMFCNDBC().SetFloat("Emergency Help:", Fade);
			OGMEGHKECAH().SetFloat("_Near", VisionBlur);
			ADGHJOHKEHG().SetFloat(".mp3", GlassDistortion);
			LMLENGFLEBD().SetFloat("_SpawnHeuristic", GlassAberration);
			NBPKMLMCHFN.SetColor("_ScreenResolution", GlassesColor);
			IIJMIPBMMBF().SetColor("ControllerRightY", GlassesColor2);
			BFGNMFCNDBC().SetColor("Deleted event", GlassColor);
			KLKILLCHJHO().SetFloat("_ScreenResolution", UseScanLineSize);
			EFMCNLELMDO().SetFloat("IconImage", UseScanLine);
			IIJMIPBMMBF().SetTexture("_Intensity", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DPLLKHHLDBB()
	{
		FPHEBLMINDA = Resources.Load("Editor/") as Texture2D;
		SCShader = Shader.Find("End index must in an integer.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IDJKNBDKHBD()
	{
		FPHEBLMINDA = Resources.Load("_Distortion") as Texture2D;
		SCShader = Shader.Find("Reload Steam Inventory");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material LPPEPKGFOEM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-97);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material LMLENGFLEBD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-100);
		}
		return BJFKDHHMLJH;
	}

	private void ONMGIPAILOH()
	{
	}

	[SpecialName]
	private Material OGMEGHKECAH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void FAMLCFNDGNI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AEMGPJDJGBJ()
	{
		FPHEBLMINDA = Resources.Load("Set Particles Color") as Texture2D;
		SCShader = Shader.Find("LastNewsButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material ADGHJOHKEHG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)82;
		}
		return BJFKDHHMLJH;
	}

	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 589f)
			{
				HBJJOCHGOPH = 956f;
			}
			OGMEGHKECAH().SetFloat("#scoresubmitionfailed: ", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("[GameEvent] Exeption:", UseFinalGlassColor);
			LPMLLJKMAMP().SetFloat("Left", Fade);
			EFMCNLELMDO().SetFloat("[MapEditor] Item creation successful! Published Item ID: ", VisionBlur);
			IONHGBPGCHK().SetFloat("_ScreenResolution", GlassDistortion);
			ADGHJOHKEHG().SetFloat("DPADHOR", GlassAberration);
			LPPEPKGFOEM().SetColor("_ColorR", GlassesColor);
			ADAFMBOGPLN().SetColor("_ScreenResolution", GlassesColor2);
			KLKILLCHJHO().SetColor("menutheme.coldheat", GlassColor);
			ELBMIEOIABA().SetFloat("SetTrailZoomSpeed", UseScanLineSize);
			FAIFBBGFAIB().SetFloat("GridDataArcs", UseScanLine);
			NBPKMLMCHFN.SetTexture("_RangeScale", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BMOFEBKGLFI()
	{
		FPHEBLMINDA = Resources.Load("Health Stats") as Texture2D;
		SCShader = Shader.Find("\" on viewID ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DKOPKPBLDHH()
	{
		FPHEBLMINDA = Resources.Load("_TimeX") as Texture2D;
		SCShader = Shader.Find("[LevelEditorScene] Updated");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1670f)
			{
				HBJJOCHGOPH = 1133f;
			}
			OJMHIMIPKME().SetFloat("_Offsets", HBJJOCHGOPH);
			LPPEPKGFOEM().SetFloat("DataText", UseFinalGlassColor);
			BFGNMFCNDBC().SetFloat("Floating point textures aren't supported on this device ({0})", Fade);
			OJMHIMIPKME().SetFloat("Run a command for data system", VisionBlur);
			LPMLLJKMAMP().SetFloat("_TimeX", GlassDistortion);
			ADAFMBOGPLN().SetFloat("_Green_G", GlassAberration);
			LPMLLJKMAMP().SetColor(" This is not possible to be called for standalone input. Please check your platform and code where this is called", GlassesColor);
			OGMEGHKECAH().SetColor("_FarCamera", GlassesColor2);
			FAIFBBGFAIB().SetColor("Player Connected", GlassColor);
			LPMLLJKMAMP().SetFloat("CameraFilterPack/Blend2Camera_Darken", UseScanLineSize);
			LPPEPKGFOEM().SetFloat("_Blood", UseScanLine);
			ELBMIEOIABA().SetTexture("'{0}' \t{1}ms \t{2}", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HAHJJPLPOKB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FDPOFMCFBMF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NCPAFCKGJEA()
	{
	}

	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1762f)
			{
				HBJJOCHGOPH = 222f;
			}
			MFHPKGICPIO().SetFloat("[DiscordController] Responding no to Ask to Join request", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("_Value3", UseFinalGlassColor);
			HJGEHJDMCGI().SetFloat("CameraFilterPack/Blur_Focus", Fade);
			ADAFMBOGPLN().SetFloat("{", VisionBlur);
			FAIFBBGFAIB().SetFloat("_Value", GlassDistortion);
			IONHGBPGCHK().SetFloat("{\"items\":", GlassAberration);
			OGMEGHKECAH().SetColor("_Value", GlassesColor);
			ELBMIEOIABA().SetColor("Messages (shift+tab)", GlassesColor2);
			NBPKMLMCHFN.SetColor("_Value8", GlassColor);
			ADGHJOHKEHG().SetFloat(".completedMaps", UseScanLineSize);
			IONHGBPGCHK().SetFloat("#no", UseScanLine);
			PLBEJJIHFPB().SetTexture("_Threshhold", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HEBOIFKBLGD()
	{
	}

	private void EKPLGFAEOBE()
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

	private void PGMMBADJIKH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JHJGJJKELJM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AOKOLPEGHDD()
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

	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 408f)
			{
				HBJJOCHGOPH = 824f;
			}
			KLKILLCHJHO().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			KLKILLCHJHO().SetFloat("player.mysteryitem", UseFinalGlassColor);
			KLKILLCHJHO().SetFloat("owner: ", Fade);
			KLKILLCHJHO().SetFloat("CameraFilterPack/Drawing_Manga5", VisionBlur);
			OJMHIMIPKME().SetFloat("_Value4", GlassDistortion);
			LPMLLJKMAMP().SetFloat("_Value", GlassAberration);
			IONHGBPGCHK().SetColor("SetSatelliteInput", GlassesColor);
			FAIFBBGFAIB().SetColor("stats on", GlassesColor2);
			IIJMIPBMMBF().SetColor("#alreadyexist", GlassColor);
			ADAFMBOGPLN().SetFloat("CameraFilterPack/TV_Old_Movie", UseScanLineSize);
			MFHPKGICPIO().SetFloat("_Intensity", UseScanLine);
			KLKILLCHJHO().SetTexture("ERROR: preview file name is empty in modName.workshop.json", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-126);
		}
		return BJFKDHHMLJH;
	}

	private void MFBCLNAHEFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IGPCNCJIEOJ()
	{
		FPHEBLMINDA = Resources.Load(".") as Texture2D;
		SCShader = Shader.Find("_BlurVector");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JHPOIOELNCG()
	{
	}

	private void IBPAMDEAGJL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material BFGNMFCNDBC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.None;
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

	private void PKGJJFIFLII()
	{
	}

	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 833f)
			{
				HBJJOCHGOPH = 290f;
			}
			HJGEHJDMCGI().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("_History1LumaTex", UseFinalGlassColor);
			IIJMIPBMMBF().SetFloat("menu.playedpage", Fade);
			OKJOKHGJHGF().SetFloat("CameraFilterPack/Gradients_Therma", VisionBlur);
			MFHPKGICPIO().SetFloat("y", GlassDistortion);
			LPMLLJKMAMP().SetFloat("_ScreenResolution", GlassAberration);
			OGMEGHKECAH().SetColor("_Blend", GlassesColor);
			ELBMIEOIABA().SetColor("z", GlassesColor2);
			KLKILLCHJHO().SetColor("[", GlassColor);
			ADAFMBOGPLN().SetFloat("settings.arcshitsoundtimedelay", UseScanLineSize);
			BFGNMFCNDBC().SetFloat("_ScreenResolution", UseScanLine);
			ELBMIEOIABA().SetTexture("Submition failed", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1057f)
			{
				HBJJOCHGOPH = 670f;
			}
			OJMHIMIPKME().SetFloat(" SecondsBeforeRespawn: ", HBJJOCHGOPH);
			LMLENGFLEBD().SetFloat("_MainTex2", UseFinalGlassColor);
			OJMHIMIPKME().SetFloat("ticket", Fade);
			EFMCNLELMDO().SetFloat("_Value4", VisionBlur);
			LMLENGFLEBD().SetFloat("Joined Room. isMasterClient: ", GlassDistortion);
			OJMHIMIPKME().SetFloat("_TimeX", GlassAberration);
			NBPKMLMCHFN.SetColor("_Value4", GlassesColor);
			IIJMIPBMMBF().SetColor("_TimeX", GlassesColor2);
			FAIFBBGFAIB().SetColor("BadgeText", GlassColor);
			ADGHJOHKEHG().SetFloat("Triangle", UseScanLineSize);
			NBPKMLMCHFN.SetFloat("maps.", UseScanLine);
			HJGEHJDMCGI().SetTexture("Folk", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NEKCPLGFOFD()
	{
	}

	private void KLOLKEBAPFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BMODOIJGIOO()
	{
	}

	[SpecialName]
	private Material ELBMIEOIABA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 16f)
			{
				HBJJOCHGOPH = 1225f;
			}
			LPMLLJKMAMP().SetFloat("Using WebSocket to connect NameServer (AuthMode is AuthOnceWss).", HBJJOCHGOPH);
			OKJOKHGJHGF().SetFloat("_VignettingColor", UseFinalGlassColor);
			LPPEPKGFOEM().SetFloat("0", Fade);
			LPPEPKGFOEM().SetFloat("/Segment-[Up]", VisionBlur);
			LMLENGFLEBD().SetFloat("Result for ", GlassDistortion);
			ADGHJOHKEHG().SetFloat("restrictions\n\n#until: ", GlassAberration);
			ADAFMBOGPLN().SetColor("CameraFilterPack/Distortion_Wave_Horizontal", GlassesColor);
			ELBMIEOIABA().SetColor("steamid", GlassesColor2);
			OJMHIMIPKME().SetColor("couldn't be found!", GlassColor);
			OJMHIMIPKME().SetFloat("InventoryButton", UseScanLineSize);
			IONHGBPGCHK().SetFloat("settings.fps", UseScanLine);
			KLKILLCHJHO().SetTexture("_TimeX", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFMCNLELMDO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BMGPBIBPBLA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ABIOAMNCEOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1557f)
			{
				HBJJOCHGOPH = 579f;
			}
			NBPKMLMCHFN.SetFloat("_PositionY", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("_TimeX", UseFinalGlassColor);
			OKJOKHGJHGF().SetFloat("value", Fade);
			IIJMIPBMMBF().SetFloat("[Left]", VisionBlur);
			ELBMIEOIABA().SetFloat("CheckCombo", GlassDistortion);
			LPPEPKGFOEM().SetFloat(":\n", GlassAberration);
			EFMCNLELMDO().SetColor("maps.", GlassesColor);
			LMLENGFLEBD().SetColor("_Value", GlassesColor2);
			IIJMIPBMMBF().SetColor("#alreadyexist", GlassColor);
			NBPKMLMCHFN.SetFloat("InfoCanvas", UseScanLineSize);
			LPPEPKGFOEM().SetFloat("CameraFilterPack/Gradients_NeonGradient", UseScanLine);
			OGMEGHKECAH().SetTexture("SetPosition", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LLJLDLLNFBH()
	{
	}

	private void MDNHCLKNCLE()
	{
		FPHEBLMINDA = Resources.Load("#no") as Texture2D;
		SCShader = Shader.Find("Run a command for the Localization Servise");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KDMKDEKCELE()
	{
		FPHEBLMINDA = Resources.Load("USE_UV_BASED_REPROJECTION") as Texture2D;
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CACCPBENDAP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1157f)
			{
				HBJJOCHGOPH = 1289f;
			}
			IIJMIPBMMBF().SetFloat("_Value2", HBJJOCHGOPH);
			EFMCNLELMDO().SetFloat(".lastCheckpoint.time", UseFinalGlassColor);
			FAIFBBGFAIB().SetFloat(".wav", Fade);
			LMLENGFLEBD().SetFloat("_TimeX", VisionBlur);
			OKJOKHGJHGF().SetFloat("_Value6", GlassDistortion);
			FAIFBBGFAIB().SetFloat("_TimeX", GlassAberration);
			OJMHIMIPKME().SetColor("1427616858", GlassesColor);
			ADAFMBOGPLN().SetColor("[DiscordController] Init", GlassesColor2);
			BFGNMFCNDBC().SetColor("DISTORT", GlassColor);
			ELBMIEOIABA().SetFloat("_Offsets", UseScanLineSize);
			OKJOKHGJHGF().SetFloat("ItemNameText", UseScanLine);
			MFHPKGICPIO().SetTexture(":\n", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GENCBNFIILN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1241f)
			{
				HBJJOCHGOPH = 1579f;
			}
			LMLENGFLEBD().SetFloat("_VignettingColor", HBJJOCHGOPH);
			LPMLLJKMAMP().SetFloat("_Distortion", UseFinalGlassColor);
			IIJMIPBMMBF().SetFloat("menu.relaxinfo", Fade);
			LMLENGFLEBD().SetFloat("Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(", VisionBlur);
			ADGHJOHKEHG().SetFloat(". Check if the server is available.", GlassDistortion);
			PLBEJJIHFPB().SetFloat("_Distortion", GlassAberration);
			ADGHJOHKEHG().SetColor("ViewMenu", GlassesColor);
			KLKILLCHJHO().SetColor("restrictions\n\n#until: ", GlassesColor2);
			OJMHIMIPKME().SetColor("error", GlassColor);
			OGMEGHKECAH().SetFloat(" but this PhotonView does not exist! View was/is ours.", UseScanLineSize);
			ELBMIEOIABA().SetFloat("_Threshhold", UseScanLine);
			KLKILLCHJHO().SetTexture("SetParticlesParticleSize", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HJGEHJDMCGI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 38f)
			{
				HBJJOCHGOPH = 440f;
			}
			IONHGBPGCHK().SetFloat("resetall", HBJJOCHGOPH);
			ADGHJOHKEHG().SetFloat("offsets", UseFinalGlassColor);
			LPPEPKGFOEM().SetFloat("<color=#", Fade);
			OKJOKHGJHGF().SetFloat("status", VisionBlur);
			IIJMIPBMMBF().SetFloat("Vertical", GlassDistortion);
			NBPKMLMCHFN.SetFloat(". Going to ignore! Check PhotonServerSettings.RpcList", GlassAberration);
			ADAFMBOGPLN().SetColor("_Min", GlassesColor);
			LMLENGFLEBD().SetColor("offsets", GlassesColor2);
			ADGHJOHKEHG().SetColor("_Value7", GlassColor);
			OGMEGHKECAH().SetFloat("_TimeX", UseScanLineSize);
			ELBMIEOIABA().SetFloat("_Value3", UseScanLine);
			EFMCNLELMDO().SetTexture("UseFinalGlassColor", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPPEPKGFOEM());
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
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void IBFJAOINHMK()
	{
	}

	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 183f)
			{
				HBJJOCHGOPH = 384f;
			}
			PLBEJJIHFPB().SetFloat("settings.arcsnohitsoundtimedelay", HBJJOCHGOPH);
			KLKILLCHJHO().SetFloat("_Offsets", UseFinalGlassColor);
			LPMLLJKMAMP().SetFloat("_LutTex", Fade);
			OGMEGHKECAH().SetFloat(" isInactive: ", VisionBlur);
			LPMLLJKMAMP().SetFloat("B:", GlassDistortion);
			PLBEJJIHFPB().SetFloat("_EdgeSize", GlassAberration);
			MFHPKGICPIO().SetColor("ready", GlassesColor);
			EFMCNLELMDO().SetColor("error", GlassesColor2);
			IIJMIPBMMBF().SetColor("/?page=ranks", GlassColor);
			IIJMIPBMMBF().SetFloat("CameraFilterPack/Sharpen_Sharpen", UseScanLineSize);
			BFGNMFCNDBC().SetFloat("_Value", UseScanLine);
			OGMEGHKECAH().SetTexture("Tab1Content", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FIKNBPAIFBI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 707f)
			{
				HBJJOCHGOPH = 1352f;
			}
			OJMHIMIPKME().SetFloat("#useticket", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("CameraFilterPack/Blend2Camera_VividLight", UseFinalGlassColor);
			LPMLLJKMAMP().SetFloat("Set satellite clockwise rotattion speed", Fade);
			NBPKMLMCHFN.SetFloat("1.87", VisionBlur);
			KLKILLCHJHO().SetFloat("/Assets/MyImage", GlassDistortion);
			MFHPKGICPIO().SetFloat("(scene)", GlassAberration);
			BFGNMFCNDBC().SetColor("_BaseTex", GlassesColor);
			LPMLLJKMAMP().SetColor("PhotonServerSettings", GlassesColor2);
			MFHPKGICPIO().SetColor("G:", GlassColor);
			HJGEHJDMCGI().SetFloat("masterSteamID", UseScanLineSize);
			NBPKMLMCHFN.SetFloat("PLEASE WAIT", UseScanLine);
			NBPKMLMCHFN.SetTexture("Right", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1615f)
			{
				HBJJOCHGOPH = 9f;
			}
			MFHPKGICPIO().SetFloat("PhotonView with ID ", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("SetSunMinSize", UseFinalGlassColor);
			IIJMIPBMMBF().SetFloat("\0\0", Fade);
			KLKILLCHJHO().SetFloat("0.00", VisionBlur);
			IONHGBPGCHK().SetFloat("CameraFilterPack/Color_RGB", GlassDistortion);
			LPMLLJKMAMP().SetFloat("Error: PhotonNetwork.SetInterestGroups was called with an illegal group number: ", GlassAberration);
			OJMHIMIPKME().SetColor("_ScreenResolution", GlassesColor);
			OJMHIMIPKME().SetColor("_MainTex", GlassesColor2);
			OGMEGHKECAH().SetColor("_Value3", GlassColor);
			ELBMIEOIABA().SetFloat("_VelocityTex", UseScanLineSize);
			ELBMIEOIABA().SetFloat("fade in duration", UseScanLine);
			OJMHIMIPKME().SetTexture("SaveButton", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFMCNLELMDO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CNPINCHINJA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LBIOIEANMGI()
	{
	}

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1273f)
			{
				HBJJOCHGOPH = 729f;
			}
			OJMHIMIPKME().SetFloat("restrictions\n\n#until: ", HBJJOCHGOPH);
			ADGHJOHKEHG().SetFloat("#91CCFF", UseFinalGlassColor);
			IONHGBPGCHK().SetFloat("Status: ", Fade);
			ELBMIEOIABA().SetFloat("_ScreenResolution", VisionBlur);
			LPMLLJKMAMP().SetFloat("MapEnd", GlassDistortion);
			ADGHJOHKEHG().SetFloat("ItemsCountText", GlassAberration);
			LMLENGFLEBD().SetColor("WARNING: rotation axis set to 0 on ", GlassesColor);
			IONHGBPGCHK().SetColor("{0:0}", GlassesColor2);
			ELBMIEOIABA().SetColor("_ScreenResolution", GlassColor);
			LPPEPKGFOEM().SetFloat("Cross", UseScanLineSize);
			MFHPKGICPIO().SetFloat("ticket", UseScanLine);
			IONHGBPGCHK().SetTexture("PLEASE WAIT", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void KNBJBNDGCIJ()
	{
		FPHEBLMINDA = Resources.Load("skin.") as Texture2D;
		SCShader = Shader.Find("OpSetPropertiesOfActor not sent. ActorNr must be > 0 and actorProperties != null.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PAKPHKPDKGE()
	{
		FPHEBLMINDA = Resources.Load("bpmgrid") as Texture2D;
		SCShader = Shader.Find("_DX11NoiseTime");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BGDONBMDPGM()
	{
	}

	private void MJEFMIPLFAB()
	{
		FPHEBLMINDA = Resources.Load("player.blackcat") as Texture2D;
		SCShader = Shader.Find("offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KCNIHHNMFFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 523f)
			{
				HBJJOCHGOPH = 143f;
			}
			BFGNMFCNDBC().SetFloat("offsets", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat(" has no method \"", UseFinalGlassColor);
			LPMLLJKMAMP().SetFloat("IntraTime", Fade);
			OKJOKHGJHGF().SetFloat("_Value3", VisionBlur);
			NBPKMLMCHFN.SetFloat("grid", GlassDistortion);
			BFGNMFCNDBC().SetFloat("settings.enableranking", GlassAberration);
			PLBEJJIHFPB().SetColor("[NetworkMenu] Joining ", GlassesColor);
			BFGNMFCNDBC().SetColor("CameraFilterPack/Drawing_Paper2", GlassesColor2);
			LPPEPKGFOEM().SetColor("Set Sun MaxSize", GlassColor);
			ADAFMBOGPLN().SetFloat("maps.", UseScanLineSize);
			IONHGBPGCHK().SetFloat("Attempting to remove texture that was not allocated: {0}", UseScanLine);
			OGMEGHKECAH().SetTexture("_TimeX", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPPEPKGFOEM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void COOHIILCOCO()
	{
		FPHEBLMINDA = Resources.Load("_Bloom2") as Texture2D;
		SCShader = Shader.Find("Data/Editor/leveltemplate");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NFEDLAOPHML()
	{
	}

	private void BNLENEDAHHL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material FAIFBBGFAIB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
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

	[SpecialName]
	private Material ADAFMBOGPLN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)83;
		}
		return BJFKDHHMLJH;
	}

	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1473f)
			{
				HBJJOCHGOPH = 526f;
			}
			KLKILLCHJHO().SetFloat("(\\[ */ *b *\\])", HBJJOCHGOPH);
			ADGHJOHKEHG().SetFloat("checkpoint", UseFinalGlassColor);
			NBPKMLMCHFN.SetFloat("New SaveGame", Fade);
			PLBEJJIHFPB().SetFloat(": ", VisionBlur);
			BFGNMFCNDBC().SetFloat("Joystick1Button2", GlassDistortion);
			MFHPKGICPIO().SetFloat("0,1,true,0", GlassAberration);
			IONHGBPGCHK().SetColor("PunSupportLogger", GlassesColor);
			FAIFBBGFAIB().SetColor(".lastCheckpoint.correctScore", GlassesColor2);
			ADGHJOHKEHG().SetColor("CameraFilterPack/Sharpen_Sharpen", GlassColor);
			ELBMIEOIABA().SetFloat("score", UseScanLineSize);
			HJGEHJDMCGI().SetFloat(".", UseScanLine);
			IIJMIPBMMBF().SetTexture("deletemap", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OJMHIMIPKME());
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

	[SpecialName]
	private Material LPMLLJKMAMP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable;
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

	private void DDBOODLPCAM()
	{
	}

	private void EHCGBJDFMHG()
	{
	}

	[SpecialName]
	private Material KLKILLCHJHO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 897f)
			{
				HBJJOCHGOPH = 943f;
			}
			ADGHJOHKEHG().SetFloat("SpawnObj", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("#mapalreadyexistupdate", UseFinalGlassColor);
			EFMCNLELMDO().SetFloat("visible", Fade);
			HJGEHJDMCGI().SetFloat("/", VisionBlur);
			HJGEHJDMCGI().SetFloat("_DistortionSize", GlassDistortion);
			IIJMIPBMMBF().SetFloat("_Value2", GlassAberration);
			OKJOKHGJHGF().SetColor("Set satellite radius (offset)", GlassesColor);
			ADAFMBOGPLN().SetColor("???", GlassesColor2);
			ADGHJOHKEHG().SetColor("{", GlassColor);
			LPPEPKGFOEM().SetFloat("_ScreenResolution", UseScanLineSize);
			IIJMIPBMMBF().SetFloat("_LensDirt", UseScanLine);
			MFHPKGICPIO().SetTexture("Loss ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
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
			if (HBJJOCHGOPH > 601f)
			{
				HBJJOCHGOPH = 1066f;
			}
			PLBEJJIHFPB().SetFloat("float,0", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("blue", UseFinalGlassColor);
			MFHPKGICPIO().SetFloat("_TimeX", Fade);
			FAIFBBGFAIB().SetFloat("Bad parameters for getbool! Use <key> <value>", VisionBlur);
			OJMHIMIPKME().SetFloat("_TimeX", GlassDistortion);
			NBPKMLMCHFN.SetFloat("float,0.5", GlassAberration);
			LPPEPKGFOEM().SetColor("_Alpha", GlassesColor);
			LPPEPKGFOEM().SetColor("_ScreenResolution", GlassesColor2);
			IIJMIPBMMBF().SetColor(". Should be just one?", GlassColor);
			ADGHJOHKEHG().SetFloat(". Calling ConnectToRegionMaster() is: ", UseScanLineSize);
			ELBMIEOIABA().SetFloat("Joystick1Button6", UseScanLine);
			OJMHIMIPKME().SetTexture("hardcoreinfo", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material MFHPKGICPIO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void DPFOEBCADNP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material PLBEJJIHFPB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void MJNPIDGNJMK()
	{
	}

	private void NDDNJNCINDA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 813f)
			{
				HBJJOCHGOPH = 373f;
			}
			OGMEGHKECAH().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			KLKILLCHJHO().SetFloat("_ScreenResolution", UseFinalGlassColor);
			FAIFBBGFAIB().SetFloat("CameraFilterPack/Blend2Camera_SoftLight", Fade);
			EFMCNLELMDO().SetFloat("PenaltyScoreText", VisionBlur);
			PLBEJJIHFPB().SetFloat("bool", GlassDistortion);
			PLBEJJIHFPB().SetFloat("_Value", GlassAberration);
			LMLENGFLEBD().SetColor("[PlayerController] ", GlassesColor);
			LPMLLJKMAMP().SetColor("IconImage", GlassesColor2);
			ELBMIEOIABA().SetColor("_TimeX", GlassColor);
			MFHPKGICPIO().SetFloat("Beat Detected", UseScanLineSize);
			BFGNMFCNDBC().SetFloat("_PColor2", UseScanLine);
			MFHPKGICPIO().SetTexture("Left Stick Click", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
