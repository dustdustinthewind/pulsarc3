// CameraFilterPack_Blur_BlurHole
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Blur/Blur Hole")]
[ExecuteInEditMode]
public class CameraFilterPack_Blur_BlurHole : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	[Range(1f, 16f)]
	public float Size = 10f;

	[Range(0f, 1f)]
	public float _Radius = 0.25f;

	[Range(0f, 4f)]
	public float _SpotSize = 1f;

	[Range(0f, 1f)]
	public float _CenterX = 0.5f;

	[Range(0f, 1f)]
	public float _CenterY = 0.5f;

	[Range(0f, 1f)]
	public float _AlphaBlur = 1f;

	[Range(0f, 1f)]
	public float _AlphaBlurInside;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

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

	private void LEAHIBJDMBI()
	{
	}

	[SpecialName]
	private Material LONNIJMNKFB()
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 548f)
			{
				HBJJOCHGOPH = 541f;
			}
			EJDPNJAEAKJ().SetFloat("{0:0} minute{1}, ", HBJJOCHGOPH);
			ADBKPGFMNKO().SetFloat("The given 2D texture ", Size);
			NBPKMLMCHFN.SetFloat("_TimeX", _Radius);
			LONNIJMNKFB().SetFloat("_CenterY", _SpotSize);
			JIBOKBCPDLC().SetFloat("Could not find RPC with index: ", _CenterX);
			DEFBJOCJJKF().SetFloat("Editor/", _CenterY);
			LONNIJMNKFB().SetFloat("[Down-Left]", _AlphaBlur);
			FOOCJIDNGBB().SetFloat("OpenButton", _AlphaBlurInside);
			HEINDEMCGIK().SetVector("SaveButton", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1160f)
			{
				HBJJOCHGOPH = 1448f;
			}
			HNFFHCLNBDN().SetFloat("X", HBJJOCHGOPH);
			NJDIODJNGGA().SetFloat("0 seconds", Size);
			EFDEIFCDAFG().SetFloat(".png", _Radius);
			MLMKCOINOOH().SetFloat("PossibleMapPointsText", _SpotSize);
			OIIDAKBILMI().SetFloat("_Offsets", _CenterX);
			HCGJCMDJPGD().SetFloat("config.txt", _CenterY);
			CIAFLBFJLEJ().SetFloat("s", _AlphaBlur);
			NJDIODJNGGA().SetFloat("_TimeX", _AlphaBlurInside);
			FOOCJIDNGBB().SetVector("_VignettingColor", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CIAFLBFJLEJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BOLBPPHJBMI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FEKECCBFGMI()
	{
		SCShader = Shader.Find("pointBuffer");
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
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material EJDPNJAEAKJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void LJIHHJOAJCN()
	{
	}

	[SpecialName]
	private Material ADBKPGFMNKO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-126);
		}
		return BJFKDHHMLJH;
	}

	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1537f)
			{
				HBJJOCHGOPH = 1749f;
			}
			OGMEGHKECAH().SetFloat("Missing shader for image effect {0}", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception", Size);
			EFDEIFCDAFG().SetFloat("#", _Radius);
			AELJLBOJAIL().SetFloat("hitsounds:", _SpotSize);
			AELJLBOJAIL().SetFloat("_TimeX", _CenterX);
			EJDPNJAEAKJ().SetFloat("RecordButton", _CenterY);
			LENEJAGLCNL().SetFloat("gold", _AlphaBlur);
			EFDEIFCDAFG().SetFloat("_TimeX", _AlphaBlurInside);
			NBPKMLMCHFN.SetVector("[", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIIDAKBILMI());
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material DEFBJOCJJKF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void NNCCPEBIAKH()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ICILLMAKLMI()
	{
		SCShader = Shader.Find("table");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BGFJOEPFOPM()
	{
	}

	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1693f)
			{
				HBJJOCHGOPH = 21f;
			}
			OIIDAKBILMI().SetFloat("_Value3", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("_TimeX", Size);
			LENEJAGLCNL().SetFloat("/../", _Radius);
			AELJLBOJAIL().SetFloat("In Main Menu", _SpotSize);
			HEINDEMCGIK().SetFloat("Ev Destroy Failed. Could not find PhotonView with instantiationId ", _CenterX);
			ADBKPGFMNKO().SetFloat("_Value", _CenterY);
			OIIDAKBILMI().SetFloat("CameraFilterPack/Atmosphere_Fog", _AlphaBlur);
			HHIFMIPPMPF().SetFloat(",", _AlphaBlurInside);
			CIAFLBFJLEJ().SetVector("HighScaleShot", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GCHBGCGBMCK()
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

	private void MFMIODIAKNI()
	{
	}

	private void CCPEDDLAMIB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material OIIDAKBILMI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)81;
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

	private void OBAEDJJDCPN()
	{
	}

	private void DLIJFEGIEKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 317f)
			{
				HBJJOCHGOPH = 191f;
			}
			OGMEGHKECAH().SetFloat("_Value2", HBJJOCHGOPH);
			LENEJAGLCNL().SetFloat("_LowRez", Size);
			NBPKMLMCHFN.SetFloat("_MainTex2", _Radius);
			EJDPNJAEAKJ().SetFloat("Joystick1Button6", _SpotSize);
			OIIDAKBILMI().SetFloat("1248864821", _CenterX);
			OGMEGHKECAH().SetFloat("_Visualize", _CenterY);
			OIIDAKBILMI().SetFloat("_copy", _AlphaBlur);
			LONNIJMNKFB().SetFloat("_TimeX", _AlphaBlurInside);
			ADBKPGFMNKO().SetVector("_Value3", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
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

	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1294f)
			{
				HBJJOCHGOPH = 834f;
			}
			DEFBJOCJJKF().SetFloat("D-Pad Down", HBJJOCHGOPH);
			FKEOGPDLBDD().SetFloat("_Alpha", Size);
			NJDIODJNGGA().SetFloat("Edited unlock conditions", _Radius);
			DEFBJOCJJKF().SetFloat("_EmissionColor", _SpotSize);
			EFDEIFCDAFG().SetFloat("RULES", _CenterX);
			HCGJCMDJPGD().SetFloat("visible", _CenterY);
			HEINDEMCGIK().SetFloat("_CurrentMipLevel", _AlphaBlur);
			LENEJAGLCNL().SetFloat("_Distortion", _AlphaBlurInside);
			DEFBJOCJJKF().SetVector("_TimeX", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FNCDAPDOBBI()
	{
		SCShader = Shader.Find("PlayerPrefs::Deserialize() parameterContent has ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LCJHDLKJEOM()
	{
	}

	private void DDFCIOMKEEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1650f)
			{
				HBJJOCHGOPH = 506f;
			}
			DEFBJOCJJKF().SetFloat(".icon", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("_Extra", Size);
			OGMEGHKECAH().SetFloat("_Intensity", _Radius);
			DEFBJOCJJKF().SetFloat("open", _SpotSize);
			NJDIODJNGGA().SetFloat("_MainTex", _CenterX);
			NBPKMLMCHFN.SetFloat("_Value", _CenterY);
			EFDEIFCDAFG().SetFloat("resource", _AlphaBlur);
			AELJLBOJAIL().SetFloat("_MainTex2", _AlphaBlurInside);
			EJDPNJAEAKJ().SetVector("_TimeX", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CIAFLBFJLEJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material JIBOKBCPDLC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void COOHIILCOCO()
	{
		SCShader = Shader.Find("PPI: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1226f)
			{
				HBJJOCHGOPH = 1588f;
			}
			ADBKPGFMNKO().SetFloat("Joystick1Button3", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("icon.png", Size);
			AELJLBOJAIL().SetFloat("Reconnect() failed. Can only connect while in state 'Disconnected'. Current state: ", _Radius);
			HEINDEMCGIK().SetFloat("Edited event", _SpotSize);
			MLMKCOINOOH().SetFloat("_BaseTex", _CenterX);
			HNFFHCLNBDN().SetFloat("_ScreenResolution", _CenterY);
			NJDIODJNGGA().SetFloat("Set Sun Emission", _AlphaBlur);
			EJDPNJAEAKJ().SetFloat("float,1", _AlphaBlurInside);
			FKEOGPDLBDD().SetVector("[DiscordController] Disconnect {0}: {1}", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AEDDNDHCLNN()
	{
		SCShader = Shader.Find("ShowSprite");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FMNPFCHBLJF()
	{
		SCShader = Shader.Find("DPADHOR");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KFACDBHDAOD()
	{
	}

	[SpecialName]
	private Material FOOCJIDNGBB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return BJFKDHHMLJH;
	}

	private void JONGNKNLLND()
	{
		SCShader = Shader.Find("_Screen");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NFEDLAOPHML()
	{
	}

	private void LBAJLLFMMMP()
	{
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HMPGIFBJFIK()
	{
		SCShader = Shader.Find(".");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material EFDEIFCDAFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material MLMKCOINOOH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void MGMAOBPPOBJ()
	{
		SCShader = Shader.Find("TStart");
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

	private void GPHPJIDGEPI()
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
			if (HBJJOCHGOPH > 195f)
			{
				HBJJOCHGOPH = 185f;
			}
			HNFFHCLNBDN().SetFloat("finished", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("_TimeX", Size);
			HEINDEMCGIK().SetFloat("runas", _Radius);
			HHIFMIPPMPF().SetFloat("_TimeX", _SpotSize);
			CIAFLBFJLEJ().SetFloat("offsets", _CenterX);
			EFDEIFCDAFG().SetFloat("_CenterX", _CenterY);
			ADBKPGFMNKO().SetFloat("-1", _AlphaBlur);
			AELJLBOJAIL().SetFloat("PS Home", _AlphaBlurInside);
			OIIDAKBILMI().SetVector("Set Player Distance", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
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
			if (HBJJOCHGOPH > 234f)
			{
				HBJJOCHGOPH = 1446f;
			}
			EJDPNJAEAKJ().SetFloat(".progress", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("Uploader", Size);
			HCGJCMDJPGD().SetFloat("_Saturation", _Radius);
			AELJLBOJAIL().SetFloat("menu.enableselectormusic", _SpotSize);
			OIIDAKBILMI().SetFloat("menu.selectedplaymode", _CenterX);
			OIIDAKBILMI().SetFloat("_Green_R", _CenterY);
			DEFBJOCJJKF().SetFloat("float,0", _AlphaBlur);
			AELJLBOJAIL().SetFloat("float,0", _AlphaBlurInside);
			ADBKPGFMNKO().SetVector("_ScreenResolution", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MAOCOEGAFND()
	{
	}

	private void FIKFJDFELIP()
	{
		SCShader = Shader.Find(" ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1200f)
			{
				HBJJOCHGOPH = 1368f;
			}
			NJDIODJNGGA().SetFloat("Tab1Content", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("_ScreenResolution", Size);
			AELJLBOJAIL().SetFloat("_TimeX", _Radius);
			HHIFMIPPMPF().SetFloat("CameraFilterPack/Drawing_BluePrint", _SpotSize);
			HHIFMIPPMPF().SetFloat("offsets", _CenterX);
			HHIFMIPPMPF().SetFloat("_TimeX", _CenterY);
			NJDIODJNGGA().SetFloat("_ColorBuffer", _AlphaBlur);
			DEFBJOCJJKF().SetFloat("SaveButton", _AlphaBlurInside);
			HNFFHCLNBDN().SetVector("setfloat", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1259f)
			{
				HBJJOCHGOPH = 1879f;
			}
			FOOCJIDNGBB().SetFloat("SetSunInput", HBJJOCHGOPH);
			HEINDEMCGIK().SetFloat("\"\"", Size);
			NBPKMLMCHFN.SetFloat(" evLeave: ", _Radius);
			FKEOGPDLBDD().SetFloat("InfoText", _SpotSize);
			ADBKPGFMNKO().SetFloat("_Value3", _CenterX);
			DEFBJOCJJKF().SetFloat("Noise shaders are not set up! Disabling noise effect.", _CenterY);
			LENEJAGLCNL().SetFloat("Mouse Y", _AlphaBlur);
			ADBKPGFMNKO().SetFloat("_Distortion", _AlphaBlurInside);
			LENEJAGLCNL().SetVector("_RampTex", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BKGJOECFMID()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NPLCENPNJBM()
	{
		SCShader = Shader.Find("offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HOMNAHDDNHJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IFIHBNJKEKD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LCHBFNIPBHB()
	{
	}

	[SpecialName]
	private Material HEINDEMCGIK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-107);
		}
		return BJFKDHHMLJH;
	}

	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 900f)
			{
				HBJJOCHGOPH = 432f;
			}
			ADBKPGFMNKO().SetFloat("DPADHOR", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("SetTrailZoomSpeed", Size);
			FKEOGPDLBDD().SetFloat("_SecondTex", _Radius);
			EFDEIFCDAFG().SetFloat("_BlurParams", _SpotSize);
			FKEOGPDLBDD().SetFloat("_Value2", _CenterX);
			OGMEGHKECAH().SetFloat("_ScreenResolution", _CenterY);
			HEINDEMCGIK().SetFloat("JoinButton", _AlphaBlur);
			FOOCJIDNGBB().SetFloat("SUCCESS! Item submitted! :D :D :D", _AlphaBlurInside);
			FKEOGPDLBDD().SetVector("_TimeX", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 982f)
			{
				HBJJOCHGOPH = 257f;
			}
			EJDPNJAEAKJ().SetFloat("OnPressRight", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("_ScreenResolution", Size);
			EJDPNJAEAKJ().SetFloat("Players NetIDs:", _Radius);
			HHIFMIPPMPF().SetFloat("UI Extensions/UIScreen", _SpotSize);
			EFDEIFCDAFG().SetFloat("float,2", _CenterX);
			OIIDAKBILMI().SetFloat("_Value2", _CenterY);
			NBPKMLMCHFN.SetFloat("Right", _AlphaBlur);
			NBPKMLMCHFN.SetFloat("VIGNETTE_FILMIC", _AlphaBlurInside);
			FKEOGPDLBDD().SetVector("[PlayerBase] Loaded custom model: ", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 833f)
			{
				HBJJOCHGOPH = 1780f;
			}
			LENEJAGLCNL().SetFloat("Using PhotonServerSettings.Protocol when leaving the NameServer (AuthMode is AuthOnceWss): ", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat(". Verify the Prefab is in a Resources folder (and not in a subfolder)", Size);
			FKEOGPDLBDD().SetFloat("2;13;14;15;16", _Radius);
			HCGJCMDJPGD().SetFloat("[Up-Right-Left]", _SpotSize);
			ADBKPGFMNKO().SetFloat("System.String", _CenterX);
			HEINDEMCGIK().SetFloat("workshop.", _CenterY);
			HCGJCMDJPGD().SetFloat("_Value3", _AlphaBlur);
			EJDPNJAEAKJ().SetFloat("CameraFilterPack_AAA_Blood_Hit1", _AlphaBlurInside);
			JIBOKBCPDLC().SetVector("history", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 306f)
			{
				HBJJOCHGOPH = 1880f;
			}
			AELJLBOJAIL().SetFloat("_Value", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("_Value2", Size);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Colors_DarkColor", _Radius);
			FKEOGPDLBDD().SetFloat("menu.playedpage", _SpotSize);
			CIAFLBFJLEJ().SetFloat("_Value2", _CenterX);
			OIIDAKBILMI().SetFloat("<b>", _CenterY);
			OIIDAKBILMI().SetFloat("_Value2", _AlphaBlur);
			EFDEIFCDAFG().SetFloat("Fade", _AlphaBlurInside);
			HEINDEMCGIK().SetVector("ticket", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 563f)
			{
				HBJJOCHGOPH = 1884f;
			}
			HNFFHCLNBDN().SetFloat("_Value", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("GameScene", Size);
			LONNIJMNKFB().SetFloat("player.quantum", _Radius);
			MLMKCOINOOH().SetFloat("_TimeX", _SpotSize);
			HCGJCMDJPGD().SetFloat("MaxLivesSlider", _CenterX);
			HHIFMIPPMPF().SetFloat("_Amount", _CenterY);
			HNFFHCLNBDN().SetFloat("_Speed", _AlphaBlur);
			FKEOGPDLBDD().SetFloat("_DotSize", _AlphaBlurInside);
			CIAFLBFJLEJ().SetVector("Joystick1Button9", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KCDOMIJBFLL()
	{
	}

	private void POJFHDFJOPE()
	{
	}

	private void MJNPIDGNJMK()
	{
	}

	private void LBPCODPOJAH()
	{
	}

	private void LIEGJOHINGC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OKLAJINHPAN()
	{
		SCShader = Shader.Find("0.00");
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
			NBPKMLMCHFN.SetFloat("_Distortion", Size);
			NBPKMLMCHFN.SetFloat("_Radius", _Radius);
			NBPKMLMCHFN.SetFloat("_SpotSize", _SpotSize);
			NBPKMLMCHFN.SetFloat("_CenterX", _CenterX);
			NBPKMLMCHFN.SetFloat("_CenterY", _CenterY);
			NBPKMLMCHFN.SetFloat("_Alpha", _AlphaBlur);
			NBPKMLMCHFN.SetFloat("_Alpha2", _AlphaBlurInside);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1715f)
			{
				HBJJOCHGOPH = 1936f;
			}
			HNFFHCLNBDN().SetFloat("[LobbyPlayerElement] Created lpe for ", HBJJOCHGOPH);
			EJDPNJAEAKJ().SetFloat("player.xp", Size);
			OIIDAKBILMI().SetFloat("_Value2", _Radius);
			CIAFLBFJLEJ().SetFloat(" ", _SpotSize);
			OIIDAKBILMI().SetFloat("Fill Area", _CenterX);
			MLMKCOINOOH().SetFloat("menu.tabid", _CenterY);
			NJDIODJNGGA().SetFloat("StartButton", _AlphaBlur);
			EJDPNJAEAKJ().SetFloat("(master)", _AlphaBlurInside);
			NBPKMLMCHFN.SetVector("/", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PKBENONAOOL()
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

	private void NAALCEPIHCH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FABKIGNFECE()
	{
	}

	[SpecialName]
	private Material CIAFLBFJLEJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void MGFFNGEGFDC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EHCGBJDFMHG()
	{
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/BlurHole");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 943f)
			{
				HBJJOCHGOPH = 182f;
			}
			NJDIODJNGGA().SetFloat("ChallengesButton", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("FrostCanvas", Size);
			FOOCJIDNGBB().SetFloat("Updated!", _Radius);
			LENEJAGLCNL().SetFloat("</color>", _SpotSize);
			CIAFLBFJLEJ().SetFloat("_HdrParams", _CenterX);
			ADBKPGFMNKO().SetFloat("SetEnvSpriteImage", _CenterY);
			CIAFLBFJLEJ().SetFloat("Image", _AlphaBlur);
			EFDEIFCDAFG().SetFloat("It seems some instantiation is not completed, as instantiation data is used. You should make sure instantiations are paused when calling this method. Cleaning now, despite this.", _AlphaBlurInside);
			JIBOKBCPDLC().SetVector("CameraFilterPack_Paper1", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HLDFOJMHKNL()
	{
	}

	private void IKMELABKBHO()
	{
	}

	private void DOOIKOEBBJB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 868f)
			{
				HBJJOCHGOPH = 227f;
			}
			ADBKPGFMNKO().SetFloat("_Value8", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("_Value2", Size);
			FOOCJIDNGBB().SetFloat("menu.enableselectormusic", _Radius);
			NBPKMLMCHFN.SetFloat("Mask texture not readable, set your sprite to Texture Type 'Advanced' and check 'Read/Write Enabled'", _SpotSize);
			FKEOGPDLBDD().SetFloat("_MainTex2", _CenterX);
			LONNIJMNKFB().SetFloat("_LutTex", _CenterY);
			FKEOGPDLBDD().SetFloat("_Value3", _AlphaBlur);
			HCGJCMDJPGD().SetFloat("_ScreenResolution", _AlphaBlurInside);
			MLMKCOINOOH().SetVector("editor.", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KCNIHHNMFFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1517f)
			{
				HBJJOCHGOPH = 792f;
			}
			NBPKMLMCHFN.SetFloat("appid", HBJJOCHGOPH);
			HEINDEMCGIK().SetFloat("_TimeX", Size);
			CIAFLBFJLEJ().SetFloat("_ExtraColor", _Radius);
			HEINDEMCGIK().SetFloat("_Intensity", _SpotSize);
			EFDEIFCDAFG().SetFloat("_SmoothEnd", _CenterX);
			LONNIJMNKFB().SetFloat("maps.", _CenterY);
			FOOCJIDNGBB().SetFloat("Maps Editor v.", _AlphaBlur);
			OGMEGHKECAH().SetFloat("CameraFilterPack/TV_Tiles", _AlphaBlurInside);
			DEFBJOCJJKF().SetVector("Fade", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1357f)
			{
				HBJJOCHGOPH = 1029f;
			}
			CIAFLBFJLEJ().SetFloat("Left Click", HBJJOCHGOPH);
			LENEJAGLCNL().SetFloat("GUICamera", Size);
			HEINDEMCGIK().SetFloat("workshop.", _Radius);
			OGMEGHKECAH().SetFloat("_Near", _SpotSize);
			OIIDAKBILMI().SetFloat("_Distortion", _CenterX);
			DEFBJOCJJKF().SetFloat("CameraFilterPack/FX_Drunk", _CenterY);
			NBPKMLMCHFN.SetFloat("Ok", _AlphaBlur);
			JIBOKBCPDLC().SetFloat("mapselector.filter.favoriteonly", _AlphaBlurInside);
			ADBKPGFMNKO().SetVector("LocalPlayer is null or not in mActors! LocalPlayer: {0} mActors==null: {1} newID: {2}", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CCLNNLCOPBL()
	{
		SCShader = Shader.Find("[Steamworks.NET] Could not load [lib]steam_api.dll/so/dylib. It's likely not in the correct location. Refer to the README for more details.\n");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EPEGAEGDJAM()
	{
		SCShader = Shader.Find("FavoriteButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LCDJFJIBADI()
	{
	}

	[SpecialName]
	private Material AELJLBOJAIL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void FDMAEPOHDMK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HHIFMIPPMPF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void JHPOIOELNCG()
	{
	}

	private void NEKCPLGFOFD()
	{
	}

	[SpecialName]
	private Material LENEJAGLCNL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.None;
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

	private void KDMANOEMOCA()
	{
		SCShader = Shader.Find("CameraFilterPack/TV_Videoflip");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HMNLHMLILKD()
	{
	}

	private void NNPBKKBFDHH()
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-128);
		}
		return BJFKDHHMLJH;
	}

	private void HIPEHGNBJMN()
	{
		SCShader = Shader.Find("BadgeImage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 93f)
			{
				HBJJOCHGOPH = 1677f;
			}
			HNFFHCLNBDN().SetFloat("Hidden/Image Effects/Cinematic/Bloom", HBJJOCHGOPH);
			LENEJAGLCNL().SetFloat(".lastCheckpoint.time", Size);
			CIAFLBFJLEJ().SetFloat("_TimeX", _Radius);
			DEFBJOCJJKF().SetFloat("_TimeX", _SpotSize);
			FOOCJIDNGBB().SetFloat(" (now: ", _CenterX);
			OIIDAKBILMI().SetFloat("_Value4", _CenterY);
			HEINDEMCGIK().SetFloat("_Value2", _AlphaBlur);
			NJDIODJNGGA().SetFloat("_Value", _AlphaBlurInside);
			HHIFMIPPMPF().SetVector("settings.selectormapsperpage", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JKFDDNMPOJH()
	{
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1073f)
			{
				HBJJOCHGOPH = 1065f;
			}
			LENEJAGLCNL().SetFloat("_Value2", HBJJOCHGOPH);
			MLMKCOINOOH().SetFloat("s", Size);
			FOOCJIDNGBB().SetFloat("&", _Radius);
			CIAFLBFJLEJ().SetFloat("_Value4", _SpotSize);
			JIBOKBCPDLC().SetFloat("workshop.", _CenterX);
			OGMEGHKECAH().SetFloat("...", _CenterY);
			AELJLBOJAIL().SetFloat("_Near", _AlphaBlur);
			FOOCJIDNGBB().SetFloat("_Offsets", _AlphaBlurInside);
			HCGJCMDJPGD().SetVector("/icon", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JOJFHFHOCHO()
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
	private Material NJDIODJNGGA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return BJFKDHHMLJH;
	}

	private void JIAAFKOPEKO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1299f)
			{
				HBJJOCHGOPH = 228f;
			}
			HNFFHCLNBDN().SetFloat("saveGameName ", HBJJOCHGOPH);
			FKEOGPDLBDD().SetFloat("yyyy-MM-dd HH:mm:ss", Size);
			LONNIJMNKFB().SetFloat("player.linea", _Radius);
			MLMKCOINOOH().SetFloat("Unknown player asked for PickupItems", _SpotSize);
			EJDPNJAEAKJ().SetFloat("NEW_ACHIEVEMENT_1_26", _CenterX);
			FOOCJIDNGBB().SetFloat("[ItemsHandler] Found ", _CenterY);
			LENEJAGLCNL().SetFloat("Item ", _AlphaBlur);
			EJDPNJAEAKJ().SetFloat("Oct", _AlphaBlurInside);
			HEINDEMCGIK().SetVector("Editor/", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
