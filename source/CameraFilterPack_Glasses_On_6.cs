// CameraFilterPack_Glasses_On_6
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Glasses/Spy")]
[ExecuteInEditMode]
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
			LPPEPKGFOEM().SetFloat("Connecting to server", HBJJOCHGOPH);
			ELBMIEOIABA().SetFloat("plogs", UseFinalGlassColor);
			PLBEJJIHFPB().SetFloat(" beatThreshold: ", Fade);
			LPMLLJKMAMP().SetFloat("Joystick1Button9", VisionBlur);
			EFMCNLELMDO().SetFloat(".icon", GlassDistortion);
			IONHGBPGCHK().SetFloat("Creating new item...", GlassAberration);
			EFMCNLELMDO().SetColor("CameraFilterPack/EyesVision_2", GlassesColor);
			PLBEJJIHFPB().SetColor("/Segment-[Left]", GlassesColor2);
			LPMLLJKMAMP().SetColor("_Blue_B", GlassColor);
			HJGEHJDMCGI().SetFloat("_HitPointTexture", UseScanLineSize);
			IIJMIPBMMBF().SetFloat("_Lift", UseScanLine);
			EFMCNLELMDO().SetTexture(".played", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
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
			OGMEGHKECAH().SetFloat(" canvas not found", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("Clears all text from the debug console", UseFinalGlassColor);
			ELBMIEOIABA().SetFloat("_Value4", Fade);
			OKJOKHGJHGF().SetFloat("_BlurRadius4", VisionBlur);
			LPMLLJKMAMP().SetFloat("_Distortion", GlassDistortion);
			HJGEHJDMCGI().SetFloat("challenges.", GlassAberration);
			EFMCNLELMDO().SetColor("No Description", GlassesColor);
			IONHGBPGCHK().SetColor("_Value7", GlassesColor2);
			OJMHIMIPKME().SetColor("ItemsCountText", GlassColor);
			OKJOKHGJHGF().SetFloat("OK", UseScanLineSize);
			OGMEGHKECAH().SetFloat("ConnectUsingSettings() failed. Can only connect while in state 'Disconnected'. Current state: ", UseScanLine);
			OGMEGHKECAH().SetTexture(" not exist", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFMCNLELMDO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JONGNKNLLND()
	{
		FPHEBLMINDA = Resources.Load("_ThirdTex") as Texture2D;
		SCShader = Shader.Find("value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DBEMDAJDDDA()
	{
		FPHEBLMINDA = Resources.Load("set environment id") as Texture2D;
		SCShader = Shader.Find("[PlayerController] ");
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
			IIJMIPBMMBF().SetFloat("_PColor2", HBJJOCHGOPH);
			KLKILLCHJHO().SetFloat(" has been disabled as it's not supported on the current platform.", UseFinalGlassColor);
			OGMEGHKECAH().SetFloat("LevelNameInputField", Fade);
			LMLENGFLEBD().SetFloat("maps.", VisionBlur);
			IIJMIPBMMBF().SetFloat("_Value3", GlassDistortion);
			LMLENGFLEBD().SetFloat("CameraFilterPack/Blend2Camera_Multiply", GlassAberration);
			ELBMIEOIABA().SetColor("_Value2", GlassesColor);
			BFGNMFCNDBC().SetColor(": ", GlassesColor2);
			OKJOKHGJHGF().SetColor("Object ID. Case-Sensitive", GlassColor);
			BFGNMFCNDBC().SetFloat("Mouse1", UseScanLineSize);
			NBPKMLMCHFN.SetFloat("Joystick1Button6", UseScanLine);
			ELBMIEOIABA().SetTexture("_Offsets", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB());
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
			ADAFMBOGPLN().SetFloat(":", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("CameraFilterPack/Blend2Camera_HardLight", UseFinalGlassColor);
			OKJOKHGJHGF().SetFloat(" is muted", Fade);
			NBPKMLMCHFN.SetFloat("offsets", VisionBlur);
			LPPEPKGFOEM().SetFloat("{0:0} hour{1}, ", GlassDistortion);
			EFMCNLELMDO().SetFloat("CameraFilterPack/Blur_Blurry", GlassAberration);
			IIJMIPBMMBF().SetColor("0", GlassesColor);
			LMLENGFLEBD().SetColor("<b>Kick player by NetID</b>\nuse: /kick {NetID}\nUse \"/players\" command to get all NetIDs\nRoom owner only can kick the players", GlassesColor2);
			BFGNMFCNDBC().SetColor("Editor/", GlassColor);
			LPMLLJKMAMP().SetFloat("#done", UseScanLineSize);
			NBPKMLMCHFN.SetFloat("_Bloom2", UseScanLine);
			BFGNMFCNDBC().SetTexture("[LevelEditorScene] Print Audio Wave: Done", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ELBMIEOIABA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KIMMMCJFMAB()
	{
		FPHEBLMINDA = Resources.Load("Currently, the limit of users is reached for this title. Try again later. Disconnecting") as Texture2D;
		SCShader = Shader.Find("EndlessLoopsScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FNCDAPDOBBI()
	{
		FPHEBLMINDA = Resources.Load("VIGNETTE_FILMIC") as Texture2D;
		SCShader = Shader.Find(" not exist");
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
			LPMLLJKMAMP().SetFloat("Set Satellite Trail Width", HBJJOCHGOPH);
			LPPEPKGFOEM().SetFloat("_Amount", UseFinalGlassColor);
			FAIFBBGFAIB().SetFloat("y", Fade);
			IONHGBPGCHK().SetFloat("SetupEncryption() got called. ", VisionBlur);
			LPMLLJKMAMP().SetFloat("settings_bindings_", GlassDistortion);
			PLBEJJIHFPB().SetFloat("MapEditor v.", GlassAberration);
			IONHGBPGCHK().SetColor("maphash", GlassesColor);
			NBPKMLMCHFN.SetColor("_Value6", GlassesColor2);
			EFMCNLELMDO().SetColor("The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.", GlassColor);
			KLKILLCHJHO().SetFloat(".", UseScanLineSize);
			LPMLLJKMAMP().SetFloat("GlassesColor2", UseScanLine);
			FAIFBBGFAIB().SetTexture("MultiplayerButton", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF());
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
			BFGNMFCNDBC().SetFloat("Exit to Windows", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("UI Extensions/UILinearDodge", UseFinalGlassColor);
			FAIFBBGFAIB().SetFloat("_Value", Fade);
			OJMHIMIPKME().SetFloat("end", VisionBlur);
			ELBMIEOIABA().SetFloat("_Value4", GlassDistortion);
			FAIFBBGFAIB().SetFloat("maps.", GlassAberration);
			ADAFMBOGPLN().SetColor(" Remote called.", GlassesColor);
			LPPEPKGFOEM().SetColor("[NetworkManager] Connected to ", GlassesColor2);
			OJMHIMIPKME().SetColor("CameraFilterPack/Blend2Camera_LighterColor", GlassColor);
			OGMEGHKECAH().SetFloat("Reset XP", UseScanLineSize);
			ADAFMBOGPLN().SetFloat("CheckpointsScoreText", UseScanLine);
			KLKILLCHJHO().SetTexture(" beatThreshold: ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NKFDNIAKGEO()
	{
		FPHEBLMINDA = Resources.Load("Delete events") as Texture2D;
		SCShader = Shader.Find("Authentication failed: '{0}' Code: {1}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ANCKKLFPGDI()
	{
		FPHEBLMINDA = Resources.Load("Data") as Texture2D;
		SCShader = Shader.Find("_Offsets");
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
			NBPKMLMCHFN.SetFloat("_Value4", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("settings_bindings_", UseFinalGlassColor);
			OGMEGHKECAH().SetFloat(".", Fade);
			IIJMIPBMMBF().SetFloat("New level loaded. Removed ", VisionBlur);
			ELBMIEOIABA().SetFloat("Cancel", GlassDistortion);
			IONHGBPGCHK().SetFloat("rd", GlassAberration);
			ELBMIEOIABA().SetColor("CameraFilterPack/Distortion_Lens", GlassesColor);
			KLKILLCHJHO().SetColor("skin.hit_normal", GlassesColor2);
			ADGHJOHKEHG().SetColor("Connected to gameserver.", GlassColor);
			ADAFMBOGPLN().SetFloat("DPADVER", UseScanLineSize);
			PLBEJJIHFPB().SetFloat("cipherText", UseScanLine);
			NBPKMLMCHFN.SetTexture("Sending RPC \"", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KLKILLCHJHO());
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
		FPHEBLMINDA = Resources.Load(">") as Texture2D;
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
			EFMCNLELMDO().SetFloat("_Value", HBJJOCHGOPH);
			OJMHIMIPKME().SetFloat("BadgeText", UseFinalGlassColor);
			HJGEHJDMCGI().SetFloat("SpawnObj", Fade);
			ELBMIEOIABA().SetFloat("HitVariationSlider", VisionBlur);
			OGMEGHKECAH().SetFloat("_Visualize", GlassDistortion);
			LMLENGFLEBD().SetFloat("_MainTex2", GlassAberration);
			ELBMIEOIABA().SetColor("_Green_B", GlassesColor);
			IIJMIPBMMBF().SetColor("_ScreenResolution", GlassesColor2);
			IONHGBPGCHK().SetColor(" not found", GlassColor);
			KLKILLCHJHO().SetFloat("_EmissionColor", UseScanLineSize);
			ADGHJOHKEHG().SetFloat("Loading", UseScanLine);
			PLBEJJIHFPB().SetTexture("_Value5", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HAIAHJPCPAG()
	{
		FPHEBLMINDA = Resources.Load("_Bullet_12") as Texture2D;
		SCShader = Shader.Find("_TimeX");
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
			MFHPKGICPIO().SetFloat("[ResourcesManager] Load image error: ", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("menu.enableselectormusic", UseFinalGlassColor);
			LMLENGFLEBD().SetFloat("settings.enablerankingnotifications", Fade);
			NBPKMLMCHFN.SetFloat("_Fade", VisionBlur);
			ADGHJOHKEHG().SetFloat("ConfigVersionSlider", GlassDistortion);
			BFGNMFCNDBC().SetFloat("Offline or in OfflineMode. No VitalStats available.", GlassAberration);
			ELBMIEOIABA().SetColor("_History4LumaTex", GlassesColor);
			LPPEPKGFOEM().SetColor("_NoiseTex", GlassesColor2);
			OGMEGHKECAH().SetColor("1159514800", GlassColor);
			ADAFMBOGPLN().SetFloat("float,0", UseScanLineSize);
			ELBMIEOIABA().SetFloat("CameraFilterPack/Distortion_Wave_Horizontal", UseScanLine);
			OKJOKHGJHGF().SetTexture("LevelInfoInputField", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KLKILLCHJHO());
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
		FPHEBLMINDA = Resources.Load("[Down]") as Texture2D;
		SCShader = Shader.Find("/icon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CCLNNLCOPBL()
	{
		FPHEBLMINDA = Resources.Load("_TimeX") as Texture2D;
		SCShader = Shader.Find("Have you fully accept the terms?");
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
		FPHEBLMINDA = Resources.Load("Waiting to start") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/TV_WideScreenVertical");
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
			PLBEJJIHFPB().SetFloat("_TimeX", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("CameraFilterPack_TV_Noise2", UseFinalGlassColor);
			IIJMIPBMMBF().SetFloat("_History3Weight", Fade);
			LPMLLJKMAMP().SetFloat("value", VisionBlur);
			ADAFMBOGPLN().SetFloat("...", GlassDistortion);
			LPPEPKGFOEM().SetFloat(" not exist", GlassAberration);
			OGMEGHKECAH().SetColor("maps.", GlassesColor);
			HJGEHJDMCGI().SetColor(" does not exist!", GlassesColor2);
			PLBEJJIHFPB().SetColor("CameraFilterPack_VHS2", GlassColor);
			EFMCNLELMDO().SetFloat("Object ID. Case-Sensitive", UseScanLineSize);
			FAIFBBGFAIB().SetFloat("CameraFilterPack/Noise_TV", UseScanLine);
			ELBMIEOIABA().SetTexture(" ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			EFMCNLELMDO().SetFloat("_VignetteSettings", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("MainThreadExecuter", UseFinalGlassColor);
			HJGEHJDMCGI().SetFloat(" not found", Fade);
			IIJMIPBMMBF().SetFloat("BadgeImage", VisionBlur);
			ADAFMBOGPLN().SetFloat("_Speed", GlassDistortion);
			ADGHJOHKEHG().SetFloat("id", GlassAberration);
			IIJMIPBMMBF().SetColor("value", GlassesColor);
			HJGEHJDMCGI().SetColor("_TimeX", GlassesColor2);
			EFMCNLELMDO().SetColor("CameraFilterPack/TV_Video3D", GlassColor);
			IIJMIPBMMBF().SetFloat("CameraFilterPack/FX_Scan", UseScanLineSize);
			LMLENGFLEBD().SetFloat("PhotonNetwork.room is null. You don't have to call LeaveRoom() when you're not in one. State: ", UseScanLine);
			BFGNMFCNDBC().SetTexture("_ScreenResolution", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OJMHIMIPKME());
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
		SCShader = Shader.Find("SpawnObj");
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
		SCShader = Shader.Find("settings.arcshitsoundtimedelay");
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
			LMLENGFLEBD().SetFloat("ItemTemplate", HBJJOCHGOPH);
			ELBMIEOIABA().SetFloat("Set satellite audio input", UseFinalGlassColor);
			OKJOKHGJHGF().SetFloat("_ScreenResolution", Fade);
			IIJMIPBMMBF().SetFloat("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", VisionBlur);
			HJGEHJDMCGI().SetFloat("RarityImage", GlassDistortion);
			LPMLLJKMAMP().SetFloat("ExitButton", GlassAberration);
			BFGNMFCNDBC().SetColor("Alpha", GlassesColor);
			LPMLLJKMAMP().SetColor("/", GlassesColor2);
			IIJMIPBMMBF().SetColor("maps.", GlassColor);
			OGMEGHKECAH().SetFloat("settings.enablerankingnotifications", UseScanLineSize);
			HJGEHJDMCGI().SetFloat("_TimeX", UseScanLine);
			PLBEJJIHFPB().SetTexture("[EMPTY]", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KLKILLCHJHO());
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
			OKJOKHGJHGF().SetFloat("menu.tabid", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", UseFinalGlassColor);
			BFGNMFCNDBC().SetFloat("0", Fade);
			ADGHJOHKEHG().SetFloat("_Near", VisionBlur);
			ADAFMBOGPLN().SetFloat("Data/Skins/", GlassDistortion);
			MFHPKGICPIO().SetFloat("_Offsets", GlassAberration);
			ADAFMBOGPLN().SetColor("_Size", GlassesColor);
			ADAFMBOGPLN().SetColor("\0\0", GlassesColor2);
			HJGEHJDMCGI().SetColor("BitsData", GlassColor);
			ADAFMBOGPLN().SetFloat("_ScreenResolution", UseScanLineSize);
			LMLENGFLEBD().SetFloat("_Value1", UseScanLine);
			OKJOKHGJHGF().SetTexture("_GrainOffsetScale", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DPLLKHHLDBB()
	{
		FPHEBLMINDA = Resources.Load("Editor/") as Texture2D;
		SCShader = Shader.Find("Start index must in an integer.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IDJKNBDKHBD()
	{
		FPHEBLMINDA = Resources.Load("_Distortion") as Texture2D;
		SCShader = Shader.Find("Reset XP");
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
			EFMCNLELMDO().SetFloat("bad", HBJJOCHGOPH);
			EFMCNLELMDO().SetFloat("maps.", UseFinalGlassColor);
			OGMEGHKECAH().SetFloat("Keypad ", Fade);
			KLKILLCHJHO().SetFloat("Created", VisionBlur);
			NBPKMLMCHFN.SetFloat("_Value4", GlassDistortion);
			IONHGBPGCHK().SetFloat("DPADHOR", GlassAberration);
			LPPEPKGFOEM().SetColor("_ColorR", GlassesColor);
			FAIFBBGFAIB().SetColor("_Value2", GlassesColor2);
			LPMLLJKMAMP().SetColor("menutheme.coldheat", GlassColor);
			IONHGBPGCHK().SetFloat("SetTrailZoomSpeed", UseScanLineSize);
			LMLENGFLEBD().SetFloat("caret", UseScanLine);
			HJGEHJDMCGI().SetTexture("_BlurArea", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BMOFEBKGLFI()
	{
		FPHEBLMINDA = Resources.Load("Traffic Stats") as Texture2D;
		SCShader = Shader.Find(" By: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DKOPKPBLDHH()
	{
		FPHEBLMINDA = Resources.Load("CONTRAST") as Texture2D;
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
			FAIFBBGFAIB().SetFloat("_SecondTex", HBJJOCHGOPH);
			HJGEHJDMCGI().SetFloat("DataText", UseFinalGlassColor);
			NBPKMLMCHFN.SetFloat("Image effects aren't supported on this device ({0})", Fade);
			OJMHIMIPKME().SetFloat("#FFDA44CC", VisionBlur);
			LMLENGFLEBD().SetFloat("_TimeX", GlassDistortion);
			EFMCNLELMDO().SetFloat("_Green_R", GlassAberration);
			LMLENGFLEBD().SetColor(" This is not possible to be called for standalone input. Please check your platform and code where this is called", GlassesColor);
			FAIFBBGFAIB().SetColor("_FarCamera", GlassesColor2);
			HJGEHJDMCGI().SetColor("Player Connected", GlassColor);
			ADAFMBOGPLN().SetFloat("CameraFilterPack/Blend2Camera_Darken", UseScanLineSize);
			LMLENGFLEBD().SetFloat("_Blood", UseScanLine);
			ADAFMBOGPLN().SetTexture("open", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			LPMLLJKMAMP().SetFloat("[DiscordController] Responding yes to Ask to Join request", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("_Value3", UseFinalGlassColor);
			OKJOKHGJHGF().SetFloat("CameraFilterPack/Blur_Focus", Fade);
			EFMCNLELMDO().SetFloat("R:", VisionBlur);
			OJMHIMIPKME().SetFloat("_TimeX", GlassDistortion);
			MFHPKGICPIO().SetFloat("outputitemdefid", GlassAberration);
			OGMEGHKECAH().SetColor("_Value", GlassesColor);
			OGMEGHKECAH().SetColor("#{0:00} '{1}'{2} {3}", GlassesColor2);
			LPMLLJKMAMP().SetColor("_Value7", GlassColor);
			HJGEHJDMCGI().SetFloat("true", UseScanLineSize);
			OGMEGHKECAH().SetFloat("#tryagain", UseScanLine);
			NBPKMLMCHFN.SetTexture("_Offsets", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ELBMIEOIABA());
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
			OKJOKHGJHGF().SetFloat("Fade", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("player.mysteryitem", UseFinalGlassColor);
			HJGEHJDMCGI().SetFloat("ViewID {0} {1}{2}", Fade);
			LPMLLJKMAMP().SetFloat("_DotSize", VisionBlur);
			ADGHJOHKEHG().SetFloat("_Value4", GlassDistortion);
			IONHGBPGCHK().SetFloat("CameraFilterPack/OldFilm_Cutting2", GlassAberration);
			OKJOKHGJHGF().SetColor("Set satellite emission (glow)", GlassesColor);
			MFHPKGICPIO().SetColor("Out {0,4} | In {1,4} | Sum {2,4}", GlassesColor2);
			LPPEPKGFOEM().SetColor("LoadMapCanvas", GlassColor);
			HJGEHJDMCGI().SetFloat("_TimeX", UseScanLineSize);
			OKJOKHGJHGF().SetFloat("_MainTex", UseScanLine);
			IIJMIPBMMBF().SetTexture("ERROR: Preview file must be <1MB!", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPPEPKGFOEM());
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
		FPHEBLMINDA = Resources.Load(".workshop.json") as Texture2D;
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
			EFMCNLELMDO().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			HJGEHJDMCGI().SetFloat("_VelocityTex", UseFinalGlassColor);
			BFGNMFCNDBC().SetFloat("menu.playedpage", Fade);
			BFGNMFCNDBC().SetFloat("_ScreenResolution", VisionBlur);
			HJGEHJDMCGI().SetFloat("z", GlassDistortion);
			PLBEJJIHFPB().SetFloat("_ScreenResolution", GlassAberration);
			LMLENGFLEBD().SetColor("_LutTex", GlassesColor);
			PLBEJJIHFPB().SetColor("float,1", GlassesColor2);
			OKJOKHGJHGF().SetColor("[", GlassColor);
			EFMCNLELMDO().SetFloat("settings.arcsnohitsoundtimedelay", UseScanLineSize);
			ADAFMBOGPLN().SetFloat("_Value", UseScanLine);
			BFGNMFCNDBC().SetTexture("PLEASE WAIT", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HJGEHJDMCGI());
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
			HJGEHJDMCGI().SetFloat("PickupItemInit", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("_MainTex2", UseFinalGlassColor);
			HJGEHJDMCGI().SetFloat("challenges.", Fade);
			NBPKMLMCHFN.SetFloat("_Value3", VisionBlur);
			OKJOKHGJHGF().SetFloat("Ignored PU RPC, cause item is inactive. ", GlassDistortion);
			FAIFBBGFAIB().SetFloat("CameraFilterPack/Drawing_Paper3", GlassAberration);
			OGMEGHKECAH().SetColor("_Value3", GlassesColor);
			IIJMIPBMMBF().SetColor("CameraFilterPack/EXTRA_SHOWFPS", GlassesColor2);
			IONHGBPGCHK().SetColor("BadgeImage", GlassColor);
			LPPEPKGFOEM().SetFloat("Joystick1Button3", UseScanLineSize);
			IONHGBPGCHK().SetFloat(".completed", UseScanLine);
			OGMEGHKECAH().SetTexture("Electronic", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPPEPKGFOEM());
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
			BFGNMFCNDBC().SetFloat("ns", HBJJOCHGOPH);
			EFMCNLELMDO().SetFloat("_Vignetting2", UseFinalGlassColor);
			OGMEGHKECAH().SetFloat("0", Fade);
			PLBEJJIHFPB().SetFloat("[PlayerBase] Current attempt: ", VisionBlur);
			EFMCNLELMDO().SetFloat("Result for ", GlassDistortion);
			ADAFMBOGPLN().SetFloat("#forever", GlassAberration);
			HJGEHJDMCGI().SetColor("_NumberOfWaves", GlassesColor);
			FAIFBBGFAIB().SetColor("ticket", GlassesColor2);
			KLKILLCHJHO().SetColor("OnSerialize", GlassColor);
			ADGHJOHKEHG().SetFloat("InventoryButton", UseScanLineSize);
			LPPEPKGFOEM().SetFloat("settings.fps", UseScanLine);
			HJGEHJDMCGI().SetTexture("CameraFilterPack/FX_Hexagon", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OJMHIMIPKME());
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
			LPPEPKGFOEM().SetFloat("_PositionX", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("CameraFilterPack/Glasses_On", UseFinalGlassColor);
			PLBEJJIHFPB().SetFloat("Set Crosshair Emission", Fade);
			OGMEGHKECAH().SetFloat(",", VisionBlur);
			OGMEGHKECAH().SetFloat("[PlayerBase] Loaded music", GlassDistortion);
			KLKILLCHJHO().SetFloat("ItemNameText", GlassAberration);
			PLBEJJIHFPB().SetColor("maps.", GlassesColor);
			KLKILLCHJHO().SetColor("CameraFilterPack/TV_WideScreenVertical", GlassesColor2);
			ELBMIEOIABA().SetColor("LoadMapCanvas", GlassColor);
			OGMEGHKECAH().SetFloat("InfoText", UseScanLineSize);
			KLKILLCHJHO().SetFloat("_ScreenResolution", UseScanLine);
			IIJMIPBMMBF().SetTexture("SetTrailZoomSpeed", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
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
		FPHEBLMINDA = Resources.Load("#yes") as Texture2D;
		SCShader = Shader.Find("ls");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KDMKDEKCELE()
	{
		FPHEBLMINDA = Resources.Load("USE_CORNER_DETECTION") as Texture2D;
		SCShader = Shader.Find("_Value");
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
			IONHGBPGCHK().SetFloat("_Value", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("LostAllLives", UseFinalGlassColor);
			ADAFMBOGPLN().SetFloat(".ogg", Fade);
			MFHPKGICPIO().SetFloat("_TimeX", VisionBlur);
			NBPKMLMCHFN.SetFloat("_Value6", GlassDistortion);
			ADGHJOHKEHG().SetFloat("_ScreenResolution", GlassAberration);
			LMLENGFLEBD().SetColor("1234332714", GlassesColor);
			LPMLLJKMAMP().SetColor("[DiscordController] Sectate ({0})", GlassesColor2);
			OJMHIMIPKME().SetColor("_Luminance", GlassColor);
			LMLENGFLEBD().SetFloat("_Offsets", UseScanLineSize);
			OJMHIMIPKME().SetFloat("ItemsCountText", UseScanLine);
			HJGEHJDMCGI().SetTexture("ItemNameText", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
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
			LPPEPKGFOEM().SetFloat("_Vignetting", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Fade", UseFinalGlassColor);
			MFHPKGICPIO().SetFloat("menu.selectedplaymode", Fade);
			MFHPKGICPIO().SetFloat("Error: You're not logged into Steam!", VisionBlur);
			ADGHJOHKEHG().SetFloat(" while connecting to: ", GlassDistortion);
			IONHGBPGCHK().SetFloat("_TimeX", GlassAberration);
			NBPKMLMCHFN.SetColor("#mapnotloaded", GlassesColor);
			IONHGBPGCHK().SetColor("#forever", GlassesColor2);
			HJGEHJDMCGI().SetColor("#close", GlassColor);
			EFMCNLELMDO().SetFloat("Received RPC \"", UseScanLineSize);
			LMLENGFLEBD().SetFloat("_Offsets", UseScanLine);
			KLKILLCHJHO().SetTexture("SetParticlesParticleSize", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
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
			NBPKMLMCHFN.SetFloat(".status", HBJJOCHGOPH);
			EFMCNLELMDO().SetFloat("offsets", UseFinalGlassColor);
			KLKILLCHJHO().SetFloat("</color>", Fade);
			ADGHJOHKEHG().SetFloat("status", VisionBlur);
			KLKILLCHJHO().SetFloat("Vertical", GlassDistortion);
			LPPEPKGFOEM().SetFloat("Sending vacant view IDs. Length: ", GlassAberration);
			LPMLLJKMAMP().SetColor("UI Extensions/SoftMaskShaderText", GlassesColor);
			PLBEJJIHFPB().SetColor("No valid adaptive tonemapper type found!", GlassesColor2);
			MFHPKGICPIO().SetColor("_Value6", GlassColor);
			BFGNMFCNDBC().SetFloat("CameraFilterPack/Vision_AuraDistortion", UseScanLineSize);
			MFHPKGICPIO().SetFloat("_Value2", UseScanLine);
			ADAFMBOGPLN().SetTexture("UseFinalGlassColor", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
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
			OKJOKHGJHGF().SetFloat("settings.arcsdestroydelay", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("_BlurParams", UseFinalGlassColor);
			ADGHJOHKEHG().SetFloat("_Blend", Fade);
			KLKILLCHJHO().SetFloat("Received event Leave for unknown player ID: {0}", VisionBlur);
			OJMHIMIPKME().SetFloat("R:", GlassDistortion);
			ADAFMBOGPLN().SetFloat("_EdgeSize", GlassAberration);
			OJMHIMIPKME().SetColor("ready", GlassesColor);
			OKJOKHGJHGF().SetColor("#getrewardfailed: ", GlassesColor2);
			KLKILLCHJHO().SetColor("AVG Misses:", GlassColor);
			FAIFBBGFAIB().SetFloat("_ScreenResolution", UseScanLineSize);
			MFHPKGICPIO().SetFloat("_TimeX", UseScanLine);
			IIJMIPBMMBF().SetTexture("Tab1Content", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ELBMIEOIABA());
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
			KLKILLCHJHO().SetFloat("#failed: ", HBJJOCHGOPH);
			KLKILLCHJHO().SetFloat("CameraFilterPack/Blend2Camera_VividLight", UseFinalGlassColor);
			BFGNMFCNDBC().SetFloat("float,40", Fade);
			HJGEHJDMCGI().SetFloat("{0}{1}{2}={3}", VisionBlur);
			OJMHIMIPKME().SetFloat("bad", GlassDistortion);
			ELBMIEOIABA().SetFloat("View ({3}){0} on {1} {2}", GlassAberration);
			HJGEHJDMCGI().SetColor("_Intensity", GlassesColor);
			ADGHJOHKEHG().SetColor("Jit ", GlassesColor2);
			KLKILLCHJHO().SetColor("#", GlassColor);
			OKJOKHGJHGF().SetFloat("masterSteamID", UseScanLineSize);
			ADGHJOHKEHG().SetFloat("PLEASE WAIT", UseScanLine);
			ELBMIEOIABA().SetTexture("GameScene", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF());
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
			EFMCNLELMDO().SetFloat(", ", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("SetParent", UseFinalGlassColor);
			FAIFBBGFAIB().SetFloat("#no", Fade);
			NBPKMLMCHFN.SetFloat("LevelEditor/patterns", VisionBlur);
			KLKILLCHJHO().SetFloat("_ScreenResolution", GlassDistortion);
			OJMHIMIPKME().SetFloat("Error: PhotonNetwork.SetInterestGroups was called with an illegal group number: ", GlassAberration);
			FAIFBBGFAIB().SetColor("_Fade", GlassesColor);
			OGMEGHKECAH().SetColor("_InvRenderTargetSize", GlassesColor2);
			MFHPKGICPIO().SetColor("_Value2", GlassColor);
			OJMHIMIPKME().SetFloat("_MaxBlurRadius", UseScanLineSize);
			PLBEJJIHFPB().SetFloat("fade in duration", UseScanLine);
			OJMHIMIPKME().SetTexture("SaveButton", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KLKILLCHJHO());
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
			HJGEHJDMCGI().SetFloat("\n\n#", HBJJOCHGOPH);
			ADGHJOHKEHG().SetFloat("ItemNameText", UseFinalGlassColor);
			OKJOKHGJHGF().SetFloat("n/a", Fade);
			EFMCNLELMDO().SetFloat("_ScreenResolution", VisionBlur);
			LPPEPKGFOEM().SetFloat("MapEnd", GlassDistortion);
			HJGEHJDMCGI().SetFloat("x", GlassAberration);
			ADAFMBOGPLN().SetColor("WARNING: rotation axis set to 0 on ", GlassesColor);
			KLKILLCHJHO().SetColor("00", GlassesColor2);
			LMLENGFLEBD().SetColor("_Value4", GlassColor);
			PLBEJJIHFPB().SetFloat("Square", UseScanLineSize);
			ELBMIEOIABA().SetFloat("Subscribe: ", UseScanLine);
			IONHGBPGCHK().SetTexture("0.00", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB());
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
		FPHEBLMINDA = Resources.Load("http") as Texture2D;
		SCShader = Shader.Find("OpGetGameList not sent. LobbyType must be SqlLobby.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PAKPHKPDKGE()
	{
		FPHEBLMINDA = Resources.Load("EventData0DropDownList") as Texture2D;
		SCShader = Shader.Find("_AccumOrig");
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
		FPHEBLMINDA = Resources.Load("???") as Texture2D;
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
			LPPEPKGFOEM().SetFloat("_AdaptParams", HBJJOCHGOPH);
			ELBMIEOIABA().SetFloat("null", UseFinalGlassColor);
			IIJMIPBMMBF().SetFloat("IntraSig", Fade);
			OKJOKHGJHGF().SetFloat("_Value2", VisionBlur);
			ELBMIEOIABA().SetFloat("grid", GlassDistortion);
			IIJMIPBMMBF().SetFloat("HPToggle", GlassAberration);
			ADGHJOHKEHG().SetColor("Created by ", GlassesColor);
			OJMHIMIPKME().SetColor("CameraFilterPack_Paper3", GlassesColor2);
			LPPEPKGFOEM().SetColor("Set Sun MaxSize", GlassColor);
			LMLENGFLEBD().SetFloat("maps.", UseScanLineSize);
			OJMHIMIPKME().SetFloat("Floating point textures aren't supported on this device ({0})", UseScanLine);
			NBPKMLMCHFN.SetTexture("CameraFilterPack/FX_Scan", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void COOHIILCOCO()
	{
		FPHEBLMINDA = Resources.Load("_Bloom1") as Texture2D;
		SCShader = Shader.Find("Editor/");
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
			PLBEJJIHFPB().SetFloat("(\\[ */ *b *\\])", HBJJOCHGOPH);
			LPMLLJKMAMP().SetFloat("Added checkpoint", UseFinalGlassColor);
			KLKILLCHJHO().SetFloat("The other scroll rect doesnt support scrolling horizontally", Fade);
			NBPKMLMCHFN.SetFloat("[PlayerController] ", VisionBlur);
			IONHGBPGCHK().SetFloat("Joystick1Button1", GlassDistortion);
			ADAFMBOGPLN().SetFloat("0,1,true,0", GlassAberration);
			ADGHJOHKEHG().SetColor("Status: ", GlassesColor);
			LPMLLJKMAMP().SetColor(".lastCheckpoint.time", GlassesColor2);
			LPPEPKGFOEM().SetColor("_ScreenResolution", GlassColor);
			ADAFMBOGPLN().SetFloat("scene ", UseScanLineSize);
			IIJMIPBMMBF().SetFloat(".", UseScanLine);
			ADAFMBOGPLN().SetTexture("/", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPPEPKGFOEM());
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
			ADAFMBOGPLN().SetFloat("SpawnObj", HBJJOCHGOPH);
			ELBMIEOIABA().SetFloat("#no", UseFinalGlassColor);
			ADAFMBOGPLN().SetFloat("Can't set Room.MaxPlayers to: ", Fade);
			PLBEJJIHFPB().SetFloat("[MapsData] Installed: ", VisionBlur);
			IONHGBPGCHK().SetFloat("_DistortionSize", GlassDistortion);
			OKJOKHGJHGF().SetFloat("_Value", GlassAberration);
			IONHGBPGCHK().SetColor("float,2", GlassesColor);
			LPMLLJKMAMP().SetColor("CountEventsGoal", GlassesColor2);
			OGMEGHKECAH().SetColor("G:", GlassColor);
			PLBEJJIHFPB().SetFloat("_Value4", UseScanLineSize);
			PLBEJJIHFPB().SetFloat("_Bloom4", UseScanLine);
			OGMEGHKECAH().SetTexture("Lag ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
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
			LPPEPKGFOEM().SetFloat("float,0", HBJJOCHGOPH);
			HJGEHJDMCGI().SetFloat("violet", UseFinalGlassColor);
			ADAFMBOGPLN().SetFloat("_TimeX", Fade);
			FAIFBBGFAIB().SetFloat("getfloat", VisionBlur);
			PLBEJJIHFPB().SetFloat("CameraFilterPack/Blur_Radial_Fast", GlassDistortion);
			IONHGBPGCHK().SetFloat("seconds", GlassAberration);
			ADAFMBOGPLN().SetColor("_Alpha", GlassesColor);
			ELBMIEOIABA().SetColor("_Noise", GlassesColor2);
			LPMLLJKMAMP().SetColor("\" that takes ", GlassColor);
			KLKILLCHJHO().SetFloat("No regions available. Are you sure your appid is valid and setup?", UseScanLineSize);
			HJGEHJDMCGI().SetFloat("Joystick1Button5", UseScanLine);
			PLBEJJIHFPB().SetTexture("menu.hardcoreinfo", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFMCNLELMDO());
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
			OJMHIMIPKME().SetFloat("_Fade", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("_Fade", UseFinalGlassColor);
			BFGNMFCNDBC().SetFloat("CameraFilterPack/Blend2Camera_Overlay", Fade);
			OKJOKHGJHGF().SetFloat("PenaltyScoreText", VisionBlur);
			EFMCNLELMDO().SetFloat("maps.", GlassDistortion);
			HJGEHJDMCGI().SetFloat("_Value", GlassAberration);
			ADAFMBOGPLN().SetColor(" not exist", GlassesColor);
			ADGHJOHKEHG().SetColor("IconImage", GlassesColor2);
			IIJMIPBMMBF().SetColor("CameraFilterPack/FX_Grid", GlassColor);
			OKJOKHGJHGF().SetFloat("Beat Detected", UseScanLineSize);
			ADAFMBOGPLN().SetFloat("_Value7", UseScanLine);
			FAIFBBGFAIB().SetTexture("Start", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ELBMIEOIABA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
