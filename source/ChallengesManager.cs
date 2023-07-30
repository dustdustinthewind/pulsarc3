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

		internal bool NLALPCHCOPE(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(BDGDDFKKGGA[4]);
		}

		internal bool GBKBDKHPLKG(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == DBBLOPNANJE;
		}

		internal bool PBCAHKDLFPE(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == DBBLOPNANJE;
		}

		internal bool BFEABMIFIEE(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.BGIOHLIFHND() == DBBLOPNANJE;
		}

		internal bool MEMPOPNAEDN(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.OFGNFACIGIL() == DBBLOPNANJE;
		}

		internal bool KFNPHCCAJFD(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.ENDOGIJIIMN() == ulong.Parse(BDGDDFKKGGA[4]);
		}

		internal bool BKNHHGBPLGH(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == DBBLOPNANJE;
		}

		internal bool HMMBBDJNGGL(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(BDGDDFKKGGA[2]);
		}

		internal bool HJKJAANIFLL(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.BGIOHLIFHND() == ulong.Parse(BDGDDFKKGGA[1]);
		}

		internal bool LGKMMLGKBEF(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.ENDOGIJIIMN() == ulong.Parse(BDGDDFKKGGA[2]);
		}

		internal bool KFNBKFELFLH(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.BGIOHLIFHND() == DBBLOPNANJE;
		}

		internal bool ONEPCCGOEKI(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.ENDOGIJIIMN() == ulong.Parse(BDGDDFKKGGA[6]);
		}

		internal bool BDGDIDPDBHG(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.ENDOGIJIIMN() == DBBLOPNANJE;
		}

		internal bool LLGBONGFMBH(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(BDGDDFKKGGA[4]);
		}

		internal bool OLIGLEMPFOP(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.OFGNFACIGIL() == DBBLOPNANJE;
		}

		internal bool DBFPGFHEGKA(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.BGIOHLIFHND() == DBBLOPNANJE;
		}
	}

	[CompilerGenerated]
	private sealed class EBMHMNGGEJM
	{
		internal ulong JMMILEFMACB;

		internal bool KFNBKFELFLH(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.OFGNFACIGIL() == JMMILEFMACB;
		}

		internal bool BFEABMIFIEE(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool BDGDIDPDBHG(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.BGIOHLIFHND() == JMMILEFMACB;
		}

		internal bool EKHOOPGPPGE(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.OFGNFACIGIL() == JMMILEFMACB;
		}

		internal bool JKEDCEOCPJO(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.ENDOGIJIIMN() == JMMILEFMACB;
		}

		internal bool GBKBDKHPLKG(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool LLNDDFGPOPL(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.BGIOHLIFHND() == JMMILEFMACB;
		}

		internal bool AEINPAGJFME(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.OFGNFACIGIL() == JMMILEFMACB;
		}

		internal bool BKNHHGBPLGH(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.OFGNFACIGIL() == JMMILEFMACB;
		}

		internal bool LOEAMHGMMPK(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.OFGNFACIGIL() == JMMILEFMACB;
		}

		internal bool OLIGLEMPFOP(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool LNDGINDKPFA(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.BGIOHLIFHND() == JMMILEFMACB;
		}

		internal bool PBCAHKDLFPE(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.ENDOGIJIIMN() == JMMILEFMACB;
		}

		internal bool MEMPOPNAEDN(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool DBFPGFHEGKA(Challenge IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}
	}

	public string getRewardUrl = "???";

	public List<Challenge> challengesList;

	private List<ulong> ODNDAPINPLB;

	public void OFCPEKECFMC(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		BFLLKFPPAAB.NNIMFGIDOKG(AAGGLAGLINL);
		if (Singleton<Scene>.Instance.DINKBGAFKAH() == "BadgeText")
		{
			((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
		}
	}

	public void LIOPPCKCLDE()
	{
		foreach (ulong item in ODNDAPINPLB)
		{
			StartCoroutine(Singleton<ChallengesMessage>.Instance.ShowMessage(GetChallengeByID(item), "CameraFilterPack/Blend2Camera_ColorKey", IKKPBLDLFKH(item).info));
		}
		ODNDAPINPLB.Clear();
	}

	public void NHMHNDIMKFE(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.OHIBODCDDKB("SettingsCanvas" + BFLLKFPPAAB.ENDOGIJIIMN() + "_Green_G"))
		{
			ODNDAPINPLB.Add(BFLLKFPPAAB.OFGNFACIGIL());
			Singleton<SaveSystem>.Instance.SetBool("[UI] " + BFLLKFPPAAB.OFGNFACIGIL() + "UI Extensions/UISoftAdditive", true);
		}
	}

	private void KDDOGHOJBFJ(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA.Length < 3)
		{
			Debug.LogError("_MaxRadiusOrKInPaper");
			return;
		}
		ulong DBBLOPNANJE = 1uL;
		if (ulong.TryParse(BDGDDFKKGGA[0], out DBBLOPNANJE))
		{
			challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.BGIOHLIFHND() == DBBLOPNANJE);
		}
		if (BDGDDFKKGGA.Length == 1)
		{
			Debug.Log("menu.selectedplaymode");
		}
		else if (BDGDDFKKGGA.Length == 8)
		{
			if (BDGDDFKKGGA[1] == "Loading inventory")
			{
				foreach (Challenge challenges in challengesList)
				{
					challenges.JAIMCPINONG();
				}
			}
		}
		else if (BDGDDFKKGGA[0] == "Working.\nPlease wait..")
		{
			if (BDGDDFKKGGA.Length != 3)
			{
				Debug.LogError("stretchWidth");
			}
			else
			{
				challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.id == ulong.Parse(BDGDDFKKGGA[4])).JAIMCPINONG();
			}
		}
		if (Singleton<Scene>.Instance.OOFJKHEJJNM() == "GroupNameText")
		{
			((MenuScene)Singleton<Scene>.Instance).CHCPLHFBNBI();
		}
	}

	public bool AHPJBCMFFHA()
	{
		return ODNDAPINPLB.Count > 1;
	}

	public Challenge GetChallengeByID(ulong JMMILEFMACB)
	{
		return Singleton<ChallengesManager>.Instance.challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.id == JMMILEFMACB);
	}

	public void KKAHIHFGODN(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.HasKey("[NetworkManager] Connection failed: " + BFLLKFPPAAB.OFGNFACIGIL() + "CameraFilterPack/Blend2Camera_Screen"))
		{
			ODNDAPINPLB.Add(BFLLKFPPAAB.ENDOGIJIIMN());
			Singleton<SaveSystem>.Instance.GIKPOGCBJFI("Obtain test Item" + BFLLKFPPAAB.OFGNFACIGIL() + "CameraFilterPack/Alien_Vision", true);
		}
	}

	public void IMPMODGKJPD(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.HasKey("\n" + BFLLKFPPAAB.BGIOHLIFHND() + "Changed config"))
		{
			ODNDAPINPLB.Add(BFLLKFPPAAB.OFGNFACIGIL());
			Singleton<SaveSystem>.Instance.GIKPOGCBJFI("mapselector.filter.subscribedonly" + BFLLKFPPAAB.OFGNFACIGIL() + "Tab1Content", true);
		}
	}

	public void NHCKOOHGIBN(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.OHIBODCDDKB("_Value6" + BFLLKFPPAAB.ENDOGIJIIMN() + "BadgeImage"))
		{
			ODNDAPINPLB.Add(BFLLKFPPAAB.OFGNFACIGIL());
			Singleton<SaveSystem>.Instance.BHLOCFLKPPN("Can't set Room.MaxPlayers to: " + BFLLKFPPAAB.id + "SupportLogger ", true);
		}
	}

	public bool JDOAHMPPCCB()
	{
		return ODNDAPINPLB.Count > 0;
	}

	public void FKMBPEGKILO(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		BFLLKFPPAAB.AcceptChallenge(AAGGLAGLINL);
		if (Singleton<Scene>.Instance.DMICPEENLPH() == "curScn")
		{
			((MenuScene)Singleton<Scene>.Instance).CBKNCIMGLGK();
		}
	}

	public void PIHPLADMPHI(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.HBBEJIBFLHO("] to be droppable" + BFLLKFPPAAB.BGIOHLIFHND() + "_Visualize"))
		{
			ODNDAPINPLB.Add(BFLLKFPPAAB.ENDOGIJIIMN());
			Singleton<SaveSystem>.Instance.GIKPOGCBJFI("_DepthLevel" + BFLLKFPPAAB.OFGNFACIGIL() + "ResetButton", false);
		}
	}

	public IEnumerator ENEONGMIMAJ(ulong DDFGKDFMPNL)
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

	public bool HasProgress()
	{
		return ODNDAPINPLB.Count > 0;
	}

	public void EOGLBNCHOIO(ulong CENMLCAACBF)
	{
		if (IKKPBLDLFKH(CENMLCAACBF).OFPNJBGNLDH() == Challenge.CurrentStatus.NotStarted)
		{
			StartCoroutine(PLNGNEDBKJL(CENMLCAACBF));
		}
	}

	public void BIKHHEKODCK(ulong CENMLCAACBF)
	{
		if (GetChallengeByID(CENMLCAACBF).EFOKGOMPFIO() == Challenge.CurrentStatus.InProgress)
		{
			StartCoroutine(PLNGNEDBKJL(CENMLCAACBF));
		}
	}

	public long ToUnixTimeSeconds(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
	}

	public void KPFKCDIFHKG(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.HBBEJIBFLHO("masterSteamID" + BFLLKFPPAAB.id + "_TapLowForeground"))
		{
			ODNDAPINPLB.Add(BFLLKFPPAAB.id);
			Singleton<SaveSystem>.Instance.GIKPOGCBJFI("mapselector.filter.rateduponly" + BFLLKFPPAAB.ENDOGIJIIMN() + "_Extra2", true);
		}
	}

	public void PMBBDPNMGHK(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		BFLLKFPPAAB.EFKJBLMEPBA(AAGGLAGLINL);
		if (Singleton<Scene>.Instance.IIPMMNJPGMA() == "PUNCloudBestRegion")
		{
			((MenuScene)Singleton<Scene>.Instance).CHCPLHFBNBI();
		}
	}

	public void DKEIOCOHFFB(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.HBBEJIBFLHO("Joystick1Button11" + BFLLKFPPAAB.OFGNFACIGIL() + "UI/Particles/Hidden"))
		{
			ODNDAPINPLB.Add(BFLLKFPPAAB.OFGNFACIGIL());
			Singleton<SaveSystem>.Instance.GIKPOGCBJFI("Operation " + BFLLKFPPAAB.OFGNFACIGIL() + "_ScreenResolution", false);
		}
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

	public Challenge IKKPBLDLFKH(ulong JMMILEFMACB)
	{
		return Singleton<ChallengesManager>.Instance.challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.OFGNFACIGIL() == JMMILEFMACB);
	}

	public void MACGEHPMGCA()
	{
		foreach (ulong item in ODNDAPINPLB)
		{
			StartCoroutine(Singleton<ChallengesMessage>.Instance.IJFDCPFAPBP(JIPIKLINJOF(item), "CameraFilterPack/Retro_Loading", IKKPBLDLFKH(item).GPBAIPHOIKN()));
		}
		ODNDAPINPLB.Clear();
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

	private void NFKKELPADIB(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA.Length < 3)
		{
			Debug.LogError("_Angle");
			return;
		}
		ulong DBBLOPNANJE = 1uL;
		if (ulong.TryParse(BDGDDFKKGGA[1], out DBBLOPNANJE))
		{
			challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.BGIOHLIFHND() == DBBLOPNANJE);
		}
		if (BDGDDFKKGGA.Length == 0)
		{
			Debug.Log(": ");
		}
		else if (BDGDDFKKGGA.Length == 6)
		{
			if (BDGDDFKKGGA[1] == "CameraFilterPack/Blend2Camera_PinLight")
			{
				foreach (Challenge challenges in challengesList)
				{
					challenges.AIFAGDOHAGD();
				}
			}
		}
		else if (BDGDDFKKGGA[1] == ".")
		{
			if (BDGDDFKKGGA.Length != 7)
			{
				Debug.LogError("_Value2");
			}
			else
			{
				challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.ENDOGIJIIMN() == ulong.Parse(BDGDDFKKGGA[4])).AIFAGDOHAGD();
			}
		}
		if (Singleton<Scene>.Instance.KHDLEJLPGKP() == "907198288")
		{
			((MenuScene)Singleton<Scene>.Instance).CHCPLHFBNBI();
		}
	}

	public void OCOJEBKMIEJ(ulong CENMLCAACBF)
	{
		if (JIPIKLINJOF(CENMLCAACBF).PlayerStatus == Challenge.CurrentStatus.InProgress)
		{
			StartCoroutine(GetReward(CENMLCAACBF));
		}
	}

	public bool LFGEKLNBDAD()
	{
		return ODNDAPINPLB.Count > 1;
	}

	public void JEALJMLENKL(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.OHIBODCDDKB("_ScreenResolution" + BFLLKFPPAAB.id + "CameraFilterPack/BlurTiltShift"))
		{
			ODNDAPINPLB.Add(BFLLKFPPAAB.OFGNFACIGIL());
			Singleton<SaveSystem>.Instance.JKOMMNBGPDK("CameraFilterPack/Blend2Camera_Lighten" + BFLLKFPPAAB.BGIOHLIFHND() + "_Value2", true);
		}
	}

	public void IJNDNNGHOCM(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.OHIBODCDDKB("0.00" + BFLLKFPPAAB.ENDOGIJIIMN() + "/"))
		{
			ODNDAPINPLB.Add(BFLLKFPPAAB.id);
			Singleton<SaveSystem>.Instance.JKOMMNBGPDK("_Amount" + BFLLKFPPAAB.ENDOGIJIIMN() + "_PosX", false);
		}
	}

	public IEnumerator PLNGNEDBKJL(ulong DDFGKDFMPNL)
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

	public void GBENDPNJDHK(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		BFLLKFPPAAB.OINNDMKBIAF(AAGGLAGLINL);
		if (Singleton<Scene>.Instance.HPKHOICGMFC() == "SSAARenderTargetCamera")
		{
			((MenuScene)Singleton<Scene>.Instance).CBKNCIMGLGK();
		}
	}

	public void TryGetReward(ulong CENMLCAACBF)
	{
		if (GetChallengeByID(CENMLCAACBF).PlayerStatus == Challenge.CurrentStatus.Complete)
		{
			StartCoroutine(GetReward(CENMLCAACBF));
		}
	}

	public Challenge JIPIKLINJOF(ulong JMMILEFMACB)
	{
		return Singleton<ChallengesManager>.Instance.challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.OFGNFACIGIL() == JMMILEFMACB);
	}

	public void ONAAJPPJILB(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.HasKey("00" + BFLLKFPPAAB.id + "_Level"))
		{
			ODNDAPINPLB.Add(BFLLKFPPAAB.id);
			Singleton<SaveSystem>.Instance.BHLOCFLKPPN("ItemNameText" + BFLLKFPPAAB.BGIOHLIFHND() + "&search=", true);
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

	public void KCEHNEPHBPH(ulong CENMLCAACBF)
	{
		if (JIPIKLINJOF(CENMLCAACBF).HCPDNILLJEJ() == (Challenge.CurrentStatus)5)
		{
			StartCoroutine(PLNGNEDBKJL(CENMLCAACBF));
		}
	}

	public void PGKKNFMKAEC()
	{
		foreach (ulong item in ODNDAPINPLB)
		{
			StartCoroutine(Singleton<ChallengesMessage>.Instance.BKLEAFCFGIF(PBOAKKCBNFB(item), "_MainTex2", IKKPBLDLFKH(item).HCEHDFKNGKB()));
		}
		ODNDAPINPLB.Clear();
	}

	public void KCKLDEBDNFB(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		BFLLKFPPAAB.EFKJBLMEPBA(AAGGLAGLINL);
		if (Singleton<Scene>.Instance.IIPMMNJPGMA() == "SetPosition")
		{
			((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
		}
	}

	public void LNMNGPIDLCN(ulong CENMLCAACBF)
	{
		if (GetChallengeByID(CENMLCAACBF).JNEKHPIOHIK() == (Challenge.CurrentStatus)8)
		{
			StartCoroutine(ENEONGMIMAJ(CENMLCAACBF));
		}
	}

	public void OBPBHCBIHCJ(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.HasKey("No Dispatcher exists in the scene. Actions will not be invoked!" + BFLLKFPPAAB.id + "_EdgeSize"))
		{
			ODNDAPINPLB.Add(BFLLKFPPAAB.BGIOHLIFHND());
			Singleton<SaveSystem>.Instance.GIKPOGCBJFI("_Red_B" + BFLLKFPPAAB.BGIOHLIFHND() + "_DistortionSize", false);
		}
	}

	public void FECMEIJGLJI(List<Challenge> KOHKPKPOBPD)
	{
		DebugCommands.FAGEJPPIDOL().JAFPBHCJCGE("_TimeX", NFKKELPADIB, "mapselector.filter.favoriteonly", "_ToneCurveRange", true);
		ODNDAPINPLB = new List<ulong>();
		challengesList = new List<Challenge>();
		DateTime dateTime = DateTime.UtcNow.AddHours(1575.0);
		foreach (Challenge item in KOHKPKPOBPD)
		{
			DateTime dateTime2 = DateTime.Parse(item.DNCDAFPLBIA(), CultureInfo.InvariantCulture);
			DateTime dateTime3 = DateTime.Parse(item.endDateTime, CultureInfo.InvariantCulture);
			challengesList.Add(item);
			if (Singleton<SaveSystem>.Instance.OHIBODCDDKB("/C tasklist" + item.BGIOHLIFHND() + "Tried to Initialize the SteamAPI twice in one session!") && dateTime >= dateTime2 && dateTime <= dateTime3)
			{
				CDDLPAHMHHJ(item);
			}
		}
	}

	public Challenge PBOAKKCBNFB(ulong JMMILEFMACB)
	{
		return Singleton<ChallengesManager>.Instance.challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.BGIOHLIFHND() == JMMILEFMACB);
	}

	public void CHAJHAOEIKF(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.HBBEJIBFLHO(" " + BFLLKFPPAAB.OFGNFACIGIL() + "grid"))
		{
			ODNDAPINPLB.Add(BFLLKFPPAAB.ENDOGIJIIMN());
			Singleton<SaveSystem>.Instance.JKOMMNBGPDK("_TimeX" + BFLLKFPPAAB.id + "Left ", false);
		}
	}

	public void CDDLPAHMHHJ(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		BFLLKFPPAAB.NNIMFGIDOKG(AAGGLAGLINL);
		if (Singleton<Scene>.Instance.INGBCJIGOJK() == "\\\"")
		{
			((MenuScene)Singleton<Scene>.Instance).CBKNCIMGLGK();
		}
	}

	public void GKFIEBJAILE()
	{
		foreach (ulong item in ODNDAPINPLB)
		{
			StartCoroutine(Singleton<ChallengesMessage>.Instance.FPKCOIJLBLN(IKKPBLDLFKH(item), "_Red_R", PBOAKKCBNFB(item).info));
		}
		ODNDAPINPLB.Clear();
	}

	public bool FEBLIDAIGAG()
	{
		return ODNDAPINPLB.Count > 1;
	}

	public void AcceptChallenge(Challenge BFLLKFPPAAB, bool AAGGLAGLINL = false)
	{
		BFLLKFPPAAB.AcceptChallenge(AAGGLAGLINL);
		if (Singleton<Scene>.Instance.id == "MenuScene")
		{
			((MenuScene)Singleton<Scene>.Instance).UpdateChallengesTile();
		}
	}

	private void GBCPMNOJGDJ(string[] BDGDDFKKGGA)
	{
		if (BDGDDFKKGGA.Length < 4)
		{
			Debug.LogError("_ScreenResolution");
			return;
		}
		ulong DBBLOPNANJE = 1uL;
		if (ulong.TryParse(BDGDDFKKGGA[1], out DBBLOPNANJE))
		{
			challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.ENDOGIJIIMN() == DBBLOPNANJE);
		}
		if (BDGDDFKKGGA.Length == 0)
		{
			Debug.Log("_Gain");
		}
		else if (BDGDDFKKGGA.Length == 3)
		{
			if (BDGDDFKKGGA[1] == "13")
			{
				foreach (Challenge challenges in challengesList)
				{
					challenges.AIFAGDOHAGD();
				}
			}
		}
		else if (BDGDDFKKGGA[1] == "Bad parameters for getint! Use <key> <value>")
		{
			if (BDGDDFKKGGA.Length != 4)
			{
				Debug.LogError("]. Please verify you have this gameobject in a Resources folder.");
			}
			else
			{
				challengesList.Find((Challenge IACGDFHKCAE) => IACGDFHKCAE.id == ulong.Parse(BDGDDFKKGGA[4])).AIFAGDOHAGD();
			}
		}
		if (Singleton<Scene>.Instance.PGNOPJPKDEA() == "ViewMenu")
		{
			((MenuScene)Singleton<Scene>.Instance).CHCPLHFBNBI();
		}
	}

	public long AHCHPPGMLEI(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(-78, 1, 1, 0, 0, 0)).TotalSeconds;
	}

	public void CompleteChallenge(Challenge BFLLKFPPAAB)
	{
		if (!Singleton<SaveSystem>.Instance.HasKey("challenges." + BFLLKFPPAAB.id + ".message"))
		{
			ODNDAPINPLB.Add(BFLLKFPPAAB.id);
			Singleton<SaveSystem>.Instance.SetBool("challenges." + BFLLKFPPAAB.id + ".message", true);
		}
	}

	public void PCBHFLCFPIO()
	{
		foreach (ulong item in ODNDAPINPLB)
		{
			StartCoroutine(Singleton<ChallengesMessage>.Instance.FPCHLDCNODE(JIPIKLINJOF(item), "maps.", IKKPBLDLFKH(item).GPBAIPHOIKN()));
		}
		ODNDAPINPLB.Clear();
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

	public void ABJOHBOOJPG()
	{
		foreach (ulong item in ODNDAPINPLB)
		{
			StartCoroutine(Singleton<ChallengesMessage>.Instance.EOAALFEALFB(JIPIKLINJOF(item), "\" gets executed locally only, if at all.", GetChallengeByID(item).HCEHDFKNGKB()));
		}
		ODNDAPINPLB.Clear();
	}

	public long NHBOHPPIALG(DateTime LPGNCFKLMEH)
	{
		return (long)(LPGNCFKLMEH - new DateTime(-43, 0, 0, 0, 1, 0)).TotalSeconds;
	}
}
