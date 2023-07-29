// CameraFilterPack_TV_PlanetMars
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/TV/Planet Mars")]
[ExecuteInEditMode]
public class CameraFilterPack_TV_PlanetMars : MonoBehaviour
{
	public Shader SCShader;

	private Vector4 GOIJPFAHKPE;

	[Range(0f, 1f)]
	public float Fade = 1f;

	private float HBJJOCHGOPH = 1f;

	[Range(-10f, 10f)]
	public float Distortion = 1f;

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

	[SpecialName]
	private Material HFBJAOFLCJI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-91);
		}
		return BJFKDHHMLJH;
	}

	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1110f)
			{
				HBJJOCHGOPH = 1856f;
			}
			BAGICADFBAB().SetFloat(" not exist", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("IntraSig", Distortion);
			HHIFMIPPMPF().SetFloat("[SaveSystem] Init from ", Fade);
			CIAFLBFJLEJ().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 503f, 554f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFCPHFMKHII());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PMPKMGKAAJH()
	{
		SCShader = Shader.Find("ItemNameText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1541f)
			{
				HBJJOCHGOPH = 1339f;
			}
			NFMGLIKNOOC().SetFloat("Sequence contains no elements", HBJJOCHGOPH);
			OLHDPICFBOF().SetFloat("RedoButton", Distortion);
			CIAFLBFJLEJ().SetFloat(".icon", Fade);
			CECJJMKLEAK().SetVector("settings_bindings_controller_type", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1880f, 1404f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IHHNCCOGLPN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HEINDEMCGIK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void HDDECCMEJKA()
	{
	}

	private void BDBJEDIOKBN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AEEGKLABFLN()
	{
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
			NBPKMLMCHFN.SetFloat("_Distortion", Distortion);
			NBPKMLMCHFN.SetFloat("Fade", Fade);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 629f)
			{
				HBJJOCHGOPH = 1591f;
			}
			LPDOGGFOBDH().SetFloat("BitsData", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("_Value4", Distortion);
			OIIDAKBILMI().SetFloat("MapConfig", Fade);
			CECJJMKLEAK().SetVector("mapselector.filter.favoriteonly", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 437f, 64f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CIAFLBFJLEJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HMPGIFBJFIK()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material MHBAIEKFBIJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material BAGICADFBAB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-92);
		}
		return BJFKDHHMLJH;
	}

	private void AAPKBNDHBLI()
	{
	}

	private void EDBEHEKMGFH()
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

	private void MMBPLGGLPDB()
	{
	}

	[SpecialName]
	private Material OGMEGHKECAH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)89;
		}
		return BJFKDHHMLJH;
	}

	private void AEDDNDHCLNN()
	{
		SCShader = Shader.Find("PhotonServerSettings");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1670f)
			{
				HBJJOCHGOPH = 1771f;
			}
			MJJIEHANFJA().SetFloat("skin.", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("_TimeX", Distortion);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", Fade);
			HNICHJCGJOC().SetVector("Tab1Content", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1376f, 1580f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FABMDEHEDNO()
	{
	}

	private void KKEOHFGKCIK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material NFMGLIKNOOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-126);
		}
		return BJFKDHHMLJH;
	}

	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 487f)
			{
				HBJJOCHGOPH = 1093f;
			}
			HNICHJCGJOC().SetFloat("_TimeX", HBJJOCHGOPH);
			GHHPOGODBHB().SetFloat("UI Extensions/UISoftAdditive", Distortion);
			IONHGBPGCHK().SetFloat("MenuScene", Fade);
			MHBAIEKFBIJ().SetVector("event", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1017f, 545f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
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
			if (HBJJOCHGOPH > 733f)
			{
				HBJJOCHGOPH = 654f;
			}
			MJJIEHANFJA().SetFloat("[ItemsHandler] Loading ", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("_ScreenResolution", Distortion);
			MHBAIEKFBIJ().SetFloat("maps.", Fade);
			LPDOGGFOBDH().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 607f, 344f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BAGICADFBAB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DAHFFNNIGML()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JECMJNFGBGC()
	{
		SCShader = Shader.Find(".");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material HHIFMIPPMPF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-118);
		}
		return BJFKDHHMLJH;
	}

	private void LJIHHJOAJCN()
	{
	}

	private void PKGJJFIFLII()
	{
	}

	private void JFJLGJEPEAA()
	{
		SCShader = Shader.Find("]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NEKCPLGFOFD()
	{
	}

	private void ALMGMOOHLMA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JEBIBKLHFLB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 434f)
			{
				HBJJOCHGOPH = 1903f;
			}
			HFBJAOFLCJI().SetFloat("Editor/", HBJJOCHGOPH);
			OIIDAKBILMI().SetFloat("Fade", Distortion);
			OIIDAKBILMI().SetFloat("/../", Fade);
			CIAFLBFJLEJ().SetVector("Set Particles Gravity", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 605f, 1297f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LLKKGGLNIDF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OPCLBGHAPMG()
	{
	}

	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 206f)
			{
				HBJJOCHGOPH = 416f;
			}
			NBPKMLMCHFN.SetFloat("menu.playedpage", HBJJOCHGOPH);
			CECJJMKLEAK().SetFloat("OK", Distortion);
			HNICHJCGJOC().SetFloat("#ok", Fade);
			MHBAIEKFBIJ().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1597f, 1279f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MHBAIEKFBIJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JONGNKNLLND()
	{
		SCShader = Shader.Find("RarityImage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 37f)
			{
				HBJJOCHGOPH = 902f;
			}
			OIIDAKBILMI().SetFloat("A", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("_Offsets", Distortion);
			GJHLADDCMFF().SetFloat("Preparing configuration", Fade);
			LPDOGGFOBDH().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 768f, 304f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GHHPOGODBHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material OIIDAKBILMI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideAndDontSave;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HNICHJCGJOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void DKPBBJINKMG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material MJJIEHANFJA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void HOMNAHDDNHJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IDJKNBDKHBD()
	{
		SCShader = Shader.Find("_BorderSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IFIHBNJKEKD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GJAJBMGGPFB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1898f)
			{
				HBJJOCHGOPH = 1536f;
			}
			LPDOGGFOBDH().SetFloat("D-Pad Up", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("HiddenToggle", Distortion);
			IONHGBPGCHK().SetFloat("_TimeX", Fade);
			NBPKMLMCHFN.SetVector("#accuracy", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1916f, 117f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KCDBBPKIFNJ()
	{
	}

	private void MGFFNGEGFDC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BMBIGILMLLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 419f)
			{
				HBJJOCHGOPH = 228f;
			}
			BAGICADFBAB().SetFloat("#no", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("_TimeX", Distortion);
			OIIDAKBILMI().SetFloat("_ScreenResolution", Fade);
			NFKFAAHHLLM().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 63f, 591f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/TV_PlanetMars");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EFJDNLGNACH()
	{
		SCShader = Shader.Find("_DotSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1449f)
			{
				HBJJOCHGOPH = 985f;
			}
			CECJJMKLEAK().SetFloat("/", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("GroupNameText", Distortion);
			CECJJMKLEAK().SetFloat("UseFinalGlassColor", Fade);
			GJHLADDCMFF().SetVector("In Main Menu", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 613f, 59f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AGEJKLMJGDO()
	{
		SCShader = Shader.Find("Joystick1Button9");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PKHPNHBEKHA()
	{
	}

	private void HPNNCNNFMGK()
	{
	}

	[SpecialName]
	private Material LPDOGGFOBDH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void NNCCPEBIAKH()
	{
		SCShader = Shader.Find("challenges.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LKBOEPPBLIF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1962f)
			{
				HBJJOCHGOPH = 1039f;
			}
			CIAFLBFJLEJ().SetFloat("{}", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("misses", Distortion);
			OIIDAKBILMI().SetFloat("Joined room ", Fade);
			LPDOGGFOBDH().SetVector("VisionBlur", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1902f, 337f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CIAFLBFJLEJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 520f)
			{
				HBJJOCHGOPH = 57f;
			}
			CIAFLBFJLEJ().SetFloat(", our prefix is ", HBJJOCHGOPH);
			NFKFAAHHLLM().SetFloat("CameraFilterPack/Vision_Hell_Blood", Distortion);
			GJHLADDCMFF().SetFloat(" ", Fade);
			HHIFMIPPMPF().SetVector("OPEN FILE", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 426f, 567f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material CECJJMKLEAK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void FDNONDCGGCG()
	{
		SCShader = Shader.Find("SAVE");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OHFOLGANOLC()
	{
		SCShader = Shader.Find("Creating awesome maps");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DLBODOFAJGM()
	{
		SCShader = Shader.Find("_SunColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KDMKDEKCELE()
	{
		SCShader = Shader.Find("_FrustumCornersWS");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)102;
		}
		return BJFKDHHMLJH;
	}

	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 456f)
			{
				HBJJOCHGOPH = 1300f;
			}
			MHBAIEKFBIJ().SetFloat("Image", HBJJOCHGOPH);
			GJHLADDCMFF().SetFloat("_ScreenResolution", Distortion);
			OGMEGHKECAH().SetFloat("[PlayerBase] New highscore", Fade);
			CFCPHFMKHII().SetVector("inventory.selected.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 637f, 1906f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material OKJOKHGJHGF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return BJFKDHHMLJH;
	}

	private void COOHIILCOCO()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FDMAEPOHDMK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DIPDEHOOBPG()
	{
		SCShader = Shader.Find("SetSatelliteRadius");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MDNHCLKNCLE()
	{
		SCShader = Shader.Find("CameraFilterPack/3D_Inverse");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material GJHLADDCMFF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void GPNAOAKCMHC()
	{
		SCShader = Shader.Find("menu.selectedplaymode");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material NFKFAAHHLLM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return BJFKDHHMLJH;
	}

	private void NFEDLAOPHML()
	{
	}

	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1808f)
			{
				HBJJOCHGOPH = 1109f;
			}
			GHHPOGODBHB().SetFloat("yyyy-MM-dd HH:mm:ss", HBJJOCHGOPH);
			CIAFLBFJLEJ().SetFloat(".lastCheckpoint.powerupsScore", Distortion);
			GHHPOGODBHB().SetFloat("PS Home", Fade);
			NFKFAAHHLLM().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 66f, 1363f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
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

	private void BMOFEBKGLFI()
	{
		SCShader = Shader.Find("Rock");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EPEGAEGDJAM()
	{
		SCShader = Shader.Find("_SecondTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IFJDKDFLGBG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JHANGPCOCIG()
	{
		SCShader = Shader.Find("settings.shaders");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MBLDJEFBLFL()
	{
	}

	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 169f)
			{
				HBJJOCHGOPH = 1991f;
			}
			CECJJMKLEAK().SetFloat("[RanksSystem] Init", HBJJOCHGOPH);
			HEINDEMCGIK().SetFloat("PlayMusic", Distortion);
			HEINDEMCGIK().SetFloat("-help", Fade);
			OIIDAKBILMI().SetVector("_SecondTex", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1696f, 1339f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ILCFPCIPENO()
	{
		SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HNDNDPECBPL()
	{
	}

	private void OCCGJMPAJIK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FMHOHGEAIEA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material GHHPOGODBHB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)126;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material CFCPHFMKHII()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void NBGIMIDICKE()
	{
		SCShader = Shader.Find("x");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OIBMHPIFAKK()
	{
	}

	private void NKLIHNJCHOG()
	{
	}

	private void FDPOFMCFBMF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Update()
	{
	}

	private void LPMINJJPDCH()
	{
	}

	private void ONPFGCEFMML()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1038f)
			{
				HBJJOCHGOPH = 784f;
			}
			LPDOGGFOBDH().SetFloat("ConfigVersionSlider", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("ERROR: mod directory not found!", Distortion);
			HNICHJCGJOC().SetFloat("88f00bdf0ad61b16b803971ebe071962", Fade);
			GHHPOGODBHB().SetVector("ItemsUploader", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 972f, 1923f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NNPBKKBFDHH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BMIOFJFMCBG()
	{
		SCShader = Shader.Find("CameraFilterPack_Paper1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BLKGOMCPEKI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material CIAFLBFJLEJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1103f)
			{
				HBJJOCHGOPH = 1303f;
			}
			CIAFLBFJLEJ().SetFloat("_FgOverlap", HBJJOCHGOPH);
			OLHDPICFBOF().SetFloat("#close", Distortion);
			HFBJAOFLCJI().SetFloat("_MaxRadiusOrKInPaper", Fade);
			LPDOGGFOBDH().SetVector("CameraFilterPack/Colors_DarkColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1928f, 260f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EKCKJLFFAID()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NDBPCNICGLC()
	{
		SCShader = Shader.Find("STICKLHOR");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material OLHDPICFBOF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 577f)
			{
				HBJJOCHGOPH = 590f;
			}
			MJJIEHANFJA().SetFloat("CameraFilterPack/Blend2Camera_Multiply", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("ControllerRightY", Distortion);
			NFMGLIKNOOC().SetFloat("ShadersToggle", Fade);
			NFMGLIKNOOC().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 920f, 80f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LFAFJKJAEEL()
	{
		SCShader = Shader.Find("_ForceYSwap");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CHOPDIGHJNH()
	{
		SCShader = Shader.Find("inventory.selected.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1513f)
			{
				HBJJOCHGOPH = 1050f;
			}
			GHHPOGODBHB().SetFloat("_EdgeWeight", HBJJOCHGOPH);
			MJJIEHANFJA().SetFloat("[PlayerBase] SetPlayerDistance error: ", Distortion);
			OGMEGHKECAH().SetFloat("CameraFilterPack/Atmosphere_Fog", Fade);
			BAGICADFBAB().SetVector("(\\[ *h1 *\\])", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1387f, 217f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
