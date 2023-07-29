// CameraFilterPack_Fly_Vision
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Vision/Fly_Vision")]
[ExecuteInEditMode]
public class CameraFilterPack_Fly_Vision : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0.04f, 1.5f)]
	public float Zoom = 0.25f;

	[Range(0f, 1f)]
	public float Distortion = 0.4f;

	[Range(0f, 1f)]
	public float Fade = 0.4f;

	[Range(0f, 10f)]
	private float CCIENBFIKKH = 1f;

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

	private void BGDPIHMAACO()
	{
		FPHEBLMINDA = Resources.Load("Item ") as Texture2D;
		SCShader = Shader.Find("Skipping packet for ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LLJLDLLNFBH()
	{
	}

	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1848f)
			{
				HBJJOCHGOPH = 745f;
			}
			LONNIJMNKFB().SetFloat("TRACKING", HBJJOCHGOPH);
			JIBOKBCPDLC().SetFloat("0,2,true,0", Zoom);
			LONNIJMNKFB().SetFloat(".lastCheckpoint.powerupsScore", Distortion);
			LONNIJMNKFB().SetFloat("SaveButton", Fade);
			LONNIJMNKFB().SetFloat("SetSatelliteSensitivity", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("Testing, the group has toggled [", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1870f, 1994f));
			JIBOKBCPDLC().SetTexture("AuthenticationValues UserId: {0}, GetParameters: {1} Token available: {2}", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OCMKCBBCEFG()
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
			NBPKMLMCHFN.SetFloat("_Value", Zoom);
			NBPKMLMCHFN.SetFloat("_Value2", Distortion);
			NBPKMLMCHFN.SetFloat("_Value3", Fade);
			NBPKMLMCHFN.SetFloat("_Value4", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			NBPKMLMCHFN.SetTexture("Texture2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FKEJGBFDCAH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EGEPLFGKGLI()
	{
		FPHEBLMINDA = Resources.Load("_ChangeGreen") as Texture2D;
		SCShader = Shader.Find(".");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NPLCENPNJBM()
	{
		FPHEBLMINDA = Resources.Load("EventMenu") as Texture2D;
		SCShader = Shader.Find("https://vk.com/khb.soft");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BNEJMABFKJE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Update()
	{
	}

	private void JHLGHODFJOO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CFIAKIJAILI()
	{
	}

	private void AIJGAJIOJDJ()
	{
	}

	[SpecialName]
	private Material LONNIJMNKFB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-102);
		}
		return BJFKDHHMLJH;
	}

	private void CCLNNLCOPBL()
	{
		FPHEBLMINDA = Resources.Load("_ScreenResolution") as Texture2D;
		SCShader = Shader.Find(".GoalProgress");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KCDOMIJBFLL()
	{
	}

	private void LEAHIBJDMBI()
	{
	}

	[SpecialName]
	private Material JIBOKBCPDLC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-124);
		}
		return BJFKDHHMLJH;
	}

	private void NCNPAKFAFOE()
	{
		FPHEBLMINDA = Resources.Load("_FixDistance") as Texture2D;
		SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void Start()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_Fly_VisionFX") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Fly_Vision");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1721f)
			{
				HBJJOCHGOPH = 1160f;
			}
			JIBOKBCPDLC().SetFloat("FPSToggle", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("Copy from ", Zoom);
			NBPKMLMCHFN.SetFloat("JoinRoom failed (room maybe closed by now). Client stays on masterserver: {0}. State: {1}", Distortion);
			JIBOKBCPDLC().SetFloat("ERROR You should never change PhotonPlayer IDs!", Fade);
			NBPKMLMCHFN.SetFloat(",", CCIENBFIKKH);
			LONNIJMNKFB().SetVector("CameraFilterPack/Real_VHS", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1f, 828f));
			JIBOKBCPDLC().SetTexture("Joystick1Button9", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DPFOEBCADNP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 800f)
			{
				HBJJOCHGOPH = 1739f;
			}
			JIBOKBCPDLC().SetFloat(": ", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("_TimeX", Zoom);
			LONNIJMNKFB().SetFloat("VisionBlur", Distortion);
			JIBOKBCPDLC().SetFloat("_Value", Fade);
			LONNIJMNKFB().SetFloat("_Value6", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("_Greenness", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1361f, 794f));
			NBPKMLMCHFN.SetTexture("menu.enableselectormusic", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OFPPIKHNJOD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 43f)
			{
				HBJJOCHGOPH = 639f;
			}
			NBPKMLMCHFN.SetFloat("Drop_Far", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("Hidden/Fast Approximate Anti-aliasing", Zoom);
			LONNIJMNKFB().SetFloat("_Value", Distortion);
			JIBOKBCPDLC().SetFloat("_ScreenResolution", Fade);
			JIBOKBCPDLC().SetFloat(".lastCheckpoint.checkpointsUsed", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1837f, 372f));
			JIBOKBCPDLC().SetTexture("LevelURLInputField", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CIPKEPDELJB()
	{
		FPHEBLMINDA = Resources.Load("MainCamera") as Texture2D;
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
