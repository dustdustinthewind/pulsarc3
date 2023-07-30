// CameraFilterPack_Blend2Camera_SplitScreen
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Split Screen/SideBySide")]
public class CameraFilterPack_Blend2Camera_SplitScreen : MonoBehaviour
{
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_SplitScreen";

	public Shader SCShader;

	public Camera Camera2;

	private float HBJJOCHGOPH = 1f;

	private Material BJFKDHHMLJH;

	[Range(0f, 1f)]
	public float SwitchCameraToCamera2;

	[Range(0f, 1f)]
	public float BlendFX = 1f;

	[Range(-3f, 3f)]
	public float SplitX = 0.5f;

	[Range(-3f, 3f)]
	public float SplitY = 0.5f;

	[Range(0f, 2f)]
	public float Smooth = 0.1f;

	[Range(-3.14f, 3.14f)]
	public float Rotation = 3.14f;

	private bool CONEELGCALI;

	private RenderTexture JDMCFBKJHDD;

	private Vector2 FPEMMGKMJGA;

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

	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 548f)
			{
				HBJJOCHGOPH = 589f;
			}
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture("_Value2", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat("CameraFilterPack/3D_BlackHole", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Unknown player asked for PickupItems", BlendFX);
			NBPKMLMCHFN.SetFloat("GlassDistortion", SwitchCameraToCamera2);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", SplitX);
			NBPKMLMCHFN.SetFloat("max. lives color", SplitY);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Blend2Camera_GreenScreen", Smooth);
			NBPKMLMCHFN.SetFloat("AccuracyScoreText", Rotation);
			LDNADDJMIPK().SetInt("CameraFilterPack/Blizzard", (!CONEELGCALI) ? 1 : 1);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EMAMCDFBGOA()
	{
		NNCCPEBIAKH();
	}

	private void Update()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	[SpecialName]
	private Material ACHNOHCLGOO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)65;
		}
		return BJFKDHHMLJH;
	}

	private void BGDPIHMAACO()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 44);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EJJEDJIOFAB()
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

	private void LADCJEIALMH()
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

	private void FABMDEHEDNO()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void JHJGJJKELJM()
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

	private void LHBDPDOBNAK()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 579f)
			{
				HBJJOCHGOPH = 984f;
			}
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture("_ScreenResolution", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat("shader.future", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("{0} minutes ago", BlendFX);
			LDNADDJMIPK().SetFloat("_Value3", SwitchCameraToCamera2);
			ACHNOHCLGOO().SetFloat("[MapsData] Bad map: ", SplitX);
			LDNADDJMIPK().SetFloat("GhostFade2", SplitY);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/FX_Funk", Smooth);
			NBPKMLMCHFN.SetFloat("challenges/", Rotation);
			ACHNOHCLGOO().SetInt("<b>", CONEELGCALI ? 1 : 0);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KCDOMIJBFLL()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1724f)
			{
				HBJJOCHGOPH = 1106f;
			}
			if (Camera2 != null)
			{
				ACHNOHCLGOO().SetTexture("ItemNameText", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat("_ColorBuffer", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat("_TimeX", BlendFX);
			ACHNOHCLGOO().SetFloat("config.txt", SwitchCameraToCamera2);
			NBPKMLMCHFN.SetFloat("settings.arcshitsoundtimedelay", SplitX);
			NBPKMLMCHFN.SetFloat("_DiffuseColor", SplitY);
			NBPKMLMCHFN.SetFloat("_U", Smooth);
			LDNADDJMIPK().SetFloat("Case-Sensitive", Rotation);
			NBPKMLMCHFN.SetInt("CameraFilterPack/TV_Distorted", (!CONEELGCALI) ? 1 : 0);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
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

	private void PAKPHKPDKGE()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -11);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ECKEBMIMIGK()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void Start()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 24);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LIFBFDKFMMH()
	{
		BGDPIHMAACO();
	}

	private void NEKCPLGFOFD()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1207f)
			{
				HBJJOCHGOPH = 1536f;
			}
			if (Camera2 != null)
			{
				ACHNOHCLGOO().SetTexture("SpectatingUserInfo", JDMCFBKJHDD);
			}
			ACHNOHCLGOO().SetFloat("InfoText", HBJJOCHGOPH);
			LDNADDJMIPK().SetFloat("ResetButton", BlendFX);
			NBPKMLMCHFN.SetFloat("bad", SwitchCameraToCamera2);
			ACHNOHCLGOO().SetFloat("sfxVolume", SplitX);
			NBPKMLMCHFN.SetFloat(" to: ", SplitY);
			NBPKMLMCHFN.SetFloat(". ActorNr: ", Smooth);
			LDNADDJMIPK().SetFloat("#yes", Rotation);
			ACHNOHCLGOO().SetInt("GameScene", CONEELGCALI ? 1 : 0);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HGIMCCHIPCP()
	{
		JKFDDNMPOJH();
	}

	private void NNCCPEBIAKH()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 75);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OnValidate()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void MBNMADBPDLL()
	{
		PAKPHKPDKGE();
	}

	private void OnEnable()
	{
		Start();
	}

	private void HGDDCINLDAD()
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

	private void DHENLPJJOEN()
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

	private void ICDBMJKMIKC()
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

	private void OFBLDOCCBBN()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void MHGPANIBBCM()
	{
		NNCCPEBIAKH();
	}

	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1330f)
			{
				HBJJOCHGOPH = 1335f;
			}
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture("SpectateButton", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat("ENABLE_EYE_ADAPTATION", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat("_Value4", BlendFX);
			LDNADDJMIPK().SetFloat("_Value4", SwitchCameraToCamera2);
			ACHNOHCLGOO().SetFloat(". Stopping handling if inactive.", SplitX);
			LDNADDJMIPK().SetFloat("_ScreenResolution", SplitY);
			LDNADDJMIPK().SetFloat("bpmgrid", Smooth);
			NBPKMLMCHFN.SetFloat("player.xp", Rotation);
			ACHNOHCLGOO().SetInt("Needs to be attached to the Event System component in the scene", (!CONEELGCALI) ? 1 : 0);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JHPOIOELNCG()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
	}

	private void INGOODALACO()
	{
		JKFDDNMPOJH();
	}

	private void GBFPAEDPOPP()
	{
		BGDPIHMAACO();
	}

	private void JKFDDNMPOJH()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -101);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FBIIBKKCOKO()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
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
			NBPKMLMCHFN.SetFloat("_Value3", SplitX);
			NBPKMLMCHFN.SetFloat("_Value6", SplitY);
			NBPKMLMCHFN.SetFloat("_Value4", Smooth);
			NBPKMLMCHFN.SetFloat("_Value5", Rotation);
			NBPKMLMCHFN.SetInt("_ForceYSwap", (!CONEELGCALI) ? 1 : 0);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LDNADDJMIPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void OKHGJFFIIBA()
	{
		JKFDDNMPOJH();
	}

	private void PLIKADJCEPO()
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
