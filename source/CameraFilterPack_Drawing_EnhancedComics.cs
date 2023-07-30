// CameraFilterPack_Drawing_EnhancedComics
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Drawing/EnhancedComics")]
[ExecuteInEditMode]
public class CameraFilterPack_Drawing_EnhancedComics : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Material BJFKDHHMLJH;

	[Range(0f, 1f)]
	public float DotSize = 0.15f;

	[Range(0f, 1f)]
	public float _ColorR = 0.9f;

	[Range(0f, 1f)]
	public float _ColorG = 0.4f;

	[Range(0f, 1f)]
	public float _ColorB = 0.4f;

	[Range(0f, 1f)]
	public float _Blood = 0.5f;

	[Range(0f, 1f)]
	public float _SmoothStart = 0.02f;

	[Range(0f, 1f)]
	public float _SmoothEnd = 0.1f;

	public Color ColorRGB = new Color(1f, 0f, 0f);

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

	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 488f)
			{
				HBJJOCHGOPH = 912f;
			}
			FHFLKLMFHOI().SetFloat("_BlurRadius", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat("offsets", DotSize);
			NBPKMLMCHFN.SetFloat("_EdgeWeight", _ColorR);
			CFEDGDGBCHE().SetFloat("_Value3", _ColorG);
			NJDIODJNGGA().SetFloat("A", _ColorB);
			NJDIODJNGGA().SetFloat(".lastCheckpoint.time", _Blood);
			NJDIODJNGGA().SetColor("Set Satellite Lerp Speed", ColorRGB);
			BFGNMFCNDBC().SetFloat("id", _SmoothStart);
			MCDGIILBNIF().SetFloat("Editor/", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1329f)
			{
				HBJJOCHGOPH = 1006f;
			}
			OKJOKHGJHGF().SetFloat("0", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("value", DotSize);
			DOHGBNPMBKG().SetFloat("#getrewardfailed: ", _ColorR);
			MCDGIILBNIF().SetFloat("CameraFilterPack/NightVision_4", _ColorG);
			NJDIODJNGGA().SetFloat("offline", _ColorB);
			ACHNOHCLGOO().SetFloat("Tab1Content", _Blood);
			NBPKMLMCHFN.SetColor(",0", ColorRGB);
			FHFLKLMFHOI().SetFloat("_ScreenResolution", _SmoothStart);
			AELJLBOJAIL().SetFloat("PLEASE WAIT", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BJOHDLNDFAD()
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
			if (HBJJOCHGOPH > 405f)
			{
				HBJJOCHGOPH = 1875f;
			}
			FHFLKLMFHOI().SetFloat("-1", HBJJOCHGOPH);
			EJDPNJAEAKJ().SetFloat("ReJoinRoom failed. A roomname is required. If you don't know one, how will you join?", DotSize);
			FHFLKLMFHOI().SetFloat("Vignette", _ColorR);
			NBPKMLMCHFN.SetFloat("curScn", _ColorG);
			HNICHJCGJOC().SetFloat("Tab1Content", _ColorB);
			MCDGIILBNIF().SetFloat("_Red_G", _Blood);
			NJDIODJNGGA().SetColor("_SmallTex", ColorRGB);
			EJDPNJAEAKJ().SetFloat(" cannot be used as a 3D LUT.", _SmoothStart);
			EJDPNJAEAKJ().SetFloat("SetSpeed", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
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
			if (HBJJOCHGOPH > 877f)
			{
				HBJJOCHGOPH = 131f;
			}
			NBPKMLMCHFN.SetFloat("Bad SegmentType passed in to CreateLineCap. Must be SegmentType.Start or SegmentType.End", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("menu.selectedplaymode", DotSize);
			EFDEIFCDAFG().SetFloat("_ScreenResolution", _ColorR);
			DKNJGHFLAIF().SetFloat("wss://", _ColorG);
			MCDGIILBNIF().SetFloat("Hidden/Image Effects/Cinematic/MotionBlur/Reconstruction", _ColorB);
			AELJLBOJAIL().SetFloat("_Value3", _Blood);
			NJDIODJNGGA().SetColor("SetParticlesCountPerBeat", ColorRGB);
			EFDEIFCDAFG().SetFloat("_History4LumaTex", _SmoothStart);
			EJDPNJAEAKJ().SetFloat("\" that takes ", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material NLFJGMBCICG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void PKLOBJHKFEO()
	{
		SCShader = Shader.Find("(((?<x>(?=[,\\r\\n]+))|\"(?<x>([^\"]|\"\")+)\"|(?<x>[^,\\r\\n]+)),?)");
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
			if (HBJJOCHGOPH > 1175f)
			{
				HBJJOCHGOPH = 1218f;
			}
			ACHNOHCLGOO().SetFloat("Items/", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("_MainTex2", DotSize);
			DOHGBNPMBKG().SetFloat("CameraFilterPack_Fly_VisionFX", _ColorR);
			FHFLKLMFHOI().SetFloat("_Red_C", _ColorG);
			EFDEIFCDAFG().SetFloat("settings.cameramovements", _ColorB);
			NJDIODJNGGA().SetFloat("OpSettings()", _Blood);
			CFEDGDGBCHE().SetColor("\\\\", ColorRGB);
			EJDPNJAEAKJ().SetFloat("_ScreenResolution", _SmoothStart);
			AELJLBOJAIL().SetFloat("Clears all text from the debug console", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NFEDLAOPHML()
	{
	}

	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 504f)
			{
				HBJJOCHGOPH = 1270f;
			}
			CFEDGDGBCHE().SetFloat("Keypad", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("CameraFilterPack/Blur_DitherOffset", DotSize);
			DOHGBNPMBKG().SetFloat("Received unknown status code: ", _ColorR);
			EJDPNJAEAKJ().SetFloat("player.orangearc", _ColorG);
			NLFJGMBCICG().SetFloat("_Rand", _ColorB);
			NBPKMLMCHFN.SetFloat("Data/Skins/", _Blood);
			HNICHJCGJOC().SetColor(". Verify the Prefab is in a Resources folder (and not in a subfolder)", ColorRGB);
			EJDPNJAEAKJ().SetFloat("CameraFilterPack_Atmosphere_Rain_FX", _SmoothStart);
			DBOLLHHMKKN().SetFloat("EnableRankedNotificationsToggle", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EJFJENFKLND()
	{
	}

	private void FDMAEPOHDMK()
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
			BJFKDHHMLJH.hideFlags = (HideFlags)98;
		}
		return BJFKDHHMLJH;
	}

	private void EDBEHEKMGFH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DGCGGKMNPLD()
	{
	}

	private void NJHJHBOJKIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 341f)
			{
				HBJJOCHGOPH = 1433f;
			}
			MCDGIILBNIF().SetFloat("_Value1", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("Ignored PU RPC, cause item is inactive. ", DotSize);
			DKKBFFHBHJE().SetFloat("colorB", _ColorR);
			DKKBFFHBHJE().SetFloat("CameraFilterPack/Drawing_Manga", _ColorG);
			OKJOKHGJHGF().SetFloat("_NoiseAmount", _ColorB);
			OKJOKHGJHGF().SetFloat("EnableRankedNotificationsToggle", _Blood);
			BFGNMFCNDBC().SetColor("{0} months ago", ColorRGB);
			DBOLLHHMKKN().SetFloat("ConfigVersionSlider", _SmoothStart);
			BFGNMFCNDBC().SetFloat("OnReadyClick", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MGMAOBPPOBJ()
	{
		SCShader = Shader.Find("bloomintencity:");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material EFDEIFCDAFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 449f)
			{
				HBJJOCHGOPH = 858f;
			}
			MCDGIILBNIF().SetFloat("TRACKING", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat(".lastCheckpoint.correctScore", DotSize);
			NLFJGMBCICG().SetFloat("_Visualize", _ColorR);
			NLFJGMBCICG().SetFloat("shader.crispwinter", _ColorG);
			EFDEIFCDAFG().SetFloat(" / Sample Count: ", _ColorB);
			DOHGBNPMBKG().SetFloat("value", _Blood);
			EJDPNJAEAKJ().SetColor("[ResourcesManager] Load text error: not found", ColorRGB);
			DBOLLHHMKKN().SetFloat("#creatingnewitem", _SmoothStart);
			DKKBFFHBHJE().SetFloat(".mp3", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FBPHNEJBDJN()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FABKIGNFECE()
	{
	}

	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1966f)
			{
				HBJJOCHGOPH = 1702f;
			}
			NLFJGMBCICG().SetFloat("Bad parameters for init! Use \"init\" or \"init <savename>\"", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat("_TimeX", DotSize);
			AELJLBOJAIL().SetFloat("CameraFilterPack/Distortion_Aspiration", _ColorR);
			FHFLKLMFHOI().SetFloat("NEW_ACHIEVEMENT_1_", _ColorG);
			NLFJGMBCICG().SetFloat("_ScreenResolution", _ColorB);
			EJDPNJAEAKJ().SetFloat("PAUSE [SPACE]", _Blood);
			MCDGIILBNIF().SetColor("_Distortion", ColorRGB);
			HNICHJCGJOC().SetFloat("5;6;7;8;11;12;18;19;20;22x6;44x1", _SmoothStart);
			MCDGIILBNIF().SetFloat("_AdditiveReflection", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1198f)
			{
				HBJJOCHGOPH = 379f;
			}
			BFGNMFCNDBC().SetFloat("_DiffuseColor", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("#availablechallenges", DotSize);
			BFGNMFCNDBC().SetFloat("value", _ColorR);
			NJDIODJNGGA().SetFloat("_ToneCurveRange", _ColorG);
			DOHGBNPMBKG().SetFloat("[DiscordController] Error {0}: {1}", _ColorB);
			CFEDGDGBCHE().SetFloat(" not exist", _Blood);
			ACHNOHCLGOO().SetColor("Hidden/Image Effects/Cinematic/AmbientOcclusion", ColorRGB);
			DKNJGHFLAIF().SetFloat("_ScratchOffsetScale", _SmoothStart);
			EFDEIFCDAFG().SetFloat("ERROR: Make sure your mod contains at leats one file!", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DKKBFFHBHJE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-124);
		}
		return BJFKDHHMLJH;
	}

	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1067f)
			{
				HBJJOCHGOPH = 1714f;
			}
			BFGNMFCNDBC().SetFloat("_Value", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("t", DotSize);
			AELJLBOJAIL().SetFloat("_SampleCount", _ColorR);
			DOHGBNPMBKG().SetFloat("#ok", _ColorG);
			BFGNMFCNDBC().SetFloat("Dance", _ColorB);
			AELJLBOJAIL().SetFloat("[Sound Manager] Audio clip is null, cannot play sound", _Blood);
			DKKBFFHBHJE().SetColor("float,1", ColorRGB);
			FHFLKLMFHOI().SetFloat("_Value", _SmoothStart);
			FHFLKLMFHOI().SetFloat("GameScene", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material CFEDGDGBCHE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-101);
		}
		return BJFKDHHMLJH;
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Drawing_EnhancedComics");
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

	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1642f)
			{
				HBJJOCHGOPH = 1826f;
			}
			EJDPNJAEAKJ().SetFloat("_Value", HBJJOCHGOPH);
			FHFLKLMFHOI().SetFloat("[PlayerBase] Loaded spawner data", DotSize);
			HNICHJCGJOC().SetFloat("_DepthLevel", _ColorR);
			NBPKMLMCHFN.SetFloat("/Segment-[Down]", _ColorG);
			EJDPNJAEAKJ().SetFloat("BitsData", _ColorB);
			NJDIODJNGGA().SetFloat("menu.selectedplaymode", _Blood);
			MCDGIILBNIF().SetColor("_EmissionGain", ColorRGB);
			NBPKMLMCHFN.SetFloat("ConnectToRegion() failed. Can only connect while in state 'Disconnected'. Current state: ", _SmoothStart);
			AELJLBOJAIL().SetFloat("_Bullet_7", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BMOFEBKGLFI()
	{
		SCShader = Shader.Find("ResetSpeed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IFIHBNJKEKD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1f)
			{
				HBJJOCHGOPH = 1447f;
			}
			BFGNMFCNDBC().SetFloat("5;6;7;8;11;12;18;19;20;22x6;44x1", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("#useticket", DotSize);
			ACHNOHCLGOO().SetFloat(". Client is not the MasterClient in this room.", _ColorR);
			DKKBFFHBHJE().SetFloat("Error: Someone else(", _ColorG);
			BFGNMFCNDBC().SetFloat("Malformed RPC; this should never occur. Content: ", _ColorB);
			HNICHJCGJOC().SetFloat("_Value2", _Blood);
			NJDIODJNGGA().SetColor("_Distortion", ColorRGB);
			NLFJGMBCICG().SetFloat("0.00/0.00", _SmoothStart);
			ACHNOHCLGOO().SetFloat("Fade", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material NJDIODJNGGA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-108);
		}
		return BJFKDHHMLJH;
	}

	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1799f)
			{
				HBJJOCHGOPH = 259f;
			}
			NBPKMLMCHFN.SetFloat("/icon", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("#{0:X2}{1:X2}{2:X2}", DotSize);
			MCDGIILBNIF().SetFloat("CameraFilterPack/Colors_RgbClamp", _ColorR);
			OKJOKHGJHGF().SetFloat("_Value4", _ColorG);
			FHFLKLMFHOI().SetFloat("CurrentTimeLabel", _ColorB);
			NBPKMLMCHFN.SetFloat("Xbox Home", _Blood);
			NJDIODJNGGA().SetColor("CurrentTimeLabel", ColorRGB);
			DKKBFFHBHJE().SetFloat("_BlurCoe", _SmoothStart);
			FHFLKLMFHOI().SetFloat("Joystick1Button0", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JOPCCCCHNLI()
	{
		SCShader = Shader.Find("513510");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 824f)
			{
				HBJJOCHGOPH = 428f;
			}
			AELJLBOJAIL().SetFloat("MainCamera", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("<b>Time</b>:", DotSize);
			AELJLBOJAIL().SetFloat("_ChromaticAberration", _ColorR);
			OKJOKHGJHGF().SetFloat("_ScreenResolution", _ColorG);
			FHFLKLMFHOI().SetFloat("_TimeX", _ColorB);
			EJDPNJAEAKJ().SetFloat("The new master starts a new round, cause we didn't start yet.", _Blood);
			EFDEIFCDAFG().SetColor("value", ColorRGB);
			DKNJGHFLAIF().SetFloat("#ok", _SmoothStart);
			OKJOKHGJHGF().SetFloat("_MainTex2", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1344f)
			{
				HBJJOCHGOPH = 1377f;
			}
			DOHGBNPMBKG().SetFloat("player.russia", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("null", DotSize);
			DOHGBNPMBKG().SetFloat("Illegal view ID:", _ColorR);
			HNICHJCGJOC().SetFloat("PlayMusic", _ColorG);
			AELJLBOJAIL().SetFloat("_TimeX", _ColorB);
			DBOLLHHMKKN().SetFloat("_DisplayVelocityScale", _Blood);
			CFEDGDGBCHE().SetColor("_EdgeWeight", ColorRGB);
			DOHGBNPMBKG().SetFloat("id", _SmoothStart);
			EJDPNJAEAKJ().SetFloat("Tab2Content", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FPHLDMMAOEF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PLBOFEPBPKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1649f)
			{
				HBJJOCHGOPH = 95f;
			}
			EJDPNJAEAKJ().SetFloat("The new master starts a new round, cause we didn't start yet.", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("[Right-Left]", DotSize);
			DOHGBNPMBKG().SetFloat("_Value4", _ColorR);
			DBOLLHHMKKN().SetFloat("_Distortion", _ColorG);
			NJDIODJNGGA().SetFloat("bans.viewed.", _ColorB);
			OKJOKHGJHGF().SetFloat("menu.tabid", _Blood);
			ACHNOHCLGOO().SetColor("_Near", ColorRGB);
			ACHNOHCLGOO().SetFloat("bool", _SmoothStart);
			DKNJGHFLAIF().SetFloat("#mapmustbecompletebeforesubmit", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1608f)
			{
				HBJJOCHGOPH = 517f;
			}
			NBPKMLMCHFN.SetFloat("Case-Sensitive", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("_ScreenResolution", DotSize);
			BFGNMFCNDBC().SetFloat("Type of observed is unknown when receiving.", _ColorR);
			OKJOKHGJHGF().SetFloat("mapselector.filter.favoriteonly", _ColorG);
			HNICHJCGJOC().SetFloat("NameText", _ColorB);
			DOHGBNPMBKG().SetFloat("Set Sun Sensitivity", _Blood);
			DBOLLHHMKKN().SetColor("Joystick1Button9", ColorRGB);
			DOHGBNPMBKG().SetFloat("[LocalizationService] Localization: ", _SmoothStart);
			MCDGIILBNIF().SetFloat("Particles/Additive", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1419f)
			{
				HBJJOCHGOPH = 1777f;
			}
			FHFLKLMFHOI().SetFloat("CameraFilterPack/Vision_AuraDistortion", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("_BlurTex", DotSize);
			NBPKMLMCHFN.SetFloat("bans.viewed.", _ColorR);
			EFDEIFCDAFG().SetFloat("_Value4", _ColorG);
			MCDGIILBNIF().SetFloat("bad", _ColorB);
			MCDGIILBNIF().SetFloat("HiddenToggle", _Blood);
			EFDEIFCDAFG().SetColor("closed", ColorRGB);
			CFEDGDGBCHE().SetFloat("/?player=", _SmoothStart);
			BFGNMFCNDBC().SetFloat("mapselector.filter.rateduponly", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GNMGIHFKJIJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JOONHGHGKKF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material AELJLBOJAIL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-95);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material EJDPNJAEAKJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void MJNPIDGNJMK()
	{
	}

	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 896f)
			{
				HBJJOCHGOPH = 193f;
			}
			ACHNOHCLGOO().SetFloat("speed", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("SetSatelliteInput", DotSize);
			CFEDGDGBCHE().SetFloat("_Value2", _ColorR);
			HNICHJCGJOC().SetFloat("setAF", _ColorG);
			EJDPNJAEAKJ().SetFloat("CameraFilterPack/Blend2Camera_Difference", _ColorB);
			NBPKMLMCHFN.SetFloat("ViewMenu", _Blood);
			NLFJGMBCICG().SetColor("_Radius", ColorRGB);
			CFEDGDGBCHE().SetFloat("UseScanLineSize", _SmoothStart);
			FHFLKLMFHOI().SetFloat("MenuScene", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LOMDIOLNFHI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material DKNJGHFLAIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-113);
		}
		return BJFKDHHMLJH;
	}

	private void PMPKMGKAAJH()
	{
		SCShader = Shader.Find(" ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OnDisable()
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
			if (HBJJOCHGOPH > 1329f)
			{
				HBJJOCHGOPH = 1863f;
			}
			OKJOKHGJHGF().SetFloat("settings.enablehitsoundsinnormal", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("GhostFade", DotSize);
			OKJOKHGJHGF().SetFloat("settings.showHP", _ColorR);
			DBOLLHHMKKN().SetFloat("maps.", _ColorG);
			DOHGBNPMBKG().SetFloat("_TimeX", _ColorB);
			EJDPNJAEAKJ().SetFloat("_Near", _Blood);
			DOHGBNPMBKG().SetColor("maps.", ColorRGB);
			OKJOKHGJHGF().SetFloat("_Value3", _SmoothStart);
			NJDIODJNGGA().SetFloat("14", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NAOLAJPDGIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HMNLHMLILKD()
	{
	}

	private void LADCJEIALMH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MJEFMIPLFAB()
	{
		SCShader = Shader.Find("AudioSampler");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1345f)
			{
				HBJJOCHGOPH = 762f;
			}
			DOHGBNPMBKG().SetFloat("player.watermelon", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("Can not SetMasterClient(). Not in room or in offlineMode.", DotSize);
			DKKBFFHBHJE().SetFloat("Joystick1Button7", _ColorR);
			DKKBFFHBHJE().SetFloat("CameraFilterPack_Paper4", _ColorG);
			DKKBFFHBHJE().SetFloat("1234332714", _ColorB);
			HNICHJCGJOC().SetFloat(">", _Blood);
			DKNJGHFLAIF().SetColor("_Value", ColorRGB);
			BFGNMFCNDBC().SetFloat("Hex value #RRGGBB", _SmoothStart);
			DOHGBNPMBKG().SetFloat("[Steamworks.NET] SteamAPI_Init() failed. Refer to Valve's documentation or the comment above this line for more information.", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DOHGBNPMBKG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void GPHPJIDGEPI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material ACHNOHCLGOO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)95;
		}
		return BJFKDHHMLJH;
	}

	private void JBNPEHMDCMI()
	{
	}

	private void GCHBGCGBMCK()
	{
	}

	[SpecialName]
	private Material HNICHJCGJOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-102);
		}
		return BJFKDHHMLJH;
	}

	private void JKFDDNMPOJH()
	{
		SCShader = Shader.Find("Bad parameters for setbool! Use <key> <value>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material MCDGIILBNIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void KKEOHFGKCIK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KLOLKEBAPFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OKLAJINHPAN()
	{
		SCShader = Shader.Find("ResourceFileSelector");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
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
			NBPKMLMCHFN.SetFloat("_DotSize", DotSize);
			NBPKMLMCHFN.SetFloat("_ColorR", _ColorR);
			NBPKMLMCHFN.SetFloat("_ColorG", _ColorG);
			NBPKMLMCHFN.SetFloat("_ColorB", _ColorB);
			NBPKMLMCHFN.SetFloat("_Blood", _Blood);
			NBPKMLMCHFN.SetColor("_ColorRGB", ColorRGB);
			NBPKMLMCHFN.SetFloat("_SmoothStart", _SmoothStart);
			NBPKMLMCHFN.SetFloat("_SmoothEnd", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material BFGNMFCNDBC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	private void HMPGIFBJFIK()
	{
		SCShader = Shader.Find(",");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1486f)
			{
				HBJJOCHGOPH = 315f;
			}
			NJDIODJNGGA().SetFloat("*.workshop.json", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("BlockCount", DotSize);
			MCDGIILBNIF().SetFloat("Tab2Content", _ColorR);
			DOHGBNPMBKG().SetFloat("PPI: ", _ColorG);
			NJDIODJNGGA().SetFloat("y", _ColorB);
			ACHNOHCLGOO().SetFloat("/icon", _Blood);
			OKJOKHGJHGF().SetColor(". We have no such PhotonView! Ignored this if you're leaving a room. State: ", ColorRGB);
			DOHGBNPMBKG().SetFloat("JITTER", _SmoothStart);
			BFGNMFCNDBC().SetFloat("ComboScoreText", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NKLIHNJCHOG()
	{
	}

	private void CCLNNLCOPBL()
	{
		SCShader = Shader.Find("CameraFilterPack_RainFX_Anm2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material FHFLKLMFHOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1447f)
			{
				HBJJOCHGOPH = 1449f;
			}
			BFGNMFCNDBC().SetFloat("[MapsData] Found ", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("USE_DIAG_SEARCH", DotSize);
			HNICHJCGJOC().SetFloat("_Bullet_10", _ColorR);
			BFGNMFCNDBC().SetFloat("CameraFilterPack/Drawing_Toon", _ColorG);
			AELJLBOJAIL().SetFloat("_Green_B", _ColorB);
			ACHNOHCLGOO().SetFloat("maps.", _Blood);
			AELJLBOJAIL().SetColor("_FarCamera", ColorRGB);
			CFEDGDGBCHE().SetFloat("_FresnelFade", _SmoothStart);
			BFGNMFCNDBC().SetFloat("[PlayerController] ", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 179f)
			{
				HBJJOCHGOPH = 1549f;
			}
			DKNJGHFLAIF().SetFloat("#useticket", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("#loopnumber ", DotSize);
			DOHGBNPMBKG().SetFloat("_Speed", _ColorR);
			EFDEIFCDAFG().SetFloat("OK", _ColorG);
			BFGNMFCNDBC().SetFloat("_Value12", _ColorB);
			EJDPNJAEAKJ().SetFloat("_TimeX", _Blood);
			FHFLKLMFHOI().SetColor("RPC: 'OnAwakeRPC' PhotonView: ", ColorRGB);
			EJDPNJAEAKJ().SetFloat("#no", _SmoothStart);
			EJDPNJAEAKJ().SetFloat("settings.shaders.bloomintencity", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LBPHCAMMAPB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CNGAJDBOCLJ()
	{
		SCShader = Shader.Find("USE_DIAG_SEARCH");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OCMKCBBCEFG()
	{
	}

	private void DAHFFNNIGML()
	{
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 353f)
			{
				HBJJOCHGOPH = 1873f;
			}
			EFDEIFCDAFG().SetFloat("OxOD.lastPath", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("clear", DotSize);
			MCDGIILBNIF().SetFloat("player.xp", _ColorR);
			DBOLLHHMKKN().SetFloat("IconImage", _ColorG);
			FHFLKLMFHOI().SetFloat(" takes from: ", _ColorB);
			EFDEIFCDAFG().SetFloat("_Value2", _Blood);
			AELJLBOJAIL().SetColor("_TimeX", ColorRGB);
			EFDEIFCDAFG().SetFloat("_TimeX", _SmoothStart);
			FHFLKLMFHOI().SetFloat("yyyy-MM-dd HH:mm:ss", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DBOLLHHMKKN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-87);
		}
		return BJFKDHHMLJH;
	}

	private void LIBGAKMKHJJ()
	{
		SCShader = Shader.Find("RPC: 'OnAwakeRPC' PhotonView: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 862f)
			{
				HBJJOCHGOPH = 1308f;
			}
			DOHGBNPMBKG().SetFloat("Floating point textures aren't supported on this device ({0})", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("[Right]", DotSize);
			NJDIODJNGGA().SetFloat("Horizontal", _ColorR);
			NBPKMLMCHFN.SetFloat("There is already a virtual button named ", _ColorG);
			FHFLKLMFHOI().SetFloat("maps.", _ColorB);
			NBPKMLMCHFN.SetFloat("Item invalid. Make sure your mod contains at leats one file.", _Blood);
			BFGNMFCNDBC().SetColor("settings.arcsdestroydelay", ColorRGB);
			FHFLKLMFHOI().SetFloat("team", _SmoothStart);
			CFEDGDGBCHE().SetFloat("_Fade", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EGEGNHLODAA()
	{
	}
}
