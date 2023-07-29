// CameraFilterPack_Blur_Tilt_Shift
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Blur/Tilt_Shift")]
[ExecuteInEditMode]
public class CameraFilterPack_Blur_Tilt_Shift : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 20f)]
	public float Amount = 3f;

	[Range(2f, 16f)]
	public int FastFilter = 8;

	[Range(0f, 1f)]
	public float Smooth = 0.5f;

	[Range(0f, 1f)]
	public float Size = 0.5f;

	[Range(-1f, 1f)]
	public float Position = 0.5f;

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

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/BlurTiltShift");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CCLNNLCOPBL()
	{
		SCShader = Shader.Find(": ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NNCCPEBIAKH()
	{
		SCShader = Shader.Find("CameraFilterPack/Colors_RgbClamp");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material LDNADDJMIPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void LLJLDLLNFBH()
	{
	}

	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1466f)
			{
				HBJJOCHGOPH = 894f;
			}
			DBOLLHHMKKN().SetFloat(" not exist", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_CenterX", Amount);
			ACHNOHCLGOO().SetFloat("Intensity", Smooth);
			NBPKMLMCHFN.SetFloat("0.00", Size);
			ACHNOHCLGOO().SetFloat("It seems some instantiation is not completed, as instantiation data is used. You should make sure instantiations are paused when calling this method. Cleaning now, despite this.", Position);
			DBOLLHHMKKN().SetVector("restrictions", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = (FilterMode)4;
				Graphics.Blit(AAACLELCPML, temporary, DBOLLHHMKKN(), 3);
				Graphics.Blit(temporary, temporary2, ACHNOHCLGOO(), 1);
				LDNADDJMIPK().SetFloat("Save", Amount * 1888f);
				Graphics.Blit(temporary2, temporary, NBPKMLMCHFN, 5);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 0);
				ACHNOHCLGOO().SetTexture("menu.playedpage", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO(), 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 793f)
			{
				HBJJOCHGOPH = 409f;
			}
			LDNADDJMIPK().SetFloat("Tab2Content", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat("FinalScoreSmallText", Amount);
			NBPKMLMCHFN.SetFloat("inventory.selected.", Smooth);
			ACHNOHCLGOO().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", Size);
			NBPKMLMCHFN.SetFloat("input", Position);
			LDNADDJMIPK().SetVector("#scoresubmitionfailed: ", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = FilterMode.Trilinear;
				Graphics.Blit(AAACLELCPML, temporary, DBOLLHHMKKN(), 8);
				Graphics.Blit(temporary, temporary2, DBOLLHHMKKN(), 0);
				ACHNOHCLGOO().SetFloat("[MapEditor] Loading music...", Amount * 1597f);
				Graphics.Blit(temporary2, temporary, NBPKMLMCHFN, 6);
				Graphics.Blit(temporary, temporary2, ACHNOHCLGOO(), 0);
				LDNADDJMIPK().SetTexture("CameraFilterPack/TV_Vintage", temporary2);
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

	private void GAOOPEEBGJA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material ACHNOHCLGOO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)114;
		}
		return BJFKDHHMLJH;
	}

	private void FEHCNJLLJMP()
	{
		SCShader = Shader.Find("SetSunSensitivity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void Update()
	{
	}

	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1613f)
			{
				HBJJOCHGOPH = 1879f;
			}
			ACHNOHCLGOO().SetFloat("shader.none", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value9", Amount);
			DBOLLHHMKKN().SetFloat("Ignored PU RPC, cause item is inactive. ", Smooth);
			DBOLLHHMKKN().SetFloat("Can not SetMasterClient(). Not in room or in offlineMode.", Size);
			NBPKMLMCHFN.SetFloat("SetParticlesGravity", Position);
			ACHNOHCLGOO().SetVector("_Source", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = (FilterMode)7;
				Graphics.Blit(AAACLELCPML, temporary, LDNADDJMIPK(), 2);
				Graphics.Blit(temporary, temporary2, ACHNOHCLGOO(), 1);
				NBPKMLMCHFN.SetFloat("<color=#", Amount * 1037f);
				Graphics.Blit(temporary2, temporary, ACHNOHCLGOO(), 8);
				Graphics.Blit(temporary, temporary2, ACHNOHCLGOO(), 1);
				NBPKMLMCHFN.SetTexture("_Value", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO(), 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK(), 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DBOLLHHMKKN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-95);
		}
		return BJFKDHHMLJH;
	}

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1816f)
			{
				HBJJOCHGOPH = 5f;
			}
			ACHNOHCLGOO().SetFloat("new round", HBJJOCHGOPH);
			LDNADDJMIPK().SetFloat("_Value5", Amount);
			DBOLLHHMKKN().SetFloat("maps.", Smooth);
			NBPKMLMCHFN.SetFloat("_Value", Size);
			ACHNOHCLGOO().SetFloat("_UV_Transform", Position);
			LDNADDJMIPK().SetVector("/", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)8;
				Graphics.Blit(AAACLELCPML, temporary, ACHNOHCLGOO(), 4);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 1);
				DBOLLHHMKKN().SetFloat("_Alpha", Amount * 973f);
				Graphics.Blit(temporary2, temporary, ACHNOHCLGOO(), 5);
				Graphics.Blit(temporary, temporary2, LDNADDJMIPK(), 0);
				NBPKMLMCHFN.SetTexture("skin.no_hit", temporary2);
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
			NBPKMLMCHFN.SetFloat("_Value1", Smooth);
			NBPKMLMCHFN.SetFloat("_Value2", Size);
			NBPKMLMCHFN.SetFloat("_Value3", Position);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = FilterMode.Trilinear;
				Graphics.Blit(AAACLELCPML, temporary, NBPKMLMCHFN, 2);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 0);
				NBPKMLMCHFN.SetFloat("_Amount", Amount * 2f);
				Graphics.Blit(temporary2, temporary, NBPKMLMCHFN, 2);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 0);
				NBPKMLMCHFN.SetTexture("_MainTex2", temporary2);
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

	private void BEBNOKFLJPH()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KLILJHJNICK()
	{
		SCShader = Shader.Find("_GrainTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EGEPLFGKGLI()
	{
		SCShader = Shader.Find(" ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KIMMMCJFMAB()
	{
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}
}
