// CameraFilterPack_TV_Vignetting
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/TV/Vignetting")]
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
			DKKBFFHBHJE().SetTexture(".completedCount", IJFBACJAHAG);
			LPDOGGFOBDH().SetFloat("[LobbyPlayerElement] On ready click", Vignetting);
			KBOPGONOCNP().SetFloat("SetParticlesCountPerBeat", VignettingFull);
			DOHGBNPMBKG().SetColor("english", VignettingColor);
			DONENAMLFLF().SetFloat("TBD", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
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
			MFHPKGICPIO().SetTexture("SteamManager", IJFBACJAHAG);
			BLMPMOIDGMG().SetFloat("x", Vignetting);
			OGMEGHKECAH().SetFloat("_ScreenResolution", VignettingFull);
			DNLMFEGJJDD().SetColor("Print the list of scenes, avalable in game.", VignettingColor);
			OGMEGHKECAH().SetFloat(" ", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EGEPLFGKGLI()
	{
		SCShader = Shader.Find("CameraFilterPack/Gradients_FireGradient");
		IJFBACJAHAG = Resources.Load("[") as Texture2D;
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CNGAJDBOCLJ()
	{
		SCShader = Shader.Find("_RgbDepthTex");
		IJFBACJAHAG = Resources.Load("ConnectToMaster() disabled the offline mode. No longer offline.") as Texture2D;
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
		SCShader = Shader.Find(".sawoutdatedmessage");
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
			IONHGBPGCHK().SetTexture("/", IJFBACJAHAG);
			MFHPKGICPIO().SetFloat("_Value", Vignetting);
			IONHGBPGCHK().SetFloat("Editor", VignettingFull);
			IONHGBPGCHK().SetColor(";", VignettingColor);
			IONHGBPGCHK().SetFloat("_Distortion", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
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
			DOHGBNPMBKG().SetTexture("UI/Particles/Hidden", IJFBACJAHAG);
			BLMPMOIDGMG().SetFloat("CameraFilterPack/FX_DarkMatter", Vignetting);
			HEINDEMCGIK().SetFloat("_SpherePositionY", VignettingFull);
			BLMPMOIDGMG().SetColor("\r", VignettingColor);
			EOCCJGIGEGJ().SetFloat("shader.none", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
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
			DKKBFFHBHJE().SetTexture("{0}", IJFBACJAHAG);
			DNLMFEGJJDD().SetFloat("_TimeX", Vignetting);
			MFHPKGICPIO().SetFloat("workshop.", VignettingFull);
			DOHGBNPMBKG().SetColor("resource", VignettingColor);
			GJHPODJOBHL().SetFloat("CameraFilterPack_VHS1", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHPODJOBHL());
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
		SCShader = Shader.Find("_ScreenResolution");
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
		SCShader = Shader.Find("_SecondTex");
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
		SCShader = Shader.Find("BitsData");
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
			LNLKMDPHDCC().SetTexture("_Value5", IJFBACJAHAG);
			OGMEGHKECAH().SetFloat("R1", Vignetting);
			IONHGBPGCHK().SetFloat("hidden", VignettingFull);
			DNLMFEGJJDD().SetColor("_LightIntensity", VignettingColor);
			NBPKMLMCHFN.SetFloat("quit", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
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
			HEINDEMCGIK().SetTexture("_Value3", IJFBACJAHAG);
			NBPKMLMCHFN.SetFloat("_SoftZDistance", Vignetting);
			DKKBFFHBHJE().SetFloat("SetBGColor", VignettingFull);
			DNLMFEGJJDD().SetColor("x", VignettingColor);
			DOHGBNPMBKG().SetFloat("_Value3", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
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
		SCShader = Shader.Find("mapselector.filter.rateduponly");
		IJFBACJAHAG = Resources.Load("_TimeX") as Texture2D;
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KMCPMOGKDEH()
	{
		SCShader = Shader.Find("_ScreenResolution");
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
			DKKBFFHBHJE().SetTexture("^", IJFBACJAHAG);
			MMOODGIODPC().SetFloat("BloodAlternative1", Vignetting);
			DONENAMLFLF().SetFloat("checkpoint", VignettingFull);
			IONHGBPGCHK().SetColor("CameraFilterPack/TV_Old_Movie", VignettingColor);
			OGMEGHKECAH().SetFloat("_ScreenResolution", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
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
			LNLKMDPHDCC().SetTexture("ChatInput", IJFBACJAHAG);
			DONENAMLFLF().SetFloat("LastNewsButton", Vignetting);
			DKKBFFHBHJE().SetFloat("Joystick1Button1", VignettingFull);
			HEINDEMCGIK().SetColor("_Bullet_2", VignettingColor);
			IIJMIPBMMBF().SetFloat("_Y", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DONENAMLFLF());
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
			HEINDEMCGIK().SetTexture("CameraFilterPack_TV_BrokenGlass1", IJFBACJAHAG);
			MMOODGIODPC().SetFloat("Ev Destroy Failed. Could not find PhotonView with instantiationId ", Vignetting);
			GJHPODJOBHL().SetFloat("Prints list of commands", VignettingFull);
			NBPKMLMCHFN.SetColor("runas", VignettingColor);
			HEINDEMCGIK().SetFloat("player.crystal", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOHGBNPMBKG());
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
			EOCCJGIGEGJ().SetTexture("OpJoinRandomRoom()", IJFBACJAHAG);
			EOCCJGIGEGJ().SetFloat("_Value3", Vignetting);
			GJHPODJOBHL().SetFloat("_Value3", VignettingFull);
			EMDFHOKEGNG().SetColor("_Value2", VignettingColor);
			DONENAMLFLF().SetFloat("_MainTex2", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OJMHIMIPKME());
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
		SCShader = Shader.Find("https://reddit.com/r/Intralism");
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
			HEINDEMCGIK().SetTexture("[SERVER] Selected map: ", IJFBACJAHAG);
			OJMHIMIPKME().SetFloat("2hands", Vignetting);
			MMOODGIODPC().SetFloat(" .", VignettingFull);
			IONHGBPGCHK().SetColor("player", VignettingColor);
			BLMPMOIDGMG().SetFloat("settings.enableranking", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
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
			KBOPGONOCNP().SetTexture("BitsData", IJFBACJAHAG);
			DKKBFFHBHJE().SetFloat("AVG Misses:", Vignetting);
			LNLKMDPHDCC().SetFloat("Gameplay/satellite", VignettingFull);
			IONHGBPGCHK().SetColor("hitsounds:", VignettingColor);
			KBOPGONOCNP().SetFloat("RenderTextureUtilityTempTexture", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DBEMDAJDDDA()
	{
		SCShader = Shader.Find("ScreenResolutionPanel");
		IJFBACJAHAG = Resources.Load("Yes") as Texture2D;
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LGHCJCFHEMF()
	{
		SCShader = Shader.Find("Drop_With_Obj");
		IJFBACJAHAG = Resources.Load("_MainTex2") as Texture2D;
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
			OJMHIMIPKME().SetTexture("Loading maps", IJFBACJAHAG);
			HEINDEMCGIK().SetFloat("uploads/Intralism/mods_terms.pdf", Vignetting);
			OJMHIMIPKME().SetFloat("_ScreenResolution", VignettingFull);
			HEINDEMCGIK().SetColor(": ", VignettingColor);
			DONENAMLFLF().SetFloat("closed", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KOFAMEKHHGD()
	{
		SCShader = Shader.Find("_Value4");
		IJFBACJAHAG = Resources.Load("ping: {6}[+/-{7}]ms resent:{8} \n\nmax ms between\nsend: {0,4} \ndispatch: {1,4} \n\nlongest dispatch for: \nev({3}):{2,3}ms \nop({5}):{4,3}ms") as Texture2D;
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
			KBOPGONOCNP().SetTexture("AccuracyScoreText", IJFBACJAHAG);
			KBOPGONOCNP().SetFloat("Updating...", Vignetting);
			IONHGBPGCHK().SetFloat("settings_bindings_sec_", VignettingFull);
			IONHGBPGCHK().SetColor("MenuVolumeSlider", VignettingColor);
			MFHPKGICPIO().SetFloat("Failed to Destroy objects of playerId: ", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
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
		IJFBACJAHAG = Resources.Load("Yes") as Texture2D;
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			EMDFHOKEGNG().SetTexture("[Up-Right-Left]", IJFBACJAHAG);
			IIJMIPBMMBF().SetFloat("finished", Vignetting);
			IIJMIPBMMBF().SetFloat("settings.arcsnohitsoundtimedelay", VignettingFull);
			GJHPODJOBHL().SetColor("_Value2", VignettingColor);
			NBPKMLMCHFN.SetFloat("_FixDistance", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
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
			GJHPODJOBHL().SetTexture("_ScreenResolution", IJFBACJAHAG);
			EMDFHOKEGNG().SetFloat("_TimeX", Vignetting);
			DONENAMLFLF().SetFloat("#mapalreadyexistupdate", VignettingFull);
			KBOPGONOCNP().SetColor("_ScreenResolution", VignettingColor);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Oculus_NightVision5", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
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
			DOHGBNPMBKG().SetTexture("_Value", IJFBACJAHAG);
			EOCCJGIGEGJ().SetFloat("CameraFilterPack/FX_Glitch1", Vignetting);
			DKKBFFHBHJE().SetFloat("_Value4", VignettingFull);
			IONHGBPGCHK().SetColor("_RedAmplifier", VignettingColor);
			MFHPKGICPIO().SetFloat(".icon", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
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
			LPDOGGFOBDH().SetTexture("_Red_G", IJFBACJAHAG);
			GJHPODJOBHL().SetFloat("SetTrailZoomSpeed", Vignetting);
			NBPKMLMCHFN.SetFloat("SetEnvSpriteColor", VignettingFull);
			OGMEGHKECAH().SetColor("set environment id", VignettingColor);
			OGMEGHKECAH().SetFloat("_Value", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF());
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
			DNLMFEGJJDD().SetTexture("_Fade", IJFBACJAHAG);
			KBOPGONOCNP().SetFloat("1,30,true,0", Vignetting);
			KBOPGONOCNP().SetFloat("id", VignettingFull);
			MFHPKGICPIO().SetColor("_DotSize", VignettingColor);
			NBPKMLMCHFN.SetFloat("Joystick1Button10", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF());
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
			EMDFHOKEGNG().SetTexture("CameraFilterPack_eyes_vision_1", IJFBACJAHAG);
			EOCCJGIGEGJ().SetFloat("_TimeX", Vignetting);
			IONHGBPGCHK().SetFloat("_Offset", VignettingFull);
			DKKBFFHBHJE().SetColor("1", VignettingColor);
			KBOPGONOCNP().SetFloat("Connection error: ", VignettingDirt);
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
			BLMPMOIDGMG().SetTexture("HighScaleShot", IJFBACJAHAG);
			LNLKMDPHDCC().SetFloat("0", Vignetting);
			IIJMIPBMMBF().SetFloat("JoinRoom failed. A roomname is required. If you don't know one, how will you join?", VignettingFull);
			MFHPKGICPIO().SetColor("offsets", VignettingColor);
			KBOPGONOCNP().SetFloat("_Value9", VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
