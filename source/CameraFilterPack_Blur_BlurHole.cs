// CameraFilterPack_Blur_BlurHole
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Blur/Blur Hole")]
[ExecuteInEditMode]
public class CameraFilterPack_Blur_BlurHole : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	[Range(1f, 16f)]
	public float Size = 10f;

	[Range(0f, 1f)]
	public float _Radius = 0.25f;

	[Range(0f, 4f)]
	public float _SpotSize = 1f;

	[Range(0f, 1f)]
	public float _CenterX = 0.5f;

	[Range(0f, 1f)]
	public float _CenterY = 0.5f;

	[Range(0f, 1f)]
	public float _AlphaBlur = 1f;

	[Range(0f, 1f)]
	public float _AlphaBlurInside;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

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

	private void LEAHIBJDMBI()
	{
	}

	[SpecialName]
	private Material LONNIJMNKFB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material FKEOGPDLBDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 548f)
			{
				HBJJOCHGOPH = 541f;
			}
			NJDIODJNGGA().SetFloat("{0:0} minute{1}, ", HBJJOCHGOPH);
			JIBOKBCPDLC().SetFloat("_Extra2", Size);
			HCGJCMDJPGD().SetFloat("_TimeX", _Radius);
			EJDPNJAEAKJ().SetFloat("_CenterX", _SpotSize);
			FKEOGPDLBDD().SetFloat("Sending vacant view IDs. Length: ", _CenterX);
			LENEJAGLCNL().SetFloat("#alreadyexist", _CenterY);
			FKEOGPDLBDD().SetFloat("[Down-Left]", _AlphaBlur);
			EFDEIFCDAFG().SetFloat(" ", _AlphaBlurInside);
			NBPKMLMCHFN.SetVector("SaveButton", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
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
			if (HBJJOCHGOPH > 1160f)
			{
				HBJJOCHGOPH = 1448f;
			}
			ADBKPGFMNKO().SetFloat("DeleteButton", HBJJOCHGOPH);
			MLMKCOINOOH().SetFloat("0 seconds", Size);
			NJDIODJNGGA().SetFloat(".jpg", _Radius);
			DEFBJOCJJKF().SetFloat("PossibleMapPointsText", _SpotSize);
			MLMKCOINOOH().SetFloat("_FgOverlap", _CenterX);
			LONNIJMNKFB().SetFloat(".status", _CenterY);
			OIIDAKBILMI().SetFloat("s", _AlphaBlur);
			AELJLBOJAIL().SetFloat("CameraFilterPack/FX_Hexagon_Black", _AlphaBlurInside);
			FOOCJIDNGBB().SetVector("_Vignetting2", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BOLBPPHJBMI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FEKECCBFGMI()
	{
		SCShader = Shader.Find("_Offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material HNFFHCLNBDN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material EJDPNJAEAKJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void LJIHHJOAJCN()
	{
	}

	[SpecialName]
	private Material ADBKPGFMNKO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-126);
		}
		return BJFKDHHMLJH;
	}

	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1537f)
			{
				HBJJOCHGOPH = 1749f;
			}
			AELJLBOJAIL().SetFloat("_BaseTex", HBJJOCHGOPH);
			CIAFLBFJLEJ().SetFloat("SlidingArea", Size);
			LENEJAGLCNL().SetFloat("<color=#", _Radius);
			FKEOGPDLBDD().SetFloat("settings.enablehitsoundsinrelax", _SpotSize);
			ADBKPGFMNKO().SetFloat("CameraFilterPack/Colors_HUE_Rotate", _CenterX);
			DEFBJOCJJKF().SetFloat("RecordButton", _CenterY);
			HCGJCMDJPGD().SetFloat("white", _AlphaBlur);
			EJDPNJAEAKJ().SetFloat("_TimeX", _AlphaBlurInside);
			HNFFHCLNBDN().SetVector("\n", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material OGMEGHKECAH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material DEFBJOCJJKF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void NNCCPEBIAKH()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ICILLMAKLMI()
	{
		SCShader = Shader.Find("help");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BGFJOEPFOPM()
	{
	}

	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1693f)
			{
				HBJJOCHGOPH = 21f;
			}
			HCGJCMDJPGD().SetFloat("_Value2", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("CameraFilterPack/FX_Psycho", Size);
			EFDEIFCDAFG().SetFloat("-", _Radius);
			HCGJCMDJPGD().SetFloat("In Main Menu", _SpotSize);
			LENEJAGLCNL().SetFloat(") then the masterserver requests a disconnect!", _CenterX);
			ADBKPGFMNKO().SetFloat("CameraFilterPack/Special_Bubble", _CenterY);
			HHIFMIPPMPF().SetFloat("CameraFilterPack/Atmosphere_Fog", _AlphaBlur);
			EFDEIFCDAFG().SetFloat(".GoalProgress", _AlphaBlurInside);
			OIIDAKBILMI().SetVector("HighScaleShot", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GCHBGCGBMCK()
	{
	}

	private void FJNCHGLIEMA()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MFMIODIAKNI()
	{
	}

	private void CCPEDDLAMIB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material OIIDAKBILMI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)81;
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

	private void OBAEDJJDCPN()
	{
	}

	private void DLIJFEGIEKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 317f)
			{
				HBJJOCHGOPH = 191f;
			}
			HNFFHCLNBDN().SetFloat("_Value2", HBJJOCHGOPH);
			ADBKPGFMNKO().SetFloat("_Offsets", Size);
			NBPKMLMCHFN.SetFloat("_MainTex2", _Radius);
			HCGJCMDJPGD().SetFloat("Joystick1Button5", _SpotSize);
			FKEOGPDLBDD().SetFloat("896296812", _CenterX);
			OGMEGHKECAH().SetFloat("_Visualize", _CenterY);
			AELJLBOJAIL().SetFloat("Editor/", _AlphaBlur);
			DEFBJOCJJKF().SetFloat("_MainTex2", _AlphaBlurInside);
			AELJLBOJAIL().SetVector("_Value2", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IFJDKDFLGBG()
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
			if (HBJJOCHGOPH > 1294f)
			{
				HBJJOCHGOPH = 834f;
			}
			FKEOGPDLBDD().SetFloat("D-Pad Up", HBJJOCHGOPH);
			ADBKPGFMNKO().SetFloat("_TimeX", Size);
			HEINDEMCGIK().SetFloat("grid", _Radius);
			HNFFHCLNBDN().SetFloat("_EmissionColor", _SpotSize);
			HHIFMIPPMPF().SetFloat("RULES", _CenterX);
			ADBKPGFMNKO().SetFloat("open", _CenterY);
			MLMKCOINOOH().SetFloat("Screen Space Reflections", _AlphaBlur);
			LONNIJMNKFB().SetFloat("_Distortion", _AlphaBlurInside);
			OIIDAKBILMI().SetVector("CameraFilterPack/Light_Rainbow", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FNCDAPDOBBI()
	{
		SCShader = Shader.Find(" : ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LCJHDLKJEOM()
	{
	}

	private void DDFCIOMKEEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1650f)
			{
				HBJJOCHGOPH = 506f;
			}
			OGMEGHKECAH().SetFloat("skin.", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("_Blend", Size);
			HNFFHCLNBDN().SetFloat("_Offsets", _Radius);
			NJDIODJNGGA().SetFloat("Room: '{0}' {1},{2} {4}/{3} players.", _SpotSize);
			AELJLBOJAIL().SetFloat("_SceneFogParams", _CenterX);
			LENEJAGLCNL().SetFloat("_TimeX", _CenterY);
			LENEJAGLCNL().SetFloat("LevelNameInputField", _AlphaBlur);
			NJDIODJNGGA().SetFloat("_Value4", _AlphaBlurInside);
			LENEJAGLCNL().SetVector("CameraFilterPack/TV_ARCADE_Fast", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FOOCJIDNGBB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material JIBOKBCPDLC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void COOHIILCOCO()
	{
		SCShader = Shader.Find("Testing, a toggle has toggled [");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1226f)
			{
				HBJJOCHGOPH = 1588f;
			}
			EFDEIFCDAFG().SetFloat("Circle", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("No info", Size);
			NJDIODJNGGA().SetFloat("ConnectToMaster() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", _Radius);
			ADBKPGFMNKO().SetFloat("ResourceFileSelector", _SpotSize);
			ADBKPGFMNKO().SetFloat("_SampleScale", _CenterX);
			JIBOKBCPDLC().SetFloat("_Value4", _CenterY);
			NBPKMLMCHFN.SetFloat("Set Sun Emission", _AlphaBlur);
			HNFFHCLNBDN().SetFloat("float,1", _AlphaBlurInside);
			ADBKPGFMNKO().SetVector("[DiscordController] Connected to {0}#{1}: {2}", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AEDDNDHCLNN()
	{
		SCShader = Shader.Find("_Color");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FMNPFCHBLJF()
	{
		SCShader = Shader.Find("DPADHOR");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KFACDBHDAOD()
	{
	}

	[SpecialName]
	private Material FOOCJIDNGBB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return BJFKDHHMLJH;
	}

	private void JONGNKNLLND()
	{
		SCShader = Shader.Find("pointBuffer");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NFEDLAOPHML()
	{
	}

	private void LBAJLLFMMMP()
	{
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HMPGIFBJFIK()
	{
		SCShader = Shader.Find(" ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material EFDEIFCDAFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material MLMKCOINOOH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void MGMAOBPPOBJ()
	{
		SCShader = Shader.Find("move");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DLMPALHKMON()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GPHPJIDGEPI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 195f)
			{
				HBJJOCHGOPH = 185f;
			}
			FKEOGPDLBDD().SetFloat("maps.", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("CameraFilterPack/FX_Psycho", Size);
			LENEJAGLCNL().SetFloat("runas", _Radius);
			EFDEIFCDAFG().SetFloat("CameraFilterPack/Distortion_Noise", _SpotSize);
			HHIFMIPPMPF().SetFloat("offsets", _CenterX);
			EFDEIFCDAFG().SetFloat("_TimeX", _CenterY);
			LONNIJMNKFB().SetFloat("-1", _AlphaBlur);
			HNFFHCLNBDN().SetFloat("Joystick1Button12", _AlphaBlurInside);
			CIAFLBFJLEJ().SetVector("SetPlayerDistance", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
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
			if (HBJJOCHGOPH > 234f)
			{
				HBJJOCHGOPH = 1446f;
			}
			OIIDAKBILMI().SetFloat(".progress", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat(".workshop.json", Size);
			FKEOGPDLBDD().SetFloat("_Threshhold", _Radius);
			HNFFHCLNBDN().SetFloat("Items/", _SpotSize);
			OGMEGHKECAH().SetFloat("menu.selectedplaymode", _CenterX);
			FKEOGPDLBDD().SetFloat("_Green_R", _CenterY);
			NJDIODJNGGA().SetFloat("float,0", _AlphaBlur);
			MLMKCOINOOH().SetFloat("float,0", _AlphaBlurInside);
			HCGJCMDJPGD().SetVector("_Value4", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MAOCOEGAFND()
	{
	}

	private void FIKFJDFELIP()
	{
		SCShader = Shader.Find("rd");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1200f)
			{
				HBJJOCHGOPH = 1368f;
			}
			HHIFMIPPMPF().SetFloat("Tab2Content", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("_Value2", Size);
			OIIDAKBILMI().SetFloat("_TimeX", _Radius);
			FOOCJIDNGBB().SetFloat("CameraFilterPack/Drawing_BluePrint", _SpotSize);
			CIAFLBFJLEJ().SetFloat("_TapHigh", _CenterX);
			LENEJAGLCNL().SetFloat("_TimeX", _CenterY);
			MLMKCOINOOH().SetFloat("offsets", _AlphaBlur);
			HCGJCMDJPGD().SetFloat("SaveButton", _AlphaBlurInside);
			FKEOGPDLBDD().SetVector("setfloat", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1259f)
			{
				HBJJOCHGOPH = 1879f;
			}
			DEFBJOCJJKF().SetFloat("Set sun emission (glow)", HBJJOCHGOPH);
			MLMKCOINOOH().SetFloat("_Value1", Size);
			NJDIODJNGGA().SetFloat("Adding player twice: ", _Radius);
			HEINDEMCGIK().SetFloat("rarity", _SpotSize);
			OGMEGHKECAH().SetFloat("_Value2", _CenterX);
			HCGJCMDJPGD().SetFloat("_NoiseTex", _CenterY);
			HCGJCMDJPGD().SetFloat("Mouse Wheel Down", _AlphaBlur);
			HEINDEMCGIK().SetFloat("_TimeX", _AlphaBlurInside);
			MLMKCOINOOH().SetVector("_Offset", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BKGJOECFMID()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NPLCENPNJBM()
	{
		SCShader = Shader.Find("_ClutTex");
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

	private void IFIHBNJKEKD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LCHBFNIPBHB()
	{
	}

	[SpecialName]
	private Material HEINDEMCGIK()
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
			if (HBJJOCHGOPH > 900f)
			{
				HBJJOCHGOPH = 432f;
			}
			HCGJCMDJPGD().SetFloat("DPADHOR", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("SetSpeed", Size);
			HCGJCMDJPGD().SetFloat("_Offsets", _Radius);
			EFDEIFCDAFG().SetFloat("Hidden/DepthOfField/MedianFilter", _SpotSize);
			FKEOGPDLBDD().SetFloat("_Value", _CenterX);
			HCGJCMDJPGD().SetFloat("_Value4", _CenterY);
			NJDIODJNGGA().SetFloat("JoinButton", _AlphaBlur);
			NJDIODJNGGA().SetFloat("Committing changes...", _AlphaBlurInside);
			HNFFHCLNBDN().SetVector("_TimeX", new Vector2(Screen.width, Screen.height));
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

	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 982f)
			{
				HBJJOCHGOPH = 257f;
			}
			FKEOGPDLBDD().SetFloat("There are too many cells created by your subdivision options. Maximum allowed number of cells is ", HBJJOCHGOPH);
			NJDIODJNGGA().SetFloat("_Value4", Size);
			HNFFHCLNBDN().SetFloat("Players NetIDs:", _Radius);
			NBPKMLMCHFN.SetFloat("Please attach component to a Graphical UI component", _SpotSize);
			HNFFHCLNBDN().SetFloat("value", _CenterX);
			ADBKPGFMNKO().SetFloat("_Value", _CenterY);
			EJDPNJAEAKJ().SetFloat("Right", _AlphaBlur);
			MLMKCOINOOH().SetFloat("VIGNETTE_CLASSIC", _AlphaBlurInside);
			HEINDEMCGIK().SetVector("Gameplay/sun", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 833f)
			{
				HBJJOCHGOPH = 1780f;
			}
			ADBKPGFMNKO().SetFloat("ns", HBJJOCHGOPH);
			JIBOKBCPDLC().SetFloat(". Client is not the MasterClient in this room.", Size);
			OIIDAKBILMI().SetFloat("5;6;7;8;11;12;18;19;20;22x6;44x1", _Radius);
			HHIFMIPPMPF().SetFloat("[Left]", _SpotSize);
			NJDIODJNGGA().SetFloat("\\", _CenterX);
			HCGJCMDJPGD().SetFloat("MapEnd", _CenterY);
			EFDEIFCDAFG().SetFloat("_Value2", _AlphaBlur);
			OGMEGHKECAH().SetFloat("CameraFilterPack_AAA_Blood_Hit1", _AlphaBlurInside);
			JIBOKBCPDLC().SetVector("Clears all text from the debug console", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 306f)
			{
				HBJJOCHGOPH = 1880f;
			}
			ADBKPGFMNKO().SetFloat("_Value", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("_Value", Size);
			EFDEIFCDAFG().SetFloat("CameraFilterPack/Colors_DarkColor", _Radius);
			HEINDEMCGIK().SetFloat("menu.playedpage", _SpotSize);
			LENEJAGLCNL().SetFloat("_TimeX", _CenterX);
			ADBKPGFMNKO().SetFloat("<b>", _CenterY);
			JIBOKBCPDLC().SetFloat("_Value2", _AlphaBlur);
			FKEOGPDLBDD().SetFloat("_TimeX", _AlphaBlurInside);
			MLMKCOINOOH().SetVector("#no", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 563f)
			{
				HBJJOCHGOPH = 1884f;
			}
			EJDPNJAEAKJ().SetFloat("_Value", HBJJOCHGOPH);
			FOOCJIDNGBB().SetFloat("VoteDownToggle", Size);
			JIBOKBCPDLC().SetFloat("player.neon", _Radius);
			AELJLBOJAIL().SetFloat("_TimeX", _SpotSize);
			HNFFHCLNBDN().SetFloat("HandsCountSlider", _CenterX);
			FKEOGPDLBDD().SetFloat("_Amount", _CenterY);
			EJDPNJAEAKJ().SetFloat("_Speed", _AlphaBlur);
			ADBKPGFMNKO().SetFloat("_Distortion", _AlphaBlurInside);
			EFDEIFCDAFG().SetVector("Joystick1Button8", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KCDOMIJBFLL()
	{
	}

	private void POJFHDFJOPE()
	{
	}

	private void MJNPIDGNJMK()
	{
	}

	private void LBPCODPOJAH()
	{
	}

	private void LIEGJOHINGC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OKLAJINHPAN()
	{
		SCShader = Shader.Find("0.00");
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
			NBPKMLMCHFN.SetFloat("_Distortion", Size);
			NBPKMLMCHFN.SetFloat("_Radius", _Radius);
			NBPKMLMCHFN.SetFloat("_SpotSize", _SpotSize);
			NBPKMLMCHFN.SetFloat("_CenterX", _CenterX);
			NBPKMLMCHFN.SetFloat("_CenterY", _CenterY);
			NBPKMLMCHFN.SetFloat("_Alpha", _AlphaBlur);
			NBPKMLMCHFN.SetFloat("_Alpha2", _AlphaBlurInside);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1715f)
			{
				HBJJOCHGOPH = 1936f;
			}
			FKEOGPDLBDD().SetFloat("/", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("player.xp", Size);
			JIBOKBCPDLC().SetFloat("_TimeX", _Radius);
			HNFFHCLNBDN().SetFloat(";", _SpotSize);
			HCGJCMDJPGD().SetFloat("settings.gamemessagesduration", _CenterX);
			OGMEGHKECAH().SetFloat("menu.tabid", _CenterY);
			LONNIJMNKFB().SetFloat("StartButton", _AlphaBlur);
			CIAFLBFJLEJ().SetFloat(" (inactive)", _AlphaBlurInside);
			JIBOKBCPDLC().SetVector("/", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PKBENONAOOL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IMGGCJICLHK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NAALCEPIHCH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FABKIGNFECE()
	{
	}

	[SpecialName]
	private Material CIAFLBFJLEJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void MGFFNGEGFDC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EHCGBJDFMHG()
	{
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/BlurHole");
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
			if (HBJJOCHGOPH > 943f)
			{
				HBJJOCHGOPH = 182f;
			}
			HEINDEMCGIK().SetFloat("ChallengesButton", HBJJOCHGOPH);
			OIIDAKBILMI().SetFloat("FrostCanvas", Size);
			FKEOGPDLBDD().SetFloat("[LevelEditorScene] Updated", _Radius);
			CIAFLBFJLEJ().SetFloat("#", _SpotSize);
			ADBKPGFMNKO().SetFloat("_ExposureAdjustment", _CenterX);
			OIIDAKBILMI().SetFloat("SetEnvSpriteImage", _CenterY);
			HHIFMIPPMPF().SetFloat("Item ", _AlphaBlur);
			FKEOGPDLBDD().SetFloat("Not sending leave operation. State is not 'Joined': ", _AlphaBlurInside);
			HHIFMIPPMPF().SetVector("_ScreenResolution", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HLDFOJMHKNL()
	{
	}

	private void IKMELABKBHO()
	{
	}

	private void DOOIKOEBBJB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 868f)
			{
				HBJJOCHGOPH = 227f;
			}
			FKEOGPDLBDD().SetFloat("_Value8", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("_Value", Size);
			FKEOGPDLBDD().SetFloat("menu.enableselectormusic", _Radius);
			HCGJCMDJPGD().SetFloat(" Also make sure to disable sprite packing for this sprite.", _SpotSize);
			HCGJCMDJPGD().SetFloat("_MainTex2", _CenterX);
			HNFFHCLNBDN().SetFloat("_Blend", _CenterY);
			HEINDEMCGIK().SetFloat("_Value3", _AlphaBlur);
			LENEJAGLCNL().SetFloat("_Dist", _AlphaBlurInside);
			FOOCJIDNGBB().SetVector("Editor/", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KCNIHHNMFFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1517f)
			{
				HBJJOCHGOPH = 792f;
			}
			JIBOKBCPDLC().SetFloat("Reset All", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Pixelisation_Sweater", Size);
			ADBKPGFMNKO().SetFloat("_Value4", _Radius);
			EFDEIFCDAFG().SetFloat("_Blend", _SpotSize);
			NBPKMLMCHFN.SetFloat("_SmoothStart", _CenterX);
			OIIDAKBILMI().SetFloat("maps.", _CenterY);
			HCGJCMDJPGD().SetFloat("EventSystem", _AlphaBlur);
			HCGJCMDJPGD().SetFloat("_ScreenResolution", _AlphaBlurInside);
			HNFFHCLNBDN().SetVector("UseFinalGlassColor", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CIAFLBFJLEJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1357f)
			{
				HBJJOCHGOPH = 1029f;
			}
			LONNIJMNKFB().SetFloat("Down ", HBJJOCHGOPH);
			EJDPNJAEAKJ().SetFloat("Selection Box", Size);
			AELJLBOJAIL().SetFloat("LevelNameText", _Radius);
			MLMKCOINOOH().SetFloat("_Near", _SpotSize);
			HEINDEMCGIK().SetFloat("_Distortion", _CenterX);
			DEFBJOCJJKF().SetFloat("_Value", _CenterY);
			NBPKMLMCHFN.SetFloat("?", _AlphaBlur);
			EJDPNJAEAKJ().SetFloat("winter2020", _AlphaBlurInside);
			AELJLBOJAIL().SetVector("Can't execute Disconnect() while not connected. Nothing changed. State: {0}", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CIAFLBFJLEJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CCLNNLCOPBL()
	{
		SCShader = Shader.Find("[Steamworks.NET] Packsize Test returned false, the wrong version of Steamworks.NET is being run in this platform.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EPEGAEGDJAM()
	{
		SCShader = Shader.Find("LeaderboardsButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LCDJFJIBADI()
	{
	}

	[SpecialName]
	private Material AELJLBOJAIL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void FDMAEPOHDMK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HHIFMIPPMPF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void JHPOIOELNCG()
	{
	}

	private void NEKCPLGFOFD()
	{
	}

	[SpecialName]
	private Material LENEJAGLCNL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return BJFKDHHMLJH;
	}

	private void BJOHDLNDFAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KDMANOEMOCA()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HMNLHMLILKD()
	{
	}

	private void NNPBKKBFDHH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HCGJCMDJPGD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-128);
		}
		return BJFKDHHMLJH;
	}

	private void HIPEHGNBJMN()
	{
		SCShader = Shader.Find("LeaderboardsButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 93f)
			{
				HBJJOCHGOPH = 1677f;
			}
			AELJLBOJAIL().SetFloat("_BlendTex", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat(".lastCheckpoint.lives", Size);
			AELJLBOJAIL().SetFloat("CameraFilterPack/OldFilm_Cutting1", _Radius);
			FKEOGPDLBDD().SetFloat("CameraFilterPack/FX_Ascii", _SpotSize);
			HNFFHCLNBDN().SetFloat("Cant send PickupItem spawn times to unknown targetPlayer.", _CenterX);
			NJDIODJNGGA().SetFloat("_Value4", _CenterY);
			NBPKMLMCHFN.SetFloat("_Value2", _AlphaBlur);
			NJDIODJNGGA().SetFloat("_Value", _AlphaBlurInside);
			NBPKMLMCHFN.SetVector("settings.arcshitsoundtimedelay", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JKFDDNMPOJH()
	{
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1073f)
			{
				HBJJOCHGOPH = 1065f;
			}
			CIAFLBFJLEJ().SetFloat("_Value", HBJJOCHGOPH);
			CIAFLBFJLEJ().SetFloat("s", Size);
			NJDIODJNGGA().SetFloat("lobby '{0}'[{1}]", _Radius);
			HEINDEMCGIK().SetFloat("_Value3", _SpotSize);
			DEFBJOCJJKF().SetFloat("?", _CenterX);
			HCGJCMDJPGD().SetFloat("...", _CenterY);
			JIBOKBCPDLC().SetFloat("_Near", _AlphaBlur);
			CIAFLBFJLEJ().SetFloat("_Offsets", _AlphaBlurInside);
			ADBKPGFMNKO().SetVector("/icon", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
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

	private void GHILDCBCDJI()
	{
	}

	[SpecialName]
	private Material NJDIODJNGGA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return BJFKDHHMLJH;
	}

	private void JIAAFKOPEKO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1299f)
			{
				HBJJOCHGOPH = 228f;
			}
			LENEJAGLCNL().SetFloat("OnSerialize", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat(",", Size);
			JIBOKBCPDLC().SetFloat("player.dragon", _Radius);
			HCGJCMDJPGD().SetFloat("Cant ask anyone else for PickupItem spawn times.", _SpotSize);
			DEFBJOCJJKF().SetFloat("NEW_ACHIEVEMENT_1_26", _CenterX);
			JIBOKBCPDLC().SetFloat("[ItemsHandler] Loading ", _CenterY);
			HEINDEMCGIK().SetFloat("Items", _AlphaBlur);
			CIAFLBFJLEJ().SetFloat("Jul", _AlphaBlurInside);
			FOOCJIDNGBB().SetVector("editor.", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
