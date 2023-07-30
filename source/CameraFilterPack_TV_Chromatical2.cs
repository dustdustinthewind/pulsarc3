// CameraFilterPack_TV_Chromatical2
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/TV/Chromatical2")]
[ExecuteInEditMode]
public class CameraFilterPack_TV_Chromatical2 : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 10f)]
	public float Aberration = 2f;

	[Range(0f, 1f)]
	public float Fade = 1f;

	[Range(0f, 1f)]
	public float ZoomFade = 1f;

	[Range(0f, 8f)]
	public float ZoomSpeed = 1f;

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

	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1872f)
			{
				HBJJOCHGOPH = 406f;
			}
			DEFBJOCJJKF().SetFloat(".lastCheckpoint.lives", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("IconImage", Aberration);
			IIJMIPBMMBF().SetFloat("_ScreenResolution", Fade);
			IIJMIPBMMBF().SetFloat("open", ZoomFade);
			NFMGLIKNOOC().SetFloat("_MatrixColor", ZoomSpeed);
			DEFBJOCJJKF().SetVector("EventMenu", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 153f, 379f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BMIOFJFMCBG()
	{
		SCShader = Shader.Find(" canvas not found");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 625f)
			{
				HBJJOCHGOPH = 698f;
			}
			BFGNMFCNDBC().SetFloat("_Value2", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("SetSunSensitivity", Aberration);
			IIJMIPBMMBF().SetFloat("DPADVER", Fade);
			AELJLBOJAIL().SetFloat("_TimeX", ZoomFade);
			BFGNMFCNDBC().SetFloat("MusicFileSelector", ZoomSpeed);
			BFGNMFCNDBC().SetVector("Error: PhotonNetwork.SetInterestGroups was called with an illegal group number: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 68f, 585f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
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

	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 226f)
			{
				HBJJOCHGOPH = 282f;
			}
			BFGNMFCNDBC().SetFloat("FileMenu", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("Dance", Aberration);
			HHIFMIPPMPF().SetFloat("_Amount", Fade);
			HHIFMIPPMPF().SetFloat("#md5submitionfailed: ", ZoomFade);
			NBPKMLMCHFN.SetFloat(" is muted", ZoomSpeed);
			NBPKMLMCHFN.SetVector("Mouse Wheel Up", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1034f, 547f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 174f)
			{
				HBJJOCHGOPH = 49f;
			}
			DEFBJOCJJKF().SetFloat("_Value6", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("\\[ *im.*\\](\\n\\n\\n|\\n\\n|\\n|)", Aberration);
			FAIFBBGFAIB().SetFloat("_VelocityScale", Fade);
			FAIFBBGFAIB().SetFloat("_ScreenResolution", ZoomFade);
			DEFBJOCJJKF().SetFloat("#alreadyexist", ZoomSpeed);
			HHIFMIPPMPF().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 611f, 1874f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 66f)
			{
				HBJJOCHGOPH = 378f;
			}
			BFGNMFCNDBC().SetFloat("_TimeX", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("_SampleCount", Aberration);
			AELJLBOJAIL().SetFloat("Unsupported target enum: ", Fade);
			DEFBJOCJJKF().SetFloat("[NetworkScene] Exited", ZoomFade);
			AELJLBOJAIL().SetFloat("_Bullet_10", ZoomSpeed);
			FAIFBBGFAIB().SetVector("roomDescription", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1983f, 388f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JHJFBCFBKLD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CIPKEPDELJB()
	{
		SCShader = Shader.Find("#close");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
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
			NBPKMLMCHFN.SetFloat("_Value", Aberration);
			NBPKMLMCHFN.SetFloat("Fade", Fade);
			NBPKMLMCHFN.SetFloat("ZoomFade", ZoomFade);
			NBPKMLMCHFN.SetFloat("ZoomSpeed", ZoomSpeed);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BFEILOMHNPC()
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

	private void EGEPLFGKGLI()
	{
		SCShader = Shader.Find("#");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FKEJGBFDCAH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 61f)
			{
				HBJJOCHGOPH = 726f;
			}
			FAIFBBGFAIB().SetFloat("MouseY", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("inventory.selected.", Aberration);
			FAIFBBGFAIB().SetFloat("achievements.21.completed.", Fade);
			HHIFMIPPMPF().SetFloat("_Value2", ZoomFade);
			HHIFMIPPMPF().SetFloat("[PlayerBase] Delete checkpoint data", ZoomSpeed);
			BFGNMFCNDBC().SetVector("ResetSpeed", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1853f, 1373f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material BFGNMFCNDBC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)76;
		}
		return BJFKDHHMLJH;
	}

	private void FEHCNJLLJMP()
	{
		SCShader = Shader.Find("/C tasklist");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material AELJLBOJAIL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-95);
		}
		return BJFKDHHMLJH;
	}

	private void BGDPIHMAACO()
	{
		SCShader = Shader.Find("float,0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material DEFBJOCJJKF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)104;
		}
		return BJFKDHHMLJH;
	}

	private void CCLNNLCOPBL()
	{
		SCShader = Shader.Find("[PlayerController] ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EJJEDJIOFAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FPHLDMMAOEF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 990f)
			{
				HBJJOCHGOPH = 527f;
			}
			DEFBJOCJJKF().SetFloat("#reward: ", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("_MainTex2", Aberration);
			IIJMIPBMMBF().SetFloat("maps.", Fade);
			HHIFMIPPMPF().SetFloat("PhotonNetwork error: Could not Instantiate the prefab [", ZoomFade);
			BFGNMFCNDBC().SetFloat("\n", ZoomSpeed);
			BFGNMFCNDBC().SetVector("_Value4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 65f, 1312f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DAHFFNNIGML()
	{
		SCShader = Shader.Find(" ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void Update()
	{
	}

	private void JOJFHFHOCHO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DIPDEHOOBPG()
	{
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material IIJMIPBMMBF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave;
		}
		return BJFKDHHMLJH;
	}

	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1502f)
			{
				HBJJOCHGOPH = 1152f;
			}
			OIMMPLPBLBK().SetFloat("_Offsets", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("DPADVER", Aberration);
			NFMGLIKNOOC().SetFloat("_ScreenResolution", Fade);
			FAIFBBGFAIB().SetFloat("_ScreenSize", ZoomFade);
			FAIFBBGFAIB().SetFloat("SpawnObj", ZoomSpeed);
			HHIFMIPPMPF().SetVector("_Intervale", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1361f, 1727f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KDMANOEMOCA()
	{
		SCShader = Shader.Find("AudioSampler");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IHLMNAGPKDA()
	{
		SCShader = Shader.Find("\n\n• ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 337f)
			{
				HBJJOCHGOPH = 1007f;
			}
			AELJLBOJAIL().SetFloat("z", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("_ScreenResolution", Aberration);
			DEFBJOCJJKF().SetFloat("_InternalLutTex", Fade);
			IIJMIPBMMBF().SetFloat("CameraFilterPack/Antialiasing_FXAA", ZoomFade);
			AELJLBOJAIL().SetFloat("*.workshop.json", ZoomSpeed);
			NFMGLIKNOOC().SetVector("_EmissionGain", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1774f, 1456f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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

	private void LOMDIOLNFHI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HHIFMIPPMPF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material OIMMPLPBLBK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)93;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NFMGLIKNOOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material FAIFBBGFAIB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/TV_Chromatical2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
