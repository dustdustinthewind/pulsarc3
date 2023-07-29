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
			PHGCJOPFDOG().SetFloat("Tab1Content", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("type", Dissipation);
			NBPKMLMCHFN.SetFloat("_MainTex2", LHFNOLGKGMO);
			LMLENGFLEBD().SetFloat("_Value3", NEJIJAPDALK);
			MFHPKGICPIO().SetFloat("return ", CCIENBFIKKH);
			LMLENGFLEBD().SetVector("$ {0}", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1341f, 786f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
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
			ALABBJPHCNG().SetFloat("Checkpoint", HBJJOCHGOPH);
			PHGCJOPFDOG().SetFloat("BitsData", Dissipation);
			IIJMIPBMMBF().SetFloat("shader.crispwinter", LHFNOLGKGMO);
			KEMAALEODNH().SetFloat("_Value3", NEJIJAPDALK);
			GHHPOGODBHB().SetFloat("#91CCFF", CCIENBFIKKH);
			DONENAMLFLF().SetVector("Case-Sensitive", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1180f, 1976f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
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
			MMOODGIODPC().SetFloat("offsets", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Moved event", Dissipation);
			GKILCDHJFEG().SetFloat("_TimeX", LHFNOLGKGMO);
			KEMAALEODNH().SetFloat("Crosshair", NEJIJAPDALK);
			LMLENGFLEBD().SetFloat("#{0:X2}{1:X2}{2:X2}", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("Horizontal", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 4f, 1394f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
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
			LMLENGFLEBD().SetFloat("_Value3", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("id", Dissipation);
			LMLENGFLEBD().SetFloat("Dance", LHFNOLGKGMO);
			ACHNOHCLGOO().SetFloat("_EmissionColor", NEJIJAPDALK);
			MMOODGIODPC().SetFloat("JoinTeam was called in state: ", CCIENBFIKKH);
			LNLKMDPHDCC().SetVector("_CurveTex", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1104f, 1811f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
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
			DOHGBNPMBKG().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			GKILCDHJFEG().SetFloat("G:", Dissipation);
			MMOODGIODPC().SetFloat("Overlay", LHFNOLGKGMO);
			OHKGGPFGLFD().SetFloat("_Value", NEJIJAPDALK);
			GHHPOGODBHB().SetFloat("_TimeX", CCIENBFIKKH);
			MFHPKGICPIO().SetVector(" This is not possible to be called for standalone input. Please check your platform and code where this is called", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1394f, 786f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OHKGGPFGLFD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EIMNPCMHJLJ()
	{
		SCShader = Shader.Find("LT");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MDNHCLKNCLE()
	{
		SCShader = Shader.Find("<not connected>");
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
			ACHNOHCLGOO().SetFloat("0,7,true,0", HBJJOCHGOPH);
			DOHGBNPMBKG().SetFloat("[MapsData] User's maps was loaded", Dissipation);
			GKILCDHJFEG().SetFloat(":</b> ", LHFNOLGKGMO);
			MLMKCOINOOH().SetFloat("Set sun lerp speed", NEJIJAPDALK);
			ALABBJPHCNG().SetFloat("CameraFilterPack/Blend2Camera_Exclusion", CCIENBFIKKH);
			PHGCJOPFDOG().SetVector("Joystick1Button11", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 58f, 285f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
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
		SCShader = Shader.Find("/");
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
		SCShader = Shader.Find("_Bullet_6");
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
		SCShader = Shader.Find("Added unlock condition");
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
		SCShader = Shader.Find("Joystick1Button9");
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
			IIJMIPBMMBF().SetFloat("DPADVER", HBJJOCHGOPH);
			DONENAMLFLF().SetFloat("settings.enablehitsoundsinrelax", Dissipation);
			NBPKMLMCHFN.SetFloat("DPADHOR", LHFNOLGKGMO);
			LMLENGFLEBD().SetFloat("_Saturation", NEJIJAPDALK);
			MMOODGIODPC().SetFloat("RecieveChatMessage", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("_Value9", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 17f, 636f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MLMKCOINOOH());
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
			LNLKMDPHDCC().SetFloat(".lastCheckpoint.isMapCompleted", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat("[LocalizationService] Loading file: ", Dissipation);
			DBOLLHHMKKN().SetFloat("Fade", LHFNOLGKGMO);
			NBPKMLMCHFN.SetFloat("clear", NEJIJAPDALK);
			IIJMIPBMMBF().SetFloat("RequestSelectedLevel", CCIENBFIKKH);
			DBOLLHHMKKN().SetVector("Mid", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1171f, 1474f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF());
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
			MMOODGIODPC().SetFloat("mapselector.filter.favoriteonly", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("settings.cameramovements", Dissipation);
			ALABBJPHCNG().SetFloat(".played", LHFNOLGKGMO);
			PHGCJOPFDOG().SetFloat("Type of observed is unknown when receiving.", NEJIJAPDALK);
			HNFFHCLNBDN().SetFloat("CameraFilterPack/Gradients_FireGradient", CCIENBFIKKH);
			DOHGBNPMBKG().SetVector("Type \"help\" for list of commands", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 195f, 234f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GKILCDHJFEG());
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
			MLMKCOINOOH().SetFloat("CameraFilterPack/EXTRA_SHOWFPS", HBJJOCHGOPH);
			ACHNOHCLGOO().SetFloat("_ScreenResolution", Dissipation);
			LNLKMDPHDCC().SetFloat("SelectionBox component must be placed on a canvas in Screen Space Overlay mode.", LHFNOLGKGMO);
			GKILCDHJFEG().SetFloat("CameraFilterPack/Glitch_Mozaic", NEJIJAPDALK);
			MMOODGIODPC().SetFloat("IntraTime", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("_Value6", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 985f, 218f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IKDNLHLBHID()
	{
		SCShader = Shader.Find("settings.showHP");
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
			PHGCJOPFDOG().SetFloat("CameraFilterPack/EXTRA_SHOWFPS", HBJJOCHGOPH);
			ALABBJPHCNG().SetFloat("Tab2Content", Dissipation);
			LMLENGFLEBD().SetFloat("_Value3", LHFNOLGKGMO);
			HNFFHCLNBDN().SetFloat("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.", NEJIJAPDALK);
			PHGCJOPFDOG().SetFloat("_Speed", CCIENBFIKKH);
			DOHGBNPMBKG().SetVector("(\\[ */ *quote *\\])", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1706f, 803f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
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
			MLMKCOINOOH().SetFloat("CameraFilterPack_RainFX_Anm2", HBJJOCHGOPH);
			ALABBJPHCNG().SetFloat("event", Dissipation);
			LNLKMDPHDCC().SetFloat("_Amount", LHFNOLGKGMO);
			NBPKMLMCHFN.SetFloat("restrictions\n\n#until: ", NEJIJAPDALK);
			LMLENGFLEBD().SetFloat("inventory.selected.", CCIENBFIKKH);
			IIJMIPBMMBF().SetVector("_Value6", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 911f, 1141f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNFFHCLNBDN());
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
			PHGCJOPFDOG().SetFloat("_DistortionSize", HBJJOCHGOPH);
			DOHGBNPMBKG().SetFloat("[ItemsHandler] Found ", Dissipation);
			DOHGBNPMBKG().SetFloat("challenges.", LHFNOLGKGMO);
			DOHGBNPMBKG().SetFloat("CameraFilterPack/Blend2Camera_SplitScreen3D", NEJIJAPDALK);
			LNLKMDPHDCC().SetFloat("_Offsets", CCIENBFIKKH);
			MLMKCOINOOH().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1138f, 76f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
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
			DBOLLHHMKKN().SetFloat("EnvironmentSlider", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat(" ", Dissipation);
			MLMKCOINOOH().SetFloat("addNewButton", LHFNOLGKGMO);
			HNFFHCLNBDN().SetFloat("_Value", NEJIJAPDALK);
			OHKGGPFGLFD().SetFloat("BlockSize", CCIENBFIKKH);
			OHKGGPFGLFD().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 235f, 965f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GHHPOGODBHB());
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
			LMLENGFLEBD().SetFloat("[ResourcesManager] Load image error: ", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", Dissipation);
			MFHPKGICPIO().SetFloat("Warning, using scrollbors with the Scroll Snap controls is not advised as it causes unpredictable results", LHFNOLGKGMO);
			GHHPOGODBHB().SetFloat("_Fade", NEJIJAPDALK);
			EFDEIFCDAFG().SetFloat("ws://", CCIENBFIKKH);
			GKILCDHJFEG().SetVector("SpeedSlider", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 461f, 1766f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMAALEODNH());
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
			GKILCDHJFEG().SetFloat("blue", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat("Set sun lerp speed", Dissipation);
			GHHPOGODBHB().SetFloat("_Value", LHFNOLGKGMO);
			ALABBJPHCNG().SetFloat("menu.enableselectormusic", NEJIJAPDALK);
			GKILCDHJFEG().SetFloat("NO", CCIENBFIKKH);
			MLMKCOINOOH().SetVector("_HalfResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1805f, 550f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LFAFJKJAEEL()
	{
		SCShader = Shader.Find("UseFinalGlassColor");
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
			MLMKCOINOOH().SetFloat("CameraFilterPack/3D_Ghost", HBJJOCHGOPH);
			KEMAALEODNH().SetFloat("_TimeX", Dissipation);
			KEMAALEODNH().SetFloat("\\\\", LHFNOLGKGMO);
			ALABBJPHCNG().SetFloat("Set Sun Lerp Speed", NEJIJAPDALK);
			GHHPOGODBHB().SetFloat("clear", CCIENBFIKKH);
			DONENAMLFLF().SetVector("CameraFilterPack/Alien_Vision", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 499f, 1620f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LMLENGFLEBD());
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
			DOHGBNPMBKG().SetFloat(".lastCheckpoint.correctScore", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("Populate Mesh Data", Dissipation);
			IIJMIPBMMBF().SetFloat("LocalPlayer is null or not in mActors! LocalPlayer: {0} mActors==null: {1} newID: {2}", LHFNOLGKGMO);
			PHGCJOPFDOG().SetFloat("_Value5", NEJIJAPDALK);
			DONENAMLFLF().SetFloat("_DiffuseColor", CCIENBFIKKH);
			KEMAALEODNH().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 558f, 1744f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ALABBJPHCNG());
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
		SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NNCCPEBIAKH()
	{
		SCShader = Shader.Find("<color=#{0}>{1}</color>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JONGNKNLLND()
	{
		SCShader = Shader.Find("0.00");
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
			GHHPOGODBHB().SetFloat("player.russia", HBJJOCHGOPH);
			MFHPKGICPIO().SetFloat("_TimeX", Dissipation);
			GKILCDHJFEG().SetFloat("_Colorisation", LHFNOLGKGMO);
			KEMAALEODNH().SetFloat("offsets", NEJIJAPDALK);
			GHHPOGODBHB().SetFloat("_FixDistance", CCIENBFIKKH);
			DOHGBNPMBKG().SetVector("_Bloom2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1443f, 1917f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ALABBJPHCNG());
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
			MLMKCOINOOH().SetFloat("_Red_G", HBJJOCHGOPH);
			MMOODGIODPC().SetFloat("<b>Intralism Items Uploader</b> by Oxy949", Dissipation);
			GHHPOGODBHB().SetFloat("The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.", LHFNOLGKGMO);
			NBPKMLMCHFN.SetFloat("_Value", NEJIJAPDALK);
			KEMAALEODNH().SetFloat("[Up-Right-Left]", CCIENBFIKKH);
			LMLENGFLEBD().SetVector("float,1.5", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1925f, 459f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF());
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
		SCShader = Shader.Find("_ScreenResolution");
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
			MFHPKGICPIO().SetFloat("SelectorMapsCountSlider", HBJJOCHGOPH);
			GHHPOGODBHB().SetFloat("{0}", Dissipation);
			LMLENGFLEBD().SetFloat("PS Home", LHFNOLGKGMO);
			OHKGGPFGLFD().SetFloat("checkpoint", NEJIJAPDALK);
			MMOODGIODPC().SetFloat("_Size", CCIENBFIKKH);
			DBOLLHHMKKN().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 986f, 591f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LNLKMDPHDCC());
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
		SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EFJDNLGNACH()
	{
		SCShader = Shader.Find("restrictions");
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
		SCShader = Shader.Find("CameraFilterPack/Blend2Camera_Luminosity");
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
		SCShader = Shader.Find("UnAllocateViewID() should be called after the PhotonView was destroyed (GameObject.Destroy()). ViewID: {0} still found in: {1}");
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
		SCShader = Shader.Find("_TimeX");
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
			EFDEIFCDAFG().SetFloat("#discord{0}joinrequest", HBJJOCHGOPH);
			DONENAMLFLF().SetFloat("OpJoinRandomRoom()", Dissipation);
			LMLENGFLEBD().SetFloat("_ScreenResolution", LHFNOLGKGMO);
			LNLKMDPHDCC().SetFloat("Drop_With_Obj", NEJIJAPDALK);
			DBOLLHHMKKN().SetFloat("/", CCIENBFIKKH);
			MFHPKGICPIO().SetVector("_TapMedium", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 492f, 835f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DONENAMLFLF());
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
			EFDEIFCDAFG().SetFloat("_Visualize", HBJJOCHGOPH);
			EFDEIFCDAFG().SetFloat("_Amount", Dissipation);
			PHGCJOPFDOG().SetFloat("_ScreenResolution", LHFNOLGKGMO);
			DBOLLHHMKKN().SetFloat("ResetSpeed", NEJIJAPDALK);
			MLMKCOINOOH().SetFloat("_ScreenResolution", CCIENBFIKKH);
			MMOODGIODPC().SetVector("/../", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 19f, 274f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GHHPOGODBHB());
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
			MFHPKGICPIO().SetFloat("CameraFilterPack/Edge_Edge_filter", HBJJOCHGOPH);
			PHGCJOPFDOG().SetFloat("UpdateNewsTileStart", Dissipation);
			PHGCJOPFDOG().SetFloat("Error: I/O Failure", LHFNOLGKGMO);
			MFHPKGICPIO().SetFloat("sfxVolume", NEJIJAPDALK);
			LNLKMDPHDCC().SetFloat("_BlurredColor", CCIENBFIKKH);
			LNLKMDPHDCC().SetVector("menu.tabid", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1625f, 748f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF());
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
			GHHPOGODBHB().SetFloat("_WaveIntensity", HBJJOCHGOPH);
			DONENAMLFLF().SetFloat("_MainTex2", Dissipation);
			OHKGGPFGLFD().SetFloat("Received RPC \"", LHFNOLGKGMO);
			GHHPOGODBHB().SetFloat("_Screen", NEJIJAPDALK);
			PHGCJOPFDOG().SetFloat("[PlayerBase] Starting new round", CCIENBFIKKH);
			EFDEIFCDAFG().SetVector("Hidden/Image Effects/Cinematic/AmbientOcclusion", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 863f, 1643f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MLMKCOINOOH());
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
		SCShader = Shader.Find("CameraFilterPack/FX_InverChromiLum");
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
