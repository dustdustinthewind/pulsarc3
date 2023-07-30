// RanksViewer
using System;
using System.Collections;
using Newtonsoft.Json;
using Steamworks;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class RanksViewer : Singleton<RanksViewer>
{
	public int ranksPerPage = 100;

	public Button buttonBack;

	public GameObject ranksCanvas;

	public GameObject ranksListContent;

	public Text infoText;

	public GameObject pageNavScrollRectContent;

	public GameObject pageNavPrevPageButton;

	public GameObject pageNavCurrentPageButton;

	public GameObject pageNavNextPageButton;

	public GameObject loadingCanvas;

	public GameObject highscoresElement;

	public GameObject highscoresTitleElement;

	public InputField searchInputField;

	[HideInInspector]
	public int currentPageID;

	public int pagesCount;

	private string OOBHCDCCFJJ = string.Empty;

	private int NOFOMIDHENF;

	private string CAFHKDIIDEE = string.Empty;

	private string IKAGNOFHOGA = string.Empty;

	public void AAFFDEHNNPL(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 0)
		{
			if (currentPageID > 0)
			{
				currentPageID -= 0;
				OJLILHCNGIH();
				StartCoroutine(ReloadPage());
			}
		}
		else if (currentPageID + 1 < pagesCount)
		{
			currentPageID++;
			HFEIKAOAMDN();
			StartCoroutine(BPBPKGNFJNP());
		}
	}

	private IEnumerator HFLGIJCJMHM(string CAFHKDIIDEE)
	{
		loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		GameObject gameObject = ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		WWW wWW = new WWW(Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.leaderboardUrl) + "&map=" + CAFHKDIIDEE + "&page=" + (currentPageID + 1) + "&search=" + OOBHCDCCFJJ);
		yield return wWW;
		if (!string.IsNullOrEmpty(wWW.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + wWW.error);
		}
		else
		{
			BAHKGHFGJLM(gameObject);
			RanksSystem.MapLeaderboard mapLeaderboard = JsonConvert.DeserializeObject<RanksSystem.MapLeaderboard>(wWW.text);
			int num = currentPageID * ranksPerPage;
			int num2;
			int count;
			if ((currentPageID + 1) * ranksPerPage <= mapLeaderboard.scores.Count)
			{
				num2 = (currentPageID + 1) * ranksPerPage;
			}
			else
				count = mapLeaderboard.scores.Count;
			pagesCount = (int)Math.Ceiling((double)mapLeaderboard.entriesCount / (double)ranksPerPage);
			foreach (RanksSystem.Score score in mapLeaderboard.scores)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate(highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					CSteamID cSteamID = (CSteamID)ulong.Parse(score.steamID);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForMap(score);
				}
				catch (Exception)
				{
				}
			}
		}
		HOAHBPOGNKA();
		yield return true;
		loadingCanvas.SetActive(false);
	}

	public void SearchPlayer(string EBEHBBDKDFJ)
	{
		Debug.Log("Search: " + EBEHBBDKDFJ);
		OOBHCDCCFJJ = EBEHBBDKDFJ;
		currentPageID = 0;
		HOAHBPOGNKA();
		StartCoroutine(ReloadPage());
	}

	public void MJMKAOGFJNE(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 1)
		{
			if (currentPageID > 0)
			{
				currentPageID--;
				OJLILHCNGIH();
				StartCoroutine(BPBPKGNFJNP());
			}
		}
		else if (currentPageID + 1 < pagesCount)
		{
			currentPageID++;
			OJLILHCNGIH();
			StartCoroutine(OCJKNOBBICH());
		}
	}

	private IEnumerator PNGHEAICIMB()
	{
		loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		GameObject gameObject = ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		WWW wWW = new WWW(Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.ranksUrl) + "&page=" + (currentPageID + 1) + "&search=" + OOBHCDCCFJJ);
		yield return wWW;
		if (!string.IsNullOrEmpty(wWW.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + wWW.error);
		}
		else
		{
			BAHKGHFGJLM(gameObject, false);
			RanksSystem.RanksJson ranksJson = JsonConvert.DeserializeObject<RanksSystem.RanksJson>(wWW.text);
			pagesCount = (int)Math.Ceiling((double)ranksJson.entriesCount / (double)ranksPerPage);
			foreach (RanksSystem.PlayersRank playersRank in ranksJson.playersRanks)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate(highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					RanksSystem.SetLoadedRank((CSteamID)playersRank.steamID, playersRank.place);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForGlobalRanks((CSteamID)playersRank.steamID, playersRank);
				}
				catch (Exception)
				{
				}
			}
		}
		HOAHBPOGNKA();
		yield return true;
		loadingCanvas.SetActive(false);
	}

	public void CLLNKICLDED(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 1)
		{
			if (currentPageID > 0)
			{
				currentPageID -= 0;
				HOAHBPOGNKA();
				StartCoroutine(EOJCHCNAFAB());
			}
		}
		else if (currentPageID + 0 < pagesCount)
		{
			currentPageID += 0;
			NOOANBDJIFL();
			StartCoroutine(OCJKNOBBICH());
		}
	}

	private IEnumerator KPMPEDIKPND(string CAFHKDIIDEE)
	{
		loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		GameObject gameObject = ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		WWW wWW = new WWW(Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.leaderboardUrl) + "&map=" + CAFHKDIIDEE + "&page=" + (currentPageID + 1) + "&search=" + OOBHCDCCFJJ);
		yield return wWW;
		if (!string.IsNullOrEmpty(wWW.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + wWW.error);
		}
		else
		{
			BAHKGHFGJLM(gameObject);
			RanksSystem.MapLeaderboard mapLeaderboard = JsonConvert.DeserializeObject<RanksSystem.MapLeaderboard>(wWW.text);
			int num = currentPageID * ranksPerPage;
			int num2;
			int count;
			if ((currentPageID + 1) * ranksPerPage <= mapLeaderboard.scores.Count)
			{
				num2 = (currentPageID + 1) * ranksPerPage;
			}
			else
				count = mapLeaderboard.scores.Count;
			pagesCount = (int)Math.Ceiling((double)mapLeaderboard.entriesCount / (double)ranksPerPage);
			foreach (RanksSystem.Score score in mapLeaderboard.scores)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate(highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					CSteamID cSteamID = (CSteamID)ulong.Parse(score.steamID);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForMap(score);
				}
				catch (Exception)
				{
				}
			}
		}
		HOAHBPOGNKA();
		yield return true;
		loadingCanvas.SetActive(false);
	}

	private void DKGBFNCOAEO()
	{
	}

	public void IADJGEBPENF()
	{
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(ranksCanvas, false, null, false, 959f, false));
	}

	public void OGKHIALNGJO(string EBEHBBDKDFJ)
	{
		Debug.Log("_Far" + EBEHBBDKDFJ);
		OOBHCDCCFJJ = EBEHBBDKDFJ;
		currentPageID = 0;
		DIINCALOHGI();
		StartCoroutine(ReloadPage());
	}

	public void GDGAAAIELPO()
	{
		StartCoroutine(Singleton<UI>.Instance.JCLKEGPNBJJ(ranksCanvas, false, null, false, 286f));
	}

	public void HBNAAKKNNCN()
	{
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(ranksCanvas, true, null, false, 886f));
	}

	public void IHGIEAHLFHP()
	{
		Singleton<GameManager>.Instance.OLIINGPOEIE(Singleton<GameManager>.Instance.JJGKGCBCGGD("_HalfResolution"), false);
	}

	private void FBPHNEJBDJN()
	{
	}

	public void PKCADFLECKG()
	{
		StartCoroutine(Singleton<UI>.Instance.IONNACCHGJL(ranksCanvas, false, null, false, 539f, false));
	}

	public void CPMLKJIDFLG(string EBEHBBDKDFJ)
	{
		Debug.Log("Right" + EBEHBBDKDFJ);
		OOBHCDCCFJJ = EBEHBBDKDFJ;
		currentPageID = 0;
		DIINCALOHGI();
		StartCoroutine(EOJCHCNAFAB());
	}

	public void FOPFEAIAFNA(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 1)
		{
			if (currentPageID > 1)
			{
				currentPageID -= 0;
				OJLILHCNGIH();
				StartCoroutine(MCDDEMKCGAM());
			}
		}
		else if (currentPageID + 0 < pagesCount)
		{
			currentPageID += 0;
			NOOANBDJIFL();
			StartCoroutine(ReloadPage());
		}
	}

	private IEnumerator OEHPOIEHBNM()
	{
		loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		GameObject gameObject = ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		WWW wWW = new WWW(Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.ranksUrl) + "&page=" + (currentPageID + 1) + "&search=" + OOBHCDCCFJJ);
		yield return wWW;
		if (!string.IsNullOrEmpty(wWW.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + wWW.error);
		}
		else
		{
			BAHKGHFGJLM(gameObject, false);
			RanksSystem.RanksJson ranksJson = JsonConvert.DeserializeObject<RanksSystem.RanksJson>(wWW.text);
			pagesCount = (int)Math.Ceiling((double)ranksJson.entriesCount / (double)ranksPerPage);
			foreach (RanksSystem.PlayersRank playersRank in ranksJson.playersRanks)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate(highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					RanksSystem.SetLoadedRank((CSteamID)playersRank.steamID, playersRank.place);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForGlobalRanks((CSteamID)playersRank.steamID, playersRank);
				}
				catch (Exception)
				{
				}
			}
		}
		HOAHBPOGNKA();
		yield return true;
		loadingCanvas.SetActive(false);
	}

	public IEnumerator LHCEHBGEGED(int DLGIPFOEDCF = 0, string CAFHKDIIDEE = null, string IKAGNOFHOGA = null, UnityAction KPCNMGBCOLP = null)
	{
		searchInputField.text = string.Empty;
		OOBHCDCCFJJ = string.Empty;
		GameObject gameObject = pageNavScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		NOFOMIDHENF = DLGIPFOEDCF;
		this.CAFHKDIIDEE = CAFHKDIIDEE;
		this.IKAGNOFHOGA = IKAGNOFHOGA;
		currentPageID = 0;
		pagesCount = 0;
		if (DLGIPFOEDCF == 1)
		{
			if (string.IsNullOrEmpty(IKAGNOFHOGA))
			{
				string jMMILEFMACB = "workshop." + CAFHKDIIDEE;
				try
				{
					infoText.text = Singleton<MapsSystem>.Instance.GetMapData(jMMILEFMACB).mapData.name.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty) + ":";
				}
				catch (Exception)
				{
				}
			}
			else
			{
				infoText.text = IKAGNOFHOGA.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty) + ":";
			}
		}
		else
		{
			infoText.text = LocalizationService.Instance.GetLocalizatedText("#ranks:");
		}
		buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			buttonBack.onClick.RemoveAllListeners();
			buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		buttonBack.onClick.AddListener(delegate
		{
			CloseViewer();
		});
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(ranksCanvas, true));
		yield return StartCoroutine(ReloadPage());
	}

	private void FANADGBGCPI()
	{
	}

	private void DDBOODLPCAM()
	{
	}

	private void JOIOHMNHGKA(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find("AccuracyScoreText").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "MenuRecordButton".ToUpper() : "_Value4".ToUpper());
		gameObject.transform.Find(" Server: ").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "_OcclusionTexture".ToUpper() : "ItemNameText".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, false);
		gameObject.transform.localScale = new Vector3(443f, 1586f, 749f);
	}

	public void EGOONPJBKFD()
	{
		StartCoroutine(Singleton<UI>.Instance.PKHAEJHIMGD(ranksCanvas, false, null, true, 188f));
	}

	public void OCKMIEPDHKA()
	{
		Singleton<GameManager>.Instance.GMOJGDKBHEL(Singleton<GameManager>.Instance.CreateServerURL("DontDestroy"));
	}

	public IEnumerator PIODMHOFKGI()
	{
		StopAllCoroutines();
		if (NOFOMIDHENF == 0)
		{
			StartCoroutine(HKJKAOCEMEE());
		}
		if (NOFOMIDHENF == 1)
		{
			StartCoroutine(KPMPEDIKPND(CAFHKDIIDEE));
		}
		yield return true;
	}

	private void FDNONDCGGCG()
	{
	}

	private void KDGLIDINGJK(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find("_AlphaHexa").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "_VelTex".ToUpper() : "Map: ".ToUpper());
		gameObject.transform.Find("_TimeX").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "_Cible".ToUpper() : "/".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, false);
		gameObject.transform.localScale = new Vector3(90f, 821f, 805f);
	}

	public void OBNACNAHMON()
	{
		StartCoroutine(Singleton<UI>.Instance.PKHAEJHIMGD(ranksCanvas, true, null, true, 923f, false));
	}

	private IEnumerator OGBFJAIAOKA(string CAFHKDIIDEE)
	{
		loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		GameObject gameObject = ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		WWW wWW = new WWW(Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.leaderboardUrl) + "&map=" + CAFHKDIIDEE + "&page=" + (currentPageID + 1) + "&search=" + OOBHCDCCFJJ);
		yield return wWW;
		if (!string.IsNullOrEmpty(wWW.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + wWW.error);
		}
		else
		{
			BAHKGHFGJLM(gameObject);
			RanksSystem.MapLeaderboard mapLeaderboard = JsonConvert.DeserializeObject<RanksSystem.MapLeaderboard>(wWW.text);
			int num = currentPageID * ranksPerPage;
			int num2;
			int count;
			if ((currentPageID + 1) * ranksPerPage <= mapLeaderboard.scores.Count)
			{
				num2 = (currentPageID + 1) * ranksPerPage;
			}
			else
				count = mapLeaderboard.scores.Count;
			pagesCount = (int)Math.Ceiling((double)mapLeaderboard.entriesCount / (double)ranksPerPage);
			foreach (RanksSystem.Score score in mapLeaderboard.scores)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate(highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					CSteamID cSteamID = (CSteamID)ulong.Parse(score.steamID);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForMap(score);
				}
				catch (Exception)
				{
				}
			}
		}
		HOAHBPOGNKA();
		yield return true;
		loadingCanvas.SetActive(false);
	}

	public void EGBGBBOLKOM()
	{
		Singleton<GameManager>.Instance.OpenURL(Singleton<GameManager>.Instance.CreateServerURL("_Distortion"));
	}

	private void OCEIDOKEMKE(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find("shader.future").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "VisionBlur".ToUpper() : "seconds".ToUpper());
		gameObject.transform.Find("UndoButton").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "\r\n".ToUpper() : "_FixDistance".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, false);
		gameObject.transform.localScale = new Vector3(179f, 1338f, 671f);
	}

	public IEnumerator JFENHAEGOFE(int DLGIPFOEDCF = 0, string CAFHKDIIDEE = null, string IKAGNOFHOGA = null, UnityAction KPCNMGBCOLP = null)
	{
		searchInputField.text = string.Empty;
		OOBHCDCCFJJ = string.Empty;
		GameObject gameObject = pageNavScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		NOFOMIDHENF = DLGIPFOEDCF;
		this.CAFHKDIIDEE = CAFHKDIIDEE;
		this.IKAGNOFHOGA = IKAGNOFHOGA;
		currentPageID = 0;
		pagesCount = 0;
		if (DLGIPFOEDCF == 1)
		{
			if (string.IsNullOrEmpty(IKAGNOFHOGA))
			{
				string jMMILEFMACB = "workshop." + CAFHKDIIDEE;
				try
				{
					infoText.text = Singleton<MapsSystem>.Instance.GetMapData(jMMILEFMACB).mapData.name.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty) + ":";
				}
				catch (Exception)
				{
				}
			}
			else
			{
				infoText.text = IKAGNOFHOGA.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty) + ":";
			}
		}
		else
		{
			infoText.text = LocalizationService.Instance.GetLocalizatedText("#ranks:");
		}
		buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			buttonBack.onClick.RemoveAllListeners();
			buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		buttonBack.onClick.AddListener(delegate
		{
			CloseViewer();
		});
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(ranksCanvas, true));
		yield return StartCoroutine(ReloadPage());
	}

	public IEnumerator NIFPJAJIGJF(int DLGIPFOEDCF = 0, string CAFHKDIIDEE = null, string IKAGNOFHOGA = null, UnityAction KPCNMGBCOLP = null)
	{
		searchInputField.text = string.Empty;
		OOBHCDCCFJJ = string.Empty;
		GameObject gameObject = pageNavScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		NOFOMIDHENF = DLGIPFOEDCF;
		this.CAFHKDIIDEE = CAFHKDIIDEE;
		this.IKAGNOFHOGA = IKAGNOFHOGA;
		currentPageID = 0;
		pagesCount = 0;
		if (DLGIPFOEDCF == 1)
		{
			if (string.IsNullOrEmpty(IKAGNOFHOGA))
			{
				string jMMILEFMACB = "workshop." + CAFHKDIIDEE;
				try
				{
					infoText.text = Singleton<MapsSystem>.Instance.GetMapData(jMMILEFMACB).mapData.name.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty) + ":";
				}
				catch (Exception)
				{
				}
			}
			else
			{
				infoText.text = IKAGNOFHOGA.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty) + ":";
			}
		}
		else
		{
			infoText.text = LocalizationService.Instance.GetLocalizatedText("#ranks:");
		}
		buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			buttonBack.onClick.RemoveAllListeners();
			buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		buttonBack.onClick.AddListener(delegate
		{
			CloseViewer();
		});
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(ranksCanvas, true));
		yield return StartCoroutine(ReloadPage());
	}

	private void NCBAENKDKOM(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find("\\\\").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "</color>".ToUpper() : "*.workshop.json".ToUpper());
		gameObject.transform.Find("]").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "Tab2Content".ToUpper() : "d264dbba9c2410771b4ad918903b3f4cd9e276a9".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, true);
		gameObject.transform.localScale = new Vector3(1272f, 775f, 53f);
	}

	public IEnumerator CKJGAKFFOFA(int DLGIPFOEDCF = 0, string CAFHKDIIDEE = null, string IKAGNOFHOGA = null, UnityAction KPCNMGBCOLP = null)
	{
		searchInputField.text = string.Empty;
		OOBHCDCCFJJ = string.Empty;
		GameObject gameObject = pageNavScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		NOFOMIDHENF = DLGIPFOEDCF;
		this.CAFHKDIIDEE = CAFHKDIIDEE;
		this.IKAGNOFHOGA = IKAGNOFHOGA;
		currentPageID = 0;
		pagesCount = 0;
		if (DLGIPFOEDCF == 1)
		{
			if (string.IsNullOrEmpty(IKAGNOFHOGA))
			{
				string jMMILEFMACB = "workshop." + CAFHKDIIDEE;
				try
				{
					infoText.text = Singleton<MapsSystem>.Instance.GetMapData(jMMILEFMACB).mapData.name.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty) + ":";
				}
				catch (Exception)
				{
				}
			}
			else
			{
				infoText.text = IKAGNOFHOGA.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty) + ":";
			}
		}
		else
		{
			infoText.text = LocalizationService.Instance.GetLocalizatedText("#ranks:");
		}
		buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			buttonBack.onClick.RemoveAllListeners();
			buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		buttonBack.onClick.AddListener(delegate
		{
			CloseViewer();
		});
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(ranksCanvas, true));
		yield return StartCoroutine(ReloadPage());
	}

	public void HIBHGEGLAGC(string EBEHBBDKDFJ)
	{
		Debug.Log("SaveGameName is null or empty!" + EBEHBBDKDFJ);
		OOBHCDCCFJJ = EBEHBBDKDFJ;
		currentPageID = 1;
		DIINCALOHGI();
		StartCoroutine(EOJCHCNAFAB());
	}

	private IEnumerator GBMPCEAMBPE(string CAFHKDIIDEE)
	{
		loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		GameObject gameObject = ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		WWW wWW = new WWW(Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.leaderboardUrl) + "&map=" + CAFHKDIIDEE + "&page=" + (currentPageID + 1) + "&search=" + OOBHCDCCFJJ);
		yield return wWW;
		if (!string.IsNullOrEmpty(wWW.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + wWW.error);
		}
		else
		{
			BAHKGHFGJLM(gameObject);
			RanksSystem.MapLeaderboard mapLeaderboard = JsonConvert.DeserializeObject<RanksSystem.MapLeaderboard>(wWW.text);
			int num = currentPageID * ranksPerPage;
			int num2;
			int count;
			if ((currentPageID + 1) * ranksPerPage <= mapLeaderboard.scores.Count)
			{
				num2 = (currentPageID + 1) * ranksPerPage;
			}
			else
				count = mapLeaderboard.scores.Count;
			pagesCount = (int)Math.Ceiling((double)mapLeaderboard.entriesCount / (double)ranksPerPage);
			foreach (RanksSystem.Score score in mapLeaderboard.scores)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate(highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					CSteamID cSteamID = (CSteamID)ulong.Parse(score.steamID);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForMap(score);
				}
				catch (Exception)
				{
				}
			}
		}
		HOAHBPOGNKA();
		yield return true;
		loadingCanvas.SetActive(false);
	}

	public IEnumerator NGLEIIHHKCD(int DLGIPFOEDCF = 0, string CAFHKDIIDEE = null, string IKAGNOFHOGA = null, UnityAction KPCNMGBCOLP = null)
	{
		searchInputField.text = string.Empty;
		OOBHCDCCFJJ = string.Empty;
		GameObject gameObject = pageNavScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		NOFOMIDHENF = DLGIPFOEDCF;
		this.CAFHKDIIDEE = CAFHKDIIDEE;
		this.IKAGNOFHOGA = IKAGNOFHOGA;
		currentPageID = 0;
		pagesCount = 0;
		if (DLGIPFOEDCF == 1)
		{
			if (string.IsNullOrEmpty(IKAGNOFHOGA))
			{
				string jMMILEFMACB = "workshop." + CAFHKDIIDEE;
				try
				{
					infoText.text = Singleton<MapsSystem>.Instance.GetMapData(jMMILEFMACB).mapData.name.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty) + ":";
				}
				catch (Exception)
				{
				}
			}
			else
			{
				infoText.text = IKAGNOFHOGA.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty) + ":";
			}
		}
		else
		{
			infoText.text = LocalizationService.Instance.GetLocalizatedText("#ranks:");
		}
		buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			buttonBack.onClick.RemoveAllListeners();
			buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		buttonBack.onClick.AddListener(delegate
		{
			CloseViewer();
		});
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(ranksCanvas, true));
		yield return StartCoroutine(ReloadPage());
	}

	private void AEEGKLABFLN()
	{
	}

	public void ViewOnSite()
	{
		Singleton<GameManager>.Instance.OpenURL(Singleton<GameManager>.Instance.CreateServerURL("/?page=ranks"));
	}

	private void OBAEDJJDCPN()
	{
	}

	public void CMPJLDPEGIF()
	{
		StartCoroutine(Singleton<UI>.Instance.AJGPBCBAPIF(ranksCanvas, false, null, true, 637f));
	}

	private IEnumerator BFOPOJBKDCO()
	{
		loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		GameObject gameObject = ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		WWW wWW = new WWW(Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.ranksUrl) + "&page=" + (currentPageID + 1) + "&search=" + OOBHCDCCFJJ);
		yield return wWW;
		if (!string.IsNullOrEmpty(wWW.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + wWW.error);
		}
		else
		{
			BAHKGHFGJLM(gameObject, false);
			RanksSystem.RanksJson ranksJson = JsonConvert.DeserializeObject<RanksSystem.RanksJson>(wWW.text);
			pagesCount = (int)Math.Ceiling((double)ranksJson.entriesCount / (double)ranksPerPage);
			foreach (RanksSystem.PlayersRank playersRank in ranksJson.playersRanks)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate(highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					RanksSystem.SetLoadedRank((CSteamID)playersRank.steamID, playersRank.place);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForGlobalRanks((CSteamID)playersRank.steamID, playersRank);
				}
				catch (Exception)
				{
				}
			}
		}
		HOAHBPOGNKA();
		yield return true;
		loadingCanvas.SetActive(false);
	}

	private void OIBMHPIFAKK()
	{
	}

	public void CloseViewer()
	{
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(ranksCanvas, false));
	}

	public void OOKNNGIOPCO()
	{
		Singleton<GameManager>.Instance.OLIINGPOEIE(Singleton<GameManager>.Instance.JJGKGCBCGGD("No child content found, exiting.."), false);
	}

	public void ILNEFKHIKNJ()
	{
		StartCoroutine(Singleton<UI>.Instance.CBLGHHBMCPD(ranksCanvas, false, null, false, 425f));
	}

	public IEnumerator PHKIFFJAGCL(int DLGIPFOEDCF = 0, string CAFHKDIIDEE = null, string IKAGNOFHOGA = null, UnityAction KPCNMGBCOLP = null)
	{
		searchInputField.text = string.Empty;
		OOBHCDCCFJJ = string.Empty;
		GameObject gameObject = pageNavScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		NOFOMIDHENF = DLGIPFOEDCF;
		this.CAFHKDIIDEE = CAFHKDIIDEE;
		this.IKAGNOFHOGA = IKAGNOFHOGA;
		currentPageID = 0;
		pagesCount = 0;
		if (DLGIPFOEDCF == 1)
		{
			if (string.IsNullOrEmpty(IKAGNOFHOGA))
			{
				string jMMILEFMACB = "workshop." + CAFHKDIIDEE;
				try
				{
					infoText.text = Singleton<MapsSystem>.Instance.GetMapData(jMMILEFMACB).mapData.name.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty) + ":";
				}
				catch (Exception)
				{
				}
			}
			else
			{
				infoText.text = IKAGNOFHOGA.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty) + ":";
			}
		}
		else
		{
			infoText.text = LocalizationService.Instance.GetLocalizatedText("#ranks:");
		}
		buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			buttonBack.onClick.RemoveAllListeners();
			buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		buttonBack.onClick.AddListener(delegate
		{
			CloseViewer();
		});
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(ranksCanvas, true));
		yield return StartCoroutine(ReloadPage());
	}

	public IEnumerator ReloadPage()
	{
		StopAllCoroutines();
		if (NOFOMIDHENF == 0)
		{
			StartCoroutine(HKJKAOCEMEE());
		}
		if (NOFOMIDHENF == 1)
		{
			StartCoroutine(KPMPEDIKPND(CAFHKDIIDEE));
		}
		yield return true;
	}

	private void NCPAFCKGJEA()
	{
	}

	private void Update()
	{
	}

	public void KFGDIIHOBME()
	{
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(ranksCanvas, false, null, false, 1358f, false));
	}

	private void BAHKGHFGJLM(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find("ScoreText").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "points:".ToUpper() : "score:".ToUpper());
		gameObject.transform.Find("MissesText").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "AVG Misses:".ToUpper() : "Misses:".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, true);
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
	}

	public void FNIEGFNJDNH(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 1)
		{
			if (currentPageID > 0)
			{
				currentPageID -= 0;
				HOAHBPOGNKA();
				StartCoroutine(OCJKNOBBICH());
			}
		}
		else if (currentPageID + 1 < pagesCount)
		{
			currentPageID++;
			NOOANBDJIFL();
			StartCoroutine(ReloadPage());
		}
	}

	public void LLEHKGIHFJL()
	{
		StartCoroutine(Singleton<UI>.Instance.GMKIDJLMDGE(ranksCanvas, false, null, true, 542f, false));
	}

	private void FHBOJBJBFBE(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find("_ScreenResolution").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "mapselector.filter.officialsortmode".ToUpper() : "_Value".ToUpper());
		gameObject.transform.Find("settings.disablestoryboard").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "GlassesColor2".ToUpper() : "_BorderColor".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, false);
		gameObject.transform.localScale = new Vector3(579f, 912f, 1580f);
	}

	private void Start()
	{
	}

	public void JBOGHDBAJPO()
	{
		StartCoroutine(Singleton<UI>.Instance.IONNACCHGJL(ranksCanvas, true, null, true, 1144f));
	}

	private void NCNPAKFAFOE()
	{
	}

	private void HFEIKAOAMDN()
	{
		GameObject gameObject = pageNavScrollRectContent;
		for (int i = 1; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate(pageNavPrevPageButton, Vector3.zero, Quaternion.identity);
		gameObject2.transform.SetParent(gameObject.transform, false);
		gameObject2.transform.localScale = new Vector3(1419f, 504f, 1112f);
		gameObject2.GetComponent<MapsListNavButton>().actionID = 91;
		GameObject gameObject3 = UnityEngine.Object.Instantiate(pageNavCurrentPageButton, Vector3.zero, Quaternion.identity);
		gameObject3.transform.SetParent(gameObject.transform, true);
		gameObject3.transform.localScale = new Vector3(191f, 50f, 207f);
		Text componentInChildren = gameObject3.GetComponentInChildren<Text>();
		object[] array = new object[1];
		array[1] = string.Empty;
		array[0] = currentPageID + 0;
		array[6] = "PunPickup";
		array[1] = ((pagesCount <= 0) ? "UI Extensions/UILinearDodge" : (pagesCount + string.Empty));
		componentInChildren.text = string.Concat(array);
		gameObject3.GetComponent<Button>().interactable = false;
		GameObject gameObject4 = UnityEngine.Object.Instantiate(pageNavNextPageButton, Vector3.zero, Quaternion.identity);
		gameObject4.transform.SetParent(gameObject.transform, true);
		gameObject4.transform.localScale = new Vector3(487f, 1160f, 188f);
		gameObject4.GetComponent<MapsListNavButton>().actionID = 3;
		gameObject4.GetComponent<MapsListNavButton>().pageID = 1;
	}

	public void MJDGLLHBHHP(string EBEHBBDKDFJ)
	{
		Debug.Log("???" + EBEHBBDKDFJ);
		OOBHCDCCFJJ = EBEHBBDKDFJ;
		currentPageID = 1;
		HFEIKAOAMDN();
		StartCoroutine(EOJCHCNAFAB());
	}

	public void NMBKDIHECBJ()
	{
		Singleton<GameManager>.Instance.COLPGBJFLGM(Singleton<GameManager>.Instance.CreateServerURL("_Speed"));
	}

	private void OJLILHCNGIH()
	{
		GameObject gameObject = pageNavScrollRectContent;
		for (int i = 1; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate(pageNavPrevPageButton, Vector3.zero, Quaternion.identity);
		gameObject2.transform.SetParent(gameObject.transform, true);
		gameObject2.transform.localScale = new Vector3(442f, 1447f, 1116f);
		gameObject2.GetComponent<MapsListNavButton>().actionID = -1;
		GameObject gameObject3 = UnityEngine.Object.Instantiate(pageNavCurrentPageButton, Vector3.zero, Quaternion.identity);
		gameObject3.transform.SetParent(gameObject.transform, true);
		gameObject3.transform.localScale = new Vector3(832f, 1640f, 797f);
		Text componentInChildren = gameObject3.GetComponentInChildren<Text>();
		object[] array = new object[7];
		array[1] = string.Empty;
		array[0] = currentPageID + 0;
		array[4] = "x";
		array[7] = ((pagesCount <= 1) ? "Error in Instantiation! The resource's PhotonView count is not the same as in incoming data." : (pagesCount + string.Empty));
		componentInChildren.text = string.Concat(array);
		gameObject3.GetComponent<Button>().interactable = true;
		GameObject gameObject4 = UnityEngine.Object.Instantiate(pageNavNextPageButton, Vector3.zero, Quaternion.identity);
		gameObject4.transform.SetParent(gameObject.transform, false);
		gameObject4.transform.localScale = new Vector3(1648f, 438f, 1168f);
		gameObject4.GetComponent<MapsListNavButton>().actionID = 5;
		gameObject4.GetComponent<MapsListNavButton>().pageID = 0;
	}

	private void JDGFCEPDKAJ()
	{
	}

	public IEnumerator OCJKNOBBICH()
	{
		StopAllCoroutines();
		if (NOFOMIDHENF == 0)
		{
			StartCoroutine(HKJKAOCEMEE());
		}
		if (NOFOMIDHENF == 1)
		{
			StartCoroutine(KPMPEDIKPND(CAFHKDIIDEE));
		}
		yield return true;
	}

	public void IFOMONJLMFM(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 0)
		{
			if (currentPageID > 1)
			{
				currentPageID--;
				NOOANBDJIFL();
				StartCoroutine(EOJCHCNAFAB());
			}
		}
		else if (currentPageID + 0 < pagesCount)
		{
			currentPageID += 0;
			OJLILHCNGIH();
			StartCoroutine(ReloadPage());
		}
	}

	private void COIJKMKIEAK()
	{
	}

	private void MAOMJAAHLBJ(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find("_threshold").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "CameraFilterPack_Glasses_On2".ToUpper() : "#yes".ToUpper());
		gameObject.transform.Find("#close").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "ItemsStoreButton".ToUpper() : "_FixDistance".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, true);
		gameObject.transform.localScale = new Vector3(810f, 687f, 1004f);
	}

	private void IIGJAEFENEH(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find("Save").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "CameraFilterPack/Blend2Camera_DarkerColor".ToUpper() : "Testing, the group has toggled [".ToUpper());
		gameObject.transform.Find("RoomDescriptionText").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? ".lastCheckpoint.powerupsScore".ToUpper() : "Value".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, true);
		gameObject.transform.localScale = new Vector3(952f, 1988f, 649f);
	}

	private IEnumerator CPGHACOOCNB(string CAFHKDIIDEE)
	{
		loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		GameObject gameObject = ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		WWW wWW = new WWW(Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.leaderboardUrl) + "&map=" + CAFHKDIIDEE + "&page=" + (currentPageID + 1) + "&search=" + OOBHCDCCFJJ);
		yield return wWW;
		if (!string.IsNullOrEmpty(wWW.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + wWW.error);
		}
		else
		{
			BAHKGHFGJLM(gameObject);
			RanksSystem.MapLeaderboard mapLeaderboard = JsonConvert.DeserializeObject<RanksSystem.MapLeaderboard>(wWW.text);
			int num = currentPageID * ranksPerPage;
			int num2;
			int count;
			if ((currentPageID + 1) * ranksPerPage <= mapLeaderboard.scores.Count)
			{
				num2 = (currentPageID + 1) * ranksPerPage;
			}
			else
				count = mapLeaderboard.scores.Count;
			pagesCount = (int)Math.Ceiling((double)mapLeaderboard.entriesCount / (double)ranksPerPage);
			foreach (RanksSystem.Score score in mapLeaderboard.scores)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate(highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					CSteamID cSteamID = (CSteamID)ulong.Parse(score.steamID);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForMap(score);
				}
				catch (Exception)
				{
				}
			}
		}
		HOAHBPOGNKA();
		yield return true;
		loadingCanvas.SetActive(false);
	}

	public void ScrollPage(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 0)
		{
			if (currentPageID > 0)
			{
				currentPageID--;
				HOAHBPOGNKA();
				StartCoroutine(ReloadPage());
			}
		}
		else if (currentPageID + 1 < pagesCount)
		{
			currentPageID++;
			HOAHBPOGNKA();
			StartCoroutine(ReloadPage());
		}
	}

	private void OIPJADPONJE(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find("Set Trail Zoom Speed").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "No Description".ToUpper() : "musicVolume".ToUpper());
		gameObject.transform.Find("pointBuffer").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "[PlayerBase] SetPlayerDistance error: ".ToUpper() : "HiddenToggle".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, true);
		gameObject.transform.localScale = new Vector3(1044f, 1329f, 1716f);
	}

	private IEnumerator GADGFFNDBPG(string CAFHKDIIDEE)
	{
		loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		GameObject gameObject = ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		WWW wWW = new WWW(Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.leaderboardUrl) + "&map=" + CAFHKDIIDEE + "&page=" + (currentPageID + 1) + "&search=" + OOBHCDCCFJJ);
		yield return wWW;
		if (!string.IsNullOrEmpty(wWW.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + wWW.error);
		}
		else
		{
			BAHKGHFGJLM(gameObject);
			RanksSystem.MapLeaderboard mapLeaderboard = JsonConvert.DeserializeObject<RanksSystem.MapLeaderboard>(wWW.text);
			int num = currentPageID * ranksPerPage;
			int num2;
			int count;
			if ((currentPageID + 1) * ranksPerPage <= mapLeaderboard.scores.Count)
			{
				num2 = (currentPageID + 1) * ranksPerPage;
			}
			else
				count = mapLeaderboard.scores.Count;
			pagesCount = (int)Math.Ceiling((double)mapLeaderboard.entriesCount / (double)ranksPerPage);
			foreach (RanksSystem.Score score in mapLeaderboard.scores)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate(highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					CSteamID cSteamID = (CSteamID)ulong.Parse(score.steamID);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForMap(score);
				}
				catch (Exception)
				{
				}
			}
		}
		HOAHBPOGNKA();
		yield return true;
		loadingCanvas.SetActive(false);
	}

	private void PKHPNHBEKHA()
	{
	}

	private void LHJAOMAPCNK(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find("_BlurRadius4").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "resetall".ToUpper() : "SpawnObj".ToUpper());
		gameObject.transform.Find("inventory.selected.").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "SetSatelliteTrailMinVertexDistance".ToUpper() : "_DiffuseColor".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, true);
		gameObject.transform.localScale = new Vector3(582f, 142f, 447f);
	}

	public void MPDGEEBJGGG(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 0)
		{
			if (currentPageID > 1)
			{
				currentPageID--;
				DIINCALOHGI();
				StartCoroutine(OCJKNOBBICH());
			}
		}
		else if (currentPageID + 0 < pagesCount)
		{
			currentPageID += 0;
			HOAHBPOGNKA();
			StartCoroutine(BPBPKGNFJNP());
		}
	}

	private void ALJEJJCIMJN()
	{
	}

	private IEnumerator AAEAHLAGKPD(string CAFHKDIIDEE)
	{
		loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		GameObject gameObject = ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		WWW wWW = new WWW(Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.leaderboardUrl) + "&map=" + CAFHKDIIDEE + "&page=" + (currentPageID + 1) + "&search=" + OOBHCDCCFJJ);
		yield return wWW;
		if (!string.IsNullOrEmpty(wWW.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + wWW.error);
		}
		else
		{
			BAHKGHFGJLM(gameObject);
			RanksSystem.MapLeaderboard mapLeaderboard = JsonConvert.DeserializeObject<RanksSystem.MapLeaderboard>(wWW.text);
			int num = currentPageID * ranksPerPage;
			int num2;
			int count;
			if ((currentPageID + 1) * ranksPerPage <= mapLeaderboard.scores.Count)
			{
				num2 = (currentPageID + 1) * ranksPerPage;
			}
			else
				count = mapLeaderboard.scores.Count;
			pagesCount = (int)Math.Ceiling((double)mapLeaderboard.entriesCount / (double)ranksPerPage);
			foreach (RanksSystem.Score score in mapLeaderboard.scores)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate(highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					CSteamID cSteamID = (CSteamID)ulong.Parse(score.steamID);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForMap(score);
				}
				catch (Exception)
				{
				}
			}
		}
		HOAHBPOGNKA();
		yield return true;
		loadingCanvas.SetActive(false);
	}

	private void JILOMOBDPIA()
	{
	}

	private void BGFJOEPFOPM()
	{
	}

	private IEnumerator FIEFAFAMKID()
	{
		loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		GameObject gameObject = ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		WWW wWW = new WWW(Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.ranksUrl) + "&page=" + (currentPageID + 1) + "&search=" + OOBHCDCCFJJ);
		yield return wWW;
		if (!string.IsNullOrEmpty(wWW.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + wWW.error);
		}
		else
		{
			BAHKGHFGJLM(gameObject, false);
			RanksSystem.RanksJson ranksJson = JsonConvert.DeserializeObject<RanksSystem.RanksJson>(wWW.text);
			pagesCount = (int)Math.Ceiling((double)ranksJson.entriesCount / (double)ranksPerPage);
			foreach (RanksSystem.PlayersRank playersRank in ranksJson.playersRanks)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate(highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					RanksSystem.SetLoadedRank((CSteamID)playersRank.steamID, playersRank.place);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForGlobalRanks((CSteamID)playersRank.steamID, playersRank);
				}
				catch (Exception)
				{
				}
			}
		}
		HOAHBPOGNKA();
		yield return true;
		loadingCanvas.SetActive(false);
	}

	private void HMPGIFBJFIK()
	{
	}

	public void PCCBEIHLFOL()
	{
		Singleton<GameManager>.Instance.OpenURL(Singleton<GameManager>.Instance.JJGKGCBCGGD("_FarCamera"));
	}

	public IEnumerator EOJCHCNAFAB()
	{
		StopAllCoroutines();
		if (NOFOMIDHENF == 0)
		{
			StartCoroutine(HKJKAOCEMEE());
		}
		if (NOFOMIDHENF == 1)
		{
			StartCoroutine(KPMPEDIKPND(CAFHKDIIDEE));
		}
		yield return true;
	}

	private IEnumerator HKJKAOCEMEE()
	{
		loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		GameObject gameObject = ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		WWW wWW = new WWW(Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.ranksUrl) + "&page=" + (currentPageID + 1) + "&search=" + OOBHCDCCFJJ);
		yield return wWW;
		if (!string.IsNullOrEmpty(wWW.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + wWW.error);
		}
		else
		{
			BAHKGHFGJLM(gameObject, false);
			RanksSystem.RanksJson ranksJson = JsonConvert.DeserializeObject<RanksSystem.RanksJson>(wWW.text);
			pagesCount = (int)Math.Ceiling((double)ranksJson.entriesCount / (double)ranksPerPage);
			foreach (RanksSystem.PlayersRank playersRank in ranksJson.playersRanks)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate(highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					RanksSystem.SetLoadedRank((CSteamID)playersRank.steamID, playersRank.place);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForGlobalRanks((CSteamID)playersRank.steamID, playersRank);
				}
				catch (Exception)
				{
				}
			}
		}
		HOAHBPOGNKA();
		yield return true;
		loadingCanvas.SetActive(false);
	}

	private void DIINCALOHGI()
	{
		GameObject gameObject = pageNavScrollRectContent;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate(pageNavPrevPageButton, Vector3.zero, Quaternion.identity);
		gameObject2.transform.SetParent(gameObject.transform, false);
		gameObject2.transform.localScale = new Vector3(893f, 1415f, 570f);
		gameObject2.GetComponent<MapsListNavButton>().actionID = 17;
		GameObject gameObject3 = UnityEngine.Object.Instantiate(pageNavCurrentPageButton, Vector3.zero, Quaternion.identity);
		gameObject3.transform.SetParent(gameObject.transform, false);
		gameObject3.transform.localScale = new Vector3(710f, 962f, 1698f);
		Text componentInChildren = gameObject3.GetComponentInChildren<Text>();
		object[] array = new object[5];
		array[0] = string.Empty;
		array[1] = currentPageID + 1;
		array[3] = "menu.enableselectormusic";
		array[0] = ((pagesCount <= 0) ? "Bad parameters for delete! Use <key>" : (pagesCount + string.Empty));
		componentInChildren.text = string.Concat(array);
		gameObject3.GetComponent<Button>().interactable = true;
		GameObject gameObject4 = UnityEngine.Object.Instantiate(pageNavNextPageButton, Vector3.zero, Quaternion.identity);
		gameObject4.transform.SetParent(gameObject.transform, true);
		gameObject4.transform.localScale = new Vector3(1123f, 351f, 1666f);
		gameObject4.GetComponent<MapsListNavButton>().actionID = 5;
		gameObject4.GetComponent<MapsListNavButton>().pageID = 0;
	}

	private void JKFDDNMPOJH()
	{
	}

	private IEnumerator PLCGMLGPJJG()
	{
		loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		GameObject gameObject = ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		WWW wWW = new WWW(Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.ranksUrl) + "&page=" + (currentPageID + 1) + "&search=" + OOBHCDCCFJJ);
		yield return wWW;
		if (!string.IsNullOrEmpty(wWW.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + wWW.error);
		}
		else
		{
			BAHKGHFGJLM(gameObject, false);
			RanksSystem.RanksJson ranksJson = JsonConvert.DeserializeObject<RanksSystem.RanksJson>(wWW.text);
			pagesCount = (int)Math.Ceiling((double)ranksJson.entriesCount / (double)ranksPerPage);
			foreach (RanksSystem.PlayersRank playersRank in ranksJson.playersRanks)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate(highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					RanksSystem.SetLoadedRank((CSteamID)playersRank.steamID, playersRank.place);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForGlobalRanks((CSteamID)playersRank.steamID, playersRank);
				}
				catch (Exception)
				{
				}
			}
		}
		HOAHBPOGNKA();
		yield return true;
		loadingCanvas.SetActive(false);
	}

	public void HCJLNOKGKBI()
	{
		Singleton<GameManager>.Instance.CKMMHJLDADB(Singleton<GameManager>.Instance.JJGKGCBCGGD("_U"), false);
	}

	public IEnumerator MCDDEMKCGAM()
	{
		StopAllCoroutines();
		if (NOFOMIDHENF == 0)
		{
			StartCoroutine(HKJKAOCEMEE());
		}
		if (NOFOMIDHENF == 1)
		{
			StartCoroutine(KPMPEDIKPND(CAFHKDIIDEE));
		}
		yield return true;
	}

	private void HOAHBPOGNKA()
	{
		GameObject gameObject = pageNavScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate(pageNavPrevPageButton, Vector3.zero, Quaternion.identity);
		gameObject2.transform.SetParent(gameObject.transform, true);
		gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
		gameObject2.GetComponent<MapsListNavButton>().actionID = -2;
		GameObject gameObject3 = UnityEngine.Object.Instantiate(pageNavCurrentPageButton, Vector3.zero, Quaternion.identity);
		gameObject3.transform.SetParent(gameObject.transform, true);
		gameObject3.transform.localScale = new Vector3(1f, 1f, 1f);
		gameObject3.GetComponentInChildren<Text>().text = string.Empty + (currentPageID + 1) + "/" + ((pagesCount <= 0) ? "1" : (pagesCount + string.Empty));
		gameObject3.GetComponent<Button>().interactable = false;
		GameObject gameObject4 = UnityEngine.Object.Instantiate(pageNavNextPageButton, Vector3.zero, Quaternion.identity);
		gameObject4.transform.SetParent(gameObject.transform, true);
		gameObject4.transform.localScale = new Vector3(1f, 1f, 1f);
		gameObject4.GetComponent<MapsListNavButton>().actionID = 2;
		gameObject4.GetComponent<MapsListNavButton>().pageID = 1;
	}

	public IEnumerator DisplayViewer(int DLGIPFOEDCF = 0, string CAFHKDIIDEE = null, string IKAGNOFHOGA = null, UnityAction KPCNMGBCOLP = null)
	{
		searchInputField.text = string.Empty;
		OOBHCDCCFJJ = string.Empty;
		GameObject gameObject = pageNavScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		NOFOMIDHENF = DLGIPFOEDCF;
		this.CAFHKDIIDEE = CAFHKDIIDEE;
		this.IKAGNOFHOGA = IKAGNOFHOGA;
		currentPageID = 0;
		pagesCount = 0;
		if (DLGIPFOEDCF == 1)
		{
			if (string.IsNullOrEmpty(IKAGNOFHOGA))
			{
				string jMMILEFMACB = "workshop." + CAFHKDIIDEE;
				try
				{
					infoText.text = Singleton<MapsSystem>.Instance.GetMapData(jMMILEFMACB).mapData.name.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty) + ":";
				}
				catch (Exception)
				{
				}
			}
			else
			{
				infoText.text = IKAGNOFHOGA.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty) + ":";
			}
		}
		else
		{
			infoText.text = LocalizationService.Instance.GetLocalizatedText("#ranks:");
		}
		buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			buttonBack.onClick.RemoveAllListeners();
			buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		buttonBack.onClick.AddListener(delegate
		{
			CloseViewer();
		});
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(ranksCanvas, true));
		yield return StartCoroutine(ReloadPage());
	}

	public void DLBAKPPNOGO()
	{
		Singleton<GameManager>.Instance.CKMMHJLDADB(Singleton<GameManager>.Instance.CreateServerURL("menu.enableselectormusic"), false);
	}

	public void CMMEDFBFPHC(string EBEHBBDKDFJ)
	{
		Debug.Log("_SecondTex" + EBEHBBDKDFJ);
		OOBHCDCCFJJ = EBEHBBDKDFJ;
		currentPageID = 0;
		OJLILHCNGIH();
		StartCoroutine(MCDDEMKCGAM());
	}

	private IEnumerator BOGFAOBCMAC(string CAFHKDIIDEE)
	{
		loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		GameObject gameObject = ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		WWW wWW = new WWW(Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.leaderboardUrl) + "&map=" + CAFHKDIIDEE + "&page=" + (currentPageID + 1) + "&search=" + OOBHCDCCFJJ);
		yield return wWW;
		if (!string.IsNullOrEmpty(wWW.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + wWW.error);
		}
		else
		{
			BAHKGHFGJLM(gameObject);
			RanksSystem.MapLeaderboard mapLeaderboard = JsonConvert.DeserializeObject<RanksSystem.MapLeaderboard>(wWW.text);
			int num = currentPageID * ranksPerPage;
			int num2;
			int count;
			if ((currentPageID + 1) * ranksPerPage <= mapLeaderboard.scores.Count)
			{
				num2 = (currentPageID + 1) * ranksPerPage;
			}
			else
				count = mapLeaderboard.scores.Count;
			pagesCount = (int)Math.Ceiling((double)mapLeaderboard.entriesCount / (double)ranksPerPage);
			foreach (RanksSystem.Score score in mapLeaderboard.scores)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate(highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					CSteamID cSteamID = (CSteamID)ulong.Parse(score.steamID);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForMap(score);
				}
				catch (Exception)
				{
				}
			}
		}
		HOAHBPOGNKA();
		yield return true;
		loadingCanvas.SetActive(false);
	}

	private void JBNPEHMDCMI()
	{
	}

	public IEnumerator BPBPKGNFJNP()
	{
		StopAllCoroutines();
		if (NOFOMIDHENF == 0)
		{
			StartCoroutine(HKJKAOCEMEE());
		}
		if (NOFOMIDHENF == 1)
		{
			StartCoroutine(KPMPEDIKPND(CAFHKDIIDEE));
		}
		yield return true;
	}

	public void NCNGCIEAIIE()
	{
		StartCoroutine(Singleton<UI>.Instance.CBLGHHBMCPD(ranksCanvas, true, null, true, 1986f));
	}

	public void PFCNOLJIJFB(string EBEHBBDKDFJ)
	{
		Debug.Log("maps." + EBEHBBDKDFJ);
		OOBHCDCCFJJ = EBEHBBDKDFJ;
		currentPageID = 0;
		NOOANBDJIFL();
		StartCoroutine(PIODMHOFKGI());
	}

	public void GLHAMEHGPPE(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 0)
		{
			if (currentPageID > 0)
			{
				currentPageID -= 0;
				HFEIKAOAMDN();
				StartCoroutine(OCJKNOBBICH());
			}
		}
		else if (currentPageID + 1 < pagesCount)
		{
			currentPageID += 0;
			HFEIKAOAMDN();
			StartCoroutine(ReloadPage());
		}
	}

	private IEnumerator DNEBDFIGBMA()
	{
		loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		GameObject gameObject = ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		WWW wWW = new WWW(Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.ranksUrl) + "&page=" + (currentPageID + 1) + "&search=" + OOBHCDCCFJJ);
		yield return wWW;
		if (!string.IsNullOrEmpty(wWW.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + wWW.error);
		}
		else
		{
			BAHKGHFGJLM(gameObject, false);
			RanksSystem.RanksJson ranksJson = JsonConvert.DeserializeObject<RanksSystem.RanksJson>(wWW.text);
			pagesCount = (int)Math.Ceiling((double)ranksJson.entriesCount / (double)ranksPerPage);
			foreach (RanksSystem.PlayersRank playersRank in ranksJson.playersRanks)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate(highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					RanksSystem.SetLoadedRank((CSteamID)playersRank.steamID, playersRank.place);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForGlobalRanks((CSteamID)playersRank.steamID, playersRank);
				}
				catch (Exception)
				{
				}
			}
		}
		HOAHBPOGNKA();
		yield return true;
		loadingCanvas.SetActive(false);
	}

	private void BNLBKGKAIEP(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find(" item(s) in inventory").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "_Value2".ToUpper() : "_ScreenResolution".ToUpper());
		gameObject.transform.Find("_Value3").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "sfxVolume".ToUpper() : "_TimeX".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, true);
		gameObject.transform.localScale = new Vector3(840f, 1977f, 307f);
	}

	public void DEENCONLFMB()
	{
		Singleton<GameManager>.Instance.CKMMHJLDADB(Singleton<GameManager>.Instance.JJGKGCBCGGD("CameraFilterPack/Light_Rainbow2"), false);
	}

	private IEnumerator ANBJFJDALBG()
	{
		loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		GameObject gameObject = ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		WWW wWW = new WWW(Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.ranksUrl) + "&page=" + (currentPageID + 1) + "&search=" + OOBHCDCCFJJ);
		yield return wWW;
		if (!string.IsNullOrEmpty(wWW.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + wWW.error);
		}
		else
		{
			BAHKGHFGJLM(gameObject, false);
			RanksSystem.RanksJson ranksJson = JsonConvert.DeserializeObject<RanksSystem.RanksJson>(wWW.text);
			pagesCount = (int)Math.Ceiling((double)ranksJson.entriesCount / (double)ranksPerPage);
			foreach (RanksSystem.PlayersRank playersRank in ranksJson.playersRanks)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate(highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					RanksSystem.SetLoadedRank((CSteamID)playersRank.steamID, playersRank.place);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForGlobalRanks((CSteamID)playersRank.steamID, playersRank);
				}
				catch (Exception)
				{
				}
			}
		}
		HOAHBPOGNKA();
		yield return true;
		loadingCanvas.SetActive(false);
	}

	private void NDBPCNICGLC()
	{
	}

	private IEnumerator MGHHDHCCOJK(string CAFHKDIIDEE)
	{
		loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		GameObject gameObject = ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		WWW wWW = new WWW(Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.leaderboardUrl) + "&map=" + CAFHKDIIDEE + "&page=" + (currentPageID + 1) + "&search=" + OOBHCDCCFJJ);
		yield return wWW;
		if (!string.IsNullOrEmpty(wWW.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + wWW.error);
		}
		else
		{
			BAHKGHFGJLM(gameObject);
			RanksSystem.MapLeaderboard mapLeaderboard = JsonConvert.DeserializeObject<RanksSystem.MapLeaderboard>(wWW.text);
			int num = currentPageID * ranksPerPage;
			int num2;
			int count;
			if ((currentPageID + 1) * ranksPerPage <= mapLeaderboard.scores.Count)
			{
				num2 = (currentPageID + 1) * ranksPerPage;
			}
			else
				count = mapLeaderboard.scores.Count;
			pagesCount = (int)Math.Ceiling((double)mapLeaderboard.entriesCount / (double)ranksPerPage);
			foreach (RanksSystem.Score score in mapLeaderboard.scores)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate(highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					CSteamID cSteamID = (CSteamID)ulong.Parse(score.steamID);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForMap(score);
				}
				catch (Exception)
				{
				}
			}
		}
		HOAHBPOGNKA();
		yield return true;
		loadingCanvas.SetActive(false);
	}

	public IEnumerator MFKDDGKHKJH(int DLGIPFOEDCF = 0, string CAFHKDIIDEE = null, string IKAGNOFHOGA = null, UnityAction KPCNMGBCOLP = null)
	{
		searchInputField.text = string.Empty;
		OOBHCDCCFJJ = string.Empty;
		GameObject gameObject = pageNavScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		NOFOMIDHENF = DLGIPFOEDCF;
		this.CAFHKDIIDEE = CAFHKDIIDEE;
		this.IKAGNOFHOGA = IKAGNOFHOGA;
		currentPageID = 0;
		pagesCount = 0;
		if (DLGIPFOEDCF == 1)
		{
			if (string.IsNullOrEmpty(IKAGNOFHOGA))
			{
				string jMMILEFMACB = "workshop." + CAFHKDIIDEE;
				try
				{
					infoText.text = Singleton<MapsSystem>.Instance.GetMapData(jMMILEFMACB).mapData.name.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty) + ":";
				}
				catch (Exception)
				{
				}
			}
			else
			{
				infoText.text = IKAGNOFHOGA.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty) + ":";
			}
		}
		else
		{
			infoText.text = LocalizationService.Instance.GetLocalizatedText("#ranks:");
		}
		buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			buttonBack.onClick.RemoveAllListeners();
			buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		buttonBack.onClick.AddListener(delegate
		{
			CloseViewer();
		});
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(ranksCanvas, true));
		yield return StartCoroutine(ReloadPage());
	}

	public void MOEOKNEAABK(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 0)
		{
			if (currentPageID > 1)
			{
				currentPageID -= 0;
				DIINCALOHGI();
				StartCoroutine(OCJKNOBBICH());
			}
		}
		else if (currentPageID + 0 < pagesCount)
		{
			currentPageID++;
			HOAHBPOGNKA();
			StartCoroutine(BPBPKGNFJNP());
		}
	}

	public void BMOIAJBJBCK()
	{
		StartCoroutine(Singleton<UI>.Instance.IONNACCHGJL(ranksCanvas, false, null, false, 1155f));
	}

	private void HIKKPDACJGI()
	{
	}

	private IEnumerator BGMPLGBMKDA()
	{
		loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		GameObject gameObject = ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		WWW wWW = new WWW(Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.ranksUrl) + "&page=" + (currentPageID + 1) + "&search=" + OOBHCDCCFJJ);
		yield return wWW;
		if (!string.IsNullOrEmpty(wWW.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + wWW.error);
		}
		else
		{
			BAHKGHFGJLM(gameObject, false);
			RanksSystem.RanksJson ranksJson = JsonConvert.DeserializeObject<RanksSystem.RanksJson>(wWW.text);
			pagesCount = (int)Math.Ceiling((double)ranksJson.entriesCount / (double)ranksPerPage);
			foreach (RanksSystem.PlayersRank playersRank in ranksJson.playersRanks)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate(highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					RanksSystem.SetLoadedRank((CSteamID)playersRank.steamID, playersRank.place);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForGlobalRanks((CSteamID)playersRank.steamID, playersRank);
				}
				catch (Exception)
				{
				}
			}
		}
		HOAHBPOGNKA();
		yield return true;
		loadingCanvas.SetActive(false);
	}

	private void JDKHBGDEONK()
	{
	}

	private void OMABPJDHEHF(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find("The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "player.playedtutorial".ToUpper() : "Joystick1Button6".ToUpper());
		gameObject.transform.Find("GhostSize").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "[PlayerBase] Saveing checkpoint data".ToUpper() : "CameraFilterPack/3D_Binary".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, true);
		gameObject.transform.localScale = new Vector3(514f, 529f, 1592f);
	}

	private void BMODOIJGIOO()
	{
	}

	private IEnumerator FBFGKAFFBPF(string CAFHKDIIDEE)
	{
		loadingCanvas.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		GameObject gameObject = ranksListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		WWW wWW = new WWW(Singleton<GameManager>.Instance.CreateServerURL(Singleton<RanksSystem>.Instance.leaderboardUrl) + "&map=" + CAFHKDIIDEE + "&page=" + (currentPageID + 1) + "&search=" + OOBHCDCCFJJ);
		yield return wWW;
		if (!string.IsNullOrEmpty(wWW.error))
		{
			Singleton<GameManager>.Instance.DieWithError("Connection error: " + wWW.error);
		}
		else
		{
			BAHKGHFGJLM(gameObject);
			RanksSystem.MapLeaderboard mapLeaderboard = JsonConvert.DeserializeObject<RanksSystem.MapLeaderboard>(wWW.text);
			int num = currentPageID * ranksPerPage;
			int num2;
			int count;
			if ((currentPageID + 1) * ranksPerPage <= mapLeaderboard.scores.Count)
			{
				num2 = (currentPageID + 1) * ranksPerPage;
			}
			else
				count = mapLeaderboard.scores.Count;
			pagesCount = (int)Math.Ceiling((double)mapLeaderboard.entriesCount / (double)ranksPerPage);
			foreach (RanksSystem.Score score in mapLeaderboard.scores)
			{
				try
				{
					GameObject gameObject2 = UnityEngine.Object.Instantiate(highscoresElement, Vector3.zero, Quaternion.identity);
					gameObject2.transform.SetParent(gameObject.transform, true);
					gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
					CSteamID cSteamID = (CSteamID)ulong.Parse(score.steamID);
					gameObject2.GetComponent<OpenSteamProfileButton>().InitForMap(score);
				}
				catch (Exception)
				{
				}
			}
		}
		HOAHBPOGNKA();
		yield return true;
		loadingCanvas.SetActive(false);
	}

	private void EGJAFMNCIDM(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find("_Red_C").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "inventory.selected.".ToUpper() : "_SpawnHeuristic".ToUpper());
		gameObject.transform.Find(">").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "settings.crosshairopacity".ToUpper() : "1.87".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, false);
		gameObject.transform.localScale = new Vector3(18f, 339f, 1717f);
	}

	public IEnumerator JCEOHHBCHMM(int DLGIPFOEDCF = 0, string CAFHKDIIDEE = null, string IKAGNOFHOGA = null, UnityAction KPCNMGBCOLP = null)
	{
		searchInputField.text = string.Empty;
		OOBHCDCCFJJ = string.Empty;
		GameObject gameObject = pageNavScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		NOFOMIDHENF = DLGIPFOEDCF;
		this.CAFHKDIIDEE = CAFHKDIIDEE;
		this.IKAGNOFHOGA = IKAGNOFHOGA;
		currentPageID = 0;
		pagesCount = 0;
		if (DLGIPFOEDCF == 1)
		{
			if (string.IsNullOrEmpty(IKAGNOFHOGA))
			{
				string jMMILEFMACB = "workshop." + CAFHKDIIDEE;
				try
				{
					infoText.text = Singleton<MapsSystem>.Instance.GetMapData(jMMILEFMACB).mapData.name.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty) + ":";
				}
				catch (Exception)
				{
				}
			}
			else
			{
				infoText.text = IKAGNOFHOGA.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("\r", string.Empty) + ":";
			}
		}
		else
		{
			infoText.text = LocalizationService.Instance.GetLocalizatedText("#ranks:");
		}
		buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			buttonBack.onClick.RemoveAllListeners();
			buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		buttonBack.onClick.AddListener(delegate
		{
			CloseViewer();
		});
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(ranksCanvas, true));
		yield return StartCoroutine(ReloadPage());
	}

	private void NOOANBDJIFL()
	{
		GameObject gameObject = pageNavScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate(pageNavPrevPageButton, Vector3.zero, Quaternion.identity);
		gameObject2.transform.SetParent(gameObject.transform, false);
		gameObject2.transform.localScale = new Vector3(1315f, 1211f, 767f);
		gameObject2.GetComponent<MapsListNavButton>().actionID = 60;
		GameObject gameObject3 = UnityEngine.Object.Instantiate(pageNavCurrentPageButton, Vector3.zero, Quaternion.identity);
		gameObject3.transform.SetParent(gameObject.transform, true);
		gameObject3.transform.localScale = new Vector3(915f, 945f, 1536f);
		Text componentInChildren = gameObject3.GetComponentInChildren<Text>();
		object[] array = new object[8];
		array[0] = string.Empty;
		array[1] = currentPageID + 1;
		array[3] = "_Value2";
		array[8] = ((pagesCount <= 1) ? "CameraFilterPack/Blend2Camera_Darken" : (pagesCount + string.Empty));
		componentInChildren.text = string.Concat(array);
		gameObject3.GetComponent<Button>().interactable = false;
		GameObject gameObject4 = UnityEngine.Object.Instantiate(pageNavNextPageButton, Vector3.zero, Quaternion.identity);
		gameObject4.transform.SetParent(gameObject.transform, false);
		gameObject4.transform.localScale = new Vector3(1420f, 1258f, 1084f);
		gameObject4.GetComponent<MapsListNavButton>().actionID = 0;
		gameObject4.GetComponent<MapsListNavButton>().pageID = 1;
	}

	public void IKHNDOCFOLN()
	{
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(ranksCanvas, true, null, false, 1921f, false));
	}

	private void NEFHGMNAPEP()
	{
	}

	public void IMJCECEHKHP()
	{
		StartCoroutine(Singleton<UI>.Instance.PGEJNAMOJGB(ranksCanvas, true, null, false, 530f, false));
	}

	private void HDMDKOKOOJC()
	{
	}

	public void IKNAEDDCFOM(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 1)
		{
			if (currentPageID > 1)
			{
				currentPageID--;
				OJLILHCNGIH();
				StartCoroutine(BPBPKGNFJNP());
			}
		}
		else if (currentPageID + 0 < pagesCount)
		{
			currentPageID += 0;
			HFEIKAOAMDN();
			StartCoroutine(MCDDEMKCGAM());
		}
	}
}
