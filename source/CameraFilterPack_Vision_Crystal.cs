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
			NBPKMLMCHFN.SetFloat("HitInRelaxMusicToggle", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("menu.enableselectormusic", Value);
			KBOPGONOCNP().SetFloat("Scene", X);
			IIBLJCKLGFG().SetFloat("source", Y);
			NBPKMLMCHFN.SetFloat("_TimeX", CCIENBFIKKH);
			IIBLJCKLGFG().SetVector("_Offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 943f, 824f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
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
			OIMMPLPBLBK().SetFloat("CameraFilterPack/Gradients_Tech", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("</size>", Value);
			MICHFGAOPKM().SetFloat("Joystick1Button5", X);
			KBOPGONOCNP().SetFloat("[LevelEditorScene] Error: Timeout :S", Y);
			IIBLJCKLGFG().SetFloat("BadgeText", CCIENBFIKKH);
			KBOPGONOCNP().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 891f, 1525f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
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
			DEFBJOCJJKF().SetFloat("NO", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("stretchWidth", Value);
			OIMMPLPBLBK().SetFloat("Run a command for data system", X);
			IIBLJCKLGFG().SetFloat("Tab1Content", Y);
			KBOPGONOCNP().SetFloat("Failed to InstantiateSceneObject prefab: ", CCIENBFIKKH);
			IIBLJCKLGFG().SetVector("CameraFilterPack/Blur_Steam", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 704f, 392f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			DEFBJOCJJKF().SetFloat("CameraFilterPack/FX_Ascii", HBJJOCHGOPH);
			IIBLJCKLGFG().SetFloat(" base map(s)", Value);
			OIMMPLPBLBK().SetFloat("#91CCFF", X);
			KBOPGONOCNP().SetFloat("_Value2", Y);
			KBOPGONOCNP().SetFloat(" while connecting to: ", CCIENBFIKKH);
			MICHFGAOPKM().SetVector("fade out duration", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 416f, 923f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			IIBLJCKLGFG().SetFloat("maps.", Value);
			IIBLJCKLGFG().SetFloat("MapEditorScene", X);
			MICHFGAOPKM().SetFloat(" = ", Y);
			OIMMPLPBLBK().SetFloat("IconImage", CCIENBFIKKH);
			OIMMPLPBLBK().SetVector("Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1865f, 920f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
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
			IIBLJCKLGFG().SetFloat("achievements.21.progress", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("<b>Kick player by NetID</b>\nuse: /kick {NetID}\nUse \"/players\" command to get all NetIDs\nRoom owner only can kick the players", Value);
			NBPKMLMCHFN.SetFloat(".sav", X);
			IIBLJCKLGFG().SetFloat("CameraFilterPack/TV_Vignetting", Y);
			OIMMPLPBLBK().SetFloat("cipherText", CCIENBFIKKH);
			KBOPGONOCNP().SetVector(" SecondsBeforeRespawn: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 3f, 1843f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
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
			MICHFGAOPKM().SetFloat("Image effects aren't supported on this device ({0})", HBJJOCHGOPH);
			IIBLJCKLGFG().SetFloat(" ", Value);
			MICHFGAOPKM().SetFloat("_ScreenResolution", X);
			IIBLJCKLGFG().SetFloat("[PlayerBase] Reset", Y);
			OIMMPLPBLBK().SetFloat("PointsScoreText", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("restrictions\n\n#until: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 15f, 770f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			OIMMPLPBLBK().SetFloat("/Segment-[Down]", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("MenuRecordButton", Value);
			IIBLJCKLGFG().SetFloat("_Value5", X);
			DEFBJOCJJKF().SetFloat(".completed", Y);
			DEFBJOCJJKF().SetFloat("_EmissionColor", CCIENBFIKKH);
			OIMMPLPBLBK().SetVector("<b>Commands:</b>\n/help\n/players\n/kick\n/table\n/clear", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1843f, 675f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
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
			NBPKMLMCHFN.SetFloat("_BlurVector", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("_Value6", Value);
			NBPKMLMCHFN.SetFloat("PopulateMapsList", X);
			KBOPGONOCNP().SetFloat("CreateRoom failed, client stays on masterserver: {0}.", Y);
			KBOPGONOCNP().SetFloat("CameraFilterPack_Glasses_On4", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("_Noise", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1381f, 1246f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
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
			IIBLJCKLGFG().SetFloat("_TimeX", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_History4LumaTex", Value);
			NBPKMLMCHFN.SetFloat("_TimeX", X);
			NBPKMLMCHFN.SetFloat(".sav", Y);
			OIMMPLPBLBK().SetFloat("RemoveEnvironmentObject", CCIENBFIKKH);
			IIBLJCKLGFG().SetVector("tagElement", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 376f, 1818f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIBLJCKLGFG());
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
			KBOPGONOCNP().SetFloat("\" for viewID ", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("offsets", Value);
			DEFBJOCJJKF().SetFloat("_Value", X);
			DEFBJOCJJKF().SetFloat("settings.arcsnohitsoundtimedelay", Y);
			IIBLJCKLGFG().SetFloat("tagElement", CCIENBFIKKH);
			OIMMPLPBLBK().SetVector("Items/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1682f, 721f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
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
			MICHFGAOPKM().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("_Blue_B", Value);
			KBOPGONOCNP().SetFloat("Vignette", X);
			NBPKMLMCHFN.SetFloat("_Value4", Y);
			KBOPGONOCNP().SetFloat("ReJoinRoom failed. A roomname is required. If you don't know one, how will you join?", CCIENBFIKKH);
			OIMMPLPBLBK().SetVector("settings.hideui", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1731f, 156f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
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
			IIBLJCKLGFG().SetFloat("BadgeText", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("_Distortion", Value);
			MICHFGAOPKM().SetFloat("<b>", X);
			OIMMPLPBLBK().SetFloat("[EMPTY]", Y);
			NBPKMLMCHFN.SetFloat("menu.selectedplaymode", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("CameraFilterPack/Colors_HUE_Rotate", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1285f, 1783f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
