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
			LEIAFCPJMDP().SetFloat("_Value4", HBJJOCHGOPH);
			HKIMAANBGMJ().SetFloat("Can't start OFFLINE mode while connected!", center.x);
			LEIAFCPJMDP().SetFloat("SlidingArea", center.y);
			MFHPKGICPIO().SetFloat("#tryagain", Radius);
			ACHNOHCLGOO().SetVector("color", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 99f, 95f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
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
			EFDEIFCDAFG().SetFloat("_Value3", HBJJOCHGOPH);
			PHGCJOPFDOG().SetFloat("Achievement 21 progress reseted", center.x);
			PHGCJOPFDOG().SetFloat("[ItemsHandler] Loading Steam inventory", center.y);
			EHDJJANLINB().SetFloat(" not exist", Radius);
			MFHPKGICPIO().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1387f, 237f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
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
		SCShader = Shader.Find("note.1");
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
			LEIAFCPJMDP().SetFloat("#mapalreadyexistupdate", HBJJOCHGOPH);
			BLMPMOIDGMG().SetFloat("mapselector.lastSearch", center.x);
			NFMGLIKNOOC().SetFloat("CameraFilterPack/TV_ARCADE_2", center.y);
			HKIMAANBGMJ().SetFloat("Ev DestroyAll! By PlayerId: ", Radius);
			PLBEJJIHFPB().SetVector("Text", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 42f, 459f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CECJJMKLEAK());
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
			LEIAFCPJMDP().SetFloat("Jit ", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("CameraFilterPack/Blend2Camera_ColorDodge", center.x);
			FOOCJIDNGBB().SetFloat("_DotSize", center.y);
			EFDEIFCDAFG().SetFloat("  |  ", Radius);
			BLMPMOIDGMG().SetVector("Tab2Content", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1462f, 1966f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EHDJJANLINB());
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
			KGOLDDBHIFN().SetFloat("CameraFilterPack_3D_Myst1", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value11", center.x);
			BLMPMOIDGMG().SetFloat("_TapLowForeground", center.y);
			EFDEIFCDAFG().SetFloat("CameraFilterPack/Sharpen_Sharpen", Radius);
			KGOLDDBHIFN().SetVector("_PositionY", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 45f, 1052f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIAIGCAHDA());
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
		SCShader = Shader.Find("workshop.");
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
		SCShader = Shader.Find("SupportLogger OnJoinedLobby(");
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
			PLBEJJIHFPB().SetFloat("_Value4", HBJJOCHGOPH);
			OLHDPICFBOF().SetFloat("IEnumerable", center.x);
			HKIMAANBGMJ().SetFloat("SetSunDirectionVector", center.y);
			GJHLADDCMFF().SetFloat("_Value", Radius);
			CECJJMKLEAK().SetVector("LevelEditor/patterns", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 784f, 1817f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
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
		SCShader = Shader.Find("float,0");
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
		SCShader = Shader.Find("_TimeX");
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
			ACHNOHCLGOO().SetFloat("_History3Weight", HBJJOCHGOPH);
			HHIAIGCAHDA().SetFloat("_Smooth", center.x);
			ACHNOHCLGOO().SetFloat(".b", center.y);
			KGOLDDBHIFN().SetFloat("Gameplay/sun", Radius);
			GJHLADDCMFF().SetVector("Uploading preview image...", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1175f, 1003f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
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
			KBOPGONOCNP().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			CECJJMKLEAK().SetFloat("In Main Menu", center.x);
			LEIAFCPJMDP().SetFloat("_TimeX", center.y);
			CFEDGDGBCHE().SetFloat("_Value3", Radius);
			FOOCJIDNGBB().SetVector("b", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 483f, 1602f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HJPCJGOEKMF()
	{
		SCShader = Shader.Find("OpGetGameList()");
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
		SCShader = Shader.Find("\n");
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
			NFMGLIKNOOC().SetFloat("_SSAO", HBJJOCHGOPH);
			CECJJMKLEAK().SetFloat("Month_", center.x);
			EHDJJANLINB().SetFloat(": ", center.y);
			HKIMAANBGMJ().SetFloat("ConnectToBestCloudServer() failed. Can only connect while in state 'Disconnected'. Current state: ", Radius);
			HKIMAANBGMJ().SetVector("workshop.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 158f, 1372f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
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
		SCShader = Shader.Find("float,1.5");
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
		SCShader = Shader.Find("UseScanLineSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PAKPHKPDKGE()
	{
		SCShader = Shader.Find("_Bullet_2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JMEOGJHCONJ()
	{
		SCShader = Shader.Find("CameraFilterPack_RainFX_Anm");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KMCPMOGKDEH()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EFJDNLGNACH()
	{
		SCShader = Shader.Find("_Offsets");
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
		SCShader = Shader.Find("_Value");
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
			KGOLDDBHIFN().SetFloat("setfloat", HBJJOCHGOPH);
			HKIMAANBGMJ().SetFloat("/", center.x);
			CECJJMKLEAK().SetFloat(",", center.y);
			KBOPGONOCNP().SetFloat("RoomPlayersCountText", Radius);
			PHGCJOPFDOG().SetVector("Mouse Y", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 691f, 1893f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
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
			FOOCJIDNGBB().SetFloat("Forward", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("/icon", center.x);
			KGOLDDBHIFN().SetFloat("_Source", center.y);
			LEIAFCPJMDP().SetFloat("CameraFilterPack/Retro_Loading", Radius);
			EHDJJANLINB().SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 995f, 1625f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EHDJJANLINB());
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
			EHDJJANLINB().SetFloat("Current xp: ", HBJJOCHGOPH);
			PHGCJOPFDOG().SetFloat("_SecondTex", center.x);
			BLMPMOIDGMG().SetFloat("_Value3", center.y);
			BLMPMOIDGMG().SetFloat(".ogg", Radius);
			CECJJMKLEAK().SetVector(":", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 952f, 697f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKIMAANBGMJ());
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
			OLHDPICFBOF().SetFloat("_Radius", HBJJOCHGOPH);
			FOOCJIDNGBB().SetFloat("GlassAberration", center.x);
			OLHDPICFBOF().SetFloat("Using Stopwatch as precision timer for PUN.", center.y);
			FOOCJIDNGBB().SetFloat(" region", Radius);
			MFHPKGICPIO().SetVector("EnableRankingToggle", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1282f, 1986f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FOOCJIDNGBB());
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
			OLHDPICFBOF().SetFloat("_Value2", HBJJOCHGOPH);
			BLMPMOIDGMG().SetFloat("workshop.", center.x);
			MFHPKGICPIO().SetFloat("_Value4", center.y);
			PHGCJOPFDOG().SetFloat("F3", Radius);
			NBPKMLMCHFN.SetVector("grid", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 125f, 556f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
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
			GJHLADDCMFF().SetFloat("Freq: ", HBJJOCHGOPH);
			HHIAIGCAHDA().SetFloat("Delete events", center.x);
			LEIAFCPJMDP().SetFloat("tagElement", center.y);
			ACHNOHCLGOO().SetFloat("LivesSlider", Radius);
			PHGCJOPFDOG().SetVector("CameraFilterPack/Vision_Tunnel", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 750f, 1472f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FOOCJIDNGBB());
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
			FOOCJIDNGBB().SetFloat("MaxLivesSlider", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("Outdated version. Please restart the game to get lastest updates.", center.x);
			NBPKMLMCHFN.SetFloat("settings.disablestoryboard", center.y);
			GJHLADDCMFF().SetFloat("_Value4", Radius);
			MFHPKGICPIO().SetVector("SpeedSlider", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1128f, 1929f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FOOCJIDNGBB());
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
			CFEDGDGBCHE().SetFloat("Sending RPC \"", HBJJOCHGOPH);
			NDMPCDHADMJ().SetFloat("Tab1Content", center.x);
			FOOCJIDNGBB().SetFloat("SetSatelliteTrailLength", center.y);
			EFDEIFCDAFG().SetFloat("&page=", Radius);
			CFEDGDGBCHE().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 293f, 227f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NDMPCDHADMJ());
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
		SCShader = Shader.Find("ItemTemplate");
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
			CFEDGDGBCHE().SetFloat("LivesSlider", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat("_TimeX", center.x);
			GJHLADDCMFF().SetFloat("_Min", center.y);
			FOOCJIDNGBB().SetFloat("{0,-18} {1,18}", Radius);
			KBOPGONOCNP().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1116f, 1443f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKIMAANBGMJ());
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
			EHDJJANLINB().SetFloat(". Client should be in a room. Current connectionStateDetailed: ", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat("JoinRandom failed: No open game. Calling: OnPhotonRandomJoinFailed() and staying on master server.", center.x);
			HKIMAANBGMJ().SetFloat("CameraFilterPack/Distortion_Lens", center.y);
			EHDJJANLINB().SetFloat("_Noise", Radius);
			HHIAIGCAHDA().SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 52f, 1202f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
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
			EHDJJANLINB().SetFloat(".lastCheckpoint.bgcolor", HBJJOCHGOPH);
			BLMPMOIDGMG().SetFloat("_Value4", center.x);
			KGOLDDBHIFN().SetFloat(".lastCheckpoint.correctScore", center.y);
			KBOPGONOCNP().SetFloat("<b><i>Map's Stats:</i></b>", Radius);
			EFDEIFCDAFG().SetVector("0.00", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 340f, 581f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
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
		SCShader = Shader.Find("_NoiseTilingPerChannel");
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
		SCShader = Shader.Find("_TimeX");
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
			CECJJMKLEAK().SetFloat("[Sound Manager] Audio clip is null, cannot play sound", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("_Speed", center.x);
			GJHLADDCMFF().SetFloat("inventory.selected.", center.y);
			HKIMAANBGMJ().SetFloat(".played", Radius);
			HKIMAANBGMJ().SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1785f, 119f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIAIGCAHDA());
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
			ACHNOHCLGOO().SetFloat(".g", HBJJOCHGOPH);
			CECJJMKLEAK().SetFloat("_Value4", center.x);
			GJHLADDCMFF().SetFloat("Unknown player asked for PickupItems", center.y);
			MFHPKGICPIO().SetFloat("Set Satellite Trail Length", Radius);
			HHIAIGCAHDA().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1180f, 1437f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
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
		SCShader = Shader.Find("[PlayerController] ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void COOHIILCOCO()
	{
		SCShader = Shader.Find("_ScreenResolution");
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
