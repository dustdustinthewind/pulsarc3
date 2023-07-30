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
			HILDKDFEBPF().SetFloat("NetworkCanvas", HBJJOCHGOPH);
			DOMEEFLPEPJ().SetFloat("PointerExit ", PosX);
			PLBEJJIHFPB().SetFloat("Set Satellite Lerp Speed", PosY);
			GKILCDHJFEG().SetFloat("_Offsets", Speed);
			GKILCDHJFEG().SetFloat("icon", FPECJFFEDOM);
			AELJLBOJAIL().SetVector("[MapsData] Caching ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 813f, 837f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIBLJCKLGFG());
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
			LENEJAGLCNL().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			LENEJAGLCNL().SetFloat(": ", PosX);
			PHGCJOPFDOG().SetFloat("PhotonView ID duplicate found: {0}. New: {1} old: {2}. Maybe one wasn't destroyed on scene load?! Check for 'DontDestroyOnLoad'. Destroying old entry, adding new.", PosY);
			AELJLBOJAIL().SetFloat("CameraFilterPack/Pixel_Pixelisation", Speed);
			OCMBHMLNCEK().SetFloat("OK", FPECJFFEDOM);
			IGIAPKPKGPK().SetVector("_PositionY", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 667f, 1103f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
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
		SCShader = Shader.Find("Done! You are a contributor until: ");
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
			DKNJGHFLAIF().SetFloat("_Speed", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("_TimeX", PosX);
			MNLKBFFKHIE().SetFloat("_Value", PosY);
			EHDJJANLINB().SetFloat("float,0.5", Speed);
			LENEJAGLCNL().SetFloat("PhotonMono", FPECJFFEDOM);
			OCMBHMLNCEK().SetVector("ControllerRightY", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1553f, 436f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MICHFGAOPKM());
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
			NBPKMLMCHFN.SetFloat("MapperNameText", HBJJOCHGOPH);
			IGIAPKPKGPK().SetFloat("#ok", PosX);
			MICHFGAOPKM().SetFloat("Texture2", PosY);
			EPCGJFCCAFH().SetFloat("_TimeX", Speed);
			IGIAPKPKGPK().SetFloat("CompletedLevel", FPECJFFEDOM);
			AELJLBOJAIL().SetVector("_Distortion", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1814f, 1347f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			KBOPGONOCNP().SetFloat("_TimeX", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("LastHighScoreText", PosX);
			AELJLBOJAIL().SetFloat("Save", PosY);
			ALABBJPHCNG().SetFloat("curScn", Speed);
			OHKGGPFGLFD().SetFloat("Playing ", FPECJFFEDOM);
			MNLKBFFKHIE().SetVector("[PhotonMessageInfo: Sender='{1}' Senttime={0}]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1938f, 345f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NDMPCDHADMJ());
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
		SCShader = Shader.Find("Received RPC: ");
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
			EPCGJFCCAFH().SetFloat("Joystick1Button0", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", PosX);
			ADGHJOHKEHG().SetFloat("/../", PosY);
			AELJLBOJAIL().SetFloat("CameraFilterPack/FX_Funk", Speed);
			NMDBCDFPGOK().SetFloat("LevelNameInputField", FPECJFFEDOM);
			LPDOGGFOBDH().SetVector("Music End", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1681f, 627f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
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
			MNLKBFFKHIE().SetFloat("_RedAmplifier", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("#forever", PosX);
			MICHFGAOPKM().SetFloat("Gameplay/particles", PosY);
			PDEAHJPOMEF().SetFloat("_TileTexDebug", Speed);
			DOMEEFLPEPJ().SetFloat("_Value", FPECJFFEDOM);
			MNLKBFFKHIE().SetVector("Object ID. Case-Sensitive", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1346f, 870f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PHGCJOPFDOG());
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
			DKNJGHFLAIF().SetFloat("CameraFilterPack/Vision_Aura", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("<color=#{0}>{1}</color>", PosX);
			MNLKBFFKHIE().SetFloat("CameraFilterPack/Glow_Glow_Color", PosY);
			NBPKMLMCHFN.SetFloat("traffic", Speed);
			EOCCJGIGEGJ().SetFloat("#close", FPECJFFEDOM);
			NJDIODJNGGA().SetVector("tintColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1345f, 1340f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MICHFGAOPKM());
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
		SCShader = Shader.Find("Default UI Material");
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
			OCMBHMLNCEK().SetFloat("sfxVolume", HBJJOCHGOPH);
			DOMEEFLPEPJ().SetFloat("Turn", PosX);
			HILDKDFEBPF().SetFloat("). ", PosY);
			KBOPGONOCNP().SetFloat("Missing shader in ", Speed);
			MICHFGAOPKM().SetFloat("Drop_Far", FPECJFFEDOM);
			IGIAPKPKGPK().SetVector("Trackpad", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1318f, 1209f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PHGCJOPFDOG());
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
		SCShader = Shader.Find("CameraFilterPack/Blend2Camera_HardMix");
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
		SCShader = Shader.Find("/");
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
			NDMPCDHADMJ().SetFloat("_Value2", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("A", PosX);
			NMDBCDFPGOK().SetFloat("RoomNameText", PosY);
			NJDIODJNGGA().SetFloat("_CameraClipInfo", Speed);
			PDEAHJPOMEF().SetFloat(" room(s)", FPECJFFEDOM);
			LPDOGGFOBDH().SetVector("[PlayerBase] SetPlayerDistance error: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 667f, 265f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NNFMIAFHMJM()
	{
		SCShader = Shader.Find("https://bitbucket.org/khb-soft/intralismarcsviewer/");
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
		SCShader = Shader.Find("R:");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EPEGAEGDJAM()
	{
		SCShader = Shader.Find("[Up-Left]");
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
			EPCGJFCCAFH().SetFloat(" is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package.", HBJJOCHGOPH);
			ALABBJPHCNG().SetFloat("s", PosX);
			OHKGGPFGLFD().SetFloat("BloodAlternative1", PosY);
			ADGHJOHKEHG().SetFloat("id", Speed);
			NBPKMLMCHFN.SetFloat("_TimeX", FPECJFFEDOM);
			IGIAPKPKGPK().SetVector("UseScanLineSize", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 356f, 865f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PHGCJOPFDOG());
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
			NBPKMLMCHFN.SetFloat("_TimeX", HBJJOCHGOPH);
			HILDKDFEBPF().SetFloat("BitsData", PosX);
			MNLKBFFKHIE().SetFloat(" beatThreshold: ", PosY);
			IIBLJCKLGFG().SetFloat("Right Stick Click", Speed);
			MICHFGAOPKM().SetFloat("_ScreenResolution", FPECJFFEDOM);
			PDEAHJPOMEF().SetVector("Server: {0}. Region: {1} ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 939f, 364f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HILDKDFEBPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DLBODOFAJGM()
	{
		SCShader = Shader.Find("_Value3");
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
		SCShader = Shader.Find("_Value5");
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
		SCShader = Shader.Find(".");
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
		SCShader = Shader.Find("inventory.selected.");
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
			KBOPGONOCNP().SetFloat("OnJoinedLobby(). This client is connected and does get a room-list, which gets stored as PhotonNetwork.GetRoomList(). This script now calls: PhotonNetwork.JoinRandomRoom();", HBJJOCHGOPH);
			OHKGGPFGLFD().SetFloat("%]</b> ", PosX);
			GKILCDHJFEG().SetFloat("_Params", PosY);
			EHDJJANLINB().SetFloat("_Value4", Speed);
			GKILCDHJFEG().SetFloat(" : ", FPECJFFEDOM);
			MNLKBFFKHIE().SetVector("_PColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1687f, 801f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
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
		SCShader = Shader.Find("_Threshold");
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
			KGOLDDBHIFN().SetFloat(" to ", HBJJOCHGOPH);
			LENEJAGLCNL().SetFloat("DPADHOR", PosX);
			NDMPCDHADMJ().SetFloat("id", PosY);
			PDEAHJPOMEF().SetFloat("MascotChallenge2019", Speed);
			ALABBJPHCNG().SetFloat(",", FPECJFFEDOM);
			KGOLDDBHIFN().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1344f, 668f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NJDIODJNGGA());
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
		SCShader = Shader.Find(". local RequestedView.ownerId: ");
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
		SCShader = Shader.Find("float,1");
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
			KGOLDDBHIFN().SetFloat("id", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", PosX);
			OCMBHMLNCEK().SetFloat("CloseConnection: Only the masterclient can kick another player.", PosY);
			NBPKMLMCHFN.SetFloat("MusicFileSelector", Speed);
			MICHFGAOPKM().SetFloat("CameraFilterPack/3D_Shield", FPECJFFEDOM);
			MNLKBFFKHIE().SetVector("_CurveTex", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1862f, 1013f));
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
		SCShader = Shader.Find("_Intensity");
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
			LPDOGGFOBDH().SetFloat("[ImageLoader] Loaded image from ", HBJJOCHGOPH);
			OCMBHMLNCEK().SetFloat("_Value4", PosX);
			IGIAPKPKGPK().SetFloat("#onfirstranktext", PosY);
			GKILCDHJFEG().SetFloat("CameraFilterPack/Atmosphere_Rain_Pro_3D", Speed);
			ALABBJPHCNG().SetFloat(": ", FPECJFFEDOM);
			MICHFGAOPKM().SetVector("#getrewardfailed: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1735f, 983f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
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
			LPDOGGFOBDH().SetFloat("_Value4", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("Tab1Content", PosX);
			NDMPCDHADMJ().SetFloat("offsets", PosY);
			OHKGGPFGLFD().SetFloat("<b>HP</b>:", Speed);
			OHKGGPFGLFD().SetFloat("1332644700", FPECJFFEDOM);
			KBOPGONOCNP().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 523f, 1313f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HILDKDFEBPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JABNHMIHBHC()
	{
		SCShader = Shader.Find("1248864821");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MDNHCLKNCLE()
	{
		SCShader = Shader.Find(" .");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NPLCENPNJBM()
	{
		SCShader = Shader.Find("Exit to Windows");
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
		SCShader = Shader.Find("_ChromaticAberration");
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
			PHGCJOPFDOG().SetFloat("players", HBJJOCHGOPH);
			EHDJJANLINB().SetFloat("CameraFilterPack/BlurTiltShift", PosX);
			MICHFGAOPKM().SetFloat(" respawn: ", PosY);
			EHDJJANLINB().SetFloat("_Green_R", Speed);
			EHDJJANLINB().SetFloat("#ok", FPECJFFEDOM);
			GKILCDHJFEG().SetVector("CameraFilterPack_TV_BrokenGlass_2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1387f, 1456f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOMEEFLPEPJ());
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
			EOCCJGIGEGJ().SetFloat("x", HBJJOCHGOPH);
			IGIAPKPKGPK().SetFloat("challenges.", PosX);
			PDEAHJPOMEF().SetFloat("_ScreenResolution", PosY);
			EPCGJFCCAFH().SetFloat("GameScene", Speed);
			OHKGGPFGLFD().SetFloat("value", FPECJFFEDOM);
			MICHFGAOPKM().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1990f, 1993f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
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
		SCShader = Shader.Find("ConnectToRegion() failed. Can only connect while in state 'Disconnected'. Current state: ");
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
			LPDOGGFOBDH().SetFloat("%", HBJJOCHGOPH);
			ADGHJOHKEHG().SetFloat("settings.enableselectormusic", PosX);
			EHDJJANLINB().SetFloat("file://", PosY);
			EHDJJANLINB().SetFloat("CameraFilterPack/Blend2Camera_PinLight", Speed);
			EPCGJFCCAFH().SetFloat("Connecting", FPECJFFEDOM);
			LENEJAGLCNL().SetVector(".played", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1158f, 1206f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OCMBHMLNCEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ICILLMAKLMI()
	{
		SCShader = Shader.Find("PlaySound");
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
			KGOLDDBHIFN().SetFloat("#C8C8C8FF", HBJJOCHGOPH);
			OHKGGPFGLFD().SetFloat(" elements", PosX);
			MNLKBFFKHIE().SetFloat("LoadingStatusText", PosY);
			OHKGGPFGLFD().SetFloat("{0:0.0} ms ({1:0.} fps)", Speed);
			PDEAHJPOMEF().SetFloat("#tryagain", FPECJFFEDOM);
			OCMBHMLNCEK().SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 388f, 1084f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PHGCJOPFDOG());
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
		SCShader = Shader.Find("LoadPlayerSkin");
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
		SCShader = Shader.Find("SetCrosshairColor");
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
		SCShader = Shader.Find("EventData0DropDownList");
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
		SCShader = Shader.Find("ChangeSelectedLevel");
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
			NDMPCDHADMJ().SetFloat("DeleteButton", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("_Value", PosX);
			LENEJAGLCNL().SetFloat(". Verify the Prefab is in a Resources folder (and not in a subfolder)", PosY);
			ALABBJPHCNG().SetFloat("_Vignette", Speed);
			IIBLJCKLGFG().SetFloat("_TimeX", FPECJFFEDOM);
			OHKGGPFGLFD().SetVector("?", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 254f, 1789f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGIAPKPKGPK());
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
		SCShader = Shader.Find("mapselector.lastSearch");
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
			IIBLJCKLGFG().SetFloat("Multiplayer", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("#close", PosX);
			HILDKDFEBPF().SetFloat("masterSteamID", PosY);
			HILDKDFEBPF().SetFloat("_Value4", Speed);
			NMDBCDFPGOK().SetFloat(".r", FPECJFFEDOM);
			DKNJGHFLAIF().SetVector("Object ID. Case-Sensitive", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1158f, 834f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MNLKBFFKHIE());
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
