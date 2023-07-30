// CameraFilterPack_Vision_Hell_Blood
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Vision/Hell_Blood")]
public class CameraFilterPack_Vision_Hell_Blood : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 1f)]
	public float Hole_Size = 0.57f;

	[Range(0f, 0.5f)]
	public float Hole_Smooth = 0.362f;

	[Range(-2f, 2f)]
	public float Hole_Speed = 0.85f;

	[Range(-10f, 10f)]
	public float Intensity = 0.24f;

	public Color ColorBlood = new Color(1f, 0f, 0f, 1f);

	[Range(-1f, 1f)]
	public float BloodAlternative1;

	[Range(-1f, 1f)]
	public float BloodAlternative2;

	[Range(-1f, 1f)]
	public float BloodAlternative3 = -1f;

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

	[SpecialName]
	private Material LNLKMDPHDCC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void PHJLHCMCCKE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NPLCENPNJBM()
	{
		SCShader = Shader.Find(".icon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NNCCPEBIAKH()
	{
		SCShader = Shader.Find("CameraFilterPack/Vision_Hell_Blood");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PAKPHKPDKGE()
	{
		SCShader = Shader.Find("roomDescription");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HGDDCINLDAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IDIIELPAMCJ()
	{
	}

	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 332f)
			{
				HBJJOCHGOPH = 1594f;
			}
			DBOLLHHMKKN().SetFloat("maps.", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("_OffsetScale", Hole_Size);
			HNICHJCGJOC().SetFloat(" ", Hole_Smooth);
			EPCGJFCCAFH().SetFloat("_Intensity", Hole_Speed * 1146f);
			EFDEIFCDAFG().SetColor("cameramovements:", ColorBlood);
			EFDEIFCDAFG().SetFloat("_TimeX", Intensity);
			HNICHJCGJOC().SetFloat("misses", BloodAlternative1);
			LNLKMDPHDCC().SetFloat("The region arrays from Name Server are not ok. Must be non-null and same length. ", BloodAlternative2);
			ADBKPGFMNKO().SetFloat("_Value4", BloodAlternative3);
			LNLKMDPHDCC().SetVector("LevelInfoInputField", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 532f, 924f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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

	private void Update()
	{
	}

	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1843f)
			{
				HBJJOCHGOPH = 497f;
			}
			HNICHJCGJOC().SetFloat("_Value", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("CameraFilterPack/TV_Distorted", Hole_Size);
			HNICHJCGJOC().SetFloat("FinalScoreText", Hole_Smooth);
			LNLKMDPHDCC().SetFloat("Select", Hole_Speed * 1815f);
			LNLKMDPHDCC().SetColor("settings.enablehitsoundsinnormal", ColorBlood);
			EFDEIFCDAFG().SetFloat("[Left]", Intensity);
			IONHGBPGCHK().SetFloat("MapEnd", BloodAlternative1);
			DBOLLHHMKKN().SetFloat("default", BloodAlternative2);
			DBOLLHHMKKN().SetFloat("Lightning", BloodAlternative3);
			ADBKPGFMNKO().SetVector("SaveButton", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 96f, 896f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MMBPLGGLPDB()
	{
	}

	private void AGEJKLMJGDO()
	{
		SCShader = Shader.Find("_FinalReflectionTexture");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 785f)
			{
				HBJJOCHGOPH = 1618f;
			}
			HFBJAOFLCJI().SetFloat("Value", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("resource id", Hole_Size);
			LNLKMDPHDCC().SetFloat("Fade", Hole_Smooth);
			DBOLLHHMKKN().SetFloat("R2", Hole_Speed * 758f);
			DBOLLHHMKKN().SetColor("color", ColorBlood);
			EPCGJFCCAFH().SetFloat("SetCrosshairColor", Intensity);
			EPCGJFCCAFH().SetFloat("BadgeText", BloodAlternative1);
			IONHGBPGCHK().SetFloat("_Value2", BloodAlternative2);
			HNICHJCGJOC().SetFloat("JoinOrCreateRoom failed. In offline mode you still have to leave a room to enter another.", BloodAlternative3);
			IONHGBPGCHK().SetVector("EVENT CONFIG [Ctrl+E]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 675f, 1049f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DBOLLHHMKKN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-107);
		}
		return BJFKDHHMLJH;
	}

	private void CNGAJDBOCLJ()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OCCGJMPAJIK()
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
			NBPKMLMCHFN.SetFloat("_Value", Hole_Size);
			NBPKMLMCHFN.SetFloat("_Value2", Hole_Smooth);
			NBPKMLMCHFN.SetFloat("_Value3", Hole_Speed * 15f);
			NBPKMLMCHFN.SetColor("ColorBlood", ColorBlood);
			NBPKMLMCHFN.SetFloat("_Value4", Intensity);
			NBPKMLMCHFN.SetFloat("BloodAlternative1", BloodAlternative1);
			NBPKMLMCHFN.SetFloat("BloodAlternative2", BloodAlternative2);
			NBPKMLMCHFN.SetFloat("BloodAlternative3", BloodAlternative3);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EPEGAEGDJAM()
	{
		SCShader = Shader.Find("music.ogg");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material HNICHJCGJOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void KLILJHJNICK()
	{
		SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material EFDEIFCDAFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-73);
		}
		return BJFKDHHMLJH;
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Vision_Hell_Blood");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BGDPIHMAACO()
	{
		SCShader = Shader.Find("EventSystem");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material HFBJAOFLCJI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideAndDontSave;
		}
		return BJFKDHHMLJH;
	}

	private void FDPOFMCFBMF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FBMDHDBELEK()
	{
	}

	private void BGFJOEPFOPM()
	{
	}

	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 28f)
			{
				HBJJOCHGOPH = 1144f;
			}
			NBPKMLMCHFN.SetFloat("menutheme", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("Lerp speed. Recomended 10", Hole_Size);
			ADBKPGFMNKO().SetFloat("_Brightness", Hole_Smooth);
			LNLKMDPHDCC().SetFloat("The binding '", Hole_Speed * 117f);
			LNLKMDPHDCC().SetColor("UpperMid", ColorBlood);
			LNLKMDPHDCC().SetFloat("_TimeX", Intensity);
			EFDEIFCDAFG().SetFloat(".lastCheckpoint.lives", BloodAlternative1);
			HNICHJCGJOC().SetFloat("Ownership mode == fixed. Ignoring request.", BloodAlternative2);
			NBPKMLMCHFN.SetFloat("Populate Mesh Data", BloodAlternative3);
			HNICHJCGJOC().SetVector("LB", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 826f, 1510f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AEIJFLJEABG()
	{
	}

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-73);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material EPCGJFCCAFH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void NKLIHNJCHOG()
	{
	}

	[SpecialName]
	private Material ADBKPGFMNKO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-96);
		}
		return BJFKDHHMLJH;
	}

	private void GAOOPEEBGJA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}
}
