// CameraFilterPack_FX_Hypno
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/FX/Hypno")]
[ExecuteInEditMode]
public class CameraFilterPack_FX_Hypno : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 1f)]
	public float Speed = 1f;

	[Range(-2f, 2f)]
	public float Red;

	[Range(-2f, 2f)]
	public float Green = 1f;

	[Range(-2f, 2f)]
	public float Blue = 1f;

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

	private void FGOPJMGNHGO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FGBDGGCBFLP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BGFJOEPFOPM()
	{
	}

	private void FLKEJJEGCFA()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material JLHLHKPHDFO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
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

	private void LLKKGGLNIDF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OHFOLGANOLC()
	{
		SCShader = Shader.Find("CameraFilterPack/TV_WideScreenCircle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
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

	private void FOMNCPKKCFN()
	{
	}

	private void FJNCHGLIEMA()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IEMEHGCFAPD()
	{
	}

	private void KKLMPKLKAEM()
	{
	}

	private void NKFDNIAKGEO()
	{
		SCShader = Shader.Find("not available at the moment");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material LMLENGFLEBD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)97;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HEINDEMCGIK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 799f)
			{
				HBJJOCHGOPH = 1457f;
			}
			NBPKMLMCHFN.SetFloat("Submit", HBJJOCHGOPH);
			FKEOGPDLBDD().SetFloat("CameraFilterPack/Noise_TV_3", Speed);
			FKEOGPDLBDD().SetFloat("--------------------------------", Red);
			OHKGGPFGLFD().SetFloat("</color>", Green);
			FKEOGPDLBDD().SetFloat("Edited unlock conditions", Blue);
			MMOODGIODPC().SetVector("_MainTex2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 858f, 1231f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FDPOFMCFBMF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PFNFPINPCMH()
	{
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Update()
	{
	}

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 711f)
			{
				HBJJOCHGOPH = 1036f;
			}
			OJMHIMIPKME().SetFloat("_MainTex2", HBJJOCHGOPH);
			FKEOGPDLBDD().SetFloat("_Light", Speed);
			NFKFAAHHLLM().SetFloat("TransferOwnership() view ", Red);
			BAGICADFBAB().SetFloat("_ReflectionTexture1", Green);
			FOOCJIDNGBB().SetFloat("shader.frost", Blue);
			LEIAFCPJMDP().SetVector("request", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 720f, 965f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LEIAFCPJMDP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AKHCOBHHGJP()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DBEMDAJDDDA()
	{
		SCShader = Shader.Find("Zoom speed. Base 1.5");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1176f)
			{
				HBJJOCHGOPH = 324f;
			}
			OKJOKHGJHGF().SetFloat("_SizeX", HBJJOCHGOPH);
			KEMJNOMIPHN().SetFloat("EditMenu", Speed);
			JLHLHKPHDFO().SetFloat("[LevelEditorScene] Creating new item...", Red);
			IIJMIPBMMBF().SetFloat("_DepthLevel", Green);
			IIJMIPBMMBF().SetFloat("MapConfig", Blue);
			BAGICADFBAB().SetVector("LevelEditor/icons", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 537f, 194f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GJLKJAOBPJD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OIBMHPIFAKK()
	{
	}

	[SpecialName]
	private Material LELKBCALFCF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void HLIAEEMGBHN()
	{
		SCShader = Shader.Find("PUNCloudBestRegion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ABEIEGDHBNO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material NFKFAAHHLLM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void IMGGCJICLHK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1950f)
			{
				HBJJOCHGOPH = 1132f;
			}
			HCGJCMDJPGD().SetFloat("]", HBJJOCHGOPH);
			LELKBCALFCF().SetFloat("_RampOffset", Speed);
			HEINDEMCGIK().SetFloat("MenuScene", Red);
			NBPKMLMCHFN.SetFloat("Can't change CrcCheckEnabled while being connected. CrcCheckEnabled stays ", Green);
			GKILCDHJFEG().SetFloat("value", Blue);
			EJDPNJAEAKJ().SetVector("-help", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1117f, 398f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material BAGICADFBAB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void ABIOAMNCEOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 499f)
			{
				HBJJOCHGOPH = 1f;
			}
			LMLENGFLEBD().SetFloat("settings.selectormapsperpage", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("In Main Menu", Speed);
			OIMMPLPBLBK().SetFloat("_AxialAberration", Red);
			NFKFAAHHLLM().SetFloat("DPADHOR", Green);
			HEINDEMCGIK().SetFloat("Can't connect: ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings", Blue);
			BAGICADFBAB().SetVector("quantity", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1434f, 496f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JHJFBCFBKLD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NNFMIAFHMJM()
	{
		SCShader = Shader.Find("Creating awesome maps");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DDFCIOMKEEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1920f)
			{
				HBJJOCHGOPH = 1658f;
			}
			OKJOKHGJHGF().SetFloat("_TimeX", HBJJOCHGOPH);
			NFKFAAHHLLM().SetFloat("menu.playedpage", Speed);
			LEIAFCPJMDP().SetFloat("Arc", Red);
			LMLENGFLEBD().SetFloat("[#clicktogetreward]", Green);
			OKJOKHGJHGF().SetFloat("CheckpointsScoreText", Blue);
			LMLENGFLEBD().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 619f, 1278f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1265f)
			{
				HBJJOCHGOPH = 344f;
			}
			IIJMIPBMMBF().SetFloat("SetSatelliteEmission", HBJJOCHGOPH);
			EJDPNJAEAKJ().SetFloat("LevelConfigButton", Speed);
			JLHLHKPHDFO().SetFloat("player.licenceaccepted", Red);
			HNICHJCGJOC().SetFloat("_TimeX", Green);
			EJDPNJAEAKJ().SetFloat("_NoisePerChannel", Blue);
			HNICHJCGJOC().SetVector("CameraFilterPack/FX_Scan", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1841f, 161f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OHKGGPFGLFD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PLEOOAJIMEE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1590f)
			{
				HBJJOCHGOPH = 1061f;
			}
			FOOCJIDNGBB().SetFloat("[MapEditor] Loaded music file: ", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("settings.enablehitsoundsinrelax", Speed);
			BAGICADFBAB().SetFloat("LevelNameText", Red);
			DKNJGHFLAIF().SetFloat("_Value7", Green);
			OCHJIMJNEMO().SetFloat("_ScreenResolution", Blue);
			GKILCDHJFEG().SetVector("2hands", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 112f, 146f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PHJLHCMCCKE()
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
	private Material JIBOKBCPDLC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-107);
		}
		return BJFKDHHMLJH;
	}

	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 517f)
			{
				HBJJOCHGOPH = 1269f;
			}
			OIMMPLPBLBK().SetFloat("player.bat", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("_WhiteBalance", Speed);
			BAGICADFBAB().SetFloat("event", Red);
			OKJOKHGJHGF().SetFloat("Anomaly_Distortion", Green);
			HEINDEMCGIK().SetFloat("maps.", Blue);
			NBPKMLMCHFN.SetVector("SetSatelliteSensitivity", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1730f, 763f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LCHBFNIPBHB()
	{
	}

	private void KMOCDAOKGLI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NEKCPLGFOFD()
	{
	}

	private void FDNONDCGGCG()
	{
		SCShader = Shader.Find("[PlayerController] ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NAOLAJPDGIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KDMANOEMOCA()
	{
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
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
	private Material LEIAFCPJMDP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void GBGAMCPNBCC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DLBODOFAJGM()
	{
		SCShader = Shader.Find("_InvRenderTargetSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material OJMHIMIPKME()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	private void BGDPIHMAACO()
	{
		SCShader = Shader.Find("value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FKEJGBFDCAH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JKBMKPDGCHG()
	{
		SCShader = Shader.Find("x");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CMIBEOJGAIL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
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
	private Material HNICHJCGJOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KEMJNOMIPHN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 816f)
			{
				HBJJOCHGOPH = 1148f;
			}
			HEINDEMCGIK().SetFloat("ReconnectAndRejoin() disabled the offline mode. No longer offline.", HBJJOCHGOPH);
			OHKGGPFGLFD().SetFloat("CameraFilterPack/Drawing_Curve", Speed);
			HEINDEMCGIK().SetFloat("Cross", Red);
			FGENHBKMPDA().SetFloat("set", Green);
			IIJMIPBMMBF().SetFloat("yes", Blue);
			EJDPNJAEAKJ().SetVector("Fade", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1483f, 877f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BMOFEBKGLFI()
	{
		SCShader = Shader.Find("_Far");
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
			BJFKDHHMLJH.hideFlags = (HideFlags)82;
		}
		return BJFKDHHMLJH;
	}

	private void NPLCENPNJBM()
	{
		SCShader = Shader.Find(") then the masterserver requests a disconnect!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IEFMONDKKJN()
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
			NBPKMLMCHFN.SetFloat("_Value", Speed);
			NBPKMLMCHFN.SetFloat("_Value2", Red);
			NBPKMLMCHFN.SetFloat("_Value3", Green);
			NBPKMLMCHFN.SetFloat("_Value4", Blue);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JHANGPCOCIG()
	{
		SCShader = Shader.Find("_ScreenResolution");
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
			BJFKDHHMLJH.hideFlags = (HideFlags)122;
		}
		return BJFKDHHMLJH;
	}

	private void HONBLGFDMLL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material FGENHBKMPDA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material OHKGGPFGLFD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)90;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material OKJOKHGJHGF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 591f)
			{
				HBJJOCHGOPH = 1906f;
			}
			HEINDEMCGIK().SetFloat("[NetworkManager] Join failed", HBJJOCHGOPH);
			LEIAFCPJMDP().SetFloat("skin.hit_perfect", Speed);
			OHKGGPFGLFD().SetFloat("_TimeX", Red);
			OJMHIMIPKME().SetFloat("\"\"", Green);
			FKEOGPDLBDD().SetFloat("#score", Blue);
			JLHLHKPHDFO().SetVector("OnRelease", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1167f, 49f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 884f)
			{
				HBJJOCHGOPH = 1000f;
			}
			HNICHJCGJOC().SetFloat("player.xp", HBJJOCHGOPH);
			FKEOGPDLBDD().SetFloat("_Near", Speed);
			OIMMPLPBLBK().SetFloat("_U", Red);
			JIBOKBCPDLC().SetFloat("1087340967", Green);
			OCHJIMJNEMO().SetFloat("ConfigVersionSlider", Blue);
			NBPKMLMCHFN.SetVector("Back", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 349f, 16f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 979f)
			{
				HBJJOCHGOPH = 1662f;
			}
			EJDPNJAEAKJ().SetFloat("_EmissionGain", HBJJOCHGOPH);
			OHKGGPFGLFD().SetFloat(".save", Speed);
			DKNJGHFLAIF().SetFloat(". Not Destroying GameObject or PhotonViews!", Red);
			OIMMPLPBLBK().SetFloat("_MainTex2", Green);
			LELKBCALFCF().SetFloat("_Saturation", Blue);
			JLHLHKPHDFO().SetVector("SetPosition", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 408f, 56f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OHKGGPFGLFD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DKNJGHFLAIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material FKEOGPDLBDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-91);
		}
		return BJFKDHHMLJH;
	}

	private void EHCGBJDFMHG()
	{
	}

	private void OMCLOFCJMPG()
	{
	}

	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 270f)
			{
				HBJJOCHGOPH = 1812f;
			}
			JIBOKBCPDLC().SetFloat("_Size", HBJJOCHGOPH);
			BAGICADFBAB().SetFloat("Set Object Rotation", Speed);
			IIJMIPBMMBF().SetFloat("Player", Red);
			LMLENGFLEBD().SetFloat(" not exist", Green);
			NBPKMLMCHFN.SetFloat("UI/Particles/Hidden", Blue);
			OCHJIMJNEMO().SetVector("FinalScoreSmallText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1923f, 677f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FOOCJIDNGBB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material MMOODGIODPC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/FX_Hypno");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1155f)
			{
				HBJJOCHGOPH = 183f;
			}
			JIBOKBCPDLC().SetFloat("mapselector.orderby", HBJJOCHGOPH);
			FGENHBKMPDA().SetFloat("red", Speed);
			JIBOKBCPDLC().SetFloat("Set Particle Size", Red);
			EJDPNJAEAKJ().SetFloat("_ScreenResolution", Green);
			FKEOGPDLBDD().SetFloat("CameraFilterPack/Blend2Camera_HardLight", Blue);
			FOOCJIDNGBB().SetVector("This might be a misconfiguration in the game server config. You need to edit it to a (public) address.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 97f, 1467f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GPHPJIDGEPI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GHILDCBCDJI()
	{
	}

	[SpecialName]
	private Material OCHJIMJNEMO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material EJDPNJAEAKJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)105;
		}
		return BJFKDHHMLJH;
	}

	private void IHHNCCOGLPN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HCGJCMDJPGD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void KIEJKBNBHMD()
	{
	}

	private void KNBJBNDGCIJ()
	{
		SCShader = Shader.Find(" cannot be used as a 3D LUT.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HMPGIFBJFIK()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HLLHJIDOOGA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LMADKINICIN()
	{
	}

	private void LCJHDLKJEOM()
	{
	}

	private void AMHEJBMLFNM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BNEJMABFKJE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ODGMCJILIHF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DLMPALHKMON()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1667f)
			{
				HBJJOCHGOPH = 113f;
			}
			OCHJIMJNEMO().SetFloat("CurrentTimeLabel", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("\n", Speed);
			KEMJNOMIPHN().SetFloat("Bad parameters for init! Use \"init\" or \"init <savename>\"", Red);
			EJDPNJAEAKJ().SetFloat("randomdrop", Green);
			BAGICADFBAB().SetFloat("_TimeX", Blue);
			LELKBCALFCF().SetVector("_ExtraLight", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 268f, 129f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DLIJFEGIEKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1406f)
			{
				HBJJOCHGOPH = 661f;
			}
			OHKGGPFGLFD().SetFloat("_Value2", HBJJOCHGOPH);
			FKEOGPDLBDD().SetFloat("[EditorEvent] Exception: ", Speed);
			JIBOKBCPDLC().SetFloat("/", Red);
			HCGJCMDJPGD().SetFloat("_FarCamera", Green);
			JIBOKBCPDLC().SetFloat("grid", Blue);
			HNICHJCGJOC().SetVector("Error: Someone else(", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1112f, 1183f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LGHCJCFHEMF()
	{
		SCShader = Shader.Find("SetSunInput");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LLJLDLLNFBH()
	{
	}

	private void DOEPOGLEGLE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material FOOCJIDNGBB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 928f)
			{
				HBJJOCHGOPH = 1618f;
			}
			LELKBCALFCF().SetFloat("Anomaly_With_Obj", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat(",", Speed);
			MMOODGIODPC().SetFloat("runas", Red);
			HEINDEMCGIK().SetFloat("_Vibrance", Green);
			HCGJCMDJPGD().SetFloat("[ResourcesManager] Load image error: ", Blue);
			JLHLHKPHDFO().SetVector("The directory was created successfully at ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 397f, 33f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DNNFHBOOPIN()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
