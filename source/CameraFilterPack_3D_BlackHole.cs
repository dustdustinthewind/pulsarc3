// CameraFilterPack_3D_BlackHole
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/3D/BlackHole")]
public class CameraFilterPack_3D_BlackHole : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	public bool _Visualize;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 100f)]
	public float _FixDistance = 5f;

	[Range(-0.99f, 0.99f)]
	public float _Distance = 0.05f;

	[Range(0f, 1f)]
	public float _Size = 0.25f;

	[Range(-2f, 2f)]
	public float DistortionLevel = 1.2f;

	[Range(0f, 1f)]
	public float DistortionSize;

	public bool AutoAnimatedNear;

	[Range(-5f, 5f)]
	public float AutoAnimatedNearSpeed = 0.5f;

	public static Color ChangeColorRGB;

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

	private void EAHCLIEEJOG()
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

	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 117f)
			{
				HBJJOCHGOPH = 1626f;
			}
			KEMJNOMIPHN().SetFloat("[NetworkManager] Exited", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 532f)
				{
					_Distance = 820f;
				}
				if (_Distance < 1157f)
				{
					_Distance = 1744f;
				}
				LPMLLJKMAMP().SetFloat("SetPosition", _Distance);
			}
			else
			{
				KEMJNOMIPHN().SetFloat("x", _Distance);
			}
			HKGAONMOBMH().SetFloat("_ScreenResolution", _Size);
			PLBEJJIHFPB().SetFloat(" to: ", _FixDistance);
			HCGJCMDJPGD().SetFloat("_Speed", DistortionLevel);
			LDNADDJMIPK().SetFloat("[Left]", DistortionSize);
			ADGHJOHKEHG().SetFloat("_Intensity", (!_Visualize) ? 0 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			MMOODGIODPC().SetFloat("player.goldbat", 1080f / farClipPlane);
			LPMLLJKMAMP().SetVector("PhotonView ID duplicate found: {0}. New: {1} old: {2}. Maybe one wasn't destroyed on scene load?! Check for 'DontDestroyOnLoad'. Destroying old entry, adding new.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 50f, 1835f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
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
			if (HBJJOCHGOPH > 784f)
			{
				HBJJOCHGOPH = 266f;
			}
			LDNADDJMIPK().SetFloat("colorA", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 873f)
				{
					_Distance = 1541f;
				}
				if (_Distance < 190f)
				{
					_Distance = 1123f;
				}
				JFDGLLEOPGB().SetFloat("inventory.selected.", _Distance);
			}
			else
			{
				JFDGLLEOPGB().SetFloat("_PrevViewProj", _Distance);
			}
			MMOODGIODPC().SetFloat("_BlurRadius", _Size);
			HCGJCMDJPGD().SetFloat("replayData", _FixDistance);
			LPMLLJKMAMP().SetFloat("win", DistortionLevel);
			HCGJCMDJPGD().SetFloat("_TimeX", DistortionSize);
			PLBEJJIHFPB().SetFloat("tagElement", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			GHHPOGODBHB().SetFloat("_TimeX", 1006f / farClipPlane);
			ADGHJOHKEHG().SetVector("ItemsCountText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 841f, 1123f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IBHACCEEFFI()
	{
	}

	private void EGEPLFGKGLI()
	{
		SCShader = Shader.Find("SpawnObj");
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
			if (HBJJOCHGOPH > 322f)
			{
				HBJJOCHGOPH = 1971f;
			}
			JFDGLLEOPGB().SetFloat("[LobbyPlayerElement] On ready click", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1539f)
				{
					_Distance = 170f;
				}
				if (_Distance < 1592f)
				{
					_Distance = 1469f;
				}
				HKGAONMOBMH().SetFloat("/", _Distance);
			}
			else
			{
				LDNADDJMIPK().SetFloat("_Value3", _Distance);
			}
			JFDGLLEOPGB().SetFloat("-1", _Size);
			HKGAONMOBMH().SetFloat("#or", _FixDistance);
			LPMLLJKMAMP().SetFloat("float,0", DistortionLevel);
			LDNADDJMIPK().SetFloat("finished", DistortionSize);
			HKGAONMOBMH().SetFloat("CameraFilterPack/TV_Noise", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HKGAONMOBMH().SetFloat("PointsScoreText", 1893f / farClipPlane);
			LDNADDJMIPK().SetVector("DifficultyBG", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 225f, 209f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CGDMLHLJIDK()
	{
		SCShader = Shader.Find(".lastCheckpoint.comboScore");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KMCPMOGKDEH()
	{
		SCShader = Shader.Find("open");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JBNPEHMDCMI()
	{
	}

	private void DPFOEBCADNP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PBEPCAPAKLG()
	{
	}

	private void OFIMMFHFHDD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KMOCDAOKGLI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NDAJBJFJGCF()
	{
	}

	private void DHENLPJJOEN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1676f)
			{
				HBJJOCHGOPH = 1688f;
			}
			MFHPKGICPIO().SetFloat("z", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1271f)
				{
					_Distance = 361f;
				}
				if (_Distance < 1291f)
				{
					_Distance = 1192f;
				}
				HKGAONMOBMH().SetFloat("LostAllLives", _Distance);
			}
			else
			{
				KEMJNOMIPHN().SetFloat("player.circle", _Distance);
			}
			LPMLLJKMAMP().SetFloat("VisionBlur", _Size);
			ADGHJOHKEHG().SetFloat("_TimeX", _FixDistance);
			JFDGLLEOPGB().SetFloat("Mouse Y", DistortionLevel);
			HKGAONMOBMH().SetFloat(".lastCheckpoint.checkpointsUsed", DistortionSize);
			PLBEJJIHFPB().SetFloat(" timeUntilRespawnBasedOnTimeBase:", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			KEMJNOMIPHN().SetFloat("_ScreenResolution", 1254f / farClipPlane);
			HCGJCMDJPGD().SetVector("_ColorBuffer", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 890f, 1740f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1109f)
			{
				HBJJOCHGOPH = 780f;
			}
			MMOODGIODPC().SetFloat("Joystick1Button0", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1536f)
				{
					_Distance = 1774f;
				}
				if (_Distance < 288f)
				{
					_Distance = 1607f;
				}
				LDNADDJMIPK().SetFloat("PublishButton", _Distance);
			}
			else
			{
				LDNADDJMIPK().SetFloat("CameraFilterPack/Blur_Noise", _Distance);
			}
			GHHPOGODBHB().SetFloat("maps.", _Size);
			PLBEJJIHFPB().SetFloat("RecordButton", _FixDistance);
			HKGAONMOBMH().SetFloat("OpGetGameList()", DistortionLevel);
			NBPKMLMCHFN.SetFloat("Overlay", DistortionSize);
			NBPKMLMCHFN.SetFloat("#tryagain", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HCGJCMDJPGD().SetFloat("ConfigVersionSlider", 1387f / farClipPlane);
			HCGJCMDJPGD().SetVector("UNDISTORT", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 340f, 1588f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1268f)
			{
				HBJJOCHGOPH = 1157f;
			}
			NBPKMLMCHFN.SetFloat("Exception caught! ", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1365f)
				{
					_Distance = 1674f;
				}
				if (_Distance < 418f)
				{
					_Distance = 587f;
				}
				GHHPOGODBHB().SetFloat("_ScreenResolution", _Distance);
			}
			else
			{
				LDNADDJMIPK().SetFloat("InfoButton", _Distance);
			}
			EJDPNJAEAKJ().SetFloat("_ScreenResolution", _Size);
			LDNADDJMIPK().SetFloat(".", _FixDistance);
			EJDPNJAEAKJ().SetFloat("_Value3", DistortionLevel);
			EOCCJGIGEGJ().SetFloat("skin.", DistortionSize);
			HCGJCMDJPGD().SetFloat("_BlurDirectionPacked", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			EOCCJGIGEGJ().SetFloat("CameraFilterPack/Drawing_Manga3", 1504f / farClipPlane);
			PLBEJJIHFPB().SetVector("SetParticlesParticleSpeed", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 517f, 304f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-94);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material MMOODGIODPC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void KIEJKBNBHMD()
	{
	}

	private void EJFJENFKLND()
	{
	}

	private void MMMDPANNAIO()
	{
		SCShader = Shader.Find(" not exist");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material EJDPNJAEAKJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-74);
		}
		return BJFKDHHMLJH;
	}

	private void BNEJMABFKJE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LEAHIBJDMBI()
	{
	}

	[SpecialName]
	private Material KEMJNOMIPHN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return BJFKDHHMLJH;
	}

	private void Update()
	{
	}

	private void EDBEHEKMGFH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 807f)
			{
				HBJJOCHGOPH = 630f;
			}
			KEMJNOMIPHN().SetFloat("_TimeX", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1083f)
				{
					_Distance = 1187f;
				}
				if (_Distance < 1437f)
				{
					_Distance = 1853f;
				}
				NBPKMLMCHFN.SetFloat("checkpoint", _Distance);
			}
			else
			{
				HKGAONMOBMH().SetFloat("_FresnelFadePower", _Distance);
			}
			GHHPOGODBHB().SetFloat("Tab2Content", _Size);
			MFHPKGICPIO().SetFloat(",", _FixDistance);
			EJDPNJAEAKJ().SetFloat("ComboText", DistortionLevel);
			KEMJNOMIPHN().SetFloat("_ColorR", DistortionSize);
			MFHPKGICPIO().SetFloat("0", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			MFHPKGICPIO().SetFloat("_Distortion", 666f / farClipPlane);
			LDNADDJMIPK().SetVector("Received RPC \"", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1703f, 1352f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
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
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1f)
				{
					_Distance = -1f;
				}
				if (_Distance < -1f)
				{
					_Distance = 1f;
				}
				NBPKMLMCHFN.SetFloat("_Near", _Distance);
			}
			else
			{
				NBPKMLMCHFN.SetFloat("_Near", _Distance);
			}
			NBPKMLMCHFN.SetFloat("_Far", _Size);
			NBPKMLMCHFN.SetFloat("_FixDistance", _FixDistance);
			NBPKMLMCHFN.SetFloat("_DistortionLevel", DistortionLevel);
			NBPKMLMCHFN.SetFloat("_DistortionSize", DistortionSize);
			NBPKMLMCHFN.SetFloat("_Visualize", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			NBPKMLMCHFN.SetFloat("_FarCamera", 1000f / farClipPlane);
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
	private Material JFDGLLEOPGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 930f)
			{
				HBJJOCHGOPH = 1316f;
			}
			EOCCJGIGEGJ().SetFloat(".lastCheckpoint.longestComboScore", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1415f)
				{
					_Distance = 1565f;
				}
				if (_Distance < 1296f)
				{
					_Distance = 1872f;
				}
				HKGAONMOBMH().SetFloat("_MainTex2", _Distance);
			}
			else
			{
				PLBEJJIHFPB().SetFloat("_Size", _Distance);
			}
			GHHPOGODBHB().SetFloat("finished", _Size);
			EOCCJGIGEGJ().SetFloat(".lastCheckpoint.incorrectScore", _FixDistance);
			GHHPOGODBHB().SetFloat("DPADVER", DistortionLevel);
			ADGHJOHKEHG().SetFloat("wss://", DistortionSize);
			PLBEJJIHFPB().SetFloat("Joystick1Button6", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			MFHPKGICPIO().SetFloat("_TintColor", 486f / farClipPlane);
			PLBEJJIHFPB().SetVector("_MatrixSize", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 609f, 1468f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KCCIEMBMOBA()
	{
		SCShader = Shader.Find("solo");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HNILMGEKDEC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1901f)
			{
				HBJJOCHGOPH = 1737f;
			}
			ADGHJOHKEHG().SetFloat("[EMPTY]", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 953f)
				{
					_Distance = 739f;
				}
				if (_Distance < 1433f)
				{
					_Distance = 563f;
				}
				EOCCJGIGEGJ().SetFloat(" ", _Distance);
			}
			else
			{
				EOCCJGIGEGJ().SetFloat("workshop.", _Distance);
			}
			MMOODGIODPC().SetFloat("1,30,true,0", _Size);
			JFDGLLEOPGB().SetFloat("_MatrixSize", _FixDistance);
			KEMJNOMIPHN().SetFloat("_SearchTex", DistortionLevel);
			GHHPOGODBHB().SetFloat("Anomaly_Far", DistortionSize);
			JFDGLLEOPGB().SetFloat("Set Trail Zoom (player camera move forward effect). Base value - 1.5", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			LDNADDJMIPK().SetFloat(" .", 248f / farClipPlane);
			JFDGLLEOPGB().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1017f, 204f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
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
			if (HBJJOCHGOPH > 1501f)
			{
				HBJJOCHGOPH = 1370f;
			}
			HKGAONMOBMH().SetFloat("fade out duration", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1536f)
				{
					_Distance = 62f;
				}
				if (_Distance < 1520f)
				{
					_Distance = 72f;
				}
				EOCCJGIGEGJ().SetFloat("_Value7", _Distance);
			}
			else
			{
				NBPKMLMCHFN.SetFloat("MenuScene", _Distance);
			}
			EOCCJGIGEGJ().SetFloat("_Value3", _Size);
			ADGHJOHKEHG().SetFloat(". The RPC has been ignored.", _FixDistance);
			JFDGLLEOPGB().SetFloat("Tab2Content", DistortionLevel);
			MFHPKGICPIO().SetFloat("Needs to be attached to the Event System component in the scene", DistortionSize);
			HCGJCMDJPGD().SetFloat("settings.selectormapsperpage", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			LPMLLJKMAMP().SetFloat("settings.disablestoryboard", 344f / farClipPlane);
			KEMJNOMIPHN().SetVector("MusicFileSelector", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1745f, 654f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material MFHPKGICPIO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)70;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material ADGHJOHKEHG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-76);
		}
		return BJFKDHHMLJH;
	}

	private void BEBNOKFLJPH()
	{
		SCShader = Shader.Find("Fade");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 888f)
			{
				HBJJOCHGOPH = 1149f;
			}
			GHHPOGODBHB().SetFloat(".lastCheckpoint.penaltyScore", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1880f)
				{
					_Distance = 1817f;
				}
				if (_Distance < 1729f)
				{
					_Distance = 657f;
				}
				EOCCJGIGEGJ().SetFloat("#score", _Distance);
			}
			else
			{
				MMOODGIODPC().SetFloat("http://api.steampowered.com/ISteamNews/GetNewsForApp/v0002/?format=json&appid=513510", _Distance);
			}
			PLBEJJIHFPB().SetFloat("_Value4", _Size);
			PLBEJJIHFPB().SetFloat("_Distortion", _FixDistance);
			MMOODGIODPC().SetFloat("_Green_C", DistortionLevel);
			ADGHJOHKEHG().SetFloat("ShowTitle", DistortionSize);
			ADGHJOHKEHG().SetFloat("Object ID. Case-Sensitive", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			LDNADDJMIPK().SetFloat("Skipping EstablishEncryption. Protocol is secure.", 365f / farClipPlane);
			EJDPNJAEAKJ().SetVector("CameraFilterPack/AAA_Blood_Plus", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1514f, 1504f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KIMMMCJFMAB()
	{
		SCShader = Shader.Find("Tab2Content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CCPEDDLAMIB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HPNNCNNFMGK()
	{
	}

	[SpecialName]
	private Material GHHPOGODBHB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material EOCCJGIGEGJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void KFACDBHDAOD()
	{
	}

	private void DLBODOFAJGM()
	{
		SCShader = Shader.Find("settings.enablehitsoundsinnormal");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HGDDCINLDAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1119f)
			{
				HBJJOCHGOPH = 552f;
			}
			MMOODGIODPC().SetFloat(" ", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 712f)
				{
					_Distance = 844f;
				}
				if (_Distance < 972f)
				{
					_Distance = 78f;
				}
				GHHPOGODBHB().SetFloat("_TimeX", _Distance);
			}
			else
			{
				KEMJNOMIPHN().SetFloat("Mouse", _Distance);
			}
			KEMJNOMIPHN().SetFloat("GlassesColor", _Size);
			KEMJNOMIPHN().SetFloat("https://twitch.tv/intralism", _FixDistance);
			LDNADDJMIPK().SetFloat("_SSAO", DistortionLevel);
			EOCCJGIGEGJ().SetFloat("Need to specify a start index and end index.", DistortionSize);
			NBPKMLMCHFN.SetFloat("ItemNameBGImage", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			PLBEJJIHFPB().SetFloat("DPADHOR", 745f / farClipPlane);
			ADGHJOHKEHG().SetVector("float,1.5", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1709f, 863f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HLLHJIDOOGA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HCGJCMDJPGD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void BJOHDLNDFAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FBMDHDBELEK()
	{
	}

	[SpecialName]
	private Material LPMLLJKMAMP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void JDGFCEPDKAJ()
	{
	}

	private void NNFMIAFHMJM()
	{
		SCShader = Shader.Find("\\n");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material HKGAONMOBMH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)102;
		}
		return BJFKDHHMLJH;
	}

	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 465f)
			{
				HBJJOCHGOPH = 840f;
			}
			LDNADDJMIPK().SetFloat("_SecondTex", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 706f)
				{
					_Distance = 288f;
				}
				if (_Distance < 1217f)
				{
					_Distance = 12f;
				}
				KEMJNOMIPHN().SetFloat("[Up-Down]", _Distance);
			}
			else
			{
				KEMJNOMIPHN().SetFloat(", ", _Distance);
			}
			ADGHJOHKEHG().SetFloat("Hex value #RRGGBB", _Size);
			NBPKMLMCHFN.SetFloat("settings.volume.editor", _FixDistance);
			MFHPKGICPIO().SetFloat("_Offsets", DistortionLevel);
			GHHPOGODBHB().SetFloat("Player", DistortionSize);
			HCGJCMDJPGD().SetFloat("/icon", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			MMOODGIODPC().SetFloat("menu.selectedlevelid", 212f / farClipPlane);
			KEMJNOMIPHN().SetVector("_MainTex2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 146f, 38f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AGEJKLMJGDO()
	{
		SCShader = Shader.Find("_ToPrevViewProjCombined");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HONBLGFDMLL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GPHPJIDGEPI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material LDNADDJMIPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)73;
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

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DFENCIHAADO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 948f)
			{
				HBJJOCHGOPH = 700f;
			}
			HKGAONMOBMH().SetFloat("[Up-Right-Down-Left]", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 248f)
				{
					_Distance = 977f;
				}
				if (_Distance < 410f)
				{
					_Distance = 1f;
				}
				EOCCJGIGEGJ().SetFloat("/", _Distance);
			}
			else
			{
				NBPKMLMCHFN.SetFloat("mapselector.filter.favoriteonly", _Distance);
			}
			EOCCJGIGEGJ().SetFloat("_BlurVector", _Size);
			EOCCJGIGEGJ().SetFloat("NetworkScene", _FixDistance);
			LPMLLJKMAMP().SetFloat("CameraFilterPack/FX_8bits", DistortionLevel);
			JFDGLLEOPGB().SetFloat("_Value4", DistortionSize);
			HCGJCMDJPGD().SetFloat("maps.", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			MFHPKGICPIO().SetFloat("PunSupportLogger", 1002f / farClipPlane);
			KEMJNOMIPHN().SetVector("MenuVolumeSlider", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1272f, 575f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/3D_BlackHole");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CFIAKIJAILI()
	{
	}
}
