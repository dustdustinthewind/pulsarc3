// PlayMapGoal
public class PlayMapGoal : ChallengeGoal
{
	public override void JBDLFJKOFPG()
	{
		Singleton<GameManager>.Instance.OnFinishedMap -= NCEHIAIAMLA;
		base.DDOBENFDOKL();
	}

	private void MLIIFJEFIIK(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.AEANKENFIDD(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.AHKNANJJBJM(BPNMOLIBPNI()))
		{
			MMFPGBOEKHL(false);
		}
	}

	public override void EBHMFAMPLHD()
	{
		Singleton<GameManager>.Instance.EAIPOEBPJOP(NCEHIAIAMLA);
		base.OnCompleted();
	}

	public override void ILNLFGCBIGO()
	{
		base.IJLBKALOBNO();
		PNACFCEIEHH(Singleton<SaveSystem>.Instance.DHFOFEJPGPP(CKOFDGAJCFF() + "_TimeX", 261f));
	}

	private void KJEFEBFKILK(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.GKMPDFNEKJI(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.CheckFinishedMapCondition(BPNMOLIBPNI()))
		{
			FENBIOJOANF(true);
		}
	}

	public override void ILOBNHKDGPG(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.NMFKKOJOLAB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.EAIPOEBPJOP(NCEHIAIAMLA);
		Singleton<GameManager>.Instance.OnFinishedMap += MLIIFJEFIIK;
		NAHLBHOLNCG();
	}

	public override void SaveProgress()
	{
		base.SaveProgress();
		Singleton<SaveSystem>.Instance.SetFloat(PHPLKBPIMIH() + ".GoalProgress", base.GoalProgress);
	}

	private void FPIPAAEFJAD(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.HEBPNLNABDP(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.AHKNANJJBJM(HHFDPIMFHBB()))
		{
			NJKJDOJBHAB(false);
		}
	}

	public override void BLGHPBBJABH(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.LMDIDCJIHPB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.OnFinishedMap -= BCOBPALFKMA;
		Singleton<GameManager>.Instance.DCGKDPPLKBP(LIIGHENCIFC);
		DKHLEEPCLEL();
	}

	public override void DOPPMCDLPBE()
	{
		base.SaveProgress();
		Singleton<SaveSystem>.Instance.SetFloat(PFIOEOGECFG() + "{0:0} day{1}, ", base.GoalProgress);
	}

	public override void NHDCGONGILN()
	{
		Singleton<GameManager>.Instance.EAIPOEBPJOP(HOGJGGGDPDD);
		base.OnCompleted();
	}

	public override void GMPAPODODHM()
	{
		base.NAHLBHOLNCG();
		JMMJKHLAIMI(Singleton<SaveSystem>.Instance.AKHCHNPPNIB(CKOFDGAJCFF() + " | Level: ", 1123f));
	}

