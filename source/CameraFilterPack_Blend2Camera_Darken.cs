// CameraFilterPack_Blend2Camera_Darken
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/Darken")]
[ExecuteInEditMode]
public class CameraFilterPack_Blend2Camera_Darken : MonoBehaviour
{
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Darken";

	public Shader SCShader;

	public Camera Camera2;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 1f)]
	public float SwitchCameraToCamera2;

	[Range(0f, 1f)]
	public float BlendFX = 0.5f;

	private RenderTexture JDMCFBKJHDD;

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

	private void OnDisable()
	{
		if (Camera2 != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OnEnable()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void GJPONJKJICG()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -72);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void GLGGNBOBFKE()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 60);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void KIMMMCJFMAB()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -74);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 202f)
			{
				HBJJOCHGOPH = 830f;
			}
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture("[Up]", JDMCFBKJHDD);
			}
			LDNADDJMIPK().SetFloat("_Value3", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Triangle", BlendFX);
			LDNADDJMIPK().SetFloat("<b>#", SwitchCameraToCamera2);
			LDNADDJMIPK().SetVector("downloading", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1889f, 1350f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1672f)
			{
				HBJJOCHGOPH = 481f;
			}
			if (Camera2 != null)
			{
				LDNADDJMIPK().SetTexture("checkpoint", JDMCFBKJHDD);
			}
			LDNADDJMIPK().SetFloat("player.orangearc", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_FrustumCornersWS", BlendFX);
			LDNADDJMIPK().SetFloat("_ReflectionTexture3", SwitchCameraToCamera2);
			LDNADDJMIPK().SetVector("/../", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1350f, 329f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FDIJLKIIMLL()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 43);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 992f)
			{
				HBJJOCHGOPH = 1818f;
			}
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture("_ScreenResolution", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat("Paste events", HBJJOCHGOPH);
			LDNADDJMIPK().SetFloat("id", BlendFX);
			NBPKMLMCHFN.SetFloat("[Up-Down-Left]", SwitchCameraToCamera2);
			NBPKMLMCHFN.SetVector("/music", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 63f, 416f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	private void NKLIHNJCHOG()
	{
	}

	[SpecialName]
	private Material LDNADDJMIPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)103;
		}
		return BJFKDHHMLJH;
	}

	private void IFKNIHJCAFB()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 40);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void Start()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DIPDEHOOBPG()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 45);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MFOOCOIIIJN()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -14);
			Camera2.targetTexture = JDMCFBKJHDD;
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
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture("_MainTex2", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat("_TimeX", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value", BlendFX);
			NBPKMLMCHFN.SetFloat("_Value2", SwitchCameraToCamera2);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
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
			if (HBJJOCHGOPH > 284f)
			{
				HBJJOCHGOPH = 645f;
			}
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture("offsets", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat("tagElement", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("JITTER", BlendFX);
			NBPKMLMCHFN.SetFloat("warning: Audio Source: ", SwitchCameraToCamera2);
			NBPKMLMCHFN.SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1213f, 1125f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OnValidate()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void OFBLDOCCBBN()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -117);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void GPJHPNGNEBP()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -58);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}
}
