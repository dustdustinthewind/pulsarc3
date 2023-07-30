// CameraFilterPack_Blur_Steam
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Blur/Steam")]
public class CameraFilterPack_Blur_Steam : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 1f)]
	public float Radius = 0.1f;

	[Range(0f, 1f)]
	public float Quality = 0.75f;

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

	private void BLKGOMCPEKI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1652f)
			{
				HBJJOCHGOPH = 770f;
			}
			JIBOKBCPDLC().SetFloat("SetSunInput", HBJJOCHGOPH);
			FOOCJIDNGBB().SetFloat("roomDescription", Radius);
			BBIMPFGLDCP().SetFloat("#8E8E8EFF", Quality);
			OCHJIMJNEMO().SetVector("http", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material JFDGLLEOPGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material OCHJIMJNEMO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	private void PKGJJFIFLII()
	{
	}

	[SpecialName]
	private Material LEHDPILKKND()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)66;
		}
		return BJFKDHHMLJH;
	}

	private void FOMNCPKKCFN()
	{
	}

	private void MODENHKMKOC()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JHJFBCFBKLD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1481f)
			{
				HBJJOCHGOPH = 1692f;
			}
			BBIMPFGLDCP().SetFloat("color", HBJJOCHGOPH);
			LPMLLJKMAMP().SetFloat("_Value1", Radius);
			NBPKMLMCHFN.SetFloat("_UserLutTex", Quality);
			CECICEGFHKL().SetVector("_AdaptParams", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FOOCJIDNGBB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GGPDKCHEBAG()
	{
	}

	private void KMKLDAJLCNM()
	{
	}

	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 960f)
			{
				HBJJOCHGOPH = 1557f;
			}
			NMDBCDFPGOK().SetFloat("BitsData", HBJJOCHGOPH);
			LPMLLJKMAMP().SetFloat("_ScreenResolution", Radius);
			KHCLIAMBBNC().SetFloat("CameraFilterPack/Blur_Blurry", Quality);
			GKILCDHJFEG().SetVector("CameraFilterPack_3D_Myst1", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADAFMBOGPLN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HHKBBEFJEBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 7f)
			{
				HBJJOCHGOPH = 1009f;
			}
			BBIMPFGLDCP().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			BAGICADFBAB().SetFloat("IconImage", Radius);
			LPMLLJKMAMP().SetFloat("_Red_G", Quality);
			NBPKMLMCHFN.SetVector("JoinRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DIPDEHOOBPG()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NPBDIMJDMGA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1573f)
			{
				HBJJOCHGOPH = 160f;
			}
			JIBOKBCPDLC().SetFloat("_MainTex2", HBJJOCHGOPH);
			KHCLIAMBBNC().SetFloat("EditMenu", Radius);
			HILDKDFEBPF().SetFloat("/", Quality);
			FOOCJIDNGBB().SetVector("_FixDistance", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKHBBBFLGJH());
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
			if (HBJJOCHGOPH > 891f)
			{
				HBJJOCHGOPH = 1514f;
			}
			BAGICADFBAB().SetFloat("_TimeX", HBJJOCHGOPH);
			LPMLLJKMAMP().SetFloat("_TimeX", Radius);
			BBIMPFGLDCP().SetFloat("attempted to spawn go (", Quality);
			CECICEGFHKL().SetVector("CameraFilterPack_Glasses_On4", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PDHKMDBNGGN()
	{
		SCShader = Shader.Find("<color=#");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LOMDIOLNFHI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KCNIHHNMFFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1593f)
			{
				HBJJOCHGOPH = 1192f;
			}
			BBIMPFGLDCP().SetFloat("#random #epic #item", HBJJOCHGOPH);
			HILDKDFEBPF().SetFloat("_ScreenResolution", Radius);
			HKHBBBFLGJH().SetFloat("0.00", Quality);
			BBIMPFGLDCP().SetVector("CameraFilterPack/Blend2Camera_Lighten", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ENKPNJMPDEB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KFEKCJDEECK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MNBPNHNAEBK()
	{
		SCShader = Shader.Find("CameraFilterPack/Blend2Camera_VividLight");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material HKHBBBFLGJH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-102);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NMDBCDFPGOK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-73);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material BBIMPFGLDCP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)104;
		}
		return BJFKDHHMLJH;
	}

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1614f)
			{
				HBJJOCHGOPH = 1792f;
			}
			MJJIEHANFJA().SetFloat("shader.frost", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat(".", Radius);
			ENKPNJMPDEB().SetFloat("_ScreenResolution", Quality);
			LEHDPILKKND().SetVector("_ScreenResolution", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BBIMPFGLDCP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	private void OFIMMFHFHDD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PCHCFIOHIKK()
	{
		SCShader = Shader.Find(") then the masterserver requests a disconnect!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PLBOFEPBPKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FKEJGBFDCAH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LAMEHAHJKMI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PBEPCAPAKLG()
	{
	}

	[SpecialName]
	private Material GCDFNHMJMIP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1613f)
			{
				HBJJOCHGOPH = 1399f;
			}
			PEIMCBBHLBJ().SetFloat("TotalHitsScoreText", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Left", Radius);
			FOOCJIDNGBB().SetFloat("VIGNETTE_FILMIC", Quality);
			GCDFNHMJMIP().SetVector("[PlayerController] ", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CECICEGFHKL());
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
			if (HBJJOCHGOPH > 1750f)
			{
				HBJJOCHGOPH = 1572f;
			}
			LPCHMEKDCHI().SetFloat("Bad SegmentType passed in to CreateLineCap. Must be SegmentType.Start or SegmentType.End", HBJJOCHGOPH);
			JIBOKBCPDLC().SetFloat("Jun", Radius);
			JFDGLLEOPGB().SetFloat("_Amount", Quality);
			NMDBCDFPGOK().SetVector("#outdatedmap! Challenges will not work!", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NJHJHBOJKIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HMPGIFBJFIK()
	{
		SCShader = Shader.Find("_Value5");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 186f)
			{
				HBJJOCHGOPH = 849f;
			}
			NMDBCDFPGOK().SetFloat("Gameplay/LobbyPlayerIconElement", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("/", Radius);
			FOOCJIDNGBB().SetFloat("MapConfig", Quality);
			MJJIEHANFJA().SetVector("_TimeX", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 626f)
			{
				HBJJOCHGOPH = 45f;
			}
			GCDFNHMJMIP().SetFloat(".jpg", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value", Radius);
			MJJIEHANFJA().SetFloat("player.licenceaccepted", Quality);
			JIBOKBCPDLC().SetVector("_Value2", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MPJCMKFFKHH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1693f)
			{
				HBJJOCHGOPH = 466f;
			}
			CECICEGFHKL().SetFloat("Remove Environment Object", HBJJOCHGOPH);
			ADAFMBOGPLN().SetFloat("_Intensity", Radius);
			BBIMPFGLDCP().SetFloat("maps.", Quality);
			OCHJIMJNEMO().SetVector("Case-Sensitive", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HONBLGFDMLL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BJOHDLNDFAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JONGNKNLLND()
	{
		SCShader = Shader.Find("MapEnd");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AOLABBMIEIM()
	{
	}

	private void EKCKJLFFAID()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material LELKBCALFCF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-87);
		}
		return BJFKDHHMLJH;
	}

	private void BFEILOMHNPC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DDFCIOMKEEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 838f)
			{
				HBJJOCHGOPH = 1075f;
			}
			NBPKMLMCHFN.SetFloat("_Intensity", HBJJOCHGOPH);
			OCHJIMJNEMO().SetFloat("_Value", Radius);
			JIBOKBCPDLC().SetFloat("No Dispatcher exists in the scene. Actions will not be invoked!", Quality);
			MJJIEHANFJA().SetVector("SpawnObj", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LEHDPILKKND());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NNBCLMJGFEN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GAOOPEEBGJA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ELKELFCGMPE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LIEGJOHINGC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material FOOCJIDNGBB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-72);
		}
		return BJFKDHHMLJH;
	}

	private void NFEDLAOPHML()
	{
	}

	private void JIAAFKOPEKO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 527f)
			{
				HBJJOCHGOPH = 899f;
			}
			BBIMPFGLDCP().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			HILDKDFEBPF().SetFloat(":", Radius);
			GCDFNHMJMIP().SetFloat("CameraFilterPack/Blend2Camera_BlueScreen", Quality);
			BBIMPFGLDCP().SetVector("_RgbTex", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material ENKPNJMPDEB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)91;
		}
		return BJFKDHHMLJH;
	}

	private void JBCNIPJDPJB()
	{
	}

	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1522f)
			{
				HBJJOCHGOPH = 873f;
			}
			CECICEGFHKL().SetFloat("SetSatelliteRotationSpeed", HBJJOCHGOPH);
			LPCHMEKDCHI().SetFloat("maps.", Radius);
			NMDBCDFPGOK().SetFloat("master", Quality);
			NBPKMLMCHFN.SetVector("EnvironmentSlider", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CECICEGFHKL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MAOCOEGAFND()
	{
	}

	[SpecialName]
	private Material IKAEIOAHPKI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1894f)
			{
				HBJJOCHGOPH = 718f;
			}
			PEIMCBBHLBJ().SetFloat("Left Stick Click", HBJJOCHGOPH);
			LEHDPILKKND().SetFloat("_MainTex", Radius);
			OCHJIMJNEMO().SetFloat("CameraFilterPack/FX_Dot_Circle", Quality);
			BAGICADFBAB().SetVector(". Verify the Prefab is in a Resources folder (and not in a subfolder)", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HILDKDFEBPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NNPBKKBFDHH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material LPMLLJKMAMP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material ADAFMBOGPLN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-128);
		}
		return BJFKDHHMLJH;
	}

	private void ONMGIPAILOH()
	{
	}

	private void IKIDIJLIGOH()
	{
	}

	private void JNGMIAFLBDL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material GKILCDHJFEG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-113);
		}
		return BJFKDHHMLJH;
	}

	private void AKCADICOFDD()
	{
	}

	private void PKBENONAOOL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GLEJGFLCLPJ()
	{
		SCShader = Shader.Find("settings.volume.editor");
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
			if (HBJJOCHGOPH > 22f)
			{
				HBJJOCHGOPH = 298f;
			}
			MJJIEHANFJA().SetFloat("score", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("Joystick1Button10", Radius);
			LELKBCALFCF().SetFloat("Lightning", Quality);
			NMDBCDFPGOK().SetVector("UsernameText", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JECMJNFGBGC()
	{
		SCShader = Shader.Find("CameraFilterPack/Lut_PlayWith");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OFMNDBNFBDJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GJCOELHNLJE()
	{
	}

	private void OPHBLNNGFKG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 612f)
			{
				HBJJOCHGOPH = 1788f;
			}
			HILDKDFEBPF().SetFloat("skin.hit_wrong", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat("_BlurRadius4", Radius);
			IKAEIOAHPKI().SetFloat("Update() was called by Unity. Scene is loaded. Let's connect to the Photon Master Server. Calling: PhotonNetwork.ConnectUsingSettings();", Quality);
			ADAFMBOGPLN().SetVector(" left", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ENKPNJMPDEB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JMEOGJHCONJ()
	{
		SCShader = Shader.Find(".lastCheckpoint.playerdistance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material JIBOKBCPDLC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void EODOHEAKJFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ANKIJGCGCBF()
	{
	}

	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 204f)
			{
				HBJJOCHGOPH = 1226f;
			}
			JFDGLLEOPGB().SetFloat("CameraFilterPack/Blend2Camera_SplitScreen", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("Tab2Content", Radius);
			LEHDPILKKND().SetFloat("_Value1", Quality);
			LELKBCALFCF().SetVector("[Right-Down-Left]", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NMDBCDFPGOK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IAIGNDMHFFG()
	{
	}

	private void EPJJDKJEDMM()
	{
	}

	private void KKEOHFGKCIK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AGEJKLMJGDO()
	{
		SCShader = Shader.Find("offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HNDNDPECBPL()
	{
	}

	[SpecialName]
	private Material HILDKDFEBPF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void INLDEHPAMJC()
	{
	}

	[SpecialName]
	private Material PEIMCBBHLBJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void PODKOCOPGLC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1249f)
			{
				HBJJOCHGOPH = 437f;
			}
			GKILCDHJFEG().SetFloat("settings.showHP", HBJJOCHGOPH);
			JIBOKBCPDLC().SetFloat("_Offsets", Radius);
			LEHDPILKKND().SetFloat("mapselector.filter.rateduponly", Quality);
			NBPKMLMCHFN.SetVector("_Visualize", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BBIMPFGLDCP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KLILJHJNICK()
	{
		SCShader = Shader.Find("Warning: No Shape Curve set for CurveWaveform.cs on ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HDDECCMEJKA()
	{
	}

	[SpecialName]
	private Material MJJIEHANFJA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)99;
		}
		return BJFKDHHMLJH;
	}

	private void FGOPJMGNHGO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JCGMGLMADEN()
	{
	}

	private void JHJGJJKELJM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FDPOFMCFBMF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1809f)
			{
				HBJJOCHGOPH = 602f;
			}
			HILDKDFEBPF().SetFloat("challenges.", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("PhotonNetwork error: Could not Instantiate the prefab [", Radius);
			CECICEGFHKL().SetFloat("_Near", Quality);
			HKHBBBFLGJH().SetVector("CameraFilterPack/Pixel_Pixelisation", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BAGICADFBAB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material CECICEGFHKL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-116);
		}
		return BJFKDHHMLJH;
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Blur_Steam");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FJNJIHCLODK()
	{
	}

	[SpecialName]
	private Material LPCHMEKDCHI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-114);
		}
		return BJFKDHHMLJH;
	}

	private void GKNKIIEALCH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KIEJKBNBHMD()
	{
	}

	private void CPCDFMMLHLO()
	{
	}

	private void LMBDNPLDGIJ()
	{
	}

	private void NKLIHNJCHOG()
	{
	}

	private void FABKIGNFECE()
	{
	}

	private void FDNONDCGGCG()
	{
		SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KMOCDAOKGLI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ODCJJFBJJNF()
	{
	}

	private void KMEONPMCNJG()
	{
	}

	private void FHPFJBFCOOF()
	{
		SCShader = Shader.Find("visible");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NAOLAJPDGIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PNNPDMHLFHE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IFIHBNJKEKD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LGHCJCFHEMF()
	{
		SCShader = Shader.Find("Checkpoint");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IMCKJCHKMKB()
	{
		SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PAEGLMEOKHP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NNCCPEBIAKH()
	{
		SCShader = Shader.Find("_PColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OKLAJINHPAN()
	{
		SCShader = Shader.Find("CameraFilterPack/Colors_DarkColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ABHEJPAGNMO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material KHCLIAMBBNC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void GNCIOPKPLLA()
	{
	}

	private void DBLILJGKGHJ()
	{
		SCShader = Shader.Find("SetSunSensitivity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DOEPOGLEGLE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JOHOFNKJDEB()
	{
		SCShader = Shader.Find("Time Offset: {0}");
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

	private void DOFDGBGEDFI()
	{
		SCShader = Shader.Find("1234332714");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AEDDNDHCLNN()
	{
		SCShader = Shader.Find("LostLive");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BFGIMALGMAJ()
	{
	}

	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1963f)
			{
				HBJJOCHGOPH = 147f;
			}
			PEIMCBBHLBJ().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			FOOCJIDNGBB().SetFloat("_Blue_C", Radius);
			PEIMCBBHLBJ().SetFloat("_Value", Quality);
			NBPKMLMCHFN.SetVector("SetParticlesCountPerBeat", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FOOCJIDNGBB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KFMEAMBLODG()
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
			NBPKMLMCHFN.SetFloat("_Radius", Radius);
			NBPKMLMCHFN.SetFloat("_Quality", Quality);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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

	private void OHBNLJOPDDC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GOANCMNGDLE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1688f)
			{
				HBJJOCHGOPH = 372f;
			}
			HKHBBBFLGJH().SetFloat("_Screen", HBJJOCHGOPH);
			KHCLIAMBBNC().SetFloat("PickupItemInit", Radius);
			LPMLLJKMAMP().SetFloat("_TimeX", Quality);
			KHCLIAMBBNC().SetVector("inventory.selected.", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HPFOFGJPNCI()
	{
		SCShader = Shader.Find("CameraFilterPack/Blend2Camera_Multiply");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FJABOCDLCAI()
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

	private void MKKJICPMPHK()
	{
	}

	[SpecialName]
	private Material BAGICADFBAB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	private void DKPBBJINKMG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HEBOIFKBLGD()
	{
	}

	private void MFLBEJHMEMO()
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

	private void FEGJMDDIDIC()
	{
		SCShader = Shader.Find("UpdateNewsTileStart");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PFNFPINPCMH()
	{
	}

	private void CPAJLKHMOJB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}
}
