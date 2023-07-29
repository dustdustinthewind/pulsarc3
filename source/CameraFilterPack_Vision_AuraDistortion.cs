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
			BKKJJJGADLM().SetFloat("_MainTex2", HBJJOCHGOPH);
			OHKGGPFGLFD().SetFloat("ViewMenu", Twist);
			EOCCJGIGEGJ().SetColor("#join", Color);
			EJDPNJAEAKJ().SetFloat("DPADHOR", PosX);
			MJJIEHANFJA().SetFloat("LogStats", PosY);
			ADBKPGFMNKO().SetFloat("_ColorRGB", Speed);
			ILKALHDJBFE().SetVector(".lastCheckpoint.time", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 913f, 1624f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK());
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
			MFHPKGICPIO().SetFloat("End index must in an integer.", HBJJOCHGOPH);
			HKIMAANBGMJ().SetFloat("CameraFilterPack/Blend2Camera_Hue", Twist);
			LDNADDJMIPK().SetColor(": ", Color);
			LEIAFCPJMDP().SetFloat("_TimeX", PosX);
			IOHHLNAPGMA().SetFloat("_TimeX", PosY);
			IOHHLNAPGMA().SetFloat("NEW_ACHIEVEMENT_1_", Speed);
			IKBJACCLPCL().SetVector("Destroying GO as global. ID: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1556f, 545f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
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
			FOOCJIDNGBB().SetFloat("_ToneCurve", HBJJOCHGOPH);
			JJNHPMLMJIH().SetFloat("_Far", Twist);
			LEIAFCPJMDP().SetColor("_BorderSize", Color);
			IOHHLNAPGMA().SetFloat("gameVolume", PosX);
			NDMPCDHADMJ().SetFloat("_SearchTex", PosY);
			ILKALHDJBFE().SetFloat("Joystick1Button2", Speed);
			ADBKPGFMNKO().SetVector(" - StoreAuthURLResponse] - ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1358f, 393f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
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
		SCShader = Shader.Find("menu.relaxinfo");
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
			BAGICADFBAB().SetFloat("InfoCanvas", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("_VignetteColor", Twist);
			OIBHFCLJKDB().SetColor("_Value3", Color);
			EBJKJPAIAAM().SetFloat("STICKRHOR", PosX);
			MFHPKGICPIO().SetFloat("CameraFilterPack/Gradients_ElectricGradient", PosY);
			EJDPNJAEAKJ().SetFloat("BitsData", Speed);
			GCDFNHMJMIP().SetVector(".highscore", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 492f, 1331f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
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
		SCShader = Shader.Find("UI Extensions/UISoftAdditive");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EGEPLFGKGLI()
	{
		SCShader = Shader.Find("LB");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NMAOGOMAING()
	{
		SCShader = Shader.Find("CameraFilterPack/TV_Tiles");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MMOKKAPFGAK()
	{
		SCShader = Shader.Find("UseFinalGlassColor");
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
		SCShader = Shader.Find("ItemNameBGImage");
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
			DONENAMLFLF().SetFloat("ERROR You have missing MonoBehaviours on your gameobjects!", HBJJOCHGOPH);
			MJJIEHANFJA().SetFloat("#mapalreadyexistupdate", Twist);
			ADBKPGFMNKO().SetColor("SetEnvSpriteImage", Color);
			EJDPNJAEAKJ().SetFloat("_Green_G", PosX);
			MJJIEHANFJA().SetFloat("menu.selectedlevelid", PosY);
			LEIAFCPJMDP().SetFloat("[DiscordController] Join ({0})", Speed);
			EJDPNJAEAKJ().SetVector("SetCrosshairEmission", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1174f, 391f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
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
			FOOCJIDNGBB().SetFloat("_Bullet_4", HBJJOCHGOPH);
			BAGICADFBAB().SetFloat("_NeighborMaxTex", Twist);
			ADBKPGFMNKO().SetColor("RecieveChatMessage", Color);
			JJNHPMLMJIH().SetFloat("CameraFilterPack_Blizzard1", PosX);
			CBCNOEIALHB().SetFloat("CameraFilterPack/Drawing_Comics", PosY);
			EGOGECOEONM().SetFloat("GlassColor", Speed);
			EGOGECOEONM().SetVector("Bad SegmentType passed in to CreateLineCap. Must be SegmentType.Start or SegmentType.End", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1717f, 1313f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JJNHPMLMJIH());
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
		SCShader = Shader.Find("CameraFilterPack/OldFilm_Cutting2");
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
			NBPKMLMCHFN.SetFloat("win", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("_Value2", Twist);
			BKKJJJGADLM().SetColor("MenuScene", Color);
			EGOGECOEONM().SetFloat("HPToggle", PosX);
			EOCCJGIGEGJ().SetFloat("note.2", PosY);
			HHIFMIPPMPF().SetFloat("_Value3", Speed);
			HEHKGPKLAKK().SetVector("_Value5", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 198f, 696f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DONENAMLFLF());
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
			IKBJACCLPCL().SetFloat("anonymous", HBJJOCHGOPH);
			HKIMAANBGMJ().SetFloat("_ScreenResolution", Twist);
			HEHKGPKLAKK().SetColor("Parent ID", Color);
			FGENHBKMPDA().SetFloat("Room: '{0}' {1},{2} {4}/{3} players.\ncustomProps: {5}", PosX);
			HKGAONMOBMH().SetFloat("[ResourcesManager] Unloading data resources", PosY);
			NLFJGMBCICG().SetFloat("icon", Speed);
			HKIMAANBGMJ().SetVector("id", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1717f, 1220f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIBHFCLJKDB());
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
		SCShader = Shader.Find("UI Extensions/SoftMaskShader");
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
		SCShader = Shader.Find("CameraFilterPack/TV_ARCADE");
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
			MJJIEHANFJA().SetFloat("_TimeX", HBJJOCHGOPH);
			OIBHFCLJKDB().SetFloat("Drop_Near", Twist);
			DONENAMLFLF().SetColor("Network destroy Instantiated GO: ", Color);
			BKKJJJGADLM().SetFloat("_TimeX", PosX);
			HKHBBBFLGJH().SetFloat("BadgeText", PosY);
			FOOCJIDNGBB().SetFloat("DPADHOR", Speed);
			ADBKPGFMNKO().SetVector(".lastCheckpoint.isMapCompleted", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 137f, 1537f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
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
			FOOCJIDNGBB().SetFloat(".g", HBJJOCHGOPH);
			EBJKJPAIAAM().SetFloat(".icon", Twist);
			IOHHLNAPGMA().SetColor("USE_PREDICATION", Color);
			MFHPKGICPIO().SetFloat("Loading maps", PosX);
			HKHBBBFLGJH().SetFloat("_Far", PosY);
			HEHKGPKLAKK().SetFloat("Tab2Content", Speed);
			LPDOGGFOBDH().SetVector("???", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1991f, 252f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
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
		SCShader = Shader.Find("_Value2");
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
			KDMBOKLMADJ().SetFloat("tagElement", HBJJOCHGOPH);
			DONENAMLFLF().SetFloat("CameraFilterPack/Blend2Camera_Lighten", Twist);
			LEHDPILKKND().SetColor("_TimeX", Color);
			HKIMAANBGMJ().SetFloat("_FixDistance", PosX);
			LDNADDJMIPK().SetFloat("config.txt", PosY);
			KHCLIAMBBNC().SetFloat("note.4", Speed);
			DONENAMLFLF().SetVector(".completed", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 564f, 481f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FIKFJDFELIP()
	{
		SCShader = Shader.Find("skin.");
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
		SCShader = Shader.Find("_TimeX");
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
		SCShader = Shader.Find("LevelEditor/CustomEventEditor-Text");
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
			BKKJJJGADLM().SetFloat("Failed to InstantiateSceneObject prefab: ", HBJJOCHGOPH);
			HEHKGPKLAKK().SetFloat("settings.volume.game", Twist);
			MFHPKGICPIO().SetColor("_Blue_G", Color);
			FGENHBKMPDA().SetFloat("_Value3", PosX);
			ILKALHDJBFE().SetFloat("\" for viewID ", PosY);
			HEHKGPKLAKK().SetFloat("_Value2", Speed);
			GCDFNHMJMIP().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 397f, 920f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
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
		SCShader = Shader.Find("Items/");
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
		SCShader = Shader.Find("file://");
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
			KGOLDDBHIFN().SetFloat("settings.disablestoryboard", HBJJOCHGOPH);
			HEHKGPKLAKK().SetFloat("CameraFilterPack/Blend2Camera_HardLight", Twist);
			FOOCJIDNGBB().SetColor("_Blend", Color);
			OIBHFCLJKDB().SetFloat(" ", PosX);
			ILKALHDJBFE().SetFloat("Texture2", PosY);
			NBPKMLMCHFN.SetFloat("OneHand", Speed);
			MFHPKGICPIO().SetVector("No Name", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1874f, 322f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
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
		SCShader = Shader.Find("#close");
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
			MFHPKGICPIO().SetFloat("GlassesColor", HBJJOCHGOPH);
			ADBKPGFMNKO().SetFloat("SpectateButton", Twist);
			EBJKJPAIAAM().SetColor("VisionBlur", Color);
			LPDOGGFOBDH().SetFloat("#pleasewait", PosX);
			FOOCJIDNGBB().SetFloat("image", PosY);
			LEHDPILKKND().SetFloat("No Name", Speed);
			LDNADDJMIPK().SetVector("\n", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1184f, 281f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
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
			EOCCJGIGEGJ().SetFloat("mode", Twist);
			HKIMAANBGMJ().SetColor("Unable to get a reward! Try again?", Color);
			EJDPNJAEAKJ().SetFloat("_RotationMatrix", PosX);
			HKIMAANBGMJ().SetFloat("Can't execute Disconnect() while not connected. Nothing changed. State: {0}", PosY);
			HKGAONMOBMH().SetFloat("_Blue_R", Speed);
			LEHDPILKKND().SetVector("GlassColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 321f, 1593f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CBCNOEIALHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KNBJBNDGCIJ()
	{
		SCShader = Shader.Find("event");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PMPKMGKAAJH()
	{
		SCShader = Shader.Find("ConnectToBestCloudServer() failed. Can only connect while in state 'Disconnected'. Current state: ");
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
			ADBKPGFMNKO().SetFloat("_Value3", HBJJOCHGOPH);
			DONENAMLFLF().SetFloat("CameraFilterPack/Blend2Camera_Exclusion", Twist);
			HEINDEMCGIK().SetColor("ConnectToMaster() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", Color);
			LPDOGGFOBDH().SetFloat("yesterday", PosX);
			MFHPKGICPIO().SetFloat("_Value4", PosY);
			JFDGLLEOPGB().SetFloat("_Near", Speed);
			LDNADDJMIPK().SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 640f, 1569f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LIBGAKMKHJJ()
	{
		SCShader = Shader.Find(" is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package.");
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
		SCShader = Shader.Find("[PlayerBase] Loaded spawner data");
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
			LEHDPILKKND().SetFloat("_BlurVector", HBJJOCHGOPH);
			EJDPNJAEAKJ().SetFloat("_TimeX", Twist);
			IOHHLNAPGMA().SetColor("skin.hit_perfect", Color);
			NLFJGMBCICG().SetFloat("If you host Photon yourself, make sure to start the 'Instance LoadBalancing' ", PosX);
			EOCCJGIGEGJ().SetFloat("PRESS A KEY", PosY);
			IOHHLNAPGMA().SetFloat("Joystick1Button9", Speed);
			CBCNOEIALHB().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1519f, 358f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKIMAANBGMJ());
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
		SCShader = Shader.Find(" url: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void COOHIILCOCO()
	{
		SCShader = Shader.Find(".");
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
			FGENHBKMPDA().SetFloat("_TimeX", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("true", Twist);
			EBJKJPAIAAM().SetColor("[DiscordController] Responding yes to Ask to Join request", Color);
			MFHPKGICPIO().SetFloat("/", PosX);
			NLFJGMBCICG().SetFloat("EventTimeInputField", PosY);
			MJJIEHANFJA().SetFloat("_Saturation", Speed);
			HKGAONMOBMH().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 637f, 159f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
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
			CBCNOEIALHB().SetFloat("_ReflectionTexture1", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("#rt", Twist);
			BKKJJJGADLM().SetColor("No Camera attached!", Color);
			ADBKPGFMNKO().SetFloat("_Value2", PosX);
			GCDFNHMJMIP().SetFloat("_TimeX", PosY);
			HEHKGPKLAKK().SetFloat("_Value4", Speed);
			DONENAMLFLF().SetVector("JoinRoom failed. A roomname is required. If you don't know one, how will you join?", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1417f, 1451f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EBJKJPAIAAM());
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
			NBPKMLMCHFN.SetFloat("Set Sun Input", HBJJOCHGOPH);
			HKGAONMOBMH().SetFloat("cameramovements:", Twist);
			JJNHPMLMJIH().SetColor("menu.enableselectormusic", Color);
			EBJKJPAIAAM().SetFloat("_DepthLevel", PosX);
			HHIFMIPPMPF().SetFloat("#score", PosY);
			KGOLDDBHIFN().SetFloat("SupportLogger OnCreatedRoom(", Speed);
			BAGICADFBAB().SetVector("CameraFilterPack/Lut_Simple", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1216f, 1256f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KHCLIAMBBNC());
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
			KGOLDDBHIFN().SetFloat("ResetButton", HBJJOCHGOPH);
			KDMBOKLMADJ().SetFloat("_FixDistance", Twist);
			DONENAMLFLF().SetColor("_MidGrey", Color);
			MJJIEHANFJA().SetFloat("_TimeX", PosX);
			KGOLDDBHIFN().SetFloat("{0} days ago", PosY);
			MFHPKGICPIO().SetFloat(".lastCheckpoint.checkpointsUsed", Speed);
			MJJIEHANFJA().SetVector("FinalScoreSmallText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 630f, 118f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
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
			HEINDEMCGIK().SetFloat("_ToneCurveRange", HBJJOCHGOPH);
			ADBKPGFMNKO().SetFloat("Set Crosshair Emission", Twist);
			KDMBOKLMADJ().SetColor(".status", Color);
			EBJKJPAIAAM().SetFloat("GlassDistortion", PosX);
			KGOLDDBHIFN().SetFloat("_Value", PosY);
			NLFJGMBCICG().SetFloat("_Params", Speed);
			NLFJGMBCICG().SetVector("source", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1063f, 1739f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KDMBOKLMADJ());
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
			IKBJACCLPCL().SetFloat("_MainTex2", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("menu.selectedplaymode", Twist);
			EJDPNJAEAKJ().SetColor("levelcompleted", Color);
			HEINDEMCGIK().SetFloat(" ", PosX);
			IOHHLNAPGMA().SetFloat("settings.gamemessagesduration", PosY);
			OIBHFCLJKDB().SetFloat("_TintColor", Speed);
			FGENHBKMPDA().SetVector("DPADVER", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1203f, 1153f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
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
		SCShader = Shader.Find("_NoiseTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CFFCLAHMBAA()
	{
		SCShader = Shader.Find("_ScreenResolution");
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
		SCShader = Shader.Find("_RgbTex");
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
			JJNHPMLMJIH().SetFloat("Fade", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("_Value4", Twist);
			HKGAONMOBMH().SetColor("Mouse Y", Color);
			IOHHLNAPGMA().SetFloat("true", PosX);
			EJDPNJAEAKJ().SetFloat("[LevelEditorScene] Exported to ", PosY);
			OIBHFCLJKDB().SetFloat("Received unknown status code: ", Speed);
			JJNHPMLMJIH().SetVector("DifficultyBG", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1616f, 972f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LEIAFCPJMDP());
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
