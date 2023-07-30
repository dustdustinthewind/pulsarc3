// PlayMapGoal
public class PlayMapGoal : ChallengeGoal
{
	public override void KBKFJCIEPLO()
	{
		base.AGCKLPAKDAK();
		Singleton<SaveSystem>.Instance.SetFloat(FJFFJLBABDI() + "CameraFilterPack/Vision_Rainbow", base.GoalProgress);
	}

	public override void PLLIKCPBLKK()
	{
		Singleton<GameManager>.Instance.OnFinishedMap -= ODKKJODPBMI;
		base.ONLIHAEAHOJ();
	}

	public override void LOFENJCNEEJ()
	{
		base.FBLBEAJKCPH();
		Singleton<SaveSystem>.Instance.OKOEGLJJHOK(FJFFJLBABDI() + "mapselector.lastSearch", FBEFEPECHBM());
	}

	public override void JJPHFPDNDEC()
	{
		base.PPPFKGOCMLO();
		AHMNICEJLMF(Singleton<SaveSystem>.Instance.GetFloat(BGOBKCLKJMD() + "_Green_G", 351f));
	}

	public override void KFFKJDAFLNJ()
	{
		base.HEPLJACPKFO();
		BNPNMCFLDNI(Singleton<SaveSystem>.Instance.PGKJAIODCEF(IKLKPAJBHGB() + "_Value3", 915f));
	}

	public override void PNEDPOKJNFH()
	{
		Singleton<GameManager>.Instance.GPEKLFBAAGI(LIIGHENCIFC);
		base.PIKFPFLKBCG();
	}

	private void OGIIODFJAHD(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.LCBKIGCLPBH(Singleton<LuaEnvironment>.Instance.BHJCFDLIGFJ());
		if (Singleton<LuaEnvironment>.Instance.AMPMFFNDBMB(MKLMBNEGNKK()))
		{
			MBIMEPCPGOF(false);
		}
	}

