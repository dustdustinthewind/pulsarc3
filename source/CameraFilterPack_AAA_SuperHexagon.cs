// CameraFilterPack_AAA_SuperHexagon
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/AAA/Super Hexagon")]
public class CameraFilterPack_AAA_SuperHexagon : MonoBehaviour
{
	public Shader SCShader;

	[Range(0f, 1f)]
	public float _AlphaHexa = 1f;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0.2f, 10f)]
	public float HexaSize = 2.5f;

	public float _BorderSize = 1f;

	public Color _BorderColor = new Color(0.75f, 0.75f, 1f, 1f);

	public Color _HexaColor = new Color(0f, 0.5f, 1f, 1f);

	public float _SpotSize = 2.5f;

	public Vector2 center = new Vector2(0.5f, 0.5f);

	public float Radius = 0.25f;

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

	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1632f)
			{
				HBJJOCHGOPH = 1703f;
			}
			KGOLDDBHIFN().SetFloat("_Value4", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("PossibleMapPointsText", HexaSize);
			NBPKMLMCHFN.SetFloat("\nCreated by Oxy949", center.x);
			NBPKMLMCHFN.SetFloat("Connected to NameServer.", center.y);
			KGOLDDBHIFN().SetFloat("(master)", Radius);
			IONHGBPGCHK().SetFloat("MessageText", _BorderSize);
			KGOLDDBHIFN().SetColor("_Blue_B", _BorderColor);
			IONHGBPGCHK().SetColor("ready", _HexaColor);
			KGOLDDBHIFN().SetFloat("_ScreenResolution", _AlphaHexa);
			KGOLDDBHIFN().SetFloat("Couldn't call DestroyAll() as only the master client is allowed to call this.", _SpotSize);
			IONHGBPGCHK().SetVector(".", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1426f, 1409f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
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

	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 73f)
			{
				HBJJOCHGOPH = 667f;
			}
			IONHGBPGCHK().SetFloat("SelectorMusicToggle", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("GlassDistortion", HexaSize);
			KGOLDDBHIFN().SetFloat(" not exist", center.x);
			KGOLDDBHIFN().SetFloat("Mouse1", center.y);
			IONHGBPGCHK().SetFloat("SetEnvSpriteColor", Radius);
			KGOLDDBHIFN().SetFloat("2", _BorderSize);
			IONHGBPGCHK().SetColor("Sets the boolean value of the Auto Focus Input Field property.", _BorderColor);
			KGOLDDBHIFN().SetColor("ConnectToRegion: ", _HexaColor);
			NBPKMLMCHFN.SetFloat("ReconnectToMaster() with AuthValues == null is not correct!", _AlphaHexa);
			KGOLDDBHIFN().SetFloat("GetLive", _SpotSize);
			KGOLDDBHIFN().SetVector("_Glitch", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1444f, 103f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 145f)
			{
				HBJJOCHGOPH = 1275f;
			}
			KGOLDDBHIFN().SetFloat("#{0:X2}{1:X2}{2:X2}", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("CameraFilterPack/Distortion_FishEye", HexaSize);
			NBPKMLMCHFN.SetFloat("_EmissionColor", center.x);
			IONHGBPGCHK().SetFloat("_FixDistance", center.y);
			NBPKMLMCHFN.SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", Radius);
			IONHGBPGCHK().SetFloat("_HexaColor", _BorderSize);
			IONHGBPGCHK().SetColor("_ScreenResolution", _BorderColor);
			KGOLDDBHIFN().SetColor("_Value3", _HexaColor);
			KGOLDDBHIFN().SetFloat("_Parameter", _AlphaHexa);
			IONHGBPGCHK().SetFloat("_Offsets", _SpotSize);
			KGOLDDBHIFN().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 354f, 873f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/AAA_Super_Hexagon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material KGOLDDBHIFN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-116);
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
			NBPKMLMCHFN.SetFloat("_Value", HexaSize);
			NBPKMLMCHFN.SetFloat("_PositionX", center.x);
			NBPKMLMCHFN.SetFloat("_PositionY", center.y);
			NBPKMLMCHFN.SetFloat("_Radius", Radius);
			NBPKMLMCHFN.SetFloat("_BorderSize", _BorderSize);
			NBPKMLMCHFN.SetColor("_BorderColor", _BorderColor);
			NBPKMLMCHFN.SetColor("_HexaColor", _HexaColor);
			NBPKMLMCHFN.SetFloat("_AlphaHexa", _AlphaHexa);
			NBPKMLMCHFN.SetFloat("_SpotSize", _SpotSize);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
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

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 617f)
			{
				HBJJOCHGOPH = 1924f;
			}
			NBPKMLMCHFN.SetFloat("_Value", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("LeaderboardsButton", HexaSize);
			IONHGBPGCHK().SetFloat("Set Object Scale", center.x);
			NBPKMLMCHFN.SetFloat("#FFFFFFFF", center.y);
			IONHGBPGCHK().SetFloat("From {0} at Index {1} \n", Radius);
			NBPKMLMCHFN.SetFloat("_Value2", _BorderSize);
			KGOLDDBHIFN().SetColor("_Smooth", _BorderColor);
			KGOLDDBHIFN().SetColor(" argument(s): ", _HexaColor);
			IONHGBPGCHK().SetFloat("id", _AlphaHexa);
			KGOLDDBHIFN().SetFloat("There are {0} reported logs.", _SpotSize);
			IONHGBPGCHK().SetVector("Object ID. Case-Sensitive", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1678f, 431f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
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

	private void FKEJGBFDCAH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 8f)
			{
				HBJJOCHGOPH = 1379f;
			}
			NBPKMLMCHFN.SetFloat("HPText", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("_Value5", HexaSize);
			IONHGBPGCHK().SetFloat("}", center.x);
			KGOLDDBHIFN().SetFloat("CameraFilterPack/Glow_Glow_Color", center.y);
			NBPKMLMCHFN.SetFloat("_Params", Radius);
			NBPKMLMCHFN.SetFloat("#scoresubmitionfailed: ", _BorderSize);
			KGOLDDBHIFN().SetColor("[SteamManager] Connecting to server", _BorderColor);
			KGOLDDBHIFN().SetColor("_MainTex2", _HexaColor);
			KGOLDDBHIFN().SetFloat("Jan", _AlphaHexa);
			IONHGBPGCHK().SetFloat("CameraFilterPack/Drawing_BluePrint", _SpotSize);
			KGOLDDBHIFN().SetVector("cancel", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1801f, 1761f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JHLGHODFJOO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BNEJMABFKJE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}
}
