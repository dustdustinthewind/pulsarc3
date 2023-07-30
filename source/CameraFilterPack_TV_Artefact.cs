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
			MHBAIEKFBIJ().SetFloat("id", HBJJOCHGOPH);
			ADBKPGFMNKO().SetFloat("mapselector.filter.favoriteonly", Colorisation);
			EOCCJGIGEGJ().SetFloat("Reset All", Parasite);
			HNFFHCLNBDN().SetFloat("[LevelEditorScene] Error: I/O Failure! :(", Noise);
			HNFFHCLNBDN().SetFloat("menu.selectedplaymode", Fade);
			LPMLLJKMAMP().SetVector("[LevelEditorScene] Print Audio Wave: Start", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 796f, 185f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
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
			HHLFDHNEIAH().SetFloat("st", HBJJOCHGOPH);
			FHFLKLMFHOI().SetFloat("StartButton", Colorisation);
			KJMECMIGJJA().SetFloat("MultiplayerButton", Parasite);
			KHCLIAMBBNC().SetFloat("_PixelsPerMeterAtOneMeter", Noise);
			NBPKMLMCHFN.SetFloat("sprite", Fade);
			NBPKMLMCHFN.SetVector(".png", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1418f, 642f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FHFLKLMFHOI());
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
			NBPKMLMCHFN.SetFloat("_Value7", HBJJOCHGOPH);
			LPMLLJKMAMP().SetFloat("CameraFilterPack/FX_DigitalMatrixDistortion", Colorisation);
			PDEAHJPOMEF().SetFloat(".", Parasite);
			BFGNMFCNDBC().SetFloat("Crosshair2", Noise);
			KJMECMIGJJA().SetFloat("Change Note:", Fade);
			KJMECMIGJJA().SetVector("Anomaly_Near", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 457f, 464f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
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
			KHCLIAMBBNC().SetFloat("#rategameinfo", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("[LocalizationService] All keys for ", Colorisation);
			DOHGBNPMBKG().SetFloat("settings.fps", Parasite);
			MHBAIEKFBIJ().SetFloat("<b>#", Noise);
			PDEAHJPOMEF().SetFloat("UI Extensions/UI Image Crop", Fade);
			EOCCJGIGEGJ().SetVector(" registered.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 899f, 915f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BFGNMFCNDBC());
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
		SCShader = Shader.Find("_FixDistance");
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
			NBPKMLMCHFN.SetFloat("player.egglipszerotwo", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("[FileSelector] Dialog ended, result: ", Colorisation);
			DOHGBNPMBKG().SetFloat("player.dragon", Parasite);
			ADBKPGFMNKO().SetFloat("_FgCocMask", Noise);
			ADBKPGFMNKO().SetFloat("_Value5", Fade);
			DNLMFEGJJDD().SetVector("_Value11", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 191f, 1096f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			AELJLBOJAIL().SetFloat("_Value", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat("deletemap", Colorisation);
			HHLFDHNEIAH().SetFloat("id", Parasite);
			DNLMFEGJJDD().SetFloat("OpAuthenticate()", Noise);
			KHCLIAMBBNC().SetFloat("_Value2", Fade);
			MHBAIEKFBIJ().SetVector("bad", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 925f, 1418f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DOKAKEMDALN()
	{
		SCShader = Shader.Find("CameraFilterPack_OldFilm1");
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
		SCShader = Shader.Find("_Value4");
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
			HNFFHCLNBDN().SetFloat("%", HBJJOCHGOPH);
			EOCCJGIGEGJ().SetFloat("/", Colorisation);
			LPMLLJKMAMP().SetFloat("LoadMapCanvas", Parasite);
			KHCLIAMBBNC().SetFloat("bad", Noise);
			NBPKMLMCHFN.SetFloat("Failed to InstantiateSceneObject prefab: ", Fade);
			NBPKMLMCHFN.SetVector("#ok", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1015f, 1197f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
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
			AELJLBOJAIL().SetFloat("CameraFilterPack/Blend2Camera_LinearLight", HBJJOCHGOPH);
			LPMLLJKMAMP().SetFloat("</b>", Colorisation);
			HHLFDHNEIAH().SetFloat("x", Parasite);
			DOHGBNPMBKG().SetFloat("_Line", Noise);
			MHBAIEKFBIJ().SetFloat("The new master starts a new round, cause we didn't start yet.", Fade);
			DOMEEFLPEPJ().SetVector("OK", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 479f, 1161f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOHGBNPMBKG());
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
		SCShader = Shader.Find("#md5submitionfailed: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CNGAJDBOCLJ()
	{
		SCShader = Shader.Find("Item invalid. Make sure your mod contains at leats one file.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KDMANOEMOCA()
	{
		SCShader = Shader.Find("ConfigVersionSlider");
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
			BFGNMFCNDBC().SetFloat("music.ogg", HBJJOCHGOPH);
			DOMEEFLPEPJ().SetFloat("RanksButton", Colorisation);
			DOMEEFLPEPJ().SetFloat("CameraFilterPack/AAA_Blood", Parasite);
			AELJLBOJAIL().SetFloat("challengeid", Noise);
			PDEAHJPOMEF().SetFloat("GlassColor", Fade);
			NBPKMLMCHFN.SetVector("Failed to InstantiateSceneObject prefab: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1831f, 1960f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			HNFFHCLNBDN().SetFloat("CameraFilterPack/Vision_Tunnel", HBJJOCHGOPH);
			HNFFHCLNBDN().SetFloat("_MaxSteps", Colorisation);
			MHBAIEKFBIJ().SetFloat("Received RPC \"", Parasite);
			ADBKPGFMNKO().SetFloat("ResourceIDInputField", Noise);
			FHFLKLMFHOI().SetFloat("GlassesColor2", Fade);
			ADBKPGFMNKO().SetVector("FinalScoreSmallText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 898f, 1811f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FHFLKLMFHOI());
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
			DOHGBNPMBKG().SetFloat("Set environment sprite color and alpha.", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("[MapsData] Preloading workshop", Colorisation);
			DNLMFEGJJDD().SetFloat("_MainTex", Parasite);
			DOHGBNPMBKG().SetFloat("OpSettings()", Noise);
			DOHGBNPMBKG().SetFloat("The given 2D texture ", Fade);
			NBPKMLMCHFN.SetVector("list", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 992f, 1995f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
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
		SCShader = Shader.Find("R1");
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
		SCShader = Shader.Find("settings.enablerankingnotifications");
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
			NBPKMLMCHFN.SetFloat("#tryagain", HBJJOCHGOPH);
			MHBAIEKFBIJ().SetFloat(").png", Colorisation);
			HHLFDHNEIAH().SetFloat("_TimeX", Parasite);
			MHBAIEKFBIJ().SetFloat("english", Noise);
			BFGNMFCNDBC().SetFloat("SetSunLerpSpeed", Fade);
			MHBAIEKFBIJ().SetVector("LevelConfigButton", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 80f, 1038f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void OHFOLGANOLC()
	{
		SCShader = Shader.Find("float,1.5");
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
			ADBKPGFMNKO().SetFloat("_Value2", HBJJOCHGOPH);
			BFGNMFCNDBC().SetFloat("_Value2", Colorisation);
			ADBKPGFMNKO().SetFloat("[RanksSystem] Map hash: ", Parasite);
			DOMEEFLPEPJ().SetFloat("_Value", Noise);
			ADBKPGFMNKO().SetFloat("#exit", Fade);
			HHLFDHNEIAH().SetVector(". Check if the server is available.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 615f, 626f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNFFHCLNBDN());
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
			ADBKPGFMNKO().SetFloat("Yes", HBJJOCHGOPH);
			KHCLIAMBBNC().SetFloat("LastHighScoreText", Colorisation);
			KHCLIAMBBNC().SetFloat("_Value4", Parasite);
			BFGNMFCNDBC().SetFloat("IconImage", Noise);
			DOHGBNPMBKG().SetFloat("ResourcesConfig", Fade);
			FHFLKLMFHOI().SetVector("http", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1031f, 909f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DOHGBNPMBKG());
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
			NBPKMLMCHFN.SetFloat("_ScreenResolution", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("System.String", Colorisation);
			DOMEEFLPEPJ().SetFloat("_Value4", Parasite);
			ADBKPGFMNKO().SetFloat("[DiscordController] Init", Noise);
			BFGNMFCNDBC().SetFloat("_PColor2", Fade);
			ADBKPGFMNKO().SetVector("checkpoint", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1781f, 1592f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
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
			KHCLIAMBBNC().SetFloat("InputField", HBJJOCHGOPH);
			PDEAHJPOMEF().SetFloat("CameraFilterPack/3D_Myst", Colorisation);
			EOCCJGIGEGJ().SetFloat("_TimeX", Parasite);
			HNFFHCLNBDN().SetFloat("Tab1Content", Noise);
			KJMECMIGJJA().SetFloat("settings_bindings_sec_", Fade);
			KJMECMIGJJA().SetVector("[Down]", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1164f, 1869f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
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
		SCShader = Shader.Find("_NoiseTex");
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
			ADBKPGFMNKO().SetFloat(": ", HBJJOCHGOPH);
			MHBAIEKFBIJ().SetFloat("_TimeX", Colorisation);
			DOHGBNPMBKG().SetFloat("CameraFilterPack/Blend2Camera_DarkerColor", Parasite);
			ADBKPGFMNKO().SetFloat("_Value3", Noise);
			MHBAIEKFBIJ().SetFloat("Error: I/O Failure! :(", Fade);
			ADBKPGFMNKO().SetVector("_Value3", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 196f, 880f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
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
		SCShader = Shader.Find("Editor/");
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
		SCShader = Shader.Find("_Red_R");
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
			HHLFDHNEIAH().SetFloat("_FixDistance", HBJJOCHGOPH);
			KHCLIAMBBNC().SetFloat("HIDE CONFIG [Ctrl+E]", Colorisation);
			MHBAIEKFBIJ().SetFloat("_LightIntensity", Parasite);
			PDEAHJPOMEF().SetFloat("[ResourcesManager] Load audio error: ", Noise);
			DOMEEFLPEPJ().SetFloat("DPADVER", Fade);
			BFGNMFCNDBC().SetVector("GlassesColor2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 30f, 142f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EOCCJGIGEGJ());
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
			FHFLKLMFHOI().SetFloat("ComboScoreText", HBJJOCHGOPH);
			HNFFHCLNBDN().SetFloat("CameraFilterPack/Noise_TV", Colorisation);
			FHFLKLMFHOI().SetFloat("_ScreenResolution", Parasite);
			DOHGBNPMBKG().SetFloat("CameraFilterPack/BlurTiltShift_V", Noise);
			DNLMFEGJJDD().SetFloat("settings_bindings_sec_", Fade);
			LPMLLJKMAMP().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 570f, 1631f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KHCLIAMBBNC());
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
			FHFLKLMFHOI().SetFloat("_Value2", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("note.3", Colorisation);
			NBPKMLMCHFN.SetFloat("MenuScene", Parasite);
			HHLFDHNEIAH().SetFloat("_DistanceParams", Noise);
			ADBKPGFMNKO().SetFloat("'{0}'{1}{2}", Fade);
			KHCLIAMBBNC().SetVector("f", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 639f, 238f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MHBAIEKFBIJ());
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
		SCShader = Shader.Find("_Value4");
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
			EOCCJGIGEGJ().SetFloat("g", HBJJOCHGOPH);
			DNLMFEGJJDD().SetFloat("CameraFilterPack/BlurTiltShift_V", Colorisation);
			DNLMFEGJJDD().SetFloat("_Value8", Parasite);
			MHBAIEKFBIJ().SetFloat(":", Noise);
			MHBAIEKFBIJ().SetFloat("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.", Fade);
			KJMECMIGJJA().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 363f, 1246f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
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
		SCShader = Shader.Find("+");
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
			AELJLBOJAIL().SetFloat("id", HBJJOCHGOPH);
			HHLFDHNEIAH().SetFloat("settings.volume.menu", Colorisation);
			MHBAIEKFBIJ().SetFloat(" or ", Parasite);
			BFGNMFCNDBC().SetFloat("_Value3", Noise);
			LPMLLJKMAMP().SetFloat("FinalScoreText", Fade);
			DNLMFEGJJDD().SetVector("_Level", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 737f, 441f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MHBAIEKFBIJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JILOMOBDPIA()
	{
		SCShader = Shader.Find("PLEASE WAIT");
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
		SCShader = Shader.Find("/");
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
			MHBAIEKFBIJ().SetFloat("OpChangeGroups()", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat("masterSteamID", Colorisation);
			KHCLIAMBBNC().SetFloat("_Value3", Parasite);
			KHCLIAMBBNC().SetFloat("_ScreenResolution", Noise);
			KJMECMIGJJA().SetFloat("_Value2", Fade);
			ADBKPGFMNKO().SetVector("Set sun min/max size", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1722f, 1740f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
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
		SCShader = Shader.Find("CameraFilterPack/Blend2Camera_VividLight");
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
			DNLMFEGJJDD().SetFloat("_Value2", HBJJOCHGOPH);
			KJMECMIGJJA().SetFloat("PlaySound", Colorisation);
			DOMEEFLPEPJ().SetFloat("_MainTex2", Parasite);
			DOMEEFLPEPJ().SetFloat("_ScreenResolution", Noise);
			KJMECMIGJJA().SetFloat("Object ID. Case-Sensitive", Fade);
			FHFLKLMFHOI().SetVector(" = ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1337f, 286f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
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
			HHLFDHNEIAH().SetFloat("_BlurDirectionPacked", HBJJOCHGOPH);
			ADBKPGFMNKO().SetFloat("LevelEditor/CustomEventEditor-", Colorisation);
			FHFLKLMFHOI().SetFloat("Ownership mode == fixed. Ignoring request.", Parasite);
			LPMLLJKMAMP().SetFloat("_Value4", Noise);
			PDEAHJPOMEF().SetFloat("[EditorEvent] Exception: ", Fade);
			HHLFDHNEIAH().SetVector("CameraFilterPack/Retro_Loading", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 648f, 1958f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}
}
