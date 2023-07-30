// CameraFilterPack_Oculus_NightVision2
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Night Vision/Night Vision 2")]
public class CameraFilterPack_Oculus_NightVision2 : MonoBehaviour
{
	private string ELOFMLPCCEA = "CameraFilterPack/Oculus_NightVision2";

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

	[SpecialName]
	private Material HNICHJCGJOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void BMODOIJGIOO()
	{
	}

	private void LBEHKFNPKMC()
	{
		float[] array = new float[-31];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 736f)
			{
				HBJJOCHGOPH = 1899f;
			}
			KAFBNOBOIAJ().SetFloat("{0}{1}{2}={3}", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat("Horizontal", PLKFKNHPEHE[1] / 587f);
			HNICHJCGJOC().SetFloat("0,7,true,0", PLKFKNHPEHE[0] / 1889f);
			KAFBNOBOIAJ().SetFloat("CameraFilterPack/Gradients_NeonGradient", PLKFKNHPEHE[3] / 1173f);
			DBOLLHHMKKN().SetFloat("CameraFilterPack/AAA_WaterDrop", PLKFKNHPEHE[7] / 457f);
			JFDGLLEOPGB().SetFloat("No player left to ask", PLKFKNHPEHE[6] / 1155f);
			NDMPCDHADMJ().SetFloat("_Blue_C", PLKFKNHPEHE[3] / 1464f);
			HHIAIGCAHDA().SetFloat("_Value5", PLKFKNHPEHE[7] / 388f);
			HNICHJCGJOC().SetFloat("float,1.5", PLKFKNHPEHE[0] / 1124f);
			NDMPCDHADMJ().SetFloat("[LevelEditorScene] Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(", PLKFKNHPEHE[5] / 1646f);
			NBPKMLMCHFN.SetFloat("Fade", PLKFKNHPEHE[36] / 736f);
			CFEDGDGBCHE().SetFloat("BadgeText", PLKFKNHPEHE[64] / 779f);
			AELJLBOJAIL().SetFloat("_Amount", PLKFKNHPEHE[24] / 1801f);
			DBOLLHHMKKN().SetFloat("resource id", FadeFX);
			NFMGLIKNOOC().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1897f, 1991f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LCHBFNIPBHB()
	{
	}

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 870f)
			{
				HBJJOCHGOPH = 1286f;
			}
			NBMPPNFKFLB().SetFloat("_Blue_G", HBJJOCHGOPH);
			NDMPCDHADMJ().SetFloat("SetSatelliteEmission", PLKFKNHPEHE[0] / 270f);
			CFEDGDGBCHE().SetFloat("_EmissionColor", PLKFKNHPEHE[1] / 311f);
			NBMPPNFKFLB().SetFloat("_Distortion", PLKFKNHPEHE[1] / 1531f);
			HHIAIGCAHDA().SetFloat("[PlayerController] ", PLKFKNHPEHE[3] / 909f);
			NBPKMLMCHFN.SetFloat("selColor", PLKFKNHPEHE[4] / 237f);
			HFBJAOFLCJI().SetFloat("/", PLKFKNHPEHE[3] / 792f);
			NBPKMLMCHFN.SetFloat("_Value4", PLKFKNHPEHE[7] / 654f);
			NDMPCDHADMJ().SetFloat("y", PLKFKNHPEHE[5] / 6f);
			DBOLLHHMKKN().SetFloat("[Steamworks.NET] Could not load [lib]steam_api.dll/so/dylib. It's likely not in the correct location. Refer to the README for more details.\n", PLKFKNHPEHE[1] / 793f);
			HFBJAOFLCJI().SetFloat("LevelInfoInputField", PLKFKNHPEHE[-31] / 184f);
			BFGNMFCNDBC().SetFloat("Can't SendMove. Turn is finished by this player.", PLKFKNHPEHE[-30] / 792f);
			HFBJAOFLCJI().SetFloat("skin.", PLKFKNHPEHE[95] / 125f);
			DBOLLHHMKKN().SetFloat("_Red_R", FadeFX);
			NBMPPNFKFLB().SetVector("_Contrast", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 476f, 1916f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MKIMDFLBFOM()
	{
		GPHHNFDCFMC();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GPHHNFDCFMC()
	{
		float[] array = new float[24];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void EALEEMOPJNO()
	{
		float[] array = new float[-96];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1805f)
			{
				HBJJOCHGOPH = 109f;
			}
			JFDGLLEOPGB().SetFloat("SpawnObj", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("bad", PLKFKNHPEHE[0] / 257f);
			NFMGLIKNOOC().SetFloat("_Fade", PLKFKNHPEHE[1] / 972f);
			HFBJAOFLCJI().SetFloat("value", PLKFKNHPEHE[4] / 1481f);
			HHIAIGCAHDA().SetFloat("CameraFilterPack/Glow_Glow", PLKFKNHPEHE[6] / 412f);
			AELJLBOJAIL().SetFloat("Missing shader in ", PLKFKNHPEHE[5] / 1189f);
			KAFBNOBOIAJ().SetFloat("MusicFileSelector", PLKFKNHPEHE[3] / 880f);
			NBMPPNFKFLB().SetFloat("_Value", PLKFKNHPEHE[1] / 1289f);
			AELJLBOJAIL().SetFloat("<b>", PLKFKNHPEHE[4] / 717f);
			NBPKMLMCHFN.SetFloat("#activechallenges", PLKFKNHPEHE[5] / 1297f);
			DBOLLHHMKKN().SetFloat(".lastCheckpoint.correctScore", PLKFKNHPEHE[72] / 317f);
			NBPKMLMCHFN.SetFloat("/", PLKFKNHPEHE[-14] / 1119f);
			DBOLLHHMKKN().SetFloat(".lastCheckpoint.lives", PLKFKNHPEHE[-19] / 1609f);
			HFBJAOFLCJI().SetFloat("_ColorRGB", FadeFX);
			NBPKMLMCHFN.SetVector(" not exist", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1417f, 944f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 483f)
			{
				HBJJOCHGOPH = 1261f;
			}
			CFEDGDGBCHE().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat(": ", PLKFKNHPEHE[0] / 1155f);
			HHIAIGCAHDA().SetFloat("inventory.lastitemscount", PLKFKNHPEHE[1] / 528f);
			CFEDGDGBCHE().SetFloat("achievements.21.progress", PLKFKNHPEHE[5] / 136f);
			JFDGLLEOPGB().SetFloat("Joystick", PLKFKNHPEHE[0] / 133f);
			CFEDGDGBCHE().SetFloat("???", PLKFKNHPEHE[5] / 1003f);
			NBMPPNFKFLB().SetFloat("CameraFilterPack/Blend2Camera_Hue", PLKFKNHPEHE[7] / 937f);
			DBOLLHHMKKN().SetFloat("InstantiateRpc", PLKFKNHPEHE[7] / 930f);
			NDMPCDHADMJ().SetFloat("SaveMapButton", PLKFKNHPEHE[3] / 1768f);
			HNICHJCGJOC().SetFloat("GlassesColor2", PLKFKNHPEHE[1] / 608f);
			JFDGLLEOPGB().SetFloat("finished", PLKFKNHPEHE[-53] / 414f);
			BFGNMFCNDBC().SetFloat("FinalScoreText", PLKFKNHPEHE[70] / 1609f);
			JFDGLLEOPGB().SetFloat("[RanksSystem] Init", PLKFKNHPEHE[-107] / 1718f);
			HFBJAOFLCJI().SetFloat("Menu", FadeFX);
			DBOLLHHMKKN().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1068f, 692f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BFKANNFLAKP()
	{
		ILAGEKDPGOI();
	}

	private void FKDKJKCAHJC()
	{
		GPHHNFDCFMC();
	}

	private void OnValidate()
	{
		MIPGPMKJELI();
	}

	private void PBKELEKDBIC()
	{
		float[] array = new float[98];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void FEHCNJLLJMP()
	{
		MHLKBPJKIOL();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
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

	[SpecialName]
	private Material BFGNMFCNDBC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)110;
		}
		return BJFKDHHMLJH;
	}

	private void FGOPJMGNHGO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material NFMGLIKNOOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void KNBJBNDGCIJ()
	{
		LBEHKFNPKMC();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void Update()
	{
	}

	[SpecialName]
	private Material JFDGLLEOPGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return BJFKDHHMLJH;
	}

	private void GAAPMFBPJNH()
	{
		MHLKBPJKIOL();
	}

	private void OFBLDOCCBBN()
	{
		MIPGPMKJELI();
	}

	private void KHHCNLLEHDI()
	{
		float[] array = new float[-60];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void BEBNOKFLJPH()
	{
		GPHHNFDCFMC();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KHDANGFKIGL()
	{
		EENNCFGECAE();
	}

	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 867f)
			{
				HBJJOCHGOPH = 231f;
			}
			HNICHJCGJOC().SetFloat("Bad SegmentType passed in to CreateLineCap. Must be SegmentType.Start or SegmentType.End", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_PColor2", PLKFKNHPEHE[0] / 1724f);
			NBPKMLMCHFN.SetFloat("caret", PLKFKNHPEHE[1] / 1349f);
			AELJLBOJAIL().SetFloat("music", PLKFKNHPEHE[2] / 1967f);
			HFBJAOFLCJI().SetFloat(" Time: ", PLKFKNHPEHE[8] / 1240f);
			DBOLLHHMKKN().SetFloat(" not exist", PLKFKNHPEHE[2] / 780f);
			DBOLLHHMKKN().SetFloat("No Name", PLKFKNHPEHE[0] / 119f);
			NBPKMLMCHFN.SetFloat("_LightIntensity", PLKFKNHPEHE[1] / 242f);
			NFMGLIKNOOC().SetFloat("_ScreenResolution", PLKFKNHPEHE[6] / 1910f);
			AELJLBOJAIL().SetFloat("Joystick1Button4", PLKFKNHPEHE[8] / 175f);
			HNICHJCGJOC().SetFloat("Value", PLKFKNHPEHE[-93] / 823f);
			AELJLBOJAIL().SetFloat("_ScreenResolution", PLKFKNHPEHE[-75] / 1790f);
			NFMGLIKNOOC().SetFloat("RPC: 'OnAwakeRPC' PhotonView: ", PLKFKNHPEHE[-71] / 1731f);
			BFGNMFCNDBC().SetFloat("ChatHistoryInputField", FadeFX);
			DBOLLHHMKKN().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1539f, 544f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1514f)
			{
				HBJJOCHGOPH = 87f;
			}
			NFMGLIKNOOC().SetFloat("mainmenu", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("Received RPC: ", PLKFKNHPEHE[1] / 938f);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Oculus_NightVision3", PLKFKNHPEHE[0] / 1735f);
			NFMGLIKNOOC().SetFloat("FullscreenToggle", PLKFKNHPEHE[8] / 242f);
			NBMPPNFKFLB().SetFloat(": ", PLKFKNHPEHE[3] / 385f);
			HHIAIGCAHDA().SetFloat("[LevelEditorScene] Map submitted!", PLKFKNHPEHE[4] / 1634f);
			HFBJAOFLCJI().SetFloat(": ", PLKFKNHPEHE[3] / 167f);
			NFMGLIKNOOC().SetFloat("#yes", PLKFKNHPEHE[2] / 1306f);
			BFGNMFCNDBC().SetFloat("/music", PLKFKNHPEHE[1] / 786f);
			JFDGLLEOPGB().SetFloat("_Distance", PLKFKNHPEHE[0] / 718f);
			DBOLLHHMKKN().SetFloat("Fade", PLKFKNHPEHE[-45] / 736f);
			DBOLLHHMKKN().SetFloat("GlassesColor", PLKFKNHPEHE[62] / 839f);
			JFDGLLEOPGB().SetFloat("[PlayerController] ", PLKFKNHPEHE[122] / 1538f);
			NBMPPNFKFLB().SetFloat("0.00", FadeFX);
			NFMGLIKNOOC().SetVector("_Value4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1552f, 1782f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LIEGJOHINGC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JBAPHFIBANG()
	{
		DLPEBHPCJMD();
	}

	private void ILAGEKDPGOI()
	{
		PLKFKNHPEHE = new float[10] { 200f, -200f, -200f, 195f, 4f, -160f, 200f, -200f, -200f, -200f };
	}

	private void HLLHJIDOOGA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IHLMNAGPKDA()
	{
		KHHCNLLEHDI();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JOACBIEHHCE()
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

	private void OFIMMFHFHDD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DLPEBHPCJMD()
	{
		float[] array = new float[-51];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CMBGFMAOEPG()
	{
		KHHCNLLEHDI();
	}

	[SpecialName]
	private Material NBMPPNFKFLB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)101;
		}
		return BJFKDHHMLJH;
	}

	private void CPAJLKHMOJB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FOFGKHFJHFK()
	{
		float[] array = new float[18];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	[SpecialName]
	private Material DBOLLHHMKKN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)125;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NDMPCDHADMJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)117;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material AELJLBOJAIL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-1);
		}
		return BJFKDHHMLJH;
	}

	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 658f)
			{
				HBJJOCHGOPH = 1024f;
			}
			KAFBNOBOIAJ().SetFloat("Triangle", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("_PColor2", PLKFKNHPEHE[0] / 100f);
			BFGNMFCNDBC().SetFloat("EnvironmentSlider", PLKFKNHPEHE[1] / 1851f);
			HHIAIGCAHDA().SetFloat("_Value2", PLKFKNHPEHE[0] / 1593f);
			HFBJAOFLCJI().SetFloat("_Value", PLKFKNHPEHE[0] / 1647f);
			CFEDGDGBCHE().SetFloat("shader.frost", PLKFKNHPEHE[3] / 475f);
			JFDGLLEOPGB().SetFloat("d264dbba9c2410771b4ad918903b3f4cd9e276a9", PLKFKNHPEHE[8] / 1771f);
			DBOLLHHMKKN().SetFloat(" method: ", PLKFKNHPEHE[6] / 697f);
			HFBJAOFLCJI().SetFloat("_DotSize", PLKFKNHPEHE[3] / 475f);
			CFEDGDGBCHE().SetFloat("_Value", PLKFKNHPEHE[3] / 113f);
			NFMGLIKNOOC().SetFloat("Object ID", PLKFKNHPEHE[40] / 1871f);
			NFMGLIKNOOC().SetFloat("CameraFilterPack_RainFX_Anm2", PLKFKNHPEHE[-97] / 1441f);
			BFGNMFCNDBC().SetFloat("menutheme.jamaicanorcdub", PLKFKNHPEHE[-3] / 770f);
			NFMGLIKNOOC().SetFloat("false", FadeFX);
			HFBJAOFLCJI().SetVector(" with a prefix of ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 404f, 798f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MIPGPMKJELI()
	{
		PLKFKNHPEHE = new float[12]
		{
			200f, -200f, -200f, 195f, 4f, -160f, 200f, -200f, -200f, -200f,
			10f, -200f
		};
	}

	[SpecialName]
	private Material CFEDGDGBCHE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void ANKALNDLHEL()
	{
		LBEHKFNPKMC();
	}

	private void CFIAKIJAILI()
	{
	}

	[SpecialName]
	private Material HHIAIGCAHDA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)95;
		}
		return BJFKDHHMLJH;
	}

	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1818f)
			{
				HBJJOCHGOPH = 373f;
			}
			HNICHJCGJOC().SetFloat("_Quality", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("MenuScene", PLKFKNHPEHE[1] / 660f);
			NFMGLIKNOOC().SetFloat("Add Environment Sprite", PLKFKNHPEHE[0] / 50f);
			DBOLLHHMKKN().SetFloat("workshop.", PLKFKNHPEHE[3] / 405f);
			AELJLBOJAIL().SetFloat("_Value13", PLKFKNHPEHE[7] / 1675f);
			HNICHJCGJOC().SetFloat("CameraFilterPack/Drawing_Manga_FlashWhite", PLKFKNHPEHE[1] / 1241f);
			DBOLLHHMKKN().SetFloat("Netw. Sim.", PLKFKNHPEHE[4] / 1929f);
			KAFBNOBOIAJ().SetFloat("_Value4", PLKFKNHPEHE[3] / 1338f);
			DBOLLHHMKKN().SetFloat("_TimeX", PLKFKNHPEHE[2] / 340f);
			JFDGLLEOPGB().SetFloat(". Going to authenticate anyways.", PLKFKNHPEHE[7] / 521f);
			CFEDGDGBCHE().SetFloat("#ok", PLKFKNHPEHE[-70] / 1378f);
			DBOLLHHMKKN().SetFloat("color", PLKFKNHPEHE[-73] / 366f);
			HFBJAOFLCJI().SetFloat("Left", PLKFKNHPEHE[114] / 1661f);
			AELJLBOJAIL().SetFloat("/", FadeFX);
			DBOLLHHMKKN().SetVector("Creating new item...", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 78f, 993f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 254f)
			{
				HBJJOCHGOPH = 1028f;
			}
			NBMPPNFKFLB().SetFloat("/music", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("_Value", PLKFKNHPEHE[0] / 1128f);
			NBMPPNFKFLB().SetFloat("-1", PLKFKNHPEHE[0] / 1190f);
			NFMGLIKNOOC().SetFloat("skin.", PLKFKNHPEHE[4] / 1450f);
			NBPKMLMCHFN.SetFloat(".lastCheckpoint.time", PLKFKNHPEHE[6] / 1191f);
			NBMPPNFKFLB().SetFloat("CameraFilterPack/Drawing_Halftone", PLKFKNHPEHE[1] / 214f);
			CFEDGDGBCHE().SetFloat("_TreatBackfaceHitAsMiss", PLKFKNHPEHE[2] / 43f);
			KAFBNOBOIAJ().SetFloat("_BgColor", PLKFKNHPEHE[5] / 1150f);
			JFDGLLEOPGB().SetFloat("Case-Sensitive", PLKFKNHPEHE[6] / 1159f);
			AELJLBOJAIL().SetFloat("#000000", PLKFKNHPEHE[3] / 1331f);
			NDMPCDHADMJ().SetFloat("inventory.selected.", PLKFKNHPEHE[43] / 978f);
			NFMGLIKNOOC().SetFloat("_MainTex2", PLKFKNHPEHE[40] / 1979f);
			NFMGLIKNOOC().SetFloat("Ignored PU RPC, cause item is inactive. ", PLKFKNHPEHE[92] / 451f);
			NDMPCDHADMJ().SetFloat("Loaded Game: ", FadeFX);
			DBOLLHHMKKN().SetVector("-", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1827f, 463f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MHLKBPJKIOL()
	{
		float[] array = new float[-57];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 12f)
			{
				HBJJOCHGOPH = 949f;
			}
			JFDGLLEOPGB().SetFloat("mapid", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("[SERVER] Player ", PLKFKNHPEHE[1] / 1152f);
			HNICHJCGJOC().SetFloat("CameraFilterPack/Blend2Camera_PinLight", PLKFKNHPEHE[0] / 812f);
			NFMGLIKNOOC().SetFloat("Left Stick Click", PLKFKNHPEHE[4] / 1208f);
			DBOLLHHMKKN().SetFloat("-", PLKFKNHPEHE[4] / 1682f);
			HFBJAOFLCJI().SetFloat("_SSAO", PLKFKNHPEHE[4] / 129f);
			KAFBNOBOIAJ().SetFloat("/", PLKFKNHPEHE[7] / 92f);
			CFEDGDGBCHE().SetFloat("CameraFilterPack/Blizzard", PLKFKNHPEHE[8] / 1013f);
			HHIAIGCAHDA().SetFloat("???", PLKFKNHPEHE[0] / 258f);
			NDMPCDHADMJ().SetFloat("Cannot remove cached RPCs on a PhotonView thats not ours! ", PLKFKNHPEHE[4] / 1736f);
			NBMPPNFKFLB().SetFloat("_Value2", PLKFKNHPEHE[-123] / 1979f);
			NBPKMLMCHFN.SetFloat("player.crystal", PLKFKNHPEHE[-66] / 107f);
			NFMGLIKNOOC().SetFloat("DPADHOR", PLKFKNHPEHE[48] / 562f);
			NFMGLIKNOOC().SetFloat("Joystick1Button1", FadeFX);
			AELJLBOJAIL().SetVector("Fade", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 849f, 870f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
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
			if (HBJJOCHGOPH > 1284f)
			{
				HBJJOCHGOPH = 1426f;
			}
			HHIAIGCAHDA().SetFloat("Scene", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat("http://api.steampowered.com/ISteamNews/GetNewsForApp/v0002/?format=json&appid=513510", PLKFKNHPEHE[0] / 717f);
			NFMGLIKNOOC().SetFloat("Please attach component to a Graphical UI component", PLKFKNHPEHE[1] / 1624f);
			HNICHJCGJOC().SetFloat("Image", PLKFKNHPEHE[1] / 1716f);
			HFBJAOFLCJI().SetFloat("_TimeX", PLKFKNHPEHE[3] / 133f);
			HHIAIGCAHDA().SetFloat("[SERVER] Kicked ", PLKFKNHPEHE[1] / 459f);
			NFMGLIKNOOC().SetFloat("CameraFilterPack/Colors_HUE_Rotate", PLKFKNHPEHE[1] / 1154f);
			NBMPPNFKFLB().SetFloat("ViewID {0} {1}{2}", PLKFKNHPEHE[5] / 681f);
			NBMPPNFKFLB().SetFloat("_Colorisation", PLKFKNHPEHE[5] / 1113f);
			AELJLBOJAIL().SetFloat("_Value", PLKFKNHPEHE[1] / 589f);
			KAFBNOBOIAJ().SetFloat("master", PLKFKNHPEHE[-4] / 1162f);
			AELJLBOJAIL().SetFloat("_BlurParams", PLKFKNHPEHE[103] / 1001f);
			CFEDGDGBCHE().SetFloat("Tab2Content", PLKFKNHPEHE[122] / 602f);
			DBOLLHHMKKN().SetFloat("Run a command for the Localization Servise", FadeFX);
			CFEDGDGBCHE().SetVector("[PlayerController] ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 379f, 988f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HAIAHJPCPAG()
	{
		MHLKBPJKIOL();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EENNCFGECAE()
	{
		float[] array = new float[29];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void AEIJFLJEABG()
	{
	}

	[SpecialName]
	private Material KAFBNOBOIAJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-65);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HFBJAOFLCJI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1338f)
			{
				HBJJOCHGOPH = 1359f;
			}
			NFMGLIKNOOC().SetFloat("ReconnectAndRejoin() failed. It seems the client wasn't connected to a game server before (no address).", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat("_Radius2", PLKFKNHPEHE[0] / 760f);
			HHIAIGCAHDA().SetFloat("z", PLKFKNHPEHE[1] / 1254f);
			NFMGLIKNOOC().SetFloat("Zoom speed. Base 1.5", PLKFKNHPEHE[8] / 757f);
			AELJLBOJAIL().SetFloat("value", PLKFKNHPEHE[8] / 1801f);
			AELJLBOJAIL().SetFloat("1", PLKFKNHPEHE[0] / 317f);
			KAFBNOBOIAJ().SetFloat("ExitButton", PLKFKNHPEHE[4] / 1098f);
			KAFBNOBOIAJ().SetFloat("Set Sun DirectionVector", PLKFKNHPEHE[6] / 1609f);
			AELJLBOJAIL().SetFloat("FreqVolume: ", PLKFKNHPEHE[4] / 1454f);
			HNICHJCGJOC().SetFloat(".jpg", PLKFKNHPEHE[1] / 888f);
			KAFBNOBOIAJ().SetFloat("---", PLKFKNHPEHE[-107] / 1203f);
			NFMGLIKNOOC().SetFloat("_ScreenResolution", PLKFKNHPEHE[71] / 1675f);
			HHIAIGCAHDA().SetFloat("SetupEncryption() got called. ", PLKFKNHPEHE[37] / 95f);
			HFBJAOFLCJI().SetFloat("settings.arcsdestroydelay", FadeFX);
			NBMPPNFKFLB().SetVector("\0\0", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1590f, 268f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 13f)
			{
				HBJJOCHGOPH = 1857f;
			}
			DBOLLHHMKKN().SetFloat("finished", HBJJOCHGOPH);
			NDMPCDHADMJ().SetFloat("{0}={2}: {1} \"{3}\"", PLKFKNHPEHE[0] / 137f);
			HHIAIGCAHDA().SetFloat("RoomDescriptionText", PLKFKNHPEHE[1] / 107f);
			NBMPPNFKFLB().SetFloat("IntraTime", PLKFKNHPEHE[5] / 632f);
			AELJLBOJAIL().SetFloat("_TimeX", PLKFKNHPEHE[5] / 1552f);
			NBMPPNFKFLB().SetFloat(" / ", PLKFKNHPEHE[0] / 59f);
			AELJLBOJAIL().SetFloat("SpawnObj", PLKFKNHPEHE[7] / 951f);
			BFGNMFCNDBC().SetFloat(" ; ", PLKFKNHPEHE[5] / 1741f);
			BFGNMFCNDBC().SetFloat("didAuthenticate ", PLKFKNHPEHE[1] / 684f);
			HFBJAOFLCJI().SetFloat("JoinButton", PLKFKNHPEHE[8] / 172f);
			HFBJAOFLCJI().SetFloat("player.licenceaccepted", PLKFKNHPEHE[61] / 1271f);
			NFMGLIKNOOC().SetFloat("_Value3", PLKFKNHPEHE[-20] / 208f);
			NFMGLIKNOOC().SetFloat("_ScreenResolution", PLKFKNHPEHE[78] / 330f);
			HFBJAOFLCJI().SetFloat("Had to lookup view that wasn't in photonViewList: ", FadeFX);
			NBMPPNFKFLB().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1006f, 907f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DBGBCCBHBBC()
	{
		PBKELEKDBIC();
	}
}
