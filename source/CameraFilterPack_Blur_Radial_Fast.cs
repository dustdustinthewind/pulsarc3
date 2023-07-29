// CameraFilterPack_Blur_Radial_Fast
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Blur/Radial_Fast")]
[ExecuteInEditMode]
public class CameraFilterPack_Blur_Radial_Fast : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(-0.5f, 0.5f)]
	public float Intensity = 0.125f;

	[Range(-2f, 2f)]
	public float MovX = 0.5f;

	[Range(-2f, 2f)]
	public float MovY = 0.5f;

	[Range(0f, 10f)]
	private float KJIKOEIAENF = 1f;

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

	[SpecialName]
	private Material HCGJCMDJPGD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)79;
		}
		return BJFKDHHMLJH;
	}

	private void ILCFPCIPENO()
	{
		SCShader = Shader.Find("#");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1953f)
			{
				HBJJOCHGOPH = 820f;
			}
			HKIMAANBGMJ().SetFloat("Tab1Content", HBJJOCHGOPH);
			LELKBCALFCF().SetFloat("file://", Intensity);
			KBOPGONOCNP().SetFloat(".lastCheckpoint.bgcolor", MovX);
			HCGJCMDJPGD().SetFloat("Operation ", MovY);
			HCGJCMDJPGD().SetFloat("_Parameter", KJIKOEIAENF);
			BAGICADFBAB().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1182f, 277f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AEDDNDHCLNN()
	{
		SCShader = Shader.Find("Cannot remove cached RPCs on a PhotonView thats not ours! ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void FBPHNEJBDJN()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ANKIJGCGCBF()
	{
	}

	private void JNGMIAFLBDL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ICILLMAKLMI()
	{
		SCShader = Shader.Find("_GlowColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HNMIAKKBMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1695f)
			{
				HBJJOCHGOPH = 405f;
			}
			NFMGLIKNOOC().SetFloat("value", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("custom", Intensity);
			BFGNMFCNDBC().SetFloat(" | Level: ", MovX);
			HKIMAANBGMJ().SetFloat("CameraFilterPack/Noise_TV_2", MovY);
			LELKBCALFCF().SetFloat("RequestSelectedLevel", KJIKOEIAENF);
			BFGNMFCNDBC().SetVector("a year ago", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 394f, 1967f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IGPCNCJIEOJ()
	{
		SCShader = Shader.Find("FileMenu");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FGOPJMGNHGO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PKGJJFIFLII()
	{
	}

	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 637f)
			{
				HBJJOCHGOPH = 1310f;
			}
			OIIDAKBILMI().SetFloat("Network destroy Instantiated GO: ", HBJJOCHGOPH);
			OHKGGPFGLFD().SetFloat("StandAloneInputSystem should not be used with the GamePadInputModule, please remove it from the Event System in this scene or disable it when this module is in use", Intensity);
			HKIMAANBGMJ().SetFloat("ShineEffect", MovX);
			KBOPGONOCNP().SetFloat("SetSunSensitivity", MovY);
			HKIMAANBGMJ().SetFloat("AudioSampler", KJIKOEIAENF);
			OIIDAKBILMI().SetVector("IconImage", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1180f, 1892f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OEIBFOHPOPD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 519f)
			{
				HBJJOCHGOPH = 699f;
			}
			OCHJIMJNEMO().SetFloat("[LevelEditorScene] Print Audio Wave: Start", HBJJOCHGOPH);
			OIIDAKBILMI().SetFloat("float,2", Intensity);
			NFMGLIKNOOC().SetFloat("B", MovX);
			EOCCJGIGEGJ().SetFloat("_Parameter", MovY);
			LELKBCALFCF().SetFloat("' was created: ", KJIKOEIAENF);
			INOBFNCKFGK().SetVector("#status", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1396f, 648f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1873f)
			{
				HBJJOCHGOPH = 1770f;
			}
			IONHGBPGCHK().SetFloat("CameraFilterPack/Blend2Camera_Exclusion", HBJJOCHGOPH);
			MJJIEHANFJA().SetFloat("[LevelEditorScene] Error: You're not logged into Steam!", Intensity);
			AELJLBOJAIL().SetFloat("{0,-18} {1,18}", MovX);
			IONHGBPGCHK().SetFloat(". The RPC has been ignored.", MovY);
			AELJLBOJAIL().SetFloat("Up", KJIKOEIAENF);
			BFGNMFCNDBC().SetVector("#turnoninternet", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1888f, 1694f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOMEEFLPEPJ());
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
			if (HBJJOCHGOPH > 1789f)
			{
				HBJJOCHGOPH = 183f;
			}
			AELJLBOJAIL().SetFloat("_VelTex", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("shader.frost", Intensity);
			MICHFGAOPKM().SetFloat("itemdefid[0]", MovX);
			FGENHBKMPDA().SetFloat("CameraFilterPack/TV_Rgb", MovY);
			MICHFGAOPKM().SetFloat("id", KJIKOEIAENF);
			NBPKMLMCHFN.SetVector("RemoveEnvironmentObject", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1309f, 330f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 541f)
			{
				HBJJOCHGOPH = 187f;
			}
			HKIMAANBGMJ().SetFloat("RecordButton", HBJJOCHGOPH);
			EFMCNLELMDO().SetFloat("Beat Detected", Intensity);
			NBPKMLMCHFN.SetFloat(":", MovX);
			KHCLIAMBBNC().SetFloat("CameraFilterPack/EXTRA_SHOWFPS", MovY);
			BAGICADFBAB().SetFloat("player.gamecompleted", KJIKOEIAENF);
			KBOPGONOCNP().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1252f, 166f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFMCNLELMDO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FMFNILJIEIA()
	{
		SCShader = Shader.Find("The authentication ticket expired. You need to connect (and authenticate) again. Disconnecting.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HEBOIFKBLGD()
	{
	}

	private void LINKAMEPKGM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JOACBIEHHCE()
	{
	}

	[SpecialName]
	private Material INOBFNCKFGK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void HPNNCNNFMGK()
	{
	}

	private void COOHIILCOCO()
	{
		SCShader = Shader.Find("Instantiating: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HHKBBEFJEBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 799f)
			{
				HBJJOCHGOPH = 1501f;
			}
			DOMEEFLPEPJ().SetFloat("Failed!", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("[UI] ", Intensity);
			HCGJCMDJPGD().SetFloat("_Color_G", MovX);
			LELKBCALFCF().SetFloat("LoadMapCanvas", MovY);
			EOCCJGIGEGJ().SetFloat("_TimeX", KJIKOEIAENF);
			NFMGLIKNOOC().SetVector("plainText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 932f, 188f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
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
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void NNFMIAFHMJM()
	{
		SCShader = Shader.Find("CameraFilterPack/Gradients_Hue");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material LELKBCALFCF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void COIJKMKIEAK()
	{
		SCShader = Shader.Find("LevelInfoInputField");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OIBMHPIFAKK()
	{
	}

	private void ODAIMOJLJOF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material BFGNMFCNDBC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.HideAndDontSave;
		}
		return BJFKDHHMLJH;
	}

	private void DKPBBJINKMG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CEDFFAOOPOG()
	{
		SCShader = Shader.Find("GenerationMenu");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material NFMGLIKNOOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
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

	private void BGFJOEPFOPM()
	{
	}

	private void EDPDMBFLHLP()
	{
		SCShader = Shader.Find("Inside cells:\n");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CPAJLKHMOJB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JLNNHKPHMAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 199f)
			{
				HBJJOCHGOPH = 114f;
			}
			KHCLIAMBBNC().SetFloat("_ForceYSwap", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("_TimeX", Intensity);
			DOMEEFLPEPJ().SetFloat("z", MovX);
			BAGICADFBAB().SetFloat("CameraFilterPack/Pixelisation_OilPaintHQ", MovY);
			OHKGGPFGLFD().SetFloat("_Value3", KJIKOEIAENF);
			MICHFGAOPKM().SetVector(" registered.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 595f, 1111f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BAGICADFBAB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HLIAEEMGBHN()
	{
		SCShader = Shader.Find("_VignettingDirt");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FDPOFMCFBMF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KOJKBFDNGDK()
	{
		SCShader = Shader.Find("CameraFilterPack_Blizzard1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LLKKGGLNIDF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MKOMIDCPCDC()
	{
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material BAGICADFBAB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)97;
		}
		return BJFKDHHMLJH;
	}

	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1643f)
			{
				HBJJOCHGOPH = 948f;
			}
			LELKBCALFCF().SetFloat("_MatrixSize", HBJJOCHGOPH);
			OIIDAKBILMI().SetFloat("_ScreenResolution", Intensity);
			HKIMAANBGMJ().SetFloat("FrostCanvas", MovX);
			DOMEEFLPEPJ().SetFloat("_Value3", MovY);
			LELKBCALFCF().SetFloat("#000000CC", KJIKOEIAENF);
			FGENHBKMPDA().SetVector(" from: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 551f, 147f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 389f)
			{
				HBJJOCHGOPH = 1927f;
			}
			BFGNMFCNDBC().SetFloat("CompletedLevel", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("_Blend", Intensity);
			HKIMAANBGMJ().SetFloat("cancel", MovX);
			MJJIEHANFJA().SetFloat("CheckpointsScoreText", MovY);
			MICHFGAOPKM().SetFloat("UseScanLineSize", KJIKOEIAENF);
			OCHJIMJNEMO().SetVector("Environment/SunBase_", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 593f, 291f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AIBNKIDADPI()
	{
		SCShader = Shader.Find("_Val");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PKBENONAOOL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GNPDGBNDCPL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Blur_Radial_Fast");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1300f)
			{
				HBJJOCHGOPH = 1711f;
			}
			NBPKMLMCHFN.SetFloat("_ScreenResolution", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("_ScreenResolution", Intensity);
			KHCLIAMBBNC().SetFloat("Items", MovX);
			MJJIEHANFJA().SetFloat("<b>#", MovY);
			BFGNMFCNDBC().SetFloat("GlassDistortion", KJIKOEIAENF);
			EOCCJGIGEGJ().SetVector("_Offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1057f, 1239f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OBAEDJJDCPN()
	{
	}

	[SpecialName]
	private Material MICHFGAOPKM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-105);
		}
		return BJFKDHHMLJH;
	}

	private void EHCGBJDFMHG()
	{
	}

	private void JOONHGHGKKF()
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
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

	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 684f)
			{
				HBJJOCHGOPH = 478f;
			}
			OIIDAKBILMI().SetFloat("ready", HBJJOCHGOPH);
			OCHJIMJNEMO().SetFloat("_Offsets", Intensity);
			KBOPGONOCNP().SetFloat("CameraFilterPack/Vision_Plasma", MovX);
			OCHJIMJNEMO().SetFloat("settings_bindings_controller_type", MovY);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Drawing_Toon", KJIKOEIAENF);
			HCGJCMDJPGD().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1498f, 1754f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GMELGGJOPBB()
	{
	}

	[SpecialName]
	private Material EOCCJGIGEGJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1786f)
			{
				HBJJOCHGOPH = 508f;
			}
			NFMGLIKNOOC().SetFloat("OK", HBJJOCHGOPH);
			BAGICADFBAB().SetFloat("stats on", Intensity);
			INOBFNCKFGK().SetFloat("https://bugs.khb-soft.ru/set_project.php?project_id=1", MovX);
			EOCCJGIGEGJ().SetFloat("_Value9", MovY);
			BAGICADFBAB().SetFloat(".lastCheckpoint.lives", KJIKOEIAENF);
			BFGNMFCNDBC().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 647f, 101f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material OCHJIMJNEMO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-70);
		}
		return BJFKDHHMLJH;
	}

	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 683f)
			{
				HBJJOCHGOPH = 414f;
			}
			HCGJCMDJPGD().SetFloat("received</b>\n#reason: ", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("CameraFilterPack/TV_Horror", Intensity);
			KBOPGONOCNP().SetFloat("EnableRankingToggle", MovX);
			KBOPGONOCNP().SetFloat("player.goldlollipop", MovY);
			KHCLIAMBBNC().SetFloat("/", KJIKOEIAENF);
			AELJLBOJAIL().SetVector("InventoryGrid", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 178f, 1150f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, INOBFNCKFGK());
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
			if (HBJJOCHGOPH > 322f)
			{
				HBJJOCHGOPH = 696f;
			}
			HKIMAANBGMJ().SetFloat("bans.viewed.", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat(" ownership transfered to: ", Intensity);
			EFMCNLELMDO().SetFloat("GetGameList failed: ", MovX);
			FGENHBKMPDA().SetFloat("_ScreenResolution", MovY);
			LELKBCALFCF().SetFloat("_Distortion", KJIKOEIAENF);
			MICHFGAOPKM().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1071f, 804f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IEFMONDKKJN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BMNOHLNANIP()
	{
	}

	private void HIKKPDACJGI()
	{
	}

	private void LBPCODPOJAH()
	{
	}

	private void AEIJFLJEABG()
	{
	}

	[SpecialName]
	private Material CECJJMKLEAK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void GLEJGFLCLPJ()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material OHKGGPFGLFD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-65);
		}
		return BJFKDHHMLJH;
	}

	private void OCMKCBBCEFG()
	{
	}

	private void FLKEJJEGCFA()
	{
		SCShader = Shader.Find("Fade");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MGFFNGEGFDC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 487f)
			{
				HBJJOCHGOPH = 1311f;
			}
			MICHFGAOPKM().SetFloat("stretchWidth", HBJJOCHGOPH);
			MJJIEHANFJA().SetFloat(".lastCheckpoint.powerupsScore", Intensity);
			KBOPGONOCNP().SetFloat("_BlurRadius4", MovX);
			MICHFGAOPKM().SetFloat("CheckpointsScoreText", MovY);
			AELJLBOJAIL().SetFloat("_Amount", KJIKOEIAENF);
			NBPKMLMCHFN.SetVector("_Value4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 955f, 783f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KNBJBNDGCIJ()
	{
		SCShader = Shader.Find("CompletedLevel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 670f)
			{
				HBJJOCHGOPH = 730f;
			}
			EOCCJGIGEGJ().SetFloat("Down ", HBJJOCHGOPH);
			OCHJIMJNEMO().SetFloat("original.tutorial", Intensity);
			KHCLIAMBBNC().SetFloat("_TraceBehindObjects", MovX);
			HCGJCMDJPGD().SetFloat("PlayButton", MovY);
			MJJIEHANFJA().SetFloat("#reward: ", KJIKOEIAENF);
			BAGICADFBAB().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 740f, 1931f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CECJJMKLEAK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1194f)
			{
				HBJJOCHGOPH = 1343f;
			}
			MICHFGAOPKM().SetFloat("_RampTex", HBJJOCHGOPH);
			DOMEEFLPEPJ().SetFloat("_FadeFromBinary", Intensity);
			MJJIEHANFJA().SetFloat("The given 2D texture ", MovX);
			OCHJIMJNEMO().SetFloat("_Near", MovY);
			EFMCNLELMDO().SetFloat(" - Contains ", KJIKOEIAENF);
			MJJIEHANFJA().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 62f, 1943f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material MJJIEHANFJA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)69;
		}
		return BJFKDHHMLJH;
	}

	private void FABMDEHEDNO()
	{
	}

	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1331f)
			{
				HBJJOCHGOPH = 368f;
			}
			HKIMAANBGMJ().SetFloat("1234332714", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("english", Intensity);
			NBPKMLMCHFN.SetFloat("_Color", MovX);
			OIIDAKBILMI().SetFloat("_SizeY", MovY);
			OCHJIMJNEMO().SetFloat("[Down-Left]", KJIKOEIAENF);
			LELKBCALFCF().SetVector(".mp3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1840f, 339f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LELKBCALFCF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material KHCLIAMBBNC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 0f)
			{
				HBJJOCHGOPH = 474f;
			}
			OIIDAKBILMI().SetFloat("_ColorBuffer", HBJJOCHGOPH);
			INOBFNCKFGK().SetFloat("float,10", Intensity);
			BAGICADFBAB().SetFloat("ConfigVersionSlider", MovX);
			OIIDAKBILMI().SetFloat("_SpawnHeuristic", MovY);
			LELKBCALFCF().SetFloat("#savemapbeforeuploading", KJIKOEIAENF);
			HKIMAANBGMJ().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1603f, 926f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LBAJLLFMMMP()
	{
		SCShader = Shader.Find("[LevelEditorScene] Print Audio Wave: Start");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material FGENHBKMPDA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideAndDontSave;
		}
		return BJFKDHHMLJH;
	}

	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1960f)
			{
				HBJJOCHGOPH = 687f;
			}
			EFMCNLELMDO().SetFloat("_AdaptationMin", HBJJOCHGOPH);
			INOBFNCKFGK().SetFloat("#", Intensity);
			MJJIEHANFJA().SetFloat("_Axis", MovX);
			AELJLBOJAIL().SetFloat("return CheckCondition()", MovY);
			LELKBCALFCF().SetFloat("true", KJIKOEIAENF);
			OCHJIMJNEMO().SetVector("offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 617f, 352f));
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
			if (HBJJOCHGOPH > 1769f)
			{
				HBJJOCHGOPH = 1854f;
			}
			MJJIEHANFJA().SetFloat("_ChangeGreen", HBJJOCHGOPH);
			MJJIEHANFJA().SetFloat(".completedMaps", Intensity);
			DOMEEFLPEPJ().SetFloat(" or player:", MovX);
			INOBFNCKFGK().SetFloat(" - PUBLISHED #", MovY);
			KBOPGONOCNP().SetFloat("skin.hit_normal", KJIKOEIAENF);
			LELKBCALFCF().SetVector("RoomNameText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1190f, 255f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOMEEFLPEPJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NDAJBJFJGCF()
	{
	}

	[SpecialName]
	private Material EFMCNLELMDO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)79;
		}
		return BJFKDHHMLJH;
	}

	private void HAHJJPLPOKB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JILOMOBDPIA()
	{
		SCShader = Shader.Find("#000000CC");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JHPOIOELNCG()
	{
	}

	private void FHPFJBFCOOF()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IHLMNAGPKDA()
	{
		SCShader = Shader.Find("mapselector.orderby");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ADPLHDFJFID()
	{
		SCShader = Shader.Find("_Red_B");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ONKDMMJPEMN()
	{
	}

	[SpecialName]
	private Material AELJLBOJAIL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)100;
		}
		return BJFKDHHMLJH;
	}

	private void JHANGPCOCIG()
	{
		SCShader = Shader.Find("mapselector.filter.favoriteonly");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CEAGPJBGBMH()
	{
		SCShader = Shader.Find(". Check if the server is available.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DOKAKEMDALN()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MEBPBNLBECA()
	{
		SCShader = Shader.Find("z");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void Update()
	{
	}

	private void GPHPJIDGEPI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IENKPJEBMFM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GCDLIKEDMCF()
	{
	}

	private void FDNONDCGGCG()
	{
		SCShader = Shader.Find("SpawnObj");
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
			NBPKMLMCHFN.SetFloat("_Value", Intensity);
			NBPKMLMCHFN.SetFloat("_Value2", MovX);
			NBPKMLMCHFN.SetFloat("_Value3", MovY);
			NBPKMLMCHFN.SetFloat("_Value4", KJIKOEIAENF);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
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

	private void NJBMCJOOMMP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1088f)
			{
				HBJJOCHGOPH = 287f;
			}
			AELJLBOJAIL().SetFloat(" ", HBJJOCHGOPH);
			KHCLIAMBBNC().SetFloat("_ScreenResolution", Intensity);
			OHKGGPFGLFD().SetFloat("_Value3", MovX);
			MICHFGAOPKM().SetFloat("_Value2", MovY);
			OIIDAKBILMI().SetFloat("_MatrixSpeed", KJIKOEIAENF);
			BAGICADFBAB().SetVector("workshop.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1371f, 725f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
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

	private void FKEJGBFDCAH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 143f)
			{
				HBJJOCHGOPH = 1148f;
			}
			HCGJCMDJPGD().SetFloat("finished", HBJJOCHGOPH);
			BAGICADFBAB().SetFloat("TransferOwnership() view ", Intensity);
			EFMCNLELMDO().SetFloat("Coord", MovX);
			NFMGLIKNOOC().SetFloat("CameraFilterPack/Blend2Camera_GreenScreen", MovY);
			BAGICADFBAB().SetFloat("Protocol switch from: ", KJIKOEIAENF);
			NBPKMLMCHFN.SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 196f, 529f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HCDBNAKGDJC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 692f)
			{
				HBJJOCHGOPH = 634f;
			}
			BFGNMFCNDBC().SetFloat("_TimeX", HBJJOCHGOPH);
			OCHJIMJNEMO().SetFloat("_TreatBackfaceHitAsMiss", Intensity);
			MICHFGAOPKM().SetFloat("_Distortion", MovX);
			AELJLBOJAIL().SetFloat("[ResourcesManager] Load audio error: ", MovY);
			MJJIEHANFJA().SetFloat("_InvScreenSize", KJIKOEIAENF);
			BFGNMFCNDBC().SetVector("Mouse2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1390f, 1620f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)104;
		}
		return BJFKDHHMLJH;
	}

	private void MGMAOBPPOBJ()
	{
		SCShader = Shader.Find("Please specify a map name or buildID");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CFIAKIJAILI()
	{
	}

	private void LBPHCAMMAPB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PNNPDMHLFHE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1783f)
			{
				HBJJOCHGOPH = 546f;
			}
			CECJJMKLEAK().SetFloat("_Value4", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("#yes", Intensity);
			CECJJMKLEAK().SetFloat("achievements.21.progress", MovX);
			HCGJCMDJPGD().SetFloat("https://twitch.tv/intralism", MovY);
			NFMGLIKNOOC().SetFloat("Error: You're not logged into Steam!", KJIKOEIAENF);
			CECJJMKLEAK().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 948f, 775f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, INOBFNCKFGK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ONMGIPAILOH()
	{
	}

	private void KFACDBHDAOD()
	{
	}

	private void FBMDHDBELEK()
	{
	}

	private void CACCPBENDAP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 705f)
			{
				HBJJOCHGOPH = 259f;
			}
			DOMEEFLPEPJ().SetFloat("_BlurRadius4", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("MenuScene", Intensity);
			OHKGGPFGLFD().SetFloat("_ScreenResolution", MovX);
			OCHJIMJNEMO().SetFloat("UseFinalGlassColor", MovY);
			HCGJCMDJPGD().SetFloat("player.goldarc", KJIKOEIAENF);
			BAGICADFBAB().SetVector("failed", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1705f, 496f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AKHCOBHHGJP()
	{
		SCShader = Shader.Find("#alreadyexist");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
