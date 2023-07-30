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
			CFEDGDGBCHE().SetFloat("/", HBJJOCHGOPH);
			OGMEGHKECAH().SetFloat(".ogg", FramePerSecond);
			GCDFNHMJMIP().SetFloat("PLEASE WAIT", Contrast);
			MFHPKGICPIO().SetFloat("Set sun directionVector - in which direction sun will grow on beat", Burn);
			PLBEJJIHFPB().SetFloat("speed", SceneCut);
			OGMEGHKECAH().SetFloat("SpawnObj", Fade);
			GCDFNHMJMIP().SetVector("PossibleMapPointsText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 456f, 152f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
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
			EFDEIFCDAFG().SetFloat(".lastCheckpoint.playerdistance", HBJJOCHGOPH);
			EFMCNLELMDO().SetFloat("#or", FramePerSecond);
			OGMEGHKECAH().SetFloat("Set satellite color", Contrast);
			HKHBBBFLGJH().SetFloat("_ColorLevel", Burn);
			AELJLBOJAIL().SetFloat("CameraFilterPack/Blend2Camera_Overlay", SceneCut);
			GHHPOGODBHB().SetFloat(" not exist", Fade);
			NBPKMLMCHFN.SetVector("BlockCount", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 865f, 328f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
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
			EFMCNLELMDO().SetFloat("LevelNameText", HBJJOCHGOPH);
			MLMKCOINOOH().SetFloat("_LowRez", FramePerSecond);
			PLBEJJIHFPB().SetFloat("_SearchTex", Contrast);
			HKGAONMOBMH().SetFloat("_Colorisation", Burn);
			MICHFGAOPKM().SetFloat("Failed to 'network-remove' GameObject because it is missing a valid InstantiationId on view: ", SceneCut);
			MLMKCOINOOH().SetFloat("_ScreenResolution", Fade);
			GCDFNHMJMIP().SetVector("x", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 928f, 1730f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
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
			OCHJIMJNEMO().SetFloat("Preparing configuration", HBJJOCHGOPH);
			LPPEPKGFOEM().SetFloat("settings.enablerankingnotifications", FramePerSecond);
			LMLENGFLEBD().SetFloat("[Singleton] Using instance of '", Contrast);
			LPDOGGFOBDH().SetFloat("_Value3", Burn);
			GCDFNHMJMIP().SetFloat(".sav", SceneCut);
			MLMKCOINOOH().SetFloat("float,2", Fade);
			MICHFGAOPKM().SetVector(". The group number should be at least 1.", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 742f, 809f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFMCNLELMDO());
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
			MFHPKGICPIO().SetFloat("#ok", HBJJOCHGOPH);
			LPDOGGFOBDH().SetFloat("back", FramePerSecond);
			AELJLBOJAIL().SetFloat("settings.crosshairopacity", Contrast);
			LMLENGFLEBD().SetFloat("_ScreenResolution", Burn);
			LPDOGGFOBDH().SetFloat("IconImage", SceneCut);
			OCHJIMJNEMO().SetFloat("Can't find key ", Fade);
			MFHPKGICPIO().SetVector("Set Satellite Trail MinVertexDistance", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1020f, 1457f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, AELJLBOJAIL());
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
			DOHGBNPMBKG().SetFloat(" ownership transfered to: ", HBJJOCHGOPH);
			LPDOGGFOBDH().SetFloat("challenges.", FramePerSecond);
			OCHJIMJNEMO().SetFloat("player.currentrank", Contrast);
			HEHKGPKLAKK().SetFloat("Set Sun Lerp Speed", Burn);
			HEINDEMCGIK().SetFloat("CameraFilterPack_Atmosphere_Rain_FX", SceneCut);
			MLMKCOINOOH().SetFloat("_Value", Fade);
			PLBEJJIHFPB().SetVector("Keypad ", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1153f, 329f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, GHHPOGODBHB());
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
			AELJLBOJAIL().SetFloat("fade in duration", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("input", FramePerSecond);
			OCHJIMJNEMO().SetFloat("_MainTex2", Contrast);
			EFMCNLELMDO().SetFloat("BitsData", Burn);
			EHDJJANLINB().SetFloat("#", SceneCut);
			KDMBOKLMADJ().SetFloat("21x3", Fade);
			DOHGBNPMBKG().SetVector("Set satellite trail length in seconds", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 687f, 1706f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
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
			OCHJIMJNEMO().SetFloat("<b>Commands:</b>\n/help\n/players\n/kick\n/table\n/clear", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("_ScreenResolution", FramePerSecond);
			OGMEGHKECAH().SetFloat("FindFriends failed to apply the result, as a required value wasn't provided or the friend list length differed from result.", Contrast);
			EHDJJANLINB().SetFloat(".lastCheckpoint.checkpointsUsed", Burn);
			LPDOGGFOBDH().SetFloat("???", SceneCut);
			MLMKCOINOOH().SetFloat("_StretchWidth", Fade);
			OCHJIMJNEMO().SetVector("list", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 952f, 304f));
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
			if (HBJJOCHGOPH > 487f)
			{
				HBJJOCHGOPH = 1092f;
			}
			CFEDGDGBCHE().SetFloat("-1", HBJJOCHGOPH);
			GHHPOGODBHB().SetFloat("_Parasite", FramePerSecond);
			CFEDGDGBCHE().SetFloat("_MainTex2", Contrast);
			DOHGBNPMBKG().SetFloat("...", Burn);
			AELJLBOJAIL().SetFloat("ConnectToRegion() failed. Can only connect while in state 'Disconnected'. Current state: ", SceneCut);
			BAGICADFBAB().SetFloat("_Value2", Fade);
			MICHFGAOPKM().SetVector("grid", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 297f, 1885f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DNLMFEGJJDD());
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
			LPDOGGFOBDH().SetFloat("Start", HBJJOCHGOPH);
			MICHFGAOPKM().SetFloat("IncorrectHitsScoreText", FramePerSecond);
			HEINDEMCGIK().SetFloat("_Bloom3", Contrast);
			DNLMFEGJJDD().SetFloat("_TimeX", Burn);
			DNLMFEGJJDD().SetFloat(". Should be just one?", SceneCut);
			MFHPKGICPIO().SetFloat("RecieveChatActionMessage", Fade);
			LPDOGGFOBDH().SetVector("settings.enablehitsoundsinrelax", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1307f, 1122f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK());
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
			MFHPKGICPIO().SetFloat("CameraFilterPack/Light_Water", FramePerSecond);
			BAGICADFBAB().SetFloat(" or player:", Contrast);
			PLBEJJIHFPB().SetFloat(" cannot be used as a 3D LUT.", Burn);
			PLBEJJIHFPB().SetFloat("LevelProgressBar", SceneCut);
			MFHPKGICPIO().SetFloat("CameraFilterPack/TV_Chromatical", Fade);
			GHHPOGODBHB().SetVector("StopSounds", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1962f, 1289f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
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
			BAGICADFBAB().SetFloat("IDInputField", HBJJOCHGOPH);
			CFEDGDGBCHE().SetFloat("ALREADY SEEN", FramePerSecond);
			MFHPKGICPIO().SetFloat("_Value2", Contrast);
			MICHFGAOPKM().SetFloat("_TimeX", Burn);
			LDNADDJMIPK().SetFloat("_Value2", SceneCut);
			EFMCNLELMDO().SetFloat("/icon", Fade);
			DNLMFEGJJDD().SetVector("roomDescription", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 558f, 604f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, ADBKPGFMNKO());
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
			OCHJIMJNEMO().SetFloat("Is Clone ?: ", HBJJOCHGOPH);
			ADBKPGFMNKO().SetFloat("?", FramePerSecond);
			NBPKMLMCHFN.SetFloat("note.3", Contrast);
			ADBKPGFMNKO().SetFloat("CameraFilterPack/BlurTiltShift_Hole", Burn);
			HEINDEMCGIK().SetFloat("{0:0}", SceneCut);
			LMLENGFLEBD().SetFloat("</color>", Fade);
			OGMEGHKECAH().SetVector("HightScoreMaxPointsText", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 817f, 597f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, EFDEIFCDAFG());
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
			KDMBOKLMADJ().SetFloat("_Value3", HBJJOCHGOPH);
			LDNADDJMIPK().SetFloat("CameraFilterPack/Blend2Camera_Darken", FramePerSecond);
			HEINDEMCGIK().SetFloat("]", Contrast);
			MFHPKGICPIO().SetFloat("A", Burn);
			LDNADDJMIPK().SetFloat("hidden", SceneCut);
			EFDEIFCDAFG().SetFloat("colorC", Fade);
			MFHPKGICPIO().SetVector("_CameraClipInfo", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 741f, 831f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CFEDGDGBCHE());
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
			OCHJIMJNEMO().SetFloat("_Value", HBJJOCHGOPH);
			HEHKGPKLAKK().SetFloat("VisionBlur", FramePerSecond);
			MICHFGAOPKM().SetFloat("_Offsets", Contrast);
			AELJLBOJAIL().SetFloat("...", Burn);
			NBPKMLMCHFN.SetFloat("BitsData", SceneCut);
			LONNIJMNKFB().SetFloat("The given 2D texture ", Fade);
			HKHBBBFLGJH().SetVector("SpectateButton", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1414f, 1761f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HKGAONMOBMH());
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
			BAGICADFBAB().SetFloat("GraphicsQualitySlider", HBJJOCHGOPH);
			GJHPODJOBHL().SetFloat("BestScoreText", FramePerSecond);
			HEHKGPKLAKK().SetFloat("SpawnObj", Contrast);
			BAGICADFBAB().SetFloat("#ok", Burn);
			LONNIJMNKFB().SetFloat("pointBuffer", SceneCut);
			LPPEPKGFOEM().SetFloat("colorB", Fade);
			MICHFGAOPKM().SetVector("_Value5", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 1066f, 1686f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, LDNADDJMIPK());
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
			EFDEIFCDAFG().SetFloat("_TimeX", HBJJOCHGOPH);
			PLBEJJIHFPB().SetFloat("[#clicktogetreward]", FramePerSecond);
			PLBEJJIHFPB().SetFloat("_MinVelocity", Contrast);
			MFHPKGICPIO().SetFloat("Warning: Unhandled event ", Burn);
			EFDEIFCDAFG().SetFloat("Tab1Content", SceneCut);
			MICHFGAOPKM().SetFloat("ConnectionTimeout", Fade);
			LDNADDJMIPK().SetVector("_Green_C", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 379f, 1510f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MFHPKGICPIO());
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
			KDMBOKLMADJ().SetFloat("https://store.steampowered.com/recommended/recommendgame/", HBJJOCHGOPH);
			GHHPOGODBHB().SetFloat("request", FramePerSecond);
			DOHGBNPMBKG().SetFloat("SpawnObj", Contrast);
			CFEDGDGBCHE().SetFloat("maps.", Burn);
			EHDJJANLINB().SetFloat("InfoCanvas", SceneCut);
			HKHBBBFLGJH().SetFloat("_TimeX", Fade);
			ADBKPGFMNKO().SetVector("_InvRenderTargetSize", new Vector4(AAACLELCPML.width, AAACLELCPML.height, 229f, 1286f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OGMEGHKECAH());
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
