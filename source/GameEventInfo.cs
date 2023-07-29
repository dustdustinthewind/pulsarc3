// GameEventInfo
using System;
using System.Runtime.CompilerServices;
using MoonSharp.Interpreter;

[Serializable]
[MoonSharpUserData]
public class GameEventInfo
{
	public string mapid { get; set; }

	public float mapdifficulty { get; set; }

	public string maptags { get; set; }

	public int handsCount { get; set; }

	public string mapper { get; set; }

	public bool isofficial { get; set; }

	public bool isloved { get; set; }

	public bool isfunny { get; set; }

	public bool isstoryboardactive { get; set; }

	public bool ismultiplayer { get; set; }

	public int multiplayerplayers { get; set; }

	public int multiplayerplace { get; set; }

	public int gamemode { get; set; }

	public int loopscount { get; set; }

	public string eventtype { get; set; }

	public string eventdata { get; set; }

	public float eventtime { get; set; }

	[SpecialName]
	public string CPJFGIKHAND()
	{
		return maptags;
	}

	[SpecialName]
	public int DKJBBCONPEB()
	{
		return multiplayerplace;
	}

	[SpecialName]
	public int LOIPNPKBCMC()
	{
		return multiplayerplace;
	}

	[SpecialName]
	public void LHAFCMGGOMO(float DPNHODJHGJL)
	{
		mapdifficulty = DPNHODJHGJL;
	}

	[SpecialName]
	public string JEAPDMHBMEL()
	{
		return mapper;
	}

	[SpecialName]
	public string DFBGJPBBIJJ()
	{
		return mapper;
	}

	[SpecialName]
	public void APALNCADHBO(int DPNHODJHGJL)
	{
		gamemode = DPNHODJHGJL;
	}

	[SpecialName]
	public int GBOOJBKEKCH()
	{
		return multiplayerplayers;
	}

	[SpecialName]
	public bool FODIFPGJNFH()
	{
		return isfunny;
	}

	[SpecialName]
	public bool EHCKBMPNOJO()
	{
		return isloved;
	}

	[SpecialName]
	public void CMIGOCHFOOH(int DPNHODJHGJL)
	{
		loopscount = DPNHODJHGJL;
	}

	[SpecialName]
	public string FEFOACJLBFE()
	{
		return mapper;
	}

	[SpecialName]
	public void DNIMOKBJONL(string DPNHODJHGJL)
	{
		eventdata = DPNHODJHGJL;
	}

	[SpecialName]
	public int AJIDIBPJIPG()
	{
		return multiplayerplayers;
	}

	[SpecialName]
	public bool DFJNEIIGIED()
	{
		return isfunny;
	}

	[SpecialName]
	public int MDGNEDEFFIP()
	{
		return handsCount;
	}

	[SpecialName]
	public float ELPCPFHDMLE()
	{
		return eventtime;
	}

	[SpecialName]
	public bool OKOAJMDELCH()
	{
		return isfunny;
	}

	[SpecialName]
	public bool DPLAJEPHEML()
	{
		return isstoryboardactive;
	}

	[SpecialName]
	public string NJOALFNMBGI()
	{
		return mapid;
	}

	[SpecialName]
	public void OPJHPJMHLEP(bool DPNHODJHGJL)
	{
		ismultiplayer = DPNHODJHGJL;
	}

	[SpecialName]
	public string FJGFEDNEOEC()
	{
		return mapid;
	}

	[SpecialName]
	public void IEMOCFIMKJI(string DPNHODJHGJL)
	{
		eventtype = DPNHODJHGJL;
	}

	[SpecialName]
	public string CKGLEBDPAEG()
	{
		return eventtype;
	}

