// GameState
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MoonSharp.Interpreter;

[MoonSharpUserData]
public class GameState
{
	private int FFPBGKFKENP;

	private Dictionary<string, object> NOJGGCLPPAM;

	public int Action
	{
		get
		{
			return FFPBGKFKENP;
		}
		[MoonSharpHidden]
		set
		{
			FFPBGKFKENP = value;
		}
	}

	public void KHJGDOEDODJ(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	public void IJJLEONOJFC(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	public int KLEPLFNCJBB(string HFEFHOPOLIK)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 0;
	}

	[SpecialName]
	public void MIHJACPDMBN(int DPNHODJHGJL)
	{
		FFPBGKFKENP = DPNHODJHGJL;
	}

	[SpecialName]
	public void OMPFFHOCPOA(int DPNHODJHGJL)
	{
		FFPBGKFKENP = DPNHODJHGJL;
	}

	[SpecialName]
	public int GNAMJJFBIIH()
	{
		return FFPBGKFKENP;
	}

	public void IFNMCNLEJPA(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	public void MGOLCKBNLMN(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				NOJGGCLPPAM.Add(HONJLFPGFON, false);
			}
		}
		else
		{
			NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	[SpecialName]
	public void NHKBECAGNMF(int DPNHODJHGJL)
	{
		FFPBGKFKENP = DPNHODJHGJL;
	}

	public bool IINJNLILBNH(string HONJLFPGFON)
	{
		return NOJGGCLPPAM.ContainsKey(HONJLFPGFON);
	}

	public int GJHGEODJOMC(string HFEFHOPOLIK)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 0;
	}

	[SpecialName]
	public void OAAADLHEAPB(int DPNHODJHGJL)
	{
		FFPBGKFKENP = DPNHODJHGJL;
	}

	public void SetFlag(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				NOJGGCLPPAM.Add(HONJLFPGFON, true);
			}
		}
		else
		{
			NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	public bool ELKKBLKBNCK(string HONJLFPGFON)
	{
		return NOJGGCLPPAM.ContainsKey(HONJLFPGFON);
	}

	public void HHDPOFMAJIJ(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	public void OKDLCHPEFAJ(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	public bool DANKEDNMADL(string HONJLFPGFON)
	{
		return NOJGGCLPPAM.ContainsKey(HONJLFPGFON);
	}

	[SpecialName]
	public int FFJCLMOEGJP()
	{
		return FFPBGKFKENP;
	}

	[SpecialName]
	public int OCNOMPJFPDH()
	{
		return FFPBGKFKENP;
	}

	public void PNBKMOKMGCA(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	[SpecialName]
	public void NLJHNBPIOBM(int DPNHODJHGJL)
	{
		FFPBGKFKENP = DPNHODJHGJL;
	}

	public void ILEFCAOODPD(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	[SpecialName]
	public int PIEMAFNAIFJ()
	{
		return FFPBGKFKENP;
	}

	public void CDJGEAAHDCO(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				NOJGGCLPPAM.Add(HONJLFPGFON, true);
			}
		}
		else
		{
			NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	public void PLKCIHMOEDF(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	[SpecialName]
	public void MOMKPOKGKGG(int DPNHODJHGJL)
	{
		FFPBGKFKENP = DPNHODJHGJL;
	}

	public void SetInt(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	public int PABBPEFFKIF(string HFEFHOPOLIK)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 0;
	}

	public int EPIDPKPODKM(string HFEFHOPOLIK)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 1;
	}

	public int OJNFPHLBFIK(string HFEFHOPOLIK)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 1;
	}

	[SpecialName]
	public void BJIMJIHHAAO(int DPNHODJHGJL)
	{
		FFPBGKFKENP = DPNHODJHGJL;
	}

	public void GMOCCPMECNA(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				NOJGGCLPPAM.Add(HONJLFPGFON, false);
			}
		}
		else
		{
			NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	public void FOHCCLDFIPI(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				NOJGGCLPPAM.Add(HONJLFPGFON, true);
			}
		}
		else
		{
			NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	[SpecialName]
	public int ACFEFOIGPGH()
	{
		return FFPBGKFKENP;
	}

	public int GetInt(string HFEFHOPOLIK)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 0;
	}

	public void AIEGEOFOMAK(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	public void ONBLOOKJGJK(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				NOJGGCLPPAM.Add(HONJLFPGFON, true);
			}
		}
		else
		{
			NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	public void GBFBKFACPBI(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	[SpecialName]
	public void EEDFEGBFNEE(int DPNHODJHGJL)
	{
		FFPBGKFKENP = DPNHODJHGJL;
	}

	public bool JGJDPHFPDIB(string HONJLFPGFON)
	{
		return NOJGGCLPPAM.ContainsKey(HONJLFPGFON);
	}

	public void IHCHOMIEIMA(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	[SpecialName]
	public int JPLMMEMJDFL()
	{
		return FFPBGKFKENP;
	}

	public int HHEOBAMLBKO(string HFEFHOPOLIK)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 1;
	}

	public void KAGHFDBFEID(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	[SpecialName]
	public int ADFMPHGIJIB()
	{
		return FFPBGKFKENP;
	}

	public void NIHEAIFNFGK(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				NOJGGCLPPAM.Add(HONJLFPGFON, false);
			}
		}
		else
		{
			NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	public void HHLLFMCPPHO(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				NOJGGCLPPAM.Add(HONJLFPGFON, false);
			}
		}
		else
		{
			NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	[SpecialName]
	public void GMNIMJALECK(int DPNHODJHGJL)
	{
		FFPBGKFKENP = DPNHODJHGJL;
	}

	public void JCNPPGPPEHF(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	[SpecialName]
	public int COLMMBOCJLJ()
	{
		return FFPBGKFKENP;
	}

	public void LAJHLIANCJE(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				NOJGGCLPPAM.Add(HONJLFPGFON, false);
			}
		}
		else
		{
			NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	public int KPCOPGALPAH(string HFEFHOPOLIK)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 0;
	}

	public void CJKADOEEHCN(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				NOJGGCLPPAM.Add(HONJLFPGFON, true);
			}
		}
		else
		{
			NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	public void BBABCIKOEMF(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				NOJGGCLPPAM.Add(HONJLFPGFON, true);
			}
		}
		else
		{
			NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	[SpecialName]
	public int PMIPMLMPBOI()
	{
		return FFPBGKFKENP;
	}

	public int JOFPMNKAJOD(string HFEFHOPOLIK)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 1;
	}

	public bool EFDCJIJHPOO(string HONJLFPGFON)
	{
		return NOJGGCLPPAM.ContainsKey(HONJLFPGFON);
	}

	public bool HEMKFLEJGCC(string HONJLFPGFON)
	{
		return NOJGGCLPPAM.ContainsKey(HONJLFPGFON);
	}

	public void OFBNABDMOFC(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	public int LDHFNHNCGMM(string HFEFHOPOLIK)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 1;
	}

	public void BCMMKLKAGLO(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				NOJGGCLPPAM.Add(HONJLFPGFON, true);
			}
		}
		else
		{
			NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	public void IJFLFDFLCHP(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				NOJGGCLPPAM.Add(HONJLFPGFON, true);
			}
		}
		else
		{
			NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	public int PKIEJKHMECB(string HFEFHOPOLIK)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 1;
	}

	[SpecialName]
	public void OADEMMCFLKA(int DPNHODJHGJL)
	{
		FFPBGKFKENP = DPNHODJHGJL;
	}

	public int EGGJOJMNLBH(string HFEFHOPOLIK)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 1;
	}

	public int AFCPNFKIKKJ(string HFEFHOPOLIK)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 1;
	}

	public bool LNPDOIGOEIO(string HONJLFPGFON)
	{
		return NOJGGCLPPAM.ContainsKey(HONJLFPGFON);
	}

	public void LNOFBDBGDOK(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				NOJGGCLPPAM.Add(HONJLFPGFON, false);
			}
		}
		else
		{
			NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	[SpecialName]
	public int IKPMMJBEAHO()
	{
		return FFPBGKFKENP;
	}

	public void KKLFJDENBPM(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				NOJGGCLPPAM.Add(HONJLFPGFON, false);
			}
		}
		else
		{
			NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	public void JPALJEGCCHA(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				NOJGGCLPPAM.Add(HONJLFPGFON, false);
			}
		}
		else
		{
			NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	[SpecialName]
	public int CDGFIFOHACK()
	{
		return FFPBGKFKENP;
	}

	public bool PHPNPOGFJJJ(string HONJLFPGFON)
	{
		return NOJGGCLPPAM.ContainsKey(HONJLFPGFON);
	}

	public void MFMOAHDMPDC(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	public int POANCKAKLOH(string HFEFHOPOLIK)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 1;
	}

	public void OCINFGEAKDI(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				NOJGGCLPPAM.Add(HONJLFPGFON, false);
			}
		}
		else
		{
			NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	[SpecialName]
	public void ALLJLCGOGJH(int DPNHODJHGJL)
	{
		FFPBGKFKENP = DPNHODJHGJL;
	}

	public void FNGAMGMAHFM(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	[SpecialName]
	public void JMJNKANMANK(int DPNHODJHGJL)
	{
		FFPBGKFKENP = DPNHODJHGJL;
	}

	public bool GetFlag(string HONJLFPGFON)
	{
		return NOJGGCLPPAM.ContainsKey(HONJLFPGFON);
	}

	public int JBLBOBGALKH(string HFEFHOPOLIK)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 0;
	}

	public void OFPCEFFGHPI(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	[SpecialName]
	public void LINOCPHKFOG(int DPNHODJHGJL)
	{
		FFPBGKFKENP = DPNHODJHGJL;
	}

	[SpecialName]
	public void DKCBLLOBLAM(int DPNHODJHGJL)
	{
		FFPBGKFKENP = DPNHODJHGJL;
	}

	[SpecialName]
	public int FMHHCMOODOF()
	{
		return FFPBGKFKENP;
	}

	[SpecialName]
	public void KANLDPOJBHC(int DPNHODJHGJL)
	{
		FFPBGKFKENP = DPNHODJHGJL;
	}

	[SpecialName]
	public void IKFLAMEGGKK(int DPNHODJHGJL)
	{
		FFPBGKFKENP = DPNHODJHGJL;
	}

	public void HOJEBEFDKPD(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	public void LFLJNBFMACE(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				NOJGGCLPPAM.Add(HONJLFPGFON, true);
			}
		}
		else
		{
			NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	public bool KMBKOLIKBDL(string HONJLFPGFON)
	{
		return NOJGGCLPPAM.ContainsKey(HONJLFPGFON);
	}

	[SpecialName]
	public void GAMCBGMILFI(int DPNHODJHGJL)
	{
		FFPBGKFKENP = DPNHODJHGJL;
	}

	public void AOCPPOKPMNO(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	public bool HEBJGNKAKIL(string HONJLFPGFON)
	{
		return NOJGGCLPPAM.ContainsKey(HONJLFPGFON);
	}

	public void IJLFDHOCKIN(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				NOJGGCLPPAM.Add(HONJLFPGFON, true);
			}
		}
		else
		{
			NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	[SpecialName]
	public int MKKENABFELP()
	{
		return FFPBGKFKENP;
	}

	public bool DBCNCFEBJBN(string HONJLFPGFON)
	{
		return NOJGGCLPPAM.ContainsKey(HONJLFPGFON);
	}

	public void GAGPLKADFMJ(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				NOJGGCLPPAM.Add(HONJLFPGFON, false);
			}
		}
		else
		{
			NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	[SpecialName]
	public void KPDOPNBDBLJ(int DPNHODJHGJL)
	{
		FFPBGKFKENP = DPNHODJHGJL;
	}

	[SpecialName]
	public void IEOCONPDLLF(int DPNHODJHGJL)
	{
		FFPBGKFKENP = DPNHODJHGJL;
	}

	public int ODIGHKEMLLM(string HFEFHOPOLIK)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 0;
	}

	public int KECMHJIDDEI(string HFEFHOPOLIK)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 1;
	}

	[SpecialName]
	public void MNJBJNECLCK(int DPNHODJHGJL)
	{
		FFPBGKFKENP = DPNHODJHGJL;
	}

	public int JNLHMOEFMML(string HFEFHOPOLIK)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 1;
	}

	[SpecialName]
	public int ACHEAADDJOB()
	{
		return FFPBGKFKENP;
	}

	public void FOJMLGFIPCB(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				NOJGGCLPPAM.Add(HONJLFPGFON, true);
			}
		}
		else
		{
			NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	public bool CDIIDAAHHPA(string HONJLFPGFON)
	{
		return NOJGGCLPPAM.ContainsKey(HONJLFPGFON);
	}

	public void NNNBGIJFHFH(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	public void IFLMHHJKJMC(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				NOJGGCLPPAM.Add(HONJLFPGFON, true);
			}
		}
		else
		{
			NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	[SpecialName]
	public int CDPFJGFPKCB()
	{
		return FFPBGKFKENP;
	}

	[MoonSharpHidden]
	public GameState()
	{
		NOJGGCLPPAM = new Dictionary<string, object>();
	}

	[SpecialName]
	public void EFHICFFMNGF(int DPNHODJHGJL)
	{
		FFPBGKFKENP = DPNHODJHGJL;
	}

	[SpecialName]
	public int DGPINJKDBGL()
	{
		return FFPBGKFKENP;
	}

	[SpecialName]
	public void EHOCIKECPKC(int DPNHODJHGJL)
	{
		FFPBGKFKENP = DPNHODJHGJL;
	}

	public int KPGAODLKMOP(string HFEFHOPOLIK)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 0;
	}

	public bool IBPJPCDBAPP(string HONJLFPGFON)
	{
		return NOJGGCLPPAM.ContainsKey(HONJLFPGFON);
	}

	public void OLDPNKLFGKK(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				NOJGGCLPPAM.Add(HONJLFPGFON, true);
			}
		}
		else
		{
			NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	public void GPPDNOGOEHC(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	public int IGADJGDBHPO(string HFEFHOPOLIK)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 1;
	}

	public int EDOOIBLEGEP(string HFEFHOPOLIK)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 1;
	}

	public int LEOLIDKCBOG(string HFEFHOPOLIK)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 1;
	}

