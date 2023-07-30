// CameraFilterPack_Distortion_BlackHole
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Distortion/BlackHole")]
[ExecuteInEditMode]
public class CameraFilterPack_Distortion_BlackHole : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(-1f, 1f)]
	public float PositionX;

	[Range(-1f, 1f)]
	public float PositionY;

	[Range(-5f, 5f)]
	public float Size = 0.05f;

	[Range(0f, 180f)]
	public float Distortion = 30f;

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

	private void LBPHCAMMAPB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HDMDKOKOOJC()
	{
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FGBDGGCBFLP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material LPDOGGFOBDH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)66;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material JFDGLLEOPGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-69);
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

	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1270f)
			{
				HBJJOCHGOPH = 1135f;
			}
			JFDGLLEOPGB().SetFloat("Color", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("x", PositionX);
			NFMGLIKNOOC().SetFloat("_ScreenResolution", PositionY);
			JFDGLLEOPGB().SetFloat("AudioSampler", Size);
			CEKJODEAMGB().SetFloat("public", Distortion);
			EMDFHOKEGNG().SetVector("#exitmapeditor", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
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

	private void HLDFOJMHKNL()
	{
	}

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 633f)
			{
				HBJJOCHGOPH = 1416f;
			}
			ACHNOHCLGOO().SetFloat("[PlayerBase] Got checkpoint at ", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat(".icon", PositionX);
			NBPKMLMCHFN.SetFloat("shader.pixel", PositionY);
			EMDFHOKEGNG().SetFloat("_Value2", Size);
			DNLMFEGJJDD().SetFloat("_PrevViewProj", Distortion);
			BFGNMFCNDBC().SetVector("Submition failed", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CEKJODEAMGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FDMAEPOHDMK()
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

	private void DNENFLNCIJP()
	{
	}

	[SpecialName]
	private Material IGIAPKPKGPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)120;
		}
		return BJFKDHHMLJH;
	}

	private void JNGMIAFLBDL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MGFFNGEGFDC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 34f)
			{
				HBJJOCHGOPH = 948f;
			}
			NBPKMLMCHFN.SetFloat("_Value2", HBJJOCHGOPH);
			GJHLADDCMFF().SetFloat(": ", PositionX);
			EFDEIFCDAFG().SetFloat("offsets", PositionY);
			NBPKMLMCHFN.SetFloat("_TimeX", Size);
			LDNADDJMIPK().SetFloat("ReconnectAndRejoin() disabled the offline mode. No longer offline.", Distortion);
			BFGNMFCNDBC().SetVector("player.redabstract", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1618f)
			{
				HBJJOCHGOPH = 124f;
			}
			IGIAPKPKGPK().SetFloat(" - ", HBJJOCHGOPH);
			JLHLHKPHDFO().SetFloat("LevelNameInputField", PositionX);
			JIBOKBCPDLC().SetFloat("[Up-Down]", PositionY);
			PGPEMMBJOOG().SetFloat("player.quantum", Size);
			EFDEIFCDAFG().SetFloat("_MainTex2", Distortion);
			BFGNMFCNDBC().SetVector(" : ", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MJNPIDGNJMK()
	{
	}

	private void GPHPJIDGEPI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material ADGHJOHKEHG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void IFJDKDFLGBG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material BFGNMFCNDBC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-116);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material GCDFNHMJMIP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void KCDOMIJBFLL()
	{
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 439f)
			{
				HBJJOCHGOPH = 1350f;
			}
			GJHLADDCMFF().SetFloat("Couldn't call DestroyAll() as only the master client is allowed to call this.", HBJJOCHGOPH);
			IGIAPKPKGPK().SetFloat(".sawoutdatedmessage", PositionX);
			JIBOKBCPDLC().SetFloat("Horizontal", PositionY);
			IGIAPKPKGPK().SetFloat("_ScreenResolution", Size);
			FEAEGGCNIAA().SetFloat("PlayButton", Distortion);
			CEKJODEAMGB().SetVector("Scene", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PKLOBJHKFEO()
	{
		SCShader = Shader.Find("_CutOff");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1842f)
			{
				HBJJOCHGOPH = 58f;
			}
			KGOLDDBHIFN().SetFloat("_Distortion", HBJJOCHGOPH);
			ADGHJOHKEHG().SetFloat("_VignettingColor", PositionX);
			GCDFNHMJMIP().SetFloat("_Value", PositionY);
			LPDOGGFOBDH().SetFloat("Error: I/O Failure! :(", Size);
			IGIAPKPKGPK().SetFloat("_TimeX", Distortion);
			PGPEMMBJOOG().SetVector("Cross", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material ABHDNGIHBKE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material JLHLHKPHDFO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)125;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material DNLMFEGJJDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NFMGLIKNOOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material CEKJODEAMGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material ACHNOHCLGOO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void CCPEDDLAMIB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material EMDFHOKEGNG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)70;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material GJHLADDCMFF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave;
		}
		return BJFKDHHMLJH;
	}

	private void POJFHDFJOPE()
	{
	}

	private void PLIKADJCEPO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material DONENAMLFLF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material FEAEGGCNIAA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1999f)
			{
				HBJJOCHGOPH = 684f;
			}
			NFMGLIKNOOC().SetFloat("MenuVolumeSlider", HBJJOCHGOPH);
			GCDFNHMJMIP().SetFloat("CameraFilterPack/Color_GrayScale", PositionX);
			BFGNMFCNDBC().SetFloat("BitsData", PositionY);
			LDNADDJMIPK().SetFloat("AskForPickupItemSpawnTimes", Size);
			JFDGLLEOPGB().SetFloat("1159514800", Distortion);
			DONENAMLFLF().SetVector("_Distortion", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 134f)
			{
				HBJJOCHGOPH = 1415f;
			}
			NFMGLIKNOOC().SetFloat("player.licenceaccepted", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("_Value4", PositionX);
			DNLMFEGJJDD().SetFloat(":", PositionY);
			CEKJODEAMGB().SetFloat(".mp3", Size);
			DONENAMLFLF().SetFloat("JoinOrCreateRoom failed. In offline mode you still have to leave a room to enter another.", Distortion);
			EMDFHOKEGNG().SetVector("RoomNameText", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ICILLMAKLMI()
	{
		SCShader = Shader.Find("steamid");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LMADKINICIN()
	{
	}

	private void NFEDLAOPHML()
	{
	}

	private void FOMNCPKKCFN()
	{
	}

	[SpecialName]
	private Material LDNADDJMIPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1295f)
			{
				HBJJOCHGOPH = 5f;
			}
			ABHDNGIHBKE().SetFloat("_ColorLevel", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("_Value", PositionX);
			LPDOGGFOBDH().SetFloat("LB", PositionY);
			ACHNOHCLGOO().SetFloat("#no", Size);
			DONENAMLFLF().SetFloat("PlayButton", Distortion);
			GJHLADDCMFF().SetVector("NEW_ACHIEVEMENT_1_", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material JIBOKBCPDLC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)109;
		}
		return BJFKDHHMLJH;
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Distortion_BlackHole");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IDIIELPAMCJ()
	{
	}

	private void NEKCPLGFOFD()
	{
	}

	private void NDAJBJFJGCF()
	{
	}

	private void IKIDIJLIGOH()
	{
	}

	private void IEMEHGCFAPD()
	{
	}

	private void DFENCIHAADO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Update()
	{
	}

	private void PAKPHKPDKGE()
	{
		SCShader = Shader.Find("There are a few rules that you must accept before submitting your work. Please select \"RULES\" button, if you haven't read them yet.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MFLBEJHMEMO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JMEOGJHCONJ()
	{
		SCShader = Shader.Find("PhotonServerSettings");
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

	private void NAALCEPIHCH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 6f)
			{
				HBJJOCHGOPH = 1695f;
			}
			LDNADDJMIPK().SetFloat("_ColorG", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("score", PositionX);
			CEKJODEAMGB().SetFloat("id", PositionY);
			JLHLHKPHDFO().SetFloat("_ReflectionBufferSize", Size);
			ACHNOHCLGOO().SetFloat("entering", Distortion);
			LDNADDJMIPK().SetVector("_Value4", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LCJHDLKJEOM()
	{
	}

	private void JAAJECBCCFM()
	{
	}

	[SpecialName]
	private Material OGMEGHKECAH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 665f)
			{
				HBJJOCHGOPH = 322f;
			}
			EFDEIFCDAFG().SetFloat("Added event", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("EndlessLoopsScoreText", PositionX);
			LPDOGGFOBDH().SetFloat("?", PositionY);
			NFMGLIKNOOC().SetFloat("_Value2", Size);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Blend2Camera_Color", Distortion);
			EMDFHOKEGNG().SetVector("masterVolume", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JDGFCEPDKAJ()
	{
	}

	[SpecialName]
	private Material PGPEMMBJOOG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-73);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KGOLDDBHIFN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)75;
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

	private void HLLHJIDOOGA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BMODOIJGIOO()
	{
	}

	private void JOACBIEHHCE()
	{
	}

	[SpecialName]
	private Material EFDEIFCDAFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-128);
		}
		return BJFKDHHMLJH;
	}

	private void DOEPOGLEGLE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1012f)
			{
				HBJJOCHGOPH = 367f;
			}
			DNLMFEGJJDD().SetFloat("EventConfigButton", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("_MidGrey", PositionX);
			IGIAPKPKGPK().SetFloat("_TimeX", PositionY);
			JFDGLLEOPGB().SetFloat("_Value2", Size);
			KGOLDDBHIFN().SetFloat("NetworkPeer broke!", Distortion);
			GCDFNHMJMIP().SetVector("ScrollPanel", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
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
			if (HBJJOCHGOPH > 817f)
			{
				HBJJOCHGOPH = 194f;
			}
			ADGHJOHKEHG().SetFloat(",", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("CameraFilterPack/Edge_Neon", PositionX);
			GCDFNHMJMIP().SetFloat("_MainTex2", PositionY);
			KGOLDDBHIFN().SetFloat("maps.", Size);
			JFDGLLEOPGB().SetFloat("solo", Distortion);
			ACHNOHCLGOO().SetVector("Left Stick Click", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 194f)
			{
				HBJJOCHGOPH = 157f;
			}
			FEAEGGCNIAA().SetFloat(".lastCheckpoint.playerdistance", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("PhotonView ID duplicate found: {0}. New: {1} old: {2}. Maybe one wasn't destroyed on scene load?! Check for 'DontDestroyOnLoad'. Destroying old entry, adding new.", PositionX);
			CEKJODEAMGB().SetFloat("?", PositionY);
			OGMEGHKECAH().SetFloat("_Color_R", Size);
			ACHNOHCLGOO().SetFloat("_TimeX", Distortion);
			LPDOGGFOBDH().SetVector("player.dragon", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
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
			NBPKMLMCHFN.SetFloat("_PositionX", PositionX);
			NBPKMLMCHFN.SetFloat("_PositionY", PositionY);
			NBPKMLMCHFN.SetFloat("_Distortion", Size);
			NBPKMLMCHFN.SetFloat("_Distortion2", Distortion);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CFFCLAHMBAA()
	{
		SCShader = Shader.Find("GameScene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}
}
