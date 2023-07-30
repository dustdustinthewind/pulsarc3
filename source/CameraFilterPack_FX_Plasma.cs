// CameraFilterPack_FX_Plasma
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/FX/Plasma")]
[ExecuteInEditMode]
public class CameraFilterPack_FX_Plasma : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 20f)]
	private float ADPHJHEFAON = 6f;

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
	private Material HNICHJCGJOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)120;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HCGJCMDJPGD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void GPFJMKCGHGB()
	{
	}

	private void IIFCIDDJHPM()
	{
	}

	[SpecialName]
	private Material LDNADDJMIPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 316f)
			{
				HBJJOCHGOPH = 1373f;
			}
			NFMGLIKNOOC().SetFloat("You have added the SecondScrollRect to a scroll view that already has both directions selected", HBJJOCHGOPH);
			GHHPOGODBHB().SetFloat("#submit", ADPHJHEFAON);
			JLHLHKPHDFO().SetVector(": ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 788f, 60f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FABMDEHEDNO()
	{
	}

	private void FDMAEPOHDMK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MMMDPANNAIO()
	{
		SCShader = Shader.Find("mapselector.filter.favoriteonly");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JHPOIOELNCG()
	{
	}

	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1028f)
			{
				HBJJOCHGOPH = 946f;
			}
			DONENAMLFLF().SetFloat("_SceneFogMode", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("MenuScene", ADPHJHEFAON);
			HCGJCMDJPGD().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 376f, 678f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material ACHNOHCLGOO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
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

	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 11f)
			{
				HBJJOCHGOPH = 731f;
			}
			ACHNOHCLGOO().SetFloat("ResetButton", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("_Amount", ADPHJHEFAON);
			LDNADDJMIPK().SetVector("USE_CORNER_DETECTION", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 867f, 1361f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIBLJCKLGFG());
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void BMOFEBKGLFI()
	{
		SCShader = Shader.Find("[Steamworks.NET] Packsize Test returned false, the wrong version of Steamworks.NET is being run in this platform.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FPHLDMMAOEF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JDGFCEPDKAJ()
	{
	}

	[SpecialName]
	private Material JLHLHKPHDFO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material LONNIJMNKFB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-72);
		}
		return BJFKDHHMLJH;
	}

	private void NCPAFCKGJEA()
	{
	}

	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1028f)
			{
				HBJJOCHGOPH = 281f;
			}
			EOCCJGIGEGJ().SetFloat("(\\[ */ *h1 *\\])", HBJJOCHGOPH);
			DONENAMLFLF().SetFloat(" not exist", ADPHJHEFAON);
			GHHPOGODBHB().SetVector("player.neon", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 793f, 1593f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 161f)
			{
				HBJJOCHGOPH = 259f;
			}
			DONENAMLFLF().SetFloat("Particles/Additive", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("_ReflectionTexture4", ADPHJHEFAON);
			EOCCJGIGEGJ().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 65f, 850f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JEBIBKLHFLB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HEHKGPKLAKK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void BMIOFJFMCBG()
	{
		SCShader = Shader.Find("#");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IABLKKAALGI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1446f)
			{
				HBJJOCHGOPH = 195f;
			}
			HNICHJCGJOC().SetFloat("_SunThreshold", HBJJOCHGOPH);
			GJHLADDCMFF().SetFloat("original.tutorial", ADPHJHEFAON);
			HCGJCMDJPGD().SetVector("BackButton", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 216f, 1688f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NAALCEPIHCH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HAIAHJPCPAG()
	{
		SCShader = Shader.Find("ItemTemplate");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return BJFKDHHMLJH;
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/FX_Plasma");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 635f)
			{
				HBJJOCHGOPH = 1928f;
			}
			EOCCJGIGEGJ().SetFloat("Drop_Near", HBJJOCHGOPH);
			DONENAMLFLF().SetFloat(".save", ADPHJHEFAON);
			LDNADDJMIPK().SetVector(":", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 759f, 445f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FEHCNJLLJMP()
	{
		SCShader = Shader.Find("workshop.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JOACBIEHHCE()
	{
	}

	private void CGBHOELMAOC()
	{
	}

	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 463f)
			{
				HBJJOCHGOPH = 370f;
			}
			ACHNOHCLGOO().SetFloat("PLEASE WAIT", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat("w", ADPHJHEFAON);
			HCGJCMDJPGD().SetVector(": ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1443f, 539f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PAEGLMEOKHP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NNCCPEBIAKH()
	{
		SCShader = Shader.Find("[EditorEvent] Exception: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NDAJBJFJGCF()
	{
	}

	private void KDMKDEKCELE()
	{
		SCShader = Shader.Find("PLEASE WAIT");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1328f)
			{
				HBJJOCHGOPH = 292f;
			}
			EOCCJGIGEGJ().SetFloat("_TimeX", HBJJOCHGOPH);
			HEHKGPKLAKK().SetFloat("ERROR: preview file name is empty in modName.workshop.json", ADPHJHEFAON);
			OGMEGHKECAH().SetVector("<b>", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 35f, 1772f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GHHPOGODBHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material GJHLADDCMFF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-81);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material GHHPOGODBHB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 665f)
			{
				HBJJOCHGOPH = 1761f;
			}
			OGMEGHKECAH().SetFloat(" ", HBJJOCHGOPH);
			IIBLJCKLGFG().SetFloat("_Value3", ADPHJHEFAON);
			LDNADDJMIPK().SetVector(":\n", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1600f, 533f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JOPCCCCHNLI()
	{
		SCShader = Shader.Find("Offline or in OfflineMode. No VitalStats available.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 129f)
			{
				HBJJOCHGOPH = 1944f;
			}
			DONENAMLFLF().SetFloat("CameraFilterPack/TV_Artefact", HBJJOCHGOPH);
			IIBLJCKLGFG().SetFloat("Using constructor for new PingNativeDynamic()", ADPHJHEFAON);
			EOCCJGIGEGJ().SetVector("SetParticlesParticleSpeed", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 759f, 1595f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DNENFLNCIJP()
	{
	}

	private void PKLOBJHKFEO()
	{
		SCShader = Shader.Find("_FlipAlphaMask");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 316f)
			{
				HBJJOCHGOPH = 807f;
			}
			GHHPOGODBHB().SetFloat("Set Crosshair Color", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("Cant send PickupItem spawn times to unknown targetPlayer.", ADPHJHEFAON);
			JLHLHKPHDFO().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 725f, 857f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DONENAMLFLF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void Update()
	{
	}

	private void KLILJHJNICK()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DLMPALHKMON()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EPEGAEGDJAM()
	{
		SCShader = Shader.Find("workshop.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material IIBLJCKLGFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)94;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NFMGLIKNOOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)94;
		}
		return BJFKDHHMLJH;
	}

	private void DIPDEHOOBPG()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IBHACCEEFFI()
	{
	}

	private void ANCKKLFPGDI()
	{
		SCShader = Shader.Find("#E14FFF");
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
			if (HBJJOCHGOPH > 1404f)
			{
				HBJJOCHGOPH = 932f;
			}
			GHHPOGODBHB().SetFloat("Fade", HBJJOCHGOPH);
			IIBLJCKLGFG().SetFloat("Skipping region because it's not in PhotonServerSettings.EnabledRegions: ", ADPHJHEFAON);
			LONNIJMNKFB().SetVector("#discord{0}joinrequest", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 156f, 1067f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LBPHCAMMAPB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DKGBFNCOAEO()
	{
		SCShader = Shader.Find("Can't set MaxPlayers when not in that room.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 768f)
			{
				HBJJOCHGOPH = 386f;
			}
			HEHKGPKLAKK().SetFloat("_GreenAmplifier", HBJJOCHGOPH);
			LDNADDJMIPK().SetFloat("Tab2Content", ADPHJHEFAON);
			GHHPOGODBHB().SetVector("CompletedLevel", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1267f, 70f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LPMINJJPDCH()
	{
	}

	private void LADCJEIALMH()
	{
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
			if (HBJJOCHGOPH > 1072f)
			{
				HBJJOCHGOPH = 1080f;
			}
			GJHLADDCMFF().SetFloat("CameraFilterPack/FX_Glitch1", HBJJOCHGOPH);
			IIBLJCKLGFG().SetFloat("_ProjectionInv", ADPHJHEFAON);
			LDNADDJMIPK().SetVector(".completed", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1076f, 438f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AGMJDGHLBMN()
	{
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
			NBPKMLMCHFN.SetFloat("_Value", ADPHJHEFAON);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ICILLMAKLMI()
	{
		SCShader = Shader.Find(" not exist");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material EOCCJGIGEGJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return BJFKDHHMLJH;
	}

	private void MKIMDFLBFOM()
	{
		SCShader = Shader.Find("Tab2Content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LOMDIOLNFHI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GPNAOAKCMHC()
	{
		SCShader = Shader.Find("Jul");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
