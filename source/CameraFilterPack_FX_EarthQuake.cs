// CameraFilterPack_FX_EarthQuake
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/FX/Earth Quake")]
[ExecuteInEditMode]
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
		SCShader = Shader.Find("Skipping EstablishEncryption. Protocol is secure.");
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
			NBPKMLMCHFN.SetFloat("masterSteamID", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("workshop.", Speed);
			OIMMPLPBLBK().SetFloat("UI", X);
			NBPKMLMCHFN.SetFloat("Gameplay/sprite", Y);
			OIMMPLPBLBK().SetFloat("UpdateNewsTileStart", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("OnJoinedRoom() called by PUN. Now this client is in a room. From here on, your game would be running. For reference, all callbacks are listed in enum: PhotonNetworkingMessage", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1778f, 567f));
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
			KAFBNOBOIAJ().SetFloat("0.00", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat(" GameServer:", Speed);
			KAFBNOBOIAJ().SetFloat("[DiscordController] Sectate ({0})", X);
			OIMMPLPBLBK().SetFloat("[SERVER] Selected mode: ", Y);
			NBPKMLMCHFN.SetFloat("_Near", CCIENBFIKKH);
			OIMMPLPBLBK().SetVector("[LevelEditorScene] Map submitted!", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 512f, 251f));
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
		SCShader = Shader.Find("_Smooth");
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
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NPLCENPNJBM()
	{
		SCShader = Shader.Find("Missing shader in ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IMCKJCHKMKB()
	{
		SCShader = Shader.Find("_Offsets");
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
			NBPKMLMCHFN.SetFloat("Aimer Input Module is incompatible with the StandAloneInputSystem, please remove it from the Event System in this scene or disable it when this module is in use", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Can't set MaxPlayers when not in that room.", Speed);
			OIMMPLPBLBK().SetFloat("_Heigh", X);
			NBPKMLMCHFN.SetFloat("_Value5", Y);
			KAFBNOBOIAJ().SetFloat("_AxialAberration", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("Tonemapper curve texture", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1320f, 1556f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
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
			NBPKMLMCHFN.SetFloat("[MapEditor] Created new map: ", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("settings.gamemessagesduration", Speed);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", X);
			NBPKMLMCHFN.SetFloat("_Value2", Y);
			KAFBNOBOIAJ().SetFloat("_Offsets", CCIENBFIKKH);
			KAFBNOBOIAJ().SetVector("Created", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1193f, 1678f));
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
			OIMMPLPBLBK().SetFloat("_DX11NoiseTime", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("/", Speed);
			OIMMPLPBLBK().SetFloat("st", X);
			KAFBNOBOIAJ().SetFloat("Soundtrack", Y);
			OIMMPLPBLBK().SetFloat(">", CCIENBFIKKH);
			KAFBNOBOIAJ().SetVector("_Value4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1849f, 928f));
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
			if (HBJJOCHGOPH > 1750f)
			{
				HBJJOCHGOPH = 730f;
			}
			OIMMPLPBLBK().SetFloat("_ProjectToPixelMatrix", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("AddEnvironmentObject", Speed);
			KAFBNOBOIAJ().SetFloat("Error! no audio sources attached to AudioSampler.css", X);
			KAFBNOBOIAJ().SetFloat("RPCs can only be sent in rooms. Call of \"", Y);
			OIMMPLPBLBK().SetFloat("menu.playedsolo", CCIENBFIKKH);
			KAFBNOBOIAJ().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 499f, 1929f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
