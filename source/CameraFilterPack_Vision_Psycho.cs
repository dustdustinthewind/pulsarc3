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
			EOCCJGIGEGJ().SetFloat("_Value3", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("_TimeX", HoleSize);
			OIMMPLPBLBK().SetFloat("_TimeX", HoleSmooth);
			OIMMPLPBLBK().SetFloat("There is already a virtual axis named ", Color1);
			LONNIJMNKFB().SetFloat("https://steamcommunity.com/sharedfiles/filedetails/?id=", Color2);
			LONNIJMNKFB().SetVector("#ok", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1282f, 1122f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
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
			KDMBOKLMADJ().SetFloat("CameraFilterPack_TV_Noise3", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("CameraFilterPack/Pixel_Pixelisation", HoleSize);
			GJHLADDCMFF().SetFloat("#FFFFFFFF", HoleSmooth);
			OGMEGHKECAH().SetFloat("hardcoreinfo", Color1);
			GKILCDHJFEG().SetFloat("_PositionY", Color2);
			KOHGPKOFEJO().SetVector(" ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1179f, 1111f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
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
			NBPKMLMCHFN.SetFloat("_ChromaticAberration", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("CameraFilterPack_AAA_Blood2", HoleSize);
			HNICHJCGJOC().SetFloat("_Value2", HoleSmooth);
			HEHKGPKLAKK().SetFloat("[PlayerBase] ShowTitle error: ", Color1);
			KEMJNOMIPHN().SetFloat("Ev Destroy Failed. Could not find PhotonView with instantiationId ", Color2);
			OGMEGHKECAH().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 672f, 677f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
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
		SCShader = Shader.Find("Start");
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
			GKILCDHJFEG().SetFloat(">", HBJJOCHGOPH);
			ADGHJOHKEHG().SetFloat("UseScanLine", HoleSize);
			HEHKGPKLAKK().SetFloat("CurrentTimeLabel", HoleSmooth);
			LONNIJMNKFB().SetFloat("Error: You're not logged into Steam!", Color1);
			HHIFMIPPMPF().SetFloat(";", Color2);
			OGMEGHKECAH().SetVector("traffic", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 92f, 953f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOHGBNPMBKG());
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
			HNICHJCGJOC().SetFloat("Object ID. Case-Sensitive", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat(",", HoleSize);
			HNICHJCGJOC().SetFloat("_FarCamera", HoleSmooth);
			EJDPNJAEAKJ().SetFloat("[LevelEditorScene] Error: Timeout :S", Color1);
			KOHGPKOFEJO().SetFloat("_NoiseAmount", Color2);
			KEMJNOMIPHN().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 863f, 247f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HDMDKOKOOJC()
	{
		SCShader = Shader.Find("CameraFilterPack/TV_Vcr");
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
			EJDPNJAEAKJ().SetFloat("Sending vacant view IDs. Length: ", HBJJOCHGOPH);
			KDMBOKLMADJ().SetFloat("_TimeX", HoleSize);
			ADGHJOHKEHG().SetFloat("restrictions\n\n#until: ", HoleSmooth);
			GKILCDHJFEG().SetFloat("CameraFilterPack/Blend2Camera_VividLight", Color1);
			KBOPGONOCNP().SetFloat(" not exist", Color2);
			DKNJGHFLAIF().SetVector("SetSpeed", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1448f, 961f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
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
			HEHKGPKLAKK().SetFloat("settings_bindings_controller_type", HBJJOCHGOPH);
			DOHGBNPMBKG().SetFloat("_BorderSize", HoleSize);
			KBOPGONOCNP().SetFloat(" to: ", HoleSmooth);
			HFBJAOFLCJI().SetFloat("IconImage", Color1);
			OIMMPLPBLBK().SetFloat("_MainTex2", Color2);
			GKILCDHJFEG().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1446f, 1306f));
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
			GJHLADDCMFF().SetFloat("Joystick1Button7", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("Tab1Content", HoleSize);
			HNICHJCGJOC().SetFloat("_MainTex2", HoleSmooth);
			KBOPGONOCNP().SetFloat("couldn't be found!", Color1);
			KBOPGONOCNP().SetFloat("settings.enablehitsoundsinrelax", Color2);
			HFBJAOFLCJI().SetVector("Items/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1384f, 536f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
		SCShader = Shader.Find("_Value2");
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
			KEMJNOMIPHN().SetFloat("_ExposureAdjustment", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("_SmoothEnd", HoleSize);
			GJHLADDCMFF().SetFloat("[", HoleSmooth);
			EOCCJGIGEGJ().SetFloat("Set Satellite Input", Color1);
			OGMEGHKECAH().SetFloat(". Not Destroying GameObject or PhotonViews!", Color2);
			NBPKMLMCHFN.SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1444f, 1513f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
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
			ABHDNGIHBKE().SetFloat("4,28,true,0", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("maps.", HoleSize);
			DEFBJOCJJKF().SetFloat(" - ", HoleSmooth);
			DEFBJOCJJKF().SetFloat("#yes", Color1);
			KDMBOKLMADJ().SetFloat("-", Color2);
			KOHGPKOFEJO().SetVector("itemdefid[0]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1248f, 628f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
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
		SCShader = Shader.Find("Aug");
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
		SCShader = Shader.Find("TypedLobbyInfo '{0}'[{1}] rooms: {2} players: {3}");
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
			NBPKMLMCHFN.SetFloat("Set camera background color", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("source", HoleSize);
			KDMBOKLMADJ().SetFloat("misses", HoleSmooth);
			HHIFMIPPMPF().SetFloat("CameraFilterPack/Blend2Camera_DarkerColor", Color1);
			OGMEGHKECAH().SetFloat("CameraFilterPack/Vision_Blood_Fast", Color2);
			GKILCDHJFEG().SetVector("_Value5", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 715f, 41f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
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
			KOHGPKOFEJO().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			KEMJNOMIPHN().SetFloat("0 - sun, 1 - satellite, 2 - particles emitter", HoleSize);
			HFBJAOFLCJI().SetFloat("Added event", HoleSmooth);
			HNICHJCGJOC().SetFloat("_SunPosition", Color1);
			DOHGBNPMBKG().SetFloat("achievements.21.progress", Color2);
			LONNIJMNKFB().SetVector("[LocalizationService] All keys for ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 9f, 1472f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KOHGPKOFEJO());
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
			KEMAALEODNH().SetFloat("SetEnvSpriteImage", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("GenerationMenu", HoleSize);
			GKILCDHJFEG().SetFloat("Case-Sensitive", HoleSmooth);
			KEMAALEODNH().SetFloat("value", Color1);
			OGMEGHKECAH().SetFloat("The given 2D texture ", Color2);
			GKILCDHJFEG().SetVector("PlaySound", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1928f, 1047f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHLADDCMFF());
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
			KEMAALEODNH().SetFloat("settings_bindings_controller_type", HBJJOCHGOPH);
			ADGHJOHKEHG().SetFloat("GetLive", HoleSize);
			ADGHJOHKEHG().SetFloat("GhostPosY", HoleSmooth);
			KBOPGONOCNP().SetFloat("RB", Color1);
			HEHKGPKLAKK().SetFloat("Triangle", Color2);
			ADGHJOHKEHG().SetVector(".lastCheckpoint.correctScore", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1557f, 1601f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
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
			OGMEGHKECAH().SetFloat("offsets", HBJJOCHGOPH);
			KDMBOKLMADJ().SetFloat("CameraFilterPack/Drawing_Paper3", HoleSize);
			KEMAALEODNH().SetFloat("/", HoleSmooth);
			HNICHJCGJOC().SetFloat("_Value", Color1);
			GJHLADDCMFF().SetFloat("<color=#{0}>{1}</color>", Color2);
			KEMAALEODNH().SetVector("[MapsData] Bad map: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 497f, 323f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHLADDCMFF());
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
			DOHGBNPMBKG().SetFloat("TotalHitsScoreText", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("achievements.21.progress", HoleSize);
			ADGHJOHKEHG().SetFloat("_Green_B", HoleSmooth);
			KDMBOKLMADJ().SetFloat("ConfigVersionSlider", Color1);
			NBPKMLMCHFN.SetFloat("SetSatelliteRadius", Color2);
			NBPKMLMCHFN.SetVector("SaveButton", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 523f, 127f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
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
			DKNJGHFLAIF().SetFloat("ResourceFileSelector", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("scn", HoleSize);
			KEMJNOMIPHN().SetFloat("[PlayerController] ", HoleSmooth);
			EOCCJGIGEGJ().SetFloat("LevelFolderInputField", Color1);
			OGMEGHKECAH().SetFloat("maps.", Color2);
			ABHDNGIHBKE().SetVector("menutheme.melancholicose", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 466f, 1909f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KDMBOKLMADJ());
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
			KAFBNOBOIAJ().SetFloat("#loopnumber ", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("Parent ID", HoleSize);
			HFBJAOFLCJI().SetFloat("[DiscordController] Error {0}: {1}", HoleSmooth);
			KEMAALEODNH().SetFloat("_TimeX", Color1);
			KAFBNOBOIAJ().SetFloat("Set camera (or player) distance. Base player distance - 14", Color2);
			KDMBOKLMADJ().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1061f, 1982f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
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
			KEMJNOMIPHN().SetFloat("_Vignette_Alpha", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat(" should be overwritten.", HoleSize);
			KDMBOKLMADJ().SetFloat("Received RPC \"", HoleSmooth);
			ABHDNGIHBKE().SetFloat("[MapEditor] Importing map: ", Color1);
			EOCCJGIGEGJ().SetFloat("1", Color2);
			KDMBOKLMADJ().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1269f, 194f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
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
		SCShader = Shader.Find("PublishButton");
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
			OIMMPLPBLBK().SetFloat(",", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("_Saturation", HoleSize);
			KOHGPKOFEJO().SetFloat("SetSatelliteEmission", HoleSmooth);
			DOHGBNPMBKG().SetFloat("_Value3", Color1);
			LONNIJMNKFB().SetFloat("SetSpeed", Color2);
			KBOPGONOCNP().SetVector("SetParticlesParticleSpeed", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1260f, 67f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
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
			HEHKGPKLAKK().SetFloat("_TimeX", HBJJOCHGOPH);
			ADGHJOHKEHG().SetFloat("_Vignetting2", HoleSize);
			HNICHJCGJOC().SetFloat("[MapEditor] Exported to ", HoleSmooth);
			KOHGPKOFEJO().SetFloat("Prints list of commands", Color1);
			ADGHJOHKEHG().SetFloat("_Value2", Color2);
			DKNJGHFLAIF().SetVector("settings.fps", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1134f, 1887f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
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
			KEMJNOMIPHN().SetFloat(" is set to dontSave = true, continuing loop.", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("SetSatelliteRotationSpeed", HoleSize);
			KEMAALEODNH().SetFloat("StartTime already set: ", HoleSmooth);
			KAFBNOBOIAJ().SetFloat("ShadersToggle", Color1);
			KBOPGONOCNP().SetFloat("mapselector.filter.subscribedonly", Color2);
			OGMEGHKECAH().SetVector("0,7,true,0", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 320f, 939f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
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
			OGMEGHKECAH().SetFloat("Bad parameters for setbool! Use <key> <value>", HBJJOCHGOPH);
			KEMJNOMIPHN().SetFloat("Floating point textures aren't supported on this device ({0})", HoleSize);
			ADGHJOHKEHG().SetFloat("Fill Area", HoleSmooth);
			DOHGBNPMBKG().SetFloat("Please attach component to a Graphical UI component", Color1);
			OIMMPLPBLBK().SetFloat("/theme", Color2);
			LONNIJMNKFB().SetVector("_MainTex2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 162f, 1927f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
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
		SCShader = Shader.Find("_Value");
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
			KAFBNOBOIAJ().SetFloat("/../", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("RB", HoleSize);
			GJHLADDCMFF().SetFloat(" with prefix ", HoleSmooth);
			EOCCJGIGEGJ().SetFloat("0.00", Color1);
			GKILCDHJFEG().SetFloat("settings.volume.editor", Color2);
			EOCCJGIGEGJ().SetVector("player.xp", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1769f, 355f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
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
			EOCCJGIGEGJ().SetFloat("GameScene", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("OK", HoleSize);
			GJHLADDCMFF().SetFloat("set environment id", HoleSmooth);
			OGMEGHKECAH().SetFloat("_TimeX", Color1);
			EOCCJGIGEGJ().SetFloat("settings.fps", Color2);
			KEMJNOMIPHN().SetVector("Received RPC \"", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1200f, 1870f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
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
			EOCCJGIGEGJ().SetFloat("_ThirdTex", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("_Value2", HoleSize);
			KEMAALEODNH().SetFloat("PossibleMapPointsText", HoleSmooth);
			KBOPGONOCNP().SetFloat("#obtained", Color1);
			NBPKMLMCHFN.SetFloat("LoadMapCanvas", Color2);
			ADGHJOHKEHG().SetVector("_MainTex2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 4f, 1088f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KDMBOKLMADJ());
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
			ADGHJOHKEHG().SetFloat("health", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("id", HoleSize);
			OIMMPLPBLBK().SetFloat(": ", HoleSmooth);
			HHIFMIPPMPF().SetFloat("_NoiseAmount", Color1);
			OIMMPLPBLBK().SetFloat("2", Color2);
			DKNJGHFLAIF().SetVector("Reading preview file failed!: \"{0}\"", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1511f, 1842f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KDMBOKLMADJ());
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
			KDMBOKLMADJ().SetFloat("#creatingnewitem", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("MapperNameText", HoleSize);
			HEHKGPKLAKK().SetFloat("local CheckCondition = function()", HoleSmooth);
			KBOPGONOCNP().SetFloat("null", Color1);
			ADGHJOHKEHG().SetFloat("y", Color2);
			GKILCDHJFEG().SetVector(": ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 512f, 638f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
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
		SCShader = Shader.Find("[MapEditor] Importing map: ");
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
			ABHDNGIHBKE().SetFloat("_TimeX", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("VisionBlur", HoleSize);
			ABHDNGIHBKE().SetFloat(").png", HoleSmooth);
			EJDPNJAEAKJ().SetFloat("CameraFilterPack/Gradients_Ansi", Color1);
			KOHGPKOFEJO().SetFloat("Hidden/Image Effects/Cinematic/AmbientOcclusion", Color2);
			KOHGPKOFEJO().SetVector("LivesSlider", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1901f, 1704f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
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
			GJHLADDCMFF().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("workshop.", HoleSize);
			HEHKGPKLAKK().SetFloat("_copy", HoleSmooth);
			HHIFMIPPMPF().SetFloat("). ", Color1);
			HNICHJCGJOC().SetFloat("_Value", Color2);
			OGMEGHKECAH().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1455f, 32f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
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
			KAFBNOBOIAJ().SetFloat("_VelocityScale", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat(".ogg", HoleSize);
			GJHLADDCMFF().SetFloat("SetSatelliteLerpSpeed", HoleSmooth);
			ADGHJOHKEHG().SetFloat("There are a few rules that you must accept before submitting your work. Please select \"RULES\" button, if you haven't read them yet.", Color1);
			DKNJGHFLAIF().SetFloat("offsets", Color2);
			ADGHJOHKEHG().SetVector("CameraFilterPack/FX_Hypno", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1816f, 1059f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MMOKKAPFGAK()
	{
		SCShader = Shader.Find("\" for viewID ");
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
		SCShader = Shader.Find("_ScreenResolution");
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
		SCShader = Shader.Find("Working commands:\nreset <challengeid>\nresetall");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}
}
