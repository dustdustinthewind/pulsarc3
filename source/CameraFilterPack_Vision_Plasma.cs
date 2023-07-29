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
		SCShader = Shader.Find("_PColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KMCPMOGKDEH()
	{
		SCShader = Shader.Find("AudioSampler");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NKFDNIAKGEO()
	{
		SCShader = Shader.Find("#pleasewait");
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
		SCShader = Shader.Find("sprite");
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
			HKHBBBFLGJH().SetFloat("Committing changes...", HBJJOCHGOPH);
			EJDPNJAEAKJ().SetFloat("[PlayerController] ", Value);
			CECICEGFHKL().SetFloat("[Up-Down]", Value2);
			BAGICADFBAB().SetFloat("'{0}'{1}{2}", Intensity);
			NDMPCDHADMJ().SetFloat("DPADVER", CCIENBFIKKH);
			IIJMIPBMMBF().SetVector("Mouse Y", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 795f, 804f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NMDBCDFPGOK());
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
		SCShader = Shader.Find("EditMenu");
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
			LMLENGFLEBD().SetFloat("_Screen", HBJJOCHGOPH);
			CECICEGFHKL().SetFloat("#tryagain", Value);
			PEIMCBBHLBJ().SetFloat("_TimeX", Value2);
			HKHBBBFLGJH().SetFloat("OK", Intensity);
			ENKPNJMPDEB().SetFloat("Set particles count per one beat", CCIENBFIKKH);
			DKNJGHFLAIF().SetVector("]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 877f, 188f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MGMAOBPPOBJ()
	{
		SCShader = Shader.Find("_Intensity");
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
		SCShader = Shader.Find("#{0:00}{1}{2}");
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
			HNFFHCLNBDN().SetFloat("skin.", HBJJOCHGOPH);
			HNFFHCLNBDN().SetFloat("_ScreenResolution", Value);
			NDMPCDHADMJ().SetFloat("_Offsets", Value2);
			NMDBCDFPGOK().SetFloat("LivesSlider", Intensity);
			FLOHGDECHHH().SetFloat("_ScreenResolution", CCIENBFIKKH);
			OIIDAKBILMI().SetVector("_Distortion", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1806f, 1112f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			OGMEGHKECAH().SetFloat("LevelURLInputField", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("0.00", Value);
			GKILCDHJFEG().SetFloat("id", Value2);
			DKNJGHFLAIF().SetFloat("  |  Events Count: ", Intensity);
			KEMJNOMIPHN().SetFloat("#checkpoint", CCIENBFIKKH);
			NDMPCDHADMJ().SetVector("ReconnectAndRejoin() disabled the offline mode. No longer offline.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1441f, 368f));
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
		SCShader = Shader.Find("Preparing content...");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CHOPDIGHJNH()
	{
		SCShader = Shader.Find("Preparing content...");
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
			ENKPNJMPDEB().SetFloat("Error! no audio sources attached to AudioSampler.css", HBJJOCHGOPH);
			NMDBCDFPGOK().SetFloat("]. Please verify you have this gameobject in a Resources folder.", Value);
			NFKFAAHHLLM().SetFloat("/", Value2);
			NDMPCDHADMJ().SetFloat("ShadersToggle", Intensity);
			NDMPCDHADMJ().SetFloat("turn", CCIENBFIKKH);
			PEIMCBBHLBJ().SetVector("_Value4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1956f, 302f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
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
			ENKPNJMPDEB().SetFloat("_DepthLevel", HBJJOCHGOPH);
			NMDBCDFPGOK().SetFloat("RanksButton", Value);
			IIJMIPBMMBF().SetFloat("_Blend", Value2);
			CFEDGDGBCHE().SetFloat("File not found: {0}", Intensity);
			PEIMCBBHLBJ().SetFloat("Uploading content", CCIENBFIKKH);
			IIJMIPBMMBF().SetVector("[PlayerController] ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1619f, 766f));
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
			FLOHGDECHHH().SetFloat("CameraFilterPack/Blend2Camera_LinearBurn", HBJJOCHGOPH);
			OIIDAKBILMI().SetFloat("maps.", Value);
			NMDBCDFPGOK().SetFloat("\0\0", Value2);
			OIIDAKBILMI().SetFloat("custom", Intensity);
			OIIDAKBILMI().SetFloat("#rate!", CCIENBFIKKH);
			HKIMAANBGMJ().SetVector("Crosshair", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 556f, 783f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNFFHCLNBDN());
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
			LMLENGFLEBD().SetFloat("Value", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("_Parameter", Value);
			HCGJCMDJPGD().SetFloat("GLITCH", Value2);
			HNFFHCLNBDN().SetFloat("ClearEnvironment", Intensity);
			FKEOGPDLBDD().SetFloat("_Color_B", CCIENBFIKKH);
			BAGICADFBAB().SetVector("_FixDistance", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 238f, 765f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
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
			FLOHGDECHHH().SetFloat("_Quality", HBJJOCHGOPH);
			EJDPNJAEAKJ().SetFloat("_ScreenResolution", Value);
			NFKFAAHHLLM().SetFloat("id", Value2);
			DKNJGHFLAIF().SetFloat("{0,-18} {1,18}", Intensity);
			CFEDGDGBCHE().SetFloat("ArcsNoHitsoundTimeDelaySlider", CCIENBFIKKH);
			GKILCDHJFEG().SetVector(" respawn in future: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1291f, 1863f));
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
			GKILCDHJFEG().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			CECICEGFHKL().SetFloat("CameraFilterPack/Blend2Camera_LinearBurn", Value);
			NDMPCDHADMJ().SetFloat("_TimeX", Value2);
			CECICEGFHKL().SetFloat("_TimeX", Intensity);
			IIJMIPBMMBF().SetFloat("id", CCIENBFIKKH);
			KGOLDDBHIFN().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 725f, 99f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKHBBBFLGJH());
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
			CFEDGDGBCHE().SetFloat("_Value3", HBJJOCHGOPH);
			OIIDAKBILMI().SetFloat("Editor", Value);
			OIIDAKBILMI().SetFloat("_ScreenResolution", Value2);
			OIIDAKBILMI().SetFloat("DifficultyBG", Intensity);
			HCGJCMDJPGD().SetFloat("downloading", CCIENBFIKKH);
			HCGJCMDJPGD().SetVector("[PlayerBase] SetBGColor error: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 293f, 441f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EDPDMBFLHLP()
	{
		SCShader = Shader.Find("CameraFilterPack/Color_GrayScale");
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
		SCShader = Shader.Find("CameraFilterPack/Glasses_On");
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
			EJDPNJAEAKJ().SetFloat("/", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("Fade", Value);
			OIIDAKBILMI().SetFloat("_FixDistance", Value2);
			LMLENGFLEBD().SetFloat("settings.arcshitsoundtimedelay", Intensity);
			HNFFHCLNBDN().SetFloat("skin.hit_normal", CCIENBFIKKH);
			CECICEGFHKL().SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1558f, 314f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
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
			HCGJCMDJPGD().SetFloat("CameraFilterPack/Lut_Simple", HBJJOCHGOPH);
			BAGICADFBAB().SetFloat("/", Value);
			NMDBCDFPGOK().SetFloat("yes", Value2);
			ENKPNJMPDEB().SetFloat("OxOD.lastPath", Intensity);
			NDMPCDHADMJ().SetFloat("_ScreenResolution", CCIENBFIKKH);
			ENKPNJMPDEB().SetVector("FreqVolume: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 57f, 85f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FIKFJDFELIP()
	{
		SCShader = Shader.Find("player.currentrank");
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
			OGMEGHKECAH().SetFloat("_Value2", HBJJOCHGOPH);
			FLOHGDECHHH().SetFloat("fade in duration", Value);
			FLOHGDECHHH().SetFloat("_Value7", Value2);
			CFEDGDGBCHE().SetFloat("_Threshhold", Intensity);
			PEIMCBBHLBJ().SetFloat("_Bullet_8", CCIENBFIKKH);
			DKNJGHFLAIF().SetVector(" / ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1588f, 1029f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF());
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
		SCShader = Shader.Find("_Visualize");
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
		SCShader = Shader.Find(".lastCheckpoint.correctScore");
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
			ENKPNJMPDEB().SetFloat("inventory.selected.", HBJJOCHGOPH);
			NDMPCDHADMJ().SetFloat("_DistortionSize", Value);
			KBOPGONOCNP().SetFloat("_ScreenResolution", Value2);
			NDMPCDHADMJ().SetFloat("mapselector.filter.subscribedonly", Intensity);
			LNLKMDPHDCC().SetFloat("#no", CCIENBFIKKH);
			DKNJGHFLAIF().SetVector("workshop.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1683f, 1399f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKHBBBFLGJH());
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
		SCShader = Shader.Find("SetPlayerDistance");
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
			FKEOGPDLBDD().SetFloat("offsets", HBJJOCHGOPH);
			FKEOGPDLBDD().SetFloat(".sav", Value);
			KGOLDDBHIFN().SetFloat("_EmissionColor", Value2);
			ENKPNJMPDEB().SetFloat("CameraFilterPack/FX_Plasma", Intensity);
			HCGJCMDJPGD().SetFloat("_LoopCount", CCIENBFIKKH);
			OGMEGHKECAH().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1530f, 1374f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LMLENGFLEBD());
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
		SCShader = Shader.Find("SetRoomStartTimestamp");
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
			FLOHGDECHHH().SetFloat("CameraFilterPack/Distortion_ShockWaveManual", HBJJOCHGOPH);
			PEIMCBBHLBJ().SetFloat("Set Satellite Trail Length", Value);
			NJDIODJNGGA().SetFloat(".png", Value2);
			ENKPNJMPDEB().SetFloat("CameraFilterPack/TV_ARCADE", Intensity);
			OGMEGHKECAH().SetFloat("_NoiseTex", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("Fade", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 605f, 1671f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NJDIODJNGGA());
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
		SCShader = Shader.Find("settings.disablestoryboard");
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
			OGMEGHKECAH().SetFloat("VIGNETTE_DESAT", HBJJOCHGOPH);
			NJDIODJNGGA().SetFloat("_MainTex2", Value);
			NDMPCDHADMJ().SetFloat("skin.", Value2);
			HKIMAANBGMJ().SetFloat("finished", Intensity);
			IIJMIPBMMBF().SetFloat("_Wavy", CCIENBFIKKH);
			IIJMIPBMMBF().SetVector("inventory.selected.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1505f, 1151f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
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
			LMLENGFLEBD().SetFloat("_TimeX", HBJJOCHGOPH);
			HKHBBBFLGJH().SetFloat("_BlurRadius4", Value);
			BAGICADFBAB().SetFloat("Reading preview file failed! Make sure JSON file is filled properly and/or file exists: \"{0}\"", Value2);
			BAGICADFBAB().SetFloat("SpectateButton", Intensity);
			ENKPNJMPDEB().SetFloat("_TimeX", CCIENBFIKKH);
			HKHBBBFLGJH().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1901f, 298f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKHBBBFLGJH());
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
			IIJMIPBMMBF().SetFloat("hand", HBJJOCHGOPH);
			LMLENGFLEBD().SetFloat("CameraFilterPack/Blend2Camera_Darken", Value);
			LMLENGFLEBD().SetFloat("MapFolderInputField", Value2);
			HKIMAANBGMJ().SetFloat("_ScreenResolution", Intensity);
			LNLKMDPHDCC().SetFloat("Texture2", CCIENBFIKKH);
			HKIMAANBGMJ().SetVector(" This is not possible to be called for standalone input. Please check your platform and code where this is called", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 166f, 487f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
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
			BAGICADFBAB().SetFloat("_EdgeSize", HBJJOCHGOPH);
			LMLENGFLEBD().SetFloat("_ScreenResolution", Value);
			NJDIODJNGGA().SetFloat("[ResourcesManager] Unloading data resources", Value2);
			KGOLDDBHIFN().SetFloat("score:", Intensity);
			FKEOGPDLBDD().SetFloat("Text", CCIENBFIKKH);
			OGMEGHKECAH().SetVector("mapselector.tags.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 755f, 921f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
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
		SCShader = Shader.Find("_FrustumCornersWS");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PKLOBJHKFEO()
	{
		SCShader = Shader.Find("</color>");
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
		SCShader = Shader.Find("#,0.00");
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
		SCShader = Shader.Find("_TapLowBackground");
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
		SCShader = Shader.Find("CameraFilterPack_TV_HorrorFX");
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
			BAGICADFBAB().SetFloat("_BorderColor", HBJJOCHGOPH);
			HKIMAANBGMJ().SetFloat("LoadingStatusText", Value);
			FKEOGPDLBDD().SetFloat(".sav", Value2);
			PEIMCBBHLBJ().SetFloat("_Value1", Intensity);
			LMLENGFLEBD().SetFloat("Set Sun MaxSize", CCIENBFIKKH);
			KEMJNOMIPHN().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1937f, 728f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NDMPCDHADMJ());
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
			HCGJCMDJPGD().SetFloat("Dec", HBJJOCHGOPH);
			NMDBCDFPGOK().SetFloat("skin.", Value);
			HKIMAANBGMJ().SetFloat("LevelNameInputField", Value2);
			KGOLDDBHIFN().SetFloat("#turnoninternet", Intensity);
			NMDBCDFPGOK().SetFloat(" SecondsBeforeRespawn: ", CCIENBFIKKH);
			OIIDAKBILMI().SetVector("_History2Weight", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1800f, 1758f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ENKPNJMPDEB());
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
			HKIMAANBGMJ().SetFloat("[ItemsHandler] All in-game items loaded", HBJJOCHGOPH);
			CECICEGFHKL().SetFloat(" but this PhotonView does not exist! View was/is ours.", Value);
			PEIMCBBHLBJ().SetFloat("ShineEffect", Value2);
			CECICEGFHKL().SetFloat("_Saturation", Intensity);
			BAGICADFBAB().SetFloat("settings.disablestoryboard", CCIENBFIKKH);
			NJDIODJNGGA().SetVector("UseFinalGlassColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1350f, 466f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CECICEGFHKL());
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
			OGMEGHKECAH().SetFloat("workshop.", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Vision_Warp2", Value);
			ENKPNJMPDEB().SetFloat("BadgeText", Value2);
			NDMPCDHADMJ().SetFloat("???", Intensity);
			HEINDEMCGIK().SetFloat("maps.", CCIENBFIKKH);
			GKILCDHJFEG().SetVector("ItemTemplate", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 437f, 1215f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
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
			CECICEGFHKL().SetFloat("STOP [R]", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("LevelInfoInputField", Value);
			FLOHGDECHHH().SetFloat("#91CCFF", Value2);
			LMLENGFLEBD().SetFloat("Source: ", Intensity);
			NDMPCDHADMJ().SetFloat("\"", CCIENBFIKKH);
			NDMPCDHADMJ().SetVector("settings.enablehitsoundsinrelax", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1133f, 731f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKIMAANBGMJ());
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
		SCShader = Shader.Find("[MapsStats] Map ID: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MFMIODIAKNI()
	{
	}
}
