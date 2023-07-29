// CameraFilterPack_Alien_Vision
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Alien/Vision")]
public class CameraFilterPack_Alien_Vision : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 0.5f)]
	public float Therma_Variation = 0.5f;

	[Range(0f, 1f)]
	public float Speed = 0.5f;

	[Range(0f, 4f)]
	private float ALELLLFCDBF;

	[Range(0f, 16f)]
	private float NFDIFLHGJKB = 1f;

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

	private void NJHJHBOJKIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Alien_Vision");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FEHCNJLLJMP()
	{
		SCShader = Shader.Find("inventory.selected.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FHPFJBFCOOF()
	{
		SCShader = Shader.Find("X");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LMBDNPLDGIJ()
	{
	}

	[SpecialName]
	private Material DEFBJOCJJKF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-83);
		}
		return BJFKDHHMLJH;
	}

	private void JHJGJJKELJM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NNCCPEBIAKH()
	{
		SCShader = Shader.Find("Operation ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1330f)
			{
				HBJJOCHGOPH = 869f;
			}
			HKGAONMOBMH().SetFloat("float,1", HBJJOCHGOPH);
			IIBLJCKLGFG().SetFloat("/", Therma_Variation);
			IIBLJCKLGFG().SetFloat("#ok", Speed);
			EPCGJFCCAFH().SetFloat("_TimeX", ALELLLFCDBF);
			HKGAONMOBMH().SetFloat("nogamesfound", NFDIFLHGJKB);
			IIBLJCKLGFG().SetVector("_NoisePerChannel", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 970f, 925f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
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
			NBPKMLMCHFN.SetFloat("_Value", Therma_Variation);
			NBPKMLMCHFN.SetFloat("_Value2", Speed);
			NBPKMLMCHFN.SetFloat("_Value3", ALELLLFCDBF);
			NBPKMLMCHFN.SetFloat("_Value4", NFDIFLHGJKB);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FIKFJDFELIP()
	{
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1416f)
			{
				HBJJOCHGOPH = 899f;
			}
			MCDGIILBNIF().SetFloat("EventData0DropDownList", HBJJOCHGOPH);
			HKGAONMOBMH().SetFloat("_Screen", Therma_Variation);
			KBOPGONOCNP().SetFloat("Instance\nWorking commands:\ninit or init <savepath>\npath\nsetint <key> <value>\ngetint <key> <value>\nsetfloat <key> <value>\ngetfloat <key> <value>\nsetstring <key> <value>\ngetstring <key> <value>\nsetbool <key> <value>\ngetbool <key> <value>\ndelete <key>\ndeleteall", Speed);
			EJDPNJAEAKJ().SetFloat("_Value3", ALELLLFCDBF);
			EJDPNJAEAKJ().SetFloat("_EmissionColor", NFDIFLHGJKB);
			NBPKMLMCHFN.SetVector("Object ID. Case-Sensitive", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1368f, 1642f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EJDPNJAEAKJ());
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

	[SpecialName]
	private Material IIBLJCKLGFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void MJEFMIPLFAB()
	{
		SCShader = Shader.Find("1234332714");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NCPAFCKGJEA()
	{
	}

	[SpecialName]
	private Material EPCGJFCCAFH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void AGMJDGHLBMN()
	{
	}

	private void DGCGGKMNPLD()
	{
	}

	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1890f)
			{
				HBJJOCHGOPH = 1541f;
			}
			EJDPNJAEAKJ().SetFloat("Connecting to server", HBJJOCHGOPH);
			HKGAONMOBMH().SetFloat("PunRespawn with Position.", Therma_Variation);
			IIBLJCKLGFG().SetFloat("<b>(╯°□°）╯︵ ┻━┻</b>", Speed);
			DEFBJOCJJKF().SetFloat("st", ALELLLFCDBF);
			NBPKMLMCHFN.SetFloat("_Threshhold", NFDIFLHGJKB);
			GCDFNHMJMIP().SetVector("Editor/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1388f, 969f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FJIKDJAMOHA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Update()
	{
	}

	private void PAEGLMEOKHP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NKLIHNJCHOG()
	{
	}

	private void OFPPIKHNJOD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FNCDAPDOBBI()
	{
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EJJEDJIOFAB()
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
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)71;
		}
		return BJFKDHHMLJH;
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 640f)
			{
				HBJJOCHGOPH = 1790f;
			}
			HKGAONMOBMH().SetFloat("ReJoinRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("_TimeX", Therma_Variation);
			ADGHJOHKEHG().SetFloat("EventConfigButton", Speed);
			KBOPGONOCNP().SetFloat("_BlurVector", ALELLLFCDBF);
			ADGHJOHKEHG().SetFloat("The shader ", NFDIFLHGJKB);
			IIBLJCKLGFG().SetVector("GameScene", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 249f, 483f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ONMGIPAILOH()
	{
	}

	private void HMPGIFBJFIK()
	{
		SCShader = Shader.Find("[PlayerBase] ShowImage \"");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LJIHHJOAJCN()
	{
	}

	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 696f)
			{
				HBJJOCHGOPH = 1968f;
			}
			EJDPNJAEAKJ().SetFloat("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", HBJJOCHGOPH);
			GCDFNHMJMIP().SetFloat("SpawnObj", Therma_Variation);
			KBOPGONOCNP().SetFloat("ItemNameText", Speed);
			HKGAONMOBMH().SetFloat("value", ALELLLFCDBF);
			NBPKMLMCHFN.SetFloat("4,28,true,0", NFDIFLHGJKB);
			IIBLJCKLGFG().SetVector("_Bullet_1", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 346f, 1284f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FABKIGNFECE()
	{
	}

	private void MAOCOEGAFND()
	{
	}

	private void LLJLDLLNFBH()
	{
	}

	private void BMIOFJFMCBG()
	{
		SCShader = Shader.Find("CameraFilterPack/TV_Chromatical2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LOMDIOLNFHI()
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
			BJFKDHHMLJH.hideFlags = HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void JHANGPCOCIG()
	{
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DHENLPJJOEN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JDGFCEPDKAJ()
	{
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1759f)
			{
				HBJJOCHGOPH = 151f;
			}
			NBPKMLMCHFN.SetFloat("blue", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("float,0", Therma_Variation);
			HKGAONMOBMH().SetFloat("_Saturation", Speed);
			EPCGJFCCAFH().SetFloat("_ScreenResolution", ALELLLFCDBF);
			HKGAONMOBMH().SetFloat("skin.hit_perfect", NFDIFLHGJKB);
			GCDFNHMJMIP().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1078f, 942f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 203f)
			{
				HBJJOCHGOPH = 891f;
			}
			KBOPGONOCNP().SetFloat("PLEASE WAIT", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("]", Therma_Variation);
			DEFBJOCJJKF().SetFloat("ControllerLeftY", Speed);
			DEFBJOCJJKF().SetFloat("_Fade", ALELLLFCDBF);
			MCDGIILBNIF().SetFloat("CameraFilterPack/Gradients_Desert", NFDIFLHGJKB);
			HKGAONMOBMH().SetVector("StartButton", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 668f, 489f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EJFJENFKLND()
	{
	}

	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1002f)
			{
				HBJJOCHGOPH = 51f;
			}
			EJDPNJAEAKJ().SetFloat("BlockSize", HBJJOCHGOPH);
			EJDPNJAEAKJ().SetFloat("CameraFilterPack/Blend2Camera_Saturation", Therma_Variation);
			KBOPGONOCNP().SetFloat("Please attach component to a Graphical UI component", Speed);
			EJDPNJAEAKJ().SetFloat(")", ALELLLFCDBF);
			HKGAONMOBMH().SetFloat("_Value5", NFDIFLHGJKB);
			HKGAONMOBMH().SetVector("LevelNameInputField", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 746f, 1409f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 821f)
			{
				HBJJOCHGOPH = 761f;
			}
			HHIFMIPPMPF().SetFloat("CameraFilterPack/Vision_Tunnel", HBJJOCHGOPH);
			EJDPNJAEAKJ().SetFloat("settings.enablehitsoundsinnormal", Therma_Variation);
			KBOPGONOCNP().SetFloat("Noise & Grain effect failing as noise texture is not assigned. please assign.", Speed);
			GCDFNHMJMIP().SetFloat("_ReprojectionMatrix", ALELLLFCDBF);
			MCDGIILBNIF().SetFloat("_MatrixSize", NFDIFLHGJKB);
			EJDPNJAEAKJ().SetVector("_Value4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1178f, 968f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1566f)
			{
				HBJJOCHGOPH = 303f;
			}
			EJDPNJAEAKJ().SetFloat("Write me to get one for testing :)", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("StartButton", Therma_Variation);
			NBPKMLMCHFN.SetFloat("GameScene", Speed);
			MCDGIILBNIF().SetFloat("CameraFilterPack/EyesVision_2", ALELLLFCDBF);
			MCDGIILBNIF().SetFloat("_ScreenResolution", NFDIFLHGJKB);
			DEFBJOCJJKF().SetVector(",", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 572f, 279f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 417f)
			{
				HBJJOCHGOPH = 523f;
			}
			NBPKMLMCHFN.SetFloat("_TimeX", HBJJOCHGOPH);
			HKGAONMOBMH().SetFloat("maps.", Therma_Variation);
			EJDPNJAEAKJ().SetFloat("_BlurDirectionPacked", Speed);
			GCDFNHMJMIP().SetFloat("Please attach component to a Graphical UI component", ALELLLFCDBF);
			HKGAONMOBMH().SetFloat("Noise shaders are not set up! Disabling noise effect.", NFDIFLHGJKB);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 273f, 1461f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OCCGJMPAJIK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EFJDNLGNACH()
	{
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material HKGAONMOBMH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void BOLBPPHJBMI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OIBMHPIFAKK()
	{
	}

	private void MECJHOJPODB()
	{
	}

	private void EGEGNHLODAA()
	{
	}

	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1741f)
			{
				HBJJOCHGOPH = 711f;
			}
			EPCGJFCCAFH().SetFloat("TwoHands", HBJJOCHGOPH);
			ADGHJOHKEHG().SetFloat("inventory.selected.", Therma_Variation);
			EPCGJFCCAFH().SetFloat("_Far", Speed);
			MCDGIILBNIF().SetFloat("_TimeX", ALELLLFCDBF);
			KBOPGONOCNP().SetFloat("Joystick1Button2", NFDIFLHGJKB);
			IIBLJCKLGFG().SetVector("UseScanLine", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1561f, 244f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HHIFMIPPMPF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInHierarchy);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material MCDGIILBNIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void IIFCIDDJHPM()
	{
	}

	private void CBIBDOIBJAI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material GCDFNHMJMIP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return BJFKDHHMLJH;
	}

	private void HLIAEEMGBHN()
	{
		SCShader = Shader.Find("Parameter levelId can't be null!");
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
			if (HBJJOCHGOPH > 1460f)
			{
				HBJJOCHGOPH = 123f;
			}
			EJDPNJAEAKJ().SetFloat("_MainTex2", HBJJOCHGOPH);
			GCDFNHMJMIP().SetFloat("Texture2", Therma_Variation);
			HKGAONMOBMH().SetFloat("achievements.21.progress", Speed);
			MCDGIILBNIF().SetFloat("_Value3", ALELLLFCDBF);
			IIBLJCKLGFG().SetFloat("_Val3", NFDIFLHGJKB);
			GCDFNHMJMIP().SetVector("VHS", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1776f, 1797f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JBNPEHMDCMI()
	{
	}

	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1092f)
			{
				HBJJOCHGOPH = 230f;
			}
			EJDPNJAEAKJ().SetFloat("YES", HBJJOCHGOPH);
			GCDFNHMJMIP().SetFloat(" = ", Therma_Variation);
			HHIFMIPPMPF().SetFloat("L1", Speed);
			DEFBJOCJJKF().SetFloat(": ", ALELLLFCDBF);
			ADGHJOHKEHG().SetFloat("_TimeX", NFDIFLHGJKB);
			NBPKMLMCHFN.SetVector("Jit ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 311f, 851f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-65);
		}
		return BJFKDHHMLJH;
	}

	private void KMCPMOGKDEH()
	{
		SCShader = Shader.Find(" Remote called.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FGOPJMGNHGO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HGDDCINLDAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}
}
