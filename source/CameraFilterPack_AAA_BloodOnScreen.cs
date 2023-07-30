// CameraFilterPack_AAA_BloodOnScreen
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/AAA/Blood On Screen")]
public class CameraFilterPack_AAA_BloodOnScreen : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	[Range(0.02f, 1.6f)]
	public float Blood_On_Screen = 1f;

	public Color Blood_Color = Color.red;

	[Range(0f, 2f)]
	public float Blood_Intensify = 0.7f;

	[Range(0f, 2f)]
	public float Blood_Darkness = 0.5f;

	[Range(0f, 1f)]
	public float Blood_Distortion_Speed = 0.25f;

	[Range(0f, 1f)]
	public float Blood_Fade = 1f;

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

	private void CCLNNLCOPBL()
	{
		FPHEBLMINDA = Resources.Load("LoadMapCanvas") as Texture2D;
		SCShader = Shader.Find("Hidden/DepthOfField/MedianFilter");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JHPOIOELNCG()
	{
	}

	private void JHJGJJKELJM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LLJLDLLNFBH()
	{
	}

	[SpecialName]
	private Material DBOLLHHMKKN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)69;
		}
		return BJFKDHHMLJH;
	}

	private void IMCKJCHKMKB()
	{
		FPHEBLMINDA = Resources.Load("_TimeX") as Texture2D;
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material ACHNOHCLGOO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void PAKPHKPDKGE()
	{
		FPHEBLMINDA = Resources.Load("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data") as Texture2D;
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1792f)
			{
				HBJJOCHGOPH = 474f;
			}
			DBOLLHHMKKN().SetFloat("event", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("Mar", Mathf.Clamp(Blood_On_Screen, 1000f, 1844f));
			NBPKMLMCHFN.SetFloat("Connection error: ", Mathf.Clamp(Blood_Intensify, 1796f, 201f));
			NBPKMLMCHFN.SetFloat("_ThirdTex", Mathf.Clamp(Blood_Darkness, 4f, 1773f));
			DBOLLHHMKKN().SetFloat("note.2", Mathf.Clamp(Blood_Fade, 114f, 1077f));
			NBPKMLMCHFN.SetFloat("SetPosition", Mathf.Clamp(Blood_Distortion_Speed, 1580f, 1245f));
			NBPKMLMCHFN.SetColor("LevelEditor/CustomEventEditor-", Blood_Color);
			ADBKPGFMNKO().SetTexture("_DotSize", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Start()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_AAA_BloodOnScreen1") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/AAA_BloodOnScreen");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material PLBEJJIHFPB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)95;
		}
		return BJFKDHHMLJH;
	}

	private void OFPPIKHNJOD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AEIJFLJEABG()
	{
	}

	private void CFIAKIJAILI()
	{
	}

	private void NNCCPEBIAKH()
	{
		FPHEBLMINDA = Resources.Load("player.licenceaccepted") as Texture2D;
		SCShader = Shader.Find("_Factor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material ADBKPGFMNKO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)89;
		}
		return BJFKDHHMLJH;
	}

	private void GHILDCBCDJI()
	{
	}

	private void GAOOPEEBGJA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FIKFJDFELIP()
	{
		FPHEBLMINDA = Resources.Load(" Remote called.") as Texture2D;
		SCShader = Shader.Find("Using WebSocket to connect NameServer (AuthMode is AuthOnceWss).");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DLMPALHKMON()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material LONNIJMNKFB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)100;
		}
		return BJFKDHHMLJH;
	}

	private void Update()
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
			NBPKMLMCHFN.SetFloat("_Value", Mathf.Clamp(Blood_On_Screen, 0.02f, 1.6f));
			NBPKMLMCHFN.SetFloat("_Value2", Mathf.Clamp(Blood_Intensify, 0f, 2f));
			NBPKMLMCHFN.SetFloat("_Value3", Mathf.Clamp(Blood_Darkness, 0f, 2f));
			NBPKMLMCHFN.SetFloat("_Value4", Mathf.Clamp(Blood_Fade, 0f, 1f));
			NBPKMLMCHFN.SetFloat("_Value5", Mathf.Clamp(Blood_Distortion_Speed, 0f, 2f));
			NBPKMLMCHFN.SetColor("_Color2", Blood_Color);
			NBPKMLMCHFN.SetTexture("_MainTex2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JHLGHODFJOO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}
}
