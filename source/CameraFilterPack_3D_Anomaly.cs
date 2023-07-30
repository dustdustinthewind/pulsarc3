// CameraFilterPack_3D_Anomaly
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/3D/Anomaly")]
[ExecuteInEditMode]
public class CameraFilterPack_3D_Anomaly : MonoBehaviour
{
	public Shader SCShader;

	public bool _Visualize;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 100f)]
	public float _FixDistance = 23f;

	[Range(-0.5f, 0.99f)]
	public float Anomaly_Near = 0.045f;

	[Range(0f, 1f)]
	public float Anomaly_Far = 0.11f;

	[Range(0f, 2f)]
	public float Intensity = 1f;

	[Range(0f, 1f)]
	public float AnomalyWithoutObject = 1f;

	[Range(0.1f, 1f)]
	public float Anomaly_Distortion = 0.25f;

	[Range(4f, 64f)]
	public float Anomaly_Distortion_Size = 12f;

	[Range(-4f, 8f)]
	public float Anomaly_Intensity = 2f;

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

	private void NCNPAKFAFOE()
	{
		SCShader = Shader.Find("Search: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material CIAFLBFJLEJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void FMNPFCHBLJF()
	{
		SCShader = Shader.Find(" not exist");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CGDMLHLJIDK()
	{
		SCShader = Shader.Find(".lastCheckpoint.time");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MFLBEJHMEMO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1136f)
			{
				HBJJOCHGOPH = 597f;
			}
			OJMHIMIPKME().SetFloat("[Left]", HBJJOCHGOPH);
			LPMLLJKMAMP().SetFloat("LoadMapCanvas", Intensity);
			KDMBOKLMADJ().SetFloat("[NetworkScene] Exited", Anomaly_Distortion);
			LDNADDJMIPK().SetFloat("CameraFilterPack/Broken_Screen", Anomaly_Distortion_Size);
			IIBLJCKLGFG().SetFloat("[Right]", Anomaly_Intensity);
			HKIMAANBGMJ().SetFloat("CameraFilterPack/Blur_Focus", _Visualize ? 1 : 0);
			MMOODGIODPC().SetFloat("_Value", _FixDistance);
			LDNADDJMIPK().SetFloat("SetSatelliteRotationSpeed", Anomaly_Near);
			KEMAALEODNH().SetFloat("Set satellite trail width", Anomaly_Far);
			NBPKMLMCHFN.SetFloat("FileMenu", AnomalyWithoutObject);
			LPMLLJKMAMP().SetVector("_NormalAndRoughnessTexture", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 777f, 287f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 977f)
			{
				HBJJOCHGOPH = 637f;
			}
			LONNIJMNKFB().SetFloat("Using Stopwatch as precision timer for PUN.", HBJJOCHGOPH);
			MMOODGIODPC().SetFloat("_Fade", Intensity);
			LPCHMEKDCHI().SetFloat("_Value2", Anomaly_Distortion);
			CIAFLBFJLEJ().SetFloat("maps.", Anomaly_Distortion_Size);
			NBPKMLMCHFN.SetFloat("Bass", Anomaly_Intensity);
			KBOPGONOCNP().SetFloat("_TimeX", (!_Visualize) ? 0 : 0);
			NBPKMLMCHFN.SetFloat("skin.", _FixDistance);
			LPMLLJKMAMP().SetFloat("D-Pad Up", Anomaly_Near);
			MMOODGIODPC().SetFloat("float,0", Anomaly_Far);
			NFMGLIKNOOC().SetFloat("0.00", AnomalyWithoutObject);
			KGOLDDBHIFN().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1451f, 1539f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FANADGBGCPI()
	{
		SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KLILJHJNICK()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GCHBGCGBMCK()
	{
	}

	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1398f)
			{
				HBJJOCHGOPH = 1073f;
			}
			LPCHMEKDCHI().SetFloat(": ", HBJJOCHGOPH);
			LPMLLJKMAMP().SetFloat("NEW_ACHIEVEMENT_1_", Intensity);
			NFMGLIKNOOC().SetFloat("Left Stick Click", Anomaly_Distortion);
			KBOPGONOCNP().SetFloat("NO", Anomaly_Distortion_Size);
			LPCHMEKDCHI().SetFloat("mapselector.filter.rateduponly", Anomaly_Intensity);
			MMOODGIODPC().SetFloat("Tab2Content", (!_Visualize) ? 1 : 0);
			KEMJNOMIPHN().SetFloat("X", _FixDistance);
			KEMAALEODNH().SetFloat(":\n", Anomaly_Near);
			KGOLDDBHIFN().SetFloat("shader.ghost", Anomaly_Far);
			OJMHIMIPKME().SetFloat("score", AnomalyWithoutObject);
			KBOPGONOCNP().SetVector("input", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 90f, 1711f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	[SpecialName]
	private Material LDNADDJMIPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)93;
		}
		return BJFKDHHMLJH;
	}

	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1014f)
			{
				HBJJOCHGOPH = 1243f;
			}
			LPMLLJKMAMP().SetFloat("_Near", HBJJOCHGOPH);
			LPMLLJKMAMP().SetFloat("_TimeX", Intensity);
			LONNIJMNKFB().SetFloat("note.5", Anomaly_Distortion);
			KEMJNOMIPHN().SetFloat("_Value3", Anomaly_Distortion_Size);
			KEMJNOMIPHN().SetFloat("shader.frost", Anomaly_Intensity);
			KDMBOKLMADJ().SetFloat("#ok", (!_Visualize) ? 0 : 0);
			DBOLLHHMKKN().SetFloat("_Radius", _FixDistance);
			KEMAALEODNH().SetFloat("#timeuntilend: ", Anomaly_Near);
			DBOLLHHMKKN().SetFloat("score", Anomaly_Far);
			LPCHMEKDCHI().SetFloat("a year ago", AnomalyWithoutObject);
			IIBLJCKLGFG().SetVector("_HitPointTexture", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1316f, 1817f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CIPKEPDELJB()
	{
		SCShader = Shader.Find("BadgeText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GMELGGJOPBB()
	{
	}

	private void BOLBPPHJBMI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HKIMAANBGMJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.DontSave;
		}
		return BJFKDHHMLJH;
	}

	private void IIFCIDDJHPM()
	{
	}

	[SpecialName]
	private Material KDMBOKLMADJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)97;
		}
		return BJFKDHHMLJH;
	}

	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1086f)
			{
				HBJJOCHGOPH = 1200f;
			}
			DBOLLHHMKKN().SetFloat("_Value2", HBJJOCHGOPH);
			LPCHMEKDCHI().SetFloat("[PlayerController] ", Intensity);
			MMOODGIODPC().SetFloat("settings.enablehitsoundsinnormal", Anomaly_Distortion);
			DBOLLHHMKKN().SetFloat("View ({3}){0} on {1} {2}", Anomaly_Distortion_Size);
			LPMLLJKMAMP().SetFloat("_Value2", Anomaly_Intensity);
			KBOPGONOCNP().SetFloat("PointsScoreText", (!_Visualize) ? 1 : 1);
			LPMLLJKMAMP().SetFloat("Need to specify a start index and end index.", _FixDistance);
			LPCHMEKDCHI().SetFloat("Scene", Anomaly_Near);
			CIAFLBFJLEJ().SetFloat("Encryption wasn't established: ", Anomaly_Far);
			NFMGLIKNOOC().SetFloat("/icon", AnomalyWithoutObject);
			KEMAALEODNH().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 709f, 596f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1407f)
			{
				HBJJOCHGOPH = 699f;
			}
			KGOLDDBHIFN().SetFloat("Error: you cannot read this stream that you are writing!", HBJJOCHGOPH);
			CIAFLBFJLEJ().SetFloat("_Value3", Intensity);
			DBOLLHHMKKN().SetFloat("_Value2", Anomaly_Distortion);
			MMOODGIODPC().SetFloat("LoadPlayerEnvironment", Anomaly_Distortion_Size);
			NFMGLIKNOOC().SetFloat("1", Anomaly_Intensity);
			LONNIJMNKFB().SetFloat("_ScreenResolution", (!_Visualize) ? 1 : 1);
			DBOLLHHMKKN().SetFloat("_InvScreenSize", _FixDistance);
			KGOLDDBHIFN().SetFloat("_ScreenResolution", Anomaly_Near);
			MMOODGIODPC().SetFloat("StartButton", Anomaly_Far);
			KDMBOKLMADJ().SetFloat("time", AnomalyWithoutObject);
			OJMHIMIPKME().SetVector("set", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1903f, 1410f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JLNNHKPHMAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KCCIEMBMOBA()
	{
		SCShader = Shader.Find("'{0}' \t{1}ms \t{2}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ODGMCJILIHF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material KEMAALEODNH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material LPMLLJKMAMP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
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
	private Material MMOODGIODPC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	private void NNFMIAFHMJM()
	{
		SCShader = Shader.Find("13");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FHGKIOOMMOH()
	{
		SCShader = Shader.Find("Waiting to start");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1797f)
			{
				HBJJOCHGOPH = 1156f;
			}
			IIBLJCKLGFG().SetFloat("_Value3", HBJJOCHGOPH);
			LPCHMEKDCHI().SetFloat("ResetButton", Intensity);
			LPMLLJKMAMP().SetFloat("_ScreenResolution", Anomaly_Distortion);
			LONNIJMNKFB().SetFloat("_Offsets", Anomaly_Distortion_Size);
			NBPKMLMCHFN.SetFloat(" ", Anomaly_Intensity);
			CIAFLBFJLEJ().SetFloat("AudioSampler", (!_Visualize) ? 0 : 0);
			LPCHMEKDCHI().SetFloat("Set Satellite Sensitivity", _FixDistance);
			KEMAALEODNH().SetFloat("r", Anomaly_Near);
			CIAFLBFJLEJ().SetFloat("_FarCamera", Anomaly_Far);
			NBPKMLMCHFN.SetFloat("yyyy", AnomalyWithoutObject);
			NFMGLIKNOOC().SetVector("player.deleted", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1952f, 1130f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DFENCIHAADO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material DBOLLHHMKKN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)79;
		}
		return BJFKDHHMLJH;
	}

	private void PKBENONAOOL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FMFNILJIEIA()
	{
		SCShader = Shader.Find("_Distance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MGFFNGEGFDC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EPEGAEGDJAM()
	{
		SCShader = Shader.Find(": ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 528f)
			{
				HBJJOCHGOPH = 863f;
			}
			LONNIJMNKFB().SetFloat("SUBMIT '{0}' FILES", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("CameraFilterPack/EXTRA_SHOWFPS", Intensity);
			LPMLLJKMAMP().SetFloat("_TimeX", Anomaly_Distortion);
			LPCHMEKDCHI().SetFloat("downloading", Anomaly_Distortion_Size);
			LPCHMEKDCHI().SetFloat("/?page=ranks", Anomaly_Intensity);
			KBOPGONOCNP().SetFloat("Bad parameters for set! Use <language>", (!_Visualize) ? 0 : 0);
			KDMBOKLMADJ().SetFloat("DPADVER", _FixDistance);
			MMOODGIODPC().SetFloat("_EmissionGain", Anomaly_Near);
			OJMHIMIPKME().SetFloat("_LensDirtIntensity", Anomaly_Far);
			NFMGLIKNOOC().SetFloat("_Value4", AnomalyWithoutObject);
			KBOPGONOCNP().SetVector("JoinOrCreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 435f, 1479f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void KOJKBFDNGDK()
	{
		SCShader = Shader.Find("CameraFilterPack/3D_BlackHole");
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-99);
		}
		return BJFKDHHMLJH;
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/3D_Anomaly");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NEKCPLGFOFD()
	{
	}

	private void IKMELABKBHO()
	{
	}

	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 873f)
			{
				HBJJOCHGOPH = 30f;
			}
			LONNIJMNKFB().SetFloat("gold", HBJJOCHGOPH);
			LPCHMEKDCHI().SetFloat("value", Intensity);
			LDNADDJMIPK().SetFloat("SetSunEmission", Anomaly_Distortion);
			NBPKMLMCHFN.SetFloat("_Value", Anomaly_Distortion_Size);
			IIBLJCKLGFG().SetFloat("_MainTex", Anomaly_Intensity);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", (!_Visualize) ? 1 : 0);
			CIAFLBFJLEJ().SetFloat("PlayButton", _FixDistance);
			LDNADDJMIPK().SetFloat("CameraFilterPack/TV_MovieNoise", Anomaly_Near);
			KGOLDDBHIFN().SetFloat("CameraMovementSlider", Anomaly_Far);
			MMOODGIODPC().SetFloat("Preparing content", AnomalyWithoutObject);
			IIBLJCKLGFG().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1988f, 640f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FABKIGNFECE()
	{
	}

	private void FODKODGPPDA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BGDONBMDPGM()
	{
	}

	private void AGMJDGHLBMN()
	{
	}

	private void HLLHJIDOOGA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material KGOLDDBHIFN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void GFACKFCEIBC()
	{
	}

	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1699f)
			{
				HBJJOCHGOPH = 1565f;
			}
			IIBLJCKLGFG().SetFloat("LowMid", HBJJOCHGOPH);
			OJMHIMIPKME().SetFloat("_AdaptionSpeed", Intensity);
			IIBLJCKLGFG().SetFloat(" not exist", Anomaly_Distortion);
			LONNIJMNKFB().SetFloat(" not exist", Anomaly_Distortion_Size);
			LPCHMEKDCHI().SetFloat("CameraFilterPack_VHS2", Anomaly_Intensity);
			LPMLLJKMAMP().SetFloat("#E14FFF", _Visualize ? 1 : 0);
			KDMBOKLMADJ().SetFloat("maps.", _FixDistance);
			LDNADDJMIPK().SetFloat("#accuracy", Anomaly_Near);
			KGOLDDBHIFN().SetFloat("_History3LumaTex", Anomaly_Far);
			NFMGLIKNOOC().SetFloat("settings.cameramovements", AnomalyWithoutObject);
			CIAFLBFJLEJ().SetVector("UsernameText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 310f, 1452f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FKDEEJFNNJC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FDNONDCGGCG()
	{
		SCShader = Shader.Find("z");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material LPCHMEKDCHI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-126);
		}
		return BJFKDHHMLJH;
	}

	private void IABLKKAALGI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DFFKKLAPHCC()
	{
		SCShader = Shader.Find("#failed!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material OJMHIMIPKME()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void PMPKMGKAAJH()
	{
		SCShader = Shader.Find(", ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HGDDCINLDAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EKCDEFDELMP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FIKFJDFELIP()
	{
		SCShader = Shader.Find("_Axis");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JHANGPCOCIG()
	{
		SCShader = Shader.Find("Set Object Position");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ONPFGCEFMML()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MDCFIHDPLIG()
	{
	}

	private void BFEILOMHNPC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OIBMHPIFAKK()
	{
	}

	private void DBEMDAJDDDA()
	{
		SCShader = Shader.Find("VoteDownToggle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1791f)
			{
				HBJJOCHGOPH = 30f;
			}
			KDMBOKLMADJ().SetFloat("mapselector.filter.subscribedonly", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("PerfectHitsScoreText", Intensity);
			CIAFLBFJLEJ().SetFloat("Object ID. Case-Sensitive", Anomaly_Distortion);
			KDMBOKLMADJ().SetFloat("menutheme", Anomaly_Distortion_Size);
			OJMHIMIPKME().SetFloat("_ScreenResolution", Anomaly_Intensity);
			OJMHIMIPKME().SetFloat("CameraFilterPack/OldFilm_Cutting2", (!_Visualize) ? 1 : 1);
			KBOPGONOCNP().SetFloat("CameraFilterPack/Blend2Camera_Subtract", _FixDistance);
			HKIMAANBGMJ().SetFloat("gameVolume", Anomaly_Near);
			KDMBOKLMADJ().SetFloat("Joystick1Button4", Anomaly_Far);
			LDNADDJMIPK().SetFloat("inventory.selected.", AnomalyWithoutObject);
			DBOLLHHMKKN().SetVector("_Value5", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1948f, 1469f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1222f)
			{
				HBJJOCHGOPH = 1900f;
			}
			DBOLLHHMKKN().SetFloat("StopMusic", HBJJOCHGOPH);
			MMOODGIODPC().SetFloat("_Red_C", Intensity);
			KGOLDDBHIFN().SetFloat("OpLeaveLobby()", Anomaly_Distortion);
			KEMJNOMIPHN().SetFloat("masterSteamID", Anomaly_Distortion_Size);
			CIAFLBFJLEJ().SetFloat("_AllowBackwardsRays", Anomaly_Intensity);
			CIAFLBFJLEJ().SetFloat("VIGNETTE_FILMIC", (!_Visualize) ? 0 : 0);
			MMOODGIODPC().SetFloat("_Value5", _FixDistance);
			NBPKMLMCHFN.SetFloat("{0:x2}", Anomaly_Near);
			KEMAALEODNH().SetFloat("image", Anomaly_Far);
			OJMHIMIPKME().SetFloat("_TimeX", AnomalyWithoutObject);
			NFMGLIKNOOC().SetVector("_DotSize", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 803f, 506f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GPNAOAKCMHC()
	{
		SCShader = Shader.Find("OnSerialize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GKNKIIEALCH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EJJEDJIOFAB()
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

	private void IMGGCJICLHK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EDCMIPNCPLB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 135f)
			{
				HBJJOCHGOPH = 1513f;
			}
			KEMAALEODNH().SetFloat("_Y", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("_Glitch", Intensity);
			CIAFLBFJLEJ().SetFloat("CheckpointsScoreText", Anomaly_Distortion);
			HKIMAANBGMJ().SetFloat("menu.selectedplaymode", Anomaly_Distortion_Size);
			MMOODGIODPC().SetFloat("[PlayerBase] Starting game from: ", Anomaly_Intensity);
			CIAFLBFJLEJ().SetFloat("CameraFilterPack/Blend2Camera_Subtract", (!_Visualize) ? 1 : 1);
			KBOPGONOCNP().SetFloat("HitVariationSlider", _FixDistance);
			LPCHMEKDCHI().SetFloat("player.russia", Anomaly_Near);
			OJMHIMIPKME().SetFloat("Month_", Anomaly_Far);
			LONNIJMNKFB().SetFloat("[NetworkManager] Connection failed: ", AnomalyWithoutObject);
			KEMAALEODNH().SetVector("VIGNETTE_DESAT", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1267f, 1539f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KDMBOKLMADJ());
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
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LMADKINICIN()
	{
	}

	private void ALMGMOOHLMA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1756f)
			{
				HBJJOCHGOPH = 196f;
			}
			HKIMAANBGMJ().SetFloat("_Offsets", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("RarityImage", Intensity);
			LONNIJMNKFB().SetFloat("_TintColor", Anomaly_Distortion);
			KEMAALEODNH().SetFloat("ticket", Anomaly_Distortion_Size);
			OJMHIMIPKME().SetFloat("</color>", Anomaly_Intensity);
			LPMLLJKMAMP().SetFloat("Preparing content", _Visualize ? 1 : 0);
			KBOPGONOCNP().SetFloat("_Green_R", _FixDistance);
			OJMHIMIPKME().SetFloat("_TimeX", Anomaly_Near);
			KEMAALEODNH().SetFloat("_Bullet_8", Anomaly_Far);
			DBOLLHHMKKN().SetFloat("icon_border", AnomalyWithoutObject);
			HKIMAANBGMJ().SetVector("JoystickButton13", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1554f, 540f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OJMHIMIPKME());
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
			if (HBJJOCHGOPH > 619f)
			{
				HBJJOCHGOPH = 1971f;
			}
			DBOLLHHMKKN().SetFloat("_TimeX", HBJJOCHGOPH);
			LPCHMEKDCHI().SetFloat("ItemNameText", Intensity);
			LDNADDJMIPK().SetFloat("_SizeX", Anomaly_Distortion);
			NBPKMLMCHFN.SetFloat("MouseX", Anomaly_Distortion_Size);
			CIAFLBFJLEJ().SetFloat("MenuVolumeSlider", Anomaly_Intensity);
			NBPKMLMCHFN.SetFloat("_TimeX", _Visualize ? 1 : 0);
			LONNIJMNKFB().SetFloat("CameraFilterPack/Vision_Psycho", _FixDistance);
			DBOLLHHMKKN().SetFloat("_Value2", Anomaly_Near);
			LPCHMEKDCHI().SetFloat("_ScreenResolution", Anomaly_Far);
			DBOLLHHMKKN().SetFloat("0.00", AnomalyWithoutObject);
			OJMHIMIPKME().SetVector("_Distortion", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1807f, 1165f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material IIBLJCKLGFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)81;
		}
		return BJFKDHHMLJH;
	}

	private void NAOLAJPDGIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 301f)
			{
				HBJJOCHGOPH = 1112f;
			}
			KDMBOKLMADJ().SetFloat("_Value", HBJJOCHGOPH);
			IIBLJCKLGFG().SetFloat("http://steamcommunity.com/sharedfiles/filedetails/?id=", Intensity);
			DBOLLHHMKKN().SetFloat("PossibleMapMaxScoreText", Anomaly_Distortion);
			KEMAALEODNH().SetFloat("/icon", Anomaly_Distortion_Size);
			DBOLLHHMKKN().SetFloat("Updated!", Anomaly_Intensity);
			LDNADDJMIPK().SetFloat("SetSunMaxSize", _Visualize ? 1 : 0);
			LPMLLJKMAMP().SetFloat("System.Boolean", _FixDistance);
			IIBLJCKLGFG().SetFloat("_ChangeRed", Anomaly_Near);
			HKIMAANBGMJ().SetFloat("ItemsCountText", Anomaly_Far);
			OJMHIMIPKME().SetFloat("_Value2", AnomalyWithoutObject);
			DBOLLHHMKKN().SetVector("_MainTex2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1565f, 1504f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material NFMGLIKNOOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void LIBGAKMKHJJ()
	{
		SCShader = Shader.Find("move");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GJAJBMGGPFB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 777f)
			{
				HBJJOCHGOPH = 1644f;
			}
			LPCHMEKDCHI().SetFloat("_Parasite", HBJJOCHGOPH);
			CIAFLBFJLEJ().SetFloat("Can't execute Disconnect() while not connected. Nothing changed. State: {0}", Intensity);
			OJMHIMIPKME().SetFloat("_TimeX", Anomaly_Distortion);
			CIAFLBFJLEJ().SetFloat("curScn", Anomaly_Distortion_Size);
			IIBLJCKLGFG().SetFloat("[PlayerController] ", Anomaly_Intensity);
			LONNIJMNKFB().SetFloat("rd", (!_Visualize) ? 1 : 0);
			DBOLLHHMKKN().SetFloat("Description goes here", _FixDistance);
			LONNIJMNKFB().SetFloat(": ", Anomaly_Near);
			NFMGLIKNOOC().SetFloat("11", Anomaly_Far);
			DBOLLHHMKKN().SetFloat(".status", AnomalyWithoutObject);
			KEMAALEODNH().SetVector("CameraFilterPack/Colors_BleachBypass", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 965f, 1566f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1022f)
			{
				HBJJOCHGOPH = 1709f;
			}
			KEMAALEODNH().SetFloat("StartButton", HBJJOCHGOPH);
			LDNADDJMIPK().SetFloat("BitsData", Intensity);
			KBOPGONOCNP().SetFloat("-1", Anomaly_Distortion);
			LDNADDJMIPK().SetFloat("settings.fps", Anomaly_Distortion_Size);
			LDNADDJMIPK().SetFloat("EnvironmentSlider", Anomaly_Intensity);
			LPMLLJKMAMP().SetFloat("Text", (!_Visualize) ? 0 : 0);
			LDNADDJMIPK().SetFloat("AccuracyScoreText", _FixDistance);
			IIBLJCKLGFG().SetFloat("_Bullet_2", Anomaly_Near);
			KGOLDDBHIFN().SetFloat("Start index must in an integer.", Anomaly_Far);
			DBOLLHHMKKN().SetFloat("IconImage", AnomalyWithoutObject);
			CIAFLBFJLEJ().SetVector("<color=#{0}>{1}</color>", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1425f, 1763f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KOFAMEKHHGD()
	{
		SCShader = Shader.Find("Set sun min/max size");
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
			NBPKMLMCHFN.SetFloat("_Value2", Intensity);
			NBPKMLMCHFN.SetFloat("Anomaly_Distortion", Anomaly_Distortion);
			NBPKMLMCHFN.SetFloat("Anomaly_Distortion_Size", Anomaly_Distortion_Size);
			NBPKMLMCHFN.SetFloat("Anomaly_Intensity", Anomaly_Intensity);
			NBPKMLMCHFN.SetFloat("_Visualize", _Visualize ? 1 : 0);
			NBPKMLMCHFN.SetFloat("_FixDistance", _FixDistance);
			NBPKMLMCHFN.SetFloat("Anomaly_Near", Anomaly_Near);
			NBPKMLMCHFN.SetFloat("Anomaly_Far", Anomaly_Far);
			NBPKMLMCHFN.SetFloat("Anomaly_With_Obj", AnomalyWithoutObject);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material KEMJNOMIPHN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void POJFHDFJOPE()
	{
	}

	private void NNBCLMJGFEN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NDAJBJFJGCF()
	{
	}

	private void LMBDNPLDGIJ()
	{
	}

	private void IDIIELPAMCJ()
	{
	}

	private void LCJHDLKJEOM()
	{
	}

	private void FJIKDJAMOHA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1058f)
			{
				HBJJOCHGOPH = 1475f;
			}
			NFMGLIKNOOC().SetFloat("JoinOrCreateRoom failed. In offline mode you still have to leave a room to enter another.", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("seconds", Intensity);
			LPCHMEKDCHI().SetFloat("_Distortion", Anomaly_Distortion);
			KEMJNOMIPHN().SetFloat("A", Anomaly_Distortion_Size);
			KBOPGONOCNP().SetFloat("OnJoinedRoom() called by PUN. Now this client is in a room. From here on, your game would be running. For reference, all callbacks are listed in enum: PhotonNetworkingMessage", Anomaly_Intensity);
			DBOLLHHMKKN().SetFloat("_GreenAmplifier", (!_Visualize) ? 1 : 1);
			NBPKMLMCHFN.SetFloat("...", _FixDistance);
			LPMLLJKMAMP().SetFloat("_Value", Anomaly_Near);
			LDNADDJMIPK().SetFloat("CameraFilterPack/Colors_Adjust_PreFilters", Anomaly_Far);
			LPMLLJKMAMP().SetFloat("CameraFilterPack/Color_Sepia", AnomalyWithoutObject);
			NBPKMLMCHFN.SetVector("_Params2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 786f, 189f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EAHCLIEEJOG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}
}
