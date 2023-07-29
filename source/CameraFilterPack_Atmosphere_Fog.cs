// CameraFilterPack_Atmosphere_Fog
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Weather/Fog")]
[ExecuteInEditMode]
public class CameraFilterPack_Atmosphere_Fog : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 1f)]
	public float _Near;

	[Range(0f, 1f)]
	public float _Far = 0.05f;

	public Color FogColor = new Color(0.4f, 0.4f, 0.4f, 1f);

	[Range(0f, 1f)]
	public float Fade = 1f;

	public static Color ChangeColorRGB;

	private Texture2D FPHEBLMINDA;

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

	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1278f)
			{
				HBJJOCHGOPH = 1462f;
			}
			KEMAALEODNH().SetFloat("COMPLETED", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("\t", Fade);
			IIJMIPBMMBF().SetFloat("_TimeX", _Near);
			IIJMIPBMMBF().SetFloat("MenuScene", _Far);
			NLFJGMBCICG().SetColor("skin.hit_wrong", FogColor);
			CECJJMKLEAK().SetVector("Object ID. Case-Sensitive", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1412f, 1330f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			HNICHJCGJOC().SetTexture("_Offsets", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DOOIKOEBBJB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1055f)
			{
				HBJJOCHGOPH = 670f;
			}
			IONHGBPGCHK().SetFloat("<b>#", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("float,0", Fade);
			OOMFJGPAOKL().SetFloat("float,10", _Near);
			FLOHGDECHHH().SetFloat(",", _Far);
			JLHLHKPHDFO().SetColor("mapselector.lastSearch", FogColor);
			FLOHGDECHHH().SetVector("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1733f, 1385f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			NBMPPNFKFLB().SetTexture("CameraFilterPack_Blizzard1", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1005f)
			{
				HBJJOCHGOPH = 289f;
			}
			OHKGGPFGLFD().SetFloat("Rock", HBJJOCHGOPH);
			IIBLJCKLGFG().SetFloat("x", Fade);
			IGKFMCPDNOI().SetFloat("SetSatelliteSensitivity", _Near);
			FLOHGDECHHH().SetFloat("/", _Far);
			FLOHGDECHHH().SetColor("_SweaterSize", FogColor);
			ADGHJOHKEHG().SetVector("_Blue_C", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1111f, 1430f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			IONHGBPGCHK().SetTexture("challenges.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1013f)
			{
				HBJJOCHGOPH = 741f;
			}
			ADGHJOHKEHG().SetFloat("SetSunDirectionVector", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("RecordButton", Fade);
			MICHFGAOPKM().SetFloat("id", _Near);
			FEAEGGCNIAA().SetFloat(" SphereWaveform.cs", _Far);
			FLOHGDECHHH().SetColor("_ScreenResolution", FogColor);
			NBMPPNFKFLB().SetVector("_ProjectToPixelMatrix", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 159f, 1703f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			DKNJGHFLAIF().SetTexture("note.5", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DKNJGHFLAIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 785f)
			{
				HBJJOCHGOPH = 922f;
			}
			MICHFGAOPKM().SetFloat("_Far", HBJJOCHGOPH);
			JLHLHKPHDFO().SetFloat("[PlayerController] ", Fade);
			IGKFMCPDNOI().SetFloat(".lastCheckpoint.lives", _Near);
			NLFJGMBCICG().SetFloat("NetworkPeer broke!", _Far);
			OHKGGPFGLFD().SetColor("LoadingStatusText", FogColor);
			NLFJGMBCICG().SetVector("(\\[ */ *i *\\])", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1756f, 1034f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			HNICHJCGJOC().SetTexture("[PlayerBase] Loaded custom model: ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DPFOEBCADNP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 605f)
			{
				HBJJOCHGOPH = 1994f;
			}
			FLOHGDECHHH().SetFloat("System.Single", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("CameraFilterPack/TV_Vintage", Fade);
			JLHLHKPHDFO().SetFloat("</size>", _Near);
			JLHLHKPHDFO().SetFloat("setAF", _Far);
			MICHFGAOPKM().SetColor("clicked ", FogColor);
			DKNJGHFLAIF().SetVector("Object ID. Case-Sensitive", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 579f, 95f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			KEMAALEODNH().SetTexture("Checkpoint", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LINKAMEPKGM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material IIJMIPBMMBF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.HideInHierarchy;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material MICHFGAOPKM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-85);
		}
		return BJFKDHHMLJH;
	}

	private void BGDPIHMAACO()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack/TV_VHS_Rewind") as Texture2D;
		SCShader = Shader.Find("_MatrixColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MANDOGNJJBD()
	{
	}

	[SpecialName]
	private Material NFMGLIKNOOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	private void LIBGAKMKHJJ()
	{
		FPHEBLMINDA = Resources.Load("_SSAO") as Texture2D;
		SCShader = Shader.Find("_Color2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EKCDEFDELMP()
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
			if (HBJJOCHGOPH > 642f)
			{
				HBJJOCHGOPH = 302f;
			}
			KEMAALEODNH().SetFloat("blue", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("targetColor", Fade);
			DKNJGHFLAIF().SetFloat("_ScreenResolution", _Near);
			EHDJJANLINB().SetFloat("ItemNameText", _Far);
			IIBLJCKLGFG().SetColor("nd", FogColor);
			OHKGGPFGLFD().SetVector("ComboText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 756f, 737f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			FLOHGDECHHH().SetTexture(" [", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FODKODGPPDA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BOLBPPHJBMI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1925f)
			{
				HBJJOCHGOPH = 1567f;
			}
			EHDJJANLINB().SetFloat("Mouse Y", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("request", Fade);
			IGKFMCPDNOI().SetFloat("AVG Misses:", _Near);
			NBPKMLMCHFN.SetFloat("Object ID. Case-Sensitive", _Far);
			OOMFJGPAOKL().SetColor("_Near", FogColor);
			KEMAALEODNH().SetVector("steamid", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1830f, 43f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			IONHGBPGCHK().SetTexture("bpmgrid", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void POJFHDFJOPE()
	{
	}

	private void LLKKGGLNIDF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DPIPGGDNGHN()
	{
	}

	private void HONBLGFDMLL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1051f)
			{
				HBJJOCHGOPH = 458f;
			}
			IGKFMCPDNOI().SetFloat(" on effect ", HBJJOCHGOPH);
			EHDJJANLINB().SetFloat("InventoryGrid", Fade);
			NBMPPNFKFLB().SetFloat("[PlayerBase] SpawnObj error: ", _Near);
			NFMGLIKNOOC().SetFloat("CameraFilterPack/Blend2Camera_ColorDodge", _Far);
			FLOHGDECHHH().SetColor("<command>", FogColor);
			KEMAALEODNH().SetVector("Hip-hop", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 866f, 399f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			JLHLHKPHDFO().SetTexture("_TimeX", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
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

	private void BGFJOEPFOPM()
	{
	}

	private void NNCCPEBIAKH()
	{
		FPHEBLMINDA = Resources.Load("_Radius") as Texture2D;
		SCShader = Shader.Find("USE_DIAG_SEARCH");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material IIBLJCKLGFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-76);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HNICHJCGJOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NLFJGMBCICG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)85;
		}
		return BJFKDHHMLJH;
	}

	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 584f)
			{
				HBJJOCHGOPH = 1354f;
			}
			JLHLHKPHDFO().SetFloat("DPADVER", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("SetParticlesInput", Fade);
			FKEOGPDLBDD().SetFloat("The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.", _Near);
			CECJJMKLEAK().SetFloat("CameraFilterPack/Blend2Camera_LinearLight", _Far);
			IGKFMCPDNOI().SetColor(".", FogColor);
			MICHFGAOPKM().SetVector("AudioSampler", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 938f, 1421f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			IONHGBPGCHK().SetTexture("The used master server address is not available with the subscription currently used. Got to Photon Cloud Dashboard or change URL. Disconnecting.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IKIDIJLIGOH()
	{
	}

	private void CCLNNLCOPBL()
	{
		FPHEBLMINDA = Resources.Load("CountEventsGoal") as Texture2D;
		SCShader = Shader.Find("player.dragon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
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
			NBPKMLMCHFN.SetFloat("_DepthLevel", Fade);
			NBPKMLMCHFN.SetFloat("_Near", _Near);
			NBPKMLMCHFN.SetFloat("_Far", _Far);
			NBPKMLMCHFN.SetColor("_ColorRGB", FogColor);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			NBPKMLMCHFN.SetTexture("Texture2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1280f)
			{
				HBJJOCHGOPH = 31f;
			}
			MICHFGAOPKM().SetFloat("SetSatelliteColor", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("_TimeX", Fade);
			FGENHBKMPDA().SetFloat("CameraFilterPack/Vision_Hell_Blood", _Near);
			NBMPPNFKFLB().SetFloat("_Distortion", _Far);
			HNICHJCGJOC().SetColor("settings.enableranking", FogColor);
			IONHGBPGCHK().SetVector("mapselector.tags.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1367f, 900f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			NLFJGMBCICG().SetTexture("[ItemsHandler] Found ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LAMEHAHJKMI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material FGENHBKMPDA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IGKFMCPDNOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void MGFFNGEGFDC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OCCGJMPAJIK()
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

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 673f)
			{
				HBJJOCHGOPH = 943f;
			}
			FKEOGPDLBDD().SetFloat("Editor", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("BitsData", Fade);
			KEMAALEODNH().SetFloat(" now: ", _Near);
			IIJMIPBMMBF().SetFloat("_ScreenResolution", _Far);
			NBPKMLMCHFN.SetColor(",", FogColor);
			FGENHBKMPDA().SetVector("DPADVER", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 338f, 1359f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			IONHGBPGCHK().SetTexture("Received your UserID from server. Updating local value to: {0}", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KFEKCJDEECK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material OOMFJGPAOKL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-114);
		}
		return BJFKDHHMLJH;
	}

	private void EODOHEAKJFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 133f)
			{
				HBJJOCHGOPH = 803f;
			}
			IIJMIPBMMBF().SetFloat("_SmallTex", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat(": ", Fade);
			NBMPPNFKFLB().SetFloat("gameVolume", _Near);
			JLHLHKPHDFO().SetFloat(": ", _Far);
			NLFJGMBCICG().SetColor("GlassesColor2", FogColor);
			MICHFGAOPKM().SetVector("settings.selectormapsperpage", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1654f, 1379f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			EHDJJANLINB().SetTexture(",", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material KEMAALEODNH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)101;
		}
		return BJFKDHHMLJH;
	}

	private void NPLCENPNJBM()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack/AAA_WaterDrop") as Texture2D;
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KDMKDEKCELE()
	{
		FPHEBLMINDA = Resources.Load("_Shadow") as Texture2D;
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FMFNILJIEIA()
	{
		FPHEBLMINDA = Resources.Load("shader.future") as Texture2D;
		SCShader = Shader.Find("y");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FGNFILLNPJK()
	{
	}

	private void DKOPKPBLDHH()
	{
		FPHEBLMINDA = Resources.Load("player.currentrank") as Texture2D;
		SCShader = Shader.Find("GlassDistortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1786f)
			{
				HBJJOCHGOPH = 1783f;
			}
			NBPKMLMCHFN.SetFloat("SubmitUserVote:", HBJJOCHGOPH);
			EHDJJANLINB().SetFloat("Instance\nWorking commands:\ninit or init <savepath>\npath\nsetint <key> <value>\ngetint <key> <value>\nsetfloat <key> <value>\ngetfloat <key> <value>\nsetstring <key> <value>\ngetstring <key> <value>\nsetbool <key> <value>\ngetbool <key> <value>\ndelete <key>\ndeleteall", Fade);
			EMDFHOKEGNG().SetFloat("maps.", _Near);
			NBMPPNFKFLB().SetFloat("ticket", _Far);
			HNICHJCGJOC().SetColor("ConfigVersionSlider", FogColor);
			FGENHBKMPDA().SetVector("CameraFilterPack/TV_VHS", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 175f, 249f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			NBPKMLMCHFN.SetTexture("Rap", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MICHFGAOPKM());
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

	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 340f)
			{
				HBJJOCHGOPH = 410f;
			}
			FGENHBKMPDA().SetFloat("PUNCloudBestRegion", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("EnableRankingToggle", Fade);
			IONHGBPGCHK().SetFloat("offsets", _Near);
			NFMGLIKNOOC().SetFloat("_TimeX", _Far);
			IONHGBPGCHK().SetColor("SubmitUserVote:", FogColor);
			IIJMIPBMMBF().SetVector("CameraFilterPack/Alien_Vision", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1419f, 1154f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			JLHLHKPHDFO().SetTexture("_Value2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 986f)
			{
				HBJJOCHGOPH = 631f;
			}
			FGENHBKMPDA().SetFloat("#FFDA44", HBJJOCHGOPH);
			FLOHGDECHHH().SetFloat("_Value4", Fade);
			DKNJGHFLAIF().SetFloat("Mouse1", _Near);
			HNICHJCGJOC().SetFloat("settings.arcsdestroydelay", _Far);
			CECJJMKLEAK().SetColor("_TimeX", FogColor);
			FLOHGDECHHH().SetVector("SetPosition", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 683f, 1906f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			OHKGGPFGLFD().SetTexture("SSAARenderTargetCamera", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MMOKKAPFGAK()
	{
		FPHEBLMINDA = Resources.Load("Editor") as Texture2D;
		SCShader = Shader.Find("-1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material JLHLHKPHDFO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-121);
		}
		return BJFKDHHMLJH;
	}

	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 640f)
			{
				HBJJOCHGOPH = 1287f;
			}
			NBMPPNFKFLB().SetFloat("note.1", HBJJOCHGOPH);
			HNICHJCGJOC().SetFloat("Fade", Fade);
			IIJMIPBMMBF().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", _Near);
			KEMAALEODNH().SetFloat("_ScreenResolution", _Far);
			FKEOGPDLBDD().SetColor("EditMenu", FogColor);
			ADGHJOHKEHG().SetVector("CameraFilterPack/Film_Grain", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 670f, 905f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			EMDFHOKEGNG().SetTexture("_Value2", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OOMFJGPAOKL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LMADKINICIN()
	{
	}

	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1365f)
			{
				HBJJOCHGOPH = 1174f;
			}
			IIJMIPBMMBF().SetFloat("Room: '{0}' {1},{2} {4}/{3} players.", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("Other", Fade);
			DKNJGHFLAIF().SetFloat("_Luminance", _Near);
			OOMFJGPAOKL().SetFloat("Type of observed is unknown when receiving.", _Far);
			DKNJGHFLAIF().SetColor("SfxVolumeSlider", FogColor);
			IIJMIPBMMBF().SetVector("_Gamma", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1939f, 1428f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			NBPKMLMCHFN.SetTexture("/", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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

	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 491f)
			{
				HBJJOCHGOPH = 1884f;
			}
			OOMFJGPAOKL().SetFloat("menu.relaxinfo", HBJJOCHGOPH);
			IIBLJCKLGFG().SetFloat("AreaTex", Fade);
			KEMAALEODNH().SetFloat("addNewButton", _Near);
			OHKGGPFGLFD().SetFloat("_Value", _Far);
			IIBLJCKLGFG().SetColor("JoinRandomRoom failed. In offline mode you still have to leave a room to enter another.", FogColor);
			NBPKMLMCHFN.SetVector("IconFileSelector", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1588f, 1533f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			NLFJGMBCICG().SetTexture("_EmissionGain", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OHKGGPFGLFD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HNILMGEKDEC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KOJKBFDNGDK()
	{
		FPHEBLMINDA = Resources.Load("PhotonView with ID ") as Texture2D;
		SCShader = Shader.Find("Vertical");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DLBODOFAJGM()
	{
		FPHEBLMINDA = Resources.Load("SetSpeed") as Texture2D;
		SCShader = Shader.Find("SetParticlesEmission");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material FLOHGDECHHH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void LCJHDLKJEOM()
	{
	}

	private void IIFCIDDJHPM()
	{
	}

	private void PLIKADJCEPO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OPCLBGHAPMG()
	{
	}

	private void DFFKKLAPHCC()
	{
		FPHEBLMINDA = Resources.Load(".status") as Texture2D;
		SCShader = Shader.Find("_MaxBlurRadius");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DNENFLNCIJP()
	{
	}

	private void KMOCDAOKGLI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LFAFJKJAEEL()
	{
		FPHEBLMINDA = Resources.Load("/") as Texture2D;
		SCShader = Shader.Find("_BlurVector");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LDDKCCMHMIC()
	{
	}

	private void PKBENONAOOL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ILCFPCIPENO()
	{
		FPHEBLMINDA = Resources.Load("speed") as Texture2D;
		SCShader = Shader.Find("ConnectToMaster() failed. Can only connect while in state 'Disconnected'. Current state: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LBAJLLFMMMP()
	{
		FPHEBLMINDA = Resources.Load("Winter2020") as Texture2D;
		SCShader = Shader.Find("_PosX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LBPCODPOJAH()
	{
	}

	[SpecialName]
	private Material OHKGGPFGLFD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)79;
		}
		return BJFKDHHMLJH;
	}

	private void IHHNCCOGLPN()
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
			if (HBJJOCHGOPH > 1932f)
			{
				HBJJOCHGOPH = 936f;
			}
			IIBLJCKLGFG().SetFloat("_EmissionColor", HBJJOCHGOPH);
			FLOHGDECHHH().SetFloat("/../", Fade);
			OHKGGPFGLFD().SetFloat("RecieveChatActionMessage", _Near);
			NLFJGMBCICG().SetFloat("_Intensity", _Far);
			DKNJGHFLAIF().SetColor("_TimeX", FogColor);
			EMDFHOKEGNG().SetVector("Gameplay/Base", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 814f, 1613f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			NFMGLIKNOOC().SetTexture("ResourceFileSelector", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material EHDJJANLINB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-110);
		}
		return BJFKDHHMLJH;
	}

	private void ONMGIPAILOH()
	{
	}

	[SpecialName]
	private Material EMDFHOKEGNG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
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

	[SpecialName]
	private Material IONHGBPGCHK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)115;
		}
		return BJFKDHHMLJH;
	}

	private void IFJDKDFLGBG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MGMAOBPPOBJ()
	{
		FPHEBLMINDA = Resources.Load("_ScreenResolution") as Texture2D;
		SCShader = Shader.Find("SlidingArea");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AKHCOBHHGJP()
	{
		FPHEBLMINDA = Resources.Load("#") as Texture2D;
		SCShader = Shader.Find("SpectateButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GNMGIHFKJIJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material NBMPPNFKFLB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1741f)
			{
				HBJJOCHGOPH = 1488f;
			}
			NLFJGMBCICG().SetFloat("settings.fps", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("Room: '{0}' {1},{2} {4}/{3} players.", Fade);
			NBMPPNFKFLB().SetFloat("_TimeX", _Near);
			FGENHBKMPDA().SetFloat("Gameplay/Base", _Far);
			NLFJGMBCICG().SetColor("_Value4", FogColor);
			EMDFHOKEGNG().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1071f, 1755f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			FEAEGGCNIAA().SetTexture(" - ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CECJJMKLEAK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GNPDGBNDCPL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1105f)
			{
				HBJJOCHGOPH = 1510f;
			}
			IONHGBPGCHK().SetFloat("sprite", HBJJOCHGOPH);
			JLHLHKPHDFO().SetFloat("Connection error: ", Fade);
			IGKFMCPDNOI().SetFloat("CameraFilterPack/FX_Scan", _Near);
			MICHFGAOPKM().SetFloat("_Color2", _Far);
			IIJMIPBMMBF().SetColor("plainText", FogColor);
			FKEOGPDLBDD().SetVector("#{0:00} '{1}'{2} {3}", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 819f, 1763f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			FKEOGPDLBDD().SetTexture("[LocalizationService] All keys for ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CCFEDENFNEF()
	{
		FPHEBLMINDA = Resources.Load("_Value5") as Texture2D;
		SCShader = Shader.Find("_BlurRadius4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 687f)
			{
				HBJJOCHGOPH = 934f;
			}
			NFMGLIKNOOC().SetFloat("2;13;14;15;16", HBJJOCHGOPH);
			NLFJGMBCICG().SetFloat("0.00", Fade);
			NFMGLIKNOOC().SetFloat("CameraFilterPack/BlurTiltShift_Hole", _Near);
			ADGHJOHKEHG().SetFloat("steamid", _Far);
			MICHFGAOPKM().SetColor("CameraFilterPack/Glasses_On", FogColor);
			IIJMIPBMMBF().SetVector("RECORD [R]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1542f, 417f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			OHKGGPFGLFD().SetTexture(": ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material CECJJMKLEAK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-87);
		}
		return BJFKDHHMLJH;
	}

	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1329f)
			{
				HBJJOCHGOPH = 121f;
			}
			OOMFJGPAOKL().SetFloat("_History2ChromaTex", HBJJOCHGOPH);
			CECJJMKLEAK().SetFloat("CameraFilterPack/TV_Vcr", Fade);
			FGENHBKMPDA().SetFloat("_Value5", _Near);
			IGKFMCPDNOI().SetFloat("_RGB", _Far);
			OHKGGPFGLFD().SetColor("_Value", FogColor);
			JLHLHKPHDFO().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 526f, 123f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			NLFJGMBCICG().SetTexture("_FixDistance", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MJEFMIPLFAB()
	{
		FPHEBLMINDA = Resources.Load("Hidden/ScreenSpaceReflection") as Texture2D;
		SCShader = Shader.Find("[Up]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material FEAEGGCNIAA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.HideInHierarchy;
		}
		return BJFKDHHMLJH;
	}

	private void Update()
	{
	}

	private void OBAEDJJDCPN()
	{
	}

	private void EDBEHEKMGFH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KDJEJBBDILE()
	{
	}

	private void Start()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_Atmosphere_Rain_FX") as Texture2D;
		SCShader = Shader.Find("CameraFilterPack/Atmosphere_Fog");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FEKECCBFGMI()
	{
		FPHEBLMINDA = Resources.Load("CameraFilterPack_TV_BrokenGlass1") as Texture2D;
		SCShader = Shader.Find(":");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material ADGHJOHKEHG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	private void HLLHJIDOOGA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
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
}
