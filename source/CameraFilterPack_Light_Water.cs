// CameraFilterPack_Light_Water
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Light/Water")]
public class CameraFilterPack_Light_Water : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 1f)]
	public float Size = 4f;

	[Range(0f, 2f)]
	public float Alpha = 0.07f;

	[Range(0f, 32f)]
	public float Distance = 10f;

	[Range(-2f, 2f)]
	public float Speed = 0.4f;

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

	private void AGEJKLMJGDO()
	{
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material OCHJIMJNEMO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-66);
		}
		return BJFKDHHMLJH;
	}

	private void JMEOGJHCONJ()
	{
		SCShader = Shader.Find("icon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IIFCIDDJHPM()
	{
	}

	private void OCCGJMPAJIK()
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

	private void LJIHHJOAJCN()
	{
	}

	private void FANADGBGCPI()
	{
		SCShader = Shader.Find("selector");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime * Speed;
			if (HBJJOCHGOPH > 100f)
			{
				HBJJOCHGOPH = 0f;
			}
			NBPKMLMCHFN.SetFloat("_TimeX", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Alpha", Alpha);
			NBPKMLMCHFN.SetFloat("_Distance", Distance);
			NBPKMLMCHFN.SetFloat("_Size", Size);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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

	private void IFJDKDFLGBG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KNBJBNDGCIJ()
	{
		SCShader = Shader.Find("_Value8");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IKIDIJLIGOH()
	{
	}

	[SpecialName]
	private Material NFMGLIKNOOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void MECJHOJPODB()
	{
	}

	private void AGMJDGHLBMN()
	{
	}

	private void AIJGAJIOJDJ()
	{
	}

	[SpecialName]
	private Material DONENAMLFLF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-118);
		}
		return BJFKDHHMLJH;
	}

	private void KKEOHFGKCIK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ONMGIPAILOH()
	{
	}

	private void DKOPKPBLDHH()
	{
		SCShader = Shader.Find("restart");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EGEGNHLODAA()
	{
	}

	private void BMIOFJFMCBG()
	{
		SCShader = Shader.Find("w");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Light_Water");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DKGBFNCOAEO()
	{
		SCShader = Shader.Find("help");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime * Speed;
			if (HBJJOCHGOPH > 1797f)
			{
				HBJJOCHGOPH = 1469f;
			}
			NFMGLIKNOOC().SetFloat("SetBGColor", HBJJOCHGOPH);
			HKGAONMOBMH().SetFloat("Error: Someone else(", Alpha);
			DONENAMLFLF().SetFloat("CameraFilterPack/Edge_Edge_filter", Distance);
			HKGAONMOBMH().SetFloat("Object ID. Case-Sensitive", Size);
			JLHLHKPHDFO().SetVector("Working.\nPlease wait..", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 211f, 1400f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ICILLMAKLMI()
	{
		SCShader = Shader.Find("gamemode");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime * Speed;
			if (HBJJOCHGOPH > 147f)
			{
				HBJJOCHGOPH = 1805f;
			}
			NFMGLIKNOOC().SetFloat("settings.volume.sfx", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("Object ID. Case-Sensitive", Alpha);
			DONENAMLFLF().SetFloat("[Right]", Distance);
			HKGAONMOBMH().SetFloat("[ResourcesManager] Load image error: ", Size);
			NBPKMLMCHFN.SetVector(" SphereWaveform.cs", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1978f, 44f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BEBNOKFLJPH()
	{
		SCShader = Shader.Find("CameraFilterPack/Blur_GaussianBlur");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EGEPLFGKGLI()
	{
		SCShader = Shader.Find("/../");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MMBPLGGLPDB()
	{
	}

	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime * Speed;
			if (HBJJOCHGOPH > 1036f)
			{
				HBJJOCHGOPH = 1587f;
			}
			JLHLHKPHDFO().SetFloat("#finished", HBJJOCHGOPH);
			DONENAMLFLF().SetFloat("_Value", Alpha);
			DONENAMLFLF().SetFloat(".highscore", Distance);
			HKGAONMOBMH().SetFloat("Data/Skins/", Size);
			NBPKMLMCHFN.SetVector("SpawnObj", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1314f, 764f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HGDDCINLDAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime * Speed;
			if (HBJJOCHGOPH > 1784f)
			{
				HBJJOCHGOPH = 1152f;
			}
			DONENAMLFLF().SetFloat("ReconnectAndRejoin() with AuthValues == null is not correct!", HBJJOCHGOPH);
			HKGAONMOBMH().SetFloat("Set satellite emission (glow)", Alpha);
			FEAEGGCNIAA().SetFloat(" Time: ", Distance);
			FEAEGGCNIAA().SetFloat("RPC: 'OnAwakeRPC' Parameter: ", Size);
			FEAEGGCNIAA().SetVector("offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1438f, 1296f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OEENOOGEEHD()
	{
	}

	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime * Speed;
			if (HBJJOCHGOPH > 924f)
			{
				HBJJOCHGOPH = 1931f;
			}
			HEHKGPKLAKK().SetFloat("--------------------------------", HBJJOCHGOPH);
			HKGAONMOBMH().SetFloat("RPCs can only be sent in rooms. Call of \"", Alpha);
			JLHLHKPHDFO().SetFloat("Joystick1Button12", Distance);
			LENEJAGLCNL().SetFloat("SelectionBox component must be placed on a canvas in Screen Space Overlay mode.", Size);
			JLHLHKPHDFO().SetVector("Editor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 71f, 1589f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime * Speed;
			if (HBJJOCHGOPH > 391f)
			{
				HBJJOCHGOPH = 522f;
			}
			NFMGLIKNOOC().SetFloat("null", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("hardcoreinfo", Alpha);
			PLBEJJIHFPB().SetFloat("_Value12", Distance);
			OCHJIMJNEMO().SetFloat("Map: ", Size);
			PLBEJJIHFPB().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1846f, 530f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KMEONPMCNJG()
	{
	}

	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime * Speed;
			if (HBJJOCHGOPH > 27f)
			{
				HBJJOCHGOPH = 1159f;
			}
			NBPKMLMCHFN.SetFloat("settings.cameramovements", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("CameraFilterPack/Color_GrayScale", Alpha);
			IONHGBPGCHK().SetFloat("inventory.selected.", Distance);
			NBPKMLMCHFN.SetFloat("restrictions\n\n#until: ", Size);
			NFMGLIKNOOC().SetVector("green", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 838f, 1122f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LENEJAGLCNL());
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
	private Material JLHLHKPHDFO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime * Speed;
			if (HBJJOCHGOPH > 904f)
			{
				HBJJOCHGOPH = 1104f;
			}
			PLBEJJIHFPB().SetFloat("SetSunInput", HBJJOCHGOPH);
			DONENAMLFLF().SetFloat("Sprite", Alpha);
			PLBEJJIHFPB().SetFloat("[PlayerBase] Loaded environment: ", Distance);
			JLHLHKPHDFO().SetFloat("UseFinalGlassColor", Size);
			DONENAMLFLF().SetVector("CameraFilterPack/Blend2Camera_ColorBurn", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 193f, 1441f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LPMINJJPDCH()
	{
	}

	private void EJJEDJIOFAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ILCFPCIPENO()
	{
		SCShader = Shader.Find("Joystick1Button12");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material LENEJAGLCNL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return BJFKDHHMLJH;
	}

	private void BFEILOMHNPC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime * Speed;
			if (HBJJOCHGOPH > 1577f)
			{
				HBJJOCHGOPH = 120f;
			}
			NFMGLIKNOOC().SetFloat("_Near", HBJJOCHGOPH);
			JLHLHKPHDFO().SetFloat("caret", Alpha);
			OCHJIMJNEMO().SetFloat("_ScreenResolution", Distance);
			JLHLHKPHDFO().SetFloat("SetSatelliteEmission", Size);
			NBPKMLMCHFN.SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 704f, 1784f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
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

	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime * Speed;
			if (HBJJOCHGOPH > 1379f)
			{
				HBJJOCHGOPH = 752f;
			}
			JLHLHKPHDFO().SetFloat("Warning, using scrollbors with the Scroll Snap controls is not advised as it causes unpredictable results", HBJJOCHGOPH);
			LENEJAGLCNL().SetFloat("_Value7", Alpha);
			IONHGBPGCHK().SetFloat("Error0", Distance);
			HKGAONMOBMH().SetFloat("FinalScoreSmallText", Size);
			NBPKMLMCHFN.SetVector("Hex value #RRGGBB", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 184f, 1889f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CNDACAHCCOI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LOMDIOLNFHI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CNGAJDBOCLJ()
	{
		SCShader = Shader.Find("CameraFilterPack_Paper1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IHLMNAGPKDA()
	{
		SCShader = Shader.Find("Hello World, is my item a clone? [");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FHPFJBFCOOF()
	{
		SCShader = Shader.Find(": ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LLJLDLLNFBH()
	{
	}

	private void Update()
	{
	}

	private void FOMNCPKKCFN()
	{
	}

	[SpecialName]
	private Material HKGAONMOBMH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
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

	[SpecialName]
	private Material FEAEGGCNIAA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void PBEPCAPAKLG()
	{
	}

	private void MAOCOEGAFND()
	{
	}

	private void ODGMCJILIHF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material PLBEJJIHFPB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void KLILJHJNICK()
	{
		SCShader = Shader.Find("steamid");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HMPGIFBJFIK()
	{
		SCShader = Shader.Find("There are too many cells created by your subdivision options. Maximum allowed number of cells is ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime * Speed;
			if (HBJJOCHGOPH > 160f)
			{
				HBJJOCHGOPH = 1744f;
			}
			FEAEGGCNIAA().SetFloat("0,1,false", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value", Alpha);
			PLBEJJIHFPB().SetFloat("_Offsets", Distance);
			HEHKGPKLAKK().SetFloat("CameraFilterPack/Fly_Vision", Size);
			JLHLHKPHDFO().SetVector("Edited unlock conditions", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1891f, 187f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LENEJAGLCNL());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)81;
		}
		return BJFKDHHMLJH;
	}

	private void FBPHNEJBDJN()
	{
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HPNNCNNFMGK()
	{
	}

	private void HLIAEEMGBHN()
	{
		SCShader = Shader.Find(" - LOCAL");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
