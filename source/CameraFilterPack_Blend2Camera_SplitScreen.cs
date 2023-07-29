// CameraFilterPack_Blend2Camera_SplitScreen
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Split Screen/SideBySide")]
[ExecuteInEditMode]
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
				ACHNOHCLGOO().SetTexture("_Value4", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat("CameraFilterPack/3D_BlackHole", HBJJOCHGOPH);
			LDNADDJMIPK().SetFloat(" timeUntilRespawn: ", BlendFX);
			LDNADDJMIPK().SetFloat("GlassAberration", SwitchCameraToCamera2);
			ACHNOHCLGOO().SetFloat("CameraFilterPack/FX_Glitch3", SplitX);
			ACHNOHCLGOO().SetFloat("max. lives color", SplitY);
			ACHNOHCLGOO().SetFloat("_MainTex2", Smooth);
			NBPKMLMCHFN.SetFloat("0.00", Rotation);
			LDNADDJMIPK().SetInt("_TimeX", (!CONEELGCALI) ? 1 : 1);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EMAMCDFBGOA()
	{
		Start();
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
				ACHNOHCLGOO().SetTexture("_ScreenResolution", JDMCFBKJHDD);
			}
			ACHNOHCLGOO().SetFloat("shader.future", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat("a minute ago", BlendFX);
			ACHNOHCLGOO().SetFloat("_Value4", SwitchCameraToCamera2);
			NBPKMLMCHFN.SetFloat("/", SplitX);
			ACHNOHCLGOO().SetFloat("GhostFade2", SplitY);
			LDNADDJMIPK().SetFloat("_TimeX", Smooth);
			ACHNOHCLGOO().SetFloat("skin.", Rotation);
			LDNADDJMIPK().SetInt("#activechallenges", CONEELGCALI ? 1 : 0);
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
				ACHNOHCLGOO().SetTexture("RarityImage", JDMCFBKJHDD);
			}
			LDNADDJMIPK().SetFloat("colorA", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat("_TimeX", BlendFX);
			ACHNOHCLGOO().SetFloat("config.txt", SwitchCameraToCamera2);
			ACHNOHCLGOO().SetFloat("SelectorMapsCountSlider", SplitX);
			LDNADDJMIPK().SetFloat("_EmissionGain", SplitY);
			ACHNOHCLGOO().SetFloat("_U", Smooth);
			LDNADDJMIPK().SetFloat("Case-Sensitive", Rotation);
			NBPKMLMCHFN.SetInt("_TimeX", (!CONEELGCALI) ? 1 : 0);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
				NBPKMLMCHFN.SetTexture("UsernameText", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat("InfoCanvas", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat("finished", BlendFX);
			NBPKMLMCHFN.SetFloat("ok", SwitchCameraToCamera2);
			LDNADDJMIPK().SetFloat("musicVolume", SplitX);
			NBPKMLMCHFN.SetFloat("Error: Someone else(", SplitY);
			NBPKMLMCHFN.SetFloat(" isOwnerActive: ", Smooth);
			NBPKMLMCHFN.SetFloat("[MapsEditor] Creating new item...", Rotation);
			LDNADDJMIPK().SetInt("Right", CONEELGCALI ? 1 : 0);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
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
		NNCCPEBIAKH();
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
		BGDPIHMAACO();
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
			NBPKMLMCHFN.SetFloat("_ToneCurve", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", BlendFX);
			NBPKMLMCHFN.SetFloat("_Value5", SwitchCameraToCamera2);
			NBPKMLMCHFN.SetFloat(" could not be executed (yet). Wait for state JoinedLobby or ConnectedToMaster and their callbacks before calling operations. WebRPCs need a server-side configuration. Enum OperationCode helps identify the operation.", SplitX);
			ACHNOHCLGOO().SetFloat("CameraFilterPack/Blend2Camera_LinearDodge", SplitY);
			LDNADDJMIPK().SetFloat("Paste events", Smooth);
			LDNADDJMIPK().SetFloat("player.xp", Rotation);
			LDNADDJMIPK().SetInt("\n", (!CONEELGCALI) ? 1 : 0);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
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
		BGDPIHMAACO();
	}

	private void GBFPAEDPOPP()
	{
		JKFDDNMPOJH();
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
		Start();
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
