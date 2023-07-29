// CameraFilterPack_Blend2Camera_SplitScreen3D
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Split Screen/Split 3D")]
[ExecuteInEditMode]
public class CameraFilterPack_Blend2Camera_SplitScreen3D : MonoBehaviour
{
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_SplitScreen3D";

	public Shader SCShader;

	public Camera Camera2;

	private float HBJJOCHGOPH = 1f;

	private Material BJFKDHHMLJH;

	[Range(0f, 100f)]
	public float _FixDistance = 1f;

	[Range(-0.99f, 0.99f)]
	public float _Distance = 0.5f;

	[Range(0f, 0.5f)]
	public float _Size = 0.1f;

	[Range(0f, 1f)]
	public float SwitchCameraToCamera2;

	[Range(0f, 1f)]
	public float BlendFX = 1f;

	[Range(-3f, 3f)]
	public float SplitX = 0.5f;

	[Range(-3f, 3f)]
	public float SplitY = 0.5f;

	[Range(0f, 2f)]
	public float Smooth = 0.1f;

	[Range(-3.14f, 3.14f)]
	public float Rotation = 3.14f;

	private bool CONEELGCALI;

	private RenderTexture JDMCFBKJHDD;

	private Vector2 FPEMMGKMJGA;

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

	private void GNPDGBNDCPL()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MKKJICPMPHK()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void ABKHEFGLAOJ()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void FPHLDMMAOEF()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OnEnable()
	{
		Start();
	}

