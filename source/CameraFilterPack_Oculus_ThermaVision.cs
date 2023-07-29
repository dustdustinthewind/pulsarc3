// CameraFilterPack_Oculus_ThermaVision
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Vision/ThermaVision")]
public class CameraFilterPack_Oculus_ThermaVision : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(0f, 1f)]
	public float Therma_Variation = 0.5f;

	[Range(0f, 8f)]
	private float OGLODCDJJLB = 3f;

	[Range(0f, 4f)]
	private float ALELLLFCDBF;

	[Range(0f, 16f)]
	private float NFDIFLHGJKB = 1f;

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

	private void NAALCEPIHCH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void Update()
	{
	}

	private void NBGIMIDICKE()
	{
		SCShader = Shader.Find("CameraFilterPack/Vision_Hell_Blood");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1367f)
			{
				HBJJOCHGOPH = 1776f;
			}
			BAGICADFBAB().SetFloat("#tryagain", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("Set particles gravity", Therma_Variation);
			INOBFNCKFGK().SetFloat("_PColor2", OGLODCDJJLB);
			BLMPMOIDGMG().SetFloat("_DepthLevel", ALELLLFCDBF);
			OOMFJGPAOKL().SetFloat("EventTimeInputField", NFDIFLHGJKB);
			LPMLLJKMAMP().SetVector("Left Click", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1849f, 1972f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PFNFPINPCMH()
	{
	}

	private void NPLCENPNJBM()
	{
		SCShader = Shader.Find("grid");
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

	private void HPFOFGJPNCI()
	{
		SCShader = Shader.Find("_SmoothStart");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material PEIMCBBHLBJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)93;
		}
		return BJFKDHHMLJH;
	}

	private void LGHCJCFHEMF()
	{
		SCShader = Shader.Find("skin.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void KNBJBNDGCIJ()
	{
		SCShader = Shader.Find("...");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 512f)
			{
				HBJJOCHGOPH = 1405f;
			}
			DIOAAHJDMLK().SetFloat("_DotSize", HBJJOCHGOPH);
			BLMPMOIDGMG().SetFloat("x", Therma_Variation);
			INOBFNCKFGK().SetFloat("SetParticlesInput", OGLODCDJJLB);
			INOBFNCKFGK().SetFloat("RespawnAfter", ALELLLFCDBF);
			NBMPPNFKFLB().SetFloat("offsets", NFDIFLHGJKB);
			EHDJJANLINB().SetVector("ReJoinRoom failed. A roomname is required. If you don't know one, how will you join?", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 588f, 836f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PEIMCBBHLBJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GPFJMKCGHGB()
	{
	}

	private void GNMGIHFKJIJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GMELGGJOPBB()
	{
	}

	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1101f)
			{
				HBJJOCHGOPH = 1030f;
			}
			CIAFLBFJLEJ().SetFloat("settings.shaders.bloomintencity", HBJJOCHGOPH);
			DIOAAHJDMLK().SetFloat("_TimeX", Therma_Variation);
			OOMFJGPAOKL().SetFloat(".lastCheckpoint.perfectHits", OGLODCDJJLB);
			FOOCJIDNGBB().SetFloat("settings.shaders", ALELLLFCDBF);
			OJMHIMIPKME().SetFloat("CameraFilterPack_Blizzard1", NFDIFLHGJKB);
			CIAFLBFJLEJ().SetVector("CameraFilterPack/Blend2Camera_SoftLight", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 768f, 1712f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material NBMPPNFKFLB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HCGJCMDJPGD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)111;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material EHDJJANLINB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
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

	private void HMNLHMLILKD()
	{
	}

	[SpecialName]
	private Material DEFBJOCJJKF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)71;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material CIAFLBFJLEJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-105);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material JFDGLLEOPGB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSave | HideFlags.HideInInspector);
		}
		return BJFKDHHMLJH;
	}

	private void GOIMKCCICFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 716f)
			{
				HBJJOCHGOPH = 418f;
			}
			INOBFNCKFGK().SetFloat("_EmissionColor", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat("CheckResources () for ", Therma_Variation);
			INOBFNCKFGK().SetFloat("_Green_G", OGLODCDJJLB);
			JFDGLLEOPGB().SetFloat("_Value2", ALELLLFCDBF);
			DIOAAHJDMLK().SetFloat(",", NFDIFLHGJKB);
			LPMLLJKMAMP().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1988f, 1370f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FOOCJIDNGBB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JBMBNKOOENB()
	{
	}

	private void AKHCOBHHGJP()
	{
		SCShader = Shader.Find("_Extra3");
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
			if (HBJJOCHGOPH > 698f)
			{
				HBJJOCHGOPH = 1272f;
			}
			EHDJJANLINB().SetFloat("Subscribed cells:\n", HBJJOCHGOPH);
			EHDJJANLINB().SetFloat("Object ID. Case-Sensitive", Therma_Variation);
			FOOCJIDNGBB().SetFloat("CameraFilterPack/Blur_Bloom", OGLODCDJJLB);
			IKAIDLJKLFC().SetFloat(".completed", ALELLLFCDBF);
			JFDGLLEOPGB().SetFloat("ticket", NFDIFLHGJKB);
			FLGPDBBKAIP().SetVector("#useticket", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1941f, 1245f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DIOAAHJDMLK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GAOOPEEBGJA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PJIFJFENPJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1940f)
			{
				HBJJOCHGOPH = 910f;
			}
			IKAIDLJKLFC().SetFloat("Selection Box", HBJJOCHGOPH);
			CECJJMKLEAK().SetFloat(" beatThreshold: ", Therma_Variation);
			HCGJCMDJPGD().SetFloat("[LevelEditorScene] Error: You're not logged into Steam!", OGLODCDJJLB);
			BLMPMOIDGMG().SetFloat("_Value2", ALELLLFCDBF);
			HHIFMIPPMPF().SetFloat("_PrevViewProj", NFDIFLHGJKB);
			HHIFMIPPMPF().SetVector("0.00:0.00", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 319f, 1597f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLGPDBBKAIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BLKGOMCPEKI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material GBFOAHKAJEK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)78;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material DONENAMLFLF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-104);
		}
		return BJFKDHHMLJH;
	}

	private void LFAFJKJAEEL()
	{
		SCShader = Shader.Find("CameraFilterPack/Gradients_Tech");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GJLKJAOBPJD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JNBPKNNBMDI()
	{
	}

	private void BJOHDLNDFAD()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 20f)
			{
				HBJJOCHGOPH = 855f;
			}
			DEFBJOCJJKF().SetFloat("GameScene", HBJJOCHGOPH);
			OJMHIMIPKME().SetFloat("_ScreenResolution", Therma_Variation);
			INOBFNCKFGK().SetFloat("_FarCamera", OGLODCDJJLB);
			IKAIDLJKLFC().SetFloat("DifficultyBG", ALELLLFCDBF);
			CIAFLBFJLEJ().SetFloat("powerup.1", NFDIFLHGJKB);
			LPMLLJKMAMP().SetVector("Created by ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 327f, 1453f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PHJLHCMCCKE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material IKAIDLJKLFC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 359f)
			{
				HBJJOCHGOPH = 1480f;
			}
			BAGICADFBAB().SetFloat("_ToPrevViewProjCombined", HBJJOCHGOPH);
			BAGICADFBAB().SetFloat("CameraFilterPack/Distortion_BlackHole", Therma_Variation);
			LPMLLJKMAMP().SetFloat("0.00:0.00", OGLODCDJJLB);
			LDNADDJMIPK().SetFloat("Uploading preview image", ALELLLFCDBF);
			CFEDGDGBCHE().SetFloat("SetSunColors", NFDIFLHGJKB);
			KGOLDDBHIFN().SetVector("[LevelEditorScene] Print Audio Wave: Start", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 845f, 185f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OOMFJGPAOKL());
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

	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1869f)
			{
				HBJJOCHGOPH = 1071f;
			}
			CFEDGDGBCHE().SetFloat("_Value3", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("_ScreenResolution", Therma_Variation);
			EHDJJANLINB().SetFloat("_CenterX", OGLODCDJJLB);
			KGOLDDBHIFN().SetFloat(", data: ", ALELLLFCDBF);
			NBMPPNFKFLB().SetFloat("x", NFDIFLHGJKB);
			CECJJMKLEAK().SetVector("Network destroy Instantiated GO: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1818f, 417f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, INOBFNCKFGK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HAHJJPLPOKB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JNGMIAFLBDL()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material LPMLLJKMAMP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)89;
		}
		return BJFKDHHMLJH;
	}

	private void CEAGPJBGBMH()
	{
		SCShader = Shader.Find("CameraFilterPack/EyesVision_1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void JAAJECBCCFM()
	{
	}

	private void BGDPIHMAACO()
	{
		SCShader = Shader.Find("CameraFilterPack/Fly_Vision");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material OJMHIMIPKME()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void GBGAMCPNBCC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material CFEDGDGBCHE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void OPKNFOGMGII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1770f)
			{
				HBJJOCHGOPH = 562f;
			}
			HKHBBBFLGJH().SetFloat("No Name", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("true", Therma_Variation);
			JFDGLLEOPGB().SetFloat("#no", OGLODCDJJLB);
			CIAFLBFJLEJ().SetFloat("RPC: 'OnAwakeRPC' PhotonView: ", ALELLLFCDBF);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/TV_ARCADE_Fast", NFDIFLHGJKB);
			KGOLDDBHIFN().SetVector("LevelNameText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 86f, 252f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BMNOHLNANIP()
	{
	}

	private void AEOLJEIDMDB()
	{
		SCShader = Shader.Find("CameraFilterPack/VHS_Tracking");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DBEMDAJDDDA()
	{
		SCShader = Shader.Find(" from: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1000f)
			{
				HBJJOCHGOPH = 1461f;
			}
			DEFBJOCJJKF().SetFloat("Result for ", HBJJOCHGOPH);
			LPMLLJKMAMP().SetFloat("start", Therma_Variation);
			JFDGLLEOPGB().SetFloat("FinalScoreSmallText", OGLODCDJJLB);
			FAIFBBGFAIB().SetFloat("[RanksSystem] Init", ALELLLFCDBF);
			CFEDGDGBCHE().SetFloat("Lag ", NFDIFLHGJKB);
			CIAFLBFJLEJ().SetVector("offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1835f, 94f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JDGFCEPDKAJ()
	{
	}

	private void CIHGFHNNFEE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 312f)
			{
				HBJJOCHGOPH = 1514f;
			}
			OOMFJGPAOKL().SetFloat("{0}", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat("The other scroll rect doesnt support scrolling vertically", Therma_Variation);
			FAIFBBGFAIB().SetFloat("_EmissionGain", OGLODCDJJLB);
			NBMPPNFKFLB().SetFloat("Gameplay/Base", ALELLLFCDBF);
			DONENAMLFLF().SetFloat("HightScoreMaxPointsText", NFDIFLHGJKB);
			FOOCJIDNGBB().SetVector("_Intensity", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 164f, 1899f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, INOBFNCKFGK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JBCNIPJDPJB()
	{
	}

	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 557f)
			{
				HBJJOCHGOPH = 1451f;
			}
			JFDGLLEOPGB().SetFloat(": ", HBJJOCHGOPH);
			JCPDCGIJKJD().SetFloat("maps.", Therma_Variation);
			OOMFJGPAOKL().SetFloat("_Near", OGLODCDJJLB);
			HHIFMIPPMPF().SetFloat("SpawnObj", ALELLLFCDBF);
			FLGPDBBKAIP().SetFloat("_ScreenResolution", NFDIFLHGJKB);
			DONENAMLFLF().SetVector("menu.enableselectormusic", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 392f, 1718f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PEIMCBBHLBJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JOONHGHGKKF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1415f)
			{
				HBJJOCHGOPH = 1234f;
			}
			CIAFLBFJLEJ().SetFloat("OpAuthenticate()", HBJJOCHGOPH);
			FLGPDBBKAIP().SetFloat("YES", Therma_Variation);
			FOOCJIDNGBB().SetFloat("_Value4", OGLODCDJJLB);
			FOOCJIDNGBB().SetFloat("ArcsDestroyDelaySlider", ALELLLFCDBF);
			CECJJMKLEAK().SetFloat("_Value", NFDIFLHGJKB);
			DEFBJOCJJKF().SetVector("settings.volume.editor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 324f, 87f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CEDFFAOOPOG()
	{
		SCShader = Shader.Find("MenuScene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1465f)
			{
				HBJJOCHGOPH = 866f;
			}
			GBFOAHKAJEK().SetFloat("Scene", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat("OpGetGameList not sent. Lobby cannot be null.", Therma_Variation);
			HCGJCMDJPGD().SetFloat("_Value2", OGLODCDJJLB);
			INOBFNCKFGK().SetFloat("y", ALELLLFCDBF);
			LPMLLJKMAMP().SetFloat("maps.", NFDIFLHGJKB);
			OOMFJGPAOKL().SetVector(" url: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1218f, 770f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CCPEDDLAMIB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1892f)
			{
				HBJJOCHGOPH = 1306f;
			}
			FLGPDBBKAIP().SetFloat("Preparing configuration", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("_MainTex", Therma_Variation);
			IKAIDLJKLFC().SetFloat("_Bloom3", OGLODCDJJLB);
			BAGICADFBAB().SetFloat("_EmissionColor", ALELLLFCDBF);
			OOMFJGPAOKL().SetFloat("NEW_ACHIEVEMENT_1_21", NFDIFLHGJKB);
			HCGJCMDJPGD().SetVector("ns", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1759f, 1674f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CECJJMKLEAK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material HHIFMIPPMPF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
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

	private void CNGAJDBOCLJ()
	{
		SCShader = Shader.Find("/icon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FEGJMDDIDIC()
	{
		SCShader = Shader.Find("_Near");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material FOOCJIDNGBB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-74);
		}
		return BJFKDHHMLJH;
	}

	private void HNILMGEKDEC()
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
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void NPBDIMJDMGA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1020f)
			{
				HBJJOCHGOPH = 1191f;
			}
			FAIFBBGFAIB().SetFloat("_Near", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("X2", Therma_Variation);
			DEFBJOCJJKF().SetFloat("_TimeX", OGLODCDJJLB);
			CIAFLBFJLEJ().SetFloat("float,10", ALELLLFCDBF);
			NBPKMLMCHFN.SetFloat("_FixDistance", NFDIFLHGJKB);
			DEFBJOCJJKF().SetVector("Tab2Content", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 857f, 578f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IHHNCCOGLPN()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NJHJHBOJKIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 957f)
			{
				HBJJOCHGOPH = 1757f;
			}
			BLMPMOIDGMG().SetFloat("_Value3", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat("close", Therma_Variation);
			OJMHIMIPKME().SetFloat("_Value", OGLODCDJJLB);
			NBMPPNFKFLB().SetFloat("Set satellite color", ALELLLFCDBF);
			GBFOAHKAJEK().SetFloat("_RayStepSize", NFDIFLHGJKB);
			HKHBBBFLGJH().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1528f, 1276f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
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
			if (HBJJOCHGOPH > 1210f)
			{
				HBJJOCHGOPH = 1445f;
			}
			CIAFLBFJLEJ().SetFloat("Object ID. Case-Sensitive", HBJJOCHGOPH);
			LDNADDJMIPK().SetFloat("Set Particles Color", Therma_Variation);
			GBFOAHKAJEK().SetFloat("ScrollPanel", OGLODCDJJLB);
			LDNADDJMIPK().SetFloat("Keypad", ALELLLFCDBF);
			DONENAMLFLF().SetFloat("_MainTex2", NFDIFLHGJKB);
			NBPKMLMCHFN.SetVector("OnAwakeRPC", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 898f, 1817f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DIOAAHJDMLK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void HOMNAHDDNHJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void EIMNPCMHJLJ()
	{
		SCShader = Shader.Find("F3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void ELGOMIMONOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1421f)
			{
				HBJJOCHGOPH = 1880f;
			}
			DIOAAHJDMLK().SetFloat("_CenterX", HBJJOCHGOPH);
			HKHBBBFLGJH().SetFloat("ResetButton", Therma_Variation);
			LDNADDJMIPK().SetFloat("#getrewardfailed: ", OGLODCDJJLB);
			CECJJMKLEAK().SetFloat(".sav", ALELLLFCDBF);
			CIAFLBFJLEJ().SetFloat("_MainTex2", NFDIFLHGJKB);
			FAIFBBGFAIB().SetVector("Copy from ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 971f, 1521f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FABMDEHEDNO()
	{
	}

	private void LCHBFNIPBHB()
	{
	}

	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 588f)
			{
				HBJJOCHGOPH = 1593f;
			}
			NBPKMLMCHFN.SetFloat("_ForceYSwap", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("_Value3", Therma_Variation);
			LPMLLJKMAMP().SetFloat("float,1", OGLODCDJJLB);
			CFEDGDGBCHE().SetFloat("_Value2", ALELLLFCDBF);
			JCPDCGIJKJD().SetFloat("Cross", NFDIFLHGJKB);
			FOOCJIDNGBB().SetVector("GlassColor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1563f, 1534f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KKEOHFGKCIK()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ALNNIDLFILB()
	{
		SCShader = Shader.Find("speed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void GJAJBMGGPFB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LFBGJIIECLD()
	{
		SCShader = Shader.Find("UI Extensions/UIMultiply");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AIBNKIDADPI()
	{
		SCShader = Shader.Find("original.tutorial");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DFENCIHAADO()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JABNHMIHBHC()
	{
		SCShader = Shader.Find("player.redlifering");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void FEHCNJLLJMP()
	{
		SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void LLDHEJIEDHO()
	{
	}

	[SpecialName]
	private Material CECJJMKLEAK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return BJFKDHHMLJH;
	}

	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1615f)
			{
				HBJJOCHGOPH = 1984f;
			}
			FOOCJIDNGBB().SetFloat("Object ID. Case-Sensitive", HBJJOCHGOPH);
			BAGICADFBAB().SetFloat("#lives", Therma_Variation);
			PEIMCBBHLBJ().SetFloat("http://steamcommunity.com/sharedfiles/filedetails/?id=", OGLODCDJJLB);
			BAGICADFBAB().SetFloat("_Value", ALELLLFCDBF);
			JCPDCGIJKJD().SetFloat("Moved event", NFDIFLHGJKB);
			BLMPMOIDGMG().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 757f, 1322f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CBIBDOIBJAI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 191f)
			{
				HBJJOCHGOPH = 57f;
			}
			EHDJJANLINB().SetFloat("[Right-Down-Left]", HBJJOCHGOPH);
			OOMFJGPAOKL().SetFloat("inventory.lastitemscount", Therma_Variation);
			KGOLDDBHIFN().SetFloat("_SoftZDistance", OGLODCDJJLB);
			HCGJCMDJPGD().SetFloat("#exitmapeditor", ALELLLFCDBF);
			IKAIDLJKLFC().SetFloat("CameraFilterPack_TV_BrokenGlass1", NFDIFLHGJKB);
			FLGPDBBKAIP().SetVector(" ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 923f, 1225f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material LDNADDJMIPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)68;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material BLMPMOIDGMG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-119);
		}
		return BJFKDHHMLJH;
	}

	private void IBLGHLNNAHN()
	{
		SCShader = Shader.Find(".GoalProgress");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material HKHBBBFLGJH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 684f)
			{
				HBJJOCHGOPH = 1905f;
			}
			FLGPDBBKAIP().SetFloat("_Offsets", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat(" ", Therma_Variation);
			OOMFJGPAOKL().SetFloat("_ThirdTex", OGLODCDJJLB);
			LPMLLJKMAMP().SetFloat("[Down]", ALELLLFCDBF);
			BLMPMOIDGMG().SetFloat("EditMenu", NFDIFLHGJKB);
			LDNADDJMIPK().SetVector("_BlurRadius4", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 281f, 1130f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CIAFLBFJLEJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void COOHIILCOCO()
	{
		SCShader = Shader.Find("[Sound Manager] Audio clip is null, cannot play music");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AGEJKLMJGDO()
	{
		SCShader = Shader.Find("OnMastedChangeScene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MFMIODIAKNI()
	{
	}

	private void POJFHDFJOPE()
	{
	}

	private void FHPFJBFCOOF()
	{
		SCShader = Shader.Find("ScrollPanel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void Start()
	{
		SCShader = Shader.Find("CameraFilterPack/Oculus_ThermaVision");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material DIOAAHJDMLK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)103;
		}
		return BJFKDHHMLJH;
	}

	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 220f)
			{
				HBJJOCHGOPH = 1673f;
			}
			PEIMCBBHLBJ().SetFloat("<command>", HBJJOCHGOPH);
			OJMHIMIPKME().SetFloat("#,0.00", Therma_Variation);
			CFEDGDGBCHE().SetFloat("SetPosition", OGLODCDJJLB);
			FAIFBBGFAIB().SetFloat("_BlurCoe", ALELLLFCDBF);
			FOOCJIDNGBB().SetFloat("_Value", NFDIFLHGJKB);
			CFEDGDGBCHE().SetVector("Set the end of the map. Use this if you want to cut the long music.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 260f, 659f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material JCPDCGIJKJD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-107);
		}
		return BJFKDHHMLJH;
	}

	private void JOPCCCCHNLI()
	{
		SCShader = Shader.Find(".lastCheckpoint.currentCombo");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 509f)
			{
				HBJJOCHGOPH = 465f;
			}
			CECJJMKLEAK().SetFloat("Health Stats", HBJJOCHGOPH);
			CIAFLBFJLEJ().SetFloat("_Color", Therma_Variation);
			KGOLDDBHIFN().SetFloat("_MainTex", OGLODCDJJLB);
			PEIMCBBHLBJ().SetFloat("\n", ALELLLFCDBF);
			OJMHIMIPKME().SetFloat("Reconnect() disabled the offline mode. No longer offline.", NFDIFLHGJKB);
			LDNADDJMIPK().SetVector("_Red_R", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1956f, 1014f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JCPDCGIJKJD());
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
			if (HBJJOCHGOPH > 912f)
			{
				HBJJOCHGOPH = 1367f;
			}
			NBPKMLMCHFN.SetFloat("ERROR: Make sure your mod contains at leats one file!", HBJJOCHGOPH);
			INOBFNCKFGK().SetFloat("CountEventsGoal", Therma_Variation);
			JCPDCGIJKJD().SetFloat("StartButton", OGLODCDJJLB);
			DEFBJOCJJKF().SetFloat("float,0", ALELLLFCDBF);
			FAIFBBGFAIB().SetFloat("Data/Skins/", NFDIFLHGJKB);
			CFEDGDGBCHE().SetVector("a year ago", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1756f, 494f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GBFOAHKAJEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 900f)
			{
				HBJJOCHGOPH = 1367f;
			}
			HCGJCMDJPGD().SetFloat("_Value", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("offsets", Therma_Variation);
			INOBFNCKFGK().SetFloat("_ScreenResolution", OGLODCDJJLB);
			FOOCJIDNGBB().SetFloat("_Value2", ALELLLFCDBF);
			LPMLLJKMAMP().SetFloat("Hidden/TonemappingColorGrading", NFDIFLHGJKB);
			IKAIDLJKLFC().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 936f, 901f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BOLBPPHJBMI()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FEKECCBFGMI()
	{
		SCShader = Shader.Find("stats on");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1963f)
			{
				HBJJOCHGOPH = 1486f;
			}
			BAGICADFBAB().SetFloat("EditMenu", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("SetSunMinSize", Therma_Variation);
			PEIMCBBHLBJ().SetFloat(". The group number should be at least 1.", OGLODCDJJLB);
			HHIFMIPPMPF().SetFloat("_BlurVector", ALELLLFCDBF);
			CIAFLBFJLEJ().SetFloat("InputField", NFDIFLHGJKB);
			FAIFBBGFAIB().SetVector("FPSToggle", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 974f, 1791f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLGPDBBKAIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 989f)
			{
				HBJJOCHGOPH = 1385f;
			}
			FOOCJIDNGBB().SetFloat(" ", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat(":", Therma_Variation);
			JFDGLLEOPGB().SetFloat("error", OGLODCDJJLB);
			FLGPDBBKAIP().SetFloat("_Gain", ALELLLFCDBF);
			OJMHIMIPKME().SetFloat("0,7,true,0", NFDIFLHGJKB);
			OOMFJGPAOKL().SetVector("IntraTime", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 988f, 1213f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CECJJMKLEAK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1284f)
			{
				HBJJOCHGOPH = 1005f;
			}
			IKAIDLJKLFC().SetFloat("_TimeX", HBJJOCHGOPH);
			KGOLDDBHIFN().SetFloat("OnJoinedLobby(). This client is connected and does get a room-list, which gets stored as PhotonNetwork.GetRoomList(). This script now calls: PhotonNetwork.JoinRandomRoom();", Therma_Variation);
			HHIFMIPPMPF().SetFloat("player.xp", OGLODCDJJLB);
			FAIFBBGFAIB().SetFloat("_Extra3", ALELLLFCDBF);
			JFDGLLEOPGB().SetFloat(".workshop.json", NFDIFLHGJKB);
			CECJJMKLEAK().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1501f, 82f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
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
			NBPKMLMCHFN.SetFloat("_Value", Therma_Variation);
			NBPKMLMCHFN.SetFloat("_Value2", OGLODCDJJLB);
			NBPKMLMCHFN.SetFloat("_Value3", ALELLLFCDBF);
			NBPKMLMCHFN.SetFloat("_Value4", NFDIFLHGJKB);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material OOMFJGPAOKL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 957f)
			{
				HBJJOCHGOPH = 715f;
			}
			DEFBJOCJJKF().SetFloat("/Segment-[Down]", HBJJOCHGOPH);
			JFDGLLEOPGB().SetFloat("Editor/", Therma_Variation);
			OOMFJGPAOKL().SetFloat("pointBuffer", OGLODCDJJLB);
			DIOAAHJDMLK().SetFloat("_ScreenResolution", ALELLLFCDBF);
			NBPKMLMCHFN.SetFloat("_Visualize", NFDIFLHGJKB);
			HCGJCMDJPGD().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 275f, 906f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MCKCCPLJIFE()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material BAGICADFBAB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)84;
		}
		return BJFKDHHMLJH;
	}

	private void DKPBBJINKMG()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void AOLABBMIEIM()
	{
	}

	private void FGNFILLNPJK()
	{
	}

	[SpecialName]
	private Material KGOLDDBHIFN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 732f)
			{
				HBJJOCHGOPH = 1366f;
			}
			DIOAAHJDMLK().SetFloat("ConfigVersionSlider", HBJJOCHGOPH);
			LPMLLJKMAMP().SetFloat("_Visualize", Therma_Variation);
			CECJJMKLEAK().SetFloat("open", OGLODCDJJLB);
			DIOAAHJDMLK().SetFloat("RespawnAfter", ALELLLFCDBF);
			FLGPDBBKAIP().SetFloat("Editor/", NFDIFLHGJKB);
			CECJJMKLEAK().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1034f, 1632f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DIOAAHJDMLK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LIBGAKMKHJJ()
	{
		SCShader = Shader.Find("_Intensity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material FLGPDBBKAIP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-90);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material INOBFNCKFGK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)66;
		}
		return BJFKDHHMLJH;
	}

	private void MJEFMIPLFAB()
	{
		SCShader = Shader.Find("Unsupported type: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}
}
