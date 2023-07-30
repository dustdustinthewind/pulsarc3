// CameraFilterPack_TV_Tiles
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/TV/Tiles")]
public class CameraFilterPack_TV_Tiles : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0.5f, 2f)]
	public float Size = 1f;

	[Range(0f, 10f)]
	public float Intensity = 4f;

	[Range(0f, 1f)]
	public float StretchX = 0.6f;

	[Range(0f, 1f)]
	public float StretchY = 0.4f;

	[Range(0f, 1f)]
	public float Fade = 0.6f;

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
	private Material EMDFHOKEGNG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void MECJHOJPODB()
	{
	}

	[SpecialName]
	private Material OGMEGHKECAH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)106;
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

	private void FHPFJBFCOOF()
	{
		SCShader = Shader.Find("Error: I/O Failure! :(");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FDPOFMCFBMF()
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

	[SpecialName]
	private Material EPCGJFCCAFH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-121);
		}
		return BJFKDHHMLJH;
	}

	private void LLJLDLLNFBH()
	{
	}

	private void FANADGBGCPI()
	{
		SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ODAIMOJLJOF()
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
			NBPKMLMCHFN.SetFloat("_Value", Size);
			NBPKMLMCHFN.SetFloat("_Value2", Intensity);
			NBPKMLMCHFN.SetFloat("_Value3", StretchX);
			NBPKMLMCHFN.SetFloat("_Value4", StretchY);
			NBPKMLMCHFN.SetFloat("Fade", Fade);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1250f)
			{
				HBJJOCHGOPH = 528f;
			}
			HKGAONMOBMH().SetFloat("player.licenceaccepted", HBJJOCHGOPH);
			IIBLJCKLGFG().SetFloat("PhotonView ID duplicate found: {0}. New: {1} old: {2}. Maybe one wasn't destroyed on scene load?! Check for 'DontDestroyOnLoad'. Destroying old entry, adding new.", Size);
			GJHLADDCMFF().SetFloat("settings_bindings_sec_", Intensity);
			FEAEGGCNIAA().SetFloat("ControllerLeftY", StretchX);
			NBPKMLMCHFN.SetFloat("_Value4", StretchY);
			FEAEGGCNIAA().SetFloat("Items/", Fade);
			EPCGJFCCAFH().SetVector("seconds", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 631f, 652f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material FEAEGGCNIAA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void Update()
	{
	}

	[SpecialName]
	private Material GJHLADDCMFF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-105);
		}
		return BJFKDHHMLJH;
	}

	private void MAOCOEGAFND()
	{
	}

	private void ILCFPCIPENO()
	{
		SCShader = Shader.Find("_DistortionWave");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void POIMNOBDBBN()
	{
	}

	[SpecialName]
	private Material OKJOKHGJHGF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-70);
		}
		return BJFKDHHMLJH;
	}

	private void EPEGAEGDJAM()
	{
		SCShader = Shader.Find("LevelEditor/CustomEventEditor-Text");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CNGAJDBOCLJ()
	{
		SCShader = Shader.Find("_Gain");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DLMPALHKMON()
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
			if (HBJJOCHGOPH > 1760f)
			{
				HBJJOCHGOPH = 1508f;
			}
			FEAEGGCNIAA().SetFloat("settings.disablestoryboard", HBJJOCHGOPH);
			JIBOKBCPDLC().SetFloat("<b>", Size);
			OIMMPLPBLBK().SetFloat("_Value5", Intensity);
			IIBLJCKLGFG().SetFloat("checkpoint", StretchX);
			NBMPPNFKFLB().SetFloat("LeaderboardsButton", StretchY);
			GJHLADDCMFF().SetFloat("[MapEditor] Updating top menu", Fade);
			OKJOKHGJHGF().SetVector("z", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1959f, 1059f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OIBMHPIFAKK()
	{
	}

	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1986f)
			{
				HBJJOCHGOPH = 1973f;
			}
			EPCGJFCCAFH().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("_Value4", Size);
			EPCGJFCCAFH().SetFloat("_SpotSize", Intensity);
			GJHLADDCMFF().SetFloat("DisableStoryboardToggle", StretchX);
			EPCGJFCCAFH().SetFloat("_CenterX", StretchY);
			HKGAONMOBMH().SetFloat("GlassesColor2", Fade);
			GJHLADDCMFF().SetVector(" not found", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1384f, 1779f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MMOKKAPFGAK()
	{
		SCShader = Shader.Find("LevelEditor/CustomEventEditor-");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 274f)
			{
				HBJJOCHGOPH = 815f;
			}
			IIBLJCKLGFG().SetFloat("_CenterX", HBJJOCHGOPH);
			HKGAONMOBMH().SetFloat("ArcsDestroyDelaySlider", Size);
			EMDFHOKEGNG().SetFloat("ConnectionTimeout", Intensity);
			NBMPPNFKFLB().SetFloat("event", StretchX);
			OGMEGHKECAH().SetFloat("challengeid", StretchY);
			EMDFHOKEGNG().SetFloat("_ScreenResolution", Fade);
			OIMMPLPBLBK().SetVector("#challengecomplete", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1175f, 695f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material JIBOKBCPDLC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-123);
		}
		return BJFKDHHMLJH;
	}

	private void BFEILOMHNPC()
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
			BJFKDHHMLJH.hideFlags = (HideFlags)66;
		}
		return BJFKDHHMLJH;
	}

	private void NCNPAKFAFOE()
	{
		SCShader = Shader.Find("grid");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ONMGIPAILOH()
	{
	}

	private void FKEJGBFDCAH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CFIAKIJAILI()
	{
	}

	[SpecialName]
	private Material OIMMPLPBLBK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)94;
		}
		return BJFKDHHMLJH;
	}

	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 345f)
			{
				HBJJOCHGOPH = 1675f;
			}
			EPCGJFCCAFH().SetFloat("Object ID. Case-Sensitive", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat(". Set PhotonNetwork.OnEventCall.", Size);
			DNLMFEGJJDD().SetFloat("_Value", Intensity);
			IIBLJCKLGFG().SetFloat("IntraTime", StretchX);
			HKGAONMOBMH().SetFloat("[LocalizationService] Loading file: ", StretchY);
			DNLMFEGJJDD().SetFloat("ArcsDestroyDelaySlider", Fade);
			IIBLJCKLGFG().SetVector("note.6", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1897f, 489f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GKNKIIEALCH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IMCKJCHKMKB()
	{
		SCShader = Shader.Find("settings.selectormapsperpage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OFPPIKHNJOD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EFJDNLGNACH()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MMMDPANNAIO()
	{
		SCShader = Shader.Find("}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CHOPDIGHJNH()
	{
		SCShader = Shader.Find("<not connected>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EHCGBJDFMHG()
	{
	}

	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 611f)
			{
				HBJJOCHGOPH = 62f;
			}
			JIBOKBCPDLC().SetFloat("JoinRandom failed: No open game. Calling: OnPhotonRandomJoinFailed() and staying on master server.", HBJJOCHGOPH);
			OKJOKHGJHGF().SetFloat("_Value5", Size);
			OIMMPLPBLBK().SetFloat("_Value", Intensity);
			NBPKMLMCHFN.SetFloat(",", StretchX);
			JIBOKBCPDLC().SetFloat("_Near", StretchY);
			HKGAONMOBMH().SetFloat("_ScreenResolution", Fade);
			EMDFHOKEGNG().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1578f, 1227f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material NBMPPNFKFLB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void NPLCENPNJBM()
	{
		SCShader = Shader.Find("Mouse2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 409f)
			{
				HBJJOCHGOPH = 1039f;
			}
			OKJOKHGJHGF().SetFloat("_Value4", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("BloodAlternative1", Size);
			HKGAONMOBMH().SetFloat("_Value", Intensity);
			FEAEGGCNIAA().SetFloat("#mapalreadyexistupdate", StretchX);
			JIBOKBCPDLC().SetFloat("_ScreenResolution", StretchY);
			JIBOKBCPDLC().SetFloat("CameraFilterPack/Drawing_Manga4", Fade);
			EPCGJFCCAFH().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 705f, 1159f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MGFFNGEGFDC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JOPCCCCHNLI()
	{
		SCShader = Shader.Find("ViewID {0} {1}{2}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1595f)
			{
				HBJJOCHGOPH = 444f;
			}
			EPCGJFCCAFH().SetFloat("_Value2", HBJJOCHGOPH);
			GJHLADDCMFF().SetFloat("Joystick1Button5", Size);
			NBPKMLMCHFN.SetFloat("Left Click", Intensity);
			OKJOKHGJHGF().SetFloat("_TimeX", StretchX);
			NBPKMLMCHFN.SetFloat("_TimeX", StretchY);
			OIMMPLPBLBK().SetFloat("Scene", Fade);
			IIBLJCKLGFG().SetVector("Already exist!", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 771f, 101f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FJIKDJAMOHA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AEIJFLJEABG()
	{
	}

	private void FIKFJDFELIP()
	{
		SCShader = Shader.Find("#close");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1898f)
			{
				HBJJOCHGOPH = 1399f;
			}
			IIBLJCKLGFG().SetFloat(", ", HBJJOCHGOPH);
			HKGAONMOBMH().SetFloat("_SpherePositionX", Size);
			OGMEGHKECAH().SetFloat("_TimeX", Intensity);
			IIBLJCKLGFG().SetFloat(" - StoreAuthURLResponse] - ", StretchX);
			GJHLADDCMFF().SetFloat("steamid", StretchY);
			FEAEGGCNIAA().SetFloat("_Value4", Fade);
			OIMMPLPBLBK().SetVector("custom", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1866f, 1350f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NJHJHBOJKIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EJJEDJIOFAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/TV_Tiles");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JILOMOBDPIA()
	{
		SCShader = Shader.Find("_Params2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ALMGMOOHLMA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LECCHIAFGGE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material DNLMFEGJJDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 529f)
			{
				HBJJOCHGOPH = 406f;
			}
			NBPKMLMCHFN.SetFloat("Hex value #RRGGBB", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("inventory.selected.", Size);
			NBPKMLMCHFN.SetFloat("IncorrectHitsScoreText", Intensity);
			OIMMPLPBLBK().SetFloat("_BlurRadius4", StretchX);
			DNLMFEGJJDD().SetFloat("note.0", StretchY);
			NBMPPNFKFLB().SetFloat("#no", Fade);
			OKJOKHGJHGF().SetVector("_ForegroundBlurExtrude", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 317f, 395f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material IIBLJCKLGFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-94);
		}
		return BJFKDHHMLJH;
	}

	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 365f)
			{
				HBJJOCHGOPH = 370f;
			}
			OKJOKHGJHGF().SetFloat("MapConfig", HBJJOCHGOPH);
			OKJOKHGJHGF().SetFloat("CameraFilterPack/Colors_Threshold", Size);
			FEAEGGCNIAA().SetFloat("FullscreenToggle", Intensity);
			OGMEGHKECAH().SetFloat("_Far", StretchX);
			HKGAONMOBMH().SetFloat("_ToneCurve", StretchY);
			IIBLJCKLGFG().SetFloat("L2", Fade);
			HKGAONMOBMH().SetVector("CameraFilterPack_Glasses_On6", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 468f, 1302f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JHLGHODFJOO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}
}
