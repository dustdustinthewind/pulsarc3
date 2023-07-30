// ReplayScene
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class ReplayScene : Scene
{
	public GameObject selector;

	public GameObject text;

	[CompilerGenerated]
	private static UnityAction LNIJKGECNME;

	private static void POKNFJCGMIA()
	{
	}

	public override void CIPKEPDELJB()
	{
		base.Start();
		EJBGCLOEOPN(true);
	}

	private static void BBBMMAAAMOI()
	{
	}

	public void PLDJGGDGBPN(string BNJFKKGOACF)
	{
		Debug.Log("Prints list of commands" + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.GFBOAHOPOLL(BNJFKKGOACF, Object.FindObjectOfType<FileSelector>().result, false, true);
		string text = Object.FindObjectOfType<FileSelector>().result + "_RotationMatrix";
		StartCoroutine(Helpers.SaveFile(text, GameManager.IBOCADBLICL((string)ResourcesManager.BBDAJIDMBNJ(BNJFKKGOACF))));
		Singleton<MessageBoxPanel>.Instance.GJAEFOENJGI("PowerUp" + text, "[DiscordController] Responding yes to Ask to Join request", MKLKPECNKJP, true, true, 362f);
	}

	public override void MMMDPANNAIO()
	{
		base.KOJKBFDNGDK();
		JMJMGFGJKEF(true);
	}

	public void APOEGIHAMNE(string BNJFKKGOACF)
	{
		Debug.Log("_Value2" + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.BJBCFBNIAMF(BNJFKKGOACF, Object.FindObjectOfType<FileSelector>().result, false, true);
		string text = Object.FindObjectOfType<FileSelector>().result + "player.greenlollipop";
		StartCoroutine(Helpers.SaveFile(text, GameManager.PNOAGJLDFJL((string)ResourcesManager.MJGKEEAOAAD(BNJFKKGOACF))));
		Singleton<MessageBoxPanel>.Instance.AMBEIAGHBEF("CONTRAST" + text, "Run a command for data system", EJKFMJPONCO, true, true, 191f);
	}

	public override void HDMDKOKOOJC()
	{
		base.ODMPMJPALID();
		BAKILCLOCBF(true);
	}

	public override void ILCFPCIPENO()
	{
		base.LBAJLLFMMMP();
		KAGHABABGCB(false);
	}

	public override void KDMKDEKCELE()
	{
		base.KDMKDEKCELE();
		DPMCFFEDPEH(false);
	}

	public override void HMPGIFBJFIK()
	{
		base.KNBJBNDGCIJ();
		EIKPLOCGCIK(true);
	}

	private static void EJKFMJPONCO()
	{
	}

	private static void OGFFDNNEGEI()
	{
	}

	public override void FANADGBGCPI()
	{
		base.ALNNIDLFILB();
		BAKILCLOCBF(false);
	}

	private static void NFMNMBDBNCM()
	{
	}

	private static void CLPECMJONEG()
	{
	}

	public override void KOJKBFDNGDK()
	{
		base.Start();
		DPGCJACMEKB(false);
	}

	public override void LBAJLLFMMMP()
	{
		base.FIKFJDFELIP();
		GLBKNLOICDL(false);
	}

	[CompilerGenerated]
	private static void INAJPJFLILM()
	{
	}

	private static void GNBMKNLHEFD()
	{
	}

	public override void MMOKKAPFGAK()
	{
		base.IKDNLHLBHID();
		OCDKCHGHMBG(false);
	}

	private static void LKENGJFAEDI()
	{
	}

	public void CFFELFFMCOI(string BNJFKKGOACF)
	{
		Debug.Log("sounds/no_hit" + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.NKMCMMBEHGE(BNJFKKGOACF, Object.FindObjectOfType<FileSelector>().result, true, true);
		string text = Object.FindObjectOfType<FileSelector>().result + "_Distortion";
		StartCoroutine(Helpers.SaveFile(text, GameManager.PNOAGJLDFJL((string)ResourcesManager.BBDAJIDMBNJ(BNJFKKGOACF))));
		Singleton<MessageBoxPanel>.Instance.GJAEFOENJGI("TotalHitsScoreText" + text, "Warning: Unhandled event ", BIANMHLLHEB, false, false, 1827f);
	}

	private static void HOIBMGMOBNH()
	{
	}

	public override void GPNAOAKCMHC()
	{
		base.GLEJGFLCLPJ();
		LGJLNDGBEOP(true);
	}

	public void PFIAKPMKJMB(string BNJFKKGOACF)
	{
		Debug.Log(":</b> " + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.DBBMKJAEEAE(BNJFKKGOACF, Object.FindObjectOfType<FileSelector>().result, false, true);
		string text = Object.FindObjectOfType<FileSelector>().result + "Players NetIDs:";
		StartCoroutine(Helpers.SaveFile(text, GameManager.Decrypt((string)ResourcesManager.EJAFPGNGGOC(BNJFKKGOACF))));
		Singleton<MessageBoxPanel>.Instance.FKPCEFPFPJD("X2" + text, "_Value1", CMJAHDMKEPE, false, false, 264f);
	}

	public void PPLGNHGJBKH(string BNJFKKGOACF)
	{
		Debug.Log("_ChromaticAberration" + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.DBBMKJAEEAE(BNJFKKGOACF, Object.FindObjectOfType<FileSelector>().result, true);
		string text = Object.FindObjectOfType<FileSelector>().result + "ready";
		StartCoroutine(Helpers.SaveFile(text, GameManager.CHADLKENPOO((string)ResourcesManager.OJOLHAGIGOL(BNJFKKGOACF))));
		Singleton<MessageBoxPanel>.Instance.MEGHOGOANGJ("Currently, the limit of users is reached for this title. Try again later. Disconnecting" + text, "BadgeText", OGFFDNNEGEI, false, false, 97f);
	}

	public override void DBLILJGKGHJ()
	{
		base.EDPDMBFLHLP();
		JDONOMPKEED(true);
	}

	private static void DGFFFFHNHDB()
	{
	}

	public void HJGNOPFNGCG(string BNJFKKGOACF)
	{
		Debug.Log("CameraFilterPack/Blur_Bloom" + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.NKMCMMBEHGE(BNJFKKGOACF, Object.FindObjectOfType<FileSelector>().result);
		string text = Object.FindObjectOfType<FileSelector>().result + "_Value11";
		StartCoroutine(Helpers.SaveFile(text, GameManager.NOPLBGANHHC((string)ResourcesManager.LHIHFLJHGKJ(BNJFKKGOACF))));
		Singleton<MessageBoxPanel>.Instance.AMBEIAGHBEF("Can't set visible when not in that room." + text, "_ScreenResolution", DGFFFFHNHDB, false, true, 349f);
	}

	public void HFKLCLCBHBO(string BNJFKKGOACF)
	{
		Debug.Log("z" + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.OFAELGIDIDE(BNJFKKGOACF, Object.FindObjectOfType<FileSelector>().result, true, true);
		string text = Object.FindObjectOfType<FileSelector>().result + "#lives";
		StartCoroutine(Helpers.SaveFile(text, GameManager.IBOCADBLICL((string)ResourcesManager.EJAFPGNGGOC(BNJFKKGOACF))));
		Singleton<MessageBoxPanel>.Instance.CIOKBENBFPJ("_RangeScale" + text, "#savemapchanges?", OGFFDNNEGEI, false, true, 1670f);
	}

	public override void PKLOBJHKFEO()
	{
		base.NNFMIAFHMJM();
		EIKPLOCGCIK(true);
	}

	private static void HILKHCPHOPJ()
	{
	}

	public void MPICBPFNLKF(string BNJFKKGOACF)
	{
		Debug.Log("CameraFilterPack_TV_Noise" + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.BJBCFBNIAMF(BNJFKKGOACF, Object.FindObjectOfType<FileSelector>().result);
		string text = Object.FindObjectOfType<FileSelector>().result + "Object ID. Case-Sensitive";
		StartCoroutine(Helpers.SaveFile(text, GameManager.CHADLKENPOO((string)ResourcesManager.OJOLHAGIGOL(BNJFKKGOACF)), true));
		Singleton<MessageBoxPanel>.Instance.DEAKLIGJIFG("0.00" + text, "_Value3", BPJCPHJGICK, true, true, 1682f);
	}

	public void NNHNCKKKHKO(string BNJFKKGOACF)
	{
		Debug.Log("EditMenu" + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.NKMCMMBEHGE(BNJFKKGOACF, Object.FindObjectOfType<FileSelector>().result, false, true);
		string text = Object.FindObjectOfType<FileSelector>().result + "Items";
		StartCoroutine(Helpers.SaveFile(text, GameManager.IBOCADBLICL((string)ResourcesManager.MJGKEEAOAAD(BNJFKKGOACF))));
		Singleton<MessageBoxPanel>.Instance.NCIKLIFEAMB("," + text, "[PhotonMessageInfo: Sender='{1}' Senttime={0}]", COHOKAEMADK, true, false, 1973f);
	}

	private static void FGCBEGALJMD()
	{
	}

	public override void CHOPDIGHJNH()
	{
		base.BGDPIHMAACO();
		LGCNGKPADGA(true);
	}

	public override void KCCIEMBMOBA()
	{
		base.BGDPIHMAACO();
		MNKKKMIIBFB(true);
	}

	private static void PCIHBBFOHKO()
	{
	}

	private static void BPJCPHJGICK()
	{
	}

	public override void JKFDDNMPOJH()
	{
		base.OKLAJINHPAN();
		GLBKNLOICDL(false);
	}

	public void CMNEEBEFBMC(string BNJFKKGOACF)
	{
		Debug.Log("Editor/" + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.NKMCMMBEHGE(BNJFKKGOACF, Object.FindObjectOfType<FileSelector>().result, true);
		string text = Object.FindObjectOfType<FileSelector>().result + "on master";
		StartCoroutine(Helpers.SaveFile(text, GameManager.PJHEGJPGKPP((string)ResourcesManager.MACOLLJOENJ(BNJFKKGOACF)), true));
		Singleton<MessageBoxPanel>.Instance.JJEOAFDDLHK("element" + text, "ShadersToggle", BBHLIOCPEPE, false, true, 1748f);
	}

	public void CLPJKONJENF(string BNJFKKGOACF)
	{
		Debug.Log("_TimeX" + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.ODGICECFMAG(BNJFKKGOACF, Object.FindObjectOfType<FileSelector>().result, true);
		string text = Object.FindObjectOfType<FileSelector>().result + "[EMPTY]";
		StartCoroutine(Helpers.SaveFile(text, GameManager.PNOAGJLDFJL((string)ResourcesManager.OJOLHAGIGOL(BNJFKKGOACF))));
		Singleton<MessageBoxPanel>.Instance.GNKJLJNJJFP("Skipping region because it's not in PhotonServerSettings.EnabledRegions: " + text, "_TimeX", GNBMKNLHEFD, false, false, 1425f);
	}

	public override void FLKEJJEGCFA()
	{
		base.FEHCNJLLJMP();
		EJBGCLOEOPN(true);
	}

	public override void DLBODOFAJGM()
	{
		base.KNBJBNDGCIJ();
		CFBPIOCEFHL(true);
	}

	private static void EDFLOIENIJN()
	{
	}

	public override void DBEMDAJDDDA()
	{
		base.IKDNLHLBHID();
		MMLKMEBMOFK(false);
	}

	public void KDLMINCLJLK(string BNJFKKGOACF)
	{
		Debug.Log("settings_bindings_controller_type" + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.DBBMKJAEEAE(BNJFKKGOACF, Object.FindObjectOfType<FileSelector>().result, true);
		string text = Object.FindObjectOfType<FileSelector>().result + "_Value";
		StartCoroutine(Helpers.SaveFile(text, GameManager.PJHEGJPGKPP((string)ResourcesManager.LHIHFLJHGKJ(BNJFKKGOACF))));
		Singleton<MessageBoxPanel>.Instance.BOKKOAKIDMK("_ScreenResolution" + text, "score", CPIJPEIOIJO, false, false, 1218f);
	}

	private static void IJKGHACJMPL()
	{
	}

	public void GJKPMMPFLEJ(string BNJFKKGOACF)
	{
		Debug.Log("SetEnvSpriteImage" + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.NKMCMMBEHGE(BNJFKKGOACF, Object.FindObjectOfType<FileSelector>().result, true);
		string text = Object.FindObjectOfType<FileSelector>().result + "_Value3";
		StartCoroutine(Helpers.SaveFile(text, GameManager.PJHEGJPGKPP((string)ResourcesManager.BKKJBPILALK(BNJFKKGOACF)), true));
		Singleton<MessageBoxPanel>.Instance.BIGHIEJMHHA("#random #epic #item" + text, "#{0:X2}{1:X2}{2:X2}", DEMPBNKPLLD, false, true, 1690f);
	}

	public void OpenReplayFile(string BNJFKKGOACF)
	{
		Debug.Log("[ReplayScene] Loading replay: " + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.LoadText(BNJFKKGOACF, Object.FindObjectOfType<FileSelector>().result, true);
		string text = Object.FindObjectOfType<FileSelector>().result + "_dec.json";
		StartCoroutine(Helpers.SaveFile(text, GameManager.Decrypt((string)ResourcesManager.GetLoadedResource(BNJFKKGOACF)), true));
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("Saved as: " + text, "ok", delegate
		{
		});
	}

	public void ABMLMOAMLNJ(string BNJFKKGOACF)
	{
		Debug.Log("_Axis" + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.LoadText(BNJFKKGOACF, Object.FindObjectOfType<FileSelector>().result, true);
		string text = Object.FindObjectOfType<FileSelector>().result + "_SizeX";
		StartCoroutine(Helpers.SaveFile(text, GameManager.PJHEGJPGKPP((string)ResourcesManager.EJAFPGNGGOC(BNJFKKGOACF))));
		Singleton<MessageBoxPanel>.Instance.DPFKHGBCDFH("Item " + text, "/icon", DGFFFFHNHDB, true, false, 1688f);
	}

	public override void Start()
	{
		base.Start();
		ShowCursor(true);
	}

	public override void ICILLMAKLMI()
	{
		base.HLIAEEMGBHN();
		EJBGCLOEOPN(true);
	}

	private static void CPIJPEIOIJO()
	{
	}

	private static void DCJNBBGHHKD()
	{
	}

	private static void NICPJCBFDBI()
	{
	}

	public void OIFKDHHODOJ(string BNJFKKGOACF)
	{
		Debug.Log("_Value2" + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.DBBMKJAEEAE(BNJFKKGOACF, Object.FindObjectOfType<FileSelector>().result, true, true);
		string text = Object.FindObjectOfType<FileSelector>().result + "CameraFilterPack/Distortion_FishEye";
		StartCoroutine(Helpers.SaveFile(text, GameManager.PJHEGJPGKPP((string)ResourcesManager.POBCMIMPNBF(BNJFKKGOACF))));
		Singleton<MessageBoxPanel>.Instance.FKPCEFPFPJD("_Value2" + text, "_Offsets", delegate
		{
		}, true, false, 874f);
	}

	public override void FMFNILJIEIA()
	{
		base.MKIMDFLBFOM();
		GDJMNGJBLHJ(true);
	}

	public void DPKDPJKKBBL(string BNJFKKGOACF)
	{
		Debug.Log("Skipping packet for " + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.ODGICECFMAG(BNJFKKGOACF, Object.FindObjectOfType<FileSelector>().result);
		string text = Object.FindObjectOfType<FileSelector>().result + "MenuScene";
		StartCoroutine(Helpers.SaveFile(text, GameManager.NOPLBGANHHC((string)ResourcesManager.GetLoadedResource(BNJFKKGOACF)), true));
		Singleton<MessageBoxPanel>.Instance.PGJLMNEJGML("workshop." + text, "Down", DEMPBNKPLLD, false, false, 1168f);
	}

	public void HIAAHFLHGNP(string BNJFKKGOACF)
	{
		Debug.Log("View ({3}){0} on {1} {2}" + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.GFBOAHOPOLL(BNJFKKGOACF, Object.FindObjectOfType<FileSelector>().result, true, true);
		string text = Object.FindObjectOfType<FileSelector>().result + "_MainTex2";
		StartCoroutine(Helpers.SaveFile(text, GameManager.NOPLBGANHHC((string)ResourcesManager.OJOLHAGIGOL(BNJFKKGOACF)), true));
		Singleton<MessageBoxPanel>.Instance.GNKJLJNJJFP(".lastCheckpoint.playerdistance" + text, ". Check if the server is available.", HOIBMGMOBNH, false, false, 652f);
	}

	public void LBDMDFCLFAM(string BNJFKKGOACF)
	{
		Debug.Log("GlassDistortion" + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.BJBCFBNIAMF(BNJFKKGOACF, Object.FindObjectOfType<FileSelector>().result);
		string text = Object.FindObjectOfType<FileSelector>().result + "Hidden/DepthOfField/MedianFilter";
		StartCoroutine(Helpers.SaveFile(text, GameManager.Decrypt((string)ResourcesManager.LHIHFLJHGKJ(BNJFKKGOACF))));
		Singleton<MessageBoxPanel>.Instance.BOKKOAKIDMK("Source: " + text, "/icon", CMJAHDMKEPE, false, false, 1449f);
	}

	public override void FNCDAPDOBBI()
	{
		base.ALNNIDLFILB();
		CFBPIOCEFHL(true);
	}

	public void OAIOJJELPEL(string BNJFKKGOACF)
	{
		Debug.Log("GlassDistortion" + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.GFBOAHOPOLL(BNJFKKGOACF, Object.FindObjectOfType<FileSelector>().result);
		string text = Object.FindObjectOfType<FileSelector>().result + "_ScreenResolution";
		StartCoroutine(Helpers.SaveFile(text, GameManager.CHADLKENPOO((string)ResourcesManager.BBDAJIDMBNJ(BNJFKKGOACF)), true));
		Singleton<MessageBoxPanel>.Instance.AMBEIAGHBEF("MaxLivesSlider" + text, "_TimeX", EJKFMJPONCO, false, false, 60f);
	}

	public override void FEHCNJLLJMP()
	{
		base.KNBJBNDGCIJ();
		LGJLNDGBEOP(false);
	}

	public override void EFJDNLGNACH()
	{
		base.ALNNIDLFILB();
		EIKPLOCGCIK(true);
	}

	public override void DIPDEHOOBPG()
	{
		base.EDPDMBFLHLP();
		OCDKCHGHMBG(true);
	}

	private static void ENFKDKFCNNI()
	{
	}

	public void LBGFBNKOOKJ(string BNJFKKGOACF)
	{
		Debug.Log("_FarCamera" + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.LoadText(BNJFKKGOACF, Object.FindObjectOfType<FileSelector>().result, true, true);
		string text = Object.FindObjectOfType<FileSelector>().result + "_FadeFX";
		StartCoroutine(Helpers.SaveFile(text, GameManager.PNOAGJLDFJL((string)ResourcesManager.MJGKEEAOAAD(BNJFKKGOACF))));
		Singleton<MessageBoxPanel>.Instance.DKGAEEALMLE("The observed monobehaviour (" + text, "_AreaTex", DGFFFFHNHDB, false, true, 1527f);
	}

	public void GJEONKJFCJA(string BNJFKKGOACF)
	{
		Debug.Log("OpSettings()" + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.LoadText(BNJFKKGOACF, Object.FindObjectOfType<FileSelector>().result, true, true);
		string text = Object.FindObjectOfType<FileSelector>().result + "_Gain";
		StartCoroutine(Helpers.SaveFile(text, GameManager.CHADLKENPOO((string)ResourcesManager.MJGKEEAOAAD(BNJFKKGOACF)), true));
		Singleton<MessageBoxPanel>.Instance.MEGHOGOANGJ("System.Int32" + text, "CameraFilterPack/FX_DarkMatter", POKNFJCGMIA, false, false, 1385f);
	}

	private static void BIANMHLLHEB()
	{
	}

	private static void CMJAHDMKEPE()
	{
	}

	public void HPLAMMJKIDH(string BNJFKKGOACF)
	{
		Debug.Log("\n" + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.FHNPMJHPOAO(BNJFKKGOACF, Object.FindObjectOfType<FileSelector>().result, true, true);
		string text = Object.FindObjectOfType<FileSelector>().result + "_ScreenResolution";
		StartCoroutine(Helpers.SaveFile(text, GameManager.PNOAGJLDFJL((string)ResourcesManager.MACOLLJOENJ(BNJFKKGOACF)), true));
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("_Blue_B" + text, " cannot be used as a 3D LUT.", NFMNMBDBNCM, true, false, 237f);
	}

	private static void BOKGJFLJLMN()
	{
	}

	public void PJJGFFKDCAK(string BNJFKKGOACF)
	{
		Debug.Log("entering" + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.FHNPMJHPOAO(BNJFKKGOACF, Object.FindObjectOfType<FileSelector>().result, false, true);
		string text = Object.FindObjectOfType<FileSelector>().result + "[PlayerController] ";
		StartCoroutine(Helpers.SaveFile(text, GameManager.NOPLBGANHHC((string)ResourcesManager.MJGKEEAOAAD(BNJFKKGOACF))));
		Singleton<MessageBoxPanel>.Instance.JPHEAJOLIGK("Zoom speed. Base 1.5" + text, "\\n", BPJCPHJGICK, false, false, 1158f);
	}

	private static void COHOKAEMADK()
	{
	}

	private static void BBHLIOCPEPE()
	{
	}

	public void IAOAPHMPCGO(string BNJFKKGOACF)
	{
		Debug.Log("ClearEnvironment" + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.LoadText(BNJFKKGOACF, Object.FindObjectOfType<FileSelector>().result, false, true);
		string text = Object.FindObjectOfType<FileSelector>().result + "mapselector.orderby";
		StartCoroutine(Helpers.SaveFile(text, GameManager.IBOCADBLICL((string)ResourcesManager.GetLoadedResource(BNJFKKGOACF))));
		Singleton<MessageBoxPanel>.Instance.CNGOPHCPHCH("Malformed RPC; this should never occur. Content: " + text, "Failed!", NICPJCBFDBI, false, false, 156f);
	}

	private static void FODCPPPNJCJ()
	{
	}

	public override void DKOPKPBLDHH()
	{
		base.ODMPMJPALID();
		GLBKNLOICDL(true);
	}

	public override void DNNFHBOOPIN()
	{
		base.FIKFJDFELIP();
		LGJLNDGBEOP(true);
	}

	public override void ANCKKLFPGDI()
	{
		base.NNFMIAFHMJM();
		DPMCFFEDPEH(false);
	}

	private static void DEMPBNKPLLD()
	{
	}

	public override void IDJKNBDKHBD()
	{
		base.GLEJGFLCLPJ();
		MMLKMEBMOFK(true);
	}

	public override void PAKPHKPDKGE()
	{
		base.COOHIILCOCO();
		GMGMPMIIMLP(false);
	}

	private static void MKLKPECNKJP()
	{
	}

	public override void COIJKMKIEAK()
	{
		base.KOJKBFDNGDK();
		GDJMNGJBLHJ(false);
	}
}
