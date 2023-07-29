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
		SCShader = Shader.Find("Source Object: ");
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
			JIBOKBCPDLC().SetFloat("_Value1", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("CorrectHitsScoreText", Alpha);
			OIMMPLPBLBK().SetFloat("CameraFilterPack_AAA_Blood2", LHFNOLGKGMO);
			NBPKMLMCHFN.SetFloat("SpawnObj", NEJIJAPDALK);
			NBPKMLMCHFN.SetFloat("OpCreateRoom()", CCIENBFIKKH);
			JIBOKBCPDLC().SetVector("Set Object Scale", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1091f, 741f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
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
		SCShader = Shader.Find("restrictions\n\n#until: ");
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
		SCShader = Shader.Find("CameraFilterPack/FX_Plasma");
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
			GCDFNHMJMIP().SetFloat("_Value2", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("SetSunMaxSize", Alpha);
			OIMMPLPBLBK().SetFloat("player.xp", LHFNOLGKGMO);
			JIBOKBCPDLC().SetFloat("Operation failed: ", NEJIJAPDALK);
			OIMMPLPBLBK().SetFloat("_TimeX", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("Malformed RPC; this should never occur. Content: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 701f, 1196f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
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
			OIMMPLPBLBK().SetFloat("Fade", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("513510", Alpha);
			GCDFNHMJMIP().SetFloat("_TreatBackfaceHitAsMiss", LHFNOLGKGMO);
			OIMMPLPBLBK().SetFloat("Text", NEJIJAPDALK);
			KAFBNOBOIAJ().SetFloat("maps.", CCIENBFIKKH);
			KAFBNOBOIAJ().SetVector("ViewMenu", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 485f, 1455f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			JIBOKBCPDLC().SetFloat(".", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("_FixDistance", Alpha);
			NBPKMLMCHFN.SetFloat("offsets", LHFNOLGKGMO);
			JIBOKBCPDLC().SetFloat("CameraFilterPack/3D_BlackHole", NEJIJAPDALK);
			OIMMPLPBLBK().SetFloat("{0} seconds ago", CCIENBFIKKH);
			JIBOKBCPDLC().SetVector("menutheme.hunter", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 519f, 254f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
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
			OIMMPLPBLBK().SetFloat("_Distortion", HBJJOCHGOPH);
			JIBOKBCPDLC().SetFloat("[NetworkManager] Connection failed: ", Alpha);
			JIBOKBCPDLC().SetFloat(" (inactive)", LHFNOLGKGMO);
			NBPKMLMCHFN.SetFloat("player.xp", NEJIJAPDALK);
			GCDFNHMJMIP().SetFloat("_Value2", CCIENBFIKKH);
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
			NBPKMLMCHFN.SetFloat("[PlayerController] ", HBJJOCHGOPH);
			JIBOKBCPDLC().SetFloat("_Curve", Alpha);
			JIBOKBCPDLC().SetFloat("mapselector.filter.favoriteonly", LHFNOLGKGMO);
			OIMMPLPBLBK().SetFloat("Tab2Content", NEJIJAPDALK);
			KAFBNOBOIAJ().SetFloat("_Value5", CCIENBFIKKH);
			KAFBNOBOIAJ().SetVector("[MapEditor] Exported to ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1943f, 663f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
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
		SCShader = Shader.Find("SetSatelliteInput");
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
			NBPKMLMCHFN.SetFloat("Objects in List: ", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", Alpha);
			OIMMPLPBLBK().SetFloat(".", LHFNOLGKGMO);
			GCDFNHMJMIP().SetFloat("SetSunInput", NEJIJAPDALK);
			OIMMPLPBLBK().SetFloat("_ExposureAdjustment", CCIENBFIKKH);
			JIBOKBCPDLC().SetVector("LocalPlayer is null or not in mActors! LocalPlayer: {0} mActors==null: {1} newID: {2}", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 338f, 1792f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
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
