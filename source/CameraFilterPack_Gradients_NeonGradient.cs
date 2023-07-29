// CameraFilterPack_Gradients_NeonGradient
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Gradients/Neon")]
public class CameraFilterPack_Gradients_NeonGradient : MonoBehaviour
{
	public Shader SCShader;

	private string ELOFMLPCCEA = "CameraFilterPack/Gradients_NeonGradient";

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 1f)]
	public float Switch = 1f;

	[Range(0f, 1f)]
	public float Fade = 1f;

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

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ODGMCJILIHF()
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-107);
		}
		return BJFKDHHMLJH;
	}

	private void JOONHGHGKKF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HFBJAOFLCJI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material OLHDPICFBOF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void FBPHNEJBDJN()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PKHPNHBEKHA()
	{
	}

	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 399f)
			{
				HBJJOCHGOPH = 1397f;
			}
			JCPDCGIJKJD().SetFloat("_TimeX", HBJJOCHGOPH);
			KDMBOKLMADJ().SetFloat(" not exist", Switch);
			HEINDEMCGIK().SetFloat("\" marked with the [PunRPC](C#) or @PunRPC(JS) property! Args: ", Fade);
			NFKFAAHHLLM().SetVector("skin.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1187f, 1339f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EPJJDKJEDMM()
	{
	}

	private void OFPPIKHNJOD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NAOLAJPDGIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JIAAFKOPEKO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 404f)
			{
				HBJJOCHGOPH = 838f;
			}
			INOBFNCKFGK().SetFloat("_NormalAndRoughnessTexture", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("ControllerRightX", Switch);
			OLHDPICFBOF().SetFloat("CameraFilterPack/BlurTiltShift_Hole", Fade);
			NBPKMLMCHFN.SetVector("CameraFilterPack/Pixelisation_OilPaint", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1533f, 875f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOMEEFLPEPJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HHLFDHNEIAH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void LMADKINICIN()
	{
	}

	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 206f)
			{
				HBJJOCHGOPH = 93f;
			}
			CIAFLBFJLEJ().SetFloat("_Red_B", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("#reward: ", Switch);
			JFDGLLEOPGB().SetFloat("[LevelEditorScene] Exported to ", Fade);
			ABHDNGIHBKE().SetVector("?page=addtip", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 180f, 1256f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PHJLHCMCCKE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DPIPGGDNGHN()
	{
	}

	private void OKHBBIKDIEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1275f)
			{
				HBJJOCHGOPH = 1353f;
			}
			PGPEMMBJOOG().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("Bad parameters for init! Use \"init\" or \"init <savename>\"", Switch);
			DOMEEFLPEPJ().SetFloat("achievements.21.completed.", Fade);
			CIAFLBFJLEJ().SetVector("tip", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 670f, 923f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	private void IKIDIJLIGOH()
	{
	}

	private void KMCPMOGKDEH()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
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
			if (HBJJOCHGOPH > 1292f)
			{
				HBJJOCHGOPH = 1818f;
			}
			FHFLKLMFHOI().SetFloat("#onrankchangeuptext", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("CameraFilterPack/Pixelisation_Dot", Switch);
			OKJOKHGJHGF().SetFloat(">", Fade);
			OKJOKHGJHGF().SetVector("_BlurParams", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1770f, 1048f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MNBPNHNAEBK()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ELGOMIMONOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 590f)
			{
				HBJJOCHGOPH = 363f;
			}
			JCPDCGIJKJD().SetFloat("_EmissionColor", HBJJOCHGOPH);
			HEINDEMCGIK().SetFloat("SpawnObj", Switch);
			HEINDEMCGIK().SetFloat("CameraFilterPack_Broken_Screen1", Fade);
			HEINDEMCGIK().SetVector("x", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1643f, 1177f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DDFCIOMKEEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1955f)
			{
				HBJJOCHGOPH = 1292f;
			}
			CIAFLBFJLEJ().SetFloat("CameraFilterPack/TV_Chromatical2", HBJJOCHGOPH);
			DOMEEFLPEPJ().SetFloat("_DistCenterScale", Switch);
			CIAFLBFJLEJ().SetFloat("_Value3", Fade);
			NFKFAAHHLLM().SetVector("TotalHitsScoreText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1515f, 1921f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AEOLJEIDMDB()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material HEINDEMCGIK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void ICDBMJKMIKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CBIBDOIBJAI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JKFDDNMPOJH()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NKFDNIAKGEO()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HIFLPHLGLFG()
	{
	}

	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 619f)
			{
				HBJJOCHGOPH = 233f;
			}
			PGPEMMBJOOG().SetFloat("http://steamcommunity.com/sharedfiles/filedetails/?id=", HBJJOCHGOPH);
			DOMEEFLPEPJ().SetFloat("\n", Switch);
			NFKFAAHHLLM().SetFloat("\" gets executed locally only, if at all.", Fade);
			OLHDPICFBOF().SetVector("</color>", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 290f, 351f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material NFKFAAHHLLM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material GJHLADDCMFF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void ELDMKIAPNGP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PAKPHKPDKGE()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IFJDKDFLGBG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material INOBFNCKFGK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1827f)
			{
				HBJJOCHGOPH = 1448f;
			}
			CIAFLBFJLEJ().SetFloat("_MainTex2", HBJJOCHGOPH);
			HEINDEMCGIK().SetFloat("CameraFilterPack_Sweater", Switch);
			JCPDCGIJKJD().SetFloat("Joystick1Button8", Fade);
			CIAFLBFJLEJ().SetVector(". Verify the Prefab is in a Resources folder (and not in a subfolder)", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 593f, 1778f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 76f)
			{
				HBJJOCHGOPH = 1231f;
			}
			HHLFDHNEIAH().SetFloat("_MotionBlurTmpCam", HBJJOCHGOPH);
			INOBFNCKFGK().SetFloat("Despawn environment object by id", Switch);
			ABHDNGIHBKE().SetFloat("_History1Weight", Fade);
			CIAFLBFJLEJ().SetVector("SelectorMapsCountSlider", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1832f, 248f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 927f)
			{
				HBJJOCHGOPH = 109f;
			}
			INOBFNCKFGK().SetFloat("No info", HBJJOCHGOPH);
			JLHLHKPHDFO().SetFloat("_TimeX", Switch);
			GJHLADDCMFF().SetFloat("[MapsData] Preloading workshop", Fade);
			HHLFDHNEIAH().SetVector("_InternalLutTex", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 876f, 1729f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOMEEFLPEPJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FABKIGNFECE()
	{
	}

	private void EDBEHEKMGFH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JHPOIOELNCG()
	{
	}

	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 317f)
			{
				HBJJOCHGOPH = 307f;
			}
			OLHDPICFBOF().SetFloat("_Bullet_6", HBJJOCHGOPH);
			OLHDPICFBOF().SetFloat("ScrollPanel", Switch);
			NBPKMLMCHFN.SetFloat("settings_bindings_", Fade);
			GJHLADDCMFF().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 49f, 1892f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EJJEDJIOFAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JAAJECBCCFM()
	{
	}

	private void GBGAMCPNBCC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material CIAFLBFJLEJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.HideInInspector | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material GCDFNHMJMIP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void ECBILENEOOL()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IKDNLHLBHID()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NNBCLMJGFEN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DFFKKLAPHCC()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GFACKFCEIBC()
	{
	}

	private void KDMANOEMOCA()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GJCOELHNLJE()
	{
	}

	private void OMIHEBMMCPG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 129f)
			{
				HBJJOCHGOPH = 390f;
			}
			JCPDCGIJKJD().SetFloat("Set Sun Emission", HBJJOCHGOPH);
			JCPDCGIJKJD().SetFloat("[Down]", Switch);
			JCPDCGIJKJD().SetFloat("\t", Fade);
			HEINDEMCGIK().SetVector("RecieveChatActionMessage", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1053f, 52f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LEAHIBJDMBI()
	{
	}

	[SpecialName]
	private Material JCPDCGIJKJD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void OFIMMFHFHDD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material JFDGLLEOPGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-73);
		}
		return BJFKDHHMLJH;
	}

	private void KLDNGKBMDAN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FODKODGPPDA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 142f)
			{
				HBJJOCHGOPH = 1798f;
			}
			GJHLADDCMFF().SetFloat("resource", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_EmissionGain", Switch);
			JCPDCGIJKJD().SetFloat("CameraFilterPack/Vision_AuraDistortion", Fade);
			OKJOKHGJHGF().SetVector("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1417f, 1928f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, INOBFNCKFGK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material JLHLHKPHDFO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-108);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material EMDFHOKEGNG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)106;
		}
		return BJFKDHHMLJH;
	}

	private void BMNOHLNANIP()
	{
	}

	private void DBEMDAJDDDA()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
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
			if (HBJJOCHGOPH > 1020f)
			{
				HBJJOCHGOPH = 1587f;
			}
			ABHDNGIHBKE().SetFloat("LevelEditor/CustomEventEditor-", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("#pleasewait", Switch);
			OLHDPICFBOF().SetFloat("_Intensity", Fade);
			OLHDPICFBOF().SetVector("_BlurredColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 291f, 1323f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HCIPECAOGIA()
	{
	}

	[SpecialName]
	private Material EOCCJGIGEGJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-72);
		}
		return BJFKDHHMLJH;
	}

	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 401f)
			{
				HBJJOCHGOPH = 1962f;
			}
			GJHLADDCMFF().SetFloat(".lastCheckpoint.lives", HBJJOCHGOPH);
			GJHLADDCMFF().SetFloat("_DepthLevel", Switch);
			GJHLADDCMFF().SetFloat("offline room", Fade);
			NBPKMLMCHFN.SetVector("Up ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1224f, 825f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MFMIODIAKNI()
	{
	}

	private void GENCBNFIILN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 468f)
			{
				HBJJOCHGOPH = 1033f;
			}
			NFKFAAHHLLM().SetFloat("CameraFilterPack/TV_Artefact", HBJJOCHGOPH);
			JLHLHKPHDFO().SetFloat("RoomNameText", Switch);
			OLHDPICFBOF().SetFloat("CameraFilterPack/RainFX", Fade);
			NFKFAAHHLLM().SetVector("_Value4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1112f, 540f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHLFDHNEIAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 974f)
			{
				HBJJOCHGOPH = 535f;
			}
			HEINDEMCGIK().SetFloat("[GameEvent] Exeption:", HBJJOCHGOPH);
			GCDFNHMJMIP().SetFloat("ArcsDestroyDelaySlider", Switch);
			HEINDEMCGIK().SetFloat("Connection error: ", Fade);
			JFDGLLEOPGB().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 578f, 846f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JCPDCGIJKJD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PAEGLMEOKHP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KLILJHJNICK()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NJBMCJOOMMP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1456f)
			{
				HBJJOCHGOPH = 1766f;
			}
			GCDFNHMJMIP().SetFloat("FileMenu", HBJJOCHGOPH);
			GJHLADDCMFF().SetFloat("Copy from ", Switch);
			HFBJAOFLCJI().SetFloat("{0}\n{1}\n{2}\n{3}\n{4}\n{5}", Fade);
			OKJOKHGJHGF().SetVector("Hex value #RRGGBB", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1759f, 1071f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 439f)
			{
				HBJJOCHGOPH = 976f;
			}
			GJHLADDCMFF().SetFloat("inventory.selected.", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("settings.volume.sfx", Switch);
			EMDFHOKEGNG().SetFloat("Most likely the game became empty during the switch to GameServer.", Fade);
			INOBFNCKFGK().SetVector("_DistortionSize", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1915f, 223f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MMOKKAPFGAK()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JDGFCEPDKAJ()
	{
	}

	private void JOACBIEHHCE()
	{
	}

	[SpecialName]
	private Material KDMBOKLMADJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void MECJHOJPODB()
	{
	}

	private void NNFMIAFHMJM()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 123f)
			{
				HBJJOCHGOPH = 728f;
			}
			HHLFDHNEIAH().SetFloat("_Blue_R", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Blue_B", Switch);
			EOCCJGIGEGJ().SetFloat("_TimeX", Fade);
			DOMEEFLPEPJ().SetVector("HandsCountSlider", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 766f, 874f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JCPDCGIJKJD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1739f)
			{
				HBJJOCHGOPH = 865f;
			}
			NFKFAAHHLLM().SetFloat("CameraFilterPack/Drawing_Laplacian", HBJJOCHGOPH);
			INOBFNCKFGK().SetFloat("maps.", Switch);
			KDMBOKLMADJ().SetFloat("settings.volume.sfx", Fade);
			JCPDCGIJKJD().SetVector("Can't start OFFLINE mode while connected!", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1916f, 432f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
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

	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 679f)
			{
				HBJJOCHGOPH = 906f;
			}
			EOCCJGIGEGJ().SetFloat("_Value2", HBJJOCHGOPH);
			NFKFAAHHLLM().SetFloat("_ScreenResolution", Switch);
			JFDGLLEOPGB().SetFloat("Custom Authentication failed (either due to user-input or configuration or AuthParameter string format). Calling: OnCustomAuthenticationFailed()", Fade);
			HEINDEMCGIK().SetVector("Backward", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 671f, 194f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1107f)
			{
				HBJJOCHGOPH = 321f;
			}
			HFBJAOFLCJI().SetFloat("SpectateButton", HBJJOCHGOPH);
			GJHLADDCMFF().SetFloat("#rt", Switch);
			ABHDNGIHBKE().SetFloat("_FadeFX", Fade);
			INOBFNCKFGK().SetVector("Texture2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 839f, 951f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material OKJOKHGJHGF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-112);
		}
		return BJFKDHHMLJH;
	}

	private void JNBPKNNBMDI()
	{
	}

	private void MAOCOEGAFND()
	{
	}

	private void NDAJBJFJGCF()
	{
	}

	private void AAPKBNDHBLI()
	{
	}

	private void DKGBFNCOAEO()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material PGPEMMBJOOG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void MGFFNGEGFDC()
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
			NBPKMLMCHFN.SetFloat("_Value", Switch);
			NBPKMLMCHFN.SetFloat("_Value2", Fade);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CCLNNLCOPBL()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JABNHMIHBHC()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1826f)
			{
				HBJJOCHGOPH = 390f;
			}
			INOBFNCKFGK().SetFloat("#onrankchangedowntext", HBJJOCHGOPH);
			NFKFAAHHLLM().SetFloat("_Intensity", Switch);
			EOCCJGIGEGJ().SetFloat(".highscore", Fade);
			GCDFNHMJMIP().SetVector("_EmissionColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 683f, 1422f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CGDMLHLJIDK()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material DOMEEFLPEPJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void BOLBPPHJBMI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AEDDNDHCLNN()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ADPLHDFJFID()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JHANGPCOCIG()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1369f)
			{
				HBJJOCHGOPH = 1298f;
			}
			ABHDNGIHBKE().SetFloat("|", HBJJOCHGOPH);
			OKJOKHGJHGF().SetFloat("SetRoomStartTimestamp", Switch);
			PGPEMMBJOOG().SetFloat("_Value2", Fade);
			HEINDEMCGIK().SetVector("skin.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1724f, 824f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHLFDHNEIAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HPFOFGJPNCI()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EFJDNLGNACH()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IHHNCCOGLPN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DBLILJGKGHJ()
	{
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NEKCPLGFOFD()
	{
	}

	private void EKCKJLFFAID()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1506f)
			{
				HBJJOCHGOPH = 1825f;
			}
			CIAFLBFJLEJ().SetFloat("_Far", HBJJOCHGOPH);
			EMDFHOKEGNG().SetFloat("Mine", Switch);
			DOMEEFLPEPJ().SetFloat("#exit", Fade);
			HHLFDHNEIAH().SetVector("#mapalreadyexistupdate", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1121f, 842f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 571f)
			{
				HBJJOCHGOPH = 50f;
			}
			FHFLKLMFHOI().SetFloat(": ", HBJJOCHGOPH);
			FHFLKLMFHOI().SetFloat("_FlipAlphaMask", Switch);
			EOCCJGIGEGJ().SetFloat("menu.selectedlevelid", Fade);
			NFKFAAHHLLM().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1766f, 568f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JCPDCGIJKJD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 120f)
			{
				HBJJOCHGOPH = 1561f;
			}
			GCDFNHMJMIP().SetFloat("Please attach component to a Graphical UI component", HBJJOCHGOPH);
			GCDFNHMJMIP().SetFloat("powerup.0", Switch);
			HHLFDHNEIAH().SetFloat("ItemTemplate", Fade);
			HFBJAOFLCJI().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1369f, 1290f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material FHFLKLMFHOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-69);
		}
		return BJFKDHHMLJH;
	}
}