	public void FFKLBCLMLJM(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	[SpecialName]
	public void HEKJPGGNHGI(int DPNHODJHGJL)
	{
		FFPBGKFKENP = DPNHODJHGJL;
	}

	public int NDGODCIFBOB(string HFEFHOPOLIK)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 0;
	}

	public void GKPMKFLJEEH(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				NOJGGCLPPAM.Add(HONJLFPGFON, false);
			}
		}
		else
		{
			NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	public void DCINDMCHGID(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				NOJGGCLPPAM.Add(HONJLFPGFON, false);
			}
		}
		else
		{
			NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}

	public int DFEBLDOCCAC(string HFEFHOPOLIK)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			return (int)NOJGGCLPPAM[HFEFHOPOLIK];
		}
		return 1;
	}

	[SpecialName]
	public int PDDKGPCIDJA()
	{
		return FFPBGKFKENP;
	}

	public void DKPKHLKNOFN(string HFEFHOPOLIK, int DPNHODJHGJL)
	{
		if (NOJGGCLPPAM.ContainsKey(HFEFHOPOLIK))
		{
			NOJGGCLPPAM[HFEFHOPOLIK] = DPNHODJHGJL;
		}
		else
		{
			NOJGGCLPPAM.Add(HFEFHOPOLIK, DPNHODJHGJL);
		}
	}

	public void CDPMHHLAPBB(string HONJLFPGFON, bool GMIGAABPDHM)
	{
		if (GMIGAABPDHM)
		{
			if (!NOJGGCLPPAM.ContainsKey(HONJLFPGFON))
			{
				NOJGGCLPPAM.Add(HONJLFPGFON, false);
			}
		}
		else
		{
			NOJGGCLPPAM.Remove(HONJLFPGFON);
		}
	}
}
