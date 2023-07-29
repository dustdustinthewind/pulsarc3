// CameraFilterPack_TV_Tiles
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/TV/Tiles")]
[ExecuteInEditMode]
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
		SCShader = Shader.Find("Item creation successful! Published Item ID: ");
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
			FEAEGGCNIAA().SetFloat("[LevelEditorScene] Error: I/O Failure! :(", HBJJOCHGOPH);
			FEAEGGCNIAA().SetFloat("Cannot remove cached RPCs on a PhotonView thats not ours! ", Size);
			FEAEGGCNIAA().SetFloat("The binding '", Intensity);
			OKJOKHGJHGF().SetFloat("PRESS A KEY", StretchX);
			IIBLJCKLGFG().SetFloat("_ScreenResolution", StretchY);
			EPCGJFCCAFH().SetFloat("Items/", Fade);
			OKJOKHGJHGF().SetVector("float,0.5", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 631f, 652f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHLADDCMFF());
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
		SCShader = Shader.Find("_Wavy");
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
		SCShader = Shader.Find(",");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CNGAJDBOCLJ()
	{
		SCShader = Shader.Find("_ScreenResolution");
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
			JIBOKBCPDLC().SetFloat("settings.disablestoryboard", HBJJOCHGOPH);
			FEAEGGCNIAA().SetFloat("#activechallenges", Size);
			DNLMFEGJJDD().SetFloat("_ScreenResolution", Intensity);
			EPCGJFCCAFH().SetFloat("Added event", StretchX);
			IIBLJCKLGFG().SetFloat("LeaderboardsButton", StretchY);
			OIMMPLPBLBK().SetFloat("/", Fade);
			IIBLJCKLGFG().SetVector("float,0", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1959f, 1059f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
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
			DNLMFEGJJDD().SetFloat("CameraFilterPack/TV_CompressionFX", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("_Value4", Size);
			JIBOKBCPDLC().SetFloat("_SpotSize", Intensity);
			NBPKMLMCHFN.SetFloat("DisableStoryboardToggle", StretchX);
			GJHLADDCMFF().SetFloat("_CenterY", StretchY);
			OIMMPLPBLBK().SetFloat("GlassColor", Fade);
			OKJOKHGJHGF().SetVector("bool", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1384f, 1779f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MMOKKAPFGAK()
	{
		SCShader = Shader.Find("EventTimeInputField");
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
			DNLMFEGJJDD().SetFloat("_CenterX", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("settings.arcsdestroydelay", Size);
			OGMEGHKECAH().SetFloat(".png", Intensity);
			OGMEGHKECAH().SetFloat("OneHand", StretchX);
			NBPKMLMCHFN.SetFloat("IntraTime", StretchY);
			OGMEGHKECAH().SetFloat("CameraFilterPack/Gradients_Tech", Fade);
			IIBLJCKLGFG().SetVector("<command>", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1175f, 695f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
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
			HKGAONMOBMH().SetFloat("value", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("SetupEncryption() got called. ", Size);
			JIBOKBCPDLC().SetFloat("_ScreenResolution", Intensity);
			OKJOKHGJHGF().SetFloat("#tryagain", StretchX);
			EMDFHOKEGNG().SetFloat("#", StretchY);
			OIMMPLPBLBK().SetFloat("ArcsDestroyDelaySlider", Fade);
			OIMMPLPBLBK().SetVector("settings.cameramovements", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1897f, 489f));
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
		SCShader = Shader.Find("#mapby");
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
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MMMDPANNAIO()
	{
		SCShader = Shader.Find("Horizontal");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CHOPDIGHJNH()
	{
		SCShader = Shader.Find("Setting autoCleanUpPlayerObjects while in a room is not supported.");
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
			IIBLJCKLGFG().SetFloat("FindFriends failed to apply the result, as a required value wasn't provided or the friend list length differed from result.", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("_Value5", Size);
			HKGAONMOBMH().SetFloat("_Value", Intensity);
			NBPKMLMCHFN.SetFloat(".status", StretchX);
			OKJOKHGJHGF().SetFloat("_Near", StretchY);
			IIBLJCKLGFG().SetFloat("CameraFilterPack/Drawing_Manga_FlashWhite", Fade);
			NBPKMLMCHFN.SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1578f, 1227f));
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
		SCShader = Shader.Find("Middle Click");
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
			JIBOKBCPDLC().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			EMDFHOKEGNG().SetFloat("BloodAlternative3", Size);
			OGMEGHKECAH().SetFloat("_Value", Intensity);
			EPCGJFCCAFH().SetFloat("#creatingnewitem", StretchX);
			GJHLADDCMFF().SetFloat("CameraFilterPack/Edge_Sobel", StretchY);
			GJHLADDCMFF().SetFloat("CameraFilterPack/Drawing_Manga4", Fade);
			OGMEGHKECAH().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 705f, 1159f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHLADDCMFF());
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
		SCShader = Shader.Find("owner: ");
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
			OKJOKHGJHGF().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			OKJOKHGJHGF().SetFloat("R1", Size);
			HKGAONMOBMH().SetFloat("Mouse1", Intensity);
			OKJOKHGJHGF().SetFloat("_Value", StretchX);
			HKGAONMOBMH().SetFloat("_Value", StretchY);
			NBPKMLMCHFN.SetFloat("GameVolumeSlider", Fade);
			NBPKMLMCHFN.SetVector("Already exist!", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 771f, 101f));
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
		SCShader = Shader.Find("error");
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
			OGMEGHKECAH().SetFloat("offline", HBJJOCHGOPH);
			GJHLADDCMFF().SetFloat("_SpherePositionY", Size);
			JIBOKBCPDLC().SetFloat("_Value", Intensity);
			EMDFHOKEGNG().SetFloat("error", StretchX);
			NBMPPNFKFLB().SetFloat("https://api.steampowered.com/IInventoryService/AddItem/v001", StretchY);
			JIBOKBCPDLC().SetFloat("_ScreenResolution", Fade);
			HKGAONMOBMH().SetVector("[PlayerBase] Loaded environment: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1866f, 1350f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
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
		SCShader = Shader.Find("_SubsampleIndices");
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
			FEAEGGCNIAA().SetFloat("Set satellite color", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("inventory.selected.", Size);
			EMDFHOKEGNG().SetFloat("ComboScoreText", Intensity);
			FEAEGGCNIAA().SetFloat("_SunThreshold", StretchX);
			IIBLJCKLGFG().SetFloat("note.4", StretchY);
			GJHLADDCMFF().SetFloat("#savemapchanges?", Fade);
			OIMMPLPBLBK().SetVector("_InvRenderTargetSize", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 317f, 395f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIBLJCKLGFG());
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
			OKJOKHGJHGF().SetFloat("--------------------------------", HBJJOCHGOPH);
			OKJOKHGJHGF().SetFloat("_TimeX", Size);
			HKGAONMOBMH().SetFloat("FullscreenToggle", Intensity);
			IIBLJCKLGFG().SetFloat("_Far", StretchX);
			NBPKMLMCHFN.SetFloat("_NeutralTonemapperParams2", StretchY);
			OGMEGHKECAH().SetFloat("Joystick1Button7", Fade);
			IIBLJCKLGFG().SetVector("CameraFilterPack/Glasses_On", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 468f, 1302f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
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
