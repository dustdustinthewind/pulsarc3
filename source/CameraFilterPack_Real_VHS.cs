// CameraFilterPack_Real_VHS
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/VHS/Real VHS HQ")]
public class CameraFilterPack_Real_VHS : MonoBehaviour
{
	public Shader SCShader;

	private Material BJFKDHHMLJH;

	private Texture2D EIJFCDJLEPB;

	private Texture2D JAFJKILGIKJ;

	[Range(0f, 1f)]
	public float TRACKING = 0.212f;

	[Range(0f, 1f)]
	public float JITTER = 1f;

	[Range(0f, 1f)]
	public float GLITCH = 1f;

	[Range(0f, 1f)]
	public float NOISE = 1f;

	[Range(-1f, 1f)]
	public float Brightness;

	[Range(0f, 1.5f)]
	public float Constrast = 1f;

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

	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			AELJLBOJAIL().SetTexture("_Red_G", EIJFCDJLEPB);
			DKNJGHFLAIF().SetTexture(".message", JAFJKILGIKJ);
			KOHGPKOFEJO().SetFloat("0.00", TRACKING);
			HNICHJCGJOC().SetFloat(" ", JITTER);
			KBOPGONOCNP().SetFloat("inventory.selected.", GLITCH);
			EHDJJANLINB().SetFloat("fade out duration", NOISE);
			MCDGIILBNIF().SetFloat("_Blue_B", Brightness);
			ACHNOHCLGOO().SetFloat("_ScreenResolution", 654f - Constrast);
			int width = 18;
			int height = 96;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			temporary.filterMode = (FilterMode)7;
			Graphics.Blit(AAACLELCPML, temporary, ACHNOHCLGOO());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EDBEHEKMGFH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KMKLDAJLCNM()
	{
	}

	private void JHLGHODFJOO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MAOCOEGAFND()
	{
	}

	[SpecialName]
	private Material ACHNOHCLGOO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HNICHJCGJOC().SetTexture("team", EIJFCDJLEPB);
			DKNJGHFLAIF().SetTexture("_TimeX", JAFJKILGIKJ);
			ACHNOHCLGOO().SetFloat("NEW_ACHIEVEMENT_1_26", TRACKING);
			DKNJGHFLAIF().SetFloat("Right Stick Click", JITTER);
			NBPKMLMCHFN.SetFloat(":", GLITCH);
			KBOPGONOCNP().SetFloat("#discord{0}joinrequest", NOISE);
			HNICHJCGJOC().SetFloat("_TimeX", Brightness);
			LENEJAGLCNL().SetFloat("_Value5", 816f - Constrast);
			int width = -96;
			int height = -170;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			temporary.filterMode = FilterMode.Trilinear;
			Graphics.Blit(AAACLELCPML, temporary, HEHKGPKLAKK());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material EHDJJANLINB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	public static Texture2D CBEEMEFFFCL(Texture2D LGILGCGIHHM, RenderTexture HIIBHBOMGLD, int EPLDGCDGCEF, int HOKPADCPFPM)
	{
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = HIIBHBOMGLD;
		LGILGCGIHHM.ReadPixels(new Rect(333f, 1189f, LGILGCGIHHM.width, LGILGCGIHHM.height), 0, 0);
		RenderTexture.active = active;
		return LGILGCGIHHM;
	}

	public static Texture2D KFKBEKKIOAC(Texture2D LGILGCGIHHM, RenderTexture HIIBHBOMGLD, int EPLDGCDGCEF, int HOKPADCPFPM)
	{
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = HIIBHBOMGLD;
		LGILGCGIHHM.ReadPixels(new Rect(1881f, 1545f, LGILGCGIHHM.width, LGILGCGIHHM.height), 1, 1);
		RenderTexture.active = active;
		return LGILGCGIHHM;
	}

	private void NNPBKKBFDHH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	public static Texture2D BPFMPEIKCBO(Texture2D LGILGCGIHHM, RenderTexture HIIBHBOMGLD, int EPLDGCDGCEF, int HOKPADCPFPM)
	{
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = HIIBHBOMGLD;
		LGILGCGIHHM.ReadPixels(new Rect(331f, 677f, LGILGCGIHHM.width, LGILGCGIHHM.height), 0, 0);
		RenderTexture.active = active;
		return LGILGCGIHHM;
	}

	private void ODAIMOJLJOF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	public static Texture2D HFLEMGJEGOJ(Texture2D LGILGCGIHHM, RenderTexture HIIBHBOMGLD, int EPLDGCDGCEF, int HOKPADCPFPM)
	{
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = HIIBHBOMGLD;
		LGILGCGIHHM.ReadPixels(new Rect(1003f, 1356f, LGILGCGIHHM.width, LGILGCGIHHM.height), 0, 1);
		RenderTexture.active = active;
		return LGILGCGIHHM;
	}

