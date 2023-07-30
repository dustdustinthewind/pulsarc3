// CameraFilterPack_Vision_AuraDistortion
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Vision/AuraDistortion")]
public class CameraFilterPack_Vision_AuraDistortion : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 2f)]
	public float Twist = 1f;

	[Range(-4f, 4f)]
	public float Speed = 1f;

	public Color Color = new Color(0.16f, 0.57f, 0.19f);

	[Range(-1f, 2f)]
	public float PosX = 0.5f;

	[Range(-1f, 2f)]
	public float PosY = 0.5f;

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
	private Material HEINDEMCGIK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)110;
		}
		return BJFKDHHMLJH;
	}

	private void AOGCKKLFGPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1298f)
			{
				HBJJOCHGOPH = 1647f;
			}
			FOOCJIDNGBB().SetFloat("_MainTex2", HBJJOCHGOPH);
			LPDOGGFOBDH().SetFloat("GenerationMenu", Twist);
			LDNADDJMIPK().SetColor("#join", Color);
			HHIFMIPPMPF().SetFloat("DPADVER", PosX);
			ADBKPGFMNKO().SetFloat(" is not observed by this object's photonView! OnPhotonSerializeView() in this class won't be used.", PosY);
			EOCCJGIGEGJ().SetFloat("_ColorRGB", Speed);
			MFHPKGICPIO().SetVector(".", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 913f, 1624f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIBHFCLJKDB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1133f)
			{
				HBJJOCHGOPH = 1474f;
			}
			NLFJGMBCICG().SetFloat("Start index must in an integer.", HBJJOCHGOPH);
			IKBJACCLPCL().SetFloat("CameraFilterPack/Blend2Camera_Hue", Twist);
			HKGAONMOBMH().SetColor(": ", Color);
			IOHHLNAPGMA().SetFloat("CameraFilterPack/Edge_BlackLine", PosX);
			MJJIEHANFJA().SetFloat("_TimeX", PosY);
			LDNADDJMIPK().SetFloat("NEW_ACHIEVEMENT_1_", Speed);
			OHKGGPFGLFD().SetVector(". Not Destroying GameObject or PhotonViews!", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1556f, 545f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material JJNHPMLMJIH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)106;
		}
		return BJFKDHHMLJH;
	}

	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1998f)
			{
				HBJJOCHGOPH = 1936f;
			}
			ILKALHDJBFE().SetFloat("ENABLE_EYE_ADAPTATION", HBJJOCHGOPH);
			IOHHLNAPGMA().SetFloat("_Far", Twist);
			GCDFNHMJMIP().SetColor("_BorderSize", Color);
			ILKALHDJBFE().SetFloat("editorVolume", PosX);
			NLFJGMBCICG().SetFloat("_AreaTex", PosY);
			KGOLDDBHIFN().SetFloat("A", Speed);
			LEHDPILKKND().SetVector(" - GameWebCallback] - ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1358f, 393f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EIDKCANPHJE()
	{
	}

	[SpecialName]
	private Material EJDPNJAEAKJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NDMPCDHADMJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material MFHPKGICPIO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void GJLKJAOBPJD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MEBPBNLBECA()
	{
		SCShader = Shader.Find("menu.selectedplaymode");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material LPDOGGFOBDH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-71);
		}
		return BJFKDHHMLJH;
	}

	private void IMGGCJICLHK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material KGOLDDBHIFN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)113;
		}
		return BJFKDHHMLJH;
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
			NBPKMLMCHFN.SetFloat("_Value", Twist);
			NBPKMLMCHFN.SetColor("_Value2", Color);
			NBPKMLMCHFN.SetFloat("_Value3", PosX);
			NBPKMLMCHFN.SetFloat("_Value4", PosY);
			NBPKMLMCHFN.SetFloat("_Value5", Speed);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material EGOGECOEONM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)89;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HKHBBBFLGJH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HEHKGPKLAKK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
		}
		return BJFKDHHMLJH;
	}

	private void EAHCLIEEJOG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AIBNKIDADPI()
	{
		SCShader = Shader.Find("isVisible");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material ILKALHDJBFE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)106;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IOHHLNAPGMA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-83);
		}
		return BJFKDHHMLJH;
	}

	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1384f)
			{
				HBJJOCHGOPH = 874f;
			}
			EBJKJPAIAAM().SetFloat("\n\n• ", HBJJOCHGOPH);
			GCDFNHMJMIP().SetFloat("CHROMATIC_ABERRATION", Twist);
			ILKALHDJBFE().SetColor("_Value", Color);
			FGENHBKMPDA().SetFloat("STICKLHOR", PosX);
			ILKALHDJBFE().SetFloat("_ScreenResolution", PosY);
			IKBJACCLPCL().SetFloat("event", Speed);
			HKHBBBFLGJH().SetVector(".", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 492f, 1331f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material KDMBOKLMADJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-124);
		}
		return BJFKDHHMLJH;
	}

	private void ALJEADNKJPO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material OIBHFCLJKDB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void MKOMIDCPCDC()
	{
		SCShader = Shader.Find("Please attach component to a Graphical UI component");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EGEPLFGKGLI()
	{
		SCShader = Shader.Find("Y");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NMAOGOMAING()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MMOKKAPFGAK()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GKNKIIEALCH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MFLBEJHMEMO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DKOPKPBLDHH()
	{
		SCShader = Shader.Find("EventSystem");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material HHIFMIPPMPF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material DONENAMLFLF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-77);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material EOCCJGIGEGJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return BJFKDHHMLJH;
	}

	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 721f)
			{
				HBJJOCHGOPH = 1055f;
			}
			JJNHPMLMJIH().SetFloat("Malformed RPC; this should never occur. Content: ", HBJJOCHGOPH);
			ADBKPGFMNKO().SetFloat("#no", Twist);
			ADBKPGFMNKO().SetColor("SetParticlesParticleSpeed", Color);
			JJNHPMLMJIH().SetFloat("_Green_R", PosX);
			EOCCJGIGEGJ().SetFloat("menu.selectedlevelid", PosY);
			KGOLDDBHIFN().SetFloat("[DiscordController] Disconnect {0}: {1}", Speed);
			OIBHFCLJKDB().SetVector("SetCrosshairEmission", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1174f, 391f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NDMPCDHADMJ());
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
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 435f)
			{
				HBJJOCHGOPH = 369f;
			}
			NLFJGMBCICG().SetFloat("_Bullet_3", HBJJOCHGOPH);
			ILKALHDJBFE().SetFloat("_LoopCount", Twist);
			EJDPNJAEAKJ().SetColor("RecieveChatMessage", Color);
			BKKJJJGADLM().SetFloat("_ScreenResolution", PosX);
			BKKJJJGADLM().SetFloat("CameraFilterPack/Drawing_Comics", PosY);
			JJNHPMLMJIH().SetFloat("GlassesColor2", Speed);
			DONENAMLFLF().SetVector(" ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1717f, 1313f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BGDONBMDPGM()
	{
	}

	private void KCDOMIJBFLL()
	{
	}

	private void NPLCENPNJBM()
	{
		SCShader = Shader.Find("HighScaleShot");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IDJKNBDKHBD()
	{
		SCShader = Shader.Find("_Offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HMNLHMLILKD()
	{
	}

	private void KLILJHJNICK()
	{
		SCShader = Shader.Find("CameraFilterPack_OldFilm2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NBGIMIDICKE()
	{
		SCShader = Shader.Find("MusicFileSelector");
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void FOAGAKFBIGD()
	{
	}

	private void APKNAPHOFHC()
	{
	}

	[SpecialName]
	private Material NLFJGMBCICG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-76);
		}
		return BJFKDHHMLJH;
	}

	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 781f)
			{
				HBJJOCHGOPH = 618f;
			}
			OHKGGPFGLFD().SetFloat("[PlayerBase] Reset", HBJJOCHGOPH);
			LEHDPILKKND().SetFloat("_Value", Twist);
			NLFJGMBCICG().SetColor("MenuScene", Color);
			LEIAFCPJMDP().SetFloat("settings.showHP", PosX);
			LDNADDJMIPK().SetFloat("CheckCombo", PosY);
			LPDOGGFOBDH().SetFloat("_Value3", Speed);
			IOHHLNAPGMA().SetVector("_Value4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 198f, 696f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LEIAFCPJMDP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NPBDIMJDMGA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 258f)
			{
				HBJJOCHGOPH = 538f;
			}
			CBCNOEIALHB().SetFloat("ChatInput", HBJJOCHGOPH);
			JJNHPMLMJIH().SetFloat("_Value4", Twist);
			LPDOGGFOBDH().SetColor("Parent ID", Color);
			LDNADDJMIPK().SetFloat("hidden", PosX);
			MFHPKGICPIO().SetFloat(",viewkeys", PosY);
			KGOLDDBHIFN().SetFloat("/icon", Speed);
			HKHBBBFLGJH().SetVector("Set Sun DirectionVector", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1717f, 1220f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DKGBFNCOAEO()
	{
		SCShader = Shader.Find("DPADHOR");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LFBGJIIECLD()
	{
		SCShader = Shader.Find("effector");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MOMHHBKAGKG()
	{
	}

	private void LADCJEIALMH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CEAGPJBGBMH()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 230f)
			{
				HBJJOCHGOPH = 1581f;
			}
			IOHHLNAPGMA().SetFloat("CameraFilterPack/Gradients_Ansi", HBJJOCHGOPH);
			HKHBBBFLGJH().SetFloat("Drop_Near", Twist);
			HEHKGPKLAKK().SetColor("Failed to 'network-remove' GameObject. Client is neither owner nor masterClient taking over for owner who left: ", Color);
			NLFJGMBCICG().SetFloat("CameraFilterPack/FX_8bits_gb", PosX);
			EGOGECOEONM().SetFloat("BadgeText", PosY);
			EGOGECOEONM().SetFloat("DPADVER", Speed);
			IKBJACCLPCL().SetVector(".lastCheckpoint.bgcolor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 137f, 1537f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIBHFCLJKDB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AIKDNGCEDAB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1646f)
			{
				HBJJOCHGOPH = 1753f;
			}
			LEIAFCPJMDP().SetFloat(".g", HBJJOCHGOPH);
			OIBHFCLJKDB().SetFloat("skin.", Twist);
			HEINDEMCGIK().SetColor("_ReprojectionMatrix", Color);
			KGOLDDBHIFN().SetFloat("LoadingStatusText", PosX);
			HKGAONMOBMH().SetFloat("_Far", PosY);
			KDMBOKLMADJ().SetFloat("Tab2Content", Speed);
			EOCCJGIGEGJ().SetVector("_UserLutParams", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1991f, 252f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FOOCJIDNGBB());
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

	[SpecialName]
	private Material MJJIEHANFJA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)79;
		}
		return BJFKDHHMLJH;
	}

	private void KCCIEMBMOBA()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DPLLKHHLDBB()
	{
		SCShader = Shader.Find("CameraFilterPack/Blur_Movie");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material LDNADDJMIPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)98;
		}
		return BJFKDHHMLJH;
	}

	private void EDBEHEKMGFH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HKIMAANBGMJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)105;
		}
		return BJFKDHHMLJH;
	}

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1176f)
			{
				HBJJOCHGOPH = 931f;
			}
			OIBHFCLJKDB().SetFloat(" ", HBJJOCHGOPH);
			HKGAONMOBMH().SetFloat("_ScreenResolution", Twist);
			OIBHFCLJKDB().SetColor("CameraFilterPack/Blur_Steam", Color);
			KHCLIAMBBNC().SetFloat("_FixDistance", PosX);
			HEHKGPKLAKK().SetFloat("config.txt", PosY);
			HKIMAANBGMJ().SetFloat("note.0", Speed);
			FOOCJIDNGBB().SetVector("[MapsEditor] Creating new item...", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 564f, 481f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FIKFJDFELIP()
	{
		SCShader = Shader.Find("end");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PEDHPEMNHBF()
	{
		SCShader = Shader.Find("StartButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CMIBEOJGAIL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JDKHBGDEONK()
	{
		SCShader = Shader.Find("CameraFilterPack/Blur_Radial_Fast");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BMNOHLNANIP()
	{
	}

	[SpecialName]
	private Material OHKGGPFGLFD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void ALNNIDLFILB()
	{
		SCShader = Shader.Find("steamid");
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

	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 163f)
			{
				HBJJOCHGOPH = 1711f;
			}
			MJJIEHANFJA().SetFloat(". Prefab must have a PhotonView component.", HBJJOCHGOPH);
			HEHKGPKLAKK().SetFloat("settings.volume.editor", Twist);
			CBCNOEIALHB().SetColor("_Blue_R", Color);
			EBJKJPAIAAM().SetFloat("_Value2", PosX);
			BKKJJJGADLM().SetFloat(" By: ", PosY);
			HEHKGPKLAKK().SetFloat("_TimeX", Speed);
			JFDGLLEOPGB().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 397f, 920f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BKKJJJGADLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IBFJAOINHMK()
	{
	}

	[SpecialName]
	private Material LEIAFCPJMDP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void HCIPECAOGIA()
	{
	}

	private void JNIINHHCAFE()
	{
	}

	private void FMFNILJIEIA()
	{
		SCShader = Shader.Find("No Description");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ALMGMOOHLMA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OGJJDKENBNC()
	{
		SCShader = Shader.Find("[ResourcesManager] Load image error: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MBLDJEFBLFL()
	{
	}

	[SpecialName]
	private Material JFDGLLEOPGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-123);
		}
		return BJFKDHHMLJH;
	}

	private void KCNIHHNMFFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1152f)
			{
				HBJJOCHGOPH = 74f;
			}
			KHCLIAMBBNC().SetFloat("settings.enablehitsoundsinrelax", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("CameraFilterPack/Blend2Camera_HardLight", Twist);
			JJNHPMLMJIH().SetColor(" cannot be used as a 3D LUT.", Color);
			NDMPCDHADMJ().SetFloat("/?player=", PosX);
			ILKALHDJBFE().SetFloat("_ScreenResolution", PosY);
			HKGAONMOBMH().SetFloat("HiddenToggle", Speed);
			EBJKJPAIAAM().SetVector("icon.png", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1874f, 322f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LEIAFCPJMDP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LEHDPILKKND()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void CCLNNLCOPBL()
	{
		SCShader = Shader.Find("#tryagain");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1959f)
			{
				HBJJOCHGOPH = 209f;
			}
			MFHPKGICPIO().SetFloat("GlassAberration", HBJJOCHGOPH);
			OHKGGPFGLFD().SetFloat("SpectateButton", Twist);
			OIBHFCLJKDB().SetColor("Fade", Color);
			NLFJGMBCICG().SetFloat("MAPS NOT FOUND", PosX);
			HKGAONMOBMH().SetFloat("Object ID. Case-Sensitive", PosY);
			OHKGGPFGLFD().SetFloat("No Name", Speed);
			LEHDPILKKND().SetVector("\n", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1184f, 281f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1428f)
			{
				HBJJOCHGOPH = 189f;
			}
			ADBKPGFMNKO().SetFloat("?", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("#", Twist);
			HHIFMIPPMPF().SetColor("No", Color);
			NBPKMLMCHFN.SetFloat("_RampTex", PosX);
			LDNADDJMIPK().SetFloat(" to: ", PosY);
			FGENHBKMPDA().SetFloat("_Blue_R", Speed);
			FGENHBKMPDA().SetVector("GlassesColor2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 321f, 1593f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KNBJBNDGCIJ()
	{
		SCShader = Shader.Find("checkpoint");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PMPKMGKAAJH()
	{
		SCShader = Shader.Find("ReconnectAndRejoin() failed. It seems the client doesn't have any previous room to re-join.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DKPBBJINKMG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OMFBGCMHNBM()
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
			BJFKDHHMLJH.hideFlags = (HideFlags)78;
		}
		return BJFKDHHMLJH;
	}

	private void MGMAOBPPOBJ()
	{
		SCShader = Shader.Find("ItemsCountText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IAJKLKJJKEJ()
	{
	}

	private void LCDJFJIBADI()
	{
	}

	private void KLCAJPOCMPF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1431f)
			{
				HBJJOCHGOPH = 1986f;
			}
			JFDGLLEOPGB().SetFloat("_Value", HBJJOCHGOPH);
			HEHKGPKLAKK().SetFloat("_ScreenResolution", Twist);
			MJJIEHANFJA().SetColor(":", Color);
			ADBKPGFMNKO().SetFloat("yesterday", PosX);
			NDMPCDHADMJ().SetFloat("_Value4", PosY);
			LEHDPILKKND().SetFloat("_Near", Speed);
			OHKGGPFGLFD().SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 640f, 1569f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LIBGAKMKHJJ()
	{
		SCShader = Shader.Find("The shader ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GEHINELAGBI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JBNPEHMDCMI()
	{
	}

	private void FJNJIHCLODK()
	{
	}

	[SpecialName]
	private Material FGENHBKMPDA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-88);
		}
		return BJFKDHHMLJH;
	}

	private void AEOLJEIDMDB()
	{
		SCShader = Shader.Find("settings.arcsnohitsoundtimedelay");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JEBIBKLHFLB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 77f)
			{
				HBJJOCHGOPH = 1170f;
			}
			JFDGLLEOPGB().SetFloat("_BlurVector", HBJJOCHGOPH);
			LEIAFCPJMDP().SetFloat("_TimeX", Twist);
			LEHDPILKKND().SetColor("skin.hit_perfect", Color);
			FGENHBKMPDA().SetFloat("Operation failed: ", PosX);
			KHCLIAMBBNC().SetFloat("Jump", PosY);
			HEHKGPKLAKK().SetFloat("Joystick1Button8", Speed);
			HEINDEMCGIK().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1519f, 358f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GAOOPEEBGJA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MMPHNFPPEHO()
	{
		SCShader = Shader.Find("settings.customdataskin");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void COOHIILCOCO()
	{
		SCShader = Shader.Find(".lastCheckpoint.playerdistance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material EBJKJPAIAAM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void ODAIMOJLJOF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KMOCDAOKGLI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FJKJGBLPDGG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1125f)
			{
				HBJJOCHGOPH = 1068f;
			}
			CBCNOEIALHB().SetFloat("CameraFilterPack/FX_Funk", HBJJOCHGOPH);
			JJNHPMLMJIH().SetFloat("t", Twist);
			GCDFNHMJMIP().SetColor("blue", Color);
			HHIFMIPPMPF().SetFloat("/", PosX);
			EOCCJGIGEGJ().SetFloat("LevelEditor/CustomEventEditor-", PosY);
			OIBHFCLJKDB().SetFloat("_Threshhold", Speed);
			EOCCJGIGEGJ().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 637f, 159f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NNFMIAFHMJM()
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

	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 633f)
			{
				HBJJOCHGOPH = 1236f;
			}
			HEHKGPKLAKK().SetFloat("_HitPointTexture", HBJJOCHGOPH);
			IKBJACCLPCL().SetFloat("SetRoomStartTimestamp", Twist);
			HKGAONMOBMH().SetColor("ConnectionTimeout", Color);
			NLFJGMBCICG().SetFloat("_Value", PosX);
			JFDGLLEOPGB().SetFloat("CameraFilterPack/FX_Glitch1", PosY);
			EBJKJPAIAAM().SetFloat("_Value3", Speed);
			IOHHLNAPGMA().SetVector("CreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1417f, 1451f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IKBJACCLPCL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CGDMLHLJIDK()
	{
		SCShader = Shader.Find("CameraFilterPack/Blend2Camera_Darken");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LLKKGGLNIDF()
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

	private void DHNGNHGDPLM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DLIJFEGIEKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 387f)
			{
				HBJJOCHGOPH = 615f;
			}
			ADBKPGFMNKO().SetFloat("SetSunInput", HBJJOCHGOPH);
			BAGICADFBAB().SetFloat("settings.shaders.bloomintencity", Twist);
			MJJIEHANFJA().SetColor("menu.enableselectormusic", Color);
			JFDGLLEOPGB().SetFloat("_DepthLevel", PosX);
			EOCCJGIGEGJ().SetFloat("ScoreText", PosY);
			NDMPCDHADMJ().SetFloat("SupportLogger OnJoinedRoom(", Speed);
			DONENAMLFLF().SetVector("_LutTex", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1216f, 1256f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GPHPJIDGEPI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PHJJHFBLICM()
	{
	}

	private void NNPBKKBFDHH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IFJDKDFLGBG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IGJPPFJOFKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 309f)
			{
				HBJJOCHGOPH = 386f;
			}
			HKGAONMOBMH().SetFloat("RestartButton", HBJJOCHGOPH);
			BKKJJJGADLM().SetFloat("_FixDistance", Twist);
			EOCCJGIGEGJ().SetColor("_NoiseTex", Color);
			HHIFMIPPMPF().SetFloat("_TimeX", PosX);
			MFHPKGICPIO().SetFloat("{0} days ago", PosY);
			LDNADDJMIPK().SetFloat(".lastCheckpoint.correctScore", Speed);
			NBPKMLMCHFN.SetVector("FinalScoreSmallText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 630f, 118f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PHJLHCMCCKE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EHCGBJDFMHG()
	{
	}

	private void KFMEAMBLODG()
	{
	}

	private void ICDBMJKMIKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FAKGFMFAPDG()
	{
	}

	[SpecialName]
	private Material IKBJACCLPCL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material GCDFNHMJMIP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1870f)
			{
				HBJJOCHGOPH = 635f;
			}
			HKHBBBFLGJH().SetFloat("_LumTex", HBJJOCHGOPH);
			HEINDEMCGIK().SetFloat("Set Crosshair Emission", Twist);
			JFDGLLEOPGB().SetColor(",", Color);
			BKKJJJGADLM().SetFloat("VisionBlur", PosX);
			JJNHPMLMJIH().SetFloat("_Value", PosY);
			BKKJJJGADLM().SetFloat("_FarCorner", Speed);
			DONENAMLFLF().SetVector("Sequence contains no elements", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1063f, 1739f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material BKKJJJGADLM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void HPPMAKHOPBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 61f)
			{
				HBJJOCHGOPH = 1581f;
			}
			JJNHPMLMJIH().SetFloat("_MainTex2", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("menu.selectedplaymode", Twist);
			NLFJGMBCICG().SetColor("levelcompleted", Color);
			HEINDEMCGIK().SetFloat("_Value4", PosX);
			NDMPCDHADMJ().SetFloat("settings.gamemessagesduration", PosY);
			MFHPKGICPIO().SetFloat("_Offsets", Speed);
			MFHPKGICPIO().SetVector("DPADVER", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1203f, 1153f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BAGICADFBAB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material ADBKPGFMNKO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)78;
		}
		return BJFKDHHMLJH;
	}

	private void GCDLIKEDMCF()
	{
	}

	private void DGCGGKMNPLD()
	{
	}

	[SpecialName]
	private Material KHCLIAMBBNC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	private void EKPLGFAEOBE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EIMNPCMHJLJ()
	{
		SCShader = Shader.Find("_MidGrey");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CFFCLAHMBAA()
	{
		SCShader = Shader.Find("_Strength");
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

	private void KMIEAGOFLBN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MNBPNHNAEBK()
	{
		SCShader = Shader.Find("_");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material HKGAONMOBMH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)103;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material CBCNOEIALHB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void IENKPJEBMFM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AOLABBMIEIM()
	{
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Vision_AuraDistortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GOANCMNGDLE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1550f)
			{
				HBJJOCHGOPH = 143f;
			}
			OHKGGPFGLFD().SetFloat("UseFinalGlassColor", HBJJOCHGOPH);
			HEHKGPKLAKK().SetFloat("_Value3", Twist);
			HEHKGPKLAKK().SetColor("Mouse X", Color);
			EJDPNJAEAKJ().SetFloat(".", PosX);
			MJJIEHANFJA().SetFloat("/", PosY);
			FGENHBKMPDA().SetFloat(" while connecting to: ", Speed);
			IKBJACCLPCL().SetVector("DifficultyBG", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1616f, 972f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK());
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
}
