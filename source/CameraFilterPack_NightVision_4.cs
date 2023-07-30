// CameraFilterPack_NightVision_4
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Night Vision/Night Vision 4")]
[ExecuteInEditMode]
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
			NBPKMLMCHFN.SetFloat("PointsScoreText", HBJJOCHGOPH);
			OIBHFCLJKDB().SetFloat("_NoiseAmount", PLKFKNHPEHE[0] / 942f);
			OJMHIMIPKME().SetFloat("https://bitbucket.org/khb-soft/intralismarcsviewer/", PLKFKNHPEHE[1] / 1819f);
			PLBEJJIHFPB().SetFloat("offsets", PLKFKNHPEHE[6] / 1683f);
			JFDGLLEOPGB().SetFloat("CameraFilterPack/Gradients_Ansi", PLKFKNHPEHE[5] / 85f);
			HNFFHCLNBDN().SetFloat("CameraFilterPack/FX_8bits", PLKFKNHPEHE[0] / 428f);
			OIBHFCLJKDB().SetFloat(" : ", PLKFKNHPEHE[6] / 1291f);
			LPDOGGFOBDH().SetFloat("Editor/", PLKFKNHPEHE[6] / 566f);
			JFDGLLEOPGB().SetFloat("_TimeX", PLKFKNHPEHE[4] / 1506f);
			BAGICADFBAB().SetFloat("0,7,true,0", PLKFKNHPEHE[6] / 172f);
			MMOODGIODPC().SetFloat("MaxLivesSlider", PLKFKNHPEHE[-112] / 1842f);
			LPDOGGFOBDH().SetFloat("Set particles count per one beat", PLKFKNHPEHE[-86] / 1438f);
			DKKBFFHBHJE().SetFloat("_TintColor", PLKFKNHPEHE[-111] / 1500f);
			JFDGLLEOPGB().SetFloat("_TimeX", FadeFX);
			HILDKDFEBPF().SetVector("CameraFilterPack/Color_RGB", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 189f, 859f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
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
		MIPGPMKJELI();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DBLILJGKGHJ()
	{
		OLGKEEPPPKG();
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
			LPDOGGFOBDH().SetFloat("[#clicktogetreward]", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("SpectatingUserInfo", PLKFKNHPEHE[1] / 1618f);
			MMOODGIODPC().SetFloat("CameraFilterPack/TV_VHS", PLKFKNHPEHE[1] / 1876f);
			HNFFHCLNBDN().SetFloat("Fade", PLKFKNHPEHE[3] / 169f);
			MMOODGIODPC().SetFloat("Cross", PLKFKNHPEHE[8] / 1532f);
			DKKBFFHBHJE().SetFloat("workshop.", PLKFKNHPEHE[5] / 1705f);
			LEIAFCPJMDP().SetFloat("_ScreenResolution", PLKFKNHPEHE[0] / 1113f);
			MMOODGIODPC().SetFloat("musicVolume", PLKFKNHPEHE[5] / 1525f);
			JFDGLLEOPGB().SetFloat("[", PLKFKNHPEHE[0] / 1672f);
			OJMHIMIPKME().SetFloat("[ReplayScene] Loading replay: ", PLKFKNHPEHE[2] / 518f);
			NBPKMLMCHFN.SetFloat("Crosshair2", PLKFKNHPEHE[-48] / 563f);
			MMOODGIODPC().SetFloat("Created", PLKFKNHPEHE[-93] / 1625f);
			BLMPMOIDGMG().SetFloat("_ReflectionTexture2", PLKFKNHPEHE[30] / 352f);
			PLBEJJIHFPB().SetFloat("DISTORT", FadeFX);
			BLMPMOIDGMG().SetVector("Music End", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 537f, 57f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MJEFMIPLFAB()
	{
		OLGKEEPPPKG();
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
			BAGICADFBAB().SetFloat("UseScanLineSize", HBJJOCHGOPH);
			ENKPNJMPDEB().SetFloat("EventMenu", PLKFKNHPEHE[1] / 1140f);
			FEAEGGCNIAA().SetFloat("OnAwakeRPC", PLKFKNHPEHE[1] / 229f);
			HILDKDFEBPF().SetFloat("offsets", PLKFKNHPEHE[2] / 265f);
			ECCPAOBFDKP().SetFloat("offsets", PLKFKNHPEHE[5] / 1917f);
			NBPKMLMCHFN.SetFloat(".lastCheckpoint.checkpointsUsed", PLKFKNHPEHE[5] / 1753f);
			ECCPAOBFDKP().SetFloat("\n", PLKFKNHPEHE[2] / 908f);
			HNFFHCLNBDN().SetFloat("#tryagain", PLKFKNHPEHE[1] / 1396f);
			NBPKMLMCHFN.SetFloat("Hidden/DepthOfField/MedianFilter", PLKFKNHPEHE[1] / 396f);
			ENKPNJMPDEB().SetFloat("CameraFilterPack/Drawing_CellShading", PLKFKNHPEHE[2] / 105f);
			BLMPMOIDGMG().SetFloat("isVisible", PLKFKNHPEHE[31] / 101f);
			BAGICADFBAB().SetFloat("menu.playedpage", PLKFKNHPEHE[67] / 1459f);
			OIBHFCLJKDB().SetFloat("NEW", PLKFKNHPEHE[65] / 1539f);
			CIAFLBFJLEJ().SetFloat("_ScreenResolution", FadeFX);
			LPDOGGFOBDH().SetVector("_FixDistance", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 939f, 1028f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ECCPAOBFDKP());
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
			ECCPAOBFDKP().SetFloat("_Color2", PLKFKNHPEHE[0] / 1256f);
			DKKBFFHBHJE().SetFloat("Can't set MaxPlayers when not in that room.", PLKFKNHPEHE[0] / 895f);
			LEIAFCPJMDP().SetFloat("y", PLKFKNHPEHE[7] / 575f);
			NBPKMLMCHFN.SetFloat("float,0", PLKFKNHPEHE[4] / 1090f);
			BAGICADFBAB().SetFloat("ENABLE_USER_LUT", PLKFKNHPEHE[7] / 1089f);
			ECCPAOBFDKP().SetFloat("_Value2", PLKFKNHPEHE[6] / 1991f);
			OIBHFCLJKDB().SetFloat("_Value4", PLKFKNHPEHE[2] / 1155f);
			JFDGLLEOPGB().SetFloat("settings_bindings_", PLKFKNHPEHE[2] / 1433f);
			DKKBFFHBHJE().SetFloat("CompletedLevel", PLKFKNHPEHE[5] / 470f);
			NBPKMLMCHFN.SetFloat("_Distance", PLKFKNHPEHE[20] / 925f);
			FEAEGGCNIAA().SetFloat("_EdgeWeight", PLKFKNHPEHE[5] / 1786f);
			HILDKDFEBPF().SetFloat("settings.shaders", PLKFKNHPEHE[124] / 1058f);
			ENKPNJMPDEB().SetFloat("_TimeX", FadeFX);
			OIBHFCLJKDB().SetVector(".GoalProgress", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 900f, 1559f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ECCPAOBFDKP());
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
			CIAFLBFJLEJ().SetFloat("_History3Weight", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("PhotonView with ID {0} wasn't properly unregistered! Please report this case to developer@photonengine.com", PLKFKNHPEHE[0] / 1727f);
			BAGICADFBAB().SetFloat("Data/Maps/", PLKFKNHPEHE[0] / 1899f);
			HNFFHCLNBDN().SetFloat("_Offsets", PLKFKNHPEHE[4] / 779f);
			LPDOGGFOBDH().SetFloat("workshop.", PLKFKNHPEHE[4] / 1983f);
			ENKPNJMPDEB().SetFloat(". The RPC has been ignored.", PLKFKNHPEHE[3] / 304f);
			ENKPNJMPDEB().SetFloat("Sprite", PLKFKNHPEHE[4] / 1236f);
			FEAEGGCNIAA().SetFloat("FileMenu", PLKFKNHPEHE[4] / 1332f);
			HILDKDFEBPF().SetFloat(".played", PLKFKNHPEHE[6] / 717f);
			OJMHIMIPKME().SetFloat("/", PLKFKNHPEHE[8] / 1160f);
			BLMPMOIDGMG().SetFloat("player.greenlollipop", PLKFKNHPEHE[-31] / 1598f);
			BLMPMOIDGMG().SetFloat("_FixDistance", PLKFKNHPEHE[-66] / 768f);
			ECCPAOBFDKP().SetFloat("_Value2", PLKFKNHPEHE[-68] / 1709f);
			CIAFLBFJLEJ().SetFloat("Joystick1Button1", FadeFX);
			HILDKDFEBPF().SetVector("value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1801f, 1505f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BAGICADFBAB());
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
			PLBEJJIHFPB().SetFloat("' ping: ", HBJJOCHGOPH);
			OJMHIMIPKME().SetFloat(":</b> ", PLKFKNHPEHE[0] / 691f);
			OJMHIMIPKME().SetFloat("CameraFilterPack/3D_Distortion", PLKFKNHPEHE[0] / 64f);
			BLMPMOIDGMG().SetFloat("_Blue_G", PLKFKNHPEHE[3] / 1520f);
			ENKPNJMPDEB().SetFloat(" TimeOfRespawn: ", PLKFKNHPEHE[0] / 115f);
			HILDKDFEBPF().SetFloat("_PColor2", PLKFKNHPEHE[1] / 1278f);
			LPDOGGFOBDH().SetFloat("A", PLKFKNHPEHE[6] / 830f);
			CIAFLBFJLEJ().SetFloat("_Value", PLKFKNHPEHE[3] / 991f);
			JFDGLLEOPGB().SetFloat("\n\n• ", PLKFKNHPEHE[6] / 864f);
			FEAEGGCNIAA().SetFloat("player.watermelon", PLKFKNHPEHE[6] / 1725f);
			LEIAFCPJMDP().SetFloat("maps.", PLKFKNHPEHE[88] / 1607f);
			LEIAFCPJMDP().SetFloat("_Green_G", PLKFKNHPEHE[-115] / 1398f);
			JFDGLLEOPGB().SetFloat("maps.", PLKFKNHPEHE[-4] / 131f);
			LPDOGGFOBDH().SetFloat("#tryagain", FadeFX);
			ENKPNJMPDEB().SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 384f, 1628f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GPJHPNGNEBP()
	{
		NDAIGNNKOAC();
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
		JKCPPCDFLBL();
	}

	private void MMMDPANNAIO()
	{
		JIGIHDNCJHE();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LGHCJCFHEMF()
	{
		NFMCBMDELNK();
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
			NBPKMLMCHFN.SetFloat("ItemNameText", HBJJOCHGOPH);
			HILDKDFEBPF().SetFloat("_EmissionColor", PLKFKNHPEHE[0] / 1154f);
			DKKBFFHBHJE().SetFloat("[GameScene] Submiting rank", PLKFKNHPEHE[0] / 1652f);
			BAGICADFBAB().SetFloat("maps.", PLKFKNHPEHE[4] / 243f);
			LPDOGGFOBDH().SetFloat("CameraFilterPack/FX_8bits_gb", PLKFKNHPEHE[2] / 1684f);
			JFDGLLEOPGB().SetFloat("RecordButton", PLKFKNHPEHE[1] / 428f);
			PLBEJJIHFPB().SetFloat("#tryagain", PLKFKNHPEHE[0] / 318f);
			JFDGLLEOPGB().SetFloat("g", PLKFKNHPEHE[1] / 1676f);
			PLBEJJIHFPB().SetFloat("{\"items\":", PLKFKNHPEHE[7] / 1878f);
			OIBHFCLJKDB().SetFloat("_ScreenResolution", PLKFKNHPEHE[8] / 1221f);
			OJMHIMIPKME().SetFloat("_Value8", PLKFKNHPEHE[113] / 1009f);
			JFDGLLEOPGB().SetFloat("]", PLKFKNHPEHE[-74] / 877f);
			BLMPMOIDGMG().SetFloat("_Value4", PLKFKNHPEHE[-60] / 240f);
			FEAEGGCNIAA().SetFloat("NetworkCanvas", FadeFX);
			CIAFLBFJLEJ().SetVector("[Up-Right]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 881f, 1791f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ENKPNJMPDEB());
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
		JIGIHDNCJHE();
	}

	private void MGGFMCIGOAF()
	{
		float[] array = new float[92];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void COIJKMKIEAK()
	{
		DJGJOMFJPEF();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KOFAMEKHHGD()
	{
		JBBKKKJOJMJ();
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
		CJPHFMAAIDC();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IDJKNBDKHBD()
	{
		JKCPPCDFLBL();
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
			HNFFHCLNBDN().SetFloat("Committing changes...", HBJJOCHGOPH);
			BLMPMOIDGMG().SetFloat("IconFileSelector", PLKFKNHPEHE[1] / 92f);
			ECCPAOBFDKP().SetFloat("GameScene", PLKFKNHPEHE[0] / 1399f);
			FEAEGGCNIAA().SetFloat("_Value4", PLKFKNHPEHE[5] / 1310f);
			LEIAFCPJMDP().SetFloat("settings_bindings_", PLKFKNHPEHE[4] / 673f);
			OIBHFCLJKDB().SetFloat("_Offsets", PLKFKNHPEHE[6] / 656f);
			BAGICADFBAB().SetFloat("y", PLKFKNHPEHE[0] / 1393f);
			LEIAFCPJMDP().SetFloat("settings.arcshitsoundtimedelay", PLKFKNHPEHE[0] / 1103f);
			ECCPAOBFDKP().SetFloat("CameraFilterPack/Gradients_Stripe", PLKFKNHPEHE[3] / 1311f);
			ENKPNJMPDEB().SetFloat("GameObject ", PLKFKNHPEHE[6] / 709f);
			BAGICADFBAB().SetFloat("Object ID", PLKFKNHPEHE[-17] / 127f);
			OJMHIMIPKME().SetFloat("Set sun audio input", PLKFKNHPEHE[-11] / 1080f);
			DKKBFFHBHJE().SetFloat("_Value", PLKFKNHPEHE[-30] / 415f);
			LPDOGGFOBDH().SetFloat("_ScreenResolution", FadeFX);
			DKKBFFHBHJE().SetVector("SendVacantViewIds()", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1769f, 609f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
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
			FEAEGGCNIAA().SetFloat("CameraFilterPack/Distortion_Dream", HBJJOCHGOPH);
			HNFFHCLNBDN().SetFloat("_Value2", PLKFKNHPEHE[1] / 1636f);
			OJMHIMIPKME().SetFloat("#mapby", PLKFKNHPEHE[1] / 1462f);
			HILDKDFEBPF().SetFloat("/icon", PLKFKNHPEHE[4] / 1459f);
			NBPKMLMCHFN.SetFloat("Adding player twice: ", PLKFKNHPEHE[6] / 198f);
			HNFFHCLNBDN().SetFloat("_FarCamera", PLKFKNHPEHE[5] / 189f);
			FEAEGGCNIAA().SetFloat("mapselector.filter.rateduponly", PLKFKNHPEHE[5] / 1215f);
			NBPKMLMCHFN.SetFloat("{0} seconds ago", PLKFKNHPEHE[7] / 168f);
			HILDKDFEBPF().SetFloat(" ", PLKFKNHPEHE[5] / 1080f);
			LPDOGGFOBDH().SetFloat("Set Parent", PLKFKNHPEHE[7] / 562f);
			LEIAFCPJMDP().SetFloat("_ScreenResolution", PLKFKNHPEHE[-49] / 624f);
			OJMHIMIPKME().SetFloat("BitsData", PLKFKNHPEHE[-7] / 1600f);
			HILDKDFEBPF().SetFloat("Stream did not contain properly formatted byte array", PLKFKNHPEHE[0] / 628f);
			BLMPMOIDGMG().SetFloat("isVisible", FadeFX);
			CIAFLBFJLEJ().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1708f, 1803f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
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
			PLBEJJIHFPB().SetFloat("GetGameList failed: ", HBJJOCHGOPH);
			LEIAFCPJMDP().SetFloat("speed", PLKFKNHPEHE[1] / 206f);
			HNFFHCLNBDN().SetFloat("levelcompleted", PLKFKNHPEHE[0] / 1201f);
			NBPKMLMCHFN.SetFloat("SetEnvSpriteImage", PLKFKNHPEHE[3] / 33f);
			ECCPAOBFDKP().SetFloat("Back", PLKFKNHPEHE[3] / 972f);
			OIBHFCLJKDB().SetFloat("_AlphaMask", PLKFKNHPEHE[6] / 193f);
			HILDKDFEBPF().SetFloat("_Offsets", PLKFKNHPEHE[0] / 1946f);
			JFDGLLEOPGB().SetFloat("#ok", PLKFKNHPEHE[3] / 1927f);
			JFDGLLEOPGB().SetFloat("HiddenToggle", PLKFKNHPEHE[0] / 503f);
			PLBEJJIHFPB().SetFloat(" could not be executed (yet). Wait for state JoinedLobby or ConnectedToMaster and their callbacks before calling operations. WebRPCs need a server-side configuration. Enum OperationCode helps identify the operation.", PLKFKNHPEHE[1] / 1084f);
			LEIAFCPJMDP().SetFloat("GlassesColor2", PLKFKNHPEHE[-8] / 306f);
			OIBHFCLJKDB().SetFloat("Source: ", PLKFKNHPEHE[-71] / 678f);
			DKKBFFHBHJE().SetFloat("d264dbba9c2410771b4ad918903b3f4cd9e276a9", PLKFKNHPEHE[84] / 658f);
			OIBHFCLJKDB().SetFloat("_Value2", FadeFX);
			JFDGLLEOPGB().SetVector("_History3ChromaTex", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 39f, 1754f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
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
		NDAIGNNKOAC();
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
		LBEHKFNPKMC();
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
			HNFFHCLNBDN().SetFloat("CameraFilterPack/Blend2Camera_SoftLight", HBJJOCHGOPH);
			OJMHIMIPKME().SetFloat("MessageText", PLKFKNHPEHE[1] / 403f);
			MMOODGIODPC().SetFloat("_History1ChromaTex", PLKFKNHPEHE[0] / 318f);
			JFDGLLEOPGB().SetFloat("Connected to masterserver.", PLKFKNHPEHE[4] / 329f);
			LPDOGGFOBDH().SetFloat("_ReflectionTexture3", PLKFKNHPEHE[7] / 119f);
			BAGICADFBAB().SetFloat("_ScreenResolution", PLKFKNHPEHE[5] / 1938f);
			MMOODGIODPC().SetFloat(" ", PLKFKNHPEHE[6] / 1746f);
			ECCPAOBFDKP().SetFloat("id", PLKFKNHPEHE[7] / 34f);
			BAGICADFBAB().SetFloat("<command>", PLKFKNHPEHE[0] / 213f);
			CIAFLBFJLEJ().SetFloat("maps.", PLKFKNHPEHE[5] / 1600f);
			LPDOGGFOBDH().SetFloat("Tab1Content", PLKFKNHPEHE[-78] / 986f);
			DKKBFFHBHJE().SetFloat("_BlurCoe", PLKFKNHPEHE[93] / 1784f);
			MMOODGIODPC().SetFloat("</i>", PLKFKNHPEHE[-85] / 1634f);
			HNFFHCLNBDN().SetFloat("_Value2", FadeFX);
			OJMHIMIPKME().SetVector("_Intensity", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 106f, 1655f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
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
		MENBDLDBIHO();
	}

	private void FMFNILJIEIA()
	{
		NFMCBMDELNK();
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
			BLMPMOIDGMG().SetFloat("settings_bindings_", HBJJOCHGOPH);
			BAGICADFBAB().SetFloat("settings.shaders.bloomintencity", PLKFKNHPEHE[1] / 946f);
			FEAEGGCNIAA().SetFloat("DPADHOR", PLKFKNHPEHE[1] / 563f);
			ECCPAOBFDKP().SetFloat("Hex value #RRGGBB", PLKFKNHPEHE[7] / 752f);
			DKKBFFHBHJE().SetFloat("_MainTex2", PLKFKNHPEHE[5] / 951f);
			PLBEJJIHFPB().SetFloat(".a", PLKFKNHPEHE[8] / 1180f);
			LPDOGGFOBDH().SetFloat("_ScreenResolution", PLKFKNHPEHE[2] / 1890f);
			BLMPMOIDGMG().SetFloat("_Offsets", PLKFKNHPEHE[7] / 418f);
			BLMPMOIDGMG().SetFloat("#close", PLKFKNHPEHE[6] / 613f);
			LEIAFCPJMDP().SetFloat("/?page=ranks", PLKFKNHPEHE[8] / 13f);
			ENKPNJMPDEB().SetFloat("ConfigVersionSlider", PLKFKNHPEHE[-92] / 1070f);
			ECCPAOBFDKP().SetFloat("_ScreenResolution", PLKFKNHPEHE[-66] / 165f);
			BAGICADFBAB().SetFloat("settings_bindings_", PLKFKNHPEHE[-67] / 162f);
			FEAEGGCNIAA().SetFloat("_color", FadeFX);
			LEIAFCPJMDP().SetVector("_Far", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 183f, 1529f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HILDKDFEBPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DLBODOFAJGM()
	{
		MIPGPMKJELI();
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
			LEIAFCPJMDP().SetFloat("_NoiseTex", HBJJOCHGOPH);
			CIAFLBFJLEJ().SetFloat("CameraFilterPack/FX_8bits_gb", PLKFKNHPEHE[0] / 92f);
			LPDOGGFOBDH().SetFloat("CameraFilterPack/Fly_Vision", PLKFKNHPEHE[1] / 410f);
			HNFFHCLNBDN().SetFloat("StartCanvas", PLKFKNHPEHE[4] / 1781f);
			OIBHFCLJKDB().SetFloat("offsets", PLKFKNHPEHE[2] / 1065f);
			PLBEJJIHFPB().SetFloat("Object ID. Case-Sensitive", PLKFKNHPEHE[1] / 132f);
			JFDGLLEOPGB().SetFloat("note.7", PLKFKNHPEHE[0] / 1348f);
			OJMHIMIPKME().SetFloat("InfoText", PLKFKNHPEHE[5] / 1307f);
			LEIAFCPJMDP().SetFloat("Attempting to remove texture that was not allocated: {0}", PLKFKNHPEHE[8] / 547f);
			NBPKMLMCHFN.SetFloat("Tab2Content", PLKFKNHPEHE[4] / 309f);
			BLMPMOIDGMG().SetFloat("_Val", PLKFKNHPEHE[-67] / 344f);
			OJMHIMIPKME().SetFloat("OK", PLKFKNHPEHE[46] / 1329f);
			OJMHIMIPKME().SetFloat("[DiscordController] Shutdown", PLKFKNHPEHE[-111] / 687f);
			ENKPNJMPDEB().SetFloat("_Amount", FadeFX);
			HILDKDFEBPF().SetVector("\t", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1740f, 991f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNFFHCLNBDN());
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
			OJMHIMIPKME().SetFloat("PunPickupSimple", HBJJOCHGOPH);
			OJMHIMIPKME().SetFloat("MusicFileSelector", PLKFKNHPEHE[0] / 1819f);
			HNFFHCLNBDN().SetFloat("effector", PLKFKNHPEHE[1] / 59f);
			MMOODGIODPC().SetFloat("Fade", PLKFKNHPEHE[4] / 602f);
			LEIAFCPJMDP().SetFloat("UNDISTORT", PLKFKNHPEHE[1] / 1040f);
			OJMHIMIPKME().SetFloat("OxOD.lastPath", PLKFKNHPEHE[0] / 0f);
			PLBEJJIHFPB().SetFloat("note.5", PLKFKNHPEHE[1] / 1801f);
			PLBEJJIHFPB().SetFloat("_Value4", PLKFKNHPEHE[8] / 783f);
			OIBHFCLJKDB().SetFloat("UseFinalGlassColor", PLKFKNHPEHE[3] / 1124f);
			BLMPMOIDGMG().SetFloat("note.4", PLKFKNHPEHE[1] / 497f);
			BAGICADFBAB().SetFloat("CameraFilterPack/BlurHole", PLKFKNHPEHE[-30] / 1496f);
			MMOODGIODPC().SetFloat("ItemNameText", PLKFKNHPEHE[-126] / 1595f);
			NBPKMLMCHFN.SetFloat("_DotSize", PLKFKNHPEHE[-68] / 518f);
			FEAEGGCNIAA().SetFloat("Right Stick Click", FadeFX);
			LEIAFCPJMDP().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 53f, 981f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
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
			ECCPAOBFDKP().SetFloat("</color>", HBJJOCHGOPH);
			LEIAFCPJMDP().SetFloat("_FadeFX", PLKFKNHPEHE[1] / 102f);
			LPDOGGFOBDH().SetFloat("Edited event", PLKFKNHPEHE[0] / 1765f);
			OIBHFCLJKDB().SetFloat("[MapEditor] Loading map: ", PLKFKNHPEHE[1] / 711f);
			LEIAFCPJMDP().SetFloat("...", PLKFKNHPEHE[3] / 1282f);
			FEAEGGCNIAA().SetFloat("_Value6", PLKFKNHPEHE[8] / 180f);
			ENKPNJMPDEB().SetFloat("_ScreenResolution", PLKFKNHPEHE[2] / 804f);
			JFDGLLEOPGB().SetFloat("[LevelEditorScene] Print Audio Wave: Start", PLKFKNHPEHE[5] / 484f);
			ENKPNJMPDEB().SetFloat("Edited unlock conditions", PLKFKNHPEHE[0] / 1996f);
			HNFFHCLNBDN().SetFloat("LevelNameInputField", PLKFKNHPEHE[4] / 801f);
			OIBHFCLJKDB().SetFloat("<color=#{0}>{1}</color>", PLKFKNHPEHE[-26] / 1367f);
			CIAFLBFJLEJ().SetFloat("menu.enableselectormusic", PLKFKNHPEHE[67] / 1811f);
			DKKBFFHBHJE().SetFloat("_Amount", PLKFKNHPEHE[-78] / 781f);
			LEIAFCPJMDP().SetFloat("#score", FadeFX);
			FEAEGGCNIAA().SetVector("true", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 950f, 289f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
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
			NBPKMLMCHFN.SetFloat("_ScreenResolution", HBJJOCHGOPH);
			LPDOGGFOBDH().SetFloat("custom", PLKFKNHPEHE[0] / 246f);
			BAGICADFBAB().SetFloat("accuracy", PLKFKNHPEHE[1] / 815f);
			BLMPMOIDGMG().SetFloat("inventory.selected.", PLKFKNHPEHE[3] / 682f);
			MMOODGIODPC().SetFloat("_NoiseTex", PLKFKNHPEHE[7] / 713f);
			JFDGLLEOPGB().SetFloat("LastNewsButton", PLKFKNHPEHE[4] / 477f);
			MMOODGIODPC().SetFloat("_ScreenResolution", PLKFKNHPEHE[6] / 754f);
			BLMPMOIDGMG().SetFloat("MapEnd", PLKFKNHPEHE[8] / 136f);
			BLMPMOIDGMG().SetFloat("#orderby:", PLKFKNHPEHE[7] / 440f);
			MMOODGIODPC().SetFloat("_ScreenResolution", PLKFKNHPEHE[4] / 1794f);
			ENKPNJMPDEB().SetFloat("id", PLKFKNHPEHE[12] / 1885f);
			PLBEJJIHFPB().SetFloat("Left Stick Click", PLKFKNHPEHE[-42] / 242f);
			OJMHIMIPKME().SetFloat("CameraFilterPack/AAA_Super_Hexagon", PLKFKNHPEHE[-45] / 1716f);
			NBPKMLMCHFN.SetFloat("#", FadeFX);
			MMOODGIODPC().SetVector(".completed", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1519f, 977f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HILDKDFEBPF());
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
		OBAAOMIIMHO();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CGDMLHLJIDK()
	{
		FMEFPOILMDI();
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
		JBBKKKJOJMJ();
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
			PLBEJJIHFPB().SetFloat("Tab1Content", HBJJOCHGOPH);
			OIBHFCLJKDB().SetFloat("Hidden/Fast Approximate Anti-aliasing", PLKFKNHPEHE[1] / 717f);
			HNFFHCLNBDN().SetFloat("_TimeX", PLKFKNHPEHE[1] / 1508f);
			HILDKDFEBPF().SetFloat(" TimeOfRespawn: ", PLKFKNHPEHE[4] / 1252f);
			LPDOGGFOBDH().SetFloat("[Up-Down]", PLKFKNHPEHE[5] / 1273f);
			JFDGLLEOPGB().SetFloat("#md5submitionfailed: ", PLKFKNHPEHE[5] / 1454f);
			ENKPNJMPDEB().SetFloat("Received RPC \"", PLKFKNHPEHE[2] / 1736f);
			FEAEGGCNIAA().SetFloat("Edited unlock conditions", PLKFKNHPEHE[7] / 181f);
			HNFFHCLNBDN().SetFloat("OpSetPropertiesOfActor not sent. ActorNr must be > 0 and actorProperties != null.", PLKFKNHPEHE[4] / 1705f);
			FEAEGGCNIAA().SetFloat("EventData0DropDownList", PLKFKNHPEHE[7] / 0f);
			OJMHIMIPKME().SetFloat("Set camera background color", PLKFKNHPEHE[119] / 1652f);
			HNFFHCLNBDN().SetFloat("_MainTex2", PLKFKNHPEHE[96] / 345f);
			CIAFLBFJLEJ().SetFloat("_AdaptTex", PLKFKNHPEHE[39] / 1494f);
			OIBHFCLJKDB().SetFloat(" AuthMode ", FadeFX);
			OJMHIMIPKME().SetVector("SpawnObj", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 255f, 1687f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
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
			BLMPMOIDGMG().SetFloat("ItemsStoreButton", HBJJOCHGOPH);
			ECCPAOBFDKP().SetFloat(").", PLKFKNHPEHE[1] / 1662f);
			MMOODGIODPC().SetFloat("Connection error: ", PLKFKNHPEHE[0] / 176f);
			JFDGLLEOPGB().SetFloat("player.circle", PLKFKNHPEHE[5] / 1674f);
			LEIAFCPJMDP().SetFloat("MapperNameText", PLKFKNHPEHE[1] / 302f);
			BLMPMOIDGMG().SetFloat("back", PLKFKNHPEHE[7] / 1540f);
			JFDGLLEOPGB().SetFloat("CameraFilterPack/Gradients_Rainbow", PLKFKNHPEHE[0] / 670f);
			OIBHFCLJKDB().SetFloat("HandsCountSlider", PLKFKNHPEHE[5] / 1887f);
			JFDGLLEOPGB().SetFloat("_SpotSize", PLKFKNHPEHE[7] / 1210f);
			ENKPNJMPDEB().SetFloat("CameraFilterPack/Antialiasing_FXAA", PLKFKNHPEHE[8] / 1224f);
			ENKPNJMPDEB().SetFloat("_BlurPass", PLKFKNHPEHE[-82] / 934f);
			NBPKMLMCHFN.SetFloat("Malformed RPC; this should never occur. Content: ", PLKFKNHPEHE[-109] / 1037f);
			ECCPAOBFDKP().SetFloat("_Offsets", PLKFKNHPEHE[126] / 1971f);
			NBPKMLMCHFN.SetFloat("_SunColor", FadeFX);
			LPDOGGFOBDH().SetVector("CameraFilterPack/Retro_Loading", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 157f, 835f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MEBPBNLBECA()
	{
		BKDIBLNOONA();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DBIBFOINCKM()
	{
		CJPHFMAAIDC();
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
		NBMEBBHCNMH();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GHMDNIFLGOB()
	{
		JBBKKKJOJMJ();
	}

	private void ALJEJJCIMJN()
	{
		BKDIBLNOONA();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EBBMDDEFNKL()
	{
		PHOIJLHHAJJ();
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
			DKKBFFHBHJE().SetFloat(".wav", HBJJOCHGOPH);
			BLMPMOIDGMG().SetFloat("[NetworkMenu] Joining ", PLKFKNHPEHE[0] / 1291f);
			OIBHFCLJKDB().SetFloat("stretchWidth", PLKFKNHPEHE[1] / 1139f);
			LEIAFCPJMDP().SetFloat("_ScreenResolution", PLKFKNHPEHE[0] / 43f);
			FEAEGGCNIAA().SetFloat("]", PLKFKNHPEHE[8] / 1428f);
			OIBHFCLJKDB().SetFloat("yesterday", PLKFKNHPEHE[7] / 1272f);
			HILDKDFEBPF().SetFloat("_Value3", PLKFKNHPEHE[6] / 1675f);
			MMOODGIODPC().SetFloat("_TimeX", PLKFKNHPEHE[7] / 1945f);
			MMOODGIODPC().SetFloat("No player left to ask", PLKFKNHPEHE[1] / 451f);
			JFDGLLEOPGB().SetFloat("_ReflectionBufferSize", PLKFKNHPEHE[7] / 1880f);
			HNFFHCLNBDN().SetFloat("MessageText", PLKFKNHPEHE[63] / 505f);
			OJMHIMIPKME().SetFloat("CameraFilterPack/Atmosphere_Rain_Pro_3D", PLKFKNHPEHE[65] / 776f);
			ECCPAOBFDKP().SetFloat("settings.enableranking", PLKFKNHPEHE[-59] / 1378f);
			HNFFHCLNBDN().SetFloat("_Near", FadeFX);
			MMOODGIODPC().SetVector("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 784f, 381f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
		JIGIHDNCJHE();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NNFMIAFHMJM()
	{
		MENBDLDBIHO();
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
		NDAIGNNKOAC();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LFINMLHAMFN()
	{
		JIGIHDNCJHE();
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
			CIAFLBFJLEJ().SetFloat("#exit", HBJJOCHGOPH);
			LEIAFCPJMDP().SetFloat("_Value3", PLKFKNHPEHE[1] / 1957f);
			CIAFLBFJLEJ().SetFloat("Tab2Content", PLKFKNHPEHE[1] / 960f);
			HILDKDFEBPF().SetFloat("DPADHOR", PLKFKNHPEHE[8] / 180f);
			MMOODGIODPC().SetFloat("_Red_G", PLKFKNHPEHE[1] / 919f);
			PLBEJJIHFPB().SetFloat("CountEventsGoal", PLKFKNHPEHE[2] / 786f);
			OJMHIMIPKME().SetFloat("_Value", PLKFKNHPEHE[6] / 1657f);
			JFDGLLEOPGB().SetFloat("_Bullet_5", PLKFKNHPEHE[1] / 1884f);
			BLMPMOIDGMG().SetFloat("_Value4", PLKFKNHPEHE[2] / 659f);
			NBPKMLMCHFN.SetFloat("value", PLKFKNHPEHE[5] / 658f);
			FEAEGGCNIAA().SetFloat(" ", PLKFKNHPEHE[118] / 1339f);
			MMOODGIODPC().SetFloat("\r", PLKFKNHPEHE[39] / 1071f);
			LEIAFCPJMDP().SetFloat("checkpoint", PLKFKNHPEHE[2] / 1450f);
			DKKBFFHBHJE().SetFloat("Music End", FadeFX);
			OJMHIMIPKME().SetVector("_Brightness", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1478f, 901f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HILDKDFEBPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HPOHJDJIADD()
	{
		FJNEBMBJPLK();
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
		PHINJDJEFLI();
	}

	private void BNIIBNCLHFA()
	{
		FALHNNJBOEM();
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
		LBEHKFNPKMC();
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
		FJNEBMBJPLK();
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
			OIBHFCLJKDB().SetFloat("In Main Menu", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("_ScreenResolution", PLKFKNHPEHE[1] / 1564f);
			LEIAFCPJMDP().SetFloat(" x ", PLKFKNHPEHE[0] / 854f);
			HNFFHCLNBDN().SetFloat("_ScreenResolution", PLKFKNHPEHE[0] / 1579f);
			HNFFHCLNBDN().SetFloat("MenuPlayButton", PLKFKNHPEHE[4] / 1537f);
			CIAFLBFJLEJ().SetFloat("GlassDistortion", PLKFKNHPEHE[2] / 1428f);
			JFDGLLEOPGB().SetFloat("_Radius", PLKFKNHPEHE[4] / 1621f);
			CIAFLBFJLEJ().SetFloat("_Glitch", PLKFKNHPEHE[7] / 1993f);
			BLMPMOIDGMG().SetFloat("MenuPlayButton", PLKFKNHPEHE[5] / 268f);
			LEIAFCPJMDP().SetFloat("file://", PLKFKNHPEHE[3] / 237f);
			HNFFHCLNBDN().SetFloat("CameraFilterPack/FX_Hypno", PLKFKNHPEHE[-6] / 1929f);
			HNFFHCLNBDN().SetFloat("_TimeX", PLKFKNHPEHE[-56] / 1544f);
			LEIAFCPJMDP().SetFloat("Spawn new environment sprite (image) and sets its id", PLKFKNHPEHE[16] / 959f);
			LEIAFCPJMDP().SetFloat("#score", FadeFX);
			OIBHFCLJKDB().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 67f, 1301f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
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
		JPBEEFIPDOL();
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
			JFDGLLEOPGB().SetFloat("a", HBJJOCHGOPH);
			BLMPMOIDGMG().SetFloat("_Value3", PLKFKNHPEHE[0] / 1171f);
			BLMPMOIDGMG().SetFloat("Solo", PLKFKNHPEHE[0] / 1670f);
			LEIAFCPJMDP().SetFloat("Mouse ", PLKFKNHPEHE[3] / 1886f);
			PLBEJJIHFPB().SetFloat("bad", PLKFKNHPEHE[6] / 7f);
			PLBEJJIHFPB().SetFloat("_Distortion", PLKFKNHPEHE[0] / 839f);
			HILDKDFEBPF().SetFloat("_TimeX", PLKFKNHPEHE[4] / 1915f);
			ENKPNJMPDEB().SetFloat("_TimeX", PLKFKNHPEHE[1] / 809f);
			MMOODGIODPC().SetFloat("randomdrop", PLKFKNHPEHE[7] / 1489f);
			LPDOGGFOBDH().SetFloat("menu.relaxinfo", PLKFKNHPEHE[2] / 1004f);
			PLBEJJIHFPB().SetFloat(".", PLKFKNHPEHE[41] / 684f);
			BLMPMOIDGMG().SetFloat("This might be a misconfiguration in the game server config. You need to edit it to a (public) address.", PLKFKNHPEHE[39] / 1960f);
			JFDGLLEOPGB().SetFloat("_TimeX", PLKFKNHPEHE[-36] / 674f);
			BLMPMOIDGMG().SetFloat("_Intensity", FadeFX);
			BAGICADFBAB().SetVector("_Value4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1518f, 925f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNFFHCLNBDN());
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
