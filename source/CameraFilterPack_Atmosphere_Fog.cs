// CameraFilterPack_Atmosphere_Fog
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Weather/Fog")]
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
			EMDFHOKEGNG().SetFloat("NEW", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("\t", Fade);
			NFMGLIKNOOC().SetFloat("_TimeX", _Near);
			FLOHGDECHHH().SetFloat("MenuScene", _Far);
			JLHLHKPHDFO().SetColor("skin.hit_wrong", FogColor);
			JLHLHKPHDFO().SetVector("Object ID. Case-Sensitive", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1412f, 1330f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			CECJJMKLEAK().SetTexture("_Offsets", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
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
			DKNJGHFLAIF().SetFloat("<b>#", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("float,0", Fade);
			FGENHBKMPDA().SetFloat("float,10", _Near);
			OOMFJGPAOKL().SetFloat("EventData0DropDownList", _Far);
			EMDFHOKEGNG().SetColor("EventSystem", FogColor);
			OOMFJGPAOKL().SetVector("Items", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1733f, 1385f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			FLOHGDECHHH().SetTexture("_ScreenResolution", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
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
			NFMGLIKNOOC().SetFloat("Rock", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("x", Fade);
			FLOHGDECHHH().SetFloat("SetSatelliteInput", _Near);
			IIBLJCKLGFG().SetFloat("?", _Far);
			FEAEGGCNIAA().SetColor("_Fade", FogColor);
			NBPKMLMCHFN.SetVector("_Green_C", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1111f, 1430f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			FKEOGPDLBDD().SetTexture(".completedCount", FPHEBLMINDA);
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
			DKNJGHFLAIF().SetFloat("SetSunMinSize", HBJJOCHGOPH);
			JLHLHKPHDFO().SetFloat("RecordButton", Fade);
			NBPKMLMCHFN.SetFloat("id", _Near);
			KEMAALEODNH().SetFloat(" SphereWaveform.cs", _Far);
			IGKFMCPDNOI().SetColor("_Value4", FogColor);
			EMDFHOKEGNG().SetVector("_ProjInfo", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 159f, 1703f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			EMDFHOKEGNG().SetTexture("note.1", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIBLJCKLGFG());
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
			DKNJGHFLAIF().SetFloat("_Near", HBJJOCHGOPH);
			FLOHGDECHHH().SetFloat("[PlayerController] ", Fade);
			IGKFMCPDNOI().SetFloat(".", _Near);
			FGENHBKMPDA().SetFloat("Error: you cannot write/send to this stream that you are reading!", _Far);
			OOMFJGPAOKL().SetColor("[MapsData] Caching ", FogColor);
			IIBLJCKLGFG().SetVector("(\\[ */ *i *\\])", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1756f, 1034f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			IIBLJCKLGFG().SetTexture("Gameplay/sun", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
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
			FGENHBKMPDA().SetFloat("System.Single", HBJJOCHGOPH);
			FEAEGGCNIAA().SetFloat("_VignettingDirt", Fade);
			EHDJJANLINB().SetFloat("</size>", _Near);
			NFMGLIKNOOC().SetFloat("Achievement 21 progress reseted", _Far);
			FLOHGDECHHH().SetColor("IEnumerable", FogColor);
			FLOHGDECHHH().SetVector("id", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 579f, 95f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			FKEOGPDLBDD().SetTexture("SpawnObj", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNICHJCGJOC());
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
		FPHEBLMINDA = Resources.Load("_ScreenResolution") as Texture2D;
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
		FPHEBLMINDA = Resources.Load("_TexelOffsetScale") as Texture2D;
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
			NBPKMLMCHFN.SetFloat("0,1,false", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("_Saturation", Fade);
			NBMPPNFKFLB().SetFloat("_ScreenResolution", _Near);
			IIBLJCKLGFG().SetFloat("ItemsCountText", _Far);
			IIJMIPBMMBF().SetColor("2", FogColor);
			NLFJGMBCICG().SetVector("ComboText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 756f, 737f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			CECJJMKLEAK().SetTexture("NameText", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FEAEGGCNIAA());
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
			JLHLHKPHDFO().SetFloat("Mouse X", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("IntraSig", Fade);
			DKNJGHFLAIF().SetFloat("AVG Misses:", _Near);
			KEMAALEODNH().SetFloat("Object ID. Case-Sensitive", _Far);
			OOMFJGPAOKL().SetColor("_Near", FogColor);
			FLOHGDECHHH().SetVector("\\\"", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1830f, 43f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			IGKFMCPDNOI().SetTexture("EventData0DropDownList", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OOMFJGPAOKL());
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
			IGKFMCPDNOI().SetFloat(" has been disabled as it's not supported on the current platform.", HBJJOCHGOPH);
			OOMFJGPAOKL().SetFloat("ItemNameText", Fade);
			NBPKMLMCHFN.SetFloat("[PlayerBase] Unknown event: ", _Near);
			KEMAALEODNH().SetFloat("CameraFilterPack/Blend2Camera_ColorDodge", _Far);
			FEAEGGCNIAA().SetColor("Run a command for data system", FogColor);
			JLHLHKPHDFO().SetVector("Hip-hop", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 866f, 399f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			FEAEGGCNIAA().SetTexture("CameraFilterPack/TV_MovieNoise", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
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
		FPHEBLMINDA = Resources.Load("_PositionY") as Texture2D;
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
			MICHFGAOPKM().SetFloat("PRESS A KEY", HBJJOCHGOPH);
			IONHGBPGCHK().SetFloat("SetParticlesParticleSize", Fade);
			JLHLHKPHDFO().SetFloat(" Server: ", _Near);
			IIJMIPBMMBF().SetFloat("CameraFilterPack/Blend2Camera_LinearLight", _Far);
			DKNJGHFLAIF().SetColor("[PlayerBase] Loaded spawner data", FogColor);
			CECJJMKLEAK().SetVector("AudioSampler", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 938f, 1421f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			ADGHJOHKEHG().SetTexture("Authentication failed: '{0}' Code: {1}", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FGENHBKMPDA());
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
		FPHEBLMINDA = Resources.Load(",") as Texture2D;
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
			CECJJMKLEAK().SetFloat("SetSunMaxSize", HBJJOCHGOPH);
			CECJJMKLEAK().SetFloat("CameraFilterPack/Glasses_On", Fade);
			KEMAALEODNH().SetFloat("_Value4", _Near);
			JLHLHKPHDFO().SetFloat("_ExtraColor", _Far);
			FGENHBKMPDA().SetColor("HPToggle", FogColor);
			EMDFHOKEGNG().SetVector("tagElement", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1367f, 900f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			IIBLJCKLGFG().SetTexture("|", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
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
			IIBLJCKLGFG().SetFloat("\nCreated by Oxy949", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("BitsData", Fade);
			IIBLJCKLGFG().SetFloat(" (now: ", _Near);
			CECJJMKLEAK().SetFloat("_Fade", _Far);
			FKEOGPDLBDD().SetColor(",", FogColor);
			EMDFHOKEGNG().SetVector("DPADHOR", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 338f, 1359f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			FKEOGPDLBDD().SetTexture("The used master server address is not available with the subscription currently used. Got to Photon Cloud Dashboard or change URL. Disconnecting.", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
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
			FKEOGPDLBDD().SetFloat("_AdaptionSpeed", HBJJOCHGOPH);
			OOMFJGPAOKL().SetFloat("[PlayerController] ", Fade);
			MICHFGAOPKM().SetFloat("editorVolume", _Near);
			IIJMIPBMMBF().SetFloat(": ", _Far);
			CECJJMKLEAK().SetColor("GlassesColor", FogColor);
			FLOHGDECHHH().SetVector("settings.enablehitsoundsinnormal", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1654f, 1379f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			EHDJJANLINB().SetTexture(".GoalProgress", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NLFJGMBCICG());
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
		SCShader = Shader.Find("CameraFilterPack/Colors_Threshold");
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
		SCShader = Shader.Find("w");
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
		SCShader = Shader.Find("VisionBlur");
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
			FLOHGDECHHH().SetFloat("?", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("Instance\nWorking commands:\ninit or init <savepath>\npath\nsetint <key> <value>\ngetint <key> <value>\nsetfloat <key> <value>\ngetfloat <key> <value>\nsetstring <key> <value>\ngetstring <key> <value>\nsetbool <key> <value>\ngetbool <key> <value>\ndelete <key>\ndeleteall", Fade);
			NFMGLIKNOOC().SetFloat("maps.", _Near);
			FGENHBKMPDA().SetFloat("#close", _Far);
			EHDJJANLINB().SetColor("SpeedSlider", FogColor);
			NBMPPNFKFLB().SetVector("_Distortion", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 175f, 249f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			IIBLJCKLGFG().SetTexture("Pop", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADGHJOHKEHG());
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
			NBMPPNFKFLB().SetFloat("NetworkPeer broke!", HBJJOCHGOPH);
			FKEOGPDLBDD().SetFloat("EnableRankingToggle", Fade);
			OOMFJGPAOKL().SetFloat("offsets", _Near);
			IIBLJCKLGFG().SetFloat("CameraFilterPack/Color_YUV", _Far);
			EHDJJANLINB().SetColor("?", FogColor);
			NBMPPNFKFLB().SetVector("CameraFilterPack/Alien_Vision", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1419f, 1154f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			ADGHJOHKEHG().SetTexture("_Value", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
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
			MICHFGAOPKM().SetFloat("#EA4137", HBJJOCHGOPH);
			FEAEGGCNIAA().SetFloat("_Value4", Fade);
			NBPKMLMCHFN.SetFloat("Mouse0", _Near);
			HNICHJCGJOC().SetFloat("ArcsDestroyDelaySlider", _Far);
			JLHLHKPHDFO().SetColor("_TimeX", FogColor);
			FGENHBKMPDA().SetVector("SetPosition", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 683f, 1906f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			NBPKMLMCHFN.SetTexture("Screenshots only supported in PlayMode", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MMOKKAPFGAK()
	{
		FPHEBLMINDA = Resources.Load("LoadMapCanvas") as Texture2D;
		SCShader = Shader.Find("#ok");
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
			JLHLHKPHDFO().SetFloat("#outdatedmap! Challenges will not work!", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("UseFinalGlassColor", Fade);
			NFMGLIKNOOC().SetFloat("Vertical", _Near);
			EMDFHOKEGNG().SetFloat("_Value", _Far);
			ADGHJOHKEHG().SetColor("EditMenu", FogColor);
			OOMFJGPAOKL().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 670f, 905f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			MICHFGAOPKM().SetTexture("_Value", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JLHLHKPHDFO());
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
			IGKFMCPDNOI().SetFloat("open", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("Other", Fade);
			IIBLJCKLGFG().SetFloat("_AxialAberration", _Near);
			FLOHGDECHHH().SetFloat("PUN-instantiated '", _Far);
			NBMPPNFKFLB().SetColor("menu.enableselectormusic", FogColor);
			KEMAALEODNH().SetVector("_WhiteBalance", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1939f, 1428f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			FGENHBKMPDA().SetTexture("NewIconFileSelector", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FKEOGPDLBDD());
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
			IIJMIPBMMBF().SetFloat("menu.relaxinfo", HBJJOCHGOPH);
			CECJJMKLEAK().SetFloat("Hidden/Subpixel Morphological Anti-aliasing", Fade);
			IIBLJCKLGFG().SetFloat("Events Moved", _Near);
			NFMGLIKNOOC().SetFloat("_Value", _Far);
			KEMAALEODNH().SetColor("JoinOrCreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", FogColor);
			IONHGBPGCHK().SetVector("IconFileSelector", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1588f, 1533f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			JLHLHKPHDFO().SetTexture("[Down]", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IONHGBPGCHK());
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
		FPHEBLMINDA = Resources.Load(" has no method \"") as Texture2D;
		SCShader = Shader.Find("name");
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
		FPHEBLMINDA = Resources.Load("challenges.") as Texture2D;
		SCShader = Shader.Find("Hidden/Image Effects/Cinematic/MotionBlur/Reconstruction");
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
		FPHEBLMINDA = Resources.Load("#done") as Texture2D;
		SCShader = Shader.Find("_OcclusionBlurTexture");
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
		SCShader = Shader.Find("ConnectUsingSettings() disabled the offline mode. No longer offline.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LBAJLLFMMMP()
	{
		FPHEBLMINDA = Resources.Load("/GetNews/pinnednewsid") as Texture2D;
		SCShader = Shader.Find("_ExtraColor");
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
			OHKGGPFGLFD().SetFloat("/", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("OPEN", Fade);
			IIBLJCKLGFG().SetFloat("RecieveChatActionMessage", _Near);
			IIBLJCKLGFG().SetFloat("_Distortion", _Far);
			HNICHJCGJOC().SetColor("CameraFilterPack_Sweater", FogColor);
			IONHGBPGCHK().SetVector("Gameplay/Base", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 814f, 1613f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			EMDFHOKEGNG().SetTexture("ResourceIDInputField", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
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
		FPHEBLMINDA = Resources.Load("_Size") as Texture2D;
		SCShader = Shader.Find("ScrollPanel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AKHCOBHHGJP()
	{
		FPHEBLMINDA = Resources.Load(">") as Texture2D;
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
			OHKGGPFGLFD().SetFloat("settings.shaders.bloomintencity", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("Can't set MaxPlayers when not in that room.", Fade);
			FGENHBKMPDA().SetFloat("_MainTex2", _Near);
			EHDJJANLINB().SetFloat("Gameplay/Base", _Far);
			FEAEGGCNIAA().SetColor("_Value3", FogColor);
			NLFJGMBCICG().SetVector("Fade", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1071f, 1755f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			NFMGLIKNOOC().SetTexture("?", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			FKEOGPDLBDD().SetFloat("[PlayerBase] MapEnd error: ", HBJJOCHGOPH);
			FGENHBKMPDA().SetFloat("</color>", Fade);
			FGENHBKMPDA().SetFloat("_Distortion", _Near);
			CECJJMKLEAK().SetFloat("_Color2", _Far);
			OOMFJGPAOKL().SetColor(" BETA", FogColor);
			FGENHBKMPDA().SetVector(" ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 819f, 1763f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			FKEOGPDLBDD().SetTexture(" key(s)", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CCFEDENFNEF()
	{
		FPHEBLMINDA = Resources.Load("_Value5") as Texture2D;
		SCShader = Shader.Find("_SunThreshold");
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
			OOMFJGPAOKL().SetFloat("5;6;7;8;11;12;18;19;20;22x6;44x1", HBJJOCHGOPH);
			CECJJMKLEAK().SetFloat("resource", Fade);
			OOMFJGPAOKL().SetFloat("_MainTex2", _Near);
			OHKGGPFGLFD().SetFloat("appid", _Far);
			FKEOGPDLBDD().SetColor("CameraFilterPack_Glasses_On6", FogColor);
			ADGHJOHKEHG().SetVector("MenuRecordButton", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1542f, 417f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			DKNJGHFLAIF().SetTexture(": ", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
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
			IGKFMCPDNOI().SetFloat("_History4LumaTex", HBJJOCHGOPH);
			FEAEGGCNIAA().SetFloat("_ScreenResolution", Fade);
			NBMPPNFKFLB().SetFloat("_Value5", _Near);
			FKEOGPDLBDD().SetFloat("_TimeX", _Far);
			JLHLHKPHDFO().SetColor("_TimeX", FogColor);
			IIBLJCKLGFG().SetVector("CameraFilterPack/Color_Switching", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 526f, 123f));
			GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			FKEOGPDLBDD().SetTexture("_FixDistance", FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MJEFMIPLFAB()
	{
		FPHEBLMINDA = Resources.Load("_History3Weight") as Texture2D;
		SCShader = Shader.Find("[Down]");
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
		FPHEBLMINDA = Resources.Load("_ScreenResolution") as Texture2D;
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
