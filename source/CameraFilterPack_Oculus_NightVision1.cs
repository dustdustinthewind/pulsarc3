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
			CFEDGDGBCHE().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("\" gets executed locally only, if at all.", GAMMLIDAPPF);
			IGIAPKPKGPK().SetVector("\\[ *im.*\\](\\n\\n\\n|\\n\\n|\\n|)", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 901f, 362f));
			MMOODGIODPC().SetFloat("curScn", Vignette);
			OIIDAKBILMI().SetFloat("workshop.", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CIPKEPDELJB()
	{
		SCShader = Shader.Find("'{0}' \t{1}ms \t{2}");
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
		SCShader = Shader.Find("Hidden/DepthOfField/DepthOfField");
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
			LONNIJMNKFB().SetFloat("http", HBJJOCHGOPH);
			NJDIODJNGGA().SetFloat("[PlayerBase] Ready", GAMMLIDAPPF);
			OIMMPLPBLBK().SetVector("#random #rare #item", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 593f, 1843f));
			IGIAPKPKGPK().SetFloat("Missing shader for image effect {0}", Vignette);
			NBPKMLMCHFN.SetFloat("Left Stick Click", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
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
		SCShader = Shader.Find("CameraFilterPack/Blend2Camera_Multiply");
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
			FAIFBBGFAIB().SetFloat("_Value", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Drawing_Comics", GAMMLIDAPPF);
			CFEDGDGBCHE().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1775f, 987f));
			MMOODGIODPC().SetFloat("[MenuScene] Error: ", Vignette);
			LONNIJMNKFB().SetFloat("InfoCanvas", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
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
		SCShader = Shader.Find("Crosshair1");
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
			CFEDGDGBCHE().SetFloat(" cannot be used as a 3D LUT.", HBJJOCHGOPH);
			OIIDAKBILMI().SetFloat("_Value6", GAMMLIDAPPF);
			MMOODGIODPC().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 413f, 925f));
			IGIAPKPKGPK().SetFloat("#,0.00", Vignette);
			DBOLLHHMKKN().SetFloat("MusicFileSelector", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			DNLMFEGJJDD().SetFloat("_Axis", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("pointBuffer", GAMMLIDAPPF);
			OIMMPLPBLBK().SetVector("_FixDistance", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 139f, 11f));
			MMOODGIODPC().SetFloat(" canvas not found", Vignette);
			NFMGLIKNOOC().SetFloat("_Value2", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ANCKKLFPGDI()
	{
		SCShader = Shader.Find("Item ");
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
			HCGJCMDJPGD().SetFloat("Case-Sensitive", HBJJOCHGOPH);
			OIIDAKBILMI().SetFloat("isVisible", GAMMLIDAPPF);
			OIMMPLPBLBK().SetVector("_MainTex2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1910f, 1594f));
			KBOPGONOCNP().SetFloat("en", Vignette);
			OIIDAKBILMI().SetFloat("Add Environment Object", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MLMKCOINOOH());
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
			LONNIJMNKFB().SetFloat("_Offsets", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("maxScore", GAMMLIDAPPF);
			MLMKCOINOOH().SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1915f, 1229f));
			OIMMPLPBLBK().SetFloat("ItemNameText", Vignette);
			NJDIODJNGGA().SetFloat("RequestForPickupItems", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIIDAKBILMI());
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
			MCDGIILBNIF().SetFloat("BackButton", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("PLEASE WAIT", GAMMLIDAPPF);
			DNLMFEGJJDD().SetVector("CameraFilterPack/Blend2Camera_Darken", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1927f, 893f));
			MLMKCOINOOH().SetFloat("_Green_G", Vignette);
			MLMKCOINOOH().SetFloat("No player left to ask", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MLMKCOINOOH());
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
			CFEDGDGBCHE().SetFloat("Children", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("CameraFilterPack/Distortion_BlackHole", GAMMLIDAPPF);
			IGIAPKPKGPK().SetVector("Authentication failed: '{0}' Code: {1}", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1679f, 102f));
			MMOODGIODPC().SetFloat("open", Vignette);
			CFEDGDGBCHE().SetFloat("_Value7", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGIAPKPKGPK());
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
		SCShader = Shader.Find("_TimeX");
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
		SCShader = Shader.Find("challenges.");
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
			IGIAPKPKGPK().SetFloat("[MapsData] Bad map: ", HBJJOCHGOPH);
			OIIDAKBILMI().SetFloat("_Blue_R", GAMMLIDAPPF);
			MLMKCOINOOH().SetVector("JoinTeam was called in state: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 131f, 45f));
			LONNIJMNKFB().SetFloat("ok", Vignette);
			MLMKCOINOOH().SetFloat("_BlurRadius4", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
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
			MMOODGIODPC().SetFloat(".lastCheckpoint.penaltyScore", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat(" has no method \"", GAMMLIDAPPF);
			LONNIJMNKFB().SetVector(".completed", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1554f, 325f));
			IGIAPKPKGPK().SetFloat("#tryagain", Vignette);
			MMOODGIODPC().SetFloat("#onrankchangeuptext", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
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
		SCShader = Shader.Find("CameraFilterPack/Oculus_NightVision1");
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
			NBPKMLMCHFN.SetFloat("MapperNameText", HBJJOCHGOPH);
			MLMKCOINOOH().SetFloat("_TimeX", GAMMLIDAPPF);
			CFEDGDGBCHE().SetVector("_DiffuseColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 194f, 650f));
			IGIAPKPKGPK().SetFloat("No Description", Vignette);
			KBOPGONOCNP().SetFloat("CameraFilterPack_OldFilm2", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
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
			MCDGIILBNIF().SetFloat("Items", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("_MainTex", GAMMLIDAPPF);
			DBOLLHHMKKN().SetVector("Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1128f, 1619f));
			OIMMPLPBLBK().SetFloat("_Value2", Vignette);
			NFMGLIKNOOC().SetFloat("[MapEditor] Item creation successful! Published Item ID: ", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
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
			NJDIODJNGGA().SetFloat("challengeid", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("_TimeX", GAMMLIDAPPF);
			HCGJCMDJPGD().SetVector("Room: '{0}' {1},{2} {4}/{3} players.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 126f, 516f));
			DBOLLHHMKKN().SetFloat("#{0:X2}{1:X2}{2:X2}", Vignette);
			CFEDGDGBCHE().SetFloat("_FixDistance", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KCCIEMBMOBA()
	{
		SCShader = Shader.Find("Value");
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
			NBPKMLMCHFN.SetFloat("GhostFade", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("Please define the RectTransform for the Center viewport of the scrollable area", GAMMLIDAPPF);
			LONNIJMNKFB().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 532f, 221f));
			HCGJCMDJPGD().SetFloat("_MainTex2", Vignette);
			KBOPGONOCNP().SetFloat("#close", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
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
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Glasses_On", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("SetParticlesInput", GAMMLIDAPPF);
			IGIAPKPKGPK().SetVector("_Green_C", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1657f, 294f));
			GKILCDHJFEG().SetFloat("Items", Vignette);
			MCDGIILBNIF().SetFloat(" ", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
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
		SCShader = Shader.Find("[ItemsHandler] Found ");
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
			FAIFBBGFAIB().SetFloat("targetColor", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("_Value6", GAMMLIDAPPF);
			NJDIODJNGGA().SetVector("Bad parameters for reset! Use \"reset <challengeid>\"", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1094f, 632f));
			NBPKMLMCHFN.SetFloat("Mouse1", Vignette);
			OIMMPLPBLBK().SetFloat("_MatrixColor", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HJPCJGOEKMF()
	{
		SCShader = Shader.Find("menutheme.deleted");
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
			CFEDGDGBCHE().SetFloat("_ColoredChange", HBJJOCHGOPH);
			NJDIODJNGGA().SetFloat("SaveButton", GAMMLIDAPPF);
			MMOODGIODPC().SetVector("CameraFilterPack_TV_HorrorFX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1487f, 238f));
			DBOLLHHMKKN().SetFloat("CameraFilterPack/FX_Scan", Vignette);
			OIMMPLPBLBK().SetFloat("SearchTex", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIIDAKBILMI());
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
			IGIAPKPKGPK().SetFloat("float", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("setbool", GAMMLIDAPPF);
			OIMMPLPBLBK().SetVector(" Message: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 233f, 86f));
			MLMKCOINOOH().SetFloat("_Value12", Vignette);
			DNLMFEGJJDD().SetFloat("#availablechallenges", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FANADGBGCPI()
	{
		SCShader = Shader.Find("Tab1Content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JILOMOBDPIA()
	{
		SCShader = Shader.Find("BitsData");
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
			IGIAPKPKGPK().SetFloat("_Amount", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("System.Int32", GAMMLIDAPPF);
			NBPKMLMCHFN.SetVector("[ImageLoader] Loaded image from ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1333f, 917f));
			IGIAPKPKGPK().SetFloat("settings.hitvariation", Vignette);
			GKILCDHJFEG().SetFloat("#scoresubmitionfailed: ", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NJDIODJNGGA());
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
			LONNIJMNKFB().SetFloat("maps.", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("Failed!", GAMMLIDAPPF);
			MCDGIILBNIF().SetVector("Add Environment Sprite", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 419f, 533f));
			MMOODGIODPC().SetFloat("_Amount", Vignette);
			NFMGLIKNOOC().SetFloat("float,1", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NJDIODJNGGA());
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
			DNLMFEGJJDD().SetFloat("[LevelEditorScene] Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(", HBJJOCHGOPH);
			NJDIODJNGGA().SetFloat("Please specify either t or f.", GAMMLIDAPPF);
			MLMKCOINOOH().SetVector("[", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 342f, 1583f));
			IGIAPKPKGPK().SetFloat("ComboScoreText", Vignette);
			FAIFBBGFAIB().SetFloat("Cant ask anyone else for PickupItem spawn times.", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PMPKMGKAAJH()
	{
		SCShader = Shader.Find("#E14FFF");
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
			HCGJCMDJPGD().SetFloat("[LevelEditorScene] Error: I/O Failure! :(", HBJJOCHGOPH);
			MMOODGIODPC().SetFloat("_TimeX", GAMMLIDAPPF);
			DNLMFEGJJDD().SetVector("_DistortionSize", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 915f, 792f));
			NFMGLIKNOOC().SetFloat("_Value2", Vignette);
			IGIAPKPKGPK().SetFloat("_Distortion", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
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
		SCShader = Shader.Find("cancel");
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
			DBOLLHHMKKN().SetFloat("BitsData", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("/", GAMMLIDAPPF);
			DBOLLHHMKKN().SetVector("setAF", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1490f, 638f));
			OIMMPLPBLBK().SetFloat("icon_border", Vignette);
			NBPKMLMCHFN.SetFloat("_Fade", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
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
			OIIDAKBILMI().SetFloat("HitVariationSlider", HBJJOCHGOPH);
			OIIDAKBILMI().SetFloat("_ChromaticAberration", GAMMLIDAPPF);
			OIMMPLPBLBK().SetVector("SupportLogger OnApplicationPause: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1317f, 1362f));
			OIIDAKBILMI().SetFloat("_GrainTex", Vignette);
			NJDIODJNGGA().SetFloat("$ {0}", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			NFMGLIKNOOC().SetFloat("_Value2", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("2", GAMMLIDAPPF);
			KBOPGONOCNP().SetVector("ItemNameText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 615f, 1793f));
			MMOODGIODPC().SetFloat("In Network lobby", Vignette);
			OIMMPLPBLBK().SetFloat("_TimeX", Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
