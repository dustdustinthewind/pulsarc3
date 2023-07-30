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
	public int EHJFDBMNBLF()
	{
		return score;
	}

	[SpecialName]
	public void PEIIDGDGBMJ(bool DPNHODJHGJL)
	{
		isloved = DPNHODJHGJL;
	}

	[SpecialName]
	public void NBJNLNEKBKM(bool DPNHODJHGJL)
	{
		ismultiplayer = DPNHODJHGJL;
	}

	[SpecialName]
	public void EFEAKIJBGJJ(int DPNHODJHGJL)
	{
		handsCount = DPNHODJHGJL;
	}

	[SpecialName]
	public void BHLFPEPFGLC(int DPNHODJHGJL)
	{
		score = DPNHODJHGJL;
	}

	[SpecialName]
	public void BAHPHPGJKNH(bool DPNHODJHGJL)
	{
		isofficial = DPNHODJHGJL;
	}

	[SpecialName]
	public float MMKEHHGBODC()
	{
		return mapdifficulty;
	}

	[SpecialName]
	public void BGNOFFFJPOL(int DPNHODJHGJL)
	{
		loopscount = DPNHODJHGJL;
	}

	[SpecialName]
	public string HCDPOIKNDBD()
	{
		return maptags;
	}

	[SpecialName]
	public void ICMIGLKKMGB(int DPNHODJHGJL)
	{
		handsCount = DPNHODJHGJL;
	}

	[SpecialName]
	public string FPKAOFBFCNG()
	{
		return mapid;
	}

	public void NIDBAEKPFOD(FinishedMapInfo CDJGIKGAFOD)
	{
		CDJGIKGAFOD.LECMMNPDAEB(FPKAOFBFCNG());
		CDJGIKGAFOD.mapdifficulty = FBNOEPGJOFE();
		CDJGIKGAFOD.maptags = LGDJOHEANFH();
		CDJGIKGAFOD.EFEAKIJBGJJ(HHGHGCPJPEO());
		CDJGIKGAFOD.mapper = DMKMBMLMEGG();
		CDJGIKGAFOD.KJKDMIFADMP(isofficial);
		CDJGIKGAFOD.isloved = FIICJDMHAKO();
		CDJGIKGAFOD.BEGHGKNFIIO(isfunny);
		CDJGIKGAFOD.KJIANIGMAHL(completed);
		CDJGIKGAFOD.IGAFDMLBICN(AOEIIDNEDNA());
		CDJGIKGAFOD.ismultiplayer = ismultiplayer;
		CDJGIKGAFOD.multiplayerplayers = multiplayerplayers;
		CDJGIKGAFOD.HGKBIBBIOJO(LBEIFJOIECI());
		CDJGIKGAFOD.multiplayerplayers = multiplayerplayers;
		CDJGIKGAFOD.gamemode = APGBPAACDCP();
		CDJGIKGAFOD.LOILCMFNNIK(ADLMHKJENNM());
		CDJGIKGAFOD.accuracy = FCDCFEDGIMI();
		CDJGIKGAFOD.MIFMFDDPDIA(EHJFDBMNBLF());
		CDJGIKGAFOD.perfecthits = perfecthits;
		CDJGIKGAFOD.NBGPOOIKAHC(EANEJLEINKA());
		CDJGIKGAFOD.time = time;
	}

	[SpecialName]
	public void CFGNLNHDGDM(bool DPNHODJHGJL)
	{
		isofficial = DPNHODJHGJL;
	}

	[SpecialName]
	public void BEGHGKNFIIO(bool DPNHODJHGJL)
	{
		isfunny = DPNHODJHGJL;
	}

	[SpecialName]
	public string IKGKNONPHNM()
	{
		return mapper;
	}

	[SpecialName]
	public int BNANJCOEKNP()
	{
		return gamemode;
	}

	[SpecialName]
	public void OBENJJNMPCL(int DPNHODJHGJL)
	{
		gamemode = DPNHODJHGJL;
	}

	[SpecialName]
	public void NEIFJEODIKJ(bool DPNHODJHGJL)
	{
		completed = DPNHODJHGJL;
	}

	[SpecialName]
	public void COJIPONIHHD(bool DPNHODJHGJL)
	{
		isofficial = DPNHODJHGJL;
	}

	[SpecialName]
	public int NMKBDHDPONG()
	{
		return misses;
	}

	[SpecialName]
	public int IBKMHHOKFOB()
	{
		return misses;
	}

	[SpecialName]
	public bool PGLBENNEPHB()
	{
		return isstoryboardactive;
	}

	[SpecialName]
	public bool AOEIIDNEDNA()
	{
		return isstoryboardactive;
	}

	[SpecialName]
	public void NDKIJAACHLH(int DPNHODJHGJL)
	{
		loopscount = DPNHODJHGJL;
	}

	[SpecialName]
	public void HGKBIBBIOJO(int DPNHODJHGJL)
	{
		multiplayerplace = DPNHODJHGJL;
	}

	[SpecialName]
	public int LOIPNPKBCMC()
	{
		return multiplayerplace;
	}

	[SpecialName]
	public void GBMACLIJLBI(int DPNHODJHGJL)
	{
		loopscount = DPNHODJHGJL;
	}

	[SpecialName]
	public bool GDHAIFDLLOC()
	{
		return isloved;
	}

	[SpecialName]
	public float IFNIGBNDJLH()
	{
		return accuracy;
	}

	[SpecialName]
	public void CFAPNLGGNOM(string DPNHODJHGJL)
	{
		mapper = DPNHODJHGJL;
	}

	[SpecialName]
	public string DCFMDKHGGKO()
	{
		return mapper;
	}

	[SpecialName]
	public void KJKDMIFADMP(bool DPNHODJHGJL)
	{
		isofficial = DPNHODJHGJL;
	}

	[SpecialName]
	public void MIFMFDDPDIA(int DPNHODJHGJL)
	{
		score = DPNHODJHGJL;
	}

	[SpecialName]
	public void AAECLNDIEJO(bool DPNHODJHGJL)
	{
		isloved = DPNHODJHGJL;
	}

	[SpecialName]
	public bool HABBDOLBMAN()
	{
		return isstoryboardactive;
	}

	[SpecialName]
	public int EANEJLEINKA()
	{
		return misses;
	}

	[SpecialName]
	public void DCEBDGNIOMI(bool DPNHODJHGJL)
	{
		isfunny = DPNHODJHGJL;
	}

	[SpecialName]
	public string BAGLMCDCJOE()
	{
		return maptags;
	}

	[SpecialName]
	public void NNCAPEAILDJ(float DPNHODJHGJL)
	{
		accuracy = DPNHODJHGJL;
	}

	[SpecialName]
	public void OAOPKANCNNN(int DPNHODJHGJL)
	{
		loopscount = DPNHODJHGJL;
	}

	[SpecialName]
	public int PBFMOGJPMFG()
	{
		return misses;
	}

	[SpecialName]
	public void KJIANIGMAHL(bool DPNHODJHGJL)
	{
		completed = DPNHODJHGJL;
	}

	[SpecialName]
	public void IIPLLJCOOBC(bool DPNHODJHGJL)
	{
		isfunny = DPNHODJHGJL;
	}

	[SpecialName]
	public string GCPHLINHEJN()
	{
		return mapper;
	}

	[SpecialName]
	public void ICIHBFHNCEK(int DPNHODJHGJL)
	{
		multiplayerplace = DPNHODJHGJL;
	}

	[SpecialName]
	public void FLNEADLCNLE(bool DPNHODJHGJL)
	{
		ismultiplayer = DPNHODJHGJL;
	}

	[SpecialName]
	public void NBGPOOIKAHC(int DPNHODJHGJL)
	{
		misses = DPNHODJHGJL;
	}

	[SpecialName]
	public float FBNOEPGJOFE()
	{
		return mapdifficulty;
	}

	[SpecialName]
	public void LOILCMFNNIK(int DPNHODJHGJL)
	{
		loopscount = DPNHODJHGJL;
	}

	[SpecialName]
	public void EICIGNJFKBK(bool DPNHODJHGJL)
	{
		isloved = DPNHODJHGJL;
	}

	[SpecialName]
	public int CPHIGCHONCM()
	{
		return multiplayerplayers;
	}

	[SpecialName]
	public bool EBPIGPCOGLF()
	{
		return isstoryboardactive;
	}

	[SpecialName]
	public int HHGHGCPJPEO()
	{
		return handsCount;
	}

	[SpecialName]
	public int BDCHKNNHNGE()
	{
		return multiplayerplace;
	}

	[SpecialName]
	public float PAGBDLNJAHP()
	{
		return accuracy;
	}

	[SpecialName]
	public string DMKMBMLMEGG()
	{
		return mapper;
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
	public void JKGMFMGEEDF(bool DPNHODJHGJL)
	{
		isfunny = DPNHODJHGJL;
	}

	[SpecialName]
	public void OMGMALOJDPB(bool DPNHODJHGJL)
	{
		isfunny = DPNHODJHGJL;
	}

	[SpecialName]
	public float FCDCFEDGIMI()
	{
		return accuracy;
	}

	[SpecialName]
	public int LBEIFJOIECI()
	{
		return multiplayerplace;
	}

	[SpecialName]
	public int FIOBCCPJOAI()
	{
		return gamemode;
	}

	[SpecialName]
	public void HPFOLIBCHIC(float DPNHODJHGJL)
	{
		mapdifficulty = DPNHODJHGJL;
	}

	[SpecialName]
	public void OBNONHLFLIK(string DPNHODJHGJL)
	{
		mapper = DPNHODJHGJL;
	}

	[SpecialName]
	public void JPCLCMDINFD(float DPNHODJHGJL)
	{
		accuracy = DPNHODJHGJL;
	}

	[SpecialName]
	public string LGDJOHEANFH()
	{
		return maptags;
	}

	[SpecialName]
	public bool FIICJDMHAKO()
	{
		return isloved;
	}

	[SpecialName]
	public void ODKIIHKOMAC(int DPNHODJHGJL)
	{
		perfecthits = DPNHODJHGJL;
	}

	[SpecialName]
	public void GBKFIPJOBPE(int DPNHODJHGJL)
	{
		handsCount = DPNHODJHGJL;
	}

	[SpecialName]
	public bool EOJAGLOMCLA()
	{
		return ismultiplayer;
	}

	[SpecialName]
	public void NLHONELLCNN(int DPNHODJHGJL)
	{
		loopscount = DPNHODJHGJL;
	}

	[SpecialName]
	public void PGHDPDALLHG(bool DPNHODJHGJL)
	{
		ismultiplayer = DPNHODJHGJL;
	}

	[SpecialName]
	public float HHNFFDKGBFD()
	{
		return mapdifficulty;
	}

	[SpecialName]
	public void HMHFKLLJOBF(bool DPNHODJHGJL)
	{
		isofficial = DPNHODJHGJL;
	}

	[SpecialName]
	public void JEIJDKJOPIM(int DPNHODJHGJL)
	{
		multiplayerplace = DPNHODJHGJL;
	}

	[SpecialName]
	public int APGBPAACDCP()
	{
		return gamemode;
	}

	[SpecialName]
	public void LJDGONNDCJP(int DPNHODJHGJL)
	{
		perfecthits = DPNHODJHGJL;
	}

	[SpecialName]
	public void MDKLDNNICAK(float DPNHODJHGJL)
	{
		time = DPNHODJHGJL;
	}

	[SpecialName]
	public void DHHLJNCJLGN(int DPNHODJHGJL)
	{
		perfecthits = DPNHODJHGJL;
	}

	[SpecialName]
	public void PJMOEHBAMFI(bool DPNHODJHGJL)
	{
		isfunny = DPNHODJHGJL;
	}

	[SpecialName]
	public int AEAHNHNPLHP()
	{
		return misses;
	}

	[SpecialName]
	public void LAAMICHIJBO(int DPNHODJHGJL)
	{
		score = DPNHODJHGJL;
	}

	[SpecialName]
	public void PONDJCNLBPG(float DPNHODJHGJL)
	{
		accuracy = DPNHODJHGJL;
	}

	[SpecialName]
	public void KMADNCIJJDN(string DPNHODJHGJL)
	{
		mapid = DPNHODJHGJL;
	}

	[SpecialName]
	public void KIJFOAKBHBN(bool DPNHODJHGJL)
	{
		ismultiplayer = DPNHODJHGJL;
	}

	[SpecialName]
	public int JLBCICHLHCA()
	{
		return loopscount;
	}

	[SpecialName]
	public void LJFLELGFMLA(bool DPNHODJHGJL)
	{
		isofficial = DPNHODJHGJL;
	}

	[SpecialName]
	public int MBLCJDILDJB()
	{
		return perfecthits;
	}

	[SpecialName]
	public int KEGDFKNNHNC()
	{
		return multiplayerplayers;
	}

	[SpecialName]
	public void FPONFICAAGI(bool DPNHODJHGJL)
	{
		completed = DPNHODJHGJL;
	}

	[SpecialName]
	public void ADCLIIPJOBI(bool DPNHODJHGJL)
	{
		isstoryboardactive = DPNHODJHGJL;
	}

	public void LCBKIGCLPBH(FinishedMapInfo CDJGIKGAFOD)
	{
		CDJGIKGAFOD.mapid = mapid;
		CDJGIKGAFOD.mapdifficulty = FBNOEPGJOFE();
		CDJGIKGAFOD.ODOJJJBOMFC(LGDJOHEANFH());
		CDJGIKGAFOD.handsCount = DBIODIJDFML();
		CDJGIKGAFOD.CFAPNLGGNOM(DCFMDKHGGKO());
		CDJGIKGAFOD.KJKDMIFADMP(isofficial);
		CDJGIKGAFOD.isloved = isloved;
		CDJGIKGAFOD.OMGMALOJDPB(isfunny);
		CDJGIKGAFOD.NEIFJEODIKJ(completed);
		CDJGIKGAFOD.IGAFDMLBICN(isstoryboardactive);
		CDJGIKGAFOD.KIJFOAKBHBN(EOJAGLOMCLA());
		CDJGIKGAFOD.multiplayerplayers = multiplayerplayers;
		CDJGIKGAFOD.multiplayerplace = LOIPNPKBCMC();
		CDJGIKGAFOD.multiplayerplayers = multiplayerplayers;
		CDJGIKGAFOD.gamemode = BNANJCOEKNP();
		CDJGIKGAFOD.LOILCMFNNIK(JLBCICHLHCA());
		CDJGIKGAFOD.JPCLCMDINFD(PAGBDLNJAHP());
		CDJGIKGAFOD.LAAMICHIJBO(EHIOHJHBJBO());
		CDJGIKGAFOD.DHHLJNCJLGN(MBLCJDILDJB());
		CDJGIKGAFOD.NBGPOOIKAHC(PBFMOGJPMFG());
		CDJGIKGAFOD.time = time;
	}

	public void GCJEPNMMPDK(FinishedMapInfo CDJGIKGAFOD)
	{
		CDJGIKGAFOD.LECMMNPDAEB(FPKAOFBFCNG());
		CDJGIKGAFOD.mapdifficulty = HHNFFDKGBFD();
		CDJGIKGAFOD.maptags = maptags;
		CDJGIKGAFOD.GBKFIPJOBPE(HHGHGCPJPEO());
		CDJGIKGAFOD.OBNONHLFLIK(DMKMBMLMEGG());
		CDJGIKGAFOD.ACLFCAIINIF(isofficial);
		CDJGIKGAFOD.isloved = CHNBKHKJKPA();
		CDJGIKGAFOD.OMGMALOJDPB(isfunny);
		CDJGIKGAFOD.completed = completed;
		CDJGIKGAFOD.IGAFDMLBICN(AOEIIDNEDNA());
		CDJGIKGAFOD.KIJFOAKBHBN(ismultiplayer);
		CDJGIKGAFOD.multiplayerplayers = CPHIGCHONCM();
		CDJGIKGAFOD.HGKBIBBIOJO(BDCHKNNHNGE());
		CDJGIKGAFOD.multiplayerplayers = CPHIGCHONCM();
		CDJGIKGAFOD.gamemode = FIOBCCPJOAI();
		CDJGIKGAFOD.loopscount = loopscount;
		CDJGIKGAFOD.PONDJCNLBPG(accuracy);
		CDJGIKGAFOD.LAAMICHIJBO(score);
		CDJGIKGAFOD.ODKIIHKOMAC(perfecthits);
		CDJGIKGAFOD.NBGPOOIKAHC(NMKBDHDPONG());
		CDJGIKGAFOD.time = time;
	}

	[SpecialName]
	public bool CHNBKHKJKPA()
	{
		return isloved;
	}

	[SpecialName]
	public int NCPDIDJOKLJ()
	{
		return misses;
	}

	[SpecialName]
	public int ADLMHKJENNM()
	{
		return loopscount;
	}

	[SpecialName]
	public void ACLFCAIINIF(bool DPNHODJHGJL)
	{
		isofficial = DPNHODJHGJL;
	}

	[SpecialName]
	public int EHIOHJHBJBO()
	{
		return score;
	}

	[SpecialName]
	public bool GECNLGNPDFA()
	{
		return isloved;
	}

	[SpecialName]
	public void ODOJJJBOMFC(string DPNHODJHGJL)
	{
		maptags = DPNHODJHGJL;
	}

	[SpecialName]
	public void LECMMNPDAEB(string DPNHODJHGJL)
	{
		mapid = DPNHODJHGJL;
	}

	[SpecialName]
	public bool NBMDOOENPLE()
	{
		return isofficial;
	}

	[SpecialName]
	public string LMOMNPCPDJH()
	{
		return mapper;
	}

	[SpecialName]
	public int DBIODIJDFML()
	{
		return handsCount;
	}

	[SpecialName]
	public void IGAFDMLBICN(bool DPNHODJHGJL)
	{
		isstoryboardactive = DPNHODJHGJL;
	}

	[SpecialName]
	public float FOPLAHECBDN()
	{
		return accuracy;
	}

	[SpecialName]
	public string FBOHCNABBGE()
	{
		return mapper;
	}

	[SpecialName]
	public void FLJHBGENNLG(float DPNHODJHGJL)
	{
		time = DPNHODJHGJL;
	}

	[SpecialName]
	public void ALLGEBFFHNM(bool DPNHODJHGJL)
	{
		isloved = DPNHODJHGJL;
	}
}
