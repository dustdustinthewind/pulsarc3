// CameraFilterPack_AAA_SuperComputer
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/AAA/Super Computer")]
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
		SCShader = Shader.Find("https://www.youtube.com/watch?v=cDVXukrKo74");
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
			EFDEIFCDAFG().SetFloat("_NeutralTonemapperParams1", HBJJOCHGOPH);
			GJHLADDCMFF().SetFloat("OnPhotonRandomJoinFailed() was called by PUN. No random room available, so we create one. Calling: PhotonNetwork.CreateRoom(null, new RoomOptions() {maxPlayers = 4}, null);", ShapeFormula);
			NFMGLIKNOOC().SetFloat(" methods \"", Shape);
			EJDPNJAEAKJ().SetFloat("master", center.x);
			NFMGLIKNOOC().SetFloat("PhotonView ID duplicate found: {0}. New: {1} old: {2}. Maybe one wasn't destroyed on scene load?! Check for 'DontDestroyOnLoad'. Destroying old entry, adding new.", center.y);
			EJDPNJAEAKJ().SetFloat("PointerExit ", Radius);
			KEMJNOMIPHN().SetFloat("MenuScene", _BorderSize);
			DOHGBNPMBKG().SetColor("ICollection", _BorderColor);
			HKHBBBFLGJH().SetFloat("string", _AlphaHexa);
			ABHDNGIHBKE().SetFloat("OPEN", _SpotSize);
			ABHDNGIHBKE().SetVector("Connection error: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 343f, 753f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DAHFFNNIGML()
	{
		SCShader = Shader.Find("DifficultyBG");
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
		SCShader = Shader.Find("2;13;14;15;16");
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
			KEMJNOMIPHN().SetFloat("help", HBJJOCHGOPH);
			CFCPHFMKHII().SetFloat("#8E8E8EFF", ShapeFormula);
			NFMGLIKNOOC().SetFloat("Right", Shape);
			HNICHJCGJOC().SetFloat("Type of observed is unknown when receiving.", center.x);
			KEMJNOMIPHN().SetFloat("In Main Menu", center.y);
			PDEAHJPOMEF().SetFloat("CameraFilterPack/TV_BrokenGlass2", Radius);
			HKHBBBFLGJH().SetFloat("[LocalizationService] Error: ", _BorderSize);
			HHIAIGCAHDA().SetColor(" player(s)", _BorderColor);
			CFCPHFMKHII().SetFloat("_Red_C", _AlphaHexa);
			EJDPNJAEAKJ().SetFloat("pointBuffer", _SpotSize);
			NBPKMLMCHFN.SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1129f, 209f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ABHDNGIHBKE());
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
			HNICHJCGJOC().SetFloat("#failed!", HBJJOCHGOPH);
			HKHBBBFLGJH().SetFloat("SetRotation", ShapeFormula);
			CFCPHFMKHII().SetFloat("Source: ", Shape);
			EJDPNJAEAKJ().SetFloat("0.00", center.x);
			EFDEIFCDAFG().SetFloat("_TimeX", center.y);
			ABHDNGIHBKE().SetFloat("UseScanLineSize", Radius);
			PDEAHJPOMEF().SetFloat("Triangle", _BorderSize);
			ABHDNGIHBKE().SetColor("#task", _BorderColor);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Blur_DitherOffset", _AlphaHexa);
			OGMEGHKECAH().SetFloat("getfloat", _SpotSize);
			NBPKMLMCHFN.SetVector("Save", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 553f, 134f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKHBBBFLGJH());
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
		SCShader = Shader.Find("inventory.selected.");
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
			NFMGLIKNOOC().SetFloat("PUNCloudBestRegion", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("menu.enableselectormusic", ShapeFormula);
			HHIAIGCAHDA().SetFloat("_VelTex", Shape);
			OGMEGHKECAH().SetFloat("Gameplay/sun", center.x);
			KEMJNOMIPHN().SetFloat("Reset All", center.y);
			EJDPNJAEAKJ().SetFloat("CameraFilterPack/Blend2Camera_DarkerColor", Radius);
			EFDEIFCDAFG().SetFloat("InfoCanvas", _BorderSize);
			HNICHJCGJOC().SetColor("SetParticlesCountPerBeat", _BorderColor);
			KEMJNOMIPHN().SetFloat("Tab2Content", _AlphaHexa);
			KEMJNOMIPHN().SetFloat("_History3LumaTex", _SpotSize);
			NBPKMLMCHFN.SetVector("Can't connect: Loading settings failed. ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1731f, 451f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NFMGLIKNOOC());
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
			HHIAIGCAHDA().SetFloat("_Value2", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("#mapmustbecompletebeforesubmit", ShapeFormula);
			HNICHJCGJOC().SetFloat("SpectatingUserInfo", Shape);
			DOHGBNPMBKG().SetFloat("BitsData", center.x);
			GJHLADDCMFF().SetFloat("_Speed", center.y);
			HKHBBBFLGJH().SetFloat("_TimeX", Radius);
			HNICHJCGJOC().SetFloat("_ScreenResolution", _BorderSize);
			ABHDNGIHBKE().SetColor("Texture2", _BorderColor);
			GJHLADDCMFF().SetFloat("{0:0}", _AlphaHexa);
			EJDPNJAEAKJ().SetFloat("[PlayerBase] ShowTitle error: ", _SpotSize);
			EJDPNJAEAKJ().SetVector("CameraFilterPack/FX_Drunk", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1572f, 1466f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MKIMDFLBFOM()
	{
		SCShader = Shader.Find("513510");
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
			CFCPHFMKHII().SetFloat("FPSToggle", HBJJOCHGOPH);
			EJDPNJAEAKJ().SetFloat("[PlayerController] ", ShapeFormula);
			HHIAIGCAHDA().SetFloat("Tab1Content", Shape);
			EFDEIFCDAFG().SetFloat("id", center.x);
			NFMGLIKNOOC().SetFloat("OnPlayerGameMessage", center.y);
			PDEAHJPOMEF().SetFloat("GhostPosY", Radius);
			IGKFMCPDNOI().SetFloat("[Right-Down-Left]", _BorderSize);
			EFDEIFCDAFG().SetColor("EnvironmentSlider", _BorderColor);
			GJHLADDCMFF().SetFloat("#91CCFF", _AlphaHexa);
			OGMEGHKECAH().SetFloat("_ScreenResolution", _SpotSize);
			DOHGBNPMBKG().SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 191f, 1113f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CIPKEPDELJB()
	{
		SCShader = Shader.Find("win");
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
			HNICHJCGJOC().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("X2", ShapeFormula);
			DOHGBNPMBKG().SetFloat("Blues", Shape);
			HNICHJCGJOC().SetFloat("_Value2", center.x);
			NBPKMLMCHFN.SetFloat("GroupNameText", center.y);
			GJHLADDCMFF().SetFloat("_FixDistance", Radius);
			OGMEGHKECAH().SetFloat("TotalTimeLabel", _BorderSize);
			HKHBBBFLGJH().SetColor("BlockSize", _BorderColor);
			ABHDNGIHBKE().SetFloat("Editor/", _AlphaHexa);
			HHIAIGCAHDA().SetFloat("settings.enablehitsoundsinrelax", _SpotSize);
			CFCPHFMKHII().SetVector(",", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 307f, 1002f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ANCKKLFPGDI()
	{
		SCShader = Shader.Find("Cannot send messages when not connected. Either connect to Photon OR use offline mode!");
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
			EFDEIFCDAFG().SetFloat("Player", HBJJOCHGOPH);
			HHIAIGCAHDA().SetFloat("/files/editor_manual.pdf", ShapeFormula);
			ABHDNGIHBKE().SetFloat("Connection error: ", Shape);
			HNICHJCGJOC().SetFloat("float,2", center.x);
			GJHLADDCMFF().SetFloat("Jump", center.y);
			NBPKMLMCHFN.SetFloat("Case-Sensitive", Radius);
			PDEAHJPOMEF().SetFloat("_ScreenResolution", _BorderSize);
			HKHBBBFLGJH().SetColor("_NoiseScale", _BorderColor);
			NBPKMLMCHFN.SetFloat("#onrankchangeuptext", _AlphaHexa);
			EFDEIFCDAFG().SetFloat("_MainTex2", _SpotSize);
			NFMGLIKNOOC().SetVector("CameraFilterPack/Vision_Warp", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 437f, 1077f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKHBBBFLGJH());
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
			OGMEGHKECAH().SetFloat(": ", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("player.gamecompleted", ShapeFormula);
			KEMJNOMIPHN().SetFloat("CameraFilterPack_AAA_Blood_Hit1", Shape);
			EJDPNJAEAKJ().SetFloat("_Value3", center.x);
			CFCPHFMKHII().SetFloat("steamid", center.y);
			GJHLADDCMFF().SetFloat("DifficultyBG", Radius);
			DOHGBNPMBKG().SetFloat("Reconnect() failed. It seems the client wasn't connected before?! Current state: ", _BorderSize);
			HNICHJCGJOC().SetColor(".", _BorderColor);
			PDEAHJPOMEF().SetFloat("[PlayerBase] Game mode: ", _AlphaHexa);
			ABHDNGIHBKE().SetFloat("masterSteamID", _SpotSize);
			DOHGBNPMBKG().SetVector("(\\[ */ *quote *\\])", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1577f, 1309f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKHBBBFLGJH());
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
			HNICHJCGJOC().SetFloat("_Value", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("<color=white>PhotonView Group: ", ShapeFormula);
			KEMJNOMIPHN().SetFloat("CameraFilterPack/Blend2Camera_HardLight", Shape);
			CFCPHFMKHII().SetFloat("https://steamcommunity.com/sharedfiles/filedetails/?id=", center.x);
			OGMEGHKECAH().SetFloat("ViewMenu", center.y);
			PDEAHJPOMEF().SetFloat("anonymous", Radius);
			IGKFMCPDNOI().SetFloat("SelectorMapsCountSlider", _BorderSize);
			KEMJNOMIPHN().SetColor("\n", _BorderColor);
			IGKFMCPDNOI().SetFloat("_QualitySettings", _AlphaHexa);
			KEMJNOMIPHN().SetFloat("Version 1.0", _SpotSize);
			HHIAIGCAHDA().SetVector("CameraFilterPack_AAA_Blood2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 85f, 166f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
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
			DOHGBNPMBKG().SetFloat("_Value4", HBJJOCHGOPH);
			CFCPHFMKHII().SetFloat("EventConfigButton", ShapeFormula);
			PDEAHJPOMEF().SetFloat("InputField", Shape);
			DOHGBNPMBKG().SetFloat("_Noise", center.x);
			HKHBBBFLGJH().SetFloat("OxOD.lastPath", center.y);
			CFCPHFMKHII().SetFloat("_Glitch", Radius);
			KEMJNOMIPHN().SetFloat("_TimeX", _BorderSize);
			OGMEGHKECAH().SetColor("</color>", _BorderColor);
			CFCPHFMKHII().SetFloat("reset", _AlphaHexa);
			KEMJNOMIPHN().SetFloat("workshop.", _SpotSize);
			HNICHJCGJOC().SetVector("_Value4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1777f, 652f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
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
			OGMEGHKECAH().SetFloat("Playing ", HBJJOCHGOPH);
			KEMJNOMIPHN().SetFloat("[Right]", ShapeFormula);
			PDEAHJPOMEF().SetFloat("Joystick", Shape);
			NFMGLIKNOOC().SetFloat("[NetworkManager] Connection failed: ", center.x);
			NBPKMLMCHFN.SetFloat("_TintColor", center.y);
			DOHGBNPMBKG().SetFloat("player.licenceaccepted", Radius);
			EJDPNJAEAKJ().SetFloat("offsets", _BorderSize);
			NFMGLIKNOOC().SetColor("Selection Box", _BorderColor);
			OGMEGHKECAH().SetFloat("turn", _AlphaHexa);
			NBPKMLMCHFN.SetFloat(".lastCheckpoint.penaltyScore", _SpotSize);
			NFMGLIKNOOC().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1466f, 1663f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKHBBBFLGJH());
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
			NFMGLIKNOOC().SetFloat("_Distortion", HBJJOCHGOPH);
			EJDPNJAEAKJ().SetFloat("UpperMid", ShapeFormula);
			EFDEIFCDAFG().SetFloat("_Near", Shape);
			CFCPHFMKHII().SetFloat("ViewMenu", center.x);
			HNICHJCGJOC().SetFloat("] ", center.y);
			NBPKMLMCHFN.SetFloat("Intensity", Radius);
			CFCPHFMKHII().SetFloat("Failed to Destroy objects of playerId: ", _BorderSize);
			DOHGBNPMBKG().SetColor("settings.fps", _BorderColor);
			IGKFMCPDNOI().SetFloat("_dec.json", _AlphaHexa);
			EJDPNJAEAKJ().SetFloat("_TimeX", _SpotSize);
			HKHBBBFLGJH().SetVector("0.00", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1333f, 293f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IGKFMCPDNOI());
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
		SCShader = Shader.Find("_Fade");
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
