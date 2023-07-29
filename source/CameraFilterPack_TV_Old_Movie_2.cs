// CameraFilterPack_TV_Old_Movie_2
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Old Film/Old_Movie_2")]
public class CameraFilterPack_TV_Old_Movie_2 : MonoBehaviour
{
	public Shader SCShader;

	private float HBJJOCHGOPH = 1f;

	private Vector4 GOIJPFAHKPE;

	private Material BJFKDHHMLJH;

	[Range(1f, 60f)]
	public float FramePerSecond = 15f;

	[Range(0f, 5f)]
	public float Contrast = 1f;

	[Range(0f, 4f)]
	public float Burn;

	[Range(0f, 16f)]
	public float SceneCut = 1f;

	[Range(0f, 1f)]
	public float Fade = 1f;

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

	private void PAEGLMEOKHP()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material EHDJJANLINB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-110);
		}
		return BJFKDHHMLJH;
	}

	private void LCDJFJIBADI()
	{
	}

	[SpecialName]
	private Material MLMKCOINOOH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)101;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material LDNADDJMIPK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable;
		}
		return BJFKDHHMLJH;
	}

	private void KNBJBNDGCIJ()
	{
	}

	private void MGMAOBPPOBJ()
	{
	}

	private void ALMGMOOHLMA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MKOMIDCPCDC()
	{
	}

	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 176f)
			{
				HBJJOCHGOPH = 1802f;
			}
			EFDEIFCDAFG().SetFloat("[MapEditor] Updating map assets", HBJJOCHGOPH);
			DOHGBNPMBKG().SetFloat(".wav", FramePerSecond);
			LONNIJMNKFB().SetFloat("#ok", Contrast);
			HEINDEMCGIK().SetFloat("SetSatelliteColor", Burn);
			MICHFGAOPKM().SetFloat("1,30,true,0", SceneCut);
			EHDJJANLINB().SetFloat("SpawnObj", Fade);
			LPDOGGFOBDH().SetVector("PossibleMapPointsText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 456f, 152f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 960f)
			{
				HBJJOCHGOPH = 46f;
			}
			OGMEGHKECAH().SetFloat(".lastCheckpoint.bgcolor", HBJJOCHGOPH);
			KDMBOKLMADJ().SetFloat("recipes", FramePerSecond);
			EHDJJANLINB().SetFloat("SetSatelliteEmission", Contrast);
			MICHFGAOPKM().SetFloat("_ColorLevel", Burn);
			HEINDEMCGIK().SetFloat("CameraFilterPack/Blend2Camera_Overlay", SceneCut);
			NBPKMLMCHFN.SetFloat(": ", Fade);
			LPPEPKGFOEM().SetVector("_Color", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 865f, 328f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NDAJBJFJGCF()
	{
	}

	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 645f)
			{
				HBJJOCHGOPH = 897f;
			}
			BAGICADFBAB().SetFloat("workshop.", HBJJOCHGOPH);
			LDNADDJMIPK().SetFloat("_Offsets", FramePerSecond);
			ADBKPGFMNKO().SetFloat("_Params1", Contrast);
			GJHPODJOBHL().SetFloat("_Parasite", Burn);
			HKGAONMOBMH().SetFloat("Network destroy Instantiated GO: ", SceneCut);
			HKHBBBFLGJH().SetFloat("CameraFilterPack/Edge_Golden", Fade);
			AELJLBOJAIL().SetVector("ItemsCountText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 928f, 1730f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GJHPODJOBHL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DKGBFNCOAEO()
	{
	}

	private void LDDKCCMHMIC()
	{
	}

	[SpecialName]
	private Material DNLMFEGJJDD()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void BMODOIJGIOO()
	{
	}

	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1521f)
			{
				HBJJOCHGOPH = 232f;
			}
			LMLENGFLEBD().SetFloat("Uploading content", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat("settings.enablerankingnotifications", FramePerSecond);
			OGMEGHKECAH().SetFloat("[Singleton] An instance of '", Contrast);
			EFMCNLELMDO().SetFloat("_Value3", Burn);
			GJHPODJOBHL().SetFloat(" does not exist!", SceneCut);
			NBPKMLMCHFN.SetFloat("Set satellite trail width", Fade);
			HKGAONMOBMH().SetVector(". The group number should be at least 1.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 742f, 809f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JEBIBKLHFLB()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KMCPMOGKDEH()
	{
	}

	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 894f)
			{
				HBJJOCHGOPH = 1313f;
			}
			MLMKCOINOOH().SetFloat("MapEditor v.", HBJJOCHGOPH);
			BAGICADFBAB().SetFloat("menu.selectedplaymode", FramePerSecond);
			EHDJJANLINB().SetFloat("settings.crosshairopacity", Contrast);
			LPDOGGFOBDH().SetFloat("_ScreenResolution", Burn);
			DOHGBNPMBKG().SetFloat("IconImage", SceneCut);
			LPDOGGFOBDH().SetFloat("r", Fade);
			AELJLBOJAIL().SetVector("id", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1020f, 1457f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material EFMCNLELMDO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset;
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

	private void NAOLAJPDGIC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material AELJLBOJAIL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-119);
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

	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 699f)
			{
				HBJJOCHGOPH = 1241f;
			}
			DOHGBNPMBKG().SetFloat(" Time: ", HBJJOCHGOPH);
			HEHKGPKLAKK().SetFloat("#challengecomplete", FramePerSecond);
			HKHBBBFLGJH().SetFloat("#onrankchangeuptext", Contrast);
			DNLMFEGJJDD().SetFloat("Set Sun Lerp Speed", Burn);
			MLMKCOINOOH().SetFloat("CameraFilterPack_Atmosphere_Rain_FX", SceneCut);
			BAGICADFBAB().SetFloat("_Value2", Fade);
			GJHPODJOBHL().SetVector("Left", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1153f, 329f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EPEGAEGDJAM()
	{
	}

	[SpecialName]
	private Material PLBEJJIHFPB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void OMCLOFCJMPG()
	{
	}

	[SpecialName]
	private Material GJHPODJOBHL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-66);
		}
		return BJFKDHHMLJH;
	}

	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1601f)
			{
				HBJJOCHGOPH = 1025f;
			}
			BAGICADFBAB().SetFloat("seconds", HBJJOCHGOPH);
			LPDOGGFOBDH().SetFloat("input", FramePerSecond);
			LPDOGGFOBDH().SetFloat("_MainTex2", Contrast);
			GHHPOGODBHB().SetFloat("BitsData", Burn);
			LONNIJMNKFB().SetFloat("#timeuntilchallenge: ", SceneCut);
			MICHFGAOPKM().SetFloat("inventory.selected.", Fade);
			MICHFGAOPKM().SetVector("SetSatelliteTrailWidth", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 687f, 1706f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void GKNKIIEALCH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LADCJEIALMH()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GAOOPEEBGJA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1398f)
			{
				HBJJOCHGOPH = 407f;
			}
			LDNADDJMIPK().SetFloat("MenuScene", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat("CameraFilterPack/TV_Vcr", FramePerSecond);
			HKHBBBFLGJH().SetFloat("Connected to NameServer.", Contrast);
			DOHGBNPMBKG().SetFloat(".lastCheckpoint.perfectHits", Burn);
			LPDOGGFOBDH().SetFloat("Save", SceneCut);
			KDMBOKLMADJ().SetFloat("_Offsets", Fade);
			NBPKMLMCHFN.SetVector("[LocalizationService] All languages: ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 952f, 304f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MICHFGAOPKM());
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
			if (HBJJOCHGOPH > 487f)
			{
				HBJJOCHGOPH = 1092f;
			}
			AELJLBOJAIL().SetFloat("-1", HBJJOCHGOPH);
			LPPEPKGFOEM().SetFloat("_Noise", FramePerSecond);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/Film_ColorPerfection", Contrast);
			MLMKCOINOOH().SetFloat("cancel", Burn);
			LMLENGFLEBD().SetFloat("ConnectToRegion: ", SceneCut);
			AELJLBOJAIL().SetFloat("_Value3", Fade);
			KDMBOKLMADJ().SetVector("caret", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 297f, 1885f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LKBOEPPBLIF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 884f)
			{
				HBJJOCHGOPH = 475f;
			}
			HKHBBBFLGJH().SetFloat("Joystick1Button10", HBJJOCHGOPH);
			EFMCNLELMDO().SetFloat("ComboScoreText", FramePerSecond);
			MFHPKGICPIO().SetFloat("_Bloom5", Contrast);
			GHHPOGODBHB().SetFloat("_TimeX", Burn);
			LPDOGGFOBDH().SetFloat("PhotonNetwork error: Could not Instantiate the prefab [", SceneCut);
			MICHFGAOPKM().SetFloat("RecieveChatActionMessage", Fade);
			HEHKGPKLAKK().SetVector("settings.enablehitsoundsinrelax", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1307f, 1122f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFMCNLELMDO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void CIPKEPDELJB()
	{
	}

	[SpecialName]
	private Material HEINDEMCGIK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-126);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material MFHPKGICPIO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)94;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HKGAONMOBMH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return BJFKDHHMLJH;
	}

	private void EPJJDKJEDMM()
	{
	}

	private void DLMPALHKMON()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ONKDMMJPEMN()
	{
	}

	[SpecialName]
	private Material OGMEGHKECAH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)70;
		}
		return BJFKDHHMLJH;
	}

	private void LCHBFNIPBHB()
	{
	}

	[SpecialName]
	private Material HKHBBBFLGJH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-65);
		}
		return BJFKDHHMLJH;
	}

	private void LLJLDLLNFBH()
	{
	}

	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 855f)
			{
				HBJJOCHGOPH = 1507f;
			}
			AELJLBOJAIL().SetFloat("_Value2", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_TimeX", FramePerSecond);
			GCDFNHMJMIP().SetFloat("Unsupported target enum: ", Contrast);
			DOHGBNPMBKG().SetFloat("_LutTex", Burn);
			OCHJIMJNEMO().SetFloat("Fill Area", SceneCut);
			ADBKPGFMNKO().SetFloat("_TimeX", Fade);
			PLBEJJIHFPB().SetVector("PlayMusic", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1962f, 1289f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void KKLMPKLKAEM()
	{
	}

	private void FJNCHGLIEMA()
	{
	}

	[SpecialName]
	private Material BAGICADFBAB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable;
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
	private Material CFEDGDGBCHE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)95;
		}
		return BJFKDHHMLJH;
	}

	private void KMEONPMCNJG()
	{
	}

	private void DFFKKLAPHCC()
	{
	}

	private void JAAJECBCCFM()
	{
	}

	[SpecialName]
	private Material DOHGBNPMBKG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)97;
		}
		return BJFKDHHMLJH;
	}

	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1156f)
			{
				HBJJOCHGOPH = 1393f;
			}
			DNLMFEGJJDD().SetFloat("Icon", HBJJOCHGOPH);
			AELJLBOJAIL().SetFloat("/files/mods_terms.pdf", FramePerSecond);
			GJHPODJOBHL().SetFloat("_Value2", Contrast);
			MICHFGAOPKM().SetFloat("_Value", Burn);
			AELJLBOJAIL().SetFloat("_ScreenResolution", SceneCut);
			MLMKCOINOOH().SetFloat("/icon", Fade);
			LDNADDJMIPK().SetVector("roomDescription", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 558f, 604f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LONNIJMNKFB());
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
			if (HBJJOCHGOPH > 121f)
			{
				HBJJOCHGOPH = 498f;
			}
			LONNIJMNKFB().SetFloat("Source Object: ", HBJJOCHGOPH);
			LONNIJMNKFB().SetFloat("?", FramePerSecond);
			KDMBOKLMADJ().SetFloat("note.5", Contrast);
			MFHPKGICPIO().SetFloat("CameraFilterPack/BlurTiltShift_Hole", Burn);
			CFEDGDGBCHE().SetFloat("{0:0}", SceneCut);
			GCDFNHMJMIP().SetFloat("<color=#", Fade);
			EHDJJANLINB().SetVector("0.00", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 817f, 597f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
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
			BJFKDHHMLJH.hideFlags = (HideFlags)(-106);
		}
		return BJFKDHHMLJH;
	}

	private void EKCKJLFFAID()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1701f)
			{
				HBJJOCHGOPH = 1881f;
			}
			PLBEJJIHFPB().SetFloat("_Value4", HBJJOCHGOPH);
			GHHPOGODBHB().SetFloat("CameraFilterPack/Blend2Camera_Darken", FramePerSecond);
			BAGICADFBAB().SetFloat(" - LOCAL", Contrast);
			DOHGBNPMBKG().SetFloat("B", Burn);
			PLBEJJIHFPB().SetFloat("Room: '{0}' {1},{2} {4}/{3} players.\ncustomProps: {5}", SceneCut);
			CFEDGDGBCHE().SetFloat("colorD", Fade);
			LONNIJMNKFB().SetVector("_WorldToCameraMatrix", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 741f, 831f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LPPEPKGFOEM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NNCCPEBIAKH()
	{
	}

	private void COOHIILCOCO()
	{
	}

	private void MKIMDFLBFOM()
	{
	}

	private void MDNHCLKNCLE()
	{
	}

	private void LMADKINICIN()
	{
	}

	[SpecialName]
	private Material LPPEPKGFOEM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material GCDFNHMJMIP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material GHHPOGODBHB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	private void FODKODGPPDA()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void GNMGIHFKJIJ()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NFEDLAOPHML()
	{
	}

	[SpecialName]
	private Material LPDOGGFOBDH()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void OEENOOGEEHD()
	{
	}

	[SpecialName]
	private Material LONNIJMNKFB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)87;
		}
		return BJFKDHHMLJH;
	}

	private void CFIAKIJAILI()
	{
	}

	private void PKHPNHBEKHA()
	{
	}

	private void PKLOBJHKFEO()
	{
	}

	private void IMCKJCHKMKB()
	{
	}

	[SpecialName]
	private Material EFDEIFCDAFG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)68;
		}
		return BJFKDHHMLJH;
	}

	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1160f)
			{
				HBJJOCHGOPH = 436f;
			}
			LONNIJMNKFB().SetFloat("_Value3", HBJJOCHGOPH);
			GJHPODJOBHL().SetFloat("GlassDistortion", FramePerSecond);
			LPDOGGFOBDH().SetFloat("_SecondTex", Contrast);
			HEHKGPKLAKK().SetFloat("...", Burn);
			DNLMFEGJJDD().SetFloat("BitsData", SceneCut);
			LONNIJMNKFB().SetFloat("Couldn't color correct with 3D LUT texture. Image Effect will be disabled.", Fade);
			HEINDEMCGIK().SetVector("SpectateButton", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1414f, 1761f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FOLDLDLFFLM()
	{
	}

	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 4f)
			{
				HBJJOCHGOPH = 1652f;
			}
			MLMKCOINOOH().SetFloat("ShadersToggle", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat("BestScoreText", FramePerSecond);
			LONNIJMNKFB().SetFloat("Left", Contrast);
			BAGICADFBAB().SetFloat("/", Burn);
			OCHJIMJNEMO().SetFloat("_Screen", SceneCut);
			NBPKMLMCHFN.SetFloat("colorD", Fade);
			DOHGBNPMBKG().SetVector("CameraFilterPack/Vision_Blood", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1066f, 1686f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1016f)
			{
				HBJJOCHGOPH = 1765f;
			}
			OGMEGHKECAH().SetFloat("_Fade", HBJJOCHGOPH);
			LPPEPKGFOEM().SetFloat("#task", FramePerSecond);
			EFMCNLELMDO().SetFloat("_Jitter", Contrast);
			MFHPKGICPIO().SetFloat("SetupEncryption() called but ignored. Not XB1 compiled. EncryptionData: ", Burn);
			HKGAONMOBMH().SetFloat("LevelInfoInputField", SceneCut);
			EHDJJANLINB().SetFloat("No Camera attached!", Fade);
			NBPKMLMCHFN.SetVector("_Blue_C", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 379f, 1510f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
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
			NBPKMLMCHFN.SetFloat("_Value", FramePerSecond);
			NBPKMLMCHFN.SetFloat("_Value2", Contrast);
			NBPKMLMCHFN.SetFloat("_Value3", Burn);
			NBPKMLMCHFN.SetFloat("_Value4", SceneCut);
			NBPKMLMCHFN.SetFloat("_Fade", Fade);
			NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void Start()
	{
	}

	private void CHOPDIGHJNH()
	{
	}

	private void OnDisable()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material ADBKPGFMNKO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HEHKGPKLAKK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material KDMBOKLMADJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-91);
		}
		return BJFKDHHMLJH;
	}

	private void ICDBMJKMIKC()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LLKKGGLNIDF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MAOCOEGAFND()
	{
	}

	private void MNBPNHNAEBK()
	{
	}

	private void AIJGAJIOJDJ()
	{
	}

	private void HDMDKOKOOJC()
	{
	}

	private void FPHLDMMAOEF()
	{
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material MICHFGAOPKM()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1107f)
			{
				HBJJOCHGOPH = 266f;
			}
			DOHGBNPMBKG().SetFloat("player.playedtutorial", HBJJOCHGOPH);
			BAGICADFBAB().SetFloat("#tryagain", FramePerSecond);
			KDMBOKLMADJ().SetFloat("SpawnObj", Contrast);
			HEINDEMCGIK().SetFloat("maps.", Burn);
			HKHBBBFLGJH().SetFloat("x", SceneCut);
			CFEDGDGBCHE().SetFloat("_Distortion", Fade);
			ADBKPGFMNKO().SetVector("_MainTex", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 229f, 1286f));
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
	private Material OCHJIMJNEMO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-99);
		}
		return BJFKDHHMLJH;
	}
}
