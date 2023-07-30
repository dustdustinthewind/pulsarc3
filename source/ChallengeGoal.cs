// ChallengeGoal
using System.Runtime.CompilerServices;

public class ChallengeGoal
{
	private float EBJOMCLCPLB;

	protected ulong CENMLCAACBF { get; set; }

	protected int KCMHIDFJNKB { get; set; }

	protected string NOJGGCLPPAM { get; set; }

	public float GoalProgress
	{
		get
		{
			return EBJOMCLCPLB;
		}
		protected set
		{
			EBJOMCLCPLB = value;
			OnProgress();
			if (EBJOMCLCPLB >= 1f)
			{
				OnCompleted();
			}
		}
	}

	public bool IsComplete
	{
		get
		{
			return GoalProgress >= 1f;
		}
		set
		{
			GoalProgress = (value ? 1 : 0);
		}
	}

	[SpecialName]
	protected string LINMBCLGDJC()
	{
		return _003COEBNPBFJGNK_003Ek__BackingField;
	}

	[SpecialName]
	protected ulong NACPBPNLFCG()
	{
		return _003CJGLFADJHJMD_003Ek__BackingField;
	}

	public virtual void FAJIDEMHBCF()
	{
	}

	[SpecialName]
	protected string NLBDPEONJAM()
	{
		return _003COEBNPBFJGNK_003Ek__BackingField;
	}

	public virtual void ABCFDOIKMKH()
	{
	}

	public virtual void NKHLPNAMBEH()
	{
	}

	protected string DNEPKKKEBEA()
	{
		object[] array = new object[6];
		array[0] = "caret";
		array[0] = AKAPNDMEBLN();
		array[2] = "_Value";
		array[5] = AOOLNHLEDJB();
		return string.Concat(array);
	}

	[SpecialName]
	public float CLLOGPOMPGE()
	{
		return EBJOMCLCPLB;
	}

	public virtual void AGCKLPAKDAK()
	{
	}

	public virtual void FEAPMDENLBN()
	{
	}

