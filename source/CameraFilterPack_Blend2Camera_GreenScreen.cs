// CameraFilterPack_Blend2Camera_GreenScreen
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Camera Filter Pack/Chroma Key/GreenScreen")]
[ExecuteInEditMode]
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
		DBEMDAJDDDA();
		JAAJECBCCFM();
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
				HJGEHJDMCGI().SetTexture("_TimeX", JDMCFBKJHDD);
			}
			DIOAAHJDMLK().SetFloat("CameraFilterPack/Edge_BlackLine", HBJJOCHGOPH);
			HHIAIGCAHDA().SetFloat("CameraFilterPack/Drawing_Paper3", BlendFX);
			OIBHFCLJKDB().SetFloat("JoinOrCreateRoom failed. In offline mode you still have to leave a room to enter another.", Adjust);
			OCMBHMLNCEK().SetFloat("_Luminance", Precision);
			DONENAMLFLF().SetFloat("UseFinalGlassColor", Luminosity);
			DKNJGHFLAIF().SetFloat("_ScreenResolution", Change_Red);
			KLKILLCHJHO().SetFloat("maps.", Change_Green);
			ADBKPGFMNKO().SetFloat("_Value5", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DABHAJNHOAL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void MHGPANIBBCM()
	{
		NPLCENPNJBM();
		EPJJDKJEDMM();
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
				BLMPMOIDGMG().SetTexture("CameraFilterPack/3D_Mirror", JDMCFBKJHDD);
			}
			DABHAJNHOAL().SetFloat("Joystick1Button4", HBJJOCHGOPH);
			MJJIEHANFJA().SetFloat(" has ", BlendFX);
			MJJIEHANFJA().SetFloat("CameraFilterPack/Blend2Camera_DarkerColor", Adjust);
			HBLDMJCOAHA().SetFloat("Value", Precision);
			IKAIDLJKLFC().SetFloat("_MatrixColor", Luminosity);
			HHIAIGCAHDA().SetFloat("_Value2", Change_Red);
			ADBKPGFMNKO().SetFloat("_Fade", Change_Green);
			JLHLHKPHDFO().SetFloat("Icon", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, MNLKBFFKHIE());
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
				NBPKMLMCHFN.SetTexture("Noise shaders are not set up! Disabling noise effect.", JDMCFBKJHDD);
			}
			BLMPMOIDGMG().SetFloat("Set sun audio input", HBJJOCHGOPH);
			MNLKBFFKHIE().SetFloat("player.greenarc", BlendFX);
			HNFFHCLNBDN().SetFloat("_FilteredReflections", Adjust);
			FAIFBBGFAIB().SetFloat("_Value4", Precision);
			OKJOKHGJHGF().SetFloat("_ScreenResolution", Luminosity);
			BLMPMOIDGMG().SetFloat("Joystick1Button9", Change_Red);
			OKJOKHGJHGF().SetFloat("settings.arcsdestroydelay", Change_Green);
			MJJIEHANFJA().SetFloat("_Value2", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OIBHFCLJKDB());
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
		ADPLHDFJFID();
		MBLDJEFBLFL();
	}

	private void HNNKIOHCDKG()
	{
		DAHFFNNIGML();
		JAAJECBCCFM();
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
				MJJIEHANFJA().SetTexture("settings.volume.editor", JDMCFBKJHDD);
			}
			HNFFHCLNBDN().SetFloat("Delete events", HBJJOCHGOPH);
			DONENAMLFLF().SetFloat("VisionBlur", BlendFX);
			JLHLHKPHDFO().SetFloat("_MainTex2", Adjust);
			DKNJGHFLAIF().SetFloat("cipherText", Precision);
			ADBKPGFMNKO().SetFloat("_TimeX", Luminosity);
			OIBHFCLJKDB().SetFloat("[SERVER] Selected map: ", Change_Red);
			IKAIDLJKLFC().SetFloat("_EmissionGain", Change_Green);
			ECCPAOBFDKP().SetFloat("[PlayerController] ", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JLHLHKPHDFO());
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
		ALJEJJCIMJN();
		EPJJDKJEDMM();
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
				OOMFJGPAOKL().SetTexture("/", JDMCFBKJHDD);
			}
			OOMFJGPAOKL().SetFloat("Reset 21 achievement progress", HBJJOCHGOPH);
			HHIAIGCAHDA().SetFloat("_TimeX", BlendFX);
			IKAIDLJKLFC().SetFloat("CameraFilterPack/Blur_Dithering2x2", Adjust);
			PGPEMMBJOOG().SetFloat("SubmitUserVote:", Precision);
			DABHAJNHOAL().SetFloat("AskForPickupItemSpawnTimes", Luminosity);
			IKAIDLJKLFC().SetFloat(". Client should be in a room. Current connectionStateDetailed: ", Change_Red);
			OKJOKHGJHGF().SetFloat("</color>", Change_Green);
			HBLDMJCOAHA().SetFloat("LoadMapCanvas", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HBLDMJCOAHA());
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
				EJDPNJAEAKJ().SetTexture("Skipping region because it's not in PhotonServerSettings.EnabledRegions: ", JDMCFBKJHDD);
			}
			DBOLLHHMKKN().SetFloat("_MaxBlurRadius", HBJJOCHGOPH);
			BLMPMOIDGMG().SetFloat("accuracy", BlendFX);
			OOMFJGPAOKL().SetFloat("CameraFilterPack/FX_ZebraColor", Adjust);
			OCMBHMLNCEK().SetFloat("Prints list of all previous commands", Precision);
			IKAIDLJKLFC().SetFloat("/icon", Luminosity);
			DBOLLHHMKKN().SetFloat("_NoiseTex", Change_Red);
			FAIFBBGFAIB().SetFloat("LoadingStatusText", Change_Green);
			HBLDMJCOAHA().SetFloat(" Owner called.", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, CBCNOEIALHB());
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
		BMOFEBKGLFI();
		IAIGNDMHFFG();
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
		IBJIBLHJKMG();
		DPIPGGDNGHN();
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
				ADBKPGFMNKO().SetTexture("_TimeX", JDMCFBKJHDD);
			}
			EJDPNJAEAKJ().SetFloat("_TimeX", HBJJOCHGOPH);
			ECCPAOBFDKP().SetFloat("_Value3", BlendFX);
			DBOLLHHMKKN().SetFloat("_Axis", Adjust);
			DKNJGHFLAIF().SetFloat("OpCreateRoom()", Precision);
			ECCPAOBFDKP().SetFloat("}", Luminosity);
			OIBHFCLJKDB().SetFloat("mapselector.filter.subscribedonly", Change_Red);
			DONENAMLFLF().SetFloat("MusicFileSelector", Change_Green);
			HEHKGPKLAKK().SetFloat("_ScreenResolution", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DABHAJNHOAL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void AJBHOEBKGDO()
	{
		OHFOLGANOLC();
		FJNJIHCLODK();
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
				BLMPMOIDGMG().SetTexture("_ScreenResolution", JDMCFBKJHDD);
			}
			DABHAJNHOAL().SetFloat("_AdditiveReflection", HBJJOCHGOPH);
			DBOLLHHMKKN().SetFloat("offsets", BlendFX);
			IKAIDLJKLFC().SetFloat("{0:0} minute{1}, ", Adjust);
			HJGEHJDMCGI().SetFloat("_Value2", Precision);
			NBPKMLMCHFN.SetFloat("english", Luminosity);
			DKNJGHFLAIF().SetFloat("_Distortion", Change_Red);
			IIJMIPBMMBF().SetFloat(" Gb", Change_Green);
			MNLKBFFKHIE().SetFloat("player.redarc", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OOMFJGPAOKL());
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
				PGPEMMBJOOG().SetTexture(": ", JDMCFBKJHDD);
			}
			MNLKBFFKHIE().SetFloat("ResourceFileSelector", HBJJOCHGOPH);
			MNLKBFFKHIE().SetFloat("_ScreenResolution", BlendFX);
			ECCPAOBFDKP().SetFloat("Missing shader in ", Adjust);
			ABHDNGIHBKE().SetFloat("_AdaptationMin", Precision);
			NBPKMLMCHFN.SetFloat("_ScreenResolution", Luminosity);
			OIBHFCLJKDB().SetFloat("winter2020_official", Change_Red);
			KLKILLCHJHO().SetFloat("_Value", Change_Green);
			DKNJGHFLAIF().SetFloat(".lastCheckpoint.powerupsScore", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DIOAAHJDMLK());
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
				DBOLLHHMKKN().SetTexture("1278033234", JDMCFBKJHDD);
			}
			OCMBHMLNCEK().SetFloat("note.5", HBJJOCHGOPH);
			ABHDNGIHBKE().SetFloat("Left Stick Click", BlendFX);
			EJDPNJAEAKJ().SetFloat("CameraFilterPack/AAA_WaterDrop", Adjust);
			DABHAJNHOAL().SetFloat("Join failed on GameServer. Changing back to MasterServer. Msg: ", Precision);
			DIOAAHJDMLK().SetFloat("settings.volume.menu", Luminosity);
			JLHLHKPHDFO().SetFloat("_FixDistance", Change_Red);
			KLKILLCHJHO().SetFloat("_NeighbourMaxTex", Change_Green);
			DABHAJNHOAL().SetFloat("SingleplayerButton", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	private void BDMCPMKDBDG()
	{
		ODMPMJPALID();
		AIJGAJIOJDJ();
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
		KCCIEMBMOBA();
		FJNJIHCLODK();
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
		DBEMDAJDDDA();
		Update();
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
				NBMPPNFKFLB().SetTexture("settings.enablehitsoundsinrelax", JDMCFBKJHDD);
			}
			BLMPMOIDGMG().SetFloat("_ScreenResolution", HBJJOCHGOPH);
			EJDPNJAEAKJ().SetFloat("challenges", BlendFX);
			OIBHFCLJKDB().SetFloat("achievements.id", Adjust);
			IIJMIPBMMBF().SetFloat("_DiffuseColor", Precision);
			DONENAMLFLF().SetFloat("/GetNews/pinnednewsid", Luminosity);
			HEHKGPKLAKK().SetFloat("_FarCamera", Change_Red);
			NBPKMLMCHFN.SetFloat("skin.", Change_Green);
			HJGEHJDMCGI().SetFloat("GlassesColor", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
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
				NBMPPNFKFLB().SetTexture("<b>", JDMCFBKJHDD);
			}
			FAIFBBGFAIB().SetFloat("_MainTex2", HBJJOCHGOPH);
			OIBHFCLJKDB().SetFloat("[CraftingPanel] Init", BlendFX);
			DKNJGHFLAIF().SetFloat("CheckpointsScoreText", Adjust);
			CBCNOEIALHB().SetFloat("#tryagain", Precision);
			NBPKMLMCHFN.SetFloat("_TimeX", Luminosity);
			ADGHJOHKEHG().SetFloat("CameraFilterPack/Blend2Camera_HardLight", Change_Red);
			DKNJGHFLAIF().SetFloat("_Value2", Change_Green);
			PGPEMMBJOOG().SetFloat("\\", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, DBOLLHHMKKN());
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
		DAHFFNNIGML();
		MJNPIDGNJMK();
	}

	private void HHODKHPIBLG()
	{
		IHLMNAGPKDA();
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
				ECCPAOBFDKP().SetTexture("_Value", JDMCFBKJHDD);
			}
			HNFFHCLNBDN().SetFloat("PhotonView with ID {0} wasn't properly unregistered! Please report this case to developer@photonengine.com", HBJJOCHGOPH);
			HJGEHJDMCGI().SetFloat("[PlayerController] ", BlendFX);
			MNLKBFFKHIE().SetFloat("_SweaterSize", Adjust);
			OCMBHMLNCEK().SetFloat(".a", Precision);
			DIOAAHJDMLK().SetFloat("_Bullet_3", Luminosity);
			OCMBHMLNCEK().SetFloat("id", Change_Red);
			OOMFJGPAOKL().SetFloat("PossibleMapPointsText", Change_Green);
			IIJMIPBMMBF().SetFloat("_MainTex2", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OOMFJGPAOKL());
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
		JFJLGJEPEAA();
		PKHPNHBEKHA();
	}

	private void LGELACBDPEH()
	{
		Start();
		EPJJDKJEDMM();
	}

	private void DIOLLANDDKJ()
	{
		PCHCFIOHIKK();
		AIJGAJIOJDJ();
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
		NDBPCNICGLC();
		LCDJFJIBADI();
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
				ABHDNGIHBKE().SetTexture("_Value4", JDMCFBKJHDD);
			}
			ECCPAOBFDKP().SetFloat(" ", HBJJOCHGOPH);
			OOMFJGPAOKL().SetFloat("Currently, the limit of users is reached for this title. Try again later. Disconnecting", BlendFX);
			EJDPNJAEAKJ().SetFloat("custom", Adjust);
			FAIFBBGFAIB().SetFloat("UpdateNewsTileStart", Precision);
			DONENAMLFLF().SetFloat("Init", Luminosity);
			ECCPAOBFDKP().SetFloat("/", Change_Red);
			NBPKMLMCHFN.SetFloat("_FilteredReflections", Change_Green);
			CBCNOEIALHB().SetFloat("_Value3", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
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
		ADPLHDFJFID();
		PKHPNHBEKHA();
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
		DBEMDAJDDDA();
		MJNPIDGNJMK();
	}

	private void GBFPAEDPOPP()
	{
		FEHCNJLLJMP();
		LCDJFJIBADI();
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
				HEHKGPKLAKK().SetTexture("player.goldabstract", JDMCFBKJHDD);
			}
			DKNJGHFLAIF().SetFloat("CameraFilterPack/Distortion_Half_Sphere", HBJJOCHGOPH);
			BLMPMOIDGMG().SetFloat("_TimeX", BlendFX);
			HNFFHCLNBDN().SetFloat("shader.future", Adjust);
			FAIFBBGFAIB().SetFloat("_Value3", Precision);
			HHIAIGCAHDA().SetFloat("menu.relaxinfo", Luminosity);
			HHIAIGCAHDA().SetFloat("_DistortionSize", Change_Red);
			ADBKPGFMNKO().SetFloat("_Blur", Change_Green);
			HEHKGPKLAKK().SetFloat("maxScore", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, OCMBHMLNCEK());
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
				ADGHJOHKEHG().SetTexture("_MainTexBlurred", JDMCFBKJHDD);
			}
			OOMFJGPAOKL().SetFloat("_Distortion", HBJJOCHGOPH);
			HJGEHJDMCGI().SetFloat("_Amount", BlendFX);
			IIJMIPBMMBF().SetFloat("...", Adjust);
			ADBKPGFMNKO().SetFloat("?", Precision);
			OOMFJGPAOKL().SetFloat("CameraFilterPack/FX_Screens", Luminosity);
			HEHKGPKLAKK().SetFloat("original.tutorial", Change_Red);
			DONENAMLFLF().SetFloat("InfoButton", Change_Green);
			BLMPMOIDGMG().SetFloat("BitsData", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, JLHLHKPHDFO());
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
		JONGNKNLLND();
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
		DPIPGGDNGHN();
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
		BMOFEBKGLFI();
		PFNFPINPCMH();
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
		JFJLGJEPEAA();
		PKGJJFIFLII();
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
		KCCIEMBMOBA();
		PKGJJFIFLII();
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
		DAHFFNNIGML();
		JAAJECBCCFM();
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
				HHIAIGCAHDA().SetTexture("MainButton", JDMCFBKJHDD);
			}
			ADBKPGFMNKO().SetFloat("settings.fps", HBJJOCHGOPH);
			IIJMIPBMMBF().SetFloat("menu.selectedplaymode", BlendFX);
			EJDPNJAEAKJ().SetFloat("[PlayerBase] ShowImage \"", Adjust);
			JLHLHKPHDFO().SetFloat("RoomDescriptionText", Precision);
			OCMBHMLNCEK().SetFloat("player.goldwatermelon", Luminosity);
			OOMFJGPAOKL().SetFloat("ChallengesButton", Change_Red);
			NBMPPNFKFLB().SetFloat("_NoiseTex", Change_Green);
			NBPKMLMCHFN.SetFloat("settings_bindings_", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, HEHKGPKLAKK());
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
				HNFFHCLNBDN().SetTexture("EnableRankedNotificationsToggle", JDMCFBKJHDD);
			}
			ADGHJOHKEHG().SetFloat("_Distortion", HBJJOCHGOPH);
			IKAIDLJKLFC().SetFloat("Player Disconnected", BlendFX);
			HBLDMJCOAHA().SetFloat("_ScreenResolution", Adjust);
			EJDPNJAEAKJ().SetFloat("EnableRankingToggle", Precision);
			MNLKBFFKHIE().SetFloat("_Radius", Luminosity);
			HNFFHCLNBDN().SetFloat(" now: ", Change_Red);
			OKJOKHGJHGF().SetFloat("_TimeX", Change_Green);
			ADBKPGFMNKO().SetFloat("GlassDistortion", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, NBMPPNFKFLB());
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
				DBOLLHHMKKN().SetTexture("skin.", JDMCFBKJHDD);
			}
			IIJMIPBMMBF().SetFloat(">", HBJJOCHGOPH);
			HNFFHCLNBDN().SetFloat("#ok", BlendFX);
			ABHDNGIHBKE().SetFloat("_Value", Adjust);
			OOMFJGPAOKL().SetFloat("<command>", Precision);
			PGPEMMBJOOG().SetFloat("_LightIntensity", Luminosity);
			HEHKGPKLAKK().SetFloat("UseFinalGlassColor", Change_Red);
			DONENAMLFLF().SetFloat("SpawnObj", Change_Green);
			DIOAAHJDMLK().SetFloat("[", Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, FAIFBBGFAIB());
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
