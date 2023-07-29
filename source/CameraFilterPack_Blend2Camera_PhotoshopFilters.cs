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
				NBPKMLMCHFN.SetTexture("_BokehParams", JDMCFBKJHDD);
			}
			PEIMCBBHLBJ().SetFloat("CameraFilterPack/TV_ARCADE_2", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("LetterSpacing: Missing Text component", BlendFX);
			LPDOGGFOBDH().SetFloat(".lastCheckpoint.powerupsScore", SwitchCameraToCamera2);
			KEMJNOMIPHN().SetVector("_SpherePositionY", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 666f, 1045f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPCHMEKDCHI());
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
				MHBAIEKFBIJ().SetTexture("_Value4", JDMCFBKJHDD);
			}
			IFMAPIDFNLI().SetFloat("}", HBJJOCHGOPH);
			IKAEIOAHPKI().SetFloat("[Right]", BlendFX);
			MFHPKGICPIO().SetFloat("settings_bindings_", SwitchCameraToCamera2);
			LDNADDJMIPK().SetVector("\n", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1355f, 873f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OCMBHMLNCEK());
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
				JIBOKBCPDLC().SetTexture("/", JDMCFBKJHDD);
			}
			NBMPPNFKFLB().SetFloat("AudioSampler", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("Mouse", BlendFX);
			EFDEIFCDAFG().SetFloat("settings.volume.menu", SwitchCameraToCamera2);
			LDNADDJMIPK().SetVector("_Offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 46f, 1560f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IKAEIOAHPKI());
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
			MPJAFNJLBEF();
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
			ELOFMLPCCEA = "intensity";
		}
		if (filterchoice == filters.DarkerColor)
		{
			ELOFMLPCCEA = "SpawnObj";
		}
		if (filterchoice == filters.Screen)
		{
			ELOFMLPCCEA = "_ZCurve";
		}
		if (filterchoice == filters.LinearBurn)
		{
			ELOFMLPCCEA = "_Value2";
		}
		if (filterchoice == filters.LinearBurn)
		{
			ELOFMLPCCEA = "CameraFilterPack/FX_Dot_Circle";
		}
		if (filterchoice == filters.ColorDodge)
		{
			ELOFMLPCCEA = "L1";
		}
		if (filterchoice == filters.LinearDodge)
		{
			ELOFMLPCCEA = "maps.";
		}
		if (filterchoice == filters.DarkerColor)
		{
			ELOFMLPCCEA = "CameraFilterPack/FX_Glitch1";
		}
		if (filterchoice == (filters)105)
		{
			ELOFMLPCCEA = "_FadeFX";
		}
		if (filterchoice == (filters)116)
		{
			ELOFMLPCCEA = "Waiting to start";
		}
		if (filterchoice == filters.VividLight)
		{
			ELOFMLPCCEA = "[Down]";
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
			ELOFMLPCCEA = ":";
		}
		if (filterchoice == (filters)77)
		{
			ELOFMLPCCEA = "_FarCamera";
		}
		if (filterchoice == (filters)(-70))
		{
			ELOFMLPCCEA = "If you host Photon yourself, make sure to start the 'Instance LoadBalancing' ";
		}
		if (filterchoice == filters.LinearBurn)
		{
			ELOFMLPCCEA = "\nv.";
		}
		if (filterchoice == filters.Subtract)
		{
			ELOFMLPCCEA = "ConnectToMaster() failed. Can only connect while in state 'Disconnected'. Current state: ";
		}
		if (filterchoice == filters.HardLight)
		{
			ELOFMLPCCEA = "Gameplay/sprite";
		}
		if (filterchoice == (filters)78)
		{
			ELOFMLPCCEA = "To Log";
		}
		if (filterchoice == (filters)(-86))
		{
			ELOFMLPCCEA = "AccuracyScoreText";
		}
		if (filterchoice == (filters)(-1))
		{
			ELOFMLPCCEA = "achievements.21.completed.workshop.";
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
		GBPGJKPMMDN();
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
			CKFICFFNDFJ();
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
			ELOFMLPCCEA = "[LevelEditorScene] Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(";
		}
		if (filterchoice == filters.Multiply)
		{
			ELOFMLPCCEA = "uploads/Intralism/mods_terms.pdf";
		}
		if (filterchoice == filters.Multiply)
		{
			ELOFMLPCCEA = "workshop.";
		}
		if (filterchoice == filters.DarkerColor)
		{
			ELOFMLPCCEA = "Connection failed: ";
		}
		if (filterchoice == filters.Lighten)
		{
			ELOFMLPCCEA = "cipherText";
		}
		if (filterchoice == filters.ColorBurn)
		{
			ELOFMLPCCEA = "CameraFilterPack/Colors_NewPosterize";
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
			ELOFMLPCCEA = "CameraFilterPack/Blur_Bloom";
		}
		if (filterchoice == (filters)106)
		{
			ELOFMLPCCEA = "_ScreenResolution";
		}
		if (filterchoice == (filters)120)
		{
			ELOFMLPCCEA = "#random #rare #item";
		}
		if (filterchoice == filters.Subtract)
		{
			ELOFMLPCCEA = "_Value2";
		}
		if (filterchoice == (filters)33)
		{
			ELOFMLPCCEA = "Beat Detected";
		}
		if (filterchoice == (filters)(-44))
		{
			ELOFMLPCCEA = "Search: ";
		}
		if (filterchoice == (filters)(-86))
		{
			ELOFMLPCCEA = "LastNewsButton";
		}
		if (filterchoice == (filters)90)
		{
			ELOFMLPCCEA = "_ScreenResolution";
		}
		if (filterchoice == (filters)36)
		{
			ELOFMLPCCEA = "Line";
		}
		if (filterchoice == (filters)44)
		{
			ELOFMLPCCEA = "RequestForPickupItems";
		}
		if (filterchoice == (filters)(-80))
		{
			ELOFMLPCCEA = "</color>";
		}
		if (filterchoice == (filters)118)
		{
			ELOFMLPCCEA = "Alpha";
		}
		if (filterchoice == (filters)59)
		{
			ELOFMLPCCEA = "grid";
		}
		if (filterchoice == (filters)(-97))
		{
			ELOFMLPCCEA = "_TimeX";
		}
		if (filterchoice == (filters)120)
		{
			ELOFMLPCCEA = "_AlphaHexa";
		}
		if (filterchoice == (filters)98)
		{
			ELOFMLPCCEA = " not exist";
		}
		if (filterchoice == (filters)44)
		{
			ELOFMLPCCEA = "0 - default, 1 - left, 2 - right";
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
		NBMEBBHCNMH();
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
				MFHPKGICPIO().SetTexture("#no", JDMCFBKJHDD);
			}
			ADBKPGFMNKO().SetFloat("_Screen", HBJJOCHGOPH);
			ADBKPGFMNKO().SetFloat(" not exist", BlendFX);
			JIBOKBCPDLC().SetFloat("YES", SwitchCameraToCamera2);
			MNLKBFFKHIE().SetVector("CameraFilterPack/Distortion_Half_Sphere", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 850f, 741f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
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
		FEHMFPBAGFG();
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
				DOMEEFLPEPJ().SetTexture("_ScreenResolution", JDMCFBKJHDD);
			}
			PEIMCBBHLBJ().SetFloat("http://steamcommunity.com/sharedfiles/filedetails/?id=", HBJJOCHGOPH);
			LDNADDJMIPK().SetFloat("accuracy", BlendFX);
			MFHPKGICPIO().SetFloat("menu.selectedlevelid", SwitchCameraToCamera2);
			KEMJNOMIPHN().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1457f, 898f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IKAEIOAHPKI());
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
			ELOFMLPCCEA = "ViewMenu";
		}
		if (filterchoice == filters.Multiply)
		{
			ELOFMLPCCEA = "Item created: Id: ";
		}
		if (filterchoice == filters.LinearBurn)
		{
			ELOFMLPCCEA = "_ScreenResolution";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "_EmissionColor";
		}
		if (filterchoice == filters.LinearBurn)
		{
			ELOFMLPCCEA = "_TimeX";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "Texture2";
		}
		if (filterchoice == filters.ColorDodge)
		{
			ELOFMLPCCEA = "\n\n#";
		}
		if (filterchoice == filters.Screen)
		{
			ELOFMLPCCEA = " not exist";
		}
		if (filterchoice == filters.DarkerColor)
		{
			ELOFMLPCCEA = "x";
		}
		if (filterchoice == (filters)(-98))
		{
			ELOFMLPCCEA = "players";
		}
		if (filterchoice == (filters)(-16))
		{
			ELOFMLPCCEA = " not exist";
		}
		if (filterchoice == (filters)(-58))
		{
			ELOFMLPCCEA = ".lastCheckpoint.powerupsScore";
		}
		if (filterchoice == (filters)(-27))
		{
			ELOFMLPCCEA = "_EmissionColor";
		}
		if (filterchoice == (filters)81)
		{
			ELOFMLPCCEA = ".lastCheckpoint.bgcolor";
		}
		if (filterchoice == (filters)80)
		{
			ELOFMLPCCEA = "_MainTex";
		}
		if (filterchoice == (filters)71)
		{
			ELOFMLPCCEA = "_ScreenResolution";
		}
		if (filterchoice == (filters)(-106))
		{
			ELOFMLPCCEA = "RPC can't be sent to target PhotonPlayer being null! Did not send \"";
		}
		if (filterchoice == (filters)(-115))
		{
			ELOFMLPCCEA = "_TimeX";
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
			ELOFMLPCCEA = "_Parameter";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "[LocalizationService] All keys for ";
		}
		if (filterchoice == (filters)(-38))
		{
			ELOFMLPCCEA = "--------------------------------";
		}
		if (filterchoice == (filters)34)
		{
			ELOFMLPCCEA = "settings_bindings_controller_type";
		}
		if (filterchoice == (filters)(-95))
		{
			ELOFMLPCCEA = ". Using max value: 255.";
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
			CGCHMJCJOBB();
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
				HILDKDFEBPF().SetTexture("_MainTex2", JDMCFBKJHDD);
			}
			LDNADDJMIPK().SetFloat("yyyy-MM-dd HH:mm:ss", HBJJOCHGOPH);
			OCMBHMLNCEK().SetFloat("https://vk.com/khb.soft", BlendFX);
			OCMBHMLNCEK().SetFloat("_ScreenResolution", SwitchCameraToCamera2);
			FKEOGPDLBDD().SetVector("skin.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1406f, 860f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
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
			ELOFMLPCCEA = "_Jitter";
		}
		if (filterchoice == filters.Multiply)
		{
			ELOFMLPCCEA = "_Fade";
		}
		if (filterchoice == filters.ColorBurn)
		{
			ELOFMLPCCEA = "Tab2Content";
		}
		if (filterchoice == filters.ColorDodge)
		{
			ELOFMLPCCEA = "ExitButton";
		}
		if (filterchoice == filters.Multiply)
		{
			ELOFMLPCCEA = "[MapsData] Found ";
		}
		if (filterchoice == filters.Lighten)
		{
			ELOFMLPCCEA = "#scoresubmitionfailed: ";
		}
		if (filterchoice == filters.LinearBurn)
		{
			ELOFMLPCCEA = "CameraFilterPack/Distortion_ShockWave";
		}
		if (filterchoice == filters.Screen)
		{
			ELOFMLPCCEA = "maps.";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "init";
		}
		if (filterchoice == (filters)(-123))
		{
			ELOFMLPCCEA = "settings.fps";
		}
		if (filterchoice == (filters)116)
		{
			ELOFMLPCCEA = "z";
		}
		if (filterchoice == (filters)(-50))
		{
			ELOFMLPCCEA = "EditMenu";
		}
		if (filterchoice == (filters)78)
		{
			ELOFMLPCCEA = "SupportLogger OnJoinedRoom(";
		}
		if (filterchoice == (filters)111)
		{
			ELOFMLPCCEA = "http://api.steampowered.com/ISteamNews/GetNewsForApp/v0002/?format=json&appid=513510";
		}
		if (filterchoice == (filters)(-97))
		{
			ELOFMLPCCEA = "<command>";
		}
		if (filterchoice == (filters)111)
		{
			ELOFMLPCCEA = "Gameplay/LobbyPlayerIconElement";
		}
		if (filterchoice == (filters)(-125))
		{
			ELOFMLPCCEA = "Connection error: ";
		}
		if (filterchoice == (filters)(-106))
		{
			ELOFMLPCCEA = "OnAwakeRPC";
		}
		if (filterchoice == (filters)(-18))
		{
			ELOFMLPCCEA = "settings.crosshairopacity";
		}
		if (filterchoice == (filters)(-56))
		{
			ELOFMLPCCEA = "MultiplayerButton";
		}
		if (filterchoice == (filters)121)
		{
			ELOFMLPCCEA = "_TimeX";
		}
		if (filterchoice == (filters)58)
		{
			ELOFMLPCCEA = "_UserLutParams";
		}
		if (filterchoice == (filters)26)
		{
			ELOFMLPCCEA = "SetSatelliteColor";
		}
		if (filterchoice == (filters)(-11))
		{
			ELOFMLPCCEA = " | Level: ";
		}
		if (filterchoice == (filters)(-63))
		{
			ELOFMLPCCEA = "SpawnObj";
		}
	}

	private void OIAACNGKGML()
	{
		if (filterchoice != BEHNMDCNKBF)
		{
			CGCHMJCJOBB();
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
			ELOFMLPCCEA = "_EmissionColor";
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
			ELOFMLPCCEA = "Currently, the limit of users is reached for this title. Try again later. Disconnecting";
		}
		if (filterchoice == filters.LinearBurn)
		{
			ELOFMLPCCEA = "[MapsStats] Length: ";
		}
		if (filterchoice == filters.Screen)
		{
			ELOFMLPCCEA = "[MenuScene] Error: ";
		}
		if (filterchoice == filters.Lighten)
		{
			ELOFMLPCCEA = "speed";
		}
		if (filterchoice == filters.LinearDodge)
		{
			ELOFMLPCCEA = "_MainTex2";
		}
		if (filterchoice == filters.LighterColor)
		{
			ELOFMLPCCEA = "error";
		}
		if (filterchoice == (filters)(-76))
		{
			ELOFMLPCCEA = "PLEASE WAIT";
		}
		if (filterchoice == (filters)98)
		{
			ELOFMLPCCEA = "EventData0DropDownList";
		}
		if (filterchoice == (filters)47)
		{
			ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_DarkerColor";
		}
		if (filterchoice == (filters)95)
		{
			ELOFMLPCCEA = "JoinRoom failed. A roomname is required. If you don't know one, how will you join?";
		}
		if (filterchoice == (filters)110)
		{
			ELOFMLPCCEA = "_ColorLevel";
		}
		if (filterchoice == (filters)(-56))
		{
			ELOFMLPCCEA = "SpawnObj";
		}
		if (filterchoice == (filters)(-104))
		{
			ELOFMLPCCEA = "GhostPosY";
		}
		if (filterchoice == (filters)(-71))
		{
			ELOFMLPCCEA = "_TimeX";
		}
		if (filterchoice == (filters)123)
		{
			ELOFMLPCCEA = "_EmissionColor";
		}
		if (filterchoice == (filters)85)
		{
			ELOFMLPCCEA = "InfoButton";
		}
		if (filterchoice == filters.PinLight)
		{
			ELOFMLPCCEA = "Maps Editor v.";
		}
		if (filterchoice == (filters)91)
		{
			ELOFMLPCCEA = "_DistAmount";
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
			ELOFMLPCCEA = "<b>Intralism Items Uploader</b> by Oxy949";
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
			GOCIGGGHANF();
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
				IFMAPIDFNLI().SetTexture(".b", JDMCFBKJHDD);
			}
			OCMBHMLNCEK().SetFloat("_EmissionGain", HBJJOCHGOPH);
			OCMBHMLNCEK().SetFloat("Playing ", BlendFX);
			MFHPKGICPIO().SetFloat("[MapEditor] Item creation successful! Published Item ID: ", SwitchCameraToCamera2);
			LDNADDJMIPK().SetVector("colorD", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1625f, 1078f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
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
			MELKBLIIFEO();
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
			ELOFMLPCCEA = "mapselector.filter.favoriteonly";
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
			ELOFMLPCCEA = "_VignetteSettings";
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
			ELOFMLPCCEA = "Item ";
		}
		if (filterchoice == filters.ColorBurn)
		{
			ELOFMLPCCEA = "There are a few rules that you must accept before submitting your work. Please select \"RULES\" button, if you haven't read them yet.";
		}
		if (filterchoice == (filters)(-128))
		{
			ELOFMLPCCEA = "GlassColor";
		}
		if (filterchoice == (filters)124)
		{
			ELOFMLPCCEA = "/files/editor_manual.pdf";
		}
		if (filterchoice == filters.Overlay)
		{
			ELOFMLPCCEA = "_BlurRadius4";
		}
		if (filterchoice == (filters)(-36))
		{
			ELOFMLPCCEA = "Screen Space Reflections";
		}
		if (filterchoice == (filters)66)
		{
			ELOFMLPCCEA = "GlassesColor2";
		}
		if (filterchoice == (filters)(-8))
		{
			ELOFMLPCCEA = "_NoiseTex";
		}
		if (filterchoice == (filters)95)
		{
			ELOFMLPCCEA = "OK";
		}
		if (filterchoice == (filters)49)
		{
			ELOFMLPCCEA = "OK";
		}
		if (filterchoice == (filters)68)
		{
			ELOFMLPCCEA = "_Bloom0";
		}
		if (filterchoice == (filters)(-75))
		{
			ELOFMLPCCEA = "-showlogs";
		}
		if (filterchoice == (filters)(-68))
		{
			ELOFMLPCCEA = "EventMenu";
		}
		if (filterchoice == (filters)(-16))
		{
			ELOFMLPCCEA = "shader.crispwinter";
		}
		if (filterchoice == (filters)(-122))
		{
			ELOFMLPCCEA = " argument(s): ";
		}
		if (filterchoice == (filters)(-7))
		{
			ELOFMLPCCEA = "_Value2";
		}
		if (filterchoice == (filters)123)
		{
			ELOFMLPCCEA = "GlassesColor2";
		}
		if (filterchoice == (filters)32)
		{
			ELOFMLPCCEA = "https://bugs.khb-soft.ru/set_project.php?project_id=1";
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
			ELOFMLPCCEA = "_CurveParams";
		}
		if (filterchoice == filters.Screen)
		{
			ELOFMLPCCEA = "_ScreenResolution";
		}
		if (filterchoice == filters.Multiply)
		{
			ELOFMLPCCEA = "Triangle";
		}
		if (filterchoice == filters.Lighten)
		{
			ELOFMLPCCEA = " not found";
		}
		if (filterchoice == filters.LinearDodge)
		{
			ELOFMLPCCEA = "UsernameText";
		}
		if (filterchoice == filters.LinearDodge)
		{
			ELOFMLPCCEA = "_History2ChromaTex";
		}
		if (filterchoice == filters.Lighten)
		{
			ELOFMLPCCEA = "DPADHOR";
		}
		if (filterchoice == filters.ColorDodge)
		{
			ELOFMLPCCEA = "SetRoomStartTimestamp";
		}
		if (filterchoice == (filters)(-57))
		{
			ELOFMLPCCEA = "Changed config";
		}
		if (filterchoice == (filters)(-63))
		{
			ELOFMLPCCEA = "Set arcs speed. Base value - 15";
		}
		if (filterchoice == (filters)(-34))
		{
			ELOFMLPCCEA = "Bad parameters for setstring! Use <key> <value>";
		}
		if (filterchoice == (filters)(-48))
		{
			ELOFMLPCCEA = "_Value";
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
			ELOFMLPCCEA = "PopulateMapsList";
		}
		if (filterchoice == (filters)80)
		{
			ELOFMLPCCEA = "_MainTex2";
		}
		if (filterchoice == (filters)(-31))
		{
			ELOFMLPCCEA = ".highscore";
		}
		if (filterchoice == (filters)59)
		{
			ELOFMLPCCEA = "_ScreenResolution";
		}
		if (filterchoice == (filters)45)
		{
			ELOFMLPCCEA = "&";
		}
		if (filterchoice == (filters)121)
		{
			ELOFMLPCCEA = "#rt";
		}
		if (filterchoice == filters.Saturation)
		{
			ELOFMLPCCEA = "InventoryButton";
		}
		if (filterchoice == (filters)(-25))
		{
			ELOFMLPCCEA = "AuthenticationValues UserId: {0}, GetParameters: {1} Token available: {2}";
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
			ELOFMLPCCEA = "FileLabel";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = " Path: ";
		}
		if (filterchoice == filters.ColorBurn)
		{
			ELOFMLPCCEA = "_Value";
		}
		if (filterchoice == filters.Screen)
		{
			ELOFMLPCCEA = "Image";
		}
		if (filterchoice == filters.DarkerColor)
		{
			ELOFMLPCCEA = "Reconnect() failed. It seems the client wasn't connected before?! Current state: ";
		}
		if (filterchoice == filters.ColorDodge)
		{
			ELOFMLPCCEA = "EnableRankingToggle";
		}
		if (filterchoice == filters.Multiply)
		{
			ELOFMLPCCEA = "RT";
		}
		if (filterchoice == filters.Lighten)
		{
			ELOFMLPCCEA = " respawn: ";
		}
		if (filterchoice == (filters)42)
		{
			ELOFMLPCCEA = "0.00:0.00";
		}
		if (filterchoice == (filters)(-74))
		{
			ELOFMLPCCEA = "steamid";
		}
		if (filterchoice == (filters)(-56))
		{
			ELOFMLPCCEA = "Player";
		}
		if (filterchoice == (filters)46)
		{
			ELOFMLPCCEA = "CameraFilterPack_3D_Myst1";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "rarity";
		}
		if (filterchoice == (filters)61)
		{
			ELOFMLPCCEA = "PLEASE WAIT";
		}
		if (filterchoice == (filters)69)
		{
			ELOFMLPCCEA = "CameraFilterPack/Pixelisation_OilPaintHQ";
		}
		if (filterchoice == (filters)(-49))
		{
			ELOFMLPCCEA = "_NoiseAmount";
		}
		if (filterchoice == (filters)(-117))
		{
			ELOFMLPCCEA = "PunRespawn";
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
			ELOFMLPCCEA = "RecordButton";
		}
		if (filterchoice == (filters)48)
		{
			ELOFMLPCCEA = "_ScreenResolution";
		}
		if (filterchoice == (filters)(-20))
		{
			ELOFMLPCCEA = "[MapsData] Installed: ";
		}
		if (filterchoice == (filters)88)
		{
			ELOFMLPCCEA = "inventory.itemscash";
		}
		if (filterchoice == (filters)35)
		{
			ELOFMLPCCEA = "No Name";
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
		MELKBLIIFEO();
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
			AFOHBGHNBDI();
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
			ELOFMLPCCEA = "The image effect ";
		}
		if (filterchoice == filters.DarkerColor)
		{
			ELOFMLPCCEA = "{0}";
		}
		if (filterchoice == filters.Lighten)
		{
			ELOFMLPCCEA = "' got destroyed by engine. This is OK when loading levels. Otherwise use: PhotonNetwork.Destroy().";
		}
		if (filterchoice == filters.Lighten)
		{
			ELOFMLPCCEA = "GroupNameText";
		}
		if (filterchoice == filters.LinearBurn)
		{
			ELOFMLPCCEA = "#close";
		}
		if (filterchoice == filters.Lighten)
		{
			ELOFMLPCCEA = "_TimeX";
		}
		if (filterchoice == filters.ColorDodge)
		{
			ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Saturation";
		}
		if (filterchoice == filters.ColorDodge)
		{
			ELOFMLPCCEA = "_ScreenResolution";
		}
		if (filterchoice == (filters)26)
		{
			ELOFMLPCCEA = "EndlessLoopsScoreText";
		}
		if (filterchoice == (filters)(-125))
		{
			ELOFMLPCCEA = "_Color";
		}
		if (filterchoice == (filters)(-78))
		{
			ELOFMLPCCEA = "/Segment-[Right]";
		}
		if (filterchoice == (filters)(-34))
		{
			ELOFMLPCCEA = "Deleted event";
		}
		if (filterchoice == (filters)66)
		{
			ELOFMLPCCEA = "_OffsetScale";
		}
		if (filterchoice == (filters)(-71))
		{
			ELOFMLPCCEA = "_ReflectionTexture3";
		}
		if (filterchoice == filters.Subtract)
		{
			ELOFMLPCCEA = "CameraFilterPack/Drawing_BluePrint";
		}
		if (filterchoice == (filters)25)
		{
			ELOFMLPCCEA = "#ok";
		}
		if (filterchoice == (filters)(-19))
		{
			ELOFMLPCCEA = "Changed config";
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
			ELOFMLPCCEA = "Mouse Wheel Down";
		}
		if (filterchoice == (filters)(-95))
		{
			ELOFMLPCCEA = "Case-Sensitive";
		}
		if (filterchoice == (filters)43)
		{
			ELOFMLPCCEA = "player.dragon";
		}
		if (filterchoice == (filters)(-39))
		{
			ELOFMLPCCEA = "menu.selectedplaymode";
		}
		if (filterchoice == filters.Luminosity)
		{
			ELOFMLPCCEA = "880078120";
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
		MENDFOCFMAN();
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
		NBMEBBHCNMH();
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
				NBPKMLMCHFN.SetTexture("MenuVolumeSlider", JDMCFBKJHDD);
			}
			NBMPPNFKFLB().SetFloat("SetBGColor", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("settings.volume.editor", BlendFX);
			KEMJNOMIPHN().SetFloat("[PlayerBase] Loaded custom model: ", SwitchCameraToCamera2);
			MHBAIEKFBIJ().SetVector("settings.enablehitsoundsinrelax", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 272f, 466f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPCHMEKDCHI());
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
			IGCBJKFAFEH();
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
			MPJAFNJLBEF();
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
			ELOFMLPCCEA = "[LevelEditorScene] Updated";
		}
		if (filterchoice == filters.Multiply)
		{
			ELOFMLPCCEA = "maps.";
		}
		if (filterchoice == filters.LinearDodge)
		{
			ELOFMLPCCEA = "_CenterX";
		}
		if (filterchoice == filters.Screen)
		{
			ELOFMLPCCEA = "<color=#{0}>{1}</color>";
		}
		if (filterchoice == filters.LinearBurn)
		{
			ELOFMLPCCEA = "settings.arcsnohitsoundtimedelay";
		}
		if (filterchoice == filters.ColorBurn)
		{
			ELOFMLPCCEA = "_Value2";
		}
		if (filterchoice == filters.Multiply)
		{
			ELOFMLPCCEA = "_Distortion";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "maphash";
		}
		if (filterchoice == filters.Multiply)
		{
			ELOFMLPCCEA = "note.1";
		}
		if (filterchoice == (filters)(-64))
		{
			ELOFMLPCCEA = "_SceneFogParams";
		}
		if (filterchoice == (filters)77)
		{
			ELOFMLPCCEA = "bad";
		}
		if (filterchoice == (filters)(-34))
		{
			ELOFMLPCCEA = "InfoText";
		}
		if (filterchoice == (filters)123)
		{
			ELOFMLPCCEA = "0";
		}
		if (filterchoice == (filters)(-122))
		{
			ELOFMLPCCEA = "value";
		}
		if (filterchoice == (filters)69)
		{
			ELOFMLPCCEA = "_Threshhold";
		}
		if (filterchoice == filters.Difference)
		{
			ELOFMLPCCEA = "#";
		}
		if (filterchoice == (filters)70)
		{
			ELOFMLPCCEA = "_ChromaticAberration";
		}
		if (filterchoice == (filters)79)
		{
			ELOFMLPCCEA = "_Value";
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
			ELOFMLPCCEA = "Lag ";
		}
		if (filterchoice == (filters)(-78))
		{
			ELOFMLPCCEA = "_BokehParams";
		}
		if (filterchoice == (filters)(-12))
		{
			ELOFMLPCCEA = "_ScreenResolution";
		}
		if (filterchoice == (filters)(-5))
		{
			ELOFMLPCCEA = "ShowSprite";
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
		CGCHMJCJOBB();
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
			MIPGPMKJELI();
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
		NBMEBBHCNMH();
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
			LGHFFANDDCM();
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
				KEMJNOMIPHN().SetTexture("offsets", JDMCFBKJHDD);
			}
			LPDOGGFOBDH().SetFloat("_Offsets", HBJJOCHGOPH);
			OKJOKHGJHGF().SetFloat("masterSteamID", BlendFX);
			DOMEEFLPEPJ().SetFloat("_ScreenResolution", SwitchCameraToCamera2);
			HILDKDFEBPF().SetVector("Set Crosshair Color", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 776f, 1646f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
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
		MPJAFNJLBEF();
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
				LPCHMEKDCHI().SetTexture("</color>", JDMCFBKJHDD);
			}
			LDNADDJMIPK().SetFloat("CameraFilterPack/Film_ColorPerfection", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("_TimeX", BlendFX);
			EFDEIFCDAFG().SetFloat("1.87", SwitchCameraToCamera2);
			OIIDAKBILMI().SetVector("]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 901f, 1635f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPCHMEKDCHI());
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
				FKEOGPDLBDD().SetTexture("<color=#{0}>{1}</color>", JDMCFBKJHDD);
			}
			LDNADDJMIPK().SetFloat("Couldn't call DestroyAll() as only the master client is allowed to call this.", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat(".highscore", BlendFX);
			EFDEIFCDAFG().SetFloat("Cross", SwitchCameraToCamera2);
			FKEOGPDLBDD().SetVector("_History4ChromaTex", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1128f, 1845f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MPENCEIGLEH());
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
			MBKICIMOCGC();
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
			MPJAFNJLBEF();
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
				KEMJNOMIPHN().SetTexture("CameraFilterPack/Blend2Camera_LinearLight", JDMCFBKJHDD);
			}
			IKAEIOAHPKI().SetFloat("CameraFilterPack/Vision_Hell_Blood", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("UI", BlendFX);
			IKAEIOAHPKI().SetFloat("y", SwitchCameraToCamera2);
			LPDOGGFOBDH().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 60f, 1011f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
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
				PEIMCBBHLBJ().SetTexture("CameraFilterPack/Real_VHS", JDMCFBKJHDD);
			}
			LDNADDJMIPK().SetFloat("&page=", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Edge_Sobel", BlendFX);
			PEIMCBBHLBJ().SetFloat("SetScale", SwitchCameraToCamera2);
			ADBKPGFMNKO().SetVector("Object ID. Case-Sensitive", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 405f, 651f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
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
		MELKBLIIFEO();
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
				IKAEIOAHPKI().SetTexture("skin.hit_perfect", JDMCFBKJHDD);
			}
			NBMPPNFKFLB().SetFloat(" ", HBJJOCHGOPH);
			OCMBHMLNCEK().SetFloat("_TimeX", BlendFX);
			LDNADDJMIPK().SetFloat("Error: I/O Failure! :(", SwitchCameraToCamera2);
			LPDOGGFOBDH().SetVector("_Value7", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 268f, 1638f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIIDAKBILMI());
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
			ELOFMLPCCEA = " Also make sure to disable sprite packing for this sprite.";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "\r";
		}
		if (filterchoice == filters.ColorDodge)
		{
			ELOFMLPCCEA = "Attempting to remove texture that was not allocated: {0}";
		}
		if (filterchoice == filters.ColorBurn)
		{
			ELOFMLPCCEA = "#ok";
		}
		if (filterchoice == filters.ColorDodge)
		{
			ELOFMLPCCEA = "[DiscordController] Responding no to Ask to Join request";
		}
		if (filterchoice == filters.ColorDodge)
		{
			ELOFMLPCCEA = "CameraFilterPack/3D_Binary";
		}
		if (filterchoice == filters.ColorDodge)
		{
			ELOFMLPCCEA = "Tab2Content";
		}
		if (filterchoice == filters.Screen)
		{
			ELOFMLPCCEA = "[LocalizationService] Error: ";
		}
		if (filterchoice == filters.ColorDodge)
		{
			ELOFMLPCCEA = "Have you fully accept the terms?";
		}
		if (filterchoice == (filters)(-114))
		{
			ELOFMLPCCEA = "[CraftingPanel] Init";
		}
		if (filterchoice == (filters)(-101))
		{
			ELOFMLPCCEA = "Switch environment sprite image";
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
			ELOFMLPCCEA = "_TimeX";
		}
		if (filterchoice == filters.PinLight)
		{
			ELOFMLPCCEA = "Fade";
		}
		if (filterchoice == (filters)(-30))
		{
			ELOFMLPCCEA = "_ScreenResolution";
		}
		if (filterchoice == (filters)36)
		{
			ELOFMLPCCEA = "note.2";
		}
		if (filterchoice == (filters)48)
		{
			ELOFMLPCCEA = "Music End";
		}
		if (filterchoice == (filters)90)
		{
			ELOFMLPCCEA = "CameraFilterPack/TV_Chromatical2";
		}
		if (filterchoice == (filters)123)
		{
			ELOFMLPCCEA = "Use ticket: ";
		}
		if (filterchoice == (filters)(-101))
		{
			ELOFMLPCCEA = "_Bloom2";
		}
		if (filterchoice == (filters)(-28))
		{
			ELOFMLPCCEA = "_EmissionColor";
		}
		if (filterchoice == (filters)76)
		{
			ELOFMLPCCEA = "High";
		}
		if (filterchoice == (filters)(-121))
		{
			ELOFMLPCCEA = "_Value";
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
				NBPKMLMCHFN.SetTexture("traffic", JDMCFBKJHDD);
			}
			MPENCEIGLEH().SetFloat("uploads/Intralism/mods_terms.pdf", HBJJOCHGOPH);
			ADBKPGFMNKO().SetFloat("Fade", BlendFX);
			HILDKDFEBPF().SetFloat("challenges.", SwitchCameraToCamera2);
			EFDEIFCDAFG().SetVector("SetSunMaxSize", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1682f, 1371f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MPENCEIGLEH());
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
			ELOFMLPCCEA = "FinalScoreSmallText";
		}
		if (filterchoice == filters.LinearDodge)
		{
			ELOFMLPCCEA = "_Value2";
		}
		if (filterchoice == filters.LinearDodge)
		{
			ELOFMLPCCEA = "FindFriends failed to apply the result, as a required value wasn't provided or the friend list length differed from result.";
		}
		if (filterchoice == filters.LinearDodge)
		{
			ELOFMLPCCEA = "_Value4";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "OpGetGameList not sent. LobbyType must be SqlLobby.";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "_ScreenResolution";
		}
		if (filterchoice == filters.LinearBurn)
		{
			ELOFMLPCCEA = "CameraFilterPack_VHS2";
		}
		if (filterchoice == (filters)(-61))
		{
			ELOFMLPCCEA = "/";
		}
		if (filterchoice == (filters)(-73))
		{
			ELOFMLPCCEA = "_ScreenResolution";
		}
		if (filterchoice == (filters)(-89))
		{
			ELOFMLPCCEA = "Observed type is not serializable: ";
		}
		if (filterchoice == (filters)82)
		{
			ELOFMLPCCEA = "Received RPC: ";
		}
		if (filterchoice == (filters)52)
		{
			ELOFMLPCCEA = "CreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.";
		}
		if (filterchoice == (filters)(-60))
		{
			ELOFMLPCCEA = "YES";
		}
		if (filterchoice == (filters)(-86))
		{
			ELOFMLPCCEA = "_Offsets";
		}
		if (filterchoice == (filters)(-107))
		{
			ELOFMLPCCEA = "_Value";
		}
		if (filterchoice == filters.LinearDodge)
		{
			ELOFMLPCCEA = "_Near";
		}
		if (filterchoice == (filters)26)
		{
			ELOFMLPCCEA = ". No ViewIDs are free to use. Max is: ";
		}
		if (filterchoice == (filters)(-56))
		{
			ELOFMLPCCEA = "#tryagain";
		}
		if (filterchoice == (filters)(-26))
		{
			ELOFMLPCCEA = " ";
		}
		if (filterchoice == (filters)127)
		{
			ELOFMLPCCEA = "_FarCamera";
		}
		if (filterchoice == (filters)82)
		{
			ELOFMLPCCEA = "downloading";
		}
		if (filterchoice == (filters)(-10))
		{
			ELOFMLPCCEA = "_Value4";
		}
		if (filterchoice == (filters)90)
		{
			ELOFMLPCCEA = "ws://";
		}
	}

	private void FEHMFPBAGFG()
	{
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "player.circle";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "_ScreenResolution";
		}
		if (filterchoice == filters.ColorBurn)
		{
			ELOFMLPCCEA = "OnJoinedLobby(). This client is connected and does get a room-list, which gets stored as PhotonNetwork.GetRoomList(). This script now calls: PhotonNetwork.JoinRandomRoom();";
		}
		if (filterchoice == filters.Multiply)
		{
			ELOFMLPCCEA = "EventTimeInputField";
		}
		if (filterchoice == filters.LinearBurn)
		{
			ELOFMLPCCEA = "_Value2";
		}
		if (filterchoice == filters.ColorDodge)
		{
			ELOFMLPCCEA = "_Distortion";
		}
		if (filterchoice == filters.Lighten)
		{
			ELOFMLPCCEA = "Texture2";
		}
		if (filterchoice == filters.Multiply)
		{
			ELOFMLPCCEA = "MaxLivesSlider";
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
			ELOFMLPCCEA = ".lastCheckpoint.incorrectScore";
		}
		if (filterchoice == (filters)80)
		{
			ELOFMLPCCEA = "_PositionX";
		}
		if (filterchoice == (filters)65)
		{
			ELOFMLPCCEA = "int";
		}
		if (filterchoice == (filters)52)
		{
			ELOFMLPCCEA = "_Value2";
		}
		if (filterchoice == (filters)37)
		{
			ELOFMLPCCEA = "_Value2";
		}
		if (filterchoice == filters.Subtract)
		{
			ELOFMLPCCEA = "/";
		}
		if (filterchoice == (filters)(-75))
		{
			ELOFMLPCCEA = "Fill Area";
		}
		if (filterchoice == (filters)(-15))
		{
			ELOFMLPCCEA = "checkpoint";
		}
		if (filterchoice == (filters)116)
		{
			ELOFMLPCCEA = "The used master server address is not available with the subscription currently used. Got to Photon Cloud Dashboard or change URL. Disconnecting.";
		}
		if (filterchoice == (filters)(-6))
		{
			ELOFMLPCCEA = "player.ice";
		}
		if (filterchoice == filters.Hue)
		{
			ELOFMLPCCEA = "id";
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
			ELOFMLPCCEA = "selector";
		}
	}

	private void GOCIGGGHANF()
	{
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "_Dist";
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
			ELOFMLPCCEA = "Joystick1Button7";
		}
		if (filterchoice == filters.ColorBurn)
		{
			ELOFMLPCCEA = "PossibleMapMaxScoreText";
		}
		if (filterchoice == filters.DarkerColor)
		{
			ELOFMLPCCEA = "Item ";
		}
		if (filterchoice == filters.Multiply)
		{
			ELOFMLPCCEA = "SupportLogger OnFailedToConnectToPhoton(";
		}
		if (filterchoice == filters.ColorDodge)
		{
			ELOFMLPCCEA = "[LevelEditorScene] Error: Timeout :S";
		}
		if (filterchoice == filters.LinearDodge)
		{
			ELOFMLPCCEA = "#rategameinfo";
		}
		if (filterchoice == (filters)(-54))
		{
			ELOFMLPCCEA = "_Value2";
		}
		if (filterchoice == (filters)83)
		{
			ELOFMLPCCEA = "1177138211";
		}
		if (filterchoice == (filters)(-92))
		{
			ELOFMLPCCEA = ",";
		}
		if (filterchoice == (filters)102)
		{
			ELOFMLPCCEA = "LivesSlider";
		}
		if (filterchoice == (filters)(-8))
		{
			ELOFMLPCCEA = " while connecting to: ";
		}
		if (filterchoice == (filters)125)
		{
			ELOFMLPCCEA = "_Vignette";
		}
		if (filterchoice == (filters)74)
		{
			ELOFMLPCCEA = "#forever";
		}
		if (filterchoice == (filters)(-45))
		{
			ELOFMLPCCEA = "22x3";
		}
		if (filterchoice == (filters)(-93))
		{
			ELOFMLPCCEA = "_MainTex2";
		}
		if (filterchoice == (filters)58)
		{
			ELOFMLPCCEA = "Set Particle Size";
		}
		if (filterchoice == (filters)(-88))
		{
			ELOFMLPCCEA = "note.5";
		}
		if (filterchoice == (filters)(-78))
		{
			ELOFMLPCCEA = " This is not possible to be called for standalone input. Please check your platform and code where this is called";
		}
		if (filterchoice == (filters)(-103))
		{
			ELOFMLPCCEA = "icon_border";
		}
		if (filterchoice == (filters)121)
		{
			ELOFMLPCCEA = "SetSatelliteTrailMinVertexDistance";
		}
		if (filterchoice == (filters)98)
		{
			ELOFMLPCCEA = "PhotonView ID duplicate found: {0}. New: {1} old: {2}. Maybe one wasn't destroyed on scene load?! Check for 'DontDestroyOnLoad'. Destroying old entry, adding new.";
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
			MHNCEEDIKCC();
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
		IGCBJKFAFEH();
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
			MPJAFNJLBEF();
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
			IGCBJKFAFEH();
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
			FEHMFPBAGFG();
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
		GOCIGGGHANF();
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
			ELOFMLPCCEA = "#";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "[Up]";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "Authentication failed: '{0}' Code: {1}";
		}
		if (filterchoice == filters.ColorDodge)
		{
			ELOFMLPCCEA = "SpawnObj";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "_TimeX";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "ShadersToggle";
		}
		if (filterchoice == filters.LinearBurn)
		{
			ELOFMLPCCEA = "Object ID. Case-Sensitive";
		}
		if (filterchoice == filters.ColorDodge)
		{
			ELOFMLPCCEA = "_BloomIntensity";
		}
		if (filterchoice == (filters)36)
		{
			ELOFMLPCCEA = "_Value";
		}
		if (filterchoice == (filters)(-17))
		{
			ELOFMLPCCEA = "maps.";
		}
		if (filterchoice == (filters)(-28))
		{
			ELOFMLPCCEA = "OPEN FILE";
		}
		if (filterchoice == (filters)58)
		{
			ELOFMLPCCEA = "_Green_R";
		}
		if (filterchoice == (filters)(-102))
		{
			ELOFMLPCCEA = "[Left]";
		}
		if (filterchoice == (filters)(-83))
		{
			ELOFMLPCCEA = "visible";
		}
		if (filterchoice == (filters)83)
		{
			ELOFMLPCCEA = "_TimeX";
		}
		if (filterchoice == (filters)(-48))
		{
			ELOFMLPCCEA = "127.0.0.1";
		}
		if (filterchoice == (filters)(-39))
		{
			ELOFMLPCCEA = "_Blue_R";
		}
		if (filterchoice == (filters)(-74))
		{
			ELOFMLPCCEA = "Square";
		}
		if (filterchoice == (filters)(-96))
		{
			ELOFMLPCCEA = "_TimeX";
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
			ELOFMLPCCEA = "USE_PREDICATION";
		}
		if (filterchoice == (filters)(-57))
		{
			ELOFMLPCCEA = "steamid";
		}
		if (filterchoice == (filters)(-81))
		{
			ELOFMLPCCEA = "settings.enablehitsoundsinnormal";
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
			FEHMFPBAGFG();
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
			ELOFMLPCCEA = "_ScreenResolution";
		}
		if (filterchoice == filters.Multiply)
		{
			ELOFMLPCCEA = "_DepthLevel";
		}
		if (filterchoice == filters.Multiply)
		{
			ELOFMLPCCEA = "_TimeX";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "_History1Weight";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "Set Particles Gravity";
		}
		if (filterchoice == filters.Lighten)
		{
			ELOFMLPCCEA = "CameraFilterPack/FX_DigitalMatrix";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = " AuthMode ";
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
			ELOFMLPCCEA = "] to be droppable";
		}
		if (filterchoice == (filters)(-95))
		{
			ELOFMLPCCEA = "settings_bindings_";
		}
		if (filterchoice == (filters)(-125))
		{
			ELOFMLPCCEA = "ReconnectAndRejoin() failed. It seems the client wasn't connected to a game server before (no address).";
		}
		if (filterchoice == (filters)84)
		{
			ELOFMLPCCEA = "Emergency Help:";
		}
		if (filterchoice == (filters)114)
		{
			ELOFMLPCCEA = "_SceneFogMode";
		}
		if (filterchoice == (filters)(-92))
		{
			ELOFMLPCCEA = "_ScreenResolution";
		}
		if (filterchoice == (filters)51)
		{
			ELOFMLPCCEA = "sfxVolume";
		}
		if (filterchoice == (filters)(-27))
		{
			ELOFMLPCCEA = "[PowerUp]";
		}
		if (filterchoice == (filters)(-63))
		{
			ELOFMLPCCEA = "event";
		}
		if (filterchoice == (filters)39)
		{
			ELOFMLPCCEA = "offsets";
		}
		if (filterchoice == (filters)(-65))
		{
			ELOFMLPCCEA = "_Value";
		}
		if (filterchoice == (filters)(-114))
		{
			ELOFMLPCCEA = "HitInRelaxMusicToggle";
		}
		if (filterchoice == (filters)27)
		{
			ELOFMLPCCEA = "Can't set Room.MaxPlayers to: ";
		}
		if (filterchoice == (filters)(-50))
		{
			ELOFMLPCCEA = "QuickSave";
		}
		if (filterchoice == (filters)(-126))
		{
			ELOFMLPCCEA = "settings.hitvariation";
		}
		if (filterchoice == (filters)37)
		{
			ELOFMLPCCEA = "AddEnvironmentSprite";
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
		LGHFFANDDCM();
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
			JOLDJFOBCLO();
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
		NBMEBBHCNMH();
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
			LBEHKFNPKMC();
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
				OCMBHMLNCEK().SetTexture("player.slash", JDMCFBKJHDD);
			}
			MNLKBFFKHIE().SetFloat("_Blue_B", HBJJOCHGOPH);
			KEMJNOMIPHN().SetFloat("ConnectionTimeout", BlendFX);
			NBPKMLMCHFN.SetFloat("ResourcesConfig", SwitchCameraToCamera2);
			LDNADDJMIPK().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1383f, 679f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
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
		GBPGJKPMMDN();
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
		MPJAFNJLBEF();
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
			MELKBLIIFEO();
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
			ELOFMLPCCEA = "_History1Weight";
		}
		if (filterchoice == filters.Darken)
		{
			ELOFMLPCCEA = "_FarCamera";
		}
		if (filterchoice == filters.LinearBurn)
		{
			ELOFMLPCCEA = "_Extra2";
		}
		if (filterchoice == filters.Multiply)
		{
			ELOFMLPCCEA = "_ScreenResolution";
		}
		if (filterchoice == filters.Screen)
		{
			ELOFMLPCCEA = "Joystick1Button11";
		}
		if (filterchoice == filters.ColorDodge)
		{
			ELOFMLPCCEA = "menu.relaxinfo";
		}
		if (filterchoice == filters.ColorBurn)
		{
			ELOFMLPCCEA = "[Right-Left]";
		}
		if (filterchoice == filters.LinearBurn)
		{
			ELOFMLPCCEA = "https://twitch.tv/intralism";
		}
		if (filterchoice == filters.DarkerColor)
		{
			ELOFMLPCCEA = "_NoiseTex";
		}
		if (filterchoice == (filters)107)
		{
			ELOFMLPCCEA = "_CenterY";
		}
		if (filterchoice == (filters)65)
		{
			ELOFMLPCCEA = "player.deleted";
		}
		if (filterchoice == (filters)(-34))
		{
			ELOFMLPCCEA = "OPEN FILE";
		}
		if (filterchoice == (filters)(-120))
		{
			ELOFMLPCCEA = "<b>Difficulty</b>:";
		}
		if (filterchoice == (filters)100)
		{
			ELOFMLPCCEA = "CameraFilterPack/Color_GrayScale";
		}
		if (filterchoice == (filters)72)
		{
			ELOFMLPCCEA = "ZoomFade";
		}
		if (filterchoice == (filters)107)
		{
			ELOFMLPCCEA = "ChatHistoryInputField";
		}
		if (filterchoice == (filters)115)
		{
			ELOFMLPCCEA = "CameraFilterPack/Pixelisation_Dot";
		}
		if (filterchoice == filters.DarkerColor)
		{
			ELOFMLPCCEA = "achievements.21.progress";
		}
		if (filterchoice == (filters)(-33))
		{
			ELOFMLPCCEA = "Using constructor for new PingNativeDynamic()";
		}
		if (filterchoice == (filters)(-78))
		{
			ELOFMLPCCEA = "CountEventsGoal";
		}
		if (filterchoice == filters.Luminosity)
		{
			ELOFMLPCCEA = "offsets";
		}
		if (filterchoice == (filters)(-3))
		{
			ELOFMLPCCEA = "Tab2Content";
		}
		if (filterchoice == (filters)(-53))
		{
			ELOFMLPCCEA = "_Blend";
		}
		if (filterchoice == (filters)62)
		{
			ELOFMLPCCEA = "_Value2";
		}
		if (filterchoice == (filters)70)
		{
			ELOFMLPCCEA = "ERROR: Make sure your mod contains at leats one file!";
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
				ADBKPGFMNKO().SetTexture("stretchWidth", JDMCFBKJHDD);
			}
			MFHPKGICPIO().SetFloat("GroupNameText", HBJJOCHGOPH);
			HILDKDFEBPF().SetFloat(".lastCheckpoint.bgcolor", BlendFX);
			LPDOGGFOBDH().SetFloat("UseScanLineSize", SwitchCameraToCamera2);
			OIIDAKBILMI().SetVector("_AdditiveReflection", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1497f, 330f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOMEEFLPEPJ());
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
