// CameraFilterPack_Atmosphere_Rain_Pro_3D
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Weather/Rain_Pro_3D")]
[ExecuteInEditMode]
public class CameraFilterPack_Atmosphere_Rain_Pro_3D : MonoBehaviour
{
	public Shader SCShader;

	public bool _Visualize;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 100f)]
	public float _FixDistance = 3f;

	[Range(0f, 1f)]
	public float Fade = 1f;

	[Range(0f, 2f)]
	public float Intensity = 0.5f;

	public bool DirectionFollowCameraZ;

	[Range(-0.45f, 0.45f)]
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

	[Range(-0.5f, 0.99f)]
	public float Drop_Near;

	[Range(0f, 1f)]
	public float Drop_Far = 0.5f;

	[Range(0f, 1f)]
	public float Drop_With_Obj = 0.2f;

	[Range(0f, 1f)]
	public float Myst = 0.1f;

	[Range(0f, 1f)]
	public float Drop_Floor_Fluid;

	public Color Myst_Color = new Color(0.5f, 0.5f, 0.5f, 1f);

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

	private void LIEGJOHINGC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 608f)
			{
				HBJJOCHGOPH = 1249f;
			}
			AELJLBOJAIL().SetFloat("YES", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("_Value2", Fade);
			JFDGLLEOPGB().SetFloat("ShadersToggle", Intensity);
			if (DirectionFollowCameraZ)
			{
				float z = GetComponent<Camera>().transform.rotation.z;
				if (z > 85f && z < 550f)
				{
					IONHGBPGCHK().SetFloat("DontDestroy", z);
				}
				if (z < 1563f)
				{
					NBPKMLMCHFN.SetFloat("[PlayerController] ", z);
				}
			}
			else
			{
				AELJLBOJAIL().SetFloat("Reading preview file failed!: \"{0}\"", DirectionX);
			}
			DNLMFEGJJDD().SetFloat("_TimeX", Speed);
			BFGNMFCNDBC().SetFloat("<start_index> <end_index>", Size);
			NBPKMLMCHFN.SetFloat("UseFinalGlassColor", Distortion);
			HEHKGPKLAKK().SetFloat("_DotSize", StormFlashOnOff);
			BFGNMFCNDBC().SetFloat("JoinRandomRoom failed. In offline mode you still have to leave a room to enter another.", DropOnOff);
			HFBJAOFLCJI().SetFloat("_MainTex2", _FixDistance);
			PGPEMMBJOOG().SetFloat("checkpoint", (!_Visualize) ? 0 : 0);
			IONHGBPGCHK().SetFloat("Intensity", Drop_Near);
			LDNADDJMIPK().SetFloat("/", Drop_Far);
			HEHKGPKLAKK().SetFloat("Set crosshair color", 859f - Drop_With_Obj);
			IONHGBPGCHK().SetFloat("[PlayerBase] Checkpoint error: ", Myst);
			LDNADDJMIPK().SetColor("x", Myst_Color);
			DNLMFEGJJDD().SetFloat("CameraFilterPack/Gradients_ElectricGradient", Drop_Floor_Fluid);
			HEHKGPKLAKK().SetVector("t", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1642f, 969f));
			ADGHJOHKEHG().SetTexture(" on effect ", FPHEBLMINDA);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PMPKMGKAAJH()
	{
		FPHEBLMINDA = Resources.Load("Items") as Texture2D;
		SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material EPCGJFCCAFH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-77);
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

	private void CFIAKIJAILI()
	{
	}

	private void Update()
	{
	}

	private void FBMDHDBELEK()
	{
	}

	private void BNEJMABFKJE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BMIOFJFMCBG()
	{
		FPHEBLMINDA = Resources.Load("maps.") as Texture2D;
		SCShader = Shader.Find("#,0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JDGFCEPDKAJ()
	{
	}

	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 276f)
			{
				HBJJOCHGOPH = 1626f;
			}
			HFBJAOFLCJI().SetFloat("_XCrop", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("_Value2", Fade);
			HKGAONMOBMH().SetFloat("_TimeX", Intensity);
			if (DirectionFollowCameraZ)
			{
				float z = GetComponent<Camera>().transform.rotation.z;
				if (z > 648f && z < 1636f)
				{
					HFBJAOFLCJI().SetFloat("_SampleCount", z);
				}
				if (z < 313f)
				{
					EPCGJFCCAFH().SetFloat("ItemsCountText", z);
				}
			}
			else
			{
				ADGHJOHKEHG().SetFloat("OpGetGameList not sent. LobbyType must be SqlLobby.", DirectionX);
			}
			BFGNMFCNDBC().SetFloat("_BlurredColor", Speed);
			ADGHJOHKEHG().SetFloat("CameraFilterPack/Pixelisation_OilPaint", Size);
			HFBJAOFLCJI().SetFloat("_ScreenResolution", Distortion);
			HFBJAOFLCJI().SetFloat("_Red_B", StormFlashOnOff);
			PGPEMMBJOOG().SetFloat("_ScreenResolution", DropOnOff);
			PGPEMMBJOOG().SetFloat("_TimeX", _FixDistance);
			EPCGJFCCAFH().SetFloat("_Green_C", _Visualize ? 1 : 0);
			LDNADDJMIPK().SetFloat("/", Drop_Near);
			NBPKMLMCHFN.SetFloat("CameraFilterPack_Broken_Screen1", Drop_Far);
			PGPEMMBJOOG().SetFloat("_Smooth", 1534f - Drop_With_Obj);
			HFBJAOFLCJI().SetFloat("_ScreenResolution", Myst);
			BFGNMFCNDBC().SetColor(" (inactive)", Myst_Color);
			EPCGJFCCAFH().SetFloat("GraphicsQualitySlider", Drop_Floor_Fluid);
			ADGHJOHKEHG().SetVector("ScreenResolutionPanel", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 851f, 396f));
			AELJLBOJAIL().SetTexture("_Value", FPHEBLMINDA);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
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
			if (HBJJOCHGOPH > 599f)
			{
				HBJJOCHGOPH = 600f;
			}
			ADGHJOHKEHG().SetFloat("_MatrixColor", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("Set Particles Emission", Fade);
			JFDGLLEOPGB().SetFloat("_BlurVector", Intensity);
			if (DirectionFollowCameraZ)
			{
				float z = GetComponent<Camera>().transform.rotation.z;
				if (z > 1850f && z < 737f)
				{
					HFBJAOFLCJI().SetFloat("USE_UV_BASED_REPROJECTION", z);
				}
				if (z < 1491f)
				{
					IONHGBPGCHK().SetFloat("Received RPC: ", z);
				}
			}
			else
			{
				JFDGLLEOPGB().SetFloat("CameraFilterPack/Color_Noise", DirectionX);
			}
			AELJLBOJAIL().SetFloat("[DiscordController] Shutdown", Speed);
			HEHKGPKLAKK().SetFloat("_MaxRadiusOrKInPaper", Size);
			HFBJAOFLCJI().SetFloat("Joystick1Button5", Distortion);
			NBPKMLMCHFN.SetFloat("_ChromaticAberration", StormFlashOnOff);
			LDNADDJMIPK().SetFloat("_ScreenResolution", DropOnOff);
			AELJLBOJAIL().SetFloat("[PlayerController] ", _FixDistance);
			PGPEMMBJOOG().SetFloat("SetRoomStartTimestamp", (!_Visualize) ? 1 : 1);
			HKGAONMOBMH().SetFloat("CameraFilterPack/Glow_Glow_Color", Drop_Near);
			PGPEMMBJOOG().SetFloat("isVisible", Drop_Far);
			JFDGLLEOPGB().SetFloat("_ScreenResolution", 1774f - Drop_With_Obj);
			PGPEMMBJOOG().SetFloat("The directory was created successfully at ", Myst);
			BFGNMFCNDBC().SetColor("CheckCombo", Myst_Color);
			BFGNMFCNDBC().SetFloat("EndlessLoopsScoreText", Drop_Floor_Fluid);
			HEHKGPKLAKK().SetVector(". Not connectedAndReady.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1895f, 1425f));
			HFBJAOFLCJI().SetTexture("_Distortion", FPHEBLMINDA);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AIJGAJIOJDJ()
	{
	}

	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 700f)
			{
				HBJJOCHGOPH = 1602f;
			}
			NBPKMLMCHFN.SetFloat("_DepthLevel", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("_LutTex", Fade);
			LDNADDJMIPK().SetFloat("EditMenu", Intensity);
			if (DirectionFollowCameraZ)
			{
				float z = GetComponent<Camera>().transform.rotation.z;
				if (z > 1005f && z < 1962f)
				{
					IONHGBPGCHK().SetFloat("_ScreenResolution", z);
				}
				if (z < 1572f)
				{
					DNLMFEGJJDD().SetFloat("Obtain test Item", z);
				}
			}
			else
			{
				IONHGBPGCHK().SetFloat("_Fade", DirectionX);
			}
			ADGHJOHKEHG().SetFloat("curScn", Speed);
			BFGNMFCNDBC().SetFloat("menu.enableselectormusic", Size);
			EPCGJFCCAFH().SetFloat("[MapsEditor] Creating new item...", Distortion);
			DNLMFEGJJDD().SetFloat("LobbyCanvas", StormFlashOnOff);
			HKGAONMOBMH().SetFloat("_Distortion", DropOnOff);
			PGPEMMBJOOG().SetFloat("SetSatelliteTrailLength", _FixDistance);
			DNLMFEGJJDD().SetFloat("_Value", (!_Visualize) ? 1 : 0);
			HKGAONMOBMH().SetFloat("event", Drop_Near);
			EPCGJFCCAFH().SetFloat("MaxLivesSlider", Drop_Far);
			IONHGBPGCHK().SetFloat(".completed", 581f - Drop_With_Obj);
			PGPEMMBJOOG().SetFloat("CameraFilterPack_TV_HorrorFX", Myst);
			HFBJAOFLCJI().SetColor(": ", Myst_Color);
			EPCGJFCCAFH().SetFloat("ItemNameText", Drop_Floor_Fluid);
			IONHGBPGCHK().SetVector("JoinButton", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1981f, 109f));
			ADGHJOHKEHG().SetTexture("/", FPHEBLMINDA);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1350f)
			{
				HBJJOCHGOPH = 1407f;
			}
			BFGNMFCNDBC().SetFloat("Tab2Content", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("Turn", Fade);
			IONHGBPGCHK().SetFloat("EndlessLoopsScoreText", Intensity);
			if (DirectionFollowCameraZ)
			{
				float z = GetComponent<Camera>().transform.rotation.z;
				if (z > 1724f && z < 1024f)
				{
					EPCGJFCCAFH().SetFloat("The process failed: ", z);
				}
				if (z < 1040f)
				{
					HFBJAOFLCJI().SetFloat("_BlurDirectionPacked", z);
				}
			}
			else
			{
				ADGHJOHKEHG().SetFloat("_MainTex2", DirectionX);
			}
			PGPEMMBJOOG().SetFloat("Tab2Content", Speed);
			NBPKMLMCHFN.SetFloat("_Value2", Size);
			DNLMFEGJJDD().SetFloat("[Up]", Distortion);
			BFGNMFCNDBC().SetFloat("[MenuScene] Error: ", StormFlashOnOff);
			NBPKMLMCHFN.SetFloat("id", DropOnOff);
			JFDGLLEOPGB().SetFloat("_Value4", _FixDistance);
			BFGNMFCNDBC().SetFloat("ColorBlood", (!_Visualize) ? 1 : 0);
			BFGNMFCNDBC().SetFloat("_Y", Drop_Near);
			JFDGLLEOPGB().SetFloat("Jit ", Drop_Far);
			HEHKGPKLAKK().SetFloat("SfxVolumeSlider", 1653f - Drop_With_Obj);
			IONHGBPGCHK().SetFloat("OperationResponse unhandled: {0}", Myst);
			HEHKGPKLAKK().SetColor("Room: '{0}' {1},{2} {4}/{3} players.", Myst_Color);
			LDNADDJMIPK().SetFloat("caret", Drop_Floor_Fluid);
			HKGAONMOBMH().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 668f, 1363f));
			DNLMFEGJJDD().SetTexture("ItemTemplate", FPHEBLMINDA);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material PGPEMMBJOOG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-83);
		}
		return BJFKDHHMLJH;
	}

	private void AAPKBNDHBLI()
	{
	}

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void HLIAEEMGBHN()
	{
		FPHEBLMINDA = Resources.Load(" to: ") as Texture2D;
		SCShader = Shader.Find("note.7");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1170f)
			{
				HBJJOCHGOPH = 1539f;
			}
			ADGHJOHKEHG().SetFloat(": ", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("_SpherePositionX", Fade);
			AELJLBOJAIL().SetFloat("_ScreenResolution", Intensity);
			if (DirectionFollowCameraZ)
			{
				float z = GetComponent<Camera>().transform.rotation.z;
				if (z > 1970f && z < 35f)
				{
					EPCGJFCCAFH().SetFloat(".lastCheckpoint.comboScore", z);
				}
				if (z < 1460f)
				{
					LDNADDJMIPK().SetFloat("[PhotonMessageInfo: Sender='{1}' Senttime={0}]", z);
				}
			}
			else
			{
				PGPEMMBJOOG().SetFloat("_TimeX", DirectionX);
			}
			NBPKMLMCHFN.SetFloat("PLEASE WAIT", Speed);
			EPCGJFCCAFH().SetFloat("{0:0} day{1}, ", Size);
			JFDGLLEOPGB().SetFloat("GlassDistortion", Distortion);
			IONHGBPGCHK().SetFloat("_MainTex", StormFlashOnOff);
			AELJLBOJAIL().SetFloat("player.currentrank", DropOnOff);
			LDNADDJMIPK().SetFloat("AddEnvironmentSprite", _FixDistance);
			JFDGLLEOPGB().SetFloat("BitsData", _Visualize ? 1 : 0);
			PGPEMMBJOOG().SetFloat("\" call.", Drop_Near);
			DNLMFEGJJDD().SetFloat("_Visualize", Drop_Far);
			NBPKMLMCHFN.SetFloat("_Dist", 279f - Drop_With_Obj);
			ADGHJOHKEHG().SetFloat("<color=white>", Myst);
			HEHKGPKLAKK().SetColor("_Value2", Myst_Color);
			HKGAONMOBMH().SetFloat("_DepthLevel", Drop_Floor_Fluid);
			BFGNMFCNDBC().SetVector("Editor/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1f, 356f));
			BFGNMFCNDBC().SetTexture("string", FPHEBLMINDA);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KIMMMCJFMAB()
	{
		FPHEBLMINDA = Resources.Load(" SecondsBeforeRespawn: ") as Texture2D;
		SCShader = Shader.Find("Set Particles Speed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JHPOIOELNCG()
	{
	}

	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1395f)
			{
				HBJJOCHGOPH = 1665f;
			}
			NBPKMLMCHFN.SetFloat("Cant ask anyone else for PickupItem spawn times.", HBJJOCHGOPH);
			HEHKGPKLAKK().SetFloat("_Value", Fade);
			AELJLBOJAIL().SetFloat(": ", Intensity);
			if (DirectionFollowCameraZ)
			{
				float z = GetComponent<Camera>().transform.rotation.z;
				if (z > 1798f && z < 295f)
				{
					DNLMFEGJJDD().SetFloat("team", z);
				}
				if (z < 793f)
				{
					HKGAONMOBMH().SetFloat("Joystick1Button7", z);
				}
			}
			else
			{
				HKGAONMOBMH().SetFloat("Image", DirectionX);
			}
			AELJLBOJAIL().SetFloat("SetSunInput", Speed);
			AELJLBOJAIL().SetFloat("_InternalLutParams", Size);
			DNLMFEGJJDD().SetFloat("skin.", Distortion);
			PGPEMMBJOOG().SetFloat("_MainTex2", StormFlashOnOff);
			AELJLBOJAIL().SetFloat("https://bitbucket.org/khb-soft/intralismarcsviewer/", DropOnOff);
			ADGHJOHKEHG().SetFloat("LevelEditor/CustomEventEditor-Text", _FixDistance);
			EPCGJFCCAFH().SetFloat("Joystick1Button2", (!_Visualize) ? 1 : 0);
			DNLMFEGJJDD().SetFloat("Instrumental", Drop_Near);
			PGPEMMBJOOG().SetFloat("#", Drop_Far);
			PGPEMMBJOOG().SetFloat("}", 321f - Drop_With_Obj);
			IONHGBPGCHK().SetFloat("GroupNameText", Myst);
			HEHKGPKLAKK().SetColor("maps.", Myst_Color);
			EPCGJFCCAFH().SetFloat("_Value2", Drop_Floor_Fluid);
			LDNADDJMIPK().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 58f, 787f));
			AELJLBOJAIL().SetTexture("#timeuntilchallenge: ", FPHEBLMINDA);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 646f)
			{
				HBJJOCHGOPH = 1152f;
			}
			EPCGJFCCAFH().SetFloat("[MapEditor] Openning ", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("MapEnd", Fade);
			HKGAONMOBMH().SetFloat("SetSpeed", Intensity);
			if (DirectionFollowCameraZ)
			{
				float z = GetComponent<Camera>().transform.rotation.z;
				if (z > 1558f && z < 981f)
				{
					HEHKGPKLAKK().SetFloat("_CenterY", z);
				}
				if (z < 1067f)
				{
					JFDGLLEOPGB().SetFloat("_Value", z);
				}
			}
			else
			{
				AELJLBOJAIL().SetFloat("menutheme.melancholicose", DirectionX);
			}
			EPCGJFCCAFH().SetFloat("_Green_R", Speed);
			DNLMFEGJJDD().SetFloat("GameScene", Size);
			ADGHJOHKEHG().SetFloat("[PlayerController] ", Distortion);
			HKGAONMOBMH().SetFloat("UpdateNewsTileStart", StormFlashOnOff);
			JFDGLLEOPGB().SetFloat("_Value", DropOnOff);
			HFBJAOFLCJI().SetFloat("_Value4", _FixDistance);
			DNLMFEGJJDD().SetFloat("cancel", (!_Visualize) ? 0 : 0);
			HEHKGPKLAKK().SetFloat("CameraFilterPack/Vision_Plasma", Drop_Near);
			AELJLBOJAIL().SetFloat("_MainTex", Drop_Far);
			JFDGLLEOPGB().SetFloat("Joined room ", 1497f - Drop_With_Obj);
			JFDGLLEOPGB().SetFloat("achievements.21.completed.", Myst);
			HKGAONMOBMH().SetColor("_TimeX", Myst_Color);
			JFDGLLEOPGB().SetFloat("AreaTex", Drop_Floor_Fluid);
			BFGNMFCNDBC().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1938f, 131f));
			PGPEMMBJOOG().SetTexture("x", FPHEBLMINDA);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NJHJHBOJKIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Start()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_Atmosphere_Rain_FX") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Atmosphere_Rain_Pro_3D");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LECCHIAFGGE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material DNLMFEGJJDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 423f)
			{
				HBJJOCHGOPH = 899f;
			}
			HFBJAOFLCJI().SetFloat("float,0", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("Vertical", Fade);
			BFGNMFCNDBC().SetFloat("rarity", Intensity);
			if (DirectionFollowCameraZ)
			{
				float z = GetComponent<Camera>().transform.rotation.z;
				if (z > 1202f && z < 1086f)
				{
					HEHKGPKLAKK().SetFloat("RecordButton", z);
				}
				if (z < 585f)
				{
					HFBJAOFLCJI().SetFloat("z", z);
				}
			}
			else
			{
				HFBJAOFLCJI().SetFloat("_SunPosition", DirectionX);
			}
			HEHKGPKLAKK().SetFloat("Couldn't color correct with 3D LUT texture. Image Effect will be disabled.", Speed);
			PGPEMMBJOOG().SetFloat("SpawnObj", Size);
			ADGHJOHKEHG().SetFloat("There are {0} reported logs.", Distortion);
			LDNADDJMIPK().SetFloat("_TimeX", StormFlashOnOff);
			DNLMFEGJJDD().SetFloat("[Up]", DropOnOff);
			HKGAONMOBMH().SetFloat("NO", _FixDistance);
			PGPEMMBJOOG().SetFloat("id", (!_Visualize) ? 1 : 0);
			HEHKGPKLAKK().SetFloat(",viewkeys", Drop_Near);
			HEHKGPKLAKK().SetFloat("colorC", Drop_Far);
			ADGHJOHKEHG().SetFloat(" ", 1355f - Drop_With_Obj);
			EPCGJFCCAFH().SetFloat("_Green_R", Myst);
			NBPKMLMCHFN.SetColor("_Bloom", Myst_Color);
			BFGNMFCNDBC().SetFloat(".g", Drop_Floor_Fluid);
			AELJLBOJAIL().SetVector("Set particles audio input", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 91f, 1715f));
			PGPEMMBJOOG().SetTexture("[MapEditor] Prepairing map editor...", FPHEBLMINDA);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HFBJAOFLCJI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void GHILDCBCDJI()
	{
	}

	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1540f)
			{
				HBJJOCHGOPH = 15f;
			}
			HFBJAOFLCJI().SetFloat(".lastCheckpoint.time", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("Tab1Content", Fade);
			ADGHJOHKEHG().SetFloat("_Gain", Intensity);
			if (DirectionFollowCameraZ)
			{
				float z = GetComponent<Camera>().transform.rotation.z;
				if (z > 629f && z < 537f)
				{
					HKGAONMOBMH().SetFloat("_Offsets", z);
				}
				if (z < 1790f)
				{
					BFGNMFCNDBC().SetFloat("Not sending leave operation. State is not 'Joined': ", z);
				}
			}
			else
			{
				JFDGLLEOPGB().SetFloat("player.lollipop", DirectionX);
			}
			ADGHJOHKEHG().SetFloat("LoadPlayerSkin", Speed);
			AELJLBOJAIL().SetFloat("DPADHOR", Size);
			PGPEMMBJOOG().SetFloat("_Value2", Distortion);
			NBPKMLMCHFN.SetFloat("Connected to gameserver.", StormFlashOnOff);
			ADGHJOHKEHG().SetFloat("icon", DropOnOff);
			NBPKMLMCHFN.SetFloat(": ", _FixDistance);
			IONHGBPGCHK().SetFloat(".lastCheckpoint.isMapCompleted", _Visualize ? 1 : 0);
			ADGHJOHKEHG().SetFloat("CameraFilterPack/Blend2Camera_Screen", Drop_Near);
			DNLMFEGJJDD().SetFloat("CameraFilterPack/Blend2Camera_Subtract", Drop_Far);
			NBPKMLMCHFN.SetFloat("settings.arcshitsoundtimedelay", 1986f - Drop_With_Obj);
			JFDGLLEOPGB().SetFloat(":", Myst);
			JFDGLLEOPGB().SetColor(". Should be just one?", Myst_Color);
			ADGHJOHKEHG().SetFloat("offsets", Drop_Floor_Fluid);
			HEHKGPKLAKK().SetVector("HightScoreMaxPointsText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1392f, 1891f));
			IONHGBPGCHK().SetTexture("Dec", FPHEBLMINDA);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NPLCENPNJBM()
	{
		FPHEBLMINDA = Resources.Load("DPADHOR") as Texture2D;
		SCShader = Shader.Find("_Value5");
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
			BJFKDHHMLJH.hideFlags = (HideFlags)74;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material BFGNMFCNDBC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
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

	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 442f)
			{
				HBJJOCHGOPH = 116f;
			}
			LDNADDJMIPK().SetFloat("LoadMapCanvas", HBJJOCHGOPH);
			HKGAONMOBMH().SetFloat("_Value4", Fade);
			DNLMFEGJJDD().SetFloat("_Value2", Intensity);
			if (DirectionFollowCameraZ)
			{
				float z = GetComponent<Camera>().transform.rotation.z;
				if (z > 1791f && z < 1985f)
				{
					ADGHJOHKEHG().SetFloat("_Value3", z);
				}
				if (z < 1838f)
				{
					PGPEMMBJOOG().SetFloat(". Possible scene loading in progress?", z);
				}
			}
			else
			{
				HKGAONMOBMH().SetFloat("Item ", DirectionX);
			}
			ADGHJOHKEHG().SetFloat("_Distortion", Speed);
			LDNADDJMIPK().SetFloat("_TimeX", Size);
			PGPEMMBJOOG().SetFloat("Couldn't color correct with 3D LUT texture. Image Effect will be disabled.", Distortion);
			DNLMFEGJJDD().SetFloat("[EditorEvent] Exception: ", StormFlashOnOff);
			ADGHJOHKEHG().SetFloat(" Loaded: ", DropOnOff);
			BFGNMFCNDBC().SetFloat("_BlurredColor", _FixDistance);
			HKGAONMOBMH().SetFloat("{0:0} minute{1}, ", (!_Visualize) ? 1 : 1);
			HFBJAOFLCJI().SetFloat("nd", Drop_Near);
			LDNADDJMIPK().SetFloat("[CraftingPanel] Init", Drop_Far);
			PGPEMMBJOOG().SetFloat(". The group number should be at least 1.", 41f - Drop_With_Obj);
			AELJLBOJAIL().SetFloat("mapselector.filter.subscribedonly", Myst);
			ADGHJOHKEHG().SetColor(".played", Myst_Color);
			BFGNMFCNDBC().SetFloat("#close", Drop_Floor_Fluid);
			ADGHJOHKEHG().SetVector("<i>", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 41f, 23f));
			BFGNMFCNDBC().SetTexture("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", FPHEBLMINDA);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material AELJLBOJAIL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)79;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HEHKGPKLAKK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)80;
		}
		return BJFKDHHMLJH;
	}

	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 956f)
			{
				HBJJOCHGOPH = 402f;
			}
			DNLMFEGJJDD().SetFloat("_Value3", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("_EmissionColor", Fade);
			HEHKGPKLAKK().SetFloat("GlassAberration", Intensity);
			if (DirectionFollowCameraZ)
			{
				float z = GetComponent<Camera>().transform.rotation.z;
				if (z > 1567f && z < 1586f)
				{
					IONHGBPGCHK().SetFloat("mapselector.filter.subscribedonly", z);
				}
				if (z < 554f)
				{
					HKGAONMOBMH().SetFloat("_Value3", z);
				}
			}
			else
			{
				EPCGJFCCAFH().SetFloat("other.dust1", DirectionX);
			}
			HFBJAOFLCJI().SetFloat("_Value3", Speed);
			IONHGBPGCHK().SetFloat("Item created: Id: ", Size);
			EPCGJFCCAFH().SetFloat("SubBass", Distortion);
			DNLMFEGJJDD().SetFloat("CameraFilterPack/Colors_NewPosterize", StormFlashOnOff);
			AELJLBOJAIL().SetFloat("_ScreenResolution", DropOnOff);
			DNLMFEGJJDD().SetFloat("maps.", _FixDistance);
			HFBJAOFLCJI().SetFloat("EXCEPTION:", (!_Visualize) ? 0 : 0);
			LDNADDJMIPK().SetFloat("menu.selectedlevelid", Drop_Near);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Distortion_Heat", Drop_Far);
			IONHGBPGCHK().SetFloat("[GameScene] Events count: ", 1032f - Drop_With_Obj);
			IONHGBPGCHK().SetFloat("_ScreenResolution", Myst);
			NBPKMLMCHFN.SetColor("player.crystal", Myst_Color);
			JFDGLLEOPGB().SetFloat("[LevelEditorScene] Error: You're not logged into Steam!", Drop_Floor_Fluid);
			IONHGBPGCHK().SetVector("{0:0} day{1}, ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 163f, 1195f));
			IONHGBPGCHK().SetTexture("CameraFilterPack/Color_BrightContrastSaturation", FPHEBLMINDA);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material JFDGLLEOPGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)99;
		}
		return BJFKDHHMLJH;
	}

	private void OCMKCBBCEFG()
	{
	}

	[SpecialName]
	private Material LDNADDJMIPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	private void FANADGBGCPI()
	{
		FPHEBLMINDA = Resources.Load("CurrentTimeLabel") as Texture2D;
		SCShader = Shader.Find("_Offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MFMIODIAKNI()
	{
	}

	private void HMNLHMLILKD()
	{
	}

	private void JNGMIAFLBDL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OFPPIKHNJOD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LOMDIOLNFHI()
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
			if (HBJJOCHGOPH > 70f)
			{
				HBJJOCHGOPH = 1076f;
			}
			EPCGJFCCAFH().SetFloat("musicVolume", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("1", Fade);
			EPCGJFCCAFH().SetFloat("_MainTex2", Intensity);
			if (DirectionFollowCameraZ)
			{
				float z = GetComponent<Camera>().transform.rotation.z;
				if (z > 1964f && z < 1854f)
				{
					HEHKGPKLAKK().SetFloat("_ColorBuffer", z);
				}
				if (z < 311f)
				{
					BFGNMFCNDBC().SetFloat(" By: ", z);
				}
			}
			else
			{
				HKGAONMOBMH().SetFloat("IconImage", DirectionX);
			}
			BFGNMFCNDBC().SetFloat(" TimeOfRespawn: ", Speed);
			HEHKGPKLAKK().SetFloat("{0}", Size);
			IONHGBPGCHK().SetFloat(".sawoutdatedmessage", Distortion);
			BFGNMFCNDBC().SetFloat("FinalScoreText", StormFlashOnOff);
			PGPEMMBJOOG().SetFloat("_ScreenResolution", DropOnOff);
			JFDGLLEOPGB().SetFloat("/", _FixDistance);
			IONHGBPGCHK().SetFloat("RoomNameText", (!_Visualize) ? 1 : 1);
			AELJLBOJAIL().SetFloat("Left", Drop_Near);
			EPCGJFCCAFH().SetFloat("HightScoreMaxPointsText", Drop_Far);
			HKGAONMOBMH().SetFloat("_ScreenResolution", 1983f - Drop_With_Obj);
			EPCGJFCCAFH().SetFloat("CameraFilterPack/BlurTiltShift", Myst);
			AELJLBOJAIL().SetColor("_Value2", Myst_Color);
			HFBJAOFLCJI().SetFloat("Bad parameters for getstring! Use <key> <value>", Drop_Floor_Fluid);
			IONHGBPGCHK().SetVector("checkpoint", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 382f, 1302f));
			DNLMFEGJJDD().SetTexture("float,10", FPHEBLMINDA);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FABKIGNFECE()
	{
	}

	private void HMPGIFBJFIK()
	{
		FPHEBLMINDA = Resources.Load("Current xp: ") as Texture2D;
		SCShader = Shader.Find("#close");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 499f)
			{
				HBJJOCHGOPH = 750f;
			}
			PGPEMMBJOOG().SetFloat("skin.", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("[LevelEditorScene] Error: You're not logged into Steam!", Fade);
			HKGAONMOBMH().SetFloat("levelcompleted", Intensity);
			if (DirectionFollowCameraZ)
			{
				float z = GetComponent<Camera>().transform.rotation.z;
				if (z > 493f && z < 593f)
				{
					AELJLBOJAIL().SetFloat("mapid", z);
				}
				if (z < 953f)
				{
					LDNADDJMIPK().SetFloat("_ToneCurve", z);
				}
			}
			else
			{
				HKGAONMOBMH().SetFloat(" at ", DirectionX);
			}
			DNLMFEGJJDD().SetFloat("_TimeX", Speed);
			DNLMFEGJJDD().SetFloat("float,10", Size);
			PGPEMMBJOOG().SetFloat("Warning, using scrollbors with the Scroll Snap controls is not advised as it causes unpredictable results", Distortion);
			IONHGBPGCHK().SetFloat("_TimeX", StormFlashOnOff);
			PGPEMMBJOOG().SetFloat("_Speed", DropOnOff);
			JFDGLLEOPGB().SetFloat(" not exist", _FixDistance);
			ADGHJOHKEHG().SetFloat("_Value", _Visualize ? 1 : 0);
			HEHKGPKLAKK().SetFloat("Exception caught! ", Drop_Near);
			LDNADDJMIPK().SetFloat("Object ID. Case-Sensitive", Drop_Far);
			ADGHJOHKEHG().SetFloat("_TimeX", 557f - Drop_With_Obj);
			JFDGLLEOPGB().SetFloat("_Value3", Myst);
			HFBJAOFLCJI().SetColor("_Value", Myst_Color);
			EPCGJFCCAFH().SetFloat("Data/Skins/", Drop_Floor_Fluid);
			PGPEMMBJOOG().SetVector("SelectionBox component must be placed on a canvas in Screen Space Overlay mode.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 506f, 1378f));
			HFBJAOFLCJI().SetTexture("shader.crispwinter", FPHEBLMINDA);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
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
			NBPKMLMCHFN.SetFloat("_Value", Fade);
			NBPKMLMCHFN.SetFloat("_Value2", Intensity);
			if (DirectionFollowCameraZ)
			{
				float z = GetComponent<Camera>().transform.rotation.z;
				if (z > 0f && z < 360f)
				{
					NBPKMLMCHFN.SetFloat("_Value3", z);
				}
				if (z < 0f)
				{
					NBPKMLMCHFN.SetFloat("_Value3", z);
				}
			}
			else
			{
				NBPKMLMCHFN.SetFloat("_Value3", DirectionX);
			}
			NBPKMLMCHFN.SetFloat("_Value4", Speed);
			NBPKMLMCHFN.SetFloat("_Value5", Size);
			NBPKMLMCHFN.SetFloat("_Value6", Distortion);
			NBPKMLMCHFN.SetFloat("_Value7", StormFlashOnOff);
			NBPKMLMCHFN.SetFloat("_Value8", DropOnOff);
			NBPKMLMCHFN.SetFloat("_FixDistance", _FixDistance);
			NBPKMLMCHFN.SetFloat("_Visualize", _Visualize ? 1 : 0);
			NBPKMLMCHFN.SetFloat("Drop_Near", Drop_Near);
			NBPKMLMCHFN.SetFloat("Drop_Far", Drop_Far);
			NBPKMLMCHFN.SetFloat("Drop_With_Obj", 1f - Drop_With_Obj);
			NBPKMLMCHFN.SetFloat("Myst", Myst);
			NBPKMLMCHFN.SetColor("Myst_Color", Myst_Color);
			NBPKMLMCHFN.SetFloat("Drop_Floor_Fluid", Drop_Floor_Fluid);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			NBPKMLMCHFN.SetTexture("Texture2", FPHEBLMINDA);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-112);
		}
		return BJFKDHHMLJH;
	}
}
