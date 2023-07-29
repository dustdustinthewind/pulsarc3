// CameraFilterPack_AAA_WaterDrop
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/AAA/WaterDrop")]
public class CameraFilterPack_AAA_WaterDrop : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	[Range(8f, 64f)]
	public float Distortion = 8f;

	[Range(0f, 7f)]
	public float SizeX = 1f;

	[Range(0f, 7f)]
	public float SizeY = 0.5f;

	[Range(0f, 10f)]
	public float Speed = 1f;

	private Material BJFKDHHMLJH;

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

	private void MKIFJMPELJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 352f)
			{
				HBJJOCHGOPH = 1859f;
			}
			ADAFMBOGPLN().SetFloat("(\\[ *i *\\])", HBJJOCHGOPH);
			LPCHMEKDCHI().SetFloat("_Value3", Distortion);
			LPCHMEKDCHI().SetFloat("CameraFilterPack_WaterDrop", SizeX);
			OCMBHMLNCEK().SetFloat("PossibleMapPointsText", SizeY);
			OOMFJGPAOKL().SetFloat("id", Speed);
			FKEOGPDLBDD().SetTexture("_Threshhold", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADAFMBOGPLN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EHCGBJDFMHG()
	{
	}

	private void CCFEDENFNEF()
	{
		FPHEBLMINDA = Resources.Load("DifficultyBG") as Texture2D;
		SCShader = Shader.Find("_Green_G");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1683f)
			{
				HBJJOCHGOPH = 725f;
			}
			FEAEGGCNIAA().SetFloat("_Blue_G", HBJJOCHGOPH);
			IIBLJCKLGFG().SetFloat("_Value2", Distortion);
			DKNJGHFLAIF().SetFloat("Tab1Content", SizeX);
			NLFJGMBCICG().SetFloat("status", SizeY);
			HNICHJCGJOC().SetFloat("error", Speed);
			OOMFJGPAOKL().SetTexture("MaxLivesSlider", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
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
			if (HBJJOCHGOPH > 183f)
			{
				HBJJOCHGOPH = 465f;
			}
			LPCHMEKDCHI().SetFloat(".played", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("settings.crosshairopacity", Distortion);
			KBOPGONOCNP().SetFloat("Connect() failed. Can't connect while disconnecting (still). Current state: ", SizeX);
			OOMFJGPAOKL().SetFloat("_Fade", SizeY);
			JCPDCGIJKJD().SetFloat("SpawnObj", Speed);
			DOHGBNPMBKG().SetTexture("/", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GHHPOGODBHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DHLCNIINMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1629f)
			{
				HBJJOCHGOPH = 460f;
			}
			HHIFMIPPMPF().SetFloat("GhostFade2", HBJJOCHGOPH);
			OCMBHMLNCEK().SetFloat(" not exist", Distortion);
			EHDJJANLINB().SetFloat("settings_bindings_controller_type", SizeX);
			FEAEGGCNIAA().SetFloat("offsets", SizeY);
			FEAEGGCNIAA().SetFloat("Moved event", Speed);
			GKILCDHJFEG().SetTexture("checkpoint", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DOKAKEMDALN()
	{
		FPHEBLMINDA = Resources.Load("color") as Texture2D;
		SCShader = Shader.Find("_FadeDistance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material KEMAALEODNH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void EJJEDJIOFAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material FGENHBKMPDA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.HideInHierarchy;
		}
		return BJFKDHHMLJH;
	}

	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1257f)
			{
				HBJJOCHGOPH = 1149f;
			}
			IIBLJCKLGFG().SetFloat("settings.selectormapsperpage", HBJJOCHGOPH);
			GHHPOGODBHB().SetFloat("MenuScene", Distortion);
			HKHBBBFLGJH().SetFloat("_Value", SizeX);
			HFBJAOFLCJI().SetFloat("CameraFilterPack/TV_Video3D", SizeY);
			DOHGBNPMBKG().SetFloat(" not found", Speed);
			NLFJGMBCICG().SetTexture("Preparing configuration", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material CFEDGDGBCHE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material ABHDNGIHBKE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)94;
		}
		return BJFKDHHMLJH;
	}

	private void MANDOGNJJBD()
	{
	}

	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1376f)
			{
				HBJJOCHGOPH = 1718f;
			}
			HNICHJCGJOC().SetFloat("menu.hardcoreinfo", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("FPSToggle", Distortion);
			DEFBJOCJJKF().SetFloat("Set Satellite Sensitivity", SizeX);
			DKNJGHFLAIF().SetFloat("_TapLowForeground", SizeY);
			NLFJGMBCICG().SetFloat("CameraFilterPack/Blend2Camera_ColorKey", Speed);
			KBOPGONOCNP().SetTexture("GridDataStoryboard", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JLNNHKPHMAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HKHBBBFLGJH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material EHDJJANLINB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 587f)
			{
				HBJJOCHGOPH = 326f;
			}
			NDMPCDHADMJ().SetFloat(":", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("maps.", Distortion);
			HKHBBBFLGJH().SetFloat("score", SizeX);
			CFEDGDGBCHE().SetFloat("CameraFilterPack/Distortion_Wave_Horizontal", SizeY);
			DKNJGHFLAIF().SetFloat("_CurTex", Speed);
			KBOPGONOCNP().SetTexture("BadgeText", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GJLKJAOBPJD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1047f)
			{
				HBJJOCHGOPH = 513f;
			}
			KBOPGONOCNP().SetFloat("UseScanLine", HBJJOCHGOPH);
			GHHPOGODBHB().SetFloat("[NetworkMenu] Joining ", Distortion);
			IIBLJCKLGFG().SetFloat("(\\[ *url=)((?:https\\:\\/\\/)|(?:http\\:\\/\\/)|(?:www\\.))?([a-zA-Z0-9\\-\\.]+\\.[a-zA-Z]{2,3}(?:\\??)[a-zA-Z0-9\\-\\._\\?\\,\\'\\/\\\\\\+&%\\$#\\=~]+)(\\])", SizeX);
			HFBJAOFLCJI().SetFloat("#ok", SizeY);
			IONHGBPGCHK().SetFloat("CameraFilterPack_VHS2", Speed);
			HHIFMIPPMPF().SetTexture("LivesSlider", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 323f)
			{
				HBJJOCHGOPH = 313f;
			}
			DEFBJOCJJKF().SetFloat("_Value5", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("_SpawnHeuristic", Distortion);
			ADAFMBOGPLN().SetFloat("\" on viewID ", SizeX);
			IIBLJCKLGFG().SetFloat("#close", SizeY);
			IIBLJCKLGFG().SetFloat("newPath", Speed);
			DOHGBNPMBKG().SetTexture("_Offsets", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BNCLKHOEGDK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JCGMGLMADEN()
	{
	}

	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1269f)
			{
				HBJJOCHGOPH = 326f;
			}
			FKEOGPDLBDD().SetFloat("_ForceYSwap", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("shader.none", Distortion);
			OCMBHMLNCEK().SetFloat("0", SizeX);
			DOHGBNPMBKG().SetFloat("_Level", SizeY);
			GHHPOGODBHB().SetFloat("#onrankchangeuptext", Speed);
			NLFJGMBCICG().SetTexture("Connection error: ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ALJEJJCIMJN()
	{
		FPHEBLMINDA = Resources.Load("PLEASE WAIT") as Texture2D;
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OCCGJMPAJIK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FOMNCPKKCFN()
	{
	}

	private void NDBPCNICGLC()
	{
		FPHEBLMINDA = Resources.Load("Joystick1Button7") as Texture2D;
		SCShader = Shader.Find("HPToggle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JKBMKPDGCHG()
	{
		FPHEBLMINDA = Resources.Load("Preparing content...") as Texture2D;
		SCShader = Shader.Find("CountEventsGoal");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void COMNAPAAPDO()
	{
	}

	private void OFPPIKHNJOD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PBEPCAPAKLG()
	{
	}

	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1172f)
			{
				HBJJOCHGOPH = 923f;
			}
			HCGJCMDJPGD().SetFloat("settings.hitvariation", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("InfoCanvas", Distortion);
			HCGJCMDJPGD().SetFloat("_Value2", SizeX);
			IONHGBPGCHK().SetFloat("WARNING: rotation axis set to 0 on ", SizeY);
			EHDJJANLINB().SetFloat("_TimeX", Speed);
			OOMFJGPAOKL().SetTexture("_Value3", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
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

	[SpecialName]
	private Material HHIFMIPPMPF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void LKBOEPPBLIF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 332f)
			{
				HBJJOCHGOPH = 550f;
			}
			IIBLJCKLGFG().SetFloat("CameraFilterPack/Gradients_Therma", HBJJOCHGOPH);
			ADAFMBOGPLN().SetFloat("#combo", Distortion);
			DKNJGHFLAIF().SetFloat("Items/", SizeX);
			LPCHMEKDCHI().SetFloat("_Bullet_10", SizeY);
			LPCHMEKDCHI().SetFloat("_ScreenResolution", Speed);
			HFBJAOFLCJI().SetTexture("\" gets executed locally only, if at all.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DAHFFNNIGML()
	{
		FPHEBLMINDA = Resources.Load("MultiplayerButton") as Texture2D;
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material HNICHJCGJOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.HideInInspector | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void MAOCOEGAFND()
	{
	}

	[SpecialName]
	private Material GHHPOGODBHB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-98);
		}
		return BJFKDHHMLJH;
	}

	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1375f)
			{
				HBJJOCHGOPH = 1936f;
			}
			DOMEEFLPEPJ().SetFloat(".png", HBJJOCHGOPH);
			GHHPOGODBHB().SetFloat("s", Distortion);
			IIBLJCKLGFG().SetFloat("_CenterY", SizeX);
			NDMPCDHADMJ().SetFloat("OnAwakeRPC", SizeY);
			NBPKMLMCHFN.SetFloat("float,10", Speed);
			ABHDNGIHBKE().SetTexture("#task", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OCMBHMLNCEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LMBDNPLDGIJ()
	{
	}

	private void Start()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_WaterDrop") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/AAA_WaterDrop");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material GKILCDHJFEG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)122;
		}
		return BJFKDHHMLJH;
	}

	private void KOJKBFDNGDK()
	{
		FPHEBLMINDA = Resources.Load("float,0") as Texture2D;
		SCShader = Shader.Find("_ScreenResolution");
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
			if (HBJJOCHGOPH > 919f)
			{
				HBJJOCHGOPH = 548f;
			}
			OOMFJGPAOKL().SetFloat("ScrollPanel", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("checkpoint", Distortion);
			OCMBHMLNCEK().SetFloat("settings.volume.game", SizeX);
			FGENHBKMPDA().SetFloat("Mouse Y", SizeY);
			IIBLJCKLGFG().SetFloat("_TimeX", Speed);
			LPCHMEKDCHI().SetTexture("\n\n#", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FGNFILLNPJK()
	{
	}

	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1469f)
			{
				HBJJOCHGOPH = 42f;
			}
			KBOPGONOCNP().SetFloat("_Distortion2", HBJJOCHGOPH);
			HKHBBBFLGJH().SetFloat("IntraSig", Distortion);
			DKNJGHFLAIF().SetFloat("_MainTex2", SizeX);
			OCMBHMLNCEK().SetFloat("#close", SizeY);
			FKEOGPDLBDD().SetFloat("_TimeX", Speed);
			FKEOGPDLBDD().SetTexture("ConfigVersionSlider", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 560f)
			{
				HBJJOCHGOPH = 182f;
			}
			HCGJCMDJPGD().SetFloat("menutheme.hunter", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat(" not exist", Distortion);
			NDMPCDHADMJ().SetFloat("Created by ", SizeX);
			HCGJCMDJPGD().SetFloat("skin.hit_perfect", SizeY);
			ECCPAOBFDKP().SetFloat("Authentication failed: '{0}' Code: {1}", Speed);
			DEFBJOCJJKF().SetTexture("[Left]", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OCMBHMLNCEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FANADGBGCPI()
	{
		FPHEBLMINDA = Resources.Load("#ok") as Texture2D;
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MDNHCLKNCLE()
	{
		FPHEBLMINDA = Resources.Load("settings.enablehitsoundsinrelax") as Texture2D;
		SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1743f)
			{
				HBJJOCHGOPH = 424f;
			}
			DEFBJOCJJKF().SetFloat("caret", HBJJOCHGOPH);
			HKGAONMOBMH().SetFloat(" failed in a server-side plugin. Check the configuration in the Dashboard. Message from server-plugin: ", Distortion);
			IIBLJCKLGFG().SetFloat("/music", SizeX);
			HKGAONMOBMH().SetFloat("CameraFilterPack/Glasses_On", SizeY);
			JCPDCGIJKJD().SetFloat("-showlogs", Speed);
			HCGJCMDJPGD().SetTexture(".lastCheckpoint.playerdistance", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KOFAMEKHHGD()
	{
		FPHEBLMINDA = Resources.Load("Fade") as Texture2D;
		SCShader = Shader.Find("no lives color");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
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
			BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material ADAFMBOGPLN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void GNMGIHFKJIJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material FEAEGGCNIAA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void EFECEKPFOEM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FDPOFMCFBMF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1554f)
			{
				HBJJOCHGOPH = 1288f;
			}
			KBOPGONOCNP().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("mapselector.tags.", Distortion);
			FEAEGGCNIAA().SetFloat("_Intensity", SizeX);
			DKNJGHFLAIF().SetFloat("_EmissionColor", SizeY);
			CFEDGDGBCHE().SetFloat("menu.playedpage", Speed);
			FKEOGPDLBDD().SetTexture("SetBGColor", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OCMBHMLNCEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LDDKCCMHMIC()
	{
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
			NBPKMLMCHFN.SetFloat("_Distortion", Distortion);
			NBPKMLMCHFN.SetFloat("_SizeX", SizeX);
			NBPKMLMCHFN.SetFloat("_SizeY", SizeY);
			NBPKMLMCHFN.SetFloat("_Speed", Speed);
			NBPKMLMCHFN.SetTexture("_MainTex2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DEFBJOCJJKF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.HideInHierarchy | HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-84);
		}
		return BJFKDHHMLJH;
	}

	private void AOKOLPEGHDD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HMNLHMLILKD()
	{
	}

	private void OKHBBIKDIEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1399f)
			{
				HBJJOCHGOPH = 1644f;
			}
			DOHGBNPMBKG().SetFloat("maps.", HBJJOCHGOPH);
			LDNADDJMIPK().SetFloat("?", Distortion);
			IIBLJCKLGFG().SetFloat("_Near", SizeX);
			HFBJAOFLCJI().SetFloat("CameraFilterPack/EyesVision_2", SizeY);
			HCGJCMDJPGD().SetFloat("_Value6", Speed);
			FKEOGPDLBDD().SetTexture("inventory.selected.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GHHPOGODBHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CGBHOELMAOC()
	{
	}

	private void ADPLHDFJFID()
	{
		FPHEBLMINDA = Resources.Load("PunPickupSimple") as Texture2D;
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 553f)
			{
				HBJJOCHGOPH = 1628f;
			}
			LDNADDJMIPK().SetFloat("Created", HBJJOCHGOPH);
			FEAEGGCNIAA().SetFloat("_PositionX", Distortion);
			DOMEEFLPEPJ().SetFloat("MenuVolumeSlider", SizeX);
			GHHPOGODBHB().SetFloat("ERROR: Preview file must be <1MB!", SizeY);
			HHIFMIPPMPF().SetFloat(".lastCheckpoint.powerupsScore", Speed);
			OCMBHMLNCEK().SetTexture("#score", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JCPDCGIJKJD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material OCMBHMLNCEK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void FEHCNJLLJMP()
	{
		FPHEBLMINDA = Resources.Load("Connection error: ") as Texture2D;
		SCShader = Shader.Find("float,0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 515f)
			{
				HBJJOCHGOPH = 422f;
			}
			EHDJJANLINB().SetFloat("[PlayerController] ", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("EventMenu", Distortion);
			OIBHFCLJKDB().SetFloat("Room: '{0}' {1},{2} {4}/{3} players.\ncustomProps: {5}", SizeX);
			FKEOGPDLBDD().SetFloat("#91CCFF", SizeY);
			LPCHMEKDCHI().SetFloat("GameScene", Speed);
			FKEOGPDLBDD().SetTexture("CameraFilterPack/Color_YUV", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DNENFLNCIJP()
	{
	}

	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1893f)
			{
				HBJJOCHGOPH = 1682f;
			}
			IONHGBPGCHK().SetFloat("_BlurVector", HBJJOCHGOPH);
			OIBHFCLJKDB().SetFloat("GlassColor", Distortion);
			DOHGBNPMBKG().SetFloat("\\\\", SizeX);
			IIBLJCKLGFG().SetFloat(" b.", SizeY);
			HCGJCMDJPGD().SetFloat("Fade", Speed);
			FEAEGGCNIAA().SetTexture("_Saturation", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOMEEFLPEPJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FMNPFCHBLJF()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack/Blend2Camera_DarkerColor") as Texture2D;
		SCShader = Shader.Find("_ColorBuffer");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JDGFCEPDKAJ()
	{
	}

	private void IBPAMDEAGJL()
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void ONKDMMJPEMN()
	{
	}

	private void GOANCMNGDLE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 219f)
			{
				HBJJOCHGOPH = 459f;
			}
			GKILCDHJFEG().SetFloat("achievements.id", HBJJOCHGOPH);
			JCPDCGIJKJD().SetFloat("_SpawnHeuristic", Distortion);
			HCGJCMDJPGD().SetFloat("_Value", SizeX);
			DOMEEFLPEPJ().SetFloat("InfoCanvas", SizeY);
			OIBHFCLJKDB().SetFloat("float,0", Speed);
			KBOPGONOCNP().SetTexture("LevelEditor/CustomEventEditor-Text", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GHILDCBCDJI()
	{
	}

	private void MGMAOBPPOBJ()
	{
		FPHEBLMINDA = Resources.Load("_TimeX") as Texture2D;
		SCShader = Shader.Find("SetSunMaxSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BOLBPPHJBMI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 841f)
			{
				HBJJOCHGOPH = 1018f;
			}
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Pixel_Pixelisation", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("CameraFilterPack/Pixelisation_OilPaint", Distortion);
			CFEDGDGBCHE().SetFloat("_Value", SizeX);
			JCPDCGIJKJD().SetFloat("menu.selectedplaymode", SizeY);
			KEMAALEODNH().SetFloat("help", Speed);
			OIBHFCLJKDB().SetTexture("Add Environment Object", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DOHGBNPMBKG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-71);
		}
		return BJFKDHHMLJH;
	}

	private void OGJJDKENBNC()
	{
		FPHEBLMINDA = Resources.Load("UseFinalGlassColor") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Real_VHS");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material ECCPAOBFDKP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)102;
		}
		return BJFKDHHMLJH;
	}

	private void OMIHEBMMCPG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 632f)
			{
				HBJJOCHGOPH = 1209f;
			}
			NBPKMLMCHFN.SetFloat("RoomNameText", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("_MainTex2", Distortion);
			GKILCDHJFEG().SetFloat("_ScreenResolution", SizeX);
			ECCPAOBFDKP().SetFloat("Set satellite trail width", SizeY);
			GKILCDHJFEG().SetFloat("SfxVolumeSlider", Speed);
			OCMBHMLNCEK().SetTexture("No connection to item server!", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOMEEFLPEPJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 312f)
			{
				HBJJOCHGOPH = 1755f;
			}
			GHHPOGODBHB().SetFloat("Items/", HBJJOCHGOPH);
			LPCHMEKDCHI().SetFloat("_Min", Distortion);
			LDNADDJMIPK().SetFloat("Tab2Content", SizeX);
			KBOPGONOCNP().SetFloat("<b>#", SizeY);
			FKEOGPDLBDD().SetFloat("Set Satellite Emission", Speed);
			HNICHJCGJOC().SetTexture("_TimeX", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NKFDNIAKGEO()
	{
		FPHEBLMINDA = Resources.Load(".status") as Texture2D;
		SCShader = Shader.Find("_Red_B");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GBGAMCPNBCC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LBPCODPOJAH()
	{
	}

	[SpecialName]
	private Material DKNJGHFLAIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material JCPDCGIJKJD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)105;
		}
		return BJFKDHHMLJH;
	}

	private void Update()
	{
	}

	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 411f)
			{
				HBJJOCHGOPH = 1750f;
			}
			HKGAONMOBMH().SetFloat("Sent count: ", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("CameraFilterPack/FX_8bits_gb", Distortion);
			DOHGBNPMBKG().SetFloat("SetSpeed", SizeX);
			LDNADDJMIPK().SetFloat("RenderTextureUtilityTempTexture", SizeY);
			FEAEGGCNIAA().SetFloat("_AreaTex", Speed);
			LPCHMEKDCHI().SetTexture("player.greenarc", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OOMFJGPAOKL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material OOMFJGPAOKL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)122;
		}
		return BJFKDHHMLJH;
	}

	private void CBIBDOIBJAI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HFBJAOFLCJI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1089f)
			{
				HBJJOCHGOPH = 1259f;
			}
			HHIFMIPPMPF().SetFloat("_Value", HBJJOCHGOPH);
			JCPDCGIJKJD().SetFloat("\\n", Distortion);
			HCGJCMDJPGD().SetFloat("Item ", SizeX);
			DKNJGHFLAIF().SetFloat("maps.", SizeY);
			ABHDNGIHBKE().SetFloat("_OcclusionTexture", Speed);
			HHIFMIPPMPF().SetTexture("0.00", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
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
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.HideInHierarchy | HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1752f)
			{
				HBJJOCHGOPH = 945f;
			}
			FKEOGPDLBDD().SetFloat("[PlayerBase] Unknown event: ", HBJJOCHGOPH);
			ADAFMBOGPLN().SetFloat("_TimeX", Distortion);
			HKHBBBFLGJH().SetFloat("\" for viewID ", SizeX);
			LDNADDJMIPK().SetFloat("CameraFilterPack/Glow_Glow", SizeY);
			GKILCDHJFEG().SetFloat(",", Speed);
			FKEOGPDLBDD().SetTexture("_ScreenResolution", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HHKBBEFJEBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1752f)
			{
				HBJJOCHGOPH = 649f;
			}
			LPCHMEKDCHI().SetFloat("MultiplayerButton", HBJJOCHGOPH);
			DOMEEFLPEPJ().SetFloat("_Value7", Distortion);
			ABHDNGIHBKE().SetFloat("settings.disablestoryboard", SizeX);
			DOMEEFLPEPJ().SetFloat("< true | false >", SizeY);
			JCPDCGIJKJD().SetFloat("_ForegroundBlurExtrude", Speed);
			FKEOGPDLBDD().SetTexture("Using WebSocket to connect NameServer (AuthMode is AuthOnceWss).", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material FKEOGPDLBDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-105);
		}
		return BJFKDHHMLJH;
	}

	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1727f)
			{
				HBJJOCHGOPH = 327f;
			}
			NDMPCDHADMJ().SetFloat("CameraFilterPack_Paper4", HBJJOCHGOPH);
			HKHBBBFLGJH().SetFloat("Icon", Distortion);
			KEMAALEODNH().SetFloat("_Far", SizeX);
			HKGAONMOBMH().SetFloat("Items", SizeY);
			HKHBBBFLGJH().SetFloat("_MatrixColor", Speed);
			KEMAALEODNH().SetTexture("OK", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKHBBBFLGJH());
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void JEBIBKLHFLB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LEAHIBJDMBI()
	{
	}

	[SpecialName]
	private Material NDMPCDHADMJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)64;
		}
		return BJFKDHHMLJH;
	}

	private void IKDNLHLBHID()
	{
		FPHEBLMINDA = Resources.Load("Send") as Texture2D;
		SCShader = Shader.Find("GameModeText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material IIBLJCKLGFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void DOEPOGLEGLE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LKJMIODJGCM()
	{
	}

	private void FIJHDKIPENG()
	{
		FPHEBLMINDA = Resources.Load("Connection failed: ") as Texture2D;
		SCShader = Shader.Find("offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 259f)
			{
				HBJJOCHGOPH = 590f;
			}
			IONHGBPGCHK().SetFloat("<b>Time</b>:", HBJJOCHGOPH);
			OOMFJGPAOKL().SetFloat("_ExposureAdjustment", Distortion);
			LDNADDJMIPK().SetFloat("maps.", SizeX);
			CFEDGDGBCHE().SetFloat("Drop_Near", SizeY);
			OOMFJGPAOKL().SetFloat("_Value3", Speed);
			OOMFJGPAOKL().SetTexture("In Main Menu", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1697f)
			{
				HBJJOCHGOPH = 1011f;
			}
			GHHPOGODBHB().SetFloat("Bad parameters for setbool! Use <key> <value>", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("yes", Distortion);
			FKEOGPDLBDD().SetFloat("settings.arcshitsoundtimedelay", SizeX);
			FEAEGGCNIAA().SetFloat("_PColor2", SizeY);
			CFEDGDGBCHE().SetFloat("Achievement 21 progress reseted", Speed);
			GKILCDHJFEG().SetTexture(".played", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material NLFJGMBCICG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)68;
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

	private void HDDECCMEJKA()
	{
	}

	private void COGBDFKOHKK()
	{
	}

	private void KMOCDAOKGLI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EKCKJLFFAID()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-110);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material OIBHFCLJKDB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-108);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material LDNADDJMIPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
		}
		return BJFKDHHMLJH;
	}

	private void AEOLJEIDMDB()
	{
		FPHEBLMINDA = Resources.Load("_Green_C") as Texture2D;
		SCShader = Shader.Find("_Params3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