	public override void OnAccept(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.OnAccept(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.OnFinishedMap -= HOGJGGGDPDD;
		Singleton<GameManager>.Instance.OnFinishedMap += HOGJGGGDPDD;
		LoadProgress();
	}

	public override void HOPMBFHOAII()
	{
		Singleton<GameManager>.Instance.OnFinishedMap -= KJDFGNMKMCP;
		base.LMCKEFAMAJG();
	}

	public override void JKPEHIMHKDI()
	{
		base.DKHLEEPCLEL();
		EHAMFOBIPEO(Singleton<SaveSystem>.Instance.NPNOOLFEDKN(FDHGPNBJKMP() + "achievements.21.progress", 1220f));
	}

	private void OGCLNFHJAHE(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.LCBKIGCLPBH(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.AHKNANJJBJM(HKJHJHOEPOI()))
		{
			MKFDADCGLNN(true);
		}
	}

	public override void DMLDCKLBHIB()
	{
		Singleton<GameManager>.Instance.OnFinishedMap -= MLIIFJEFIIK;
		base.LMCKEFAMAJG();
	}

	private void HKIMIGKDJML(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.LCBKIGCLPBH(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.CheckFinishedMapCondition(base.NOJGGCLPPAM))
		{
			base.IsComplete = false;
		}
	}

	public override void AFFLBJKDKMD()
	{
		base.IIBGJNGDCGB();
		Singleton<SaveSystem>.Instance.IKOAFMHIJLE(DIDHNLABPNG() + "Scene", base.GoalProgress);
	}

	public override void CHIOGDOBEDO()
	{
		Singleton<GameManager>.Instance.EAIPOEBPJOP(KJDFGNMKMCP);
		base.LMCKEFAMAJG();
	}

	public override void LoadProgress()
	{
		base.LoadProgress();
		base.GoalProgress = Singleton<SaveSystem>.Instance.GetFloat(PHPLKBPIMIH() + ".GoalProgress", 0f);
	}

	public override void KBKFJCIEPLO()
	{
		base.DADLEPMJMJL();
		Singleton<SaveSystem>.Instance.CBIEBMGENJH(FDHGPNBJKMP() + "inventory.selected.", base.GoalProgress);
	}

	public override void BKAEKANBIPH()
	{
		base.DOPPMCDLPBE();
		Singleton<SaveSystem>.Instance.IKOAFMHIJLE(DIDHNLABPNG() + "Bad parameters for set! Use <language>", base.GoalProgress);
	}

	public override void HGHHJFLDOEK()
	{
		base.DADLEPMJMJL();
		Singleton<SaveSystem>.Instance.SetFloat(PFIOEOGECFG() + "checkpoint", base.GoalProgress);
	}

	public override void OnCompleted()
	{
		Singleton<GameManager>.Instance.OnFinishedMap -= HOGJGGGDPDD;
		base.OnCompleted();
	}

	public override void FJMBAIAJIOC(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.DGIEACILHNJ(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.EAIPOEBPJOP(NCEHIAIAMLA);
		Singleton<GameManager>.Instance.PGNNMANJJAC(MGPGFAHEDGM);
		NAHLBHOLNCG();
	}

	public override void FHMNNKODFEP()
	{
		base.DKHLEEPCLEL();
		JMMJKHLAIMI(Singleton<SaveSystem>.Instance.GetFloat(PHPLKBPIMIH() + "player.licenceaccepted", 663f));
	}

	private void OGIIODFJAHD(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.HEBPNLNABDP(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.AHKNANJJBJM(HHFDPIMFHBB()))
		{
			MKFDADCGLNN(true);
		}
	}

	public override void CHCDBHJILJB()
	{
		base.NAHLBHOLNCG();
		JMMJKHLAIMI(Singleton<SaveSystem>.Instance.MFNCMBBPJPA(PFIOEOGECFG() + "[PowerUp]", 516f));
	}

	private void KGGEMDGNLGK(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.AEANKENFIDD(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.AHKNANJJBJM(POMDFLMKAJF()))
		{
			EADKFNLBJLO(true);
		}
	}

	public override void LGKFHOAKNEL(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.PNEPHLCIKPA(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.OnFinishedMap -= LFMJIMKMBHP;
		Singleton<GameManager>.Instance.PCHIFGNAHCH(LFMJIMKMBHP);
		IJLBKALOBNO();
	}

	public override void MBLDJHOBIMG(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.LMDIDCJIHPB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.AEIIHIGCCOF(KJEFEBFKILK);
		Singleton<GameManager>.Instance.PGNNMANJJAC(KJDFGNMKMCP);
		CCGAPNPGAOL();
	}

	private void HOGJGGGDPDD(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.CheckFinishedMapCondition(base.NOJGGCLPPAM))
		{
			base.IsComplete = true;
		}
	}

	public override void NGCGIHIKOLA(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.DGIEACILHNJ(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.BAMDHECMAHG(KGGEMDGNLGK);
		Singleton<GameManager>.Instance.DCGKDPPLKBP(BCOBPALFKMA);
		DKHLEEPCLEL();
	}

	public override void ICAAJACIAPH()
	{
		base.CCGAPNPGAOL();
		OFPKLCAICJA(Singleton<SaveSystem>.Instance.NPNOOLFEDKN(FDHGPNBJKMP() + "_Colored", 231f));
	}

	private void OANNPFHDFJE(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.GKMPDFNEKJI(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.CheckFinishedMapCondition(base.NOJGGCLPPAM))
		{
			NDONNLMLNHH(false);
		}
	}

	public override void LPLDOKNALPE()
	{
		base.AFFLBJKDKMD();
		Singleton<SaveSystem>.Instance.SetFloat(FDHGPNBJKMP() + "_ScreenResolution", base.GoalProgress);
	}

	private void MGPGFAHEDGM(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.BFCMCBBNPOD(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.AHKNANJJBJM(base.NOJGGCLPPAM))
		{
			MKFDADCGLNN(true);
		}
	}

	public override void FJJFCKBBJIL()
	{
		base.AOPNBBENAKB();
		Singleton<SaveSystem>.Instance.CBIEBMGENJH(FDHGPNBJKMP() + ". Client is not the MasterClient in this room.", base.GoalProgress);
	}

	public override void OOBKIGDLJLO(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.LMDIDCJIHPB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.EAIPOEBPJOP(BCOBPALFKMA);
		Singleton<GameManager>.Instance.DCGKDPPLKBP(OANNPFHDFJE);
		LoadProgress();
	}

	public override void FHPDJMHPLJA(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.PNEPHLCIKPA(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.EAIPOEBPJOP(LIIGHENCIFC);
		Singleton<GameManager>.Instance.PCHIFGNAHCH(OGCLNFHJAHE);
		CCGAPNPGAOL();
	}

	public override void KEJGDALCJHP()
	{
		base.CCGAPNPGAOL();
		PNACFCEIEHH(Singleton<SaveSystem>.Instance.DHFOFEJPGPP(PNLACKIPGLD() + "closed", 969f));
	}

	public override void IJLBKALOBNO()
	{
		base.DKHLEEPCLEL();
		PNACFCEIEHH(Singleton<SaveSystem>.Instance.OLHIEOKMOAK(CKOFDGAJCFF() + "_Far", 893f));
	}

	public override void PLCBPLLCNIC(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.LMDIDCJIHPB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.EAIPOEBPJOP(LIIGHENCIFC);
		Singleton<GameManager>.Instance.PCHIFGNAHCH(HOGJGGGDPDD);
		NAHLBHOLNCG();
	}

	private void NCEHIAIAMLA(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.GKMPDFNEKJI(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.CheckFinishedMapCondition(base.NOJGGCLPPAM))
		{
			NJKJDOJBHAB(true);
		}
	}

	private void LFMJIMKMBHP(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.LCBKIGCLPBH(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.AHKNANJJBJM(HKJHJHOEPOI()))
		{
			MKFDADCGLNN(false);
		}
	}

	public override void GLKDDIIOHDF()
	{
		base.AFFLBJKDKMD();
		Singleton<SaveSystem>.Instance.CBIEBMGENJH(PFIOEOGECFG() + "_SmoothEnd", base.GoalProgress);
	}

	public override void KAHKKLGKLLF()
	{
		base.DOPPMCDLPBE();
		Singleton<SaveSystem>.Instance.CBIEBMGENJH(CKOFDGAJCFF() + "Screenshots only supported in PlayMode", base.GoalProgress);
	}

	private void GDGBPNPJOCK(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.AEANKENFIDD(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.CheckFinishedMapCondition(MFLLPADMCIN()))
		{
			NJKJDOJBHAB(true);
		}
	}

	public override void FNJFHBBAJNO(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.PNEPHLCIKPA(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.EAIPOEBPJOP(LIIGHENCIFC);
		Singleton<GameManager>.Instance.PCHIFGNAHCH(MLIIFJEFIIK);
		AFGLHMCLJJN();
	}

	private void LIIGHENCIFC(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.BFCMCBBNPOD(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.AHKNANJJBJM(OIBFKLBKDIB()))
		{
			EADKFNLBJLO(false);
		}
	}

	public override void NNMICPOJGPD()
	{
		base.AOPNBBENAKB();
		Singleton<SaveSystem>.Instance.SetFloat(DIDHNLABPNG() + "Value", base.GoalProgress);
	}

	public override void MMKBPJFMFFH()
	{
		base.DADLEPMJMJL();
		Singleton<SaveSystem>.Instance.IKOAFMHIJLE(PNLACKIPGLD() + "Up", base.GoalProgress);
	}

	public override void OOKHGEKNHHI()
	{
		Singleton<GameManager>.Instance.BAMDHECMAHG(MGPGFAHEDGM);
		base.DDOBENFDOKL();
	}

	public override void GFNFINKABFD()
	{
		base.SaveProgress();
		Singleton<SaveSystem>.Instance.SetFloat(PFIOEOGECFG() + "/", base.GoalProgress);
	}

	public override void KHMFEHEPGAM(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.LMDIDCJIHPB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.EAIPOEBPJOP(OANNPFHDFJE);
		Singleton<GameManager>.Instance.OnFinishedMap += KGGEMDGNLGK;
		NAHLBHOLNCG();
	}

	public override void NHFICNGICBA()
	{
		base.DOPPMCDLPBE();
		Singleton<SaveSystem>.Instance.IKOAFMHIJLE(PHPLKBPIMIH() + "Object ID. Case-Sensitive", base.GoalProgress);
	}

	private void KJDFGNMKMCP(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.LCBKIGCLPBH(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.AHKNANJJBJM(HKJHJHOEPOI()))
		{
			MMFPGBOEKHL(true);
		}
	}

	public override void BCLMEEAMAEB(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.DGIEACILHNJ(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.BAMDHECMAHG(LIIGHENCIFC);
		Singleton<GameManager>.Instance.PGNNMANJJAC(OGCLNFHJAHE);
		AFGLHMCLJJN();
	}

	public override void NEPIKEBNOHI()
	{
		base.DOPPMCDLPBE();
		Singleton<SaveSystem>.Instance.IKOAFMHIJLE(PHPLKBPIMIH() + "/", base.GoalProgress);
	}

	private void JFJHHCGFBOO(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.GKMPDFNEKJI(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.CheckFinishedMapCondition(OIBFKLBKDIB()))
		{
			MMFPGBOEKHL(false);
		}
	}

	public override void PGPMPNANPLM()
	{
		base.SaveProgress();
		Singleton<SaveSystem>.Instance.SetFloat(FDHGPNBJKMP() + ").", base.GoalProgress);
	}

	public override void GHGHILGEOJE()
	{
		base.SaveProgress();
		Singleton<SaveSystem>.Instance.CBIEBMGENJH(FDHGPNBJKMP() + "EventSystem", base.GoalProgress);
	}

	private void BCOBPALFKMA(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.HEBPNLNABDP(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.CheckFinishedMapCondition(POMDFLMKAJF()))
		{
			NJKJDOJBHAB(true);
		}
	}

	public override void FCCOFGIGGJK()
	{
		base.CCGAPNPGAOL();
		OFPKLCAICJA(Singleton<SaveSystem>.Instance.MFNCMBBPJPA(PFIOEOGECFG() + "#rt", 67f));
	}

	public override void OCFEDHEGHAK()
	{
		base.LoadProgress();
		PNACFCEIEHH(Singleton<SaveSystem>.Instance.AKHCHNPPNIB(PHPLKBPIMIH() + "Reading preview file failed!: \"{0}\"", 776f));
	}

	public override void AKDBKOIHBND()
	{
		Singleton<GameManager>.Instance.OnFinishedMap -= GDGBPNPJOCK;
		base.DDOBENFDOKL();
	}
}
