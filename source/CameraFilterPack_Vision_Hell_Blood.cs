// CameraFilterPack_Vision_Hell_Blood
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Vision/Hell_Blood")]
[ExecuteInEditMode]
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
		SCShader = Shader.Find("?");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NNCCPEBIAKH()
	{
		SCShader = Shader.Find("_TimeX");
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
			HNICHJCGJOC().SetFloat("maps.", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_BlurRadius", Hole_Size);
			IONHGBPGCHK().SetFloat(" ", Hole_Smooth);
			EPCGJFCCAFH().SetFloat("colorB", Hole_Speed * 1146f);
			DBOLLHHMKKN().SetColor("settings.cameramovements", ColorBlood);
			HNICHJCGJOC().SetFloat("_TimeX", Intensity);
			LNLKMDPHDCC().SetFloat("replayData", BloodAlternative1);
			DBOLLHHMKKN().SetFloat("\n", BloodAlternative2);
			HNICHJCGJOC().SetFloat("_ScreenResolution", BloodAlternative3);
			HNICHJCGJOC().SetVector("LevelNameInputField", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 532f, 924f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
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
			NBPKMLMCHFN.SetFloat("_Value2", HBJJOCHGOPH);
			ADBKPGFMNKO().SetFloat("_TimeX", Hole_Size);
			ADBKPGFMNKO().SetFloat("FinalScoreText", Hole_Smooth);
			NBPKMLMCHFN.SetFloat("Joystick1Button9", Hole_Speed * 1815f);
			IONHGBPGCHK().SetColor("settings.enablehitsoundsinnormal", ColorBlood);
			EPCGJFCCAFH().SetFloat("[Left]", Intensity);
			EFDEIFCDAFG().SetFloat("SetBGColor", BloodAlternative1);
			DBOLLHHMKKN().SetFloat("Data/Skins/", BloodAlternative2);
			ADBKPGFMNKO().SetFloat("Lightning", BloodAlternative3);
			HFBJAOFLCJI().SetVector("SaveButton", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 96f, 896f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
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
		SCShader = Shader.Find("_RayStepSize");
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
			HNICHJCGJOC().SetFloat(" x ", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("resource id", Hole_Size);
			EPCGJFCCAFH().SetFloat("VisionBlur", Hole_Smooth);
			HFBJAOFLCJI().SetFloat("Select", Hole_Speed * 758f);
			ADBKPGFMNKO().SetColor("Start Color's hex value #RRGGBBAA", ColorBlood);
			ADBKPGFMNKO().SetFloat("Set Crosshair Color", Intensity);
			HFBJAOFLCJI().SetFloat("BadgeText", BloodAlternative1);
			NBPKMLMCHFN.SetFloat("_Value5", BloodAlternative2);
			HFBJAOFLCJI().SetFloat("JoinRandomRoom failed. In offline mode you still have to leave a room to enter another.", BloodAlternative3);
			NBPKMLMCHFN.SetVector("EVENT CONFIG [Ctrl+E]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 675f, 1049f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
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
		SCShader = Shader.Find("CameraFilterPack/Light_Rainbow");
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
		SCShader = Shader.Find("No Name");
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
		SCShader = Shader.Find("/../");
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
		SCShader = Shader.Find("Search: ");
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
			HFBJAOFLCJI().SetFloat("/", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("Lerp speed. Recomended 10", Hole_Size);
			LNLKMDPHDCC().SetFloat("_Saturation", Hole_Smooth);
			ADBKPGFMNKO().SetFloat("' has been reset to the fault value", Hole_Speed * 117f);
			NBPKMLMCHFN.SetColor("UpperMid", ColorBlood);
			LNLKMDPHDCC().SetFloat("_TimeX", Intensity);
			ADBKPGFMNKO().SetFloat(".lastCheckpoint.checkpointsUsed", BloodAlternative1);
			HNICHJCGJOC().SetFloat("Ev OwnershipTransfer. ViewID ", BloodAlternative2);
			ADBKPGFMNKO().SetFloat(" Also make sure to disable sprite packing for this sprite.", BloodAlternative3);
			IONHGBPGCHK().SetVector("RB", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 826f, 1510f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
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
