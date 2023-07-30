// CameraFilterPack_Blur_Radial_Fast
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Blur/Radial_Fast")]
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
			HKIMAANBGMJ().SetFloat("LevelURLInputField", HBJJOCHGOPH);
			MJJIEHANFJA().SetFloat("[ResourcesManager] Load image error: ", Intensity);
			KHCLIAMBBNC().SetFloat(".sawoutdatedmessage", MovX);
			NFMGLIKNOOC().SetFloat("Operation ", MovY);
			HKIMAANBGMJ().SetFloat("vignetteIntensity", KJIKOEIAENF);
			OCHJIMJNEMO().SetVector("CameraFilterPack/Drawing_Manga2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1182f, 277f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AEDDNDHCLNN()
	{
		SCShader = Shader.Find("PhotonView register is ignored, because viewID is 0. No id assigned yet to: ");
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
		SCShader = Shader.Find("_TimeX");
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
		SCShader = Shader.Find("_Value3");
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
			BFGNMFCNDBC().SetFloat("Object ID. Case-Sensitive", HBJJOCHGOPH);
			DOMEEFLPEPJ().SetFloat("UI", Intensity);
			OIIDAKBILMI().SetFloat("Emergency Help:", MovX);
			LELKBCALFCF().SetFloat("CameraFilterPack_TV_Noise2", MovY);
			DOMEEFLPEPJ().SetFloat("Gameplay/LobbyPlayerIconElement", KJIKOEIAENF);
			AELJLBOJAIL().SetVector("a year ago", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 394f, 1967f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIIDAKBILMI());
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
			EFMCNLELMDO().SetFloat("Failed to 'network-remove' GameObject because it is missing a valid InstantiationId on view: ", HBJJOCHGOPH);
			DOMEEFLPEPJ().SetFloat("Submit", Intensity);
			BFGNMFCNDBC().SetFloat("Please attach component to a Graphical UI component", MovX);
			DOMEEFLPEPJ().SetFloat("SetSunSensitivity", MovY);
			IONHGBPGCHK().SetFloat("AudioSampler", KJIKOEIAENF);
			EFMCNLELMDO().SetVector("IconImage", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1180f, 1892f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
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
			MICHFGAOPKM().SetFloat("#exitmapeditor", HBJJOCHGOPH);
			OCHJIMJNEMO().SetFloat("float,2", Intensity);
			OHKGGPFGLFD().SetFloat("A", MovX);
			NFMGLIKNOOC().SetFloat("_Parameter", MovY);
			IONHGBPGCHK().SetFloat("': ", KJIKOEIAENF);
			OIIDAKBILMI().SetVector("#task", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1396f, 648f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
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
			INOBFNCKFGK().SetFloat("CameraFilterPack/Blend2Camera_Difference", HBJJOCHGOPH);
			CECJJMKLEAK().SetFloat("[LevelEditorScene] Error: You're not logged into Steam!", Intensity);
			MICHFGAOPKM().SetFloat("--------------------------------", MovX);
			INOBFNCKFGK().SetFloat(" with a prefix of ", MovY);
			KHCLIAMBBNC().SetFloat("PowerUp", KJIKOEIAENF);
			DOMEEFLPEPJ().SetVector("FPSToggle", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1888f, 1694f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
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
			AELJLBOJAIL().SetFloat("_Jitter", HBJJOCHGOPH);
			LELKBCALFCF().SetFloat("menutheme.letitbe", Intensity);
			INOBFNCKFGK().SetFloat("\\\"", MovX);
			IONHGBPGCHK().SetFloat("Fade", MovY);
			LELKBCALFCF().SetFloat("Set Particles Gravity", KJIKOEIAENF);
			DOMEEFLPEPJ().SetVector("Spawn new environment object (sun, satellite etc) and sets its id", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1309f, 330f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
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
			MJJIEHANFJA().SetFloat("RecordButton", HBJJOCHGOPH);
			LELKBCALFCF().SetFloat("Beat Detected", Intensity);
			BFGNMFCNDBC().SetFloat(":", MovX);
			AELJLBOJAIL().SetFloat("_ScreenResolution", MovY);
			BFGNMFCNDBC().SetFloat("player.gamecompleted", KJIKOEIAENF);
			AELJLBOJAIL().SetVector("CameraFilterPack/Gradients_ElectricGradient", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1252f, 166f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FMFNILJIEIA()
	{
		SCShader = Shader.Find("Currently, the limit of users is reached for this title. Try again later. Disconnecting");
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
		SCShader = Shader.Find("Mine");
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
			BFGNMFCNDBC().SetFloat("/", HBJJOCHGOPH);
			EFMCNLELMDO().SetFloat("[UI] ", Intensity);
			AELJLBOJAIL().SetFloat("_Color_R", MovX);
			OHKGGPFGLFD().SetFloat("/icon", MovY);
			HCGJCMDJPGD().SetFloat("CameraFilterPack/TV_ARCADE", KJIKOEIAENF);
			IONHGBPGCHK().SetVector(" BETA", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 932f, 188f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
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
		SCShader = Shader.Find("_ScreenResolution");
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
		SCShader = Shader.Find("Tab1Content");
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
		SCShader = Shader.Find("Vertical");
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
			NBPKMLMCHFN.SetFloat("_ForceYSwap", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("CameraFilterPack/Pixelisation_Sweater", Intensity);
			CECJJMKLEAK().SetFloat("y", MovX);
			CECJJMKLEAK().SetFloat("_Value", MovY);
			NFMGLIKNOOC().SetFloat("_Value3", KJIKOEIAENF);
			MICHFGAOPKM().SetVector(" registered.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 595f, 1111f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LELKBCALFCF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HLIAEEMGBHN()
	{
		SCShader = Shader.Find("_VignettingColor");
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
		SCShader = Shader.Find("_Value3");
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
			HCGJCMDJPGD().SetFloat("_MatrixSize", HBJJOCHGOPH);
			DOMEEFLPEPJ().SetFloat("_ScreenResolution", Intensity);
			KBOPGONOCNP().SetFloat("shader.frost", MovX);
			MJJIEHANFJA().SetFloat("_Value", MovY);
			IONHGBPGCHK().SetFloat("#FFDA44", KJIKOEIAENF);
			OCHJIMJNEMO().SetVector("Destroying GO as global. ID: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 551f, 147f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOMEEFLPEPJ());
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
			HCGJCMDJPGD().SetFloat("Finished", HBJJOCHGOPH);
			KHCLIAMBBNC().SetFloat("_Blend", Intensity);
			LELKBCALFCF().SetFloat("[ResourcesManager] Load text error: not found", MovX);
			OHKGGPFGLFD().SetFloat("CheckpointsScoreText", MovY);
			IONHGBPGCHK().SetFloat("GlassColor", KJIKOEIAENF);
			OHKGGPFGLFD().SetVector("2hands", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 593f, 291f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BAGICADFBAB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AIBNKIDADPI()
	{
		SCShader = Shader.Find("CameraFilterPack/Pixel_Pixelisation");
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
			OHKGGPFGLFD().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			OHKGGPFGLFD().SetFloat("Fade", Intensity);
			NBPKMLMCHFN.SetFloat("Scrollbar", MovX);
			CECJJMKLEAK().SetFloat("\n\n#", MovY);
			INOBFNCKFGK().SetFloat("VisionBlur", KJIKOEIAENF);
			IONHGBPGCHK().SetVector("_Offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1057f, 1239f));
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
			AELJLBOJAIL().SetFloat("ResetButton", HBJJOCHGOPH);
			DOMEEFLPEPJ().SetFloat("_FgCocMask", Intensity);
			BFGNMFCNDBC().SetFloat("_ScreenResolution", MovX);
			IONHGBPGCHK().SetFloat("Joystick", MovY);
			BFGNMFCNDBC().SetFloat("_MainTex2", KJIKOEIAENF);
			EFMCNLELMDO().SetVector("CameraFilterPack_TV_BrokenGlass_2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1498f, 1754f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
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
			NBPKMLMCHFN.SetFloat("Submition failed", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("{0}sec average:", Intensity);
			AELJLBOJAIL().SetFloat("https://reddit.com/r/Intralism", MovX);
			FGENHBKMPDA().SetFloat("_Value9", MovY);
			NBPKMLMCHFN.SetFloat(".", KJIKOEIAENF);
			KBOPGONOCNP().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 647f, 101f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, INOBFNCKFGK());
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
			KHCLIAMBBNC().SetFloat("restrictions\n\n#until: ", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("_RGB", Intensity);
			MJJIEHANFJA().SetFloat("settings.enableranking", MovX);
			KHCLIAMBBNC().SetFloat("player.greenlollipop", MovY);
			CECJJMKLEAK().SetFloat("/icon", KJIKOEIAENF);
			IONHGBPGCHK().SetVector("ItemNameText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 178f, 1150f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOMEEFLPEPJ());
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
			INOBFNCKFGK().SetFloat("bans.viewed.", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat(". MasterClient: ", Intensity);
			NBPKMLMCHFN.SetFloat("JoinRandom failed: No open game. Calling: OnPhotonRandomJoinFailed() and staying on master server.", MovX);
			MICHFGAOPKM().SetFloat("_ScreenResolution", MovY);
			MICHFGAOPKM().SetFloat("_TimeX", KJIKOEIAENF);
			EFMCNLELMDO().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1071f, 804f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MICHFGAOPKM());
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
		SCShader = Shader.Find("_TimeX");
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
		SCShader = Shader.Find("_TimeX");
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
			BAGICADFBAB().SetFloat("offsets", HBJJOCHGOPH);
			OCHJIMJNEMO().SetFloat(".lastCheckpoint.incorrectScore", Intensity);
			OCHJIMJNEMO().SetFloat("_SunPosition", MovX);
			AELJLBOJAIL().SetFloat("CheckpointsScoreText", MovY);
			HCGJCMDJPGD().SetFloat("_TimeX", KJIKOEIAENF);
			KBOPGONOCNP().SetVector("_Value4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 955f, 783f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, INOBFNCKFGK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KNBJBNDGCIJ()
	{
		SCShader = Shader.Find("\" error: ");
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
			NBPKMLMCHFN.SetFloat("Down", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("original.tutorial", Intensity);
			EOCCJGIGEGJ().SetFloat("_TreatBackfaceHitAsMiss", MovX);
			EFMCNLELMDO().SetFloat("PLAY [SPACE]", MovY);
			LELKBCALFCF().SetFloat(":</b> ", KJIKOEIAENF);
			BAGICADFBAB().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 740f, 1931f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
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
			KBOPGONOCNP().SetFloat("_Offset", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("_FadeFromBinary", Intensity);
			LELKBCALFCF().SetFloat("CameraFilterPack/Lut_TestMode", MovX);
			KHCLIAMBBNC().SetFloat("_Near", MovY);
			CECJJMKLEAK().SetFloat("list", KJIKOEIAENF);
			DOMEEFLPEPJ().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 62f, 1943f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OHKGGPFGLFD());
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
			NFMGLIKNOOC().SetFloat("1177138211", HBJJOCHGOPH);
			DOMEEFLPEPJ().SetFloat("#", Intensity);
			BAGICADFBAB().SetFloat("SupportLogger OnDisconnectedFromPhoton().", MovX);
			EFMCNLELMDO().SetFloat("_SizeY", MovY);
			NBPKMLMCHFN.SetFloat("[Down-Left]", KJIKOEIAENF);
			HCGJCMDJPGD().SetVector("settings.customdataskin", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1840f, 339f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CECJJMKLEAK());
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
			CECJJMKLEAK().SetFloat("threshold", HBJJOCHGOPH);
			MJJIEHANFJA().SetFloat("float,10", Intensity);
			BFGNMFCNDBC().SetFloat("Tab1Content", MovX);
			EFMCNLELMDO().SetFloat("_Offsets", MovY);
			MICHFGAOPKM().SetFloat("#yes", KJIKOEIAENF);
			INOBFNCKFGK().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1603f, 926f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BAGICADFBAB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LBAJLLFMMMP()
	{
		SCShader = Shader.Find("player.licenceaccepted");
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
			CECJJMKLEAK().SetFloat("_AdaptationSpeed", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("UI/Particles/Hidden", Intensity);
			CECJJMKLEAK().SetFloat("_CameraToWorldMatrix", MovX);
			DOMEEFLPEPJ().SetFloat("StopMusic", MovY);
			MICHFGAOPKM().SetFloat("Please specify either t or f.", KJIKOEIAENF);
			INOBFNCKFGK().SetVector("offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 617f, 352f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KHCLIAMBBNC());
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
			HCGJCMDJPGD().SetFloat("_ChangeRed", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat(".completedMaps", Intensity);
			INOBFNCKFGK().SetFloat("Sending RPC \"", MovX);
			KHCLIAMBBNC().SetFloat(" - PUBLISHED #", MovY);
			AELJLBOJAIL().SetFloat("skin.hit_normal", KJIKOEIAENF);
			HKIMAANBGMJ().SetVector("RoomNameText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1190f, 255f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFMCNLELMDO());
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
		SCShader = Shader.Find("#FFDA44");
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
		SCShader = Shader.Find("_Red_G");
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
		SCShader = Shader.Find(" while connecting to: ");
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
		SCShader = Shader.Find("float,0");
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
		SCShader = Shader.Find("event");
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
			OCHJIMJNEMO().SetFloat(" ", HBJJOCHGOPH);
			KHCLIAMBBNC().SetFloat("_ScreenResolution", Intensity);
			NBPKMLMCHFN.SetFloat("_Value3", MovX);
			KBOPGONOCNP().SetFloat("_Value", MovY);
			MJJIEHANFJA().SetFloat("_MatrixSpeed", KJIKOEIAENF);
			AELJLBOJAIL().SetVector("LevelNameText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1371f, 725f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
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
			OHKGGPFGLFD().SetFloat("[PlayerBase] ShowTitle error: ", HBJJOCHGOPH);
			DOMEEFLPEPJ().SetFloat("RequestOwnership(): ", Intensity);
			OCHJIMJNEMO().SetFloat("_ScreenResolution", MovX);
			MJJIEHANFJA().SetFloat("CameraFilterPack/Blend2Camera_GreenScreen", MovY);
			AELJLBOJAIL().SetFloat("ExitGames.Client.Photon.SocketWebTcp, Assembly-CSharp", KJIKOEIAENF);
			EOCCJGIGEGJ().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 196f, 529f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
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
			EFMCNLELMDO().SetFloat("CameraFilterPack/FX_Glitch2", HBJJOCHGOPH);
			MJJIEHANFJA().SetFloat("_AdditiveReflection", Intensity);
			NBPKMLMCHFN.SetFloat("_TimeX", MovX);
			OIIDAKBILMI().SetFloat(" url: ", MovY);
			FGENHBKMPDA().SetFloat("_ReflectionBufferSize", KJIKOEIAENF);
			NBPKMLMCHFN.SetVector("Mouse1", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1390f, 1620f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MJJIEHANFJA());
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
		SCShader = Shader.Find("<command>");
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
			BAGICADFBAB().SetFloat("_Value3", HBJJOCHGOPH);
			LELKBCALFCF().SetFloat("#exit", Intensity);
			LELKBCALFCF().SetFloat("achievements.21.progress", MovX);
			HKIMAANBGMJ().SetFloat("https://discord.gg/intralism", MovY);
			NFMGLIKNOOC().SetFloat("Item created: Id: ", KJIKOEIAENF);
			IONHGBPGCHK().SetVector("CameraFilterPack/OldFilm_Cutting1", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 948f, 775f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKIMAANBGMJ());
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
			OHKGGPFGLFD().SetFloat("_SunPosition", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("MenuScene", Intensity);
			IONHGBPGCHK().SetFloat("_Value2", MovX);
			EOCCJGIGEGJ().SetFloat("_TimeX", MovY);
			CECJJMKLEAK().SetFloat("player.arrow", KJIKOEIAENF);
			KBOPGONOCNP().SetVector("levelcompleted", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1705f, 496f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AKHCOBHHGJP()
	{
		SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