	private void JHJFBCFBKLD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	public static Texture2D KPIFOAMPJIG(Texture2D LGILGCGIHHM, RenderTexture HIIBHBOMGLD, int EPLDGCDGCEF, int HOKPADCPFPM)
	{
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = HIIBHBOMGLD;
		LGILGCGIHHM.ReadPixels(new Rect(198f, 78f, LGILGCGIHHM.width, LGILGCGIHHM.height), 0, 0);
		RenderTexture.active = active;
		return LGILGCGIHHM;
	}

	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			EHDJJANLINB().SetTexture("CameraFilterPack/Blend2Camera_Luminosity", EIJFCDJLEPB);
			DKNJGHFLAIF().SetTexture("_Value", JAFJKILGIKJ);
			AELJLBOJAIL().SetFloat("<b>", TRACKING);
			AELJLBOJAIL().SetFloat("#pleasewait", JITTER);
			DKNJGHFLAIF().SetFloat("pointBuffer", GLITCH);
			ACHNOHCLGOO().SetFloat("R2", NOISE);
			KBOPGONOCNP().SetFloat("SpectatingUserInfo", Brightness);
			DKNJGHFLAIF().SetFloat("_Offsets", 1333f - Constrast);
			int width = -86;
			int height = 134;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			temporary.filterMode = (FilterMode)8;
			Graphics.Blit(AAACLELCPML, temporary, HNICHJCGJOC());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JOACBIEHHCE()
	{
	}

	public static Texture2D LKDFDHPIHME(Texture2D LGILGCGIHHM, RenderTexture HIIBHBOMGLD, int EPLDGCDGCEF, int HOKPADCPFPM)
	{
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = HIIBHBOMGLD;
		LGILGCGIHHM.ReadPixels(new Rect(1513f, 118f, LGILGCGIHHM.width, LGILGCGIHHM.height), 1, 1);
		RenderTexture.active = active;
		return LGILGCGIHHM;
	}

	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			NBPKMLMCHFN.SetTexture("_TimeX", EIJFCDJLEPB);
			MCDGIILBNIF().SetTexture("offsets", JAFJKILGIKJ);
			AELJLBOJAIL().SetFloat("Reset XP", TRACKING);
			HEHKGPKLAKK().SetFloat("original.tutorial", JITTER);
			ACHNOHCLGOO().SetFloat("_TimeX", GLITCH);
			HEHKGPKLAKK().SetFloat("menutheme.27thfloor", NOISE);
			DKNJGHFLAIF().SetFloat("Operation ", Brightness);
			DKNJGHFLAIF().SetFloat("_Bullet_10", 114f - Constrast);
			int width = 121;
			int height = -39;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			temporary.filterMode = (FilterMode)7;
			Graphics.Blit(AAACLELCPML, temporary, AELJLBOJAIL());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	public static Texture2D PLNJPIAHEIF(Texture2D LGILGCGIHHM, RenderTexture HIIBHBOMGLD, int EPLDGCDGCEF, int HOKPADCPFPM)
	{
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = HIIBHBOMGLD;
		LGILGCGIHHM.ReadPixels(new Rect(601f, 1795f, LGILGCGIHHM.width, LGILGCGIHHM.height), 0, 1);
		RenderTexture.active = active;
		return LGILGCGIHHM;
	}

