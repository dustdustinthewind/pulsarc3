// CameraFilterPack_Glasses_On_5
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Glasses/Futuristic Montain")]
[ExecuteInEditMode]
public class CameraFilterPack_Glasses_On_5 : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	[Range(0f, 1f)]
	public float Fade = 0.2f;

	[Range(0f, 0.1f)]
	public float VisionBlur = 0.005f;

	public Color GlassesColor = new Color(0.1f, 0.1f, 0.1f, 1f);

	public Color GlassesColor2 = new Color(0.45f, 0.45f, 0.45f, 0.25f);

	[Range(0f, 1f)]
	public float GlassDistortion = 0.6f;

	[Range(0f, 1f)]
	public float GlassAberration = 0.3f;

	[Range(0f, 1f)]
	public float UseFinalGlassColor;

	[Range(0f, 1f)]
	public float UseScanLine = 0.4f;

	[Range(1f, 512f)]
	public float UseScanLineSize = 358f;

	public Color GlassColor = new Color(0.1f, 0.3f, 1f, 1f);

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

	private void BEBNOKFLJPH()
	{
		FPHEBLMINDA = Resources.Load("?") as Texture2D;
		SCShader = Shader.Find("#ok");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JOACBIEHHCE()
	{
	}

	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 867f)
			{
				HBJJOCHGOPH = 531f;
			}
			NBPKMLMCHFN.SetFloat(".lastCheckpoint.correctScore", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat(": ", UseFinalGlassColor);
			NBPKMLMCHFN.SetFloat("_AdaptParams", Fade);
			NBPKMLMCHFN.SetFloat("--------------------------------", VisionBlur);
			HNICHJCGJOC().SetFloat("mapselector.filter.officialsortmode", GlassDistortion);
			HHIFMIPPMPF().SetFloat("#no", GlassAberration);
			NBPKMLMCHFN.SetColor("No font defined. Found font: ", GlassesColor);
			KGOLDDBHIFN().SetColor("Chat", GlassesColor2);
			OIMMPLPBLBK().SetColor("_Value1", GlassColor);
			HNICHJCGJOC().SetFloat("_Red_B", UseScanLineSize);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/VHS_Tracking", UseScanLine);
			OIMMPLPBLBK().SetTexture("quit", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HFBJAOFLCJI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)66;
		}
		return BJFKDHHMLJH;
	}

	private void Update()
	{
	}

	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 860f)
			{
				HBJJOCHGOPH = 123f;
			}
			HHIFMIPPMPF().SetFloat("_BaseTex", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("PunRespawn", UseFinalGlassColor);
			NBPKMLMCHFN.SetFloat("_Far", Fade);
			HHIFMIPPMPF().SetFloat("Joined Room. isMasterClient: ", VisionBlur);
			HNICHJCGJOC().SetFloat("Drop_Far", GlassDistortion);
			HFBJAOFLCJI().SetFloat("closed", GlassAberration);
			HHIFMIPPMPF().SetColor("CameraFilterPack/TV_WideScreenCircle", GlassesColor);
			HFBJAOFLCJI().SetColor("_TimeX", GlassesColor2);
			OIMMPLPBLBK().SetColor("float,1", GlassColor);
			HFBJAOFLCJI().SetFloat("_NoiseScale", UseScanLineSize);
			HHIFMIPPMPF().SetFloat("_ScreenResolution", UseScanLine);
			KGOLDDBHIFN().SetTexture("CameraFilterPack/Retro_Loading", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KDMANOEMOCA()
	{
		FPHEBLMINDA = Resources.Load("Editor/") as Texture2D;
		SCShader = Shader.Find("Joystick1Button3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1772f)
			{
				HBJJOCHGOPH = 582f;
			}
			HHIFMIPPMPF().SetFloat("_Value", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("_FullResolutionFiltering", UseFinalGlassColor);
			HFBJAOFLCJI().SetFloat("Called GetNumberOfCurrentPlayers()", Fade);
			HHIFMIPPMPF().SetFloat("_Bullet_8", VisionBlur);
			HNICHJCGJOC().SetFloat("_EmissionGain", GlassDistortion);
			HHIFMIPPMPF().SetFloat("player.redlifering", GlassAberration);
			HFBJAOFLCJI().SetColor("Set satellite radius (offset)", GlassesColor);
			NBPKMLMCHFN.SetColor("_Value3", GlassesColor2);
			HFBJAOFLCJI().SetColor(": ", GlassColor);
			HNICHJCGJOC().SetFloat("<color=#{0}>{1}</color>", UseScanLineSize);
			HHIFMIPPMPF().SetFloat("mapselector.filter.subscribedonly", UseScanLine);
			HNICHJCGJOC().SetTexture("yesterday", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FABKIGNFECE()
	{
	}

	private void CIPKEPDELJB()
	{
		FPHEBLMINDA = Resources.Load("Fill") as Texture2D;
		SCShader = Shader.Find("Beat Detected");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void Start()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_Glasses_On6") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Glasses_On");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LEAHIBJDMBI()
	{
	}

	private void KLILJHJNICK()
	{
		FPHEBLMINDA = Resources.Load("Internal LUT") as Texture2D;
		SCShader = Shader.Find("image");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LLJLDLLNFBH()
	{
	}

	[SpecialName]
	private Material KGOLDDBHIFN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-114);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HHIFMIPPMPF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void OnDisable()
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
			NBPKMLMCHFN.SetFloat("UseFinalGlassColor", UseFinalGlassColor);
			NBPKMLMCHFN.SetFloat("Fade", Fade);
			NBPKMLMCHFN.SetFloat("VisionBlur", VisionBlur);
			NBPKMLMCHFN.SetFloat("GlassDistortion", GlassDistortion);
			NBPKMLMCHFN.SetFloat("GlassAberration", GlassAberration);
			NBPKMLMCHFN.SetColor("GlassesColor", GlassesColor);
			NBPKMLMCHFN.SetColor("GlassesColor2", GlassesColor2);
			NBPKMLMCHFN.SetColor("GlassColor", GlassColor);
			NBPKMLMCHFN.SetFloat("UseScanLineSize", UseScanLineSize);
			NBPKMLMCHFN.SetFloat("UseScanLine", UseScanLine);
			NBPKMLMCHFN.SetTexture("_MainTex2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CCLNNLCOPBL()
	{
		FPHEBLMINDA = Resources.Load("[LevelEditorScene] Print Audio Wave: Start") as Texture2D;
		SCShader = Shader.Find("CompletedLevel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JOJFHFHOCHO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HNICHJCGJOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 525f)
			{
				HBJJOCHGOPH = 837f;
			}
			KGOLDDBHIFN().SetFloat("Texture2", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat(" beatThreshold: ", UseFinalGlassColor);
			KGOLDDBHIFN().SetFloat(" region", Fade);
			OIMMPLPBLBK().SetFloat("#ok", VisionBlur);
			HNICHJCGJOC().SetFloat("_TimeX", GlassDistortion);
			HFBJAOFLCJI().SetFloat("Sending RPC \"", GlassAberration);
			HNICHJCGJOC().SetColor("Object ID. Case-Sensitive", GlassesColor);
			HHIFMIPPMPF().SetColor(".lastCheckpoint.incorrectScore", GlassesColor2);
			HFBJAOFLCJI().SetColor("_Value3", GlassColor);
			KGOLDDBHIFN().SetFloat("float,0.5", UseScanLineSize);
			HFBJAOFLCJI().SetFloat("quit", UseScanLine);
			HHIFMIPPMPF().SetTexture("st", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ONMGIPAILOH()
	{
	}

	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 927f)
			{
				HBJJOCHGOPH = 792f;
			}
			NBPKMLMCHFN.SetFloat("_TimeX", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("Received OnSerialization for view ID ", UseFinalGlassColor);
			KGOLDDBHIFN().SetFloat("_Params1", Fade);
			OIMMPLPBLBK().SetFloat("Gameplay/Base", VisionBlur);
			KGOLDDBHIFN().SetFloat("New resource ID. Case-Sensitive", GlassDistortion);
			KGOLDDBHIFN().SetFloat("{0} hours ago", GlassAberration);
			HFBJAOFLCJI().SetColor("UndoButton", GlassesColor);
			NBPKMLMCHFN.SetColor("_Blend", GlassesColor2);
			HNICHJCGJOC().SetColor("ready", GlassColor);
			OIMMPLPBLBK().SetFloat("Horizontal", UseScanLineSize);
			HNICHJCGJOC().SetFloat("offsets", UseScanLine);
			HHIFMIPPMPF().SetTexture("steamid", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1258f)
			{
				HBJJOCHGOPH = 535f;
			}
			HNICHJCGJOC().SetFloat("Map id for", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("Editor", UseFinalGlassColor);
			HFBJAOFLCJI().SetFloat("_TileMaxOffs", Fade);
			KGOLDDBHIFN().SetFloat("_History1ChromaTex", VisionBlur);
			NBPKMLMCHFN.SetFloat("EventData0DropDownList", GlassDistortion);
			OIMMPLPBLBK().SetFloat("buttons", GlassAberration);
			HFBJAOFLCJI().SetColor("MenuScene", GlassesColor);
			KGOLDDBHIFN().SetColor("_Value8", GlassesColor2);
			KGOLDDBHIFN().SetColor("player.xp", GlassColor);
			HHIFMIPPMPF().SetFloat("#getrewardnow ", UseScanLineSize);
			HNICHJCGJOC().SetFloat("note.7", UseScanLine);
			HFBJAOFLCJI().SetTexture(" ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EGEPLFGKGLI()
	{
		FPHEBLMINDA = Resources.Load("PLEASE WAIT") as Texture2D;
		SCShader = Shader.Find(".lastCheckpoint.lives");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material OIMMPLPBLBK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
		}
		return BJFKDHHMLJH;
	}

	private void CNGAJDBOCLJ()
	{
		FPHEBLMINDA = Resources.Load("bans.viewed.") as Texture2D;
		SCShader = Shader.Find(". Set PhotonNetwork.OnEventCall.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