	public override void OnAccept(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.OnAccept(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.OnFinishedMap -= HOGJGGGDPDD;
		Singleton<GameManager>.Instance.OnFinishedMap += HOGJGGGDPDD;
		LoadProgress();
	}

	public override void GDBPHCFAMLK()
	{
		Singleton<GameManager>.Instance.GPEKLFBAAGI(LIIGHENCIFC);
		base.KBJAAOIAPCC();
	}

	private void ODKKJODPBMI(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.NIDBAEKPFOD(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.MBPHDIDGGDJ(MKLMBNEGNKK()))
		{
			LEIJPFEABBJ(false);
		}
	}

	public override void NKDABNOFGLP(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.HAPELGDNDFN(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.GPEKLFBAAGI(ODKKJODPBMI);
		Singleton<GameManager>.Instance.OnFinishedMap += OGIIODFJAHD;
		EMDHDEGLPPF();
	}

	public override void CFKBBLCNEOA()
	{
		base.OMENGFPFDLL();
		Singleton<SaveSystem>.Instance.FNBPKFMKJFO(JLGGLIMFAFJ() + "_Blue_G", LIDCEAOBMAF());
	}

	public override void JKPEHIMHKDI()
	{
		base.HEPLJACPKFO();
		base.GoalProgress = Singleton<SaveSystem>.Instance.HCNELAJLBPC(KHILCMNLMOJ() + "The given 2D texture ", 456f);
	}

	public override void LDAOALCLIHN(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.GKCOBIILKMA(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.GPEKLFBAAGI(ODKKJODPBMI);
		Singleton<GameManager>.Instance.IALDPMHMMAJ(JFJHHCGFBOO);
		LoadProgress();
	}

	public override void MLNCEPLFEKJ()
	{
		base.SaveProgress();
		Singleton<SaveSystem>.Instance.OKOEGLJJHOK(PHPLKBPIMIH() + "maps.", base.GoalProgress);
	}

	public override void BHENLODHFAB()
	{
		base.SaveProgress();
		Singleton<SaveSystem>.Instance.KDHMHPPBLIF(PHPLKBPIMIH() + "OnMastedChangeScene", FBEFEPECHBM());
	}

	public override void GHILLBKBCBO()
	{
		base.FBLBEAJKCPH();
		Singleton<SaveSystem>.Instance.FIKHPJEMEGO(PHPLKBPIMIH() + "[PlayerController] ", GHDFDFBCJNB());
	}

	private void HOGJGGGDPDD(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.CheckFinishedMapCondition(base.NOJGGCLPPAM))
		{
			base.IsComplete = true;
		}
	}

	public override void OnCompleted()
	{
		Singleton<GameManager>.Instance.OnFinishedMap -= HOGJGGGDPDD;
		base.OnCompleted();
	}

	public override void AAOAGGDLFLI(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.NGLEHMAEEKL(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.IJANEODJFIG(HOGJGGGDPDD);
		Singleton<GameManager>.Instance.IALDPMHMMAJ(JFJHHCGFBOO);
		DFBDPJGHEEK();
	}

	public override void EBHMFAMPLHD()
	{
		Singleton<GameManager>.Instance.GPEKLFBAAGI(HKIMIGKDJML);
		base.IOIAOIMIIMA();
	}

	public override void HDOHBDAGMEO()
	{
		base.PPPFKGOCMLO();
		NHENNCOILPG(Singleton<SaveSystem>.Instance.PGKJAIODCEF(JLGGLIMFAFJ() + "challenges.", 49f));
	}

	public override void FHPDJMHPLJA(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.OnAccept(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.GPEKLFBAAGI(JFJHHCGFBOO);
		Singleton<GameManager>.Instance.BKDFHECPBCM(OGIIODFJAHD);
		PPPFKGOCMLO();
	}

	public override void DPPBKDMBLHN()
	{
		base.LoadProgress();
		base.GoalProgress = Singleton<SaveSystem>.Instance.DPAGLGGNECO(KHILCMNLMOJ() + " ", 730f);
	}

	public override void LoadProgress()
	{
		base.LoadProgress();
		base.GoalProgress = Singleton<SaveSystem>.Instance.GetFloat(PHPLKBPIMIH() + ".GoalProgress", 0f);
	}

	public override void FGGPLKCGIGO()
	{
		base.FLEONCKOLNB();
		Singleton<SaveSystem>.Instance.KDHMHPPBLIF(KOHBJKHPDGK() + "Messages (shift+tab)", GHDFDFBCJNB());
	}

	public override void MGBFJJJIJPM()
	{
		base.FLEONCKOLNB();
		Singleton<SaveSystem>.Instance.OKOEGLJJHOK(FJFFJLBABDI() + "[ResourcesManager] Load image error: ", GHDFDFBCJNB());
	}

	public override void KGGEDALAKDA(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.KJJMJJJEGDB(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.IJANEODJFIG(ODKKJODPBMI);
		Singleton<GameManager>.Instance.BKDFHECPBCM(ODKKJODPBMI);
		PPPFKGOCMLO();
	}

	private void FBGDKGGKFMJ(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.LCBKIGCLPBH(Singleton<LuaEnvironment>.Instance.BHJCFDLIGFJ());
		if (Singleton<LuaEnvironment>.Instance.GEEDHEPEHCJ(base.NOJGGCLPPAM))
		{
			DPIJMEGONOJ(false);
		}
	}

	public override void GJPOCDKINFD()
	{
		Singleton<GameManager>.Instance.GPEKLFBAAGI(OGIIODFJAHD);
		base.KBJAAOIAPCC();
	}

	public override void HJHMCJPPINB()
	{
		base.SaveProgress();
		Singleton<SaveSystem>.Instance.BPJPCGCIFGK(KHILCMNLMOJ() + "settings.volume.game", FBEFEPECHBM());
	}

	public override void BBFFELGLDHE()
	{
		base.LoadProgress();
		base.GoalProgress = Singleton<SaveSystem>.Instance.DPAGLGGNECO(ADHHBPHLCJO() + "_SampleScale", 121f);
	}

	public override void AFMPCOFDHJI()
	{
		Singleton<GameManager>.Instance.OnFinishedMap -= LIIGHENCIFC;
		base.ONLIHAEAHOJ();
	}

	public override void JKILPDLMHMN(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.KHMFEHEPGAM(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.IJANEODJFIG(LIIGHENCIFC);
		Singleton<GameManager>.Instance.OnFinishedMap += HKIMIGKDJML;
		DFBDPJGHEEK();
	}

	private void LIIGHENCIFC(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.CopyValues(Singleton<LuaEnvironment>.Instance.BHJCFDLIGFJ());
		if (Singleton<LuaEnvironment>.Instance.AMPMFFNDBMB(IGCNBLBAAAK()))
		{
			DPIJMEGONOJ(false);
		}
	}

	public override void SaveProgress()
	{
		base.SaveProgress();
		Singleton<SaveSystem>.Instance.SetFloat(PHPLKBPIMIH() + ".GoalProgress", base.GoalProgress);
	}

	public override void BOGGKCBDLJH()
	{
		base.DFBDPJGHEEK();
		JKINKBKCGFP(Singleton<SaveSystem>.Instance.PGKJAIODCEF(FJFFJLBABDI() + "_Value", 449f));
	}

	public override void ILPNDHPCELH()
	{
		base.OMENGFPFDLL();
		Singleton<SaveSystem>.Instance.FNBPKFMKJFO(FJFFJLBABDI() + "CameraFilterPack/NightVision_4", GHDFDFBCJNB());
	}

	public override void HHACHIOIAEK(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.KHMFEHEPGAM(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.OnFinishedMap -= JFJHHCGFBOO;
		Singleton<GameManager>.Instance.IALDPMHMMAJ(OGIIODFJAHD);
		PPPFKGOCMLO();
	}

	public override void JOABPMBAHCA()
	{
		base.LoadProgress();
		base.GoalProgress = Singleton<SaveSystem>.Instance.GetFloat(BGOBKCLKJMD() + "float,10", 307f);
	}

	public override void NHFICNGICBA()
	{
		base.OPDGBIPHKGC();
		Singleton<SaveSystem>.Instance.OKOEGLJJHOK(PHPLKBPIMIH() + "Set Sun Input", LIDCEAOBMAF());
	}

	public override void OPDGBIPHKGC()
	{
		base.FLEONCKOLNB();
		Singleton<SaveSystem>.Instance.KDHMHPPBLIF(KHILCMNLMOJ() + "powerup.1", FBEFEPECHBM());
	}

	public override void DOKEOBBOHEL()
	{
		Singleton<GameManager>.Instance.GPEKLFBAAGI(OGIIODFJAHD);
		base.IPAILGLGGKK();
	}

	public override void NNMICPOJGPD()
	{
		base.SaveProgress();
		Singleton<SaveSystem>.Instance.OKOEGLJJHOK(KHILCMNLMOJ() + "Value", LIDCEAOBMAF());
	}

	public override void AKAIIFMFEOH()
	{
		base.LoadProgress();
		NHENNCOILPG(Singleton<SaveSystem>.Instance.HCNELAJLBPC(BGOBKCLKJMD() + "_ScreenResolution", 433f));
	}

	private void JFJHHCGFBOO(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.GCJEPNMMPDK(Singleton<LuaEnvironment>.Instance.MBBENLGCION());
		if (Singleton<LuaEnvironment>.Instance.IAKGIOHHEKN(MFLLPADMCIN()))
		{
			NBIPNNIDDLC(true);
		}
	}

	public override void PLCBPLLCNIC(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.HAPELGDNDFN(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.OnFinishedMap -= FBGDKGGKFMJ;
		Singleton<GameManager>.Instance.IALDPMHMMAJ(LIIGHENCIFC);
		EMDHDEGLPPF();
	}

	public override void OKDKEJEJJAN()
	{
		Singleton<GameManager>.Instance.OnFinishedMap -= FBGDKGGKFMJ;
		base.IPAILGLGGKK();
	}

	public override void EAJBKDEOBLE(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.DPIDHAFMFGG(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.IJANEODJFIG(ODKKJODPBMI);
		Singleton<GameManager>.Instance.OnFinishedMap += HOGJGGGDPDD;
		EMDHDEGLPPF();
	}

	public override void OHBHMNMCEGL()
	{
		base.SaveProgress();
		Singleton<SaveSystem>.Instance.FNBPKFMKJFO(BGOBKCLKJMD() + "/", LIDCEAOBMAF());
	}

	public override void NHDLPBMMEDK(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.NOFLEDOPHMO(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.IJANEODJFIG(JFJHHCGFBOO);
		Singleton<GameManager>.Instance.OnFinishedMap += JFJHHCGFBOO;
		PPPFKGOCMLO();
	}

	public override void LOMENLJBNLK()
	{
		Singleton<GameManager>.Instance.IJANEODJFIG(LIIGHENCIFC);
		base.JNLJADDKPAI();
	}

	public override void KAHKKLGKLLF()
	{
		base.OPDGBIPHKGC();
		Singleton<SaveSystem>.Instance.FNBPKFMKJFO(KHILCMNLMOJ() + "DPADHOR", FBEFEPECHBM());
	}

	public override void HOPMBFHOAII()
	{
		Singleton<GameManager>.Instance.GPEKLFBAAGI(HKIMIGKDJML);
		base.IPAILGLGGKK();
	}

	public override void OJGLANCHIPN()
	{
		base.PPPFKGOCMLO();
		NHENNCOILPG(Singleton<SaveSystem>.Instance.GetFloat(IKLKPAJBHGB() + "_TimeX", 3f));
	}

	public override void MBLDJHOBIMG(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.DPIDHAFMFGG(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.OnFinishedMap -= LIIGHENCIFC;
		Singleton<GameManager>.Instance.BKDFHECPBCM(LIIGHENCIFC);
		DFBDPJGHEEK();
	}

	public override void LJOEJPOJPGH(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.NOFLEDOPHMO(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.IJANEODJFIG(HOGJGGGDPDD);
		Singleton<GameManager>.Instance.BKDFHECPBCM(HOGJGGGDPDD);
		DFBDPJGHEEK();
	}

	public override void BCLMEEAMAEB(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.GKCOBIILKMA(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.OnFinishedMap -= JFJHHCGFBOO;
		Singleton<GameManager>.Instance.IALDPMHMMAJ(LIIGHENCIFC);
		PPPFKGOCMLO();
	}

	public override void ELCONNKPDJG()
	{
		Singleton<GameManager>.Instance.OnFinishedMap -= HKIMIGKDJML;
		base.KHECALMHGKE();
	}

	public override void NHKOCDNCIJB()
	{
		Singleton<GameManager>.Instance.IJANEODJFIG(FBGDKGGKFMJ);
		base.ONLIHAEAHOJ();
	}

	private void HKIMIGKDJML(FinishedMapInfo DAGALCAILLN)
	{
		DAGALCAILLN.LCBKIGCLPBH(Singleton<LuaEnvironment>.Instance.FMI);
		if (Singleton<LuaEnvironment>.Instance.CheckFinishedMapCondition(LINMBCLGDJC()))
		{
			base.IsComplete = true;
		}
	}

	public override void KEJGDALCJHP()
	{
		base.PPPFKGOCMLO();
		JKINKBKCGFP(Singleton<SaveSystem>.Instance.GetFloat(IKLKPAJBHGB() + "_Value", 1836f));
	}

	public override void NMFBGKMIHFA()
	{
		Singleton<GameManager>.Instance.IJANEODJFIG(JFJHHCGFBOO);
		base.NHKOCDNCIJB();
	}

	public override void OKBEBBKCBOA()
	{
		base.LoadProgress();
		base.GoalProgress = Singleton<SaveSystem>.Instance.GetFloat(IKLKPAJBHGB() + "menu.enableselectormusic", 1408f);
	}

	public override void EEMAOPDAGLE(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		base.NGLEHMAEEKL(CENMLCAACBF, KCMHIDFJNKB, NOJGGCLPPAM);
		Singleton<GameManager>.Instance.GPEKLFBAAGI(HKIMIGKDJML);
		Singleton<GameManager>.Instance.BKDFHECPBCM(HOGJGGGDPDD);
		EMDHDEGLPPF();
	}
}
