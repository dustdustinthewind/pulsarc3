// CameraFilterPack_Vision_Blood_Fast
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Vision/Blood_Fast")]
public class CameraFilterPack_Vision_Blood_Fast : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0.01f, 1f)]
	public float HoleSize = 0.6f;

	[Range(-1f, 1f)]
	public float HoleSmooth = 0.3f;

	[Range(-2f, 2f)]
	public float Color1 = 0.2f;

	[Range(-2f, 2f)]
	public float Color2 = 0.9f;

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

	private void JHLGHODFJOO()
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

	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1713f)
			{
				HBJJOCHGOPH = 727f;
			}
			NBPKMLMCHFN.SetFloat(" x ", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("_Value3", HoleSize);
			KGOLDDBHIFN().SetFloat("Joystick1Button11", HoleSmooth);
			NBPKMLMCHFN.SetFloat("_BlurFilterDistance", Color1);
			KGOLDDBHIFN().SetFloat("UseScanLineSize", Color2);
			KGOLDDBHIFN().SetVector("OnPress", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 252f, 278f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MAOCOEGAFND()
	{
	}

	private void NCNPAKFAFOE()
	{
		SCShader = Shader.Find("CameraFilterPack/Drawing_Toon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BEBNOKFLJPH()
	{
		SCShader = Shader.Find("_Visualize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 275f)
			{
				HBJJOCHGOPH = 548f;
			}
			KGOLDDBHIFN().SetFloat("PUNCloudBestRegion", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("menutheme.27thfloor", HoleSize);
			NBPKMLMCHFN.SetFloat("maps.", HoleSmooth);
			NBPKMLMCHFN.SetFloat("_Value2", Color1);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", Color2);
			KGOLDDBHIFN().SetVector("SetTrailZoomSpeed", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1563f, 829f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-72);
		}
		return BJFKDHHMLJH;
	}

	private void GPHPJIDGEPI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JAAJECBCCFM()
	{
	}

	private void Update()
	{
	}

	private void MFMIODIAKNI()
	{
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
			NBPKMLMCHFN.SetFloat("_Value", HoleSize);
			NBPKMLMCHFN.SetFloat("_Value2", HoleSmooth);
			NBPKMLMCHFN.SetFloat("_Value3", Color1);
			NBPKMLMCHFN.SetFloat("_Value4", Color2);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1669f)
			{
				HBJJOCHGOPH = 925f;
			}
			KGOLDDBHIFN().SetFloat("[EditorEvent] Exception: ", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("z", HoleSize);
			NBPKMLMCHFN.SetFloat("Set particles audio input", HoleSmooth);
			NBPKMLMCHFN.SetFloat("#ok", Color1);
			NBPKMLMCHFN.SetFloat("_Value", Color2);
			NBPKMLMCHFN.SetVector("EventData0DropDownList", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 300f, 1470f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Vision_Blood_Fast");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
