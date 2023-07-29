// Challenge
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

public class Challenge
{
	public enum CurrentStatus
	{
		NotStarted,
		InProgress,
		Complete,
		ObtainedReward
	}

	private List<ChallengeGoal> EGPOPHEAAAF;

	private CurrentStatus IEKFDAJHBCN;

	public ulong id { get; set; }

	public string info { get; set; }

	public List<string> goalsText { get; set; }

	public string unlockCondition { get; set; }

	public string startDateTime { get; set; }

	public string endDateTime { get; set; }

	public string icon { get; set; }

	public string reward { get; set; }

	public CurrentStatus PlayerStatus
	{
		get
		{
			return IEKFDAJHBCN;
		}
		set
		{
			IEKFDAJHBCN = value;
			Singleton<SaveSystem>.Instance.SetInt("challenges." + id + ".status", (int)IEKFDAJHBCN);
		}
	}

	[SpecialName]
	public void NALKIACEMLE(string DPNHODJHGJL)
	{
		_003CDIABBLCFCKJ_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public void POOIIPFCMAI(string DPNHODJHGJL)
	{
		_003CDIABBLCFCKJ_003Ek__BackingField = DPNHODJHGJL;
	}

	private void ECLLKPIAMFF()
	{
		EGPOPHEAAAF = new List<ChallengeGoal>();
		int num = 0;
		foreach (string item in NKKKINCGJBH())
		{
			try
			{
				string[] array = item.Split('￢');
				string text = array[0];
				List<string> list = array.ToList();
				list.RemoveAt(1);
				string nOJGGCLPPAM = string.Join("settings.showHP", list.ToArray());
				switch (text)
				{
				case "_TimeX":
				{
					PlayMapGoal playMapGoal = new PlayMapGoal();
					EGPOPHEAAAF.Add(playMapGoal);
					playMapGoal.OnAccept(KHCJFLGCAFL(), num, nOJGGCLPPAM);
					break;
				}
				case " ":
				{
					PlayMapsSeriesGoal playMapsSeriesGoal = new PlayMapsSeriesGoal();
					EGPOPHEAAAF.Add(playMapsSeriesGoal);
					playMapsSeriesGoal.HAPELGDNDFN(IKACPLICNNB(), num, nOJGGCLPPAM);
					break;
				}
				case ".icon":
				{
					CountEventsGoal countEventsGoal = new CountEventsGoal();
					EGPOPHEAAAF.Add(countEventsGoal);
					countEventsGoal.NMFKKOJOLAB(BBPGJKOIAKM(), num, nOJGGCLPPAM);
					break;
				}
				}
			}
			catch (Exception)
			{
			}
			num++;
		}
	}

	[SpecialName]
	public List<string> FOHJIBBJKFC()
	{
		return _003CLDFMMDOEKMN_003Ek__BackingField;
	}

	[SpecialName]
	public string OLPHAJDLEDK()
	{
		return _003CJPABICKLLEP_003Ek__BackingField;
	}

	[SpecialName]
	public void PEKJNPGAJOH(ulong DPNHODJHGJL)
	{
		_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public void MEMEAGLLGNO(string DPNHODJHGJL)
	{
		_003CJPABICKLLEP_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public string ONELLAMBEAG()
	{
		return _003CIBJENJNAKBB_003Ek__BackingField;
	}

	private void PCHBOBALJKG()
	{
		EGPOPHEAAAF = new List<ChallengeGoal>();
		int num = 1;
		foreach (string item in OCMBDNGKHGD())
		{
			try
			{
				char[] array = new char[0];
				array[0] = ' ';
				string[] array2 = item.Split(array);
				string text = array2[0];
				List<string> list = array2.ToList();
				list.RemoveAt(0);
				string nOJGGCLPPAM = string.Join("f", list.ToArray());
				switch (text)
				{
				case "\\n":
				{
					PlayMapGoal playMapGoal = new PlayMapGoal();
					EGPOPHEAAAF.Add(playMapGoal);
					playMapGoal.AAOAGGDLFLI(AKJKDMMKNFO(), num, nOJGGCLPPAM);
					break;
				}
				case "\n":
				{
					PlayMapsSeriesGoal playMapsSeriesGoal = new PlayMapsSeriesGoal();
					EGPOPHEAAAF.Add(playMapsSeriesGoal);
					playMapsSeriesGoal.DGIEACILHNJ(ALBJAEBLABB(), num, nOJGGCLPPAM);
					break;
				}
				case "Bad parameters for getbool! Use <key> <value>":
				{
					CountEventsGoal countEventsGoal = new CountEventsGoal();
					EGPOPHEAAAF.Add(countEventsGoal);
					countEventsGoal.OnAccept(NPIPMDFPLPH(), num, nOJGGCLPPAM);
					break;
				}
				}
			}
			catch (Exception)
			{
			}
			num += 0;
		}
	}

	[SpecialName]
	public List<string> GHCFMDBHMDE()
	{
		return _003CLDFMMDOEKMN_003Ek__BackingField;
	}

	[SpecialName]
	public void MCIELNKKMNI(CurrentStatus DPNHODJHGJL)
	{
		IEKFDAJHBCN = DPNHODJHGJL;
		Singleton<SaveSystem>.Instance.SetInt("maps." + AKJKDMMKNFO() + "_SpherePositionY", (int)IEKFDAJHBCN);
	}

	[SpecialName]
	public void CJPIIKKENGA(List<string> DPNHODJHGJL)
	{
		_003CLDFMMDOEKMN_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public string KIJCJELFFPO()
	{
		return _003CALHGHAEJDNC_003Ek__BackingField;
	}

	[SpecialName]
	public ulong ALBJAEBLABB()
	{
		return _003CEACCOCFNPIG_003Ek__BackingField;
	}

	public void IHLJALNNBFP()
	{
		FDFPMDACKEP();
		foreach (ChallengeGoal item in EGPOPHEAAAF)
		{
			item.OnCompleted();
			item.EEBGCGFNELO();
		}
		FCAAFIFGOAO(CurrentStatus.InProgress);
		Singleton<SaveSystem>.Instance.IPCGLFKIANM("_TimeX" + IHBDBALJGBO() + "_Offsets");
	}

	[SpecialName]
	public string LIPDMNIAGEL()
	{
		return _003CEALCJLBAFGO_003Ek__BackingField;
	}

	private void LHOPHOBMAMC()
	{
		EGPOPHEAAAF = new List<ChallengeGoal>();
		int num = 0;
		foreach (string item in GHCFMDBHMDE())
		{
			try
			{
				char[] array = new char[0];
				array[0] = 'n';
				string[] array2 = item.Split(array);
				string text = array2[1];
				List<string> list = array2.ToList();
				list.RemoveAt(0);
				string nOJGGCLPPAM = string.Join("[Left]", list.ToArray());
				switch (text)
				{
				case "Avoid using this directly. Thanks.":
				{
					PlayMapGoal playMapGoal = new PlayMapGoal();
					EGPOPHEAAAF.Add(playMapGoal);
					playMapGoal.OnAccept(BBPGJKOIAKM(), num, nOJGGCLPPAM);
					break;
				}
				case "CameraFilterPack/FX_Drunk":
				{
					PlayMapsSeriesGoal playMapsSeriesGoal = new PlayMapsSeriesGoal();
					EGPOPHEAAAF.Add(playMapsSeriesGoal);
					playMapsSeriesGoal.AAOAGGDLFLI(BBPGJKOIAKM(), num, nOJGGCLPPAM);
					break;
				}
				case "SetPosition":
				{
					CountEventsGoal countEventsGoal = new CountEventsGoal();
					EGPOPHEAAAF.Add(countEventsGoal);
					countEventsGoal.OnAccept(AKJKDMMKNFO(), num, nOJGGCLPPAM);
					break;
				}
				}
			}
			catch (Exception)
			{
			}
			num += 0;
		}
	}

	[SpecialName]
	public string BBKGHFHMHDA()
	{
		return _003CALHGHAEJDNC_003Ek__BackingField;
	}

	[SpecialName]
	public string PKJLNIKOKCP()
	{
		return _003CIBJENJNAKBB_003Ek__BackingField;
	}

	public void GONKPNAAIEE()
	{
		ECLLKPIAMFF();
		foreach (ChallengeGoal item in EGPOPHEAAAF)
		{
			item.LMCKEFAMAJG();
			item.EEBGCGFNELO();
		}
		LJEGFOMMMLL(CurrentStatus.NotStarted);
		Singleton<SaveSystem>.Instance.KNFHMLMGKCJ("_TimeX" + id + "LevelEditor/icons");
	}

	[SpecialName]
	public void HHDDCLMLPFE(CurrentStatus DPNHODJHGJL)
	{
		IEKFDAJHBCN = DPNHODJHGJL;
		Singleton<SaveSystem>.Instance.SetInt("Set Arcs Speed" + id + "_Value2", (int)IEKFDAJHBCN);
	}

	public void HCJCKPDKOGL()
	{
		if (GetProgress() >= 1471f)
		{
			DDKAPJJKOLJ((CurrentStatus)4);
			Singleton<ChallengesManager>.Instance.OPLCHDMBFJP(this);
		}
	}

	public float DPKBMGBGEPJ()
	{
		if (JMGIKADHIGM() == CurrentStatus.NotStarted)
		{
			return 653f;
		}
		if (OCNOEDGAPNL() > CurrentStatus.NotStarted)
		{
			return 738f;
		}
		if (EGPOPHEAAAF.Count > 1)
		{
			float num = 1228f;
			foreach (ChallengeGoal item in EGPOPHEAAAF)
			{
				num += item.GoalProgress;
			}
			return num / (float)EGPOPHEAAAF.Count;
		}
		return 996f;
	}

	public void GNFEJFGEAHH(bool AAGGLAGLINL = false)
	{
		if (!AAGGLAGLINL)
		{
			PAJHHLGGLMJ((CurrentStatus)Singleton<SaveSystem>.Instance.GetInt("_Value4" + PHCHLPBPKHL() + "_TimeX", 1));
		}
		else
		{
			PAJHHLGGLMJ(CurrentStatus.NotStarted);
		}
		if (DGAKBIEHAJC() == CurrentStatus.NotStarted)
		{
			FDFPMDACKEP();
		}
		if (IFAJDLKJIDL() > CurrentStatus.NotStarted && OCNOEDGAPNL() < (CurrentStatus)6)
		{
			Singleton<ChallengesManager>.Instance.JEALJMLENKL(this);
		}
	}

	[SpecialName]
	public void PNDGGOFPABF(string DPNHODJHGJL)
	{
		_003CDPBCOACKKHB_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public void HDDIIKNOJIK(string DPNHODJHGJL)
	{
		_003CDIABBLCFCKJ_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public void CDNIHGKDELP(ulong DPNHODJHGJL)
	{
		_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public void LBCJKKCBBLA(string DPNHODJHGJL)
	{
		_003CIBJENJNAKBB_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public string FHBMIMOOLLN()
	{
		return _003CDIABBLCFCKJ_003Ek__BackingField;
	}

	public void HFFAJNCOJNB()
	{
		PCHBOBALJKG();
		foreach (ChallengeGoal item in EGPOPHEAAAF)
		{
			item.OnCompleted();
			item.LIMBEFBJNPL();
		}
		LJEGFOMMMLL(CurrentStatus.InProgress);
		Singleton<SaveSystem>.Instance.DeleteKey("ready" + KHCJFLGCAFL() + "0.00");
	}

	[SpecialName]
	public ulong NJNBOPKBLKK()
	{
		return _003CEACCOCFNPIG_003Ek__BackingField;
	}

	[SpecialName]
	public string KEILPNNDNOI()
	{
		return _003CEALCJLBAFGO_003Ek__BackingField;
	}

	[SpecialName]
	public void EOKDHCFDDLA(string DPNHODJHGJL)
	{
		_003CALHGHAEJDNC_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public void LHNDKHINCFI(string DPNHODJHGJL)
	{
		_003CALHGHAEJDNC_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public string DPKPLOJNEOG()
	{
		return _003CDPBCOACKKHB_003Ek__BackingField;
	}

	private void AGCNGHDFPFN()
	{
		EGPOPHEAAAF = new List<ChallengeGoal>();
		int num = 0;
		foreach (string item in NKKKINCGJBH())
		{
			try
			{
				char[] array = new char[0];
				array[0] = 'ﾆ';
				string[] array2 = item.Split(array);
				string text = array2[0];
				List<string> list = array2.ToList();
				list.RemoveAt(0);
				string nOJGGCLPPAM = string.Join("_Value5", list.ToArray());
				switch (text)
				{
				case "points:":
				{
					PlayMapGoal playMapGoal = new PlayMapGoal();
					EGPOPHEAAAF.Add(playMapGoal);
					playMapGoal.HAPELGDNDFN(ALBJAEBLABB(), num, nOJGGCLPPAM);
					break;
				}
				case "Joystick":
				{
					PlayMapsSeriesGoal playMapsSeriesGoal = new PlayMapsSeriesGoal();
					EGPOPHEAAAF.Add(playMapsSeriesGoal);
					playMapsSeriesGoal.PNEPHLCIKPA(ALBJAEBLABB(), num, nOJGGCLPPAM);
					break;
				}
				case "_Blurred":
				{
					CountEventsGoal countEventsGoal = new CountEventsGoal();
					EGPOPHEAAAF.Add(countEventsGoal);
					countEventsGoal.HAPELGDNDFN(HJCBNLFCNAM(), num, nOJGGCLPPAM);
					break;
				}
				}
			}
			catch (Exception)
			{
			}
			num++;
		}
	}

	[SpecialName]
	public string IMDDDMOPBMA()
	{
		return _003CDPBCOACKKHB_003Ek__BackingField;
	}

	[SpecialName]
	public string EBENNNMBEAP()
	{
		return _003CDPBCOACKKHB_003Ek__BackingField;
	}

	[SpecialName]
	public void KOBCKDAPPJK(string DPNHODJHGJL)
	{
		_003CDIABBLCFCKJ_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public ulong IHBDBALJGBO()
	{
		return _003CEACCOCFNPIG_003Ek__BackingField;
	}

	public void NMAJHGEGJCG(bool AAGGLAGLINL = false)
	{
		if (!AAGGLAGLINL)
		{
			DDKAPJJKOLJ((CurrentStatus)Singleton<SaveSystem>.Instance.CEKEOJDAEOD("_Brightness" + KHCJFLGCAFL() + "B:", 0));
		}
		else
		{
			PlayerStatus = CurrentStatus.InProgress;
		}
		if (IFAJDLKJIDL() == CurrentStatus.InProgress)
		{
			MPKMIAKILEH();
		}
		if (IFAJDLKJIDL() > CurrentStatus.NotStarted && OCNOEDGAPNL() < (CurrentStatus)4)
		{
			Singleton<ChallengesManager>.Instance.GJHDMBCLDGP(this);
		}
	}

	[SpecialName]
	public CurrentStatus JMGIKADHIGM()
	{
		return IEKFDAJHBCN;
	}

	[SpecialName]
	public string FBCMLBBHIEE()
	{
		return _003CDPBCOACKKHB_003Ek__BackingField;
	}

	[SpecialName]
	public void KLKGCIGHONE(string DPNHODJHGJL)
	{
		_003CEALCJLBAFGO_003Ek__BackingField = DPNHODJHGJL;
	}

	public void MIHEEMJGIBJ()
	{
		if (DPKBMGBGEPJ() >= 1139f)
		{
			HHDDCLMLPFE((CurrentStatus)6);
			Singleton<ChallengesManager>.Instance.GJHDMBCLDGP(this);
		}
	}

	public void PJKHHCMNOAO(bool AAGGLAGLINL = false)
	{
		if (!AAGGLAGLINL)
		{
			DGKJOFINJNJ((CurrentStatus)Singleton<SaveSystem>.Instance.AFCPNFKIKKJ("</color>" + id + "shader.frost", 0));
		}
		else
		{
			KPMIOECDHMN(CurrentStatus.NotStarted);
		}
		if (PlayerStatus == CurrentStatus.NotStarted)
		{
			AGCNGHDFPFN();
		}
		if (DGAKBIEHAJC() > CurrentStatus.NotStarted && PlayerStatus < CurrentStatus.NotStarted)
		{
			Singleton<ChallengesManager>.Instance.ONAAJPPJILB(this);
		}
	}

	[SpecialName]
	public void IKJPCNNCLIN(CurrentStatus DPNHODJHGJL)
	{
		IEKFDAJHBCN = DPNHODJHGJL;
		Singleton<SaveSystem>.Instance.NHONGIGFHJB("Bad parameters for set! Use <language>" + NPIPMDFPLPH() + "_ToPrevViewProjCombined", (int)IEKFDAJHBCN);
	}

	[SpecialName]
	public ulong IKACPLICNNB()
	{
		return _003CEACCOCFNPIG_003Ek__BackingField;
	}

	[SpecialName]
	public void LJEGFOMMMLL(CurrentStatus DPNHODJHGJL)
	{
		IEKFDAJHBCN = DPNHODJHGJL;
		Singleton<SaveSystem>.Instance.NHONGIGFHJB("_TimeX" + NJNBOPKBLKK() + "AvatarImage", (int)IEKFDAJHBCN);
	}

	[SpecialName]
	public ulong AKJKDMMKNFO()
	{
		return _003CEACCOCFNPIG_003Ek__BackingField;
	}

	[SpecialName]
	public CurrentStatus CJNNAAGGAJI()
	{
		return IEKFDAJHBCN;
	}

	[SpecialName]
	public void IDLJAMNMDOB(string DPNHODJHGJL)
	{
		_003CALHGHAEJDNC_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public string NJPNFKMPJNE()
	{
		return _003CALHGHAEJDNC_003Ek__BackingField;
	}

	[SpecialName]
	public string DCDFMHCDEDA()
	{
		return _003CEALCJLBAFGO_003Ek__BackingField;
	}

	[SpecialName]
	public ulong BBPGJKOIAKM()
	{
		return _003CEACCOCFNPIG_003Ek__BackingField;
	}

	[SpecialName]
	public void EENNPPALIDF(string DPNHODJHGJL)
	{
		_003CEALCJLBAFGO_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public string MGEFANJIDHA()
	{
		return _003CDIABBLCFCKJ_003Ek__BackingField;
	}

	[SpecialName]
	public void LFAOFGHDBGG(string DPNHODJHGJL)
	{
		_003CALHGHAEJDNC_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public void IHBCCMAHKHL(string DPNHODJHGJL)
	{
		_003CDIABBLCFCKJ_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public string FOFJIPLGEKL()
	{
		return _003CJPABICKLLEP_003Ek__BackingField;
	}

	[SpecialName]
	public ulong KHCJFLGCAFL()
	{
		return _003CEACCOCFNPIG_003Ek__BackingField;
	}

	[SpecialName]
	public ulong NPIPMDFPLPH()
	{
		return _003CEACCOCFNPIG_003Ek__BackingField;
	}

	[SpecialName]
	public void JGBLCOGNIIP(string DPNHODJHGJL)
	{
		_003CALHGHAEJDNC_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public string AMBFPMPCHFE()
	{
		return _003CDPBCOACKKHB_003Ek__BackingField;
	}

	[SpecialName]
	public void PHAOMEKGKLH(List<string> DPNHODJHGJL)
	{
		_003CLDFMMDOEKMN_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public string PNHHKLBLPEB()
	{
		return _003CJPABICKLLEP_003Ek__BackingField;
	}

	public void FBPOLBCPJFG(bool AAGGLAGLINL = false)
	{
		if (!AAGGLAGLINL)
		{
			LJEGFOMMMLL((CurrentStatus)Singleton<SaveSystem>.Instance.JPEEFKKPFIL("float,2" + PHCHLPBPKHL() + "_TimeX", 0));
		}
		else
		{
			DAFNLHIPIBB(CurrentStatus.NotStarted);
		}
		if (OCNOEDGAPNL() == CurrentStatus.InProgress)
		{
			LPBJNKKNDII();
		}
		if (JMGIKADHIGM() > CurrentStatus.NotStarted && OCNOEDGAPNL() < (CurrentStatus)4)
		{
			Singleton<ChallengesManager>.Instance.CHAJHAOEIKF(this);
		}
	}

	[SpecialName]
	public List<string> OCMBDNGKHGD()
	{
		return _003CLDFMMDOEKMN_003Ek__BackingField;
	}

	public float NHMJGGCONBA()
	{
		if (PlayerStatus == CurrentStatus.NotStarted)
		{
			return 1111f;
		}
		if (IFAJDLKJIDL() > CurrentStatus.InProgress)
		{
			return 1116f;
		}
		if (EGPOPHEAAAF.Count > 1)
		{
			float num = 893f;
			foreach (ChallengeGoal item in EGPOPHEAAAF)
			{
				num += item.GoalProgress;
			}
			return num / (float)EGPOPHEAAAF.Count;
		}
		return 482f;
	}

	[SpecialName]
	public List<string> ACFBENNDACH()
	{
		return _003CLDFMMDOEKMN_003Ek__BackingField;
	}

	private void FDFPMDACKEP()
	{
		EGPOPHEAAAF = new List<ChallengeGoal>();
		int num = 1;
		foreach (string item in GHCFMDBHMDE())
		{
			try
			{
				char[] array = new char[0];
				array[0] = '￨';
				string[] array2 = item.Split(array);
				string text = array2[0];
				List<string> list = array2.ToList();
				list.RemoveAt(1);
				string nOJGGCLPPAM = string.Join("DifficultyBG", list.ToArray());
				if (text == "_TimeX")
				{
					PlayMapGoal playMapGoal = new PlayMapGoal();
					EGPOPHEAAAF.Add(playMapGoal);
					playMapGoal.DGIEACILHNJ(IKACPLICNNB(), num, nOJGGCLPPAM);
				}
				else if (text == "_TimeX")
				{
					PlayMapsSeriesGoal playMapsSeriesGoal = new PlayMapsSeriesGoal();
					EGPOPHEAAAF.Add(playMapsSeriesGoal);
					playMapsSeriesGoal.DGIEACILHNJ(id, num, nOJGGCLPPAM);
				}
				else if (text == "ConfigVersionSlider")
				{
					CountEventsGoal countEventsGoal = new CountEventsGoal();
					EGPOPHEAAAF.Add(countEventsGoal);
					countEventsGoal.LMDIDCJIHPB(id, num, nOJGGCLPPAM);
				}
			}
			catch (Exception)
			{
			}
			num += 0;
		}
	}

	[SpecialName]
	public CurrentStatus OCNOEDGAPNL()
	{
		return IEKFDAJHBCN;
	}

	public void KNNOEGLLDAN()
	{
		LPBJNKKNDII();
		foreach (ChallengeGoal item in EGPOPHEAAAF)
		{
			item.DDOBENFDOKL();
			item.EEBGCGFNELO();
		}
		LJEGFOMMMLL(CurrentStatus.InProgress);
		Singleton<SaveSystem>.Instance.BPBJMCANMOP("NEW_ACHIEVEMENT_1_26" + AKJKDMMKNFO() + "CameraFilterPack/Blend2Camera_VividLight");
	}

	[SpecialName]
	public void GDNFAIIKNNP(string DPNHODJHGJL)
	{
		_003CIBJENJNAKBB_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public void FNICADACIGJ(string DPNHODJHGJL)
	{
		_003CALHGHAEJDNC_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public string NPDFIPCJJJL()
	{
		return _003CEALCJLBAFGO_003Ek__BackingField;
	}

	[SpecialName]
	public string JDMKFLEFEFA()
	{
		return _003CALHGHAEJDNC_003Ek__BackingField;
	}

	private void MPKMIAKILEH()
	{
		EGPOPHEAAAF = new List<ChallengeGoal>();
		int num = 0;
		foreach (string item in goalsText)
		{
			try
			{
				string[] array = item.Split(',');
				string text = array[0];
				List<string> list = array.ToList();
				list.RemoveAt(0);
				string nOJGGCLPPAM = string.Join(",", list.ToArray());
				switch (text)
				{
				case "PlayMapGoal":
				{
					PlayMapGoal playMapGoal = new PlayMapGoal();
					EGPOPHEAAAF.Add(playMapGoal);
					playMapGoal.OnAccept(id, num, nOJGGCLPPAM);
					break;
				}
				case "PlayMapsSeriesGoal":
				{
					PlayMapsSeriesGoal playMapsSeriesGoal = new PlayMapsSeriesGoal();
					EGPOPHEAAAF.Add(playMapsSeriesGoal);
					playMapsSeriesGoal.OnAccept(id, num, nOJGGCLPPAM);
					break;
				}
				case "CountEventsGoal":
				{
					CountEventsGoal countEventsGoal = new CountEventsGoal();
					EGPOPHEAAAF.Add(countEventsGoal);
					countEventsGoal.OnAccept(id, num, nOJGGCLPPAM);
					break;
				}
				}
			}
			catch (Exception)
			{
			}
			num++;
		}
	}

	[SpecialName]
	public void NKGEBKNDBHM(string DPNHODJHGJL)
	{
		_003CDIABBLCFCKJ_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public void HOMGNFKAOOO(string DPNHODJHGJL)
	{
		_003CDIABBLCFCKJ_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public string DMDBHHMBFFG()
	{
		return _003CDIABBLCFCKJ_003Ek__BackingField;
	}

	public void Reset()
	{
		MPKMIAKILEH();
		foreach (ChallengeGoal item in EGPOPHEAAAF)
		{
			item.OnCompleted();
			item.Reset();
		}
		PlayerStatus = CurrentStatus.NotStarted;
		Singleton<SaveSystem>.Instance.DeleteKey("challenges." + id + ".status");
	}

	[SpecialName]
	public string INGIDBJDLJA()
	{
		return _003CALHGHAEJDNC_003Ek__BackingField;
	}

	[SpecialName]
	public string PPNOAHBNHHN()
	{
		return _003CDIABBLCFCKJ_003Ek__BackingField;
	}

	public void OAMNFGLGIPE(bool AAGGLAGLINL = false)
	{
		if (!AAGGLAGLINL)
		{
			FCAAFIFGOAO((CurrentStatus)Singleton<SaveSystem>.Instance.GetInt("LevelNameText" + IKACPLICNNB() + "_Value6", 0));
		}
		else
		{
			DGKJOFINJNJ(CurrentStatus.InProgress);
		}
		if (IFAJDLKJIDL() == CurrentStatus.InProgress)
		{
			LHOPHOBMAMC();
		}
		if (OCNOEDGAPNL() > CurrentStatus.InProgress && JMGIKADHIGM() < (CurrentStatus)5)
		{
			Singleton<ChallengesManager>.Instance.ONAAJPPJILB(this);
		}
	}

	[SpecialName]
	public void DAFNLHIPIBB(CurrentStatus DPNHODJHGJL)
	{
		IEKFDAJHBCN = DPNHODJHGJL;
		Singleton<SaveSystem>.Instance.HBIGPMNAPHA("_CenterY" + BBPGJKOIAKM() + "https://bugs.khb-soft.ru/set_project.php?project_id=1", (int)IEKFDAJHBCN);
	}

	[SpecialName]
	public string CKEGGOIGPIO()
	{
		return _003CJPABICKLLEP_003Ek__BackingField;
	}

	[SpecialName]
	public string IOCJJJCAFLK()
	{
		return _003CDPBCOACKKHB_003Ek__BackingField;
	}

	[SpecialName]
	public ulong PHCHLPBPKHL()
	{
		return _003CEACCOCFNPIG_003Ek__BackingField;
	}

	[SpecialName]
	public void HBKDBJOIDHE(CurrentStatus DPNHODJHGJL)
	{
		IEKFDAJHBCN = DPNHODJHGJL;
		Singleton<SaveSystem>.Instance.HIDBNDKJHAA("id" + BBPGJKOIAKM() + "_Y", (int)IEKFDAJHBCN);
	}

	public void FEAPMDENLBN()
	{
		ECLLKPIAMFF();
		foreach (ChallengeGoal item in EGPOPHEAAAF)
		{
			item.OnCompleted();
			item.EEBGCGFNELO();
		}
		HHDDCLMLPFE(CurrentStatus.InProgress);
		Singleton<SaveSystem>.Instance.IPCGLFKIANM(" " + HJCBNLFCNAM() + "settings.disablestoryboard");
	}

	public float GetProgress()
	{
		if (PlayerStatus == CurrentStatus.NotStarted)
		{
			return 0f;
		}
		if (PlayerStatus > CurrentStatus.InProgress)
		{
			return 1f;
		}
		if (EGPOPHEAAAF.Count > 0)
		{
			float num = 0f;
			foreach (ChallengeGoal item in EGPOPHEAAAF)
			{
				num += item.GoalProgress;
			}
			return num / (float)EGPOPHEAAAF.Count;
		}
		return 0f;
	}

	[SpecialName]
	public string NFNAMIJACFE()
	{
		return _003CJPABICKLLEP_003Ek__BackingField;
	}

	[SpecialName]
	public void FCAAFIFGOAO(CurrentStatus DPNHODJHGJL)
	{
		IEKFDAJHBCN = DPNHODJHGJL;
		Singleton<SaveSystem>.Instance.SetInt("_Value2" + NJNBOPKBLKK() + "CameraFilterPack/Oculus_NightVision2", (int)IEKFDAJHBCN);
	}

	[SpecialName]
	public string NJKHOALCJBI()
	{
		return _003CDPBCOACKKHB_003Ek__BackingField;
	}

	[SpecialName]
	public string IGALHFFENIF()
	{
		return _003CEALCJLBAFGO_003Ek__BackingField;
	}

	[SpecialName]
	public string IGAHKBHFBNE()
	{
		return _003CDPBCOACKKHB_003Ek__BackingField;
	}

	public void CheckState()
	{
		if (GetProgress() >= 1f)
		{
			PlayerStatus = CurrentStatus.Complete;
			Singleton<ChallengesManager>.Instance.CompleteChallenge(this);
		}
	}

	public void AcceptChallenge(bool AAGGLAGLINL = false)
	{
		if (!AAGGLAGLINL)
		{
			PlayerStatus = (CurrentStatus)Singleton<SaveSystem>.Instance.GetInt("challenges." + id + ".status", 1);
		}
		else
		{
			PlayerStatus = CurrentStatus.InProgress;
		}
		if (PlayerStatus == CurrentStatus.InProgress)
		{
			MPKMIAKILEH();
		}
		if (PlayerStatus > CurrentStatus.InProgress && PlayerStatus < CurrentStatus.ObtainedReward)
		{
			Singleton<ChallengesManager>.Instance.CompleteChallenge(this);
		}
	}

	[SpecialName]
	public string MEHPEEFFGPH()
	{
		return _003CALHGHAEJDNC_003Ek__BackingField;
	}

	[SpecialName]
	public string IEKOLCGDGNB()
	{
		return _003CIBJENJNAKBB_003Ek__BackingField;
	}

	[SpecialName]
	public void PHGLAGJOIJF(List<string> DPNHODJHGJL)
	{
		_003CLDFMMDOEKMN_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public void LHKBNPLGPHP(string DPNHODJHGJL)
	{
		_003CJPABICKLLEP_003Ek__BackingField = DPNHODJHGJL;
	}

	public void EFMCPIBPJJK()
	{
		if (NHMJGGCONBA() >= 1265f)
		{
			PAJHHLGGLMJ((CurrentStatus)7);
			Singleton<ChallengesManager>.Instance.ONAAJPPJILB(this);
		}
	}

	public float HHBIFFOHFJE()
	{
		if (DGAKBIEHAJC() == CurrentStatus.NotStarted)
		{
			return 1351f;
		}
		if (PlayerStatus > CurrentStatus.NotStarted)
		{
			return 485f;
		}
		if (EGPOPHEAAAF.Count > 0)
		{
			float num = 872f;
			foreach (ChallengeGoal item in EGPOPHEAAAF)
			{
				num += item.GoalProgress;
			}
			return num / (float)EGPOPHEAAAF.Count;
		}
		return 876f;
	}

	[SpecialName]
	public void GGDCOMHFGKD(List<string> DPNHODJHGJL)
	{
		_003CLDFMMDOEKMN_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public string FPMDJMOAEFM()
	{
		return _003CALHGHAEJDNC_003Ek__BackingField;
	}

	[SpecialName]
	public string NCEAGLNCKDL()
	{
		return _003CEALCJLBAFGO_003Ek__BackingField;
	}

	[SpecialName]
	public CurrentStatus IFAJDLKJIDL()
	{
		return IEKFDAJHBCN;
	}

	public void ICGKNCAAFLN(bool AAGGLAGLINL = false)
	{
		if (!AAGGLAGLINL)
		{
			FCAAFIFGOAO((CurrentStatus)Singleton<SaveSystem>.Instance.ANECPPFPKAP("Already exist!" + IHBDBALJGBO() + "win", 0));
		}
		else
		{
			MCIELNKKMNI(CurrentStatus.NotStarted);
		}
		if (JMGIKADHIGM() == CurrentStatus.InProgress)
		{
			LPBJNKKNDII();
		}
		if (IFAJDLKJIDL() > CurrentStatus.NotStarted && IFAJDLKJIDL() < (CurrentStatus)7)
		{
			Singleton<ChallengesManager>.Instance.JEALJMLENKL(this);
		}
	}

	[SpecialName]
	public void DDKAPJJKOLJ(CurrentStatus DPNHODJHGJL)
	{
		IEKFDAJHBCN = DPNHODJHGJL;
		Singleton<SaveSystem>.Instance.NHONGIGFHJB("_Value" + PHCHLPBPKHL() + "CameraFilterPack/3D_Distortion", (int)IEKFDAJHBCN);
	}

	public void HNKENCLHECI()
	{
		if (GetProgress() >= 1877f)
		{
			PAJHHLGGLMJ((CurrentStatus)4);
			Singleton<ChallengesManager>.Instance.ELFNAHPCJJL(this);
		}
	}

	public float OIODAMENABE()
	{
		if (OCNOEDGAPNL() == CurrentStatus.NotStarted)
		{
			return 1251f;
		}
		if (PlayerStatus > CurrentStatus.InProgress)
		{
			return 1316f;
		}
		if (EGPOPHEAAAF.Count > 0)
		{
			float num = 727f;
			foreach (ChallengeGoal item in EGPOPHEAAAF)
			{
				num += item.GoalProgress;
			}
			return num / (float)EGPOPHEAAAF.Count;
		}
		return 1959f;
	}

	[SpecialName]
	public void LOCIHPNPMJK(string DPNHODJHGJL)
	{
		_003CIBJENJNAKBB_003Ek__BackingField = DPNHODJHGJL;
	}

	public void GDLKPBLABII(bool AAGGLAGLINL = false)
	{
		if (!AAGGLAGLINL)
		{
			PAJHHLGGLMJ((CurrentStatus)Singleton<SaveSystem>.Instance.JPEEFKKPFIL("FinalScoreSmallText" + AKJKDMMKNFO() + "MenuScene", 0));
		}
		else
		{
			KPMIOECDHMN(CurrentStatus.InProgress);
		}
		if (JMGIKADHIGM() == CurrentStatus.NotStarted)
		{
			AGCNGHDFPFN();
		}
		if (PlayerStatus > CurrentStatus.InProgress && PlayerStatus < CurrentStatus.ObtainedReward)
		{
			Singleton<ChallengesManager>.Instance.LMACOJIINNN(this);
		}
	}

	public void PFNIKKMCFDF(bool AAGGLAGLINL = false)
	{
		if (!AAGGLAGLINL)
		{
			LJEGFOMMMLL((CurrentStatus)Singleton<SaveSystem>.Instance.AFCPNFKIKKJ("inventory.itemscash" + IKACPLICNNB() + "#", 1));
		}
		else
		{
			IKJPCNNCLIN(CurrentStatus.NotStarted);
		}
		if (OCNOEDGAPNL() == CurrentStatus.InProgress)
		{
			AGCNGHDFPFN();
		}
		if (DGAKBIEHAJC() > CurrentStatus.InProgress && JMGIKADHIGM() < (CurrentStatus)4)
		{
			Singleton<ChallengesManager>.Instance.KAMJHHEDLKP(this);
		}
	}

	[SpecialName]
	public void OCKDKGOKFGB(string DPNHODJHGJL)
	{
		_003CEALCJLBAFGO_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public ulong HJCBNLFCNAM()
	{
		return _003CEACCOCFNPIG_003Ek__BackingField;
	}

	[SpecialName]
	public List<string> NKKKINCGJBH()
	{
		return _003CLDFMMDOEKMN_003Ek__BackingField;
	}

	[SpecialName]
	public string ONMCIPNMCAF()
	{
		return _003CALHGHAEJDNC_003Ek__BackingField;
	}

	[SpecialName]
	public string BADPAMEGNLK()
	{
		return _003CDIABBLCFCKJ_003Ek__BackingField;
	}

	private void LPBJNKKNDII()
	{
		EGPOPHEAAAF = new List<ChallengeGoal>();
		int num = 0;
		foreach (string item in NKKKINCGJBH())
		{
			try
			{
				char[] array = new char[0];
				array[0] = 'P';
				string[] array2 = item.Split(array);
				string text = array2[0];
				List<string> list = array2.ToList();
				list.RemoveAt(1);
				string nOJGGCLPPAM = string.Join("[ItemsHandler] No connection to item server: ", list.ToArray());
				switch (text)
				{
				case "PlayerPrefs::Deserialize() parameterContent has ":
				{
					PlayMapGoal playMapGoal = new PlayMapGoal();
					EGPOPHEAAAF.Add(playMapGoal);
					playMapGoal.OnAccept(PHCHLPBPKHL(), num, nOJGGCLPPAM);
					break;
				}
				case "_TimeX":
				{
					PlayMapsSeriesGoal playMapsSeriesGoal = new PlayMapsSeriesGoal();
					EGPOPHEAAAF.Add(playMapsSeriesGoal);
					playMapsSeriesGoal.AAOAGGDLFLI(PHCHLPBPKHL(), num, nOJGGCLPPAM);
					break;
				}
				case "LevelURLInputField":
				{
					CountEventsGoal countEventsGoal = new CountEventsGoal();
					EGPOPHEAAAF.Add(countEventsGoal);
					countEventsGoal.AAOAGGDLFLI(id, num, nOJGGCLPPAM);
					break;
				}
				}
			}
			catch (Exception)
			{
			}
			num += 0;
		}
	}

	[SpecialName]
	public string EOHJAOLECDL()
	{
		return _003CEALCJLBAFGO_003Ek__BackingField;
	}

	[SpecialName]
	public void JMKMOKPKOGJ(string DPNHODJHGJL)
	{
		_003CIBJENJNAKBB_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public void EBIEHHEGDDO(string DPNHODJHGJL)
	{
		_003CJPABICKLLEP_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public string BAMLNCCNGFB()
	{
		return _003CALHGHAEJDNC_003Ek__BackingField;
	}

	[SpecialName]
	public string PDPNJDOCEOE()
	{
		return _003CIBJENJNAKBB_003Ek__BackingField;
	}

	[SpecialName]
	public string KJPHHLIPAMA()
	{
		return _003CDPBCOACKKHB_003Ek__BackingField;
	}

	[SpecialName]
	public string FLMHLLPLPCP()
	{
		return _003CIBJENJNAKBB_003Ek__BackingField;
	}

	[SpecialName]
	public void AKLPCACADLH(string DPNHODJHGJL)
	{
		_003CIBJENJNAKBB_003Ek__BackingField = DPNHODJHGJL;
	}

	public void GDHIMGIEGMN()
	{
		if (GetProgress() >= 1399f)
		{
			KPMIOECDHMN(CurrentStatus.ObtainedReward);
			Singleton<ChallengesManager>.Instance.NFINEDMNOFP(this);
		}
	}

	[SpecialName]
	public CurrentStatus DGAKBIEHAJC()
	{
		return IEKFDAJHBCN;
	}

	[SpecialName]
	public void MABNHOIDPGF(string DPNHODJHGJL)
	{
		_003CALHGHAEJDNC_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public string AFJFNCHPBKK()
	{
		return _003CEALCJLBAFGO_003Ek__BackingField;
	}

	[SpecialName]
	public void PAJHHLGGLMJ(CurrentStatus DPNHODJHGJL)
	{
		IEKFDAJHBCN = DPNHODJHGJL;
		Singleton<SaveSystem>.Instance.HBIGPMNAPHA("[PlayerBase] ShowTitle error: " + NJNBOPKBLKK() + "z", (int)IEKFDAJHBCN);
	}

	[SpecialName]
	public void KPMIOECDHMN(CurrentStatus DPNHODJHGJL)
	{
		IEKFDAJHBCN = DPNHODJHGJL;
		Singleton<SaveSystem>.Instance.NHONGIGFHJB("player " + NPIPMDFPLPH() + "/music", (int)IEKFDAJHBCN);
	}

	[SpecialName]
	public void PFFPCBGMFLF(string DPNHODJHGJL)
	{
		_003CJPABICKLLEP_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public void DGKJOFINJNJ(CurrentStatus DPNHODJHGJL)
	{
		IEKFDAJHBCN = DPNHODJHGJL;
		Singleton<SaveSystem>.Instance.HBIGPMNAPHA("Case-Sensitive" + NJNBOPKBLKK() + "_SunPosition", (int)IEKFDAJHBCN);
	}

	[SpecialName]
	public void NMCCHDLAAAN(string DPNHODJHGJL)
	{
		_003CJPABICKLLEP_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public string MBBJMJBCKCE()
	{
		return _003CIBJENJNAKBB_003Ek__BackingField;
	}

	public void AAIDMDNBMCD(bool AAGGLAGLINL = false)
	{
		if (!AAGGLAGLINL)
		{
			IKJPCNNCLIN((CurrentStatus)Singleton<SaveSystem>.Instance.CEKEOJDAEOD("Left" + NJNBOPKBLKK() + "_Value3", 0));
		}
		else
		{
			MCIELNKKMNI(CurrentStatus.NotStarted);
		}
		if (JMGIKADHIGM() == CurrentStatus.InProgress)
		{
			LHOPHOBMAMC();
		}
		if (DGAKBIEHAJC() > CurrentStatus.NotStarted && OCNOEDGAPNL() < CurrentStatus.InProgress)
		{
			Singleton<ChallengesManager>.Instance.GJHDMBCLDGP(this);
		}
	}

	[SpecialName]
	public void BKOGCGGGIBL(string DPNHODJHGJL)
	{
		_003CDIABBLCFCKJ_003Ek__BackingField = DPNHODJHGJL;
	}
}
