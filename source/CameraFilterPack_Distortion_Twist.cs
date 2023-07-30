// CameraFilterPack_Distortion_Twist
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Distortion/Twist")]
[ExecuteInEditMode]
public class CameraFilterPack_Distortion_Twist : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(-2f, 2f)]
	public float CenterX = 0.5f;

	[Range(-2f, 2f)]
	public float CenterY = 0.5f;

	[Range(-3.14f, 3.14f)]
	public float Distortion = 1f;

	[Range(-2f, 2f)]
	public float Size = 1f;

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

	private void CIHGFHNNFEE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IAJKLKJJKEJ()
	{
	}

	private void COOHIILCOCO()
	{
		SCShader = Shader.Find("_BaseTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NDBPCNICGLC()
	{
		SCShader = Shader.Find(".g");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PHJJHFBLICM()
	{
	}

	private void IHLMNAGPKDA()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material MLMKCOINOOH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.HideAndDontSave;
		}
		return BJFKDHHMLJH;
	}

	private void FJABOCDLCAI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1342f)
			{
				HBJJOCHGOPH = 1857f;
			}
			EMDFHOKEGNG().SetFloat("offsets", HBJJOCHGOPH);
			LELKBCALFCF().SetFloat("SetTrailZoomSpeed", CenterX);
			HCGJCMDJPGD().SetFloat("Most likely the game became empty during the switch to GameServer.", CenterY);
			IONHGBPGCHK().SetFloat("_ScreenResolution", Distortion);
			EBJKJPAIAAM().SetFloat("settings.selectormapsperpage", Size);
			OGMEGHKECAH().SetVector("B:", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EBJKJPAIAAM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material GBFOAHKAJEK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-125);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material FKEOGPDLBDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void MKOMIDCPCDC()
	{
		SCShader = Shader.Find("Mouse");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material HCGJCMDJPGD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)75;
		}
		return BJFKDHHMLJH;
	}

	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1922f)
			{
				HBJJOCHGOPH = 1694f;
			}
			NBPKMLMCHFN.SetFloat("_Value3", HBJJOCHGOPH);
			ILKALHDJBFE().SetFloat("[PlayerController] ", CenterX);
			IONHGBPGCHK().SetFloat("CameraFilterPack_Atmosphere_Rain_FX", CenterY);
			MLMKCOINOOH().SetFloat("Validating mod pack...", Distortion);
			OKJOKHGJHGF().SetFloat("menu.playedsolo", Size);
			NFKFAAHHLLM().SetVector("_TimeX", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MHBAIEKFBIJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HNDNDPECBPL()
	{
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)127;
		}
		return BJFKDHHMLJH;
	}

	private void FBMDHDBELEK()
	{
	}

	private void OKHBBIKDIEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1883f)
			{
				HBJJOCHGOPH = 391f;
			}
			MFHPKGICPIO().SetFloat("_Value2", HBJJOCHGOPH);
			NFKFAAHHLLM().SetFloat("CameraFilterPack/3D_Inverse", CenterX);
			LELKBCALFCF().SetFloat("_TimeX", CenterY);
			OGMEGHKECAH().SetFloat("_TimeX", Distortion);
			ACHNOHCLGOO().SetFloat("_FarCamera", Size);
			FKEOGPDLBDD().SetVector("#failed: ", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 88f)
			{
				HBJJOCHGOPH = 980f;
			}
			NFKFAAHHLLM().SetFloat("default", HBJJOCHGOPH);
			EBJKJPAIAAM().SetFloat(" ", CenterX);
			EGOGECOEONM().SetFloat("_HalfResolution", CenterY);
			DOMEEFLPEPJ().SetFloat("_TimeX", Distortion);
			LELKBCALFCF().SetFloat("_ScreenResolution", Size);
			LENEJAGLCNL().SetVector("_Value", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HEBOIFKBLGD()
	{
	}

	private void NPLCENPNJBM()
	{
		SCShader = Shader.Find("CameraFilterPack/TV_Rgb");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1563f)
			{
				HBJJOCHGOPH = 657f;
			}
			IONHGBPGCHK().SetFloat(". The RPC has been ignored.", HBJJOCHGOPH);
			NFKFAAHHLLM().SetFloat(" (inactive)", CenterX);
			HJGEHJDMCGI().SetFloat("Right Click", CenterY);
			KAFBNOBOIAJ().SetFloat("\n", Distortion);
			HJGEHJDMCGI().SetFloat("RecieveChatActionMessage", Size);
			EPCGJFCCAFH().SetVector("menuthemes", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PEIMCBBHLBJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AOGCKKLFGPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1657f)
			{
				HBJJOCHGOPH = 1994f;
			}
			NLFJGMBCICG().SetFloat(",", HBJJOCHGOPH);
			HJGEHJDMCGI().SetFloat("UseFinalGlassColor", CenterX);
			MNLKBFFKHIE().SetFloat("_Value", CenterY);
			EMDFHOKEGNG().SetFloat("Circle", Distortion);
			EMDFHOKEGNG().SetFloat("levelcompleted", Size);
			KAFBNOBOIAJ().SetVector(".message", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LELKBCALFCF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BFEILOMHNPC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DFFKKLAPHCC()
	{
		SCShader = Shader.Find("https://bitbucket.org/khb-soft/intralismarcsviewer/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HIFLPHLGLFG()
	{
	}

	private void DLBODOFAJGM()
	{
		SCShader = Shader.Find("inventory.lastitemscount");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1083f)
			{
				HBJJOCHGOPH = 1333f;
			}
			DOMEEFLPEPJ().SetFloat("_BokehParams", HBJJOCHGOPH);
			LELKBCALFCF().SetFloat(": ", CenterX);
			HJGEHJDMCGI().SetFloat("vignetteIntensity", CenterY);
			FEAEGGCNIAA().SetFloat(" beatThreshold: ", Distortion);
			MLMKCOINOOH().SetFloat("[Down]", Size);
			EPCGJFCCAFH().SetVector("Items/", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
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
	private Material KEMJNOMIPHN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void DBLILJGKGHJ()
	{
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AEEGKLABFLN()
	{
	}

	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 78f)
			{
				HBJJOCHGOPH = 14f;
			}
			KEMJNOMIPHN().SetFloat("STICKLVER", HBJJOCHGOPH);
			FKEOGPDLBDD().SetFloat("_ScreenResolution", CenterX);
			NBPKMLMCHFN.SetFloat("plainText", CenterY);
			IONHGBPGCHK().SetFloat("CameraFilterPack/FX_Hexagon", Distortion);
			EPCGJFCCAFH().SetFloat("[GameScene] Events count: ", Size);
			LELKBCALFCF().SetVector("_Red_G", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MHBAIEKFBIJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JLNNHKPHMAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NKFDNIAKGEO()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material MFHPKGICPIO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-102);
		}
		return BJFKDHHMLJH;
	}

	private void NJBMCJOOMMP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 505f)
			{
				HBJJOCHGOPH = 773f;
			}
			OGMEGHKECAH().SetFloat("value", HBJJOCHGOPH);
			MHBAIEKFBIJ().SetFloat("id", CenterX);
			EGOGECOEONM().SetFloat("_DX11NoiseTime", CenterY);
			KEMJNOMIPHN().SetFloat("CameraFilterPack/Blend2Camera_ColorDodge", Distortion);
			MLMKCOINOOH().SetFloat("BadgeText", Size);
			MFHPKGICPIO().SetVector("shaders", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
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
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void JMAIIENCEKE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HNGHDAPKEJG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material DOMEEFLPEPJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.HideInInspector | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 480f)
			{
				HBJJOCHGOPH = 1958f;
			}
			FKEOGPDLBDD().SetFloat("#alreadyexist", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("OnMastedChangeScene", CenterX);
			IIJMIPBMMBF().SetFloat("#combo", CenterY);
			OKJOKHGJHGF().SetFloat("SelectionBox component is on a gameObject with a Canvas Scaler component. As of now, Canvas Scalers without the default settings throw off the coordinates of the selection box. Canvas Scaler has been removed.", Distortion);
			LENEJAGLCNL().SetFloat("ZoomSpeed", Size);
			EGOGECOEONM().SetVector("settings.fps", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JOPCCCCHNLI()
	{
		SCShader = Shader.Find("hidden");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LDDKCCMHMIC()
	{
	}

	private void MNBPNHNAEBK()
	{
		SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material KAFBNOBOIAJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void DGCGGKMNPLD()
	{
	}

	private void AIBNKIDADPI()
	{
		SCShader = Shader.Find("Tab2Content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JILOMOBDPIA()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ECBILENEOOL()
	{
		SCShader = Shader.Find(",");
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-88);
		}
		return BJFKDHHMLJH;
	}

	private void NCPAFCKGJEA()
	{
	}

	private void FANADGBGCPI()
	{
		SCShader = Shader.Find("_LightIntensity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OFMNDBNFBDJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GKNKIIEALCH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LPMINJJPDCH()
	{
	}

	private void MFLBEJHMEMO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1411f)
			{
				HBJJOCHGOPH = 1858f;
			}
			PEIMCBBHLBJ().SetFloat("_TimeX", HBJJOCHGOPH);
			MLMKCOINOOH().SetFloat("FindFriends failed to apply the result, as a required value wasn't provided or the friend list length differed from result.", CenterX);
			KEMJNOMIPHN().SetFloat("CameraFilterPack/Blend2Camera_BlueScreen", CenterY);
			OGMEGHKECAH().SetFloat("_PrevViewProj", Distortion);
			EMDFHOKEGNG().SetFloat(": ", Size);
			FEAEGGCNIAA().SetVector(", our prefix is ", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EBJKJPAIAAM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MDNHCLKNCLE()
	{
		SCShader = Shader.Find("Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HMNLHMLILKD()
	{
	}

	private void ODAIMOJLJOF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BGFJOEPFOPM()
	{
	}

	private void AEIJFLJEABG()
	{
	}

	private void PEDHPEMNHBF()
	{
		SCShader = Shader.Find("#lives");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IGJPPFJOFKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 686f)
			{
				HBJJOCHGOPH = 381f;
			}
			IONHGBPGCHK().SetFloat("/", HBJJOCHGOPH);
			GBFOAHKAJEK().SetFloat("[DiscordController] Shutdown", CenterX);
			ACHNOHCLGOO().SetFloat("Submit", CenterY);
			IIJMIPBMMBF().SetFloat("CorrectHitsScoreText", Distortion);
			ADAFMBOGPLN().SetFloat("_Value2", Size);
			LENEJAGLCNL().SetVector("_ScreenResolution", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KMKLDAJLCNM()
	{
	}

	private void FMFNILJIEIA()
	{
		SCShader = Shader.Find("settings_bindings_sec_");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NNCCPEBIAKH()
	{
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GNPDGBNDCPL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NHHCGPAMLAJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GOIMKCCICFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 562f)
			{
				HBJJOCHGOPH = 361f;
			}
			GJHLADDCMFF().SetFloat("CameraFilterPack_Blizzard1", HBJJOCHGOPH);
			LELKBCALFCF().SetFloat("UseScanLine", CenterX);
			NFKFAAHHLLM().SetFloat("SendVacantViewIds()", CenterY);
			GJHLADDCMFF().SetFloat("_EmissionGain", Distortion);
			HJGEHJDMCGI().SetFloat("offsets", Size);
			EMDFHOKEGNG().SetVector("_Value", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF());
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

	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1107f)
			{
				HBJJOCHGOPH = 1483f;
			}
			MLMKCOINOOH().SetFloat(" (now: ", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("Sprite", CenterX);
			MHBAIEKFBIJ().SetFloat("_Value10", CenterY);
			LENEJAGLCNL().SetFloat("GlassColor", Distortion);
			GJHLADDCMFF().SetFloat("#forever", Size);
			EMDFHOKEGNG().SetVector("CameraFilterPack/Glasses_OnX", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JCGMGLMADEN()
	{
	}

	[SpecialName]
	private Material GJHLADDCMFF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void BNCLKHOEGDK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1787f)
			{
				HBJJOCHGOPH = 293f;
			}
			MHBAIEKFBIJ().SetFloat("_TimeX", HBJJOCHGOPH);
			EGOGECOEONM().SetFloat("_Value", CenterX);
			MLMKCOINOOH().SetFloat("_ScreenResolution", CenterY);
			MFHPKGICPIO().SetFloat("' got destroyed by engine. This is OK when loading levels. Otherwise use: PhotonNetwork.Destroy().", Distortion);
			MNLKBFFKHIE().SetFloat("value", Size);
			EPCGJFCCAFH().SetVector("CameraFilterPack_Sweater", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material FEAEGGCNIAA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)101;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material EBJKJPAIAAM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void PKLOBJHKFEO()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1736f)
			{
				HBJJOCHGOPH = 228f;
			}
			KEMJNOMIPHN().SetFloat("achievements.id", HBJJOCHGOPH);
			ILKALHDJBFE().SetFloat(".icon", CenterX);
			MNLKBFFKHIE().SetFloat("player.licenceaccepted", CenterY);
			IONHGBPGCHK().SetFloat("\"\"", Distortion);
			ILKALHDJBFE().SetFloat("The shader ", Size);
			EMDFHOKEGNG().SetVector("Joystick1Button0", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Distortion_Twist");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LBAJLLFMMMP()
	{
		SCShader = Shader.Find("_Value5");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FJHFOBHJEHL()
	{
	}

	[SpecialName]
	private Material IIJMIPBMMBF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1912f)
			{
				HBJJOCHGOPH = 1721f;
			}
			IONHGBPGCHK().SetFloat("float,1", HBJJOCHGOPH);
			PEIMCBBHLBJ().SetFloat("_Distortion", CenterX);
			OGMEGHKECAH().SetFloat("BlockCount", CenterY);
			FKEOGPDLBDD().SetFloat("_Val2", Distortion);
			FEAEGGCNIAA().SetFloat(":", Size);
			NLFJGMBCICG().SetVector("_TintColor", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FOMNCPKKCFN()
	{
	}

	private void CFFCLAHMBAA()
	{
		SCShader = Shader.Find("settings.gamemessagesduration");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GCHBGCGBMCK()
	{
	}

	private void LKBOEPPBLIF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 769f)
			{
				HBJJOCHGOPH = 60f;
			}
			DOMEEFLPEPJ().SetFloat("Set Satellite Color", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat(".lastCheckpoint.longestComboScore", CenterX);
			MNLKBFFKHIE().SetFloat("RecieveChatMessage", CenterY);
			PEIMCBBHLBJ().SetFloat("Tab1Content", Distortion);
			GJHLADDCMFF().SetFloat("CameraFilterPack/TV_Horror", Size);
			ACHNOHCLGOO().SetVector("x", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BKIGIIINEDH()
	{
		SCShader = Shader.Find("_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CEDFFAOOPOG()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material ADAFMBOGPLN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)107;
		}
		return BJFKDHHMLJH;
	}

	private void FEGJMDDIDIC()
	{
		SCShader = Shader.Find("[RanksSystem] Ranks updated. Next update: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1056f)
			{
				HBJJOCHGOPH = 1617f;
			}
			HCGJCMDJPGD().SetFloat("_MainTex2", HBJJOCHGOPH);
			PEIMCBBHLBJ().SetFloat("CameraFilterPack/Lut_Simple", CenterX);
			DOMEEFLPEPJ().SetFloat("ItemsCountText", CenterY);
			MLMKCOINOOH().SetFloat("[", Distortion);
			ACHNOHCLGOO().SetFloat("JoinOrCreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", Size);
			DOMEEFLPEPJ().SetVector("CameraFilterPack/Blend2Camera_Lighten", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PEIMCBBHLBJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1072f)
			{
				HBJJOCHGOPH = 421f;
			}
			HCGJCMDJPGD().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			EMDFHOKEGNG().SetFloat("[SaveSystem] Outdated savefile found", CenterX);
			FEAEGGCNIAA().SetFloat("float,2", CenterY);
			LELKBCALFCF().SetFloat("menu.enableselectormusic", Distortion);
			KAFBNOBOIAJ().SetFloat("CameraFilterPack/FX_DigitalMatrixDistortion", Size);
			HCGJCMDJPGD().SetVector(",", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LELKBCALFCF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void DOKAKEMDALN()
	{
		SCShader = Shader.Find("2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EGEPLFGKGLI()
	{
		SCShader = Shader.Find("st");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HLHJBJGEEEA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MABCDJDPGNA()
	{
		SCShader = Shader.Find("#mapalreadyexistupdate");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CFIAKIJAILI()
	{
	}

	private void Update()
	{
	}

	[SpecialName]
	private Material ILKALHDJBFE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1546f)
			{
				HBJJOCHGOPH = 1618f;
			}
			GBFOAHKAJEK().SetFloat("Bad parameters for reset! Use \"reset <challengeid>\"", HBJJOCHGOPH);
			FEAEGGCNIAA().SetFloat(" ownership transfered to: ", CenterX);
			IONHGBPGCHK().SetFloat("#C8C8C8FF", CenterY);
			MNLKBFFKHIE().SetFloat("inventory.selected.", Distortion);
			DBOLLHHMKKN().SetFloat("maps.", Size);
			MHBAIEKFBIJ().SetVector("The process failed: ", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ILKALHDJBFE());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material EGOGECOEONM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
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
			NBPKMLMCHFN.SetFloat("_TimeX", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_CenterX", CenterX);
			NBPKMLMCHFN.SetFloat("_CenterY", CenterY);
			NBPKMLMCHFN.SetFloat("_Distortion", Distortion);
			NBPKMLMCHFN.SetFloat("_Size", Size);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EHCGBJDFMHG()
	{
	}

	[SpecialName]
	private Material HJGEHJDMCGI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-116);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material ACHNOHCLGOO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)85;
		}
		return BJFKDHHMLJH;
	}

	private void LEAHIBJDMBI()
	{
	}

	private void CNPINCHINJA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IMCKJCHKMKB()
	{
		SCShader = Shader.Find("Image");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 598f)
			{
				HBJJOCHGOPH = 1189f;
			}
			OGMEGHKECAH().SetFloat("id", HBJJOCHGOPH);
			HJGEHJDMCGI().SetFloat("kick", CenterX);
			MHBAIEKFBIJ().SetFloat("DPADVER", CenterY);
			KAFBNOBOIAJ().SetFloat("IEnumerable", Distortion);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Blend2Camera_LinearDodge", Size);
			NFKFAAHHLLM().SetVector("settings.volume.game", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOMEEFLPEPJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KOJKBFDNGDK()
	{
		SCShader = Shader.Find("/");
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
			if (HBJJOCHGOPH > 313f)
			{
				HBJJOCHGOPH = 305f;
			}
			MFHPKGICPIO().SetFloat("LevelURLInputField", HBJJOCHGOPH);
			OKJOKHGJHGF().SetFloat("DPADVER", CenterX);
			KAFBNOBOIAJ().SetFloat("_FadeFromBinary", CenterY);
			KEMJNOMIPHN().SetFloat("_Value2", Distortion);
			ADAFMBOGPLN().SetFloat("_Glitch", Size);
			OGMEGHKECAH().SetVector("RecieveChatActionMessage", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MHBAIEKFBIJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KNBJBNDGCIJ()
	{
		SCShader = Shader.Find("st");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OIKAPFGPLML(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1847f)
			{
				HBJJOCHGOPH = 556f;
			}
			NLFJGMBCICG().SetFloat("_Blue_C", HBJJOCHGOPH);
			GJHLADDCMFF().SetFloat("_TimeX", CenterX);
			NFKFAAHHLLM().SetFloat("/files/editor_manual.pdf", CenterY);
			FEAEGGCNIAA().SetFloat("#scoresubmitionfailed: ", Distortion);
			IONHGBPGCHK().SetFloat("_FarCamera", Size);
			EBJKJPAIAAM().SetVector("player.arrow", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MHBAIEKFBIJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void APKNAPHOFHC()
	{
	}

	[SpecialName]
	private Material NFKFAAHHLLM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material PEIMCBBHLBJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)124;
		}
		return BJFKDHHMLJH;
	}

	private void ODLMOJDBPPG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EAHCLIEEJOG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IKMELABKBHO()
	{
	}

	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 130f)
			{
				HBJJOCHGOPH = 1233f;
			}
			FEAEGGCNIAA().SetFloat("_MainTex2", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value", CenterX);
			EGOGECOEONM().SetFloat("quit", CenterY);
			OKJOKHGJHGF().SetFloat("_ScreenResolution", Distortion);
			LENEJAGLCNL().SetFloat("_FixDistance", Size);
			NFKFAAHHLLM().SetVector("Player Disconnected", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GBFOAHKAJEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DHLCNIINMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1269f)
			{
				HBJJOCHGOPH = 1040f;
			}
			IIJMIPBMMBF().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			LELKBCALFCF().SetFloat("https://steamcommunity.com/sharedfiles/filedetails/?id=", CenterX);
			NFKFAAHHLLM().SetFloat("_ColorRGB", CenterY);
			LENEJAGLCNL().SetFloat("_CenterX", Distortion);
			FEAEGGCNIAA().SetFloat("CameraFilterPack/FX_8bits", Size);
			EPCGJFCCAFH().SetVector("Needs to be attached to the Event System component in the scene", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EBJKJPAIAAM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material EMDFHOKEGNG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-89);
		}
		return BJFKDHHMLJH;
	}

	private void ELKELFCGMPE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material MHBAIEKFBIJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1746f)
			{
				HBJJOCHGOPH = 1144f;
			}
			KEMJNOMIPHN().SetFloat("_SizeY", HBJJOCHGOPH);
			ILKALHDJBFE().SetFloat("_Value2", CenterX);
			PEIMCBBHLBJ().SetFloat("[MapEditor] Loading events...", CenterY);
			KAFBNOBOIAJ().SetFloat("_MainTex2", Distortion);
			EGOGECOEONM().SetFloat("_Value2", Size);
			NLFJGMBCICG().SetVector("z", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MNLKBFFKHIE());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)107;
		}
		return BJFKDHHMLJH;
	}

	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1913f)
			{
				HBJJOCHGOPH = 677f;
			}
			GBFOAHKAJEK().SetFloat("\n\n#", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat("_Value4", CenterX);
			EPCGJFCCAFH().SetFloat("_Lift", CenterY);
			EMDFHOKEGNG().SetFloat("Outdated version. Please restart the game to get lastest updates.", Distortion);
			ACHNOHCLGOO().SetFloat("Horizontal", Size);
			NLFJGMBCICG().SetVector("[ItemsHandler] Inventory not changed", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
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
			if (HBJJOCHGOPH > 1084f)
			{
				HBJJOCHGOPH = 1880f;
			}
			OGMEGHKECAH().SetFloat("GlassesColor2", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("MenuRecordButton", CenterX);
			OGMEGHKECAH().SetFloat("_Value5", CenterY);
			OKJOKHGJHGF().SetFloat("ConfigVersionSlider", Distortion);
			EMDFHOKEGNG().SetFloat("ping: {6}[+/-{7}]ms resent:{8} \n\nmax ms between\nsend: {0,4} \ndispatch: {1,4} \n\nlongest dispatch for: \nev({3}):{2,3}ms \nop({5}):{4,3}ms", Size);
			IONHGBPGCHK().SetVector("note.1", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LENEJAGLCNL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-96);
		}
		return BJFKDHHMLJH;
	}

	private void BGDONBMDPGM()
	{
	}

	private void KKLMPKLKAEM()
	{
	}

	private void IHAMJLJFFLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 413f)
			{
				HBJJOCHGOPH = 280f;
			}
			ACHNOHCLGOO().SetFloat("Connect() failed. Can't connect while disconnecting (still). Current state: ", HBJJOCHGOPH);
			ILKALHDJBFE().SetFloat("maps.", CenterX);
			OKJOKHGJHGF().SetFloat("_ScreenResolution", CenterY);
			FKEOGPDLBDD().SetFloat("[MapEditor] Loaded music file: ", Distortion);
			ADAFMBOGPLN().SetFloat("challenges.", Size);
			ILKALHDJBFE().SetVector("value", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GBFOAHKAJEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material MNLKBFFKHIE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-89);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material EPCGJFCCAFH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void JGMEKCFHGLE()
	{
	}

	private void IHHNCCOGLPN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JIAAFKOPEKO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1621f)
			{
				HBJJOCHGOPH = 476f;
			}
			GBFOAHKAJEK().SetFloat("Trackpad", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("_Value2", CenterX);
			EPCGJFCCAFH().SetFloat("_Value2", CenterY);
			EBJKJPAIAAM().SetFloat("CameraFilterPack/Blend2Camera_Multiply", Distortion);
			FEAEGGCNIAA().SetFloat("#no", Size);
			IIJMIPBMMBF().SetVector("InstantiateRpc", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MHBAIEKFBIJ());
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

	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 561f)
			{
				HBJJOCHGOPH = 190f;
			}
			ACHNOHCLGOO().SetFloat("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", HBJJOCHGOPH);
			DOMEEFLPEPJ().SetFloat("Oct", CenterX);
			EPCGJFCCAFH().SetFloat("[Right]", CenterY);
			FKEOGPDLBDD().SetFloat("player.xp", Distortion);
			HCGJCMDJPGD().SetFloat("visible", Size);
			HJGEHJDMCGI().SetVector("FToA", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PJGFBHOKMIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FGNFILLNPJK()
	{
	}

	private void IGPCNCJIEOJ()
	{
		SCShader = Shader.Find("RarityImage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OKLAJINHPAN()
	{
		SCShader = Shader.Find("Drop_Floor_Fluid");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LBIOIEANMGI()
	{
	}
}
