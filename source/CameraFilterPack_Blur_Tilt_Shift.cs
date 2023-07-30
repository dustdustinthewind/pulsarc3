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
		SCShader = Shader.Find("%");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NNCCPEBIAKH()
	{
		SCShader = Shader.Find("_ScreenResolution");
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
			ACHNOHCLGOO().SetFloat(": ", HBJJOCHGOPH);
			LDNADDJMIPK().SetFloat("_TimeX", Amount);
			LDNADDJMIPK().SetFloat("Fade", Smooth);
			ACHNOHCLGOO().SetFloat("LevelEditor/patterns", Size);
			ACHNOHCLGOO().SetFloat("Not sending leave operation. State is not 'Joined': ", Position);
			ACHNOHCLGOO().SetVector("\n\n#", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = (FilterMode)4;
				Graphics.Blit(AAACLELCPML, temporary, ACHNOHCLGOO(), 3);
				Graphics.Blit(temporary, temporary2, DBOLLHHMKKN(), 1);
				DBOLLHHMKKN().SetFloat("Save", Amount * 1888f);
				Graphics.Blit(temporary2, temporary, ACHNOHCLGOO(), 5);
				Graphics.Blit(temporary, temporary2, LDNADDJMIPK(), 0);
				NBPKMLMCHFN.SetTexture("menu.tabid", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK(), 1);
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
			LDNADDJMIPK().SetFloat("EnvironmentSlider", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("FinalScoreSmallText", Amount);
			DBOLLHHMKKN().SetFloat("inventory.selected.", Smooth);
			DBOLLHHMKKN().SetFloat("EventSystem", Size);
			ACHNOHCLGOO().SetFloat("input", Position);
			LDNADDJMIPK().SetVector("bad", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = FilterMode.Trilinear;
				Graphics.Blit(AAACLELCPML, temporary, DBOLLHHMKKN(), 8);
				Graphics.Blit(temporary, temporary2, DBOLLHHMKKN(), 0);
				ACHNOHCLGOO().SetFloat("[MapEditor] Prepairing map editor...", Amount * 1597f);
				Graphics.Blit(temporary2, temporary, ACHNOHCLGOO(), 6);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 0);
				LDNADDJMIPK().SetTexture("_VignettingColor", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK(), 1);
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
		SCShader = Shader.Find("SetSunInput");
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
			LDNADDJMIPK().SetFloat("shader.pixel", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("_Value8", Amount);
			ACHNOHCLGOO().SetFloat("PunRespawn with Position.", Smooth);
			ACHNOHCLGOO().SetFloat(". No ViewIDs are free to use. Max is: ", Size);
			ACHNOHCLGOO().SetFloat("Set particles size", Position);
			NBPKMLMCHFN.SetVector("offsets", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = (FilterMode)7;
				Graphics.Blit(AAACLELCPML, temporary, ACHNOHCLGOO(), 2);
				Graphics.Blit(temporary, temporary2, LDNADDJMIPK(), 1);
				ACHNOHCLGOO().SetFloat("#onrankchangeuptext", Amount * 1037f);
				Graphics.Blit(temporary2, temporary, LDNADDJMIPK(), 8);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 1);
				DBOLLHHMKKN().SetTexture("_TimeX", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN, 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO(), 1);
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
			DBOLLHHMKKN().SetFloat("remaining: {0:0.000}", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value5", Amount);
			ACHNOHCLGOO().SetFloat("maps.", Smooth);
			LDNADDJMIPK().SetFloat("_Value", Size);
			LDNADDJMIPK().SetFloat("_MainTex", Position);
			DBOLLHHMKKN().SetVector("[MapsData] Unsubscribe ", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)8;
				Graphics.Blit(AAACLELCPML, temporary, NBPKMLMCHFN, 4);
				Graphics.Blit(temporary, temporary2, ACHNOHCLGOO(), 1);
				LDNADDJMIPK().SetFloat("_Alpha", Amount * 973f);
				Graphics.Blit(temporary2, temporary, NBPKMLMCHFN, 5);
				Graphics.Blit(temporary, temporary2, NBPKMLMCHFN, 0);
				ACHNOHCLGOO().SetTexture("skin.no_hit", temporary2);
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
		SCShader = Shader.Find("_MainTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EGEPLFGKGLI()
	{
		SCShader = Shader.Find("%");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KIMMMCJFMAB()
	{
		SCShader = Shader.Find("_TimeX");
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
