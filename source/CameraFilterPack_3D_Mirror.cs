// CameraFilterPack_3D_Mirror
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/3D/Mirror")]
public class CameraFilterPack_3D_Mirror : MonoBehaviour
{
	public Shader SCShader;

	public bool _Visualize;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 100f)]
	public float _FixDistance = 1.5f;

	[Range(-0.99f, 0.99f)]
	public float _Distance = 0.4f;

	[Range(0f, 0.5f)]
	public float _Size = 0.5f;

	[Range(0f, 1f)]
	public float Fade = 1f;

	[Range(0f, 2f)]
	public float Lightning = 2f;

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

	[SpecialName]
	private Material KEMJNOMIPHN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material ABHDNGIHBKE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void AKHCOBHHGJP()
	{
		SCShader = Shader.Find("JoinRoom failed. A roomname is required. If you don't know one, how will you join?");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1020f)
			{
				HBJJOCHGOPH = 1704f;
			}
			MMOODGIODPC().SetFloat(" - StoreAuthURLResponse] - ", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1908f)
				{
					_Distance = 1116f;
				}
				if (_Distance < 880f)
				{
					_Distance = 555f;
				}
				DOHGBNPMBKG().SetFloat("mapselector.filter.officialsortmode", _Distance);
			}
			else
			{
				HKGAONMOBMH().SetFloat("BitsData", _Distance);
			}
			KHCLIAMBBNC().SetFloat("http://steamcommunity.com/sharedfiles/filedetails/?id=", _Size);
			EPCGJFCCAFH().SetFloat("z", _FixDistance);
			NJDIODJNGGA().SetFloat(" not exist", Fade);
			EOCCJGIGEGJ().SetFloat("inventory.selected.", Lightning);
			BBIMPFGLDCP().SetFloat("Destroy all spawned environment objects", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			MHBAIEKFBIJ().SetFloat("id", 394f / farClipPlane);
			MFHPKGICPIO().SetVector("BadgeImage", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 610f, 604f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material OOMFJGPAOKL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return BJFKDHHMLJH;
	}

	private void GNPDGBNDCPL()
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
			if (HBJJOCHGOPH > 522f)
			{
				HBJJOCHGOPH = 1229f;
			}
			KHCLIAMBBNC().SetFloat("cancel", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 621f)
				{
					_Distance = 679f;
				}
				if (_Distance < 587f)
				{
					_Distance = 167f;
				}
				EOCCJGIGEGJ().SetFloat("GameScene", _Distance);
			}
			else
			{
				OOMFJGPAOKL().SetFloat("ConfigVersionSlider", _Distance);
			}
			FOOCJIDNGBB().SetFloat("_ScreenResolution", _Size);
			NBPKMLMCHFN.SetFloat("Set Object Position", _FixDistance);
			BBIMPFGLDCP().SetFloat("IntraTime", Fade);
			LMLENGFLEBD().SetFloat("float,1.5", Lightning);
			LNLKMDPHDCC().SetFloat("CameraFilterPack/Blend2Camera_Difference", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			KBOPGONOCNP().SetFloat("_NoiseTex", 57f / farClipPlane);
			FKEOGPDLBDD().SetVector("Share", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 569f, 1414f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material EPCGJFCCAFH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void ICDBMJKMIKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 523f)
			{
				HBJJOCHGOPH = 232f;
			}
			CFEDGDGBCHE().SetFloat("Tab2Content", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1503f)
				{
					_Distance = 655f;
				}
				if (_Distance < 77f)
				{
					_Distance = 38f;
				}
				FOOCJIDNGBB().SetFloat("cancel", _Distance);
			}
			else
			{
				DOHGBNPMBKG().SetFloat("[PlayerController] ", _Distance);
			}
			EJDPNJAEAKJ().SetFloat("loadscene", _Size);
			KEMJNOMIPHN().SetFloat("_Value", _FixDistance);
			MHBAIEKFBIJ().SetFloat("_Blue_R", Fade);
			FEAEGGCNIAA().SetFloat("TwoHands", Lightning);
			OOMFJGPAOKL().SetFloat("_Value", (!_Visualize) ? 0 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			KBOPGONOCNP().SetFloat("SetPlayerDistance", 1070f / farClipPlane);
			MFHPKGICPIO().SetVector("SetSatelliteLerpSpeed", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1870f, 1571f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LBAJLLFMMMP()
	{
		SCShader = Shader.Find("_AdaptionSpeed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material LNLKMDPHDCC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)97;
		}
		return BJFKDHHMLJH;
	}

	private void LFBGJIIECLD()
	{
		SCShader = Shader.Find("_TimeX");
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

	[SpecialName]
	private Material CFEDGDGBCHE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-88);
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

	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1002f)
			{
				HBJJOCHGOPH = 1536f;
			}
			NLFJGMBCICG().SetFloat("_Value2", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1495f)
				{
					_Distance = 603f;
				}
				if (_Distance < 1036f)
				{
					_Distance = 827f;
				}
				ABHDNGIHBKE().SetFloat("MenuScene", _Distance);
			}
			else
			{
				MFHPKGICPIO().SetFloat("maps.", _Distance);
			}
			DOHGBNPMBKG().SetFloat("_Value4", _Size);
			EPCGJFCCAFH().SetFloat("maps.", _FixDistance);
			KBOPGONOCNP().SetFloat("_ScreenResolution", Fade);
			LMLENGFLEBD().SetFloat("_DistortionLevel", Lightning);
			BBIMPFGLDCP().SetFloat("PlayerBase_", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			NJDIODJNGGA().SetFloat("Room: '{0}' {1},{2} {4}/{3} players.\ncustomProps: {5}", 680f / farClipPlane);
			CFEDGDGBCHE().SetVector("ShowSprite", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 864f, 416f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FOOCJIDNGBB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DLBODOFAJGM()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EODOHEAKJFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HMNLHMLILKD()
	{
	}

	private void PKGJJFIFLII()
	{
	}

	private void NCNPAKFAFOE()
	{
		SCShader = Shader.Find("Joystick1Button11");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void APKNAPHOFHC()
	{
	}

	private void KMOCDAOKGLI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material MFHPKGICPIO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material LPCHMEKDCHI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material BBIMPFGLDCP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void GNMGIHFKJIJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BGDPIHMAACO()
	{
		SCShader = Shader.Find("BitsData");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material ENKPNJMPDEB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)119;
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

	private void JDKHBGDEONK()
	{
		SCShader = Shader.Find("Down ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CGBHOELMAOC()
	{
	}

	private void LIBGAKMKHJJ()
	{
		SCShader = Shader.Find("sprite");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1152f)
			{
				HBJJOCHGOPH = 1118f;
			}
			DOHGBNPMBKG().SetFloat("[SaveSystem] Init from ", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1957f)
				{
					_Distance = 579f;
				}
				if (_Distance < 971f)
				{
					_Distance = 1934f;
				}
				EJDPNJAEAKJ().SetFloat("ERROR You should never change PhotonPlayer IDs!", _Distance);
			}
			else
			{
				ABHDNGIHBKE().SetFloat("???", _Distance);
			}
			EJDPNJAEAKJ().SetFloat("CurrentTimeLabel", _Size);
			LMLENGFLEBD().SetFloat("USE_CORNER_DETECTION", _FixDistance);
			KHCLIAMBBNC().SetFloat("EnableRankedNotificationsToggle", Fade);
			HKGAONMOBMH().SetFloat("UpperMid", Lightning);
			ABHDNGIHBKE().SetFloat("Set particless emission (glow)", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			EJDPNJAEAKJ().SetFloat("_Value2", 1560f / farClipPlane);
			HKGAONMOBMH().SetVector("_Red_G", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 584f, 589f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 854f)
			{
				HBJJOCHGOPH = 567f;
			}
			MHBAIEKFBIJ().SetFloat("Parent object ID. Case-Sensitive", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 264f)
				{
					_Distance = 1447f;
				}
				if (_Distance < 718f)
				{
					_Distance = 1808f;
				}
				FEAEGGCNIAA().SetFloat("?", _Distance);
			}
			else
			{
				OOMFJGPAOKL().SetFloat("maps.", _Distance);
			}
			OOMFJGPAOKL().SetFloat("0,1,false", _Size);
			MHBAIEKFBIJ().SetFloat("Connecting to server", _FixDistance);
			ENKPNJMPDEB().SetFloat("Text", Fade);
			FEAEGGCNIAA().SetFloat(": ", Lightning);
			FOOCJIDNGBB().SetFloat("[PlayerController] ", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FEAEGGCNIAA().SetFloat("x", 321f / farClipPlane);
			HKGAONMOBMH().SetVector("Drop_Far", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 310f, 483f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AOKOLPEGHDD()
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
			if (HBJJOCHGOPH > 1759f)
			{
				HBJJOCHGOPH = 609f;
			}
			ABHDNGIHBKE().SetFloat("_Value3", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 183f)
				{
					_Distance = 530f;
				}
				if (_Distance < 1357f)
				{
					_Distance = 1737f;
				}
				NBPKMLMCHFN.SetFloat(" now: ", _Distance);
			}
			else
			{
				FOOCJIDNGBB().SetFloat("wss://", _Distance);
			}
			MHBAIEKFBIJ().SetFloat("Triangle", _Size);
			EPCGJFCCAFH().SetFloat("Vertical", _FixDistance);
			EPCGJFCCAFH().SetFloat(": ", Fade);
			ENKPNJMPDEB().SetFloat("\" gets executed locally only, if at all.", Lightning);
			MMOODGIODPC().SetFloat("No player left to ask", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			LPCHMEKDCHI().SetFloat("float,0", 356f / farClipPlane);
			NLFJGMBCICG().SetVector("_Distortion", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1988f, 1375f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	private void GPHPJIDGEPI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material KBOPGONOCNP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return BJFKDHHMLJH;
	}

	private void EJFJENFKLND()
	{
	}

	[SpecialName]
	private Material EJDPNJAEAKJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor;
		}
		return BJFKDHHMLJH;
	}

	private void KDMKDEKCELE()
	{
		SCShader = Shader.Find("</color>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PFNFPINPCMH()
	{
	}

	private void MFMIODIAKNI()
	{
	}

	private void EPEGAEGDJAM()
	{
		SCShader = Shader.Find("_ChannelMixerBlue");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MFLBEJHMEMO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MDNHCLKNCLE()
	{
		SCShader = Shader.Find(".lastCheckpoint.time");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PLIKADJCEPO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KFACDBHDAOD()
	{
	}

	private void EAHCLIEEJOG()
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
			if (HBJJOCHGOPH > 1317f)
			{
				HBJJOCHGOPH = 1858f;
			}
			BBIMPFGLDCP().SetFloat("maphash", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 777f)
				{
					_Distance = 1189f;
				}
				if (_Distance < 1680f)
				{
					_Distance = 324f;
				}
				MFHPKGICPIO().SetFloat("_MainTex", _Distance);
			}
			else
			{
				CFEDGDGBCHE().SetFloat("Square", _Distance);
			}
			LNLKMDPHDCC().SetFloat("_Value6", _Size);
			BBIMPFGLDCP().SetFloat("Fade", _FixDistance);
			ENKPNJMPDEB().SetFloat("CameraFilterPack/Blend2Camera_SoftLight", Fade);
			EJDPNJAEAKJ().SetFloat("_TimeX", Lightning);
			LMLENGFLEBD().SetFloat("#C8C8C8FF", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			EOCCJGIGEGJ().SetFloat("Text", 253f / farClipPlane);
			DOHGBNPMBKG().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 678f, 411f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPCHMEKDCHI());
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

	private void MKFLBEGJJDC()
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
			if (HBJJOCHGOPH > 1890f)
			{
				HBJJOCHGOPH = 1172f;
			}
			NBPKMLMCHFN.SetFloat("VisionBlur", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 652f)
				{
					_Distance = 123f;
				}
				if (_Distance < 1742f)
				{
					_Distance = 1787f;
				}
				NJDIODJNGGA().SetFloat("SetSatelliteTrailLength", _Distance);
			}
			else
			{
				MHBAIEKFBIJ().SetFloat("_Value2", _Distance);
			}
			NLFJGMBCICG().SetFloat("Skipping packet for ", _Size);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", _FixDistance);
			FKEOGPDLBDD().SetFloat("_Value4", Fade);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", Lightning);
			MMOODGIODPC().SetFloat("event", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HKGAONMOBMH().SetFloat("_DotSize", 1764f / farClipPlane);
			LPCHMEKDCHI().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 587f, 868f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 746f)
			{
				HBJJOCHGOPH = 1986f;
			}
			MFHPKGICPIO().SetFloat("_MainTex2", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1473f)
				{
					_Distance = 1714f;
				}
				if (_Distance < 757f)
				{
					_Distance = 1502f;
				}
				MFHPKGICPIO().SetFloat("PublishButton", _Distance);
			}
			else
			{
				NBPKMLMCHFN.SetFloat("[SERVER] Player ", _Distance);
			}
			DOHGBNPMBKG().SetFloat("_Value3", _Size);
			HKGAONMOBMH().SetFloat("_Value", _FixDistance);
			KEMJNOMIPHN().SetFloat("_DotSize", Fade);
			FEAEGGCNIAA().SetFloat("_Value5", Lightning);
			KEMJNOMIPHN().SetFloat("#ok", (!_Visualize) ? 0 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			KBOPGONOCNP().SetFloat("CameraFilterPack/Distortion_Water_Drop", 336f / farClipPlane);
			NLFJGMBCICG().SetVector("SlidingArea", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 870f, 1899f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BBIMPFGLDCP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LPMINJJPDCH()
	{
	}

	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 205f)
			{
				HBJJOCHGOPH = 1864f;
			}
			NBPKMLMCHFN.SetFloat("Please specify a map name or buildID", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 177f)
				{
					_Distance = 1914f;
				}
				if (_Distance < 639f)
				{
					_Distance = 966f;
				}
				ENKPNJMPDEB().SetFloat("mapselector.filter.subscribedonly", _Distance);
			}
			else
			{
				LNLKMDPHDCC().SetFloat("_ScreenResolution", _Distance);
			}
			EOCCJGIGEGJ().SetFloat("Malformed RPC; this should never occur. Content: ", _Size);
			FOOCJIDNGBB().SetFloat("/", _FixDistance);
			ENKPNJMPDEB().SetFloat("menu.playedsolo", Fade);
			FKEOGPDLBDD().SetFloat("start", Lightning);
			FOOCJIDNGBB().SetFloat("Message duration multiplier. Recomended 1", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HKGAONMOBMH().SetFloat("threshold", 938f / farClipPlane);
			EOCCJGIGEGJ().SetVector("_WorldToCameraMatrix", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1370f, 1165f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ENKPNJMPDEB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DNNFHBOOPIN()
	{
		SCShader = Shader.Find("---");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
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
	private Material HKGAONMOBMH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void KIMMMCJFMAB()
	{
		SCShader = Shader.Find("leave");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ANDELGODEOC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OIBMHPIFAKK()
	{
	}

	[SpecialName]
	private Material KHCLIAMBBNC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1328f)
			{
				HBJJOCHGOPH = 568f;
			}
			EPCGJFCCAFH().SetFloat("value", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 463f)
				{
					_Distance = 224f;
				}
				if (_Distance < 1809f)
				{
					_Distance = 1322f;
				}
				CFEDGDGBCHE().SetFloat("Items/", _Distance);
			}
			else
			{
				KBOPGONOCNP().SetFloat("_ScreenResolution", _Distance);
			}
			CFEDGDGBCHE().SetFloat("y", _Size);
			KHCLIAMBBNC().SetFloat("/config", _FixDistance);
			DOHGBNPMBKG().SetFloat("CameraFilterPack/BlurHole", Fade);
			MHBAIEKFBIJ().SetFloat("SSAARenderTargetCamera", Lightning);
			KEMJNOMIPHN().SetFloat("Connection error: ", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			LMLENGFLEBD().SetFloat("\n", 499f / farClipPlane);
			LPCHMEKDCHI().SetVector("_Blue_R", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 154f, 1525f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FDMAEPOHDMK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HMPGIFBJFIK()
	{
		SCShader = Shader.Find("EventData0DropDownList");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 679f)
			{
				HBJJOCHGOPH = 1150f;
			}
			ABHDNGIHBKE().SetFloat("PossibleMapPointsText", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1398f)
				{
					_Distance = 1609f;
				}
				if (_Distance < 1071f)
				{
					_Distance = 1104f;
				}
				EJDPNJAEAKJ().SetFloat("EnableRankedNotificationsToggle", _Distance);
			}
			else
			{
				EPCGJFCCAFH().SetFloat("CameraFilterPack/Drawing_Manga5", _Distance);
			}
			EJDPNJAEAKJ().SetFloat(". ActorNr: ", _Size);
			LMLENGFLEBD().SetFloat("#tryagain", _FixDistance);
			KHCLIAMBBNC().SetFloat("#ok", Fade);
			MFHPKGICPIO().SetFloat("AudioSampler", Lightning);
			LPCHMEKDCHI().SetFloat("Found best region: '", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FKEOGPDLBDD().SetFloat("Image", 1587f / farClipPlane);
			FOOCJIDNGBB().SetVector("YES", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 690f, 1094f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			if (HBJJOCHGOPH > 716f)
			{
				HBJJOCHGOPH = 1093f;
			}
			LPCHMEKDCHI().SetFloat(" b.", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 533f)
				{
					_Distance = 944f;
				}
				if (_Distance < 1519f)
				{
					_Distance = 1134f;
				}
				ENKPNJMPDEB().SetFloat("colorC", _Distance);
			}
			else
			{
				NBPKMLMCHFN.SetFloat("Failed to InstantiateSceneObject prefab: ", _Distance);
			}
			CFEDGDGBCHE().SetFloat("_Value3", _Size);
			OOMFJGPAOKL().SetFloat("curScn", _FixDistance);
			NLFJGMBCICG().SetFloat("player.orangearc", Fade);
			LNLKMDPHDCC().SetFloat("MapEnd", Lightning);
			HKGAONMOBMH().SetFloat("_Factor", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			OOMFJGPAOKL().SetFloat("OPEN FILE", 33f / farClipPlane);
			ENKPNJMPDEB().SetVector("menu.selectedplaymode", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1570f, 19f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MHBAIEKFBIJ());
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

	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1786f)
			{
				HBJJOCHGOPH = 790f;
			}
			FEAEGGCNIAA().SetFloat("#rt", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1936f)
				{
					_Distance = 139f;
				}
				if (_Distance < 1425f)
				{
					_Distance = 1501f;
				}
				FEAEGGCNIAA().SetFloat("Tab1Content", _Distance);
			}
			else
			{
				OOMFJGPAOKL().SetFloat(" joined", _Distance);
			}
			KBOPGONOCNP().SetFloat("Jazz", _Size);
			MMOODGIODPC().SetFloat(" Kb", _FixDistance);
			MFHPKGICPIO().SetFloat("_Value3", Fade);
			NLFJGMBCICG().SetFloat("CameraFilterPack/OldFilm_Cutting1", Lightning);
			ENKPNJMPDEB().SetFloat("GlassColor", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			DOHGBNPMBKG().SetFloat("PointsScoreText", 957f / farClipPlane);
			CFEDGDGBCHE().SetVector("float,10", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 123f, 945f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FHGKIOOMMOH()
	{
		SCShader = Shader.Find("menu.enableselectormusic");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material EOCCJGIGEGJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)98;
		}
		return BJFKDHHMLJH;
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
			NBPKMLMCHFN.SetFloat("Fade", Fade);
			NBPKMLMCHFN.SetFloat("Lightning", Lightning);
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

	private void LKJMIODJGCM()
	{
	}

	private void KCDOMIJBFLL()
	{
	}

	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1693f)
			{
				HBJJOCHGOPH = 896f;
			}
			KHCLIAMBBNC().SetFloat("Joystick1Button2", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 551f)
				{
					_Distance = 891f;
				}
				if (_Distance < 448f)
				{
					_Distance = 258f;
				}
				MMOODGIODPC().SetFloat("_Value4", _Distance);
			}
			else
			{
				KHCLIAMBBNC().SetFloat("_BlurCoe", _Distance);
			}
			FOOCJIDNGBB().SetFloat("AudioSampler", _Size);
			NJDIODJNGGA().SetFloat("/", _FixDistance);
			NJDIODJNGGA().SetFloat("icon", Fade);
			NLFJGMBCICG().SetFloat("Scene", Lightning);
			LPCHMEKDCHI().SetFloat(" ", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			EPCGJFCCAFH().SetFloat("checkpoint", 1225f / farClipPlane);
			LNLKMDPHDCC().SetVector("RequestOwnership(): ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1579f, 117f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DBLILJGKGHJ()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IENKPJEBMFM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OPCLBGHAPMG()
	{
	}

	[SpecialName]
	private Material NJDIODJNGGA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInHierarchy);
		}
		return BJFKDHHMLJH;
	}

	private void JMAIIENCEKE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MEBPBNLBECA()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 37f)
			{
				HBJJOCHGOPH = 324f;
			}
			BBIMPFGLDCP().SetFloat(" not exist", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 727f)
				{
					_Distance = 262f;
				}
				if (_Distance < 1094f)
				{
					_Distance = 1165f;
				}
				NBPKMLMCHFN.SetFloat("CameraFilterPack/Blend2Camera_ColorBurn", _Distance);
			}
			else
			{
				ABHDNGIHBKE().SetFloat("_Green_B", _Distance);
			}
			ABHDNGIHBKE().SetFloat("Instance\nWorking commands:\ninit or init <savepath>\npath\nsetint <key> <value>\ngetint <key> <value>\nsetfloat <key> <value>\ngetfloat <key> <value>\nsetstring <key> <value>\ngetstring <key> <value>\nsetbool <key> <value>\ngetbool <key> <value>\ndelete <key>\ndeleteall", _Size);
			LPCHMEKDCHI().SetFloat("_Light2", _FixDistance);
			KEMJNOMIPHN().SetFloat("ResetButton", Fade);
			KEMJNOMIPHN().SetFloat("steamid", Lightning);
			NJDIODJNGGA().SetFloat("_ScreenResolution", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			FOOCJIDNGBB().SetFloat("CameraFilterPack/TV_Vintage", 291f / farClipPlane);
			EJDPNJAEAKJ().SetVector("_FadeShield", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1638f, 249f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material FEAEGGCNIAA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)116;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material FKEOGPDLBDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)71;
		}
		return BJFKDHHMLJH;
	}

	private void KIEJKBNBHMD()
	{
	}

	private void ANCKKLFPGDI()
	{
		SCShader = Shader.Find("CameraFilterPack/AAA_Blood_Hit");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material DOHGBNPMBKG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)111;
		}
		return BJFKDHHMLJH;
	}

	private void DLMPALHKMON()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LFAFJKJAEEL()
	{
		SCShader = Shader.Find("From {0} at Index {1} \n");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/3D_Mirror");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material MMOODGIODPC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)80;
		}
		return BJFKDHHMLJH;
	}

	private void FAKGFMFAPDG()
	{
	}

	private void NBGIMIDICKE()
	{
		SCShader = Shader.Find("DPADHOR");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1951f)
			{
				HBJJOCHGOPH = 1147f;
			}
			LMLENGFLEBD().SetFloat("-1", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 1687f)
				{
					_Distance = 209f;
				}
				if (_Distance < 510f)
				{
					_Distance = 1856f;
				}
				MFHPKGICPIO().SetFloat("_Value3", _Distance);
			}
			else
			{
				HKGAONMOBMH().SetFloat("X", _Distance);
			}
			MMOODGIODPC().SetFloat("Joystick1Button8", _Size);
			MFHPKGICPIO().SetFloat("/", _FixDistance);
			EJDPNJAEAKJ().SetFloat("OnJoinedLobby(). This client is connected and does get a room-list, which gets stored as PhotonNetwork.GetRoomList(). This script now calls: PhotonNetwork.JoinRandomRoom();", Fade);
			EJDPNJAEAKJ().SetFloat("1234332714", Lightning);
			MHBAIEKFBIJ().SetFloat("RecordButton", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			EPCGJFCCAFH().SetFloat("ready", 1706f / farClipPlane);
			EPCGJFCCAFH().SetVector("BitsData", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 717f, 1166f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IIFCIDDJHPM()
	{
	}

	private void HIPEHGNBJMN()
	{
		SCShader = Shader.Find("Left Stick Click");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DGCGGKMNPLD()
	{
	}

	private void OFIMMFHFHDD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NFEDLAOPHML()
	{
	}

	private void HDMDKOKOOJC()
	{
		SCShader = Shader.Find("deletemap");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 407f)
			{
				HBJJOCHGOPH = 1775f;
			}
			EJDPNJAEAKJ().SetFloat("z", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 965f)
				{
					_Distance = 1577f;
				}
				if (_Distance < 1241f)
				{
					_Distance = 1442f;
				}
				FEAEGGCNIAA().SetFloat("_Far", _Distance);
			}
			else
			{
				ABHDNGIHBKE().SetFloat("ViewID {0} {1}{2}", _Distance);
			}
			NLFJGMBCICG().SetFloat("DPADHOR", _Size);
			LNLKMDPHDCC().SetFloat("EndlessLoopsScoreText", _FixDistance);
			DOHGBNPMBKG().SetFloat("_Value", Fade);
			LMLENGFLEBD().SetFloat("Status: ", Lightning);
			OOMFJGPAOKL().SetFloat("maps.", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			HKGAONMOBMH().SetFloat("lobby '{0}'[{1}]", 691f / farClipPlane);
			KBOPGONOCNP().SetVector("note.1", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 760f, 1509f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LMLENGFLEBD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)95;
		}
		return BJFKDHHMLJH;
	}

	private void DPIPGGDNGHN()
	{
	}

	private void PLBOFEPBPKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material NLFJGMBCICG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)76;
		}
		return BJFKDHHMLJH;
	}

	private void NDDNJNCINDA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material FOOCJIDNGBB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-95);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material MHBAIEKFBIJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void HDDECCMEJKA()
	{
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GOANCMNGDLE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1423f)
			{
				HBJJOCHGOPH = 1131f;
			}
			NBPKMLMCHFN.SetFloat("_Distortion", HBJJOCHGOPH);
			if (AutoAnimatedNear)
			{
				_Distance += Time.deltaTime * AutoAnimatedNearSpeed;
				if (_Distance > 877f)
				{
					_Distance = 305f;
				}
				if (_Distance < 464f)
				{
					_Distance = 957f;
				}
				EJDPNJAEAKJ().SetFloat("_TimeX", _Distance);
			}
			else
			{
				NLFJGMBCICG().SetFloat("Set Crosshair Emission", _Distance);
			}
			EOCCJGIGEGJ().SetFloat("maps.", _Size);
			ENKPNJMPDEB().SetFloat("_DotSize", _FixDistance);
			MMOODGIODPC().SetFloat("_Green_C", Fade);
			LNLKMDPHDCC().SetFloat("_EmissionGain", Lightning);
			ABHDNGIHBKE().SetFloat("masterSteamID", (!_Visualize) ? 0 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			NJDIODJNGGA().SetFloat("Anomaly_Far", 1062f / farClipPlane);
			MHBAIEKFBIJ().SetVector("_Val", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 448f, 978f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DDBOODLPCAM()
	{
	}

	private void CNGAJDBOCLJ()
	{
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HOMNAHDDNHJ()
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

	private void NNPBKKBFDHH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LAMEHAHJKMI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KCCIEMBMOBA()
	{
		SCShader = Shader.Find("Editor/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void POIMNOBDBBN()
	{
	}
}
