// CameraFilterPack_Oculus_NightVision3
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Night Vision/Night Vision 3")]
[ExecuteInEditMode]
public class CameraFilterPack_Oculus_NightVision3 : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0.2f, 2f)]
	public float Greenness = 1f;

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

	private void KFACDBHDAOD()
	{
	}

	private void EHCGBJDFMHG()
	{
	}

	private void PMPKMGKAAJH()
	{
		SCShader = Shader.Find("ItemTemplate");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HONBLGFDMLL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EDBEHEKMGFH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HLDFOJMHKNL()
	{
	}

	[SpecialName]
	private Material CECJJMKLEAK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void AKHCOBHHGJP()
	{
		SCShader = Shader.Find("HandsCountSlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
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
			NBPKMLMCHFN.SetFloat("_Greenness", Greenness);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IGPCNCJIEOJ()
	{
		SCShader = Shader.Find("SpawnObj");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FHPFJBFCOOF()
	{
		SCShader = Shader.Find("Set sun beat detection sensitivity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material MFHPKGICPIO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)75;
		}
		return BJFKDHHMLJH;
	}

	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1745f)
			{
				HBJJOCHGOPH = 457f;
			}
			BLMPMOIDGMG().SetFloat(".sawoutdatedmessage", HBJJOCHGOPH);
			LPMLLJKMAMP().SetFloat("_ProjInfo", Greenness);
			OCHJIMJNEMO().SetVector(": ", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1866f)
			{
				HBJJOCHGOPH = 1436f;
			}
			PGPEMMBJOOG().SetFloat("http", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("_Value5", Greenness);
			DKNJGHFLAIF().SetVector("Alpha", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BGDPIHMAACO()
	{
		SCShader = Shader.Find("Mouse");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1000f)
			{
				HBJJOCHGOPH = 1182f;
			}
			BLMPMOIDGMG().SetFloat("float,0", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("_ZCurve", Greenness);
			MFHPKGICPIO().SetVector("_TimeX", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MKOMIDCPCDC()
	{
		SCShader = Shader.Find("_TimeX");
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
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)126;
		}
		return BJFKDHHMLJH;
	}

	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 217f)
			{
				HBJJOCHGOPH = 1978f;
			}
			CEKJODEAMGB().SetFloat("%]</b> ", HBJJOCHGOPH);
			LPMLLJKMAMP().SetFloat("0", Greenness);
			HFBJAOFLCJI().SetVector("ItemsCountText", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LEAHIBJDMBI()
	{
	}

	[SpecialName]
	private Material GHHPOGODBHB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideAndDontSave | HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void KCDOMIJBFLL()
	{
	}

	[SpecialName]
	private Material OIIDAKBILMI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-110);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material LPPEPKGFOEM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 276f)
			{
				HBJJOCHGOPH = 741f;
			}
			EOCCJGIGEGJ().SetFloat("_Jitter", HBJJOCHGOPH);
			BAGICADFBAB().SetFloat("original.tutorial", Greenness);
			BAGICADFBAB().SetVector("ControllerLeftX", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPPEPKGFOEM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 72f)
			{
				HBJJOCHGOPH = 1012f;
			}
			OCHJIMJNEMO().SetFloat("The directory was created successfully at ", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat(".a", Greenness);
			NLFJGMBCICG().SetVector("#tryagain", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FDPOFMCFBMF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GBGAMCPNBCC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DHNGNHGDPLM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LFBGJIIECLD()
	{
		SCShader = Shader.Find("_Value6");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ONMGIPAILOH()
	{
	}

	private void MFLBEJHMEMO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LAMEHAHJKMI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PKLOBJHKFEO()
	{
		SCShader = Shader.Find("masterSteamID");
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

	private void LBPCODPOJAH()
	{
	}

	private void LKJMIODJGCM()
	{
	}

	private void CNGAJDBOCLJ()
	{
		SCShader = Shader.Find("_AlphaMask");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KLILJHJNICK()
	{
		SCShader = Shader.Find("[SaveSystem] Outdated savefile found");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ODBNMPGBCGO()
	{
		SCShader = Shader.Find("SpawnObj");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OMIHEBMMCPG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1597f)
			{
				HBJJOCHGOPH = 1803f;
			}
			BAGICADFBAB().SetFloat("OnPressRight", HBJJOCHGOPH);
			MLMKCOINOOH().SetFloat("_ScreenResolution", Greenness);
			MLMKCOINOOH().SetVector("ENABLE_COLOR_GRADING", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LJIHHJOAJCN()
	{
	}

	[SpecialName]
	private Material BAGICADFBAB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)114;
		}
		return BJFKDHHMLJH;
	}

	private void JCGMGLMADEN()
	{
	}

	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1404f)
			{
				HBJJOCHGOPH = 1057f;
			}
			NLFJGMBCICG().SetFloat("CameraFilterPack/Pixelisation_Sweater", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("CreateRoom failed, client stays on masterserver: {0}.", Greenness);
			MLMKCOINOOH().SetVector("_Bullet_5", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FNCDAPDOBBI()
	{
		SCShader = Shader.Find("logc");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material PGPEMMBJOOG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	private void KDJEJBBDILE()
	{
	}

	private void GOANCMNGDLE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1721f)
			{
				HBJJOCHGOPH = 1690f;
			}
			BBIMPFGLDCP().SetFloat("w", HBJJOCHGOPH);
			CECJJMKLEAK().SetFloat("_DepthLevel", Greenness);
			LNLKMDPHDCC().SetVector(" ", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GOIMKCCICFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1637f)
			{
				HBJJOCHGOPH = 507f;
			}
			LNLKMDPHDCC().SetFloat("_Bullet_9", HBJJOCHGOPH);
			NFKFAAHHLLM().SetFloat("offsets", Greenness);
			NJDIODJNGGA().SetVector("LoadingStatusText", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
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
			if (HBJJOCHGOPH > 876f)
			{
				HBJJOCHGOPH = 187f;
			}
			HFBJAOFLCJI().SetFloat("RarityImage", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("0 - background, 1 - foreground", Greenness);
			CEKJODEAMGB().SetVector("x", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CEKJODEAMGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
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

	private void KIEJKBNBHMD()
	{
	}

	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1452f)
			{
				HBJJOCHGOPH = 436f;
			}
			NFKFAAHHLLM().SetFloat("DifficultyBG", HBJJOCHGOPH);
			BBIMPFGLDCP().SetFloat("/theme", Greenness);
			BAGICADFBAB().SetVector("data", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GHHPOGODBHB());
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
			if (HBJJOCHGOPH > 641f)
			{
				HBJJOCHGOPH = 1060f;
			}
			EOCCJGIGEGJ().SetFloat("_FarCamera", HBJJOCHGOPH);
			MLMKCOINOOH().SetFloat("mapselector.filter.favoriteonly", Greenness);
			NFKFAAHHLLM().SetVector("Saved Game: ", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material ABHDNGIHBKE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)66;
		}
		return BJFKDHHMLJH;
	}

	private void PNLKFANNOKO()
	{
	}

	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 235f)
			{
				HBJJOCHGOPH = 1738f;
			}
			PDEAHJPOMEF().SetFloat("_Value7", HBJJOCHGOPH);
			OCHJIMJNEMO().SetFloat("Please specify either t or f.", Greenness);
			NJDIODJNGGA().SetVector("Brightness", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CECJJMKLEAK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material BBIMPFGLDCP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)67;
		}
		return BJFKDHHMLJH;
	}

	private void OCMKCBBCEFG()
	{
	}

	private void AOKOLPEGHDD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MPJCMKFFKHH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 646f)
			{
				HBJJOCHGOPH = 1307f;
			}
			BLMPMOIDGMG().SetFloat("EventMenu", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("/", Greenness);
			OCHJIMJNEMO().SetVector("[SteamManager] Connection established, authorization", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MLMKCOINOOH());
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
	private Material NFKFAAHHLLM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material LPMLLJKMAMP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-102);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material MICHFGAOPKM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-80);
		}
		return BJFKDHHMLJH;
	}

	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1750f)
			{
				HBJJOCHGOPH = 1703f;
			}
			GHHPOGODBHB().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			NJDIODJNGGA().SetFloat("OnRelease", Greenness);
			GHHPOGODBHB().SetVector("restrictions", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 162f)
			{
				HBJJOCHGOPH = 1481f;
			}
			BLMPMOIDGMG().SetFloat("Winter2020", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("_TimeX", Greenness);
			MICHFGAOPKM().SetVector("Fade", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FDMAEPOHDMK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material EOCCJGIGEGJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void IMGGCJICLHK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material DKNJGHFLAIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void KIMMMCJFMAB()
	{
		SCShader = Shader.Find("1.87");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material HFBJAOFLCJI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-128);
		}
		return BJFKDHHMLJH;
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Oculus_NightVision3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BMOFEBKGLFI()
	{
		SCShader = Shader.Find("achievements.21.progress");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material CEKJODEAMGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.HideInHierarchy;
		}
		return BJFKDHHMLJH;
	}

	private void LBAJLLFMMMP()
	{
		SCShader = Shader.Find(" cannot be used as a 3D LUT.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material LNLKMDPHDCC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void HEBOIFKBLGD()
	{
	}

	private void CGBHOELMAOC()
	{
	}

	[SpecialName]
	private Material NJDIODJNGGA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-80);
		}
		return BJFKDHHMLJH;
	}

	private void ALMGMOOHLMA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EIMNPCMHJLJ()
	{
		SCShader = Shader.Find("SetPlayerDistance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material GKILCDHJFEG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void IBPAMDEAGJL()
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
			if (HBJJOCHGOPH > 1102f)
			{
				HBJJOCHGOPH = 1316f;
			}
			MICHFGAOPKM().SetFloat("_Value", HBJJOCHGOPH);
			OIIDAKBILMI().SetFloat("CameraFilterPack/Blend2Camera_LighterColor", Greenness);
			LPMLLJKMAMP().SetVector("offsets", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BLMPMOIDGMG());
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

	private void ECBILENEOOL()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1722f)
			{
				HBJJOCHGOPH = 1653f;
			}
			MFHPKGICPIO().SetFloat("_MainTex2", HBJJOCHGOPH);
			OCHJIMJNEMO().SetFloat("_ScreenResolution", Greenness);
			MICHFGAOPKM().SetVector("settings.disablestoryboard", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IEMEHGCFAPD()
	{
	}

	private void LKBOEPPBLIF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1026f)
			{
				HBJJOCHGOPH = 220f;
			}
			OCHJIMJNEMO().SetFloat("<color=#", HBJJOCHGOPH);
			BBIMPFGLDCP().SetFloat("menu.relaxinfo", Greenness);
			KEMAALEODNH().SetVector("CameraFilterPack/FX_Funk", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HIKKPDACJGI()
	{
	}

	private void JBNPEHMDCMI()
	{
	}

	private void ICILLMAKLMI()
	{
		SCShader = Shader.Find("CameraFilterPack/Noise_TV_2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 989f)
			{
				HBJJOCHGOPH = 1003f;
			}
			NFKFAAHHLLM().SetFloat("_Value4", HBJJOCHGOPH);
			GHHPOGODBHB().SetFloat("Failed to InstantiateSceneObject prefab:", Greenness);
			PGPEMMBJOOG().SetVector("x", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GNMGIHFKJIJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NDBPCNICGLC()
	{
		SCShader = Shader.Find("_PositionX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 814f)
			{
				HBJJOCHGOPH = 1867f;
			}
			DKNJGHFLAIF().SetFloat("Vertical", HBJJOCHGOPH);
			OIIDAKBILMI().SetFloat("_Value2", Greenness);
			EOCCJGIGEGJ().SetVector("time: ", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
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

	private void EDCMIPNCPLB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material KEMAALEODNH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-78);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material MLMKCOINOOH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-81);
		}
		return BJFKDHHMLJH;
	}

	private void BGFJOEPFOPM()
	{
	}

	[SpecialName]
	private Material BLMPMOIDGMG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)87;
		}
		return BJFKDHHMLJH;
	}

	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 629f)
			{
				HBJJOCHGOPH = 29f;
			}
			CECJJMKLEAK().SetFloat("w", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("AccuracyScoreText", Greenness);
			BLMPMOIDGMG().SetVector(".lastCheckpoint.lives", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LBIOIEANMGI()
	{
	}

	private void PNNPDMHLFHE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EGEGNHLODAA()
	{
	}

	private void BMODOIJGIOO()
	{
	}

	private void KCDBBPKIFNJ()
	{
	}

	private void ANCKKLFPGDI()
	{
		SCShader = Shader.Find("settings.showHP");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CCPEDDLAMIB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PBEPCAPAKLG()
	{
	}

	[SpecialName]
	private Material DBOLLHHMKKN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-108);
		}
		return BJFKDHHMLJH;
	}

	private void DHENLPJJOEN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material NLFJGMBCICG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-88);
		}
		return BJFKDHHMLJH;
	}

	private void Update()
	{
	}
}
