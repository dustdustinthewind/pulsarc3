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
		SCShader = Shader.Find("Image effects aren't supported on this device ({0})");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NDBPCNICGLC()
	{
		SCShader = Shader.Find(".b");
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
		SCShader = Shader.Find("_ScreenResolution");
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
			KEMJNOMIPHN().SetFloat("offsets", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("SetPosition", CenterX);
			KAFBNOBOIAJ().SetFloat("HandleEventLeave for player ID: ", CenterY);
			KAFBNOBOIAJ().SetFloat("Texture2", Distortion);
			ACHNOHCLGOO().SetFloat("settings.selectormapsperpage", Size);
			MNLKBFFKHIE().SetVector("G:", new Vector2(Screen.width, Screen.height));
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
		SCShader = Shader.Find("Mouse Wheel Down");
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
			DBOLLHHMKKN().SetFloat("_Value4", HBJJOCHGOPH);
			MNLKBFFKHIE().SetFloat(": ", CenterX);
			OKJOKHGJHGF().SetFloat("CameraFilterPack_Atmosphere_Rain_FX", CenterY);
			IIJMIPBMMBF().SetFloat("/512px-512px.png", Distortion);
			FEAEGGCNIAA().SetFloat("menu.playedpage", Size);
			LENEJAGLCNL().SetVector("_TimeX", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOMEEFLPEPJ());
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
			OKJOKHGJHGF().SetFloat("_Value3", HBJJOCHGOPH);
			GBFOAHKAJEK().SetFloat("CameraFilterPack/3D_Inverse", CenterX);
			LENEJAGLCNL().SetFloat("_TimeX", CenterY);
			EMDFHOKEGNG().SetFloat("_DotSize", Distortion);
			MHBAIEKFBIJ().SetFloat("_FarCamera", Size);
			OGMEGHKECAH().SetVector("#close", new Vector2(Screen.width, Screen.height));
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
			ADAFMBOGPLN().SetFloat("Data/Skins/", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("'{0}'{1}{2}", CenterX);
			LELKBCALFCF().SetFloat("_ScreenEdgeFading", CenterY);
			LENEJAGLCNL().SetFloat("_Amount", Distortion);
			OGMEGHKECAH().SetFloat("CameraFilterPack/Blend2Camera_GreenScreen", Size);
			OKJOKHGJHGF().SetVector("_Value2", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HJGEHJDMCGI());
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
		SCShader = Shader.Find("_Distortion");
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
			EGOGECOEONM().SetFloat("Received RPC: ", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat("(master)", CenterX);
			HCGJCMDJPGD().SetFloat("Mouse2", CenterY);
			IIJMIPBMMBF().SetFloat("\n", Distortion);
			LENEJAGLCNL().SetFloat("RecieveChatActionMessage", Size);
			HCGJCMDJPGD().SetVector("Image", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
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
			ACHNOHCLGOO().SetFloat("BestScoreText", HBJJOCHGOPH);
			MNLKBFFKHIE().SetFloat("Fade", CenterX);
			GBFOAHKAJEK().SetFloat("_ScreenResolution", CenterY);
			FKEOGPDLBDD().SetFloat("Joystick1Button3", Distortion);
			MFHPKGICPIO().SetFloat("failed", Size);
			PEIMCBBHLBJ().SetVector("#pleasewait", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
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
		SCShader = Shader.Find(".workshop.json");
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
		SCShader = Shader.Find("[ItemsHandler] No connection to item server: ");
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
			KAFBNOBOIAJ().SetFloat("_Offsets", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat(" not exist", CenterX);
			EMDFHOKEGNG().SetFloat("_Parameter", CenterY);
			KEMJNOMIPHN().SetFloat(" beatThreshold: ", Distortion);
			HJGEHJDMCGI().SetFloat("[Up]", Size);
			MHBAIEKFBIJ().SetVector("/config", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHLADDCMFF());
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
			DBOLLHHMKKN().SetFloat("STICKRVER", HBJJOCHGOPH);
			PEIMCBBHLBJ().SetFloat("_ScreenResolution", CenterX);
			ADAFMBOGPLN().SetFloat("cipherText", CenterY);
			EPCGJFCCAFH().SetFloat("_TimeX", Distortion);
			EGOGECOEONM().SetFloat("[GameScene] Events count: ", Size);
			MNLKBFFKHIE().SetVector("_Red_G", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
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
		SCShader = Shader.Find("_Value");
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
			FEAEGGCNIAA().SetFloat("float,0", HBJJOCHGOPH);
			PEIMCBBHLBJ().SetFloat("id", CenterX);
			NBPKMLMCHFN.SetFloat("_NoisePerChannel", CenterY);
			MLMKCOINOOH().SetFloat("CameraFilterPack/Blend2Camera_ColorDodge", Distortion);
			NBPKMLMCHFN.SetFloat("COMPLETED", Size);
			MNLKBFFKHIE().SetVector("menuthemes", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
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
			ADAFMBOGPLN().SetFloat("Editor/", HBJJOCHGOPH);
			LELKBCALFCF().SetFloat("original.tutorial", CenterX);
			GJHLADDCMFF().SetFloat("#combo", CenterY);
			KEMJNOMIPHN().SetFloat("Needs to be attached to the Event System component in the scene", Distortion);
			NFKFAAHHLLM().SetFloat("_ScreenResolution", Size);
			MFHPKGICPIO().SetVector("settings.fps", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MNLKBFFKHIE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JOPCCCCHNLI()
	{
		SCShader = Shader.Find("Room: '{0}' {1},{2} {4}/{3} players.\ncustomProps: {5}");
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
		SCShader = Shader.Find("Fade");
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
		SCShader = Shader.Find("HandsCountSlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JILOMOBDPIA()
	{
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ECBILENEOOL()
	{
		SCShader = Shader.Find("Aimer Input Module is incompatible with the StandAloneInputSystem, please remove it from the Event System in this scene or disable it when this module is in use");
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
			ADAFMBOGPLN().SetFloat("_TimeX", HBJJOCHGOPH);
			ADAFMBOGPLN().SetFloat("OnStatusChanged: {0} current State: {1}", CenterX);
			KAFBNOBOIAJ().SetFloat("_MainTex2", CenterY);
			LELKBCALFCF().SetFloat("_MaxVelocity", Distortion);
			HCGJCMDJPGD().SetFloat(" not exist", Size);
			KEMJNOMIPHN().SetVector("Received RPC: ", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MDNHCLKNCLE()
	{
		SCShader = Shader.Find(" x ");
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
		SCShader = Shader.Find("#accuracy");
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
			MNLKBFFKHIE().SetFloat("/../", HBJJOCHGOPH);
			KEMJNOMIPHN().SetFloat("{0}", CenterX);
			OGMEGHKECAH().SetFloat("Vertical", CenterY);
			MHBAIEKFBIJ().SetFloat("CorrectHitsScoreText", Distortion);
			FEAEGGCNIAA().SetFloat("_Value4", Size);
			IONHGBPGCHK().SetVector("_ScreenResolution", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
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
		SCShader = Shader.Find("settings_bindings_controller_type");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NNCCPEBIAKH()
	{
		SCShader = Shader.Find("_Value3");
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
			DBOLLHHMKKN().SetFloat("CameraFilterPack/Blizzard", HBJJOCHGOPH);
			EBJKJPAIAAM().SetFloat("_MainTex2", CenterX);
			NBPKMLMCHFN.SetFloat("Malformed RPC; this should never occur. Content: ", CenterY);
			KAFBNOBOIAJ().SetFloat("LostLive", Distortion);
			EMDFHOKEGNG().SetFloat("stretchWidth", Size);
			NLFJGMBCICG().SetVector("_ScreenResolution", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GBFOAHKAJEK());
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
			OKJOKHGJHGF().SetFloat(" now: ", HBJJOCHGOPH);
			MNLKBFFKHIE().SetFloat("Done!", CenterX);
			FEAEGGCNIAA().SetFloat("_Value10", CenterY);
			OGMEGHKECAH().SetFloat("UseScanLineSize", Distortion);
			ADAFMBOGPLN().SetFloat("restrictions\n\n#until: ", Size);
			EBJKJPAIAAM().SetVector("_TimeX", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ILKALHDJBFE());
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
			ADAFMBOGPLN().SetFloat("_TimeX", HBJJOCHGOPH);
			HJGEHJDMCGI().SetFloat("_Value", CenterX);
			MFHPKGICPIO().SetFloat("_ScreenResolution", CenterY);
			OKJOKHGJHGF().SetFloat("Observed type is not serializable: ", Distortion);
			DBOLLHHMKKN().SetFloat("float,1.5", Size);
			NBPKMLMCHFN.SetVector("CameraFilterPack/Pixelisation_Sweater", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HJGEHJDMCGI());
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
			LELKBCALFCF().SetFloat("achievements.id", HBJJOCHGOPH);
			OKJOKHGJHGF().SetFloat("challenges.", CenterX);
			KEMJNOMIPHN().SetFloat("[LevelEditorScene] Error: I/O Failure! :(", CenterY);
			HJGEHJDMCGI().SetFloat("\"", Distortion);
			HCGJCMDJPGD().SetFloat(" is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package.", Size);
			MHBAIEKFBIJ().SetVector("X", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
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
		SCShader = Shader.Find("_ScreenResolution");
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
			NFKFAAHHLLM().SetFloat("float,1", HBJJOCHGOPH);
			ILKALHDJBFE().SetFloat("_Distortion", CenterX);
			FEAEGGCNIAA().SetFloat("[#clicktoacceptchallenge]", CenterY);
			MLMKCOINOOH().SetFloat("CameraFilterPack/Deep_OilPaintHQ", Distortion);
			ACHNOHCLGOO().SetFloat("EventData0DropDownList", Size);
			MLMKCOINOOH().SetVector("_Offsets", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOMEEFLPEPJ());
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
		SCShader = Shader.Find("ArcsDestroyDelaySlider");
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
			IONHGBPGCHK().SetFloat("Set Satellite Color", HBJJOCHGOPH);
			NFKFAAHHLLM().SetFloat(".lastCheckpoint.maxLongestCombo", CenterX);
			DBOLLHHMKKN().SetFloat("RecieveChatMessage", CenterY);
			EMDFHOKEGNG().SetFloat("Tab1Content", Distortion);
			EBJKJPAIAAM().SetFloat("_TimeX", Size);
			KEMJNOMIPHN().SetVector("w", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BKIGIIINEDH()
	{
		SCShader = Shader.Find("CameraFilterPack/TV_VHS");
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
		SCShader = Shader.Find(";");
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
			KEMJNOMIPHN().SetFloat("_MainTex2", HBJJOCHGOPH);
			LENEJAGLCNL().SetFloat("The given 2D texture ", CenterX);
			FEAEGGCNIAA().SetFloat("ItemNameText", CenterY);
			DBOLLHHMKKN().SetFloat("ticket", Distortion);
			OGMEGHKECAH().SetFloat("offline room", Size);
			ADAFMBOGPLN().SetVector("CameraFilterPack/Blend2Camera_Lighten", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADAFMBOGPLN());
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
			LENEJAGLCNL().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			MLMKCOINOOH().SetFloat("[SaveSystem] Outdated savefile found", CenterX);
			ILKALHDJBFE().SetFloat("Set satellite trail width", CenterY);
			NLFJGMBCICG().SetFloat("SfxVolumeSlider", Distortion);
			NFKFAAHHLLM().SetFloat("_TimeX", Size);
			IIJMIPBMMBF().SetVector("[Down]", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF());
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
		SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EGEPLFGKGLI()
	{
		SCShader = Shader.Find("elapsed: {0:0.000}");
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
		SCShader = Shader.Find("#creatingnewitem");
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
			EPCGJFCCAFH().SetFloat("MenuScene", HBJJOCHGOPH);
			EMDFHOKEGNG().SetFloat(" to: ", CenterX);
			MHBAIEKFBIJ().SetFloat("RecordButton", CenterY);
			HJGEHJDMCGI().SetFloat("inventory.selected.", Distortion);
			LELKBCALFCF().SetFloat(".highscore", Size);
			GJHLADDCMFF().SetVector("/Saved Games/", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LELKBCALFCF());
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
		SCShader = Shader.Find("GroupNameText");
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
			MFHPKGICPIO().SetFloat("kick", CenterX);
			EGOGECOEONM().SetFloat("DPADVER", CenterY);
			MLMKCOINOOH().SetFloat("PointerExit ", Distortion);
			KAFBNOBOIAJ().SetFloat("CameraFilterPack/Blend2Camera_LinearDodge", Size);
			MNLKBFFKHIE().SetVector("settings.volume.sfx", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
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
			HCGJCMDJPGD().SetFloat("LevelInfoInputField", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat("DPADHOR", CenterX);
			IIJMIPBMMBF().SetFloat("_FadeFromBinary", CenterY);
			PEIMCBBHLBJ().SetFloat("_ScreenResolution", Distortion);
			HJGEHJDMCGI().SetFloat("_ScreenResolution", Size);
			MHBAIEKFBIJ().SetVector("RecieveChatActionMessage", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EBJKJPAIAAM());
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
			OKJOKHGJHGF().SetFloat("_FadeFX", HBJJOCHGOPH);
			ADAFMBOGPLN().SetFloat("_TimeX", CenterX);
			DBOLLHHMKKN().SetFloat("\nCreated by Oxy949", CenterY);
			EPCGJFCCAFH().SetFloat("#tryagain", Distortion);
			MLMKCOINOOH().SetFloat("_FarCamera", Size);
			DOMEEFLPEPJ().SetVector("player.goldarc", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF());
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
			HJGEHJDMCGI().SetFloat("_MainTex2", HBJJOCHGOPH);
			GJHLADDCMFF().SetFloat("_Value2", CenterX);
			FEAEGGCNIAA().SetFloat("Closes the app", CenterY);
			ILKALHDJBFE().SetFloat("CameraFilterPack/TV_WideScreenHV", Distortion);
			EMDFHOKEGNG().SetFloat("_FixDistance", Size);
			ILKALHDJBFE().SetVector("masterSteamID", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
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
			EGOGECOEONM().SetFloat("_TimeX", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("#failed!", CenterX);
			NFKFAAHHLLM().SetFloat("_ColorRGB", CenterY);
			ADAFMBOGPLN().SetFloat("_CenterX", Distortion);
			FKEOGPDLBDD().SetFloat("_TimeX", Size);
			KAFBNOBOIAJ().SetVector("\n", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EMDFHOKEGNG());
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
			KAFBNOBOIAJ().SetFloat("_SizeY", HBJJOCHGOPH);
			LELKBCALFCF().SetFloat("_Value3", CenterX);
			EPCGJFCCAFH().SetFloat("[MapEditor] Prepairing map editor...", CenterY);
			ADAFMBOGPLN().SetFloat("_MainTex2", Distortion);
			ACHNOHCLGOO().SetFloat("_Value3", Size);
			IONHGBPGCHK().SetVector("y", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
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
			MNLKBFFKHIE().SetFloat("\n\n#", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("CameraFilterPack/TV_Video3D", CenterX);
			IONHGBPGCHK().SetFloat("_Gain", CenterY);
			ILKALHDJBFE().SetFloat("#restart", Distortion);
			MHBAIEKFBIJ().SetFloat("Vertical", Size);
			FKEOGPDLBDD().SetVector("[ItemsHandler] Inventory has changed", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
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
			IIJMIPBMMBF().SetFloat("GlassColor", HBJJOCHGOPH);
			LENEJAGLCNL().SetFloat("MenuRecordButton", CenterX);
			MLMKCOINOOH().SetFloat("_Value5", CenterY);
			PEIMCBBHLBJ().SetFloat("ConfigVersionSlider", Distortion);
			HJGEHJDMCGI().SetFloat("The number of objects sent via a PhotonStreamQueue has to be the same each frame", Size);
			EPCGJFCCAFH().SetVector("note.5", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
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
			GJHLADDCMFF().SetFloat("ns", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("maps.", CenterX);
			MNLKBFFKHIE().SetFloat("CameraFilterPack/FX_Dot_Circle", CenterY);
			NLFJGMBCICG().SetFloat("[MapEditor] Loaded music file: ", Distortion);
			HJGEHJDMCGI().SetFloat("PlayMapGoal", Size);
			LELKBCALFCF().SetVector("value", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHLADDCMFF());
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
			ADAFMBOGPLN().SetFloat("Joystick1Button0", HBJJOCHGOPH);
			KEMJNOMIPHN().SetFloat("_Value3", CenterX);
			ACHNOHCLGOO().SetFloat("_Value3", CenterY);
			FKEOGPDLBDD().SetFloat("CameraFilterPack/Blend2Camera_Multiply", Distortion);
			LENEJAGLCNL().SetFloat("MouseY", Size);
			DOMEEFLPEPJ().SetVector("Horizontal", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LELKBCALFCF());
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
			IIJMIPBMMBF().SetFloat("0,7,true,0", HBJJOCHGOPH);
			LELKBCALFCF().SetFloat("Dec", CenterX);
			NLFJGMBCICG().SetFloat("[Right]", CenterY);
			ACHNOHCLGOO().SetFloat("player.xp", Distortion);
			MHBAIEKFBIJ().SetFloat("closed", Size);
			MLMKCOINOOH().SetVector("No font defined. Found font: ", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
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
