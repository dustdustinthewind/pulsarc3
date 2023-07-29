// CameraFilterPack_TV_BrokenGlass
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/TV/Broken Glass")]
public class CameraFilterPack_TV_BrokenGlass : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	[Range(0f, 128f)]
	public float Broken_Small;

	[Range(0f, 128f)]
	public float Broken_Medium;

	[Range(0f, 128f)]
	public float Broken_High;

	[Range(0f, 128f)]
	public float Broken_Big = 1f;

	[Range(0f, 0.004f)]
	public float LightReflect = 0.002f;

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

	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 337f)
			{
				HBJJOCHGOPH = 419f;
			}
			PDEAHJPOMEF().SetFloat("[Left]", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("CameraFilterPack/Noise_TV_3", LightReflect);
			KBOPGONOCNP().SetFloat(":", Broken_Small);
			OIMMPLPBLBK().SetFloat("Joystick1Button5", Broken_Medium);
			KEMAALEODNH().SetFloat("_MainTex2", Broken_High);
			NBPKMLMCHFN.SetFloat("deletemap", Broken_Big);
			KBOPGONOCNP().SetTexture("_Value", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KDMKDEKCELE()
	{
		FPHEBLMINDA = Resources.Load("_Size") as Texture2D;
		SCShader = Shader.Find("Tab2Content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JILOMOBDPIA()
	{
		FPHEBLMINDA = Resources.Load("#exit") as Texture2D;
		SCShader = Shader.Find("id");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DKOPKPBLDHH()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack/FX_Drunk2") as Texture2D;
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ICDBMJKMIKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 77f)
			{
				HBJJOCHGOPH = 433f;
			}
			GKILCDHJFEG().SetFloat("SelectorMapsCountSlider", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("ResetButton", LightReflect);
			KBOPGONOCNP().SetFloat("MouseY", Broken_Small);
			OIMMPLPBLBK().SetFloat("EditMenu", Broken_Medium);
			LNLKMDPHDCC().SetFloat("Connect() failed. Can't connect while disconnecting (still). Current state: ", Broken_High);
			GKILCDHJFEG().SetFloat("SpawnObj", Broken_Big);
			PDEAHJPOMEF().SetTexture("ItemsCountText", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LNLKMDPHDCC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void IKIDIJLIGOH()
	{
	}

	private void PLIKADJCEPO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 718f)
			{
				HBJJOCHGOPH = 539f;
			}
			PDEAHJPOMEF().SetFloat("ScreenResolutionPanel", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("LevelInfoInputField", LightReflect);
			KBOPGONOCNP().SetFloat("_TimeX", Broken_Small);
			GKILCDHJFEG().SetFloat("_TimeX", Broken_Medium);
			OIMMPLPBLBK().SetFloat("SupportLogger OnDisconnectedFromPhoton().", Broken_High);
			NBPKMLMCHFN.SetFloat("x", Broken_Big);
			PGPEMMBJOOG().SetTexture("id", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material OIMMPLPBLBK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void Start()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_TV_BrokenGlass1") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/TV_BrokenGlass");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FHPFJBFCOOF()
	{
		FPHEBLMINDA = Resources.Load("_Far") as Texture2D;
		SCShader = Shader.Find(":");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NJHJHBOJKIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1369f)
			{
				HBJJOCHGOPH = 668f;
			}
			KEMAALEODNH().SetFloat("CameraFilterPack/TV_Tiles", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat(".b", LightReflect);
			KEMAALEODNH().SetFloat(".lastCheckpoint.bgcolor", Broken_Small);
			NBPKMLMCHFN.SetFloat("_Value2", Broken_Medium);
			OIMMPLPBLBK().SetFloat("cancel", Broken_High);
			GKILCDHJFEG().SetFloat("<b>(╯°□°）╯︵ ┻━┻</b>", Broken_Big);
			NBPKMLMCHFN.SetTexture("input", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KCDOMIJBFLL()
	{
	}

	private void ALMGMOOHLMA()
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
			if (HBJJOCHGOPH > 716f)
			{
				HBJJOCHGOPH = 585f;
			}
			OIMMPLPBLBK().SetFloat("offsets", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("Show image from resources by id at the center of the screen at foreground or background", LightReflect);
			KEMAALEODNH().SetFloat("z", Broken_Small);
			GKILCDHJFEG().SetFloat("CameraFilterPack/Blend2Camera_SoftLight", Broken_Medium);
			PDEAHJPOMEF().SetFloat("distance", Broken_High);
			PDEAHJPOMEF().SetFloat("keep aspect ratio", Broken_Big);
			LNLKMDPHDCC().SetTexture("selector", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FKEJGBFDCAH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material GKILCDHJFEG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void NDAJBJFJGCF()
	{
	}

	private void DIPDEHOOBPG()
	{
		FPHEBLMINDA = Resources.Load("RPC: 'OnAwakeRPC' Parameter: ") as Texture2D;
		SCShader = Shader.Find("Reset");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
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
			NBPKMLMCHFN.SetFloat("_Value", LightReflect);
			NBPKMLMCHFN.SetFloat("_Value2", Broken_Small);
			NBPKMLMCHFN.SetFloat("_Value3", Broken_Medium);
			NBPKMLMCHFN.SetFloat("_Value4", Broken_High);
			NBPKMLMCHFN.SetFloat("_Value5", Broken_Big);
			NBPKMLMCHFN.SetTexture("_MainTex2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FANADGBGCPI()
	{
		FPHEBLMINDA = Resources.Load("[ImageLoader] Loaded image from ") as Texture2D;
		SCShader = Shader.Find("#tryagain");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1381f)
			{
				HBJJOCHGOPH = 1978f;
			}
			OIMMPLPBLBK().SetFloat("float,0", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("float,0", LightReflect);
			KBOPGONOCNP().SetFloat("_Far", Broken_Small);
			PGPEMMBJOOG().SetFloat("#alreadystarted", Broken_Medium);
			OIMMPLPBLBK().SetFloat("]", Broken_High);
			OIMMPLPBLBK().SetFloat("_Red_R", Broken_Big);
			PGPEMMBJOOG().SetTexture("sounds/no_hit", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HFBJAOFLCJI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-118);
		}
		return BJFKDHHMLJH;
	}

	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1779f)
			{
				HBJJOCHGOPH = 883f;
			}
			NBPKMLMCHFN.SetFloat("_MainTex2", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat("CrosshairOpacitySlider", LightReflect);
			OIMMPLPBLBK().SetFloat("Messages (shift+tab)", Broken_Small);
			OIMMPLPBLBK().SetFloat("_Value4", Broken_Medium);
			PDEAHJPOMEF().SetFloat("_Value3", Broken_High);
			KBOPGONOCNP().SetFloat("EventConfigButton", Broken_Big);
			KEMAALEODNH().SetTexture("\"", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MGMAOBPPOBJ()
	{
		FPHEBLMINDA = Resources.Load("int") as Texture2D;
		SCShader = Shader.Find("_Visualize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KCCIEMBMOBA()
	{
		FPHEBLMINDA = Resources.Load("/") as Texture2D;
		SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JBNPEHMDCMI()
	{
	}

	private void KDMANOEMOCA()
	{
		FPHEBLMINDA = Resources.Load("[LevelEditorScene] Print Audio Wave: Start") as Texture2D;
		SCShader = Shader.Find("Up ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MFMIODIAKNI()
	{
	}

	private void CCPEDDLAMIB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1855f)
			{
				HBJJOCHGOPH = 739f;
			}
			NBPKMLMCHFN.SetFloat("From {0} at Index {1} \n", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat(".played", LightReflect);
			PGPEMMBJOOG().SetFloat("_PrevViewProj", Broken_Small);
			NBPKMLMCHFN.SetFloat("float,1", Broken_Medium);
			GKILCDHJFEG().SetFloat("<color=#", Broken_High);
			KBOPGONOCNP().SetFloat("_TimeX", Broken_Big);
			HFBJAOFLCJI().SetTexture("Tab2Content", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BMOFEBKGLFI()
	{
		FPHEBLMINDA = Resources.Load("_HrDepthTex") as Texture2D;
		SCShader = Shader.Find("shader.frost");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LOMDIOLNFHI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FJHFOBHJEHL()
	{
	}

	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 258f)
			{
				HBJJOCHGOPH = 25f;
			}
			NBPKMLMCHFN.SetFloat("CameraFilterPack_TV_Arcade1", HBJJOCHGOPH);
			PGPEMMBJOOG().SetFloat("_ProjectToPixelMatrix", LightReflect);
			HFBJAOFLCJI().SetFloat("maps.", Broken_Small);
			PDEAHJPOMEF().SetFloat("Messages (shift+tab)", Broken_Medium);
			PGPEMMBJOOG().SetFloat("Set Player Distance", Broken_High);
			PDEAHJPOMEF().SetFloat("_TimeX", Broken_Big);
			HFBJAOFLCJI().SetTexture("#mapby", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BGDPIHMAACO()
	{
		FPHEBLMINDA = Resources.Load("menutheme.deleted") as Texture2D;
		SCShader = Shader.Find("workshop.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material KEMAALEODNH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void FGOPJMGNHGO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material OGMEGHKECAH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
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

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1246f)
			{
				HBJJOCHGOPH = 1546f;
			}
			LNLKMDPHDCC().SetFloat("JoinRoom failed. A roomname is required. If you don't know one, how will you join?", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("1", LightReflect);
			PGPEMMBJOOG().SetFloat(" (inactive)", Broken_Small);
			GKILCDHJFEG().SetFloat("Preparing configuration...", Broken_Medium);
			PGPEMMBJOOG().SetFloat("threshold", Broken_High);
			OGMEGHKECAH().SetFloat("_ScreenResolution", Broken_Big);
			NBPKMLMCHFN.SetTexture("[PlayerController] ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HPNNCNNFMGK()
	{
	}

	private void MAOCOEGAFND()
	{
	}

	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 545f)
			{
				HBJJOCHGOPH = 415f;
			}
			OIMMPLPBLBK().SetFloat(".completedMaps", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("_TimeX", LightReflect);
			LNLKMDPHDCC().SetFloat("mapselector.filter.rateduponly", Broken_Small);
			PDEAHJPOMEF().SetFloat("d264dbba9c2410771b4ad918903b3f4cd9e276a9", Broken_Medium);
			PDEAHJPOMEF().SetFloat("No connection to item server!", Broken_High);
			LNLKMDPHDCC().SetFloat("CameraFilterPack/Color_GrayScale", Broken_Big);
			PGPEMMBJOOG().SetTexture("Finished", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ODGMCJILIHF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1001f)
			{
				HBJJOCHGOPH = 805f;
			}
			GKILCDHJFEG().SetFloat("_Value", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("LoadMapCanvas", LightReflect);
			NBPKMLMCHFN.SetFloat("': ", Broken_Small);
			HFBJAOFLCJI().SetFloat("EnvironmentSlider", Broken_Medium);
			NBPKMLMCHFN.SetFloat("SetSatelliteTrailMinVertexDistance", Broken_High);
			HFBJAOFLCJI().SetFloat(":", Broken_Big);
			PDEAHJPOMEF().SetTexture("_Value", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IMGGCJICLHK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OBAEDJJDCPN()
	{
	}

	private void GJLKJAOBPJD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1173f)
			{
				HBJJOCHGOPH = 1183f;
			}
			NBPKMLMCHFN.SetFloat(") but there is no recycle bin setup for it", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("CameraFilterPack_Paper2", LightReflect);
			GKILCDHJFEG().SetFloat("_DistanceParams", Broken_Small);
			OGMEGHKECAH().SetFloat("HightScoreMaxPointsText", Broken_Medium);
			OIMMPLPBLBK().SetFloat("MainButton", Broken_High);
			KBOPGONOCNP().SetFloat("#ok", Broken_Big);
			KBOPGONOCNP().SetTexture("_ScreenResolution", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 658f)
			{
				HBJJOCHGOPH = 124f;
			}
			LNLKMDPHDCC().SetFloat("Nov", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Currently, the limit of users is reached for this title. Try again later. Disconnecting", LightReflect);
			OGMEGHKECAH().SetFloat("_SecondTex", Broken_Small);
			OIMMPLPBLBK().SetFloat("colorC", Broken_Medium);
			KEMAALEODNH().SetFloat("_Threshhold", Broken_High);
			PDEAHJPOMEF().SetFloat("Move environment object to the position", Broken_Big);
			NBPKMLMCHFN.SetTexture("id", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JHANGPCOCIG()
	{
		FPHEBLMINDA = Resources.Load("Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. ") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/3D_Mirror");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material PGPEMMBJOOG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-118);
		}
		return BJFKDHHMLJH;
	}

	private void LCHBFNIPBHB()
	{
	}

	private void GKNKIIEALCH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AEIJFLJEABG()
	{
	}

	private void PAKPHKPDKGE()
	{
		FPHEBLMINDA = Resources.Load("a year ago") as Texture2D;
		SCShader = Shader.Find("float,10");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OFIMMFHFHDD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Update()
	{
	}

	private void JAAJECBCCFM()
	{
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return BJFKDHHMLJH;
	}

	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 618f)
			{
				HBJJOCHGOPH = 1935f;
			}
			HFBJAOFLCJI().SetFloat("_Value2", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("Items", LightReflect);
			KEMAALEODNH().SetFloat("Noise shaders are not set up! Disabling noise effect.", Broken_Small);
			HFBJAOFLCJI().SetFloat("event", Broken_Medium);
			OIMMPLPBLBK().SetFloat("_Value3", Broken_High);
			NBPKMLMCHFN.SetFloat("Solo", Broken_Big);
			PDEAHJPOMEF().SetTexture("RecordButton", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HONBLGFDMLL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}
}
