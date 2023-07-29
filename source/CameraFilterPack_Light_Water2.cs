// CameraFilterPack_Light_Water2
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Light/Water2")]
public class CameraFilterPack_Light_Water2 : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 10f)]
	public float Speed = 0.2f;

	[Range(0f, 10f)]
	public float Speed_X = 0.2f;

	[Range(0f, 1f)]
	public float Speed_Y = 0.3f;

	[Range(0f, 10f)]
	public float Intensity = 2.4f;

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
	private Material KDMBOKLMADJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material FAIFBBGFAIB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1913f)
			{
				HBJJOCHGOPH = 1781f;
			}
			CIAFLBFJLEJ().SetFloat("CameraFilterPack/Glasses_On", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("_MainTex2", Speed);
			IONHGBPGCHK().SetFloat("_Value1", Speed_X);
			AELJLBOJAIL().SetFloat("ExitButton", Speed_Y);
			AELJLBOJAIL().SetFloat("GO==null", Intensity);
			KGOLDDBHIFN().SetVector("[PlayerBase] Loaded spawner data", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 561f, 1124f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MECJHOJPODB()
	{
	}

	private void LLDHEJIEDHO()
	{
	}

	private void MKFLBEGJJDC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NAALCEPIHCH()
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

	private void IFIHBNJKEKD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FBPHNEJBDJN()
	{
		SCShader = Shader.Find("id");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Light_Water2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FDPOFMCFBMF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CHOPDIGHJNH()
	{
		SCShader = Shader.Find("ERROR: Preview file must be <1MB!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 609f)
			{
				HBJJOCHGOPH = 1830f;
			}
			FKEOGPDLBDD().SetFloat("PopulateMapsList", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("Scene", Speed);
			HEINDEMCGIK().SetFloat("_TimeX", Speed_X);
			NDMPCDHADMJ().SetFloat("CameraFilterPack/FX_8bits", Speed_Y);
			FLOHGDECHHH().SetFloat("bpmgrid", Intensity);
			NDMPCDHADMJ().SetVector("Checkpoint", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1855f, 1386f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NNPBKKBFDHH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IBPAMDEAGJL()
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

	private void HNDNDPECBPL()
	{
	}

	private void LJIHHJOAJCN()
	{
	}

	[SpecialName]
	private Material HEINDEMCGIK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)127;
		}
		return BJFKDHHMLJH;
	}

	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1228f)
			{
				HBJJOCHGOPH = 390f;
			}
			NMDBCDFPGOK().SetFloat("/", HBJJOCHGOPH);
			INOBFNCKFGK().SetFloat("JITTER", Speed);
			FLOHGDECHHH().SetFloat("_Radius", Speed_X);
			INOBFNCKFGK().SetFloat("_Bullet_3", Speed_Y);
			NBPKMLMCHFN.SetFloat("wss://", Intensity);
			IONHGBPGCHK().SetVector("Editor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 808f, 1791f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HDDECCMEJKA()
	{
	}

	[SpecialName]
	private Material FKEOGPDLBDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void HAIAHJPCPAG()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 553f)
			{
				HBJJOCHGOPH = 457f;
			}
			INOBFNCKFGK().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat(".mp3", Speed);
			NLFJGMBCICG().SetFloat("automaticallyRecycleParticleSystems is true but there is no ParticleSystem on this GameObject!", Speed_X);
			KGOLDDBHIFN().SetFloat("skin.hit_perfect", Speed_Y);
			AELJLBOJAIL().SetFloat("x", Intensity);
			DKNJGHFLAIF().SetVector("#EA4137", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 155f, 215f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KCDOMIJBFLL()
	{
	}

	private void OCCGJMPAJIK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1828f)
			{
				HBJJOCHGOPH = 1967f;
			}
			DEFBJOCJJKF().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			FGENHBKMPDA().SetFloat("_Value11", Speed);
			FLOHGDECHHH().SetFloat("https://steamcommunity.com/app/513510/workshop/", Speed_X);
			FKEOGPDLBDD().SetFloat("_ScreenResolution", Speed_Y);
			NDMPCDHADMJ().SetFloat("/", Intensity);
			FLOHGDECHHH().SetVector(" Mb", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1498f, 1723f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
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
			if (HBJJOCHGOPH > 341f)
			{
				HBJJOCHGOPH = 1815f;
			}
			DEFBJOCJJKF().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			CIAFLBFJLEJ().SetFloat("CameraFilterPack/Color_Chromatic_Aberration", Speed);
			FKEOGPDLBDD().SetFloat("ItemTemplate", Speed_X);
			KDMBOKLMADJ().SetFloat("SetSunInput", Speed_Y);
			CIAFLBFJLEJ().SetFloat("_ScreenResolution", Intensity);
			INOBFNCKFGK().SetVector("menu.selectedlevelid", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1818f, 443f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FEKECCBFGMI()
	{
		SCShader = Shader.Find("float,1.5");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material KGOLDDBHIFN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-81);
		}
		return BJFKDHHMLJH;
	}

	private void EKCDEFDELMP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FOLDLDLFFLM()
	{
	}

	private void GJCOELHNLJE()
	{
	}

	[SpecialName]
	private Material OIMMPLPBLBK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)76;
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

	private void HEBOIFKBLGD()
	{
	}

	private void GPFJMKCGHGB()
	{
	}

	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1979f)
			{
				HBJJOCHGOPH = 1419f;
			}
			NMDBCDFPGOK().SetFloat("OxOD.lastPath", HBJJOCHGOPH);
			CIAFLBFJLEJ().SetFloat("_TimeX", Speed);
			OIMMPLPBLBK().SetFloat("UI Extensions/SoftMaskShader", Speed_X);
			NLFJGMBCICG().SetFloat("<b>#banended</b>", Speed_Y);
			FGENHBKMPDA().SetFloat(" ", Intensity);
			FLOHGDECHHH().SetVector("TimeBGSlider", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 711f, 1003f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 314f)
			{
				HBJJOCHGOPH = 1649f;
			}
			CIAFLBFJLEJ().SetFloat("Vignette", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("settings.enableranking", Speed);
			DEFBJOCJJKF().SetFloat(" / ", Speed_X);
			AELJLBOJAIL().SetFloat("_ScreenResolution", Speed_Y);
			KGOLDDBHIFN().SetFloat("[Steamworks.NET] SteamAPI_Init() failed. Refer to Valve's documentation or the comment above this line for more information.", Intensity);
			PLBEJJIHFPB().SetVector("_Green_B", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1959f, 439f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FMFNILJIEIA()
	{
		SCShader = Shader.Find("LevelEditor/icons");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1274f)
			{
				HBJJOCHGOPH = 1291f;
			}
			NDMPCDHADMJ().SetFloat("EventMenu", HBJJOCHGOPH);
			CIAFLBFJLEJ().SetFloat("#tryagain", Speed);
			OIMMPLPBLBK().SetFloat("_EdgeWeight", Speed_X);
			PLBEJJIHFPB().SetFloat("_Value9", Speed_Y);
			KGOLDDBHIFN().SetFloat("PublishButton", Intensity);
			FAIFBBGFAIB().SetVector("selColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 909f, 202f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1849f)
			{
				HBJJOCHGOPH = 584f;
			}
			DEFBJOCJJKF().SetFloat("OnReadyClick", HBJJOCHGOPH);
			FGENHBKMPDA().SetFloat("[MapEditor] Exported to ", Speed);
			FAIFBBGFAIB().SetFloat("Jun", Speed_X);
			KGOLDDBHIFN().SetFloat("[LevelEditorScene] Error: I/O Failure! :(", Speed_Y);
			NDMPCDHADMJ().SetFloat("Fill", Intensity);
			AELJLBOJAIL().SetVector("Tab1Content", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1613f, 1322f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return BJFKDHHMLJH;
	}

	private void EHCGBJDFMHG()
	{
	}

	private void HIPEHGNBJMN()
	{
		SCShader = Shader.Find("ItemNameBGImage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material FGENHBKMPDA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void HGDDCINLDAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HNILMGEKDEC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IBFJAOINHMK()
	{
	}

	private void MCKCCPLJIFE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NAOLAJPDGIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 47f)
			{
				HBJJOCHGOPH = 1214f;
			}
			OIMMPLPBLBK().SetFloat("Right", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("skin.", Speed);
			CIAFLBFJLEJ().SetFloat("ShineEffect", Speed_X);
			PLBEJJIHFPB().SetFloat("Preparing configuration", Speed_Y);
			OIMMPLPBLBK().SetFloat("Failed to 'network-remove' GameObject. Client is neither owner nor masterClient taking over for owner who left: ", Intensity);
			FKEOGPDLBDD().SetVector("Incoming: \n", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 930f, 374f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material NDMPCDHADMJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void OFMNDBNFBDJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ICILLMAKLMI()
	{
		SCShader = Shader.Find("PenaltyScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KFACDBHDAOD()
	{
	}

	[SpecialName]
	private Material NFKFAAHHLLM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInHierarchy);
		}
		return BJFKDHHMLJH;
	}

	private void LFAFJKJAEEL()
	{
		SCShader = Shader.Find("[Up-Right-Down]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
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
			NBPKMLMCHFN.SetFloat("_Value", Speed);
			NBPKMLMCHFN.SetFloat("_Value2", Speed_X);
			NBPKMLMCHFN.SetFloat("_Value3", Speed_Y);
			NBPKMLMCHFN.SetFloat("_Value4", Intensity);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PFNFPINPCMH()
	{
	}

	private void BDBJEDIOKBN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LADCJEIALMH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EPEGAEGDJAM()
	{
		SCShader = Shader.Find("TotalHitsScoreText");
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
			if (HBJJOCHGOPH > 442f)
			{
				HBJJOCHGOPH = 1650f;
			}
			FGENHBKMPDA().SetFloat("_NeighbourMaxTex", HBJJOCHGOPH);
			NMDBCDFPGOK().SetFloat("[PowerUp]", Speed);
			NMDBCDFPGOK().SetFloat("GhostSize", Speed_X);
			KDMBOKLMADJ().SetFloat("player.goldcrystal", Speed_Y);
			AELJLBOJAIL().SetFloat("settings.disablestoryboard", Intensity);
			CIAFLBFJLEJ().SetVector("Jump", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1183f, 614f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GPNAOAKCMHC()
	{
		SCShader = Shader.Find("player.mysteryitem");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HCIPECAOGIA()
	{
	}

	private void DBEMDAJDDDA()
	{
		SCShader = Shader.Find("ENABLE_COLOR_GRADING");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FGOPJMGNHGO()
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
			if (HBJJOCHGOPH > 932f)
			{
				HBJJOCHGOPH = 1902f;
			}
			FAIFBBGFAIB().SetFloat("SpawnObj", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("PhotonView with ID ", Speed);
			NMDBCDFPGOK().SetFloat("/", Speed_X);
			KGOLDDBHIFN().SetFloat("settings.enableselectormusic", Speed_Y);
			CIAFLBFJLEJ().SetFloat("\n", Intensity);
			KGOLDDBHIFN().SetVector("ns", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 638f, 1976f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 330f)
			{
				HBJJOCHGOPH = 1671f;
			}
			OIMMPLPBLBK().SetFloat("float,0.5", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("SetSpeed", Speed);
			KGOLDDBHIFN().SetFloat("In Map Editor", Speed_X);
			DEFBJOCJJKF().SetFloat("_Value4", Speed_Y);
			FGENHBKMPDA().SetFloat("_Distortion", Intensity);
			CIAFLBFJLEJ().SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 552f, 1819f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OPCLBGHAPMG()
	{
	}

	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1635f)
			{
				HBJJOCHGOPH = 510f;
			}
			NDMPCDHADMJ().SetFloat("id", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("CameraFilterPack/Glasses_On", Speed);
			FLOHGDECHHH().SetFloat("_EmissionGain", Speed_X);
			NLFJGMBCICG().SetFloat("CameraFilterPack/TV_CompressionFX", Speed_Y);
			NMDBCDFPGOK().SetFloat("[Singleton] multiple instances of '", Intensity);
			FAIFBBGFAIB().SetVector("STICKLHOR", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1984f, 952f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ELGOMIMONOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1822f)
			{
				HBJJOCHGOPH = 386f;
			}
			CIAFLBFJLEJ().SetFloat("player.goldcrystal", HBJJOCHGOPH);
			INOBFNCKFGK().SetFloat("_RedAmplifier", Speed);
			FAIFBBGFAIB().SetFloat("Result for ", Speed_X);
			DKNJGHFLAIF().SetFloat("_ScreenResolution", Speed_Y);
			PLBEJJIHFPB().SetFloat("_Value3", Intensity);
			DEFBJOCJJKF().SetVector("_Blue_B", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1683f, 169f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material AELJLBOJAIL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)126;
		}
		return BJFKDHHMLJH;
	}

	private void JHJGJJKELJM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JHLGHODFJOO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FJNCHGLIEMA()
	{
		SCShader = Shader.Find("[SERVER] Player ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OKHBBIKDIEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 493f)
			{
				HBJJOCHGOPH = 1235f;
			}
			HEINDEMCGIK().SetFloat("_Value4", HBJJOCHGOPH);
			NFKFAAHHLLM().SetFloat("_Value2", Speed);
			DEFBJOCJJKF().SetFloat("SetSatelliteTrailLength", Speed_X);
			INOBFNCKFGK().SetFloat("Tab2Content", Speed_Y);
			AELJLBOJAIL().SetFloat("_TargetScale", Intensity);
			KGOLDDBHIFN().SetVector("_LumTex", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1239f, 1440f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, INOBFNCKFGK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material CIAFLBFJLEJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void DFFKKLAPHCC()
	{
		SCShader = Shader.Find("Set Particle Size");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IKMELABKBHO()
	{
	}

	private void GNMGIHFKJIJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CCPEDDLAMIB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material PLBEJJIHFPB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-77);
		}
		return BJFKDHHMLJH;
	}

	private void DPIPGGDNGHN()
	{
	}

	private void PDHKMDBNGGN()
	{
		SCShader = Shader.Find("RestartButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MFLBEJHMEMO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DDBOODLPCAM()
	{
	}

	private void GENCBNFIILN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1808f)
			{
				HBJJOCHGOPH = 212f;
			}
			NLFJGMBCICG().SetFloat("IDInputField", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("note.6", Speed);
			NLFJGMBCICG().SetFloat("workshop.", Speed_X);
			INOBFNCKFGK().SetFloat("time: ", Speed_Y);
			FAIFBBGFAIB().SetFloat("_TimeX", Intensity);
			FLOHGDECHHH().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 514f, 1285f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EJFJENFKLND()
	{
	}

	[SpecialName]
	private Material NMDBCDFPGOK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material DEFBJOCJJKF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)118;
		}
		return BJFKDHHMLJH;
	}

	private void LEAHIBJDMBI()
	{
	}

	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 619f)
			{
				HBJJOCHGOPH = 17f;
			}
			FLOHGDECHHH().SetFloat("UseScanLine", HBJJOCHGOPH);
			NMDBCDFPGOK().SetFloat("ResourceIDInputField", Speed);
			OIMMPLPBLBK().SetFloat("CameraFilterPack_TV_HorrorFX", Speed_X);
			DKNJGHFLAIF().SetFloat(" ", Speed_Y);
			FGENHBKMPDA().SetFloat("[Up-Right-Down-Left]", Intensity);
			INOBFNCKFGK().SetVector("SetSunSensitivity", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 561f, 1531f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CNDACAHCCOI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material INOBFNCKFGK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material FLOHGDECHHH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void AGMJDGHLBMN()
	{
	}

	private void ONPFGCEFMML()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JILOMOBDPIA()
	{
		SCShader = Shader.Find(".status");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1054f)
			{
				HBJJOCHGOPH = 299f;
			}
			FLOHGDECHHH().SetFloat("input", HBJJOCHGOPH);
			NMDBCDFPGOK().SetFloat("EventSystem", Speed);
			FAIFBBGFAIB().SetFloat("BitsData", Speed_X);
			HEINDEMCGIK().SetFloat("InfoText", Speed_Y);
			FLOHGDECHHH().SetFloat("Received RPC \"", Intensity);
			NDMPCDHADMJ().SetVector("' ping: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 523f, 1768f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, INOBFNCKFGK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FJHFOBHJEHL()
	{
	}

	private void KCCIEMBMOBA()
	{
		SCShader = Shader.Find("[PlayerController] ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)100;
		}
		return BJFKDHHMLJH;
	}

	private void APKNAPHOFHC()
	{
	}

	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 874f)
			{
				HBJJOCHGOPH = 576f;
			}
			NDMPCDHADMJ().SetFloat("#", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("_Intensity", Speed);
			DEFBJOCJJKF().SetFloat("_Intensity", Speed_X);
			DEFBJOCJJKF().SetFloat("CameraFilterPack/Vision_Warp2", Speed_Y);
			FKEOGPDLBDD().SetFloat("_Color_R", Intensity);
			NDMPCDHADMJ().SetVector("_History2ChromaTex", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 195f, 1680f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DKOPKPBLDHH()
	{
		SCShader = Shader.Find("yyyy-MM-dd HH:mm:ss");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 763f)
			{
				HBJJOCHGOPH = 991f;
			}
			FGENHBKMPDA().SetFloat("CameraFilterPack/Distortion_ShockWaveManual", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("_TimeX", Speed);
			HEINDEMCGIK().SetFloat("CameraFilterPack_TV_Noise", Speed_X);
			NBPKMLMCHFN.SetFloat("solo", Speed_Y);
			AELJLBOJAIL().SetFloat("Set satellite lerp speed", Intensity);
			PLBEJJIHFPB().SetVector("bool", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 596f, 45f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
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

	private void HMNLHMLILKD()
	{
	}

	private void Update()
	{
	}

	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 297f)
			{
				HBJJOCHGOPH = 1852f;
			}
			NMDBCDFPGOK().SetFloat("_Distortion", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("_Value2", Speed);
			FGENHBKMPDA().SetFloat("_TimeX", Speed_X);
			KDMBOKLMADJ().SetFloat("SetSatelliteTrailMinVertexDistance", Speed_Y);
			PLBEJJIHFPB().SetFloat(" not exist", Intensity);
			NDMPCDHADMJ().SetVector(" from: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1425f, 233f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KNBJBNDGCIJ()
	{
		SCShader = Shader.Find("set environment id");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PNLKFANNOKO()
	{
	}

	private void MMPHNFPPEHO()
	{
		SCShader = Shader.Find("f");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JEBIBKLHFLB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BNLENEDAHHL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BMBIGILMLLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1738f)
			{
				HBJJOCHGOPH = 1555f;
			}
			NDMPCDHADMJ().SetFloat(" to ", HBJJOCHGOPH);
			HEINDEMCGIK().SetFloat("error", Speed);
			KDMBOKLMADJ().SetFloat("PlayButton", Speed_X);
			FAIFBBGFAIB().SetFloat("SetupEncryption() got called. ", Speed_Y);
			HEINDEMCGIK().SetFloat("Can't set Room.MaxPlayers to: ", Intensity);
			KDMBOKLMADJ().SetVector("/../", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1870f, 1098f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JMAIIENCEKE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NJBMCJOOMMP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 28f)
			{
				HBJJOCHGOPH = 1946f;
			}
			NDMPCDHADMJ().SetFloat(". We have no such PhotonView! Ignored this if you're leaving a room. State: ", HBJJOCHGOPH);
			NFKFAAHHLLM().SetFloat("_Blue_G", Speed);
			KGOLDDBHIFN().SetFloat("/", Speed_X);
			AELJLBOJAIL().SetFloat("/", Speed_Y);
			NMDBCDFPGOK().SetFloat("_Distortion", Intensity);
			AELJLBOJAIL().SetVector("1,30,true,0", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1497f, 698f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLOHGDECHHH());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-73);
		}
		return BJFKDHHMLJH;
	}

	private void NPBDIMJDMGA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 334f)
			{
				HBJJOCHGOPH = 1348f;
			}
			CIAFLBFJLEJ().SetFloat("SetSpeed", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value2", Speed);
			IONHGBPGCHK().SetFloat("Sep", Speed_X);
			FLOHGDECHHH().SetFloat("_Green_R", Speed_Y);
			NMDBCDFPGOK().SetFloat("icon", Intensity);
			NBPKMLMCHFN.SetVector("_QualitySettings", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 84f, 1543f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OPHBLNNGFKG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 148f)
			{
				HBJJOCHGOPH = 1377f;
			}
			KGOLDDBHIFN().SetFloat(".lastCheckpoint.time", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("_Strength", Speed);
			KGOLDDBHIFN().SetFloat("_Far", Speed_X);
			FAIFBBGFAIB().SetFloat(", ", Speed_Y);
			NMDBCDFPGOK().SetFloat("BitsData", Intensity);
			FLOHGDECHHH().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1671f, 1194f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
