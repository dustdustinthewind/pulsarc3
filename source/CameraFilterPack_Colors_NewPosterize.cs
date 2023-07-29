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
			EHDJJANLINB().SetFloat(" beatThreshold: ", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("maps.", Gamma);
			NDMPCDHADMJ().SetFloat("HightScoreMaxPointsText", Colors);
			KAFBNOBOIAJ().SetFloat("VoteDownToggle", Green_Mod);
			ABHDNGIHBKE().SetFloat("<color=#{0}>{1}</color>", CCIENBFIKKH);
			EPCGJFCCAFH().SetVector("SpawnObj", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1951f, 1802f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ICILLMAKLMI()
	{
		SCShader = Shader.Find("Tab1Content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CGDMLHLJIDK()
	{
		SCShader = Shader.Find("Failed to InstantiateSceneObject prefab: ");
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
		SCShader = Shader.Find("mapselector.filter.officialsortmode");
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
		SCShader = Shader.Find("Left ");
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
		SCShader = Shader.Find(".highscore");
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
		SCShader = Shader.Find("SetRotation");
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
			DOHGBNPMBKG().SetFloat("#accuracy", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat("menu.selectedlevelid", Gamma);
			HNICHJCGJOC().SetFloat("MapEnd", Colors);
			DKKBFFHBHJE().SetFloat("_ScreenResolution", Green_Mod);
			HNICHJCGJOC().SetFloat("ReconnectAndRejoin() failed. Can only connect while in state 'Disconnected'. Current state: ", CCIENBFIKKH);
			KJMECMIGJJA().SetVector("Set the end of the map. Use this if you want to cut the long music.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 508f, 1238f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KOHGPKOFEJO());
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
			DOHGBNPMBKG().SetFloat("\\[ *im.*\\](\\n\\n\\n|\\n\\n|\\n|)", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("_Value", Gamma);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", Colors);
			KOHGPKOFEJO().SetFloat("stats on", Green_Mod);
			HNICHJCGJOC().SetFloat("_Value4", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("https://steamcommunity.com/sharedfiles/filedetails/?id=", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 443f, 1367f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
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
			DKNJGHFLAIF().SetFloat(".completed", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("_Value", Gamma);
			KJMECMIGJJA().SetFloat(".lastCheckpoint.maxLongestCombo", Colors);
			EPCGJFCCAFH().SetFloat("PlayMusic", Green_Mod);
			KOHGPKOFEJO().SetFloat("System.Boolean", CCIENBFIKKH);
			KAFBNOBOIAJ().SetVector("BadgeText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1348f, 43f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KOHGPKOFEJO());
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
			HNICHJCGJOC().SetFloat("inventory.selected.", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("Environment/SunBase_", Gamma);
			NDMPCDHADMJ().SetFloat("ComboScoreText", Colors);
			ABHDNGIHBKE().SetFloat("Editor/", Green_Mod);
			KAFBNOBOIAJ().SetFloat("Rtt:{0,4} +/-{1,3}", CCIENBFIKKH);
			HNICHJCGJOC().SetVector("Checkpoint", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1743f, 334f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
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
			KOHGPKOFEJO().SetFloat("maps.", HBJJOCHGOPH);
			NJDIODJNGGA().SetFloat("OpSetPropertiesOfActor not sent. ActorNr must be > 0 and actorProperties != null.", Gamma);
			HNICHJCGJOC().SetFloat("GlassesColor", Colors);
			MCDGIILBNIF().SetFloat("#pleasewait", Green_Mod);
			ABHDNGIHBKE().SetFloat("Adreno", CCIENBFIKKH);
			KJMECMIGJJA().SetVector("Items/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1208f, 1381f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
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
			KAFBNOBOIAJ().SetFloat("_EmissionGain", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat("Could not find RPC with index: ", Gamma);
			NDMPCDHADMJ().SetFloat("[MapsData] Found ", Colors);
			EHDJJANLINB().SetFloat("colorD", Green_Mod);
			FAIFBBGFAIB().SetFloat("CameraFilterPack/Blend2Camera_Subtract", CCIENBFIKKH);
			BKKJJJGADLM().SetVector("_EdgeSize", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 647f, 180f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
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
			FAIFBBGFAIB().SetFloat("RootCanvas", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("ConnectionTimeout", Gamma);
			KJMECMIGJJA().SetFloat("FinalScoreSmallText", Colors);
			KJMECMIGJJA().SetFloat("file://", Green_Mod);
			DKKBFFHBHJE().SetFloat(".completed", CCIENBFIKKH);
			DKKBFFHBHJE().SetVector("</color>", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 634f, 686f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
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
		SCShader = Shader.Find("[LevelEditorScene] Error: I/O Failure! :(");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NNCCPEBIAKH()
	{
		SCShader = Shader.Find("Set Sun Input");
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
			CFEDGDGBCHE().SetFloat(" not exist", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("d264dbba9c2410771b4ad918903b3f4cd9e276a9", Gamma);
			BKKJJJGADLM().SetFloat("value", Colors);
			BKKJJJGADLM().SetFloat("OnPressRight", Green_Mod);
			FAIFBBGFAIB().SetFloat("x", CCIENBFIKKH);
			DKKBFFHBHJE().SetVector("Player", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 648f, 1627f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NJDIODJNGGA());
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
			KJMECMIGJJA().SetFloat("_TimeX", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("Text", Gamma);
			BKKJJJGADLM().SetFloat("RecieveChatActionMessage", Colors);
			KAFBNOBOIAJ().SetFloat("_Offsets", Green_Mod);
			NBPKMLMCHFN.SetFloat("Connection failed: ", CCIENBFIKKH);
			ADGHJOHKEHG().SetVector("ItemNameBGImage", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1364f, 831f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
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
			NDMPCDHADMJ().SetFloat(".lastCheckpoint.checkpointsUsed", HBJJOCHGOPH);
			BKKJJJGADLM().SetFloat("SfxVolumeSlider", Gamma);
			NDMPCDHADMJ().SetFloat("_ScreenResolution", Colors);
			ADGHJOHKEHG().SetFloat("Drop_With_Obj", Green_Mod);
			KAFBNOBOIAJ().SetFloat("_Value2", CCIENBFIKKH);
			ADGHJOHKEHG().SetVector("SaveButton", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1911f, 114f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NJDIODJNGGA());
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
			ABHDNGIHBKE().SetFloat("x", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat("_Intensity", Gamma);
			EHDJJANLINB().SetFloat("_TimeX", Colors);
			FAIFBBGFAIB().SetFloat("maps.", Green_Mod);
			ABHDNGIHBKE().SetFloat("HightScoreMaxPointsText", CCIENBFIKKH);
			DOHGBNPMBKG().SetVector("VisionBlur", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 857f, 1468f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
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
		SCShader = Shader.Find("Editing: ");
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
			DKNJGHFLAIF().SetFloat("<b>Max Score</b>:", HBJJOCHGOPH);
			DOHGBNPMBKG().SetFloat("/", Gamma);
			CFEDGDGBCHE().SetFloat("z", Colors);
			KJMECMIGJJA().SetFloat("_ScreenResolution", Green_Mod);
			KAFBNOBOIAJ().SetFloat(".sav", CCIENBFIKKH);
			NJDIODJNGGA().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1995f, 883f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
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
		SCShader = Shader.Find("Joystick1Button12");
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
			KOHGPKOFEJO().SetFloat("_MatrixSpeed", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("note.3", Gamma);
			ADGHJOHKEHG().SetFloat("[UI] Unknows button action: ", Colors);
			ADGHJOHKEHG().SetFloat("_DiffuseColor", Green_Mod);
			BKKJJJGADLM().SetFloat("skin.", CCIENBFIKKH);
			CFEDGDGBCHE().SetVector("SpawnObj", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 782f, 789f));
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
		SCShader = Shader.Find("#ok");
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
			KAFBNOBOIAJ().SetFloat("_Distance", HBJJOCHGOPH);
			DOHGBNPMBKG().SetFloat("ReconnectAndRejoin() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", Gamma);
			DKKBFFHBHJE().SetFloat("_Value", Colors);
			NBPKMLMCHFN.SetFloat("UseFinalGlassColor", Green_Mod);
			KOHGPKOFEJO().SetFloat("[EMPTY]", CCIENBFIKKH);
			CFEDGDGBCHE().SetVector(".", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1048f, 1212f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB());
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
			BKKJJJGADLM().SetFloat("set", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat("_TargetScale", Gamma);
			ADGHJOHKEHG().SetFloat("_Value2", Colors);
			ADGHJOHKEHG().SetFloat("_Gain", Green_Mod);
			NJDIODJNGGA().SetFloat("/../", CCIENBFIKKH);
			KEMAALEODNH().SetVector(" ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1695f, 82f));
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
		SCShader = Shader.Find("_TimeX");
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
		SCShader = Shader.Find("maps.");
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
			KAFBNOBOIAJ().SetFloat("_Value", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat("_TimeX", Gamma);
			KJMECMIGJJA().SetFloat("_Value10", Colors);
			ADGHJOHKEHG().SetFloat("CameraFilterPack/Color_RGB", Green_Mod);
			HNICHJCGJOC().SetFloat("Set Satellite Emission", CCIENBFIKKH);
			DOHGBNPMBKG().SetVector("_MainTex", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1136f, 409f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
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
			KOHGPKOFEJO().SetFloat("_MainTex2", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("Fade", Gamma);
			NJDIODJNGGA().SetFloat("x", Colors);
			HNICHJCGJOC().SetFloat("Screen Space Reflections", Green_Mod);
			ADGHJOHKEHG().SetFloat("float", CCIENBFIKKH);
			KEMAALEODNH().SetVector("offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 103f, 1470f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KJMECMIGJJA());
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
			EHDJJANLINB().SetFloat("ScrollPanel", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("EventData0DropDownList", Gamma);
			NJDIODJNGGA().SetFloat("[NetworkManager] Updating rooms...", Colors);
			KEMAALEODNH().SetFloat("AvatarImage", Green_Mod);
			MCDGIILBNIF().SetFloat("/icon", CCIENBFIKKH);
			KOHGPKOFEJO().SetVector("menu.selectedplaymode", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 354f, 1307f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
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
