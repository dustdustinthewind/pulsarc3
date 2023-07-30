// CameraFilterPack_3D_Mirror
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/3D/Mirror")]
[ExecuteInEditMode]
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
		SCShader = Shader.Find("JoinRoom failed. In offline mode you still have to leave a room to enter another.");
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
			KBOPGONOCNP().SetFloat(" - GameWebCallback] - ", HBJJOCHGOPH);
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
				MFHPKGICPIO().SetFloat("mapselector.filter.subscribedonly", _Distance);
			}
			else
			{
				NLFJGMBCICG().SetFloat("event", _Distance);
			}
			NBPKMLMCHFN.SetFloat("menu.enableselectormusic", _Size);
			EPCGJFCCAFH().SetFloat("z", _FixDistance);
			ENKPNJMPDEB().SetFloat(": ", Fade);
			MFHPKGICPIO().SetFloat("22x1", Lightning);
			NLFJGMBCICG().SetFloat("Clear Environment", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			EJDPNJAEAKJ().SetFloat("SetSatelliteRotationSpeed", 394f / farClipPlane);
			FKEOGPDLBDD().SetVector("LoadingStatusText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 610f, 604f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MHBAIEKFBIJ());
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
			MFHPKGICPIO().SetFloat("...", HBJJOCHGOPH);
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
				FEAEGGCNIAA().SetFloat("GameScene", _Distance);
			}
			else
			{
				FOOCJIDNGBB().SetFloat("LivesSlider", _Distance);
			}
			FKEOGPDLBDD().SetFloat("_GlowColor", _Size);
			BBIMPFGLDCP().SetFloat("Set Object Position", _FixDistance);
			ABHDNGIHBKE().SetFloat("challengeid", Fade);
			FEAEGGCNIAA().SetFloat("y", Lightning);
			HKGAONMOBMH().SetFloat("CameraFilterPack/Blend2Camera_HardMix", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			NJDIODJNGGA().SetFloat("_VelocityScale", 57f / farClipPlane);
			LPCHMEKDCHI().SetVector("R2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 569f, 1414f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OOMFJGPAOKL());
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
			FKEOGPDLBDD().SetFloat("EnvironmentSlider", HBJJOCHGOPH);
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
				EPCGJFCCAFH().SetFloat("[ResourcesManager] Load text error: not found", _Distance);
			}
			else
			{
				KEMJNOMIPHN().SetFloat(" not exist", _Distance);
			}
			MMOODGIODPC().SetFloat("Print the list of scenes, avalable in game.", _Size);
			FEAEGGCNIAA().SetFloat("_Value", _FixDistance);
			HKGAONMOBMH().SetFloat("_Blue_R", Fade);
			LPCHMEKDCHI().SetFloat("event", Lightning);
			EOCCJGIGEGJ().SetFloat("_TimeX", (!_Visualize) ? 0 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			ABHDNGIHBKE().SetFloat("ShowTitle", 1070f / farClipPlane);
			KHCLIAMBBNC().SetVector("SetSatelliteEmission", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1870f, 1571f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LBAJLLFMMMP()
	{
		SCShader = Shader.Find("_ExposureAdjustment");
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
			CFEDGDGBCHE().SetFloat("_Value2", HBJJOCHGOPH);
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
				EOCCJGIGEGJ().SetFloat("#yes", _Distance);
			}
			else
			{
				MMOODGIODPC().SetFloat(".lastCheckpoint.longestComboScore", _Distance);
			}
			BBIMPFGLDCP().SetFloat("_Value2", _Size);
			LNLKMDPHDCC().SetFloat("Crosshair1", _FixDistance);
			LMLENGFLEBD().SetFloat("_ScreenResolution", Fade);
			MFHPKGICPIO().SetFloat("_DistortionLevel", Lightning);
			KEMJNOMIPHN().SetFloat("SpawnObj", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			MFHPKGICPIO().SetFloat("hidden", 680f / farClipPlane);
			NBPKMLMCHFN.SetVector("finished", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 864f, 416f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DLBODOFAJGM()
	{
		SCShader = Shader.Find("_TimeX");
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
		SCShader = Shader.Find("Left Stick Click");
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
		SCShader = Shader.Find(",");
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
		SCShader = Shader.Find("Down");
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
		SCShader = Shader.Find("1");
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
			KBOPGONOCNP().SetFloat("[SaveSystem] Init from ", HBJJOCHGOPH);
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
				FOOCJIDNGBB().SetFloat("Could not execute RPC ", _Distance);
			}
			else
			{
				ABHDNGIHBKE().SetFloat(" item(s) in inventory", _Distance);
			}
			FEAEGGCNIAA().SetFloat("[MapEditor] Loaded music file: ", _Size);
			MHBAIEKFBIJ().SetFloat("USE_CORNER_DETECTION", _FixDistance);
			LMLENGFLEBD().SetFloat("EnableRankedNotificationsToggle", Fade);
			HKGAONMOBMH().SetFloat("UpperMid", Lightning);
			EPCGJFCCAFH().SetFloat("float,1.5", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			DOHGBNPMBKG().SetFloat("_Value", 1560f / farClipPlane);
			EPCGJFCCAFH().SetVector("_Red_R", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 584f, 589f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
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
			FEAEGGCNIAA().SetFloat("Parent object ID. Case-Sensitive", HBJJOCHGOPH);
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
				NBPKMLMCHFN.SetFloat("?", _Distance);
			}
			else
			{
				DOHGBNPMBKG().SetFloat("maps.", _Distance);
			}
			NJDIODJNGGA().SetFloat("0,1,false", _Size);
			NJDIODJNGGA().SetFloat("LoadingStatusText", _FixDistance);
			ENKPNJMPDEB().SetFloat("Item ", Fade);
			NJDIODJNGGA().SetFloat("[PlayerController] ", Lightning);
			ABHDNGIHBKE().SetFloat("AddEnvironmentSprite", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			KEMJNOMIPHN().SetFloat("x", 321f / farClipPlane);
			FEAEGGCNIAA().SetVector("Drop_Far", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 310f, 483f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
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
			FKEOGPDLBDD().SetFloat("_Value2", HBJJOCHGOPH);
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
				LMLENGFLEBD().SetFloat(" (now: ", _Distance);
			}
			else
			{
				OOMFJGPAOKL().SetFloat("Using constructor for new PingNativeDynamic()", _Distance);
			}
			EJDPNJAEAKJ().SetFloat("Joystick1Button3", _Size);
			KEMJNOMIPHN().SetFloat("name", _FixDistance);
			EJDPNJAEAKJ().SetFloat(": ", Fade);
			BBIMPFGLDCP().SetFloat("Error; Only the MasterClient can call RemoveRPCs for other players.", Lightning);
			EOCCJGIGEGJ().SetFloat("Cant ask anyone else for PickupItem spawn times.", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			MFHPKGICPIO().SetFloat("x", 356f / farClipPlane);
			BBIMPFGLDCP().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1988f, 1375f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FOOCJIDNGBB());
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
		SCShader = Shader.Find("#");
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
		SCShader = Shader.Find("_ChannelMixerRed");
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
		SCShader = Shader.Find(".");
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
			LMLENGFLEBD().SetFloat("mapid", HBJJOCHGOPH);
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
				KEMJNOMIPHN().SetFloat("_Offsets", _Distance);
			}
			else
			{
				DOHGBNPMBKG().SetFloat("Mouse Y", _Distance);
			}
			DOHGBNPMBKG().SetFloat("_Value6", _Size);
			FEAEGGCNIAA().SetFloat("UseFinalGlassColor", _FixDistance);
			MHBAIEKFBIJ().SetFloat("CameraFilterPack/Blend2Camera_Overlay", Fade);
			EPCGJFCCAFH().SetFloat("CameraFilterPack/Glasses_On", Lightning);
			MFHPKGICPIO().SetFloat("#8E8E8EFF", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			ENKPNJMPDEB().SetFloat("Item ", 253f / farClipPlane);
			ABHDNGIHBKE().SetVector("CameraFilterPack/Drawing_NewCellShading", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 678f, 411f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
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
			ABHDNGIHBKE().SetFloat("Fade", HBJJOCHGOPH);
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
				KBOPGONOCNP().SetFloat("SetSatelliteRotationSpeed", _Distance);
			}
			else
			{
				OOMFJGPAOKL().SetFloat("_Value", _Distance);
			}
			EOCCJGIGEGJ().SetFloat("Received OnSerialization for view ID ", _Size);
			FKEOGPDLBDD().SetFloat("_Value2", _FixDistance);
			LMLENGFLEBD().SetFloat("_Value4", Fade);
			ENKPNJMPDEB().SetFloat("_FarCamera", Lightning);
			NBPKMLMCHFN.SetFloat("BitsData", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			KHCLIAMBBNC().SetFloat("_DotSize", 1764f / farClipPlane);
			FKEOGPDLBDD().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 587f, 868f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
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
			LPCHMEKDCHI().SetFloat("_MainTex2", HBJJOCHGOPH);
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
				KEMJNOMIPHN().SetFloat("PublishButton", _Distance);
			}
			else
			{
				ENKPNJMPDEB().SetFloat("RecieveChatActionMessage", _Distance);
			}
			MFHPKGICPIO().SetFloat("_Value2", _Size);
			MMOODGIODPC().SetFloat("_TimeX", _FixDistance);
			NLFJGMBCICG().SetFloat("_DotSize", Fade);
			HKGAONMOBMH().SetFloat("_Value5", Lightning);
			NBPKMLMCHFN.SetFloat("/", (!_Visualize) ? 0 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			EJDPNJAEAKJ().SetFloat("_ScreenResolution", 336f / farClipPlane);
			LMLENGFLEBD().SetVector("Overlay", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 870f, 1899f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KBOPGONOCNP());
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
			MFHPKGICPIO().SetFloat("challenges.", HBJJOCHGOPH);
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
				OOMFJGPAOKL().SetFloat("mapselector.filter.rateduponly", _Distance);
			}
			else
			{
				NLFJGMBCICG().SetFloat("_ScreenResolution", _Distance);
			}
			HKGAONMOBMH().SetFloat(" with a prefix of ", _Size);
			BBIMPFGLDCP().SetFloat("/", _FixDistance);
			FEAEGGCNIAA().SetFloat("original.tutorial", Fade);
			HKGAONMOBMH().SetFloat("start", Lightning);
			ENKPNJMPDEB().SetFloat("duration", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			KHCLIAMBBNC().SetFloat("colorC", 938f / farClipPlane);
			CFEDGDGBCHE().SetVector("_CameraClipInfo", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1370f, 1165f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DNNFHBOOPIN()
	{
		SCShader = Shader.Find("Obtain test Item");
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
			NJDIODJNGGA().SetFloat("Object ID. Case-Sensitive", HBJJOCHGOPH);
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
				FKEOGPDLBDD().SetFloat("/config", _Distance);
			}
			else
			{
				MHBAIEKFBIJ().SetFloat("_Value3", _Distance);
			}
			EPCGJFCCAFH().SetFloat("z", _Size);
			LNLKMDPHDCC().SetFloat("Items/", _FixDistance);
			HKGAONMOBMH().SetFloat("CameraFilterPack/BlurHole", Fade);
			NBPKMLMCHFN.SetFloat("Screenshots only supported in PlayMode", Lightning);
			LMLENGFLEBD().SetFloat("#restart", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			EPCGJFCCAFH().SetFloat("The region arrays from Name Server are not ok. Must be non-null and same length. ", 499f / farClipPlane);
			KHCLIAMBBNC().SetVector("_Green_B", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 154f, 1525f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FOOCJIDNGBB());
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
		SCShader = Shader.Find("BitsData");
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
			FEAEGGCNIAA().SetFloat("PossibleMapPointsText", HBJJOCHGOPH);
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
				LPCHMEKDCHI().SetFloat("EnableRankedNotificationsToggle", _Distance);
			}
			else
			{
				KEMJNOMIPHN().SetFloat("_DotSize", _Distance);
			}
			DOHGBNPMBKG().SetFloat("Can't find PhotonView of incoming OwnershipRequest. ViewId not found: ", _Size);
			FEAEGGCNIAA().SetFloat("#scoresubmitionfailed: ", _FixDistance);
			KEMJNOMIPHN().SetFloat("SpawnObj", Fade);
			LPCHMEKDCHI().SetFloat("AudioSampler", Lightning);
			EOCCJGIGEGJ().SetFloat(" PhotonNetwork.networkingPeer.AvailableRegions ", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			ABHDNGIHBKE().SetFloat("Image", 1587f / farClipPlane);
			DOHGBNPMBKG().SetVector("Map already submited. Update?", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 690f, 1094f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPCHMEKDCHI());
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
			OOMFJGPAOKL().SetFloat("public", HBJJOCHGOPH);
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
				KHCLIAMBBNC().SetFloat("colorA", _Distance);
			}
			else
			{
				EPCGJFCCAFH().SetFloat("Failed to InstantiateSceneObject prefab: ", _Distance);
			}
			MHBAIEKFBIJ().SetFloat("_Value2", _Size);
			LPCHMEKDCHI().SetFloat("curScn", _FixDistance);
			FKEOGPDLBDD().SetFloat("menutheme.deleted", Fade);
			NJDIODJNGGA().SetFloat("MapEnd", Lightning);
			KBOPGONOCNP().SetFloat("_Factor", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			LMLENGFLEBD().SetFloat("_LensDirt", 33f / farClipPlane);
			MFHPKGICPIO().SetVector("menu.selectedplaymode", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1570f, 19f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
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
			DOHGBNPMBKG().SetFloat("remaining: {0:0.000}", HBJJOCHGOPH);
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
				MMOODGIODPC().SetFloat("[SERVER] Player ", _Distance);
			}
			KHCLIAMBBNC().SetFloat("Jazz", _Size);
			NJDIODJNGGA().SetFloat("#.##", _FixDistance);
			EJDPNJAEAKJ().SetFloat("_Value3", Fade);
			ABHDNGIHBKE().SetFloat("_ScreenResolution", Lightning);
			LNLKMDPHDCC().SetFloat("GlassesColor2", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			EPCGJFCCAFH().SetFloat("PointsScoreText", 957f / farClipPlane);
			EJDPNJAEAKJ().SetVector("float,10", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 123f, 945f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FHGKIOOMMOH()
	{
		SCShader = Shader.Find("SingleplayerButton");
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
			LNLKMDPHDCC().SetFloat("Joystick1Button1", HBJJOCHGOPH);
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
				CFEDGDGBCHE().SetFloat("_Value3", _Distance);
			}
			else
			{
				MFHPKGICPIO().SetFloat("_BlurCoe", _Distance);
			}
			FKEOGPDLBDD().SetFloat("AudioSampler", _Size);
			NJDIODJNGGA().SetFloat("selector", _FixDistance);
			LNLKMDPHDCC().SetFloat("/icon", Fade);
			HKGAONMOBMH().SetFloat("SfxVolumeSlider", Lightning);
			KHCLIAMBBNC().SetFloat(" ", (!_Visualize) ? 1 : 1);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			LMLENGFLEBD().SetFloat("resource", 1225f / farClipPlane);
			LPCHMEKDCHI().SetVector("Network destroy Instantiated GO: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1579f, 117f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPCHMEKDCHI());
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
			NLFJGMBCICG().SetFloat("[PlayerController] ", HBJJOCHGOPH);
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
				CFEDGDGBCHE().SetFloat("_ScreenResolution", _Distance);
			}
			else
			{
				KBOPGONOCNP().SetFloat("_Green_G", _Distance);
			}
			LPCHMEKDCHI().SetFloat("Unsupported type: ", _Size);
			MFHPKGICPIO().SetFloat("_Light", _FixDistance);
			KEMJNOMIPHN().SetFloat("ResetButton", Fade);
			MFHPKGICPIO().SetFloat(".message", Lightning);
			LMLENGFLEBD().SetFloat("_ScreenResolution", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			OOMFJGPAOKL().SetFloat("_VignettingDirt", 291f / farClipPlane);
			KBOPGONOCNP().SetVector("_FadeShield", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1638f, 249f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
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
		SCShader = Shader.Find("Source Object: ");
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
			FEAEGGCNIAA().SetFloat("-1", HBJJOCHGOPH);
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
				LPCHMEKDCHI().SetFloat("_Value2", _Distance);
			}
			else
			{
				NLFJGMBCICG().SetFloat("Xbox Home", _Distance);
			}
			EPCGJFCCAFH().SetFloat("Joystick1Button7", _Size);
			OOMFJGPAOKL().SetFloat("/", _FixDistance);
			NBPKMLMCHFN.SetFloat("Update() was called by Unity. Scene is loaded. Let's connect to the Photon Master Server. Calling: PhotonNetwork.ConnectUsingSettings();", Fade);
			EPCGJFCCAFH().SetFloat("1177138211", Lightning);
			LPCHMEKDCHI().SetFloat("RecordButton", (!_Visualize) ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			KBOPGONOCNP().SetFloat("ready", 1706f / farClipPlane);
			KBOPGONOCNP().SetVector("ResourceFileSelector", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 717f, 1166f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
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
		SCShader = Shader.Find("Start");
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
		SCShader = Shader.Find("/");
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
			ABHDNGIHBKE().SetFloat("x", HBJJOCHGOPH);
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
				ABHDNGIHBKE().SetFloat("_Near", _Distance);
			}
			else
			{
				MMOODGIODPC().SetFloat(" respawn: ", _Distance);
			}
			DOHGBNPMBKG().SetFloat("DPADVER", _Size);
			ABHDNGIHBKE().SetFloat("EndlessLoopsScoreText", _FixDistance);
			KBOPGONOCNP().SetFloat("_TimeX", Fade);
			KHCLIAMBBNC().SetFloat("scn", Lightning);
			OOMFJGPAOKL().SetFloat("maps.", _Visualize ? 1 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			EPCGJFCCAFH().SetFloat("OpChangeGroups()", 691f / farClipPlane);
			ENKPNJMPDEB().SetVector("#ok", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 760f, 1509f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
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
			KHCLIAMBBNC().SetFloat("_TimeX", HBJJOCHGOPH);
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
				CFEDGDGBCHE().SetFloat("_ScreenResolution", _Distance);
			}
			else
			{
				HKGAONMOBMH().SetFloat("SetCrosshairEmission", _Distance);
			}
			NBPKMLMCHFN.SetFloat("maps.", _Size);
			BBIMPFGLDCP().SetFloat("_TimeX", _FixDistance);
			KBOPGONOCNP().SetFloat("_Red_C", Fade);
			EPCGJFCCAFH().SetFloat("[Left]", Lightning);
			CFEDGDGBCHE().SetFloat("roomDescription", (!_Visualize) ? 0 : 0);
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			MFHPKGICPIO().SetFloat("Anomaly_Far", 1062f / farClipPlane);
			MMOODGIODPC().SetVector("CameraFilterPack/Colors_Brightness", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 448f, 978f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
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
		SCShader = Shader.Find("_TimeX");
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
