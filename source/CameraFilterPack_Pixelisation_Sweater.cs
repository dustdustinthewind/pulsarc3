// CameraFilterPack_Pixelisation_Sweater
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Pixelisation/Pixelisation_Sweater")]
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
		FPHEBLMINDA = Resources.Load(" x ") as Texture2D;
		SCShader = Shader.Find("Cant ask anyone else for PickupItem spawn times.");
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
			EMDFHOKEGNG().SetFloat(".jpg", HBJJOCHGOPH);
			CEKJODEAMGB().SetFloat("LoadingStatusText", Fade);
			BFGNMFCNDBC().SetFloat("_ScreenResolution", SweaterSize);
			BFGNMFCNDBC().SetFloat("https://api.steampowered.com/IInventoryService/AddItem/v001", _Intensity);
			NBPKMLMCHFN.SetTexture("Right", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGIAPKPKGPK());
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
			GCDFNHMJMIP().SetFloat("Unsupported target enum: ", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("challenges.", Fade);
			EMDFHOKEGNG().SetFloat("3;4;9;10;21x6", SweaterSize);
			BFGNMFCNDBC().SetFloat("_Value2", _Intensity);
			NBPKMLMCHFN.SetTexture("CameraFilterPack/Drawing_Laplacian", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGIAPKPKGPK());
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
		FPHEBLMINDA = Resources.Load("b") as Texture2D;
		SCShader = Shader.Find("resetall");
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
			CEKJODEAMGB().SetFloat("_TapLow", HBJJOCHGOPH);
			CEKJODEAMGB().SetFloat("_PrefilterOffs", Fade);
			FLOHGDECHHH().SetFloat(".lastCheckpoint.maxLongestCombo", SweaterSize);
			NFMGLIKNOOC().SetFloat("st", _Intensity);
			IGIAPKPKGPK().SetTexture(". The RPC has been ignored.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLOHGDECHHH());
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
		FPHEBLMINDA = Resources.Load("_Value") as Texture2D;
		SCShader = Shader.Find("_Offsets");
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
		FPHEBLMINDA = Resources.Load("Gameplay/satellite") as Texture2D;
		SCShader = Shader.Find("_ScreenResolution");
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
			DBOLLHHMKKN().SetFloat("open", HBJJOCHGOPH);
			LPDOGGFOBDH().SetFloat("_MainTex2", Fade);
			EMDFHOKEGNG().SetFloat("LastHighScoreText", SweaterSize);
			CEKJODEAMGB().SetFloat("[#clicktogetreward]", _Intensity);
			EMDFHOKEGNG().SetTexture("_Value", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
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
		SCShader = Shader.Find("Overlay");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JKFDDNMPOJH()
	{
		FPHEBLMINDA = Resources.Load("settings.disablestoryboard") as Texture2D;
		SCShader = Shader.Find(" timeUntilRespawn: ");
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
			KAFBNOBOIAJ().SetFloat("SetParticlesColor", HBJJOCHGOPH);
			CEKJODEAMGB().SetFloat("_Bullet_4", Fade);
			EOCCJGIGEGJ().SetFloat("ItemNameBGImage", SweaterSize);
			EOCCJGIGEGJ().SetFloat("OneHand", _Intensity);
			CEKJODEAMGB().SetTexture("OK", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
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
		FPHEBLMINDA = Resources.Load("ERROR") as Texture2D;
		SCShader = Shader.Find("skin.no_hit");
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
			NFMGLIKNOOC().SetFloat("CameraFilterPack/FX_superDot", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("menu.playedsolo", Fade);
			EOCCJGIGEGJ().SetFloat("workshop.", SweaterSize);
			CEKJODEAMGB().SetFloat("arcs", _Intensity);
			KAFBNOBOIAJ().SetTexture("No Dispatcher exists in the scene. Actions will not be invoked!", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
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
			EOCCJGIGEGJ().SetFloat(" method: ", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("ACCEPT", Fade);
			CEKJODEAMGB().SetFloat("</color>", SweaterSize);
			DBOLLHHMKKN().SetFloat("OpCreateRoom()", _Intensity);
			CEKJODEAMGB().SetTexture("[MapsData] Caching ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
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
			KAFBNOBOIAJ().SetFloat("_TimeX", HBJJOCHGOPH);
			NFKFAAHHLLM().SetFloat("_Bullet_1", Fade);
			NFKFAAHHLLM().SetFloat("_Bullet_7", SweaterSize);
			FLOHGDECHHH().SetFloat("/icon", _Intensity);
			KAFBNOBOIAJ().SetTexture("CameraFilterPack/Color_Sepia", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
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
		FPHEBLMINDA = Resources.Load("GlassColor") as Texture2D;
		SCShader = Shader.Find("Uploading preview image");
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
			EMDFHOKEGNG().SetFloat("GlassDistortion", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("_Distortion", Fade);
			EMDFHOKEGNG().SetFloat("GlassDistortion", SweaterSize);
			NBPKMLMCHFN.SetFloat("settings.enablehitsoundsinnormal", _Intensity);
			EMDFHOKEGNG().SetTexture("z", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
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
			NBPKMLMCHFN.SetFloat("/", HBJJOCHGOPH);
			CEKJODEAMGB().SetFloat("_Value2", Fade);
			DBOLLHHMKKN().SetFloat("cmd.exe", SweaterSize);
			NBPKMLMCHFN.SetFloat("_SecondTex", _Intensity);
			LPDOGGFOBDH().SetTexture("GameScene", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
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
		SCShader = Shader.Find("set environment id");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FLKEJJEGCFA()
	{
		FPHEBLMINDA = Resources.Load("#timeuntilend: ") as Texture2D;
		SCShader = Shader.Find("Up");
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
			EMDFHOKEGNG().SetFloat("settings.volume.menu", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Blue_R", Fade);
			BFGNMFCNDBC().SetFloat("false", SweaterSize);
			DBOLLHHMKKN().SetFloat("Out {0,4} | In {1,4} | Sum {2,4}", _Intensity);
			KAFBNOBOIAJ().SetTexture("#useticket", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
		FPHEBLMINDA = Resources.Load(").png") as Texture2D;
		SCShader = Shader.Find("settings.volume.menu");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PMPKMGKAAJH()
	{
		FPHEBLMINDA = Resources.Load("_TimeX") as Texture2D;
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
			OIMMPLPBLBK().SetFloat("Loading...", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("The server address is 127.0.0.1 (localhost): Make sure the server is running on this machine. Android and iOS emulators have their own localhost.", Fade);
			LONNIJMNKFB().SetFloat("HightScoreMaxPointsText", SweaterSize);
			EMDFHOKEGNG().SetFloat("Set camera (or player) distance. Base player distance - 14", _Intensity);
			GCDFNHMJMIP().SetTexture("_Value", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
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
			KAFBNOBOIAJ().SetFloat("_Vignetting", HBJJOCHGOPH);
			CEKJODEAMGB().SetFloat("workshop.", Fade);
			GCDFNHMJMIP().SetFloat("OnPress", SweaterSize);
			OIMMPLPBLBK().SetFloat("Could not find RPC with index: ", _Intensity);
			FLOHGDECHHH().SetTexture("Texture2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
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
		FPHEBLMINDA = Resources.Load("[LevelEditorScene] Print Audio Wave: Start") as Texture2D;
		SCShader = Shader.Find("3");
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
		FPHEBLMINDA = Resources.Load("Is Clone ?: ") as Texture2D;
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
			FLOHGDECHHH().SetFloat("CameraFilterPack_Glasses_On5", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("Up ", Fade);
			EMDFHOKEGNG().SetFloat("Texture2", SweaterSize);
			EOCCJGIGEGJ().SetFloat("_TimeX", _Intensity);
			NFKFAAHHLLM().SetTexture("_SunPosition", FPHEBLMINDA);
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
		FPHEBLMINDA = Resources.Load("Reading preview file failed!: \"{0}\"") as Texture2D;
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
		FPHEBLMINDA = Resources.Load("_FadeDistance") as Texture2D;
		SCShader = Shader.Find("Items");
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
			IGIAPKPKGPK().SetFloat("_Value", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("SupportLogger OnJoinedLobby(", Fade);
			NFMGLIKNOOC().SetFloat("ScreenResolutionPanel", SweaterSize);
			IGIAPKPKGPK().SetFloat(". No ViewIDs are free to use. Max is: ", _Intensity);
			CEKJODEAMGB().SetTexture("InventoryButton", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
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
		FPHEBLMINDA = Resources.Load("shader.invert") as Texture2D;
		SCShader = Shader.Find("[MapsData] Workshop maps was loaded");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JILOMOBDPIA()
	{
		FPHEBLMINDA = Resources.Load("icon.png") as Texture2D;
		SCShader = Shader.Find("_Value4");
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
		SCShader = Shader.Find("mapselector.filter.rateduponly");
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
			CEKJODEAMGB().SetFloat("skin.", HBJJOCHGOPH);
			NFKFAAHHLLM().SetFloat("_History1LumaTex", Fade);
			NBPKMLMCHFN.SetFloat("SetSunMaxSize", SweaterSize);
			LONNIJMNKFB().SetFloat("original.tutorial", _Intensity);
			DBOLLHHMKKN().SetTexture("file://", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
