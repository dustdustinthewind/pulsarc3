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
		FPHEBLMINDA = Resources.Load("ItemTemplate") as Texture2D;
		SCShader = Shader.Find(" with prefix ");
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
			JIBOKBCPDLC().SetFloat("VHS2", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("0,2,true,0", Zoom);
			JIBOKBCPDLC().SetFloat("maps.", Distortion);
			LONNIJMNKFB().SetFloat("SaveButton", Fade);
			NBPKMLMCHFN.SetFloat("SetSatelliteSensitivity", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("Is it practically possible?", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1870f, 1994f));
			LONNIJMNKFB().SetTexture("TypedLobbyInfo '{0}'[{1}] rooms: {2} players: {3}", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
		FPHEBLMINDA = Resources.Load("_ChangeRed") as Texture2D;
		SCShader = Shader.Find("_EmissionColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NPLCENPNJBM()
	{
		FPHEBLMINDA = Resources.Load("HelpMenu") as Texture2D;
		SCShader = Shader.Find("https://twitch.tv/intralism");
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
		SCShader = Shader.Find(".icon");
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
		SCShader = Shader.Find("[Down]");
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
			JIBOKBCPDLC().SetFloat("Scene", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat(".", Zoom);
			NBPKMLMCHFN.SetFloat("Skipping region because it's not in PhotonServerSettings.EnabledRegions: ", Distortion);
			JIBOKBCPDLC().SetFloat("Could not execute RPC ", Fade);
			JIBOKBCPDLC().SetFloat(",", CCIENBFIKKH);
			LONNIJMNKFB().SetVector("Texture3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1f, 828f));
			LONNIJMNKFB().SetTexture("View", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
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
			NBPKMLMCHFN.SetFloat("[PlayerController] ", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Light_Rainbow2", Zoom);
			JIBOKBCPDLC().SetFloat("Fade", Distortion);
			NBPKMLMCHFN.SetFloat("_TimeX", Fade);
			LONNIJMNKFB().SetFloat("_Value5", CCIENBFIKKH);
			LONNIJMNKFB().SetVector("_OnOff", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1361f, 794f));
			JIBOKBCPDLC().SetTexture("SelectorMusicToggle", FPHEBLMINDA);
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
			JIBOKBCPDLC().SetFloat("Drop_Far", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_TargetScale", Zoom);
			JIBOKBCPDLC().SetFloat("_Value", Distortion);
			LONNIJMNKFB().SetFloat("_Value2", Fade);
			NBPKMLMCHFN.SetFloat(".lastCheckpoint.correctScore", CCIENBFIKKH);
			JIBOKBCPDLC().SetVector(".png", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1837f, 372f));
			JIBOKBCPDLC().SetTexture("ConfigVersionSlider", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CIPKEPDELJB()
	{
		FPHEBLMINDA = Resources.Load("Left") as Texture2D;
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
