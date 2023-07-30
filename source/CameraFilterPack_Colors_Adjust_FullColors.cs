// CameraFilterPack_Colors_Adjust_FullColors
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/ColorsAdjust/FullColors")]
[ExecuteInEditMode]
public class CameraFilterPack_Colors_Adjust_FullColors : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(-200f, 200f)]
	public float Red_R = 100f;

	[Range(-200f, 200f)]
	public float Red_G;

	[Range(-200f, 200f)]
	public float Red_B;

	[Range(-200f, 200f)]
	public float Red_Constant;

	[Range(-200f, 200f)]
	public float Green_R;

	[Range(-200f, 200f)]
	public float Green_G = 100f;

	[Range(-200f, 200f)]
	public float Green_B;

	[Range(-200f, 200f)]
	public float Green_Constant;

	[Range(-200f, 200f)]
	public float Blue_R;

	[Range(-200f, 200f)]
	public float Blue_G;

	[Range(-200f, 200f)]
	public float Blue_B = 100f;

	[Range(-200f, 200f)]
	public float Blue_Constant;

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

	private void FJIKDJAMOHA()
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
			if (HBJJOCHGOPH > 85f)
			{
				HBJJOCHGOPH = 723f;
			}
			HCGJCMDJPGD().SetFloat("_EmissionGain", HBJJOCHGOPH);
			HEHKGPKLAKK().SetFloat("There are a few rules that you must accept before submitting your work. Please select \"RULES\" button, if you haven't read them yet.", Red_R / 1507f);
			ACHNOHCLGOO().SetFloat("CameraFilterPack/TV_Distorted", Red_G / 1153f);
			EJDPNJAEAKJ().SetFloat("UI", Red_B / 871f);
			EJDPNJAEAKJ().SetFloat("icon", Green_R / 1005f);
			NBMPPNFKFLB().SetFloat("_Green_G", Green_G / 1713f);
			BLMPMOIDGMG().SetFloat("_Value3", Green_B / 1610f);
			BKKJJJGADLM().SetFloat("--------------------------------", Blue_R / 1848f);
			KDMBOKLMADJ().SetFloat("_ScreenResolution", Blue_G / 451f);
			GJHLADDCMFF().SetFloat("_TimeX", Blue_B / 533f);
			HHIFMIPPMPF().SetFloat("]", Red_Constant / 1171f);
			EFDEIFCDAFG().SetFloat("OnPress", Green_Constant / 1998f);
			BKKJJJGADLM().SetFloat(". Possible scene loading in progress?", Blue_Constant / 364f);
			NBMPPNFKFLB().SetVector("inventory.itemscash", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 450f, 528f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material NBMPPNFKFLB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)100;
		}
		return BJFKDHHMLJH;
	}

	private void KDMKDEKCELE()
	{
		SCShader = Shader.Find("CameraFilterPack/Edge_Neon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KDJEJBBDILE()
	{
		if (!Application.isPlaying)
		{
		}
	}

	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1220f)
			{
				HBJJOCHGOPH = 1368f;
			}
			HHIFMIPPMPF().SetFloat("ReconnectAndRejoin() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", HBJJOCHGOPH);
			BKKJJJGADLM().SetFloat("_Fade", Red_R / 614f);
			JLHLHKPHDFO().SetFloat("Data/Skins/", Red_G / 1304f);
			NLFJGMBCICG().SetFloat("Tab1Content", Red_B / 1600f);
			BKKJJJGADLM().SetFloat("[Down]", Green_R / 107f);
			HKHBBBFLGJH().SetFloat("_Value2", Green_G / 1765f);
			NLFJGMBCICG().SetFloat("LT", Green_B / 79f);
			IGIAPKPKGPK().SetFloat("CameraFilterPack/Blend2Camera_Color", Blue_R / 1342f);
			HEHKGPKLAKK().SetFloat("GO==null", Blue_G / 1280f);
			BLMPMOIDGMG().SetFloat(": ", Blue_B / 1102f);
			LMLENGFLEBD().SetFloat("[TextSaver] Text saved to ", Red_Constant / 1420f);
			MLMKCOINOOH().SetFloat("]", Green_Constant / 520f);
			LDNADDJMIPK().SetFloat("settings.volume.editor", Blue_Constant / 1306f);
			KOHGPKOFEJO().SetVector("CameraFilterPack/Drawing_Manga_Flash_Color", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1766f, 1705f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HCGJCMDJPGD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-65);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KOHGPKOFEJO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HKHBBBFLGJH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)81;
		}
		return BJFKDHHMLJH;
	}

	private void PFNFPINPCMH()
	{
		if (!Application.isPlaying)
		{
		}
	}

	private void CGDMLHLJIDK()
	{
		SCShader = Shader.Find("CameraFilterPack/Blend2Camera_ColorDodge");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material NLFJGMBCICG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material OIIDAKBILMI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
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

	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1614f)
			{
				HBJJOCHGOPH = 134f;
			}
			NBMPPNFKFLB().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			BKKJJJGADLM().SetFloat("CameraFilterPack/Vision_Hell_Blood", Red_R / 485f);
			JLHLHKPHDFO().SetFloat("The given 2D texture ", Red_G / 1787f);
			HEHKGPKLAKK().SetFloat("LevelInfoInputField", Red_B / 559f);
			HKHBBBFLGJH().SetFloat(" ", Green_R / 405f);
			KDMBOKLMADJ().SetFloat("_ScreenResolution", Green_G / 380f);
			EFDEIFCDAFG().SetFloat("COMPLETED", Green_B / 588f);
			JLHLHKPHDFO().SetFloat("MapFolderInputField", Blue_R / 1707f);
			EJDPNJAEAKJ().SetFloat("_FarCamera", Blue_G / 884f);
			KDMBOKLMADJ().SetFloat("Drop_Far", Blue_B / 429f);
			KDMBOKLMADJ().SetFloat("Bad parameters for set! Use <language>", Red_Constant / 1021f);
			EPCGJFCCAFH().SetFloat("No Dispatcher exists in the scene. Actions will not be invoked!", Green_Constant / 920f);
			ACHNOHCLGOO().SetFloat("Remove Environment Object", Blue_Constant / 1302f);
			EFDEIFCDAFG().SetVector("_ForceYSwap", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1411f, 1125f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BKKJJJGADLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material IGIAPKPKGPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	private void COGBDFKOHKK()
	{
		if (!Application.isPlaying)
		{
		}
	}

	private void PNLKFANNOKO()
	{
		if (!Application.isPlaying)
		{
		}
	}

	private void CPAJLKHMOJB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LCJHDLKJEOM()
	{
		if (!Application.isPlaying)
		{
		}
	}

	[SpecialName]
	private Material EPCGJFCCAFH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	private void JHJGJJKELJM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material BKKJJJGADLM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-86);
		}
		return BJFKDHHMLJH;
	}

	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 149f)
			{
				HBJJOCHGOPH = 1948f;
			}
			BKKJJJGADLM().SetFloat("GameScene", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("Vertical", Red_R / 1041f);
			EMDFHOKEGNG().SetFloat("OK", Red_G / 722f);
			NBMPPNFKFLB().SetFloat("Subscribe: ", Red_B / 1663f);
			ACHNOHCLGOO().SetFloat(".jpg", Green_R / 1692f);
			BKKJJJGADLM().SetFloat("_Value3", Green_G / 1624f);
			EPCGJFCCAFH().SetFloat("/", Green_B / 1445f);
			BLMPMOIDGMG().SetFloat("ScoreText", Blue_R / 90f);
			HHIFMIPPMPF().SetFloat("MouseY", Blue_G / 1957f);
			HHIFMIPPMPF().SetFloat("If you host Photon yourself, make sure to start the 'Instance LoadBalancing' ", Blue_B / 433f);
			EJDPNJAEAKJ().SetFloat("_MainTex", Red_Constant / 621f);
			EHDJJANLINB().SetFloat("_Vignette", Green_Constant / 1101f);
			BLMPMOIDGMG().SetFloat("_Blue_C", Blue_Constant / 1327f);
			HCGJCMDJPGD().SetVector("_Alpha", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1604f, 272f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AIJGAJIOJDJ()
	{
		if (!Application.isPlaying)
		{
		}
	}

	[SpecialName]
	private Material MLMKCOINOOH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-82);
		}
		return BJFKDHHMLJH;
	}

	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1771f)
			{
				HBJJOCHGOPH = 740f;
			}
			LDNADDJMIPK().SetFloat("Tab2Content", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Editor/", Red_R / 1031f);
			KDMBOKLMADJ().SetFloat("/config", Red_G / 1996f);
			NLFJGMBCICG().SetFloat("inventory.selected.", Red_B / 317f);
			HEHKGPKLAKK().SetFloat("[MapsData] Bad map: ", Green_R / 59f);
			LDNADDJMIPK().SetFloat("Tab2Content", Green_G / 1424f);
			OIIDAKBILMI().SetFloat("_ScreenResolution", Green_B / 309f);
			DKNJGHFLAIF().SetFloat("[PlayerBase] Starting game from: ", Blue_R / 1720f);
			GJHLADDCMFF().SetFloat("tip", Blue_G / 477f);
			EPCGJFCCAFH().SetFloat("GameModeText", Blue_B / 485f);
			ACHNOHCLGOO().SetFloat(" argument(s): ", Red_Constant / 1140f);
			HCGJCMDJPGD().SetFloat("Is it practically possible?", Green_Constant / 1929f);
			HCGJCMDJPGD().SetFloat("CameraFilterPack/Blend2Camera_Lighten", Blue_Constant / 1411f);
			EMDFHOKEGNG().SetVector("SettingsCanvas", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1690f, 1819f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CCPEDDLAMIB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 226f)
			{
				HBJJOCHGOPH = 570f;
			}
			ACHNOHCLGOO().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			EHDJJANLINB().SetFloat("#", Red_R / 1811f);
			GJHLADDCMFF().SetFloat("_Value3", Red_G / 1089f);
			JLHLHKPHDFO().SetFloat("_Value", Red_B / 677f);
			GJHLADDCMFF().SetFloat("_TexelOffsetScale", Green_R / 199f);
			OIIDAKBILMI().SetFloat("_Value3", Green_G / 454f);
			EJDPNJAEAKJ().SetFloat("#yes", Green_B / 1517f);
			KOHGPKOFEJO().SetFloat("[PlayerController] ", Blue_R / 996f);
			EFDEIFCDAFG().SetFloat("itemdefid[0]", Blue_G / 1338f);
			EFDEIFCDAFG().SetFloat("MapEditorScene", Blue_B / 152f);
			LMLENGFLEBD().SetFloat("HandsCountSlider", Red_Constant / 1578f);
			EPCGJFCCAFH().SetFloat("_DistortionLevel", Green_Constant / 114f);
			EFDEIFCDAFG().SetFloat("DPADHOR", Blue_Constant / 709f);
			EFDEIFCDAFG().SetVector("Found best region: '", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 506f, 1612f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material ACHNOHCLGOO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material EMDFHOKEGNG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material EHDJJANLINB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)84;
		}
		return BJFKDHHMLJH;
	}

	private void MPJCMKFFKHH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 908f)
			{
				HBJJOCHGOPH = 1224f;
			}
			HCGJCMDJPGD().SetFloat("CameraFilterPack/FX_DigitalMatrixDistortion", HBJJOCHGOPH);
			LMLENGFLEBD().SetFloat("ready", Red_R / 1052f);
			EMDFHOKEGNG().SetFloat("Editor/", Red_G / 318f);
			ACHNOHCLGOO().SetFloat("ResetButton", Red_B / 908f);
			KOHGPKOFEJO().SetFloat("_Value2", Green_R / 1195f);
			OIIDAKBILMI().SetFloat("_Value6", Green_G / 1406f);
			EMDFHOKEGNG().SetFloat("_ScreenResolution", Green_B / 1143f);
			EJDPNJAEAKJ().SetFloat("SettingsCanvas", Blue_R / 1176f);
			HHIFMIPPMPF().SetFloat("_Value", Blue_G / 308f);
			GJHLADDCMFF().SetFloat("CONTRAST", Blue_B / 1094f);
			NLFJGMBCICG().SetFloat("\\n", Red_Constant / 857f);
			HEHKGPKLAKK().SetFloat("_Value2", Green_Constant / 86f);
			HCGJCMDJPGD().SetFloat("IDInputField", Blue_Constant / 273f);
			LMLENGFLEBD().SetVector("CameraFilterPack/FX_Screens", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 252f, 210f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EJDPNJAEAKJ());
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
			if (HBJJOCHGOPH > 246f)
			{
				HBJJOCHGOPH = 1586f;
			}
			MLMKCOINOOH().SetFloat("LoadPlayerEnvironment", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Received RPC \"", Red_R / 233f);
			BLMPMOIDGMG().SetFloat("_SizeY", Red_G / 1734f);
			EFDEIFCDAFG().SetFloat(".played", Red_B / 1382f);
			KOHGPKOFEJO().SetFloat("settings.volume.game", Green_R / 1038f);
			ACHNOHCLGOO().SetFloat("CameraFilterPack/3D_Anomaly", Green_G / 67f);
			JLHLHKPHDFO().SetFloat("Gameplay/sun", Green_B / 1275f);
			HEHKGPKLAKK().SetFloat("mapselector.orderby", Blue_R / 669f);
			LMLENGFLEBD().SetFloat("HPToggle", Blue_G / 798f);
			EMDFHOKEGNG().SetFloat("CameraFilterPack/FX_8bits", Blue_B / 1348f);
			NBMPPNFKFLB().SetFloat("#", Red_Constant / 1491f);
			MLMKCOINOOH().SetFloat(".lastCheckpoint.lives", Green_Constant / 865f);
			OIIDAKBILMI().SetFloat("BitsData", Blue_Constant / 1446f);
			OIIDAKBILMI().SetVector("_MotionBlurTmpCam", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 646f, 1210f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1190f)
			{
				HBJJOCHGOPH = 1900f;
			}
			HEHKGPKLAKK().SetFloat("Tab1Content", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("Editor/", Red_R / 895f);
			EHDJJANLINB().SetFloat("[PlayerBase] Config error: musicTime <= 0", Red_G / 1111f);
			MLMKCOINOOH().SetFloat("sounds/hit_normal", Red_B / 272f);
			GJHLADDCMFF().SetFloat("_ChangeGreen", Green_R / 1193f);
			IGIAPKPKGPK().SetFloat(" not exist", Green_G / 1347f);
			KDMBOKLMADJ().SetFloat("Failed to 'GetKeyCode' for key: ", Green_B / 1834f);
			IGIAPKPKGPK().SetFloat("nogamesfound", Blue_R / 498f);
			LDNADDJMIPK().SetFloat("BitsData", Blue_G / 594f);
			EHDJJANLINB().SetFloat("_Fade", Blue_B / 1373f);
			HKHBBBFLGJH().SetFloat("Toggle {0} is not part of ToggleGroup {1}", Red_Constant / 1138f);
			EFDEIFCDAFG().SetFloat("Save", Green_Constant / 1907f);
			IGIAPKPKGPK().SetFloat("UseFinalGlassColor", Blue_Constant / 770f);
			JLHLHKPHDFO().SetVector("float,50", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1975f, 1515f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void COIJKMKIEAK()
	{
		SCShader = Shader.Find("Items");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GHILDCBCDJI()
	{
		if (!Application.isPlaying)
		{
		}
	}

	private void NNFMIAFHMJM()
	{
		SCShader = Shader.Find("sounds/no_hit");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 136f)
			{
				HBJJOCHGOPH = 1485f;
			}
			DKNJGHFLAIF().SetFloat("settings.gamemessagesduration", HBJJOCHGOPH);
			HKHBBBFLGJH().SetFloat("sfxVolume", Red_R / 1398f);
			EMDFHOKEGNG().SetFloat("CameraFilterPack/3D_Myst", Red_G / 193f);
			JLHLHKPHDFO().SetFloat("_MainTex2", Red_B / 516f);
			IGIAPKPKGPK().SetFloat(".lastCheckpoint.powerupsScore", Green_R / 1391f);
			LDNADDJMIPK().SetFloat("Use \"/help\" for commands list", Green_G / 1364f);
			EMDFHOKEGNG().SetFloat("null", Green_B / 326f);
			EHDJJANLINB().SetFloat("#tryagain", Blue_R / 1429f);
			EHDJJANLINB().SetFloat("DPADVER", Blue_G / 1704f);
			GJHLADDCMFF().SetFloat("1", Blue_B / 1294f);
			EJDPNJAEAKJ().SetFloat("_LutTex", Red_Constant / 1672f);
			IGIAPKPKGPK().SetFloat("_FadeFX", Green_Constant / 227f);
			LMLENGFLEBD().SetFloat("_HalfResolution", Blue_Constant / 1203f);
			EFDEIFCDAFG().SetVector("CameraFilterPack/Blend2Camera_Subtract", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1901f, 433f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OMCLOFCJMPG()
	{
		if (!Application.isPlaying)
		{
		}
	}

	private void EGEPLFGKGLI()
	{
		SCShader = Shader.Find("float,1.5");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JAAJECBCCFM()
	{
		if (!Application.isPlaying)
		{
		}
	}

	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1859f)
			{
				HBJJOCHGOPH = 643f;
			}
			OIIDAKBILMI().SetFloat("_Value5", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("BloodAlternative3", Red_R / 1878f);
			HHIFMIPPMPF().SetFloat("BadgeImage", Red_G / 710f);
			EFDEIFCDAFG().SetFloat("Drop_With_Obj", Red_B / 1000f);
			KDMBOKLMADJ().SetFloat("Waiting to start", Green_R / 1173f);
			BLMPMOIDGMG().SetFloat("_MainTex2", Green_G / 1998f);
			DKNJGHFLAIF().SetFloat("Set EnvSprite Image", Green_B / 975f);
			OIIDAKBILMI().SetFloat("#ok", Blue_R / 951f);
			LDNADDJMIPK().SetFloat("Down ", Blue_G / 1585f);
			KDMBOKLMADJ().SetFloat("NewMapHandsCountSlider", Blue_B / 172f);
			BLMPMOIDGMG().SetFloat("_ScreenResolution", Red_Constant / 1778f);
			EPCGJFCCAFH().SetFloat("settings.cameramovements", Green_Constant / 648f);
			LMLENGFLEBD().SetFloat("Joystick1Button4", Blue_Constant / 102f);
			EHDJJANLINB().SetVector(".lastCheckpoint.currentCombo", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1665f, 1706f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BKKJJJGADLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PLBOFEPBPKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 192f)
			{
				HBJJOCHGOPH = 1378f;
			}
			EJDPNJAEAKJ().SetFloat("[Right]", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("sprite", Red_R / 407f);
			DKNJGHFLAIF().SetFloat("Can't set MaxPlayers when not in that room.", Red_G / 1051f);
			EJDPNJAEAKJ().SetFloat("Xbox Home", Red_B / 126f);
			EJDPNJAEAKJ().SetFloat("It seems some instantiation is not completed, as instantiation data is used. You should make sure instantiations are paused when calling this method. Cleaning now, despite this.", Green_R / 280f);
			EHDJJANLINB().SetFloat("_SecondTex", Green_G / 1320f);
			BKKJJJGADLM().SetFloat("_Green_G", Green_B / 1878f);
			HEHKGPKLAKK().SetFloat("LeaderboardsButton", Blue_R / 579f);
			EMDFHOKEGNG().SetFloat("/Saved Games/", Blue_G / 1748f);
			KOHGPKOFEJO().SetFloat("IconImage", Blue_B / 919f);
			IGIAPKPKGPK().SetFloat("LoadingStatusText", Red_Constant / 995f);
			EHDJJANLINB().SetFloat("_Value3", Green_Constant / 212f);
			EHDJJANLINB().SetFloat(" PhotonNetwork.networkingPeer.AvailableRegions ", Blue_Constant / 759f);
			EHDJJANLINB().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 180f, 627f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ICDBMJKMIKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 962f)
			{
				HBJJOCHGOPH = 1007f;
			}
			HEHKGPKLAKK().SetFloat("menu.selectedlevelid", HBJJOCHGOPH);
			EHDJJANLINB().SetFloat("_TimeX", Red_R / 872f);
			IGIAPKPKGPK().SetFloat("\r", Red_G / 1029f);
			EMDFHOKEGNG().SetFloat("_EmissionColor", Red_B / 113f);
			HEHKGPKLAKK().SetFloat(".", Green_R / 749f);
			ACHNOHCLGOO().SetFloat("_ScreenResolution", Green_G / 1038f);
			IGIAPKPKGPK().SetFloat("MapCreationCanvas", Green_B / 1790f);
			KOHGPKOFEJO().SetFloat("CameraFilterPack/OldFilm_Cutting2", Blue_R / 1488f);
			EHDJJANLINB().SetFloat("_Value", Blue_G / 905f);
			BLMPMOIDGMG().SetFloat("CameraFilterPack/Blend2Camera_Multiply", Blue_B / 1529f);
			KOHGPKOFEJO().SetFloat("/", Red_Constant / 747f);
			HHIFMIPPMPF().SetFloat("menu.relaxinfo", Green_Constant / 1756f);
			NBMPPNFKFLB().SetFloat("UseFinalGlassColor", Blue_Constant / 228f);
			EJDPNJAEAKJ().SetVector("_SecondTex", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1722f, 1782f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BKKJJJGADLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LMLENGFLEBD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)90;
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

	[SpecialName]
	private Material EJDPNJAEAKJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy;
		}
		return BJFKDHHMLJH;
	}

	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 801f)
			{
				HBJJOCHGOPH = 1468f;
			}
			BKKJJJGADLM().SetFloat("_TimeX", HBJJOCHGOPH);
			HKHBBBFLGJH().SetFloat("_Distortion", Red_R / 1504f);
			EMDFHOKEGNG().SetFloat("steamid", Red_G / 724f);
			BLMPMOIDGMG().SetFloat("MessageText", Red_B / 1551f);
			EFDEIFCDAFG().SetFloat("_Value3", Green_R / 1361f);
			DKNJGHFLAIF().SetFloat("[Up]", Green_G / 761f);
			EMDFHOKEGNG().SetFloat("_Value9", Green_B / 1099f);
			EPCGJFCCAFH().SetFloat(" not exist", Blue_R / 385f);
			NBMPPNFKFLB().SetFloat("_Saturation", Blue_G / 1219f);
			DKNJGHFLAIF().SetFloat("_SunThreshold", Blue_B / 242f);
			KDMBOKLMADJ().SetFloat("_Value3", Red_Constant / 1722f);
			BKKJJJGADLM().SetFloat("UpdateDownloadingProgress", Green_Constant / 1076f);
			HKHBBBFLGJH().SetFloat("_ScreenResolution", Blue_Constant / 358f);
			BKKJJJGADLM().SetVector("settings.volume.menu", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1496f, 232f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BLMPMOIDGMG());
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

	private void JKBMKPDGCHG()
	{
		SCShader = Shader.Find("menu.tabid");
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-73);
		}
		return BJFKDHHMLJH;
	}

	private void AKHCOBHHGJP()
	{
		SCShader = Shader.Find("score");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GKNKIIEALCH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CCLNNLCOPBL()
	{
		SCShader = Shader.Find("SettingsCanvas");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OBAEDJJDCPN()
	{
		if (!Application.isPlaying)
		{
		}
	}

	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 719f)
			{
				HBJJOCHGOPH = 1396f;
			}
			MLMKCOINOOH().SetFloat("settings.volume.game", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("w", Red_R / 594f);
			HCGJCMDJPGD().SetFloat("BadgeText", Red_G / 821f);
			BKKJJJGADLM().SetFloat("_Jitter", Red_B / 1541f);
			EJDPNJAEAKJ().SetFloat("\"", Green_R / 78f);
			BLMPMOIDGMG().SetFloat(",", Green_G / 474f);
			EPCGJFCCAFH().SetFloat("[NetworkManager] Exited", Green_B / 70f);
			MLMKCOINOOH().SetFloat("_Parasite", Blue_R / 745f);
			LMLENGFLEBD().SetFloat("[PlayerController] ", Blue_G / 1979f);
			OIIDAKBILMI().SetFloat("_EdgeThreshold", Blue_B / 823f);
			BLMPMOIDGMG().SetFloat("_ScreenResolution", Red_Constant / 1020f);
			HCGJCMDJPGD().SetFloat("_BlurRadius", Green_Constant / 472f);
			EFDEIFCDAFG().SetFloat("_Value2", Blue_Constant / 1431f);
			NBMPPNFKFLB().SetVector("Gameplay/sun", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 42f, 759f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NFEDLAOPHML()
	{
		if (!Application.isPlaying)
		{
		}
	}

	private void IIFCIDDJHPM()
	{
		if (!Application.isPlaying)
		{
		}
	}

	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1410f)
			{
				HBJJOCHGOPH = 826f;
			}
			HHIFMIPPMPF().SetFloat("OpSetPropertiesOfActor not sent. ActorNr must be > 0 and actorProperties != null.", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat(" (", Red_R / 930f);
			HKHBBBFLGJH().SetFloat("MenuScene", Red_G / 289f);
			EHDJJANLINB().SetFloat("D-Pad Down", Red_B / 1086f);
			LDNADDJMIPK().SetFloat("R:", Green_R / 767f);
			EPCGJFCCAFH().SetFloat("_Blue_R", Green_G / 583f);
			EJDPNJAEAKJ().SetFloat("_TimeX", Green_B / 613f);
			NLFJGMBCICG().SetFloat("input", Blue_R / 1696f);
			EFDEIFCDAFG().SetFloat("BadgeText", Blue_G / 73f);
			HEHKGPKLAKK().SetFloat("_Value2", Blue_B / 1798f);
			ACHNOHCLGOO().SetFloat(" ", Red_Constant / 1293f);
			EHDJJANLINB().SetFloat("_ScreenResolution", Green_Constant / 1391f);
			EJDPNJAEAKJ().SetFloat(" not exist", Blue_Constant / 345f);
			KDMBOKLMADJ().SetVector("tagElement", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 768f, 1515f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BKKJJJGADLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1628f)
			{
				HBJJOCHGOPH = 592f;
			}
			EHDJJANLINB().SetFloat("Connection error: ", HBJJOCHGOPH);
			EMDFHOKEGNG().SetFloat("editor.", Red_R / 1481f);
			MLMKCOINOOH().SetFloat("_Value2", Red_G / 1963f);
			HHIFMIPPMPF().SetFloat("offsets", Red_B / 14f);
			HKHBBBFLGJH().SetFloat("_Value3", Green_R / 1900f);
			LMLENGFLEBD().SetFloat("itemdefid[0]", Green_G / 970f);
			NBPKMLMCHFN.SetFloat("_BlurFilterDistance", Green_B / 572f);
			HEHKGPKLAKK().SetFloat("path", Blue_R / 1122f);
			HHIFMIPPMPF().SetFloat("_Value2", Blue_G / 1946f);
			NBMPPNFKFLB().SetFloat("_TimeX", Blue_B / 1171f);
			EFDEIFCDAFG().SetFloat(". Verify the Prefab is in a Resources folder (and not in a subfolder)", Red_Constant / 1711f);
			DKNJGHFLAIF().SetFloat(".workshop.json", Green_Constant / 1993f);
			EMDFHOKEGNG().SetFloat("CameraFilterPack/Blend2Camera_HardMix", Blue_Constant / 996f);
			HKHBBBFLGJH().SetVector("_FarCamera", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1725f, 235f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MKFLBEGJJDC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HEHKGPKLAKK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-71);
		}
		return BJFKDHHMLJH;
	}

	private void POJFHDFJOPE()
	{
		if (!Application.isPlaying)
		{
		}
	}

	private void Update()
	{
		if (!Application.isPlaying)
		{
		}
	}

	private void PHJJHFBLICM()
	{
		if (!Application.isPlaying)
		{
		}
	}

	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1665f)
			{
				HBJJOCHGOPH = 1697f;
			}
			BKKJJJGADLM().SetFloat("_NoiseTex", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("_TimeX", Red_R / 1960f);
			ACHNOHCLGOO().SetFloat("_ScreenResolution", Red_G / 356f);
			HKHBBBFLGJH().SetFloat("x", Red_B / 1659f);
			LDNADDJMIPK().SetFloat("w", Green_R / 399f);
			KDMBOKLMADJ().SetFloat(":</b> ", Green_G / 1202f);
			LDNADDJMIPK().SetFloat("{0} hours ago", Green_B / 657f);
			LMLENGFLEBD().SetFloat("\" call.", Blue_R / 384f);
			MLMKCOINOOH().SetFloat("_Threshhold", Blue_G / 1246f);
			NLFJGMBCICG().SetFloat("#", Blue_B / 252f);
			KOHGPKOFEJO().SetFloat("_ProjectionInv", Red_Constant / 1005f);
			JLHLHKPHDFO().SetFloat("BitsData", Green_Constant / 779f);
			KDMBOKLMADJ().SetFloat("SetParticlesInput", Blue_Constant / 95f);
			LDNADDJMIPK().SetVector("SetEnvSpriteImage", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1757f, 489f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LDNADDJMIPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-80);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material DKNJGHFLAIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)78;
		}
		return BJFKDHHMLJH;
	}

	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1021f)
			{
				HBJJOCHGOPH = 1983f;
			}
			IGIAPKPKGPK().SetFloat("_Size", HBJJOCHGOPH);
			KDMBOKLMADJ().SetFloat("CameraFilterPack/BlurTiltShift", Red_R / 473f);
			NBPKMLMCHFN.SetFloat("_Value2", Red_G / 1410f);
			GJHLADDCMFF().SetFloat("Joystick1Button10", Red_B / 52f);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", Green_R / 1452f);
			EHDJJANLINB().SetFloat("Please wait..", Green_G / 1045f);
			ACHNOHCLGOO().SetFloat("player.licenceaccepted", Green_B / 1454f);
			LMLENGFLEBD().SetFloat("_TimeX", Blue_R / 1007f);
			NBMPPNFKFLB().SetFloat("#8E8E8EFF", Blue_G / 72f);
			KOHGPKOFEJO().SetFloat("_Value4", Blue_B / 40f);
			BLMPMOIDGMG().SetFloat("_Far", Red_Constant / 191f);
			BKKJJJGADLM().SetFloat("_TimeX", Green_Constant / 169f);
			ACHNOHCLGOO().SetFloat("/", Blue_Constant / 1616f);
			NBMPPNFKFLB().SetVector("ItemsCountText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 421f, 1090f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PHJLHCMCCKE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GCHBGCGBMCK()
	{
		if (!Application.isPlaying)
		{
		}
	}

	private void PKLOBJHKFEO()
	{
		SCShader = Shader.Find("Hex value #RRGGBB");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ONKDMMJPEMN()
	{
		if (!Application.isPlaying)
		{
		}
	}

	private void LEAHIBJDMBI()
	{
		if (!Application.isPlaying)
		{
		}
	}

	private void EPEGAEGDJAM()
	{
		SCShader = Shader.Find(" (now: ");
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
			BJFKDHHMLJH.hideFlags = (HideFlags)99;
		}
		return BJFKDHHMLJH;
	}

	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1578f)
			{
				HBJJOCHGOPH = 378f;
			}
			EJDPNJAEAKJ().SetFloat("{0:0} minute{1}, ", HBJJOCHGOPH);
			LDNADDJMIPK().SetFloat("[DiscordController] Init", Red_R / 1690f);
			BLMPMOIDGMG().SetFloat("bad", Red_G / 1623f);
			LMLENGFLEBD().SetFloat("_TimeX", Red_B / 902f);
			EFDEIFCDAFG().SetFloat("_ScreenResolution", Green_R / 83f);
			KDMBOKLMADJ().SetFloat("[Up-Right-Down-Left]", Green_G / 1299f);
			BKKJJJGADLM().SetFloat("mainMenu", Green_B / 370f);
			EMDFHOKEGNG().SetFloat(" not exist", Blue_R / 64f);
			MLMKCOINOOH().SetFloat("Editor/", Blue_G / 1732f);
			EHDJJANLINB().SetFloat("_TimeX", Blue_B / 1522f);
			JLHLHKPHDFO().SetFloat("_BlurDirectionPacked", Red_Constant / 789f);
			JLHLHKPHDFO().SetFloat("_MainTex2", Green_Constant / 87f);
			HCGJCMDJPGD().SetFloat("/C tasklist", Blue_Constant / 1446f);
			EFDEIFCDAFG().SetVector("#mapby", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 269f, 1345f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BMOFEBKGLFI()
	{
		SCShader = Shader.Find("Tab2Content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MAOCOEGAFND()
	{
		if (!Application.isPlaying)
		{
		}
	}

	private void ABIOAMNCEOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 220f)
			{
				HBJJOCHGOPH = 1993f;
			}
			MLMKCOINOOH().SetFloat("[NetworkManager] Updating rooms...", HBJJOCHGOPH);
			JLHLHKPHDFO().SetFloat("{0}", Red_R / 302f);
			NBMPPNFKFLB().SetFloat("_VignetteSettings", Red_G / 380f);
			DKNJGHFLAIF().SetFloat("LevelProgressBar", Red_B / 1491f);
			EMDFHOKEGNG().SetFloat("_HueShift", Green_R / 522f);
			EJDPNJAEAKJ().SetFloat("_FarCamera", Green_G / 1332f);
			ACHNOHCLGOO().SetFloat("???", Green_B / 946f);
			OIIDAKBILMI().SetFloat("-1", Blue_R / 1738f);
			NBPKMLMCHFN.SetFloat("_TimeX", Blue_G / 1153f);
			ACHNOHCLGOO().SetFloat("Player", Blue_B / 1553f);
			HCGJCMDJPGD().SetFloat("_Blend", Red_Constant / 1408f);
			EJDPNJAEAKJ().SetFloat("_ScreenResolution", Green_Constant / 1763f);
			MLMKCOINOOH().SetFloat("_MainTex2", Blue_Constant / 454f);
			BLMPMOIDGMG().SetVector("[Up]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1859f, 599f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HNILMGEKDEC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material KDMBOKLMADJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.HideAndDontSave;
		}
		return BJFKDHHMLJH;
	}

	private void IBHACCEEFFI()
	{
		if (!Application.isPlaying)
		{
		}
	}

	[SpecialName]
	private Material GJHLADDCMFF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)72;
		}
		return BJFKDHHMLJH;
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Colors_Adjust_FullColors");
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
			NBPKMLMCHFN.SetFloat("_Red_R", Red_R / 100f);
			NBPKMLMCHFN.SetFloat("_Red_G", Red_G / 100f);
			NBPKMLMCHFN.SetFloat("_Red_B", Red_B / 100f);
			NBPKMLMCHFN.SetFloat("_Green_R", Green_R / 100f);
			NBPKMLMCHFN.SetFloat("_Green_G", Green_G / 100f);
			NBPKMLMCHFN.SetFloat("_Green_B", Green_B / 100f);
			NBPKMLMCHFN.SetFloat("_Blue_R", Blue_R / 100f);
			NBPKMLMCHFN.SetFloat("_Blue_G", Blue_G / 100f);
			NBPKMLMCHFN.SetFloat("_Blue_B", Blue_B / 100f);
			NBPKMLMCHFN.SetFloat("_Red_C", Red_Constant / 100f);
			NBPKMLMCHFN.SetFloat("_Green_C", Green_Constant / 100f);
			NBPKMLMCHFN.SetFloat("_Blue_C", Blue_Constant / 100f);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GPHPJIDGEPI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CMIBEOJGAIL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 445f)
			{
				HBJJOCHGOPH = 1135f;
			}
			HCGJCMDJPGD().SetFloat("Feb", HBJJOCHGOPH);
			EHDJJANLINB().SetFloat("RecieveChatActionMessage", Red_R / 1717f);
			LMLENGFLEBD().SetFloat("127.0.0.1", Red_G / 1238f);
			EFDEIFCDAFG().SetFloat("OnPickedUp", Red_B / 38f);
			JLHLHKPHDFO().SetFloat("_Heigh", Green_R / 999f);
			HEHKGPKLAKK().SetFloat("_SampleDistance", Green_G / 312f);
			NLFJGMBCICG().SetFloat("Ev Destroy Failed. Could not find PhotonView with instantiationId ", Green_B / 1074f);
			EHDJJANLINB().SetFloat("SaveButton", Blue_R / 701f);
			KDMBOKLMADJ().SetFloat("_TileMaxLoop", Blue_G / 594f);
			MLMKCOINOOH().SetFloat("1248864821", Blue_B / 252f);
			HEHKGPKLAKK().SetFloat("settings.arcshitsoundtimedelay", Red_Constant / 244f);
			HCGJCMDJPGD().SetFloat("settings.enableranking", Green_Constant / 455f);
			EJDPNJAEAKJ().SetFloat("settings.crosshairopacity", Blue_Constant / 499f);
			HCGJCMDJPGD().SetVector("PhotonNetwork error: Could not Instantiate the prefab [", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 500f, 1278f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1931f)
			{
				HBJJOCHGOPH = 1295f;
			}
			NBMPPNFKFLB().SetFloat("_DotSize", HBJJOCHGOPH);
			IGIAPKPKGPK().SetFloat("[MapsData] Caching ", Red_R / 448f);
			EFDEIFCDAFG().SetFloat("_Value4", Red_G / 1860f);
			IGIAPKPKGPK().SetFloat(".", Red_B / 1807f);
			KOHGPKOFEJO().SetFloat("y", Green_R / 84f);
			EJDPNJAEAKJ().SetFloat("Joystick1Button10", Green_G / 269f);
			JLHLHKPHDFO().SetFloat("menu.selectedlevelid", Green_B / 1703f);
			KDMBOKLMADJ().SetFloat("_Value4", Blue_R / 401f);
			JLHLHKPHDFO().SetFloat("_Size", Blue_G / 411f);
			HKHBBBFLGJH().SetFloat("_Amount", Blue_B / 764f);
			EFDEIFCDAFG().SetFloat("#ok", Red_Constant / 610f);
			EFDEIFCDAFG().SetFloat("_ScreenResolution", Green_Constant / 1972f);
			NLFJGMBCICG().SetFloat("_TimeX", Blue_Constant / 1761f);
			EJDPNJAEAKJ().SetVector("_Red_B", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 304f, 1486f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 900f)
			{
				HBJJOCHGOPH = 306f;
			}
			GJHLADDCMFF().SetFloat("y", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat(") but there is no recycle bin setup for it", Red_R / 217f);
			NLFJGMBCICG().SetFloat("CameraFilterPack/Colors_Adjust_PreFilters", Red_G / 251f);
			HCGJCMDJPGD().SetFloat("_SecondTex", Red_B / 1736f);
			LMLENGFLEBD().SetFloat(" = ", Green_R / 1280f);
			EPCGJFCCAFH().SetFloat("_Intensity", Green_G / 767f);
			HEHKGPKLAKK().SetFloat("settings.fps", Green_B / 553f);
			EMDFHOKEGNG().SetFloat("ItemNameText", Blue_R / 1607f);
			HEHKGPKLAKK().SetFloat("SetSunMinSize", Blue_G / 1677f);
			EJDPNJAEAKJ().SetFloat("Multiplayer", Blue_B / 1581f);
			IGIAPKPKGPK().SetFloat("achievements.21.completed.", Red_Constant / 1256f);
			HKHBBBFLGJH().SetFloat("_Value6", Green_Constant / 1185f);
			KDMBOKLMADJ().SetFloat("_TimeX", Blue_Constant / 1782f);
			LMLENGFLEBD().SetVector("SetParticlesInput", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1290f, 284f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1755f)
			{
				HBJJOCHGOPH = 742f;
			}
			NBMPPNFKFLB().SetFloat("_SubsampleIndices", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat("_VignetteBlur", Red_R / 508f);
			BLMPMOIDGMG().SetFloat("#000000CC", Red_G / 159f);
			HEHKGPKLAKK().SetFloat("\n", Red_B / 1543f);
			IGIAPKPKGPK().SetFloat("[PlayerController] ", Green_R / 776f);
			OIIDAKBILMI().SetFloat("StartButton", Green_G / 1381f);
			HCGJCMDJPGD().SetFloat("Texture2", Green_B / 51f);
			OIIDAKBILMI().SetFloat("Tonemapper curve texture", Blue_R / 1466f);
			NBMPPNFKFLB().SetFloat("PossibleMapPointsText", Blue_G / 1510f);
			EMDFHOKEGNG().SetFloat("_History4Weight", Blue_B / 443f);
			HEHKGPKLAKK().SetFloat("[Up]", Red_Constant / 1482f);
			ACHNOHCLGOO().SetFloat("SetBGColor", Green_Constant / 571f);
			ACHNOHCLGOO().SetFloat(" region", Blue_Constant / 957f);
			EPCGJFCCAFH().SetVector("Hidden/Image Effects/Cinematic/Bloom", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 712f, 1726f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ODAIMOJLJOF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material BLMPMOIDGMG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void MJEFMIPLFAB()
	{
		SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AAPKBNDHBLI()
	{
		if (!Application.isPlaying)
		{
		}
	}

	[SpecialName]
	private Material JLHLHKPHDFO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 730f)
			{
				HBJJOCHGOPH = 47f;
			}
			HHIFMIPPMPF().SetFloat("_TimeX", HBJJOCHGOPH);
			HKHBBBFLGJH().SetFloat("???", Red_R / 692f);
			KOHGPKOFEJO().SetFloat("_ScreenResolution", Red_G / 648f);
			NLFJGMBCICG().SetFloat(" ", Red_B / 1487f);
			ACHNOHCLGOO().SetFloat("/theme", Green_R / 149f);
			MLMKCOINOOH().SetFloat("CameraFilterPack/TV_Old", Green_G / 1622f);
			GJHLADDCMFF().SetFloat("_NeighbourMaxTex", Green_B / 283f);
			EHDJJANLINB().SetFloat("EnableRankingToggle", Blue_R / 1207f);
			BLMPMOIDGMG().SetFloat("_Value4", Blue_G / 130f);
			EJDPNJAEAKJ().SetFloat("close", Blue_B / 1996f);
			NBMPPNFKFLB().SetFloat("Can't set MaxPlayers when not in that room.", Red_Constant / 1832f);
			NBPKMLMCHFN.SetFloat("_Size", Green_Constant / 1269f);
			ACHNOHCLGOO().SetFloat("CameraFilterPack/EyesVision_1", Blue_Constant / 1021f);
			ACHNOHCLGOO().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 982f, 1613f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BKKJJJGADLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LIEGJOHINGC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}
}
