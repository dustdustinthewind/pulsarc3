// CountEventsGoal
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class CountEventsGoal : ChallengeGoal
{
	private int MHLPNLMDILP;

	private string CBMKNPLELGP = "true";

	private int HGMKPHILBMM;

	public override void PIKFPFLKBCG()
	{
		Singleton<GameManager>.Instance.FOKIAPDGFAB(IPGKJJJPLOL);
		base.PIKFPFLKBCG();
	}

	public override void OKJDCJIDGCH()
	{
		base.HEPLJACPKFO();
		HGMKPHILBMM = Singleton<SaveSystem>.Instance.KFNFNKILGPH(KHILCMNLMOJ() + "open", 1);
		base.GoalProgress = LNACNNOIHMB();
	}

	public override void ICAAJACIAPH()
	{
		base.PPPFKGOCMLO();
		HGMKPHILBMM = Singleton<SaveSystem>.Instance.HHBIEPMBICO(PHPLKBPIMIH() + "challenges.", 1);
		BNPNMCFLDNI(GICDHIHBFHI());
	}

	public override void NMFBGKMIHFA()
	{
		Singleton<GameManager>.Instance.OnGameEvent -= BOOHNLOCBDK;
		base.IOIAOIMIIMA();
	}

	public override void HLFLMNNEKBJ(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.LPGHCNKDCKD(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = 'e';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[0];
		List<string> list = array2.ToList();
		list.RemoveAt(1);
		string cBMKNPLELGP = string.Join("CameraFilterPack/Blur_Radial", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite);
		CBMKNPLELGP = cBMKNPLELGP;
		Singleton<GameManager>.Instance.FOKIAPDGFAB(FIBINEJFAHF);
		Singleton<GameManager>.Instance.OnGameEvent += KJKPJNECCAA;
		EMDHDEGLPPF();
	}

	public override void BMMJGMKOBJL()
	{
		Singleton<GameManager>.Instance.LKMBANBOLHD(CBLPBNNHFDF);
		base.ALGICFLJJBM();
	}

	public override void AIAIAJFFBIN(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.KJJMJJJEGDB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = '\uffdd';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[0];
		List<string> list = array2.ToList();
		list.RemoveAt(1);
		string cBMKNPLELGP = string.Join("_Blue_G", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingSign);
		CBMKNPLELGP = cBMKNPLELGP;
		Singleton<GameManager>.Instance.FOKIAPDGFAB(AJNMBKABIMO);
		Singleton<GameManager>.Instance.OnGameEvent += IPGKJJJPLOL;
		HEPLJACPKFO();
	}

	public override void KIBIPGFCBKO()
	{
		base.LoadProgress();
		HGMKPHILBMM = Singleton<SaveSystem>.Instance.KFNFNKILGPH(JLGGLIMFAFJ() + "_SSAO", 0);
		JKINKBKCGFP(LNACNNOIHMB());
	}

	private void CGKBKHDGKNP(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.PPEBDMBKOBD());
		if (Singleton<LuaEnvironment>.Instance.NILOPHNEAIC(CBMKNPLELGP))
		{
			HGMKPHILBMM += 0;
			AHMNICEJLMF(CAOJDEFHMAG());
		}
	}

	public override void NGHGLCLLIMP()
	{
		base.AGCKLPAKDAK();
		Singleton<SaveSystem>.Instance.GBFBKFACPBI(KHILCMNLMOJ() + "_Value2", HGMKPHILBMM);
	}

	public override void ABFLIINAFLC()
	{
		base.OPDGBIPHKGC();
		Singleton<SaveSystem>.Instance.OFPCEFFGHPI(JLGGLIMFAFJ() + "IconFileSelector", HGMKPHILBMM);
	}

	public override void LKGPOLEPAEG()
	{
		base.OPDGBIPHKGC();
		Singleton<SaveSystem>.Instance.OFPCEFFGHPI(FJFFJLBABDI() + " at ", HGMKPHILBMM);
	}

	public override void GOFMABPMLKF()
	{
		Singleton<SaveSystem>.Instance.DeleteKey(FJFFJLBABDI() + "_ScreenResolution");
		base.IJHPPIHFFEA();
	}

	private void NLPFNLACBHB(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.GEI);
		if (Singleton<LuaEnvironment>.Instance.CheckMapEventCondition(CBMKNPLELGP))
		{
			HGMKPHILBMM++;
			NHENNCOILPG(CEKIBLKIKEF());
		}
	}

	private float CDCIEIOFABB()
	{
		return (float)HGMKPHILBMM / (float)MHLPNLMDILP;
	}

	public override void AODLIPCOIAK()
	{
		Singleton<GameManager>.Instance.OnGameEvent -= OKLHDAEHLKC;
		base.ONLIHAEAHOJ();
	}

	private float MBKDOOBIJJJ()
	{
		return (float)HGMKPHILBMM / (float)MHLPNLMDILP;
	}

	private void KJKPJNECCAA(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.GEI);
		if (Singleton<LuaEnvironment>.Instance.CheckMapEventCondition(CBMKNPLELGP))
		{
			HGMKPHILBMM++;
			BNPNMCFLDNI(GICDHIHBFHI());
		}
	}

	private float OKMLICIEMEG()
	{
		return (float)HGMKPHILBMM / (float)MHLPNLMDILP;
	}

	public override void EAEAIFOBPHI(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.LPGHCNKDCKD(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = 'i';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[0];
		List<string> list = array2.ToList();
		list.RemoveAt(1);
		string cBMKNPLELGP = string.Join("id", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingSign);
		CBMKNPLELGP = cBMKNPLELGP;
		Singleton<GameManager>.Instance.FOKIAPDGFAB(ANGLIEAGDOA);
		Singleton<GameManager>.Instance.AALMFLNJPDG(AJNMBKABIMO);
		HEPLJACPKFO();
	}

	private float CAOJDEFHMAG()
	{
		return (float)HGMKPHILBMM / (float)MHLPNLMDILP;
	}

	public override void DOPPMCDLPBE()
	{
		base.FLEONCKOLNB();
		Singleton<SaveSystem>.Instance.DAAJKCCCICP(PHPLKBPIMIH() + "CameraFilterPack/Colors_Adjust_ColorRGB", HGMKPHILBMM);
	}

	public override void HBEJAGDGJAI()
	{
		base.HOEHJFEELNJ();
		Singleton<SaveSystem>.Instance.OFPCEFFGHPI(DNEPKKKEBEA() + "GlassColor", HGMKPHILBMM);
	}

	public override void DOKEOBBOHEL()
	{
		Singleton<GameManager>.Instance.OnGameEvent -= ANGLIEAGDOA;
		base.KLEMLMOPEFE();
	}

	public override void BJHJCGJACEA()
	{
		Singleton<SaveSystem>.Instance.IOJKJDBACPC(KHILCMNLMOJ() + "_TimeX");
		base.CJPIGOKLKOA();
	}

	public override void DEDANNMJNOC()
	{
		Singleton<SaveSystem>.Instance.IOJKJDBACPC(KHILCMNLMOJ() + ".r");
		base.Reset();
	}

	public override void MBLDJHOBIMG(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.NGLEHMAEEKL(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[0];
		array[1] = 'z';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[0];
		List<string> list = array2.ToList();
		list.RemoveAt(0);
		string cBMKNPLELGP = string.Join("Can not SetMasterClient(). Not in room or in offlineMode.", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingWhite);
		CBMKNPLELGP = cBMKNPLELGP;
		Singleton<GameManager>.Instance.FOKIAPDGFAB(KCNNFCFHAHI);
		Singleton<GameManager>.Instance.AALMFLNJPDG(AJNMBKABIMO);
		HEPLJACPKFO();
	}

	public override void CHMIIBGANOP()
	{
		base.EMDHDEGLPPF();
		HGMKPHILBMM = Singleton<SaveSystem>.Instance.GetInt(BGOBKCLKJMD() + "Checkpoint", 0);
		base.GoalProgress = OKMLICIEMEG();
	}

	private void CBLPBNNHFDF(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.EKPOOHDFOBN());
		if (Singleton<LuaEnvironment>.Instance.ENBEECGHGLO(CBMKNPLELGP))
		{
			HGMKPHILBMM += 0;
			JKINKBKCGFP(LNACNNOIHMB());
		}
	}

	public override void AFGLHMCLJJN()
	{
		base.LoadProgress();
		HGMKPHILBMM = Singleton<SaveSystem>.Instance.GetInt(DNEPKKKEBEA() + "_ScreenResolution", 1);
		AHMNICEJLMF(GICDHIHBFHI());
	}

	public override void PKFHBBCFEHG()
	{
		base.KANOEJEJAJN();
		Singleton<SaveSystem>.Instance.OFPCEFFGHPI(BGOBKCLKJMD() + "Image", HGMKPHILBMM);
	}

	public override void JODHOODGJGP()
	{
		base.OMENGFPFDLL();
		Singleton<SaveSystem>.Instance.DAAJKCCCICP(DNEPKKKEBEA() + "CameraFilterPack/Distortion_BlackHole", HGMKPHILBMM);
	}

	public override void BFJJMGFNGMN(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.KHMFEHEPGAM(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		string[] array = NOJGGCLPPAM.Split('ￅ');
		string s = array[0];
		List<string> list = array.ToList();
		list.RemoveAt(1);
		string cBMKNPLELGP = string.Join("_ScreenResolution", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.None);
		CBMKNPLELGP = cBMKNPLELGP;
		Singleton<GameManager>.Instance.FOKIAPDGFAB(NNFFNFNKFOF);
		Singleton<GameManager>.Instance.AALMFLNJPDG(KCNNFCFHAHI);
		HEPLJACPKFO();
	}

	private float LNACNNOIHMB()
	{
		return (float)HGMKPHILBMM / (float)MHLPNLMDILP;
	}

	public override void OnAccept(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.OnAccept(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		string[] array = NOJGGCLPPAM.Split(',');
		string s = array[0];
		List<string> list = array.ToList();
		list.RemoveAt(0);
		string cBMKNPLELGP = string.Join(",", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.Integer);
		CBMKNPLELGP = cBMKNPLELGP;
		Singleton<GameManager>.Instance.OnGameEvent -= OKLHDAEHLKC;
		Singleton<GameManager>.Instance.OnGameEvent += OKLHDAEHLKC;
		LoadProgress();
	}

	public override void KIILJGKMPOA()
	{
		base.EMDHDEGLPPF();
		HGMKPHILBMM = Singleton<SaveSystem>.Instance.KFNFNKILGPH(KHILCMNLMOJ() + " ", 1);
		BNPNMCFLDNI(CAOJDEFHMAG());
	}

	public override void DMGIOKBHOBL(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.LPGHCNKDCKD(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = '\uffdf';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[1];
		List<string> list = array2.ToList();
		list.RemoveAt(1);
		string cBMKNPLELGP = string.Join("Edited unlock conditions", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite);
		CBMKNPLELGP = cBMKNPLELGP;
		Singleton<GameManager>.Instance.FOKIAPDGFAB(KCNNFCFHAHI);
		Singleton<GameManager>.Instance.OnGameEvent += CGKBKHDGKNP;
		DFBDPJGHEEK();
	}

	public override void DGNLHKLGAMC()
	{
		Singleton<SaveSystem>.Instance.JHCDGOMGOBE(JLGGLIMFAFJ() + "Move environment object to the position");
		base.IJHPPIHFFEA();
	}

	public override void JADEDAEMLBN()
	{
		Singleton<SaveSystem>.Instance.KGGLDBCMCCM(ADHHBPHLCJO() + "_Value");
		base.NHJBGDIEGPH();
	}

	public override void OnCompleted()
	{
		Singleton<GameManager>.Instance.OnGameEvent -= OKLHDAEHLKC;
		base.OnCompleted();
	}

	public override void LJOEJPOJPGH(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.DPIDHAFMFGG(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[0];
		array[1] = 'ﾠ';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[0];
		List<string> list = array2.ToList();
		list.RemoveAt(0);
		string cBMKNPLELGP = string.Join("OnPlayerGameMessage", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingSign);
		CBMKNPLELGP = cBMKNPLELGP;
		Singleton<GameManager>.Instance.LKMBANBOLHD(OKLHDAEHLKC);
		Singleton<GameManager>.Instance.OnGameEvent += NLPFNLACBHB;
		HEPLJACPKFO();
	}

	private void ANGLIEAGDOA(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.EKPOOHDFOBN());
		if (Singleton<LuaEnvironment>.Instance.GAFCMDALGPH(CBMKNPLELGP))
		{
			HGMKPHILBMM++;
			AHMNICEJLMF(LNACNNOIHMB());
		}
	}

	private void OKLHDAEHLKC(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.GEI);
		if (Singleton<LuaEnvironment>.Instance.CheckMapEventCondition(CBMKNPLELGP))
		{
			HGMKPHILBMM++;
			base.GoalProgress = CAOJDEFHMAG();
		}
	}

	private float CEKIBLKIKEF()
	{
		return (float)HGMKPHILBMM / (float)MHLPNLMDILP;
	}

	public override void LoadProgress()
	{
		base.LoadProgress();
		HGMKPHILBMM = Singleton<SaveSystem>.Instance.GetInt(PHPLKBPIMIH() + ".completedCount", 0);
		base.GoalProgress = CAOJDEFHMAG();
	}

	public override void IOFDCAIPEGA()
	{
		Singleton<GameManager>.Instance.LKMBANBOLHD(ICCPGBPICFP);
		base.OnCompleted();
	}

	public override void CPGAFFIOGCH()
	{
		Singleton<SaveSystem>.Instance.JHCDGOMGOBE(ADHHBPHLCJO() + "player.blackwhite");
		base.CJPIGOKLKOA();
	}

	private void KCNNFCFHAHI(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.PPEBDMBKOBD());
		if (Singleton<LuaEnvironment>.Instance.GAFCMDALGPH(CBMKNPLELGP))
		{
			HGMKPHILBMM += 0;
			base.GoalProgress = GICDHIHBFHI();
		}
	}

	public override void LHIBPEGLPHM()
	{
		Singleton<SaveSystem>.Instance.AGDCACJJAMG(JLGGLIMFAFJ() + "0.00");
		base.COABGLMKACM();
	}

	public override void AFMPCOFDHJI()
	{
		Singleton<GameManager>.Instance.LKMBANBOLHD(ANGLIEAGDOA);
		base.IOIAOIMIIMA();
	}

	public override void KGGEDALAKDA(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.GKCOBIILKMA(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[0];
		array[1] = 'ﾤ';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[1];
		List<string> list = array2.ToList();
		list.RemoveAt(0);
		string cBMKNPLELGP = string.Join("Delete events", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingWhite);
		CBMKNPLELGP = cBMKNPLELGP;
		Singleton<GameManager>.Instance.LKMBANBOLHD(BOOHNLOCBDK);
		Singleton<GameManager>.Instance.PLHPCLABBIA(IPGKJJJPLOL);
		LoadProgress();
	}

	public override void KBJAAOIAPCC()
	{
		Singleton<GameManager>.Instance.LKMBANBOLHD(FIBINEJFAHF);
		base.JNLJADDKPAI();
	}

	public override void FJMBAIAJIOC(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.OnAccept(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		string[] array = NOJGGCLPPAM.Split('\n');
		string s = array[0];
		List<string> list = array.ToList();
		list.RemoveAt(0);
		string cBMKNPLELGP = string.Join("CameraFilterPack/Blend2Camera_Overlay", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.Integer);
		CBMKNPLELGP = cBMKNPLELGP;
		Singleton<GameManager>.Instance.LKMBANBOLHD(ANGLIEAGDOA);
		Singleton<GameManager>.Instance.OnGameEvent += KJKPJNECCAA;
		HBLGNPFJGBF();
	}

	public override void PGPMPNANPLM()
	{
		base.AGCKLPAKDAK();
		Singleton<SaveSystem>.Instance.SetInt(IKLKPAJBHGB() + "speed", HGMKPHILBMM);
	}

	public override void KLBGGKHNLDD()
	{
		base.PPPFKGOCMLO();
		HGMKPHILBMM = Singleton<SaveSystem>.Instance.KFNFNKILGPH(KOHBJKHPDGK() + "\" that takes ", 1);
		AHMNICEJLMF(CAOJDEFHMAG());
	}

	private void NNFFNFNKFOF(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.EKPOOHDFOBN());
		if (Singleton<LuaEnvironment>.Instance.NILOPHNEAIC(CBMKNPLELGP))
		{
			HGMKPHILBMM += 0;
			JKINKBKCGFP(CDCIEIOFABB());
		}
	}

	public override void ILOBNHKDGPG(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.MOOFNOAOAMF(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = ',';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[1];
		List<string> list = array2.ToList();
		list.RemoveAt(0);
		string cBMKNPLELGP = string.Join("Received RPC \"", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite);
		CBMKNPLELGP = cBMKNPLELGP;
		Singleton<GameManager>.Instance.LKMBANBOLHD(KCNNFCFHAHI);
		Singleton<GameManager>.Instance.OnGameEvent += IPGKJJJPLOL;
		EMDHDEGLPPF();
	}

	public override void OGKGIAAACAD()
	{
		Singleton<SaveSystem>.Instance.KGGLDBCMCCM(DNEPKKKEBEA() + "Other");
		base.HIGJLKBIEOK();
	}

	private void FIBINEJFAHF(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.EKPOOHDFOBN());
		if (Singleton<LuaEnvironment>.Instance.CheckMapEventCondition(CBMKNPLELGP))
		{
			HGMKPHILBMM += 0;
			NHENNCOILPG(CEKIBLKIKEF());
		}
	}

	private void IPGKJJJPLOL(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.DDGJFHBJMPK());
		if (Singleton<LuaEnvironment>.Instance.ENBEECGHGLO(CBMKNPLELGP))
		{
			HGMKPHILBMM++;
			NHENNCOILPG(LNACNNOIHMB());
		}
	}

	public override void MOOFNOAOAMF(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.NOFLEDOPHMO(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		string[] array = NOJGGCLPPAM.Split('ﾑ');
		string s = array[0];
		List<string> list = array.ToList();
		list.RemoveAt(0);
		string cBMKNPLELGP = string.Join("GlassColor", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingWhite);
		CBMKNPLELGP = cBMKNPLELGP;
		Singleton<GameManager>.Instance.LKMBANBOLHD(KCNNFCFHAHI);
		Singleton<GameManager>.Instance.PLHPCLABBIA(IPGKJJJPLOL);
		HEPLJACPKFO();
	}

	public override void GENNDFFJJNH()
	{
		base.HEPLJACPKFO();
		HGMKPHILBMM = Singleton<SaveSystem>.Instance.GetInt(PHPLKBPIMIH() + "ScreenResolutionPanel", 1);
		base.GoalProgress = CEKIBLKIKEF();
	}

	private float GICDHIHBFHI()
	{
		return (float)HGMKPHILBMM / (float)MHLPNLMDILP;
	}

	public override void SaveProgress()
	{
		base.SaveProgress();
		Singleton<SaveSystem>.Instance.SetInt(PHPLKBPIMIH() + ".completedCount", HGMKPHILBMM);
	}

	public override void ADNFLLEGHGH()
	{
		Singleton<GameManager>.Instance.FOKIAPDGFAB(ICCPGBPICFP);
		base.OnCompleted();
	}

	public override void GMPAPODODHM()
	{
		base.LoadProgress();
		HGMKPHILBMM = Singleton<SaveSystem>.Instance.HHBIEPMBICO(PHPLKBPIMIH() + "PointsScoreText", 0);
		NHENNCOILPG(MBKDOOBIJJJ());
	}

	public override void KOBJAEPJJJM()
	{
		Singleton<SaveSystem>.Instance.KGGLDBCMCCM(IKLKPAJBHGB() + "SetSatelliteRotationSpeed");
		base.LAACNNJDKBI();
	}

	public override void LEPCANPAJFA()
	{
		base.HEPLJACPKFO();
		HGMKPHILBMM = Singleton<SaveSystem>.Instance.HHBIEPMBICO(FJFFJLBABDI() + "ready", 0);
		NHENNCOILPG(GICDHIHBFHI());
	}

	private void BOOHNLOCBDK(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.PPEBDMBKOBD());
		if (Singleton<LuaEnvironment>.Instance.CheckMapEventCondition(CBMKNPLELGP))
		{
			HGMKPHILBMM++;
			AHMNICEJLMF(MBKDOOBIJJJ());
		}
	}

	public override void FPMFLNFMDLN()
	{
		base.KANOEJEJAJN();
		Singleton<SaveSystem>.Instance.SetInt(KOHBJKHPDGK() + "_Value4", HGMKPHILBMM);
	}

	public override void FHFEHPCEMGI(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.KJJMJJJEGDB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = '5';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[0];
		List<string> list = array2.ToList();
		list.RemoveAt(0);
		string cBMKNPLELGP = string.Join("_VelocityScale", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingSign);
		CBMKNPLELGP = cBMKNPLELGP;
		Singleton<GameManager>.Instance.FOKIAPDGFAB(NNFFNFNKFOF);
		Singleton<GameManager>.Instance.PLHPCLABBIA(KCNNFCFHAHI);
		EMDHDEGLPPF();
	}

	private void AJNMBKABIMO(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.EKPOOHDFOBN());
		if (Singleton<LuaEnvironment>.Instance.ENBEECGHGLO(CBMKNPLELGP))
		{
			HGMKPHILBMM++;
			BNPNMCFLDNI(GICDHIHBFHI());
		}
	}

	public override void PCPDMGPGMEF()
	{
		Singleton<GameManager>.Instance.LKMBANBOLHD(KJKPJNECCAA);
		base.KLEMLMOPEFE();
	}

	private void ICCPGBPICFP(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.EDIJMIINAGB());
		if (Singleton<LuaEnvironment>.Instance.CheckMapEventCondition(CBMKNPLELGP))
		{
			HGMKPHILBMM++;
			base.GoalProgress = CDCIEIOFABB();
		}
	}

	public override void FHPDJMHPLJA(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.LPGHCNKDCKD(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[0];
		array[1] = 'f';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[0];
		List<string> list = array2.ToList();
		list.RemoveAt(1);
		string cBMKNPLELGP = string.Join("_Value4", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.AllowTrailingWhite);
		CBMKNPLELGP = cBMKNPLELGP;
		Singleton<GameManager>.Instance.OnGameEvent -= AJNMBKABIMO;
		Singleton<GameManager>.Instance.OnGameEvent += NLPFNLACBHB;
		PPPFKGOCMLO();
	}

	public override void DNNEPKGGCAO()
	{
		base.PPPFKGOCMLO();
		HGMKPHILBMM = Singleton<SaveSystem>.Instance.HHBIEPMBICO(BGOBKCLKJMD() + "_Visualize", 1);
		AHMNICEJLMF(OKMLICIEMEG());
	}

	public override void NNFMEADJLLM()
	{
		Singleton<GameManager>.Instance.LKMBANBOLHD(OKLHDAEHLKC);
		base.OnCompleted();
	}

	public override void OKFNEFJMLJI()
	{
		base.FLEONCKOLNB();
		Singleton<SaveSystem>.Instance.GBFBKFACPBI(PHPLKBPIMIH() + "Pop", HGMKPHILBMM);
	}

	public override void Reset()
	{
		Singleton<SaveSystem>.Instance.DeleteKey(PHPLKBPIMIH() + ".completedCount");
		base.Reset();
	}
}
