// CameraFilterPack_Blend2Camera_Exclusion
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/Exclusion")]
public class CameraFilterPack_Blend2Camera_Exclusion : MonoBehaviour
{
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Exclusion";

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

	private void OnEnable()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void AGMJDGHLBMN()
	{
	}

	private void MMMDPANNAIO()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -71);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
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
			if (HBJJOCHGOPH > 1854f)
			{
				HBJJOCHGOPH = 227f;
			}
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture("Ev DestroyAll! By PlayerId: ", JDMCFBKJHDD);
			}
			KGOLDDBHIFN().SetFloat("_History3LumaTex", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("LoadPlayerSkin", BlendFX);
			NBPKMLMCHFN.SetFloat("_BlurRadius4", SwitchCameraToCamera2);
			NFMGLIKNOOC().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1583f, 148f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HJDPEBAPBPN()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 70);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void NCNPAKFAFOE()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 75);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material NFMGLIKNOOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return BJFKDHHMLJH;
	}

	private void FDIJLKIIMLL()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 103);
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

	private void KIMMMCJFMAB()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 88);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
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

	private void FBMDHDBELEK()
	{
	}

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void JNACKHNNEPA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 38);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void Update()
	{
	}

	private void JBNPEHMDCMI()
	{
	}

	private void ELANJOHIJME()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -113);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void CFIAKIJAILI()
	{
	}

	private void CCLNNLCOPBL()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -38);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
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

	[SpecialName]
	private Material DOHGBNPMBKG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void DAHFFNNIGML()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 2);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HLIAEEMGBHN()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 71);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1398f)
			{
				HBJJOCHGOPH = 1839f;
			}
			if (Camera2 != null)
			{
				DOHGBNPMBKG().SetTexture("Error: you cannot write/send to this stream that you are reading!", JDMCFBKJHDD);
			}
			IONHGBPGCHK().SetFloat("_Value3", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("LivesSlider", BlendFX);
			DOHGBNPMBKG().SetFloat("[Right]", SwitchCameraToCamera2);
			KGOLDDBHIFN().SetVector("resource", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 20f, 889f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1132f)
			{
				HBJJOCHGOPH = 555f;
			}
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture("UseScanLineSize", JDMCFBKJHDD);
			}
			IONHGBPGCHK().SetFloat("</b>", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("workshop.txt", BlendFX);
			KGOLDDBHIFN().SetFloat("EventSystem", SwitchCameraToCamera2);
			NBPKMLMCHFN.SetVector("s", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1285f, 1077f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EMAMCDFBGOA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 69);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1125f)
			{
				HBJJOCHGOPH = 1941f;
			}
			if (Camera2 != null)
			{
				KGOLDDBHIFN().SetTexture("_NoiseTex", JDMCFBKJHDD);
			}
			IONHGBPGCHK().SetFloat("x", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("offsets", BlendFX);
			KGOLDDBHIFN().SetFloat("itemdefid[0]", SwitchCameraToCamera2);
			KGOLDDBHIFN().SetVector("_Value4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1510f, 6f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOHGBNPMBKG());
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void PAEGLMEOKHP()
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

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1198f)
			{
				HBJJOCHGOPH = 295f;
			}
			if (Camera2 != null)
			{
				DOHGBNPMBKG().SetTexture(", ", JDMCFBKJHDD);
			}
			DOHGBNPMBKG().SetFloat("float,0", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("#discord{0}joinrequest", BlendFX);
			PDEAHJPOMEF().SetFloat("Show image from resources by id at the center of the screen at foreground or background", SwitchCameraToCamera2);
			PDEAHJPOMEF().SetVector("Tab1Content", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 746f, 1161f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DPFOEBCADNP()
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

	private void IBEAPBDAOCC()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 107);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void IFBKMAEMKNN()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 102);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 276f)
			{
				HBJJOCHGOPH = 729f;
			}
			if (Camera2 != null)
			{
				NFMGLIKNOOC().SetTexture("[Up-Right]", JDMCFBKJHDD);
			}
			IONHGBPGCHK().SetFloat("\"x", HBJJOCHGOPH);
			DOHGBNPMBKG().SetFloat("pointBuffer", BlendFX);
			KGOLDDBHIFN().SetFloat("Gameplay/sun", SwitchCameraToCamera2);
			KGOLDDBHIFN().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 287f, 931f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GHICDLBKEJN()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -9);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void CNHEENCFCMF()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -46);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)88;
		}
		return BJFKDHHMLJH;
	}

	private void FINDGJLEHOL()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -44);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void LOOGLMFBJHK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 40);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
	}

	private void OFIMMFHFHDD()
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
}
