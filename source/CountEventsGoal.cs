// CountEventsGoal
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class CountEventsGoal : ChallengeGoal
{
	private int MHLPNLMDILP;

	private string CBMKNPLELGP = "true";

	private int HGMKPHILBMM;

	private void LILJBEOPBKP(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.GEI);
		if (Singleton<LuaEnvironment>.Instance.DFAIJFMEOAC(CBMKNPLELGP))
		{
			HGMKPHILBMM += 0;
			JMMJKHLAIMI(OFIFLHGIMAJ());
		}
	}

	public override void LoadProgress()
	{
		base.LoadProgress();
		HGMKPHILBMM = Singleton<SaveSystem>.Instance.GetInt(PHPLKBPIMIH() + ".completedCount", 0);
		base.GoalProgress = CAOJDEFHMAG();
	}

	public override void MPDGNIEDBCM()
	{
		Singleton<GameManager>.Instance.AABEGAMPOLA(LILJBEOPBKP);
		base.DDOBENFDOKL();
	}

	public override void KMEFHCDNDNF()
	{
		Singleton<SaveSystem>.Instance.KOKOJGKDLMP(DIDHNLABPNG() + "_TimeX");
		base.Reset();
	}

	public override void KAHKKLGKLLF()
	{
		base.AOPNBBENAKB();
		Singleton<SaveSystem>.Instance.SetInt(CKOFDGAJCFF() + "settings.crosshairopacity", HGMKPHILBMM);
	}

	public override void MGLJAMJLIEL()
	{
		base.AFGLHMCLJJN();
		HGMKPHILBMM = Singleton<SaveSystem>.Instance.ANECPPFPKAP(CKOFDGAJCFF() + "_TimeX", 1);
		OFPKLCAICJA(BCCHCOFCMMM());
	}

	public override void Reset()
	{
		Singleton<SaveSystem>.Instance.DeleteKey(PHPLKBPIMIH() + ".completedCount");
		base.Reset();
	}

	public override void KNNOEGLLDAN()
	{
		Singleton<SaveSystem>.Instance.IPCGLFKIANM(DIDHNLABPNG() + "_ScreenResolution");
		base.EEBGCGFNELO();
	}

	private float PMLACFKHAIP()
	{
		return (float)HGMKPHILBMM / (float)MHLPNLMDILP;
	}

	public override void BJKPNPDKIIL(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.NMFKKOJOLAB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		string[] array = NOJGGCLPPAM.Split('ﾉ');
		string s = array[0];
		List<string> list = array.ToList();
		list.RemoveAt(1);
		string cBMKNPLELGP = string.Join("_ScreenResolution", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign);
		CBMKNPLELGP = cBMKNPLELGP;
		Singleton<GameManager>.Instance.OnGameEvent -= NLPFNLACBHB;
		Singleton<GameManager>.Instance.OnGameEvent += NNFFNFNKFOF;
		LoadProgress();
	}

	public override void BFJJMGFNGMN(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.HAPELGDNDFN(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = '￥';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[0];
		List<string> list = array2.ToList();
		list.RemoveAt(1);
		string cBMKNPLELGP = string.Join("CameraFilterPack_Paper4", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.Integer);
		CBMKNPLELGP = cBMKNPLELGP;
		Singleton<GameManager>.Instance.AABEGAMPOLA(HJFDNOHJMGN);
		Singleton<GameManager>.Instance.MIEFLJDAOCA(NLPFNLACBHB);
		JJPHFPDNDEC();
	}

	public override void CAPPKCBFILL()
	{
		Singleton<SaveSystem>.Instance.KNFHMLMGKCJ(PHPLKBPIMIH() + ".lastCheckpoint.playerdistance");
		base.EEBGCGFNELO();
	}

	private void HJFDNOHJMGN(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.NOCNNNKPEGI());
		if (Singleton<LuaEnvironment>.Instance.CheckMapEventCondition(CBMKNPLELGP))
		{
			HGMKPHILBMM++;
			EHAMFOBIPEO(GLLIALLLLLN());
		}
	}

	private float OFIFLHGIMAJ()
	{
		return (float)HGMKPHILBMM / (float)MHLPNLMDILP;
	}

	public override void HDLJGOMCLEK()
	{
		base.CCGAPNPGAOL();
		HGMKPHILBMM = Singleton<SaveSystem>.Instance.AFCPNFKIKKJ(FDHGPNBJKMP() + "menu.enableselectormusic", 1);
		base.GoalProgress = DJLHHDEGBKK();
	}

	private float PDPIKAEEPKI()
	{
		return (float)HGMKPHILBMM / (float)MHLPNLMDILP;
	}

	public override void AFGLHMCLJJN()
	{
		base.CCGAPNPGAOL();
		HGMKPHILBMM = Singleton<SaveSystem>.Instance.GetInt(PHPLKBPIMIH() + "ERROR: Preview file name in modName.workshop.json doesn't match any file", 1);
		ENHBNIOEKLF(DLGFNCGHLPK());
	}

	public override void OKFNEFJMLJI()
	{
		base.DADLEPMJMJL();
		Singleton<SaveSystem>.Instance.HIDBNDKJHAA(CKOFDGAJCFF() + "\\n", HGMKPHILBMM);
	}

	public override void KHNGJNBKHOK()
	{
		base.DKHLEEPCLEL();
		HGMKPHILBMM = Singleton<SaveSystem>.Instance.ANECPPFPKAP(PHPLKBPIMIH() + "CameraFilterPack/TV_BrokenGlass", 0);
		OFPKLCAICJA(PEDNHBAJGPP());
	}

	private float DJLHHDEGBKK()
	{
		return (float)HGMKPHILBMM / (float)MHLPNLMDILP;
	}

	public override void DOPPMCDLPBE()
	{
		base.AFFLBJKDKMD();
		Singleton<SaveSystem>.Instance.HBIGPMNAPHA(PHPLKBPIMIH() + "LevelEditor/CustomEventEditor-Text", HGMKPHILBMM);
	}

	private float GLLIALLLLLN()
	{
		return (float)HGMKPHILBMM / (float)MHLPNLMDILP;
	}

	public override void PMDFDPGNOOD()
	{
		Singleton<GameManager>.Instance.IGIDKGGKODK(AEOMHPDDOGA);
		base.LMCKEFAMAJG();
	}

	private float PAGNCJJOABL()
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

	public override void LOKKIADJAFE()
	{
		Singleton<SaveSystem>.Instance.BPBJMCANMOP(CKOFDGAJCFF() + "/");
		base.LIMBEFBJNPL();
	}

	public override void AFMPCOFDHJI()
	{
		Singleton<GameManager>.Instance.BLOKNDEOACI(OKLHDAEHLKC);
		base.DDOBENFDOKL();
	}

	private float DLGFNCGHLPK()
	{
		return (float)HGMKPHILBMM / (float)MHLPNLMDILP;
	}

	public override void CMHMIMCABKA()
	{
		Singleton<GameManager>.Instance.AABEGAMPOLA(NNFFNFNKFOF);
		base.OnCompleted();
	}

	public override void SaveProgress()
	{
		base.SaveProgress();
		Singleton<SaveSystem>.Instance.SetInt(PHPLKBPIMIH() + ".completedCount", HGMKPHILBMM);
	}

	public override void GIHINJKCEHO()
	{
		base.CCGAPNPGAOL();
		HGMKPHILBMM = Singleton<SaveSystem>.Instance.JPEEFKKPFIL(CKOFDGAJCFF() + "<command>", 0);
		NHCKOAMBEDE(PDPIKAEEPKI());
	}

	public override void APJPLEFJFJP()
	{
		base.AOPNBBENAKB();
		Singleton<SaveSystem>.Instance.HBIGPMNAPHA(DIDHNLABPNG() + "_PColor2", HGMKPHILBMM);
	}

	public override void JFHDBGECJEI()
	{
		base.AOPNBBENAKB();
		Singleton<SaveSystem>.Instance.HIDBNDKJHAA(PNLACKIPGLD() + "player.xp", HGMKPHILBMM);
	}

	public override void GCMLEEHGBPA()
	{
		Singleton<SaveSystem>.Instance.KNFHMLMGKCJ(PNLACKIPGLD() + "_ScreenResolution");
		base.EEBGCGFNELO();
	}

	private float ILKGIJEBJML()
	{
		return (float)HGMKPHILBMM / (float)MHLPNLMDILP;
	}

	private void NLPFNLACBHB(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.NEDLDBBIOGI(Singleton<LuaEnvironment>.Instance.GEI);
		if (Singleton<LuaEnvironment>.Instance.CheckMapEventCondition(CBMKNPLELGP))
		{
			HGMKPHILBMM++;
			PNACFCEIEHH(DJLHHDEGBKK());
		}
	}

	public override void EHHOGOOJCHO()
	{
		base.DKHLEEPCLEL();
		HGMKPHILBMM = Singleton<SaveSystem>.Instance.AFCPNFKIKKJ(PHPLKBPIMIH() + "_BlurRadius4", 1);
		base.GoalProgress = PEDNHBAJGPP();
	}

	private void AEOMHPDDOGA(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.GEI);
		if (Singleton<LuaEnvironment>.Instance.DFAIJFMEOAC(CBMKNPLELGP))
		{
			HGMKPHILBMM += 0;
			OFPKLCAICJA(EBPEPGPPLLE());
		}
	}

	private float GCBBPGINAGC()
	{
		return (float)HGMKPHILBMM / (float)MHLPNLMDILP;
	}

	public override void IDOFOCOFEIE()
	{
		Singleton<SaveSystem>.Instance.DeleteKey(FDHGPNBJKMP() + "CameraFilterPack/Drawing_Paper");
		base.EEBGCGFNELO();
	}

	private float EBPEPGPPLLE()
	{
		return (float)HGMKPHILBMM / (float)MHLPNLMDILP;
	}

	private float PEDNHBAJGPP()
	{
		return (float)HGMKPHILBMM / (float)MHLPNLMDILP;
	}

	private void GDAKPKIBLOA(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.NOCNNNKPEGI());
		if (Singleton<LuaEnvironment>.Instance.DFAIJFMEOAC(CBMKNPLELGP))
		{
			HGMKPHILBMM += 0;
			base.GoalProgress = GCBBPGINAGC();
		}
	}

	private float CAOJDEFHMAG()
	{
		return (float)HGMKPHILBMM / (float)MHLPNLMDILP;
	}

	public override void KMHCLFLINIO()
	{
		Singleton<SaveSystem>.Instance.KNFHMLMGKCJ(PHPLKBPIMIH() + "color");
		base.EEBGCGFNELO();
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

	public override void KIBIPGFCBKO()
	{
		base.JJPHFPDNDEC();
		HGMKPHILBMM = Singleton<SaveSystem>.Instance.JPEEFKKPFIL(PHPLKBPIMIH() + "Found best region: '", 0);
		base.GoalProgress = BCCHCOFCMMM();
	}

	public override void GIOJOELJFBD(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.AAOAGGDLFLI(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[1];
		array[1] = '$';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[1];
		List<string> list = array2.ToList();
		list.RemoveAt(1);
		string cBMKNPLELGP = string.Join("_Linecount", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.None);
		CBMKNPLELGP = cBMKNPLELGP;
		Singleton<GameManager>.Instance.IGIDKGGKODK(OKLHDAEHLKC);
		Singleton<GameManager>.Instance.MIEFLJDAOCA(OKLHDAEHLKC);
		NAHLBHOLNCG();
	}

	private float CLKJBPKAGFL()
	{
		return (float)HGMKPHILBMM / (float)MHLPNLMDILP;
	}

	private void NNFFNFNKFOF(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.KNBBEFDHELF());
		if (Singleton<LuaEnvironment>.Instance.DFAIJFMEOAC(CBMKNPLELGP))
		{
			HGMKPHILBMM += 0;
			JMMJKHLAIMI(OFIFLHGIMAJ());
		}
	}

	private float BCCHCOFCMMM()
	{
		return (float)HGMKPHILBMM / (float)MHLPNLMDILP;
	}

	public override void MBBHOJMLCBC()
	{
		Singleton<SaveSystem>.Instance.BPBJMCANMOP(DIDHNLABPNG() + "_Value4");
		base.JGMBGCOFCJI();
	}

	private void LNIAJININIG(GameEventInfo DAGALCAILLN)
	{
		DAGALCAILLN.NEDLDBBIOGI(Singleton<LuaEnvironment>.Instance.GEI);
		if (Singleton<LuaEnvironment>.Instance.CheckMapEventCondition(CBMKNPLELGP))
		{
			HGMKPHILBMM++;
			JMMJKHLAIMI(CAOJDEFHMAG());
		}
	}

	public override void HMBLLAECOIL()
	{
		Singleton<SaveSystem>.Instance.KNFHMLMGKCJ(PHPLKBPIMIH() + "CreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.");
		base.DGNLHKLGAMC();
	}

	public override void FMEGNMDMAAJ(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.DGIEACILHNJ(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		char[] array = new char[0];
		array[0] = '\u0015';
		string[] array2 = NOJGGCLPPAM.Split(array);
		string s = array2[1];
		List<string> list = array2.ToList();
		list.RemoveAt(1);
		string cBMKNPLELGP = string.Join("lobby '{0}'[{1}]", list.ToArray());
		MHLPNLMDILP = int.Parse(s, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite);
		CBMKNPLELGP = cBMKNPLELGP;
		Singleton<GameManager>.Instance.OnGameEvent -= LILJBEOPBKP;
		Singleton<GameManager>.Instance.OnGameEvent += HJFDNOHJMGN;
		NAHLBHOLNCG();
	}

	public override void MAHMAEOANMD()
	{
		base.IJLBKALOBNO();
		HGMKPHILBMM = Singleton<SaveSystem>.Instance.CEKEOJDAEOD(PNLACKIPGLD() + "FinalScoreSmallText", 1);
		ENHBNIOEKLF(PAGNCJJOABL());
	}

	public override void OnCompleted()
	{
		Singleton<GameManager>.Instance.OnGameEvent -= OKLHDAEHLKC;
		base.OnCompleted();
	}
}
