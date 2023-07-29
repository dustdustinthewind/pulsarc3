// CameraFilterPack_Blur_Focus
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Blur/Focus")]
[ExecuteInEditMode]
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
			EFDEIFCDAFG().SetFloat("y", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("Paste events", CenterX);
			PGPEMMBJOOG().SetFloat("ticket", CenterY);
			float value = Mathf.Round(_Size / 1256f) * 378f;
			ADBKPGFMNKO().SetFloat("_ScreenResolution", value);
			PDEAHJPOMEF().SetFloat("_AdaptTex", _Eyes);
			EPCGJFCCAFH().SetVector(".highscore", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
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
			LONNIJMNKFB().SetFloat("intensity", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("_Value3", CenterX);
			DEFBJOCJJKF().SetFloat("colorA", CenterY);
			float value = Mathf.Round(_Size / 518f) * 690f;
			ADBKPGFMNKO().SetFloat(" not exist", value);
			ADBKPGFMNKO().SetFloat(";", _Eyes);
			LONNIJMNKFB().SetVector("\n", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
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
			ADBKPGFMNKO().SetFloat("value", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat(". Check if the server is available.", CenterX);
			PDEAHJPOMEF().SetFloat("CameraFilterPack/Blend2Camera_PinLight", CenterY);
			float value = Mathf.Round(_Size / 969f) * 1118f;
			DEFBJOCJJKF().SetFloat("MessageText", value);
			PGPEMMBJOOG().SetFloat("Selection Box", _Eyes);
			ADBKPGFMNKO().SetVector("ItemNameBGImage", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
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
		SCShader = Shader.Find("EventSystem");
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
			ADBKPGFMNKO().SetFloat("workshop.", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Mouse X", CenterX);
			EPCGJFCCAFH().SetFloat("OpJoinLobby()", CenterY);
			float value = Mathf.Round(_Size / 638f) * 646f;
			OIMMPLPBLBK().SetFloat("CameraFilterPack/Distortion_Flush", value);
			ADBKPGFMNKO().SetFloat("_Value2", _Eyes);
			OIMMPLPBLBK().SetVector("Emergency Help:", new Vector2(Screen.width, Screen.height));
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
		SCShader = Shader.Find(": ");
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
			HNICHJCGJOC().SetFloat("_ExposureAdjustment", HBJJOCHGOPH);
			ADBKPGFMNKO().SetFloat("]", CenterX);
			PDEAHJPOMEF().SetFloat("#", CenterY);
			float value = Mathf.Round(_Size / 718f) * 1683f;
			DEFBJOCJJKF().SetFloat("_TimeX", value);
			OIMMPLPBLBK().SetFloat("_Speed", _Eyes);
			LONNIJMNKFB().SetVector("_Value", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KIMMMCJFMAB()
	{
		SCShader = Shader.Find("[SaveSystem] Outdated savefile found");
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
			NBPKMLMCHFN.SetFloat("_EmissionGain", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("EVENT CONFIG [Ctrl+E]", CenterX);
			EFDEIFCDAFG().SetFloat("No Name", CenterY);
			float value = Mathf.Round(_Size / 1876f) * 282f;
			EFDEIFCDAFG().SetFloat("_ScreenResolution", value);
			PDEAHJPOMEF().SetFloat("music.ogg", _Eyes);
			NBMPPNFKFLB().SetVector("LoadMapCanvas", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
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
			NBPKMLMCHFN.SetFloat("_Intensity", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("{0}{1}{2}={3}", CenterX);
			LONNIJMNKFB().SetFloat("_Offsets", CenterY);
			float value = Mathf.Round(_Size / 914f) * 46f;
			NBPKMLMCHFN.SetFloat("_ScreenResolution", value);
			LONNIJMNKFB().SetFloat("ticket", _Eyes);
			NBMPPNFKFLB().SetVector("_NoiseScale", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
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
			LONNIJMNKFB().SetFloat("[PlayerBase] Checkpoint error: ", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("_TimeX", CenterX);
			IGIAPKPKGPK().SetFloat("RestartButton", CenterY);
			float value = Mathf.Round(_Size / 155f) * 1146f;
			PGPEMMBJOOG().SetFloat("/", value);
			ADBKPGFMNKO().SetFloat("\t", _Eyes);
			EPCGJFCCAFH().SetVector("ScreenResolutionPanel", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
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
			NBPKMLMCHFN.SetFloat("challenges.", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("_ScreenResolution", CenterX);
			NBPKMLMCHFN.SetFloat("music.ogg", CenterY);
			float value = Mathf.Round(_Size / 1528f) * 304f;
			LONNIJMNKFB().SetFloat("CameraFilterPack/Blend2Camera_Saturation", value);
			PDEAHJPOMEF().SetFloat("1248864821", _Eyes);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
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
		SCShader = Shader.Find("[PlayerBase] SetPlayerDistance error: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IMCKJCHKMKB()
	{
		SCShader = Shader.Find("_Level");
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
			HNICHJCGJOC().SetFloat("selColor", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat(" while connecting to: ", CenterX);
			DEFBJOCJJKF().SetFloat("Using WebSocket to connect NameServer (AuthMode is AuthOnceWss).", CenterY);
			float value = Mathf.Round(_Size / 694f) * 1813f;
			PGPEMMBJOOG().SetFloat("_Value4", value);
			PDEAHJPOMEF().SetFloat("_Value", _Eyes);
			ADBKPGFMNKO().SetVector("[ItemsHandler] No connection to item server: ", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
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
		SCShader = Shader.Find("http");
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
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
