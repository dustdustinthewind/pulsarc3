// FinishedMapInfo
using System;
using System.Runtime.CompilerServices;
using MoonSharp.Interpreter;

[Serializable]
[MoonSharpUserData]
public class FinishedMapInfo
{
	public string mapid { get; set; }

	public float mapdifficulty { get; set; }

	public string maptags { get; set; }

	public int handsCount { get; set; }

	public string mapper { get; set; }

	public bool isofficial { get; set; }

	public bool isloved { get; set; }

	public bool isfunny { get; set; }

	public bool completed { get; set; }

	public bool isstoryboardactive { get; set; }

	public bool ismultiplayer { get; set; }

	public int multiplayerplayers { get; set; }

	public int multiplayerplace { get; set; }

	public int gamemode { get; set; }

	public int loopscount { get; set; }

	public float accuracy { get; set; }

	public int score { get; set; }

	public int perfecthits { get; set; }

	public int misses { get; set; }

	public float time { get; set; }

	[SpecialName]
	public int OLHBOHICOLF()
	{
		return multiplayerplayers;
	}

	[SpecialName]
	public void DFAEGIMMLJG(string DPNHODJHGJL)
	{
		maptags = DPNHODJHGJL;
	}

	[SpecialName]
	public void HCDIHFPNKEN(bool DPNHODJHGJL)
	{
		isloved = DPNHODJHGJL;
	}

	[SpecialName]
	public void PKMEGDEOBIH(int DPNHODJHGJL)
	{
		score = DPNHODJHGJL;
	}

	[SpecialName]
	public int GMPLCDJGDKB()
	{
		return multiplayerplayers;
	}

	[SpecialName]
	public void HIKNMAFMEGN(float DPNHODJHGJL)
	{
		time = DPNHODJHGJL;
	}

	[SpecialName]
	public void NCIOHFAJOBI(string DPNHODJHGJL)
	{
		mapid = DPNHODJHGJL;
	}

	[SpecialName]
	public int HEHHJEDIMAK()
	{
		return handsCount;
	}

	[SpecialName]
	public bool PBKHDLKMBJB()
	{
		return isofficial;
	}

	[SpecialName]
	public void OGGLFCDKJBE(bool DPNHODJHGJL)
	{
		isloved = DPNHODJHGJL;
	}

	[SpecialName]
	public string CNDPCBFHCAG()
	{
		return maptags;
	}

	public void GKMPDFNEKJI(FinishedMapInfo CDJGIKGAFOD)
	{
		CDJGIKGAFOD.mapid = mapid;
		CDJGIKGAFOD.mapdifficulty = mapdifficulty;
		CDJGIKGAFOD.DFAEGIMMLJG(maptags);
		CDJGIKGAFOD.handsCount = HEHHJEDIMAK();
		CDJGIKGAFOD.mapper = MBODFMKMDBF();
		CDJGIKGAFOD.IGCKBAONHGA(isofficial);
		CDJGIKGAFOD.isloved = isloved;
		CDJGIKGAFOD.isfunny = GCDCEHIODNO();
		CDJGIKGAFOD.completed = completed;
		CDJGIKGAFOD.PNDEPBDCKKO(isstoryboardactive);
		CDJGIKGAFOD.ismultiplayer = FMADLJCGDMA();
		CDJGIKGAFOD.multiplayerplayers = multiplayerplayers;
		CDJGIKGAFOD.multiplayerplace = multiplayerplace;
		CDJGIKGAFOD.multiplayerplayers = multiplayerplayers;
		CDJGIKGAFOD.gamemode = gamemode;
		CDJGIKGAFOD.loopscount = FCLAGGGFPMH();
		CDJGIKGAFOD.accuracy = EIBKCHCPPKG();
		CDJGIKGAFOD.PKMEGDEOBIH(LMGJOMCGAGL());
		CDJGIKGAFOD.CPHGKPFLIDE(GAALNMAAGMA());
		CDJGIKGAFOD.misses = MFBIIFFEBCG();
		CDJGIKGAFOD.HIKNMAFMEGN(FMLMKCNAEKP());
	}

