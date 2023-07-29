// CameraFilterPack_Glow_Glow_Color
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Glow/Glow_Color")]
[ExecuteInEditMode]
public class CameraFilterPack_Glow_Glow_Color : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 20f)]
	public float Amount = 4f;

	[Range(2f, 16f)]
	public int FastFilter = 4;

	[Range(0f, 1f)]
	public float Threshold = 0.5f;

	[Range(0f, 3f)]
	public float Intensity = 2.25f;

	[Range(-1f, 1f)]
	public float Precision = 0.56f;

	public Color GlowColor = new Color(0f, 0.7f, 1f, 1f);

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

	private void DLMPALHKMON()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BEBNOKFLJPH()
	{
		SCShader = Shader.Find("<b>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1357f)
			{
				HBJJOCHGOPH = 723f;
			}
			NFMGLIKNOOC().SetFloat("_TimeX", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("ns.exitgames.com", Amount);
			NFMGLIKNOOC().SetFloat(": ", Threshold);
			NBPKMLMCHFN.SetFloat("BloodAlternative3", Intensity);
			NBPKMLMCHFN.SetFloat(".lastCheckpoint.time", Precision);
			NFMGLIKNOOC().SetColor("menu.playedpage", GlowColor);
			NFMGLIKNOOC().SetVector("CameraFilterPack/Color_GrayScale", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)6;
				Graphics.Blit(AAACLELCPML, temporary, NBPKMLMCHFN, 1);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 3);
				Graphics.Blit(temporary2, temporary, NFMGLIKNOOC(), 1);
				NBPKMLMCHFN.SetFloat("float,0", Amount * 288f);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 3);
				Graphics.Blit(temporary2, temporary, NFMGLIKNOOC(), 1);
				NBPKMLMCHFN.SetTexture("_LightIntensity", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC(), 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN, 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BFEILOMHNPC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1970f)
			{
				HBJJOCHGOPH = 875f;
			}
			NBPKMLMCHFN.SetFloat("float,0", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("bool", Amount);
			NFMGLIKNOOC().SetFloat("GlassDistortion", Threshold);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", Intensity);
			NFMGLIKNOOC().SetFloat(").png", Precision);
			NBPKMLMCHFN.SetColor("RPCs can only be sent in rooms. Call of \"", GlowColor);
			NBPKMLMCHFN.SetVector("settings.volume.sfx", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(AAACLELCPML, temporary, NFMGLIKNOOC(), 2);
				Graphics.Blit(temporary, temporary2, NFMGLIKNOOC(), 3);
				Graphics.Blit(temporary2, temporary, NFMGLIKNOOC(), 0);
				NFMGLIKNOOC().SetFloat("x", Amount * 1469f);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 7);
				Graphics.Blit(temporary2, temporary, NBPKMLMCHFN, 0);
				NFMGLIKNOOC().SetTexture("CameraFilterPack_TV_Vignetting1", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN, 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC(), 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NBGIMIDICKE()
	{
		SCShader = Shader.Find("Coroutine container not configured... did you forget to call Init?");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BGDPIHMAACO()
	{
		SCShader = Shader.Find("LevelNameInputField");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Glow_Glow_Color");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ICDBMJKMIKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CNGAJDBOCLJ()
	{
		SCShader = Shader.Find("#failed!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MFMIODIAKNI()
	{
	}

	private void HNILMGEKDEC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 100f)
			{
				HBJJOCHGOPH = 0f;
			}
			NBPKMLMCHFN.SetFloat("_TimeX", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Amount", Amount);
			NBPKMLMCHFN.SetFloat("_Value1", Threshold);
			NBPKMLMCHFN.SetFloat("_Value2", Intensity);
			NBPKMLMCHFN.SetFloat("_Value3", Precision);
			NBPKMLMCHFN.SetColor("_GlowColor", GlowColor);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = FilterMode.Trilinear;
				Graphics.Blit(AAACLELCPML, temporary, NBPKMLMCHFN, 3);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 2);
				Graphics.Blit(temporary2, temporary, NBPKMLMCHFN, 0);
				NBPKMLMCHFN.SetFloat("_Amount", Amount * 2f);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 2);
				Graphics.Blit(temporary2, temporary, NBPKMLMCHFN, 0);
				NBPKMLMCHFN.SetTexture("_MainTex2", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN, 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN, 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IDIIELPAMCJ()
	{
	}

	private void Update()
	{
	}

	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1374f)
			{
				HBJJOCHGOPH = 1292f;
			}
			NFMGLIKNOOC().SetFloat("EventMenu", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("elapsed: {0:0.000}", Amount);
			NFMGLIKNOOC().SetFloat("settings_bindings_", Threshold);
			NBPKMLMCHFN.SetFloat("Please specify a map name or buildID", Intensity);
			NBPKMLMCHFN.SetFloat("Parent ID", Precision);
			NBPKMLMCHFN.SetColor("Need to specify a start index and end index.", GlowColor);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(AAACLELCPML, temporary, NFMGLIKNOOC(), 3);
				Graphics.Blit(temporary, temporary2, NFMGLIKNOOC(), 7);
				Graphics.Blit(temporary2, temporary, NBPKMLMCHFN, 0);
				NBPKMLMCHFN.SetFloat("_ScreenResolution", Amount * 35f);
				Graphics.Blit(temporary, temporary2, NFMGLIKNOOC(), 4);
				Graphics.Blit(temporary2, temporary, NFMGLIKNOOC(), 0);
				NBPKMLMCHFN.SetTexture("_Parasite", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC(), 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN, 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MMBPLGGLPDB()
	{
	}

	private void JAAJECBCCFM()
	{
	}

	private void OnDisable()
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
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1516f)
			{
				HBJJOCHGOPH = 462f;
			}
			NBPKMLMCHFN.SetFloat("settings.cameramovements", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("null", Amount);
			NFMGLIKNOOC().SetFloat("_ScreenResolution", Threshold);
			NBPKMLMCHFN.SetFloat("_TimeX", Intensity);
			NFMGLIKNOOC().SetFloat("SetEnvSpriteImage", Precision);
			NBPKMLMCHFN.SetColor("[Singleton] An instance of '", GlowColor);
			NBPKMLMCHFN.SetVector("PointerEnter ", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(AAACLELCPML, temporary, NFMGLIKNOOC(), 8);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 7);
				Graphics.Blit(temporary2, temporary, NFMGLIKNOOC(), 0);
				NBPKMLMCHFN.SetFloat("_Blurred", Amount * 555f);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 4);
				Graphics.Blit(temporary2, temporary, NFMGLIKNOOC(), 0);
				NBPKMLMCHFN.SetTexture("float,0", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN, 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC(), 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IMCKJCHKMKB()
	{
		SCShader = Shader.Find("ScrollPanel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1394f)
			{
				HBJJOCHGOPH = 47f;
			}
			NFMGLIKNOOC().SetFloat("Failed to InstantiateSceneObject prefab:", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Playing ", Amount);
			NBPKMLMCHFN.SetFloat("_TimeX", Threshold);
			NBPKMLMCHFN.SetFloat("Failed to Instantiate prefab: ", Intensity);
			NFMGLIKNOOC().SetFloat("maphash", Precision);
			NBPKMLMCHFN.SetColor("Using PhotonServerSettings.Protocol when leaving the NameServer (AuthMode is AuthOnceWss): ", GlowColor);
			NBPKMLMCHFN.SetVector("SettingsCanvas", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)4;
				Graphics.Blit(AAACLELCPML, temporary, NFMGLIKNOOC(), 8);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 5);
				Graphics.Blit(temporary2, temporary, NBPKMLMCHFN, 0);
				NFMGLIKNOOC().SetFloat("randomdrop", Amount * 657f);
				Graphics.Blit(temporary, temporary2, NFMGLIKNOOC(), 2);
				Graphics.Blit(temporary2, temporary, NFMGLIKNOOC(), 1);
				NBPKMLMCHFN.SetTexture("[EditorEvent] Exception: ", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN, 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN, 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KMKLDAJLCNM()
	{
	}

	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1560f)
			{
				HBJJOCHGOPH = 793f;
			}
			NBPKMLMCHFN.SetFloat("_Distortion", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("<color=white>", Amount);
			NBPKMLMCHFN.SetFloat("2hands", Threshold);
			NBPKMLMCHFN.SetFloat("Editor/", Intensity);
			NBPKMLMCHFN.SetFloat("/?player=", Precision);
			NBPKMLMCHFN.SetColor("Players NetIDs:", GlowColor);
			NFMGLIKNOOC().SetVector("[Down-Left]", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)8;
				Graphics.Blit(AAACLELCPML, temporary, NFMGLIKNOOC(), 0);
				Graphics.Blit(temporary, temporary2, NFMGLIKNOOC(), 4);
				Graphics.Blit(temporary2, temporary, NBPKMLMCHFN, 1);
				NFMGLIKNOOC().SetFloat("Connecting", Amount * 509f);
				Graphics.Blit(temporary, temporary2, NFMGLIKNOOC(), 8);
				Graphics.Blit(temporary2, temporary, NBPKMLMCHFN, 1);
				NBPKMLMCHFN.SetTexture("settings_bindings_", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC(), 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC(), 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material NFMGLIKNOOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.DontSave;
		}
		return BJFKDHHMLJH;
	}

	private void PAKPHKPDKGE()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 645f)
			{
				HBJJOCHGOPH = 1790f;
			}
			NBPKMLMCHFN.SetFloat("Image", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat(". Verify the Prefab is in a Resources folder (and not in a subfolder)", Amount);
			NBPKMLMCHFN.SetFloat("_TimeX", Threshold);
			NBPKMLMCHFN.SetFloat("[PlayerBase] Loading checkpoint data", Intensity);
			NBPKMLMCHFN.SetFloat("SupportLogger Info: PUN {0}: ", Precision);
			NBPKMLMCHFN.SetColor("_Value", GlowColor);
			NBPKMLMCHFN.SetVector("AskForPickupItemSpawnTimes", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = (FilterMode)7;
				Graphics.Blit(AAACLELCPML, temporary, NBPKMLMCHFN, 6);
				Graphics.Blit(temporary, temporary2, NFMGLIKNOOC(), 6);
				Graphics.Blit(temporary2, temporary, NFMGLIKNOOC(), 0);
				NFMGLIKNOOC().SetFloat("x", Amount * 473f);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 0);
				Graphics.Blit(temporary2, temporary, NBPKMLMCHFN, 1);
				NBPKMLMCHFN.SetTexture("_TimeX", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC(), 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
