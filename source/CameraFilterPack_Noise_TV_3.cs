// CameraFilterPack_Noise_TV_3
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Noise/TV_3")]
[ExecuteInEditMode]
public class CameraFilterPack_Noise_TV_3 : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 1f)]
	public float Fade = 1f;

	[Range(0f, 1f)]
	public float Fade_Additive;

	[Range(0f, 1f)]
	public float Fade_Distortion;

	[Range(0f, 10f)]
	private float CCIENBFIKKH = 1f;

	private Texture2D FPHEBLMINDA;

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

	private void CCLNNLCOPBL()
	{
		FPHEBLMINDA = Resources.Load("checkpoint") as Texture2D;
		SCShader = Shader.Find("Set EnvSprite Image");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JIAAFKOPEKO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 602f)
			{
				HBJJOCHGOPH = 1729f;
			}
			HNFFHCLNBDN().SetFloat(" GO:", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("[PlayerBase] SetSpeed error: ", Fade);
			PDEAHJPOMEF().SetFloat(".lastCheckpoint.incorrectScore", Fade_Additive);
			ADGHJOHKEHG().SetFloat("_MainTex2", Fade_Distortion);
			IIJMIPBMMBF().SetFloat("workshop.", CCIENBFIKKH);
			KJMECMIGJJA().SetVector("id", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1128f, 1729f));
			ABHDNGIHBKE().SetTexture("MapEnd", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IKMELABKBHO()
	{
	}

	private void ONKDMMJPEMN()
	{
	}

	private void EKCKJLFFAID()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material ADBKPGFMNKO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-69);
		}
		return BJFKDHHMLJH;
	}

	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 48f)
			{
				HBJJOCHGOPH = 415f;
			}
			NBPKMLMCHFN.SetFloat("_EmissionGain", HBJJOCHGOPH);
			ADBKPGFMNKO().SetFloat("workshop.txt", Fade);
			PGPEMMBJOOG().SetFloat("_ScreenResolution", Fade_Additive);
			OLHDPICFBOF().SetFloat("Tab1Content", Fade_Distortion);
			LENEJAGLCNL().SetFloat("FToA", CCIENBFIKKH);
			DKNJGHFLAIF().SetVector("CameraFilterPack_VHS1", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1201f, 124f));
			FKEOGPDLBDD().SetTexture("y", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
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
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1522f)
			{
				HBJJOCHGOPH = 376f;
			}
			HKGAONMOBMH().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			EJDPNJAEAKJ().SetFloat("LastHighScoreText", Fade);
			LPDOGGFOBDH().SetFloat("<color=#{0}>{1}</color>", Fade_Additive);
			KDMBOKLMADJ().SetFloat("_Value4", Fade_Distortion);
			KJMECMIGJJA().SetFloat("y", CCIENBFIKKH);
			ADBKPGFMNKO().SetVector("_Blue_G", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 115f, 1643f));
			LPDOGGFOBDH().SetTexture("#FFDA44CC", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HMNLHMLILKD()
	{
	}

	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 827f)
			{
				HBJJOCHGOPH = 1348f;
			}
			LDNADDJMIPK().SetFloat("mapselector.filter.rateduponly", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("BitsData", Fade);
			DKNJGHFLAIF().SetFloat("???", Fade_Additive);
			LPDOGGFOBDH().SetFloat("_BokehParams", Fade_Distortion);
			PGPEMMBJOOG().SetFloat("UI/Particles/Hidden", CCIENBFIKKH);
			EFMCNLELMDO().SetVector("note.6", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1945f, 282f));
			KOHGPKOFEJO().SetTexture("plogs", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	[SpecialName]
	private Material EFMCNLELMDO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)107;
		}
		return BJFKDHHMLJH;
	}

	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 513f)
			{
				HBJJOCHGOPH = 595f;
			}
			KDMBOKLMADJ().SetFloat("_Light", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("_Offsets", Fade);
			IIBLJCKLGFG().SetFloat("IntraSig", Fade_Additive);
			LPDOGGFOBDH().SetFloat("Item invalid. No idea why.", Fade_Distortion);
			HCGJCMDJPGD().SetFloat("_Value4", CCIENBFIKKH);
			PGPEMMBJOOG().SetVector("CameraFilterPack/Pixelisation_Dot", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1589f, 1066f));
			NBPKMLMCHFN.SetTexture("_Near", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MGMAOBPPOBJ()
	{
		FPHEBLMINDA = Resources.Load("_Value4") as Texture2D;
		SCShader = Shader.Find("[EditorEvent] Exception: ");
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
			BJFKDHHMLJH.hideFlags = (HideFlags)69;
		}
		return BJFKDHHMLJH;
	}

	private void FMHOHGEAIEA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PKGJJFIFLII()
	{
	}

	private void OFPPIKHNJOD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AEEGKLABFLN()
	{
	}

	[SpecialName]
	private Material LPDOGGFOBDH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void ABEIEGDHBNO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1286f)
			{
				HBJJOCHGOPH = 1489f;
			}
			PDEAHJPOMEF().SetFloat("maps.", HBJJOCHGOPH);
			DONENAMLFLF().SetFloat("76561198041679481", Fade);
			DONENAMLFLF().SetFloat("CameraFilterPack/Drawing_Halftone", Fade_Additive);
			DKNJGHFLAIF().SetFloat("ERROR: Make sure your mod contains at leats one file!", Fade_Distortion);
			DONENAMLFLF().SetFloat("menu.hardcoreinfo", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("LoadingStatusText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 634f, 1775f));
			ADBKPGFMNKO().SetTexture("isBunned", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LPMINJJPDCH()
	{
	}

	private void NCNPAKFAFOE()
	{
		FPHEBLMINDA = Resources.Load("_ColorLevel") as Texture2D;
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EGEGNHLODAA()
	{
	}

	private void ABFNJCEBIKA()
	{
	}

	[SpecialName]
	private Material KOHGPKOFEJO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)103;
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
			NBPKMLMCHFN.SetFloat("_Value", Fade);
			NBPKMLMCHFN.SetFloat("_Value2", Fade_Additive);
			NBPKMLMCHFN.SetFloat("_Value3", Fade_Distortion);
			NBPKMLMCHFN.SetFloat("_Value4", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			NBPKMLMCHFN.SetTexture("Texture2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HNFFHCLNBDN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)85;
		}
		return BJFKDHHMLJH;
	}

	private void FJIKDJAMOHA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GPNAOAKCMHC()
	{
		FPHEBLMINDA = Resources.Load("Beat Detected") as Texture2D;
		SCShader = Shader.Find("SetEnvSpriteColor");
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
	private Material KDMBOKLMADJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return BJFKDHHMLJH;
	}

	private void LIEGJOHINGC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1416f)
			{
				HBJJOCHGOPH = 544f;
			}
			HCGJCMDJPGD().SetFloat("[PlayerController] ", HBJJOCHGOPH);
			LENEJAGLCNL().SetFloat("y", Fade);
			LENEJAGLCNL().SetFloat("EventSystem", Fade_Additive);
			HNFFHCLNBDN().SetFloat("mapselector.filter.favoriteonly", Fade_Distortion);
			LDNADDJMIPK().SetFloat("CameraFilterPack/Light_Rainbow", CCIENBFIKKH);
			EJDPNJAEAKJ().SetVector("Tab1Content", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 654f, 1568f));
			FKEOGPDLBDD().SetTexture("CameraFilterPack/Oculus_NightVision2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CPAJLKHMOJB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PJIFJFENPJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1724f)
			{
				HBJJOCHGOPH = 890f;
			}
			LPCHMEKDCHI().SetFloat("_TimeX", HBJJOCHGOPH);
			IIBLJCKLGFG().SetFloat(": ", Fade);
			IIJMIPBMMBF().SetFloat("restart", Fade_Additive);
			ADGHJOHKEHG().SetFloat("menu.tabid", Fade_Distortion);
			IIBLJCKLGFG().SetFloat("/", CCIENBFIKKH);
			LPDOGGFOBDH().SetVector("USE_CORNER_DETECTION", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1662f, 819f));
			NBPKMLMCHFN.SetTexture("_TimeX", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JOACBIEHHCE()
	{
	}

	[SpecialName]
	private Material PGPEMMBJOOG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
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

	private void AEDDNDHCLNN()
	{
		FPHEBLMINDA = Resources.Load("Received unknown status code: ") as Texture2D;
		SCShader = Shader.Find("Drop_With_Obj");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JLNNHKPHMAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KLDNGKBMDAN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 3f)
			{
				HBJJOCHGOPH = 1813f;
			}
			ADGHJOHKEHG().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			EFMCNLELMDO().SetFloat("setstring", Fade);
			LPCHMEKDCHI().SetFloat("_ScreenResolution", Fade_Additive);
			NBPKMLMCHFN.SetFloat("_MainTex2", Fade_Distortion);
			NBPKMLMCHFN.SetFloat("_TimeX", CCIENBFIKKH);
			PDEAHJPOMEF().SetVector(",", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1324f, 1830f));
			PGPEMMBJOOG().SetTexture("ItemsCountText", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ILCFPCIPENO()
	{
		FPHEBLMINDA = Resources.Load("PublishButton") as Texture2D;
		SCShader = Shader.Find("settings.gamemessagesduration");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 484f)
			{
				HBJJOCHGOPH = 1958f;
			}
			EFMCNLELMDO().SetFloat("resource id", HBJJOCHGOPH);
			PGPEMMBJOOG().SetFloat("CameraFilterPack/Light_Water2", Fade);
			ADBKPGFMNKO().SetFloat("SetPlayerDistance", Fade_Additive);
			LPDOGGFOBDH().SetFloat("Items/", Fade_Distortion);
			DONENAMLFLF().SetFloat("seconds", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("CameraFilterPack/TV_Artefact", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1492f, 591f));
			ADGHJOHKEHG().SetTexture("BadgeText", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HJPCJGOEKMF()
	{
		FPHEBLMINDA = Resources.Load("DifficultyBG") as Texture2D;
		SCShader = Shader.Find("Hidden/Image Effects/Cinematic/MotionBlur/FrameBlending");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
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

	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1072f)
			{
				HBJJOCHGOPH = 646f;
			}
			LPDOGGFOBDH().SetFloat("Best region found in PlayerPrefs. Connecting to: ", HBJJOCHGOPH);
			LENEJAGLCNL().SetFloat("CameraFilterPack/Distortion_Twist_Square", Fade);
			KOHGPKOFEJO().SetFloat("CameraFilterPack/Color_Noise", Fade_Additive);
			KOHGPKOFEJO().SetFloat("_BlendTex", Fade_Distortion);
			NDMPCDHADMJ().SetFloat("JoinButton", CCIENBFIKKH);
			HCGJCMDJPGD().SetVector("StartButton", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1170f, 1641f));
			KOHGPKOFEJO().SetTexture("[Right]", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DPFOEBCADNP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GPFJMKCGHGB()
	{
	}

	[SpecialName]
	private Material IIJMIPBMMBF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)100;
		}
		return BJFKDHHMLJH;
	}

	private void Start()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_TV_Noise3") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Noise_TV_3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material ABHDNGIHBKE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void GKNKIIEALCH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HKGAONMOBMH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void KMCPMOGKDEH()
	{
		FPHEBLMINDA = Resources.Load("Search: ") as Texture2D;
		SCShader = Shader.Find(" not exist");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 679f)
			{
				HBJJOCHGOPH = 403f;
			}
			IIBLJCKLGFG().SetFloat("CameraFilterPack_3D_Computer1", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat("_TimeX", Fade);
			IIJMIPBMMBF().SetFloat("/", Fade_Additive);
			DONENAMLFLF().SetFloat("_Value11", Fade_Distortion);
			HCGJCMDJPGD().SetFloat("_Value3", CCIENBFIKKH);
			LDNADDJMIPK().SetVector("Can't connect: Loading settings failed. ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1705f, 1959f));
			ADBKPGFMNKO().SetTexture("_Offsets", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LPCHMEKDCHI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)104;
		}
		return BJFKDHHMLJH;
	}

	private void PAEGLMEOKHP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MFMIODIAKNI()
	{
	}

	private void MKIFJMPELJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 379f)
			{
				HBJJOCHGOPH = 1445f;
			}
			LDNADDJMIPK().SetFloat("Left Stick Click", HBJJOCHGOPH);
			HNFFHCLNBDN().SetFloat(" cannot be used as a 3D LUT.", Fade);
			EJDPNJAEAKJ().SetFloat("_Value", Fade_Additive);
			ABHDNGIHBKE().SetFloat("event", Fade_Distortion);
			PDEAHJPOMEF().SetFloat(".", CCIENBFIKKH);
			HCGJCMDJPGD().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 151f, 1040f));
			HKGAONMOBMH().SetTexture("settings.showHP", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material ADGHJOHKEHG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void ONMGIPAILOH()
	{
	}

	private void PBEPCAPAKLG()
	{
	}

	[SpecialName]
	private Material FKEOGPDLBDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-111);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NDMPCDHADMJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void NBGIMIDICKE()
	{
		FPHEBLMINDA = Resources.Load("Can't set Room.MaxPlayers to: ") as Texture2D;
		SCShader = Shader.Find("EventTimeInputField");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DGCGGKMNPLD()
	{
	}

	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 968f)
			{
				HBJJOCHGOPH = 1600f;
			}
			HCGJCMDJPGD().SetFloat("_Size", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Search: ", Fade);
			KJMECMIGJJA().SetFloat("_Near", Fade_Additive);
			KOHGPKOFEJO().SetFloat("Clears all text from the debug console", Fade_Distortion);
			DONENAMLFLF().SetFloat(": ", CCIENBFIKKH);
			ADGHJOHKEHG().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 59f, 414f));
			OLHDPICFBOF().SetTexture("The given 2D texture ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GCHBGCGBMCK()
	{
	}

	private void LCDJFJIBADI()
	{
	}

	private void BMODOIJGIOO()
	{
	}

	[SpecialName]
	private Material OLHDPICFBOF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	private void GMELGGJOPBB()
	{
	}

	private void KMOCDAOKGLI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NNBCLMJGFEN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IEFMONDKKJN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-120);
		}
		return BJFKDHHMLJH;
	}

	private void BDBJEDIOKBN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material LDNADDJMIPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideAndDontSave;
		}
		return BJFKDHHMLJH;
	}

	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 351f)
			{
				HBJJOCHGOPH = 487f;
			}
			HNFFHCLNBDN().SetFloat("Init", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("DPADVER", Fade);
			NBPKMLMCHFN.SetFloat("-", Fade_Additive);
			LPCHMEKDCHI().SetFloat("event", Fade_Distortion);
			DKNJGHFLAIF().SetFloat("_Value2", CCIENBFIKKH);
			DONENAMLFLF().SetVector("\" to target: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 322f, 21f));
			LDNADDJMIPK().SetTexture("start", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DKNJGHFLAIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)77;
		}
		return BJFKDHHMLJH;
	}

	private void PMPKMGKAAJH()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack/Blend2Camera_Screen") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/TV_Vintage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FLKEJJEGCFA()
	{
		FPHEBLMINDA = Resources.Load("A") as Texture2D;
		SCShader = Shader.Find("_EdgeThresholdMin");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OMIHEBMMCPG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1775f)
			{
				HBJJOCHGOPH = 896f;
			}
			KOHGPKOFEJO().SetFloat("_Value", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("shader.invert", Fade);
			HCGJCMDJPGD().SetFloat("ResourcesConfig", Fade_Additive);
			DKNJGHFLAIF().SetFloat("deletemap", Fade_Distortion);
			IIBLJCKLGFG().SetFloat("\" for viewID ", CCIENBFIKKH);
			KOHGPKOFEJO().SetVector("Set particles audio input", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 569f, 1321f));
			HKGAONMOBMH().SetTexture("LocalPlayer is null or not in mActors! LocalPlayer: {0} mActors==null: {1} newID: {2}", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HCGJCMDJPGD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)75;
		}
		return BJFKDHHMLJH;
	}

	private void KCCIEMBMOBA()
	{
		FPHEBLMINDA = Resources.Load("setbool") as Texture2D;
		SCShader = Shader.Find(".");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KMEONPMCNJG()
	{
	}

	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1117f)
			{
				HBJJOCHGOPH = 1993f;
			}
			HNFFHCLNBDN().SetFloat("CreateRoom failed. In offline mode you still have to leave a room to enter another.", HBJJOCHGOPH);
			OLHDPICFBOF().SetFloat("_ColorRGB", Fade);
			KDMBOKLMADJ().SetFloat("_PrevViewProj", Fade_Additive);
			ABHDNGIHBKE().SetFloat("_Value", Fade_Distortion);
			IIBLJCKLGFG().SetFloat("_Value2", CCIENBFIKKH);
			ABHDNGIHBKE().SetVector("float,10", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 789f, 1947f));
			ABHDNGIHBKE().SetTexture("_ScreenResolution", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HIKKPDACJGI()
	{
	}

	private void EGEPLFGKGLI()
	{
		FPHEBLMINDA = Resources.Load(",") as Texture2D;
		SCShader = Shader.Find("mapselector.filter.rateduponly");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HCIPECAOGIA()
	{
	}

	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 586f)
			{
				HBJJOCHGOPH = 1632f;
			}
			HKGAONMOBMH().SetFloat("player.xp", HBJJOCHGOPH);
			LPDOGGFOBDH().SetFloat("_Value2", Fade);
			KDMBOKLMADJ().SetFloat("<b>Intralism Items Uploader</b> by Oxy949", Fade_Additive);
			DKNJGHFLAIF().SetFloat("Player", Fade_Distortion);
			PGPEMMBJOOG().SetFloat("player.goldabstract", CCIENBFIKKH);
			KDMBOKLMADJ().SetVector("MouseX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1526f, 1756f));
			ADBKPGFMNKO().SetTexture("EnableRankedNotificationsToggle", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FABKIGNFECE()
	{
	}

	private void EPJJDKJEDMM()
	{
	}

	private void FDMAEPOHDMK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material LENEJAGLCNL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void MBLDJEFBLFL()
	{
	}

	[SpecialName]
	private Material KJMECMIGJJA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 668f)
			{
				HBJJOCHGOPH = 1202f;
			}
			DONENAMLFLF().SetFloat("_Radius2", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat("Set satellite audio input", Fade);
			OLHDPICFBOF().SetFloat("musicVolume", Fade_Additive);
			LENEJAGLCNL().SetFloat("_ScreenResolution", Fade_Distortion);
			OLHDPICFBOF().SetFloat("#alreadyexist", CCIENBFIKKH);
			FKEOGPDLBDD().SetVector("Error: I/O Failure! :(", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 99f, 828f));
			DKNJGHFLAIF().SetTexture("_Screen", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
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
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1799f)
			{
				HBJJOCHGOPH = 1259f;
			}
			HNFFHCLNBDN().SetFloat("Ignored PU RPC, cause item is inactive. ", HBJJOCHGOPH);
			FKEOGPDLBDD().SetFloat("[MapsData] Caching ", Fade);
			NDMPCDHADMJ().SetFloat("PopulateMapsList", Fade_Additive);
			IIJMIPBMMBF().SetFloat("_Distortion", Fade_Distortion);
			KJMECMIGJJA().SetFloat("Couldn't color correct with 3D LUT texture. Image Effect will be disabled.", CCIENBFIKKH);
			LPDOGGFOBDH().SetVector("Joystick1Button2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1273f, 1334f));
			NDMPCDHADMJ().SetTexture("_ChannelMixerGreen", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LENEJAGLCNL());
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

	private void FIKFJDFELIP()
	{
		FPHEBLMINDA = Resources.Load(". Our prefix is ") as Texture2D;
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OCMKCBBCEFG()
	{
	}

	[SpecialName]
	private Material EJDPNJAEAKJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-89);
		}
		return BJFKDHHMLJH;
	}

	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1374f)
			{
				HBJJOCHGOPH = 1072f;
			}
			LENEJAGLCNL().SetFloat("_ColorBuffer", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("_CurveParams", Fade);
			LENEJAGLCNL().SetFloat("settings.volume.sfx", Fade_Additive);
			KDMBOKLMADJ().SetFloat("close", Fade_Distortion);
			ADGHJOHKEHG().SetFloat("Uploading content...", CCIENBFIKKH);
			DKNJGHFLAIF().SetVector("CameraFilterPack/BlurTiltShift_Hole", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 879f, 32f));
			IIBLJCKLGFG().SetTexture("_Threshold", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNFFHCLNBDN());
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

	private void LINKAMEPKGM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ALJEJJCIMJN()
	{
		FPHEBLMINDA = Resources.Load("_NoiseAmount") as Texture2D;
		SCShader = Shader.Find(": ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1093f)
			{
				HBJJOCHGOPH = 506f;
			}
			EFMCNLELMDO().SetFloat("original.tutorial", HBJJOCHGOPH);
			HNFFHCLNBDN().SetFloat("_Value2", Fade);
			NBPKMLMCHFN.SetFloat("_SizeY", Fade_Additive);
			EJDPNJAEAKJ().SetFloat("_BlurVector", Fade_Distortion);
			LPDOGGFOBDH().SetFloat(":", CCIENBFIKKH);
			HKGAONMOBMH().SetVector("sounds/no_hit", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1718f, 1922f));
			ADGHJOHKEHG().SetTexture("GlassDistortion", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1628f)
			{
				HBJJOCHGOPH = 8f;
			}
			KDMBOKLMADJ().SetFloat("offline", HBJJOCHGOPH);
			EJDPNJAEAKJ().SetFloat("CameraFilterPack/FX_Grid", Fade);
			DONENAMLFLF().SetFloat("ComboScoreText", Fade_Additive);
			OLHDPICFBOF().SetFloat(" Gb", Fade_Distortion);
			OLHDPICFBOF().SetFloat("0.00", CCIENBFIKKH);
			IIJMIPBMMBF().SetVector("Myst_Color", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1420f, 699f));
			ABHDNGIHBKE().SetTexture("_Distortion", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MCKCCPLJIFE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NKFDNIAKGEO()
	{
		FPHEBLMINDA = Resources.Load("Joystick1Button5") as Texture2D;
		SCShader = Shader.Find("Scene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}
}