	[SpecialName]
	public int NJAJMNFNKBB()
	{
		return handsCount;
	}

	[SpecialName]
	public string OBKIKPLGGGH()
	{
		return mapper;
	}

	[SpecialName]
	public void LAGKGACCGBI(int DPNHODJHGJL)
	{
		handsCount = DPNHODJHGJL;
	}

	[SpecialName]
	public void IGCKBAONHGA(bool DPNHODJHGJL)
	{
		isofficial = DPNHODJHGJL;
	}

	[SpecialName]
	public bool JMKANIFLHEF()
	{
		return completed;
	}

	public void AEANKENFIDD(FinishedMapInfo CDJGIKGAFOD)
	{
		CDJGIKGAFOD.mapid = mapid;
		CDJGIKGAFOD.ABNOACNJLJG(BFLKPJGCJAB());
		CDJGIKGAFOD.maptags = CNDPCBFHCAG();
		CDJGIKGAFOD.LAGKGACCGBI(NJAJMNFNKBB());
		CDJGIKGAFOD.mapper = MBODFMKMDBF();
		CDJGIKGAFOD.IGCKBAONHGA(isofficial);
		CDJGIKGAFOD.HCDIHFPNKEN(isloved);
		CDJGIKGAFOD.isfunny = KIECDBIPADM();
		CDJGIKGAFOD.completed = CPHKMHKMFPE();
		CDJGIKGAFOD.PNDEPBDCKKO(isstoryboardactive);
		CDJGIKGAFOD.ismultiplayer = ismultiplayer;
		CDJGIKGAFOD.multiplayerplayers = ODLDNPPDIKE();
		CDJGIKGAFOD.multiplayerplace = multiplayerplace;
		CDJGIKGAFOD.multiplayerplayers = LKIMMFDLCOA();
		CDJGIKGAFOD.AIBKCDNFAAG(gamemode);
		CDJGIKGAFOD.loopscount = NKIPBLLHHBN();
		CDJGIKGAFOD.accuracy = EIBKCHCPPKG();
		CDJGIKGAFOD.GFOAKJOLJDP(LMGJOMCGAGL());
		CDJGIKGAFOD.CPHGKPFLIDE(GAALNMAAGMA());
		CDJGIKGAFOD.OBKMGIPPBCJ(MFABIKMCLHC());
		CDJGIKGAFOD.time = time;
	}

	[SpecialName]
	public void NLMLEGJAEJC(bool DPNHODJHGJL)
	{
		isofficial = DPNHODJHGJL;
	}

	[SpecialName]
	public int LMGJOMCGAGL()
	{
		return score;
	}

	[SpecialName]
	public void IBJAHDCDHKH(bool DPNHODJHGJL)
	{
		completed = DPNHODJHGJL;
	}

	[SpecialName]
	public void INMHOFPBLAB(bool DPNHODJHGJL)
	{
		isloved = DPNHODJHGJL;
	}

	[SpecialName]
	public int OOGDAKDPNDC()
	{
		return multiplayerplayers;
	}

	[SpecialName]
	public void ALPBACEOLHK(int DPNHODJHGJL)
	{
		score = DPNHODJHGJL;
	}

	[SpecialName]
	public string KJHLNENOIGI()
	{
		return mapper;
	}

	[SpecialName]
	public bool FMADLJCGDMA()
	{
		return ismultiplayer;
	}

	[SpecialName]
	public float BFLKPJGCJAB()
	{
		return mapdifficulty;
	}

	[SpecialName]
	public int BJOGJJFKHHH()
	{
		return misses;
	}

	[SpecialName]
	public bool NMGIIOPOMEK()
	{
		return isloved;
	}

	[SpecialName]
	public void EICMGIEKGIH(int DPNHODJHGJL)
	{
		handsCount = DPNHODJHGJL;
	}

	[SpecialName]
	public void OMOBMDJMNHN(int DPNHODJHGJL)
	{
		perfecthits = DPNHODJHGJL;
	}

