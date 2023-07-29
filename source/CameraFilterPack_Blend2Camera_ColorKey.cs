// CameraFilterPack_Blend2Camera_ColorKey
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Chroma Key/Color Key")]
public class CameraFilterPack_Blend2Camera_ColorKey : MonoBehaviour
{
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_ColorKey";

	public Shader SCShader;

	public Camera Camera2;

	private float HBJJOCHGOPH = 1f;

	private Material BJFKDHHMLJH;

	[Range(0f, 1f)]
	public float BlendFX = 1f;

	public Color ColorKey;

	[Range(-0.2f, 0.2f)]
	public float Adjust;

	[Range(-0.2f, 0.2f)]
	public float Precision;

	[Range(-0.2f, 0.2f)]
	public float Luminosity;

	[Range(-0.3f, 0.3f)]
	public float Change_Red;

	[Range(-0.3f, 0.3f)]
	public float Change_Green;

	[Range(-0.3f, 0.3f)]
	public float Change_Blue;

	private RenderTexture JDMCFBKJHDD;

	private Vector2 FPEMMGKMJGA;

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

	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 566f)
			{
				HBJJOCHGOPH = 752f;
			}
			if (Camera2 != null)
			{
				EOCCJGIGEGJ().SetTexture("Set Object Position", JDMCFBKJHDD);
			}
			GCDFNHMJMIP().SetFloat("#", HBJJOCHGOPH);
			LPCHMEKDCHI().SetFloat("menu.selectedplaymode", BlendFX);
			HCGJCMDJPGD().SetFloat("menu.selectedlevelid", Adjust);
			MHBAIEKFBIJ().SetFloat("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", Precision);
			GKILCDHJFEG().SetFloat(": ", Luminosity);
			GCDFNHMJMIP().SetFloat("_PrevViewProj", Change_Red);
			HHIFMIPPMPF().SetFloat("Set Sun DirectionVector", Change_Green);
			HHIFMIPPMPF().SetFloat("maps.", Change_Blue);
			CIAFLBFJLEJ().SetColor("0,1,false", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material KEMAALEODNH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material DONENAMLFLF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-105);
		}
		return BJFKDHHMLJH;
	}

	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 879f)
			{
				HBJJOCHGOPH = 18f;
			}
			if (Camera2 != null)
			{
				IIBLJCKLGFG().SetTexture("mapselector.filter.officialsortmode", JDMCFBKJHDD);
			}
			HCGJCMDJPGD().SetFloat("CameraFilterPack/Blur_Dithering2x2", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("Anomaly_Distortion", BlendFX);
			NBPKMLMCHFN.SetFloat("{0}{1}{2}={3}", Adjust);
			EOCCJGIGEGJ().SetFloat("Set Satellite Lerp Speed", Precision);
			ABHDNGIHBKE().SetFloat("Screen Space Reflections", Luminosity);
			HHIAIGCAHDA().SetFloat("Set Sun Lerp Speed", Change_Red);
			DONENAMLFLF().SetFloat("_Red_B", Change_Green);
			FHFLKLMFHOI().SetFloat("/", Change_Blue);
			GKILCDHJFEG().SetColor("_LightIntensity", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LNLKMDPHDCC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)113;
		}
		return BJFKDHHMLJH;
	}

	private void KKGMKGHFELO()
	{
		NNCCPEBIAKH();
		EHJJFJCKGAJ();
	}

	private void FKEJGBFDCAH()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IMCKJCHKMKB()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -91);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CBIBDOIBJAI()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NNFMIAFHMJM()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -78);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EAHCLIEEJOG()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LFBGJIIECLD()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 5);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ABFNJCEBIKA()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void FLKEJJEGCFA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -109);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 693f)
			{
				HBJJOCHGOPH = 8f;
			}
			if (Camera2 != null)
			{
				GKILCDHJFEG().SetTexture(";", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat("DisableStoryboardToggle", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("BitsData", BlendFX);
			GKILCDHJFEG().SetFloat(".", Adjust);
			ABHDNGIHBKE().SetFloat("\n", Precision);
			HHIFMIPPMPF().SetFloat("SUBMIT", Luminosity);
			CBCNOEIALHB().SetFloat("The server address is 127.0.0.1 (localhost): Make sure the server is running on this machine. Android and iOS emulators have their own localhost.", Change_Red);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/FX_8bits_gb", Change_Green);
			MLMKCOINOOH().SetFloat("CameraFilterPack/3D_BlackHole", Change_Blue);
			CIAFLBFJLEJ().SetColor("GlassesColor2", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MHBAIEKFBIJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AEDDNDHCLNN()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -102);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OHFOLGANOLC()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -34);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void JHJFBCFBKLD()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 440f)
			{
				HBJJOCHGOPH = 13f;
			}
			if (Camera2 != null)
			{
				MHBAIEKFBIJ().SetTexture("_FixDistance", JDMCFBKJHDD);
			}
			FHFLKLMFHOI().SetFloat("#8E8E8EFF", HBJJOCHGOPH);
			CBCNOEIALHB().SetFloat("Tab1Content", BlendFX);
			CIAFLBFJLEJ().SetFloat("?", Adjust);
			GKILCDHJFEG().SetFloat("_ScreenResolution", Precision);
			IIBLJCKLGFG().SetFloat("color", Luminosity);
			HHIFMIPPMPF().SetFloat(":\n", Change_Red);
			CIAFLBFJLEJ().SetFloat("_MainTex", Change_Green);
			HHIAIGCAHDA().SetFloat("_SmoothEnd", Change_Blue);
			GCDFNHMJMIP().SetColor(" could not be executed (yet). Wait for state JoinedLobby or ConnectedToMaster and their callbacks before calling operations. WebRPCs need a server-side configuration. Enum OperationCode helps identify the operation.", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 662f)
			{
				HBJJOCHGOPH = 1176f;
			}
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture("_ScreenResolution", JDMCFBKJHDD);
			}
			FHFLKLMFHOI().SetFloat("#ok", HBJJOCHGOPH);
			DONENAMLFLF().SetFloat("_Value", BlendFX);
			GCDFNHMJMIP().SetFloat(".lastCheckpoint.powerupsScore", Adjust);
			IIBLJCKLGFG().SetFloat("0.00", Precision);
			MLMKCOINOOH().SetFloat("connect", Luminosity);
			MHBAIEKFBIJ().SetFloat("end", Change_Red);
			MLMKCOINOOH().SetFloat("settings.crosshairopacity", Change_Green);
			MLMKCOINOOH().SetFloat("Left ", Change_Blue);
			ABHDNGIHBKE().SetColor("Image effects aren't supported on this device ({0})", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CIAFLBFJLEJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FMFNILJIEIA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -45);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1227f)
			{
				HBJJOCHGOPH = 1440f;
			}
			if (Camera2 != null)
			{
				HKGAONMOBMH().SetTexture("X", JDMCFBKJHDD);
			}
			CIAFLBFJLEJ().SetFloat("Editor/", HBJJOCHGOPH);
			MLMKCOINOOH().SetFloat("Hidden/Fast Approximate Anti-aliasing", BlendFX);
			LPDOGGFOBDH().SetFloat("_Value4", Adjust);
			HCGJCMDJPGD().SetFloat("Joystick1Button12", Precision);
			LNLKMDPHDCC().SetFloat("/", Luminosity);
			HCGJCMDJPGD().SetFloat("_Level", Change_Red);
			HKGAONMOBMH().SetFloat("_TimeX", Change_Green);
			HHIAIGCAHDA().SetFloat("<color=white>", Change_Blue);
			MLMKCOINOOH().SetColor("plogs", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BDBJEDIOKBN()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material CIAFLBFJLEJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void JOLKPPEBILA()
	{
		MMPHNFPPEHO();
		ABFNJCEBIKA();
	}

	private void HIFPDKKBDHJ()
	{
		HAIAHJPCPAG();
		KCDBBPKIFNJ();
	}

	private void PBEPCAPAKLG()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void IGPCNCJIEOJ()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -116);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DGCGGKMNPLD()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void EKPLGFAEOBE()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
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
			if (HBJJOCHGOPH > 1252f)
			{
				HBJJOCHGOPH = 272f;
			}
			if (Camera2 != null)
			{
				DONENAMLFLF().SetTexture("StartButton", JDMCFBKJHDD);
			}
			GCDFNHMJMIP().SetFloat("CameraFilterPack/Broken_Screen", HBJJOCHGOPH);
			LPCHMEKDCHI().SetFloat("_Red_B", BlendFX);
			DONENAMLFLF().SetFloat("inventory.selected.", Adjust);
			HCGJCMDJPGD().SetFloat("_Value4", Precision);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", Luminosity);
			HHIAIGCAHDA().SetFloat("mapselector.orderby", Change_Red);
			HCGJCMDJPGD().SetFloat("open", Change_Green);
			LPDOGGFOBDH().SetFloat("-1", Change_Blue);
			GCDFNHMJMIP().SetColor("EditMenu", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LOMDIOLNFHI()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ONKDMMJPEMN()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void CPCDFMMLHLO()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 244f)
			{
				HBJJOCHGOPH = 1122f;
			}
			if (Camera2 != null)
			{
				ABHDNGIHBKE().SetTexture("SetupEncryption() got called. ", JDMCFBKJHDD);
			}
			HKGAONMOBMH().SetFloat("ConfigVersionSlider", HBJJOCHGOPH);
			CBCNOEIALHB().SetFloat("CameraFilterPack_Broken_Screen1", BlendFX);
			FHFLKLMFHOI().SetFloat("Finished", Adjust);
			DONENAMLFLF().SetFloat("Data/Maps/", Precision);
			FHFLKLMFHOI().SetFloat(". Set PhotonNetwork.OnEventCall.", Luminosity);
			NBPKMLMCHFN.SetFloat("_Blurred", Change_Red);
			EOCCJGIGEGJ().SetFloat("SettingsCanvas", Change_Green);
			LNLKMDPHDCC().SetFloat(". Our prefix is ", Change_Blue);
			MLMKCOINOOH().SetColor("#failed!", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material MLMKCOINOOH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void EFJDNLGNACH()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 110);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HEBOIFKBLGD()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void KOFAMEKHHGD()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -35);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GPNAOAKCMHC()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 56);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MMPHNFPPEHO()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 46);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
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
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture("_MainTex2", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat("_TimeX", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value", BlendFX);
			NBPKMLMCHFN.SetFloat("_Value2", Adjust);
			NBPKMLMCHFN.SetFloat("_Value3", Precision);
			NBPKMLMCHFN.SetFloat("_Value4", Luminosity);
			NBPKMLMCHFN.SetFloat("_Value5", Change_Red);
			NBPKMLMCHFN.SetFloat("_Value6", Change_Green);
			NBPKMLMCHFN.SetFloat("_Value7", Change_Blue);
			NBPKMLMCHFN.SetColor("_ColorKey", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IENKPJEBMFM()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
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
			if (HBJJOCHGOPH > 985f)
			{
				HBJJOCHGOPH = 1952f;
			}
			if (Camera2 != null)
			{
				ABHDNGIHBKE().SetTexture("shader.invert", JDMCFBKJHDD);
			}
			FHFLKLMFHOI().SetFloat("HiddenToggle", HBJJOCHGOPH);
			LPDOGGFOBDH().SetFloat("[PlayerBase] Current attempt: ", BlendFX);
			ABHDNGIHBKE().SetFloat("CameraFilterPack/Edge_Neon", Adjust);
			ABHDNGIHBKE().SetFloat("_Visualize", Precision);
			LPCHMEKDCHI().SetFloat("player.blackcat", Luminosity);
			DONENAMLFLF().SetFloat("Music End", Change_Red);
			GKILCDHJFEG().SetFloat("request", Change_Green);
			HKIMAANBGMJ().SetFloat("_Radius", Change_Blue);
			GKILCDHJFEG().SetColor("InfoButton", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KLILJHJNICK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -109);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FDMAEPOHDMK()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HAIAHJPCPAG()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -58);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material LPCHMEKDCHI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)93;
		}
		return BJFKDHHMLJH;
	}

	private void LIFBFDKFMMH()
	{
		FMFNILJIEIA();
		Update();
	}

	[SpecialName]
	private Material MHBAIEKFBIJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void JBNPEHMDCMI()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1431f)
			{
				HBJJOCHGOPH = 417f;
			}
			if (Camera2 != null)
			{
				DONENAMLFLF().SetTexture("score", JDMCFBKJHDD);
			}
			MHBAIEKFBIJ().SetFloat("}", HBJJOCHGOPH);
			LPDOGGFOBDH().SetFloat("_TimeX", BlendFX);
			GKILCDHJFEG().SetFloat("[Left]", Adjust);
			CBCNOEIALHB().SetFloat("maps.", Precision);
			MLMKCOINOOH().SetFloat("_Green_C", Luminosity);
			NBPKMLMCHFN.SetFloat("_TimeX", Change_Red);
			HKIMAANBGMJ().SetFloat("CameraFilterPack/EyesVision_1", Change_Green);
			HKGAONMOBMH().SetFloat("Fade", Change_Blue);
			IIBLJCKLGFG().SetColor("[ResourcesManager] Load text error: not found", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AEMGPJDJGBJ()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -112);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PHJLHCMCCKE()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1755f)
			{
				HBJJOCHGOPH = 871f;
			}
			if (Camera2 != null)
			{
				LNLKMDPHDCC().SetTexture(".g", JDMCFBKJHDD);
			}
			IIBLJCKLGFG().SetFloat("_FixDistance", HBJJOCHGOPH);
			CIAFLBFJLEJ().SetFloat("arc", BlendFX);
			GCDFNHMJMIP().SetFloat("/", Adjust);
			FHFLKLMFHOI().SetFloat("Received OnSerialization for view ID ", Precision);
			GKILCDHJFEG().SetFloat("/", Luminosity);
			GKILCDHJFEG().SetFloat("Fade", Change_Red);
			IIBLJCKLGFG().SetFloat("Image", Change_Green);
			DONENAMLFLF().SetFloat("player.xp", Change_Blue);
			EOCCJGIGEGJ().SetColor("_LightIntensity", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OKHBBIKDIEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1617f)
			{
				HBJJOCHGOPH = 561f;
			}
			if (Camera2 != null)
			{
				EOCCJGIGEGJ().SetTexture("???", JDMCFBKJHDD);
			}
			GKILCDHJFEG().SetFloat("R1", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("Fade", BlendFX);
			LPCHMEKDCHI().SetFloat("_Fade", Adjust);
			ABHDNGIHBKE().SetFloat("_FarCamera", Precision);
			GCDFNHMJMIP().SetFloat("mapselector.lastSearch", Luminosity);
			HKGAONMOBMH().SetFloat("_TimeX", Change_Red);
			HCGJCMDJPGD().SetFloat("_TimeX", Change_Green);
			KEMAALEODNH().SetFloat("_Factor", Change_Blue);
			HKGAONMOBMH().SetColor("note.0", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FAKGFMFAPDG()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void KGHFKHBPHEH()
	{
		FLKEJJEGCFA();
		APKNAPHOFHC();
	}

	private void AOKOLPEGHDD()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void APKNAPHOFHC()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void PLBOFEPBPKC()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EJJEDJIOFAB()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IABLKKAALGI()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MFMIODIAKNI()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void BFEILOMHNPC()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OnEnable()
	{
		Start();
		Update();
	}

	private void KDMANOEMOCA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -49);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MMMDPANNAIO()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 58);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 137f)
			{
				HBJJOCHGOPH = 639f;
			}
			if (Camera2 != null)
			{
				LPDOGGFOBDH().SetTexture("SpeedSlider", JDMCFBKJHDD);
			}
			HKGAONMOBMH().SetFloat("GlassesColor2", HBJJOCHGOPH);
			CIAFLBFJLEJ().SetFloat("_Near", BlendFX);
			GCDFNHMJMIP().SetFloat("[PlayerController] ", Adjust);
			IIBLJCKLGFG().SetFloat("Object ID. Case-Sensitive", Precision);
			CBCNOEIALHB().SetFloat("CameraFilterPack/Vision_Plasma", Luminosity);
			HHIAIGCAHDA().SetFloat("menu.selectedplaymode", Change_Red);
			HHIFMIPPMPF().SetFloat("bad", Change_Green);
			MLMKCOINOOH().SetFloat("_TimeX", Change_Blue);
			DONENAMLFLF().SetColor("PointsScoreText", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FBMDHDBELEK()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void OnDisable()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LGELACBDPEH()
	{
		OHFOLGANOLC();
		HLDFOJMHKNL();
	}

	private void LLDBPKHDPKI()
	{
		OKLAJINHPAN();
		Update();
	}

	private void ABIOAMNCEOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 432f)
			{
				HBJJOCHGOPH = 1553f;
			}
			if (Camera2 != null)
			{
				KEMAALEODNH().SetTexture(";", JDMCFBKJHDD);
			}
			KEMAALEODNH().SetFloat("CameraFilterPack/Drawing_Manga", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Atmosphere_Rain_Pro_3D", BlendFX);
			LNLKMDPHDCC().SetFloat("\"", Adjust);
			HKIMAANBGMJ().SetFloat("_Blue_C", Precision);
			KEMAALEODNH().SetFloat("Set sun audio input", Luminosity);
			CBCNOEIALHB().SetFloat("[EditorEvent] Exception: ", Change_Red);
			LPDOGGFOBDH().SetFloat("_TapLowForeground", Change_Green);
			LNLKMDPHDCC().SetFloat("CameraFilterPack/3D_Inverse", Change_Blue);
			IIBLJCKLGFG().SetColor("_SpawnHeuristic", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIAIGCAHDA());
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
			if (HBJJOCHGOPH > 1829f)
			{
				HBJJOCHGOPH = 935f;
			}
			if (Camera2 != null)
			{
				LNLKMDPHDCC().SetTexture("Please attach component to a Graphical UI component", JDMCFBKJHDD);
			}
			MHBAIEKFBIJ().SetFloat("visible", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("colorC", BlendFX);
			CIAFLBFJLEJ().SetFloat(" argument(s): ", Adjust);
			EOCCJGIGEGJ().SetFloat("file://", Precision);
			GCDFNHMJMIP().SetFloat("CameraFilterPack/Vision_Plasma", Luminosity);
			EOCCJGIGEGJ().SetFloat("_TimeX", Change_Red);
			ABHDNGIHBKE().SetFloat("settings.shaders", Change_Green);
			MHBAIEKFBIJ().SetFloat("Failed to InstantiateSceneObject prefab: ", Change_Blue);
			HHIAIGCAHDA().SetColor("_Value3", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MHBAIEKFBIJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FJKJGBLPDGG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 588f)
			{
				HBJJOCHGOPH = 1513f;
			}
			if (Camera2 != null)
			{
				CBCNOEIALHB().SetTexture("_Value3", JDMCFBKJHDD);
			}
			HKIMAANBGMJ().SetFloat("_Value", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("GameScene", BlendFX);
			LNLKMDPHDCC().SetFloat(" ", Adjust);
			KEMAALEODNH().SetFloat("_Value8", Precision);
			HCGJCMDJPGD().SetFloat(".", Luminosity);
			FHFLKLMFHOI().SetFloat("_Value2", Change_Red);
			LPDOGGFOBDH().SetFloat("_TimeX", Change_Green);
			GCDFNHMJMIP().SetFloat("PunRespawn with Position.", Change_Blue);
			GCDFNHMJMIP().SetColor("TRACKING", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FCKMAOMOKNB()
	{
		KLILJHJNICK();
		BFGIMALGMAJ();
	}

	private void BMIOFJFMCBG()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -9);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BFGIMALGMAJ()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void MGMAOBPPOBJ()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -95);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void Update()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void EHJJFJCKGAJ()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void PPGEGFMNIKO()
	{
		FLKEJJEGCFA();
		KCDBBPKIFNJ();
	}

	private void IJCBBIJOCAH()
	{
		NNFMIAFHMJM();
		MFMIODIAKNI();
	}

	private void IBPAMDEAGJL()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KDBKBPCIHBL()
	{
		KDMANOEMOCA();
		EHJJFJCKGAJ();
	}

	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 51f)
			{
				HBJJOCHGOPH = 1507f;
			}
			if (Camera2 != null)
			{
				HHIAIGCAHDA().SetTexture("[EditorEvent] Exception: ", JDMCFBKJHDD);
			}
			ABHDNGIHBKE().SetFloat("ls", HBJJOCHGOPH);
			HKGAONMOBMH().SetFloat(":", BlendFX);
			GKILCDHJFEG().SetFloat("SetParticlesCountPerBeat", Adjust);
			CBCNOEIALHB().SetFloat("Exit to menu?", Precision);
			GKILCDHJFEG().SetFloat("_TimeX", Luminosity);
			GKILCDHJFEG().SetFloat("ConfigVersionSlider", Change_Red);
			MLMKCOINOOH().SetFloat("custom", Change_Green);
			IIBLJCKLGFG().SetFloat("_ScreenResolution", Change_Blue);
			CIAFLBFJLEJ().SetColor("_SSRMultiplier", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JBCNIPJDPJB()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void LBPHCAMMAPB()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JOACBIEHHCE()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	[SpecialName]
	private Material IIBLJCKLGFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	private void EKCKJLFFAID()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material EOCCJGIGEGJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material ABHDNGIHBKE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void JNALDALAJLG()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NNCCPEBIAKH()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 88);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HLDFOJMHKNL()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void KCDBBPKIFNJ()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1005f)
			{
				HBJJOCHGOPH = 1919f;
			}
			if (Camera2 != null)
			{
				MHBAIEKFBIJ().SetTexture("maps.", JDMCFBKJHDD);
			}
			DONENAMLFLF().SetFloat("_Value", HBJJOCHGOPH);
			CIAFLBFJLEJ().SetFloat("_BlueAmplifier", BlendFX);
			GCDFNHMJMIP().SetFloat("CameraFilterPack/TV_ARCADE_Fast", Adjust);
			IIBLJCKLGFG().SetFloat("FinalScoreText", Precision);
			LPCHMEKDCHI().SetFloat("_EmissionGain", Luminosity);
			MHBAIEKFBIJ().SetFloat("_Value2", Change_Red);
			HKIMAANBGMJ().SetFloat("_Value", Change_Green);
			LPCHMEKDCHI().SetFloat("LostLive", Change_Blue);
			EOCCJGIGEGJ().SetColor("_MainTex2", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material CBCNOEIALHB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material FHFLKLMFHOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)111;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material GCDFNHMJMIP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HKGAONMOBMH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-105);
		}
		return BJFKDHHMLJH;
	}

	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 505f)
			{
				HBJJOCHGOPH = 1008f;
			}
			if (Camera2 != null)
			{
				MHBAIEKFBIJ().SetTexture("OxOD.lastPath", JDMCFBKJHDD);
			}
			HKIMAANBGMJ().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("note.3", BlendFX);
			MLMKCOINOOH().SetFloat("_BlurVector", Adjust);
			ABHDNGIHBKE().SetFloat("Joystick1Button12", Precision);
			MLMKCOINOOH().SetFloat("Bad parameters for setint! Use <key> <value>", Luminosity);
			LPDOGGFOBDH().SetFloat("Avoid using this directly. Thanks.", Change_Red);
			CIAFLBFJLEJ().SetFloat("_TimeX", Change_Green);
			LPDOGGFOBDH().SetFloat("[PlayerBase] Loaded custom model: ", Change_Blue);
			HHIFMIPPMPF().SetColor("Save", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CBCNOEIALHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HHIAIGCAHDA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 975f)
			{
				HBJJOCHGOPH = 1204f;
			}
			if (Camera2 != null)
			{
				GCDFNHMJMIP().SetTexture("scene ", JDMCFBKJHDD);
			}
			HHIFMIPPMPF().SetFloat("_Speed", HBJJOCHGOPH);
			LPCHMEKDCHI().SetFloat("ColorBlood", BlendFX);
			MLMKCOINOOH().SetFloat("DPADHOR", Adjust);
			HCGJCMDJPGD().SetFloat(" Server: ", Precision);
			LPDOGGFOBDH().SetFloat("/", Luminosity);
			MLMKCOINOOH().SetFloat("GenerationMenu", Change_Red);
			HHIFMIPPMPF().SetFloat("_ScreenResolution", Change_Green);
			EOCCJGIGEGJ().SetFloat("StartButton", Change_Blue);
			EOCCJGIGEGJ().SetColor("_TimeX", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 114f)
			{
				HBJJOCHGOPH = 585f;
			}
			if (Camera2 != null)
			{
				CBCNOEIALHB().SetTexture("#close", JDMCFBKJHDD);
			}
			CIAFLBFJLEJ().SetFloat("DPADVER", HBJJOCHGOPH);
			CIAFLBFJLEJ().SetFloat("_TimeX", BlendFX);
			NBPKMLMCHFN.SetFloat("float,2", Adjust);
			LPCHMEKDCHI().SetFloat(", ", Precision);
			CBCNOEIALHB().SetFloat(".sawoutdatedmessage", Luminosity);
			ABHDNGIHBKE().SetFloat("(((?<x>(?=[,\\r\\n]+))|\"(?<x>([^\"]|\"\")+)\"|(?<x>[^,\\r\\n]+)),?)", Change_Red);
			NBPKMLMCHFN.SetFloat("CameraFilterPack_Atmosphere_Rain_FX", Change_Green);
			HHIAIGCAHDA().SetFloat("EnableRankingToggle", Change_Blue);
			GCDFNHMJMIP().SetColor("challenges.", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HNILMGEKDEC()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MEJPBKFMAIG()
	{
		IGPCNCJIEOJ();
		DGCGGKMNPLD();
	}

	private void LJIHHJOAJCN()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void NNBCLMJGFEN()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1767f)
			{
				HBJJOCHGOPH = 1194f;
			}
			if (Camera2 != null)
			{
				MHBAIEKFBIJ().SetTexture("Can't start OFFLINE mode while connected!", JDMCFBKJHDD);
			}
			LNLKMDPHDCC().SetFloat("_Value", HBJJOCHGOPH);
			MLMKCOINOOH().SetFloat("_Value", BlendFX);
			ABHDNGIHBKE().SetFloat("masterSteamID", Adjust);
			FHFLKLMFHOI().SetFloat("Set camera (or player) distance. Base player distance - 14", Precision);
			CIAFLBFJLEJ().SetFloat("_TimeX", Luminosity);
			HKGAONMOBMH().SetFloat("_Intensity", Change_Red);
			HKGAONMOBMH().SetFloat("r", Change_Green);
			CBCNOEIALHB().SetFloat("CameraFilterPack/Blend2Camera_LinearLight", Change_Blue);
			MLMKCOINOOH().SetColor("_ScreenResolution", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HLIAEEMGBHN()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -124);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OKLAJINHPAN()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 47);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BNEJMABFKJE()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IGCJMAADPGG()
	{
		Start();
		ONKDMMJPEMN();
	}

	private void DPGHJILBPCE()
	{
		AEDDNDHCLNN();
		JBCNIPJDPJB();
	}

	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 498f)
			{
				HBJJOCHGOPH = 1805f;
			}
			if (Camera2 != null)
			{
				GCDFNHMJMIP().SetTexture("_ScreenResolution", JDMCFBKJHDD);
			}
			HHIAIGCAHDA().SetFloat(" ", HBJJOCHGOPH);
			DONENAMLFLF().SetFloat("_TimeX", BlendFX);
			MHBAIEKFBIJ().SetFloat("_MatrixColor", Adjust);
			HKIMAANBGMJ().SetFloat("Image", Precision);
			CBCNOEIALHB().SetFloat("_ScreenResolution", Luminosity);
			CIAFLBFJLEJ().SetFloat("FavoriteButton", Change_Red);
			KEMAALEODNH().SetFloat(";", Change_Green);
			GKILCDHJFEG().SetFloat("ConnectToMaster() disabled the offline mode. No longer offline.", Change_Blue);
			LPCHMEKDCHI().SetColor("Failed to InstantiateSceneObject prefab: ", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material GKILCDHJFEG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-69);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HCGJCMDJPGD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)104;
		}
		return BJFKDHHMLJH;
	}

	private void Start()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 24);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GFACKFCEIBC()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void IEFMONDKKJN()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 352f)
			{
				HBJJOCHGOPH = 1826f;
			}
			if (Camera2 != null)
			{
				HHIFMIPPMPF().SetTexture("Done!", JDMCFBKJHDD);
			}
			GKILCDHJFEG().SetFloat("Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. ", HBJJOCHGOPH);
			LPDOGGFOBDH().SetFloat("_Speed", BlendFX);
			LPCHMEKDCHI().SetFloat("_Value2", Adjust);
			HHIFMIPPMPF().SetFloat("BitsData", Precision);
			HKGAONMOBMH().SetFloat("MainCamera", Luminosity);
			GKILCDHJFEG().SetFloat("_AccumOrig", Change_Red);
			HCGJCMDJPGD().SetFloat("Switch environment sprite image", Change_Green);
			MHBAIEKFBIJ().SetFloat("s", Change_Blue);
			HKGAONMOBMH().SetColor("Gameplay/sprite", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HKIMAANBGMJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material LPDOGGFOBDH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-96);
		}
		return BJFKDHHMLJH;
	}
}
