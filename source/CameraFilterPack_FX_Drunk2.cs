// CameraFilterPack_FX_Drunk2
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/FX/Drunk2")]
[ExecuteInEditMode]
public class CameraFilterPack_FX_Drunk2 : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 10f)]
	private float ADPHJHEFAON = 1f;

	[Range(0f, 10f)]
	private float EOKMJCIDCDB = 1f;

	[Range(0f, 10f)]
	private float ILHJFHFPGBB = 1f;

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

	private void ALNNIDLFILB()
	{
		SCShader = Shader.Find("CameraFilterPack_TV_Noise3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OBAEDJJDCPN()
	{
	}

	private void MCKCCPLJIFE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JHANGPCOCIG()
	{
		SCShader = Shader.Find("Observed type is not serializable: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EPEGAEGDJAM()
	{
		SCShader = Shader.Find("ViewMenu");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ELDMKIAPNGP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LAMEHAHJKMI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MANDOGNJJBD()
	{
	}

	private void DAHFFNNIGML()
	{
		SCShader = Shader.Find("[Up-Right-Down-Left]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OHIJGCLBMJL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DFENCIHAADO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material EMDFHOKEGNG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return BJFKDHHMLJH;
	}

	private void HPPMAKHOPBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 177f)
			{
				HBJJOCHGOPH = 1015f;
			}
			OCMBHMLNCEK().SetFloat("[PlayerController] ", HBJJOCHGOPH);
			ALABBJPHCNG().SetFloat("\\\"", ADPHJHEFAON);
			MICHFGAOPKM().SetFloat("_Value5", EOKMJCIDCDB);
			NBPKMLMCHFN.SetFloat("plainText", ILHJFHFPGBB);
			HKHBBBFLGJH().SetFloat("player.blackwhite", CCIENBFIKKH);
			PGFDGPABBMJ().SetVector("/C tasklist", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1036f, 1377f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EGOGECOEONM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material OCMBHMLNCEK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
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

	private void JLNNHKPHMAB()
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
			if (HBJJOCHGOPH > 1076f)
			{
				HBJJOCHGOPH = 1645f;
			}
			BLMPMOIDGMG().SetFloat("MenuVolumeSlider", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("ItemNameBGImage", ADPHJHEFAON);
			EGOGECOEONM().SetFloat("Set satellite trail length in seconds", EOKMJCIDCDB);
			PHGCJOPFDOG().SetFloat("[Down]", ILHJFHFPGBB);
			KGOLDDBHIFN().SetFloat("[Down]", CCIENBFIKKH);
			OHKGGPFGLFD().SetVector("Couldn't color correct with 3D LUT texture. Image Effect will be disabled.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 963f, 708f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CPCDFMMLHLO()
	{
	}

	private void CEAGPJBGBMH()
	{
		SCShader = Shader.Find("GhostFade");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FHPFJBFCOOF()
	{
		SCShader = Shader.Find("_Smooth");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KOFAMEKHHGD()
	{
		SCShader = Shader.Find("CameraFilterPack_TV_BrokenGlass1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LFAFJKJAEEL()
	{
		SCShader = Shader.Find("#exitmapeditor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material BLMPMOIDGMG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.HideInHierarchy | HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void BFEILOMHNPC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HDMDKOKOOJC()
	{
		SCShader = Shader.Find("Sent count: ");
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
			if (HBJJOCHGOPH > 137f)
			{
				HBJJOCHGOPH = 573f;
			}
			KDMBOKLMADJ().SetFloat("_Value2", HBJJOCHGOPH);
			EMDFHOKEGNG().SetFloat("AudioSampler", ADPHJHEFAON);
			JIBOKBCPDLC().SetFloat("[EditorEvent] Exception: ", EOKMJCIDCDB);
			EHDJJANLINB().SetFloat("CameraFilterPack/FX_DigitalMatrixDistortion", ILHJFHFPGBB);
			KDMBOKLMADJ().SetFloat("D-Pad Left", CCIENBFIKKH);
			EMDFHOKEGNG().SetVector("_Amount", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 324f, 1266f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OHKGGPFGLFD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EIDKCANPHJE()
	{
	}

	private void FJNJIHCLODK()
	{
	}

	private void ALMGMOOHLMA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1211f)
			{
				HBJJOCHGOPH = 585f;
			}
			KJMECMIGJJA().SetFloat("/", HBJJOCHGOPH);
			MJJIEHANFJA().SetFloat("<b>Speed</b>:", ADPHJHEFAON);
			BLMPMOIDGMG().SetFloat("_Value", EOKMJCIDCDB);
			BLMPMOIDGMG().SetFloat("LoadMapCanvas", ILHJFHFPGBB);
			KDMBOKLMADJ().SetFloat("menu.playedsolo", CCIENBFIKKH);
			IKBJACCLPCL().SetVector(" Owner called.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 966f, 269f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ALABBJPHCNG());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-88);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material DIOAAHJDMLK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)104;
		}
		return BJFKDHHMLJH;
	}

	private void FJKJGBLPDGG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1860f)
			{
				HBJJOCHGOPH = 1708f;
			}
			NBPKMLMCHFN.SetFloat("#forever", HBJJOCHGOPH);
			IKBJACCLPCL().SetFloat("_HalfResolution", ADPHJHEFAON);
			DOMEEFLPEPJ().SetFloat(" not exist", EOKMJCIDCDB);
			BLMPMOIDGMG().SetFloat("_HardBlend", ILHJFHFPGBB);
			PHGCJOPFDOG().SetFloat("Data/Maps/", CCIENBFIKKH);
			ALABBJPHCNG().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1028f, 834f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KMIEAGOFLBN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HIFLPHLGLFG()
	{
	}

	private void JNALDALAJLG()
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

	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1631f)
			{
				HBJJOCHGOPH = 1098f;
			}
			MJJIEHANFJA().SetFloat("_TimeX", HBJJOCHGOPH);
			IKBJACCLPCL().SetFloat("<b><i>Map's Stats:</i></b>", ADPHJHEFAON);
			ALABBJPHCNG().SetFloat("Crosshair2", EOKMJCIDCDB);
			MJJIEHANFJA().SetFloat("CameraFilterPack/Color_Sepia", ILHJFHFPGBB);
			PGFDGPABBMJ().SetFloat("settings_bindings_controller_type", CCIENBFIKKH);
			MICHFGAOPKM().SetVector("_BlurSize", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 32f, 216f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOMEEFLPEPJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JHJFBCFBKLD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AIKDNGCEDAB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1513f)
			{
				HBJJOCHGOPH = 1323f;
			}
			DIOAAHJDMLK().SetFloat("_FadeFX", HBJJOCHGOPH);
			DIOAAHJDMLK().SetFloat("2", ADPHJHEFAON);
			IKBJACCLPCL().SetFloat("_MainTex2", EOKMJCIDCDB);
			NBPKMLMCHFN.SetFloat("Edited event", ILHJFHFPGBB);
			KDMBOKLMADJ().SetFloat("CameraFilterPack/Atmosphere_Rain_Pro_3D", CCIENBFIKKH);
			INOBFNCKFGK().SetVector("&map=", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 261f, 1255f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PHGCJOPFDOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LMLENGFLEBD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void ABEIEGDHBNO()
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

	private void PCHCFIOHIKK()
	{
		SCShader = Shader.Find(". Sent by actorNr: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MOMHHBKAGKG()
	{
	}

	private void NAOLAJPDGIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 554f)
			{
				HBJJOCHGOPH = 1118f;
			}
			EMDFHOKEGNG().SetFloat("_Value2", HBJJOCHGOPH);
			INOBFNCKFGK().SetFloat("CameraFilterPack/Blend2Camera_VividLight", ADPHJHEFAON);
			OHKGGPFGLFD().SetFloat("ViewMenu", EOKMJCIDCDB);
			EHDJJANLINB().SetFloat("CameraFilterPack/TV_Artefact", ILHJFHFPGBB);
			JIBOKBCPDLC().SetFloat("player.gamecompleted", CCIENBFIKKH);
			ALABBJPHCNG().SetVector("_Far", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1559f, 1552f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IFMAPIDFNLI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BMIOFJFMCBG()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material MCDGIILBNIF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void DGCGGKMNPLD()
	{
	}

	private void DFFKKLAPHCC()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IAJKLKJJKEJ()
	{
	}

	private void HDDECCMEJKA()
	{
	}

	private void EJFJENFKLND()
	{
	}

	private void NCNPAKFAFOE()
	{
		SCShader = Shader.Find("#craftng");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KLOLKEBAPFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JGMEKCFHGLE()
	{
	}

	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 336f)
			{
				HBJJOCHGOPH = 1166f;
			}
			OHKGGPFGLFD().SetFloat("AvatarImage", HBJJOCHGOPH);
			NMDBCDFPGOK().SetFloat("ReconnectAndRejoin() failed. Can only connect while in state 'Disconnected'. Current state: ", ADPHJHEFAON);
			MCDGIILBNIF().SetFloat("Remove Environment Object", EOKMJCIDCDB);
			DOMEEFLPEPJ().SetFloat("_TimeX", ILHJFHFPGBB);
			KDMBOKLMADJ().SetFloat("Most likely the game became empty during the switch to GameServer.", CCIENBFIKKH);
			IKBJACCLPCL().SetVector("Map: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 271f, 304f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JECMJNFGBGC()
	{
		SCShader = Shader.Find("Set particless emission (glow)");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EKCDEFDELMP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 629f)
			{
				HBJJOCHGOPH = 736f;
			}
			PHGCJOPFDOG().SetFloat("_Value3", HBJJOCHGOPH);
			ALABBJPHCNG().SetFloat("StartButton", ADPHJHEFAON);
			DIOAAHJDMLK().SetFloat("ItemsCountText", EOKMJCIDCDB);
			IKBJACCLPCL().SetFloat("masterSteamID", ILHJFHFPGBB);
			MCDGIILBNIF().SetFloat("SetCrosshairEmission", CCIENBFIKKH);
			ALABBJPHCNG().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1149f, 325f));
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

	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 554f)
			{
				HBJJOCHGOPH = 177f;
			}
			NMDBCDFPGOK().SetFloat("mapselector.filter.favoriteonly", HBJJOCHGOPH);
			JIBOKBCPDLC().SetFloat("_MainTex2", ADPHJHEFAON);
			LMLENGFLEBD().SetFloat("ready", EOKMJCIDCDB);
			HKHBBBFLGJH().SetFloat("Object ID. Case-Sensitive", ILHJFHFPGBB);
			KGOLDDBHIFN().SetFloat("_MainTex2", CCIENBFIKKH);
			NMDBCDFPGOK().SetVector("[PlayerBase] SetSpeed error: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 322f, 1628f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ALABBJPHCNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HLDFOJMHKNL()
	{
	}

	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 264f)
			{
				HBJJOCHGOPH = 953f;
			}
			JIBOKBCPDLC().SetFloat("_Value3", HBJJOCHGOPH);
			KDMBOKLMADJ().SetFloat("_Speed", ADPHJHEFAON);
			LMLENGFLEBD().SetFloat("_Near", EOKMJCIDCDB);
			DOMEEFLPEPJ().SetFloat("YES", ILHJFHFPGBB);
			PGFDGPABBMJ().SetFloat("PlayersScrollRectContent", CCIENBFIKKH);
			INOBFNCKFGK().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1733f, 766f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JHJGJJKELJM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CFIAKIJAILI()
	{
	}

	private void MKFFLJGJMLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 456f)
			{
				HBJJOCHGOPH = 1195f;
			}
			GCDFNHMJMIP().SetFloat("_Value5", HBJJOCHGOPH);
			ALABBJPHCNG().SetFloat("Noise & Grain effect failing as noise texture is not assigned. please assign.", ADPHJHEFAON);
			MJJIEHANFJA().SetFloat("Search: ", EOKMJCIDCDB);
			LMLENGFLEBD().SetFloat("_TimeX", ILHJFHFPGBB);
			IFMAPIDFNLI().SetFloat("#getrewardnow ", CCIENBFIKKH);
			DIOAAHJDMLK().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1940f, 277f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DIOAAHJDMLK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IEMEHGCFAPD()
	{
	}

	private void ANBIJFCCANE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 926f)
			{
				HBJJOCHGOPH = 563f;
			}
			NBPKMLMCHFN.SetFloat("MapConfig", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat("skin.hit_wrong", ADPHJHEFAON);
			MICHFGAOPKM().SetFloat(": ", EOKMJCIDCDB);
			KJMECMIGJJA().SetFloat("_TimeX", ILHJFHFPGBB);
			KGOLDDBHIFN().SetFloat("_Extra2", CCIENBFIKKH);
			HKHBBBFLGJH().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 259f, 943f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DIOAAHJDMLK());
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
			if (HBJJOCHGOPH > 1390f)
			{
				HBJJOCHGOPH = 561f;
			}
			EMDFHOKEGNG().SetFloat("CameraFilterPack/Deep_OilPaintHQ", HBJJOCHGOPH);
			OCMBHMLNCEK().SetFloat("_FrustumCornersWS", ADPHJHEFAON);
			KJMECMIGJJA().SetFloat("_Value3", EOKMJCIDCDB);
			DIOAAHJDMLK().SetFloat("Aug", ILHJFHFPGBB);
			GCDFNHMJMIP().SetFloat(" not exist", CCIENBFIKKH);
			MJJIEHANFJA().SetVector("#rt", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 927f, 164f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 299f)
			{
				HBJJOCHGOPH = 1552f;
			}
			GCDFNHMJMIP().SetFloat(" not exist", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("#reward: ", ADPHJHEFAON);
			PGFDGPABBMJ().SetFloat("FPSToggle", EOKMJCIDCDB);
			EHDJJANLINB().SetFloat("#yes", ILHJFHFPGBB);
			PHGCJOPFDOG().SetFloat("_Value", CCIENBFIKKH);
			ALABBJPHCNG().SetVector(" This is not possible to be called for standalone input. Please check your platform and code where this is called", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 642f, 1562f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material MJJIEHANFJA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)94;
		}
		return BJFKDHHMLJH;
	}

	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1644f)
			{
				HBJJOCHGOPH = 1437f;
			}
			OHKGGPFGLFD().SetFloat("curScn", HBJJOCHGOPH);
			LMLENGFLEBD().SetFloat("Object ID. Case-Sensitive", ADPHJHEFAON);
			KGOLDDBHIFN().SetFloat("float,50", EOKMJCIDCDB);
			BLMPMOIDGMG().SetFloat("Joystick1Button4", ILHJFHFPGBB);
			INOBFNCKFGK().SetFloat("[MapsData] Found ", CCIENBFIKKH);
			MJJIEHANFJA().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1066f, 53f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ANCKKLFPGDI()
	{
		SCShader = Shader.Find("BadgeImage");
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material GCDFNHMJMIP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)107;
		}
		return BJFKDHHMLJH;
	}

	private void POJFHDFJOPE()
	{
	}

	private void GGPDKCHEBAG()
	{
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 471f)
			{
				HBJJOCHGOPH = 280f;
			}
			NBPKMLMCHFN.SetFloat("#md5submitionfailed: ", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value4", ADPHJHEFAON);
			OHKGGPFGLFD().SetFloat("_TimeX", EOKMJCIDCDB);
			PHGCJOPFDOG().SetFloat("LevelEditor/icons", ILHJFHFPGBB);
			MICHFGAOPKM().SetFloat("_Value5", CCIENBFIKKH);
			MICHFGAOPKM().SetVector("Aimer Input Module is incompatible with the StandAloneInputSystem, please remove it from the Event System in this scene or disable it when this module is in use", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 825f, 925f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DIOAAHJDMLK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NDAJBJFJGCF()
	{
	}

	private void EDDPLJGKLKJ()
	{
	}

	private void HEBOIFKBLGD()
	{
	}

	private void OIKAPFGPLML(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 752f)
			{
				HBJJOCHGOPH = 810f;
			}
			INOBFNCKFGK().SetFloat("OxOD.lastPath", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat("_Value", ADPHJHEFAON);
			HKHBBBFLGJH().SetFloat("SpectateButton", EOKMJCIDCDB);
			PHGCJOPFDOG().SetFloat("_Value6", ILHJFHFPGBB);
			DOMEEFLPEPJ().SetFloat("_TimeX", CCIENBFIKKH);
			KJMECMIGJJA().SetVector("0.00/0.00", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1689f, 1903f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FABMDEHEDNO()
	{
	}

	private void GMELGGJOPBB()
	{
	}

	private void HPFOFGJPNCI()
	{
		SCShader = Shader.Find("music");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PKBENONAOOL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NNPBKKBFDHH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MKKJICPMPHK()
	{
	}

	private void PAKPHKPDKGE()
	{
		SCShader = Shader.Find("settings.customdataskin");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GLEJGFLCLPJ()
	{
		SCShader = Shader.Find("_Fade");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material IKBJACCLPCL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-113);
		}
		return BJFKDHHMLJH;
	}

	private void HNMIAKKBMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 270f)
			{
				HBJJOCHGOPH = 953f;
			}
			KGOLDDBHIFN().SetFloat("CameraFilterPack/Colors_Brightness", HBJJOCHGOPH);
			KDMBOKLMADJ().SetFloat("inventory.itemscash", ADPHJHEFAON);
			OHKGGPFGLFD().SetFloat("_ScreenResolution", EOKMJCIDCDB);
			DOMEEFLPEPJ().SetFloat("_MainTex2", ILHJFHFPGBB);
			BLMPMOIDGMG().SetFloat("_Value2", CCIENBFIKKH);
			ALABBJPHCNG().SetVector(".lastCheckpoint.comboScore", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1126f, 261f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ALABBJPHCNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LOMDIOLNFHI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material DOMEEFLPEPJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)97;
		}
		return BJFKDHHMLJH;
	}

	private void AEEGKLABFLN()
	{
	}

	private void DLMPALHKMON()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material NMDBCDFPGOK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)100;
		}
		return BJFKDHHMLJH;
	}

	private void MFMIODIAKNI()
	{
	}

	[SpecialName]
	private Material JIBOKBCPDLC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void KPNKCNJBMKB()
	{
	}

	private void LMADKINICIN()
	{
	}

	private void APKNAPHOFHC()
	{
	}

	private void LBIOIEANMGI()
	{
	}

	[SpecialName]
	private Material KJMECMIGJJA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void LIBGAKMKHJJ()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EJJEDJIOFAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ODMPMJPALID()
	{
		SCShader = Shader.Find("Jit ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GAOOPEEBGJA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KDMKDEKCELE()
	{
		SCShader = Shader.Find("[EditorEvent] Exception: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
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
	private Material PGFDGPABBMJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-121);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material INOBFNCKFGK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void LDDKCCMHMIC()
	{
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/FX_Drunk2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MECJHOJPODB()
	{
	}

	private void MNBPNHNAEBK()
	{
		SCShader = Shader.Find("_MainTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 601f)
			{
				HBJJOCHGOPH = 274f;
			}
			KJMECMIGJJA().SetFloat("ERROR You have missing MonoBehaviours on your gameobjects!", HBJJOCHGOPH);
			MCDGIILBNIF().SetFloat(".sawoutdatedmessage", ADPHJHEFAON);
			PHGCJOPFDOG().SetFloat("\\\"", EOKMJCIDCDB);
			PGFDGPABBMJ().SetFloat("_NeutralTonemapperParams1", ILHJFHFPGBB);
			BLMPMOIDGMG().SetFloat("maps.", CCIENBFIKKH);
			NMDBCDFPGOK().SetVector("[PlayerController] ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 498f, 506f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JIBOKBCPDLC());
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

	private void AAEEHINDPNC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ALJEADNKJPO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KCDBBPKIFNJ()
	{
	}

	private void BJNKKNAEGIK()
	{
		SCShader = Shader.Find("closed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HCIPECAOGIA()
	{
	}

	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1145f)
			{
				HBJJOCHGOPH = 976f;
			}
			BLMPMOIDGMG().SetFloat("No Dispatcher exists in the scene. Actions will not be invoked!", HBJJOCHGOPH);
			GCDFNHMJMIP().SetFloat("maps.", ADPHJHEFAON);
			KDMBOKLMADJ().SetFloat("_NeutralTonemapperParams2", EOKMJCIDCDB);
			INOBFNCKFGK().SetFloat("EventMenu", ILHJFHFPGBB);
			DIOAAHJDMLK().SetFloat("[PlayerBase] Loaded custom model: ", CCIENBFIKKH);
			HKHBBBFLGJH().SetVector("_FixDistance", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 319f, 400f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DIOAAHJDMLK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material EGOGECOEONM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
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
			NBPKMLMCHFN.SetFloat("_Value", ADPHJHEFAON);
			NBPKMLMCHFN.SetFloat("_Value2", EOKMJCIDCDB);
			NBPKMLMCHFN.SetFloat("_Value3", ILHJFHFPGBB);
			NBPKMLMCHFN.SetFloat("_Value4", CCIENBFIKKH);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JOJFHFHOCHO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DPLLKHHLDBB()
	{
		SCShader = Shader.Find("[MenuScene] Inited");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OOGIHDLBBLM()
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
	private Material PHGCJOPFDOG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void PJIFJFENPJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1350f)
			{
				HBJJOCHGOPH = 967f;
			}
			ALABBJPHCNG().SetFloat("_Value", HBJJOCHGOPH);
			EGOGECOEONM().SetFloat("Reading preview file failed! Make sure JSON file is filled properly and/or file exists: \"{0}\"", ADPHJHEFAON);
			EMDFHOKEGNG().SetFloat("CameraFilterPack/Blend2Camera_Multiply", EOKMJCIDCDB);
			HKHBBBFLGJH().SetFloat("_TimeX", ILHJFHFPGBB);
			IFMAPIDFNLI().SetFloat("x", CCIENBFIKKH);
			KJMECMIGJJA().SetVector("_copy", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 895f, 987f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IFMAPIDFNLI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material OHKGGPFGLFD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-122);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material ALABBJPHCNG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-76);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IFMAPIDFNLI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KGOLDDBHIFN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
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

	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 525f)
			{
				HBJJOCHGOPH = 408f;
			}
			IFMAPIDFNLI().SetFloat("(\\[ *url=)((?:https\\:\\/\\/)|(?:http\\:\\/\\/)|(?:www\\.))?([a-zA-Z0-9\\-\\.]+\\.[a-zA-Z]{2,3}(?:\\??)[a-zA-Z0-9\\-\\._\\?\\,\\'\\/\\\\\\+&%\\$#\\=~]+)(\\])", HBJJOCHGOPH);
			NMDBCDFPGOK().SetFloat("_ColorRGB", ADPHJHEFAON);
			OHKGGPFGLFD().SetFloat("<b>", EOKMJCIDCDB);
			JIBOKBCPDLC().SetFloat("player.licenceaccepted", ILHJFHFPGBB);
			JIBOKBCPDLC().SetFloat("restrictions", CCIENBFIKKH);
			OHKGGPFGLFD().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 176f, 1971f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOMEEFLPEPJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 534f)
			{
				HBJJOCHGOPH = 1681f;
			}
			DOMEEFLPEPJ().SetFloat("...", HBJJOCHGOPH);
			MJJIEHANFJA().SetFloat("Set sun beat detection sensitivity", ADPHJHEFAON);
			DOMEEFLPEPJ().SetFloat("CameraFilterPack/Blend2Camera_BlueScreen", EOKMJCIDCDB);
			OHKGGPFGLFD().SetFloat("Tab2Content", ILHJFHFPGBB);
			NBPKMLMCHFN.SetFloat("Ok", CCIENBFIKKH);
			EMDFHOKEGNG().SetVector("Reconnect() failed. It seems the client wasn't connected before?! Current state: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1544f, 1330f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MICHFGAOPKM());
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
			if (HBJJOCHGOPH > 1361f)
			{
				HBJJOCHGOPH = 1103f;
			}
			HKHBBBFLGJH().SetFloat("CameraFilterPack/Vision_Warp", HBJJOCHGOPH);
			EGOGECOEONM().SetFloat(";", ADPHJHEFAON);
			LMLENGFLEBD().SetFloat("Tab2Content", EOKMJCIDCDB);
			OCMBHMLNCEK().SetFloat("_ScreenResolution", ILHJFHFPGBB);
			NBPKMLMCHFN.SetFloat("21x3", CCIENBFIKKH);
			DOMEEFLPEPJ().SetVector("menutheme.coldheat", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1392f, 1436f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ALABBJPHCNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1861f)
			{
				HBJJOCHGOPH = 1317f;
			}
			IFMAPIDFNLI().SetFloat("?", HBJJOCHGOPH);
			DIOAAHJDMLK().SetFloat("Screen Space Reflections", ADPHJHEFAON);
			KJMECMIGJJA().SetFloat("finished", EOKMJCIDCDB);
			MCDGIILBNIF().SetFloat("_Value4", ILHJFHFPGBB);
			KJMECMIGJJA().SetFloat("DPADVER", CCIENBFIKKH);
			JIBOKBCPDLC().SetVector(". Going to ignore! Check PhotonServerSettings.RpcList", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 782f, 464f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IKBJACCLPCL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 165f)
			{
				HBJJOCHGOPH = 1495f;
			}
			BLMPMOIDGMG().SetFloat("SetSpeed", HBJJOCHGOPH);
			DOMEEFLPEPJ().SetFloat("Set object anchor to another object", ADPHJHEFAON);
			KGOLDDBHIFN().SetFloat("mapselector.filter.rateduponly", EOKMJCIDCDB);
			DIOAAHJDMLK().SetFloat("_Value2", ILHJFHFPGBB);
			INOBFNCKFGK().SetFloat("SetParticlesParticleSpeed", CCIENBFIKKH);
			KJMECMIGJJA().SetVector("RenderTextureUtilityTempTexture", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1566f, 209f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
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
			if (HBJJOCHGOPH > 783f)
			{
				HBJJOCHGOPH = 481f;
			}
			BLMPMOIDGMG().SetFloat("id", HBJJOCHGOPH);
			OCMBHMLNCEK().SetFloat("MenuScene", ADPHJHEFAON);
			MICHFGAOPKM().SetFloat("HPToggle", EOKMJCIDCDB);
			LMLENGFLEBD().SetFloat("inventory.selected.", ILHJFHFPGBB);
			GCDFNHMJMIP().SetFloat(" ", CCIENBFIKKH);
			GCDFNHMJMIP().SetVector("#failed: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1082f, 1809f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NMDBCDFPGOK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HKHBBBFLGJH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void MJLAAKJHBIM()
	{
	}

	private void CKECPMDEBLL()
	{
	}

	private void NBGIMIDICKE()
	{
		SCShader = Shader.Find("[ResourcesManager] Load image error: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CFFCLAHMBAA()
	{
		SCShader = Shader.Find("_Red_R");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material KDMBOKLMADJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)122;
		}
		return BJFKDHHMLJH;
	}

	private void KNBJBNDGCIJ()
	{
		SCShader = Shader.Find("settings.shaders");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 217f)
			{
				HBJJOCHGOPH = 188f;
			}
			DIOAAHJDMLK().SetFloat("init", HBJJOCHGOPH);
			OCMBHMLNCEK().SetFloat("_FgOverlap", ADPHJHEFAON);
			OCMBHMLNCEK().SetFloat("_Threshhold", EOKMJCIDCDB);
			DOMEEFLPEPJ().SetFloat("menu.hardcoreinfo", ILHJFHFPGBB);
			KDMBOKLMADJ().SetFloat("_Value", CCIENBFIKKH);
			KGOLDDBHIFN().SetVector("UI Extensions/UI Image Crop", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 472f, 652f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 920f)
			{
				HBJJOCHGOPH = 655f;
			}
			NMDBCDFPGOK().SetFloat("_SecondTex", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat("_Red_G", ADPHJHEFAON);
			IKBJACCLPCL().SetFloat("_Green_B", EOKMJCIDCDB);
			EMDFHOKEGNG().SetFloat("_TimeX", ILHJFHFPGBB);
			DOMEEFLPEPJ().SetFloat("_Value10", CCIENBFIKKH);
			PHGCJOPFDOG().SetVector("y", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 354f, 1602f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
