// CameraFilterPack_FX_Hexagon_Black
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/FX/Hexagon_Black")]
[ExecuteInEditMode]
public class CameraFilterPack_FX_Hexagon_Black : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0.2f, 10f)]
	public float Value = 1f;

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
	private Material FHFLKLMFHOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return BJFKDHHMLJH;
	}

	private void EGEGNHLODAA()
	{
	}

	private void LCDJFJIBADI()
	{
	}

	[SpecialName]
	private Material EOCCJGIGEGJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-107);
		}
		return BJFKDHHMLJH;
	}

	private void IEMEHGCFAPD()
	{
	}

	[SpecialName]
	private Material FGENHBKMPDA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.HideInHierarchy;
		}
		return BJFKDHHMLJH;
	}

	private void FNCDAPDOBBI()
	{
		SCShader = Shader.Find("PhotonView with ID ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 442f)
			{
				HBJJOCHGOPH = 979f;
			}
			EFDEIFCDAFG().SetFloat("Fade", HBJJOCHGOPH);
			FHFLKLMFHOI().SetFloat("settings.enablehitsoundsinnormal", Value);
			NLFJGMBCICG().SetVector("_Offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1871f, 525f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CNGAJDBOCLJ()
	{
		SCShader = Shader.Find("OnReadyClick");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DFFKKLAPHCC()
	{
		SCShader = Shader.Find("_Radius");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 875f)
			{
				HBJJOCHGOPH = 731f;
			}
			LPCHMEKDCHI().SetFloat(",", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("achievements.21.completed.", Value);
			PHGCJOPFDOG().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 223f, 1748f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-124);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NLFJGMBCICG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)107;
		}
		return BJFKDHHMLJH;
	}

	private void GJLKJAOBPJD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 255f)
			{
				HBJJOCHGOPH = 455f;
			}
			EFDEIFCDAFG().SetFloat("PhotonView ID duplicate found: {0}. New: {1} old: {2}. Maybe one wasn't destroyed on scene load?! Check for 'DontDestroyOnLoad'. Destroying old entry, adding new.", HBJJOCHGOPH);
			FGENHBKMPDA().SetFloat("Joystick1Button1", Value);
			KAFBNOBOIAJ().SetVector("mapselector.filter.officialsortmode", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1122f, 333f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KDMANOEMOCA()
	{
		SCShader = Shader.Find("SetSpeed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1561f)
			{
				HBJJOCHGOPH = 1436f;
			}
			KOHGPKOFEJO().SetFloat("FileLabel", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("Fade", Value);
			PHGCJOPFDOG().SetVector("music.ogg", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1255f, 383f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void POJFHDFJOPE()
	{
	}

	private void IIFCIDDJHPM()
	{
	}

	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 734f)
			{
				HBJJOCHGOPH = 1036f;
			}
			LPCHMEKDCHI().SetFloat("_Value4", HBJJOCHGOPH);
			PHGCJOPFDOG().SetFloat(". Not connectedAndReady.", Value);
			PDEAHJPOMEF().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 650f, 585f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1956f)
			{
				HBJJOCHGOPH = 80f;
			}
			IONHGBPGCHK().SetFloat("GameScene", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_MainTex2", Value);
			IONHGBPGCHK().SetVector("CameraFilterPack/FX_Glitch1", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 185f, 1706f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material NBMPPNFKFLB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 566f)
			{
				HBJJOCHGOPH = 1663f;
			}
			FGENHBKMPDA().SetFloat("open", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("SetPosition", Value);
			NLFJGMBCICG().SetVector(" not exist", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1802f, 1978f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EDBEHEKMGFH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EPEGAEGDJAM()
	{
		SCShader = Shader.Find("offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PBEPCAPAKLG()
	{
	}

	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 235f)
			{
				HBJJOCHGOPH = 802f;
			}
			LONNIJMNKFB().SetFloat("Call ConnectToNameServer to ping available regions.", HBJJOCHGOPH);
			LPCHMEKDCHI().SetFloat("_ScreenResolution", Value);
			NBPKMLMCHFN.SetVector("_Distortion", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1450f, 1341f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FLKEJJEGCFA()
	{
		SCShader = Shader.Find("rarity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KLILJHJNICK()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material PHGCJOPFDOG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 236f)
			{
				HBJJOCHGOPH = 1760f;
			}
			MICHFGAOPKM().SetFloat("Alternative", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat(" not exist", Value);
			FHFLKLMFHOI().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 724f, 666f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DHENLPJJOEN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material MICHFGAOPKM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)117;
		}
		return BJFKDHHMLJH;
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/FX_Hexagon_Black");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1716f)
			{
				HBJJOCHGOPH = 1914f;
			}
			FHFLKLMFHOI().SetFloat("CameraFilterPack_eyes_vision_1", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("PlayButton", Value);
			HCGJCMDJPGD().SetVector(": ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1472f, 1494f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MICHFGAOPKM());
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

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AEIJFLJEABG()
	{
	}

	[SpecialName]
	private Material LPCHMEKDCHI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1866f)
			{
				HBJJOCHGOPH = 772f;
			}
			IONHGBPGCHK().SetFloat("DPADVER", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("MenuScene", Value);
			MICHFGAOPKM().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 224f, 535f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LBAJLLFMMMP()
	{
		SCShader = Shader.Find("_LightIntensity");
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
			NBPKMLMCHFN.SetFloat("_Value", Value);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PKLOBJHKFEO()
	{
		SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HLLHJIDOOGA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 865f)
			{
				HBJJOCHGOPH = 247f;
			}
			KOHGPKOFEJO().SetFloat("CameraFilterPack/Antialiasing_FXAA", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", Value);
			PDEAHJPOMEF().SetVector("_UV_Transform", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1119f, 903f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LGHCJCFHEMF()
	{
		SCShader = Shader.Find("id");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 73f)
			{
				HBJJOCHGOPH = 1146f;
			}
			GKILCDHJFEG().SetFloat("Validating mod pack...", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("1.87", Value);
			EOCCJGIGEGJ().SetVector("View ({3}){0} on {1} {2}", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 766f, 515f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material EFDEIFCDAFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void DOEPOGLEGLE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material KOHGPKOFEJO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
		}
		return BJFKDHHMLJH;
	}

	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 76f)
			{
				HBJJOCHGOPH = 97f;
			}
			NLFJGMBCICG().SetFloat("move", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("_Value", Value);
			NLFJGMBCICG().SetVector("_SpherePositionY", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1231f, 727f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DDBOODLPCAM()
	{
	}

	private void NNCCPEBIAKH()
	{
		SCShader = Shader.Find("_Value5");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DLMPALHKMON()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1872f)
			{
				HBJJOCHGOPH = 550f;
			}
			PHGCJOPFDOG().SetFloat("_Blend", HBJJOCHGOPH);
			FGENHBKMPDA().SetFloat("colorD", Value);
			FHFLKLMFHOI().SetVector("[PlayerBase] Loaded environment: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1820f, 1754f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MPJCMKFFKHH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1848f)
			{
				HBJJOCHGOPH = 59f;
			}
			LONNIJMNKFB().SetFloat("menu.selectedlevelid", HBJJOCHGOPH);
			PHGCJOPFDOG().SetFloat("settings.disablestoryboard", Value);
			LPCHMEKDCHI().SetVector("_SSAO", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1204f, 1046f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PAEGLMEOKHP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 356f)
			{
				HBJJOCHGOPH = 356f;
			}
			FGENHBKMPDA().SetFloat("https://bitbucket.org/khb-soft/intralismarcsviewer/", HBJJOCHGOPH);
			HHIAIGCAHDA().SetFloat("quit", Value);
			GKILCDHJFEG().SetVector("_Green_C", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1234f, 835f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LMADKINICIN()
	{
	}

	private void OCCGJMPAJIK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AEOLJEIDMDB()
	{
		SCShader = Shader.Find("https://vk.com/khb.soft");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 882f)
			{
				HBJJOCHGOPH = 183f;
			}
			FGENHBKMPDA().SetFloat(" scene view IDs from last level.", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("#accuracy", Value);
			PHGCJOPFDOG().SetVector("BlockCount", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 407f, 1916f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BGFJOEPFOPM()
	{
	}

	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1939f)
			{
				HBJJOCHGOPH = 1585f;
			}
			LPCHMEKDCHI().SetFloat("Connection error: ", HBJJOCHGOPH);
			FHFLKLMFHOI().SetFloat("Using PhotonServerSettings.Protocol when leaving the NameServer (AuthMode is AuthOnceWss): ", Value);
			MICHFGAOPKM().SetVector("ZoomFade", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 632f, 1510f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
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
			if (HBJJOCHGOPH > 85f)
			{
				HBJJOCHGOPH = 224f;
			}
			FHFLKLMFHOI().SetFloat("LevelURLInputField", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat(" not exist", Value);
			HHIAIGCAHDA().SetVector("<i>", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 142f, 225f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MFMIODIAKNI()
	{
	}

	private void HIKKPDACJGI()
	{
	}

	[SpecialName]
	private Material HHIAIGCAHDA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material GKILCDHJFEG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-1);
		}
		return BJFKDHHMLJH;
	}

	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 124f)
			{
				HBJJOCHGOPH = 256f;
			}
			PDEAHJPOMEF().SetFloat("[MapEditor] Created new map: ", HBJJOCHGOPH);
			PHGCJOPFDOG().SetFloat("GameObject ", Value);
			NBPKMLMCHFN.SetVector("ShowTitle", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1538f, 115f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIAIGCAHDA());
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
			if (HBJJOCHGOPH > 1574f)
			{
				HBJJOCHGOPH = 1875f;
			}
			KAFBNOBOIAJ().SetFloat("{0:0}", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("Committing changes...", Value);
			MICHFGAOPKM().SetVector("player", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1623f, 357f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LONNIJMNKFB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-72);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-81);
		}
		return BJFKDHHMLJH;
	}

	private void KMEONPMCNJG()
	{
	}

	private void LCHBFNIPBHB()
	{
	}

	private void FMFNILJIEIA()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CCLNNLCOPBL()
	{
		SCShader = Shader.Find("[PlayerController] ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material KAFBNOBOIAJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void JNBPKNNBMDI()
	{
	}

	private void DNENFLNCIJP()
	{
	}

	private void CBIBDOIBJAI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FPHLDMMAOEF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Update()
	{
	}

	private void MKFLBEGJJDC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HCGJCMDJPGD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-90);
		}
		return BJFKDHHMLJH;
	}

	private void HJPCJGOEKMF()
	{
		SCShader = Shader.Find(" not exist");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JKBMKPDGCHG()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EDCMIPNCPLB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 435f)
			{
				HBJJOCHGOPH = 1904f;
			}
			FGENHBKMPDA().SetFloat("Connected to gameserver.", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("_Value4", Value);
			HCGJCMDJPGD().SetVector("player.xp", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 82f, 653f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MJNPIDGNJMK()
	{
	}

	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1830f)
			{
				HBJJOCHGOPH = 790f;
			}
			KOHGPKOFEJO().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			HHIAIGCAHDA().SetFloat("[PlayerController] ", Value);
			HCGJCMDJPGD().SetVector("_Green_B", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1331f, 1570f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LEAHIBJDMBI()
	{
	}

	private void GPNAOAKCMHC()
	{
		SCShader = Shader.Find("CrosshairOpacitySlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MGMAOBPPOBJ()
	{
		SCShader = Shader.Find("RarityImage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1411f)
			{
				HBJJOCHGOPH = 795f;
			}
			KOHGPKOFEJO().SetFloat("Joystick1Button12", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("menu.selectedlevelid", Value);
			LONNIJMNKFB().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 774f, 1257f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HDDECCMEJKA()
	{
	}

	private void ICILLMAKLMI()
	{
		SCShader = Shader.Find("#close");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