	public void FLNDNCGFKKH(GameEventInfo ANFCKLODOMJ)
	{
		ANFCKLODOMJ.mapid = FJGFEDNEOEC();
		ANFCKLODOMJ.LHAFCMGGOMO(mapdifficulty);
		ANFCKLODOMJ.maptags = CPJFGIKHAND();
		ANFCKLODOMJ.handsCount = MDGNEDEFFIP();
		ANFCKLODOMJ.mapper = DFBGJPBBIJJ();
		ANFCKLODOMJ.isofficial = isofficial;
		ANFCKLODOMJ.isloved = EHCKBMPNOJO();
		ANFCKLODOMJ.isfunny = DFJNEIIGIED();
		ANFCKLODOMJ.isstoryboardactive = DPLAJEPHEML();
		ANFCKLODOMJ.ismultiplayer = ismultiplayer;
		ANFCKLODOMJ.multiplayerplayers = multiplayerplayers;
		ANFCKLODOMJ.multiplayerplace = multiplayerplace;
		ANFCKLODOMJ.multiplayerplayers = OHLCCMKCLKN();
		ANFCKLODOMJ.APALNCADHBO(gamemode);
		ANFCKLODOMJ.loopscount = loopscount;
		ANFCKLODOMJ.IEMOCFIMKJI(CKGLEBDPAEG());
		ANFCKLODOMJ.eventdata = EFJJEFNNDDG();
		ANFCKLODOMJ.eventtime = eventtime;
	}

	public void NEDLDBBIOGI(GameEventInfo ANFCKLODOMJ)
	{
		ANFCKLODOMJ.mapid = NJOALFNMBGI();
		ANFCKLODOMJ.mapdifficulty = BHMEKMNGHNB();
		ANFCKLODOMJ.maptags = maptags;
		ANFCKLODOMJ.handsCount = MDGNEDEFFIP();
		ANFCKLODOMJ.mapper = JEAPDMHBMEL();
		ANFCKLODOMJ.isofficial = isofficial;
		ANFCKLODOMJ.isloved = EHCKBMPNOJO();
		ANFCKLODOMJ.isfunny = FODIFPGJNFH();
		ANFCKLODOMJ.isstoryboardactive = isstoryboardactive;
		ANFCKLODOMJ.OPJHPJMHLEP(ismultiplayer);
		ANFCKLODOMJ.multiplayerplayers = multiplayerplayers;
		ANFCKLODOMJ.multiplayerplace = LOIPNPKBCMC();
		ANFCKLODOMJ.multiplayerplayers = AJIDIBPJIPG();
		ANFCKLODOMJ.gamemode = gamemode;
		ANFCKLODOMJ.loopscount = loopscount;
		ANFCKLODOMJ.IEMOCFIMKJI(eventtype);
		ANFCKLODOMJ.DNIMOKBJONL(EFJJEFNNDDG());
		ANFCKLODOMJ.EDJCJJNDNKB(ELPCPFHDMLE());
	}

	[SpecialName]
	public string EFJJEFNNDDG()
	{
		return eventdata;
	}

	[SpecialName]
	public void EDJCJJNDNKB(float DPNHODJHGJL)
	{
		eventtime = DPNHODJHGJL;
	}

	[SpecialName]
	public int OHLCCMKCLKN()
	{
		return multiplayerplayers;
	}

	[SpecialName]
	public float BHMEKMNGHNB()
	{
		return mapdifficulty;
	}

	[SpecialName]
	public void ABHJCEENJBC(bool DPNHODJHGJL)
	{
		isstoryboardactive = DPNHODJHGJL;
	}

	public void CopyValues(GameEventInfo ANFCKLODOMJ)
	{
		ANFCKLODOMJ.mapid = mapid;
		ANFCKLODOMJ.mapdifficulty = mapdifficulty;
		ANFCKLODOMJ.maptags = maptags;
		ANFCKLODOMJ.handsCount = handsCount;
		ANFCKLODOMJ.mapper = mapper;
		ANFCKLODOMJ.isofficial = isofficial;
		ANFCKLODOMJ.isloved = isloved;
		ANFCKLODOMJ.isfunny = isfunny;
		ANFCKLODOMJ.isstoryboardactive = isstoryboardactive;
		ANFCKLODOMJ.ismultiplayer = ismultiplayer;
		ANFCKLODOMJ.multiplayerplayers = multiplayerplayers;
		ANFCKLODOMJ.multiplayerplace = multiplayerplace;
		ANFCKLODOMJ.multiplayerplayers = multiplayerplayers;
		ANFCKLODOMJ.gamemode = gamemode;
		ANFCKLODOMJ.loopscount = loopscount;
		ANFCKLODOMJ.eventtype = eventtype;
		ANFCKLODOMJ.eventdata = eventdata;
		ANFCKLODOMJ.eventtime = eventtime;
	}

	[SpecialName]
	public int GKMCBLPAMEC()
	{
		return multiplayerplace;
	}
}
