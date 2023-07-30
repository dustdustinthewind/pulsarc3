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
	public CurrentStatus EFOKGOMPFIO()
	{
		return IEKFDAJHBCN;
	}

	[SpecialName]
	public ulong ENDOGIJIIMN()
	{
		return _003CEACCOCFNPIG_003Ek__BackingField;
	}

	[SpecialName]
	public void CFJAADKGIBI(List<string> DPNHODJHGJL)
	{
		_003CLDFMMDOEKMN_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public void JCGPDAHKPPI(string DPNHODJHGJL)
	{
		_003CJPABICKLLEP_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public CurrentStatus BBLDABFGDFF()
	{
		return IEKFDAJHBCN;
	}

	[SpecialName]
	public string GJONOJPJGAO()
	{
		return _003CALHGHAEJDNC_003Ek__BackingField;
	}

	public float KCMBMLFLEOK()
	{
		if (HCPDNILLJEJ() == CurrentStatus.NotStarted)
		{
			return 1145f;
		}
		if (JNEKHPIOHIK() > CurrentStatus.NotStarted)
		{
			return 1199f;
		}
		if (EGPOPHEAAAF.Count > 1)
		{
			float num = 139f;
			foreach (ChallengeGoal item in EGPOPHEAAAF)
			{
				num += item.FBEFEPECHBM();
			}
			return num / (float)EGPOPHEAAAF.Count;
		}
		return 1490f;
	}

	[SpecialName]
	public string CGDEMHHGAON()
	{
		return _003CALHGHAEJDNC_003Ek__BackingField;
	}

	[SpecialName]
	public string LACOFOPCNBG()
	{
		return _003CDIABBLCFCKJ_003Ek__BackingField;
	}

	[SpecialName]
	public ulong OFGNFACIGIL()
	{
		return _003CEACCOCFNPIG_003Ek__BackingField;
	}

	[SpecialName]
	public string MHNLMDPIGLB()
	{
		return _003CIBJENJNAKBB_003Ek__BackingField;
	}

	[SpecialName]
	public void ABNFDKBNAGF(ulong DPNHODJHGJL)
	{
		_003CEACCOCFNPIG_003Ek__BackingField = DPNHODJHGJL;
	}

	public float GIMMCHBOAPA()
	{
		if (PlayerStatus == CurrentStatus.NotStarted)
		{
			return 364f;
		}
		if (BBLDABFGDFF() > CurrentStatus.NotStarted)
		{
			return 987f;
		}
		if (EGPOPHEAAAF.Count > 0)
		{
			float num = 1160f;
			foreach (ChallengeGoal item in EGPOPHEAAAF)
			{
				num += item.GoalProgress;
			}
			return num / (float)EGPOPHEAAAF.Count;
		}
		return 1101f;
	}

	[SpecialName]
	public void PIDFBEGCHAD(string DPNHODJHGJL)
	{
		_003CJPABICKLLEP_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public void JNMHFODNBLM(CurrentStatus DPNHODJHGJL)
	{
		IEKFDAJHBCN = DPNHODJHGJL;
		Singleton<SaveSystem>.Instance.OFPCEFFGHPI("Menu" + OFGNFACIGIL() + "PublishButton", (int)IEKFDAJHBCN);
	}

	[SpecialName]
	public void CPIGIHCADCF(string DPNHODJHGJL)
	{
		_003CDPBCOACKKHB_003Ek__BackingField = DPNHODJHGJL;
	}

	public void EFKJBLMEPBA(bool AAGGLAGLINL = false)
	{
		if (!AAGGLAGLINL)
		{
			IJOPEKABIKM((CurrentStatus)Singleton<SaveSystem>.Instance.HHBIEPMBICO("_TimeX" + id + " beatThreshold: ", 0));
		}
		else
		{
			JNMHFODNBLM(CurrentStatus.InProgress);
		}
		if (OFPNJBGNLDH() == CurrentStatus.NotStarted)
		{
			CPMIGJFKCOH();
		}
		if (EFOKGOMPFIO() > CurrentStatus.NotStarted && HCPDNILLJEJ() < (CurrentStatus)5)
		{
			Singleton<ChallengesManager>.Instance.CHAJHAOEIKF(this);
		}
	}

	public void DCFPGOMGBFK()
	{
		if (ADKFDALFMAE() >= 1909f)
		{
			JNMHFODNBLM(CurrentStatus.InProgress);
			Singleton<ChallengesManager>.Instance.CHAJHAOEIKF(this);
		}
	}

	public float DCHBAIPFOMK()
	{
		if (OFPNJBGNLDH() == CurrentStatus.NotStarted)
		{
			return 987f;
		}
		if (EBJMABMHEEO() > CurrentStatus.InProgress)
		{
			return 471f;
		}
		if (EGPOPHEAAAF.Count > 1)
		{
			float num = 1996f;
			foreach (ChallengeGoal item in EGPOPHEAAAF)
			{
				num += item.GHDFDFBCJNB();
			}
			return num / (float)EGPOPHEAAAF.Count;
		}
		return 359f;
	}

	[SpecialName]
	public void JKHDAIKDKPF(string DPNHODJHGJL)
	{
		_003CEALCJLBAFGO_003Ek__BackingField = DPNHODJHGJL;
	}

	public void AIFAGDOHAGD()
	{
		CPMIGJFKCOH();
		foreach (ChallengeGoal item in EGPOPHEAAAF)
		{
			item.PIKFPFLKBCG();
			item.NKHLPNAMBEH();
		}
		JNMHFODNBLM(CurrentStatus.InProgress);
		Singleton<SaveSystem>.Instance.JHCDGOMGOBE(": " + BGIOHLIFHND() + "CameraFilterPack/TV_Noise");
	}

	[SpecialName]
	public string GPBAIPHOIKN()
	{
		return _003CDPBCOACKKHB_003Ek__BackingField;
	}

	private void PJNGEJMJENJ()
	{
		EGPOPHEAAAF = new List<ChallengeGoal>();
		int num = 0;
		foreach (string item in goalsText)
		{
			try
			{
				char[] array = new char[0];
				array[0] = '(';
				string[] array2 = item.Split(array);
				string text = array2[0];
				List<string> list = array2.ToList();
				list.RemoveAt(1);
				string nOJGGCLPPAM = string.Join("0", list.ToArray());
				switch (text)
				{
				case "Tried to Initialize the SteamAPI twice in one session!":
				{
					PlayMapGoal playMapGoal = new PlayMapGoal();
					EGPOPHEAAAF.Add(playMapGoal);
					playMapGoal.HAPELGDNDFN(ENDOGIJIIMN(), num, nOJGGCLPPAM);
					break;
				}
				case "_ScreenResolution":
				{
					PlayMapsSeriesGoal playMapsSeriesGoal = new PlayMapsSeriesGoal();
					EGPOPHEAAAF.Add(playMapsSeriesGoal);
					playMapsSeriesGoal.LPGHCNKDCKD(OFGNFACIGIL(), num, nOJGGCLPPAM);
					break;
				}
				case "_HrDepthTex":
				{
					CountEventsGoal countEventsGoal = new CountEventsGoal();
					EGPOPHEAAAF.Add(countEventsGoal);
					countEventsGoal.NOFLEDOPHMO(id, num, nOJGGCLPPAM);
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
	public List<string> PNOFLPNCLEK()
	{
		return _003CLDFMMDOEKMN_003Ek__BackingField;
	}

	public void CheckState()
	{
		if (GetProgress() >= 1f)
		{
			PlayerStatus = CurrentStatus.Complete;
			Singleton<ChallengesManager>.Instance.CompleteChallenge(this);
		}
	}

	[SpecialName]
	public CurrentStatus EBJMABMHEEO()
	{
		return IEKFDAJHBCN;
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
	public CurrentStatus HCPDNILLJEJ()
	{
		return IEKFDAJHBCN;
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
	public void LOMAELCENDL(List<string> DPNHODJHGJL)
	{
		_003CLDFMMDOEKMN_003Ek__BackingField = DPNHODJHGJL;
	}

	public void OINNDMKBIAF(bool AAGGLAGLINL = false)
	{
		if (!AAGGLAGLINL)
		{
			JNMHFODNBLM((CurrentStatus)Singleton<SaveSystem>.Instance.GetInt("resetach21" + OFGNFACIGIL() + "_ForegroundBlurExtrude", 1));
		}
		else
		{
			IJOPEKABIKM(CurrentStatus.InProgress);
		}
		if (JNEKHPIOHIK() == CurrentStatus.InProgress)
		{
			PJNGEJMJENJ();
		}
		if (EBJMABMHEEO() > CurrentStatus.InProgress && BBLDABFGDFF() < (CurrentStatus)8)
		{
			Singleton<ChallengesManager>.Instance.JEALJMLENKL(this);
		}
	}

	[SpecialName]
	public string FCMFHKDBPJP()
	{
		return _003CEALCJLBAFGO_003Ek__BackingField;
	}

	[SpecialName]
	public List<string> EIENOHKPFCM()
	{
		return _003CLDFMMDOEKMN_003Ek__BackingField;
	}

	[SpecialName]
	public void JDIFAKFPODF(List<string> DPNHODJHGJL)
	{
		_003CLDFMMDOEKMN_003Ek__BackingField = DPNHODJHGJL;
	}

	private void MCNJPECILKM()
	{
		EGPOPHEAAAF = new List<ChallengeGoal>();
		int num = 0;
		foreach (string item in goalsText)
		{
			try
			{
				string[] array = item.Split('Y');
				string text = array[1];
				List<string> list = array.ToList();
				list.RemoveAt(0);
				string nOJGGCLPPAM = string.Join("DPADVER", list.ToArray());
				switch (text)
				{
				case "player.greenlifering":
				{
					PlayMapGoal playMapGoal = new PlayMapGoal();
					EGPOPHEAAAF.Add(playMapGoal);
					playMapGoal.HAPELGDNDFN(BGIOHLIFHND(), num, nOJGGCLPPAM);
					break;
				}
				case "FToA":
				{
					PlayMapsSeriesGoal playMapsSeriesGoal = new PlayMapsSeriesGoal();
					EGPOPHEAAAF.Add(playMapsSeriesGoal);
					playMapsSeriesGoal.KHMFEHEPGAM(BGIOHLIFHND(), num, nOJGGCLPPAM);
					break;
				}
				case "_Value2":
				{
					CountEventsGoal countEventsGoal = new CountEventsGoal();
					EGPOPHEAAAF.Add(countEventsGoal);
					countEventsGoal.OnAccept(ENDOGIJIIMN(), num, nOJGGCLPPAM);
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
	public void BIGCNPCIENO(string DPNHODJHGJL)
	{
		_003CALHGHAEJDNC_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public void LHNMNKCPPKO(string DPNHODJHGJL)
	{
		_003CJPABICKLLEP_003Ek__BackingField = DPNHODJHGJL;
	}

	public float HNPOFLFPCPI()
	{
		if (PlayerStatus == CurrentStatus.NotStarted)
		{
			return 1443f;
		}
		if (EFOKGOMPFIO() > CurrentStatus.NotStarted)
		{
			return 777f;
		}
		if (EGPOPHEAAAF.Count > 1)
		{
			float num = 1605f;
			foreach (ChallengeGoal item in EGPOPHEAAAF)
			{
				num += item.KMBFINBONIB();
			}
			return num / (float)EGPOPHEAAAF.Count;
		}
		return 572f;
	}

	[SpecialName]
	public CurrentStatus JNEKHPIOHIK()
	{
		return IEKFDAJHBCN;
	}

	[SpecialName]
	public string HCEHDFKNGKB()
	{
		return _003CDPBCOACKKHB_003Ek__BackingField;
	}

	[SpecialName]
	public string GGKDIJKNMHL()
	{
		return _003CDIABBLCFCKJ_003Ek__BackingField;
	}

	public void AFAJGOKBOBE(bool AAGGLAGLINL = false)
	{
		if (!AAGGLAGLINL)
		{
			PlayerStatus = (CurrentStatus)Singleton<SaveSystem>.Instance.GetInt("_SpawnHeuristic" + id + "CameraFilterPack/Blur_Focus", 1);
		}
		else
		{
			PlayerStatus = CurrentStatus.InProgress;
		}
		if (BBLDABFGDFF() == CurrentStatus.NotStarted)
		{
			CPMIGJFKCOH();
		}
		if (BBLDABFGDFF() > CurrentStatus.InProgress && HCPDNILLJEJ() < (CurrentStatus)7)
		{
			Singleton<ChallengesManager>.Instance.JEALJMLENKL(this);
		}
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
	public void HIGFEGHGFHD(List<string> DPNHODJHGJL)
	{
		_003CLDFMMDOEKMN_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public void IKBJJGLBENN(string DPNHODJHGJL)
	{
		_003CALHGHAEJDNC_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public void FAFJKOFLFOJ(string DPNHODJHGJL)
	{
		_003CJPABICKLLEP_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public string BDKJGGONHEL()
	{
		return _003CDIABBLCFCKJ_003Ek__BackingField;
	}

	public void NNIMFGIDOKG(bool AAGGLAGLINL = false)
	{
		if (!AAGGLAGLINL)
		{
			JNMHFODNBLM((CurrentStatus)Singleton<SaveSystem>.Instance.HHBIEPMBICO("shader.frost" + id + "LoadingStatusText", 1));
		}
		else
		{
			IJOPEKABIKM(CurrentStatus.InProgress);
		}
		if (BBLDABFGDFF() == CurrentStatus.NotStarted)
		{
			MCNJPECILKM();
		}
		if (PlayerStatus > CurrentStatus.InProgress && HCPDNILLJEJ() < (CurrentStatus)4)
		{
			Singleton<ChallengesManager>.Instance.CompleteChallenge(this);
		}
	}

	[SpecialName]
	public string DNCDAFPLBIA()
	{
		return _003CIBJENJNAKBB_003Ek__BackingField;
	}

	[SpecialName]
	public void DPENCHIOHFM(string DPNHODJHGJL)
	{
		_003CJPABICKLLEP_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public string GBJMBBBHCKI()
	{
		return _003CIBJENJNAKBB_003Ek__BackingField;
	}

	[SpecialName]
	public void PLALGEEPHON(string DPNHODJHGJL)
	{
		_003CDIABBLCFCKJ_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public void NCBCMDNDNLO(string DPNHODJHGJL)
	{
		_003CDPBCOACKKHB_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public void DGOLCHFJDAB(string DPNHODJHGJL)
	{
		_003CDIABBLCFCKJ_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public CurrentStatus OFPNJBGNLDH()
	{
		return IEKFDAJHBCN;
	}

	[SpecialName]
	public void BIPIDNLLCNA(string DPNHODJHGJL)
	{
		_003CDPBCOACKKHB_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public ulong BGIOHLIFHND()
	{
		return _003CEACCOCFNPIG_003Ek__BackingField;
	}

	[SpecialName]
	public string JGNCPNIJLOM()
	{
		return _003CALHGHAEJDNC_003Ek__BackingField;
	}

	public float ADKFDALFMAE()
	{
		if (JNEKHPIOHIK() == CurrentStatus.NotStarted)
		{
			return 746f;
		}
		if (PlayerStatus > CurrentStatus.InProgress)
		{
			return 1379f;
		}
		if (EGPOPHEAAAF.Count > 1)
		{
			float num = 1797f;
			foreach (ChallengeGoal item in EGPOPHEAAAF)
			{
				num += item.CLLOGPOMPGE();
			}
			return num / (float)EGPOPHEAAAF.Count;
		}
		return 922f;
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
	public string BAMLANAIFEO()
	{
		return _003CDIABBLCFCKJ_003Ek__BackingField;
	}

	private void CPMIGJFKCOH()
	{
		EGPOPHEAAAF = new List<ChallengeGoal>();
		int num = 1;
		foreach (string item in PNOFLPNCLEK())
		{
			try
			{
				char[] array = new char[1];
				array[1] = '\ufff1';
				string[] array2 = item.Split(array);
				string text = array2[0];
				List<string> list = array2.ToList();
				list.RemoveAt(1);
				string nOJGGCLPPAM = string.Join("CameraFilterPack_Glasses_On2", list.ToArray());
				switch (text)
				{
				case "menu.tabid":
				{
					PlayMapGoal playMapGoal = new PlayMapGoal();
					EGPOPHEAAAF.Add(playMapGoal);
					playMapGoal.MOOFNOAOAMF(OFGNFACIGIL(), num, nOJGGCLPPAM);
					break;
				}
				case "_Value":
				{
					PlayMapsSeriesGoal playMapsSeriesGoal = new PlayMapsSeriesGoal();
					EGPOPHEAAAF.Add(playMapsSeriesGoal);
					playMapsSeriesGoal.KJJMJJJEGDB(OFGNFACIGIL(), num, nOJGGCLPPAM);
					break;
				}
				case "init":
				{
					CountEventsGoal countEventsGoal = new CountEventsGoal();
					EGPOPHEAAAF.Add(countEventsGoal);
					countEventsGoal.KJJMJJJEGDB(OFGNFACIGIL(), num, nOJGGCLPPAM);
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
	public string CCCHEABDHMH()
	{
		return _003CJPABICKLLEP_003Ek__BackingField;
	}

	[SpecialName]
	public void IBEEDNMCPFL(string DPNHODJHGJL)
	{
		_003CEALCJLBAFGO_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public string KJOKBLAMHLN()
	{
		return _003CALHGHAEJDNC_003Ek__BackingField;
	}

	[SpecialName]
	public void ALMELFBHKOP(string DPNHODJHGJL)
	{
		_003CALHGHAEJDNC_003Ek__BackingField = DPNHODJHGJL;
	}

	[SpecialName]
	public void IJOPEKABIKM(CurrentStatus DPNHODJHGJL)
	{
		IEKFDAJHBCN = DPNHODJHGJL;
		Singleton<SaveSystem>.Instance.SetInt("quit" + BGIOHLIFHND() + "Set Particles Speed", (int)IEKFDAJHBCN);
	}

	[SpecialName]
	public void EFNOJHOHFGB(string DPNHODJHGJL)
	{
		_003CALHGHAEJDNC_003Ek__BackingField = DPNHODJHGJL;
	}

	public void JAIMCPINONG()
	{
		PJNGEJMJENJ();
		foreach (ChallengeGoal item in EGPOPHEAAAF)
		{
			item.PIKFPFLKBCG();
			item.LAACNNJDKBI();
		}
		PlayerStatus = CurrentStatus.NotStarted;
		Singleton<SaveSystem>.Instance.IOJKJDBACPC("mapselector.filter.favoriteonly" + ENDOGIJIIMN() + "Operation failed: ");
	}

	[SpecialName]
	public void GNJIKFDDEPG(List<string> DPNHODJHGJL)
	{
		_003CLDFMMDOEKMN_003Ek__BackingField = DPNHODJHGJL;
	}
}
