// CameraFilterPack_TV_WideScreenHV
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/TV/WideScreenHV")]
[ExecuteInEditMode]
public class CameraFilterPack_TV_WideScreenHV : MonoBehaviour
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

	private void FHGKIOOMMOH()
	{
		SCShader = Shader.Find("Start");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BGDPIHMAACO()
	{
		SCShader = Shader.Find("AudioSampler");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1345f)
			{
				HBJJOCHGOPH = 511f;
			}
			JLHLHKPHDFO().SetFloat("Hidden/DepthOfField/BokehSplatting", HBJJOCHGOPH);
			JLHLHKPHDFO().SetFloat("SpawnObj", Size);
			CIAFLBFJLEJ().SetFloat("\n", Smooth);
			DNLMFEGJJDD().SetFloat("_ScreenResolution", ICABEDDNGIH);
			GJHPODJOBHL().SetFloat("Joystick1Button10", LHOMPJOPKHE);
			JLHLHKPHDFO().SetVector("_FgCocMask", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 670f, 1819f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FJNCHGLIEMA()
	{
		SCShader = Shader.Find("_ChannelMixerGreen");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AEOLJEIDMDB()
	{
		SCShader = Shader.Find("_Value6");
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

	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 550f)
			{
				HBJJOCHGOPH = 1403f;
			}
			LNLKMDPHDCC().SetFloat("Drop_Far", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("_Value7", Size);
			MCDGIILBNIF().SetFloat("_Value", Smooth);
			BFGNMFCNDBC().SetFloat("Editor", ICABEDDNGIH);
			GJHPODJOBHL().SetFloat("Set object anchor to another object", LHOMPJOPKHE);
			LNLKMDPHDCC().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 416f, 456f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material OCHJIMJNEMO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void Update()
	{
	}

	private void OFMNDBNFBDJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material EHDJJANLINB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-102);
		}
		return BJFKDHHMLJH;
	}

	private void JHANGPCOCIG()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 184f)
			{
				HBJJOCHGOPH = 1113f;
			}
			MMOODGIODPC().SetFloat("CurrentTimeLabel", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat(").png", Size);
			CEKJODEAMGB().SetFloat("float,0", Smooth);
			IONHGBPGCHK().SetFloat("' got destroyed by engine. This is OK when loading levels. Otherwise use: PhotonNetwork.Destroy().", ICABEDDNGIH);
			JLHLHKPHDFO().SetFloat("grid", LHOMPJOPKHE);
			BFGNMFCNDBC().SetVector("PUN-instantiated '", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 572f, 1564f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LMBDNPLDGIJ()
	{
	}

	private void FOLDLDLFFLM()
	{
	}

	[SpecialName]
	private Material FHFLKLMFHOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void PMPKMGKAAJH()
	{
		SCShader = Shader.Find("settings.customdataskin");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 14f)
			{
				HBJJOCHGOPH = 627f;
			}
			CIAFLBFJLEJ().SetFloat("_Green_R", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("Reading preview file failed!: \"{0}\"", Size);
			OCHJIMJNEMO().SetFloat("_TimeX", Smooth);
			OGMEGHKECAH().SetFloat("PointsScoreText", ICABEDDNGIH);
			FHFLKLMFHOI().SetFloat("workshop.", LHOMPJOPKHE);
			OGMEGHKECAH().SetVector("FindFriends failed to apply the result, as a required value wasn't provided or the friend list length differed from result.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1992f, 280f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material OGMEGHKECAH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)73;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material CIAFLBFJLEJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void AGMJDGHLBMN()
	{
	}

	private void LLKKGGLNIDF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1119f)
			{
				HBJJOCHGOPH = 1545f;
			}
			DNLMFEGJJDD().SetFloat("_TimeX", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("TRACKING", Size);
			LNLKMDPHDCC().SetFloat("OpLeaveLobby()", Smooth);
			OGMEGHKECAH().SetFloat("In Main Menu", ICABEDDNGIH);
			KDMBOKLMADJ().SetFloat("_Angle", LHOMPJOPKHE);
			GJHPODJOBHL().SetVector("_EdgeSharpness", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1390f, 1757f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ABIOAMNCEOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 265f)
			{
				HBJJOCHGOPH = 713f;
			}
			LONNIJMNKFB().SetFloat("OpJoinLobby()", HBJJOCHGOPH);
			CIAFLBFJLEJ().SetFloat("Warning, using scrollbors with the Scroll Snap controls is not advised as it causes unpredictable results", Size);
			CIAFLBFJLEJ().SetFloat("Copy from ", Smooth);
			MCDGIILBNIF().SetFloat("Text", ICABEDDNGIH);
			FHFLKLMFHOI().SetFloat("player.orangearc", LHOMPJOPKHE);
			EHDJJANLINB().SetVector("[BuildInfo] Error: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 454f, 1996f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CIAFLBFJLEJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1952f)
			{
				HBJJOCHGOPH = 1172f;
			}
			OCHJIMJNEMO().SetFloat("inventory.selected.", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("_MainTex2", Size);
			CIAFLBFJLEJ().SetFloat("_Value3", Smooth);
			DNLMFEGJJDD().SetFloat("Noise & Grain effect failing as noise texture is not assigned. please assign.", ICABEDDNGIH);
			KAFBNOBOIAJ().SetFloat("Set satellite color", LHOMPJOPKHE);
			DNLMFEGJJDD().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1693f, 326f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PFNFPINPCMH()
	{
	}

	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 127f)
			{
				HBJJOCHGOPH = 1504f;
			}
			FHFLKLMFHOI().SetFloat("Set Satellite Input", HBJJOCHGOPH);
			FHFLKLMFHOI().SetFloat("RPC: 'OnAwakeRPC' PhotonView: ", Size);
			DBOLLHHMKKN().SetFloat("<color=#{0}>{1}</color>", Smooth);
			NBPKMLMCHFN.SetFloat(". Check if the server is available.", ICABEDDNGIH);
			CEKJODEAMGB().SetFloat("_Value2", LHOMPJOPKHE);
			IONHGBPGCHK().SetVector("The image effect ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1915f, 1599f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EFJDNLGNACH()
	{
		SCShader = Shader.Find("masterSteamID");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1363f)
			{
				HBJJOCHGOPH = 1929f;
			}
			CIAFLBFJLEJ().SetFloat("float,1.5", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("w", Size);
			IONHGBPGCHK().SetFloat(".icon", Smooth);
			LONNIJMNKFB().SetFloat("SetSatelliteColor", ICABEDDNGIH);
			MMOODGIODPC().SetFloat("PenaltyScoreText", LHOMPJOPKHE);
			OCHJIMJNEMO().SetVector("player.goldwatermelon", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1273f, 1057f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1987f)
			{
				HBJJOCHGOPH = 1208f;
			}
			OCHJIMJNEMO().SetFloat("CameraFilterPack_Paper2", HBJJOCHGOPH);
			GJHPODJOBHL().SetFloat("CameraFilterPack/Distortion_Noise", Size);
			MCDGIILBNIF().SetFloat(".", Smooth);
			MMOODGIODPC().SetFloat("fetch", ICABEDDNGIH);
			FHFLKLMFHOI().SetFloat("_BgFade", LHOMPJOPKHE);
			KAFBNOBOIAJ().SetVector("[FileSelector] Dialog canceled", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 572f, 398f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material MMOODGIODPC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)103;
		}
		return BJFKDHHMLJH;
	}

	private void AIJGAJIOJDJ()
	{
	}

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)93;
		}
		return BJFKDHHMLJH;
	}

	private void KCDOMIJBFLL()
	{
	}

	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 421f)
			{
				HBJJOCHGOPH = 35f;
			}
			KDMBOKLMADJ().SetFloat("Object ID. Case-Sensitive", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("|", Size);
			MCDGIILBNIF().SetFloat("_Value6", Smooth);
			BFGNMFCNDBC().SetFloat("UsernameText", ICABEDDNGIH);
			OGMEGHKECAH().SetFloat("DPADHOR", LHOMPJOPKHE);
			BFGNMFCNDBC().SetVector("settings.gamemessagesduration", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 145f, 359f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 821f)
			{
				HBJJOCHGOPH = 1584f;
			}
			MMOODGIODPC().SetFloat("_Value3", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("workshop.", Size);
			BFGNMFCNDBC().SetFloat("#scoresubmitionfailed: ", Smooth);
			KDMBOKLMADJ().SetFloat("LB", ICABEDDNGIH);
			IONHGBPGCHK().SetFloat("_BlurRadius4", LHOMPJOPKHE);
			DBOLLHHMKKN().SetVector("_MainTex2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 167f, 1748f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OOGIHDLBBLM()
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

	[SpecialName]
	private Material KDMBOKLMADJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-106);
		}
		return BJFKDHHMLJH;
	}

	private void CPAJLKHMOJB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1021f)
			{
				HBJJOCHGOPH = 1488f;
			}
			NBPKMLMCHFN.SetFloat(" failed in a server-side plugin. Check the configuration in the Dashboard. Message from server-plugin: ", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("_TimeX", Size);
			BFGNMFCNDBC().SetFloat("[CraftingPanel] Init", Smooth);
			LONNIJMNKFB().SetFloat("_Value3", ICABEDDNGIH);
			LONNIJMNKFB().SetFloat("OnRenderImage in Helper called ...", LHOMPJOPKHE);
			NBPKMLMCHFN.SetVector("Skipping packet for ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1771f, 302f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MKFLBEGJJDC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 268f)
			{
				HBJJOCHGOPH = 645f;
			}
			DBOLLHHMKKN().SetFloat("--------------------------------", HBJJOCHGOPH);
			CIAFLBFJLEJ().SetFloat("_Jitter", Size);
			IONHGBPGCHK().SetFloat("ready", Smooth);
			OGMEGHKECAH().SetFloat("LevelEditor/patterns", ICABEDDNGIH);
			OGMEGHKECAH().SetFloat("CameraFilterPack/Blur_Focus", LHOMPJOPKHE);
			OGMEGHKECAH().SetVector("Object ID. Case-Sensitive", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1170f, 1472f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LNLKMDPHDCC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
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

	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 49f)
			{
				HBJJOCHGOPH = 479f;
			}
			DBOLLHHMKKN().SetFloat("hidden", HBJJOCHGOPH);
			CEKJODEAMGB().SetFloat("PlayerBase_", Size);
			FHFLKLMFHOI().SetFloat("CameraFilterPack_Broken_Screen1", Smooth);
			DBOLLHHMKKN().SetFloat(", ", ICABEDDNGIH);
			DBOLLHHMKKN().SetFloat("Set Satellite Emission", LHOMPJOPKHE);
			NBPKMLMCHFN.SetVector("Reading preview file failed! Make sure JSON file is filled properly and/or file exists: \"{0}\"", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1552f, 942f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-112);
		}
		return BJFKDHHMLJH;
	}

	private void DIPDEHOOBPG()
	{
		SCShader = Shader.Find("settings_bindings_sec_");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CFIAKIJAILI()
	{
	}

	private void FABMDEHEDNO()
	{
	}

	[SpecialName]
	private Material KAFBNOBOIAJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-91);
		}
		return BJFKDHHMLJH;
	}

	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 93f)
			{
				HBJJOCHGOPH = 1674f;
			}
			DBOLLHHMKKN().SetFloat(".completed", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("CameraFilterPack_TV_Noise3", Size);
			BFGNMFCNDBC().SetFloat("_Value2", Smooth);
			FHFLKLMFHOI().SetFloat(".sawoutdatedmessage", ICABEDDNGIH);
			GJHPODJOBHL().SetFloat("float,2", LHOMPJOPKHE);
			DBOLLHHMKKN().SetVector("Fill", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 892f, 1648f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 598f)
			{
				HBJJOCHGOPH = 504f;
			}
			FHFLKLMFHOI().SetFloat("RequestSelectedLevel", HBJJOCHGOPH);
			JLHLHKPHDFO().SetFloat("IconImage", Size);
			KAFBNOBOIAJ().SetFloat("SetSunSensitivity", Smooth);
			FHFLKLMFHOI().SetFloat("Cross", ICABEDDNGIH);
			MMOODGIODPC().SetFloat("_Speed", LHOMPJOPKHE);
			GJHPODJOBHL().SetVector("b", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1846f, 41f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CEKJODEAMGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void POIMNOBDBBN()
	{
	}

	[SpecialName]
	private Material MCDGIILBNIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)122;
		}
		return BJFKDHHMLJH;
	}

	private void KDMKDEKCELE()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AEIJFLJEABG()
	{
	}

	private void OBAEDJJDCPN()
	{
	}

	private void GBGAMCPNBCC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BKGJOECFMID()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IKIDIJLIGOH()
	{
	}

	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 982f)
			{
				HBJJOCHGOPH = 1832f;
			}
			KDMBOKLMADJ().SetFloat("[SaveSystem] Outdated savefile found", HBJJOCHGOPH);
			EHDJJANLINB().SetFloat("_Value2", Size);
			NBPKMLMCHFN.SetFloat("Reset All", Smooth);
			KAFBNOBOIAJ().SetFloat("_Speed", ICABEDDNGIH);
			OGMEGHKECAH().SetFloat("NEW_ACHIEVEMENT_1_", LHOMPJOPKHE);
			NBPKMLMCHFN.SetVector("CameraFilterPack/3D_Inverse", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1661f, 1513f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material GJHPODJOBHL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void MNBPNHNAEBK()
	{
		SCShader = Shader.Find("note.0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 539f)
			{
				HBJJOCHGOPH = 329f;
			}
			FHFLKLMFHOI().SetFloat("1087340967", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("EventTimeInputField", Size);
			DBOLLHHMKKN().SetFloat("_TimeX", Smooth);
			KAFBNOBOIAJ().SetFloat("_ScreenResolution", ICABEDDNGIH);
			OGMEGHKECAH().SetFloat("_FixDistance", LHOMPJOPKHE);
			JLHLHKPHDFO().SetVector("': ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1552f, 1110f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 411f)
			{
				HBJJOCHGOPH = 1067f;
			}
			DNLMFEGJJDD().SetFloat("mapselector.filter.subscribedonly", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat(" from: ", Size);
			CIAFLBFJLEJ().SetFloat("Tab1Content", Smooth);
			CEKJODEAMGB().SetFloat("Set sun lerp speed", ICABEDDNGIH);
			LONNIJMNKFB().SetFloat("player.licenceaccepted", LHOMPJOPKHE);
			MCDGIILBNIF().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1421f, 1680f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CEKJODEAMGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MGMAOBPPOBJ()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material BFGNMFCNDBC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material CEKJODEAMGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
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

	private void IFJDKDFLGBG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/TV_WideScreenHV");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FNCDAPDOBBI()
	{
		SCShader = Shader.Find("Item created: Id: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FKDEEJFNNJC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IMGGCJICLHK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LDDKCCMHMIC()
	{
	}

	[SpecialName]
	private Material DNLMFEGJJDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void BMOFEBKGLFI()
	{
		SCShader = Shader.Find("player.xp");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
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

	private void EKCKJLFFAID()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NNPBKKBFDHH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1123f)
			{
				HBJJOCHGOPH = 191f;
			}
			LONNIJMNKFB().SetFloat("1177138211", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("player.xp", Size);
			CIAFLBFJLEJ().SetFloat("_TimeX", Smooth);
			OCHJIMJNEMO().SetFloat("(master)", ICABEDDNGIH);
			DNLMFEGJJDD().SetFloat("_MinVelocity", LHOMPJOPKHE);
			DNLMFEGJJDD().SetVector("_MainTex2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 410f, 268f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
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
			if (HBJJOCHGOPH > 392f)
			{
				HBJJOCHGOPH = 862f;
			}
			CIAFLBFJLEJ().SetFloat("DPADVER", HBJJOCHGOPH);
			FHFLKLMFHOI().SetFloat("ScrollPanel", Size);
			OCHJIMJNEMO().SetFloat("_Value", Smooth);
			JLHLHKPHDFO().SetFloat("settings.enablehitsoundsinnormal", ICABEDDNGIH);
			MCDGIILBNIF().SetFloat("Image", LHOMPJOPKHE);
			IONHGBPGCHK().SetVector("TransferOwnership() view ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 885f, 1998f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JHLGHODFJOO()
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

	private void BMIOFJFMCBG()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 813f)
			{
				HBJJOCHGOPH = 1951f;
			}
			OGMEGHKECAH().SetFloat("#tryagain", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("Joystick1Button0", Size);
			KAFBNOBOIAJ().SetFloat(" x ", Smooth);
			LNLKMDPHDCC().SetFloat("JoinRoom failed (room maybe closed by now). Client stays on masterserver: {0}. State: {1}", ICABEDDNGIH);
			LONNIJMNKFB().SetFloat("_BorderColor", LHOMPJOPKHE);
			MCDGIILBNIF().SetVector(" not exist", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 642f, 957f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CIAFLBFJLEJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DBOLLHHMKKN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)116;
		}
		return BJFKDHHMLJH;
	}

	private void NNCCPEBIAKH()
	{
		SCShader = Shader.Find("_LightIntensity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 579f)
			{
				HBJJOCHGOPH = 815f;
			}
			FHFLKLMFHOI().SetFloat(" = ", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("Setting autoCleanUpPlayerObjects while in a room is not supported.", Size);
			LONNIJMNKFB().SetFloat("</i>", Smooth);
			MMOODGIODPC().SetFloat("_History1LumaTex", ICABEDDNGIH);
			KAFBNOBOIAJ().SetFloat("Mouse Wheel Up", LHOMPJOPKHE);
			CEKJODEAMGB().SetVector("[Up]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1369f, 854f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CEKJODEAMGB());
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
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void GCDLIKEDMCF()
	{
	}

	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 179f)
			{
				HBJJOCHGOPH = 1114f;
			}
			MCDGIILBNIF().SetFloat("y", HBJJOCHGOPH);
			KDMBOKLMADJ().SetFloat("RateButton", Size);
			BFGNMFCNDBC().SetFloat("NO", Smooth);
			CIAFLBFJLEJ().SetFloat("received</b>\n#reason: ", ICABEDDNGIH);
			DNLMFEGJJDD().SetFloat(".mp3", LHOMPJOPKHE);
			BFGNMFCNDBC().SetVector("_Distortion", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1745f, 903f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MKIMDFLBFOM()
	{
		SCShader = Shader.Find("Left");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LADCJEIALMH()
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

	private void MCKCCPLJIFE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JONGNKNLLND()
	{
		SCShader = Shader.Find("PUNCloudBestRegion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CNGAJDBOCLJ()
	{
		SCShader = Shader.Find("player.rgb");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void APKNAPHOFHC()
	{
	}

	private void GKNKIIEALCH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DGCGGKMNPLD()
	{
	}
}
