// CameraFilterPack_Light_Water2
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Light/Water2")]
[ExecuteInEditMode]
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
			PLBEJJIHFPB().SetFloat("CameraFilterPack/Glasses_On", HBJJOCHGOPH);
			CIAFLBFJLEJ().SetFloat("_MainTex2", Speed);
			PLBEJJIHFPB().SetFloat("_PColor", Speed_X);
			FKEOGPDLBDD().SetFloat("ExitButton", Speed_Y);
			NDMPCDHADMJ().SetFloat(") of this PhotonView does not implement OnPhotonSerializeView()!", Intensity);
			HEINDEMCGIK().SetVector("settings.arcshitsoundtimedelay", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 561f, 1124f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, INOBFNCKFGK());
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
		SCShader = Shader.Find("Set Object Scale");
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
		SCShader = Shader.Find("ERROR: Make sure your mod contains at leats one file!");
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
			KGOLDDBHIFN().SetFloat("/", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("MenuVolumeSlider", Speed);
			DKNJGHFLAIF().SetFloat("CameraFilterPack/FX_InverChromiLum", Speed_X);
			NBPKMLMCHFN.SetFloat("Texture2", Speed_Y);
			OIMMPLPBLBK().SetFloat("EventData0DropDownList", Intensity);
			IONHGBPGCHK().SetVector("SpawnObj", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1855f, 1386f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			AELJLBOJAIL().SetFloat("music", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("TRACKING", Speed);
			FGENHBKMPDA().SetFloat("_Radius", Speed_X);
			NLFJGMBCICG().SetFloat("_Bullet_2", Speed_Y);
			DEFBJOCJJKF().SetFloat("1.87", Intensity);
			IONHGBPGCHK().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 808f, 1791f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CIAFLBFJLEJ());
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
			FLOHGDECHHH().SetFloat("_TimeX", HBJJOCHGOPH);
			KDMBOKLMADJ().SetFloat("SpawnObj", Speed);
			INOBFNCKFGK().SetFloat("attempted to spawn a GameObject from recycle bin (", Speed_X);
			PLBEJJIHFPB().SetFloat("skin.hit_wrong", Speed_Y);
			HEINDEMCGIK().SetFloat("Case-Sensitive", Intensity);
			FKEOGPDLBDD().SetVector("#91CCFF", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 155f, 215f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
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
			FGENHBKMPDA().SetFloat("_Colored", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value11", Speed);
			FKEOGPDLBDD().SetFloat("Player", Speed_X);
			DKNJGHFLAIF().SetFloat("_Value", Speed_Y);
			NLFJGMBCICG().SetFloat("Editor/", Intensity);
			KGOLDDBHIFN().SetVector(" Kb", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1498f, 1723f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
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
			INOBFNCKFGK().SetFloat("_Value5", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("_ScreenResolution", Speed);
			FLOHGDECHHH().SetFloat("SlidingArea", Speed_X);
			FKEOGPDLBDD().SetFloat("SetSunInput", Speed_Y);
			NDMPCDHADMJ().SetFloat("CameraFilterPack/TV_Video3D", Intensity);
			AELJLBOJAIL().SetVector("menu.selectedlevelid", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1818f, 443f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
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
			CIAFLBFJLEJ().SetFloat("OxOD.lastPath", HBJJOCHGOPH);
			CIAFLBFJLEJ().SetFloat("_TimeX", Speed);
			OIMMPLPBLBK().SetFloat("effector", Speed_X);
			DEFBJOCJJKF().SetFloat("<b>#banended</b>", Speed_Y);
			FAIFBBGFAIB().SetFloat(" ", Intensity);
			INOBFNCKFGK().SetVector("TimeBGSlider", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 711f, 1003f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLOHGDECHHH());
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
			NLFJGMBCICG().SetFloat("CameraFilterPack_TV_Vignetting1", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("settings.enableranking", Speed);
			NFKFAAHHLLM().SetFloat(": ", Speed_X);
			IONHGBPGCHK().SetFloat("_Value4", Speed_Y);
			IONHGBPGCHK().SetFloat("[Steamworks.NET] Packsize Test returned false, the wrong version of Steamworks.NET is being run in this platform.", Intensity);
			HEINDEMCGIK().SetVector("_Green_B", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1959f, 439f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FMFNILJIEIA()
	{
		SCShader = Shader.Find("_Color");
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
			IONHGBPGCHK().SetFloat("EventMenu", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("#md5submitionfailed: ", Speed);
			OIMMPLPBLBK().SetFloat("_TimeX", Speed_X);
			KGOLDDBHIFN().SetFloat("_Value9", Speed_Y);
			DEFBJOCJJKF().SetFloat("LevelConfigButton", Intensity);
			KDMBOKLMADJ().SetVector("_RgbTex", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 909f, 202f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
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
			HEINDEMCGIK().SetFloat("OnReadyClick", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("#ok", Speed);
			AELJLBOJAIL().SetFloat("Apr", Speed_X);
			FAIFBBGFAIB().SetFloat("[LevelEditorScene] Error: I/O Failure! :(", Speed_Y);
			DKNJGHFLAIF().SetFloat("Fill Area", Intensity);
			NBPKMLMCHFN.SetVector("Tab1Content", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1613f, 1322f));
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
			HEINDEMCGIK().SetFloat("GameScene", HBJJOCHGOPH);
			HEINDEMCGIK().SetFloat("http", Speed);
			CIAFLBFJLEJ().SetFloat("ShineEffect", Speed_X);
			OIMMPLPBLBK().SetFloat("Preparing configuration", Speed_Y);
			NLFJGMBCICG().SetFloat("Failed to Destroy objects of playerId: ", Intensity);
			IONHGBPGCHK().SetVector("Reset", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 930f, 374f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
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
		SCShader = Shader.Find("[Up-Right-Left]");
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
			DKNJGHFLAIF().SetFloat("_NoiseTex", HBJJOCHGOPH);
			INOBFNCKFGK().SetFloat("[PowerUp]", Speed);
			INOBFNCKFGK().SetFloat("GhostSize", Speed_X);
			FKEOGPDLBDD().SetFloat("player.goldcrystal", Speed_Y);
			NDMPCDHADMJ().SetFloat("DisableStoryboardToggle", Intensity);
			OIMMPLPBLBK().SetVector("ControllerLeftY", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1183f, 614f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
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
		SCShader = Shader.Find("_ChannelMixerBlue");
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
			FKEOGPDLBDD().SetFloat("Error0", HBJJOCHGOPH);
			KDMBOKLMADJ().SetFloat("\" that takes ", Speed);
			IONHGBPGCHK().SetFloat("/", Speed_X);
			HEINDEMCGIK().SetFloat("settings.disablestoryboard", Speed_Y);
			FLOHGDECHHH().SetFloat("\n", Intensity);
			NMDBCDFPGOK().SetVector("ns", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 638f, 1976f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			NLFJGMBCICG().SetFloat("float,0.5", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("/", Speed);
			NMDBCDFPGOK().SetFloat("Committing changes...", Speed_X);
			DKNJGHFLAIF().SetFloat("_Value3", Speed_Y);
			KGOLDDBHIFN().SetFloat("CameraFilterPack/TV_PlanetMars", Intensity);
			FKEOGPDLBDD().SetVector("ERROR: Preview file name in modName.workshop.json doesn't match any file", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 552f, 1819f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB());
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
			FAIFBBGFAIB().SetFloat("Set Object Rotation", HBJJOCHGOPH);
			FKEOGPDLBDD().SetFloat("CameraFilterPack_Glasses_On7", Speed);
			NDMPCDHADMJ().SetFloat("[Down]", Speed_X);
			FKEOGPDLBDD().SetFloat("ZoomSpeed", Speed_Y);
			CIAFLBFJLEJ().SetFloat("(singleton) ", Intensity);
			OIMMPLPBLBK().SetVector("Mouse X", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1984f, 952f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
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
			NDMPCDHADMJ().SetFloat("player.crystal", HBJJOCHGOPH);
			NDMPCDHADMJ().SetFloat("_TimeX", Speed);
			NBPKMLMCHFN.SetFloat("Bad parameters for getstring! Use <key> <value>", Speed_X);
			AELJLBOJAIL().SetFloat("_TimeX", Speed_Y);
			FGENHBKMPDA().SetFloat("_Value2", Intensity);
			KDMBOKLMADJ().SetVector("_Blue_R", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1683f, 169f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
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
			KDMBOKLMADJ().SetFloat("_Value2", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("_Value", Speed);
			KGOLDDBHIFN().SetFloat("SetSatelliteRotationSpeed", Speed_X);
			OIMMPLPBLBK().SetFloat("Tab2Content", Speed_Y);
			FLOHGDECHHH().SetFloat("_Intensity", Intensity);
			KDMBOKLMADJ().SetVector("_AdaptationMin", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1239f, 1440f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NMDBCDFPGOK());
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
		SCShader = Shader.Find("SetParticlesParticleSize");
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
		SCShader = Shader.Find("SpectateButton");
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
			NLFJGMBCICG().SetFloat("yyyy-MM-dd HH:mm:ss", HBJJOCHGOPH);
			KDMBOKLMADJ().SetFloat("note.5", Speed);
			OIMMPLPBLBK().SetFloat("workshop.", Speed_X);
			KDMBOKLMADJ().SetFloat(",", Speed_Y);
			OIMMPLPBLBK().SetFloat("CameraFilterPack/VHS_Tracking", Intensity);
			OIMMPLPBLBK().SetVector("_Value4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 514f, 1285f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB());
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
			IONHGBPGCHK().SetFloat("UseScanLineSize", HBJJOCHGOPH);
			NFKFAAHHLLM().SetFloat("Working.\nPlease wait..", Speed);
			OIMMPLPBLBK().SetFloat("_RGB", Speed_X);
			PLBEJJIHFPB().SetFloat(" ", Speed_Y);
			NLFJGMBCICG().SetFloat("[Up-Right-Down-Left]", Intensity);
			CIAFLBFJLEJ().SetVector("SetSunInput", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 561f, 1531f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
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
		SCShader = Shader.Find("challenges.");
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
			PLBEJJIHFPB().SetFloat("Object ID. Case-Sensitive", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("PopulateMapsList", Speed);
			NLFJGMBCICG().SetFloat("BitsData", Speed_X);
			NBPKMLMCHFN.SetFloat("rarity", Speed_Y);
			OIMMPLPBLBK().SetFloat("Could not find RPC with index: ", Intensity);
			NDMPCDHADMJ().SetVector("No regions available. Are you sure your appid is valid and setup?", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 523f, 1768f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
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
		SCShader = Shader.Find(" not exist");
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
			NFKFAAHHLLM().SetFloat(">", HBJJOCHGOPH);
			KDMBOKLMADJ().SetFloat("_Blend", Speed);
			OIMMPLPBLBK().SetFloat("_BlurVector", Speed_X);
			KDMBOKLMADJ().SetFloat("_ScreenResolution", Speed_Y);
			KDMBOKLMADJ().SetFloat("_Line", Intensity);
			NMDBCDFPGOK().SetVector("_History4LumaTex", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 195f, 1680f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DKOPKPBLDHH()
	{
		SCShader = Shader.Find(":");
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
			KDMBOKLMADJ().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			HEINDEMCGIK().SetFloat("CameraFilterPack/Atmosphere_Rain_Pro", Speed);
			IONHGBPGCHK().SetFloat("_ScreenResolution", Speed_X);
			HEINDEMCGIK().SetFloat("solo", Speed_Y);
			FKEOGPDLBDD().SetFloat("Set satellite lerp speed", Intensity);
			NBPKMLMCHFN.SetVector("bool", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 596f, 45f));
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
			DEFBJOCJJKF().SetFloat("_TimeX", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("_Value", Speed);
			FLOHGDECHHH().SetFloat("CameraFilterPack/FX_Hexagon", Speed_X);
			NDMPCDHADMJ().SetFloat("SetSatelliteLerpSpeed", Speed_Y);
			AELJLBOJAIL().SetFloat(": ", Intensity);
			IONHGBPGCHK().SetVector("Network destroy Instantiated GO: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1425f, 233f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
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
		SCShader = Shader.Find("true");
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
			KDMBOKLMADJ().SetFloat("Bad modpack name: {0}", HBJJOCHGOPH);
			FKEOGPDLBDD().SetFloat("#close", Speed);
			NMDBCDFPGOK().SetFloat("PlayButton", Speed_X);
			NMDBCDFPGOK().SetFloat("Warning: Unhandled event ", Speed_Y);
			CIAFLBFJLEJ().SetFloat("Can't set open when not in that room.", Intensity);
			NBPKMLMCHFN.SetVector("/../", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1870f, 1098f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
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
			FAIFBBGFAIB().SetFloat("PhotonView with ID {0} wasn't properly unregistered! Please report this case to developer@photonengine.com", HBJJOCHGOPH);
			HEINDEMCGIK().SetFloat("_Blue_G", Speed);
			NLFJGMBCICG().SetFloat("/../", Speed_X);
			NLFJGMBCICG().SetFloat("IconFileSelector", Speed_Y);
			HEINDEMCGIK().SetFloat("_Distortion", Intensity);
			INOBFNCKFGK().SetVector("1,30,true,0", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1497f, 698f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NMDBCDFPGOK());
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
			NFKFAAHHLLM().SetFloat("SetSpeed", HBJJOCHGOPH);
			NDMPCDHADMJ().SetFloat("_Value", Speed);
			INOBFNCKFGK().SetFloat("Jul", Speed_X);
			FLOHGDECHHH().SetFloat("_Red_B", Speed_Y);
			FLOHGDECHHH().SetFloat("/icon", Intensity);
			NDMPCDHADMJ().SetVector("_SampleCount", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 84f, 1543f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NMDBCDFPGOK());
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
			NLFJGMBCICG().SetFloat(".", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("_Strength", Speed);
			FKEOGPDLBDD().SetFloat("_Far", Speed_X);
			OIMMPLPBLBK().SetFloat("s", Speed_Y);
			DKNJGHFLAIF().SetFloat("BitsData", Intensity);
			INOBFNCKFGK().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1671f, 1194f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
