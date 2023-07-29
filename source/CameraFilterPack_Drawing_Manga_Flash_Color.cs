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
			EPCGJFCCAFH().SetFloat("player.bluebat", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat("masterSteamID", Size);
			BFGNMFCNDBC().SetFloat("_ScreenResolution", Speed);
			CEKJODEAMGB().SetFloat("Data/Editor/leveltemplate", PosX);
			KJMECMIGJJA().SetFloat(" not exist", PosY);
			IONHGBPGCHK().SetFloat("Joystick1Button6", Intensity);
			BFGNMFCNDBC().SetColor("&search=", Color);
			NDMPCDHADMJ().SetVector("EditMenu", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 21f, 1305f));
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
			IONHGBPGCHK().SetFloat("subscribeall", HBJJOCHGOPH);
			CEKJODEAMGB().SetFloat("menu.selectedplaymode", Size);
			JLHLHKPHDFO().SetFloat("EnvironmentSlider", Speed);
			NBPKMLMCHFN.SetFloat("_Value3", PosX);
			BFGNMFCNDBC().SetFloat("#yes", PosY);
			IGKFMCPDNOI().SetFloat("_HrDepthTex", Intensity);
			JLHLHKPHDFO().SetColor("_Offsets", Color);
			KJMECMIGJJA().SetVector("_VelocityTex", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 762f, 1614f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
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
		SCShader = Shader.Find("_Extra2");
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
			JLHLHKPHDFO().SetFloat("_TimeX", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("InputField", Size);
			EHDJJANLINB().SetFloat("\n", Speed);
			EHDJJANLINB().SetFloat("EditMenu", PosX);
			JLHLHKPHDFO().SetFloat(" Remote called.", PosY);
			JLHLHKPHDFO().SetFloat("</i>", Intensity);
			JLHLHKPHDFO().SetColor(" Mb", Color);
			CEKJODEAMGB().SetVector(" has no method \"", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1388f, 651f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NCNPAKFAFOE()
	{
		SCShader = Shader.Find("ComboText");
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
		SCShader = Shader.Find("CameraFilterPack/Noise_TV");
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
			IONHGBPGCHK().SetFloat("_Value5", HBJJOCHGOPH);
			FHFLKLMFHOI().SetFloat("_Value2", Size);
			IGKFMCPDNOI().SetFloat("skin.", Speed);
			NDMPCDHADMJ().SetFloat("BloodAlternative2", PosX);
			CEKJODEAMGB().SetFloat("_ScreenResolution", PosY);
			EPCGJFCCAFH().SetFloat(" SphereWaveform.cs", Intensity);
			EPCGJFCCAFH().SetColor("player.xp", Color);
			CEKJODEAMGB().SetVector("_AdaptionSpeed", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1701f, 1613f));
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
			DBOLLHHMKKN().SetFloat("yes", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("CameraFilterPack/Blend2Camera_Lighten", Size);
			DBOLLHHMKKN().SetFloat("???", Speed);
			EHDJJANLINB().SetFloat("_ScreenResolution", PosX);
			KJMECMIGJJA().SetFloat("_FadeFX", PosY);
			KJMECMIGJJA().SetFloat("_TimeX", Intensity);
			NLFJGMBCICG().SetColor("PossibleMapPointsText", Color);
			KOHGPKOFEJO().SetVector("bpmgrid", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 574f, 1756f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PAKPHKPDKGE()
	{
		SCShader = Shader.Find("_FgOverlap");
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
		SCShader = Shader.Find("Default UI Material");
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
			IGKFMCPDNOI().SetFloat(" key(s)", HBJJOCHGOPH);
			JLHLHKPHDFO().SetFloat("Joystick1Button7", Size);
			CEKJODEAMGB().SetFloat("HPText", Speed);
			EPCGJFCCAFH().SetFloat(": ", PosX);
			CEKJODEAMGB().SetFloat(".lastCheckpoint.penaltyScore", PosY);
			EPCGJFCCAFH().SetFloat("_TimeX", Intensity);
			NLFJGMBCICG().SetColor("false", Color);
			BFGNMFCNDBC().SetVector("/icon", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1617f, 877f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FLKEJJEGCFA()
	{
		SCShader = Shader.Find("_TimeX");
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
			KOHGPKOFEJO().SetFloat("_Value4", HBJJOCHGOPH);
			FHFLKLMFHOI().SetFloat("Uploader", Size);
			CEKJODEAMGB().SetFloat("_TexelOffsetScale", Speed);
			JLHLHKPHDFO().SetFloat("_Intensity", PosX);
			NDMPCDHADMJ().SetFloat("_MainTex2", PosY);
			IGKFMCPDNOI().SetFloat("Cannot remove cached RPCs on a PhotonView thats not ours! ", Intensity);
			NLFJGMBCICG().SetColor("Tab2Content", Color);
			IGKFMCPDNOI().SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 170f, 557f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
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
			IGKFMCPDNOI().SetFloat("on master", HBJJOCHGOPH);
			FHFLKLMFHOI().SetFloat("player.goldabstract", Size);
			IONHGBPGCHK().SetFloat("player.deleted", Speed);
			FHFLKLMFHOI().SetFloat("BitsData", PosX);
			FHFLKLMFHOI().SetFloat("CameraFilterPack/Atmosphere_Rain", PosY);
			FHFLKLMFHOI().SetFloat("EventSystem", Intensity);
			IGKFMCPDNOI().SetColor("Edited unlock conditions", Color);
			IONHGBPGCHK().SetVector("EventMenu", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1208f, 819f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CEKJODEAMGB());
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
			NBPKMLMCHFN.SetFloat("_Value4", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("config.txt", Size);
			CEKJODEAMGB().SetFloat("_Linecount", Speed);
			NBPKMLMCHFN.SetFloat(".", PosX);
			IGKFMCPDNOI().SetFloat(": ", PosY);
			BFGNMFCNDBC().SetFloat("_ScreenResolution", Intensity);
			KJMECMIGJJA().SetColor("Items/", Color);
			DBOLLHHMKKN().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 527f, 128f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JLHLHKPHDFO());
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
			NDMPCDHADMJ().SetFloat("ViewMenu", HBJJOCHGOPH);
			EPCGJFCCAFH().SetFloat("workshop.", Size);
			EHDJJANLINB().SetFloat("maps.", Speed);
			IGKFMCPDNOI().SetFloat("_NoiseTex", PosX);
			IGKFMCPDNOI().SetFloat("The process failed: ", PosY);
			CEKJODEAMGB().SetFloat("menu.selectedplaymode", Intensity);
			EHDJJANLINB().SetColor("_Heigh", Color);
			NLFJGMBCICG().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 355f, 1180f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KJMECMIGJJA());
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
			JLHLHKPHDFO().SetFloat(".GoalProgress", HBJJOCHGOPH);
			EHDJJANLINB().SetFloat(" not exist", Size);
			FHFLKLMFHOI().SetFloat("settings_bindings_", Speed);
			NBPKMLMCHFN.SetFloat("start", PosX);
			NLFJGMBCICG().SetFloat(" not exist", PosY);
			IGKFMCPDNOI().SetFloat("HH:mm:ss", Intensity);
			KJMECMIGJJA().SetColor("PUNCloudBestRegion", Color);
			NLFJGMBCICG().SetVector("Fade", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 170f, 1228f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NDMPCDHADMJ());
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
			KJMECMIGJJA().SetFloat("PhotonView with ID {0} wasn't properly unregistered! Please report this case to developer@photonengine.com", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("/Segment-[Right]", Size);
			NBPKMLMCHFN.SetFloat("_InternalLutParams", Speed);
			CEKJODEAMGB().SetFloat("_TimeX", PosX);
			BFGNMFCNDBC().SetFloat("GameScene", PosY);
			IGKFMCPDNOI().SetFloat("_PColor", Intensity);
			NDMPCDHADMJ().SetColor("Mar", Color);
			NBPKMLMCHFN.SetVector("Horizontal", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1762f, 1795f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
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
		SCShader = Shader.Find("CameraFilterPack/TV_Rgb");
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
			IGKFMCPDNOI().SetFloat("_Blend", HBJJOCHGOPH);
			NDMPCDHADMJ().SetFloat("[MapsData] Preloading ", Size);
			NBPKMLMCHFN.SetFloat(" cannot be used as a 3D LUT.", Speed);
			EPCGJFCCAFH().SetFloat("_SearchTex", PosX);
			NLFJGMBCICG().SetFloat("_Value7", PosY);
			DBOLLHHMKKN().SetFloat("SfxVolumeSlider", Intensity);
			NDMPCDHADMJ().SetColor("restrictions\n\n#until: ", Color);
			IONHGBPGCHK().SetVector("bool", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1687f, 783f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
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
			FHFLKLMFHOI().SetFloat("checkpoint", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat("-1", Size);
			NDMPCDHADMJ().SetFloat("_BlurredColor", Speed);
			NDMPCDHADMJ().SetFloat("_DotSize", PosX);
			EPCGJFCCAFH().SetFloat("SetScale", PosY);
			EHDJJANLINB().SetFloat("_Value", Intensity);
			BFGNMFCNDBC().SetColor("]", Color);
			EPCGJFCCAFH().SetVector("_MainTex2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1925f, 1888f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CEKJODEAMGB());
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
			BFGNMFCNDBC().SetFloat("DifficultyBG", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("_Brightness", Size);
			IONHGBPGCHK().SetFloat("mapselector.orderby", Speed);
			BFGNMFCNDBC().SetFloat("_SunThreshold", PosX);
			DBOLLHHMKKN().SetFloat("_TimeX", PosY);
			NLFJGMBCICG().SetFloat("#lives", Intensity);
			FHFLKLMFHOI().SetColor("_Blend", Color);
			NDMPCDHADMJ().SetVector("sprite", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1212f, 892f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KOHGPKOFEJO());
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
		SCShader = Shader.Find("StartCanvas");
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
			CEKJODEAMGB().SetFloat("id", HBJJOCHGOPH);
			EHDJJANLINB().SetFloat("--------------------------------", Size);
			NLFJGMBCICG().SetFloat("_Near", Speed);
			NBPKMLMCHFN.SetFloat("challenges/", PosX);
			DBOLLHHMKKN().SetFloat("_Speed", PosY);
			DBOLLHHMKKN().SetFloat("Joystick1Button10", Intensity);
			DBOLLHHMKKN().SetColor("/icon", Color);
			KOHGPKOFEJO().SetVector("GridDataStoryboard", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 391f, 1698f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FHFLKLMFHOI());
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
			IONHGBPGCHK().SetFloat("_Screen", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("_ColorBuffer", Size);
			KOHGPKOFEJO().SetFloat("JoinRoom failed. A roomname is required. If you don't know one, how will you join?", Speed);
			EHDJJANLINB().SetFloat("CameraFilterPack_AAA_BloodOnScreen1", PosX);
			NBPKMLMCHFN.SetFloat("float,0", PosY);
			JLHLHKPHDFO().SetFloat("maps.", Intensity);
			FHFLKLMFHOI().SetColor("OnPressRight", Color);
			NBPKMLMCHFN.SetVector("CameraFilterPack/Edge_Sigmoid", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 599f, 1579f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EHDJJANLINB());
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
			DBOLLHHMKKN().SetFloat("Right Stick Click", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Pixelisation_OilPaint", Size);
			NBPKMLMCHFN.SetFloat("Delete events", Speed);
			EPCGJFCCAFH().SetFloat("GlassAberration", PosX);
			EPCGJFCCAFH().SetFloat("menu.relaxinfo", PosY);
			KOHGPKOFEJO().SetFloat("hidden", Intensity);
			FHFLKLMFHOI().SetColor("<color=#{0}>{1}</color>", Color);
			KOHGPKOFEJO().SetVector(" AuthMode ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1720f, 1343f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CEKJODEAMGB());
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
			NDMPCDHADMJ().SetFloat("_Value", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat(" in-game items", Size);
			BFGNMFCNDBC().SetFloat("_BlurVector", Speed);
			IONHGBPGCHK().SetFloat(" ", PosX);
			IGKFMCPDNOI().SetFloat(", ", PosY);
			FHFLKLMFHOI().SetFloat("Ignored PU RPC, cause item is inactive. ", Intensity);
			FHFLKLMFHOI().SetColor("BadgeText", Color);
			JLHLHKPHDFO().SetVector("menu.selectedlevelid", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1421f, 714f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KJMECMIGJJA());
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
			IGKFMCPDNOI().SetFloat("settings.enableranking", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("Rotate environment object to the rotation", Size);
			DBOLLHHMKKN().SetFloat(". Our prefix is ", Speed);
			DBOLLHHMKKN().SetFloat("Scene", PosX);
			NLFJGMBCICG().SetFloat(".highscore", PosY);
			CEKJODEAMGB().SetFloat("?", Intensity);
			NLFJGMBCICG().SetColor("_TimeX", Color);
			FHFLKLMFHOI().SetVector(".lastCheckpoint.perfectHits", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1091f, 1268f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FANADGBGCPI()
	{
		SCShader = Shader.Find("#yes");
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
			IONHGBPGCHK().SetFloat("Result for ", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("ItemsCountText", Size);
			KJMECMIGJJA().SetFloat("sprite", Speed);
			EPCGJFCCAFH().SetFloat("_AdaptionSpeed", PosX);
			NBPKMLMCHFN.SetFloat("Set Player Distance", PosY);
			EHDJJANLINB().SetFloat("caret", Intensity);
			EPCGJFCCAFH().SetColor("_Value3", Color);
			KJMECMIGJJA().SetVector("OnClick", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 664f, 1184f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NDMPCDHADMJ());
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
			IGKFMCPDNOI().SetFloat("CameraFilterPack/Drawing_Paper2", HBJJOCHGOPH);
			CEKJODEAMGB().SetFloat("<color=white>PhotonView Group: ", Size);
			EPCGJFCCAFH().SetFloat("MenuScene", Speed);
			NBPKMLMCHFN.SetFloat("_Value4", PosX);
			BFGNMFCNDBC().SetFloat("CameraFilterPack/Blend2Camera_HardLight", PosY);
			KOHGPKOFEJO().SetFloat("BitsData", Intensity);
			IONHGBPGCHK().SetColor("_MainTex2", Color);
			EHDJJANLINB().SetVector("shader.future", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 583f, 1486f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
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
		SCShader = Shader.Find("StandAloneInputSystem should not be used with the GamePadInputModule, please remove it from the Event System in this scene or disable it when this module is in use");
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
			JLHLHKPHDFO().SetFloat("FreqVolume: ", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("BadgeImage", Size);
			NLFJGMBCICG().SetFloat("BadgeText", Speed);
			KOHGPKOFEJO().SetFloat("stretchWidth", PosX);
			FHFLKLMFHOI().SetFloat("Set Satellite Input", PosY);
			NBPKMLMCHFN.SetFloat("Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(", Intensity);
			IGKFMCPDNOI().SetColor("hand", Color);
			KJMECMIGJJA().SetVector("Joystick1Button8", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 932f, 1500f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CEKJODEAMGB());
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
			IONHGBPGCHK().SetFloat("The given 2D texture ", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat("_FarCamera", Size);
			IGKFMCPDNOI().SetFloat("maxScore", Speed);
			EHDJJANLINB().SetFloat("Default UI Material", PosX);
			IONHGBPGCHK().SetFloat("InfoCanvas", PosY);
			JLHLHKPHDFO().SetFloat("Value", Intensity);
			DBOLLHHMKKN().SetColor("z", Color);
			KOHGPKOFEJO().SetVector("warning: Audio Source: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1133f, 1652f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
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
		SCShader = Shader.Find("_FadeFX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
