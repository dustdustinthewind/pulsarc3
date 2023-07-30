// CameraFilterPack_Edge_Neon
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Edge/Neon")]
[ExecuteInEditMode]
public class CameraFilterPack_Edge_Neon : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(1f, 10f)]
	public float EdgeWeight = 1f;

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

	private void NDBPCNICGLC()
	{
		SCShader = Shader.Find("blue");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material OJMHIMIPKME()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-103);
		}
		return BJFKDHHMLJH;
	}

	private void DAHFFNNIGML()
	{
		SCShader = Shader.Find("ns.exitgames.com");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CNGAJDBOCLJ()
	{
		SCShader = Shader.Find("G:");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LCDJFJIBADI()
	{
	}

	private void LMBDNPLDGIJ()
	{
	}

	private void PHJJHFBLICM()
	{
	}

	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 885f)
			{
				HBJJOCHGOPH = 1171f;
			}
			MLMKCOINOOH().SetFloat("DestroyPlayerObjects() failed, cause players can only destroy their own GameObjects. A Master Client can destroy anyone's. This is master: ", HBJJOCHGOPH);
			KEMJNOMIPHN().SetFloat("maps.", EdgeWeight);
			MLMKCOINOOH().SetVector("InventoryContent", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MODENHKMKOC()
	{
		SCShader = Shader.Find(" not exist");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CBIBDOIBJAI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JDKHBGDEONK()
	{
		SCShader = Shader.Find("/Segment-[Up]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MKOMIDCPCDC()
	{
		SCShader = Shader.Find("DPADVER");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Edge_Neon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GOIMKCCICFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1721f)
			{
				HBJJOCHGOPH = 1655f;
			}
			HKIMAANBGMJ().SetFloat("FinalScoreSmallText", HBJJOCHGOPH);
			MLMKCOINOOH().SetFloat("#close", EdgeWeight);
			NBPKMLMCHFN.SetVector("CameraFilterPack/Blend2Camera_Difference", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ELDMKIAPNGP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ANCKKLFPGDI()
	{
		SCShader = Shader.Find("yesterday");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KFACDBHDAOD()
	{
	}

	[SpecialName]
	private Material FGENHBKMPDA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)80;
		}
		return BJFKDHHMLJH;
	}

	private void GJCOELHNLJE()
	{
	}

	private void HIKKPDACJGI()
	{
	}

	private void OFIMMFHFHDD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IGPCNCJIEOJ()
	{
		SCShader = Shader.Find("float,1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material ENKPNJMPDEB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void OCCGJMPAJIK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material FAIFBBGFAIB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material EMDFHOKEGNG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.DontSave;
		}
		return BJFKDHHMLJH;
	}

	private void BMGPBIBPBLA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material INOBFNCKFGK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)77;
		}
		return BJFKDHHMLJH;
	}

	private void DNNFHBOOPIN()
	{
		SCShader = Shader.Find("GameScene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material LELKBCALFCF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)65;
		}
		return BJFKDHHMLJH;
	}

	private void OMIHEBMMCPG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 957f)
			{
				HBJJOCHGOPH = 84f;
			}
			HKIMAANBGMJ().SetFloat("entering", HBJJOCHGOPH);
			MLMKCOINOOH().SetFloat("settings.enableranking", EdgeWeight);
			NLFJGMBCICG().SetVector("maps.", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NEFHGMNAPEP()
	{
		SCShader = Shader.Find(" - ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IKDNLHLBHID()
	{
		SCShader = Shader.Find("Search: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material DOMEEFLPEPJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void EHJJFJCKGAJ()
	{
	}

	private void LKJMIODJGCM()
	{
	}

	private void HGDDCINLDAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AKCADICOFDD()
	{
	}

	private void LLJLDLLNFBH()
	{
	}

	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1690f)
			{
				HBJJOCHGOPH = 19f;
			}
			ABHDNGIHBKE().SetFloat("#activechallenges", HBJJOCHGOPH);
			CEKJODEAMGB().SetFloat("_ClutTex", EdgeWeight);
			DEFBJOCJJKF().SetVector("blue", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material CEKJODEAMGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void FOMNCPKKCFN()
	{
	}

	private void ALJEJJCIMJN()
	{
		SCShader = Shader.Find("SelectionBox component is on a gameObject with a Canvas Scaler component. As of now, Canvas Scalers without the default settings throw off the coordinates of the selection box. Canvas Scaler has been removed.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DLMPALHKMON()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void BGDPIHMAACO()
	{
		SCShader = Shader.Find("NO");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ABEIEGDHBNO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material OKJOKHGJHGF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void MMOKKAPFGAK()
	{
		SCShader = Shader.Find("CameraFilterPack/Colors_Adjust_FullColors");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1875f)
			{
				HBJJOCHGOPH = 998f;
			}
			OKJOKHGJHGF().SetFloat("#{0:00} '{1}'{2} {3}", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("[PlayerBase] Highscore: ", EdgeWeight);
			OJMHIMIPKME().SetVector("_ScreenResolution", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HCDBNAKGDJC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MKFLBEGJJDC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material OCHJIMJNEMO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-121);
		}
		return BJFKDHHMLJH;
	}

	private void MECJHOJPODB()
	{
	}

	[SpecialName]
	private Material LPMLLJKMAMP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void KHIGHFJKPFG()
	{
		SCShader = Shader.Find("_Offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EFECEKPFOEM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PKBENONAOOL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LECCHIAFGGE()
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

	private void FODKODGPPDA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KMEONPMCNJG()
	{
	}

	[SpecialName]
	private Material JIBOKBCPDLC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-107);
		}
		return BJFKDHHMLJH;
	}

	private void ELGOMIMONOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1743f)
			{
				HBJJOCHGOPH = 1966f;
			}
			HEINDEMCGIK().SetFloat("]", HBJJOCHGOPH);
			EMDFHOKEGNG().SetFloat("OpAuthenticate()", EdgeWeight);
			INOBFNCKFGK().SetVector("#ok", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LELKBCALFCF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CIHGFHNNFEE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OFPPIKHNJOD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MNBPNHNAEBK()
	{
		SCShader = Shader.Find("The other scroll rect doesnt support scrolling vertically");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JOJFHFHOCHO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HIPEHGNBJMN()
	{
		SCShader = Shader.Find("Warning: Unhandled event ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1111f)
			{
				HBJJOCHGOPH = 1804f;
			}
			GJHLADDCMFF().SetFloat("hardcoreinfo", HBJJOCHGOPH);
			EMDFHOKEGNG().SetFloat("skin.", EdgeWeight);
			MLMKCOINOOH().SetVector("menu.enableselectormusic", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KOJKBFDNGDK()
	{
		SCShader = Shader.Find(":</b> ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
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
			NBPKMLMCHFN.SetFloat("_EdgeWeight", EdgeWeight);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HONBLGFDMLL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HIFLPHLGLFG()
	{
	}

	private void FIKFJDFELIP()
	{
		SCShader = Shader.Find(" - PUBLISHED #");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void ANDELGODEOC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OKLAJINHPAN()
	{
		SCShader = Shader.Find("RecieveChatActionMessage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JBNPEHMDCMI()
	{
	}

	private void JOPCCCCHNLI()
	{
		SCShader = Shader.Find("/music");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
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
	private Material GKILCDHJFEG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NLFJGMBCICG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void INLDEHPAMJC()
	{
	}

	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1148f)
			{
				HBJJOCHGOPH = 777f;
			}
			DOMEEFLPEPJ().SetFloat("RPCs can only be sent in rooms. Call of \"", HBJJOCHGOPH);
			MLMKCOINOOH().SetFloat("ControllerLeftY", EdgeWeight);
			OCHJIMJNEMO().SetVector("[MapsData] Installed: ", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DOEPOGLEGLE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EKCKJLFFAID()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OKHBBIKDIEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 163f)
			{
				HBJJOCHGOPH = 454f;
			}
			CEKJODEAMGB().SetFloat("It seems some instantiation is not completed, as instantiation data is used. You should make sure instantiations are paused when calling this method. Cleaning now, despite this.", HBJJOCHGOPH);
			DOMEEFLPEPJ().SetFloat("Description goes here", EdgeWeight);
			HEINDEMCGIK().SetVector("GameScene", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LLDHEJIEDHO()
	{
	}

	private void NKFDNIAKGEO()
	{
		SCShader = Shader.Find("uploads/Intralism/mods_terms.pdf");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 882f)
			{
				HBJJOCHGOPH = 1074f;
			}
			GHHPOGODBHB().SetFloat("solo", HBJJOCHGOPH);
			INOBFNCKFGK().SetFloat("CameraFilterPack_Glasses_On2", EdgeWeight);
			NLFJGMBCICG().SetVector("_ScreenResolution", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HAIAHJPCPAG()
	{
		SCShader = Shader.Find("Myst_Color");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material HCGJCMDJPGD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material FLOHGDECHHH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)70;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KEMJNOMIPHN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material NBMPPNFKFLB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~HideFlags.HideInHierarchy;
		}
		return BJFKDHHMLJH;
	}

	private void PAEGLMEOKHP()
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

	private void FKDEEJFNNJC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1888f)
			{
				HBJJOCHGOPH = 520f;
			}
			FGENHBKMPDA().SetFloat("_Distortion", HBJJOCHGOPH);
			EMDFHOKEGNG().SetFloat("CameraFilterPack/Blend2Camera_LinearBurn", EdgeWeight);
			DOMEEFLPEPJ().SetVector("EnableRankedNotificationsToggle", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, INOBFNCKFGK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FGOPJMGNHGO()
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-78);
		}
		return BJFKDHHMLJH;
	}

	private void IMCKJCHKMKB()
	{
		SCShader = Shader.Find("Set Satellite Input");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IBLGHLNNAHN()
	{
		SCShader = Shader.Find("settings.hitvariation");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material MLMKCOINOOH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave | HideFlags.HideInHierarchy;
		}
		return BJFKDHHMLJH;
	}

	private void KHGEBPHKAGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 88f)
			{
				HBJJOCHGOPH = 1004f;
			}
			KEMJNOMIPHN().SetFloat("00", HBJJOCHGOPH);
			OCHJIMJNEMO().SetFloat("Default UI Material", EdgeWeight);
			GJHLADDCMFF().SetVector("[PlayerController] ", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LELKBCALFCF());
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
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 585f)
			{
				HBJJOCHGOPH = 277f;
			}
			OIMMPLPBLBK().SetFloat("lobby '{0}'[{1}]", HBJJOCHGOPH);
			HEINDEMCGIK().SetFloat("Failed to 'network-remove' GameObject because has no PhotonView components: ", EdgeWeight);
			INOBFNCKFGK().SetVector("_Blue_B", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GHHPOGODBHB());
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
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void EJJEDJIOFAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FHPFJBFCOOF()
	{
		SCShader = Shader.Find("_Value1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AIJGAJIOJDJ()
	{
	}

	private void Update()
	{
	}

	private void EGEGNHLODAA()
	{
	}

	[SpecialName]
	private Material GJHLADDCMFF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)126;
		}
		return BJFKDHHMLJH;
	}

	private void OOGIHDLBBLM()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MMBPLGGLPDB()
	{
	}

	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1469f)
			{
				HBJJOCHGOPH = 210f;
			}
			LELKBCALFCF().SetFloat("Lerp speed. Recomended 10", HBJJOCHGOPH);
			OIMMPLPBLBK().SetFloat("Xbox Home", EdgeWeight);
			JIBOKBCPDLC().SetVector("CameraFilterPack/BlurTiltShift", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HEINDEMCGIK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return BJFKDHHMLJH;
	}

	private void FBPHNEJBDJN()
	{
		SCShader = Shader.Find(" BETA");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LMADKINICIN()
	{
	}

	[SpecialName]
	private Material HKIMAANBGMJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)110;
		}
		return BJFKDHHMLJH;
	}

	private void AAPKBNDHBLI()
	{
	}

	private void FJIKDJAMOHA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 692f)
			{
				HBJJOCHGOPH = 1938f;
			}
			NLFJGMBCICG().SetFloat("#", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("Loaded Game: ", EdgeWeight);
			LPMLLJKMAMP().SetVector("\r\n", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material OIMMPLPBLBK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material DEFBJOCJJKF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-82);
		}
		return BJFKDHHMLJH;
	}

	private void GENCBNFIILN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1288f)
			{
				HBJJOCHGOPH = 1550f;
			}
			FGENHBKMPDA().SetFloat("settings.crosshairopacity", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("DPADHOR", EdgeWeight);
			GHHPOGODBHB().SetVector("[Down]", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FDMAEPOHDMK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NAOLAJPDGIC()
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
			if (HBJJOCHGOPH > 1187f)
			{
				HBJJOCHGOPH = 1053f;
			}
			JIBOKBCPDLC().SetFloat("DPADVER", HBJJOCHGOPH);
			INOBFNCKFGK().SetFloat("_Axis", EdgeWeight);
			JIBOKBCPDLC().SetVector("_TimeX", new Vector2(Screen.width, Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOMEEFLPEPJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JFMIDILENDO()
	{
	}

	[SpecialName]
	private Material GHHPOGODBHB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy;
		}
		return BJFKDHHMLJH;
	}

	private void FMFNILJIEIA()
	{
		SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LBPCODPOJAH()
	{
	}
}
