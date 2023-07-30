// CameraFilterPack_3D_Snow
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/3D/Snow")]
[ExecuteInEditMode]
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
			IGKFMCPDNOI().SetFloat("]", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("Joystick1Button12", Fade);
			CECJJMKLEAK().SetFloat("Changed config", Intensity);
			ADBKPGFMNKO().SetFloat("_Distortion", Speed * 957f);
			LMLENGFLEBD().SetFloat("System.Int32", Size);
			HFBJAOFLCJI().SetFloat("Tab2Content", (!_Visualize) ? 0 : 0);
			LMLENGFLEBD().SetFloat("CameraFilterPack/Color_YUV", _FixDistance);
			MCDGIILBNIF().SetFloat("#ok", Snow_Near);
			HFBJAOFLCJI().SetFloat("ticket", Snow_Far);
			NBPKMLMCHFN.SetFloat("shader.pixel", SnowWithoutObject);
			NDMPCDHADMJ().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1989f, 1905f));
			ILKALHDJBFE().SetTexture("_Radius2", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
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
			NKBIEMJBCBM().SetFloat("_ScreenResolution", Fade);
			OCHJIMJNEMO().SetFloat("SetSpeed", Intensity);
			BKKJJJGADLM().SetFloat("_EdgeSize", Speed * 1813f);
			IGKFMCPDNOI().SetFloat("Joined room ", Size);
			MMOODGIODPC().SetFloat("PunSupportLogger", (!_Visualize) ? 1 : 1);
			IOHHLNAPGMA().SetFloat(": ", _FixDistance);
			MMOODGIODPC().SetFloat("_TimeX", Snow_Near);
			MMOODGIODPC().SetFloat("_TimeX", Snow_Far);
			KLKILLCHJHO().SetFloat("_EmissionColor", SnowWithoutObject);
			DOHGBNPMBKG().SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 159f, 1657f));
			LPPEPKGFOEM().SetTexture(" ", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFMCNLELMDO());
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
			IGKFMCPDNOI().SetFloat("settings.enablerankingnotifications", HBJJOCHGOPH);
			FEAEGGCNIAA().SetFloat("{0:0} minute{1}, ", Fade);
			HHIFMIPPMPF().SetFloat("GlassAberration", Intensity);
			FEAEGGCNIAA().SetFloat("Tab1Content", Speed * 24f);
			ILKALHDJBFE().SetFloat("_TimeX", Size);
			KLKILLCHJHO().SetFloat("_VignetteBlur", (!_Visualize) ? 1 : 0);
			ADBKPGFMNKO().SetFloat("ItemNameBGImage", _FixDistance);
			NDMPCDHADMJ().SetFloat("_TimeX", Snow_Near);
			INOBFNCKFGK().SetFloat("Spawn ark to be pressed at this time", Snow_Far);
			LMLENGFLEBD().SetFloat("Setting autoCleanUpPlayerObjects while in a room is not supported.", SnowWithoutObject);
			MCDGIILBNIF().SetVector("Oct", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1974f, 1079f));
			LMLENGFLEBD().SetTexture("_Red_G", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADAFMBOGPLN());
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
			FAIFBBGFAIB().SetFloat("_ChannelMixerRed", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat("_Value2", Fade);
			NDMPCDHADMJ().SetFloat("menu.resetlevelcheckpoint", Intensity);
			HHIAIGCAHDA().SetFloat("Please wait..", Speed * 305f);
			BAGICADFBAB().SetFloat("_Far", Size);
			ACHNOHCLGOO().SetFloat("_FarCamera", _Visualize ? 1 : 0);
			HFBJAOFLCJI().SetFloat("master", _FixDistance);
			MMOODGIODPC().SetFloat("_Bullet_8", Snow_Near);
			HKHBBBFLGJH().SetFloat("/", Snow_Far);
			MMOODGIODPC().SetFloat(" GameServer:", SnowWithoutObject);
			FAIFBBGFAIB().SetVector("#forever", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1524f, 1059f));
			LMLENGFLEBD().SetTexture("Tab1Content", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OCHJIMJNEMO());
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
			HFBJAOFLCJI().SetFloat("[SteamManager] Connecting to server", HBJJOCHGOPH);
			HKHBBBFLGJH().SetFloat("System.Int32", Fade);
			NDMPCDHADMJ().SetFloat("InfoCanvas", Intensity);
			NFMGLIKNOOC().SetFloat("custom", Speed * 1739f);
			HKHBBBFLGJH().SetFloat(":", Size);
			HHIFMIPPMPF().SetFloat("_Distortion", (!_Visualize) ? 1 : 0);
			HKHBBBFLGJH().SetFloat("SetSatelliteLerpSpeed", _FixDistance);
			LPPEPKGFOEM().SetFloat("/?player=", Snow_Near);
			KLKILLCHJHO().SetFloat("_TimeX", Snow_Far);
			BAGICADFBAB().SetFloat("_Val", SnowWithoutObject);
			NDMPCDHADMJ().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 321f, 36f));
			DOHGBNPMBKG().SetTexture("Exit to Windows", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
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
			NDMPCDHADMJ().SetFloat("english", HBJJOCHGOPH);
			ADAFMBOGPLN().SetFloat("bool", Fade);
			NBPKMLMCHFN.SetFloat("local CheckCondition = function()", Intensity);
			MMOODGIODPC().SetFloat("ok", Speed * 1279f);
			MMOODGIODPC().SetFloat("_Amount", Size);
			IOHHLNAPGMA().SetFloat("Joystick1Button3", (!_Visualize) ? 0 : 0);
			HFBJAOFLCJI().SetFloat("id", _FixDistance);
			OCHJIMJNEMO().SetFloat("_TimeX", Snow_Near);
			HHIFMIPPMPF().SetFloat("_Value", Snow_Far);
			ADAFMBOGPLN().SetFloat(".GoalProgress", SnowWithoutObject);
			HHIAIGCAHDA().SetVector("]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 772f, 1965f));
			CECJJMKLEAK().SetTexture("_ScreenResolution", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BAGICADFBAB());
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
			NBPKMLMCHFN.SetFloat("_ScreenResolution", HBJJOCHGOPH);
			KLKILLCHJHO().SetFloat("_Green_C", Fade);
			FEAEGGCNIAA().SetFloat("CameraFilterPack/Blend2Camera_ColorDodge", Intensity);
			HHIAIGCAHDA().SetFloat("#score", Speed * 1565f);
			IOHHLNAPGMA().SetFloat("Fade", Size);
			BKKJJJGADLM().SetFloat("[Right]", (!_Visualize) ? 0 : 0);
			MCDGIILBNIF().SetFloat("offline", _FixDistance);
			DOHGBNPMBKG().SetFloat("[Singleton] An instance of '", Snow_Near);
			MCDGIILBNIF().SetFloat("_TimeX", Snow_Far);
			HHIAIGCAHDA().SetFloat("_TimeX", SnowWithoutObject);
			NKBIEMJBCBM().SetVector("_Axis", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1763f, 679f));
			IGKFMCPDNOI().SetTexture("workshop.", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFMCNLELMDO());
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
			ADBKPGFMNKO().SetFloat("_DiffuseColor", HBJJOCHGOPH);
			KLKILLCHJHO().SetFloat("Failed to InstantiateSceneObject prefab: ", Fade);
			IOHHLNAPGMA().SetFloat("_MainTex", Intensity);
			HHIFMIPPMPF().SetFloat("SpawnObj", Speed * 1250f);
			LMLENGFLEBD().SetFloat("_Value2", Size);
			DOHGBNPMBKG().SetFloat("/", _Visualize ? 1 : 0);
			DOHGBNPMBKG().SetFloat("Editor/", _FixDistance);
			DOHGBNPMBKG().SetFloat("LevelNameInputField", Snow_Near);
			CECJJMKLEAK().SetFloat("PhotonView ID duplicate found: {0}. New: {1} old: {2}. Maybe one wasn't destroyed on scene load?! Check for 'DontDestroyOnLoad'. Destroying old entry, adding new.", Snow_Far);
			FAIFBBGFAIB().SetFloat("_Value7", SnowWithoutObject);
			FEAEGGCNIAA().SetVector("InfoButton", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1107f, 27f));
			DOHGBNPMBKG().SetTexture(" (inactive)", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KLKILLCHJHO());
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
			NBPKMLMCHFN.SetFloat("0,7,true,0", HBJJOCHGOPH);
			FEAEGGCNIAA().SetFloat(".sav", Fade);
			KLKILLCHJHO().SetFloat("_TimeX", Intensity);
			CECJJMKLEAK().SetFloat("#yes", Speed * 1042f);
			FEAEGGCNIAA().SetFloat("Set particles audio input", Size);
			BKKJJJGADLM().SetFloat("_CenterY", (!_Visualize) ? 1 : 1);
			NDMPCDHADMJ().SetFloat("_ScreenResolution", _FixDistance);
			NBPKMLMCHFN.SetFloat("X2", Snow_Near);
			IGKFMCPDNOI().SetFloat("Lerp speed. Recomended 10", Snow_Far);
			NKBIEMJBCBM().SetFloat("Down", SnowWithoutObject);
			FEAEGGCNIAA().SetVector("EditMenu", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 16f, 1744f));
			NBPKMLMCHFN.SetTexture("/", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
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
			BKKJJJGADLM().SetFloat("Ev OwnershipRequest ", HBJJOCHGOPH);
			OCHJIMJNEMO().SetFloat("FPSToggle", Fade);
			KLKILLCHJHO().SetFloat("MusicFileSelector", Intensity);
			ILKALHDJBFE().SetFloat("_Value4", Speed * 1159f);
			MCDGIILBNIF().SetFloat("IconImage", Size);
			NFMGLIKNOOC().SetFloat("#checkpoint", (!_Visualize) ? 0 : 0);
			ILKALHDJBFE().SetFloat("id", _FixDistance);
			BKKJJJGADLM().SetFloat("_DiffuseColor", Snow_Near);
			DOHGBNPMBKG().SetFloat("UsernameText", Snow_Far);
			IOHHLNAPGMA().SetFloat("maps.", SnowWithoutObject);
			BKKJJJGADLM().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1f, 212f));
			HHIAIGCAHDA().SetTexture("_SprTex", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KLKILLCHJHO());
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
			KLKILLCHJHO().SetFloat("#91CCFF", HBJJOCHGOPH);
			HHIAIGCAHDA().SetFloat("_TimeX", Fade);
			INOBFNCKFGK().SetFloat("#", Intensity);
			NKBIEMJBCBM().SetFloat("_Value", Speed * 536f);
			ILKALHDJBFE().SetFloat("CameraFilterPack/Blizzard", Size);
			KLKILLCHJHO().SetFloat("Join failed on GameServer. Changing back to MasterServer. Msg: ", (!_Visualize) ? 1 : 1);
			NFMGLIKNOOC().SetFloat("menu.tabid", _FixDistance);
			EFMCNLELMDO().SetFloat("SaveButton", Snow_Near);
			HFBJAOFLCJI().SetFloat("_Red_B", Snow_Far);
			FEAEGGCNIAA().SetFloat("_Value", SnowWithoutObject);
			KLKILLCHJHO().SetVector(".highscore", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 721f, 1021f));
			LMLENGFLEBD().SetTexture("_Radius2", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ILKALHDJBFE());
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
			MMOODGIODPC().SetFloat("CameraFilterPack_Atmosphere_Rain_FX", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("action", Fade);
			IGKFMCPDNOI().SetFloat("SetSatelliteRadius", Intensity);
			DOHGBNPMBKG().SetFloat("Tab2Content", Speed * 1948f);
			HHIFMIPPMPF().SetFloat("_Value3", Size);
			DOHGBNPMBKG().SetFloat("_Red_C", _Visualize ? 1 : 0);
			NDMPCDHADMJ().SetFloat("0 - background, 1 - foreground", _FixDistance);
			HFBJAOFLCJI().SetFloat("player.xp", Snow_Near);
			LPPEPKGFOEM().SetFloat("loadscene", Snow_Far);
			BAGICADFBAB().SetFloat("#obtained", SnowWithoutObject);
			HFBJAOFLCJI().SetVector("_CenterRadius", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1682f, 1863f));
			BKKJJJGADLM().SetTexture(" ownership transfered to: ", Texture2);
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
			MCDGIILBNIF().SetFloat("CameraFilterPack/TV_Chromatical", HBJJOCHGOPH);
			KLKILLCHJHO().SetFloat("Fill Area", Fade);
			ACHNOHCLGOO().SetFloat("_Amount", Intensity);
			BAGICADFBAB().SetFloat("StartButton", Speed * 1390f);
			ACHNOHCLGOO().SetFloat("ScrollPanel", Size);
			NFMGLIKNOOC().SetFloat("_EdgeThresholdMin", (!_Visualize) ? 1 : 1);
			ILKALHDJBFE().SetFloat("_LightIntensity", _FixDistance);
			INOBFNCKFGK().SetFloat("menutheme.idunno", Snow_Near);
			LPPEPKGFOEM().SetFloat("CameraFilterPack/Distortion_Heat", Snow_Far);
			IOHHLNAPGMA().SetFloat("GameScene", SnowWithoutObject);
			IGKFMCPDNOI().SetVector("_BlurVector", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 510f, 1867f));
			FEAEGGCNIAA().SetTexture("_ScreenResolution", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
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
			ACHNOHCLGOO().SetFloat("settings_bindings_sec_", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("_Value5", Fade);
			FAIFBBGFAIB().SetFloat("#getrewardfailed: ", Intensity);
			FEAEGGCNIAA().SetFloat("_Params1", Speed * 133f);
			DOHGBNPMBKG().SetFloat("SpawnObj", Size);
			IGKFMCPDNOI().SetFloat("?", (!_Visualize) ? 0 : 0);
			EFMCNLELMDO().SetFloat("_TimeX", _FixDistance);
			HFBJAOFLCJI().SetFloat("Arc", Snow_Near);
			OCHJIMJNEMO().SetFloat("R:", Snow_Far);
			LMLENGFLEBD().SetFloat("id", SnowWithoutObject);
			IGKFMCPDNOI().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1474f, 1234f));
			NBPKMLMCHFN.SetTexture("SelectorMusicToggle", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
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
			MCDGIILBNIF().SetFloat("RecieveChatActionMessage", HBJJOCHGOPH);
			BKKJJJGADLM().SetFloat("CameraFilterPack/Edge_BlackLine", Fade);
			IOHHLNAPGMA().SetFloat("Please attach component to a Graphical UI component", Intensity);
			HKHBBBFLGJH().SetFloat("_Value2", Speed * 1476f);
			HKHBBBFLGJH().SetFloat("SpawnObj", Size);
			HKHBBBFLGJH().SetFloat("event", (!_Visualize) ? 1 : 0);
			HKHBBBFLGJH().SetFloat("[Steamworks.NET] Could not load [lib]steam_api.dll/so/dylib. It's likely not in the correct location. Refer to the README for more details.\n", _FixDistance);
			IGKFMCPDNOI().SetFloat("_BlurRadius", Snow_Near);
			CECJJMKLEAK().SetFloat("Fade", Snow_Far);
			HKHBBBFLGJH().SetFloat("_Bullet_10", SnowWithoutObject);
			BKKJJJGADLM().SetVector("ResetButton", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1462f, 890f));
			HHIFMIPPMPF().SetTexture("_FadeFX", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
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
			FAIFBBGFAIB().SetFloat(".lastCheckpoint.maxLongestCombo", HBJJOCHGOPH);
			BKKJJJGADLM().SetFloat("isVisible", Fade);
			CECJJMKLEAK().SetFloat("_TimeX", Intensity);
			ADBKPGFMNKO().SetFloat("SetCrosshairColor", Speed * 545f);
			ADBKPGFMNKO().SetFloat("HiddenToggle", Size);
			CECJJMKLEAK().SetFloat("#getrewardfailed: ", _Visualize ? 1 : 0);
			FEAEGGCNIAA().SetFloat("You have added the SecondScrollRect to a scroll view that already has both directions selected", _FixDistance);
			NFMGLIKNOOC().SetFloat("BitsData", Snow_Near);
			ACHNOHCLGOO().SetFloat("Set Background Color", Snow_Far);
			BKKJJJGADLM().SetFloat("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.", SnowWithoutObject);
			NKBIEMJBCBM().SetVector("Mouse X", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1505f, 817f));
			ACHNOHCLGOO().SetTexture(".completed", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BAGICADFBAB());
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
			ILKALHDJBFE().SetFloat("_Value", HBJJOCHGOPH);
			FEAEGGCNIAA().SetFloat("Error: I/O Failure! :(", Fade);
			MMOODGIODPC().SetFloat("RarityImage", Intensity);
			CECJJMKLEAK().SetFloat("SetSatelliteRadius", Speed * 87f);
			OCHJIMJNEMO().SetFloat("Can't set open when not in that room.", Size);
			KLKILLCHJHO().SetFloat("#submit", (!_Visualize) ? 1 : 1);
			LPPEPKGFOEM().SetFloat("OpGetGameList not sent. LobbyType must be SqlLobby.", _FixDistance);
			HHIAIGCAHDA().SetFloat("_Value", Snow_Near);
			ACHNOHCLGOO().SetFloat("-", Snow_Far);
			HFBJAOFLCJI().SetFloat("_Distortion", SnowWithoutObject);
			ADBKPGFMNKO().SetVector("offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 721f, 193f));
			ADBKPGFMNKO().SetTexture("[PlayerBase] Starting game from: ", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IOHHLNAPGMA());
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
			FAIFBBGFAIB().SetFloat("#timeuntilchallenge: ", HBJJOCHGOPH);
			FEAEGGCNIAA().SetFloat("_TimeX", Fade);
			BKKJJJGADLM().SetFloat("SetSatelliteTrailMinVertexDistance", Intensity);
			FAIFBBGFAIB().SetFloat("#ok", Speed * 786f);
			FEAEGGCNIAA().SetFloat("mapselector.filter.subscribedonly", Size);
			FEAEGGCNIAA().SetFloat("CameraFilterPack/Gradients_Ansi", (!_Visualize) ? 1 : 1);
			MMOODGIODPC().SetFloat("_Value5", _FixDistance);
			ACHNOHCLGOO().SetFloat("_Params1", Snow_Near);
			HHIAIGCAHDA().SetFloat("_VelTex", Snow_Far);
			MMOODGIODPC().SetFloat("STOP [R]", SnowWithoutObject);
			HFBJAOFLCJI().SetVector("\"", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1653f, 1787f));
			NFMGLIKNOOC().SetTexture(" Server: ", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOHGBNPMBKG());
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
			MCDGIILBNIF().SetFloat("speed", HBJJOCHGOPH);
			EFMCNLELMDO().SetFloat("VIGNETTE_DESAT", Fade);
			ADBKPGFMNKO().SetFloat("CountEventsGoal", Intensity);
			IOHHLNAPGMA().SetFloat("UnityEngine.MonoBehaviour", Speed * 666f);
			HHIFMIPPMPF().SetFloat("turn", Size);
			MMOODGIODPC().SetFloat("bad", (!_Visualize) ? 0 : 0);
			FEAEGGCNIAA().SetFloat("_ScreenResolution", _FixDistance);
			BAGICADFBAB().SetFloat("menu.selectedplaymode", Snow_Near);
			NFMGLIKNOOC().SetFloat("ticket.ticket1", Snow_Far);
			FAIFBBGFAIB().SetFloat("Failed to 'network-remove' GameObject because has no PhotonView components: ", SnowWithoutObject);
			CECJJMKLEAK().SetVector("_MainTex2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 448f, 384f));
			LPPEPKGFOEM().SetTexture("_Blue_R", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB());
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
			IGKFMCPDNOI().SetFloat("_CameraWS", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("editor.", Fade);
			ILKALHDJBFE().SetFloat("_ColorBuffer", Intensity);
			NKBIEMJBCBM().SetFloat("Moved event", Speed * 1981f);
			BKKJJJGADLM().SetFloat("907198288", Size);
			LPPEPKGFOEM().SetFloat("Drop_Far", _Visualize ? 1 : 0);
			MMOODGIODPC().SetFloat("IconImage", _FixDistance);
			DOHGBNPMBKG().SetFloat("https://steamcommunity.com/app/513510/workshop/", Snow_Near);
			NFMGLIKNOOC().SetFloat("Can't set open when not in that room.", Snow_Far);
			BAGICADFBAB().SetFloat("ItemNameText", SnowWithoutObject);
			CECJJMKLEAK().SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1335f, 1780f));
			NFMGLIKNOOC().SetTexture("_Value", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
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
			IOHHLNAPGMA().SetFloat("_TimeX", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("menu.hardcoreinfo", Fade);
			NFMGLIKNOOC().SetFloat("_Value6", Intensity);
			LPPEPKGFOEM().SetFloat("_TimeX", Speed * 1933f);
			HHIFMIPPMPF().SetFloat("_Radius", Size);
			EFMCNLELMDO().SetFloat("PLAY [SPACE]", (!_Visualize) ? 1 : 1);
			MMOODGIODPC().SetFloat("CameraFilterPack/TV_BrokenGlass2", _FixDistance);
			MMOODGIODPC().SetFloat("LivesSlider", Snow_Near);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Colors_DarkColor", Snow_Far);
			DOHGBNPMBKG().SetFloat("mapid", SnowWithoutObject);
			BAGICADFBAB().SetVector("GroupNameText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 419f, 1717f));
			ADBKPGFMNKO().SetTexture("Joystick1Button2", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OCHJIMJNEMO());
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
			NFMGLIKNOOC().SetFloat("Classical", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("CameraFilterPack_AAA_Blood2", Fade);
			HFBJAOFLCJI().SetFloat("Editor/", Intensity);
			EFMCNLELMDO().SetFloat("yes", Speed * 1255f);
			KLKILLCHJHO().SetFloat("ResetSpeed", Size);
			FEAEGGCNIAA().SetFloat("ns", _Visualize ? 1 : 0);
			NBPKMLMCHFN.SetFloat("_Color_G", _FixDistance);
			ADBKPGFMNKO().SetFloat("EventConfigButton", Snow_Near);
			OCHJIMJNEMO().SetFloat("OnStatusChanged: {0} current State: {1}", Snow_Far);
			CECJJMKLEAK().SetFloat("[MapsData] Workshop maps was loaded", SnowWithoutObject);
			IGKFMCPDNOI().SetVector("_Value1", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1874f, 903f));
			BAGICADFBAB().SetTexture("1 Kb", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
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
			HHIAIGCAHDA().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			EFMCNLELMDO().SetFloat("float,50", Fade);
			EFMCNLELMDO().SetFloat("ArcsNoHitsoundTimeDelaySlider", Intensity);
			ILKALHDJBFE().SetFloat("Editor/", Speed * 1912f);
			IGKFMCPDNOI().SetFloat("OpGetGameList()", Size);
			IOHHLNAPGMA().SetFloat("D-Pad Down", (!_Visualize) ? 0 : 0);
			HHIAIGCAHDA().SetFloat("GameScene", _FixDistance);
			ILKALHDJBFE().SetFloat("#pleasewait", Snow_Near);
			FEAEGGCNIAA().SetFloat("CameraFilterPack/Blend2Camera_Multiply", Snow_Far);
			EFMCNLELMDO().SetFloat(" GameServer:", SnowWithoutObject);
			INOBFNCKFGK().SetVector("1087340967", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 24f, 319f));
			INOBFNCKFGK().SetTexture("AddEnvironmentObject", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CECJJMKLEAK());
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
			CECJJMKLEAK().SetFloat(" ", HBJJOCHGOPH);
			HKHBBBFLGJH().SetFloat("Set satellite clockwise rotattion speed", Fade);
			LMLENGFLEBD().SetFloat("#creatingnewitem", Intensity);
			MCDGIILBNIF().SetFloat("HiddenToggle", Speed * 51f);
			KLKILLCHJHO().SetFloat("_Threshhold", Size);
			LMLENGFLEBD().SetFloat("MapEnd", (!_Visualize) ? 1 : 1);
			OCHJIMJNEMO().SetFloat("CameraFilterPack/Blend2Camera_VividLight", _FixDistance);
			EFMCNLELMDO().SetFloat("[SaveSystem] Outdated savefile found", Snow_Near);
			FEAEGGCNIAA().SetFloat("CameraFilterPack/Blend2Camera_Subtract", Snow_Far);
			FEAEGGCNIAA().SetFloat("Texture2", SnowWithoutObject);
			LMLENGFLEBD().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 593f, 524f));
			NKBIEMJBCBM().SetTexture("_Value2", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIAIGCAHDA());
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
			LPPEPKGFOEM().SetFloat("_Distortion", HBJJOCHGOPH);
			LPPEPKGFOEM().SetFloat("z", Fade);
			NBPKMLMCHFN.SetFloat("DPADVER", Intensity);
			BAGICADFBAB().SetFloat("_Value11", Speed * 211f);
			ILKALHDJBFE().SetFloat("setint", Size);
			BKKJJJGADLM().SetFloat("maps.", (!_Visualize) ? 1 : 1);
			NBPKMLMCHFN.SetFloat("_LightIntensity", _FixDistance);
			OCHJIMJNEMO().SetFloat("DisableStoryboardToggle", Snow_Near);
			HFBJAOFLCJI().SetFloat("_Parasite", Snow_Far);
			ACHNOHCLGOO().SetFloat("Creating awesome maps", SnowWithoutObject);
			IOHHLNAPGMA().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1968f, 1995f));
			ADAFMBOGPLN().SetTexture("steamid", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
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
			HKHBBBFLGJH().SetFloat("0 seconds", HBJJOCHGOPH);
			OCHJIMJNEMO().SetFloat("IconFileSelector", Fade);
			INOBFNCKFGK().SetFloat("_MainTex2", Intensity);
			KLKILLCHJHO().SetFloat("settings.gamemessagesduration", Speed * 1268f);
			MMOODGIODPC().SetFloat("Type of observed is unknown when receiving.", Size);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", (!_Visualize) ? 1 : 1);
			FAIFBBGFAIB().SetFloat("ticket", _FixDistance);
			FAIFBBGFAIB().SetFloat("_Value3", Snow_Near);
			BKKJJJGADLM().SetFloat("_TimeX", Snow_Far);
			ADBKPGFMNKO().SetFloat("SpawnObj", SnowWithoutObject);
			ILKALHDJBFE().SetVector("COMPLETED", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 612f, 1586f));
			NKBIEMJBCBM().SetTexture("AvatarImage", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, INOBFNCKFGK());
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
			HKHBBBFLGJH().SetFloat("_Value4", HBJJOCHGOPH);
			MMOODGIODPC().SetFloat(">", Fade);
			MMOODGIODPC().SetFloat("</color>", Intensity);
			DOHGBNPMBKG().SetFloat("SpawnObj", Speed * 35f);
			DOHGBNPMBKG().SetFloat("_Amount", Size);
			MCDGIILBNIF().SetFloat("CameraFilterPack/Light_Water", (!_Visualize) ? 0 : 0);
			NKBIEMJBCBM().SetFloat("#discord{0}joinrequest", _FixDistance);
			LMLENGFLEBD().SetFloat("L2", Snow_Near);
			HHIFMIPPMPF().SetFloat("Creating awesome map", Snow_Far);
			NFMGLIKNOOC().SetFloat("MenuScene", SnowWithoutObject);
			ACHNOHCLGOO().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 480f, 70f));
			EFMCNLELMDO().SetTexture("Spawn ark to be pressed at this time", Texture2);
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ILKALHDJBFE());
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
