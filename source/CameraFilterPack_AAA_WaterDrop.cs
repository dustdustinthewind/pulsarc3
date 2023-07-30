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
			GHHPOGODBHB().SetFloat("(\\[ *i *\\])", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("_Value2", Distortion);
			HKGAONMOBMH().SetFloat("CameraFilterPack_WaterDrop", SizeX);
			KBOPGONOCNP().SetFloat("PossibleMapPointsText", SizeY);
			HKHBBBFLGJH().SetFloat("Set EnvSprite Image", Speed);
			IONHGBPGCHK().SetTexture("colorD", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
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
			CFEDGDGBCHE().SetFloat("_Blue_R", HBJJOCHGOPH);
			IIBLJCKLGFG().SetFloat("_Value", Distortion);
			IONHGBPGCHK().SetFloat("Tab1Content", SizeX);
			DOMEEFLPEPJ().SetFloat("status", SizeY);
			IIBLJCKLGFG().SetFloat(" - StoreAuthURLResponse] - ", Speed);
			HCGJCMDJPGD().SetTexture("HandsCountSlider", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
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
			FKEOGPDLBDD().SetFloat("maps.", HBJJOCHGOPH);
			OIBHFCLJKDB().SetFloat("CrosshairOpacitySlider", Distortion);
			DKNJGHFLAIF().SetFloat("ReconnectAndRejoin() with AuthValues == null is not correct!", SizeX);
			LDNADDJMIPK().SetFloat("_TimeX", SizeY);
			NLFJGMBCICG().SetFloat("ShowTitle", Speed);
			FEAEGGCNIAA().SetTexture("#pleasewait", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JCPDCGIJKJD());
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
			NBPKMLMCHFN.SetFloat("GhostFade2", HBJJOCHGOPH);
			HKHBBBFLGJH().SetFloat(": ", Distortion);
			HHIFMIPPMPF().SetFloat("settings_bindings_controller_type", SizeX);
			OOMFJGPAOKL().SetFloat("offsets", SizeY);
			DKNJGHFLAIF().SetFloat("[Right]", Speed);
			ECCPAOBFDKP().SetTexture("EventTimeInputField", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DOKAKEMDALN()
	{
		FPHEBLMINDA = Resources.Load("float,10") as Texture2D;
		SCShader = Shader.Find("_ReflectionBlur");
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
			FGENHBKMPDA().SetFloat("settings.arcshitsoundtimedelay", HBJJOCHGOPH);
			EHDJJANLINB().SetFloat("#yes", Distortion);
			HKHBBBFLGJH().SetFloat("_TimeX", SizeX);
			LPCHMEKDCHI().SetFloat("_ScreenResolution", SizeY);
			KEMAALEODNH().SetFloat("shader.invert", Speed);
			HFBJAOFLCJI().SetTexture("Preparing content", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOMEEFLPEPJ());
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
			HKHBBBFLGJH().SetFloat("OK", HBJJOCHGOPH);
			FEAEGGCNIAA().SetFloat("Scene", Distortion);
			ABHDNGIHBKE().SetFloat("Set Satellite Sensitivity", SizeX);
			HFBJAOFLCJI().SetFloat("_TapMedium", SizeY);
			NDMPCDHADMJ().SetFloat("CameraFilterPack/Blend2Camera_ColorKey", Speed);
			KBOPGONOCNP().SetTexture("GridDataStoryboard", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
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
			FKEOGPDLBDD().SetFloat("hitsounds:", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("maps.", Distortion);
			OOMFJGPAOKL().SetFloat("owner: ", SizeX);
			OOMFJGPAOKL().SetFloat("CameraFilterPack/Distortion_Wave_Horizontal", SizeY);
			DOMEEFLPEPJ().SetFloat("threshold", Speed);
			HCGJCMDJPGD().SetTexture("NEW", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			FGENHBKMPDA().SetFloat("UseScanLineSize", HBJJOCHGOPH);
			LPCHMEKDCHI().SetFloat("[NetworkMenu] Joining ", Distortion);
			FKEOGPDLBDD().SetFloat("(\\[ *url=)((?:https\\:\\/\\/)|(?:http\\:\\/\\/)|(?:www\\.))?([a-zA-Z0-9\\-\\.]+\\.[a-zA-Z]{2,3}(?:\\??)[a-zA-Z0-9\\-\\._\\?\\,\\'\\/\\\\\\+&%\\$#\\=~]+)(\\])", SizeX);
			LPCHMEKDCHI().SetFloat("#exit", SizeY);
			NBPKMLMCHFN.SetFloat("CameraFilterPack_VHS1", Speed);
			FGENHBKMPDA().SetTexture("MaxLivesSlider", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
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
			FEAEGGCNIAA().SetFloat("_Value4", HBJJOCHGOPH);
			HKHBBBFLGJH().SetFloat("_BlurredColor", Distortion);
			IIBLJCKLGFG().SetFloat(" By: ", SizeX);
			DKNJGHFLAIF().SetFloat("#failed: ", SizeY);
			ECCPAOBFDKP().SetFloat("/", Speed);
			DOMEEFLPEPJ().SetTexture("_FgOverlap", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
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
			NDMPCDHADMJ().SetFloat("_Value5", HBJJOCHGOPH);
			HKGAONMOBMH().SetFloat("shader.pixel", Distortion);
			GKILCDHJFEG().SetFloat("#ok", SizeX);
			JCPDCGIJKJD().SetFloat("_Level", SizeY);
			IIBLJCKLGFG().SetFloat("#onfirstranktext", Speed);
			HCGJCMDJPGD().SetTexture("#later", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ALJEJJCIMJN()
	{
		FPHEBLMINDA = Resources.Load("0.00") as Texture2D;
		SCShader = Shader.Find("_Value2");
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
		FPHEBLMINDA = Resources.Load("Joystick1Button6") as Texture2D;
		SCShader = Shader.Find("HPToggle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JKBMKPDGCHG()
	{
		FPHEBLMINDA = Resources.Load("The number of players playing your game: ") as Texture2D;
		SCShader = Shader.Find(",");
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
			FEAEGGCNIAA().SetFloat("settings.cameramovements", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("rarity", Distortion);
			FEAEGGCNIAA().SetFloat("_Value", SizeX);
			JCPDCGIJKJD().SetFloat("WARNING: rotation axis set to 0 on ", SizeY);
			DEFBJOCJJKF().SetFloat("CameraFilterPack/EyesVision_1", Speed);
			ADAFMBOGPLN().SetTexture("_Value3", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ECCPAOBFDKP());
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
			GKILCDHJFEG().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("#highscore", Distortion);
			HKGAONMOBMH().SetFloat("inventory.selected.", SizeX);
			OOMFJGPAOKL().SetFloat("_Bullet_8", SizeY);
			NBPKMLMCHFN.SetFloat("_Value4", Speed);
			NLFJGMBCICG().SetTexture("Error; Only the MasterClient can call RemoveRPCs for other players.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DAHFFNNIGML()
	{
		FPHEBLMINDA = Resources.Load("MultiplayerButton") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Vision_Tunnel");
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
			IIBLJCKLGFG().SetFloat("/Assets/MyImage", HBJJOCHGOPH);
			FEAEGGCNIAA().SetFloat("s", Distortion);
			IIBLJCKLGFG().SetFloat("_CenterX", SizeX);
			DKNJGHFLAIF().SetFloat("</color>", SizeY);
			JCPDCGIJKJD().SetFloat("float,10", Speed);
			DOHGBNPMBKG().SetTexture("[#clicktoacceptchallenge]", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
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
		SCShader = Shader.Find("_TimeX");
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
			ECCPAOBFDKP().SetFloat("MainButton", HBJJOCHGOPH);
			OOMFJGPAOKL().SetFloat("_EmissionColor", Distortion);
			ECCPAOBFDKP().SetFloat("settings.volume.menu", SizeX);
			ABHDNGIHBKE().SetFloat("Mouse Wheel Down", SizeY);
			DOHGBNPMBKG().SetFloat("CameraFilterPack/Gradients_FireGradient", Speed);
			FGENHBKMPDA().SetTexture("\n\n#", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
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
			DOMEEFLPEPJ().SetFloat("steamid", Distortion);
			IONHGBPGCHK().SetFloat("_MainTex2", SizeX);
			GKILCDHJFEG().SetFloat("#failed: ", SizeY);
			GKILCDHJFEG().SetFloat("CameraFilterPack/Light_Water2", Speed);
			CFEDGDGBCHE().SetTexture("ConfigVersionSlider", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
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
			KEMAALEODNH().SetFloat("player.goldbat", HBJJOCHGOPH);
			OOMFJGPAOKL().SetFloat(": ", Distortion);
			KEMAALEODNH().SetFloat("KickThePlayer", SizeX);
			NDMPCDHADMJ().SetFloat("sounds/hit_wrong", SizeY);
			JCPDCGIJKJD().SetFloat("If you host Photon yourself, make sure to start the 'Instance LoadBalancing' ", Speed);
			CFEDGDGBCHE().SetTexture("[Up]", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADAFMBOGPLN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FANADGBGCPI()
	{
		FPHEBLMINDA = Resources.Load("#failed!") as Texture2D;
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MDNHCLKNCLE()
	{
		FPHEBLMINDA = Resources.Load("win") as Texture2D;
		SCShader = Shader.Find("_Value2");
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
			JCPDCGIJKJD().SetFloat("Tab1Content", HBJJOCHGOPH);
			LPCHMEKDCHI().SetFloat("Operation ", Distortion);
			HNICHJCGJOC().SetFloat("/", SizeX);
			EHDJJANLINB().SetFloat("CameraFilterPack_Glasses_On6", SizeY);
			JCPDCGIJKJD().SetFloat("settings.fps", Speed);
			HKHBBBFLGJH().SetTexture(".lastCheckpoint.comboScore", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KOFAMEKHHGD()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack/TV_ARCADE") as Texture2D;
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
			FEAEGGCNIAA().SetFloat("Speed", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("mapselector.tags.", Distortion);
			EHDJJANLINB().SetFloat("_OcclusionTexture", SizeX);
			DOMEEFLPEPJ().SetFloat("settings.crosshairopacity", SizeY);
			KEMAALEODNH().SetFloat("menu.playedpage", Speed);
			DOHGBNPMBKG().SetTexture("MapEnd", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
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
			KBOPGONOCNP().SetFloat("maps.", HBJJOCHGOPH);
			EHDJJANLINB().SetFloat("?", Distortion);
			OIBHFCLJKDB().SetFloat("_Near", SizeX);
			HKGAONMOBMH().SetFloat("CameraFilterPack_eyes_vision_2", SizeY);
			HKHBBBFLGJH().SetFloat("_Value6", Speed);
			EHDJJANLINB().SetTexture("inventory.selected.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
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
		FPHEBLMINDA = Resources.Load("OnPickedUp") as Texture2D;
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
			HKGAONMOBMH().SetFloat("Created", HBJJOCHGOPH);
			IIBLJCKLGFG().SetFloat("_Value2", Distortion);
			HCGJCMDJPGD().SetFloat("MenuVolumeSlider", SizeX);
			LDNADDJMIPK().SetFloat("ERROR: Make sure your mod contains at leats one file!", SizeY);
			NDMPCDHADMJ().SetFloat(".lastCheckpoint.incorrectScore", Speed);
			HKGAONMOBMH().SetTexture("#score", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPCHMEKDCHI());
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
		FPHEBLMINDA = Resources.Load("</color>") as Texture2D;
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
			OCMBHMLNCEK().SetFloat(" not exist", HBJJOCHGOPH);
			DOHGBNPMBKG().SetFloat("EventMenu", Distortion);
			KEMAALEODNH().SetFloat("open", SizeX);
			KEMAALEODNH().SetFloat("#000000", SizeY);
			HNICHJCGJOC().SetFloat("VoteDownToggle", Speed);
			HKGAONMOBMH().SetTexture("_ScreenResolution", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
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
			FEAEGGCNIAA().SetFloat("_BlurVector", HBJJOCHGOPH);
			OIBHFCLJKDB().SetFloat("GlassesColor2", Distortion);
			LPCHMEKDCHI().SetFloat("\\", SizeX);
			ECCPAOBFDKP().SetFloat("public", SizeY);
			FKEOGPDLBDD().SetFloat("UseFinalGlassColor", Speed);
			DOHGBNPMBKG().SetTexture("_Saturation", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FMNPFCHBLJF()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack/Blend2Camera_LinearBurn") as Texture2D;
		SCShader = Shader.Find("_Offsets");
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
			JCPDCGIJKJD().SetFloat("NEW_ACHIEVEMENT_1_", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("_BlurredColor", Distortion);
			HNICHJCGJOC().SetFloat("_TimeX", SizeX);
			ADAFMBOGPLN().SetFloat("InfoText", SizeY);
			OCMBHMLNCEK().SetFloat("y", Speed);
			NDMPCDHADMJ().SetTexture("steamid", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
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
		SCShader = Shader.Find("SetSunColors");
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
			ADAFMBOGPLN().SetFloat("_MainTex2", HBJJOCHGOPH);
			OOMFJGPAOKL().SetFloat("_Value4", Distortion);
			HNICHJCGJOC().SetFloat("_TimeX", SizeX);
			DEFBJOCJJKF().SetFloat("menu.relaxinfo", SizeY);
			OIBHFCLJKDB().SetFloat("help", Speed);
			HCGJCMDJPGD().SetTexture("AddEnvironmentObject", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
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
		FPHEBLMINDA = Resources.Load("_TimeX") as Texture2D;
		SCShader = Shader.Find("Texture3");
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
			ABHDNGIHBKE().SetFloat("RoomNameText", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat("_MainTex2", Distortion);
			IONHGBPGCHK().SetFloat("_ScreenResolution", SizeX);
			KEMAALEODNH().SetFloat("Set satellite trail width", SizeY);
			HCGJCMDJPGD().SetFloat("menu.enableselectormusic", Speed);
			DOMEEFLPEPJ().SetTexture("GroupNameText", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
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
			GHHPOGODBHB().SetFloat("/Segment-[Up]", HBJJOCHGOPH);
			IIBLJCKLGFG().SetFloat("UI Extensions/SoftMaskShaderText", Distortion);
			KBOPGONOCNP().SetFloat("MaxLivesSlider", SizeX);
			HHIFMIPPMPF().SetFloat("<b>#", SizeY);
			EHDJJANLINB().SetFloat("Set Satellite Emission", Speed);
			HNICHJCGJOC().SetTexture("_TimeX", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADAFMBOGPLN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NKFDNIAKGEO()
	{
		FPHEBLMINDA = Resources.Load(".status") as Texture2D;
		SCShader = Shader.Find("_Red_G");
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
			GHHPOGODBHB().SetFloat(" (now: ", HBJJOCHGOPH);
			LPCHMEKDCHI().SetFloat("_Distortion", Distortion);
			ECCPAOBFDKP().SetFloat("SetSpeed", SizeX);
			FGENHBKMPDA().SetFloat("Depth textures aren't supported on this device ({0})", SizeY);
			ECCPAOBFDKP().SetFloat("AreaTex", Speed);
			LPCHMEKDCHI().SetTexture("player.greenarc", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIBHFCLJKDB());
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
			JCPDCGIJKJD().SetFloat("CameraFilterPack/Oculus_ThermaVision", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("[ERROR KEY {0}]", Distortion);
			FKEOGPDLBDD().SetFloat("ItemTemplate", SizeX);
			HKGAONMOBMH().SetFloat("maps.", SizeY);
			ADAFMBOGPLN().SetFloat("_BlurVector", Speed);
			GHHPOGODBHB().SetTexture("LevelEditor/patterns", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NDMPCDHADMJ());
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
			GHHPOGODBHB().SetFloat(" not exist", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("_TimeX", Distortion);
			OCMBHMLNCEK().SetFloat(". Going to ignore! Check PhotonServerSettings.RpcList", SizeX);
			ADAFMBOGPLN().SetFloat("_ScreenResolution", SizeY);
			KBOPGONOCNP().SetFloat("settings.disablestoryboard", Speed);
			IONHGBPGCHK().SetTexture("_Value4", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
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
			DKNJGHFLAIF().SetFloat("MultiplayerButton", HBJJOCHGOPH);
			JCPDCGIJKJD().SetFloat("_Value6", Distortion);
			LDNADDJMIPK().SetFloat("settings.disablestoryboard", SizeX);
			IONHGBPGCHK().SetFloat("setAF", SizeY);
			DKNJGHFLAIF().SetFloat("_FgOverlap", Speed);
			DOHGBNPMBKG().SetTexture("ns", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
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
			IIBLJCKLGFG().SetFloat("CameraFilterPack_Paper4", HBJJOCHGOPH);
			OIBHFCLJKDB().SetFloat("IDInputField", Distortion);
			DOMEEFLPEPJ().SetFloat("_Near", SizeX);
			ABHDNGIHBKE().SetFloat("Scrollbar", SizeY);
			ECCPAOBFDKP().SetFloat("_MatrixColor", Speed);
			FKEOGPDLBDD().SetTexture("OK", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIBHFCLJKDB());
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
		FPHEBLMINDA = Resources.Load("Chat") as Texture2D;
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
			LPCHMEKDCHI().SetFloat("<b>HP</b>:", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat("_RangeScale", Distortion);
			HFBJAOFLCJI().SetFloat("maps.", SizeX);
			FGENHBKMPDA().SetFloat("Drop_Near", SizeY);
			NLFJGMBCICG().SetFloat("_Value2", Speed);
			GHHPOGODBHB().SetTexture("In Main Menu", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
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
			LPCHMEKDCHI().SetFloat("Bad parameters for setbool! Use <key> <value>", HBJJOCHGOPH);
			DOMEEFLPEPJ().SetFloat("menu.resetlevelcheckpoint", Distortion);
			KBOPGONOCNP().SetFloat("settings.arcshitsoundtimedelay", SizeX);
			DOHGBNPMBKG().SetFloat("_PColor2", SizeY);
			JCPDCGIJKJD().SetFloat("NEW_ACHIEVEMENT_1_21", Speed);
			FGENHBKMPDA().SetTexture("maps.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
		FPHEBLMINDA = Resources.Load("_Red_C") as Texture2D;
		SCShader = Shader.Find("USE_PREDICATION");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
