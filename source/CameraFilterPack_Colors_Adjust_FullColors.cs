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
			BLMPMOIDGMG().SetFloat("ready", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("There are a few rules that you must accept before submitting your work. Please select \"RULES\" button, if you haven't read them yet.", Red_R / 1507f);
			KOHGPKOFEJO().SetFloat("_TimeX", Red_G / 1153f);
			JLHLHKPHDFO().SetFloat("custom", Red_B / 871f);
			IGIAPKPKGPK().SetFloat("icon", Green_R / 1005f);
			GJHLADDCMFF().SetFloat("_Blue_R", Green_G / 1713f);
			ACHNOHCLGOO().SetFloat("_Value4", Green_B / 1610f);
			JLHLHKPHDFO().SetFloat("-", Blue_R / 1848f);
			MLMKCOINOOH().SetFloat("_ScreenResolution", Blue_G / 451f);
			KDMBOKLMADJ().SetFloat("_TimeX", Blue_B / 533f);
			KDMBOKLMADJ().SetFloat("You have added the SecondScrollRect to a scroll view that already has both directions selected", Red_Constant / 1171f);
			LDNADDJMIPK().SetFloat("OnRelease", Green_Constant / 1998f);
			GJHLADDCMFF().SetFloat("RPC can't be sent to target PhotonPlayer being null! Did not send \"", Blue_Constant / 364f);
			NBMPPNFKFLB().SetVector("inventory.itemscash", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 450f, 528f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
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
		SCShader = Shader.Find("_TimeX");
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
			NBPKMLMCHFN.SetFloat("Can't connect: Loading settings failed. ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings", HBJJOCHGOPH);
			HKHBBBFLGJH().SetFloat("CameraFilterPack/TV_PlanetMars", Red_R / 614f);
			EMDFHOKEGNG().SetFloat(".mp3", Red_G / 1304f);
			LMLENGFLEBD().SetFloat("Tab1Content", Red_B / 1600f);
			ACHNOHCLGOO().SetFloat("_EmissionGain", Green_R / 107f);
			NLFJGMBCICG().SetFloat("_Value4", Green_G / 1765f);
			HCGJCMDJPGD().SetFloat("Joystick1Button7", Green_B / 79f);
			LMLENGFLEBD().SetFloat("CameraFilterPack/Blend2Camera_Color", Blue_R / 1342f);
			OIIDAKBILMI().SetFloat(".", Blue_G / 1280f);
			OIIDAKBILMI().SetFloat(" not exist", Blue_B / 1102f);
			GJHLADDCMFF().SetFloat("/../", Red_Constant / 1420f);
			EPCGJFCCAFH().SetFloat("outputitemdefid", Green_Constant / 520f);
			HHIFMIPPMPF().SetFloat("SettingsCanvas", Blue_Constant / 1306f);
			HEHKGPKLAKK().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1766f, 1705f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHLADDCMFF());
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
		SCShader = Shader.Find("CameraFilterPack/Blend2Camera_LinearDodge");
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
			KOHGPKOFEJO().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat("_TimeX", Red_R / 485f);
			NLFJGMBCICG().SetFloat("_Blend", Red_G / 1787f);
			EMDFHOKEGNG().SetFloat("LevelNameInputField", Red_B / 559f);
			DKNJGHFLAIF().SetFloat("OpenButton", Green_R / 405f);
			ACHNOHCLGOO().SetFloat("CameraFilterPack/FX_Psycho", Green_G / 380f);
			KDMBOKLMADJ().SetFloat(".completed", Green_B / 588f);
			EMDFHOKEGNG().SetFloat("Editor/", Blue_R / 1707f);
			NBPKMLMCHFN.SetFloat("_FarCamera", Blue_G / 884f);
			HHIFMIPPMPF().SetFloat("Drop_With_Obj", Blue_B / 429f);
			LDNADDJMIPK().SetFloat("Bad parameters for set! Use <language>", Red_Constant / 1021f);
			EPCGJFCCAFH().SetFloat("\n", Green_Constant / 920f);
			EHDJJANLINB().SetFloat("Remove Environment Object", Blue_Constant / 1302f);
			EPCGJFCCAFH().SetVector("_ForceYSwap", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1411f, 1125f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGIAPKPKGPK());
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
			LDNADDJMIPK().SetFloat("GameScene", HBJJOCHGOPH);
			KDMBOKLMADJ().SetFloat("Cancel", Red_R / 1041f);
			KOHGPKOFEJO().SetFloat("OK", Red_G / 722f);
			EPCGJFCCAFH().SetFloat("ticket", Red_B / 1663f);
			NBPKMLMCHFN.SetFloat(".png", Green_R / 1692f);
			KDMBOKLMADJ().SetFloat("_Value4", Green_G / 1624f);
			DKNJGHFLAIF().SetFloat("settings.customdataskin", Green_B / 1445f);
			EHDJJANLINB().SetFloat("score:", Blue_R / 90f);
			EMDFHOKEGNG().SetFloat("MouseX", Blue_G / 1957f);
			EJDPNJAEAKJ().SetFloat("Custom Authentication failed (either due to user-input or configuration or AuthParameter string format). Calling: OnCustomAuthenticationFailed()", Blue_B / 433f);
			EHDJJANLINB().SetFloat("_UV_Transform", Red_Constant / 621f);
			EJDPNJAEAKJ().SetFloat("_Linecount", Green_Constant / 1101f);
			HHIFMIPPMPF().SetFloat("_FadeFX", Blue_Constant / 1327f);
			EHDJJANLINB().SetVector("_Alpha2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1604f, 272f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIIDAKBILMI());
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
			JLHLHKPHDFO().SetFloat("Tab2Content", HBJJOCHGOPH);
			KDMBOKLMADJ().SetFloat("/", Red_R / 1031f);
			ACHNOHCLGOO().SetFloat("Items/", Red_G / 1996f);
			JLHLHKPHDFO().SetFloat("inventory.selected.", Red_B / 317f);
			BLMPMOIDGMG().SetFloat("[MapsData] Preloading workshop", Green_R / 59f);
			NBMPPNFKFLB().SetFloat("Tab2Content", Green_G / 1424f);
			LMLENGFLEBD().SetFloat("_ScreenResolution", Green_B / 309f);
			KOHGPKOFEJO().SetFloat(",", Blue_R / 1720f);
			EMDFHOKEGNG().SetFloat(" #", Blue_G / 477f);
			EPCGJFCCAFH().SetFloat("#", Blue_B / 485f);
			DKNJGHFLAIF().SetFloat(" has ", Red_Constant / 1140f);
			KOHGPKOFEJO().SetFloat("Testing, the group has toggled [", Green_Constant / 1929f);
			EJDPNJAEAKJ().SetFloat("_MainTex2", Blue_Constant / 1411f);
			HEHKGPKLAKK().SetVector("ShadersToggle", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1690f, 1819f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KDMBOKLMADJ());
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
			LDNADDJMIPK().SetFloat("_Value", HBJJOCHGOPH);
			EHDJJANLINB().SetFloat("[EMPTY]", Red_R / 1811f);
			HCGJCMDJPGD().SetFloat("_Value3", Red_G / 1089f);
			HEHKGPKLAKK().SetFloat("_Value", Red_B / 677f);
			HHIFMIPPMPF().SetFloat("_SSAO", Green_R / 199f);
			DKNJGHFLAIF().SetFloat("_Value4", Green_G / 454f);
			KOHGPKOFEJO().SetFloat("#ok", Green_B / 1517f);
			NBPKMLMCHFN.SetFloat(": ", Blue_R / 996f);
			HEHKGPKLAKK().SetFloat("[ItemsHandler] All in-game items loaded", Blue_G / 1338f);
			DKNJGHFLAIF().SetFloat("ItemsUploader", Blue_B / 152f);
			HEHKGPKLAKK().SetFloat("MaxLivesSlider", Red_Constant / 1578f);
			EHDJJANLINB().SetFloat("_DistortionLevel", Green_Constant / 114f);
			NBPKMLMCHFN.SetFloat("DPADHOR", Blue_Constant / 709f);
			BKKJJJGADLM().SetVector(". Calling ConnectToRegionMaster() is: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 506f, 1612f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
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
			DKNJGHFLAIF().SetFloat("_TimeX", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_DiffuseColor", Red_R / 1052f);
			NBPKMLMCHFN.SetFloat("Data/Editor/leveltemplate", Red_G / 318f);
			KOHGPKOFEJO().SetFloat("ResetButton", Red_B / 908f);
			DKNJGHFLAIF().SetFloat("_Value3", Green_R / 1195f);
			OIIDAKBILMI().SetFloat("_Value6", Green_G / 1406f);
			BLMPMOIDGMG().SetFloat("CameraFilterPack/FX_Dot_Circle", Green_B / 1143f);
			OIIDAKBILMI().SetFloat("ShadersToggle", Blue_R / 1176f);
			EHDJJANLINB().SetFloat("_Value3", Blue_G / 308f);
			EPCGJFCCAFH().SetFloat("CameraFilterPack/Retro_Loading", Blue_B / 1094f);
			EHDJJANLINB().SetFloat("[EMPTY]", Red_Constant / 857f);
			OIIDAKBILMI().SetFloat("_Value3", Green_Constant / 86f);
			KOHGPKOFEJO().SetFloat("Icon", Blue_Constant / 273f);
			EHDJJANLINB().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 252f, 210f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
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
			HHIFMIPPMPF().SetFloat(".lastCheckpoint.time", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat(" but this PhotonView does not exist! Was remote PV.", Red_R / 233f);
			BLMPMOIDGMG().SetFloat("_SizeY", Red_G / 1734f);
			JLHLHKPHDFO().SetFloat(".completed", Red_B / 1382f);
			HCGJCMDJPGD().SetFloat("settings.volume.editor", Green_R / 1038f);
			NLFJGMBCICG().SetFloat("CameraFilterPack/3D_Anomaly", Green_G / 67f);
			ACHNOHCLGOO().SetFloat("[PlayerBase] Loaded custom model: ", Green_B / 1275f);
			KDMBOKLMADJ().SetFloat("mapselector.orderby", Blue_R / 669f);
			NLFJGMBCICG().SetFloat("settings.showHP", Blue_G / 798f);
			EFDEIFCDAFG().SetFloat("_TimeX", Blue_B / 1348f);
			NBPKMLMCHFN.SetFloat("G:", Red_Constant / 1491f);
			KDMBOKLMADJ().SetFloat(".lastCheckpoint.correctScore", Green_Constant / 865f);
			LDNADDJMIPK().SetFloat("BitsData", Blue_Constant / 1446f);
			KDMBOKLMADJ().SetVector("_ZCurve", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 646f, 1210f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKHBBBFLGJH());
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
			IGIAPKPKGPK().SetFloat("ConfigVersionSlider", HBJJOCHGOPH);
			BKKJJJGADLM().SetFloat("_copy", Red_R / 895f);
			HKHBBBFLGJH().SetFloat("#ok", Red_G / 1111f);
			HEHKGPKLAKK().SetFloat("[Sound Manager] Audio clip is null, cannot play sound", Red_B / 272f);
			LMLENGFLEBD().SetFloat("_ChangeBlue", Green_R / 1193f);
			HCGJCMDJPGD().SetFloat(" not exist", Green_G / 1347f);
			HCGJCMDJPGD().SetFloat("DPADVER", Green_B / 1834f);
			NBMPPNFKFLB().SetFloat("nogamesfound", Blue_R / 498f);
			EPCGJFCCAFH().SetFloat("Deleted event", Blue_G / 594f);
			BKKJJJGADLM().SetFloat("_Fade", Blue_B / 1373f);
			EMDFHOKEGNG().SetFloat("]", Red_Constant / 1138f);
			KDMBOKLMADJ().SetFloat("Save", Green_Constant / 1907f);
			JLHLHKPHDFO().SetFloat("Fade", Blue_Constant / 770f);
			DKNJGHFLAIF().SetVector("float,50", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1975f, 1515f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void COIJKMKIEAK()
	{
		SCShader = Shader.Find("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception");
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
		SCShader = Shader.Find("sounds/hit_wrong");
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
			EMDFHOKEGNG().SetFloat("settings.arcsdestroydelay", HBJJOCHGOPH);
			LDNADDJMIPK().SetFloat("editorVolume", Red_R / 1398f);
			ACHNOHCLGOO().SetFloat("CameraFilterPack/3D_Myst", Red_G / 193f);
			HKHBBBFLGJH().SetFloat("CameraFilterPack_Paper4", Red_B / 516f);
			EMDFHOKEGNG().SetFloat(".lastCheckpoint.comboScore", Green_R / 1391f);
			EJDPNJAEAKJ().SetFloat("Use \"/help\" for commands list", Green_G / 1364f);
			LDNADDJMIPK().SetFloat(", ", Green_B / 326f);
			NBPKMLMCHFN.SetFloat("#useticket", Blue_R / 1429f);
			HCGJCMDJPGD().SetFloat("DPADVER", Blue_G / 1704f);
			MLMKCOINOOH().SetFloat("st", Blue_B / 1294f);
			HCGJCMDJPGD().SetFloat("_Blend", Red_Constant / 1672f);
			EFDEIFCDAFG().SetFloat("_ScreenResolution", Green_Constant / 227f);
			KOHGPKOFEJO().SetFloat("_PixelsPerMeterAtOneMeter", Blue_Constant / 1203f);
			DKNJGHFLAIF().SetVector("CameraFilterPack/Blend2Camera_Subtract", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1901f, 433f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIIDAKBILMI());
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
			EFDEIFCDAFG().SetFloat("_Value5", HBJJOCHGOPH);
			IGIAPKPKGPK().SetFloat("_ScreenResolution", Red_R / 1878f);
			GJHLADDCMFF().SetFloat("BadgeText", Red_G / 710f);
			NBMPPNFKFLB().SetFloat("Drop_With_Obj", Red_B / 1000f);
			KOHGPKOFEJO().SetFloat("Waiting to start", Green_R / 1173f);
			MLMKCOINOOH().SetFloat("_FarCamera", Green_G / 1998f);
			EFDEIFCDAFG().SetFloat("id", Green_B / 975f);
			KOHGPKOFEJO().SetFloat("<b>#", Blue_R / 951f);
			HCGJCMDJPGD().SetFloat("Mouse0", Blue_G / 1585f);
			ACHNOHCLGOO().SetFloat("IconFileSelector", Blue_B / 172f);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/FX_Funk", Red_Constant / 1778f);
			HEHKGPKLAKK().SetFloat("CrosshairOpacitySlider", Green_Constant / 648f);
			OIIDAKBILMI().SetFloat("Joystick1Button5", Blue_Constant / 102f);
			BKKJJJGADLM().SetVector(".lastCheckpoint.bgcolor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1665f, 1706f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
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
			HHIFMIPPMPF().SetFloat("SpawnObj", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("[PlayerBase] Config error: musicTime <= 0", Red_R / 407f);
			LMLENGFLEBD().SetFloat("Room: '{0}' {1},{2} {4}/{3} players.", Red_G / 1051f);
			HKHBBBFLGJH().SetFloat("X", Red_B / 126f);
			HHIFMIPPMPF().SetFloat("Join failed on GameServer. Changing back to MasterServer. Msg: ", Green_R / 280f);
			ACHNOHCLGOO().SetFloat("_Offsets", Green_G / 1320f);
			EPCGJFCCAFH().SetFloat("_Green_B", Green_B / 1878f);
			HHIFMIPPMPF().SetFloat("FavoriteButton", Blue_R / 579f);
			BKKJJJGADLM().SetFloat("Added GameObject to prefabDictionary: ", Blue_G / 1748f);
			OIIDAKBILMI().SetFloat("ItemNameBGImage", Blue_B / 919f);
			EFDEIFCDAFG().SetFloat("inventory.lastitemscount", Red_Constant / 995f);
			GJHLADDCMFF().SetFloat("_Value3", Green_Constant / 212f);
			NBMPPNFKFLB().SetFloat("Found best region: '", Blue_Constant / 759f);
			EJDPNJAEAKJ().SetVector("_CenterX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 180f, 627f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KOHGPKOFEJO());
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
			JLHLHKPHDFO().SetFloat("menu.selectedlevelid", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("_TimeX", Red_R / 872f);
			KDMBOKLMADJ().SetFloat("[SERVER] Selected mode: ", Red_G / 1029f);
			GJHLADDCMFF().SetFloat(".", Red_B / 113f);
			EMDFHOKEGNG().SetFloat("Copy from ", Green_R / 749f);
			KOHGPKOFEJO().SetFloat("CameraFilterPack/Color_Chromatic_Plus", Green_G / 1038f);
			EJDPNJAEAKJ().SetFloat("#8E8E8EFF", Green_B / 1790f);
			EJDPNJAEAKJ().SetFloat("_TimeX", Blue_R / 1488f);
			EJDPNJAEAKJ().SetFloat("_Value2", Blue_G / 905f);
			LMLENGFLEBD().SetFloat("CameraFilterPack/Blend2Camera_Multiply", Blue_B / 1529f);
			LDNADDJMIPK().SetFloat("/", Red_Constant / 747f);
			NLFJGMBCICG().SetFloat("menu.relaxinfo", Green_Constant / 1756f);
			GJHLADDCMFF().SetFloat("Fade", Blue_Constant / 228f);
			DKNJGHFLAIF().SetVector("_Offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1722f, 1782f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKHBBBFLGJH());
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
			NBPKMLMCHFN.SetFloat("_TimeX", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat("CameraFilterPack/TV_WideScreenCircle", Red_R / 1504f);
			KOHGPKOFEJO().SetFloat("[ItemsHandler] Loading ", Red_G / 724f);
			MLMKCOINOOH().SetFloat("MAPS NOT FOUND", Red_B / 1551f);
			LMLENGFLEBD().SetFloat("_ScreenResolution", Green_R / 1361f);
			GJHLADDCMFF().SetFloat("[PlayerBase] Ready", Green_G / 761f);
			LMLENGFLEBD().SetFloat("_Value9", Green_B / 1099f);
			DKNJGHFLAIF().SetFloat("[PlayerController] ", Blue_R / 385f);
			EMDFHOKEGNG().SetFloat("_Offsets", Blue_G / 1219f);
			NBPKMLMCHFN.SetFloat("_BlurRadius4", Blue_B / 242f);
			BLMPMOIDGMG().SetFloat("_Value4", Red_Constant / 1722f);
			EFDEIFCDAFG().SetFloat("DifficultyBG", Green_Constant / 1076f);
			ACHNOHCLGOO().SetFloat("CameraFilterPack/3D_Shield", Blue_Constant / 358f);
			MLMKCOINOOH().SetVector("action", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1496f, 232f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
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
		SCShader = Shader.Find("JoinTeam was called in state: ");
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
		SCShader = Shader.Find("ShadersToggle");
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
			EFDEIFCDAFG().SetFloat("settings.volume.sfx", HBJJOCHGOPH);
			BKKJJJGADLM().SetFloat("y", Red_R / 594f);
			NLFJGMBCICG().SetFloat("DifficultyBG", Red_G / 821f);
			OIIDAKBILMI().SetFloat("_VelTex", Red_B / 1541f);
			HHIFMIPPMPF().SetFloat("(((?<x>(?=[,\\r\\n]+))|\"(?<x>([^\"]|\"\")+)\"|(?<x>[^,\\r\\n]+)),?)", Green_R / 78f);
			HEHKGPKLAKK().SetFloat("[ResourcesManager] Load text error: not found", Green_G / 474f);
			HEHKGPKLAKK().SetFloat("[NetworkManager] Exited", Green_B / 70f);
			HEHKGPKLAKK().SetFloat("_Noise", Blue_R / 745f);
			IGIAPKPKGPK().SetFloat(":", Blue_G / 1979f);
			MLMKCOINOOH().SetFloat("_OffsetScale", Blue_B / 823f);
			HEHKGPKLAKK().SetFloat("CameraFilterPack/TV_MovieNoise", Red_Constant / 1020f);
			EJDPNJAEAKJ().SetFloat("_Offsets", Green_Constant / 472f);
			GJHLADDCMFF().SetFloat("_ScreenResolution", Blue_Constant / 1431f);
			KDMBOKLMADJ().SetVector("[PlayerBase] Loaded custom model: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 42f, 759f));
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
			NBMPPNFKFLB().SetFloat("OpAuthenticate() failed. When you want Custom Authentication encryption is mandatory.", HBJJOCHGOPH);
			MLMKCOINOOH().SetFloat(" (", Red_R / 930f);
			KDMBOKLMADJ().SetFloat(".message", Red_G / 289f);
			HKHBBBFLGJH().SetFloat("D-Pad Right", Red_B / 1086f);
			HCGJCMDJPGD().SetFloat("B:", Green_R / 767f);
			DKNJGHFLAIF().SetFloat("_Blue_G", Green_G / 583f);
			BKKJJJGADLM().SetFloat("_Distortion", Green_B / 613f);
			BKKJJJGADLM().SetFloat("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", Blue_R / 1696f);
			BKKJJJGADLM().SetFloat("maps.", Blue_G / 73f);
			KDMBOKLMADJ().SetFloat("_Value3", Blue_B / 1798f);
			IGIAPKPKGPK().SetFloat("InputField", Red_Constant / 1293f);
			BKKJJJGADLM().SetFloat("_Value2", Green_Constant / 1391f);
			OIIDAKBILMI().SetFloat("[PlayerController] ", Blue_Constant / 345f);
			NBMPPNFKFLB().SetVector("HiddenToggle", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 768f, 1515f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
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
			DKNJGHFLAIF().SetFloat("[RanksSystem] Ranks updated. Next update: ", HBJJOCHGOPH);
			HEHKGPKLAKK().SetFloat("Editor/", Red_R / 1481f);
			KOHGPKOFEJO().SetFloat("_Value2", Red_G / 1963f);
			EHDJJANLINB().SetFloat("_HrDepthTex", Red_B / 14f);
			BLMPMOIDGMG().SetFloat("_Value3", Green_R / 1900f);
			EHDJJANLINB().SetFloat("time", Green_G / 970f);
			EHDJJANLINB().SetFloat("_Axis", Green_B / 572f);
			OIIDAKBILMI().SetFloat("Save Path: ", Blue_R / 1122f);
			GJHLADDCMFF().SetFloat("_Value3", Blue_G / 1946f);
			OIIDAKBILMI().SetFloat("_Value", Blue_B / 1171f);
			EHDJJANLINB().SetFloat(". Prefab must have a PhotonView component.", Red_Constant / 1711f);
			EJDPNJAEAKJ().SetFloat(".", Green_Constant / 1993f);
			MLMKCOINOOH().SetFloat("CameraFilterPack/Blend2Camera_Difference", Blue_Constant / 996f);
			EHDJJANLINB().SetVector("_FarCamera", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1725f, 235f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKHBBBFLGJH());
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
			HCGJCMDJPGD().SetFloat("_NoiseTilingPerChannel", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("_DotSize", Red_R / 1960f);
			OIIDAKBILMI().SetFloat("CameraFilterPack/Oculus_NightVision5", Red_G / 356f);
			DKNJGHFLAIF().SetFloat("ItemNameText", Red_B / 1659f);
			KOHGPKOFEJO().SetFloat("z", Green_R / 399f);
			HKHBBBFLGJH().SetFloat("#timeuntilend: ", Green_G / 1202f);
			IGIAPKPKGPK().SetFloat("{0} hours ago", Green_B / 657f);
			LMLENGFLEBD().SetFloat("Error: Cannot change the name of a remote player!", Blue_R / 384f);
			ACHNOHCLGOO().SetFloat("_ColorBuffer", Blue_G / 1246f);
			LMLENGFLEBD().SetFloat("</color>", Blue_B / 252f);
			EFDEIFCDAFG().SetFloat("_Radius", Red_Constant / 1005f);
			GJHLADDCMFF().SetFloat("BitsData", Green_Constant / 779f);
			ACHNOHCLGOO().SetFloat("Set Particles Input", Blue_Constant / 95f);
			HKHBBBFLGJH().SetVector("Set EnvSprite Image", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1757f, 489f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
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
			EFDEIFCDAFG().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("_TimeX", Red_R / 473f);
			JLHLHKPHDFO().SetFloat("_Value2", Red_G / 1410f);
			BLMPMOIDGMG().SetFloat("Joystick1Button11", Red_B / 52f);
			MLMKCOINOOH().SetFloat("CameraFilterPack/FX_Glitch2", Green_R / 1452f);
			EMDFHOKEGNG().SetFloat("Editor/", Green_G / 1045f);
			NLFJGMBCICG().SetFloat("[LevelEditorScene] Error: I/O Failure! :(", Green_B / 1454f);
			EFDEIFCDAFG().SetFloat("_Value", Blue_R / 1007f);
			IGIAPKPKGPK().SetFloat("RecordButton", Blue_G / 72f);
			DKNJGHFLAIF().SetFloat("_Value4", Blue_B / 40f);
			BLMPMOIDGMG().SetFloat("_Far", Red_Constant / 191f);
			GJHLADDCMFF().SetFloat("_TimeX", Green_Constant / 169f);
			EMDFHOKEGNG().SetFloat("[MapEditor] Loaded music file: ", Blue_Constant / 1616f);
			NBPKMLMCHFN.SetVector("ItemsCountText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 421f, 1090f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EMDFHOKEGNG());
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
		SCShader = Shader.Find("Set satellite color");
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
		SCShader = Shader.Find(" now: ");
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
			LMLENGFLEBD().SetFloat("{0:0} minute{1}, ", HBJJOCHGOPH);
			EHDJJANLINB().SetFloat("#discord{0}joinrequest", Red_R / 1690f);
			OIIDAKBILMI().SetFloat("ok", Red_G / 1623f);
			EFDEIFCDAFG().SetFloat("_Value", Red_B / 902f);
			KDMBOKLMADJ().SetFloat("_ScreenResolution", Green_R / 83f);
			LMLENGFLEBD().SetFloat("[Up-Right-Down-Left]", Green_G / 1299f);
			KOHGPKOFEJO().SetFloat("mainMenu", Green_B / 370f);
			HCGJCMDJPGD().SetFloat("[PlayerController] ", Blue_R / 64f);
			BLMPMOIDGMG().SetFloat("Editor/", Blue_G / 1732f);
			KDMBOKLMADJ().SetFloat("_Value", Blue_B / 1522f);
			OIIDAKBILMI().SetFloat("_MinVelocity", Red_Constant / 789f);
			NBMPPNFKFLB().SetFloat("_MainTex2", Green_Constant / 87f);
			EPCGJFCCAFH().SetFloat("/C tasklist", Blue_Constant / 1446f);
			NLFJGMBCICG().SetVector("MapperNameText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 269f, 1345f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EHDJJANLINB());
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
			EMDFHOKEGNG().SetFloat("[NetworkManager] Updating rooms...", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("{0:0} day{1}, ", Red_R / 302f);
			KOHGPKOFEJO().SetFloat("_VignetteSettings", Red_G / 380f);
			IGIAPKPKGPK().SetFloat("CheckCombo", Red_B / 1491f);
			ACHNOHCLGOO().SetFloat("_Sat", Green_R / 522f);
			EMDFHOKEGNG().SetFloat("_FarCamera", Green_G / 1332f);
			GJHLADDCMFF().SetFloat("Tried to Initialize the SteamAPI twice in one session!", Green_B / 946f);
			IGIAPKPKGPK().SetFloat("-1", Blue_R / 1738f);
			NBMPPNFKFLB().SetFloat("_Value2", Blue_G / 1153f);
			BKKJJJGADLM().SetFloat("[MenuScene] Error: ", Blue_B / 1553f);
			LMLENGFLEBD().SetFloat("_LutTex", Red_Constant / 1408f);
			HKHBBBFLGJH().SetFloat("Texture2", Green_Constant / 1763f);
			ACHNOHCLGOO().SetFloat("_MainTex2", Blue_Constant / 454f);
			GJHLADDCMFF().SetVector("[Left]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1859f, 599f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LMLENGFLEBD());
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
			KOHGPKOFEJO().SetFloat("May", HBJJOCHGOPH);
			BKKJJJGADLM().SetFloat("[SERVER] Player ", Red_R / 1717f);
			HHIFMIPPMPF().SetFloat("This might be a misconfiguration in the game server config. You need to edit it to a (public) address.", Red_G / 1238f);
			JLHLHKPHDFO().SetFloat("PunPickupSimple", Red_B / 38f);
			LDNADDJMIPK().SetFloat("_Intervale", Green_R / 999f);
			EFDEIFCDAFG().SetFloat("_Exponent", Green_G / 312f);
			BKKJJJGADLM().SetFloat("Warning: Unhandled Event ErrorInfo (251). Set PhotonNetwork.OnEventCall to the method PUN should call for this event.", Green_B / 1074f);
			IGIAPKPKGPK().SetFloat("SaveButton", Blue_R / 701f);
			EJDPNJAEAKJ().SetFloat("_MaxBlurRadius", Blue_G / 594f);
			NLFJGMBCICG().SetFloat("907198288", Blue_B / 252f);
			NBPKMLMCHFN.SetFloat("[PlayerBase] Loaded spawner data", Red_Constant / 244f);
			MLMKCOINOOH().SetFloat("EnableRankingToggle", Green_Constant / 455f);
			GJHLADDCMFF().SetFloat("Crosshair2", Blue_Constant / 499f);
			IGIAPKPKGPK().SetVector("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 500f, 1278f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKHBBBFLGJH());
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
			OIIDAKBILMI().SetFloat("CameraFilterPack/Drawing_Manga5", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("[MapsData] Bad map: ", Red_R / 448f);
			LMLENGFLEBD().SetFloat("_ScreenResolution", Red_G / 1860f);
			EPCGJFCCAFH().SetFloat(".lastCheckpoint.lives", Red_B / 1807f);
			EFDEIFCDAFG().SetFloat("float,0", Green_R / 84f);
			JLHLHKPHDFO().SetFloat("Joystick1Button11", Green_G / 269f);
			DKNJGHFLAIF().SetFloat("menu.tabid", Green_B / 1703f);
			HKHBBBFLGJH().SetFloat("_ScreenResolution", Blue_R / 401f);
			IGIAPKPKGPK().SetFloat("_ScreenResolution", Blue_G / 411f);
			JLHLHKPHDFO().SetFloat("_Amount", Blue_B / 764f);
			EJDPNJAEAKJ().SetFloat("note.1", Red_Constant / 610f);
			HCGJCMDJPGD().SetFloat("CameraFilterPack_Fly_VisionFX", Green_Constant / 1972f);
			EFDEIFCDAFG().SetFloat("_Radius", Blue_Constant / 1761f);
			HEHKGPKLAKK().SetVector("_Green_R", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 304f, 1486f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
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
			EFDEIFCDAFG().SetFloat("y", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("automaticallyRecycleParticleSystems is true but there is no ParticleSystem on this GameObject!", Red_R / 217f);
			BLMPMOIDGMG().SetFloat("_TimeX", Red_G / 251f);
			EFDEIFCDAFG().SetFloat("_EdgeThreshold", Red_B / 1736f);
			EFDEIFCDAFG().SetFloat("PUN-instantiated '", Green_R / 1280f);
			KDMBOKLMADJ().SetFloat("colorB", Green_G / 767f);
			HKHBBBFLGJH().SetFloat("settings.fps", Green_B / 553f);
			EHDJJANLINB().SetFloat("RarityImage", Blue_R / 1607f);
			LMLENGFLEBD().SetFloat("SetSunDirectionVector", Blue_G / 1677f);
			LDNADDJMIPK().SetFloat("Multiplayer", Blue_B / 1581f);
			DKNJGHFLAIF().SetFloat("achievements.21.completed.", Red_Constant / 1256f);
			GJHLADDCMFF().SetFloat("_ScreenResolution", Green_Constant / 1185f);
			EJDPNJAEAKJ().SetFloat("_Value", Blue_Constant / 1782f);
			EPCGJFCCAFH().SetVector("SpawnObj", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1290f, 284f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BLMPMOIDGMG());
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
			EJDPNJAEAKJ().SetFloat("USE_PREDICATION", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("DISTORT", Red_R / 508f);
			GJHLADDCMFF().SetFloat("#FFDA44CC", Red_G / 159f);
			HHIFMIPPMPF().SetFloat("\n", Red_B / 1543f);
			OIIDAKBILMI().SetFloat(": ", Green_R / 776f);
			ACHNOHCLGOO().SetFloat("StartButton", Green_G / 1381f);
			OIIDAKBILMI().SetFloat("Texture2", Green_B / 51f);
			IGIAPKPKGPK().SetFloat("Identity LUT", Blue_R / 1466f);
			HEHKGPKLAKK().SetFloat("PointsScoreText", Blue_G / 1510f);
			OIIDAKBILMI().SetFloat("_NormalAndRoughnessTexture", Blue_B / 443f);
			NBMPPNFKFLB().SetFloat("[Up]", Red_Constant / 1482f);
			EFDEIFCDAFG().SetFloat("RemoveEnvironmentObject", Green_Constant / 571f);
			NBPKMLMCHFN.SetFloat(" region", Blue_Constant / 957f);
			MLMKCOINOOH().SetVector("_Curve", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 712f, 1726f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK());
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
			EJDPNJAEAKJ().SetFloat("_Y", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat("???", Red_R / 692f);
			EHDJJANLINB().SetFloat("_ScreenResolution", Red_G / 648f);
			ACHNOHCLGOO().SetFloat(" ", Red_B / 1487f);
			OIIDAKBILMI().SetFloat("AudioSampler", Green_R / 149f);
			HHIFMIPPMPF().SetFloat("_Distortion", Green_G / 1622f);
			EJDPNJAEAKJ().SetFloat("_MaxRadiusOrKInPaper", Green_B / 283f);
			HHIFMIPPMPF().SetFloat("EnableRankingToggle", Blue_R / 1207f);
			ACHNOHCLGOO().SetFloat("_Value4", Blue_G / 130f);
			MLMKCOINOOH().SetFloat("#random #common #item", Blue_B / 1996f);
			EHDJJANLINB().SetFloat("Room: '{0}' {1},{2} {4}/{3} players.", Red_Constant / 1832f);
			NLFJGMBCICG().SetFloat("_ScreenResolution", Green_Constant / 1269f);
			LMLENGFLEBD().SetFloat("_TimeX", Blue_Constant / 1021f);
			BKKJJJGADLM().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 982f, 1613f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
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
