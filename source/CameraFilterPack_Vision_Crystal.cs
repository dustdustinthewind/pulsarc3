// CameraFilterPack_Vision_Crystal
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Vision/Crystal")]
public class CameraFilterPack_Vision_Crystal : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(-10f, 10f)]
	public float Value = 1f;

	[Range(-1f, 1f)]
	public float X = 1f;

	[Range(-1f, 1f)]
	public float Y = 1f;

	[Range(-1f, 1f)]
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

	private void MKIMDFLBFOM()
	{
	}

	private void NAOLAJPDGIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 641f)
			{
				HBJJOCHGOPH = 49f;
			}
			DEFBJOCJJKF().SetFloat("HitInRelaxMusicToggle", HBJJOCHGOPH);
			IIBLJCKLGFG().SetFloat("SelectorMusicToggle", Value);
			NBPKMLMCHFN.SetFloat("Scene", X);
			MICHFGAOPKM().SetFloat("Sequence contains no elements", Y);
			OIMMPLPBLBK().SetFloat("_TimeX", CCIENBFIKKH);
			KBOPGONOCNP().SetVector("_CurveParams", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 943f, 824f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1975f)
			{
				HBJJOCHGOPH = 389f;
			}
			IIBLJCKLGFG().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			IIBLJCKLGFG().SetFloat("</size>", Value);
			OIMMPLPBLBK().SetFloat("Joystick1Button4", X);
			IIBLJCKLGFG().SetFloat("[MapEditor] Item creation successful! Published Item ID: ", Y);
			OIMMPLPBLBK().SetFloat("BadgeText", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 891f, 1525f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material OIMMPLPBLBK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)116;
		}
		return BJFKDHHMLJH;
	}

	private void EGEPLFGKGLI()
	{
	}

	[SpecialName]
	private Material IIBLJCKLGFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-92);
		}
		return BJFKDHHMLJH;
	}

	private void LIEGJOHINGC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EJJEDJIOFAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MFMIODIAKNI()
	{
	}

	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 627f)
			{
				HBJJOCHGOPH = 1763f;
			}
			NBPKMLMCHFN.SetFloat("YES", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("offsets", Value);
			IIBLJCKLGFG().SetFloat("Run a command for data system", X);
			DEFBJOCJJKF().SetFloat("LevelNameInputField", Y);
			MICHFGAOPKM().SetFloat(". Prefab must have a PhotonView component.", CCIENBFIKKH);
			DEFBJOCJJKF().SetVector("CameraFilterPack/Blur_Steam", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 704f, 392f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ICDBMJKMIKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HMPGIFBJFIK()
	{
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BFEILOMHNPC()
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
			if (HBJJOCHGOPH > 1462f)
			{
				HBJJOCHGOPH = 942f;
			}
			OIMMPLPBLBK().SetFloat("_Distortion", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat(" workshop map(s)", Value);
			OIMMPLPBLBK().SetFloat("ItemNameText", X);
			NBPKMLMCHFN.SetFloat("_TimeX", Y);
			IIBLJCKLGFG().SetFloat("The server address is 127.0.0.1 (localhost): Make sure the server is running on this machine. Android and iOS emulators have their own localhost.", CCIENBFIKKH);
			MICHFGAOPKM().SetVector("fade out duration", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 416f, 923f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	private void HMNLHMLILKD()
	{
	}

	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 247f)
			{
				HBJJOCHGOPH = 1919f;
			}
			NBPKMLMCHFN.SetFloat("_Value7", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("maps.", Value);
			MICHFGAOPKM().SetFloat("https://store.steampowered.com/itemstore/513510/", X);
			IIBLJCKLGFG().SetFloat("#", Y);
			KBOPGONOCNP().SetFloat("inventory.selected.", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("ScreenResolutionPanel", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1865f, 920f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IMGGCJICLHK()
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
			if (HBJJOCHGOPH > 728f)
			{
				HBJJOCHGOPH = 2f;
			}
			OIMMPLPBLBK().SetFloat("achievements.21.completed.workshop.", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("[SERVER] Kicked ", Value);
			KBOPGONOCNP().SetFloat("Saved Game: ", X);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", Y);
			KBOPGONOCNP().SetFloat("d264dbba9c2410771b4ad918903b3f4cd9e276a9", CCIENBFIKKH);
			MICHFGAOPKM().SetVector("PunRespawn", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 3f, 1843f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
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

	private void DIPDEHOOBPG()
	{
	}

	[SpecialName]
	private Material DEFBJOCJJKF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 856f)
			{
				HBJJOCHGOPH = 278f;
			}
			MICHFGAOPKM().SetFloat("_BaseTex", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat(" ", Value);
			KBOPGONOCNP().SetFloat("_Value4", X);
			MICHFGAOPKM().SetFloat("_EmissionGain", Y);
			DEFBJOCJJKF().SetFloat("PointsScoreText", CCIENBFIKKH);
			MICHFGAOPKM().SetVector("#forever", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 15f, 770f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KCCIEMBMOBA()
	{
	}

	private void Start()
	{
	}

	private void ODAIMOJLJOF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 265f)
			{
				HBJJOCHGOPH = 1322f;
			}
			KBOPGONOCNP().SetFloat("/Segment-[Up]", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("EventSystem", Value);
			IIBLJCKLGFG().SetFloat("_Value5", X);
			MICHFGAOPKM().SetFloat("[MapsSystem] Unloading maps resources...", Y);
			OIMMPLPBLBK().SetFloat("_EmissionColor", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("<b>Commands:</b>\n/help\n/players\n/kick\n/table\n/clear", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1843f, 675f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1413f)
			{
				HBJJOCHGOPH = 878f;
			}
			OIMMPLPBLBK().SetFloat("_BlurVector", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("_Value5", Value);
			KBOPGONOCNP().SetFloat("mapselector.filter.subscribedonly", X);
			OIMMPLPBLBK().SetFloat(" ", Y);
			IIBLJCKLGFG().SetFloat("_MainTex2", CCIENBFIKKH);
			DEFBJOCJJKF().SetVector("_Noise", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1381f, 1246f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NPLCENPNJBM()
	{
	}

	private void PMPKMGKAAJH()
	{
	}

	private void FKEJGBFDCAH()
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
			NBPKMLMCHFN.SetFloat("_Value", Value);
			NBPKMLMCHFN.SetFloat("_Value2", X);
			NBPKMLMCHFN.SetFloat("_Value3", Y);
			NBPKMLMCHFN.SetFloat("_Value4", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HNILMGEKDEC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JOJFHFHOCHO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1702f)
			{
				HBJJOCHGOPH = 1544f;
			}
			OIMMPLPBLBK().SetFloat("CameraFilterPack/BlurHole", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("_History2LumaTex", Value);
			OIMMPLPBLBK().SetFloat("_TimeX", X);
			OIMMPLPBLBK().SetFloat("Saved Game: ", Y);
			OIMMPLPBLBK().SetFloat("Spawn new environment object (sun, satellite etc) and sets its id", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("tagElement", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 376f, 1818f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-80);
		}
		return BJFKDHHMLJH;
	}

	private void CGBHOELMAOC()
	{
	}

	private void FHPFJBFCOOF()
	{
	}

	private void IMCKJCHKMKB()
	{
	}

	private void JAAJECBCCFM()
	{
	}

	private void MAOCOEGAFND()
	{
	}

	private void DOEPOGLEGLE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OBAEDJJDCPN()
	{
	}

	private void GHILDCBCDJI()
	{
	}

	private void HGDDCINLDAD()
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
			if (HBJJOCHGOPH > 1280f)
			{
				HBJJOCHGOPH = 1239f;
			}
			KBOPGONOCNP().SetFloat(" Remote called.", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("offsets", Value);
			MICHFGAOPKM().SetFloat("_TimeX", X);
			MICHFGAOPKM().SetFloat("settings.enablehitsoundsinnormal", Y);
			MICHFGAOPKM().SetFloat(" ", CCIENBFIKKH);
			KBOPGONOCNP().SetVector("/config", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1682f, 721f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1368f)
			{
				HBJJOCHGOPH = 404f;
			}
			DEFBJOCJJKF().SetFloat("_Value4", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("_Blue_R", Value);
			IIBLJCKLGFG().SetFloat("CameraFilterPack_TV_Vignetting1", X);
			NBPKMLMCHFN.SetFloat("_Value3", Y);
			OIMMPLPBLBK().SetFloat("JoinRandomRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", CCIENBFIKKH);
			KBOPGONOCNP().SetVector("' found!", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1731f, 156f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ONMGIPAILOH()
	{
	}

	private void KDMANOEMOCA()
	{
	}

	private void GKNKIIEALCH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JKFDDNMPOJH()
	{
	}

	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1528f)
			{
				HBJJOCHGOPH = 1919f;
			}
			DEFBJOCJJKF().SetFloat("BadgeText", HBJJOCHGOPH);
			IIBLJCKLGFG().SetFloat("_Distortion", Value);
			OIMMPLPBLBK().SetFloat("Loading...", X);
			NBPKMLMCHFN.SetFloat("#", Y);
			IIBLJCKLGFG().SetFloat("menu.selectedplaymode", CCIENBFIKKH);
			IIBLJCKLGFG().SetVector("_Val", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1285f, 1783f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
