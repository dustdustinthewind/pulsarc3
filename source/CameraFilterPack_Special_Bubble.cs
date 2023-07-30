// CameraFilterPack_Special_Bubble
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Special/Bubble")]
[ExecuteInEditMode]
public class CameraFilterPack_Special_Bubble : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(-4f, 4f)]
	public float X = 0.5f;

	[Range(-4f, 4f)]
	public float Y = 0.5f;

	[Range(0f, 5f)]
	public float Rate = 1f;

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

	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 573f)
			{
				HBJJOCHGOPH = 1062f;
			}
			DNLMFEGJJDD().SetFloat(": ", HBJJOCHGOPH);
			PHGCJOPFDOG().SetFloat("_Value", X);
			PDEAHJPOMEF().SetFloat("Set Particles Speed", Y);
			ACHNOHCLGOO().SetFloat("Bad parameters for set! Use <language>", Rate);
			NBPKMLMCHFN.SetFloat("_Greenness", CCIENBFIKKH);
			BKKJJJGADLM().SetVector(" ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 445f, 1789f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF());
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1682f)
			{
				HBJJOCHGOPH = 532f;
			}
			KEMJNOMIPHN().SetFloat("Offline or in OfflineMode. No VitalStats available.", HBJJOCHGOPH);
			FHFLKLMFHOI().SetFloat(" failed in a server-side plugin. Check the configuration in the Dashboard. Message from server-plugin: ", X);
			DNLMFEGJJDD().SetFloat(".lastCheckpoint.comboScore", Y);
			HHIFMIPPMPF().SetFloat("_ScreenResolution", Rate);
			HNICHJCGJOC().SetFloat("value", CCIENBFIKKH);
			OCHJIMJNEMO().SetVector("GraphicsQualitySlider", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 772f, 256f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IEMEHGCFAPD()
	{
	}

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 850f)
			{
				HBJJOCHGOPH = 1988f;
			}
			HNICHJCGJOC().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat("Aug", X);
			OJMHIMIPKME().SetFloat("</color>", Y);
			PDEAHJPOMEF().SetFloat("_Value", Rate);
			ACHNOHCLGOO().SetFloat("_Value", CCIENBFIKKH);
			EHDJJANLINB().SetVector("-1", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 597f, 250f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
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
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.HideInInspector | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void LLKKGGLNIDF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ANCKKLFPGDI()
	{
		SCShader = Shader.Find("ItemsUploader");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material HHIFMIPPMPF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-105);
		}
		return BJFKDHHMLJH;
	}

	private void KLILJHJNICK()
	{
		SCShader = Shader.Find("{0} days ago");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FNCDAPDOBBI()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KOJKBFDNGDK()
	{
		SCShader = Shader.Find("https://bitbucket.org/khb-soft/intralismarcsviewer/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1322f)
			{
				HBJJOCHGOPH = 1870f;
			}
			BKKJJJGADLM().SetFloat("offsets", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("checkpoint", X);
			FHFLKLMFHOI().SetFloat("Waiting for AvailableRegions. State: ", Y);
			FHFLKLMFHOI().SetFloat(" user's map(s)", Rate);
			OJMHIMIPKME().SetFloat("powerup.1", CCIENBFIKKH);
			OJMHIMIPKME().SetVector("mapselector.lastSearch", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 687f, 816f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HNICHJCGJOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material FHFLKLMFHOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IIJMIPBMMBF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-104);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KEMJNOMIPHN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void IEFMONDKKJN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material NLFJGMBCICG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)96;
		}
		return BJFKDHHMLJH;
	}

	private void HJPCJGOEKMF()
	{
		SCShader = Shader.Find("_FlipAlphaMask");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IMGGCJICLHK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PKBENONAOOL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material PHGCJOPFDOG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void MMOKKAPFGAK()
	{
		SCShader = Shader.Find("StartButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DFENCIHAADO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GHILDCBCDJI()
	{
	}

	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1097f)
			{
				HBJJOCHGOPH = 181f;
			}
			IIJMIPBMMBF().SetFloat("Set Satellite Sensitivity", HBJJOCHGOPH);
			PHGCJOPFDOG().SetFloat(",", X);
			BKKJJJGADLM().SetFloat("Mouse X", Y);
			KEMJNOMIPHN().SetFloat("w", Rate);
			HHIFMIPPMPF().SetFloat("_TimeX", CCIENBFIKKH);
			LNLKMDPHDCC().SetVector("CameraFilterPack/Distortion_Water_Drop", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1146f, 1281f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void OFPPIKHNJOD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1291f)
			{
				HBJJOCHGOPH = 733f;
			}
			FHFLKLMFHOI().SetFloat("NEW_ACHIEVEMENT_1_21", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("[ERROR KEY {0}]", X);
			OJMHIMIPKME().SetFloat("CameraFilterPack/Gradients_Therma", Y);
			NLFJGMBCICG().SetFloat("Horizontal", Rate);
			KEMJNOMIPHN().SetFloat("settings.shaders", CCIENBFIKKH);
			LNLKMDPHDCC().SetVector("_ColorG", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 352f, 1756f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CNDACAHCCOI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1294f)
			{
				HBJJOCHGOPH = 419f;
			}
			LNLKMDPHDCC().SetFloat("Freq: ", HBJJOCHGOPH);
			OCHJIMJNEMO().SetFloat("_ScreenResolution", X);
			EHDJJANLINB().SetFloat("file://", Y);
			NBPKMLMCHFN.SetFloat("DPADVER", Rate);
			IIJMIPBMMBF().SetFloat("SfxVolumeSlider", CCIENBFIKKH);
			EHDJJANLINB().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1867f, 1808f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EHDJJANLINB());
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
			NBPKMLMCHFN.SetFloat("_Value", X);
			NBPKMLMCHFN.SetFloat("_Value2", Y);
			NBPKMLMCHFN.SetFloat("_Value3", Rate);
			NBPKMLMCHFN.SetFloat("_Value4", CCIENBFIKKH);
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
			if (HBJJOCHGOPH > 551f)
			{
				HBJJOCHGOPH = 230f;
			}
			HHIFMIPPMPF().SetFloat("CameraFilterPack/3D_Myst", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("_BlurSize", X);
			OCHJIMJNEMO().SetFloat(": ", Y);
			EHDJJANLINB().SetFloat(".played", Rate);
			OCHJIMJNEMO().SetFloat("id", CCIENBFIKKH);
			EHDJJANLINB().SetVector("Indie", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 52f, 1088f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
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
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void OMCLOFCJMPG()
	{
	}

	[SpecialName]
	private Material DKKBFFHBHJE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)95;
		}
		return BJFKDHHMLJH;
	}

	private void ALMGMOOHLMA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MMMDPANNAIO()
	{
		SCShader = Shader.Find("TotalHitsScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DLMPALHKMON()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material BKKJJJGADLM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)125;
		}
		return BJFKDHHMLJH;
	}

	private void KFACDBHDAOD()
	{
	}

	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1196f)
			{
				HBJJOCHGOPH = 1800f;
			}
			KBOPGONOCNP().SetFloat("</color>", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("#score", X);
			BKKJJJGADLM().SetFloat("Failed to InstantiateSceneObject prefab: ", Y);
			PDEAHJPOMEF().SetFloat("_Bullet_12", Rate);
			ACHNOHCLGOO().SetFloat("tagElement", CCIENBFIKKH);
			LNLKMDPHDCC().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 440f, 238f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material OCHJIMJNEMO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)79;
		}
		return BJFKDHHMLJH;
	}

	private void LPMINJJPDCH()
	{
	}

	private void MKIMDFLBFOM()
	{
		SCShader = Shader.Find("_Value9");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material OJMHIMIPKME()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material EHDJJANLINB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void NDAJBJFJGCF()
	{
	}

	private void FPHLDMMAOEF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1550f)
			{
				HBJJOCHGOPH = 1320f;
			}
			KEMJNOMIPHN().SetFloat("Particles/Additive", HBJJOCHGOPH);
			FHFLKLMFHOI().SetFloat("CameraFilterPack/OldFilm_Cutting2", X);
			OJMHIMIPKME().SetFloat("#tryagain", Y);
			PHGCJOPFDOG().SetFloat("_ScreenResolution", Rate);
			DNLMFEGJJDD().SetFloat("_Value4", CCIENBFIKKH);
			HHIFMIPPMPF().SetVector("_Green_R", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1771f, 1188f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FMFNILJIEIA()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 902f)
			{
				HBJJOCHGOPH = 1560f;
			}
			PHGCJOPFDOG().SetFloat("_Parameter", HBJJOCHGOPH);
			PHGCJOPFDOG().SetFloat("_Green_C", X);
			IIJMIPBMMBF().SetFloat(". The group number should be at least 1.", Y);
			HHIFMIPPMPF().SetFloat("_MatrixSize", Rate);
			PHGCJOPFDOG().SetFloat("_ScreenResolution", CCIENBFIKKH);
			EHDJJANLINB().SetVector(".played", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1242f, 610f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MECJHOJPODB()
	{
	}

	private void LCHBFNIPBHB()
	{
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Special_Bubble");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material ACHNOHCLGOO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void LCDJFJIBADI()
	{
	}

	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 902f)
			{
				HBJJOCHGOPH = 1463f;
			}
			BKKJJJGADLM().SetFloat("<b>[", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("menu.tabid", X);
			HNICHJCGJOC().SetFloat("If you host Photon yourself, make sure to start the 'Instance LoadBalancing' ", Y);
			ACHNOHCLGOO().SetFloat("Connection error: ", Rate);
			KBOPGONOCNP().SetFloat("Up", CCIENBFIKKH);
			HNICHJCGJOC().SetVector(". Not Destroying GameObject or PhotonViews!", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1369f, 313f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JHPOIOELNCG()
	{
	}

	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 871f)
			{
				HBJJOCHGOPH = 193f;
			}
			OJMHIMIPKME().SetFloat(" x ", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("CameraFilterPack/Blend2Camera_Luminosity", X);
			KBOPGONOCNP().SetFloat("EventMenu", Y);
			KEMJNOMIPHN().SetFloat("_TapMedium", Rate);
			AELJLBOJAIL().SetFloat("_TimeX", CCIENBFIKKH);
			EMDFHOKEGNG().SetVector("DifficultyBG", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1662f, 466f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HIPEHGNBJMN()
	{
		SCShader = Shader.Find(".ogg");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FIKFJDFELIP()
	{
		SCShader = Shader.Find("english");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 208f)
			{
				HBJJOCHGOPH = 1363f;
			}
			ACHNOHCLGOO().SetFloat("_Value3", HBJJOCHGOPH);
			OJMHIMIPKME().SetFloat("_Value2", X);
			DNLMFEGJJDD().SetFloat(".", Y);
			LNLKMDPHDCC().SetFloat("_ScreenResolution", Rate);
			HNICHJCGJOC().SetFloat("_Value2", CCIENBFIKKH);
			PHGCJOPFDOG().SetVector("_MainTex2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 31f, 287f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1150f)
			{
				HBJJOCHGOPH = 1460f;
			}
			LNLKMDPHDCC().SetFloat("_Value", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("/", X);
			IIJMIPBMMBF().SetFloat("COMPLETED", Y);
			EHDJJANLINB().SetFloat("_TimeX", Rate);
			KBOPGONOCNP().SetFloat("x", CCIENBFIKKH);
			PDEAHJPOMEF().SetVector("\" that takes ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1364f, 232f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FHFLKLMFHOI());
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

	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 516f)
			{
				HBJJOCHGOPH = 1909f;
			}
			KEMJNOMIPHN().SetFloat("open", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("_Distortion", X);
			PHGCJOPFDOG().SetFloat(".lastCheckpoint.playerdistance", Y);
			HNICHJCGJOC().SetFloat("Data", Rate);
			OCHJIMJNEMO().SetFloat("_ScreenResolution", CCIENBFIKKH);
			OCHJIMJNEMO().SetVector("CameraFilterPack/Colors_DarkColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1060f, 776f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 65f)
			{
				HBJJOCHGOPH = 1825f;
			}
			AELJLBOJAIL().SetFloat("workshop.", HBJJOCHGOPH);
			PHGCJOPFDOG().SetFloat("_PositionY", X);
			OJMHIMIPKME().SetFloat("CameraFilterPack/Blur_Blurry", Y);
			KBOPGONOCNP().SetFloat("Set particles gravity", Rate);
			OCHJIMJNEMO().SetFloat("_Size", CCIENBFIKKH);
			DNLMFEGJJDD().SetVector("UseScanLine", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 345f, 87f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1417f)
			{
				HBJJOCHGOPH = 1360f;
			}
			EMDFHOKEGNG().SetFloat("_FixDistance", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Set Arcs Speed", X);
			AELJLBOJAIL().SetFloat("_EdgeThresholdMin", Y);
			BKKJJJGADLM().SetFloat("_MainTex2", Rate);
			DNLMFEGJJDD().SetFloat("time", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 839f, 1182f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BKKJJJGADLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PMPKMGKAAJH()
	{
		SCShader = Shader.Find("_Visualize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GCHBGCGBMCK()
	{
	}

	private void EHCGBJDFMHG()
	{
	}

	private void LIEGJOHINGC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DOEPOGLEGLE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1534f)
			{
				HBJJOCHGOPH = 1327f;
			}
			KBOPGONOCNP().SetFloat("In Map Editor", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("Text", X);
			ACHNOHCLGOO().SetFloat("_TimeX", Y);
			DKKBFFHBHJE().SetFloat("(\\[ *b *\\])", Rate);
			EHDJJANLINB().SetFloat("uploads/Intralism/mods_terms.pdf", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("GetGameList failed: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1769f, 858f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
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
			if (HBJJOCHGOPH > 615f)
			{
				HBJJOCHGOPH = 1267f;
			}
			PDEAHJPOMEF().SetFloat("Tab2Content", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Left", X);
			ACHNOHCLGOO().SetFloat("_PosY", Y);
			KBOPGONOCNP().SetFloat("_NeighbourMaxTex", Rate);
			KEMJNOMIPHN().SetFloat("_Extra2", CCIENBFIKKH);
			ACHNOHCLGOO().SetVector("Result for ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 948f, 431f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IKIDIJLIGOH()
	{
	}

	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 350f)
			{
				HBJJOCHGOPH = 1282f;
			}
			KEMJNOMIPHN().SetFloat(" not exist", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("[SERVER] Player ", X);
			DNLMFEGJJDD().SetFloat("#reward: ", Y);
			OCHJIMJNEMO().SetFloat("_Value", Rate);
			FHFLKLMFHOI().SetFloat("_ScreenResolution", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("_ChangeGreen", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 479f, 900f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 916f)
			{
				HBJJOCHGOPH = 1120f;
			}
			AELJLBOJAIL().SetFloat("Player Connected", HBJJOCHGOPH);
			PHGCJOPFDOG().SetFloat("gameVolume", X);
			LNLKMDPHDCC().SetFloat("_UV_Transform", Y);
			FHFLKLMFHOI().SetFloat("[MapsData] Caching ", Rate);
			ACHNOHCLGOO().SetFloat("ScreenResolutionPanel", CCIENBFIKKH);
			AELJLBOJAIL().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 585f, 1330f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1920f)
			{
				HBJJOCHGOPH = 1866f;
			}
			PDEAHJPOMEF().SetFloat("Tab2Content", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("_BlurRadius", X);
			EHDJJANLINB().SetFloat("menu.selectedlevelid", Y);
			EHDJJANLINB().SetFloat("_ScreenResolution", Rate);
			ACHNOHCLGOO().SetFloat("saveGameName ", CCIENBFIKKH);
			IIJMIPBMMBF().SetVector("player.egglipszerotwo", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 617f, 892f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 359f)
			{
				HBJJOCHGOPH = 228f;
			}
			LNLKMDPHDCC().SetFloat("_Value3", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("_TimeX", X);
			NBPKMLMCHFN.SetFloat("#getrewardnow ", Y);
			BKKJJJGADLM().SetFloat("_AlphaUV", Rate);
			FHFLKLMFHOI().SetFloat(".sav", CCIENBFIKKH);
			KBOPGONOCNP().SetVector("Received RPC \"", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 423f, 1019f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FBPHNEJBDJN()
	{
		SCShader = Shader.Find("[LevelEditorScene] Error: I/O Failure! :(");
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

	private void CMIBEOJGAIL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KKEOHFGKCIK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1623f)
			{
				HBJJOCHGOPH = 1561f;
			}
			DKKBFFHBHJE().SetFloat("1", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("GlassesColor", X);
			HNICHJCGJOC().SetFloat("yesterday", Y);
			FHFLKLMFHOI().SetFloat("CameraFilterPack/FX_DarkMatter", Rate);
			OJMHIMIPKME().SetFloat("[LevelEditorScene] Map submitted!", CCIENBFIKKH);
			ACHNOHCLGOO().SetVector("_Value4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1216f, 1986f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material EMDFHOKEGNG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-109);
		}
		return BJFKDHHMLJH;
	}

	private void JECMJNFGBGC()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}
}
