// CameraFilterPack_Vision_Psycho
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Vision/Psycho")]
public class CameraFilterPack_Vision_Psycho : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0.01f, 1f)]
	public float HoleSize = 0.6f;

	[Range(-1f, 1f)]
	public float HoleSmooth = 0.3f;

	[Range(-2f, 2f)]
	public float Color1 = 0.2f;

	[Range(-2f, 2f)]
	public float Color2 = 0.9f;

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

	private void FOLDLDLFFLM()
	{
	}

	private void OFPPIKHNJOD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 539f)
			{
				HBJJOCHGOPH = 856f;
			}
			OIMMPLPBLBK().SetFloat("_Value4", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("_Value", HoleSize);
			GKILCDHJFEG().SetFloat("_Parasite", HoleSmooth);
			GKILCDHJFEG().SetFloat("There is already a virtual button named ", Color1);
			KOHGPKOFEJO().SetFloat("Error: I/O Failure! :(", Color2);
			OIMMPLPBLBK().SetVector("KickThePlayer", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1282f, 1122f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
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
			if (HBJJOCHGOPH > 523f)
			{
				HBJJOCHGOPH = 1512f;
			}
			EOCCJGIGEGJ().SetFloat("_TimeX", HBJJOCHGOPH);
			EJDPNJAEAKJ().SetFloat("_Val", HoleSize);
			EJDPNJAEAKJ().SetFloat("#FFFFFFFF", HoleSmooth);
			EOCCJGIGEGJ().SetFloat("OK", Color1);
			KEMAALEODNH().SetFloat("_Distortion", Color2);
			DKNJGHFLAIF().SetVector(":", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1179f, 1111f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			BJFKDHHMLJH.hideFlags = (HideFlags)97;
		}
		return BJFKDHHMLJH;
	}

	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 515f)
			{
				HBJJOCHGOPH = 17f;
			}
			DEFBJOCJJKF().SetFloat("_BlurDistance", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("CameraFilterPack_AAA_Blood2", HoleSize);
			OGMEGHKECAH().SetFloat("_Value3", HoleSmooth);
			NBPKMLMCHFN.SetFloat("finished", Color1);
			EJDPNJAEAKJ().SetFloat("Warning: Unhandled Event ErrorInfo (251). Set PhotonNetwork.OnEventCall to the method PUN should call for this event.", Color2);
			HFBJAOFLCJI().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 672f, 677f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
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

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FEKECCBFGMI()
	{
		SCShader = Shader.Find("Joystick1Button10");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 219f)
			{
				HBJJOCHGOPH = 1619f;
			}
			KEMAALEODNH().SetFloat("#", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_MainTex2", HoleSize);
			EJDPNJAEAKJ().SetFloat("CurrentTimeLabel", HoleSmooth);
			ADGHJOHKEHG().SetFloat("Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(", Color1);
			KEMAALEODNH().SetFloat("|", Color2);
			NBPKMLMCHFN.SetVector("Out {0,4} | In {1,4} | Sum {2,4}", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 92f, 953f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 721f)
			{
				HBJJOCHGOPH = 1693f;
			}
			KEMAALEODNH().SetFloat("value", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat(",", HoleSize);
			KEMAALEODNH().SetFloat("_FarCamera", HoleSmooth);
			HHIFMIPPMPF().SetFloat("[LevelEditorScene] Error: Timeout :S", Color1);
			EOCCJGIGEGJ().SetFloat("_MainTex", Color2);
			DKNJGHFLAIF().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 863f, 247f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HDMDKOKOOJC()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1726f)
			{
				HBJJOCHGOPH = 57f;
			}
			LONNIJMNKFB().SetFloat("Could not find RPC with index: ", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value", HoleSize);
			KEMJNOMIPHN().SetFloat("-1", HoleSmooth);
			HEHKGPKLAKK().SetFloat("CameraFilterPack/Blend2Camera_LinearLight", Color1);
			EOCCJGIGEGJ().SetFloat("[PlayerController] ", Color2);
			KEMAALEODNH().SetVector("0x", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1448f, 961f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KOJKBFDNGDK()
	{
		SCShader = Shader.Find("(\\[ *\\/ *url *])");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BJOHDLNDFAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EAHCLIEEJOG()
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
			if (HBJJOCHGOPH > 1841f)
			{
				HBJJOCHGOPH = 668f;
			}
			NBPKMLMCHFN.SetFloat("settings_bindings_", HBJJOCHGOPH);
			KDMBOKLMADJ().SetFloat("_BorderSize", HoleSize);
			KEMAALEODNH().SetFloat("Had to lookup view that wasn't in photonViewList: ", HoleSmooth);
			HNICHJCGJOC().SetFloat("IconImage", Color1);
			EJDPNJAEAKJ().SetFloat("_TimeX", Color2);
			HEHKGPKLAKK().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1446f, 1306f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Vision_Psycho");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MMBPLGGLPDB()
	{
	}

	private void FKEJGBFDCAH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IABLKKAALGI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1009f)
			{
				HBJJOCHGOPH = 236f;
			}
			HFBJAOFLCJI().SetFloat("Joystick1Button8", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("caret", HoleSize);
			GKILCDHJFEG().SetFloat("_TimeX", HoleSmooth);
			KOHGPKOFEJO().SetFloat("DontDestroy", Color1);
			KBOPGONOCNP().SetFloat("settings.disablestoryboard", Color2);
			KDMBOKLMADJ().SetVector("Items/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1384f, 536f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HMNLHMLILKD()
	{
	}

	private void NDAJBJFJGCF()
	{
	}

	private void DNNFHBOOPIN()
	{
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FOMNCPKKCFN()
	{
	}

	[SpecialName]
	private Material KDMBOKLMADJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-71);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KOHGPKOFEJO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-85);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KAFBNOBOIAJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-78);
		}
		return BJFKDHHMLJH;
	}

	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1069f)
			{
				HBJJOCHGOPH = 223f;
			}
			LONNIJMNKFB().SetFloat("_HdrParams", HBJJOCHGOPH);
			EJDPNJAEAKJ().SetFloat("CameraFilterPack/Drawing_Halftone", HoleSize);
			NBPKMLMCHFN.SetFloat("ticket", HoleSmooth);
			HFBJAOFLCJI().SetFloat("Set Satellite Input", Color1);
			KOHGPKOFEJO().SetFloat("RequestOwnership(): ", Color2);
			HEHKGPKLAKK().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1444f, 1513f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1629f)
			{
				HBJJOCHGOPH = 1983f;
			}
			HEHKGPKLAKK().SetFloat("Set camera (or player) distance. Base player distance - 14", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("maps.", HoleSize);
			KBOPGONOCNP().SetFloat("My New Mod Pack", HoleSmooth);
			HHIFMIPPMPF().SetFloat("MenuScene", Color1);
			GJHLADDCMFF().SetFloat("-", Color2);
			KOHGPKOFEJO().SetVector("{0:0.0} ms ({1:0.} fps)", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1248f, 628f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void NFEDLAOPHML()
	{
	}

	[SpecialName]
	private Material GKILCDHJFEG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void EKCKJLFFAID()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OKLAJINHPAN()
	{
		SCShader = Shader.Find("Oct");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IHLMNAGPKDA()
	{
		SCShader = Shader.Find("Player Connected");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FLKEJJEGCFA()
	{
		SCShader = Shader.Find("{0}{1}{2}={3}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void APKNAPHOFHC()
	{
	}

	[SpecialName]
	private Material HNICHJCGJOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-125);
		}
		return BJFKDHHMLJH;
	}

	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 133f)
			{
				HBJJOCHGOPH = 100f;
			}
			HHIFMIPPMPF().SetFloat("SetPlayerDistance", HBJJOCHGOPH);
			ADGHJOHKEHG().SetFloat("source", HoleSize);
			KOHGPKOFEJO().SetFloat("replayData", HoleSmooth);
			OIMMPLPBLBK().SetFloat("CameraFilterPack/Blend2Camera_DarkerColor", Color1);
			KAFBNOBOIAJ().SetFloat("_TimeX", Color2);
			HHIFMIPPMPF().SetVector("_Value6", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 715f, 41f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void COOHIILCOCO()
	{
		SCShader = Shader.Find("SetTrailZoomSpeed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1441f)
			{
				HBJJOCHGOPH = 1255f;
			}
			ABHDNGIHBKE().SetFloat("CameraFilterPack/TV_WideScreenHorizontal", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("0,2,true,0", HoleSize);
			HNICHJCGJOC().SetFloat("Edited hands count", HoleSmooth);
			EJDPNJAEAKJ().SetFloat("_BlurRadius4", Color1);
			GJHLADDCMFF().SetFloat("Achievement 21 progress reseted", Color2);
			KAFBNOBOIAJ().SetVector(": ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 9f, 1472f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1121f)
			{
				HBJJOCHGOPH = 1692f;
			}
			DOHGBNPMBKG().SetFloat("Set EnvSprite Image", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("GenerationMenu", HoleSize);
			KEMJNOMIPHN().SetFloat("Case-Sensitive", HoleSmooth);
			EJDPNJAEAKJ().SetFloat("value", Color1);
			EJDPNJAEAKJ().SetFloat(" cannot be used as a 3D LUT.", Color2);
			HFBJAOFLCJI().SetVector("end", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1928f, 1047f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 493f)
			{
				HBJJOCHGOPH = 381f;
			}
			HFBJAOFLCJI().SetFloat("settings_bindings_controller_type", HBJJOCHGOPH);
			KDMBOKLMADJ().SetFloat("Down", HoleSize);
			KDMBOKLMADJ().SetFloat("GhostPosY", HoleSmooth);
			KOHGPKOFEJO().SetFloat("LT", Color1);
			EJDPNJAEAKJ().SetFloat("L1", Color2);
			DOHGBNPMBKG().SetVector(".lastCheckpoint.checkpointsUsed", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1557f, 1601f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 633f)
			{
				HBJJOCHGOPH = 727f;
			}
			KEMAALEODNH().SetFloat("offsets", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("_TimeX", HoleSize);
			HHIFMIPPMPF().SetFloat("/", HoleSmooth);
			KBOPGONOCNP().SetFloat("_Value2", Color1);
			OGMEGHKECAH().SetFloat("X2", Color2);
			KBOPGONOCNP().SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 497f, 323f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material ADGHJOHKEHG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material OGMEGHKECAH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-80);
		}
		return BJFKDHHMLJH;
	}

	private void Update()
	{
	}

	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 511f)
			{
				HBJJOCHGOPH = 929f;
			}
			HHIFMIPPMPF().SetFloat("TotalHitsScoreText", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("achievements.21.progress", HoleSize);
			ADGHJOHKEHG().SetFloat("_Green_B", HoleSmooth);
			HHIFMIPPMPF().SetFloat("Tab2Content", Color1);
			ABHDNGIHBKE().SetFloat("Set Satellite Radius", Color2);
			HEHKGPKLAKK().SetVector("SaveButton", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 523f, 127f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KOHGPKOFEJO());
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

	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1137f)
			{
				HBJJOCHGOPH = 1813f;
			}
			EOCCJGIGEGJ().SetFloat("BitsData", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("Connecting", HoleSize);
			KEMAALEODNH().SetFloat(": ", HoleSmooth);
			EJDPNJAEAKJ().SetFloat("LevelFolderInputField", Color1);
			OIMMPLPBLBK().SetFloat("maps.", Color2);
			GJHLADDCMFF().SetVector("menutheme.melancholicose", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 466f, 1909f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material GJHLADDCMFF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 953f)
			{
				HBJJOCHGOPH = 605f;
			}
			HHIFMIPPMPF().SetFloat("#loopnumber ", HBJJOCHGOPH);
			EJDPNJAEAKJ().SetFloat("Parent ID", HoleSize);
			ABHDNGIHBKE().SetFloat("[DiscordController] Join ({0})", HoleSmooth);
			ADGHJOHKEHG().SetFloat("_CenterX", Color1);
			OGMEGHKECAH().SetFloat("Set camera (or player) distance. Base player distance - 14", Color2);
			NBPKMLMCHFN.SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1061f, 1982f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PLBOFEPBPKC()
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
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void CBIBDOIBJAI()
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
			if (HBJJOCHGOPH > 579f)
			{
				HBJJOCHGOPH = 1409f;
			}
			DOHGBNPMBKG().SetFloat("_Noise", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat(" has been disabled as it's not supported on the current platform.", HoleSize);
			NBPKMLMCHFN.SetFloat(" but this PhotonView does not exist! View was/is ours.", HoleSmooth);
			KDMBOKLMADJ().SetFloat("Editor/", Color1);
			HEHKGPKLAKK().SetFloat("PopulateMapsList", Color2);
			LONNIJMNKFB().SetVector("_Alpha", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1269f, 194f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HIFLPHLGLFG()
	{
	}

	private void FHGKIOOMMOH()
	{
		SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-125);
		}
		return BJFKDHHMLJH;
	}

	private void COGBDFKOHKK()
	{
	}

	[SpecialName]
	private Material HFBJAOFLCJI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 92f)
			{
				HBJJOCHGOPH = 1589f;
			}
			KBOPGONOCNP().SetFloat("Submit", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("_Saturation", HoleSize);
			ABHDNGIHBKE().SetFloat("SetSatelliteLerpSpeed", HoleSmooth);
			HNICHJCGJOC().SetFloat("_Value4", Color1);
			KBOPGONOCNP().SetFloat("#ok", Color2);
			EOCCJGIGEGJ().SetVector("SetEnvSpriteImage", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1260f, 67f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1471f)
			{
				HBJJOCHGOPH = 1382f;
			}
			DKNJGHFLAIF().SetFloat("_TimeX", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("_VignettingColor", HoleSize);
			DKNJGHFLAIF().SetFloat("Editor/", HoleSmooth);
			HEHKGPKLAKK().SetFloat("Clears all text from the debug console", Color1);
			HHIFMIPPMPF().SetFloat("_Value2", Color2);
			KOHGPKOFEJO().SetVector("settings.fps", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1134f, 1887f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MKFLBEGJJDC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material KEMJNOMIPHN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void PLEOOAJIMEE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1962f)
			{
				HBJJOCHGOPH = 1349f;
			}
			HEHKGPKLAKK().SetFloat("QuickSave", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat("id", HoleSize);
			EOCCJGIGEGJ().SetFloat("st", HoleSmooth);
			OGMEGHKECAH().SetFloat("Scene", Color1);
			NBPKMLMCHFN.SetFloat("mapselector.filter.subscribedonly", Color2);
			KEMJNOMIPHN().SetVector("Set satellite audio input", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 320f, 939f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NNBCLMJGFEN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LINKAMEPKGM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DGCGGKMNPLD()
	{
	}

	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 89f)
			{
				HBJJOCHGOPH = 1570f;
			}
			KOHGPKOFEJO().SetFloat("getfloat", HBJJOCHGOPH);
			ADGHJOHKEHG().SetFloat("Attempting to remove texture that was not allocated: {0}", HoleSize);
			HHIFMIPPMPF().SetFloat("Fill", HoleSmooth);
			ADGHJOHKEHG().SetFloat("_YCrop", Color1);
			HHIFMIPPMPF().SetFloat("AudioSampler", Color2);
			HEHKGPKLAKK().SetVector("CameraFilterPack/TV_Artefact", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 162f, 1927f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material OIMMPLPBLBK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-95);
		}
		return BJFKDHHMLJH;
	}

	private void PMPKMGKAAJH()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material KEMAALEODNH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material EOCCJGIGEGJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material DEFBJOCJJKF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-107);
		}
		return BJFKDHHMLJH;
	}

	private void BNEJMABFKJE()
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
			if (HBJJOCHGOPH > 148f)
			{
				HBJJOCHGOPH = 571f;
			}
			HHIFMIPPMPF().SetFloat("OxOD.lastPath", HBJJOCHGOPH);
			KDMBOKLMADJ().SetFloat("Joystick1Button6", HoleSize);
			KBOPGONOCNP().SetFloat(" [", HoleSmooth);
			KAFBNOBOIAJ().SetFloat("<b>Max Score</b>:", Color1);
			GKILCDHJFEG().SetFloat("settings.volume.game", Color2);
			LONNIJMNKFB().SetVector("player.xp", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1769f, 355f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LIEGJOHINGC()
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
			if (HBJJOCHGOPH > 1313f)
			{
				HBJJOCHGOPH = 715f;
			}
			KOHGPKOFEJO().SetFloat("[SERVER] Kicked ", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("https://steamcommunity.com/sharedfiles/filedetails/?id=", HoleSize);
			OIMMPLPBLBK().SetFloat("Case-Sensitive", HoleSmooth);
			DOHGBNPMBKG().SetFloat("_TimeX", Color1);
			GKILCDHJFEG().SetFloat("-showlogs", Color2);
			EOCCJGIGEGJ().SetVector(" but this PhotonView does not exist! View was/is ours.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1200f, 1870f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PBEPCAPAKLG()
	{
	}

	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1833f)
			{
				HBJJOCHGOPH = 1904f;
			}
			HEHKGPKLAKK().SetFloat("_EdgeThresholdMin", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("_Value3", HoleSize);
			ADGHJOHKEHG().SetFloat("PointsScoreText", HoleSmooth);
			LONNIJMNKFB().SetFloat("challenges/", Color1);
			ABHDNGIHBKE().SetFloat("Editor", Color2);
			HEHKGPKLAKK().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 4f, 1088f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 203f)
			{
				HBJJOCHGOPH = 270f;
			}
			DOHGBNPMBKG().SetFloat("{0}sec average:", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("Object ID. Case-Sensitive", HoleSize);
			ABHDNGIHBKE().SetFloat(" not exist", HoleSmooth);
			KAFBNOBOIAJ().SetFloat("_NoiseTex", Color1);
			EOCCJGIGEGJ().SetFloat("/", Color2);
			HNICHJCGJOC().SetVector(" - ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1511f, 1842f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IDIIELPAMCJ()
	{
	}

	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 959f)
			{
				HBJJOCHGOPH = 1290f;
			}
			GKILCDHJFEG().SetFloat("maps.", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("UpdateDownloadingProgress", HoleSize);
			EJDPNJAEAKJ().SetFloat("skin.", HoleSmooth);
			DOHGBNPMBKG().SetFloat(", ", Color1);
			ADGHJOHKEHG().SetFloat("x", Color2);
			GJHLADDCMFF().SetVector(" not exist", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 512f, 638f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
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
			NBPKMLMCHFN.SetFloat("_Value", HoleSize);
			NBPKMLMCHFN.SetFloat("_Value2", HoleSmooth);
			NBPKMLMCHFN.SetFloat("_Value3", Color1);
			NBPKMLMCHFN.SetFloat("_Value4", Color2);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CNGAJDBOCLJ()
	{
		SCShader = Shader.Find("CameraFilterPack/3D_Mirror");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material DKNJGHFLAIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)84;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material LONNIJMNKFB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void LPMINJJPDCH()
	{
	}

	[SpecialName]
	private Material ABHDNGIHBKE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-85);
		}
		return BJFKDHHMLJH;
	}

	private void MDNHCLKNCLE()
	{
		SCShader = Shader.Find("Editor/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GKNKIIEALCH()
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-111);
		}
		return BJFKDHHMLJH;
	}

	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1599f)
			{
				HBJJOCHGOPH = 1077f;
			}
			KBOPGONOCNP().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("GlassDistortion", HoleSize);
			DOHGBNPMBKG().SetFloat("HighScaleShot", HoleSmooth);
			ADGHJOHKEHG().SetFloat("_TimeX", Color1);
			DEFBJOCJJKF().SetFloat("_OcclusionTexture", Color2);
			ABHDNGIHBKE().SetVector("SpeedSlider", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1901f, 1704f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
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
			if (HBJJOCHGOPH > 1524f)
			{
				HBJJOCHGOPH = 558f;
			}
			LONNIJMNKFB().SetFloat("_TimeX", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("workshop.", HoleSize);
			DKNJGHFLAIF().SetFloat("StartCanvas", HoleSmooth);
			GKILCDHJFEG().SetFloat("SupportLogger OnCreatedRoom(", Color1);
			ADGHJOHKEHG().SetFloat("_Value2", Color2);
			DOHGBNPMBKG().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1455f, 32f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ABIOAMNCEOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 878f)
			{
				HBJJOCHGOPH = 1253f;
			}
			ADGHJOHKEHG().SetFloat("_Jitter", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("/", HoleSize);
			KOHGPKOFEJO().SetFloat("SetSatelliteTrailMinVertexDistance", HoleSmooth);
			GKILCDHJFEG().SetFloat("RULES", Color1);
			GKILCDHJFEG().SetFloat("_MainTexBlurred", Color2);
			GJHLADDCMFF().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1816f, 1059f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MMOKKAPFGAK()
	{
		SCShader = Shader.Find(" Owner called.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JOJFHFHOCHO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NEKCPLGFOFD()
	{
	}

	private void JKBMKPDGCHG()
	{
		SCShader = Shader.Find("CameraFilterPack/Edge_Sobel");
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

	private void CIPKEPDELJB()
	{
		SCShader = Shader.Find("Bad parameters for reset! Use \"reset <challengeid>\"");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}
}
