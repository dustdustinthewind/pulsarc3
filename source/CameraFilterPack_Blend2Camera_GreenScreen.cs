// CameraFilterPack_Blend2Camera_GreenScreen
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Chroma Key/GreenScreen")]
public class CameraFilterPack_Blend2Camera_GreenScreen : MonoBehaviour
{
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_GreenScreen";

	public Shader SCShader;

	public Camera Camera2;

	private float HBJJOCHGOPH = 1f;

	private Material BJFKDHHMLJH;

	[Range(0f, 1f)]
	public float BlendFX = 1f;

	[Range(-0.2f, 0.2f)]
	public float Adjust;

	[Range(-0.2f, 0.2f)]
	public float Precision;

	[Range(-0.2f, 0.2f)]
	public float Luminosity;

	[Range(-0.3f, 0.3f)]
	public float Change_Red;

	[Range(-0.3f, 0.3f)]
	public float Change_Green;

	[Range(-0.3f, 0.3f)]
	public float Change_Blue;

	private RenderTexture JDMCFBKJHDD;

	private Vector2 FPEMMGKMJGA;

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

	private void JICMFFAOJJB()
	{
		ALJEJJCIMJN();
		PKGJJFIFLII();
	}

	[SpecialName]
	private Material HNFFHCLNBDN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-74);
		}
		return BJFKDHHMLJH;
	}

	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1716f)
			{
				HBJJOCHGOPH = 1112f;
			}
			if (Camera2 != null)
			{
				IKAIDLJKLFC().SetTexture("CameraFilterPack/Colors_BleachBypass", JDMCFBKJHDD);
			}
			HHIAIGCAHDA().SetFloat("CameraFilterPack/Edge_BlackLine", HBJJOCHGOPH);
			OIBHFCLJKDB().SetFloat("CameraFilterPack/Drawing_Paper3", BlendFX);
			NBMPPNFKFLB().SetFloat("JoinRoom failed. In offline mode you still have to leave a room to enter another.", Adjust);
			KLKILLCHJHO().SetFloat("_AxialAberration", Precision);
			HBLDMJCOAHA().SetFloat("_TimeX", Luminosity);
			ADGHJOHKEHG().SetFloat("Fade", Change_Red);
			MNLKBFFKHIE().SetFloat("maps.", Change_Green);
			BLMPMOIDGMG().SetFloat("_Value4", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MHGPANIBBCM()
	{
		BMOFEBKGLFI();
		MBLDJEFBLFL();
	}

	[SpecialName]
	private Material ADBKPGFMNKO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)73;
		}
		return BJFKDHHMLJH;
	}

	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1237f)
			{
				HBJJOCHGOPH = 1684f;
			}
			if (Camera2 != null)
			{
				KLKILLCHJHO().SetTexture("_ScreenResolution", JDMCFBKJHDD);
			}
			MJJIEHANFJA().SetFloat("Joystick1Button3", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat(" argument(s): ", BlendFX);
			ECCPAOBFDKP().SetFloat("CameraFilterPack/Blend2Camera_LinearBurn", Adjust);
			OOMFJGPAOKL().SetFloat("_TimeX", Precision);
			DKNJGHFLAIF().SetFloat("_MatrixColor", Luminosity);
			OOMFJGPAOKL().SetFloat("_TimeX", Change_Red);
			MNLKBFFKHIE().SetFloat("_TimeX", Change_Green);
			CBCNOEIALHB().SetFloat("yyyy-MM-dd HH:mm:ss", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DPLLKHHLDBB()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -14);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void DLMPALHKMON()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void ANBIJFCCANE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 414f)
			{
				HBJJOCHGOPH = 165f;
			}
			if (Camera2 != null)
			{
				OOMFJGPAOKL().SetTexture("_NoiseTex", JDMCFBKJHDD);
			}
			OKJOKHGJHGF().SetFloat("0,7,true,0", HBJJOCHGOPH);
			OCMBHMLNCEK().SetFloat("menutheme.fragout", BlendFX);
			DABHAJNHOAL().SetFloat("_ReflectionTexture4", Adjust);
			HNFFHCLNBDN().SetFloat("_Value3", Precision);
			OKJOKHGJHGF().SetFloat("_ColorRGB", Luminosity);
			IIJMIPBMMBF().SetFloat("Joystick1Button8", Change_Red);
			ABHDNGIHBKE().SetFloat("ArcsDestroyDelaySlider", Change_Green);
			HBLDMJCOAHA().SetFloat("_Value", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void LCDJFJIBADI()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	[SpecialName]
	private Material ABHDNGIHBKE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)90;
		}
		return BJFKDHHMLJH;
	}

	private void JBBCMAJIMCA()
	{
		JONGNKNLLND();
		Update();
	}

	private void HNNKIOHCDKG()
	{
		ALJEJJCIMJN();
		IAIGNDMHFFG();
	}

	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1968f)
			{
				HBJJOCHGOPH = 204f;
			}
			if (Camera2 != null)
			{
				JLHLHKPHDFO().SetTexture("settings.volume.game", JDMCFBKJHDD);
			}
			OKJOKHGJHGF().SetFloat("[Up]", HBJJOCHGOPH);
			HHIAIGCAHDA().SetFloat("Fade", BlendFX);
			EJDPNJAEAKJ().SetFloat("_MainTex2", Adjust);
			OKJOKHGJHGF().SetFloat("plainText", Precision);
			MNLKBFFKHIE().SetFloat("CameraFilterPack/Drawing_Paper", Luminosity);
			JLHLHKPHDFO().SetFloat("[SERVER] Selected map: ", Change_Red);
			MJJIEHANFJA().SetFloat("_EmissionColor", Change_Green);
			OIBHFCLJKDB().SetFloat(" not exist", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OOMFJGPAOKL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DBEMDAJDDDA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 27);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OCHCKGMIDND()
	{
		DAHFFNNIGML();
		DPIPGGDNGHN();
	}

	private void FJKJGBLPDGG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1775f)
			{
				HBJJOCHGOPH = 1308f;
			}
			if (Camera2 != null)
			{
				MNLKBFFKHIE().SetTexture("workshop.", JDMCFBKJHDD);
			}
			NBMPPNFKFLB().SetFloat("resetach21", HBJJOCHGOPH);
			IKAIDLJKLFC().SetFloat("CameraFilterPack/Colors_NewPosterize", BlendFX);
			KLKILLCHJHO().SetFloat("CameraFilterPack/Blur_Dithering2x2", Adjust);
			DABHAJNHOAL().SetFloat("?", Precision);
			FAIFBBGFAIB().SetFloat("Joined Room. isMasterClient: ", Luminosity);
			JLHLHKPHDFO().SetFloat("UnAllocateViewID() should be called after the PhotonView was destroyed (GameObject.Destroy()). ViewID: {0} still found in: {1}", Change_Red);
			HHIAIGCAHDA().SetFloat(" | ", Change_Green);
			OIBHFCLJKDB().SetFloat("/icon", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EPJJDKJEDMM()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void POENGNEMHJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 369f)
			{
				HBJJOCHGOPH = 273f;
			}
			if (Camera2 != null)
			{
				HEHKGPKLAKK().SetTexture(" ", JDMCFBKJHDD);
			}
			ADGHJOHKEHG().SetFloat("_TileMaxLoop", HBJJOCHGOPH);
			MJJIEHANFJA().SetFloat("score", BlendFX);
			IIJMIPBMMBF().SetFloat("_ScreenResolution", Adjust);
			ADGHJOHKEHG().SetFloat("Clears all text from the debug console", Precision);
			NBMPPNFKFLB().SetFloat("/", Luminosity);
			HBLDMJCOAHA().SetFloat("_NoiseAmount", Change_Red);
			HNFFHCLNBDN().SetFloat("LoadingStatusText", Change_Green);
			DKNJGHFLAIF().SetFloat("\" for viewID ", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HBLDMJCOAHA());
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
			BJFKDHHMLJH.hideFlags = (HideFlags)109;
		}
		return BJFKDHHMLJH;
	}

	private void OLDNINDEIKO()
	{
		HDMDKOKOOJC();
		JAAJECBCCFM();
	}

	private void ALJEJJCIMJN()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -52);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void MEJPBKFMAIG()
	{
		FEHCNJLLJMP();
		MBLDJEFBLFL();
	}

	private void GBGAMCPNBCC()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LIEGJOHINGC()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1069f)
			{
				HBJJOCHGOPH = 1476f;
			}
			if (Camera2 != null)
			{
				OCMBHMLNCEK().SetTexture("CameraFilterPack/TV_Horror", JDMCFBKJHDD);
			}
			KLKILLCHJHO().SetFloat("_TimeX", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("_Value2", BlendFX);
			KLKILLCHJHO().SetFloat("_Axis", Adjust);
			HNFFHCLNBDN().SetFloat("OpJoinLobby()", Precision);
			HNFFHCLNBDN().SetFloat("Yes", Luminosity);
			HHIAIGCAHDA().SetFloat("mapselector.filter.favoriteonly", Change_Red);
			IIJMIPBMMBF().SetFloat("IconFileSelector", Change_Green);
			PGPEMMBJOOG().SetFloat("_Value4", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AJBHOEBKGDO()
	{
		BMOFEBKGLFI();
		PKGJJFIFLII();
	}

	private void Update()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1990f)
			{
				HBJJOCHGOPH = 826f;
			}
			if (Camera2 != null)
			{
				DONENAMLFLF().SetTexture("_Size", JDMCFBKJHDD);
			}
			NBMPPNFKFLB().SetFloat("_TempTexture", HBJJOCHGOPH);
			EJDPNJAEAKJ().SetFloat("stretchWidth", BlendFX);
			ADGHJOHKEHG().SetFloat("s", Adjust);
			ABHDNGIHBKE().SetFloat("_Value", Precision);
			ADGHJOHKEHG().SetFloat("#", Luminosity);
			NBPKMLMCHFN.SetFloat("_Distortion", Change_Red);
			KLKILLCHJHO().SetFloat(" Mb", Change_Green);
			DBOLLHHMKKN().SetFloat("player.redarc", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIBHFCLJKDB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ODAIMOJLJOF()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FANADGBGCPI()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -19);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1520f)
			{
				HBJJOCHGOPH = 428f;
			}
			if (Camera2 != null)
			{
				IKAIDLJKLFC().SetTexture("[PlayerController] ", JDMCFBKJHDD);
			}
			HJGEHJDMCGI().SetFloat("[LevelEditorScene] Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(", HBJJOCHGOPH);
			BLMPMOIDGMG().SetFloat("_Smooth", BlendFX);
			MNLKBFFKHIE().SetFloat(" on effect ", Adjust);
			OCMBHMLNCEK().SetFloat("_AdaptationSpeed", Precision);
			MJJIEHANFJA().SetFloat("_Value4", Luminosity);
			HHIAIGCAHDA().SetFloat("/", Change_Red);
			DONENAMLFLF().SetFloat("_Value", Change_Green);
			OIBHFCLJKDB().SetFloat(".lastCheckpoint.incorrectScore", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OOMFJGPAOKL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	[SpecialName]
	private Material BLMPMOIDGMG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-87);
		}
		return BJFKDHHMLJH;
	}

	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1497f)
			{
				HBJJOCHGOPH = 648f;
			}
			if (Camera2 != null)
			{
				MJJIEHANFJA().SetTexture("880078120", JDMCFBKJHDD);
			}
			MJJIEHANFJA().SetFloat("note.1", HBJJOCHGOPH);
			DABHAJNHOAL().SetFloat("Options", BlendFX);
			IKAIDLJKLFC().SetFloat("CameraFilterPack/AAA_WaterDrop", Adjust);
			IIJMIPBMMBF().SetFloat("Create failed on GameServer. Changing back to MasterServer. Msg: ", Precision);
			DABHAJNHOAL().SetFloat("settings.showHP", Luminosity);
			HJGEHJDMCGI().SetFloat("_FixDistance", Change_Red);
			HHIAIGCAHDA().SetFloat("_NoiseTex", Change_Green);
			OIBHFCLJKDB().SetFloat("#turnoninternet", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BDMCPMKDBDG()
	{
		NLDKIPEMILC();
		Update();
	}

	private void OnDisable()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OCHMKJKBAPI()
	{
		HDMDKOKOOJC();
		JAAJECBCCFM();
	}

	[SpecialName]
	private Material OCMBHMLNCEK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.DontSave;
		}
		return BJFKDHHMLJH;
	}

	private void OLAGABIMGDA()
	{
		EFJDNLGNACH();
		DPIPGGDNGHN();
	}

	private void OPIBJIMIOKE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1316f)
			{
				HBJJOCHGOPH = 1990f;
			}
			if (Camera2 != null)
			{
				MJJIEHANFJA().SetTexture("menu.enableselectormusic", JDMCFBKJHDD);
			}
			PGPEMMBJOOG().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			DABHAJNHOAL().SetFloat(".status", BlendFX);
			OKJOKHGJHGF().SetFloat("achievements.id", Adjust);
			HHIAIGCAHDA().SetFloat("LostLive", Precision);
			DIOAAHJDMLK().SetFloat("/GetNews/pinnednewsid", Luminosity);
			DKNJGHFLAIF().SetFloat("_FarCamera", Change_Red);
			NBPKMLMCHFN.SetFloat("challenges/", Change_Green);
			MNLKBFFKHIE().SetFloat("GlassAberration", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIBHFCLJKDB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DGCGGKMNPLD()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	[SpecialName]
	private Material IIJMIPBMMBF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void DHLCNIINMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1876f)
			{
				HBJJOCHGOPH = 1543f;
			}
			if (Camera2 != null)
			{
				ADGHJOHKEHG().SetTexture("<b>", JDMCFBKJHDD);
			}
			HJGEHJDMCGI().SetFloat("_Amount", HBJJOCHGOPH);
			BLMPMOIDGMG().SetFloat("time", BlendFX);
			ABHDNGIHBKE().SetFloat("CheckpointsScoreText", Adjust);
			DKNJGHFLAIF().SetFloat("Done! You are a contributor until: ", Precision);
			MJJIEHANFJA().SetFloat("CameraFilterPack/TV_VHS", Luminosity);
			IIJMIPBMMBF().SetFloat("CameraFilterPack/Blend2Camera_HardLight", Change_Red);
			OCMBHMLNCEK().SetFloat("_Value", Change_Green);
			MJJIEHANFJA().SetFloat("\\", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, KLKILLCHJHO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void DAHFFNNIGML()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 125);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void HJDPEBAPBPN()
	{
		KCCIEMBMOBA();
		MJNPIDGNJMK();
	}

	private void JEBIBKLHFLB()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material CBCNOEIALHB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-81);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material HBLDMJCOAHA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-70);
		}
		return BJFKDHHMLJH;
	}

	private void FEHCNJLLJMP()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 77);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void GPHPJIDGEPI()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material EJDPNJAEAKJ()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-113);
		}
		return BJFKDHHMLJH;
	}

	private void DPIPGGDNGHN()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void EKCKJLFFAID()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HLHJBJGEEEA()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void FJNJIHCLODK()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void KKLMPKLKAEM()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void JAAJECBCCFM()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void LLAJPKFNDIG()
	{
		MDNHCLKNCLE();
		KKLMPKLKAEM();
	}

	private void HHODKHPIBLG()
	{
		FANADGBGCPI();
		AIJGAJIOJDJ();
	}

	[SpecialName]
	private Material DBOLLHHMKKN()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)70;
		}
		return BJFKDHHMLJH;
	}

	private void NHHCGPAMLAJ()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material KLKILLCHJHO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void OCMKCBBCEFG()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1150f)
			{
				HBJJOCHGOPH = 584f;
			}
			if (Camera2 != null)
			{
				KLKILLCHJHO().SetTexture("CameraFilterPack/TV_VHS", JDMCFBKJHDD);
			}
			DIOAAHJDMLK().SetFloat(". The group number should be at least 1.", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat(": ", BlendFX);
			HJGEHJDMCGI().SetFloat("_Fade", Adjust);
			OIBHFCLJKDB().SetFloat(".a", Precision);
			ECCPAOBFDKP().SetFloat("_Bullet_2", Luminosity);
			JLHLHKPHDFO().SetFloat("id", Change_Red);
			OIBHFCLJKDB().SetFloat("PossibleMapPointsText", Change_Green);
			OCMBHMLNCEK().SetFloat("_Value5", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OCMBHMLNCEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void EFJDNLGNACH()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -61);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void EODOHEAKJFO()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void OAKONCDEPPI()
	{
		JONGNKNLLND();
		JAAJECBCCFM();
	}

	private void LGELACBDPEH()
	{
		Start();
		EPJJDKJEDMM();
	}

	private void DIOLLANDDKJ()
	{
		ADPLHDFJFID();
		IAIGNDMHFFG();
	}

	private void CAKNMILHHNE()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LICOLMAOHKI()
	{
		JFJLGJEPEAA();
		DPIPGGDNGHN();
	}

	[SpecialName]
	private Material MNLKBFFKHIE()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-91);
		}
		return BJFKDHHMLJH;
	}

	private void AIJGAJIOJDJ()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1178f)
			{
				HBJJOCHGOPH = 1325f;
			}
			if (Camera2 != null)
			{
				IIJMIPBMMBF().SetTexture("_Value3", JDMCFBKJHDD);
			}
			OOMFJGPAOKL().SetFloat(" ", HBJJOCHGOPH);
			JLHLHKPHDFO().SetFloat("The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.", BlendFX);
			ADBKPGFMNKO().SetFloat("UI", Adjust);
			OOMFJGPAOKL().SetFloat("UpdateNewsTileStart", Precision);
			IKAIDLJKLFC().SetFloat("[MapEditor] Loading map: ", Luminosity);
			HEHKGPKLAKK().SetFloat("#done", Change_Red);
			HHIAIGCAHDA().SetFloat("_ReflectionTexture4", Change_Green);
			KLKILLCHJHO().SetFloat("_Value3", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void FPHLDMMAOEF()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void CMIBEOJGAIL()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void IENKPJEBMFM()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JNALDALAJLG()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void JFJLGJEPEAA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -123);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void AONJNAGNLIH()
	{
		NCNPAKFAFOE();
		MJNPIDGNJMK();
	}

	private void FEKECCBFGMI()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 26);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void CFMJMJOHJII()
	{
		KCCIEMBMOBA();
		AIJGAJIOJDJ();
	}

	private void GBFPAEDPOPP()
	{
		ODMPMJPALID();
		LCHBFNIPBHB();
	}

	[SpecialName]
	private Material JLHLHKPHDFO()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)81;
		}
		return BJFKDHHMLJH;
	}

	private void BMOFEBKGLFI()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -45);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IHHNCCOGLPN()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
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
			if (HBJJOCHGOPH > 1573f)
			{
				HBJJOCHGOPH = 1416f;
			}
			if (Camera2 != null)
			{
				ADBKPGFMNKO().SetTexture("player.goldabstract", JDMCFBKJHDD);
			}
			OIBHFCLJKDB().SetFloat("CameraFilterPack/Distortion_Half_Sphere", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("CameraFilterPack/FX_8bits", BlendFX);
			BLMPMOIDGMG().SetFloat("shader.future", Adjust);
			OKJOKHGJHGF().SetFloat("_Value2", Precision);
			MJJIEHANFJA().SetFloat("menu.relaxinfo", Luminosity);
			ADBKPGFMNKO().SetFloat("_DistortionSize", Change_Red);
			HHIAIGCAHDA().SetFloat("offsets", Change_Green);
			OCMBHMLNCEK().SetFloat("difficulty", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HBLDMJCOAHA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PKGJJFIFLII()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	[SpecialName]
	private Material OOMFJGPAOKL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void MBLDJEFBLFL()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void JONGNKNLLND()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -14);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void MJNPIDGNJMK()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
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
			if (Camera2 != null)
			{
				NBPKMLMCHFN.SetTexture("_MainTex2", JDMCFBKJHDD);
			}
			NBPKMLMCHFN.SetFloat("_TimeX", HBJJOCHGOPH);
			NBPKMLMCHFN.SetFloat("_Value", BlendFX);
			NBPKMLMCHFN.SetFloat("_Value2", Adjust);
			NBPKMLMCHFN.SetFloat("_Value3", Precision);
			NBPKMLMCHFN.SetFloat("_Value4", Luminosity);
			NBPKMLMCHFN.SetFloat("_Value5", Change_Red);
			NBPKMLMCHFN.SetFloat("_Value6", Change_Green);
			NBPKMLMCHFN.SetFloat("_Value7", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void ELDMKIAPNGP()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material OIBHFCLJKDB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-121);
		}
		return BJFKDHHMLJH;
	}

	private void OnEnable()
	{
		Start();
		Update();
	}

	private void NCNPAKFAFOE()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 116);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PJIFJFENPJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 924f)
			{
				HBJJOCHGOPH = 387f;
			}
			if (Camera2 != null)
			{
				HJGEHJDMCGI().SetTexture("offsets", JDMCFBKJHDD);
			}
			DABHAJNHOAL().SetFloat("_TimeX", HBJJOCHGOPH);
			DONENAMLFLF().SetFloat("_ScreenResolution", BlendFX);
			OKJOKHGJHGF().SetFloat("...", Adjust);
			HEHKGPKLAKK().SetFloat("?", Precision);
			OKJOKHGJHGF().SetFloat("_ScreenResolution", Luminosity);
			ADGHJOHKEHG().SetFloat("solo", Change_Red);
			PGPEMMBJOOG().SetFloat("InfoButton", Change_Green);
			MJJIEHANFJA().SetFloat("BitsData", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void NJHJHBOJKIC()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void MGFFNGEGFDC()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void PAHNKEGFGHB()
	{
		IBJIBLHJKMG();
		PFNFPINPCMH();
	}

	private void LCHBFNIPBHB()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void CNDACAHCCOI()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void LIFBFDKFMMH()
	{
		BMOFEBKGLFI();
		MJNPIDGNJMK();
	}

	private void MDNHCLKNCLE()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 97);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void PCHCFIOHIKK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 84);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void KLDNGKBMDAN()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void NGEGCLCPPCD()
	{
		MDNHCLKNCLE();
		JAAJECBCCFM();
	}

	[SpecialName]
	private Material HEHKGPKLAKK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material MJJIEHANFJA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-97);
		}
		return BJFKDHHMLJH;
	}

	private void NPLCENPNJBM()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -124);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material HJGEHJDMCGI()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material DONENAMLFLF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material ADGHJOHKEHG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-122);
		}
		return BJFKDHHMLJH;
	}

	private void MLEAHDDGEMJ()
	{
		KCCIEMBMOBA();
		KKLMPKLKAEM();
	}

	[SpecialName]
	private Material OKJOKHGJHGF()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild;
		}
		return BJFKDHHMLJH;
	}

	private void FDPOFMCFBMF()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material DIOAAHJDMLK()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-78);
		}
		return BJFKDHHMLJH;
	}

	private void NDBPCNICGLC()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 88);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void OHFOLGANOLC()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -89);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void HDMDKOKOOJC()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 46);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	private Material DABHAJNHOAL()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	[SpecialName]
	private Material IKAIDLJKLFC()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return BJFKDHHMLJH;
	}

	private void ADPLHDFJFID()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -1);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material ECCPAOBFDKP()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)106;
		}
		return BJFKDHHMLJH;
	}

	private void IBFHEDHJDLH()
	{
		BMOFEBKGLFI();
		DGCGGKMNPLD();
	}

	[SpecialName]
	private Material HHIAIGCAHDA()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset;
		}
		return BJFKDHHMLJH;
	}

	private void KLILJHJNICK()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 81);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void NLDKIPEMILC()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 50);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void LHGFCBDACBM()
	{
		IHLMNAGPKDA();
		LCDJFJIBADI();
	}

	private void ELHFAMLBLHM()
	{
		JONGNKNLLND();
		PKGJJFIFLII();
	}

	[SpecialName]
	private Material FAIFBBGFAIB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)122;
		}
		return BJFKDHHMLJH;
	}

	private void PFNFPINPCMH()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void LADCJEIALMH()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	[SpecialName]
	private Material NBMPPNFKFLB()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)(-123);
		}
		return BJFKDHHMLJH;
	}

	private void NMAOGOMAING()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -28);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	private Material PGPEMMBJOOG()
	{
		if (BJFKDHHMLJH == null)
		{
			BJFKDHHMLJH = new Material(SCShader);
			BJFKDHHMLJH.hideFlags = (HideFlags)120;
		}
		return BJFKDHHMLJH;
	}

	private void IAIGNDMHFFG()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void KODKKCOKEPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 1443f)
			{
				HBJJOCHGOPH = 788f;
			}
			if (Camera2 != null)
			{
				DIOAAHJDMLK().SetTexture(" ", JDMCFBKJHDD);
			}
			PGPEMMBJOOG().SetFloat("{0:0.0} ms ({1:0.} fps)", HBJJOCHGOPH);
			DKNJGHFLAIF().SetFloat("menu.relaxinfo", BlendFX);
			DONENAMLFLF().SetFloat("[PlayerBase] Got checkpoint at ", Adjust);
			DABHAJNHOAL().SetFloat("RoomDescriptionText", Precision);
			ADGHJOHKEHG().SetFloat("player.goldwatermelon", Luminosity);
			NBMPPNFKFLB().SetFloat("ChallengesButton", Change_Red);
			KLKILLCHJHO().SetFloat("_VelocityScale", Change_Green);
			EJDPNJAEAKJ().SetFloat("settings_bindings_controller_type", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HBLDMJCOAHA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void IBJIBLHJKMG()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -6);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 877f)
			{
				HBJJOCHGOPH = 597f;
			}
			if (Camera2 != null)
			{
				EJDPNJAEAKJ().SetTexture("EnableRankingToggle", JDMCFBKJHDD);
			}
			PGPEMMBJOOG().SetFloat("Fade", HBJJOCHGOPH);
			HNFFHCLNBDN().SetFloat("Player Disconnected", BlendFX);
			IKAIDLJKLFC().SetFloat("CameraFilterPack/TV_Video3D", Adjust);
			KLKILLCHJHO().SetFloat("EnableRankingToggle", Precision);
			OOMFJGPAOKL().SetFloat("_Distortion", Luminosity);
			DABHAJNHOAL().SetFloat(" (now: ", Change_Red);
			KLKILLCHJHO().SetFloat("CameraFilterPack/Glasses_On", Change_Green);
			JLHLHKPHDFO().SetFloat("VisionBlur", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CBCNOEIALHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void JAFOCEDILNK()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void HGDDCINLDAD()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KMOCDAOKGLI()
	{
		if (Camera2 != null && Camera2.targetTexture != null)
		{
			Camera2.targetTexture = null;
		}
		if ((bool)BJFKDHHMLJH)
		{
			Object.DestroyImmediate(BJFKDHHMLJH);
		}
	}

	private void KCCIEMBMOBA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 21);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void Start()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 24);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
	}

	private void FIKNBPAIFBI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (SCShader != null)
		{
			HBJJOCHGOPH += Time.deltaTime;
			if (HBJJOCHGOPH > 428f)
			{
				HBJJOCHGOPH = 701f;
			}
			if (Camera2 != null)
			{
				IIJMIPBMMBF().SetTexture("http", JDMCFBKJHDD);
			}
			BLMPMOIDGMG().SetFloat("<color=#", HBJJOCHGOPH);
			FAIFBBGFAIB().SetFloat("Sprite", BlendFX);
			BLMPMOIDGMG().SetFloat("_Value", Adjust);
			NBMPPNFKFLB().SetFloat("#challengecomplete", Precision);
			DBOLLHHMKKN().SetFloat("_LightIntensity", Luminosity);
			PGPEMMBJOOG().SetFloat("_TimeX", Change_Red);
			HEHKGPKLAKK().SetFloat("SpawnObj", Change_Green);
			HJGEHJDMCGI().SetFloat("[", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void PKHPNHBEKHA()
	{
		FPEMMGKMJGA.x = Screen.width;
		FPEMMGKMJGA.y = Screen.height;
		if (!Application.isPlaying)
		{
		}
	}

	private void ODMPMJPALID()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, -79);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}

	private void IHLMNAGPKDA()
	{
		if (Camera2 != null)
		{
			JDMCFBKJHDD = new RenderTexture((int)FPEMMGKMJGA.x, (int)FPEMMGKMJGA.y, 93);
			Camera2.targetTexture = JDMCFBKJHDD;
		}
		SCShader = Shader.Find(ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
	}
}
