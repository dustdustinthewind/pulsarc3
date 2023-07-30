// CameraFilterPack_Gradients_FireGradient
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Gradients/Fire")]
[ExecuteInEditMode]
public class CameraFilterPack_Gradients_FireGradient : MonoBehaviour
{
	public Shader SCShader;

	private string ELOFMLPCCEA = "CameraFilterPack/Gradients_FireGradient";

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 1f)]
	public float Switch = 1f;

	[Range(0f, 1f)]
	public float Fade = 1f;

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

	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1007f)
			{
				HBJJOCHGOPH = 1380f;
			}
			MCDGIILBNIF().SetFloat("#ok", HBJJOCHGOPH);
			LELKBCALFCF().SetFloat("[ReplayScene] Loading replay: ", Switch);
			ABHDNGIHBKE().SetFloat("Tab2Content", Fade);
			LELKBCALFCF().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1591f, 1296f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LELKBCALFCF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material OKJOKHGJHGF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 327f)
			{
				HBJJOCHGOPH = 954f;
			}
			KGOLDDBHIFN().SetFloat("_Red_G", HBJJOCHGOPH);
			MHBAIEKFBIJ().SetFloat("_Red_C", Switch);
			MJJIEHANFJA().SetFloat("Scene", Fade);
			NBPKMLMCHFN.SetVector("OK", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1397f, 604f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OPHBLNNGFKG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1255f)
			{
				HBJJOCHGOPH = 100f;
			}
			FEAEGGCNIAA().SetFloat("CameraFilterPack_AAA_BloodOnScreen1", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("#savemapbeforeuploading", Switch);
			JFDGLLEOPGB().SetFloat("Spawn new environment sprite (image) and sets its id", Fade);
			PHGCJOPFDOG().SetVector("MouseX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 94f, 8f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material MJJIEHANFJA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material FEAEGGCNIAA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-80);
		}
		return BJFKDHHMLJH;
	}

	private void FKDEEJFNNJC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LIBGAKMKHJJ()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material EHDJJANLINB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void NJHJHBOJKIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FHGKIOOMMOH()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
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
	private Material EFDEIFCDAFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-114);
		}
		return BJFKDHHMLJH;
	}

	private void DAHFFNNIGML()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PNLKFANNOKO()
	{
	}

	private void GPNAOAKCMHC()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BDBJEDIOKBN()
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

	private void Start()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JHPOIOELNCG()
	{
	}

	private void MFMIODIAKNI()
	{
	}

	private void FGNFILLNPJK()
	{
	}

	[SpecialName]
	private Material KJMECMIGJJA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)111;
		}
		return BJFKDHHMLJH;
	}

	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1882f)
			{
				HBJJOCHGOPH = 370f;
			}
			MJJIEHANFJA().SetFloat("_Value7", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("/", Switch);
			MJJIEHANFJA().SetFloat(".played", Fade);
			DOHGBNPMBKG().SetVector("settings.volume.menu", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1851f, 1738f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KOFAMEKHHGD()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MMOKKAPFGAK()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1320f)
			{
				HBJJOCHGOPH = 1034f;
			}
			DOHGBNPMBKG().SetFloat("_MainTex2", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("mapselector.orderby", Switch);
			NJDIODJNGGA().SetFloat("Set Satellite Lerp Speed", Fade);
			LELKBCALFCF().SetVector("settings_bindings_sec_", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 724f, 1256f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MKIFJMPELJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1811f)
			{
				HBJJOCHGOPH = 1756f;
			}
			LELKBCALFCF().SetFloat("#ok", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat("float,0", Switch);
			IGKFMCPDNOI().SetFloat("ScoreText", Fade);
			CFCPHFMKHII().SetVector("_Value4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1549f, 1432f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IMGGCJICLHK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LLKKGGLNIDF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JDKHBGDEONK()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EPEGAEGDJAM()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ALMGMOOHLMA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AMHEJBMLFNM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LFAFJKJAEEL()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material PHGCJOPFDOG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NBMPPNFKFLB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)102;
		}
		return BJFKDHHMLJH;
	}

	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1755f)
			{
				HBJJOCHGOPH = 379f;
			}
			HNFFHCLNBDN().SetFloat("SpawnObj", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("_Value4", Switch);
			KBOPGONOCNP().SetFloat("materialsquantity[", Fade);
			DOHGBNPMBKG().SetVector("SetSunMinSize", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 704f, 66f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LELKBCALFCF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material KGOLDDBHIFN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-66);
		}
		return BJFKDHHMLJH;
	}

	private void BLKGOMCPEKI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DOKAKEMDALN()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 492f)
			{
				HBJJOCHGOPH = 546f;
			}
			ABHDNGIHBKE().SetFloat("FinalScoreText", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("SpawnObj", Switch);
			ABHDNGIHBKE().SetFloat("_Threshold", Fade);
			EFDEIFCDAFG().SetVector("Map already submited. Update?", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 914f, 728f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LBIOIEANMGI()
	{
	}

	private void POJFHDFJOPE()
	{
	}

	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 782f)
			{
				HBJJOCHGOPH = 1666f;
			}
			LMLENGFLEBD().SetFloat("Set Sun Sensitivity", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("/", Switch);
			IGKFMCPDNOI().SetFloat("settings.enableselectormusic", Fade);
			MJJIEHANFJA().SetVector("CameraFilterPack/3D_Ghost", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1238f, 825f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ODAIMOJLJOF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DPFOEBCADNP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CFFCLAHMBAA()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
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
			NBPKMLMCHFN.SetFloat("_Value", Switch);
			NBPKMLMCHFN.SetFloat("_Value2", Fade);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NNCCPEBIAKH()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void Update()
	{
	}

	private void FEHCNJLLJMP()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material HNFFHCLNBDN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material CFCPHFMKHII()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1472f)
			{
				HBJJOCHGOPH = 198f;
			}
			HEHKGPKLAKK().SetFloat("Error: I/O Failure", HBJJOCHGOPH);
			LELKBCALFCF().SetFloat("SettingsCanvas", Switch);
			LMLENGFLEBD().SetFloat("IconImage", Fade);
			MJJIEHANFJA().SetVector("Please specify a map name or buildID", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1596f, 671f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KCCIEMBMOBA()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FGBDGGCBFLP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IDIIELPAMCJ()
	{
	}

	private void DDFCIOMKEEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 698f)
			{
				HBJJOCHGOPH = 868f;
			}
			KBOPGONOCNP().SetFloat("SelectionBox component must be placed on a canvas in Screen Space Overlay mode.", HBJJOCHGOPH);
			FEAEGGCNIAA().SetFloat("CameraFilterPack/FX_Drunk", Switch);
			ABHDNGIHBKE().SetFloat("Coroutine container not configured... did you forget to call Init?", Fade);
			EFDEIFCDAFG().SetVector("CameraFilterPack/TV_Old_Movie", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1962f, 130f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LBPHCAMMAPB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JLNNHKPHMAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material NJDIODJNGGA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material MCDGIILBNIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void JHANGPCOCIG()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AEIJFLJEABG()
	{
	}

	[SpecialName]
	private Material JFDGLLEOPGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)79;
		}
		return BJFKDHHMLJH;
	}

	private void HPNNCNNFMGK()
	{
	}

	[SpecialName]
	private Material IGKFMCPDNOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)87;
		}
		return BJFKDHHMLJH;
	}

	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1227f)
			{
				HBJJOCHGOPH = 570f;
			}
			HNFFHCLNBDN().SetFloat("_TimeX", HBJJOCHGOPH);
			MHBAIEKFBIJ().SetFloat("/", Switch);
			EHDJJANLINB().SetFloat("CameraFilterPack/FX_DarkMatter", Fade);
			KBOPGONOCNP().SetVector("challenges.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 355f, 1897f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DOHGBNPMBKG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-118);
		}
		return BJFKDHHMLJH;
	}

	private void KMCPMOGKDEH()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IBPAMDEAGJL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material LELKBCALFCF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void HGDDCINLDAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LLDHEJIEDHO()
	{
	}

	private void AAPKBNDHBLI()
	{
	}

	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1160f)
			{
				HBJJOCHGOPH = 573f;
			}
			NBPKMLMCHFN.SetFloat(": ", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("Set Trail Zoom (player camera move forward effect). Base value - 1.5", Switch);
			ABHDNGIHBKE().SetFloat("Joystick1Button1", Fade);
			NBMPPNFKFLB().SetVector("_MatrixSize", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1749f, 459f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PKGJJFIFLII()
	{
	}

	private void IKIDIJLIGOH()
	{
	}

	private void PDHKMDBNGGN()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 902f)
			{
				HBJJOCHGOPH = 865f;
			}
			KBOPGONOCNP().SetFloat("sounds/hit_wrong", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("#", Switch);
			PHGCJOPFDOG().SetFloat("time", Fade);
			FEAEGGCNIAA().SetVector("LevelConfigButton", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1780f, 116f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ALJEJJCIMJN()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1926f)
			{
				HBJJOCHGOPH = 335f;
			}
			EHDJJANLINB().SetFloat("_AreaTex", HBJJOCHGOPH);
			LELKBCALFCF().SetFloat("D-Pad Right", Switch);
			LELKBCALFCF().SetFloat("_ColorLevel", Fade);
			AELJLBOJAIL().SetVector("_Blue_B", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 259f, 275f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LMLENGFLEBD());
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
	private Material NFMGLIKNOOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)71;
		}
		return BJFKDHHMLJH;
	}

	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 960f)
			{
				HBJJOCHGOPH = 1713f;
			}
			AELJLBOJAIL().SetFloat("Set Particles Input", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("menu.tabid", Switch);
			DOHGBNPMBKG().SetFloat("File not found: {0}", Fade);
			LMLENGFLEBD().SetVector(" SecondsBeforeRespawn: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 77f, 1723f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1269f)
			{
				HBJJOCHGOPH = 1197f;
			}
			OKJOKHGJHGF().SetFloat("Failed to InstantiateSceneObject prefab:", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat("PUNCloudBestRegion", Switch);
			LMLENGFLEBD().SetFloat("PhotonView with ID {0} wasn't properly unregistered! Please report this case to developer@photonengine.com", Fade);
			LELKBCALFCF().SetVector("Item invalid. Make sure your mod contains at leats one file.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1944f, 989f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 51f)
			{
				HBJJOCHGOPH = 1060f;
			}
			KJMECMIGJJA().SetFloat("intensity", HBJJOCHGOPH);
			CFCPHFMKHII().SetFloat("SaveButton", Switch);
			PHGCJOPFDOG().SetFloat("_Distortion", Fade);
			MCDGIILBNIF().SetVector(" ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1301f, 1644f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EHDJJANLINB());
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

	private void MNBPNHNAEBK()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FEKECCBFGMI()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IGPCNCJIEOJ()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CPAJLKHMOJB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 454f)
			{
				HBJJOCHGOPH = 1338f;
			}
			LMLENGFLEBD().SetFloat(".lastCheckpoint.isMapCompleted", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat(":", Switch);
			HEHKGPKLAKK().SetFloat(": ", Fade);
			MHBAIEKFBIJ().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 600f, 265f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PFNFPINPCMH()
	{
	}

	private void HLLHJIDOOGA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 670f)
			{
				HBJJOCHGOPH = 179f;
			}
			EHDJJANLINB().SetFloat("mapselector.filter.subscribedonly", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("bool", Switch);
			MCDGIILBNIF().SetFloat("Can't set MaxPlayers when not in that room.", Fade);
			KGOLDDBHIFN().SetVector("Fade", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1937f, 1969f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material ABHDNGIHBKE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material MHBAIEKFBIJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-69);
		}
		return BJFKDHHMLJH;
	}

	private void JHLGHODFJOO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1153f)
			{
				HBJJOCHGOPH = 406f;
			}
			FEAEGGCNIAA().SetFloat("CameraMovementSlider", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat("_Green_R", Switch);
			NFMGLIKNOOC().SetFloat("_TimeX", Fade);
			KJMECMIGJJA().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 463f, 119f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JECMJNFGBGC()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1191f)
			{
				HBJJOCHGOPH = 1609f;
			}
			ABHDNGIHBKE().SetFloat("#close", HBJJOCHGOPH);
			LELKBCALFCF().SetFloat("_ScreenResolution", Switch);
			MCDGIILBNIF().SetFloat("CameraFilterPack/TV_Rgb", Fade);
			KJMECMIGJJA().SetVector("Return: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 963f, 1896f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)111;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material LMLENGFLEBD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-111);
		}
		return BJFKDHHMLJH;
	}

	private void CFIAKIJAILI()
	{
	}

	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1857f)
			{
				HBJJOCHGOPH = 309f;
			}
			MHBAIEKFBIJ().SetFloat("en", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("clear", Switch);
			DOHGBNPMBKG().SetFloat(" method: ", Fade);
			NBMPPNFKFLB().SetVector(":", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 982f, 1465f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OCCGJMPAJIK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LMBDNPLDGIJ()
	{
	}

	private void IFJDKDFLGBG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1367f)
			{
				HBJJOCHGOPH = 1476f;
			}
			LMLENGFLEBD().SetFloat("Joystick1Button0", HBJJOCHGOPH);
			EHDJJANLINB().SetFloat("editorVolume", Switch);
			NBMPPNFKFLB().SetFloat("CameraFilterPack/Blur_Bloom", Fade);
			MCDGIILBNIF().SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 283f, 252f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material AELJLBOJAIL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-120);
		}
		return BJFKDHHMLJH;
	}

	private void JKBMKPDGCHG()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
