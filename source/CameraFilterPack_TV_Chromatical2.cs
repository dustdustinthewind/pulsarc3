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
			BFGNMFCNDBC().SetFloat(".lastCheckpoint.checkpointsUsed", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("MessageText", Aberration);
			FAIFBBGFAIB().SetFloat("CameraFilterPack/FX_Glitch1", Fade);
			BFGNMFCNDBC().SetFloat("'{0}' \t{1}ms \t{2}", ZoomFade);
			BFGNMFCNDBC().SetFloat("_MatrixColor", ZoomSpeed);
			HHIFMIPPMPF().SetVector("ViewMenu", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 153f, 379f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			DEFBJOCJJKF().SetFloat("_Value4", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("SetSatelliteRadius", Aberration);
			DEFBJOCJJKF().SetFloat("DPADVER", Fade);
			AELJLBOJAIL().SetFloat("_Value", ZoomFade);
			OIMMPLPBLBK().SetFloat("MusicFileSelector", ZoomSpeed);
			HHIFMIPPMPF().SetVector(". The group number should be at least 1.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 68f, 585f));
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
			OIMMPLPBLBK().SetFloat("FileMenu", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Dance", Aberration);
			OIMMPLPBLBK().SetFloat("_Amount", Fade);
			OIMMPLPBLBK().SetFloat("#tryagain", ZoomFade);
			HHIFMIPPMPF().SetFloat(" is muted", ZoomSpeed);
			FAIFBBGFAIB().SetVector("Mouse Wheel Down", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1034f, 547f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
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
			AELJLBOJAIL().SetFloat("_Value7", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("\\[ *im.*\\](\\n\\n\\n|\\n\\n|\\n|)", Aberration);
			FAIFBBGFAIB().SetFloat("_TileMaxOffs", Fade);
			BFGNMFCNDBC().SetFloat("_TimeX", ZoomFade);
			AELJLBOJAIL().SetFloat("Editor/", ZoomSpeed);
			IIJMIPBMMBF().SetVector("_Value4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 611f, 1874f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
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
			NBPKMLMCHFN.SetFloat("UseFinalGlassColor", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("Hidden/Fast Approximate Anti-aliasing", Aberration);
			HHIFMIPPMPF().SetFloat(". The group number should be at least 1.", Fade);
			HHIFMIPPMPF().SetFloat("[NetworkScene] Exited", ZoomFade);
			HHIFMIPPMPF().SetFloat("_Bullet_12", ZoomSpeed);
			NBPKMLMCHFN.SetVector("masterSteamID", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1983f, 388f));
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
		SCShader = Shader.Find("#onfirstranktext");
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
		SCShader = Shader.Find(",");
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
			IIJMIPBMMBF().SetFloat("MouseX", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("inventory.selected.", Aberration);
			FAIFBBGFAIB().SetFloat("achievements.21.completed.", Fade);
			DEFBJOCJJKF().SetFloat("_Value3", ZoomFade);
			BFGNMFCNDBC().SetFloat("maps.", ZoomSpeed);
			FAIFBBGFAIB().SetVector("ResetSpeed", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1853f, 1373f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
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
		SCShader = Shader.Find("y");
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
		SCShader = Shader.Find(":");
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
			HHIFMIPPMPF().SetFloat("#timeuntilchallenge: ", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("_TimeX", Aberration);
			HHIFMIPPMPF().SetFloat(".completed", Fade);
			AELJLBOJAIL().SetFloat("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.", ZoomFade);
			FAIFBBGFAIB().SetFloat("Source Object: ", ZoomSpeed);
			NFMGLIKNOOC().SetVector("_Value4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 65f, 1312f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DAHFFNNIGML()
	{
		SCShader = Shader.Find("help");
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
		SCShader = Shader.Find("_TimeX");
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
			FAIFBBGFAIB().SetFloat("_SecondTex", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("DPADHOR", Aberration);
			DEFBJOCJJKF().SetFloat("CameraFilterPack/FX_Dot_Circle", Fade);
			BFGNMFCNDBC().SetFloat("_ProjInfo", ZoomFade);
			NBPKMLMCHFN.SetFloat("Left", ZoomSpeed);
			FAIFBBGFAIB().SetVector("_Intervale", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1361f, 1727f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
		SCShader = Shader.Find("InfoCanvas");
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
			NBPKMLMCHFN.SetFloat("z", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("CameraFilterPack/FX_Hypno", Aberration);
			AELJLBOJAIL().SetFloat("_UserLutTex", Fade);
			HHIFMIPPMPF().SetFloat("CameraFilterPack/Antialiasing_FXAA", ZoomFade);
			NBPKMLMCHFN.SetFloat("Called GetNumberOfCurrentPlayers()", ZoomSpeed);
			AELJLBOJAIL().SetVector("Items/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1774f, 1456f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
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
