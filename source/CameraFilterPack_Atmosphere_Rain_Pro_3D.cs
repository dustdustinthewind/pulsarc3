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
			IONHGBPGCHK().SetFloat("Save level before uploading?", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("_Value", Fade);
			HFBJAOFLCJI().SetFloat("SettingsCanvas", Intensity);
			if (DirectionFollowCameraZ)
			{
				float z = GetComponent<Camera>().transform.rotation.z;
				if (z > 85f && z < 550f)
				{
					HFBJAOFLCJI().SetFloat("couldn't be found!", z);
				}
				if (z < 1563f)
				{
					HKGAONMOBMH().SetFloat(" not exist", z);
				}
			}
			else
			{
				AELJLBOJAIL().SetFloat("LevelEditor/patterns", DirectionX);
			}
			HFBJAOFLCJI().SetFloat("CameraFilterPack/Edge_Sigmoid", Speed);
			AELJLBOJAIL().SetFloat("Clears the console and prints the logs in the specified range", Size);
			BFGNMFCNDBC().SetFloat("_TimeX", Distortion);
			BFGNMFCNDBC().SetFloat("_TimeX", StormFlashOnOff);
			EPCGJFCCAFH().SetFloat("JoinOrCreateRoom failed. In offline mode you still have to leave a room to enter another.", DropOnOff);
			JFDGLLEOPGB().SetFloat("_MainTex2", _FixDistance);
			HFBJAOFLCJI().SetFloat("Edited unlock conditions", (!_Visualize) ? 0 : 0);
			ADGHJOHKEHG().SetFloat("_TimeX", Drop_Near);
			BFGNMFCNDBC().SetFloat("settings.enableranking", Drop_Far);
			IONHGBPGCHK().SetFloat("Set crosshair color", 859f - Drop_With_Obj);
			IONHGBPGCHK().SetFloat("[PlayerBase] SetSpeed error: ", Myst);
			JFDGLLEOPGB().SetColor("InfoCanvas", Myst_Color);
			PGPEMMBJOOG().SetFloat("_ScreenResolution", Drop_Floor_Fluid);
			HEHKGPKLAKK().SetVector("Please specify either t or f.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1642f, 969f));
			DNLMFEGJJDD().SetTexture("Missing shader in ", FPHEBLMINDA);
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
		FPHEBLMINDA = Resources.Load("ScrollPanel") as Texture2D;
		SCShader = Shader.Find("icon");
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
		SCShader = Shader.Find("#,0.00");
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
			JFDGLLEOPGB().SetFloat("Default UI Material", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("_Value", Fade);
			LDNADDJMIPK().SetFloat("CameraFilterPack/FX_ZebraColor", Intensity);
			if (DirectionFollowCameraZ)
			{
				float z = GetComponent<Camera>().transform.rotation.z;
				if (z > 648f && z < 1636f)
				{
					BFGNMFCNDBC().SetFloat("_Radius", z);
				}
				if (z < 313f)
				{
					BFGNMFCNDBC().SetFloat("InfoCanvas", z);
				}
			}
			else
			{
				HEHKGPKLAKK().SetFloat("OpJoinRandomRoom()", DirectionX);
			}
			EPCGJFCCAFH().SetFloat("_Offsets", Speed);
			EPCGJFCCAFH().SetFloat("_Value4", Size);
			BFGNMFCNDBC().SetFloat("_Glitch", Distortion);
			NBPKMLMCHFN.SetFloat("_Red_G", StormFlashOnOff);
			ADGHJOHKEHG().SetFloat("_ScreenResolution", DropOnOff);
			HEHKGPKLAKK().SetFloat("CameraFilterPack/Gradients_Tech", _FixDistance);
			PGPEMMBJOOG().SetFloat("_Green_C", _Visualize ? 1 : 0);
			HKGAONMOBMH().SetFloat("#done", Drop_Near);
			LDNADDJMIPK().SetFloat("CameraFilterPack_Broken_Screen1", Drop_Far);
			BFGNMFCNDBC().SetFloat("_Dist", 1534f - Drop_With_Obj);
			JFDGLLEOPGB().SetFloat("_Value4", Myst);
			PGPEMMBJOOG().SetColor(" ", Myst_Color);
			BFGNMFCNDBC().SetFloat("GraphicsQualitySlider", Drop_Floor_Fluid);
			AELJLBOJAIL().SetVector("ScreenResolutionPanel", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 851f, 396f));
			DNLMFEGJJDD().SetTexture("_TimeX", FPHEBLMINDA);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
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
			if (HBJJOCHGOPH > 599f)
			{
				HBJJOCHGOPH = 600f;
			}
			IONHGBPGCHK().SetFloat("_MatrixColor", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("Set Particles Emission", Fade);
			BFGNMFCNDBC().SetFloat("_BlurVector", Intensity);
			if (DirectionFollowCameraZ)
			{
				float z = GetComponent<Camera>().transform.rotation.z;
				if (z > 1850f && z < 737f)
				{
					AELJLBOJAIL().SetFloat("USE_CORNER_DETECTION", z);
				}
				if (z < 1491f)
				{
					JFDGLLEOPGB().SetFloat(". The RPC has been ignored.", z);
				}
			}
			else
			{
				IONHGBPGCHK().SetFloat("_ScreenResolution", DirectionX);
			}
			HFBJAOFLCJI().SetFloat("[DiscordController] Init", Speed);
			HEHKGPKLAKK().SetFloat("_MaxVelocity", Size);
			NBPKMLMCHFN.SetFloat("Joystick1Button4", Distortion);
			IONHGBPGCHK().SetFloat("_DistAmount", StormFlashOnOff);
			LDNADDJMIPK().SetFloat("_Value4", DropOnOff);
			IONHGBPGCHK().SetFloat("[PlayerController] ", _FixDistance);
			HKGAONMOBMH().SetFloat("turn: {0:0}", (!_Visualize) ? 1 : 1);
			HKGAONMOBMH().SetFloat("_MainTex2", Drop_Near);
			DNLMFEGJJDD().SetFloat("isVisible", Drop_Far);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", 1774f - Drop_With_Obj);
			NBPKMLMCHFN.SetFloat(".sav", Myst);
			NBPKMLMCHFN.SetColor("[PlayerBase] Loaded music", Myst_Color);
			HKGAONMOBMH().SetFloat("CheckpointsScoreText", Drop_Floor_Fluid);
			DNLMFEGJJDD().SetVector("score", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1895f, 1425f));
			JFDGLLEOPGB().SetTexture("_Distortion", FPHEBLMINDA);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
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
			JFDGLLEOPGB().SetFloat("_DepthLevel", HBJJOCHGOPH);
			HEHKGPKLAKK().SetFloat("_Blend", Fade);
			BFGNMFCNDBC().SetFloat("ViewMenu", Intensity);
			if (DirectionFollowCameraZ)
			{
				float z = GetComponent<Camera>().transform.rotation.z;
				if (z > 1005f && z < 1962f)
				{
					EPCGJFCCAFH().SetFloat("_ColorLevel", z);
				}
				if (z < 1572f)
				{
					HEHKGPKLAKK().SetFloat("Reload Steam Inventory", z);
				}
			}
			else
			{
				HEHKGPKLAKK().SetFloat("_ScreenResolution", DirectionX);
			}
			BFGNMFCNDBC().SetFloat("curScn", Speed);
			HEHKGPKLAKK().SetFloat("menu.enableselectormusic", Size);
			IONHGBPGCHK().SetFloat("#mapalreadyexistupdate", Distortion);
			BFGNMFCNDBC().SetFloat("LobbyCanvas", StormFlashOnOff);
			ADGHJOHKEHG().SetFloat("_TimeX", DropOnOff);
			BFGNMFCNDBC().SetFloat("Set satellite radius (offset)", _FixDistance);
			HKGAONMOBMH().SetFloat("_TimeX", (!_Visualize) ? 1 : 0);
			NBPKMLMCHFN.SetFloat("event", Drop_Near);
			BFGNMFCNDBC().SetFloat("HandsCountSlider", Drop_Far);
			EPCGJFCCAFH().SetFloat("maps.", 581f - Drop_With_Obj);
			IONHGBPGCHK().SetFloat("_RGB", Myst);
			IONHGBPGCHK().SetColor("[PlayerController] ", Myst_Color);
			HFBJAOFLCJI().SetFloat("RarityImage", Drop_Floor_Fluid);
			BFGNMFCNDBC().SetVector("JoinButton", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1981f, 109f));
			PGPEMMBJOOG().SetTexture("/", FPHEBLMINDA);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			ADGHJOHKEHG().SetFloat("HandsCountSlider", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("move", Fade);
			DNLMFEGJJDD().SetFloat("CheckpointsScoreText", Intensity);
			if (DirectionFollowCameraZ)
			{
				float z = GetComponent<Camera>().transform.rotation.z;
				if (z > 1724f && z < 1024f)
				{
					HEHKGPKLAKK().SetFloat(" does not exist!", z);
				}
				if (z < 1040f)
				{
					EPCGJFCCAFH().SetFloat("_ToPrevViewProjCombined", z);
				}
			}
			else
			{
				HKGAONMOBMH().SetFloat("_MainTex2", DirectionX);
			}
			HEHKGPKLAKK().SetFloat("ConfigVersionSlider", Speed);
			BFGNMFCNDBC().SetFloat("_Value2", Size);
			BFGNMFCNDBC().SetFloat(",0", Distortion);
			HFBJAOFLCJI().SetFloat("/theme", StormFlashOnOff);
			DNLMFEGJJDD().SetFloat("id", DropOnOff);
			ADGHJOHKEHG().SetFloat("_Value3", _FixDistance);
			EPCGJFCCAFH().SetFloat("_Value2", (!_Visualize) ? 1 : 0);
			EPCGJFCCAFH().SetFloat("_Y", Drop_Near);
			DNLMFEGJJDD().SetFloat("Rtt:{0,4} +/-{1,3}", Drop_Far);
			JFDGLLEOPGB().SetFloat("menu.enableselectormusic", 1653f - Drop_With_Obj);
			LDNADDJMIPK().SetFloat("GetGameList failed: ", Myst);
			HKGAONMOBMH().SetColor("Can't set MaxPlayers when not in that room.", Myst_Color);
			AELJLBOJAIL().SetFloat("Tab1Content", Drop_Floor_Fluid);
			ADGHJOHKEHG().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 668f, 1363f));
			HKGAONMOBMH().SetTexture("SlidingArea", FPHEBLMINDA);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
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
		FPHEBLMINDA = Resources.Load(" Time: ") as Texture2D;
		SCShader = Shader.Find("note.3");
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
			HFBJAOFLCJI().SetFloat("[PlayerController] ", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("_SpherePositionX", Fade);
			HKGAONMOBMH().SetFloat("Fade", Intensity);
			if (DirectionFollowCameraZ)
			{
				float z = GetComponent<Camera>().transform.rotation.z;
				if (z > 1970f && z < 35f)
				{
					IONHGBPGCHK().SetFloat(".lastCheckpoint.powerupsScore", z);
				}
				if (z < 1460f)
				{
					AELJLBOJAIL().SetFloat("curScn", z);
				}
			}
			else
			{
				IONHGBPGCHK().SetFloat("CameraFilterPack/Distortion_Twist_Square", DirectionX);
			}
			IONHGBPGCHK().SetFloat("Ok", Speed);
			AELJLBOJAIL().SetFloat("{0:0} day{1}, ", Size);
			IONHGBPGCHK().SetFloat("VisionBlur", Distortion);
			BFGNMFCNDBC().SetFloat("_Offsets", StormFlashOnOff);
			HFBJAOFLCJI().SetFloat("[RanksSystem] Init", DropOnOff);
			IONHGBPGCHK().SetFloat("SetParticlesGravity", _FixDistance);
			DNLMFEGJJDD().SetFloat(",", _Visualize ? 1 : 0);
			DNLMFEGJJDD().SetFloat("RPCs can only be sent in rooms. Call of \"", Drop_Near);
			NBPKMLMCHFN.SetFloat("_Visualize", Drop_Far);
			AELJLBOJAIL().SetFloat("_Size", 279f - Drop_With_Obj);
			HEHKGPKLAKK().SetFloat("<color=white>PhotonView Group: ", Myst);
			DNLMFEGJJDD().SetColor("_Value2", Myst_Color);
			JFDGLLEOPGB().SetFloat("_DepthLevel", Drop_Floor_Fluid);
			JFDGLLEOPGB().SetVector("#alreadyexist", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1f, 356f));
			AELJLBOJAIL().SetTexture("bool", FPHEBLMINDA);
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
		FPHEBLMINDA = Resources.Load("PunRespawn") as Texture2D;
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
			DNLMFEGJJDD().SetFloat(" id: ", HBJJOCHGOPH);
			HEHKGPKLAKK().SetFloat("_TimeX", Fade);
			HEHKGPKLAKK().SetFloat("StartRound", Intensity);
			if (DirectionFollowCameraZ)
			{
				float z = GetComponent<Camera>().transform.rotation.z;
				if (z > 1798f && z < 295f)
				{
					AELJLBOJAIL().SetFloat("score", z);
				}
				if (z < 793f)
				{
					ADGHJOHKEHG().SetFloat("Joystick1Button6", z);
				}
			}
			else
			{
				HEHKGPKLAKK().SetFloat("skins", DirectionX);
			}
			JFDGLLEOPGB().SetFloat("SetScale", Speed);
			EPCGJFCCAFH().SetFloat("ENABLE_DITHERING", Size);
			DNLMFEGJJDD().SetFloat("local CheckCondition = function()", Distortion);
			LDNADDJMIPK().SetFloat("CameraFilterPack/Blend2Camera_VividLight", StormFlashOnOff);
			HEHKGPKLAKK().SetFloat("/", DropOnOff);
			IONHGBPGCHK().SetFloat("LevelEditor/CustomEventEditor-Text", _FixDistance);
			AELJLBOJAIL().SetFloat("A", (!_Visualize) ? 1 : 0);
			HFBJAOFLCJI().SetFloat("Instrumental", Drop_Near);
			HFBJAOFLCJI().SetFloat("GameModeText", Drop_Far);
			HEHKGPKLAKK().SetFloat("\\\"", 321f - Drop_With_Obj);
			ADGHJOHKEHG().SetFloat("InventoryContent", Myst);
			HKGAONMOBMH().SetColor(".played", Myst_Color);
			PGPEMMBJOOG().SetFloat("_Value", Drop_Floor_Fluid);
			IONHGBPGCHK().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 58f, 787f));
			PGPEMMBJOOG().SetTexture("#reward: ", FPHEBLMINDA);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
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
			AELJLBOJAIL().SetFloat("/", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("MapEnd", Fade);
			AELJLBOJAIL().SetFloat("/", Intensity);
			if (DirectionFollowCameraZ)
			{
				float z = GetComponent<Camera>().transform.rotation.z;
				if (z > 1558f && z < 981f)
				{
					DNLMFEGJJDD().SetFloat("_CenterY", z);
				}
				if (z < 1067f)
				{
					HEHKGPKLAKK().SetFloat("_Value", z);
				}
			}
			else
			{
				ADGHJOHKEHG().SetFloat("menutheme.idunno", DirectionX);
			}
			HEHKGPKLAKK().SetFloat("_Red_B", Speed);
			EPCGJFCCAFH().SetFloat("GameScene", Size);
			ADGHJOHKEHG().SetFloat(" not exist", Distortion);
			JFDGLLEOPGB().SetFloat("achievements.21.progress", StormFlashOnOff);
			AELJLBOJAIL().SetFloat("CameraFilterPack/TV_VHS", DropOnOff);
			PGPEMMBJOOG().SetFloat("_Value4", _FixDistance);
			HFBJAOFLCJI().SetFloat("[ResourcesManager] Load text error: not found", (!_Visualize) ? 0 : 0);
			HEHKGPKLAKK().SetFloat("_ScreenResolution", Drop_Near);
			NBPKMLMCHFN.SetFloat("_CenterRadius", Drop_Far);
			HKGAONMOBMH().SetFloat("Joined room ", 1497f - Drop_With_Obj);
			ADGHJOHKEHG().SetFloat("achievements.21.completed.", Myst);
			IONHGBPGCHK().SetColor("_MainTex2", Myst_Color);
			AELJLBOJAIL().SetFloat("_ConsoleSettings", Drop_Floor_Fluid);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1938f, 131f));
			IONHGBPGCHK().SetTexture("InfoCanvas", FPHEBLMINDA);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
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
			ADGHJOHKEHG().SetFloat("float,0", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("Aimer Input Module is incompatible with the StandAloneInputSystem, please remove it from the Event System in this scene or disable it when this module is in use", Fade);
			IONHGBPGCHK().SetFloat("RarityImage", Intensity);
			if (DirectionFollowCameraZ)
			{
				float z = GetComponent<Camera>().transform.rotation.z;
				if (z > 1202f && z < 1086f)
				{
					IONHGBPGCHK().SetFloat("RecordButton", z);
				}
				if (z < 585f)
				{
					PGPEMMBJOOG().SetFloat("z", z);
				}
			}
			else
			{
				LDNADDJMIPK().SetFloat("_Skybox", DirectionX);
			}
			NBPKMLMCHFN.SetFloat("The given 2D texture ", Speed);
			DNLMFEGJJDD().SetFloat("[PlayerBase] Starting game from: ", Size);
			EPCGJFCCAFH().SetFloat(" - {0}", Distortion);
			HFBJAOFLCJI().SetFloat("CameraFilterPack/Sharpen_Sharpen", StormFlashOnOff);
			IONHGBPGCHK().SetFloat("SpawnObj", DropOnOff);
			IONHGBPGCHK().SetFloat("YES", _FixDistance);
			AELJLBOJAIL().SetFloat("id", (!_Visualize) ? 1 : 0);
			HEHKGPKLAKK().SetFloat("[ResourcesManager] Load text error: not found", Drop_Near);
			ADGHJOHKEHG().SetFloat("colorA", Drop_Far);
			BFGNMFCNDBC().SetFloat("\"x", 1355f - Drop_With_Obj);
			HEHKGPKLAKK().SetFloat("_Green_R", Myst);
			AELJLBOJAIL().SetColor("_Parameter", Myst_Color);
			EPCGJFCCAFH().SetFloat(".g", Drop_Floor_Fluid);
			EPCGJFCCAFH().SetVector("0,7,true,0", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 91f, 1715f));
			EPCGJFCCAFH().SetTexture("Init", FPHEBLMINDA);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
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
			PGPEMMBJOOG().SetFloat(".lastCheckpoint.bgcolor", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Tab1Content", Fade);
			AELJLBOJAIL().SetFloat("_TimeX", Intensity);
			if (DirectionFollowCameraZ)
			{
				float z = GetComponent<Camera>().transform.rotation.z;
				if (z > 629f && z < 537f)
				{
					IONHGBPGCHK().SetFloat("_FgOverlap", z);
				}
				if (z < 1790f)
				{
					NBPKMLMCHFN.SetFloat(" to: ", z);
				}
			}
			else
			{
				JFDGLLEOPGB().SetFloat("player.lollipop", DirectionX);
			}
			HKGAONMOBMH().SetFloat("[PlayerBase] Highscore: ", Speed);
			PGPEMMBJOOG().SetFloat("DPADHOR", Size);
			HKGAONMOBMH().SetFloat("_Value2", Distortion);
			BFGNMFCNDBC().SetFloat("OnStatusChanged: {0} current State: {1}", StormFlashOnOff);
			BFGNMFCNDBC().SetFloat("/icon", DropOnOff);
			EPCGJFCCAFH().SetFloat(": ", _FixDistance);
			NBPKMLMCHFN.SetFloat("[PlayerBase] Loading checkpoint data", _Visualize ? 1 : 0);
			HFBJAOFLCJI().SetFloat("CameraFilterPack/Blend2Camera_Screen", Drop_Near);
			HKGAONMOBMH().SetFloat("CameraFilterPack/Blend2Camera_Subtract", Drop_Far);
			NBPKMLMCHFN.SetFloat("ArcsHitsoundTimeDelaySlider", 1986f - Drop_With_Obj);
			HFBJAOFLCJI().SetFloat(".", Myst);
			NBPKMLMCHFN.SetColor("\" that takes ", Myst_Color);
			JFDGLLEOPGB().SetFloat("_TapHigh", Drop_Floor_Fluid);
			ADGHJOHKEHG().SetVector("FinalScoreText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1392f, 1891f));
			IONHGBPGCHK().SetTexture("Oct", FPHEBLMINDA);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NPLCENPNJBM()
	{
		FPHEBLMINDA = Resources.Load("DPADVER") as Texture2D;
		SCShader = Shader.Find("_Value4");
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
			IONHGBPGCHK().SetFloat("Data/Editor/leveltemplate", HBJJOCHGOPH);
			ADGHJOHKEHG().SetFloat("_Value3", Fade);
			NBPKMLMCHFN.SetFloat("_Value", Intensity);
			if (DirectionFollowCameraZ)
			{
				float z = GetComponent<Camera>().transform.rotation.z;
				if (z > 1791f && z < 1985f)
				{
					PGPEMMBJOOG().SetFloat("_Value2", z);
				}
				if (z < 1838f)
				{
					JFDGLLEOPGB().SetFloat("RPC can't be sent to target PhotonPlayer being null! Did not send \"", z);
				}
			}
			else
			{
				BFGNMFCNDBC().SetFloat("Items", DirectionX);
			}
			JFDGLLEOPGB().SetFloat("_TimeX", Speed);
			ADGHJOHKEHG().SetFloat("CameraFilterPack/TV_Distorted", Size);
			IONHGBPGCHK().SetFloat("The given 2D texture ", Distortion);
			NBPKMLMCHFN.SetFloat("checkpoint", StormFlashOnOff);
			IONHGBPGCHK().SetFloat(". Name: ", DropOnOff);
			NBPKMLMCHFN.SetFloat("_Offsets", _FixDistance);
			JFDGLLEOPGB().SetFloat("{0:0} minute{1}, ", (!_Visualize) ? 1 : 1);
			BFGNMFCNDBC().SetFloat("2", Drop_Near);
			HFBJAOFLCJI().SetFloat("time", Drop_Far);
			DNLMFEGJJDD().SetFloat(". The group number should be at least 1.", 41f - Drop_With_Obj);
			JFDGLLEOPGB().SetFloat("mapselector.filter.rateduponly", Myst);
			IONHGBPGCHK().SetColor(".completed", Myst_Color);
			LDNADDJMIPK().SetFloat("#tryagain", Drop_Floor_Fluid);
			BFGNMFCNDBC().SetVector("<i>", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 41f, 23f));
			HFBJAOFLCJI().SetTexture("input", FPHEBLMINDA);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
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
			AELJLBOJAIL().SetFloat("_Value2", HBJJOCHGOPH);
			PGPEMMBJOOG().SetFloat("_EmissionColor", Fade);
			PGPEMMBJOOG().SetFloat("GlassDistortion", Intensity);
			if (DirectionFollowCameraZ)
			{
				float z = GetComponent<Camera>().transform.rotation.z;
				if (z > 1567f && z < 1586f)
				{
					HFBJAOFLCJI().SetFloat("mapselector.filter.rateduponly", z);
				}
				if (z < 554f)
				{
					JFDGLLEOPGB().SetFloat("_Value2", z);
				}
			}
			else
			{
				HKGAONMOBMH().SetFloat("other.dust0", DirectionX);
			}
			HEHKGPKLAKK().SetFloat("_Value", Speed);
			LDNADDJMIPK().SetFloat("SUCCESS! Item submitted! :D :D :D", Size);
			EPCGJFCCAFH().SetFloat("SubBass", Distortion);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", StormFlashOnOff);
			HEHKGPKLAKK().SetFloat("_ScreenResolution", DropOnOff);
			HKGAONMOBMH().SetFloat("maps.", _FixDistance);
			HFBJAOFLCJI().SetFloat("/", (!_Visualize) ? 0 : 0);
			HFBJAOFLCJI().SetFloat("menu.selectedlevelid", Drop_Near);
			AELJLBOJAIL().SetFloat("_ScreenResolution", Drop_Far);
			PGPEMMBJOOG().SetFloat("[GameScene] Checkpoints count: ", 1032f - Drop_With_Obj);
			IONHGBPGCHK().SetFloat("_Value4", Myst);
			HKGAONMOBMH().SetColor("player.circle", Myst_Color);
			PGPEMMBJOOG().SetFloat("[LevelEditorScene] Error: Timeout :S", Drop_Floor_Fluid);
			HFBJAOFLCJI().SetVector("{0}{1}{2}", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 163f, 1195f));
			LDNADDJMIPK().SetTexture("CameraFilterPack/Color_BrightContrastSaturation", FPHEBLMINDA);
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
			PGPEMMBJOOG().SetFloat("sfxVolume", HBJJOCHGOPH);
			HKGAONMOBMH().SetFloat("win", Fade);
			DNLMFEGJJDD().SetFloat("UseScanLine", Intensity);
			if (DirectionFollowCameraZ)
			{
				float z = GetComponent<Camera>().transform.rotation.z;
				if (z > 1964f && z < 1854f)
				{
					EPCGJFCCAFH().SetFloat("_Threshhold", z);
				}
				if (z < 311f)
				{
					ADGHJOHKEHG().SetFloat(" Owner called.", z);
				}
			}
			else
			{
				NBPKMLMCHFN.SetFloat("_Value1", DirectionX);
			}
			LDNADDJMIPK().SetFloat("PunRespawn", Speed);
			EPCGJFCCAFH().SetFloat("{0}", Size);
			DNLMFEGJJDD().SetFloat("[MapEditor] Openning ", Distortion);
			HEHKGPKLAKK().SetFloat("FinalScoreText", StormFlashOnOff);
			HEHKGPKLAKK().SetFloat("_TimeX", DropOnOff);
			HEHKGPKLAKK().SetFloat("NewIconFileSelector", _FixDistance);
			EPCGJFCCAFH().SetFloat("RoomNameText", (!_Visualize) ? 1 : 1);
			JFDGLLEOPGB().SetFloat("Right", Drop_Near);
			DNLMFEGJJDD().SetFloat("HightScoreMaxPointsText", Drop_Far);
			HEHKGPKLAKK().SetFloat("_FarCamera", 1983f - Drop_With_Obj);
			ADGHJOHKEHG().SetFloat("CameraFilterPack/BlurTiltShift", Myst);
			LDNADDJMIPK().SetColor("_Value2", Myst_Color);
			PGPEMMBJOOG().SetFloat("Bad parameters for getstring! Use <key> <value>", Drop_Floor_Fluid);
			ADGHJOHKEHG().SetVector("LevelEditor/icons", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 382f, 1302f));
			DNLMFEGJJDD().SetTexture("float,10", FPHEBLMINDA);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
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
		FPHEBLMINDA = Resources.Load("-help") as Texture2D;
		SCShader = Shader.Find("#tryagain");
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
			ADGHJOHKEHG().SetFloat("local CheckCondition = function()", HBJJOCHGOPH);
			HEHKGPKLAKK().SetFloat("[LevelEditorScene] Error: You're not logged into Steam!", Fade);
			ADGHJOHKEHG().SetFloat("achievements.26.progress", Intensity);
			if (DirectionFollowCameraZ)
			{
				float z = GetComponent<Camera>().transform.rotation.z;
				if (z > 493f && z < 593f)
				{
					DNLMFEGJJDD().SetFloat("steamid", z);
				}
				if (z < 953f)
				{
					EPCGJFCCAFH().SetFloat("ENABLE_EYE_ADAPTATION", z);
				}
			}
			else
			{
				JFDGLLEOPGB().SetFloat(" at ", DirectionX);
			}
			PGPEMMBJOOG().SetFloat("_ScreenResolution", Speed);
			BFGNMFCNDBC().SetFloat("Speed is a lerp speed of color changing. Greater values means faster changing. 0 - intant change", Size);
			EPCGJFCCAFH().SetFloat("th", Distortion);
			HKGAONMOBMH().SetFloat("CameraFilterPack/FX_Screens", StormFlashOnOff);
			NBPKMLMCHFN.SetFloat("_TimeX", DropOnOff);
			LDNADDJMIPK().SetFloat(": ", _FixDistance);
			HKGAONMOBMH().SetFloat("_TimeX", _Visualize ? 1 : 0);
			EPCGJFCCAFH().SetFloat("ReplyMatch is false! ", Drop_Near);
			HKGAONMOBMH().SetFloat("id", Drop_Far);
			ADGHJOHKEHG().SetFloat("_TimeX", 557f - Drop_With_Obj);
			NBPKMLMCHFN.SetFloat("_Value", Myst);
			BFGNMFCNDBC().SetColor("_Value", Myst_Color);
			HEHKGPKLAKK().SetFloat("default", Drop_Floor_Fluid);
			HEHKGPKLAKK().SetVector("To {0} at Index {1} \n", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 506f, 1378f));
			PGPEMMBJOOG().SetTexture("player.goldcrystal", FPHEBLMINDA);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK());
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
