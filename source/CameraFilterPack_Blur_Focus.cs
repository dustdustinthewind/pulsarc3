// CameraFilterPack_Blur_Focus
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Blur/Focus")]
public class CameraFilterPack_Blur_Focus : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(-1f, 1f)]
	public float CenterX;

	[Range(-1f, 1f)]
	public float CenterY;

	[Range(0f, 10f)]
	public float _Size = 5f;

	[Range(0.12f, 64f)]
	public float _Eyes = 2f;

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

	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1498f)
			{
				HBJJOCHGOPH = 261f;
			}
			HNICHJCGJOC().SetFloat("x", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("[MapEditor] Reset", CenterX);
			PDEAHJPOMEF().SetFloat("#no", CenterY);
			float value = Mathf.Round(_Size / 1256f) * 378f;
			NBMPPNFKFLB().SetFloat("_ScreenResolution", value);
			DEFBJOCJJKF().SetFloat("intensity", _Eyes);
			HNICHJCGJOC().SetVector(".highscore", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1086f)
			{
				HBJJOCHGOPH = 722f;
			}
			EFDEIFCDAFG().SetFloat("_HrDepthTex", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("_Value2", CenterX);
			EPCGJFCCAFH().SetFloat("_ColorBuffer", CenterY);
			float value = Mathf.Round(_Size / 518f) * 690f;
			DEFBJOCJJKF().SetFloat(": ", value);
			NBMPPNFKFLB().SetFloat(";", _Eyes);
			DEFBJOCJJKF().SetVector("\n", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Blur_Focus");
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
			NBPKMLMCHFN.SetFloat("_CenterX", CenterX);
			NBPKMLMCHFN.SetFloat("_CenterY", CenterY);
			float value = Mathf.Round(_Size / 0.2f) * 0.2f;
			NBPKMLMCHFN.SetFloat("_Size", value);
			NBPKMLMCHFN.SetFloat("_Circle", _Eyes);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LOMDIOLNFHI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1546f)
			{
				HBJJOCHGOPH = 1734f;
			}
			HNICHJCGJOC().SetFloat("value", HBJJOCHGOPH);
			PGPEMMBJOOG().SetFloat(" while connecting to: ", CenterX);
			DEFBJOCJJKF().SetFloat("_ScreenResolution", CenterY);
			float value = Mathf.Round(_Size / 969f) * 1118f;
			IGIAPKPKGPK().SetFloat("MessageText", value);
			PDEAHJPOMEF().SetFloat("Fake", _Eyes);
			EPCGJFCCAFH().SetVector("IconImage", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DEFBJOCJJKF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-78);
		}
		return BJFKDHHMLJH;
	}

	private void FOMNCPKKCFN()
	{
	}

	private void JAAJECBCCFM()
	{
	}

	private void EHCGBJDFMHG()
	{
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FHPFJBFCOOF()
	{
		SCShader = Shader.Find("Deleted data");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GJLKJAOBPJD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material PGPEMMBJOOG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material ADBKPGFMNKO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)95;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material OIMMPLPBLBK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)112;
		}
		return BJFKDHHMLJH;
	}

	private void LEAHIBJDMBI()
	{
	}

	private void HLIAEEMGBHN()
	{
		SCShader = Shader.Find("cmd.exe");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1570f)
			{
				HBJJOCHGOPH = 1540f;
			}
			LONNIJMNKFB().SetFloat("workshop.", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("DPADHOR", CenterX);
			EPCGJFCCAFH().SetFloat("playing", CenterY);
			float value = Mathf.Round(_Size / 638f) * 646f;
			HNICHJCGJOC().SetFloat("CameraFilterPack/Distortion_Flush", value);
			HNICHJCGJOC().SetFloat("_Value", _Eyes);
			PGPEMMBJOOG().SetVector("0", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NBGIMIDICKE()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IHLMNAGPKDA()
	{
		SCShader = Shader.Find("[PlayerController] ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1498f)
			{
				HBJJOCHGOPH = 1522f;
			}
			ADBKPGFMNKO().SetFloat("_Curve", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat(" [", CenterX);
			PDEAHJPOMEF().SetFloat(">", CenterY);
			float value = Mathf.Round(_Size / 718f) * 1683f;
			NBPKMLMCHFN.SetFloat("CameraFilterPack/TV_Old", value);
			EPCGJFCCAFH().SetFloat("_Value3", _Eyes);
			DEFBJOCJJKF().SetVector("_TimeX", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KIMMMCJFMAB()
	{
		SCShader = Shader.Find("[SaveSystem] Init from ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FBMDHDBELEK()
	{
	}

	private void Update()
	{
	}

	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 637f)
			{
				HBJJOCHGOPH = 1842f;
			}
			EFDEIFCDAFG().SetFloat("_EmissionGain", HBJJOCHGOPH);
			IGIAPKPKGPK().SetFloat("0.00", CenterX);
			PDEAHJPOMEF().SetFloat("No Name", CenterY);
			float value = Mathf.Round(_Size / 1876f) * 282f;
			NBMPPNFKFLB().SetFloat("_ScreenResolution", value);
			ADBKPGFMNKO().SetFloat("maps.", _Eyes);
			EPCGJFCCAFH().SetVector("Editor/", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1793f)
			{
				HBJJOCHGOPH = 1476f;
			}
			EFDEIFCDAFG().SetFloat("_Noise", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("TypedLobbyInfo '{0}'[{1}] rooms: {2} players: {3}", CenterX);
			NBMPPNFKFLB().SetFloat("_Offsets", CenterY);
			float value = Mathf.Round(_Size / 914f) * 46f;
			DEFBJOCJJKF().SetFloat("_TimeX", value);
			EPCGJFCCAFH().SetFloat("#no", _Eyes);
			EFDEIFCDAFG().SetVector("_RandomTexture", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material EFDEIFCDAFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void BJOHDLNDFAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 67f)
			{
				HBJJOCHGOPH = 1293f;
			}
			OIMMPLPBLBK().SetFloat("[PlayerBase] SetSpeed error: ", HBJJOCHGOPH);
			IGIAPKPKGPK().SetFloat("CameraFilterPack/Light_Rainbow2", CenterX);
			PDEAHJPOMEF().SetFloat("RestartButton", CenterY);
			float value = Mathf.Round(_Size / 155f) * 1146f;
			EFDEIFCDAFG().SetFloat("/", value);
			ADBKPGFMNKO().SetFloat("\n", _Eyes);
			NBPKMLMCHFN.SetVector("ScreenResolutionPanel", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
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

	[SpecialName]
	private Material LONNIJMNKFB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 808f)
			{
				HBJJOCHGOPH = 734f;
			}
			IGIAPKPKGPK().SetFloat("MenuScene", HBJJOCHGOPH);
			PGPEMMBJOOG().SetFloat("_Glow", CenterX);
			IGIAPKPKGPK().SetFloat("No Name", CenterY);
			float value = Mathf.Round(_Size / 1528f) * 304f;
			HNICHJCGJOC().SetFloat("CameraFilterPack/Blend2Camera_Saturation", value);
			HNICHJCGJOC().SetFloat("Reset 21 achievement progress", _Eyes);
			NBMPPNFKFLB().SetVector("_ScreenResolution", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-120);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IGIAPKPKGPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInHierarchy | HideFlags.HideInInspector);
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

	[SpecialName]
	private Material HNICHJCGJOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material EPCGJFCCAFH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)78;
		}
		return BJFKDHHMLJH;
	}

	private void JHPOIOELNCG()
	{
	}

	private void FANADGBGCPI()
	{
		SCShader = Shader.Find("(");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IMCKJCHKMKB()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1224f)
			{
				HBJJOCHGOPH = 732f;
			}
			HNICHJCGJOC().SetFloat("_RgbTex", HBJJOCHGOPH);
			ADBKPGFMNKO().SetFloat("The server address is 127.0.0.1 (localhost): Make sure the server is running on this machine. Android and iOS emulators have their own localhost.", CenterX);
			IGIAPKPKGPK().SetFloat("ns", CenterY);
			float value = Mathf.Round(_Size / 694f) * 1813f;
			LONNIJMNKFB().SetFloat("_Value3", value);
			NBPKMLMCHFN.SetFloat("_TimeX", _Eyes);
			DEFBJOCJJKF().SetVector("inventory.lastitemscount", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IIFCIDDJHPM()
	{
	}

	private void JHJGJJKELJM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material NBMPPNFKFLB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-117);
		}
		return BJFKDHHMLJH;
	}

	private void GKNKIIEALCH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CNGAJDBOCLJ()
	{
		SCShader = Shader.Find("#getrewardfailed: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JMEOGJHCONJ()
	{
		SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MMBPLGGLPDB()
	{
	}

	private void OEENOOGEEHD()
	{
	}

	private void BGDPIHMAACO()
	{
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
