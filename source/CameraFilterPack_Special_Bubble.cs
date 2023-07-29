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
			DKKBFFHBHJE().SetFloat("[PlayerController] ", HBJJOCHGOPH);
			BKKJJJGADLM().SetFloat("_Value2", X);
			LNLKMDPHDCC().SetFloat("Set Particles Speed", Y);
			EMDFHOKEGNG().SetFloat("Bad parameters for set! Use <language>", Rate);
			OCHJIMJNEMO().SetFloat("_ScreenResolution", CCIENBFIKKH);
			KBOPGONOCNP().SetVector(" ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 445f, 1789f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
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
			HHIFMIPPMPF().SetFloat("CreateRoom failed. In offline mode you still have to leave a room to enter another.", HBJJOCHGOPH);
			EHDJJANLINB().SetFloat("Operation failed: ", X);
			HHIFMIPPMPF().SetFloat(".lastCheckpoint.playerdistance", Y);
			AELJLBOJAIL().SetFloat("CameraFilterPack/Blend2Camera_BlueScreen", Rate);
			DNLMFEGJJDD().SetFloat("float,2", CCIENBFIKKH);
			HNICHJCGJOC().SetVector("ShadersToggle", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 772f, 256f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
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
			EMDFHOKEGNG().SetFloat("CameraFilterPack/FX_Glitch2", HBJJOCHGOPH);
			OCHJIMJNEMO().SetFloat("Oct", X);
			KBOPGONOCNP().SetFloat("<color=#", Y);
			IIJMIPBMMBF().SetFloat("_Value2", Rate);
			ACHNOHCLGOO().SetFloat("_Value2", CCIENBFIKKH);
			PHGCJOPFDOG().SetVector("\n\n#", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 597f, 250f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
		SCShader = Shader.Find("yesterday");
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
		SCShader = Shader.Find(".workshop.json");
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
			PHGCJOPFDOG().SetFloat("_LrDepthTex", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("BitsData", X);
			OJMHIMIPKME().SetFloat("No regions available. Are you sure your appid is valid and setup?", Y);
			NBPKMLMCHFN.SetFloat("Editor/", Rate);
			AELJLBOJAIL().SetFloat("bloomintencity:", CCIENBFIKKH);
			EMDFHOKEGNG().SetVector("EventSystem", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 687f, 816f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
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
		SCShader = Shader.Find("_NoOuterClip");
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
			IIJMIPBMMBF().SetFloat("id", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("PlayMapsSeriesGoal", X);
			IIJMIPBMMBF().SetFloat("Mouse Y", Y);
			DNLMFEGJJDD().SetFloat("y", Rate);
			ACHNOHCLGOO().SetFloat("_TimeX", CCIENBFIKKH);
			NLFJGMBCICG().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1146f, 1281f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
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
			NLFJGMBCICG().SetFloat("achievements.21.progress", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("_EmissionColor", X);
			FHFLKLMFHOI().SetFloat("_TimeX", Y);
			PDEAHJPOMEF().SetFloat("Vertical", Rate);
			NBPKMLMCHFN.SetFloat("shader.frost", CCIENBFIKKH);
			DNLMFEGJJDD().SetVector("_ColorB", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 352f, 1756f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF());
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
			PHGCJOPFDOG().SetFloat("Freq: ", HBJJOCHGOPH);
			KEMJNOMIPHN().SetFloat("CameraFilterPack/TV_WideScreenVertical", X);
			LNLKMDPHDCC().SetFloat("[TextSaver] Text saved to ", Y);
			KEMJNOMIPHN().SetFloat("DPADHOR", Rate);
			DNLMFEGJJDD().SetFloat("SfxVolumeSlider", CCIENBFIKKH);
			HHIFMIPPMPF().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1867f, 1808f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OJMHIMIPKME());
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
			DKKBFFHBHJE().SetFloat("CameraFilterPack/3D_Myst", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("_Blurred", X);
			PDEAHJPOMEF().SetFloat("[PlayerController] ", Y);
			NLFJGMBCICG().SetFloat("DifficultyBG", Rate);
			NLFJGMBCICG().SetFloat("Object ID. Case-Sensitive", CCIENBFIKKH);
			NLFJGMBCICG().SetVector("Instrumental", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 52f, 1088f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
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
		SCShader = Shader.Find("PerfectHitsScoreText");
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
			HHIFMIPPMPF().SetFloat("OnAwakeRPC", HBJJOCHGOPH);
			KEMJNOMIPHN().SetFloat("#lives", X);
			KEMJNOMIPHN().SetFloat("Failed to InstantiateSceneObject prefab:", Y);
			ACHNOHCLGOO().SetFloat("_MainTex2", Rate);
			PDEAHJPOMEF().SetFloat("tagElement", CCIENBFIKKH);
			BKKJJJGADLM().SetVector("_Value4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 440f, 238f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
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
			OCHJIMJNEMO().SetFloat("Particles/Additive", HBJJOCHGOPH);
			EHDJJANLINB().SetFloat("_Value", X);
			FHFLKLMFHOI().SetFloat("bad", Y);
			DNLMFEGJJDD().SetFloat("CameraFilterPack/FX_Glitch2", Rate);
			LNLKMDPHDCC().SetFloat("_ScreenResolution", CCIENBFIKKH);
			KBOPGONOCNP().SetVector("_Green_G", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1771f, 1188f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FMFNILJIEIA()
	{
		SCShader = Shader.Find("_ScreenResolution");
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
			HHIFMIPPMPF().SetFloat("_Parameter", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("_Blue_C", X);
			ACHNOHCLGOO().SetFloat(" scene view IDs from last level.", Y);
			PDEAHJPOMEF().SetFloat("_MatrixSize", Rate);
			AELJLBOJAIL().SetFloat("_ScreenResolution", CCIENBFIKKH);
			IIJMIPBMMBF().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1242f, 610f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
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
			EMDFHOKEGNG().SetFloat("%]</b> ", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("/", X);
			PDEAHJPOMEF().SetFloat("Authentication failed: '{0}' Code: {1}", Y);
			HNICHJCGJOC().SetFloat("#tryagain", Rate);
			OJMHIMIPKME().SetFloat("Down", CCIENBFIKKH);
			HNICHJCGJOC().SetVector("Destroying GO as global. ID: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1369f, 313f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
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
			AELJLBOJAIL().SetFloat("EnableRankingToggle", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("_MainTex2", X);
			IIJMIPBMMBF().SetFloat("EventMenu", Y);
			IIJMIPBMMBF().SetFloat("_TapMedium", Rate);
			NBPKMLMCHFN.SetFloat("_TimeX", CCIENBFIKKH);
			DKKBFFHBHJE().SetVector("DifficultyBG", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1662f, 466f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HIPEHGNBJMN()
	{
		SCShader = Shader.Find(".wav");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FIKFJDFELIP()
	{
		SCShader = Shader.Find("[LocalizationService] Localization: ");
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
			EHDJJANLINB().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			KEMJNOMIPHN().SetFloat("_Value3", X);
			KEMJNOMIPHN().SetFloat(".highscore", Y);
			PDEAHJPOMEF().SetFloat("_Amount", Rate);
			OCHJIMJNEMO().SetFloat("_Value4", CCIENBFIKKH);
			BKKJJJGADLM().SetVector("CameraFilterPack/Drawing_CellShading", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 31f, 287f));
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
			IIJMIPBMMBF().SetFloat("_Value2", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("[MapsData] Preloading ", X);
			KBOPGONOCNP().SetFloat(".played", Y);
			AELJLBOJAIL().SetFloat("_Fade", Rate);
			KBOPGONOCNP().SetFloat("w", CCIENBFIKKH);
			NLFJGMBCICG().SetVector(". Should be just one?", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1364f, 232f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF());
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
			KEMJNOMIPHN().SetFloat("master", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", X);
			HNICHJCGJOC().SetFloat(".lastCheckpoint.longestComboScore", Y);
			KBOPGONOCNP().SetFloat("Data", Rate);
			ACHNOHCLGOO().SetFloat("CameraFilterPack/TV_MovieNoise", CCIENBFIKKH);
			DKKBFFHBHJE().SetVector("CameraFilterPack/Colors_DarkColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1060f, 776f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
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
			ACHNOHCLGOO().SetFloat("workshop.", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("_Distortion", X);
			ACHNOHCLGOO().SetFloat("CameraFilterPack/Blur_Blurry", Y);
			OCHJIMJNEMO().SetFloat("Set particles gravity", Rate);
			LNLKMDPHDCC().SetFloat("_Size", CCIENBFIKKH);
			HNICHJCGJOC().SetVector("_MainTex2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 345f, 87f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
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
			KBOPGONOCNP().SetFloat("_FixDistance", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("Set Arcs Speed", X);
			AELJLBOJAIL().SetFloat("_EdgeSharpness", Y);
			OJMHIMIPKME().SetFloat("_MainTex2", Rate);
			HNICHJCGJOC().SetFloat(":\n", CCIENBFIKKH);
			EMDFHOKEGNG().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 839f, 1182f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
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
			PDEAHJPOMEF().SetFloat("EventData0DropDownList", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Overlay", X);
			PHGCJOPFDOG().SetFloat("_TimeX", Y);
			OJMHIMIPKME().SetFloat("(\\[ *b *\\])", Rate);
			LNLKMDPHDCC().SetFloat("#forever", CCIENBFIKKH);
			FHFLKLMFHOI().SetVector("OnStatusChanged: {0} current State: {1}", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1769f, 858f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
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
			DKKBFFHBHJE().SetFloat("Tab2Content", HBJJOCHGOPH);
			EHDJJANLINB().SetFloat("/?player=", X);
			EMDFHOKEGNG().SetFloat("_Tint", Y);
			KEMJNOMIPHN().SetFloat("_MaxRadiusOrKInPaper", Rate);
			NLFJGMBCICG().SetFloat("The given 2D texture ", CCIENBFIKKH);
			FHFLKLMFHOI().SetVector(" : ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 948f, 431f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
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
			AELJLBOJAIL().SetFloat("[PlayerBase] Unknown event: ", HBJJOCHGOPH);
			EHDJJANLINB().SetFloat(" joined", X);
			ACHNOHCLGOO().SetFloat("#timeuntilchallenge: ", Y);
			IIJMIPBMMBF().SetFloat("_Value2", Rate);
			PHGCJOPFDOG().SetFloat("_ScreenResolution", CCIENBFIKKH);
			PHGCJOPFDOG().SetVector("_ChangeBlue", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 479f, 900f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
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
			KEMJNOMIPHN().SetFloat("In Network lobby", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("settings.volume.sfx", X);
			PDEAHJPOMEF().SetFloat("_Overlay", Y);
			NLFJGMBCICG().SetFloat("[MapsData] Bad map: ", Rate);
			EHDJJANLINB().SetFloat("Value", CCIENBFIKKH);
			OJMHIMIPKME().SetVector("_Value5", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 585f, 1330f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
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
			OJMHIMIPKME().SetFloat("Tab2Content", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat("_Offsets", X);
			KBOPGONOCNP().SetFloat("menu.selectedlevelid", Y);
			HNICHJCGJOC().SetFloat("_ScreenResolution", Rate);
			IIJMIPBMMBF().SetFloat("OnDeserialize", CCIENBFIKKH);
			DNLMFEGJJDD().SetVector("player.blackwhite", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 617f, 892f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF());
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
			OJMHIMIPKME().SetFloat("_Value4", HBJJOCHGOPH);
			KEMJNOMIPHN().SetFloat("_Value", X);
			KBOPGONOCNP().SetFloat("challenges/", Y);
			EMDFHOKEGNG().SetFloat("_MainTex", Rate);
			AELJLBOJAIL().SetFloat(" does not exist!", CCIENBFIKKH);
			LNLKMDPHDCC().SetVector(" with a prefix of ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 423f, 1019f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FBPHNEJBDJN()
	{
		SCShader = Shader.Find("ResourceIDInputField");
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
			NBPKMLMCHFN.SetFloat("st", HBJJOCHGOPH);
			EHDJJANLINB().SetFloat("GlassesColor2", X);
			KEMJNOMIPHN().SetFloat("{0} months ago", Y);
			PHGCJOPFDOG().SetFloat("_TimeX", Rate);
			HHIFMIPPMPF().SetFloat("Done!", CCIENBFIKKH);
			FHFLKLMFHOI().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1216f, 1986f));
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
