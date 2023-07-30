// CameraFilterPack_Light_Water
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Light/Water")]
[ExecuteInEditMode]
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
		SCShader = Shader.Find("_Value3");
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
		SCShader = Shader.Find("/icon");
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
		SCShader = Shader.Find("cancel");
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
		SCShader = Shader.Find("x");
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
		SCShader = Shader.Find("y");
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
			JLHLHKPHDFO().SetFloat("Show text at the center of the screen. Usefull for quick messages like 'Thanks for playing!'", HBJJOCHGOPH);
			DONENAMLFLF().SetFloat("Ev OwnershipTransfer. ViewID ", Alpha);
			IONHGBPGCHK().SetFloat("_ScreenResolution", Distance);
			NFMGLIKNOOC().SetFloat("Object ID. Case-Sensitive", Size);
			NBPKMLMCHFN.SetVector("14", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 211f, 1400f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ICILLMAKLMI()
	{
		SCShader = Shader.Find("mapid");
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
			DONENAMLFLF().SetFloat("settings.volume.game", HBJJOCHGOPH);
			LENEJAGLCNL().SetFloat("Object ID. Case-Sensitive", Alpha);
			DONENAMLFLF().SetFloat("SpawnObj", Distance);
			LENEJAGLCNL().SetFloat("inventory.selected.", Size);
			JLHLHKPHDFO().SetVector(" SphereWaveform.cs", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1978f, 44f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
		SCShader = Shader.Find("[TextSaver] Text saved to ");
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
			NBPKMLMCHFN.SetFloat("#reward: ", HBJJOCHGOPH);
			FEAEGGCNIAA().SetFloat("_TimeX", Alpha);
			NBPKMLMCHFN.SetFloat(".", Distance);
			NFMGLIKNOOC().SetFloat("default", Size);
			FEAEGGCNIAA().SetVector("SpawnObj", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1314f, 764f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JLHLHKPHDFO());
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
			HKGAONMOBMH().SetFloat("ns.exitgames.com", HBJJOCHGOPH);
			HKGAONMOBMH().SetFloat("Set satellite emission (glow)", Alpha);
			FEAEGGCNIAA().SetFloat("RequestOwnership(): ", Distance);
			PLBEJJIHFPB().SetFloat("OnAwakeRPC", Size);
			HKGAONMOBMH().SetVector("offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1438f, 1296f));
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
			HKGAONMOBMH().SetFloat("<b>Time</b>:", HBJJOCHGOPH);
			DONENAMLFLF().SetFloat("DestroyPlayerObjects() failed, cause players can only destroy their own GameObjects. A Master Client can destroy anyone's. This is master: ", Alpha);
			OCHJIMJNEMO().SetFloat("Right Stick Click", Distance);
			PLBEJJIHFPB().SetFloat("From {0} at Index {1} \n", Size);
			NFMGLIKNOOC().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 71f, 1589f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
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
			NFMGLIKNOOC().SetFloat("PointerEnter ", HBJJOCHGOPH);
			OCHJIMJNEMO().SetFloat("menu.hardcoreinfo", Alpha);
			OCHJIMJNEMO().SetFloat("_Value12", Distance);
			LENEJAGLCNL().SetFloat("Map: ", Size);
			HKGAONMOBMH().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1846f, 530f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
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
			PLBEJJIHFPB().SetFloat("settings.cameramovements", HBJJOCHGOPH);
			LENEJAGLCNL().SetFloat("CameraFilterPack/Color_GrayScale", Alpha);
			LENEJAGLCNL().SetFloat("21x3", Distance);
			HKGAONMOBMH().SetFloat("restrictions\n\n#until: ", Size);
			OCHJIMJNEMO().SetVector("0,1,false", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 838f, 1122f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OCHJIMJNEMO());
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
			PLBEJJIHFPB().SetFloat("SetScale", HBJJOCHGOPH);
			LENEJAGLCNL().SetFloat("newPath", Alpha);
			DONENAMLFLF().SetFloat("custom", Distance);
			NBPKMLMCHFN.SetFloat("_TimeX", Size);
			HKGAONMOBMH().SetVector("CameraFilterPack/Blend2Camera_ColorBurn", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 193f, 1441f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OCHJIMJNEMO());
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
		SCShader = Shader.Find("Joystick1Button11");
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
			NBPKMLMCHFN.SetFloat("_Near", HBJJOCHGOPH);
			HEHKGPKLAKK().SetFloat("grid", Alpha);
			IONHGBPGCHK().SetFloat("_Intensity", Distance);
			NFMGLIKNOOC().SetFloat("SetSunLerpSpeed", Size);
			PLBEJJIHFPB().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 704f, 1784f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LENEJAGLCNL());
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
			HKGAONMOBMH().SetFloat(" ", HBJJOCHGOPH);
			FEAEGGCNIAA().SetFloat("_Value6", Alpha);
			NFMGLIKNOOC().SetFloat("Error0", Distance);
			FEAEGGCNIAA().SetFloat("FinalScoreSmallText", Size);
			LENEJAGLCNL().SetVector("color", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 184f, 1889f));
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
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IHLMNAGPKDA()
	{
		SCShader = Shader.Find("] to be droppable");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FHPFJBFCOOF()
	{
		SCShader = Shader.Find("[PlayerController] ");
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
		SCShader = Shader.Find("ticket");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HMPGIFBJFIK()
	{
		SCShader = Shader.Find("Cause: ");
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
			JLHLHKPHDFO().SetFloat("blue", HBJJOCHGOPH);
			FEAEGGCNIAA().SetFloat("_TimeX", Alpha);
			NBPKMLMCHFN.SetFloat("_SecondTex", Distance);
			HEHKGPKLAKK().SetFloat("CameraFilterPack/Fly_Vision", Size);
			IONHGBPGCHK().SetVector("OK", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1891f, 187f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DONENAMLFLF());
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
		SCShader = Shader.Find("_Value3");
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
