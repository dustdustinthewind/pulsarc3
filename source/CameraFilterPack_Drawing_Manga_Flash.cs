// CameraFilterPack_Drawing_Manga_Flash
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Drawing/Manga_Flash")]
[ExecuteInEditMode]
public class CameraFilterPack_Drawing_Manga_Flash : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(1f, 10f)]
	public float Size = 1f;

	[Range(0f, 30f)]
	public int Speed = 5;

	[Range(-1f, 1f)]
	public float PosX = 0.5f;

	[Range(-1f, 1f)]
	public float PosY = 0.5f;

	[Range(0f, 1f)]
	public float Intensity = 1f;

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

	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 415f)
			{
				HBJJOCHGOPH = 913f;
			}
			KBOPGONOCNP().SetFloat("_MainTex2", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("_Visualize", Size);
			EFDEIFCDAFG().SetFloat(": ", Speed);
			NBPKMLMCHFN.SetFloat("maps.", PosX);
			LONNIJMNKFB().SetFloat("grid", PosY);
			DNLMFEGJJDD().SetFloat("menu.playedpage", Intensity);
			KBOPGONOCNP().SetVector("Server: {0}. Region: {1} ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 976f, 1751f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)93;
		}
		return BJFKDHHMLJH;
	}

	private void EGEPLFGKGLI()
	{
		SCShader = Shader.Find("getbool");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JBCNIPJDPJB()
	{
	}

	[SpecialName]
	private Material DBOLLHHMKKN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void FBMDHDBELEK()
	{
	}

	private void GPNAOAKCMHC()
	{
		SCShader = Shader.Find("OxOD.lastPath");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CPAJLKHMOJB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JMEOGJHCONJ()
	{
		SCShader = Shader.Find("ExitButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CIPKEPDELJB()
	{
		SCShader = Shader.Find("_Vignette");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OEENOOGEEHD()
	{
	}

	private void NNFMIAFHMJM()
	{
		SCShader = Shader.Find("Warning: Unhandled event ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AAPKBNDHBLI()
	{
	}

	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1270f)
			{
				HBJJOCHGOPH = 899f;
			}
			DBOLLHHMKKN().SetFloat(".a", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("Set Player Distance", Size);
			NBPKMLMCHFN.SetFloat("Reconnect() failed. Can only connect while in state 'Disconnected'. Current state: ", Speed);
			KBOPGONOCNP().SetFloat(".wav", PosX);
			NBPKMLMCHFN.SetFloat("#failed: ", PosY);
			LONNIJMNKFB().SetFloat(".played", Intensity);
			DNLMFEGJJDD().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 836f, 1816f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
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

	private void EDBEHEKMGFH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OIBMHPIFAKK()
	{
	}

	private void HMPGIFBJFIK()
	{
		SCShader = Shader.Find("QuickSave");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LCJHDLKJEOM()
	{
	}

	private void GKNKIIEALCH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 468f)
			{
				HBJJOCHGOPH = 1970f;
			}
			LONNIJMNKFB().SetFloat(" not exist", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat("CameraFilterPack/Distortion_Twist_Square", Size);
			DBOLLHHMKKN().SetFloat("Ev DestroyAll! By PlayerId: ", Speed);
			KBOPGONOCNP().SetFloat("#orderby:", PosX);
			DNLMFEGJJDD().SetFloat("_TimeX", PosY);
			DNLMFEGJJDD().SetFloat("float,0", Intensity);
			KOHGPKOFEJO().SetVector("LevelEditor/icons", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1330f, 1687f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void POIMNOBDBBN()
	{
	}

	private void NJHJHBOJKIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1378f)
			{
				HBJJOCHGOPH = 26f;
			}
			DNLMFEGJJDD().SetFloat("EndlessLoopsScoreText", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("_MainTex", Size);
			DBOLLHHMKKN().SetFloat("#8E8E8EFF", Speed);
			KOHGPKOFEJO().SetFloat("EventSystem", PosX);
			NBPKMLMCHFN.SetFloat(". Possible scene loading in progress?", PosY);
			EFDEIFCDAFG().SetFloat("_EmissionColor", Intensity);
			EFDEIFCDAFG().SetVector("CameraFilterPack/Drawing_NewCellShading", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 460f, 1879f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JKFDDNMPOJH()
	{
		SCShader = Shader.Find("Mouse1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DOEPOGLEGLE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PAKPHKPDKGE()
	{
		SCShader = Shader.Find("The shader ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JAAJECBCCFM()
	{
	}

	private void JHPOIOELNCG()
	{
	}

	[SpecialName]
	private Material KOHGPKOFEJO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-96);
		}
		return BJFKDHHMLJH;
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
		SCShader = Shader.Find("CameraFilterPack/Drawing_Manga_Flash");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FPHLDMMAOEF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 598f)
			{
				HBJJOCHGOPH = 692f;
			}
			DNLMFEGJJDD().SetFloat("_SunColor", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("[EMPTY]", Size);
			NBPKMLMCHFN.SetFloat(".lastCheckpoint.playerdistance", Speed);
			LONNIJMNKFB().SetFloat("_ScreenResolution", PosX);
			LONNIJMNKFB().SetFloat("Map id for", PosY);
			KOHGPKOFEJO().SetFloat("_Value2", Intensity);
			DNLMFEGJJDD().SetVector("ScreenResolutionPanel", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 157f, 366f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LONNIJMNKFB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)65;
		}
		return BJFKDHHMLJH;
	}

	private void HONBLGFDMLL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IMGGCJICLHK()
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideAndDontSave | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 342f)
			{
				HBJJOCHGOPH = 616f;
			}
			DBOLLHHMKKN().SetFloat("Feb", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat("_Offsets", Size);
			NBPKMLMCHFN.SetFloat("_Curve", Speed);
			LONNIJMNKFB().SetFloat("JoinRoom failed (room maybe closed by now). Client stays on masterserver: {0}. State: {1}", PosX);
			EFDEIFCDAFG().SetFloat("#newhighscore", PosY);
			DBOLLHHMKKN().SetFloat("curScn", Intensity);
			KBOPGONOCNP().SetVector("_Parameter", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1290f, 6f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JOACBIEHHCE()
	{
	}

	private void OMCLOFCJMPG()
	{
	}

	private void JHLGHODFJOO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EHCGBJDFMHG()
	{
	}

	private void JOJFHFHOCHO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1915f)
			{
				HBJJOCHGOPH = 134f;
			}
			DNLMFEGJJDD().SetFloat("_Value5", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat(" item(s) in inventory", Size);
			KBOPGONOCNP().SetFloat("_Value2", Speed);
			KOHGPKOFEJO().SetFloat("_Bloom1", PosX);
			DNLMFEGJJDD().SetFloat("_Contrast", PosY);
			KOHGPKOFEJO().SetFloat("Item ", Intensity);
			DNLMFEGJJDD().SetVector("ScoreText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 149f, 1307f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GPHPJIDGEPI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material DNLMFEGJJDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void GJLKJAOBPJD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DHENLPJJOEN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Update()
	{
	}

	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1583f)
			{
				HBJJOCHGOPH = 1716f;
			}
			KOHGPKOFEJO().SetFloat("<b>Time</b>:", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat("_Value4", Size);
			KBOPGONOCNP().SetFloat("SetupEncryption() got called. ", Speed);
			KOHGPKOFEJO().SetFloat("Image", PosX);
			NBPKMLMCHFN.SetFloat("_MainTex2", PosY);
			EFDEIFCDAFG().SetFloat("_Heigh", Intensity);
			LONNIJMNKFB().SetVector(" is muted", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 323f, 835f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DFENCIHAADO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BGDONBMDPGM()
	{
	}

	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1498f)
			{
				HBJJOCHGOPH = 69f;
			}
			NBPKMLMCHFN.SetFloat("DPADVER", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("settings.volume.sfx", Size);
			DNLMFEGJJDD().SetFloat(" ", Speed);
			EFDEIFCDAFG().SetFloat("maps.", PosX);
			DBOLLHHMKKN().SetFloat("_ColorRGB", PosY);
			EFDEIFCDAFG().SetFloat("_TimeX", Intensity);
			EFDEIFCDAFG().SetVector("#,0.00", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 668f, 566f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 543f)
			{
				HBJJOCHGOPH = 1399f;
			}
			KOHGPKOFEJO().SetFloat(" in SaveLoadMenu.prefabDictionary!", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat("#,0.00", Size);
			NBPKMLMCHFN.SetFloat("ChatHistoryInputField", Speed);
			EFDEIFCDAFG().SetFloat("_ScreenResolution", PosX);
			KBOPGONOCNP().SetFloat("_DiffuseColor", PosY);
			NBPKMLMCHFN.SetFloat("Editor", Intensity);
			LONNIJMNKFB().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1938f, 94f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CGBHOELMAOC()
	{
	}

	private void BMODOIJGIOO()
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
			NBPKMLMCHFN.SetFloat("_Value", Size);
			NBPKMLMCHFN.SetFloat("_Value2", Speed);
			NBPKMLMCHFN.SetFloat("_Value3", PosX);
			NBPKMLMCHFN.SetFloat("_Value4", PosY);
			NBPKMLMCHFN.SetFloat("_Intensity", Intensity);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
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

	private void GHILDCBCDJI()
	{
	}
}
