// CameraFilterPack_Glasses_On_4
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Glasses/Futuristic Desert")]
[ExecuteInEditMode]
public class CameraFilterPack_Glasses_On_4 : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	[Range(0f, 1f)]
	public float Fade = 0.2f;

	[Range(0f, 0.1f)]
	public float VisionBlur = 0.005f;

	public Color GlassesColor = new Color(0f, 0f, 0f, 1f);

	public Color GlassesColor2 = new Color(0.25f, 0.25f, 0.25f, 0.25f);

	[Range(0f, 1f)]
	public float GlassDistortion = 0.6f;

	[Range(0f, 1f)]
	public float GlassAberration = 0.3f;

	[Range(0f, 1f)]
	public float UseFinalGlassColor;

	[Range(0f, 1f)]
	public float UseScanLine = 0.4f;

	[Range(1f, 512f)]
	public float UseScanLineSize = 358f;

	public Color GlassColor = new Color(1f, 0.4f, 0f, 1f);

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

	private void CMIBEOJGAIL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1596f)
			{
				HBJJOCHGOPH = 154f;
			}
			LDNADDJMIPK().SetFloat("CameraFilterPack/Real_VHS", HBJJOCHGOPH);
			MNLKBFFKHIE().SetFloat("\n", UseFinalGlassColor);
			LONNIJMNKFB().SetFloat("_ScreenResolution", Fade);
			EPCGJFCCAFH().SetFloat("CameraFilterPack/Gradients_Hue", VisionBlur);
			IIJMIPBMMBF().SetFloat("Chat", GlassDistortion);
			IIJMIPBMMBF().SetFloat("Object ID. Case-Sensitive", GlassAberration);
			OIBHFCLJKDB().SetColor("UI Extensions/SoftMaskShaderText", GlassesColor);
			FLOHGDECHHH().SetColor("#no", GlassesColor2);
			PGPEMMBJOOG().SetColor("_Value2", GlassColor);
			LDNADDJMIPK().SetFloat("#forever", UseScanLineSize);
			NBPKMLMCHFN.SetFloat("MenuPlayButton", UseScanLine);
			LONNIJMNKFB().SetTexture("LeaderboardsButton", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HNILMGEKDEC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OPCLBGHAPMG()
	{
	}

	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 876f)
			{
				HBJJOCHGOPH = 1445f;
			}
			ADBKPGFMNKO().SetFloat("Copy from ", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("_TimeX", UseFinalGlassColor);
			LONNIJMNKFB().SetFloat("st", Fade);
			MNLKBFFKHIE().SetFloat("There are {0} reported logs.", VisionBlur);
			PGPEMMBJOOG().SetFloat("ChallengesButton", GlassDistortion);
			NDMPCDHADMJ().SetFloat("FavoriteButton", GlassAberration);
			LONNIJMNKFB().SetColor("_Value", GlassesColor);
			PGPEMMBJOOG().SetColor("[ReplayScene] Loading replay: ", GlassesColor2);
			GKILCDHJFEG().SetColor("Gameplay/satellite", GlassColor);
			KOHGPKOFEJO().SetFloat("CameraFilterPack/EXTRA_SHOWFPS", UseScanLineSize);
			KBOPGONOCNP().SetFloat("_TimeX", UseScanLine);
			NBPKMLMCHFN.SetTexture("USE_DIAG_SEARCH", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FLKEJJEGCFA()
	{
		FPHEBLMINDA = Resources.Load("[Up]") as Texture2D;
		SCShader = Shader.Find("_ScreenEdgeFading");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material EPCGJFCCAFH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void IMGGCJICLHK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LCJHDLKJEOM()
	{
	}

	private void KOJKBFDNGDK()
	{
		FPHEBLMINDA = Resources.Load("shader.pixel") as Texture2D;
		SCShader = Shader.Find("UseFinalGlassColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JAAJECBCCFM()
	{
	}

	private void FJIKDJAMOHA()
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

	private void HIPEHGNBJMN()
	{
		FPHEBLMINDA = Resources.Load("_NoiseAmount") as Texture2D;
		SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OMCLOFCJMPG()
	{
	}

	private void AEEGKLABFLN()
	{
	}

	private void FGNFILLNPJK()
	{
	}

	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1284f)
			{
				HBJJOCHGOPH = 439f;
			}
			OIBHFCLJKDB().SetFloat("icon.png", HBJJOCHGOPH);
			PGPEMMBJOOG().SetFloat("_Value2", UseFinalGlassColor);
			PGPEMMBJOOG().SetFloat("#accuracy", Fade);
			KBOPGONOCNP().SetFloat("Item creation successful! Published Item ID: ", VisionBlur);
			KDMBOKLMADJ().SetFloat("CameraFilterPack/Blend2Camera_LighterColor", GlassDistortion);
			ADBKPGFMNKO().SetFloat("OpGetGameList not sent. Lobby cannot be null.", GlassAberration);
			EPCGJFCCAFH().SetColor(" BETA", GlassesColor);
			LDNADDJMIPK().SetColor("st", GlassesColor2);
			ADBKPGFMNKO().SetColor("[MapEditor] Reset", GlassColor);
			EPCGJFCCAFH().SetFloat("intensity", UseScanLineSize);
			NBPKMLMCHFN.SetFloat("steamid", UseScanLine);
			NBPKMLMCHFN.SetTexture("Ev Destroy Failed. Could not find PhotonView with instantiationId ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JBMBNKOOENB()
	{
	}

	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1160f)
			{
				HBJJOCHGOPH = 1074f;
			}
			ADBKPGFMNKO().SetFloat("Crosshair1", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("CameraFilterPack_TV_Noise2", UseFinalGlassColor);
			MNLKBFFKHIE().SetFloat("Move environment object to the position", Fade);
			JCPDCGIJKJD().SetFloat("_HdrParams", VisionBlur);
			MNLKBFFKHIE().SetFloat(").png", GlassDistortion);
			NBPKMLMCHFN.SetFloat("_Value4", GlassAberration);
			OIBHFCLJKDB().SetColor("MapFolderInputField", GlassesColor);
			NDMPCDHADMJ().SetColor("[DiscordController] Disconnect {0}: {1}", GlassesColor2);
			PGPEMMBJOOG().SetColor("_MainTex2", GlassColor);
			JCPDCGIJKJD().SetFloat("player.xp", UseScanLineSize);
			PGPEMMBJOOG().SetFloat("_Green_G", UseScanLine);
			NFMGLIKNOOC().SetTexture("float,0", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MANDOGNJJBD()
	{
	}

	private void PNNPDMHLFHE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FHGKIOOMMOH()
	{
		FPHEBLMINDA = Resources.Load("intensity") as Texture2D;
		SCShader = Shader.Find("_NeutralTonemapperParams2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material JCPDCGIJKJD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material ADBKPGFMNKO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material GKILCDHJFEG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	private void ANKIJGCGCBF()
	{
	}

	private void Update()
	{
	}

	private void OPHBLNNGFKG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1630f)
			{
				HBJJOCHGOPH = 261f;
			}
			ABHDNGIHBKE().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			ECCPAOBFDKP().SetFloat("_Value1", UseFinalGlassColor);
			NDMPCDHADMJ().SetFloat("Error: I/O Failure", Fade);
			ABHDNGIHBKE().SetFloat("Scene", VisionBlur);
			KDMBOKLMADJ().SetFloat("CameraFilterPack_VHS2", GlassDistortion);
			KBOPGONOCNP().SetFloat("_ScreenResolution", GlassAberration);
			EPCGJFCCAFH().SetColor("_ColorBuffer", GlassesColor);
			LONNIJMNKFB().SetColor("_ScreenResolution", GlassesColor2);
			ECCPAOBFDKP().SetColor("Bad parameters for init! Use \"init\" or \"init <savename>\"", GlassColor);
			MNLKBFFKHIE().SetFloat("CameraFilterPack/Blend2Camera_Subtract", UseScanLineSize);
			NDMPCDHADMJ().SetFloat("offline room", UseScanLine);
			OIBHFCLJKDB().SetTexture("DPADHOR", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FODKODGPPDA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CCFEDENFNEF()
	{
		FPHEBLMINDA = Resources.Load("STOP [R]") as Texture2D;
		SCShader = Shader.Find("_MatrixSpeed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void EKCDEFDELMP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EGEPLFGKGLI()
	{
		FPHEBLMINDA = Resources.Load("red") as Texture2D;
		SCShader = Shader.Find("_Parasite");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EJJEDJIOFAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IDIIELPAMCJ()
	{
	}

	[SpecialName]
	private Material MNLKBFFKHIE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void DHNGNHGDPLM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LLJLDLLNFBH()
	{
	}

	private void CACCPBENDAP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 583f)
			{
				HBJJOCHGOPH = 249f;
			}
			ECCPAOBFDKP().SetFloat("DestroyPlayerObjects() failed, cause parameter 'targetPlayer' was null.", HBJJOCHGOPH);
			OIBHFCLJKDB().SetFloat("_Offsets", UseFinalGlassColor);
			NDMPCDHADMJ().SetFloat("Please attach component to a Graphical UI component", Fade);
			MNLKBFFKHIE().SetFloat("challenges.", VisionBlur);
			NDMPCDHADMJ().SetFloat("_History2LumaTex", GlassDistortion);
			MNLKBFFKHIE().SetFloat("MenuRecordButton", GlassAberration);
			PGPEMMBJOOG().SetColor("_Value6", GlassesColor);
			KBOPGONOCNP().SetColor("_Value2", GlassesColor2);
			FLOHGDECHHH().SetColor("_Value2", GlassColor);
			EPCGJFCCAFH().SetFloat("{0:0} day{1}, ", UseScanLineSize);
			NDMPCDHADMJ().SetFloat("settings.disablestoryboard", UseScanLine);
			OIBHFCLJKDB().SetTexture("[NetworkManager] Found ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ECCPAOBFDKP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FAMLCFNDGNI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KFEKCJDEECK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OFPPIKHNJOD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material ABHDNGIHBKE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-118);
		}
		return BJFKDHHMLJH;
	}

	private void NNBCLMJGFEN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1228f)
			{
				HBJJOCHGOPH = 1624f;
			}
			JCPDCGIJKJD().SetFloat("Turn", HBJJOCHGOPH);
			PGPEMMBJOOG().SetFloat("_TimeX", UseFinalGlassColor);
			KBOPGONOCNP().SetFloat("_Value7", Fade);
			ABHDNGIHBKE().SetFloat("float,1.5", VisionBlur);
			HKGAONMOBMH().SetFloat("#close", GlassDistortion);
			EPCGJFCCAFH().SetFloat("_Value5", GlassAberration);
			JCPDCGIJKJD().SetColor("_ScreenResolution", GlassesColor);
			HKGAONMOBMH().SetColor("default", GlassesColor2);
			LONNIJMNKFB().SetColor(": ", GlassColor);
			MNLKBFFKHIE().SetFloat("_TimeX", UseScanLineSize);
			PGPEMMBJOOG().SetFloat(" Time: ", UseScanLine);
			MNLKBFFKHIE().SetTexture("\\\\", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JDKHBGDEONK()
	{
		FPHEBLMINDA = Resources.Load("_TimeX") as Texture2D;
		SCShader = Shader.Find("Fade");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void COOHIILCOCO()
	{
		FPHEBLMINDA = Resources.Load("\0\0") as Texture2D;
		SCShader = Shader.Find("_Green_G");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material LDNADDJMIPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void ALMGMOOHLMA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JNALDALAJLG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material NDMPCDHADMJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void BMIOFJFMCBG()
	{
		FPHEBLMINDA = Resources.Load("#status") as Texture2D;
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1460f)
			{
				HBJJOCHGOPH = 312f;
			}
			LONNIJMNKFB().SetFloat("_Value", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat("#", UseFinalGlassColor);
			FLOHGDECHHH().SetFloat("_Fade", Fade);
			ADBKPGFMNKO().SetFloat("MenuScene", VisionBlur);
			MNLKBFFKHIE().SetFloat("TotalHitsScoreText", GlassDistortion);
			NFMGLIKNOOC().SetFloat("y", GlassAberration);
			MNLKBFFKHIE().SetColor(".lastCheckpoint.lives", GlassesColor);
			LONNIJMNKFB().SetColor("SelectionBox component is on a gameObject with a Canvas Scaler component. As of now, Canvas Scalers without the default settings throw off the coordinates of the selection box. Canvas Scaler has been removed.", GlassesColor2);
			NDMPCDHADMJ().SetColor("_Visualize", GlassColor);
			EPCGJFCCAFH().SetFloat("EventMenu", UseScanLineSize);
			JCPDCGIJKJD().SetFloat("0.00", UseScanLine);
			IIJMIPBMMBF().SetTexture("Change Note:", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KCCIEMBMOBA()
	{
		FPHEBLMINDA = Resources.Load("_TexelOffsetScale") as Texture2D;
		SCShader = Shader.Find("shader.sunny");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GNPDGBNDCPL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1704f)
			{
				HBJJOCHGOPH = 913f;
			}
			LONNIJMNKFB().SetFloat("_Offsets", HBJJOCHGOPH);
			FLOHGDECHHH().SetFloat("score", UseFinalGlassColor);
			NDMPCDHADMJ().SetFloat("Mouse2", Fade);
			ABHDNGIHBKE().SetFloat("Incoming: \n", VisionBlur);
			HKGAONMOBMH().SetFloat("[PlayerBase] Loaded environment: ", GlassDistortion);
			GKILCDHJFEG().SetFloat("resource id", GlassAberration);
			GKILCDHJFEG().SetColor("id", GlassesColor);
			KDMBOKLMADJ().SetColor("offsets", GlassesColor2);
			OIBHFCLJKDB().SetColor("_TimeX", GlassColor);
			ABHDNGIHBKE().SetFloat("_CurveParams", UseScanLineSize);
			JCPDCGIJKJD().SetFloat("Clears all text from the debug console", UseScanLine);
			IIJMIPBMMBF().SetTexture(".lastCheckpoint.powerupsScore", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JLNNHKPHMAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MJNPIDGNJMK()
	{
	}

	[SpecialName]
	private Material PGPEMMBJOOG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)66;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IIJMIPBMMBF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)104;
		}
		return BJFKDHHMLJH;
	}

	private void IMCKJCHKMKB()
	{
		FPHEBLMINDA = Resources.Load(".sawoutdatedmessage") as Texture2D;
		SCShader = Shader.Find("Gameplay/sprite");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1651f)
			{
				HBJJOCHGOPH = 681f;
			}
			EPCGJFCCAFH().SetFloat("_Near", HBJJOCHGOPH);
			MNLKBFFKHIE().SetFloat("CameraFilterPack_VHS2", UseFinalGlassColor);
			OIBHFCLJKDB().SetFloat("_AdaptTex", Fade);
			PGPEMMBJOOG().SetFloat("ItemTemplate", VisionBlur);
			JCPDCGIJKJD().SetFloat("GlassColor", GlassDistortion);
			NDMPCDHADMJ().SetFloat("_Value4", GlassAberration);
			NDMPCDHADMJ().SetColor("-", GlassesColor);
			NBPKMLMCHFN.SetColor("[PlayerBase] Loaded spawner data", GlassesColor2);
			EPCGJFCCAFH().SetColor("[EditorEvent] Exception: ", GlassColor);
			KBOPGONOCNP().SetFloat("_ExposureAdjustment", UseScanLineSize);
			KBOPGONOCNP().SetFloat("_AccumulationTex", UseScanLine);
			OIBHFCLJKDB().SetTexture("SaveButton", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PHJJHFBLICM()
	{
	}

	private void FABKIGNFECE()
	{
	}

	private void DOKAKEMDALN()
	{
		FPHEBLMINDA = Resources.Load("Tab2Content") as Texture2D;
		SCShader = Shader.Find("#C8C8C8FF");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BOPKKCAFODF()
	{
		FPHEBLMINDA = Resources.Load("_DiffuseColor") as Texture2D;
		SCShader = Shader.Find("menu.playedpage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 846f)
			{
				HBJJOCHGOPH = 602f;
			}
			ABHDNGIHBKE().SetFloat("#ok", HBJJOCHGOPH);
			NDMPCDHADMJ().SetFloat("_Blurred", UseFinalGlassColor);
			MNLKBFFKHIE().SetFloat("CameraFilterPack/TV_VHS_Rewind", Fade);
			NFMGLIKNOOC().SetFloat("settings.enablehitsoundsinnormal", VisionBlur);
			MNLKBFFKHIE().SetFloat("^", GlassDistortion);
			LDNADDJMIPK().SetFloat(".completed", GlassAberration);
			ECCPAOBFDKP().SetColor("b", GlassesColor);
			GKILCDHJFEG().SetColor("_Blue_R", GlassesColor2);
			NDMPCDHADMJ().SetColor("menutheme.coldheat", GlassColor);
			NDMPCDHADMJ().SetFloat("_Blue_B", UseScanLineSize);
			LONNIJMNKFB().SetFloat("_BorderColor", UseScanLine);
			LDNADDJMIPK().SetTexture("ResourceFileSelector", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ECCPAOBFDKP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 705f)
			{
				HBJJOCHGOPH = 1613f;
			}
			ECCPAOBFDKP().SetFloat("maps.", HBJJOCHGOPH);
			PGPEMMBJOOG().SetFloat("Error: PhotonNetwork.SetInterestGroups was called with an illegal group number: ", UseFinalGlassColor);
			KBOPGONOCNP().SetFloat("Item created: Id: ", Fade);
			MNLKBFFKHIE().SetFloat("ConnectToRegion: ", VisionBlur);
			NDMPCDHADMJ().SetFloat(".lastCheckpoint.perfectHits", GlassDistortion);
			ADBKPGFMNKO().SetFloat("GlassDistortion", GlassAberration);
			MNLKBFFKHIE().SetColor("_Value", GlassesColor);
			ECCPAOBFDKP().SetColor("_Value5", GlassesColor2);
			IIJMIPBMMBF().SetColor("_TimeX", GlassColor);
			LONNIJMNKFB().SetFloat("_Threshold", UseScanLineSize);
			PGPEMMBJOOG().SetFloat("_Speed", UseScanLine);
			PGPEMMBJOOG().SetTexture("Gameplay/Base", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material OIBHFCLJKDB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 734f)
			{
				HBJJOCHGOPH = 25f;
			}
			FLOHGDECHHH().SetFloat("_EmissionColor", HBJJOCHGOPH);
			KDMBOKLMADJ().SetFloat("value", UseFinalGlassColor);
			FLOHGDECHHH().SetFloat("ConnectToRegion() failed. Can only connect while in state 'Disconnected'. Current state: ", Fade);
			MNLKBFFKHIE().SetFloat("_Value2", VisionBlur);
			IIJMIPBMMBF().SetFloat("_MainTex2", GlassDistortion);
			KBOPGONOCNP().SetFloat("Vertical", GlassAberration);
			EPCGJFCCAFH().SetColor("turn", GlassesColor);
			LONNIJMNKFB().SetColor("maps.", GlassesColor2);
			PGPEMMBJOOG().SetColor("ScreenResolutionPanel", GlassColor);
			KOHGPKOFEJO().SetFloat("_NoiseTilingPerChannel", UseScanLineSize);
			IIJMIPBMMBF().SetFloat("_Level", UseScanLine);
			ABHDNGIHBKE().SetTexture("SelectionBox component is on a gameObject with a Canvas Scaler component. As of now, Canvas Scalers without the default settings throw off the coordinates of the selection box. Canvas Scaler has been removed.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AOKOLPEGHDD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HIFLPHLGLFG()
	{
	}

	private void Start()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_Glasses_On5") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Glasses_On");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GOIMKCCICFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 186f)
			{
				HBJJOCHGOPH = 1387f;
			}
			KOHGPKOFEJO().SetFloat("icon", HBJJOCHGOPH);
			ECCPAOBFDKP().SetFloat("CameraFilterPack/Blur_GaussianBlur", UseFinalGlassColor);
			LONNIJMNKFB().SetFloat("mapselector.orderby", Fade);
			OIBHFCLJKDB().SetFloat("masterVolume", VisionBlur);
			NFMGLIKNOOC().SetFloat("_CenterY", GlassDistortion);
			JCPDCGIJKJD().SetFloat("#finished", GlassAberration);
			NFMGLIKNOOC().SetColor("_FadeFromBinary", GlassesColor);
			ABHDNGIHBKE().SetColor("_Offsets", GlassesColor2);
			PGPEMMBJOOG().SetColor(". Prefab must have a PhotonView component.", GlassColor);
			KBOPGONOCNP().SetFloat("list", UseScanLineSize);
			ECCPAOBFDKP().SetFloat("_Distortion", UseScanLine);
			KBOPGONOCNP().SetTexture("[Right-Down]", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIBHFCLJKDB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LBPHCAMMAPB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KIMMMCJFMAB()
	{
		FPHEBLMINDA = Resources.Load("Editor/") as Texture2D;
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PMPKMGKAAJH()
	{
		FPHEBLMINDA = Resources.Load("\n\n#") as Texture2D;
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DFFKKLAPHCC()
	{
		FPHEBLMINDA = Resources.Load("_Value4") as Texture2D;
		SCShader = Shader.Find("_DotSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PKLOBJHKFEO()
	{
		FPHEBLMINDA = Resources.Load("_Alpha") as Texture2D;
		SCShader = Shader.Find("yyyy-MM-dd HH:mm:ss");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OOGIHDLBBLM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FGBDGGCBFLP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PDHKMDBNGGN()
	{
		FPHEBLMINDA = Resources.Load("RT") as Texture2D;
		SCShader = Shader.Find("Horizontal");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1429f)
			{
				HBJJOCHGOPH = 1188f;
			}
			LDNADDJMIPK().SetFloat("_EmissionGain", HBJJOCHGOPH);
			PGPEMMBJOOG().SetFloat("/icon", UseFinalGlassColor);
			NBPKMLMCHFN.SetFloat("_BlendTex", Fade);
			NDMPCDHADMJ().SetFloat("Arc", VisionBlur);
			PGPEMMBJOOG().SetFloat("true", GlassDistortion);
			MNLKBFFKHIE().SetFloat("_Value5", GlassAberration);
			LONNIJMNKFB().SetColor("g", GlassesColor);
			KOHGPKOFEJO().SetColor("Incoming: \n", GlassesColor2);
			LDNADDJMIPK().SetColor("CameraFilterPack/Oculus_NightVision5", GlassColor);
			KOHGPKOFEJO().SetFloat("[LocalizationService] Localization: ", UseScanLineSize);
			ADBKPGFMNKO().SetFloat("_Value2", UseScanLine);
			HKGAONMOBMH().SetTexture("_MatrixColor", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIBHFCLJKDB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FMFNILJIEIA()
	{
		FPHEBLMINDA = Resources.Load("PhotonView register is ignored, because viewID is 0. No id assigned yet to: ") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/OldFilm_Cutting2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material LONNIJMNKFB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)75;
		}
		return BJFKDHHMLJH;
	}

	private void ONPFGCEFMML()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HLLHJIDOOGA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material FLOHGDECHHH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)86;
		}
		return BJFKDHHMLJH;
	}

	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1292f)
			{
				HBJJOCHGOPH = 147f;
			}
			ADBKPGFMNKO().SetFloat("received</b>\n#reason: ", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("BitsData", UseFinalGlassColor);
			KDMBOKLMADJ().SetFloat("nogamesfound", Fade);
			OIBHFCLJKDB().SetFloat("JoinRandomRoom failed. In offline mode you still have to leave a room to enter another.", VisionBlur);
			HKGAONMOBMH().SetFloat("winter2020", GlassDistortion);
			KBOPGONOCNP().SetFloat("_Value2", GlassAberration);
			NBPKMLMCHFN.SetColor("/", GlassesColor);
			HKGAONMOBMH().SetColor(": ", GlassesColor2);
			HKGAONMOBMH().SetColor(". Verify the Prefab is in a Resources folder (and not in a subfolder)", GlassColor);
			GKILCDHJFEG().SetFloat("_Value3", UseScanLineSize);
			ABHDNGIHBKE().SetFloat("EndlessLoopsScoreText", UseScanLine);
			KBOPGONOCNP().SetTexture("_TimeX", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 969f)
			{
				HBJJOCHGOPH = 1452f;
			}
			EPCGJFCCAFH().SetFloat(" not exist", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat(",", UseFinalGlassColor);
			KBOPGONOCNP().SetFloat("achievements.21.progress", Fade);
			NFMGLIKNOOC().SetFloat("SetTrailZoomSpeed", VisionBlur);
			KDMBOKLMADJ().SetFloat("[UI] Unknows button action: ", GlassDistortion);
			OIBHFCLJKDB().SetFloat("_Value2", GlassAberration);
			HKGAONMOBMH().SetColor(".lastCheckpoint.comboScore", GlassesColor);
			LONNIJMNKFB().SetColor("_ScreenResolution", GlassesColor2);
			ECCPAOBFDKP().SetColor("Anomaly_Near", GlassColor);
			LDNADDJMIPK().SetFloat("CameraFilterPack/FX_InverChromiLum", UseScanLineSize);
			HKGAONMOBMH().SetFloat("_Value2", UseScanLine);
			MNLKBFFKHIE().SetTexture("ScoreText", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EDCMIPNCPLB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IIFCIDDJHPM()
	{
	}

	private void NJBMCJOOMMP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 714f)
			{
				HBJJOCHGOPH = 1621f;
			}
			LONNIJMNKFB().SetFloat("win", HBJJOCHGOPH);
			FLOHGDECHHH().SetFloat("_BlurArea", UseFinalGlassColor);
			FLOHGDECHHH().SetFloat("maps.", Fade);
			NFMGLIKNOOC().SetFloat("DPADHOR", VisionBlur);
			KBOPGONOCNP().SetFloat("maps.", GlassDistortion);
			MNLKBFFKHIE().SetFloat("[PlayerBase] Starting game from: ", GlassAberration);
			PGPEMMBJOOG().SetColor("Start", GlassesColor);
			MNLKBFFKHIE().SetColor("_ScreenResolution", GlassesColor2);
			LONNIJMNKFB().SetColor("Called GetNumberOfCurrentPlayers()", GlassColor);
			PGPEMMBJOOG().SetFloat("/", UseScanLineSize);
			EPCGJFCCAFH().SetFloat("_HighlightSuppression", UseScanLine);
			NDMPCDHADMJ().SetTexture("value", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MAOCOEGAFND()
	{
	}

	private void NNPBKKBFDHH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MFMIODIAKNI()
	{
	}

	[SpecialName]
	private Material KDMBOKLMADJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void BMODOIJGIOO()
	{
	}

	[SpecialName]
	private Material KOHGPKOFEJO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-104);
		}
		return BJFKDHHMLJH;
	}

	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1434f)
			{
				HBJJOCHGOPH = 1051f;
			}
			KDMBOKLMADJ().SetFloat("challenges.", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("0.00", UseFinalGlassColor);
			LONNIJMNKFB().SetFloat("appid", Fade);
			ECCPAOBFDKP().SetFloat("MaxLivesSlider", VisionBlur);
			JCPDCGIJKJD().SetFloat("RecieveChatActionMessage", GlassDistortion);
			ADBKPGFMNKO().SetFloat("_Value", GlassAberration);
			JCPDCGIJKJD().SetColor("513510", GlassesColor);
			ADBKPGFMNKO().SetColor("_FixDistance", GlassesColor2);
			KDMBOKLMADJ().SetColor("\t", GlassColor);
			NBPKMLMCHFN.SetFloat("[MapEditor] Prepairing map editor...", UseScanLineSize);
			ABHDNGIHBKE().SetFloat("AccuracyScoreText", UseScanLine);
			IIJMIPBMMBF().SetTexture("<size=24>", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MNLKBFFKHIE());
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
			NBPKMLMCHFN.SetFloat("UseFinalGlassColor", UseFinalGlassColor);
			NBPKMLMCHFN.SetFloat("Fade", Fade);
			NBPKMLMCHFN.SetFloat("VisionBlur", VisionBlur);
			NBPKMLMCHFN.SetFloat("GlassDistortion", GlassDistortion);
			NBPKMLMCHFN.SetFloat("GlassAberration", GlassAberration);
			NBPKMLMCHFN.SetColor("GlassesColor", GlassesColor);
			NBPKMLMCHFN.SetColor("GlassesColor2", GlassesColor2);
			NBPKMLMCHFN.SetColor("GlassColor", GlassColor);
			NBPKMLMCHFN.SetFloat("UseScanLineSize", UseScanLineSize);
			NBPKMLMCHFN.SetFloat("UseScanLine", UseScanLine);
			NBPKMLMCHFN.SetTexture("_MainTex2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PLBOFEPBPKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JEBIBKLHFLB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HKGAONMOBMH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-111);
		}
		return BJFKDHHMLJH;
	}

	private void FEKECCBFGMI()
	{
		FPHEBLMINDA = Resources.Load("Time Offset: {0}") as Texture2D;
		SCShader = Shader.Find(". Verify the Prefab is in a Resources folder (and not in a subfolder)");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KDJEJBBDILE()
	{
	}

	[SpecialName]
	private Material ECCPAOBFDKP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1451f)
			{
				HBJJOCHGOPH = 143f;
			}
			KBOPGONOCNP().SetFloat("#alreadyexist", HBJJOCHGOPH);
			KDMBOKLMADJ().SetFloat("_TimeX", UseFinalGlassColor);
			KBOPGONOCNP().SetFloat("Player", Fade);
			NDMPCDHADMJ().SetFloat(": ", VisionBlur);
			GKILCDHJFEG().SetFloat("_EmissionGain", GlassDistortion);
			ABHDNGIHBKE().SetFloat("G:", GlassAberration);
			PGPEMMBJOOG().SetColor("settings.hitvariation", GlassesColor);
			IIJMIPBMMBF().SetColor("#no", GlassesColor2);
			PGPEMMBJOOG().SetColor("offsets", GlassColor);
			HKGAONMOBMH().SetFloat("SetTrailZoomSpeed", UseScanLineSize);
			ADBKPGFMNKO().SetFloat("float,2", UseScanLine);
			ABHDNGIHBKE().SetTexture("type", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DHENLPJJOEN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HDMDKOKOOJC()
	{
		FPHEBLMINDA = Resources.Load("Options") as Texture2D;
		SCShader = Shader.Find("Drop_With_Obj");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OIBMHPIFAKK()
	{
	}

	[SpecialName]
	private Material NFMGLIKNOOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)89;
		}
		return BJFKDHHMLJH;
	}

	private void AEMGPJDJGBJ()
	{
		FPHEBLMINDA = Resources.Load("table") as Texture2D;
		SCShader = Shader.Find("init");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1937f)
			{
				HBJJOCHGOPH = 97f;
			}
			MNLKBFFKHIE().SetFloat("Feb", HBJJOCHGOPH);
			MNLKBFFKHIE().SetFloat("[PlayerBase] Loaded music", UseFinalGlassColor);
			IIJMIPBMMBF().SetFloat("mapselector.filter.officialsortmode", Fade);
			EPCGJFCCAFH().SetFloat("_ScreenResolution", VisionBlur);
			FLOHGDECHHH().SetFloat("id", GlassDistortion);
			KBOPGONOCNP().SetFloat("file://", GlassAberration);
			GKILCDHJFEG().SetColor("inventory.itemscash", GlassesColor);
			NBPKMLMCHFN.SetColor("BitsData", GlassesColor2);
			ABHDNGIHBKE().SetColor("_BlurParams", GlassColor);
			NBPKMLMCHFN.SetFloat(" not found", UseScanLineSize);
			HKGAONMOBMH().SetFloat("#yes", UseScanLine);
			IIJMIPBMMBF().SetTexture("FullscreenToggle", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 78f)
			{
				HBJJOCHGOPH = 778f;
			}
			LDNADDJMIPK().SetFloat("player.mysteryitem", HBJJOCHGOPH);
			OIBHFCLJKDB().SetFloat("_SearchTex", UseFinalGlassColor);
			MNLKBFFKHIE().SetFloat("_Value4", Fade);
			FLOHGDECHHH().SetFloat("maps.", VisionBlur);
			FLOHGDECHHH().SetFloat("_Red_B", GlassDistortion);
			ABHDNGIHBKE().SetFloat("_Distortion", GlassAberration);
			HKGAONMOBMH().SetColor("_SunColor", GlassesColor);
			KBOPGONOCNP().SetColor("_CenterY", GlassesColor2);
			ADBKPGFMNKO().SetColor("#later", GlassColor);
			KDMBOKLMADJ().SetFloat("The given 2D texture ", UseScanLineSize);
			EPCGJFCCAFH().SetFloat("Object ID. Case-Sensitive", UseScanLine);
			LONNIJMNKFB().SetTexture("OK", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GLEJGFLCLPJ()
	{
		FPHEBLMINDA = Resources.Load("_Value4") as Texture2D;
		SCShader = Shader.Find("_NoiseTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LCDJFJIBADI()
	{
	}

	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1953f)
			{
				HBJJOCHGOPH = 368f;
			}
			OIBHFCLJKDB().SetFloat(",", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("+", UseFinalGlassColor);
			NBPKMLMCHFN.SetFloat("player.quantum", Fade);
			MNLKBFFKHIE().SetFloat("#{0:00} '{1}'{2} {3}", VisionBlur);
			LDNADDJMIPK().SetFloat("OpSetPropertiesOfActor()", GlassDistortion);
			ECCPAOBFDKP().SetFloat("finished", GlassAberration);
			JCPDCGIJKJD().SetColor("_SizeX", GlassesColor);
			OIBHFCLJKDB().SetColor("_SunThreshold", GlassesColor2);
			ECCPAOBFDKP().SetColor("Illegal view ID:", GlassColor);
			NDMPCDHADMJ().SetFloat("1278033234", UseScanLineSize);
			FLOHGDECHHH().SetFloat("The shader ", UseScanLine);
			PGPEMMBJOOG().SetTexture("set id", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PAKPHKPDKGE()
	{
		FPHEBLMINDA = Resources.Load("_Offsets") as Texture2D;
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MKOMIDCPCDC()
	{
		FPHEBLMINDA = Resources.Load("UseScanLineSize") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Oculus_NightVision5");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void COIJKMKIEAK()
	{
		FPHEBLMINDA = Resources.Load("_ScreenResolution") as Texture2D;
		SCShader = Shader.Find("BitsData");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HONBLGFDMLL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LDDKCCMHMIC()
	{
	}

	private void EPJJDKJEDMM()
	{
	}

	private void BFEILOMHNPC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}
}
