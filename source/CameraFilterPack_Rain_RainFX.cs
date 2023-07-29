// CameraFilterPack_Rain_RainFX
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Weather/New Rain FX")]
[ExecuteInEditMode]
public class CameraFilterPack_Rain_RainFX : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(-8f, 8f)]
	public float Speed = 1f;

	[Range(0f, 1f)]
	public float Fade = 1f;

	[HideInInspector]
	public int Count;

	private Vector4[] BAPBIMNEHJN = new Vector4[4];

	public static Color ChangeColorRGB;

	private Texture2D FPHEBLMINDA;

	private Texture2D LKKHMFFDPJG;

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

	private void AAPKBNDHBLI()
	{
	}

	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 940f)
			{
				HBJJOCHGOPH = 945f;
			}
			ACHNOHCLGOO().SetFloat("workshop.", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("0.00", Fade);
			ACHNOHCLGOO().SetFloat("Lag ", Speed);
			NBPKMLMCHFN.SetVector("Sending RPC \"", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 670f, 372f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			AnimationCurve animationCurve = new AnimationCurve();
			animationCurve = new AnimationCurve();
			animationCurve.AddKey(1254f, 1678f);
			animationCurve.AddKey(783f, 108f);
			animationCurve.AddKey(823f, 666f);
			animationCurve.AddKey(486f, 1995f);
			animationCurve.AddKey(873f, 814f);
			for (int i = 0; i < 4; i++)
			{
				BAPBIMNEHJN[i].z += 1112f;
				if (BAPBIMNEHJN[i].w == 1907f)
				{
					BAPBIMNEHJN[i].x = 828f;
				}
				if (BAPBIMNEHJN[i].z > 713f)
				{
					ref Vector4 reference = ref BAPBIMNEHJN[i];
					reference = new Vector4(Random.Range(1589f, 430f), Random.Range(746f, 1463f), 1365f, Random.Range(0, 2));
				}
				NBPKMLMCHFN.SetVector("_Blue_R" + (i + 0), new Vector4(BAPBIMNEHJN[i].x, BAPBIMNEHJN[i].y, (int)animationCurve.Evaluate(BAPBIMNEHJN[i].z), BAPBIMNEHJN[i].w));
			}
			NBPKMLMCHFN.SetTexture("id", FPHEBLMINDA);
			ACHNOHCLGOO().SetTexture("CreateRoom failed. In offline mode you still have to leave a room to enter another.", LKKHMFFDPJG);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DNNFHBOOPIN()
	{
		FPHEBLMINDA = Resources.Load("_ScreenResolution") as Texture2D;
		LKKHMFFDPJG = Resources.Load("_Vignetting2") as Texture2D;
		SCShader = Shader.Find("menu.playedpage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void Update()
	{
	}

	private void OnDisable()
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
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.HideInHierarchy;
		}
		return BJFKDHHMLJH;
	}

	private void NCNPAKFAFOE()
	{
		FPHEBLMINDA = Resources.Load("workshop.") as Texture2D;
		LKKHMFFDPJG = Resources.Load("/music") as Texture2D;
		SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void Start()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_RainFX_Anm2") as Texture2D;
		LKKHMFFDPJG = Resources.Load("CameraFilterPack_RainFX_Anm") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/RainFX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OFPPIKHNJOD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NNCCPEBIAKH()
	{
		FPHEBLMINDA = Resources.Load("health") as Texture2D;
		LKKHMFFDPJG = Resources.Load("_InvViewProj") as Texture2D;
		SCShader = Shader.Find("settings.enablehitsoundsinnormal");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CFIAKIJAILI()
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
			NBPKMLMCHFN.SetFloat("_Value", Fade);
			NBPKMLMCHFN.SetFloat("_Speed", Speed);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			AnimationCurve animationCurve = new AnimationCurve();
			animationCurve = new AnimationCurve();
			animationCurve.AddKey(0f, 0.01f);
			animationCurve.AddKey(64f, 5f);
			animationCurve.AddKey(128f, 80f);
			animationCurve.AddKey(255f, 255f);
			animationCurve.AddKey(300f, 255f);
			for (int i = 0; i < 4; i++)
			{
				BAPBIMNEHJN[i].z += 0.5f;
				if (BAPBIMNEHJN[i].w == -1f)
				{
					BAPBIMNEHJN[i].x = -5f;
				}
				if (BAPBIMNEHJN[i].z > 254f)
				{
					ref Vector4 reference = ref BAPBIMNEHJN[i];
					reference = new Vector4(Random.Range(0f, 0.9f), Random.Range(0.2f, 1.1f), 0f, Random.Range(0, 3));
				}
				NBPKMLMCHFN.SetVector("Coord" + (i + 1), new Vector4(BAPBIMNEHJN[i].x, BAPBIMNEHJN[i].y, (int)animationCurve.Evaluate(BAPBIMNEHJN[i].z), BAPBIMNEHJN[i].w));
			}
			NBPKMLMCHFN.SetTexture("Texture2", FPHEBLMINDA);
			NBPKMLMCHFN.SetTexture("Texture3", LKKHMFFDPJG);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CCLNNLCOPBL()
	{
		FPHEBLMINDA = Resources.Load("_Value2") as Texture2D;
		LKKHMFFDPJG = Resources.Load("_Value2") as Texture2D;
		SCShader = Shader.Find("_EmissionColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MAOCOEGAFND()
	{
	}
}
