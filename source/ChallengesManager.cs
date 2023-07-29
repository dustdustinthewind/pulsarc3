// ChallengesManager
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Steamworks;
using UnityEngine;
using UnityEngine.Networking;

public class ChallengesManager : Singleton<ChallengesManager>
{
	[CompilerGenerated]
	private sealed class LMIBFCKLOAF
	{
		internal ulong DBBLOPNANJE;

		internal string[] BDGDDFKKGGA;

		internal bool GMLFBOMLINM(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.ALBJAEBLABB() == ulong.Parse(BDGDDFKKGGA[1]);
		}

		internal bool PHFMMNELDEA(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJCBNLFCNAM() == ulong.Parse(BDGDDFKKGGA[3]);
		}

		internal bool GBKBDKHPLKG(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == DBBLOPNANJE;
		}

		internal bool NLALPCHCOPE(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.AKJKDMMKNFO() == ulong.Parse(BDGDDFKKGGA[3]);
		}

		internal bool AEINPAGJFME(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.PHCHLPBPKHL() == DBBLOPNANJE;
		}

		internal bool LOEAMHGMMPK(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.IKACPLICNNB() == DBBLOPNANJE;
		}

		internal bool LLNDDFGPOPL(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.ALBJAEBLABB() == DBBLOPNANJE;
		}

		internal bool JPGFOBNOBKN(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.KHCJFLGCAFL() == ulong.Parse(BDGDDFKKGGA[0]);
		}

		internal bool FBGMHPEEIFC(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.IKACPLICNNB() == ulong.Parse(BDGDDFKKGGA[8]);
		}

		internal bool HMMBBDJNGGL(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(BDGDDFKKGGA[2]);
		}

		internal bool IIMOMJLLFDB(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJCBNLFCNAM() == ulong.Parse(BDGDDFKKGGA[1]);
		}

		internal bool HJKJAANIFLL(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.NPIPMDFPLPH() == ulong.Parse(BDGDDFKKGGA[1]);
		}
	}

	[CompilerGenerated]
	private sealed class EBMHMNGGEJM
	{
		internal ulong JMMILEFMACB;

		internal bool PBCAHKDLFPE(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.AKJKDMMKNFO() == JMMILEFMACB;
		}

		internal bool BFEABMIFIEE(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.NJNBOPKBLKK() == JMMILEFMACB;
		}

