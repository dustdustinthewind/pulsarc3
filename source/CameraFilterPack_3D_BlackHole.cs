// CameraFilterPack_3D_BlackHole
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/3D/BlackHole")]
[ExecuteInEditMode]
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
			HCGJCMDJPGD().SetFloat("[NetworkManager] Exited", HBJJOCHGOPH);
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
				HCGJCMDJPGD().SetFloat("SetTrailZoomSpeed", _Distance);
			}
			else
			{
				LPMLLJKMAMP().SetFloat("w", _Distance);
			}
			HCGJCMDJPGD().SetFloat("_Value4", _Size);
			HKGAONMOBMH().SetFloat("ExitGames.Client.Photon.SocketWebTcp, Assembly-CSharp", _FixDistance);
			LDNADDJMIPK().SetFloat("_TimeX", DistortionLevel);
			ADGHJOHKEHG().SetFloat("[Left]", DistortionSize);
			HKGAONMOBMH().SetFloat("_MainTex", (!_Visualize) ? 0 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			EJDPNJAEAKJ().SetFloat("player.bluebat", 1080f / farClipPlane);
			MFHPKGICPIO().SetVector("Had to lookup view that wasn't in photonViewList: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 50f, 1835f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PLBEJJIHFPB());
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
			HCGJCMDJPGD().SetFloat("_ColorBuffer", HBJJOCHGOPH);
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
				GHHPOGODBHB().SetFloat("21x3", _Distance);
			}
			else
			{
				MFHPKGICPIO().SetFloat("_Parameter", _Distance);
			}
			JFDGLLEOPGB().SetFloat("_EdgeSharpness", _Size);
			JFDGLLEOPGB().SetFloat("accuracy", _FixDistance);
			MFHPKGICPIO().SetFloat(".lastCheckpoint.perfectHits", DistortionLevel);
			GHHPOGODBHB().SetFloat("_TimeX", DistortionSize);
			NBPKMLMCHFN.SetFloat("tagElement", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			LPMLLJKMAMP().SetFloat("CameraFilterPack/TV_Distorted", 1006f / farClipPlane);
			HCGJCMDJPGD().SetVector("InfoCanvas", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 841f, 1123f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
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
		SCShader = Shader.Find("[Up]");
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
			HKGAONMOBMH().SetFloat("[LobbyPlayerElement] On ready click", HBJJOCHGOPH);
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
				LPMLLJKMAMP().SetFloat("music", _Distance);
			}
			else
			{
				JFDGLLEOPGB().SetFloat("_Value2", _Distance);
			}
			LDNADDJMIPK().SetFloat("restrictions\n\n#until: ", _Size);
			JFDGLLEOPGB().SetFloat("\"x", _FixDistance);
			LDNADDJMIPK().SetFloat("float,0", DistortionLevel);
			LDNADDJMIPK().SetFloat("[PlayerBase] Reset", DistortionSize);
			HKGAONMOBMH().SetFloat("_ScreenResolution", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			MFHPKGICPIO().SetFloat("0.00", 1893f / farClipPlane);
			ADGHJOHKEHG().SetVector("DifficultyBG", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 225f, 209f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CGDMLHLJIDK()
	{
		SCShader = Shader.Find(".lastCheckpoint.powerupsScore");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KMCPMOGKDEH()
	{
		SCShader = Shader.Find("Room: '{0}' {1},{2} {4}/{3} players.");
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
			MMOODGIODPC().SetFloat("z", HBJJOCHGOPH);
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
				EOCCJGIGEGJ().SetFloat("_DiffuseColor", _Distance);
			}
			else
			{
				LPMLLJKMAMP().SetFloat("player.circle", _Distance);
			}
			KEMJNOMIPHN().SetFloat("Fade", _Size);
			JFDGLLEOPGB().SetFloat("CameraFilterPack/Glow_Glow_Color", _FixDistance);
			LPMLLJKMAMP().SetFloat("DPADHOR", DistortionLevel);
			GHHPOGODBHB().SetFloat(".lastCheckpoint.lives", DistortionSize);
			MFHPKGICPIO().SetFloat(" now: ", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			GHHPOGODBHB().SetFloat("_TimeX", 1254f / farClipPlane);
			KEMJNOMIPHN().SetVector("threshold", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 890f, 1740f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
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
			ADGHJOHKEHG().SetFloat("Joystick1Button12", HBJJOCHGOPH);
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
				PLBEJJIHFPB().SetFloat("PublishButton", _Distance);
			}
			else
			{
				PLBEJJIHFPB().SetFloat("CameraFilterPack/Blur_Noise", _Distance);
			}
			ADGHJOHKEHG().SetFloat("Loading", _Size);
			NBPKMLMCHFN.SetFloat("#C8C8C8FF", _FixDistance);
			KEMJNOMIPHN().SetFloat("OpJoinRoom()", DistortionLevel);
			GHHPOGODBHB().SetFloat("Text", DistortionSize);
			ADGHJOHKEHG().SetFloat("#md5submitionfailed: ", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			MFHPKGICPIO().SetFloat("Tab2Content", 1387f / farClipPlane);
			HCGJCMDJPGD().SetVector("VIGNETTE_BLUR", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 340f, 1588f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
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
			LDNADDJMIPK().SetFloat("BestRegion checks region: ", HBJJOCHGOPH);
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
				ADGHJOHKEHG().SetFloat("_Value5", _Distance);
			}
			else
			{
				MMOODGIODPC().SetFloat("InfoButton", _Distance);
			}
			LDNADDJMIPK().SetFloat("_Value4", _Size);
			PLBEJJIHFPB().SetFloat("_EmissionColor", _FixDistance);
			LDNADDJMIPK().SetFloat("_Value2", DistortionLevel);
			EOCCJGIGEGJ().SetFloat("challenges/", DistortionSize);
			GHHPOGODBHB().SetFloat("_PrevViewProj", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			KEMJNOMIPHN().SetFloat("_DotSize", 1504f / farClipPlane);
			EJDPNJAEAKJ().SetVector("Set particles gravity", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 517f, 304f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
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
		SCShader = Shader.Find("[PlayerController] ");
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
			HCGJCMDJPGD().SetFloat("_TimeX", HBJJOCHGOPH);
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
				LDNADDJMIPK().SetFloat("Edited unlock conditions", _Distance);
			}
			else
			{
				KEMJNOMIPHN().SetFloat("_SSRMultiplier", _Distance);
			}
			EJDPNJAEAKJ().SetFloat("Tab2Content", _Size);
			PLBEJJIHFPB().SetFloat("EventData0DropDownList", _FixDistance);
			PLBEJJIHFPB().SetFloat("HPText", DistortionLevel);
			LDNADDJMIPK().SetFloat("_DotSize", DistortionSize);
			GHHPOGODBHB().SetFloat("#ok", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			NBPKMLMCHFN.SetFloat("_TimeX", 666f / farClipPlane);
			GHHPOGODBHB().SetVector(" By: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1703f, 1352f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GHHPOGODBHB());
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
			MMOODGIODPC().SetFloat(".lastCheckpoint.playerdistance", HBJJOCHGOPH);
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
				EJDPNJAEAKJ().SetFloat("_MainTex2", _Distance);
			}
			else
			{
				PLBEJJIHFPB().SetFloat("_Size", _Distance);
			}
			LPMLLJKMAMP().SetFloat("finished", _Size);
			LDNADDJMIPK().SetFloat(".lastCheckpoint.correctScore", _FixDistance);
			MFHPKGICPIO().SetFloat("DPADVER", DistortionLevel);
			LDNADDJMIPK().SetFloat(" Message: ", DistortionSize);
			MMOODGIODPC().SetFloat("RB", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			LDNADDJMIPK().SetFloat("_Threshhold", 486f / farClipPlane);
			MMOODGIODPC().SetVector("_MatrixSize", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 609f, 1468f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
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
			ADGHJOHKEHG().SetFloat("#", HBJJOCHGOPH);
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
				ADGHJOHKEHG().SetFloat(" ", _Distance);
			}
			else
			{
				EOCCJGIGEGJ().SetFloat("workshop.", _Distance);
			}
			EJDPNJAEAKJ().SetFloat("speed", _Size);
			JFDGLLEOPGB().SetFloat("_MatrixSize", _FixDistance);
			LPMLLJKMAMP().SetFloat("SearchTex", DistortionLevel);
			EOCCJGIGEGJ().SetFloat("Anomaly_Near", DistortionSize);
			HKGAONMOBMH().SetFloat("float,1.5", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			LPMLLJKMAMP().SetFloat("n/a", 248f / farClipPlane);
			LDNADDJMIPK().SetVector("#creatingnewitem", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1017f, 204f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
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
			JFDGLLEOPGB().SetFloat("fade out duration", HBJJOCHGOPH);
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
				GHHPOGODBHB().SetFloat("_Value7", _Distance);
			}
			else
			{
				EJDPNJAEAKJ().SetFloat("/", _Distance);
			}
			HKGAONMOBMH().SetFloat("_Value3", _Size);
			KEMJNOMIPHN().SetFloat(" with a prefix of ", _FixDistance);
			MFHPKGICPIO().SetFloat("ConfigVersionSlider", DistortionLevel);
			HKGAONMOBMH().SetFloat("SelectionBox component is on a gameObject with a Canvas Scaler component. As of now, Canvas Scalers without the default settings throw off the coordinates of the selection box. Canvas Scaler has been removed.", DistortionSize);
			EOCCJGIGEGJ().SetFloat("Search: ", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			KEMJNOMIPHN().SetFloat("[GameScene] Events count: ", 344f / farClipPlane);
			HKGAONMOBMH().SetVector("IconFileSelector", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1745f, 654f));
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
		SCShader = Shader.Find("_TimeX");
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
			EOCCJGIGEGJ().SetFloat(".lastCheckpoint.perfectHits", HBJJOCHGOPH);
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
				HKGAONMOBMH().SetFloat("#score", _Distance);
			}
			else
			{
				HKGAONMOBMH().SetFloat("http://api.steampowered.com/ISteamNews/GetNewsForApp/v0002/?format=json&appid=513510", _Distance);
			}
			NBPKMLMCHFN.SetFloat("_Value3", _Size);
			EJDPNJAEAKJ().SetFloat("_TimeX", _FixDistance);
			ADGHJOHKEHG().SetFloat("_Red_C", DistortionLevel);
			MMOODGIODPC().SetFloat("SpawnObj", DistortionSize);
			HCGJCMDJPGD().SetFloat("Object ID. Case-Sensitive", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			EJDPNJAEAKJ().SetFloat("Connected to NameServer.", 365f / farClipPlane);
			NBPKMLMCHFN.SetVector("CameraFilterPack/AAA_Blood_Plus", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1514f, 1504f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KIMMMCJFMAB()
	{
		SCShader = Shader.Find("LivesSlider");
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
		SCShader = Shader.Find("powerup.0");
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
			PLBEJJIHFPB().SetFloat(" ", HBJJOCHGOPH);
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
				LPMLLJKMAMP().SetFloat("CameraFilterPack/Light_Rainbow2", _Distance);
			}
			else
			{
				LPMLLJKMAMP().SetFloat("Mouse2", _Distance);
			}
			HCGJCMDJPGD().SetFloat("GlassAberration", _Size);
			HKGAONMOBMH().SetFloat("https://discord.gg/intralism", _FixDistance);
			LPMLLJKMAMP().SetFloat("_SSAO", DistortionLevel);
			LDNADDJMIPK().SetFloat("X2", DistortionSize);
			MFHPKGICPIO().SetFloat("IconImage", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HCGJCMDJPGD().SetFloat("DPADHOR", 745f / farClipPlane);
			MFHPKGICPIO().SetVector("float,1.5", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1709f, 863f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
		SCShader = Shader.Find("[EMPTY]");
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
			GHHPOGODBHB().SetFloat("_ThirdTex", HBJJOCHGOPH);
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
				MFHPKGICPIO().SetFloat("[Up-Down]", _Distance);
			}
			else
			{
				LPMLLJKMAMP().SetFloat("s", _Distance);
			}
			KEMJNOMIPHN().SetFloat("Hex value #RRGGBB", _Size);
			GHHPOGODBHB().SetFloat("settings.volume.editor", _FixDistance);
			MMOODGIODPC().SetFloat("_Offsets", DistortionLevel);
			LDNADDJMIPK().SetFloat("UpdateNewsTileStart", DistortionSize);
			LPMLLJKMAMP().SetFloat("Items/", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			KEMJNOMIPHN().SetFloat("menu.selectedlevelid", 212f / farClipPlane);
			EJDPNJAEAKJ().SetVector("CameraFilterPack/Blend2Camera_LinearBurn", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 146f, 38f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AGEJKLMJGDO()
	{
		SCShader = Shader.Find("_PrevViewProj");
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
			EOCCJGIGEGJ().SetFloat("[Up-Right-Down-Left]", HBJJOCHGOPH);
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
				KEMJNOMIPHN().SetFloat("workshop.", _Distance);
			}
			else
			{
				LPMLLJKMAMP().SetFloat("mapselector.filter.favoriteonly", _Distance);
			}
			NBPKMLMCHFN.SetFloat("_BlurVector", _Size);
			EJDPNJAEAKJ().SetFloat("ItemsUploader", _FixDistance);
			EOCCJGIGEGJ().SetFloat("Texture2", DistortionLevel);
			GHHPOGODBHB().SetFloat("_Value3", DistortionSize);
			MMOODGIODPC().SetFloat("maps.", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			LDNADDJMIPK().SetFloat("Status: ", 1002f / farClipPlane);
			EJDPNJAEAKJ().SetVector("MenuVolumeSlider", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1272f, 575f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EJDPNJAEAKJ());
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
