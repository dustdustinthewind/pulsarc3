// CameraFilterPack_Pixelisation_Sweater
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Pixelisation/Pixelisation_Sweater")]
[ExecuteInEditMode]
public class CameraFilterPack_Pixelisation_Sweater : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(16f, 128f)]
	public float SweaterSize = 64f;

	[Range(0f, 2f)]
	public float _Intensity = 1.4f;

	[Range(0f, 1f)]
	public float Fade = 1f;

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

	private void FDMAEPOHDMK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LCJHDLKJEOM()
	{
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JONGNKNLLND()
	{
		FPHEBLMINDA = Resources.Load("SettingsCanvas") as Texture2D;
		SCShader = Shader.Find("Unknown player asked for PickupItems");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FIKFJDFELIP()
	{
		FPHEBLMINDA = Resources.Load("_Value3") as Texture2D;
		SCShader = Shader.Find("FinalScoreText");
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
			if (HBJJOCHGOPH > 1350f)
			{
				HBJJOCHGOPH = 1610f;
			}
			KAFBNOBOIAJ().SetFloat(".png", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("inventory.lastitemscount", Fade);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", SweaterSize);
			OIMMPLPBLBK().SetFloat("time", _Intensity);
			OIMMPLPBLBK().SetTexture("Left", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MMBPLGGLPDB()
	{
	}

	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1395f)
			{
				HBJJOCHGOPH = 1445f;
			}
			GCDFNHMJMIP().SetFloat(". The group number should be at least 1.", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("challenges.", Fade);
			LPDOGGFOBDH().SetFloat("22x3", SweaterSize);
			NBPKMLMCHFN.SetFloat("_Value2", _Intensity);
			LPDOGGFOBDH().SetTexture("CameraFilterPack/Drawing_Laplacian", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CFIAKIJAILI()
	{
	}

	private void GBGAMCPNBCC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MJEFMIPLFAB()
	{
		FPHEBLMINDA = Resources.Load("x") as Texture2D;
		SCShader = Shader.Find("Bad parameters for reset! Use \"reset <challengeid>\"");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JNGMIAFLBDL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 709f)
			{
				HBJJOCHGOPH = 889f;
			}
			DBOLLHHMKKN().SetFloat("_TapMedium", HBJJOCHGOPH);
			FLOHGDECHHH().SetFloat("_Intensity", Fade);
			BFGNMFCNDBC().SetFloat(".lastCheckpoint.powerupsScore", SweaterSize);
			LPDOGGFOBDH().SetFloat("elapsed: {0:0.000}", _Intensity);
			LONNIJMNKFB().SetTexture("Received RPC: ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGIAPKPKGPK());
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void NNFMIAFHMJM()
	{
		FPHEBLMINDA = Resources.Load("_Value2") as Texture2D;
		SCShader = Shader.Find("_BlurCoe");
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

	[SpecialName]
	private Material FLOHGDECHHH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-86);
		}
		return BJFKDHHMLJH;
	}

	private void CHOPDIGHJNH()
	{
		FPHEBLMINDA = Resources.Load("[Up]") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Blur_Noise");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1283f)
			{
				HBJJOCHGOPH = 117f;
			}
			LPDOGGFOBDH().SetFloat("Room: '{0}' {1},{2} {4}/{3} players.", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("CameraFilterPack_Paper3", Fade);
			EMDFHOKEGNG().SetFloat("LastHighScoreText", SweaterSize);
			DBOLLHHMKKN().SetFloat(":</b> ", _Intensity);
			NBPKMLMCHFN.SetTexture("_Value", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IABLKKAALGI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FBPHNEJBDJN()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack/3D_Myst") as Texture2D;
		SCShader = Shader.Find("Scrollbar");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JKFDDNMPOJH()
	{
		FPHEBLMINDA = Resources.Load("settings.disablestoryboard") as Texture2D;
		SCShader = Shader.Find("Sent count: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 647f)
			{
				HBJJOCHGOPH = 1681f;
			}
			OIMMPLPBLBK().SetFloat("Set Particles Color", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("_Bullet_5", Fade);
			NFMGLIKNOOC().SetFloat("ItemNameText", SweaterSize);
			EMDFHOKEGNG().SetFloat("TwoHands", _Intensity);
			BFGNMFCNDBC().SetTexture("OK", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LMADKINICIN()
	{
	}

	private void JHANGPCOCIG()
	{
		FPHEBLMINDA = Resources.Load("steamid") as Texture2D;
		SCShader = Shader.Find("sounds/hit_wrong");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material DBOLLHHMKKN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return BJFKDHHMLJH;
	}

	private void DLMPALHKMON()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material EMDFHOKEGNG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void ODGMCJILIHF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MECJHOJPODB()
	{
	}

	private void GJAJBMGGPFB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1113f)
			{
				HBJJOCHGOPH = 911f;
			}
			OIMMPLPBLBK().SetFloat("_TimeX", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("menu.playedsolo", Fade);
			NFMGLIKNOOC().SetFloat("workshop.", SweaterSize);
			LONNIJMNKFB().SetFloat("Creating new item...", _Intensity);
			NBPKMLMCHFN.SetTexture("No Dispatcher exists in the scene. Actions will not be invoked!", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DHNGNHGDPLM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material LPDOGGFOBDH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-94);
		}
		return BJFKDHHMLJH;
	}

	private void AGMJDGHLBMN()
	{
	}

	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 192f)
			{
				HBJJOCHGOPH = 622f;
			}
			LONNIJMNKFB().SetFloat("Sending RPC \"", HBJJOCHGOPH);
			FLOHGDECHHH().SetFloat("NO", Fade);
			EOCCJGIGEGJ().SetFloat("</color>", SweaterSize);
			OIMMPLPBLBK().SetFloat("OpJoinRandomRoom()", _Intensity);
			NFKFAAHHLLM().SetTexture("[MapsData] Bad map: ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
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
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void CMIBEOJGAIL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1512f)
			{
				HBJJOCHGOPH = 182f;
			}
			DBOLLHHMKKN().SetFloat("_Value", HBJJOCHGOPH);
			GCDFNHMJMIP().SetFloat("_Bullet_3", Fade);
			KAFBNOBOIAJ().SetFloat("_Bullet_8", SweaterSize);
			NBPKMLMCHFN.SetFloat("/icon", _Intensity);
			KAFBNOBOIAJ().SetTexture("_TimeX", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EJFJENFKLND()
	{
	}

	private void NPLCENPNJBM()
	{
		FPHEBLMINDA = Resources.Load("UseScanLineSize") as Texture2D;
		SCShader = Shader.Find("#failed!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material KAFBNOBOIAJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-120);
		}
		return BJFKDHHMLJH;
	}

	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1828f)
			{
				HBJJOCHGOPH = 1218f;
			}
			NFKFAAHHLLM().SetFloat("GlassAberration", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("_Distortion", Fade);
			KAFBNOBOIAJ().SetFloat("GlassAberration", SweaterSize);
			BFGNMFCNDBC().SetFloat("settings.selectormapsperpage", _Intensity);
			OIMMPLPBLBK().SetTexture("y", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material BFGNMFCNDBC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 812f)
			{
				HBJJOCHGOPH = 894f;
			}
			EMDFHOKEGNG().SetFloat("/../", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("_Value4", Fade);
			NBPKMLMCHFN.SetFloat("cmd.exe", SweaterSize);
			OIMMPLPBLBK().SetFloat("_MainTex", _Intensity);
			EMDFHOKEGNG().SetTexture("GameScene", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	private void CCPEDDLAMIB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BJOHDLNDFAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OFPPIKHNJOD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FOMNCPKKCFN()
	{
	}

	private void Start()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_Sweater") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Pixelisation_Sweater");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FJNCHGLIEMA()
	{
		FPHEBLMINDA = Resources.Load("AccuracyScoreText") as Texture2D;
		SCShader = Shader.Find("Case-Sensitive");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FLKEJJEGCFA()
	{
		FPHEBLMINDA = Resources.Load("#getrewardnow ") as Texture2D;
		SCShader = Shader.Find("Up ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 470f)
			{
				HBJJOCHGOPH = 1868f;
			}
			CEKJODEAMGB().SetFloat("action", HBJJOCHGOPH);
			CEKJODEAMGB().SetFloat("_Blue_G", Fade);
			FLOHGDECHHH().SetFloat("{0}", SweaterSize);
			GCDFNHMJMIP().SetFloat("stats on", _Intensity);
			FLOHGDECHHH().SetTexture("#yes", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GCHBGCGBMCK()
	{
	}

	private void AEIJFLJEABG()
	{
	}

	private void CPAJLKHMOJB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DLBODOFAJGM()
	{
		FPHEBLMINDA = Resources.Load("HighScaleShot") as Texture2D;
		SCShader = Shader.Find("action");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PMPKMGKAAJH()
	{
		FPHEBLMINDA = Resources.Load("_Glitch") as Texture2D;
		SCShader = Shader.Find("float,1.5");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1610f)
			{
				HBJJOCHGOPH = 200f;
			}
			FLOHGDECHHH().SetFloat("<b>", HBJJOCHGOPH);
			IGIAPKPKGPK().SetFloat(". Check if the server is available.", Fade);
			LPDOGGFOBDH().SetFloat("HightScoreMaxPointsText", SweaterSize);
			OIMMPLPBLBK().SetFloat("Set camera (or player) distance. Base player distance - 14", _Intensity);
			NFMGLIKNOOC().SetTexture("Fade", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material NFKFAAHHLLM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material GCDFNHMJMIP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)67;
		}
		return BJFKDHHMLJH;
	}

	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1037f)
			{
				HBJJOCHGOPH = 1276f;
			}
			EMDFHOKEGNG().SetFloat("_VignettingColor", HBJJOCHGOPH);
			NFKFAAHHLLM().SetFloat("workshop.", Fade);
			DBOLLHHMKKN().SetFloat("Chat", SweaterSize);
			KAFBNOBOIAJ().SetFloat("\" for viewID ", _Intensity);
			EOCCJGIGEGJ().SetTexture("CameraFilterPack/Real_VHS", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JNBPKNNBMDI()
	{
	}

	private void HLIAEEMGBHN()
	{
		FPHEBLMINDA = Resources.Load("[LevelEditorScene] Print Audio Wave: Done") as Texture2D;
		SCShader = Shader.Find("rd");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OBAEDJJDCPN()
	{
	}

	private void ANCKKLFPGDI()
	{
		FPHEBLMINDA = Resources.Load("\n") as Texture2D;
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 797f)
			{
				HBJJOCHGOPH = 753f;
			}
			GCDFNHMJMIP().SetFloat("CameraFilterPack/Glasses_On", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("Down", Fade);
			OIMMPLPBLBK().SetFloat("Texture2", SweaterSize);
			KAFBNOBOIAJ().SetFloat("Value", _Intensity);
			BFGNMFCNDBC().SetTexture("_Skybox", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FPHLDMMAOEF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material CEKJODEAMGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void DKOPKPBLDHH()
	{
		FPHEBLMINDA = Resources.Load(" - ") as Texture2D;
		SCShader = Shader.Find("RanksButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material EOCCJGIGEGJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	private void ILCFPCIPENO()
	{
		FPHEBLMINDA = Resources.Load("_SSRMultiplier") as Texture2D;
		SCShader = Shader.Find("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 44f)
			{
				HBJJOCHGOPH = 665f;
			}
			EOCCJGIGEGJ().SetFloat("_Value", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("SupportLogger OnJoinedRoom(", Fade);
			NFMGLIKNOOC().SetFloat("Value", SweaterSize);
			NFMGLIKNOOC().SetFloat("Can not SetMasterClient(). Not in room or in offlineMode.", _Intensity);
			KAFBNOBOIAJ().SetTexture("InventoryButton", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KMKLDAJLCNM()
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
			NBPKMLMCHFN.SetFloat("_Fade", Fade);
			NBPKMLMCHFN.SetFloat("_SweaterSize", SweaterSize);
			NBPKMLMCHFN.SetFloat("_Intensity", _Intensity);
			NBPKMLMCHFN.SetTexture("Texture2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material NFMGLIKNOOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void JMEOGJHCONJ()
	{
		FPHEBLMINDA = Resources.Load("inventory.selected.") as Texture2D;
		SCShader = Shader.Find("[MapsData] Base maps loaded");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JILOMOBDPIA()
	{
		FPHEBLMINDA = Resources.Load("No info") as Texture2D;
		SCShader = Shader.Find("_Value5");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material LONNIJMNKFB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-104);
		}
		return BJFKDHHMLJH;
	}

	private void ODBNMPGBCGO()
	{
		FPHEBLMINDA = Resources.Load("DisableStoryboardToggle") as Texture2D;
		SCShader = Shader.Find("mapselector.filter.favoriteonly");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NJHJHBOJKIC()
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
			if (HBJJOCHGOPH > 1546f)
			{
				HBJJOCHGOPH = 269f;
			}
			DBOLLHHMKKN().SetFloat(".icon", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_History3LumaTex", Fade);
			NFKFAAHHLLM().SetFloat("SetSunMaxSize", SweaterSize);
			BFGNMFCNDBC().SetFloat("menu.playedsolo", _Intensity);
			NFMGLIKNOOC().SetTexture(">", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
