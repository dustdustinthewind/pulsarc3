// CameraFilterPack_Atmosphere_Rain
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Weather/Rain")]
public class CameraFilterPack_Atmosphere_Rain : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 1f)]
	public float Fade = 1f;

	[Range(0f, 2f)]
	public float Intensity = 0.5f;

	[Range(-0.25f, 0.25f)]
	public float DirectionX = 0.12f;

	[Range(0.4f, 2f)]
	public float Size = 1.5f;

	[Range(0f, 0.5f)]
	public float Speed = 0.275f;

	[Range(0f, 0.5f)]
	public float Distortion = 0.05f;

	[Range(0f, 1f)]
	public float StormFlashOnOff = 1f;

	private Texture2D FPHEBLMINDA;

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
	private Material OCHJIMJNEMO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void IHHNCCOGLPN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CIPKEPDELJB()
	{
		FPHEBLMINDA = Resources.Load("\n\n#") as Texture2D;
		SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JMEOGJHCONJ()
	{
		FPHEBLMINDA = Resources.Load("Tab1Content") as Texture2D;
		SCShader = Shader.Find("x");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1137f)
			{
				HBJJOCHGOPH = 602f;
			}
			JIBOKBCPDLC().SetFloat("Room: '{0}' {1},{2} {4}/{3} players.\ncustomProps: {5}", HBJJOCHGOPH);
			EBJKJPAIAAM().SetFloat("Subscribe: ", Fade);
			FKEOGPDLBDD().SetFloat("Please wait..", Intensity);
			HKIMAANBGMJ().SetFloat("ViewMenu", DirectionX);
			NBPKMLMCHFN.SetFloat("_RGB", Speed);
			MJJIEHANFJA().SetFloat("maps.", Size);
			JIBOKBCPDLC().SetFloat(" ", Distortion);
			GJHLADDCMFF().SetFloat("_Exponent", StormFlashOnOff);
			KGOLDDBHIFN().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 583f, 516f));
			PDEAHJPOMEF().SetTexture("Bad parameters for getstring! Use <key> <value>", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LNOOFNGHNEL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1436f)
			{
				HBJJOCHGOPH = 1714f;
			}
			GJHLADDCMFF().SetFloat("_EmissionColor", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("Set Sun Sensitivity", Fade);
			IKBJACCLPCL().SetFloat("Set arcs speed. Base value - 15", Intensity);
			PDEAHJPOMEF().SetFloat("STICKLHOR", DirectionX);
			KGOLDDBHIFN().SetFloat("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", Speed);
			HKIMAANBGMJ().SetFloat(". Should be just one?", Size);
			HKIMAANBGMJ().SetFloat("_EmissionGain", Distortion);
			KHCLIAMBBNC().SetFloat("settings.enablehitsoundsinnormal", StormFlashOnOff);
			FKEOGPDLBDD().SetVector("EventData0DropDownList", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 353f, 520f));
			GJHLADDCMFF().SetTexture(" (", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FHPFJBFCOOF()
	{
		FPHEBLMINDA = Resources.Load("Tab2Content") as Texture2D;
		SCShader = Shader.Find("_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JNALDALAJLG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KMCPMOGKDEH()
	{
		FPHEBLMINDA = Resources.Load("Set Object Scale") as Texture2D;
		SCShader = Shader.Find("_BlurDirectionPacked");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MGFFNGEGFDC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material MJJIEHANFJA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)108;
		}
		return BJFKDHHMLJH;
	}

	private void ICGNMOFMLFA()
	{
	}

	private void IENKPJEBMFM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1291f)
			{
				HBJJOCHGOPH = 1302f;
			}
			KHCLIAMBBNC().SetFloat("inventory.selected.", HBJJOCHGOPH);
			JIBOKBCPDLC().SetFloat("_BlurParams", Fade);
			FGENHBKMPDA().SetFloat("_Glitch", Intensity);
			KGOLDDBHIFN().SetFloat("_ScreenResolution", DirectionX);
			IGKFMCPDNOI().SetFloat("ShowTitle", Speed);
			JIBOKBCPDLC().SetFloat("Save", Size);
			FKEOGPDLBDD().SetFloat("GlassesColor", Distortion);
			NFKFAAHHLLM().SetFloat("_ScreenResolution", StormFlashOnOff);
			LPDOGGFOBDH().SetVector("{0}", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1050f, 1229f));
			KGOLDDBHIFN().SetTexture("LoadPlayerSkin", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FOMNCPKKCFN()
	{
	}

	private void AEDDNDHCLNN()
	{
		FPHEBLMINDA = Resources.Load("Please define the RectTransform for the Center viewport of the scrollable area") as Texture2D;
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OPIBJIMIOKE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 938f)
			{
				HBJJOCHGOPH = 630f;
			}
			HKIMAANBGMJ().SetFloat("_Value3", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("RenderTextureUtilityTempTexture", Fade);
			NFKFAAHHLLM().SetFloat("_ScreenResolution", Intensity);
			NJDIODJNGGA().SetFloat("_ScreenResolution", DirectionX);
			IGKFMCPDNOI().SetFloat("SetCrosshairColor", Speed);
			KLKILLCHJHO().SetFloat("_Value", Size);
			PLBEJJIHFPB().SetFloat("[PlayerBase] Invoke event ", Distortion);
			IKBJACCLPCL().SetFloat("_Value2", StormFlashOnOff);
			IGKFMCPDNOI().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 682f, 318f));
			NJDIODJNGGA().SetTexture("original.tutorial", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KLKILLCHJHO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	private void PNLKFANNOKO()
	{
	}

	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1026f)
			{
				HBJJOCHGOPH = 648f;
			}
			JIBOKBCPDLC().SetFloat("DestroyPlayerObjects() failed, cause parameter 'targetPlayer' was null.", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("EventSystem", Fade);
			KOHGPKOFEJO().SetFloat("_TimeX", Intensity);
			EBJKJPAIAAM().SetFloat("yyyy-MM-dd HH:mm:ss", DirectionX);
			EOCCJGIGEGJ().SetFloat("Operation failed: ", Speed);
			PLBEJJIHFPB().SetFloat("_Value", Size);
			LPDOGGFOBDH().SetFloat("original.tutorial", Distortion);
			ECCPAOBFDKP().SetFloat("CameraFilterPack/Blend2Camera_ColorBurn", StormFlashOnOff);
			NFKFAAHHLLM().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 364f, 587f));
			LPDOGGFOBDH().SetTexture("CameraFilterPack/Drawing_Paper3", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KLKILLCHJHO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IEFMONDKKJN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OCMKCBBCEFG()
	{
	}

	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 10f)
			{
				HBJJOCHGOPH = 1738f;
			}
			IIJMIPBMMBF().SetFloat("{0}", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat("LoadPlayerEnvironment", Fade);
			FKEOGPDLBDD().SetFloat("PUNCloudBestRegion", Intensity);
			DIOAAHJDMLK().SetFloat(".highscore", DirectionX);
			PLBEJJIHFPB().SetFloat("_TimeX", Speed);
			BLMPMOIDGMG().SetFloat("x", Size);
			MJJIEHANFJA().SetFloat("0.00", Distortion);
			OCHJIMJNEMO().SetFloat("y", StormFlashOnOff);
			EOCCJGIGEGJ().SetVector("_Amount", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 985f, 554f));
			FGENHBKMPDA().SetTexture("CameraFilterPack/Blend2Camera_Saturation", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CMIBEOJGAIL()
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
			NBPKMLMCHFN.SetFloat("_Value", Fade);
			NBPKMLMCHFN.SetFloat("_Value2", Intensity);
			NBPKMLMCHFN.SetFloat("_Value3", DirectionX);
			NBPKMLMCHFN.SetFloat("_Value4", Speed);
			NBPKMLMCHFN.SetFloat("_Value5", Size);
			NBPKMLMCHFN.SetFloat("_Value6", Distortion);
			NBPKMLMCHFN.SetFloat("_Value7", StormFlashOnOff);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			NBPKMLMCHFN.SetTexture("Texture2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material IKBJACCLPCL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-128);
		}
		return BJFKDHHMLJH;
	}

	private void HLLHJIDOOGA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MKOMIDCPCDC()
	{
		FPHEBLMINDA = Resources.Load("float,0") as Texture2D;
		SCShader = Shader.Find("curScn");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material KEMAALEODNH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void LGHCJCFHEMF()
	{
		FPHEBLMINDA = Resources.Load(" url: ") as Texture2D;
		SCShader = Shader.Find("0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void Start()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_Atmosphere_Rain_FX") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Atmosphere_Rain");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material FGENHBKMPDA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)90;
		}
		return BJFKDHHMLJH;
	}

	private void NNBCLMJGFEN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DKPBBJINKMG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PDHKMDBNGGN()
	{
		FPHEBLMINDA = Resources.Load("[MapsData] Found ") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack_TV_Arcade1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material HKIMAANBGMJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return BJFKDHHMLJH;
	}

	private void DAHFFNNIGML()
	{
		FPHEBLMINDA = Resources.Load("setAF") as Texture2D;
		SCShader = Shader.Find("Bass");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BMBIGILMLLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 122f)
			{
				HBJJOCHGOPH = 659f;
			}
			KGOLDDBHIFN().SetFloat("CameraFilterPack/3D_Myst", HBJJOCHGOPH);
			NJDIODJNGGA().SetFloat("_Value4", Fade);
			PDEAHJPOMEF().SetFloat("_Blue_B", Intensity);
			KHCLIAMBBNC().SetFloat(":</b> ", DirectionX);
			PDEAHJPOMEF().SetFloat("Distortion", Speed);
			KOHGPKOFEJO().SetFloat("Pop", Size);
			ECCPAOBFDKP().SetFloat("_SmoothEnd", Distortion);
			DIOAAHJDMLK().SetFloat("shader.invert", StormFlashOnOff);
			PLBEJJIHFPB().SetVector("skin.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 263f, 1547f));
			MJJIEHANFJA().SetTexture("SetParent", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KOHGPKOFEJO());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)96;
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

	private void ECBILENEOOL()
	{
		FPHEBLMINDA = Resources.Load("_Value3") as Texture2D;
		SCShader = Shader.Find("\r");
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
			if (HBJJOCHGOPH > 1187f)
			{
				HBJJOCHGOPH = 1194f;
			}
			KEMAALEODNH().SetFloat("y", HBJJOCHGOPH);
			ECCPAOBFDKP().SetFloat("Fade", Fade);
			JIBOKBCPDLC().SetFloat("Set Satellite Input", Intensity);
			DIOAAHJDMLK().SetFloat("_AccumulationTex", DirectionX);
			BLMPMOIDGMG().SetFloat("float,0", Speed);
			GJHLADDCMFF().SetFloat("Joystick1Button9", Size);
			KOHGPKOFEJO().SetFloat("/config", Distortion);
			IGKFMCPDNOI().SetFloat("unsubscribemap", StormFlashOnOff);
			KLKILLCHJHO().SetVector("SpectatingUserInfo", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 321f, 637f));
			KEMAALEODNH().SetTexture("Error: PhotonNetwork.SetInterestGroups was called with an illegal group number: ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CCPEDDLAMIB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 447f)
			{
				HBJJOCHGOPH = 1614f;
			}
			LPDOGGFOBDH().SetFloat("Jazz", HBJJOCHGOPH);
			LPDOGGFOBDH().SetFloat(" to: ", Fade);
			IIJMIPBMMBF().SetFloat("_Value6", Intensity);
			KEMAALEODNH().SetFloat("ReconnectToMaster() with AuthValues == null is not correct!", DirectionX);
			FGENHBKMPDA().SetFloat("Subscribe: ", Speed);
			IIJMIPBMMBF().SetFloat("[LevelEditorScene] Creating new item...", Size);
			BLMPMOIDGMG().SetFloat("SpawnObj", Distortion);
			PLBEJJIHFPB().SetFloat("shader.none", StormFlashOnOff);
			PLBEJJIHFPB().SetVector("Had to lookup view that wasn't in photonViewList: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 814f, 1907f));
			KOHGPKOFEJO().SetTexture("Beat Detected", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KCCIEMBMOBA()
	{
		FPHEBLMINDA = Resources.Load(". Calling ConnectToRegionMaster() is: ") as Texture2D;
		SCShader = Shader.Find("[Up-Right-Down]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FDNONDCGGCG()
	{
		FPHEBLMINDA = Resources.Load("_Value2") as Texture2D;
		SCShader = Shader.Find("1,30,true,0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FAMLCFNDGNI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EIMNPCMHJLJ()
	{
		FPHEBLMINDA = Resources.Load("Creating new item...") as Texture2D;
		SCShader = Shader.Find("colorC");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material DIOAAHJDMLK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	private void CHOPDIGHJNH()
	{
		FPHEBLMINDA = Resources.Load("?") as Texture2D;
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KCDBBPKIFNJ()
	{
	}

	private void AGDIBDLHMKF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 475f)
			{
				HBJJOCHGOPH = 1901f;
			}
			FKEOGPDLBDD().SetFloat("End index must in an integer.", HBJJOCHGOPH);
			NFKFAAHHLLM().SetFloat("CameraFilterPack/BlurTiltShift_Hole", Fade);
			KOHGPKOFEJO().SetFloat(">", Intensity);
			KLKILLCHJHO().SetFloat("_Value3", DirectionX);
			KGOLDDBHIFN().SetFloat("_SecondTex", Speed);
			KHCLIAMBBNC().SetFloat("EditMenu", Size);
			KGOLDDBHIFN().SetFloat("_Value2", Distortion);
			KOHGPKOFEJO().SetFloat("CameraFilterPack_TV_BrokenGlass1", StormFlashOnOff);
			KHCLIAMBBNC().SetVector("finished", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1143f, 1617f));
			EOCCJGIGEGJ().SetTexture("/../", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DOKAKEMDALN()
	{
		FPHEBLMINDA = Resources.Load("Creating new item...") as Texture2D;
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1841f)
			{
				HBJJOCHGOPH = 1556f;
			}
			KEMAALEODNH().SetFloat("menu.tabid", HBJJOCHGOPH);
			BLMPMOIDGMG().SetFloat("_Value2", Fade);
			PDEAHJPOMEF().SetFloat("0 - default, 1 - left, 2 - right", Intensity);
			BLMPMOIDGMG().SetFloat(".completed", DirectionX);
			HKIMAANBGMJ().SetFloat("ResourceIDInputField", Speed);
			PDEAHJPOMEF().SetFloat("_MainTex2", Size);
			MJJIEHANFJA().SetFloat(".lastCheckpoint.perfectHits", Distortion);
			NJDIODJNGGA().SetFloat("GenerationMenu", StormFlashOnOff);
			NFKFAAHHLLM().SetVector("inventory.selected.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 785f, 187f));
			KLKILLCHJHO().SetTexture(". Stopping handling if inactive.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CEAGPJBGBMH()
	{
		FPHEBLMINDA = Resources.Load("_Bullet_1") as Texture2D;
		SCShader = Shader.Find("Editor/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FJABOCDLCAI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IAJKLKJJKEJ()
	{
	}

	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1631f)
			{
				HBJJOCHGOPH = 1123f;
			}
			KEMAALEODNH().SetFloat(" takes from: ", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat("_Amount", Fade);
			PLBEJJIHFPB().SetFloat(".completed", Intensity);
			GJHLADDCMFF().SetFloat("_TimeX", DirectionX);
			KEMAALEODNH().SetFloat("settings.enablerankingnotifications", Speed);
			FKEOGPDLBDD().SetFloat("_Parasite", Size);
			IGKFMCPDNOI().SetFloat("Feb", Distortion);
			LPDOGGFOBDH().SetFloat("CameraFilterPack/Distortion_Twist", StormFlashOnOff);
			FGENHBKMPDA().SetVector("[MapEditor] Item creation successful! Published Item ID: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 977f, 333f));
			KLKILLCHJHO().SetTexture("float,1.5", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HHKBBEFJEBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1913f)
			{
				HBJJOCHGOPH = 74f;
			}
			KHCLIAMBBNC().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("GlassesColor", Fade);
			OCHJIMJNEMO().SetFloat("0.00/0.00", Intensity);
			IKBJACCLPCL().SetFloat("CameraFilterPack/Distortion_Half_Sphere", DirectionX);
			KGOLDDBHIFN().SetFloat("Set sun min/max size", Speed);
			GJHLADDCMFF().SetFloat("_Value", Size);
			EBJKJPAIAAM().SetFloat("_MaxBlurRadius", Distortion);
			NJDIODJNGGA().SetFloat("[LevelEditorScene] Print Audio Wave: Done", StormFlashOnOff);
			ECCPAOBFDKP().SetVector("_FadeFX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 838f, 903f));
			GJHLADDCMFF().SetTexture("#failed: ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1045f)
			{
				HBJJOCHGOPH = 1209f;
			}
			DIOAAHJDMLK().SetFloat("_TimeX", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("_Alpha", Fade);
			OCHJIMJNEMO().SetFloat("#onrankchangeuptext", Intensity);
			FGENHBKMPDA().SetFloat("Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(", DirectionX);
			IIJMIPBMMBF().SetFloat("IconImage", Speed);
			IIJMIPBMMBF().SetFloat("_Amount", Size);
			DIOAAHJDMLK().SetFloat("_TimeX", Distortion);
			KGOLDDBHIFN().SetFloat("In Main Menu", StormFlashOnOff);
			IKBJACCLPCL().SetVector("_VignetteCenter", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 362f, 54f));
			DIOAAHJDMLK().SetTexture("settings.crosshairopacity", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CKCPPNHANAA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 944f)
			{
				HBJJOCHGOPH = 388f;
			}
			HKIMAANBGMJ().SetFloat("[ERROR KEY {0}]", HBJJOCHGOPH);
			ECCPAOBFDKP().SetFloat(":", Fade);
			KLKILLCHJHO().SetFloat("_MainTex2", Intensity);
			JIBOKBCPDLC().SetFloat("\n", DirectionX);
			GJHLADDCMFF().SetFloat("float,0", Speed);
			NBPKMLMCHFN.SetFloat("MapEnd", Size);
			KHCLIAMBBNC().SetFloat("_Fade", Distortion);
			KEMAALEODNH().SetFloat("EndlessLoopsScoreText", StormFlashOnOff);
			NJDIODJNGGA().SetVector("_SprTex", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 876f, 688f));
			KGOLDDBHIFN().SetTexture("maps.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FGBDGGCBFLP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IHAMJLJFFLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 782f)
			{
				HBJJOCHGOPH = 978f;
			}
			KEMAALEODNH().SetFloat("skin.", HBJJOCHGOPH);
			KOHGPKOFEJO().SetFloat(" Remote called.", Fade);
			KEMAALEODNH().SetFloat("Editor/", Intensity);
			KLKILLCHJHO().SetFloat("Bass", DirectionX);
			JIBOKBCPDLC().SetFloat("_Green_G", Speed);
			EBJKJPAIAAM().SetFloat("_Light2", Size);
			MJJIEHANFJA().SetFloat("CameraFilterPack/Distortion_Aspiration", Distortion);
			NJDIODJNGGA().SetFloat("_FarCamera", StormFlashOnOff);
			IKBJACCLPCL().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1409f, 21f));
			NFKFAAHHLLM().SetTexture("PRESS A KEY", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IMGGCJICLHK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PLBOFEPBPKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BMODOIJGIOO()
	{
	}

	[SpecialName]
	private Material NFKFAAHHLLM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void FOAGAKFBIGD()
	{
	}

	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1600f)
			{
				HBJJOCHGOPH = 437f;
			}
			KOHGPKOFEJO().SetFloat("#status", HBJJOCHGOPH);
			LPDOGGFOBDH().SetFloat("CameraFilterPack/TV_Video3D", Fade);
			PDEAHJPOMEF().SetFloat("_ScreenResolution", Intensity);
			IIJMIPBMMBF().SetFloat("_MainTex2", DirectionX);
			LPDOGGFOBDH().SetFloat("_Value", Speed);
			KHCLIAMBBNC().SetFloat("EventMenu", Size);
			MJJIEHANFJA().SetFloat("_TimeX", Distortion);
			IIJMIPBMMBF().SetFloat("_VelocityScale", StormFlashOnOff);
			PLBEJJIHFPB().SetVector(" - PUBLISHED #", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 557f, 157f));
			LPDOGGFOBDH().SetTexture("ConnectUsingSettings() disabled the offline mode. No longer offline.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ODBNMPGBCGO()
	{
		FPHEBLMINDA = Resources.Load("GameScene") as Texture2D;
		SCShader = Shader.Find("_BlurVector");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MFBCLNAHEFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material JIBOKBCPDLC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void PAKPHKPDKGE()
	{
		FPHEBLMINDA = Resources.Load("_ExposureAdjustment") as Texture2D;
		SCShader = Shader.Find("ns");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 233f)
			{
				HBJJOCHGOPH = 1560f;
			}
			KOHGPKOFEJO().SetFloat("_MainTex", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("Joystick1Button5", Fade);
			GJHLADDCMFF().SetFloat("attempted to spawn go (", Intensity);
			PLBEJJIHFPB().SetFloat("_Distortion", DirectionX);
			JIBOKBCPDLC().SetFloat("_FadeFX", Speed);
			KOHGPKOFEJO().SetFloat("SetParticlesColor", Size);
			PDEAHJPOMEF().SetFloat("a year ago", Distortion);
			KEMAALEODNH().SetFloat("_TimeX", StormFlashOnOff);
			PLBEJJIHFPB().SetVector("-", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 675f, 16f));
			KHCLIAMBBNC().SetTexture("CameraFilterPack/Color_Switching", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AKHCOBHHGJP()
	{
		FPHEBLMINDA = Resources.Load("settings.selectormapsperpage") as Texture2D;
		SCShader = Shader.Find("settings.shaders.bloomintencity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material NJDIODJNGGA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-105);
		}
		return BJFKDHHMLJH;
	}

	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 568f)
			{
				HBJJOCHGOPH = 1532f;
			}
			MJJIEHANFJA().SetFloat("time: ", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("{\"items\":", Fade);
			FGENHBKMPDA().SetFloat("<b>Speed</b>:", Intensity);
			NJDIODJNGGA().SetFloat("Editor/", DirectionX);
			KGOLDDBHIFN().SetFloat("_ConsoleSettings", Speed);
			ECCPAOBFDKP().SetFloat("/", Size);
			ECCPAOBFDKP().SetFloat("_FilteredReflections", Distortion);
			HKIMAANBGMJ().SetFloat("skin.hit_wrong", StormFlashOnOff);
			JIBOKBCPDLC().SetVector("menu.enableselectormusic", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1139f, 1491f));
			MJJIEHANFJA().SetTexture("inventory.selected.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DLBODOFAJGM()
	{
		FPHEBLMINDA = Resources.Load("_Speed") as Texture2D;
		SCShader = Shader.Find("settings.enablehitsoundsinrelax");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LBAJLLFMMMP()
	{
		FPHEBLMINDA = Resources.Load("_Value") as Texture2D;
		SCShader = Shader.Find("workshop.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LEAHIBJDMBI()
	{
	}

	private void HGDDCINLDAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HIPBNBKNICE()
	{
	}

	private void KHGEBPHKAGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 961f)
			{
				HBJJOCHGOPH = 1226f;
			}
			ECCPAOBFDKP().SetFloat("skin.", HBJJOCHGOPH);
			HKIMAANBGMJ().SetFloat("_TimeX", Fade);
			FKEOGPDLBDD().SetFloat("MenuScene", Intensity);
			FKEOGPDLBDD().SetFloat("bans.viewed.", DirectionX);
			PDEAHJPOMEF().SetFloat("_TimeX", Speed);
			GJHLADDCMFF().SetFloat("skin.hit_wrong", Size);
			KLKILLCHJHO().SetFloat(" is not supported on this platform!", Distortion);
			KEMAALEODNH().SetFloat("_Value7", StormFlashOnOff);
			GJHLADDCMFF().SetVector("[SERVER] Selected map: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1194f, 543f));
			FGENHBKMPDA().SetTexture("%", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IMCKJCHKMKB()
	{
		FPHEBLMINDA = Resources.Load("settings.crosshairopacity") as Texture2D;
		SCShader = Shader.Find("_DotSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1457f)
			{
				HBJJOCHGOPH = 3f;
			}
			NBPKMLMCHFN.SetFloat("[ResourcesManager] Load text error: not found", HBJJOCHGOPH);
			OCHJIMJNEMO().SetFloat("Vignette", Fade);
			KGOLDDBHIFN().SetFloat("_VelTex", Intensity);
			MJJIEHANFJA().SetFloat("BitsData", DirectionX);
			PDEAHJPOMEF().SetFloat("LivesSlider", Speed);
			JIBOKBCPDLC().SetFloat("CameraFilterPack/Retro_Loading", Size);
			NJDIODJNGGA().SetFloat("config.txt", Distortion);
			KOHGPKOFEJO().SetFloat("[Right]", StormFlashOnOff);
			NJDIODJNGGA().SetVector("Overlay", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 307f, 589f));
			NJDIODJNGGA().SetTexture("_TimeX", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material KOHGPKOFEJO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material LPDOGGFOBDH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-105);
		}
		return BJFKDHHMLJH;
	}

	private void NJHJHBOJKIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EDBEHEKMGFH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material PLBEJJIHFPB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.HideInHierarchy | HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material EOCCJGIGEGJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-121);
		}
		return BJFKDHHMLJH;
	}

	private void PKGJJFIFLII()
	{
	}

	[SpecialName]
	private Material IGKFMCPDNOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)75;
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

	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1241f)
			{
				HBJJOCHGOPH = 851f;
			}
			FGENHBKMPDA().SetFloat("settings.selectormapsperpage", HBJJOCHGOPH);
			GJHLADDCMFF().SetFloat("LevelEditor/CustomEventEditor-Text", Fade);
			ECCPAOBFDKP().SetFloat(".", Intensity);
			NBPKMLMCHFN.SetFloat("_Value7", DirectionX);
			ECCPAOBFDKP().SetFloat("LoadingStatusText", Speed);
			DIOAAHJDMLK().SetFloat("_BlurCoe", Size);
			NJDIODJNGGA().SetFloat("_TimeX", Distortion);
			IGKFMCPDNOI().SetFloat("CameraFilterPack_Glasses_On4", StormFlashOnOff);
			NFKFAAHHLLM().SetVector("no lives color", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1466f, 565f));
			ECCPAOBFDKP().SetTexture(",", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JOACBIEHHCE()
	{
	}

	private void BGDONBMDPGM()
	{
	}

	private void KIMMMCJFMAB()
	{
		FPHEBLMINDA = Resources.Load("<b>") as Texture2D;
		SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material KHCLIAMBBNC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)102;
		}
		return BJFKDHHMLJH;
	}

	private void PMPKMGKAAJH()
	{
		FPHEBLMINDA = Resources.Load("Mouse X") as Texture2D;
		SCShader = Shader.Find("[MapsData] Bad map: ");
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
			BJFKDHHMLJH.hideFlags = (HideFlags)120;
		}
		return BJFKDHHMLJH;
	}

	private void JILOMOBDPIA()
	{
		FPHEBLMINDA = Resources.Load("red") as Texture2D;
		SCShader = Shader.Find("[PlayerBase] Invoke event ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material KLKILLCHJHO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)81;
		}
		return BJFKDHHMLJH;
	}

	private void HAIAHJPCPAG()
	{
		FPHEBLMINDA = Resources.Load("SpawnObj") as Texture2D;
		SCShader = Shader.Find("[TextSaver] Text saved to ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OGJJDKENBNC()
	{
		FPHEBLMINDA = Resources.Load("_MainTex2") as Texture2D;
		SCShader = Shader.Find("id");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 15f)
			{
				HBJJOCHGOPH = 160f;
			}
			PDEAHJPOMEF().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("_ScreenResolution", Fade);
			KLKILLCHJHO().SetFloat("ConnectUsingSettings() disabled the offline mode. No longer offline.", Intensity);
			MJJIEHANFJA().SetFloat("CompletedLevel", DirectionX);
			KGOLDDBHIFN().SetFloat("maps.", Speed);
			FKEOGPDLBDD().SetFloat("Edited event", Size);
			IIJMIPBMMBF().SetFloat("UseScanLineSize", Distortion);
			DIOAAHJDMLK().SetFloat("1.87", StormFlashOnOff);
			HKIMAANBGMJ().SetVector("Failed to Destroy objects of playerId: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 726f, 1871f));
			KOHGPKOFEJO().SetTexture("Line", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KLKILLCHJHO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JIAAFKOPEKO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1895f)
			{
				HBJJOCHGOPH = 1119f;
			}
			LPDOGGFOBDH().SetFloat("AudioSampler", HBJJOCHGOPH);
			GJHLADDCMFF().SetFloat("float,2", Fade);
			LPDOGGFOBDH().SetFloat("CameraMovementSlider", Intensity);
			NJDIODJNGGA().SetFloat("_Value2", DirectionX);
			NFKFAAHHLLM().SetFloat("threshold", Speed);
			DIOAAHJDMLK().SetFloat("UsernameText", Size);
			JIBOKBCPDLC().SetFloat("inventory.selected.", Distortion);
			EOCCJGIGEGJ().SetFloat("ItemNameText", StormFlashOnOff);
			GJHLADDCMFF().SetVector("LevelConfigButton", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1794f, 86f));
			LPDOGGFOBDH().SetTexture("GlassAberration", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CNGAJDBOCLJ()
	{
		FPHEBLMINDA = Resources.Load("maps.") as Texture2D;
		SCShader = Shader.Find("player.goldwatermelon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KMOCDAOKGLI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MFLBEJHMEMO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IKMELABKBHO()
	{
	}

	private void FDMAEPOHDMK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IKDNLHLBHID()
	{
		FPHEBLMINDA = Resources.Load("DPADHOR") as Texture2D;
		SCShader = Shader.Find(" connected: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material EBJKJPAIAAM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	private void JHANGPCOCIG()
	{
		FPHEBLMINDA = Resources.Load("Right Stick Click") as Texture2D;
		SCShader = Shader.Find("LivesSlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NLDKIPEMILC()
	{
		FPHEBLMINDA = Resources.Load("settings.hitvariation") as Texture2D;
		SCShader = Shader.Find("Have you fully accept the terms?");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ANKIJGCGCBF()
	{
	}

	[SpecialName]
	private Material GJHLADDCMFF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void HLDFOJMHKNL()
	{
	}

	[SpecialName]
	private Material IIJMIPBMMBF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)105;
		}
		return BJFKDHHMLJH;
	}

	private void CPAJLKHMOJB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KFMEAMBLODG()
	{
	}

	private void FJNCHGLIEMA()
	{
		FPHEBLMINDA = Resources.Load("Cant ask anyone else for PickupItem spawn times.") as Texture2D;
		SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 993f)
			{
				HBJJOCHGOPH = 1793f;
			}
			HKIMAANBGMJ().SetFloat("float,0", HBJJOCHGOPH);
			DIOAAHJDMLK().SetFloat("JoinButton", Fade);
			KEMAALEODNH().SetFloat(" not exist", Intensity);
			DIOAAHJDMLK().SetFloat("_Offsets", DirectionX);
			OCHJIMJNEMO().SetFloat("NEW_ACHIEVEMENT_1_", Speed);
			DIOAAHJDMLK().SetFloat("_DotSize", Size);
			KOHGPKOFEJO().SetFloat("Registered PhotonView: ", Distortion);
			JIBOKBCPDLC().SetFloat("_ScreenResolution", StormFlashOnOff);
			KLKILLCHJHO().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 829f, 1708f));
			NFKFAAHHLLM().SetTexture("Error0", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IKBJACCLPCL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LECCHIAFGGE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MDCFIHDPLIG()
	{
	}

	private void ALJEADNKJPO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CNPINCHINJA()
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
			if (HBJJOCHGOPH > 1363f)
			{
				HBJJOCHGOPH = 21f;
			}
			MJJIEHANFJA().SetFloat("_BlurredColor", HBJJOCHGOPH);
			BLMPMOIDGMG().SetFloat("_MainTex2", Fade);
			BLMPMOIDGMG().SetFloat("settings.selectormapsperpage", Intensity);
			NBPKMLMCHFN.SetFloat("_Distortion", DirectionX);
			BLMPMOIDGMG().SetFloat("_RampTex", Speed);
			KGOLDDBHIFN().SetFloat("CameraFilterPack/Edge_BlackLine", Size);
			IKBJACCLPCL().SetFloat("_Value5", Distortion);
			MJJIEHANFJA().SetFloat("id", StormFlashOnOff);
			KGOLDDBHIFN().SetVector("GlassDistortion", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 19f, 1179f));
			EBJKJPAIAAM().SetTexture("/", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EPJJDKJEDMM()
	{
	}

	private void JAAJECBCCFM()
	{
	}

	private void EFJDNLGNACH()
	{
		FPHEBLMINDA = Resources.Load("cancel") as Texture2D;
		SCShader = Shader.Find("OnEvent: {0}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CCFEDENFNEF()
	{
		FPHEBLMINDA = Resources.Load("BadgeText") as Texture2D;
		SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NNFMIAFHMJM()
	{
		FPHEBLMINDA = Resources.Load("&search=") as Texture2D;
		SCShader = Shader.Find("curScn");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JEBIBKLHFLB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void IHLMNAGPKDA()
	{
		FPHEBLMINDA = Resources.Load("-") as Texture2D;
		SCShader = Shader.Find("sounds/no_hit");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EDPDMBFLHLP()
	{
		FPHEBLMINDA = Resources.Load("_ScreenResolution") as Texture2D;
		SCShader = Shader.Find("Horizontal");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material FKEOGPDLBDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)70;
		}
		return BJFKDHHMLJH;
	}

	private void AIKDNGCEDAB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1153f)
			{
				HBJJOCHGOPH = 1602f;
			}
			KGOLDDBHIFN().SetFloat("HandsCountSlider", HBJJOCHGOPH);
			DIOAAHJDMLK().SetFloat("[MapEditor] Created new map: ", Fade);
			KEMAALEODNH().SetFloat(").png", Intensity);
			JIBOKBCPDLC().SetFloat("CameraFilterPack_Glasses_On7", DirectionX);
			NFKFAAHHLLM().SetFloat("PossibleMapPointsText", Speed);
			IKBJACCLPCL().SetFloat("_ScreenResolution", Size);
			JIBOKBCPDLC().SetFloat(" has been disabled as it's not supported on the current platform.", Distortion);
			KOHGPKOFEJO().SetFloat("_Curve", StormFlashOnOff);
			PDEAHJPOMEF().SetVector("steamid", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 601f, 765f));
			KOHGPKOFEJO().SetTexture("CameraFilterPack/EXTRA_Rotation", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GNJDKAECPKA()
	{
		FPHEBLMINDA = Resources.Load("_Bullet_6") as Texture2D;
		SCShader = Shader.Find("value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OKHBBIKDIEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1655f)
			{
				HBJJOCHGOPH = 655f;
			}
			PLBEJJIHFPB().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat("_Value", Fade);
			BLMPMOIDGMG().SetFloat("UseScanLine", Intensity);
			NJDIODJNGGA().SetFloat("_Size", DirectionX);
			MJJIEHANFJA().SetFloat("_TimeX", Speed);
			KLKILLCHJHO().SetFloat("_NoOuterClip", Size);
			KGOLDDBHIFN().SetFloat("CameraFilterPack/Drawing_Toon", Distortion);
			NBPKMLMCHFN.SetFloat("Default UI Material", StormFlashOnOff);
			ECCPAOBFDKP().SetVector("Oct", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 445f, 238f));
			KHCLIAMBBNC().SetTexture("22x1", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ONPFGCEFMML()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CGBHOELMAOC()
	{
	}

	[SpecialName]
	private Material KGOLDDBHIFN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)124;
		}
		return BJFKDHHMLJH;
	}
}
