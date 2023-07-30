// CameraFilterPack_3D_Ghost
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/3D/Ghost")]
[ExecuteInEditMode]
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
			FEAEGGCNIAA().SetFloat(".lastCheckpoint.playerdistance", HBJJOCHGOPH);
			BKKJJJGADLM().SetFloat("Floating point textures aren't supported on this device ({0})", Intensity);
			BFGNMFCNDBC().SetFloat("[LevelEditorScene] Error: Timeout :S", GhostPosX);
			CFEDGDGBCHE().SetFloat("BitsData", GhostPosY);
			DKNJGHFLAIF().SetFloat("menu.tabid", GhostFade);
			KAFBNOBOIAJ().SetFloat("Operation failed: ", GhostFade2);
			BKKJJJGADLM().SetFloat("inventory.itemscash", GhostSize);
			BFGNMFCNDBC().SetFloat("ENABLE_DITHERING", _Visualize ? 1 : 0);
			FAIFBBGFAIB().SetFloat("_ChangeRed", _FixDistance);
			FAIFBBGFAIB().SetFloat("Object ID. Case-Sensitive", Ghost_Near);
			KAFBNOBOIAJ().SetFloat("CameraFilterPack/Drawing_Comics", Ghost_Far);
			BKKJJJGADLM().SetFloat("BitsData", GhostWithoutObject);
			MICHFGAOPKM().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 196f, 211f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IMCKJCHKMKB()
	{
		SCShader = Shader.Find(".png");
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
			KAFBNOBOIAJ().SetFloat("DPADHOR", HBJJOCHGOPH);
			BKKJJJGADLM().SetFloat("_Value", Intensity);
			BKKJJJGADLM().SetFloat("[MapsEditor] Creating new item...", GhostPosX);
			LNLKMDPHDCC().SetFloat(".workshop.json", GhostPosY);
			MICHFGAOPKM().SetFloat("CameraFilterPack/Drawing_Manga_Flash", GhostFade);
			ABHDNGIHBKE().SetFloat("CameraFilterPack/Lut_PlayWith", GhostFade2);
			BFGNMFCNDBC().SetFloat("_SweaterSize", GhostSize);
			BKKJJJGADLM().SetFloat("_Distortion", (!_Visualize) ? 0 : 0);
			FAIFBBGFAIB().SetFloat(".workshop", _FixDistance);
			IIJMIPBMMBF().SetFloat("CameraFilterPack/Antialiasing_FXAA", Ghost_Near);
			IIJMIPBMMBF().SetFloat("_Value", Ghost_Far);
			FAIFBBGFAIB().SetFloat("note.4", GhostWithoutObject);
			HCGJCMDJPGD().SetVector("SUBMIT", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1750f, 789f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
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
		SCShader = Shader.Find(" SecondsBeforeRespawn: ");
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
			OIMMPLPBLBK().SetFloat("win", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat("_TimeX", Intensity);
			NBPKMLMCHFN.SetFloat("Data/Localization", GhostPosX);
			ABHDNGIHBKE().SetFloat("_TimeX", GhostPosY);
			BKKJJJGADLM().SetFloat("Object ID. Case-Sensitive", GhostFade);
			OIMMPLPBLBK().SetFloat("_Green_G", GhostFade2);
			MMOODGIODPC().SetFloat("SupportLogger OnLeftRoom().", GhostSize);
			NBPKMLMCHFN.SetFloat("_NeighbourMaxTex", (!_Visualize) ? 0 : 0);
			KAFBNOBOIAJ().SetFloat(" b.", _FixDistance);
			OIMMPLPBLBK().SetFloat("_TimeX", Ghost_Near);
			HCGJCMDJPGD().SetFloat("ERROR", Ghost_Far);
			IIJMIPBMMBF().SetFloat("Reconnect() disabled the offline mode. No longer offline.", GhostWithoutObject);
			CFEDGDGBCHE().SetVector("EXCEPTION:", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1761f, 42f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
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
			OIMMPLPBLBK().SetFloat("%", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("ping: {6}[+/-{7}]ms resent:{8} \n\nmax ms between\nsend: {0,4} \ndispatch: {1,4} \n\nlongest dispatch for: \nev({3}):{2,3}ms \nop({5}):{4,3}ms", Intensity);
			MMOODGIODPC().SetFloat("_ScreenResolution", GhostPosX);
			NBPKMLMCHFN.SetFloat("LostAllLives", GhostPosY);
			NLFJGMBCICG().SetFloat("_MainTex2", GhostFade);
			MICHFGAOPKM().SetFloat("RedoButton", GhostFade2);
			BKKJJJGADLM().SetFloat("mapselector.filter.favoriteonly", GhostSize);
			NBPKMLMCHFN.SetFloat(" ", (!_Visualize) ? 1 : 1);
			BFGNMFCNDBC().SetFloat("CameraFilterPack/Distortion_Aspiration", _FixDistance);
			FEAEGGCNIAA().SetFloat("ViewID {0} {1}{2}", Ghost_Near);
			LNLKMDPHDCC().SetFloat("_VignetteColor", Ghost_Far);
			LNLKMDPHDCC().SetFloat("_Speed", GhostWithoutObject);
			NLFJGMBCICG().SetVector("#tryagain", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1866f, 749f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
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
			NLFJGMBCICG().SetFloat(" not exist", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat("[Right]", Intensity);
			BFGNMFCNDBC().SetFloat("_TimeX", GhostPosX);
			KGOLDDBHIFN().SetFloat("event", GhostPosY);
			NBPKMLMCHFN.SetFloat("player.redlifering", GhostFade);
			OIMMPLPBLBK().SetFloat("_Value2", GhostFade2);
			FAIFBBGFAIB().SetFloat("BadgeImage", GhostSize);
			KAFBNOBOIAJ().SetFloat("_Value", (!_Visualize) ? 0 : 0);
			NLFJGMBCICG().SetFloat("_Glitch", _FixDistance);
			FAIFBBGFAIB().SetFloat(" could not be executed (yet). Wait for state JoinedLobby or ConnectedToMaster and their callbacks before calling operations. WebRPCs need a server-side configuration. Enum OperationCode helps identify the operation.", Ghost_Near);
			IIJMIPBMMBF().SetFloat(".lastCheckpoint.lives", Ghost_Far);
			HCGJCMDJPGD().SetFloat("DPADHOR", GhostWithoutObject);
			FEAEGGCNIAA().SetVector("sounds/hit_normal", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 707f, 477f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
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
		SCShader = Shader.Find("Updating...");
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
			KAFBNOBOIAJ().SetFloat("_TimeX", HBJJOCHGOPH);
			HCGJCMDJPGD().SetFloat(" methods \"", Intensity);
			DKNJGHFLAIF().SetFloat("Checkpoint", GhostPosX);
			CFEDGDGBCHE().SetFloat("BadgeText", GhostPosY);
			HCGJCMDJPGD().SetFloat("_Smooth", GhostFade);
			ABHDNGIHBKE().SetFloat("Show image from resources by id at the center of the screen at foreground or background", GhostFade2);
			FAIFBBGFAIB().SetFloat("_Intensity", GhostSize);
			OIMMPLPBLBK().SetFloat("_Bullet_3", _Visualize ? 1 : 0);
			NBPKMLMCHFN.SetFloat(" Time: ", _FixDistance);
			DKNJGHFLAIF().SetFloat("Fade", Ghost_Near);
			HCGJCMDJPGD().SetFloat(", ", Ghost_Far);
			IIJMIPBMMBF().SetFloat("EnableRankedNotificationsToggle", GhostWithoutObject);
			IIJMIPBMMBF().SetVector("int", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 788f, 1644f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
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
			IIJMIPBMMBF().SetFloat("event", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat("[NetworkManager] Exited", Intensity);
			OIMMPLPBLBK().SetFloat("0.00", GhostPosX);
			ABHDNGIHBKE().SetFloat("_Value2", GhostPosY);
			MMOODGIODPC().SetFloat("maps.", GhostFade);
			MMOODGIODPC().SetFloat("' ping: ", GhostFade2);
			OIMMPLPBLBK().SetFloat("\r\n", GhostSize);
			CFEDGDGBCHE().SetFloat("Items/", (!_Visualize) ? 0 : 0);
			MMOODGIODPC().SetFloat("init", _FixDistance);
			MMOODGIODPC().SetFloat("_MainTex", Ghost_Near);
			BFGNMFCNDBC().SetFloat("_TimeX", Ghost_Far);
			BFGNMFCNDBC().SetFloat("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.", GhostWithoutObject);
			ABHDNGIHBKE().SetVector("LevelEditor/CustomEventEditor-Text", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 936f, 1234f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
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
			NLFJGMBCICG().SetFloat("_LightIntensity", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("_ZCurve", Intensity);
			CFEDGDGBCHE().SetFloat("CameraFilterPack/Blur_Steam", GhostPosX);
			ABHDNGIHBKE().SetFloat("[MapsData] Found ", GhostPosY);
			IIJMIPBMMBF().SetFloat("id", GhostFade);
			CFEDGDGBCHE().SetFloat("_MainTex2", GhostFade2);
			BKKJJJGADLM().SetFloat("_TimeX", GhostSize);
			HCGJCMDJPGD().SetFloat("skin.no_hit", (!_Visualize) ? 1 : 1);
			MICHFGAOPKM().SetFloat("#,0.00", _FixDistance);
			LNLKMDPHDCC().SetFloat("FToA", Ghost_Near);
			ABHDNGIHBKE().SetFloat("CameraFilterPack/NightVision_4", Ghost_Far);
			NLFJGMBCICG().SetFloat("s", GhostWithoutObject);
			OIMMPLPBLBK().SetVector("hitsounds:", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1335f, 433f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
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
		SCShader = Shader.Find("Set EnvSprite Image");
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
			BKKJJJGADLM().SetFloat("Right Stick Click", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("Mouse X", Intensity);
			MICHFGAOPKM().SetFloat("_LutTex", GhostPosX);
			ABHDNGIHBKE().SetFloat("_TimeX", GhostPosY);
			KGOLDDBHIFN().SetFloat("x", GhostFade);
			NLFJGMBCICG().SetFloat("Exit to Windows", GhostFade2);
			NLFJGMBCICG().SetFloat("SetSpeed", GhostSize);
			FAIFBBGFAIB().SetFloat("_FixDistance", (!_Visualize) ? 1 : 0);
			KAFBNOBOIAJ().SetFloat("CameraFilterPack/BlurTiltShift_V", _FixDistance);
			BFGNMFCNDBC().SetFloat("UseFinalGlassColor", Ghost_Near);
			DKNJGHFLAIF().SetFloat("saveGameName ", Ghost_Far);
			BKKJJJGADLM().SetFloat("_TimeX", GhostWithoutObject);
			LNLKMDPHDCC().SetVector("_FarCamera", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1188f, 726f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BKKJJJGADLM());
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
			KAFBNOBOIAJ().SetFloat("maps.", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("LevelEditor/CustomEventEditor-Text", Intensity);
			HCGJCMDJPGD().SetFloat("_Axis", GhostPosX);
			CFEDGDGBCHE().SetFloat("OnDeserialize", GhostPosY);
			MMOODGIODPC().SetFloat("X", GhostFade);
			MMOODGIODPC().SetFloat("GridDataArcs", GhostFade2);
			BKKJJJGADLM().SetFloat("CameraFilterPack/Film_ColorPerfection", GhostSize);
			FEAEGGCNIAA().SetFloat("CameraFilterPack/AAA_WaterDropPro", (!_Visualize) ? 1 : 0);
			FEAEGGCNIAA().SetFloat("_Value3", _FixDistance);
			NBPKMLMCHFN.SetFloat("UpdateDownloadingProgress", Ghost_Near);
			KGOLDDBHIFN().SetFloat("Uploading content", Ghost_Far);
			MICHFGAOPKM().SetFloat("_MatrixSpeed", GhostWithoutObject);
			MMOODGIODPC().SetVector("CameraFilterPack/FX_DigitalMatrix", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1469f, 998f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EGEPLFGKGLI()
	{
		SCShader = Shader.Find(". The group number should be at least 1.");
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
		SCShader = Shader.Find("LostLive");
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
		SCShader = Shader.Find("settings.shaders.bloomintencity");
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
		SCShader = Shader.Find("Start Color's hex value #RRGGBBAA");
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
		SCShader = Shader.Find("InfoText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JKFDDNMPOJH()
	{
		SCShader = Shader.Find("Brightness");
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
			ABHDNGIHBKE().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("_TimeX", Intensity);
			IIJMIPBMMBF().SetFloat("RateButton", GhostPosX);
			HCGJCMDJPGD().SetFloat("_Parameter", GhostPosY);
			DKNJGHFLAIF().SetFloat("closed", GhostFade);
			NBPKMLMCHFN.SetFloat("skin.", GhostFade2);
			KAFBNOBOIAJ().SetFloat("_ScreenResolution", GhostSize);
			OIMMPLPBLBK().SetFloat("Preparing content...", (!_Visualize) ? 1 : 0);
			FEAEGGCNIAA().SetFloat("_Value", _FixDistance);
			LNLKMDPHDCC().SetFloat("[PlayerBase] SetPlayerDistance error: ", Ghost_Near);
			CFEDGDGBCHE().SetFloat("_EmissionColor", Ghost_Far);
			HCGJCMDJPGD().SetFloat("blue", GhostWithoutObject);
			ABHDNGIHBKE().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 434f, 1857f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
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
			LNLKMDPHDCC().SetFloat("settings_bindings_sec_", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat("_TimeX", Intensity);
			KGOLDDBHIFN().SetFloat("ClearEnvironment", GhostPosX);
			MICHFGAOPKM().SetFloat("_Value", GhostPosY);
			MMOODGIODPC().SetFloat("ResetSpeed", GhostFade);
			ABHDNGIHBKE().SetFloat("KickThePlayer", GhostFade2);
			KAFBNOBOIAJ().SetFloat("_Value2", GhostSize);
			IIJMIPBMMBF().SetFloat("CameraFilterPack/TV_Posterize", _Visualize ? 1 : 0);
			MMOODGIODPC().SetFloat("SetupEncryption() called but ignored. Not XB1 compiled. EncryptionData: ", _FixDistance);
			KAFBNOBOIAJ().SetFloat("\n", Ghost_Near);
			HCGJCMDJPGD().SetFloat("_TimeX", Ghost_Far);
			KAFBNOBOIAJ().SetFloat("sfxVolume", GhostWithoutObject);
			ABHDNGIHBKE().SetVector("_MidGrey", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 8f, 858f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
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
		SCShader = Shader.Find("_PColor2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}
}
