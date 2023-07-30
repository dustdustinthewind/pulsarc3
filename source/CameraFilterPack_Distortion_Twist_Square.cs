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
			AELJLBOJAIL().SetFloat("BitsData", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("received</b>\n#reason: ", CenterX);
			IGKFMCPDNOI().SetFloat("CheckpointsScoreText", CenterY);
			IOHHLNAPGMA().SetFloat("SetCrosshairEmission", Distortion);
			JDMJJGEHMJO().SetFloat("_Value", Size);
			DKKBFFHBHJE().SetVector("_ConsoleSettings", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
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
		SCShader = Shader.Find("_TexelOffsetScale");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NCNPAKFAFOE()
	{
		SCShader = Shader.Find("Failed to 'network-remove' GameObject. Client is neither owner nor masterClient taking over for owner who left: ");
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
		SCShader = Shader.Find("MenuScene");
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
			DKKBFFHBHJE().SetFloat("Fade", HBJJOCHGOPH);
			LPCHMEKDCHI().SetFloat("IncorrectHitsScoreText", CenterX);
			ACHNOHCLGOO().SetFloat("inventory.selected.", CenterY);
			KLKILLCHJHO().SetFloat("_TimeX", Distortion);
			KLKILLCHJHO().SetFloat("settings.arcsdestroydelay", Size);
			DKKBFFHBHJE().SetVector("#ok", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
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
		SCShader = Shader.Find("Unknown player asked for PickupItems");
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
			EOCCJGIGEGJ().SetFloat("_CenterY", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("_TimeX", CenterX);
			PDEAHJPOMEF().SetFloat("maps.", CenterY);
			KBOPGONOCNP().SetFloat("There are a few rules that you must accept before submitting your work. Please select \"RULES\" button, if you haven't read them yet.", Distortion);
			IGKFMCPDNOI().SetFloat("_BlurCoe", Size);
			OPMDBHHACME().SetVector(".sawoutdatedmessage", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
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
			KDMBOKLMADJ().SetFloat("_Value", HBJJOCHGOPH);
			KLKILLCHJHO().SetFloat("#rt", CenterX);
			HEHKGPKLAKK().SetFloat("settings.arcsdestroydelay", CenterY);
			OLHDPICFBOF().SetFloat("OnClick", Distortion);
			ALABBJPHCNG().SetFloat("_MainTex2", Size);
			IKAEIOAHPKI().SetVector("_Fade", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LFAFJKJAEEL()
	{
		SCShader = Shader.Find("Map id for");
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
		SCShader = Shader.Find("QuickSave");
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
		SCShader = Shader.Find("CameraFilterPack/Gradients_Stripe");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HMPGIFBJFIK()
	{
		SCShader = Shader.Find("_CameraWS");
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
		SCShader = Shader.Find("_LutTex");
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
			KDMBOKLMADJ().SetFloat("_Value3", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat("grid", CenterX);
			IOHHLNAPGMA().SetFloat("_MatrixColor", CenterY);
			MFHPKGICPIO().SetFloat("Tab2Content", Distortion);
			MPENCEIGLEH().SetFloat("#ok", Size);
			NBPKMLMCHFN.SetVector("_TimeX", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
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
			LPCHMEKDCHI().SetFloat("_Screen", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat(" not exist", CenterX);
			AELJLBOJAIL().SetFloat("_Blue_C", CenterY);
			JDMJJGEHMJO().SetFloat("_MainTex2", Distortion);
			KBOPGONOCNP().SetFloat("CameraFilterPack_TV_Noise3", Size);
			EOCCJGIGEGJ().SetVector("CameraFilterPack/Blend2Camera_Color", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
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
			FKEOGPDLBDD().SetFloat("B:", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("CameraFilterPack/Edge_Neon", CenterX);
			OLHDPICFBOF().SetFloat("mapselector.filter.subscribedonly", CenterY);
			IGKFMCPDNOI().SetFloat("_Distortion2", Distortion);
			HNFFHCLNBDN().SetFloat("Hello", Size);
			ALABBJPHCNG().SetVector("resetall", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
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
		SCShader = Shader.Find("UseScanLine");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DNNFHBOOPIN()
	{
		SCShader = Shader.Find("_AlphaHexa");
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
			DKKBFFHBHJE().SetFloat("QuickSave", HBJJOCHGOPH);
			FKEOGPDLBDD().SetFloat("_Value3", CenterX);
			MFHPKGICPIO().SetFloat("menu.playedsolo", CenterY);
			KLKILLCHJHO().SetFloat("#forever", Distortion);
			MFHPKGICPIO().SetFloat("UI Extensions/UIMultiply", Size);
			MPENCEIGLEH().SetVector(".message", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPCHMEKDCHI());
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
			ALABBJPHCNG().SetFloat("EnvironmentSlider", HBJJOCHGOPH);
			LPCHMEKDCHI().SetFloat(". Check if the server is available.", CenterX);
			KLKILLCHJHO().SetFloat("settings.arcsnohitsoundtimedelay", CenterY);
			HEHKGPKLAKK().SetFloat("_ColorRGB", Distortion);
			HKIMAANBGMJ().SetFloat("_Min", Size);
			KBOPGONOCNP().SetVector("Horizontal", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
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
			HKIMAANBGMJ().SetFloat("maps.", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("Beat Detected", CenterX);
			EOCCJGIGEGJ().SetFloat("_FixDistance", CenterY);
			KGOLDDBHIFN().SetFloat("_Value2", Distortion);
			LPCHMEKDCHI().SetFloat("_Visualize", Size);
			KGOLDDBHIFN().SetVector("#mapnotloaded", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
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
			KDMBOKLMADJ().SetFloat("s", HBJJOCHGOPH);
			KLKILLCHJHO().SetFloat("Joystick1Button9", CenterX);
			AELJLBOJAIL().SetFloat("<b>#", CenterY);
			KDMBOKLMADJ().SetFloat("x", Distortion);
			KLKILLCHJHO().SetFloat("sprite", Size);
			ACHNOHCLGOO().SetVector("Joystick1Button4", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIIDAKBILMI());
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
			HNFFHCLNBDN().SetFloat("_TimeX", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("_Value2", CenterX);
			HKIMAANBGMJ().SetFloat("_U", CenterY);
			OIIDAKBILMI().SetFloat("<command>", Distortion);
			HEHKGPKLAKK().SetFloat("_Value4", Size);
			LMLENGFLEBD().SetVector("#alreadyexist", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MPENCEIGLEH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ECBILENEOOL()
	{
		SCShader = Shader.Find("If you host Photon yourself, make sure to start the 'Instance LoadBalancing' ");
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
			AELJLBOJAIL().SetFloat("settings.enablehitsoundsinrelax", HBJJOCHGOPH);
			IKAEIOAHPKI().SetFloat("UseScanLine", CenterX);
			MPENCEIGLEH().SetFloat("#no", CenterY);
			AELJLBOJAIL().SetFloat("Cancel", Distortion);
			PDEAHJPOMEF().SetFloat("_Size", Size);
			KDMBOKLMADJ().SetVector("#ok", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OPMDBHHACME());
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
			MPENCEIGLEH().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", HBJJOCHGOPH);
			FEAEGGCNIAA().SetFloat("_TimeX", CenterX);
			ALABBJPHCNG().SetFloat("CameraFilterPack/Blur_Dithering2x2", CenterY);
			PDEAHJPOMEF().SetFloat("_Jitter", Distortion);
			HEHKGPKLAKK().SetFloat("LoadMapCanvas", Size);
			ACHNOHCLGOO().SetVector("Received RPC: ", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LMLENGFLEBD());
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
			DKKBFFHBHJE().SetFloat("_Visualize", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("OnPickedUp", CenterX);
			KGOLDDBHIFN().SetFloat("Set Satellite Lerp Speed", CenterY);
			LMLENGFLEBD().SetFloat("_Value4", Distortion);
			LMLENGFLEBD().SetFloat("player.gamecompleted", Size);
			IOHHLNAPGMA().SetVector("_Value2", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB());
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
		SCShader = Shader.Find("HiddenToggle");
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
		SCShader = Shader.Find("Received unknown status code: ");
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
			AELJLBOJAIL().SetFloat("_Value3", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat(".", CenterX);
			ALABBJPHCNG().SetFloat(" Time: ", CenterY);
			ACHNOHCLGOO().SetFloat("LoadingStatusText", Distortion);
			ACHNOHCLGOO().SetFloat("CameraFilterPack/Glasses_On", Size);
			ACHNOHCLGOO().SetVector("DISTORT", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
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
			KGOLDDBHIFN().SetFloat("#{0:00}{1}{2}", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("_ScreenResolution", CenterX);
			LPCHMEKDCHI().SetFloat(": ", CenterY);
			KBOPGONOCNP().SetFloat("_TimeX", Distortion);
			IKAEIOAHPKI().SetFloat("st", Size);
			FEAEGGCNIAA().SetVector("updating", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
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
			FAIFBBGFAIB().SetFloat("_Offsets", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("_MatrixColor", CenterX);
			AELJLBOJAIL().SetFloat("Hex value #RRGGBB", CenterY);
			ALABBJPHCNG().SetFloat("Texture2", Distortion);
			IKAEIOAHPKI().SetFloat("Joystick1Button12", Size);
			FEAEGGCNIAA().SetVector("0.00", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IKAEIOAHPKI());
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
			DKKBFFHBHJE().SetFloat("Added unlock condition", HBJJOCHGOPH);
			JDMJJGEHMJO().SetFloat("Can't change CrcCheckEnabled while being connected. CrcCheckEnabled stays ", CenterX);
			OPMDBHHACME().SetFloat("DPADVER", CenterY);
			ACHNOHCLGOO().SetFloat(".lastCheckpoint.lives", Distortion);
			IOHHLNAPGMA().SetFloat("_Value", Size);
			LPCHMEKDCHI().SetVector("_Value9", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
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
			KDMBOKLMADJ().SetFloat("[", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat("z", CenterX);
			MFHPKGICPIO().SetFloat("roomDescription", CenterY);
			JDMJJGEHMJO().SetFloat("_Value2", Distortion);
			NBPKMLMCHFN.SetFloat("Loaded skin audio", Size);
			FKEOGPDLBDD().SetVector("Received OnSerialization for view ID ", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK());
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
			IGKFMCPDNOI().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("Can't find key ", CenterX);
			OPMDBHHACME().SetFloat("ConnectionTimeout", CenterY);
			IGKFMCPDNOI().SetFloat("_Offsets", Distortion);
			JDMJJGEHMJO().SetFloat("_Value2", Size);
			NBPKMLMCHFN.SetVector("_Factor", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
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
			FAIFBBGFAIB().SetFloat("Destroying GO as global. ID: ", HBJJOCHGOPH);
			KLKILLCHJHO().SetFloat("88f00bdf0ad61b16b803971ebe071962", CenterX);
			JDMJJGEHMJO().SetFloat("0.00", CenterY);
			FAIFBBGFAIB().SetFloat("_AxialAberration", Distortion);
			KBOPGONOCNP().SetFloat("leave", Size);
			JDMJJGEHMJO().SetVector("RECORD [R]", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			JDMJJGEHMJO().SetFloat(" respawn in future: ", HBJJOCHGOPH);
			IKAEIOAHPKI().SetFloat("_MatrixSpeed", CenterX);
			HKIMAANBGMJ().SetFloat("CameraFilterPack/Colors_RgbClamp", CenterY);
			LMLENGFLEBD().SetFloat("EndlessLoopsScoreText", Distortion);
			ACHNOHCLGOO().SetFloat("_TimeX", Size);
			ALABBJPHCNG().SetVector("{0}={2}: {1} \"{3}\"", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ILCFPCIPENO()
	{
		SCShader = Shader.Find("Reset All");
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
			OIIDAKBILMI().SetFloat("Tab2Content", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("CameraFilterPack/TV_BrokenGlass2", CenterX);
			IOHHLNAPGMA().SetFloat("\" for viewID ", CenterY);
			KBOPGONOCNP().SetFloat("other.dust2", Distortion);
			IGKFMCPDNOI().SetFloat("_Blue_R", Size);
			AELJLBOJAIL().SetVector("Creating awesome maps", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
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
			PDEAHJPOMEF().SetFloat("Mouse2", HBJJOCHGOPH);
			IOHHLNAPGMA().SetFloat("workshop.", CenterX);
			IKAEIOAHPKI().SetFloat("No Name", CenterY);
			DKKBFFHBHJE().SetFloat(">", Distortion);
			IGKFMCPDNOI().SetFloat("_Offsets", Size);
			LPCHMEKDCHI().SetVector("_Distortion", new Vector2(Screen.width, Screen.height));
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
		SCShader = Shader.Find("HighScaleShot");
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
			MFHPKGICPIO().SetFloat("TestMapButton", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("^", CenterX);
			EOCCJGIGEGJ().SetFloat("tip", CenterY);
			IOHHLNAPGMA().SetFloat("_BokehParams", Distortion);
			KDMBOKLMADJ().SetFloat("SpawnObj", Size);
			JDMJJGEHMJO().SetVector("Set particles audio input", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKIMAANBGMJ());
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
			NBPKMLMCHFN.SetFloat("offsets", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("NewMusicFileSelector", CenterX);
			KBOPGONOCNP().SetFloat("_Axis", CenterY);
			FEAEGGCNIAA().SetFloat("_Value3", Distortion);
			LMLENGFLEBD().SetFloat("_ScreenResolution", Size);
			HEHKGPKLAKK().SetVector(":", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK());
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
			MFHPKGICPIO().SetFloat("Simulate", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("The authentication ticket expired. You need to connect (and authenticate) again. Disconnecting.", CenterX);
			OPMDBHHACME().SetFloat("PlayMapGoal", CenterY);
			EOCCJGIGEGJ().SetFloat("[PlayerController] ", Distortion);
			LPCHMEKDCHI().SetFloat("/", Size);
			FAIFBBGFAIB().SetVector("_ScreenResolution", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
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
			JDMJJGEHMJO().SetFloat("_PosY", HBJJOCHGOPH);
			LPCHMEKDCHI().SetFloat("settings.shaders", CenterX);
			IGKFMCPDNOI().SetFloat("\n", CenterY);
			ACHNOHCLGOO().SetFloat("_ScreenResolution", Distortion);
			KGOLDDBHIFN().SetFloat("y", Size);
			ACHNOHCLGOO().SetVector("SpectateButton", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
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
		SCShader = Shader.Find("[Down]");
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
			EOCCJGIGEGJ().SetFloat("_MainTex2", HBJJOCHGOPH);
			HNFFHCLNBDN().SetFloat("GroupNameText", CenterX);
			IKAEIOAHPKI().SetFloat("]", CenterY);
			KBOPGONOCNP().SetFloat("_Speed", Distortion);
			FEAEGGCNIAA().SetFloat("appid", Size);
			OPMDBHHACME().SetVector("#tryagain", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
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
		SCShader = Shader.Find("_ScreenResolution");
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
			KGOLDDBHIFN().SetFloat("_OcclusionTexture", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("settings.volume.game", CenterX);
			ACHNOHCLGOO().SetFloat("Is it practically possible?", CenterY);
			KGOLDDBHIFN().SetFloat("{0:0.0} ms ({1:0.} fps)", Distortion);
			KDMBOKLMADJ().SetFloat("#done", Size);
			AELJLBOJAIL().SetVector("_ExposureAdjustment", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KLKILLCHJHO());
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
		SCShader = Shader.Find("-1");
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
		SCShader = Shader.Find("_CenterX");
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
			FEAEGGCNIAA().SetFloat("Unable to get a reward! Try again?", HBJJOCHGOPH);
			OLHDPICFBOF().SetFloat("%", CenterX);
			KBOPGONOCNP().SetFloat("hardcoreinfo", CenterY);
			HKIMAANBGMJ().SetFloat(".b", Distortion);
			MFHPKGICPIO().SetFloat("Best region found in PlayerPrefs. Connecting to: ", Size);
			FKEOGPDLBDD().SetVector("#no", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNFFHCLNBDN());
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
			KLKILLCHJHO().SetFloat("_Bloom4", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("maps.", CenterX);
			AELJLBOJAIL().SetFloat("_Value1", CenterY);
			NBPKMLMCHFN.SetFloat("Please attach component to a Graphical UI component", Distortion);
			LPCHMEKDCHI().SetFloat("_Offsets", Size);
			OIIDAKBILMI().SetVector("_Value2", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
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
			OIIDAKBILMI().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			MPENCEIGLEH().SetFloat("_Distance", CenterX);
			DKKBFFHBHJE().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", CenterY);
			NBPKMLMCHFN.SetFloat("_Value2", Distortion);
			OPMDBHHACME().SetFloat("_ScreenResolution", Size);
			OPMDBHHACME().SetVector("_Value4", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
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
			IOHHLNAPGMA().SetFloat("y", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("checkpoint", CenterX);
			IOHHLNAPGMA().SetFloat("' found!", CenterY);
			PDEAHJPOMEF().SetFloat("_ScreenResolution", Distortion);
			DKKBFFHBHJE().SetFloat("ConfigVersionSlider", Size);
			LPCHMEKDCHI().SetVector("[PlayerBase] Loaded music", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
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
			HEHKGPKLAKK().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			LMLENGFLEBD().SetFloat("note.1", CenterX);
			KGOLDDBHIFN().SetFloat("_FixDistance", CenterY);
			JDMJJGEHMJO().SetFloat("BadgeText", Distortion);
			MPENCEIGLEH().SetFloat("CameraFilterPack_Atmosphere_Rain_FX", Size);
			JDMJJGEHMJO().SetVector("The given 2D texture ", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OLHDPICFBOF());
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
			KBOPGONOCNP().SetFloat("player.egglipszerotwo", HBJJOCHGOPH);
			OIIDAKBILMI().SetFloat("_Value13", CenterX);
			OIIDAKBILMI().SetFloat("[", CenterY);
			MPENCEIGLEH().SetFloat(".", Distortion);
			NBPKMLMCHFN.SetFloat("#status", Size);
			FAIFBBGFAIB().SetVector("Joystick", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HAIAHJPCPAG()
	{
		SCShader = Shader.Find("_EmissionColor");
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
