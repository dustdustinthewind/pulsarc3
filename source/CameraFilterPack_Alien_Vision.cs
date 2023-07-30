// CameraFilterPack_Alien_Vision
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Alien/Vision")]
[ExecuteInEditMode]
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
		SCShader = Shader.Find("Xbox Home");
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
		SCShader = Shader.Find(". Stopping handling if inactive.");
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
			EJDPNJAEAKJ().SetFloat("float,1", HBJJOCHGOPH);
			GCDFNHMJMIP().SetFloat("/icon", Therma_Variation);
			DEFBJOCJJKF().SetFloat("}", Speed);
			ADGHJOHKEHG().SetFloat("CameraFilterPack/VHS_Tracking", ALELLLFCDBF);
			EJDPNJAEAKJ().SetFloat("MessageText", NFDIFLHGJKB);
			HHIFMIPPMPF().SetVector("_NoiseTex", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 970f, 925f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIBLJCKLGFG());
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
		SCShader = Shader.Find("_Value3");
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
			HKGAONMOBMH().SetFloat("BitsData", HBJJOCHGOPH);
			GCDFNHMJMIP().SetFloat("pointBuffer", Therma_Variation);
			IIBLJCKLGFG().SetFloat("Instance\nWorking commands:\ninit or init <savepath>\npath\nsetint <key> <value>\ngetint <key> <value>\nsetfloat <key> <value>\ngetfloat <key> <value>\nsetstring <key> <value>\ngetstring <key> <value>\nsetbool <key> <value>\ngetbool <key> <value>\ndelete <key>\ndeleteall", Speed);
			NBPKMLMCHFN.SetFloat("_Value2", ALELLLFCDBF);
			IIBLJCKLGFG().SetFloat("LevelEditor/icons", NFDIFLHGJKB);
			ADGHJOHKEHG().SetVector("Object ID. Case-Sensitive", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1368f, 1642f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
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
		SCShader = Shader.Find("907198288");
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
			EJDPNJAEAKJ().SetFloat("LoadingStatusText", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("OnPickedUp", Therma_Variation);
			HKGAONMOBMH().SetFloat("<b>(╯°□°）╯︵ ┻━┻</b>", Speed);
			IIBLJCKLGFG().SetFloat("StartTime already set: ", ALELLLFCDBF);
			IIBLJCKLGFG().SetFloat("colorD", NFDIFLHGJKB);
			MCDGIILBNIF().SetVector("#alreadyexist", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1388f, 969f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
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
		SCShader = Shader.Find("_TimeX");
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
			EPCGJFCCAFH().SetFloat("JoinRandomRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("CameraFilterPack/TV_BrokenGlass", Therma_Variation);
			IIBLJCKLGFG().SetFloat("EventConfigButton", Speed);
			GCDFNHMJMIP().SetFloat("_BlurVector", ALELLLFCDBF);
			DEFBJOCJJKF().SetFloat("The image effect ", NFDIFLHGJKB);
			ADGHJOHKEHG().SetVector("GameScene", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 249f, 483f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
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
		SCShader = Shader.Find("[PlayerBase] Got checkpoint at ");
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
			ADGHJOHKEHG().SetFloat("input", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("[Up]", Therma_Variation);
			ADGHJOHKEHG().SetFloat("ItemsCountText", Speed);
			ADGHJOHKEHG().SetFloat("value", ALELLLFCDBF);
			ADGHJOHKEHG().SetFloat("distance", NFDIFLHGJKB);
			HHIFMIPPMPF().SetVector("CameraFilterPack/TV_BrokenGlass2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 346f, 1284f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
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
		SCShader = Shader.Find("_ScreenResolution");
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
		SCShader = Shader.Find("_TimeX");
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
			IIBLJCKLGFG().SetFloat("0,1,false", HBJJOCHGOPH);
			EJDPNJAEAKJ().SetFloat("z", Therma_Variation);
			ADGHJOHKEHG().SetFloat("_Saturation", Speed);
			IIBLJCKLGFG().SetFloat("_Value3", ALELLLFCDBF);
			HHIFMIPPMPF().SetFloat("sounds/hit_wrong", NFDIFLHGJKB);
			GCDFNHMJMIP().SetVector("_Value4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1078f, 942f));
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
			NBPKMLMCHFN.SetFloat("PLEASE WAIT", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("Toggle {0} is not part of ToggleGroup {1}", Therma_Variation);
			HKGAONMOBMH().SetFloat("Backward", Speed);
			GCDFNHMJMIP().SetFloat("_Wavy", ALELLLFCDBF);
			EJDPNJAEAKJ().SetFloat("_ScreenResolution", NFDIFLHGJKB);
			EJDPNJAEAKJ().SetVector("StartButton", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 668f, 489f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIBLJCKLGFG());
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
			NBPKMLMCHFN.SetFloat("SupportLogger OnLeftRoom().", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Blend2Camera_Saturation", Therma_Variation);
			IIBLJCKLGFG().SetFloat("Please attach component to a Graphical UI component", Speed);
			IIBLJCKLGFG().SetFloat(" timeUntilRespawn: ", ALELLLFCDBF);
			DEFBJOCJJKF().SetFloat("_Value5", NFDIFLHGJKB);
			ADGHJOHKEHG().SetVector("Tab1Content", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 746f, 1409f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
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
			EPCGJFCCAFH().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("settings.disablestoryboard", Therma_Variation);
			HHIFMIPPMPF().SetFloat("_MainTex", Speed);
			GCDFNHMJMIP().SetFloat("_Params1", ALELLLFCDBF);
			KBOPGONOCNP().SetFloat("_MatrixSize", NFDIFLHGJKB);
			HHIFMIPPMPF().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1178f, 968f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
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
			ADGHJOHKEHG().SetFloat("?", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("StartButton", Therma_Variation);
			DEFBJOCJJKF().SetFloat("http://steamcommunity.com/sharedfiles/filedetails/?id=", Speed);
			EPCGJFCCAFH().SetFloat("CameraFilterPack_eyes_vision_2", ALELLLFCDBF);
			ADGHJOHKEHG().SetFloat("_Value4", NFDIFLHGJKB);
			IIBLJCKLGFG().SetVector("/512px-512px.png", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 572f, 279f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
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
			MCDGIILBNIF().SetFloat("CameraFilterPack/Glasses_OnX", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("Crosshair2", Therma_Variation);
			GCDFNHMJMIP().SetFloat("_PrevViewProj", Speed);
			NBPKMLMCHFN.SetFloat("Default UI Material", ALELLLFCDBF);
			DEFBJOCJJKF().SetFloat("_NoiseTex", NFDIFLHGJKB);
			KBOPGONOCNP().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 273f, 1461f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EJDPNJAEAKJ());
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
			EPCGJFCCAFH().SetFloat("event", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("inventory.selected.", Therma_Variation);
			EPCGJFCCAFH().SetFloat("_Near", Speed);
			ADGHJOHKEHG().SetFloat("_ScreenResolution", ALELLLFCDBF);
			ADGHJOHKEHG().SetFloat("A", NFDIFLHGJKB);
			KBOPGONOCNP().SetVector("UseScanLineSize", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1561f, 244f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
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
		SCShader = Shader.Find("curScn");
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
			EPCGJFCCAFH().SetFloat("_MainTex2", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("_ScreenResolution", Therma_Variation);
			EPCGJFCCAFH().SetFloat("NEW_ACHIEVEMENT_1_21", Speed);
			KBOPGONOCNP().SetFloat("_Value2", ALELLLFCDBF);
			MCDGIILBNIF().SetFloat("_Val2", NFDIFLHGJKB);
			GCDFNHMJMIP().SetVector("CameraFilterPack_VHS2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1776f, 1797f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			ADGHJOHKEHG().SetFloat("Save the map before exiting?", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("The number of objects sent via a PhotonStreamQueue has to be the same each frame", Therma_Variation);
			HKGAONMOBMH().SetFloat("Joystick1Button4", Speed);
			DEFBJOCJJKF().SetFloat("[PlayerController] ", ALELLLFCDBF);
			HHIFMIPPMPF().SetFloat("_ScreenResolution", NFDIFLHGJKB);
			KBOPGONOCNP().SetVector("Rtt:{0,4} +/-{1,3}", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 311f, 851f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
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
		SCShader = Shader.Find(" but this PhotonView does not exist! View was/is ours.");
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
