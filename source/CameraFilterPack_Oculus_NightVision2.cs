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
			NDMPCDHADMJ().SetFloat("{0}_{1}", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("There is already a virtual axis named ", PLKFKNHPEHE[1] / 587f);
			CFEDGDGBCHE().SetFloat("Set satellite audio input", PLKFKNHPEHE[0] / 1889f);
			NDMPCDHADMJ().SetFloat("_TimeX", PLKFKNHPEHE[3] / 1173f);
			HNICHJCGJOC().SetFloat("CameraFilterPack/AAA_WaterDrop", PLKFKNHPEHE[7] / 457f);
			JFDGLLEOPGB().SetFloat("Cant send PickupItem spawn times to unknown targetPlayer.", PLKFKNHPEHE[6] / 1155f);
			NFMGLIKNOOC().SetFloat("_FadeFX", PLKFKNHPEHE[3] / 1464f);
			NBMPPNFKFLB().SetFloat("_ForceYSwap", PLKFKNHPEHE[7] / 388f);
			NBPKMLMCHFN.SetFloat("Set particless emission (glow)", PLKFKNHPEHE[0] / 1124f);
			NBMPPNFKFLB().SetFloat("ResourceFileSelector", PLKFKNHPEHE[5] / 1646f);
			NDMPCDHADMJ().SetFloat("Fade", PLKFKNHPEHE[36] / 736f);
			NDMPCDHADMJ().SetFloat("BadgeText", PLKFKNHPEHE[64] / 779f);
			HNICHJCGJOC().SetFloat("_MainTex2", PLKFKNHPEHE[24] / 1801f);
			DBOLLHHMKKN().SetFloat("resource id", FadeFX);
			JFDGLLEOPGB().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1897f, 1991f));
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
			HHIAIGCAHDA().SetFloat("_Blue_B", HBJJOCHGOPH);
			NDMPCDHADMJ().SetFloat("Set Satellite Emission", PLKFKNHPEHE[0] / 270f);
			NDMPCDHADMJ().SetFloat("_EmissionGain", PLKFKNHPEHE[1] / 311f);
			HFBJAOFLCJI().SetFloat("_Distortion", PLKFKNHPEHE[1] / 1531f);
			HNICHJCGJOC().SetFloat(": ", PLKFKNHPEHE[3] / 909f);
			HFBJAOFLCJI().SetFloat("The given 2D texture ", PLKFKNHPEHE[4] / 237f);
			CFEDGDGBCHE().SetFloat("[LevelEditorScene] Exported to ", PLKFKNHPEHE[3] / 792f);
			HHIAIGCAHDA().SetFloat("_Value4", PLKFKNHPEHE[7] / 654f);
			NBPKMLMCHFN.SetFloat("y", PLKFKNHPEHE[5] / 6f);
			HHIAIGCAHDA().SetFloat("[SteamManager] Connecting to server", PLKFKNHPEHE[1] / 793f);
			NBMPPNFKFLB().SetFloat("Tab1Content", PLKFKNHPEHE[-31] / 184f);
			NDMPCDHADMJ().SetFloat("move", PLKFKNHPEHE[-30] / 792f);
			DBOLLHHMKKN().SetFloat(".icon", PLKFKNHPEHE[95] / 125f);
			NDMPCDHADMJ().SetFloat("_Red_R", FadeFX);
			CFEDGDGBCHE().SetVector("_Contrast", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 476f, 1916f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIAIGCAHDA());
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
			DBOLLHHMKKN().SetFloat("SpawnObj", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat("#scoresubmitionfailed: ", PLKFKNHPEHE[0] / 257f);
			DBOLLHHMKKN().SetFloat("_ScreenResolution", PLKFKNHPEHE[1] / 972f);
			CFEDGDGBCHE().SetFloat("float,1", PLKFKNHPEHE[4] / 1481f);
			DBOLLHHMKKN().SetFloat("_TimeX", PLKFKNHPEHE[6] / 412f);
			NBPKMLMCHFN.SetFloat(" should be overwritten.", PLKFKNHPEHE[5] / 1189f);
			NBMPPNFKFLB().SetFloat("IconFileSelector", PLKFKNHPEHE[3] / 880f);
			HFBJAOFLCJI().SetFloat("_Value2", PLKFKNHPEHE[1] / 1289f);
			NFMGLIKNOOC().SetFloat("<b>", PLKFKNHPEHE[4] / 717f);
			DBOLLHHMKKN().SetFloat(":</b> ", PLKFKNHPEHE[5] / 1297f);
			AELJLBOJAIL().SetFloat(".lastCheckpoint.perfectHits", PLKFKNHPEHE[72] / 317f);
			AELJLBOJAIL().SetFloat("/", PLKFKNHPEHE[-14] / 1119f);
			NBMPPNFKFLB().SetFloat(".lastCheckpoint.checkpointsUsed", PLKFKNHPEHE[-19] / 1609f);
			JFDGLLEOPGB().SetFloat("_ColorRGB", FadeFX);
			HFBJAOFLCJI().SetVector("[PlayerController] ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1417f, 944f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
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
			KAFBNOBOIAJ().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("[PlayerController] ", PLKFKNHPEHE[0] / 1155f);
			NBPKMLMCHFN.SetFloat("[ItemsHandler] Inventory not changed", PLKFKNHPEHE[1] / 528f);
			BFGNMFCNDBC().SetFloat("achievements.21.progress", PLKFKNHPEHE[5] / 136f);
			BFGNMFCNDBC().SetFloat("settings_bindings_controller_type", PLKFKNHPEHE[0] / 133f);
			BFGNMFCNDBC().SetFloat("Tried to Initialize the SteamAPI twice in one session!", PLKFKNHPEHE[5] / 1003f);
			AELJLBOJAIL().SetFloat("CameraFilterPack/Blend2Camera_Hue", PLKFKNHPEHE[7] / 937f);
			HHIAIGCAHDA().SetFloat("Horizontal", PLKFKNHPEHE[7] / 930f);
			CFEDGDGBCHE().SetFloat("FileMenu", PLKFKNHPEHE[3] / 1768f);
			CFEDGDGBCHE().SetFloat("GlassColor", PLKFKNHPEHE[1] / 608f);
			NFMGLIKNOOC().SetFloat("win", PLKFKNHPEHE[-53] / 414f);
			NDMPCDHADMJ().SetFloat("FinalScoreText", PLKFKNHPEHE[70] / 1609f);
			CFEDGDGBCHE().SetFloat("settings.enablerankingnotifications", PLKFKNHPEHE[-107] / 1718f);
			HNICHJCGJOC().SetFloat("Left Stick Click", FadeFX);
			HNICHJCGJOC().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1068f, 692f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIAIGCAHDA());
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
		FOFGKHFJHFK();
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
		KHHCNLLEHDI();
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
		DLPEBHPCJMD();
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
		GPHHNFDCFMC();
	}

	private void OFBLDOCCBBN()
	{
		MHLKBPJKIOL();
	}

	private void KHHCNLLEHDI()
	{
		float[] array = new float[-60];
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		PLKFKNHPEHE = array;
	}

	private void BEBNOKFLJPH()
	{
		ILAGEKDPGOI();
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KHDANGFKIGL()
	{
		MHLKBPJKIOL();
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
			HFBJAOFLCJI().SetFloat("Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. ", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("_MainTex2", PLKFKNHPEHE[0] / 1724f);
			DBOLLHHMKKN().SetFloat("Added checkpoint", PLKFKNHPEHE[1] / 1349f);
			HNICHJCGJOC().SetFloat("/", PLKFKNHPEHE[2] / 1967f);
			BFGNMFCNDBC().SetFloat(" to: ", PLKFKNHPEHE[8] / 1240f);
			JFDGLLEOPGB().SetFloat("[PlayerController] ", PLKFKNHPEHE[2] / 780f);
			NBPKMLMCHFN.SetFloat("No info", PLKFKNHPEHE[0] / 119f);
			CFEDGDGBCHE().SetFloat("_LightIntensity", PLKFKNHPEHE[1] / 242f);
			BFGNMFCNDBC().SetFloat("CameraFilterPack/Colors_NewPosterize", PLKFKNHPEHE[6] / 1910f);
			DBOLLHHMKKN().SetFloat("L1", PLKFKNHPEHE[8] / 175f);
			JFDGLLEOPGB().SetFloat(" x ", PLKFKNHPEHE[-93] / 823f);
			NDMPCDHADMJ().SetFloat("_ScreenResolution", PLKFKNHPEHE[-75] / 1790f);
			HNICHJCGJOC().SetFloat("DestroyRpc", PLKFKNHPEHE[-71] / 1731f);
			NDMPCDHADMJ().SetFloat("In Network lobby", FadeFX);
			JFDGLLEOPGB().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1539f, 544f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NDMPCDHADMJ());
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
			NBPKMLMCHFN.SetFloat("mainmenu", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat(", ", PLKFKNHPEHE[1] / 938f);
			NBMPPNFKFLB().SetFloat("_TimeX", PLKFKNHPEHE[0] / 1735f);
			NFMGLIKNOOC().SetFloat("MenuVolumeSlider", PLKFKNHPEHE[8] / 242f);
			NBMPPNFKFLB().SetFloat(": ", PLKFKNHPEHE[3] / 385f);
			AELJLBOJAIL().SetFloat("#ok", PLKFKNHPEHE[4] / 1634f);
			NFMGLIKNOOC().SetFloat(": ", PLKFKNHPEHE[3] / 167f);
			NBMPPNFKFLB().SetFloat("#ok", PLKFKNHPEHE[2] / 1306f);
			HHIAIGCAHDA().SetFloat("music", PLKFKNHPEHE[1] / 786f);
			KAFBNOBOIAJ().SetFloat("_Distance", PLKFKNHPEHE[0] / 718f);
			HFBJAOFLCJI().SetFloat("VisionBlur", PLKFKNHPEHE[-45] / 736f);
			NDMPCDHADMJ().SetFloat("GlassesColor2", PLKFKNHPEHE[62] / 839f);
			HFBJAOFLCJI().SetFloat(":", PLKFKNHPEHE[122] / 1538f);
			CFEDGDGBCHE().SetFloat("PLEASE WAIT", FadeFX);
			DBOLLHHMKKN().SetVector("_Value4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1552f, 1782f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HFBJAOFLCJI());
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
		MHLKBPJKIOL();
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
		EENNCFGECAE();
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
		EALEEMOPJNO();
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
			NBPKMLMCHFN.SetFloat("Joystick1Button4", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("_MainTex2", PLKFKNHPEHE[0] / 100f);
			HFBJAOFLCJI().SetFloat("Tab2Content", PLKFKNHPEHE[1] / 1851f);
			CFEDGDGBCHE().SetFloat("_Value3", PLKFKNHPEHE[0] / 1593f);
			NBPKMLMCHFN.SetFloat("_Value2", PLKFKNHPEHE[0] / 1647f);
			NBPKMLMCHFN.SetFloat("player.bat", PLKFKNHPEHE[3] / 475f);
			BFGNMFCNDBC().SetFloat("No Dispatcher exists in the scene. Actions will not be invoked!", PLKFKNHPEHE[8] / 1771f);
			JFDGLLEOPGB().SetFloat("Sending RPC \"", PLKFKNHPEHE[6] / 697f);
			KAFBNOBOIAJ().SetFloat("CameraFilterPack/Drawing_Manga3", PLKFKNHPEHE[3] / 475f);
			BFGNMFCNDBC().SetFloat("_Value", PLKFKNHPEHE[3] / 113f);
			BFGNMFCNDBC().SetFloat("Object ID. Case-Sensitive", PLKFKNHPEHE[40] / 1871f);
			HFBJAOFLCJI().SetFloat("CameraFilterPack_RainFX_Anm", PLKFKNHPEHE[-97] / 1441f);
			NDMPCDHADMJ().SetFloat("menutheme.jamaicanorcdub", PLKFKNHPEHE[-3] / 770f);
			NDMPCDHADMJ().SetFloat("{0}", FadeFX);
			KAFBNOBOIAJ().SetVector("Malformed RPC; this should never occur. Content: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 404f, 798f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NDMPCDHADMJ());
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
		ILAGEKDPGOI();
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
			NBMPPNFKFLB().SetFloat("_Quality", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("challenges.", PLKFKNHPEHE[1] / 660f);
			HHIAIGCAHDA().SetFloat("resource id", PLKFKNHPEHE[0] / 50f);
			JFDGLLEOPGB().SetFloat("\n", PLKFKNHPEHE[3] / 405f);
			JFDGLLEOPGB().SetFloat("_Value13", PLKFKNHPEHE[7] / 1675f);
			JFDGLLEOPGB().SetFloat("_TimeX", PLKFKNHPEHE[1] / 1241f);
			NBMPPNFKFLB().SetFloat("Rtt:{0,4} +/-{1,3}", PLKFKNHPEHE[4] / 1929f);
			NBPKMLMCHFN.SetFloat("CameraFilterPack_OldFilm1", PLKFKNHPEHE[3] / 1338f);
			BFGNMFCNDBC().SetFloat("_Value", PLKFKNHPEHE[2] / 340f);
			CFEDGDGBCHE().SetFloat(". Check if the server is available.", PLKFKNHPEHE[7] / 521f);
			JFDGLLEOPGB().SetFloat("#ok", PLKFKNHPEHE[-70] / 1378f);
			BFGNMFCNDBC().SetFloat("color", PLKFKNHPEHE[-73] / 366f);
			NFMGLIKNOOC().SetFloat("?", PLKFKNHPEHE[114] / 1661f);
			AELJLBOJAIL().SetFloat("/../", FadeFX);
			BFGNMFCNDBC().SetVector("OK", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 78f, 993f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
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
			NBPKMLMCHFN.SetFloat("/music", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("_Value2", PLKFKNHPEHE[0] / 1128f);
			HHIAIGCAHDA().SetFloat("-1", PLKFKNHPEHE[0] / 1190f);
			NFMGLIKNOOC().SetFloat("Unable to get a reward! Try again?", PLKFKNHPEHE[4] / 1450f);
			HNICHJCGJOC().SetFloat("SetSpeed", PLKFKNHPEHE[6] / 1191f);
			JFDGLLEOPGB().SetFloat("CameraFilterPack/Drawing_Halftone", PLKFKNHPEHE[1] / 214f);
			HFBJAOFLCJI().SetFloat("_TraceBehindObjects", PLKFKNHPEHE[2] / 43f);
			HHIAIGCAHDA().SetFloat("_Threshold", PLKFKNHPEHE[5] / 1150f);
			CFEDGDGBCHE().SetFloat("x", PLKFKNHPEHE[6] / 1159f);
			NBMPPNFKFLB().SetFloat("#91CCFF", PLKFKNHPEHE[3] / 1331f);
			KAFBNOBOIAJ().SetFloat("LoadingStatusText", PLKFKNHPEHE[43] / 978f);
			AELJLBOJAIL().SetFloat("_MainTex2", PLKFKNHPEHE[40] / 1979f);
			NBPKMLMCHFN.SetFloat(" id: ", PLKFKNHPEHE[92] / 451f);
			NDMPCDHADMJ().SetFloat("The process failed: ", FadeFX);
			NFMGLIKNOOC().SetVector("]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1827f, 463f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
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
			BFGNMFCNDBC().SetFloat("gamemode", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("[SERVER] Player ", PLKFKNHPEHE[1] / 1152f);
			HFBJAOFLCJI().SetFloat("_MainTex2", PLKFKNHPEHE[0] / 812f);
			HHIAIGCAHDA().SetFloat("Right Stick Click", PLKFKNHPEHE[4] / 1208f);
			KAFBNOBOIAJ().SetFloat("]", PLKFKNHPEHE[4] / 1682f);
			HFBJAOFLCJI().SetFloat("_BlurRadius4", PLKFKNHPEHE[4] / 129f);
			NFMGLIKNOOC().SetFloat("/music", PLKFKNHPEHE[7] / 92f);
			NFMGLIKNOOC().SetFloat("CameraFilterPack/Blizzard", PLKFKNHPEHE[8] / 1013f);
			CFEDGDGBCHE().SetFloat("???", PLKFKNHPEHE[0] / 258f);
			NBMPPNFKFLB().SetFloat(" method: ", PLKFKNHPEHE[4] / 1736f);
			CFEDGDGBCHE().SetFloat("_Value2", PLKFKNHPEHE[-123] / 1979f);
			AELJLBOJAIL().SetFloat("player.goldcrystal", PLKFKNHPEHE[-66] / 107f);
			NFMGLIKNOOC().SetFloat("DPADHOR", PLKFKNHPEHE[48] / 562f);
			CFEDGDGBCHE().SetFloat("Joystick1Button2", FadeFX);
			NDMPCDHADMJ().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 849f, 870f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
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
			CFEDGDGBCHE().SetFloat("PunRespawn", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("/GetNews/pinnednewsid", PLKFKNHPEHE[0] / 717f);
			KAFBNOBOIAJ().SetFloat("ShineEffect", PLKFKNHPEHE[1] / 1624f);
			AELJLBOJAIL().SetFloat("Image", PLKFKNHPEHE[1] / 1716f);
			NBMPPNFKFLB().SetFloat("_Bullet_1", PLKFKNHPEHE[3] / 133f);
			KAFBNOBOIAJ().SetFloat("[SERVER] Kicked ", PLKFKNHPEHE[1] / 459f);
			AELJLBOJAIL().SetFloat("CameraFilterPack/Colors_HUE_Rotate", PLKFKNHPEHE[1] / 1154f);
			KAFBNOBOIAJ().SetFloat("owner: ", PLKFKNHPEHE[5] / 681f);
			NBMPPNFKFLB().SetFloat("_Parasite", PLKFKNHPEHE[5] / 1113f);
			DBOLLHHMKKN().SetFloat("_Value2", PLKFKNHPEHE[1] / 589f);
			KAFBNOBOIAJ().SetFloat(" ", PLKFKNHPEHE[-4] / 1162f);
			NDMPCDHADMJ().SetFloat("_Offsets", PLKFKNHPEHE[103] / 1001f);
			KAFBNOBOIAJ().SetFloat("SpeedSlider", PLKFKNHPEHE[122] / 602f);
			KAFBNOBOIAJ().SetFloat("Localization Servise\nWorking commands:\nset <language>\nlist\nkeys", FadeFX);
			AELJLBOJAIL().SetVector(": ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 379f, 988f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HAIAHJPCPAG()
	{
		KHHCNLLEHDI();
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
			HNICHJCGJOC().SetFloat("ReconnectAndRejoin() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", HBJJOCHGOPH);
			NDMPCDHADMJ().SetFloat("_BlurFilterDistance", PLKFKNHPEHE[0] / 760f);
			BFGNMFCNDBC().SetFloat("z", PLKFKNHPEHE[1] / 1254f);
			CFEDGDGBCHE().SetFloat("float,1.5", PLKFKNHPEHE[8] / 757f);
			NBMPPNFKFLB().SetFloat("float,50", PLKFKNHPEHE[8] / 1801f);
			CFEDGDGBCHE().SetFloat("/", PLKFKNHPEHE[0] / 317f);
			NDMPCDHADMJ().SetFloat("ExitButton", PLKFKNHPEHE[4] / 1098f);
			BFGNMFCNDBC().SetFloat("Set Sun DirectionVector", PLKFKNHPEHE[6] / 1609f);
			CFEDGDGBCHE().SetFloat("FreqVolume: ", PLKFKNHPEHE[4] / 1454f);
			NBMPPNFKFLB().SetFloat(".png", PLKFKNHPEHE[1] / 888f);
			NBMPPNFKFLB().SetFloat("513510", PLKFKNHPEHE[-107] / 1203f);
			HHIAIGCAHDA().SetFloat("_ScreenResolution", PLKFKNHPEHE[71] / 1675f);
			NBPKMLMCHFN.SetFloat("Sending vacant view IDs. Length: ", PLKFKNHPEHE[37] / 95f);
			BFGNMFCNDBC().SetFloat("settings.arcsdestroydelay", FadeFX);
			NFMGLIKNOOC().SetVector("ControllerRightY", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1590f, 268f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
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
			JFDGLLEOPGB().SetFloat("ShowSprite", HBJJOCHGOPH);
			HFBJAOFLCJI().SetFloat("PUNCloudBestRegion", PLKFKNHPEHE[0] / 137f);
			JFDGLLEOPGB().SetFloat("RoomDescriptionText", PLKFKNHPEHE[1] / 107f);
			KAFBNOBOIAJ().SetFloat("#close", PLKFKNHPEHE[5] / 632f);
			HNICHJCGJOC().SetFloat("_TimeX", PLKFKNHPEHE[5] / 1552f);
			KAFBNOBOIAJ().SetFloat(": ", PLKFKNHPEHE[0] / 59f);
			NBMPPNFKFLB().SetFloat("SpawnObj", PLKFKNHPEHE[7] / 951f);
			CFEDGDGBCHE().SetFloat(" ; ", PLKFKNHPEHE[5] / 1741f);
			AELJLBOJAIL().SetFloat(". Going to authenticate anyways.", PLKFKNHPEHE[1] / 684f);
			KAFBNOBOIAJ().SetFloat("JoinButton", PLKFKNHPEHE[8] / 172f);
			HNICHJCGJOC().SetFloat("player.licenceaccepted", PLKFKNHPEHE[61] / 1271f);
			JFDGLLEOPGB().SetFloat("_Value4", PLKFKNHPEHE[-20] / 208f);
			DBOLLHHMKKN().SetFloat("_ScreenResolution", PLKFKNHPEHE[78] / 330f);
			CFEDGDGBCHE().SetFloat("PhotonView ID duplicate found: {0}. New: {1} old: {2}. Maybe one wasn't destroyed on scene load?! Check for 'DontDestroyOnLoad'. Destroying old entry, adding new.", FadeFX);
			NBPKMLMCHFN.SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1006f, 907f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
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