	private void KOJKBFDNGDK()
	{
		SCShader = Shader.Find("settings_bindings_controller_type");
		EIJFCDJLEPB = Resources.Load("_Value3") as Texture2D;
		JAFJKILGIKJ = Resources.Load("[DiscordController] Join ({0})") as Texture2D;
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material HNICHJCGJOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void FBPHNEJBDJN()
	{
		SCShader = Shader.Find("turn");
		EIJFCDJLEPB = Resources.Load("_threshold") as Texture2D;
		JAFJKILGIKJ = Resources.Load("CameraFilterPack/3D_Myst") as Texture2D;
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HDDECCMEJKA()
	{
	}

	public static Texture2D GOKCNCOJHOH(Texture2D LGILGCGIHHM, RenderTexture HIIBHBOMGLD, int EPLDGCDGCEF, int HOKPADCPFPM)
	{
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = HIIBHBOMGLD;
		LGILGCGIHHM.ReadPixels(new Rect(1497f, 1455f, LGILGCGIHHM.width, LGILGCGIHHM.height), 1, 1);
		RenderTexture.active = active;
		return LGILGCGIHHM;
	}

	private void KMEONPMCNJG()
	{
	}

	private void LGHCJCFHEMF()
	{
		SCShader = Shader.Find("ChatInput");
		EIJFCDJLEPB = Resources.Load("cancel") as Texture2D;
		JAFJKILGIKJ = Resources.Load(",") as Texture2D;
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material MCDGIILBNIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-117);
		}
		return BJFKDHHMLJH;
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Real_VHS");
		EIJFCDJLEPB = Resources.Load("CameraFilterPack_VHS1") as Texture2D;
		JAFJKILGIKJ = Resources.Load("CameraFilterPack_VHS2") as Texture2D;
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PHJJHFBLICM()
	{
	}

	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			NBPKMLMCHFN.SetTexture("_TimeX", EIJFCDJLEPB);
			DKNJGHFLAIF().SetTexture("settings_bindings_", JAFJKILGIKJ);
			KOHGPKOFEJO().SetFloat("ComboScoreText", TRACKING);
			EHDJJANLINB().SetFloat("_SubsampleIndices", JITTER);
			AELJLBOJAIL().SetFloat(".lastCheckpoint.penaltyScore", GLITCH);
			EHDJJANLINB().SetFloat(": ", NOISE);
			MCDGIILBNIF().SetFloat("inventory.selected.", Brightness);
			ACHNOHCLGOO().SetFloat("maps.", 1273f - Constrast);
			int width = 133;
			int height = 170;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			temporary.filterMode = FilterMode.Point;
			Graphics.Blit(AAACLELCPML, temporary, ACHNOHCLGOO());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AEOLJEIDMDB()
	{
		SCShader = Shader.Find("ConnectToMaster() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.");
		EIJFCDJLEPB = Resources.Load("EnableRankingToggle") as Texture2D;
		JAFJKILGIKJ = Resources.Load("_Saturation") as Texture2D;
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			NBPKMLMCHFN.SetTexture("/files/mods_terms.pdf", EIJFCDJLEPB);
			EHDJJANLINB().SetTexture(".lastCheckpoint.correctScore", JAFJKILGIKJ);
			KOHGPKOFEJO().SetFloat("InventoryButton", TRACKING);
			NBPKMLMCHFN.SetFloat("_Near", JITTER);
			KOHGPKOFEJO().SetFloat("SetEnvSpriteColor", GLITCH);
			NBPKMLMCHFN.SetFloat("Joystick1Button9", NOISE);
			NBPKMLMCHFN.SetFloat("_BlurVector", Brightness);
			NBPKMLMCHFN.SetFloat("AudioSampler", 1336f - Constrast);
			int width = -70;
			int height = 165;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			temporary.filterMode = (FilterMode)6;
			Graphics.Blit(AAACLELCPML, temporary, AELJLBOJAIL());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OPCLBGHAPMG()
	{
	}

	private void LCDJFJIBADI()
	{
	}

	private void FHGKIOOMMOH()
	{
		SCShader = Shader.Find("_ScreenResolution");
		EIJFCDJLEPB = Resources.Load("RarityImage") as Texture2D;
		JAFJKILGIKJ = Resources.Load("_Near") as Texture2D;
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LMADKINICIN()
	{
	}

	private void FJIKDJAMOHA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KIMMMCJFMAB()
	{
		SCShader = Shader.Find("Ev DestroyAll! By PlayerId: ");
		EIJFCDJLEPB = Resources.Load("mapselector.orderby") as Texture2D;
		JAFJKILGIKJ = Resources.Load("value") as Texture2D;
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			LENEJAGLCNL().SetTexture("Hidden/DepthOfField/BokehSplatting", EIJFCDJLEPB);
			KOHGPKOFEJO().SetTexture("settings.crosshairopacity", JAFJKILGIKJ);
			AELJLBOJAIL().SetFloat("workshop.", TRACKING);
			LENEJAGLCNL().SetFloat("The process failed: ", JITTER);
			KBOPGONOCNP().SetFloat("<color=#", GLITCH);
			NBPKMLMCHFN.SetFloat("maps.", NOISE);
			KOHGPKOFEJO().SetFloat("SpawnObj", Brightness);
			HNICHJCGJOC().SetFloat("X", 1122f - Constrast);
			int width = -114;
			int height = 0;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			temporary.filterMode = (FilterMode)4;
			Graphics.Blit(AAACLELCPML, temporary, DKNJGHFLAIF());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LBAJLLFMMMP()
	{
		SCShader = Shader.Find("_CenterX");
		EIJFCDJLEPB = Resources.Load("icon_border") as Texture2D;
		JAFJKILGIKJ = Resources.Load("PLEASE WAIT") as Texture2D;
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FDMAEPOHDMK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CFIAKIJAILI()
	{
	}

	private void LBIOIEANMGI()
	{
	}

	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			AELJLBOJAIL().SetTexture("Can't find key ", EIJFCDJLEPB);
			HNICHJCGJOC().SetTexture("_InvRenderTargetSize", JAFJKILGIKJ);
			DKNJGHFLAIF().SetFloat("_BorderSize", TRACKING);
			KBOPGONOCNP().SetFloat("DPADVER", JITTER);
			NBPKMLMCHFN.SetFloat("ResourceIDInputField", GLITCH);
			EHDJJANLINB().SetFloat("IncorrectHitsScoreText", NOISE);
			ACHNOHCLGOO().SetFloat("_Amount", Brightness);
			EHDJJANLINB().SetFloat("_MainTex2", 1816f - Constrast);
			int width = -33;
			int height = 105;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			temporary.filterMode = (FilterMode)3;
			Graphics.Blit(AAACLELCPML, temporary, ACHNOHCLGOO());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material AELJLBOJAIL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	public static Texture2D GetRTPixels(Texture2D LGILGCGIHHM, RenderTexture HIIBHBOMGLD, int EPLDGCDGCEF, int HOKPADCPFPM)
	{
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = HIIBHBOMGLD;
		LGILGCGIHHM.ReadPixels(new Rect(0f, 0f, LGILGCGIHHM.width, LGILGCGIHHM.height), 0, 0);
		RenderTexture.active = active;
		return LGILGCGIHHM;
	}

	private void LIEGJOHINGC()
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
			NBPKMLMCHFN.SetTexture("_SampleDistance", EIJFCDJLEPB);
			AELJLBOJAIL().SetTexture("MapperNameText", JAFJKILGIKJ);
			NBPKMLMCHFN.SetFloat("_EmissionGain", TRACKING);
			HNICHJCGJOC().SetFloat("_Value4", JITTER);
			HEHKGPKLAKK().SetFloat("CameraFilterPack/TV_ARCADE_2", GLITCH);
			HEHKGPKLAKK().SetFloat("_Value2", NOISE);
			DKNJGHFLAIF().SetFloat("_ScreenResolution", Brightness);
			ACHNOHCLGOO().SetFloat("action", 774f - Constrast);
			int width = 1;
			int height = 108;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			temporary.filterMode = FilterMode.Trilinear;
			Graphics.Blit(AAACLELCPML, temporary, AELJLBOJAIL());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
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

	private void FJHFOBHJEHL()
	{
	}

	private void PKHPNHBEKHA()
	{
	}

	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HEHKGPKLAKK().SetTexture("_Distortion", EIJFCDJLEPB);
			DKNJGHFLAIF().SetTexture("Sets the boolean value of the Auto Focus Input Field property.", JAFJKILGIKJ);
			DKNJGHFLAIF().SetFloat(" SphereWaveform.cs", TRACKING);
			NBPKMLMCHFN.SetFloat("_TimeX", JITTER);
			LENEJAGLCNL().SetFloat("_Value2", GLITCH);
			KBOPGONOCNP().SetFloat("OpJoinLobby()", NOISE);
			EHDJJANLINB().SetFloat("HandsCountSlider", Brightness);
			LENEJAGLCNL().SetFloat("/", 1191f - Constrast);
			int width = 155;
			int height = -62;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			temporary.filterMode = FilterMode.Trilinear;
			Graphics.Blit(AAACLELCPML, temporary, HNICHJCGJOC());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
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
			NBPKMLMCHFN.SetTexture("Joystick1Button", EIJFCDJLEPB);
			EHDJJANLINB().SetTexture("FinalScoreText", JAFJKILGIKJ);
			NBPKMLMCHFN.SetFloat("SpawnObj", TRACKING);
			KOHGPKOFEJO().SetFloat("[PlayerController] ", JITTER);
			AELJLBOJAIL().SetFloat("menu.selectedplaymode", GLITCH);
			NBPKMLMCHFN.SetFloat("_Radius2", NOISE);
			LENEJAGLCNL().SetFloat("/?page=ranks", Brightness);
			KBOPGONOCNP().SetFloat("_Blue_C", 970f - Constrast);
			int width = 139;
			int height = 35;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			temporary.filterMode = FilterMode.Bilinear;
			Graphics.Blit(AAACLELCPML, temporary, DKNJGHFLAIF());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EJJEDJIOFAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	public static Texture2D AJHJDJLIKAK(Texture2D LGILGCGIHHM, RenderTexture HIIBHBOMGLD, int EPLDGCDGCEF, int HOKPADCPFPM)
	{
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = HIIBHBOMGLD;
		LGILGCGIHHM.ReadPixels(new Rect(1568f, 317f, LGILGCGIHHM.width, LGILGCGIHHM.height), 0, 0);
		RenderTexture.active = active;
		return LGILGCGIHHM;
	}

	private void KOFAMEKHHGD()
	{
		SCShader = Shader.Find("#ok");
		EIJFCDJLEPB = Resources.Load("Mask texture not readable, set your sprite to Texture Type 'Advanced' and check 'Read/Write Enabled'") as Texture2D;
		JAFJKILGIKJ = Resources.Load("< true | false >") as Texture2D;
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

	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			MCDGIILBNIF().SetTexture("player.quantum", EIJFCDJLEPB);
			LENEJAGLCNL().SetTexture("gameVolume", JAFJKILGIKJ);
			KOHGPKOFEJO().SetFloat("DifficultyBG", TRACKING);
			NBPKMLMCHFN.SetFloat("_Value2", JITTER);
			KBOPGONOCNP().SetFloat("FileMenu", GLITCH);
			HEHKGPKLAKK().SetFloat("<color=#{0}>{1}</color>", NOISE);
			NBPKMLMCHFN.SetFloat("Need to specify a start index and end index.", Brightness);
			KBOPGONOCNP().SetFloat("End index must in an integer.", 1001f - Constrast);
			int width = 85;
			int height = 181;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			temporary.filterMode = (FilterMode)7;
			Graphics.Blit(AAACLELCPML, temporary, HEHKGPKLAKK());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	public static Texture2D DIKKBBNDOPD(Texture2D LGILGCGIHHM, RenderTexture HIIBHBOMGLD, int EPLDGCDGCEF, int HOKPADCPFPM)
	{
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = HIIBHBOMGLD;
		LGILGCGIHHM.ReadPixels(new Rect(415f, 130f, LGILGCGIHHM.width, LGILGCGIHHM.height), 0, 0);
		RenderTexture.active = active;
		return LGILGCGIHHM;
	}

	public static Texture2D HNOBPNCADNN(Texture2D LGILGCGIHHM, RenderTexture HIIBHBOMGLD, int EPLDGCDGCEF, int HOKPADCPFPM)
	{
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = HIIBHBOMGLD;
		LGILGCGIHHM.ReadPixels(new Rect(298f, 207f, LGILGCGIHHM.width, LGILGCGIHHM.height), 0, 1);
		RenderTexture.active = active;
		return LGILGCGIHHM;
	}

	private void KCCIEMBMOBA()
	{
		SCShader = Shader.Find("Set Sun MinSize");
		EIJFCDJLEPB = Resources.Load("_Value4") as Texture2D;
		JAFJKILGIKJ = Resources.Load("CameraFilterPack/Blend2Camera_Divide") as Texture2D;
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			DKNJGHFLAIF().SetTexture("_TimeX", EIJFCDJLEPB);
			EHDJJANLINB().SetTexture("_Red_B", JAFJKILGIKJ);
			DKNJGHFLAIF().SetFloat("_Intensity", TRACKING);
			DKNJGHFLAIF().SetFloat("VisionBlur", JITTER);
			AELJLBOJAIL().SetFloat("BitsData", GLITCH);
			ACHNOHCLGOO().SetFloat("Editor", NOISE);
			KOHGPKOFEJO().SetFloat("[Left]", Brightness);
			NBPKMLMCHFN.SetFloat(" cannot be used as a 3D LUT.", 512f - Constrast);
			int width = 185;
			int height = 113;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			temporary.filterMode = FilterMode.Bilinear;
			Graphics.Blit(AAACLELCPML, temporary, EHDJJANLINB());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			NBPKMLMCHFN.SetTexture("Set satellite radius (offset)", EIJFCDJLEPB);
			KBOPGONOCNP().SetTexture("Failed to InstantiateSceneObject prefab: ", JAFJKILGIKJ);
			KOHGPKOFEJO().SetFloat("_Offsets", TRACKING);
			KBOPGONOCNP().SetFloat("In Main Menu", JITTER);
			ACHNOHCLGOO().SetFloat(" respawn: ", GLITCH);
			AELJLBOJAIL().SetFloat("_Offsets", NOISE);
			KOHGPKOFEJO().SetFloat("maps.", Brightness);
			EHDJJANLINB().SetFloat("_Offsets", 825f - Constrast);
			int width = -192;
			int height = -176;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			temporary.filterMode = (FilterMode)6;
			Graphics.Blit(AAACLELCPML, temporary, KOHGPKOFEJO());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			LENEJAGLCNL().SetTexture("_ScreenResolution", EIJFCDJLEPB);
			LENEJAGLCNL().SetTexture("settings.arcsdestroydelay", JAFJKILGIKJ);
			LENEJAGLCNL().SetFloat("closed", TRACKING);
			EHDJJANLINB().SetFloat("SetSatelliteTrailLength", JITTER);
			AELJLBOJAIL().SetFloat("Hidden/DepthOfField/MedianFilter", GLITCH);
			AELJLBOJAIL().SetFloat("player.playedtutorial", NOISE);
			EHDJJANLINB().SetFloat("RecieveChatMessage", Brightness);
			DKNJGHFLAIF().SetFloat("MenuScene", 657f - Constrast);
			int width = 21;
			int height = -41;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			temporary.filterMode = (FilterMode)4;
			Graphics.Blit(AAACLELCPML, temporary, HNICHJCGJOC());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BMODOIJGIOO()
	{
	}

	private void FANADGBGCPI()
	{
		SCShader = Shader.Find("_ScreenResolution");
		EIJFCDJLEPB = Resources.Load("_Value4") as Texture2D;
		JAFJKILGIKJ = Resources.Load(" respawn: ") as Texture2D;
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	public static Texture2D KKFKBIHNAKM(Texture2D LGILGCGIHHM, RenderTexture HIIBHBOMGLD, int EPLDGCDGCEF, int HOKPADCPFPM)
	{
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = HIIBHBOMGLD;
		LGILGCGIHHM.ReadPixels(new Rect(1770f, 529f, LGILGCGIHHM.width, LGILGCGIHHM.height), 0, 0);
		RenderTexture.active = active;
		return LGILGCGIHHM;
	}

	private void CKCPPNHANAA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			KBOPGONOCNP().SetTexture("_Value", EIJFCDJLEPB);
			KOHGPKOFEJO().SetTexture("note.5", JAFJKILGIKJ);
			KOHGPKOFEJO().SetFloat("_ScreenResolution", TRACKING);
			KBOPGONOCNP().SetFloat("[PlayerController] ", JITTER);
			HNICHJCGJOC().SetFloat("_TimeX", GLITCH);
			KOHGPKOFEJO().SetFloat("_TapHigh", NOISE);
			HEHKGPKLAKK().SetFloat("0", Brightness);
			KOHGPKOFEJO().SetFloat("OK", 1334f - Constrast);
			int width = -192;
			int height = -106;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			temporary.filterMode = (FilterMode)7;
			Graphics.Blit(AAACLELCPML, temporary, KBOPGONOCNP());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MPJCMKFFKHH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			MCDGIILBNIF().SetTexture("PossibleMapPointsText", EIJFCDJLEPB);
			EHDJJANLINB().SetTexture("_MainTex2", JAFJKILGIKJ);
			ACHNOHCLGOO().SetFloat("Crosshair2", TRACKING);
			HNICHJCGJOC().SetFloat("RT", JITTER);
			LENEJAGLCNL().SetFloat("GameMessagesDurationSlider", GLITCH);
			HEHKGPKLAKK().SetFloat("_Value4", NOISE);
			HEHKGPKLAKK().SetFloat("_TimeX", Brightness);
			EHDJJANLINB().SetFloat("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception", 1144f - Constrast);
			int width = 7;
			int height = 178;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			temporary.filterMode = (FilterMode)8;
			Graphics.Blit(AAACLELCPML, temporary, HNICHJCGJOC());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HEHKGPKLAKK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)106;
		}
		return BJFKDHHMLJH;
	}

	public static Texture2D ALGEMPDDLDC(Texture2D LGILGCGIHHM, RenderTexture HIIBHBOMGLD, int EPLDGCDGCEF, int HOKPADCPFPM)
	{
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = HIIBHBOMGLD;
		LGILGCGIHHM.ReadPixels(new Rect(33f, 1683f, LGILGCGIHHM.width, LGILGCGIHHM.height), 0, 0);
		RenderTexture.active = active;
		return LGILGCGIHHM;
	}

	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			ACHNOHCLGOO().SetTexture(". Set PhotonNetwork.OnEventCall.", EIJFCDJLEPB);
			AELJLBOJAIL().SetTexture("player.currentrank", JAFJKILGIKJ);
			KOHGPKOFEJO().SetFloat("AddEnvironmentObject", TRACKING);
			LENEJAGLCNL().SetFloat("_MainTex2", JITTER);
			KOHGPKOFEJO().SetFloat("CameraFilterPack/Gradients_Rainbow", GLITCH);
			EHDJJANLINB().SetFloat("#forever", NOISE);
			EHDJJANLINB().SetFloat("_Params1", Brightness);
			KOHGPKOFEJO().SetFloat("_Value2", 652f - Constrast);
			int width = 145;
			int height = 128;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			temporary.filterMode = (FilterMode)5;
			Graphics.Blit(AAACLELCPML, temporary, NBPKMLMCHFN);
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BEBNOKFLJPH()
	{
		SCShader = Shader.Find("steamid");
		EIJFCDJLEPB = Resources.Load("finished") as Texture2D;
		JAFJKILGIKJ = Resources.Load("move") as Texture2D;
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	public static Texture2D FOFFKKAKHLK(Texture2D LGILGCGIHHM, RenderTexture HIIBHBOMGLD, int EPLDGCDGCEF, int HOKPADCPFPM)
	{
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = HIIBHBOMGLD;
		LGILGCGIHHM.ReadPixels(new Rect(1363f, 1310f, LGILGCGIHHM.width, LGILGCGIHHM.height), 0, 1);
		RenderTexture.active = active;
		return LGILGCGIHHM;
	}

	private void MMMDPANNAIO()
	{
		SCShader = Shader.Find("_Value10");
		EIJFCDJLEPB = Resources.Load("_Green_G") as Texture2D;
		JAFJKILGIKJ = Resources.Load("DifficultyBG") as Texture2D;
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	public static Texture2D GKOFFOOKEIH(Texture2D LGILGCGIHHM, RenderTexture HIIBHBOMGLD, int EPLDGCDGCEF, int HOKPADCPFPM)
	{
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = HIIBHBOMGLD;
		LGILGCGIHHM.ReadPixels(new Rect(1702f, 464f, LGILGCGIHHM.width, LGILGCGIHHM.height), 0, 1);
		RenderTexture.active = active;
		return LGILGCGIHHM;
	}

	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			NBPKMLMCHFN.SetTexture("VHS", EIJFCDJLEPB);
			NBPKMLMCHFN.SetTexture("VHS2", JAFJKILGIKJ);
			NBPKMLMCHFN.SetFloat("TRACKING", TRACKING);
			NBPKMLMCHFN.SetFloat("JITTER", JITTER);
			NBPKMLMCHFN.SetFloat("GLITCH", GLITCH);
			NBPKMLMCHFN.SetFloat("NOISE", NOISE);
			NBPKMLMCHFN.SetFloat("Brightness", Brightness);
			NBPKMLMCHFN.SetFloat("CONTRAST", 1f - Constrast);
			int width = 382;
			int height = 576;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			temporary.filterMode = FilterMode.Trilinear;
			Graphics.Blit(AAACLELCPML, temporary, NBPKMLMCHFN);
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OHFOLGANOLC()
	{
		SCShader = Shader.Find("PLEASE WAIT");
		EIJFCDJLEPB = Resources.Load("CameraFilterPack/Color_Sepia") as Texture2D;
		JAFJKILGIKJ = Resources.Load("Warning, using scrollbors with the Scroll Snap controls is not advised as it causes unpredictable results") as Texture2D;
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PBEPCAPAKLG()
	{
	}

	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			NBPKMLMCHFN.SetTexture("Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. ", EIJFCDJLEPB);
			ACHNOHCLGOO().SetTexture("[MenuScene] Error: ", JAFJKILGIKJ);
			KBOPGONOCNP().SetFloat("GetLive", TRACKING);
			DKNJGHFLAIF().SetFloat("menu.enableselectormusic", JITTER);
			ACHNOHCLGOO().SetFloat("Default UI Material", GLITCH);
			KOHGPKOFEJO().SetFloat("UI Extensions/UIScreen", NOISE);
			AELJLBOJAIL().SetFloat("End Value should be greater than the start value, values not changed", Brightness);
			ACHNOHCLGOO().SetFloat("settings.crosshairopacity", 1430f - Constrast);
			int width = 173;
			int height = 0;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			temporary.filterMode = (FilterMode)4;
			Graphics.Blit(AAACLELCPML, temporary, ACHNOHCLGOO());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			MCDGIILBNIF().SetTexture("_ChannelMixerGreen", EIJFCDJLEPB);
			HEHKGPKLAKK().SetTexture("_Value3", JAFJKILGIKJ);
			KBOPGONOCNP().SetFloat("_ScreenResolution", TRACKING);
			KOHGPKOFEJO().SetFloat(" is set to dontSave = true, continuing loop.", JITTER);
			EHDJJANLINB().SetFloat("_Value3", GLITCH);
			HNICHJCGJOC().SetFloat("CameraFilterPack/Noise_TV_3", NOISE);
			MCDGIILBNIF().SetFloat("_ColorLevel", Brightness);
			LENEJAGLCNL().SetFloat("DifficultyBG", 722f - Constrast);
			int width = 142;
			int height = -28;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			temporary.filterMode = (FilterMode)5;
			Graphics.Blit(AAACLELCPML, temporary, HEHKGPKLAKK());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			KBOPGONOCNP().SetTexture("settings.shaders.bloomintencity", EIJFCDJLEPB);
			NBPKMLMCHFN.SetTexture(" #", JAFJKILGIKJ);
			MCDGIILBNIF().SetFloat(" ", TRACKING);
			KBOPGONOCNP().SetFloat(".status", JITTER);
			LENEJAGLCNL().SetFloat("PunRespawn", GLITCH);
			HNICHJCGJOC().SetFloat("_TimeX", NOISE);
			HEHKGPKLAKK().SetFloat("_Value5", Brightness);
			AELJLBOJAIL().SetFloat("ACCEPT", 1873f - Constrast);
			int width = -145;
			int height = 199;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			temporary.filterMode = (FilterMode)5;
			Graphics.Blit(AAACLELCPML, temporary, ACHNOHCLGOO());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-106);
		}
		return BJFKDHHMLJH;
	}

	public static Texture2D EFBGDKGGCCD(Texture2D LGILGCGIHHM, RenderTexture HIIBHBOMGLD, int EPLDGCDGCEF, int HOKPADCPFPM)
	{
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = HIIBHBOMGLD;
		LGILGCGIHHM.ReadPixels(new Rect(1245f, 1372f, LGILGCGIHHM.width, LGILGCGIHHM.height), 0, 1);
		RenderTexture.active = active;
		return LGILGCGIHHM;
	}

	private void GJAJBMGGPFB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material DKNJGHFLAIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-83);
		}
		return BJFKDHHMLJH;
	}

	private void CPAJLKHMOJB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OBAEDJJDCPN()
	{
	}

	private void FJNCHGLIEMA()
	{
		SCShader = Shader.Find("YES");
		EIJFCDJLEPB = Resources.Load("Gameplay/sun") as Texture2D;
		JAFJKILGIKJ = Resources.Load("_Value2") as Texture2D;
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DFFKKLAPHCC()
	{
		SCShader = Shader.Find("Aimer Input Module is incompatible with the StandAloneInputSystem, please remove it from the Event System in this scene or disable it when this module is in use");
		EIJFCDJLEPB = Resources.Load("_Value2") as Texture2D;
		JAFJKILGIKJ = Resources.Load("color") as Texture2D;
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material KOHGPKOFEJO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material LENEJAGLCNL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			NBPKMLMCHFN.SetTexture("COMPLETED", EIJFCDJLEPB);
			DKNJGHFLAIF().SetTexture("_Value4", JAFJKILGIKJ);
			ACHNOHCLGOO().SetFloat("CameraFilterPack/Blend2Camera_Darken", TRACKING);
			LENEJAGLCNL().SetFloat("FreqVolume: ", JITTER);
			KBOPGONOCNP().SetFloat("CameraFilterPack/Pixelisation_OilPaint", GLITCH);
			AELJLBOJAIL().SetFloat("#obtained", NOISE);
			ACHNOHCLGOO().SetFloat("BadgeText", Brightness);
			ACHNOHCLGOO().SetFloat("menu.tabid", 926f - Constrast);
			int width = -69;
			int height = -150;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			temporary.filterMode = (FilterMode)6;
			Graphics.Blit(AAACLELCPML, temporary, DKNJGHFLAIF());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
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
			KOHGPKOFEJO().SetTexture("_Value1", EIJFCDJLEPB);
			LENEJAGLCNL().SetTexture("Sets the boolean value of the Auto Focus Input Field property.", JAFJKILGIKJ);
			AELJLBOJAIL().SetFloat("Editor", TRACKING);
			DKNJGHFLAIF().SetFloat("UseScanLine", JITTER);
			ACHNOHCLGOO().SetFloat("HiddenToggle", GLITCH);
			AELJLBOJAIL().SetFloat("CameraFilterPack/Gradients_Therma", NOISE);
			LENEJAGLCNL().SetFloat("MapEnd", Brightness);
			EHDJJANLINB().SetFloat("CameraFilterPack/Edge_Golden", 1825f - Constrast);
			int width = -89;
			int height = -69;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			temporary.filterMode = FilterMode.Trilinear;
			Graphics.Blit(AAACLELCPML, temporary, HNICHJCGJOC());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
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

	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			KOHGPKOFEJO().SetTexture("inventory.selected.", EIJFCDJLEPB);
			NBPKMLMCHFN.SetTexture("_Value", JAFJKILGIKJ);
			LENEJAGLCNL().SetFloat("_Value2", TRACKING);
			NBPKMLMCHFN.SetFloat("_Value4", JITTER);
			HNICHJCGJOC().SetFloat("Hex value #RRGGBB", GLITCH);
			ACHNOHCLGOO().SetFloat("23x3", NOISE);
			MCDGIILBNIF().SetFloat("_DotSize", Brightness);
			HNICHJCGJOC().SetFloat(".highscore", 620f - Constrast);
			int width = 100;
			int height = -19;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			temporary.filterMode = (FilterMode)4;
			Graphics.Blit(AAACLELCPML, temporary, ACHNOHCLGOO());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
