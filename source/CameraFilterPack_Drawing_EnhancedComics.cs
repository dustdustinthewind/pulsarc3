// CameraFilterPack_Drawing_EnhancedComics
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Drawing/EnhancedComics")]
[ExecuteInEditMode]
public class CameraFilterPack_Drawing_EnhancedComics : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Material BJFKDHHMLJH;

	[Range(0f, 1f)]
	public float DotSize = 0.15f;

	[Range(0f, 1f)]
	public float _ColorR = 0.9f;

	[Range(0f, 1f)]
	public float _ColorG = 0.4f;

	[Range(0f, 1f)]
	public float _ColorB = 0.4f;

	[Range(0f, 1f)]
	public float _Blood = 0.5f;

	[Range(0f, 1f)]
	public float _SmoothStart = 0.02f;

	[Range(0f, 1f)]
	public float _SmoothEnd = 0.1f;

	public Color ColorRGB = new Color(1f, 0f, 0f);

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

	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 488f)
			{
				HBJJOCHGOPH = 912f;
			}
			DKKBFFHBHJE().SetFloat("_Offsets", HBJJOCHGOPH);
			DOHGBNPMBKG().SetFloat("offsets", DotSize);
			CFEDGDGBCHE().SetFloat("_ScreenResolution", _ColorR);
			DKKBFFHBHJE().SetFloat("_Value5", _ColorG);
			HNICHJCGJOC().SetFloat("B", _ColorB);
			BFGNMFCNDBC().SetFloat(".lastCheckpoint.checkpointsUsed", _Blood);
			NJDIODJNGGA().SetColor("id", ColorRGB);
			DBOLLHHMKKN().SetFloat("id", _SmoothStart);
			OKJOKHGJHGF().SetFloat("editor.", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1329f)
			{
				HBJJOCHGOPH = 1006f;
			}
			FHFLKLMFHOI().SetFloat("Emergency Help:", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("value", DotSize);
			FHFLKLMFHOI().SetFloat("error", _ColorR);
			MCDGIILBNIF().SetFloat("_TimeX", _ColorG);
			NJDIODJNGGA().SetFloat("OpJoinLobby()", _ColorB);
			HNICHJCGJOC().SetFloat("Tab1Content", _Blood);
			NJDIODJNGGA().SetColor("[Up]", ColorRGB);
			CFEDGDGBCHE().SetFloat("_ScreenResolution", _SmoothStart);
			CFEDGDGBCHE().SetFloat("Creating awesome maps", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BJOHDLNDFAD()
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
			if (HBJJOCHGOPH > 405f)
			{
				HBJJOCHGOPH = 1875f;
			}
			NBPKMLMCHFN.SetFloat("#forever", HBJJOCHGOPH);
			EJDPNJAEAKJ().SetFloat("Only the Master Client can AllocateSceneViewID(). Check PhotonNetwork.isMasterClient!", DotSize);
			BFGNMFCNDBC().SetFloat("_Vignetting", _ColorR);
			ACHNOHCLGOO().SetFloat("curScn", _ColorG);
			DBOLLHHMKKN().SetFloat("Tab1Content", _ColorB);
			NJDIODJNGGA().SetFloat("_Red_B", _Blood);
			EFDEIFCDAFG().SetColor("offsets", ColorRGB);
			BFGNMFCNDBC().SetFloat("_LutTex", _SmoothStart);
			ACHNOHCLGOO().SetFloat("#failed!", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 877f)
			{
				HBJJOCHGOPH = 131f;
			}
			DKKBFFHBHJE().SetFloat("Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. ", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("menu.selectedplaymode", DotSize);
			EFDEIFCDAFG().SetFloat("CameraFilterPack/Distortion_Dream", _ColorR);
			NLFJGMBCICG().SetFloat("catched: ", _ColorG);
			AELJLBOJAIL().SetFloat("_VelocityScale", _ColorB);
			DOHGBNPMBKG().SetFloat("_Value4", _Blood);
			HNICHJCGJOC().SetColor("SetEnvSpriteColor", ColorRGB);
			FHFLKLMFHOI().SetFloat("_History2ChromaTex", _SmoothStart);
			NLFJGMBCICG().SetFloat("PhotonView with ID ", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material NLFJGMBCICG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void PKLOBJHKFEO()
	{
		SCShader = Shader.Find("ls");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1175f)
			{
				HBJJOCHGOPH = 1218f;
			}
			ACHNOHCLGOO().SetFloat("/config", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("_MainTex2", DotSize);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Fly_Vision", _ColorR);
			DBOLLHHMKKN().SetFloat("_Green_C", _ColorG);
			EJDPNJAEAKJ().SetFloat("settings.hitvariation", _ColorB);
			EFDEIFCDAFG().SetFloat("TypedLobbyInfo '{0}'[{1}] rooms: {2} players: {3}", _Blood);
			NBPKMLMCHFN.SetColor("\\", ColorRGB);
			AELJLBOJAIL().SetFloat("CameraFilterPack/FX_Dot_Circle", _SmoothStart);
			ACHNOHCLGOO().SetFloat("Prints list of all previous commands", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NFEDLAOPHML()
	{
	}

	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 504f)
			{
				HBJJOCHGOPH = 1270f;
			}
			AELJLBOJAIL().SetFloat("Keypad", HBJJOCHGOPH);
			DOHGBNPMBKG().SetFloat("_TimeX", DotSize);
			BFGNMFCNDBC().SetFloat("Can't find PhotonView of incoming OwnershipRequest. ViewId not found: ", _ColorR);
			DBOLLHHMKKN().SetFloat("player.orangearc", _ColorG);
			MCDGIILBNIF().SetFloat("_Radius2", _ColorB);
			EFDEIFCDAFG().SetFloat("[ResourcesManager] Load audio error: ", _Blood);
			NBPKMLMCHFN.SetColor("Failed to InstantiateSceneObject prefab: ", ColorRGB);
			FHFLKLMFHOI().SetFloat("CameraFilterPack_Atmosphere_Rain_FX", _SmoothStart);
			BFGNMFCNDBC().SetFloat("EnableRankedNotificationsToggle", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EJFJENFKLND()
	{
	}

	private void FDMAEPOHDMK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material OKJOKHGJHGF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)98;
		}
		return BJFKDHHMLJH;
	}

	private void EDBEHEKMGFH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DGCGGKMNPLD()
	{
	}

	private void NJHJHBOJKIC()
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
			if (HBJJOCHGOPH > 341f)
			{
				HBJJOCHGOPH = 1433f;
			}
			MCDGIILBNIF().SetFloat("_Value2", HBJJOCHGOPH);
			NJDIODJNGGA().SetFloat(" TimeOfRespawn: ", DotSize);
			ACHNOHCLGOO().SetFloat("colorD", _ColorR);
			NLFJGMBCICG().SetFloat("_TimeX", _ColorG);
			MCDGIILBNIF().SetFloat("_MainTex", _ColorB);
			ACHNOHCLGOO().SetFloat("settings.enablerankingnotifications", _Blood);
			AELJLBOJAIL().SetColor("{0} months ago", ColorRGB);
			BFGNMFCNDBC().SetFloat("#yes", _SmoothStart);
			NBPKMLMCHFN.SetFloat("OnReadyClick", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MGMAOBPPOBJ()
	{
		SCShader = Shader.Find("settings.shaders.bloomintencity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material EFDEIFCDAFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 449f)
			{
				HBJJOCHGOPH = 858f;
			}
			EFDEIFCDAFG().SetFloat("JITTER", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat(".lastCheckpoint.checkpointsUsed", DotSize);
			NBPKMLMCHFN.SetFloat("_FarCamera", _ColorR);
			FHFLKLMFHOI().SetFloat("shader.ghost", _ColorG);
			DKKBFFHBHJE().SetFloat(" != ", _ColorB);
			EFDEIFCDAFG().SetFloat("value", _Blood);
			NBPKMLMCHFN.SetColor(",viewkeys", ColorRGB);
			ACHNOHCLGOO().SetFloat("maps.", _SmoothStart);
			BFGNMFCNDBC().SetFloat("</color>", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FBPHNEJBDJN()
	{
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FABKIGNFECE()
	{
	}

	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1966f)
			{
				HBJJOCHGOPH = 1702f;
			}
			EFDEIFCDAFG().SetFloat("Bad parameters for init! Use \"init\" or \"init <savename>\"", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("_Distortion", DotSize);
			BFGNMFCNDBC().SetFloat("_TimeX", _ColorR);
			FHFLKLMFHOI().SetFloat("achievements.id", _ColorG);
			NLFJGMBCICG().SetFloat("_ScreenResolution", _ColorB);
			DBOLLHHMKKN().SetFloat("PLAY [SPACE]", _Blood);
			EFDEIFCDAFG().SetColor("_Distortion", ColorRGB);
			CFEDGDGBCHE().SetFloat("2;13;14;15;16", _SmoothStart);
			HNICHJCGJOC().SetFloat("_TreatBackfaceHitAsMiss", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1198f)
			{
				HBJJOCHGOPH = 379f;
			}
			DKKBFFHBHJE().SetFloat("FinishMap", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("#availablechallenges", DotSize);
			DOHGBNPMBKG().SetFloat("float,1", _ColorR);
			DKNJGHFLAIF().SetFloat("_NeutralTonemapperParams1", _ColorG);
			NBPKMLMCHFN.SetFloat("[DiscordController] Join ({0})", _ColorB);
			EJDPNJAEAKJ().SetFloat("[PlayerController] ", _Blood);
			DOHGBNPMBKG().SetColor("AmbientOcclusion", ColorRGB);
			CFEDGDGBCHE().SetFloat("Missing shader in ", _SmoothStart);
			DKKBFFHBHJE().SetFloat("ERROR: Preview file must be <1MB!", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DKKBFFHBHJE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-124);
		}
		return BJFKDHHMLJH;
	}

	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1067f)
			{
				HBJJOCHGOPH = 1714f;
			}
			BFGNMFCNDBC().SetFloat("_Value2", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("true", DotSize);
			HNICHJCGJOC().SetFloat("_QualitySettings", _ColorR);
			CFEDGDGBCHE().SetFloat("_Color", _ColorG);
			EFDEIFCDAFG().SetFloat("Dance", _ColorB);
			MCDGIILBNIF().SetFloat("sfxVolume", _Blood);
			NBPKMLMCHFN.SetColor("Set satellite lerp speed", ColorRGB);
			DKKBFFHBHJE().SetFloat("_Value", _SmoothStart);
			DKNJGHFLAIF().SetFloat("GameScene", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material CFEDGDGBCHE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-101);
		}
		return BJFKDHHMLJH;
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Drawing_EnhancedComics");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IBPAMDEAGJL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1642f)
			{
				HBJJOCHGOPH = 1826f;
			}
			EFDEIFCDAFG().SetFloat("_Value2", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat(".", DotSize);
			BFGNMFCNDBC().SetFloat("_DepthLevel", _ColorR);
			DBOLLHHMKKN().SetFloat("Gameplay/sun", _ColorG);
			DKNJGHFLAIF().SetFloat("BitsData", _ColorB);
			DOHGBNPMBKG().SetFloat(" ", _Blood);
			NBPKMLMCHFN.SetColor("_EmissionGain", ColorRGB);
			ACHNOHCLGOO().SetFloat("not available at the moment", _SmoothStart);
			DOHGBNPMBKG().SetFloat("_Bullet_8", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BMOFEBKGLFI()
	{
		SCShader = Shader.Find("ResetSpeed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IFIHBNJKEKD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1f)
			{
				HBJJOCHGOPH = 1447f;
			}
			NJDIODJNGGA().SetFloat("23x3", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("steamid", DotSize);
			BFGNMFCNDBC().SetFloat("Failed to InstantiateSceneObject prefab:", _ColorR);
			DOHGBNPMBKG().SetFloat("Ev DestroyAll! By PlayerId: ", _ColorG);
			NBPKMLMCHFN.SetFloat(", ", _ColorB);
			DBOLLHHMKKN().SetFloat("_Value3", _Blood);
			NBPKMLMCHFN.SetColor("_ScreenResolution", ColorRGB);
			EJDPNJAEAKJ().SetFloat("Preparing content", _SmoothStart);
			EJDPNJAEAKJ().SetFloat("CameraFilterPack/TV_Rgb", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material NJDIODJNGGA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-108);
		}
		return BJFKDHHMLJH;
	}

	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1799f)
			{
				HBJJOCHGOPH = 259f;
			}
			HNICHJCGJOC().SetFloat("/icon", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("R:", DotSize);
			DKKBFFHBHJE().SetFloat("_TimeX", _ColorR);
			OKJOKHGJHGF().SetFloat("_Value5", _ColorG);
			DOHGBNPMBKG().SetFloat("CurrentTimeLabel", _ColorB);
			HNICHJCGJOC().SetFloat("X", _Blood);
			MCDGIILBNIF().SetColor("CurrentTimeLabel", ColorRGB);
			DBOLLHHMKKN().SetFloat("_Offsets", _SmoothStart);
			BFGNMFCNDBC().SetFloat("Square", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JOPCCCCHNLI()
	{
		SCShader = Shader.Find("76561198041679481");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 824f)
			{
				HBJJOCHGOPH = 428f;
			}
			DKKBFFHBHJE().SetFloat("2hands", HBJJOCHGOPH);
			NJDIODJNGGA().SetFloat("--------------------------------", DotSize);
			EJDPNJAEAKJ().SetFloat("_BlurDistance", _ColorR);
			CFEDGDGBCHE().SetFloat("CameraFilterPack/TV_PlanetMars", _ColorG);
			AELJLBOJAIL().SetFloat("_Level", _ColorB);
			ACHNOHCLGOO().SetFloat("turn: {0:0}", _Blood);
			DBOLLHHMKKN().SetColor("value", ColorRGB);
			AELJLBOJAIL().SetFloat("#ok", _SmoothStart);
			NJDIODJNGGA().SetFloat("_MainTex2", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EJDPNJAEAKJ());
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
			if (HBJJOCHGOPH > 1344f)
			{
				HBJJOCHGOPH = 1377f;
			}
			DBOLLHHMKKN().SetFloat("ticket.ticket1", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("{0}\t is: {1}", DotSize);
			EFDEIFCDAFG().SetFloat(" GO:", _ColorR);
			CFEDGDGBCHE().SetFloat("return CheckCondition()", _ColorG);
			FHFLKLMFHOI().SetFloat("_TimeX", _ColorB);
			MCDGIILBNIF().SetFloat("_VelocityScale", _Blood);
			MCDGIILBNIF().SetColor("_EdgeWeight", ColorRGB);
			NBPKMLMCHFN.SetFloat("Object ID. Case-Sensitive", _SmoothStart);
			AELJLBOJAIL().SetFloat("Tab2Content", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FPHLDMMAOEF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PLBOFEPBPKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1649f)
			{
				HBJJOCHGOPH = 95f;
			}
			CFEDGDGBCHE().SetFloat("remaining: {0:0.000}", HBJJOCHGOPH);
			FHFLKLMFHOI().SetFloat("[Right-Left]", DotSize);
			AELJLBOJAIL().SetFloat("BloodAlternative2", _ColorR);
			DBOLLHHMKKN().SetFloat("_Distortion", _ColorG);
			EFDEIFCDAFG().SetFloat("<b>#", _ColorB);
			DKKBFFHBHJE().SetFloat("ChangeSelectedLevel", _Blood);
			MCDGIILBNIF().SetColor("_Near", ColorRGB);
			DBOLLHHMKKN().SetFloat("int", _SmoothStart);
			EFDEIFCDAFG().SetFloat("#submit", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ACHNOHCLGOO());
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
			if (HBJJOCHGOPH > 1608f)
			{
				HBJJOCHGOPH = 517f;
			}
			DKKBFFHBHJE().SetFloat("Case-Sensitive", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat("CameraFilterPack/FX_superDot", DotSize);
			EFDEIFCDAFG().SetFloat("The observed monobehaviour (", _ColorR);
			DKNJGHFLAIF().SetFloat("mapselector.filter.favoriteonly", _ColorG);
			NBPKMLMCHFN.SetFloat(" [", _ColorB);
			AELJLBOJAIL().SetFloat("id", _Blood);
			NJDIODJNGGA().SetColor("Joystick1Button10", ColorRGB);
			EJDPNJAEAKJ().SetFloat("[LocalizationService] Loading file: ", _SmoothStart);
			DKKBFFHBHJE().SetFloat("Particles/Additive", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1419f)
			{
				HBJJOCHGOPH = 1777f;
			}
			HNICHJCGJOC().SetFloat("_TimeX", HBJJOCHGOPH);
			FHFLKLMFHOI().SetFloat("VIGNETTE_BLUR", DotSize);
			OKJOKHGJHGF().SetFloat("<b>#", _ColorR);
			NJDIODJNGGA().SetFloat("_ScreenResolution", _ColorG);
			HNICHJCGJOC().SetFloat("#md5submitionfailed: ", _ColorB);
			ACHNOHCLGOO().SetFloat("EnvironmentSlider", _Blood);
			FHFLKLMFHOI().SetColor("hidden", ColorRGB);
			EJDPNJAEAKJ().SetFloat("#,0", _SmoothStart);
			OKJOKHGJHGF().SetFloat("mapselector.filter.subscribedonly", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GNMGIHFKJIJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JOONHGHGKKF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material AELJLBOJAIL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-95);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material EJDPNJAEAKJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void MJNPIDGNJMK()
	{
	}

	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 896f)
			{
				HBJJOCHGOPH = 193f;
			}
			HNICHJCGJOC().SetFloat("1,30,true,0", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("Set Satellite Input", DotSize);
			AELJLBOJAIL().SetFloat("_Value2", _ColorR);
			HNICHJCGJOC().SetFloat("<color=#{0}>{1}</color>", _ColorG);
			DOHGBNPMBKG().SetFloat("CameraFilterPack/Blend2Camera_Exclusion", _ColorB);
			MCDGIILBNIF().SetFloat("ViewMenu", _Blood);
			OKJOKHGJHGF().SetColor("_Intensity", ColorRGB);
			NJDIODJNGGA().SetFloat("UseScanLine", _SmoothStart);
			FHFLKLMFHOI().SetFloat("#close", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LOMDIOLNFHI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material DKNJGHFLAIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-113);
		}
		return BJFKDHHMLJH;
	}

	private void PMPKMGKAAJH()
	{
		SCShader = Shader.Find("%");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1329f)
			{
				HBJJOCHGOPH = 1863f;
			}
			EFDEIFCDAFG().SetFloat("settings.enablehitsoundsinnormal", HBJJOCHGOPH);
			OKJOKHGJHGF().SetFloat("GhostFade", DotSize);
			NBPKMLMCHFN.SetFloat("FullscreenToggle", _ColorR);
			NBPKMLMCHFN.SetFloat("maps.", _ColorG);
			HNICHJCGJOC().SetFloat("_Gain", _ColorB);
			EJDPNJAEAKJ().SetFloat("_Far", _Blood);
			DKNJGHFLAIF().SetColor(".lastCheckpoint.playerdistance", ColorRGB);
			DKKBFFHBHJE().SetFloat("_ScreenResolution", _SmoothStart);
			DKKBFFHBHJE().SetFloat("Working.\nPlease wait..", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NAOLAJPDGIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HMNLHMLILKD()
	{
	}

	private void LADCJEIALMH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MJEFMIPLFAB()
	{
		SCShader = Shader.Find("AudioSampler");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1345f)
			{
				HBJJOCHGOPH = 762f;
			}
			HNICHJCGJOC().SetFloat("player.watermelon", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("DestroyPlayerObjects() failed, cause players can only destroy their own GameObjects. A Master Client can destroy anyone's. This is master: ", DotSize);
			DKNJGHFLAIF().SetFloat("Joystick1Button8", _ColorR);
			OKJOKHGJHGF().SetFloat("CameraFilterPack/Drawing_Paper3", _ColorG);
			EFDEIFCDAFG().SetFloat("1427616858", _ColorB);
			EFDEIFCDAFG().SetFloat("</color>", _Blood);
			NJDIODJNGGA().SetColor("_Value2", ColorRGB);
			NJDIODJNGGA().SetFloat("Hex value #RRGGBB", _SmoothStart);
			BFGNMFCNDBC().SetFloat("TestTicket", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
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

	[SpecialName]
	private Material ACHNOHCLGOO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)95;
		}
		return BJFKDHHMLJH;
	}

	private void JBNPEHMDCMI()
	{
	}

	private void GCHBGCGBMCK()
	{
	}

	[SpecialName]
	private Material HNICHJCGJOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-102);
		}
		return BJFKDHHMLJH;
	}

	private void JKFDDNMPOJH()
	{
		SCShader = Shader.Find("getbool");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material MCDGIILBNIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void KKEOHFGKCIK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KLOLKEBAPFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OKLAJINHPAN()
	{
		SCShader = Shader.Find("ResourceFileSelector");
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
			NBPKMLMCHFN.SetFloat("_DotSize", DotSize);
			NBPKMLMCHFN.SetFloat("_ColorR", _ColorR);
			NBPKMLMCHFN.SetFloat("_ColorG", _ColorG);
			NBPKMLMCHFN.SetFloat("_ColorB", _ColorB);
			NBPKMLMCHFN.SetFloat("_Blood", _Blood);
			NBPKMLMCHFN.SetColor("_ColorRGB", ColorRGB);
			NBPKMLMCHFN.SetFloat("_SmoothStart", _SmoothStart);
			NBPKMLMCHFN.SetFloat("_SmoothEnd", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	private void HMPGIFBJFIK()
	{
		SCShader = Shader.Find(".completedCount");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1486f)
			{
				HBJJOCHGOPH = 315f;
			}
			ACHNOHCLGOO().SetFloat("Called GetNumberOfCurrentPlayers()", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("[#clicktogetreward]", DotSize);
			MCDGIILBNIF().SetFloat("Tab2Content", _ColorR);
			EFDEIFCDAFG().SetFloat("The other scroll rect doesnt support scrolling horizontally", _ColorG);
			ACHNOHCLGOO().SetFloat("float,1.5", _ColorB);
			CFEDGDGBCHE().SetFloat("icon", _Blood);
			EFDEIFCDAFG().SetColor(" with prefix ", ColorRGB);
			DBOLLHHMKKN().SetFloat("GLITCH", _SmoothStart);
			NLFJGMBCICG().SetFloat("ComboScoreText", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NKLIHNJCHOG()
	{
	}

	private void CCLNNLCOPBL()
	{
		SCShader = Shader.Find("CameraFilterPack/RainFX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material FHFLKLMFHOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1447f)
			{
				HBJJOCHGOPH = 1449f;
			}
			ACHNOHCLGOO().SetFloat("[MapsData] Workshop maps was loaded", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("USE_CORNER_DETECTION", DotSize);
			DBOLLHHMKKN().SetFloat("_Bullet_11", _ColorR);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Drawing_Toon", _ColorG);
			DOHGBNPMBKG().SetFloat("_Blue_R", _ColorB);
			NJDIODJNGGA().SetFloat("maps.", _Blood);
			DKNJGHFLAIF().SetColor("_ScreenResolution", ColorRGB);
			DKNJGHFLAIF().SetFloat("_ReflectionBufferSize", _SmoothStart);
			NBPKMLMCHFN.SetFloat(": ", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 179f)
			{
				HBJJOCHGOPH = 1549f;
			}
			DKNJGHFLAIF().SetFloat("#yes", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat("settings.gamemessagesduration", DotSize);
			DKNJGHFLAIF().SetFloat("_Speed", _ColorR);
			NLFJGMBCICG().SetFloat("[NetworkManager] Connection failed: ", _ColorG);
			NBPKMLMCHFN.SetFloat("_Value12", _ColorB);
			CFEDGDGBCHE().SetFloat("_Value", _Blood);
			DKKBFFHBHJE().SetColor(" PhotonView: ", ColorRGB);
			EJDPNJAEAKJ().SetFloat("#savemapbeforeuploading", _SmoothStart);
			NJDIODJNGGA().SetFloat("settings.fps", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LBPHCAMMAPB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CNGAJDBOCLJ()
	{
		SCShader = Shader.Find("USE_CORNER_DETECTION");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OCMKCBBCEFG()
	{
	}

	private void DAHFFNNIGML()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 353f)
			{
				HBJJOCHGOPH = 1873f;
			}
			AELJLBOJAIL().SetFloat("OPEN", HBJJOCHGOPH);
			OKJOKHGJHGF().SetFloat("history", DotSize);
			EJDPNJAEAKJ().SetFloat("player.xp", _ColorR);
			CFEDGDGBCHE().SetFloat("IconImage", _ColorG);
			AELJLBOJAIL().SetFloat(" isOwnerActive: ", _ColorB);
			DBOLLHHMKKN().SetFloat("_Value3", _Blood);
			EFDEIFCDAFG().SetColor("_TimeX", ColorRGB);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", _SmoothStart);
			DKKBFFHBHJE().SetFloat("#,0.00", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-87);
		}
		return BJFKDHHMLJH;
	}

	private void LIBGAKMKHJJ()
	{
		SCShader = Shader.Find("DestroyRpc");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 862f)
			{
				HBJJOCHGOPH = 1308f;
			}
			DKNJGHFLAIF().SetFloat("Attempting to remove texture that was not allocated: {0}", HBJJOCHGOPH);
			OKJOKHGJHGF().SetFloat("ready", DotSize);
			DOHGBNPMBKG().SetFloat("There is already a virtual axis named ", _ColorR);
			AELJLBOJAIL().SetFloat("Hidden/Image Effects/Cinematic/AmbientOcclusion", _ColorG);
			EJDPNJAEAKJ().SetFloat("#yes", _ColorB);
			HNICHJCGJOC().SetFloat("https://steamcommunity.com/sharedfiles/filedetails/?id=", _Blood);
			HNICHJCGJOC().SetColor("settings.arcsnohitsoundtimedelay", ColorRGB);
			BFGNMFCNDBC().SetFloat("team", _SmoothStart);
			BFGNMFCNDBC().SetFloat("_Fade", _SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EGEGNHLODAA()
	{
	}
}
