// CameraFilterPack_Distortion_ShockWaveManual
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Distortion/ShockWave Manual")]
[ExecuteInEditMode]
public class CameraFilterPack_Distortion_ShockWaveManual : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(-1.5f, 1.5f)]
	public float PosX = 0.5f;

	[Range(-1.5f, 1.5f)]
	public float PosY = 0.5f;

	[Range(-0.1f, 2f)]
	public float Value = 0.5f;

	[Range(0f, 10f)]
	public float Size = 1f;

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

	private void OBAEDJJDCPN()
	{
	}

	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1377f)
			{
				HBJJOCHGOPH = 1878f;
			}
			KAFBNOBOIAJ().SetFloat("Tab1Content", HBJJOCHGOPH);
			OKJOKHGJHGF().SetFloat("#", PosX);
			ABHDNGIHBKE().SetFloat("[MapsData] Base maps loaded", PosY);
			GJHLADDCMFF().SetFloat("Anomaly_Intensity", Value);
			KJMECMIGJJA().SetFloat("_Value4", Size);
			NFMGLIKNOOC().SetVector("EXCEPTION:", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1750f, 226f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BBIMPFGLDCP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 455f)
			{
				HBJJOCHGOPH = 1568f;
			}
			OIBHFCLJKDB().SetFloat("CameraFilterPack/Drawing_Crosshatch", HBJJOCHGOPH);
			MLMKCOINOOH().SetFloat("PublishMapButton", PosX);
			IFMAPIDFNLI().SetFloat("No valid adaptive tonemapper type found!", PosY);
			KHCLIAMBBNC().SetFloat("_ScreenResolution", Value);
			IIBLJCKLGFG().SetFloat("BadgeText", Size);
			EJDPNJAEAKJ().SetVector("_RgbTex", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1472f, 1727f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KHCLIAMBBNC());
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

	private void OFPPIKHNJOD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DFFKKLAPHCC()
	{
		SCShader = Shader.Find("_Offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 848f)
			{
				HBJJOCHGOPH = 1584f;
			}
			NBPKMLMCHFN.SetFloat("CameraFilterPack/FX_DigitalMatrix", HBJJOCHGOPH);
			IGIAPKPKGPK().SetFloat("RecieveChatMessage", PosX);
			OIBHFCLJKDB().SetFloat("[FileSelector] Dialog canceled", PosY);
			MNLKBFFKHIE().SetFloat("player.arrow", Value);
			EHDJJANLINB().SetFloat("_Light", Size);
			KAFBNOBOIAJ().SetVector(".status", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 658f, 461f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material EFMCNLELMDO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)122;
		}
		return BJFKDHHMLJH;
	}

	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 150f)
			{
				HBJJOCHGOPH = 1110f;
			}
			DONENAMLFLF().SetFloat("#yes", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("GlassesColor", PosX);
			IGIAPKPKGPK().SetFloat(": ", PosY);
			BBIMPFGLDCP().SetFloat("' has been reset to the fault value", Value);
			MLMKCOINOOH().SetFloat("Operation failed: ", Size);
			EHDJJANLINB().SetVector("float,1.5", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1791f, 665f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 594f)
			{
				HBJJOCHGOPH = 948f;
			}
			IFMAPIDFNLI().SetFloat("{0} minutes ago", HBJJOCHGOPH);
			IGIAPKPKGPK().SetFloat("_FixDistance", PosX);
			GJHLADDCMFF().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", PosY);
			ENKPNJMPDEB().SetFloat("float,1", Value);
			ABHDNGIHBKE().SetFloat("Set particles start speed", Size);
			KEMAALEODNH().SetVector(". Not Destroying GameObject or PhotonViews!", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1273f, 1683f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 91f)
			{
				HBJJOCHGOPH = 1075f;
			}
			DNLMFEGJJDD().SetFloat("getbool", HBJJOCHGOPH);
			GJHLADDCMFF().SetFloat("BadgeImage", PosX);
			AELJLBOJAIL().SetFloat("_Colorisation", PosY);
			EJDPNJAEAKJ().SetFloat("_TimeX", Value);
			EJDPNJAEAKJ().SetFloat("Reconnect() failed. It seems the client wasn't connected before?! Current state: ", Size);
			ENKPNJMPDEB().SetVector("_SizeY", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 810f, 1555f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JONGNKNLLND()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1341f)
			{
				HBJJOCHGOPH = 1624f;
			}
			EFMCNLELMDO().SetFloat("_TimeX", HBJJOCHGOPH);
			ENKPNJMPDEB().SetFloat("CameraFilterPack/TV_ARCADE_Fast", PosX);
			EFMCNLELMDO().SetFloat("_Noise", PosY);
			KEMAALEODNH().SetFloat("_Value7", Value);
			EHDJJANLINB().SetFloat("bad", Size);
			EFMCNLELMDO().SetVector("ItemNameText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 707f, 1384f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KJMECMIGJJA());
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
			if (HBJJOCHGOPH > 1218f)
			{
				HBJJOCHGOPH = 1167f;
			}
			PLBEJJIHFPB().SetFloat("received</b>\n#reason: ", HBJJOCHGOPH);
			IIBLJCKLGFG().SetFloat("CameraFilterPack/Colors_Adjust_FullColors", PosX);
			OKJOKHGJHGF().SetFloat("Brightness", PosY);
			IONHGBPGCHK().SetFloat("mainMenu", Value);
			EJDPNJAEAKJ().SetFloat("Spawn ark to be pressed at this time", Size);
			NBPKMLMCHFN.SetVector("LoadingStatusText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1685f, 360f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ANKIJGCGCBF()
	{
	}

	private void FHPFJBFCOOF()
	{
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LLDHEJIEDHO()
	{
	}

	private void LCHBFNIPBHB()
	{
	}

	private void NDDNJNCINDA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material KHCLIAMBBNC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material EJDPNJAEAKJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void EHCGBJDFMHG()
	{
	}

	private void DOKAKEMDALN()
	{
		SCShader = Shader.Find("cancel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CCFEDENFNEF()
	{
		SCShader = Shader.Find("Scrollbar");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
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
			NBPKMLMCHFN.SetFloat("_Value", PosX);
			NBPKMLMCHFN.SetFloat("_Value2", PosY);
			NBPKMLMCHFN.SetFloat("_Value3", Value);
			NBPKMLMCHFN.SetFloat("_Value4", Size);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KLDNGKBMDAN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material OIBHFCLJKDB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material IIBLJCKLGFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-68);
		}
		return BJFKDHHMLJH;
	}

	private void EFECEKPFOEM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 888f)
			{
				HBJJOCHGOPH = 200f;
			}
			NFMGLIKNOOC().SetFloat(": ", HBJJOCHGOPH);
			MLMKCOINOOH().SetFloat("_Value3", PosX);
			KHCLIAMBBNC().SetFloat("_Colored", PosY);
			NFMGLIKNOOC().SetFloat("SetSatelliteRadius", Value);
			AELJLBOJAIL().SetFloat("\n\n#", Size);
			KJMECMIGJJA().SetVector("#failed!", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1449f, 1619f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AMHEJBMLFNM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material KJMECMIGJJA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void PFNFPINPCMH()
	{
	}

	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1859f)
			{
				HBJJOCHGOPH = 94f;
			}
			KAFBNOBOIAJ().SetFloat("ItemNameBGImage", HBJJOCHGOPH);
			EJDPNJAEAKJ().SetFloat("_NoiseScale", PosX);
			DONENAMLFLF().SetFloat("_ScreenResolution", PosY);
			EJDPNJAEAKJ().SetFloat("LastNewsButton", Value);
			ABHDNGIHBKE().SetFloat("max. lives color", Size);
			BBIMPFGLDCP().SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1133f, 858f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FDPOFMCFBMF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FLKEJJEGCFA()
	{
		SCShader = Shader.Find("_Brightness");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material DONENAMLFLF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void FJKJGBLPDGG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 39f)
			{
				HBJJOCHGOPH = 760f;
			}
			EFMCNLELMDO().SetFloat("Player Connected", HBJJOCHGOPH);
			EHDJJANLINB().SetFloat("_DotSize", PosX);
			IIBLJCKLGFG().SetFloat("_Value2", PosY);
			OIBHFCLJKDB().SetFloat("Bass", Value);
			MNLKBFFKHIE().SetFloat("BestScoreText", Size);
			KEMAALEODNH().SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 814f, 750f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIBLJCKLGFG());
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
			if (HBJJOCHGOPH > 1220f)
			{
				HBJJOCHGOPH = 592f;
			}
			KEMAALEODNH().SetFloat("_Val", HBJJOCHGOPH);
			EJDPNJAEAKJ().SetFloat("UseScanLineSize", PosX);
			IONHGBPGCHK().SetFloat("_Extra2", PosY);
			EFMCNLELMDO().SetFloat("/", Value);
			AELJLBOJAIL().SetFloat("_SpawnHeuristic", Size);
			EHDJJANLINB().SetVector("GroupNameText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 361f, 1978f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)72;
		}
		return BJFKDHHMLJH;
	}

	private void CGBHOELMAOC()
	{
	}

	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 500f)
			{
				HBJJOCHGOPH = 1523f;
			}
			KJMECMIGJJA().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			MLMKCOINOOH().SetFloat("_Red_B", PosX);
			BBIMPFGLDCP().SetFloat("other.dust1", PosY);
			ENKPNJMPDEB().SetFloat("_ExposureAdjustment", Value);
			BBIMPFGLDCP().SetFloat("_TimeX", Size);
			IGIAPKPKGPK().SetVector("CameraFilterPack/Blur_Steam", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 474f, 1737f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ENKPNJMPDEB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1311f)
			{
				HBJJOCHGOPH = 992f;
			}
			IGIAPKPKGPK().SetFloat("<size=24>", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value2", PosX);
			DONENAMLFLF().SetFloat("The observed monobehaviour (", PosY);
			BBIMPFGLDCP().SetFloat(".", Value);
			DNLMFEGJJDD().SetFloat("_ScreenResolution", Size);
			ABHDNGIHBKE().SetVector(".lastCheckpoint.powerupsScore", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 380f, 1714f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFMCNLELMDO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FGOPJMGNHGO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IMCKJCHKMKB()
	{
		SCShader = Shader.Find("offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material AELJLBOJAIL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	private void NPBDIMJDMGA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 817f)
			{
				HBJJOCHGOPH = 1723f;
			}
			IONHGBPGCHK().SetFloat("RoomDescriptionText", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat(" ", PosX);
			DNLMFEGJJDD().SetFloat("/../", PosY);
			MNLKBFFKHIE().SetFloat("_Value4", Value);
			IONHGBPGCHK().SetFloat("[Right-Left]", Size);
			IFMAPIDFNLI().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1839f, 1010f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JKFDDNMPOJH()
	{
		SCShader = Shader.Find("CameraFilterPack/Lut_Simple");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CGDMLHLJIDK()
	{
		SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 504f)
			{
				HBJJOCHGOPH = 527f;
			}
			NFMGLIKNOOC().SetFloat("icon", HBJJOCHGOPH);
			EFMCNLELMDO().SetFloat("_Blue_R", PosX);
			PLBEJJIHFPB().SetFloat("settings_bindings_controller_type", PosY);
			KHCLIAMBBNC().SetFloat("r", Value);
			KHCLIAMBBNC().SetFloat("_Red_C", Size);
			EJDPNJAEAKJ().SetVector("Y", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 59f, 1722f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void POIMNOBDBBN()
	{
	}

	private void IEMEHGCFAPD()
	{
	}

	[SpecialName]
	private Material MLMKCOINOOH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)84;
		}
		return BJFKDHHMLJH;
	}

	private void LGHCJCFHEMF()
	{
		SCShader = Shader.Find("JoinButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 315f)
			{
				HBJJOCHGOPH = 1463f;
			}
			KHCLIAMBBNC().SetFloat("LetterSpacing: Missing Text component", HBJJOCHGOPH);
			ENKPNJMPDEB().SetFloat("[PhotonMessageInfo: Sender='{1}' Senttime={0}]", PosX);
			OIBHFCLJKDB().SetFloat("/?player=", PosY);
			GJHLADDCMFF().SetFloat("_Value2", Value);
			MNLKBFFKHIE().SetFloat("Loading inventory", Size);
			PLBEJJIHFPB().SetVector("_BlurParams", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 394f, 216f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FMHOHGEAIEA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AIBNKIDADPI()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 867f)
			{
				HBJJOCHGOPH = 683f;
			}
			DNLMFEGJJDD().SetFloat("Texture2", HBJJOCHGOPH);
			IIBLJCKLGFG().SetFloat("Select", PosX);
			EJDPNJAEAKJ().SetFloat("_MainTex2", PosY);
			EHDJJANLINB().SetFloat("CameraFilterPack/TV_WideScreenCircle", Value);
			EJDPNJAEAKJ().SetFloat("ResourceIDInputField", Size);
			DONENAMLFLF().SetVector("y", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1432f, 73f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material EHDJJANLINB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-102);
		}
		return BJFKDHHMLJH;
	}

	private void PLBOFEPBPKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material IGIAPKPKGPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KAFBNOBOIAJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-116);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material DNLMFEGJJDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 489f)
			{
				HBJJOCHGOPH = 1263f;
			}
			MLMKCOINOOH().SetFloat("settings_bindings_sec_", HBJJOCHGOPH);
			KAFBNOBOIAJ().SetFloat("Called GetNumberOfCurrentPlayers()", PosX);
			IONHGBPGCHK().SetFloat("grid", PosY);
			KHCLIAMBBNC().SetFloat("_Red_C", Value);
			EHDJJANLINB().SetFloat("_ProjInfo", Size);
			DNLMFEGJJDD().SetVector("\" that takes ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1782f, 1682f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BNCLKHOEGDK()
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
			if (HBJJOCHGOPH > 1153f)
			{
				HBJJOCHGOPH = 599f;
			}
			EFMCNLELMDO().SetFloat("icon", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("[Left]", PosX);
			EJDPNJAEAKJ().SetFloat(";", PosY);
			IIBLJCKLGFG().SetFloat("$ {0}", Value);
			MNLKBFFKHIE().SetFloat(" Time: ", Size);
			KAFBNOBOIAJ().SetVector("menu.selectedplaymode", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1078f, 13f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KCCIEMBMOBA()
	{
		SCShader = Shader.Find("CameraFilterPack/Vision_Drost");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MEBPBNLBECA()
	{
		SCShader = Shader.Find("DPADHOR");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DLIJFEGIEKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1019f)
			{
				HBJJOCHGOPH = 510f;
			}
			DONENAMLFLF().SetFloat("InfoCanvas", HBJJOCHGOPH);
			OIBHFCLJKDB().SetFloat("_Value3", PosX);
			EJDPNJAEAKJ().SetFloat("MenuScene", PosY);
			KHCLIAMBBNC().SetFloat("_CenterX", Value);
			GJHLADDCMFF().SetFloat("_FixDistance", Size);
			ABHDNGIHBKE().SetVector("In Network lobby", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 566f, 1712f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EDBEHEKMGFH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Distortion_ShockWaveManual");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void COOHIILCOCO()
	{
		SCShader = Shader.Find("#md5submitionfailed: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FEHCNJLLJMP()
	{
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ODCJJFBJJNF()
	{
	}

	private void JOPCCCCHNLI()
	{
		SCShader = Shader.Find("b");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1619f)
			{
				HBJJOCHGOPH = 1151f;
			}
			KAFBNOBOIAJ().SetFloat("powerup.0", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat("[PlayerController] ", PosX);
			KEMAALEODNH().SetFloat(" not exist", PosY);
			KAFBNOBOIAJ().SetFloat("Data/Editor/leveltemplate", Value);
			IIBLJCKLGFG().SetFloat("mapselector.orderby", Size);
			PLBEJJIHFPB().SetVector("Connecting", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1584f, 1445f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DPIPGGDNGHN()
	{
	}

	private void NAOLAJPDGIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MNBPNHNAEBK()
	{
		SCShader = Shader.Find("_Value6");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DAHFFNNIGML()
	{
		SCShader = Shader.Find("_Overlay");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FABMDEHEDNO()
	{
	}

	private void NKFDNIAKGEO()
	{
		SCShader = Shader.Find("_Green_R");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void BNEJMABFKJE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material NFMGLIKNOOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)89;
		}
		return BJFKDHHMLJH;
	}

	private void JOONHGHGKKF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material IFMAPIDFNLI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)95;
		}
		return BJFKDHHMLJH;
	}

	private void NEFHGMNAPEP()
	{
		SCShader = Shader.Find("SpawnObj");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OFMNDBNFBDJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EKCKJLFFAID()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JILOMOBDPIA()
	{
		SCShader = Shader.Find("/Segment-[Up]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IBFJAOINHMK()
	{
	}

	private void KLILJHJNICK()
	{
		SCShader = Shader.Find("settings_bindings_");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FDMAEPOHDMK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EODOHEAKJFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.HideInInspector | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void HLHJBJGEEEA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KHIGHFJKPFG()
	{
		SCShader = Shader.Find("Other");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KDJEJBBDILE()
	{
	}

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1957f)
			{
				HBJJOCHGOPH = 1265f;
			}
			BBIMPFGLDCP().SetFloat("<b>#", HBJJOCHGOPH);
			BBIMPFGLDCP().SetFloat("#orderby:", PosX);
			ABHDNGIHBKE().SetFloat("\" gets executed locally only, if at all.", PosY);
			IONHGBPGCHK().SetFloat(".r", Value);
			NBPKMLMCHFN.SetFloat("???", Size);
			NFMGLIKNOOC().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 896f, 1068f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FAMLCFNDGNI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KFMEAMBLODG()
	{
	}

	private void NNBCLMJGFEN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MPJCMKFFKHH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1134f)
			{
				HBJJOCHGOPH = 445f;
			}
			GJHLADDCMFF().SetFloat("Chat", HBJJOCHGOPH);
			KHCLIAMBBNC().SetFloat("Localization Servise\nWorking commands:\nset <language>\nlist\nkeys", PosX);
			KJMECMIGJJA().SetFloat("Multiplayer", PosY);
			OIBHFCLJKDB().SetFloat("CameraFilterPack_Broken_Screen1", Value);
			MLMKCOINOOH().SetFloat("RateButton", Size);
			MNLKBFFKHIE().SetVector("_Offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 926f, 1242f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KHCLIAMBBNC());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)73;
		}
		return BJFKDHHMLJH;
	}

	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 556f)
			{
				HBJJOCHGOPH = 609f;
			}
			IFMAPIDFNLI().SetFloat(":</b> ", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("Up", PosX);
			DONENAMLFLF().SetFloat("#000000", PosY);
			OIBHFCLJKDB().SetFloat("id", Value);
			KEMAALEODNH().SetFloat("_Value4", Size);
			ABHDNGIHBKE().SetVector(" - LOCAL", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1029f, 1569f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BBIMPFGLDCP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GOIMKCCICFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 90f)
			{
				HBJJOCHGOPH = 1568f;
			}
			ENKPNJMPDEB().SetFloat("_TimeX", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat("CameraFilterPack/TV_Noise", PosX);
			KJMECMIGJJA().SetFloat("LoadPlayerEnvironment", PosY);
			IIBLJCKLGFG().SetFloat("RB", Value);
			PLBEJJIHFPB().SetFloat("_Value2", Size);
			GJHLADDCMFF().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1884f, 1851f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IFMAPIDFNLI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material OKJOKHGJHGF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void ECBILENEOOL()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MECJHOJPODB()
	{
	}

	[SpecialName]
	private Material MNLKBFFKHIE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-118);
		}
		return BJFKDHHMLJH;
	}

	private void NPLCENPNJBM()
	{
		SCShader = Shader.Find("ClearEnvironment");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material GJHLADDCMFF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return BJFKDHHMLJH;
	}

	private void OOGIHDLBBLM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ANCKKLFPGDI()
	{
		SCShader = Shader.Find("Could not find RPC with index: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KPOCGNOKNOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1032f)
			{
				HBJJOCHGOPH = 149f;
			}
			EHDJJANLINB().SetFloat("menuVolume", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("[MenuScene] Error: ", PosX);
			PLBEJJIHFPB().SetFloat("OnJoinedRoom() called by PUN. Now this client is in a room. From here on, your game would be running. For reference, all callbacks are listed in enum: PhotonNetworkingMessage", PosY);
			KJMECMIGJJA().SetFloat("bad", Value);
			DNLMFEGJJDD().SetFloat(".lastCheckpoint.powerupsScore", Size);
			EFMCNLELMDO().SetVector("[SERVER] Selected map: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1725f, 1930f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
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

	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1150f)
			{
				HBJJOCHGOPH = 850f;
			}
			AELJLBOJAIL().SetFloat("_NoiseTex", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("ERROR: Preview file name in modName.workshop.json doesn't match any file", PosX);
			IONHGBPGCHK().SetFloat("JoinButton", PosY);
			IONHGBPGCHK().SetFloat("intensity", Value);
			NBPKMLMCHFN.SetFloat("/", Size);
			EFMCNLELMDO().SetVector("1", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1384f, 434f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KCNIHHNMFFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 961f)
			{
				HBJJOCHGOPH = 1070f;
			}
			KAFBNOBOIAJ().SetFloat("Lag ", HBJJOCHGOPH);
			EHDJJANLINB().SetFloat(":", PosX);
			KJMECMIGJJA().SetFloat("workshop.txt", PosY);
			OIBHFCLJKDB().SetFloat("_AccumulationTex", Value);
			NBPKMLMCHFN.SetFloat("_HeightParams", Size);
			ABHDNGIHBKE().SetVector("Source: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1177f, 50f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IABLKKAALGI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1516f)
			{
				HBJJOCHGOPH = 305f;
			}
			EFMCNLELMDO().SetFloat("SetParticlesParticleSpeed", HBJJOCHGOPH);
			GJHLADDCMFF().SetFloat("_MatrixColor", PosX);
			KHCLIAMBBNC().SetFloat("_Offsets", PosY);
			DONENAMLFLF().SetFloat("_Value3", Value);
			MLMKCOINOOH().SetFloat("/", Size);
			AELJLBOJAIL().SetVector("RecieveChatActionMessage", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1463f, 560f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GKNKIIEALCH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LLKKGGLNIDF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material ENKPNJMPDEB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)112;
		}
		return BJFKDHHMLJH;
	}

	private void Update()
	{
	}

	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1041f)
			{
				HBJJOCHGOPH = 851f;
			}
			DNLMFEGJJDD().SetFloat("_TimeX", HBJJOCHGOPH);
			MNLKBFFKHIE().SetFloat("mainmenu", PosX);
			IIBLJCKLGFG().SetFloat("0,1,false", PosY);
			KEMAALEODNH().SetFloat("CameraFilterPack/Blend2Camera_Subtract", Value);
			KAFBNOBOIAJ().SetFloat("_ScreenResolution", Size);
			IIBLJCKLGFG().SetVector("LostLive", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1318f, 554f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material KEMAALEODNH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material BBIMPFGLDCP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1672f)
			{
				HBJJOCHGOPH = 1273f;
			}
			KEMAALEODNH().SetFloat(",", HBJJOCHGOPH);
			MNLKBFFKHIE().SetFloat("attempted to spawn a GameObject from recycle bin (", PosX);
			NFMGLIKNOOC().SetFloat(" BETA", PosY);
			IGIAPKPKGPK().SetFloat("_Value4", Value);
			EJDPNJAEAKJ().SetFloat("_ScreenResolution", Size);
			EFMCNLELMDO().SetVector("Uploading content", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1131f, 355f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
