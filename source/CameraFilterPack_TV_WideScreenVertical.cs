// CameraFilterPack_TV_WideScreenVertical
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/TV/WideScreenVertical")]
[ExecuteInEditMode]
public class CameraFilterPack_TV_WideScreenVertical : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 0.8f)]
	public float Size = 0.55f;

	[Range(0.001f, 0.4f)]
	public float Smooth = 0.01f;

	[Range(0f, 10f)]
	private float ICABEDDNGIH = 1f;

	[Range(0f, 10f)]
	private float LHOMPJOPKHE = 1f;

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

	private void HMNLHMLILKD()
	{
	}

	private void NKLIHNJCHOG()
	{
	}

	private void LMADKINICIN()
	{
	}

	private void FBMDHDBELEK()
	{
	}

	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 536f)
			{
				HBJJOCHGOPH = 492f;
			}
			LPDOGGFOBDH().SetFloat("Image effects aren't supported on this device ({0})", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("_Value3", Size);
			LPDOGGFOBDH().SetFloat("Prints list of commands", Smooth);
			LONNIJMNKFB().SetFloat("_MainTex2", ICABEDDNGIH);
			NLFJGMBCICG().SetFloat("Show Title", LHOMPJOPKHE);
			NLFJGMBCICG().SetVector("#", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1245f, 629f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NCNPAKFAFOE()
	{
		SCShader = Shader.Find("AddEnvironmentObject");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1526f)
			{
				HBJJOCHGOPH = 208f;
			}
			KBOPGONOCNP().SetFloat("Tab2Content", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("CameraFilterPack/FX_DigitalMatrix", Size);
			MICHFGAOPKM().SetFloat("_ProjInfo", Smooth);
			NBPKMLMCHFN.SetFloat(" ", ICABEDDNGIH);
			PDEAHJPOMEF().SetFloat("_TimeX", LHOMPJOPKHE);
			PDEAHJPOMEF().SetVector("Can't set visible when not in that room.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 673f, 279f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
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

	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1003f)
			{
				HBJJOCHGOPH = 1011f;
			}
			MFHPKGICPIO().SetFloat("offsets", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("ResourceIDInputField", Size);
			KBOPGONOCNP().SetFloat("Offline", Smooth);
			IGKFMCPDNOI().SetFloat("_Value1", ICABEDDNGIH);
			NFKFAAHHLLM().SetFloat("https://bugs.khb-soft.ru/set_project.php?project_id=1", LHOMPJOPKHE);
			IGKFMCPDNOI().SetVector("AllocateViewID() failed. Room (user {0}) is out of 'scene' viewIDs. It seems all available are in use.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 711f, 1270f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IFJDKDFLGBG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CGBHOELMAOC()
	{
	}

	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1989f)
			{
				HBJJOCHGOPH = 1738f;
			}
			HCGJCMDJPGD().SetFloat("\n\n• ", HBJJOCHGOPH);
			NFKFAAHHLLM().SetFloat("player.redabstract", Size);
			NBPKMLMCHFN.SetFloat("ConfigVersionSlider", Smooth);
			LONNIJMNKFB().SetFloat(" GO:", ICABEDDNGIH);
			NLFJGMBCICG().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", LHOMPJOPKHE);
			NDMPCDHADMJ().SetVector("init", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1588f, 1986f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HLLHJIDOOGA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OBAEDJJDCPN()
	{
	}

	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 74f)
			{
				HBJJOCHGOPH = 1144f;
			}
			IGKFMCPDNOI().SetFloat("workshop.", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("_Value", Size);
			HHIFMIPPMPF().SetFloat("BitsData", Smooth);
			LONNIJMNKFB().SetFloat("</color>", ICABEDDNGIH);
			NBPKMLMCHFN.SetFloat("maps.", LHOMPJOPKHE);
			NDMPCDHADMJ().SetVector("UI Extensions/UI Image Crop", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1615f, 1774f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material MICHFGAOPKM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-97);
		}
		return BJFKDHHMLJH;
	}

	private void PLIKADJCEPO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BOLBPPHJBMI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-92);
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

	[SpecialName]
	private Material NFKFAAHHLLM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)101;
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

	private void DIPDEHOOBPG()
	{
		SCShader = Shader.Find("_Saturation");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KMKLDAJLCNM()
	{
	}

	private void CBIBDOIBJAI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CNDACAHCCOI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CCPEDDLAMIB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Update()
	{
	}

	private void GCHBGCGBMCK()
	{
	}

	private void KKEOHFGKCIK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material LPDOGGFOBDH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1353f)
			{
				HBJJOCHGOPH = 1355f;
			}
			NFKFAAHHLLM().SetFloat("_DiffuseColor", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("Set satellite color", Size);
			MICHFGAOPKM().SetFloat("_Value", Smooth);
			LONNIJMNKFB().SetFloat("Submit", ICABEDDNGIH);
			KBOPGONOCNP().SetFloat("_", LHOMPJOPKHE);
			HHIFMIPPMPF().SetVector("Submition failed", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 707f, 158f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JAAJECBCCFM()
	{
	}

	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1248f)
			{
				HBJJOCHGOPH = 1544f;
			}
			LPDOGGFOBDH().SetFloat("player.licenceaccepted", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat(",", Size);
			NBPKMLMCHFN.SetFloat("No info", Smooth);
			LPDOGGFOBDH().SetFloat("seconds", ICABEDDNGIH);
			NLFJGMBCICG().SetFloat("_Value3", LHOMPJOPKHE);
			NLFJGMBCICG().SetVector("menu.playedpage", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 56f, 1076f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FOMNCPKKCFN()
	{
	}

	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1661f)
			{
				HBJJOCHGOPH = 1783f;
			}
			LPDOGGFOBDH().SetFloat("#91CCFF", HBJJOCHGOPH);
			LPDOGGFOBDH().SetFloat("http://steamcommunity.com/sharedfiles/filedetails/?id=", Size);
			LONNIJMNKFB().SetFloat("Joined room ", Smooth);
			MFHPKGICPIO().SetFloat("_TimeX", ICABEDDNGIH);
			LONNIJMNKFB().SetFloat("z", LHOMPJOPKHE);
			PDEAHJPOMEF().SetVector("\\\"", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1133f, 1494f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LONNIJMNKFB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-100);
		}
		return BJFKDHHMLJH;
	}

	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1452f)
			{
				HBJJOCHGOPH = 995f;
			}
			NBPKMLMCHFN.SetFloat("CameraFilterPack/TV_Videoflip", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("_Value2", Size);
			IGKFMCPDNOI().SetFloat("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.", Smooth);
			MFHPKGICPIO().SetFloat("A", ICABEDDNGIH);
			NBPKMLMCHFN.SetFloat("[LobbyPlayerElement] On ready click", LHOMPJOPKHE);
			HCGJCMDJPGD().SetVector(" or player:", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 458f, 1097f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GJLKJAOBPJD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1014f)
			{
				HBJJOCHGOPH = 664f;
			}
			PDEAHJPOMEF().SetFloat("LevelURLInputField", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("/theme", Size);
			KBOPGONOCNP().SetFloat("0", Smooth);
			NBPKMLMCHFN.SetFloat("id", ICABEDDNGIH);
			HHIFMIPPMPF().SetFloat("Default color's lerp speed of color changing. Greater values means faster changing. 0 - intant change.", LHOMPJOPKHE);
			MICHFGAOPKM().SetVector("EnableRankingToggle", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1657f, 1375f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1905f)
			{
				HBJJOCHGOPH = 1605f;
			}
			PDEAHJPOMEF().SetFloat("\\[ *im.*\\](\\n\\n\\n|\\n\\n|\\n|)", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_FullResolutionFiltering", Size);
			PDEAHJPOMEF().SetFloat("Right Stick Click", Smooth);
			IGKFMCPDNOI().SetFloat("error", ICABEDDNGIH);
			LONNIJMNKFB().SetFloat("Result for ", LHOMPJOPKHE);
			LONNIJMNKFB().SetVector("[LevelEditorScene] Print Audio Wave: Start", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 165f, 1409f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NPLCENPNJBM()
	{
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1228f)
			{
				HBJJOCHGOPH = 117f;
			}
			PDEAHJPOMEF().SetFloat("type", HBJJOCHGOPH);
			LPDOGGFOBDH().SetFloat("value", Size);
			HCGJCMDJPGD().SetFloat("_Distance", Smooth);
			KBOPGONOCNP().SetFloat("hand", ICABEDDNGIH);
			HCGJCMDJPGD().SetFloat("DPADVER", LHOMPJOPKHE);
			LONNIJMNKFB().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 54f, 1644f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NNFMIAFHMJM()
	{
		SCShader = Shader.Find("_MaxRadiusOrKInPaper");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BKGJOECFMID()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 990f)
			{
				HBJJOCHGOPH = 1702f;
			}
			HHIFMIPPMPF().SetFloat("_MainTex", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("GlassColor", Size);
			KBOPGONOCNP().SetFloat("settings.fps", Smooth);
			MICHFGAOPKM().SetFloat(".highscore", ICABEDDNGIH);
			IGKFMCPDNOI().SetFloat("DPADHOR", LHOMPJOPKHE);
			LPDOGGFOBDH().SetVector("}", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 657f, 955f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OCMKCBBCEFG()
	{
	}

	private void JKBMKPDGCHG()
	{
		SCShader = Shader.Find("Emergency Help:");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MMBPLGGLPDB()
	{
	}

	private void GKNKIIEALCH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PAEGLMEOKHP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HCGJCMDJPGD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)122;
		}
		return BJFKDHHMLJH;
	}

	private void JOJFHFHOCHO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CFFCLAHMBAA()
	{
		SCShader = Shader.Find("#getrewardfailed: ");
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

	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1570f)
			{
				HBJJOCHGOPH = 620f;
			}
			IGKFMCPDNOI().SetFloat("w", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("SpectateButton", Size);
			MICHFGAOPKM().SetFloat("<size=24>", Smooth);
			KBOPGONOCNP().SetFloat("Right Stick Click", ICABEDDNGIH);
			NBPKMLMCHFN.SetFloat("inventory.selected.", LHOMPJOPKHE);
			MICHFGAOPKM().SetVector("_LightIntensity", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 67f, 1674f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HHIFMIPPMPF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)91;
		}
		return BJFKDHHMLJH;
	}

	private void EJFJENFKLND()
	{
	}

	private void PKLOBJHKFEO()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material NLFJGMBCICG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-92);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy;
		}
		return BJFKDHHMLJH;
	}

	private void LCHBFNIPBHB()
	{
	}

	private void DGCGGKMNPLD()
	{
	}

	[SpecialName]
	private Material IGKFMCPDNOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-126);
		}
		return BJFKDHHMLJH;
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
			NBPKMLMCHFN.SetFloat("_Value", Size);
			NBPKMLMCHFN.SetFloat("_Value2", Smooth);
			NBPKMLMCHFN.SetFloat("_Value3", ICABEDDNGIH);
			NBPKMLMCHFN.SetFloat("_Value4", LHOMPJOPKHE);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EPEGAEGDJAM()
	{
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EDBEHEKMGFH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/TV_WideScreenVertical");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DNNFHBOOPIN()
	{
		SCShader = Shader.Find("_Value7");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material NDMPCDHADMJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1895f)
			{
				HBJJOCHGOPH = 17f;
			}
			NBPKMLMCHFN.SetFloat("Editor/", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("DPADHOR", Size);
			NDMPCDHADMJ().SetFloat("ItemNameText", Smooth);
			MFHPKGICPIO().SetFloat(".a", ICABEDDNGIH);
			MICHFGAOPKM().SetFloat("BitsData", LHOMPJOPKHE);
			NFKFAAHHLLM().SetVector("value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 956f, 369f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DKGBFNCOAEO()
	{
		SCShader = Shader.Find("elapsed: {0:0.000}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IKIDIJLIGOH()
	{
	}

	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 256f)
			{
				HBJJOCHGOPH = 875f;
			}
			HHIFMIPPMPF().SetFloat("_TimeX", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("Editor/", Size);
			KBOPGONOCNP().SetFloat("UseScanLine", Smooth);
			LONNIJMNKFB().SetFloat("Offline", ICABEDDNGIH);
			NLFJGMBCICG().SetFloat("SaveButton", LHOMPJOPKHE);
			NFKFAAHHLLM().SetVector("SetSatelliteRotationSpeed", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 824f, 417f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1163f)
			{
				HBJJOCHGOPH = 757f;
			}
			HCGJCMDJPGD().SetFloat("_Parameter", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("note.1", Size);
			HHIFMIPPMPF().SetFloat("MenuScene", Smooth);
			PDEAHJPOMEF().SetFloat("_ToneCurve", ICABEDDNGIH);
			NDMPCDHADMJ().SetFloat("_Value", LHOMPJOPKHE);
			MICHFGAOPKM().SetVector("menutheme.fragout", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 196f, 1363f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MJEFMIPLFAB()
	{
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BMOFEBKGLFI()
	{
		SCShader = Shader.Find("SetParticlesColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LDDKCCMHMIC()
	{
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1857f)
			{
				HBJJOCHGOPH = 712f;
			}
			LPDOGGFOBDH().SetFloat(" argument(s): ", HBJJOCHGOPH);
			LPDOGGFOBDH().SetFloat("mapselector.filter.rateduponly", Size);
			KBOPGONOCNP().SetFloat("_TimeX", Smooth);
			IGKFMCPDNOI().SetFloat("OnJoinedRoom() called by PUN. Now this client is in a room. From here on, your game would be running. For reference, all callbacks are listed in enum: PhotonNetworkingMessage", ICABEDDNGIH);
			LPDOGGFOBDH().SetFloat("ItemNameText", LHOMPJOPKHE);
			IGKFMCPDNOI().SetVector("_Amount", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1157f, 1747f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