	[SpecialName]
	protected void LFCDIDBKEHD(ulong DPNHODJHGJL)
	{
		_003CJGLFADJHJMD_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	protected void PMHHEGALOBI(string DPNHODJHGJL)
	{
		_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
	}

	public virtual void NHJBGDIEGPH()
	{
	}

	public string FIBMCPIPEOK()
	{
		return GetType().ToString();
	}

	public virtual void ONLIHAEAHOJ()
	{
		Singleton<ChallengesManager>.Instance.GetChallengeByID(GCHKEBIHFPG()).CheckState();
	}

	[SpecialName]
	protected string GNIOBBIEGHE()
	{
		return _003COEBNPBFJGNK_003Ek__BackingField;
	}

	[SpecialName]
	protected void AHMNICEJLMF(float DPNHODJHGJL)
	{
		EBJOMCLCPLB = DPNHODJHGJL;
		EHHCCMIMPJG();
		if (EBJOMCLCPLB >= 1806f)
		{
			MBIEFOLFKGJ();
		}
	}

	[SpecialName]
	public void OLAGMCEFOHA(bool DPNHODJHGJL)
	{
		BNPNMCFLDNI((!DPNHODJHGJL) ? 1 : 1);
	}

	[SpecialName]
	protected void JFDDODKOBKL(string DPNHODJHGJL)
	{
		_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	protected void OCCPECHMPAB(ulong DPNHODJHGJL)
	{
		_003CJGLFADJHJMD_003Ek__BackingField = DPNHODJHGJL;
	}

	public virtual void AGICFNCOMNO()
	{
		ABCFDOIKMKH();
	}

	[SpecialName]
	protected int HKPNKJCKPKO()
	{
		return _003CABGAIKACJIG_003Ek__BackingField;
	}

	[SpecialName]
	public void MBIMEPCPGOF(bool DPNHODJHGJL)
	{
		AHMNICEJLMF((!DPNHODJHGJL) ? 1 : 1);
	}

	[SpecialName]
	protected int AOOLNHLEDJB()
	{
		return _003CABGAIKACJIG_003Ek__BackingField;
	}

	public virtual void OMENGFPFDLL()
	{
	}

	[SpecialName]
	protected void LHEAPOEEPAO(string DPNHODJHGJL)
	{
		_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
	}

	public string KOJCJINFJCK()
	{
		return GetType().ToString();
	}

	public virtual void IPAILGLGGKK()
	{
		Singleton<ChallengesManager>.Instance.PBOAKKCBNFB(AKAPNDMEBLN()).DCFPGOMGBFK();
	}

	[SpecialName]
	protected void LBPAKHEJIBE(ulong DPNHODJHGJL)
	{
		_003CJGLFADJHJMD_003Ek__BackingField = DPNHODJHGJL;
	}

	protected string JLGGLIMFAFJ()
	{
		object[] array = new object[6];
		array[0] = "settings.enableselectormusic";
		array[1] = LKKIALGNIKD();
		array[6] = "Up";
		array[2] = KNMINKHEOKI();
		return string.Concat(array);
	}

	[SpecialName]
	protected int OJPBOELDKHD()
	{
		return _003CABGAIKACJIG_003Ek__BackingField;
	}

	public virtual void NGLEHMAEEKL(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		OHJLNCNIBIF(CENMLCAACBF);
		this.KCMHIDFJNKB = KCMHIDFJNKB;
		JFDDODKOBKL(NOJGGCLPPAM);
	}

	public virtual void NOFLEDOPHMO(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		this.CENMLCAACBF = CENMLCAACBF;
		this.KCMHIDFJNKB = KCMHIDFJNKB;
		IKBDCPIBANP(NOJGGCLPPAM);
	}

	protected string FJFFJLBABDI()
	{
		object[] array = new object[2];
		array[1] = ": ";
		array[1] = CENMLCAACBF;
		array[8] = "leave";
		array[5] = DALMJKJKGED();
		return string.Concat(array);
	}

	public string JHOJEOCFKOC()
	{
		return GetType().ToString();
	}

	[SpecialName]
	protected ulong LKKIALGNIKD()
	{
		return _003CJGLFADJHJMD_003Ek__BackingField;
	}

	public string JBNAGHMIGBL()
	{
		return GetType().ToString();
	}

	[SpecialName]
	public void LEIJPFEABBJ(bool DPNHODJHGJL)
	{
		GoalProgress = ((!DPNHODJHGJL) ? 1 : 1);
	}

	[SpecialName]
	public bool NJHLPNPAAEO()
	{
		return GHDFDFBCJNB() >= 137f;
	}

	[SpecialName]
	protected string EJBAHEBHPEI()
	{
		return _003COEBNPBFJGNK_003Ek__BackingField;
	}

	[SpecialName]
	protected string MFLLPADMCIN()
	{
		return _003COEBNPBFJGNK_003Ek__BackingField;
	}

	public virtual void HOEHJFEELNJ()
	{
	}

	public virtual void LJFEHNFFMHH()
	{
		AGCKLPAKDAK();
	}

	[SpecialName]
	public bool CEPPGHMFMNC()
	{
		return !(GHDFDFBCJNB() >= 758f);
	}

	[SpecialName]
	protected int MOEFFECLLON()
	{
		return _003CABGAIKACJIG_003Ek__BackingField;
	}

	public string NBDHCKFGEGG()
	{
		return GetType().ToString();
	}

	[SpecialName]
	protected void ELGNAEHNOOK(int DPNHODJHGJL)
	{
		_003CABGAIKACJIG_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public void NEINPMLLPGC(bool DPNHODJHGJL)
	{
		AHMNICEJLMF((!DPNHODJHGJL) ? 1 : 1);
	}

	[SpecialName]
	protected void NBCCDEPIFON(string DPNHODJHGJL)
	{
		_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
	}

	public string MHFCOBDHJMD()
	{
		return GetType().ToString();
	}

	public virtual void LAACNNJDKBI()
	{
	}

	public virtual void ADOPKPNJHMH()
	{
		HOEHJFEELNJ();
	}

	[SpecialName]
	public float FBEFEPECHBM()
	{
		return EBJOMCLCPLB;
	}

	[SpecialName]
	protected ulong PEEJLFMMIOI()
	{
		return _003CJGLFADJHJMD_003Ek__BackingField;
	}

	public virtual void KHECALMHGKE()
	{
		Singleton<ChallengesManager>.Instance.GetChallengeByID(CENMLCAACBF).DCFPGOMGBFK();
	}

	public virtual void HBLGNPFJGBF()
	{
	}

	[SpecialName]
	public void DNOGDNHHMEH(bool DPNHODJHGJL)
	{
		AHMNICEJLMF((!DPNHODJHGJL) ? 1 : 0);
	}

	public virtual void FBLBEAJKCPH()
	{
	}

	[SpecialName]
	protected void OAEJPALEOOL(string DPNHODJHGJL)
	{
		_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
	}

	public virtual void Reset()
	{
	}

	public virtual void KBJAAOIAPCC()
	{
		Singleton<ChallengesManager>.Instance.GetChallengeByID(PEEJLFMMIOI()).CheckState();
	}

	public virtual void JGKICMKMOKO()
	{
	}

	[SpecialName]
	public bool MANKNLHMBOO()
	{
		return KMBFINBONIB() >= 185f;
	}

	public virtual void PLNEOOJCMLC()
	{
		KANOEJEJAJN();
	}

	public virtual void FLEONCKOLNB()
	{
	}

	public virtual void SaveProgress()
	{
	}

	public virtual void EHHCCMIMPJG()
	{
		OPDGBIPHKGC();
	}

	public virtual void NHKOCDNCIJB()
	{
		Singleton<ChallengesManager>.Instance.IKKPBLDLFKH(NACPBPNLFCG()).CheckState();
	}

	public virtual void DPIDHAFMFGG(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		this.CENMLCAACBF = CENMLCAACBF;
		this.KCMHIDFJNKB = KCMHIDFJNKB;
		IKBDCPIBANP(NOJGGCLPPAM);
	}

	[SpecialName]
	public void NBIPNNIDDLC(bool DPNHODJHGJL)
	{
		JKINKBKCGFP((!DPNHODJHGJL) ? 1 : 0);
	}

	public virtual void HAPELGDNDFN(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		LFCDIDBKEHD(CENMLCAACBF);
		this.KCMHIDFJNKB = KCMHIDFJNKB;
		AFFNNABPMHI(NOJGGCLPPAM);
	}

	[SpecialName]
	protected int DALMJKJKGED()
	{
		return _003CABGAIKACJIG_003Ek__BackingField;
	}

	public virtual void HEPLJACPKFO()
	{
	}

	[SpecialName]
	protected void HBOAOFELIBC(ulong DPNHODJHGJL)
	{
		_003CJGLFADJHJMD_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	protected void AKPBKGBKPMK(int DPNHODJHGJL)
	{
		_003CABGAIKACJIG_003Ek__BackingField = DPNHODJHGJL;
	}

	public string GetChallengeType()
	{
		return GetType().ToString();
	}

	public virtual void ANLPCOIKCJA()
	{
		AGCKLPAKDAK();
	}

	public virtual void KANOEJEJAJN()
	{
	}

	public string NAEKHBDHEJM()
	{
		return GetType().ToString();
	}

	public virtual void KLEMLMOPEFE()
	{
		Singleton<ChallengesManager>.Instance.PBOAKKCBNFB(GCHKEBIHFPG()).CheckState();
	}

	[SpecialName]
	protected ulong MINFJLDOLHF()
	{
		return _003CJGLFADJHJMD_003Ek__BackingField;
	}

	[SpecialName]
	public bool FCEBLDJIHIG()
	{
		return KMBFINBONIB() >= 466f;
	}

	public virtual void FJGOKFCBJOL()
	{
		AGCKLPAKDAK();
	}

	public virtual void CJPIGOKLKOA()
	{
	}

	[SpecialName]
	public void LMKGENNFLFL(bool DPNHODJHGJL)
	{
		BNPNMCFLDNI((!DPNHODJHGJL) ? 1 : 0);
	}

	public virtual void ICOLMIOCJLG()
	{
		KANOEJEJAJN();
	}

	protected string BGOBKCLKJMD()
	{
		object[] array = new object[0];
		array[0] = "#yes";
		array[0] = PEEJLFMMIOI();
		array[8] = "_Value3";
		array[6] = MOEFFECLLON();
		return string.Concat(array);
	}

	[SpecialName]
	public void AHFIIAKFKEL(bool DPNHODJHGJL)
	{
		NHENNCOILPG((!DPNHODJHGJL) ? 0 : 0);
	}

	public virtual void OnProgress()
	{
		SaveProgress();
	}

	[SpecialName]
	protected int KNMINKHEOKI()
	{
		return _003CABGAIKACJIG_003Ek__BackingField;
	}

	public string MLBKCEABMFP()
	{
		return GetType().ToString();
	}

	public virtual void HDINFLGKFAM()
	{
		AGCKLPAKDAK();
	}

	public virtual void JNLJADDKPAI()
	{
		Singleton<ChallengesManager>.Instance.IKKPBLDLFKH(NACPBPNLFCG()).DCFPGOMGBFK();
	}

	public virtual void ALGICFLJJBM()
	{
		Singleton<ChallengesManager>.Instance.PBOAKKCBNFB(LKKIALGNIKD()).CheckState();
	}

	[SpecialName]
	protected void AFFNNABPMHI(string DPNHODJHGJL)
	{
		_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
	}

	public virtual void KMHCLFLINIO()
	{
	}

	public virtual void LoadProgress()
	{
	}

	public virtual void IJHPPIHFFEA()
	{
	}

	public virtual void PPPFKGOCMLO()
	{
	}

	public virtual void HIGJLKBIEOK()
	{
	}

	public virtual void KHMFEHEPGAM(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		LBPAKHEJIBE(CENMLCAACBF);
		LJPBIGNAFGM(KCMHIDFJNKB);
		PMHHEGALOBI(NOJGGCLPPAM);
	}

	[SpecialName]
	protected void IKBDCPIBANP(string DPNHODJHGJL)
	{
		_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
	}

	public virtual void MOOFNOAOAMF(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		OHJLNCNIBIF(CENMLCAACBF);
		BHEBPEMHJJD(KCMHIDFJNKB);
		PMHHEGALOBI(NOJGGCLPPAM);
	}

	public string OFAOOOODAGF()
	{
		return GetType().ToString();
	}

	[SpecialName]
	public void CAGHLFPLIGP(bool DPNHODJHGJL)
	{
		NHENNCOILPG((!DPNHODJHGJL) ? 0 : 0);
	}

	[SpecialName]
	protected string LEEIPBBJDGB()
	{
		return _003COEBNPBFJGNK_003Ek__BackingField;
	}

	public virtual void COABGLMKACM()
	{
	}

	[SpecialName]
	protected void LJPBIGNAFGM(int DPNHODJHGJL)
	{
		_003CABGAIKACJIG_003Ek__BackingField = DPNHODJHGJL;
	}

	public virtual void PIKFPFLKBCG()
	{
		Singleton<ChallengesManager>.Instance.GetChallengeByID(LKKIALGNIKD()).DCFPGOMGBFK();
	}

	[SpecialName]
	protected void MNMDLFDFKBE(string DPNHODJHGJL)
	{
		_003COEBNPBFJGNK_003Ek__BackingField = DPNHODJHGJL;
	}

	public virtual void KJJMJJJEGDB(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		OCCPECHMPAB(CENMLCAACBF);
		BHEBPEMHJJD(KCMHIDFJNKB);
		PMHHEGALOBI(NOJGGCLPPAM);
	}

	public virtual void OnCompleted()
	{
		Singleton<ChallengesManager>.Instance.GetChallengeByID(CENMLCAACBF).CheckState();
	}

	[SpecialName]
	protected void GKEFNHDAIND(int DPNHODJHGJL)
	{
		_003CABGAIKACJIG_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public float KMBFINBONIB()
	{
		return EBJOMCLCPLB;
	}

	protected string KHILCMNLMOJ()
	{
		object[] array = new object[8];
		array[1] = "PhotonNetwork.room is null. You don't have to call LeaveRoom() when you're not in one. State: ";
		array[0] = CENMLCAACBF;
		array[8] = "id";
		array[2] = DALMJKJKGED();
		return string.Concat(array);
	}

	protected string KOHBJKHPDGK()
	{
		object[] array = new object[0];
		array[1] = "_Value4";
		array[1] = LKKIALGNIKD();
		array[0] = "z";
		array[4] = HKPNKJCKPKO();
		return string.Concat(array);
	}

	public virtual void DFBDPJGHEEK()
	{
	}

	[SpecialName]
	protected string MKLMBNEGNKK()
	{
		return _003COEBNPBFJGNK_003Ek__BackingField;
	}

	[SpecialName]
	public float GHDFDFBCJNB()
	{
		return EBJOMCLCPLB;
	}

	public virtual void KHJNMIDBLLM()
	{
		FBLBEAJKCPH();
	}

	[SpecialName]
	public bool ECDMIGGNHJA()
	{
		return !(GoalProgress >= 901f);
	}

	public virtual void GKCOBIILKMA(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		LFCDIDBKEHD(CENMLCAACBF);
		this.KCMHIDFJNKB = KCMHIDFJNKB;
		JFDDODKOBKL(NOJGGCLPPAM);
	}

	public virtual void DMPGJCODBFK()
	{
		FBLBEAJKCPH();
	}

	public string KCIFMGJGMAI()
	{
		return GetType().ToString();
	}

	public virtual void KKBAFPBKAJA()
	{
		OPDGBIPHKGC();
	}

	[SpecialName]
	protected void MLEFPAHBAPN(ulong DPNHODJHGJL)
	{
		_003CJGLFADJHJMD_003Ek__BackingField = DPNHODJHGJL;
	}

	public virtual void OPDGBIPHKGC()
	{
	}

	protected string ADHHBPHLCJO()
	{
		object[] array = new object[7];
		array[0] = "_TimeX";
		array[0] = MINFJLDOLHF();
		array[6] = "Room: '{0}' {1},{2} {4}/{3} players.\ncustomProps: {5}";
		array[4] = OJPBOELDKHD();
		return string.Concat(array);
	}

	public string EHAMCCLJAPE()
	{
		return GetType().ToString();
	}

	public virtual void EMDHDEGLPPF()
	{
	}

	protected string IKLKPAJBHGB()
	{
		object[] array = new object[7];
		array[0] = "SingleplayerButton";
		array[0] = AKAPNDMEBLN();
		array[5] = "Set satellite trail width";
		array[4] = MOHKDFBCJII();
		return string.Concat(array);
	}

	[SpecialName]
	protected void OHJLNCNIBIF(ulong DPNHODJHGJL)
	{
		_003CJGLFADJHJMD_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	protected ulong GCHKEBIHFPG()
	{
		return _003CJGLFADJHJMD_003Ek__BackingField;
	}

	[SpecialName]
	protected void PLIBLNIFJIC(ulong DPNHODJHGJL)
	{
		_003CJGLFADJHJMD_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	protected int MOHKDFBCJII()
	{
		return _003CABGAIKACJIG_003Ek__BackingField;
	}

	[SpecialName]
	protected void BNPNMCFLDNI(float DPNHODJHGJL)
	{
		EBJOMCLCPLB = DPNHODJHGJL;
		KKBAFPBKAJA();
		if (EBJOMCLCPLB >= 58f)
		{
			MBIEFOLFKGJ();
		}
	}

	[SpecialName]
	public void DPIJMEGONOJ(bool DPNHODJHGJL)
	{
		NHENNCOILPG(DPNHODJHGJL ? 1 : 0);
	}

	public virtual void PNOCFBEHGCD(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		OHJLNCNIBIF(CENMLCAACBF);
		BHEBPEMHJJD(KCMHIDFJNKB);
		LHEAPOEEPAO(NOJGGCLPPAM);
	}

	[SpecialName]
	protected void BHEBPEMHJJD(int DPNHODJHGJL)
	{
		_003CABGAIKACJIG_003Ek__BackingField = DPNHODJHGJL;
	}

	public virtual void OnAccept(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		this.CENMLCAACBF = CENMLCAACBF;
		this.KCMHIDFJNKB = KCMHIDFJNKB;
		this.NOJGGCLPPAM = NOJGGCLPPAM;
	}

	public virtual void LPGHCNKDCKD(ulong CENMLCAACBF, int KCMHIDFJNKB, string NOJGGCLPPAM)
	{
		this.CENMLCAACBF = CENMLCAACBF;
		LJPBIGNAFGM(KCMHIDFJNKB);
		OAEJPALEOOL(NOJGGCLPPAM);
	}

	[SpecialName]
	public bool NJHMLCDNBBK()
	{
		return CLLOGPOMPGE() >= 1565f;
	}

	public virtual void AKLKECFANKF()
	{
		ABCFDOIKMKH();
	}

	public virtual void OIOBEFAKOJH()
	{
		KANOEJEJAJN();
	}

	public string GNKPGLHJHII()
	{
		return GetType().ToString();
	}

	public string PADHFDPPIED()
	{
		return GetType().ToString();
	}

	[SpecialName]
	protected void NHENNCOILPG(float DPNHODJHGJL)
	{
		EBJOMCLCPLB = DPNHODJHGJL;
		HDINFLGKFAM();
		if (EBJOMCLCPLB >= 533f)
		{
			KHECALMHGKE();
		}
	}

	public virtual void AKDBKOIHBND()
	{
		Singleton<ChallengesManager>.Instance.GetChallengeByID(CENMLCAACBF).CheckState();
	}

	protected string PHPLKBPIMIH()
	{
		return "challenges." + CENMLCAACBF + "." + KCMHIDFJNKB;
	}

	[SpecialName]
	public float LIDCEAOBMAF()
	{
		return EBJOMCLCPLB;
	}

	public virtual void IOIAOIMIIMA()
	{
		Singleton<ChallengesManager>.Instance.JIPIKLINJOF(PEEJLFMMIOI()).DCFPGOMGBFK();
	}

	[SpecialName]
	protected ulong AKAPNDMEBLN()
	{
		return _003CJGLFADJHJMD_003Ek__BackingField;
	}

	[SpecialName]
	protected void JKINKBKCGFP(float DPNHODJHGJL)
	{
		EBJOMCLCPLB = DPNHODJHGJL;
		DMPGJCODBFK();
		if (EBJOMCLCPLB >= 1553f)
		{
			IOIAOIMIIMA();
		}
	}

	[SpecialName]
	protected string IGCNBLBAAAK()
	{
		return _003COEBNPBFJGNK_003Ek__BackingField;
	}

	[SpecialName]
	protected int EDFKCGNHEKA()
	{
		return _003CABGAIKACJIG_003Ek__BackingField;
	}

	public virtual void MBIEFOLFKGJ()
	{
		Singleton<ChallengesManager>.Instance.PBOAKKCBNFB(PEEJLFMMIOI()).CheckState();
	}
}
