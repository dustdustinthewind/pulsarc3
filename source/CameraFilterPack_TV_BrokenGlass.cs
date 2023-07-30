// CameraFilterPack_TV_BrokenGlass
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/TV/Broken Glass")]
[ExecuteInEditMode]
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
			PGPEMMBJOOG().SetFloat("SpawnObj", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("CameraFilterPack_TV_Noise3", LightReflect);
			NBPKMLMCHFN.SetFloat("End index must in an integer.", Broken_Small);
			HFBJAOFLCJI().SetFloat("LB", Broken_Medium);
			OGMEGHKECAH().SetFloat("_MainTex2", Broken_High);
			KEMAALEODNH().SetFloat("/", Broken_Big);
			OIMMPLPBLBK().SetTexture("_Value", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KDMKDEKCELE()
	{
		FPHEBLMINDA = Resources.Load("_Distance") as Texture2D;
		SCShader = Shader.Find("Tab2Content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JILOMOBDPIA()
	{
		FPHEBLMINDA = Resources.Load("Connection error: ") as Texture2D;
		SCShader = Shader.Find("id");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DKOPKPBLDHH()
	{
		FPHEBLMINDA = Resources.Load("_ScreenResolution") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Edge_Neon");
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
			LNLKMDPHDCC().SetFloat("settings.arcshitsoundtimedelay", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("RestartButton", LightReflect);
			PGPEMMBJOOG().SetFloat("\0\0", Broken_Small);
			KBOPGONOCNP().SetFloat("EditMenu", Broken_Medium);
			HFBJAOFLCJI().SetFloat("ReconnectAndRejoin() with AuthValues == null is not correct!", Broken_High);
			OIMMPLPBLBK().SetFloat("SpawnObj", Broken_Big);
			KEMAALEODNH().SetTexture("ItemsCountText", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
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
			PDEAHJPOMEF().SetFloat("SettingsCanvas", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat("LevelURLInputField", LightReflect);
			GKILCDHJFEG().SetFloat("CameraFilterPack/Distortion_Dissipation", Broken_Small);
			PGPEMMBJOOG().SetFloat("CameraFilterPack/NightVision_4", Broken_Medium);
			KEMAALEODNH().SetFloat("). ", Broken_High);
			OGMEGHKECAH().SetFloat("x", Broken_Big);
			KEMAALEODNH().SetTexture("id", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
		SCShader = Shader.Find("settings.enablehitsoundsinrelax");
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
			LNLKMDPHDCC().SetFloat("_Distortion", HBJJOCHGOPH);
			PGPEMMBJOOG().SetFloat(".b", LightReflect);
			NBPKMLMCHFN.SetFloat(".lastCheckpoint.playerdistance", Broken_Small);
			KBOPGONOCNP().SetFloat("_Value", Broken_Medium);
			OIMMPLPBLBK().SetFloat("cancel", Broken_High);
			NBPKMLMCHFN.SetFloat("<b>(╯°□°）╯︵ ┻━┻</b>", Broken_Big);
			OIMMPLPBLBK().SetTexture("Object ID. Case-Sensitive", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
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
			HFBJAOFLCJI().SetFloat("_TapLowForeground", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("Show image from resources by id at the center of the screen at foreground or background", LightReflect);
			OIMMPLPBLBK().SetFloat("x", Broken_Small);
			HFBJAOFLCJI().SetFloat("CameraFilterPack/Blend2Camera_SoftLight", Broken_Medium);
			LNLKMDPHDCC().SetFloat("distance", Broken_High);
			PDEAHJPOMEF().SetFloat("keep aspect ratio", Broken_Big);
			KBOPGONOCNP().SetTexture("source", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
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
		FPHEBLMINDA = Resources.Load("OnAwakeRPC") as Texture2D;
		SCShader = Shader.Find("{0}sec average:");
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
		FPHEBLMINDA = Resources.Load("[FileSelector] Dialog canceled") as Texture2D;
		SCShader = Shader.Find("MenuScene");
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
			KBOPGONOCNP().SetFloat("float,0", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat("float,0", LightReflect);
			NBPKMLMCHFN.SetFloat("_Far", Broken_Small);
			KBOPGONOCNP().SetFloat("JoinButton", Broken_Medium);
			OIMMPLPBLBK().SetFloat("settings.hitvariation", Broken_High);
			OIMMPLPBLBK().SetFloat("_TimeX", Broken_Big);
			NBPKMLMCHFN.SetTexture("Loaded skin audio", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
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
			LNLKMDPHDCC().SetFloat("CameraFilterPack/Blend2Camera_SplitScreen3D", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("settings.cameramovements", LightReflect);
			PDEAHJPOMEF().SetFloat("(master)", Broken_Small);
			GKILCDHJFEG().SetFloat("_Value2", Broken_Medium);
			OGMEGHKECAH().SetFloat("_Value3", Broken_High);
			OGMEGHKECAH().SetFloat("TimeBGSlider", Broken_Big);
			PDEAHJPOMEF().SetTexture("]", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MGMAOBPPOBJ()
	{
		FPHEBLMINDA = Resources.Load("bool") as Texture2D;
		SCShader = Shader.Find("_Visualize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KCCIEMBMOBA()
	{
		FPHEBLMINDA = Resources.Load("MapperNameText") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Blend2Camera_ColorKey");
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
		FPHEBLMINDA = Resources.Load("player.licenceaccepted") as Texture2D;
		SCShader = Shader.Find("Up");
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
			GKILCDHJFEG().SetFloat("Source Object: ", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat(".highscore", LightReflect);
			GKILCDHJFEG().SetFloat("_Parameter", Broken_Small);
			OIMMPLPBLBK().SetFloat("x", Broken_Medium);
			PDEAHJPOMEF().SetFloat("</color>", Broken_High);
			KEMAALEODNH().SetFloat("CameraFilterPack/Drawing_Paper2", Broken_Big);
			PGPEMMBJOOG().SetTexture("Tab2Content", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BMOFEBKGLFI()
	{
		FPHEBLMINDA = Resources.Load("offsets") as Texture2D;
		SCShader = Shader.Find("shader.crispwinter");
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
			HFBJAOFLCJI().SetFloat("Fade", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("_ProjInfo", LightReflect);
			PDEAHJPOMEF().SetFloat("maps.", Broken_Small);
			HFBJAOFLCJI().SetFloat("#{0:00} '{1}'{2} {3}", Broken_Medium);
			OGMEGHKECAH().SetFloat("Set Player Distance", Broken_High);
			GKILCDHJFEG().SetFloat("CameraFilterPack/3D_Shield", Broken_Big);
			LNLKMDPHDCC().SetTexture("settings.selectormapsperpage", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BGDPIHMAACO()
	{
		FPHEBLMINDA = Resources.Load("menutheme.jamaicanorcdub") as Texture2D;
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
			PGPEMMBJOOG().SetFloat("CreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("Dec", LightReflect);
			GKILCDHJFEG().SetFloat(" ", Broken_Small);
			PDEAHJPOMEF().SetFloat("There was an error retrieving the NumberOfCurrentPlayers.", Broken_Medium);
			NBPKMLMCHFN.SetFloat("colorD", Broken_High);
			HFBJAOFLCJI().SetFloat("_Value4", Broken_Big);
			KBOPGONOCNP().SetTexture(" not exist", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
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
			PGPEMMBJOOG().SetFloat("true", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("CameraFilterPack/Blur_Noise", LightReflect);
			GKILCDHJFEG().SetFloat("mapselector.filter.favoriteonly", Broken_Small);
			GKILCDHJFEG().SetFloat("88f00bdf0ad61b16b803971ebe071962", Broken_Medium);
			OIMMPLPBLBK().SetFloat("Image", Broken_High);
			OGMEGHKECAH().SetFloat("CameraFilterPack/Color_GrayScale", Broken_Big);
			KBOPGONOCNP().SetTexture("Finished", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
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
			LNLKMDPHDCC().SetFloat("_TimeX", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("LoadMapCanvas", LightReflect);
			PDEAHJPOMEF().SetFloat("masterVolume", Broken_Small);
			OGMEGHKECAH().SetFloat("Tab2Content", Broken_Medium);
			GKILCDHJFEG().SetFloat("SetSatelliteLerpSpeed", Broken_High);
			PDEAHJPOMEF().SetFloat("End index must in an integer.", Broken_Big);
			NBPKMLMCHFN.SetTexture("_TimeX", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
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
			OGMEGHKECAH().SetFloat("attempted to spawn a GameObject from recycle bin (", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("CameraFilterPack_Paper2", LightReflect);
			KEMAALEODNH().SetFloat("_CameraWS", Broken_Small);
			KBOPGONOCNP().SetFloat("HightScoreMaxPointsText", Broken_Medium);
			HFBJAOFLCJI().SetFloat(" ", Broken_High);
			HFBJAOFLCJI().SetFloat("#forever", Broken_Big);
			NBPKMLMCHFN.SetTexture("_ScreenResolution", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
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
			PGPEMMBJOOG().SetFloat("Sep", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.", LightReflect);
			NBPKMLMCHFN.SetFloat("_BlurCoe", Broken_Small);
			PGPEMMBJOOG().SetFloat("colorA", Broken_Medium);
			KBOPGONOCNP().SetFloat("_Offsets", Broken_High);
			PDEAHJPOMEF().SetFloat("float,0", Broken_Big);
			LNLKMDPHDCC().SetTexture("id", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JHANGPCOCIG()
	{
		FPHEBLMINDA = Resources.Load("Warning, using scrollbors with the Scroll Snap controls is not advised as it causes unpredictable results") as Texture2D;
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
		SCShader = Shader.Find("Lerp speed. Recomended 10");
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
			OGMEGHKECAH().SetFloat("_Value2", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat("Scrollbar", LightReflect);
			KBOPGONOCNP().SetFloat("_NoiseTex", Broken_Small);
			KBOPGONOCNP().SetFloat("BitsData", Broken_Medium);
			NBPKMLMCHFN.SetFloat("_Value2", Broken_High);
			OIMMPLPBLBK().SetFloat("Playing ", Broken_Big);
			OIMMPLPBLBK().SetTexture("STOP [R]", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
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
