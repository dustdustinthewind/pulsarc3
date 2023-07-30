// CameraFilterPack_Colors_DarkColor
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Colors/DarkColor")]
[ExecuteInEditMode]
public class CameraFilterPack_Colors_DarkColor : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(-5f, 5f)]
	public float Alpha = 1f;

	[Range(0f, 16f)]
	private float LHFNOLGKGMO = 11f;

	[Range(-1f, 1f)]
	private float NEJIJAPDALK = 1f;

	[Range(0f, 10f)]
	private float CCIENBFIKKH = 1f;

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

	private void LADCJEIALMH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NAOLAJPDGIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JNGMIAFLBDL()
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-108);
		}
		return BJFKDHHMLJH;
	}

	private void NBGIMIDICKE()
	{
		SCShader = Shader.Find("Is Clone ?: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MMMDPANNAIO()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JOJFHFHOCHO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Update()
	{
	}

	private void LOMDIOLNFHI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1782f)
			{
				HBJJOCHGOPH = 1558f;
			}
			OIMMPLPBLBK().SetFloat("_Amount", HBJJOCHGOPH);
			JIBOKBCPDLC().SetFloat("PerfectHitsScoreText", Alpha);
			GCDFNHMJMIP().SetFloat("CameraFilterPack_AAA_Blood2", LHFNOLGKGMO);
			GCDFNHMJMIP().SetFloat("[Right]", NEJIJAPDALK);
			KAFBNOBOIAJ().SetFloat("OpJoinLobby()", CCIENBFIKKH);
			OIMMPLPBLBK().SetVector("SetScale", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1091f, 741f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FKEJGBFDCAH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DOEPOGLEGLE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EGEPLFGKGLI()
	{
		SCShader = Shader.Find("#forever");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FDPOFMCFBMF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DAHFFNNIGML()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JAAJECBCCFM()
	{
	}

	private void LEAHIBJDMBI()
	{
	}

	private void JKFDDNMPOJH()
	{
		SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LCJHDLKJEOM()
	{
	}

	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 885f)
			{
				HBJJOCHGOPH = 1461f;
			}
			OIMMPLPBLBK().SetFloat("_Value", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Set sun min/max size", Alpha);
			KAFBNOBOIAJ().SetFloat("player.xp", LHFNOLGKGMO);
			GCDFNHMJMIP().SetFloat(" could not be executed (yet). Wait for state JoinedLobby or ConnectedToMaster and their callbacks before calling operations. WebRPCs need a server-side configuration. Enum OperationCode helps identify the operation.", NEJIJAPDALK);
			GCDFNHMJMIP().SetFloat("_TimeX", CCIENBFIKKH);
			OIMMPLPBLBK().SetVector(", our prefix is ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 701f, 1196f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CBIBDOIBJAI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material KAFBNOBOIAJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)87;
		}
		return BJFKDHHMLJH;
	}

	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1122f)
			{
				HBJJOCHGOPH = 932f;
			}
			NBPKMLMCHFN.SetFloat("CameraFilterPack/TV_Posterize", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("key", Alpha);
			NBPKMLMCHFN.SetFloat("_AdditiveReflection", LHFNOLGKGMO);
			OIMMPLPBLBK().SetFloat("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception", NEJIJAPDALK);
			KAFBNOBOIAJ().SetFloat("maps.", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("ViewMenu", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 485f, 1455f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AGMJDGHLBMN()
	{
	}

	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 917f)
			{
				HBJJOCHGOPH = 382f;
			}
			GCDFNHMJMIP().SetFloat(".lastCheckpoint.playerdistance", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("_FixDistance", Alpha);
			GCDFNHMJMIP().SetFloat("_TapLowForeground", LHFNOLGKGMO);
			JIBOKBCPDLC().SetFloat("CameraFilterPack/3D_BlackHole", NEJIJAPDALK);
			JIBOKBCPDLC().SetFloat("{0} seconds ago", CCIENBFIKKH);
			JIBOKBCPDLC().SetVector("menutheme.hunter", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 519f, 254f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			if (HBJJOCHGOPH > 1057f)
			{
				HBJJOCHGOPH = 671f;
			}
			OIMMPLPBLBK().SetFloat("Fade", HBJJOCHGOPH);
			GCDFNHMJMIP().SetFloat("[NetworkManager] Connection failed: ", Alpha);
			OIMMPLPBLBK().SetFloat(" ", LHFNOLGKGMO);
			OIMMPLPBLBK().SetFloat("player.xp", NEJIJAPDALK);
			OIMMPLPBLBK().SetFloat("_Value", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("mapselector.filter.favoriteonly", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1131f, 1865f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FABKIGNFECE()
	{
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Colors_DarkColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MMBPLGGLPDB()
	{
	}

	[SpecialName]
	private Material JIBOKBCPDLC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-87);
		}
		return BJFKDHHMLJH;
	}

	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 431f)
			{
				HBJJOCHGOPH = 1292f;
			}
			GCDFNHMJMIP().SetFloat(" not exist", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("Hidden/Image Effects/Cinematic/Bloom", Alpha);
			KAFBNOBOIAJ().SetFloat("mapselector.filter.favoriteonly", LHFNOLGKGMO);
			OIMMPLPBLBK().SetFloat("Tab2Content", NEJIJAPDALK);
			OIMMPLPBLBK().SetFloat("_Value5", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("#ok", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1943f, 663f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)85;
		}
		return BJFKDHHMLJH;
	}

	private void EDBEHEKMGFH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KMCPMOGKDEH()
	{
		SCShader = Shader.Find("SetSatelliteColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 210f)
			{
				HBJJOCHGOPH = 667f;
			}
			OIMMPLPBLBK().SetFloat("ping: {6}[+/-{7}]ms resent:{8} \n\nmax ms between\nsend: {0,4} \ndispatch: {1,4} \n\nlongest dispatch for: \nev({3}):{2,3}ms \nop({5}):{4,3}ms", HBJJOCHGOPH);
			GCDFNHMJMIP().SetFloat("Vertical", Alpha);
			NBPKMLMCHFN.SetFloat(".lastCheckpoint.playerdistance", LHFNOLGKGMO);
			GCDFNHMJMIP().SetFloat("SetSunInput", NEJIJAPDALK);
			KAFBNOBOIAJ().SetFloat("_Curve", CCIENBFIKKH);
			GCDFNHMJMIP().SetVector("Can't execute Disconnect() while not connected. Nothing changed. State: {0}", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 338f, 1792f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
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
			NBPKMLMCHFN.SetFloat("_Value", Alpha);
			NBPKMLMCHFN.SetFloat("_Value2", LHFNOLGKGMO);
			NBPKMLMCHFN.SetFloat("_Value3", NEJIJAPDALK);
			NBPKMLMCHFN.SetFloat("_Value4", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
