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
		SCShader = Shader.Find("Unable to get a reward! Try again?");
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
			OIMMPLPBLBK().SetFloat(" to: ", HBJJOCHGOPH);
			FLOHGDECHHH().SetFloat("GameScene", Size);
			LONNIJMNKFB().SetFloat("Data/Localization", Speed);
			FAIFBBGFAIB().SetFloat("FinalScoreSmallText", ILHJFHFPGBB);
			IGKFMCPDNOI().SetFloat(" b.", CCIENBFIKKH);
			HKGAONMOBMH().SetVector("[BuildInfo] Error: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 643f, 1119f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PGPEMMBJOOG());
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
			NBPKMLMCHFN.SetFloat("_ScreenResolution", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("note.2", Size);
			PLBEJJIHFPB().SetFloat("source", Speed);
			NBPKMLMCHFN.SetFloat("(\\[ *h1 *\\])", ILHJFHFPGBB);
			NBPKMLMCHFN.SetFloat("menu.playedsolo", CCIENBFIKKH);
			KOHGPKOFEJO().SetVector("Using constructor for new PingNativeDynamic()", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1074f, 1896f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BKKJJJGADLM());
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
			LONNIJMNKFB().SetFloat("float,0", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("ConnectToMaster() failed. Can only connect while in state 'Disconnected'. Current state: ", Size);
			OIMMPLPBLBK().SetFloat("Gameplay/LobbyPlayerIconElement", Speed);
			GHHPOGODBHB().SetFloat("_Jitter", ILHJFHFPGBB);
			HHIAIGCAHDA().SetFloat("_MainTex2", CCIENBFIKKH);
			HKGAONMOBMH().SetVector("CameraFilterPack/Vision_AuraDistortion", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1286f, 11f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BKKJJJGADLM());
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
			FLOHGDECHHH().SetFloat("#failed: ", HBJJOCHGOPH);
			GHHPOGODBHB().SetFloat(" | Level: ", Size);
			BKKJJJGADLM().SetFloat("It seems some instantiation is not completed, as instantiation data is used. You should make sure instantiations are paused when calling this method. Cleaning now, despite this.", Speed);
			BKKJJJGADLM().SetFloat("\\", ILHJFHFPGBB);
			BKKJJJGADLM().SetFloat("UseFinalGlassColor", CCIENBFIKKH);
			KOHGPKOFEJO().SetVector("_Circle", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1300f, 311f));
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
			PGPEMMBJOOG().SetFloat("workshop.", HBJJOCHGOPH);
			HKGAONMOBMH().SetFloat("EnableRankingToggle", Size);
			BKKJJJGADLM().SetFloat(" not exist", Speed);
			DNLMFEGJJDD().SetFloat("seconds", ILHJFHFPGBB);
			BFGNMFCNDBC().SetFloat("Item created: Id: ", CCIENBFIKKH);
			BFGNMFCNDBC().SetVector(" x ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 635f, 299f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PGPEMMBJOOG());
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
		SCShader = Shader.Find("OpJoinRandomRoom()");
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
		SCShader = Shader.Find("_PrefilterOffs");
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
		SCShader = Shader.Find("Horizontal");
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
		SCShader = Shader.Find("Offline or in OfflineMode. No VitalStats available.");
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
			IGKFMCPDNOI().SetFloat("Default UI Material", HBJJOCHGOPH);
			FLOHGDECHHH().SetFloat("<b>Difficulty</b>:", Size);
			IGKFMCPDNOI().SetFloat("_Value2", Speed);
			LENEJAGLCNL().SetFloat("settings.shaders", ILHJFHFPGBB);
			LONNIJMNKFB().SetFloat("AVG Misses:", CCIENBFIKKH);
			HHIAIGCAHDA().SetVector("No Camera attached!", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 313f, 225f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KOHGPKOFEJO());
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
		SCShader = Shader.Find("GameScene");
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
			FAIFBBGFAIB().SetFloat("DPADHOR", Size);
			FAIFBBGFAIB().SetFloat("Tab1Content", Speed);
			NBPKMLMCHFN.SetFloat("CameraFilterPack_Glasses_On3", ILHJFHFPGBB);
			PLBEJJIHFPB().SetFloat("Data/Editor/leveltemplate", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 132f, 1907f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EJDPNJAEAKJ());
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
			HFBJAOFLCJI().SetFloat("CameraFilterPack/Color_RGB", HBJJOCHGOPH);
			FLOHGDECHHH().SetFloat("settings.crosshairopacity", Size);
			LENEJAGLCNL().SetFloat("The directory was created successfully at ", Speed);
			ADGHJOHKEHG().SetFloat("restrictions", ILHJFHFPGBB);
			BKKJJJGADLM().SetFloat("_Value2", CCIENBFIKKH);
			KOHGPKOFEJO().SetVector("_SizeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 675f, 1611f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
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
		SCShader = Shader.Find(".");
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
			GHHPOGODBHB().SetFloat("CameraFilterPack/Blend2Camera_Difference", HBJJOCHGOPH);
			EJDPNJAEAKJ().SetFloat("1", Size);
			PGPEMMBJOOG().SetFloat("LeaderboardsButton", Speed);
			EJDPNJAEAKJ().SetFloat("There is already a virtual axis named ", ILHJFHFPGBB);
			GHHPOGODBHB().SetFloat("Received RPC: ", CCIENBFIKKH);
			HHIAIGCAHDA().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1846f, 1619f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JMEOGJHCONJ()
	{
		SCShader = Shader.Find("CompletedLevel");
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
			EJDPNJAEAKJ().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			HHIAIGCAHDA().SetFloat("_ScreenResolution", Size);
			KOHGPKOFEJO().SetFloat(".highscore", Speed);
			BFGNMFCNDBC().SetFloat("#combo", ILHJFHFPGBB);
			LENEJAGLCNL().SetFloat("-", CCIENBFIKKH);
			BFGNMFCNDBC().SetVector("ReconnectAndRejoin() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 120f, 1584f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
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
			PGPEMMBJOOG().SetFloat("Show Image", HBJJOCHGOPH);
			GHHPOGODBHB().SetFloat("Crosshair2", Size);
			OIMMPLPBLBK().SetFloat("_Value", Speed);
			DNLMFEGJJDD().SetFloat("_PColor", ILHJFHFPGBB);
			BFGNMFCNDBC().SetFloat("Status: ", CCIENBFIKKH);
			OIMMPLPBLBK().SetVector("CameraFilterPack/Color_Chromatic_Aberration", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 789f, 985f));
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
		SCShader = Shader.Find("_ScreenResolution");
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
		SCShader = Shader.Find("[Down]");
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
			NBPKMLMCHFN.SetFloat("SetSatelliteLerpSpeed", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("workshop.", Size);
			LENEJAGLCNL().SetFloat("_Value2", Speed);
			FLOHGDECHHH().SetFloat("Can't do manual instantiation without PhotonView component.", ILHJFHFPGBB);
			LONNIJMNKFB().SetFloat("_ScreenResolution", CCIENBFIKKH);
			DNLMFEGJJDD().SetVector("RoomDescriptionText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1846f, 1943f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
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
			HHIAIGCAHDA().SetFloat("OK", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat("shader.crispwinter", Size);
			KOHGPKOFEJO().SetFloat("mapselector.filter.favoriteonly", Speed);
			IGKFMCPDNOI().SetFloat("r", ILHJFHFPGBB);
			FLOHGDECHHH().SetFloat("_BilateralUpsampling", CCIENBFIKKH);
			PGPEMMBJOOG().SetVector("_HrDepthTex", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 274f, 91f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
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
			LENEJAGLCNL().SetFloat("Best region found in PlayerPrefs. Connecting to: ", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("ItemNameText", Size);
			HKGAONMOBMH().SetFloat("_EdgeThresholdMin", Speed);
			NBPKMLMCHFN.SetFloat("SlidingArea", ILHJFHFPGBB);
			GHHPOGODBHB().SetFloat("CameraMovementSlider", CCIENBFIKKH);
			HHIAIGCAHDA().SetVector("_Intensity", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1469f, 1149f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
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
			DNLMFEGJJDD().SetFloat("_VignetteSettings", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat("menu.playedsolo", Size);
			NBPKMLMCHFN.SetFloat("Call ConnectToNameServer to ping available regions.", Speed);
			PGPEMMBJOOG().SetFloat("#no", ILHJFHFPGBB);
			PLBEJJIHFPB().SetFloat("_Value3", CCIENBFIKKH);
			HHIAIGCAHDA().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1865f, 1405f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
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
		SCShader = Shader.Find("/Saved Games/");
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
			LONNIJMNKFB().SetFloat("Set Particles Speed", HBJJOCHGOPH);
			BKKJJJGADLM().SetFloat("_ScreenResolution", Size);
			BFGNMFCNDBC().SetFloat("SpawnObj", Speed);
			LONNIJMNKFB().SetFloat("checkpoint", ILHJFHFPGBB);
			BFGNMFCNDBC().SetFloat("Set particles color", CCIENBFIKKH);
			BKKJJJGADLM().SetVector("[PlayerBase] MapEnd error: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1015f, 215f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLOHGDECHHH());
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
