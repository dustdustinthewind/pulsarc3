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
			DBOLLHHMKKN().SetFloat("_TimeX", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("_Visualize", Size);
			NBPKMLMCHFN.SetFloat(" not exist", Speed);
			KBOPGONOCNP().SetFloat("bool", PosX);
			NBPKMLMCHFN.SetFloat("grid", PosY);
			LONNIJMNKFB().SetFloat("menu.playedpage", Intensity);
			DNLMFEGJJDD().SetVector("SupportLogger OnFailedToConnectToPhoton(", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 976f, 1751f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
		SCShader = Shader.Find("_Linecount");
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
		SCShader = Shader.Find("SetupEncryption() called but ignored. Not XB1 compiled. EncryptionData: ");
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
			KBOPGONOCNP().SetFloat(".a", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("distance", Size);
			NBPKMLMCHFN.SetFloat("Reconnect() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", Speed);
			DBOLLHHMKKN().SetFloat("/", PosX);
			KBOPGONOCNP().SetFloat("#useticket", PosY);
			KBOPGONOCNP().SetFloat(".played", Intensity);
			KBOPGONOCNP().SetVector("_Value4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 836f, 1816f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
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
		SCShader = Shader.Find("GameObject ");
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
			NBPKMLMCHFN.SetFloat("[PlayerController] ", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Distortion_Twist_Square", Size);
			NBPKMLMCHFN.SetFloat(". Sent by actorNr: ", Speed);
			LONNIJMNKFB().SetFloat("#", PosX);
			KOHGPKOFEJO().SetFloat("_Value", PosY);
			DBOLLHHMKKN().SetFloat("float,0", Intensity);
			LONNIJMNKFB().SetVector("_EmissionColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1330f, 1687f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
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
			KOHGPKOFEJO().SetFloat("EndlessLoopsScoreText", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_RampOffset", Size);
			NBPKMLMCHFN.SetFloat("RecordButton", Speed);
			DNLMFEGJJDD().SetFloat("EventSystem", PosX);
			EFDEIFCDAFG().SetFloat("\" gets executed locally only, if at all.", PosY);
			KBOPGONOCNP().SetFloat("maps.", Intensity);
			EFDEIFCDAFG().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 460f, 1879f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JKFDDNMPOJH()
	{
		SCShader = Shader.Find("Mouse2");
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
		SCShader = Shader.Find(" is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package.");
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
			LONNIJMNKFB().SetFloat("_ColorBuffer", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("\n", Size);
			LONNIJMNKFB().SetFloat(".", Speed);
			KOHGPKOFEJO().SetFloat("_ScreenResolution", PosX);
			LONNIJMNKFB().SetFloat("maps.", PosY);
			DNLMFEGJJDD().SetFloat("_Value3", Intensity);
			KOHGPKOFEJO().SetVector("ScreenResolutionPanel", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 157f, 366f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
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
			LONNIJMNKFB().SetFloat("Apr", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("_Offsets", Size);
			DBOLLHHMKKN().SetFloat("_SampleScale", Speed);
			DBOLLHHMKKN().SetFloat("JoinRandom failed: {0}.", PosX);
			NBPKMLMCHFN.SetFloat("maps.", PosY);
			KOHGPKOFEJO().SetFloat("[PhotonMessageInfo: Sender='{1}' Senttime={0}]", Intensity);
			EFDEIFCDAFG().SetVector("_Parameter", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1290f, 6f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KOHGPKOFEJO());
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
			NBPKMLMCHFN.SetFloat("_Value5", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat("???", Size);
			LONNIJMNKFB().SetFloat("_ScreenResolution", Speed);
			KOHGPKOFEJO().SetFloat("_Bloom3", PosX);
			EFDEIFCDAFG().SetFloat("_Contrast", PosY);
			DNLMFEGJJDD().SetFloat("Image", Intensity);
			DNLMFEGJJDD().SetVector("ScoreText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 149f, 1307f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
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
			DBOLLHHMKKN().SetFloat("--------------------------------", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("_Value5", Size);
			KOHGPKOFEJO().SetFloat("Malformed RPC; this should never occur. Content: ", Speed);
			EFDEIFCDAFG().SetFloat("GroupNameText", PosX);
			EFDEIFCDAFG().SetFloat("_MainTex2", PosY);
			KOHGPKOFEJO().SetFloat("_Heigh", Intensity);
			KBOPGONOCNP().SetVector(" is muted", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 323f, 835f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KOHGPKOFEJO());
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
			KOHGPKOFEJO().SetFloat("DPADVER", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("settings.volume.editor", Size);
			EFDEIFCDAFG().SetFloat("help", Speed);
			KBOPGONOCNP().SetFloat("maps.", PosX);
			KBOPGONOCNP().SetFloat("_ScreenResolution", PosY);
			KOHGPKOFEJO().SetFloat("_TimeX", Intensity);
			DBOLLHHMKKN().SetVector("_EmissionColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 668f, 566f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			EFDEIFCDAFG().SetFloat("g", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("yyyy-MM-dd HH:mm:ss", Size);
			DBOLLHHMKKN().SetFloat("ChatHistoryInputField", Speed);
			DNLMFEGJJDD().SetFloat("CameraFilterPack/Gradients_Hue", PosX);
			DBOLLHHMKKN().SetFloat("LostAllLives", PosY);
			NBPKMLMCHFN.SetFloat("[MapEditor] Created new map: ", Intensity);
			DBOLLHHMKKN().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1938f, 94f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
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
