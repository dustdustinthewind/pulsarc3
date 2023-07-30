// CameraFilterPack_Blend2Camera_SplitScreen3D
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Split Screen/Split 3D")]
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
				ACHNOHCLGOO().SetTexture("player.xp", JDMCFBKJHDD);
			}
			KGOLDDBHIFN().SetFloat("_Visualize", _Distance);
			AELJLBOJAIL().SetFloat("maps.", _Size);
			LPDOGGFOBDH().SetFloat("Done!", _FixDistance);
			OOMFJGPAOKL().SetFloat("BitsData", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_GrainTex", BlendFX);
			NBPKMLMCHFN.SetFloat("powerup.0", SwitchCameraToCamera2);
			MCDGIILBNIF().SetFloat("#91CCFF", SplitX);
			OOMFJGPAOKL().SetFloat("CameraFilterPack/Color_Convert_Normal", SplitY);
			HJGEHJDMCGI().SetFloat("settings.enablehitsoundsinrelax", Smooth);
			DOMEEFLPEPJ().SetFloat("MAPS NOT FOUND", Rotation);
			HJGEHJDMCGI().SetInt("HandsCountSlider", (!CONEELGCALI) ? 0 : 0);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLGPDBBKAIP());
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
		AEOLJEIDMDB();
	}

	private void FLHBCHLMOFK()
	{
		EGEPLFGKGLI();
	}

	private void DBGBCCBHBBC()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void PMAADPNNHKK()
	{
		KDMANOEMOCA();
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
		JKBMKPDGCHG();
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
				LPMLLJKMAMP().SetTexture("colorD", JDMCFBKJHDD);
			}
			DOMEEFLPEPJ().SetFloat("_Heigh", _Distance);
			ECCPAOBFDKP().SetFloat("_DotSize", _Size);
			LNLKMDPHDCC().SetFloat("Connection error: ", _FixDistance);
			CBCNOEIALHB().SetFloat("r", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("#onrankchangedowntext", BlendFX);
			EFDEIFCDAFG().SetFloat("clear", SwitchCameraToCamera2);
			OOMFJGPAOKL().SetFloat("GameMessagesDurationSlider", SplitX);
			DOMEEFLPEPJ().SetFloat("SetParticlesParticleSpeed", SplitY);
			LPDOGGFOBDH().SetFloat("Tab1Content", Smooth);
			LNLKMDPHDCC().SetFloat("#ok", Rotation);
			NBPKMLMCHFN.SetInt("SpawnObj", (!CONEELGCALI) ? 1 : 0);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
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
		AGEJKLMJGDO();
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
				KGOLDDBHIFN().SetTexture("plainText", JDMCFBKJHDD);
			}
			ADBKPGFMNKO().SetFloat("High", _Distance);
			HKHBBBFLGJH().SetFloat("_DepthLevel", _Size);
			HFBJAOFLCJI().SetFloat("caret", _FixDistance);
			KAFBNOBOIAJ().SetFloat("Added event", HBJJOCHGOPH);
			NMDBCDFPGOK().SetFloat("_Visualize", BlendFX);
			KAFBNOBOIAJ().SetFloat("roomDescription", SwitchCameraToCamera2);
			KDMBOKLMADJ().SetFloat("RequestForPickupItems", SplitX);
			ECCPAOBFDKP().SetFloat("_Vignetting2", SplitY);
			HKHBBBFLGJH().SetFloat(".wav", Smooth);
			EFDEIFCDAFG().SetFloat("HandsCountSlider", Rotation);
			HKHBBBFLGJH().SetInt("SetSunInput", (!CONEELGCALI) ? 1 : 0);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
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
		EGEPLFGKGLI();
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
				HKHBBBFLGJH().SetTexture("). ", JDMCFBKJHDD);
			}
			HFBJAOFLCJI().SetFloat("_CenterY", _Distance);
			ABHDNGIHBKE().SetFloat("_Value", _Size);
			GCDFNHMJMIP().SetFloat("CameraFilterPack/Distortion_Heat", _FixDistance);
			NBPKMLMCHFN.SetFloat("Set Sun DirectionVector", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("score", BlendFX);
			CBCNOEIALHB().SetFloat("<b>", SwitchCameraToCamera2);
			PDEAHJPOMEF().SetFloat("_ForegroundBlurExtrude", SplitX);
			LPDOGGFOBDH().SetFloat("_Value", SplitY);
			NMDBCDFPGOK().SetFloat("#tryagain", Smooth);
			NKBIEMJBCBM().SetFloat("GameMessagesDurationSlider", Rotation);
			KDMBOKLMADJ().SetInt(" canvas not found", CONEELGCALI ? 1 : 0);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NMDBCDFPGOK());
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
				ADBKPGFMNKO().SetTexture("_FarCamera", JDMCFBKJHDD);
			}
			HJGEHJDMCGI().SetFloat("Keeping GameObject in the scene: ", _Distance);
			EFDEIFCDAFG().SetFloat("CameraFilterPack_TV_BrokenGlass_2", _Size);
			AELJLBOJAIL().SetFloat("maps.", _FixDistance);
			HJGEHJDMCGI().SetFloat("_TimeX", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("_Value2", BlendFX);
			HFBJAOFLCJI().SetFloat("Submit", SwitchCameraToCamera2);
			NBPKMLMCHFN.SetFloat("SetSunColors", SplitX);
			ECCPAOBFDKP().SetFloat("#ok", SplitY);
			AELJLBOJAIL().SetFloat("_TimeX", Smooth);
			HFBJAOFLCJI().SetFloat("yyyy", Rotation);
			EFDEIFCDAFG().SetInt("_TimeX", (!CONEELGCALI) ? 1 : 1);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
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
		KDMANOEMOCA();
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
		Start();
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
				ABHDNGIHBKE().SetTexture("_LightIntensity", JDMCFBKJHDD);
			}
			NKBIEMJBCBM().SetFloat("_EdgeSize", _Distance);
			NMDBCDFPGOK().SetFloat("USE_PREDICATION", _Size);
			HFBJAOFLCJI().SetFloat("Item ", _FixDistance);
			KDMBOKLMADJ().SetFloat("_Value6", HBJJOCHGOPH);
			HJGEHJDMCGI().SetFloat("speed", BlendFX);
			NKBIEMJBCBM().SetFloat("CameraFilterPack/Blur_DitherOffset", SwitchCameraToCamera2);
			DOMEEFLPEPJ().SetFloat("element", SplitX);
			DOMEEFLPEPJ().SetFloat("_ScreenResolution", SplitY);
			HJGEHJDMCGI().SetFloat("Uploading preview image...", Smooth);
			KAFBNOBOIAJ().SetFloat("_FgCocMask", Rotation);
			LPDOGGFOBDH().SetInt(".a", (!CONEELGCALI) ? 1 : 0);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EBBOJPEPDCN()
	{
		AKHCOBHHGJP();
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
		AGEJKLMJGDO();
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
		AKHCOBHHGJP();
	}

	private void CPMAAHPLGOP()
	{
		EGEPLFGKGLI();
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
				ACHNOHCLGOO().SetTexture("_FarCamera", JDMCFBKJHDD);
			}
			FLGPDBBKAIP().SetFloat("menu.tabid", _Distance);
			HJGEHJDMCGI().SetFloat("You need to have a child LayoutGroup content set for the list: ", _Size);
			MCDGIILBNIF().SetFloat(" GameServer:", _FixDistance);
			FLGPDBBKAIP().SetFloat("_Value", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("1159514800", BlendFX);
			KAFBNOBOIAJ().SetFloat("/", SwitchCameraToCamera2);
			FLGPDBBKAIP().SetFloat("value", SplitX);
			GCDFNHMJMIP().SetFloat("bans.viewed.", SplitY);
			AELJLBOJAIL().SetFloat("Object ID. Case-Sensitive", Smooth);
			KGOLDDBHIFN().SetFloat("_RangeScale", Rotation);
			OOMFJGPAOKL().SetInt("_TimeX", (!CONEELGCALI) ? 0 : 0);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
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
		JFJLGJEPEAA();
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
		KOFAMEKHHGD();
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
				NKBIEMJBCBM().SetTexture("value", JDMCFBKJHDD);
			}
			LNLKMDPHDCC().SetFloat("_Visualize", _Distance);
			HFBJAOFLCJI().SetFloat("_Intensity", _Size);
			KAFBNOBOIAJ().SetFloat("/../", _FixDistance);
			NBPKMLMCHFN.SetFloat(": ", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("_Value5", BlendFX);
			NMDBCDFPGOK().SetFloat("EnableRankedNotificationsToggle", SwitchCameraToCamera2);
			PDEAHJPOMEF().SetFloat("Turn", SplitX);
			ECCPAOBFDKP().SetFloat("Rap", SplitY);
			NMDBCDFPGOK().SetFloat("ScrollPanel", Smooth);
			HKHBBBFLGJH().SetFloat("_LrDepthTex", Rotation);
			GCDFNHMJMIP().SetInt("DPADVER", (!CONEELGCALI) ? 1 : 1);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OOMFJGPAOKL());
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
				NMDBCDFPGOK().SetTexture("Hidden/DepthOfField/MedianFilter", JDMCFBKJHDD);
			}
			CBCNOEIALHB().SetFloat("Loading inventory", _Distance);
			FLGPDBBKAIP().SetFloat("Fade", _Size);
			FLGPDBBKAIP().SetFloat("Tab2Content", _FixDistance);
			NMDBCDFPGOK().SetFloat("OnReadyClick", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("hidden", BlendFX);
			GCDFNHMJMIP().SetFloat("_AOTex", SwitchCameraToCamera2);
			NKBIEMJBCBM().SetFloat("settings.selectormapsperpage", SplitX);
			PDEAHJPOMEF().SetFloat("_Visualize", SplitY);
			HFBJAOFLCJI().SetFloat("/icon", Smooth);
			OOMFJGPAOKL().SetFloat("_HeightParams", Rotation);
			LPDOGGFOBDH().SetInt("_ScreenResolution", (!CONEELGCALI) ? 0 : 0);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NKBIEMJBCBM());
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
				NKBIEMJBCBM().SetTexture("offsets", JDMCFBKJHDD);
			}
			KDMBOKLMADJ().SetFloat("Ev OwnershipRequest ", _Distance);
			HKHBBBFLGJH().SetFloat("_History3Weight", _Size);
			ABHDNGIHBKE().SetFloat("ShowSprite", _FixDistance);
			NBPKMLMCHFN.SetFloat("bad", HBJJOCHGOPH);
			HKHBBBFLGJH().SetFloat("#updateoutdatedmap", BlendFX);
			ADBKPGFMNKO().SetFloat("_Visualize", SwitchCameraToCamera2);
			FLGPDBBKAIP().SetFloat("MaxLivesSlider", SplitX);
			HJGEHJDMCGI().SetFloat("_ProjInfo", SplitY);
			LPDOGGFOBDH().SetFloat("GlassDistortion", Smooth);
			KDMBOKLMADJ().SetFloat("_SpawnHeuristic", Rotation);
			NKBIEMJBCBM().SetInt("Texture2", CONEELGCALI ? 1 : 0);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KDMBOKLMADJ());
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
		AGEJKLMJGDO();
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
				HKHBBBFLGJH().SetTexture("{0}\n{1}\n{2}\n{3}\n{4}\n{5}", JDMCFBKJHDD);
			}
			GCDFNHMJMIP().SetFloat("[Down]", _Distance);
			CBCNOEIALHB().SetFloat("{0:0.0} ms ({1:0.} fps)", _Size);
			LNLKMDPHDCC().SetFloat("LevelConfigButton", _FixDistance);
			LPMLLJKMAMP().SetFloat("[PlayerController] ", HBJJOCHGOPH);
			ADBKPGFMNKO().SetFloat("_TimeX", BlendFX);
			HJGEHJDMCGI().SetFloat("_Offsets", SwitchCameraToCamera2);
			ECCPAOBFDKP().SetFloat("CameraFilterPack/Real_VHS", SplitX);
			MCDGIILBNIF().SetFloat("itemdefid[0]", SplitY);
			LPDOGGFOBDH().SetFloat("_TimeX", Smooth);
			FLGPDBBKAIP().SetFloat("_TimeX", Rotation);
			ABHDNGIHBKE().SetInt("Network destroy Instantiated GO: ", (!CONEELGCALI) ? 1 : 0);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NMDBCDFPGOK());
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
				LPDOGGFOBDH().SetTexture("_HalfResolution", JDMCFBKJHDD);
			}
			NKBIEMJBCBM().SetFloat("_SizeX", _Distance);
			NBPKMLMCHFN.SetFloat("_Value", _Size);
			HKHBBBFLGJH().SetFloat("note.1", _FixDistance);
			LNLKMDPHDCC().SetFloat("cancel", HBJJOCHGOPH);
			NKBIEMJBCBM().SetFloat("Set particles count per one beat", BlendFX);
			ADBKPGFMNKO().SetFloat("CameraFilterPack/TV_MovieNoise", SwitchCameraToCamera2);
			CBCNOEIALHB().SetFloat("_EmissionColor", SplitX);
			GCDFNHMJMIP().SetFloat("[EMPTY]", SplitY);
			NKBIEMJBCBM().SetFloat("custom", Smooth);
			HJGEHJDMCGI().SetFloat("#FFDA44", Rotation);
			HJGEHJDMCGI().SetInt("_Value1", (!CONEELGCALI) ? 1 : 1);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
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
				GCDFNHMJMIP().SetTexture("_Green_G", JDMCFBKJHDD);
			}
			EFDEIFCDAFG().SetFloat("_DotSize", _Distance);
			LNLKMDPHDCC().SetFloat("settings.disablestoryboard", _Size);
			NMDBCDFPGOK().SetFloat("Type \"help\" for list of commands", _FixDistance);
			NMDBCDFPGOK().SetFloat("CameraFilterPack/TV_ARCADE", HBJJOCHGOPH);
			ECCPAOBFDKP().SetFloat("Waiting for AvailableRegions. State: ", BlendFX);
			GCDFNHMJMIP().SetFloat("_History2LumaTex", SwitchCameraToCamera2);
			GCDFNHMJMIP().SetFloat("ResetButton", SplitX);
			LNLKMDPHDCC().SetFloat("{0}", SplitY);
			FLGPDBBKAIP().SetFloat("offsets", Smooth);
			ACHNOHCLGOO().SetFloat(".completedMaps", Rotation);
			EFDEIFCDAFG().SetInt("_PositionX", (!CONEELGCALI) ? 1 : 0);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
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
				NKBIEMJBCBM().SetTexture("InventoryButton", JDMCFBKJHDD);
			}
			GCDFNHMJMIP().SetFloat("-", _Distance);
			GCDFNHMJMIP().SetFloat("#FFFFFFFF", _Size);
			PDEAHJPOMEF().SetFloat("[PlayerBase] Loaded custom model: ", _FixDistance);
			ACHNOHCLGOO().SetFloat(".lastCheckpoint.currentCombo", HBJJOCHGOPH);
			KDMBOKLMADJ().SetFloat("Tab2Content", BlendFX);
			LNLKMDPHDCC().SetFloat("set id", SwitchCameraToCamera2);
			NMDBCDFPGOK().SetFloat("(\\[ */ *quote *\\])", SplitX);
			LPMLLJKMAMP().SetFloat("_ScreenResolution", SplitY);
			OOMFJGPAOKL().SetFloat(". Verify the Prefab is in a Resources folder (and not in a subfolder)", Smooth);
			KGOLDDBHIFN().SetFloat("Instantiating: ", Rotation);
			HFBJAOFLCJI().SetInt(";", (!CONEELGCALI) ? 1 : 1);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
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
		DBLILJGKGHJ();
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
		AEOLJEIDMDB();
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
		Start();
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
				NBPKMLMCHFN.SetTexture("_Exponent", JDMCFBKJHDD);
			}
			AELJLBOJAIL().SetFloat("mapselector.tags.", _Distance);
			OOMFJGPAOKL().SetFloat("setfloat", _Size);
			AELJLBOJAIL().SetFloat(": ", _FixDistance);
			FLGPDBBKAIP().SetFloat("_EdgeSharpness", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("EditMenu", BlendFX);
			KDMBOKLMADJ().SetFloat("RecordButton", SwitchCameraToCamera2);
			KGOLDDBHIFN().SetFloat("menu.selectedlevelid", SplitX);
			ABHDNGIHBKE().SetFloat("/", SplitY);
			OOMFJGPAOKL().SetFloat("_Value2", Smooth);
			LPDOGGFOBDH().SetFloat("VIGNETTE_BLUR", Rotation);
			KGOLDDBHIFN().SetInt("Encryption wasn't established: ", CONEELGCALI ? 1 : 0);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HJGEHJDMCGI());
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
				LNLKMDPHDCC().SetTexture("CameraFilterPack_WaterDrop", JDMCFBKJHDD);
			}
			CBCNOEIALHB().SetFloat("SpectatingUserInfo", _Distance);
			MCDGIILBNIF().SetFloat("ShowTitle", _Size);
			EFDEIFCDAFG().SetFloat("_CenterX", _FixDistance);
			ADBKPGFMNKO().SetFloat("colorB", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("_TimeX", BlendFX);
			LPDOGGFOBDH().SetFloat("list", SwitchCameraToCamera2);
			EFDEIFCDAFG().SetFloat("_Value2", SplitX);
			PDEAHJPOMEF().SetFloat("_ScreenResolution", SplitY);
			KDMBOKLMADJ().SetFloat("\t", Smooth);
			NKBIEMJBCBM().SetFloat("_Green_G", Rotation);
			HKHBBBFLGJH().SetInt("_ColorBuffer", (!CONEELGCALI) ? 0 : 0);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
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
				KDMBOKLMADJ().SetTexture("HandleEventLeave for player ID: ", JDMCFBKJHDD);
			}
			KDMBOKLMADJ().SetFloat(" cannot be used as a 3D LUT.", _Distance);
			KDMBOKLMADJ().SetFloat("Version 1.0", _Size);
			NMDBCDFPGOK().SetFloat("CameraFilterPack_WaterDrop", _FixDistance);
			EFDEIFCDAFG().SetFloat(") but there is no recycle bin setup for it", HBJJOCHGOPH);
			KDMBOKLMADJ().SetFloat("_Greenness", BlendFX);
			HJGEHJDMCGI().SetFloat("_Size", SwitchCameraToCamera2);
			PDEAHJPOMEF().SetFloat("MascotChallenge2019", SplitX);
			GCDFNHMJMIP().SetFloat("_ProjInfo", SplitY);
			EFDEIFCDAFG().SetFloat("runas", Smooth);
			KDMBOKLMADJ().SetFloat("{0}", Rotation);
			HKHBBBFLGJH().SetInt("_TintColor", CONEELGCALI ? 1 : 0);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HMKJFPBFOFI()
	{
		BMIOFJFMCBG();
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
				NKBIEMJBCBM().SetTexture("14", JDMCFBKJHDD);
			}
			NKBIEMJBCBM().SetFloat("End index must in an integer.", _Distance);
			KGOLDDBHIFN().SetFloat("_NormalAndRoughnessTexture", _Size);
			KDMBOKLMADJ().SetFloat("Adding player twice: ", _FixDistance);
			KGOLDDBHIFN().SetFloat("_Value", HBJJOCHGOPH);
			HJGEHJDMCGI().SetFloat("_Noise", BlendFX);
			AELJLBOJAIL().SetFloat("_TimeX", SwitchCameraToCamera2);
			ABHDNGIHBKE().SetFloat("LobbyCanvas", SplitX);
			PDEAHJPOMEF().SetFloat("_Far", SplitY);
			EFDEIFCDAFG().SetFloat("CameraFilterPack_3D_Myst1", Smooth);
			ADBKPGFMNKO().SetFloat("_Value2", Rotation);
			HFBJAOFLCJI().SetInt("local CheckCondition = function()", CONEELGCALI ? 1 : 0);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
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
		AGEJKLMJGDO();
	}

	private void KFCCKOBOLAH()
	{
		Start();
	}
}