	public void LCBKIGCLPBH(FinishedMapInfo CDJGIKGAFOD)
	{
		CDJGIKGAFOD.GDPIBNNMIGC(mapid);
		CDJGIKGAFOD.mapdifficulty = MIHLDCLJOHM();
		CDJGIKGAFOD.GLNIJNANKME(BDNJEOLDHCK());
		CDJGIKGAFOD.handsCount = NJAJMNFNKBB();
		CDJGIKGAFOD.mapper = MBODFMKMDBF();
		CDJGIKGAFOD.NLMLEGJAEJC(isofficial);
		CDJGIKGAFOD.BAHPLOIFKOF(GECNLGNPDFA());
		CDJGIKGAFOD.isfunny = isfunny;
		CDJGIKGAFOD.IBJAHDCDHKH(JMKANIFLHEF());
		CDJGIKGAFOD.PNDEPBDCKKO(isstoryboardactive);
		CDJGIKGAFOD.ismultiplayer = ismultiplayer;
		CDJGIKGAFOD.multiplayerplayers = OLHBOHICOLF();
		CDJGIKGAFOD.multiplayerplace = multiplayerplace;
		CDJGIKGAFOD.multiplayerplayers = GMPLCDJGDKB();
		CDJGIKGAFOD.gamemode = gamemode;
		CDJGIKGAFOD.loopscount = IBJNCIGGCBI();
		CDJGIKGAFOD.KNDDGKJBIDJ(EIBKCHCPPKG());
		CDJGIKGAFOD.GFOAKJOLJDP(LMGJOMCGAGL());
		CDJGIKGAFOD.OMOBMDJMNHN(perfecthits);
		CDJGIKGAFOD.misses = BJOGJJFKHHH();
		CDJGIKGAFOD.HIKNMAFMEGN(time);
	}

	[SpecialName]
	public int FCLAGGGFPMH()
	{
		return loopscount;
	}

	[SpecialName]
	public string FMOPHPFNGFD()
	{
		return mapper;
	}

	[SpecialName]
	public string MBODFMKMDBF()
	{
		return mapper;
	}

	[SpecialName]
	public void ABNOACNJLJG(float DPNHODJHGJL)
	{
		mapdifficulty = DPNHODJHGJL;
	}

	[SpecialName]
	public void HNLJIEMDIOB(bool DPNHODJHGJL)
	{
		isloved = DPNHODJHGJL;
	}

	[SpecialName]
	public int GAALNMAAGMA()
	{
		return perfecthits;
	}

	[SpecialName]
	public float KBIGOBLILCL()
	{
		return accuracy;
	}

	[SpecialName]
	public int BNJDHEACLEL()
	{
		return handsCount;
	}

	public void BFCMCBBNPOD(FinishedMapInfo CDJGIKGAFOD)
	{
		CDJGIKGAFOD.GDPIBNNMIGC(mapid);
		CDJGIKGAFOD.ABNOACNJLJG(BFLKPJGCJAB());
		CDJGIKGAFOD.maptags = CNDPCBFHCAG();
		CDJGIKGAFOD.LAGKGACCGBI(NJAJMNFNKBB());
		CDJGIKGAFOD.mapper = FMOPHPFNGFD();
		CDJGIKGAFOD.NLMLEGJAEJC(isofficial);
		CDJGIKGAFOD.isloved = NMGIIOPOMEK();
		CDJGIKGAFOD.isfunny = GCDCEHIODNO();
		CDJGIKGAFOD.completed = JMKANIFLHEF();
		CDJGIKGAFOD.isstoryboardactive = isstoryboardactive;
		CDJGIKGAFOD.FPEPFJBBANC(FMADLJCGDMA());
		CDJGIKGAFOD.multiplayerplayers = GMPLCDJGDKB();
		CDJGIKGAFOD.multiplayerplace = multiplayerplace;
		CDJGIKGAFOD.multiplayerplayers = OOGDAKDPNDC();
		CDJGIKGAFOD.gamemode = gamemode;
		CDJGIKGAFOD.loopscount = IBJNCIGGCBI();
		CDJGIKGAFOD.KNDDGKJBIDJ(EHKEJPJPOCG());
		CDJGIKGAFOD.score = LMGJOMCGAGL();
		CDJGIKGAFOD.perfecthits = perfecthits;
		CDJGIKGAFOD.OBKMGIPPBCJ(MFBIIFFEBCG());
		CDJGIKGAFOD.HIKNMAFMEGN(time);
	}

