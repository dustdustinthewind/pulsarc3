// CameraFilterPack_3D_Snow
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/3D/Snow")]
public class CameraFilterPack_3D_Snow : MonoBehaviour
{
	public Shader SCShader;

	public bool _Visualize;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 100f)]
	public float _FixDistance = 5f;

	[Range(-0.5f, 0.99f)]
	public float Snow_Near = 0.08f;

	[Range(0f, 1f)]
	public float Snow_Far = 0.55f;

	[Range(0f, 1f)]
	public float Fade = 1f;

	[Range(0f, 2f)]
	public float Intensity = 1f;

	[Range(0f, 2f)]
	public float Size = 1f;

	[Range(0f, 0.5f)]
	public float Speed = 0.275f;

	[Range(0f, 1f)]
	public float SnowWithoutObject = 1f;

	public Texture2D Texture2;

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

	private void CKCPPNHANAA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1783f)
			{
				HBJJOCHGOPH = 815f;
			}
			KLKILLCHJHO().SetFloat("]", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Joystick1Button0", Fade);
			MCDGIILBNIF().SetFloat("[Right]", Intensity);
			HKHBBBFLGJH().SetFloat("_Distortion", Speed * 957f);
			HKHBBBFLGJH().SetFloat("System.Boolean", Size);
			NKBIEMJBCBM().SetFloat("HiddenToggle", (!_Visualize) ? 0 : 0);
			ADAFMBOGPLN().SetFloat("CameraFilterPack/Color_YUV", _FixDistance);
			EFMCNLELMDO().SetFloat("[MapEditor] Exported to ", Snow_Near);
			FAIFBBGFAIB().SetFloat("steamid", Snow_Far);
			IGKFMCPDNOI().SetFloat("other.dust0", SnowWithoutObject);
			KLKILLCHJHO().SetVector("Texture2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1989f, 1905f));
			NKBIEMJBCBM().SetTexture("_BlurFilterDistance", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, INOBFNCKFGK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Start()
	{
	}

	private void GCHBGCGBMCK()
	{
	}

	private void CNGAJDBOCLJ()
	{
	}

	private void JKBMKPDGCHG()
	{
	}

	private void PKLOBJHKFEO()
	{
	}

	private void PAKPHKPDKGE()
	{
	}

	[SpecialName]
	private Material BAGICADFBAB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 907f)
			{
				HBJJOCHGOPH = 1210f;
			}
			LPPEPKGFOEM().SetFloat("_TimeX", HBJJOCHGOPH);
			ADBKPGFMNKO().SetFloat("CameraFilterPack/Vision_Drost", Fade);
			IOHHLNAPGMA().SetFloat("Set Arcs Speed", Intensity);
			IGKFMCPDNOI().SetFloat("_ColorLevel", Speed * 1813f);
			MCDGIILBNIF().SetFloat("Joined room ", Size);
			EFMCNLELMDO().SetFloat("SupportLogger OnApplicationPause: ", (!_Visualize) ? 1 : 1);
			BAGICADFBAB().SetFloat("x", _FixDistance);
			IGKFMCPDNOI().SetFloat("_RedAmplifier", Snow_Near);
			OCHJIMJNEMO().SetFloat("UseFinalGlassColor", Snow_Far);
			OCHJIMJNEMO().SetFloat("_TintColor", SnowWithoutObject);
			DOHGBNPMBKG().SetVector("MenuScene", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 159f, 1657f));
			KLKILLCHJHO().SetTexture("close", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, INOBFNCKFGK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material NDMPCDHADMJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 9f)
			{
				HBJJOCHGOPH = 502f;
			}
			INOBFNCKFGK().SetFloat("player.currentrank", HBJJOCHGOPH);
			ILKALHDJBFE().SetFloat("{0:0} minute{1}, ", Fade);
			OCHJIMJNEMO().SetFloat("GlassesColor", Intensity);
			IOHHLNAPGMA().SetFloat("LevelNameInputField", Speed * 24f);
			LMLENGFLEBD().SetFloat("_Near", Size);
			NDMPCDHADMJ().SetFloat("DISTORT", (!_Visualize) ? 1 : 0);
			MCDGIILBNIF().SetFloat("RarityImage", _FixDistance);
			BAGICADFBAB().SetFloat("_TimeX", Snow_Near);
			LPPEPKGFOEM().SetFloat("SetSpeed", Snow_Far);
			NBPKMLMCHFN.SetFloat("Can't change CrcCheckEnabled while being connected. CrcCheckEnabled stays ", SnowWithoutObject);
			KLKILLCHJHO().SetVector("Dec", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1974f, 1079f));
			MCDGIILBNIF().SetTexture("_Red_B", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IOHHLNAPGMA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DAHFFNNIGML()
	{
	}

	private void KKEOHFGKCIK()
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
			if (HBJJOCHGOPH > 1010f)
			{
				HBJJOCHGOPH = 213f;
			}
			NKBIEMJBCBM().SetFloat("_ChannelMixerBlue", HBJJOCHGOPH);
			NDMPCDHADMJ().SetFloat("_ScreenResolution", Fade);
			DOHGBNPMBKG().SetFloat("yes", Intensity);
			FEAEGGCNIAA().SetFloat("Editor/", Speed * 305f);
			DOHGBNPMBKG().SetFloat("_LightIntensity", Size);
			ILKALHDJBFE().SetFloat("_ScreenResolution", _Visualize ? 1 : 0);
			DOHGBNPMBKG().SetFloat("Update() was called by Unity. Scene is loaded. Let's connect to the Photon Master Server. Calling: PhotonNetwork.ConnectUsingSettings();", _FixDistance);
			LPPEPKGFOEM().SetFloat("_Bullet_9", Snow_Near);
			NKBIEMJBCBM().SetFloat("SetSpeed", Snow_Far);
			CECJJMKLEAK().SetFloat("BlockCount", SnowWithoutObject);
			HFBJAOFLCJI().SetVector("restrictions\n\n#until: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1524f, 1059f));
			INOBFNCKFGK().SetTexture("#updateoutdatedmap", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ONKDMMJPEMN()
	{
	}

	private void NKFDNIAKGEO()
	{
	}

	private void EIDKCANPHJE()
	{
	}

	private void AGEJKLMJGDO()
	{
	}

	private void PKHPNHBEKHA()
	{
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
			NBPKMLMCHFN.SetFloat("_Value", Fade);
			NBPKMLMCHFN.SetFloat("_Value2", Intensity);
			NBPKMLMCHFN.SetFloat("_Value4", Speed * 6f);
			NBPKMLMCHFN.SetFloat("_Value5", Size);
			NBPKMLMCHFN.SetFloat("_Visualize", _Visualize ? 1 : 0);
			NBPKMLMCHFN.SetFloat("_FixDistance", _FixDistance);
			NBPKMLMCHFN.SetFloat("Drop_Near", Snow_Near);
			NBPKMLMCHFN.SetFloat("Drop_Far", Snow_Far);
			NBPKMLMCHFN.SetFloat("Drop_With_Obj", SnowWithoutObject);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			NBPKMLMCHFN.SetTexture("Texture2", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material FEAEGGCNIAA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideAndDontSave | HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void IEMEHGCFAPD()
	{
	}

	private void MGMAOBPPOBJ()
	{
	}

	private void DKOPKPBLDHH()
	{
	}

	[SpecialName]
	private Material IGKFMCPDNOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-120);
		}
		return BJFKDHHMLJH;
	}

	private void ODAIMOJLJOF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HHIFMIPPMPF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return BJFKDHHMLJH;
	}

	private void BDBJEDIOKBN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 152f)
			{
				HBJJOCHGOPH = 1664f;
			}
			MCDGIILBNIF().SetFloat("[SteamManager] Connection established, authorization", HBJJOCHGOPH);
			BKKJJJGADLM().SetFloat("System.Boolean", Fade);
			DOHGBNPMBKG().SetFloat("ItemsCountText", Intensity);
			IOHHLNAPGMA().SetFloat("[PlayerBase] Loaded environment: ", Speed * 1739f);
			DOHGBNPMBKG().SetFloat("LevelProgressBar", Size);
			NFMGLIKNOOC().SetFloat("_ScreenResolution", (!_Visualize) ? 1 : 0);
			IOHHLNAPGMA().SetFloat("SetSatelliteTrailMinVertexDistance", _FixDistance);
			ADAFMBOGPLN().SetFloat("?", Snow_Near);
			INOBFNCKFGK().SetFloat("_TimeX", Snow_Far);
			DOHGBNPMBKG().SetFloat("_Val", SnowWithoutObject);
			NKBIEMJBCBM().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 321f, 36f));
			LMLENGFLEBD().SetTexture("QuickSave", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-97);
		}
		return BJFKDHHMLJH;
	}

	private void FANADGBGCPI()
	{
	}

	private void EFJDNLGNACH()
	{
	}

	private void MBLDJEFBLFL()
	{
	}

	private void JKFDDNMPOJH()
	{
	}

	private void MANDOGNJJBD()
	{
	}

	private void HMKBLLMIKAB()
	{
	}

	private void IKDNLHLBHID()
	{
	}

	private void EGEGNHLODAA()
	{
	}

	private void AOLABBMIEIM()
	{
	}

	private void JECMJNFGBGC()
	{
	}

	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1029f)
			{
				HBJJOCHGOPH = 1245f;
			}
			CECJJMKLEAK().SetFloat("[LocalizationService] Localization: ", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("string", Fade);
			ADBKPGFMNKO().SetFloat("skin.", Intensity);
			HFBJAOFLCJI().SetFloat("#close", Speed * 1279f);
			NFMGLIKNOOC().SetFloat("_Amount", Size);
			HHIAIGCAHDA().SetFloat("Y", (!_Visualize) ? 0 : 0);
			IOHHLNAPGMA().SetFloat("id", _FixDistance);
			LMLENGFLEBD().SetFloat("_Value", Snow_Near);
			KLKILLCHJHO().SetFloat("_Value2", Snow_Far);
			HHIFMIPPMPF().SetFloat(".completedMaps", SnowWithoutObject);
			HKHBBBFLGJH().SetVector("LostLive", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 772f, 1965f));
			LPPEPKGFOEM().SetTexture("CameraFilterPack/Distortion_ShockWaveManual", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1621f)
			{
				HBJJOCHGOPH = 1424f;
			}
			KLKILLCHJHO().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			FEAEGGCNIAA().SetFloat("_Blue_C", Fade);
			BKKJJJGADLM().SetFloat("_MainTex2", Intensity);
			KLKILLCHJHO().SetFloat("#score", Speed * 1565f);
			ADBKPGFMNKO().SetFloat("_ScreenResolution", Size);
			OCHJIMJNEMO().SetFloat("[Left]", (!_Visualize) ? 0 : 0);
			NFMGLIKNOOC().SetFloat("on master", _FixDistance);
			IOHHLNAPGMA().SetFloat("' found!", Snow_Near);
			NBPKMLMCHFN.SetFloat("_TimeX", Snow_Far);
			IOHHLNAPGMA().SetFloat("_Value", SnowWithoutObject);
			IGKFMCPDNOI().SetVector("_RandomTexture", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1763f, 679f));
			INOBFNCKFGK().SetTexture("[MapsSystem] Unloading maps resources...", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
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
			if (HBJJOCHGOPH > 227f)
			{
				HBJJOCHGOPH = 1425f;
			}
			NFMGLIKNOOC().SetFloat("_EmissionColor", HBJJOCHGOPH);
			DOHGBNPMBKG().SetFloat("Failed to InstantiateSceneObject prefab: ", Fade);
			ADBKPGFMNKO().SetFloat("_RampOffset", Intensity);
			ADBKPGFMNKO().SetFloat("[Left]", Speed * 1250f);
			FEAEGGCNIAA().SetFloat("_Value2", Size);
			OCHJIMJNEMO().SetFloat(" user's map(s)", _Visualize ? 1 : 0);
			EFMCNLELMDO().SetFloat("Data/Editor/leveltemplate", _FixDistance);
			BAGICADFBAB().SetFloat("Tab1Content", Snow_Near);
			FAIFBBGFAIB().SetFloat(" scene: ", Snow_Far);
			MCDGIILBNIF().SetFloat("_PColor2", SnowWithoutObject);
			LPPEPKGFOEM().SetVector("InfoButton", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1107f, 27f));
			LMLENGFLEBD().SetTexture("(master)", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LLDHEJIEDHO()
	{
	}

	private void OPKNFOGMGII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 807f)
			{
				HBJJOCHGOPH = 1876f;
			}
			HHIFMIPPMPF().SetFloat("0,7,true,0", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat(".sav", Fade);
			BAGICADFBAB().SetFloat("_PColor", Intensity);
			FEAEGGCNIAA().SetFloat("status", Speed * 1042f);
			MCDGIILBNIF().SetFloat("Set particles audio input", Size);
			OCHJIMJNEMO().SetFloat("_Alpha", (!_Visualize) ? 1 : 1);
			DOHGBNPMBKG().SetFloat("_ScreenResolution", _FixDistance);
			HKHBBBFLGJH().SetFloat("X2", Snow_Near);
			NBPKMLMCHFN.SetFloat("float,10", Snow_Far);
			ILKALHDJBFE().SetFloat("Down ", SnowWithoutObject);
			BKKJJJGADLM().SetVector("EventMenu", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 16f, 1744f));
			IOHHLNAPGMA().SetTexture("Save level before uploading?", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KLOLKEBAPFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material INOBFNCKFGK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	private void AEEGKLABFLN()
	{
	}

	private void OMIHEBMMCPG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1524f)
			{
				HBJJOCHGOPH = 157f;
			}
			BAGICADFBAB().SetFloat(" takes from: ", HBJJOCHGOPH);
			OCHJIMJNEMO().SetFloat("Scene", Fade);
			ILKALHDJBFE().SetFloat("Editor/", Intensity);
			NDMPCDHADMJ().SetFloat("_Value4", Speed * 1159f);
			NDMPCDHADMJ().SetFloat("ItemNameBGImage", Size);
			HFBJAOFLCJI().SetFloat("\" error: ", (!_Visualize) ? 0 : 0);
			IOHHLNAPGMA().SetFloat("Object ID. Case-Sensitive", _FixDistance);
			EFMCNLELMDO().SetFloat("_DiffuseColor", Snow_Near);
			LMLENGFLEBD().SetFloat("DataText", Snow_Far);
			FAIFBBGFAIB().SetFloat("[GameEvent] Exeption:", SnowWithoutObject);
			IOHHLNAPGMA().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1f, 212f));
			NKBIEMJBCBM().SetTexture("[#clicktoacceptchallenge]", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FODKODGPPDA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EKPLGFAEOBE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material ILKALHDJBFE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void AOGCKKLFGPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 570f)
			{
				HBJJOCHGOPH = 897f;
			}
			KLKILLCHJHO().SetFloat(":\n", HBJJOCHGOPH);
			OCHJIMJNEMO().SetFloat("_Fade", Fade);
			HHIFMIPPMPF().SetFloat("#timeuntilchallenge: ", Intensity);
			IGKFMCPDNOI().SetFloat("_Value2", Speed * 536f);
			HKHBBBFLGJH().SetFloat("_TimeX", Size);
			HHIAIGCAHDA().SetFloat("Join failed on GameServer. Changing back to MasterServer. Msg: ", (!_Visualize) ? 1 : 1);
			HHIFMIPPMPF().SetFloat("menu.tabid", _FixDistance);
			NDMPCDHADMJ().SetFloat("LevelConfigButton", Snow_Near);
			IOHHLNAPGMA().SetFloat("_Green_R", Snow_Far);
			BAGICADFBAB().SetFloat("_Value2", SnowWithoutObject);
			LMLENGFLEBD().SetVector(".played", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 721f, 1021f));
			LMLENGFLEBD().SetTexture("_BlurFilterDistance", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IOHHLNAPGMA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MKOMIDCPCDC()
	{
	}

	private void GJLKJAOBPJD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JABNHMIHBHC()
	{
	}

	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1060f)
			{
				HBJJOCHGOPH = 955f;
			}
			IGKFMCPDNOI().SetFloat("CameraFilterPack_Atmosphere_Rain_FX", HBJJOCHGOPH);
			BKKJJJGADLM().SetFloat("[SoundManager] Loaded skin audio", Fade);
			NBPKMLMCHFN.SetFloat("Set Satellite Radius", Intensity);
			MMOODGIODPC().SetFloat("Tab2Content", Speed * 1948f);
			ADAFMBOGPLN().SetFloat("_Value3", Size);
			ACHNOHCLGOO().SetFloat("_Red_C", _Visualize ? 1 : 0);
			LPPEPKGFOEM().SetFloat("0 - background, 1 - foreground", _FixDistance);
			ADBKPGFMNKO().SetFloat("player.xp", Snow_Near);
			OCHJIMJNEMO().SetFloat("Load scene by name or build id", Snow_Far);
			NFMGLIKNOOC().SetFloat("skin.", SnowWithoutObject);
			MMOODGIODPC().SetVector("_MainTex", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1682f, 1863f));
			NFMGLIKNOOC().SetTexture(" to: ", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NAALCEPIHCH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material BKKJJJGADLM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void ODBNMPGBCGO()
	{
	}

	private void KCDBBPKIFNJ()
	{
	}

	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1711f)
			{
				HBJJOCHGOPH = 5f;
			}
			ILKALHDJBFE().SetFloat("Fade", HBJJOCHGOPH);
			IOHHLNAPGMA().SetFloat("Fill", Fade);
			ACHNOHCLGOO().SetFloat("_MainTex2", Intensity);
			LPPEPKGFOEM().SetFloat("StartButton", Speed * 1390f);
			HFBJAOFLCJI().SetFloat("SlidingArea", Size);
			ADAFMBOGPLN().SetFloat("_EdgeSharpness", (!_Visualize) ? 1 : 1);
			KLKILLCHJHO().SetFloat("_LightIntensity", _FixDistance);
			BKKJJJGADLM().SetFloat("menutheme.idunno", Snow_Near);
			BKKJJJGADLM().SetFloat("_TimeX", Snow_Far);
			ILKALHDJBFE().SetFloat("Right", SnowWithoutObject);
			ADAFMBOGPLN().SetVector("_BlurVector", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 510f, 1867f));
			NKBIEMJBCBM().SetTexture("_Amount", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DPLLKHHLDBB()
	{
	}

	private void HJPCJGOEKMF()
	{
	}

	[SpecialName]
	private Material NFMGLIKNOOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void LLKKGGLNIDF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material NKBIEMJBCBM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-108);
		}
		return BJFKDHHMLJH;
	}

	private void JNALDALAJLG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HMPGIFBJFIK()
	{
	}

	[SpecialName]
	private Material HFBJAOFLCJI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)120;
		}
		return BJFKDHHMLJH;
	}

	private void AAEEHINDPNC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MPJCMKFFKHH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1927f)
			{
				HBJJOCHGOPH = 1608f;
			}
			OCHJIMJNEMO().SetFloat("settings_bindings_controller_type", HBJJOCHGOPH);
			MMOODGIODPC().SetFloat("_Value5", Fade);
			NFMGLIKNOOC().SetFloat("http", Intensity);
			NKBIEMJBCBM().SetFloat("_ReprojectionMatrix", Speed * 133f);
			LPPEPKGFOEM().SetFloat("SpawnObj", Size);
			FEAEGGCNIAA().SetFloat("/", (!_Visualize) ? 0 : 0);
			BKKJJJGADLM().SetFloat("_Value", _FixDistance);
			HKHBBBFLGJH().SetFloat("arc", Snow_Near);
			ADAFMBOGPLN().SetFloat("B:", Snow_Far);
			IOHHLNAPGMA().SetFloat("id", SnowWithoutObject);
			IOHHLNAPGMA().SetVector("_Distortion", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1474f, 1234f));
			EFMCNLELMDO().SetTexture("SelectorMusicToggle", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFMCNLELMDO());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)118;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material ADBKPGFMNKO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-83);
		}
		return BJFKDHHMLJH;
	}

	private void PAEGLMEOKHP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material MCDGIILBNIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void LKJMIODJGCM()
	{
	}

	private void EIMNPCMHJLJ()
	{
	}

	private void GNJDKAECPKA()
	{
	}

	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 771f)
			{
				HBJJOCHGOPH = 556f;
			}
			IGKFMCPDNOI().SetFloat("workshop.", HBJJOCHGOPH);
			ADBKPGFMNKO().SetFloat("_TimeX", Fade);
			LMLENGFLEBD().SetFloat("UI Extensions/UISoftAdditive", Intensity);
			KLKILLCHJHO().SetFloat("_ScreenResolution", Speed * 1476f);
			HFBJAOFLCJI().SetFloat("[Right]", Size);
			ACHNOHCLGOO().SetFloat("BitsData", (!_Visualize) ? 1 : 0);
			ADBKPGFMNKO().SetFloat("[SteamManager] Connecting to server", _FixDistance);
			ILKALHDJBFE().SetFloat("_Offsets", Snow_Near);
			NKBIEMJBCBM().SetFloat("VisionBlur", Snow_Far);
			IOHHLNAPGMA().SetFloat("_Bullet_12", SnowWithoutObject);
			ILKALHDJBFE().SetVector("finished", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1462f, 890f));
			DOHGBNPMBKG().SetTexture("_ScreenResolution", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IOHHLNAPGMA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CEDFFAOOPOG()
	{
	}

	[SpecialName]
	private Material LPPEPKGFOEM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-112);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material DOHGBNPMBKG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 179f)
			{
				HBJJOCHGOPH = 787f;
			}
			MCDGIILBNIF().SetFloat(".lastCheckpoint.powerupsScore", HBJJOCHGOPH);
			KLKILLCHJHO().SetFloat("isVisible", Fade);
			NBPKMLMCHFN.SetFloat("_Value", Intensity);
			HHIFMIPPMPF().SetFloat("SetParticlesParticleSize", Speed * 545f);
			MCDGIILBNIF().SetFloat("EnvironmentSlider", Size);
			ADBKPGFMNKO().SetFloat("http", _Visualize ? 1 : 0);
			NDMPCDHADMJ().SetFloat("The other scroll rect doesnt support scrolling vertically", _FixDistance);
			HHIAIGCAHDA().SetFloat("BitsData", Snow_Near);
			INOBFNCKFGK().SetFloat("Set Background Color", Snow_Far);
			ACHNOHCLGOO().SetFloat("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.", SnowWithoutObject);
			BKKJJJGADLM().SetVector("STICKLHOR", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1505f, 817f));
			DOHGBNPMBKG().SetTexture(".completed", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HPNNCNNFMGK()
	{
	}

	private void ICILLMAKLMI()
	{
	}

	private void KMEONPMCNJG()
	{
	}

	private void KDMANOEMOCA()
	{
	}

	[SpecialName]
	private Material ACHNOHCLGOO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return BJFKDHHMLJH;
	}

	private void ICDBMJKMIKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NCNPAKFAFOE()
	{
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DLMPALHKMON()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BNCLKHOEGDK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EKCDEFDELMP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IBPAMDEAGJL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material MMOODGIODPC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void MGFFNGEGFDC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LMADKINICIN()
	{
	}

	private void LIBGAKMKHJJ()
	{
	}

	private void JOHOFNKJDEB()
	{
	}

	private void DIPDEHOOBPG()
	{
	}

	[SpecialName]
	private Material HHIAIGCAHDA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void DNENFLNCIJP()
	{
	}

	private void INLDEHPAMJC()
	{
	}

	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 556f)
			{
				HBJJOCHGOPH = 472f;
			}
			BKKJJJGADLM().SetFloat("_Value2", HBJJOCHGOPH);
			IOHHLNAPGMA().SetFloat("Item creation successful! Published Item ID: ", Fade);
			IOHHLNAPGMA().SetFloat("ItemNameText", Intensity);
			HHIFMIPPMPF().SetFloat("SetSatelliteTrailWidth", Speed * 87f);
			LMLENGFLEBD().SetFloat("Can't set Room.MaxPlayers to: ", Size);
			ADAFMBOGPLN().SetFloat("#no", (!_Visualize) ? 1 : 1);
			ADAFMBOGPLN().SetFloat("OpSetPropertiesOfActor not sent. ActorNr must be > 0 and actorProperties != null.", _FixDistance);
			ILKALHDJBFE().SetFloat("_Value", Snow_Near);
			CECJJMKLEAK().SetFloat("-", Snow_Far);
			EFMCNLELMDO().SetFloat("_Distortion", SnowWithoutObject);
			NKBIEMJBCBM().SetVector("offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 721f, 193f));
			ILKALHDJBFE().SetTexture("SpawnObj", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material KLKILLCHJHO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)107;
		}
		return BJFKDHHMLJH;
	}

	private void CGBHOELMAOC()
	{
	}

	[SpecialName]
	private Material HKHBBBFLGJH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void CIHGFHNNFEE()
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

	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 243f)
			{
				HBJJOCHGOPH = 217f;
			}
			FAIFBBGFAIB().SetFloat("#obtained", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("_TimeX", Fade);
			KLKILLCHJHO().SetFloat("SetParticlesEmission", Intensity);
			ADAFMBOGPLN().SetFloat("#tryagain", Speed * 786f);
			NDMPCDHADMJ().SetFloat("mapselector.orderby", Size);
			IOHHLNAPGMA().SetFloat("_TimeX", (!_Visualize) ? 1 : 1);
			OCHJIMJNEMO().SetFloat("_Value5", _FixDistance);
			HHIFMIPPMPF().SetFloat("_ReprojectionMatrix", Snow_Near);
			HHIFMIPPMPF().SetFloat("_TileTexDebug", Snow_Far);
			OCHJIMJNEMO().SetFloat("RecordButton", SnowWithoutObject);
			IOHHLNAPGMA().SetVector("#or", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1653f, 1787f));
			NBPKMLMCHFN.SetTexture("No regions available. Are you sure your appid is valid and setup?", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPPEPKGFOEM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1235f)
			{
				HBJJOCHGOPH = 820f;
			}
			DOHGBNPMBKG().SetFloat("Lerp speed. Recomended 10", HBJJOCHGOPH);
			INOBFNCKFGK().SetFloat("_VignetteCenter", Fade);
			MCDGIILBNIF().SetFloat("???", Intensity);
			HKHBBBFLGJH().SetFloat(" in SaveLoadMenu.prefabDictionary!", Speed * 666f);
			INOBFNCKFGK().SetFloat("turn", Size);
			NFMGLIKNOOC().SetFloat("#scoresubmitionfailed: ", (!_Visualize) ? 0 : 0);
			DOHGBNPMBKG().SetFloat("CameraFilterPack/Oculus_NightVision5", _FixDistance);
			EFMCNLELMDO().SetFloat("menu.selectedplaymode", Snow_Near);
			ACHNOHCLGOO().SetFloat("ticket.ticket1", Snow_Far);
			ACHNOHCLGOO().SetFloat("Failed to 'network-remove' GameObject because it is missing a valid InstantiationId on view: ", SnowWithoutObject);
			EFMCNLELMDO().SetVector("_MainTex2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 448f, 384f));
			NKBIEMJBCBM().SetTexture("_Blue_R", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BAGICADFBAB());
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
			if (HBJJOCHGOPH > 1115f)
			{
				HBJJOCHGOPH = 1601f;
			}
			ADAFMBOGPLN().SetFloat("_DistanceParams", HBJJOCHGOPH);
			FEAEGGCNIAA().SetFloat("Editor/", Fade);
			BAGICADFBAB().SetFloat("_BlurArea", Intensity);
			BKKJJJGADLM().SetFloat("_EmissionGain", Speed * 1981f);
			FEAEGGCNIAA().SetFloat("1177138211", Size);
			MCDGIILBNIF().SetFloat("Drop_Far", _Visualize ? 1 : 0);
			LMLENGFLEBD().SetFloat("IconImage", _FixDistance);
			FEAEGGCNIAA().SetFloat("https://store.steampowered.com/itemstore/513510/", Snow_Near);
			EFMCNLELMDO().SetFloat("Can't set Room.MaxPlayers to: ", Snow_Far);
			EFMCNLELMDO().SetFloat("InventoryGrid", SnowWithoutObject);
			CECJJMKLEAK().SetVector("#pleasewait", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1335f, 1780f));
			MCDGIILBNIF().SetTexture("_ScreenResolution", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADAFMBOGPLN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void COOHIILCOCO()
	{
	}

	private void OGJJDKENBNC()
	{
	}

	private void DHLCNIINMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1066f)
			{
				HBJJOCHGOPH = 1700f;
			}
			NFMGLIKNOOC().SetFloat("_TimeX", HBJJOCHGOPH);
			LMLENGFLEBD().SetFloat("hardcoreinfo", Fade);
			INOBFNCKFGK().SetFloat("_Value7", Intensity);
			NBPKMLMCHFN.SetFloat("_Fade", Speed * 1933f);
			NKBIEMJBCBM().SetFloat("_Radius", Size);
			HFBJAOFLCJI().SetFloat("PLAY [SPACE]", (!_Visualize) ? 1 : 1);
			NFMGLIKNOOC().SetFloat("_TimeX", _FixDistance);
			ADBKPGFMNKO().SetFloat("SpeedSlider", Snow_Near);
			FEAEGGCNIAA().SetFloat("_TimeX", Snow_Far);
			NBPKMLMCHFN.SetFloat("gamemode", SnowWithoutObject);
			ADBKPGFMNKO().SetVector("GroupNameText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 419f, 1717f));
			EFMCNLELMDO().SetTexture("Circle", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
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

	private void JONGNKNLLND()
	{
	}

	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 38f)
			{
				HBJJOCHGOPH = 80f;
			}
			ILKALHDJBFE().SetFloat("Dance", HBJJOCHGOPH);
			CECJJMKLEAK().SetFloat("CameraFilterPack_AAA_Blood2", Fade);
			BKKJJJGADLM().SetFloat("Editor/", Intensity);
			NDMPCDHADMJ().SetFloat("yes", Speed * 1255f);
			NDMPCDHADMJ().SetFloat("ResetSpeed", Size);
			ACHNOHCLGOO().SetFloat("Using PhotonServerSettings.Protocol when leaving the NameServer (AuthMode is AuthOnceWss): ", _Visualize ? 1 : 0);
			INOBFNCKFGK().SetFloat("_Color_B", _FixDistance);
			INOBFNCKFGK().SetFloat("EventConfigButton", Snow_Near);
			IGKFMCPDNOI().SetFloat("Connected to gameserver.", Snow_Far);
			HKHBBBFLGJH().SetFloat("[MapsData] Found ", SnowWithoutObject);
			INOBFNCKFGK().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1874f, 903f));
			NFMGLIKNOOC().SetTexture(" Mb", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BKKJJJGADLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FAKGFMFAPDG()
	{
	}

	private void OBAEDJJDCPN()
	{
	}

	[SpecialName]
	private Material ADAFMBOGPLN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1425f)
			{
				HBJJOCHGOPH = 624f;
			}
			IGKFMCPDNOI().SetFloat("_Amount", HBJJOCHGOPH);
			ILKALHDJBFE().SetFloat("float,50", Fade);
			BKKJJJGADLM().SetFloat("ArcsNoHitsoundTimeDelaySlider", Intensity);
			INOBFNCKFGK().SetFloat("Editor/", Speed * 1912f);
			BAGICADFBAB().SetFloat("OpGetGameList not sent. LobbyType must be SqlLobby.", Size);
			IOHHLNAPGMA().SetFloat("D-Pad Right", (!_Visualize) ? 0 : 0);
			FAIFBBGFAIB().SetFloat("GameScene", _FixDistance);
			NFMGLIKNOOC().SetFloat("Sprite", Snow_Near);
			LPPEPKGFOEM().SetFloat("CameraFilterPack/Blend2Camera_ColorBurn", Snow_Far);
			BAGICADFBAB().SetFloat("SupportLogger OnDisconnectedFromPhoton().", SnowWithoutObject);
			ADAFMBOGPLN().SetVector("1177138211", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 24f, 319f));
			MMOODGIODPC().SetTexture("AddEnvironmentObject", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material IOHHLNAPGMA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-101);
		}
		return BJFKDHHMLJH;
	}

	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1102f)
			{
				HBJJOCHGOPH = 1651f;
			}
			IGKFMCPDNOI().SetFloat(" ", HBJJOCHGOPH);
			FEAEGGCNIAA().SetFloat("SetSatelliteRadius", Fade);
			IGKFMCPDNOI().SetFloat("maps.", Intensity);
			IGKFMCPDNOI().SetFloat("OneHand", Speed * 51f);
			LPPEPKGFOEM().SetFloat("_TapMedium", Size);
			IGKFMCPDNOI().SetFloat("MapEnd", (!_Visualize) ? 1 : 1);
			HKHBBBFLGJH().SetFloat("CameraFilterPack/Blend2Camera_LinearLight", _FixDistance);
			NFMGLIKNOOC().SetFloat("Save", Snow_Near);
			CECJJMKLEAK().SetFloat("CameraFilterPack/Blend2Camera_Subtract", Snow_Far);
			FEAEGGCNIAA().SetFloat("CameraFilterPack_TV_Noise3", SnowWithoutObject);
			ADAFMBOGPLN().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 593f, 524f));
			BKKJJJGADLM().SetTexture("_Value3", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 231f)
			{
				HBJJOCHGOPH = 1726f;
			}
			HKHBBBFLGJH().SetFloat("_Distortion", HBJJOCHGOPH);
			HKHBBBFLGJH().SetFloat("z", Fade);
			FEAEGGCNIAA().SetFloat("DPADVER", Intensity);
			FEAEGGCNIAA().SetFloat("_Value12", Speed * 211f);
			OCHJIMJNEMO().SetFloat("setint", Size);
			HHIAIGCAHDA().SetFloat("maps.", (!_Visualize) ? 1 : 1);
			FAIFBBGFAIB().SetFloat("_LightIntensity", _FixDistance);
			NDMPCDHADMJ().SetFloat("DisableStoryboardToggle", Snow_Near);
			HHIAIGCAHDA().SetFloat("_Noise", Snow_Far);
			ILKALHDJBFE().SetFloat("0.00:0.00", SnowWithoutObject);
			BKKJJJGADLM().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1968f, 1995f));
			DOHGBNPMBKG().SetTexture("request", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BMOFEBKGLFI()
	{
	}

	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1784f)
			{
				HBJJOCHGOPH = 1888f;
			}
			BAGICADFBAB().SetFloat("0 seconds", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("MusicFileSelector", Fade);
			NKBIEMJBCBM().SetFloat("_MainTex2", Intensity);
			CECJJMKLEAK().SetFloat("Fill Area", Speed * 1268f);
			LMLENGFLEBD().SetFloat("The observed monobehaviour (", Size);
			HHIFMIPPMPF().SetFloat("Coord", (!_Visualize) ? 1 : 1);
			DOHGBNPMBKG().SetFloat("steamid", _FixDistance);
			ACHNOHCLGOO().SetFloat("_Value6", Snow_Near);
			LPPEPKGFOEM().SetFloat("_TimeX", Snow_Far);
			ACHNOHCLGOO().SetFloat("SpawnObj", SnowWithoutObject);
			INOBFNCKFGK().SetVector("BadgeText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 612f, 1586f));
			HHIFMIPPMPF().SetTexture("AvatarImage", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FEKECCBFGMI()
	{
	}

	private void PHJJHFBLICM()
	{
	}

	[SpecialName]
	private Material CECJJMKLEAK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.HideInInspector | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void FIKFJDFELIP()
	{
	}

	private void JBCNIPJDPJB()
	{
	}

	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 629f)
			{
				HBJJOCHGOPH = 451f;
			}
			INOBFNCKFGK().SetFloat("_Value4", HBJJOCHGOPH);
			ILKALHDJBFE().SetFloat("</color>", Fade);
			IGKFMCPDNOI().SetFloat("<color=#", Intensity);
			BAGICADFBAB().SetFloat("ShowTitle", Speed * 35f);
			HHIAIGCAHDA().SetFloat("_Value1", Size);
			HFBJAOFLCJI().SetFloat("_TimeX", (!_Visualize) ? 0 : 0);
			NKBIEMJBCBM().SetFloat("{0}", _FixDistance);
			HKHBBBFLGJH().SetFloat("Joystick1Button7", Snow_Near);
			FEAEGGCNIAA().SetFloat("CurrentTimeLabel", Snow_Far);
			BKKJJJGADLM().SetFloat("ok", SnowWithoutObject);
			NDMPCDHADMJ().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 480f, 70f));
			DOHGBNPMBKG().SetTexture("SetSpeed", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LBAJLLFMMMP()
	{
	}

	private void BKIGIIINEDH()
	{
	}

	private void CFIAKIJAILI()
	{
	}

	private void CKECPMDEBLL()
	{
	}

	private void MCKCCPLJIFE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material LMLENGFLEBD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)70;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material EFMCNLELMDO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-117);
		}
		return BJFKDHHMLJH;
	}

	private void GGPDKCHEBAG()
	{
	}
}