	private void JNALDALAJLG()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 202f)
			{
				HBJJOCHGOPH = 704f;
			}
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture("player.xp", JDMCFBKJHDD);
			}
			ABHDNGIHBKE().SetFloat("_Visualize", _Distance);
			NMDBCDFPGOK().SetFloat("maps.", _Size);
			ADBKPGFMNKO().SetFloat("OK", _FixDistance);
			LNLKMDPHDCC().SetFloat("BitsData", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("_GrainOffsetScale", BlendFX);
			LPMLLJKMAMP().SetFloat("settings.enablehitsoundsinnormal", SwitchCameraToCamera2);
			NMDBCDFPGOK().SetFloat("rarity", SplitX);
			KDMBOKLMADJ().SetFloat("CameraFilterPack/Color_Convert_Normal", SplitY);
			FLGPDBBKAIP().SetFloat("DisableStoryboardToggle", Smooth);
			ADBKPGFMNKO().SetFloat("#pleasewait", Rotation);
			HKHBBBFLGJH().SetInt("MaxLivesSlider", (!CONEELGCALI) ? 0 : 0);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HJGEHJDMCGI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EGEPLFGKGLI()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 79);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DFFKKLAPHCC()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 79);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EGEGNHLODAA()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void BEKMLIFILFP()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 70);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OnValidate()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void AENIGCONKBD()
	{
		Start();
	}

	private void FLHBCHLMOFK()
	{
		KOFAMEKHHGD();
	}

	private void DBGBCCBHBBC()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void PMAADPNNHKK()
	{
		Start();
	}

	[SpecialName]
	private Material HJGEHJDMCGI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)104;
		}
		return BJFKDHHMLJH;
	}

	private void IKIDIJLIGOH()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void LDDKCCMHMIC()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void MEJPBKFMAIG()
	{
		EGEPLFGKGLI();
	}

	private void ICDBMJKMIKC()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CNPINCHINJA()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1315f)
			{
				HBJJOCHGOPH = 1503f;
			}
			if (Camera2 != null)
			{
				HFBJAOFLCJI().SetTexture("_Threshhold", JDMCFBKJHDD);
			}
			GCDFNHMJMIP().SetFloat("_Intervale", _Distance);
			NKBIEMJBCBM().SetFloat("CameraFilterPack/Drawing_Manga3", _Size);
			MCDGIILBNIF().SetFloat("Connection error: ", _FixDistance);
			OOMFJGPAOKL().SetFloat("b", HBJJOCHGOPH);
			LPMLLJKMAMP().SetFloat("<color=#", BlendFX);
			KAFBNOBOIAJ().SetFloat("clear", SwitchCameraToCamera2);
			NMDBCDFPGOK().SetFloat("GameMessagesDurationSlider", SplitX);
			ECCPAOBFDKP().SetFloat("SetEnvSpriteImage", SplitY);
			NMDBCDFPGOK().SetFloat("LevelNameInputField", Smooth);
			HKHBBBFLGJH().SetFloat("note.1", Rotation);
			HJGEHJDMCGI().SetInt("BitsData", (!CONEELGCALI) ? 1 : 0);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BAEHKBADMAO()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IBEAPBDAOCC()
	{
		NEFHGMNAPEP();
	}

	private void CAKNMILHHNE()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Update()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void GFACKFCEIBC()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void ANBIJFCCANE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1273f)
			{
				HBJJOCHGOPH = 1390f;
			}
			if (Camera2 != null)
			{
				LPDOGGFOBDH().SetTexture("Stream did not contain properly formatted byte array", JDMCFBKJHDD);
			}
			FLGPDBBKAIP().SetFloat("High", _Distance);
			EFDEIFCDAFG().SetFloat("_DepthLevel", _Size);
			OOMFJGPAOKL().SetFloat("GridDataArcs", _FixDistance);
			LNLKMDPHDCC().SetFloat("Edited hands count", HBJJOCHGOPH);
			LPDOGGFOBDH().SetFloat("_FixDistance", BlendFX);
			KDMBOKLMADJ().SetFloat("roomDescription", SwitchCameraToCamera2);
			MCDGIILBNIF().SetFloat("Cant send PickupItem spawn times to unknown targetPlayer.", SplitX);
			KAFBNOBOIAJ().SetFloat("_VignettingDirt", SplitY);
			HJGEHJDMCGI().SetFloat("default", Smooth);
			HJGEHJDMCGI().SetFloat("Tab2Content", Rotation);
			ABHDNGIHBKE().SetInt("SetSunSensitivity", (!CONEELGCALI) ? 1 : 0);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HDDECCMEJKA()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	[SpecialName]
	private Material ABHDNGIHBKE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void KMEONPMCNJG()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void OOBIMFILNED()
	{
		AGEJKLMJGDO();
	}

	private void OCNIANNJIPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 820f)
			{
				HBJJOCHGOPH = 1714f;
			}
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture("SupportLogger OnDisconnectedFromPhoton().", JDMCFBKJHDD);
			}
			KGOLDDBHIFN().SetFloat("_CenterY", _Distance);
			GCDFNHMJMIP().SetFloat("_Value2", _Size);
			KGOLDDBHIFN().SetFloat("CameraFilterPack/Distortion_Heat", _FixDistance);
			FLGPDBBKAIP().SetFloat("id", HBJJOCHGOPH);
			FLGPDBBKAIP().SetFloat("accuracy", BlendFX);
			ADBKPGFMNKO().SetFloat("<b>", SwitchCameraToCamera2);
			NBPKMLMCHFN.SetFloat("_InvRenderTargetSize", SplitX);
			NBPKMLMCHFN.SetFloat("_Value2", SplitY);
			NKBIEMJBCBM().SetFloat("#exit", Smooth);
			CBCNOEIALHB().SetFloat("GameMessagesDurationSlider", Rotation);
			ADBKPGFMNKO().SetInt(" canvas not found", CONEELGCALI ? 1 : 0);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LCDJFJIBADI()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1218f)
			{
				HBJJOCHGOPH = 292f;
			}
			if (Camera2 != null)
			{
				OOMFJGPAOKL().SetTexture("_FarCamera", JDMCFBKJHDD);
			}
			HKHBBBFLGJH().SetFloat("Can't find key ", _Distance);
			AELJLBOJAIL().SetFloat("CameraFilterPack/TV_BrokenGlass2", _Size);
			PDEAHJPOMEF().SetFloat("maps.", _FixDistance);
			ECCPAOBFDKP().SetFloat("_TimeX", HBJJOCHGOPH);
			OOMFJGPAOKL().SetFloat("_Value2", BlendFX);
			ACHNOHCLGOO().SetFloat("Horizontal", SwitchCameraToCamera2);
			ACHNOHCLGOO().SetFloat("SetSunColors", SplitX);
			AELJLBOJAIL().SetFloat("0", SplitY);
			LPDOGGFOBDH().SetFloat("_ScreenResolution", Smooth);
			NMDBCDFPGOK().SetFloat("Jan", Rotation);
			KAFBNOBOIAJ().SetInt("_Distortion", (!CONEELGCALI) ? 1 : 1);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LPMINJJPDCH()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void FODKODGPPDA()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material EFDEIFCDAFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return BJFKDHHMLJH;
	}

	private void PNLKFANNOKO()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	[SpecialName]
	private Material NKBIEMJBCBM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-109);
		}
		return BJFKDHHMLJH;
	}

	private void AENGMPAMCFL()
	{
		NEFHGMNAPEP();
	}

	private void JOONHGHGKKF()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BNEJMABFKJE()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material AELJLBOJAIL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)104;
		}
		return BJFKDHHMLJH;
	}

	private void OHIJGCLBMJL()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KCDOMIJBFLL()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	[SpecialName]
	private Material LNLKMDPHDCC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void KGHFKHBPHEH()
	{
		JFJLGJEPEAA();
	}

	private void LGJAHGCLMLE()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void BKGJOECFMID()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ELKELFCGMPE()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ONKDMMJPEMN()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	[SpecialName]
	private Material LPDOGGFOBDH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)97;
		}
		return BJFKDHHMLJH;
	}

	private void IKMELABKBHO()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void BLKGOMCPEKI()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GOANCMNGDLE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 435f)
			{
				HBJJOCHGOPH = 366f;
			}
			if (Camera2 != null)
			{
				LPDOGGFOBDH().SetTexture("_LightIntensity", JDMCFBKJHDD);
			}
			MCDGIILBNIF().SetFloat("_ColorLevel", _Distance);
			LNLKMDPHDCC().SetFloat("USE_DIAG_SEARCH", _Size);
			NMDBCDFPGOK().SetFloat("Image", _FixDistance);
			OOMFJGPAOKL().SetFloat("_Value7", HBJJOCHGOPH);
			LPMLLJKMAMP().SetFloat("speed", BlendFX);
			NMDBCDFPGOK().SetFloat("_TimeX", SwitchCameraToCamera2);
			ECCPAOBFDKP().SetFloat("float", SplitX);
			CBCNOEIALHB().SetFloat("CameraFilterPack/Blend2Camera_VividLight", SplitY);
			DOMEEFLPEPJ().SetFloat("Item invalid. Make sure your mod contains at leats one file.", Smooth);
			ACHNOHCLGOO().SetFloat("_Offsets", Rotation);
			KDMBOKLMADJ().SetInt(".a", (!CONEELGCALI) ? 1 : 0);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ECCPAOBFDKP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EBBOJPEPDCN()
	{
		KOFAMEKHHGD();
	}

	[SpecialName]
	private Material MCDGIILBNIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void DPGHJILBPCE()
	{
		NEFHGMNAPEP();
	}

	private void DBLILJGKGHJ()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 125);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OAKONCDEPPI()
	{
		JFJLGJEPEAA();
	}

	private void CPMAAHPLGOP()
	{
		BMIOFJFMCBG();
	}

	private void OEAMLMGNFFC()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void KOFAMEKHHGD()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 53);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 975f)
			{
				HBJJOCHGOPH = 104f;
			}
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture("_FarCamera", JDMCFBKJHDD);
			}
			EFDEIFCDAFG().SetFloat("menu.tabid", _Distance);
			HKHBBBFLGJH().SetFloat("You need to have a Graphic control (such as an Image) for the list [", _Size);
			ADBKPGFMNKO().SetFloat("BlockCount", _FixDistance);
			NMDBCDFPGOK().SetFloat("_Value", HBJJOCHGOPH);
			NMDBCDFPGOK().SetFloat("achievements.21.completed.workshop.", BlendFX);
			NMDBCDFPGOK().SetFloat("settings.customdataskin", SwitchCameraToCamera2);
			LPMLLJKMAMP().SetFloat("float,50", SplitX);
			EFDEIFCDAFG().SetFloat("bans.viewed.", SplitY);
			ADBKPGFMNKO().SetFloat("Object ID. Case-Sensitive", Smooth);
			DOMEEFLPEPJ().SetFloat("_ExposureAdjustment", Rotation);
			ECCPAOBFDKP().SetInt("UseFinalGlassColor", (!CONEELGCALI) ? 0 : 0);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IBHACCEEFFI()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void AEIJFLJEABG()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void LIEEGINIKOK()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	[SpecialName]
	private Material CBCNOEIALHB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)110;
		}
		return BJFKDHHMLJH;
	}

	private void PPGEGFMNIKO()
	{
		JKBMKPDGCHG();
	}

	[SpecialName]
	private Material ACHNOHCLGOO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	private void EAOKCECGKAK()
	{
		AEOLJEIDMDB();
	}

	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1455f)
			{
				HBJJOCHGOPH = 1496f;
			}
			if (Camera2 != null)
			{
				MCDGIILBNIF().SetTexture("float,2", JDMCFBKJHDD);
			}
			KGOLDDBHIFN().SetFloat("_Visualize", _Distance);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", _Size);
			LNLKMDPHDCC().SetFloat("/", _FixDistance);
			CBCNOEIALHB().SetFloat("[PlayerController] ", HBJJOCHGOPH);
			LPDOGGFOBDH().SetFloat("_Value6", BlendFX);
			CBCNOEIALHB().SetFloat("EnableRankedNotificationsToggle", SwitchCameraToCamera2);
			OOMFJGPAOKL().SetFloat("Time Offset: {0}", SplitX);
			KDMBOKLMADJ().SetFloat("Rock", SplitY);
			LPMLLJKMAMP().SetFloat("SlidingArea", Smooth);
			NBPKMLMCHFN.SetFloat("_FgOverlap", Rotation);
			PDEAHJPOMEF().SetInt("DPADHOR", (!CONEELGCALI) ? 1 : 1);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLGPDBBKAIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OIKAPFGPLML(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1979f)
			{
				HBJJOCHGOPH = 369f;
			}
			if (Camera2 != null)
			{
				PDEAHJPOMEF().SetTexture("_BlurParams", JDMCFBKJHDD);
			}
			EFDEIFCDAFG().SetFloat("LoadingStatusText", _Distance);
			KDMBOKLMADJ().SetFloat("VisionBlur", _Size);
			EFDEIFCDAFG().SetFloat("LivesSlider", _FixDistance);
			CBCNOEIALHB().SetFloat("OnReadyClick", HBJJOCHGOPH);
			OOMFJGPAOKL().SetFloat("closed", BlendFX);
			DOMEEFLPEPJ().SetFloat("_FarCorner", SwitchCameraToCamera2);
			AELJLBOJAIL().SetFloat("settings.hitvariation", SplitX);
			HKHBBBFLGJH().SetFloat("_Visualize", SplitY);
			OOMFJGPAOKL().SetFloat("icon", Smooth);
			NBPKMLMCHFN.SetFloat("_SceneFogParams", Rotation);
			HJGEHJDMCGI().SetInt("CameraFilterPack/FX_superDot", (!CONEELGCALI) ? 0 : 0);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NMDBCDFPGOK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Start()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 24);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OIBMHPIFAKK()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void JKBMKPDGCHG()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -88);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CNDACAHCCOI()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MOMGJJDIFFI()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void PBEPCAPAKLG()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	[SpecialName]
	private Material KDMBOKLMADJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void LNOOFNGHNEL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1501f)
			{
				HBJJOCHGOPH = 744f;
			}
			if (Camera2 != null)
			{
				KDMBOKLMADJ().SetTexture("_MainTexBlurred", JDMCFBKJHDD);
			}
			FLGPDBBKAIP().SetFloat(". local RequestedView.ownerId: ", _Distance);
			NBPKMLMCHFN.SetFloat("Hidden/ScreenSpaceReflection", _Size);
			KDMBOKLMADJ().SetFloat("LevelEditor/patterns", _FixDistance);
			HKHBBBFLGJH().SetFloat("#md5submitionfailed: ", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("#no", BlendFX);
			ACHNOHCLGOO().SetFloat("_Visualize", SwitchCameraToCamera2);
			HFBJAOFLCJI().SetFloat("Tab2Content", SplitX);
			CBCNOEIALHB().SetFloat("_Rand", SplitY);
			KDMBOKLMADJ().SetFloat("GlassAberration", Smooth);
			NKBIEMJBCBM().SetFloat("_BokehParams", Rotation);
			ABHDNGIHBKE().SetInt("Texture3", CONEELGCALI ? 1 : 0);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GMELGGJOPBB()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void NEFHGMNAPEP()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 64);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material ADBKPGFMNKO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-103);
		}
		return BJFKDHHMLJH;
	}

	private void LLAJPKFNDIG()
	{
		JKBMKPDGCHG();
	}

	private void GGELPAHPFAJ()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
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
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture("_MainTex2", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat("_Near", _Distance);
			NBPKMLMCHFN.SetFloat("_Far", _Size);
			NBPKMLMCHFN.SetFloat("_FixDistance", _FixDistance);
			NBPKMLMCHFN.SetFloat("_TimeX", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value", BlendFX);
			NBPKMLMCHFN.SetFloat("_Value2", SwitchCameraToCamera2);
			NBPKMLMCHFN.SetFloat("_Value3", SplitX);
			NBPKMLMCHFN.SetFloat("_Value6", SplitY);
			NBPKMLMCHFN.SetFloat("_Value4", Smooth);
			NBPKMLMCHFN.SetFloat("_Value5", Rotation);
			NBPKMLMCHFN.SetInt("_ForceYSwap", (!CONEELGCALI) ? 1 : 0);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void POENGNEMHJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1962f)
			{
				HBJJOCHGOPH = 770f;
			}
			if (Camera2 != null)
			{
				ACHNOHCLGOO().SetTexture("Objects in List: ", JDMCFBKJHDD);
			}
			LPDOGGFOBDH().SetFloat("/", _Distance);
			EFDEIFCDAFG().SetFloat("settings.fps", _Size);
			NBPKMLMCHFN.SetFloat("PublishButton", _FixDistance);
			KAFBNOBOIAJ().SetFloat(": ", HBJJOCHGOPH);
			LPMLLJKMAMP().SetFloat("_TimeX", BlendFX);
			HFBJAOFLCJI().SetFloat("_SpawnHeuristic", SwitchCameraToCamera2);
			KGOLDDBHIFN().SetFloat("CameraFilterPack_VHS1", SplitX);
			ACHNOHCLGOO().SetFloat("time", SplitY);
			MCDGIILBNIF().SetFloat("_TimeX", Smooth);
			ECCPAOBFDKP().SetFloat("_Value", Rotation);
			HJGEHJDMCGI().SetInt(" from: ", (!CONEELGCALI) ? 1 : 0);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MAMFKACDKDP()
	{
		NEFHGMNAPEP();
	}

	private void LLKKGGLNIDF()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EJFJENFKLND()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void JFMIDILENDO()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void JFJLGJEPEAA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -116);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 123f)
			{
				HBJJOCHGOPH = 1672f;
			}
			if (Camera2 != null)
			{
				KAFBNOBOIAJ().SetTexture("_PixelsPerMeterAtOneMeter", JDMCFBKJHDD);
			}
			CBCNOEIALHB().SetFloat("_SizeX", _Distance);
			KGOLDDBHIFN().SetFloat("_Value2", _Size);
			LPMLLJKMAMP().SetFloat("note.2", _FixDistance);
			ACHNOHCLGOO().SetFloat("selector", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat("Set particles count per one beat", BlendFX);
			LPMLLJKMAMP().SetFloat("_TimeX", SwitchCameraToCamera2);
			KGOLDDBHIFN().SetFloat("_EmissionGain", SplitX);
			OOMFJGPAOKL().SetFloat("\\n", SplitY);
			PDEAHJPOMEF().SetFloat("[PlayerBase] Loaded environment: ", Smooth);
			ACHNOHCLGOO().SetFloat("#000000CC", Rotation);
			KAFBNOBOIAJ().SetInt("IconImage", (!CONEELGCALI) ? 1 : 1);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KMKLDAJLCNM()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void JBAPHFIBANG()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void GEGDELOFIML()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void DIGHKAJILJH()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OKHBBIKDIEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1619f)
			{
				HBJJOCHGOPH = 218f;
			}
			if (Camera2 != null)
			{
				HKHBBBFLGJH().SetTexture("_Green_B", JDMCFBKJHDD);
			}
			KAFBNOBOIAJ().SetFloat("CameraFilterPack/Drawing_NewCellShading", _Distance);
			EFDEIFCDAFG().SetFloat("maps.", _Size);
			DOMEEFLPEPJ().SetFloat("================================", _FixDistance);
			KGOLDDBHIFN().SetFloat("_TimeX", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("No regions available. Are you sure your appid is valid and setup?", BlendFX);
			HFBJAOFLCJI().SetFloat("_History4LumaTex", SwitchCameraToCamera2);
			HFBJAOFLCJI().SetFloat("ResetButton", SplitX);
			NMDBCDFPGOK().SetFloat(" {0}", SplitY);
			ECCPAOBFDKP().SetFloat("offsets", Smooth);
			DOMEEFLPEPJ().SetFloat(".completedMaps", Rotation);
			LPDOGGFOBDH().SetInt("_PositionX", (!CONEELGCALI) ? 1 : 0);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BNJEFIBPJLO()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1174f)
			{
				HBJJOCHGOPH = 1416f;
			}
			if (Camera2 != null)
			{
				DOMEEFLPEPJ().SetTexture("InventoryButton", JDMCFBKJHDD);
			}
			PDEAHJPOMEF().SetFloat("/../", _Distance);
			LPMLLJKMAMP().SetFloat("speed", _Size);
			NBPKMLMCHFN.SetFloat("[Left]", _FixDistance);
			DOMEEFLPEPJ().SetFloat(".lastCheckpoint.bgcolor", HBJJOCHGOPH);
			CBCNOEIALHB().SetFloat("MaxLivesSlider", BlendFX);
			HFBJAOFLCJI().SetFloat("Case-Sensitive", SwitchCameraToCamera2);
			PDEAHJPOMEF().SetFloat("(\\[ */ *quote *\\])", SplitX);
			LPMLLJKMAMP().SetFloat("Coord", SplitY);
			LPDOGGFOBDH().SetFloat("Failed to InstantiateSceneObject prefab: ", Smooth);
			KGOLDDBHIFN().SetFloat("PunRespawn", Rotation);
			FLGPDBBKAIP().SetInt(":", (!CONEELGCALI) ? 1 : 1);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material KGOLDDBHIFN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)81;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material LPMLLJKMAMP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-1);
		}
		return BJFKDHHMLJH;
	}

	private void JMAIIENCEKE()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CFIAKIJAILI()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	[SpecialName]
	private Material KAFBNOBOIAJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)100;
		}
		return BJFKDHHMLJH;
	}

	private void NFEDLAOPHML()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void IHAGANPOFDP()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	[SpecialName]
	private Material HKHBBBFLGJH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideAndDontSave | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	private void BKCJHBJCAKO()
	{
		KOFAMEKHHGD();
	}

	[SpecialName]
	private Material OOMFJGPAOKL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void CCKABCDEOJC()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	[SpecialName]
	private Material HFBJAOFLCJI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void AGEJKLMJGDO()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 126);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CIHGFHNNFEE()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HFLHDMPHOJA()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void BMIOFJFMCBG()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -119);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JOJFHFHOCHO()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OnDisable()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CLBJLKBNHOK()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void FPFJGEHEOPF()
	{
		DBLILJGKGHJ();
	}

	[SpecialName]
	private Material ECCPAOBFDKP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void KKLMPKLKAEM()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	[SpecialName]
	private Material GCDFNHMJMIP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-88);
		}
		return BJFKDHHMLJH;
	}

	private void FOLDLDLFFLM()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void KDJEJBBDILE()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void OCHCKGMIDND()
	{
		JFJLGJEPEAA();
	}

	private void FKDKJKCAHJC()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void ANCKKLFPGDI()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 81);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OFMNDBNFBDJ()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KFMEAMBLODG()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	[SpecialName]
	private Material FLGPDBBKAIP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void KDMANOEMOCA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -35);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FINDGJLEHOL()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 994f)
			{
				HBJJOCHGOPH = 1640f;
			}
			if (Camera2 != null)
			{
				KDMBOKLMADJ().SetTexture("intensity", JDMCFBKJHDD);
			}
			ECCPAOBFDKP().SetFloat("mapselector.tags.", _Distance);
			ADBKPGFMNKO().SetFloat("Bad parameters for setbool! Use <key> <value>", _Size);
			HFBJAOFLCJI().SetFloat(" not exist", _FixDistance);
			KGOLDDBHIFN().SetFloat("_BlurRadius", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("FileMenu", BlendFX);
			HFBJAOFLCJI().SetFloat("PlayButton", SwitchCameraToCamera2);
			HFBJAOFLCJI().SetFloat("menu.selectedlevelid", SplitX);
			FLGPDBBKAIP().SetFloat("settings.customdataskin", SplitY);
			LPMLLJKMAMP().SetFloat("_Value3", Smooth);
			PDEAHJPOMEF().SetFloat("UNDISTORT", Rotation);
			ABHDNGIHBKE().SetInt("Exception while connecting to: ", CONEELGCALI ? 1 : 0);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OOMFJGPAOKL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1025f)
			{
				HBJJOCHGOPH = 748f;
			}
			if (Camera2 != null)
			{
				MCDGIILBNIF().SetTexture("CameraFilterPack/AAA_WaterDrop", JDMCFBKJHDD);
			}
			LPDOGGFOBDH().SetFloat("AvatarImage", _Distance);
			PDEAHJPOMEF().SetFloat("ShowTitle", _Size);
			DOMEEFLPEPJ().SetFloat("_CenterY", _FixDistance);
			NKBIEMJBCBM().SetFloat("colorD", HBJJOCHGOPH);
			FLGPDBBKAIP().SetFloat("_Value", BlendFX);
			HJGEHJDMCGI().SetFloat(" - Contains ", SwitchCameraToCamera2);
			KGOLDDBHIFN().SetFloat("_Value3", SplitX);
			MCDGIILBNIF().SetFloat("_TimeX", SplitY);
			NBPKMLMCHFN.SetFloat("\t", Smooth);
			KGOLDDBHIFN().SetFloat("_Green_G", Rotation);
			LPMLLJKMAMP().SetInt("offsets", (!CONEELGCALI) ? 0 : 0);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BMBIGILMLLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1094f)
			{
				HBJJOCHGOPH = 233f;
			}
			if (Camera2 != null)
			{
				NKBIEMJBCBM().SetTexture("HandleEventLeave for player ID: ", JDMCFBKJHDD);
			}
			PDEAHJPOMEF().SetFloat("_LutTex", _Distance);
			NKBIEMJBCBM().SetFloat("There was an error retrieving the NumberOfCurrentPlayers.", _Size);
			LNLKMDPHDCC().SetFloat("CameraFilterPack_WaterDrop", _FixDistance);
			HJGEHJDMCGI().SetFloat("Horizontal", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("_ScreenResolution", BlendFX);
			KGOLDDBHIFN().SetFloat("_Size", SwitchCameraToCamera2);
			MCDGIILBNIF().SetFloat("arcs", SplitX);
			ABHDNGIHBKE().SetFloat("_ProjectToPixelMatrix", SplitY);
			KDMBOKLMADJ().SetFloat("Error0", Smooth);
			PDEAHJPOMEF().SetFloat("#yes", Rotation);
			LNLKMDPHDCC().SetInt("_LensDirtIntensity", CONEELGCALI ? 1 : 0);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLGPDBBKAIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HMKJFPBFOFI()
	{
		NEFHGMNAPEP();
	}

	private void JDGFCEPDKAJ()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	[SpecialName]
	private Material DOMEEFLPEPJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-90);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NMDBCDFPGOK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-91);
		}
		return BJFKDHHMLJH;
	}

	private void CACCPBENDAP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1736f)
			{
				HBJJOCHGOPH = 471f;
			}
			if (Camera2 != null)
			{
				NMDBCDFPGOK().SetTexture("Working.\nPlease wait..", JDMCFBKJHDD);
			}
			ABHDNGIHBKE().SetFloat("Please specify either t or f.", _Distance);
			HKHBBBFLGJH().SetFloat("_ReflectionTexture0", _Size);
			HKHBBBFLGJH().SetFloat("Received event Leave for unknown player ID: {0}", _FixDistance);
			LPMLLJKMAMP().SetFloat("_Value2", HBJJOCHGOPH);
			FLGPDBBKAIP().SetFloat("_Intensity", BlendFX);
			KAFBNOBOIAJ().SetFloat("_TimeX", SwitchCameraToCamera2);
			NMDBCDFPGOK().SetFloat("LobbyCanvas", SplitX);
			ECCPAOBFDKP().SetFloat("_Far", SplitY);
			MCDGIILBNIF().SetFloat("CameraFilterPack_3D_Myst1", Smooth);
			HJGEHJDMCGI().SetFloat("_Value2", Rotation);
			ECCPAOBFDKP().SetInt("skin.", CONEELGCALI ? 1 : 0);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GGPDKCHEBAG()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void AEOLJEIDMDB()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 67);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ALMGMOOHLMA()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AKHCOBHHGJP()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 83);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MLAGEPNCCGM()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void HIFPDKKBDHJ()
	{
		EGEPLFGKGLI();
	}

	private void KFCCKOBOLAH()
	{
		DBLILJGKGHJ();
	}
}
