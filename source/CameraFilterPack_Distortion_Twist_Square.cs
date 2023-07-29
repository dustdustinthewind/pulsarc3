// CameraFilterPack_Distortion_Twist_Square
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Distortion/Twist_Square")]
[ExecuteInEditMode]
public class CameraFilterPack_Distortion_Twist_Square : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(-2f, 2f)]
	public float CenterX = 0.5f;

	[Range(-2f, 2f)]
	public float CenterY = 0.5f;

	[Range(-3.14f, 3.14f)]
	public float Distortion = 0.5f;

	[Range(-2f, 2f)]
	public float Size = 0.25f;

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

	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 380f)
			{
				HBJJOCHGOPH = 1925f;
			}
			HEHKGPKLAKK().SetFloat("event", HBJJOCHGOPH);
			JDMJJGEHMJO().SetFloat("received</b>\n#reason: ", CenterX);
			PDEAHJPOMEF().SetFloat("CheckpointsScoreText", CenterY);
			OLHDPICFBOF().SetFloat("SetParticlesGravity", Distortion);
			IKAEIOAHPKI().SetFloat("_Value2", Size);
			NBPKMLMCHFN.SetVector("AreaTex", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PGMMBADJIKH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DBEMDAJDDDA()
	{
		SCShader = Shader.Find("_SSAO");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NCNPAKFAFOE()
	{
		SCShader = Shader.Find(". Not Destroying GameObject or PhotonViews!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material OPMDBHHACME()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material FAIFBBGFAIB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)110;
		}
		return BJFKDHHMLJH;
	}

	private void ABEIEGDHBNO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KOFAMEKHHGD()
	{
		SCShader = Shader.Find("inventory.selected.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material HEHKGPKLAKK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-123);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IKAEIOAHPKI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void GGPDKCHEBAG()
	{
	}

	[SpecialName]
	private Material ACHNOHCLGOO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-89);
		}
		return BJFKDHHMLJH;
	}

	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 412f)
			{
				HBJJOCHGOPH = 1524f;
			}
			EOCCJGIGEGJ().SetFloat("VisionBlur", HBJJOCHGOPH);
			IOHHLNAPGMA().SetFloat("IncorrectHitsScoreText", CenterX);
			EOCCJGIGEGJ().SetFloat("inventory.selected.", CenterY);
			IGKFMCPDNOI().SetFloat("_CenterX", Distortion);
			FKEOGPDLBDD().SetFloat("[", Size);
			OIIDAKBILMI().SetVector("[LevelEditorScene] Map submitted!", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MPENCEIGLEH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BDBJEDIOKBN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material DKKBFFHBHJE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void BKIGIIINEDH()
	{
		SCShader = Shader.Find("SetScale");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KNBJBNDGCIJ()
	{
		SCShader = Shader.Find(" timeUntilRespawn: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AEOLJEIDMDB()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OBAEDJJDCPN()
	{
	}

	private void FABKIGNFECE()
	{
	}

	private void NHHCGPAMLAJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1373f)
			{
				HBJJOCHGOPH = 1789f;
			}
			OIIDAKBILMI().SetFloat("_Size", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("_Parasite", CenterX);
			HEHKGPKLAKK().SetFloat("maps.", CenterY);
			FKEOGPDLBDD().SetFloat("RULES", Distortion);
			KBOPGONOCNP().SetFloat("_SecondTex", Size);
			KGOLDDBHIFN().SetVector("maps.", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material IOHHLNAPGMA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1774f)
			{
				HBJJOCHGOPH = 1096f;
			}
			KDMBOKLMADJ().SetFloat("_Value3", HBJJOCHGOPH);
			FKEOGPDLBDD().SetFloat("Can't do manual instantiation without PhotonView component.", CenterX);
			OLHDPICFBOF().SetFloat("settings.arcsnohitsoundtimedelay", CenterY);
			PDEAHJPOMEF().SetFloat("Chat", Distortion);
			FEAEGGCNIAA().SetFloat("_TimeX", Size);
			MPENCEIGLEH().SetVector("_ScreenResolution", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LFAFJKJAEEL()
	{
		SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material ALABBJPHCNG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)83;
		}
		return BJFKDHHMLJH;
	}

	private void IGPCNCJIEOJ()
	{
		SCShader = Shader.Find("GameObject ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AEIJFLJEABG()
	{
	}

	private void MKOMIDCPCDC()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HMPGIFBJFIK()
	{
		SCShader = Shader.Find("_DistanceParams");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MGFFNGEGFDC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MJNPIDGNJMK()
	{
	}

	private void HDMDKOKOOJC()
	{
		SCShader = Shader.Find("EditMenu");
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
			NBPKMLMCHFN.SetFloat("_CenterX", CenterX);
			NBPKMLMCHFN.SetFloat("_CenterY", CenterY);
			NBPKMLMCHFN.SetFloat("_Distortion", Distortion);
			NBPKMLMCHFN.SetFloat("_Size", Size);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EDPDMBFLHLP()
	{
		SCShader = Shader.Find("_Blend");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 698f)
			{
				HBJJOCHGOPH = 1824f;
			}
			KDMBOKLMADJ().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			HKIMAANBGMJ().SetFloat("Edited unlock conditions", CenterX);
			KGOLDDBHIFN().SetFloat("_MatrixColor", CenterY);
			IOHHLNAPGMA().SetFloat("Tab2Content", Distortion);
			OIIDAKBILMI().SetFloat("#ok", Size);
			ALABBJPHCNG().SetVector("_ScreenResolution", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KLKILLCHJHO());
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
			if (HBJJOCHGOPH > 1762f)
			{
				HBJJOCHGOPH = 1799f;
			}
			MFHPKGICPIO().SetFloat("_Offsets", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("[PlayerController] ", CenterX);
			OPMDBHHACME().SetFloat("_Blue_C", CenterY);
			AELJLBOJAIL().SetFloat("_TimeX", Distortion);
			HNFFHCLNBDN().SetFloat("_TimeX", Size);
			ALABBJPHCNG().SetVector("CameraFilterPack/Blend2Camera_Luminosity", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void POIMNOBDBBN()
	{
	}

	private void NPLCENPNJBM()
	{
		SCShader = Shader.Find("MaxLivesSlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material FEAEGGCNIAA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 995f)
			{
				HBJJOCHGOPH = 1488f;
			}
			OIIDAKBILMI().SetFloat(",", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("_TimeX", CenterX);
			NBPKMLMCHFN.SetFloat("mapselector.filter.favoriteonly", CenterY);
			KGOLDDBHIFN().SetFloat("_ScreenResolution", Distortion);
			KGOLDDBHIFN().SetFloat(".sav", Size);
			FKEOGPDLBDD().SetVector("MenuScene", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ALABBJPHCNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OHBNLJOPDDC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material FKEOGPDLBDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void DBLILJGKGHJ()
	{
		SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DNNFHBOOPIN()
	{
		SCShader = Shader.Find("_SpotSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void Update()
	{
	}

	private void MBLDJEFBLFL()
	{
	}

	private void BOLBPPHJBMI()
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

	private void IKDNLHLBHID()
	{
		SCShader = Shader.Find("#close");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KLCAJPOCMPF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 938f)
			{
				HBJJOCHGOPH = 896f;
			}
			OPMDBHHACME().SetFloat("GameObject ", HBJJOCHGOPH);
			MPENCEIGLEH().SetFloat("_Value4", CenterX);
			AELJLBOJAIL().SetFloat("MapEnd", CenterY);
			KDMBOKLMADJ().SetFloat("#forever", Distortion);
			KGOLDDBHIFN().SetFloat("Default UI Material", Size);
			KDMBOKLMADJ().SetVector(".message", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LPCHMEKDCHI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void JNALDALAJLG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GNMGIHFKJIJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NKLIHNJCHOG()
	{
	}

	private void LJIHHJOAJCN()
	{
	}

	private void JONGNKNLLND()
	{
		SCShader = Shader.Find("EventMenu");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LPMINJJPDCH()
	{
	}

	private void OFMNDBNFBDJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GHILDCBCDJI()
	{
	}

	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 351f)
			{
				HBJJOCHGOPH = 1246f;
			}
			IOHHLNAPGMA().SetFloat("HandsCountSlider", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("The server address is 127.0.0.1 (localhost): Make sure the server is running on this machine. Android and iOS emulators have their own localhost.", CenterX);
			DKKBFFHBHJE().SetFloat("LoadPlayerEnvironment", CenterY);
			KBOPGONOCNP().SetFloat("_ColorRGB", Distortion);
			AELJLBOJAIL().SetFloat("_FlipAlphaMask", Size);
			HKIMAANBGMJ().SetVector("Vertical", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DDBOODLPCAM()
	{
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Distortion_Twist_Square");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LBIOIEANMGI()
	{
	}

	[SpecialName]
	private Material JDMJJGEHMJO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material OLHDPICFBOF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void MODENHKMKOC()
	{
		SCShader = Shader.Find("Add Environment Object");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 206f)
			{
				HBJJOCHGOPH = 1963f;
			}
			DKKBFFHBHJE().SetFloat("maps.", HBJJOCHGOPH);
			IOHHLNAPGMA().SetFloat("Beat Detected", CenterX);
			PDEAHJPOMEF().SetFloat("_FixDistance", CenterY);
			KBOPGONOCNP().SetFloat("_Value2", Distortion);
			LPCHMEKDCHI().SetFloat("_Visualize", Size);
			ACHNOHCLGOO().SetVector("ViewMenu", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KLKILLCHJHO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material KDMBOKLMADJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-78);
		}
		return BJFKDHHMLJH;
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

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
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
	private Material IGKFMCPDNOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)96;
		}
		return BJFKDHHMLJH;
	}

	private void KFACDBHDAOD()
	{
	}

	[SpecialName]
	private Material KGOLDDBHIFN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1810f)
			{
				HBJJOCHGOPH = 277f;
			}
			OPMDBHHACME().SetFloat("s", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("Joystick1Button10", CenterX);
			ALABBJPHCNG().SetFloat("received</b>\n#reason: ", CenterY);
			AELJLBOJAIL().SetFloat("y", Distortion);
			MFHPKGICPIO().SetFloat("#outdatedmap! Challenges will not work!", Size);
			KLKILLCHJHO().SetVector("Joystick1Button5", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 344f)
			{
				HBJJOCHGOPH = 11f;
			}
			ALABBJPHCNG().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			IOHHLNAPGMA().SetFloat("_Value2", CenterX);
			ACHNOHCLGOO().SetFloat("_V", CenterY);
			AELJLBOJAIL().SetFloat("[SaveSystem] Init from ", Distortion);
			FKEOGPDLBDD().SetFloat("_Value4", Size);
			MFHPKGICPIO().SetVector("Editor/", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ECBILENEOOL()
	{
		SCShader = Shader.Find("Custom Authentication failed (either due to user-input or configuration or AuthParameter string format). Calling: OnCustomAuthenticationFailed()");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 430f)
			{
				HBJJOCHGOPH = 1098f;
			}
			ACHNOHCLGOO().SetFloat("settings.disablestoryboard", HBJJOCHGOPH);
			MPENCEIGLEH().SetFloat("_MainTex2", CenterX);
			ACHNOHCLGOO().SetFloat("#savemapchanges?", CenterY);
			OPMDBHHACME().SetFloat("Warning, using scrollbors with the Scroll Snap controls is not advised as it causes unpredictable results", Distortion);
			IOHHLNAPGMA().SetFloat("_ScreenResolution", Size);
			HKIMAANBGMJ().SetVector("Editor", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BKGJOECFMID()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)64;
		}
		return BJFKDHHMLJH;
	}

	private void HNMIAKKBMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 167f)
			{
				HBJJOCHGOPH = 1694f;
			}
			HEHKGPKLAKK().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", HBJJOCHGOPH);
			HNFFHCLNBDN().SetFloat("_Value", CenterX);
			KDMBOKLMADJ().SetFloat("_TimeX", CenterY);
			HKIMAANBGMJ().SetFloat("_VelTex", Distortion);
			IGKFMCPDNOI().SetFloat("Editor", Size);
			OPMDBHHACME().SetVector("null", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
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

	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 756f)
			{
				HBJJOCHGOPH = 309f;
			}
			OPMDBHHACME().SetFloat("_Visualize", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("PunPickupSimple", CenterX);
			OLHDPICFBOF().SetFloat("Set Satellite Lerp Speed", CenterY);
			KLKILLCHJHO().SetFloat("_Value4", Distortion);
			FEAEGGCNIAA().SetFloat("achievements.21.progress", Size);
			IGKFMCPDNOI().SetVector("_Value3", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ALABBJPHCNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HMKBLLMIKAB()
	{
	}

	private void OGJJDKENBNC()
	{
		SCShader = Shader.Find("tagElement");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void COGBDFKOHKK()
	{
	}

	private void JEBIBKLHFLB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KFMEAMBLODG()
	{
	}

	private void CCLNNLCOPBL()
	{
		SCShader = Shader.Find("Can't find PhotonView of incoming OwnershipRequest. ViewId not found: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 655f)
			{
				HBJJOCHGOPH = 164f;
			}
			DKKBFFHBHJE().SetFloat("_Value3", HBJJOCHGOPH);
			OPMDBHHACME().SetFloat(":", CenterX);
			KDMBOKLMADJ().SetFloat("PhotonView ID duplicate found: {0}. New: {1} old: {2}. Maybe one wasn't destroyed on scene load?! Check for 'DontDestroyOnLoad'. Destroying old entry, adding new.", CenterY);
			FAIFBBGFAIB().SetFloat("LoadingStatusText", Distortion);
			OPMDBHHACME().SetFloat("_TimeX", Size);
			IOHHLNAPGMA().SetVector("_DistCenterScale", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JBMBNKOOENB()
	{
	}

	[SpecialName]
	private Material LMLENGFLEBD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1113f)
			{
				HBJJOCHGOPH = 1851f;
			}
			IGKFMCPDNOI().SetFloat(" ", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("Texture2", CenterX);
			LMLENGFLEBD().SetFloat(": ", CenterY);
			FKEOGPDLBDD().SetFloat("_TimeX", Distortion);
			FEAEGGCNIAA().SetFloat("remaining: {0:0.000}", Size);
			MFHPKGICPIO().SetVector("...", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1089f)
			{
				HBJJOCHGOPH = 1513f;
			}
			PDEAHJPOMEF().SetFloat("_BlurCoe", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("_MatrixColor", CenterX);
			AELJLBOJAIL().SetFloat("Set satellite color", CenterY);
			LMLENGFLEBD().SetFloat("CameraFilterPack_TV_Noise2", Distortion);
			HEHKGPKLAKK().SetFloat("Xbox Home", Size);
			OLHDPICFBOF().SetVector("--------------------------------", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HNFFHCLNBDN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void OIBMHPIFAKK()
	{
	}

	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 929f)
			{
				HBJJOCHGOPH = 820f;
			}
			OIIDAKBILMI().SetFloat("LevelEditor/patterns", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("You did not select a Hosting Type in your PhotonServerSettings. Please set it up or don't use ConnectUsingSettings().", CenterX);
			FEAEGGCNIAA().SetFloat("DPADVER", CenterY);
			HKIMAANBGMJ().SetFloat(".lastCheckpoint.correctScore", Distortion);
			FEAEGGCNIAA().SetFloat("_Value2", Size);
			IOHHLNAPGMA().SetVector("_Value9", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HIPBNBKNICE()
	{
	}

	private void KKLMPKLKAEM()
	{
	}

	private void AIBNKIDADPI()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 523f)
			{
				HBJJOCHGOPH = 508f;
			}
			FEAEGGCNIAA().SetFloat("[", HBJJOCHGOPH);
			HKIMAANBGMJ().SetFloat("w", CenterX);
			ALABBJPHCNG().SetFloat("masterSteamID", CenterY);
			IOHHLNAPGMA().SetFloat("_Value3", Distortion);
			JDMJJGEHMJO().SetFloat("sounds/no_hit", Size);
			OLHDPICFBOF().SetVector(" with prefix ", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1337f)
			{
				HBJJOCHGOPH = 1552f;
			}
			OPMDBHHACME().SetFloat("CameraFilterPack/Blend2Camera_Darken", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("r", CenterX);
			IOHHLNAPGMA().SetFloat("No Camera attached!", CenterY);
			FKEOGPDLBDD().SetFloat("_StretchWidth", Distortion);
			HEHKGPKLAKK().SetFloat("_Value2", Size);
			JDMJJGEHMJO().SetVector("_Factor", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ALABBJPHCNG());
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
			if (HBJJOCHGOPH > 892f)
			{
				HBJJOCHGOPH = 1314f;
			}
			DKKBFFHBHJE().SetFloat(" Time: ", HBJJOCHGOPH);
			KDMBOKLMADJ().SetFloat("plainText", CenterX);
			EOCCJGIGEGJ().SetFloat("isBunned", CenterY);
			KBOPGONOCNP().SetFloat("_Luminance", Distortion);
			KBOPGONOCNP().SetFloat("ResetButton", Size);
			PDEAHJPOMEF().SetVector("RECORD [R]", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 569f)
			{
				HBJJOCHGOPH = 686f;
			}
			KBOPGONOCNP().SetFloat("PunRespawn with Position.", HBJJOCHGOPH);
			HNFFHCLNBDN().SetFloat("_MatrixSpeed", CenterX);
			EOCCJGIGEGJ().SetFloat("_TimeX", CenterY);
			ACHNOHCLGOO().SetFloat("EndlessLoopsScoreText", Distortion);
			LMLENGFLEBD().SetFloat("_Amount", Size);
			ACHNOHCLGOO().SetVector("PUNCloudBestRegion", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ILCFPCIPENO()
	{
		SCShader = Shader.Find("---");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AOKOLPEGHDD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EIMNPCMHJLJ()
	{
		SCShader = Shader.Find("/?player=");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1229f)
			{
				HBJJOCHGOPH = 1995f;
			}
			KGOLDDBHIFN().SetFloat("Tab2Content", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("_Bullet_1", CenterX);
			KDMBOKLMADJ().SetFloat(" Owner called.", CenterY);
			KLKILLCHJHO().SetFloat("player.lollipop", Distortion);
			KLKILLCHJHO().SetFloat("_Blue_G", Size);
			KDMBOKLMADJ().SetVector("0.00:0.00", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material MPENCEIGLEH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void OCMKCBBCEFG()
	{
	}

	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1909f)
			{
				HBJJOCHGOPH = 713f;
			}
			IGKFMCPDNOI().SetFloat("Middle Click", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("workshop.", CenterX);
			AELJLBOJAIL().SetFloat("No Name", CenterY);
			MFHPKGICPIO().SetFloat("#", Distortion);
			KDMBOKLMADJ().SetFloat("_Offsets", Size);
			OIIDAKBILMI().SetVector("_TimeX", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KMEONPMCNJG()
	{
	}

	private void IBJIBLHJKMG()
	{
		SCShader = Shader.Find("Coroutine container not configured... did you forget to call Init?");
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
			if (HBJJOCHGOPH > 1063f)
			{
				HBJJOCHGOPH = 648f;
			}
			OPMDBHHACME().SetFloat("PublishMapButton", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat("Joystick", CenterX);
			EOCCJGIGEGJ().SetFloat(" #", CenterY);
			KLKILLCHJHO().SetFloat("_BlurCoe", Distortion);
			OPMDBHHACME().SetFloat("Left", Size);
			AELJLBOJAIL().SetVector("AddEnvironmentSprite", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OIKAPFGPLML(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1812f)
			{
				HBJJOCHGOPH = 977f;
			}
			OIIDAKBILMI().SetFloat("offsets", HBJJOCHGOPH);
			OIIDAKBILMI().SetFloat("/icon", CenterX);
			MFHPKGICPIO().SetFloat("_AOTex", CenterY);
			OPMDBHHACME().SetFloat("_Value3", Distortion);
			AELJLBOJAIL().SetFloat("_Amount", Size);
			DKKBFFHBHJE().SetVector("EventData0DropDownList", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JDMJJGEHMJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IBBFFKEAOCE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 860f)
			{
				HBJJOCHGOPH = 703f;
			}
			HNFFHCLNBDN().SetFloat("Jit ", HBJJOCHGOPH);
			MPENCEIGLEH().SetFloat("Received your NickName from server. Updating local value to: {0}", CenterX);
			OIIDAKBILMI().SetFloat("CountEventsGoal", CenterY);
			PDEAHJPOMEF().SetFloat(": ", Distortion);
			AELJLBOJAIL().SetFloat("Save level before uploading?", Size);
			HNFFHCLNBDN().SetVector("CameraFilterPack_Blizzard1", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
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

	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1655f)
			{
				HBJJOCHGOPH = 1458f;
			}
			KBOPGONOCNP().SetFloat("_ExtraLight", HBJJOCHGOPH);
			JDMJJGEHMJO().SetFloat("settings.shaders", CenterX);
			OPMDBHHACME().SetFloat("\n", CenterY);
			IKAEIOAHPKI().SetFloat("CameraFilterPack/TV_WideScreenHorizontal", Distortion);
			MPENCEIGLEH().SetFloat("float,0", Size);
			IGKFMCPDNOI().SetVector("SpectateButton", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IIFCIDDJHPM()
	{
	}

	private void KHIGHFJKPFG()
	{
		SCShader = Shader.Find("[Up]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GNPDGBNDCPL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ANDELGODEOC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void POEMOLBJDLG()
	{
	}

	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1645f)
			{
				HBJJOCHGOPH = 1889f;
			}
			LMLENGFLEBD().SetFloat("_MainTex2", HBJJOCHGOPH);
			OPMDBHHACME().SetFloat("GroupNameText", CenterX);
			ACHNOHCLGOO().SetFloat("\n", CenterY);
			NBPKMLMCHFN.SetFloat("_MainTex2", Distortion);
			FAIFBBGFAIB().SetFloat("76561198041679481", Size);
			IKAEIOAHPKI().SetVector("#exit", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EDDPLJGKLKJ()
	{
	}

	private void MMPHNFPPEHO()
	{
		SCShader = Shader.Find("Texture2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FJNJIHCLODK()
	{
	}

	private void PODKOCOPGLC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1216f)
			{
				HBJJOCHGOPH = 1802f;
			}
			OPMDBHHACME().SetFloat("_BlurVector", HBJJOCHGOPH);
			HEHKGPKLAKK().SetFloat("editorVolume", CenterX);
			AELJLBOJAIL().SetFloat("Testing, the group has toggled [", CenterY);
			JDMJJGEHMJO().SetFloat("time", Distortion);
			JDMJJGEHMJO().SetFloat("/", Size);
			IKAEIOAHPKI().SetVector("_HdrParams", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OPMDBHHACME());
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

	private void KMOCDAOKGLI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HPFIHLMKIPF()
	{
		SCShader = Shader.Find("#forever");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ALMGMOOHLMA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FMFNILJIEIA()
	{
		SCShader = Shader.Find("_CenterY");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.HideInHierarchy | HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material EOCCJGIGEGJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HKIMAANBGMJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 421f)
			{
				HBJJOCHGOPH = 1074f;
			}
			KGOLDDBHIFN().SetFloat("{\"items\":", HBJJOCHGOPH);
			JDMJJGEHMJO().SetFloat(" ", CenterX);
			OPMDBHHACME().SetFloat("OK", CenterY);
			KDMBOKLMADJ().SetFloat(".a", Distortion);
			IGKFMCPDNOI().SetFloat("Can't connect: ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings", Size);
			OPMDBHHACME().SetVector("ticket", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JNBPKNNBMDI()
	{
	}

	private void POENGNEMHJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1073f)
			{
				HBJJOCHGOPH = 1787f;
			}
			EOCCJGIGEGJ().SetFloat("_Bloom5", HBJJOCHGOPH);
			FEAEGGCNIAA().SetFloat("maps.", CenterX);
			KGOLDDBHIFN().SetFloat("_Value2", CenterY);
			OIIDAKBILMI().SetFloat("UI Extensions/UILinearDodge", Distortion);
			OIIDAKBILMI().SetFloat("_Offsets", Size);
			IGKFMCPDNOI().SetVector("_Value2", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MPENCEIGLEH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DGCGGKMNPLD()
	{
	}

	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 231f)
			{
				HBJJOCHGOPH = 1196f;
			}
			IGKFMCPDNOI().SetFloat("CameraFilterPack/TV_Tiles", HBJJOCHGOPH);
			OIIDAKBILMI().SetFloat("_Distance", CenterX);
			FKEOGPDLBDD().SetFloat("Vertical", CenterY);
			KLKILLCHJHO().SetFloat("_ScreenResolution", Distortion);
			FAIFBBGFAIB().SetFloat("_ScreenResolution", Size);
			OLHDPICFBOF().SetVector("_ScreenResolution", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1347f)
			{
				HBJJOCHGOPH = 1531f;
			}
			AELJLBOJAIL().SetFloat("z", HBJJOCHGOPH);
			KDMBOKLMADJ().SetFloat("SetBGColor", CenterX);
			OLHDPICFBOF().SetFloat("settings.hideui", CenterY);
			ALABBJPHCNG().SetFloat("CameraFilterPack/Blur_Regular", Distortion);
			EOCCJGIGEGJ().SetFloat("SpeedSlider", Size);
			HEHKGPKLAKK().SetVector("CheckCombo", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OGLCKDAHOCG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material MFHPKGICPIO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-124);
		}
		return BJFKDHHMLJH;
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1198f)
			{
				HBJJOCHGOPH = 209f;
			}
			OIIDAKBILMI().SetFloat("CameraFilterPack/TV_ARCADE_2", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("note.2", CenterX);
			LPCHMEKDCHI().SetFloat("_FixDistance", CenterY);
			ACHNOHCLGOO().SetFloat("BadgeText", Distortion);
			PDEAHJPOMEF().SetFloat("CameraFilterPack/Atmosphere_Rain_Pro_3D", Size);
			FKEOGPDLBDD().SetVector(" cannot be used as a 3D LUT.", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KPOCGNOKNOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1634f)
			{
				HBJJOCHGOPH = 1284f;
			}
			FEAEGGCNIAA().SetFloat("player.blackwhite", HBJJOCHGOPH);
			HEHKGPKLAKK().SetFloat("_Value13", CenterX);
			FEAEGGCNIAA().SetFloat("[", CenterY);
			LPCHMEKDCHI().SetFloat(".highscore", Distortion);
			MFHPKGICPIO().SetFloat("#reward: ", Size);
			OLHDPICFBOF().SetVector("settings_bindings_controller_type", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MPENCEIGLEH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HAIAHJPCPAG()
	{
		SCShader = Shader.Find("[EditorEvent] Exception: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
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
	private Material KLKILLCHJHO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-118);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material OIIDAKBILMI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void JHJFBCFBKLD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}
}
