// CameraFilterPack_Colors_HSV
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Colors/HSV")]
[ExecuteInEditMode]
public class CameraFilterPack_Colors_HSV : MonoBehaviour
{
	public Shader SCShader;

	[Range(0f, 360f)]
	public float _HueShift = 180f;

	[Range(-32f, 32f)]
	public float _Saturation = 1f;

	[Range(-32f, 32f)]
	public float _ValueBrightness = 1f;

	private Material BJFKDHHMLJH;

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

	private void BEBNOKFLJPH()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			NBPKMLMCHFN.SetFloat("[MapsData] Caching ", _HueShift);
			HHIFMIPPMPF().SetFloat("_DotSize", _Saturation);
			NBPKMLMCHFN.SetFloat("tagElement", _ValueBrightness);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
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

	private void Start()
	{
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

	private void GAOOPEEBGJA()
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
			NBPKMLMCHFN.SetFloat("_HueShift", _HueShift);
			NBPKMLMCHFN.SetFloat("_Sat", _Saturation);
			NBPKMLMCHFN.SetFloat("_Val", _ValueBrightness);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OCMKCBBCEFG()
	{
	}

	private void JAAJECBCCFM()
	{
	}

	[SpecialName]
	private Material HHIFMIPPMPF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material ACHNOHCLGOO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-98);
		}
		return BJFKDHHMLJH;
	}

	private void KLILJHJNICK()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IMCKJCHKMKB()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			NBPKMLMCHFN.SetFloat("_ScreenResolution", _HueShift);
			NBPKMLMCHFN.SetFloat("_Axis", _Saturation);
			ACHNOHCLGOO().SetFloat("LevelNameInputField", _ValueBrightness);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DLMPALHKMON()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Update()
	{
	}

	private void JHPOIOELNCG()
	{
	}

	private void MMBPLGGLPDB()
	{
	}

	private void OFPPIKHNJOD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}
}
