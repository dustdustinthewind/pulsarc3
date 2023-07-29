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
			GCDFNHMJMIP().SetFloat("key", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat(" not exist", Red);
			OGMEGHKECAH().SetFloat("_VignetteSettings", Green);
			MICHFGAOPKM().SetFloat("LoadingStatusText", Blue);
			MICHFGAOPKM().SetFloat("BitsData", Brightness);
			MFHPKGICPIO().SetVector(" but this PhotonView does not exist! View was/is ours.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1702f, 1920f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DONENAMLFLF());
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
			EJDPNJAEAKJ().SetFloat("_DotSize", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("_Far", Red);
			FHFLKLMFHOI().SetFloat("???", Green);
			GCDFNHMJMIP().SetFloat("_Value2", Blue);
			DKKBFFHBHJE().SetFloat("Scene", Brightness);
			NLFJGMBCICG().SetVector("_EmissionGain", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 865f, 1117f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FHFLKLMFHOI());
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
			DKKBFFHBHJE().SetFloat("'{0}' \t{1}ms \t{2}", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value5", Red);
			DONENAMLFLF().SetFloat("Jazz", Green);
			DONENAMLFLF().SetFloat("/", Blue);
			DKKBFFHBHJE().SetFloat("_MainTex2", Brightness);
			GCDFNHMJMIP().SetVector("EventTimeInputField", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1528f, 763f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BMIOFJFMCBG()
	{
		SCShader = Shader.Find("\\n");
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
			NBPKMLMCHFN.SetFloat("EventTimeInputField", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("Freq: ", Red);
			AELJLBOJAIL().SetFloat("_MainTex", Green);
			EJDPNJAEAKJ().SetFloat("AppID: {0}*** GameVersion: {1} PeerId: {2} ", Blue);
			OGMEGHKECAH().SetFloat("Alpha", Brightness);
			NBPKMLMCHFN.SetVector("maps.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1691f, 632f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
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
			AELJLBOJAIL().SetFloat("CameraFilterPack/AAA_Blood_Hit", HBJJOCHGOPH);
			FLOHGDECHHH().SetFloat("Scale environment object by the values", Red);
			NBMPPNFKFLB().SetFloat("_TimeX", Green);
			FEAEGGCNIAA().SetFloat("settings_bindings_", Blue);
			NBMPPNFKFLB().SetFloat("[PhotonMessageInfo: Sender='{1}' Senttime={0}]", Brightness);
			NBPKMLMCHFN.SetVector("settings_bindings_controller_type", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 88f, 684f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FHFLKLMFHOI());
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
			DKKBFFHBHJE().SetFloat("finished", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("LevelFolderInputField", Red);
			NBMPPNFKFLB().SetFloat("Texture2", Green);
			GCDFNHMJMIP().SetFloat("visible", Blue);
			NBPKMLMCHFN.SetFloat("#finished", Brightness);
			MFHPKGICPIO().SetVector("Down", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1350f, 1932f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
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
			OGMEGHKECAH().SetFloat("OK", HBJJOCHGOPH);
			DONENAMLFLF().SetFloat("CameraFilterPack/Distortion_Lens", Red);
			FEAEGGCNIAA().SetFloat("sounds/hit_normal", Green);
			NLFJGMBCICG().SetFloat("LT", Blue);
			DKKBFFHBHJE().SetFloat("[MapEditor] Loading map: ", Brightness);
			DKKBFFHBHJE().SetVector(" ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1431f, 621f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
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
		SCShader = Shader.Find("ConfigVersionSlider");
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
		SCShader = Shader.Find("_TimeX");
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
		SCShader = Shader.Find("[ItemsHandler] No connection to item server: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FNCDAPDOBBI()
	{
		SCShader = Shader.Find("_BlurDistance");
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
			NLFJGMBCICG().SetFloat("AmbientOcclusion", HBJJOCHGOPH);
			FLOHGDECHHH().SetFloat("settings_bindings_", Red);
			MICHFGAOPKM().SetFloat("_Value5", Green);
			FLOHGDECHHH().SetFloat("_TimeX", Blue);
			NBMPPNFKFLB().SetFloat("value", Brightness);
			FLOHGDECHHH().SetVector("[PlayerBase] Loaded music", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1956f, 131f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
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
		SCShader = Shader.Find("offsets");
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
			OGMEGHKECAH().SetFloat("_MatrixColor", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", Red);
			DKKBFFHBHJE().SetFloat("SUBMIT", Green);
			FLOHGDECHHH().SetFloat("Set Satellite Radius", Blue);
			FEAEGGCNIAA().SetFloat("_CurrentMipLevel", Brightness);
			NBMPPNFKFLB().SetVector("Beat Detected", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 593f, 211f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MICHFGAOPKM());
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
			AELJLBOJAIL().SetFloat("value", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat(".completedMaps", Red);
			ABHDNGIHBKE().SetFloat("failed", Green);
			EJDPNJAEAKJ().SetFloat("LoadingStatusText", Blue);
			NLFJGMBCICG().SetFloat("[", Brightness);
			MFHPKGICPIO().SetVector("CameraFilterPack/Blend2Camera_SplitScreen", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 910f, 428f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
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
		SCShader = Shader.Find("player.rgb");
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
		SCShader = Shader.Find("/music");
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
			NBPKMLMCHFN.SetFloat("#,0.00", HBJJOCHGOPH);
			FEAEGGCNIAA().SetFloat("FrostCanvas", Red);
			FHFLKLMFHOI().SetFloat("_StretchWidth", Green);
			ABHDNGIHBKE().SetFloat("Failed to 'GetKeyCode' for key: ", Blue);
			NBPKMLMCHFN.SetFloat("float,10", Brightness);
			AELJLBOJAIL().SetVector("original.tutorial", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 539f, 129f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
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
			GCDFNHMJMIP().SetFloat("_Glow", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat(".g", Red);
			DKKBFFHBHJE().SetFloat("key", Green);
			OGMEGHKECAH().SetFloat("powerup.1", Blue);
			OGMEGHKECAH().SetFloat("HandleEventLeave for player ID: ", Brightness);
			NBPKMLMCHFN.SetVector("menutheme.hunter", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1087f, 1457f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PDHKMDBNGGN()
	{
		SCShader = Shader.Find("OnAwakeRPC");
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
			NLFJGMBCICG().SetFloat("-showlogs", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("Most likely the game became empty during the switch to GameServer.", Red);
			ABHDNGIHBKE().SetFloat(" ", Green);
			ABHDNGIHBKE().SetFloat("PLEASE WAIT", Blue);
			NLFJGMBCICG().SetFloat("_TimeX", Brightness);
			LNLKMDPHDCC().SetVector("SpawnObj", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1795f, 759f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NPLCENPNJBM()
	{
		SCShader = Shader.Find("OPEN");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FLKEJJEGCFA()
	{
		SCShader = Shader.Find("AudioSampler");
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
			ABHDNGIHBKE().SetFloat("Tab2Content", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("PointerExit ", Red);
			OGMEGHKECAH().SetFloat("PointerExit ", Green);
			NLFJGMBCICG().SetFloat("_History3Weight", Blue);
			NBPKMLMCHFN.SetFloat("inventory.selected.", Brightness);
			EJDPNJAEAKJ().SetVector("float,50", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 504f, 235f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DONENAMLFLF());
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
			NLFJGMBCICG().SetFloat("_Value13", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("_PColor2", Red);
			MICHFGAOPKM().SetFloat("Set Object Rotation", Green);
			MICHFGAOPKM().SetFloat("PhotonView register is ignored, because viewID is 0. No id assigned yet to: ", Blue);
			MFHPKGICPIO().SetFloat("_Value2", Brightness);
			ABHDNGIHBKE().SetVector("TimeBGSlider", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 956f, 1405f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
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
		SCShader = Shader.Find("_BlurPass");
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
			GCDFNHMJMIP().SetFloat("_DotSize", HBJJOCHGOPH);
			FLOHGDECHHH().SetFloat("\t", Red);
			AELJLBOJAIL().SetFloat("#ok", Green);
			GCDFNHMJMIP().SetFloat("Internal LUT", Blue);
			DONENAMLFLF().SetFloat("<color=white>", Brightness);
			LNLKMDPHDCC().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 142f, 304f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EJDPNJAEAKJ());
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
			MICHFGAOPKM().SetFloat("_MainTex2", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("_TimeX", Red);
			FEAEGGCNIAA().SetFloat("_EmissionColor", Green);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", Blue);
			NLFJGMBCICG().SetFloat("EventMenu", Brightness);
			NBMPPNFKFLB().SetVector("\\[ *im.*\\](\\n\\n\\n|\\n\\n|\\n|)", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1873f, 475f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EJDPNJAEAKJ());
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
			AELJLBOJAIL().SetFloat("_MainTex2", HBJJOCHGOPH);
			DKKBFFHBHJE().SetFloat("_Value3", Red);
			OGMEGHKECAH().SetFloat("delete", Green);
			FLOHGDECHHH().SetFloat("maps.", Blue);
			FEAEGGCNIAA().SetFloat("_Value2", Brightness);
			NBPKMLMCHFN.SetVector("Set the end of the map. Use this if you want to cut the long music.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1662f, 61f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLOHGDECHHH());
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
		SCShader = Shader.Find("]. Please verify you have this gameobject in a Resources folder.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}
}
