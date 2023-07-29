// CameraFilterPack_3D_Ghost
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/3D/Ghost")]
public class CameraFilterPack_3D_Ghost : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	public bool _Visualize;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 100f)]
	public float _FixDistance = 5f;

	[Range(-0.5f, 0.99f)]
	public float Ghost_Near = 0.08f;

	[Range(0f, 1f)]
	public float Ghost_Far = 0.55f;

	[Range(0f, 2f)]
	public float Intensity = 1f;

	[Range(0f, 1f)]
	public float GhostWithoutObject = 1f;

	[Range(-1f, 1f)]
	public float GhostPosX;

	[Range(-1f, 1f)]
	public float GhostPosY;

	[Range(0.1f, 8f)]
	public float GhostFade2 = 2f;

	[Range(-1f, 1f)]
	public float GhostFade;

	[Range(0.5f, 1.5f)]
	public float GhostSize = 0.9f;

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

	private void EHCGBJDFMHG()
	{
	}

	private void JOONHGHGKKF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 392f)
			{
				HBJJOCHGOPH = 1303f;
			}
			LNLKMDPHDCC().SetFloat(".", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("Attempting to remove texture that was not allocated: {0}", Intensity);
			ABHDNGIHBKE().SetFloat("[LevelEditorScene] Error: You're not logged into Steam!", GhostPosX);
			MMOODGIODPC().SetFloat("BitsData", GhostPosY);
			OIMMPLPBLBK().SetFloat("menu.tabid", GhostFade);
			BKKJJJGADLM().SetFloat("If you host Photon yourself, make sure to start the 'Instance LoadBalancing' ", GhostFade2);
			FAIFBBGFAIB().SetFloat("inventory.itemscash", GhostSize);
			BKKJJJGADLM().SetFloat("_InternalLutParams", _Visualize ? 1 : 0);
			CFEDGDGBCHE().SetFloat("_ChangeGreen", _FixDistance);
			NLFJGMBCICG().SetFloat("input", Ghost_Near);
			LNLKMDPHDCC().SetFloat("CameraFilterPack/Drawing_Comics", Ghost_Far);
			MICHFGAOPKM().SetFloat("checkpoint", GhostWithoutObject);
			DKNJGHFLAIF().SetVector("CameraFilterPack/Oculus_NightVision5", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 196f, 211f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IMCKJCHKMKB()
	{
		SCShader = Shader.Find("default");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EJFJENFKLND()
	{
	}

	[SpecialName]
	private Material OIMMPLPBLBK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void MNBPNHNAEBK()
	{
		SCShader = Shader.Find("CameraFilterPack/Blend2Camera_Luminosity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HLLHJIDOOGA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material LNLKMDPHDCC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)97;
		}
		return BJFKDHHMLJH;
	}

	private void Update()
	{
	}

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 383f)
			{
				HBJJOCHGOPH = 1330f;
			}
			OIMMPLPBLBK().SetFloat("DPADHOR", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("_ScreenResolution", Intensity);
			NLFJGMBCICG().SetFloat(".completed", GhostPosX);
			FAIFBBGFAIB().SetFloat(" to ", GhostPosY);
			HCGJCMDJPGD().SetFloat("_TimeX", GhostFade);
			IIJMIPBMMBF().SetFloat("The given 2D texture ", GhostFade2);
			BKKJJJGADLM().SetFloat("Texture2", GhostSize);
			MICHFGAOPKM().SetFloat("_Size", (!_Visualize) ? 0 : 0);
			OIMMPLPBLBK().SetFloat(".workshop.json", _FixDistance);
			LNLKMDPHDCC().SetFloat("CameraFilterPack/Antialiasing_FXAA", Ghost_Near);
			ABHDNGIHBKE().SetFloat("_Value3", Ghost_Far);
			NBPKMLMCHFN.SetFloat("powerup.0", GhostWithoutObject);
			CFEDGDGBCHE().SetVector("SUBMIT", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1750f, 789f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
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

	private void ICILLMAKLMI()
	{
		SCShader = Shader.Find("Anomaly_With_Obj");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material HCGJCMDJPGD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return BJFKDHHMLJH;
	}

	private void ANCKKLFPGDI()
	{
		SCShader = Shader.Find("OnPickedUp");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material BFGNMFCNDBC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 141f)
			{
				HBJJOCHGOPH = 315f;
			}
			FAIFBBGFAIB().SetFloat("CompletedLevel", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Distortion", Intensity);
			CFEDGDGBCHE().SetFloat("[EMPTY]", GhostPosX);
			IIJMIPBMMBF().SetFloat("_Value", GhostPosY);
			MICHFGAOPKM().SetFloat("Object ID. Case-Sensitive", GhostFade);
			KGOLDDBHIFN().SetFloat("_Green_B", GhostFade2);
			ABHDNGIHBKE().SetFloat("BlockSize", GhostSize);
			FEAEGGCNIAA().SetFloat("_TileTexDebug", (!_Visualize) ? 0 : 0);
			IIJMIPBMMBF().SetFloat("[BuildInfo] Error: ", _FixDistance);
			KAFBNOBOIAJ().SetFloat("_Amount", Ghost_Near);
			DKNJGHFLAIF().SetFloat("steamid", Ghost_Far);
			NBPKMLMCHFN.SetFloat("ReconnectAndRejoin() disabled the offline mode. No longer offline.", GhostWithoutObject);
			IIJMIPBMMBF().SetVector("ERROR: Make sure your mod contains at leats one file!", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1761f, 42f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material KAFBNOBOIAJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void FDPOFMCFBMF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1409f)
			{
				HBJJOCHGOPH = 419f;
			}
			BFGNMFCNDBC().SetFloat(": ", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("The number of objects sent via a PhotonStreamQueue has to be the same each frame", Intensity);
			DKNJGHFLAIF().SetFloat("CameraFilterPack/TV_Vcr", GhostPosX);
			BFGNMFCNDBC().SetFloat(".lastCheckpoint.time", GhostPosY);
			NLFJGMBCICG().SetFloat("_MainTex2", GhostFade);
			IIJMIPBMMBF().SetFloat("RedoButton", GhostFade2);
			IIJMIPBMMBF().SetFloat("mapselector.orderby", GhostSize);
			FEAEGGCNIAA().SetFloat(" ", (!_Visualize) ? 1 : 1);
			MMOODGIODPC().SetFloat("CameraFilterPack/Distortion_Aspiration", _FixDistance);
			NBPKMLMCHFN.SetFloat("owner: ", Ghost_Near);
			BKKJJJGADLM().SetFloat("UNDISTORT", Ghost_Far);
			IIJMIPBMMBF().SetFloat("_Speed", GhostWithoutObject);
			MMOODGIODPC().SetVector("#close", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1866f, 749f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GHILDCBCDJI()
	{
	}

	private void JOACBIEHHCE()
	{
	}

	private void OMCLOFCJMPG()
	{
	}

	private void IMGGCJICLHK()
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-108);
		}
		return BJFKDHHMLJH;
	}

	private void HGDDCINLDAD()
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
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void BNEJMABFKJE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HONBLGFDMLL()
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
			if (HBJJOCHGOPH > 277f)
			{
				HBJJOCHGOPH = 1852f;
			}
			DKNJGHFLAIF().SetFloat("[PlayerController] ", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("SpawnObj", Intensity);
			LNLKMDPHDCC().SetFloat("_TimeX", GhostPosX);
			NBPKMLMCHFN.SetFloat("event", GhostPosY);
			KAFBNOBOIAJ().SetFloat("player.redlifering", GhostFade);
			NLFJGMBCICG().SetFloat("_Value3", GhostFade2);
			FAIFBBGFAIB().SetFloat("BadgeText", GhostSize);
			HCGJCMDJPGD().SetFloat("_Value2", (!_Visualize) ? 0 : 0);
			HCGJCMDJPGD().SetFloat("_ScreenResolution", _FixDistance);
			LNLKMDPHDCC().SetFloat(" failed in a server-side plugin. Check the configuration in the Dashboard. Message from server-plugin: ", Ghost_Near);
			ABHDNGIHBKE().SetFloat(".lastCheckpoint.checkpointsUsed", Ghost_Far);
			KAFBNOBOIAJ().SetFloat("DPADHOR", GhostWithoutObject);
			MMOODGIODPC().SetVector("[Sound Manager] Audio clip is null, cannot play sound", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 707f, 477f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PKLOBJHKFEO()
	{
		SCShader = Shader.Find("mapselector.filter.rateduponly");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MMMDPANNAIO()
	{
		SCShader = Shader.Find("ticket");
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
			if (HBJJOCHGOPH > 281f)
			{
				HBJJOCHGOPH = 1536f;
			}
			KAFBNOBOIAJ().SetFloat("_Value", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat(" argument(s): ", Intensity);
			FEAEGGCNIAA().SetFloat(",", GhostPosX);
			NLFJGMBCICG().SetFloat("BadgeText", GhostPosY);
			KAFBNOBOIAJ().SetFloat("_ScreenResolution", GhostFade);
			FEAEGGCNIAA().SetFloat("Show image from resources by id at the center of the screen at foreground or background", GhostFade2);
			KAFBNOBOIAJ().SetFloat("_Intensity", GhostSize);
			NBPKMLMCHFN.SetFloat("_Bullet_5", _Visualize ? 1 : 0);
			BKKJJJGADLM().SetFloat("PhotonView ID duplicate found: {0}. New: {1} old: {2}. Maybe one wasn't destroyed on scene load?! Check for 'DontDestroyOnLoad'. Destroying old entry, adding new.", _FixDistance);
			NBPKMLMCHFN.SetFloat("VisionBlur", Ghost_Near);
			MICHFGAOPKM().SetFloat("0 seconds", Ghost_Far);
			NBPKMLMCHFN.SetFloat("EnableRankedNotificationsToggle", GhostWithoutObject);
			LNLKMDPHDCC().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 788f, 1644f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
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
			if (HBJJOCHGOPH > 676f)
			{
				HBJJOCHGOPH = 1669f;
			}
			ABHDNGIHBKE().SetFloat(" ", HBJJOCHGOPH);
			BKKJJJGADLM().SetFloat("[NetworkManager] Exited", Intensity);
			CFEDGDGBCHE().SetFloat("[MapEditor] Loading map: ", GhostPosX);
			MICHFGAOPKM().SetFloat("_Value3", GhostPosY);
			MICHFGAOPKM().SetFloat("maps.", GhostFade);
			FAIFBBGFAIB().SetFloat("Netw. Sim.", GhostFade2);
			BFGNMFCNDBC().SetFloat("\r\n", GhostSize);
			NLFJGMBCICG().SetFloat("Gameplay/Segment-[PowerUp]", (!_Visualize) ? 0 : 0);
			MMOODGIODPC().SetFloat("init", _FixDistance);
			FAIFBBGFAIB().SetFloat("_GrainTex", Ghost_Near);
			MMOODGIODPC().SetFloat("_TimeX", Ghost_Far);
			HCGJCMDJPGD().SetFloat("Failed to 'network-remove' GameObject because it's null.", GhostWithoutObject);
			MMOODGIODPC().SetVector(",", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 936f, 1234f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
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

	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1034f)
			{
				HBJJOCHGOPH = 1231f;
			}
			IIJMIPBMMBF().SetFloat("_LightIntensity", HBJJOCHGOPH);
			MMOODGIODPC().SetFloat("_Saturation", Intensity);
			OIMMPLPBLBK().SetFloat("CameraFilterPack/Blur_Steam", GhostPosX);
			NBPKMLMCHFN.SetFloat("[MapsData] Workshop maps was loaded", GhostPosY);
			BFGNMFCNDBC().SetFloat("id", GhostFade);
			HCGJCMDJPGD().SetFloat("_MainTex2", GhostFade2);
			IIJMIPBMMBF().SetFloat("_Value", GhostSize);
			FAIFBBGFAIB().SetFloat("sounds/hit_wrong", (!_Visualize) ? 1 : 1);
			FEAEGGCNIAA().SetFloat("yyyy-MM-dd HH:mm:ss", _FixDistance);
			NBPKMLMCHFN.SetFloat("fetch", Ghost_Near);
			IIJMIPBMMBF().SetFloat("_TimeX", Ghost_Far);
			NLFJGMBCICG().SetFloat("s", GhostWithoutObject);
			CFEDGDGBCHE().SetVector(":", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1335f, 433f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NEKCPLGFOFD()
	{
	}

	private void BEBNOKFLJPH()
	{
		SCShader = Shader.Find("id");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material MICHFGAOPKM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)87;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material ABHDNGIHBKE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)65;
		}
		return BJFKDHHMLJH;
	}

	private void GKNKIIEALCH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material KGOLDDBHIFN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-69);
		}
		return BJFKDHHMLJH;
	}

	private void PLIKADJCEPO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ICDBMJKMIKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material FEAEGGCNIAA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1051f)
			{
				HBJJOCHGOPH = 1835f;
			}
			HCGJCMDJPGD().SetFloat("PS Home", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("Mouse Y", Intensity);
			LNLKMDPHDCC().SetFloat("_Blend", GhostPosX);
			BKKJJJGADLM().SetFloat("_TimeX", GhostPosY);
			BFGNMFCNDBC().SetFloat("y", GhostFade);
			OIMMPLPBLBK().SetFloat("Load Game", GhostFade2);
			BKKJJJGADLM().SetFloat("0x", GhostSize);
			BFGNMFCNDBC().SetFloat("_FixDistance", (!_Visualize) ? 1 : 0);
			BKKJJJGADLM().SetFloat("_TimeX", _FixDistance);
			KGOLDDBHIFN().SetFloat("Fade", Ghost_Near);
			LNLKMDPHDCC().SetFloat("OnDeserialize", Ghost_Far);
			MICHFGAOPKM().SetFloat("_TimeX", GhostWithoutObject);
			MICHFGAOPKM().SetVector("_FarCamera", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1188f, 726f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
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

	private void KMCPMOGKDEH()
	{
		SCShader = Shader.Find("_StretchWidth");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PHJLHCMCCKE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IFJDKDFLGBG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 893f)
			{
				HBJJOCHGOPH = 685f;
			}
			CFEDGDGBCHE().SetFloat("[PlayerBase] Delete checkpoint data", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("EventTimeInputField", Intensity);
			BFGNMFCNDBC().SetFloat("Curve texture", GhostPosX);
			MMOODGIODPC().SetFloat("UnityEngine.MonoBehaviour", GhostPosY);
			HCGJCMDJPGD().SetFloat("Joystick1Button1", GhostFade);
			HCGJCMDJPGD().SetFloat("GridDataArcs", GhostFade2);
			NLFJGMBCICG().SetFloat("_TimeX", GhostSize);
			FAIFBBGFAIB().SetFloat("CameraFilterPack/AAA_WaterDropPro", (!_Visualize) ? 1 : 0);
			ABHDNGIHBKE().SetFloat("_Value4", _FixDistance);
			FAIFBBGFAIB().SetFloat("http://steamcommunity.com/sharedfiles/filedetails/?id=", Ghost_Near);
			FAIFBBGFAIB().SetFloat("PLEASE WAIT", Ghost_Far);
			BKKJJJGADLM().SetFloat("_MatrixSpeed", GhostWithoutObject);
			DKNJGHFLAIF().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1469f, 998f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EGEPLFGKGLI()
	{
		SCShader = Shader.Find(" scene view IDs from last level.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CPAJLKHMOJB()
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return BJFKDHHMLJH;
	}

	private void DNNFHBOOPIN()
	{
		SCShader = Shader.Find("_DiffuseColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IEFMONDKKJN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HLDFOJMHKNL()
	{
	}

	private void AEIJFLJEABG()
	{
	}

	private void CHOPDIGHJNH()
	{
		SCShader = Shader.Find("FrostCanvas");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IABLKKAALGI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BGDPIHMAACO()
	{
		SCShader = Shader.Find("#FFFFFFFF");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FJIKDJAMOHA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DLBODOFAJGM()
	{
		SCShader = Shader.Find("ItemsCountText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JKFDDNMPOJH()
	{
		SCShader = Shader.Find("CONTRAST");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FOMNCPKKCFN()
	{
	}

	private void LBPHCAMMAPB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/3D_Ghost");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
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
			NBPKMLMCHFN.SetFloat("_Value2", Intensity);
			NBPKMLMCHFN.SetFloat("GhostPosX", GhostPosX);
			NBPKMLMCHFN.SetFloat("GhostPosY", GhostPosY);
			NBPKMLMCHFN.SetFloat("GhostFade", GhostFade);
			NBPKMLMCHFN.SetFloat("GhostFade2", GhostFade2);
			NBPKMLMCHFN.SetFloat("GhostSize", GhostSize);
			NBPKMLMCHFN.SetFloat("_Visualize", _Visualize ? 1 : 0);
			NBPKMLMCHFN.SetFloat("_FixDistance", _FixDistance);
			NBPKMLMCHFN.SetFloat("Drop_Near", Ghost_Near);
			NBPKMLMCHFN.SetFloat("Drop_Far", Ghost_Far);
			NBPKMLMCHFN.SetFloat("Drop_With_Obj", GhostWithoutObject);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1313f)
			{
				HBJJOCHGOPH = 1409f;
			}
			ABHDNGIHBKE().SetFloat("CameraFilterPack/Gradients_NeonGradient", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("_Size", Intensity);
			ABHDNGIHBKE().SetFloat("LeaderboardsButton", GhostPosX);
			FAIFBBGFAIB().SetFloat("_Parameter", GhostPosY);
			BFGNMFCNDBC().SetFloat("hidden", GhostFade);
			IIJMIPBMMBF().SetFloat(".icon", GhostFade2);
			IIJMIPBMMBF().SetFloat("CameraFilterPack/Drawing_Manga2", GhostSize);
			OIMMPLPBLBK().SetFloat("Uploading content...", (!_Visualize) ? 1 : 0);
			BFGNMFCNDBC().SetFloat("_Value", _FixDistance);
			HCGJCMDJPGD().SetFloat("[PlayerBase] ShowTitle error: ", Ghost_Near);
			MICHFGAOPKM().SetFloat("[Right]", Ghost_Far);
			IIJMIPBMMBF().SetFloat("[DiscordController] Responding yes to Ask to Join request", GhostWithoutObject);
			FAIFBBGFAIB().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 434f, 1857f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 31f)
			{
				HBJJOCHGOPH = 478f;
			}
			HCGJCMDJPGD().SetFloat("settings_bindings_controller_type", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("_TimeX", Intensity);
			ABHDNGIHBKE().SetFloat("SetParent", GhostPosX);
			NLFJGMBCICG().SetFloat("_Value2", GhostPosY);
			IIJMIPBMMBF().SetFloat("ResetSpeed", GhostFade);
			NLFJGMBCICG().SetFloat("Created by ", GhostFade2);
			BFGNMFCNDBC().SetFloat("_Value2", GhostSize);
			BKKJJJGADLM().SetFloat("_TimeX", _Visualize ? 1 : 0);
			NLFJGMBCICG().SetFloat("SendVacantViewIds()", _FixDistance);
			KGOLDDBHIFN().SetFloat("\n", Ghost_Near);
			MMOODGIODPC().SetFloat("_DotSize", Ghost_Far);
			MMOODGIODPC().SetFloat("menuVolume", GhostWithoutObject);
			IIJMIPBMMBF().SetVector("_NoiseTex", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 8f, 858f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BKKJJJGADLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DKNJGHFLAIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-1);
		}
		return BJFKDHHMLJH;
	}

	private void IIFCIDDJHPM()
	{
	}

	[SpecialName]
	private Material FAIFBBGFAIB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IIJMIPBMMBF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)95;
		}
		return BJFKDHHMLJH;
	}

	private void JHJFBCFBKLD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material NLFJGMBCICG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void PDHKMDBNGGN()
	{
		SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}
}
