// CameraFilterPack_Drawing_Curve
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Drawing/Curve")]
[ExecuteInEditMode]
public class CameraFilterPack_Drawing_Curve : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(3f, 5f)]
	public float Size = 1f;

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

	private void OCCGJMPAJIK()
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
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HCGJCMDJPGD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-78);
		}
		return BJFKDHHMLJH;
	}

	private void KFACDBHDAOD()
	{
	}

	private void OHFOLGANOLC()
	{
		SCShader = Shader.Find("Exception while connecting to: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material BLMPMOIDGMG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void LIBGAKMKHJJ()
	{
		SCShader = Shader.Find("SpawnObj");
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
			if (HBJJOCHGOPH > 550f)
			{
				HBJJOCHGOPH = 1575f;
			}
			LNLKMDPHDCC().SetFloat("_MainTex2", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("player.redarc", Size);
			LONNIJMNKFB().SetVector("[PlayerBase] SpawnObj error: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 870f, 1319f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CECJJMKLEAK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EGEGNHLODAA()
	{
	}

	[SpecialName]
	private Material OKJOKHGJHGF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-74);
		}
		return BJFKDHHMLJH;
	}

	private void APKNAPHOFHC()
	{
	}

	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1123f)
			{
				HBJJOCHGOPH = 1089f;
			}
			CECJJMKLEAK().SetFloat("Classical", HBJJOCHGOPH);
			MMOODGIODPC().SetFloat("CameraFilterPack/Blend2Camera_Difference", Size);
			CFCPHFMKHII().SetVector("...", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1268f, 976f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FDNONDCGGCG()
	{
		SCShader = Shader.Find(".g");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material MMOODGIODPC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)97;
		}
		return BJFKDHHMLJH;
	}

	private void KDMANOEMOCA()
	{
		SCShader = Shader.Find("_LightIntensity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material GCDFNHMJMIP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-106);
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

	private void IIFCIDDJHPM()
	{
	}

	private void KMCPMOGKDEH()
	{
		SCShader = Shader.Find("seconds");
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
			NBPKMLMCHFN.SetFloat("_Value", Size);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JBNPEHMDCMI()
	{
	}

	private void JKFDDNMPOJH()
	{
		SCShader = Shader.Find("/GetNews/pinnednewsid");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AGMJDGHLBMN()
	{
	}

	[SpecialName]
	private Material NFMGLIKNOOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)116;
		}
		return BJFKDHHMLJH;
	}

	private void KKEOHFGKCIK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IKMELABKBHO()
	{
	}

	private void JAAJECBCCFM()
	{
	}

	[SpecialName]
	private Material KDMBOKLMADJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void BEBNOKFLJPH()
	{
		SCShader = Shader.Find("_ExposureAdjustment");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material EJDPNJAEAKJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material AELJLBOJAIL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void JOACBIEHHCE()
	{
	}

	private void LINKAMEPKGM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material CECJJMKLEAK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void Update()
	{
	}

	private void OMCLOFCJMPG()
	{
	}

	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 304f)
			{
				HBJJOCHGOPH = 397f;
			}
			NBPKMLMCHFN.SetFloat("https://bitbucket.org/khb-soft/intralismarcsviewer/", HBJJOCHGOPH);
			GJHLADDCMFF().SetFloat("BestScoreText", Size);
			GCDFNHMJMIP().SetVector("Set sun min/max size", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 645f, 1714f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 652f)
			{
				HBJJOCHGOPH = 1033f;
			}
			NFMGLIKNOOC().SetFloat("_Value2", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("plainText", Size);
			FAIFBBGFAIB().SetVector("CameraFilterPack/EyesVision_2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 246f, 1347f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LONNIJMNKFB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 536f)
			{
				HBJJOCHGOPH = 214f;
			}
			IGIAPKPKGPK().SetFloat("PunRespawn", HBJJOCHGOPH);
			BLMPMOIDGMG().SetFloat("_MainTex2", Size);
			ACHNOHCLGOO().SetVector("menu.hardcoreinfo", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 264f, 1405f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LPMINJJPDCH()
	{
	}

	private void FHGKIOOMMOH()
	{
		SCShader = Shader.Find("menutheme.idunno");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EJJEDJIOFAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material KJMECMIGJJA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-85);
		}
		return BJFKDHHMLJH;
	}

	private void PKHPNHBEKHA()
	{
	}

	[SpecialName]
	private Material EFMCNLELMDO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material FAIFBBGFAIB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-74);
		}
		return BJFKDHHMLJH;
	}

	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1285f)
			{
				HBJJOCHGOPH = 93f;
			}
			KOHGPKOFEJO().SetFloat("offsets", HBJJOCHGOPH);
			FEAEGGCNIAA().SetFloat("player.redarc", Size);
			ACHNOHCLGOO().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 706f, 755f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Drawing_Curve");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FBPHNEJBDJN()
	{
		SCShader = Shader.Find("y");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 910f)
			{
				HBJJOCHGOPH = 919f;
			}
			CFCPHFMKHII().SetFloat("tagElement", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat(": ", Size);
			GCDFNHMJMIP().SetVector("VIGNETTE_BLUR", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1377f, 716f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
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
			base.enabled = true;
		}
	}

	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1760f)
			{
				HBJJOCHGOPH = 742f;
			}
			GJHLADDCMFF().SetFloat("_TimeX", HBJJOCHGOPH);
			OKJOKHGJHGF().SetFloat("CameraFilterPack/Vision_Drost", Size);
			EFMCNLELMDO().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1299f, 838f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KMKLDAJLCNM()
	{
	}

	private void GMELGGJOPBB()
	{
	}

	private void DOEPOGLEGLE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1980f)
			{
				HBJJOCHGOPH = 1263f;
			}
			FAIFBBGFAIB().SetFloat("SearchTex", HBJJOCHGOPH);
			BLMPMOIDGMG().SetFloat(": ", Size);
			IIBLJCKLGFG().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 813f, 451f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material KOHGPKOFEJO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void DBEMDAJDDDA()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BNEJMABFKJE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IMGGCJICLHK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PLEOOAJIMEE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1278f)
			{
				HBJJOCHGOPH = 1436f;
			}
			GKILCDHJFEG().SetFloat("menu.tabid", HBJJOCHGOPH);
			HNFFHCLNBDN().SetFloat("0", Size);
			NFMGLIKNOOC().SetVector("Most likely the game became empty during the switch to GameServer.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 762f, 1961f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 991f)
			{
				HBJJOCHGOPH = 1797f;
			}
			EFMCNLELMDO().SetFloat("CameraFilterPack/Blur_Bloom", HBJJOCHGOPH);
			BLMPMOIDGMG().SetFloat("maps.", Size);
			KOHGPKOFEJO().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 86f, 1962f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CGBHOELMAOC()
	{
	}

	private void NDAJBJFJGCF()
	{
	}

	private void MFLBEJHMEMO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HNFFHCLNBDN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-90);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material ACHNOHCLGOO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material FEAEGGCNIAA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave;
		}
		return BJFKDHHMLJH;
	}

	private void OFIMMFHFHDD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HLDFOJMHKNL()
	{
	}

	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 762f)
			{
				HBJJOCHGOPH = 1026f;
			}
			FEAEGGCNIAA().SetFloat("OnAwakeRPC", HBJJOCHGOPH);
			BLMPMOIDGMG().SetFloat("_Blue_B", Size);
			KDMBOKLMADJ().SetVector("Sent count: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1878f, 1828f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HIKKPDACJGI()
	{
	}

	[SpecialName]
	private Material IIBLJCKLGFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.HideInHierarchy;
		}
		return BJFKDHHMLJH;
	}

	private void BGFJOEPFOPM()
	{
	}

	private void MJNPIDGNJMK()
	{
	}

	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 892f)
			{
				HBJJOCHGOPH = 913f;
			}
			GKILCDHJFEG().SetFloat("IconImage", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("_EmissionGain", Size);
			IIBLJCKLGFG().SetVector(" beatThreshold: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 396f, 894f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HKGAONMOBMH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-99);
		}
		return BJFKDHHMLJH;
	}

	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 631f)
			{
				HBJJOCHGOPH = 956f;
			}
			GJHLADDCMFF().SetFloat("_MainTex2", HBJJOCHGOPH);
			HKGAONMOBMH().SetFloat("STOP [R]", Size);
			NBPKMLMCHFN.SetVector("The process failed: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 165f, 1794f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material CFCPHFMKHII()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void KMEONPMCNJG()
	{
	}

	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 332f)
			{
				HBJJOCHGOPH = 41f;
			}
			KDMBOKLMADJ().SetFloat("Left", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("Subscribed cells:\n", Size);
			HKGAONMOBMH().SetVector("_SoftZDistance", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1451f, 1032f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
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
	private Material LNLKMDPHDCC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material GJHLADDCMFF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)66;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IGIAPKPKGPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-77);
		}
		return BJFKDHHMLJH;
	}

	private void IEMEHGCFAPD()
	{
	}

	[SpecialName]
	private Material LPDOGGFOBDH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)125;
		}
		return BJFKDHHMLJH;
	}

	private void CFFCLAHMBAA()
	{
		SCShader = Shader.Find("Tab1Content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JECMJNFGBGC()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CHOPDIGHJNH()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 777f)
			{
				HBJJOCHGOPH = 752f;
			}
			GCDFNHMJMIP().SetFloat("ticket", HBJJOCHGOPH);
			BLMPMOIDGMG().SetFloat("_Value3", Size);
			FAIFBBGFAIB().SetVector("EnableRankingToggle", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 715f, 1782f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EDCMIPNCPLB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material OIMMPLPBLBK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void EGEPLFGKGLI()
	{
		SCShader = Shader.Find("OpLeaveLobby()");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FPHLDMMAOEF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PHJJHFBLICM()
	{
	}

	private void NNPBKKBFDHH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ODBNMPGBCGO()
	{
		SCShader = Shader.Find("Texture2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
