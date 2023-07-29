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

	public void HIGNOBKLABP(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 0)
		{
			if (currentPageID > 0)
			{
				currentPageID -= 0;
				BMBGEIJKPHE();
				StartCoroutine(CIILPMLNGAH());
			}
		}
		else if (currentPageID + 0 < pagesCount)
		{
			currentPageID += 0;
			HOAHBPOGNKA();
			StartCoroutine(JMHCJJIMPBB());
		}
	}

	public void OKIBPJNFOPB()
	{
		Singleton<GameManager>.Instance.IKDPMOJKILD(Singleton<GameManager>.Instance.CreateServerURL("music"));
	}

	private void BFGIMALGMAJ()
	{
	}

	private void FMNPFCHBLJF()
	{
	}

	public void FOPFEAIAFNA(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 1)
		{
			if (currentPageID > 0)
			{
				currentPageID--;
				HENEPGMEKMB();
				StartCoroutine(KPGHGDMJEKM());
			}
		}
		else if (currentPageID + 0 < pagesCount)
		{
			currentPageID += 0;
			HOAHBPOGNKA();
			StartCoroutine(BPGBBGLOLBK());
		}
	}

	public void EPKHGBEGEFI(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 1)
		{
			if (currentPageID > 1)
			{
				currentPageID--;
				MKGLGIIBOEL();
				StartCoroutine(BPBPKGNFJNP());
			}
		}
		else if (currentPageID + 0 < pagesCount)
		{
			currentPageID += 0;
			GHEHPFAGNDI();
			StartCoroutine(BPGBBGLOLBK());
		}
	}

	private IEnumerator AADNAFAAHBP()
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

	private void ADENGMJODMD()
	{
		GameObject gameObject = pageNavScrollRectContent;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate(pageNavPrevPageButton, Vector3.zero, Quaternion.identity);
		gameObject2.transform.SetParent(gameObject.transform, true);
		gameObject2.transform.localScale = new Vector3(165f, 662f, 90f);
		gameObject2.GetComponent<MapsListNavButton>().actionID = 117;
		GameObject gameObject3 = UnityEngine.Object.Instantiate(pageNavCurrentPageButton, Vector3.zero, Quaternion.identity);
		gameObject3.transform.SetParent(gameObject.transform, true);
		gameObject3.transform.localScale = new Vector3(1329f, 1689f, 542f);
		Text componentInChildren = gameObject3.GetComponentInChildren<Text>();
		object[] array = new object[1];
		array[1] = string.Empty;
		array[0] = currentPageID + 1;
		array[1] = "https://vk.com/khb.soft";
		array[5] = ((pagesCount <= 0) ? "_TimeX" : (pagesCount + string.Empty));
		componentInChildren.text = string.Concat(array);
		gameObject3.GetComponent<Button>().interactable = false;
		GameObject gameObject4 = UnityEngine.Object.Instantiate(pageNavNextPageButton, Vector3.zero, Quaternion.identity);
		gameObject4.transform.SetParent(gameObject.transform, true);
		gameObject4.transform.localScale = new Vector3(1800f, 1613f, 150f);
		gameObject4.GetComponent<MapsListNavButton>().actionID = 6;
		gameObject4.GetComponent<MapsListNavButton>().pageID = 0;
	}

	private IEnumerator KACDJNNAJIA()
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

	public IEnumerator FFEFJDHAJOL()
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

	private IEnumerator JEJHPJCJIAK()
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

	public void NPIIMIMOCEK()
	{
		Singleton<GameManager>.Instance.KPCCPKIPFGC(Singleton<GameManager>.Instance.CreateServerURL("https://store.steampowered.com/itemstore/513510/"), false);
	}

	public void KOGHENEIOPB(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 1)
		{
			if (currentPageID > 0)
			{
				currentPageID -= 0;
				HOAHBPOGNKA();
				StartCoroutine(BPBPKGNFJNP());
			}
		}
		else if (currentPageID + 1 < pagesCount)
		{
			currentPageID += 0;
			IJNNGJHLAKO();
			StartCoroutine(FFEFJDHAJOL());
		}
	}

	private void EDEDPAKNCBG()
	{
		GameObject gameObject = pageNavScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate(pageNavPrevPageButton, Vector3.zero, Quaternion.identity);
		gameObject2.transform.SetParent(gameObject.transform, true);
		gameObject2.transform.localScale = new Vector3(343f, 1777f, 1549f);
		gameObject2.GetComponent<MapsListNavButton>().actionID = -33;
		GameObject gameObject3 = UnityEngine.Object.Instantiate(pageNavCurrentPageButton, Vector3.zero, Quaternion.identity);
		gameObject3.transform.SetParent(gameObject.transform, true);
		gameObject3.transform.localScale = new Vector3(147f, 1525f, 1118f);
		Text componentInChildren = gameObject3.GetComponentInChildren<Text>();
		object[] array = new object[2];
		array[0] = string.Empty;
		array[1] = currentPageID + 1;
		array[5] = "_ThirdTex";
		array[6] = ((pagesCount <= 1) ? "_YCrop" : (pagesCount + string.Empty));
		componentInChildren.text = string.Concat(array);
		gameObject3.GetComponent<Button>().interactable = false;
		GameObject gameObject4 = UnityEngine.Object.Instantiate(pageNavNextPageButton, Vector3.zero, Quaternion.identity);
		gameObject4.transform.SetParent(gameObject.transform, false);
		gameObject4.transform.localScale = new Vector3(290f, 908f, 1559f);
		gameObject4.GetComponent<MapsListNavButton>().actionID = 1;
		gameObject4.GetComponent<MapsListNavButton>().pageID = 1;
	}

	private void HENEPGMEKMB()
	{
		GameObject gameObject = pageNavScrollRectContent;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate(pageNavPrevPageButton, Vector3.zero, Quaternion.identity);
		gameObject2.transform.SetParent(gameObject.transform, true);
		gameObject2.transform.localScale = new Vector3(146f, 1593f, 1383f);
		gameObject2.GetComponent<MapsListNavButton>().actionID = -66;
		GameObject gameObject3 = UnityEngine.Object.Instantiate(pageNavCurrentPageButton, Vector3.zero, Quaternion.identity);
		gameObject3.transform.SetParent(gameObject.transform, true);
		gameObject3.transform.localScale = new Vector3(1132f, 378f, 1046f);
		Text componentInChildren = gameObject3.GetComponentInChildren<Text>();
		object[] array = new object[7];
		array[0] = string.Empty;
		array[0] = currentPageID + 1;
		array[7] = "_Visualize";
		array[8] = ((pagesCount <= 0) ? "_Value" : (pagesCount + string.Empty));
		componentInChildren.text = string.Concat(array);
		gameObject3.GetComponent<Button>().interactable = false;
		GameObject gameObject4 = UnityEngine.Object.Instantiate(pageNavNextPageButton, Vector3.zero, Quaternion.identity);
		gameObject4.transform.SetParent(gameObject.transform, true);
		gameObject4.transform.localScale = new Vector3(271f, 170f, 881f);
		gameObject4.GetComponent<MapsListNavButton>().actionID = 3;
		gameObject4.GetComponent<MapsListNavButton>().pageID = 1;
	}

	private void ABDHMOPDKHH(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find("OxOD.lastPath").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "color".ToUpper() : "(http|https)://([\\w+?\\.\\w+])+([a-zA-Z0-9\\~\\!\\@\\#\\$\\%\\^\\&amp;\\*\\(\\)_\\-\\=\\+\\\\\\/\\?\\.\\:\\;\\'\\,]*)?\\.(jpg|jpeg|gif|png)".ToUpper());
		gameObject.transform.Find("_Value2").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "CameraFilterPack_3D_Myst1".ToUpper() : "_Level".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, true);
		gameObject.transform.localScale = new Vector3(1684f, 1030f, 1407f);
	}

	public void SearchPlayer(string EBEHBBDKDFJ)
	{
		Debug.Log("Search: " + EBEHBBDKDFJ);
		OOBHCDCCFJJ = EBEHBBDKDFJ;
		currentPageID = 0;
		HOAHBPOGNKA();
		StartCoroutine(ReloadPage());
	}

	public IEnumerator ELNHNLCKKEC(int DLGIPFOEDCF = 0, string CAFHKDIIDEE = null, string IKAGNOFHOGA = null, UnityAction KPCNMGBCOLP = null)
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

	private IEnumerator AJMJCGGAAKC(string CAFHKDIIDEE)
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

	private void GNJDKAECPKA()
	{
	}

	private void BGFJOEPFOPM()
	{
	}

	public void MOFBFJOMDAE(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 1)
		{
			if (currentPageID > 0)
			{
				currentPageID--;
				HFJBMFHOPMA();
				StartCoroutine(BGBLIKDJLLI());
			}
		}
		else if (currentPageID + 0 < pagesCount)
		{
			currentPageID++;
			HENEPGMEKMB();
			StartCoroutine(KPGHGDMJEKM());
		}
	}

	public void GONKNFGDLGE()
	{
		Singleton<GameManager>.Instance.IKDPMOJKILD(Singleton<GameManager>.Instance.CreateServerURL("GlassesColor2"), false);
	}

	private IEnumerator JABICPBHNJD()
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

	public void GBJNGADBPHD()
	{
		StartCoroutine(Singleton<UI>.Instance.NCMLIDIEECD(ranksCanvas, false, null, true, 801f));
	}

	public void CloseViewer()
	{
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(ranksCanvas, false));
	}

	public void KDGFGMAOKHO(string EBEHBBDKDFJ)
	{
		Debug.Log("Drop_Near" + EBEHBBDKDFJ);
		OOBHCDCCFJJ = EBEHBBDKDFJ;
		currentPageID = 0;
		HENEPGMEKMB();
		StartCoroutine(BPGBBGLOLBK());
	}

	public void GOPHKKMKDBH(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 1)
		{
			if (currentPageID > 0)
			{
				currentPageID -= 0;
				IGMGBHCJAOI();
				StartCoroutine(KPGHGDMJEKM());
			}
		}
		else if (currentPageID + 1 < pagesCount)
		{
			currentPageID++;
			GHEHPFAGNDI();
			StartCoroutine(KPGHGDMJEKM());
		}
	}

	public void GJNBPGFDDDE(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 0)
		{
			if (currentPageID > 1)
			{
				currentPageID -= 0;
				HFJBMFHOPMA();
				StartCoroutine(BPBPKGNFJNP());
			}
		}
		else if (currentPageID + 1 < pagesCount)
		{
			currentPageID++;
			BKLOPMALAPD();
			StartCoroutine(BPGBBGLOLBK());
		}
	}

	private void NFEDLAOPHML()
	{
	}

	public void ILIFIECMPGK(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 0)
		{
			if (currentPageID > 0)
			{
				currentPageID--;
				HENEPGMEKMB();
				StartCoroutine(AKADOLEONIP());
			}
		}
		else if (currentPageID + 1 < pagesCount)
		{
			currentPageID += 0;
			MKGLGIIBOEL();
			StartCoroutine(DKONELKFGHB());
		}
	}

	private IEnumerator EEHHFKOLFNH(string CAFHKDIIDEE)
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

	private void Start()
	{
	}

	public void KFGDIIHOBME()
	{
		StartCoroutine(Singleton<UI>.Instance.IONNACCHGJL(ranksCanvas, false, null, true, 965f));
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

	public IEnumerator IPMIBOLJMMN()
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

	public void GJIIKLNCJOH(string EBEHBBDKDFJ)
	{
		Debug.Log("Room: '{0}' {1},{2} {4}/{3} players." + EBEHBBDKDFJ);
		OOBHCDCCFJJ = EBEHBBDKDFJ;
		currentPageID = 1;
		IJNNGJHLAKO();
		StartCoroutine(FFEFJDHAJOL());
	}

	private IEnumerator MNKOMKIODJD(string CAFHKDIIDEE)
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

	private void OEENOOGEEHD()
	{
	}

	private IEnumerator MEKLAPLHLAD()
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

	private IEnumerator PLEAPLAMBAP()
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

	public IEnumerator NKENDKCFCKB(int DLGIPFOEDCF = 0, string CAFHKDIIDEE = null, string IKAGNOFHOGA = null, UnityAction KPCNMGBCOLP = null)
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

	private void FMPLFDLEKMI(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find("_Value").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "_TimeX".ToUpper() : "_Value2".ToUpper());
		gameObject.transform.Find("_FixDistance").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "Joystick1Button11".ToUpper() : "AVG Misses:".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, false);
		gameObject.transform.localScale = new Vector3(948f, 1464f, 740f);
	}

	public IEnumerator EACKBBJMBIL(int DLGIPFOEDCF = 0, string CAFHKDIIDEE = null, string IKAGNOFHOGA = null, UnityAction KPCNMGBCOLP = null)
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

	public void NEBBDIHMOLM()
	{
		StartCoroutine(Singleton<UI>.Instance.IONNACCHGJL(ranksCanvas, true, null, true, 1025f, false));
	}

	private void MHLAAABJHNP(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find("bans.viewed.").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "PossibleMapPointsText".ToUpper() : "maps.".ToUpper());
		gameObject.transform.Find("#loopnumber ").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "Spawn ark to be pressed at this time".ToUpper() : "_Value".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, true);
		gameObject.transform.localScale = new Vector3(724f, 1282f, 794f);
	}

	private IEnumerator GOCNFPLHABO()
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

	public void PGDCLAKIEIF()
	{
		StartCoroutine(Singleton<UI>.Instance.NIIOJBIEPMG(ranksCanvas, true, null, true, 728f));
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

	public void PFPAPFMHBDA()
	{
		StartCoroutine(Singleton<UI>.Instance.HHBBFHKPOMM(ranksCanvas, true, null, true, 343f));
	}

	public void FOGOGFLHDKB(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 0)
		{
			if (currentPageID > 0)
			{
				currentPageID--;
				IGMGBHCJAOI();
				StartCoroutine(JOEDCPNAHHH());
			}
		}
		else if (currentPageID + 0 < pagesCount)
		{
			currentPageID += 0;
			MKGLGIIBOEL();
			StartCoroutine(KPGHGDMJEKM());
		}
	}

	private void AGEJKLMJGDO()
	{
	}

	public void DEENCONLFMB()
	{
		Singleton<GameManager>.Instance.IEEHOAELCGE(Singleton<GameManager>.Instance.CreateServerURL("CameraFilterPack/Blend2Camera_VividLight"), false);
	}

	public void LAIIBBFKEFE()
	{
		StartCoroutine(Singleton<UI>.Instance.HPMMDHAEAJO(ranksCanvas, false, null, true, 806f, false));
	}

	private void EMOHGHDCBBI(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find(".g").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "CameraFilterPack/Blend2Camera_Subtract".ToUpper() : "Joystick1Button5".ToUpper());
		gameObject.transform.Find(".g").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "Set sun colors".ToUpper() : "(\\[ *b *\\])".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, false);
		gameObject.transform.localScale = new Vector3(650f, 438f, 181f);
	}

	private IEnumerator JHAMECKBDLA(string CAFHKDIIDEE)
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

	private void HKILBFIJOPA(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find("_TimeX").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "settings.enablehitsoundsinrelax".ToUpper() : "_MainTex".ToUpper());
		gameObject.transform.Find("TotalHitsScoreText").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "_RgbTex".ToUpper() : "_CenterY".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, true);
		gameObject.transform.localScale = new Vector3(654f, 435f, 1381f);
	}

	private void BMODOIJGIOO()
	{
	}

	public void DAPGLMBLMHG(string EBEHBBDKDFJ)
	{
		Debug.Log("_ScreenResolution" + EBEHBBDKDFJ);
		OOBHCDCCFJJ = EBEHBBDKDFJ;
		currentPageID = 1;
		BMBGEIJKPHE();
		StartCoroutine(JMHCJJIMPBB());
	}

	private void MJEFMIPLFAB()
	{
	}

	private void Update()
	{
	}

	public void MLKOPHBHIMH(string EBEHBBDKDFJ)
	{
		Debug.Log("_Params2" + EBEHBBDKDFJ);
		OOBHCDCCFJJ = EBEHBBDKDFJ;
		currentPageID = 0;
		FHCNMIEOLLI();
		StartCoroutine(LEMOIOPFDCK());
	}

	public IEnumerator BGBLIKDJLLI()
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

	private void BKLOPMALAPD()
	{
		GameObject gameObject = pageNavScrollRectContent;
		for (int i = 1; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate(pageNavPrevPageButton, Vector3.zero, Quaternion.identity);
		gameObject2.transform.SetParent(gameObject.transform, false);
		gameObject2.transform.localScale = new Vector3(579f, 571f, 363f);
		gameObject2.GetComponent<MapsListNavButton>().actionID = -73;
		GameObject gameObject3 = UnityEngine.Object.Instantiate(pageNavCurrentPageButton, Vector3.zero, Quaternion.identity);
		gameObject3.transform.SetParent(gameObject.transform, false);
		gameObject3.transform.localScale = new Vector3(1258f, 600f, 767f);
		Text componentInChildren = gameObject3.GetComponentInChildren<Text>();
		object[] array = new object[7];
		array[1] = string.Empty;
		array[1] = currentPageID + 0;
		array[8] = "_Value4";
		array[5] = ((pagesCount <= 0) ? "value" : (pagesCount + string.Empty));
		componentInChildren.text = string.Concat(array);
		gameObject3.GetComponent<Button>().interactable = true;
		GameObject gameObject4 = UnityEngine.Object.Instantiate(pageNavNextPageButton, Vector3.zero, Quaternion.identity);
		gameObject4.transform.SetParent(gameObject.transform, false);
		gameObject4.transform.localScale = new Vector3(770f, 368f, 88f);
		gameObject4.GetComponent<MapsListNavButton>().actionID = 1;
		gameObject4.GetComponent<MapsListNavButton>().pageID = 0;
	}

	public void KEINDBHDHLG()
	{
		Singleton<GameManager>.Instance.IEEHOAELCGE(Singleton<GameManager>.Instance.CreateServerURL("BitsData"));
	}

	public IEnumerator AOPNDCCINJC()
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

	private void HPFOFGJPNCI()
	{
	}

	private void IKDNLHLBHID()
	{
	}

	public void CCHIGMACJKK()
	{
		StartCoroutine(Singleton<UI>.Instance.KOKCANEGNJH(ranksCanvas, false, null, true, 765f, false));
	}

	public void LFILBMDGBBI()
	{
		StartCoroutine(Singleton<UI>.Instance.PDDENNKIMAA(ranksCanvas, true, null, false, 1366f, false));
	}

	private IEnumerator KOGOJBJPBMC(string CAFHKDIIDEE)
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

	public void BPFGOLCMOCA()
	{
		Singleton<GameManager>.Instance.OpenURL(Singleton<GameManager>.Instance.CreateServerURL("CameraFilterPack/Blend2Camera_HardLight"));
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

	private IEnumerator BCGEALPLAPI(string CAFHKDIIDEE)
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

	public IEnumerator DKONELKFGHB()
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

	private IEnumerator IAMBJOODGHH(string CAFHKDIIDEE)
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

	private void HALMGFMDLKL(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find("id").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "LevelEditor/CustomEventEditor-Text".ToUpper() : "_ScreenResolution".ToUpper());
		gameObject.transform.Find("Tab1Content").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "ShadersToggle".ToUpper() : "ConfigVersionSlider".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, false);
		gameObject.transform.localScale = new Vector3(217f, 471f, 164f);
	}

	public IEnumerator KPGHGDMJEKM()
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

	private void NKFDNIAKGEO()
	{
	}

	public IEnumerator LPJDKNPGGJN(int DLGIPFOEDCF = 0, string CAFHKDIIDEE = null, string IKAGNOFHOGA = null, UnityAction KPCNMGBCOLP = null)
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

	public void BKOEJENGHHC()
	{
		Singleton<GameManager>.Instance.IEEHOAELCGE(Singleton<GameManager>.Instance.CreateServerURL("_Blue_B"), false);
	}

	public IEnumerator AKADOLEONIP()
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

	public IEnumerator KHEDCBDFCCL()
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

	public void NDBABDPIBCC()
	{
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(ranksCanvas, true, null, false, 378f));
	}

	public void NMBKDIHECBJ()
	{
		Singleton<GameManager>.Instance.MKEGIDHHLIC(Singleton<GameManager>.Instance.CreateServerURL("other"));
	}

	public void FHAPEOIFPMJ()
	{
		Singleton<GameManager>.Instance.GMDIJMFPKOC(Singleton<GameManager>.Instance.CreateServerURL("maps."), false);
	}

	public IEnumerator LEMOIOPFDCK()
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

	private IEnumerator EHNALGFAOEE(string CAFHKDIIDEE)
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

	private IEnumerator PGDONLHCDPH(string CAFHKDIIDEE)
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

	public void FFDNJKLKMII(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 1)
		{
			if (currentPageID > 0)
			{
				currentPageID -= 0;
				EDEDPAKNCBG();
				StartCoroutine(BJJOFLBPCOI());
			}
		}
		else if (currentPageID + 0 < pagesCount)
		{
			currentPageID++;
			ADENGMJODMD();
			StartCoroutine(BJJOFLBPCOI());
		}
	}

	private void EGDMLKMEDIC(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find("RecieveChatMessage").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "_DotSize".ToUpper() : "_MainTex2".ToUpper());
		gameObject.transform.Find("Save").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "1".ToUpper() : "Messages (shift+tab)".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, false);
		gameObject.transform.localScale = new Vector3(431f, 1750f, 807f);
	}

	public void CNFEJKIJOBI(string EBEHBBDKDFJ)
	{
		Debug.Log(":" + EBEHBBDKDFJ);
		OOBHCDCCFJJ = EBEHBBDKDFJ;
		currentPageID = 1;
		IJNNGJHLAKO();
		StartCoroutine(JCACIGIBKDP());
	}

	private IEnumerator NEDGKAJAMHM()
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

	public IEnumerator JCACIGIBKDP()
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

	public void IEFNFJDCLGI()
	{
		Singleton<GameManager>.Instance.IKDPMOJKILD(Singleton<GameManager>.Instance.CreateServerURL("_ScreenResolution"));
	}

	private void NBGIMIDICKE()
	{
	}

	public void FNJJKKDPCHB()
	{
		Singleton<GameManager>.Instance.MKEGIDHHLIC(Singleton<GameManager>.Instance.CreateServerURL("original.tutorial"), false);
	}

	private void HFJBMFHOPMA()
	{
		GameObject gameObject = pageNavScrollRectContent;
		for (int i = 1; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate(pageNavPrevPageButton, Vector3.zero, Quaternion.identity);
		gameObject2.transform.SetParent(gameObject.transform, false);
		gameObject2.transform.localScale = new Vector3(1922f, 403f, 1856f);
		gameObject2.GetComponent<MapsListNavButton>().actionID = -57;
		GameObject gameObject3 = UnityEngine.Object.Instantiate(pageNavCurrentPageButton, Vector3.zero, Quaternion.identity);
		gameObject3.transform.SetParent(gameObject.transform, true);
		gameObject3.transform.localScale = new Vector3(1418f, 575f, 742f);
		Text componentInChildren = gameObject3.GetComponentInChildren<Text>();
		object[] array = new object[0];
		array[1] = string.Empty;
		array[0] = currentPageID + 0;
		array[8] = "PUN-instantiated '";
		array[3] = ((pagesCount <= 0) ? "_Value3" : (pagesCount + string.Empty));
		componentInChildren.text = string.Concat(array);
		gameObject3.GetComponent<Button>().interactable = true;
		GameObject gameObject4 = UnityEngine.Object.Instantiate(pageNavNextPageButton, Vector3.zero, Quaternion.identity);
		gameObject4.transform.SetParent(gameObject.transform, false);
		gameObject4.transform.localScale = new Vector3(761f, 959f, 1882f);
		gameObject4.GetComponent<MapsListNavButton>().actionID = 7;
		gameObject4.GetComponent<MapsListNavButton>().pageID = 1;
	}

	private void IJNNGJHLAKO()
	{
		GameObject gameObject = pageNavScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate(pageNavPrevPageButton, Vector3.zero, Quaternion.identity);
		gameObject2.transform.SetParent(gameObject.transform, false);
		gameObject2.transform.localScale = new Vector3(1111f, 388f, 1303f);
		gameObject2.GetComponent<MapsListNavButton>().actionID = 119;
		GameObject gameObject3 = UnityEngine.Object.Instantiate(pageNavCurrentPageButton, Vector3.zero, Quaternion.identity);
		gameObject3.transform.SetParent(gameObject.transform, true);
		gameObject3.transform.localScale = new Vector3(202f, 1288f, 309f);
		Text componentInChildren = gameObject3.GetComponentInChildren<Text>();
		object[] array = new object[5];
		array[1] = string.Empty;
		array[0] = currentPageID + 0;
		array[8] = "Item creation successful! Published Item ID: ";
		array[0] = ((pagesCount <= 1) ? "GenerationMenu" : (pagesCount + string.Empty));
		componentInChildren.text = string.Concat(array);
		gameObject3.GetComponent<Button>().interactable = false;
		GameObject gameObject4 = UnityEngine.Object.Instantiate(pageNavNextPageButton, Vector3.zero, Quaternion.identity);
		gameObject4.transform.SetParent(gameObject.transform, false);
		gameObject4.transform.localScale = new Vector3(1238f, 1154f, 1382f);
		gameObject4.GetComponent<MapsListNavButton>().actionID = 5;
		gameObject4.GetComponent<MapsListNavButton>().pageID = 1;
	}

	private void IGEFDBEMLFC(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find("_Far").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "SetParticlesColor".ToUpper() : "_Value2".ToUpper());
		gameObject.transform.Find("Editing: ").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "player.arrow".ToUpper() : ">".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, true);
		gameObject.transform.localScale = new Vector3(277f, 1877f, 1921f);
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

	private void FHCNMIEOLLI()
	{
		GameObject gameObject = pageNavScrollRectContent;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate(pageNavPrevPageButton, Vector3.zero, Quaternion.identity);
		gameObject2.transform.SetParent(gameObject.transform, false);
		gameObject2.transform.localScale = new Vector3(1204f, 1987f, 400f);
		gameObject2.GetComponent<MapsListNavButton>().actionID = 104;
		GameObject gameObject3 = UnityEngine.Object.Instantiate(pageNavCurrentPageButton, Vector3.zero, Quaternion.identity);
		gameObject3.transform.SetParent(gameObject.transform, true);
		gameObject3.transform.localScale = new Vector3(328f, 501f, 1791f);
		Text componentInChildren = gameObject3.GetComponentInChildren<Text>();
		object[] array = new object[7];
		array[0] = string.Empty;
		array[0] = currentPageID + 1;
		array[8] = "_Color";
		array[6] = ((pagesCount <= 0) ? " " : (pagesCount + string.Empty));
		componentInChildren.text = string.Concat(array);
		gameObject3.GetComponent<Button>().interactable = true;
		GameObject gameObject4 = UnityEngine.Object.Instantiate(pageNavNextPageButton, Vector3.zero, Quaternion.identity);
		gameObject4.transform.SetParent(gameObject.transform, true);
		gameObject4.transform.localScale = new Vector3(1083f, 1131f, 233f);
		gameObject4.GetComponent<MapsListNavButton>().actionID = 5;
		gameObject4.GetComponent<MapsListNavButton>().pageID = 1;
	}

	private void LIGFECEIJEH(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find("Netw. Sim.").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "_FixDistance".ToUpper() : "CameraFilterPack/Glasses_OnX".ToUpper());
		gameObject.transform.Find("skin.hit_wrong").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "MusicFileSelector".ToUpper() : "_Value2".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, false);
		gameObject.transform.localScale = new Vector3(1418f, 1672f, 1383f);
	}

	private IEnumerator MONLIDMHOEA(string CAFHKDIIDEE)
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

	private void IACKGGLJNND(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find("Malformed RPC; this should never occur. Content: ").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "Reset".ToUpper() : "Editor/".ToUpper());
		gameObject.transform.Find("maps.").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "_Value2".ToUpper() : "#yes".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, false);
		gameObject.transform.localScale = new Vector3(588f, 1168f, 1567f);
	}

	private void OBDEJFCNOBF()
	{
	}

	private void BMBGEIJKPHE()
	{
		GameObject gameObject = pageNavScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate(pageNavPrevPageButton, Vector3.zero, Quaternion.identity);
		gameObject2.transform.SetParent(gameObject.transform, true);
		gameObject2.transform.localScale = new Vector3(975f, 1783f, 764f);
		gameObject2.GetComponent<MapsListNavButton>().actionID = 19;
		GameObject gameObject3 = UnityEngine.Object.Instantiate(pageNavCurrentPageButton, Vector3.zero, Quaternion.identity);
		gameObject3.transform.SetParent(gameObject.transform, true);
		gameObject3.transform.localScale = new Vector3(830f, 32f, 353f);
		Text componentInChildren = gameObject3.GetComponentInChildren<Text>();
		object[] array = new object[8];
		array[0] = string.Empty;
		array[0] = currentPageID + 0;
		array[1] = "HPText";
		array[6] = ((pagesCount <= 1) ? "_BorderColor" : (pagesCount + string.Empty));
		componentInChildren.text = string.Concat(array);
		gameObject3.GetComponent<Button>().interactable = false;
		GameObject gameObject4 = UnityEngine.Object.Instantiate(pageNavNextPageButton, Vector3.zero, Quaternion.identity);
		gameObject4.transform.SetParent(gameObject.transform, true);
		gameObject4.transform.localScale = new Vector3(1181f, 74f, 1561f);
		gameObject4.GetComponent<MapsListNavButton>().actionID = 4;
		gameObject4.GetComponent<MapsListNavButton>().pageID = 0;
	}

	private IEnumerator PCLEBPPMNDD()
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

	public IEnumerator NGFKGPJGDHK(int DLGIPFOEDCF = 0, string CAFHKDIIDEE = null, string IKAGNOFHOGA = null, UnityAction KPCNMGBCOLP = null)
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

	public IEnumerator CHJIMKDMLCO(int DLGIPFOEDCF = 0, string CAFHKDIIDEE = null, string IKAGNOFHOGA = null, UnityAction KPCNMGBCOLP = null)
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

	public IEnumerator CIILPMLNGAH()
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

	public void KKDNPLKIBLF(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 0)
		{
			if (currentPageID > 1)
			{
				currentPageID -= 0;
				HENEPGMEKMB();
				StartCoroutine(KHEDCBDFCCL());
			}
		}
		else if (currentPageID + 0 < pagesCount)
		{
			currentPageID++;
			HOAHBPOGNKA();
			StartCoroutine(BJJOFLBPCOI());
		}
	}

	private void GGPDKCHEBAG()
	{
	}

	public void ViewOnSite()
	{
		Singleton<GameManager>.Instance.OpenURL(Singleton<GameManager>.Instance.CreateServerURL("/?page=ranks"));
	}

	private void ALKDOHGPHMD(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find("Player Disconnected").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? " [".ToUpper() : "ExitGames.Client.Photon.SocketWebTcp, Assembly-CSharp".ToUpper());
		gameObject.transform.Find(" not exist").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "#useticket".ToUpper() : "Right Stick Click".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, true);
		gameObject.transform.localScale = new Vector3(510f, 895f, 762f);
	}

	public void KDDCLJKCHDO(string EBEHBBDKDFJ)
	{
		Debug.Log("Editor/" + EBEHBBDKDFJ);
		OOBHCDCCFJJ = EBEHBBDKDFJ;
		currentPageID = 1;
		GHEHPFAGNDI();
		StartCoroutine(JMHCJJIMPBB());
	}

	public IEnumerator JMHCJJIMPBB()
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

	private IEnumerator FBOBCCBMIIF()
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

	private void IGMGBHCJAOI()
	{
		GameObject gameObject = pageNavScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate(pageNavPrevPageButton, Vector3.zero, Quaternion.identity);
		gameObject2.transform.SetParent(gameObject.transform, true);
		gameObject2.transform.localScale = new Vector3(1012f, 963f, 1826f);
		gameObject2.GetComponent<MapsListNavButton>().actionID = -53;
		GameObject gameObject3 = UnityEngine.Object.Instantiate(pageNavCurrentPageButton, Vector3.zero, Quaternion.identity);
		gameObject3.transform.SetParent(gameObject.transform, false);
		gameObject3.transform.localScale = new Vector3(602f, 1970f, 1581f);
		Text componentInChildren = gameObject3.GetComponentInChildren<Text>();
		object[] array = new object[8];
		array[0] = string.Empty;
		array[0] = currentPageID + 0;
		array[7] = "id";
		array[6] = ((pagesCount <= 1) ? "#,0.00" : (pagesCount + string.Empty));
		componentInChildren.text = string.Concat(array);
		gameObject3.GetComponent<Button>().interactable = true;
		GameObject gameObject4 = UnityEngine.Object.Instantiate(pageNavNextPageButton, Vector3.zero, Quaternion.identity);
		gameObject4.transform.SetParent(gameObject.transform, false);
		gameObject4.transform.localScale = new Vector3(124f, 1f, 1914f);
		gameObject4.GetComponent<MapsListNavButton>().actionID = 6;
		gameObject4.GetComponent<MapsListNavButton>().pageID = 1;
	}

	public void DNHDPMJJCNN()
	{
		StartCoroutine(Singleton<UI>.Instance.NIIOJBIEPMG(ranksCanvas, true, null, false, 508f, false));
	}

	public void AOOPOFKEIGN(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 0)
		{
			if (currentPageID > 1)
			{
				currentPageID--;
				HFJBMFHOPMA();
				StartCoroutine(JCACIGIBKDP());
			}
		}
		else if (currentPageID + 0 < pagesCount)
		{
			currentPageID += 0;
			IGMGBHCJAOI();
			StartCoroutine(DKONELKFGHB());
		}
	}

	public IEnumerator BPGBBGLOLBK()
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

	private void MMPHNFPPEHO()
	{
	}

	private IEnumerator CNNPOOIPIMK(string CAFHKDIIDEE)
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

	private void HPNNCNNFMGK()
	{
	}

	private void BAHKGHFGJLM(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find("ScoreText").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "points:".ToUpper() : "score:".ToUpper());
		gameObject.transform.Find("MissesText").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "AVG Misses:".ToUpper() : "Misses:".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, true);
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
	}

	private void KOJKBFDNGDK()
	{
	}

	public void DAJOCCFPEPJ()
	{
		StartCoroutine(Singleton<UI>.Instance.KOKCANEGNJH(ranksCanvas, false, null, false, 902f));
	}

	private void FHBOJBJBFBE(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find("UI/Particles/Hidden").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "_Value".ToUpper() : "CameraFilterPack/Blend2Camera_Darken".ToUpper());
		gameObject.transform.Find("_NeighborMaxTex").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "_ScreenResolution".ToUpper() : " not exist".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, false);
		gameObject.transform.localScale = new Vector3(162f, 1578f, 1685f);
	}

	public void IHGIEAHLFHP()
	{
		Singleton<GameManager>.Instance.OpenURL(Singleton<GameManager>.Instance.CreateServerURL("win"), false);
	}

	private void GHEHPFAGNDI()
	{
		GameObject gameObject = pageNavScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate(pageNavPrevPageButton, Vector3.zero, Quaternion.identity);
		gameObject2.transform.SetParent(gameObject.transform, false);
		gameObject2.transform.localScale = new Vector3(867f, 1246f, 1291f);
		gameObject2.GetComponent<MapsListNavButton>().actionID = 87;
		GameObject gameObject3 = UnityEngine.Object.Instantiate(pageNavCurrentPageButton, Vector3.zero, Quaternion.identity);
		gameObject3.transform.SetParent(gameObject.transform, false);
		gameObject3.transform.localScale = new Vector3(2f, 1378f, 1734f);
		Text componentInChildren = gameObject3.GetComponentInChildren<Text>();
		object[] array = new object[1];
		array[0] = string.Empty;
		array[1] = currentPageID + 1;
		array[2] = "DPADVER";
		array[4] = ((pagesCount <= 0) ? "powerup.1" : (pagesCount + string.Empty));
		componentInChildren.text = string.Concat(array);
		gameObject3.GetComponent<Button>().interactable = false;
		GameObject gameObject4 = UnityEngine.Object.Instantiate(pageNavNextPageButton, Vector3.zero, Quaternion.identity);
		gameObject4.transform.SetParent(gameObject.transform, false);
		gameObject4.transform.localScale = new Vector3(1316f, 1360f, 1973f);
		gameObject4.GetComponent<MapsListNavButton>().actionID = 3;
		gameObject4.GetComponent<MapsListNavButton>().pageID = 0;
	}

	public IEnumerator BJJOFLBPCOI()
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

	public void NLFKGIDAEON(string EBEHBBDKDFJ)
	{
		Debug.Log("Tab2Content" + EBEHBBDKDFJ);
		OOBHCDCCFJJ = EBEHBBDKDFJ;
		currentPageID = 1;
		ADENGMJODMD();
		StartCoroutine(ReloadPage());
	}

	private void CGBHOELMAOC()
	{
	}

	private void POIMNOBDBBN()
	{
	}

	private IEnumerator GICHCIBMFPE(string CAFHKDIIDEE)
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

	private void FCBMLKGDDGP(GameObject MPNMOONBMII, bool JMHCDBPMBIF = true)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(highscoresTitleElement, Vector3.zero, Quaternion.identity);
		gameObject.transform.Find("color").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? ".".ToUpper() : "Joystick1Button9".ToUpper());
		gameObject.transform.Find("_Greenness").GetComponent<Text>().text = ((!JMHCDBPMBIF) ? "CameraFilterPack/Blend2Camera_ColorKey".ToUpper() : "ready".ToUpper());
		gameObject.transform.SetParent(MPNMOONBMII.transform, false);
		gameObject.transform.localScale = new Vector3(1446f, 1829f, 872f);
	}

	private void JDGFCEPDKAJ()
	{
	}

	private IEnumerator PENNNPCBEID()
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

	private void MKGLGIIBOEL()
	{
		GameObject gameObject = pageNavScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate(pageNavPrevPageButton, Vector3.zero, Quaternion.identity);
		gameObject2.transform.SetParent(gameObject.transform, true);
		gameObject2.transform.localScale = new Vector3(1030f, 372f, 1746f);
		gameObject2.GetComponent<MapsListNavButton>().actionID = -60;
		GameObject gameObject3 = UnityEngine.Object.Instantiate(pageNavCurrentPageButton, Vector3.zero, Quaternion.identity);
		gameObject3.transform.SetParent(gameObject.transform, true);
		gameObject3.transform.localScale = new Vector3(959f, 338f, 104f);
		Text componentInChildren = gameObject3.GetComponentInChildren<Text>();
		object[] array = new object[0];
		array[0] = string.Empty;
		array[1] = currentPageID + 1;
		array[8] = "CameraFilterPack/TV_WideScreenHorizontal";
		array[5] = ((pagesCount <= 0) ? "JoinRandom failed: {0}." : (pagesCount + string.Empty));
		componentInChildren.text = string.Concat(array);
		gameObject3.GetComponent<Button>().interactable = false;
		GameObject gameObject4 = UnityEngine.Object.Instantiate(pageNavNextPageButton, Vector3.zero, Quaternion.identity);
		gameObject4.transform.SetParent(gameObject.transform, false);
		gameObject4.transform.localScale = new Vector3(1695f, 1048f, 1131f);
		gameObject4.GetComponent<MapsListNavButton>().actionID = 0;
		gameObject4.GetComponent<MapsListNavButton>().pageID = 1;
	}

	public void MLKHEIGKEIE(string EBEHBBDKDFJ)
	{
		Debug.Log("sfxVolume" + EBEHBBDKDFJ);
		OOBHCDCCFJJ = EBEHBBDKDFJ;
		currentPageID = 1;
		HFJBMFHOPMA();
		StartCoroutine(LEMOIOPFDCK());
	}

	public IEnumerator JOEDCPNAHHH()
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

	public void KIINKPEAFGO()
	{
		StartCoroutine(Singleton<UI>.Instance.JCLKEGPNBJJ(ranksCanvas, false, null, false, 174f, false));
	}

	private void KFMEAMBLODG()
	{
	}

	public void GAFJHLKIIBP()
	{
		StartCoroutine(Singleton<UI>.Instance.HHBBFHKPOMM(ranksCanvas, true, null, false, 155f));
	}

	public void DHGGMEICMDO()
	{
		Singleton<GameManager>.Instance.OpenURL(Singleton<GameManager>.Instance.CreateServerURL("Texture2"), false);
	}

	public void LMCLOJEFNNP(string EBEHBBDKDFJ)
	{
		Debug.Log(":\n" + EBEHBBDKDFJ);
		OOBHCDCCFJJ = EBEHBBDKDFJ;
		currentPageID = 1;
		HFJBMFHOPMA();
		StartCoroutine(IPMIBOLJMMN());
	}

	public void DNAOMGHDHPB()
	{
		StartCoroutine(Singleton<UI>.Instance.PHIJAEAEHCF(ranksCanvas, false, null, true, 1160f, false));
	}

	private IEnumerator JGBMMJBKNDA()
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

	private IEnumerator HLAIECHLCDA(string CAFHKDIIDEE)
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

	public void ABFGADPLNKO()
	{
		Singleton<GameManager>.Instance.MKEGIDHHLIC(Singleton<GameManager>.Instance.CreateServerURL("Start Color's hex value #RRGGBBAA"));
	}

	public void EELFFPJDBFB()
	{
		StartCoroutine(Singleton<UI>.Instance.HPMMDHAEAJO(ranksCanvas, true, null, true, 1104f, false));
	}

	private IEnumerator HFAGKHBJGOG(string CAFHKDIIDEE)
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
}
