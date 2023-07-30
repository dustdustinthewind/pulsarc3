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
		SCShader = Shader.Find("_ScreenResolution");
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
			CFEDGDGBCHE().SetFloat("Done! You are a contributor until: ", HBJJOCHGOPH);
			BLMPMOIDGMG().SetFloat("float,0", Therma_Variation);
			NBMPPNFKFLB().SetFloat("_PColor2", OGLODCDJJLB);
			IKAIDLJKLFC().SetFloat("_DepthLevel", ALELLLFCDBF);
			NBPKMLMCHFN.SetFloat("ResourceIDInputField", NFDIFLHGJKB);
			IKAIDLJKLFC().SetVector("Down ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1849f, 1972f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DEFBJOCJJKF());
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
		SCShader = Shader.Find("end");
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
			BAGICADFBAB().SetFloat("_Distortion", HBJJOCHGOPH);
			EHDJJANLINB().SetFloat("x", Therma_Variation);
			HCGJCMDJPGD().SetFloat("Set particles count per one beat", OGLODCDJJLB);
			OOMFJGPAOKL().SetFloat("PunPickupSimple", ALELLLFCDBF);
			DIOAAHJDMLK().SetFloat("_SmallTex", NFDIFLHGJKB);
			PEIMCBBHLBJ().SetVector("JoinRandomRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 588f, 836f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
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
			BAGICADFBAB().SetFloat("settings.shaders", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_TimeX", Therma_Variation);
			JFDGLLEOPGB().SetFloat(".lastCheckpoint.powerupsScore", OGLODCDJJLB);
			DONENAMLFLF().SetFloat("Player", ALELLLFCDBF);
			DIOAAHJDMLK().SetFloat("CameraFilterPack_Blizzard1", NFDIFLHGJKB);
			HCGJCMDJPGD().SetVector("CameraFilterPack/Blend2Camera_SoftLight", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 768f, 1712f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EHDJJANLINB());
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
			CECJJMKLEAK().SetFloat("settings.crosshairopacity", HBJJOCHGOPH);
			PEIMCBBHLBJ().SetFloat(" is not supported on this platform!", Therma_Variation);
			CECJJMKLEAK().SetFloat("_Green_R", OGLODCDJJLB);
			JFDGLLEOPGB().SetFloat("_Value", ALELLLFCDBF);
			CIAFLBFJLEJ().SetFloat("/512px-512px.png", NFDIFLHGJKB);
			LDNADDJMIPK().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1988f, 1370f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CIAFLBFJLEJ());
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
		SCShader = Shader.Find("_Extra2");
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
			DIOAAHJDMLK().SetFloat("Vertical", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("id", Therma_Variation);
			DEFBJOCJJKF().SetFloat("_MainTex2", OGLODCDJJLB);
			OOMFJGPAOKL().SetFloat("maps.", ALELLLFCDBF);
			LPMLLJKMAMP().SetFloat("[", NFDIFLHGJKB);
			NBPKMLMCHFN.SetVector("#failed: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1941f, 1245f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
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
			HCGJCMDJPGD().SetFloat("Fake", HBJJOCHGOPH);
			FOOCJIDNGBB().SetFloat(" beatThreshold: ", Therma_Variation);
			FOOCJIDNGBB().SetFloat("/", OGLODCDJJLB);
			INOBFNCKFGK().SetFloat("_Value", ALELLLFCDBF);
			NBPKMLMCHFN.SetFloat("_Parameter", NFDIFLHGJKB);
			NBMPPNFKFLB().SetVector("Creating awesome maps", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 319f, 1597f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CECJJMKLEAK());
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
		SCShader = Shader.Find("_ScreenResolution");
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
			FAIFBBGFAIB().SetFloat("GameScene", HBJJOCHGOPH);
			LDNADDJMIPK().SetFloat("_Fade", Therma_Variation);
			BLMPMOIDGMG().SetFloat("_FarCamera", OGLODCDJJLB);
			BAGICADFBAB().SetFloat("UpdateDownloadingProgress", ALELLLFCDBF);
			JCPDCGIJKJD().SetFloat("powerup.0", NFDIFLHGJKB);
			BLMPMOIDGMG().SetVector("KickThePlayer", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 327f, 1453f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DONENAMLFLF());
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
			DIOAAHJDMLK().SetFloat("_InvViewProj", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("_ScreenResolution", Therma_Variation);
			LPMLLJKMAMP().SetFloat("Creating awesome maps", OGLODCDJJLB);
			FAIFBBGFAIB().SetFloat("OK", ALELLLFCDBF);
			JCPDCGIJKJD().SetFloat("SetPosition", NFDIFLHGJKB);
			DONENAMLFLF().SetVector("#exitmapeditor", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 845f, 185f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
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
			HHIFMIPPMPF().SetFloat("_Value2", HBJJOCHGOPH);
			GBFOAHKAJEK().SetFloat("_Radius", Therma_Variation);
			DIOAAHJDMLK().SetFloat("_TimeX", OGLODCDJJLB);
			NBPKMLMCHFN.SetFloat("No Name", ALELLLFCDBF);
			DEFBJOCJJKF().SetFloat("z", NFDIFLHGJKB);
			DIOAAHJDMLK().SetVector("Failed to 'network-remove' GameObject because it is missing a valid InstantiationId on view: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1818f, 417f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKHBBBFLGJH());
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
		SCShader = Shader.Find("CameraFilterPack_eyes_vision_1");
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
		SCShader = Shader.Find("CameraFilterPack_Fly_VisionFX");
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
			LDNADDJMIPK().SetFloat("file://", HBJJOCHGOPH);
			DIOAAHJDMLK().SetFloat(".GoalProgress", Therma_Variation);
			GBFOAHKAJEK().SetFloat(".completed", OGLODCDJJLB);
			OOMFJGPAOKL().SetFloat("</color>", ALELLLFCDBF);
			FLGPDBBKAIP().SetFloat("CameraFilterPack_TV_Arcade1", NFDIFLHGJKB);
			CIAFLBFJLEJ().SetVector("InfoCanvas", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 86f, 252f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PEIMCBBHLBJ());
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
		SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void DBEMDAJDDDA()
	{
		SCShader = Shader.Find("Destroying GO as global. ID: ");
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
			OJMHIMIPKME().SetFloat("Result for ", HBJJOCHGOPH);
			HKHBBBFLGJH().SetFloat("start", Therma_Variation);
			LDNADDJMIPK().SetFloat("PointsScoreText", OGLODCDJJLB);
			LPMLLJKMAMP().SetFloat("/", ALELLLFCDBF);
			NBMPPNFKFLB().SetFloat("No peer to communicate with. ", NFDIFLHGJKB);
			CFEDGDGBCHE().SetVector("offsets", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1835f, 94f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KGOLDDBHIFN());
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
			FLGPDBBKAIP().SetFloat("[DiscordController] Shutdown", HBJJOCHGOPH);
			EHDJJANLINB().SetFloat("You have added the SecondScrollRect to a scroll view that already has both directions selected", Therma_Variation);
			NBMPPNFKFLB().SetFloat("_EmissionGain", OGLODCDJJLB);
			HKHBBBFLGJH().SetFloat("Gameplay/Base", ALELLLFCDBF);
			GBFOAHKAJEK().SetFloat("HightScoreMaxPointsText", NFDIFLHGJKB);
			EHDJJANLINB().SetVector("_Radius", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 164f, 1899f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PEIMCBBHLBJ());
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
			DEFBJOCJJKF().SetFloat(": ", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("maps.", Therma_Variation);
			GBFOAHKAJEK().SetFloat("_Near", OGLODCDJJLB);
			OOMFJGPAOKL().SetFloat("ShowTitle", ALELLLFCDBF);
			GBFOAHKAJEK().SetFloat("_Value", NFDIFLHGJKB);
			OOMFJGPAOKL().SetVector("menu.enableselectormusic", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 392f, 1718f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GBFOAHKAJEK());
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
			CECJJMKLEAK().SetFloat("OpAuthenticate() failed. When you want Custom Authentication encryption is mandatory.", HBJJOCHGOPH);
			NBMPPNFKFLB().SetFloat("Map already submited. Update?", Therma_Variation);
			BLMPMOIDGMG().SetFloat("_Value3", OGLODCDJJLB);
			LDNADDJMIPK().SetFloat("settings.gamemessagesduration", ALELLLFCDBF);
			FOOCJIDNGBB().SetFloat("_TimeX", NFDIFLHGJKB);
			FAIFBBGFAIB().SetVector("settings.volume.game", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 324f, 87f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CEDFFAOOPOG()
	{
		SCShader = Shader.Find("error");
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
			FAIFBBGFAIB().SetFloat("FPSToggle", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat("OpJoinRandomRoom()", Therma_Variation);
			NBMPPNFKFLB().SetFloat("_Value2", OGLODCDJJLB);
			LDNADDJMIPK().SetFloat("float,0", ALELLLFCDBF);
			NBMPPNFKFLB().SetFloat("BadgeText", NFDIFLHGJKB);
			DEFBJOCJJKF().SetVector("settings.customdataskin", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1218f, 770f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
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
			LDNADDJMIPK().SetFloat("PLEASE WAIT", HBJJOCHGOPH);
			CIAFLBFJLEJ().SetFloat("_InvRenderTargetSize", Therma_Variation);
			DEFBJOCJJKF().SetFloat("_Bloom2", OGLODCDJJLB);
			JCPDCGIJKJD().SetFloat("[EditorEvent] Exception: ", ALELLLFCDBF);
			DIOAAHJDMLK().SetFloat("achievements.21.completed.workshop.", NFDIFLHGJKB);
			NBMPPNFKFLB().SetVector("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1759f, 1674f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
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
		SCShader = Shader.Find("/");
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
			CFEDGDGBCHE().SetFloat("_Near", HBJJOCHGOPH);
			FOOCJIDNGBB().SetFloat("================================", Therma_Variation);
			HCGJCMDJPGD().SetFloat("CameraFilterPack/Drawing_Lines", OGLODCDJJLB);
			BAGICADFBAB().SetFloat("float,10", ALELLLFCDBF);
			FLGPDBBKAIP().SetFloat("_FixDistance", NFDIFLHGJKB);
			KGOLDDBHIFN().SetVector("SpeedSlider", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 857f, 578f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JCPDCGIJKJD());
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
			FAIFBBGFAIB().SetFloat("_Value3", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat(" ", Therma_Variation);
			NBPKMLMCHFN.SetFloat("_TimeX", OGLODCDJJLB);
			OOMFJGPAOKL().SetFloat("Hex value #RRGGBB", ALELLLFCDBF);
			HKHBBBFLGJH().SetFloat("_FinalReflectionTexture", NFDIFLHGJKB);
			KGOLDDBHIFN().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1528f, 1276f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IKAIDLJKLFC());
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
			GBFOAHKAJEK().SetFloat("id", HBJJOCHGOPH);
			OOMFJGPAOKL().SetFloat("Set Particles Color", Therma_Variation);
			OOMFJGPAOKL().SetFloat("InputField", OGLODCDJJLB);
			JFDGLLEOPGB().SetFloat("Alpha", ALELLLFCDBF);
			JFDGLLEOPGB().SetFloat("_MainTex2", NFDIFLHGJKB);
			JCPDCGIJKJD().SetVector("<color=white>", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 898f, 1817f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIFMIPPMPF());
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
			LPMLLJKMAMP().SetFloat("_TimeX", HBJJOCHGOPH);
			GBFOAHKAJEK().SetFloat("ResetButton", Therma_Variation);
			NBPKMLMCHFN.SetFloat("IntraSig", OGLODCDJJLB);
			JFDGLLEOPGB().SetFloat("Saved Game: ", ALELLLFCDBF);
			OJMHIMIPKME().SetFloat("_MainTex2", NFDIFLHGJKB);
			GBFOAHKAJEK().SetVector(".", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 971f, 1521f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FLGPDBBKAIP());
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
			OJMHIMIPKME().SetFloat("_Value5", HBJJOCHGOPH);
			CECJJMKLEAK().SetFloat("_Value3", Therma_Variation);
			NBPKMLMCHFN.SetFloat("x", OGLODCDJJLB);
			DIOAAHJDMLK().SetFloat("_Value", ALELLLFCDBF);
			NBMPPNFKFLB().SetFloat("Square", NFDIFLHGJKB);
			CIAFLBFJLEJ().SetVector("GlassesColor2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1563f, 1534f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OJMHIMIPKME());
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
		SCShader = Shader.Find("Set Arcs Speed");
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
		SCShader = Shader.Find("Please attach component to a Graphical UI component");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void AIBNKIDADPI()
	{
		SCShader = Shader.Find("OnMastedChangeScene");
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
		SCShader = Shader.Find("_MainTex2");
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
			DEFBJOCJJKF().SetFloat("Object ID. Case-Sensitive", HBJJOCHGOPH);
			IKAIDLJKLFC().SetFloat("#lives", Therma_Variation);
			NBPKMLMCHFN.SetFloat("VoteUpToggle", OGLODCDJJLB);
			DEFBJOCJJKF().SetFloat("_TimeX", ALELLLFCDBF);
			NBPKMLMCHFN.SetFloat("[Right]", NFDIFLHGJKB);
			PEIMCBBHLBJ().SetVector("_Value", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 757f, 1322f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BAGICADFBAB());
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
			DEFBJOCJJKF().SetFloat("GroupNameText", Therma_Variation);
			NBPKMLMCHFN.SetFloat("_MaxRadiusOrKInPaper", OGLODCDJJLB);
			INOBFNCKFGK().SetFloat("#yes", ALELLLFCDBF);
			LDNADDJMIPK().SetFloat("_ScreenResolution", NFDIFLHGJKB);
			BLMPMOIDGMG().SetVector("MapperNameText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 923f, 1225f));
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
		SCShader = Shader.Find("challenges.");
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
			EHDJJANLINB().SetFloat("_LowRez", HBJJOCHGOPH);
			CECJJMKLEAK().SetFloat(" ", Therma_Variation);
			LDNADDJMIPK().SetFloat("_Offsets", OGLODCDJJLB);
			DEFBJOCJJKF().SetFloat("SpawnObj", ALELLLFCDBF);
			FLGPDBBKAIP().SetFloat("Init", NFDIFLHGJKB);
			OOMFJGPAOKL().SetVector("_SSAO", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 281f, 1130f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void COOHIILCOCO()
	{
		SCShader = Shader.Find("skin.hit_normal");
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
		SCShader = Shader.Find("MainButton");
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
			LDNADDJMIPK().SetFloat("Run a command for the Localization Servise", HBJJOCHGOPH);
			HHIFMIPPMPF().SetFloat("yyyy-MM-dd HH:mm:ss", Therma_Variation);
			FAIFBBGFAIB().SetFloat("SetTrailZoomSpeed", OGLODCDJJLB);
			NBPKMLMCHFN.SetFloat("_BokehParams", ALELLLFCDBF);
			GBFOAHKAJEK().SetFloat("_TimeX", NFDIFLHGJKB);
			HHIFMIPPMPF().SetVector("Music End", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 260f, 659f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GBFOAHKAJEK());
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
		SCShader = Shader.Find(".lastCheckpoint.checkpointsUsed");
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
			FOOCJIDNGBB().SetFloat("Incoming: \n", HBJJOCHGOPH);
			PEIMCBBHLBJ().SetFloat("BlockCount", Therma_Variation);
			NBPKMLMCHFN.SetFloat(" is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package.", OGLODCDJJLB);
			JCPDCGIJKJD().SetFloat("\n", ALELLLFCDBF);
			FLGPDBBKAIP().SetFloat(":", NFDIFLHGJKB);
			FAIFBBGFAIB().SetVector("_TimeX", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1956f, 1014f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EHDJJANLINB());
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
			INOBFNCKFGK().SetFloat("EXCEPTION:", HBJJOCHGOPH);
			BLMPMOIDGMG().SetFloat(",", Therma_Variation);
			KGOLDDBHIFN().SetFloat("StartButton", OGLODCDJJLB);
			KGOLDDBHIFN().SetFloat("z", ALELLLFCDBF);
			IKAIDLJKLFC().SetFloat("default", NFDIFLHGJKB);
			DIOAAHJDMLK().SetVector("{0} years ago", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1756f, 494f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
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
			GBFOAHKAJEK().SetFloat("_TimeX", HBJJOCHGOPH);
			DEFBJOCJJKF().SetFloat("_threshold", Therma_Variation);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", OGLODCDJJLB);
			IKAIDLJKLFC().SetFloat("_TimeX", ALELLLFCDBF);
			NBMPPNFKFLB().SetFloat("Curve texture", NFDIFLHGJKB);
			EHDJJANLINB().SetVector("CameraFilterPack/Color_Switching", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 936f, 901f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
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
		SCShader = Shader.Find("Out {0,4} | In {1,4} | Sum {2,4}");
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
			INOBFNCKFGK().SetFloat("EditMenu", HBJJOCHGOPH);
			BLMPMOIDGMG().SetFloat("SetSunMinSize", Therma_Variation);
			HHIFMIPPMPF().SetFloat("Unsupported target enum: ", OGLODCDJJLB);
			LPMLLJKMAMP().SetFloat("_BlurVector", ALELLLFCDBF);
			EHDJJANLINB().SetFloat("HighScaleShot", NFDIFLHGJKB);
			GBFOAHKAJEK().SetVector("FPSToggle", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 974f, 1791f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, PEIMCBBHLBJ());
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
			CIAFLBFJLEJ().SetFloat(" ", HBJJOCHGOPH);
			CECJJMKLEAK().SetFloat("[PlayerController] ", Therma_Variation);
			CIAFLBFJLEJ().SetFloat("itemid", OGLODCDJJLB);
			NBPKMLMCHFN.SetFloat("_TimeX", ALELLLFCDBF);
			CIAFLBFJLEJ().SetFloat("0,7,true,0", NFDIFLHGJKB);
			PEIMCBBHLBJ().SetVector("challengeid", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 988f, 1213f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
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
			LDNADDJMIPK().SetFloat("CameraFilterPack/Colors_NewPosterize", HBJJOCHGOPH);
			GBFOAHKAJEK().SetFloat(".", Therma_Variation);
			PEIMCBBHLBJ().SetFloat("isBunned", OGLODCDJJLB);
			OJMHIMIPKME().SetFloat("_Extra2", ALELLLFCDBF);
			BLMPMOIDGMG().SetFloat("https://bitbucket.org/khb-soft/intralismarcsviewer/", NFDIFLHGJKB);
			NBMPPNFKFLB().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1501f, 82f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FOOCJIDNGBB());
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
			NBPKMLMCHFN.SetFloat("/Segment-[Up]", HBJJOCHGOPH);
			CIAFLBFJLEJ().SetFloat(" user's map(s)", Therma_Variation);
			HCGJCMDJPGD().SetFloat("_SecondTex", OGLODCDJJLB);
			DIOAAHJDMLK().SetFloat("_Value3", ALELLLFCDBF);
			CFEDGDGBCHE().SetFloat("_Visualize", NFDIFLHGJKB);
			FLGPDBBKAIP().SetVector("CameraFilterPack/Glow_Glow_Color", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 275f, 906f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HCGJCMDJPGD());
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
			HHIFMIPPMPF().SetFloat("ConfigVersionSlider", HBJJOCHGOPH);
			CECJJMKLEAK().SetFloat("_Visualize", Therma_Variation);
			CIAFLBFJLEJ().SetFloat("Room: '{0}' {1},{2} {4}/{3} players.", OGLODCDJJLB);
			FLGPDBBKAIP().SetFloat("PunRespawn with Position.", ALELLLFCDBF);
			CIAFLBFJLEJ().SetFloat("MapFolderInputField", NFDIFLHGJKB);
			EHDJJANLINB().SetVector("_Value2", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1034f, 1632f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LIBGAKMKHJJ()
	{
		SCShader = Shader.Find("_Radius");
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
