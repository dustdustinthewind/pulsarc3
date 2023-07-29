// OpenSteamProfileButton
using System;
using System.Collections;
using System.Globalization;
using Steamworks;
using UnityEngine;
using UnityEngine.UI;

public class OpenSteamProfileButton : MonoBehaviour
{
	[HideInInspector]
	public CSteamID playerId;

	public Image avatar;

	public Image avatarBG;

	public Text position;

	public Text username;

	public Text date;

	public Text accurancy;

	public Text misses;

	public Text score;

	public void OpenSteamProfile()
	{
		Singleton<GameManager>.Instance.OpenURL(Singleton<GameManager>.Instance.CreateServerURL("/?player=") + playerId);
	}

	private IEnumerator HMACEEHPEHI(RanksSystem.PlayersRank NMHGNJMJFGO)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(playerId));
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(playerId));
		username.text = ResourcesManager.GetLoadedSteamPlayernameColored(playerId);
		avatar.sprite = ResourcesManager.GetLoadedAvatar(playerId);
		avatarBG.color = RanksSystem.GetRankColor(NMHGNJMJFGO.place, true);
		position.text = string.Empty + NMHGNJMJFGO.place;
		DateTime mJHMIFPOJEA = DateTime.ParseExact(NMHGNJMJFGO.updated, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
		date.text = string.Empty + Helpers.GetRelativeDateTime(mJHMIFPOJEA);
		NumberFormatInfo numberFormatInfo = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
		numberFormatInfo.NumberGroupSeparator = " ";
		score.text = string.Empty + NMHGNJMJFGO.totalScore.ToString("#,0", numberFormatInfo);
		accurancy.text = string.Empty + (NMHGNJMJFGO.avgAccuracy * 100f).ToString("#,0.00", numberFormatInfo) + "%";
		misses.text = string.Empty + NMHGNJMJFGO.avgMisses.ToString("#,0.00", numberFormatInfo);
	}

	private IEnumerator DDOBIMLAJOM(RanksSystem.PlayersRank NMHGNJMJFGO)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(playerId));
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(playerId));
		username.text = ResourcesManager.GetLoadedSteamPlayernameColored(playerId);
		avatar.sprite = ResourcesManager.GetLoadedAvatar(playerId);
		avatarBG.color = RanksSystem.GetRankColor(NMHGNJMJFGO.place, true);
		position.text = string.Empty + NMHGNJMJFGO.place;
		DateTime mJHMIFPOJEA = DateTime.ParseExact(NMHGNJMJFGO.updated, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
		date.text = string.Empty + Helpers.GetRelativeDateTime(mJHMIFPOJEA);
		NumberFormatInfo numberFormatInfo = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
		numberFormatInfo.NumberGroupSeparator = " ";
		score.text = string.Empty + NMHGNJMJFGO.totalScore.ToString("#,0", numberFormatInfo);
		accurancy.text = string.Empty + (NMHGNJMJFGO.avgAccuracy * 100f).ToString("#,0.00", numberFormatInfo) + "%";
		misses.text = string.Empty + NMHGNJMJFGO.avgMisses.ToString("#,0.00", numberFormatInfo);
	}

	private IEnumerator NGHPEKIBEKH(RanksSystem.Score NMHGNJMJFGO)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(playerId));
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(playerId));
		username.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(playerId);
		avatar.sprite = ResourcesManager.GetLoadedAvatar(playerId);
		avatarBG.color = RanksSystem.GetRankColor((RanksSystem.GetLoadedRank(playerId) == null) ? (-1) : RanksSystem.GetLoadedRank(playerId).place, true);
		position.text = string.Empty + NMHGNJMJFGO.place;
		DateTime mJHMIFPOJEA = DateTime.ParseExact(NMHGNJMJFGO.date, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
		date.text = string.Empty + Helpers.GetRelativeDateTime(mJHMIFPOJEA);
		NumberFormatInfo numberFormatInfo = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
		numberFormatInfo.NumberGroupSeparator = " ";
		score.text = string.Empty + NMHGNJMJFGO.score.ToString("#,0", numberFormatInfo);
		accurancy.text = string.Empty + (NMHGNJMJFGO.accuracy * 100f).ToString("#,0.00", numberFormatInfo) + "%";
		misses.text = string.Empty + NMHGNJMJFGO.misses.ToString("#,0.00", numberFormatInfo);
	}

	private IEnumerator DKEGICAPCII(RanksSystem.PlayersRank NMHGNJMJFGO)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(playerId));
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(playerId));
		username.text = ResourcesManager.GetLoadedSteamPlayernameColored(playerId);
		avatar.sprite = ResourcesManager.GetLoadedAvatar(playerId);
		avatarBG.color = RanksSystem.GetRankColor(NMHGNJMJFGO.place, true);
		position.text = string.Empty + NMHGNJMJFGO.place;
		DateTime mJHMIFPOJEA = DateTime.ParseExact(NMHGNJMJFGO.updated, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
		date.text = string.Empty + Helpers.GetRelativeDateTime(mJHMIFPOJEA);
		NumberFormatInfo numberFormatInfo = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
		numberFormatInfo.NumberGroupSeparator = " ";
		score.text = string.Empty + NMHGNJMJFGO.totalScore.ToString("#,0", numberFormatInfo);
		accurancy.text = string.Empty + (NMHGNJMJFGO.avgAccuracy * 100f).ToString("#,0.00", numberFormatInfo) + "%";
		misses.text = string.Empty + NMHGNJMJFGO.avgMisses.ToString("#,0.00", numberFormatInfo);
	}

	private IEnumerator FBBIDIIOLLD(RanksSystem.Score NMHGNJMJFGO)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(playerId));
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(playerId));
		username.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(playerId);
		avatar.sprite = ResourcesManager.GetLoadedAvatar(playerId);
		avatarBG.color = RanksSystem.GetRankColor((RanksSystem.GetLoadedRank(playerId) == null) ? (-1) : RanksSystem.GetLoadedRank(playerId).place, true);
		position.text = string.Empty + NMHGNJMJFGO.place;
		DateTime mJHMIFPOJEA = DateTime.ParseExact(NMHGNJMJFGO.date, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
		date.text = string.Empty + Helpers.GetRelativeDateTime(mJHMIFPOJEA);
		NumberFormatInfo numberFormatInfo = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
		numberFormatInfo.NumberGroupSeparator = " ";
		score.text = string.Empty + NMHGNJMJFGO.score.ToString("#,0", numberFormatInfo);
		accurancy.text = string.Empty + (NMHGNJMJFGO.accuracy * 100f).ToString("#,0.00", numberFormatInfo) + "%";
		misses.text = string.Empty + NMHGNJMJFGO.misses.ToString("#,0.00", numberFormatInfo);
	}

	private IEnumerator MGCMPLFCAGN(RanksSystem.Score NMHGNJMJFGO)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(playerId));
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(playerId));
		username.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(playerId);
		avatar.sprite = ResourcesManager.GetLoadedAvatar(playerId);
		avatarBG.color = RanksSystem.GetRankColor((RanksSystem.GetLoadedRank(playerId) == null) ? (-1) : RanksSystem.GetLoadedRank(playerId).place, true);
		position.text = string.Empty + NMHGNJMJFGO.place;
		DateTime mJHMIFPOJEA = DateTime.ParseExact(NMHGNJMJFGO.date, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
		date.text = string.Empty + Helpers.GetRelativeDateTime(mJHMIFPOJEA);
		NumberFormatInfo numberFormatInfo = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
		numberFormatInfo.NumberGroupSeparator = " ";
		score.text = string.Empty + NMHGNJMJFGO.score.ToString("#,0", numberFormatInfo);
		accurancy.text = string.Empty + (NMHGNJMJFGO.accuracy * 100f).ToString("#,0.00", numberFormatInfo) + "%";
		misses.text = string.Empty + NMHGNJMJFGO.misses.ToString("#,0.00", numberFormatInfo);
	}

	private IEnumerator IBMJIJBHGMA(RanksSystem.Score NMHGNJMJFGO)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(playerId));
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(playerId));
		username.text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(playerId);
		avatar.sprite = ResourcesManager.GetLoadedAvatar(playerId);
		avatarBG.color = RanksSystem.GetRankColor((RanksSystem.GetLoadedRank(playerId) == null) ? (-1) : RanksSystem.GetLoadedRank(playerId).place, true);
		position.text = string.Empty + NMHGNJMJFGO.place;
		DateTime mJHMIFPOJEA = DateTime.ParseExact(NMHGNJMJFGO.date, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
		date.text = string.Empty + Helpers.GetRelativeDateTime(mJHMIFPOJEA);
		NumberFormatInfo numberFormatInfo = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
		numberFormatInfo.NumberGroupSeparator = " ";
		score.text = string.Empty + NMHGNJMJFGO.score.ToString("#,0", numberFormatInfo);
		accurancy.text = string.Empty + (NMHGNJMJFGO.accuracy * 100f).ToString("#,0.00", numberFormatInfo) + "%";
		misses.text = string.Empty + NMHGNJMJFGO.misses.ToString("#,0.00", numberFormatInfo);
	}

	public void InitForGlobalRanks(CSteamID JMMILEFMACB, RanksSystem.PlayersRank NMHGNJMJFGO)
	{
		playerId = JMMILEFMACB;
		StartCoroutine(DDOBIMLAJOM(NMHGNJMJFGO));
	}

	public void BKJGPCGMAPK(RanksSystem.Score NMHGNJMJFGO)
	{
		playerId = (CSteamID)ulong.Parse(NMHGNJMJFGO.EFEMONFHGDB());
		StartCoroutine(FBBIDIIOLLD(NMHGNJMJFGO));
	}

	public void ABABKDACGDI(RanksSystem.Score NMHGNJMJFGO)
	{
		playerId = (CSteamID)ulong.Parse(NMHGNJMJFGO.LGJPIKFGCII());
		StartCoroutine(NGHPEKIBEKH(NMHGNJMJFGO));
	}

	private void KLILJHJNICK()
	{
	}

	public void InitForMap(RanksSystem.Score NMHGNJMJFGO)
	{
		playerId = (CSteamID)ulong.Parse(NMHGNJMJFGO.steamID);
		StartCoroutine(IBMJIJBHGMA(NMHGNJMJFGO));
	}

	private void Start()
	{
	}

	public void MDNJNCCOGFK(RanksSystem.Score NMHGNJMJFGO)
	{
		playerId = (CSteamID)ulong.Parse(NMHGNJMJFGO.LGJPIKFGCII());
		StartCoroutine(FBBIDIIOLLD(NMHGNJMJFGO));
	}

	public void BDHICPOHEPJ()
	{
		Singleton<GameManager>.Instance.NJOEGFFMEIC(Singleton<GameManager>.Instance.CreateServerURL(" #") + playerId);
	}

	private void CCLNNLCOPBL()
	{
	}

	private IEnumerator CHMOJJBJLCJ(RanksSystem.PlayersRank NMHGNJMJFGO)
	{
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(playerId));
		yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(playerId));
		username.text = ResourcesManager.GetLoadedSteamPlayernameColored(playerId);
		avatar.sprite = ResourcesManager.GetLoadedAvatar(playerId);
		avatarBG.color = RanksSystem.GetRankColor(NMHGNJMJFGO.place, true);
		position.text = string.Empty + NMHGNJMJFGO.place;
		DateTime mJHMIFPOJEA = DateTime.ParseExact(NMHGNJMJFGO.updated, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
		date.text = string.Empty + Helpers.GetRelativeDateTime(mJHMIFPOJEA);
		NumberFormatInfo numberFormatInfo = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
		numberFormatInfo.NumberGroupSeparator = " ";
		score.text = string.Empty + NMHGNJMJFGO.totalScore.ToString("#,0", numberFormatInfo);
		accurancy.text = string.Empty + (NMHGNJMJFGO.avgAccuracy * 100f).ToString("#,0.00", numberFormatInfo) + "%";
		misses.text = string.Empty + NMHGNJMJFGO.avgMisses.ToString("#,0.00", numberFormatInfo);
	}

	public void IOJJDKKHOHH(CSteamID JMMILEFMACB, RanksSystem.PlayersRank NMHGNJMJFGO)
	{
		playerId = JMMILEFMACB;
		StartCoroutine(DKEGICAPCII(NMHGNJMJFGO));
	}

	public void KNIIGFIJLBN(RanksSystem.Score NMHGNJMJFGO)
	{
		playerId = (CSteamID)ulong.Parse(NMHGNJMJFGO.steamID);
		StartCoroutine(IBMJIJBHGMA(NMHGNJMJFGO));
	}
}