	[SpecialName]
	public void EDOFADAPLLB(int DPNHODJHGJL)
	{
		gamemode = DPNHODJHGJL;
	}

	[SpecialName]
	public void OBKMGIPPBCJ(int DPNHODJHGJL)
	{
		misses = DPNHODJHGJL;
	}

	[SpecialName]
	public float MIHLDCLJOHM()
	{
		return mapdifficulty;
	}

	[SpecialName]
	public void NCFGPDBGCGC(int DPNHODJHGJL)
	{
		score = DPNHODJHGJL;
	}

	[SpecialName]
	public bool KIECDBIPADM()
	{
		return isfunny;
	}

	[SpecialName]
	public void ODKLCAIJPNC(string DPNHODJHGJL)
	{
		mapid = DPNHODJHGJL;
	}

	[SpecialName]
	public void FPEPFJBBANC(bool DPNHODJHGJL)
	{
		ismultiplayer = DPNHODJHGJL;
	}

	[SpecialName]
	public int MFBIIFFEBCG()
	{
		return misses;
	}

	[SpecialName]
	public void GDPIBNNMIGC(string DPNHODJHGJL)
	{
		mapid = DPNHODJHGJL;
	}

	[SpecialName]
	public void OHOGEANBEKM(bool DPNHODJHGJL)
	{
		isloved = DPNHODJHGJL;
	}

	[SpecialName]
	public void KNDDGKJBIDJ(float DPNHODJHGJL)
	{
		accuracy = DPNHODJHGJL;
	}

	[SpecialName]
	public void GFOAKJOLJDP(int DPNHODJHGJL)
	{
		score = DPNHODJHGJL;
	}

	[SpecialName]
	public void PNDEPBDCKKO(bool DPNHODJHGJL)
	{
		isstoryboardactive = DPNHODJHGJL;
	}

	[SpecialName]
	public void BAHPLOIFKOF(bool DPNHODJHGJL)
	{
		isloved = DPNHODJHGJL;
	}

	[SpecialName]
	public int IBJNCIGGCBI()
	{
		return loopscount;
	}

	[SpecialName]
	public bool LMNIKBHCCNJ()
	{
		return ismultiplayer;
	}

	[SpecialName]
	public void CPHGKPFLIDE(int DPNHODJHGJL)
	{
		perfecthits = DPNHODJHGJL;
	}

	[SpecialName]
	public int LKIMMFDLCOA()
	{
		return multiplayerplayers;
	}

	[SpecialName]
	public bool GOGHKDLGAID()
	{
		return isofficial;
	}

	[SpecialName]
	public void BCFCKNPHPID(bool DPNHODJHGJL)
	{
		completed = DPNHODJHGJL;
	}

	[SpecialName]
	public int KMDLAPCGNMJ()
	{
		return misses;
	}

	[SpecialName]
	public int NKIPBLLHHBN()
	{
		return loopscount;
	}

	[SpecialName]
	public int KEOCIFAOAIP()
	{
		return perfecthits;
	}

	[SpecialName]
	public void AIBKCDNFAAG(int DPNHODJHGJL)
	{
		gamemode = DPNHODJHGJL;
	}

