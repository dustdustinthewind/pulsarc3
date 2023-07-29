// CameraFilterPack_FX_EarthQuake
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/FX/Earth Quake")]
public class CameraFilterPack_FX_EarthQuake : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 100f)]
	public float Speed = 15f;

	[Range(0f, 0.2f)]
	public float X = 0.008f;

	[Range(0f, 0.2f)]
	public float Y = 0.008f;

	[Range(0f, 0.2f)]
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

	private void DAHFFNNIGML()
	{
		SCShader = Shader.Find("Encryption wasn't established: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BNEJMABFKJE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 790f)
			{
				HBJJOCHGOPH = 185f;
			}
			OIMMPLPBLBK().SetFloat("masterSteamID", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("workshop.", Speed);
			OIMMPLPBLBK().SetFloat("custom", X);
			OIMMPLPBLBK().SetFloat("[Down]", Y);
			KAFBNOBOIAJ().SetFloat("Player", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector(". Current number of cells is ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1778f, 567f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1250f)
			{
				HBJJOCHGOPH = 761f;
			}
			NBPKMLMCHFN.SetFloat("0.00", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat(" GameServer:", Speed);
			OIMMPLPBLBK().SetFloat("[DiscordController] Join request {0}#{1}: {2}", X);
			NBPKMLMCHFN.SetFloat("workshop.", Y);
			KAFBNOBOIAJ().SetFloat("_Near", CCIENBFIKKH);
			KAFBNOBOIAJ().SetVector("#ok", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 512f, 251f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OFPPIKHNJOD()
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

	[SpecialName]
	private Material OIMMPLPBLBK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)120;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KAFBNOBOIAJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void NKLIHNJCHOG()
	{
	}

	private void KMCPMOGKDEH()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MFMIODIAKNI()
	{
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/FX_EarthQuake");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
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
			NBPKMLMCHFN.SetFloat("_Value", Speed);
			NBPKMLMCHFN.SetFloat("_Value2", X);
			NBPKMLMCHFN.SetFloat("_Value3", Y);
			NBPKMLMCHFN.SetFloat("_Value4", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EAHCLIEEJOG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FABKIGNFECE()
	{
	}

	private void PLIKADJCEPO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DPFOEBCADNP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JOJFHFHOCHO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PAKPHKPDKGE()
	{
		SCShader = Shader.Find("CameraFilterPack/Blend2Camera_LinearLight");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NPLCENPNJBM()
	{
		SCShader = Shader.Find("CheckResources () for ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IMCKJCHKMKB()
	{
		SCShader = Shader.Find("_BlurredColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1375f)
			{
				HBJJOCHGOPH = 1193f;
			}
			KAFBNOBOIAJ().SetFloat("Vertical", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat(". Using max value: 255.", Speed);
			NBPKMLMCHFN.SetFloat("_Heigh", X);
			OIMMPLPBLBK().SetFloat("_Value5", Y);
			NBPKMLMCHFN.SetFloat("_Luminance", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("Identity LUT", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1320f, 1556f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1626f)
			{
				HBJJOCHGOPH = 1599f;
			}
			KAFBNOBOIAJ().SetFloat("Editor/", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("settings.arcsdestroydelay", Speed);
			OIMMPLPBLBK().SetFloat("CameraFilterPack/Blend2Camera_Saturation", X);
			KAFBNOBOIAJ().SetFloat("_Value2", Y);
			KAFBNOBOIAJ().SetFloat("_SpawnHeuristic", CCIENBFIKKH);
			KAFBNOBOIAJ().SetVector("[MapEditor] Item creation successful! Published Item ID: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1193f, 1678f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1741f)
			{
				HBJJOCHGOPH = 1075f;
			}
			OIMMPLPBLBK().SetFloat("_NoisePerChannel", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("Editor/", Speed);
			OIMMPLPBLBK().SetFloat("elapsed: {0:0.000}", X);
			KAFBNOBOIAJ().SetFloat("Other", Y);
			KAFBNOBOIAJ().SetFloat("#", CCIENBFIKKH);
			OIMMPLPBLBK().SetVector("_Value5", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1849f, 928f));
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
			if (HBJJOCHGOPH > 1750f)
			{
				HBJJOCHGOPH = 730f;
			}
			OIMMPLPBLBK().SetFloat("_CameraToWorldMatrix", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("AddEnvironmentObject", Speed);
			OIMMPLPBLBK().SetFloat("Error! no audio sources attached to AudioSampler.css", X);
			NBPKMLMCHFN.SetFloat(". Possible scene loading in progress?", Y);
			OIMMPLPBLBK().SetFloat("MapEnd", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 499f, 1929f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FABMDEHEDNO()
	{
	}

	private void KDMANOEMOCA()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
