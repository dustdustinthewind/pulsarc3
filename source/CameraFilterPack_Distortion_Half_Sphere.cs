// CameraFilterPack_Distortion_Half_Sphere
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Distortion/Half_Sphere")]
[ExecuteInEditMode]
public class CameraFilterPack_Distortion_Half_Sphere : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	[Range(1f, 6f)]
	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	public float SphereSize = 2.5f;

	[Range(-1f, 1f)]
	public float SpherePositionX;

	[Range(-1f, 1f)]
	public float SpherePositionY;

	[Range(1f, 10f)]
	public float Strength = 5f;

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
	private Material CEKJODEAMGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)66;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NFMGLIKNOOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)81;
		}
		return BJFKDHHMLJH;
	}

	private void DBLILJGKGHJ()
	{
		SCShader = Shader.Find("PLEASE WAIT");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material GKILCDHJFEG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 827f)
			{
				HBJJOCHGOPH = 800f;
			}
			NBPKMLMCHFN.SetFloat("_BlurRadius4", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("skin.", SphereSize);
			EFMCNLELMDO().SetFloat("_DotSize", SpherePositionX);
			MCDGIILBNIF().SetFloat("Working.\nPlease wait..", SpherePositionY);
			LPMLLJKMAMP().SetFloat("CameraFilterPack/Blur_Bloom", Strength);
			KAFBNOBOIAJ().SetVector("ResetButton", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PHGCJOPFDOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DFENCIHAADO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 527f)
			{
				HBJJOCHGOPH = 1953f;
			}
			GCDFNHMJMIP().SetFloat("_ChromaticAberration", HBJJOCHGOPH);
			LPMLLJKMAMP().SetFloat("score", SphereSize);
			PHGCJOPFDOG().SetFloat("ticket.ticket1", SpherePositionX);
			GJHPODJOBHL().SetFloat("_Bloom4", SpherePositionY);
			JLHLHKPHDFO().SetFloat("settings.arcsnohitsoundtimedelay", Strength);
			HEHKGPKLAKK().SetVector("_Far", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JKBMKPDGCHG()
	{
		SCShader = Shader.Find("_Speed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FOLDLDLFFLM()
	{
	}

	[SpecialName]
	private Material GJHPODJOBHL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void JOACBIEHHCE()
	{
	}

	private void FDMAEPOHDMK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HLIAEEMGBHN()
	{
		SCShader = Shader.Find("green");
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
			if (HBJJOCHGOPH > 1629f)
			{
				HBJJOCHGOPH = 975f;
			}
			PDEAHJPOMEF().SetFloat("_Value4", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("_ScreenResolution", SphereSize);
			AELJLBOJAIL().SetFloat("_Value5", SpherePositionX);
			MCDGIILBNIF().SetFloat("UnityEngine.MonoBehaviour", SpherePositionY);
			EFMCNLELMDO().SetFloat("_TimeX", Strength);
			IONHGBPGCHK().SetVector("mapselector.orderby", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LPMLLJKMAMP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-125);
		}
		return BJFKDHHMLJH;
	}

	private void FEHCNJLLJMP()
	{
		SCShader = Shader.Find("_Angle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HDDECCMEJKA()
	{
	}

	private void Update()
	{
	}

	private void MMBPLGGLPDB()
	{
	}

	private void AGMJDGHLBMN()
	{
	}

	private void IEMEHGCFAPD()
	{
	}

	private void NNFMIAFHMJM()
	{
		SCShader = Shader.Find("_Visualize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OIBMHPIFAKK()
	{
	}

	private void KMKLDAJLCNM()
	{
	}

	[SpecialName]
	private Material EOCCJGIGEGJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void BEBNOKFLJPH()
	{
		SCShader = Shader.Find("value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material FGENHBKMPDA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-92);
		}
		return BJFKDHHMLJH;
	}

	private void PKBENONAOOL()
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

	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 652f)
			{
				HBJJOCHGOPH = 1127f;
			}
			NBPKMLMCHFN.SetFloat("ControllerRightY", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("LevelConfigButton", SphereSize);
			CEKJODEAMGB().SetFloat("_TimeX", SpherePositionX);
			NBPKMLMCHFN.SetFloat(",", SpherePositionY);
			MFHPKGICPIO().SetFloat(" not exist", Strength);
			AELJLBOJAIL().SetVector("#no", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFMCNLELMDO());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-99);
		}
		return BJFKDHHMLJH;
	}

	private void FJNCHGLIEMA()
	{
		SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AEIJFLJEABG()
	{
	}

	[SpecialName]
	private Material KAFBNOBOIAJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-103);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material PHGCJOPFDOG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)111;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material JLHLHKPHDFO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)91;
		}
		return BJFKDHHMLJH;
	}

	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 297f)
			{
				HBJJOCHGOPH = 1333f;
			}
			PHGCJOPFDOG().SetFloat("No", HBJJOCHGOPH);
			PHGCJOPFDOG().SetFloat("_Bullet_11", SphereSize);
			EOCCJGIGEGJ().SetFloat("[EditorEvent] Exception: ", SpherePositionX);
			NLFJGMBCICG().SetFloat("_History4ChromaTex", SpherePositionY);
			LPMLLJKMAMP().SetFloat("help", Strength);
			PHGCJOPFDOG().SetVector("\r", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
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

	private void CGDMLHLJIDK()
	{
		SCShader = Shader.Find("UsernameText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JNGMIAFLBDL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EKCDEFDELMP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void COOHIILCOCO()
	{
		SCShader = Shader.Find("menu.copyright");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GJLKJAOBPJD()
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

	[SpecialName]
	private Material GCDFNHMJMIP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)104;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NLFJGMBCICG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void JECMJNFGBGC()
	{
		SCShader = Shader.Find("Set Satellite Trail Width");
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

	private void HAIAHJPCPAG()
	{
		SCShader = Shader.Find("LoadMapCanvas");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ABEIEGDHBNO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material MCDGIILBNIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-117);
		}
		return BJFKDHHMLJH;
	}

	private void JMEOGJHCONJ()
	{
		SCShader = Shader.Find("_ColorBuffer");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OEENOOGEEHD()
	{
	}

	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 994f)
			{
				HBJJOCHGOPH = 1613f;
			}
			LPMLLJKMAMP().SetFloat("Set satellite trail length in seconds", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("_TimeX", SphereSize);
			PHGCJOPFDOG().SetFloat("st", SpherePositionX);
			IONHGBPGCHK().SetFloat("maps.", SpherePositionY);
			JLHLHKPHDFO().SetFloat("UI Extensions/UIAdditive", Strength);
			NFMGLIKNOOC().SetVector("note.0", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FJIKDJAMOHA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GBGAMCPNBCC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HMPGIFBJFIK()
	{
		SCShader = Shader.Find(" b.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DKGBFNCOAEO()
	{
		SCShader = Shader.Find("Did not read byte array properly");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 780f)
			{
				HBJJOCHGOPH = 1585f;
			}
			KAFBNOBOIAJ().SetFloat("#no", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("player.licenceaccepted", SphereSize);
			PHGCJOPFDOG().SetFloat("StartCanvas", SpherePositionX);
			NLFJGMBCICG().SetFloat("points:", SpherePositionY);
			NBPKMLMCHFN.SetFloat("_Value4", Strength);
			NFMGLIKNOOC().SetVector("[PlayerController] ", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)123;
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

	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 127f)
			{
				HBJJOCHGOPH = 501f;
			}
			NFMGLIKNOOC().SetFloat(" cannot be used as a 3D LUT.", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception", SphereSize);
			HEHKGPKLAKK().SetFloat("SupportLogger OnJoinedLobby(", SpherePositionX);
			PHGCJOPFDOG().SetFloat("\n", SpherePositionY);
			NLFJGMBCICG().SetFloat("_BlurRadius4", Strength);
			NBPKMLMCHFN.SetVector("settings.cameramovements", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CEKJODEAMGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HJPCJGOEKMF()
	{
		SCShader = Shader.Find("Tab2Content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 931f)
			{
				HBJJOCHGOPH = 477f;
			}
			NFMGLIKNOOC().SetFloat("Solo", HBJJOCHGOPH);
			JLHLHKPHDFO().SetFloat("ItemNameBGImage", SphereSize);
			LPMLLJKMAMP().SetFloat(".lastCheckpoint.time", SpherePositionX);
			NFMGLIKNOOC().SetFloat("_LutTex", SpherePositionY);
			FGENHBKMPDA().SetFloat("sounds/hit_wrong", Strength);
			MCDGIILBNIF().SetVector("_FarCamera", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material MFHPKGICPIO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return BJFKDHHMLJH;
	}

	private void BMIOFJFMCBG()
	{
		SCShader = Shader.Find("LoadMapCanvas");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LCDJFJIBADI()
	{
	}

	private void EPJJDKJEDMM()
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
			NBPKMLMCHFN.SetFloat("_SphereSize", SphereSize);
			NBPKMLMCHFN.SetFloat("_SpherePositionX", SpherePositionX);
			NBPKMLMCHFN.SetFloat("_SpherePositionY", SpherePositionY);
			NBPKMLMCHFN.SetFloat("_Strength", Strength);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ODGMCJILIHF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OPCLBGHAPMG()
	{
	}

	private void FBPHNEJBDJN()
	{
		SCShader = Shader.Find("_FadeDistance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KCDOMIJBFLL()
	{
	}

	private void IDJKNBDKHBD()
	{
		SCShader = Shader.Find(" - ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BMODOIJGIOO()
	{
	}

	private void ODBNMPGBCGO()
	{
		SCShader = Shader.Find("ChallengesButton");
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-88);
		}
		return BJFKDHHMLJH;
	}

	private void JDGFCEPDKAJ()
	{
	}

	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1969f)
			{
				HBJJOCHGOPH = 1698f;
			}
			AELJLBOJAIL().SetFloat("inventory.selected.", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("CompletedLevel", SphereSize);
			AELJLBOJAIL().SetFloat("PointerEnter ", SpherePositionX);
			GJHPODJOBHL().SetFloat("_Value3", SpherePositionY);
			MFHPKGICPIO().SetFloat("_TileMaxLoop", Strength);
			GCDFNHMJMIP().SetVector("_Blue_B", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BGDONBMDPGM()
	{
	}

	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 579f)
			{
				HBJJOCHGOPH = 1377f;
			}
			LPMLLJKMAMP().SetFloat("_AccumulationTex", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("menutheme.27thfloor", SphereSize);
			GCDFNHMJMIP().SetFloat("CheckResources () for ", SpherePositionX);
			MFHPKGICPIO().SetFloat("_ScreenResolution", SpherePositionY);
			JLHLHKPHDFO().SetFloat("_Extra2", Strength);
			FGENHBKMPDA().SetVector("Editor", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LGHCJCFHEMF()
	{
		SCShader = Shader.Find("{0}\t is: {1}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PAKPHKPDKGE()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KLILJHJNICK()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 588f)
			{
				HBJJOCHGOPH = 1288f;
			}
			PHGCJOPFDOG().SetFloat("CheckpointsScoreText", HBJJOCHGOPH);
			JLHLHKPHDFO().SetFloat("Created by ", SphereSize);
			JLHLHKPHDFO().SetFloat("player.egglipszerotwo", SpherePositionX);
			JLHLHKPHDFO().SetFloat("CheckpointsScoreText", SpherePositionY);
			CEKJODEAMGB().SetFloat("Joystick1Button0", Strength);
			GJHPODJOBHL().SetVector(".highscore", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FGOPJMGNHGO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PKHPNHBEKHA()
	{
	}

	[SpecialName]
	private Material HEHKGPKLAKK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void DOEPOGLEGLE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ANCKKLFPGDI()
	{
		SCShader = Shader.Find("[GameEvent] Exeption:");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JDKHBGDEONK()
	{
		SCShader = Shader.Find("System.Boolean");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ICILLMAKLMI()
	{
		SCShader = Shader.Find("<color=white>PhotonView Group: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 714f)
			{
				HBJJOCHGOPH = 1250f;
			}
			GKILCDHJFEG().SetFloat("_Fade", HBJJOCHGOPH);
			GJHPODJOBHL().SetFloat("GraphicsQualitySlider", SphereSize);
			MFHPKGICPIO().SetFloat("_TimeX", SpherePositionX);
			FGENHBKMPDA().SetFloat("Vertical", SpherePositionY);
			NFMGLIKNOOC().SetFloat("_LowRez", Strength);
			NFMGLIKNOOC().SetVector("_Value3", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 917f)
			{
				HBJJOCHGOPH = 709f;
			}
			KAFBNOBOIAJ().SetFloat("Joystick1Button12", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("ItemTemplate", SphereSize);
			NFMGLIKNOOC().SetFloat("Stream did not contain properly formatted byte array", SpherePositionX);
			NLFJGMBCICG().SetFloat("CameraFilterPack/Atmosphere_Fog", SpherePositionY);
			HEHKGPKLAKK().SetFloat("/icon", Strength);
			GKILCDHJFEG().SetVector("Left Stick Click", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1910f)
			{
				HBJJOCHGOPH = 1710f;
			}
			MFHPKGICPIO().SetFloat("_FixDistance", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("_Value", SphereSize);
			CEKJODEAMGB().SetFloat("PointerEnter ", SpherePositionX);
			PHGCJOPFDOG().SetFloat("_Value", SpherePositionY);
			NLFJGMBCICG().SetFloat("CameraFilterPack/3D_Matrix", Strength);
			EFMCNLELMDO().SetVector("_Distortion", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ONMGIPAILOH()
	{
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Distortion_Half_Sphere");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DKPBBJINKMG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NKLIHNJCHOG()
	{
	}

	[SpecialName]
	private Material EFMCNLELMDO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-119);
		}
		return BJFKDHHMLJH;
	}

	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 923f)
			{
				HBJJOCHGOPH = 1625f;
			}
			CEKJODEAMGB().SetFloat("cancel", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("_Value2", SphereSize);
			HEHKGPKLAKK().SetFloat("_RgbTex", SpherePositionX);
			AELJLBOJAIL().SetFloat("player.gamecompleted", SpherePositionY);
			GKILCDHJFEG().SetFloat("_TimeX", Strength);
			PDEAHJPOMEF().SetVector("_TimeX", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHPODJOBHL());
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
			if (HBJJOCHGOPH > 59f)
			{
				HBJJOCHGOPH = 1575f;
			}
			GKILCDHJFEG().SetFloat("Preparing content", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("/../", SphereSize);
			FGENHBKMPDA().SetFloat(".lastCheckpoint.powerupsScore", SpherePositionX);
			MFHPKGICPIO().SetFloat("#activechallenges", SpherePositionY);
			AELJLBOJAIL().SetFloat("_DiffuseColor", Strength);
			IONHGBPGCHK().SetVector("back", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CEKJODEAMGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HMNLHMLILKD()
	{
	}
}
