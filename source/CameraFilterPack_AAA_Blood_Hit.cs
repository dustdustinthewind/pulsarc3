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
			NBPKMLMCHFN.SetFloat("IntraSig", HBJJOCHGOPH);
			ADBKPGFMNKO().SetFloat("Zoom speed. Base 1.5", LightReflect);
			NBPKMLMCHFN.SetFloat("Value", Mathf.Clamp(Hit_Left, 1403f, 1910f));
			ACHNOHCLGOO().SetFloat("CameraFilterPack/FX_superDot", Mathf.Clamp(Hit_Up, 1337f, 1740f));
			ADBKPGFMNKO().SetFloat("ping: {6}[+/-{7}]ms resent:{8} \n\nmax ms between\nsend: {0,4} \ndispatch: {1,4} \n\nlongest dispatch for: \nev({3}):{2,3}ms \nop({5}):{4,3}ms", Mathf.Clamp(Hit_Right, 683f, 1702f));
			ACHNOHCLGOO().SetFloat("New SaveGame", Mathf.Clamp(Hit_Down, 546f, 1156f));
			ACHNOHCLGOO().SetFloat("offsets", Mathf.Clamp(Blood_Hit_Left, 1668f, 397f));
			NBPKMLMCHFN.SetFloat("ShowSprite", Mathf.Clamp(Blood_Hit_Up, 110f, 945f));
			ACHNOHCLGOO().SetFloat("SetCrosshairColor", Mathf.Clamp(Blood_Hit_Right, 1549f, 1272f));
			NBPKMLMCHFN.SetFloat("ItemNameText", Mathf.Clamp(Blood_Hit_Down, 986f, 390f));
			NBPKMLMCHFN.SetFloat("Joystick1Button0", Mathf.Clamp(Hit_Full, 971f, 558f));
			ACHNOHCLGOO().SetFloat("inventory.selected.", Mathf.Clamp(Blood_Hit_Full_1, 1594f, 693f));
			ACHNOHCLGOO().SetFloat("settings.disablestoryboard", Mathf.Clamp(Blood_Hit_Full_2, 1137f, 375f));
			ADBKPGFMNKO().SetFloat("Connection error: ", Mathf.Clamp(Blood_Hit_Full_3, 35f, 800f));
			ADBKPGFMNKO().SetTexture("CameraFilterPack/Drawing_Curve", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			NBPKMLMCHFN.SetFloat("Scene", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat("_History1Weight", LightReflect);
			ACHNOHCLGOO().SetFloat("_ScreenResolution", Mathf.Clamp(Hit_Left, 1976f, 85f));
			ACHNOHCLGOO().SetFloat("CameraFilterPack_Glasses_On3", Mathf.Clamp(Hit_Up, 1857f, 559f));
			NBPKMLMCHFN.SetFloat("_BlurPass", Mathf.Clamp(Hit_Right, 227f, 1204f));
			ACHNOHCLGOO().SetFloat("_Distortion", Mathf.Clamp(Hit_Down, 1874f, 1836f));
			ADBKPGFMNKO().SetFloat("_Value2", Mathf.Clamp(Blood_Hit_Left, 1811f, 817f));
			NBPKMLMCHFN.SetFloat("CameraFilterPack_3D_Myst1", Mathf.Clamp(Blood_Hit_Up, 785f, 1489f));
			ADBKPGFMNKO().SetFloat("CameraFilterPack_3D_Myst1", Mathf.Clamp(Blood_Hit_Right, 873f, 1431f));
			ACHNOHCLGOO().SetFloat("sfxVolume", Mathf.Clamp(Blood_Hit_Down, 752f, 972f));
			NBPKMLMCHFN.SetFloat("_TimeX", Mathf.Clamp(Hit_Full, 1029f, 1264f));
			ACHNOHCLGOO().SetFloat("GlassDistortion", Mathf.Clamp(Blood_Hit_Full_1, 817f, 1427f));
			ADBKPGFMNKO().SetFloat("_BlurVector", Mathf.Clamp(Blood_Hit_Full_2, 1839f, 1711f));
			NBPKMLMCHFN.SetFloat("_Value4", Mathf.Clamp(Blood_Hit_Full_3, 1786f, 1482f));
			NBPKMLMCHFN.SetTexture("CameraFilterPack/Atmosphere_Rain", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			NBPKMLMCHFN.SetFloat("#", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat("_FadeShield", LightReflect);
			ADBKPGFMNKO().SetFloat("\t", Mathf.Clamp(Hit_Left, 149f, 1229f));
			NBPKMLMCHFN.SetFloat("UI Extensions/UIAdditive", Mathf.Clamp(Hit_Up, 995f, 523f));
			NBPKMLMCHFN.SetFloat("_ScreenResolution", Mathf.Clamp(Hit_Right, 1971f, 1618f));
			NBPKMLMCHFN.SetFloat(" cannot be used as a 3D LUT.", Mathf.Clamp(Hit_Down, 1864f, 507f));
			ADBKPGFMNKO().SetFloat("CameraFilterPack/Blend2Camera_Darken", Mathf.Clamp(Blood_Hit_Left, 477f, 264f));
			NBPKMLMCHFN.SetFloat("\n", Mathf.Clamp(Blood_Hit_Up, 589f, 374f));
			ACHNOHCLGOO().SetFloat("_Near", Mathf.Clamp(Blood_Hit_Right, 1854f, 932f));
			NBPKMLMCHFN.SetFloat("_Blue_G", Mathf.Clamp(Blood_Hit_Down, 962f, 1821f));
			ACHNOHCLGOO().SetFloat("_BorderColor", Mathf.Clamp(Hit_Full, 179f, 582f));
			NBPKMLMCHFN.SetFloat("settings.showHP", Mathf.Clamp(Blood_Hit_Full_1, 1030f, 262f));
			ACHNOHCLGOO().SetFloat("RemoveEnvironmentObject", Mathf.Clamp(Blood_Hit_Full_2, 54f, 1254f));
			ADBKPGFMNKO().SetFloat("[FileSelector] Dialog canceled", Mathf.Clamp(Blood_Hit_Full_3, 1703f, 244f));
			NBPKMLMCHFN.SetTexture(" ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
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
		FPHEBLMINDA = Resources.Load("InfoText") as Texture2D;
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
			NBPKMLMCHFN.SetFloat("_Value3", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat(" beatThreshold: ", LightReflect);
			ADBKPGFMNKO().SetFloat("_GreenAmplifier", Mathf.Clamp(Hit_Left, 1417f, 1620f));
			ADBKPGFMNKO().SetFloat("hand", Mathf.Clamp(Hit_Up, 471f, 1245f));
			ADBKPGFMNKO().SetFloat(" : ", Mathf.Clamp(Hit_Right, 281f, 1810f));
			ACHNOHCLGOO().SetFloat("wss://", Mathf.Clamp(Hit_Down, 1756f, 574f));
			NBPKMLMCHFN.SetFloat("_Distortion", Mathf.Clamp(Blood_Hit_Left, 688f, 1789f));
			ACHNOHCLGOO().SetFloat("CameraFilterPack/TV_Old_Movie", Mathf.Clamp(Blood_Hit_Up, 1005f, 1349f));
			ACHNOHCLGOO().SetFloat("offsets", Mathf.Clamp(Blood_Hit_Right, 674f, 1987f));
			ACHNOHCLGOO().SetFloat("NameInfoText", Mathf.Clamp(Blood_Hit_Down, 66f, 916f));
			ACHNOHCLGOO().SetFloat("_Value3", Mathf.Clamp(Hit_Full, 1661f, 1318f));
			ACHNOHCLGOO().SetFloat("CameraFilterPack/Light_Rainbow2", Mathf.Clamp(Blood_Hit_Full_1, 764f, 112f));
			ADBKPGFMNKO().SetFloat("_BlurRadius4", Mathf.Clamp(Blood_Hit_Full_2, 68f, 1542f));
			ACHNOHCLGOO().SetFloat("Playing ", Mathf.Clamp(Blood_Hit_Full_3, 1022f, 660f));
			ACHNOHCLGOO().SetTexture(" cannot be used as a 3D LUT.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
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
		FPHEBLMINDA = Resources.Load("PhotonView register is ignored, because viewID is 0. No id assigned yet to: ") as Texture2D;
		SCShader = Shader.Find("HighScaleShot");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}
}
