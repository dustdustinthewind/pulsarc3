// CameraFilterPack_FX_Spot
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/FX/Spot")]
[ExecuteInEditMode]
public class CameraFilterPack_FX_Spot : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	public Vector2 center = new Vector2(0.5f, 0.5f);

	public float Radius = 0.2f;

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

	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1799f)
			{
				HBJJOCHGOPH = 1853f;
			}
			KGOLDDBHIFN().SetFloat("_Value5", HBJJOCHGOPH);
			NDMPCDHADMJ().SetFloat("Can't change CrcCheckEnabled while being connected. CrcCheckEnabled stays ", center.x);
			LEIAFCPJMDP().SetFloat("ItemTemplate", center.y);
			CECJJMKLEAK().SetFloat("player.currentrank", Radius);
			GJHLADDCMFF().SetVector("Color's hex value #RRGGBBAA", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 99f, 95f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CECJJMKLEAK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OOGIHDLBBLM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1793f)
			{
				HBJJOCHGOPH = 878f;
			}
			CFEDGDGBCHE().SetFloat("_Value4", HBJJOCHGOPH);
			OLHDPICFBOF().SetFloat("setAF", center.x);
			BLMPMOIDGMG().SetFloat("MenuScene", center.y);
			HKIMAANBGMJ().SetFloat("[PlayerController] ", Radius);
			OLHDPICFBOF().SetVector("Fade", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1387f, 237f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PHGCJOPFDOG());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)120;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material PHGCJOPFDOG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-118);
		}
		return BJFKDHHMLJH;
	}

	private void IHLMNAGPKDA()
	{
		SCShader = Shader.Find("note.5");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material BLMPMOIDGMG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)71;
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

	private void GCDLIKEDMCF()
	{
	}

	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1481f)
			{
				HBJJOCHGOPH = 1282f;
			}
			PHGCJOPFDOG().SetFloat("#creatingnewitem", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("menu.selectedplaymode", center.x);
			BLMPMOIDGMG().SetFloat("_TimeX", center.y);
			KBOPGONOCNP().SetFloat("Warning: Unhandled Event ErrorInfo (251). Set PhotonNetwork.OnEventCall to the method PUN should call for this event.", Radius);
			FOOCJIDNGBB().SetVector("Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 42f, 459f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OCCGJMPAJIK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AOKOLPEGHDD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1499f)
			{
				HBJJOCHGOPH = 1191f;
			}
			CECJJMKLEAK().SetFloat("PhotonServerSettings", HBJJOCHGOPH);
			HHIAIGCAHDA().SetFloat("_MainTex2", center.x);
			LEIAFCPJMDP().SetFloat("CameraFilterPack/Drawing_Laplacian", center.y);
			EFDEIFCDAFG().SetFloat("HelpMenu", Radius);
			LEIAFCPJMDP().SetVector("SpeedSlider", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1462f, 1966f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LEIAFCPJMDP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LEIAFCPJMDP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1285f)
			{
				HBJJOCHGOPH = 1335f;
			}
			CECJJMKLEAK().SetFloat("CameraFilterPack_3D_Myst1", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("_Value11", center.x);
			KGOLDDBHIFN().SetFloat("offsets", center.y);
			FOOCJIDNGBB().SetFloat("_TimeX", Radius);
			KGOLDDBHIFN().SetVector("_PositionY", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 45f, 1052f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LEIAFCPJMDP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EDBEHEKMGFH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material OLHDPICFBOF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void ODBNMPGBCGO()
	{
		SCShader = Shader.Find("http://steamcommunity.com/sharedfiles/filedetails/?id=");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NBGIMIDICKE()
	{
		SCShader = Shader.Find("IncorrectHitsScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FNCDAPDOBBI()
	{
		SCShader = Shader.Find("). ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IKIDIJLIGOH()
	{
	}

	[SpecialName]
	private Material NFMGLIKNOOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)116;
		}
		return BJFKDHHMLJH;
	}

	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1543f)
			{
				HBJJOCHGOPH = 772f;
			}
			CFEDGDGBCHE().SetFloat("_Value4", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("clicked ", center.x);
			EFDEIFCDAFG().SetFloat("Set Sun DirectionVector", center.y);
			HKIMAANBGMJ().SetFloat("_Value2", Radius);
			PLBEJJIHFPB().SetVector("LevelEditor/icons", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 784f, 1817f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void COIJKMKIEAK()
	{
		SCShader = Shader.Find(" / ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FEKECCBFGMI()
	{
		SCShader = Shader.Find("Set particles count per one beat");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PLIKADJCEPO()
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

	private void EPEGAEGDJAM()
	{
		SCShader = Shader.Find("CameraFilterPack_Broken_Screen1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DAHFFNNIGML()
	{
		SCShader = Shader.Find("_Amount");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1321f)
			{
				HBJJOCHGOPH = 1678f;
			}
			LEIAFCPJMDP().SetFloat("Hidden/ScreenSpaceReflection", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("_ScreenResolution", center.x);
			KGOLDDBHIFN().SetFloat(".a", center.y);
			KBOPGONOCNP().SetFloat("[PlayerBase] Loaded custom model: ", Radius);
			HHIAIGCAHDA().SetVector("Item invalid. Make sure your mod contains at leats one file.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1175f, 1003f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1701f)
			{
				HBJJOCHGOPH = 684f;
			}
			CECJJMKLEAK().SetFloat("CameraFilterPack/Drawing_Manga_FlashWhite", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("MultiplayerButton", center.x);
			PHGCJOPFDOG().SetFloat("_Greenness", center.y);
			ACHNOHCLGOO().SetFloat("_Value3", Radius);
			BLMPMOIDGMG().SetVector("y", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 483f, 1602f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HJPCJGOEKMF()
	{
		SCShader = Shader.Find("OpGetGameList not sent. LobbyType must be SqlLobby.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FOLDLDLFFLM()
	{
	}

	private void CCLNNLCOPBL()
	{
		SCShader = Shader.Find("[LocalizationService] Loading file: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 350f)
			{
				HBJJOCHGOPH = 1592f;
			}
			CECJJMKLEAK().SetFloat("_BlurRadius4", HBJJOCHGOPH);
			CECJJMKLEAK().SetFloat("1", center.x);
			NBPKMLMCHFN.SetFloat(" not exist", center.y);
			MFHPKGICPIO().SetFloat("ConnectToRegion() failed. Can only connect while in state 'Disconnected'. Current state: ", Radius);
			BLMPMOIDGMG().SetVector("workshop.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 158f, 1372f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void FGNFILLNPJK()
	{
	}

	private void KDMANOEMOCA()
	{
		SCShader = Shader.Find("y");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BDBJEDIOKBN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LBAJLLFMMMP()
	{
		SCShader = Shader.Find("UseScanLine");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PAKPHKPDKGE()
	{
		SCShader = Shader.Find("_Bullet_3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JMEOGJHCONJ()
	{
		SCShader = Shader.Find("CameraFilterPack/RainFX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KMCPMOGKDEH()
	{
		SCShader = Shader.Find("_DotSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EFJDNLGNACH()
	{
		SCShader = Shader.Find("_Threshhold");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NAOLAJPDGIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material FOOCJIDNGBB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-123);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NDMPCDHADMJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void KKEOHFGKCIK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DKGBFNCOAEO()
	{
		SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OPCLBGHAPMG()
	{
	}

	private void ODGMCJILIHF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BMOFEBKGLFI()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material EHDJJANLINB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void LDDKCCMHMIC()
	{
	}

	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 330f)
			{
				HBJJOCHGOPH = 655f;
			}
			BLMPMOIDGMG().SetFloat("Bad parameters for setbool! Use <key> <value>", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("/", center.x);
			HHIAIGCAHDA().SetFloat("[Down]", center.y);
			GJHLADDCMFF().SetFloat("RoomPlayersCountText", Radius);
			CECJJMKLEAK().SetVector("STICKLHOR", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 691f, 1893f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PHGCJOPFDOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BKGJOECFMID()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OCMKCBBCEFG()
	{
	}

	private void DLMPALHKMON()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material CFEDGDGBCHE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-128);
		}
		return BJFKDHHMLJH;
	}

	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 136f)
			{
				HBJJOCHGOPH = 1615f;
			}
			CFEDGDGBCHE().SetFloat("ControllerLeftY", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat("LoadMapCanvas", center.x);
			BLMPMOIDGMG().SetFloat("_ArScale", center.y);
			LEIAFCPJMDP().SetFloat("_Value", Radius);
			CFEDGDGBCHE().SetVector("#ok", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 995f, 1625f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PHGCJOPFDOG());
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
			if (HBJJOCHGOPH > 362f)
			{
				HBJJOCHGOPH = 997f;
			}
			BLMPMOIDGMG().SetFloat("player.xp", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("_EdgeThreshold", center.x);
			LEIAFCPJMDP().SetFloat("_Value4", center.y);
			FOOCJIDNGBB().SetFloat(".wav", Radius);
			CFEDGDGBCHE().SetVector(":", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 952f, 697f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FOOCJIDNGBB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PFNFPINPCMH()
	{
	}

	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 578f)
			{
				HBJJOCHGOPH = 594f;
			}
			ACHNOHCLGOO().SetFloat("_Intensity", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat("GlassesColor", center.x);
			ACHNOHCLGOO().SetFloat("Setting autoCleanUpPlayerObjects while in a room is not supported.", center.y);
			LEIAFCPJMDP().SetFloat(" region", Radius);
			MFHPKGICPIO().SetVector("EnableRankingToggle", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1282f, 1986f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EHDJJANLINB());
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
			if (HBJJOCHGOPH > 1200f)
			{
				HBJJOCHGOPH = 1660f;
			}
			KBOPGONOCNP().SetFloat("_Value3", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("workshop.", center.x);
			CFEDGDGBCHE().SetFloat("_Value5", center.y);
			BLMPMOIDGMG().SetFloat("F3", Radius);
			ACHNOHCLGOO().SetVector("caret", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 125f, 556f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CECJJMKLEAK());
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
			if (HBJJOCHGOPH > 1789f)
			{
				HBJJOCHGOPH = 1172f;
			}
			EHDJJANLINB().SetFloat("Freq: ", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat(",0", center.x);
			CFEDGDGBCHE().SetFloat("tagElement", center.y);
			NDMPCDHADMJ().SetFloat("ConfigVersionSlider", Radius);
			MFHPKGICPIO().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 750f, 1472f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	private void LINKAMEPKGM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PKHPNHBEKHA()
	{
	}

	private void PKGJJFIFLII()
	{
	}

	private void LCHBFNIPBHB()
	{
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/FX_Spot");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material KGOLDDBHIFN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)91;
		}
		return BJFKDHHMLJH;
	}

	private void OFIMMFHFHDD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EODOHEAKJFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ABIOAMNCEOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1649f)
			{
				HBJJOCHGOPH = 1026f;
			}
			BLMPMOIDGMG().SetFloat("LivesSlider", HBJJOCHGOPH);
			CECJJMKLEAK().SetFloat("#later", center.x);
			PLBEJJIHFPB().SetFloat("settings.disablestoryboard", center.y);
			NFMGLIKNOOC().SetFloat("_Value4", Radius);
			ACHNOHCLGOO().SetVector("Tab1Content", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1128f, 1929f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material PLBEJJIHFPB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void NJHJHBOJKIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material ACHNOHCLGOO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void MGFFNGEGFDC()
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

	private void GPHPJIDGEPI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1557f)
			{
				HBJJOCHGOPH = 973f;
			}
			CECJJMKLEAK().SetFloat(".", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("Tab1Content", center.x);
			OLHDPICFBOF().SetFloat("Set Satellite Trail Length", center.y);
			HKIMAANBGMJ().SetFloat("&page=", Radius);
			HHIAIGCAHDA().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 293f, 227f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
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
			NBPKMLMCHFN.SetFloat("_PositionX", center.x);
			NBPKMLMCHFN.SetFloat("_PositionY", center.y);
			NBPKMLMCHFN.SetFloat("_Radius", Radius);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NCNPAKFAFOE()
	{
		SCShader = Shader.Find("Item ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material EFDEIFCDAFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-76);
		}
		return BJFKDHHMLJH;
	}

	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1262f)
			{
				HBJJOCHGOPH = 1871f;
			}
			NFMGLIKNOOC().SetFloat("Tab2Content", HBJJOCHGOPH);
			PHGCJOPFDOG().SetFloat("_Value", center.x);
			FOOCJIDNGBB().SetFloat("_FlipAlphaMask", center.y);
			MFHPKGICPIO().SetFloat("#C8C8C8FF", Radius);
			CECJJMKLEAK().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1116f, 1443f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 428f)
			{
				HBJJOCHGOPH = 1286f;
			}
			LEIAFCPJMDP().SetFloat(". Client is not the MasterClient in this room.", HBJJOCHGOPH);
			BLMPMOIDGMG().SetFloat("FindFriends failed to apply the result, as a required value wasn't provided or the friend list length differed from result.", center.x);
			GJHLADDCMFF().SetFloat("_TimeX", center.y);
			PLBEJJIHFPB().SetFloat("_ScreenResolution", Radius);
			HKIMAANBGMJ().SetVector("/../", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 52f, 1202f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GBGAMCPNBCC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BLKGOMCPEKI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HNDNDPECBPL()
	{
	}

	private void MKIFJMPELJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1370f)
			{
				HBJJOCHGOPH = 1736f;
			}
			NDMPCDHADMJ().SetFloat(".lastCheckpoint.isMapCompleted", HBJJOCHGOPH);
			CECJJMKLEAK().SetFloat("_Value5", center.x);
			PLBEJJIHFPB().SetFloat(".lastCheckpoint.incorrectScore", center.y);
			NFMGLIKNOOC().SetFloat("MapCreationCanvas", Radius);
			PHGCJOPFDOG().SetVector("[MapEditor] Loading map: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 340f, 581f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FBMDHDBELEK()
	{
	}

	private void PMPKMGKAAJH()
	{
		SCShader = Shader.Find("_NoiseAmount");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BOLBPPHJBMI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material CECJJMKLEAK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void KCCIEMBMOBA()
	{
		SCShader = Shader.Find("_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void LCDJFJIBADI()
	{
	}

	private void JEBIBKLHFLB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 548f)
			{
				HBJJOCHGOPH = 1001f;
			}
			NDMPCDHADMJ().SetFloat("sfxVolume", HBJJOCHGOPH);
			OLHDPICFBOF().SetFloat("_Distortion", center.x);
			MFHPKGICPIO().SetFloat("LoadingStatusText", center.y);
			HKIMAANBGMJ().SetFloat("workshop.", Radius);
			OLHDPICFBOF().SetVector("#pleasewait", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1785f, 119f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LEIAFCPJMDP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material MFHPKGICPIO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1474f)
			{
				HBJJOCHGOPH = 1101f;
			}
			MFHPKGICPIO().SetFloat(".b", HBJJOCHGOPH);
			GJHLADDCMFF().SetFloat("_Value5", center.x);
			HKIMAANBGMJ().SetFloat(" timeUntilRespawn: ", center.y);
			CECJJMKLEAK().SetFloat("id", Radius);
			EHDJJANLINB().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1180f, 1437f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JDGFCEPDKAJ()
	{
	}

	private void IDJKNBDKHBD()
	{
		SCShader = Shader.Find(": ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void COOHIILCOCO()
	{
		SCShader = Shader.Find("CameraFilterPack/Distortion_Twist_Square");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material HHIAIGCAHDA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-66);
		}
		return BJFKDHHMLJH;
	}

	private void KFACDBHDAOD()
	{
	}

	private void GHILDCBCDJI()
	{
	}
}
