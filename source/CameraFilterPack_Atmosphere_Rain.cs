// CameraFilterPack_Atmosphere_Rain
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Weather/Rain")]
[ExecuteInEditMode]
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
		FPHEBLMINDA = Resources.Load("restrictions\n\n#until: ") as Texture2D;
		SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JMEOGJHCONJ()
	{
		FPHEBLMINDA = Resources.Load("Tab1Content") as Texture2D;
		SCShader = Shader.Find("z");
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
			GJHLADDCMFF().SetFloat("open", HBJJOCHGOPH);
			LPDOGGFOBDH().SetFloat("ticket", Fade);
			JIBOKBCPDLC().SetFloat("Editor/", Intensity);
			KLKILLCHJHO().SetFloat("SaveButton", DirectionX);
			EOCCJGIGEGJ().SetFloat("CameraFilterPack_TV_HorrorFX", Speed);
			FKEOGPDLBDD().SetFloat("maps.", Size);
			FKEOGPDLBDD().SetFloat(" ", Distortion);
			IKBJACCLPCL().SetFloat("intensity", StormFlashOnOff);
			NBPKMLMCHFN.SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 583f, 516f));
			KHCLIAMBBNC().SetTexture("Bad parameters for getstring! Use <key> <value>", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
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
			IIJMIPBMMBF().SetFloat("settings.crosshairopacity", HBJJOCHGOPH);
			BLMPMOIDGMG().SetFloat("Set Sun Sensitivity", Fade);
			OCHJIMJNEMO().SetFloat("Set arcs speed. Base value - 15", Intensity);
			IKBJACCLPCL().SetFloat("STICKRHOR", DirectionX);
			KOHGPKOFEJO().SetFloat("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", Speed);
			PLBEJJIHFPB().SetFloat("PhotonNetwork error: Could not Instantiate the prefab [", Size);
			LPDOGGFOBDH().SetFloat("[PlayerBase] Reset", Distortion);
			IGKFMCPDNOI().SetFloat("-", StormFlashOnOff);
			NBPKMLMCHFN.SetVector("Please wait..", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 353f, 520f));
			NFKFAAHHLLM().SetTexture("Screenshots only supported in PlayMode", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FHPFJBFCOOF()
	{
		FPHEBLMINDA = Resources.Load("Tab2Content") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/FX_8bits_gb");
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
		FPHEBLMINDA = Resources.Load("id") as Texture2D;
		SCShader = Shader.Find("_MinVelocity");
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
			EOCCJGIGEGJ().SetFloat("LoadingStatusText", HBJJOCHGOPH);
			ECCPAOBFDKP().SetFloat("_BlurParams", Fade);
			KLKILLCHJHO().SetFloat("_Noise", Intensity);
			EBJKJPAIAAM().SetFloat("CameraFilterPack/Blend2Camera_Luminosity", DirectionX);
			IIJMIPBMMBF().SetFloat("SpawnObj", Speed);
			KGOLDDBHIFN().SetFloat("Save", Size);
			NBPKMLMCHFN.SetFloat("GlassesColor2", Distortion);
			LPDOGGFOBDH().SetFloat("_ScreenResolution", StormFlashOnOff);
			NJDIODJNGGA().SetVector("{0:0} second{1}", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1050f, 1229f));
			PDEAHJPOMEF().SetTexture("/Segment-[Right]", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ECCPAOBFDKP());
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
		FPHEBLMINDA = Resources.Load("yyyy") as Texture2D;
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
			NJDIODJNGGA().SetFloat("_Value4", HBJJOCHGOPH);
			LPDOGGFOBDH().SetFloat("Hidden/DepthOfField/DepthOfField", Fade);
			IIJMIPBMMBF().SetFloat("CameraFilterPack/FX_ZebraColor", Intensity);
			JIBOKBCPDLC().SetFloat("CameraFilterPack/TV_ARCADE_2", DirectionX);
			MJJIEHANFJA().SetFloat("SetParticlesParticleSize", Speed);
			GJHLADDCMFF().SetFloat("_Value2", Size);
			NFKFAAHHLLM().SetFloat("[PlayerBase] SetSpeed error: ", Distortion);
			GJHLADDCMFF().SetFloat("_Value2", StormFlashOnOff);
			FKEOGPDLBDD().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 682f, 318f));
			KLKILLCHJHO().SetTexture("original.tutorial", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
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
			IIJMIPBMMBF().SetFloat("Error; Only the MasterClient can call RemoveRPCs for other players.", HBJJOCHGOPH);
			JIBOKBCPDLC().SetFloat("Maps Editor v.", Fade);
			GJHLADDCMFF().SetFloat("_Distortion", Intensity);
			NJDIODJNGGA().SetFloat("IDInputField", DirectionX);
			NBPKMLMCHFN.SetFloat("If you host Photon yourself, make sure to start the 'Instance LoadBalancing' ", Speed);
			KEMAALEODNH().SetFloat("_ScreenResolution", Size);
			IKBJACCLPCL().SetFloat("menu.playedsolo", Distortion);
			GJHLADDCMFF().SetFloat("CameraFilterPack/Blend2Camera_ColorBurn", StormFlashOnOff);
			LPDOGGFOBDH().SetVector("_Value4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 364f, 587f));
			FGENHBKMPDA().SetTexture("_TimeX", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
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
			FKEOGPDLBDD().SetFloat(" - {0}", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat(".", Fade);
			IIJMIPBMMBF().SetFloat("PUNCloudBestRegion", Intensity);
			BLMPMOIDGMG().SetFloat("[PlayerBase] Game mode: ", DirectionX);
			NFKFAAHHLLM().SetFloat("_TimeX", Speed);
			KOHGPKOFEJO().SetFloat("ItemNameText", Size);
			GJHLADDCMFF().SetFloat("[MapEditor] Loading map: ", Distortion);
			NBPKMLMCHFN.SetFloat("w", StormFlashOnOff);
			MJJIEHANFJA().SetVector("_Amount", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 985f, 554f));
			IKBJACCLPCL().SetTexture("CameraFilterPack/Blend2Camera_Color", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BLMPMOIDGMG());
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
		FPHEBLMINDA = Resources.Load("Set sun min/max size") as Texture2D;
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
		FPHEBLMINDA = Resources.Load("[ResourcesManager] Load audio error: ") as Texture2D;
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
		FPHEBLMINDA = Resources.Load(" workshop map(s)") as Texture2D;
		SCShader = Shader.Find("_TimeX");
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
		FPHEBLMINDA = Resources.Load("<color=#{0}>{1}</color>") as Texture2D;
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
			MJJIEHANFJA().SetFloat("CameraFilterPack/3D_Myst", HBJJOCHGOPH);
			LPDOGGFOBDH().SetFloat("BloodAlternative1", Fade);
			FGENHBKMPDA().SetFloat("_Red_C", Intensity);
			IIJMIPBMMBF().SetFloat("LoadingStatusText", DirectionX);
			KGOLDDBHIFN().SetFloat("Texture2", Speed);
			FGENHBKMPDA().SetFloat("Rap", Size);
			JIBOKBCPDLC().SetFloat("_SmoothEnd", Distortion);
			KHCLIAMBBNC().SetFloat("shader.future", StormFlashOnOff);
			KLKILLCHJHO().SetVector("Unable to get a reward! Try again?", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 263f, 1547f));
			PDEAHJPOMEF().SetTexture("SetSunMinSize", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IKBJACCLPCL());
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
		FPHEBLMINDA = Resources.Load("_Value4") as Texture2D;
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
			PLBEJJIHFPB().SetFloat("y", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("VisionBlur", Fade);
			HKIMAANBGMJ().SetFloat("Set Satellite Input", Intensity);
			NJDIODJNGGA().SetFloat("_Threshold", DirectionX);
			KLKILLCHJHO().SetFloat("float,0", Speed);
			FGENHBKMPDA().SetFloat("Start", Size);
			FGENHBKMPDA().SetFloat("Items/", Distortion);
			KGOLDDBHIFN().SetFloat("deletemap", StormFlashOnOff);
			JIBOKBCPDLC().SetVector("SpectatingUserInfo", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 321f, 637f));
			FGENHBKMPDA().SetTexture(" scene view IDs from last level.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
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
			DIOAAHJDMLK().SetFloat("Jazz", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("Not sending leave operation. State is not 'Joined': ", Fade);
			EOCCJGIGEGJ().SetFloat("_Value6", Intensity);
			PLBEJJIHFPB().SetFloat("Connect() failed. Can't connect while disconnecting (still). Current state: ", DirectionX);
			EBJKJPAIAAM().SetFloat("ticket", Speed);
			KEMAALEODNH().SetFloat("[LevelEditorScene] Creating new item...", Size);
			HKIMAANBGMJ().SetFloat("[Down]", Distortion);
			KOHGPKOFEJO().SetFloat("shader.invert", StormFlashOnOff);
			OCHJIMJNEMO().SetVector("PhotonView ID duplicate found: {0}. New: {1} old: {2}. Maybe one wasn't destroyed on scene load?! Check for 'DontDestroyOnLoad'. Destroying old entry, adding new.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 814f, 1907f));
			GJHLADDCMFF().SetTexture("Beat Detected", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IKBJACCLPCL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KCCIEMBMOBA()
	{
		FPHEBLMINDA = Resources.Load("No peer to communicate with. ") as Texture2D;
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
		FPHEBLMINDA = Resources.Load("MenuScene") as Texture2D;
		SCShader = Shader.Find("threshold");
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
		FPHEBLMINDA = Resources.Load(" - ") as Texture2D;
		SCShader = Shader.Find("_Value2");
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
			KOHGPKOFEJO().SetFloat(":", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("_TimeX", Fade);
			OCHJIMJNEMO().SetFloat("</color>", Intensity);
			PLBEJJIHFPB().SetFloat("_Value4", DirectionX);
			KHCLIAMBBNC().SetFloat("_Offsets", Speed);
			NJDIODJNGGA().SetFloat("EditMenu", Size);
			NFKFAAHHLLM().SetFloat("_Value3", Distortion);
			FGENHBKMPDA().SetFloat("_TimeX", StormFlashOnOff);
			KEMAALEODNH().SetVector("1", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1143f, 1617f));
			PDEAHJPOMEF().SetTexture("OPEN", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DOKAKEMDALN()
	{
		FPHEBLMINDA = Resources.Load("OK") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack_eyes_vision_1");
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
			PLBEJJIHFPB().SetFloat("menu.playedpage", HBJJOCHGOPH);
			IKBJACCLPCL().SetFloat("_Value3", Fade);
			EOCCJGIGEGJ().SetFloat("0 - default, 1 - left, 2 - right", Intensity);
			OCHJIMJNEMO().SetFloat(".played", DirectionX);
			OCHJIMJNEMO().SetFloat("ResourceIDInputField", Speed);
			MJJIEHANFJA().SetFloat("_MainTex2", Size);
			FKEOGPDLBDD().SetFloat(".lastCheckpoint.penaltyScore", Distortion);
			LPDOGGFOBDH().SetFloat("GenerationMenu", StormFlashOnOff);
			IGKFMCPDNOI().SetVector("inventory.selected.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 785f, 187f));
			DIOAAHJDMLK().SetTexture("Operation ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CEAGPJBGBMH()
	{
		FPHEBLMINDA = Resources.Load("_Bullet_3") as Texture2D;
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
			DIOAAHJDMLK().SetFloat(". MasterClient: ", HBJJOCHGOPH);
			KLKILLCHJHO().SetFloat("_MainTex2", Fade);
			KHCLIAMBBNC().SetFloat(" not found", Intensity);
			PDEAHJPOMEF().SetFloat("_ScreenResolution", DirectionX);
			ECCPAOBFDKP().SetFloat("player.currentrank", Speed);
			MJJIEHANFJA().SetFloat("CameraFilterPack/TV_Distorted", Size);
			MJJIEHANFJA().SetFloat("May", Distortion);
			NJDIODJNGGA().SetFloat("_TimeX", StormFlashOnOff);
			JIBOKBCPDLC().SetVector("[LevelEditorScene] Error: Timeout :S", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 977f, 333f));
			HKIMAANBGMJ().SetTexture("float,1.5", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KOHGPKOFEJO());
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
			KLKILLCHJHO().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			MJJIEHANFJA().SetFloat("GlassesColor2", Fade);
			FKEOGPDLBDD().SetFloat("Preparing content", Intensity);
			KLKILLCHJHO().SetFloat("_TimeX", DirectionX);
			NFKFAAHHLLM().SetFloat("Set sun min/max size", Speed);
			OCHJIMJNEMO().SetFloat("_Value2", Size);
			FGENHBKMPDA().SetFloat("_VelocityTex", Distortion);
			EBJKJPAIAAM().SetFloat("EditMenu", StormFlashOnOff);
			EOCCJGIGEGJ().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 838f, 903f));
			KOHGPKOFEJO().SetTexture("#close", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EBJKJPAIAAM());
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
			PDEAHJPOMEF().SetFloat("_TimeX", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("_Distance", Fade);
			KGOLDDBHIFN().SetFloat("#onrankchangedowntext", Intensity);
			EOCCJGIGEGJ().SetFloat("MascotChallenge2019", DirectionX);
			NFKFAAHHLLM().SetFloat("ItemNameBGImage", Speed);
			IIJMIPBMMBF().SetFloat("_MainTex2", Size);
			HKIMAANBGMJ().SetFloat("_SphereSize", Distortion);
			EOCCJGIGEGJ().SetFloat("MultiplayerButton", StormFlashOnOff);
			NFKFAAHHLLM().SetVector("_VignetteSettings", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 362f, 54f));
			JIBOKBCPDLC().SetTexture("GameMessagesDurationSlider", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KLKILLCHJHO());
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
			JIBOKBCPDLC().SetFloat("\\n", HBJJOCHGOPH);
			MJJIEHANFJA().SetFloat(":", Fade);
			PDEAHJPOMEF().SetFloat("_TimeX", Intensity);
			OCHJIMJNEMO().SetFloat("\n", DirectionX);
			IIJMIPBMMBF().SetFloat("y", Speed);
			OCHJIMJNEMO().SetFloat("Music End", Size);
			IGKFMCPDNOI().SetFloat("_Shadow", Distortion);
			BLMPMOIDGMG().SetFloat("EndlessLoopsScoreText", StormFlashOnOff);
			EOCCJGIGEGJ().SetVector("[#clicktoacceptchallenge]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 876f, 688f));
			LPDOGGFOBDH().SetTexture("[MapsData] Bad map: ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKIMAANBGMJ());
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
			BLMPMOIDGMG().SetFloat(".icon", HBJJOCHGOPH);
			GJHLADDCMFF().SetFloat("Received RPC \"", Fade);
			KLKILLCHJHO().SetFloat("Data/Editor/leveltemplate", Intensity);
			LPDOGGFOBDH().SetFloat("Bass", DirectionX);
			EOCCJGIGEGJ().SetFloat("_Green_B", Speed);
			EBJKJPAIAAM().SetFloat("_Line", Size);
			GJHLADDCMFF().SetFloat("CameraFilterPack/Distortion_Aspiration", Distortion);
			IGKFMCPDNOI().SetFloat("_ScreenResolution", StormFlashOnOff);
			IKBJACCLPCL().SetVector("[PlayerBase] Current attempt: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1409f, 21f));
			KHCLIAMBBNC().SetTexture("DPADVER", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
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
			JIBOKBCPDLC().SetFloat("#reward: ", HBJJOCHGOPH);
			NJDIODJNGGA().SetFloat("_ScreenResolution", Fade);
			LPDOGGFOBDH().SetFloat("CameraFilterPack/Distortion_Lens", Intensity);
			BLMPMOIDGMG().SetFloat("_TimeX", DirectionX);
			FGENHBKMPDA().SetFloat("_Value", Speed);
			PDEAHJPOMEF().SetFloat("EventMenu", Size);
			KEMAALEODNH().SetFloat("_Value", Distortion);
			GJHLADDCMFF().SetFloat("_NoiseTex", StormFlashOnOff);
			FGENHBKMPDA().SetVector("IconImage", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 557f, 157f));
			NBPKMLMCHFN.SetTexture("ConnectToMaster() failed. Can only connect while in state 'Disconnected'. Current state: ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ODBNMPGBCGO()
	{
		FPHEBLMINDA = Resources.Load("Left") as Texture2D;
		SCShader = Shader.Find("_Intensity");
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
		FPHEBLMINDA = Resources.Load("_HdrParams") as Texture2D;
		SCShader = Shader.Find("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.");
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
			ECCPAOBFDKP().SetFloat("_LowRez", HBJJOCHGOPH);
			EBJKJPAIAAM().SetFloat("RB", Fade);
			BLMPMOIDGMG().SetFloat("attempted to spawn a GameObject from recycle bin (", Intensity);
			MJJIEHANFJA().SetFloat("CameraFilterPack/Distortion_Dream2", DirectionX);
			LPDOGGFOBDH().SetFloat("_Size", Speed);
			FGENHBKMPDA().SetFloat("SetParticlesParticleSpeed", Size);
			PLBEJJIHFPB().SetFloat("a year ago", Distortion);
			PDEAHJPOMEF().SetFloat("_Threshold", StormFlashOnOff);
			PDEAHJPOMEF().SetVector("<b>Speed</b>:", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 675f, 16f));
			KGOLDDBHIFN().SetTexture("_TimeX", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AKHCOBHHGJP()
	{
		FPHEBLMINDA = Resources.Load("settings.selectormapsperpage") as Texture2D;
		SCShader = Shader.Find("cameramovements:");
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
			EBJKJPAIAAM().SetFloat("return ", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("\\\"", Fade);
			KGOLDDBHIFN().SetFloat("<b>HP</b>:", Intensity);
			FKEOGPDLBDD().SetFloat("Editor/", DirectionX);
			HKIMAANBGMJ().SetFloat("AreaTex", Speed);
			FGENHBKMPDA().SetFloat("https://bitbucket.org/khb-soft/intralismarcsviewer/", Size);
			GJHLADDCMFF().SetFloat("_TempTexture", Distortion);
			KEMAALEODNH().SetFloat("sounds/hit_perfect", StormFlashOnOff);
			LPDOGGFOBDH().SetVector("settings.showHP", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1139f, 1491f));
			FKEOGPDLBDD().SetTexture("Items/", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DLBODOFAJGM()
	{
		FPHEBLMINDA = Resources.Load("_Speed") as Texture2D;
		SCShader = Shader.Find("settings.disablestoryboard");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LBAJLLFMMMP()
	{
		FPHEBLMINDA = Resources.Load("_Value2") as Texture2D;
		SCShader = Shader.Find("\n");
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
			FGENHBKMPDA().SetFloat(".", HBJJOCHGOPH);
			GJHLADDCMFF().SetFloat("_Value", Fade);
			GJHLADDCMFF().SetFloat("#tryagain", Intensity);
			DIOAAHJDMLK().SetFloat("bans.viewed.", DirectionX);
			FKEOGPDLBDD().SetFloat("_Speed", Speed);
			EBJKJPAIAAM().SetFloat("skin.hit_wrong", Size);
			LPDOGGFOBDH().SetFloat("CheckResources () for ", Distortion);
			OCHJIMJNEMO().SetFloat("_Value7", StormFlashOnOff);
			EOCCJGIGEGJ().SetVector("[SERVER] Selected map: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1194f, 543f));
			BLMPMOIDGMG().SetTexture(": ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IMCKJCHKMKB()
	{
		FPHEBLMINDA = Resources.Load("settings.gamemessagesduration") as Texture2D;
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
			FGENHBKMPDA().SetFloat("cancel", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Vignetting2", Fade);
			NFKFAAHHLLM().SetFloat("_TileTexDebug", Intensity);
			PDEAHJPOMEF().SetFloat("BitsData", DirectionX);
			NBPKMLMCHFN.SetFloat("ConfigVersionSlider", Speed);
			ECCPAOBFDKP().SetFloat("_TimeX", Size);
			HKIMAANBGMJ().SetFloat("config.txt", Distortion);
			NBPKMLMCHFN.SetFloat("SpawnObj", StormFlashOnOff);
			NBPKMLMCHFN.SetVector("Scrollbar", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 307f, 589f));
			MJJIEHANFJA().SetTexture("_Value", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF());
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
			OCHJIMJNEMO().SetFloat("ScreenResolutionPanel", HBJJOCHGOPH);
			HKIMAANBGMJ().SetFloat("LevelEditor/CustomEventEditor-Text", Fade);
			OCHJIMJNEMO().SetFloat("/", Intensity);
			KGOLDDBHIFN().SetFloat("_Value7", DirectionX);
			KGOLDDBHIFN().SetFloat("[ItemsHandler] Loading Steam inventory", Speed);
			GJHLADDCMFF().SetFloat("_Offsets", Size);
			DIOAAHJDMLK().SetFloat("_DotSize", Distortion);
			PDEAHJPOMEF().SetFloat("CameraFilterPack/Glasses_On", StormFlashOnOff);
			KOHGPKOFEJO().SetVector("no lives color", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1466f, 565f));
			IKBJACCLPCL().SetTexture("Right", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
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
		FPHEBLMINDA = Resources.Load("#") as Texture2D;
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
		FPHEBLMINDA = Resources.Load("Mouse Y") as Texture2D;
		SCShader = Shader.Find("/");
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
		FPHEBLMINDA = Resources.Load("[DiscordController] Responding yes to Ask to Join request") as Texture2D;
		SCShader = Shader.Find("[PlayerBase] SetSpeed error: ");
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
		FPHEBLMINDA = Resources.Load("SetSpeed") as Texture2D;
		SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OGJJDKENBNC()
	{
		FPHEBLMINDA = Resources.Load("_TimeX") as Texture2D;
		SCShader = Shader.Find("Case-Sensitive");
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
			KGOLDDBHIFN().SetFloat("_TimeX", HBJJOCHGOPH);
			OCHJIMJNEMO().SetFloat("CameraFilterPack/Gradients_ElectricGradient", Fade);
			EOCCJGIGEGJ().SetFloat("ConnectToMaster() failed. Can only connect while in state 'Disconnected'. Current state: ", Intensity);
			IGKFMCPDNOI().SetFloat("OnPlayerGameMessage", DirectionX);
			FKEOGPDLBDD().SetFloat("maps.", Speed);
			DIOAAHJDMLK().SetFloat("EventTimeInputField", Size);
			KEMAALEODNH().SetFloat("UseScanLine", Distortion);
			NJDIODJNGGA().SetFloat("HostType: {0} ", StormFlashOnOff);
			PLBEJJIHFPB().SetVector("Failed to 'network-remove' GameObject. Client is neither owner nor masterClient taking over for owner who left: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 726f, 1871f));
			OCHJIMJNEMO().SetTexture("Line", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IKBJACCLPCL());
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
			JIBOKBCPDLC().SetFloat("AudioSampler", HBJJOCHGOPH);
			OCHJIMJNEMO().SetFloat("float,2", Fade);
			MJJIEHANFJA().SetFloat("settings.cameramovements", Intensity);
			NFKFAAHHLLM().SetFloat("_Value2", DirectionX);
			KGOLDDBHIFN().SetFloat("_CurTex", Speed);
			OCHJIMJNEMO().SetFloat("UsernameText", Size);
			NFKFAAHHLLM().SetFloat("inventory.selected.", Distortion);
			MJJIEHANFJA().SetFloat("#91CCFF", StormFlashOnOff);
			EOCCJGIGEGJ().SetVector("LevelConfigButton", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1794f, 86f));
			LPDOGGFOBDH().SetTexture("GlassAberration", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
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
		SCShader = Shader.Find("SupportLogger Info: PUN {0}: ");
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
		FPHEBLMINDA = Resources.Load("Joystick1Button12") as Texture2D;
		SCShader = Shader.Find("Tab2Content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NLDKIPEMILC()
	{
		FPHEBLMINDA = Resources.Load("menu.hardcoreinfo") as Texture2D;
		SCShader = Shader.Find("ACCEPT");
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
		FPHEBLMINDA = Resources.Load("Unknown player asked for PickupItems") as Texture2D;
		SCShader = Shader.Find("_Value4");
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
			GJHLADDCMFF().SetFloat("JoinButton", Fade);
			JIBOKBCPDLC().SetFloat("[PlayerController] ", Intensity);
			JIBOKBCPDLC().SetFloat("_CurveParams", DirectionX);
			IGKFMCPDNOI().SetFloat("NEW_ACHIEVEMENT_1_", Speed);
			FGENHBKMPDA().SetFloat("_ColorR", Size);
			MJJIEHANFJA().SetFloat(" scene: ", Distortion);
			KGOLDDBHIFN().SetFloat("CameraFilterPack/NightVisionFX", StormFlashOnOff);
			GJHLADDCMFF().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 829f, 1708f));
			NFKFAAHHLLM().SetTexture("Error0", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			IIJMIPBMMBF().SetFloat("_BokehParams", HBJJOCHGOPH);
			OCHJIMJNEMO().SetFloat("_TimeX", Fade);
			NBPKMLMCHFN.SetFloat("settings.enableranking", Intensity);
			KGOLDDBHIFN().SetFloat("Fade", DirectionX);
			BLMPMOIDGMG().SetFloat("offsets", Speed);
			NJDIODJNGGA().SetFloat("CameraFilterPack/Edge_BlackLine", Size);
			IKBJACCLPCL().SetFloat("_Value5", Distortion);
			BLMPMOIDGMG().SetFloat("id", StormFlashOnOff);
			FGENHBKMPDA().SetVector("GlassAberration", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 19f, 1179f));
			OCHJIMJNEMO().SetTexture("NewIconFileSelector", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHLADDCMFF());
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
		FPHEBLMINDA = Resources.Load("ChangeSelectedLevel") as Texture2D;
		SCShader = Shader.Find(". ActorNr: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CCFEDENFNEF()
	{
		FPHEBLMINDA = Resources.Load("COMPLETED") as Texture2D;
		SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NNFMIAFHMJM()
	{
		FPHEBLMINDA = Resources.Load("&search=") as Texture2D;
		SCShader = Shader.Find("Parameter levelId must be int or string!");
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
		SCShader = Shader.Find("skin.hit_wrong");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EDPDMBFLHLP()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack/FX_InverChromiLum") as Texture2D;
		SCShader = Shader.Find("Vertical");
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
			DIOAAHJDMLK().SetFloat("MaxLivesSlider", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat("Editor/", Fade);
			IIJMIPBMMBF().SetFloat(").png", Intensity);
			KOHGPKOFEJO().SetFloat("CameraFilterPack/Glasses_On", DirectionX);
			FKEOGPDLBDD().SetFloat("PossibleMapPointsText", Speed);
			NJDIODJNGGA().SetFloat("CameraFilterPack/Edge_Edge_filter", Size);
			KEMAALEODNH().SetFloat(" on effect ", Distortion);
			IGKFMCPDNOI().SetFloat("_SampleScale", StormFlashOnOff);
			KHCLIAMBBNC().SetVector("https://api.steampowered.com/IInventoryService/AddItem/v001", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 601f, 765f));
			HKIMAANBGMJ().SetTexture("_TimeX", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GNJDKAECPKA()
	{
		FPHEBLMINDA = Resources.Load("_Bullet_7") as Texture2D;
		SCShader = Shader.Find("float,2");
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
			HKIMAANBGMJ().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			OCHJIMJNEMO().SetFloat("_Value2", Fade);
			MJJIEHANFJA().SetFloat("_MainTex2", Intensity);
			LPDOGGFOBDH().SetFloat("_ScreenResolution", DirectionX);
			PDEAHJPOMEF().SetFloat("_Value", Speed);
			KLKILLCHJHO().SetFloat("_CutOff", Size);
			NBPKMLMCHFN.SetFloat("_TimeX", Distortion);
			PDEAHJPOMEF().SetFloat("Default UI Material", StormFlashOnOff);
			MJJIEHANFJA().SetVector("Dec", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 445f, 238f));
			JIBOKBCPDLC().SetTexture("LoadingStatusText", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
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
