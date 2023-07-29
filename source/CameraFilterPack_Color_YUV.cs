// CameraFilterPack_Color_YUV
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Colors/Color_YUV")]
[ExecuteInEditMode]
public class CameraFilterPack_Color_YUV : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(-1f, 1f)]
	public float _Y;

	[Range(-1f, 1f)]
	public float _U;

	[Range(-1f, 1f)]
	public float _V;

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

	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 714f)
			{
				HBJJOCHGOPH = 539f;
			}
			PDEAHJPOMEF().SetFloat("Show image from resources by id at the center of the screen at foreground or background", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("editorVolume", _Y);
			KGOLDDBHIFN().SetFloat("inventory.lastitemscount", _U);
			NLFJGMBCICG().SetFloat("CameraFilterPack/Color_Contrast", _V);
			NBPKMLMCHFN.SetVector("inventory.selected.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1582f, 1591f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DNENFLNCIJP()
	{
	}

	private void OFIMMFHFHDD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EGEPLFGKGLI()
	{
		SCShader = Shader.Find("[NetworkScene] Exited");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HPNNCNNFMGK()
	{
	}

	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 732f)
			{
				HBJJOCHGOPH = 1394f;
			}
			CEKJODEAMGB().SetFloat("SetSatelliteSensitivity", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("PLEASE WAIT", _Y);
			NBPKMLMCHFN.SetFloat("_MidGrey", _U);
			CEKJODEAMGB().SetFloat("http", _V);
			PLBEJJIHFPB().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 757f, 516f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DAHFFNNIGML()
	{
		SCShader = Shader.Find("_FixDistance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EKCKJLFFAID()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EJJEDJIOFAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MAOCOEGAFND()
	{
	}

	private void HLDFOJMHKNL()
	{
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IBHACCEEFFI()
	{
	}

	private void GKNKIIEALCH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GJAJBMGGPFB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FBMDHDBELEK()
	{
	}

	private void PHJJHFBLICM()
	{
	}

	private void KMOCDAOKGLI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AIJGAJIOJDJ()
	{
	}

	private void COIJKMKIEAK()
	{
		SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LCHBFNIPBHB()
	{
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Color_YUV");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CNGAJDBOCLJ()
	{
		SCShader = Shader.Find("BadgeText");
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

	[SpecialName]
	private Material GJHLADDCMFF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return BJFKDHHMLJH;
	}

	private void KMEONPMCNJG()
	{
	}

	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 213f)
			{
				HBJJOCHGOPH = 1058f;
			}
			PDEAHJPOMEF().SetFloat("Keeping GameObject in the scene: ", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("_TimeX", _Y);
			NBPKMLMCHFN.SetFloat("settings.volume.editor", _U);
			CEKJODEAMGB().SetFloat("_VelocityScale", _V);
			CEKJODEAMGB().SetVector(" ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1497f, 687f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HHIFMIPPMPF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-114);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material LDNADDJMIPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-113);
		}
		return BJFKDHHMLJH;
	}

	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 490f)
			{
				HBJJOCHGOPH = 501f;
			}
			NBPKMLMCHFN.SetFloat("0x", HBJJOCHGOPH);
			LDNADDJMIPK().SetFloat("_TimeX", _Y);
			EHDJJANLINB().SetFloat("Hidden/Image Effects/Cinematic/AmbientOcclusion", _U);
			PLBEJJIHFPB().SetFloat("_EmissionColor", _V);
			LDNADDJMIPK().SetVector("speed", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1516f, 786f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KFACDBHDAOD()
	{
	}

	[SpecialName]
	private Material BLMPMOIDGMG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void KDMKDEKCELE()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FHGKIOOMMOH()
	{
		SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 127f)
			{
				HBJJOCHGOPH = 1764f;
			}
			IIJMIPBMMBF().SetFloat("note.4", HBJJOCHGOPH);
			LDNADDJMIPK().SetFloat("[", _Y);
			GJHLADDCMFF().SetFloat("_Blue_R", _U);
			NLFJGMBCICG().SetFloat("_PrevViewProj", _V);
			EHDJJANLINB().SetVector("\nCreated by Oxy949", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 591f, 679f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MJNPIDGNJMK()
	{
	}

	private void Update()
	{
	}

	private void DBEMDAJDDDA()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1335f)
			{
				HBJJOCHGOPH = 463f;
			}
			NLFJGMBCICG().SetFloat("Set sun lerp speed", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("[ResourcesManager] Unloading data resources", _Y);
			LDNADDJMIPK().SetFloat("[DiscordController] Sectate ({0})", _U);
			HHIFMIPPMPF().SetFloat(".", _V);
			NBPKMLMCHFN.SetVector("settings.gamemessagesduration", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1021f, 1955f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
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

	private void CMIBEOJGAIL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1443f)
			{
				HBJJOCHGOPH = 1294f;
			}
			OCHJIMJNEMO().SetFloat("_InternalLutTex", HBJJOCHGOPH);
			CEKJODEAMGB().SetFloat("\" marked with the [PunRPC](C#) or @PunRPC(JS) property! Args: ", _Y);
			PLBEJJIHFPB().SetFloat("_Value2", _U);
			PLBEJJIHFPB().SetFloat("ConnectToRegion: ", _V);
			PLBEJJIHFPB().SetVector("#no", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 914f, 1867f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CGDMLHLJIDK()
	{
		SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
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

	private void BGDONBMDPGM()
	{
	}

	private void JOPCCCCHNLI()
	{
		SCShader = Shader.Find("offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KOJKBFDNGDK()
	{
		SCShader = Shader.Find("DestroyPlayerObjects() failed, cause players can only destroy their own GameObjects. A Master Client can destroy anyone's. This is master: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AEEGKLABFLN()
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
			NBPKMLMCHFN.SetFloat("_Y", _Y);
			NBPKMLMCHFN.SetFloat("_U", _U);
			NBPKMLMCHFN.SetFloat("_V", _V);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DHNGNHGDPLM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JECMJNFGBGC()
	{
		SCShader = Shader.Find("error");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material PLBEJJIHFPB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1571f)
			{
				HBJJOCHGOPH = 1156f;
			}
			HHIFMIPPMPF().SetFloat(" has ", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("SSAARenderTargetCamera", _Y);
			HHIFMIPPMPF().SetFloat("Editor/", _U);
			IIJMIPBMMBF().SetFloat("OxOD.lastPath", _V);
			PLBEJJIHFPB().SetVector("#turnoninternet", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 496f, 483f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EGEGNHLODAA()
	{
	}

	private void BMODOIJGIOO()
	{
	}

	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 18f)
			{
				HBJJOCHGOPH = 491f;
			}
			GJHLADDCMFF().SetFloat("_TileTexDebug", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("_Value5", _Y);
			ABHDNGIHBKE().SetFloat(". Check if the server is available.", _U);
			NLFJGMBCICG().SetFloat("Bad parameters for delete! Use <key>", _V);
			CEKJODEAMGB().SetVector("GameVolumeSlider", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 434f, 1324f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 401f)
			{
				HBJJOCHGOPH = 1547f;
			}
			LNLKMDPHDCC().SetFloat("mapselector.filter.subscribedonly", HBJJOCHGOPH);
			OCHJIMJNEMO().SetFloat("#getrewardfailed: ", _Y);
			NLFJGMBCICG().SetFloat("SetSunMinSize", _U);
			KGOLDDBHIFN().SetFloat("Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(", _V);
			CEKJODEAMGB().SetVector("#pleasewait", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1348f, 1616f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FJHFOBHJEHL()
	{
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)73;
		}
		return BJFKDHHMLJH;
	}

	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1503f)
			{
				HBJJOCHGOPH = 1881f;
			}
			PLBEJJIHFPB().SetFloat("z", HBJJOCHGOPH);
			EHDJJANLINB().SetFloat("float,40", _Y);
			NBPKMLMCHFN.SetFloat("DPADVER", _U);
			PDEAHJPOMEF().SetFloat("UseFinalGlassColor", _V);
			OCHJIMJNEMO().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 361f, 532f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HNILMGEKDEC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GPHPJIDGEPI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material CEKJODEAMGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void POIMNOBDBBN()
	{
	}

	[SpecialName]
	private Material EHDJJANLINB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KGOLDDBHIFN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)74;
		}
		return BJFKDHHMLJH;
	}

	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 782f)
			{
				HBJJOCHGOPH = 1949f;
			}
			LDNADDJMIPK().SetFloat("GetGameList failed: ", HBJJOCHGOPH);
			OCHJIMJNEMO().SetFloat("player.bat", _Y);
			PDEAHJPOMEF().SetFloat("sounds/hit_perfect", _U);
			BLMPMOIDGMG().SetFloat("_FresnelFadePower", _V);
			LNLKMDPHDCC().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 903f, 63f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KLILJHJNICK()
	{
		SCShader = Shader.Find("MenuScene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CGBHOELMAOC()
	{
	}

	private void AAPKBNDHBLI()
	{
	}

	private void CCLNNLCOPBL()
	{
		SCShader = Shader.Find("LoadingStatusText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material LNLKMDPHDCC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-76);
		}
		return BJFKDHHMLJH;
	}

	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1296f)
			{
				HBJJOCHGOPH = 331f;
			}
			BLMPMOIDGMG().SetFloat("[PlayerBase] Saveing checkpoint data", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat(".b", _Y);
			EHDJJANLINB().SetFloat("AudioSampler", _U);
			BLMPMOIDGMG().SetFloat("[PlayerController] ", _V);
			NLFJGMBCICG().SetVector("ConfigVersionSlider", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1739f, 1581f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 754f)
			{
				HBJJOCHGOPH = 1584f;
			}
			PLBEJJIHFPB().SetFloat("CorrectHitsScoreText", HBJJOCHGOPH);
			LDNADDJMIPK().SetFloat("GameScene", _Y);
			ABHDNGIHBKE().SetFloat("checkpoint", _U);
			ABHDNGIHBKE().SetFloat("CameraFilterPack/Color_GrayScale", _V);
			LDNADDJMIPK().SetVector("isVisible", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1976f, 1021f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material ABHDNGIHBKE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void MNBPNHNAEBK()
	{
		SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MJEFMIPLFAB()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CIPKEPDELJB()
	{
		SCShader = Shader.Find("Player Disconnected");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DKOPKPBLDHH()
	{
		SCShader = Shader.Find("SetParticlesInput");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IDJKNBDKHBD()
	{
		SCShader = Shader.Find("ScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1458f)
			{
				HBJJOCHGOPH = 1601f;
			}
			NLFJGMBCICG().SetFloat("_Red_G", HBJJOCHGOPH);
			BLMPMOIDGMG().SetFloat("_Value3", _Y);
			IIJMIPBMMBF().SetFloat("_Value2", _U);
			EHDJJANLINB().SetFloat("_TimeX", _V);
			KGOLDDBHIFN().SetVector("_ChangeRed", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 338f, 136f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NFEDLAOPHML()
	{
	}

	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1060f)
			{
				HBJJOCHGOPH = 1200f;
			}
			KGOLDDBHIFN().SetFloat("Data/Editor/leveltemplate", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("UI Extensions/UIScreen", _Y);
			NBPKMLMCHFN.SetFloat("ResetButton", _U);
			PDEAHJPOMEF().SetFloat("_UserLutTex", _V);
			NLFJGMBCICG().SetVector("USE_UV_BASED_REPROJECTION", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 743f, 371f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EHDJJANLINB());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)108;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material OCHJIMJNEMO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-118);
		}
		return BJFKDHHMLJH;
	}

	private void GPNAOAKCMHC()
	{
		SCShader = Shader.Find("visible");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JAAJECBCCFM()
	{
	}
}
