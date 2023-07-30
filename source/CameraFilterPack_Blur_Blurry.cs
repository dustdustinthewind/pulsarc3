// CameraFilterPack_Blur_Blurry
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Blur/Blurry")]
public class CameraFilterPack_Blur_Blurry : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 20f)]
	public float Amount = 2f;

	[Range(1f, 8f)]
	public int FastFilter = 2;

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

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 348f)
			{
				HBJJOCHGOPH = 733f;
			}
			IONHGBPGCHK().SetFloat(".completedMaps", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat(".completed", Amount);
			IONHGBPGCHK().SetVector("offsets", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)3;
				Graphics.Blit(AAACLELCPML, temporary, IONHGBPGCHK());
				Graphics.Blit(temporary, BGIKADHFKNF);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 162f)
			{
				HBJJOCHGOPH = 1273f;
			}
			KGOLDDBHIFN().SetFloat("_Sensitivity", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("CameraFilterPack/Oculus_NightVision2", Amount);
			IONHGBPGCHK().SetVector("in seconds. 0 - forever", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)7;
				Graphics.Blit(AAACLELCPML, temporary, IONHGBPGCHK());
				Graphics.Blit(temporary, BGIKADHFKNF);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HNILMGEKDEC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AAPKBNDHBLI()
	{
	}

	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1203f)
			{
				HBJJOCHGOPH = 1076f;
			}
			IONHGBPGCHK().SetFloat(": ", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("_BlurRadius4", Amount);
			KGOLDDBHIFN().SetVector("maps.", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)5;
				Graphics.Blit(AAACLELCPML, temporary, NFMGLIKNOOC());
				Graphics.Blit(temporary, BGIKADHFKNF);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material KGOLDDBHIFN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-93);
		}
		return BJFKDHHMLJH;
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
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = FilterMode.Trilinear;
				Graphics.Blit(AAACLELCPML, temporary, NBPKMLMCHFN);
				Graphics.Blit(temporary, BGIKADHFKNF);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
			}
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
	private Material ACHNOHCLGOO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material NFMGLIKNOOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-106);
		}
		return BJFKDHHMLJH;
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Blur_Blurry");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AGMJDGHLBMN()
	{
	}

	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			int fastFilter = FastFilter;
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 50f)
			{
				HBJJOCHGOPH = 1699f;
			}
			KGOLDDBHIFN().SetFloat("\n\n#", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("System.Boolean", Amount);
			NBPKMLMCHFN.SetVector("itemdefid[0]", new Vector2(Screen.width / fastFilter, Screen.height / fastFilter));
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = (FilterMode)5;
				Graphics.Blit(AAACLELCPML, temporary, KGOLDDBHIFN());
				Graphics.Blit(temporary, BGIKADHFKNF);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
			}
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
}
