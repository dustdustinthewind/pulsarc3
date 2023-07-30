// CameraFilterPack_Blend2Camera_ColorKey
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Chroma Key/Color Key")]
[ExecuteInEditMode]
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
				HKGAONMOBMH().SetTexture("Set Object Position", JDMCFBKJHDD);
			}
			LNLKMDPHDCC().SetFloat("[LocalizationService] Loading file: ", HBJJOCHGOPH);
			MLMKCOINOOH().SetFloat("menu.selectedplaymode", BlendFX);
			HCGJCMDJPGD().SetFloat("menu.selectedlevelid", Adjust);
			CBCNOEIALHB().SetFloat("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", Precision);
			CIAFLBFJLEJ().SetFloat("SetEnvSpriteImage", Luminosity);
			FHFLKLMFHOI().SetFloat("_Parameter", Change_Red);
			HHIAIGCAHDA().SetFloat("Set Sun DirectionVector", Change_Green);
			LNLKMDPHDCC().SetFloat("StartCanvas", Change_Blue);
			MLMKCOINOOH().SetColor("0,1,false", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MHBAIEKFBIJ());
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
				HKGAONMOBMH().SetTexture("mapselector.filter.favoriteonly", JDMCFBKJHDD);
			}
			MHBAIEKFBIJ().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			MLMKCOINOOH().SetFloat("Anomaly_Distortion", BlendFX);
			CBCNOEIALHB().SetFloat("TypedLobbyInfo '{0}'[{1}] rooms: {2} players: {3}", Adjust);
			HHIAIGCAHDA().SetFloat("SetSatelliteLerpSpeed", Precision);
			LNLKMDPHDCC().SetFloat("_ProjectToPixelMatrix", Luminosity);
			GKILCDHJFEG().SetFloat("SetSunLerpSpeed", Change_Red);
			ABHDNGIHBKE().SetFloat("_Red_B", Change_Green);
			ABHDNGIHBKE().SetFloat("OxOD.lastPath", Change_Blue);
			FHFLKLMFHOI().SetColor("_LightIntensity", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
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
		FLKEJJEGCFA();
		BFGIMALGMAJ();
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
				CIAFLBFJLEJ().SetTexture("[RanksSystem] Ranks: no need to update", JDMCFBKJHDD);
			}
			HHIFMIPPMPF().SetFloat("DisableStoryboardToggle", HBJJOCHGOPH);
			CBCNOEIALHB().SetFloat("event", BlendFX);
			CIAFLBFJLEJ().SetFloat("Protocol switch from: ", Adjust);
			MLMKCOINOOH().SetFloat("\n", Precision);
			CIAFLBFJLEJ().SetFloat("Change Note:", Luminosity);
			LPDOGGFOBDH().SetFloat(". Check if the server is available.", Change_Red);
			FHFLKLMFHOI().SetFloat("_Distortion", Change_Green);
			HHIFMIPPMPF().SetFloat("CameraFilterPack/3D_BlackHole", Change_Blue);
			EOCCJGIGEGJ().SetColor("GlassesColor", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
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
				CIAFLBFJLEJ().SetTexture("_Far", JDMCFBKJHDD);
			}
			HKIMAANBGMJ().SetFloat("MapCreationCanvas", HBJJOCHGOPH);
			LPCHMEKDCHI().SetFloat("LevelNameInputField", BlendFX);
			NBPKMLMCHFN.SetFloat("?", Adjust);
			FHFLKLMFHOI().SetFloat("_Value", Precision);
			HCGJCMDJPGD().SetFloat("Object ID. Case-Sensitive", Luminosity);
			HKIMAANBGMJ().SetFloat("#91CCFF", Change_Red);
			HKGAONMOBMH().SetFloat("_SecondTex", Change_Green);
			MHBAIEKFBIJ().SetFloat("_SmoothStart", Change_Blue);
			GKILCDHJFEG().SetColor(". Stopping handling if inactive.", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
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
				HCGJCMDJPGD().SetTexture("_Value2", JDMCFBKJHDD);
			}
			HKIMAANBGMJ().SetFloat("[LevelEditorScene] Map submitted!", HBJJOCHGOPH);
			MHBAIEKFBIJ().SetFloat("_TimeX", BlendFX);
			LPCHMEKDCHI().SetFloat(".lastCheckpoint.incorrectScore", Adjust);
			LPCHMEKDCHI().SetFloat("LevelEditor/patterns", Precision);
			ABHDNGIHBKE().SetFloat("connect", Luminosity);
			HKGAONMOBMH().SetFloat("PlayMusic", Change_Red);
			CBCNOEIALHB().SetFloat("_Color", Change_Green);
			IIBLJCKLGFG().SetFloat("Left", Change_Blue);
			FHFLKLMFHOI().SetColor("_BaseTex", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
				NBPKMLMCHFN.SetTexture("Xbox Home", JDMCFBKJHDD);
			}
			HKIMAANBGMJ().SetFloat("Editor/", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("_TargetScale", BlendFX);
			HHIFMIPPMPF().SetFloat("_Value3", Adjust);
			LNLKMDPHDCC().SetFloat("Right Stick Click", Precision);
			GCDFNHMJMIP().SetFloat(" Mb", Luminosity);
			LPCHMEKDCHI().SetFloat("_TimeX", Change_Red);
			IIBLJCKLGFG().SetFloat("Texture2", Change_Green);
			GCDFNHMJMIP().SetFloat(" | ", Change_Blue);
			MLMKCOINOOH().SetColor("achievements.21.progress", ColorKey);
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
		NNCCPEBIAKH();
		FAKGFMFAPDG();
	}

	private void HIFPDKKBDHJ()
	{
		HLIAEEMGBHN();
		ABFNJCEBIKA();
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
				MHBAIEKFBIJ().SetTexture("StartButton", JDMCFBKJHDD);
			}
			HHIAIGCAHDA().SetFloat("CameraFilterPack/Broken_Screen", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("_Red_G", BlendFX);
			NBPKMLMCHFN.SetFloat("inventory.selected.", Adjust);
			EOCCJGIGEGJ().SetFloat("_Value3", Precision);
			HKIMAANBGMJ().SetFloat("_ScreenResolution", Luminosity);
			FHFLKLMFHOI().SetFloat("mapselector.orderby", Change_Red);
			FHFLKLMFHOI().SetFloat("Room: '{0}' {1},{2} {4}/{3} players.", Change_Green);
			KEMAALEODNH().SetFloat("-1", Change_Blue);
			GKILCDHJFEG().SetColor("EditMenu", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
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
				HKIMAANBGMJ().SetTexture(". Set PhotonNetwork.OnEventCall.", JDMCFBKJHDD);
			}
			ABHDNGIHBKE().SetFloat("LivesSlider", HBJJOCHGOPH);
			HKIMAANBGMJ().SetFloat("_MainTex2", BlendFX);
			GKILCDHJFEG().SetFloat("OnPlayerGameMessage", Adjust);
			LPDOGGFOBDH().SetFloat(" base map(s)", Precision);
			GCDFNHMJMIP().SetFloat("Warning: Unhandled Event ErrorInfo (251). Set PhotonNetwork.OnEventCall to the method PUN should call for this event.", Luminosity);
			IIBLJCKLGFG().SetFloat("_BlurSize", Change_Red);
			GCDFNHMJMIP().SetFloat("FPSToggle", Change_Green);
			KEMAALEODNH().SetFloat("Received OnSerialization for view ID ", Change_Blue);
			HHIFMIPPMPF().SetColor("https://steamcommunity.com/sharedfiles/filedetails/?id=", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
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
				HHIFMIPPMPF().SetTexture("shader.future", JDMCFBKJHDD);
			}
			HCGJCMDJPGD().SetFloat("TwoHands", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("maps.", BlendFX);
			CBCNOEIALHB().SetFloat("_ScreenResolution", Adjust);
			CBCNOEIALHB().SetFloat("_Visualize", Precision);
			HHIAIGCAHDA().SetFloat("???", Luminosity);
			HKIMAANBGMJ().SetFloat("Music End", Change_Red);
			HHIFMIPPMPF().SetFloat("replayData", Change_Green);
			GKILCDHJFEG().SetFloat("_Radius", Change_Blue);
			MHBAIEKFBIJ().SetColor("InfoButton", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FHFLKLMFHOI());
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
		LFBGJIIECLD();
		ABFNJCEBIKA();
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
				NBPKMLMCHFN.SetTexture("mine", JDMCFBKJHDD);
			}
			ABHDNGIHBKE().SetFloat("Yes", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("_TimeX", BlendFX);
			KEMAALEODNH().SetFloat("[Left]", Adjust);
			KEMAALEODNH().SetFloat("maps.", Precision);
			IIBLJCKLGFG().SetFloat("_Blue_B", Luminosity);
			HCGJCMDJPGD().SetFloat("_VignettingDirt", Change_Red);
			MLMKCOINOOH().SetFloat("CameraFilterPack_eyes_vision_1", Change_Green);
			KEMAALEODNH().SetFloat("UseFinalGlassColor", Change_Blue);
			HHIFMIPPMPF().SetColor("#TBD", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
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
				HCGJCMDJPGD().SetTexture(".r", JDMCFBKJHDD);
			}
			LNLKMDPHDCC().SetFloat("_FixDistance", HBJJOCHGOPH);
			LPDOGGFOBDH().SetFloat("arc", BlendFX);
			IIBLJCKLGFG().SetFloat("ERROR: Preview file name in modName.workshop.json doesn't match any file", Adjust);
			CIAFLBFJLEJ().SetFloat("PhotonView with ID {0} wasn't properly unregistered! Please report this case to developer@photonengine.com", Precision);
			CBCNOEIALHB().SetFloat("LoadMapCanvas", Luminosity);
			HHIFMIPPMPF().SetFloat("_Value4", Change_Red);
			GCDFNHMJMIP().SetFloat("other", Change_Green);
			GKILCDHJFEG().SetFloat("player.xp", Change_Blue);
			MHBAIEKFBIJ().SetColor("_LightIntensity", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
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
				FHFLKLMFHOI().SetTexture("_UserLutTex", JDMCFBKJHDD);
			}
			LPDOGGFOBDH().SetFloat("L1", HBJJOCHGOPH);
			FHFLKLMFHOI().SetFloat("_TimeX", BlendFX);
			GKILCDHJFEG().SetFloat("_Wavy", Adjust);
			MHBAIEKFBIJ().SetFloat("_Visualize", Precision);
			LPCHMEKDCHI().SetFloat("PopulateMapsList", Luminosity);
			ABHDNGIHBKE().SetFloat("CameraFilterPack/Colors_HUE_Rotate", Change_Red);
			CIAFLBFJLEJ().SetFloat("_TimeX", Change_Green);
			LPDOGGFOBDH().SetFloat("_Factor", Change_Blue);
			IIBLJCKLGFG().SetColor("#outdatedmap! Challenges will not work!", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
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
		MMPHNFPPEHO();
		HLDFOJMHKNL();
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
				KEMAALEODNH().SetTexture("Tab2Content", JDMCFBKJHDD);
			}
			HCGJCMDJPGD().SetFloat("GlassesColor", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("_Near", BlendFX);
			HHIAIGCAHDA().SetFloat(" not exist", Adjust);
			MHBAIEKFBIJ().SetFloat("Object ID. Case-Sensitive", Precision);
			GCDFNHMJMIP().SetFloat("_ScreenResolution", Luminosity);
			NBPKMLMCHFN.SetFloat("mapselector.lastSearch", Change_Red);
			HKGAONMOBMH().SetFloat("quantity", Change_Green);
			GKILCDHJFEG().SetFloat("CameraFilterPack/TV_Artefact", Change_Blue);
			NBPKMLMCHFN.SetColor("PossibleMapPointsText", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
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
		MMPHNFPPEHO();
		ONKDMMJPEMN();
	}

	private void LLDBPKHDPKI()
	{
		IMCKJCHKMKB();
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
				HHIFMIPPMPF().SetTexture(" ", JDMCFBKJHDD);
			}
			HHIFMIPPMPF().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			HKIMAANBGMJ().SetFloat("CameraFilterPack/Atmosphere_Rain_Pro_3D", BlendFX);
			HCGJCMDJPGD().SetFloat("time", Adjust);
			LNLKMDPHDCC().SetFloat("_Green_C", Precision);
			CIAFLBFJLEJ().SetFloat("0,7,true,0", Luminosity);
			KEMAALEODNH().SetFloat("SpawnObj", Change_Red);
			ABHDNGIHBKE().SetFloat("_TapMedium", Change_Green);
			DONENAMLFLF().SetFloat("CameraFilterPack/3D_Inverse", Change_Blue);
			DONENAMLFLF().SetColor("_Offsets", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPCHMEKDCHI());
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
				HKIMAANBGMJ().SetTexture("Default UI Material", JDMCFBKJHDD);
			}
			HKGAONMOBMH().SetFloat("closed", HBJJOCHGOPH);
			MLMKCOINOOH().SetFloat("colorA", BlendFX);
			LPDOGGFOBDH().SetFloat(" has no method \"", Adjust);
			HKGAONMOBMH().SetFloat(".mp3", Precision);
			GCDFNHMJMIP().SetFloat("_ScreenResolution", Luminosity);
			MLMKCOINOOH().SetFloat("CameraFilterPack/Special_Bubble", Change_Red);
			KEMAALEODNH().SetFloat("settings.shaders.bloomintencity", Change_Green);
			MHBAIEKFBIJ().SetFloat(". Prefab must have a PhotonView component.", Change_Blue);
			GKILCDHJFEG().SetColor("_Value", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
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
				HKIMAANBGMJ().SetTexture("_Value2", JDMCFBKJHDD);
			}
			HKIMAANBGMJ().SetFloat("_Value", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("[SERVER] Kicked ", BlendFX);
			HCGJCMDJPGD().SetFloat("master", Adjust);
			GCDFNHMJMIP().SetFloat("_Value8", Precision);
			FHFLKLMFHOI().SetFloat("maps.", Luminosity);
			CBCNOEIALHB().SetFloat("_Value", Change_Red);
			GKILCDHJFEG().SetFloat("_TimeX", Change_Green);
			LNLKMDPHDCC().SetFloat("OnPickedUp", Change_Blue);
			KEMAALEODNH().SetColor("VHS2", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FCKMAOMOKNB()
	{
		FMFNILJIEIA();
		APKNAPHOFHC();
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
		Start();
		ABFNJCEBIKA();
	}

	private void IJCBBIJOCAH()
	{
		MMMDPANNAIO();
		EHJJFJCKGAJ();
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
		GPNAOAKCMHC();
		MFMIODIAKNI();
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
				CBCNOEIALHB().SetTexture("_EmissionColor", JDMCFBKJHDD);
			}
			CIAFLBFJLEJ().SetFloat("en", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("\r", BlendFX);
			ABHDNGIHBKE().SetFloat("Set particles start speed", Adjust);
			ABHDNGIHBKE().SetFloat("OK", Precision);
			HKGAONMOBMH().SetFloat("_TimeX", Luminosity);
			HKGAONMOBMH().SetFloat("ConfigVersionSlider", Change_Red);
			LNLKMDPHDCC().SetFloat("UI", Change_Green);
			KEMAALEODNH().SetFloat("_Value4", Change_Blue);
			HHIFMIPPMPF().SetColor("_FadeDistance", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
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
			ABHDNGIHBKE().SetFloat("_Value", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat("_GreenAmplifier", BlendFX);
			KEMAALEODNH().SetFloat("CameraFilterPack_TV_Arcade1", Adjust);
			IIBLJCKLGFG().SetFloat("restart", Precision);
			HKGAONMOBMH().SetFloat("_EmissionColor", Luminosity);
			NBPKMLMCHFN.SetFloat("_Value2", Change_Red);
			EOCCJGIGEGJ().SetFloat("_TimeX", Change_Green);
			DONENAMLFLF().SetFloat("_EmissionGain", Change_Blue);
			DONENAMLFLF().SetColor("UseScanLine", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
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
				HKIMAANBGMJ().SetTexture("/../", JDMCFBKJHDD);
			}
			IIBLJCKLGFG().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			HKIMAANBGMJ().SetFloat("note.2", BlendFX);
			LPDOGGFOBDH().SetFloat("_BlurVector", Adjust);
			CBCNOEIALHB().SetFloat("Joystick1Button11", Precision);
			LPDOGGFOBDH().SetFloat("setint", Luminosity);
			HKGAONMOBMH().SetFloat("{0}{1}:{2}", Change_Red);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/TV_Artefact", Change_Green);
			KEMAALEODNH().SetFloat("Gameplay/sun", Change_Blue);
			MLMKCOINOOH().SetColor("Save", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
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
				CIAFLBFJLEJ().SetTexture(" SecondsBeforeRespawn: ", JDMCFBKJHDD);
			}
			CBCNOEIALHB().SetFloat("_TimeX", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value2", BlendFX);
			GKILCDHJFEG().SetFloat("DPADHOR", Adjust);
			IIBLJCKLGFG().SetFloat("Operation failed: ", Precision);
			HHIAIGCAHDA().SetFloat("PublishButton", Luminosity);
			DONENAMLFLF().SetFloat("EventMenu", Change_Red);
			LNLKMDPHDCC().SetFloat("_Fade", Change_Green);
			LPCHMEKDCHI().SetFloat(" joined", Change_Blue);
			GCDFNHMJMIP().SetColor("CameraFilterPack/Light_Water", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CBCNOEIALHB());
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
				KEMAALEODNH().SetTexture("#close", JDMCFBKJHDD);
			}
			HHIFMIPPMPF().SetFloat("DPADHOR", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Edge_Golden", BlendFX);
			HKGAONMOBMH().SetFloat("value", Adjust);
			NBPKMLMCHFN.SetFloat("null", Precision);
			EOCCJGIGEGJ().SetFloat("_copy", Luminosity);
			DONENAMLFLF().SetFloat("\"", Change_Red);
			HKGAONMOBMH().SetFloat("CameraFilterPack_Atmosphere_Rain_FX", Change_Green);
			MLMKCOINOOH().SetFloat("EnableRankingToggle", Change_Blue);
			LNLKMDPHDCC().SetColor(".completedCount", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FHFLKLMFHOI());
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
		BMIOFJFMCBG();
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
				HHIFMIPPMPF().SetTexture("PhotonMono", JDMCFBKJHDD);
			}
			GKILCDHJFEG().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			LPDOGGFOBDH().SetFloat("_TimeX", BlendFX);
			NBPKMLMCHFN.SetFloat("roomDescription", Adjust);
			HKIMAANBGMJ().SetFloat("Set camera (or player) distance. Base player distance - 14", Precision);
			KEMAALEODNH().SetFloat("CameraFilterPack_TV_BrokenGlass1", Luminosity);
			HKIMAANBGMJ().SetFloat("_MainTex", Change_Red);
			NBPKMLMCHFN.SetFloat("UnityEngine.MonoBehaviour", Change_Green);
			HCGJCMDJPGD().SetFloat("CameraFilterPack/Blend2Camera_LinearLight", Change_Blue);
			ABHDNGIHBKE().SetColor("_ScreenResolution", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DONENAMLFLF());
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
		LFBGJIIECLD();
		CPCDFMMLHLO();
	}

	private void DPGHJILBPCE()
	{
		EFJDNLGNACH();
		BFGIMALGMAJ();
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
				GCDFNHMJMIP().SetTexture("Distortion", JDMCFBKJHDD);
			}
			HKGAONMOBMH().SetFloat(": ", HBJJOCHGOPH);
			MLMKCOINOOH().SetFloat("CameraFilterPack/TV_Horror", BlendFX);
			FHFLKLMFHOI().SetFloat("_MatrixColor", Adjust);
			GKILCDHJFEG().SetFloat("Image", Precision);
			LNLKMDPHDCC().SetFloat("_ScreenResolution", Luminosity);
			LPCHMEKDCHI().SetFloat("LeaderboardsButton", Change_Red);
			HCGJCMDJPGD().SetFloat(" ", Change_Green);
			KEMAALEODNH().SetFloat("ConnectUsingSettings() disabled the offline mode. No longer offline.", Change_Blue);
			HHIFMIPPMPF().SetColor("Failed to InstantiateSceneObject prefab:", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
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
				HKIMAANBGMJ().SetTexture("Sprite", JDMCFBKJHDD);
			}
			CIAFLBFJLEJ().SetFloat("Bad SegmentType passed in to CreateLineCap. Must be SegmentType.Start or SegmentType.End", HBJJOCHGOPH);
			MLMKCOINOOH().SetFloat("_Value3", BlendFX);
			IIBLJCKLGFG().SetFloat("_Value2", Adjust);
			LPDOGGFOBDH().SetFloat("BitsData", Precision);
			LNLKMDPHDCC().SetFloat("Left", Luminosity);
			HKIMAANBGMJ().SetFloat("_Angle", Change_Red);
			GKILCDHJFEG().SetFloat("New resource ID. Case-Sensitive", Change_Green);
			GKILCDHJFEG().SetFloat("{0:0} minute{1}, ", Change_Blue);
			HHIFMIPPMPF().SetColor("Gameplay/Segment-[PowerUp]", ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CIAFLBFJLEJ());
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
