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

	private IEnumerator NJOLGNIFELG(RanksSystem.Score NMHGNJMJFGO)
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

	public void ONGNADOOMCM()
	{
		Singleton<GameManager>.Instance.OpenURL(Singleton<GameManager>.Instance.CreateServerURL("_Value8") + playerId);
	}

	private void DLBODOFAJGM()
	{
	}

	private void CGDMLHLJIDK()
	{
	}

	private IEnumerator MPKAJAJPNID(RanksSystem.PlayersRank NMHGNJMJFGO)
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

	public void BDKFDJHBMPI(CSteamID JMMILEFMACB, RanksSystem.PlayersRank NMHGNJMJFGO)
	{
		playerId = JMMILEFMACB;
		StartCoroutine(DDOBIMLAJOM(NMHGNJMJFGO));
	}

	public void NKFNLLLCGGH(RanksSystem.Score NMHGNJMJFGO)
	{
		playerId = (CSteamID)ulong.Parse(NMHGNJMJFGO.GIJEEHIKLIJ());
		StartCoroutine(NJOLGNIFELG(NMHGNJMJFGO));
	}

	public void FMGPKKAHALB(RanksSystem.Score NMHGNJMJFGO)
	{
		playerId = (CSteamID)ulong.Parse(NMHGNJMJFGO.BEMGNBNHLJK());
		StartCoroutine(DCEJHOMLJNK(NMHGNJMJFGO));
	}

	private IEnumerator DCEJHOMLJNK(RanksSystem.Score NMHGNJMJFGO)
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

	private IEnumerator OBFDFAGGLKN(RanksSystem.Score NMHGNJMJFGO)
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

	private void JMEOGJHCONJ()
	{
	}

	private void JHANGPCOCIG()
	{
	}

	public void AFIJPMENFKN()
	{
		Singleton<GameManager>.Instance.OpenURL(Singleton<GameManager>.Instance.CreateServerURL("_Speed") + playerId, false);
	}

	public void NOHCKNDMNOE()
	{
		Singleton<GameManager>.Instance.FMCBLGPDACK(Singleton<GameManager>.Instance.CreateServerURL("[PlayerBase] Reset") + playerId, false);
	}

	private IEnumerator JJFNNMCPLJP(RanksSystem.PlayersRank NMHGNJMJFGO)
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

	private IEnumerator PMDGENPABPK(RanksSystem.PlayersRank NMHGNJMJFGO)
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

	public void JDAPDGIBNKK()
	{
		Singleton<GameManager>.Instance.GMOJGDKBHEL(Singleton<GameManager>.Instance.CreateServerURL("#lives") + playerId, false);
	}

	private IEnumerator NDNMBLFJPGI(RanksSystem.Score NMHGNJMJFGO)
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

	public void OPOMELAAJKL(CSteamID JMMILEFMACB, RanksSystem.PlayersRank NMHGNJMJFGO)
	{
		playerId = JMMILEFMACB;
		StartCoroutine(AIHAGADCANI(NMHGNJMJFGO));
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

	public void EMDLFLNGFAN()
	{
		Singleton<GameManager>.Instance.OpenURL(Singleton<GameManager>.Instance.JJGKGCBCGGD("Set Satellite Input") + playerId);
	}

	private void Start()
	{
	}

	private void CIPKEPDELJB()
	{
	}

	private IEnumerator CJBIIAPFLIH(RanksSystem.Score NMHGNJMJFGO)
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

	public void JLJEBIIALCK()
	{
		Singleton<GameManager>.Instance.FMCBLGPDACK(Singleton<GameManager>.Instance.JJGKGCBCGGD("_Offsets") + playerId, false);
	}

	public void OPBLCHMJOPO(RanksSystem.Score NMHGNJMJFGO)
	{
		playerId = (CSteamID)ulong.Parse(NMHGNJMJFGO.JNNPODBHMIL());
		StartCoroutine(OBFDFAGGLKN(NMHGNJMJFGO));
	}

	private IEnumerator MAEGJEFLKFC(RanksSystem.Score NMHGNJMJFGO)
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

	private void HMPGIFBJFIK()
	{
	}

	private void DIPDEHOOBPG()
	{
	}

	public void IPMGILAIMEA(RanksSystem.Score NMHGNJMJFGO)
	{
		playerId = (CSteamID)ulong.Parse(NMHGNJMJFGO.DBMLLBMLDFE());
		StartCoroutine(NJOLGNIFELG(NMHGNJMJFGO));
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

	public void EPCJLAJKDPO(CSteamID JMMILEFMACB, RanksSystem.PlayersRank NMHGNJMJFGO)
	{
		playerId = JMMILEFMACB;
		StartCoroutine(DNLDIGNLPFM(NMHGNJMJFGO));
	}

	public void PFIOHOJGMMK(RanksSystem.Score NMHGNJMJFGO)
	{
		playerId = (CSteamID)ulong.Parse(NMHGNJMJFGO.GIJEEHIKLIJ());
		StartCoroutine(DCEJHOMLJNK(NMHGNJMJFGO));
	}

	public void KFBKIBAHFBN(RanksSystem.Score NMHGNJMJFGO)
	{
		playerId = (CSteamID)ulong.Parse(NMHGNJMJFGO.BEMGNBNHLJK());
		StartCoroutine(NDNMBLFJPGI(NMHGNJMJFGO));
	}

	public void HALACLBCFEM(RanksSystem.Score NMHGNJMJFGO)
	{
		playerId = (CSteamID)ulong.Parse(NMHGNJMJFGO.BEMGNBNHLJK());
		StartCoroutine(NMFAMLINNOK(NMHGNJMJFGO));
	}

	public void LPKAEOJJKPK()
	{
		Singleton<GameManager>.Instance.GMOJGDKBHEL(Singleton<GameManager>.Instance.JJGKGCBCGGD("_Blue_R") + playerId);
	}

	public void HLKPJFKFIPG(RanksSystem.Score NMHGNJMJFGO)
	{
		playerId = (CSteamID)ulong.Parse(NMHGNJMJFGO.LFAHKCDECDC());
		StartCoroutine(CJBIIAPFLIH(NMHGNJMJFGO));
	}

	public void OpenSteamProfile()
	{
		Singleton<GameManager>.Instance.OpenURL(Singleton<GameManager>.Instance.CreateServerURL("/?player=") + playerId);
	}

	private IEnumerator NMFAMLINNOK(RanksSystem.Score NMHGNJMJFGO)
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

	private void FHPFJBFCOOF()
	{
	}

	public void InitForMap(RanksSystem.Score NMHGNJMJFGO)
	{
		playerId = (CSteamID)ulong.Parse(NMHGNJMJFGO.steamID);
		StartCoroutine(IBMJIJBHGMA(NMHGNJMJFGO));
	}

	public void OPIHMOGIABB(RanksSystem.Score NMHGNJMJFGO)
	{
		playerId = (CSteamID)ulong.Parse(NMHGNJMJFGO.JNNPODBHMIL());
		StartCoroutine(CJBIIAPFLIH(NMHGNJMJFGO));
	}

	private IEnumerator DNLDIGNLPFM(RanksSystem.PlayersRank NMHGNJMJFGO)
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

	public void IIPMAMPNALN(CSteamID JMMILEFMACB, RanksSystem.PlayersRank NMHGNJMJFGO)
	{
		playerId = JMMILEFMACB;
		StartCoroutine(DNLDIGNLPFM(NMHGNJMJFGO));
	}

	public void ACINHEIHJGL()
	{
		Singleton<GameManager>.Instance.GMOJGDKBHEL(Singleton<GameManager>.Instance.JJGKGCBCGGD("PossibleMapMaxScoreText") + playerId);
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

	private void JKFDDNMPOJH()
	{
	}

	private void DAHFFNNIGML()
	{
	}

	private IEnumerator AIHAGADCANI(RanksSystem.PlayersRank NMHGNJMJFGO)
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

	private IEnumerator NLJNFNOPFCJ(RanksSystem.PlayersRank NMHGNJMJFGO)
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

	private IEnumerator NOBEDMOMIBI(RanksSystem.Score NMHGNJMJFGO)
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

	private IEnumerator EKOCCMBEPGO(RanksSystem.Score NMHGNJMJFGO)
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

	private void MKIMDFLBFOM()
	{
	}

	public void GMHJDICKJNB(CSteamID JMMILEFMACB, RanksSystem.PlayersRank NMHGNJMJFGO)
	{
		playerId = JMMILEFMACB;
		StartCoroutine(PMDGENPABPK(NMHGNJMJFGO));
	}

	private IEnumerator IEMBFNCACKD(RanksSystem.PlayersRank NMHGNJMJFGO)
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

	public void GLCIMDMMHLM(CSteamID JMMILEFMACB, RanksSystem.PlayersRank NMHGNJMJFGO)
	{
		playerId = JMMILEFMACB;
		StartCoroutine(NLJNFNOPFCJ(NMHGNJMJFGO));
	}
}
