// CameraFilterPack_NightVision_4
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Night Vision/Night Vision 4")]
public class CameraFilterPack_NightVision_4 : MonoBehaviour
{
	private string ELOFMLPCCEA = "CameraFilterPack/NightVision_4";

	public Shader SCShader;

	[Range(0f, 1f)]
	public float FadeFX = 1f;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	private float[] PLKFKNHPEHE;

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

	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 185f)
			{
				HBJJOCHGOPH = 1114f;
			}
			LPDOGGFOBDH().SetFloat("PointsScoreText", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_NoiseTex", PLKFKNHPEHE[0] / 942f);
			OIBHFCLJKDB().SetFloat("Bad modpack name: {0}", PLKFKNHPEHE[1] / 1819f);
			MMOODGIODPC().SetFloat("_threshold", PLKFKNHPEHE[6] / 1683f);
			ECCPAOBFDKP().SetFloat("_TimeX", PLKFKNHPEHE[5] / 85f);
			OIBHFCLJKDB().SetFloat("_TimeX", PLKFKNHPEHE[0] / 428f);
			ECCPAOBFDKP().SetFloat("PlayerPrefs::Deserialize() parameterContent has ", PLKFKNHPEHE[6] / 1291f);
			JFDGLLEOPGB().SetFloat("music", PLKFKNHPEHE[6] / 566f);
			PLBEJJIHFPB().SetFloat("_TimeX", PLKFKNHPEHE[4] / 1506f);
			CIAFLBFJLEJ().SetFloat("Set satellite audio input", PLKFKNHPEHE[6] / 172f);
			PLBEJJIHFPB().SetFloat("LivesSlider", PLKFKNHPEHE[-112] / 1842f);
			OJMHIMIPKME().SetFloat("Set particles count per one beat", PLKFKNHPEHE[-86] / 1438f);
			BLMPMOIDGMG().SetFloat("_LensDirtIntensity", PLKFKNHPEHE[-111] / 1500f);
			JFDGLLEOPGB().SetFloat("_Value", FadeFX);
			JFDGLLEOPGB().SetVector("CameraFilterPack/Color_RGB", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 189f, 859f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CJPHFMAAIDC()
	{
		float[] array = new float[89];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void JFJLGJEPEAA()
	{
		FMEFPOILMDI();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DBLILJGKGHJ()
	{
		NBMEBBHCNMH();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1527f)
			{
				HBJJOCHGOPH = 1517f;
			}
			HNFFHCLNBDN().SetFloat(":</b> ", HBJJOCHGOPH);
			LPDOGGFOBDH().SetFloat("AvatarImage", PLKFKNHPEHE[1] / 1618f);
			NBPKMLMCHFN.SetFloat("_Value", PLKFKNHPEHE[1] / 1876f);
			FEAEGGCNIAA().SetFloat("_ScreenResolution", PLKFKNHPEHE[3] / 169f);
			ECCPAOBFDKP().SetFloat("Joystick1Button2", PLKFKNHPEHE[8] / 1532f);
			DKKBFFHBHJE().SetFloat("workshop.", PLKFKNHPEHE[5] / 1705f);
			MMOODGIODPC().SetFloat("_ScreenResolution", PLKFKNHPEHE[0] / 1113f);
			HILDKDFEBPF().SetFloat("masterVolume", PLKFKNHPEHE[5] / 1525f);
			HNFFHCLNBDN().SetFloat("[", PLKFKNHPEHE[0] / 1672f);
			MMOODGIODPC().SetFloat("[ReplayScene] Loading replay: ", PLKFKNHPEHE[2] / 518f);
			BAGICADFBAB().SetFloat("maps.", PLKFKNHPEHE[-48] / 563f);
			FEAEGGCNIAA().SetFloat("[MapEditor] Item creation successful! Published Item ID: ", PLKFKNHPEHE[-93] / 1625f);
			HNFFHCLNBDN().SetFloat("_ReflectionTexture4", PLKFKNHPEHE[30] / 352f);
			OIBHFCLJKDB().SetFloat("_BlurPass", FadeFX);
			DKKBFFHBHJE().SetVector("Music End", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 537f, 57f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MJEFMIPLFAB()
	{
		NBMEBBHCNMH();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FALHNNJBOEM()
	{
		float[] array = new float[30];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 921f)
			{
				HBJJOCHGOPH = 1783f;
			}
			ENKPNJMPDEB().SetFloat("UseScanLine", HBJJOCHGOPH);
			HILDKDFEBPF().SetFloat("GenerationMenu", PLKFKNHPEHE[1] / 1140f);
			DKKBFFHBHJE().SetFloat("RPC: 'OnAwakeRPC' PhotonView: ", PLKFKNHPEHE[1] / 229f);
			ENKPNJMPDEB().SetFloat("offsets", PLKFKNHPEHE[2] / 265f);
			CIAFLBFJLEJ().SetFloat("offsets", PLKFKNHPEHE[5] / 1917f);
			DKKBFFHBHJE().SetFloat(".lastCheckpoint.perfectHits", PLKFKNHPEHE[5] / 1753f);
			OIBHFCLJKDB().SetFloat("\n", PLKFKNHPEHE[2] / 908f);
			MMOODGIODPC().SetFloat("#tryagain", PLKFKNHPEHE[1] / 1396f);
			PLBEJJIHFPB().SetFloat("_BlurParams", PLKFKNHPEHE[1] / 396f);
			PLBEJJIHFPB().SetFloat("_TimeX", PLKFKNHPEHE[2] / 105f);
			HILDKDFEBPF().SetFloat("isVisible", PLKFKNHPEHE[31] / 101f);
			LPDOGGFOBDH().SetFloat("menu.playedpage", PLKFKNHPEHE[67] / 1459f);
			NBPKMLMCHFN.SetFloat("BadgeText", PLKFKNHPEHE[65] / 1539f);
			DKKBFFHBHJE().SetFloat("CameraFilterPack/Blend2Camera_Luminosity", FadeFX);
			LEIAFCPJMDP().SetVector("_FixDistance", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 939f, 1028f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 13f)
			{
				HBJJOCHGOPH = 1119f;
			}
			JFDGLLEOPGB().SetFloat("PenaltyScoreText", HBJJOCHGOPH);
			BLMPMOIDGMG().SetFloat("_Color2", PLKFKNHPEHE[0] / 1256f);
			OIBHFCLJKDB().SetFloat(". Using max value: 255.", PLKFKNHPEHE[0] / 895f);
			NBPKMLMCHFN.SetFloat("y", PLKFKNHPEHE[7] / 575f);
			LPDOGGFOBDH().SetFloat("float,0", PLKFKNHPEHE[4] / 1090f);
			DKKBFFHBHJE().SetFloat("SteamManager", PLKFKNHPEHE[7] / 1089f);
			BLMPMOIDGMG().SetFloat("_ScreenResolution", PLKFKNHPEHE[6] / 1991f);
			PLBEJJIHFPB().SetFloat("_Value4", PLKFKNHPEHE[2] / 1155f);
			NBPKMLMCHFN.SetFloat("settings_bindings_sec_", PLKFKNHPEHE[2] / 1433f);
			PLBEJJIHFPB().SetFloat("settings.enableranking", PLKFKNHPEHE[5] / 470f);
			HILDKDFEBPF().SetFloat("_ScreenResolution", PLKFKNHPEHE[20] / 925f);
			HNFFHCLNBDN().SetFloat("_ScreenResolution", PLKFKNHPEHE[5] / 1786f);
			BAGICADFBAB().SetFloat("settings.shaders", PLKFKNHPEHE[124] / 1058f);
			ENKPNJMPDEB().SetFloat("_TimeX", FadeFX);
			FEAEGGCNIAA().SetVector(",", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 900f, 1559f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIBHFCLJKDB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KPOCGNOKNOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1462f)
			{
				HBJJOCHGOPH = 1271f;
			}
			FEAEGGCNIAA().SetFloat("Hidden/ScreenSpaceReflection", HBJJOCHGOPH);
			BAGICADFBAB().SetFloat(". We have no such PhotonView! Ignored this if you're leaving a room. State: ", PLKFKNHPEHE[0] / 1727f);
			OJMHIMIPKME().SetFloat(".", PLKFKNHPEHE[0] / 1899f);
			LEIAFCPJMDP().SetFloat("_Offsets", PLKFKNHPEHE[4] / 779f);
			HNFFHCLNBDN().SetFloat(" not found", PLKFKNHPEHE[4] / 1983f);
			CIAFLBFJLEJ().SetFloat("ERROR You have missing MonoBehaviours on your gameobjects!", PLKFKNHPEHE[3] / 304f);
			CIAFLBFJLEJ().SetFloat("Done!", PLKFKNHPEHE[4] / 1236f);
			OIBHFCLJKDB().SetFloat("0.00", PLKFKNHPEHE[4] / 1332f);
			OIBHFCLJKDB().SetFloat(".played", PLKFKNHPEHE[6] / 717f);
			LEIAFCPJMDP().SetFloat("Created", PLKFKNHPEHE[8] / 1160f);
			ECCPAOBFDKP().SetFloat("player.goldlollipop", PLKFKNHPEHE[-31] / 1598f);
			DKKBFFHBHJE().SetFloat("_FixDistance", PLKFKNHPEHE[-66] / 768f);
			LEIAFCPJMDP().SetFloat("_Value2", PLKFKNHPEHE[-68] / 1709f);
			NBPKMLMCHFN.SetFloat("A", FadeFX);
			CIAFLBFJLEJ().SetVector("float,2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1801f, 1505f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HILDKDFEBPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PHINJDJEFLI()
	{
		float[] array = new float[33];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void FIKNBPAIFBI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 413f)
			{
				HBJJOCHGOPH = 1507f;
			}
			MMOODGIODPC().SetFloat("Netw. Sim.", HBJJOCHGOPH);
			MMOODGIODPC().SetFloat("#timeuntilend: ", PLKFKNHPEHE[0] / 691f);
			HILDKDFEBPF().SetFloat("CameraFilterPack/3D_Distortion", PLKFKNHPEHE[0] / 64f);
			HNFFHCLNBDN().SetFloat("_Blue_B", PLKFKNHPEHE[3] / 1520f);
			LEIAFCPJMDP().SetFloat("PunRespawn", PLKFKNHPEHE[0] / 115f);
			HNFFHCLNBDN().SetFloat("_PColor2", PLKFKNHPEHE[1] / 1278f);
			HILDKDFEBPF().SetFloat("Joystick1Button2", PLKFKNHPEHE[6] / 830f);
			DKKBFFHBHJE().SetFloat("_Value2", PLKFKNHPEHE[3] / 991f);
			LPDOGGFOBDH().SetFloat("InfoCanvas", PLKFKNHPEHE[6] / 864f);
			FEAEGGCNIAA().SetFloat("player.goldwatermelon", PLKFKNHPEHE[6] / 1725f);
			FEAEGGCNIAA().SetFloat("maps.", PLKFKNHPEHE[88] / 1607f);
			BLMPMOIDGMG().SetFloat("_Green_G", PLKFKNHPEHE[-115] / 1398f);
			LEIAFCPJMDP().SetFloat("maps.", PLKFKNHPEHE[-4] / 131f);
			DKKBFFHBHJE().SetFloat("challenges/", FadeFX);
			LEIAFCPJMDP().SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 384f, 1628f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GPJHPNGNEBP()
	{
		FCDODOIJIIB();
	}

	private void OLGKEEPPPKG()
	{
		float[] array = new float[127];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void PNNPDMHLFHE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FJHFOBHJEHL()
	{
	}

	private void ACBAHLCGNDD()
	{
		JBBKKKJOJMJ();
	}

	private void MMMDPANNAIO()
	{
		MIPGPMKJELI();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LGHCJCFHEMF()
	{
		FJNEBMBJPLK();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NFMCBMDELNK()
	{
		float[] array = new float[-101];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void JOONHGHGKKF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ALMGMOOHLMA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DJGJOMFJPEF()
	{
		float[] array = new float[-50];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void BFEILOMHNPC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HLLHJIDOOGA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GHILDCBCDJI()
	{
	}

	private void IDIIELPAMCJ()
	{
	}

	[SpecialName]
	private Material LEIAFCPJMDP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)92;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material CIAFLBFJLEJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void CNDACAHCCOI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material MMOODGIODPC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1653f)
			{
				HBJJOCHGOPH = 928f;
			}
			BLMPMOIDGMG().SetFloat("rarity", HBJJOCHGOPH);
			FEAEGGCNIAA().SetFloat("checkpoint", PLKFKNHPEHE[0] / 1154f);
			OIBHFCLJKDB().SetFloat("OnMastedChangeScene", PLKFKNHPEHE[0] / 1652f);
			PLBEJJIHFPB().SetFloat("maps.", PLKFKNHPEHE[4] / 243f);
			ENKPNJMPDEB().SetFloat("CameraFilterPack/FX_8bits_gb", PLKFKNHPEHE[2] / 1684f);
			ECCPAOBFDKP().SetFloat("PlayButton", PLKFKNHPEHE[1] / 428f);
			BLMPMOIDGMG().SetFloat("#close", PLKFKNHPEHE[0] / 318f);
			ECCPAOBFDKP().SetFloat("a", PLKFKNHPEHE[1] / 1676f);
			JFDGLLEOPGB().SetFloat("#ok", PLKFKNHPEHE[7] / 1878f);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/TV_Tiles", PLKFKNHPEHE[8] / 1221f);
			ENKPNJMPDEB().SetFloat("_Value9", PLKFKNHPEHE[113] / 1009f);
			CIAFLBFJLEJ().SetFloat("\\\"", PLKFKNHPEHE[-74] / 877f);
			NBPKMLMCHFN.SetFloat("_Value4", PLKFKNHPEHE[-60] / 240f);
			LPDOGGFOBDH().SetFloat("NetworkCanvas", FadeFX);
			DKKBFFHBHJE().SetVector("[Up-Right]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 881f, 1791f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ECCPAOBFDKP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BNEJMABFKJE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KKDDHFJOAAD()
	{
		JKCPPCDFLBL();
	}

	private void MGGFMCIGOAF()
	{
		float[] array = new float[92];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void COIJKMKIEAK()
	{
		PHINJDJEFLI();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KOFAMEKHHGD()
	{
		NDAIGNNKOAC();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FOAGAKFBIGD()
	{
	}

	private void EIMNPCMHJLJ()
	{
		NDAIGNNKOAC();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IDJKNBDKHBD()
	{
		CJPHFMAAIDC();
		SCShader = Shader.Find(ELOFMLPCCEA);
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
			if (HBJJOCHGOPH > 1583f)
			{
				HBJJOCHGOPH = 932f;
			}
			OJMHIMIPKME().SetFloat("In Map Editor", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("IconFileSelector", PLKFKNHPEHE[1] / 92f);
			LEIAFCPJMDP().SetFloat("GameScene", PLKFKNHPEHE[0] / 1399f);
			HILDKDFEBPF().SetFloat("_ScreenResolution", PLKFKNHPEHE[5] / 1310f);
			JFDGLLEOPGB().SetFloat("^", PLKFKNHPEHE[4] / 673f);
			ECCPAOBFDKP().SetFloat("_BlurredColor", PLKFKNHPEHE[6] / 656f);
			PLBEJJIHFPB().SetFloat("y", PLKFKNHPEHE[0] / 1393f);
			CIAFLBFJLEJ().SetFloat("SelectorMapsCountSlider", PLKFKNHPEHE[0] / 1103f);
			NBPKMLMCHFN.SetFloat("_TimeX", PLKFKNHPEHE[3] / 1311f);
			LEIAFCPJMDP().SetFloat("QuickSave", PLKFKNHPEHE[6] / 709f);
			HNFFHCLNBDN().SetFloat("Object ID", PLKFKNHPEHE[-17] / 127f);
			MMOODGIODPC().SetFloat("Set sun audio input", PLKFKNHPEHE[-11] / 1080f);
			LEIAFCPJMDP().SetFloat("_Value", PLKFKNHPEHE[-30] / 415f);
			FEAEGGCNIAA().SetFloat("_ScreenResolution", FadeFX);
			OJMHIMIPKME().SetVector("Malformed RPC; this should never occur. Content: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1769f, 609f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 47f)
			{
				HBJJOCHGOPH = 307f;
			}
			LPDOGGFOBDH().SetFloat("_TimeX", HBJJOCHGOPH);
			OJMHIMIPKME().SetFloat("_Value2", PLKFKNHPEHE[1] / 1636f);
			FEAEGGCNIAA().SetFloat("/", PLKFKNHPEHE[1] / 1462f);
			BLMPMOIDGMG().SetFloat("/", PLKFKNHPEHE[4] / 1459f);
			HILDKDFEBPF().SetFloat("Received event Leave for unknown player ID: {0}", PLKFKNHPEHE[6] / 198f);
			JFDGLLEOPGB().SetFloat("_FarCamera", PLKFKNHPEHE[5] / 189f);
			ENKPNJMPDEB().SetFloat("mapselector.filter.subscribedonly", PLKFKNHPEHE[5] / 1215f);
			FEAEGGCNIAA().SetFloat("{0} seconds ago", PLKFKNHPEHE[7] / 168f);
			ENKPNJMPDEB().SetFloat(" ", PLKFKNHPEHE[5] / 1080f);
			BLMPMOIDGMG().SetFloat("Object ID", PLKFKNHPEHE[7] / 562f);
			LEIAFCPJMDP().SetFloat("CameraFilterPack/FX_InverChromiLum", PLKFKNHPEHE[-49] / 624f);
			FEAEGGCNIAA().SetFloat("BitsData", PLKFKNHPEHE[-7] / 1600f);
			BAGICADFBAB().SetFloat("Did not read byte array properly", PLKFKNHPEHE[0] / 628f);
			ENKPNJMPDEB().SetFloat("isVisible", FadeFX);
			LPDOGGFOBDH().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1708f, 1803f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CIAFLBFJLEJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OKHBBIKDIEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 836f)
			{
				HBJJOCHGOPH = 982f;
			}
			CIAFLBFJLEJ().SetFloat("OnStatusChanged: {0} current State: {1}", HBJJOCHGOPH);
			HNFFHCLNBDN().SetFloat("1,30,true,0", PLKFKNHPEHE[1] / 206f);
			DKKBFFHBHJE().SetFloat("failed", PLKFKNHPEHE[0] / 1201f);
			NBPKMLMCHFN.SetFloat(": ", PLKFKNHPEHE[3] / 33f);
			BAGICADFBAB().SetFloat("Start", PLKFKNHPEHE[3] / 972f);
			LEIAFCPJMDP().SetFloat("_CutOff", PLKFKNHPEHE[6] / 193f);
			DKKBFFHBHJE().SetFloat("_Offsets", PLKFKNHPEHE[0] / 1946f);
			HNFFHCLNBDN().SetFloat("#ok", PLKFKNHPEHE[3] / 1927f);
			CIAFLBFJLEJ().SetFloat("EnvironmentSlider", PLKFKNHPEHE[0] / 503f);
			JFDGLLEOPGB().SetFloat(" failed in a server-side plugin. Check the configuration in the Dashboard. Message from server-plugin: ", PLKFKNHPEHE[1] / 1084f);
			BLMPMOIDGMG().SetFloat("GlassesColor2", PLKFKNHPEHE[-8] / 306f);
			BAGICADFBAB().SetFloat("Source: ", PLKFKNHPEHE[-71] / 678f);
			LPDOGGFOBDH().SetFloat("plainText", PLKFKNHPEHE[84] / 658f);
			LPDOGGFOBDH().SetFloat("_Value2", FadeFX);
			BAGICADFBAB().SetVector("_History1Weight", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 39f, 1754f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OEAMLMGNFFC()
	{
		DJGJOMFJPEF();
	}

	private void LECCHIAFGGE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DOMPMIAIDIL()
	{
		float[] array = new float[-18];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	[SpecialName]
	private Material OJMHIMIPKME()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)80;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material FEAEGGCNIAA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void NBMEBBHCNMH()
	{
		float[] array = new float[114];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void IHAGANPOFDP()
	{
		FMEFPOILMDI();
	}

	private void PLBOFEPBPKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MBFNACDMEEK()
	{
		PHINJDJEFLI();
	}

	private void OMIHEBMMCPG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1091f)
			{
				HBJJOCHGOPH = 902f;
			}
			OJMHIMIPKME().SetFloat("_MainTex2", HBJJOCHGOPH);
			HNFFHCLNBDN().SetFloat("MessageText", PLKFKNHPEHE[1] / 403f);
			LEIAFCPJMDP().SetFloat("_History3ChromaTex", PLKFKNHPEHE[0] / 318f);
			HNFFHCLNBDN().SetFloat(" AuthMode ", PLKFKNHPEHE[4] / 329f);
			CIAFLBFJLEJ().SetFloat("_BlurTexture", PLKFKNHPEHE[7] / 119f);
			ECCPAOBFDKP().SetFloat("_ScreenResolution", PLKFKNHPEHE[5] / 1938f);
			BLMPMOIDGMG().SetFloat("Populate Mesh Data", PLKFKNHPEHE[6] / 1746f);
			ECCPAOBFDKP().SetFloat("Object ID. Case-Sensitive", PLKFKNHPEHE[7] / 34f);
			LEIAFCPJMDP().SetFloat("Subscribe: ", PLKFKNHPEHE[0] / 213f);
			OIBHFCLJKDB().SetFloat("[PlayerBase] Delete checkpoint data", PLKFKNHPEHE[5] / 1600f);
			DKKBFFHBHJE().SetFloat("Tab2Content", PLKFKNHPEHE[-78] / 986f);
			ENKPNJMPDEB().SetFloat("_Offsets", PLKFKNHPEHE[93] / 1784f);
			ECCPAOBFDKP().SetFloat("</i>", PLKFKNHPEHE[-85] / 1634f);
			FEAEGGCNIAA().SetFloat("_Value3", FadeFX);
			HILDKDFEBPF().SetVector("_Axis", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 106f, 1655f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNFFHCLNBDN());
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
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HILDKDFEBPF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void FBIHCGOKELF()
	{
		float[] array = new float[119];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void CGBHOELMAOC()
	{
	}

	private void POIFMMFPELA()
	{
		NDAIGNNKOAC();
	}

	private void FMFNILJIEIA()
	{
		IKDGKCLIJBL();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material ENKPNJMPDEB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void FJNEBMBJPLK()
	{
		float[] array = new float[-81];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void JPBEEFIPDOL()
	{
		float[] array = new float[-56];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void AGMJDGHLBMN()
	{
	}

	private void NJBMCJOOMMP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 64f)
			{
				HBJJOCHGOPH = 1872f;
			}
			DKKBFFHBHJE().SetFloat("settings_bindings_sec_", HBJJOCHGOPH);
			FEAEGGCNIAA().SetFloat("settings.shaders", PLKFKNHPEHE[1] / 946f);
			LPDOGGFOBDH().SetFloat("Mouse Y", PLKFKNHPEHE[1] / 563f);
			BAGICADFBAB().SetFloat("no lives color", PLKFKNHPEHE[7] / 752f);
			ENKPNJMPDEB().SetFloat("CameraFilterPack/Glitch_Mozaic", PLKFKNHPEHE[5] / 951f);
			OJMHIMIPKME().SetFloat("{0} seconds ago", PLKFKNHPEHE[8] / 1180f);
			HILDKDFEBPF().SetFloat("_Amount", PLKFKNHPEHE[2] / 1890f);
			LPDOGGFOBDH().SetFloat("_FgOverlap", PLKFKNHPEHE[7] / 418f);
			MMOODGIODPC().SetFloat("#close", PLKFKNHPEHE[6] / 613f);
			LPDOGGFOBDH().SetFloat("Search: ", PLKFKNHPEHE[8] / 13f);
			PLBEJJIHFPB().SetFloat("Tab2Content", PLKFKNHPEHE[-92] / 1070f);
			OIBHFCLJKDB().SetFloat("CameraFilterPack/Blur_Movie", PLKFKNHPEHE[-66] / 165f);
			BLMPMOIDGMG().SetFloat("settings_bindings_sec_", PLKFKNHPEHE[-67] / 162f);
			ENKPNJMPDEB().SetFloat("_ScreenResolution", FadeFX);
			HNFFHCLNBDN().SetVector("_Far", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 183f, 1529f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DLBODOFAJGM()
	{
		JPBEEFIPDOL();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FCDODOIJIIB()
	{
		float[] array = new float[66];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void AAPKBNDHBLI()
	{
	}

	[SpecialName]
	private Material PLBEJJIHFPB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void IMGGCJICLHK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DHLCNIINMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 512f)
			{
				HBJJOCHGOPH = 995f;
			}
			FEAEGGCNIAA().SetFloat("_MidGrey", HBJJOCHGOPH);
			CIAFLBFJLEJ().SetFloat("_TimeX", PLKFKNHPEHE[0] / 92f);
			HNFFHCLNBDN().SetFloat("_TimeX", PLKFKNHPEHE[1] / 410f);
			HNFFHCLNBDN().SetFloat("maps.", PLKFKNHPEHE[4] / 1781f);
			ECCPAOBFDKP().SetFloat("_Intensity", PLKFKNHPEHE[2] / 1065f);
			CIAFLBFJLEJ().SetFloat("image", PLKFKNHPEHE[1] / 132f);
			FEAEGGCNIAA().SetFloat("powerup.0", PLKFKNHPEHE[0] / 1348f);
			PLBEJJIHFPB().SetFloat("NameInfoText", PLKFKNHPEHE[5] / 1307f);
			LPDOGGFOBDH().SetFloat("Hidden/DepthOfField/MedianFilter", PLKFKNHPEHE[8] / 547f);
			LPDOGGFOBDH().SetFloat("Tab2Content", PLKFKNHPEHE[4] / 309f);
			BLMPMOIDGMG().SetFloat("CameraFilterPack/Colors_HUE_Rotate", PLKFKNHPEHE[-67] / 344f);
			HILDKDFEBPF().SetFloat("Edited unlock conditions", PLKFKNHPEHE[46] / 1329f);
			OIBHFCLJKDB().SetFloat("{0}", PLKFKNHPEHE[-111] / 687f);
			PLBEJJIHFPB().SetFloat("_MainTex2", FadeFX);
			ENKPNJMPDEB().SetVector("\t", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1740f, 991f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CIAFLBFJLEJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OnValidate()
	{
		MIPGPMKJELI();
	}

	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 958f)
			{
				HBJJOCHGOPH = 1700f;
			}
			NBPKMLMCHFN.SetFloat("Joined Room. isMasterClient: ", HBJJOCHGOPH);
			HILDKDFEBPF().SetFloat("[LevelEditorScene] Reloaded config for \"", PLKFKNHPEHE[0] / 1819f);
			MMOODGIODPC().SetFloat("UI Extensions/SoftMaskShaderText", PLKFKNHPEHE[1] / 59f);
			PLBEJJIHFPB().SetFloat("_ScreenResolution", PLKFKNHPEHE[4] / 602f);
			PLBEJJIHFPB().SetFloat("_BlurPass", PLKFKNHPEHE[1] / 1040f);
			ECCPAOBFDKP().SetFloat("OxOD.lastPath", PLKFKNHPEHE[0] / 0f);
			OIBHFCLJKDB().SetFloat("settings.cameramovements", PLKFKNHPEHE[1] / 1801f);
			OJMHIMIPKME().SetFloat("_MainTex2", PLKFKNHPEHE[8] / 783f);
			ECCPAOBFDKP().SetFloat("Fade", PLKFKNHPEHE[3] / 1124f);
			HILDKDFEBPF().SetFloat("note.5", PLKFKNHPEHE[1] / 497f);
			JFDGLLEOPGB().SetFloat("_TimeX", PLKFKNHPEHE[-30] / 1496f);
			HNFFHCLNBDN().SetFloat("InventoryGrid", PLKFKNHPEHE[-126] / 1595f);
			PLBEJJIHFPB().SetFloat("_ColorR", PLKFKNHPEHE[-68] / 518f);
			OJMHIMIPKME().SetFloat("Joystick1Button12", FadeFX);
			ENKPNJMPDEB().SetVector("CameraFilterPack/Edge_Neon", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 53f, 981f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 527f)
			{
				HBJJOCHGOPH = 346f;
			}
			LPDOGGFOBDH().SetFloat("<color=#", HBJJOCHGOPH);
			ECCPAOBFDKP().SetFloat("_Size", PLKFKNHPEHE[1] / 102f);
			ECCPAOBFDKP().SetFloat("EventTimeInputField", PLKFKNHPEHE[0] / 1765f);
			HILDKDFEBPF().SetFloat("Init", PLKFKNHPEHE[1] / 711f);
			ECCPAOBFDKP().SetFloat("...", PLKFKNHPEHE[3] / 1282f);
			BAGICADFBAB().SetFloat("_Value7", PLKFKNHPEHE[8] / 180f);
			CIAFLBFJLEJ().SetFloat("_ScreenResolution", PLKFKNHPEHE[2] / 804f);
			MMOODGIODPC().SetFloat("[LevelEditorScene] Print Audio Wave: Done", PLKFKNHPEHE[5] / 484f);
			HNFFHCLNBDN().SetFloat("Tab1Content", PLKFKNHPEHE[0] / 1996f);
			HNFFHCLNBDN().SetFloat("resource", PLKFKNHPEHE[4] / 801f);
			BLMPMOIDGMG().SetFloat("================================", PLKFKNHPEHE[-26] / 1367f);
			ECCPAOBFDKP().SetFloat("menu.enableselectormusic", PLKFKNHPEHE[67] / 1811f);
			NBPKMLMCHFN.SetFloat("_Value1", PLKFKNHPEHE[-78] / 781f);
			PLBEJJIHFPB().SetFloat("#score", FadeFX);
			OIBHFCLJKDB().SetVector(".completedMaps", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 950f, 289f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1624f)
			{
				HBJJOCHGOPH = 970f;
			}
			LPDOGGFOBDH().SetFloat("CameraFilterPack/TV_Chromatical2", HBJJOCHGOPH);
			FEAEGGCNIAA().SetFloat("Crosshair", PLKFKNHPEHE[0] / 246f);
			ENKPNJMPDEB().SetFloat("replayData", PLKFKNHPEHE[1] / 815f);
			OJMHIMIPKME().SetFloat("inventory.selected.", PLKFKNHPEHE[3] / 682f);
			LPDOGGFOBDH().SetFloat("_MidGrey", PLKFKNHPEHE[7] / 713f);
			CIAFLBFJLEJ().SetFloat("LastNewsButton", PLKFKNHPEHE[4] / 477f);
			HNFFHCLNBDN().SetFloat("CameraFilterPack/FX_superDot", PLKFKNHPEHE[6] / 754f);
			BAGICADFBAB().SetFloat("MapEnd", PLKFKNHPEHE[8] / 136f);
			DKKBFFHBHJE().SetFloat("#orderby:", PLKFKNHPEHE[7] / 440f);
			BLMPMOIDGMG().SetFloat("CameraFilterPack/Blend2Camera_LinearBurn", PLKFKNHPEHE[4] / 1794f);
			BLMPMOIDGMG().SetFloat("Object ID. Case-Sensitive", PLKFKNHPEHE[12] / 1885f);
			OJMHIMIPKME().SetFloat("Joystick1Button11", PLKFKNHPEHE[-42] / 242f);
			HILDKDFEBPF().SetFloat("CameraFilterPack/AAA_Super_Hexagon", PLKFKNHPEHE[-45] / 1716f);
			BLMPMOIDGMG().SetFloat("<color=#", FadeFX);
			NBPKMLMCHFN.SetVector("#no", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1519f, 977f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIBHFCLJKDB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	private void ELDMKIAPNGP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PKLOBJHKFEO()
	{
		JPBEEFIPDOL();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CGDMLHLJIDK()
	{
		FBIHCGOKELF();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FOMNCPKKCFN()
	{
	}

	private void ADPLHDFJFID()
	{
		JKCPPCDFLBL();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FJKJGBLPDGG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 684f)
			{
				HBJJOCHGOPH = 47f;
			}
			NBPKMLMCHFN.SetFloat("Tab1Content", HBJJOCHGOPH);
			LEIAFCPJMDP().SetFloat("_ConsoleSettings", PLKFKNHPEHE[1] / 717f);
			HNFFHCLNBDN().SetFloat("Fade", PLKFKNHPEHE[1] / 1508f);
			NBPKMLMCHFN.SetFloat("OnPickedUp", PLKFKNHPEHE[4] / 1252f);
			MMOODGIODPC().SetFloat("[Up-Left]", PLKFKNHPEHE[5] / 1273f);
			JFDGLLEOPGB().SetFloat("#tryagain", PLKFKNHPEHE[5] / 1454f);
			OIBHFCLJKDB().SetFloat(" with a prefix of ", PLKFKNHPEHE[2] / 1736f);
			ECCPAOBFDKP().SetFloat("checkpoint", PLKFKNHPEHE[7] / 181f);
			PLBEJJIHFPB().SetFloat("OpAuthenticate()", PLKFKNHPEHE[4] / 1705f);
			LEIAFCPJMDP().SetFloat(":", PLKFKNHPEHE[7] / 0f);
			ENKPNJMPDEB().SetFloat("Set camera background color", PLKFKNHPEHE[119] / 1652f);
			JFDGLLEOPGB().SetFloat("CameraFilterPack/Gradients_Ansi", PLKFKNHPEHE[96] / 345f);
			OJMHIMIPKME().SetFloat("_AdaptParams", PLKFKNHPEHE[39] / 1494f);
			FEAEGGCNIAA().SetFloat(". Going to authenticate anyways.", FadeFX);
			HILDKDFEBPF().SetVector("Left", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 255f, 1687f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HLDFOJMHKNL()
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

	private void LCDJFJIBADI()
	{
	}

	private void MIPGPMKJELI()
	{
		PLKFKNHPEHE = new float[12]
		{
			200f, -200f, -200f, 195f, 4f, -160f, 200f, -200f, -200f, -200f,
			10f, -200f
		};
	}

	private void NDAIGNNKOAC()
	{
		float[] array = new float[83];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void Start()
	{
		MIPGPMKJELI();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PLEOOAJIMEE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1106f)
			{
				HBJJOCHGOPH = 191f;
			}
			HNFFHCLNBDN().SetFloat("ItemsStoreButton", HBJJOCHGOPH);
			LEIAFCPJMDP().SetFloat(").", PLKFKNHPEHE[1] / 1662f);
			BAGICADFBAB().SetFloat("Connection error: ", PLKFKNHPEHE[0] / 176f);
			HILDKDFEBPF().SetFloat("player.crystal", PLKFKNHPEHE[5] / 1674f);
			FEAEGGCNIAA().SetFloat("workshop.", PLKFKNHPEHE[1] / 302f);
			HNFFHCLNBDN().SetFloat("back", PLKFKNHPEHE[7] / 1540f);
			BAGICADFBAB().SetFloat("_TimeX", PLKFKNHPEHE[0] / 670f);
			HILDKDFEBPF().SetFloat("MaxLivesSlider", PLKFKNHPEHE[5] / 1887f);
			ENKPNJMPDEB().SetFloat("_SpotSize", PLKFKNHPEHE[7] / 1210f);
			BLMPMOIDGMG().SetFloat("_TimeX", PLKFKNHPEHE[8] / 1224f);
			LEIAFCPJMDP().SetFloat("_VignetteBlur", PLKFKNHPEHE[-82] / 934f);
			ENKPNJMPDEB().SetFloat(". Going to ignore! Check PhotonServerSettings.RpcList", PLKFKNHPEHE[-109] / 1037f);
			MMOODGIODPC().SetFloat("_FgOverlap", PLKFKNHPEHE[126] / 1971f);
			PLBEJJIHFPB().SetFloat("_ColorBuffer", FadeFX);
			ENKPNJMPDEB().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 157f, 835f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MEBPBNLBECA()
	{
		FJNEBMBJPLK();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DBIBFOINCKM()
	{
		JPBEEFIPDOL();
	}

	private void FMEFPOILMDI()
	{
		float[] array = new float[-68];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void IKDGKCLIJBL()
	{
		float[] array = new float[-31];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void JIGIHDNCJHE()
	{
		float[] array = new float[-90];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void AKHCOBHHGJP()
	{
		MIPGPMKJELI();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GHMDNIFLGOB()
	{
		OBAAOMIIMHO();
	}

	private void ALJEJJCIMJN()
	{
		MGGFMCIGOAF();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EBBMDDEFNKL()
	{
		MGGFMCIGOAF();
	}

	private void PHOIJLHHAJJ()
	{
		float[] array = new float[-122];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 954f)
			{
				HBJJOCHGOPH = 1437f;
			}
			OJMHIMIPKME().SetFloat("default", HBJJOCHGOPH);
			BLMPMOIDGMG().SetFloat("[NetworkMenu] Joining ", PLKFKNHPEHE[0] / 1291f);
			ENKPNJMPDEB().SetFloat("offsets", PLKFKNHPEHE[1] / 1139f);
			JFDGLLEOPGB().SetFloat("_ScreenResolution", PLKFKNHPEHE[0] / 43f);
			ECCPAOBFDKP().SetFloat("PowerUp", PLKFKNHPEHE[8] / 1428f);
			ENKPNJMPDEB().SetFloat("yesterday", PLKFKNHPEHE[7] / 1272f);
			BLMPMOIDGMG().SetFloat("_Value4", PLKFKNHPEHE[6] / 1675f);
			ECCPAOBFDKP().SetFloat("_TimeX", PLKFKNHPEHE[7] / 1945f);
			MMOODGIODPC().SetFloat(" respawn: ", PLKFKNHPEHE[1] / 451f);
			BLMPMOIDGMG().SetFloat("_InvScreenSize", PLKFKNHPEHE[7] / 1880f);
			LEIAFCPJMDP().SetFloat("MAPS NOT FOUND", PLKFKNHPEHE[63] / 505f);
			OIBHFCLJKDB().SetFloat("CameraFilterPack/Atmosphere_Rain_Pro_3D", PLKFKNHPEHE[65] / 776f);
			CIAFLBFJLEJ().SetFloat("settings.enableranking", PLKFKNHPEHE[-59] / 1378f);
			FEAEGGCNIAA().SetFloat("_Near", FadeFX);
			HILDKDFEBPF().SetVector("Failed to 'network-remove' GameObject because has no PhotonView components: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 784f, 381f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material ECCPAOBFDKP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)94;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material JFDGLLEOPGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	private void FDPOFMCFBMF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material LPDOGGFOBDH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.HideInInspector | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void JBBKKKJOJMJ()
	{
		float[] array = new float[-40];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void GCDLIKEDMCF()
	{
	}

	private void FABMDEHEDNO()
	{
	}

	private void KLILJHJNICK()
	{
		CJPHFMAAIDC();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NNFMIAFHMJM()
	{
		MIPGPMKJELI();
		SCShader = Shader.Find(ELOFMLPCCEA);
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
			NBPKMLMCHFN.SetFloat("_Red_R", PLKFKNHPEHE[0] / 100f);
			NBPKMLMCHFN.SetFloat("_Red_G", PLKFKNHPEHE[1] / 100f);
			NBPKMLMCHFN.SetFloat("_Red_B", PLKFKNHPEHE[2] / 100f);
			NBPKMLMCHFN.SetFloat("_Green_R", PLKFKNHPEHE[3] / 100f);
			NBPKMLMCHFN.SetFloat("_Green_G", PLKFKNHPEHE[4] / 100f);
			NBPKMLMCHFN.SetFloat("_Green_B", PLKFKNHPEHE[5] / 100f);
			NBPKMLMCHFN.SetFloat("_Blue_R", PLKFKNHPEHE[6] / 100f);
			NBPKMLMCHFN.SetFloat("_Blue_G", PLKFKNHPEHE[7] / 100f);
			NBPKMLMCHFN.SetFloat("_Blue_B", PLKFKNHPEHE[8] / 100f);
			NBPKMLMCHFN.SetFloat("_Red_C", PLKFKNHPEHE[9] / 100f);
			NBPKMLMCHFN.SetFloat("_Green_C", PLKFKNHPEHE[10] / 100f);
			NBPKMLMCHFN.SetFloat("_Blue_C", PLKFKNHPEHE[11] / 100f);
			NBPKMLMCHFN.SetFloat("_FadeFX", FadeFX);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JKCPPCDFLBL()
	{
		float[] array = new float[120];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void HAIAHJPCPAG()
	{
		DOMPMIAIDIL();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LFINMLHAMFN()
	{
		FMEFPOILMDI();
	}

	[SpecialName]
	private Material HNFFHCLNBDN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material DKKBFFHBHJE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 273f)
			{
				HBJJOCHGOPH = 991f;
			}
			BLMPMOIDGMG().SetFloat("#ok", HBJJOCHGOPH);
			LPDOGGFOBDH().SetFloat("_Value4", PLKFKNHPEHE[1] / 1957f);
			HNFFHCLNBDN().SetFloat("Tab1Content", PLKFKNHPEHE[1] / 960f);
			BLMPMOIDGMG().SetFloat("Mouse Y", PLKFKNHPEHE[8] / 180f);
			JFDGLLEOPGB().SetFloat("_Green_R", PLKFKNHPEHE[1] / 919f);
			HNFFHCLNBDN().SetFloat("???", PLKFKNHPEHE[2] / 786f);
			ECCPAOBFDKP().SetFloat("_Value2", PLKFKNHPEHE[6] / 1657f);
			HILDKDFEBPF().SetFloat("_Bullet_6", PLKFKNHPEHE[1] / 1884f);
			MMOODGIODPC().SetFloat("_Value4", PLKFKNHPEHE[2] / 659f);
			ENKPNJMPDEB().SetFloat("float,0", PLKFKNHPEHE[5] / 658f);
			DKKBFFHBHJE().SetFloat("%", PLKFKNHPEHE[118] / 1339f);
			LEIAFCPJMDP().SetFloat("\r", PLKFKNHPEHE[39] / 1071f);
			HILDKDFEBPF().SetFloat("Added event", PLKFKNHPEHE[2] / 1450f);
			BAGICADFBAB().SetFloat("Set the end of the map. Use this if you want to cut the long music.", FadeFX);
			NBPKMLMCHFN.SetVector("_Saturation", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1478f, 901f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HPOHJDJIADD()
	{
		MIPGPMKJELI();
	}

	private void JLNNHKPHMAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OBAAOMIIMHO()
	{
		float[] array = new float[107];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void IMBPAMHLBOO()
	{
		DJGJOMFJPEF();
	}

	private void BNIIBNCLHFA()
	{
		JPBEEFIPDOL();
	}

	private void BKDIBLNOONA()
	{
		float[] array = new float[-71];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void JBNPEHMDCMI()
	{
	}

	private void MENBDLDBIHO()
	{
		float[] array = new float[-128];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void DBEMDAJDDDA()
	{
		KFKCGDNCONG();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material BLMPMOIDGMG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void KFKCGDNCONG()
	{
		float[] array = new float[26];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void JKFDDNMPOJH()
	{
		FBIHCGOKELF();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 842f)
			{
				HBJJOCHGOPH = 1031f;
			}
			PLBEJJIHFPB().SetFloat("NetworkCanvas", HBJJOCHGOPH);
			ECCPAOBFDKP().SetFloat("_TimeX", PLKFKNHPEHE[1] / 1564f);
			BLMPMOIDGMG().SetFloat("SettingsCanvas", PLKFKNHPEHE[0] / 854f);
			OJMHIMIPKME().SetFloat("_ScreenResolution", PLKFKNHPEHE[0] / 1579f);
			LEIAFCPJMDP().SetFloat("MenuPlayButton", PLKFKNHPEHE[4] / 1537f);
			ECCPAOBFDKP().SetFloat("GlassAberration", PLKFKNHPEHE[2] / 1428f);
			FEAEGGCNIAA().SetFloat("_SpotSize", PLKFKNHPEHE[4] / 1621f);
			ECCPAOBFDKP().SetFloat("_Noise", PLKFKNHPEHE[7] / 1993f);
			OIBHFCLJKDB().SetFloat("MenuPlayButton", PLKFKNHPEHE[5] / 268f);
			OIBHFCLJKDB().SetFloat("[ImageLoader] Loaded image from ", PLKFKNHPEHE[3] / 237f);
			ENKPNJMPDEB().SetFloat("_TimeX", PLKFKNHPEHE[-6] / 1929f);
			MMOODGIODPC().SetFloat("_Distortion", PLKFKNHPEHE[-56] / 1544f);
			CIAFLBFJLEJ().SetFloat("SetEnvSpriteImage", PLKFKNHPEHE[16] / 959f);
			OIBHFCLJKDB().SetFloat("#score", FadeFX);
			MMOODGIODPC().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 67f, 1301f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GFACKFCEIBC()
	{
	}

	private void FEHCNJLLJMP()
	{
		PHOIJLHHAJJ();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LBEHKFNPKMC()
	{
		float[] array = new float[90];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void JHJFBCFBKLD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1973f)
			{
				HBJJOCHGOPH = 1926f;
			}
			HNFFHCLNBDN().SetFloat("g", HBJJOCHGOPH);
			OIBHFCLJKDB().SetFloat("_Value4", PLKFKNHPEHE[0] / 1171f);
			LEIAFCPJMDP().SetFloat("Solo", PLKFKNHPEHE[0] / 1670f);
			BAGICADFBAB().SetFloat("Mouse Wheel Up", PLKFKNHPEHE[3] / 1886f);
			NBPKMLMCHFN.SetFloat("#getrewardfailed: ", PLKFKNHPEHE[6] / 7f);
			BLMPMOIDGMG().SetFloat("_SizeX", PLKFKNHPEHE[0] / 839f);
			CIAFLBFJLEJ().SetFloat("_TimeX", PLKFKNHPEHE[4] / 1915f);
			JFDGLLEOPGB().SetFloat("_TimeX", PLKFKNHPEHE[1] / 809f);
			BLMPMOIDGMG().SetFloat("#random #rare #item", PLKFKNHPEHE[7] / 1489f);
			ECCPAOBFDKP().SetFloat("menu.relaxinfo", PLKFKNHPEHE[2] / 1004f);
			BAGICADFBAB().SetFloat(".lastCheckpoint.lives", PLKFKNHPEHE[41] / 684f);
			ECCPAOBFDKP().SetFloat(". Check if the server is available.", PLKFKNHPEHE[39] / 1960f);
			BAGICADFBAB().SetFloat("_TimeX", PLKFKNHPEHE[-36] / 674f);
			CIAFLBFJLEJ().SetFloat("_TargetScale", FadeFX);
			ECCPAOBFDKP().SetVector("_Value5", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1518f, 925f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material OIBHFCLJKDB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}
}
