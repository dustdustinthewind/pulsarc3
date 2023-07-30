// CameraFilterPack_Pixelisation_OilPaint
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Pixelisation/OilPaint")]
public class CameraFilterPack_Pixelisation_OilPaint : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 5f)]
	public float Value = 1f;

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

	private void GPFJMKCGHGB()
	{
	}

	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 823f)
			{
				HBJJOCHGOPH = 204f;
			}
			ACHNOHCLGOO().SetFloat("FrostCanvas", HBJJOCHGOPH);
			CFEDGDGBCHE().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1137f, 1421f));
			GCDFNHMJMIP().SetFloat("00", Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FKEJGBFDCAH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DKOPKPBLDHH()
	{
		SCShader = Shader.Find("Item invalid. Make sure your mod contains at leats one file.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 796f)
			{
				HBJJOCHGOPH = 653f;
			}
			GCDFNHMJMIP().SetFloat("_RandomTexture", HBJJOCHGOPH);
			FEAEGGCNIAA().SetVector(".mp3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1076f, 957f));
			KBOPGONOCNP().SetFloat("_Value4", Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JKFDDNMPOJH()
	{
		SCShader = Shader.Find(":");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JOACBIEHHCE()
	{
	}

	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1442f)
			{
				HBJJOCHGOPH = 1194f;
			}
			LONNIJMNKFB().SetFloat("_Red_C", HBJJOCHGOPH);
			GCDFNHMJMIP().SetVector("SetEnvSpriteImage", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1915f, 1874f));
			NBPKMLMCHFN.SetFloat("/", Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NDAJBJFJGCF()
	{
	}

	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 811f)
			{
				HBJJOCHGOPH = 188f;
			}
			AELJLBOJAIL().SetFloat("No player left to ask", HBJJOCHGOPH);
			KEMJNOMIPHN().SetVector(" ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1305f, 1489f));
			LDNADDJMIPK().SetFloat("_Value2", Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-77);
		}
		return BJFKDHHMLJH;
	}

	private void KLILJHJNICK()
	{
		SCShader = Shader.Find("CameraFilterPack/FX_Dot_Circle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 337f)
			{
				HBJJOCHGOPH = 324f;
			}
			KBOPGONOCNP().SetFloat("#timeuntilend: ", HBJJOCHGOPH);
			KBOPGONOCNP().SetVector("_Value7", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 580f, 46f));
			ACHNOHCLGOO().SetFloat("SingleplayerButton", Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
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
			if (HBJJOCHGOPH > 69f)
			{
				HBJJOCHGOPH = 653f;
			}
			FEAEGGCNIAA().SetFloat("Received your NickName from server. Updating local value to: {0}", HBJJOCHGOPH);
			NBPKMLMCHFN.SetVector("OpSetPropertiesOfActor not sent. ActorNr must be > 0 and actorProperties != null.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1043f, 811f));
			LONNIJMNKFB().SetFloat("_TimeX", Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OMCLOFCJMPG()
	{
	}

	private void LIEGJOHINGC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BGDPIHMAACO()
	{
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OCCGJMPAJIK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1559f)
			{
				HBJJOCHGOPH = 1525f;
			}
			AELJLBOJAIL().SetFloat("CameraFilterPack/TV_VHS", HBJJOCHGOPH);
			CFEDGDGBCHE().SetVector("[PlayerController] ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1035f, 1074f));
			FEAEGGCNIAA().SetFloat("AddEnvironmentObject", Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HNICHJCGJOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)91;
		}
		return BJFKDHHMLJH;
	}

	private void HONBLGFDMLL()
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1121f)
			{
				HBJJOCHGOPH = 1475f;
			}
			KEMJNOMIPHN().SetFloat("_ThirdTex", HBJJOCHGOPH);
			KEMJNOMIPHN().SetVector("_Colorisation", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 849f, 1470f));
			CFEDGDGBCHE().SetFloat("MascotChallenge2019", Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KNBJBNDGCIJ()
	{
		SCShader = Shader.Find("Trackpad");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OHFOLGANOLC()
	{
		SCShader = Shader.Find("Folk");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LCJHDLKJEOM()
	{
	}

	private void Update()
	{
	}

	[SpecialName]
	private Material LDNADDJMIPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
		}
		return BJFKDHHMLJH;
	}

	private void HLIAEEMGBHN()
	{
		SCShader = Shader.Find("_Glitch");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1891f)
			{
				HBJJOCHGOPH = 151f;
			}
			NBPKMLMCHFN.SetFloat("[LevelEditorScene] Map submitted!", HBJJOCHGOPH);
			GCDFNHMJMIP().SetVector("[PlayerBase] SpawnObj error: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1998f, 287f));
			CFEDGDGBCHE().SetFloat("Joystick1Button8", Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AGMJDGHLBMN()
	{
	}

	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1670f)
			{
				HBJJOCHGOPH = 97f;
			}
			AELJLBOJAIL().SetFloat("CameraFilterPack/FX_Mirror", HBJJOCHGOPH);
			HNICHJCGJOC().SetVector("Created", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1472f, 745f));
			LDNADDJMIPK().SetFloat("Tab2Content", Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material ACHNOHCLGOO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1662f)
			{
				HBJJOCHGOPH = 1887f;
			}
			LONNIJMNKFB().SetFloat("_Speed", HBJJOCHGOPH);
			LONNIJMNKFB().SetVector("From {0} at Index {1} \n", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 428f, 1054f));
			HNICHJCGJOC().SetFloat("CreateRoom failed, client stays on masterserver: {0}.", Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
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
			if (HBJJOCHGOPH > 1678f)
			{
				HBJJOCHGOPH = 1381f;
			}
			LONNIJMNKFB().SetFloat("_TimeX", HBJJOCHGOPH);
			CFEDGDGBCHE().SetVector("_Extra3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1125f, 1662f));
			LONNIJMNKFB().SetFloat("AllocateViewID() failed. Room (user {0}) is out of 'scene' viewIDs. It seems all available are in use.", Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BMOFEBKGLFI()
	{
		SCShader = Shader.Find("_Near");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material KEMJNOMIPHN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)89;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material LONNIJMNKFB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-106);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material CFEDGDGBCHE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave;
		}
		return BJFKDHHMLJH;
	}

	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 246f)
			{
				HBJJOCHGOPH = 1927f;
			}
			CFEDGDGBCHE().SetFloat("CameraFilterPack/Distortion_Half_Sphere", HBJJOCHGOPH);
			CFEDGDGBCHE().SetVector("Set Sun Colors", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1513f, 327f));
			AELJLBOJAIL().SetFloat(" not exist", Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material GCDFNHMJMIP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-92);
		}
		return BJFKDHHMLJH;
	}

	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1935f)
			{
				HBJJOCHGOPH = 1340f;
			}
			HNICHJCGJOC().SetFloat("player.currentrank", HBJJOCHGOPH);
			KBOPGONOCNP().SetVector("[DiscordController] Join ({0})", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1319f, 1553f));
			LDNADDJMIPK().SetFloat("_Offsets", Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NKLIHNJCHOG()
	{
	}

	[SpecialName]
	private Material FEAEGGCNIAA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	private void OCMKCBBCEFG()
	{
	}

	private void BMODOIJGIOO()
	{
	}

	private void FBMDHDBELEK()
	{
	}

	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1271f)
			{
				HBJJOCHGOPH = 1675f;
			}
			LONNIJMNKFB().SetFloat("bad", HBJJOCHGOPH);
			FEAEGGCNIAA().SetVector("SetPosition", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 196f, 1196f));
			GCDFNHMJMIP().SetFloat("_MainTex2", Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
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

	private void NEKCPLGFOFD()
	{
	}

	private void OFIMMFHFHDD()
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
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			NBPKMLMCHFN.SetFloat("_Value", Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AIJGAJIOJDJ()
	{
	}

	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1500f)
			{
				HBJJOCHGOPH = 1131f;
			}
			NBPKMLMCHFN.SetFloat("Failed to InstantiateSceneObject prefab: ", HBJJOCHGOPH);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 241f, 1998f));
			FEAEGGCNIAA().SetFloat(").", Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Pixelisation_OilPaint");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KCCIEMBMOBA()
	{
		SCShader = Shader.Find("_CenterY");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
