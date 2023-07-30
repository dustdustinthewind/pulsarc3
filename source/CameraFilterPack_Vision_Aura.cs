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
		SCShader = Shader.Find("\"");
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
			IGKFMCPDNOI().SetFloat("-1", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("GroupNameText", Twist);
			KEMAALEODNH().SetColor("Please specify either t or f.", Color);
			JFDGLLEOPGB().SetFloat("RarityImage", PosX);
			HHIFMIPPMPF().SetFloat("_Value3", PosY);
			HNICHJCGJOC().SetFloat("_threshold", Speed);
			EFDEIFCDAFG().SetVector("_FarCamera", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 84f, 1336f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			IGKFMCPDNOI().SetFloat("mainMenu", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("#alreadyexist", Twist);
			KEMAALEODNH().SetColor(",", Color);
			HNICHJCGJOC().SetFloat("[PlayerController] ", PosX);
			EFDEIFCDAFG().SetFloat("CameraFilterPack/FX_Hexagon", PosY);
			DOHGBNPMBKG().SetFloat("_WhiteBalance", Speed);
			HNICHJCGJOC().SetVector("settings_bindings_controller_type", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 693f, 1285f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
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
			KEMAALEODNH().SetFloat(".", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat(".wav", Twist);
			IGKFMCPDNOI().SetColor("Left Stick Click", Color);
			KEMAALEODNH().SetFloat("InputField", PosX);
			HHIFMIPPMPF().SetFloat("maps.", PosY);
			KEMAALEODNH().SetFloat("/music", Speed);
			KEMAALEODNH().SetVector("DPADHOR", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1926f, 968f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
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
			HHIFMIPPMPF().SetFloat("Show Title", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat(".", Twist);
			HHIFMIPPMPF().SetColor("Mouse Y", Color);
			NBPKMLMCHFN.SetFloat(".message", PosX);
			FAIFBBGFAIB().SetFloat("_MainTex2", PosY);
			DOHGBNPMBKG().SetFloat("maps.", Speed);
			EFDEIFCDAFG().SetVector("880078120", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 507f, 19f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
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
		SCShader = Shader.Find("Joystick1Button3");
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
			FAIFBBGFAIB().SetFloat("_Value2", HBJJOCHGOPH);
			DOHGBNPMBKG().SetFloat("CameraFilterPack/Blend2Camera_DarkerColor", Twist);
			DBOLLHHMKKN().SetColor("_ScreenResolution", Color);
			IGKFMCPDNOI().SetFloat("_Threshhold", PosX);
			DOHGBNPMBKG().SetFloat("CameraFilterPack/Glasses_On", PosY);
			EFDEIFCDAFG().SetFloat("_Value3", Speed);
			NBPKMLMCHFN.SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 824f, 1884f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
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
			FAIFBBGFAIB().SetFloat("owner: ", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat("UpdateNewsTileStart", Twist);
			DOHGBNPMBKG().SetColor("Blues", Color);
			KEMAALEODNH().SetFloat("finished", PosX);
			IGKFMCPDNOI().SetFloat("_TimeX", PosY);
			DOHGBNPMBKG().SetFloat("skin.no_hit", Speed);
			FAIFBBGFAIB().SetVector("SetParticlesEmission", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1633f, 1960f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB());
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
			FAIFBBGFAIB().SetFloat("/GetNews/pinnednewsid", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat("_HardBlend", Twist);
			NBPKMLMCHFN.SetColor("ItemNameText", Color);
			KEMAALEODNH().SetFloat("_TimeX", PosX);
			EFDEIFCDAFG().SetFloat("Mouse X", PosY);
			NBPKMLMCHFN.SetFloat("_Value2", Speed);
			HHIFMIPPMPF().SetVector("Tab2Content", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1360f, 1494f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
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
			NBPKMLMCHFN.SetFloat("GameVolumeSlider", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("EndlessLoopsScoreText", Twist);
			FAIFBBGFAIB().SetColor("_QualitySettings", Color);
			IGKFMCPDNOI().SetFloat("settings.shaders", PosX);
			KEMAALEODNH().SetFloat("Registered PhotonView: ", PosY);
			NBPKMLMCHFN.SetFloat("CameraFilterPack_AAA_Blood1", Speed);
			NBPKMLMCHFN.SetVector("_Offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 216f, 501f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
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
			DBOLLHHMKKN().SetFloat("_Value", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat("LevelConfigButton", Twist);
			JFDGLLEOPGB().SetColor("ScoreText", Color);
			FAIFBBGFAIB().SetFloat("[LevelEditorScene] Updated", PosX);
			IGKFMCPDNOI().SetFloat("If you host Photon yourself, make sure to start the 'Instance LoadBalancing' ", PosY);
			FAIFBBGFAIB().SetFloat("_BorderSize", Speed);
			JFDGLLEOPGB().SetVector(".a", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 611f, 1504f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
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
		SCShader = Shader.Find("Crosshair1");
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
		SCShader = Shader.Find("Connected to masterserver.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BGDPIHMAACO()
	{
		SCShader = Shader.Find("settings.volume.menu");
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
