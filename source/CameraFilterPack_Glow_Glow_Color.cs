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
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Blur_Movie", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("ws://", Amount);
			NBPKMLMCHFN.SetFloat(": ", Threshold);
			NBPKMLMCHFN.SetFloat("BloodAlternative2", Intensity);
			NBPKMLMCHFN.SetFloat("LostAllLives", Precision);
			NFMGLIKNOOC().SetColor("menu.playedpage", GlowColor);
			NFMGLIKNOOC().SetVector("_ScreenResolution", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)6;
				Graphics.Blit(AAACLELCPML, temporary, NBPKMLMCHFN, 1);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 3);
				Graphics.Blit(temporary2, temporary, NBPKMLMCHFN, 1);
				NFMGLIKNOOC().SetFloat("z", Amount * 288f);
				Graphics.Blit(temporary, temporary2, NFMGLIKNOOC(), 3);
				Graphics.Blit(temporary2, temporary, NFMGLIKNOOC(), 1);
				NFMGLIKNOOC().SetTexture("_DistortionSize", temporary);
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
			NBPKMLMCHFN.SetFloat("value", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("true", Amount);
			NFMGLIKNOOC().SetFloat("VisionBlur", Threshold);
			NBPKMLMCHFN.SetFloat("_Tint", Intensity);
			NBPKMLMCHFN.SetFloat(").png", Precision);
			NBPKMLMCHFN.SetColor("Couldn't call DestroyAll() as only the master client is allowed to call this.", GlowColor);
			NBPKMLMCHFN.SetVector("gameVolume", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(AAACLELCPML, temporary, NBPKMLMCHFN, 2);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 3);
				Graphics.Blit(temporary2, temporary, NFMGLIKNOOC(), 0);
				NFMGLIKNOOC().SetFloat("y", Amount * 1469f);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 7);
				Graphics.Blit(temporary2, temporary, NBPKMLMCHFN, 0);
				NBPKMLMCHFN.SetTexture("CameraFilterPack/TV_Vignetting", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC(), 1);
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

	private void NBGIMIDICKE()
	{
		SCShader = Shader.Find("HighScaleShot");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BGDPIHMAACO()
	{
		SCShader = Shader.Find("Tab1Content");
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
		SCShader = Shader.Find("Uploading preview image");
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
			NBPKMLMCHFN.SetFloat("st", Amount);
			NFMGLIKNOOC().SetFloat("settings_bindings_", Threshold);
			NBPKMLMCHFN.SetFloat(" - {0}", Intensity);
			NFMGLIKNOOC().SetFloat("Parent ID", Precision);
			NFMGLIKNOOC().SetColor("X2", GlowColor);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(AAACLELCPML, temporary, NBPKMLMCHFN, 3);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 7);
				Graphics.Blit(temporary2, temporary, NBPKMLMCHFN, 0);
				NFMGLIKNOOC().SetFloat("_Distortion", Amount * 35f);
				Graphics.Blit(temporary, temporary2, NFMGLIKNOOC(), 4);
				Graphics.Blit(temporary2, temporary, NBPKMLMCHFN, 0);
				NFMGLIKNOOC().SetTexture("_Colorisation", temporary);
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
			NFMGLIKNOOC().SetFloat("menu.selectedplaymode", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("Received RPC: ", Amount);
			NBPKMLMCHFN.SetFloat("_Speed", Threshold);
			NFMGLIKNOOC().SetFloat("CameraFilterPack/FX_Ascii", Intensity);
			NFMGLIKNOOC().SetFloat("Spawn new environment sprite (image) and sets its id", Precision);
			NFMGLIKNOOC().SetColor("[Singleton] Using instance of '", GlowColor);
			NFMGLIKNOOC().SetVector("clicked ", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(AAACLELCPML, temporary, NFMGLIKNOOC(), 8);
				Graphics.Blit(temporary, temporary2, NFMGLIKNOOC(), 7);
				Graphics.Blit(temporary2, temporary, NBPKMLMCHFN, 0);
				NBPKMLMCHFN.SetFloat("_BlurSize", Amount * 555f);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 4);
				Graphics.Blit(temporary2, temporary, NFMGLIKNOOC(), 0);
				NFMGLIKNOOC().SetTexture("z", temporary);
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

	private void IMCKJCHKMKB()
	{
		SCShader = Shader.Find("MainButton");
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
			NBPKMLMCHFN.SetFloat("Failed to InstantiateSceneObject prefab: ", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Gameplay/Base", Amount);
			NFMGLIKNOOC().SetFloat("_ScreenResolution", Threshold);
			NBPKMLMCHFN.SetFloat("AllocateViewID() failed. User {0} is out of subIds, as all viewIDs are used.", Intensity);
			NBPKMLMCHFN.SetFloat("gamemode", Precision);
			NFMGLIKNOOC().SetColor("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.", GlowColor);
			NFMGLIKNOOC().SetVector(" x ", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
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
				NBPKMLMCHFN.SetFloat("close", Amount * 657f);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 2);
				Graphics.Blit(temporary2, temporary, NFMGLIKNOOC(), 1);
				NBPKMLMCHFN.SetTexture("_EmissionColor", temporary);
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
			NFMGLIKNOOC().SetFloat(" | ", Amount);
			NBPKMLMCHFN.SetFloat(":", Threshold);
			NFMGLIKNOOC().SetFloat("/", Intensity);
			NFMGLIKNOOC().SetFloat("deletemap", Precision);
			NFMGLIKNOOC().SetColor("Players NetIDs:", GlowColor);
			NBPKMLMCHFN.SetVector("[Down-Left]", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
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
				NFMGLIKNOOC().SetFloat("player", Amount * 509f);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 8);
				Graphics.Blit(temporary2, temporary, NBPKMLMCHFN, 1);
				NBPKMLMCHFN.SetTexture("settings_bindings_controller_type", temporary);
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
		SCShader = Shader.Find("CameraFilterPack/Light_Rainbow2");
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
			NFMGLIKNOOC().SetFloat("Image", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat(". Client should be in a room. Current connectionStateDetailed: ", Amount);
			NFMGLIKNOOC().SetFloat("_TimeX", Threshold);
			NFMGLIKNOOC().SetFloat("maps.", Intensity);
			NBPKMLMCHFN.SetFloat("SupportLogger OnApplicationPause: ", Precision);
			NFMGLIKNOOC().SetColor("_TimeX", GlowColor);
			NBPKMLMCHFN.SetVector("Joined Room. isMasterClient: ", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = (FilterMode)7;
				Graphics.Blit(AAACLELCPML, temporary, NFMGLIKNOOC(), 6);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 6);
				Graphics.Blit(temporary2, temporary, NBPKMLMCHFN, 0);
				NBPKMLMCHFN.SetFloat("x", Amount * 473f);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 0);
				Graphics.Blit(temporary2, temporary, NBPKMLMCHFN, 1);
				NBPKMLMCHFN.SetTexture("_TimeX", temporary);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN, 1);
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
