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
			NBPKMLMCHFN.SetFloat("_BaseTex", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("_Value3", Size);
			HCGJCMDJPGD().SetFloat(" ", Smooth);
			HHIFMIPPMPF().SetFloat("_Value3", ICABEDDNGIH);
			MFHPKGICPIO().SetFloat("Show Title", LHOMPJOPKHE);
			NDMPCDHADMJ().SetVector(">", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1245f, 629f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NCNPAKFAFOE()
	{
		SCShader = Shader.Find("Checkpoint");
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
			NDMPCDHADMJ().SetFloat("MaxLivesSlider", HBJJOCHGOPH);
			NDMPCDHADMJ().SetFloat("_ScreenResolution", Size);
			HCGJCMDJPGD().SetFloat("_Intensity", Smooth);
			KBOPGONOCNP().SetFloat(":\n", ICABEDDNGIH);
			LONNIJMNKFB().SetFloat("CameraFilterPack/Edge_Edge_filter", LHOMPJOPKHE);
			IGKFMCPDNOI().SetVector("catched: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 673f, 279f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			MFHPKGICPIO().SetFloat("_ColorBuffer", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("[LevelEditorScene] Error: I/O Failure! :(", Size);
			IGKFMCPDNOI().SetFloat("Offline", Smooth);
			NBPKMLMCHFN.SetFloat("_Amount", ICABEDDNGIH);
			MFHPKGICPIO().SetFloat("https://reddit.com/r/Intralism", LHOMPJOPKHE);
			IGKFMCPDNOI().SetVector("PhotonNetwork.room is null. You don't have to call LeaveRoom() when you're not in one. State: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 711f, 1270f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
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
			HHIFMIPPMPF().SetFloat(":\n", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("player.redabstract", Size);
			IGKFMCPDNOI().SetFloat(".sawoutdatedmessage", Smooth);
			HCGJCMDJPGD().SetFloat("Illegal view ID:", ICABEDDNGIH);
			LPDOGGFOBDH().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", LHOMPJOPKHE);
			HHIFMIPPMPF().SetVector("Instance\nWorking commands:\ninit or init <savepath>\npath\nsetint <key> <value>\ngetint <key> <value>\nsetfloat <key> <value>\ngetfloat <key> <value>\nsetstring <key> <value>\ngetstring <key> <value>\nsetbool <key> <value>\ngetbool <key> <value>\ndelete <key>\ndeleteall", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1588f, 1986f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
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
			NDMPCDHADMJ().SetFloat("workshop.", HBJJOCHGOPH);
			LPDOGGFOBDH().SetFloat("_TimeX", Size);
			NFKFAAHHLLM().SetFloat("BitsData", Smooth);
			MICHFGAOPKM().SetFloat(" | ", ICABEDDNGIH);
			LONNIJMNKFB().SetFloat("maps.", LHOMPJOPKHE);
			MFHPKGICPIO().SetVector("_YCrop", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1615f, 1774f));
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
			HHIFMIPPMPF().SetFloat("ready", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("Hex value #RRGGBB", Size);
			NDMPCDHADMJ().SetFloat("_Value", Smooth);
			MFHPKGICPIO().SetFloat("Horizontal", ICABEDDNGIH);
			KBOPGONOCNP().SetFloat("_SoftZDistance", LHOMPJOPKHE);
			PDEAHJPOMEF().SetVector("Submition failed", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 707f, 158f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
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
			NLFJGMBCICG().SetFloat("NO", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("{", Size);
			NLFJGMBCICG().SetFloat("No Name", Smooth);
			LPDOGGFOBDH().SetFloat("fade out duration", ICABEDDNGIH);
			HHIFMIPPMPF().SetFloat("_Value2", LHOMPJOPKHE);
			NLFJGMBCICG().SetVector("menu.tabid", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 56f, 1076f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
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
			NLFJGMBCICG().SetFloat("#000000", HBJJOCHGOPH);
			LPDOGGFOBDH().SetFloat("workshop.", Size);
			NFKFAAHHLLM().SetFloat("Joined room ", Smooth);
			MICHFGAOPKM().SetFloat("CameraFilterPack/FX_8bits_gb", ICABEDDNGIH);
			KBOPGONOCNP().SetFloat("y", LHOMPJOPKHE);
			PDEAHJPOMEF().SetVector("materialsquantity[", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1133f, 1494f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MICHFGAOPKM());
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
			NFKFAAHHLLM().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("_Value2", Size);
			HCGJCMDJPGD().SetFloat("ReconnectToMaster() with AuthValues == null is not correct!", Smooth);
			HCGJCMDJPGD().SetFloat("Joystick1Button1", ICABEDDNGIH);
			LPDOGGFOBDH().SetFloat("[LobbyPlayerElement] Created lpe for ", LHOMPJOPKHE);
			MFHPKGICPIO().SetVector("Sending RPC \"", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 458f, 1097f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
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
			NBPKMLMCHFN.SetFloat("LevelURLInputField", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("Items/", Size);
			PDEAHJPOMEF().SetFloat("0", Smooth);
			LONNIJMNKFB().SetFloat("Set EnvSprite Color", ICABEDDNGIH);
			LPDOGGFOBDH().SetFloat("speed", LHOMPJOPKHE);
			KBOPGONOCNP().SetVector("EnableRankingToggle", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1657f, 1375f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
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
			KBOPGONOCNP().SetFloat("_TraceBehindObjects", Size);
			MFHPKGICPIO().SetFloat("Left Stick Click", Smooth);
			NFKFAAHHLLM().SetFloat("#tryagain", ICABEDDNGIH);
			NFKFAAHHLLM().SetFloat("Bad parameters for getbool! Use <key> <value>", LHOMPJOPKHE);
			MICHFGAOPKM().SetVector("player.licenceaccepted", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 165f, 1409f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NPLCENPNJBM()
	{
		SCShader = Shader.Find("_Value3");
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
			PDEAHJPOMEF().SetFloat("Add Environment Object", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("Object ID. Case-Sensitive", Size);
			NFKFAAHHLLM().SetFloat("_Level", Smooth);
			NDMPCDHADMJ().SetFloat("arc", ICABEDDNGIH);
			LONNIJMNKFB().SetFloat("DPADHOR", LHOMPJOPKHE);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 54f, 1644f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NNFMIAFHMJM()
	{
		SCShader = Shader.Find("_NeighbourMaxTex");
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
			HHIFMIPPMPF().SetFloat("_CenterRadius", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("GlassesColor2", Size);
			HCGJCMDJPGD().SetFloat("settings.shaders.bloomintencity", Smooth);
			HHIFMIPPMPF().SetFloat(".lastCheckpoint.time", ICABEDDNGIH);
			MFHPKGICPIO().SetFloat("DPADHOR", LHOMPJOPKHE);
			LPDOGGFOBDH().SetVector(",", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 657f, 955f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
		SCShader = Shader.Find("0");
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
		SCShader = Shader.Find("error");
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
			HHIFMIPPMPF().SetFloat("z", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("SpectateButton", Size);
			NLFJGMBCICG().SetFloat("<size=24>", Smooth);
			MICHFGAOPKM().SetFloat("Left Stick Click", ICABEDDNGIH);
			LPDOGGFOBDH().SetFloat("inventory.selected.", LHOMPJOPKHE);
			KBOPGONOCNP().SetVector("_LightIntensity", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 67f, 1674f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
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
		SCShader = Shader.Find("_Value2");
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
			HHIFMIPPMPF().SetFloat("/", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("DPADVER", Size);
			NLFJGMBCICG().SetFloat("ItemsCountText", Smooth);
			HCGJCMDJPGD().SetFloat(".b", ICABEDDNGIH);
			NDMPCDHADMJ().SetFloat("BitsData", LHOMPJOPKHE);
			PDEAHJPOMEF().SetVector("Object ID. Case-Sensitive", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 956f, 369f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DKGBFNCOAEO()
	{
		SCShader = Shader.Find("st");
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
			LPDOGGFOBDH().SetFloat("CameraFilterPack/Vision_Rainbow", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("editor.", Size);
			HCGJCMDJPGD().SetFloat("UseScanLineSize", Smooth);
			KBOPGONOCNP().SetFloat("Offline", ICABEDDNGIH);
			LPDOGGFOBDH().SetFloat("ViewMenu", LHOMPJOPKHE);
			IGKFMCPDNOI().SetVector("SetSunSensitivity", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 824f, 417f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			NBPKMLMCHFN.SetFloat("_ColorBuffer", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("note.0", Size);
			MFHPKGICPIO().SetFloat("reset", Smooth);
			HHIFMIPPMPF().SetFloat("ENABLE_EYE_ADAPTATION", ICABEDDNGIH);
			IGKFMCPDNOI().SetFloat("_TimeX", LHOMPJOPKHE);
			HHIFMIPPMPF().SetVector("player.redarc", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 196f, 1363f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MJEFMIPLFAB()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BMOFEBKGLFI()
	{
		SCShader = Shader.Find("SetSatelliteSensitivity");
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
			NDMPCDHADMJ().SetFloat("PhotonView with ID ", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("winter2020", Size);
			NLFJGMBCICG().SetFloat("CameraFilterPack/Gradients_Ansi", Smooth);
			IGKFMCPDNOI().SetFloat("OnPhotonRandomJoinFailed() was called by PUN. No random room available, so we create one. Calling: PhotonNetwork.CreateRoom(null, new RoomOptions() {maxPlayers = 4}, null);", ICABEDDNGIH);
			MICHFGAOPKM().SetFloat("RarityImage", LHOMPJOPKHE);
			HCGJCMDJPGD().SetVector("_Amount", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1157f, 1747f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
