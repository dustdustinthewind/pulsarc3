// CameraFilterPack_TV_VHS
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/VHS/VHS")]
[ExecuteInEditMode]
public class CameraFilterPack_TV_VHS : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(1f, 256f)]
	public float Cryptage = 64f;

	[Range(1f, 100f)]
	public float Parasite = 32f;

	[Range(0f, 3f)]
	public float Calibrage;

	[Range(0f, 1f)]
	public float WhiteParasite = 1f;

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

	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1446f)
			{
				HBJJOCHGOPH = 1091f;
			}
			PLBEJJIHFPB().SetFloat("yyyy-MM-dd HH:mm:ss", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat("_Value2", Cryptage);
			IONHGBPGCHK().SetFloat("Hex value #RRGGBB", Parasite);
			PLBEJJIHFPB().SetFloat("#forever", Calibrage);
			ACHNOHCLGOO().SetFloat("SteamManager", WhiteParasite);
			ACHNOHCLGOO().SetVector("_Value7", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1158f, 1828f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BJOHDLNDFAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1533f)
			{
				HBJJOCHGOPH = 1065f;
			}
			PLBEJJIHFPB().SetFloat("Hidden/TonemappingColorGrading", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_TimeX", Cryptage);
			FAIFBBGFAIB().SetFloat("<b>", Parasite);
			ACHNOHCLGOO().SetFloat("_BlurVector", Calibrage);
			NBPKMLMCHFN.SetFloat(" registered.", WhiteParasite);
			IONHGBPGCHK().SetVector(" methods \"", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 834f, 1148f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/TV_VHS");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BMIOFJFMCBG()
	{
		SCShader = Shader.Find("z");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DHENLPJJOEN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MMOKKAPFGAK()
	{
		SCShader = Shader.Find("#FFFFFF");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 3f)
			{
				HBJJOCHGOPH = 1734f;
			}
			FAIFBBGFAIB().SetFloat("shader.crispwinter", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat(" to: ", Cryptage);
			ACHNOHCLGOO().SetFloat("_Value2", Parasite);
			ACHNOHCLGOO().SetFloat("_Value2", Calibrage);
			NBPKMLMCHFN.SetFloat("_Value2", WhiteParasite);
			LDNADDJMIPK().SetVector("_Metrics", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 826f, 676f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1932f)
			{
				HBJJOCHGOPH = 1513f;
			}
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Drawing_Manga4", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("_TimeX", Cryptage);
			FAIFBBGFAIB().SetFloat("GameScene", Parasite);
			IONHGBPGCHK().SetFloat("_Exponent", Calibrage);
			FAIFBBGFAIB().SetFloat("value", WhiteParasite);
			FAIFBBGFAIB().SetVector("<start_index> <end_index>", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 370f, 1362f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AEIJFLJEABG()
	{
	}

	private void BFEILOMHNPC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 825f)
			{
				HBJJOCHGOPH = 1318f;
			}
			NBPKMLMCHFN.SetFloat("settings.gamemessagesduration", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("Search: ", Cryptage);
			ACHNOHCLGOO().SetFloat("_Value", Parasite);
			IONHGBPGCHK().SetFloat("CameraFilterPack_Atmosphere_Rain_FX", Calibrage);
			IONHGBPGCHK().SetFloat("Received unknown status code: ", WhiteParasite);
			ACHNOHCLGOO().SetVector("_LightIntensity", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1131f, 9f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DOEPOGLEGLE()
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void MKIMDFLBFOM()
	{
		SCShader = Shader.Find("CameraFilterPack_RainFX_Anm2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material PLBEJJIHFPB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)102;
		}
		return BJFKDHHMLJH;
	}

	private void BNEJMABFKJE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 518f)
			{
				HBJJOCHGOPH = 232f;
			}
			LDNADDJMIPK().SetFloat("Day_", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat("[Right]", Cryptage);
			PLBEJJIHFPB().SetFloat("_TimeX", Parasite);
			LDNADDJMIPK().SetFloat("offsets", Calibrage);
			PLBEJJIHFPB().SetFloat("Value", WhiteParasite);
			FAIFBBGFAIB().SetVector("received</b>\n#reason: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 307f, 1282f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DLMPALHKMON()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1971f)
			{
				HBJJOCHGOPH = 499f;
			}
			LDNADDJMIPK().SetFloat("A", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat(".lastCheckpoint.bgcolor", Cryptage);
			ACHNOHCLGOO().SetFloat("New level loaded. Removed ", Parasite);
			PLBEJJIHFPB().SetFloat("{0:0} hour{1}, ", Calibrage);
			PLBEJJIHFPB().SetFloat("_ScreenResolution", WhiteParasite);
			NBPKMLMCHFN.SetVector("[PlayerController] ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1725f, 812f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1147f)
			{
				HBJJOCHGOPH = 1458f;
			}
			IONHGBPGCHK().SetFloat("_Distortion", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("<command>", Cryptage);
			LDNADDJMIPK().SetFloat("float,2", Parasite);
			IONHGBPGCHK().SetFloat("FinalScoreSmallText", Calibrage);
			NBPKMLMCHFN.SetFloat("_Value4", WhiteParasite);
			IONHGBPGCHK().SetVector("SetPlayerDistance", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1703f, 1870f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
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
			NBPKMLMCHFN.SetFloat("_Value", Cryptage);
			NBPKMLMCHFN.SetFloat("_Value2", Parasite);
			NBPKMLMCHFN.SetFloat("_Value3", Calibrage);
			NBPKMLMCHFN.SetFloat("_Value4", WhiteParasite);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	private void LJIHHJOAJCN()
	{
	}

	private void CBIBDOIBJAI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material FAIFBBGFAIB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void CCLNNLCOPBL()
	{
		SCShader = Shader.Find("Texture2");
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-72);
		}
		return BJFKDHHMLJH;
	}

	private void NPLCENPNJBM()
	{
		SCShader = Shader.Find("[PlayerBase] MapEnd error: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DPFOEBCADNP()
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

	private void OCCGJMPAJIK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EJJEDJIOFAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LECCHIAFGGE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LCJHDLKJEOM()
	{
	}

	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1666f)
			{
				HBJJOCHGOPH = 1420f;
			}
			PLBEJJIHFPB().SetFloat("CameraFilterPack/Edge_Edge_filter", HBJJOCHGOPH);
			LDNADDJMIPK().SetFloat("Preparing content", Cryptage);
			ACHNOHCLGOO().SetFloat("_TimeX", Parasite);
			IONHGBPGCHK().SetFloat("_Value6", Calibrage);
			IONHGBPGCHK().SetFloat("_ScreenResolution", WhiteParasite);
			NBPKMLMCHFN.SetVector("CameraFilterPack/Broken_Screen", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1412f, 74f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BEBNOKFLJPH()
	{
		SCShader = Shader.Find("st");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AGMJDGHLBMN()
	{
	}

	private void FBMDHDBELEK()
	{
	}

	private void IIFCIDDJHPM()
	{
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BGFJOEPFOPM()
	{
	}

	private void HNILMGEKDEC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BMOFEBKGLFI()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NJHJHBOJKIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}
}
