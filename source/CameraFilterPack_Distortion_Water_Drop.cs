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
			NFKFAAHHLLM().SetFloat("score", HBJJOCHGOPH);
			EFDEIFCDAFG().SetVector("In Main Menu", new Vector2(Screen.width, Screen.height));
			JLHLHKPHDFO().SetFloat("Anomaly_Far", CenterX);
			PEIMCBBHLBJ().SetFloat("Exit to menu?", CenterY);
			GKILCDHJFEG().SetFloat("_Value4", WaveIntensity);
			IIJMIPBMMBF().SetInt("_ToPrevViewProjCombined", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
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
			CIAFLBFJLEJ().SetFloat("/Segment-[Up]", HBJJOCHGOPH);
			LNLKMDPHDCC().SetVector("CameraFilterPack/3D_Computer", new Vector2(Screen.width, Screen.height));
			KEMJNOMIPHN().SetFloat("<b>#", CenterX);
			HEHKGPKLAKK().SetFloat("[Up]", CenterY);
			BBIMPFGLDCP().SetFloat("HiddenToggle", WaveIntensity);
			CEKJODEAMGB().SetInt("_ScreenResolution", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
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
		SCShader = Shader.Find("_Value");
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
			GKILCDHJFEG().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			EFDEIFCDAFG().SetVector("SupportLogger OnDisconnectedFromPhoton().", new Vector2(Screen.width, Screen.height));
			HHLFDHNEIAH().SetFloat("/", CenterX);
			GBFOAHKAJEK().SetFloat("_Value7", CenterY);
			MCDGIILBNIF().SetFloat("Down", WaveIntensity);
			KEMJNOMIPHN().SetInt("\t", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHLFDHNEIAH());
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
			CEKJODEAMGB().SetFloat("[MenuScene] Error: ", HBJJOCHGOPH);
			JIBOKBCPDLC().SetVector("_Value7", new Vector2(Screen.width, Screen.height));
			GBFOAHKAJEK().SetFloat("GlassesColor2", CenterX);
			MCDGIILBNIF().SetFloat("CameraFilterPack_Sweater", CenterY);
			HNICHJCGJOC().SetFloat("Hidden/Subpixel Morphological Anti-aliasing", WaveIntensity);
			IIJMIPBMMBF().SetInt("plainText", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
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
		SCShader = Shader.Find("Already exist!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FEKECCBFGMI()
	{
		SCShader = Shader.Find("_EdgeSize");
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
			HKHBBBFLGJH().SetFloat(" ", HBJJOCHGOPH);
			HEHKGPKLAKK().SetVector("CameraFilterPack/Vision_Plasma", new Vector2(Screen.width, Screen.height));
			JIBOKBCPDLC().SetFloat("[MapsData] Bad map: ", CenterX);
			OLHDPICFBOF().SetFloat("Tried to Initialize the SteamAPI twice in one session!", CenterY);
			JLHLHKPHDFO().SetFloat("GroupNameText", WaveIntensity);
			MICHFGAOPKM().SetInt("player.licenceaccepted", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BOPKKCAFODF()
	{
		SCShader = Shader.Find("Connected to masterserver.");
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
		SCShader = Shader.Find("LT");
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
			OGMEGHKECAH().SetFloat("The new master starts a new round, cause we didn't start yet.", HBJJOCHGOPH);
			NFKFAAHHLLM().SetVector("CameraFilterPack/Distortion_Dream", new Vector2(Screen.width, Screen.height));
			OKJOKHGJHGF().SetFloat("_History3Weight", CenterX);
			KEMJNOMIPHN().SetFloat(".", CenterY);
			PGPEMMBJOOG().SetFloat("F3", WaveIntensity);
			PGPEMMBJOOG().SetInt(".played", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			NBPKMLMCHFN.SetFloat("CameraFilterPack/TV_Vignetting", HBJJOCHGOPH);
			CFEDGDGBCHE().SetVector("You did not select a Hosting Type in your PhotonServerSettings. Please set it up or don't use ConnectUsingSettings().", new Vector2(Screen.width, Screen.height));
			JIBOKBCPDLC().SetFloat("Cannot remove cached RPCs on a PhotonView thats not ours! ", CenterX);
			JLHLHKPHDFO().SetFloat("Right Stick Click", CenterY);
			MCDGIILBNIF().SetFloat("SUBMIT", WaveIntensity);
			EFDEIFCDAFG().SetInt(":", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
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
			CFEDGDGBCHE().SetFloat("appid", HBJJOCHGOPH);
			MCDGIILBNIF().SetVector("_TimeX", new Vector2(Screen.width, Screen.height));
			KEMJNOMIPHN().SetFloat("TestTicket", CenterX);
			IIJMIPBMMBF().SetFloat("ChatInput", CenterY);
			HNICHJCGJOC().SetFloat("^", WaveIntensity);
			LEIAFCPJMDP().SetInt("_ToneCurveRange", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
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
		SCShader = Shader.Find("Clears all text from the debug console");
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
			FGENHBKMPDA().SetFloat("\n", HBJJOCHGOPH);
			LPDOGGFOBDH().SetVector("_Min", new Vector2(Screen.width, Screen.height));
			DBOLLHHMKKN().SetFloat("] ", CenterX);
			JLHLHKPHDFO().SetFloat("_Value3", CenterY);
			HKHBBBFLGJH().SetFloat("_MaxBlurRadius", WaveIntensity);
			HNICHJCGJOC().SetInt(",", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FIKFJDFELIP()
	{
		SCShader = Shader.Find("icon.png");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JECMJNFGBGC()
	{
		SCShader = Shader.Find("Set crosshair emission (glow)");
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
			LNLKMDPHDCC().SetFloat("curScn", HBJJOCHGOPH);
			MCDGIILBNIF().SetVector("RanksButton", new Vector2(Screen.width, Screen.height));
			CEKJODEAMGB().SetFloat("CHROMATIC_ABERRATION", CenterX);
			EFDEIFCDAFG().SetFloat(". Should be just one?", CenterY);
			GBFOAHKAJEK().SetFloat("_ReprojectionMatrix", WaveIntensity);
			LPDOGGFOBDH().SetInt("KickThePlayer", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CNGAJDBOCLJ()
	{
		SCShader = Shader.Find("_Value3");
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
		SCShader = Shader.Find("#close");
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
			OKJOKHGJHGF().SetFloat("EventMenu", HBJJOCHGOPH);
			HKHBBBFLGJH().SetVector("BlockCount", new Vector2(Screen.width, Screen.height));
			BLMPMOIDGMG().SetFloat(" failed in a server-side plugin. Check the configuration in the Dashboard. Message from server-plugin: ", CenterX);
			ADGHJOHKEHG().SetFloat("_EmissionColor", CenterY);
			OLHDPICFBOF().SetFloat("_InternalLutTex", WaveIntensity);
			PGPEMMBJOOG().SetInt(" GO:", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
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
		SCShader = Shader.Find("}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CIPKEPDELJB()
	{
		SCShader = Shader.Find("SetEnvSpriteImage");
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
			PGPEMMBJOOG().SetFloat("VoteUpToggle", HBJJOCHGOPH);
			MICHFGAOPKM().SetVector("SaveButton", new Vector2(Screen.width, Screen.height));
			MMOODGIODPC().SetFloat("Out {0,4} | In {1,4} | Sum {2,4}", CenterX);
			CFEDGDGBCHE().SetFloat("[PlayerController] ", CenterY);
			GBFOAHKAJEK().SetFloat("y", WaveIntensity);
			HKHBBBFLGJH().SetInt("MenuScene", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EGEPLFGKGLI()
	{
		SCShader = Shader.Find("EventSystem");
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
			JLHLHKPHDFO().SetFloat("Horizontal", HBJJOCHGOPH);
			MCDGIILBNIF().SetVector("Case-Sensitive", new Vector2(Screen.width, Screen.height));
			HHLFDHNEIAH().SetFloat("Set sun audio input", CenterX);
			GBFOAHKAJEK().SetFloat("/", CenterY);
			DBOLLHHMKKN().SetFloat("OnPress", WaveIntensity);
			DBOLLHHMKKN().SetInt("Reading preview file failed!: \"{0}\"", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GBFOAHKAJEK());
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
			NBPKMLMCHFN.SetFloat("Joystick1Button9", HBJJOCHGOPH);
			FGENHBKMPDA().SetVector("#yes", new Vector2(Screen.width, Screen.height));
			PEIMCBBHLBJ().SetFloat("shader.future", CenterX);
			BLMPMOIDGMG().SetFloat("masterSteamID", CenterY);
			KEMJNOMIPHN().SetFloat("_EmissionGain", WaveIntensity);
			CFEDGDGBCHE().SetInt("_Value", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF());
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
			JLHLHKPHDFO().SetFloat("_TimeX", HBJJOCHGOPH);
			GKILCDHJFEG().SetVector("_BlurVector", new Vector2(Screen.width, Screen.height));
			HHLFDHNEIAH().SetFloat("_VignetteCenter", CenterX);
			CIAFLBFJLEJ().SetFloat("ViewMenu", CenterY);
			LNLKMDPHDCC().SetFloat("_FarCamera", WaveIntensity);
			HKHBBBFLGJH().SetInt("_SSAO", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JLHLHKPHDFO());
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
			EFDEIFCDAFG().SetFloat(" could not be executed (yet). Wait for state JoinedLobby or ConnectedToMaster and their callbacks before calling operations. WebRPCs need a server-side configuration. Enum OperationCode helps identify the operation.", HBJJOCHGOPH);
			MMOODGIODPC().SetVector("_Offsets", new Vector2(Screen.width, Screen.height));
			GKILCDHJFEG().SetFloat("BitsData", CenterX);
			PGPEMMBJOOG().SetFloat("_AllowBackwardsRays", CenterY);
			PEIMCBBHLBJ().SetFloat("Reconnect() failed. Can only connect while in state 'Disconnected'. Current state: ", WaveIntensity);
			JIBOKBCPDLC().SetInt("AddEnvironmentObject", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BBIMPFGLDCP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FDNONDCGGCG()
	{
		SCShader = Shader.Find("Failed to Instantiate prefab:");
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
			NFKFAAHHLLM().SetFloat("SpawnObj", HBJJOCHGOPH);
			LEIAFCPJMDP().SetVector("/", new Vector2(Screen.width, Screen.height));
			EFDEIFCDAFG().SetFloat("float,2", CenterX);
			OGMEGHKECAH().SetFloat("/", CenterY);
			CEKJODEAMGB().SetFloat("MenuScene", WaveIntensity);
			IIJMIPBMMBF().SetInt("_Angle", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
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
		SCShader = Shader.Find("_Value");
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
		SCShader = Shader.Find("Texture2");
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
			OKJOKHGJHGF().SetFloat("BadgeText", HBJJOCHGOPH);
			LNLKMDPHDCC().SetVector("_TimeX", new Vector2(Screen.width, Screen.height));
			KEMJNOMIPHN().SetFloat("In Main Menu", CenterX);
			NBPKMLMCHFN.SetFloat("_Value2", CenterY);
			JLHLHKPHDFO().SetFloat("FileMenu", WaveIntensity);
			JIBOKBCPDLC().SetInt("Tab2Content", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CIAFLBFJLEJ());
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
			CEKJODEAMGB().SetFloat("2;13;14;15;16", HBJJOCHGOPH);
			HKHBBBFLGJH().SetVector("_Value", new Vector2(Screen.width, Screen.height));
			BLMPMOIDGMG().SetFloat("shader.ghost", CenterX);
			MMOODGIODPC().SetFloat("maps.", CenterY);
			FGENHBKMPDA().SetFloat("Hidden/ScreenSpaceReflection", WaveIntensity);
			LNLKMDPHDCC().SetInt("SetRotation", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NMDBCDFPGOK());
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
		SCShader = Shader.Find("settings.hideui");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void COOHIILCOCO()
	{
		SCShader = Shader.Find("Apr");
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
			LNLKMDPHDCC().SetFloat("_VelocityScale", HBJJOCHGOPH);
			PEIMCBBHLBJ().SetVector("_Value2", new Vector2(Screen.width, Screen.height));
			OLHDPICFBOF().SetFloat("_HitPointTexture", CenterX);
			DBOLLHHMKKN().SetFloat("CameraFilterPack/Vision_Aura", CenterY);
			LPDOGGFOBDH().SetFloat("Remove Environment Object", WaveIntensity);
			GBFOAHKAJEK().SetInt("_SoftZDistance", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
		SCShader = Shader.Find(": ");
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
		SCShader = Shader.Find("_Value5");
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
		SCShader = Shader.Find("#,0.00");
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
		SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DKOPKPBLDHH()
	{
		SCShader = Shader.Find("Received OnSerialization for view ID ");
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
			NMDBCDFPGOK().SetFloat("\\[ *im.*\\](\\n\\n\\n|\\n\\n|\\n|)", HBJJOCHGOPH);
			BLMPMOIDGMG().SetVector("_FixDistance", new Vector2(Screen.width, Screen.height));
			NFKFAAHHLLM().SetFloat("_Radius", CenterX);
			LNLKMDPHDCC().SetFloat("Tab2Content", CenterY);
			LPDOGGFOBDH().SetFloat("CameraFilterPack/FX_8bits_gb", WaveIntensity);
			OKJOKHGJHGF().SetInt("Set sun beat detection sensitivity", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
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
			GBFOAHKAJEK().SetFloat("ticket", HBJJOCHGOPH);
			OGMEGHKECAH().SetVector("Data/Editor/leveltemplate", new Vector2(Screen.width, Screen.height));
			MMOODGIODPC().SetFloat(" (inactive)", CenterX);
			LEIAFCPJMDP().SetFloat("PlayerPrefs::Deserialize() parameterContent has ", CenterY);
			ADGHJOHKEHG().SetFloat("[NetworkManager] Connected to ", WaveIntensity);
			MICHFGAOPKM().SetInt("Can't set MaxPlayers when not in that room.", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
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
			BLMPMOIDGMG().SetFloat("turn", HBJJOCHGOPH);
			HKHBBBFLGJH().SetVector("_EmissionColor", new Vector2(Screen.width, Screen.height));
			OKJOKHGJHGF().SetFloat(".workshop", CenterX);
			LPDOGGFOBDH().SetFloat("CameraFilterPack/TV_Tiles", CenterY);
			HNICHJCGJOC().SetFloat("_LutTex", WaveIntensity);
			GBFOAHKAJEK().SetInt("_ScreenResolution", NumberOfWaves);
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
			if (HBJJOCHGOPH > 540f)
			{
				HBJJOCHGOPH = 971f;
			}
			PGPEMMBJOOG().SetFloat("NO", HBJJOCHGOPH);
			BLMPMOIDGMG().SetVector("_Value4", new Vector2(Screen.width, Screen.height));
			KEMJNOMIPHN().SetFloat("ConfigVersionSlider", CenterX);
			NBPKMLMCHFN.SetFloat("settings.enablerankingnotifications", CenterY);
			MCDGIILBNIF().SetFloat("_DistortionSize", WaveIntensity);
			GBFOAHKAJEK().SetInt("Keypad", NumberOfWaves);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