	public void CopyValues(FinishedMapInfo CDJGIKGAFOD)
	{
		CDJGIKGAFOD.mapid = mapid;
		CDJGIKGAFOD.mapdifficulty = mapdifficulty;
		CDJGIKGAFOD.maptags = maptags;
		CDJGIKGAFOD.handsCount = handsCount;
		CDJGIKGAFOD.mapper = mapper;
		CDJGIKGAFOD.isofficial = isofficial;
		CDJGIKGAFOD.isloved = isloved;
		CDJGIKGAFOD.isfunny = isfunny;
		CDJGIKGAFOD.completed = completed;
		CDJGIKGAFOD.isstoryboardactive = isstoryboardactive;
		CDJGIKGAFOD.ismultiplayer = ismultiplayer;
		CDJGIKGAFOD.multiplayerplayers = multiplayerplayers;
		CDJGIKGAFOD.multiplayerplace = multiplayerplace;
		CDJGIKGAFOD.multiplayerplayers = multiplayerplayers;
		CDJGIKGAFOD.gamemode = gamemode;
		CDJGIKGAFOD.loopscount = loopscount;
		CDJGIKGAFOD.accuracy = accuracy;
		CDJGIKGAFOD.score = score;
		CDJGIKGAFOD.perfecthits = perfecthits;
		CDJGIKGAFOD.misses = misses;
		CDJGIKGAFOD.time = time;
	}

	[SpecialName]
	public bool CPHKMHKMFPE()
	{
		return completed;
	}

	[SpecialName]
	public void AIHIKELIIFJ(bool DPNHODJHGJL)
	{
		isloved = DPNHODJHGJL;
	}

	[SpecialName]
	public float FMLMKCNAEKP()
	{
		return time;
	}

	[SpecialName]
	public float EHKEJPJPOCG()
	{
		return accuracy;
	}

	[SpecialName]
	public bool GCDCEHIODNO()
	{
		return isfunny;
	}

	[SpecialName]
	public string GLPLOEEHNAP()
	{
		return mapper;
	}

	[SpecialName]
	public int MFABIKMCLHC()
	{
		return misses;
	}

	[SpecialName]
	public string BDNJEOLDHCK()
	{
		return maptags;
	}

	public void HEBPNLNABDP(FinishedMapInfo CDJGIKGAFOD)
	{
		CDJGIKGAFOD.ODKLCAIJPNC(mapid);
		CDJGIKGAFOD.ABNOACNJLJG(MIHLDCLJOHM());
		CDJGIKGAFOD.GLNIJNANKME(CNDPCBFHCAG());
		CDJGIKGAFOD.handsCount = handsCount;
		CDJGIKGAFOD.mapper = GLPLOEEHNAP();
		CDJGIKGAFOD.NLMLEGJAEJC(PBKHDLKMBJB());
		CDJGIKGAFOD.AIHIKELIIFJ(GECNLGNPDFA());
		CDJGIKGAFOD.isfunny = isfunny;
		CDJGIKGAFOD.IBJAHDCDHKH(CPHKMHKMFPE());
		CDJGIKGAFOD.PNDEPBDCKKO(isstoryboardactive);
		CDJGIKGAFOD.ismultiplayer = LMNIKBHCCNJ();
		CDJGIKGAFOD.multiplayerplayers = OLHBOHICOLF();
		CDJGIKGAFOD.multiplayerplace = multiplayerplace;
		CDJGIKGAFOD.multiplayerplayers = multiplayerplayers;
		CDJGIKGAFOD.gamemode = gamemode;
		CDJGIKGAFOD.loopscount = NKIPBLLHHBN();
		CDJGIKGAFOD.KNDDGKJBIDJ(EIBKCHCPPKG());
		CDJGIKGAFOD.ALPBACEOLHK(score);
		CDJGIKGAFOD.OMOBMDJMNHN(perfecthits);
		CDJGIKGAFOD.misses = BJOGJJFKHHH();
		CDJGIKGAFOD.time = time;
	}

	[SpecialName]
	public bool BAFHOBJKFLN()
	{
		return isloved;
	}

	[SpecialName]
	public float EIBKCHCPPKG()
	{
		return accuracy;
	}

	[SpecialName]
	public int ODLDNPPDIKE()
	{
		return multiplayerplayers;
	}

	[SpecialName]
	public void GLNIJNANKME(string DPNHODJHGJL)
	{
		maptags = DPNHODJHGJL;
	}

	[SpecialName]
	public bool GECNLGNPDFA()
	{
		return isloved;
	}
}
