// CameraFilterPack_Distortion_ShockWave
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Distortion/ShockWave")]
[ExecuteInEditMode]
public class CameraFilterPack_Distortion_ShockWave : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(-1.5f, 1.5f)]
	public float PosX = 0.5f;

	[Range(-1.5f, 1.5f)]
	public float PosY = 0.5f;

	[Range(0f, 10f)]
	public float Speed = 1f;

	[Range(0f, 10f)]
	private float FPECJFFEDOM = 1f;

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

	private void AEOLJEIDMDB()
	{
		SCShader = Shader.Find("x");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DPIPGGDNGHN()
	{
	}

	private void MECJHOJPODB()
	{
	}

	[SpecialName]
	private Material AELJLBOJAIL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 270f)
			{
				HBJJOCHGOPH = 1689f;
			}
			NJDIODJNGGA().SetFloat("NetworkCanvas", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("null", PosX);
			LPDOGGFOBDH().SetFloat("Set Satellite Lerp Speed", PosY);
			ALABBJPHCNG().SetFloat("_Intensity", Speed);
			NDMPCDHADMJ().SetFloat("No problem found, so far", FPECJFFEDOM);
			PHGCJOPFDOG().SetVector("[MapsData] Bad map: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 813f, 837f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
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
			NBPKMLMCHFN.SetFloat("_Value", PosX);
			NBPKMLMCHFN.SetFloat("_Value2", PosY);
			NBPKMLMCHFN.SetFloat("_Value3", Speed);
			NBPKMLMCHFN.SetFloat("_Value4", FPECJFFEDOM);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1274f)
			{
				HBJJOCHGOPH = 375f;
			}
			ALABBJPHCNG().SetFloat("CameraFilterPack_Fly_VisionFX", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("(", PosX);
			PLBEJJIHFPB().SetFloat("Cannot remove cached RPCs on a PhotonView thats not ours! ", PosY);
			IIBLJCKLGFG().SetFloat("_Val", Speed);
			ADGHJOHKEHG().SetFloat("OK", FPECJFFEDOM);
			LPDOGGFOBDH().SetVector("_PositionY", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 667f, 1103f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HILDKDFEBPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material EPCGJFCCAFH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void LBAJLLFMMMP()
	{
		SCShader = Shader.Find("#failed: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MFMIODIAKNI()
	{
	}

	private void CACCPBENDAP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1608f)
			{
				HBJJOCHGOPH = 1503f;
			}
			HILDKDFEBPF().SetFloat("_Speed", HBJJOCHGOPH);
			NMDBCDFPGOK().SetFloat("_TimeX", PosX);
			EOCCJGIGEGJ().SetFloat("_Value2", PosY);
			HILDKDFEBPF().SetFloat("Show image from resources by id at the center of the screen at foreground or background", Speed);
			EOCCJGIGEGJ().SetFloat("Can't start OFFLINE mode while connected!", FPECJFFEDOM);
			ADGHJOHKEHG().SetVector("ControllerRightX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1553f, 436f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MNLKBFFKHIE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1317f)
			{
				HBJJOCHGOPH = 1845f;
			}
			KGOLDDBHIFN().SetFloat("#mapby", HBJJOCHGOPH);
			IIBLJCKLGFG().SetFloat("bans.viewed.", PosX);
			NDMPCDHADMJ().SetFloat("CameraFilterPack_TV_Noise2", PosY);
			OHKGGPFGLFD().SetFloat("_TimeX", Speed);
			LENEJAGLCNL().SetFloat("settings.enableranking", FPECJFFEDOM);
			LPDOGGFOBDH().SetVector("CameraFilterPack/FX_Ascii", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1814f, 1347f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NMDBCDFPGOK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IENKPJEBMFM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FGBDGGCBFLP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GJLKJAOBPJD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KNBJBNDGCIJ()
	{
		SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AGMJDGHLBMN()
	{
	}

	private void HNDNDPECBPL()
	{
	}

	private void COGBDFKOHKK()
	{
	}

	private void NNPBKKBFDHH()
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
			if (HBJJOCHGOPH > 387f)
			{
				HBJJOCHGOPH = 145f;
			}
			PLBEJJIHFPB().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			ADGHJOHKEHG().SetFloat("LastHighScoreText", PosX);
			NJDIODJNGGA().SetFloat("Save", PosY);
			PLBEJJIHFPB().SetFloat("curScn", Speed);
			NMDBCDFPGOK().SetFloat("Playing ", FPECJFFEDOM);
			ALABBJPHCNG().SetVector("Error: you cannot read this stream that you are writing!", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1938f, 345f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MKFLBEGJJDC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material OHKGGPFGLFD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-65);
		}
		return BJFKDHHMLJH;
	}

	private void JMAIIENCEKE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LDDKCCMHMIC()
	{
	}

	private void POJFHDFJOPE()
	{
	}

	private void FMNPFCHBLJF()
	{
		SCShader = Shader.Find("null");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 771f)
			{
				HBJJOCHGOPH = 254f;
			}
			NBPKMLMCHFN.SetFloat("Joystick1Button1", HBJJOCHGOPH);
			HILDKDFEBPF().SetFloat("_ScreenResolution", PosX);
			NDMPCDHADMJ().SetFloat("/", PosY);
			OHKGGPFGLFD().SetFloat("_TimeX", Speed);
			NJDIODJNGGA().SetFloat("grid", FPECJFFEDOM);
			OHKGGPFGLFD().SetVector("Music End", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1681f, 627f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CBIBDOIBJAI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CFFCLAHMBAA()
	{
		SCShader = Shader.Find("\n - NetID: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ABIOAMNCEOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1608f)
			{
				HBJJOCHGOPH = 1273f;
			}
			MNLKBFFKHIE().SetFloat("_GreenAmplifier", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("#forever", PosX);
			AELJLBOJAIL().SetFloat("[Right]", PosY);
			IGIAPKPKGPK().SetFloat("_ToPrevViewProjCombined", Speed);
			IGIAPKPKGPK().SetFloat("_Value2", FPECJFFEDOM);
			NDMPCDHADMJ().SetVector("Object ID. Case-Sensitive", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1346f, 870f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MANDOGNJJBD()
	{
	}

	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1694f)
			{
				HBJJOCHGOPH = 1016f;
			}
			AELJLBOJAIL().SetFloat("_TimeX", HBJJOCHGOPH);
			IIBLJCKLGFG().SetFloat("<color=#{0}>{1}</color>", PosX);
			PDEAHJPOMEF().SetFloat("_TimeX", PosY);
			NJDIODJNGGA().SetFloat("Out {0,4} | In {1,4} | Sum {2,4}", Speed);
			IGIAPKPKGPK().SetFloat("ticket", FPECJFFEDOM);
			DOMEEFLPEPJ().SetVector("stretchWidth", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1345f, 1340f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BNEJMABFKJE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FEHCNJLLJMP()
	{
		SCShader = Shader.Find("Please attach component to a Graphical UI component");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 481f)
			{
				HBJJOCHGOPH = 206f;
			}
			HILDKDFEBPF().SetFloat("settings.volume.sfx", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("TStart", PosX);
			AELJLBOJAIL().SetFloat("SupportLogger OnCreatedRoom(", PosY);
			DKNJGHFLAIF().SetFloat(" on effect ", Speed);
			PHGCJOPFDOG().SetFloat("Drop_Far", FPECJFFEDOM);
			EOCCJGIGEGJ().SetVector("Joystick1Button0", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1318f, 1209f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MNLKBFFKHIE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LLKKGGLNIDF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void COIJKMKIEAK()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KIEJKBNBHMD()
	{
	}

	private void DLMPALHKMON()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AKHCOBHHGJP()
	{
		SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PLBOFEPBPKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KKLMPKLKAEM()
	{
	}

	[SpecialName]
	private Material DOMEEFLPEPJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void JILOMOBDPIA()
	{
		SCShader = Shader.Find(" This is not possible to be called for standalone input. Please check your platform and code where this is called");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JBMBNKOOENB()
	{
	}

	private void DNNFHBOOPIN()
	{
		SCShader = Shader.Find("#pleasewait");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 60f)
			{
				HBJJOCHGOPH = 1988f;
			}
			OHKGGPFGLFD().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("Joystick1Button2", PosX);
			IGIAPKPKGPK().SetFloat("RoomNameText", PosY);
			NJDIODJNGGA().SetFloat("_WorldToCameraMatrix", Speed);
			DKNJGHFLAIF().SetFloat("[NetworkManager] roomInfo.name: ", FPECJFFEDOM);
			IIBLJCKLGFG().SetVector("[PlayerBase] ShowTitle error: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 667f, 265f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HILDKDFEBPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NNFMIAFHMJM()
	{
		SCShader = Shader.Find(".workshop.json");
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
			BJFKDHHMLJH.hideFlags = ~HideFlags.HideAndDontSave;
		}
		return BJFKDHHMLJH;
	}

	private void MNBPNHNAEBK()
	{
		SCShader = Shader.Find("B:");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EPEGAEGDJAM()
	{
		SCShader = Shader.Find("[Right-Down]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material GKILCDHJFEG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)92;
		}
		return BJFKDHHMLJH;
	}

	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1419f)
			{
				HBJJOCHGOPH = 1330f;
			}
			EHDJJANLINB().SetFloat("_MainTex", HBJJOCHGOPH);
			IIBLJCKLGFG().SetFloat("{0:0} minute{1}, ", PosX);
			NJDIODJNGGA().SetFloat("BloodAlternative3", PosY);
			IIBLJCKLGFG().SetFloat("Object ID. Case-Sensitive", Speed);
			NMDBCDFPGOK().SetFloat("_TimeX", FPECJFFEDOM);
			HILDKDFEBPF().SetVector("UseScanLine", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 356f, 865f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ALABBJPHCNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Distortion_ShockWave");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BLKGOMCPEKI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 129f)
			{
				HBJJOCHGOPH = 892f;
			}
			PDEAHJPOMEF().SetFloat("_Value", HBJJOCHGOPH);
			LPDOGGFOBDH().SetFloat("BitsData", PosX);
			LENEJAGLCNL().SetFloat(" beatThreshold: ", PosY);
			PDEAHJPOMEF().SetFloat("Joystick1Button12", Speed);
			MNLKBFFKHIE().SetFloat("_ScreenResolution", FPECJFFEDOM);
			GKILCDHJFEG().SetVector("SupportLogger OnFailedToConnectToPhoton(", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 939f, 364f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DLBODOFAJGM()
	{
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JAFOCEDILNK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material PHGCJOPFDOG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-121);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material ADGHJOHKEHG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NDMPCDHADMJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-68);
		}
		return BJFKDHHMLJH;
	}

	private void FEKECCBFGMI()
	{
		SCShader = Shader.Find("CameraFilterPack/Vision_Blood");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material DKNJGHFLAIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)99;
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

	private void BMOFEBKGLFI()
	{
		SCShader = Shader.Find("Not sending leave operation. State is not 'Joined': ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FJHFOBHJEHL()
	{
	}

	[SpecialName]
	private Material HILDKDFEBPF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)80;
		}
		return BJFKDHHMLJH;
	}

	private void IBHACCEEFFI()
	{
	}

	private void FJNCHGLIEMA()
	{
		SCShader = Shader.Find("[ResourcesManager] Load image error: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 553f)
			{
				HBJJOCHGOPH = 594f;
			}
			LENEJAGLCNL().SetFloat("OnJoinedRoom() called by PUN. Now this client is in a room. From here on, your game would be running. For reference, all callbacks are listed in enum: PhotonNetworkingMessage", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("<b>", PosX);
			DOMEEFLPEPJ().SetFloat("_SSAO", PosY);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", Speed);
			EPCGJFCCAFH().SetFloat("delete", FPECJFFEDOM);
			IIBLJCKLGFG().SetVector("_PColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1687f, 801f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material MNLKBFFKHIE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInHierarchy);
		}
		return BJFKDHHMLJH;
	}

	private void CNGAJDBOCLJ()
	{
		SCShader = Shader.Find("_FrustumCornersWS");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NFEDLAOPHML()
	{
	}

	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1583f)
			{
				HBJJOCHGOPH = 1420f;
			}
			GKILCDHJFEG().SetFloat("/", HBJJOCHGOPH);
			ALABBJPHCNG().SetFloat("DPADHOR", PosX);
			EHDJJANLINB().SetFloat("id", PosY);
			KBOPGONOCNP().SetFloat("arcs", Speed);
			GKILCDHJFEG().SetFloat("[Left]", FPECJFFEDOM);
			NMDBCDFPGOK().SetVector("_Fade", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1344f, 668f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OCMBHMLNCEK());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)112;
		}
		return BJFKDHHMLJH;
	}

	private void PDHKMDBNGGN()
	{
		SCShader = Shader.Find(". MasterClient: ");
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void HAHJJPLPOKB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NNCCPEBIAKH()
	{
		SCShader = Shader.Find("z");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FODKODGPPDA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1254f)
			{
				HBJJOCHGOPH = 1625f;
			}
			DKNJGHFLAIF().SetFloat("id", HBJJOCHGOPH);
			IIBLJCKLGFG().SetFloat("_ScreenResolution", PosX);
			DOMEEFLPEPJ().SetFloat("Destroy(targetPhotonView) failed, cause targetPhotonView is null.", PosY);
			LENEJAGLCNL().SetFloat("Editor/", Speed);
			EOCCJGIGEGJ().SetFloat("CameraFilterPack/3D_Shield", FPECJFFEDOM);
			HILDKDFEBPF().SetVector("_InternalLutTex", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1862f, 1013f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material IGIAPKPKGPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)71;
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

	[SpecialName]
	private Material IIBLJCKLGFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)85;
		}
		return BJFKDHHMLJH;
	}

	private void KFEKCJDEECK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KDMANOEMOCA()
	{
		SCShader = Shader.Find("Texture2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1768f)
			{
				HBJJOCHGOPH = 1225f;
			}
			ADGHJOHKEHG().SetFloat("[TextSaver] Text saved to ", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value4", PosX);
			OHKGGPFGLFD().SetFloat("#onrankchangeuptext", PosY);
			PHGCJOPFDOG().SetFloat("CameraFilterPack/Atmosphere_Rain_Pro_3D", Speed);
			IGIAPKPKGPK().SetFloat(" not exist", FPECJFFEDOM);
			LENEJAGLCNL().SetVector("#close", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1735f, 983f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
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
			if (HBJJOCHGOPH > 786f)
			{
				HBJJOCHGOPH = 1287f;
			}
			OCMBHMLNCEK().SetFloat("_Value4", HBJJOCHGOPH);
			OHKGGPFGLFD().SetFloat("Tab1Content", PosX);
			PLBEJJIHFPB().SetFloat("_Intensity", PosY);
			AELJLBOJAIL().SetFloat("<b>Time</b>:", Speed);
			AELJLBOJAIL().SetFloat("1159514800", FPECJFFEDOM);
			DOMEEFLPEPJ().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 523f, 1313f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JABNHMIHBHC()
	{
		SCShader = Shader.Find("1087340967");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MDNHCLKNCLE()
	{
		SCShader = Shader.Find("PunSupportLogger");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NPLCENPNJBM()
	{
		SCShader = Shader.Find("QuickSave");
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
			BJFKDHHMLJH.hideFlags = (HideFlags)113;
		}
		return BJFKDHHMLJH;
	}

	private void IKDNLHLBHID()
	{
		SCShader = Shader.Find("_BlurDistance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material NMDBCDFPGOK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material LENEJAGLCNL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material PLBEJJIHFPB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)94;
		}
		return BJFKDHHMLJH;
	}

	private void ELDMKIAPNGP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DOOIKOEBBJB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 88f)
			{
				HBJJOCHGOPH = 1677f;
			}
			ADGHJOHKEHG().SetFloat("clear", HBJJOCHGOPH);
			MNLKBFFKHIE().SetFloat("CameraFilterPack/BlurTiltShift", PosX);
			KGOLDDBHIFN().SetFloat(" SecondsBeforeRespawn: ", PosY);
			PLBEJJIHFPB().SetFloat("_Green_B", Speed);
			DKNJGHFLAIF().SetFloat("#ok", FPECJFFEDOM);
			NDMPCDHADMJ().SetVector("CameraFilterPack/TV_BrokenGlass2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1387f, 1456f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MNLKBFFKHIE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 533f)
			{
				HBJJOCHGOPH = 1111f;
			}
			MICHFGAOPKM().SetFloat("x", HBJJOCHGOPH);
			NMDBCDFPGOK().SetFloat("Please specify a map name or buildID", PosX);
			KGOLDDBHIFN().SetFloat("CameraFilterPack_Paper1", PosY);
			KGOLDDBHIFN().SetFloat("#mapby", Speed);
			ALABBJPHCNG().SetFloat("value", FPECJFFEDOM);
			EHDJJANLINB().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1990f, 1993f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PHGCJOPFDOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material NJDIODJNGGA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void MMMDPANNAIO()
	{
		SCShader = Shader.Find("ConnectToRegion: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 507f)
			{
				HBJJOCHGOPH = 1217f;
			}
			KBOPGONOCNP().SetFloat(": ", HBJJOCHGOPH);
			OCMBHMLNCEK().SetFloat("settings.hitvariation", PosX);
			DKNJGHFLAIF().SetFloat("[TextSaver] Text saved to ", PosY);
			IGIAPKPKGPK().SetFloat("_MainTex2", Speed);
			LENEJAGLCNL().SetFloat(" .", FPECJFFEDOM);
			IGIAPKPKGPK().SetVector(".completed", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1158f, 1206f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MNLKBFFKHIE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ICILLMAKLMI()
	{
		SCShader = Shader.Find("local CheckCondition = function()");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1167f)
			{
				HBJJOCHGOPH = 93f;
			}
			NMDBCDFPGOK().SetFloat("RecordButton", HBJJOCHGOPH);
			NMDBCDFPGOK().SetFloat(" elements", PosX);
			AELJLBOJAIL().SetFloat("LoadingStatusText", PosY);
			PDEAHJPOMEF().SetFloat("time", Speed);
			OCMBHMLNCEK().SetFloat("#close", FPECJFFEDOM);
			ADGHJOHKEHG().SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 388f, 1084f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BFGIMALGMAJ()
	{
	}

	private void HCIPECAOGIA()
	{
	}

	private void PHJLHCMCCKE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LCDJFJIBADI()
	{
	}

	private void LCHBFNIPBHB()
	{
	}

	private void HLIAEEMGBHN()
	{
		SCShader = Shader.Find("/Segment-[Right]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FOLDLDLFFLM()
	{
	}

	private void KIMMMCJFMAB()
	{
		SCShader = Shader.Find("SetParticlesParticleSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MBLDJEFBLFL()
	{
	}

	private void POEMOLBJDLG()
	{
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)92;
		}
		return BJFKDHHMLJH;
	}

	private void MEBPBNLBECA()
	{
		SCShader = Shader.Find(":");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material OCMBHMLNCEK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void GLEJGFLCLPJ()
	{
		SCShader = Shader.Find("menu.selectedlevelid");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material ALABBJPHCNG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)70;
		}
		return BJFKDHHMLJH;
	}

	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 21f)
			{
				HBJJOCHGOPH = 270f;
			}
			AELJLBOJAIL().SetFloat("X", HBJJOCHGOPH);
			NJDIODJNGGA().SetFloat("_Value2", PosX);
			OHKGGPFGLFD().SetFloat(". Prefab must have a PhotonView component.", PosY);
			EOCCJGIGEGJ().SetFloat("_Linecount", Speed);
			PDEAHJPOMEF().SetFloat("_Value", FPECJFFEDOM);
			KGOLDDBHIFN().SetVector("Write me to get one for testing :)", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 254f, 1789f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material MICHFGAOPKM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
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

	private void PLIKADJCEPO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Update()
	{
	}

	private void FNCDAPDOBBI()
	{
		SCShader = Shader.Find("menu.selectedplaymode");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ANKIJGCGCBF()
	{
	}

	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1279f)
			{
				HBJJOCHGOPH = 1338f;
			}
			AELJLBOJAIL().SetFloat("Map: ", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("#yes", PosX);
			DKNJGHFLAIF().SetFloat("Connection failed: ", PosY);
			KGOLDDBHIFN().SetFloat("_Value4", Speed);
			EPCGJFCCAFH().SetFloat(".g", FPECJFFEDOM);
			PLBEJJIHFPB().SetVector("Object ID. Case-Sensitive", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1158f, 834f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material EOCCJGIGEGJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-70);
		}
		return BJFKDHHMLJH;
	}
}
