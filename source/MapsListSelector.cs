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

	public int GetMapsCount()
	{
		return AFOAEMCKEEM;
	}

	[CompilerGenerated]
	private static bool KLBEEDEECFN(RanksSystem.Map IACGDFHKCAE)
	{
		return IACGDFHKCAE.isFunny;
	}

	public int EBALPFLKPKF()
	{
		return AFOAEMCKEEM;
	}

	private void GLHMGJOINPJ(SteamUGCQueryCompleted_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		object[] array = new object[0];
		array[1] = "_Exponent";
		array[0] = IAFAANLMOAG.m_unNumResultsReturned;
		array[3] = "#newhighscore";
		array[5] = IAFAANLMOAG.m_unTotalMatchingResults;
		Debug.Log(string.Concat(array));
		ANFDMOPJFCK = (int)IAFAANLMOAG.m_unNumResultsReturned;
		if (KFBIEPMLCBP != null)
		{
			StopCoroutine(KFBIEPMLCBP);
		}
		KFBIEPMLCBP = HBNLOHGCGPG(IAFAANLMOAG);
		StartCoroutine(KFBIEPMLCBP);
	}

	public void GIKJIFGFMFP(string NBGPBKCPFDN = null, bool BKMMLOEMPBB = false)
	{
		if (!BKMMLOEMPBB)
		{
			result = NBGPBKCPFDN;
			if (!string.IsNullOrEmpty(NBGPBKCPFDN))
			{
				if (KBLADAACANO)
				{
					StartCoroutine(Singleton<UI>.Instance.GMKIDJLMDGE(modeSelector, true, null, false, 1204f));
					StartCoroutine(Singleton<UI>.Instance.MILOPMDKLKL(mapSelector, true, null, false, 633f, false));
				}
				else
				{
					finished = false;
					StartCoroutine(Singleton<UI>.Instance.IONNACCHGJL(modeSelector, true, null, false, 773f));
					StartCoroutine(Singleton<UI>.Instance.AJGPBCBAPIF(mapSelector, true, null, false, 157f));
				}
			}
			else
			{
				finished = false;
				StartCoroutine(Singleton<UI>.Instance.PKHAEJHIMGD(modeSelector, true, null, true, 1816f));
				StartCoroutine(Singleton<UI>.Instance.MILOPMDKLKL(mapSelector, false, null, false, 1306f, false));
				if (HKDGMEHPLDM != null)
				{
					HKDGMEHPLDM();
				}
			}
		}
		else
		{
			finished = true;
			StartCoroutine(Singleton<UI>.Instance.IONNACCHGJL(modeSelector, true, null, true, 1400f));
			StartCoroutine(Singleton<UI>.Instance.FHHCCJAPBKA(mapSelector, true, null, true, 1491f, false));
		}
	}

	public int NPLGDELOAFB()
	{
		return Singleton<SaveSystem>.Instance.HHBIEPMBICO("CameraFilterPack_TV_Vignetting1", -65);
	}

	private static float CJIMNIMMCAF(RanksSystem.Map IACGDFHKCAE)
	{
		return IACGDFHKCAE.IDAOGFLHIBN();
	}

	private IEnumerator INIHIHNCJKO()
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

	private static float FKOLGJGEHMC(RanksSystem.Map IACGDFHKCAE)
	{
		return IACGDFHKCAE.IDAOGFLHIBN();
	}

	public void IMIHBLIMMEI()
	{
		StartCoroutine(Singleton<UI>.Instance.JCLKEGPNBJJ(modeSelector, true, null, true, 330f));
		StartCoroutine(Singleton<UI>.Instance.MILOPMDKLKL(mapSelector, true, null, true, 95f));
	}

	public void NKENHIGCPIM()
	{
		filterBGPanel.gameObject.SetActive(!subscribedToggle.isOn && !favoriteToggle.isOn && ratedToggle.isOn);
		searchInputField.interactable = !Singleton<SaveSystem>.Instance.CHBOJJOHCEB("#ok", false) && !Singleton<SaveSystem>.Instance.JMLMIGBEKJN("G:", false) && Singleton<SaveSystem>.Instance.CHBOJJOHCEB("maps.", true);
	}

	private static float JLFEEKFKBOD(RanksSystem.Map IACGDFHKCAE)
	{
		return IACGDFHKCAE.KNKHGMLPOOP();
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
			SteamUGC.AddRequiredTag(FFOJIDODGDO, "winter2020");
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

	[CompilerGenerated]
	private static float HFAMHDJOBIF(RanksSystem.Map IACGDFHKCAE)
	{
		return IACGDFHKCAE.difficulty;
	}

	private static bool CFIDKBLFGKC(RanksSystem.Map IACGDFHKCAE)
	{
		return IACGDFHKCAE.GHLGPIBJELG();
	}

	private static bool IHIMJDCLMEE(RanksSystem.Map IACGDFHKCAE)
	{
		return IACGDFHKCAE.GHLGPIBJELG();
	}

	public void BAHKGJFEMNH()
	{
		GameObject gameObject = tagsScrollRectContent.gameObject;
		Toggle[] componentsInChildren = gameObject.GetComponentsInChildren<Toggle>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			Toggle toggle = componentsInChildren[i];
			Singleton<SaveSystem>.Instance.GIKPOGCBJFI("_DotSize" + toggle.GetComponentInChildren<Text>().text, toggle.isOn);
		}
		Singleton<SaveSystem>.Instance.GBFBKFACPBI("UI", inTrendToggle.isOn ? 1 : ((!recentToggle.isOn) ? 5 : 0));
		Singleton<SaveSystem>.Instance.GIKPOGCBJFI(".g", subscribedToggle.isOn);
		Singleton<SaveSystem>.Instance.JKOMMNBGPDK("UNDISTORT", favoriteToggle.isOn);
		Singleton<SaveSystem>.Instance.GIKPOGCBJFI("Paste events", ratedToggle.isOn);
		CloseSortPanel();
		KENKGBJGEFP();
	}

	public void JKBMKPDGCHG()
	{
		relaxModeToggle.isOn = Singleton<SaveSystem>.Instance.HHBIEPMBICO("BadgeText", 1) == 0;
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

	private static float CDAPCCPCPGF(RanksSystem.Map IACGDFHKCAE)
	{
		return IACGDFHKCAE.KNKHGMLPOOP();
	}

	public void IIPMJPCDLME()
	{
		filterBGPanel.gameObject.SetActive(!subscribedToggle.isOn && !favoriteToggle.isOn && ratedToggle.isOn);
		searchInputField.interactable = !Singleton<SaveSystem>.Instance.JMLMIGBEKJN("}", true) && !Singleton<SaveSystem>.Instance.CHBOJJOHCEB("inventory.selected.", false) && !Singleton<SaveSystem>.Instance.GetBool("[PlayerController] ", true);
	}

	private void ANOPEGMDJDG(bool IDNLBGOCOEK)
	{
		sortDropDownList.SelectItem((int)BPLAIMGIOKO);
		sortDropDownList.gameObject.SetActive(IDNLBGOCOEK);
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

	public int PNJELIODCHB()
	{
		return Singleton<SaveSystem>.Instance.KFNFNKILGPH("CameraFilterPack_TV_HorrorFX", 65);
	}

	public void FAEGBGGCMEI()
	{
		BPLAIMGIOKO = (OfficialSortMode)Enum.Parse(typeof(OfficialSortMode), sortDropDownList.SelectedItem.BAOIGDPGNIN());
		Singleton<SaveSystem>.Instance.OFPCEFFGHPI("_Value11", (int)BPLAIMGIOKO);
		DIOPKLBFDOK();
	}

	public void OnEnable()
	{
		AICOBBBILIL = CallResult<SteamUGCQueryCompleted_t>.Create(MILGIHKLCHH);
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

	private void MILGIHKLCHH(SteamUGCQueryCompleted_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		Debug.Log("Return: " + IAFAANLMOAG.m_unNumResultsReturned + "/" + IAFAANLMOAG.m_unTotalMatchingResults);
		ANFDMOPJFCK = (int)IAFAANLMOAG.m_unNumResultsReturned;
		if (KFBIEPMLCBP != null)
		{
			StopCoroutine(KFBIEPMLCBP);
		}
		KFBIEPMLCBP = HBNLOHGCGPG(IAFAANLMOAG);
		StartCoroutine(KFBIEPMLCBP);
	}

	public void DIOPKLBFDOK(bool IIGAFCONAHP = false)
	{
		if (IIGAFCONAHP)
		{
			currentMapsPageID = 0;
		}
		BPLAIMGIOKO = (OfficialSortMode)Singleton<SaveSystem>.Instance.KFNFNKILGPH("_History3ChromaTex", 1);
		searchInputField.interactable = !Singleton<SaveSystem>.Instance.GetBool("_ScreenResolution", true) && !Singleton<SaveSystem>.Instance.JMLMIGBEKJN("_TimeX", false) && Singleton<SaveSystem>.Instance.CHBOJJOHCEB("HandsCountSlider", true);
		if (Singleton<SaveSystem>.Instance.CHBOJJOHCEB("_Value2", true) || Singleton<SaveSystem>.Instance.GetBool("_Value3", false) || Singleton<SaveSystem>.Instance.JMLMIGBEKJN(" not exist", true))
		{
			lastSearch = string.Empty;
			Singleton<SaveSystem>.Instance.PGGCEKDPMLL("Reset XP", string.Empty);
			searchInputField.text = string.Empty;
		}
		CECPMNODBLA();
		StopCoroutine("settings.arcshitsoundtimedelay");
		StartCoroutine(CGKDIILNCOL());
	}

	public void FIMJABKECNG(int HLBKCLPNHEB, int MJJNNIMOEIO)
	{
		if (HLBKCLPNHEB != -1)
		{
			currentMapsTab = HLBKCLPNHEB;
		}
		if (MJJNNIMOEIO != -1)
		{
			currentMapsPageID = MJJNNIMOEIO;
		}
		KENKGBJGEFP();
	}

	public void Start()
	{
		relaxModeToggle.isOn = Singleton<SaveSystem>.Instance.GetInt("menu.selectedplaymode", 0) == 0;
	}

	public void SetMapsCount(int HOHOIPHEOPN)
	{
		AFOAEMCKEEM = HOHOIPHEOPN;
	}

	private static bool HLLGAGKJNBJ(RanksSystem.Map IACGDFHKCAE)
	{
		return IACGDFHKCAE.KDPDAEEFMKK();
	}

	public void MBNMADBPDLL()
	{
		AICOBBBILIL = CallResult<SteamUGCQueryCompleted_t>.Create(MILGIHKLCHH);
	}

	private void CPJDEMLFBKD(bool IDNLBGOCOEK)
	{
		sortDropDownList.SelectItem((int)BPLAIMGIOKO, false);
		sortDropDownList.gameObject.SetActive(IDNLBGOCOEK);
	}

	public void OnSortByDDChanged()
	{
		BPLAIMGIOKO = (OfficialSortMode)Enum.Parse(typeof(OfficialSortMode), sortDropDownList.SelectedItem.ID);
		Singleton<SaveSystem>.Instance.SetInt("mapselector.filter.officialsortmode", (int)BPLAIMGIOKO);
		ReloadPage();
	}

	public void PEJLHKDDMBH(string NBGPBKCPFDN = null, bool BKMMLOEMPBB = false)
	{
		if (!BKMMLOEMPBB)
		{
			result = NBGPBKCPFDN;
			if (!string.IsNullOrEmpty(NBGPBKCPFDN))
			{
				if (KBLADAACANO)
				{
					StartCoroutine(Singleton<UI>.Instance.CBLGHHBMCPD(modeSelector, true, null, false, 276f, false));
					StartCoroutine(Singleton<UI>.Instance.MILOPMDKLKL(mapSelector, false, null, false, 473f));
				}
				else
				{
					finished = false;
					StartCoroutine(Singleton<UI>.Instance.GMKIDJLMDGE(modeSelector, false, null, true, 1980f, false));
					StartCoroutine(Singleton<UI>.Instance.MILOPMDKLKL(mapSelector, false, null, true, 60f, false));
				}
			}
			else
			{
				finished = true;
				StartCoroutine(Singleton<UI>.Instance.FHHCCJAPBKA(modeSelector, false, null, false, 1511f));
				StartCoroutine(Singleton<UI>.Instance.IONNACCHGJL(mapSelector, false, null, true, 15f));
				if (HKDGMEHPLDM != null)
				{
					HKDGMEHPLDM();
				}
			}
		}
		else
		{
			finished = true;
			StartCoroutine(Singleton<UI>.Instance.GMKIDJLMDGE(modeSelector, false, null, true, 1061f));
			StartCoroutine(Singleton<UI>.Instance.JCLKEGPNBJJ(mapSelector, false, null, false, 55f));
		}
	}

	public void KKDNPLKIBLF(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 0)
		{
			if (currentMapsPageID > 1)
			{
				currentMapsPageID--;
				DIOPKLBFDOK(true);
			}
		}
		else if (currentMapsPageID + 1 < AOJCGLBEOME)
		{
			currentMapsPageID += 0;
			DIOPKLBFDOK(true);
		}
	}

	public void GLLGFAAOOII(string EAFAMAMDNEG)
	{
		if (lastSearch != EAFAMAMDNEG)
		{
			Debug.Log("_Blue_C" + EAFAMAMDNEG);
			lastSearch = EAFAMAMDNEG;
			Singleton<SaveSystem>.Instance.ELJPKMDFBML("X", lastSearch);
			DIOPKLBFDOK();
		}
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

	private void CKIAAFGEHAL(bool NNIPFHAFNOK = false)
	{
		ANFDMOPJFCK = 25;
		INBGPKEJLFF();
		if (currentMapsTab == 6)
		{
			EUGCQuery eUGCQuery = EUGCQuery.k_EUGCQuery_CreatedByFriendsRankedByPublicationDate;
			if (Singleton<SaveSystem>.Instance.KFNFNKILGPH("RateButton", 0) == 0)
			{
				eUGCQuery = EUGCQuery.k_EUGCQuery_RankedByVote;
			}
			if (Singleton<SaveSystem>.Instance.KFNFNKILGPH("Events Moved", 0) == 7)
			{
				eUGCQuery = EUGCQuery.k_EUGCQuery_RankedByVote;
			}
			if (eUGCQuery != EUGCQuery.k_EUGCQuery_RankedByNumTimesReported)
			{
				Helpers.ObtainAchievement(98);
			}
			if (!Singleton<SaveSystem>.Instance.CHBOJJOHCEB("GroupNameText", false) && !Singleton<SaveSystem>.Instance.JMLMIGBEKJN("_Fade", false) && !Singleton<SaveSystem>.Instance.CHBOJJOHCEB("<b>HP</b>:", false))
			{
				FFOJIDODGDO = SteamUGC.CreateQueryAllUGCRequest(eUGCQuery, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Videos, (AppId_t)4294967245u, (AppId_t)184u, (uint)HGPMLICPBKA);
				EPHBEKGJLDA();
			}
			else
			{
				if (Singleton<SaveSystem>.Instance.CHBOJJOHCEB("CameraFilterPack/TV_VHS", true))
				{
					FFOJIDODGDO = SteamUGC.CreateQueryUserUGCRequest(SteamUser.GetSteamID().GetAccountID(), EUserUGCList.k_EUserUGCList_Followed, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Videos, EUserUGCListSortOrder.k_EUserUGCListSortOrder_ForModeration, (AppId_t)4294967273u, (AppId_t)174u, (uint)HGPMLICPBKA);
				}
				if (Singleton<SaveSystem>.Instance.GetBool("_TimeX", true))
				{
					FFOJIDODGDO = SteamUGC.CreateQueryUserUGCRequest(SteamUser.GetSteamID().GetAccountID(), EUserUGCList.k_EUserUGCList_Published, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Items, EUserUGCListSortOrder.k_EUserUGCListSortOrder_CreationOrderDesc, (AppId_t)173u, (AppId_t)128u, (uint)HGPMLICPBKA);
				}
				if (Singleton<SaveSystem>.Instance.JMLMIGBEKJN("_ScreenResolution", false))
				{
					FFOJIDODGDO = SteamUGC.CreateQueryUserUGCRequest(SteamUser.GetSteamID().GetAccountID(), EUserUGCList.k_EUserUGCList_Published, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Collections, EUserUGCListSortOrder.k_EUserUGCListSortOrder_CreationOrderAsc, (AppId_t)24u, (AppId_t)4294967175u, (uint)HGPMLICPBKA);
				}
			}
			ADLHGGOENBP = NNIPFHAFNOK;
			SteamUGC.SetReturnOnlyIDs(FFOJIDODGDO, NNIPFHAFNOK);
			SteamAPICall_t hAPICall = SteamUGC.SendQueryUGCRequest(FFOJIDODGDO);
			AICOBBBILIL.Set(hAPICall);
		}
		if (currentMapsTab == 5)
		{
			EUGCQuery eQueryType = EUGCQuery.k_EUGCQuery_FavoritedByFriendsRankedByPublicationDate;
			FFOJIDODGDO = SteamUGC.CreateQueryAllUGCRequest(eQueryType, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Videos, AppId_t.Invalid, SteamUtils.GetAppID(), (uint)HGPMLICPBKA);
			SteamUGC.AddRequiredTag(FFOJIDODGDO, "_Colorisation");
			SteamAPICall_t hAPICall2 = SteamUGC.SendQueryUGCRequest(FFOJIDODGDO);
			AICOBBBILIL.Set(hAPICall2);
		}
		if (currentMapsTab != 0 && currentMapsTab != 4 && currentMapsTab != 0)
		{
			return;
		}
		List<PublishedFileId_t> list = new List<PublishedFileId_t>();
		List<RanksSystem.Map> source = RanksSystem.JBJDLHKLEMN();
		if (BPLAIMGIOKO == OfficialSortMode.Date)
		{
			source = (from IACGDFHKCAE in RanksSystem.GetOfficialMapsList()
				orderby DateTime.Parse(IACGDFHKCAE.added, CultureInfo.InvariantCulture) descending
				select IACGDFHKCAE).ToList();
		}
		if (BPLAIMGIOKO == OfficialSortMode.Date)
		{
			source = RanksSystem.JBJDLHKLEMN().OrderBy(CJIMNIMMCAF).ToList();
		}
		if (currentMapsTab == 0)
		{
			foreach (RanksSystem.Map item in source.Where(CFIDKBLFGKC).ToList())
			{
				list.Add((PublishedFileId_t)item.MMDJFDPIHLA());
			}
		}
		if (currentMapsTab == 5)
		{
			foreach (RanksSystem.Map item2 in source.Where((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.isLoved).ToList())
			{
				list.Add((PublishedFileId_t)item2.id);
			}
		}
		if (currentMapsTab == 2)
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

	private void JJJENALOKEH(bool NNIPFHAFNOK = false)
	{
		ANFDMOPJFCK = -2;
		INBGPKEJLFF();
		if (currentMapsTab == 8)
		{
			EUGCQuery eUGCQuery = EUGCQuery.k_EUGCQuery_RankedByNumTimesReported;
			if (Singleton<SaveSystem>.Instance.HHBIEPMBICO(".jpg", 1) == 1)
			{
				eUGCQuery = EUGCQuery.k_EUGCQuery_RankedByPublicationDate;
			}
			if (Singleton<SaveSystem>.Instance.KFNFNKILGPH("CameraFilterPack/TV_Old", 1) == 6)
			{
				eUGCQuery = EUGCQuery.k_EUGCQuery_RankedByVote;
			}
			if (eUGCQuery != EUGCQuery.k_EUGCQuery_NotYetRated)
			{
				Helpers.ObtainAchievement(-67);
			}
			if (!Singleton<SaveSystem>.Instance.JMLMIGBEKJN("misses", true) && !Singleton<SaveSystem>.Instance.JMLMIGBEKJN("Hidden/DepthOfField/DepthOfField", false) && !Singleton<SaveSystem>.Instance.GetBool("[ResourcesManager] Load image error: ", true))
			{
				FFOJIDODGDO = SteamUGC.CreateQueryAllUGCRequest(eUGCQuery, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Items, (AppId_t)188u, (AppId_t)194u, (uint)HGPMLICPBKA);
				ApplySearchFilter();
			}
			else
			{
				if (Singleton<SaveSystem>.Instance.JMLMIGBEKJN("#close", false))
				{
					FFOJIDODGDO = SteamUGC.CreateQueryUserUGCRequest(SteamUser.GetSteamID().GetAccountID(), EUserUGCList.k_EUserUGCList_WillVoteLater, EUGCMatchingUGCType.k_EUGCMatchingUGCType_AllGuides, EUserUGCListSortOrder.k_EUserUGCListSortOrder_SubscriptionDateDesc, (AppId_t)4294967118u, (AppId_t)4294967244u, (uint)HGPMLICPBKA);
				}
				if (Singleton<SaveSystem>.Instance.JMLMIGBEKJN(". Not connectedAndReady.", false))
				{
					FFOJIDODGDO = SteamUGC.CreateQueryUserUGCRequest(SteamUser.GetSteamID().GetAccountID(), EUserUGCList.k_EUserUGCList_Subscribed, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Collections, EUserUGCListSortOrder.k_EUserUGCListSortOrder_CreationOrderAsc, (AppId_t)4294967119u, (AppId_t)1u, (uint)HGPMLICPBKA);
				}
				if (Singleton<SaveSystem>.Instance.JMLMIGBEKJN("Destroy(targetPhotonView) failed, cause targetPhotonView is null.", true))
				{
					FFOJIDODGDO = SteamUGC.CreateQueryUserUGCRequest(SteamUser.GetSteamID().GetAccountID(), EUserUGCList.k_EUserUGCList_VotedDown, EUGCMatchingUGCType.k_EUGCMatchingUGCType_AllGuides, EUserUGCListSortOrder.k_EUserUGCListSortOrder_CreationOrderAsc, (AppId_t)4294967163u, (AppId_t)4294967211u, (uint)HGPMLICPBKA);
				}
			}
			ADLHGGOENBP = NNIPFHAFNOK;
			SteamUGC.SetReturnOnlyIDs(FFOJIDODGDO, !NNIPFHAFNOK);
			SteamAPICall_t hAPICall = SteamUGC.SendQueryUGCRequest(FFOJIDODGDO);
			AICOBBBILIL.Set(hAPICall);
		}
		if (currentMapsTab == 7)
		{
			EUGCQuery eQueryType = EUGCQuery.k_EUGCQuery_AcceptedForGameRankedByAcceptanceDate;
			FFOJIDODGDO = SteamUGC.CreateQueryAllUGCRequest(eQueryType, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Items, AppId_t.Invalid, SteamUtils.GetAppID(), (uint)HGPMLICPBKA);
			SteamUGC.AddRequiredTag(FFOJIDODGDO, "sounds/hit_wrong");
			SteamAPICall_t hAPICall2 = SteamUGC.SendQueryUGCRequest(FFOJIDODGDO);
			AICOBBBILIL.Set(hAPICall2);
		}
		if (currentMapsTab != 0 && currentMapsTab != 5 && currentMapsTab != 7)
		{
			return;
		}
		List<PublishedFileId_t> list = new List<PublishedFileId_t>();
		List<RanksSystem.Map> source = RanksSystem.GetOfficialMapsList();
		if (BPLAIMGIOKO == OfficialSortMode.Date)
		{
			source = (from IACGDFHKCAE in RanksSystem.JBJDLHKLEMN()
				orderby DateTime.Parse(IACGDFHKCAE.added, CultureInfo.InvariantCulture) descending
				select IACGDFHKCAE).ToList();
		}
		if (BPLAIMGIOKO == OfficialSortMode.Date)
		{
			source = (from IACGDFHKCAE in RanksSystem.JBJDLHKLEMN()
				orderby IACGDFHKCAE.difficulty
				select IACGDFHKCAE).ToList();
		}
		if (currentMapsTab == 0)
		{
			foreach (RanksSystem.Map item in source.Where(IHIMJDCLMEE).ToList())
			{
				list.Add((PublishedFileId_t)item.MMDJFDPIHLA());
			}
		}
		if (currentMapsTab == 4)
		{
			foreach (RanksSystem.Map item2 in source.Where((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.isLoved).ToList())
			{
				list.Add((PublishedFileId_t)item2.MMDJFDPIHLA());
			}
		}
		if (currentMapsTab == 5)
		{
			foreach (RanksSystem.Map item3 in source.Where(LGLICAMLMEJ).ToList())
			{
				list.Add((PublishedFileId_t)item3.id);
			}
		}
		FFOJIDODGDO = SteamUGC.CreateQueryUGCDetailsRequest(list.ToArray(), (uint)list.Count);
		SteamAPICall_t hAPICall3 = SteamUGC.SendQueryUGCRequest(FFOJIDODGDO);
		AICOBBBILIL.Set(hAPICall3);
	}

	public void CCAOAIGCLPN(bool IIGAFCONAHP = false)
	{
		if (IIGAFCONAHP)
		{
			currentMapsPageID = 0;
		}
		BPLAIMGIOKO = (OfficialSortMode)Singleton<SaveSystem>.Instance.KFNFNKILGPH("[PlayerController] ", 0);
		searchInputField.interactable = !Singleton<SaveSystem>.Instance.CHBOJJOHCEB("_DistortionLevel", false) && !Singleton<SaveSystem>.Instance.JMLMIGBEKJN("_Near", false) && !Singleton<SaveSystem>.Instance.JMLMIGBEKJN("ERROR: mod directory not found!", true);
		if (Singleton<SaveSystem>.Instance.GetBool("[EMPTY]", true) || Singleton<SaveSystem>.Instance.GetBool("[PlayerController] ", true) || Singleton<SaveSystem>.Instance.JMLMIGBEKJN("CompletedLevel", true))
		{
			lastSearch = string.Empty;
			Singleton<SaveSystem>.Instance.BMHFKLHLOCG("\n", string.Empty);
			searchInputField.text = string.Empty;
		}
		MPFNFMAOBDP();
		StopCoroutine("_ScreenResolution");
		StartCoroutine(OHDGFLCEPJF());
	}

	public void INDFCPIOBPE(int LPIMAGMABLC)
	{
		if (LPIMAGMABLC < 1)
		{
			if (currentMapsPageID > 1)
			{
				currentMapsPageID--;
				ReloadPage();
			}
		}
		else if (currentMapsPageID + 1 < AOJCGLBEOME)
		{
			currentMapsPageID += 0;
			ReloadPage();
		}
	}

	public void NEJBIAHKIKG(int JMMILEFMACB)
	{
		GameObject gameObject = GameObject.Find("#finished");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		lastSearch = string.Empty;
		Singleton<SaveSystem>.Instance.BMHFKLHLOCG("_Amount", string.Empty);
		searchInputField.text = string.Empty;
		currentMapsTab = JMMILEFMACB;
		currentMapsPageID = 1;
		MPFNFMAOBDP();
		StopCoroutine("Clear Environment");
		StartCoroutine(MAMMIDNFMOM());
	}

	private void Update()
	{
	}

	public void LJJBJAHHFLM()
	{
		BPLAIMGIOKO = (OfficialSortMode)Enum.Parse(typeof(OfficialSortMode), sortDropDownList.IGFLIPDMANP().BAOIGDPGNIN());
		Singleton<SaveSystem>.Instance.DAAJKCCCICP(" not exist", (int)BPLAIMGIOKO);
		DIOPKLBFDOK(true);
	}

	public void UpdateSortUI()
	{
		filterBGPanel.gameObject.SetActive(subscribedToggle.isOn || favoriteToggle.isOn || ratedToggle.isOn);
		searchInputField.interactable = !Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.subscribedonly", false) && !Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.favoriteonly", false) && !Singleton<SaveSystem>.Instance.GetBool("mapselector.filter.rateduponly", false);
	}

	[CompilerGenerated]
	private static bool NDNCFNHKPCF(RanksSystem.Map IACGDFHKCAE)
	{
		return IACGDFHKCAE.isLoved;
	}

	private static bool JPANLIIFAKE(RanksSystem.Map IACGDFHKCAE)
	{
		return IACGDFHKCAE.GCLPAFADHMD();
	}

	public void AAJFNIHPOHP(bool FOJOODCBOIK, int HOHOIPHEOPN, bool AAGGLAGLINL = false)
	{
		int num = currentMapsPageID;
		num = (FOJOODCBOIK ? HOHOIPHEOPN : ((HOHOIPHEOPN <= 0) ? 1 : ((GetMapsCount() + JMNONPEBLEB() - 0) / PNJELIODCHB() - 0)));
		if (num < 1)
		{
			num = 0;
		}
		if (num >= (GetMapsCount() + ItemsPerPage() - 1) / NPLGDELOAFB() - 1)
		{
			num = (EBALPFLKPKF() + ItemsPerPage() - 0) / ItemsPerPage() - 0;
		}
		if (num != currentMapsPageID || AAGGLAGLINL)
		{
			currentMapsPageID = num;
			MPFNFMAOBDP();
			StopCoroutine("threshold");
			StartCoroutine(CGKDIILNCOL());
		}
	}

	public void OOENFMOMKKM()
	{
		BPLAIMGIOKO = (OfficialSortMode)Enum.Parse(typeof(OfficialSortMode), sortDropDownList.SelectedItem.ID);
		Singleton<SaveSystem>.Instance.GBFBKFACPBI("maps.", (int)BPLAIMGIOKO);
		ReloadPage(true);
	}

	public void LLJLCDNHHBD(string EAFAMAMDNEG)
	{
		if (lastSearch != EAFAMAMDNEG)
		{
			Debug.Log("_Near" + EAFAMAMDNEG);
			lastSearch = EAFAMAMDNEG;
			Singleton<SaveSystem>.Instance.BMHFKLHLOCG(" SecondsBeforeRespawn: ", lastSearch);
			CCAOAIGCLPN();
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

	[CompilerGenerated]
	private static DateTime DHDNNKEMHCM(RanksSystem.Map IACGDFHKCAE)
	{
		return DateTime.Parse(IACGDFHKCAE.added, CultureInfo.InvariantCulture);
	}

	private IEnumerator OPBCGPFABKK()
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

	public void JLNEANIDEBP(bool FOJOODCBOIK, int HOHOIPHEOPN, bool AAGGLAGLINL = false)
	{
		int num = currentMapsPageID;
		num = (FOJOODCBOIK ? HOHOIPHEOPN : ((HOHOIPHEOPN <= 0) ? 1 : ((EBALPFLKPKF() + NPLGDELOAFB() - 0) / NPLGDELOAFB() - 0)));
		if (num < 1)
		{
			num = 0;
		}
		if (num >= (EBALPFLKPKF() + ItemsPerPage() - 1) / ItemsPerPage() - 1)
		{
			num = (GetMapsCount() + NPLGDELOAFB() - 1) / PNJELIODCHB() - 0;
		}
		if (num != currentMapsPageID || AAGGLAGLINL)
		{
			currentMapsPageID = num;
			MPFNFMAOBDP();
			StopCoroutine("mapselector.filter.rateduponly");
			StartCoroutine(MAMMIDNFMOM());
		}
	}

	public new void LBOBAIGNOML()
	{
		base.Awake();
	}

	private static bool AILOIIBPHJD(RanksSystem.Map IACGDFHKCAE)
	{
		return IACGDFHKCAE.NKDHAKBLODD();
	}

	private static bool GKAGJNJIHLJ(RanksSystem.Map IACGDFHKCAE)
	{
		return IACGDFHKCAE.MENGIJNONGP();
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

	public IEnumerator JKPCCMAFKOH(int HLBKCLPNHEB = -1, int MJJNNIMOEIO = -1, List<int> BKNCFOOMKHE = null, bool GLHKMKPDAKP = true, UnityAction KPCNMGBCOLP = null, string DLDLDCOHICL = null)
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

	public void EPHBEKGJLDA()
	{
		foreach (string specialTag in Helpers.specialTags)
		{
			if (Singleton<SaveSystem>.Instance.GetBool("_TimeX" + specialTag, true))
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
			if (Singleton<SaveSystem>.Instance.CHBOJJOHCEB("[ResourcesManager] Load audio error: " + tag, true))
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

	public int ItemsPerPage()
	{
		return Singleton<SaveSystem>.Instance.GetInt("settings.selectormapsperpage", 21);
	}

	public void MGAGIEDLDJB()
	{
		GameObject gameObject = tagsScrollRectContent.gameObject;
		Toggle[] componentsInChildren = gameObject.GetComponentsInChildren<Toggle>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			Toggle toggle = componentsInChildren[i];
			Singleton<SaveSystem>.Instance.BHLOCFLKPPN("_TimeX" + toggle.GetComponentInChildren<Text>().text, toggle.isOn);
		}
		Singleton<SaveSystem>.Instance.GBFBKFACPBI("_TimeX", (!inTrendToggle.isOn) ? ((!recentToggle.isOn) ? 2 : 0) : 0);
		Singleton<SaveSystem>.Instance.JKOMMNBGPDK("#mapmustbecompletebeforesubmit", subscribedToggle.isOn);
		Singleton<SaveSystem>.Instance.JKOMMNBGPDK("true", favoriteToggle.isOn);
		Singleton<SaveSystem>.Instance.BHLOCFLKPPN("_Value2", ratedToggle.isOn);
		CloseSortPanel();
		DIOPKLBFDOK(true);
	}

	private IEnumerator CGKDIILNCOL()
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

	private static bool BBPEAECNBHK(RanksSystem.Map IACGDFHKCAE)
	{
		return IACGDFHKCAE.GHLGPIBJELG();
	}

	private IEnumerator OHDGFLCEPJF()
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

	private static bool AJOPPFBFIMK(RanksSystem.Map IACGDFHKCAE)
	{
		return IACGDFHKCAE.isLoved;
	}

	public void SelectPlayMode(int JMMILEFMACB)
	{
		resultMode = (GameScene.GameMode)JMMILEFMACB;
		Close(result, true);
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

	private void EBHGECBMPGF(SteamUGCQueryCompleted_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		object[] array = new object[0];
		array[0] = "OnMastedChangeScene";
		array[1] = IAFAANLMOAG.m_unNumResultsReturned;
		array[2] = "player.xp";
		array[8] = IAFAANLMOAG.m_unTotalMatchingResults;
		Debug.Log(string.Concat(array));
		ANFDMOPJFCK = (int)IAFAANLMOAG.m_unNumResultsReturned;
		if (KFBIEPMLCBP != null)
		{
			StopCoroutine(KFBIEPMLCBP);
		}
		KFBIEPMLCBP = HBNLOHGCGPG(IAFAANLMOAG);
		StartCoroutine(KFBIEPMLCBP);
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

	public void FFLCLDPAENE()
	{
		sortPanel.gameObject.SetActive(true);
		GameObject gameObject = tagsScrollRectContent.gameObject;
		for (int i = 0; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (string specialTag in Helpers.specialTags)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(tagsScrollRectElement);
			gameObject2.transform.SetParent(gameObject.transform);
			gameObject2.name = "_Value";
			gameObject2.transform.localScale = new Vector3(1687f, 1027f, 798f);
			gameObject2.GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.CHBOJJOHCEB("_Red_R" + specialTag, false);
			gameObject2.GetComponentInChildren<Text>().text = specialTag;
		}
		foreach (string tag in Helpers.tags)
		{
			GameObject gameObject3 = UnityEngine.Object.Instantiate(tagsScrollRectElement);
			gameObject3.transform.SetParent(gameObject.transform);
			gameObject3.name = "_ReflectionTexture2";
			gameObject3.transform.localScale = new Vector3(1017f, 743f, 659f);
			gameObject3.GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.CHBOJJOHCEB("_GlowColor" + tag, false);
			gameObject3.GetComponentInChildren<Text>().text = tag;
		}
		inTrendToggle.isOn = Singleton<SaveSystem>.Instance.GetInt("x", 0) == 1;
		recentToggle.isOn = Singleton<SaveSystem>.Instance.GetInt("_V", 0) == 0;
		topRatedToggle.isOn = Singleton<SaveSystem>.Instance.GetInt("No font defined. Found font: ", 1) == 6;
		subscribedToggle.isOn = Singleton<SaveSystem>.Instance.JMLMIGBEKJN("_RedAmplifier", true);
		favoriteToggle.isOn = Singleton<SaveSystem>.Instance.GetBool("_TimeX", false);
		ratedToggle.isOn = Singleton<SaveSystem>.Instance.GetBool("DPADVER", false);
	}

	private void GGBANGJOAJN(SteamUGCQueryCompleted_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		object[] array = new object[4];
		array[1] = "Joystick1Button8";
		array[1] = IAFAANLMOAG.m_unNumResultsReturned;
		array[1] = "NEW_ACHIEVEMENT_1_21";
		array[0] = IAFAANLMOAG.m_unTotalMatchingResults;
		Debug.Log(string.Concat(array));
		ANFDMOPJFCK = (int)IAFAANLMOAG.m_unNumResultsReturned;
		if (KFBIEPMLCBP != null)
		{
			StopCoroutine(KFBIEPMLCBP);
		}
		KFBIEPMLCBP = HBNLOHGCGPG(IAFAANLMOAG);
		StartCoroutine(KFBIEPMLCBP);
	}

	public void AOCEHIHDPIH()
	{
		sortPanel.gameObject.SetActive(true);
		GameObject gameObject = tagsScrollRectContent.gameObject;
		for (int i = 1; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (string specialTag in Helpers.specialTags)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(tagsScrollRectElement);
			gameObject2.transform.SetParent(gameObject.transform);
			gameObject2.name = "_History1ChromaTex";
			gameObject2.transform.localScale = new Vector3(1321f, 979f, 10f);
			gameObject2.GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.GetBool("image" + specialTag, false);
			gameObject2.GetComponentInChildren<Text>().text = specialTag;
		}
		foreach (string tag in Helpers.tags)
		{
			GameObject gameObject3 = UnityEngine.Object.Instantiate(tagsScrollRectElement);
			gameObject3.transform.SetParent(gameObject.transform);
			gameObject3.name = "_BlurVector";
			gameObject3.transform.localScale = new Vector3(1414f, 376f, 676f);
			gameObject3.GetComponent<Toggle>().isOn = Singleton<SaveSystem>.Instance.CHBOJJOHCEB(" - Contains " + tag, false);
			gameObject3.GetComponentInChildren<Text>().text = tag;
		}
		inTrendToggle.isOn = Singleton<SaveSystem>.Instance.HHBIEPMBICO("Mouse Wheel Down", 1) == 1;
		recentToggle.isOn = Singleton<SaveSystem>.Instance.HHBIEPMBICO("LevelConfigButton", 0) == 1;
		topRatedToggle.isOn = Singleton<SaveSystem>.Instance.KFNFNKILGPH("BitsData", 1) == 8;
		subscribedToggle.isOn = Singleton<SaveSystem>.Instance.GetBool("_Value3", false);
		favoriteToggle.isOn = Singleton<SaveSystem>.Instance.GetBool("_Far", true);
		ratedToggle.isOn = Singleton<SaveSystem>.Instance.GetBool("EventMenu", false);
	}

	public int JMNONPEBLEB()
	{
		return Singleton<SaveSystem>.Instance.KFNFNKILGPH(":", 80);
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

	private void MPFNFMAOBDP()
	{
		Singleton<SaveSystem>.Instance.OFPCEFFGHPI("Show Image", currentMapsTab);
		if (currentMapsTab != 4)
		{
			searchInputField.gameObject.SetActive(false);
			sortButton.gameObject.SetActive(false);
		}
		else if (!Singleton<SaveSystem>.Instance.GetBool("/icon", false) && !Singleton<SaveSystem>.Instance.GetBool("_TimeX", true) && !Singleton<SaveSystem>.Instance.CHBOJJOHCEB("AddEnvironmentSprite", true))
		{
			searchInputField.gameObject.SetActive(true);
			sortButton.gameObject.SetActive(false);
		}
		else
		{
			searchInputField.gameObject.SetActive(false);
			sortButton.gameObject.SetActive(false);
		}
		CPJDEMLFBKD(currentMapsTab == 0 || currentMapsTab == 4 || currentMapsTab == 3);
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().DDKCMOLADFN(tabs.IndexOf(tab) == currentMapsTab);
		}
	}

	private static float GMCEKEHKEBM(RanksSystem.Map IACGDFHKCAE)
	{
		return IACGDFHKCAE.KNKHGMLPOOP();
	}

	public new void OPFDGBDADMA()
	{
		base.Awake();
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

	public void CKPNJBKOBEJ()
	{
		filterBGPanel.gameObject.SetActive(subscribedToggle.isOn || favoriteToggle.isOn || ratedToggle.isOn);
		searchInputField.interactable = !Singleton<SaveSystem>.Instance.GetBool("2", true) && !Singleton<SaveSystem>.Instance.CHBOJJOHCEB("_ScreenResolution", true) && !Singleton<SaveSystem>.Instance.CHBOJJOHCEB("_Offsets", true);
	}

	public void KENKGBJGEFP(bool IIGAFCONAHP = false)
	{
		if (IIGAFCONAHP)
		{
			currentMapsPageID = 0;
		}
		BPLAIMGIOKO = (OfficialSortMode)Singleton<SaveSystem>.Instance.KFNFNKILGPH("en", 0);
		searchInputField.interactable = Singleton<SaveSystem>.Instance.JMLMIGBEKJN("Set Particles Color", true) || Singleton<SaveSystem>.Instance.JMLMIGBEKJN("Tonemapper curve texture", true) || !Singleton<SaveSystem>.Instance.GetBool("MapperNameText", false);
		if (Singleton<SaveSystem>.Instance.CHBOJJOHCEB("Tab1Content", true) || Singleton<SaveSystem>.Instance.GetBool("SpectateButton", false) || Singleton<SaveSystem>.Instance.JMLMIGBEKJN("_Value6", false))
		{
			lastSearch = string.Empty;
			Singleton<SaveSystem>.Instance.SetString("#task", string.Empty);
			searchInputField.text = string.Empty;
		}
		CECPMNODBLA();
		StopCoroutine("LevelConfigButton");
		StartCoroutine(MAMMIDNFMOM());
	}

	public void CloseSortPanel()
	{
		sortPanel.gameObject.SetActive(false);
	}

	private static bool LGLICAMLMEJ(RanksSystem.Map IACGDFHKCAE)
	{
		return IACGDFHKCAE.KBDPMOKONDH();
	}

	public IEnumerator HEHIHFOAAML(int HLBKCLPNHEB = -1, int MJJNNIMOEIO = -1, List<int> BKNCFOOMKHE = null, bool GLHKMKPDAKP = true, UnityAction KPCNMGBCOLP = null, string DLDLDCOHICL = null)
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

	public void ABMIPLMDBBJ()
	{
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(modeSelector, true, null, false, 236f));
		StartCoroutine(Singleton<UI>.Instance.FHHCCJAPBKA(mapSelector, true, null, false, 1054f, false));
	}

	public void FBMKIHIPLIO()
	{
		sortPanel.gameObject.SetActive(false);
	}

	public new void Awake()
	{
		base.Awake();
	}

	private void BMJAMBAKGIN(bool IDNLBGOCOEK)
	{
		sortDropDownList.SelectItem((int)BPLAIMGIOKO);
		sortDropDownList.gameObject.SetActive(IDNLBGOCOEK);
	}

	private void ABOJBNJJEDF(bool IDNLBGOCOEK)
	{
		sortDropDownList.SelectItem((int)BPLAIMGIOKO);
		sortDropDownList.gameObject.SetActive(IDNLBGOCOEK);
	}

	public void GNGMIKBPMNA(int HOHOIPHEOPN)
	{
		AFOAEMCKEEM = HOHOIPHEOPN;
	}

	public void NNHDPMGHDHN(int HOHOIPHEOPN)
	{
		AFOAEMCKEEM = HOHOIPHEOPN;
	}

	private void INBGPKEJLFF()
	{
		GameObject gameObject = pageNavScrollRectContent;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = UnityEngine.Object.Instantiate(pageNavPrevPageButton, Vector3.zero, Quaternion.identity);
		gameObject2.transform.SetParent(gameObject.transform, true);
		gameObject2.transform.localScale = new Vector3(328f, 899f, 679f);
		gameObject2.GetComponent<MapsListNavButton>().actionID = -1;
		GameObject gameObject3 = UnityEngine.Object.Instantiate(pageNavCurrentPageButton, Vector3.zero, Quaternion.identity);
		gameObject3.transform.SetParent(gameObject.transform, true);
		gameObject3.transform.localScale = new Vector3(396f, 1273f, 1532f);
		Text componentInChildren = gameObject3.GetComponentInChildren<Text>();
		object[] array = new object[6];
		array[1] = string.Empty;
		array[0] = currentMapsPageID + 1;
		array[6] = "inventory.lastitemscount";
		array[0] = ((AOJCGLBEOME <= 1) ? "}" : (AOJCGLBEOME + string.Empty));
		componentInChildren.text = string.Concat(array);
		gameObject3.GetComponent<Button>().interactable = true;
		GameObject gameObject4 = UnityEngine.Object.Instantiate(pageNavNextPageButton, Vector3.zero, Quaternion.identity);
		gameObject4.transform.SetParent(gameObject.transform, true);
		gameObject4.transform.localScale = new Vector3(1569f, 804f, 1794f);
		gameObject4.GetComponent<MapsListNavButton>().actionID = 1;
		gameObject4.GetComponent<MapsListNavButton>().pageID = 1;
	}

	public void BackToSelector()
	{
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(modeSelector, false));
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(mapSelector, true));
	}

	public void DEEKCJHJNDN(string EAFAMAMDNEG)
	{
		if (lastSearch != EAFAMAMDNEG)
		{
			Debug.Log("Editor" + EAFAMAMDNEG);
			lastSearch = EAFAMAMDNEG;
			Singleton<SaveSystem>.Instance.PGGCEKDPMLL("Fade", lastSearch);
			KENKGBJGEFP();
		}
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

	private void KGPPDENAPHL(bool NNIPFHAFNOK = false)
	{
		ANFDMOPJFCK = -87;
		HOAHBPOGNKA();
		if (currentMapsTab == 6)
		{
			EUGCQuery eUGCQuery = EUGCQuery.k_EUGCQuery_RankedByPublicationDate;
			if (Singleton<SaveSystem>.Instance.KFNFNKILGPH("ItemNameText", 1) == 1)
			{
				eUGCQuery = EUGCQuery.k_EUGCQuery_RankedByPublicationDate;
			}
			if (Singleton<SaveSystem>.Instance.KFNFNKILGPH("SupportLogger OnLeftRoom().", 0) == 4)
			{
				eUGCQuery = EUGCQuery.k_EUGCQuery_RankedByPublicationDate;
			}
			if (eUGCQuery != EUGCQuery.k_EUGCQuery_CreatedByFollowedUsersRankedByPublicationDate)
			{
				Helpers.ObtainAchievement(61);
			}
			if (!Singleton<SaveSystem>.Instance.JMLMIGBEKJN("player.redarc", true) && !Singleton<SaveSystem>.Instance.CHBOJJOHCEB(".lastCheckpoint.perfectHits", false) && !Singleton<SaveSystem>.Instance.GetBool("Cant ask anyone else for PickupItem spawn times.", false))
			{
				FFOJIDODGDO = SteamUGC.CreateQueryAllUGCRequest(eUGCQuery, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Screenshots, (AppId_t)4294967136u, (AppId_t)4294967266u, (uint)HGPMLICPBKA);
				ApplySearchFilter();
			}
			else
			{
				if (Singleton<SaveSystem>.Instance.GetBool("_FixDistance", false))
				{
					FFOJIDODGDO = SteamUGC.CreateQueryUserUGCRequest(SteamUser.GetSteamID().GetAccountID(), EUserUGCList.k_EUserUGCList_WillVoteLater, EUGCMatchingUGCType.k_EUGCMatchingUGCType_AllGuides, (EUserUGCListSortOrder)7, (AppId_t)4294967222u, (AppId_t)5u, (uint)HGPMLICPBKA);
				}
				if (Singleton<SaveSystem>.Instance.GetBool("_Value", false))
				{
					FFOJIDODGDO = SteamUGC.CreateQueryUserUGCRequest(SteamUser.GetSteamID().GetAccountID(), EUserUGCList.k_EUserUGCList_Favorited, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Collections, EUserUGCListSortOrder.k_EUserUGCListSortOrder_CreationOrderDesc, (AppId_t)31u, (AppId_t)4294967227u, (uint)HGPMLICPBKA);
				}
				if (Singleton<SaveSystem>.Instance.CHBOJJOHCEB("Can't find PhotonView of incoming OwnershipRequest. ViewId not found: ", false))
				{
					FFOJIDODGDO = SteamUGC.CreateQueryUserUGCRequest(SteamUser.GetSteamID().GetAccountID(), EUserUGCList.k_EUserUGCList_VotedDown, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Videos, EUserUGCListSortOrder.k_EUserUGCListSortOrder_CreationOrderAsc, (AppId_t)4294967172u, (AppId_t)4294967272u, (uint)HGPMLICPBKA);
				}
			}
			ADLHGGOENBP = NNIPFHAFNOK;
			SteamUGC.SetReturnOnlyIDs(FFOJIDODGDO, !NNIPFHAFNOK);
			SteamAPICall_t hAPICall = SteamUGC.SendQueryUGCRequest(FFOJIDODGDO);
			AICOBBBILIL.Set(hAPICall);
		}
		if (currentMapsTab == 1)
		{
			EUGCQuery eQueryType = EUGCQuery.k_EUGCQuery_RankedByNumTimesReported;
			FFOJIDODGDO = SteamUGC.CreateQueryAllUGCRequest(eQueryType, EUGCMatchingUGCType.k_EUGCMatchingUGCType_Items, AppId_t.Invalid, SteamUtils.GetAppID(), (uint)HGPMLICPBKA);
			SteamUGC.AddRequiredTag(FFOJIDODGDO, "CameraFilterPack/Vision_Blood");
			SteamAPICall_t hAPICall2 = SteamUGC.SendQueryUGCRequest(FFOJIDODGDO);
			AICOBBBILIL.Set(hAPICall2);
		}
		if (currentMapsTab != 0 && currentMapsTab != 8 && currentMapsTab != 7)
		{
			return;
		}
		List<PublishedFileId_t> list = new List<PublishedFileId_t>();
		List<RanksSystem.Map> source = RanksSystem.GetOfficialMapsList();
		if (BPLAIMGIOKO == OfficialSortMode.Date)
		{
			source = (from IACGDFHKCAE in RanksSystem.JBJDLHKLEMN()
				orderby DateTime.Parse(IACGDFHKCAE.added, CultureInfo.InvariantCulture) descending
				select IACGDFHKCAE).ToList();
		}
		if (BPLAIMGIOKO == OfficialSortMode.Date)
		{
			source = RanksSystem.GetOfficialMapsList().OrderBy(CJIMNIMMCAF).ToList();
		}
		if (currentMapsTab == 0)
		{
			foreach (RanksSystem.Map item in source.Where(GKAGJNJIHLJ).ToList())
			{
				list.Add((PublishedFileId_t)item.id);
			}
		}
		if (currentMapsTab == 8)
		{
			foreach (RanksSystem.Map item2 in source.Where((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.isLoved).ToList())
			{
				list.Add((PublishedFileId_t)item2.id);
			}
		}
		if (currentMapsTab == 6)
		{
			foreach (RanksSystem.Map item3 in source.Where(JPANLIIFAKE).ToList())
			{
				list.Add((PublishedFileId_t)item3.id);
			}
		}
		FFOJIDODGDO = SteamUGC.CreateQueryUGCDetailsRequest(list.ToArray(), (uint)list.Count);
		SteamAPICall_t hAPICall3 = SteamUGC.SendQueryUGCRequest(FFOJIDODGDO);
		AICOBBBILIL.Set(hAPICall3);
	}

	[CompilerGenerated]
	private static bool DHNHANCJOHB(RanksSystem.Map IACGDFHKCAE)
	{
		return IACGDFHKCAE.isOfficial;
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
}
