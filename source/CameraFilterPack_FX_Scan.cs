// CameraFilterPack_FX_Scan
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/FX/Scan")]
public class CameraFilterPack_FX_Scan : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0.001f, 0.1f)]
	public float Size = 0.025f;

	[Range(0f, 10f)]
	public float Speed = 1f;

	[Range(0f, 10f)]
	private float ILHJFHFPGBB = 1f;

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

	private void FBPHNEJBDJN()
	{
		SCShader = Shader.Find("{\"items\":");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IFJDKDFLGBG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1796f)
			{
				HBJJOCHGOPH = 934f;
			}
			HFBJAOFLCJI().SetFloat("PhotonView register is ignored, because viewID is 0. No id assigned yet to: ", HBJJOCHGOPH);
			LENEJAGLCNL().SetFloat("[SERVER] Kicked ", Size);
			HKGAONMOBMH().SetFloat("[ERROR KEY {0}]", Speed);
			IGKFMCPDNOI().SetFloat("FinalScoreSmallText", ILHJFHFPGBB);
			PLBEJJIHFPB().SetFloat("\nv.", CCIENBFIKKH);
			GHHPOGODBHB().SetVector("\nv.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 643f, 1119f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 793f)
			{
				HBJJOCHGOPH = 1898f;
			}
			PLBEJJIHFPB().SetFloat("_TimeX", HBJJOCHGOPH);
			LENEJAGLCNL().SetFloat("note.4", Size);
			NBPKMLMCHFN.SetFloat("source", Speed);
			ADGHJOHKEHG().SetFloat("(\\[ *h1 *\\])", ILHJFHFPGBB);
			EJDPNJAEAKJ().SetFloat("player.playedtutorial", CCIENBFIKKH);
			OIMMPLPBLBK().SetVector("wss://", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1074f, 1896f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JHLGHODFJOO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 37f)
			{
				HBJJOCHGOPH = 1473f;
			}
			PDEAHJPOMEF().SetFloat("float,0", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat(":", Size);
			FAIFBBGFAIB().SetFloat("RequestSelectedLevel", Speed);
			DNLMFEGJJDD().SetFloat("_NoiseTex", ILHJFHFPGBB);
			EJDPNJAEAKJ().SetFloat("CameraFilterPack_Paper4", CCIENBFIKKH);
			BFGNMFCNDBC().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1286f, 11f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material IGKFMCPDNOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material DNLMFEGJJDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)123;
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

	[SpecialName]
	private Material GHHPOGODBHB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1910f)
			{
				HBJJOCHGOPH = 1842f;
			}
			HKGAONMOBMH().SetFloat("#failed: ", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Reset XP", Size);
			HHIAIGCAHDA().SetFloat("Join failed on GameServer. Changing back to MasterServer. Msg: ", Speed);
			DNLMFEGJJDD().SetFloat("\\", ILHJFHFPGBB);
			FLOHGDECHHH().SetFloat("Fade", CCIENBFIKKH);
			LONNIJMNKFB().SetVector("_Circle", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1300f, 311f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GAOOPEEBGJA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Update()
	{
	}

	private void FDPOFMCFBMF()
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
			if (HBJJOCHGOPH > 1900f)
			{
				HBJJOCHGOPH = 1145f;
			}
			LONNIJMNKFB().SetFloat("[MapsStats] Difficulty: ", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat("EnableRankingToggle", Size);
			HKGAONMOBMH().SetFloat("[PlayerController] ", Speed);
			NBPKMLMCHFN.SetFloat("seconds", ILHJFHFPGBB);
			HHIAIGCAHDA().SetFloat("Error: You're not logged into Steam!", CCIENBFIKKH);
			LENEJAGLCNL().SetVector("EnableRankingToggle", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 635f, 299f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material PLBEJJIHFPB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)106;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material BKKJJJGADLM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)98;
		}
		return BJFKDHHMLJH;
	}

	private void FBMDHDBELEK()
	{
	}

	private void NNFMIAFHMJM()
	{
		SCShader = Shader.Find("OpGetGameList not sent. Lobby cannot be null.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NJHJHBOJKIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material FAIFBBGFAIB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return BJFKDHHMLJH;
	}

	private void KLILJHJNICK()
	{
		SCShader = Shader.Find("_Intensity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OFPPIKHNJOD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PAKPHKPDKGE()
	{
		SCShader = Shader.Find("Submit");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KFACDBHDAOD()
	{
	}

	private void LECCHIAFGGE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EGEPLFGKGLI()
	{
		SCShader = Shader.Find("CreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.");
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
			if (HBJJOCHGOPH > 1969f)
			{
				HBJJOCHGOPH = 925f;
			}
			IGKFMCPDNOI().SetFloat("Please attach component to a Graphical UI component", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("<b><i>Map's Stats:</i></b>", Size);
			NBPKMLMCHFN.SetFloat("_Value3", Speed);
			GHHPOGODBHB().SetFloat("settings.shaders.bloomintencity", ILHJFHFPGBB);
			NBPKMLMCHFN.SetFloat("AVG Misses:", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector(" (", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 313f, 225f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FABMDEHEDNO()
	{
	}

	private void NPLCENPNJBM()
	{
		SCShader = Shader.Find("CameraFilterPack/AAA_Blood_Plus");
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

	private void BEBNOKFLJPH()
	{
		SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KNBJBNDGCIJ()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material ADGHJOHKEHG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void COIJKMKIEAK()
	{
		SCShader = Shader.Find("<b>#");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material HFBJAOFLCJI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-121);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material OIMMPLPBLBK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 376f)
			{
				HBJJOCHGOPH = 1198f;
			}
			PDEAHJPOMEF().SetFloat("maps.", HBJJOCHGOPH);
			LENEJAGLCNL().SetFloat("Mouse Y", Size);
			DNLMFEGJJDD().SetFloat("Tab1Content", Speed);
			FLOHGDECHHH().SetFloat("CameraFilterPack/Glasses_OnX", ILHJFHFPGBB);
			PGPEMMBJOOG().SetFloat("LoadMapCanvas", CCIENBFIKKH);
			PLBEJJIHFPB().SetVector("offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 132f, 1907f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 224f)
			{
				HBJJOCHGOPH = 1754f;
			}
			EJDPNJAEAKJ().SetFloat("_TimeX", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("_EmissionColor", Size);
			HHIAIGCAHDA().SetFloat("/Saved Games/", Speed);
			BFGNMFCNDBC().SetFloat("restrictions", ILHJFHFPGBB);
			FLOHGDECHHH().SetFloat("_Value2", CCIENBFIKKH);
			FAIFBBGFAIB().SetVector("_SizeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 675f, 1611f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HHIAIGCAHDA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void HMPGIFBJFIK()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material KOHGPKOFEJO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)95;
		}
		return BJFKDHHMLJH;
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/FX_Scan");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material LENEJAGLCNL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)91;
		}
		return BJFKDHHMLJH;
	}

	private void MFLBEJHMEMO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HKGAONMOBMH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void FMNPFCHBLJF()
	{
		SCShader = Shader.Find(".highscore");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1500f)
			{
				HBJJOCHGOPH = 877f;
			}
			DNLMFEGJJDD().SetFloat("CameraFilterPack/Blend2Camera_Difference", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("sprite", Size);
			LENEJAGLCNL().SetFloat("FavoriteButton", Speed);
			GHHPOGODBHB().SetFloat("There is already a virtual button named ", ILHJFHFPGBB);
			HFBJAOFLCJI().SetFloat(", ", CCIENBFIKKH);
			BFGNMFCNDBC().SetVector("Coord", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1846f, 1619f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JMEOGJHCONJ()
	{
		SCShader = Shader.Find("settings.gamemessagesduration");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1130f)
			{
				HBJJOCHGOPH = 587f;
			}
			LENEJAGLCNL().SetFloat("CameraFilterPack/Distortion_Flag", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("_Value", Size);
			DNLMFEGJJDD().SetFloat(".played", Speed);
			HFBJAOFLCJI().SetFloat("Gameplay/Base", ILHJFHFPGBB);
			EJDPNJAEAKJ().SetFloat("-", CCIENBFIKKH);
			LONNIJMNKFB().SetVector("Best region found in PlayerPrefs. Connecting to: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 120f, 1584f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material EJDPNJAEAKJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-78);
		}
		return BJFKDHHMLJH;
	}

	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 48f)
			{
				HBJJOCHGOPH = 799f;
			}
			BKKJJJGADLM().SetFloat("Show Image", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("maps.", Size);
			FLOHGDECHHH().SetFloat("_Value2", Speed);
			HFBJAOFLCJI().SetFloat("_Value1", ILHJFHFPGBB);
			DNLMFEGJJDD().SetFloat(" is not observed by this object's photonView! OnPhotonSerializeView() in this class won't be used.", CCIENBFIKKH);
			EJDPNJAEAKJ().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 789f, 985f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material FLOHGDECHHH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void LIEGJOHINGC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JAAJECBCCFM()
	{
	}

	private void KIMMMCJFMAB()
	{
		SCShader = Shader.Find("CameraFilterPack/Distortion_Twist");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JNGMIAFLBDL()
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
			BJFKDHHMLJH.hideFlags = (HideFlags)87;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material PGPEMMBJOOG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-110);
		}
		return BJFKDHHMLJH;
	}

	private void AGEJKLMJGDO()
	{
		SCShader = Shader.Find("[Up]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material LONNIJMNKFB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 838f)
			{
				HBJJOCHGOPH = 1279f;
			}
			BFGNMFCNDBC().SetFloat("SetCrosshairColor", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat("workshop.", Size);
			DNLMFEGJJDD().SetFloat("_Value3", Speed);
			NBPKMLMCHFN.SetFloat("Horizontal", ILHJFHFPGBB);
			HHIAIGCAHDA().SetFloat("CameraFilterPack/Blend2Camera_ColorKey", CCIENBFIKKH);
			HKGAONMOBMH().SetVector("roomDescription", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1846f, 1943f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 61f)
			{
				HBJJOCHGOPH = 869f;
			}
			BFGNMFCNDBC().SetFloat("Exit to menu?", HBJJOCHGOPH);
			HHIAIGCAHDA().SetFloat("shader.ghost", Size);
			FAIFBBGFAIB().SetFloat("mapselector.filter.favoriteonly", Speed);
			PGPEMMBJOOG().SetFloat("b", ILHJFHFPGBB);
			KOHGPKOFEJO().SetFloat("_AllowBackwardsRays", CCIENBFIKKH);
			BFGNMFCNDBC().SetVector("intensity", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 274f, 91f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IIFCIDDJHPM()
	{
	}

	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 380f)
			{
				HBJJOCHGOPH = 178f;
			}
			EJDPNJAEAKJ().SetFloat("Can't connect: ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("settings.volume.sfx", Size);
			PDEAHJPOMEF().SetFloat("_EdgeSharpness", Speed);
			PDEAHJPOMEF().SetFloat("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception", ILHJFHFPGBB);
			NBPKMLMCHFN.SetFloat("settings.cameramovements", CCIENBFIKKH);
			BKKJJJGADLM().SetVector("_Light", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1469f, 1149f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
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
			if (HBJJOCHGOPH > 1738f)
			{
				HBJJOCHGOPH = 1335f;
			}
			KOHGPKOFEJO().SetFloat("_VignetteSettings", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("MapEnd", Size);
			HKGAONMOBMH().SetFloat(" Server: ", Speed);
			ADGHJOHKEHG().SetFloat("#mapalreadyexistupdate", ILHJFHFPGBB);
			NBPKMLMCHFN.SetFloat("_Value4", CCIENBFIKKH);
			HKGAONMOBMH().SetVector("CameraFilterPack/TV_BrokenGlass", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1865f, 1405f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KMOCDAOKGLI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IHLMNAGPKDA()
	{
		SCShader = Shader.Find("Exit to Windows");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EJFJENFKLND()
	{
	}

	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1454f)
			{
				HBJJOCHGOPH = 34f;
			}
			PLBEJJIHFPB().SetFloat("id", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("CameraFilterPack/Vision_Blood_Fast", Size);
			LONNIJMNKFB().SetFloat("Checkpoint", Speed);
			BFGNMFCNDBC().SetFloat("BitsData", ILHJFHFPGBB);
			ADGHJOHKEHG().SetFloat("SetParticlesEmission", CCIENBFIKKH);
			HKGAONMOBMH().SetVector("sprite", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1015f, 215f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PGPEMMBJOOG());
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
			NBPKMLMCHFN.SetFloat("_Value3", ILHJFHFPGBB);
			NBPKMLMCHFN.SetFloat("_Value4", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GJLKJAOBPJD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}
}
