// MapsListSelector
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using AudioVisualizer;
using Steamworks;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

public class MapsListSelector : Singleton<MapsListSelector>
{
	public enum OfficialSortMode
	{
		Date,
		Difficulty
	}

	public GameObject modeSelector;

	public GameObject mapSelector;

	public Button buttonBack;

	public bool finished = true;

	public string result;

	public GameScene.GameMode resultMode = GameScene.GameMode.Normal;

	public bool isInited;

	public List<GameObject> tabs;

	public GameObject levelsListElement;

	public GameObject levelsNotDownloadedListElement;

	public GameObject notFoundListElement;

	public Toggle relaxModeToggle;

	public GameObject levelsScrollRectContent;

	public Animator levelsScrollRectContentAnimation;

	public GameObject loadingCanvas;

	public GameObject pageNavScrollRectContent;

	public GameObject pageNavPrevPageButton;

	public GameObject pageNavCurrentPageButton;

	public GameObject pageNavNextPageButton;

	[HideInInspector]
	public int currentMapsTab;

	[HideInInspector]
	public int currentMapsPageID;

	private OfficialSortMode BPLAIMGIOKO;

	public InputField searchInputField;

	public DropDownList sortDropDownList;

	public Text sortDropDownListText;

	public Button sortButton;

	[Header("Sort Panel")]
	public Transform sortPanel;

	public Transform tagsScrollRectContent;

	public GameObject tagsScrollRectElement;

	[Header("Order")]
	public Toggle recentToggle;

	public Toggle inTrendToggle;

	public Toggle topRatedToggle;

	[Header("Filter")]
	public Transform filterBGPanel;

	public Toggle subscribedToggle;

	public Toggle favoriteToggle;

	public Toggle ratedToggle;

	private bool KBLADAACANO = true;

	private UnityAction HKDGMEHPLDM;

	private int HLBKCLPNHEB;

	private int MJJNNIMOEIO;

	public string lastSearch = string.Empty;

	private CallResult<SteamUGCQueryCompleted_t> AICOBBBILIL;

	private UGCQueryHandle_t FFOJIDODGDO;

	private int AFOAEMCKEEM;

	private int HGPMLICPBKA = 1;

	private int ANFDMOPJFCK = 50;

	private IEnumerator KFBIEPMLCBP;

	private int AOJCGLBEOME = 1;

	private int KODEDGNDBLA;

	private int KNLOJGHDLLJ;

	private int NJEPDDEILLL;

	private int BGEEOIKJNJG = 1;

	private int ICJGDDNMHKH;

	private int ONKCIDAHIEJ;

	private int OPLHKEHGEAN;

	private bool ADLHGGOENBP;

	[CompilerGenerated]
	private static Func<RanksSystem.Map, DateTime> LNIJKGECNME;

	[CompilerGenerated]
	private static Func<RanksSystem.Map, float> CLCBJCKCBDD;

	[CompilerGenerated]
	private static Func<RanksSystem.Map, bool> HCLEECLNOEA;

	[CompilerGenerated]
	private static Func<RanksSystem.Map, bool> ADLAKIHINOM;

	[CompilerGenerated]
	private static Func<RanksSystem.Map, bool> KCAPKHIJOHL;

	public void CCLNNLCOPBL()
	{
		relaxModeToggle.isOn = Singleton<SaveSystem>.Instance.JPEEFKKPFIL("] to be droppable", 0) == 0;
	}

	private void DHODJKNPOLL(SteamUGCQueryCompleted_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		ANFDMOPJFCK = (int)IAFAANLMOAG.m_unNumResultsReturned;
		if (KFBIEPMLCBP != null)
		{
			StopCoroutine(KFBIEPMLCBP);
		}
		KFBIEPMLCBP = IGIAHHHPMGP(IAFAANLMOAG);
		StartCoroutine(KFBIEPMLCBP);
	}

	public void Start()
	{
		relaxModeToggle.isOn = Singleton<SaveSystem>.Instance.GetInt("menu.selectedplaymode", 0) == 0;
	}

