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
			PGPEMMBJOOG().SetFloat("CameraFilterPack_VHS1", HBJJOCHGOPH);
			NDMPCDHADMJ().SetFloat("CreateRoom failed, client stays on masterserver: {0}.", UseFinalGlassColor);
			ECCPAOBFDKP().SetFloat("CameraFilterPack/FX_DigitalMatrixDistortion", Fade);
			LDNADDJMIPK().SetFloat("_TimeX", VisionBlur);
			HKGAONMOBMH().SetFloat("StartTime already set: ", GlassDistortion);
			FLOHGDECHHH().SetFloat("Object ID. Case-Sensitive", GlassAberration);
			ADBKPGFMNKO().SetColor("_Max", GlassesColor);
			KBOPGONOCNP().SetColor("#savemapbeforeuploading", GlassesColor2);
			EPCGJFCCAFH().SetColor("_Value3", GlassColor);
			FLOHGDECHHH().SetFloat("#forever", UseScanLineSize);
			OIBHFCLJKDB().SetFloat("PAUSE [SPACE]", UseScanLine);
			KBOPGONOCNP().SetTexture("BadgeImage", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NDMPCDHADMJ());
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
			EPCGJFCCAFH().SetFloat("icon", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("_TimeX", UseFinalGlassColor);
			ECCPAOBFDKP().SetFloat("nd", Fade);
			NFMGLIKNOOC().SetFloat("Scenes List:", VisionBlur);
			PGPEMMBJOOG().SetFloat("ChallengesButton", GlassDistortion);
			PGPEMMBJOOG().SetFloat("RateButton", GlassAberration);
			KBOPGONOCNP().SetColor("_Value", GlassesColor);
			KDMBOKLMADJ().SetColor("[ReplayScene] Loading replay: ", GlassesColor2);
			IIJMIPBMMBF().SetColor("[PlayerBase] Loaded custom model: ", GlassColor);
			PGPEMMBJOOG().SetFloat("_TimeX", UseScanLineSize);
			KBOPGONOCNP().SetFloat("_TimeX", UseScanLine);
			NBPKMLMCHFN.SetTexture("USE_UV_BASED_REPROJECTION", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FLKEJJEGCFA()
	{
		FPHEBLMINDA = Resources.Load("uploads/Intralism/mods_terms.pdf") as Texture2D;
		SCShader = Shader.Find("_MaxRayTraceDistance");
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
		SCShader = Shader.Find("Fade");
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
		FPHEBLMINDA = Resources.Load("_MainTex") as Texture2D;
		SCShader = Shader.Find("0.00/0.00");
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
			KDMBOKLMADJ().SetFloat("No info", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("_Value3", UseFinalGlassColor);
			ABHDNGIHBKE().SetFloat("#accuracy", Fade);
			HKGAONMOBMH().SetFloat("Error: Timeout :S", VisionBlur);
			IIJMIPBMMBF().SetFloat("_MainTex2", GlassDistortion);
			EPCGJFCCAFH().SetFloat("OpSetPropertiesOfActor()", GlassAberration);
			LONNIJMNKFB().SetColor("plainText", GlassesColor);
			NDMPCDHADMJ().SetColor("st", GlassesColor2);
			LONNIJMNKFB().SetColor("#currentbpm: ", GlassColor);
			KDMBOKLMADJ().SetFloat("_AdaptTex", UseScanLineSize);
			GKILCDHJFEG().SetFloat("https://api.steampowered.com/IInventoryService/AddItem/v001", UseScanLine);
			ABHDNGIHBKE().SetTexture("Warning: Unhandled Event ErrorInfo (251). Set PhotonNetwork.OnEventCall to the method PUN should call for this event.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ECCPAOBFDKP());
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
			ADBKPGFMNKO().SetFloat("maps.", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("CameraFilterPack/Noise_TV_2", UseFinalGlassColor);
			HKGAONMOBMH().SetFloat("Move environment object to the position", Fade);
			HKGAONMOBMH().SetFloat("No valid adaptive tonemapper type found!", VisionBlur);
			KOHGPKOFEJO().SetFloat(").png", GlassDistortion);
			NFMGLIKNOOC().SetFloat("_Value5", GlassAberration);
			NDMPCDHADMJ().SetColor("Editor/", GlassesColor);
			FLOHGDECHHH().SetColor("[DiscordController] Join ({0})", GlassesColor2);
			MNLKBFFKHIE().SetColor("CameraFilterPack_OldFilm2", GlassColor);
			ECCPAOBFDKP().SetFloat("player.gamecompleted", UseScanLineSize);
			IIJMIPBMMBF().SetFloat("_Green_G", UseScanLine);
			KBOPGONOCNP().SetTexture("float,0", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
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
		FPHEBLMINDA = Resources.Load("_Offsets") as Texture2D;
		SCShader = Shader.Find("_WhiteBalance");
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
			MNLKBFFKHIE().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			FLOHGDECHHH().SetFloat("_Value2", UseFinalGlassColor);
			NBPKMLMCHFN.SetFloat("Error: I/O Failure", Fade);
			HKGAONMOBMH().SetFloat("settings.volume.menu", VisionBlur);
			JCPDCGIJKJD().SetFloat("VHS", GlassDistortion);
			NDMPCDHADMJ().SetFloat("CameraFilterPack_Paper1", GlassAberration);
			ABHDNGIHBKE().SetColor("colorA", GlassesColor);
			ECCPAOBFDKP().SetColor("CameraFilterPack/FX_DigitalMatrix", GlassesColor2);
			HKGAONMOBMH().SetColor("Bad parameters for init! Use \"init\" or \"init <savename>\"", GlassColor);
			MNLKBFFKHIE().SetFloat("CameraFilterPack/Blend2Camera_Divide", UseScanLineSize);
			GKILCDHJFEG().SetFloat("ReJoinRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", UseScanLine);
			KOHGPKOFEJO().SetTexture("DPADVER", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
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
		FPHEBLMINDA = Resources.Load("[DiscordController] Responding yes to Ask to Join request") as Texture2D;
		SCShader = Shader.Find("_Noise");
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
			MNLKBFFKHIE().SetFloat("Couldn't call DestroyAll() as only the master client is allowed to call this.", HBJJOCHGOPH);
			OIBHFCLJKDB().SetFloat("_LowRez", UseFinalGlassColor);
			GKILCDHJFEG().SetFloat("ShineEffect", Fade);
			JCPDCGIJKJD().SetFloat("Working commands:\nreset <challengeid>\nresetall", VisionBlur);
			NFMGLIKNOOC().SetFloat("_History4LumaTex", GlassDistortion);
			KDMBOKLMADJ().SetFloat("MenuRecordButton", GlassAberration);
			NFMGLIKNOOC().SetColor("_Value6", GlassesColor);
			NDMPCDHADMJ().SetColor("Fade", GlassesColor2);
			ECCPAOBFDKP().SetColor("_Value2", GlassColor);
			LDNADDJMIPK().SetFloat("{0:0} day{1}, ", UseScanLineSize);
			LONNIJMNKFB().SetFloat("settings.disablestoryboard", UseScanLine);
			MNLKBFFKHIE().SetTexture(" room(s)", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIBHFCLJKDB());
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
			LONNIJMNKFB().SetFloat("FToA", HBJJOCHGOPH);
			ADBKPGFMNKO().SetFloat("_TimeX", UseFinalGlassColor);
			MNLKBFFKHIE().SetFloat("_Value7", Fade);
			EPCGJFCCAFH().SetFloat("float,1.5", VisionBlur);
			IIJMIPBMMBF().SetFloat("#yes", GlassDistortion);
			ADBKPGFMNKO().SetFloat("_Value6", GlassAberration);
			KOHGPKOFEJO().SetColor("_ScreenResolution", GlassesColor);
			KDMBOKLMADJ().SetColor("Data/Skins/", GlassesColor2);
			NDMPCDHADMJ().SetColor(" not exist", GlassColor);
			EPCGJFCCAFH().SetFloat("_ScreenResolution", UseScanLineSize);
			GKILCDHJFEG().SetFloat(" to: ", UseScanLine);
			JCPDCGIJKJD().SetTexture("\\\\", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JCPDCGIJKJD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JDKHBGDEONK()
	{
		FPHEBLMINDA = Resources.Load("_TimeX") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack_TV_BrokenGlass1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void COOHIILCOCO()
	{
		FPHEBLMINDA = Resources.Load("MouseY") as Texture2D;
		SCShader = Shader.Find("_Green_B");
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
		FPHEBLMINDA = Resources.Load("#reward: ") as Texture2D;
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
			ABHDNGIHBKE().SetFloat("_Value3", HBJJOCHGOPH);
			HKGAONMOBMH().SetFloat("[EMPTY]", UseFinalGlassColor);
			EPCGJFCCAFH().SetFloat("_ColoredChange", Fade);
			NBPKMLMCHFN.SetFloat("inventory.selected.", VisionBlur);
			LDNADDJMIPK().SetFloat("TotalHitsScoreText", GlassDistortion);
			HKGAONMOBMH().SetFloat("float,0", GlassAberration);
			ECCPAOBFDKP().SetColor(".lastCheckpoint.checkpointsUsed", GlassesColor);
			ABHDNGIHBKE().SetColor("Needs to be attached to the Event System component in the scene", GlassesColor2);
			MNLKBFFKHIE().SetColor("_Visualize", GlassColor);
			FLOHGDECHHH().SetFloat("EventMenu", UseScanLineSize);
			OIBHFCLJKDB().SetFloat("0.00", UseScanLine);
			NBPKMLMCHFN.SetTexture("SUBMIT", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ECCPAOBFDKP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KCCIEMBMOBA()
	{
		FPHEBLMINDA = Resources.Load("_TexelOffsetScale") as Texture2D;
		SCShader = Shader.Find("shader.frost");
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
			LDNADDJMIPK().SetFloat("_Threshhold", HBJJOCHGOPH);
			JCPDCGIJKJD().SetFloat(". Not connectedAndReady.", UseFinalGlassColor);
			ADBKPGFMNKO().SetFloat("Middle Click", Fade);
			LONNIJMNKFB().SetFloat("Health Stats", VisionBlur);
			NBPKMLMCHFN.SetFloat("Crosshair", GlassDistortion);
			NDMPCDHADMJ().SetFloat("resource id", GlassAberration);
			ADBKPGFMNKO().SetColor("Object ID. Case-Sensitive", GlassesColor);
			KDMBOKLMADJ().SetColor("_InvRenderTargetSize", GlassesColor2);
			JCPDCGIJKJD().SetColor("_Value", GlassColor);
			KOHGPKOFEJO().SetFloat("_Threshhold", UseScanLineSize);
			LONNIJMNKFB().SetFloat("history", UseScanLine);
			LONNIJMNKFB().SetTexture(".lastCheckpoint.perfectHits", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLOHGDECHHH());
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
		FPHEBLMINDA = Resources.Load("Editor") as Texture2D;
		SCShader = Shader.Find("[Down]");
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
			EPCGJFCCAFH().SetFloat("_Far", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("VHS2", UseFinalGlassColor);
			OIBHFCLJKDB().SetFloat("_CurTex", Fade);
			IIJMIPBMMBF().SetFloat("Item ", VisionBlur);
			NBPKMLMCHFN.SetFloat("UseScanLineSize", GlassDistortion);
			NFMGLIKNOOC().SetFloat("_ScreenResolution", GlassAberration);
			OIBHFCLJKDB().SetColor("]", GlassesColor);
			FLOHGDECHHH().SetColor(".", GlassesColor2);
			ECCPAOBFDKP().SetColor("_EmissionColor", GlassColor);
			KBOPGONOCNP().SetFloat("_AdaptionSpeed", UseScanLineSize);
			MNLKBFFKHIE().SetFloat("_Threshold", UseScanLine);
			ECCPAOBFDKP().SetTexture("SaveButton", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
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
		SCShader = Shader.Find("RecordButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BOPKKCAFODF()
	{
		FPHEBLMINDA = Resources.Load("_EmissionColor") as Texture2D;
		SCShader = Shader.Find("menu.tabid");
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
			NFMGLIKNOOC().SetFloat("0", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Curve", UseFinalGlassColor);
			ECCPAOBFDKP().SetFloat("_TimeX", Fade);
			LONNIJMNKFB().SetFloat("settings.selectormapsperpage", VisionBlur);
			PGPEMMBJOOG().SetFloat("Joystick", GlassDistortion);
			LDNADDJMIPK().SetFloat("[MapsData] Key ", GlassAberration);
			JCPDCGIJKJD().SetColor("x", GlassesColor);
			NFMGLIKNOOC().SetColor("_Blue_G", GlassesColor2);
			ABHDNGIHBKE().SetColor("shader.none", GlassColor);
			LONNIJMNKFB().SetFloat("_Red_C", UseScanLineSize);
			NFMGLIKNOOC().SetFloat("_AlphaHexa", UseScanLine);
			ABHDNGIHBKE().SetTexture("ResourceIDInputField", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
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
			JCPDCGIJKJD().SetFloat("maps.", HBJJOCHGOPH);
			ECCPAOBFDKP().SetFloat("Error: PhotonNetwork.SetInterestGroups was called with an illegal group number: ", UseFinalGlassColor);
			NFMGLIKNOOC().SetFloat("Error: You're not logged into Steam!", Fade);
			LONNIJMNKFB().SetFloat("Offline or in OfflineMode. No VitalStats available.", VisionBlur);
			IIJMIPBMMBF().SetFloat(".lastCheckpoint.penaltyScore", GlassDistortion);
			IIJMIPBMMBF().SetFloat("GlassAberration", GlassAberration);
			MNLKBFFKHIE().SetColor("_Value2", GlassesColor);
			KOHGPKOFEJO().SetColor("_ForceYSwap", GlassesColor2);
			KDMBOKLMADJ().SetColor("_Distortion", GlassColor);
			EPCGJFCCAFH().SetFloat("_FrustumCornersWS", UseScanLineSize);
			PGPEMMBJOOG().SetFloat("_Distortion", UseScanLine);
			ADBKPGFMNKO().SetTexture("Gameplay/Base", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			FLOHGDECHHH().SetFloat("_EmissionGain", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("float,1.5", UseFinalGlassColor);
			FLOHGDECHHH().SetFloat("ConnectToRegion: ", Fade);
			MNLKBFFKHIE().SetFloat("_Value3", VisionBlur);
			KOHGPKOFEJO().SetFloat("CameraFilterPack/Film_ColorPerfection", GlassDistortion);
			NDMPCDHADMJ().SetFloat("Inside cells:\n", GlassAberration);
			NFMGLIKNOOC().SetColor("Turn", GlassesColor);
			FLOHGDECHHH().SetColor("Tab1Content", GlassesColor2);
			NBPKMLMCHFN.SetColor("Value", GlassColor);
			GKILCDHJFEG().SetFloat("_NoiseAmount", UseScanLineSize);
			EPCGJFCCAFH().SetFloat("_Distance", UseScanLine);
			JCPDCGIJKJD().SetTexture("GUICamera", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ECCPAOBFDKP());
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
			OIBHFCLJKDB().SetFloat("No problem found, so far", HBJJOCHGOPH);
			ECCPAOBFDKP().SetFloat("CameraFilterPack/Blur_GaussianBlur", UseFinalGlassColor);
			LDNADDJMIPK().SetFloat("mapselector.orderby", Fade);
			ECCPAOBFDKP().SetFloat("': ", VisionBlur);
			IIJMIPBMMBF().SetFloat("_CenterY", GlassDistortion);
			LDNADDJMIPK().SetFloat("http", GlassAberration);
			KBOPGONOCNP().SetColor("_FadeFromBinary", GlassesColor);
			ECCPAOBFDKP().SetColor("_FgOverlap", GlassesColor2);
			EPCGJFCCAFH().SetColor(". Client should be in a room. Current connectionStateDetailed: ", GlassColor);
			IIJMIPBMMBF().SetFloat("[LocalizationService] All languages: ", UseScanLineSize);
			ABHDNGIHBKE().SetFloat("_ScreenResolution", UseScanLine);
			PGPEMMBJOOG().SetTexture("[Right-Down]", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
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
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DFFKKLAPHCC()
	{
		FPHEBLMINDA = Resources.Load("_Intensity") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Drawing_Manga_Flash");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PKLOBJHKFEO()
	{
		FPHEBLMINDA = Resources.Load("_Distance") as Texture2D;
		SCShader = Shader.Find("note.0");
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
		FPHEBLMINDA = Resources.Load("Joystick1Button8") as Texture2D;
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
			FLOHGDECHHH().SetFloat("_EmissionGain", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("LoadMapCanvas", UseFinalGlassColor);
			ADBKPGFMNKO().SetFloat("Hidden/Image Effects/Cinematic/Bloom", Fade);
			FLOHGDECHHH().SetFloat("arc", VisionBlur);
			GKILCDHJFEG().SetFloat("f", GlassDistortion);
			LONNIJMNKFB().SetFloat("CameraFilterPack/Vision_Blood", GlassAberration);
			HKGAONMOBMH().SetColor("x", GlassesColor);
			MNLKBFFKHIE().SetColor("Health Stats", GlassesColor2);
			NDMPCDHADMJ().SetColor("_TimeX", GlassColor);
			NBPKMLMCHFN.SetFloat("(?<=#)\\w+", UseScanLineSize);
			KOHGPKOFEJO().SetFloat("_Value3", UseScanLine);
			NFMGLIKNOOC().SetTexture("_MatrixColor", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FMFNILJIEIA()
	{
		FPHEBLMINDA = Resources.Load("Registered PhotonView: ") as Texture2D;
		SCShader = Shader.Find("_TimeX");
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
			LDNADDJMIPK().SetFloat("received</b>\n#reason: ", HBJJOCHGOPH);
			NDMPCDHADMJ().SetFloat("Deleted event", UseFinalGlassColor);
			KDMBOKLMADJ().SetFloat("nogamesfound", Fade);
			ABHDNGIHBKE().SetFloat("ReJoinRoom failed due to offline mode.", VisionBlur);
			GKILCDHJFEG().SetFloat("mapselector.filter.rateduponly", GlassDistortion);
			NBPKMLMCHFN.SetFloat("_Value2", GlassAberration);
			EPCGJFCCAFH().SetColor("/", GlassesColor);
			KBOPGONOCNP().SetColor("x", GlassesColor2);
			EPCGJFCCAFH().SetColor(". Prefab must have a PhotonView component.", GlassColor);
			KBOPGONOCNP().SetFloat("_Value4", UseScanLineSize);
			FLOHGDECHHH().SetFloat("EndlessLoopsScoreText", UseScanLine);
			ABHDNGIHBKE().SetTexture("_TimeX", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MNLKBFFKHIE());
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
			NDMPCDHADMJ().SetFloat("[PlayerController] ", HBJJOCHGOPH);
			NDMPCDHADMJ().SetFloat(",", UseFinalGlassColor);
			EPCGJFCCAFH().SetFloat("player.xp", Fade);
			OIBHFCLJKDB().SetFloat("Set Trail Zoom Speed", VisionBlur);
			HKGAONMOBMH().SetFloat("[UI] Unknows button action: ", GlassDistortion);
			FLOHGDECHHH().SetFloat("_Value3", GlassAberration);
			FLOHGDECHHH().SetColor(".lastCheckpoint.playerdistance", GlassesColor);
			OIBHFCLJKDB().SetColor("CameraFilterPack/Blur_Radial", GlassesColor2);
			ADBKPGFMNKO().SetColor("Anomaly_Near", GlassColor);
			ABHDNGIHBKE().SetFloat("_TimeX", UseScanLineSize);
			PGPEMMBJOOG().SetFloat("ColorBlood", UseScanLine);
			ADBKPGFMNKO().SetTexture("ScoreText", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
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
			HKGAONMOBMH().SetFloat("StartRound", HBJJOCHGOPH);
			ADBKPGFMNKO().SetFloat("_RangeScale", UseFinalGlassColor);
			KBOPGONOCNP().SetFloat("maps.", Fade);
			JCPDCGIJKJD().SetFloat("DPADVER", VisionBlur);
			FLOHGDECHHH().SetFloat("[PlayerBase] Delete checkpoint data", GlassDistortion);
			JCPDCGIJKJD().SetFloat("SpawnObj", GlassAberration);
			NBPKMLMCHFN.SetColor("Left Stick Click", GlassesColor);
			HKGAONMOBMH().SetColor("_ScreenResolution", GlassesColor2);
			NDMPCDHADMJ().SetColor("<b>Intralism Items Uploader</b> by Oxy949", GlassColor);
			MNLKBFFKHIE().SetFloat(".workshop", UseScanLineSize);
			NFMGLIKNOOC().SetFloat("_ScreenEdgeFading", UseScanLine);
			ABHDNGIHBKE().SetTexture("value", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLOHGDECHHH());
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
			ECCPAOBFDKP().SetFloat(".GoalProgress", HBJJOCHGOPH);
			ADBKPGFMNKO().SetFloat("--------------------------------", UseFinalGlassColor);
			NFMGLIKNOOC().SetFloat("76561198041679481", Fade);
			KOHGPKOFEJO().SetFloat("LivesSlider", VisionBlur);
			ECCPAOBFDKP().SetFloat("RecieveChatActionMessage", GlassDistortion);
			GKILCDHJFEG().SetFloat("_Value", GlassAberration);
			FLOHGDECHHH().SetColor("76561198041679481", GlassesColor);
			MNLKBFFKHIE().SetColor("_FixDistance", GlassesColor2);
			ADBKPGFMNKO().SetColor("\t", GlassColor);
			NFMGLIKNOOC().SetFloat("[MapEditor] Loading music...", UseScanLineSize);
			JCPDCGIJKJD().SetFloat("AccuracyScoreText", UseScanLine);
			IIJMIPBMMBF().SetTexture("<size=24>", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
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
		FPHEBLMINDA = Resources.Load("3d text") as Texture2D;
		SCShader = Shader.Find("Failed to InstantiateSceneObject prefab: ");
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
			ECCPAOBFDKP().SetFloat("Editor/", HBJJOCHGOPH);
			PGPEMMBJOOG().SetFloat("_Value", UseFinalGlassColor);
			ADBKPGFMNKO().SetFloat("[MenuScene] Error: ", Fade);
			NBPKMLMCHFN.SetFloat(" not exist", VisionBlur);
			JCPDCGIJKJD().SetFloat("_EmissionGain", GlassDistortion);
			JCPDCGIJKJD().SetFloat("{", GlassAberration);
			NDMPCDHADMJ().SetColor("settings.cameramovements", GlassesColor);
			ABHDNGIHBKE().SetColor("#mapalreadyexistupdate", GlassesColor2);
			ECCPAOBFDKP().SetColor("offsets", GlassColor);
			MNLKBFFKHIE().SetFloat("Set Trail Zoom Speed", UseScanLineSize);
			ADBKPGFMNKO().SetFloat("Set satellite trail width", UseScanLine);
			NBPKMLMCHFN.SetTexture("type", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NDMPCDHADMJ());
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
		FPHEBLMINDA = Resources.Load("Joystick1Button10") as Texture2D;
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
		FPHEBLMINDA = Resources.Load("kick") as Texture2D;
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
			OIBHFCLJKDB().SetFloat("Apr", HBJJOCHGOPH);
			PGPEMMBJOOG().SetFloat("CheckCombo", UseFinalGlassColor);
			GKILCDHJFEG().SetFloat("mapselector.filter.favoriteonly", Fade);
			LONNIJMNKFB().SetFloat("_ScreenResolution", VisionBlur);
			IIJMIPBMMBF().SetFloat("id", GlassDistortion);
			ADBKPGFMNKO().SetFloat("file://", GlassAberration);
			JCPDCGIJKJD().SetColor("[ItemsHandler] Item not found:", GlassesColor);
			ECCPAOBFDKP().SetColor("BitsData", GlassesColor2);
			LONNIJMNKFB().SetColor("_BlurParams", GlassColor);
			ECCPAOBFDKP().SetFloat("bool", UseScanLineSize);
			KBOPGONOCNP().SetFloat("#yes", UseScanLine);
			KOHGPKOFEJO().SetTexture("GraphicsQualitySlider", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLOHGDECHHH());
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
			IIJMIPBMMBF().SetFloat("player.neon", HBJJOCHGOPH);
			MNLKBFFKHIE().SetFloat("_Params1", UseFinalGlassColor);
			ECCPAOBFDKP().SetFloat("_Value4", Fade);
			EPCGJFCCAFH().SetFloat("maps.", VisionBlur);
			ECCPAOBFDKP().SetFloat("_Red_B", GlassDistortion);
			OIBHFCLJKDB().SetFloat("_TimeX", GlassAberration);
			NBPKMLMCHFN.SetColor("_BlurSize", GlassesColor);
			OIBHFCLJKDB().SetColor("_Distortion", GlassesColor2);
			FLOHGDECHHH().SetColor("#restart", GlassColor);
			KOHGPKOFEJO().SetFloat(" cannot be used as a 3D LUT.", UseScanLineSize);
			LONNIJMNKFB().SetFloat("color", UseScanLine);
			NFMGLIKNOOC().SetTexture("OK", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GLEJGFLCLPJ()
	{
		FPHEBLMINDA = Resources.Load("_ScreenResolution") as Texture2D;
		SCShader = Shader.Find("_MidGrey");
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
			KBOPGONOCNP().SetFloat("}", HBJJOCHGOPH);
			JCPDCGIJKJD().SetFloat("VoteDownToggle", UseFinalGlassColor);
			HKGAONMOBMH().SetFloat("player.quantum", Fade);
			ABHDNGIHBKE().SetFloat("Messages (shift+tab)", VisionBlur);
			ECCPAOBFDKP().SetFloat("OpSetPropertiesOfRoom()", GlassDistortion);
			MNLKBFFKHIE().SetFloat("ShowSprite", GlassAberration);
			KBOPGONOCNP().SetColor("_SizeX", GlassesColor);
			NDMPCDHADMJ().SetColor("_BlurRadius4", GlassesColor2);
			KDMBOKLMADJ().SetColor(" GO:", GlassColor);
			HKGAONMOBMH().SetFloat("1332644700", UseScanLineSize);
			NDMPCDHADMJ().SetFloat(" is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package.", UseScanLine);
			EPCGJFCCAFH().SetTexture("Case-Sensitive", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PAKPHKPDKGE()
	{
		FPHEBLMINDA = Resources.Load("_BlurredColor") as Texture2D;
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MKOMIDCPCDC()
	{
		FPHEBLMINDA = Resources.Load("UseScanLine") as Texture2D;
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void COIJKMKIEAK()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack/Blend2Camera_ColorKey") as Texture2D;
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
