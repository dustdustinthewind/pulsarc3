// CameraFilterPack_Drawing_Manga_Flash_Color
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Drawing/Manga_Flash_Color")]
[ExecuteInEditMode]
public class CameraFilterPack_Drawing_Manga_Flash_Color : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(1f, 10f)]
	public float Size = 1f;

	public Color Color = new Color(0f, 0.7f, 1f, 1f);

	[Range(0f, 30f)]
	public int Speed = 5;

	[Range(0f, 1f)]
	public float PosX = 0.5f;

	[Range(0f, 1f)]
	public float PosY = 0.5f;

	[Range(0f, 1f)]
	public float Intensity = 1f;

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
	private Material JLHLHKPHDFO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)78;
		}
		return BJFKDHHMLJH;
	}

	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1140f)
			{
				HBJJOCHGOPH = 1204f;
			}
			EHDJJANLINB().SetFloat("player.bat", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("roomDescription", Size);
			CEKJODEAMGB().SetFloat("_ScreenResolution", Speed);
			EHDJJANLINB().SetFloat("Editor/", PosX);
			JLHLHKPHDFO().SetFloat(": ", PosY);
			EPCGJFCCAFH().SetFloat("R1", Intensity);
			NBPKMLMCHFN.SetColor("&search=", Color);
			IGKFMCPDNOI().SetVector("ViewMenu", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 21f, 1305f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MGMAOBPPOBJ()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EAHCLIEEJOG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material FHFLKLMFHOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.HideAndDontSave;
		}
		return BJFKDHHMLJH;
	}

	private void EGEPLFGKGLI()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material EPCGJFCCAFH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void LCJHDLKJEOM()
	{
	}

	private void KKLMPKLKAEM()
	{
	}

	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1971f)
			{
				HBJJOCHGOPH = 1293f;
			}
			NBPKMLMCHFN.SetFloat("#FFDA44CC", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("menu.selectedplaymode", Size);
			FHFLKLMFHOI().SetFloat("HiddenToggle", Speed);
			NDMPCDHADMJ().SetFloat("_Value2", PosX);
			CEKJODEAMGB().SetFloat("#close", PosY);
			DBOLLHHMKKN().SetFloat("offsets", Intensity);
			NDMPCDHADMJ().SetColor("_SecondTex", Color);
			CEKJODEAMGB().SetVector("_MaxBlurRadius", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 762f, 1614f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CEKJODEAMGB());
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

	private void IMCKJCHKMKB()
	{
		SCShader = Shader.Find("_Extra");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void DHENLPJJOEN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FDMAEPOHDMK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1208f)
			{
				HBJJOCHGOPH = 196f;
			}
			KJMECMIGJJA().SetFloat("_TimeX", HBJJOCHGOPH);
			EHDJJANLINB().SetFloat(" ", Size);
			EHDJJANLINB().SetFloat("The region arrays from Name Server are not ok. Must be non-null and same length. ", Speed);
			EPCGJFCCAFH().SetFloat("ViewMenu", PosX);
			JLHLHKPHDFO().SetFloat("\" for viewID ", PosY);
			NLFJGMBCICG().SetFloat("</i>", Intensity);
			KOHGPKOFEJO().SetColor(" Kb", Color);
			IGKFMCPDNOI().SetVector("null", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1388f, 651f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NCNPAKFAFOE()
	{
		SCShader = Shader.Find("HPText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MMOKKAPFGAK()
	{
		SCShader = Shader.Find("Case-Sensitive");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KOJKBFDNGDK()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 897f)
			{
				HBJJOCHGOPH = 1129f;
			}
			BFGNMFCNDBC().SetFloat("_Value4", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat("_Value", Size);
			KJMECMIGJJA().SetFloat("end", Speed);
			EPCGJFCCAFH().SetFloat("BloodAlternative1", PosX);
			EPCGJFCCAFH().SetFloat("_Value2", PosY);
			IONHGBPGCHK().SetFloat(" SphereWaveform.cs", Intensity);
			EHDJJANLINB().SetColor("Current xp: ", Color);
			CEKJODEAMGB().SetVector("_ExposureAdjustment", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1701f, 1613f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
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
			NBPKMLMCHFN.SetFloat("_Value", Size);
			NBPKMLMCHFN.SetFloat("_Value2", Speed);
			NBPKMLMCHFN.SetFloat("_Value3", PosX);
			NBPKMLMCHFN.SetFloat("_Value4", PosY);
			NBPKMLMCHFN.SetFloat("_Intensity", Intensity);
			NBPKMLMCHFN.SetColor("Color", Color);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 594f)
			{
				HBJJOCHGOPH = 12f;
			}
			NDMPCDHADMJ().SetFloat("OpenButton", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("CameraFilterPack/Blend2Camera_Lighten", Size);
			FHFLKLMFHOI().SetFloat(" item(s) in inventory", Speed);
			NLFJGMBCICG().SetFloat("_ScreenResolution", PosX);
			NBPKMLMCHFN.SetFloat("_Blue_C", PosY);
			IGKFMCPDNOI().SetFloat("CameraFilterPack/Colors_RgbClamp", Intensity);
			NLFJGMBCICG().SetColor("PossibleMapPointsText", Color);
			NLFJGMBCICG().SetVector("EventData0DropDownList", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 574f, 1756f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PAKPHKPDKGE()
	{
		SCShader = Shader.Find("_Screen");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IHHNCCOGLPN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KMKLDAJLCNM()
	{
	}

	private void IDJKNBDKHBD()
	{
		SCShader = Shader.Find("UI Extensions/UIMultiply");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BLKGOMCPEKI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LJIHHJOAJCN()
	{
	}

	private void LIEGJOHINGC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BGDONBMDPGM()
	{
	}

	private void FODKODGPPDA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LMBDNPLDGIJ()
	{
	}

	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 12f)
			{
				HBJJOCHGOPH = 1537f;
			}
			IGKFMCPDNOI().SetFloat("[LocalizationService] All languages: ", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("LT", Size);
			EPCGJFCCAFH().SetFloat("HPText", Speed);
			JLHLHKPHDFO().SetFloat(": ", PosX);
			EHDJJANLINB().SetFloat(".lastCheckpoint.incorrectScore", PosY);
			BFGNMFCNDBC().SetFloat("CameraFilterPack/FX_8bits_gb", Intensity);
			IGKFMCPDNOI().SetColor("f", Color);
			NBPKMLMCHFN.SetVector("/icon", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1617f, 877f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FLKEJJEGCFA()
	{
		SCShader = Shader.Find("CameraFilterPack/3D_Anomaly");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1700f)
			{
				HBJJOCHGOPH = 631f;
			}
			FHFLKLMFHOI().SetFloat("_Value3", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat(".workshop.json", Size);
			KJMECMIGJJA().SetFloat("_NoiseScale", Speed);
			NLFJGMBCICG().SetFloat("offsets", PosX);
			FHFLKLMFHOI().SetFloat("_MainTex2", PosY);
			EPCGJFCCAFH().SetFloat("PhotonView ID duplicate found: {0}. New: {1} old: {2}. Maybe one wasn't destroyed on scene load?! Check for 'DontDestroyOnLoad'. Destroying old entry, adding new.", Intensity);
			EPCGJFCCAFH().SetColor("MaxLivesSlider", Color);
			KJMECMIGJJA().SetVector("#pleasewait", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 170f, 557f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EDBEHEKMGFH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1277f)
			{
				HBJJOCHGOPH = 278f;
			}
			IGKFMCPDNOI().SetFloat("offline", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("player.goldabstract", Size);
			JLHLHKPHDFO().SetFloat("player.linea", Speed);
			BFGNMFCNDBC().SetFloat("BitsData", PosX);
			DBOLLHHMKKN().SetFloat("CameraFilterPack/Atmosphere_Rain", PosY);
			JLHLHKPHDFO().SetFloat("Horizontal", Intensity);
			KOHGPKOFEJO().SetColor("OK", Color);
			BFGNMFCNDBC().SetVector("EventMenu", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1208f, 819f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1089f)
			{
				HBJJOCHGOPH = 332f;
			}
			FHFLKLMFHOI().SetFloat("_Value3", HBJJOCHGOPH);
			NDMPCDHADMJ().SetFloat(".status", Size);
			IGKFMCPDNOI().SetFloat("_Vignette", Speed);
			NLFJGMBCICG().SetFloat("GO==null", PosX);
			KOHGPKOFEJO().SetFloat(" not exist", PosY);
			NDMPCDHADMJ().SetFloat("Speed", Intensity);
			EHDJJANLINB().SetColor("No Description", Color);
			KJMECMIGJJA().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 527f, 128f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CEKJODEAMGB());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)76;
		}
		return BJFKDHHMLJH;
	}

	private void GNMGIHFKJIJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ONKDMMJPEMN()
	{
	}

	[SpecialName]
	private Material KJMECMIGJJA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1797f)
			{
				HBJJOCHGOPH = 1390f;
			}
			IGKFMCPDNOI().SetFloat("GenerationMenu", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("workshop.", Size);
			KOHGPKOFEJO().SetFloat("maps.", Speed);
			NLFJGMBCICG().SetFloat("_MidGrey", PosX);
			IGKFMCPDNOI().SetFloat(" does not exist!", PosY);
			CEKJODEAMGB().SetFloat("menu.selectedplaymode", Intensity);
			IONHGBPGCHK().SetColor("_Heigh", Color);
			NLFJGMBCICG().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 355f, 1180f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Drawing_Manga_Flash_Color");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 831f)
			{
				HBJJOCHGOPH = 1901f;
			}
			NBPKMLMCHFN.SetFloat(".icon", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat(": ", Size);
			NBPKMLMCHFN.SetFloat("settings_bindings_", Speed);
			JLHLHKPHDFO().SetFloat("start", PosX);
			IONHGBPGCHK().SetFloat(": ", PosY);
			BFGNMFCNDBC().SetFloat("\n", Intensity);
			KOHGPKOFEJO().SetColor("{0}={2}: {1} \"{3}\"", Color);
			NLFJGMBCICG().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 170f, 1228f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GHILDCBCDJI()
	{
	}

	[SpecialName]
	private Material IGKFMCPDNOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-113);
		}
		return BJFKDHHMLJH;
	}

	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 760f)
			{
				HBJJOCHGOPH = 439f;
			}
			BFGNMFCNDBC().SetFloat(". The group number should be at least 1.", HBJJOCHGOPH);
			JLHLHKPHDFO().SetFloat("Items/", Size);
			JLHLHKPHDFO().SetFloat("ENABLE_DITHERING", Speed);
			NDMPCDHADMJ().SetFloat("CameraFilterPack/Glasses_On", PosX);
			KOHGPKOFEJO().SetFloat("GameScene", PosY);
			EHDJJANLINB().SetFloat("_TimeX", Intensity);
			KOHGPKOFEJO().SetColor("Jan", Color);
			FHFLKLMFHOI().SetVector("#rt", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1762f, 1795f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CEKJODEAMGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JNGMIAFLBDL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MKIMDFLBFOM()
	{
		SCShader = Shader.Find("_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BKGJOECFMID()
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
			if (HBJJOCHGOPH > 1182f)
			{
				HBJJOCHGOPH = 458f;
			}
			DBOLLHHMKKN().SetFloat("_LutTex", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat("/", Size);
			DBOLLHHMKKN().SetFloat("The given 2D texture ", Speed);
			IONHGBPGCHK().SetFloat("SearchTex", PosX);
			NDMPCDHADMJ().SetFloat("_Value7", PosY);
			NBPKMLMCHFN.SetFloat("SfxVolumeSlider", Intensity);
			NBPKMLMCHFN.SetColor("\n\n#", Color);
			FHFLKLMFHOI().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1687f, 783f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NDMPCDHADMJ());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-103);
		}
		return BJFKDHHMLJH;
	}

	private void FOLDLDLFFLM()
	{
	}

	private void NAALCEPIHCH()
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-106);
		}
		return BJFKDHHMLJH;
	}

	private void GAOOPEEBGJA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1887f)
			{
				HBJJOCHGOPH = 1540f;
			}
			JLHLHKPHDFO().SetFloat("checkpoint", HBJJOCHGOPH);
			FHFLKLMFHOI().SetFloat("Right", Size);
			NDMPCDHADMJ().SetFloat("_Offsets", Speed);
			IONHGBPGCHK().SetFloat("_TimeX", PosX);
			NDMPCDHADMJ().SetFloat("RemoveEnvironmentObject", PosY);
			NLFJGMBCICG().SetFloat("_TimeX", Intensity);
			EHDJJANLINB().SetColor(" [", Color);
			EPCGJFCCAFH().SetVector("_MainTex2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1925f, 1888f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1521f)
			{
				HBJJOCHGOPH = 956f;
			}
			IONHGBPGCHK().SetFloat("maps.", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("_Brightness", Size);
			EPCGJFCCAFH().SetFloat("mapselector.orderby", Speed);
			EHDJJANLINB().SetFloat("_BlurRadius4", PosX);
			JLHLHKPHDFO().SetFloat("CameraFilterPack/Colors_Threshold", PosY);
			NBPKMLMCHFN.SetFloat("#lives", Intensity);
			KJMECMIGJJA().SetColor("_LutTex", Color);
			DBOLLHHMKKN().SetVector("[PlayerBase] MapEnd error: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1212f, 892f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
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

	private void OKLAJINHPAN()
	{
		SCShader = Shader.Find("LoadMapCanvas");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1855f)
			{
				HBJJOCHGOPH = 650f;
			}
			IGKFMCPDNOI().SetFloat("Set Sun Input", HBJJOCHGOPH);
			EHDJJANLINB().SetFloat("0.00", Size);
			BFGNMFCNDBC().SetFloat("_Near", Speed);
			FHFLKLMFHOI().SetFloat("#getrewardnow ", PosX);
			FHFLKLMFHOI().SetFloat("_TimeX", PosY);
			EHDJJANLINB().SetFloat("Joystick1Button9", Intensity);
			KJMECMIGJJA().SetColor("/icon", Color);
			NLFJGMBCICG().SetVector("GridDataStoryboard", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 391f, 1698f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AMHEJBMLFNM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IKIDIJLIGOH()
	{
	}

	private void GPFJMKCGHGB()
	{
	}

	private void DHNGNHGDPLM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KMEONPMCNJG()
	{
	}

	[SpecialName]
	private Material NDMPCDHADMJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)67;
		}
		return BJFKDHHMLJH;
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1590f)
			{
				HBJJOCHGOPH = 98f;
			}
			EHDJJANLINB().SetFloat("pointBuffer", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat("threshold", Size);
			KOHGPKOFEJO().SetFloat("CreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", Speed);
			IGKFMCPDNOI().SetFloat("CameraFilterPack_AAA_BloodOnScreen1", PosX);
			CEKJODEAMGB().SetFloat("float,0", PosY);
			NLFJGMBCICG().SetFloat(".played", Intensity);
			KOHGPKOFEJO().SetColor(". Current number of cells is ", Color);
			IONHGBPGCHK().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 599f, 1579f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PKGJJFIFLII()
	{
	}

	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1025f)
			{
				HBJJOCHGOPH = 615f;
			}
			CEKJODEAMGB().SetFloat("Joystick1Button11", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("_ScreenResolution", Size);
			NLFJGMBCICG().SetFloat("[Right]", Speed);
			DBOLLHHMKKN().SetFloat("GlassDistortion", PosX);
			NDMPCDHADMJ().SetFloat("menu.selectedplaymode", PosY);
			NBPKMLMCHFN.SetFloat("Room: '{0}' {1},{2} {4}/{3} players.", Intensity);
			FHFLKLMFHOI().SetColor("Game Version: ", Color);
			DBOLLHHMKKN().SetVector("Skipping EstablishEncryption. Protocol is secure.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1720f, 1343f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ODAIMOJLJOF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EODOHEAKJFO()
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void HLDFOJMHKNL()
	{
	}

	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 742f)
			{
				HBJJOCHGOPH = 1446f;
			}
			EPCGJFCCAFH().SetFloat("_TimeX", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("steamid", Size);
			NBPKMLMCHFN.SetFloat("_BlurVector", Speed);
			KJMECMIGJJA().SetFloat("menu.selectedplaymode", PosX);
			DBOLLHHMKKN().SetFloat("Received RPC: ", PosY);
			NDMPCDHADMJ().SetFloat("PunPickup", Intensity);
			DBOLLHHMKKN().SetColor("NEW", Color);
			BFGNMFCNDBC().SetVector("offline", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1421f, 714f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IIFCIDDJHPM()
	{
	}

	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1644f)
			{
				HBJJOCHGOPH = 1492f;
			}
			KJMECMIGJJA().SetFloat("CompletedLevel", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("Rotate environment object to the rotation", Size);
			KOHGPKOFEJO().SetFloat("Received OnSerialization for view ID ", Speed);
			NDMPCDHADMJ().SetFloat("MenuVolumeSlider", PosX);
			JLHLHKPHDFO().SetFloat("Crosshair2", PosY);
			IONHGBPGCHK().SetFloat("skin.", Intensity);
			IGKFMCPDNOI().SetColor("CameraFilterPack/Noise_TV_3", Color);
			BFGNMFCNDBC().SetVector(".lastCheckpoint.powerupsScore", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1091f, 1268f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FANADGBGCPI()
	{
		SCShader = Shader.Find("ConfigVersionSlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OHFOLGANOLC()
	{
		SCShader = Shader.Find("LoadingStatusText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void POJFHDFJOPE()
	{
	}

	private void ICDBMJKMIKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1504f)
			{
				HBJJOCHGOPH = 956f;
			}
			NLFJGMBCICG().SetFloat("Bad parameters for getstring! Use <key> <value>", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat("ItemsCountText", Size);
			JLHLHKPHDFO().SetFloat("1", Speed);
			NDMPCDHADMJ().SetFloat("_ExposureAdjustment", PosX);
			DBOLLHHMKKN().SetFloat("Set Player Distance", PosY);
			NDMPCDHADMJ().SetFloat("grid", Intensity);
			IGKFMCPDNOI().SetColor("_Value2", Color);
			DBOLLHHMKKN().SetVector(".", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 664f, 1184f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CEKJODEAMGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CFFCLAHMBAA()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KKEOHFGKCIK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 750f)
			{
				HBJJOCHGOPH = 1225f;
			}
			JLHLHKPHDFO().SetFloat("CameraFilterPack/Drawing_Paper2", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat(" | ", Size);
			CEKJODEAMGB().SetFloat("MenuScene", Speed);
			IONHGBPGCHK().SetFloat("_Value2", PosX);
			NBPKMLMCHFN.SetFloat("_Value7", PosY);
			DBOLLHHMKKN().SetFloat("Deleted event", Intensity);
			EPCGJFCCAFH().SetColor("CameraFilterPack/Blend2Camera_GreenScreen", Color);
			IONHGBPGCHK().SetVector("shader.invert", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 583f, 1486f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	private void BGFJOEPFOPM()
	{
	}

	private void JOPCCCCHNLI()
	{
		SCShader = Shader.Find("Submit");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 151f)
			{
				HBJJOCHGOPH = 1915f;
			}
			BFGNMFCNDBC().SetFloat("FreqVolume: ", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("LeaderboardsButton", Size);
			JLHLHKPHDFO().SetFloat("NEW", Speed);
			DBOLLHHMKKN().SetFloat("tintColor", PosX);
			BFGNMFCNDBC().SetFloat("Set Satellite Input", PosY);
			CEKJODEAMGB().SetFloat("Error: You're not logged into Steam!", Intensity);
			JLHLHKPHDFO().SetColor("hand", Color);
			IONHGBPGCHK().SetVector("RT", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 932f, 1500f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material CEKJODEAMGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 222f)
			{
				HBJJOCHGOPH = 1399f;
			}
			FHFLKLMFHOI().SetFloat("_Extra2", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat("_FarCamera", Size);
			DBOLLHHMKKN().SetFloat("difficulty", Speed);
			JLHLHKPHDFO().SetFloat("UI Extensions/UIScreen", PosX);
			KJMECMIGJJA().SetFloat("InfoText", PosY);
			IONHGBPGCHK().SetFloat("ScreenResolutionPanel", Intensity);
			NLFJGMBCICG().SetColor("z", Color);
			NDMPCDHADMJ().SetVector("warning: Audio Source: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1133f, 1652f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OIBMHPIFAKK()
	{
	}

	[SpecialName]
	private Material NLFJGMBCICG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-1);
		}
		return BJFKDHHMLJH;
	}

	private void FDNONDCGGCG()
	{
		SCShader = Shader.Find("_Blue_C");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
