// CameraFilterPack_Colors_Adjust_ColorRGB
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/ColorsAdjust/ColorRGB")]
[ExecuteInEditMode]
public class CameraFilterPack_Colors_Adjust_ColorRGB : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(-2f, 2f)]
	public float Red;

	[Range(-2f, 2f)]
	public float Green;

	[Range(-2f, 2f)]
	public float Blue;

	[Range(-1f, 1f)]
	public float Brightness;

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

	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1619f)
			{
				HBJJOCHGOPH = 1659f;
			}
			MICHFGAOPKM().SetFloat("Obtain promo Item", HBJJOCHGOPH);
			FEAEGGCNIAA().SetFloat(": ", Red);
			LNLKMDPHDCC().SetFloat("_VignetteSettings", Green);
			MICHFGAOPKM().SetFloat("LoadingStatusText", Blue);
			MFHPKGICPIO().SetFloat("BitsData", Brightness);
			EJDPNJAEAKJ().SetVector("Received RPC \"", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1702f, 1920f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 762f)
			{
				HBJJOCHGOPH = 1051f;
			}
			MICHFGAOPKM().SetFloat("_TimeX", HBJJOCHGOPH);
			FHFLKLMFHOI().SetFloat("_Near", Red);
			FEAEGGCNIAA().SetFloat("challenges.", Green);
			AELJLBOJAIL().SetFloat("_Value", Blue);
			MFHPKGICPIO().SetFloat("Scene", Brightness);
			DKKBFFHBHJE().SetVector("_EmissionGain", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 865f, 1117f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CIPKEPDELJB()
	{
		SCShader = Shader.Find("_ColorB");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 992f)
			{
				HBJJOCHGOPH = 898f;
			}
			LNLKMDPHDCC().SetFloat("open", HBJJOCHGOPH);
			FEAEGGCNIAA().SetFloat("_Value5", Red);
			NLFJGMBCICG().SetFloat("Instrumental", Green);
			NLFJGMBCICG().SetFloat("[MapEditor] Updating top menu", Blue);
			FEAEGGCNIAA().SetFloat("_MainTex2", Brightness);
			AELJLBOJAIL().SetVector("EventTimeInputField", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1528f, 763f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BMIOFJFMCBG()
	{
		SCShader = Shader.Find("[EMPTY]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material FHFLKLMFHOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-104);
		}
		return BJFKDHHMLJH;
	}

	private void CCPEDDLAMIB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LBPHCAMMAPB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 302f)
			{
				HBJJOCHGOPH = 19f;
			}
			EJDPNJAEAKJ().SetFloat("ResourceIDInputField", HBJJOCHGOPH);
			GCDFNHMJMIP().SetFloat("Freq: ", Red);
			LNLKMDPHDCC().SetFloat("_SceneFogParams", Green);
			FHFLKLMFHOI().SetFloat("SupportLogger ", Blue);
			FEAEGGCNIAA().SetFloat("STICKRHOR", Brightness);
			FLOHGDECHHH().SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1691f, 632f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OPCLBGHAPMG()
	{
	}

	private void CNDACAHCCOI()
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
			if (HBJJOCHGOPH > 322f)
			{
				HBJJOCHGOPH = 813f;
			}
			LNLKMDPHDCC().SetFloat("CameraFilterPack_AAA_Blood_Hit1", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("float,0", Red);
			EJDPNJAEAKJ().SetFloat("CameraFilterPack/Glitch_Mozaic", Green);
			DKKBFFHBHJE().SetFloat("settings_bindings_", Blue);
			EJDPNJAEAKJ().SetFloat("curScn", Brightness);
			AELJLBOJAIL().SetVector("settings_bindings_sec_", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 88f, 684f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PKBENONAOOL()
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
			if (HBJJOCHGOPH > 1009f)
			{
				HBJJOCHGOPH = 654f;
			}
			FLOHGDECHHH().SetFloat("finished", HBJJOCHGOPH);
			DONENAMLFLF().SetFloat("LevelFolderInputField", Red);
			ABHDNGIHBKE().SetFloat("Texture2", Green);
			MFHPKGICPIO().SetFloat("open", Blue);
			MFHPKGICPIO().SetFloat("#reward: ", Brightness);
			EJDPNJAEAKJ().SetVector("Up", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1350f, 1932f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ALMGMOOHLMA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1781f)
			{
				HBJJOCHGOPH = 1752f;
			}
			EJDPNJAEAKJ().SetFloat("OK", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("_ScreenResolution", Red);
			ABHDNGIHBKE().SetFloat("skin.hit_perfect", Green);
			MFHPKGICPIO().SetFloat("RB", Blue);
			FLOHGDECHHH().SetFloat("[MapEditor] Loading map: ", Brightness);
			DKKBFFHBHJE().SetVector(" ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1431f, 621f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HPNNCNNFMGK()
	{
	}

	[SpecialName]
	private Material AELJLBOJAIL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-94);
		}
		return BJFKDHHMLJH;
	}

	private void GPFJMKCGHGB()
	{
	}

	private void FHPFJBFCOOF()
	{
		SCShader = Shader.Find(".sawoutdatedmessage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HLDFOJMHKNL()
	{
	}

	private void ICDBMJKMIKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NCNPAKFAFOE()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ONMGIPAILOH()
	{
	}

	private void NBGIMIDICKE()
	{
		SCShader = Shader.Find("inventory.lastitemscount");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FNCDAPDOBBI()
	{
		SCShader = Shader.Find("_VignetteTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LEAHIBJDMBI()
	{
	}

	private void GPHPJIDGEPI()
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
			if (HBJJOCHGOPH > 1269f)
			{
				HBJJOCHGOPH = 676f;
			}
			NBMPPNFKFLB().SetFloat("Hidden/Image Effects/Cinematic/AmbientOcclusion", HBJJOCHGOPH);
			FLOHGDECHHH().SetFloat("settings_bindings_controller_type", Red);
			LNLKMDPHDCC().SetFloat("_Value4", Green);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Colors_Adjust_FullColors", Blue);
			MICHFGAOPKM().SetFloat("Set Crosshair Emission", Brightness);
			AELJLBOJAIL().SetVector("sprite", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1956f, 131f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JBNPEHMDCMI()
	{
	}

	private void KLILJHJNICK()
	{
		SCShader = Shader.Find("_SmallTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1864f)
			{
				HBJJOCHGOPH = 1745f;
			}
			AELJLBOJAIL().SetFloat("_MatrixColor", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("input", Red);
			EJDPNJAEAKJ().SetFloat("Change Note:", Green);
			FLOHGDECHHH().SetFloat("SetSatelliteRadius", Blue);
			DONENAMLFLF().SetFloat("Screen Space Reflections", Brightness);
			FEAEGGCNIAA().SetVector("Beat Detected", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 593f, 211f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 447f)
			{
				HBJJOCHGOPH = 702f;
			}
			NBMPPNFKFLB().SetFloat("value", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat(",", Red);
			EJDPNJAEAKJ().SetFloat("failed", Green);
			MICHFGAOPKM().SetFloat(".", Blue);
			MFHPKGICPIO().SetFloat("[", Brightness);
			MICHFGAOPKM().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 910f, 428f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material OGMEGHKECAH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)89;
		}
		return BJFKDHHMLJH;
	}

	private void IEMEHGCFAPD()
	{
	}

	private void HONBLGFDMLL()
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

	private void AIJGAJIOJDJ()
	{
	}

	private void FABKIGNFECE()
	{
	}

	[SpecialName]
	private Material LNLKMDPHDCC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void COIJKMKIEAK()
	{
		SCShader = Shader.Find("player.quantum");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material NLFJGMBCICG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void JHJFBCFBKLD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CCLNNLCOPBL()
	{
		SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material NBMPPNFKFLB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)98;
		}
		return BJFKDHHMLJH;
	}

	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1465f)
			{
				HBJJOCHGOPH = 911f;
			}
			NBPKMLMCHFN.SetFloat("yyyy-MM-dd HH:mm:ss", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("settings.shaders.bloomintencity", Red);
			DONENAMLFLF().SetFloat("_Saturation", Green);
			DKKBFFHBHJE().SetFloat("The binding '", Blue);
			DONENAMLFLF().SetFloat("Lerp speed. Recomended 10", Brightness);
			FLOHGDECHHH().SetVector("original.tutorial", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 539f, 129f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 0f)
			{
				HBJJOCHGOPH = 54f;
			}
			MFHPKGICPIO().SetFloat("_Glow", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat(".g", Red);
			NLFJGMBCICG().SetFloat("Obtain promo Item", Green);
			ABHDNGIHBKE().SetFloat("note.5", Blue);
			ABHDNGIHBKE().SetFloat("Join failed on GameServer. Changing back to MasterServer. Msg: ", Brightness);
			DONENAMLFLF().SetVector("player.goldbat", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1087f, 1457f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PDHKMDBNGGN()
	{
		SCShader = Shader.Find("<color=white>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material MFHPKGICPIO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
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
			NBPKMLMCHFN.SetFloat("_Value", Red);
			NBPKMLMCHFN.SetFloat("_Value2", Green);
			NBPKMLMCHFN.SetFloat("_Value3", Blue);
			NBPKMLMCHFN.SetFloat("_Value4", Brightness);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			if (HBJJOCHGOPH > 381f)
			{
				HBJJOCHGOPH = 961f;
			}
			FEAEGGCNIAA().SetFloat("settings.fps", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("Join failed on GameServer. Changing back to MasterServer. Msg: ", Red);
			NBMPPNFKFLB().SetFloat("Item ", Green);
			DKKBFFHBHJE().SetFloat("PLEASE WAIT", Blue);
			GCDFNHMJMIP().SetFloat("CameraFilterPack/Drawing_Manga4", Brightness);
			MFHPKGICPIO().SetVector("[Right]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1795f, 759f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NPLCENPNJBM()
	{
		SCShader = Shader.Find("OxOD.lastPath");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FLKEJJEGCFA()
	{
		SCShader = Shader.Find("/theme");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Colors_Adjust_ColorRGB");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material MICHFGAOPKM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material ABHDNGIHBKE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)126;
		}
		return BJFKDHHMLJH;
	}

	private void AEIJFLJEABG()
	{
	}

	private void MECJHOJPODB()
	{
	}

	private void JLNNHKPHMAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NKLIHNJCHOG()
	{
	}

	[SpecialName]
	private Material DONENAMLFLF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-109);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material FEAEGGCNIAA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 951f)
			{
				HBJJOCHGOPH = 932f;
			}
			EJDPNJAEAKJ().SetFloat("Tab2Content", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("ICollection", Red);
			ABHDNGIHBKE().SetFloat("ICollection", Green);
			AELJLBOJAIL().SetFloat("_History1Weight", Blue);
			FEAEGGCNIAA().SetFloat("inventory.selected.", Brightness);
			NLFJGMBCICG().SetVector("float,50", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 504f, 235f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 711f)
			{
				HBJJOCHGOPH = 1905f;
			}
			FEAEGGCNIAA().SetFloat("_Value12", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("_Value7", Red);
			AELJLBOJAIL().SetFloat("Set Object Rotation", Green);
			FLOHGDECHHH().SetFloat(" to: ", Blue);
			AELJLBOJAIL().SetFloat("_Value", Brightness);
			EJDPNJAEAKJ().SetVector("CurrentTimeLabel", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 956f, 1405f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MMBPLGGLPDB()
	{
	}

	[SpecialName]
	private Material DKKBFFHBHJE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void ICILLMAKLMI()
	{
		SCShader = Shader.Find("_ChromaticAberration");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1858f)
			{
				HBJJOCHGOPH = 1060f;
			}
			GCDFNHMJMIP().SetFloat("_TimeX", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("\t", Red);
			GCDFNHMJMIP().SetFloat("#yes", Green);
			OGMEGHKECAH().SetFloat("_CurrentMipLevel", Blue);
			AELJLBOJAIL().SetFloat(" | ", Brightness);
			GCDFNHMJMIP().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 142f, 304f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material EJDPNJAEAKJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-123);
		}
		return BJFKDHHMLJH;
	}

	private void HDDECCMEJKA()
	{
	}

	private void MMMDPANNAIO()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void Update()
	{
	}

	private void KLOLKEBAPFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1781f)
			{
				HBJJOCHGOPH = 781f;
			}
			EJDPNJAEAKJ().SetFloat("_MainTex2", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("_TimeX", Red);
			NBPKMLMCHFN.SetFloat("settings.crosshairopacity", Green);
			MFHPKGICPIO().SetFloat("_Value4", Blue);
			NLFJGMBCICG().SetFloat("EditMenu", Brightness);
			DKKBFFHBHJE().SetVector("\\[ *im.*\\](\\n\\n\\n|\\n\\n|\\n|)", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1873f, 475f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CPAJLKHMOJB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BGFJOEPFOPM()
	{
	}

	[SpecialName]
	private Material FLOHGDECHHH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-103);
		}
		return BJFKDHHMLJH;
	}

	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1144f)
			{
				HBJJOCHGOPH = 741f;
			}
			GCDFNHMJMIP().SetFloat("_MainTex2", HBJJOCHGOPH);
			FHFLKLMFHOI().SetFloat("_Value2", Red);
			OGMEGHKECAH().SetFloat("delete", Green);
			DONENAMLFLF().SetFloat("maps.", Blue);
			NLFJGMBCICG().SetFloat("_TimeX", Brightness);
			DKKBFFHBHJE().SetVector("Music End", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1662f, 61f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
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

	[SpecialName]
	private Material GCDFNHMJMIP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-83);
		}
		return BJFKDHHMLJH;
	}

	private void MKIMDFLBFOM()
	{
		SCShader = Shader.Find(". Should be just one?");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}
}
