// CameraFilterPack_TV_Artefact
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/TV/Artefact")]
public class CameraFilterPack_TV_Artefact : MonoBehaviour
{
	public Shader SCShader;

	private Vector4 GOIJPFAHKPE;

	private float HBJJOCHGOPH = 1f;

	[Range(0f, 1f)]
	public float Fade = 1f;

	[Range(-10f, 10f)]
	public float Colorisation = 1f;

	[Range(-10f, 10f)]
	public float Parasite = 1f;

	[Range(-10f, 10f)]
	public float Noise = 1f;

	private Material BJFKDHHMLJH;

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

	private void LOMDIOLNFHI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EJJEDJIOFAB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AEIJFLJEABG()
	{
	}

	private void FGBDGGCBFLP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PHJJHFBLICM()
	{
	}

	private void OIBMHPIFAKK()
	{
	}

	private void FIJHDKIPENG()
	{
		SCShader = Shader.Find("_MatrixColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 823f)
			{
				HBJJOCHGOPH = 198f;
			}
			MHBAIEKFBIJ().SetFloat("Case-Sensitive", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("menu.tabid", Colorisation);
			ADBKPGFMNKO().SetFloat("---", Parasite);
			DOMEEFLPEPJ().SetFloat("Error: I/O Failure", Noise);
			BFGNMFCNDBC().SetFloat("menu.relaxinfo", Fade);
			NBPKMLMCHFN.SetVector("[LevelEditorScene] Print Audio Wave: Done", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 796f, 185f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
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
			if (HBJJOCHGOPH > 1536f)
			{
				HBJJOCHGOPH = 1495f;
			}
			EOCCJGIGEGJ().SetFloat("st", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("StartButton", Colorisation);
			DOHGBNPMBKG().SetFloat("menu.playedsolo", Parasite);
			HHLFDHNEIAH().SetFloat("_ReflectionBlur", Noise);
			DNLMFEGJJDD().SetFloat("LevelProgressBar", Fade);
			ADBKPGFMNKO().SetVector("default", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1418f, 642f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1520f)
			{
				HBJJOCHGOPH = 794f;
			}
			AELJLBOJAIL().SetFloat("_Value7", HBJJOCHGOPH);
			MHBAIEKFBIJ().SetFloat("_TimeX", Colorisation);
			AELJLBOJAIL().SetFloat("Copy from ", Parasite);
			MHBAIEKFBIJ().SetFloat(".highscore", Noise);
			DOMEEFLPEPJ().SetFloat("SUBMIT", Fade);
			EOCCJGIGEGJ().SetVector("Anomaly_Near", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 457f, 464f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KJMECMIGJJA());
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
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1761f)
			{
				HBJJOCHGOPH = 1465f;
			}
			NBPKMLMCHFN.SetFloat("#rategameinfo", HBJJOCHGOPH);
			ADBKPGFMNKO().SetFloat("#", Colorisation);
			ADBKPGFMNKO().SetFloat("settings.fps", Parasite);
			LPMLLJKMAMP().SetFloat("<b>#", Noise);
			DOHGBNPMBKG().SetFloat("Default UI Material", Fade);
			BFGNMFCNDBC().SetVector(" registered.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 899f, 915f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOMEEFLPEPJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material FHFLKLMFHOI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-105);
		}
		return BJFKDHHMLJH;
	}

	private void IHLMNAGPKDA()
	{
		SCShader = Shader.Find("Anomaly_Near");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HAIAHJPCPAG()
	{
		SCShader = Shader.Find("Vertical");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BFEILOMHNPC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material EOCCJGIGEGJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)106;
		}
		return BJFKDHHMLJH;
	}

	private void OMIHEBMMCPG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1413f)
			{
				HBJJOCHGOPH = 65f;
			}
			HNFFHCLNBDN().SetFloat("player.blackwhite", HBJJOCHGOPH);
			HHLFDHNEIAH().SetFloat("[FileSelector] Dialog canceled", Colorisation);
			KJMECMIGJJA().SetFloat("player.dragon", Parasite);
			KJMECMIGJJA().SetFloat("_Offsets", Noise);
			PDEAHJPOMEF().SetFloat("_Value5", Fade);
			AELJLBOJAIL().SetVector("_Value12", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 191f, 1096f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IBPAMDEAGJL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material BFGNMFCNDBC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KJMECMIGJJA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void EDBEHEKMGFH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EHJJFJCKGAJ()
	{
	}

	private void EFJDNLGNACH()
	{
		SCShader = Shader.Find("SpawnObj");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JIAAFKOPEKO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1447f)
			{
				HBJJOCHGOPH = 822f;
			}
			DNLMFEGJJDD().SetFloat("_Value", HBJJOCHGOPH);
			HNFFHCLNBDN().SetFloat("/?player=", Colorisation);
			DNLMFEGJJDD().SetFloat("id", Parasite);
			AELJLBOJAIL().SetFloat("OpAuthenticate()", Noise);
			EOCCJGIGEGJ().SetFloat("_Value3", Fade);
			AELJLBOJAIL().SetVector("#md5submitionfailed: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 925f, 1418f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHLFDHNEIAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DOKAKEMDALN()
	{
		SCShader = Shader.Find("CameraFilterPack/OldFilm_Cutting1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KFACDBHDAOD()
	{
	}

	private void HNDNDPECBPL()
	{
	}

	private void IMCKJCHKMKB()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material AELJLBOJAIL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1310f)
			{
				HBJJOCHGOPH = 649f;
			}
			PDEAHJPOMEF().SetFloat("%", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("NewIconFileSelector", Colorisation);
			FHFLKLMFHOI().SetFloat("LoadMapCanvas", Parasite);
			DNLMFEGJJDD().SetFloat("#tryagain", Noise);
			DNLMFEGJJDD().SetFloat("Failed to InstantiateSceneObject prefab:", Fade);
			DOHGBNPMBKG().SetVector("[LevelEditorScene] Map submitted!", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1015f, 1197f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material PDEAHJPOMEF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)64;
		}
		return BJFKDHHMLJH;
	}

	private void BNEJMABFKJE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EODOHEAKJFO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ELDMKIAPNGP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FBMDHDBELEK()
	{
	}

	[SpecialName]
	private Material DNLMFEGJJDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-122);
		}
		return BJFKDHHMLJH;
	}

	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1412f)
			{
				HBJJOCHGOPH = 1165f;
			}
			DNLMFEGJJDD().SetFloat("_MainTex2", HBJJOCHGOPH);
			HHLFDHNEIAH().SetFloat("</b>", Colorisation);
			EOCCJGIGEGJ().SetFloat("x", Parasite);
			PDEAHJPOMEF().SetFloat("_Color_R", Noise);
			DOHGBNPMBKG().SetFloat("turn: {0:0}", Fade);
			FHFLKLMFHOI().SetVector("Exit to menu?", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 479f, 1161f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Update()
	{
	}

	[SpecialName]
	private Material HNFFHCLNBDN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)98;
		}
		return BJFKDHHMLJH;
	}

	private void HIPEHGNBJMN()
	{
		SCShader = Shader.Find("#close");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CNGAJDBOCLJ()
	{
		SCShader = Shader.Find("https://steamcommunity.com/sharedfiles/filedetails/?id=");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KDMANOEMOCA()
	{
		SCShader = Shader.Find("#yes");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 277f)
			{
				HBJJOCHGOPH = 1337f;
			}
			DOHGBNPMBKG().SetFloat("No Name", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("RanksButton", Colorisation);
			DNLMFEGJJDD().SetFloat("CameraFilterPack/AAA_Blood", Parasite);
			MHBAIEKFBIJ().SetFloat("IntraTime", Noise);
			DOMEEFLPEPJ().SetFloat("UseScanLineSize", Fade);
			HNFFHCLNBDN().SetVector(". Verify the Prefab is in a Resources folder (and not in a subfolder)", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1831f, 1960f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LPMLLJKMAMP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void BKGJOECFMID()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KCNIHHNMFFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1724f)
			{
				HBJJOCHGOPH = 955f;
			}
			KHCLIAMBBNC().SetFloat("_TimeX", HBJJOCHGOPH);
			FHFLKLMFHOI().SetFloat("_HighlightSuppression", Colorisation);
			AELJLBOJAIL().SetFloat(" but this PhotonView does not exist! View was/is ours.", Parasite);
			ADBKPGFMNKO().SetFloat("EventTimeInputField", Noise);
			DOMEEFLPEPJ().SetFloat("GlassColor", Fade);
			DNLMFEGJJDD().SetVector("FinalScoreSmallText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 898f, 1811f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CCFEDENFNEF()
	{
		SCShader = Shader.Find("#lives");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BGFJOEPFOPM()
	{
	}

	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 5f)
			{
				HBJJOCHGOPH = 240f;
			}
			LPMLLJKMAMP().SetFloat("Set environment sprite color and alpha.", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("maps.", Colorisation);
			LPMLLJKMAMP().SetFloat("_Offsets", Parasite);
			ADBKPGFMNKO().SetFloat("&", Noise);
			KJMECMIGJJA().SetFloat(" cannot be used as a 3D LUT.", Fade);
			PDEAHJPOMEF().SetVector("[LocalizationService] All languages: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 992f, 1995f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EKCDEFDELMP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FGNFILLNPJK()
	{
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OCMKCBBCEFG()
	{
	}

	private void PFNFPINPCMH()
	{
	}

	private void NNBCLMJGFEN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OFIMMFHFHDD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material KHCLIAMBBNC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideAndDontSave | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	private void HPNNCNNFMGK()
	{
	}

	private void MGMAOBPPOBJ()
	{
		SCShader = Shader.Find("L2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void POJFHDFJOPE()
	{
	}

	private void FGOPJMGNHGO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material HHLFDHNEIAH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)107;
		}
		return BJFKDHHMLJH;
	}

	private void ADPLHDFJFID()
	{
		SCShader = Shader.Find("settings.shaders");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 839f)
			{
				HBJJOCHGOPH = 899f;
			}
			DOHGBNPMBKG().SetFloat("#close", HBJJOCHGOPH);
			ADBKPGFMNKO().SetFloat("Screenshots only supported in PlayMode", Colorisation);
			KJMECMIGJJA().SetFloat("_Value2", Parasite);
			FHFLKLMFHOI().SetFloat("[LocalizationService] Localization: ", Noise);
			KHCLIAMBBNC().SetFloat("SetSatelliteEmission", Fade);
			KJMECMIGJJA().SetVector("LevelConfigButton", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 80f, 1038f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OHFOLGANOLC()
	{
		SCShader = Shader.Find("Set sun min/max size");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FABKIGNFECE()
	{
	}

	private void LADCJEIALMH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KDJEJBBDILE()
	{
	}

	private void ELGOMIMONOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 218f)
			{
				HBJJOCHGOPH = 1606f;
			}
			EOCCJGIGEGJ().SetFloat("_PositionX", HBJJOCHGOPH);
			HHLFDHNEIAH().SetFloat("_Value3", Colorisation);
			DOHGBNPMBKG().SetFloat("[MapsStats] Length: ", Parasite);
			KJMECMIGJJA().SetFloat("_Value2", Noise);
			HNFFHCLNBDN().SetFloat("#exit", Fade);
			DOMEEFLPEPJ().SetVector("The server address is 127.0.0.1 (localhost): Make sure the server is running on this machine. Android and iOS emulators have their own localhost.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 615f, 626f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 340f)
			{
				HBJJOCHGOPH = 1913f;
			}
			KHCLIAMBBNC().SetFloat("{\"items\":", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("LastHighScoreText", Colorisation);
			LPMLLJKMAMP().SetFloat("_ScreenResolution", Parasite);
			MHBAIEKFBIJ().SetFloat("MessageText", Noise);
			DOHGBNPMBKG().SetFloat("#ok", Fade);
			FHFLKLMFHOI().SetVector("skin.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1031f, 909f));
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
			if (HBJJOCHGOPH > 1360f)
			{
				HBJJOCHGOPH = 1124f;
			}
			PDEAHJPOMEF().SetFloat("CameraFilterPack/FX_DigitalMatrix", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("System.Int32", Colorisation);
			FHFLKLMFHOI().SetFloat("_ScreenResolution", Parasite);
			KJMECMIGJJA().SetFloat("#discord{0}joinrequest", Noise);
			NBPKMLMCHFN.SetFloat("_MainTex2", Fade);
			ADBKPGFMNKO().SetVector("[EditorEvent] Exception: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1781f, 1592f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 31f)
			{
				HBJJOCHGOPH = 1387f;
			}
			DOHGBNPMBKG().SetFloat("ScrollPanel", HBJJOCHGOPH);
			DOMEEFLPEPJ().SetFloat("CameraFilterPack/3D_Myst", Colorisation);
			MHBAIEKFBIJ().SetFloat("_RGB", Parasite);
			LPMLLJKMAMP().SetFloat("Edited unlock conditions", Noise);
			PDEAHJPOMEF().SetFloat("' has been reset to the fault value", Fade);
			KHCLIAMBBNC().SetVector("SpawnObj", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1164f, 1869f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FMNPFCHBLJF()
	{
		SCShader = Shader.Find("curScn");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void IABLKKAALGI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IGPCNCJIEOJ()
	{
		SCShader = Shader.Find("_NoiseTilingPerChannel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 261f)
			{
				HBJJOCHGOPH = 47f;
			}
			PDEAHJPOMEF().SetFloat(" not exist", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("_ScreenResolution", Colorisation);
			KHCLIAMBBNC().SetFloat("CameraFilterPack/Blend2Camera_DarkerColor", Parasite);
			KJMECMIGJJA().SetFloat("_Value4", Noise);
			DOMEEFLPEPJ().SetFloat("Item creation successful! Published Item ID: ", Fade);
			AELJLBOJAIL().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 196f, 880f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHLFDHNEIAH());
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

	private void JDKHBGDEONK()
	{
		SCShader = Shader.Find("_Value8");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CIPKEPDELJB()
	{
		SCShader = Shader.Find("Data/Editor/leveltemplate");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LBIOIEANMGI()
	{
	}

	private void LGHCJCFHEMF()
	{
		SCShader = Shader.Find("_Red_G");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 673f)
			{
				HBJJOCHGOPH = 1717f;
			}
			DOMEEFLPEPJ().SetFloat("_FixDistance", HBJJOCHGOPH);
			LPMLLJKMAMP().SetFloat("Committing changes...", Colorisation);
			AELJLBOJAIL().SetFloat("_Visualize", Parasite);
			DOHGBNPMBKG().SetFloat("</color>", Noise);
			PDEAHJPOMEF().SetFloat("DPADVER", Fade);
			NBPKMLMCHFN.SetVector("GlassesColor2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 30f, 142f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
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
			if (HBJJOCHGOPH > 1253f)
			{
				HBJJOCHGOPH = 1604f;
			}
			BFGNMFCNDBC().SetFloat("ComboScoreText", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("_TimeX", Colorisation);
			LPMLLJKMAMP().SetFloat("CameraFilterPack/TV_Distorted", Parasite);
			BFGNMFCNDBC().SetFloat("_TimeX", Noise);
			AELJLBOJAIL().SetFloat("settings_bindings_sec_", Fade);
			DOMEEFLPEPJ().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 570f, 1631f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MHBAIEKFBIJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1033f)
			{
				HBJJOCHGOPH = 1920f;
			}
			HNFFHCLNBDN().SetFloat("_Value4", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat("note.7", Colorisation);
			HNFFHCLNBDN().SetFloat("#yes", Parasite);
			DOHGBNPMBKG().SetFloat("_SceneFogMode", Noise);
			AELJLBOJAIL().SetFloat("(master)", Fade);
			PDEAHJPOMEF().SetVector("Please specify either t or f.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 639f, 238f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KHCLIAMBBNC());
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
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 100f)
			{
				HBJJOCHGOPH = 0f;
			}
			NBPKMLMCHFN.SetFloat("_TimeX", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Colorisation", Colorisation);
			NBPKMLMCHFN.SetFloat("_Parasite", Parasite);
			NBPKMLMCHFN.SetFloat("_Noise", Noise);
			NBPKMLMCHFN.SetFloat("Fade", Fade);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MKIMDFLBFOM()
	{
		SCShader = Shader.Find("_Value5");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ONMGIPAILOH()
	{
	}

	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 791f)
			{
				HBJJOCHGOPH = 891f;
			}
			HHLFDHNEIAH().SetFloat("a", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat("_TimeX", Colorisation);
			KHCLIAMBBNC().SetFloat("_Value9", Parasite);
			PDEAHJPOMEF().SetFloat("Please specify either t or f.", Noise);
			FHFLKLMFHOI().SetFloat("]. Please verify you have this gameobject in a Resources folder.", Fade);
			LPMLLJKMAMP().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 363f, 1246f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DPIPGGDNGHN()
	{
	}

	[SpecialName]
	private Material ADBKPGFMNKO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-102);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material DOMEEFLPEPJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideAndDontSave | HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	private void BMOFEBKGLFI()
	{
		SCShader = Shader.Find("VoteUpToggle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LEAHIBJDMBI()
	{
	}

	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 563f)
			{
				HBJJOCHGOPH = 616f;
			}
			FHFLKLMFHOI().SetFloat("Case-Sensitive", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("settings.volume.game", Colorisation);
			HNFFHCLNBDN().SetFloat(" not exist", Parasite);
			KJMECMIGJJA().SetFloat("_Value4", Noise);
			DOHGBNPMBKG().SetFloat("FinalScoreText", Fade);
			MHBAIEKFBIJ().SetVector("_Distance", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 737f, 441f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JILOMOBDPIA()
	{
		SCShader = Shader.Find("itemid");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JOONHGHGKKF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DGCGGKMNPLD()
	{
	}

	private void ONKDMMJPEMN()
	{
	}

	private void JEBIBKLHFLB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FHGKIOOMMOH()
	{
		SCShader = Shader.Find("MenuScene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material DOHGBNPMBKG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)90;
		}
		return BJFKDHHMLJH;
	}

	private void JNGMIAFLBDL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ILCFPCIPENO()
	{
		SCShader = Shader.Find("_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DDBOODLPCAM()
	{
	}

	private void HDDECCMEJKA()
	{
	}

	private void MJNPIDGNJMK()
	{
	}

	private void FMHOHGEAIEA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 275f)
			{
				HBJJOCHGOPH = 940f;
			}
			PDEAHJPOMEF().SetFloat("lobby '{0}'[{1}]", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("masterSteamID", Colorisation);
			PDEAHJPOMEF().SetFloat("_Value3", Parasite);
			AELJLBOJAIL().SetFloat("CameraFilterPack/EXTRA_SHOWFPS", Noise);
			KJMECMIGJJA().SetFloat("Fade", Fade);
			LPMLLJKMAMP().SetVector("SetSunDirectionVector", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1722f, 1740f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MHBAIEKFBIJ());
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

	private void KLILJHJNICK()
	{
		SCShader = Shader.Find("_MainTex2");
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
			if (HBJJOCHGOPH > 1403f)
			{
				HBJJOCHGOPH = 1532f;
			}
			ADBKPGFMNKO().SetFloat("_Value2", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("end", Colorisation);
			NBPKMLMCHFN.SetFloat("_MainTex2", Parasite);
			EOCCJGIGEGJ().SetFloat("CameraFilterPack/Blend2Camera_Blend", Noise);
			LPMLLJKMAMP().SetFloat("Object ID. Case-Sensitive", Fade);
			BFGNMFCNDBC().SetVector("' got destroyed by engine. This is OK when loading levels. Otherwise use: PhotonNetwork.Destroy().", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1337f, 286f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KOFAMEKHHGD()
	{
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material MHBAIEKFBIJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)81;
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

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/TV_Artefact");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1722f)
			{
				HBJJOCHGOPH = 116f;
			}
			HHLFDHNEIAH().SetFloat("_DisplayVelocityScale", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("EventTimeInputField", Colorisation);
			PDEAHJPOMEF().SetFloat("Ev OwnershipTransfer. ViewID ", Parasite);
			AELJLBOJAIL().SetFloat("_MainTex2", Noise);
			ADBKPGFMNKO().SetFloat("Changed config", Fade);
			FHFLKLMFHOI().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 648f, 1958f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
