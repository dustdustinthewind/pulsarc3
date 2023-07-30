// CameraFilterPack_FX_8bits
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Pixel/8bits")]
[ExecuteInEditMode]
public class CameraFilterPack_FX_8bits : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Material BJFKDHHMLJH;

	[Range(-1f, 1f)]
	public float Brightness;

	[Range(80f, 640f)]
	public int ResolutionX = 160;

	[Range(60f, 480f)]
	public int ResolutionY = 240;

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

	private void NAOLAJPDGIC()
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
			BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void NNCCPEBIAKH()
	{
		SCShader = Shader.Find("_Threshhold");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HGDDCINLDAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JHJFBCFBKLD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 731f)
			{
				HBJJOCHGOPH = 99f;
			}
			EFDEIFCDAFG().SetFloat("[PlayerBase] Reset", HBJJOCHGOPH);
			if (Brightness == 666f)
			{
				Brightness = 657f;
			}
			NBPKMLMCHFN.SetFloat("_Value3", Brightness);
			RenderTexture temporary = RenderTexture.GetTemporary(ResolutionX, ResolutionY, 0);
			Graphics.Blit(AAACLELCPML, temporary, PDEAHJPOMEF());
			temporary.filterMode = FilterMode.Point;
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
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

	private void KCDOMIJBFLL()
	{
	}

	private void DIPDEHOOBPG()
	{
		SCShader = Shader.Find("#ok");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FEHCNJLLJMP()
	{
		SCShader = Shader.Find("float,1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 782f)
			{
				HBJJOCHGOPH = 1963f;
			}
			HFBJAOFLCJI().SetFloat("_FullResolutionFiltering", HBJJOCHGOPH);
			if (Brightness == 824f)
			{
				Brightness = 1725f;
			}
			EFDEIFCDAFG().SetFloat("SetParticlesEmission", Brightness);
			RenderTexture temporary = RenderTexture.GetTemporary(ResolutionX, ResolutionY, 0);
			Graphics.Blit(AAACLELCPML, temporary, PDEAHJPOMEF());
			temporary.filterMode = FilterMode.Point;
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DOEPOGLEGLE()
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

	private void EPEGAEGDJAM()
	{
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material LDNADDJMIPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)116;
		}
		return BJFKDHHMLJH;
	}

	private void Update()
	{
	}

	private void CNGAJDBOCLJ()
	{
		SCShader = Shader.Find("Is it practically possible?");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DHENLPJJOEN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1910f)
			{
				HBJJOCHGOPH = 1156f;
			}
			EFDEIFCDAFG().SetFloat("LevelEditor/CustomEventEditor-Text", HBJJOCHGOPH);
			if (Brightness == 1611f)
			{
				Brightness = 385f;
			}
			PDEAHJPOMEF().SetFloat("{0}{1}:{2}", Brightness);
			RenderTexture temporary = RenderTexture.GetTemporary(ResolutionX, ResolutionY, 0);
			Graphics.Blit(AAACLELCPML, temporary, KAFBNOBOIAJ());
			temporary.filterMode = FilterMode.Point;
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JHJGJJKELJM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BEBNOKFLJPH()
	{
		SCShader = Shader.Find("_FgOverlap");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material KAFBNOBOIAJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void PAEGLMEOKHP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AIJGAJIOJDJ()
	{
	}

	private void GAOOPEEBGJA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ONMGIPAILOH()
	{
	}

	private void EDBEHEKMGFH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/FX_8bits");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 907f)
			{
				HBJJOCHGOPH = 468f;
			}
			EFDEIFCDAFG().SetFloat("SetParent", HBJJOCHGOPH);
			if (Brightness == 1463f)
			{
				Brightness = 881f;
			}
			PDEAHJPOMEF().SetFloat("Item ", Brightness);
			RenderTexture temporary = RenderTexture.GetTemporary(ResolutionX, ResolutionY, 1);
			Graphics.Blit(AAACLELCPML, temporary, EFDEIFCDAFG());
			temporary.filterMode = FilterMode.Point;
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1056f)
			{
				HBJJOCHGOPH = 1956f;
			}
			LDNADDJMIPK().SetFloat(" AuthMode ", HBJJOCHGOPH);
			if (Brightness == 1727f)
			{
				Brightness = 796f;
			}
			NBPKMLMCHFN.SetFloat("_ChangeGreen", Brightness);
			RenderTexture temporary = RenderTexture.GetTemporary(ResolutionX, ResolutionY, 1);
			Graphics.Blit(AAACLELCPML, temporary, KAFBNOBOIAJ());
			temporary.filterMode = FilterMode.Point;
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PLIKADJCEPO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material EFDEIFCDAFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
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
			if (Brightness == 0f)
			{
				Brightness = 0.001f;
			}
			NBPKMLMCHFN.SetFloat("_Distortion", Brightness);
			RenderTexture temporary = RenderTexture.GetTemporary(ResolutionX, ResolutionY, 0);
			Graphics.Blit(AAACLELCPML, temporary, NBPKMLMCHFN);
			temporary.filterMode = FilterMode.Point;
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
