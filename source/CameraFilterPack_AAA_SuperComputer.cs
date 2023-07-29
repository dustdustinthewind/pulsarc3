// CameraFilterPack_AAA_SuperComputer
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/AAA/Super Computer")]
[ExecuteInEditMode]
public class CameraFilterPack_AAA_SuperComputer : MonoBehaviour
{
	public Shader SCShader;

	[Range(0f, 1f)]
	public float _AlphaHexa = 1f;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(-20f, 20f)]
	public float ShapeFormula = 10f;

	[Range(0f, 6f)]
	public float Shape = 1f;

	[Range(-4f, 4f)]
	public float _BorderSize = 1f;

	public Color _BorderColor = new Color(0f, 0.2f, 1f, 1f);

	public float _SpotSize = 2.5f;

	public Vector2 center = new Vector2(0f, 0f);

	public float Radius = 0.77f;

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
	private Material EJDPNJAEAKJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void COIJKMKIEAK()
	{
		SCShader = Shader.Find("player.licenceaccepted");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime / 1110f;
			if (HBJJOCHGOPH > 340f)
			{
				HBJJOCHGOPH = 1760f;
			}
			PDEAHJPOMEF().SetFloat("_Exposure", HBJJOCHGOPH);
			KEMJNOMIPHN().SetFloat("There are too many cells created by your subdivision options. Maximum allowed number of cells is ", ShapeFormula);
			HKHBBBFLGJH().SetFloat(" argument(s): ", Shape);
			NBPKMLMCHFN.SetFloat("Update() was called by Unity. Scene is loaded. Let's connect to the Photon Master Server. Calling: PhotonNetwork.ConnectUsingSettings();", center.x);
			NBPKMLMCHFN.SetFloat("Cannot remove cached RPCs on a PhotonView thats not ours! ", center.y);
			KEMJNOMIPHN().SetFloat("null", Radius);
			CFCPHFMKHII().SetFloat("EventTimeInputField", _BorderSize);
			NBPKMLMCHFN.SetColor("PointerExit ", _BorderColor);
			IGKFMCPDNOI().SetFloat("float", _AlphaHexa);
			EJDPNJAEAKJ().SetFloat("/../", _SpotSize);
			HNICHJCGJOC().SetVector("&page=", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 343f, 753f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DAHFFNNIGML()
	{
		SCShader = Shader.Find("InfoCanvas");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FPHLDMMAOEF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FIKFJDFELIP()
	{
		SCShader = Shader.Find("22x3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MMBPLGGLPDB()
	{
	}

	[SpecialName]
	private Material HKHBBBFLGJH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideAndDontSave | HideFlags.HideInInspector);
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

	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime / 1823f;
			if (HBJJOCHGOPH > 6f)
			{
				HBJJOCHGOPH = 1669f;
			}
			NFMGLIKNOOC().SetFloat("table", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("RecordButton", ShapeFormula);
			ABHDNGIHBKE().SetFloat("-1", Shape);
			GJHLADDCMFF().SetFloat(") of this PhotonView does not implement OnPhotonSerializeView()!", center.x);
			HNICHJCGJOC().SetFloat("MultiplayerButton", center.y);
			CFCPHFMKHII().SetFloat("_TimeX", Radius);
			ABHDNGIHBKE().SetFloat("[LocalizationService] Loading file: ", _BorderSize);
			OGMEGHKECAH().SetColor("Joined room ", _BorderColor);
			HKHBBBFLGJH().SetFloat("_Green_C", _AlphaHexa);
			DOHGBNPMBKG().SetFloat("_Screen", _SpotSize);
			NBPKMLMCHFN.SetVector("_DiffuseColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1129f, 209f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime / 765f;
			if (HBJJOCHGOPH > 140f)
			{
				HBJJOCHGOPH = 46f;
			}
			NFMGLIKNOOC().SetFloat("Committing changes...", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("SetSunEmission", ShapeFormula);
			HHIAIGCAHDA().SetFloat("Source: ", Shape);
			OGMEGHKECAH().SetFloat("0.00", center.x);
			HKHBBBFLGJH().SetFloat("_Distortion", center.y);
			HKHBBBFLGJH().SetFloat("UseScanLine", Radius);
			CFCPHFMKHII().SetFloat("Joystick1Button4", _BorderSize);
			EJDPNJAEAKJ().SetColor("<b>", _BorderColor);
			HHIAIGCAHDA().SetFloat("_TimeX", _AlphaHexa);
			NBPKMLMCHFN.SetFloat("getfloat", _SpotSize);
			DOHGBNPMBKG().SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 553f, 134f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
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
			HBJJOCHGOPH += Time.deltaTime / 4f;
			if (HBJJOCHGOPH > 100f)
			{
				HBJJOCHGOPH = 0f;
			}
			NBPKMLMCHFN.SetFloat("_TimeX", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value", ShapeFormula);
			NBPKMLMCHFN.SetFloat("_Value2", Shape);
			NBPKMLMCHFN.SetFloat("_PositionX", center.x);
			NBPKMLMCHFN.SetFloat("_PositionY", center.y);
			NBPKMLMCHFN.SetFloat("_Radius", Radius);
			NBPKMLMCHFN.SetFloat("_BorderSize", _BorderSize);
			NBPKMLMCHFN.SetColor("_BorderColor", _BorderColor);
			NBPKMLMCHFN.SetFloat("_AlphaHexa", _AlphaHexa);
			NBPKMLMCHFN.SetFloat("_SpotSize", _SpotSize);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IFIHBNJKEKD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material GJHLADDCMFF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)118;
		}
		return BJFKDHHMLJH;
	}

	private void AAPKBNDHBLI()
	{
	}

	[SpecialName]
	private Material EFDEIFCDAFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void KLILJHJNICK()
	{
		SCShader = Shader.Find("[ResourcesManager] Load image error: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material NFMGLIKNOOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)91;
		}
		return BJFKDHHMLJH;
	}

	private void MMMDPANNAIO()
	{
		SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime / 138f;
			if (HBJJOCHGOPH > 721f)
			{
				HBJJOCHGOPH = 836f;
			}
			EJDPNJAEAKJ().SetFloat("PUNCloudBestRegion", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("settings.showHP", ShapeFormula);
			OGMEGHKECAH().SetFloat("_TileTexDebug", Shape);
			DOHGBNPMBKG().SetFloat("[PlayerBase] Loaded custom model: ", center.x);
			HKHBBBFLGJH().SetFloat("appid", center.y);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Blend2Camera_DarkerColor", Radius);
			KEMJNOMIPHN().SetFloat("ItemsCountText", _BorderSize);
			ABHDNGIHBKE().SetColor("Set Particles Count Per Beat", _BorderColor);
			HKHBBBFLGJH().SetFloat("ConfigVersionSlider", _AlphaHexa);
			PDEAHJPOMEF().SetFloat("_History1ChromaTex", _SpotSize);
			IGKFMCPDNOI().SetVector("Can't connect: ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1731f, 451f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DPIPGGDNGHN()
	{
	}

	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime / 1243f;
			if (HBJJOCHGOPH > 154f)
			{
				HBJJOCHGOPH = 1305f;
			}
			OGMEGHKECAH().SetFloat("_Value3", HBJJOCHGOPH);
			IGKFMCPDNOI().SetFloat("#changenote", ShapeFormula);
			EFDEIFCDAFG().SetFloat("SpectatingUserInfo", Shape);
			OGMEGHKECAH().SetFloat("BitsData", center.x);
			CFCPHFMKHII().SetFloat("_Speed", center.y);
			KEMJNOMIPHN().SetFloat("_Value", Radius);
			KEMJNOMIPHN().SetFloat("_ScreenResolution", _BorderSize);
			EJDPNJAEAKJ().SetColor("CameraFilterPack/FX_8bits", _BorderColor);
			DOHGBNPMBKG().SetFloat("{0:0}", _AlphaHexa);
			ABHDNGIHBKE().SetFloat("win", _SpotSize);
			ABHDNGIHBKE().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1572f, 1466f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MKIMDFLBFOM()
	{
		SCShader = Shader.Find("itemdefid[0]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material CFCPHFMKHII()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-93);
		}
		return BJFKDHHMLJH;
	}

	private void AEEGKLABFLN()
	{
	}

	private void LMBDNPLDGIJ()
	{
	}

	private void GKNKIIEALCH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material ABHDNGIHBKE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return BJFKDHHMLJH;
	}

	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime / 1803f;
			if (HBJJOCHGOPH > 435f)
			{
				HBJJOCHGOPH = 77f;
			}
			OGMEGHKECAH().SetFloat("FPSToggle", HBJJOCHGOPH);
			HHIAIGCAHDA().SetFloat(": ", ShapeFormula);
			EJDPNJAEAKJ().SetFloat("LevelURLInputField", Shape);
			CFCPHFMKHII().SetFloat("Object ID. Case-Sensitive", center.x);
			PDEAHJPOMEF().SetFloat("Finished", center.y);
			HHIAIGCAHDA().SetFloat("GhostPosY", Radius);
			NBPKMLMCHFN.SetFloat("[Right-Down-Left]", _BorderSize);
			CFCPHFMKHII().SetColor("EnvironmentSlider", _BorderColor);
			CFCPHFMKHII().SetFloat(":\n", _AlphaHexa);
			PDEAHJPOMEF().SetFloat("_TimeX", _SpotSize);
			HKHBBBFLGJH().SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 191f, 1113f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CIPKEPDELJB()
	{
		SCShader = Shader.Find("settings.enablehitsoundsinrelax");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EDBEHEKMGFH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JBCNIPJDPJB()
	{
	}

	private void IIFCIDDJHPM()
	{
	}

	private void HONBLGFDMLL()
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

	private void Update()
	{
	}

	[SpecialName]
	private Material HHIAIGCAHDA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-78);
		}
		return BJFKDHHMLJH;
	}

	private void OCMKCBBCEFG()
	{
	}

	private void BGFJOEPFOPM()
	{
	}

	private void LJIHHJOAJCN()
	{
	}

	[SpecialName]
	private Material HNICHJCGJOC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-89);
		}
		return BJFKDHHMLJH;
	}

	private void JHPOIOELNCG()
	{
	}

	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime / 627f;
			if (HBJJOCHGOPH > 377f)
			{
				HBJJOCHGOPH = 553f;
			}
			ABHDNGIHBKE().SetFloat("CameraFilterPack/FX_Dot_Circle", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("Start index must in an integer.", ShapeFormula);
			NFMGLIKNOOC().SetFloat("Children", Shape);
			HHIAIGCAHDA().SetFloat("_Value2", center.x);
			GJHLADDCMFF().SetFloat("menuthemes", center.y);
			OGMEGHKECAH().SetFloat("_FixDistance", Radius);
			OGMEGHKECAH().SetFloat("0.00", _BorderSize);
			CFCPHFMKHII().SetColor("[#clicktogetreward]", _BorderColor);
			HNICHJCGJOC().SetFloat("_copy", _AlphaHexa);
			PDEAHJPOMEF().SetFloat("hitsounds:", _SpotSize);
			NBPKMLMCHFN.SetVector(".completedMaps", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 307f, 1002f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ANCKKLFPGDI()
	{
		SCShader = Shader.Find("CreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime / 22f;
			if (HBJJOCHGOPH > 179f)
			{
				HBJJOCHGOPH = 685f;
			}
			HNICHJCGJOC().SetFloat("[MenuScene] Error: ", HBJJOCHGOPH);
			NFMGLIKNOOC().SetFloat("https://www.youtube.com/watch?v=cDVXukrKo74", ShapeFormula);
			ABHDNGIHBKE().SetFloat("[RanksSystem] Ranks: no need to update", Shape);
			HNICHJCGJOC().SetFloat("Set satellite trail width", center.x);
			EFDEIFCDAFG().SetFloat("PRESS A KEY", center.y);
			HHIAIGCAHDA().SetFloat("x", Radius);
			HHIAIGCAHDA().SetFloat("_TimeX", _BorderSize);
			IGKFMCPDNOI().SetColor("_TexelOffsetScale", _BorderColor);
			EFDEIFCDAFG().SetFloat("#onrankchangedowntext", _AlphaHexa);
			KEMJNOMIPHN().SetFloat("CameraFilterPack_OldFilm2", _SpotSize);
			NFMGLIKNOOC().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 437f, 1077f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFCPHFMKHII());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AIJGAJIOJDJ()
	{
	}

	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime / 1360f;
			if (HBJJOCHGOPH > 433f)
			{
				HBJJOCHGOPH = 1475f;
			}
			IGKFMCPDNOI().SetFloat(" not exist", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("#no", ShapeFormula);
			GJHLADDCMFF().SetFloat("CameraFilterPack_AAA_Blood_Hit1", Shape);
			NFMGLIKNOOC().SetFloat("_Value4", center.x);
			GJHLADDCMFF().SetFloat("materialsquantity[", center.y);
			IGKFMCPDNOI().SetFloat("InfoText", Radius);
			HNICHJCGJOC().SetFloat("Reconnect() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", _BorderSize);
			HNICHJCGJOC().SetColor(". The group number should be at least 1.", _BorderColor);
			NFMGLIKNOOC().SetFloat("Items/", _AlphaHexa);
			CFCPHFMKHII().SetFloat("AvatarImage", _SpotSize);
			KEMJNOMIPHN().SetVector("(\\[ */ *quote *\\])", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1577f, 1309f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime / 1432f;
			if (HBJJOCHGOPH > 1637f)
			{
				HBJJOCHGOPH = 682f;
			}
			NFMGLIKNOOC().SetFloat("_Speed", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("</color>", ShapeFormula);
			HHIAIGCAHDA().SetFloat("CameraFilterPack/Blend2Camera_HardLight", Shape);
			EFDEIFCDAFG().SetFloat("https://steamcommunity.com/sharedfiles/filedetails/?id=", center.x);
			OGMEGHKECAH().SetFloat("ViewMenu", center.y);
			PDEAHJPOMEF().SetFloat("Chat", Radius);
			ABHDNGIHBKE().SetFloat("SelectorMapsCountSlider", _BorderSize);
			IGKFMCPDNOI().SetColor("\n", _BorderColor);
			OGMEGHKECAH().SetFloat("Hidden/Subpixel Morphological Anti-aliasing", _AlphaHexa);
			EJDPNJAEAKJ().SetFloat("There was an error retrieving the NumberOfCurrentPlayers.", _SpotSize);
			IGKFMCPDNOI().SetVector("CameraFilterPack/AAA_Blood_Plus", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 85f, 166f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material IGKFMCPDNOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime / 1658f;
			if (HBJJOCHGOPH > 1639f)
			{
				HBJJOCHGOPH = 1615f;
			}
			HKHBBBFLGJH().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			HKHBBBFLGJH().SetFloat("EventConfigButton", ShapeFormula);
			PDEAHJPOMEF().SetFloat("ScrollPanel", Shape);
			OGMEGHKECAH().SetFloat("_Intensity", center.x);
			HKHBBBFLGJH().SetFloat("OPEN", center.y);
			HKHBBBFLGJH().SetFloat("_Noise", Radius);
			IGKFMCPDNOI().SetFloat("_Value2", _BorderSize);
			IGKFMCPDNOI().SetColor("<color=#", _BorderColor);
			EJDPNJAEAKJ().SetFloat("MenuScene", _AlphaHexa);
			ABHDNGIHBKE().SetFloat("[MapsStats] Max score: ", _SpotSize);
			EJDPNJAEAKJ().SetVector("CameraFilterPack/TV_Video3D", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1777f, 652f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFCPHFMKHII());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NDAJBJFJGCF()
	{
	}

	private void FOMNCPKKCFN()
	{
	}

	[SpecialName]
	private Material KEMJNOMIPHN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void KMKLDAJLCNM()
	{
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-119);
		}
		return BJFKDHHMLJH;
	}

	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime / 1525f;
			if (HBJJOCHGOPH > 269f)
			{
				HBJJOCHGOPH = 601f;
			}
			HKHBBBFLGJH().SetFloat("Solo", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("ready", ShapeFormula);
			EJDPNJAEAKJ().SetFloat("settings_bindings_controller_type", Shape);
			IGKFMCPDNOI().SetFloat("roomDescription", center.x);
			IGKFMCPDNOI().SetFloat("_BloomIntensity", center.y);
			OGMEGHKECAH().SetFloat("player.licenceaccepted", Radius);
			ABHDNGIHBKE().SetFloat("_ColorBuffer", _BorderSize);
			NBPKMLMCHFN.SetColor("GUICamera", _BorderColor);
			NFMGLIKNOOC().SetFloat("move", _AlphaHexa);
			PDEAHJPOMEF().SetFloat(".lastCheckpoint.powerupsScore", _SpotSize);
			EJDPNJAEAKJ().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1466f, 1663f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JNBPKNNBMDI()
	{
	}

	private void ICDBMJKMIKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NKLIHNJCHOG()
	{
	}

	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime / 955f;
			if (HBJJOCHGOPH > 45f)
			{
				HBJJOCHGOPH = 710f;
			}
			EFDEIFCDAFG().SetFloat("_Size", HBJJOCHGOPH);
			HHIAIGCAHDA().SetFloat("UpperMid", ShapeFormula);
			EFDEIFCDAFG().SetFloat("_Near", Shape);
			ABHDNGIHBKE().SetFloat("SaveButton", center.x);
			NBPKMLMCHFN.SetFloat("{0:0.0} ms ({1:0.} fps)", center.y);
			CFCPHFMKHII().SetFloat("Speed", Radius);
			IGKFMCPDNOI().SetFloat("Failed to 'network-remove' GameObject. Client is neither owner nor masterClient taking over for owner who left: ", _BorderSize);
			HNICHJCGJOC().SetColor("settings.fps", _BorderColor);
			CFCPHFMKHII().SetFloat("_dec.json", _AlphaHexa);
			PDEAHJPOMEF().SetFloat("_TimeX", _SpotSize);
			PDEAHJPOMEF().SetVector("PointsScoreText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1333f, 293f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PAEGLMEOKHP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material DOHGBNPMBKG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-65);
		}
		return BJFKDHHMLJH;
	}

	private void PDHKMDBNGGN()
	{
		SCShader = Shader.Find("_ColoredChange");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OEENOOGEEHD()
	{
	}

	private void BMODOIJGIOO()
	{
	}

	[SpecialName]
	private Material OGMEGHKECAH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void IMGGCJICLHK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DPFOEBCADNP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/AAA_Super_Computer");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
