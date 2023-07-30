// CameraFilterPack_Blend2Camera_ColorDodge
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/ColorDodge")]
public class CameraFilterPack_Blend2Camera_ColorDodge : MonoBehaviour
{
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_ColorDodge";

	public Shader SCShader;

	public Camera Camera2;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 1f)]
	public float SwitchCameraToCamera2;

	[Range(0f, 1f)]
	public float BlendFX = 0.5f;

	private RenderTexture JDMCFBKJHDD;

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

	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1169f)
			{
				HBJJOCHGOPH = 276f;
			}
			if (Camera2 != null)
			{
				HNICHJCGJOC().SetTexture("SetSunLerpSpeed", JDMCFBKJHDD);
			}
			JCPDCGIJKJD().SetFloat("CameraFilterPack/FX_Hexagon", HBJJOCHGOPH);
			ADBKPGFMNKO().SetFloat("MusicFileSelector", BlendFX);
			LPDOGGFOBDH().SetFloat("_ForegroundBlurExtrude", SwitchCameraToCamera2);
			KGOLDDBHIFN().SetVector("\r", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1076f, 324f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DPLLKHHLDBB()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 12);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material KEMJNOMIPHN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-85);
		}
		return BJFKDHHMLJH;
	}

	private void HGALNAGDJIM()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 93);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void OEAMLMGNFFC()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 117);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material HNICHJCGJOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-91);
		}
		return BJFKDHHMLJH;
	}

	private void LONLHFLPEJD()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -78);
			Camera2.targetTexture = JDMCFBKJHDD;
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
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture("_MainTex2", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat("_TimeX", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value", BlendFX);
			NBPKMLMCHFN.SetFloat("_Value2", SwitchCameraToCamera2);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CNFJDPMLECD()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -9);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void JOHOFNKJDEB()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -110);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IIKCMDMMJJI()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 36);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material JCPDCGIJKJD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void FIKNBPAIFBI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 377f)
			{
				HBJJOCHGOPH = 842f;
			}
			if (Camera2 != null)
			{
				ADBKPGFMNKO().SetTexture("The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.", JDMCFBKJHDD);
			}
			HNICHJCGJOC().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			ELBMIEOIABA().SetFloat("LoadingStatusText", BlendFX);
			JCPDCGIJKJD().SetFloat("skin.", SwitchCameraToCamera2);
			LPDOGGFOBDH().SetVector("  |  ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1266f, 462f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DGCGGKMNPLD()
	{
	}

	private void BBDONIDNGOE()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -3);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void GLGGNBOBFKE()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -18);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void MIAMLFNACAI()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -81);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material HJGEHJDMCGI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)125;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material ADBKPGFMNKO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void HPFOFGJPNCI()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 42);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material EFMCNLELMDO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)92;
		}
		return BJFKDHHMLJH;
	}

	private void ANKALNDLHEL()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -15);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 745f)
			{
				HBJJOCHGOPH = 1081f;
			}
			if (Camera2 != null)
			{
				LELKBCALFCF().SetTexture("_Value4", JDMCFBKJHDD);
			}
			KEMJNOMIPHN().SetFloat(":", HBJJOCHGOPH);
			ELBMIEOIABA().SetFloat("_Offsets", BlendFX);
			GJHPODJOBHL().SetFloat("_Value", SwitchCameraToCamera2);
			ADBKPGFMNKO().SetVector("_Color_R", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 980f, 1222f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LHGFCBDACBM()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 54);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void KDCLNBBODBO()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 20);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void FKDEEJFNNJC()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FABKIGNFECE()
	{
	}

	private void CCPEDDLAMIB()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CFFCLAHMBAA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 7);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FEHCNJLLJMP()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -20);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LBPHCAMMAPB()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
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
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void KFACDBHDAOD()
	{
	}

	private void CMIBEOJGAIL()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MKFLBEGJJDC()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IGPCNCJIEOJ()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -109);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MLEAHDDGEMJ()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 66);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void IBLGHLNNAHN()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -120);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OOGIHDLBBLM()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MDCFIHDPLIG()
	{
	}

	[SpecialName]
	private Material KHCLIAMBBNC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-72);
		}
		return BJFKDHHMLJH;
	}

	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 824f)
			{
				HBJJOCHGOPH = 1625f;
			}
			if (Camera2 != null)
			{
				EFMCNLELMDO().SetTexture("_TimeX", JDMCFBKJHDD);
			}
			ADBKPGFMNKO().SetFloat("#", HBJJOCHGOPH);
			LELKBCALFCF().SetFloat("VoteUpToggle", BlendFX);
			KGOLDDBHIFN().SetFloat("Inside cells:\n", SwitchCameraToCamera2);
			KHCLIAMBBNC().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 57f, 1148f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HPFBICIECGP()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -85);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void NBGIMIDICKE()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 40);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 754f)
			{
				HBJJOCHGOPH = 777f;
			}
			if (Camera2 != null)
			{
				ADBKPGFMNKO().SetTexture("CameraFilterPack/Oculus_ThermaVision", JDMCFBKJHDD);
			}
			KHCLIAMBBNC().SetFloat("value", HBJJOCHGOPH);
			LELKBCALFCF().SetFloat("Text", BlendFX);
			JFDGLLEOPGB().SetFloat("CameraFilterPack/Noise_TV", SwitchCameraToCamera2);
			KJMECMIGJJA().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1963f, 163f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CGDMLHLJIDK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -121);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AJENCHHLHKF()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 79);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material JFDGLLEOPGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)98;
		}
		return BJFKDHHMLJH;
	}

	private void DDBOODLPCAM()
	{
	}

	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1109f)
			{
				HBJJOCHGOPH = 489f;
			}
			if (Camera2 != null)
			{
				KEMJNOMIPHN().SetTexture("#scoresubmitionfailed: ", JDMCFBKJHDD);
			}
			LDNADDJMIPK().SetFloat("[LevelEditorScene] Error: I/O Failure! :(", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("nd", BlendFX);
			PDEAHJPOMEF().SetFloat("_Max", SwitchCameraToCamera2);
			LDNADDJMIPK().SetVector("G:", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 196f, 117f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFMCNLELMDO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DFFKKLAPHCC()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -57);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IEFMONDKKJN()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LOMDIOLNFHI()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ALJEJJCIMJN()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 32);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GPHPJIDGEPI()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LAGFLMMAGIO()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -120);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void NMNAEPIDENM()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 11);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1941f)
			{
				HBJJOCHGOPH = 1656f;
			}
			if (Camera2 != null)
			{
				ELBMIEOIABA().SetTexture("#scoresubmitionfailed: ", JDMCFBKJHDD);
			}
			KJMECMIGJJA().SetFloat("_TimeX", HBJJOCHGOPH);
			JCPDCGIJKJD().SetFloat("_Value5", BlendFX);
			LPDOGGFOBDH().SetFloat("Vertical", SwitchCameraToCamera2);
			JCPDCGIJKJD().SetVector("Tried to Initialize the SteamAPI twice in one session!", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 269f, 761f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JCPDCGIJKJD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1306f)
			{
				HBJJOCHGOPH = 1780f;
			}
			if (Camera2 != null)
			{
				LPDOGGFOBDH().SetTexture("caret", JDMCFBKJHDD);
			}
			PDEAHJPOMEF().SetFloat("CameraFilterPack/Colors_Adjust_FullColors", HBJJOCHGOPH);
			LPDOGGFOBDH().SetFloat("menu.copyright", BlendFX);
			KGOLDDBHIFN().SetFloat(" not exist", SwitchCameraToCamera2);
			HNICHJCGJOC().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 160f, 1005f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ELBMIEOIABA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HNMIAKKBMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 739f)
			{
				HBJJOCHGOPH = 630f;
			}
			if (Camera2 != null)
			{
				ELBMIEOIABA().SetTexture("_ScratchTex", JDMCFBKJHDD);
			}
			JFDGLLEOPGB().SetFloat(" joined", HBJJOCHGOPH);
			EFMCNLELMDO().SetFloat("IconImage", BlendFX);
			KGOLDDBHIFN().SetFloat(".", SwitchCameraToCamera2);
			GJHPODJOBHL().SetVector("_EmissionGain", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 259f, 797f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1414f)
			{
				HBJJOCHGOPH = 920f;
			}
			if (Camera2 != null)
			{
				LELKBCALFCF().SetTexture("PunRespawn", JDMCFBKJHDD);
			}
			LDNADDJMIPK().SetFloat("MultiplayerButton", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("{0:0.0} ms ({1:0.} fps)", BlendFX);
			KJMECMIGJJA().SetFloat(".sav", SwitchCameraToCamera2);
			EFMCNLELMDO().SetVector("<b>[", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 241f, 1489f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FJNCHGLIEMA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -90);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NNFMIAFHMJM()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -2);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LBAJLLFMMMP()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 119);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ENDDDMALLBK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 48);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void OMCLOFCJMPG()
	{
	}

	[SpecialName]
	private Material GJHPODJOBHL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-86);
		}
		return BJFKDHHMLJH;
	}

	private void HAHJJPLPOKB()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EPALOMHECJM()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 0);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void PHJLHCMCCKE()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HLDFOJMHKNL()
	{
	}

	[SpecialName]
	private Material ELBMIEOIABA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return BJFKDHHMLJH;
	}

	private void BLDMINMDHPA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 45);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void EBBOJPEPDCN()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 127);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void HAAFIECGECG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 897f)
			{
				HBJJOCHGOPH = 833f;
			}
			if (Camera2 != null)
			{
				LDNADDJMIPK().SetTexture("Join failed on GameServer. Changing back to MasterServer. Msg: ", JDMCFBKJHDD);
			}
			KEMJNOMIPHN().SetFloat("Maps Editor v.", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat("...", BlendFX);
			HJGEHJDMCGI().SetFloat("_Value2", SwitchCameraToCamera2);
			CFEDGDGBCHE().SetVector("PUNCloudBestRegion", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 501f, 1024f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ELJEHKEHFLM()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -32);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void BDCABNEJFCE()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 122);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material KJMECMIGJJA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-82);
		}
		return BJFKDHHMLJH;
	}

	private void GCDLIKEDMCF()
	{
	}

	private void NDDNJNCINDA()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EIDKCANPHJE()
	{
	}

	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 238f)
			{
				HBJJOCHGOPH = 28f;
			}
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture("{0:x2}", JDMCFBKJHDD);
			}
			KJMECMIGJJA().SetFloat("OpGetGameList not sent. LobbyType must be SqlLobby.", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("\" gets executed locally only, if at all.", BlendFX);
			KJMECMIGJJA().SetFloat("_FilteredReflections", SwitchCameraToCamera2);
			KAFBNOBOIAJ().SetVector("_Distortion", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1291f, 1902f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Start()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OEENOOGEEHD()
	{
	}

	private void JMEOGJHCONJ()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 104);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IFBPAGFGDGD()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 81);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material KGOLDDBHIFN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void HIPBNBKNICE()
	{
	}

	[SpecialName]
	private Material LPDOGGFOBDH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-126);
		}
		return BJFKDHHMLJH;
	}

	private void JDGFCEPDKAJ()
	{
	}

	private void KDMPELCOJCD()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 38);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material KAFBNOBOIAJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)74;
		}
		return BJFKDHHMLJH;
	}

	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 716f)
			{
				HBJJOCHGOPH = 1554f;
			}
			if (Camera2 != null)
			{
				HNICHJCGJOC().SetTexture("CameraFilterPack/FX_Spot", JDMCFBKJHDD);
			}
			ADBKPGFMNKO().SetFloat("MapEnd", HBJJOCHGOPH);
			KEMJNOMIPHN().SetFloat("Set satellite emission (glow)", BlendFX);
			JCPDCGIJKJD().SetFloat("DPADHOR", SwitchCameraToCamera2);
			KGOLDDBHIFN().SetVector("LevelNameInputField", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 498f, 1050f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
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
			if (HBJJOCHGOPH > 1083f)
			{
				HBJJOCHGOPH = 1371f;
			}
			if (Camera2 != null)
			{
				ADBKPGFMNKO().SetTexture(",", JDMCFBKJHDD);
			}
			KGOLDDBHIFN().SetFloat("EditMenu", HBJJOCHGOPH);
			GJHPODJOBHL().SetFloat("_TimeX", BlendFX);
			PDEAHJPOMEF().SetFloat("_ScreenResolution", SwitchCameraToCamera2);
			PDEAHJPOMEF().SetVector("Triangle", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1035f, 1110f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BFGIMALGMAJ()
	{
	}

	private void OnEnable()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void MGMLGCNLMKN()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 32);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 728f)
			{
				HBJJOCHGOPH = 1952f;
			}
			if (Camera2 != null)
			{
				KJMECMIGJJA().SetTexture("Pop", JDMCFBKJHDD);
			}
			ADBKPGFMNKO().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			LDNADDJMIPK().SetFloat("_Value3", BlendFX);
			HNICHJCGJOC().SetFloat("SpeedSlider", SwitchCameraToCamera2);
			PDEAHJPOMEF().SetVector("id", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 430f, 1133f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ELBMIEOIABA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KDJEJBBDILE()
	{
	}

	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 251f)
			{
				HBJJOCHGOPH = 822f;
			}
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture("MultiplayerButton", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Edge_Sobel", HBJJOCHGOPH);
			JCPDCGIJKJD().SetFloat("Alpha", BlendFX);
			NBPKMLMCHFN.SetFloat("Set Satellite Color", SwitchCameraToCamera2);
			LELKBCALFCF().SetVector("ns", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1742f, 1950f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void POIFMMFPELA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -2);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void PMOMPBFKOAM()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -117);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void HMKJFPBFOFI()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -123);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 596f)
			{
				HBJJOCHGOPH = 1199f;
			}
			if (Camera2 != null)
			{
				JFDGLLEOPGB().SetTexture("CameraFilterPack/Distortion_FishEye", JDMCFBKJHDD);
			}
			JFDGLLEOPGB().SetFloat("_FixDistance", HBJJOCHGOPH);
			LELKBCALFCF().SetFloat("B", BlendFX);
			LELKBCALFCF().SetFloat("Failed to 'network-remove' GameObject. Client is neither owner nor masterClient taking over for owner who left: ", SwitchCameraToCamera2);
			KAFBNOBOIAJ().SetVector("grid", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 262f, 1702f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EDCMIPNCPLB()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PMBOBIDNJCN()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -13);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void OnValidate()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void AAPKKMKDOFO()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -88);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void AEMGPJDJGBJ()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -126);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void COMNAPAAPDO()
	{
	}

	private void HONBLGFDMLL()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PMAADPNNHKK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -55);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void KLILJHJNICK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 72);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OnDisable()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AEIJFLJEABG()
	{
	}

	private void JKMLIADBEOB()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 1);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material LDNADDJMIPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-66);
		}
		return BJFKDHHMLJH;
	}

	private void BNLENEDAHHL()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MEMKLOMFFJO()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -56);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material CFEDGDGBCHE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void EPEGAEGDJAM()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 50);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LFAFJKJAEEL()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 69);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FAKGFMFAPDG()
	{
	}

	private void LGHCJCFHEMF()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -41);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DJAEEDICHGD()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 34);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void JHANGPCOCIG()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -103);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KKLMPKLKAEM()
	{
	}

	private void CEIAMKKNDHM()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -8);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void ECKEBMIMIGK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -110);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void PDILBLLIPFJ()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 69);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void IHAMJLJFFLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1056f)
			{
				HBJJOCHGOPH = 1281f;
			}
			if (Camera2 != null)
			{
				HJGEHJDMCGI().SetTexture(".lastCheckpoint.longestComboScore", JDMCFBKJHDD);
			}
			ELBMIEOIABA().SetFloat("LevelConfigButton", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat("_PrefilterOffs", BlendFX);
			KHCLIAMBBNC().SetFloat(").", SwitchCameraToCamera2);
			HJGEHJDMCGI().SetVector(" (", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 662f, 645f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHPODJOBHL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1310f)
			{
				HBJJOCHGOPH = 1138f;
			}
			if (Camera2 != null)
			{
				ADBKPGFMNKO().SetTexture(": ", JDMCFBKJHDD);
			}
			LELKBCALFCF().SetFloat("curScn", HBJJOCHGOPH);
			KHCLIAMBBNC().SetFloat("settings.enablerankingnotifications", BlendFX);
			JFDGLLEOPGB().SetFloat("_LutTex", SwitchCameraToCamera2);
			JFDGLLEOPGB().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 822f, 1025f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BNJEFIBPJLO()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 53);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void OIPJFDCNEDH()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -4);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void KIEJKBNBHMD()
	{
	}

	private void IBFHEDHJDLH()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -37);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void Update()
	{
	}

	private void IJCBBIJOCAH()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 40);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void JAAJECBCCFM()
	{
	}

	private void NNPBKKBFDHH()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HDMDKOKOOJC()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 57);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GAAPMFBPJNH()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -93);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}
}
