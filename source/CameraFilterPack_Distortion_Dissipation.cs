// CameraFilterPack_Distortion_Dissipation
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Distortion/Dissipation")]
[ExecuteInEditMode]
public class CameraFilterPack_Distortion_Dissipation : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 2.99f)]
	public float Dissipation = 1f;

	[Range(0f, 16f)]
	private float LHFNOLGKGMO = 11f;

	[Range(-1f, 1f)]
	private float NEJIJAPDALK = 1f;

	[Range(0f, 10f)]
	private float CCIENBFIKKH = 1f;

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
	private Material OHKGGPFGLFD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material MMOODGIODPC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)98;
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

	private void EAHCLIEEJOG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BMBIGILMLLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 384f)
			{
				HBJJOCHGOPH = 1368f;
			}
			NBPKMLMCHFN.SetFloat("LevelInfoInputField", HBJJOCHGOPH);
			GHHPOGODBHB().SetFloat("type", Dissipation);
			MMOODGIODPC().SetFloat("_PColor2", LHFNOLGKGMO);
			KEMAALEODNH().SetFloat("_Value2", NEJIJAPDALK);
			DBOLLHHMKKN().SetFloat(", data: ", CCIENBFIKKH);
			OHKGGPFGLFD().SetVector("plogs", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1341f, 786f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EKCKJLFFAID()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DLIJFEGIEKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 936f)
			{
				HBJJOCHGOPH = 249f;
			}
			MLMKCOINOOH().SetFloat("SpawnObj", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat("BitsData", Dissipation);
			LNLKMDPHDCC().SetFloat("player.goldcrystal", LHFNOLGKGMO);
			HNFFHCLNBDN().SetFloat("_Value2", NEJIJAPDALK);
			MMOODGIODPC().SetFloat("ItemNameText", CCIENBFIKKH);
			DBOLLHHMKKN().SetVector("id", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1180f, 1976f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KKLMPKLKAEM()
	{
	}

	private void JHJFBCFBKLD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 472f)
			{
				HBJJOCHGOPH = 1058f;
			}
			GKILCDHJFEG().SetFloat("offsets", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("[Right]", Dissipation);
			MLMKCOINOOH().SetFloat("CameraFilterPack/TV_WideScreenVertical", LHFNOLGKGMO);
			NBPKMLMCHFN.SetFloat("custom", NEJIJAPDALK);
			IIJMIPBMMBF().SetFloat("_MainTex", CCIENBFIKKH);
			OHKGGPFGLFD().SetVector(" This is not possible to be called for standalone input. Please check your platform and code where this is called", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 4f, 1394f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material DBOLLHHMKKN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void GFACKFCEIBC()
	{
	}

	private void BGDPIHMAACO()
	{
		SCShader = Shader.Find("_BlurVector");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material MFHPKGICPIO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-70);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KEMAALEODNH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void KCDBBPKIFNJ()
	{
	}

	private void FAKGFMFAPDG()
	{
	}

	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 269f)
			{
				HBJJOCHGOPH = 1728f;
			}
			EFDEIFCDAFG().SetFloat("_Value2", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Set Satellite Lerp Speed", Dissipation);
			ALABBJPHCNG().SetFloat("Dance", LHFNOLGKGMO);
			PHGCJOPFDOG().SetFloat("_EmissionColor", NEJIJAPDALK);
			EFDEIFCDAFG().SetFloat("score", CCIENBFIKKH);
			MLMKCOINOOH().SetVector("_ChannelMixerRed", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1104f, 1811f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1283f)
			{
				HBJJOCHGOPH = 272f;
			}
			LNLKMDPHDCC().SetFloat("_TimeX", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("#{0:X2}{1:X2}{2:X2}", Dissipation);
			NBPKMLMCHFN.SetFloat("Text", LHFNOLGKGMO);
			MFHPKGICPIO().SetFloat("_TimeX", NEJIJAPDALK);
			ALABBJPHCNG().SetFloat("CameraFilterPack/FX_Grid", CCIENBFIKKH);
			EFDEIFCDAFG().SetVector("Vertical", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1394f, 786f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EIMNPCMHJLJ()
	{
		SCShader = Shader.Find("RB");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MDNHCLKNCLE()
	{
		SCShader = Shader.Find("PhotonMono");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OPCLBGHAPMG()
	{
	}

	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 448f)
			{
				HBJJOCHGOPH = 100f;
			}
			KEMAALEODNH().SetFloat("0,7,true,0", HBJJOCHGOPH);
			LMLENGFLEBD().SetFloat("AudioClip", Dissipation);
			DONENAMLFLF().SetFloat("#activechallenges", LHFNOLGKGMO);
			KEMAALEODNH().SetFloat("Set sun lerp speed", NEJIJAPDALK);
			IIJMIPBMMBF().SetFloat("CameraFilterPack/Blend2Camera_Difference", CCIENBFIKKH);
			MMOODGIODPC().SetVector("Joystick1Button10", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 58f, 285f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MBLDJEFBLFL()
	{
	}

	private void GAOOPEEBGJA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ECBILENEOOL()
	{
		SCShader = Shader.Find("[MapsData] Installed: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CNDACAHCCOI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material DONENAMLFLF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return BJFKDHHMLJH;
	}

	private void PAKPHKPDKGE()
	{
		SCShader = Shader.Find("_Bullet_5");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material IIJMIPBMMBF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-83);
		}
		return BJFKDHHMLJH;
	}

	private void GPHPJIDGEPI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CCFEDENFNEF()
	{
		SCShader = Shader.Find("Paste events");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LMBDNPLDGIJ()
	{
	}

	private void OFMNDBNFBDJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material ALABBJPHCNG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)92;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material LMLENGFLEBD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material DOHGBNPMBKG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void LADCJEIALMH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NEFHGMNAPEP()
	{
		SCShader = Shader.Find("Share");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 652f)
			{
				HBJJOCHGOPH = 745f;
			}
			KEMAALEODNH().SetFloat("DPADVER", HBJJOCHGOPH);
			MMOODGIODPC().SetFloat("HitInRelaxMusicToggle", Dissipation);
			ALABBJPHCNG().SetFloat("DPADHOR", LHFNOLGKGMO);
			DOHGBNPMBKG().SetFloat("_Saturation", NEJIJAPDALK);
			MMOODGIODPC().SetFloat("MenuScene", CCIENBFIKKH);
			OHKGGPFGLFD().SetVector("_Value9", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 17f, 636f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GBGAMCPNBCC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ELGOMIMONOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 933f)
			{
				HBJJOCHGOPH = 789f;
			}
			DOHGBNPMBKG().SetFloat(".lastCheckpoint.time", HBJJOCHGOPH);
			DOHGBNPMBKG().SetFloat("\n", Dissipation);
			DONENAMLFLF().SetFloat("Value", LHFNOLGKGMO);
			MLMKCOINOOH().SetFloat("players", NEJIJAPDALK);
			LMLENGFLEBD().SetFloat("Gameplay/LobbyPlayerIconElement", CCIENBFIKKH);
			GKILCDHJFEG().SetVector("Mid", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1171f, 1474f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 53f)
			{
				HBJJOCHGOPH = 1901f;
			}
			NBPKMLMCHFN.SetFloat("mapselector.filter.subscribedonly", HBJJOCHGOPH);
			LNLKMDPHDCC().SetFloat("cameramovements:", Dissipation);
			PHGCJOPFDOG().SetFloat(".highscore", LHFNOLGKGMO);
			DONENAMLFLF().SetFloat(" != ", NEJIJAPDALK);
			GKILCDHJFEG().SetFloat("_ScreenResolution", CCIENBFIKKH);
			LNLKMDPHDCC().SetVector("<color=#{0}>{1}</color>", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 195f, 234f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1119f)
			{
				HBJJOCHGOPH = 1860f;
			}
			HNFFHCLNBDN().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			MLMKCOINOOH().SetFloat("_Value4", Dissipation);
			PHGCJOPFDOG().SetFloat("From {0} at Index {1} \n", LHFNOLGKGMO);
			KEMAALEODNH().SetFloat("_MainTex2", NEJIJAPDALK);
			IIJMIPBMMBF().SetFloat("request", CCIENBFIKKH);
			GHHPOGODBHB().SetVector("_Value5", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 985f, 218f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IKDNLHLBHID()
	{
		SCShader = Shader.Find("menu.enableselectormusic");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MKOMIDCPCDC()
	{
		SCShader = Shader.Find("GameModeText");
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
			if (HBJJOCHGOPH > 269f)
			{
				HBJJOCHGOPH = 1434f;
			}
			ALABBJPHCNG().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			MMOODGIODPC().SetFloat("Tab2Content", Dissipation);
			KEMAALEODNH().SetFloat("_Value2", LHFNOLGKGMO);
			EFDEIFCDAFG().SetFloat("PhotonNetwork error: Could not Instantiate the prefab [", NEJIJAPDALK);
			NBPKMLMCHFN.SetFloat("_SizeY", CCIENBFIKKH);
			DBOLLHHMKKN().SetVector("(\\[ */ *quote *\\])", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1706f, 803f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ANDELGODEOC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JHPOIOELNCG()
	{
	}

	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1485f)
			{
				HBJJOCHGOPH = 1916f;
			}
			DOHGBNPMBKG().SetFloat("Texture2", HBJJOCHGOPH);
			ALABBJPHCNG().SetFloat("event", Dissipation);
			MLMKCOINOOH().SetFloat("_Amount", LHFNOLGKGMO);
			MLMKCOINOOH().SetFloat("restrictions\n\n#until: ", NEJIJAPDALK);
			LNLKMDPHDCC().SetFloat("inventory.selected.", CCIENBFIKKH);
			LNLKMDPHDCC().SetVector("_Value6", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 911f, 1141f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OHKGGPFGLFD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IBHACCEEFFI()
	{
	}

	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1887f)
			{
				HBJJOCHGOPH = 1971f;
			}
			LMLENGFLEBD().SetFloat("_DistortionSize", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("[ItemsHandler] Item not found:", Dissipation);
			DOHGBNPMBKG().SetFloat(" ", LHFNOLGKGMO);
			EFDEIFCDAFG().SetFloat("_ForceYSwap", NEJIJAPDALK);
			MFHPKGICPIO().SetFloat("_Offsets", CCIENBFIKKH);
			LMLENGFLEBD().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1138f, 76f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CCLNNLCOPBL()
	{
		SCShader = Shader.Find("_Value2");
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
			NBPKMLMCHFN.SetFloat("_Value", Dissipation);
			NBPKMLMCHFN.SetFloat("_Value2", LHFNOLGKGMO);
			NBPKMLMCHFN.SetFloat("_Value3", NEJIJAPDALK);
			NBPKMLMCHFN.SetFloat("_Value4", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1824f)
			{
				HBJJOCHGOPH = 377f;
			}
			MLMKCOINOOH().SetFloat("EnvironmentSlider", HBJJOCHGOPH);
			HNFFHCLNBDN().SetFloat(" ", Dissipation);
			ALABBJPHCNG().SetFloat("Events Moved", LHFNOLGKGMO);
			GKILCDHJFEG().SetFloat("CameraFilterPack/Noise_TV_3", NEJIJAPDALK);
			OHKGGPFGLFD().SetFloat("_Color", CCIENBFIKKH);
			GHHPOGODBHB().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 235f, 965f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OHKGGPFGLFD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HLHJBJGEEEA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CPAJLKHMOJB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 61f)
			{
				HBJJOCHGOPH = 762f;
			}
			MMOODGIODPC().SetFloat("inventory.selected.", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat("_ScreenResolution", Dissipation);
			ALABBJPHCNG().SetFloat(" ", LHFNOLGKGMO);
			DBOLLHHMKKN().SetFloat("_TimeX", NEJIJAPDALK);
			IIJMIPBMMBF().SetFloat("{0}_{1}", CCIENBFIKKH);
			LNLKMDPHDCC().SetVector("SpeedSlider", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 461f, 1766f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void COOHIILCOCO()
	{
		SCShader = Shader.Find("[SERVER] Kicked ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KMEONPMCNJG()
	{
	}

	private void EGEGNHLODAA()
	{
	}

	[SpecialName]
	private Material LNLKMDPHDCC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material GHHPOGODBHB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1511f)
			{
				HBJJOCHGOPH = 573f;
			}
			EFDEIFCDAFG().SetFloat("violet", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Set sun lerp speed", Dissipation);
			LNLKMDPHDCC().SetFloat("_Value", LHFNOLGKGMO);
			ACHNOHCLGOO().SetFloat("SingleplayerButton", NEJIJAPDALK);
			GKILCDHJFEG().SetFloat("NO", CCIENBFIKKH);
			HNFFHCLNBDN().SetVector("_MaxSteps", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1805f, 550f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LFAFJKJAEEL()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1110f)
			{
				HBJJOCHGOPH = 711f;
			}
			MFHPKGICPIO().SetFloat("CameraFilterPack/3D_Ghost", HBJJOCHGOPH);
			DONENAMLFLF().SetFloat("_Fade", Dissipation);
			PHGCJOPFDOG().SetFloat("\\\\", LHFNOLGKGMO);
			NBPKMLMCHFN.SetFloat("SetSunLerpSpeed", NEJIJAPDALK);
			LNLKMDPHDCC().SetFloat("clear", CCIENBFIKKH);
			DONENAMLFLF().SetVector("CameraFilterPack/Alien_Vision", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 499f, 1620f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ALABBJPHCNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FJNCHGLIEMA()
	{
		SCShader = Shader.Find("_Value6");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DOEPOGLEGLE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Distortion_Dissipation");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 601f)
			{
				HBJJOCHGOPH = 828f;
			}
			ACHNOHCLGOO().SetFloat(".lastCheckpoint.time", HBJJOCHGOPH);
			MMOODGIODPC().SetFloat(" ", Dissipation);
			NBPKMLMCHFN.SetFloat(".", LHFNOLGKGMO);
			DOHGBNPMBKG().SetFloat("_Value5", NEJIJAPDALK);
			GKILCDHJFEG().SetFloat("_DiffuseColor", CCIENBFIKKH);
			PHGCJOPFDOG().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 558f, 1744f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OEENOOGEEHD()
	{
	}

	private void GJLKJAOBPJD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void COGBDFKOHKK()
	{
	}

	private void JMEOGJHCONJ()
	{
		SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NNCCPEBIAKH()
	{
		SCShader = Shader.Find("$ {0}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JONGNKNLLND()
	{
		SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material HNFFHCLNBDN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)119;
		}
		return BJFKDHHMLJH;
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1124f)
			{
				HBJJOCHGOPH = 852f;
			}
			KEMAALEODNH().SetFloat("player.russia", HBJJOCHGOPH);
			MMOODGIODPC().SetFloat("CameraFilterPack/Blur_DitherOffset", Dissipation);
			LNLKMDPHDCC().SetFloat("_TimeX", LHFNOLGKGMO);
			DBOLLHHMKKN().SetFloat("_Threshhold", NEJIJAPDALK);
			HNFFHCLNBDN().SetFloat("_FixDistance", CCIENBFIKKH);
			DBOLLHHMKKN().SetVector("_Bloom1", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1443f, 1917f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FJIKDJAMOHA()
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
			if (HBJJOCHGOPH > 229f)
			{
				HBJJOCHGOPH = 613f;
			}
			DOHGBNPMBKG().SetFloat("_Red_R", HBJJOCHGOPH);
			MMOODGIODPC().SetFloat("Called GetNumberOfCurrentPlayers()", Dissipation);
			IIJMIPBMMBF().SetFloat("Received your UserID from server. Updating local value to: {0}", LHFNOLGKGMO);
			OHKGGPFGLFD().SetFloat("CameraFilterPack/TV_WideScreenVertical", NEJIJAPDALK);
			ALABBJPHCNG().SetFloat("[Left]", CCIENBFIKKH);
			DOHGBNPMBKG().SetVector("value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1925f, 459f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JHLGHODFJOO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KDMKDEKCELE()
	{
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 581f)
			{
				HBJJOCHGOPH = 1848f;
			}
			EFDEIFCDAFG().SetFloat("SelectorMapsCountSlider", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat("#discord{0}joinrequest", Dissipation);
			MFHPKGICPIO().SetFloat("Joystick1Button12", LHFNOLGKGMO);
			GHHPOGODBHB().SetFloat("checkpoint", NEJIJAPDALK);
			MLMKCOINOOH().SetFloat("_FadeFX", CCIENBFIKKH);
			DONENAMLFLF().SetVector("CameraFilterPack/FX_Hypno", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 986f, 591f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ALABBJPHCNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CHOPDIGHJNH()
	{
		SCShader = Shader.Find("Other");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material GKILCDHJFEG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material PHGCJOPFDOG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-125);
		}
		return BJFKDHHMLJH;
	}

	private void Update()
	{
	}

	[SpecialName]
	private Material EFDEIFCDAFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-112);
		}
		return BJFKDHHMLJH;
	}

	private void BGFJOEPFOPM()
	{
	}

	private void BDBJEDIOKBN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KMOCDAOKGLI()
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

	private void EHJJFJCKGAJ()
	{
	}

	private void BMIOFJFMCBG()
	{
		SCShader = Shader.Find("_Value13");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EFJDNLGNACH()
	{
		SCShader = Shader.Find("\n\n#");
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

	private void HDDECCMEJKA()
	{
	}

	private void CGDMLHLJIDK()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material MLMKCOINOOH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void GHILDCBCDJI()
	{
	}

	private void MJEFMIPLFAB()
	{
		SCShader = Shader.Find("AllocateViewID() failed. Room (user {0}) is out of 'scene' viewIDs. It seems all available are in use.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EDCMIPNCPLB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MDCFIHDPLIG()
	{
	}

	private void CCPEDDLAMIB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HLIAEEMGBHN()
	{
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KMCPMOGKDEH()
	{
		SCShader = Shader.Find("_Contrast");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HDMDKOKOOJC()
	{
		SCShader = Shader.Find("\n\n#");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FDMAEPOHDMK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KLOLKEBAPFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OBAEDJJDCPN()
	{
	}

	private void OKHBBIKDIEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1667f)
			{
				HBJJOCHGOPH = 1335f;
			}
			LMLENGFLEBD().SetFloat("[DiscordController] Shutdown", HBJJOCHGOPH);
			MMOODGIODPC().SetFloat("OpCreateRoom()", Dissipation);
			GKILCDHJFEG().SetFloat("_Smooth", LHFNOLGKGMO);
			GHHPOGODBHB().SetFloat("Drop_With_Obj", NEJIJAPDALK);
			EFDEIFCDAFG().SetFloat("[MapsData] Installed: ", CCIENBFIKKH);
			HNFFHCLNBDN().SetVector("_Threshhold", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 492f, 835f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 353f)
			{
				HBJJOCHGOPH = 1571f;
			}
			OHKGGPFGLFD().SetFloat("_Visualize", HBJJOCHGOPH);
			MMOODGIODPC().SetFloat("_Amount", Dissipation);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", LHFNOLGKGMO);
			ACHNOHCLGOO().SetFloat("ResetSpeed", NEJIJAPDALK);
			ALABBJPHCNG().SetFloat("_ScreenResolution", CCIENBFIKKH);
			PHGCJOPFDOG().SetVector("/", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 19f, 274f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MKIFJMPELJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 230f)
			{
				HBJJOCHGOPH = 1465f;
			}
			DOHGBNPMBKG().SetFloat("CameraFilterPack/Edge_Edge_filter", HBJJOCHGOPH);
			ALABBJPHCNG().SetFloat("achievements.21.progress", Dissipation);
			ACHNOHCLGOO().SetFloat("Error: I/O Failure", LHFNOLGKGMO);
			KEMAALEODNH().SetFloat("[Sound Manager] Audio clip is null, cannot play sound", NEJIJAPDALK);
			EFDEIFCDAFG().SetFloat("_Offsets", CCIENBFIKKH);
			DONENAMLFLF().SetVector("#join", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1625f, 748f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OHKGGPFGLFD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DDBOODLPCAM()
	{
	}

	[SpecialName]
	private Material ACHNOHCLGOO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void FPHLDMMAOEF()
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
			if (HBJJOCHGOPH > 278f)
			{
				HBJJOCHGOPH = 1757f;
			}
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Distortion_Wave_Horizontal", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("_MainTex2", Dissipation);
			GHHPOGODBHB().SetFloat("Could not find RPC with index: ", LHFNOLGKGMO);
			HNFFHCLNBDN().SetFloat("pointBuffer", NEJIJAPDALK);
			ALABBJPHCNG().SetFloat("[Left]", CCIENBFIKKH);
			OHKGGPFGLFD().SetVector("There is already a virtual button named ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 863f, 1643f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FBMDHDBELEK()
	{
	}

	private void LIBGAKMKHJJ()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DBLILJGKGHJ()
	{
		SCShader = Shader.Find("_LightIntensity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}
}
