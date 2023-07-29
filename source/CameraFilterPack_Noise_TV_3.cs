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
			FKEOGPDLBDD().SetFloat(" or player:", HBJJOCHGOPH);
			EFMCNLELMDO().SetFloat("[PlayerBase] ShowTitle error: ", Fade);
			IIBLJCKLGFG().SetFloat(".lastCheckpoint.powerupsScore", Fade_Additive);
			FKEOGPDLBDD().SetFloat("_MainTex2", Fade_Distortion);
			NBPKMLMCHFN.SetFloat("workshop.", CCIENBFIKKH);
			KJMECMIGJJA().SetVector("id", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1128f, 1729f));
			LENEJAGLCNL().SetTexture("Music End", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
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
			OLHDPICFBOF().SetFloat("AudioSampler", HBJJOCHGOPH);
			LPCHMEKDCHI().SetFloat("workshop.txt", Fade);
			ADBKPGFMNKO().SetFloat("CameraFilterPack/TV_Chromatical2", Fade_Additive);
			NBPKMLMCHFN.SetFloat("LevelNameInputField", Fade_Distortion);
			ABHDNGIHBKE().SetFloat("No font defined. Found font: ", CCIENBFIKKH);
			EJDPNJAEAKJ().SetVector("CameraFilterPack_VHS2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1201f, 124f));
			LPCHMEKDCHI().SetTexture("float,0", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
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
			NBPKMLMCHFN.SetFloat("_ScreenResolution", HBJJOCHGOPH);
			LPDOGGFOBDH().SetFloat("PossibleMapMaxScoreText", Fade);
			NBPKMLMCHFN.SetFloat("Game Version: ", Fade_Additive);
			EFMCNLELMDO().SetFloat("_ScreenResolution", Fade_Distortion);
			LENEJAGLCNL().SetFloat("y", CCIENBFIKKH);
			KOHGPKOFEJO().SetVector("_Blue_B", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 115f, 1643f));
			KOHGPKOFEJO().SetTexture("subscribeall", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
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
			HKGAONMOBMH().SetFloat("mapselector.filter.subscribedonly", HBJJOCHGOPH);
			LENEJAGLCNL().SetFloat("event", Fade);
			LPCHMEKDCHI().SetFloat("???", Fade_Additive);
			DONENAMLFLF().SetFloat("_FgCocMask", Fade_Distortion);
			IIBLJCKLGFG().SetFloat("#", CCIENBFIKKH);
			HNFFHCLNBDN().SetVector("note.7", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1945f, 282f));
			FKEOGPDLBDD().SetTexture("<start_index> <end_index>", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
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
			PGPEMMBJOOG().SetFloat("_Line", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat("_SecondTex", Fade);
			LENEJAGLCNL().SetFloat("request", Fade_Additive);
			LENEJAGLCNL().SetFloat("Committing changes...", Fade_Distortion);
			NDMPCDHADMJ().SetFloat("_Value5", CCIENBFIKKH);
			OLHDPICFBOF().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1589f, 1066f));
			PGPEMMBJOOG().SetTexture("_Near", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MGMAOBPPOBJ()
	{
		FPHEBLMINDA = Resources.Load("_ScreenResolution") as Texture2D;
		SCShader = Shader.Find("Changed config");
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
			ADBKPGFMNKO().SetFloat(".highscore", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("https://api.steampowered.com/IInventoryService/AddItem/v001", Fade);
			KDMBOKLMADJ().SetFloat("_TimeX", Fade_Additive);
			KOHGPKOFEJO().SetFloat("ERROR: Preview file name in modName.workshop.json doesn't match any file", Fade_Distortion);
			NBPKMLMCHFN.SetFloat("menu.hardcoreinfo", CCIENBFIKKH);
			KOHGPKOFEJO().SetVector("BadgeText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 634f, 1775f));
			ABHDNGIHBKE().SetTexture("player.xp", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
		FPHEBLMINDA = Resources.Load("_Distortion") as Texture2D;
		SCShader = Shader.Find("_Value2");
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
		SCShader = Shader.Find(" not exist");
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
			LPCHMEKDCHI().SetFloat(": ", HBJJOCHGOPH);
			LPDOGGFOBDH().SetFloat("y", Fade);
			HKGAONMOBMH().SetFloat("Maps Editor v.", Fade_Additive);
			EJDPNJAEAKJ().SetFloat("menu.tabid", Fade_Distortion);
			HCGJCMDJPGD().SetFloat("_TimeX", CCIENBFIKKH);
			PGPEMMBJOOG().SetVector("ConfigVersionSlider", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 654f, 1568f));
			KOHGPKOFEJO().SetTexture("_TimeX", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DONENAMLFLF());
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
			ADBKPGFMNKO().SetFloat("_TimeX", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat(": ", Fade);
			HKGAONMOBMH().SetFloat("restart", Fade_Additive);
			IIJMIPBMMBF().SetFloat("/", Fade_Distortion);
			IIBLJCKLGFG().SetFloat("Editor/", CCIENBFIKKH);
			EFMCNLELMDO().SetVector("USE_DIAG_SEARCH", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1662f, 819f));
			PGPEMMBJOOG().SetTexture("_Red_R", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
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
		FPHEBLMINDA = Resources.Load("Ev OwnershipRequest ") as Texture2D;
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
			IIBLJCKLGFG().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat("setstring", Fade);
			PDEAHJPOMEF().SetFloat("_ScreenResolution", Fade_Additive);
			LPCHMEKDCHI().SetFloat("_MainTex2", Fade_Distortion);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", CCIENBFIKKH);
			HCGJCMDJPGD().SetVector(".completedMaps", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1324f, 1830f));
			EFMCNLELMDO().SetTexture("ItemNameText", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ILCFPCIPENO()
	{
		FPHEBLMINDA = Resources.Load("PublishButton") as Texture2D;
		SCShader = Shader.Find("settings.arcsdestroydelay");
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
			NDMPCDHADMJ().SetFloat("resource id", HBJJOCHGOPH);
			LPDOGGFOBDH().SetFloat("_TimeX", Fade);
			NBPKMLMCHFN.SetFloat("ClearEnvironment", Fade_Additive);
			LENEJAGLCNL().SetFloat("Gameplay/satellite", Fade_Distortion);
			ABHDNGIHBKE().SetFloat("float,0.5", CCIENBFIKKH);
			IIJMIPBMMBF().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1492f, 591f));
			HKGAONMOBMH().SetTexture("COMPLETED", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HJPCJGOEKMF()
	{
		FPHEBLMINDA = Resources.Load("DifficultyBG") as Texture2D;
		SCShader = Shader.Find("_History2LumaTex");
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
			LENEJAGLCNL().SetFloat("Can't connect: ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings", HBJJOCHGOPH);
			LPDOGGFOBDH().SetFloat("_TimeX", Fade);
			FKEOGPDLBDD().SetFloat("CameraFilterPack/Color_Noise", Fade_Additive);
			IIBLJCKLGFG().SetFloat("Hidden/Image Effects/Cinematic/Bloom", Fade_Distortion);
			FKEOGPDLBDD().SetFloat("JoinButton", CCIENBFIKKH);
			LENEJAGLCNL().SetVector("In Network lobby", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1170f, 1641f));
			PDEAHJPOMEF().SetTexture("[Right]", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
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
		FPHEBLMINDA = Resources.Load("settings.selectormapsperpage") as Texture2D;
		SCShader = Shader.Find("[PlayerController] ");
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
			PDEAHJPOMEF().SetFloat("CameraFilterPack_3D_Computer1", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat("_TimeX", Fade);
			OLHDPICFBOF().SetFloat("/", Fade_Additive);
			DONENAMLFLF().SetFloat("_Value11", Fade_Distortion);
			KDMBOKLMADJ().SetFloat("_Speed", CCIENBFIKKH);
			PGPEMMBJOOG().SetVector(":", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1705f, 1959f));
			LPCHMEKDCHI().SetTexture("_BlurredColor", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
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
			ADBKPGFMNKO().SetFloat("Joystick1Button11", HBJJOCHGOPH);
			OLHDPICFBOF().SetFloat("_LutTex", Fade);
			KOHGPKOFEJO().SetFloat("CameraFilterPack/FX_Drunk", Fade_Additive);
			KDMBOKLMADJ().SetFloat("BitsData", Fade_Distortion);
			HNFFHCLNBDN().SetFloat("maps.", CCIENBFIKKH);
			KDMBOKLMADJ().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 151f, 1040f));
			KOHGPKOFEJO().SetTexture("settings.showHP", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNFFHCLNBDN());
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
		FPHEBLMINDA = Resources.Load("visible") as Texture2D;
		SCShader = Shader.Find("Editing: ");
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
			KJMECMIGJJA().SetFloat("Fade", HBJJOCHGOPH);
			PGPEMMBJOOG().SetFloat("&map=", Fade);
			IIJMIPBMMBF().SetFloat("_Near", Fade_Additive);
			IIJMIPBMMBF().SetFloat("history", Fade_Distortion);
			ADBKPGFMNKO().SetFloat(" not exist", CCIENBFIKKH);
			LPDOGGFOBDH().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 59f, 414f));
			PGPEMMBJOOG().SetTexture(" cannot be used as a 3D LUT.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
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
			DKNJGHFLAIF().SetFloat("Init", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat("DPADVER", Fade);
			KOHGPKOFEJO().SetFloat("-", Fade_Additive);
			PDEAHJPOMEF().SetFloat("event", Fade_Distortion);
			OLHDPICFBOF().SetFloat("_Value2", CCIENBFIKKH);
			ABHDNGIHBKE().SetVector(".", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 322f, 21f));
			OLHDPICFBOF().SetTexture("start", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
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
		FPHEBLMINDA = Resources.Load("_MainTex2") as Texture2D;
		SCShader = Shader.Find("_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FLKEJJEGCFA()
	{
		FPHEBLMINDA = Resources.Load("Joystick1Button2") as Texture2D;
		SCShader = Shader.Find("_EdgeThreshold");
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
			OLHDPICFBOF().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			IIBLJCKLGFG().SetFloat("inventory.selected.", Fade);
			NDMPCDHADMJ().SetFloat("#ok", Fade_Additive);
			FKEOGPDLBDD().SetFloat("/?player=", Fade_Distortion);
			KOHGPKOFEJO().SetFloat(" Owner called.", CCIENBFIKKH);
			LPDOGGFOBDH().SetVector("AddEnvironmentSprite", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 569f, 1321f));
			ADBKPGFMNKO().SetTexture("Create failed on GameServer. Changing back to MasterServer. Msg: ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
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
		SCShader = Shader.Find(".highscore");
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
			KJMECMIGJJA().SetFloat("JoinRoom failed. In offline mode you still have to leave a room to enter another.", HBJJOCHGOPH);
			LPCHMEKDCHI().SetFloat("_ColorRGB", Fade);
			PDEAHJPOMEF().SetFloat("_BlurDirectionPacked", Fade_Additive);
			DONENAMLFLF().SetFloat("_Value", Fade_Distortion);
			EFMCNLELMDO().SetFloat("_Value2", CCIENBFIKKH);
			PGPEMMBJOOG().SetVector("Set crosshair color", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 789f, 1947f));
			IIBLJCKLGFG().SetTexture("CameraFilterPack/FX_DigitalMatrix", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
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
		FPHEBLMINDA = Resources.Load("Right") as Texture2D;
		SCShader = Shader.Find("mapselector.filter.subscribedonly");
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
			HCGJCMDJPGD().SetFloat("player.xp", HBJJOCHGOPH);
			HNFFHCLNBDN().SetFloat("_Value3", Fade);
			NDMPCDHADMJ().SetFloat("EventSystem", Fade_Additive);
			LENEJAGLCNL().SetFloat("[MenuScene] Error: ", Fade_Distortion);
			IIBLJCKLGFG().SetFloat("player.redabstract", CCIENBFIKKH);
			EFMCNLELMDO().SetVector("Right", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1526f, 1756f));
			IIJMIPBMMBF().SetTexture("EnableRankedNotificationsToggle", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
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
			EFMCNLELMDO().SetFloat("_BlurFilterDistance", HBJJOCHGOPH);
			OLHDPICFBOF().SetFloat("Set satellite audio input", Fade);
			PDEAHJPOMEF().SetFloat("masterVolume", Fade_Additive);
			ABHDNGIHBKE().SetFloat("_Fade", Fade_Distortion);
			FKEOGPDLBDD().SetFloat("Editor/", CCIENBFIKKH);
			FKEOGPDLBDD().SetVector("Item creation successful! Published Item ID: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 99f, 828f));
			LDNADDJMIPK().SetTexture("_Offsets", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			DKNJGHFLAIF().SetFloat(" id: ", HBJJOCHGOPH);
			IIBLJCKLGFG().SetFloat("[MapsData] Bad map: ", Fade);
			OLHDPICFBOF().SetFloat("mapselector.lastSearch", Fade_Additive);
			LPCHMEKDCHI().SetFloat("_Distortion", Fade_Distortion);
			EJDPNJAEAKJ().SetFloat("_Offset", CCIENBFIKKH);
			FKEOGPDLBDD().SetVector("Joystick1Button3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1273f, 1334f));
			HNFFHCLNBDN().SetTexture("ENABLE_COLOR_GRADING", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DONENAMLFLF());
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
		FPHEBLMINDA = Resources.Load(" [") as Texture2D;
		SCShader = Shader.Find("_Value3");
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
			PGPEMMBJOOG().SetFloat("offsets", HBJJOCHGOPH);
			ADGHJOHKEHG().SetFloat("_Offsets", Fade);
			DONENAMLFLF().SetFloat("settings.volume.menu", Fade_Additive);
			HKGAONMOBMH().SetFloat("#random #common #item", Fade_Distortion);
			KOHGPKOFEJO().SetFloat("Item invalid. No idea why.", CCIENBFIKKH);
			LPCHMEKDCHI().SetVector("CameraFilterPack/BlurTiltShift_Hole", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 879f, 32f));
			DKNJGHFLAIF().SetTexture("_ScreenResolution", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NDMPCDHADMJ());
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
		FPHEBLMINDA = Resources.Load("_MainTex") as Texture2D;
		SCShader = Shader.Find("st");
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
			OLHDPICFBOF().SetFloat("menu.playedsolo", HBJJOCHGOPH);
			IIBLJCKLGFG().SetFloat("_Value3", Fade);
			NBPKMLMCHFN.SetFloat("_SizeY", Fade_Additive);
			OLHDPICFBOF().SetFloat("_OcclusionTexture", Fade_Distortion);
			KDMBOKLMADJ().SetFloat(":", CCIENBFIKKH);
			ADBKPGFMNKO().SetVector("skin.hit_wrong", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1718f, 1922f));
			ADGHJOHKEHG().SetTexture("GlassAberration", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KJMECMIGJJA());
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
			ADGHJOHKEHG().SetFloat("OpJoinLobby()", HBJJOCHGOPH);
			EJDPNJAEAKJ().SetFloat("CameraFilterPack/FX_Grid", Fade);
			FKEOGPDLBDD().SetFloat("ComboScoreText", Fade_Additive);
			ABHDNGIHBKE().SetFloat("SAVE", Fade_Distortion);
			DKNJGHFLAIF().SetFloat("0.00", CCIENBFIKKH);
			KOHGPKOFEJO().SetVector("Myst_Color", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1420f, 699f));
			OLHDPICFBOF().SetTexture("CameraFilterPack/Color_Convert_Normal", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DONENAMLFLF());
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
		FPHEBLMINDA = Resources.Load("Joystick1Button6") as Texture2D;
		SCShader = Shader.Find("HitInRelaxMusicToggle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}
}
