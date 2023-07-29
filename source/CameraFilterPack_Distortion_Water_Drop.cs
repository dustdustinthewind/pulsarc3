// CameraFilterPack_Distortion_Water_Drop
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Distortion/Water_Drop")]
[ExecuteInEditMode]
public class CameraFilterPack_Distortion_Water_Drop : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(-1f, 1f)]
	public float CenterX;

	[Range(-1f, 1f)]
	public float CenterY;

	[Range(0f, 10f)]
	public float WaveIntensity = 1f;

	[Range(0f, 20f)]
	public int NumberOfWaves = 5;

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

	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 652f)
			{
				HBJJOCHGOPH = 1497f;
			}
			OKJOKHGJHGF().SetFloat(". Not connectedAndReady.", HBJJOCHGOPH);
			MICHFGAOPKM().SetVector("MultiplayerButton", new Vector2(Screen.width, Screen.height));
			IIJMIPBMMBF().SetFloat("Anomaly_Far", CenterX);
			OLHDPICFBOF().SetFloat("YES", CenterY);
			HKHBBBFLGJH().SetFloat("_Value4", WaveIntensity);
			EFDEIFCDAFG().SetInt("_MaxRadiusOrKInPaper", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LAMEHAHJKMI()
	{
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
			if (HBJJOCHGOPH > 792f)
			{
				HBJJOCHGOPH = 946f;
			}
			CEKJODEAMGB().SetFloat("/Segment-[Down]", HBJJOCHGOPH);
			HNICHJCGJOC().SetVector("CameraFilterPack/3D_Computer", new Vector2(Screen.width, Screen.height));
			OKJOKHGJHGF().SetFloat("<b>#", CenterX);
			HEHKGPKLAKK().SetFloat("Delete events", CenterY);
			GBFOAHKAJEK().SetFloat("HiddenToggle", WaveIntensity);
			HKHBBBFLGJH().SetInt("_TimeX", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DFENCIHAADO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KCCIEMBMOBA()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FGBDGGCBFLP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1773f)
			{
				HBJJOCHGOPH = 106f;
			}
			BLMPMOIDGMG().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			OKJOKHGJHGF().SetVector("_Color", new Vector2(Screen.width, Screen.height));
			JLHLHKPHDFO().SetFloat("[MapsData] User's maps was loaded", CenterX);
			MCDGIILBNIF().SetFloat("_Value7", CenterY);
			HHLFDHNEIAH().SetFloat("?", WaveIntensity);
			MMOODGIODPC().SetInt("\r", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MMBPLGGLPDB()
	{
	}

	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 154f)
			{
				HBJJOCHGOPH = 1984f;
			}
			CIAFLBFJLEJ().SetFloat("[MenuScene] Error: ", HBJJOCHGOPH);
			LEIAFCPJMDP().SetVector("_Value7", new Vector2(Screen.width, Screen.height));
			DBOLLHHMKKN().SetFloat("GlassColor", CenterX);
			MICHFGAOPKM().SetFloat("_TimeX", CenterY);
			KEMJNOMIPHN().SetFloat("SearchTex", WaveIntensity);
			PGPEMMBJOOG().SetInt("cipherText", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHLFDHNEIAH());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)87;
		}
		return BJFKDHHMLJH;
	}

	private void Update()
	{
	}

	private void MKOMIDCPCDC()
	{
		SCShader = Shader.Find("OK");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FEKECCBFGMI()
	{
		SCShader = Shader.Find("_ColorLevel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 382f)
			{
				HBJJOCHGOPH = 1744f;
			}
			HNICHJCGJOC().SetFloat("recipes", HBJJOCHGOPH);
			HKHBBBFLGJH().SetVector("_TimeX", new Vector2(Screen.width, Screen.height));
			GKILCDHJFEG().SetFloat("/", CenterX);
			NBPKMLMCHFN.SetFloat("[Steamworks.NET] DllCheck Test returned false, One or more of the Steamworks binaries seems to be the wrong version.", CenterY);
			LNLKMDPHDCC().SetFloat("GroupNameText", WaveIntensity);
			ADGHJOHKEHG().SetInt("player.licenceaccepted", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BOPKKCAFODF()
	{
		SCShader = Shader.Find(" AuthMode ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material PEIMCBBHLBJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void ODMPMJPALID()
	{
		SCShader = Shader.Find("RT");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KPOCGNOKNOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 505f)
			{
				HBJJOCHGOPH = 1535f;
			}
			JIBOKBCPDLC().SetFloat("turn: {0:0}", HBJJOCHGOPH);
			NMDBCDFPGOK().SetVector("CameraFilterPack/Distortion_Dream", new Vector2(Screen.width, Screen.height));
			NBPKMLMCHFN.SetFloat("Hidden/ScreenSpaceReflection", CenterX);
			HNICHJCGJOC().SetFloat("/", CenterY);
			GKILCDHJFEG().SetFloat("F3", WaveIntensity);
			EFDEIFCDAFG().SetInt("DifficultyBG", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GBFOAHKAJEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GPHPJIDGEPI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CACCPBENDAP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 323f)
			{
				HBJJOCHGOPH = 1083f;
			}
			MMOODGIODPC().SetFloat("CameraFilterPack_TV_Vignetting1", HBJJOCHGOPH);
			EFDEIFCDAFG().SetVector(":", new Vector2(Screen.width, Screen.height));
			GBFOAHKAJEK().SetFloat(" method: ", CenterX);
			OKJOKHGJHGF().SetFloat("PS Home", CenterY);
			PGPEMMBJOOG().SetFloat("You must complete your map before submiting it to Workshop", WaveIntensity);
			CFEDGDGBCHE().SetInt(":", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IJMAPHMBFJI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 953f)
			{
				HBJJOCHGOPH = 28f;
			}
			BLMPMOIDGMG().SetFloat("76561198041679481", HBJJOCHGOPH);
			OLHDPICFBOF().SetVector("_Value", new Vector2(Screen.width, Screen.height));
			HEHKGPKLAKK().SetFloat("{0:x2}", CenterX);
			PEIMCBBHLBJ().SetFloat("anonymous", CenterY);
			OLHDPICFBOF().SetFloat("^", WaveIntensity);
			CFEDGDGBCHE().SetInt("_NeutralTonemapperParams1", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return BJFKDHHMLJH;
	}

	private void NEKCPLGFOFD()
	{
	}

	private void OBDEJFCNOBF()
	{
	}

	private void NCNPAKFAFOE()
	{
		SCShader = Shader.Find("Prints list of all previous commands");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material GBFOAHKAJEK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-110);
		}
		return BJFKDHHMLJH;
	}

	private void DPIPGGDNGHN()
	{
	}

	private void KFEKCJDEECK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
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
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2(Screen.width, Screen.height));
			NBPKMLMCHFN.SetFloat("_CenterX", CenterX);
			NBPKMLMCHFN.SetFloat("_CenterY", CenterY);
			NBPKMLMCHFN.SetFloat("_WaveIntensity", WaveIntensity);
			NBPKMLMCHFN.SetInt("_NumberOfWaves", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild;
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

	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1323f)
			{
				HBJJOCHGOPH = 475f;
			}
			HKHBBBFLGJH().SetFloat("[", HBJJOCHGOPH);
			NBPKMLMCHFN.SetVector("_FlipAlphaMask", new Vector2(Screen.width, Screen.height));
			DBOLLHHMKKN().SetFloat("{0:0.0} ms ({1:0.} fps)", CenterX);
			ADGHJOHKEHG().SetFloat("_Value3", CenterY);
			OKJOKHGJHGF().SetFloat("_TileMaxLoop", WaveIntensity);
			NBPKMLMCHFN.SetInt("[Left]", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FIKFJDFELIP()
	{
		SCShader = Shader.Find("No info");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JECMJNFGBGC()
	{
		SCShader = Shader.Find("SetParticlesColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MANDOGNJJBD()
	{
	}

	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1350f)
			{
				HBJJOCHGOPH = 307f;
			}
			NFKFAAHHLLM().SetFloat("curScn", HBJJOCHGOPH);
			BBIMPFGLDCP().SetVector("RanksButton", new Vector2(Screen.width, Screen.height));
			NMDBCDFPGOK().SetFloat("_VignetteColor", CenterX);
			HNICHJCGJOC().SetFloat("PhotonNetwork error: Could not Instantiate the prefab [", CenterY);
			FGENHBKMPDA().SetFloat("USE_PREDICATION", WaveIntensity);
			CEKJODEAMGB().SetInt("KickThePlayer", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CNGAJDBOCLJ()
	{
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KMOCDAOKGLI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IDJKNBDKHBD()
	{
		SCShader = Shader.Find("skin.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 526f)
			{
				HBJJOCHGOPH = 150f;
			}
			NFKFAAHHLLM().SetFloat("EventMenu", HBJJOCHGOPH);
			MICHFGAOPKM().SetVector("[#clicktogetreward]", new Vector2(Screen.width, Screen.height));
			MICHFGAOPKM().SetFloat("Operation failed: ", CenterX);
			MCDGIILBNIF().SetFloat("[EditorEvent] Exception: ", CenterY);
			EFDEIFCDAFG().SetFloat("_UserLutTex", WaveIntensity);
			BLMPMOIDGMG().SetInt(" or player:", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OOGIHDLBBLM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material KEMJNOMIPHN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return BJFKDHHMLJH;
	}

	private void LBAJLLFMMMP()
	{
		SCShader = Shader.Find("\"");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CIPKEPDELJB()
	{
		SCShader = Shader.Find(": ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 267f)
			{
				HBJJOCHGOPH = 1817f;
			}
			EFDEIFCDAFG().SetFloat("VoteDownToggle", HBJJOCHGOPH);
			BBIMPFGLDCP().SetVector("LevelConfigButton", new Vector2(Screen.width, Screen.height));
			MCDGIILBNIF().SetFloat("Out {0,4} | In {1,4} | Sum {2,4}", CenterX);
			HNICHJCGJOC().SetFloat(":", CenterY);
			CFEDGDGBCHE().SetFloat("y", WaveIntensity);
			HHLFDHNEIAH().SetInt("MenuScene", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EGEPLFGKGLI()
	{
		SCShader = Shader.Find("MenuPlayButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LEAHIBJDMBI()
	{
	}

	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 372f)
			{
				HBJJOCHGOPH = 395f;
			}
			PEIMCBBHLBJ().SetFloat("Vertical", HBJJOCHGOPH);
			PEIMCBBHLBJ().SetVector("x", new Vector2(Screen.width, Screen.height));
			EFDEIFCDAFG().SetFloat("SetSunLerpSpeed", CenterX);
			BLMPMOIDGMG().SetFloat("PopulateMapsList", CenterY);
			CFEDGDGBCHE().SetFloat("OnRelease", WaveIntensity);
			KEMJNOMIPHN().SetInt(" - ", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LEIAFCPJMDP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material MMOODGIODPC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void ONMGIPAILOH()
	{
	}

	[SpecialName]
	private Material JLHLHKPHDFO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material MICHFGAOPKM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInHierarchy);
		}
		return BJFKDHHMLJH;
	}

	private void LJIHHJOAJCN()
	{
	}

	private void BGFJOEPFOPM()
	{
	}

	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1794f)
			{
				HBJJOCHGOPH = 992f;
			}
			BLMPMOIDGMG().SetFloat("Joystick1Button10", HBJJOCHGOPH);
			CIAFLBFJLEJ().SetVector("[MapsEditor] Creating new item...", new Vector2(Screen.width, Screen.height));
			NFKFAAHHLLM().SetFloat("shader.future", CenterX);
			OLHDPICFBOF().SetFloat("masterSteamID", CenterY);
			BLMPMOIDGMG().SetFloat("tip", WaveIntensity);
			LNLKMDPHDCC().SetInt("_Value2", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHLFDHNEIAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HEHKGPKLAKK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)125;
		}
		return BJFKDHHMLJH;
	}

	private void HOMNAHDDNHJ()
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
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void DNENFLNCIJP()
	{
	}

	private void CKCPPNHANAA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1900f)
			{
				HBJJOCHGOPH = 1001f;
			}
			HNICHJCGJOC().SetFloat("_Value", HBJJOCHGOPH);
			MCDGIILBNIF().SetVector("_BlurVector", new Vector2(Screen.width, Screen.height));
			CEKJODEAMGB().SetFloat("_VignetteSettings", CenterX);
			CFEDGDGBCHE().SetFloat("ViewMenu", CenterY);
			OGMEGHKECAH().SetFloat("_FarCamera", WaveIntensity);
			MCDGIILBNIF().SetInt("_SSAO", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NCPAFCKGJEA()
	{
	}

	[SpecialName]
	private Material NMDBCDFPGOK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)75;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material BLMPMOIDGMG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void AIBNKIDADPI()
	{
		SCShader = Shader.Find("SelectorMusicToggle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OPHBLNNGFKG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 580f)
			{
				HBJJOCHGOPH = 246f;
			}
			PGPEMMBJOOG().SetFloat(" failed in a server-side plugin. Check the configuration in the Dashboard. Message from server-plugin: ", HBJJOCHGOPH);
			HKHBBBFLGJH().SetVector("_Offsets", new Vector2(Screen.width, Screen.height));
			CFEDGDGBCHE().SetFloat("BitsData", CenterX);
			HEHKGPKLAKK().SetFloat("_MaxSteps", CenterY);
			NFKFAAHHLLM().SetFloat("ReconnectAndRejoin() failed. Can only connect while in state 'Disconnected'. Current state: ", WaveIntensity);
			OLHDPICFBOF().SetInt("AddEnvironmentObject", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FDNONDCGGCG()
	{
		SCShader = Shader.Find("Failed to InstantiateSceneObject prefab: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material JIBOKBCPDLC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void DOOIKOEBBJB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1236f)
			{
				HBJJOCHGOPH = 807f;
			}
			NFKFAAHHLLM().SetFloat("SetPlayerDistance", HBJJOCHGOPH);
			PEIMCBBHLBJ().SetVector("/icon", new Vector2(Screen.width, Screen.height));
			MCDGIILBNIF().SetFloat("float,2", CenterX);
			MICHFGAOPKM().SetFloat("PopulateMapsList", CenterY);
			NBPKMLMCHFN.SetFloat("RecieveChatMessage", WaveIntensity);
			JIBOKBCPDLC().SetInt("_AccumOrig", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ALNNIDLFILB()
	{
		SCShader = Shader.Find("settings.fps");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material HHLFDHNEIAH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-69);
		}
		return BJFKDHHMLJH;
	}

	private void IAJKLKJJKEJ()
	{
	}

	[SpecialName]
	private Material CFEDGDGBCHE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-101);
		}
		return BJFKDHHMLJH;
	}

	private void LKJMIODJGCM()
	{
	}

	private void OnDisable()
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
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void LGHCJCFHEMF()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GJAJBMGGPFB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HLDFOJMHKNL()
	{
	}

	private void AKHCOBHHGJP()
	{
		SCShader = Shader.Find("Texture3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PNNPDMHLFHE()
	{
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material PGPEMMBJOOG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)111;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material OKJOKHGJHGF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-111);
		}
		return BJFKDHHMLJH;
	}

	private void ELGOMIMONOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 493f)
			{
				HBJJOCHGOPH = 461f;
			}
			HEHKGPKLAKK().SetFloat("BadgeText", HBJJOCHGOPH);
			CFEDGDGBCHE().SetVector("_Distortion", new Vector2(Screen.width, Screen.height));
			EFDEIFCDAFG().SetFloat("Offline", CenterX);
			ADGHJOHKEHG().SetFloat("_Value3", CenterY);
			MICHFGAOPKM().SetFloat("0.00", WaveIntensity);
			HNICHJCGJOC().SetInt("Tab2Content", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PGPEMMBJOOG());
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

	private void GJCOELHNLJE()
	{
	}

	[SpecialName]
	private Material HNICHJCGJOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void MCKCCPLJIFE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JILOMOBDPIA()
	{
		SCShader = Shader.Find("DPADVER");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IHHNCCOGLPN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KIEJKBNBHMD()
	{
	}

	private void GNMGIHFKJIJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material BBIMPFGLDCP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 280f)
			{
				HBJJOCHGOPH = 193f;
			}
			LEIAFCPJMDP().SetFloat("22x3", HBJJOCHGOPH);
			CFEDGDGBCHE().SetVector("_Value2", new Vector2(Screen.width, Screen.height));
			HNICHJCGJOC().SetFloat("shader.ghost", CenterX);
			JLHLHKPHDFO().SetFloat("maps.", CenterY);
			IIJMIPBMMBF().SetFloat("_HitPointTexture", WaveIntensity);
			BLMPMOIDGMG().SetInt("Set Object Rotation", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PDHKMDBNGGN()
	{
		SCShader = Shader.Find(".icon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KOFAMEKHHGD()
	{
		SCShader = Shader.Find("Player");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void COOHIILCOCO()
	{
		SCShader = Shader.Find("Jun");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DBEMDAJDDDA()
	{
		SCShader = Shader.Find("_SizeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OMIHEBMMCPG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1136f)
			{
				HBJJOCHGOPH = 465f;
			}
			HNICHJCGJOC().SetFloat("_TileMaxOffs", HBJJOCHGOPH);
			PGPEMMBJOOG().SetVector("_Value3", new Vector2(Screen.width, Screen.height));
			KEMJNOMIPHN().SetFloat("_ReflectionTexture1", CenterX);
			KEMJNOMIPHN().SetFloat("_TimeX", CenterY);
			OKJOKHGJHGF().SetFloat("id", WaveIntensity);
			FGENHBKMPDA().SetInt("_", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PKGJJFIFLII()
	{
	}

	private void EKPLGFAEOBE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Distortion_Water_Drop");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MNBPNHNAEBK()
	{
		SCShader = Shader.Find(" not exist");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DEEPMOLMGED()
	{
	}

	private void JDGFCEPDKAJ()
	{
	}

	[SpecialName]
	private Material LEIAFCPJMDP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-111);
		}
		return BJFKDHHMLJH;
	}

	private void BJOHDLNDFAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FABKIGNFECE()
	{
	}

	[SpecialName]
	private Material OGMEGHKECAH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void CFFCLAHMBAA()
	{
		SCShader = Shader.Find("_Value6");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IEMEHGCFAPD()
	{
	}

	private void KLILJHJNICK()
	{
		SCShader = Shader.Find("yyyy-MM-dd HH:mm:ss");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HCDBNAKGDJC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ABHEJPAGNMO()
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

	private void HIKKPDACJGI()
	{
	}

	[SpecialName]
	private Material MCDGIILBNIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.HideInHierarchy;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material GKILCDHJFEG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return BJFKDHHMLJH;
	}

	private void INLDEHPAMJC()
	{
	}

	private void OMCLOFCJMPG()
	{
	}

	private void JKFDDNMPOJH()
	{
		SCShader = Shader.Find("CameraFilterPack/3D_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material DBOLLHHMKKN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void CCLNNLCOPBL()
	{
		SCShader = Shader.Find("[MapsData] Key ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DKOPKPBLDHH()
	{
		SCShader = Shader.Find(". Our prefix is ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PMPKMGKAAJH()
	{
		SCShader = Shader.Find("ConfigVersionSlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1601f)
			{
				HBJJOCHGOPH = 289f;
			}
			GBFOAHKAJEK().SetFloat("\\[ *im.*\\](\\n\\n\\n|\\n\\n|\\n|)", HBJJOCHGOPH);
			CEKJODEAMGB().SetVector("_FixDistance", new Vector2(Screen.width, Screen.height));
			DBOLLHHMKKN().SetFloat("_Radius", CenterX);
			BLMPMOIDGMG().SetFloat("Tab2Content", CenterY);
			BLMPMOIDGMG().SetFloat("_TimeX", WaveIntensity);
			CEKJODEAMGB().SetInt("SetSunMinSize", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 725f)
			{
				HBJJOCHGOPH = 909f;
			}
			PGPEMMBJOOG().SetFloat("bad", HBJJOCHGOPH);
			FGENHBKMPDA().SetVector("LoadMapCanvas", new Vector2(Screen.width, Screen.height));
			CIAFLBFJLEJ().SetFloat("(master)", CenterX);
			PGPEMMBJOOG().SetFloat(" elements", CenterY);
			EFDEIFCDAFG().SetFloat("[NetworkManager] Connected to ", WaveIntensity);
			MICHFGAOPKM().SetInt(". Using max value: 255.", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CEKJODEAMGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material ADGHJOHKEHG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-126);
		}
		return BJFKDHHMLJH;
	}

	private void FGNFILLNPJK()
	{
	}

	private void LBIOIEANMGI()
	{
	}

	private void FOAGAKFBIGD()
	{
	}

	[SpecialName]
	private Material LPDOGGFOBDH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)110;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material OLHDPICFBOF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)80;
		}
		return BJFKDHHMLJH;
	}

	private void ANDELGODEOC()
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-76);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IIJMIPBMMBF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-101);
		}
		return BJFKDHHMLJH;
	}

	private void AOGCKKLFGPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1998f)
			{
				HBJJOCHGOPH = 1013f;
			}
			DBOLLHHMKKN().SetFloat("Turn", HBJJOCHGOPH);
			OKJOKHGJHGF().SetVector("_EmissionColor", new Vector2(Screen.width, Screen.height));
			MCDGIILBNIF().SetFloat(".workshop.json", CenterX);
			EFDEIFCDAFG().SetFloat("_TimeX", CenterY);
			LEIAFCPJMDP().SetFloat("CameraFilterPack/Lut_TestMode", WaveIntensity);
			MCDGIILBNIF().SetInt("_ScreenResolution", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NMDBCDFPGOK());
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
			if (HBJJOCHGOPH > 540f)
			{
				HBJJOCHGOPH = 971f;
			}
			NFKFAAHHLLM().SetFloat("Change Note:", HBJJOCHGOPH);
			JLHLHKPHDFO().SetVector("_ScreenResolution", new Vector2(Screen.width, Screen.height));
			LPDOGGFOBDH().SetFloat("ConfigVersionSlider", CenterX);
			CFEDGDGBCHE().SetFloat("settings.enablerankingnotifications", CenterY);
			LNLKMDPHDCC().SetFloat("_DistortionSize", WaveIntensity);
			EFDEIFCDAFG().SetInt("Left", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