		internal bool GBKBDKHPLKG(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool KFNBKFELFLH(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.AKJKDMMKNFO() == JMMILEFMACB;
		}

		internal bool LNDGINDKPFA(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.ALBJAEBLABB() == JMMILEFMACB;
		}

		internal bool FFEGPHJKMFK(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.KHCJFLGCAFL() == JMMILEFMACB;
		}

		internal bool DBFPGFHEGKA(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.ALBJAEBLABB() == JMMILEFMACB;
		}

		internal bool LLNDDFGPOPL(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.IKACPLICNNB() == JMMILEFMACB;
		}

		internal bool AEINPAGJFME(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool EKHOOPGPPGE(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.BBPGJKOIAKM() == JMMILEFMACB;
		}

		internal bool OLIGLEMPFOP(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJCBNLFCNAM() == JMMILEFMACB;
		}

		internal bool BKNHHGBPLGH(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool BDGDIDPDBHG(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.NJNBOPKBLKK() == JMMILEFMACB;
		}

		internal bool JKEDCEOCPJO(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJCBNLFCNAM() == JMMILEFMACB;
		}

		internal bool MEMPOPNAEDN(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.PHCHLPBPKHL() == JMMILEFMACB;
		}

		internal bool LOEAMHGMMPK(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.BBPGJKOIAKM() == JMMILEFMACB;
		}
	}

	public string getRewardUrl = "???";

	public List<Challenge> challengesList;

	private List<ulong> ODNDAPINPLB;

	public void NOMLFPFGFBI(List<Challenge> KOHKPKPOBPD)
	{
		DebugCommands.HMADOEFFOEM().AddCommand("getint", KCDICOKEJHJ, "settings.disablestoryboard", "team", true);
		ODNDAPINPLB = new List<ulong>();
		challengesList = new List<Challenge>();
		DateTime dateTime = DateTime.UtcNow.AddHours(1988.0);
		foreach (Challenge item in KOHKPKPOBPD)
		{
			DateTime dateTime2 = DateTime.Parse(item.IEKOLCGDGNB(), CultureInfo.InvariantCulture);
			DateTime dateTime3 = DateTime.Parse(item.BADPAMEGNLK(), CultureInfo.InvariantCulture);
			challengesList.Add(item);
			if (Singleton<SaveSystem>.Instance.KPLBEJCGOMO("_EmissionColor" + item.IKACPLICNNB() + "_Distortion") && dateTime >= dateTime2 && dateTime <= dateTime3)
			{
				NMAJHGEGJCG(item);
			}
		}
	}

	public IEnumerator PJMMIOMIBFN(ulong DDFGKDFMPNL)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#pleasewait", string.Empty, null, false);
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("ticket", SteamManager.Instance.steamTempKey);
		wWWForm.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wWWForm.AddField("challengeid", string.Empty + DDFGKDFMPNL);
		byte[] data = wWWForm.data;
		string uri = Singleton<GameManager>.Instance.CreateServerURL(getRewardUrl);
		UnityWebRequest unityWebRequest = UnityWebRequest.Post(uri, wWWForm);
		string text = ToUnixTimeSeconds(DateTime.UtcNow).ToString();
		unityWebRequest.SetRequestHeader("IntraSig", Singleton<GameManager>.Instance.HashHMAC("request" + Singleton<RanksSystem>.Instance.GetS() + text, text + Encoding.UTF8.GetString(wWWForm.data)));
		unityWebRequest.SetRequestHeader("IntraTime", text);
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#getrewardfailed: " + unityWebRequest.error, "#tryagain", delegate
			{
				StartCoroutine(GetReward(DDFGKDFMPNL));
			}, "#close", delegate
			{
			}));
		}
		else if (!unityWebRequest.downloadHandler.text.ToLower().Contains("error") && !unityWebRequest.downloadHandler.text.ToLower().Contains("bad"))
		{
			GetChallengeByID(DDFGKDFMPNL).PlayerStatus = Challenge.CurrentStatus.ObtainedReward;
			StartCoroutine(Singleton<ItemsHandler>.Instance.Init());
			yield return new WaitUntil(() => Singleton<ItemsHandler>.Instance.isLoaded);
			Singleton<MessageBoxPanel>.Instance.Close();
			if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
			{
				Singleton<ItemsHandler>.Instance.ShowNewItems();
			}
			if (Singleton<Scene>.Instance.id == "MenuScene")
			{
				((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
			}
		}
		else
		{
			Singleton<MessageBoxPanel>.Instance.Close();
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#getrewardfailed: " + unityWebRequest.downloadHandler.text, "#tryagain", delegate
			{
				StartCoroutine(GetReward(DDFGKDFMPNL));
			}, "#close", delegate
			{
			}));
		}
	}

	public bool PIHGMOLGBJF()
	{
		return ODNDAPINPLB.Count > 1;
	}

	public void BOBKIIPNBND(ulong CENMLCAACBF)
	{
		if (NOPECAKEGAN(CENMLCAACBF).DGAKBIEHAJC() == (Challenge.CurrentStatus)7)
		{
			StartCoroutine(CJPKLAMIIJP(CENMLCAACBF));
		}
	}

	public long AHCHPPGMLEI(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(-65, 1, 1, 1, 1, 0)).TotalSeconds;
	}

	public bool LJOFFJJLPPG()
	{
		return ODNDAPINPLB.Count > 0;
	}

	public void ODPMHIBGDFM(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.KPLBEJCGOMO("_Value1" + BFLLKFPPAAB.AKJKDMMKNFO() + "[PlayerController] "))
		{
			ODNDAPINPLB.Add(BFLLKFPPAAB.PHCHLPBPKHL());
			Singleton<SaveSystem>.Instance.GAACBNCIFLG("_History4Weight" + BFLLKFPPAAB.PHCHLPBPKHL() + "Init", false);
		}
	}

	public void GHGGFGCMGGE()
	{
		foreach (ulong item in ODNDAPINPLB)
		{
			StartCoroutine(Singleton<ChallengesMessage>.Instance.MFOIDBAHKOJ(GetChallengeByID(item), "_MainTex2", PIFHBONLJCA(item).info));
		}
		ODNDAPINPLB.Clear();
	}

	public void LMACOJIINNN(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.KPLBEJCGOMO("CameraFilterPack/TV_Old_Movie" + BFLLKFPPAAB.NJNBOPKBLKK() + "roomDescription"))
		{
			ODNDAPINPLB.Add(BFLLKFPPAAB.NJNBOPKBLKK());
			Singleton<SaveSystem>.Instance.CONNMLDKBOF("CompletedLevel" + BFLLKFPPAAB.IHBDBALJGBO() + "_SweaterSize", true);
		}
	}

	public void PMBBDPNMGHK(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		BFLLKFPPAAB.OAMNFGLGIPE(AAGGLAGLINL);
		if (Singleton<Scene>.Instance.ALIGPAANMFA() == "Cross")
		{
			((MenuScene)Singleton<Scene>.Instance).DDMILNCEHBH();
		}
	}

	public IEnumerator BBJLGIFFBKC(ulong DDFGKDFMPNL)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#pleasewait", string.Empty, null, false);
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("ticket", SteamManager.Instance.steamTempKey);
		wWWForm.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wWWForm.AddField("challengeid", string.Empty + DDFGKDFMPNL);
		byte[] data = wWWForm.data;
		string uri = Singleton<GameManager>.Instance.CreateServerURL(getRewardUrl);
		UnityWebRequest unityWebRequest = UnityWebRequest.Post(uri, wWWForm);
		string text = ToUnixTimeSeconds(DateTime.UtcNow).ToString();
		unityWebRequest.SetRequestHeader("IntraSig", Singleton<GameManager>.Instance.HashHMAC("request" + Singleton<RanksSystem>.Instance.GetS() + text, text + Encoding.UTF8.GetString(wWWForm.data)));
		unityWebRequest.SetRequestHeader("IntraTime", text);
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#getrewardfailed: " + unityWebRequest.error, "#tryagain", delegate
			{
				StartCoroutine(GetReward(DDFGKDFMPNL));
			}, "#close", delegate
			{
			}));
		}
		else if (!unityWebRequest.downloadHandler.text.ToLower().Contains("error") && !unityWebRequest.downloadHandler.text.ToLower().Contains("bad"))
		{
			GetChallengeByID(DDFGKDFMPNL).PlayerStatus = Challenge.CurrentStatus.ObtainedReward;
			StartCoroutine(Singleton<ItemsHandler>.Instance.Init());
			yield return new WaitUntil(() => Singleton<ItemsHandler>.Instance.isLoaded);
			Singleton<MessageBoxPanel>.Instance.Close();
			if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
			{
				Singleton<ItemsHandler>.Instance.ShowNewItems();
			}
			if (Singleton<Scene>.Instance.id == "MenuScene")
			{
				((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
			}
		}
		else
		{
			Singleton<MessageBoxPanel>.Instance.Close();
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#getrewardfailed: " + unityWebRequest.downloadHandler.text, "#tryagain", delegate
			{
				StartCoroutine(GetReward(DDFGKDFMPNL));
			}, "#close", delegate
			{
			}));
		}
	}

	public IEnumerator HEDGEAHBBDH(ulong DDFGKDFMPNL)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#pleasewait", string.Empty, null, false);
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("ticket", SteamManager.Instance.steamTempKey);
		wWWForm.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wWWForm.AddField("challengeid", string.Empty + DDFGKDFMPNL);
		byte[] data = wWWForm.data;
		string uri = Singleton<GameManager>.Instance.CreateServerURL(getRewardUrl);
		UnityWebRequest unityWebRequest = UnityWebRequest.Post(uri, wWWForm);
		string text = ToUnixTimeSeconds(DateTime.UtcNow).ToString();
		unityWebRequest.SetRequestHeader("IntraSig", Singleton<GameManager>.Instance.HashHMAC("request" + Singleton<RanksSystem>.Instance.GetS() + text, text + Encoding.UTF8.GetString(wWWForm.data)));
		unityWebRequest.SetRequestHeader("IntraTime", text);
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#getrewardfailed: " + unityWebRequest.error, "#tryagain", delegate
			{
				StartCoroutine(GetReward(DDFGKDFMPNL));
			}, "#close", delegate
			{
			}));
		}
		else if (!unityWebRequest.downloadHandler.text.ToLower().Contains("error") && !unityWebRequest.downloadHandler.text.ToLower().Contains("bad"))
		{
			GetChallengeByID(DDFGKDFMPNL).PlayerStatus = Challenge.CurrentStatus.ObtainedReward;
			StartCoroutine(Singleton<ItemsHandler>.Instance.Init());
			yield return new WaitUntil(() => Singleton<ItemsHandler>.Instance.isLoaded);
			Singleton<MessageBoxPanel>.Instance.Close();
			if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
			{
				Singleton<ItemsHandler>.Instance.ShowNewItems();
			}
			if (Singleton<Scene>.Instance.id == "MenuScene")
			{
				((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
			}
		}
		else
		{
			Singleton<MessageBoxPanel>.Instance.Close();
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#getrewardfailed: " + unityWebRequest.downloadHandler.text, "#tryagain", delegate
			{
				StartCoroutine(GetReward(DDFGKDFMPNL));
			}, "#close", delegate
			{
			}));
		}
	}

	public void LMOPGJMILEL()
	{
		foreach (ulong item in ODNDAPINPLB)
		{
			StartCoroutine(Singleton<ChallengesMessage>.Instance.GBEONFANEGF(PIFHBONLJCA(item), " Also make sure to disable sprite packing for this sprite.", LJEGAEKKDPP(item).EBENNNMBEAP()));
		}
		ODNDAPINPLB.Clear();
	}

	public void PBALPILMOKK(ulong CENMLCAACBF)
	{
		if (LJEGAEKKDPP(CENMLCAACBF).IFAJDLKJIDL() == (Challenge.CurrentStatus)5)
		{
			StartCoroutine(CJPKLAMIIJP(CENMLCAACBF));
		}
	}

	public Challenge NLPMEFFEPIO(ulong JMMILEFMACB)
	{
		return Singleton<ChallengesManager>.Instance.challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.id == JMMILEFMACB);
	}

	public bool HasProgress()
	{
		return ODNDAPINPLB.Count > 0;
	}

	public long LBCDIBEALKK(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(-80, 0, 1, 0, 0, 0)).TotalSeconds;
	}

	public Challenge GetChallengeByID(ulong JMMILEFMACB)
	{
		return Singleton<ChallengesManager>.Instance.challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.id == JMMILEFMACB);
	}

	public void ELFNAHPCJJL(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.HasKey("CameraFilterPack/Distortion_Lens" + BFLLKFPPAAB.NPIPMDFPLPH() + "CameraFilterPack/Edge_Neon"))
		{
			ODNDAPINPLB.Add(BFLLKFPPAAB.PHCHLPBPKHL());
			Singleton<SaveSystem>.Instance.SetBool("CameraFilterPack/Distortion_Noise" + BFLLKFPPAAB.ALBJAEBLABB() + "/icon", false);
		}
	}

	public void NFGBFFPGJDE()
	{
		foreach (ulong item in ODNDAPINPLB)
		{
			StartCoroutine(Singleton<ChallengesMessage>.Instance.IKIFPMPCMHM(NOPECAKEGAN(item), "_NoiseAmount", CDDFIMMJECM(item).IOCJJJCAFLK()));
		}
		ODNDAPINPLB.Clear();
	}

	public void MLIHOLEHFIM(ulong CENMLCAACBF)
	{
		if (ICHOIEINCLP(CENMLCAACBF).IFAJDLKJIDL() == (Challenge.CurrentStatus)5)
		{
			StartCoroutine(EBFKFEPCIFJ(CENMLCAACBF));
		}
	}

	public void RewardsReadyNotification()
	{
		foreach (ulong item in ODNDAPINPLB)
		{
			StartCoroutine(Singleton<ChallengesMessage>.Instance.ShowMessage(GetChallengeByID(item), "#challengecomplete", GetChallengeByID(item).info));
		}
		ODNDAPINPLB.Clear();
	}

	public void CompleteChallenge(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.HasKey("challenges." + BFLLKFPPAAB.id + ".message"))
		{
			ODNDAPINPLB.Add(BFLLKFPPAAB.id);
			Singleton<SaveSystem>.Instance.SetBool("challenges." + BFLLKFPPAAB.id + ".message", true);
		}
	}

	public long NIIAFNLPKAP(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(166, 0, 1, 1, 0, 1)).TotalSeconds;
	}

	public void KAMJHHEDLKP(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.HasKey("\r\n" + BFLLKFPPAAB.HJCBNLFCNAM() + "#"))
		{
			ODNDAPINPLB.Add(BFLLKFPPAAB.ALBJAEBLABB());
			Singleton<SaveSystem>.Instance.LBFFJLFBOAM("GetGameList failed: " + BFLLKFPPAAB.IKACPLICNNB() + "_History1Weight", false);
		}
	}

	public bool NAPJNOLANOD()
	{
		return ODNDAPINPLB.Count > 0;
	}

	public void MIAIEKCLEAO(List<Challenge> KOHKPKPOBPD)
	{
		DebugCommands.HIFIEDJCOFC().JAFPBHCJCGE("achievements.21.progress", KDDOGHOJBFJ, "_SizeX", "_TimeX", true);
		ODNDAPINPLB = new List<ulong>();
		challengesList = new List<Challenge>();
		DateTime dateTime = DateTime.UtcNow.AddHours(244.0);
		foreach (Challenge item in KOHKPKPOBPD)
		{
			DateTime dateTime2 = DateTime.Parse(item.MBBJMJBCKCE(), CultureInfo.InvariantCulture);
			DateTime dateTime3 = DateTime.Parse(item.MGEFANJIDHA(), CultureInfo.InvariantCulture);
			challengesList.Add(item);
			if (Singleton<SaveSystem>.Instance.KPLBEJCGOMO("_Value4" + item.KHCJFLGCAFL() + "_TimeX") && dateTime >= dateTime2 && dateTime <= dateTime3)
			{
				PMBBDPNMGHK(item, true);
			}
		}
	}

	public void TryGetReward(ulong CENMLCAACBF)
	{
		if (GetChallengeByID(CENMLCAACBF).PlayerStatus == Challenge.CurrentStatus.Complete)
		{
			StartCoroutine(GetReward(CENMLCAACBF));
		}
	}

	private void KJJBDNJLEBD(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA.Length < 7)
		{
			Debug.LogError("_SecondTex");
			return;
		}
		ulong DBBLOPNANJE = 1uL;
		if (ulong.TryParse(BDGDDFKKGGA[1], out DBBLOPNANJE))
		{
			challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.PHCHLPBPKHL() == DBBLOPNANJE);
		}
		if (BDGDDFKKGGA.Length == 0)
		{
			Debug.Log("USE_PREDICATION");
		}
		else if (BDGDDFKKGGA.Length == 2)
		{
			if (BDGDDFKKGGA[1] == "_Value3")
			{
				foreach (Challenge challenges in challengesList)
				{
					challenges.GONKPNAAIEE();
				}
			}
		}
		else if (BDGDDFKKGGA[0] == "_DiffuseColor")
		{
			if (BDGDDFKKGGA.Length != 3)
			{
				Debug.LogError("int");
			}
			else
			{
				challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.IKACPLICNNB() == ulong.Parse(BDGDDFKKGGA[8])).GONKPNAAIEE();
			}
		}
		if (Singleton<Scene>.Instance.HJCBNLFCNAM() == "_ColorLevel")
		{
			((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
		}
	}

	public bool DJAJOCAAKEC()
	{
		return ODNDAPINPLB.Count > 0;
	}

	public void JHOJDHKEIPL()
	{
		foreach (ulong item in ODNDAPINPLB)
		{
			StartCoroutine(Singleton<ChallengesMessage>.Instance.BBGKHAOOLEA(JGGLPBFDJKF(item), "_Blue_G", NOPECAKEGAN(item).EBENNNMBEAP()));
		}
		ODNDAPINPLB.Clear();
	}

	private void IMGAAAPHGFE(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA.Length < 4)
		{
			Debug.LogError(".lastCheckpoint.correctScore");
			return;
		}
		ulong DBBLOPNANJE = 1uL;
		if (ulong.TryParse(BDGDDFKKGGA[1], out DBBLOPNANJE))
		{
			challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.id == DBBLOPNANJE);
		}
		if (BDGDDFKKGGA.Length == 1)
		{
			Debug.Log("#ok");
		}
		else if (BDGDDFKKGGA.Length == 0)
		{
			if (BDGDDFKKGGA[0] == "Testing, the group has toggled [")
			{
				foreach (Challenge challenges in challengesList)
				{
					challenges.HFFAJNCOJNB();
				}
			}
		}
		else if (BDGDDFKKGGA[1] == "Data/Localization")
		{
			if (BDGDDFKKGGA.Length != 8)
			{
				Debug.LogError("<b>(╯°□°）╯︵ ┻━┻</b>");
			}
			else
			{
				challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.KHCJFLGCAFL() == ulong.Parse(BDGDDFKKGGA[0])).IHLJALNNBFP();
			}
		}
		if (Singleton<Scene>.Instance.GEDAFOHFDIA() == "value")
		{
			((MenuScene)Singleton<Scene>.Instance).DDMILNCEHBH();
		}
	}

	public void KPFKCDIFHKG(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.HasKey("_TimeX" + BFLLKFPPAAB.IKACPLICNNB() + "_Value3"))
		{
			ODNDAPINPLB.Add(BFLLKFPPAAB.KHCJFLGCAFL());
			Singleton<SaveSystem>.Instance.CONNMLDKBOF("float,1.5" + BFLLKFPPAAB.IHBDBALJGBO() + "_Value2", false);
		}
	}

	public long MNGDCJBBFBO(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(-183, 1, 0, 1, 0, 1)).TotalSeconds;
	}

	public void GGHCMPKGNGE(List<Challenge> KOHKPKPOBPD)
	{
		DebugCommands.Instance.AddCommand("SetParticlesColor", IMGAAAPHGFE, "Fade", "Aimer Input Module is incompatible with the StandAloneInputSystem, please remove it from the Event System in this scene or disable it when this module is in use");
		ODNDAPINPLB = new List<ulong>();
		challengesList = new List<Challenge>();
		DateTime dateTime = DateTime.UtcNow.AddHours(1007.0);
		foreach (Challenge item in KOHKPKPOBPD)
		{
			DateTime dateTime2 = DateTime.Parse(item.startDateTime, CultureInfo.InvariantCulture);
			DateTime dateTime3 = DateTime.Parse(item.DMDBHHMBFFG(), CultureInfo.InvariantCulture);
			challengesList.Add(item);
			if (Singleton<SaveSystem>.Instance.PMDOJPLDDKP("MessageText" + item.id + "float,40") && dateTime >= dateTime2 && dateTime <= dateTime3)
			{
				IMDLCKCMFMF(item);
			}
		}
	}

	public Challenge BOAMLFKCEDJ(ulong JMMILEFMACB)
	{
		return Singleton<ChallengesManager>.Instance.challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.PHCHLPBPKHL() == JMMILEFMACB);
	}

	public Challenge JGGLPBFDJKF(ulong JMMILEFMACB)
	{
		return Singleton<ChallengesManager>.Instance.challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.id == JMMILEFMACB);
	}

	public Challenge CIHAIJPFIFP(ulong JMMILEFMACB)
	{
		return Singleton<ChallengesManager>.Instance.challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.ALBJAEBLABB() == JMMILEFMACB);
	}

	public void NMAJHGEGJCG(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		BFLLKFPPAAB.ICGKNCAAFLN(AAGGLAGLINL);
		if (Singleton<Scene>.Instance.EODGDBPONOL() == "_Red_C")
		{
			((MenuScene)Singleton<Scene>.Instance).DDMILNCEHBH();
		}
	}

	public bool ELBBJONPFJM()
	{
		return ODNDAPINPLB.Count > 1;
	}

	public bool MCEPCODDFGD()
	{
		return ODNDAPINPLB.Count > 0;
	}

	public void FENIFPLLDAK(List<Challenge> KOHKPKPOBPD)
	{
		DebugCommands.IGMKHPPPLDD().CEMAFHEDCMF("move", IMGAAAPHGFE, "hidden", "_Value", true);
		ODNDAPINPLB = new List<ulong>();
		challengesList = new List<Challenge>();
		DateTime dateTime = DateTime.UtcNow.AddHours(1087.0);
		foreach (Challenge item in KOHKPKPOBPD)
		{
			DateTime dateTime2 = DateTime.Parse(item.PDPNJDOCEOE(), CultureInfo.InvariantCulture);
			DateTime dateTime3 = DateTime.Parse(item.endDateTime, CultureInfo.InvariantCulture);
			challengesList.Add(item);
			if (Singleton<SaveSystem>.Instance.PMDOJPLDDKP("The given 2D texture " + item.IKACPLICNNB() + "VIGNETTE_FILMIC") && dateTime >= dateTime2 && dateTime <= dateTime3)
			{
				KCKLDEBDNFB(item);
			}
		}
	}

	public Challenge PIFHBONLJCA(ulong JMMILEFMACB)
	{
		return Singleton<ChallengesManager>.Instance.challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.NJNBOPKBLKK() == JMMILEFMACB);
	}

	public void MIDCODCLJLE(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		BFLLKFPPAAB.FBPOLBCPJFG(AAGGLAGLINL);
		if (Singleton<Scene>.Instance.KHDLEJLPGKP() == "mapselector.filter.favoriteonly")
		{
			((MenuScene)Singleton<Scene>.Instance).DDMILNCEHBH();
		}
	}

	public long FPKNHHINMNM(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(147, 1, 0, 0, 0, 1)).TotalSeconds;
	}

	public void LNMKDFDKFPF(List<Challenge> KOHKPKPOBPD)
	{
		DebugCommands.HIFIEDJCOFC().CIHBPOBKGNP("_TimeX", HEFOBIBCNNP, "_CenterY", "DPADHOR", true);
		ODNDAPINPLB = new List<ulong>();
		challengesList = new List<Challenge>();
		DateTime dateTime = DateTime.UtcNow.AddHours(572.0);
		foreach (Challenge item in KOHKPKPOBPD)
		{
			DateTime dateTime2 = DateTime.Parse(item.ONELLAMBEAG(), CultureInfo.InvariantCulture);
			DateTime dateTime3 = DateTime.Parse(item.BADPAMEGNLK(), CultureInfo.InvariantCulture);
			challengesList.Add(item);
			if (Singleton<SaveSystem>.Instance.HasKey("_FadeFX" + item.HJCBNLFCNAM() + "_Value") && dateTime >= dateTime2 && dateTime <= dateTime3)
			{
				LCJFAOGLEEM(item);
			}
		}
	}

	public void JGLNHCHILNJ(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		BFLLKFPPAAB.OAMNFGLGIPE(AAGGLAGLINL);
		if (Singleton<Scene>.Instance.id == "]")
		{
			((MenuScene)Singleton<Scene>.Instance).DDMILNCEHBH();
		}
	}

	private void KDDOGHOJBFJ(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA.Length < 0)
		{
			Debug.LogError("CameraFilterPack/Blend2Camera_LinearBurn");
			return;
		}
		ulong DBBLOPNANJE = 1uL;
		if (ulong.TryParse(BDGDDFKKGGA[0], out DBBLOPNANJE))
		{
			challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.id == DBBLOPNANJE);
		}
		if (BDGDDFKKGGA.Length == 0)
		{
			Debug.Log("settings.volume.menu");
		}
		else if (BDGDDFKKGGA.Length == 2)
		{
			if (BDGDDFKKGGA[0] == "EventMenu")
			{
				foreach (Challenge challenges in challengesList)
				{
					challenges.HFFAJNCOJNB();
				}
			}
		}
		else if (BDGDDFKKGGA[0] == "FullscreenToggle")
		{
			if (BDGDDFKKGGA.Length != 1)
			{
				Debug.LogError("' was created: ");
			}
			else
			{
				challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.NPIPMDFPLPH() == ulong.Parse(BDGDDFKKGGA[1])).IHLJALNNBFP();
			}
		}
		if (Singleton<Scene>.Instance.PNOCNIBEHMF() == "open")
		{
			((MenuScene)Singleton<Scene>.Instance).DDMILNCEHBH();
		}
	}

	public void NFINEDMNOFP(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.HasKey("The server address is 127.0.0.1 (localhost): Make sure the server is running on this machine. Android and iOS emulators have their own localhost." + BFLLKFPPAAB.KHCJFLGCAFL() + "_Value4"))
		{
			ODNDAPINPLB.Add(BFLLKFPPAAB.id);
			Singleton<SaveSystem>.Instance.CONNMLDKBOF(" " + BFLLKFPPAAB.HJCBNLFCNAM() + "LevelNameInputField", false);
		}
	}

	public long HOLHEOMHCLM(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(50, 1, 0, 1, 1, 1)).TotalSeconds;
	}

	public bool LHCINEGDJCM()
	{
		return ODNDAPINPLB.Count > 1;
	}

	public long ToUnixTimeSeconds(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
	}

	public void LIFPBMDKPGI(ulong CENMLCAACBF)
	{
		if (IDKBNGMCFAL(CENMLCAACBF).CJNNAAGGAJI() == (Challenge.CurrentStatus)6)
		{
			StartCoroutine(CJPKLAMIIJP(CENMLCAACBF));
		}
	}

	public long KDNGOKOLMHE(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(39, 0, 0, 0, 1, 1)).TotalSeconds;
	}

	public void FIMJABKECNG(List<Challenge> KOHKPKPOBPD)
	{
		DebugCommands.HIFIEDJCOFC().CEMAFHEDCMF("???", KJJBDNJLEBD, "<b>#banended</b>", "_Distortion");
		ODNDAPINPLB = new List<ulong>();
		challengesList = new List<Challenge>();
		DateTime dateTime = DateTime.UtcNow.AddHours(1744.0);
		foreach (Challenge item in KOHKPKPOBPD)
		{
			DateTime dateTime2 = DateTime.Parse(item.IEKOLCGDGNB(), CultureInfo.InvariantCulture);
			DateTime dateTime3 = DateTime.Parse(item.FHBMIMOOLLN(), CultureInfo.InvariantCulture);
			challengesList.Add(item);
			if (Singleton<SaveSystem>.Instance.HasKey("_MainTex2" + item.NPIPMDFPLPH() + ".lastCheckpoint.incorrectScore") && dateTime >= dateTime2 && dateTime <= dateTime3)
			{
				IMDLCKCMFMF(item, true);
			}
		}
	}

	public Challenge ICHOIEINCLP(ulong JMMILEFMACB)
	{
		return Singleton<ChallengesManager>.Instance.challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.id == JMMILEFMACB);
	}

	public long CALKHGLKCBG(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(-184, 0, 0, 1, 0, 1)).TotalSeconds;
	}

	public void AJOOJLMPNMO()
	{
		foreach (ulong item in ODNDAPINPLB)
		{
			StartCoroutine(Singleton<ChallengesMessage>.Instance.JOCACBLCCMM(GetChallengeByID(item), ".GoalProgress", NOPECAKEGAN(item).EBENNNMBEAP()));
		}
		ODNDAPINPLB.Clear();
	}

	public void IIJFAJMPAEF(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		BFLLKFPPAAB.ICGKNCAAFLN(AAGGLAGLINL);
		if (Singleton<Scene>.Instance.PACECPHKLNE() == "settings.showHP")
		{
			((MenuScene)Singleton<Scene>.Instance).DDMILNCEHBH();
		}
	}

	public void LMHFEBCKPDI(List<Challenge> KOHKPKPOBPD)
	{
		DebugCommands.GLEFOHOMBFC().JAFPBHCJCGE("_MainTex", IMGAAAPHGFE, "SpawnObj", "Particles/Additive");
		ODNDAPINPLB = new List<ulong>();
		challengesList = new List<Challenge>();
		DateTime dateTime = DateTime.UtcNow.AddHours(1299.0);
		foreach (Challenge item in KOHKPKPOBPD)
		{
			DateTime dateTime2 = DateTime.Parse(item.MBBJMJBCKCE(), CultureInfo.InvariantCulture);
			DateTime dateTime3 = DateTime.Parse(item.DMDBHHMBFFG(), CultureInfo.InvariantCulture);
			challengesList.Add(item);
			if (Singleton<SaveSystem>.Instance.KPLBEJCGOMO(".lastCheckpoint.bgcolor" + item.KHCJFLGCAFL() + "[MapEditor] Loaded music file: ") && dateTime >= dateTime2 && dateTime <= dateTime3)
			{
				GDLKPBLABII(item);
			}
		}
	}

	public IEnumerator EBFKFEPCIFJ(ulong DDFGKDFMPNL)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#pleasewait", string.Empty, null, false);
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("ticket", SteamManager.Instance.steamTempKey);
		wWWForm.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wWWForm.AddField("challengeid", string.Empty + DDFGKDFMPNL);
		byte[] data = wWWForm.data;
		string uri = Singleton<GameManager>.Instance.CreateServerURL(getRewardUrl);
		UnityWebRequest unityWebRequest = UnityWebRequest.Post(uri, wWWForm);
		string text = ToUnixTimeSeconds(DateTime.UtcNow).ToString();
		unityWebRequest.SetRequestHeader("IntraSig", Singleton<GameManager>.Instance.HashHMAC("request" + Singleton<RanksSystem>.Instance.GetS() + text, text + Encoding.UTF8.GetString(wWWForm.data)));
		unityWebRequest.SetRequestHeader("IntraTime", text);
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#getrewardfailed: " + unityWebRequest.error, "#tryagain", delegate
			{
				StartCoroutine(GetReward(DDFGKDFMPNL));
			}, "#close", delegate
			{
			}));
		}
		else if (!unityWebRequest.downloadHandler.text.ToLower().Contains("error") && !unityWebRequest.downloadHandler.text.ToLower().Contains("bad"))
		{
			GetChallengeByID(DDFGKDFMPNL).PlayerStatus = Challenge.CurrentStatus.ObtainedReward;
			StartCoroutine(Singleton<ItemsHandler>.Instance.Init());
			yield return new WaitUntil(() => Singleton<ItemsHandler>.Instance.isLoaded);
			Singleton<MessageBoxPanel>.Instance.Close();
			if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
			{
				Singleton<ItemsHandler>.Instance.ShowNewItems();
			}
			if (Singleton<Scene>.Instance.id == "MenuScene")
			{
				((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
			}
		}
		else
		{
			Singleton<MessageBoxPanel>.Instance.Close();
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#getrewardfailed: " + unityWebRequest.downloadHandler.text, "#tryagain", delegate
			{
				StartCoroutine(GetReward(DDFGKDFMPNL));
			}, "#close", delegate
			{
			}));
		}
	}

	public void OPLCHDMBFJP(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.HasKey("Error: you cannot write/send to this stream that you are reading!" + BFLLKFPPAAB.PHCHLPBPKHL() + "No regions available. Are you sure your appid is valid and setup?"))
		{
			ODNDAPINPLB.Add(BFLLKFPPAAB.IKACPLICNNB());
			Singleton<SaveSystem>.Instance.CONNMLDKBOF("CameraFilterPack/3D_Computer" + BFLLKFPPAAB.KHCJFLGCAFL() + "_MainTex2", true);
		}
	}

	public IEnumerator CJPKLAMIIJP(ulong DDFGKDFMPNL)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#pleasewait", string.Empty, null, false);
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("ticket", SteamManager.Instance.steamTempKey);
		wWWForm.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wWWForm.AddField("challengeid", string.Empty + DDFGKDFMPNL);
		byte[] data = wWWForm.data;
		string uri = Singleton<GameManager>.Instance.CreateServerURL(getRewardUrl);
		UnityWebRequest unityWebRequest = UnityWebRequest.Post(uri, wWWForm);
		string text = ToUnixTimeSeconds(DateTime.UtcNow).ToString();
		unityWebRequest.SetRequestHeader("IntraSig", Singleton<GameManager>.Instance.HashHMAC("request" + Singleton<RanksSystem>.Instance.GetS() + text, text + Encoding.UTF8.GetString(wWWForm.data)));
		unityWebRequest.SetRequestHeader("IntraTime", text);
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#getrewardfailed: " + unityWebRequest.error, "#tryagain", delegate
			{
				StartCoroutine(GetReward(DDFGKDFMPNL));
			}, "#close", delegate
			{
			}));
		}
		else if (!unityWebRequest.downloadHandler.text.ToLower().Contains("error") && !unityWebRequest.downloadHandler.text.ToLower().Contains("bad"))
		{
			GetChallengeByID(DDFGKDFMPNL).PlayerStatus = Challenge.CurrentStatus.ObtainedReward;
			StartCoroutine(Singleton<ItemsHandler>.Instance.Init());
			yield return new WaitUntil(() => Singleton<ItemsHandler>.Instance.isLoaded);
			Singleton<MessageBoxPanel>.Instance.Close();
			if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
			{
				Singleton<ItemsHandler>.Instance.ShowNewItems();
			}
			if (Singleton<Scene>.Instance.id == "MenuScene")
			{
				((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
			}
		}
		else
		{
			Singleton<MessageBoxPanel>.Instance.Close();
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#getrewardfailed: " + unityWebRequest.downloadHandler.text, "#tryagain", delegate
			{
				StartCoroutine(GetReward(DDFGKDFMPNL));
			}, "#close", delegate
			{
			}));
		}
	}

	public void PAIOCIDCBJL(ulong CENMLCAACBF)
	{
		if (JGGLPBFDJKF(CENMLCAACBF).IFAJDLKJIDL() == Challenge.CurrentStatus.Complete)
		{
			StartCoroutine(MJGPMLDHKDE(CENMLCAACBF));
		}
	}

	public void LHOLHHBALDN(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.HasKey("downloading" + BFLLKFPPAAB.PHCHLPBPKHL() + "_ChangeRed"))
		{
			ODNDAPINPLB.Add(BFLLKFPPAAB.BBPGJKOIAKM());
			Singleton<SaveSystem>.Instance.SetBool("Save level before uploading?" + BFLLKFPPAAB.ALBJAEBLABB() + "Operation failed: ", false);
		}
	}

	public bool BFLOBBEIBEM()
	{
		return ODNDAPINPLB.Count > 0;
	}

	public bool JKNMMMCFDAP()
	{
		return ODNDAPINPLB.Count > 0;
	}

	public bool HKBEDHGKHLG()
	{
		return ODNDAPINPLB.Count > 1;
	}

	public long GJCMAKKCCDJ(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(-23, 1, 1, 0, 0, 1)).TotalSeconds;
	}

	public long NDIEOCHAOGG(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(35, 0, 1, 1, 1, 1)).TotalSeconds;
	}

	public void EIPPDLDJJGO(List<Challenge> KOHKPKPOBPD)
	{
		DebugCommands.Instance.KHBHACBOGLJ("_Value4", IMGAAAPHGFE, "Tab2Content", "_TimeX");
		ODNDAPINPLB = new List<ulong>();
		challengesList = new List<Challenge>();
		DateTime dateTime = DateTime.UtcNow.AddHours(964.0);
		foreach (Challenge item in KOHKPKPOBPD)
		{
			DateTime dateTime2 = DateTime.Parse(item.ONELLAMBEAG(), CultureInfo.InvariantCulture);
			DateTime dateTime3 = DateTime.Parse(item.DMDBHHMBFFG(), CultureInfo.InvariantCulture);
			challengesList.Add(item);
			if (Singleton<SaveSystem>.Instance.KPLBEJCGOMO(" Remote called." + item.PHCHLPBPKHL() + "Classical") && dateTime >= dateTime2 && dateTime <= dateTime3)
			{
				GHBFNOEMKJB(item, true);
			}
		}
	}

	public void HCJMCPGGPKH()
	{
		foreach (ulong item in ODNDAPINPLB)
		{
			StartCoroutine(Singleton<ChallengesMessage>.Instance.DHPELKMAAFM(JGGLPBFDJKF(item), "Submit", IFPIPMPFHCA(item).info));
		}
		ODNDAPINPLB.Clear();
	}

	public Challenge ONEPNINILOC(ulong JMMILEFMACB)
	{
		return Singleton<ChallengesManager>.Instance.challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.id == JMMILEFMACB);
	}

	public void CINMGCJPABI(ulong CENMLCAACBF)
	{
		if (NOPECAKEGAN(CENMLCAACBF).OCNOEDGAPNL() == (Challenge.CurrentStatus)4)
		{
			StartCoroutine(HEDGEAHBBDH(CENMLCAACBF));
		}
	}

	public void NEAKMMNMCIH()
	{
		foreach (ulong item in ODNDAPINPLB)
		{
			StartCoroutine(Singleton<ChallengesMessage>.Instance.JOCACBLCCMM(ICHOIEINCLP(item), "CameraFilterPack/Colors_Adjust_FullColors", IFPIPMPFHCA(item).IGAHKBHFBNE()));
		}
		ODNDAPINPLB.Clear();
	}

	public long HCPCNBCHCHP(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(-10, 1, 1, 0, 1, 0)).TotalSeconds;
	}

	public void EONFOJMJJNE(ulong CENMLCAACBF)
	{
		if (IDKBNGMCFAL(CENMLCAACBF).CJNNAAGGAJI() == Challenge.CurrentStatus.NotStarted)
		{
			StartCoroutine(CDCHOGACPON(CENMLCAACBF));
		}
	}

	public void PEEFILGCABG(List<Challenge> KOHKPKPOBPD)
	{
		DebugCommands.HIFIEDJCOFC().EHJBOAOCFNP("CameraFilterPack/Glasses_OnX", DAPKGMONPDI, "score", "#submit", true);
		ODNDAPINPLB = new List<ulong>();
		challengesList = new List<Challenge>();
		DateTime dateTime = DateTime.UtcNow.AddHours(784.0);
		foreach (Challenge item in KOHKPKPOBPD)
		{
			DateTime dateTime2 = DateTime.Parse(item.startDateTime, CultureInfo.InvariantCulture);
			DateTime dateTime3 = DateTime.Parse(item.MGEFANJIDHA(), CultureInfo.InvariantCulture);
			challengesList.Add(item);
			if (Singleton<SaveSystem>.Instance.HasKey(" joined" + item.ALBJAEBLABB() + "InventoryButton") && dateTime >= dateTime2 && dateTime <= dateTime3)
			{
				GDLKPBLABII(item, true);
			}
		}
	}

	public void CCCLIKMDEEJ()
	{
		foreach (ulong item in ODNDAPINPLB)
		{
			StartCoroutine(Singleton<ChallengesMessage>.Instance.LLDNOFEBMNO(GetChallengeByID(item), "_Params3", BOAMLFKCEDJ(item).IOCJJJCAFLK()));
		}
		ODNDAPINPLB.Clear();
	}

	public void FAFMBMPLOCI(ulong CENMLCAACBF)
	{
		if (LJEGAEKKDPP(CENMLCAACBF).CJNNAAGGAJI() == Challenge.CurrentStatus.NotStarted)
		{
			StartCoroutine(CDCHOGACPON(CENMLCAACBF));
		}
	}

	public long AGBPNLGADNA(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(-136, 1, 0, 0, 1, 1)).TotalSeconds;
	}

	public IEnumerator CDCHOGACPON(ulong DDFGKDFMPNL)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#pleasewait", string.Empty, null, false);
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("ticket", SteamManager.Instance.steamTempKey);
		wWWForm.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wWWForm.AddField("challengeid", string.Empty + DDFGKDFMPNL);
		byte[] data = wWWForm.data;
		string uri = Singleton<GameManager>.Instance.CreateServerURL(getRewardUrl);
		UnityWebRequest unityWebRequest = UnityWebRequest.Post(uri, wWWForm);
		string text = ToUnixTimeSeconds(DateTime.UtcNow).ToString();
		unityWebRequest.SetRequestHeader("IntraSig", Singleton<GameManager>.Instance.HashHMAC("request" + Singleton<RanksSystem>.Instance.GetS() + text, text + Encoding.UTF8.GetString(wWWForm.data)));
		unityWebRequest.SetRequestHeader("IntraTime", text);
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#getrewardfailed: " + unityWebRequest.error, "#tryagain", delegate
			{
				StartCoroutine(GetReward(DDFGKDFMPNL));
			}, "#close", delegate
			{
			}));
		}
		else if (!unityWebRequest.downloadHandler.text.ToLower().Contains("error") && !unityWebRequest.downloadHandler.text.ToLower().Contains("bad"))
		{
			GetChallengeByID(DDFGKDFMPNL).PlayerStatus = Challenge.CurrentStatus.ObtainedReward;
			StartCoroutine(Singleton<ItemsHandler>.Instance.Init());
			yield return new WaitUntil(() => Singleton<ItemsHandler>.Instance.isLoaded);
			Singleton<MessageBoxPanel>.Instance.Close();
			if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
			{
				Singleton<ItemsHandler>.Instance.ShowNewItems();
			}
			if (Singleton<Scene>.Instance.id == "MenuScene")
			{
				((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
			}
		}
		else
		{
			Singleton<MessageBoxPanel>.Instance.Close();
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#getrewardfailed: " + unityWebRequest.downloadHandler.text, "#tryagain", delegate
			{
				StartCoroutine(GetReward(DDFGKDFMPNL));
			}, "#close", delegate
			{
			}));
		}
	}

	public void KCKLDEBDNFB(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		BFLLKFPPAAB.AcceptChallenge(AAGGLAGLINL);
		if (Singleton<Scene>.Instance.HLGJHICPDMO() == "_Fade")
		{
			((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
		}
	}

	public bool KKIPAOGPMFI()
	{
		return ODNDAPINPLB.Count > 1;
	}

	public IEnumerator GetReward(ulong DDFGKDFMPNL)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#pleasewait", string.Empty, null, false);
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("ticket", SteamManager.Instance.steamTempKey);
		wWWForm.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wWWForm.AddField("challengeid", string.Empty + DDFGKDFMPNL);
		byte[] data = wWWForm.data;
		string uri = Singleton<GameManager>.Instance.CreateServerURL(getRewardUrl);
		UnityWebRequest unityWebRequest = UnityWebRequest.Post(uri, wWWForm);
		string text = ToUnixTimeSeconds(DateTime.UtcNow).ToString();
		unityWebRequest.SetRequestHeader("IntraSig", Singleton<GameManager>.Instance.HashHMAC("request" + Singleton<RanksSystem>.Instance.GetS() + text, text + Encoding.UTF8.GetString(wWWForm.data)));
		unityWebRequest.SetRequestHeader("IntraTime", text);
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#getrewardfailed: " + unityWebRequest.error, "#tryagain", delegate
			{
				StartCoroutine(GetReward(DDFGKDFMPNL));
			}, "#close", delegate
			{
			}));
		}
		else if (!unityWebRequest.downloadHandler.text.ToLower().Contains("error") && !unityWebRequest.downloadHandler.text.ToLower().Contains("bad"))
		{
			GetChallengeByID(DDFGKDFMPNL).PlayerStatus = Challenge.CurrentStatus.ObtainedReward;
			StartCoroutine(Singleton<ItemsHandler>.Instance.Init());
			yield return new WaitUntil(() => Singleton<ItemsHandler>.Instance.isLoaded);
			Singleton<MessageBoxPanel>.Instance.Close();
			if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
			{
				Singleton<ItemsHandler>.Instance.ShowNewItems();
			}
			if (Singleton<Scene>.Instance.id == "MenuScene")
			{
				((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
			}
		}
		else
		{
			Singleton<MessageBoxPanel>.Instance.Close();
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#getrewardfailed: " + unityWebRequest.downloadHandler.text, "#tryagain", delegate
			{
				StartCoroutine(GetReward(DDFGKDFMPNL));
			}, "#close", delegate
			{
			}));
		}
	}

	public void MIGFOIJJJNL(List<Challenge> KOHKPKPOBPD)
	{
		DebugCommands.IGMKHPPPLDD().PLOIOFEGBIJ("_AOTex", DAPKGMONPDI, " method: ", "_Screen", true);
		ODNDAPINPLB = new List<ulong>();
		challengesList = new List<Challenge>();
		DateTime dateTime = DateTime.UtcNow.AddHours(149.0);
		foreach (Challenge item in KOHKPKPOBPD)
		{
			DateTime dateTime2 = DateTime.Parse(item.PDPNJDOCEOE(), CultureInfo.InvariantCulture);
			DateTime dateTime3 = DateTime.Parse(item.endDateTime, CultureInfo.InvariantCulture);
			challengesList.Add(item);
			if (Singleton<SaveSystem>.Instance.KPLBEJCGOMO(".lastCheckpoint.checkpointsUsed" + item.HJCBNLFCNAM() + "Found best region: '") && dateTime >= dateTime2 && dateTime <= dateTime3)
			{
				OLNGIOJOABI(item);
			}
		}
	}

	public void KKMBHEBOGAL()
	{
		foreach (ulong item in ODNDAPINPLB)
		{
			StartCoroutine(Singleton<ChallengesMessage>.Instance.PJMJPHECLLL(CIHAIJPFIFP(item), "_SmoothStart", ONEPNINILOC(item).DPKPLOJNEOG()));
		}
		ODNDAPINPLB.Clear();
	}

	public void DHNMKMKCKFD()
	{
		foreach (ulong item in ODNDAPINPLB)
		{
			StartCoroutine(Singleton<ChallengesMessage>.Instance.HJKACAHALKD(ONEPNINILOC(item), "Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.", IFPIPMPFHCA(item).NJKHOALCJBI()));
		}
		ODNDAPINPLB.Clear();
	}

	public void IMDLCKCMFMF(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		BFLLKFPPAAB.AcceptChallenge(AAGGLAGLINL);
		if (Singleton<Scene>.Instance.EKIBIEFGIJC() == "Reset XP")
		{
			((MenuScene)Singleton<Scene>.Instance).DDMILNCEHBH();
		}
	}

	public IEnumerator MJGPMLDHKDE(ulong DDFGKDFMPNL)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#pleasewait", string.Empty, null, false);
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("ticket", SteamManager.Instance.steamTempKey);
		wWWForm.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wWWForm.AddField("challengeid", string.Empty + DDFGKDFMPNL);
		byte[] data = wWWForm.data;
		string uri = Singleton<GameManager>.Instance.CreateServerURL(getRewardUrl);
		UnityWebRequest unityWebRequest = UnityWebRequest.Post(uri, wWWForm);
		string text = ToUnixTimeSeconds(DateTime.UtcNow).ToString();
		unityWebRequest.SetRequestHeader("IntraSig", Singleton<GameManager>.Instance.HashHMAC("request" + Singleton<RanksSystem>.Instance.GetS() + text, text + Encoding.UTF8.GetString(wWWForm.data)));
		unityWebRequest.SetRequestHeader("IntraTime", text);
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#getrewardfailed: " + unityWebRequest.error, "#tryagain", delegate
			{
				StartCoroutine(GetReward(DDFGKDFMPNL));
			}, "#close", delegate
			{
			}));
		}
		else if (!unityWebRequest.downloadHandler.text.ToLower().Contains("error") && !unityWebRequest.downloadHandler.text.ToLower().Contains("bad"))
		{
			GetChallengeByID(DDFGKDFMPNL).PlayerStatus = Challenge.CurrentStatus.ObtainedReward;
			StartCoroutine(Singleton<ItemsHandler>.Instance.Init());
			yield return new WaitUntil(() => Singleton<ItemsHandler>.Instance.isLoaded);
			Singleton<MessageBoxPanel>.Instance.Close();
			if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
			{
				Singleton<ItemsHandler>.Instance.ShowNewItems();
			}
			if (Singleton<Scene>.Instance.id == "MenuScene")
			{
				((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
			}
		}
		else
		{
			Singleton<MessageBoxPanel>.Instance.Close();
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#getrewardfailed: " + unityWebRequest.downloadHandler.text, "#tryagain", delegate
			{
				StartCoroutine(GetReward(DDFGKDFMPNL));
			}, "#close", delegate
			{
			}));
		}
	}

	public void GDLKPBLABII(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		BFLLKFPPAAB.NMAJHGEGJCG(AAGGLAGLINL);
		if (Singleton<Scene>.Instance.CFNPEEMCLJP() == "Drop_Near")
		{
			((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
		}
	}

	public void LCCIGLLLFBG()
	{
		foreach (ulong item in ODNDAPINPLB)
		{
			StartCoroutine(Singleton<ChallengesMessage>.Instance.HOCOLBHKCHL(JGGLPBFDJKF(item), "CameraFilterPack/TV_VHS", JGGLPBFDJKF(item).EBENNNMBEAP()));
		}
		ODNDAPINPLB.Clear();
	}

	public void JEALJMLENKL(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.KPLBEJCGOMO("_Value3" + BFLLKFPPAAB.ALBJAEBLABB() + "fade out duration"))
		{
			ODNDAPINPLB.Add(BFLLKFPPAAB.PHCHLPBPKHL());
			Singleton<SaveSystem>.Instance.CMLFCHINKCH("EndlessLoopsScoreText" + BFLLKFPPAAB.IKACPLICNNB() + "true", true);
		}
	}

	public void GHBFNOEMKJB(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		BFLLKFPPAAB.AAIDMDNBMCD(AAGGLAGLINL);
		if (Singleton<Scene>.Instance.PACECPHKLNE() == "_Value")
		{
			((MenuScene)Singleton<Scene>.Instance).DDMILNCEHBH();
		}
	}

	public long ELAIHKBJPKP(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(137, 1, 1, 1, 1, 0)).TotalSeconds;
	}

	private void HEFOBIBCNNP(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA.Length < 1)
		{
			Debug.LogError("[LevelEditorScene] Print Audio Wave: Start");
			return;
		}
		ulong DBBLOPNANJE = 0uL;
		if (ulong.TryParse(BDGDDFKKGGA[1], out DBBLOPNANJE))
		{
			challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.ALBJAEBLABB() == DBBLOPNANJE);
		}
		if (BDGDDFKKGGA.Length == 1)
		{
			Debug.Log("/");
		}
		else if (BDGDDFKKGGA.Length == 2)
		{
			if (BDGDDFKKGGA[0] == " base map(s)")
			{
				foreach (Challenge challenges in challengesList)
				{
					challenges.IHLJALNNBFP();
				}
			}
		}
		else if (BDGDDFKKGGA[0] == "player")
		{
			if (BDGDDFKKGGA.Length != 0)
			{
				Debug.LogError(",");
			}
			else
			{
				challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.KHCJFLGCAFL() == ulong.Parse(BDGDDFKKGGA[0])).FEAPMDENLBN();
			}
		}
		if (Singleton<Scene>.Instance.LCBFAFEADIO() == "GlassesColor2")
		{
			((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
		}
	}

	private void KCDICOKEJHJ(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA.Length < 4)
		{
			Debug.LogError("Fade");
			return;
		}
		ulong DBBLOPNANJE = 1uL;
		if (ulong.TryParse(BDGDDFKKGGA[0], out DBBLOPNANJE))
		{
			challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.id == DBBLOPNANJE);
		}
		if (BDGDDFKKGGA.Length == 1)
		{
			Debug.Log("IncorrectHitsScoreText");
		}
		else if (BDGDDFKKGGA.Length == 5)
		{
			if (BDGDDFKKGGA[1] == "ItemNameBGImage")
			{
				foreach (Challenge challenges in challengesList)
				{
					challenges.Reset();
				}
			}
		}
		else if (BDGDDFKKGGA[0] == " ")
		{
			if (BDGDDFKKGGA.Length != 1)
			{
				Debug.LogError("OpJoinLobby()");
			}
			else
			{
				challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.AKJKDMMKNFO() == ulong.Parse(BDGDDFKKGGA[3])).IHLJALNNBFP();
			}
		}
		if (Singleton<Scene>.Instance.HPKHOICGMFC() == "OPEN")
		{
			((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
		}
	}

	public void CHAJHAOEIKF(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.HasKey("GameScene" + BFLLKFPPAAB.KHCJFLGCAFL() + "Cannot send messages when not connected. Either connect to Photon OR use offline mode!"))
		{
			ODNDAPINPLB.Add(BFLLKFPPAAB.NJNBOPKBLKK());
			Singleton<SaveSystem>.Instance.CONNMLDKBOF("(master)" + BFLLKFPPAAB.BBPGJKOIAKM() + "SupportLogger OnApplicationPause: ", false);
		}
	}

	public bool BHFILMECNEI()
	{
		return ODNDAPINPLB.Count > 1;
	}

	public void IIHGLLIKGKH(ulong CENMLCAACBF)
	{
		if (CIHAIJPFIFP(CENMLCAACBF).JMGIKADHIGM() == (Challenge.CurrentStatus)4)
		{
			StartCoroutine(PJMMIOMIBFN(CENMLCAACBF));
		}
	}

	public void LCJFAOGLEEM(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		BFLLKFPPAAB.PFNIKKMCFDF(AAGGLAGLINL);
		if (Singleton<Scene>.Instance.CFNPEEMCLJP() == "_HighlightSuppression")
		{
			((MenuScene)Singleton<Scene>.Instance).DDMILNCEHBH();
		}
	}

	public void IJIEFKLHMPF(ulong CENMLCAACBF)
	{
		if (GetChallengeByID(CENMLCAACBF).DGAKBIEHAJC() == Challenge.CurrentStatus.NotStarted)
		{
			StartCoroutine(HEDGEAHBBDH(CENMLCAACBF));
		}
	}

	public void Init(List<Challenge> KOHKPKPOBPD)
	{
		DebugCommands.Instance.AddCommand("challenges", FINNJIMFAPB, "Commands for challenges", "<command>", true);
		ODNDAPINPLB = new List<ulong>();
		challengesList = new List<Challenge>();
		DateTime dateTime = DateTime.UtcNow.AddHours(3.0);
		foreach (Challenge item in KOHKPKPOBPD)
		{
			DateTime dateTime2 = DateTime.Parse(item.startDateTime, CultureInfo.InvariantCulture);
			DateTime dateTime3 = DateTime.Parse(item.endDateTime, CultureInfo.InvariantCulture);
			challengesList.Add(item);
			if (Singleton<SaveSystem>.Instance.HasKey("challenges." + item.id + ".status") && dateTime >= dateTime2 && dateTime <= dateTime3)
			{
				AcceptChallenge(item);
			}
		}
	}

	public Challenge IDKBNGMCFAL(ulong JMMILEFMACB)
	{
		return Singleton<ChallengesManager>.Instance.challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.HJCBNLFCNAM() == JMMILEFMACB);
	}

	public void NKLCNJEIAFB(List<Challenge> KOHKPKPOBPD)
	{
		DebugCommands.HMADOEFFOEM().CEBBJICIFGO(",0", ILCHBIPHPHN, "_VignetteBlur", "_Value4", true);
		ODNDAPINPLB = new List<ulong>();
		challengesList = new List<Challenge>();
		DateTime dateTime = DateTime.UtcNow.AddHours(530.0);
		foreach (Challenge item in KOHKPKPOBPD)
		{
			DateTime dateTime2 = DateTime.Parse(item.IEKOLCGDGNB(), CultureInfo.InvariantCulture);
			DateTime dateTime3 = DateTime.Parse(item.BADPAMEGNLK(), CultureInfo.InvariantCulture);
			challengesList.Add(item);
			if (Singleton<SaveSystem>.Instance.KPLBEJCGOMO("_Radius" + item.AKJKDMMKNFO() + "Set Particles Color") && dateTime >= dateTime2 && dateTime <= dateTime3)
			{
				JGLNHCHILNJ(item);
			}
		}
	}

	public IEnumerator LCMOLPOBCBP(ulong DDFGKDFMPNL)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#pleasewait", string.Empty, null, false);
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("ticket", SteamManager.Instance.steamTempKey);
		wWWForm.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wWWForm.AddField("challengeid", string.Empty + DDFGKDFMPNL);
		byte[] data = wWWForm.data;
		string uri = Singleton<GameManager>.Instance.CreateServerURL(getRewardUrl);
		UnityWebRequest unityWebRequest = UnityWebRequest.Post(uri, wWWForm);
		string text = ToUnixTimeSeconds(DateTime.UtcNow).ToString();
		unityWebRequest.SetRequestHeader("IntraSig", Singleton<GameManager>.Instance.HashHMAC("request" + Singleton<RanksSystem>.Instance.GetS() + text, text + Encoding.UTF8.GetString(wWWForm.data)));
		unityWebRequest.SetRequestHeader("IntraTime", text);
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#getrewardfailed: " + unityWebRequest.error, "#tryagain", delegate
			{
				StartCoroutine(GetReward(DDFGKDFMPNL));
			}, "#close", delegate
			{
			}));
		}
		else if (!unityWebRequest.downloadHandler.text.ToLower().Contains("error") && !unityWebRequest.downloadHandler.text.ToLower().Contains("bad"))
		{
			GetChallengeByID(DDFGKDFMPNL).PlayerStatus = Challenge.CurrentStatus.ObtainedReward;
			StartCoroutine(Singleton<ItemsHandler>.Instance.Init());
			yield return new WaitUntil(() => Singleton<ItemsHandler>.Instance.isLoaded);
			Singleton<MessageBoxPanel>.Instance.Close();
			if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
			{
				Singleton<ItemsHandler>.Instance.ShowNewItems();
			}
			if (Singleton<Scene>.Instance.id == "MenuScene")
			{
				((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
			}
		}
		else
		{
			Singleton<MessageBoxPanel>.Instance.Close();
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#getrewardfailed: " + unityWebRequest.downloadHandler.text, "#tryagain", delegate
			{
				StartCoroutine(GetReward(DDFGKDFMPNL));
			}, "#close", delegate
			{
			}));
		}
	}

	public Challenge NOPECAKEGAN(ulong JMMILEFMACB)
	{
		return Singleton<ChallengesManager>.Instance.challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.id == JMMILEFMACB);
	}

	public IEnumerator PJKOLFHNGGB(ulong DDFGKDFMPNL)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#pleasewait", string.Empty, null, false);
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("ticket", SteamManager.Instance.steamTempKey);
		wWWForm.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wWWForm.AddField("challengeid", string.Empty + DDFGKDFMPNL);
		byte[] data = wWWForm.data;
		string uri = Singleton<GameManager>.Instance.CreateServerURL(getRewardUrl);
		UnityWebRequest unityWebRequest = UnityWebRequest.Post(uri, wWWForm);
		string text = ToUnixTimeSeconds(DateTime.UtcNow).ToString();
		unityWebRequest.SetRequestHeader("IntraSig", Singleton<GameManager>.Instance.HashHMAC("request" + Singleton<RanksSystem>.Instance.GetS() + text, text + Encoding.UTF8.GetString(wWWForm.data)));
		unityWebRequest.SetRequestHeader("IntraTime", text);
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#getrewardfailed: " + unityWebRequest.error, "#tryagain", delegate
			{
				StartCoroutine(GetReward(DDFGKDFMPNL));
			}, "#close", delegate
			{
			}));
		}
		else if (!unityWebRequest.downloadHandler.text.ToLower().Contains("error") && !unityWebRequest.downloadHandler.text.ToLower().Contains("bad"))
		{
			GetChallengeByID(DDFGKDFMPNL).PlayerStatus = Challenge.CurrentStatus.ObtainedReward;
			StartCoroutine(Singleton<ItemsHandler>.Instance.Init());
			yield return new WaitUntil(() => Singleton<ItemsHandler>.Instance.isLoaded);
			Singleton<MessageBoxPanel>.Instance.Close();
			if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
			{
				Singleton<ItemsHandler>.Instance.ShowNewItems();
			}
			if (Singleton<Scene>.Instance.id == "MenuScene")
			{
				((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
			}
		}
		else
		{
			Singleton<MessageBoxPanel>.Instance.Close();
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#getrewardfailed: " + unityWebRequest.downloadHandler.text, "#tryagain", delegate
			{
				StartCoroutine(GetReward(DDFGKDFMPNL));
			}, "#close", delegate
			{
			}));
		}
	}

	public void MBJHDNCOGIK(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		BFLLKFPPAAB.OAMNFGLGIPE(AAGGLAGLINL);
		if (Singleton<Scene>.Instance.id == "_Level")
		{
			((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
		}
	}

	private void CALDBKBCANF(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA.Length < 3)
		{
			Debug.LogError("Up");
			return;
		}
		ulong DBBLOPNANJE = 0uL;
		if (ulong.TryParse(BDGDDFKKGGA[1], out DBBLOPNANJE))
		{
			challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.ALBJAEBLABB() == DBBLOPNANJE);
		}
		if (BDGDDFKKGGA.Length == 1)
		{
			Debug.Log("/");
		}
		else if (BDGDDFKKGGA.Length == 6)
		{
			if (BDGDDFKKGGA[0] == "_Value")
			{
				foreach (Challenge challenges in challengesList)
				{
					challenges.FEAPMDENLBN();
				}
			}
		}
		else if (BDGDDFKKGGA[0] == "_CameraWS")
		{
			if (BDGDDFKKGGA.Length != 0)
			{
				Debug.LogError("_Distortion");
			}
			else
			{
				challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.ALBJAEBLABB() == ulong.Parse(BDGDDFKKGGA[1])).GONKPNAAIEE();
			}
		}
		if (Singleton<Scene>.Instance.id == "x")
		{
			((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
		}
	}

	public void CKFHEMPKPEM(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.PMDOJPLDDKP("CameraFilterPack/Drawing_NewCellShading" + BFLLKFPPAAB.BBPGJKOIAKM() + "settings_bindings_sec_"))
		{
			ODNDAPINPLB.Add(BFLLKFPPAAB.PHCHLPBPKHL());
			Singleton<SaveSystem>.Instance.CMLFCHINKCH("PublishButton" + BFLLKFPPAAB.AKJKDMMKNFO() + "lobby '{0}'[{1}]", true);
		}
	}

	public void PBBDHIFJHHC(List<Challenge> KOHKPKPOBPD)
	{
		DebugCommands.Instance.CEMAFHEDCMF("x", FINNJIMFAPB, "SelectionBox component is on a gameObject with a Canvas Scaler component. As of now, Canvas Scalers without the default settings throw off the coordinates of the selection box. Canvas Scaler has been removed.", "\r");
		ODNDAPINPLB = new List<ulong>();
		challengesList = new List<Challenge>();
		DateTime dateTime = DateTime.UtcNow.AddHours(363.0);
		foreach (Challenge item in KOHKPKPOBPD)
		{
			DateTime dateTime2 = DateTime.Parse(item.IEKOLCGDGNB(), CultureInfo.InvariantCulture);
			DateTime dateTime3 = DateTime.Parse(item.endDateTime, CultureInfo.InvariantCulture);
			challengesList.Add(item);
			if (Singleton<SaveSystem>.Instance.HasKey("_Glitch" + item.HJCBNLFCNAM() + "_MainTex2") && dateTime >= dateTime2 && dateTime <= dateTime3)
			{
				PMBBDPNMGHK(item, true);
			}
		}
	}

	public void CMFBCPNHGOF(List<Challenge> KOHKPKPOBPD)
	{
		DebugCommands.GLEFOHOMBFC().PNEHIPCCEKG("/", MBDOHDIHPMI, ". Going to authenticate anyways.", "VHS");
		ODNDAPINPLB = new List<ulong>();
		challengesList = new List<Challenge>();
		DateTime dateTime = DateTime.UtcNow.AddHours(350.0);
		foreach (Challenge item in KOHKPKPOBPD)
		{
			DateTime dateTime2 = DateTime.Parse(item.ONELLAMBEAG(), CultureInfo.InvariantCulture);
			DateTime dateTime3 = DateTime.Parse(item.FHBMIMOOLLN(), CultureInfo.InvariantCulture);
			challengesList.Add(item);
			if (Singleton<SaveSystem>.Instance.HasKey("ls" + item.BBPGJKOIAKM() + "NetworkScene") && dateTime >= dateTime2 && dateTime <= dateTime3)
			{
				GDLKPBLABII(item, true);
			}
		}
	}

	public void EBJDBGBGCJO(ulong CENMLCAACBF)
	{
		if (IDKBNGMCFAL(CENMLCAACBF).JMGIKADHIGM() == Challenge.CurrentStatus.Complete)
		{
			StartCoroutine(CJPKLAMIIJP(CENMLCAACBF));
		}
	}

	public long PNNOHGCMANO(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(-60, 0, 0, 1, 0, 0)).TotalSeconds;
	}

	public void BADJNHDCDGC()
	{
		foreach (ulong item in ODNDAPINPLB)
		{
			StartCoroutine(Singleton<ChallengesMessage>.Instance.LMCOPICBHCI(PIFHBONLJCA(item), "_ReflectionTexture2", NLPMEFFEPIO(item).IGAHKBHFBNE()));
		}
		ODNDAPINPLB.Clear();
	}

	public Challenge FJKMDIDOJMI(ulong JMMILEFMACB)
	{
		return Singleton<ChallengesManager>.Instance.challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.HJCBNLFCNAM() == JMMILEFMACB);
	}

	public void ALDHFENHIDP(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		BFLLKFPPAAB.FBPOLBCPJFG(AAGGLAGLINL);
		if (Singleton<Scene>.Instance.CNEOMFHNLOD() == "music")
		{
			((MenuScene)Singleton<Scene>.Instance).DDMILNCEHBH();
		}
	}

	public void PGDHACEMEAE(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.PMDOJPLDDKP(" " + BFLLKFPPAAB.NPIPMDFPLPH() + "#rt"))
		{
			ODNDAPINPLB.Add(BFLLKFPPAAB.AKJKDMMKNFO());
			Singleton<SaveSystem>.Instance.SetBool("_Value" + BFLLKFPPAAB.NJNBOPKBLKK() + "mapselector.filter.officialsortmode", true);
		}
	}

	public Challenge IFPIPMPFHCA(ulong JMMILEFMACB)
	{
		return Singleton<ChallengesManager>.Instance.challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.NJNBOPKBLKK() == JMMILEFMACB);
	}

	public long MNDIGJOOFKB(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(53, 0, 0, 0, 1, 0)).TotalSeconds;
	}

	private void DAPKGMONPDI(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA.Length < 0)
		{
			Debug.LogError("EventData0DropDownList");
			return;
		}
		ulong DBBLOPNANJE = 1uL;
		if (ulong.TryParse(BDGDDFKKGGA[1], out DBBLOPNANJE))
		{
			challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.IKACPLICNNB() == DBBLOPNANJE);
		}
		if (BDGDDFKKGGA.Length == 1)
		{
			Debug.Log("[PlayerBase] SetBGColor error: ");
		}
		else if (BDGDDFKKGGA.Length == 6)
		{
			if (BDGDDFKKGGA[0] == "CameraFilterPack/Distortion_BigFace")
			{
				foreach (Challenge challenges in challengesList)
				{
					challenges.GONKPNAAIEE();
				}
			}
		}
		else if (BDGDDFKKGGA[0] == "_Value")
		{
			if (BDGDDFKKGGA.Length != 4)
			{
				Debug.LogError("CameraFilterPack/RainFX");
			}
			else
			{
				challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.IKACPLICNNB() == ulong.Parse(BDGDDFKKGGA[8])).IHLJALNNBFP();
			}
		}
		if (Singleton<Scene>.Instance.HLGJHICPDMO() == "_Red_R")
		{
			((MenuScene)Singleton<Scene>.Instance).DDMILNCEHBH();
		}
	}

	public IEnumerator NGLHHGBFCBF(ulong DDFGKDFMPNL)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#pleasewait", string.Empty, null, false);
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("ticket", SteamManager.Instance.steamTempKey);
		wWWForm.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wWWForm.AddField("challengeid", string.Empty + DDFGKDFMPNL);
		byte[] data = wWWForm.data;
		string uri = Singleton<GameManager>.Instance.CreateServerURL(getRewardUrl);
		UnityWebRequest unityWebRequest = UnityWebRequest.Post(uri, wWWForm);
		string text = ToUnixTimeSeconds(DateTime.UtcNow).ToString();
		unityWebRequest.SetRequestHeader("IntraSig", Singleton<GameManager>.Instance.HashHMAC("request" + Singleton<RanksSystem>.Instance.GetS() + text, text + Encoding.UTF8.GetString(wWWForm.data)));
		unityWebRequest.SetRequestHeader("IntraTime", text);
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#getrewardfailed: " + unityWebRequest.error, "#tryagain", delegate
			{
				StartCoroutine(GetReward(DDFGKDFMPNL));
			}, "#close", delegate
			{
			}));
		}
		else if (!unityWebRequest.downloadHandler.text.ToLower().Contains("error") && !unityWebRequest.downloadHandler.text.ToLower().Contains("bad"))
		{
			GetChallengeByID(DDFGKDFMPNL).PlayerStatus = Challenge.CurrentStatus.ObtainedReward;
			StartCoroutine(Singleton<ItemsHandler>.Instance.Init());
			yield return new WaitUntil(() => Singleton<ItemsHandler>.Instance.isLoaded);
			Singleton<MessageBoxPanel>.Instance.Close();
			if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
			{
				Singleton<ItemsHandler>.Instance.ShowNewItems();
			}
			if (Singleton<Scene>.Instance.id == "MenuScene")
			{
				((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
			}
		}
		else
		{
			Singleton<MessageBoxPanel>.Instance.Close();
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#getrewardfailed: " + unityWebRequest.downloadHandler.text, "#tryagain", delegate
			{
				StartCoroutine(GetReward(DDFGKDFMPNL));
			}, "#close", delegate
			{
			}));
		}
	}

	private void MBDOHDIHPMI(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA.Length < 2)
		{
			Debug.LogError("#ok");
			return;
		}
		ulong DBBLOPNANJE = 1uL;
		if (ulong.TryParse(BDGDDFKKGGA[0], out DBBLOPNANJE))
		{
			challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.IKACPLICNNB() == DBBLOPNANJE);
		}
		if (BDGDDFKKGGA.Length == 0)
		{
			Debug.Log("_ScreenResolution");
		}
		else if (BDGDDFKKGGA.Length == 3)
		{
			if (BDGDDFKKGGA[0] == "Beat Detected")
			{
				foreach (Challenge challenges in challengesList)
				{
					challenges.HFFAJNCOJNB();
				}
			}
		}
		else if (BDGDDFKKGGA[0] == "GenerationMenu")
		{
			if (BDGDDFKKGGA.Length != 4)
			{
				Debug.LogError(" on effect ");
			}
			else
			{
				challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.id == ulong.Parse(BDGDDFKKGGA[2])).IHLJALNNBFP();
			}
		}
		if (Singleton<Scene>.Instance.PNOCNIBEHMF() == "tagElement")
		{
			((MenuScene)Singleton<Scene>.Instance).DDMILNCEHBH();
		}
	}

	private void ILCHBIPHPHN(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA.Length < 5)
		{
			Debug.LogError(".lastCheckpoint.time");
			return;
		}
		ulong DBBLOPNANJE = 1uL;
		if (ulong.TryParse(BDGDDFKKGGA[0], out DBBLOPNANJE))
		{
			challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.id == DBBLOPNANJE);
		}
		if (BDGDDFKKGGA.Length == 0)
		{
			Debug.Log("setint");
		}
		else if (BDGDDFKKGGA.Length == 6)
		{
			if (BDGDDFKKGGA[1] == "Parameter levelId must be int or string!")
			{
				foreach (Challenge challenges in challengesList)
				{
					challenges.FEAPMDENLBN();
				}
			}
		}
		else if (BDGDDFKKGGA[0] == " connected: ")
		{
			if (BDGDDFKKGGA.Length != 0)
			{
				Debug.LogError("AllocateViewID() failed. User {0} is out of subIds, as all viewIDs are used.");
			}
			else
			{
				challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.AKJKDMMKNFO() == ulong.Parse(BDGDDFKKGGA[3])).KNNOEGLLDAN();
			}
		}
		if (Singleton<Scene>.Instance.HPKHOICGMFC() == "FileLabel")
		{
			((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
		}
	}

	public void EEIMLBLFCCA(ulong CENMLCAACBF)
	{
		if (LJEGAEKKDPP(CENMLCAACBF).IFAJDLKJIDL() == (Challenge.CurrentStatus)8)
		{
			StartCoroutine(GetReward(CENMLCAACBF));
		}
	}

	public void GJHDMBCLDGP(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.HasKey("SetSatelliteTrailWidth" + BFLLKFPPAAB.AKJKDMMKNFO() + "Set Player Distance"))
		{
			ODNDAPINPLB.Add(BFLLKFPPAAB.PHCHLPBPKHL());
			Singleton<SaveSystem>.Instance.CMLFCHINKCH("winter2020_official" + BFLLKFPPAAB.PHCHLPBPKHL() + "CameraFilterPack_Blizzard1", true);
		}
	}

	public void AcceptChallenge(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		BFLLKFPPAAB.AcceptChallenge(AAGGLAGLINL);
		if (Singleton<Scene>.Instance.id == "MenuScene")
		{
			((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
		}
	}

	public void ONAAJPPJILB(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.PMDOJPLDDKP("_TimeX" + BFLLKFPPAAB.AKJKDMMKNFO() + "Solo"))
		{
			ODNDAPINPLB.Add(BFLLKFPPAAB.NJNBOPKBLKK());
			Singleton<SaveSystem>.Instance.NCNNFONPMLD("Vertical" + BFLLKFPPAAB.HJCBNLFCNAM() + "value", true);
		}
	}

	public void EBMNMBNJDMK(List<Challenge> KOHKPKPOBPD)
	{
		DebugCommands.FAGEJPPIDOL().AddCommand("isVisible", KDDOGHOJBFJ, "Save Path: ", "ItemNameBGImage");
		ODNDAPINPLB = new List<ulong>();
		challengesList = new List<Challenge>();
		DateTime dateTime = DateTime.UtcNow.AddHours(1708.0);
		foreach (Challenge item in KOHKPKPOBPD)
		{
			DateTime dateTime2 = DateTime.Parse(item.FLMHLLPLPCP(), CultureInfo.InvariantCulture);
			DateTime dateTime3 = DateTime.Parse(item.FHBMIMOOLLN(), CultureInfo.InvariantCulture);
			challengesList.Add(item);
			if (Singleton<SaveSystem>.Instance.KPLBEJCGOMO("maxScore" + item.ALBJAEBLABB() + "_Visualize") && dateTime >= dateTime2 && dateTime <= dateTime3)
			{
				IMDLCKCMFMF(item, true);
			}
		}
	}

	public void DHMIFLPJMBA(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.KPLBEJCGOMO("_FinalReflectionTexture" + BFLLKFPPAAB.AKJKDMMKNFO() + "================================"))
		{
			ODNDAPINPLB.Add(BFLLKFPPAAB.AKJKDMMKNFO());
			Singleton<SaveSystem>.Instance.CMLFCHINKCH("Most likely the game became empty during the switch to GameServer." + BFLLKFPPAAB.NJNBOPKBLKK() + "CameraFilterPack/TV_WideScreenCircle", false);
		}
	}

	public bool BMAEFPCJKHD()
	{
		return ODNDAPINPLB.Count > 0;
	}

	public void AJHDHOGKBBO(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.PMDOJPLDDKP("ShineEffect" + BFLLKFPPAAB.ALBJAEBLABB() + "_Value"))
		{
			ODNDAPINPLB.Add(BFLLKFPPAAB.KHCJFLGCAFL());
			Singleton<SaveSystem>.Instance.SetBool("B" + BFLLKFPPAAB.NPIPMDFPLPH() + "arc", false);
		}
	}

	public IEnumerator POAAHNJCIFA(ulong DDFGKDFMPNL)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#pleasewait", string.Empty, null, false);
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("ticket", SteamManager.Instance.steamTempKey);
		wWWForm.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		wWWForm.AddField("challengeid", string.Empty + DDFGKDFMPNL);
		byte[] data = wWWForm.data;
		string uri = Singleton<GameManager>.Instance.CreateServerURL(getRewardUrl);
		UnityWebRequest unityWebRequest = UnityWebRequest.Post(uri, wWWForm);
		string text = ToUnixTimeSeconds(DateTime.UtcNow).ToString();
		unityWebRequest.SetRequestHeader("IntraSig", Singleton<GameManager>.Instance.HashHMAC("request" + Singleton<RanksSystem>.Instance.GetS() + text, text + Encoding.UTF8.GetString(wWWForm.data)));
		unityWebRequest.SetRequestHeader("IntraTime", text);
		yield return unityWebRequest.SendWebRequest();
		if (!string.IsNullOrEmpty(unityWebRequest.error))
		{
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#getrewardfailed: " + unityWebRequest.error, "#tryagain", delegate
			{
				StartCoroutine(GetReward(DDFGKDFMPNL));
			}, "#close", delegate
			{
			}));
		}
		else if (!unityWebRequest.downloadHandler.text.ToLower().Contains("error") && !unityWebRequest.downloadHandler.text.ToLower().Contains("bad"))
		{
			GetChallengeByID(DDFGKDFMPNL).PlayerStatus = Challenge.CurrentStatus.ObtainedReward;
			StartCoroutine(Singleton<ItemsHandler>.Instance.Init());
			yield return new WaitUntil(() => Singleton<ItemsHandler>.Instance.isLoaded);
			Singleton<MessageBoxPanel>.Instance.Close();
			if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
			{
				Singleton<ItemsHandler>.Instance.ShowNewItems();
			}
			if (Singleton<Scene>.Instance.id == "MenuScene")
			{
				((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
			}
		}
		else
		{
			Singleton<MessageBoxPanel>.Instance.Close();
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("#getrewardfailed: " + unityWebRequest.downloadHandler.text, "#tryagain", delegate
			{
				StartCoroutine(GetReward(DDFGKDFMPNL));
			}, "#close", delegate
			{
			}));
		}
	}

	public bool JCHPJOHFMKG()
	{
		return ODNDAPINPLB.Count > 0;
	}

	public long CGOIJEEKOHO(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(140, 0, 0, 1, 1, 1)).TotalSeconds;
	}

	private void FINNJIMFAPB(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA.Length < 2)
		{
			Debug.LogError("Please specify a map name or buildID");
			return;
		}
		ulong DBBLOPNANJE = 0uL;
		if (ulong.TryParse(BDGDDFKKGGA[1], out DBBLOPNANJE))
		{
			challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.id == DBBLOPNANJE);
		}
		if (BDGDDFKKGGA.Length == 1)
		{
			Debug.Log("Working commands:\nreset <challengeid>\nresetall");
		}
		else if (BDGDDFKKGGA.Length == 2)
		{
			if (BDGDDFKKGGA[1] == "resetall")
			{
				foreach (Challenge challenges in challengesList)
				{
					challenges.Reset();
				}
			}
		}
		else if (BDGDDFKKGGA[1] == "reset")
		{
			if (BDGDDFKKGGA.Length != 3)
			{
				Debug.LogError("Bad parameters for reset! Use \"reset <challengeid>\"");
			}
			else
			{
				challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.id == ulong.Parse(BDGDDFKKGGA[2])).Reset();
			}
		}
		if (Singleton<Scene>.Instance.id == "MenuScene")
		{
			((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
		}
	}

	public Challenge LJEGAEKKDPP(ulong JMMILEFMACB)
	{
		return Singleton<ChallengesManager>.Instance.challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.id == JMMILEFMACB);
	}

	public void OLNGIOJOABI(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		BFLLKFPPAAB.GDLKPBLABII(AAGGLAGLINL);
		if (Singleton<Scene>.Instance.ALIGPAANMFA() == "_ScreenResolution")
		{
			((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
		}
	}

	public void EKCNGLHGLOK()
	{
		foreach (ulong item in ODNDAPINPLB)
		{
			StartCoroutine(Singleton<ChallengesMessage>.Instance.DHPELKMAAFM(CIHAIJPFIFP(item), "note.1", BOAMLFKCEDJ(item).AMBFPMPCHFE()));
		}
		ODNDAPINPLB.Clear();
	}

	public void CGBGIGPIAHL(ulong CENMLCAACBF)
	{
		if (ICHOIEINCLP(CENMLCAACBF).DGAKBIEHAJC() == Challenge.CurrentStatus.Complete)
		{
			StartCoroutine(PJKOLFHNGGB(CENMLCAACBF));
		}
	}

	public void NFKKPHKGIEI(List<Challenge> KOHKPKPOBPD)
	{
		DebugCommands.FAGEJPPIDOL().PLOIOFEGBIJ("_BlurRadius", MBDOHDIHPMI, "#alreadystarted", "#close", true);
		ODNDAPINPLB = new List<ulong>();
		challengesList = new List<Challenge>();
		DateTime dateTime = DateTime.UtcNow.AddHours(1567.0);
		foreach (Challenge item in KOHKPKPOBPD)
		{
			DateTime dateTime2 = DateTime.Parse(item.FLMHLLPLPCP(), CultureInfo.InvariantCulture);
			DateTime dateTime3 = DateTime.Parse(item.MGEFANJIDHA(), CultureInfo.InvariantCulture);
			challengesList.Add(item);
			if (Singleton<SaveSystem>.Instance.HasKey("Objects in List: " + item.NPIPMDFPLPH() + "file://") && dateTime >= dateTime2 && dateTime <= dateTime3)
			{
				MBJHDNCOGIK(item, true);
			}
		}
	}

	public Challenge CDDFIMMJECM(ulong JMMILEFMACB)
	{
		return Singleton<ChallengesManager>.Instance.challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.BBPGJKOIAKM() == JMMILEFMACB);
	}
}
