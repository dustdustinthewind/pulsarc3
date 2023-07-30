// CameraFilterPack_Blend2Camera_PhotoshopFilters
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/PhotoshopFilters")]
[ExecuteInEditMode]
public class CameraFilterPack_Blend2Camera_PhotoshopFilters : MonoBehaviour
{
	public enum filters
	{
		Darken,
		Multiply,
		ColorBurn,
		LinearBurn,
		DarkerColor,
		Lighten,
		Screen,
		ColorDodge,
		LinearDodge,
		LighterColor,
		Overlay,
		SoftLight,
		HardLight,
		VividLight,
		LinearLight,
		PinLight,
		HardMix,
		Difference,
		Exclusion,
		Subtract,
		Divide,
		Hue,
		Saturation,
		Color,
		Luminosity
	}

	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Darken";

	public Shader SCShader;

	public Camera Camera2;

	public filters filterchoice;

	private filters BEHNMDCNKBF;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 1f)]
	public float SwitchCameraToCamera2;

	[Range(0f, 1f)]
	public float BlendFX = 0.5f;

	private RenderTexture JDMCFBKJHDD;

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

	private void NLGDPIBFHMK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -58);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void GJLKJAOBPJD()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material ADBKPGFMNKO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)77;
		}
		return BJFKDHHMLJH;
	}

	private void BNLENEDAHHL()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 648f)
			{
				HBJJOCHGOPH = 757f;
			}
			if (Camera2 != null)
			{
				LPDOGGFOBDH().SetTexture("_BlurredColor", JDMCFBKJHDD);
			}
			FKEOGPDLBDD().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			FKEOGPDLBDD().SetFloat("Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. ", BlendFX);
			MPENCEIGLEH().SetFloat(".lastCheckpoint.incorrectScore", SwitchCameraToCamera2);
			MHBAIEKFBIJ().SetVector("_SpherePositionY", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 666f, 1045f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PEIMCBBHLBJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 186f)
			{
				HBJJOCHGOPH = 1271f;
			}
			if (Camera2 != null)
			{
				LDNADDJMIPK().SetTexture("_Value3", JDMCFBKJHDD);
			}
			JIBOKBCPDLC().SetFloat("{", HBJJOCHGOPH);
			MHBAIEKFBIJ().SetFloat("[Left]", BlendFX);
			KEMJNOMIPHN().SetFloat("All bindings reset to default values. PlayerPrefs have been removed for each key.", SwitchCameraToCamera2);
			NBPKMLMCHFN.SetVector("\n", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1355f, 873f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PEIMCBBHLBJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HMNLHMLILKD()
	{
	}

	private void GCDLIKEDMCF()
	{
	}

	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 314f)
			{
				HBJJOCHGOPH = 1457f;
			}
			if (Camera2 != null)
			{
				OIIDAKBILMI().SetTexture("/", JDMCFBKJHDD);
			}
			LDNADDJMIPK().SetFloat("AudioSampler", HBJJOCHGOPH);
			OKJOKHGJHGF().SetFloat("Mouse ", BlendFX);
			KEMJNOMIPHN().SetFloat("settings.volume.game", SwitchCameraToCamera2);
			LPCHMEKDCHI().SetVector("_Offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 46f, 1560f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BHBCNNIJECK()
	{
		if (filterchoice != BEHNMDCNKBF)
		{
			MELKBLIIFEO();
			SCShader = Shader.Find(ELOFMLPCCEA);
			Object.DestroyImmediate(BJFKDHHMLJH);
			if (BJFKDHHMLJH == null)
			{
				BJFKDHHMLJH = new Material(SCShader);
				BJFKDHHMLJH.hideFlags = (HideFlags)80;
			}
		}
		BEHNMDCNKBF = filterchoice;
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -13);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void ABHEJPAGNMO()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material EFDEIFCDAFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void IFJDKDFLGBG()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CGCHMJCJOBB()
	{
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "#ok";
		}
		if (filterchoice == filters.Multiply)
		{
			ELOFMLPCCEA = "_HrDepthTex";
		}
		if (filterchoice == filters.DarkerColor)
		{
			ELOFMLPCCEA = "[Right]";
		}
		if (filterchoice == filters.Screen)
		{
			ELOFMLPCCEA = "_MotionBlurTmpCam";
		}
		if (filterchoice == filters.LinearBurn)
		{
			ELOFMLPCCEA = "_Value";
		}
		if (filterchoice == filters.LinearBurn)
		{
			ELOFMLPCCEA = "_ScreenResolution";
		}
		if (filterchoice == filters.ColorDodge)
		{
			ELOFMLPCCEA = "Triangle";
		}
		if (filterchoice == filters.LinearDodge)
		{
			ELOFMLPCCEA = " not found";
		}
		if (filterchoice == filters.DarkerColor)
		{
			ELOFMLPCCEA = "_ScreenResolution";
		}
		if (filterchoice == (filters)105)
		{
			ELOFMLPCCEA = "_Blue_C";
		}
		if (filterchoice == (filters)116)
		{
			ELOFMLPCCEA = "Waiting to start";
		}
		if (filterchoice == filters.VividLight)
		{
			ELOFMLPCCEA = "Gameplay/sprite";
		}
		if (filterchoice == (filters)(-20))
		{
			ELOFMLPCCEA = "_PColor";
		}
		if (filterchoice == (filters)(-16))
		{
			ELOFMLPCCEA = "FinalScoreSmallText";
		}
		if (filterchoice == filters.PinLight)
		{
			ELOFMLPCCEA = "ConnectToMaster() disabled the offline mode. No longer offline.";
		}
		if (filterchoice == (filters)77)
		{
			ELOFMLPCCEA = "_FarCamera";
		}
		if (filterchoice == (filters)(-70))
		{
			ELOFMLPCCEA = "Operation failed: ";
		}
		if (filterchoice == filters.LinearBurn)
		{
			ELOFMLPCCEA = "[BuildInfo] Error: ";
		}
		if (filterchoice == filters.Subtract)
		{
			ELOFMLPCCEA = "You did not select a Hosting Type in your PhotonServerSettings. Please set it up or don't use ConnectUsingSettings().";
		}
		if (filterchoice == filters.HardLight)
		{
			ELOFMLPCCEA = "Gameplay/Segment-[PowerUp]";
		}
		if (filterchoice == (filters)78)
		{
			ELOFMLPCCEA = "stats on";
		}
		if (filterchoice == (filters)(-86))
		{
			ELOFMLPCCEA = "PenaltyScoreText";
		}
		if (filterchoice == (filters)(-1))
		{
			ELOFMLPCCEA = "1159514800";
		}
		if (filterchoice == (filters)(-22))
		{
			ELOFMLPCCEA = ".a";
		}
		if (filterchoice == (filters)(-72))
		{
			ELOFMLPCCEA = "Players NetIDs:";
		}
	}

	private void HNDNDPECBPL()
	{
	}

	private void FMFNILJIEIA()
	{
		BEHNMDCNKBF = filterchoice;
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -52);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		FEHMFPBAGFG();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ELJEHKEHFLM()
	{
		if (filterchoice != BEHNMDCNKBF)
		{
			CDOAGLJEKKL();
			SCShader = Shader.Find(ELOFMLPCCEA);
			Object.DestroyImmediate(BJFKDHHMLJH);
			if (BJFKDHHMLJH == null)
			{
				BJFKDHHMLJH = new Material(SCShader);
				BJFKDHHMLJH.hideFlags = (HideFlags)120;
			}
		}
		BEHNMDCNKBF = filterchoice;
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 36);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void AFOHBGHNBDI()
	{
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "[LevelEditorScene] Error: Timeout :S";
		}
		if (filterchoice == filters.Multiply)
		{
			ELOFMLPCCEA = "[Up]";
		}
		if (filterchoice == filters.Multiply)
		{
			ELOFMLPCCEA = "workshop.";
		}
		if (filterchoice == filters.DarkerColor)
		{
			ELOFMLPCCEA = "masterSteamID";
		}
		if (filterchoice == filters.Lighten)
		{
			ELOFMLPCCEA = "plainText";
		}
		if (filterchoice == filters.ColorBurn)
		{
			ELOFMLPCCEA = "_ScreenResolution";
		}
		if (filterchoice == filters.LinearBurn)
		{
			ELOFMLPCCEA = "_TimeX";
		}
		if (filterchoice == filters.DarkerColor)
		{
			ELOFMLPCCEA = "workshop.";
		}
		if (filterchoice == filters.Screen)
		{
			ELOFMLPCCEA = "_MainTex2";
		}
		if (filterchoice == (filters)106)
		{
			ELOFMLPCCEA = "_Value2";
		}
		if (filterchoice == (filters)120)
		{
			ELOFMLPCCEA = "recipes";
		}
		if (filterchoice == filters.Subtract)
		{
			ELOFMLPCCEA = "_Value";
		}
		if (filterchoice == (filters)33)
		{
			ELOFMLPCCEA = "Beat Detected";
		}
		if (filterchoice == (filters)(-44))
		{
			ELOFMLPCCEA = "EventSystem";
		}
		if (filterchoice == (filters)(-86))
		{
			ELOFMLPCCEA = "LastNewsButton";
		}
		if (filterchoice == (filters)90)
		{
			ELOFMLPCCEA = "_Value2";
		}
		if (filterchoice == (filters)36)
		{
			ELOFMLPCCEA = "Line";
		}
		if (filterchoice == (filters)44)
		{
			ELOFMLPCCEA = " id: ";
		}
		if (filterchoice == (filters)(-80))
		{
			ELOFMLPCCEA = "#";
		}
		if (filterchoice == (filters)118)
		{
			ELOFMLPCCEA = "STICKRVER";
		}
		if (filterchoice == (filters)59)
		{
			ELOFMLPCCEA = "Tab1Content";
		}
		if (filterchoice == (filters)(-97))
		{
			ELOFMLPCCEA = "CameraFilterPack/TV_VHS";
		}
		if (filterchoice == (filters)120)
		{
			ELOFMLPCCEA = "_AlphaHexa";
		}
		if (filterchoice == (filters)98)
		{
			ELOFMLPCCEA = ": ";
		}
		if (filterchoice == (filters)44)
		{
			ELOFMLPCCEA = "hand";
		}
	}

	private void BEKMLIFILFP()
	{
		BEHNMDCNKBF = filterchoice;
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 89);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		MHNCEEDIKCC();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IBBFFKEAOCE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 849f)
			{
				HBJJOCHGOPH = 1379f;
			}
			if (Camera2 != null)
			{
				HILDKDFEBPF().SetTexture(".completed", JDMCFBKJHDD);
			}
			LPCHMEKDCHI().SetFloat("pointBuffer", HBJJOCHGOPH);
			PEIMCBBHLBJ().SetFloat(": ", BlendFX);
			ECCPAOBFDKP().SetFloat("Exit to menu?", SwitchCameraToCamera2);
			NBMPPNFKFLB().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 850f, 741f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OnValidate()
	{
		if (filterchoice != BEHNMDCNKBF)
		{
			MIPGPMKJELI();
			SCShader = Shader.Find(ELOFMLPCCEA);
			Object.DestroyImmediate(BJFKDHHMLJH);
			if (BJFKDHHMLJH == null)
			{
				BJFKDHHMLJH = new Material(SCShader);
				BJFKDHHMLJH.hideFlags = HideFlags.HideAndDontSave;
			}
		}
		BEHNMDCNKBF = filterchoice;
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void MIPGPMKJELI()
	{
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Darken";
		}
		if (filterchoice == filters.Multiply)
		{
			ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Multiply";
		}
		if (filterchoice == filters.ColorBurn)
		{
			ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_ColorBurn";
		}
		if (filterchoice == filters.LinearBurn)
		{
			ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_LinearBurn";
		}
		if (filterchoice == filters.DarkerColor)
		{
			ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_DarkerColor";
		}
		if (filterchoice == filters.Lighten)
		{
			ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Lighten";
		}
		if (filterchoice == filters.Screen)
		{
			ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Screen";
		}
		if (filterchoice == filters.ColorDodge)
		{
			ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_ColorDodge";
		}
		if (filterchoice == filters.LinearDodge)
		{
			ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_LinearDodge";
		}
		if (filterchoice == filters.LighterColor)
		{
			ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_LighterColor";
		}
		if (filterchoice == filters.Overlay)
		{
			ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Overlay";
		}
		if (filterchoice == filters.SoftLight)
		{
			ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_SoftLight";
		}
		if (filterchoice == filters.HardLight)
		{
			ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_HardLight";
		}
		if (filterchoice == filters.VividLight)
		{
			ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_VividLight";
		}
		if (filterchoice == filters.LinearLight)
		{
			ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_LinearLight";
		}
		if (filterchoice == filters.PinLight)
		{
			ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_PinLight";
		}
		if (filterchoice == filters.HardMix)
		{
			ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_HardMix";
		}
		if (filterchoice == filters.Difference)
		{
			ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Difference";
		}
		if (filterchoice == filters.Exclusion)
		{
			ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Exclusion";
		}
		if (filterchoice == filters.Subtract)
		{
			ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Subtract";
		}
		if (filterchoice == filters.Divide)
		{
			ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Divide";
		}
		if (filterchoice == filters.Hue)
		{
			ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Hue";
		}
		if (filterchoice == filters.Saturation)
		{
			ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Saturation";
		}
		if (filterchoice == filters.Color)
		{
			ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Color";
		}
		if (filterchoice == filters.Luminosity)
		{
			ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Luminosity";
		}
	}

	private void EAFFHHCMLCG()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 5);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void ALJEJJCIMJN()
	{
		BEHNMDCNKBF = filterchoice;
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -46);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		CDOAGLJEKKL();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 369f)
			{
				HBJJOCHGOPH = 1011f;
			}
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture("_Size", JDMCFBKJHDD);
			}
			FKEOGPDLBDD().SetFloat("workshop.", HBJJOCHGOPH);
			HILDKDFEBPF().SetFloat("maphash", BlendFX);
			IFMAPIDFNLI().SetFloat("OnReadyClick", SwitchCameraToCamera2);
			LPDOGGFOBDH().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1457f, 898f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IFMAPIDFNLI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MBKICIMOCGC()
	{
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "EventMenu";
		}
		if (filterchoice == filters.Multiply)
		{
			ELOFMLPCCEA = "SUCCESS! Item submitted! :D :D :D";
		}
		if (filterchoice == filters.LinearBurn)
		{
			ELOFMLPCCEA = "_TimeX";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "_DiffuseColor";
		}
		if (filterchoice == filters.LinearBurn)
		{
			ELOFMLPCCEA = "CameraFilterPack/Edge_Sobel";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "_SweaterSize";
		}
		if (filterchoice == filters.ColorDodge)
		{
			ELOFMLPCCEA = "\n\n#";
		}
		if (filterchoice == filters.Screen)
		{
			ELOFMLPCCEA = ": ";
		}
		if (filterchoice == filters.DarkerColor)
		{
			ELOFMLPCCEA = "y";
		}
		if (filterchoice == (filters)(-98))
		{
			ELOFMLPCCEA = "players";
		}
		if (filterchoice == (filters)(-16))
		{
			ELOFMLPCCEA = "[PlayerController] ";
		}
		if (filterchoice == (filters)(-58))
		{
			ELOFMLPCCEA = ".lastCheckpoint.penaltyScore";
		}
		if (filterchoice == (filters)(-27))
		{
			ELOFMLPCCEA = "_EmissionColor";
		}
		if (filterchoice == (filters)81)
		{
			ELOFMLPCCEA = "[MapsData] Preloading workshop";
		}
		if (filterchoice == (filters)80)
		{
			ELOFMLPCCEA = "_SceneFogMode";
		}
		if (filterchoice == (filters)71)
		{
			ELOFMLPCCEA = "_ScreenResolution";
		}
		if (filterchoice == (filters)(-106))
		{
			ELOFMLPCCEA = "RPCs can only be sent in rooms. Call of \"";
		}
		if (filterchoice == (filters)(-115))
		{
			ELOFMLPCCEA = "CameraFilterPack/Distortion_Heat";
		}
		if (filterchoice == filters.LinearDodge)
		{
			ELOFMLPCCEA = "_FarCamera";
		}
		if (filterchoice == (filters)(-38))
		{
			ELOFMLPCCEA = "_Value1";
		}
		if (filterchoice == (filters)99)
		{
			ELOFMLPCCEA = "vignetteIntensity";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = " - Contains ";
		}
		if (filterchoice == (filters)(-38))
		{
			ELOFMLPCCEA = "0.00";
		}
		if (filterchoice == (filters)34)
		{
			ELOFMLPCCEA = "settings_bindings_sec_";
		}
		if (filterchoice == (filters)(-95))
		{
			ELOFMLPCCEA = "Can't set MaxPlayers when not in that room.";
		}
	}

	private void EKCKJLFFAID()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CKMNIPHKPDD()
	{
		if (filterchoice != BEHNMDCNKBF)
		{
			MENDFOCFMAN();
			SCShader = Shader.Find(ELOFMLPCCEA);
			Object.DestroyImmediate(BJFKDHHMLJH);
			if (BJFKDHHMLJH == null)
			{
				BJFKDHHMLJH = new Material(SCShader);
				BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
			}
		}
		BEHNMDCNKBF = filterchoice;
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 58);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material MFHPKGICPIO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-118);
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
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture("_MainTex2", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat("_TimeX", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value", BlendFX);
			NBPKMLMCHFN.SetFloat("_Value2", SwitchCameraToCamera2);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CCPEDDLAMIB()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LECCHIAFGGE()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FPHLDMMAOEF()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Update()
	{
	}

	private void DGCGGKMNPLD()
	{
	}

	private void DGEPPDJDBLN()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 102);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 318f)
			{
				HBJJOCHGOPH = 1939f;
			}
			if (Camera2 != null)
			{
				KEMJNOMIPHN().SetTexture("_Bullet_11", JDMCFBKJHDD);
			}
			HILDKDFEBPF().SetFloat("|", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("https://twitch.tv/intralism", BlendFX);
			MHBAIEKFBIJ().SetFloat("_ScreenResolution", SwitchCameraToCamera2);
			ADBKPGFMNKO().SetVector("end", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1406f, 860f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HILDKDFEBPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CDOAGLJEKKL()
	{
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "_MinVelocity";
		}
		if (filterchoice == filters.Multiply)
		{
			ELOFMLPCCEA = "_Fade";
		}
		if (filterchoice == filters.ColorBurn)
		{
			ELOFMLPCCEA = "Tab1Content";
		}
		if (filterchoice == filters.ColorDodge)
		{
			ELOFMLPCCEA = "ExitButton";
		}
		if (filterchoice == filters.Multiply)
		{
			ELOFMLPCCEA = "[MapsData] User's maps was loaded";
		}
		if (filterchoice == filters.Lighten)
		{
			ELOFMLPCCEA = "IntraTime";
		}
		if (filterchoice == filters.LinearBurn)
		{
			ELOFMLPCCEA = "CameraFilterPack/Distortion_ShockWave";
		}
		if (filterchoice == filters.Screen)
		{
			ELOFMLPCCEA = "[PlayerBase] Loading checkpoint data";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "Instance\nWorking commands:\ninit or init <savepath>\npath\nsetint <key> <value>\ngetint <key> <value>\nsetfloat <key> <value>\ngetfloat <key> <value>\nsetstring <key> <value>\ngetstring <key> <value>\nsetbool <key> <value>\ngetbool <key> <value>\ndelete <key>\ndeleteall";
		}
		if (filterchoice == (filters)(-123))
		{
			ELOFMLPCCEA = "settings.fps";
		}
		if (filterchoice == (filters)116)
		{
			ELOFMLPCCEA = "y";
		}
		if (filterchoice == (filters)(-50))
		{
			ELOFMLPCCEA = "EditMenu";
		}
		if (filterchoice == (filters)78)
		{
			ELOFMLPCCEA = "SupportLogger OnJoinedLobby(";
		}
		if (filterchoice == (filters)111)
		{
			ELOFMLPCCEA = "http://api.steampowered.com/ISteamNews/GetNewsForApp/v0002/?format=json&appid=513510";
		}
		if (filterchoice == (filters)(-97))
		{
			ELOFMLPCCEA = "#challengecomplete";
		}
		if (filterchoice == (filters)111)
		{
			ELOFMLPCCEA = "Gameplay/LobbyPlayerIconElement";
		}
		if (filterchoice == (filters)(-125))
		{
			ELOFMLPCCEA = "#restart";
		}
		if (filterchoice == (filters)(-106))
		{
			ELOFMLPCCEA = "<color=white>";
		}
		if (filterchoice == (filters)(-18))
		{
			ELOFMLPCCEA = "settings.cameramovements";
		}
		if (filterchoice == (filters)(-56))
		{
			ELOFMLPCCEA = "MultiplayerButton";
		}
		if (filterchoice == (filters)121)
		{
			ELOFMLPCCEA = "CameraFilterPack/Special_Bubble";
		}
		if (filterchoice == (filters)58)
		{
			ELOFMLPCCEA = "_InternalLutParams";
		}
		if (filterchoice == (filters)26)
		{
			ELOFMLPCCEA = "SetSunMaxSize";
		}
		if (filterchoice == (filters)(-11))
		{
			ELOFMLPCCEA = "Emergency Help:";
		}
		if (filterchoice == (filters)(-63))
		{
			ELOFMLPCCEA = "[EditorEvent] Exception: ";
		}
	}

	private void OIAACNGKGML()
	{
		if (filterchoice != BEHNMDCNKBF)
		{
			GBPGJKPMMDN();
			SCShader = Shader.Find(ELOFMLPCCEA);
			Object.DestroyImmediate(BJFKDHHMLJH);
			if (BJFKDHHMLJH == null)
			{
				BJFKDHHMLJH = new Material(SCShader);
				BJFKDHHMLJH.hideFlags = (HideFlags)93;
			}
		}
		BEHNMDCNKBF = filterchoice;
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -62);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material MNLKBFFKHIE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)67;
		}
		return BJFKDHHMLJH;
	}

	private void MAMFKACDKDP()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -100);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void MENDFOCFMAN()
	{
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "_Value4";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "_DiffuseColor";
		}
		if (filterchoice == filters.Lighten)
		{
			ELOFMLPCCEA = "_Value5";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "Bad parameters for setint! Use <key> <value>";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.";
		}
		if (filterchoice == filters.LinearBurn)
		{
			ELOFMLPCCEA = "[RanksSystem] Map hash: ";
		}
		if (filterchoice == filters.Screen)
		{
			ELOFMLPCCEA = "[MenuScene] Error: ";
		}
		if (filterchoice == filters.Lighten)
		{
			ELOFMLPCCEA = "#FFFFFFFF";
		}
		if (filterchoice == filters.LinearDodge)
		{
			ELOFMLPCCEA = "_Value5";
		}
		if (filterchoice == filters.LighterColor)
		{
			ELOFMLPCCEA = "#getrewardfailed: ";
		}
		if (filterchoice == (filters)(-76))
		{
			ELOFMLPCCEA = "PLEASE WAIT";
		}
		if (filterchoice == (filters)98)
		{
			ELOFMLPCCEA = "BitsData";
		}
		if (filterchoice == (filters)47)
		{
			ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_LinearBurn";
		}
		if (filterchoice == (filters)95)
		{
			ELOFMLPCCEA = "CreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.";
		}
		if (filterchoice == (filters)110)
		{
			ELOFMLPCCEA = "_EdgeSize";
		}
		if (filterchoice == (filters)(-56))
		{
			ELOFMLPCCEA = "[EditorEvent] Exception: ";
		}
		if (filterchoice == (filters)(-104))
		{
			ELOFMLPCCEA = "GhostPosY";
		}
		if (filterchoice == (filters)(-71))
		{
			ELOFMLPCCEA = "CameraFilterPack/Glasses_On";
		}
		if (filterchoice == (filters)123)
		{
			ELOFMLPCCEA = "_DiffuseColor";
		}
		if (filterchoice == (filters)85)
		{
			ELOFMLPCCEA = "InfoButton";
		}
		if (filterchoice == filters.PinLight)
		{
			ELOFMLPCCEA = "EventSystem";
		}
		if (filterchoice == (filters)91)
		{
			ELOFMLPCCEA = "UNDISTORT";
		}
		if (filterchoice == (filters)25)
		{
			ELOFMLPCCEA = "workshop.";
		}
		if (filterchoice == (filters)117)
		{
			ELOFMLPCCEA = "maps.";
		}
		if (filterchoice == (filters)86)
		{
			ELOFMLPCCEA = "Called GetNumberOfCurrentPlayers()";
		}
	}

	private void FCKIJIKNMCF()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -112);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void BMHFAMJELFH()
	{
		if (filterchoice != BEHNMDCNKBF)
		{
			LGHFFANDDCM();
			SCShader = Shader.Find(ELOFMLPCCEA);
			Object.DestroyImmediate(BJFKDHHMLJH);
			if (BJFKDHHMLJH == null)
			{
				BJFKDHHMLJH = new Material(SCShader);
				BJFKDHHMLJH.hideFlags = ~HideFlags.DontSave;
			}
		}
		BEHNMDCNKBF = filterchoice;
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -123);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1085f)
			{
				HBJJOCHGOPH = 765f;
			}
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture(".b", JDMCFBKJHDD);
			}
			OIIDAKBILMI().SetFloat("_EmissionGain", HBJJOCHGOPH);
			JIBOKBCPDLC().SetFloat("Gameplay/Base", BlendFX);
			JIBOKBCPDLC().SetFloat("Created", SwitchCameraToCamera2);
			LPCHMEKDCHI().SetVector("colorC", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1625f, 1078f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MNGEPOFPLMA()
	{
		if (filterchoice != BEHNMDCNKBF)
		{
			MBKICIMOCGC();
			SCShader = Shader.Find(ELOFMLPCCEA);
			Object.DestroyImmediate(BJFKDHHMLJH);
			if (BJFKDHHMLJH == null)
			{
				BJFKDHHMLJH = new Material(SCShader);
				BJFKDHHMLJH.hideFlags = (HideFlags)(-83);
			}
		}
		BEHNMDCNKBF = filterchoice;
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -28);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void LBEHKFNPKMC()
	{
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "mapselector.filter.subscribedonly";
		}
		if (filterchoice == filters.Multiply)
		{
			ELOFMLPCCEA = "_Value4";
		}
		if (filterchoice == filters.LinearBurn)
		{
			ELOFMLPCCEA = "RecordButton";
		}
		if (filterchoice == filters.ColorBurn)
		{
			ELOFMLPCCEA = "_VignetteCenter";
		}
		if (filterchoice == filters.LinearDodge)
		{
			ELOFMLPCCEA = "workshop.";
		}
		if (filterchoice == filters.ColorBurn)
		{
			ELOFMLPCCEA = "_ScreenResolution";
		}
		if (filterchoice == filters.Lighten)
		{
			ELOFMLPCCEA = "_ScreenResolution";
		}
		if (filterchoice == filters.ColorDodge)
		{
			ELOFMLPCCEA = "ItemTemplate";
		}
		if (filterchoice == filters.ColorBurn)
		{
			ELOFMLPCCEA = "OK";
		}
		if (filterchoice == (filters)(-128))
		{
			ELOFMLPCCEA = "GlassesColor2";
		}
		if (filterchoice == (filters)124)
		{
			ELOFMLPCCEA = "<b>#";
		}
		if (filterchoice == filters.Overlay)
		{
			ELOFMLPCCEA = "_SunPosition";
		}
		if (filterchoice == (filters)(-36))
		{
			ELOFMLPCCEA = "_WorldToCameraMatrix";
		}
		if (filterchoice == (filters)66)
		{
			ELOFMLPCCEA = "GlassesColor";
		}
		if (filterchoice == (filters)(-8))
		{
			ELOFMLPCCEA = "Noise & Grain effect failing as noise texture is not assigned. please assign.";
		}
		if (filterchoice == (filters)95)
		{
			ELOFMLPCCEA = "hardcoreinfo";
		}
		if (filterchoice == (filters)49)
		{
			ELOFMLPCCEA = "OK";
		}
		if (filterchoice == (filters)68)
		{
			ELOFMLPCCEA = "_LensDirtIntensity";
		}
		if (filterchoice == (filters)(-75))
		{
			ELOFMLPCCEA = "settings.fps";
		}
		if (filterchoice == (filters)(-68))
		{
			ELOFMLPCCEA = "EditMenu";
		}
		if (filterchoice == (filters)(-16))
		{
			ELOFMLPCCEA = "FrostCanvas";
		}
		if (filterchoice == (filters)(-122))
		{
			ELOFMLPCCEA = " methods \"";
		}
		if (filterchoice == (filters)(-7))
		{
			ELOFMLPCCEA = "_Value";
		}
		if (filterchoice == (filters)123)
		{
			ELOFMLPCCEA = "GlassesColor";
		}
		if (filterchoice == (filters)32)
		{
			ELOFMLPCCEA = "https://reddit.com/r/Intralism";
		}
	}

	private void LCHBFNIPBHB()
	{
	}

	private void ALMGMOOHLMA()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AMHEJBMLFNM()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material OCMBHMLNCEK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-96);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material JIBOKBCPDLC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-71);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HILDKDFEBPF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NBMPPNFKFLB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)111;
		}
		return BJFKDHHMLJH;
	}

	private void LGHFFANDDCM()
	{
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "Result for ";
		}
		if (filterchoice == filters.Multiply)
		{
			ELOFMLPCCEA = "_Value6";
		}
		if (filterchoice == filters.LinearBurn)
		{
			ELOFMLPCCEA = "_Offsets";
		}
		if (filterchoice == filters.Screen)
		{
			ELOFMLPCCEA = "_ScreenResolution";
		}
		if (filterchoice == filters.Multiply)
		{
			ELOFMLPCCEA = "Circle";
		}
		if (filterchoice == filters.Lighten)
		{
			ELOFMLPCCEA = "shader.invert";
		}
		if (filterchoice == filters.LinearDodge)
		{
			ELOFMLPCCEA = "UsernameText";
		}
		if (filterchoice == filters.LinearDodge)
		{
			ELOFMLPCCEA = "_History4LumaTex";
		}
		if (filterchoice == filters.Lighten)
		{
			ELOFMLPCCEA = "DPADVER";
		}
		if (filterchoice == filters.ColorDodge)
		{
			ELOFMLPCCEA = "new round";
		}
		if (filterchoice == (filters)(-57))
		{
			ELOFMLPCCEA = "[EditorEvent] Exception: ";
		}
		if (filterchoice == (filters)(-63))
		{
			ELOFMLPCCEA = "1,30,true,0";
		}
		if (filterchoice == (filters)(-34))
		{
			ELOFMLPCCEA = "Bad parameters for setstring! Use <key> <value>";
		}
		if (filterchoice == (filters)(-48))
		{
			ELOFMLPCCEA = "_TimeX";
		}
		if (filterchoice == (filters)(-28))
		{
			ELOFMLPCCEA = "Rotate environment object to the rotation";
		}
		if (filterchoice == (filters)68)
		{
			ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_HardLight";
		}
		if (filterchoice == (filters)(-7))
		{
			ELOFMLPCCEA = "mapselector.filter.subscribedonly";
		}
		if (filterchoice == (filters)80)
		{
			ELOFMLPCCEA = "_Value13";
		}
		if (filterchoice == (filters)(-31))
		{
			ELOFMLPCCEA = "maps.";
		}
		if (filterchoice == (filters)59)
		{
			ELOFMLPCCEA = "Drop_With_Obj";
		}
		if (filterchoice == (filters)45)
		{
			ELOFMLPCCEA = "lobby '{0}'[{1}]";
		}
		if (filterchoice == (filters)121)
		{
			ELOFMLPCCEA = "SetRoomStartTimestamp";
		}
		if (filterchoice == filters.Saturation)
		{
			ELOFMLPCCEA = "InventoryButton";
		}
		if (filterchoice == (filters)(-25))
		{
			ELOFMLPCCEA = "TypedLobbyInfo '{0}'[{1}] rooms: {2} players: {3}";
		}
		if (filterchoice == (filters)(-40))
		{
			ELOFMLPCCEA = "Add Environment Sprite";
		}
	}

	private void HGDDCINLDAD()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PKBENONAOOL()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NBMEBBHCNMH()
	{
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "inventory.selected.";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "Icon";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = ". Name: ";
		}
		if (filterchoice == filters.ColorBurn)
		{
			ELOFMLPCCEA = "_TimeX";
		}
		if (filterchoice == filters.Screen)
		{
			ELOFMLPCCEA = "Image";
		}
		if (filterchoice == filters.DarkerColor)
		{
			ELOFMLPCCEA = "ConnectToMaster() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.";
		}
		if (filterchoice == filters.ColorDodge)
		{
			ELOFMLPCCEA = "EnableRankingToggle";
		}
		if (filterchoice == filters.Multiply)
		{
			ELOFMLPCCEA = "LT";
		}
		if (filterchoice == filters.Lighten)
		{
			ELOFMLPCCEA = "Sent count: ";
		}
		if (filterchoice == (filters)42)
		{
			ELOFMLPCCEA = "Creating awesome maps";
		}
		if (filterchoice == (filters)(-74))
		{
			ELOFMLPCCEA = "---";
		}
		if (filterchoice == (filters)(-56))
		{
			ELOFMLPCCEA = "[Singleton] multiple instances of '";
		}
		if (filterchoice == (filters)46)
		{
			ELOFMLPCCEA = "CameraFilterPack_3D_Myst1";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "RarityImage";
		}
		if (filterchoice == (filters)61)
		{
			ELOFMLPCCEA = "#ok";
		}
		if (filterchoice == (filters)69)
		{
			ELOFMLPCCEA = "_Value";
		}
		if (filterchoice == (filters)(-49))
		{
			ELOFMLPCCEA = "_NoiseTilingPerChannel";
		}
		if (filterchoice == (filters)(-117))
		{
			ELOFMLPCCEA = "Instantiating: ";
		}
		if (filterchoice == (filters)(-3))
		{
			ELOFMLPCCEA = "_Value4";
		}
		if (filterchoice == (filters)57)
		{
			ELOFMLPCCEA = "_ScreenResolution";
		}
		if (filterchoice == (filters)101)
		{
			ELOFMLPCCEA = "#C8C8C8FF";
		}
		if (filterchoice == (filters)48)
		{
			ELOFMLPCCEA = "_ScreenResolution";
		}
		if (filterchoice == (filters)(-20))
		{
			ELOFMLPCCEA = "source";
		}
		if (filterchoice == (filters)88)
		{
			ELOFMLPCCEA = "inventory.itemscash";
		}
		if (filterchoice == (filters)35)
		{
			ELOFMLPCCEA = "music.ogg";
		}
	}

	private void NPLCENPNJBM()
	{
		BEHNMDCNKBF = filterchoice;
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -86);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		MBKICIMOCGC();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material PEIMCBBHLBJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	private void ALJEADNKJPO()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EBBMDDEFNKL()
	{
		if (filterchoice != BEHNMDCNKBF)
		{
			LBEHKFNPKMC();
			SCShader = Shader.Find(ELOFMLPCCEA);
			Object.DestroyImmediate(BJFKDHHMLJH);
			if (BJFKDHHMLJH == null)
			{
				BJFKDHHMLJH = new Material(SCShader);
				BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
			}
		}
		BEHNMDCNKBF = filterchoice;
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 28);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void CKFICFFNDFJ()
	{
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "SpectateButton";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "CheckResources () for ";
		}
		if (filterchoice == filters.DarkerColor)
		{
			ELOFMLPCCEA = "false";
		}
		if (filterchoice == filters.Lighten)
		{
			ELOFMLPCCEA = " = ";
		}
		if (filterchoice == filters.Lighten)
		{
			ELOFMLPCCEA = "Image";
		}
		if (filterchoice == filters.LinearBurn)
		{
			ELOFMLPCCEA = "#tryagain";
		}
		if (filterchoice == filters.Lighten)
		{
			ELOFMLPCCEA = "_Contrast";
		}
		if (filterchoice == filters.ColorDodge)
		{
			ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Saturation";
		}
		if (filterchoice == filters.ColorDodge)
		{
			ELOFMLPCCEA = "Fade";
		}
		if (filterchoice == (filters)26)
		{
			ELOFMLPCCEA = "CheckpointsScoreText";
		}
		if (filterchoice == (filters)(-125))
		{
			ELOFMLPCCEA = "_EmissionColor";
		}
		if (filterchoice == (filters)(-78))
		{
			ELOFMLPCCEA = "LoadPlayerSkin";
		}
		if (filterchoice == (filters)(-34))
		{
			ELOFMLPCCEA = "BitsData";
		}
		if (filterchoice == (filters)66)
		{
			ELOFMLPCCEA = "_EdgeThreshold";
		}
		if (filterchoice == (filters)(-71))
		{
			ELOFMLPCCEA = "_ReflectionTexture1";
		}
		if (filterchoice == filters.Subtract)
		{
			ELOFMLPCCEA = "CameraFilterPack/Drawing_BluePrint";
		}
		if (filterchoice == (filters)25)
		{
			ELOFMLPCCEA = "Editor";
		}
		if (filterchoice == (filters)(-19))
		{
			ELOFMLPCCEA = "[EditorEvent] Exception: ";
		}
		if (filterchoice == (filters)(-71))
		{
			ELOFMLPCCEA = "/";
		}
		if (filterchoice == (filters)109)
		{
			ELOFMLPCCEA = "Misses:";
		}
		if (filterchoice == (filters)44)
		{
			ELOFMLPCCEA = "Mouse";
		}
		if (filterchoice == (filters)(-95))
		{
			ELOFMLPCCEA = "Case-Sensitive";
		}
		if (filterchoice == (filters)43)
		{
			ELOFMLPCCEA = "player.goldarc";
		}
		if (filterchoice == (filters)(-39))
		{
			ELOFMLPCCEA = "mapselector.lastSearch";
		}
		if (filterchoice == filters.Luminosity)
		{
			ELOFMLPCCEA = "1427616858";
		}
	}

	private void JHPOIOELNCG()
	{
	}

	private void JOPCCCCHNLI()
	{
		BEHNMDCNKBF = filterchoice;
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -43);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		LGHFFANDDCM();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LPMINJJPDCH()
	{
	}

	private void KNBJBNDGCIJ()
	{
		BEHNMDCNKBF = filterchoice;
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -32);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		CKFICFFNDFJ();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OFPPIKHNJOD()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material FKEOGPDLBDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)105;
		}
		return BJFKDHHMLJH;
	}

	private void JFMIDILENDO()
	{
	}

	[SpecialName]
	private Material LPCHMEKDCHI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void LKBOEPPBLIF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1783f)
			{
				HBJJOCHGOPH = 526f;
			}
			if (Camera2 != null)
			{
				NBMPPNFKFLB().SetTexture("MenuVolumeSlider", JDMCFBKJHDD);
			}
			ADBKPGFMNKO().SetFloat("Show text at the center of the screen. Usefull for quick messages like 'Thanks for playing!'", HBJJOCHGOPH);
			KEMJNOMIPHN().SetFloat("settings.volume.sfx", BlendFX);
			KEMJNOMIPHN().SetFloat("Gameplay/sun", SwitchCameraToCamera2);
			ECCPAOBFDKP().SetVector("win", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 272f, 466f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IFMAPIDFNLI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material KEMJNOMIPHN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-117);
		}
		return BJFKDHHMLJH;
	}

	private void EDBEHEKMGFH()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LGJAHGCLMLE()
	{
		if (filterchoice != BEHNMDCNKBF)
		{
			MENDFOCFMAN();
			SCShader = Shader.Find(ELOFMLPCCEA);
			Object.DestroyImmediate(BJFKDHHMLJH);
			if (BJFKDHHMLJH == null)
			{
				BJFKDHHMLJH = new Material(SCShader);
				BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInEditor;
			}
		}
		BEHNMDCNKBF = filterchoice;
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 55);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void HGPLPMCJNLL()
	{
		if (filterchoice != BEHNMDCNKBF)
		{
			CDOAGLJEKKL();
			SCShader = Shader.Find(ELOFMLPCCEA);
			Object.DestroyImmediate(BJFKDHHMLJH);
			if (BJFKDHHMLJH == null)
			{
				BJFKDHHMLJH = new Material(SCShader);
				BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
			}
		}
		BEHNMDCNKBF = filterchoice;
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 16);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material MPENCEIGLEH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-120);
		}
		return BJFKDHHMLJH;
	}

	private void IGCBJKFAFEH()
	{
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "/";
		}
		if (filterchoice == filters.Multiply)
		{
			ELOFMLPCCEA = "maps.";
		}
		if (filterchoice == filters.LinearDodge)
		{
			ELOFMLPCCEA = "_ScreenResolution";
		}
		if (filterchoice == filters.Screen)
		{
			ELOFMLPCCEA = "setAF";
		}
		if (filterchoice == filters.LinearBurn)
		{
			ELOFMLPCCEA = "settings.arcsdestroydelay";
		}
		if (filterchoice == filters.ColorBurn)
		{
			ELOFMLPCCEA = "_Value2";
		}
		if (filterchoice == filters.Multiply)
		{
			ELOFMLPCCEA = "_TimeX";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "mapid";
		}
		if (filterchoice == filters.Multiply)
		{
			ELOFMLPCCEA = "#ok";
		}
		if (filterchoice == (filters)(-64))
		{
			ELOFMLPCCEA = "_HeightParams";
		}
		if (filterchoice == (filters)77)
		{
			ELOFMLPCCEA = "error";
		}
		if (filterchoice == (filters)(-34))
		{
			ELOFMLPCCEA = "rarity";
		}
		if (filterchoice == (filters)123)
		{
			ELOFMLPCCEA = "LevelEditor/patterns";
		}
		if (filterchoice == (filters)(-122))
		{
			ELOFMLPCCEA = "value";
		}
		if (filterchoice == (filters)69)
		{
			ELOFMLPCCEA = "colorD";
		}
		if (filterchoice == filters.Difference)
		{
			ELOFMLPCCEA = "#";
		}
		if (filterchoice == (filters)70)
		{
			ELOFMLPCCEA = "_Blur";
		}
		if (filterchoice == (filters)79)
		{
			ELOFMLPCCEA = "_TimeX";
		}
		if (filterchoice == (filters)(-21))
		{
			ELOFMLPCCEA = "...";
		}
		if (filterchoice == filters.Hue)
		{
			ELOFMLPCCEA = "menu.selectedlevelid";
		}
		if (filterchoice == (filters)(-99))
		{
			ELOFMLPCCEA = "GhostFade2";
		}
		if (filterchoice == (filters)(-91))
		{
			ELOFMLPCCEA = "No peer to communicate with. ";
		}
		if (filterchoice == (filters)(-78))
		{
			ELOFMLPCCEA = "_BlurredColor";
		}
		if (filterchoice == (filters)(-12))
		{
			ELOFMLPCCEA = "_ScreenResolution";
		}
		if (filterchoice == (filters)(-5))
		{
			ELOFMLPCCEA = "finished";
		}
	}

	private void GLNBNEJBMHA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 91);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void FCKMAOMOKNB()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -91);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void IJCBBIJOCAH()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 16);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material OIIDAKBILMI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)90;
		}
		return BJFKDHHMLJH;
	}

	private void ELHFAMLBLHM()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 54);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void LICOLMAOHKI()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -27);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void JKBMKPDGCHG()
	{
		BEHNMDCNKBF = filterchoice;
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -58);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		MBKICIMOCGC();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GFHPLCFNACM()
	{
		if (filterchoice != BEHNMDCNKBF)
		{
			CDOAGLJEKKL();
			SCShader = Shader.Find(ELOFMLPCCEA);
			Object.DestroyImmediate(BJFKDHHMLJH);
			if (BJFKDHHMLJH == null)
			{
				BJFKDHHMLJH = new Material(SCShader);
				BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy;
			}
		}
		BEHNMDCNKBF = filterchoice;
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 96);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void CFFCLAHMBAA()
	{
		BEHNMDCNKBF = filterchoice;
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 42);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		GOCIGGGHANF();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JHBPINEKDPE()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -34);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void OLCOOJIONIL()
	{
		if (filterchoice != BEHNMDCNKBF)
		{
			MENDFOCFMAN();
			SCShader = Shader.Find(ELOFMLPCCEA);
			Object.DestroyImmediate(BJFKDHHMLJH);
			if (BJFKDHHMLJH == null)
			{
				BJFKDHHMLJH = new Material(SCShader);
				BJFKDHHMLJH.hideFlags = ~(HideFlags.HideAndDontSave | HideFlags.HideInInspector);
			}
		}
		BEHNMDCNKBF = filterchoice;
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 53);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void OKHBBIKDIEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1329f)
			{
				HBJJOCHGOPH = 323f;
			}
			if (Camera2 != null)
			{
				OIIDAKBILMI().SetTexture("offsets", JDMCFBKJHDD);
			}
			MFHPKGICPIO().SetFloat("_BlurParams", HBJJOCHGOPH);
			JIBOKBCPDLC().SetFloat("Player Disconnected", BlendFX);
			DOMEEFLPEPJ().SetFloat("_ScreenResolution", SwitchCameraToCamera2);
			OCMBHMLNCEK().SetVector("Set Crosshair Color", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 776f, 1646f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CNGAJDBOCLJ()
	{
		BEHNMDCNKBF = filterchoice;
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 27);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		JOLDJFOBCLO();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LNOOFNGHNEL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1825f)
			{
				HBJJOCHGOPH = 1863f;
			}
			if (Camera2 != null)
			{
				PEIMCBBHLBJ().SetTexture(" | ", JDMCFBKJHDD);
			}
			MHBAIEKFBIJ().SetFloat("_MainTex2", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("CameraFilterPack/Drawing_CellShading2", BlendFX);
			ECCPAOBFDKP().SetFloat(" connected: ", SwitchCameraToCamera2);
			MPENCEIGLEH().SetVector("-", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 901f, 1635f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 645f)
			{
				HBJJOCHGOPH = 581f;
			}
			if (Camera2 != null)
			{
				MPENCEIGLEH().SetTexture("Game Version: ", JDMCFBKJHDD);
			}
			LPCHMEKDCHI().SetFloat("Destroy(targetPhotonView) failed, cause targetPhotonView is null.", HBJJOCHGOPH);
			PEIMCBBHLBJ().SetFloat("maps.", BlendFX);
			MPENCEIGLEH().SetFloat("Square", SwitchCameraToCamera2);
			EFDEIFCDAFG().SetVector("_History2ChromaTex", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1128f, 1845f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IFMAPIDFNLI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OnDisable()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EJFJENFKLND()
	{
	}

	private void GHICDLBKEJN()
	{
		if (filterchoice != BEHNMDCNKBF)
		{
			IGCBJKFAFEH();
			SCShader = Shader.Find(ELOFMLPCCEA);
			Object.DestroyImmediate(BJFKDHHMLJH);
			if (BJFKDHHMLJH == null)
			{
				BJFKDHHMLJH = new Material(SCShader);
				BJFKDHHMLJH.hideFlags = (HideFlags)(-101);
			}
		}
		BEHNMDCNKBF = filterchoice;
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 65);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void PMAADPNNHKK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -22);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void DPKJPFEIHOB()
	{
		if (filterchoice != BEHNMDCNKBF)
		{
			GBPGJKPMMDN();
			SCShader = Shader.Find(ELOFMLPCCEA);
			Object.DestroyImmediate(BJFKDHHMLJH);
			if (BJFKDHHMLJH == null)
			{
				BJFKDHHMLJH = new Material(SCShader);
				BJFKDHHMLJH.hideFlags = (HideFlags)(-96);
			}
		}
		BEHNMDCNKBF = filterchoice;
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -98);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1934f)
			{
				HBJJOCHGOPH = 1912f;
			}
			if (Camera2 != null)
			{
				PEIMCBBHLBJ().SetTexture("CameraFilterPack/Blend2Camera_LinearLight", JDMCFBKJHDD);
			}
			MPENCEIGLEH().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			OKJOKHGJHGF().SetFloat("PlayerBase_", BlendFX);
			FKEOGPDLBDD().SetFloat("y", SwitchCameraToCamera2);
			HILDKDFEBPF().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 60f, 1011f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IFMAPIDFNLI());
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
			if (HBJJOCHGOPH > 1056f)
			{
				HBJJOCHGOPH = 635f;
			}
			if (Camera2 != null)
			{
				MFHPKGICPIO().SetTexture("Texture3", JDMCFBKJHDD);
			}
			DOMEEFLPEPJ().SetFloat("&page=", HBJJOCHGOPH);
			LPCHMEKDCHI().SetFloat("CameraFilterPack/Edge_Sobel", BlendFX);
			IFMAPIDFNLI().SetFloat("SetScale", SwitchCameraToCamera2);
			ECCPAOBFDKP().SetVector("Object ID. Case-Sensitive", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 405f, 651f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HILDKDFEBPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OKHGJFFIIBA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 89);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void DBLILJGKGHJ()
	{
		BEHNMDCNKBF = filterchoice;
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -28);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		MBKICIMOCGC();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AJBHOEBKGDO()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 100);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void CFIAKIJAILI()
	{
	}

	private void LKPBGHGCPKL()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -50);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void DDBOODLPCAM()
	{
	}

	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 559f)
			{
				HBJJOCHGOPH = 1988f;
			}
			if (Camera2 != null)
			{
				FKEOGPDLBDD().SetTexture("skin.hit_wrong", JDMCFBKJHDD);
			}
			LPCHMEKDCHI().SetFloat("ERROR You should never change PhotonPlayer IDs!", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_TimeX", BlendFX);
			LPCHMEKDCHI().SetFloat("https://steamcommunity.com/sharedfiles/filedetails/?id=", SwitchCameraToCamera2);
			LPDOGGFOBDH().SetVector("_Value7", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 268f, 1638f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GBPGJKPMMDN()
	{
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "Text";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "\t";
		}
		if (filterchoice == filters.ColorDodge)
		{
			ELOFMLPCCEA = "Floating point textures aren't supported on this device ({0})";
		}
		if (filterchoice == filters.ColorBurn)
		{
			ELOFMLPCCEA = "[LevelEditorScene] Map submitted!";
		}
		if (filterchoice == filters.ColorDodge)
		{
			ELOFMLPCCEA = "[DiscordController] Responding yes to Ask to Join request";
		}
		if (filterchoice == filters.ColorDodge)
		{
			ELOFMLPCCEA = "CameraFilterPack/3D_Binary";
		}
		if (filterchoice == filters.ColorDodge)
		{
			ELOFMLPCCEA = "MaxLivesSlider";
		}
		if (filterchoice == filters.Screen)
		{
			ELOFMLPCCEA = " = ";
		}
		if (filterchoice == filters.ColorDodge)
		{
			ELOFMLPCCEA = "Have you fully accept the terms?";
		}
		if (filterchoice == (filters)(-114))
		{
			ELOFMLPCCEA = "time";
		}
		if (filterchoice == (filters)(-101))
		{
			ELOFMLPCCEA = "New resource ID. Case-Sensitive";
		}
		if (filterchoice == (filters)30)
		{
			ELOFMLPCCEA = "NEW_ACHIEVEMENT_1_";
		}
		if (filterchoice == (filters)(-80))
		{
			ELOFMLPCCEA = "Object ID. Case-Sensitive";
		}
		if (filterchoice == (filters)(-107))
		{
			ELOFMLPCCEA = "_Value11";
		}
		if (filterchoice == (filters)49)
		{
			ELOFMLPCCEA = "CameraFilterPack/Drawing_EnhancedComics";
		}
		if (filterchoice == filters.PinLight)
		{
			ELOFMLPCCEA = "UseFinalGlassColor";
		}
		if (filterchoice == (filters)(-30))
		{
			ELOFMLPCCEA = "_Value6";
		}
		if (filterchoice == (filters)36)
		{
			ELOFMLPCCEA = "note.0";
		}
		if (filterchoice == (filters)48)
		{
			ELOFMLPCCEA = "Music End";
		}
		if (filterchoice == (filters)90)
		{
			ELOFMLPCCEA = "Speed";
		}
		if (filterchoice == (filters)123)
		{
			ELOFMLPCCEA = "Write me to get one for testing :)";
		}
		if (filterchoice == (filters)(-101))
		{
			ELOFMLPCCEA = "_Bloom0";
		}
		if (filterchoice == (filters)(-28))
		{
			ELOFMLPCCEA = "LevelEditor/icons";
		}
		if (filterchoice == (filters)76)
		{
			ELOFMLPCCEA = "High";
		}
		if (filterchoice == (filters)(-121))
		{
			ELOFMLPCCEA = "_TimeX";
		}
	}

	private void OEFNBKHNJND()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 53);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void MDCFIHDPLIG()
	{
	}

	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1843f)
			{
				HBJJOCHGOPH = 1208f;
			}
			if (Camera2 != null)
			{
				OKJOKHGJHGF().SetTexture("buttons", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat("[Up]", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("UseFinalGlassColor", BlendFX);
			LPDOGGFOBDH().SetFloat("challenges.", SwitchCameraToCamera2);
			NBMPPNFKFLB().SetVector("SetSunMaxSize", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1682f, 1371f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MHBAIEKFBIJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JOLDJFOBCLO()
	{
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "isVisible";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "0 seconds";
		}
		if (filterchoice == filters.Screen)
		{
			ELOFMLPCCEA = "PointsScoreText";
		}
		if (filterchoice == filters.LinearDodge)
		{
			ELOFMLPCCEA = "_Value";
		}
		if (filterchoice == filters.LinearDodge)
		{
			ELOFMLPCCEA = "JoinRandom failed: No open game. Calling: OnPhotonRandomJoinFailed() and staying on master server.";
		}
		if (filterchoice == filters.LinearDodge)
		{
			ELOFMLPCCEA = "_Value3";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "OpGetGameList()";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "_Distance";
		}
		if (filterchoice == filters.LinearBurn)
		{
			ELOFMLPCCEA = "CameraFilterPack_VHS1";
		}
		if (filterchoice == (filters)(-61))
		{
			ELOFMLPCCEA = "OK";
		}
		if (filterchoice == (filters)(-73))
		{
			ELOFMLPCCEA = "_ScreenResolution";
		}
		if (filterchoice == (filters)(-89))
		{
			ELOFMLPCCEA = "PUN-instantiated '";
		}
		if (filterchoice == (filters)82)
		{
			ELOFMLPCCEA = ". The RPC has been ignored.";
		}
		if (filterchoice == (filters)52)
		{
			ELOFMLPCCEA = "Offline or in OfflineMode. No VitalStats available.";
		}
		if (filterchoice == (filters)(-60))
		{
			ELOFMLPCCEA = "Map already submited. Update?";
		}
		if (filterchoice == (filters)(-86))
		{
			ELOFMLPCCEA = "_Offsets";
		}
		if (filterchoice == (filters)(-107))
		{
			ELOFMLPCCEA = "_TimeX";
		}
		if (filterchoice == filters.LinearDodge)
		{
			ELOFMLPCCEA = "_Near";
		}
		if (filterchoice == (filters)26)
		{
			ELOFMLPCCEA = "Failed to InstantiateSceneObject prefab:";
		}
		if (filterchoice == (filters)(-56))
		{
			ELOFMLPCCEA = "#ok";
		}
		if (filterchoice == (filters)(-26))
		{
			ELOFMLPCCEA = ":";
		}
		if (filterchoice == (filters)127)
		{
			ELOFMLPCCEA = "_Visualize";
		}
		if (filterchoice == (filters)82)
		{
			ELOFMLPCCEA = "downloading";
		}
		if (filterchoice == (filters)(-10))
		{
			ELOFMLPCCEA = "_Value3";
		}
		if (filterchoice == (filters)90)
		{
			ELOFMLPCCEA = "{0}_{1}";
		}
	}

	private void FEHMFPBAGFG()
	{
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "menutheme.27thfloor";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "_ScreenResolution";
		}
		if (filterchoice == filters.ColorBurn)
		{
			ELOFMLPCCEA = ".";
		}
		if (filterchoice == filters.Multiply)
		{
			ELOFMLPCCEA = "Edited event";
		}
		if (filterchoice == filters.LinearBurn)
		{
			ELOFMLPCCEA = "_Value";
		}
		if (filterchoice == filters.ColorDodge)
		{
			ELOFMLPCCEA = "_Distortion";
		}
		if (filterchoice == filters.Lighten)
		{
			ELOFMLPCCEA = "_ScreenResolution";
		}
		if (filterchoice == filters.Multiply)
		{
			ELOFMLPCCEA = "HandsCountSlider";
		}
		if (filterchoice == filters.Screen)
		{
			ELOFMLPCCEA = "_Value7";
		}
		if (filterchoice == (filters)(-42))
		{
			ELOFMLPCCEA = "_ScreenResolution";
		}
		if (filterchoice == (filters)100)
		{
			ELOFMLPCCEA = ".lastCheckpoint.correctScore";
		}
		if (filterchoice == (filters)80)
		{
			ELOFMLPCCEA = "_PositionX";
		}
		if (filterchoice == (filters)65)
		{
			ELOFMLPCCEA = "bool";
		}
		if (filterchoice == (filters)52)
		{
			ELOFMLPCCEA = "_Value";
		}
		if (filterchoice == (filters)37)
		{
			ELOFMLPCCEA = "_Value";
		}
		if (filterchoice == filters.Subtract)
		{
			ELOFMLPCCEA = "/";
		}
		if (filterchoice == (filters)(-75))
		{
			ELOFMLPCCEA = "LevelProgressBar";
		}
		if (filterchoice == (filters)(-15))
		{
			ELOFMLPCCEA = "caret";
		}
		if (filterchoice == (filters)116)
		{
			ELOFMLPCCEA = "Authentication failed: '{0}' Code: {1}";
		}
		if (filterchoice == (filters)(-6))
		{
			ELOFMLPCCEA = "???";
		}
		if (filterchoice == filters.Hue)
		{
			ELOFMLPCCEA = "Set Object Position";
		}
		if (filterchoice == (filters)(-53))
		{
			ELOFMLPCCEA = "challenges.";
		}
		if (filterchoice == (filters)(-19))
		{
			ELOFMLPCCEA = "[MenuScene] Error: ";
		}
		if (filterchoice == (filters)(-74))
		{
			ELOFMLPCCEA = "PlayersScrollRectContent";
		}
		if (filterchoice == (filters)(-124))
		{
			ELOFMLPCCEA = "cancel";
		}
	}

	private void GOCIGGGHANF()
	{
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "_Size";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "{0}";
		}
		if (filterchoice == filters.Lighten)
		{
			ELOFMLPCCEA = "SelectorMusicToggle";
		}
		if (filterchoice == filters.Lighten)
		{
			ELOFMLPCCEA = "Joystick1Button6";
		}
		if (filterchoice == filters.ColorBurn)
		{
			ELOFMLPCCEA = "PossibleMapMaxScoreText";
		}
		if (filterchoice == filters.DarkerColor)
		{
			ELOFMLPCCEA = "ItemTemplate";
		}
		if (filterchoice == filters.Multiply)
		{
			ELOFMLPCCEA = "HostType: {0} ";
		}
		if (filterchoice == filters.ColorDodge)
		{
			ELOFMLPCCEA = "[LevelEditorScene] Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(";
		}
		if (filterchoice == filters.LinearDodge)
		{
			ELOFMLPCCEA = "#rategameinfo";
		}
		if (filterchoice == (filters)(-54))
		{
			ELOFMLPCCEA = "_TimeX";
		}
		if (filterchoice == (filters)83)
		{
			ELOFMLPCCEA = "907198288";
		}
		if (filterchoice == (filters)(-92))
		{
			ELOFMLPCCEA = ",";
		}
		if (filterchoice == (filters)102)
		{
			ELOFMLPCCEA = "MaxLivesSlider";
		}
		if (filterchoice == (filters)(-8))
		{
			ELOFMLPCCEA = "The server address is 127.0.0.1 (localhost): Make sure the server is running on this machine. Android and iOS emulators have their own localhost.";
		}
		if (filterchoice == (filters)125)
		{
			ELOFMLPCCEA = "_Greenness";
		}
		if (filterchoice == (filters)74)
		{
			ELOFMLPCCEA = "#forever";
		}
		if (filterchoice == (filters)(-45))
		{
			ELOFMLPCCEA = "3;4;9;10;21x6";
		}
		if (filterchoice == (filters)(-93))
		{
			ELOFMLPCCEA = "_Value5";
		}
		if (filterchoice == (filters)58)
		{
			ELOFMLPCCEA = "SetParticlesParticleSize";
		}
		if (filterchoice == (filters)(-88))
		{
			ELOFMLPCCEA = "note.1";
		}
		if (filterchoice == (filters)(-78))
		{
			ELOFMLPCCEA = "Vertical";
		}
		if (filterchoice == (filters)(-103))
		{
			ELOFMLPCCEA = " Path: ";
		}
		if (filterchoice == (filters)121)
		{
			ELOFMLPCCEA = "Set satellite trail width";
		}
		if (filterchoice == (filters)98)
		{
			ELOFMLPCCEA = "Had to lookup view that wasn't in photonViewList: ";
		}
		if (filterchoice == (filters)43)
		{
			ELOFMLPCCEA = "FreqVolume: ";
		}
	}

	private void HNLPEJJPEGA()
	{
		if (filterchoice != BEHNMDCNKBF)
		{
			LGHFFANDDCM();
			SCShader = Shader.Find(ELOFMLPCCEA);
			Object.DestroyImmediate(BJFKDHHMLJH);
			if (BJFKDHHMLJH == null)
			{
				BJFKDHHMLJH = new Material(SCShader);
				BJFKDHHMLJH.hideFlags = (HideFlags)(-74);
			}
		}
		BEHNMDCNKBF = filterchoice;
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -104);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void JKFDDNMPOJH()
	{
		BEHNMDCNKBF = filterchoice;
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 74);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		CKFICFFNDFJ();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HENBNNAGIKN()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -92);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void AGFGKIBHCBE()
	{
		if (filterchoice != BEHNMDCNKBF)
		{
			AFOHBGHNBDI();
			SCShader = Shader.Find(ELOFMLPCCEA);
			Object.DestroyImmediate(BJFKDHHMLJH);
			if (BJFKDHHMLJH == null)
			{
				BJFKDHHMLJH = new Material(SCShader);
				BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
			}
		}
		BEHNMDCNKBF = filterchoice;
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -6);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void MDGFFKJFLBH()
	{
		if (filterchoice != BEHNMDCNKBF)
		{
			CGCHMJCJOBB();
			SCShader = Shader.Find(ELOFMLPCCEA);
			Object.DestroyImmediate(BJFKDHHMLJH);
			if (BJFKDHHMLJH == null)
			{
				BJFKDHHMLJH = new Material(SCShader);
				BJFKDHHMLJH.hideFlags = (HideFlags)(-81);
			}
		}
		BEHNMDCNKBF = filterchoice;
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 74);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void OFBLDOCCBBN()
	{
		if (filterchoice != BEHNMDCNKBF)
		{
			CGCHMJCJOBB();
			SCShader = Shader.Find(ELOFMLPCCEA);
			Object.DestroyImmediate(BJFKDHHMLJH);
			if (BJFKDHHMLJH == null)
			{
				BJFKDHHMLJH = new Material(SCShader);
				BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor;
			}
		}
		BEHNMDCNKBF = filterchoice;
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 47);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void FMNPFCHBLJF()
	{
		BEHNMDCNKBF = filterchoice;
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 52);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		MIPGPMKJELI();
		SCShader = Shader.Find(ELOFMLPCCEA);
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-98);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material LPDOGGFOBDH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-65);
		}
		return BJFKDHHMLJH;
	}

	private void MELKBLIIFEO()
	{
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "_ScreenResolution";
		}
		if (filterchoice == filters.Multiply)
		{
			ELOFMLPCCEA = "<color=#";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "[Down]";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.";
		}
		if (filterchoice == filters.ColorDodge)
		{
			ELOFMLPCCEA = "[EditorEvent] Exception: ";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "CameraFilterPack/Color_Noise";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "SettingsCanvas";
		}
		if (filterchoice == filters.LinearBurn)
		{
			ELOFMLPCCEA = "Object ID. Case-Sensitive";
		}
		if (filterchoice == filters.ColorDodge)
		{
			ELOFMLPCCEA = "_EmissionColor";
		}
		if (filterchoice == (filters)36)
		{
			ELOFMLPCCEA = "_TimeX";
		}
		if (filterchoice == (filters)(-17))
		{
			ELOFMLPCCEA = "[PlayerBase] Saveing checkpoint data";
		}
		if (filterchoice == (filters)(-28))
		{
			ELOFMLPCCEA = "[FileSelector] Starting file dialog";
		}
		if (filterchoice == (filters)58)
		{
			ELOFMLPCCEA = "_Red_B";
		}
		if (filterchoice == (filters)(-102))
		{
			ELOFMLPCCEA = ",";
		}
		if (filterchoice == (filters)(-83))
		{
			ELOFMLPCCEA = "closed";
		}
		if (filterchoice == (filters)83)
		{
			ELOFMLPCCEA = "_TimeX";
		}
		if (filterchoice == (filters)(-48))
		{
			ELOFMLPCCEA = "Exception while connecting to: ";
		}
		if (filterchoice == (filters)(-39))
		{
			ELOFMLPCCEA = "_Green_B";
		}
		if (filterchoice == (filters)(-74))
		{
			ELOFMLPCCEA = "Mouse Y";
		}
		if (filterchoice == (filters)(-96))
		{
			ELOFMLPCCEA = "CameraFilterPack/Light_Rainbow";
		}
		if (filterchoice == (filters)(-9))
		{
			ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_LinearDodge";
		}
		if (filterchoice == (filters)108)
		{
			ELOFMLPCCEA = "workshop.txt";
		}
		if (filterchoice == filters.PinLight)
		{
			ELOFMLPCCEA = "_SubsampleIndices";
		}
		if (filterchoice == (filters)(-57))
		{
			ELOFMLPCCEA = "ticket";
		}
		if (filterchoice == (filters)(-81))
		{
			ELOFMLPCCEA = "ready";
		}
	}

	[SpecialName]
	private Material DOMEEFLPEPJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-118);
		}
		return BJFKDHHMLJH;
	}

	private void MFOOCOIIIJN()
	{
		if (filterchoice != BEHNMDCNKBF)
		{
			CGCHMJCJOBB();
			SCShader = Shader.Find(ELOFMLPCCEA);
			Object.DestroyImmediate(BJFKDHHMLJH);
			if (BJFKDHHMLJH == null)
			{
				BJFKDHHMLJH = new Material(SCShader);
				BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
			}
		}
		BEHNMDCNKBF = filterchoice;
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -93);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void MPJAFNJLBEF()
	{
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "Fade";
		}
		if (filterchoice == filters.Multiply)
		{
			ELOFMLPCCEA = "_DepthLevel";
		}
		if (filterchoice == filters.Multiply)
		{
			ELOFMLPCCEA = "CameraFilterPack/Drawing_Manga5";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "_History3ChromaTex";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "SetParticlesGravity";
		}
		if (filterchoice == filters.Lighten)
		{
			ELOFMLPCCEA = "_ScreenResolution";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "Skipping EstablishEncryption. Protocol is secure.";
		}
		if (filterchoice == filters.DarkerColor)
		{
			ELOFMLPCCEA = "_Y";
		}
		if (filterchoice == filters.Multiply)
		{
			ELOFMLPCCEA = "Spawn new environment object (sun, satellite etc) and sets its id";
		}
		if (filterchoice == (filters)33)
		{
			ELOFMLPCCEA = "RootCanvas";
		}
		if (filterchoice == (filters)(-95))
		{
			ELOFMLPCCEA = "settings_bindings_";
		}
		if (filterchoice == (filters)(-125))
		{
			ELOFMLPCCEA = "Reconnect() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.";
		}
		if (filterchoice == (filters)84)
		{
			ELOFMLPCCEA = "0";
		}
		if (filterchoice == (filters)114)
		{
			ELOFMLPCCEA = "_DistanceParams";
		}
		if (filterchoice == (filters)(-92))
		{
			ELOFMLPCCEA = "_Value4";
		}
		if (filterchoice == (filters)51)
		{
			ELOFMLPCCEA = "settings.volume.menu";
		}
		if (filterchoice == (filters)(-27))
		{
			ELOFMLPCCEA = "[Up-Right-Down-Left]";
		}
		if (filterchoice == (filters)(-63))
		{
			ELOFMLPCCEA = "checkpoint";
		}
		if (filterchoice == (filters)39)
		{
			ELOFMLPCCEA = "offsets";
		}
		if (filterchoice == (filters)(-65))
		{
			ELOFMLPCCEA = "_TimeX";
		}
		if (filterchoice == (filters)(-114))
		{
			ELOFMLPCCEA = "HitInRelaxMusicToggle";
		}
		if (filterchoice == (filters)27)
		{
			ELOFMLPCCEA = "Can't set visible when not in that room.";
		}
		if (filterchoice == (filters)(-50))
		{
			ELOFMLPCCEA = "Save Game";
		}
		if (filterchoice == (filters)(-126))
		{
			ELOFMLPCCEA = "settings.selectormapsperpage";
		}
		if (filterchoice == (filters)37)
		{
			ELOFMLPCCEA = "SetParticlesGravity";
		}
	}

	private void OFIMMFHFHDD()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ADPLHDFJFID()
	{
		BEHNMDCNKBF = filterchoice;
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 69);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		FEHMFPBAGFG();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JEBIBKLHFLB()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DAIPOKLLFLD()
	{
		if (filterchoice != BEHNMDCNKBF)
		{
			CGCHMJCJOBB();
			SCShader = Shader.Find(ELOFMLPCCEA);
			Object.DestroyImmediate(BJFKDHHMLJH);
			if (BJFKDHHMLJH == null)
			{
				BJFKDHHMLJH = new Material(SCShader);
				BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
			}
		}
		BEHNMDCNKBF = filterchoice;
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 56);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void LFAFJKJAEEL()
	{
		BEHNMDCNKBF = filterchoice;
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -103);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		GBPGJKPMMDN();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AIJGAJIOJDJ()
	{
	}

	private void MOMGJJDIFFI()
	{
		if (filterchoice != BEHNMDCNKBF)
		{
			AFOHBGHNBDI();
			SCShader = Shader.Find(ELOFMLPCCEA);
			Object.DestroyImmediate(BJFKDHHMLJH);
			if (BJFKDHHMLJH == null)
			{
				BJFKDHHMLJH = new Material(SCShader);
				BJFKDHHMLJH.hideFlags = (HideFlags)(-102);
			}
		}
		BEHNMDCNKBF = filterchoice;
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -126);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void OGLCKDAHOCG()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BLKGOMCPEKI()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
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
			BJFKDHHMLJH.hideFlags = (HideFlags)94;
		}
		return BJFKDHHMLJH;
	}

	private void HMKJFPBFOFI()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 62);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void ELKELFCGMPE()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HLLHJIDOOGA()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
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
			if (HBJJOCHGOPH > 149f)
			{
				HBJJOCHGOPH = 105f;
			}
			if (Camera2 != null)
			{
				OKJOKHGJHGF().SetTexture("player.slash", JDMCFBKJHDD);
			}
			IFMAPIDFNLI().SetFloat("_Blue_G", HBJJOCHGOPH);
			OIIDAKBILMI().SetFloat("error", BlendFX);
			LDNADDJMIPK().SetFloat("MapEditor v.", SwitchCameraToCamera2);
			KEMJNOMIPHN().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1383f, 679f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material IKAEIOAHPKI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material ECCPAOBFDKP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void MLLPGPANCHI()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -68);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material IFMAPIDFNLI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.DontSave;
		}
		return BJFKDHHMLJH;
	}

	private void KMKKHLGJEMC()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 62);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void ICILLMAKLMI()
	{
		BEHNMDCNKBF = filterchoice;
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -54);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		GOCIGGGHANF();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DAHFFNNIGML()
	{
		BEHNMDCNKBF = filterchoice;
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 52);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		CKFICFFNDFJ();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material MHBAIEKFBIJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)94;
		}
		return BJFKDHHMLJH;
	}

	private void MCKCCPLJIFE()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AJENCHHLHKF()
	{
		if (filterchoice != BEHNMDCNKBF)
		{
			MENDFOCFMAN();
			SCShader = Shader.Find(ELOFMLPCCEA);
			Object.DestroyImmediate(BJFKDHHMLJH);
			if (BJFKDHHMLJH == null)
			{
				BJFKDHHMLJH = new Material(SCShader);
				BJFKDHHMLJH.hideFlags = (HideFlags)(-113);
			}
		}
		BEHNMDCNKBF = filterchoice;
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -101);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void OnEnable()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void MHNCEEDIKCC()
	{
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "_History3ChromaTex";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "_FarCamera";
		}
		if (filterchoice == filters.LinearBurn)
		{
			ELOFMLPCCEA = "_Extra";
		}
		if (filterchoice == filters.Multiply)
		{
			ELOFMLPCCEA = "_Value2";
		}
		if (filterchoice == filters.Screen)
		{
			ELOFMLPCCEA = "Joystick1Button10";
		}
		if (filterchoice == filters.ColorDodge)
		{
			ELOFMLPCCEA = "menu.selectedplaymode";
		}
		if (filterchoice == filters.ColorBurn)
		{
			ELOFMLPCCEA = "[Right-Left]";
		}
		if (filterchoice == filters.LinearBurn)
		{
			ELOFMLPCCEA = "https://discord.gg/intralism";
		}
		if (filterchoice == filters.DarkerColor)
		{
			ELOFMLPCCEA = "_VelocityScale";
		}
		if (filterchoice == (filters)107)
		{
			ELOFMLPCCEA = "_CenterX";
		}
		if (filterchoice == (filters)65)
		{
			ELOFMLPCCEA = "player.deleted";
		}
		if (filterchoice == (filters)(-34))
		{
			ELOFMLPCCEA = "_LensDirt";
		}
		if (filterchoice == (filters)(-120))
		{
			ELOFMLPCCEA = "--------------------------------";
		}
		if (filterchoice == (filters)100)
		{
			ELOFMLPCCEA = "CameraFilterPack/Color_GrayScale";
		}
		if (filterchoice == (filters)72)
		{
			ELOFMLPCCEA = "Fade";
		}
		if (filterchoice == (filters)107)
		{
			ELOFMLPCCEA = "ChatHistoryInputField";
		}
		if (filterchoice == (filters)115)
		{
			ELOFMLPCCEA = "_ScreenResolution";
		}
		if (filterchoice == filters.DarkerColor)
		{
			ELOFMLPCCEA = "NEW_ACHIEVEMENT_1_21";
		}
		if (filterchoice == (filters)(-33))
		{
			ELOFMLPCCEA = ":";
		}
		if (filterchoice == (filters)(-78))
		{
			ELOFMLPCCEA = ",";
		}
		if (filterchoice == filters.Luminosity)
		{
			ELOFMLPCCEA = "offsets";
		}
		if (filterchoice == (filters)(-3))
		{
			ELOFMLPCCEA = "LevelURLInputField";
		}
		if (filterchoice == (filters)(-53))
		{
			ELOFMLPCCEA = "_Blend";
		}
		if (filterchoice == (filters)62)
		{
			ELOFMLPCCEA = "_Value";
		}
		if (filterchoice == (filters)70)
		{
			ELOFMLPCCEA = "EXCEPTION:";
		}
	}

	private void HNMIAKKBMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1553f)
			{
				HBJJOCHGOPH = 720f;
			}
			if (Camera2 != null)
			{
				OIIDAKBILMI().SetTexture("offsets", JDMCFBKJHDD);
			}
			OCMBHMLNCEK().SetFloat("GroupNameText", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat(".sawoutdatedmessage", BlendFX);
			OIIDAKBILMI().SetFloat("GlassColor", SwitchCameraToCamera2);
			NBMPPNFKFLB().SetVector("_TempTexture", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1497f, 330f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Start()
	{
		BEHNMDCNKBF = filterchoice;
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		MIPGPMKJELI();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
