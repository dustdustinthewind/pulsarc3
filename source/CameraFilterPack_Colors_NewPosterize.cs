// CameraFilterPack_Colors_NewPosterize
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Colors/NewPosterize")]
[ExecuteInEditMode]
public class CameraFilterPack_Colors_NewPosterize : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 2f)]
	public float Gamma = 1f;

	[Range(0f, 16f)]
	public float Colors = 11f;

	[Range(-1f, 1f)]
	public float Green_Mod = 1f;

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

	private void LIEGJOHINGC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1932f)
			{
				HBJJOCHGOPH = 1520f;
			}
			KOHGPKOFEJO().SetFloat(" beatThreshold: ", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("maps.", Gamma);
			DKNJGHFLAIF().SetFloat("HightScoreMaxPointsText", Colors);
			ADGHJOHKEHG().SetFloat("VoteUpToggle", Green_Mod);
			KEMAALEODNH().SetFloat("setAF", CCIENBFIKKH);
			KJMECMIGJJA().SetVector("[MapData] Map timing update from: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1951f, 1802f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ICILLMAKLMI()
	{
		SCShader = Shader.Find("LevelURLInputField");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CGDMLHLJIDK()
	{
		SCShader = Shader.Find("Failed to Instantiate prefab:");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material MCDGIILBNIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)99;
		}
		return BJFKDHHMLJH;
	}

	private void LIBGAKMKHJJ()
	{
		SCShader = Shader.Find(" canvas not found");
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

	[SpecialName]
	private Material KOHGPKOFEJO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
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

	[SpecialName]
	private Material NJDIODJNGGA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)110;
		}
		return BJFKDHHMLJH;
	}

	private void HMNLHMLILKD()
	{
	}

	private void CCPEDDLAMIB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material CFEDGDGBCHE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-108);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material EHDJJANLINB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.HideAndDontSave;
		}
		return BJFKDHHMLJH;
	}

	private void FGBDGGCBFLP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material KEMAALEODNH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void FBPHNEJBDJN()
	{
		SCShader = Shader.Find("mapselector.orderby");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material ABHDNGIHBKE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-89);
		}
		return BJFKDHHMLJH;
	}

	private void KDMANOEMOCA()
	{
		SCShader = Shader.Find("Left");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material ADGHJOHKEHG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void DNNFHBOOPIN()
	{
		SCShader = Shader.Find("Crosshair2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IABLKKAALGI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CFIAKIJAILI()
	{
	}

	private void AEIJFLJEABG()
	{
	}

	private void MJEFMIPLFAB()
	{
		SCShader = Shader.Find("AddEnvironmentObject");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1278f)
			{
				HBJJOCHGOPH = 1171f;
			}
			KEMAALEODNH().SetFloat("#lives", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("ChangeSelectedLevel", Gamma);
			KAFBNOBOIAJ().SetFloat("MapEnd", Colors);
			KOHGPKOFEJO().SetFloat("_Value4", Green_Mod);
			EHDJJANLINB().SetFloat("Reconnect() disabled the offline mode. No longer offline.", CCIENBFIKKH);
			KAFBNOBOIAJ().SetVector("Music End", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 508f, 1238f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
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
			if (HBJJOCHGOPH > 391f)
			{
				HBJJOCHGOPH = 53f;
			}
			MCDGIILBNIF().SetFloat("\\[ *im.*\\](\\n\\n\\n|\\n\\n|\\n|)", HBJJOCHGOPH);
			EHDJJANLINB().SetFloat("_TimeX", Gamma);
			KOHGPKOFEJO().SetFloat("_Value2", Colors);
			KJMECMIGJJA().SetFloat("{0}sec average:", Green_Mod);
			FAIFBBGFAIB().SetFloat("_Value3", CCIENBFIKKH);
			EPCGJFCCAFH().SetVector("Item invalid. Make sure your mod contains at leats one file.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 443f, 1367f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
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
			if (HBJJOCHGOPH > 623f)
			{
				HBJJOCHGOPH = 244f;
			}
			ABHDNGIHBKE().SetFloat("maps.", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("_TimeX", Gamma);
			KOHGPKOFEJO().SetFloat("maps.", Colors);
			FAIFBBGFAIB().SetFloat("StopSounds", Green_Mod);
			NDMPCDHADMJ().SetFloat("System.Int32", CCIENBFIKKH);
			NDMPCDHADMJ().SetVector("BadgeImage", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1348f, 43f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BKKJJJGADLM());
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
			if (HBJJOCHGOPH > 1893f)
			{
				HBJJOCHGOPH = 446f;
			}
			EHDJJANLINB().SetFloat("22x1", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("2hands", Gamma);
			DKNJGHFLAIF().SetFloat("ComboScoreText", Colors);
			FAIFBBGFAIB().SetFloat("/", Green_Mod);
			ADGHJOHKEHG().SetFloat("Netw. Sim.", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("ShowSprite", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1743f, 334f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1925f)
			{
				HBJJOCHGOPH = 1743f;
			}
			MCDGIILBNIF().SetFloat("[PlayerBase] Loading checkpoint data", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat("OpGetGameList not sent. LobbyType must be SqlLobby.", Gamma);
			MCDGIILBNIF().SetFloat("GlassAberration", Colors);
			ADGHJOHKEHG().SetFloat(".message", Green_Mod);
			ABHDNGIHBKE().SetFloat("_VignetteSettings", CCIENBFIKKH);
			DKNJGHFLAIF().SetVector("Items/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1208f, 1381f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	private void BMODOIJGIOO()
	{
	}

	private void JAAJECBCCFM()
	{
	}

	private void JLNNHKPHMAB()
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-116);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NDMPCDHADMJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-111);
		}
		return BJFKDHHMLJH;
	}

	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 385f)
			{
				HBJJOCHGOPH = 974f;
			}
			EHDJJANLINB().SetFloat("_EmissionGain", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("Sending vacant view IDs. Length: ", Gamma);
			KJMECMIGJJA().SetFloat("[MapsData] Workshop maps was loaded", Colors);
			NJDIODJNGGA().SetFloat("colorB", Green_Mod);
			MCDGIILBNIF().SetFloat("CameraFilterPack/Blend2Camera_Exclusion", CCIENBFIKKH);
			CFEDGDGBCHE().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 647f, 180f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MECJHOJPODB()
	{
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Colors_NewPosterize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ODAIMOJLJOF()
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
			if (HBJJOCHGOPH > 1956f)
			{
				HBJJOCHGOPH = 874f;
			}
			KAFBNOBOIAJ().SetFloat(" Also make sure to disable sprite packing for this sprite.", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("error", Gamma);
			CFEDGDGBCHE().SetFloat("FinalScoreSmallText", Colors);
			ADGHJOHKEHG().SetFloat("[FileSelector] Dialog ended, result: ", Green_Mod);
			NJDIODJNGGA().SetFloat(".played", CCIENBFIKKH);
			EHDJJANLINB().SetVector("</color>", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 634f, 686f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HLDFOJMHKNL()
	{
	}

	private void DIPDEHOOBPG()
	{
		SCShader = Shader.Find("[LevelEditorScene] Error: Timeout :S");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NNCCPEBIAKH()
	{
		SCShader = Shader.Find("SetSunInput");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material EPCGJFCCAFH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return BJFKDHHMLJH;
	}

	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1148f)
			{
				HBJJOCHGOPH = 1235f;
			}
			DOHGBNPMBKG().SetFloat(": ", HBJJOCHGOPH);
			ADGHJOHKEHG().SetFloat("88f00bdf0ad61b16b803971ebe071962", Gamma);
			DOHGBNPMBKG().SetFloat("value", Colors);
			NDMPCDHADMJ().SetFloat(". Current number of cells is ", Green_Mod);
			KEMAALEODNH().SetFloat("y", CCIENBFIKKH);
			FAIFBBGFAIB().SetVector("UpdateNewsTileStart", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 648f, 1627f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 113f)
			{
				HBJJOCHGOPH = 1489f;
			}
			DKKBFFHBHJE().SetFloat("_TimeX", HBJJOCHGOPH);
			ADGHJOHKEHG().SetFloat("Item ", Gamma);
			EHDJJANLINB().SetFloat("RecieveChatActionMessage", Colors);
			HNICHJCGJOC().SetFloat("_StretchWidth", Green_Mod);
			ADGHJOHKEHG().SetFloat("Connection failed: ", CCIENBFIKKH);
			KJMECMIGJJA().SetVector("IconImage", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1364f, 831f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			if (HBJJOCHGOPH > 1458f)
			{
				HBJJOCHGOPH = 368f;
			}
			KAFBNOBOIAJ().SetFloat(".lastCheckpoint.lives", HBJJOCHGOPH);
			EHDJJANLINB().SetFloat("menu.enableselectormusic", Gamma);
			FAIFBBGFAIB().SetFloat("Fade", Colors);
			HNICHJCGJOC().SetFloat("Drop_With_Obj", Green_Mod);
			DOHGBNPMBKG().SetFloat("_Value", CCIENBFIKKH);
			ABHDNGIHBKE().SetVector("SaveButton", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1911f, 114f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
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
			NBPKMLMCHFN.SetFloat("_Value", Gamma);
			NBPKMLMCHFN.SetFloat("_Value2", Colors);
			NBPKMLMCHFN.SetFloat("_Value3", Green_Mod);
			NBPKMLMCHFN.SetFloat("_Value4", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1167f)
			{
				HBJJOCHGOPH = 1286f;
			}
			NBPKMLMCHFN.SetFloat("y", HBJJOCHGOPH);
			BKKJJJGADLM().SetFloat("_Radius", Gamma);
			KJMECMIGJJA().SetFloat("_ScreenResolution", Colors);
			HNICHJCGJOC().SetFloat("maps.", Green_Mod);
			ABHDNGIHBKE().SetFloat("HightScoreMaxPointsText", CCIENBFIKKH);
			NDMPCDHADMJ().SetVector("Fade", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 857f, 1468f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CCLNNLCOPBL()
	{
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BEBNOKFLJPH()
	{
		SCShader = Shader.Find("EventTimeInputField");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LCJHDLKJEOM()
	{
	}

	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 740f)
			{
				HBJJOCHGOPH = 1426f;
			}
			KJMECMIGJJA().SetFloat("0.00", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat("PublishButton", Gamma);
			NJDIODJNGGA().SetFloat("z", Colors);
			DKNJGHFLAIF().SetFloat("_ScreenResolution", Green_Mod);
			CFEDGDGBCHE().SetFloat(".sav", CCIENBFIKKH);
			DOHGBNPMBKG().SetVector("_MainTex2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1995f, 883f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OMCLOFCJMPG()
	{
	}

	private void OCCGJMPAJIK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PMPKMGKAAJH()
	{
		SCShader = Shader.Find("Right Stick Click");
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

	private void LJIHHJOAJCN()
	{
	}

	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1361f)
			{
				HBJJOCHGOPH = 1637f;
			}
			MCDGIILBNIF().SetFloat("_MatrixSpeed", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat("CheckCombo", Gamma);
			ABHDNGIHBKE().SetFloat("[UI] Unknows button action: ", Colors);
			EHDJJANLINB().SetFloat("_DiffuseColor", Green_Mod);
			DKKBFFHBHJE().SetFloat("#obtained", CCIENBFIKKH);
			ADGHJOHKEHG().SetVector("[Up]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 782f, 789f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JNBPKNNBMDI()
	{
	}

	private void FMNPFCHBLJF()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FLKEJJEGCFA()
	{
		SCShader = Shader.Find("[PlayerBase] Config error: musicTime <= 0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EODOHEAKJFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KFACDBHDAOD()
	{
	}

	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 148f)
			{
				HBJJOCHGOPH = 102f;
			}
			KJMECMIGJJA().SetFloat("_Alpha", HBJJOCHGOPH);
			ADGHJOHKEHG().SetFloat("ReconnectAndRejoin() failed. It seems the client wasn't connected to a game server before (no address).", Gamma);
			NJDIODJNGGA().SetFloat("_TimeX", Colors);
			HNICHJCGJOC().SetFloat("_TimeX", Green_Mod);
			CFEDGDGBCHE().SetFloat("[LocalizationService] Loading file: ", CCIENBFIKKH);
			DKNJGHFLAIF().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1048f, 1212f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 610f)
			{
				HBJJOCHGOPH = 1123f;
			}
			KJMECMIGJJA().SetFloat("Localization Servise\nWorking commands:\nset <language>\nlist\nkeys", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("_Intensity", Gamma);
			ADGHJOHKEHG().SetFloat("_Value2", Colors);
			NBPKMLMCHFN.SetFloat("_Lift", Green_Mod);
			KJMECMIGJJA().SetFloat("/", CCIENBFIKKH);
			KEMAALEODNH().SetVector("/?player=", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1695f, 82f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FOMNCPKKCFN()
	{
	}

	private void OHFOLGANOLC()
	{
		SCShader = Shader.Find("CameraFilterPack/Pixelisation_OilPaintHQ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material KAFBNOBOIAJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-112);
		}
		return BJFKDHHMLJH;
	}

	private void HMPGIFBJFIK()
	{
		SCShader = Shader.Find("_EmissionColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material KJMECMIGJJA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-81);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material DKNJGHFLAIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-117);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HNICHJCGJOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void EHCGBJDFMHG()
	{
	}

	private void DAHFFNNIGML()
	{
		SCShader = Shader.Find("_SizeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1381f)
			{
				HBJJOCHGOPH = 528f;
			}
			CFEDGDGBCHE().SetFloat("_TimeX", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("CameraFilterPack/Noise_TV_2", Gamma);
			DKKBFFHBHJE().SetFloat("_Value10", Colors);
			ADGHJOHKEHG().SetFloat("_ScreenResolution", Green_Mod);
			DKNJGHFLAIF().SetFloat("Set Satellite Emission", CCIENBFIKKH);
			NJDIODJNGGA().SetVector("_Offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1136f, 409f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 947f)
			{
				HBJJOCHGOPH = 1044f;
			}
			FAIFBBGFAIB().SetFloat("_MainTex2", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat("_Noise", Gamma);
			KJMECMIGJJA().SetFloat("w", Colors);
			MCDGIILBNIF().SetFloat("_WorldToCameraMatrix", Green_Mod);
			DKNJGHFLAIF().SetFloat("string", CCIENBFIKKH);
			FAIFBBGFAIB().SetVector("offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 103f, 1470f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DOHGBNPMBKG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-100);
		}
		return BJFKDHHMLJH;
	}

	private void GPHPJIDGEPI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 164f)
			{
				HBJJOCHGOPH = 994f;
			}
			CFEDGDGBCHE().SetFloat("InputField", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("#yes", Gamma);
			DKNJGHFLAIF().SetFloat("[NetworkManager] Updating rooms...", Colors);
			NDMPCDHADMJ().SetFloat("SpectatingUserInfo", Green_Mod);
			DOHGBNPMBKG().SetFloat("/icon", CCIENBFIKKH);
			EPCGJFCCAFH().SetVector("menu.hardcoreinfo", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 354f, 1307f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material FAIFBBGFAIB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-94);
		}
		return BJFKDHHMLJH;
	}

	private void COGBDFKOHKK()
	{
	}

	[SpecialName]
	private Material BKKJJJGADLM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-124);
		}
		return BJFKDHHMLJH;
	}

	private void ODGMCJILIHF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}
}
