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
		SCShader = Shader.Find("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FHPFJBFCOOF()
	{
		SCShader = Shader.Find("_PositionX");
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
			NBPKMLMCHFN.SetFloat("InfoText", HBJJOCHGOPH);
			HKHBBBFLGJH().SetFloat("_FixDistance", Number);
			DNLMFEGJJDD().SetFloat("Can't connect: Loading settings failed. ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings", Random);
			JLHLHKPHDFO().SetFloat("#md5submitionfailed: ", AOEEPOHCCHE);
			FAIFBBGFAIB().SetFloat("x", CCIENBFIKKH);
			JLHLHKPHDFO().SetVector("_Value7", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 300f, 1030f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
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
			PDEAHJPOMEF().SetFloat("Committing changes...", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("[LocalizationService] All languages: ", Number);
			BFGNMFCNDBC().SetFloat("_EmissionGain", Random);
			BFGNMFCNDBC().SetFloat("Item ", AOEEPOHCCHE);
			BFGNMFCNDBC().SetFloat("_FixDistance", CCIENBFIKKH);
			HKHBBBFLGJH().SetVector("FinalScoreSmallText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1649f, 1018f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLOHGDECHHH());
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
			MFHPKGICPIO().SetFloat("_ColoredChange", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("Add Environment Sprite", Number);
			JLHLHKPHDFO().SetFloat("_Value7", Random);
			JLHLHKPHDFO().SetFloat(".", AOEEPOHCCHE);
			FAIFBBGFAIB().SetFloat("_Value4", CCIENBFIKKH);
			FLOHGDECHHH().SetVector("LevelNameInputField", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1859f, 674f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
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
			PDEAHJPOMEF().SetFloat("[DiscordController] Disconnect {0}: {1}", HBJJOCHGOPH);
			HKHBBBFLGJH().SetFloat(" GO:", Number);
			FAIFBBGFAIB().SetFloat(" Owner called.", Random);
			NBPKMLMCHFN.SetFloat("#pleasewait", AOEEPOHCCHE);
			BFGNMFCNDBC().SetFloat("{0:x2}", CCIENBFIKKH);
			PDEAHJPOMEF().SetVector("_Bloom5", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1260f, 1970f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKHBBBFLGJH());
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
			MFHPKGICPIO().SetFloat("colorD", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("Editor/", Number);
			MFHPKGICPIO().SetFloat("Value", Random);
			DNLMFEGJJDD().SetFloat("_DiffuseColor", AOEEPOHCCHE);
			FLOHGDECHHH().SetFloat(", ", CCIENBFIKKH);
			MFHPKGICPIO().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1377f, 63f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
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
			DNLMFEGJJDD().SetFloat("settings.volume.editor", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("???", Number);
			NBPKMLMCHFN.SetFloat("PossibleMapMaxScoreText", Random);
			PDEAHJPOMEF().SetFloat("OpGetGameList not sent. Lobby cannot be null.", AOEEPOHCCHE);
			HKHBBBFLGJH().SetFloat("inventory.selected.", CCIENBFIKKH);
			MICHFGAOPKM().SetVector("_Quality", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1367f, 208f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
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
			PDEAHJPOMEF().SetFloat("ready", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("_Value4", Number);
			PDEAHJPOMEF().SetFloat("Connected to gameserver.", Random);
			DNLMFEGJJDD().SetFloat("-", AOEEPOHCCHE);
			DNLMFEGJJDD().SetFloat("_Value2", CCIENBFIKKH);
			FAIFBBGFAIB().SetVector("_DepthLevel", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 428f, 1415f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
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
			MFHPKGICPIO().SetFloat("https://bugs.khb-soft.ru/set_project.php?project_id=1", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("Left Stick Click", Number);
			JLHLHKPHDFO().SetFloat("#finished", Random);
			HKHBBBFLGJH().SetFloat("_PColor2", AOEEPOHCCHE);
			HKHBBBFLGJH().SetFloat("_Speed", CCIENBFIKKH);
			PDEAHJPOMEF().SetVector("type", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 768f, 39f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NCNPAKFAFOE()
	{
		SCShader = Shader.Find("_BlurCoe");
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
			FAIFBBGFAIB().SetFloat("shader.invert", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("_MainTex2", Number);
			BFGNMFCNDBC().SetFloat("_Value2", Random);
			HKHBBBFLGJH().SetFloat("_ScreenResolution", AOEEPOHCCHE);
			PDEAHJPOMEF().SetFloat("_Value1", CCIENBFIKKH);
			JLHLHKPHDFO().SetVector("#onrankchangedowntext", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1472f, 1833f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKHBBBFLGJH());
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
		SCShader = Shader.Find("Set Satellite Color");
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
		SCShader = Shader.Find("[PlayerBase] Starting new round");
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
			BFGNMFCNDBC().SetFloat("Joystick1Button10", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("player.currentrank", Number);
			MFHPKGICPIO().SetFloat("-1", Random);
			FLOHGDECHHH().SetFloat("delete", AOEEPOHCCHE);
			HKHBBBFLGJH().SetFloat("SelectionBox component must be placed on a canvas in Screen Space Overlay mode.", CCIENBFIKKH);
			DNLMFEGJJDD().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1722f, 428f));
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
		SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FNCDAPDOBBI()
	{
		SCShader = Shader.Find("Fade");
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
		SCShader = Shader.Find(": ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KDMKDEKCELE()
	{
		SCShader = Shader.Find(" By: ");
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
		SCShader = Shader.Find("key");
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
