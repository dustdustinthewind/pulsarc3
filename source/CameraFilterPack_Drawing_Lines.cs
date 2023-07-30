// CameraFilterPack_Drawing_Lines
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Drawing/Lines")]
[ExecuteInEditMode]
public class CameraFilterPack_Drawing_Lines : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0.1f, 10f)]
	public float Number = 1f;

	[Range(0f, 1f)]
	public float Random = 0.5f;

	[Range(0f, 10f)]
	private float AOEEPOHCCHE = 1f;

	[Range(0f, 10f)]
	private float CCIENBFIKKH = 1f;

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

	private void MGFFNGEGFDC()
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

	private void EPEGAEGDJAM()
	{
		SCShader = Shader.Find("PhotonNetwork error: Could not Instantiate the prefab [");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FHPFJBFCOOF()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EGEGNHLODAA()
	{
	}

	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1067f)
			{
				HBJJOCHGOPH = 692f;
			}
			NBPKMLMCHFN.SetFloat("rarity", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("_FixDistance", Number);
			HKHBBBFLGJH().SetFloat("Error: Can not set the OnSerialize rate higher than the overall SendRate.", Random);
			FAIFBBGFAIB().SetFloat("maxScore", AOEEPOHCCHE);
			JLHLHKPHDFO().SetFloat("x", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("_Value7", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 300f, 1030f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 836f)
			{
				HBJJOCHGOPH = 1767f;
			}
			JLHLHKPHDFO().SetFloat("HIDE CONFIG [Ctrl+E]", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("list", Number);
			JLHLHKPHDFO().SetFloat("_EmissionColor", Random);
			FAIFBBGFAIB().SetFloat("ItemTemplate", AOEEPOHCCHE);
			PDEAHJPOMEF().SetFloat("_FixDistance", CCIENBFIKKH);
			JLHLHKPHDFO().SetVector("FinalScoreSmallText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1649f, 1018f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material BFGNMFCNDBC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1888f)
			{
				HBJJOCHGOPH = 659f;
			}
			JLHLHKPHDFO().SetFloat("_ColoredChange", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Add Environment Sprite", Number);
			MICHFGAOPKM().SetFloat("_Value7", Random);
			FLOHGDECHHH().SetFloat(".icon", AOEEPOHCCHE);
			FLOHGDECHHH().SetFloat("_Value3", CCIENBFIKKH);
			DNLMFEGJJDD().SetVector("LevelInfoInputField", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1859f, 674f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HKHBBBFLGJH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)77;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material MICHFGAOPKM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)101;
		}
		return BJFKDHHMLJH;
	}

	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1149f)
			{
				HBJJOCHGOPH = 793f;
			}
			JLHLHKPHDFO().SetFloat("[DiscordController] Responding no to Ask to Join request", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("Illegal view ID:", Number);
			FLOHGDECHHH().SetFloat("\" for viewID ", Random);
			HKHBBBFLGJH().SetFloat("/", AOEEPOHCCHE);
			PDEAHJPOMEF().SetFloat("TestTicket", CCIENBFIKKH);
			DNLMFEGJJDD().SetVector("_Bloom3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1260f, 1970f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FDPOFMCFBMF()
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
			if (HBJJOCHGOPH > 1956f)
			{
				HBJJOCHGOPH = 1922f;
			}
			HKHBBBFLGJH().SetFloat("colorC", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("[MapsData] User's maps was loaded", Number);
			MFHPKGICPIO().SetFloat("Value", Random);
			FAIFBBGFAIB().SetFloat("/", AOEEPOHCCHE);
			FAIFBBGFAIB().SetFloat("Malformed RPC; this should never occur. Content: ", CCIENBFIKKH);
			MICHFGAOPKM().SetVector("CameraFilterPack/Distortion_Lens", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1377f, 63f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DLMPALHKMON()
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
			BJFKDHHMLJH.hideFlags = HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1979f)
			{
				HBJJOCHGOPH = 1971f;
			}
			NBPKMLMCHFN.SetFloat("settings.volume.sfx", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("[ItemsHandler] Found ", Number);
			PDEAHJPOMEF().SetFloat("PossibleMapMaxScoreText", Random);
			DNLMFEGJJDD().SetFloat("OpJoinRoom()", AOEEPOHCCHE);
			MICHFGAOPKM().SetFloat("inventory.selected.", CCIENBFIKKH);
			MICHFGAOPKM().SetVector("_Radius", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1367f, 208f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GAOOPEEBGJA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ODAIMOJLJOF()
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

	[SpecialName]
	private Material MFHPKGICPIO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void Update()
	{
	}

	private void OCMKCBBCEFG()
	{
	}

	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 475f)
			{
				HBJJOCHGOPH = 1638f;
			}
			DNLMFEGJJDD().SetFloat("[Right]", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("ColorBlood", Number);
			HKHBBBFLGJH().SetFloat("OnStatusChanged: {0} current State: {1}", Random);
			FLOHGDECHHH().SetFloat("-", AOEEPOHCCHE);
			HKHBBBFLGJH().SetFloat("_Value2", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("_DepthLevel", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 428f, 1415f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FABMDEHEDNO()
	{
	}

	private void FKEJGBFDCAH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 998f)
			{
				HBJJOCHGOPH = 1138f;
			}
			HKHBBBFLGJH().SetFloat("https://reddit.com/r/Intralism", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("Start", Number);
			FLOHGDECHHH().SetFloat("#timeuntilend: ", Random);
			JLHLHKPHDFO().SetFloat("_Value7", AOEEPOHCCHE);
			HKHBBBFLGJH().SetFloat("_Value3", CCIENBFIKKH);
			BFGNMFCNDBC().SetVector("Add Environment Object", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 768f, 39f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NCNPAKFAFOE()
	{
		SCShader = Shader.Find("Hidden/DepthOfField/BokehSplatting");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ONMGIPAILOH()
	{
	}

	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1586f)
			{
				HBJJOCHGOPH = 1068f;
			}
			BFGNMFCNDBC().SetFloat("shader.none", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("_MainTex2", Number);
			PDEAHJPOMEF().SetFloat("_Value2", Random);
			MFHPKGICPIO().SetFloat("_TimeX", AOEEPOHCCHE);
			BFGNMFCNDBC().SetFloat("ERROR: Steam App ID isn't set! Make sure 'steam_appid.txt' is placed next to the executable file, and contains a single line with the app id.", CCIENBFIKKH);
			BFGNMFCNDBC().SetVector("#onrankchangeuptext", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1472f, 1833f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LOMDIOLNFHI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Drawing_Lines");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DPFOEBCADNP()
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
			NBPKMLMCHFN.SetFloat("_Value", Number);
			NBPKMLMCHFN.SetFloat("_Value2", Random);
			NBPKMLMCHFN.SetFloat("_Value3", AOEEPOHCCHE);
			NBPKMLMCHFN.SetFloat("_Value4", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PKBENONAOOL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DLBODOFAJGM()
	{
		SCShader = Shader.Find("SetSatelliteColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material FAIFBBGFAIB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)92;
		}
		return BJFKDHHMLJH;
	}

	private void KMCPMOGKDEH()
	{
		SCShader = Shader.Find("[Left]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material JLHLHKPHDFO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)109;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material DNLMFEGJJDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void IIFCIDDJHPM()
	{
	}

	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1132f)
			{
				HBJJOCHGOPH = 1325f;
			}
			DNLMFEGJJDD().SetFloat("Joystick1Button9", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("[RanksSystem] Init", Number);
			JLHLHKPHDFO().SetFloat("restrictions\n\n#until: ", Random);
			FLOHGDECHHH().SetFloat("delete", AOEEPOHCCHE);
			BFGNMFCNDBC().SetFloat("From {0} at Index {1} \n", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1722f, 428f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DHNGNHGDPLM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JHJFBCFBKLD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CGBHOELMAOC()
	{
	}

	private void IBHACCEEFFI()
	{
	}

	private void MJNPIDGNJMK()
	{
	}

	private void OBAEDJJDCPN()
	{
	}

	private void HDDECCMEJKA()
	{
	}

	private void NPLCENPNJBM()
	{
		SCShader = Shader.Find(".lastCheckpoint.correctScore");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FNCDAPDOBBI()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BMIOFJFMCBG()
	{
		SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NBGIMIDICKE()
	{
		SCShader = Shader.Find("[PlayerController] ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KDMKDEKCELE()
	{
		SCShader = Shader.Find(" but this PhotonView does not exist! View was/is ours.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LCJHDLKJEOM()
	{
	}

	private void KIMMMCJFMAB()
	{
		SCShader = Shader.Find("Obtain promo Item");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LADCJEIALMH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}
}
