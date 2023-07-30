// CameraFilterPack_Color_Switching
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Colors/Switching")]
public class CameraFilterPack_Color_Switching : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 5f)]
	public int Color = 1;

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
	private Material ADBKPGFMNKO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)70;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KGOLDDBHIFN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void BGDPIHMAACO()
	{
		SCShader = Shader.Find("[SERVER] Kicked ");
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

	private void BGDONBMDPGM()
	{
	}

	private void KDMANOEMOCA()
	{
		SCShader = Shader.Find("player.playedtutorial");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 520f)
			{
				HBJJOCHGOPH = 435f;
			}
			DEFBJOCJJKF().SetFloat("w", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("SetSpeed", Color);
			DEFBJOCJJKF().SetVector("time", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1981f, 1488f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DNNFHBOOPIN()
	{
		SCShader = Shader.Find("#ok");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GPHPJIDGEPI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NPLCENPNJBM()
	{
		SCShader = Shader.Find("inventory.selected.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JILOMOBDPIA()
	{
		SCShader = Shader.Find("BitsData");
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

	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1462f)
			{
				HBJJOCHGOPH = 1767f;
			}
			NBPKMLMCHFN.SetFloat("z", HBJJOCHGOPH);
			ADBKPGFMNKO().SetFloat("_Offsets", Color);
			ADBKPGFMNKO().SetVector("SupportLogger OnApplicationPause: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 586f, 1397f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EDBEHEKMGFH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 910f)
			{
				HBJJOCHGOPH = 289f;
			}
			HHIFMIPPMPF().SetFloat("_SmoothEnd", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("#turnoninternet", Color);
			ADBKPGFMNKO().SetVector(". The group number should be at least 1.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 187f, 1971f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DEFBJOCJJKF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	private void JBNPEHMDCMI()
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
			NBPKMLMCHFN.SetFloat("_Distortion", Color);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FDPOFMCFBMF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BMODOIJGIOO()
	{
	}

	private void HMPGIFBJFIK()
	{
		SCShader = Shader.Find("menu.selectedplaymode");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1550f)
			{
				HBJJOCHGOPH = 558f;
			}
			DEFBJOCJJKF().SetFloat("_TimeX", HBJJOCHGOPH);
			ADBKPGFMNKO().SetFloat(": ", Color);
			DEFBJOCJJKF().SetVector("Editor/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 974f, 877f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DLBODOFAJGM()
	{
		SCShader = Shader.Find("The server address is 127.0.0.1 (localhost): Make sure the server is running on this machine. Android and iOS emulators have their own localhost.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KCDOMIJBFLL()
	{
	}

	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 750f)
			{
				HBJJOCHGOPH = 666f;
			}
			KAFBNOBOIAJ().SetFloat("_Skybox", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("LevelEditor/CustomEventEditor-Text", Color);
			IONHGBPGCHK().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1367f, 366f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HLDFOJMHKNL()
	{
	}

	private void EAHCLIEEJOG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 75f)
			{
				HBJJOCHGOPH = 129f;
			}
			IONHGBPGCHK().SetFloat("_Intensity", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("_ScreenResolution", Color);
			ADBKPGFMNKO().SetVector("_Skybox", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 971f, 264f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
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

	private void DFENCIHAADO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1089f)
			{
				HBJJOCHGOPH = 1622f;
			}
			IONHGBPGCHK().SetFloat("Freq: ", HBJJOCHGOPH);
			ADBKPGFMNKO().SetFloat(")", Color);
			NBPKMLMCHFN.SetVector("[", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 14f, 513f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	[SpecialName]
	private Material KAFBNOBOIAJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)100;
		}
		return BJFKDHHMLJH;
	}

	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1188f)
			{
				HBJJOCHGOPH = 478f;
			}
			IONHGBPGCHK().SetFloat("Brightness", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("_TimeX", Color);
			NBPKMLMCHFN.SetVector("fade in duration", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1116f, 178f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 856f)
			{
				HBJJOCHGOPH = 1754f;
			}
			KGOLDDBHIFN().SetFloat("_Parasite", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat(".lastCheckpoint.time", Color);
			IONHGBPGCHK().SetVector("Overlay", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1479f, 1021f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 397f)
			{
				HBJJOCHGOPH = 1409f;
			}
			DEFBJOCJJKF().SetFloat("UseScanLine", HBJJOCHGOPH);
			ADBKPGFMNKO().SetFloat("caret", Color);
			DEFBJOCJJKF().SetVector("_Red_G", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1806f, 1839f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LPMINJJPDCH()
	{
	}

	[SpecialName]
	private Material HHIFMIPPMPF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-86);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)72;
		}
		return BJFKDHHMLJH;
	}

	private void CCLNNLCOPBL()
	{
		SCShader = Shader.Find("MenuScene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Color_Switching");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
