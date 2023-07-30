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
		SCShader = Shader.Find("_Tint");
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
		SCShader = Shader.Find("_TimeX");
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
		SCShader = Shader.Find("_Value3");
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
		SCShader = Shader.Find("Can't connect: ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings");
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
			HEINDEMCGIK().SetFloat("Horizontal", HBJJOCHGOPH);
			HEINDEMCGIK().SetFloat("Texture2", Speed);
			OIMMPLPBLBK().SetFloat("0.00", Red);
			OJMHIMIPKME().SetFloat("<color=white>PhotonView Group: ", Green);
			LEIAFCPJMDP().SetFloat("grid", Blue);
			DKNJGHFLAIF().SetVector("_Amount", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 858f, 1231f));
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
			OKJOKHGJHGF().SetFloat("UseScanLine", HBJJOCHGOPH);
			KEMJNOMIPHN().SetFloat("_Intensity", Speed);
			HCGJCMDJPGD().SetFloat(" from: ", Red);
			OKJOKHGJHGF().SetFloat("_HitPointTexture", Green);
			OJMHIMIPKME().SetFloat("shader.sunny", Blue);
			DKNJGHFLAIF().SetVector("steamid", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 720f, 965f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LEIAFCPJMDP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AKHCOBHHGJP()
	{
		SCShader = Shader.Find("CameraFilterPack/Vision_Warp");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DBEMDAJDDDA()
	{
		SCShader = Shader.Find("speed");
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
			OCHJIMJNEMO().SetFloat("_SizeX", HBJJOCHGOPH);
			FKEOGPDLBDD().SetFloat("EditMenu", Speed);
			DKNJGHFLAIF().SetFloat("OK", Red);
			KEMJNOMIPHN().SetFloat("_TimeX", Green);
			LMLENGFLEBD().SetFloat("Editor", Blue);
			FKEOGPDLBDD().SetVector("_EmissionColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 537f, 194f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EJDPNJAEAKJ());
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
		SCShader = Shader.Find("{0}={2}: {1} \"{3}\"");
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
			LEIAFCPJMDP().SetFloat("Event Received", HBJJOCHGOPH);
			KEMJNOMIPHN().SetFloat("_MainTex", Speed);
			OHKGGPFGLFD().SetFloat("MenuScene", Red);
			FGENHBKMPDA().SetFloat("Can't start OFFLINE mode while connected!", Green);
			OHKGGPFGLFD().SetFloat("value", Blue);
			OJMHIMIPKME().SetVector("float", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1117f, 398f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
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
			GKILCDHJFEG().SetFloat("Search: ", HBJJOCHGOPH);
			FKEOGPDLBDD().SetFloat("[MenuScene] Error: ", Speed);
			OCHJIMJNEMO().SetFloat("_VignetteTex", Red);
			MMOODGIODPC().SetFloat("DPADHOR", Green);
			JLHLHKPHDFO().SetFloat("Can't connect: Loading settings failed. ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings", Blue);
			KEMJNOMIPHN().SetVector("steamid", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1434f, 496f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
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
		SCShader = Shader.Find("PLEASE WAIT");
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
			LMLENGFLEBD().SetFloat("CameraFilterPack/Color_Sepia", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("menu.playedpage", Speed);
			OIMMPLPBLBK().SetFloat("Arc", Red);
			LELKBCALFCF().SetFloat("BlockCount", Green);
			FOOCJIDNGBB().SetFloat("CheckpointsScoreText", Blue);
			JLHLHKPHDFO().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 619f, 1278f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LMLENGFLEBD());
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
			GKILCDHJFEG().SetFloat("SetSunLerpSpeed", HBJJOCHGOPH);
			LMLENGFLEBD().SetFloat("LevelConfigButton", Speed);
			NFKFAAHHLLM().SetFloat("player.licenceaccepted", Red);
			DKNJGHFLAIF().SetFloat("_MainTex2", Green);
			MMOODGIODPC().SetFloat("_DX11NoiseTime", Blue);
			IIJMIPBMMBF().SetVector("_Distortion", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1841f, 161f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
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
			JIBOKBCPDLC().SetFloat("/", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("powerup.1", Speed);
			HNICHJCGJOC().SetFloat("InfoCanvas", Red);
			FKEOGPDLBDD().SetFloat("_Value7", Green);
			IIJMIPBMMBF().SetFloat("_Value2", Blue);
			OJMHIMIPKME().SetVector(":", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 112f, 146f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
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
			OCHJIMJNEMO().SetFloat("shader.frost", HBJJOCHGOPH);
			FOOCJIDNGBB().SetFloat("_NeutralTonemapperParams1", Speed);
			OHKGGPFGLFD().SetFloat("checkpoint", Red);
			HNICHJCGJOC().SetFloat("Anomaly_Distortion", Green);
			HCGJCMDJPGD().SetFloat("maps.", Blue);
			OKJOKHGJHGF().SetVector("SetSatelliteSensitivity", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1730f, 763f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EJDPNJAEAKJ());
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
		SCShader = Shader.Find(" not exist");
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
		SCShader = Shader.Find("offsets");
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
		SCShader = Shader.Find(": ");
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
			DKNJGHFLAIF().SetFloat("Reconnect() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", HBJJOCHGOPH);
			JLHLHKPHDFO().SetFloat("_ScreenResolution", Speed);
			JIBOKBCPDLC().SetFloat("Joystick1Button1", Red);
			GKILCDHJFEG().SetFloat("Localization Servise\nWorking commands:\nset <language>\nlist\nkeys", Green);
			LELKBCALFCF().SetFloat("menu.resetlevelcheckpoint", Blue);
			GKILCDHJFEG().SetVector("_Distortion", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1483f, 877f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BMOFEBKGLFI()
	{
		SCShader = Shader.Find("_Near");
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
		SCShader = Shader.Find(" Time: ");
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
		SCShader = Shader.Find("_Value2");
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
			FGENHBKMPDA().SetFloat("[NetworkManager] Join failed", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("skin.hit_perfect", Speed);
			FGENHBKMPDA().SetFloat("_TimeX", Red);
			NBPKMLMCHFN.SetFloat("_Value1", Green);
			OCHJIMJNEMO().SetFloat("#score", Blue);
			LMLENGFLEBD().SetVector("OnPress", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1167f, 49f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BAGICADFBAB());
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
			MMOODGIODPC().SetFloat("Emergency Help:", HBJJOCHGOPH);
			JIBOKBCPDLC().SetFloat("_Near", Speed);
			JLHLHKPHDFO().SetFloat("_Y", Red);
			LELKBCALFCF().SetFloat("1248864821", Green);
			OCHJIMJNEMO().SetFloat("SpeedSlider", Blue);
			OJMHIMIPKME().SetVector("Joystick1Button8", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 349f, 16f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
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
			FGENHBKMPDA().SetFloat("_EmissionGain", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat(".save", Speed);
			OCHJIMJNEMO().SetFloat("Failed to 'network-remove' GameObject. Client is neither owner nor masterClient taking over for owner who left: ", Red);
			FKEOGPDLBDD().SetFloat("_Value5", Green);
			LELKBCALFCF().SetFloat("_ZCurve", Blue);
			JIBOKBCPDLC().SetVector("SetPosition", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 408f, 56f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
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
			OHKGGPFGLFD().SetFloat("_Color_B", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("Set Object Rotation", Speed);
			JIBOKBCPDLC().SetFloat("UpdateNewsTileStart", Red);
			JIBOKBCPDLC().SetFloat("[PlayerController] ", Green);
			HEINDEMCGIK().SetFloat("_CutOff", Blue);
			HCGJCMDJPGD().SetVector("FinalScoreSmallText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1923f, 677f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
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
			HNICHJCGJOC().SetFloat("mapselector.orderby", HBJJOCHGOPH);
			EJDPNJAEAKJ().SetFloat("red", Speed);
			JLHLHKPHDFO().SetFloat("SetParticlesParticleSize", Red);
			OKJOKHGJHGF().SetFloat("_Value", Green);
			NFKFAAHHLLM().SetFloat("CameraFilterPack/Blend2Camera_HardLight", Blue);
			FOOCJIDNGBB().SetVector("127.0.0.1", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 97f, 1467f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
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
		SCShader = Shader.Find("The given 2D texture ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HMPGIFBJFIK()
	{
		SCShader = Shader.Find("_Value");
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
			JLHLHKPHDFO().SetFloat("CurrentTimeLabel", HBJJOCHGOPH);
			BAGICADFBAB().SetFloat("\n", Speed);
			IIJMIPBMMBF().SetFloat("Bad parameters for init! Use \"init\" or \"init <savename>\"", Red);
			LELKBCALFCF().SetFloat(" ", Green);
			FOOCJIDNGBB().SetFloat("CameraFilterPack/Distortion_Twist_Square", Blue);
			LMLENGFLEBD().SetVector("_PosY", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 268f, 129f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
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
			EJDPNJAEAKJ().SetFloat("_Value2", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("_EmissionColor", Speed);
			OKJOKHGJHGF().SetFloat("/", Red);
			LMLENGFLEBD().SetFloat("_FarCamera", Green);
			OHKGGPFGLFD().SetFloat("GridDataStoryboard", Blue);
			FGENHBKMPDA().SetVector("Ev OwnershipTransfer. ViewID ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1112f, 1183f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LGHCJCFHEMF()
	{
		SCShader = Shader.Find("Set sun emission (glow)");
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
			JIBOKBCPDLC().SetFloat("Anomaly_With_Obj", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat(".GoalProgress", Speed);
			FKEOGPDLBDD().SetFloat("runas", Red);
			OJMHIMIPKME().SetFloat("_Gain", Green);
			LMLENGFLEBD().SetFloat("shader.none", Blue);
			EJDPNJAEAKJ().SetVector("Loaded Game: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 397f, 33f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OHKGGPFGLFD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DNNFHBOOPIN()
	{
		SCShader = Shader.Find("CameraFilterPack/Drawing_Comics");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
