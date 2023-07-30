// CameraFilterPack_Vision_SniperScore
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Vision/SniperScore")]
public class CameraFilterPack_Vision_SniperScore : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 1f)]
	public float Fade = 1f;

	[Range(0f, 1f)]
	public float Size = 0.45f;

	[Range(0.01f, 0.4f)]
	public float Smooth = 0.045f;

	[Range(0f, 1f)]
	public float _Cible = 0.5f;

	[Range(0f, 1f)]
	public float _Distortion = 0.5f;

	[Range(0f, 1f)]
	public float _ExtraColor = 0.5f;

	[Range(0f, 1f)]
	public float _ExtraLight = 0.35f;

	public Color _Tint = new Color(0f, 0.6f, 0f, 0.25f);

	[Range(0f, 10f)]
	private float ICABEDDNGIH = 1f;

	[Range(0f, 10f)]
	private float LHOMPJOPKHE = 1f;

	[Range(-1f, 1f)]
	public float _PosX;

	[Range(-1f, 1f)]
	public float _PosY;

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

	private void JNBPKNNBMDI()
	{
	}

	[SpecialName]
	private Material NBMPPNFKFLB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IIBLJCKLGFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-89);
		}
		return BJFKDHHMLJH;
	}

	private void ONMGIPAILOH()
	{
	}

	private void LECCHIAFGGE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IKIDIJLIGOH()
	{
	}

	private void AEIJFLJEABG()
	{
	}

	private void OCCGJMPAJIK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ODAIMOJLJOF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1899f)
			{
				HBJJOCHGOPH = 1657f;
			}
			HEHKGPKLAKK().SetFloat("_TimeX", Fade);
			MMOODGIODPC().SetFloat("MainThreadExecuter", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("Ev OwnershipTransfer. ViewID ", Size);
			KEMJNOMIPHN().SetFloat("PlayerPrefs::Deserialize() parameterContent has ", Smooth);
			OIMMPLPBLBK().SetFloat("_TimeX", ICABEDDNGIH);
			HEHKGPKLAKK().SetFloat("float,1", LHOMPJOPKHE);
			FAIFBBGFAIB().SetFloat("[Right]", _Cible);
			MMOODGIODPC().SetFloat("Show Image", _ExtraColor);
			OIMMPLPBLBK().SetFloat("System.Single", _Distortion);
			JLHLHKPHDFO().SetFloat("CameraFilterPack/Blur_Radial_Fast", _PosX);
			HEHKGPKLAKK().SetFloat("menu.enableselectormusic", _PosY);
			OIMMPLPBLBK().SetColor("ClearEnvironment", _Tint);
			OIMMPLPBLBK().SetFloat("RequestOwnership(): ", _ExtraLight);
			Vector2 vector = new Vector2(Screen.width, Screen.height);
			NBMPPNFKFLB().SetVector("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.", new Vector4(vector.x, vector.y, vector.y / vector.x, 987f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-70);
		}
		return BJFKDHHMLJH;
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Vision_SniperScore");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1965f)
			{
				HBJJOCHGOPH = 1502f;
			}
			EMDFHOKEGNG().SetFloat("EventTimeInputField", Fade);
			IIBLJCKLGFG().SetFloat("_Value3", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Connection error: ", Size);
			HEHKGPKLAKK().SetFloat("Set Satellite Trail Width", Smooth);
			FAIFBBGFAIB().SetFloat("CameraFilterPack/Distortion_Twist", ICABEDDNGIH);
			ADBKPGFMNKO().SetFloat("X", LHOMPJOPKHE);
			OIMMPLPBLBK().SetFloat("PossibleMapMaxScoreText", _Cible);
			ADBKPGFMNKO().SetFloat("skin.", _ExtraColor);
			MCDGIILBNIF().SetFloat("BackButton", _Distortion);
			IIBLJCKLGFG().SetFloat("true", _PosX);
			NBPKMLMCHFN.SetFloat("[MapsData] Caching ", _PosY);
			HEHKGPKLAKK().SetColor("_Value", _Tint);
			ADBKPGFMNKO().SetFloat("_Value2", _ExtraLight);
			Vector2 vector = new Vector2(Screen.width, Screen.height);
			KEMJNOMIPHN().SetVector("]. Please verify you have this gameobject in a Resources folder.", new Vector4(vector.x, vector.y, vector.y / vector.x, 776f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material FAIFBBGFAIB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-74);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KEMJNOMIPHN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-100);
		}
		return BJFKDHHMLJH;
	}

	private void FABMDEHEDNO()
	{
	}

	[SpecialName]
	private Material ADBKPGFMNKO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void CBIBDOIBJAI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NNFMIAFHMJM()
	{
		SCShader = Shader.Find("_Value");
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

	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 708f)
			{
				HBJJOCHGOPH = 272f;
			}
			NBMPPNFKFLB().SetFloat("Stream did not contain properly formatted byte array", Fade);
			KEMJNOMIPHN().SetFloat("float,1.5", HBJJOCHGOPH);
			ADBKPGFMNKO().SetFloat(" not exist", Size);
			IONHGBPGCHK().SetFloat("_TimeX", Smooth);
			JLHLHKPHDFO().SetFloat("_TimeX", ICABEDDNGIH);
			IIBLJCKLGFG().SetFloat("Editing: ", LHOMPJOPKHE);
			EMDFHOKEGNG().SetFloat("maps.", _Cible);
			EMDFHOKEGNG().SetFloat("Right", _ExtraColor);
			ADBKPGFMNKO().SetFloat(",", _Distortion);
			IONHGBPGCHK().SetFloat("Set the end of the map. Use this if you want to cut the long music.", _PosX);
			FAIFBBGFAIB().SetFloat("CameraFilterPack/Color_Chromatic_Plus", _PosY);
			MMOODGIODPC().SetColor("float,1.5", _Tint);
			EMDFHOKEGNG().SetFloat("1,30,true,0", _ExtraLight);
			Vector2 vector = new Vector2(Screen.width, Screen.height);
			JLHLHKPHDFO().SetVector("_History1Weight", new Vector4(vector.x, vector.y, vector.y / vector.x, 289f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BMIOFJFMCBG()
	{
		SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void Update()
	{
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
			NBPKMLMCHFN.SetFloat("_Fade", Fade);
			NBPKMLMCHFN.SetFloat("_TimeX", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value", Size);
			NBPKMLMCHFN.SetFloat("_Value2", Smooth);
			NBPKMLMCHFN.SetFloat("_Value3", ICABEDDNGIH);
			NBPKMLMCHFN.SetFloat("_Value4", LHOMPJOPKHE);
			NBPKMLMCHFN.SetFloat("_Cible", _Cible);
			NBPKMLMCHFN.SetFloat("_ExtraColor", _ExtraColor);
			NBPKMLMCHFN.SetFloat("_Distortion", _Distortion);
			NBPKMLMCHFN.SetFloat("_PosX", _PosX);
			NBPKMLMCHFN.SetFloat("_PosY", _PosY);
			NBPKMLMCHFN.SetColor("_Tint", _Tint);
			NBPKMLMCHFN.SetFloat("_ExtraLight", _ExtraLight);
			Vector2 vector = new Vector2(Screen.width, Screen.height);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(vector.x, vector.y, vector.y / vector.x, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HDDECCMEJKA()
	{
	}

	[SpecialName]
	private Material HEHKGPKLAKK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void DPIPGGDNGHN()
	{
	}

	private void JOJFHFHOCHO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DHENLPJJOEN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KCDOMIJBFLL()
	{
	}

	[SpecialName]
	private Material OIMMPLPBLBK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material JLHLHKPHDFO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.DontSave;
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

	private void AGEJKLMJGDO()
	{
		SCShader = Shader.Find(" on effect ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OIBMHPIFAKK()
	{
	}

	private void MMBPLGGLPDB()
	{
	}

	private void DIPDEHOOBPG()
	{
		SCShader = Shader.Find("masterSteamID");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DLBODOFAJGM()
	{
		SCShader = Shader.Find("Right Stick Click");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EFJDNLGNACH()
	{
		SCShader = Shader.Find("Health Stats");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IBHACCEEFFI()
	{
	}

	private void LLJLDLLNFBH()
	{
	}

	private void LCJHDLKJEOM()
	{
	}

	private void EGEPLFGKGLI()
	{
		SCShader = Shader.Find(": ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CCLNNLCOPBL()
	{
		SCShader = Shader.Find(".b");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void NEKCPLGFOFD()
	{
	}

	[SpecialName]
	private Material MCDGIILBNIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-95);
		}
		return BJFKDHHMLJH;
	}

	private void KNBJBNDGCIJ()
	{
		SCShader = Shader.Find("shader.crispwinter");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void PLIKADJCEPO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HNILMGEKDEC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JOACBIEHHCE()
	{
	}

	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 293f)
			{
				HBJJOCHGOPH = 1978f;
			}
			EMDFHOKEGNG().SetFloat("_Value6", Fade);
			IIBLJCKLGFG().SetFloat(" methods \"", HBJJOCHGOPH);
			JLHLHKPHDFO().SetFloat("Fill Area", Size);
			MMOODGIODPC().SetFloat("_Red_C", Smooth);
			MCDGIILBNIF().SetFloat("SetParticlesParticleSpeed", ICABEDDNGIH);
			MMOODGIODPC().SetFloat("[Sound Manager] Audio clip is null, cannot play music", LHOMPJOPKHE);
			MMOODGIODPC().SetFloat("maps.", _Cible);
			HEHKGPKLAKK().SetFloat("[ResourcesManager] Load audio error: ", _ExtraColor);
			MCDGIILBNIF().SetFloat("CameraFilterPack/TV_Old_Movie", _Distortion);
			IONHGBPGCHK().SetFloat("#ok", _PosX);
			OIMMPLPBLBK().SetFloat("_EmissionColor", _PosY);
			IIBLJCKLGFG().SetColor("offline", _Tint);
			IIBLJCKLGFG().SetFloat("_ScreenResolution", _ExtraLight);
			Vector2 vector = new Vector2(Screen.width, Screen.height);
			EMDFHOKEGNG().SetVector("settings_bindings_controller_type", new Vector4(vector.x, vector.y, vector.y / vector.x, 1974f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JBNPEHMDCMI()
	{
	}

	[SpecialName]
	private Material EMDFHOKEGNG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void JDGFCEPDKAJ()
	{
	}

	private void GHILDCBCDJI()
	{
	}

	private void LIEGJOHINGC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MFMIODIAKNI()
	{
	}

	private void NBGIMIDICKE()
	{
		SCShader = Shader.Find("https://steamcdn-a.akamaihd.net/steamcommunity/public/images/clans/");
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-86);
		}
		return BJFKDHHMLJH;
	}

	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1851f)
			{
				HBJJOCHGOPH = 455f;
			}
			MMOODGIODPC().SetFloat("Tab2Content", Fade);
			OIMMPLPBLBK().SetFloat("PlayButton", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("settings_bindings_sec_", Size);
			IIBLJCKLGFG().SetFloat("Joined room ", Smooth);
			MCDGIILBNIF().SetFloat("TypedLobbyInfo '{0}'[{1}] rooms: {2} players: {3}", ICABEDDNGIH);
			IIBLJCKLGFG().SetFloat("_TimeX", LHOMPJOPKHE);
			FAIFBBGFAIB().SetFloat("settings.crosshairopacity", _Cible);
			NBMPPNFKFLB().SetFloat("_QualitySettings", _ExtraColor);
			NBPKMLMCHFN.SetFloat("_SizeY", _Distortion);
			KEMJNOMIPHN().SetFloat(".r", _PosX);
			ADBKPGFMNKO().SetFloat("Set environment sprite color and alpha.", _PosY);
			MCDGIILBNIF().SetColor("BitsData", _Tint);
			MMOODGIODPC().SetFloat("_TargetScale", _ExtraLight);
			Vector2 vector = new Vector2(Screen.width, Screen.height);
			IIBLJCKLGFG().SetVector("CameraFilterPack_eyes_vision_1", new Vector4(vector.x, vector.y, vector.y / vector.x, 792f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GPHPJIDGEPI()
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
			if (HBJJOCHGOPH > 194f)
			{
				HBJJOCHGOPH = 1408f;
			}
			HEHKGPKLAKK().SetFloat("CameraFilterPack/Noise_TV", Fade);
			KEMJNOMIPHN().SetFloat("HIDE CONFIG [Ctrl+E]", HBJJOCHGOPH);
			MMOODGIODPC().SetFloat("CameraFilterPack/Blend2Camera_GreenScreen", Size);
			KEMJNOMIPHN().SetFloat("inventory.selected.", Smooth);
			MMOODGIODPC().SetFloat("_MainTex2", ICABEDDNGIH);
			EMDFHOKEGNG().SetFloat("event", LHOMPJOPKHE);
			FAIFBBGFAIB().SetFloat("_TimeX", _Cible);
			HEHKGPKLAKK().SetFloat("{\"items\":", _ExtraColor);
			MMOODGIODPC().SetFloat("Error calling OpAuthenticate! Did not work. Check log output, AuthValues and if you're connected.", _Distortion);
			KEMJNOMIPHN().SetFloat("_Near", _PosX);
			OIMMPLPBLBK().SetFloat("_CenterY", _PosY);
			OIMMPLPBLBK().SetColor("R1", _Tint);
			OIMMPLPBLBK().SetFloat("[PlayerController] ", _ExtraLight);
			Vector2 vector = new Vector2(Screen.width, Screen.height);
			IIBLJCKLGFG().SetVector("SetParticlesInput", new Vector4(vector.x, vector.y, vector.y / vector.x, 134f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DNNFHBOOPIN()
	{
		SCShader = Shader.Find("CameraFilterPack/Blizzard");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}
}
