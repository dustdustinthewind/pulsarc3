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
			NBPKMLMCHFN.SetFloat("_Value2", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("PossibleMapPointsText", HexaSize);
			KGOLDDBHIFN().SetFloat("\nCreated by Oxy949", center.x);
			IONHGBPGCHK().SetFloat("FindFriends failed to apply the result, as a required value wasn't provided or the friend list length differed from result.", center.y);
			IONHGBPGCHK().SetFloat("#{0:00}{1}{2}", Radius);
			IONHGBPGCHK().SetFloat("MessageText", _BorderSize);
			NBPKMLMCHFN.SetColor("_Blue_R", _BorderColor);
			KGOLDDBHIFN().SetColor("StartButton", _HexaColor);
			IONHGBPGCHK().SetFloat("_ScreenResolution", _AlphaHexa);
			KGOLDDBHIFN().SetFloat("Destroy(targetPhotonView) failed, cause targetPhotonView is null.", _SpotSize);
			KGOLDDBHIFN().SetVector(".lastCheckpoint.playerdistance", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1426f, 1409f));
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
			NBPKMLMCHFN.SetFloat("settings.disablestoryboard", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("VisionBlur", HexaSize);
			IONHGBPGCHK().SetFloat(": ", center.x);
			KGOLDDBHIFN().SetFloat("Left Click", center.y);
			NBPKMLMCHFN.SetFloat("SetEnvSpriteColor", Radius);
			NBPKMLMCHFN.SetFloat("11", _BorderSize);
			KGOLDDBHIFN().SetColor("setAF", _BorderColor);
			KGOLDDBHIFN().SetColor("ConnectToRegion() failed. Can only connect while in state 'Disconnected'. Current state: ", _HexaColor);
			KGOLDDBHIFN().SetFloat("ns.exitgames.com", _AlphaHexa);
			IONHGBPGCHK().SetFloat("]", _SpotSize);
			IONHGBPGCHK().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1444f, 103f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
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
			IONHGBPGCHK().SetFloat("_MainTex", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("CameraFilterPack/Distortion_FishEye", HexaSize);
			NBPKMLMCHFN.SetFloat("#,0.00", center.x);
			IONHGBPGCHK().SetFloat("_FixDistance", center.y);
			IONHGBPGCHK().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", Radius);
			KGOLDDBHIFN().SetFloat("_BorderColor", _BorderSize);
			NBPKMLMCHFN.SetColor("_Blue_C", _BorderColor);
			KGOLDDBHIFN().SetColor("_Value2", _HexaColor);
			NBPKMLMCHFN.SetFloat("_Bloom", _AlphaHexa);
			NBPKMLMCHFN.SetFloat("_Offsets", _SpotSize);
			IONHGBPGCHK().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 354f, 873f));
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
			KGOLDDBHIFN().SetFloat("_Value", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("LeaderboardsButton", HexaSize);
			IONHGBPGCHK().SetFloat("SetScale", center.x);
			NBPKMLMCHFN.SetFloat("Color's hex value #RRGGBBAA", center.y);
			KGOLDDBHIFN().SetFloat("Source Object: ", Radius);
			KGOLDDBHIFN().SetFloat("_Value2", _BorderSize);
			IONHGBPGCHK().SetColor("_Dist", _BorderColor);
			NBPKMLMCHFN.SetColor(" methods \"", _HexaColor);
			KGOLDDBHIFN().SetFloat("id", _AlphaHexa);
			IONHGBPGCHK().SetFloat(" - {0}", _SpotSize);
			NBPKMLMCHFN.SetVector("Object ID. Case-Sensitive", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1678f, 431f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			KGOLDDBHIFN().SetFloat("settings.showHP", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("_Value4", HexaSize);
			IONHGBPGCHK().SetFloat(",", center.x);
			NBPKMLMCHFN.SetFloat("_MainTex2", center.y);
			NBPKMLMCHFN.SetFloat("_FarCorner", Radius);
			KGOLDDBHIFN().SetFloat("request", _BorderSize);
			KGOLDDBHIFN().SetColor("[Steamworks.NET] Could not load [lib]steam_api.dll/so/dylib. It's likely not in the correct location. Refer to the README for more details.\n", _BorderColor);
			NBPKMLMCHFN.SetColor("_Amount", _HexaColor);
			IONHGBPGCHK().SetFloat("yyyy", _AlphaHexa);
			KGOLDDBHIFN().SetFloat("CameraFilterPack_Paper2", _SpotSize);
			IONHGBPGCHK().SetVector(",viewkeys", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1801f, 1761f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
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
