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
			AELJLBOJAIL().SetFloat("Tab2Content", HBJJOCHGOPH);
			MNLKBFFKHIE().SetFloat("GameModeText", PosX);
			NBPKMLMCHFN.SetFloat(" workshop map(s)", PosY);
			EJDPNJAEAKJ().SetFloat("Anomaly_Intensity", Value);
			IONHGBPGCHK().SetFloat("_Value4", Size);
			KAFBNOBOIAJ().SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1750f, 226f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IFMAPIDFNLI());
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
			KEMAALEODNH().SetFloat("_DotSize", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("TestMapButton", PosX);
			ABHDNGIHBKE().SetFloat("_HdrParams", PosY);
			IIBLJCKLGFG().SetFloat("_ScreenResolution", Value);
			EJDPNJAEAKJ().SetFloat("BadgeText", Size);
			NBPKMLMCHFN.SetVector("_", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1472f, 1727f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFMCNLELMDO());
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
			OIBHFCLJKDB().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			MLMKCOINOOH().SetFloat("RecieveChatMessage", PosX);
			IGIAPKPKGPK().SetFloat("[FileSelector] Dialog ended, result: ", PosY);
			AELJLBOJAIL().SetFloat("player.bluearc", Value);
			KAFBNOBOIAJ().SetFloat("_Intensity", Size);
			BBIMPFGLDCP().SetVector("challenges.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 658f, 461f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
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
			PLBEJJIHFPB().SetFloat("#yes", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("GlassAberration", PosX);
			KJMECMIGJJA().SetFloat("[PlayerController] ", PosY);
			EFMCNLELMDO().SetFloat("settings_bindings_sec_", Value);
			KAFBNOBOIAJ().SetFloat("Operation ", Size);
			IONHGBPGCHK().SetVector("value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1791f, 665f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGIAPKPKGPK());
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
			NBPKMLMCHFN.SetFloat("{0} minutes ago", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat("_FixDistance", PosX);
			IFMAPIDFNLI().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", PosY);
			IONHGBPGCHK().SetFloat("value", Value);
			IONHGBPGCHK().SetFloat("Set particles start speed", Size);
			PLBEJJIHFPB().SetVector("Failed to 'network-remove' GameObject because has no PhotonView components: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1273f, 1683f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
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
			IGIAPKPKGPK().SetFloat("getbool", HBJJOCHGOPH);
			GJHLADDCMFF().SetFloat("LoadingStatusText", PosX);
			KJMECMIGJJA().SetFloat("_TimeX", PosY);
			PLBEJJIHFPB().SetFloat("_ScreenResolution", Value);
			ABHDNGIHBKE().SetFloat("ConnectToMaster() disabled the offline mode. No longer offline.", Size);
			IFMAPIDFNLI().SetVector("_SizeY", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 810f, 1555f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EJDPNJAEAKJ());
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
			KAFBNOBOIAJ().SetFloat("_TimeX", HBJJOCHGOPH);
			OKJOKHGJHGF().SetFloat("CameraFilterPack_TV_Arcade1", PosX);
			KJMECMIGJJA().SetFloat("_Distortion", PosY);
			IIBLJCKLGFG().SetFloat("_Value7", Value);
			KEMAALEODNH().SetFloat("error", Size);
			KJMECMIGJJA().SetVector("ItemsCountText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 707f, 1384f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
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
			IIBLJCKLGFG().SetFloat("received</b>\n#reason: ", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("CameraFilterPack/Colors_Adjust_FullColors", PosX);
			KHCLIAMBBNC().SetFloat("GLITCH", PosY);
			NBPKMLMCHFN.SetFloat("mainMenu", Value);
			NBPKMLMCHFN.SetFloat("0,2,true,0", Size);
			EHDJJANLINB().SetVector("LoadingStatusText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1685f, 360f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MNLKBFFKHIE());
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
		SCShader = Shader.Find("_TimeX");
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
		SCShader = Shader.Find(",viewkeys");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CCFEDENFNEF()
	{
		SCShader = Shader.Find("InputField");
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
			MLMKCOINOOH().SetFloat("[PlayerController] ", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("_Value", PosX);
			IFMAPIDFNLI().SetFloat("_ChangeBlue", PosY);
			ENKPNJMPDEB().SetFloat("SetSatelliteRadius", Value);
			IGIAPKPKGPK().SetFloat("\n\n#", Size);
			MLMKCOINOOH().SetVector("Uploading preview image", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1449f, 1619f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IFMAPIDFNLI());
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
			ENKPNJMPDEB().SetFloat("ItemNameBGImage", HBJJOCHGOPH);
			OKJOKHGJHGF().SetFloat("_RandomTexture", PosX);
			KAFBNOBOIAJ().SetFloat("_Greenness", PosY);
			MNLKBFFKHIE().SetFloat("LastNewsButton", Value);
			BBIMPFGLDCP().SetFloat("max. lives color", Size);
			MLMKCOINOOH().SetVector("music", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1133f, 858f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
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
			EHDJJANLINB().SetFloat("Player Connected", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("_DotSize", PosX);
			IONHGBPGCHK().SetFloat("_Value2", PosY);
			MLMKCOINOOH().SetFloat("Bass", Value);
			BBIMPFGLDCP().SetFloat(",", Size);
			EFMCNLELMDO().SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 814f, 750f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
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
			DNLMFEGJJDD().SetFloat("CameraFilterPack/Colors_Brightness", HBJJOCHGOPH);
			ENKPNJMPDEB().SetFloat("GlassColor", PosX);
			KHCLIAMBBNC().SetFloat("_Extra", PosY);
			EJDPNJAEAKJ().SetFloat("#ok", Value);
			IGIAPKPKGPK().SetFloat("_Offsets", Size);
			DNLMFEGJJDD().SetVector("InventoryContent", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 361f, 1978f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
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
			MLMKCOINOOH().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			MNLKBFFKHIE().SetFloat("_Red_G", PosX);
			ABHDNGIHBKE().SetFloat("other.dust0", PosY);
			IGIAPKPKGPK().SetFloat("_ExposureAdjustment", Value);
			NBPKMLMCHFN.SetFloat("CONTRAST", Size);
			DNLMFEGJJDD().SetVector("CameraFilterPack/Blur_Steam", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 474f, 1737f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BBIMPFGLDCP());
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
			KEMAALEODNH().SetFloat("<size=24>", HBJJOCHGOPH);
			EHDJJANLINB().SetFloat("_Value", PosX);
			KAFBNOBOIAJ().SetFloat("' got destroyed by engine. This is OK when loading levels. Otherwise use: PhotonNetwork.Destroy().", PosY);
			EFMCNLELMDO().SetFloat("Crosshair1", Value);
			GJHLADDCMFF().SetFloat("_Value", Size);
			KJMECMIGJJA().SetVector(".lastCheckpoint.incorrectScore", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 380f, 1714f));
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
		SCShader = Shader.Find("_AdaptParams");
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
			NBPKMLMCHFN.SetFloat("roomDescription", HBJJOCHGOPH);
			MLMKCOINOOH().SetFloat(" ", PosX);
			EHDJJANLINB().SetFloat("[TextSaver] Text saved to ", PosY);
			PLBEJJIHFPB().SetFloat("_Value3", Value);
			BBIMPFGLDCP().SetFloat("[Right-Left]", Size);
			NBPKMLMCHFN.SetVector("CameraFilterPack/Vision_Hell_Blood", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1839f, 1010f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JKFDDNMPOJH()
	{
		SCShader = Shader.Find("_LutTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CGDMLHLJIDK()
	{
		SCShader = Shader.Find("_Value2");
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
			MNLKBFFKHIE().SetFloat("Copy from ", HBJJOCHGOPH);
			EJDPNJAEAKJ().SetFloat("_Blue_R", PosX);
			KJMECMIGJJA().SetFloat("settings_bindings_sec_", PosY);
			EFMCNLELMDO().SetFloat("UnityEngine.MonoBehaviour", Value);
			EJDPNJAEAKJ().SetFloat("_Blue_B", Size);
			DNLMFEGJJDD().SetVector("Joystick1Button3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 59f, 1722f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFMCNLELMDO());
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
			NFMGLIKNOOC().SetFloat("Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. ", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat("curScn", PosX);
			NBPKMLMCHFN.SetFloat("[LobbyPlayerElement] On ready click", PosY);
			EJDPNJAEAKJ().SetFloat("_Value", Value);
			NBPKMLMCHFN.SetFloat("LoadingStatusText", Size);
			NBPKMLMCHFN.SetVector("Hidden/DepthOfField/BokehSplatting", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 394f, 216f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
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
		SCShader = Shader.Find("_Value");
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
			NFMGLIKNOOC().SetFloat("_Intensity", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("Joystick1Button8", PosX);
			NBPKMLMCHFN.SetFloat("_MainTex2", PosY);
			IIBLJCKLGFG().SetFloat("_Distortion", Value);
			KHCLIAMBBNC().SetFloat("Working.\nPlease wait..", Size);
			IIBLJCKLGFG().SetVector("z", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1432f, 73f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHLADDCMFF());
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
			KEMAALEODNH().SetFloat("settings_bindings_", HBJJOCHGOPH);
			IGIAPKPKGPK().SetFloat("*.workshop.json", PosX);
			KAFBNOBOIAJ().SetFloat("grid", PosY);
			NBPKMLMCHFN.SetFloat("_Blue_B", Value);
			BBIMPFGLDCP().SetFloat("_Intensity", Size);
			DNLMFEGJJDD().SetVector("PhotonView with ID ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1782f, 1682f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIBLJCKLGFG());
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
			MLMKCOINOOH().SetFloat("/icon", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat(",", PosX);
			PLBEJJIHFPB().SetFloat("Save Path: ", PosY);
			EJDPNJAEAKJ().SetFloat("setAF", Value);
			IGIAPKPKGPK().SetFloat("TransferOwnership() view ", Size);
			IONHGBPGCHK().SetVector("menu.selectedplaymode", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1078f, 13f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IFMAPIDFNLI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KCCIEMBMOBA()
	{
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MEBPBNLBECA()
	{
		SCShader = Shader.Find("Failed to 'GetKeyCode' for key: ");
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
			EHDJJANLINB().SetFloat("\n\n• ", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("_Value2", PosX);
			EHDJJANLINB().SetFloat("<b>Commands:</b>\n/help\n/players\n/kick\n/table\n/clear", PosY);
			KAFBNOBOIAJ().SetFloat("_ScreenResolution", Value);
			KEMAALEODNH().SetFloat("_FixDistance", Size);
			NFMGLIKNOOC().SetVector("In Network lobby", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 566f, 1712f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KHCLIAMBBNC());
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
		SCShader = Shader.Find("bad");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FEHCNJLLJMP()
	{
		SCShader = Shader.Find("_Value3");
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
		SCShader = Shader.Find("a");
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
			PLBEJJIHFPB().SetFloat("note.4", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat(" not exist", PosX);
			OKJOKHGJHGF().SetFloat(": ", PosY);
			NFMGLIKNOOC().SetFloat("Editor/", Value);
			EHDJJANLINB().SetFloat("mapselector.orderby", Size);
			EHDJJANLINB().SetVector("scn", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1584f, 1445f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHLADDCMFF());
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
		SCShader = Shader.Find("_Value5");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DAHFFNNIGML()
	{
		SCShader = Shader.Find("_UV_Transform");
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
		SCShader = Shader.Find("_Red_B");
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
		SCShader = Shader.Find("SetParticlesInput");
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
		SCShader = Shader.Find("inventory.selected.");
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
		SCShader = Shader.Find("settings_bindings_controller_type");
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
			MNLKBFFKHIE().SetFloat("bans.viewed.", HBJJOCHGOPH);
			OKJOKHGJHGF().SetFloat("isVisible", PosX);
			KJMECMIGJJA().SetFloat(". Possible scene loading in progress?", PosY);
			EHDJJANLINB().SetFloat(".r", Value);
			OKJOKHGJHGF().SetFloat("CountEventsGoal", Size);
			GJHLADDCMFF().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 896f, 1068f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IFMAPIDFNLI());
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
			DNLMFEGJJDD().SetFloat("ChatInput", HBJJOCHGOPH);
			BBIMPFGLDCP().SetFloat("<command>", PosX);
			NFMGLIKNOOC().SetFloat("Multiplayer", PosY);
			IFMAPIDFNLI().SetFloat("_MainTex2", Value);
			DONENAMLFLF().SetFloat("FavoriteButton", Size);
			KJMECMIGJJA().SetVector("_Offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 926f, 1242f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KAFBNOBOIAJ());
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
			IGIAPKPKGPK().SetFloat(":</b> ", HBJJOCHGOPH);
			OKJOKHGJHGF().SetFloat("Right ", PosX);
			KAFBNOBOIAJ().SetFloat("#FFFFFF", PosY);
			BBIMPFGLDCP().SetFloat("Set EnvSprite Image", Value);
			ABHDNGIHBKE().SetFloat("_Value3", Size);
			IIBLJCKLGFG().SetVector("]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1029f, 1569f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIBHFCLJKDB());
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
			GJHLADDCMFF().SetFloat("_TimeX", HBJJOCHGOPH);
			EJDPNJAEAKJ().SetFloat("_Fade", PosX);
			EJDPNJAEAKJ().SetFloat("settings.arcsnohitsoundtimedelay", PosY);
			BBIMPFGLDCP().SetFloat("LB", Value);
			KAFBNOBOIAJ().SetFloat("_Value1", Size);
			MLMKCOINOOH().SetVector("CameraFilterPack/FX_Glitch1", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1884f, 1851f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
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
		SCShader = Shader.Find("_Threshold");
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
		SCShader = Shader.Find("SendVacantViewIds()");
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
			OIBHFCLJKDB().SetFloat("gameVolume", HBJJOCHGOPH);
			MLMKCOINOOH().SetFloat("Player", PosX);
			NBPKMLMCHFN.SetFloat("OnPhotonRandomJoinFailed() was called by PUN. No random room available, so we create one. Calling: PhotonNetwork.CreateRoom(null, new RoomOptions() {maxPlayers = 4}, null);", PosY);
			BBIMPFGLDCP().SetFloat("error", Value);
			KHCLIAMBBNC().SetFloat(".lastCheckpoint.incorrectScore", Size);
			KHCLIAMBBNC().SetVector("[SERVER] Selected map: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1725f, 1930f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIBHFCLJKDB());
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
			KEMAALEODNH().SetFloat("_NoiseAmount", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("ERROR: mod directory not found!", PosX);
			IONHGBPGCHK().SetFloat("JoinButton", PosY);
			IONHGBPGCHK().SetFloat("offsets", Value);
			BBIMPFGLDCP().SetFloat("selector", Size);
			GJHLADDCMFF().SetVector("Month_", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1384f, 434f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MLMKCOINOOH());
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
			EHDJJANLINB().SetFloat("Rtt:{0,4} +/-{1,3}", HBJJOCHGOPH);
			DONENAMLFLF().SetFloat("ConnectToMaster() failed. Can only connect while in state 'Disconnected'. Current state: ", PosX);
			EJDPNJAEAKJ().SetFloat("workshop.txt", PosY);
			KHCLIAMBBNC().SetFloat("USE_UV_BASED_REPROJECTION", Value);
			NBPKMLMCHFN.SetFloat("_FrustumCornersWS", Size);
			OIBHFCLJKDB().SetVector("Source: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1177f, 50f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
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
			OIBHFCLJKDB().SetFloat("SetParticlesColor", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_MatrixColor", PosX);
			BBIMPFGLDCP().SetFloat("_StretchWidth", PosY);
			KEMAALEODNH().SetFloat("_Value2", Value);
			KAFBNOBOIAJ().SetFloat("/", Size);
			NFMGLIKNOOC().SetVector("RecieveChatActionMessage", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1463f, 560f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHLADDCMFF());
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
			NBPKMLMCHFN.SetFloat("_TimeX", HBJJOCHGOPH);
			DONENAMLFLF().SetFloat("mainmenu", PosX);
			KEMAALEODNH().SetFloat("0,1,false", PosY);
			MNLKBFFKHIE().SetFloat("CameraFilterPack/Blend2Camera_Exclusion", Value);
			OKJOKHGJHGF().SetFloat("_BlueAmplifier", Size);
			ENKPNJMPDEB().SetVector("[", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1318f, 554f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ENKPNJMPDEB());
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
			KAFBNOBOIAJ().SetFloat("#TBD", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat(") but there is no recycle bin setup for it. Falling back to Instantiate", PosX);
			KAFBNOBOIAJ().SetFloat("[BuildInfo] Error: ", PosY);
			IONHGBPGCHK().SetFloat("_Value3", Value);
			IGIAPKPKGPK().SetFloat("_Value", Size);
			ABHDNGIHBKE().SetVector("Preparing configuration", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1131f, 355f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
