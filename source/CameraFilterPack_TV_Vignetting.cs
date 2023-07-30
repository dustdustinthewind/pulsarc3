// CameraFilterPack_TV_Vignetting
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/TV/Vignetting")]
[ExecuteInEditMode]
public class CameraFilterPack_TV_Vignetting : MonoBehaviour
{
	public Shader SCShader;

	private Material BJFKDHHMLJH;

	private Texture2D IJFBACJAHAG;

	[Range(0f, 1f)]
	public float Vignetting = 1f;

	[Range(0f, 1f)]
	public float VignettingFull;

	[Range(0f, 1f)]
	public float VignettingDirt;

	public Color VignettingColor = new Color(0f, 0f, 0f, 1f);

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

	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			KBOPGONOCNP().SetTexture(",", IJFBACJAHAG);
			OGMEGHKECAH().SetFloat("[LobbyPlayerElement] On ready click", Vignetting);
			IIJMIPBMMBF().SetFloat("SetParticlesCountPerBeat", VignettingFull);
			DONENAMLFLF().SetColor("#", VignettingColor);
			OGMEGHKECAH().SetFloat("TBD", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			DONENAMLFLF().SetTexture("ENABLE_USER_LUT", IJFBACJAHAG);
			NBPKMLMCHFN.SetFloat("y", Vignetting);
			LPDOGGFOBDH().SetFloat("_ScreenResolution", VignettingFull);
			BLMPMOIDGMG().SetColor("< true | false >", VignettingColor);
			KBOPGONOCNP().SetFloat("\"x", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EGEPLFGKGLI()
	{
		SCShader = Shader.Find("_ScreenResolution");
		IJFBACJAHAG = Resources.Load("\n") as Texture2D;
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CNGAJDBOCLJ()
	{
		SCShader = Shader.Find("_RgbTex");
		IJFBACJAHAG = Resources.Load("ConnectUsingSettings() disabled the offline mode. No longer offline.") as Texture2D;
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ONMGIPAILOH()
	{
	}

	private void FOLDLDLFFLM()
	{
	}

	private void GPFJMKCGHGB()
	{
	}

	private void JBCNIPJDPJB()
	{
	}

	private void FDPOFMCFBMF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OPCLBGHAPMG()
	{
	}

	private void CGDMLHLJIDK()
	{
		SCShader = Shader.Find("_copy");
		IJFBACJAHAG = Resources.Load("y") as Texture2D;
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material DONENAMLFLF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)85;
		}
		return BJFKDHHMLJH;
	}

	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			MFHPKGICPIO().SetTexture("OK", IJFBACJAHAG);
			OGMEGHKECAH().SetFloat("_Value", Vignetting);
			NBPKMLMCHFN.SetFloat(".sawoutdatedmessage", VignettingFull);
			LPDOGGFOBDH().SetColor(";", VignettingColor);
			DOHGBNPMBKG().SetFloat("_Speed", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
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
	private Material BLMPMOIDGMG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return BJFKDHHMLJH;
	}

	private void PBEPCAPAKLG()
	{
	}

	[SpecialName]
	private Material OGMEGHKECAH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			MMOODGIODPC().SetTexture("_CutOff", IJFBACJAHAG);
			MFHPKGICPIO().SetFloat("_ScreenResolution", Vignetting);
			LNLKMDPHDCC().SetFloat("_SpherePositionY", VignettingFull);
			GJHPODJOBHL().SetColor("\t", VignettingColor);
			DKKBFFHBHJE().SetFloat("shader.pixel", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DFENCIHAADO()
	{
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
			BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	private void Update()
	{
	}

	[SpecialName]
	private Material OJMHIMIPKME()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void PKHPNHBEKHA()
	{
	}

	private void LCHBFNIPBHB()
	{
	}

	private void IFJDKDFLGBG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LECCHIAFGGE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material MFHPKGICPIO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-113);
		}
		return BJFKDHHMLJH;
	}

	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			NBPKMLMCHFN.SetTexture("[DiscordController] Shutdown", IJFBACJAHAG);
			IONHGBPGCHK().SetFloat("CameraFilterPack/Gradients_Tech", Vignetting);
			HEINDEMCGIK().SetFloat("LevelNameText", VignettingFull);
			MMOODGIODPC().SetColor("resource", VignettingColor);
			DOHGBNPMBKG().SetFloat("CameraFilterPack/Real_VHS", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DKPBBJINKMG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)73;
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

	private void COOHIILCOCO()
	{
		SCShader = Shader.Find("_Glitch");
		IJFBACJAHAG = Resources.Load("0.00") as Texture2D;
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BJOHDLNDFAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IKIDIJLIGOH()
	{
	}

	private void EDBEHEKMGFH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DHNGNHGDPLM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FEHCNJLLJMP()
	{
		SCShader = Shader.Find("_Offsets");
		IJFBACJAHAG = Resources.Load("Hex value #RRGGBB") as Texture2D;
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JNBPKNNBMDI()
	{
	}

	[SpecialName]
	private Material HEINDEMCGIK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return BJFKDHHMLJH;
	}

	private void FGNFILLNPJK()
	{
	}

	private void EJFJENFKLND()
	{
	}

	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			NBPKMLMCHFN.SetTexture("Vignette", IJFBACJAHAG);
			NBPKMLMCHFN.SetFloat("_Vignetting", Vignetting);
			NBPKMLMCHFN.SetFloat("_Vignetting2", VignettingFull);
			NBPKMLMCHFN.SetColor("_VignettingColor", VignettingColor);
			NBPKMLMCHFN.SetFloat("_VignettingDirt", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NFEDLAOPHML()
	{
	}

	[SpecialName]
	private Material GJHPODJOBHL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void BGDPIHMAACO()
	{
		SCShader = Shader.Find("Deleted event");
		IJFBACJAHAG = Resources.Load("_ScreenResolution") as Texture2D;
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OEENOOGEEHD()
	{
	}

	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			GJHPODJOBHL().SetTexture("_Value4", IJFBACJAHAG);
			LNLKMDPHDCC().SetFloat("Joystick1Button5", Vignetting);
			MMOODGIODPC().SetFloat("Room: '{0}' {1},{2} {4}/{3} players.\ncustomProps: {5}", VignettingFull);
			IONHGBPGCHK().SetColor("_FixDistance", VignettingColor);
			EMDFHOKEGNG().SetFloat("Prints the number of logs currently held by DebugLogs", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			IONHGBPGCHK().SetTexture("_Value2", IJFBACJAHAG);
			MMOODGIODPC().SetFloat("_SoftZDistance", Vignetting);
			MMOODGIODPC().SetFloat("SetBGColor", VignettingFull);
			LPDOGGFOBDH().SetColor("z", VignettingColor);
			EMDFHOKEGNG().SetFloat("_Value", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LINKAMEPKGM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material LPDOGGFOBDH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void KNBJBNDGCIJ()
	{
		SCShader = Shader.Find("winter2020");
		IJFBACJAHAG = Resources.Load("_TimeX") as Texture2D;
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KMCPMOGKDEH()
	{
		SCShader = Shader.Find("_Value");
		IJFBACJAHAG = Resources.Load("CameraFilterPack/Blend2Camera_ColorKey") as Texture2D;
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AAPKBNDHBLI()
	{
	}

	[SpecialName]
	private Material DKKBFFHBHJE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-110);
		}
		return BJFKDHHMLJH;
	}

	private void FPHLDMMAOEF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material MMOODGIODPC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void NNBCLMJGFEN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			DOHGBNPMBKG().SetTexture("settings_bindings_controller_type", IJFBACJAHAG);
			OJMHIMIPKME().SetFloat("_Value4", Vignetting);
			OGMEGHKECAH().SetFloat("caret", VignettingFull);
			LNLKMDPHDCC().SetColor("_TimeX", VignettingColor);
			LPDOGGFOBDH().SetFloat("_Value2", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BLKGOMCPEKI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MJNPIDGNJMK()
	{
	}

	[SpecialName]
	private Material DNLMFEGJJDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material LNLKMDPHDCC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-114);
		}
		return BJFKDHHMLJH;
	}

	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			NBPKMLMCHFN.SetTexture("OnRelease", IJFBACJAHAG);
			GJHPODJOBHL().SetFloat("LastNewsButton", Vignetting);
			MFHPKGICPIO().SetFloat("X", VignettingFull);
			IIJMIPBMMBF().SetColor("_Bullet_1", VignettingColor);
			KBOPGONOCNP().SetFloat("_Y", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/TV_Vignetting");
		IJFBACJAHAG = Resources.Load("CameraFilterPack_TV_Vignetting1") as Texture2D;
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			IIJMIPBMMBF().SetTexture("_ScreenResolution", IJFBACJAHAG);
			IONHGBPGCHK().SetFloat("Error: Someone else(", Vignetting);
			DNLMFEGJJDD().SetFloat("help", VignettingFull);
			LPDOGGFOBDH().SetColor("runas", VignettingColor);
			OGMEGHKECAH().SetFloat("player.circle", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			LPDOGGFOBDH().SetTexture("OpCreateRoom()", IJFBACJAHAG);
			MFHPKGICPIO().SetFloat("_Value2", Vignetting);
			DNLMFEGJJDD().SetFloat("_Value3", VignettingFull);
			HEINDEMCGIK().SetColor("_Value", VignettingColor);
			KBOPGONOCNP().SetFloat("_MainTex2", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HONBLGFDMLL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OIBMHPIFAKK()
	{
	}

	private void DKOPKPBLDHH()
	{
		SCShader = Shader.Find("https://vk.com/khb.soft");
		IJFBACJAHAG = Resources.Load("_Value2") as Texture2D;
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AEIJFLJEABG()
	{
	}

	[SpecialName]
	private Material EMDFHOKEGNG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-68);
		}
		return BJFKDHHMLJH;
	}

	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			DKKBFFHBHJE().SetTexture("workshop.", IJFBACJAHAG);
			EOCCJGIGEGJ().SetFloat(":", Vignetting);
			LPDOGGFOBDH().SetFloat("Connecting", VignettingFull);
			KBOPGONOCNP().SetColor("No font defined. Found font: ", VignettingColor);
			MMOODGIODPC().SetFloat("HPToggle", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IEMEHGCFAPD()
	{
	}

	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			DNLMFEGJJDD().SetTexture("Deleted event", IJFBACJAHAG);
			LNLKMDPHDCC().SetFloat("AVG Misses:", Vignetting);
			BLMPMOIDGMG().SetFloat("Items/", VignettingFull);
			NBPKMLMCHFN.SetColor("settings.enablehitsoundsinrelax", VignettingColor);
			MFHPKGICPIO().SetFloat("Depth textures aren't supported on this device ({0})", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DBEMDAJDDDA()
	{
		SCShader = Shader.Find("SettingsCanvas");
		IJFBACJAHAG = Resources.Load("skin.") as Texture2D;
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LGHCJCFHEMF()
	{
		SCShader = Shader.Find("Drop_With_Obj");
		IJFBACJAHAG = Resources.Load("UseScanLine") as Texture2D;
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

	[SpecialName]
	private Material DOHGBNPMBKG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void HNILMGEKDEC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void POIMNOBDBBN()
	{
	}

	private void GAOOPEEBGJA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MAOCOEGAFND()
	{
	}

	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			EMDFHOKEGNG().SetTexture("LoadingStatusText", IJFBACJAHAG);
			OGMEGHKECAH().SetFloat("[Up]", Vignetting);
			IIJMIPBMMBF().SetFloat("_ScreenResolution", VignettingFull);
			EMDFHOKEGNG().SetColor("[PlayerController] ", VignettingColor);
			DOHGBNPMBKG().SetFloat("visible", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHPODJOBHL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KOFAMEKHHGD()
	{
		SCShader = Shader.Find("_Value3");
		IJFBACJAHAG = Resources.Load("Incoming: \n") as Texture2D;
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IBPAMDEAGJL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ODGMCJILIHF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			IIJMIPBMMBF().SetTexture("AccuracyScoreText", IJFBACJAHAG);
			EOCCJGIGEGJ().SetFloat("Ok", Vignetting);
			IONHGBPGCHK().SetFloat("settings_bindings_", VignettingFull);
			DNLMFEGJJDD().SetColor("FullscreenToggle", VignettingColor);
			DOHGBNPMBKG().SetFloat("]. Please verify you have this gameobject in a Resources folder.", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MECJHOJPODB()
	{
	}

	private void CNDACAHCCOI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BGFJOEPFOPM()
	{
	}

	private void PKGJJFIFLII()
	{
	}

	private void HIPEHGNBJMN()
	{
		SCShader = Shader.Find("_Value6");
		IJFBACJAHAG = Resources.Load("skin.") as Texture2D;
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			OGMEGHKECAH().SetTexture("[Left]", IJFBACJAHAG);
			DOHGBNPMBKG().SetFloat("ready", Vignetting);
			DKKBFFHBHJE().SetFloat("ArcsNoHitsoundTimeDelaySlider", VignettingFull);
			NBPKMLMCHFN.SetColor("_Value", VignettingColor);
			KBOPGONOCNP().SetFloat("_FixDistance", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			BLMPMOIDGMG().SetTexture("_Distortion", IJFBACJAHAG);
			LPDOGGFOBDH().SetFloat("_ScreenResolution", Vignetting);
			OJMHIMIPKME().SetFloat("#no", VignettingFull);
			MFHPKGICPIO().SetColor("_Distortion", VignettingColor);
			BLMPMOIDGMG().SetFloat("_ScreenResolution", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			BLMPMOIDGMG().SetTexture("_Value", IJFBACJAHAG);
			MMOODGIODPC().SetFloat("_ScreenResolution", Vignetting);
			BLMPMOIDGMG().SetFloat("_Value3", VignettingFull);
			IIJMIPBMMBF().SetColor("_TimeX", VignettingColor);
			BLMPMOIDGMG().SetFloat("skin.", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			DNLMFEGJJDD().SetTexture("_Red_R", IJFBACJAHAG);
			IIJMIPBMMBF().SetFloat("SetSpeed", Vignetting);
			LNLKMDPHDCC().SetFloat("SetParticlesCountPerBeat", VignettingFull);
			GJHPODJOBHL().SetColor("set environment id", VignettingColor);
			DNLMFEGJJDD().SetFloat("CameraFilterPack/Vision_Warp", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHPODJOBHL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JOJFHFHOCHO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			GJHPODJOBHL().SetTexture("_TimeX", IJFBACJAHAG);
			DONENAMLFLF().SetFloat("1,30,true,0", Vignetting);
			GJHPODJOBHL().SetFloat("id", VignettingFull);
			GJHPODJOBHL().SetColor("_DotSize", VignettingColor);
			DNLMFEGJJDD().SetFloat("Joystick1Button9", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			LPDOGGFOBDH().SetTexture("_ScreenResolution", IJFBACJAHAG);
			DNLMFEGJJDD().SetFloat("_TimeX", Vignetting);
			IIJMIPBMMBF().SetFloat("Couldn't color correct with 3D LUT texture. Image Effect will be disabled.", VignettingFull);
			DKKBFFHBHJE().SetColor("win", VignettingColor);
			IONHGBPGCHK().SetFloat("#restart", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material IIJMIPBMMBF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)106;
		}
		return BJFKDHHMLJH;
	}

	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			OGMEGHKECAH().SetTexture(").png", IJFBACJAHAG);
			EOCCJGIGEGJ().SetFloat("0", Vignetting);
			LPDOGGFOBDH().SetFloat("JoinRoom failed. In offline mode you still have to leave a room to enter another.", VignettingFull);
			EMDFHOKEGNG().SetColor("offsets", VignettingColor);
			NBPKMLMCHFN.SetFloat("_Value9", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
