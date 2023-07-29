// CameraFilterPack_EXTRA_SHOWFPS
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/EXTRA/SHOWFPS")]
public class CameraFilterPack_EXTRA_SHOWFPS : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(8f, 42f)]
	public float Size = 12f;

	[Range(0f, 100f)]
	private int PBNOHCNHAHB = 1;

	[Range(0f, 10f)]
	private float ILHJFHFPGBB = 1f;

	[Range(0f, 10f)]
	private float CCIENBFIKKH = 1f;

	private float OLIFJHCOEGP;

	private int NOIDDEDHJDF;

	public float frequency = 0.5f;

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

	private void AEIJFLJEABG()
	{
		OLIFJHCOEGP += Time.timeScale / Time.deltaTime;
		NOIDDEDHJDF++;
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HFBJAOFLCJI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void EGEPLFGKGLI()
	{
		PBNOHCNHAHB = 0;
		StartCoroutine(DKKLGINECAC());
		SCShader = Shader.Find("Set satellite lerp speed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JKFDDNMPOJH()
	{
		PBNOHCNHAHB = 0;
		StartCoroutine(EBJKKIKCJCC());
		SCShader = Shader.Find("SetParticlesColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private IEnumerator DKKLGINECAC()
	{
		while (true)
		{
			float num = OLIFJHCOEGP / (float)NOIDDEDHJDF;
			PBNOHCNHAHB = (int)num;
			OLIFJHCOEGP = 0f;
			NOIDDEDHJDF = 0;
			yield return new WaitForSeconds(frequency);
		}
	}

	private void DIPDEHOOBPG()
	{
		PBNOHCNHAHB = 1;
		StartCoroutine(DKKLGINECAC());
		SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private IEnumerator EBJKKIKCJCC()
	{
		while (true)
		{
			float num = OLIFJHCOEGP / (float)NOIDDEDHJDF;
			PBNOHCNHAHB = (int)num;
			OLIFJHCOEGP = 0f;
			NOIDDEDHJDF = 0;
			yield return new WaitForSeconds(frequency);
		}
	}

	private void KDMANOEMOCA()
	{
		PBNOHCNHAHB = 1;
		StartCoroutine(DKKLGINECAC());
		SCShader = Shader.Find("z");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void Start()
	{
		PBNOHCNHAHB = 0;
		StartCoroutine(DKKLGINECAC());
		SCShader = Shader.Find("CameraFilterPack/EXTRA_SHOWFPS");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material ACHNOHCLGOO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1018f)
			{
				HBJJOCHGOPH = 1838f;
			}
			ACHNOHCLGOO().SetFloat("mode", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("DPADVER", Size);
			HFBJAOFLCJI().SetFloat(": ", PBNOHCNHAHB);
			ACHNOHCLGOO().SetFloat("MenuVolumeSlider", ILHJFHFPGBB);
			HFBJAOFLCJI().SetFloat("_PositionY", CCIENBFIKKH);
			ACHNOHCLGOO().SetVector("#", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 376f, 1126f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DFENCIHAADO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PLIKADJCEPO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KMKLDAJLCNM()
	{
		OLIFJHCOEGP += Time.timeScale / Time.deltaTime;
		NOIDDEDHJDF++;
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
			NBPKMLMCHFN.SetFloat("_Value", Size);
			NBPKMLMCHFN.SetFloat("_Value2", PBNOHCNHAHB);
			NBPKMLMCHFN.SetFloat("_Value3", ILHJFHFPGBB);
			NBPKMLMCHFN.SetFloat("_Value4", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-1);
		}
		return BJFKDHHMLJH;
	}

	private void BEBNOKFLJPH()
	{
		PBNOHCNHAHB = 1;
		StartCoroutine(DKKLGINECAC());
		SCShader = Shader.Find("\n");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void Update()
	{
		OLIFJHCOEGP += Time.timeScale / Time.deltaTime;
		NOIDDEDHJDF++;
	}

	private void MAOCOEGAFND()
	{
		OLIFJHCOEGP += Time.timeScale / Time.deltaTime;
		NOIDDEDHJDF += 0;
	}
}
