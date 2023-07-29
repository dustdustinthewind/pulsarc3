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
		SCShader = Shader.Find("CameraFilterPack/Noise_TV_3");
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
		SCShader = Shader.Find("View ({3}){0} on {1} {2}");
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
		SCShader = Shader.Find("[PowerUp]");
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
			GCDFNHMJMIP().SetFloat(": ", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("steamid", ADPHJHEFAON);
			EMDFHOKEGNG().SetFloat("_ForceYSwap", EOKMJCIDCDB);
			EGOGECOEONM().SetFloat("cipherText", ILHJFHFPGBB);
			LMLENGFLEBD().SetFloat("menutheme.27thfloor", CCIENBFIKKH);
			PGFDGPABBMJ().SetVector("runas", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1036f, 1377f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OCMBHMLNCEK());
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
			GCDFNHMJMIP().SetFloat("Scene", HBJJOCHGOPH);
			INOBFNCKFGK().SetFloat("ItemNameText", ADPHJHEFAON);
			KJMECMIGJJA().SetFloat("SetSatelliteTrailWidth", EOKMJCIDCDB);
			KJMECMIGJJA().SetFloat("[Up]", ILHJFHFPGBB);
			KDMBOKLMADJ().SetFloat("_EmissionGain", CCIENBFIKKH);
			EMDFHOKEGNG().SetVector("_Offset", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 963f, 708f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EHDJJANLINB());
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
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KOFAMEKHHGD()
	{
		SCShader = Shader.Find("CameraFilterPack/TV_BrokenGlass");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LFAFJKJAEEL()
	{
		SCShader = Shader.Find("[LevelEditorScene] Print Audio Wave: Done");
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
		SCShader = Shader.Find("PickupItemInit");
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
			ALABBJPHCNG().SetFloat("_Value3", HBJJOCHGOPH);
			OHKGGPFGLFD().SetFloat("VoteDownToggle", ADPHJHEFAON);
			KDMBOKLMADJ().SetFloat("[EditorEvent] Exception: ", EOKMJCIDCDB);
			OCMBHMLNCEK().SetFloat("_TimeX", ILHJFHFPGBB);
			OHKGGPFGLFD().SetFloat("settings_bindings_", CCIENBFIKKH);
			KGOLDDBHIFN().SetVector("_MainTex2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 324f, 1266f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EMDFHOKEGNG());
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
			HKHBBBFLGJH().SetFloat("/../", HBJJOCHGOPH);
			NMDBCDFPGOK().SetFloat("<b>HP</b>:", ADPHJHEFAON);
			DIOAAHJDMLK().SetFloat("_Value2", EOKMJCIDCDB);
			ALABBJPHCNG().SetFloat("NewMusicFileSelector", ILHJFHFPGBB);
			OCMBHMLNCEK().SetFloat("menu.playedsolo", CCIENBFIKKH);
			IKBJACCLPCL().SetVector(" By: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 966f, 269f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PGFDGPABBMJ());
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
			EMDFHOKEGNG().SetFloat("#forever", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("_PixelsPerMeterAtOneMeter", ADPHJHEFAON);
			KGOLDDBHIFN().SetFloat("[PlayerController] ", EOKMJCIDCDB);
			INOBFNCKFGK().SetFloat("_FlipAlphaMask", ILHJFHFPGBB);
			LMLENGFLEBD().SetFloat(".", CCIENBFIKKH);
			MJJIEHANFJA().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1028f, 834f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OHKGGPFGLFD());
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
			INOBFNCKFGK().SetFloat("_TimeX", HBJJOCHGOPH);
			IKBJACCLPCL().SetFloat("MapCreationCanvas", ADPHJHEFAON);
			MCDGIILBNIF().SetFloat("maps.", EOKMJCIDCDB);
			PHGCJOPFDOG().SetFloat("_TimeX", ILHJFHFPGBB);
			NMDBCDFPGOK().SetFloat("settings_bindings_", CCIENBFIKKH);
			OHKGGPFGLFD().SetVector("_Bloom0", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 32f, 216f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GCDFNHMJMIP());
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
			KGOLDDBHIFN().SetFloat("_Size", HBJJOCHGOPH);
			HKHBBBFLGJH().SetFloat("[PlayerBase] Config error: musicTime <= 0", ADPHJHEFAON);
			INOBFNCKFGK().SetFloat("CameraFilterPack_Glasses_On7", EOKMJCIDCDB);
			LMLENGFLEBD().SetFloat("EventTimeInputField", ILHJFHFPGBB);
			MICHFGAOPKM().SetFloat("CameraFilterPack/Atmosphere_Rain_Pro_3D", CCIENBFIKKH);
			LMLENGFLEBD().SetVector("&map=", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 261f, 1255f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IKBJACCLPCL());
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
		SCShader = Shader.Find("Warning: Unhandled event ");
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
			DIOAAHJDMLK().SetFloat("_Value4", HBJJOCHGOPH);
			BLMPMOIDGMG().SetFloat("CameraFilterPack/Blend2Camera_VividLight", ADPHJHEFAON);
			OHKGGPFGLFD().SetFloat("ViewMenu", EOKMJCIDCDB);
			MCDGIILBNIF().SetFloat("_Colorisation", ILHJFHFPGBB);
			ALABBJPHCNG().SetFloat("player.gamecompleted", CCIENBFIKKH);
			OCMBHMLNCEK().SetVector("_Far", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1559f, 1552f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
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
		SCShader = Shader.Find("_Red_R");
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
		SCShader = Shader.Find("]");
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
			IKBJACCLPCL().SetFloat("AvatarImage", HBJJOCHGOPH);
			EGOGECOEONM().SetFloat("ReconnectAndRejoin() failed. It seems the client doesn't have any previous room to re-join.", ADPHJHEFAON);
			INOBFNCKFGK().SetFloat("Remove Environment Object", EOKMJCIDCDB);
			GCDFNHMJMIP().SetFloat("_TimeX", ILHJFHFPGBB);
			ALABBJPHCNG().SetFloat("Most likely the game became empty during the switch to GameServer.", CCIENBFIKKH);
			IFMAPIDFNLI().SetVector("[GameScene] Checkpoints count: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 271f, 304f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JECMJNFGBGC()
	{
		SCShader = Shader.Find("SetParticlesParticleSize");
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
			INOBFNCKFGK().SetFloat("_Value3", HBJJOCHGOPH);
			DIOAAHJDMLK().SetFloat("StartButton", ADPHJHEFAON);
			MJJIEHANFJA().SetFloat("ItemsCountText", EOKMJCIDCDB);
			ALABBJPHCNG().SetFloat("masterSteamID", ILHJFHFPGBB);
			NMDBCDFPGOK().SetFloat("SetParticlesGravity", CCIENBFIKKH);
			EHDJJANLINB().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1149f, 325f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EMDFHOKEGNG());
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
			PGFDGPABBMJ().SetFloat("mapselector.filter.officialsortmode", HBJJOCHGOPH);
			PGFDGPABBMJ().SetFloat("_MainTex2", ADPHJHEFAON);
			PHGCJOPFDOG().SetFloat("ready", EOKMJCIDCDB);
			PGFDGPABBMJ().SetFloat("Object ID. Case-Sensitive", ILHJFHFPGBB);
			NMDBCDFPGOK().SetFloat("CameraFilterPack_Broken_Screen1", CCIENBFIKKH);
			ALABBJPHCNG().SetVector("[PlayerBase] Checkpoint error: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 322f, 1628f));
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
			KGOLDDBHIFN().SetFloat("_Value3", HBJJOCHGOPH);
			NMDBCDFPGOK().SetFloat("_MainTex2", ADPHJHEFAON);
			KDMBOKLMADJ().SetFloat("_Near", EOKMJCIDCDB);
			INOBFNCKFGK().SetFloat("NO", ILHJFHFPGBB);
			PHGCJOPFDOG().SetFloat("PlayersScrollRectContent", CCIENBFIKKH);
			LMLENGFLEBD().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1733f, 766f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
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
			JIBOKBCPDLC().SetFloat("_Value6", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("_NoiseTex", ADPHJHEFAON);
			IFMAPIDFNLI().SetFloat("Search: ", EOKMJCIDCDB);
			EHDJJANLINB().SetFloat("_Amount", ILHJFHFPGBB);
			BLMPMOIDGMG().SetFloat("http", CCIENBFIKKH);
			ALABBJPHCNG().SetVector("_Distortion", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1940f, 277f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OHKGGPFGLFD());
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
			IKBJACCLPCL().SetFloat("--------------------------------", HBJJOCHGOPH);
			EGOGECOEONM().SetFloat("skin.hit_wrong", ADPHJHEFAON);
			EMDFHOKEGNG().SetFloat(": ", EOKMJCIDCDB);
			MJJIEHANFJA().SetFloat("_TimeX", ILHJFHFPGBB);
			INOBFNCKFGK().SetFloat("The given 2D texture ", CCIENBFIKKH);
			OHKGGPFGLFD().SetVector("CameraFilterPack/OldFilm_Cutting1", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 259f, 943f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PHGCJOPFDOG());
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
			HKHBBBFLGJH().SetFloat("_TimeX", HBJJOCHGOPH);
			IFMAPIDFNLI().SetFloat("_HeightParams", ADPHJHEFAON);
			KDMBOKLMADJ().SetFloat("_Value3", EOKMJCIDCDB);
			LMLENGFLEBD().SetFloat("Oct", ILHJFHFPGBB);
			ALABBJPHCNG().SetFloat("[PlayerController] ", CCIENBFIKKH);
			JIBOKBCPDLC().SetVector("Horizontal", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 927f, 164f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MJJIEHANFJA());
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
			EHDJJANLINB().SetFloat("[PlayerController] ", HBJJOCHGOPH);
			ALABBJPHCNG().SetFloat("#finished", ADPHJHEFAON);
			OCMBHMLNCEK().SetFloat("Scene", EOKMJCIDCDB);
			EHDJJANLINB().SetFloat("#ok", ILHJFHFPGBB);
			INOBFNCKFGK().SetFloat("_Value2", CCIENBFIKKH);
			JIBOKBCPDLC().SetVector(" This is not possible to be called for standalone input. Please check your platform and code where this is called", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 642f, 1562f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EHDJJANLINB());
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
			DOMEEFLPEPJ().SetFloat("curScn", HBJJOCHGOPH);
			GCDFNHMJMIP().SetFloat("Object ID. Case-Sensitive", ADPHJHEFAON);
			MCDGIILBNIF().SetFloat("float,50", EOKMJCIDCDB);
			EMDFHOKEGNG().SetFloat("Joystick1Button5", ILHJFHFPGBB);
			NBPKMLMCHFN.SetFloat("[MapsData] Workshop maps was loaded", CCIENBFIKKH);
			IKBJACCLPCL().SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1066f, 53f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ANCKKLFPGDI()
	{
		SCShader = Shader.Find("BadgeText");
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
			INOBFNCKFGK().SetFloat("#tryagain", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("_Value4", ADPHJHEFAON);
			KGOLDDBHIFN().SetFloat("_Value", EOKMJCIDCDB);
			IKBJACCLPCL().SetFloat("_EmissionColor", ILHJFHFPGBB);
			LMLENGFLEBD().SetFloat("_ScreenResolution", CCIENBFIKKH);
			IFMAPIDFNLI().SetVector("Vertical", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 825f, 925f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PHGCJOPFDOG());
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
			EHDJJANLINB().SetFloat("/../", HBJJOCHGOPH);
			IKBJACCLPCL().SetFloat("_Value", ADPHJHEFAON);
			DIOAAHJDMLK().SetFloat("SpectateButton", EOKMJCIDCDB);
			INOBFNCKFGK().SetFloat("_Value4", ILHJFHFPGBB);
			KJMECMIGJJA().SetFloat("_Value2", CCIENBFIKKH);
			ALABBJPHCNG().SetVector("Preparing content", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1689f, 1903f));
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
		SCShader = Shader.Find("/");
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
		SCShader = Shader.Find(" url: ");
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
			PGFDGPABBMJ().SetFloat("_Val", HBJJOCHGOPH);
			IKBJACCLPCL().SetFloat("[ItemsHandler] Item not found:", ADPHJHEFAON);
			DIOAAHJDMLK().SetFloat("_ScreenResolution", EOKMJCIDCDB);
			OHKGGPFGLFD().SetFloat("_MainTex2", ILHJFHFPGBB);
			PHGCJOPFDOG().SetFloat("_Value2", CCIENBFIKKH);
			NMDBCDFPGOK().SetVector(".lastCheckpoint.playerdistance", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1126f, 261f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DIOAAHJDMLK());
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
		SCShader = Shader.Find("CameraFilterPack/Distortion_ShockWaveManual");
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
		SCShader = Shader.Find("PhotonMono");
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
		SCShader = Shader.Find("_EmissionColor");
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
		SCShader = Shader.Find("_LowRez");
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
			GCDFNHMJMIP().SetFloat("PhotonView with ID ", HBJJOCHGOPH);
			MJJIEHANFJA().SetFloat(".lastCheckpoint.bgcolor", ADPHJHEFAON);
			INOBFNCKFGK().SetFloat("itemdefid[0]", EOKMJCIDCDB);
			OHKGGPFGLFD().SetFloat("_Exposure", ILHJFHFPGBB);
			PHGCJOPFDOG().SetFloat("maps.", CCIENBFIKKH);
			MICHFGAOPKM().SetVector(" not exist", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 498f, 506f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KJMECMIGJJA());
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
		SCShader = Shader.Find("hidden");
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
			NMDBCDFPGOK().SetFloat("No Dispatcher exists in the scene. Actions will not be invoked!", HBJJOCHGOPH);
			EMDFHOKEGNG().SetFloat("maps.", ADPHJHEFAON);
			PGFDGPABBMJ().SetFloat("_WhiteBalance", EOKMJCIDCDB);
			IKBJACCLPCL().SetFloat("ViewMenu", ILHJFHFPGBB);
			KGOLDDBHIFN().SetFloat("[Down]", CCIENBFIKKH);
			BLMPMOIDGMG().SetVector("_FixDistance", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 319f, 400f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MCDGIILBNIF());
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
		SCShader = Shader.Find("Loading...");
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
			KJMECMIGJJA().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			LMLENGFLEBD().SetFloat("File not found: {0}", ADPHJHEFAON);
			IFMAPIDFNLI().SetFloat("_MainTex2", EOKMJCIDCDB);
			DOMEEFLPEPJ().SetFloat("_Value", ILHJFHFPGBB);
			JIBOKBCPDLC().SetFloat("z", CCIENBFIKKH);
			JIBOKBCPDLC().SetVector(".sawoutdatedmessage", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 895f, 987f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KDMBOKLMADJ());
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
			NBPKMLMCHFN.SetFloat("(\\[ *url=)((?:https\\:\\/\\/)|(?:http\\:\\/\\/)|(?:www\\.))?([a-zA-Z0-9\\-\\.]+\\.[a-zA-Z]{2,3}(?:\\??)[a-zA-Z0-9\\-\\._\\?\\,\\'\\/\\\\\\+&%\\$#\\=~]+)(\\])", HBJJOCHGOPH);
			JIBOKBCPDLC().SetFloat("_ColorRGB", ADPHJHEFAON);
			NBPKMLMCHFN.SetFloat("<b>", EOKMJCIDCDB);
			IKBJACCLPCL().SetFloat("player.licenceaccepted", ILHJFHFPGBB);
			MCDGIILBNIF().SetFloat("restrictions", CCIENBFIKKH);
			MCDGIILBNIF().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 176f, 1971f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EGOGECOEONM());
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
			DIOAAHJDMLK().SetFloat("...", HBJJOCHGOPH);
			HKHBBBFLGJH().SetFloat("Set sun beat detection sensitivity", ADPHJHEFAON);
			KJMECMIGJJA().SetFloat("CameraFilterPack/Blend2Camera_BlueScreen", EOKMJCIDCDB);
			LMLENGFLEBD().SetFloat("Tab2Content", ILHJFHFPGBB);
			EHDJJANLINB().SetFloat("PLEASE WAIT", CCIENBFIKKH);
			JIBOKBCPDLC().SetVector("Reconnect() disabled the offline mode. No longer offline.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1544f, 1330f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IKBJACCLPCL());
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
			EGOGECOEONM().SetFloat("_Value", HBJJOCHGOPH);
			GCDFNHMJMIP().SetFloat(":", ADPHJHEFAON);
			KGOLDDBHIFN().SetFloat("Tab2Content", EOKMJCIDCDB);
			LMLENGFLEBD().SetFloat("_TimeX", ILHJFHFPGBB);
			BLMPMOIDGMG().SetFloat("inventory.selected.", CCIENBFIKKH);
			INOBFNCKFGK().SetVector("shader.none", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1392f, 1436f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OHKGGPFGLFD());
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
			HKHBBBFLGJH().SetFloat("SubmitUserVote:", HBJJOCHGOPH);
			IFMAPIDFNLI().SetFloat("_CurrentMipLevel", ADPHJHEFAON);
			PGFDGPABBMJ().SetFloat("win", EOKMJCIDCDB);
			NMDBCDFPGOK().SetFloat("BloodAlternative2", ILHJFHFPGBB);
			PGFDGPABBMJ().SetFloat("DPADVER", CCIENBFIKKH);
			MICHFGAOPKM().SetVector(" but this PhotonView does not exist! View was/is ours.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 782f, 464f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IFMAPIDFNLI());
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
			LMLENGFLEBD().SetFloat("SetTrailZoomSpeed", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("SetSunColors", ADPHJHEFAON);
			IKBJACCLPCL().SetFloat("mapselector.filter.subscribedonly", EOKMJCIDCDB);
			ALABBJPHCNG().SetFloat("_Value2", ILHJFHFPGBB);
			PHGCJOPFDOG().SetFloat("Set Particles Speed", CCIENBFIKKH);
			PGFDGPABBMJ().SetVector("Hidden/DepthOfField/DepthOfField", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1566f, 209f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EGOGECOEONM());
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
			PGFDGPABBMJ().SetFloat("Object ID. Case-Sensitive", HBJJOCHGOPH);
			DOMEEFLPEPJ().SetFloat("inventory.selected.", ADPHJHEFAON);
			NMDBCDFPGOK().SetFloat("settings.showHP", EOKMJCIDCDB);
			IKBJACCLPCL().SetFloat("inventory.selected.", ILHJFHFPGBB);
			LMLENGFLEBD().SetFloat("Bad SegmentType passed in to CreateLineCap. Must be SegmentType.Start or SegmentType.End", CCIENBFIKKH);
			PHGCJOPFDOG().SetVector("#failed: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1082f, 1809f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
		SCShader = Shader.Find(".jpg");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CFFCLAHMBAA()
	{
		SCShader = Shader.Find("_Red_G");
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
			IKBJACCLPCL().SetFloat("init", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("_ForegroundBlurExtrude", ADPHJHEFAON);
			JIBOKBCPDLC().SetFloat("_Saturation", EOKMJCIDCDB);
			KGOLDDBHIFN().SetFloat("hardcoreinfo", ILHJFHFPGBB);
			DIOAAHJDMLK().SetFloat("_Value3", CCIENBFIKKH);
			EGOGECOEONM().SetVector("Default UI Material", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 472f, 652f));
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
			KGOLDDBHIFN().SetFloat("_Offsets", HBJJOCHGOPH);
			IFMAPIDFNLI().SetFloat("_Red_B", ADPHJHEFAON);
			MCDGIILBNIF().SetFloat("_Blue_G", EOKMJCIDCDB);
			EHDJJANLINB().SetFloat("_TimeX", ILHJFHFPGBB);
			LMLENGFLEBD().SetFloat("_Value10", CCIENBFIKKH);
			EHDJJANLINB().SetVector("x", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 354f, 1602f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
