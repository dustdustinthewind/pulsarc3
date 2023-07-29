// CameraFilterPack_AAA_Blood_Hit
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/AAA/Blood_Hit")]
[ExecuteInEditMode]
public class CameraFilterPack_AAA_Blood_Hit : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	[Range(0f, 1f)]
	public float Hit_Left = 1f;

	[Range(0f, 1f)]
	public float Hit_Up;

	[Range(0f, 1f)]
	public float Hit_Right;

	[Range(0f, 1f)]
	public float Hit_Down;

	[Range(0f, 1f)]
	public float Blood_Hit_Left;

	[Range(0f, 1f)]
	public float Blood_Hit_Up;

	[Range(0f, 1f)]
	public float Blood_Hit_Right;

	[Range(0f, 1f)]
	public float Blood_Hit_Down;

	[Range(0f, 1f)]
	public float Hit_Full;

	[Range(0f, 1f)]
	public float Blood_Hit_Full_1;

	[Range(0f, 1f)]
	public float Blood_Hit_Full_2;

	[Range(0f, 1f)]
	public float Blood_Hit_Full_3;

	[Range(0f, 1f)]
	public float LightReflect = 0.5f;

	private Material BJFKDHHMLJH;

	private Texture2D FPHEBLMINDA;

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

	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 844f)
			{
				HBJJOCHGOPH = 907f;
			}
			ADBKPGFMNKO().SetFloat("request", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("float,1.5", LightReflect);
			NBPKMLMCHFN.SetFloat(" x ", Mathf.Clamp(Hit_Left, 1403f, 1910f));
			ACHNOHCLGOO().SetFloat("_TimeX", Mathf.Clamp(Hit_Up, 1337f, 1740f));
			NBPKMLMCHFN.SetFloat("Objects in List: ", Mathf.Clamp(Hit_Right, 683f, 1702f));
			ADBKPGFMNKO().SetFloat(".sav", Mathf.Clamp(Hit_Down, 546f, 1156f));
			ADBKPGFMNKO().SetFloat("intensity", Mathf.Clamp(Blood_Hit_Left, 1668f, 397f));
			ACHNOHCLGOO().SetFloat("Checkpoint", Mathf.Clamp(Blood_Hit_Up, 110f, 945f));
			NBPKMLMCHFN.SetFloat("Set Crosshair Color", Mathf.Clamp(Blood_Hit_Right, 1549f, 1272f));
			ADBKPGFMNKO().SetFloat("settings.volume.sfx", Mathf.Clamp(Blood_Hit_Down, 986f, 390f));
			ADBKPGFMNKO().SetFloat("Square", Mathf.Clamp(Hit_Full, 971f, 558f));
			NBPKMLMCHFN.SetFloat("inventory.selected.", Mathf.Clamp(Blood_Hit_Full_1, 1594f, 693f));
			ADBKPGFMNKO().SetFloat("SelectorMusicToggle", Mathf.Clamp(Blood_Hit_Full_2, 1137f, 375f));
			ADBKPGFMNKO().SetFloat("#tryagain", Mathf.Clamp(Blood_Hit_Full_3, 35f, 800f));
			ADBKPGFMNKO().SetTexture("CameraFilterPack/Drawing_Curve", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
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
			BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return BJFKDHHMLJH;
	}

	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1142f)
			{
				HBJJOCHGOPH = 682f;
			}
			ADBKPGFMNKO().SetFloat("FPSToggle", HBJJOCHGOPH);
			ADBKPGFMNKO().SetFloat("_History3Weight", LightReflect);
			ACHNOHCLGOO().SetFloat("CameraFilterPack/Edge_Sigmoid", Mathf.Clamp(Hit_Left, 1976f, 85f));
			ADBKPGFMNKO().SetFloat("CameraFilterPack/Glasses_OnX", Mathf.Clamp(Hit_Up, 1857f, 559f));
			NBPKMLMCHFN.SetFloat("_BlurTex", Mathf.Clamp(Hit_Right, 227f, 1204f));
			ACHNOHCLGOO().SetFloat("_Distortion2", Mathf.Clamp(Hit_Down, 1874f, 1836f));
			ADBKPGFMNKO().SetFloat("_Value2", Mathf.Clamp(Blood_Hit_Left, 1811f, 817f));
			ADBKPGFMNKO().SetFloat("CameraFilterPack_3D_Myst1", Mathf.Clamp(Blood_Hit_Up, 785f, 1489f));
			NBPKMLMCHFN.SetFloat("CameraFilterPack_3D_Myst1", Mathf.Clamp(Blood_Hit_Right, 873f, 1431f));
			ACHNOHCLGOO().SetFloat("editorVolume", Mathf.Clamp(Blood_Hit_Down, 752f, 972f));
			NBPKMLMCHFN.SetFloat("_TimeX", Mathf.Clamp(Hit_Full, 1029f, 1264f));
			NBPKMLMCHFN.SetFloat("GlassAberration", Mathf.Clamp(Blood_Hit_Full_1, 817f, 1427f));
			ADBKPGFMNKO().SetFloat("_BlurVector", Mathf.Clamp(Blood_Hit_Full_2, 1839f, 1711f));
			ACHNOHCLGOO().SetFloat("_ScreenResolution", Mathf.Clamp(Blood_Hit_Full_3, 1786f, 1482f));
			ACHNOHCLGOO().SetTexture("CameraFilterPack/Atmosphere_Rain", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
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
			NBPKMLMCHFN.SetFloat("_Value", LightReflect);
			NBPKMLMCHFN.SetFloat("_Value2", Mathf.Clamp(Hit_Left, 0f, 1f));
			NBPKMLMCHFN.SetFloat("_Value3", Mathf.Clamp(Hit_Up, 0f, 1f));
			NBPKMLMCHFN.SetFloat("_Value4", Mathf.Clamp(Hit_Right, 0f, 1f));
			NBPKMLMCHFN.SetFloat("_Value5", Mathf.Clamp(Hit_Down, 0f, 1f));
			NBPKMLMCHFN.SetFloat("_Value6", Mathf.Clamp(Blood_Hit_Left, 0f, 1f));
			NBPKMLMCHFN.SetFloat("_Value7", Mathf.Clamp(Blood_Hit_Up, 0f, 1f));
			NBPKMLMCHFN.SetFloat("_Value8", Mathf.Clamp(Blood_Hit_Right, 0f, 1f));
			NBPKMLMCHFN.SetFloat("_Value9", Mathf.Clamp(Blood_Hit_Down, 0f, 1f));
			NBPKMLMCHFN.SetFloat("_Value10", Mathf.Clamp(Hit_Full, 0f, 1f));
			NBPKMLMCHFN.SetFloat("_Value11", Mathf.Clamp(Blood_Hit_Full_1, 0f, 1f));
			NBPKMLMCHFN.SetFloat("_Value12", Mathf.Clamp(Blood_Hit_Full_2, 0f, 1f));
			NBPKMLMCHFN.SetFloat("_Value13", Mathf.Clamp(Blood_Hit_Full_3, 0f, 1f));
			NBPKMLMCHFN.SetTexture("_MainTex2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1294f)
			{
				HBJJOCHGOPH = 770f;
			}
			NBPKMLMCHFN.SetFloat("</color>", HBJJOCHGOPH);
			ADBKPGFMNKO().SetFloat("_FadeShield", LightReflect);
			ADBKPGFMNKO().SetFloat("\r", Mathf.Clamp(Hit_Left, 149f, 1229f));
			ADBKPGFMNKO().SetFloat("_XCrop", Mathf.Clamp(Hit_Up, 995f, 523f));
			ACHNOHCLGOO().SetFloat("_ScreenResolution", Mathf.Clamp(Hit_Right, 1971f, 1618f));
			ACHNOHCLGOO().SetFloat("Couldn't color correct with 3D LUT texture. Image Effect will be disabled.", Mathf.Clamp(Hit_Down, 1864f, 507f));
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Blend2Camera_Darken", Mathf.Clamp(Blood_Hit_Left, 477f, 264f));
			NBPKMLMCHFN.SetFloat("\n", Mathf.Clamp(Blood_Hit_Up, 589f, 374f));
			NBPKMLMCHFN.SetFloat("_Far", Mathf.Clamp(Blood_Hit_Right, 1854f, 932f));
			ACHNOHCLGOO().SetFloat("_Blue_B", Mathf.Clamp(Blood_Hit_Down, 962f, 1821f));
			ADBKPGFMNKO().SetFloat("_BorderColor", Mathf.Clamp(Hit_Full, 179f, 582f));
			NBPKMLMCHFN.SetFloat("settings.volume.menu", Mathf.Clamp(Blood_Hit_Full_1, 1030f, 262f));
			ADBKPGFMNKO().SetFloat("RemoveEnvironmentObject", Mathf.Clamp(Blood_Hit_Full_2, 54f, 1254f));
			NBPKMLMCHFN.SetFloat("[ImageLoader] Loaded image from ", Mathf.Clamp(Blood_Hit_Full_3, 1703f, 244f));
			ADBKPGFMNKO().SetTexture("MainButton", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CFIAKIJAILI()
	{
	}

	private void Update()
	{
	}

	private void DIPDEHOOBPG()
	{
		FPHEBLMINDA = Resources.Load("NameInfoText") as Texture2D;
		SCShader = Shader.Find("PenaltyScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GPHPJIDGEPI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Start()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_AAA_Blood_Hit1") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/AAA_Blood_Hit");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 977f)
			{
				HBJJOCHGOPH = 1572f;
			}
			NBPKMLMCHFN.SetFloat("_Value4", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat(" beatThreshold: ", LightReflect);
			ADBKPGFMNKO().SetFloat("_BlueAmplifier", Mathf.Clamp(Hit_Left, 1417f, 1620f));
			ADBKPGFMNKO().SetFloat("hand", Mathf.Clamp(Hit_Up, 471f, 1245f));
			NBPKMLMCHFN.SetFloat("setfloat", Mathf.Clamp(Hit_Right, 281f, 1810f));
			ACHNOHCLGOO().SetFloat("Can't set open when not in that room.", Mathf.Clamp(Hit_Down, 1756f, 574f));
			NBPKMLMCHFN.SetFloat("_ScreenResolution", Mathf.Clamp(Blood_Hit_Left, 688f, 1789f));
			ADBKPGFMNKO().SetFloat("_Distortion", Mathf.Clamp(Blood_Hit_Up, 1005f, 1349f));
			ADBKPGFMNKO().SetFloat("offsets", Mathf.Clamp(Blood_Hit_Right, 674f, 1987f));
			ADBKPGFMNKO().SetFloat("LevelNameText", Mathf.Clamp(Blood_Hit_Down, 66f, 916f));
			NBPKMLMCHFN.SetFloat("_Value4", Mathf.Clamp(Hit_Full, 1661f, 1318f));
			ACHNOHCLGOO().SetFloat("_TimeX", Mathf.Clamp(Blood_Hit_Full_1, 764f, 112f));
			ACHNOHCLGOO().SetFloat("_SunColor", Mathf.Clamp(Blood_Hit_Full_2, 68f, 1542f));
			ADBKPGFMNKO().SetFloat("Solo", Mathf.Clamp(Blood_Hit_Full_3, 1022f, 660f));
			ACHNOHCLGOO().SetTexture("_LutTex", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material ADBKPGFMNKO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void NCNPAKFAFOE()
	{
		FPHEBLMINDA = Resources.Load("Registered PhotonView: ") as Texture2D;
		SCShader = Shader.Find("HighScaleShot");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}
}
