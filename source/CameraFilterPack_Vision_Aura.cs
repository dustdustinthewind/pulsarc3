// CameraFilterPack_Vision_Aura
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Vision/Aura")]
public class CameraFilterPack_Vision_Aura : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 2f)]
	public float Twist = 1f;

	[Range(-4f, 4f)]
	public float Speed = 1f;

	public Color Color = new Color(0.16f, 0.57f, 0.19f);

	[Range(-1f, 2f)]
	public float PosX = 0.5f;

	[Range(-1f, 2f)]
	public float PosY = 0.5f;

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

	[SpecialName]
	private Material IGKFMCPDNOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-119);
		}
		return BJFKDHHMLJH;
	}

	private void NNCCPEBIAKH()
	{
		SCShader = Shader.Find("#failed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 834f)
			{
				HBJJOCHGOPH = 635f;
			}
			EFDEIFCDAFG().SetFloat("?", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("Image", Twist);
			HNICHJCGJOC().SetColor(" {0}", Color);
			DOHGBNPMBKG().SetFloat("RarityImage", PosX);
			EFDEIFCDAFG().SetFloat("_Value4", PosY);
			JFDGLLEOPGB().SetFloat("offsets", Speed);
			EFDEIFCDAFG().SetVector("_FarCamera", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 84f, 1336f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	private void NEKCPLGFOFD()
	{
	}

	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 655f)
			{
				HBJJOCHGOPH = 917f;
			}
			EFDEIFCDAFG().SetFloat("mainMenu", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("Editor", Twist);
			NBPKMLMCHFN.SetColor("}", Color);
			IGKFMCPDNOI().SetFloat(": ", PosX);
			NBPKMLMCHFN.SetFloat("_TimeX", PosY);
			EFDEIFCDAFG().SetFloat("_Gamma", Speed);
			NBPKMLMCHFN.SetVector("settings_bindings_", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 693f, 1285f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PAKPHKPDKGE()
	{
		SCShader = Shader.Find("menu.tabid");
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-96);
		}
		return BJFKDHHMLJH;
	}

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1012f)
			{
				HBJJOCHGOPH = 1064f;
			}
			JFDGLLEOPGB().SetFloat("Copy from ", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("/", Twist);
			KEMAALEODNH().SetColor("Joystick1Button11", Color);
			FAIFBBGFAIB().SetFloat("ScrollPanel", PosX);
			IGKFMCPDNOI().SetFloat("Init", PosY);
			JFDGLLEOPGB().SetFloat("/music", Speed);
			KEMAALEODNH().SetVector("DPADHOR", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1926f, 968f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 758f)
			{
				HBJJOCHGOPH = 86f;
			}
			FAIFBBGFAIB().SetFloat("Show Title", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat(".lastCheckpoint.lives", Twist);
			HHIFMIPPMPF().SetColor("STICKLHOR", Color);
			HHIFMIPPMPF().SetFloat("steamid", PosX);
			EFDEIFCDAFG().SetFloat("CameraFilterPack/Pixel_Pixelisation", PosY);
			HHIFMIPPMPF().SetFloat("ConfigVersionSlider", Speed);
			DBOLLHHMKKN().SetVector("1332644700", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 507f, 19f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HNILMGEKDEC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KCCIEMBMOBA()
	{
		SCShader = Shader.Find("Joystick1Button4");
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
			BJFKDHHMLJH.hideFlags = (HideFlags)118;
		}
		return BJFKDHHMLJH;
	}

	private void HGDDCINLDAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 105f)
			{
				HBJJOCHGOPH = 4f;
			}
			HHIFMIPPMPF().SetFloat("_Value3", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat("CameraFilterPack/Blend2Camera_Lighten", Twist);
			HHIFMIPPMPF().SetColor("CameraFilterPack/FX_Hexagon_Black", Color);
			DBOLLHHMKKN().SetFloat("_TapMedium", PosX);
			DBOLLHHMKKN().SetFloat("CameraFilterPack/Glasses_On", PosY);
			JFDGLLEOPGB().SetFloat("_Value4", Speed);
			DBOLLHHMKKN().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 824f, 1884f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
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

	private void LCJHDLKJEOM()
	{
	}

	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1716f)
			{
				HBJJOCHGOPH = 463f;
			}
			DOHGBNPMBKG().SetFloat("score", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("Player", Twist);
			EFDEIFCDAFG().SetColor("Children", Color);
			FAIFBBGFAIB().SetFloat("win", PosX);
			HHIFMIPPMPF().SetFloat("_Value", PosY);
			JFDGLLEOPGB().SetFloat("sounds/hit_wrong", Speed);
			DOHGBNPMBKG().SetVector("SetParticlesCountPerBeat", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1633f, 1960f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void PHJLHCMCCKE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material JFDGLLEOPGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-70);
		}
		return BJFKDHHMLJH;
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
			NBPKMLMCHFN.SetFloat("_Value", Twist);
			NBPKMLMCHFN.SetColor("_Value2", Color);
			NBPKMLMCHFN.SetFloat("_Value3", PosX);
			NBPKMLMCHFN.SetFloat("_Value4", PosY);
			NBPKMLMCHFN.SetFloat("_Value5", Speed);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			if (HBJJOCHGOPH > 1841f)
			{
				HBJJOCHGOPH = 982f;
			}
			HNICHJCGJOC().SetFloat("/GetNews/pinnednewsid", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat("_Max", Twist);
			HHIFMIPPMPF().SetColor("settings.volume.sfx", Color);
			KEMAALEODNH().SetFloat("_TimeX", PosX);
			HHIFMIPPMPF().SetFloat("STICKLHOR", PosY);
			IGKFMCPDNOI().SetFloat("_Value3", Speed);
			EFDEIFCDAFG().SetVector("Tab2Content", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1360f, 1494f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material KEMAALEODNH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)117;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material FAIFBBGFAIB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void LLJLDLLNFBH()
	{
	}

	private void GAOOPEEBGJA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material DBOLLHHMKKN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-71);
		}
		return BJFKDHHMLJH;
	}

	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1776f)
			{
				HBJJOCHGOPH = 519f;
			}
			JFDGLLEOPGB().SetFloat("GameVolumeSlider", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("HightScoreMaxPointsText", Twist);
			JFDGLLEOPGB().SetColor("Hidden/Subpixel Morphological Anti-aliasing", Color);
			HNICHJCGJOC().SetFloat("settings.shaders", PosX);
			DBOLLHHMKKN().SetFloat(" scene: ", PosY);
			HHIFMIPPMPF().SetFloat("CameraFilterPack_AAA_Blood1", Speed);
			NBPKMLMCHFN.SetVector("_LowRez", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 216f, 501f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)108;
		}
		return BJFKDHHMLJH;
	}

	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1679f)
			{
				HBJJOCHGOPH = 1994f;
			}
			EFDEIFCDAFG().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("LevelConfigButton", Twist);
			DBOLLHHMKKN().SetColor("#score", Color);
			JFDGLLEOPGB().SetFloat("Updated!", PosX);
			HNICHJCGJOC().SetFloat("Custom Authentication failed (either due to user-input or configuration or AuthParameter string format). Calling: OnCustomAuthenticationFailed()", PosY);
			DOHGBNPMBKG().SetFloat("_BorderSize", Speed);
			IGKFMCPDNOI().SetVector(".r", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 611f, 1504f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FDPOFMCFBMF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BEBNOKFLJPH()
	{
		SCShader = Shader.Find(".");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Vision_Aura");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AGEJKLMJGDO()
	{
		SCShader = Shader.Find(" AuthMode ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BGDPIHMAACO()
	{
		SCShader = Shader.Find("settings.volume.game");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GPHPJIDGEPI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JHJFBCFBKLD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}
}
