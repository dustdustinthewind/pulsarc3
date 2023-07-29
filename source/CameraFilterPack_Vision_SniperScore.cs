// CameraFilterPack_Vision_SniperScore
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Vision/SniperScore")]
[ExecuteInEditMode]
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
			IONHGBPGCHK().SetFloat("_Y", Fade);
			IIBLJCKLGFG().SetFloat("skin.no_hit", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat(" Time: ", Size);
			NBPKMLMCHFN.SetFloat(" elements", Smooth);
			HEHKGPKLAKK().SetFloat("_TimeX", ICABEDDNGIH);
			EMDFHOKEGNG().SetFloat("float,1", LHOMPJOPKHE);
			EMDFHOKEGNG().SetFloat("[Right]", _Cible);
			FAIFBBGFAIB().SetFloat("Show Image", _ExtraColor);
			MCDGIILBNIF().SetFloat("System.Int64", _Distortion);
			IONHGBPGCHK().SetFloat("CameraFilterPack/Blur_Radial_Fast", _PosX);
			IONHGBPGCHK().SetFloat("menu.enableselectormusic", _PosY);
			ADBKPGFMNKO().SetColor("ClearEnvironment", _Tint);
			IIBLJCKLGFG().SetFloat("TransferOwnership() view ", _ExtraLight);
			Vector2 vector = new Vector2(Screen.width, Screen.height);
			KEMJNOMIPHN().SetVector("ns", new Vector4(vector.x, vector.y, vector.y / vector.x, 987f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			MMOODGIODPC().SetFloat("_Value4", HBJJOCHGOPH);
			JLHLHKPHDFO().SetFloat("[RanksSystem] Ranks: no need to update", Size);
			JLHLHKPHDFO().SetFloat("id", Smooth);
			IONHGBPGCHK().SetFloat("_TimeX", ICABEDDNGIH);
			EMDFHOKEGNG().SetFloat("A", LHOMPJOPKHE);
			EMDFHOKEGNG().SetFloat("GameModeText", _Cible);
			FAIFBBGFAIB().SetFloat(".icon", _ExtraColor);
			NBMPPNFKFLB().SetFloat("BackButton", _Distortion);
			HEHKGPKLAKK().SetFloat("bool", _PosX);
			HEHKGPKLAKK().SetFloat("[MapsData] Bad map: ", _PosY);
			JLHLHKPHDFO().SetColor("_Value2", _Tint);
			EMDFHOKEGNG().SetFloat("_Value3", _ExtraLight);
			Vector2 vector = new Vector2(Screen.width, Screen.height);
			ADBKPGFMNKO().SetVector("Failed to 'network-remove' GameObject because it's null.", new Vector4(vector.x, vector.y, vector.y / vector.x, 776f));
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
		SCShader = Shader.Find("_Value2");
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
			IONHGBPGCHK().SetFloat("Did not read byte array properly", Fade);
			MMOODGIODPC().SetFloat("z", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("[PlayerController] ", Size);
			MCDGIILBNIF().SetFloat("_Value", Smooth);
			EMDFHOKEGNG().SetFloat("_Value", ICABEDDNGIH);
			MCDGIILBNIF().SetFloat("LevelEditor/patterns", LHOMPJOPKHE);
			IONHGBPGCHK().SetFloat("maps.", _Cible);
			OIMMPLPBLBK().SetFloat("-1", _ExtraColor);
			MCDGIILBNIF().SetFloat("CountEventsGoal", _Distortion);
			MCDGIILBNIF().SetFloat("Set the end of the map. Use this if you want to cut the long music.", _PosX);
			NBMPPNFKFLB().SetFloat("_TimeX", _PosY);
			HEHKGPKLAKK().SetColor("Set crosshair emission (glow)", _Tint);
			FAIFBBGFAIB().SetFloat("1,30,true,0", _ExtraLight);
			Vector2 vector = new Vector2(Screen.width, Screen.height);
			KEMJNOMIPHN().SetVector("_History3Weight", new Vector4(vector.x, vector.y, vector.y / vector.x, 289f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
		SCShader = Shader.Find("OnRenderImage in Helper called ...");
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
		SCShader = Shader.Find("[NetworkManager] Join failed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DLBODOFAJGM()
	{
		SCShader = Shader.Find("Joystick1Button12");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EFJDNLGNACH()
	{
		SCShader = Shader.Find("{0}\n{1}\n{2}\n{3}\n{4}\n{5}");
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
		SCShader = Shader.Find(" / ");
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
		SCShader = Shader.Find("shader.ghost");
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
			KEMJNOMIPHN().SetFloat("_Value6", Fade);
			OIMMPLPBLBK().SetFloat(". Should be just one?", HBJJOCHGOPH);
			JLHLHKPHDFO().SetFloat("Fill Area", Size);
			MMOODGIODPC().SetFloat("_Green_C", Smooth);
			OIMMPLPBLBK().SetFloat("SetEnvSpriteImage", ICABEDDNGIH);
			IIBLJCKLGFG().SetFloat("sfxVolume", LHOMPJOPKHE);
			MMOODGIODPC().SetFloat("maps.", _Cible);
			FAIFBBGFAIB().SetFloat("</color>", _ExtraColor);
			IONHGBPGCHK().SetFloat("_TimeX", _Distortion);
			EMDFHOKEGNG().SetFloat("Editor", _PosX);
			ADBKPGFMNKO().SetFloat("SetLives", _PosY);
			ADBKPGFMNKO().SetColor("offline", _Tint);
			IIBLJCKLGFG().SetFloat("_MainTex2", _ExtraLight);
			Vector2 vector = new Vector2(Screen.width, Screen.height);
			IIBLJCKLGFG().SetVector("settings_bindings_controller_type", new Vector4(vector.x, vector.y, vector.y / vector.x, 1974f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
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
			EMDFHOKEGNG().SetFloat("Tab2Content", Fade);
			FAIFBBGFAIB().SetFloat("  |  Events Count: ", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("settings_bindings_controller_type", Size);
			IIBLJCKLGFG().SetFloat("Joined room ", Smooth);
			MCDGIILBNIF().SetFloat("{0}{1}{2}={3}", ICABEDDNGIH);
			FAIFBBGFAIB().SetFloat("_TimeX", LHOMPJOPKHE);
			ADBKPGFMNKO().SetFloat("_EmissionColor", _Cible);
			IIBLJCKLGFG().SetFloat("Hidden/Subpixel Morphological Anti-aliasing", _ExtraColor);
			IONHGBPGCHK().SetFloat("_SizeY", _Distortion);
			EMDFHOKEGNG().SetFloat(".g", _PosX);
			KEMJNOMIPHN().SetFloat("Set environment sprite color and alpha.", _PosY);
			HEHKGPKLAKK().SetColor("BitsData", _Tint);
			KEMJNOMIPHN().SetFloat("_SampleCount", _ExtraLight);
			Vector2 vector = new Vector2(Screen.width, Screen.height);
			IONHGBPGCHK().SetVector("CameraFilterPack/EyesVision_1", new Vector4(vector.x, vector.y, vector.y / vector.x, 792f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIBLJCKLGFG());
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
			OIMMPLPBLBK().SetFloat("_TimeX", Fade);
			NBPKMLMCHFN.SetFloat("Committing changes...", HBJJOCHGOPH);
			MMOODGIODPC().SetFloat("CameraFilterPack/Blend2Camera_GreenScreen", Size);
			FAIFBBGFAIB().SetFloat("inventory.selected.", Smooth);
			ADBKPGFMNKO().SetFloat("_TimeX", ICABEDDNGIH);
			ADBKPGFMNKO().SetFloat("Added event", LHOMPJOPKHE);
			IIBLJCKLGFG().SetFloat("_ScreenResolution", _Cible);
			ADBKPGFMNKO().SetFloat("\\\"", _ExtraColor);
			IONHGBPGCHK().SetFloat("Expected protocol set to UDP, due to encryption mode DatagramEncryption. Changing protocol in PhotonServerSettings from: ", _Distortion);
			OIMMPLPBLBK().SetFloat("_Near", _PosX);
			NBMPPNFKFLB().SetFloat("_CenterY", _PosY);
			NBPKMLMCHFN.SetColor("L2", _Tint);
			JLHLHKPHDFO().SetFloat(" not exist", _ExtraLight);
			Vector2 vector = new Vector2(Screen.width, Screen.height);
			JLHLHKPHDFO().SetVector("Set Particles Input", new Vector4(vector.x, vector.y, vector.y / vector.x, 134f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
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
