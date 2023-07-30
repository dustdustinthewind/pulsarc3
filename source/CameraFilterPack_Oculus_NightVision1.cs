// CameraFilterPack_Oculus_NightVision1
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Night Vision/Night Vision 1")]
[ExecuteInEditMode]
public class CameraFilterPack_Oculus_NightVision1 : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private float GAMMLIDAPPF = 1f;

	private Material BJFKDHHMLJH;

	private Vector4 GOIJPFAHKPE;

	[Range(0f, 100f)]
	public float Vignette = 1.3f;

	[Range(1f, 150f)]
	public float Linecount = 90f;

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

	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1589f)
			{
				HBJJOCHGOPH = 1695f;
			}
			OIMMPLPBLBK().SetFloat("_TimeX", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("Couldn't call DestroyAll() as only the master client is allowed to call this.", GAMMLIDAPPF);
			NJDIODJNGGA().SetVector("\\[ *im.*\\](\\n\\n\\n|\\n\\n|\\n|)", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 901f, 362f));
			CFEDGDGBCHE().SetFloat("curScn", Vignette);
			MCDGIILBNIF().SetFloat("workshop.", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CIPKEPDELJB()
	{
		SCShader = Shader.Find("open");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material HCGJCMDJPGD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void HAIAHJPCPAG()
	{
		SCShader = Shader.Find("RenderTextureUtilityTempTexture");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1759f)
			{
				HBJJOCHGOPH = 1989f;
			}
			CFEDGDGBCHE().SetFloat("#finished", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("[Up]", GAMMLIDAPPF);
			GKILCDHJFEG().SetVector("recipes", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 593f, 1843f));
			FAIFBBGFAIB().SetFloat("_BaseTex", Vignette);
			NFMGLIKNOOC().SetFloat("Joystick1Button10", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FOMNCPKKCFN()
	{
	}

	private void Update()
	{
	}

	private void EJJEDJIOFAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KLILJHJNICK()
	{
		SCShader = Shader.Find("CameraFilterPack/Blend2Camera_Darken");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material GKILCDHJFEG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void JOACBIEHHCE()
	{
	}

	private void IEMEHGCFAPD()
	{
	}

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 144f)
			{
				HBJJOCHGOPH = 158f;
			}
			CFEDGDGBCHE().SetFloat("_Value", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("_ScreenResolution", GAMMLIDAPPF);
			NJDIODJNGGA().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1775f, 987f));
			DNLMFEGJJDD().SetFloat("Player", Vignette);
			FAIFBBGFAIB().SetFloat("DifficultyBG", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DBOLLHHMKKN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.DontSave;
		}
		return BJFKDHHMLJH;
	}

	private void POJFHDFJOPE()
	{
	}

	private void DKOPKPBLDHH()
	{
		SCShader = Shader.Find("Environment/SunBase_");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1765f)
			{
				HBJJOCHGOPH = 1692f;
			}
			OIIDAKBILMI().SetFloat("The given 2D texture ", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("_Value5", GAMMLIDAPPF);
			DNLMFEGJJDD().SetVector("_Alpha2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 413f, 925f));
			FAIFBBGFAIB().SetFloat("yyyy-MM-dd HH:mm:ss", Vignette);
			MCDGIILBNIF().SetFloat("LoadMapCanvas", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MPJCMKFFKHH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1827f)
			{
				HBJJOCHGOPH = 757f;
			}
			OIIDAKBILMI().SetFloat("_Intensity", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("_Offsets", GAMMLIDAPPF);
			CFEDGDGBCHE().SetVector("_FixDistance", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 139f, 11f));
			OIIDAKBILMI().SetFloat(" canvas not found", Vignette);
			CFEDGDGBCHE().SetFloat("_Value", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ANCKKLFPGDI()
	{
		SCShader = Shader.Find("ItemTemplate");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 45f)
			{
				HBJJOCHGOPH = 1243f;
			}
			HCGJCMDJPGD().SetFloat("set id", HBJJOCHGOPH);
			IGIAPKPKGPK().SetFloat("isVisible", GAMMLIDAPPF);
			OIIDAKBILMI().SetVector("_MainTex2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1910f, 1594f));
			MCDGIILBNIF().SetFloat("(((?<x>(?=[,\\r\\n]+))|\"(?<x>([^\"]|\"\")+)\"|(?<x>[^,\\r\\n]+)),?)", Vignette);
			IGIAPKPKGPK().SetFloat("AddEnvironmentObject", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1360f)
			{
				HBJJOCHGOPH = 145f;
			}
			OIMMPLPBLBK().SetFloat("_LowRez", HBJJOCHGOPH);
			IGIAPKPKGPK().SetFloat("maphash", GAMMLIDAPPF);
			OIIDAKBILMI().SetVector(" to ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1915f, 1229f));
			OIIDAKBILMI().SetFloat("RarityImage", Vignette);
			NBPKMLMCHFN.SetFloat("AskForPickupItemSpawnTimes", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JOONHGHGKKF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 598f)
			{
				HBJJOCHGOPH = 1182f;
			}
			HCGJCMDJPGD().SetFloat("BackButton", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("PLEASE WAIT", GAMMLIDAPPF);
			DBOLLHHMKKN().SetVector("CameraFilterPack/Blend2Camera_Darken", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1927f, 893f));
			FAIFBBGFAIB().SetFloat("_Green_G", Vignette);
			OIIDAKBILMI().SetFloat("AskForPickupItemSpawnTimes", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LCDJFJIBADI()
	{
	}

	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1761f)
			{
				HBJJOCHGOPH = 1822f;
			}
			MLMKCOINOOH().SetFloat("Children", HBJJOCHGOPH);
			IGIAPKPKGPK().SetFloat("_ScreenResolution", GAMMLIDAPPF);
			HCGJCMDJPGD().SetVector("If you host Photon yourself, make sure to start the 'Instance LoadBalancing' ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1679f, 102f));
			HCGJCMDJPGD().SetFloat("visible", Vignette);
			DBOLLHHMKKN().SetFloat("_Value7", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BGDPIHMAACO()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HDMDKOKOOJC()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NEKCPLGFOFD()
	{
	}

	private void PKLOBJHKFEO()
	{
		SCShader = Shader.Find("Bad parameters for reset! Use \"reset <challengeid>\"");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material CFEDGDGBCHE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-97);
		}
		return BJFKDHHMLJH;
	}

	private void MJNPIDGNJMK()
	{
	}

	[SpecialName]
	private Material MCDGIILBNIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)75;
		}
		return BJFKDHHMLJH;
	}

	private void HLLHJIDOOGA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 128f)
			{
				HBJJOCHGOPH = 437f;
			}
			KBOPGONOCNP().SetFloat(".completed", HBJJOCHGOPH);
			MMOODGIODPC().SetFloat("_Green_B", GAMMLIDAPPF);
			MCDGIILBNIF().SetVector("score", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 131f, 45f));
			OIMMPLPBLBK().SetFloat("ok", Vignette);
			OIIDAKBILMI().SetFloat("_SSAO", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)78;
		}
		return BJFKDHHMLJH;
	}

	private void ICDBMJKMIKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LBPHCAMMAPB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AIJGAJIOJDJ()
	{
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)97;
		}
		return BJFKDHHMLJH;
	}

	private void DBLILJGKGHJ()
	{
		SCShader = Shader.Find("_FixDistance");
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

	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1231f)
			{
				HBJJOCHGOPH = 868f;
			}
			DNLMFEGJJDD().SetFloat(".lastCheckpoint.perfectHits", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("null", GAMMLIDAPPF);
			OIIDAKBILMI().SetVector("COMPLETED", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1554f, 325f));
			KBOPGONOCNP().SetFloat("Done! You are a contributor until: ", Vignette);
			NBPKMLMCHFN.SetFloat("#onfirstranktext", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
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

	private void JECMJNFGBGC()
	{
		SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OPCLBGHAPMG()
	{
	}

	private void MNBPNHNAEBK()
	{
		SCShader = Shader.Find("Texture2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1871f)
			{
				HBJJOCHGOPH = 40f;
			}
			FAIFBBGFAIB().SetFloat("yes", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("CameraFilterPack/TV_CompressionFX", GAMMLIDAPPF);
			CFEDGDGBCHE().SetVector("_DiffuseColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 194f, 650f));
			KBOPGONOCNP().SetFloat("No Description", Vignette);
			FAIFBBGFAIB().SetFloat("_MainTex2", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NFEDLAOPHML()
	{
	}

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1453f)
			{
				HBJJOCHGOPH = 463f;
			}
			NBPKMLMCHFN.SetFloat("Scrollbar", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat(" is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package.", GAMMLIDAPPF);
			MLMKCOINOOH().SetVector("Error: You're not logged into Steam!", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1128f, 1619f));
			DBOLLHHMKKN().SetFloat("_Value", Vignette);
			MMOODGIODPC().SetFloat("Created", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DGCGGKMNPLD()
	{
	}

	[SpecialName]
	private Material IGIAPKPKGPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-87);
		}
		return BJFKDHHMLJH;
	}

	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 545f)
			{
				HBJJOCHGOPH = 1311f;
			}
			HCGJCMDJPGD().SetFloat("ticket", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("CameraFilterPack_TV_Arcade1", GAMMLIDAPPF);
			DNLMFEGJJDD().SetVector("Can't set MaxPlayers when not in that room.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 126f, 516f));
			LONNIJMNKFB().SetFloat("_CutOff", Vignette);
			NFMGLIKNOOC().SetFloat("_FixDistance", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KCCIEMBMOBA()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 361f)
			{
				HBJJOCHGOPH = 1018f;
			}
			FAIFBBGFAIB().SetFloat("GhostFade", HBJJOCHGOPH);
			MLMKCOINOOH().SetFloat("Cancel", GAMMLIDAPPF);
			OIIDAKBILMI().SetVector("_Value4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 532f, 221f));
			KBOPGONOCNP().SetFloat("CameraFilterPack/Blend2Camera_Divide", Vignette);
			HCGJCMDJPGD().SetFloat("#tryagain", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CGBHOELMAOC()
	{
	}

	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1025f)
			{
				HBJJOCHGOPH = 1135f;
			}
			DBOLLHHMKKN().SetFloat("CameraFilterPack/Glasses_On", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Set particles count per one beat", GAMMLIDAPPF);
			MLMKCOINOOH().SetVector("_Red_C", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1657f, 294f));
			NJDIODJNGGA().SetFloat("Scrollbar", Vignette);
			LONNIJMNKFB().SetFloat(":", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return BJFKDHHMLJH;
	}

	private void DIPDEHOOBPG()
	{
		SCShader = Shader.Find("|");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OHFOLGANOLC()
	{
		SCShader = Shader.Find("Tab1Content");
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
			BJFKDHHMLJH.hideFlags = ~HideFlags.HideAndDontSave;
		}
		return BJFKDHHMLJH;
	}

	private void JNGMIAFLBDL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 486f)
			{
				HBJJOCHGOPH = 1491f;
			}
			CFEDGDGBCHE().SetFloat("_Saturation", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value6", GAMMLIDAPPF);
			NFMGLIKNOOC().SetVector("Working commands:\nreset <challengeid>\nresetall", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1094f, 632f));
			MMOODGIODPC().SetFloat("Mouse0", Vignette);
			LONNIJMNKFB().SetFloat("_MatrixColor", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HJPCJGOEKMF()
	{
		SCShader = Shader.Find("menutheme.jamaicanorcdub");
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
			if (HBJJOCHGOPH > 1967f)
			{
				HBJJOCHGOPH = 609f;
			}
			IGIAPKPKGPK().SetFloat("_Fade", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("ViewMenu", GAMMLIDAPPF);
			LONNIJMNKFB().SetVector("_Distortion", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1487f, 238f));
			KBOPGONOCNP().SetFloat("_Distortion", Vignette);
			FAIFBBGFAIB().SetFloat("AreaTex", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1939f)
			{
				HBJJOCHGOPH = 212f;
			}
			KBOPGONOCNP().SetFloat("element", HBJJOCHGOPH);
			MMOODGIODPC().SetFloat(" : ", GAMMLIDAPPF);
			NFMGLIKNOOC().SetVector(":", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 233f, 86f));
			IGIAPKPKGPK().SetFloat("_Value12", Vignette);
			IGIAPKPKGPK().SetFloat("<b>", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FANADGBGCPI()
	{
		SCShader = Shader.Find("Tab2Content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JILOMOBDPIA()
	{
		SCShader = Shader.Find("event");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1636f)
			{
				HBJJOCHGOPH = 1334f;
			}
			HCGJCMDJPGD().SetFloat("_TimeX", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("System.Int32", GAMMLIDAPPF);
			MCDGIILBNIF().SetVector("[FileSelector] Dialog canceled", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1333f, 917f));
			CFEDGDGBCHE().SetFloat("HitVariationSlider", Vignette);
			KBOPGONOCNP().SetFloat("request", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DNLMFEGJJDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)107;
		}
		return BJFKDHHMLJH;
	}

	private void LDDKCCMHMIC()
	{
	}

	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 485f)
			{
				HBJJOCHGOPH = 214f;
			}
			DBOLLHHMKKN().SetFloat("[PlayerBase] Loading checkpoint data", HBJJOCHGOPH);
			MLMKCOINOOH().SetFloat("/", GAMMLIDAPPF);
			MLMKCOINOOH().SetVector("Add Environment Sprite", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 419f, 533f));
			CFEDGDGBCHE().SetFloat("_ScreenResolution", Vignette);
			DNLMFEGJJDD().SetFloat("float,1", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AEIJFLJEABG()
	{
	}

	private void MGMAOBPPOBJ()
	{
		SCShader = Shader.Find("shader.frost");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FKEJGBFDCAH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DNENFLNCIJP()
	{
	}

	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1924f)
			{
				HBJJOCHGOPH = 535f;
			}
			HCGJCMDJPGD().SetFloat("[LevelEditorScene] Error: You're not logged into Steam!", HBJJOCHGOPH);
			NJDIODJNGGA().SetFloat(":", GAMMLIDAPPF);
			GKILCDHJFEG().SetVector("RecieveChatActionMessage", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 342f, 1583f));
			OIIDAKBILMI().SetFloat("ComboScoreText", Vignette);
			NBPKMLMCHFN.SetFloat("Joined Room. isMasterClient: ", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PMPKMGKAAJH()
	{
		SCShader = Shader.Find("#EA4137");
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
			NBPKMLMCHFN.SetFloat("_Distortion", GAMMLIDAPPF);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			NBPKMLMCHFN.SetFloat("_Vignette", Vignette);
			NBPKMLMCHFN.SetFloat("_Linecount", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NDAJBJFJGCF()
	{
	}

	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 979f)
			{
				HBJJOCHGOPH = 1584f;
			}
			LONNIJMNKFB().SetFloat("[LevelEditorScene] Error: I/O Failure! :(", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("CameraFilterPack/Color_Noise", GAMMLIDAPPF);
			GKILCDHJFEG().SetVector("_DistortionSize", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 915f, 792f));
			HCGJCMDJPGD().SetFloat("_Value2", Vignette);
			DBOLLHHMKKN().SetFloat("_TimeX", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material FAIFBBGFAIB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)126;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NJDIODJNGGA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-1);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material OIIDAKBILMI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-118);
		}
		return BJFKDHHMLJH;
	}

	private void PBEPCAPAKLG()
	{
	}

	private void IHLMNAGPKDA()
	{
		SCShader = Shader.Find("...");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KFEKCJDEECK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material MLMKCOINOOH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Oculus_NightVision1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 184f)
			{
				HBJJOCHGOPH = 1017f;
			}
			DNLMFEGJJDD().SetFloat("TwoHands", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("/", GAMMLIDAPPF);
			DNLMFEGJJDD().SetVector("<start_index> <end_index>", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1490f, 638f));
			LONNIJMNKFB().SetFloat(" Loaded: ", Vignette);
			DNLMFEGJJDD().SetFloat("_Value4", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 936f)
			{
				HBJJOCHGOPH = 969f;
			}
			GKILCDHJFEG().SetFloat("Scene", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat("_DistAmount", GAMMLIDAPPF);
			NFMGLIKNOOC().SetVector("PunSupportLogger", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1317f, 1362f));
			NJDIODJNGGA().SetFloat("_MainTex", Vignette);
			NBPKMLMCHFN.SetFloat("setAF", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KLOLKEBAPFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material MMOODGIODPC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)101;
		}
		return BJFKDHHMLJH;
	}

	private void OCCGJMPAJIK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1003f)
			{
				HBJJOCHGOPH = 515f;
			}
			DBOLLHHMKKN().SetFloat("_Value", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("11", GAMMLIDAPPF);
			MLMKCOINOOH().SetVector("ItemsCountText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 615f, 1793f));
			KBOPGONOCNP().SetFloat("In Network lobby", Vignette);
			NJDIODJNGGA().SetFloat("_TimeX", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
