// CameraFilterPack_Vision_Plasma
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Vision/Plasma")]
[ExecuteInEditMode]
public class CameraFilterPack_Vision_Plasma : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(-2f, 2f)]
	public float Value = 0.6f;

	[Range(-2f, 2f)]
	public float Value2 = 0.2f;

	[Range(0f, 60f)]
	public float Intensity = 15f;

	[Range(0f, 10f)]
	private float CCIENBFIKKH = 1f;

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

	private void JOJFHFHOCHO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material EJDPNJAEAKJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)98;
		}
		return BJFKDHHMLJH;
	}

	private void DHENLPJJOEN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HNGHDAPKEJG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JABNHMIHBHC()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KMCPMOGKDEH()
	{
		SCShader = Shader.Find("_EmissionGain");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NKFDNIAKGEO()
	{
		SCShader = Shader.Find("MAPS NOT FOUND");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OIBMHPIFAKK()
	{
	}

	private void ABEIEGDHBNO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MMOKKAPFGAK()
	{
		SCShader = Shader.Find("_Offsets");
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
			BJFKDHHMLJH.hideFlags = (HideFlags)106;
		}
		return BJFKDHHMLJH;
	}

	private void KMKLDAJLCNM()
	{
	}

	[SpecialName]
	private Material LMLENGFLEBD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)117;
		}
		return BJFKDHHMLJH;
	}

	private void JKFDDNMPOJH()
	{
		SCShader = Shader.Find("[PlayerBase] MapEnd error: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material NMDBCDFPGOK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void KPOCGNOKNOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 727f)
			{
				HBJJOCHGOPH = 673f;
			}
			NFKFAAHHLLM().SetFloat("HIDE CONFIG [Ctrl+E]", HBJJOCHGOPH);
			HEINDEMCGIK().SetFloat(" not exist", Value);
			NMDBCDFPGOK().SetFloat("[Up-Down]", Value2);
			LMLENGFLEBD().SetFloat(" ", Intensity);
			KBOPGONOCNP().SetFloat("PRESS A KEY", CCIENBFIKKH);
			BAGICADFBAB().SetVector("Mouse X", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 795f, 804f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
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

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DKOPKPBLDHH()
	{
		SCShader = Shader.Find("[LevelEditorScene] Print Audio Wave: Done");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1306f)
			{
				HBJJOCHGOPH = 1297f;
			}
			OGMEGHKECAH().SetFloat("pointBuffer", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("IntraTime", Value);
			FLOHGDECHHH().SetFloat("_TimeX", Value2);
			CFEDGDGBCHE().SetFloat("Already exist!", Intensity);
			CECICEGFHKL().SetFloat("Set particles count per one beat", CCIENBFIKKH);
			PEIMCBBHLBJ().SetVector("-", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 877f, 188f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MGMAOBPPOBJ()
	{
		SCShader = Shader.Find("_OcclusionTexture");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DHNGNHGDPLM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IBFJAOINHMK()
	{
	}

	private void MKFLBEGJJDC()
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
			BJFKDHHMLJH.hideFlags = (HideFlags)64;
		}
		return BJFKDHHMLJH;
	}

	private void AKCADICOFDD()
	{
	}

	private void JDKHBGDEONK()
	{
		SCShader = Shader.Find("Error: Cannot change the name of a remote player!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FJNCHGLIEMA()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material HEINDEMCGIK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void HDMDKOKOOJC()
	{
		SCShader = Shader.Find("Sprite");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 890f)
			{
				HBJJOCHGOPH = 1675f;
			}
			HEINDEMCGIK().SetFloat("http", HBJJOCHGOPH);
			OIIDAKBILMI().SetFloat("_Value3", Value);
			NFKFAAHHLLM().SetFloat("_Offsets", Value2);
			KGOLDDBHIFN().SetFloat("MaxLivesSlider", Intensity);
			OGMEGHKECAH().SetFloat("_Distortion", CCIENBFIKKH);
			KGOLDDBHIFN().SetVector("_Vignette_Alpha", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1806f, 1112f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material OGMEGHKECAH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-94);
		}
		return BJFKDHHMLJH;
	}

	private void JCGMGLMADEN()
	{
	}

	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 398f)
			{
				HBJJOCHGOPH = 818f;
			}
			HEINDEMCGIK().SetFloat("SpeedSlider", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("/", Value);
			BAGICADFBAB().SetFloat("id", Value2);
			LNLKMDPHDCC().SetFloat("PlayButton", Intensity);
			KEMJNOMIPHN().SetFloat("[PlayerBase] SpawnObj error: ", CCIENBFIKKH);
			HNFFHCLNBDN().SetVector("Reconnect() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1441f, 368f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
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
			NBPKMLMCHFN.SetFloat("_Value", Value);
			NBPKMLMCHFN.SetFloat("_Value2", Value2);
			NBPKMLMCHFN.SetFloat("_Value3", Intensity);
			NBPKMLMCHFN.SetFloat("_Value4", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HLIAEEMGBHN()
	{
		SCShader = Shader.Find("The number of players playing your game: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CHOPDIGHJNH()
	{
		SCShader = Shader.Find("The number of players playing your game: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CMIBEOJGAIL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OMCLOFCJMPG()
	{
	}

	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1240f)
			{
				HBJJOCHGOPH = 124f;
			}
			EJDPNJAEAKJ().SetFloat("Error! no audio sources attached to AudioSampler.css", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.", Value);
			LMLENGFLEBD().SetFloat("/", Value2);
			NFKFAAHHLLM().SetFloat("ShadersToggle", Intensity);
			OGMEGHKECAH().SetFloat("turn", CCIENBFIKKH);
			OIIDAKBILMI().SetVector("_Value4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1956f, 302f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EKPLGFAEOBE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KFEKCJDEECK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ALNNIDLFILB()
	{
		SCShader = Shader.Find("CameraFilterPack_Glasses_On5");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CGBHOELMAOC()
	{
	}

	private void FABKIGNFECE()
	{
	}

	private void HONBLGFDMLL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IHHNCCOGLPN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1427f)
			{
				HBJJOCHGOPH = 959f;
			}
			NDMPCDHADMJ().SetFloat("_DepthLevel", HBJJOCHGOPH);
			HKIMAANBGMJ().SetFloat("RanksButton", Value);
			LMLENGFLEBD().SetFloat("_Blend", Value2);
			HCGJCMDJPGD().SetFloat("Reading preview file failed! Make sure JSON file is filled properly and/or file exists: \"{0}\"", Intensity);
			OIIDAKBILMI().SetFloat("PLEASE WAIT", CCIENBFIKKH);
			NJDIODJNGGA().SetVector(" not exist", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1619f, 766f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1317f)
			{
				HBJJOCHGOPH = 1705f;
			}
			NFKFAAHHLLM().SetFloat("CameraFilterPack/Blend2Camera_ColorBurn", HBJJOCHGOPH);
			ENKPNJMPDEB().SetFloat("BadgeText", Value);
			EJDPNJAEAKJ().SetFloat("#yes", Value2);
			DKNJGHFLAIF().SetFloat("UI", Intensity);
			EJDPNJAEAKJ().SetFloat("#rate!", CCIENBFIKKH);
			CFEDGDGBCHE().SetVector("custom", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 556f, 783f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 744f)
			{
				HBJJOCHGOPH = 891f;
			}
			HCGJCMDJPGD().SetFloat("Value", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("_ColorBuffer", Value);
			CFEDGDGBCHE().SetFloat("JITTER", Value2);
			OGMEGHKECAH().SetFloat("SetPlayerDistance", Intensity);
			CECICEGFHKL().SetFloat("_Color_G", CCIENBFIKKH);
			KGOLDDBHIFN().SetVector("_FixDistance", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 238f, 765f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material NJDIODJNGGA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)106;
		}
		return BJFKDHHMLJH;
	}

	private void OKHBBIKDIEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1209f)
			{
				HBJJOCHGOPH = 877f;
			}
			EJDPNJAEAKJ().SetFloat("_Quality", HBJJOCHGOPH);
			HNFFHCLNBDN().SetFloat("_Value3", Value);
			DKNJGHFLAIF().SetFloat("id", Value2);
			KEMJNOMIPHN().SetFloat("--------------------------------", Intensity);
			OIIDAKBILMI().SetFloat("ArcsNoHitsoundTimeDelaySlider", CCIENBFIKKH);
			HCGJCMDJPGD().SetVector(" SecondsBeforeRespawn: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1291f, 1863f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ENKPNJMPDEB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BNLENEDAHHL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GENCBNFIILN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 684f)
			{
				HBJJOCHGOPH = 199f;
			}
			LMLENGFLEBD().SetFloat("_Value2", HBJJOCHGOPH);
			NDMPCDHADMJ().SetFloat("CameraFilterPack/Blend2Camera_LinearBurn", Value);
			OIIDAKBILMI().SetFloat("CameraFilterPack/Gradients_NeonGradient", Value2);
			LNLKMDPHDCC().SetFloat("CameraFilterPack/Light_Rainbow", Intensity);
			HNFFHCLNBDN().SetFloat("id", CCIENBFIKKH);
			FKEOGPDLBDD().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 725f, 99f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BAGICADFBAB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NKLIHNJCHOG()
	{
	}

	private void AAPKBNDHBLI()
	{
	}

	[SpecialName]
	private Material KEMJNOMIPHN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)117;
		}
		return BJFKDHHMLJH;
	}

	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1813f)
			{
				HBJJOCHGOPH = 887f;
			}
			KGOLDDBHIFN().SetFloat("_Value3", HBJJOCHGOPH);
			NDMPCDHADMJ().SetFloat("#ok", Value);
			NBPKMLMCHFN.SetFloat("_Value2", Value2);
			NBPKMLMCHFN.SetFloat("DifficultyBG", Intensity);
			IIJMIPBMMBF().SetFloat("downloading", CCIENBFIKKH);
			CECICEGFHKL().SetVector("[PlayerBase] Checkpoint error: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 293f, 441f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EDPDMBFLHLP()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Vision_Plasma");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CGDMLHLJIDK()
	{
		SCShader = Shader.Find("CameraFilterPack_Glasses_On4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material CECICEGFHKL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void HPNNCNNFMGK()
	{
	}

	[SpecialName]
	private Material CFEDGDGBCHE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material FLOHGDECHHH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NFKFAAHHLLM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void GPFJMKCGHGB()
	{
	}

	private void LIEGJOHINGC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FOAGAKFBIGD()
	{
	}

	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 457f)
			{
				HBJJOCHGOPH = 14f;
			}
			NBPKMLMCHFN.SetFloat("/", HBJJOCHGOPH);
			OIIDAKBILMI().SetFloat("UseFinalGlassColor", Value);
			LNLKMDPHDCC().SetFloat("_Far", Value2);
			LMLENGFLEBD().SetFloat("settings.arcsnohitsoundtimedelay", Intensity);
			BAGICADFBAB().SetFloat("sounds/hit_perfect", CCIENBFIKKH);
			NDMPCDHADMJ().SetVector("OK", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1558f, 314f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BAGICADFBAB());
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
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void POJFHDFJOPE()
	{
	}

	private void KCNIHHNMFFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1212f)
			{
				HBJJOCHGOPH = 313f;
			}
			CECICEGFHKL().SetFloat("_LutTex", HBJJOCHGOPH);
			HEINDEMCGIK().SetFloat("Edited unlock conditions", Value);
			ENKPNJMPDEB().SetFloat("yes", Value2);
			ENKPNJMPDEB().SetFloat("/../", Intensity);
			GKILCDHJFEG().SetFloat("_Value2", CCIENBFIKKH);
			OIIDAKBILMI().SetVector("FreqVolume: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 57f, 85f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FIKFJDFELIP()
	{
		SCShader = Shader.Find("[RanksSystem] Init");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material OIIDAKBILMI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 127f)
			{
				HBJJOCHGOPH = 49f;
			}
			HNFFHCLNBDN().SetFloat("_Value", HBJJOCHGOPH);
			ENKPNJMPDEB().SetFloat("fade in duration", Value);
			HEINDEMCGIK().SetFloat("_Value7", Value2);
			NDMPCDHADMJ().SetFloat("_Offsets", Intensity);
			NBPKMLMCHFN.SetFloat("_Bullet_7", CCIENBFIKKH);
			GKILCDHJFEG().SetVector(" / ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1588f, 1029f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LDDKCCMHMIC()
	{
	}

	private void FMFNILJIEIA()
	{
		SCShader = Shader.Find("_LightIntensity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AEEGKLABFLN()
	{
	}

	private void IEMEHGCFAPD()
	{
	}

	private void JONGNKNLLND()
	{
		SCShader = Shader.Find(".lastCheckpoint.incorrectScore");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PLEOOAJIMEE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 96f)
			{
				HBJJOCHGOPH = 1989f;
			}
			LNLKMDPHDCC().SetFloat("inventory.selected.", HBJJOCHGOPH);
			KEMJNOMIPHN().SetFloat("_DistortionSize", Value);
			KEMJNOMIPHN().SetFloat("_ScreenResolution", Value2);
			LMLENGFLEBD().SetFloat("mapselector.filter.subscribedonly", Intensity);
			KBOPGONOCNP().SetFloat(".completed", CCIENBFIKKH);
			FLOHGDECHHH().SetVector("workshop.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1683f, 1399f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIIDAKBILMI());
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material GKILCDHJFEG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void KLILJHJNICK()
	{
		SCShader = Shader.Find("ShowTitle");
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
			if (HBJJOCHGOPH > 1918f)
			{
				HBJJOCHGOPH = 751f;
			}
			CFEDGDGBCHE().SetFloat("_Threshhold", HBJJOCHGOPH);
			CECICEGFHKL().SetFloat(".sav", Value);
			ENKPNJMPDEB().SetFloat("[EditorEvent] Exception: ", Value2);
			GKILCDHJFEG().SetFloat("_ScreenResolution", Intensity);
			GKILCDHJFEG().SetFloat("_TileMaxOffs", CCIENBFIKKH);
			HKIMAANBGMJ().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1530f, 1374f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DBLILJGKGHJ()
	{
		SCShader = Shader.Find("EndlessLoopsScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BMIOFJFMCBG()
	{
		SCShader = Shader.Find("new round");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material DKNJGHFLAIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-124);
		}
		return BJFKDHHMLJH;
	}

	private void LEAHIBJDMBI()
	{
	}

	private void FBMDHDBELEK()
	{
	}

	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 641f)
			{
				HBJJOCHGOPH = 1909f;
			}
			NDMPCDHADMJ().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat("SetSatelliteTrailLength", Value);
			KGOLDDBHIFN().SetFloat(".jpg", Value2);
			GKILCDHJFEG().SetFloat("_ScreenResolution", Intensity);
			IIJMIPBMMBF().SetFloat("_VelocityScale", CCIENBFIKKH);
			NDMPCDHADMJ().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 605f, 1671f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material ENKPNJMPDEB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
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

	private void FGOPJMGNHGO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GNPDGBNDCPL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EIMNPCMHJLJ()
	{
		SCShader = Shader.Find("settings.enablehitsoundsinrelax");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LLDHEJIEDHO()
	{
	}

	private void KLOLKEBAPFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DHLCNIINMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 312f)
			{
				HBJJOCHGOPH = 408f;
			}
			HCGJCMDJPGD().SetFloat("DISTORT", HBJJOCHGOPH);
			NMDBCDFPGOK().SetFloat("_MainTex2", Value);
			DKNJGHFLAIF().SetFloat("http", Value2);
			KEMJNOMIPHN().SetFloat("ready", Intensity);
			GKILCDHJFEG().SetFloat("_DistortionWave", CCIENBFIKKH);
			KEMJNOMIPHN().SetVector("inventory.selected.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1505f, 1151f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HNFFHCLNBDN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 354f)
			{
				HBJJOCHGOPH = 1765f;
			}
			OIIDAKBILMI().SetFloat("CameraFilterPack/Oculus_NightVision1", HBJJOCHGOPH);
			FKEOGPDLBDD().SetFloat("_SunPosition", Value);
			GKILCDHJFEG().SetFloat("addNewButton", Value2);
			OIIDAKBILMI().SetFloat("SpectateButton", Intensity);
			EJDPNJAEAKJ().SetFloat("CameraFilterPack/Distortion_Aspiration", CCIENBFIKKH);
			LNLKMDPHDCC().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1901f, 298f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void COMNAPAAPDO()
	{
	}

	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 963f)
			{
				HBJJOCHGOPH = 1556f;
			}
			PEIMCBBHLBJ().SetFloat("arc", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("_ScreenResolution", Value);
			KBOPGONOCNP().SetFloat("IconFileSelector", Value2);
			NFKFAAHHLLM().SetFloat("_Distortion", Intensity);
			NFKFAAHHLLM().SetFloat("_ScreenResolution", CCIENBFIKKH);
			FKEOGPDLBDD().SetVector(" This is not possible to be called for standalone input. Please check your platform and code where this is called", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 166f, 487f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1730f)
			{
				HBJJOCHGOPH = 367f;
			}
			HNFFHCLNBDN().SetFloat("_EdgeSize", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("_ScreenResolution", Value);
			LMLENGFLEBD().SetFloat(",viewkeys", Value2);
			LMLENGFLEBD().SetFloat("ScoreText", Intensity);
			IIJMIPBMMBF().SetFloat("Item ", CCIENBFIKKH);
			OIIDAKBILMI().SetVector("mapselector.tags.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 755f, 921f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
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
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void KDMANOEMOCA()
	{
		SCShader = Shader.Find("_Threshold");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PKLOBJHKFEO()
	{
		SCShader = Shader.Find("<color=white>PhotonView Group: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material KGOLDDBHIFN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)72;
		}
		return BJFKDHHMLJH;
	}

	private void Update()
	{
	}

	private void KHIGHFJKPFG()
	{
		SCShader = Shader.Find("yyyy-MM-dd HH:mm:ss");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HLHJBJGEEEA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BMOFEBKGLFI()
	{
		SCShader = Shader.Find("_TapLow");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CNPINCHINJA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PHJLHCMCCKE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HDDECCMEJKA()
	{
	}

	private void CFFCLAHMBAA()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HOMNAHDDNHJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ALJEADNKJPO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material BAGICADFBAB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-88);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NDMPCDHADMJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void ILCFPCIPENO()
	{
		SCShader = Shader.Find("_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material IIJMIPBMMBF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HKIMAANBGMJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return BJFKDHHMLJH;
	}

	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1196f)
			{
				HBJJOCHGOPH = 1958f;
			}
			NJDIODJNGGA().SetFloat("_BorderColor", HBJJOCHGOPH);
			ENKPNJMPDEB().SetFloat("[MapsData] Caching ", Value);
			GKILCDHJFEG().SetFloat(".sav", Value2);
			NJDIODJNGGA().SetFloat("_Amount", Intensity);
			CFEDGDGBCHE().SetFloat("Set Sun MaxSize", CCIENBFIKKH);
			DKNJGHFLAIF().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1937f, 728f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			if (HBJJOCHGOPH > 282f)
			{
				HBJJOCHGOPH = 157f;
			}
			FKEOGPDLBDD().SetFloat("Oct", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("end", Value);
			HEINDEMCGIK().SetFloat("LevelInfoInputField", Value2);
			PEIMCBBHLBJ().SetFloat("FPSToggle", Intensity);
			NBPKMLMCHFN.SetFloat("PunRespawn", CCIENBFIKKH);
			HKHBBBFLGJH().SetVector("_History4ChromaTex", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1800f, 1758f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LBPCODPOJAH()
	{
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)84;
		}
		return BJFKDHHMLJH;
	}

	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1541f)
			{
				HBJJOCHGOPH = 647f;
			}
			KGOLDDBHIFN().SetFloat("ERROR", HBJJOCHGOPH);
			BAGICADFBAB().SetFloat("Received RPC \"", Value);
			NJDIODJNGGA().SetFloat("effector", Value2);
			NDMPCDHADMJ().SetFloat("_Saturation", Intensity);
			GKILCDHJFEG().SetFloat("settings.disablestoryboard", CCIENBFIKKH);
			NJDIODJNGGA().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1350f, 466f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1085f)
			{
				HBJJOCHGOPH = 1468f;
			}
			EJDPNJAEAKJ().SetFloat("workshop.", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("_ScreenResolution", Value);
			NDMPCDHADMJ().SetFloat("BadgeImage", Value2);
			NBPKMLMCHFN.SetFloat("[ItemsHandler] Found ", Intensity);
			EJDPNJAEAKJ().SetFloat("maps.", CCIENBFIKKH);
			IIJMIPBMMBF().SetVector("SlidingArea", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 437f, 1215f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
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
			if (HBJJOCHGOPH > 1328f)
			{
				HBJJOCHGOPH = 1759f;
			}
			GKILCDHJFEG().SetFloat("RECORD [R]", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("Tab1Content", Value);
			KBOPGONOCNP().SetFloat("ItemNameText", Value2);
			KGOLDDBHIFN().SetFloat("Source: ", Intensity);
			NMDBCDFPGOK().SetFloat("]", CCIENBFIKKH);
			HKIMAANBGMJ().SetVector("settings.enablehitsoundsinrelax", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1133f, 731f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IFJDKDFLGBG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IGPCNCJIEOJ()
	{
		SCShader = Shader.Find("SubmitUserVote:");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MFMIODIAKNI()
	{
	}
}
