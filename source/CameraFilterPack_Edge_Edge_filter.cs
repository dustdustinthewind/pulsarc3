// CameraFilterPack_Edge_Edge_filter
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Edge/Edge_filter")]
[ExecuteInEditMode]
public class CameraFilterPack_Edge_Edge_filter : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 10f)]
	public float RedAmplifier;

	[Range(0f, 10f)]
	public float GreenAmplifier = 2f;

	[Range(0f, 10f)]
	public float BlueAmplifier;

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

	private void HMNLHMLILKD()
	{
	}

	private void HGDDCINLDAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
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

	private void JHPOIOELNCG()
	{
	}

	[SpecialName]
	private Material HEHKGPKLAKK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void JDGFCEPDKAJ()
	{
	}

	private void OFPPIKHNJOD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PAKPHKPDKGE()
	{
		SCShader = Shader.Find("shader.crispwinter");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OBAEDJJDCPN()
	{
	}

	private void BFEILOMHNPC()
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

	private void LPMINJJPDCH()
	{
	}

	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1629f)
			{
				HBJJOCHGOPH = 61f;
			}
			IIJMIPBMMBF().SetFloat("_TimeX", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("_TimeX", RedAmplifier);
			NBMPPNFKFLB().SetFloat("Creating new item...", GreenAmplifier);
			IIJMIPBMMBF().SetFloat("_Vignette", BlueAmplifier);
			KBOPGONOCNP().SetVector("Tab1Content", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ODAIMOJLJOF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material LDNADDJMIPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1470f)
			{
				HBJJOCHGOPH = 1088f;
			}
			KBOPGONOCNP().SetFloat("CameraFilterPack/Blend2Camera_SoftLight", HBJJOCHGOPH);
			LDNADDJMIPK().SetFloat("_FixDistance", RedAmplifier);
			KBOPGONOCNP().SetFloat("Mid", GreenAmplifier);
			GKILCDHJFEG().SetFloat("_Value2", BlueAmplifier);
			NBPKMLMCHFN.SetVector("MapEnd", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material IIJMIPBMMBF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-89);
		}
		return BJFKDHHMLJH;
	}

	private void JHJFBCFBKLD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 993f)
			{
				HBJJOCHGOPH = 737f;
			}
			LONNIJMNKFB().SetFloat(".status", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("_ScreenResolution", RedAmplifier);
			NBMPPNFKFLB().SetFloat("CameraFilterPack/TV_Rgb", GreenAmplifier);
			LDNADDJMIPK().SetFloat("sfxVolume", BlueAmplifier);
			KBOPGONOCNP().SetVector("CameraFilterPack/BlurTiltShift", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material EMDFHOKEGNG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)86;
		}
		return BJFKDHHMLJH;
	}

	private void EAHCLIEEJOG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LIEGJOHINGC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material KEMAALEODNH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy;
		}
		return BJFKDHHMLJH;
	}

	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 22f)
			{
				HBJJOCHGOPH = 1137f;
			}
			KEMAALEODNH().SetFloat("_Value2", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("_Value2", RedAmplifier);
			IIJMIPBMMBF().SetFloat("/icon", GreenAmplifier);
			NBMPPNFKFLB().SetFloat("checkpoint", BlueAmplifier);
			KBOPGONOCNP().SetVector("_ScreenResolution", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 961f)
			{
				HBJJOCHGOPH = 1107f;
			}
			GKILCDHJFEG().SetFloat("_TimeX", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("Items/", RedAmplifier);
			EMDFHOKEGNG().SetFloat("_Skybox", GreenAmplifier);
			GKILCDHJFEG().SetFloat("_NumberOfWaves", BlueAmplifier);
			HEHKGPKLAKK().SetVector("CameraFilterPack/FX_Dot_Circle", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KDMKDEKCELE()
	{
		SCShader = Shader.Find("DPADHOR");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CIPKEPDELJB()
	{
		SCShader = Shader.Find("_ReflectionBlur");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BEBNOKFLJPH()
	{
		SCShader = Shader.Find("restrictions\n\n#until: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
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
	private Material NBMPPNFKFLB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material LONNIJMNKFB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)94;
		}
		return BJFKDHHMLJH;
	}

	private void NBGIMIDICKE()
	{
		SCShader = Shader.Find("UseFinalGlassColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 123f)
			{
				HBJJOCHGOPH = 1565f;
			}
			KBOPGONOCNP().SetFloat("score:", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("_LutTex", RedAmplifier);
			HEHKGPKLAKK().SetFloat(": ", GreenAmplifier);
			KBOPGONOCNP().SetFloat("speed", BlueAmplifier);
			NBMPPNFKFLB().SetVector("BitsData", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EHCGBJDFMHG()
	{
	}

	private void AGMJDGHLBMN()
	{
	}

	private void NAOLAJPDGIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Edge_Edge_filter");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-120);
		}
		return BJFKDHHMLJH;
	}

	private void DFENCIHAADO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1947f)
			{
				HBJJOCHGOPH = 1404f;
			}
			EMDFHOKEGNG().SetFloat("PAUSE [SPACE]", HBJJOCHGOPH);
			LDNADDJMIPK().SetFloat("_Red_R", RedAmplifier);
			NBMPPNFKFLB().SetFloat("Chat", GreenAmplifier);
			HEHKGPKLAKK().SetFloat(" not found", BlueAmplifier);
			IIJMIPBMMBF().SetVector("<start_index> <end_index>", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
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
			NBPKMLMCHFN.SetFloat("_RedAmplifier", RedAmplifier);
			NBPKMLMCHFN.SetFloat("_GreenAmplifier", GreenAmplifier);
			NBPKMLMCHFN.SetFloat("_BlueAmplifier", BlueAmplifier);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MMMDPANNAIO()
	{
		SCShader = Shader.Find("The given 2D texture ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BMOFEBKGLFI()
	{
		SCShader = Shader.Find("[EditorEvent] Exception: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CBIBDOIBJAI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DLBODOFAJGM()
	{
		SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1743f)
			{
				HBJJOCHGOPH = 1091f;
			}
			IIJMIPBMMBF().SetFloat("_TimeX", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("id", RedAmplifier);
			KEMAALEODNH().SetFloat("_MatrixSpeed", GreenAmplifier);
			KBOPGONOCNP().SetFloat("Save level before uploading?", BlueAmplifier);
			GKILCDHJFEG().SetVector("_Intervale", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material GKILCDHJFEG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1628f)
			{
				HBJJOCHGOPH = 1620f;
			}
			LDNADDJMIPK().SetFloat("player.gamecompleted", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("JoinOrCreateRoom failed. A roomname is required. If you don't know one, how will you join?", RedAmplifier);
			HEHKGPKLAKK().SetFloat("Mouse", GreenAmplifier);
			KBOPGONOCNP().SetFloat(":", BlueAmplifier);
			NBPKMLMCHFN.SetVector("_TimeX", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1054f)
			{
				HBJJOCHGOPH = 353f;
			}
			NBMPPNFKFLB().SetFloat("Uploading content...", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("\" to target: ", RedAmplifier);
			GKILCDHJFEG().SetFloat("SetBGColor", GreenAmplifier);
			LDNADDJMIPK().SetFloat("SpawnObj", BlueAmplifier);
			LONNIJMNKFB().SetVector("https://steamcommunity.com/sharedfiles/filedetails/?id=", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1009f)
			{
				HBJJOCHGOPH = 1427f;
			}
			EMDFHOKEGNG().SetFloat("No regions available. Are you sure your appid is valid and setup?", HBJJOCHGOPH);
			LDNADDJMIPK().SetFloat("Failed to 'GetKeyCode' for key: ", RedAmplifier);
			NBPKMLMCHFN.SetFloat("#no", GreenAmplifier);
			LONNIJMNKFB().SetFloat("finished", BlueAmplifier);
			LONNIJMNKFB().SetVector("roomDescription", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
