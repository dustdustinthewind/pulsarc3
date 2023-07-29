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
			NBPKMLMCHFN.SetTexture("_Red_B", EIJFCDJLEPB);
			AELJLBOJAIL().SetTexture(".message", JAFJKILGIKJ);
			HNICHJCGJOC().SetFloat("--------------------------------", TRACKING);
			DKNJGHFLAIF().SetFloat("%", JITTER);
			ACHNOHCLGOO().SetFloat("LoadingStatusText", GLITCH);
			MCDGIILBNIF().SetFloat("fade out duration", NOISE);
			ACHNOHCLGOO().SetFloat("_Red_C", Brightness);
			AELJLBOJAIL().SetFloat("_ScreenResolution", 654f - Constrast);
			int width = 18;
			int height = 96;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			temporary.filterMode = (FilterMode)7;
			Graphics.Blit(AAACLELCPML, temporary, LENEJAGLCNL());
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
			MCDGIILBNIF().SetTexture("turn", EIJFCDJLEPB);
			KOHGPKOFEJO().SetTexture("_TimeX", JAFJKILGIKJ);
			HNICHJCGJOC().SetFloat("NEW_ACHIEVEMENT_1_26", TRACKING);
			KBOPGONOCNP().SetFloat("PS Home", JITTER);
			AELJLBOJAIL().SetFloat("Reconnect() failed. Can only connect while in state 'Disconnected'. Current state: ", GLITCH);
			MCDGIILBNIF().SetFloat("#yes", NOISE);
			DKNJGHFLAIF().SetFloat("_Value", Brightness);
			HEHKGPKLAKK().SetFloat("_MainTex2", 816f - Constrast);
			int width = -96;
			int height = -170;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			temporary.filterMode = FilterMode.Trilinear;
			Graphics.Blit(AAACLELCPML, temporary, KOHGPKOFEJO());
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
			LENEJAGLCNL().SetTexture("CameraFilterPack/Blend2Camera_Luminosity", EIJFCDJLEPB);
			KBOPGONOCNP().SetTexture("_Value", JAFJKILGIKJ);
			ACHNOHCLGOO().SetFloat(":</b> ", TRACKING);
			MCDGIILBNIF().SetFloat("#pleasewait", JITTER);
			HEHKGPKLAKK().SetFloat("_Screen", GLITCH);
			EHDJJANLINB().SetFloat("Select", NOISE);
			KBOPGONOCNP().SetFloat("AvatarImage", Brightness);
			LENEJAGLCNL().SetFloat("_Offsets", 1333f - Constrast);
			int width = -86;
			int height = 134;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			temporary.filterMode = (FilterMode)8;
			Graphics.Blit(AAACLELCPML, temporary, DKNJGHFLAIF());
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
			AELJLBOJAIL().SetTexture("_TimeX", EIJFCDJLEPB);
			AELJLBOJAIL().SetTexture("offsets", JAFJKILGIKJ);
			NBPKMLMCHFN.SetFloat("Reload Maps", TRACKING);
			MCDGIILBNIF().SetFloat("menu.playedsolo", JITTER);
			KBOPGONOCNP().SetFloat("_Value", GLITCH);
			KOHGPKOFEJO().SetFloat("menutheme.27thfloor", NOISE);
			KBOPGONOCNP().SetFloat("Operation ", Brightness);
			DKNJGHFLAIF().SetFloat("_Bullet_11", 114f - Constrast);
			int width = 121;
			int height = -39;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			temporary.filterMode = (FilterMode)7;
			Graphics.Blit(AAACLELCPML, temporary, LENEJAGLCNL());
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
		EIJFCDJLEPB = Resources.Load("_Value4") as Texture2D;
		JAFJKILGIKJ = Resources.Load("[DiscordController] Join request {0}#{1}: {2}") as Texture2D;
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
		SCShader = Shader.Find("move");
		EIJFCDJLEPB = Resources.Load("offsets") as Texture2D;
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
		SCShader = Shader.Find("Chat");
		EIJFCDJLEPB = Resources.Load("cancel") as Texture2D;
		JAFJKILGIKJ = Resources.Load("}") as Texture2D;
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
			HEHKGPKLAKK().SetTexture("settings_bindings_sec_", JAFJKILGIKJ);
			KBOPGONOCNP().SetFloat("ComboScoreText", TRACKING);
			HEHKGPKLAKK().SetFloat("USE_PREDICATION", JITTER);
			AELJLBOJAIL().SetFloat(".lastCheckpoint.playerdistance", GLITCH);
			ACHNOHCLGOO().SetFloat(" not exist", NOISE);
			HNICHJCGJOC().SetFloat("inventory.selected.", Brightness);
			EHDJJANLINB().SetFloat("maps.", 1273f - Constrast);
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
		SCShader = Shader.Find("Reconnect() failed. It seems the client wasn't connected before?! Current state: ");
		EIJFCDJLEPB = Resources.Load("EnableRankingToggle") as Texture2D;
		JAFJKILGIKJ = Resources.Load("_Offsets") as Texture2D;
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			AELJLBOJAIL().SetTexture("/files/mods_terms.pdf", EIJFCDJLEPB);
			HEHKGPKLAKK().SetTexture(".lastCheckpoint.checkpointsUsed", JAFJKILGIKJ);
			NBPKMLMCHFN.SetFloat("InventoryButton", TRACKING);
			NBPKMLMCHFN.SetFloat("_Near", JITTER);
			KBOPGONOCNP().SetFloat(" not exist", GLITCH);
			AELJLBOJAIL().SetFloat("Options", NOISE);
			AELJLBOJAIL().SetFloat("_BlurVector", Brightness);
			HNICHJCGJOC().SetFloat("AudioSampler", 1336f - Constrast);
			int width = -70;
			int height = 165;
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

	private void OPCLBGHAPMG()
	{
	}

	private void LCDJFJIBADI()
	{
	}

	private void FHGKIOOMMOH()
	{
		SCShader = Shader.Find("_ScreenResolution");
		EIJFCDJLEPB = Resources.Load("rarity") as Texture2D;
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
		SCShader = Shader.Find(". Sent by actorNr: ");
		EIJFCDJLEPB = Resources.Load("mapselector.orderby") as Texture2D;
		JAFJKILGIKJ = Resources.Load("float,0") as Texture2D;
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			AELJLBOJAIL().SetTexture("_BlurParams", EIJFCDJLEPB);
			HNICHJCGJOC().SetTexture("settings.gamemessagesduration", JAFJKILGIKJ);
			HEHKGPKLAKK().SetFloat("[MapsSystem] Unloading maps resources...", TRACKING);
			MCDGIILBNIF().SetFloat("/Saved Games/", JITTER);
			KBOPGONOCNP().SetFloat(">", GLITCH);
			LENEJAGLCNL().SetFloat("maps.", NOISE);
			HEHKGPKLAKK().SetFloat("SpawnObj", Brightness);
			ACHNOHCLGOO().SetFloat("A", 1122f - Constrast);
			int width = -114;
			int height = 0;
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

	private void LBAJLLFMMMP()
	{
		SCShader = Shader.Find("_CenterY");
		EIJFCDJLEPB = Resources.Load("white") as Texture2D;
		JAFJKILGIKJ = Resources.Load("Uploading content") as Texture2D;
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
			DKNJGHFLAIF().SetTexture("r", EIJFCDJLEPB);
			AELJLBOJAIL().SetTexture("_MainTex", JAFJKILGIKJ);
			DKNJGHFLAIF().SetFloat("_BorderSize", TRACKING);
			AELJLBOJAIL().SetFloat("DPADHOR", JITTER);
			MCDGIILBNIF().SetFloat("ResourceIDInputField", GLITCH);
			KOHGPKOFEJO().SetFloat("IncorrectHitsScoreText", NOISE);
			EHDJJANLINB().SetFloat("_MainTex2", Brightness);
			KBOPGONOCNP().SetFloat("CameraFilterPack_OldFilm2", 1816f - Constrast);
			int width = -33;
			int height = 105;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			temporary.filterMode = (FilterMode)3;
			Graphics.Blit(AAACLELCPML, temporary, NBPKMLMCHFN);
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
			AELJLBOJAIL().SetTexture("_Exponent", EIJFCDJLEPB);
			KOHGPKOFEJO().SetTexture("UpdateDownloadingProgress", JAFJKILGIKJ);
			KBOPGONOCNP().SetFloat("_EmissionGain", TRACKING);
			ACHNOHCLGOO().SetFloat("_ScreenResolution", JITTER);
			HEHKGPKLAKK().SetFloat("_TimeX", GLITCH);
			EHDJJANLINB().SetFloat("_Value3", NOISE);
			HNICHJCGJOC().SetFloat("_ScreenResolution", Brightness);
			DKNJGHFLAIF().SetFloat("[SoundManager] Loaded skin audio", 774f - Constrast);
			int width = 1;
			int height = 108;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			temporary.filterMode = FilterMode.Trilinear;
			Graphics.Blit(AAACLELCPML, temporary, LENEJAGLCNL());
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
			DKNJGHFLAIF().SetTexture("_ScreenResolution", EIJFCDJLEPB);
			EHDJJANLINB().SetTexture("scenes", JAFJKILGIKJ);
			HNICHJCGJOC().SetFloat(" SphereWaveform.cs", TRACKING);
			ACHNOHCLGOO().SetFloat("Fade", JITTER);
			DKNJGHFLAIF().SetFloat("_Value3", GLITCH);
			HNICHJCGJOC().SetFloat("OpCreateRoom()", NOISE);
			EHDJJANLINB().SetFloat("HandsCountSlider", Brightness);
			HEHKGPKLAKK().SetFloat("/", 1191f - Constrast);
			int width = 155;
			int height = -62;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			temporary.filterMode = FilterMode.Trilinear;
			Graphics.Blit(AAACLELCPML, temporary, EHDJJANLINB());
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
			HNICHJCGJOC().SetTexture("_Value1", EIJFCDJLEPB);
			LENEJAGLCNL().SetTexture("FinalScoreText", JAFJKILGIKJ);
			NBPKMLMCHFN.SetFloat("PlayerBase_", TRACKING);
			MCDGIILBNIF().SetFloat(": ", JITTER);
			MCDGIILBNIF().SetFloat("menu.relaxinfo", GLITCH);
			MCDGIILBNIF().SetFloat("_BlurFilterDistance", NOISE);
			KOHGPKOFEJO().SetFloat("Search: ", Brightness);
			ACHNOHCLGOO().SetFloat("_Blue_C", 970f - Constrast);
			int width = 139;
			int height = 35;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			temporary.filterMode = FilterMode.Bilinear;
			Graphics.Blit(AAACLELCPML, temporary, HEHKGPKLAKK());
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
		EIJFCDJLEPB = Resources.Load("UI Extensions/UIAdditive") as Texture2D;
		JAFJKILGIKJ = Resources.Load("scenes") as Texture2D;
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
			AELJLBOJAIL().SetTexture("player.quantum", EIJFCDJLEPB);
			NBPKMLMCHFN.SetTexture("menuVolume", JAFJKILGIKJ);
			DKNJGHFLAIF().SetFloat("InfoText", TRACKING);
			ACHNOHCLGOO().SetFloat("_Value2", JITTER);
			HEHKGPKLAKK().SetFloat("[MapEditor] Updating top menu", GLITCH);
			AELJLBOJAIL().SetFloat("Game Version: ", NOISE);
			HEHKGPKLAKK().SetFloat("Start index must in an integer.", Brightness);
			AELJLBOJAIL().SetFloat("Please specify either t or f.", 1001f - Constrast);
			int width = 85;
			int height = 181;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			temporary.filterMode = (FilterMode)7;
			Graphics.Blit(AAACLELCPML, temporary, EHDJJANLINB());
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
		EIJFCDJLEPB = Resources.Load("_ScreenResolution") as Texture2D;
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
			HNICHJCGJOC().SetTexture("_TimeX", EIJFCDJLEPB);
			LENEJAGLCNL().SetTexture("_Green_R", JAFJKILGIKJ);
			HNICHJCGJOC().SetFloat("_VignetteTex", TRACKING);
			KOHGPKOFEJO().SetFloat("GlassDistortion", JITTER);
			KOHGPKOFEJO().SetFloat("BitsData", GLITCH);
			HNICHJCGJOC().SetFloat("[MapEditor] Importing map: ", NOISE);
			DKNJGHFLAIF().SetFloat("[PlayerBase] Starting new round", Brightness);
			KOHGPKOFEJO().SetFloat("_Blend", 512f - Constrast);
			int width = 185;
			int height = 113;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			temporary.filterMode = FilterMode.Bilinear;
			Graphics.Blit(AAACLELCPML, temporary, KBOPGONOCNP());
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
			AELJLBOJAIL().SetTexture("Set satellite radius (offset)", EIJFCDJLEPB);
			NBPKMLMCHFN.SetTexture(". Client is not the MasterClient in this room.", JAFJKILGIKJ);
			AELJLBOJAIL().SetFloat("_Offsets", TRACKING);
			KOHGPKOFEJO().SetFloat("In Main Menu", JITTER);
			MCDGIILBNIF().SetFloat("ViewID {0} {1}{2}", GLITCH);
			KOHGPKOFEJO().SetFloat("_SecondTex", NOISE);
			LENEJAGLCNL().SetFloat("maps.", Brightness);
			HEHKGPKLAKK().SetFloat("_TintColor", 825f - Constrast);
			int width = -192;
			int height = -176;
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

	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			ACHNOHCLGOO().SetTexture("CameraFilterPack_Paper2", EIJFCDJLEPB);
			ACHNOHCLGOO().SetTexture("[", JAFJKILGIKJ);
			MCDGIILBNIF().SetFloat("hidden", TRACKING);
			KOHGPKOFEJO().SetFloat("SetCrosshairColor", JITTER);
			KOHGPKOFEJO().SetFloat("Hidden/DepthOfField/BokehSplatting", GLITCH);
			HNICHJCGJOC().SetFloat("?page=addtip", NOISE);
			NBPKMLMCHFN.SetFloat("RecieveChatMessage", Brightness);
			EHDJJANLINB().SetFloat("#failed: ", 657f - Constrast);
			int width = 21;
			int height = -41;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			temporary.filterMode = (FilterMode)4;
			Graphics.Blit(AAACLELCPML, temporary, AELJLBOJAIL());
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
		SCShader = Shader.Find("CameraFilterPack/FX_Glitch1");
		EIJFCDJLEPB = Resources.Load("_Value5") as Texture2D;
		JAFJKILGIKJ = Resources.Load("ViewID {0} {1}{2}") as Texture2D;
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
			MCDGIILBNIF().SetTexture("_Value", EIJFCDJLEPB);
			KOHGPKOFEJO().SetTexture("note.6", JAFJKILGIKJ);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", TRACKING);
			EHDJJANLINB().SetFloat(": ", JITTER);
			KBOPGONOCNP().SetFloat("_Red_R", GLITCH);
			KOHGPKOFEJO().SetFloat("offsets", NOISE);
			KOHGPKOFEJO().SetFloat("0", Brightness);
			KOHGPKOFEJO().SetFloat("OK", 1334f - Constrast);
			int width = -192;
			int height = -106;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			temporary.filterMode = (FilterMode)7;
			Graphics.Blit(AAACLELCPML, temporary, MCDGIILBNIF());
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
			AELJLBOJAIL().SetTexture("PossibleMapPointsText", EIJFCDJLEPB);
			KBOPGONOCNP().SetTexture("CameraFilterPack/Drawing_Toon", JAFJKILGIKJ);
			LENEJAGLCNL().SetFloat("maps.", TRACKING);
			HEHKGPKLAKK().SetFloat("Back", JITTER);
			KBOPGONOCNP().SetFloat("GameMessagesDurationSlider", GLITCH);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", NOISE);
			DKNJGHFLAIF().SetFloat("_TimeX", Brightness);
			LENEJAGLCNL().SetFloat("Text", 1144f - Constrast);
			int width = 7;
			int height = 178;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			temporary.filterMode = (FilterMode)8;
			Graphics.Blit(AAACLELCPML, temporary, NBPKMLMCHFN);
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
			ACHNOHCLGOO().SetTexture("SetupEncryption() got called. ", EIJFCDJLEPB);
			HNICHJCGJOC().SetTexture("settings.enablerankingnotifications", JAFJKILGIKJ);
			KBOPGONOCNP().SetFloat("SetRotation", TRACKING);
			NBPKMLMCHFN.SetFloat("_TimeX", JITTER);
			HNICHJCGJOC().SetFloat("_TimeX", GLITCH);
			ACHNOHCLGOO().SetFloat("restrictions\n\n#until: ", NOISE);
			KBOPGONOCNP().SetFloat("_ReprojectionMatrix", Brightness);
			MCDGIILBNIF().SetFloat("_ScreenResolution", 652f - Constrast);
			int width = 145;
			int height = 128;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			temporary.filterMode = (FilterMode)5;
			Graphics.Blit(AAACLELCPML, temporary, LENEJAGLCNL());
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
		SCShader = Shader.Find("materialsquantity[");
		EIJFCDJLEPB = Resources.Load("finished") as Texture2D;
		JAFJKILGIKJ = Resources.Load("Turn") as Texture2D;
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
		EIJFCDJLEPB = Resources.Load("_Green_B") as Texture2D;
		JAFJKILGIKJ = Resources.Load("InfoText") as Texture2D;
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
		EIJFCDJLEPB = Resources.Load("_TimeX") as Texture2D;
		JAFJKILGIKJ = Resources.Load("Populate Mesh Data") as Texture2D;
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
			MCDGIILBNIF().SetTexture("LetterSpacing: Missing Text component", EIJFCDJLEPB);
			LENEJAGLCNL().SetTexture("[MenuScene] Error: ", JAFJKILGIKJ);
			EHDJJANLINB().SetFloat("Down", TRACKING);
			DKNJGHFLAIF().SetFloat("HPToggle", JITTER);
			MCDGIILBNIF().SetFloat("Please attach component to a Graphical UI component", GLITCH);
			HEHKGPKLAKK().SetFloat("Default UI Material", NOISE);
			AELJLBOJAIL().SetFloat("InputField", Brightness);
			KBOPGONOCNP().SetFloat("settings.gamemessagesduration", 1430f - Constrast);
			int width = 173;
			int height = 0;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			temporary.filterMode = (FilterMode)4;
			Graphics.Blit(AAACLELCPML, temporary, AELJLBOJAIL());
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
			KBOPGONOCNP().SetTexture("_CurveTex", EIJFCDJLEPB);
			EHDJJANLINB().SetTexture("_Value4", JAFJKILGIKJ);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", TRACKING);
			HEHKGPKLAKK().SetFloat("saveGameName ", JITTER);
			DKNJGHFLAIF().SetFloat("_Value4", GLITCH);
			NBPKMLMCHFN.SetFloat("_Value", NOISE);
			EHDJJANLINB().SetFloat("_Distortion", Brightness);
			KOHGPKOFEJO().SetFloat("LoadMapCanvas", 722f - Constrast);
			int width = 142;
			int height = -28;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			temporary.filterMode = (FilterMode)5;
			Graphics.Blit(AAACLELCPML, temporary, EHDJJANLINB());
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
			AELJLBOJAIL().SetTexture("settings.shaders", EIJFCDJLEPB);
			LENEJAGLCNL().SetTexture("+", JAFJKILGIKJ);
			KOHGPKOFEJO().SetFloat("help", TRACKING);
			KOHGPKOFEJO().SetFloat("challenges", JITTER);
			NBPKMLMCHFN.SetFloat(" SecondsBeforeRespawn: ", GLITCH);
			DKNJGHFLAIF().SetFloat("_Level", NOISE);
			HEHKGPKLAKK().SetFloat("_Value6", Brightness);
			LENEJAGLCNL().SetFloat("NO", 1873f - Constrast);
			int width = -145;
			int height = 199;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			temporary.filterMode = (FilterMode)5;
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
		SCShader = Shader.Find("Save the map before exiting?");
		EIJFCDJLEPB = Resources.Load("[PlayerBase] Loaded custom model: ") as Texture2D;
		JAFJKILGIKJ = Resources.Load("_Value4") as Texture2D;
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DFFKKLAPHCC()
	{
		SCShader = Shader.Find("Vertical");
		EIJFCDJLEPB = Resources.Load("_Value3") as Texture2D;
		JAFJKILGIKJ = Resources.Load("Start Color's hex value #RRGGBBAA") as Texture2D;
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
			AELJLBOJAIL().SetTexture(".completed", EIJFCDJLEPB);
			ACHNOHCLGOO().SetTexture("_Value4", JAFJKILGIKJ);
			HEHKGPKLAKK().SetFloat("CameraFilterPack/Blend2Camera_Multiply", TRACKING);
			HNICHJCGJOC().SetFloat("FreqVolume: ", JITTER);
			HEHKGPKLAKK().SetFloat("_TimeX", GLITCH);
			KOHGPKOFEJO().SetFloat("challenges/", NOISE);
			LENEJAGLCNL().SetFloat("NEW", Brightness);
			KBOPGONOCNP().SetFloat("menu.tabid", 926f - Constrast);
			int width = -69;
			int height = -150;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			temporary.filterMode = (FilterMode)6;
			Graphics.Blit(AAACLELCPML, temporary, HEHKGPKLAKK());
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
			HEHKGPKLAKK().SetTexture("IconImage", EIJFCDJLEPB);
			DKNJGHFLAIF().SetTexture("< true | false >", JAFJKILGIKJ);
			AELJLBOJAIL().SetFloat("LoadMapCanvas", TRACKING);
			EHDJJANLINB().SetFloat("_MainTex2", JITTER);
			HEHKGPKLAKK().SetFloat("EnvironmentSlider", GLITCH);
			KBOPGONOCNP().SetFloat("_TimeX", NOISE);
			HEHKGPKLAKK().SetFloat("MapEnd", Brightness);
			MCDGIILBNIF().SetFloat("_TimeX", 1825f - Constrast);
			int width = -89;
			int height = -69;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			temporary.filterMode = FilterMode.Trilinear;
			Graphics.Blit(AAACLELCPML, temporary, EHDJJANLINB());
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
			AELJLBOJAIL().SetTexture("_Value2", JAFJKILGIKJ);
			HEHKGPKLAKK().SetFloat("_Value3", TRACKING);
			EHDJJANLINB().SetFloat("BloodAlternative2", JITTER);
			ACHNOHCLGOO().SetFloat("Hex value #RRGGBB", GLITCH);
			KBOPGONOCNP().SetFloat("22x1", NOISE);
			KBOPGONOCNP().SetFloat("_DotSize", Brightness);
			MCDGIILBNIF().SetFloat("maps.", 620f - Constrast);
			int width = 100;
			int height = -19;
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
}
