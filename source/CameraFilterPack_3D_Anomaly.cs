// CameraFilterPack_3D_Anomaly
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/3D/Anomaly")]
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
		SCShader = Shader.Find("&map=");
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
		SCShader = Shader.Find("[PlayerController] ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CGDMLHLJIDK()
	{
		SCShader = Shader.Find("SetPlayerDistance");
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
			KGOLDDBHIFN().SetFloat("[PlayerBase] Starting new round", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("LoadMapCanvas", Intensity);
			KEMAALEODNH().SetFloat("PlayersScrollRectContent", Anomaly_Distortion);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Broken_Screen", Anomaly_Distortion_Size);
			KDMBOKLMADJ().SetFloat("SpawnObj", Anomaly_Intensity);
			IIBLJCKLGFG().SetFloat("CameraFilterPack/Blur_Focus", _Visualize ? 1 : 0);
			NBPKMLMCHFN.SetFloat("_Value2", _FixDistance);
			KEMJNOMIPHN().SetFloat("SetSatelliteTrailLength", Anomaly_Near);
			MMOODGIODPC().SetFloat("SetSatelliteTrailMinVertexDistance", Anomaly_Far);
			IIBLJCKLGFG().SetFloat("FileMenu", AnomalyWithoutObject);
			KEMAALEODNH().SetVector("_ReflectionTexture0", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 777f, 287f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
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
			LPCHMEKDCHI().SetFloat("Can't start OFFLINE mode while connected!", HBJJOCHGOPH);
			KBOPGONOCNP().SetFloat("_ScreenResolution", Intensity);
			CIAFLBFJLEJ().SetFloat("_ScreenResolution", Anomaly_Distortion);
			LDNADDJMIPK().SetFloat("[MapData] Map timing update from: ", Anomaly_Distortion_Size);
			KEMJNOMIPHN().SetFloat("Bass", Anomaly_Intensity);
			NFMGLIKNOOC().SetFloat("UseFinalGlassColor", (!_Visualize) ? 0 : 0);
			KEMJNOMIPHN().SetFloat(".icon", _FixDistance);
			LONNIJMNKFB().SetFloat("D-Pad Down", Anomaly_Near);
			LDNADDJMIPK().SetFloat("y", Anomaly_Far);
			KDMBOKLMADJ().SetFloat("0.00", AnomalyWithoutObject);
			KBOPGONOCNP().SetVector("_Value4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1451f, 1539f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPCHMEKDCHI());
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
		SCShader = Shader.Find("_Fade");
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
			CIAFLBFJLEJ().SetFloat(" not exist", HBJJOCHGOPH);
			IIBLJCKLGFG().SetFloat("NEW_ACHIEVEMENT_1_", Intensity);
			KDMBOKLMADJ().SetFloat("Right Stick Click", Anomaly_Distortion);
			KEMAALEODNH().SetFloat("NO", Anomaly_Distortion_Size);
			LDNADDJMIPK().SetFloat("mapselector.filter.rateduponly", Anomaly_Intensity);
			NFMGLIKNOOC().SetFloat("Tab2Content", (!_Visualize) ? 1 : 0);
			KEMAALEODNH().SetFloat(" ", _FixDistance);
			LDNADDJMIPK().SetFloat(" ", Anomaly_Near);
			HKIMAANBGMJ().SetFloat("shader.future", Anomaly_Far);
			KGOLDDBHIFN().SetFloat("team", AnomalyWithoutObject);
			LONNIJMNKFB().SetVector("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 90f, 1711f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
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
			KGOLDDBHIFN().SetFloat("_Near", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value", Intensity);
			OJMHIMIPKME().SetFloat("note.7", Anomaly_Distortion);
			LONNIJMNKFB().SetFloat("_Value3", Anomaly_Distortion_Size);
			LPCHMEKDCHI().SetFloat("shader.pixel", Anomaly_Intensity);
			KGOLDDBHIFN().SetFloat("#alreadyexist", (!_Visualize) ? 0 : 0);
			KGOLDDBHIFN().SetFloat("_Quality", _FixDistance);
			LPCHMEKDCHI().SetFloat("#getrewardnow ", Anomaly_Near);
			LPCHMEKDCHI().SetFloat(". Not connectedAndReady.", Anomaly_Far);
			KBOPGONOCNP().SetFloat("a year ago", AnomalyWithoutObject);
			LPCHMEKDCHI().SetVector("_ReflectionTexture1", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1316f, 1817f));
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
			KBOPGONOCNP().SetFloat("_Value3", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat(": ", Intensity);
			OJMHIMIPKME().SetFloat("settings.selectormapsperpage", Anomaly_Distortion);
			LPMLLJKMAMP().SetFloat("(scene)", Anomaly_Distortion_Size);
			LPCHMEKDCHI().SetFloat("_Value3", Anomaly_Intensity);
			DBOLLHHMKKN().SetFloat("0.00", (!_Visualize) ? 1 : 1);
			KEMJNOMIPHN().SetFloat("End index must in an integer.", _FixDistance);
			HKIMAANBGMJ().SetFloat("Scene", Anomaly_Near);
			LPCHMEKDCHI().SetFloat("Exception while connecting to: ", Anomaly_Far);
			CIAFLBFJLEJ().SetFloat("/icon", AnomalyWithoutObject);
			IIBLJCKLGFG().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 709f, 596f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
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
			NBPKMLMCHFN.SetFloat("{0}={2}: {1} \"{3}\"", HBJJOCHGOPH);
			IIBLJCKLGFG().SetFloat("_Value4", Intensity);
			CIAFLBFJLEJ().SetFloat("_Distortion", Anomaly_Distortion);
			KEMAALEODNH().SetFloat(".lastCheckpoint.time", Anomaly_Distortion_Size);
			LDNADDJMIPK().SetFloat("2", Anomaly_Intensity);
			OJMHIMIPKME().SetFloat("Texture2", (!_Visualize) ? 1 : 1);
			CIAFLBFJLEJ().SetFloat("_CameraClipInfo", _FixDistance);
			LPMLLJKMAMP().SetFloat("_ScreenResolution", Anomaly_Near);
			LPCHMEKDCHI().SetFloat("StartButton", Anomaly_Far);
			KDMBOKLMADJ().SetFloat("[CraftingPanel] Init", AnomalyWithoutObject);
			KEMAALEODNH().SetVector("keys", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1903f, 1410f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
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
		SCShader = Shader.Find("ServerSettings: ");
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
		SCShader = Shader.Find("th");
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
			LDNADDJMIPK().SetFloat("_Value4", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat("finished", Intensity);
			NFMGLIKNOOC().SetFloat("CameraFilterPack/Distortion_ShockWave", Anomaly_Distortion);
			MMOODGIODPC().SetFloat("_Offsets", Anomaly_Distortion_Size);
			LPMLLJKMAMP().SetFloat("Skipping region because it's not in PhotonServerSettings.EnabledRegions: ", Anomaly_Intensity);
			LPMLLJKMAMP().SetFloat("VoteDownToggle", (!_Visualize) ? 0 : 0);
			DBOLLHHMKKN().SetFloat("id", _FixDistance);
			KEMAALEODNH().SetFloat("b", Anomaly_Near);
			NFMGLIKNOOC().SetFloat("_ScreenResolution", Anomaly_Far);
			NFMGLIKNOOC().SetFloat("Jan", AnomalyWithoutObject);
			NBPKMLMCHFN.SetVector("menutheme.idunno", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1952f, 1130f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
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
		SCShader = Shader.Find("_ScreenResolution");
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
		SCShader = Shader.Find("\n");
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
			HKIMAANBGMJ().SetFloat("*.workshop.json", HBJJOCHGOPH);
			CIAFLBFJLEJ().SetFloat("CameraFilterPack/EXTRA_SHOWFPS", Intensity);
			OJMHIMIPKME().SetFloat("_Amount", Anomaly_Distortion);
			KEMAALEODNH().SetFloat("downloading", Anomaly_Distortion_Size);
			LPCHMEKDCHI().SetFloat("/?page=ranks", Anomaly_Intensity);
			LDNADDJMIPK().SetFloat("Bad parameters for set! Use <language>", (!_Visualize) ? 0 : 0);
			IIBLJCKLGFG().SetFloat("DPADVER", _FixDistance);
			KEMJNOMIPHN().SetFloat("[PlayerBase] Reset", Anomaly_Near);
			KEMAALEODNH().SetFloat("_BlurSize", Anomaly_Far);
			LPMLLJKMAMP().SetFloat("_ScreenResolution", AnomalyWithoutObject);
			KEMAALEODNH().SetVector("offline room", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 435f, 1479f));
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
			LPCHMEKDCHI().SetFloat("red", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("value", Intensity);
			LPMLLJKMAMP().SetFloat("Set Sun Emission", Anomaly_Distortion);
			LONNIJMNKFB().SetFloat("_Value", Anomaly_Distortion_Size);
			LPCHMEKDCHI().SetFloat("#{0:X2}{1:X2}{2:X2}", Anomaly_Intensity);
			OJMHIMIPKME().SetFloat("CameraFilterPack/Blur_DitherOffset", (!_Visualize) ? 1 : 0);
			HKIMAANBGMJ().SetFloat("  |  ", _FixDistance);
			NBPKMLMCHFN.SetFloat("_Fade", Anomaly_Near);
			KGOLDDBHIFN().SetFloat("CameraMovementSlider", Anomaly_Far);
			KEMJNOMIPHN().SetFloat("Preparing configuration", AnomalyWithoutObject);
			IIBLJCKLGFG().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1988f, 640f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
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
			MMOODGIODPC().SetFloat("LowMid", HBJJOCHGOPH);
			MMOODGIODPC().SetFloat("_SmallTex", Intensity);
			KEMAALEODNH().SetFloat("[PlayerBase] Unknown event: ", Anomaly_Distortion);
			MMOODGIODPC().SetFloat("[PlayerController] ", Anomaly_Distortion_Size);
			KEMJNOMIPHN().SetFloat("VHS2", Anomaly_Intensity);
			LPCHMEKDCHI().SetFloat("#FFDA44", _Visualize ? 1 : 0);
			MMOODGIODPC().SetFloat("maps.", _FixDistance);
			NBPKMLMCHFN.SetFloat("#highscore", Anomaly_Near);
			MMOODGIODPC().SetFloat("_History1ChromaTex", Anomaly_Far);
			IIBLJCKLGFG().SetFloat("CrosshairOpacitySlider", AnomalyWithoutObject);
			CIAFLBFJLEJ().SetVector("UsernameText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 310f, 1452f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
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
		SCShader = Shader.Find("ICollection");
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
		SCShader = Shader.Find("Committing changes...");
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
		SCShader = Shader.Find("0 seconds");
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
		SCShader = Shader.Find("Curve texture");
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
		SCShader = Shader.Find("MenuScene");
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
			KEMAALEODNH().SetFloat("mapselector.filter.subscribedonly", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("PerfectHitsScoreText", Intensity);
			KDMBOKLMADJ().SetFloat("value", Anomaly_Distortion);
			KEMJNOMIPHN().SetFloat("/", Anomaly_Distortion_Size);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", Anomaly_Intensity);
			MMOODGIODPC().SetFloat("_Value", (!_Visualize) ? 1 : 1);
			KGOLDDBHIFN().SetFloat("CameraFilterPack/Blend2Camera_Subtract", _FixDistance);
			KBOPGONOCNP().SetFloat("menuVolume", Anomaly_Near);
			NBPKMLMCHFN.SetFloat("Joystick1Button5", Anomaly_Far);
			LPMLLJKMAMP().SetFloat("Items/", AnomalyWithoutObject);
			KEMAALEODNH().SetVector("_Value5", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1948f, 1469f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
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
			LPMLLJKMAMP().SetFloat("return CheckCondition()", HBJJOCHGOPH);
			KDMBOKLMADJ().SetFloat("_Green_C", Intensity);
			KDMBOKLMADJ().SetFloat("OpJoinRoom()", Anomaly_Distortion);
			LDNADDJMIPK().SetFloat("masterSteamID", Anomaly_Distortion_Size);
			LONNIJMNKFB().SetFloat("_MaxSteps", Anomaly_Intensity);
			NBPKMLMCHFN.SetFloat("Hidden/Image Effects/Cinematic/MotionBlur/Reconstruction", (!_Visualize) ? 0 : 0);
			HKIMAANBGMJ().SetFloat("_ScreenResolution", _FixDistance);
			LDNADDJMIPK().SetFloat(" - GameWebCallback] - ", Anomaly_Near);
			KDMBOKLMADJ().SetFloat("image", Anomaly_Far);
			MMOODGIODPC().SetFloat("UseFinalGlassColor", AnomalyWithoutObject);
			KEMAALEODNH().SetVector("CameraFilterPack/Drawing_Manga_Color", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 803f, 506f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GPNAOAKCMHC()
	{
		SCShader = Shader.Find("saveGameName ");
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
			MMOODGIODPC().SetFloat("_Y", HBJJOCHGOPH);
			KEMJNOMIPHN().SetFloat("_Noise", Intensity);
			IIBLJCKLGFG().SetFloat("EndlessLoopsScoreText", Anomaly_Distortion);
			CIAFLBFJLEJ().SetFloat("#score", Anomaly_Distortion_Size);
			LPCHMEKDCHI().SetFloat("SpawnObj", Anomaly_Intensity);
			KGOLDDBHIFN().SetFloat("CameraFilterPack/Blend2Camera_Divide", (!_Visualize) ? 1 : 1);
			LONNIJMNKFB().SetFloat("settings.hitvariation", _FixDistance);
			DBOLLHHMKKN().SetFloat("ticket.ticket1", Anomaly_Near);
			LDNADDJMIPK().SetFloat("11", Anomaly_Far);
			CIAFLBFJLEJ().SetFloat("[NetworkManager] Connection failed: ", AnomalyWithoutObject);
			NFMGLIKNOOC().SetVector("_VignetteCenter", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1267f, 1539f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPCHMEKDCHI());
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
			LDNADDJMIPK().SetFloat("_Offsets", HBJJOCHGOPH);
			IIBLJCKLGFG().SetFloat("\n\n• ", Intensity);
			KBOPGONOCNP().SetFloat("_Saturation", Anomaly_Distortion);
			KGOLDDBHIFN().SetFloat("LevelEditor/CustomEventEditor-Text", Anomaly_Distortion_Size);
			KGOLDDBHIFN().SetFloat(">", Anomaly_Intensity);
			LPMLLJKMAMP().SetFloat("Preparing content", _Visualize ? 1 : 0);
			KBOPGONOCNP().SetFloat("_Green_G", _FixDistance);
			LONNIJMNKFB().SetFloat("_TimeX", Anomaly_Near);
			HKIMAANBGMJ().SetFloat("_Bullet_10", Anomaly_Far);
			HKIMAANBGMJ().SetFloat("gold", AnomalyWithoutObject);
			NBPKMLMCHFN.SetVector("Trackpad", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1554f, 540f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			KBOPGONOCNP().SetFloat("_Value", HBJJOCHGOPH);
			MMOODGIODPC().SetFloat(":\n", Intensity);
			HKIMAANBGMJ().SetFloat("_SizeX", Anomaly_Distortion);
			KGOLDDBHIFN().SetFloat("Right", Anomaly_Distortion_Size);
			CIAFLBFJLEJ().SetFloat("Scene", Anomaly_Intensity);
			HKIMAANBGMJ().SetFloat("_TimeX", _Visualize ? 1 : 0);
			CIAFLBFJLEJ().SetFloat("_TimeX", _FixDistance);
			KDMBOKLMADJ().SetFloat("_Value2", Anomaly_Near);
			LDNADDJMIPK().SetFloat("CameraFilterPack/Color_Contrast", Anomaly_Far);
			KEMJNOMIPHN().SetFloat("-help", AnomalyWithoutObject);
			LONNIJMNKFB().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1807f, 1165f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
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
			NBPKMLMCHFN.SetFloat("_Value2", HBJJOCHGOPH);
			MMOODGIODPC().SetFloat("DifficultyBG", Intensity);
			LPMLLJKMAMP().SetFloat("PossibleMapMaxScoreText", Anomaly_Distortion);
			CIAFLBFJLEJ().SetFloat("/icon", Anomaly_Distortion_Size);
			KDMBOKLMADJ().SetFloat("OK", Anomaly_Intensity);
			NBPKMLMCHFN.SetFloat("Set Sun MaxSize", _Visualize ? 1 : 0);
			LPMLLJKMAMP().SetFloat("System.Single", _FixDistance);
			IIBLJCKLGFG().SetFloat("_ChangeGreen", Anomaly_Near);
			NBPKMLMCHFN.SetFloat("ItemNameText", Anomaly_Far);
			LONNIJMNKFB().SetFloat("_ScreenResolution", AnomalyWithoutObject);
			OJMHIMIPKME().SetVector("CameraFilterPack/Glow_Glow_Color", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1565f, 1504f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
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
		SCShader = Shader.Find("TStart");
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
			LPCHMEKDCHI().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("It seems some instantiation is not completed, as instantiation data is used. You should make sure instantiations are paused when calling this method. Cleaning now, despite this.", Intensity);
			KDMBOKLMADJ().SetFloat("_TimeX", Anomaly_Distortion);
			LPMLLJKMAMP().SetFloat("Parameter levelId must be int or string!", Anomaly_Distortion_Size);
			OJMHIMIPKME().SetFloat(":", Anomaly_Intensity);
			HKIMAANBGMJ().SetFloat(" ", (!_Visualize) ? 1 : 0);
			OJMHIMIPKME().SetFloat("Version 1.0", _FixDistance);
			NFMGLIKNOOC().SetFloat(" not exist", Anomaly_Near);
			MMOODGIODPC().SetFloat("12", Anomaly_Far);
			LPMLLJKMAMP().SetFloat(".status", AnomalyWithoutObject);
			LDNADDJMIPK().SetVector("CameraFilterPack/Colors_BleachBypass", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 965f, 1566f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKIMAANBGMJ());
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
			KEMJNOMIPHN().SetFloat("StartButton", HBJJOCHGOPH);
			KDMBOKLMADJ().SetFloat("event", Intensity);
			HKIMAANBGMJ().SetFloat("#forever", Anomaly_Distortion);
			NFMGLIKNOOC().SetFloat("menu.enableselectormusic", Anomaly_Distortion_Size);
			KEMAALEODNH().SetFloat("HandsCountSlider", Anomaly_Intensity);
			KEMAALEODNH().SetFloat("Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. ", (!_Visualize) ? 0 : 0);
			OJMHIMIPKME().SetFloat("0.00", _FixDistance);
			KEMAALEODNH().SetFloat("_Bullet_3", Anomaly_Near);
			HKIMAANBGMJ().SetFloat("End index must in an integer.", Anomaly_Far);
			CIAFLBFJLEJ().SetFloat("MessageText", AnomalyWithoutObject);
			LPMLLJKMAMP().SetVector("Type \"help\" for list of commands", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1425f, 1763f));
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
		SCShader = Shader.Find("SetSunMaxSize");
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
			KDMBOKLMADJ().SetFloat("JoinRandomRoom failed. In offline mode you still have to leave a room to enter another.", HBJJOCHGOPH);
			KEMJNOMIPHN().SetFloat("seconds", Intensity);
			KEMAALEODNH().SetFloat("CameraFilterPack/FX_Scan", Anomaly_Distortion);
			DBOLLHHMKKN().SetFloat("B", Anomaly_Distortion_Size);
			MMOODGIODPC().SetFloat(". Current number of cells is ", Anomaly_Intensity);
			OJMHIMIPKME().SetFloat("_BlueAmplifier", (!_Visualize) ? 1 : 1);
			DBOLLHHMKKN().SetFloat("...", _FixDistance);
			KBOPGONOCNP().SetFloat("_Value2", Anomaly_Near);
			KEMJNOMIPHN().SetFloat("CameraFilterPack/Colors_Adjust_PreFilters", Anomaly_Far);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Color_Sepia", AnomalyWithoutObject);
			KEMAALEODNH().SetVector("_SubsampleIndices", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 786f, 189f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
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