	public IEnumerator DisplayMapSelector(int HLBKCLPNHEB = -1, int MJJNNIMOEIO = -1, List<int> BKNCFOOMKHE = null, bool GLHKMKPDAKP = true, UnityAction KPCNMGBCOLP = null, string DLDLDCOHICL = null)
	{
		if (HLBKCLPNHEB > tabs.Count - 1)
		{
			HLBKCLPNHEB = -1;
		}
		yield return new WaitUntil(() => mapSelector);
		lastSearch = Singleton<SaveSystem>.Instance.GetString("mapselector.lastSearch", string.Empty);
		searchInputField.text = lastSearch;
		result = null;
		finished = false;
		KBLADAACANO = GLHKMKPDAKP;
		if (BKNCFOOMKHE == null)
		{
			for (int i = 0; i < tabs.Count; i++)
			{
				tabs[i].GetComponent<Button>().interactable = true;
			}
		}
		else
		{
			for (int j = 0; j < tabs.Count; j++)
			{
				tabs[j].GetComponent<Button>().interactable = BKNCFOOMKHE.Contains(j);
			}
		}
		if (string.IsNullOrEmpty(DLDLDCOHICL))
		{
			DLDLDCOHICL = LocalizationService.Instance.GetTextByKey("back").ToUpper();
		}
		this.HLBKCLPNHEB = HLBKCLPNHEB;
		this.MJJNNIMOEIO = MJJNNIMOEIO;
		resultMode = (GameScene.GameMode)Singleton<SaveSystem>.Instance.GetInt("menu.selectedplaymode", 0);
		yield return new WaitForSeconds(0.1f);
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(modeSelector, false));
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(mapSelector, true));
		Init(HLBKCLPNHEB, MJJNNIMOEIO);
		buttonBack.onClick.RemoveAllListeners();
		buttonBack.GetComponentInChildren<Text>().text = DLDLDCOHICL;
		if (KPCNMGBCOLP != null)
		{
			HKDGMEHPLDM = KPCNMGBCOLP;
		}
		else
		{
			HKDGMEHPLDM = null;
		}
		buttonBack.onClick.RemoveAllListeners();
		buttonBack.onClick.AddListener(delegate
		{
			Close();
		});
		EventSystem.current.SetSelectedGameObject(buttonBack.transform.gameObject);
		StartCoroutine(DPHCONACLFO());
		yield return new WaitUntil(() => finished);
		yield return new WaitForSeconds(0.25f);
		if (Singleton<SaveSystem>.Instance.HasKey("menu.enableselectormusic") && (bool)GameObject.Find("AudioSampler"))
		{
			GameObject.Find("AudioSampler").GetComponent<AudioSampler>().isMuted = false;
		}
	}

	[CompilerGenerated]
	private static bool DHNHANCJOHB(RanksSystem.Map IACGDFHKCAE)
	{
		return IACGDFHKCAE.isOfficial;
	}

	public int GetMapsCount()
	{
		return AFOAEMCKEEM;
	}

	public void CBFMHLKKLIG(int JMMILEFMACB)
	{
		resultMode = (GameScene.GameMode)JMMILEFMACB;
		JCANNKKJJJJ(result);
	}

	public void Close(string NBGPBKCPFDN = null, bool BKMMLOEMPBB = false)
	{
		if (!BKMMLOEMPBB)
		{
			result = NBGPBKCPFDN;
			if (!string.IsNullOrEmpty(NBGPBKCPFDN))
			{
				if (KBLADAACANO)
				{
					StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(modeSelector, true));
					StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(mapSelector, false));
				}
				else
				{
					finished = true;
					StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(modeSelector, false));
					StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(mapSelector, false));
				}
			}
			else
			{
				finished = true;
				StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(modeSelector, false));
				StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(mapSelector, false));
				if (HKDGMEHPLDM != null)
				{
					HKDGMEHPLDM();
				}
			}
		}
		else
		{
			finished = true;
			StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(modeSelector, false));
			StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(mapSelector, false));
		}
	}

	public void BackToSelector()
	{
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(modeSelector, false));
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(mapSelector, true));
	}

	public void ReloadPage(bool IIGAFCONAHP = false)
	{
		if (IIGAFCONAHP)
		{
			currentMapsPageID = 0;
		}
		BPLAIMGIOKO = (OfficialSortMode)Singleton<SaveSystem>.Instance.GetInt("mapselector.filter.officialsortmode", 0);
		searchInputField.interactable = !Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.subscribedonly", false) && !Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.favoriteonly", false) && !Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.rateduponly", false);
		if (Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.subscribedonly", false) || Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.favoriteonly", false) || Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.rateduponly", false))
		{
			lastSearch = string.Empty;
			Singleton<SaveSystem>.Instance.SetString("mapselector.lastSearch", string.Empty);
			searchInputField.text = string.Empty;
		}
		CECPMNODBLA();
		StopCoroutine("MAMMIDNFMOM");
		StartCoroutine(MAMMIDNFMOM());
	}

	public void SetMapsCount(int HOHOIPHEOPN)
	{
		AFOAEMCKEEM = HOHOIPHEOPN;
	}

	public void OnEnable()
	{
		AICOBBBILIL = CallResult<SteamUGCQueryCompleted_t>.Create(MILGIHKLCHH);
	}

	public void Init(int HLBKCLPNHEB, int MJJNNIMOEIO)
	{
		if (HLBKCLPNHEB != -1)
		{
			currentMapsTab = HLBKCLPNHEB;
		}
		if (MJJNNIMOEIO != -1)
		{
			currentMapsPageID = MJJNNIMOEIO;
		}
		ReloadPage();
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
		gameObject2.GetComponent<MapsListNavButton>().actionID = -1;
		GameObject gameObject3 = UnityEngine.Object.Instantiate(pageNavCurrentPageButton, Vector3.zero, Quaternion.identity);
		gameObject3.transform.SetParent(gameObject.transform, true);
		gameObject3.transform.localScale = new Vector3(1f, 1f, 1f);
		gameObject3.GetComponentInChildren<Text>().text = string.Empty + (currentMapsPageID + 1) + "/" + ((AOJCGLBEOME <= 0) ? "1" : (AOJCGLBEOME + string.Empty));
		gameObject3.GetComponent<Button>().interactable = false;
		GameObject gameObject4 = UnityEngine.Object.Instantiate(pageNavNextPageButton, Vector3.zero, Quaternion.identity);
		gameObject4.transform.SetParent(gameObject.transform, true);
		gameObject4.transform.localScale = new Vector3(1f, 1f, 1f);
		gameObject4.GetComponent<MapsListNavButton>().actionID = 1;
		gameObject4.GetComponent<MapsListNavButton>().pageID = 1;
	}

	private void MILGIHKLCHH(SteamUGCQueryCompleted_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		ANFDMOPJFCK = (int)IAFAANLMOAG.m_unNumResultsReturned;
		if (KFBIEPMLCBP != null)
		{
			StopCoroutine(KFBIEPMLCBP);
		}
		KFBIEPMLCBP = HBNLOHGCGPG(IAFAANLMOAG);
		StartCoroutine(KFBIEPMLCBP);
	}

	private IEnumerator DPHCONACLFO()
	{
		sortDropDownList.gameObject.SetActive(true);
		sortDropDownList.Start();
		yield return null;
		DropDownList dropDownList = sortDropDownList;
		dropDownList.Items.Clear();
		sortDropDownListText.text = LocalizationService.Instance.GetLocalizatedText("#orderby:").ToUpper();
		int num = 0;
		IEnumerator enumerator = Enum.GetValues(typeof(OfficialSortMode)).GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				OfficialSortMode officialSortMode = (OfficialSortMode)enumerator.Current;
				dropDownList.Items.Add(new DropDownListItem(LocalizationService.Instance.GetLocalizatedText("#" + officialSortMode.ToString().ToLower()).ToUpper(), string.Empty + officialSortMode));
				num++;
			}
		}
		finally
		{
			IDisposable disposable;
			IDisposable disposable2 = (disposable = enumerator as IDisposable);
			if (disposable != null)
			{
				disposable2.Dispose();
			}
		}
		dropDownList.RebuildPanel();
		dropDownList.RedrawPanel();
		dropDownList.SelectItem((int)BPLAIMGIOKO, false);
		dropDownList.gameObject.SetActive(currentMapsTab == 0 || currentMapsTab == 3 || currentMapsTab == 4);
	}

	private void DAGCCMAKLPG(SteamUGCQueryCompleted_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		ANFDMOPJFCK = (int)IAFAANLMOAG.m_unNumResultsReturned;
		if (KFBIEPMLCBP != null)
		{
			StopCoroutine(KFBIEPMLCBP);
		}
		KFBIEPMLCBP = IGIAHHHPMGP(IAFAANLMOAG);
		StartCoroutine(KFBIEPMLCBP);
	}

	public void ChangeMapsSource(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("EventSystem");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		lastSearch = string.Empty;
		Singleton<SaveSystem>.Instance.SetString("mapselector.lastSearch", string.Empty);
		searchInputField.text = string.Empty;
		currentMapsTab = JMMILEFMACB;
		currentMapsPageID = 0;
		CECPMNODBLA();
		StopCoroutine("MAMMIDNFMOM");
		StartCoroutine(MAMMIDNFMOM());
	}

	public void BKAJKMBBNKJ(int JMMILEFMACB)
	{
		resultMode = (GameScene.GameMode)JMMILEFMACB;
		CGMCNFCBHAJ(result);
	}

	public void InitSortPanel()
	{
		sortPanel.gameObject.SetActive(true);
		GameObject gameObject = tagsScrollRectContent.gameObject;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (string specialTag in Helpers.specialTags)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(tagsScrollRectElement);
			gameObject2.transform.SetParent(gameObject.transform);
			gameObject2.name = "tagElement";
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.GetBool("mapselector.tags." + specialTag, true);
			gameObject2.GetComponentInChildren<Text>().text = specialTag;
		}
		foreach (string tag in Helpers.tags)
		{
			GameObject gameObject3 = UnityEngine.Object.Instantiate(tagsScrollRectElement);
			gameObject3.transform.SetParent(gameObject.transform);
			gameObject3.name = "tagElement";
			gameObject3.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject3.GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.GetBool("mapselector.tags." + tag, true);
			gameObject3.GetComponentInChildren<Text>().text = tag;
		}
		inTrendToggle.isOn = Singleton<SaveSystem>.Instance.GetInt("mapselector.orderby", 0) == 0;
		recentToggle.isOn = Singleton<SaveSystem>.Instance.GetInt("mapselector.orderby", 0) == 1;
		topRatedToggle.isOn = Singleton<SaveSystem>.Instance.GetInt("mapselector.orderby", 0) == 2;
		subscribedToggle.isOn = Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.subscribedonly", false);
		favoriteToggle.isOn = Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.favoriteonly", false);
		ratedToggle.isOn = Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.rateduponly", false);
	}

	private void BHAPMGBDPFI(bool IDNLBGOCOEK)
	{
		sortDropDownList.KHPFNJCHEBO((int)BPLAIMGIOKO);
		sortDropDownList.gameObject.SetActive(IDNLBGOCOEK);
	}

	private void PHHPOLMDEIF(bool NNIPFHAFNOK = false)
	{
		ANFDMOPJFCK = 50;
		HOAHBPOGNKA();
		if (currentMapsTab == 2)
		{
			EUGCQuery eUGCQuery = EUGCQuery.k_EUGCQuery_RankedByTrend;
			if (Singleton<SaveSystem>.Instance.GetInt("mapselector.orderby", 0) == 1)
			{
				eUGCQuery = EUGCQuery.k_EUGCQuery_RankedByPublicationDate;
			}
			if (Singleton<SaveSystem>.Instance.GetInt("mapselector.orderby", 0) == 2)
			{
				eUGCQuery = EUGCQuery.k_EUGCQuery_RankedByVote;
			}
			if (eUGCQuery != EUGCQuery.k_EUGCQuery_RankedByTrend)
			{
				Helpers.ObtainAchievement(25);
			}
			if (!Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.subscribedonly", false) && !Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.favoriteonly", false) && !Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.rateduponly", false))
			{
				FFOJIDODGDO = SteamUGC.CreateQueryAllUGCRequest(eUGCQuery, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Items_ReadyToUse, (AppId_t)513510u, (AppId_t)513510u, (uint)HGPMLICPBKA);
				ApplySearchFilter();
			}
			else
			{
				if (Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.subscribedonly", false))
				{
					FFOJIDODGDO = SteamUGC.CreateQueryUserUGCRequest(SteamUser.GetSteamID().GetAccountID(), EUserUGCList.k_EUserUGCList_Subscribed, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Items_ReadyToUse, EUserUGCListSortOrder.k_EUserUGCListSortOrder_SubscriptionDateDesc, (AppId_t)513510u, (AppId_t)513510u, (uint)HGPMLICPBKA);
				}
				if (Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.favoriteonly", false))
				{
					FFOJIDODGDO = SteamUGC.CreateQueryUserUGCRequest(SteamUser.GetSteamID().GetAccountID(), EUserUGCList.k_EUserUGCList_Favorited, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Items_ReadyToUse, EUserUGCListSortOrder.k_EUserUGCListSortOrder_CreationOrderDesc, (AppId_t)513510u, (AppId_t)513510u, (uint)HGPMLICPBKA);
				}
				if (Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.rateduponly", false))
				{
					FFOJIDODGDO = SteamUGC.CreateQueryUserUGCRequest(SteamUser.GetSteamID().GetAccountID(), EUserUGCList.k_EUserUGCList_VotedUp, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Items_ReadyToUse, EUserUGCListSortOrder.k_EUserUGCListSortOrder_CreationOrderDesc, (AppId_t)513510u, (AppId_t)513510u, (uint)HGPMLICPBKA);
				}
			}
			ADLHGGOENBP = NNIPFHAFNOK;
			SteamUGC.SetReturnOnlyIDs(FFOJIDODGDO, !NNIPFHAFNOK);
			SteamAPICall_t hAPICall = SteamUGC.SendQueryUGCRequest(FFOJIDODGDO);
			AICOBBBILIL.Set(hAPICall);
		}
		if (currentMapsTab == 5)
		{
			EUGCQuery eQueryType = EUGCQuery.k_EUGCQuery_RankedByTrend;
			FFOJIDODGDO = SteamUGC.CreateQueryAllUGCRequest(eQueryType, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Items_ReadyToUse, AppId_t.Invalid, SteamUtils.GetAppID(), (uint)HGPMLICPBKA);
			SteamUGC.AddRequiredTag(FFOJIDODGDO, "winter2020_official");
			SteamAPICall_t hAPICall2 = SteamUGC.SendQueryUGCRequest(FFOJIDODGDO);
			AICOBBBILIL.Set(hAPICall2);
		}
		if (currentMapsTab != 0 && currentMapsTab != 3 && currentMapsTab != 4)
		{
			return;
		}
		List<PublishedFileId_t> list = new List<PublishedFileId_t>();
		List<RanksSystem.Map> source = RanksSystem.GetOfficialMapsList();
		if (BPLAIMGIOKO == OfficialSortMode.Date)
		{
			source = (from IACGDFHKCAE in RanksSystem.GetOfficialMapsList()
				orderby DateTime.Parse(IACGDFHKCAE.added, CultureInfo.InvariantCulture) descending
				select IACGDFHKCAE).ToList();
		}
		if (BPLAIMGIOKO == OfficialSortMode.Difficulty)
		{
			source = (from IACGDFHKCAE in RanksSystem.GetOfficialMapsList()
				orderby IACGDFHKCAE.difficulty
				select IACGDFHKCAE).ToList();
		}
		if (currentMapsTab == 0)
		{
			foreach (RanksSystem.Map item in source.Where((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.isOfficial).ToList())
			{
				list.Add((PublishedFileId_t)item.id);
			}
		}
		if (currentMapsTab == 3)
		{
			foreach (RanksSystem.Map item2 in source.Where((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.isLoved).ToList())
			{
				list.Add((PublishedFileId_t)item2.id);
			}
		}
		if (currentMapsTab == 4)
		{
			foreach (RanksSystem.Map item3 in source.Where((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.isFunny).ToList())
			{
				list.Add((PublishedFileId_t)item3.id);
			}
		}
		FFOJIDODGDO = SteamUGC.CreateQueryUGCDetailsRequest(list.ToArray(), (uint)list.Count);
		SteamAPICall_t hAPICall3 = SteamUGC.SendQueryUGCRequest(FFOJIDODGDO);
		AICOBBBILIL.Set(hAPICall3);
	}

	public void CGMCNFCBHAJ(string NBGPBKCPFDN = null, bool BKMMLOEMPBB = false)
	{
		if (!BKMMLOEMPBB)
		{
			result = NBGPBKCPFDN;
			if (!string.IsNullOrEmpty(NBGPBKCPFDN))
			{
				if (KBLADAACANO)
				{
					StartCoroutine(Singleton<UI>.Instance.HPMMDHAEAJO(modeSelector, false, null, false, 525f));
					StartCoroutine(Singleton<UI>.Instance.HHBBFHKPOMM(mapSelector, false, null, true, 239f, false));
				}
				else
				{
					finished = true;
					StartCoroutine(Singleton<UI>.Instance.KOKCANEGNJH(modeSelector, false, null, true, 480f));
					StartCoroutine(Singleton<UI>.Instance.GADDOIMMDHH(mapSelector, false, null, true, 1031f, false));
				}
			}
			else
			{
				finished = false;
				StartCoroutine(Singleton<UI>.Instance.PKOPFBHMJHM(modeSelector, true, null, false, 1729f));
				StartCoroutine(Singleton<UI>.Instance.IOEPPMJBOLC(mapSelector, true, null, true, 1743f, false));
				if (HKDGMEHPLDM != null)
				{
					HKDGMEHPLDM();
				}
			}
		}
		else
		{
			finished = true;
			StartCoroutine(Singleton<UI>.Instance.CIADGNBMOLN(modeSelector, false, null, false, 1934f));
			StartCoroutine(Singleton<UI>.Instance.PKOPFBHMJHM(mapSelector, true, null, false, 1636f, false));
		}
	}

	public void SelectPlayMode(int JMMILEFMACB)
	{
		resultMode = (GameScene.GameMode)JMMILEFMACB;
		Close(result, true);
	}

	public void ALKBNPMCEOM(int HLBKCLPNHEB, int MJJNNIMOEIO)
	{
		if (HLBKCLPNHEB != -1)
		{
			currentMapsTab = HLBKCLPNHEB;
		}
		if (MJJNNIMOEIO != -1)
		{
			currentMapsPageID = MJJNNIMOEIO;
		}
		DLEEFJANJDC();
	}

	public void AOCEHIHDPIH()
	{
		sortPanel.gameObject.SetActive(false);
		GameObject gameObject = tagsScrollRectContent.gameObject;
		for (int i = 0; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (string specialTag in Helpers.specialTags)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(tagsScrollRectElement);
			gameObject2.transform.SetParent(gameObject.transform);
			gameObject2.name = "https://reddit.com/r/Intralism";
			gameObject2.transform.localScale = new Vector3(261f, 798f, 897f);
			gameObject2.GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.AANPGELPGPN(").png" + specialTag, false);
			gameObject2.GetComponentInChildren<Text>().text = specialTag;
		}
		foreach (string tag in Helpers.tags)
		{
			GameObject gameObject3 = UnityEngine.Object.Instantiate(tagsScrollRectElement);
			gameObject3.transform.SetParent(gameObject.transform);
			gameObject3.name = "_Color_G";
			gameObject3.transform.localScale = new Vector3(225f, 1389f, 741f);
			gameObject3.GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.AANPGELPGPN("SetSatelliteTrailMinVertexDistance" + tag, true);
			gameObject3.GetComponentInChildren<Text>().text = tag;
		}
		inTrendToggle.isOn = Singleton<SaveSystem>.Instance.ANECPPFPKAP("YES", 1) == 1;
		recentToggle.isOn = Singleton<SaveSystem>.Instance.CMAFBKOEPLP("[EditorEvent] Exception: ", 1) == 1;
		topRatedToggle.isOn = Singleton<SaveSystem>.Instance.CEKEOJDAEOD(".b", 0) == 1;
		subscribedToggle.isOn = Singleton<SaveSystem>.Instance.ONOENJPEFDD("#91CCFF", false);
		favoriteToggle.isOn = Singleton<SaveSystem>.Instance.ONOENJPEFDD("Value", true);
		ratedToggle.isOn = Singleton<SaveSystem>.Instance.IOLBIFOIHML("[ItemsHandler] Loading Steam inventory", true);
	}

	private IEnumerator JHFJDFHNHHJ()
	{
		loadingCanvas.SetActive(true);
		levelsScrollRectContentAnimation.SetBool("isVisible", false);
		GameObject gameObject = levelsScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		if (currentMapsTab == 1)
		{
			yield return new WaitForSeconds(0.2f);
			IEnumerable<KeyValuePair<string, FullMapData>> source = Singleton<MapsSystem>.Instance.levelsData.Where((KeyValuePair<string, FullMapData> EOAFLKCABMD) => EOAFLKCABMD.Value.source == FullMapData.MapSource.Editor);
			Dictionary<string, FullMapData> AKNKMCNHKGH = new Dictionary<string, FullMapData>();
			AKNKMCNHKGH = source.ToDictionary((KeyValuePair<string, FullMapData> HDMLEEGNJHI) => HDMLEEGNJHI.Key, (KeyValuePair<string, FullMapData> HDMLEEGNJHI) => HDMLEEGNJHI.Value);
			IEnumerable<KeyValuePair<string, FullMapData>> source2 = AKNKMCNHKGH.Where((KeyValuePair<string, FullMapData> EOAFLKCABMD) => Helpers.GetIndex(AKNKMCNHKGH, EOAFLKCABMD.Key) >= ItemsPerPage() * currentMapsPageID && Helpers.GetIndex(AKNKMCNHKGH, EOAFLKCABMD.Key) < ItemsPerPage() * (currentMapsPageID + 1));
			foreach (string key in source2.ToDictionary((KeyValuePair<string, FullMapData> HDMLEEGNJHI) => HDMLEEGNJHI.Key, (KeyValuePair<string, FullMapData> HDMLEEGNJHI) => HDMLEEGNJHI.Value).Keys)
			{
				Singleton<MapsSystem>.Instance.LoadLevel(key);
			}
			List<FullMapData> list = new List<FullMapData>();
			foreach (FullMapData value in source2.ToDictionary((KeyValuePair<string, FullMapData> HDMLEEGNJHI) => HDMLEEGNJHI.Key, (KeyValuePair<string, FullMapData> HDMLEEGNJHI) => HDMLEEGNJHI.Value).Values)
			{
				if (!list.Contains(value))
				{
					list.Add(value);
				}
			}
			foreach (FullMapData NOJGGCLPPAM in list)
			{
				if (NOJGGCLPPAM == null)
				{
					continue;
				}
				if (!NOJGGCLPPAM.isLoaded())
				{
					Singleton<MapsSystem>.Instance.LoadLevel(Singleton<MapsSystem>.Instance.levelsData.FirstOrDefault((KeyValuePair<string, FullMapData> IACGDFHKCAE) => IACGDFHKCAE.Equals(NOJGGCLPPAM)).Key);
				}
				if ((NOJGGCLPPAM.mapData != null && NOJGGCLPPAM.isUnlocked()) || (!NOJGGCLPPAM.isUnlocked() && !NOJGGCLPPAM.mapData.hidden))
				{
					Singleton<MapsSystem>.Instance.AddDownloadedLevelItemToList(levelsListElement, NOJGGCLPPAM, gameObject);
				}
			}
			AOJCGLBEOME = (int)Math.Ceiling((double)AKNKMCNHKGH.Count / (double)ItemsPerPage());
			HOAHBPOGNKA();
			if (AKNKMCNHKGH.Count == 0)
			{
				GameObject gameObject2 = UnityEngine.Object.Instantiate(notFoundListElement, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(levelsScrollRectContent.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			}
			loadingCanvas.SetActive(false);
			levelsScrollRectContentAnimation.SetBool("isVisible", true);
		}
		else
		{
			HGPMLICPBKA = 1;
			PHHPOLMDEIF();
		}
	}

	public void UpdateSortUI()
	{
		filterBGPanel.gameObject.SetActive(subscribedToggle.isOn || favoriteToggle.isOn || ratedToggle.isOn);
		searchInputField.interactable = !Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.subscribedonly", false) && !Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.favoriteonly", false) && !Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.rateduponly", false);
	}

	public void LKFKCOHMNLE()
	{
		GameObject gameObject = tagsScrollRectContent.gameObject;
		Toggle[] componentsInChildren = gameObject.GetComponentsInChildren<Toggle>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			Toggle toggle = componentsInChildren[i];
			Singleton<SaveSystem>.Instance.GAACBNCIFLG("_ForceYSwap" + toggle.GetComponentInChildren<Text>().text, toggle.isOn);
		}
		Singleton<SaveSystem>.Instance.HIDBNDKJHAA("_DistortionLevel", (!inTrendToggle.isOn) ? ((!recentToggle.isOn) ? 8 : 0) : 0);
		Singleton<SaveSystem>.Instance.NCNNFONPMLD("#exit", subscribedToggle.isOn);
		Singleton<SaveSystem>.Instance.LBFFJLFBOAM("FrostCanvas", favoriteToggle.isOn);
		Singleton<SaveSystem>.Instance.NCNNFONPMLD("MenuScene", ratedToggle.isOn);
		DBFDIGPGHEJ();
		ReloadPage(true);
	}

	private IEnumerator JLPBJJIFHHB()
	{
		sortDropDownList.gameObject.SetActive(true);
		sortDropDownList.Start();
		yield return null;
		DropDownList dropDownList = sortDropDownList;
		dropDownList.Items.Clear();
		sortDropDownListText.text = LocalizationService.Instance.GetLocalizatedText("#orderby:").ToUpper();
		int num = 0;
		IEnumerator enumerator = Enum.GetValues(typeof(OfficialSortMode)).GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				OfficialSortMode officialSortMode = (OfficialSortMode)enumerator.Current;
				dropDownList.Items.Add(new DropDownListItem(LocalizationService.Instance.GetLocalizatedText("#" + officialSortMode.ToString().ToLower()).ToUpper(), string.Empty + officialSortMode));
				num++;
			}
		}
		finally
		{
			IDisposable disposable;
			IDisposable disposable2 = (disposable = enumerator as IDisposable);
			if (disposable != null)
			{
				disposable2.Dispose();
			}
		}
		dropDownList.RebuildPanel();
		dropDownList.RedrawPanel();
		dropDownList.SelectItem((int)BPLAIMGIOKO, false);
		dropDownList.gameObject.SetActive(currentMapsTab == 0 || currentMapsTab == 3 || currentMapsTab == 4);
	}

	public void CJJJDAIMDNG(string NBGPBKCPFDN = null, bool BKMMLOEMPBB = false)
	{
		if (!BKMMLOEMPBB)
		{
			result = NBGPBKCPFDN;
			if (!string.IsNullOrEmpty(NBGPBKCPFDN))
			{
				if (KBLADAACANO)
				{
					StartCoroutine(Singleton<UI>.Instance.KMOMEPOBDBN(modeSelector, true, null, false, 1125f));
					StartCoroutine(Singleton<UI>.Instance.PDDENNKIMAA(mapSelector, false, null, true, 620f, false));
				}
				else
				{
					finished = false;
					StartCoroutine(Singleton<UI>.Instance.HHBBFHKPOMM(modeSelector, false, null, false, 1936f, false));
					StartCoroutine(Singleton<UI>.Instance.CMFJGHFEKIK(mapSelector, true, null, true, 111f));
				}
			}
			else
			{
				finished = false;
				StartCoroutine(Singleton<UI>.Instance.KMOMEPOBDBN(modeSelector, false, null, true, 1916f, false));
				StartCoroutine(Singleton<UI>.Instance.JCLKEGPNBJJ(mapSelector, false, null, true, 1696f, false));
				if (HKDGMEHPLDM != null)
				{
					HKDGMEHPLDM();
				}
			}
		}
		else
		{
			finished = false;
			StartCoroutine(Singleton<UI>.Instance.AMOKEEHJLFP(modeSelector, false, null, false, 459f));
			StartCoroutine(Singleton<UI>.Instance.JCLKEGPNBJJ(mapSelector, true, null, false, 1735f));
		}
	}

	public void JDFOIDHPHIO(int JMMILEFMACB)
	{
		resultMode = (GameScene.GameMode)JMMILEFMACB;
		JCANNKKJJJJ(result, true);
	}

	public void ALBCHFHEFCK(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 0)
		{
			if (currentMapsPageID > 1)
			{
				currentMapsPageID -= 0;
				ReloadPage(true);
			}
		}
		else if (currentMapsPageID + 1 < AOJCGLBEOME)
		{
			currentMapsPageID++;
			ReloadPage(true);
		}
	}

	public void BLKGBHODPFI()
	{
		sortPanel.gameObject.SetActive(false);
		GameObject gameObject = tagsScrollRectContent.gameObject;
		for (int i = 1; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (string specialTag in Helpers.specialTags)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(tagsScrollRectElement);
			gameObject2.transform.SetParent(gameObject.transform);
			gameObject2.name = "#alreadyexist";
			gameObject2.transform.localScale = new Vector3(1635f, 1008f, 1497f);
			gameObject2.GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.EBEAKNGJCDC("_Value4" + specialTag, false);
			gameObject2.GetComponentInChildren<Text>().text = specialTag;
		}
		foreach (string tag in Helpers.tags)
		{
			GameObject gameObject3 = UnityEngine.Object.Instantiate(tagsScrollRectElement);
			gameObject3.transform.SetParent(gameObject.transform);
			gameObject3.name = "AudioSampler";
			gameObject3.transform.localScale = new Vector3(1547f, 796f, 455f);
			gameObject3.GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.ADKHKNJOJEH(".lastCheckpoint.time" + tag, true);
			gameObject3.GetComponentInChildren<Text>().text = tag;
		}
		inTrendToggle.isOn = Singleton<SaveSystem>.Instance.AFCPNFKIKKJ("settings.crosshairopacity", 0) == 0;
		recentToggle.isOn = Singleton<SaveSystem>.Instance.JPEEFKKPFIL("Player Disconnected", 1) == 0;
		topRatedToggle.isOn = Singleton<SaveSystem>.Instance.CMAFBKOEPLP("0,2,true,0", 0) == 8;
		subscribedToggle.isOn = Singleton<SaveSystem>.Instance.AANPGELPGPN(":\n", false);
		favoriteToggle.isOn = Singleton<SaveSystem>.Instance.GetBool("_TimeX", true);
		ratedToggle.isOn = Singleton<SaveSystem>.Instance.ADKHKNJOJEH("_Value3", false);
	}

	[CompilerGenerated]
	private static DateTime DHDNNKEMHCM(RanksSystem.Map IACGDFHKCAE)
	{
		return DateTime.Parse(IACGDFHKCAE.added, CultureInfo.InvariantCulture);
	}

	private static bool EFBMHLGDJMM(RanksSystem.Map IACGDFHKCAE)
	{
		return IACGDFHKCAE.MOEOCIODBDH();
	}

	public void CloseSortPanel()
	{
		sortPanel.gameObject.SetActive(false);
	}

	public void SearchMaps(string EAFAMAMDNEG)
	{
		if (lastSearch != EAFAMAMDNEG)
		{
			Debug.Log("Search: " + EAFAMAMDNEG);
			lastSearch = EAFAMAMDNEG;
			Singleton<SaveSystem>.Instance.SetString("mapselector.lastSearch", lastSearch);
			ReloadPage(true);
		}
	}

	[CompilerGenerated]
	private static bool KLBEEDEECFN(RanksSystem.Map IACGDFHKCAE)
	{
		return IACGDFHKCAE.isFunny;
	}

	public void PAFMNAIDAFH(int HLBKCLPNHEB, int MJJNNIMOEIO)
	{
		if (HLBKCLPNHEB != -1)
		{
			currentMapsTab = HLBKCLPNHEB;
		}
		if (MJJNNIMOEIO != -1)
		{
			currentMapsPageID = MJJNNIMOEIO;
		}
		DLEEFJANJDC(true);
	}

	[CompilerGenerated]
	private static float HFAMHDJOBIF(RanksSystem.Map IACGDFHKCAE)
	{
		return IACGDFHKCAE.difficulty;
	}

	private void CPJDEMLFBKD(bool IDNLBGOCOEK)
	{
		sortDropDownList.SelectItem((int)BPLAIMGIOKO, false);
		sortDropDownList.gameObject.SetActive(IDNLBGOCOEK);
	}

	public new void CIAHIJIOFIE()
	{
		base.Awake();
	}

	private static bool NHFFFAMFGEG(RanksSystem.Map IACGDFHKCAE)
	{
		return IACGDFHKCAE.GPAPLIKKEOH();
	}

	public void JCANNKKJJJJ(string NBGPBKCPFDN = null, bool BKMMLOEMPBB = false)
	{
		if (!BKMMLOEMPBB)
		{
			result = NBGPBKCPFDN;
			if (!string.IsNullOrEmpty(NBGPBKCPFDN))
			{
				if (KBLADAACANO)
				{
					StartCoroutine(Singleton<UI>.Instance.KOKCANEGNJH(modeSelector, false, null, false, 644f));
					StartCoroutine(Singleton<UI>.Instance.PHIJAEAEHCF(mapSelector, false, null, true, 1462f, false));
				}
				else
				{
					finished = false;
					StartCoroutine(Singleton<UI>.Instance.NMNFEEMHJPF(modeSelector, false, null, false, 146f, false));
					StartCoroutine(Singleton<UI>.Instance.HJEODGHPPAJ(mapSelector, false, null, true, 273f, false));
				}
			}
			else
			{
				finished = false;
				StartCoroutine(Singleton<UI>.Instance.IOEPPMJBOLC(modeSelector, false, null, true, 1449f));
				StartCoroutine(Singleton<UI>.Instance.NMNFEEMHJPF(mapSelector, true, null, false, 1312f, false));
				if (HKDGMEHPLDM != null)
				{
					HKDGMEHPLDM();
				}
			}
		}
		else
		{
			finished = true;
			StartCoroutine(Singleton<UI>.Instance.FNBLMPBOKNH(modeSelector, true, null, true, 106f, false));
			StartCoroutine(Singleton<UI>.Instance.GADDOIMMDHH(mapSelector, false, null, true, 1848f));
		}
	}

	private void CECPMNODBLA()
	{
		Singleton<SaveSystem>.Instance.SetInt("menu.tabid", currentMapsTab);
		if (currentMapsTab != 2)
		{
			searchInputField.gameObject.SetActive(false);
			sortButton.gameObject.SetActive(false);
		}
		else if (!Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.subscribedonly", false) && !Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.favoriteonly", false) && !Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.rateduponly", false))
		{
			searchInputField.gameObject.SetActive(true);
			sortButton.gameObject.SetActive(true);
		}
		else
		{
			searchInputField.gameObject.SetActive(false);
			sortButton.gameObject.SetActive(true);
		}
		CPJDEMLFBKD(currentMapsTab == 0 || currentMapsTab == 3 || currentMapsTab == 4);
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().IsSelected = tabs.IndexOf(tab) == currentMapsTab;
		}
	}

	private static bool KCJHGGECHEK(RanksSystem.Map IACGDFHKCAE)
	{
		return IACGDFHKCAE.GCLPAFADHMD();
	}

	public void ChangePage(bool FOJOODCBOIK, int HOHOIPHEOPN, bool AAGGLAGLINL = false)
	{
		int num = currentMapsPageID;
		num = (FOJOODCBOIK ? HOHOIPHEOPN : ((HOHOIPHEOPN > 0) ? ((GetMapsCount() + ItemsPerPage() - 1) / ItemsPerPage() - 1) : 0));
		if (num < 0)
		{
			num = 0;
		}
		if (num >= (GetMapsCount() + ItemsPerPage() - 1) / ItemsPerPage() - 1)
		{
			num = (GetMapsCount() + ItemsPerPage() - 1) / ItemsPerPage() - 1;
		}
		if (num != currentMapsPageID || AAGGLAGLINL)
		{
			currentMapsPageID = num;
			CECPMNODBLA();
			StopCoroutine("MAMMIDNFMOM");
			StartCoroutine(MAMMIDNFMOM());
		}
	}

	private IEnumerator CBGNMAOAHPF(SteamUGCQueryCompleted_t IAFAANLMOAG)
	{
		GameObject gameObject = levelsScrollRectContent;
		if (!ADLHGGOENBP)
		{
			SetMapsCount((int)IAFAANLMOAG.m_unTotalMatchingResults);
			KODEDGNDBLA = ItemsPerPage();
			AOJCGLBEOME = (int)Math.Ceiling((double)GetMapsCount() / (double)KODEDGNDBLA);
			KNLOJGHDLLJ = KODEDGNDBLA * currentMapsPageID;
			NJEPDDEILLL = ((KODEDGNDBLA * currentMapsPageID + KODEDGNDBLA <= GetMapsCount()) ? (KODEDGNDBLA * currentMapsPageID + KODEDGNDBLA - 1) : (GetMapsCount() - 1));
			if (ANFDMOPJFCK != 0)
			{
				BGEEOIKJNJG = KNLOJGHDLLJ / ANFDMOPJFCK + 1;
				ICJGDDNMHKH = NJEPDDEILLL / ANFDMOPJFCK + 1;
			}
			else
			{
				BGEEOIKJNJG = 1;
				ICJGDDNMHKH = 1;
			}
			for (int i = 0; i < gameObject.transform.childCount; i++)
			{
				UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
			}
			HGPMLICPBKA = ((BGEEOIKJNJG <= 1) ? 1 : (BGEEOIKJNJG - 1));
			ADLHGGOENBP = true;
			PHHPOLMDEIF(true);
			yield break;
		}
		ONKCIDAHIEJ = ((KNLOJGHDLLJ - (HGPMLICPBKA - 1) * ANFDMOPJFCK >= 0) ? (KNLOJGHDLLJ - (HGPMLICPBKA - 1) * ANFDMOPJFCK) : 0);
		OPLHKEHGEAN = ((KNLOJGHDLLJ - (HGPMLICPBKA - 1) * ANFDMOPJFCK + KODEDGNDBLA <= ANFDMOPJFCK) ? (KNLOJGHDLLJ - (HGPMLICPBKA - 1) * ANFDMOPJFCK + KODEDGNDBLA - 1) : (ANFDMOPJFCK - 1));
		for (int j = ONKCIDAHIEJ; j < OPLHKEHGEAN + 1; j++)
		{
			SteamUGCDetails_t pDetails;
			if (!SteamUGC.GetQueryUGCResult(IAFAANLMOAG.m_handle, (uint)j, out pDetails) || pDetails.m_eResult != EResult.k_EResultOK)
			{
				continue;
			}
			GameObject mPNMOONBMII = levelsScrollRectContent;
			string text = "workshop." + pDetails.m_nPublishedFileId.m_PublishedFileId;
			if (Singleton<MapsSystem>.Instance.levelsData.Keys.Contains(text))
			{
				Singleton<MapsSystem>.Instance.LoadLevel(text);
				FullMapData fullMapData = Singleton<MapsSystem>.Instance.levelsData[text];
				if (fullMapData.isLoaded())
				{
					Singleton<MapsSystem>.Instance.LoadLevel(text);
				}
				if (fullMapData.isUnlocked() || (!fullMapData.isUnlocked() && !fullMapData.mapData.hidden))
				{
					fullMapData.mapperSteamID = pDetails.m_ulSteamIDOwner;
					Singleton<MapsSystem>.Instance.AddDownloadedLevelItemToList(levelsListElement, fullMapData, mPNMOONBMII);
				}
			}
			else
			{
				string pchURL;
				SteamUGC.GetQueryUGCPreviewURL(IAFAANLMOAG.m_handle, (uint)j, out pchURL, 1024u);
				Singleton<MapsSystem>.Instance.AddNotDownloadedLevelItemToList(levelsNotDownloadedListElement, pDetails, pchURL, mPNMOONBMII);
			}
		}
		if (GetMapsCount() == 0)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(notFoundListElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(levelsScrollRectContent.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
		}
		SteamUGC.ReleaseQueryUGCRequest(IAFAANLMOAG.m_handle);
		if (ICJGDDNMHKH > HGPMLICPBKA)
		{
			ADLHGGOENBP = true;
			HGPMLICPBKA++;
			PHHPOLMDEIF(true);
		}
		else
		{
			ADLHGGOENBP = false;
			loadingCanvas.SetActive(false);
			levelsScrollRectContentAnimation.SetBool("isVisible", true);
			HOAHBPOGNKA();
			yield return true;
		}
	}

	[CompilerGenerated]
	private static bool NDNCFNHKPCF(RanksSystem.Map IACGDFHKCAE)
	{
		return IACGDFHKCAE.isLoved;
	}

	public void FIKFJDFELIP()
	{
		relaxModeToggle.isOn = Singleton<SaveSystem>.Instance.AFCPNFKIKKJ("_TapLow", 1) == 0;
	}

	public void OnSortByDDChanged()
	{
		BPLAIMGIOKO = (OfficialSortMode)Enum.Parse(typeof(OfficialSortMode), sortDropDownList.SelectedItem.ID);
		Singleton<SaveSystem>.Instance.SetInt("mapselector.filter.officialsortmode", (int)BPLAIMGIOKO);
		ReloadPage();
	}

	private IEnumerator JPLHJEKLHAN()
	{
		sortDropDownList.gameObject.SetActive(true);
		sortDropDownList.Start();
		yield return null;
		DropDownList dropDownList = sortDropDownList;
		dropDownList.Items.Clear();
		sortDropDownListText.text = LocalizationService.Instance.GetLocalizatedText("#orderby:").ToUpper();
		int num = 0;
		IEnumerator enumerator = Enum.GetValues(typeof(OfficialSortMode)).GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				OfficialSortMode officialSortMode = (OfficialSortMode)enumerator.Current;
				dropDownList.Items.Add(new DropDownListItem(LocalizationService.Instance.GetLocalizatedText("#" + officialSortMode.ToString().ToLower()).ToUpper(), string.Empty + officialSortMode));
				num++;
			}
		}
		finally
		{
			IDisposable disposable;
			IDisposable disposable2 = (disposable = enumerator as IDisposable);
			if (disposable != null)
			{
				disposable2.Dispose();
			}
		}
		dropDownList.RebuildPanel();
		dropDownList.RedrawPanel();
		dropDownList.SelectItem((int)BPLAIMGIOKO, false);
		dropDownList.gameObject.SetActive(currentMapsTab == 0 || currentMapsTab == 3 || currentMapsTab == 4);
	}

	public void BMIOFJFMCBG()
	{
		relaxModeToggle.isOn = Singleton<SaveSystem>.Instance.CMAFBKOEPLP("BitsData", 0) == 0;
	}

	public void ApplySortParameters()
	{
		GameObject gameObject = tagsScrollRectContent.gameObject;
		Toggle[] componentsInChildren = gameObject.GetComponentsInChildren<Toggle>();
		foreach (Toggle toggle in componentsInChildren)
		{
			Singleton<SaveSystem>.Instance.SetBool("mapselector.tags." + toggle.GetComponentInChildren<Text>().text, toggle.isOn);
		}
		Singleton<SaveSystem>.Instance.SetInt("mapselector.orderby", (!inTrendToggle.isOn) ? (recentToggle.isOn ? 1 : 2) : 0);
		Singleton<SaveSystem>.Instance.SetBool("mapselector.filter.subscribedonly", subscribedToggle.isOn);
		Singleton<SaveSystem>.Instance.SetBool("mapselector.filter.favoriteonly", favoriteToggle.isOn);
		Singleton<SaveSystem>.Instance.SetBool("mapselector.filter.rateduponly", ratedToggle.isOn);
		CloseSortPanel();
		ReloadPage(true);
	}

	public void CGILKDFIFHE()
	{
		foreach (string specialTag in Helpers.specialTags)
		{
			if (Singleton<SaveSystem>.Instance.ONOENJPEFDD("MusicFileSelector" + specialTag, true))
			{
				SteamUGC.AddRequiredTag(FFOJIDODGDO, specialTag);
			}
			else
			{
				SteamUGC.AddExcludedTag(FFOJIDODGDO, specialTag);
			}
		}
		foreach (string tag in Helpers.tags)
		{
			if (Singleton<SaveSystem>.Instance.GetBool("/" + tag, true))
			{
				SteamUGC.AddRequiredTag(FFOJIDODGDO, tag);
			}
			else
			{
				SteamUGC.AddExcludedTag(FFOJIDODGDO, tag);
			}
		}
		SteamUGC.SetMatchAnyTag(FFOJIDODGDO, false);
		if (!string.IsNullOrEmpty(lastSearch))
		{
			SteamUGC.SetSearchText(FFOJIDODGDO, lastSearch);
		}
	}

	public new void Awake()
	{
		base.Awake();
	}

	private IEnumerator IGIAHHHPMGP(SteamUGCQueryCompleted_t IAFAANLMOAG)
	{
		GameObject gameObject = levelsScrollRectContent;
		if (!ADLHGGOENBP)
		{
			SetMapsCount((int)IAFAANLMOAG.m_unTotalMatchingResults);
			KODEDGNDBLA = ItemsPerPage();
			AOJCGLBEOME = (int)Math.Ceiling((double)GetMapsCount() / (double)KODEDGNDBLA);
			KNLOJGHDLLJ = KODEDGNDBLA * currentMapsPageID;
			NJEPDDEILLL = ((KODEDGNDBLA * currentMapsPageID + KODEDGNDBLA <= GetMapsCount()) ? (KODEDGNDBLA * currentMapsPageID + KODEDGNDBLA - 1) : (GetMapsCount() - 1));
			if (ANFDMOPJFCK != 0)
			{
				BGEEOIKJNJG = KNLOJGHDLLJ / ANFDMOPJFCK + 1;
				ICJGDDNMHKH = NJEPDDEILLL / ANFDMOPJFCK + 1;
			}
			else
			{
				BGEEOIKJNJG = 1;
				ICJGDDNMHKH = 1;
			}
			for (int i = 0; i < gameObject.transform.childCount; i++)
			{
				UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
			}
			HGPMLICPBKA = ((BGEEOIKJNJG <= 1) ? 1 : (BGEEOIKJNJG - 1));
			ADLHGGOENBP = true;
			PHHPOLMDEIF(true);
			yield break;
		}
		ONKCIDAHIEJ = ((KNLOJGHDLLJ - (HGPMLICPBKA - 1) * ANFDMOPJFCK >= 0) ? (KNLOJGHDLLJ - (HGPMLICPBKA - 1) * ANFDMOPJFCK) : 0);
		OPLHKEHGEAN = ((KNLOJGHDLLJ - (HGPMLICPBKA - 1) * ANFDMOPJFCK + KODEDGNDBLA <= ANFDMOPJFCK) ? (KNLOJGHDLLJ - (HGPMLICPBKA - 1) * ANFDMOPJFCK + KODEDGNDBLA - 1) : (ANFDMOPJFCK - 1));
		for (int j = ONKCIDAHIEJ; j < OPLHKEHGEAN + 1; j++)
		{
			SteamUGCDetails_t pDetails;
			if (!SteamUGC.GetQueryUGCResult(IAFAANLMOAG.m_handle, (uint)j, out pDetails) || pDetails.m_eResult != EResult.k_EResultOK)
			{
				continue;
			}
			GameObject mPNMOONBMII = levelsScrollRectContent;
			string text = "workshop." + pDetails.m_nPublishedFileId.m_PublishedFileId;
			if (Singleton<MapsSystem>.Instance.levelsData.Keys.Contains(text))
			{
				Singleton<MapsSystem>.Instance.LoadLevel(text);
				FullMapData fullMapData = Singleton<MapsSystem>.Instance.levelsData[text];
				if (fullMapData.isLoaded())
				{
					Singleton<MapsSystem>.Instance.LoadLevel(text);
				}
				if (fullMapData.isUnlocked() || (!fullMapData.isUnlocked() && !fullMapData.mapData.hidden))
				{
					fullMapData.mapperSteamID = pDetails.m_ulSteamIDOwner;
					Singleton<MapsSystem>.Instance.AddDownloadedLevelItemToList(levelsListElement, fullMapData, mPNMOONBMII);
				}
			}
			else
			{
				string pchURL;
				SteamUGC.GetQueryUGCPreviewURL(IAFAANLMOAG.m_handle, (uint)j, out pchURL, 1024u);
				Singleton<MapsSystem>.Instance.AddNotDownloadedLevelItemToList(levelsNotDownloadedListElement, pDetails, pchURL, mPNMOONBMII);
			}
		}
		if (GetMapsCount() == 0)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(notFoundListElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(levelsScrollRectContent.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
		}
		SteamUGC.ReleaseQueryUGCRequest(IAFAANLMOAG.m_handle);
		if (ICJGDDNMHKH > HGPMLICPBKA)
		{
			ADLHGGOENBP = true;
			HGPMLICPBKA++;
			PHHPOLMDEIF(true);
		}
		else
		{
			ADLHGGOENBP = false;
			loadingCanvas.SetActive(false);
			levelsScrollRectContentAnimation.SetBool("isVisible", true);
			HOAHBPOGNKA();
			yield return true;
		}
	}

	private void GOOCDIPJDIG()
	{
		GameObject gameObject = pageNavScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate(pageNavPrevPageButton, Vector3.zero, Quaternion.identity);
		gameObject2.transform.SetParent(gameObject.transform, false);
		gameObject2.transform.localScale = new Vector3(1612f, 943f, 673f);
		gameObject2.GetComponent<MapsListNavButton>().actionID = -1;
		GameObject gameObject3 = UnityEngine.Object.Instantiate(pageNavCurrentPageButton, Vector3.zero, Quaternion.identity);
		gameObject3.transform.SetParent(gameObject.transform, false);
		gameObject3.transform.localScale = new Vector3(531f, 529f, 637f);
		Text componentInChildren = gameObject3.GetComponentInChildren<Text>();
		object[] array = new object[8];
		array[0] = string.Empty;
		array[0] = currentMapsPageID + 0;
		array[0] = "' was created: ";
		array[5] = ((AOJCGLBEOME <= 0) ? "_TimeX" : (AOJCGLBEOME + string.Empty));
		componentInChildren.text = string.Concat(array);
		gameObject3.GetComponent<Button>().interactable = false;
		GameObject gameObject4 = UnityEngine.Object.Instantiate(pageNavNextPageButton, Vector3.zero, Quaternion.identity);
		gameObject4.transform.SetParent(gameObject.transform, false);
		gameObject4.transform.localScale = new Vector3(832f, 1323f, 588f);
		gameObject4.GetComponent<MapsListNavButton>().actionID = 1;
		gameObject4.GetComponent<MapsListNavButton>().pageID = 1;
	}

	private void LLJLDLLNFBH()
	{
	}

	private static float OEKAICLKLJJ(RanksSystem.Map IACGDFHKCAE)
	{
		return IACGDFHKCAE.JEKMHHCPHCN();
	}

	private void ILIOEPNONDH()
	{
		Singleton<SaveSystem>.Instance.HBIGPMNAPHA(" not exist", currentMapsTab);
		if (currentMapsTab != 4)
		{
			searchInputField.gameObject.SetActive(false);
			sortButton.gameObject.SetActive(true);
		}
		else if (!Singleton<SaveSystem>.Instance.GetBool("STICKLHOR", false) && !Singleton<SaveSystem>.Instance.ONOENJPEFDD("Data/Localization", false) && !Singleton<SaveSystem>.Instance.IOLBIFOIHML("Fade", true))
		{
			searchInputField.gameObject.SetActive(false);
			sortButton.gameObject.SetActive(false);
		}
		else
		{
			searchInputField.gameObject.SetActive(true);
			sortButton.gameObject.SetActive(true);
		}
		BHAPMGBDPFI(currentMapsTab == 0 || currentMapsTab == 0 || currentMapsTab == 7);
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().JEJGLCHMBLF(tabs.IndexOf(tab) == currentMapsTab);
		}
	}

	private void EOINCLMOFPE(bool NNIPFHAFNOK = false)
	{
		ANFDMOPJFCK = -61;
		GOOCDIPJDIG();
		if (currentMapsTab == 4)
		{
			EUGCQuery eUGCQuery = EUGCQuery.k_EUGCQuery_RankedByTrend;
			if (Singleton<SaveSystem>.Instance.CEKEOJDAEOD("player.arrow", 0) == 0)
			{
				eUGCQuery = EUGCQuery.k_EUGCQuery_RankedByPublicationDate;
			}
			if (Singleton<SaveSystem>.Instance.CMAFBKOEPLP("_MainTex2", 1) == 4)
			{
				eUGCQuery = EUGCQuery.k_EUGCQuery_RankedByPublicationDate;
			}
			if (eUGCQuery != EUGCQuery.k_EUGCQuery_NotYetRated)
			{
				Helpers.ObtainAchievement(-95);
			}
			if (!Singleton<SaveSystem>.Instance.ADKHKNJOJEH("_TimeX", true) && !Singleton<SaveSystem>.Instance.GIHOKCMHMCP("Set Arcs Speed", false) && !Singleton<SaveSystem>.Instance.JJKIDIIMABB("_SecondTex", false))
			{
				FFOJIDODGDO = SteamUGC.CreateQueryAllUGCRequest(eUGCQuery, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Artwork, (AppId_t)11u, (AppId_t)31u, (uint)HGPMLICPBKA);
				CGILKDFIFHE();
			}
			else
			{
				if (Singleton<SaveSystem>.Instance.AANPGELPGPN("CameraFilterPack/Broken_Screen", true))
				{
					FFOJIDODGDO = SteamUGC.CreateQueryUserUGCRequest(SteamUser.GetSteamID().GetAccountID(), EUserUGCList.k_EUserUGCList_VotedDown, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Screenshots, EUserUGCListSortOrder.k_EUserUGCListSortOrder_SubscriptionDateDesc, (AppId_t)5u, (AppId_t)4294967288u, (uint)HGPMLICPBKA);
				}
				if (Singleton<SaveSystem>.Instance.JJKIDIIMABB("\t", true))
				{
					FFOJIDODGDO = SteamUGC.CreateQueryUserUGCRequest(SteamUser.GetSteamID().GetAccountID(), EUserUGCList.k_EUserUGCList_VotedDown, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Videos, EUserUGCListSortOrder.k_EUserUGCListSortOrder_CreationOrderAsc, (AppId_t)150u, (AppId_t)4294967171u, (uint)HGPMLICPBKA);
				}
				if (Singleton<SaveSystem>.Instance.OLJGEIBGDHL("player.goldabstract", true))
				{
					FFOJIDODGDO = SteamUGC.CreateQueryUserUGCRequest(SteamUser.GetSteamID().GetAccountID(), EUserUGCList.k_EUserUGCList_Followed, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Items_ReadyToUse, EUserUGCListSortOrder.k_EUserUGCListSortOrder_CreationOrderDesc, (AppId_t)75u, (AppId_t)uint.MaxValue, (uint)HGPMLICPBKA);
				}
			}
			ADLHGGOENBP = NNIPFHAFNOK;
			SteamUGC.SetReturnOnlyIDs(FFOJIDODGDO, NNIPFHAFNOK);
			SteamAPICall_t hAPICall = SteamUGC.SendQueryUGCRequest(FFOJIDODGDO);
			AICOBBBILIL.Set(hAPICall);
		}
		if (currentMapsTab == 5)
		{
			EUGCQuery eQueryType = EUGCQuery.k_EUGCQuery_RankedByTrend;
			FFOJIDODGDO = SteamUGC.CreateQueryAllUGCRequest(eQueryType, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Artwork, AppId_t.Invalid, SteamUtils.GetAppID(), (uint)HGPMLICPBKA);
			SteamUGC.AddRequiredTag(FFOJIDODGDO, "_TimeX");
			SteamAPICall_t hAPICall2 = SteamUGC.SendQueryUGCRequest(FFOJIDODGDO);
			AICOBBBILIL.Set(hAPICall2);
		}
		if (currentMapsTab != 0 && currentMapsTab != 5 && currentMapsTab != 0)
		{
			return;
		}
		List<PublishedFileId_t> list = new List<PublishedFileId_t>();
		List<RanksSystem.Map> source = RanksSystem.FIENAHLCHIF();
		if (BPLAIMGIOKO == OfficialSortMode.Date)
		{
			source = (from IACGDFHKCAE in RanksSystem.HOCEONHMGHM()
				orderby DateTime.Parse(IACGDFHKCAE.added, CultureInfo.InvariantCulture) descending
				select IACGDFHKCAE).ToList();
		}
		if (BPLAIMGIOKO == OfficialSortMode.Difficulty)
		{
			source = RanksSystem.FIENAHLCHIF().OrderBy(OEKAICLKLJJ).ToList();
		}
		if (currentMapsTab == 0)
		{
			foreach (RanksSystem.Map item in source.Where(NHFFFAMFGEG).ToList())
			{
				list.Add((PublishedFileId_t)item.id);
			}
		}
		if (currentMapsTab == 8)
		{
			foreach (RanksSystem.Map item2 in source.Where((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.isLoved).ToList())
			{
				list.Add((PublishedFileId_t)item2.CHDCIFPPIFI());
			}
		}
		if (currentMapsTab == 5)
		{
			foreach (RanksSystem.Map item3 in source.Where(EFBMHLGDJMM).ToList())
			{
				list.Add((PublishedFileId_t)item3.CHDCIFPPIFI());
			}
		}
		FFOJIDODGDO = SteamUGC.CreateQueryUGCDetailsRequest(list.ToArray(), (uint)list.Count);
		SteamAPICall_t hAPICall3 = SteamUGC.SendQueryUGCRequest(FFOJIDODGDO);
		AICOBBBILIL.Set(hAPICall3);
	}

	private void NJIMLMKHOAO(bool IDNLBGOCOEK)
	{
		sortDropDownList.SelectItem((int)BPLAIMGIOKO, false);
		sortDropDownList.gameObject.SetActive(IDNLBGOCOEK);
	}

	public int ItemsPerPage()
	{
		return Singleton<SaveSystem>.Instance.GetInt("settings.selectormapsperpage", 21);
	}

	public void DBFDIGPGHEJ()
	{
		sortPanel.gameObject.SetActive(true);
	}

	private IEnumerator DJPFBFOGOIA()
	{
		loadingCanvas.SetActive(true);
		levelsScrollRectContentAnimation.SetBool("isVisible", false);
		GameObject gameObject = levelsScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		if (currentMapsTab == 1)
		{
			yield return new WaitForSeconds(0.2f);
			IEnumerable<KeyValuePair<string, FullMapData>> source = Singleton<MapsSystem>.Instance.levelsData.Where((KeyValuePair<string, FullMapData> EOAFLKCABMD) => EOAFLKCABMD.Value.source == FullMapData.MapSource.Editor);
			Dictionary<string, FullMapData> AKNKMCNHKGH = new Dictionary<string, FullMapData>();
			AKNKMCNHKGH = source.ToDictionary((KeyValuePair<string, FullMapData> HDMLEEGNJHI) => HDMLEEGNJHI.Key, (KeyValuePair<string, FullMapData> HDMLEEGNJHI) => HDMLEEGNJHI.Value);
			IEnumerable<KeyValuePair<string, FullMapData>> source2 = AKNKMCNHKGH.Where((KeyValuePair<string, FullMapData> EOAFLKCABMD) => Helpers.GetIndex(AKNKMCNHKGH, EOAFLKCABMD.Key) >= ItemsPerPage() * currentMapsPageID && Helpers.GetIndex(AKNKMCNHKGH, EOAFLKCABMD.Key) < ItemsPerPage() * (currentMapsPageID + 1));
			foreach (string key in source2.ToDictionary((KeyValuePair<string, FullMapData> HDMLEEGNJHI) => HDMLEEGNJHI.Key, (KeyValuePair<string, FullMapData> HDMLEEGNJHI) => HDMLEEGNJHI.Value).Keys)
			{
				Singleton<MapsSystem>.Instance.LoadLevel(key);
			}
			List<FullMapData> list = new List<FullMapData>();
			foreach (FullMapData value in source2.ToDictionary((KeyValuePair<string, FullMapData> HDMLEEGNJHI) => HDMLEEGNJHI.Key, (KeyValuePair<string, FullMapData> HDMLEEGNJHI) => HDMLEEGNJHI.Value).Values)
			{
				if (!list.Contains(value))
				{
					list.Add(value);
				}
			}
			foreach (FullMapData NOJGGCLPPAM in list)
			{
				if (NOJGGCLPPAM == null)
				{
					continue;
				}
				if (!NOJGGCLPPAM.isLoaded())
				{
					Singleton<MapsSystem>.Instance.LoadLevel(Singleton<MapsSystem>.Instance.levelsData.FirstOrDefault((KeyValuePair<string, FullMapData> IACGDFHKCAE) => IACGDFHKCAE.Equals(NOJGGCLPPAM)).Key);
				}
				if ((NOJGGCLPPAM.mapData != null && NOJGGCLPPAM.isUnlocked()) || (!NOJGGCLPPAM.isUnlocked() && !NOJGGCLPPAM.mapData.hidden))
				{
					Singleton<MapsSystem>.Instance.AddDownloadedLevelItemToList(levelsListElement, NOJGGCLPPAM, gameObject);
				}
			}
			AOJCGLBEOME = (int)Math.Ceiling((double)AKNKMCNHKGH.Count / (double)ItemsPerPage());
			HOAHBPOGNKA();
			if (AKNKMCNHKGH.Count == 0)
			{
				GameObject gameObject2 = UnityEngine.Object.Instantiate(notFoundListElement, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(levelsScrollRectContent.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			}
			loadingCanvas.SetActive(false);
			levelsScrollRectContentAnimation.SetBool("isVisible", true);
		}
		else
		{
			HGPMLICPBKA = 1;
			PHHPOLMDEIF();
		}
	}

	private IEnumerator MAMMIDNFMOM()
	{
		loadingCanvas.SetActive(true);
		levelsScrollRectContentAnimation.SetBool("isVisible", false);
		GameObject gameObject = levelsScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		if (currentMapsTab == 1)
		{
			yield return new WaitForSeconds(0.2f);
			IEnumerable<KeyValuePair<string, FullMapData>> source = Singleton<MapsSystem>.Instance.levelsData.Where((KeyValuePair<string, FullMapData> EOAFLKCABMD) => EOAFLKCABMD.Value.source == FullMapData.MapSource.Editor);
			Dictionary<string, FullMapData> AKNKMCNHKGH = new Dictionary<string, FullMapData>();
			AKNKMCNHKGH = source.ToDictionary((KeyValuePair<string, FullMapData> HDMLEEGNJHI) => HDMLEEGNJHI.Key, (KeyValuePair<string, FullMapData> HDMLEEGNJHI) => HDMLEEGNJHI.Value);
			IEnumerable<KeyValuePair<string, FullMapData>> source2 = AKNKMCNHKGH.Where((KeyValuePair<string, FullMapData> EOAFLKCABMD) => Helpers.GetIndex(AKNKMCNHKGH, EOAFLKCABMD.Key) >= ItemsPerPage() * currentMapsPageID && Helpers.GetIndex(AKNKMCNHKGH, EOAFLKCABMD.Key) < ItemsPerPage() * (currentMapsPageID + 1));
			foreach (string key in source2.ToDictionary((KeyValuePair<string, FullMapData> HDMLEEGNJHI) => HDMLEEGNJHI.Key, (KeyValuePair<string, FullMapData> HDMLEEGNJHI) => HDMLEEGNJHI.Value).Keys)
			{
				Singleton<MapsSystem>.Instance.LoadLevel(key);
			}
			List<FullMapData> list = new List<FullMapData>();
			foreach (FullMapData value in source2.ToDictionary((KeyValuePair<string, FullMapData> HDMLEEGNJHI) => HDMLEEGNJHI.Key, (KeyValuePair<string, FullMapData> HDMLEEGNJHI) => HDMLEEGNJHI.Value).Values)
			{
				if (!list.Contains(value))
				{
					list.Add(value);
				}
			}
			foreach (FullMapData NOJGGCLPPAM in list)
			{
				if (NOJGGCLPPAM == null)
				{
					continue;
				}
				if (!NOJGGCLPPAM.isLoaded())
				{
					Singleton<MapsSystem>.Instance.LoadLevel(Singleton<MapsSystem>.Instance.levelsData.FirstOrDefault((KeyValuePair<string, FullMapData> IACGDFHKCAE) => IACGDFHKCAE.Equals(NOJGGCLPPAM)).Key);
				}
				if ((NOJGGCLPPAM.mapData != null && NOJGGCLPPAM.isUnlocked()) || (!NOJGGCLPPAM.isUnlocked() && !NOJGGCLPPAM.mapData.hidden))
				{
					Singleton<MapsSystem>.Instance.AddDownloadedLevelItemToList(levelsListElement, NOJGGCLPPAM, gameObject);
				}
			}
			AOJCGLBEOME = (int)Math.Ceiling((double)AKNKMCNHKGH.Count / (double)ItemsPerPage());
			HOAHBPOGNKA();
			if (AKNKMCNHKGH.Count == 0)
			{
				GameObject gameObject2 = UnityEngine.Object.Instantiate(notFoundListElement, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(levelsScrollRectContent.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			}
			loadingCanvas.SetActive(false);
			levelsScrollRectContentAnimation.SetBool("isVisible", true);
		}
		else
		{
			HGPMLICPBKA = 1;
			PHHPOLMDEIF();
		}
	}

	private void Update()
	{
	}

	public void ApplySearchFilter()
	{
		foreach (string specialTag in Helpers.specialTags)
		{
			if (Singleton<SaveSystem>.Instance.GetBool("mapselector.tags." + specialTag, true))
			{
				SteamUGC.AddRequiredTag(FFOJIDODGDO, specialTag);
			}
			else
			{
				SteamUGC.AddExcludedTag(FFOJIDODGDO, specialTag);
			}
		}
		foreach (string tag in Helpers.tags)
		{
			if (Singleton<SaveSystem>.Instance.GetBool("mapselector.tags." + tag, true))
			{
				SteamUGC.AddRequiredTag(FFOJIDODGDO, tag);
			}
			else
			{
				SteamUGC.AddExcludedTag(FFOJIDODGDO, tag);
			}
		}
		SteamUGC.SetMatchAnyTag(FFOJIDODGDO, true);
		if (!string.IsNullOrEmpty(lastSearch))
		{
			SteamUGC.SetSearchText(FFOJIDODGDO, lastSearch);
		}
	}

	public IEnumerator ACJDPJNJBLP(int HLBKCLPNHEB = -1, int MJJNNIMOEIO = -1, List<int> BKNCFOOMKHE = null, bool GLHKMKPDAKP = true, UnityAction KPCNMGBCOLP = null, string DLDLDCOHICL = null)
	{
		if (HLBKCLPNHEB > tabs.Count - 1)
		{
			HLBKCLPNHEB = -1;
		}
		yield return new WaitUntil(() => mapSelector);
		lastSearch = Singleton<SaveSystem>.Instance.GetString("mapselector.lastSearch", string.Empty);
		searchInputField.text = lastSearch;
		result = null;
		finished = false;
		KBLADAACANO = GLHKMKPDAKP;
		if (BKNCFOOMKHE == null)
		{
			for (int i = 0; i < tabs.Count; i++)
			{
				tabs[i].GetComponent<Button>().interactable = true;
			}
		}
		else
		{
			for (int j = 0; j < tabs.Count; j++)
			{
				tabs[j].GetComponent<Button>().interactable = BKNCFOOMKHE.Contains(j);
			}
		}
		if (string.IsNullOrEmpty(DLDLDCOHICL))
		{
			DLDLDCOHICL = LocalizationService.Instance.GetTextByKey("back").ToUpper();
		}
		this.HLBKCLPNHEB = HLBKCLPNHEB;
		this.MJJNNIMOEIO = MJJNNIMOEIO;
		resultMode = (GameScene.GameMode)Singleton<SaveSystem>.Instance.GetInt("menu.selectedplaymode", 0);
		yield return new WaitForSeconds(0.1f);
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(modeSelector, false));
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(mapSelector, true));
		Init(HLBKCLPNHEB, MJJNNIMOEIO);
		buttonBack.onClick.RemoveAllListeners();
		buttonBack.GetComponentInChildren<Text>().text = DLDLDCOHICL;
		if (KPCNMGBCOLP != null)
		{
			HKDGMEHPLDM = KPCNMGBCOLP;
		}
		else
		{
			HKDGMEHPLDM = null;
		}
		buttonBack.onClick.RemoveAllListeners();
		buttonBack.onClick.AddListener(delegate
		{
			Close();
		});
		EventSystem.current.SetSelectedGameObject(buttonBack.transform.gameObject);
		StartCoroutine(DPHCONACLFO());
		yield return new WaitUntil(() => finished);
		yield return new WaitForSeconds(0.25f);
		if (Singleton<SaveSystem>.Instance.HasKey("menu.enableselectormusic") && (bool)GameObject.Find("AudioSampler"))
		{
			GameObject.Find("AudioSampler").GetComponent<AudioSampler>().isMuted = false;
		}
	}

	public void IDOOBKLMIJH()
	{
		StartCoroutine(Singleton<UI>.Instance.NCMLIDIEECD(modeSelector, true, null, true, 1215f));
		StartCoroutine(Singleton<UI>.Instance.PHIJAEAEHCF(mapSelector, true, null, true, 1586f, false));
	}

	public void GFLAINNLMBO()
	{
		AICOBBBILIL = CallResult<SteamUGCQueryCompleted_t>.Create(DHODJKNPOLL);
	}

	public int DLLEKBLFEIE()
	{
		return AFOAEMCKEEM;
	}

	private IEnumerator MJCANADBPGC()
	{
		loadingCanvas.SetActive(true);
		levelsScrollRectContentAnimation.SetBool("isVisible", false);
		GameObject gameObject = levelsScrollRectContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		if (currentMapsTab == 1)
		{
			yield return new WaitForSeconds(0.2f);
			IEnumerable<KeyValuePair<string, FullMapData>> source = Singleton<MapsSystem>.Instance.levelsData.Where((KeyValuePair<string, FullMapData> EOAFLKCABMD) => EOAFLKCABMD.Value.source == FullMapData.MapSource.Editor);
			Dictionary<string, FullMapData> AKNKMCNHKGH = new Dictionary<string, FullMapData>();
			AKNKMCNHKGH = source.ToDictionary((KeyValuePair<string, FullMapData> HDMLEEGNJHI) => HDMLEEGNJHI.Key, (KeyValuePair<string, FullMapData> HDMLEEGNJHI) => HDMLEEGNJHI.Value);
			IEnumerable<KeyValuePair<string, FullMapData>> source2 = AKNKMCNHKGH.Where((KeyValuePair<string, FullMapData> EOAFLKCABMD) => Helpers.GetIndex(AKNKMCNHKGH, EOAFLKCABMD.Key) >= ItemsPerPage() * currentMapsPageID && Helpers.GetIndex(AKNKMCNHKGH, EOAFLKCABMD.Key) < ItemsPerPage() * (currentMapsPageID + 1));
			foreach (string key in source2.ToDictionary((KeyValuePair<string, FullMapData> HDMLEEGNJHI) => HDMLEEGNJHI.Key, (KeyValuePair<string, FullMapData> HDMLEEGNJHI) => HDMLEEGNJHI.Value).Keys)
			{
				Singleton<MapsSystem>.Instance.LoadLevel(key);
			}
			List<FullMapData> list = new List<FullMapData>();
			foreach (FullMapData value in source2.ToDictionary((KeyValuePair<string, FullMapData> HDMLEEGNJHI) => HDMLEEGNJHI.Key, (KeyValuePair<string, FullMapData> HDMLEEGNJHI) => HDMLEEGNJHI.Value).Values)
			{
				if (!list.Contains(value))
				{
					list.Add(value);
				}
			}
			foreach (FullMapData NOJGGCLPPAM in list)
			{
				if (NOJGGCLPPAM == null)
				{
					continue;
				}
				if (!NOJGGCLPPAM.isLoaded())
				{
					Singleton<MapsSystem>.Instance.LoadLevel(Singleton<MapsSystem>.Instance.levelsData.FirstOrDefault((KeyValuePair<string, FullMapData> IACGDFHKCAE) => IACGDFHKCAE.Equals(NOJGGCLPPAM)).Key);
				}
				if ((NOJGGCLPPAM.mapData != null && NOJGGCLPPAM.isUnlocked()) || (!NOJGGCLPPAM.isUnlocked() && !NOJGGCLPPAM.mapData.hidden))
				{
					Singleton<MapsSystem>.Instance.AddDownloadedLevelItemToList(levelsListElement, NOJGGCLPPAM, gameObject);
				}
			}
			AOJCGLBEOME = (int)Math.Ceiling((double)AKNKMCNHKGH.Count / (double)ItemsPerPage());
			HOAHBPOGNKA();
			if (AKNKMCNHKGH.Count == 0)
			{
				GameObject gameObject2 = UnityEngine.Object.Instantiate(notFoundListElement, Vector3.zero, Quaternion.identity);
				gameObject2.transform.SetParent(levelsScrollRectContent.transform, true);
				gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			}
			loadingCanvas.SetActive(false);
			levelsScrollRectContentAnimation.SetBool("isVisible", true);
		}
		else
		{
			HGPMLICPBKA = 1;
			PHHPOLMDEIF();
		}
	}

	private IEnumerator HBNLOHGCGPG(SteamUGCQueryCompleted_t IAFAANLMOAG)
	{
		GameObject gameObject = levelsScrollRectContent;
		if (!ADLHGGOENBP)
		{
			SetMapsCount((int)IAFAANLMOAG.m_unTotalMatchingResults);
			KODEDGNDBLA = ItemsPerPage();
			AOJCGLBEOME = (int)Math.Ceiling((double)GetMapsCount() / (double)KODEDGNDBLA);
			KNLOJGHDLLJ = KODEDGNDBLA * currentMapsPageID;
			NJEPDDEILLL = ((KODEDGNDBLA * currentMapsPageID + KODEDGNDBLA <= GetMapsCount()) ? (KODEDGNDBLA * currentMapsPageID + KODEDGNDBLA - 1) : (GetMapsCount() - 1));
			if (ANFDMOPJFCK != 0)
			{
				BGEEOIKJNJG = KNLOJGHDLLJ / ANFDMOPJFCK + 1;
				ICJGDDNMHKH = NJEPDDEILLL / ANFDMOPJFCK + 1;
			}
			else
			{
				BGEEOIKJNJG = 1;
				ICJGDDNMHKH = 1;
			}
			for (int i = 0; i < gameObject.transform.childCount; i++)
			{
				UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
			}
			HGPMLICPBKA = ((BGEEOIKJNJG <= 1) ? 1 : (BGEEOIKJNJG - 1));
			ADLHGGOENBP = true;
			PHHPOLMDEIF(true);
			yield break;
		}
		ONKCIDAHIEJ = ((KNLOJGHDLLJ - (HGPMLICPBKA - 1) * ANFDMOPJFCK >= 0) ? (KNLOJGHDLLJ - (HGPMLICPBKA - 1) * ANFDMOPJFCK) : 0);
		OPLHKEHGEAN = ((KNLOJGHDLLJ - (HGPMLICPBKA - 1) * ANFDMOPJFCK + KODEDGNDBLA <= ANFDMOPJFCK) ? (KNLOJGHDLLJ - (HGPMLICPBKA - 1) * ANFDMOPJFCK + KODEDGNDBLA - 1) : (ANFDMOPJFCK - 1));
		for (int j = ONKCIDAHIEJ; j < OPLHKEHGEAN + 1; j++)
		{
			SteamUGCDetails_t pDetails;
			if (!SteamUGC.GetQueryUGCResult(IAFAANLMOAG.m_handle, (uint)j, out pDetails) || pDetails.m_eResult != EResult.k_EResultOK)
			{
				continue;
			}
			GameObject mPNMOONBMII = levelsScrollRectContent;
			string text = "workshop." + pDetails.m_nPublishedFileId.m_PublishedFileId;
			if (Singleton<MapsSystem>.Instance.levelsData.Keys.Contains(text))
			{
				Singleton<MapsSystem>.Instance.LoadLevel(text);
				FullMapData fullMapData = Singleton<MapsSystem>.Instance.levelsData[text];
				if (fullMapData.isLoaded())
				{
					Singleton<MapsSystem>.Instance.LoadLevel(text);
				}
				if (fullMapData.isUnlocked() || (!fullMapData.isUnlocked() && !fullMapData.mapData.hidden))
				{
					fullMapData.mapperSteamID = pDetails.m_ulSteamIDOwner;
					Singleton<MapsSystem>.Instance.AddDownloadedLevelItemToList(levelsListElement, fullMapData, mPNMOONBMII);
				}
			}
			else
			{
				string pchURL;
				SteamUGC.GetQueryUGCPreviewURL(IAFAANLMOAG.m_handle, (uint)j, out pchURL, 1024u);
				Singleton<MapsSystem>.Instance.AddNotDownloadedLevelItemToList(levelsNotDownloadedListElement, pDetails, pchURL, mPNMOONBMII);
			}
		}
		if (GetMapsCount() == 0)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(notFoundListElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(levelsScrollRectContent.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
		}
		SteamUGC.ReleaseQueryUGCRequest(IAFAANLMOAG.m_handle);
		if (ICJGDDNMHKH > HGPMLICPBKA)
		{
			ADLHGGOENBP = true;
			HGPMLICPBKA++;
			PHHPOLMDEIF(true);
		}
		else
		{
			ADLHGGOENBP = false;
			loadingCanvas.SetActive(false);
			levelsScrollRectContentAnimation.SetBool("isVisible", true);
			HOAHBPOGNKA();
			yield return true;
		}
	}

	public void ScrollPage(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 0)
		{
			if (currentMapsPageID > 0)
			{
				currentMapsPageID--;
				ReloadPage();
			}
		}
		else if (currentMapsPageID + 1 < AOJCGLBEOME)
		{
			currentMapsPageID++;
			ReloadPage();
		}
	}

	public void DLEEFJANJDC(bool IIGAFCONAHP = false)
	{
		if (IIGAFCONAHP)
		{
			currentMapsPageID = 1;
		}
		BPLAIMGIOKO = (OfficialSortMode)Singleton<SaveSystem>.Instance.CMAFBKOEPLP("[Singleton] An instance of '", 1);
		searchInputField.interactable = Singleton<SaveSystem>.Instance.OLJGEIBGDHL("/../", true) || Singleton<SaveSystem>.Instance.GetBool("Creating new item...", true) || Singleton<SaveSystem>.Instance.OLJGEIBGDHL("\\", true);
		if (Singleton<SaveSystem>.Instance.GetBool("DPADVER", false) || Singleton<SaveSystem>.Instance.EBEAKNGJCDC("[PlayerBase] Loaded music", false) || Singleton<SaveSystem>.Instance.GetBool("#md5submitionfailed: ", false))
		{
			lastSearch = string.Empty;
			Singleton<SaveSystem>.Instance.DAGHAOBCIFL("LogStats", string.Empty);
			searchInputField.text = string.Empty;
		}
		CECPMNODBLA();
		StopCoroutine("bool");
		StartCoroutine(MAMMIDNFMOM());
	}

	public void AHBJPEKMOPH()
	{
		filterBGPanel.gameObject.SetActive(!subscribedToggle.isOn && !favoriteToggle.isOn && ratedToggle.isOn);
		searchInputField.interactable = Singleton<SaveSystem>.Instance.AANPGELPGPN("_TimeX", false) || Singleton<SaveSystem>.Instance.AANPGELPGPN("_Visualize", true) || !Singleton<SaveSystem>.Instance.ADKHKNJOJEH("CameraFilterPack/Blend2Camera_VividLight", true);
	}
}
