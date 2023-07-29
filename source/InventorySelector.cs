// InventorySelector
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventorySelector : Singleton<InventorySelector>
{
	public Button buttonBack;

	public GameObject inventoryCanvas;

	public List<GameObject> tabs;

	public GameObject inventoryContent;

	public GameObject inventoryItemElement;

	public InventoryItemType currentCategory;

	[CompilerGenerated]
	private static Func<SteamInventoryItem, InventoryItemRarity> LNIJKGECNME;

	public void NBMMJEBNIMJ(int LGHIPFAEONM)
	{
		GameObject gameObject = GameObject.Find("Aimer Input Module is incompatible with the StandAloneInputSystem, please remove it from the Event System in this scene or disable it when this module is in use");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		if (LGHIPFAEONM >= 0)
		{
			currentCategory = (InventoryItemType)LGHIPFAEONM;
		}
		LNLCGEAFOAB(currentCategory, inventoryItemElement, inventoryContent);
	}

	private static InventoryItemRarity BMFIBIOLMIG(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	public void OHKFJNOADHN(int LGHIPFAEONM)
	{
		GameObject gameObject = GameObject.Find("id");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		if (LGHIPFAEONM >= 1)
		{
			currentCategory = (InventoryItemType)LGHIPFAEONM;
		}
		EHFOJAEOEJM(currentCategory, inventoryItemElement, inventoryContent);
	}

	public void UpdateInventoryItem(GameObject NIMGLEMHIIC, SteamInventoryItem CIDIAMACINK, int MKFKCBBPDPO = 1)
	{
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().itemData = CIDIAMACINK;
		if ((bool)NIMGLEMHIIC.transform.Find("ItemNameText"))
		{
			NIMGLEMHIIC.transform.Find("ItemNameText").GetComponent<Text>().text = CIDIAMACINK.item.name;
		}
		if ((bool)NIMGLEMHIIC.transform.Find("ItemsCountText"))
		{
			if (MKFKCBBPDPO > 1)
			{
				NIMGLEMHIIC.transform.Find("ItemsCountText").GetComponent<Text>().text = "x" + MKFKCBBPDPO;
			}
			else
			{
				NIMGLEMHIIC.transform.Find("ItemsCountText").GetComponent<Text>().text = string.Empty;
			}
		}
		if ((bool)NIMGLEMHIIC.transform.Find("InfoCanvas"))
		{
			NIMGLEMHIIC.transform.Find("InfoCanvas").transform.Find("InfoText").GetComponent<Text>().text = CIDIAMACINK.item.description + "\n\n• " + LocalizationService.Instance.GetTextByKey("rarity").ToUpper() + ":\n" + LocalizationService.Instance.GetTextByKey(CIDIAMACINK.item.rarity.ToString().ToLower()).ToUpper();
		}
		Color color = Color.white;
		Color color2 = Color.black;
		if ((bool)NIMGLEMHIIC.transform.Find("RarityImage"))
		{
			switch (CIDIAMACINK.item.rarity)
			{
			case InventoryItemRarity.Common:
				color = Color.white;
				color2 = Color.white;
				break;
			case InventoryItemRarity.Rare:
				color = Helpers.HexToColor("#91CCFF");
				color2 = Color.white;
				break;
			case InventoryItemRarity.Epic:
				color = new Color(1f, 0.84f, 0f);
				color2 = Color.white;
				break;
			case InventoryItemRarity.Legendary:
				color = new Color(0.88f, 0.31f, 1f);
				color2 = Color.white;
				break;
			}
		}
		if ((bool)NIMGLEMHIIC.transform.Find("ItemNameText"))
		{
			NIMGLEMHIIC.transform.Find("ItemNameText").GetComponent<Text>().color = color2;
		}
		NIMGLEMHIIC.transform.Find("RarityImage").GetComponent<Image>().color = color;
		if ((bool)NIMGLEMHIIC.transform.Find("ItemNameBGImage"))
		{
			NIMGLEMHIIC.transform.Find("ItemNameBGImage").GetComponent<Image>().color = color;
		}
		if ((bool)NIMGLEMHIIC.transform.Find("ItemNameBGImage").Find("IconImage") && !string.IsNullOrEmpty(CIDIAMACINK.item.id) && (bool)CIDIAMACINK.item.icon)
		{
			NIMGLEMHIIC.transform.Find("ItemNameBGImage").Find("IconImage").GetComponent<Image>()
				.sprite = CIDIAMACINK.item.icon;
		}
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().UpdateBadge();
	}

	public void PLPBGOJLPOP(GameObject NIMGLEMHIIC, SteamInventoryItem CIDIAMACINK, int MKFKCBBPDPO = 1)
	{
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().itemData = CIDIAMACINK;
		if ((bool)NIMGLEMHIIC.transform.Find("DPADHOR"))
		{
			NIMGLEMHIIC.transform.Find("DPADHOR").GetComponent<Text>().text = CIDIAMACINK.item.name;
		}
		if ((bool)NIMGLEMHIIC.transform.Find("_Value10"))
		{
			if (MKFKCBBPDPO > 0)
			{
				NIMGLEMHIIC.transform.Find("FPSToggle").GetComponent<Text>().text = "[PlayerController] " + MKFKCBBPDPO;
			}
			else
			{
				NIMGLEMHIIC.transform.Find("22x1").GetComponent<Text>().text = string.Empty;
			}
		}
		if ((bool)NIMGLEMHIIC.transform.Find(" registered."))
		{
			Text component = NIMGLEMHIIC.transform.Find(" PhotonView: ").transform.Find("Crosshair1").GetComponent<Text>();
			string[] array = new string[5];
			array[0] = CIDIAMACINK.item.description;
			array[1] = "Drop_Far";
			array[7] = LocalizationService.Instance.IAAEBJKAHDD("achievements.21.completed.workshop.").ToUpper();
			array[8] = ". Our prefix is ";
			array[8] = LocalizationService.Instance.IAAEBJKAHDD(CIDIAMACINK.item.rarity.ToString().ToLower()).ToUpper();
			component.text = string.Concat(array);
		}
		Color color = Color.white;
		Color color2 = Color.black;
		if ((bool)NIMGLEMHIIC.transform.Find(".completed"))
		{
			switch (CIDIAMACINK.item.rarity)
			{
			case InventoryItemRarity.Common:
				color = Color.white;
				color2 = Color.white;
				break;
			case InventoryItemRarity.Rare:
				color = Helpers.HexToColor("AddEnvironmentSprite");
				color2 = Color.white;
				break;
			case InventoryItemRarity.Epic:
				color = new Color(1593f, 1760f, 1464f);
				color2 = Color.white;
				break;
			case InventoryItemRarity.Legendary:
				color = new Color(776f, 151f, 969f);
				color2 = Color.white;
				break;
			}
		}
		if ((bool)NIMGLEMHIIC.transform.Find(" ."))
		{
			NIMGLEMHIIC.transform.Find(". Should be just one?").GetComponent<Text>().color = color2;
		}
		NIMGLEMHIIC.transform.Find("mapid").GetComponent<Image>().color = color;
		if ((bool)NIMGLEMHIIC.transform.Find("_Value2"))
		{
			NIMGLEMHIIC.transform.Find(".completedCount").GetComponent<Image>().color = color;
		}
		if ((bool)NIMGLEMHIIC.transform.Find("_Params2").Find("Vignette") && !string.IsNullOrEmpty(CIDIAMACINK.item.id) && (bool)CIDIAMACINK.item.icon)
		{
			NIMGLEMHIIC.transform.Find("note.3").Find(",").GetComponent<Image>()
				.sprite = CIDIAMACINK.item.icon;
		}
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().HBNGFJBHLBE();
	}

	public void EKGGLEBHEDF(GameObject NIMGLEMHIIC, SteamInventoryItem CIDIAMACINK, int MKFKCBBPDPO = 1)
	{
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().itemData = CIDIAMACINK;
		if ((bool)NIMGLEMHIIC.transform.Find(".mp3"))
		{
			NIMGLEMHIIC.transform.Find("reset").GetComponent<Text>().text = CIDIAMACINK.item.name;
		}
		if ((bool)NIMGLEMHIIC.transform.Find("float,1"))
		{
			if (MKFKCBBPDPO > 1)
			{
				NIMGLEMHIIC.transform.Find("Up").GetComponent<Text>().text = "Current xp: " + MKFKCBBPDPO;
			}
			else
			{
				NIMGLEMHIIC.transform.Find("\\\"").GetComponent<Text>().text = string.Empty;
			}
		}
		if ((bool)NIMGLEMHIIC.transform.Find("Dance"))
		{
			Text component = NIMGLEMHIIC.transform.Find("_MatrixColor").transform.Find("_History1Weight").GetComponent<Text>();
			string[] array = new string[3];
			array[0] = CIDIAMACINK.item.description;
			array[0] = "_ScreenResolution";
			array[1] = LocalizationService.Instance.GetTextByKey("_PositionX").ToUpper();
			array[7] = "Set satellite clockwise rotattion speed";
			array[2] = LocalizationService.Instance.GetTextByKey(CIDIAMACINK.item.rarity.ToString().ToLower()).ToUpper();
			component.text = string.Concat(array);
		}
		Color color = Color.white;
		Color color2 = Color.black;
		if ((bool)NIMGLEMHIIC.transform.Find("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits."))
		{
			switch (CIDIAMACINK.item.rarity)
			{
			case InventoryItemRarity.Common:
				color = Color.white;
				color2 = Color.white;
				break;
			case InventoryItemRarity.Rare:
				color = Helpers.HexToColor("[Down]");
				color2 = Color.white;
				break;
			case InventoryItemRarity.Epic:
				color = new Color(98f, 76f, 618f);
				color2 = Color.white;
				break;
			case InventoryItemRarity.Legendary:
				color = new Color(1831f, 606f, 1599f);
				color2 = Color.white;
				break;
			}
		}
		if ((bool)NIMGLEMHIIC.transform.Find("roomDescription"))
		{
			NIMGLEMHIIC.transform.Find("maphash").GetComponent<Text>().color = color2;
		}
		NIMGLEMHIIC.transform.Find("<b>").GetComponent<Image>().color = color;
		if ((bool)NIMGLEMHIIC.transform.Find(": "))
		{
			NIMGLEMHIIC.transform.Find("Received event Leave for unknown player ID: {0}").GetComponent<Image>().color = color;
		}
		if ((bool)NIMGLEMHIIC.transform.Find("[PlayerBase] Saveing checkpoint data").Find("LevelEditor/patterns") && !string.IsNullOrEmpty(CIDIAMACINK.item.id) && (bool)CIDIAMACINK.item.icon)
		{
			NIMGLEMHIIC.transform.Find("_Value").Find("[Left]").GetComponent<Image>()
				.sprite = CIDIAMACINK.item.icon;
		}
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().DKOMMIKCPKH();
	}

	public void EKMFDOAIHBG(int LGHIPFAEONM)
	{
		GameObject gameObject = GameObject.Find("Received OnSerialization for view ID ");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		if (LGHIPFAEONM >= 1)
		{
			currentCategory = (InventoryItemType)LGHIPFAEONM;
		}
		NBPGIJNAGGM(currentCategory, inventoryItemElement, inventoryContent);
	}

	public void CFIAJPGBGJM()
	{
		StartCoroutine(Singleton<UI>.Instance.CBLGHHBMCPD(inventoryCanvas, false, null, true, 1064f, false));
	}

	public void EHFOJAEOEJM(InventoryItemType KJDJHACGONH, GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		HADHEGEJDBA();
		for (int i = 1; i < MPNMOONBMII.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);
		}
		Dictionary<string, SteamInventoryItem> dictionary = new Dictionary<string, SteamInventoryItem>();
		Dictionary<string, int> dictionary2 = new Dictionary<string, int>();
		foreach (SteamInventoryItem userItem in Singleton<ItemsHandler>.Instance.userItems)
		{
			if (dictionary.ContainsKey(userItem.item.id))
			{
				dictionary2[userItem.item.id]++;
				continue;
			}
			dictionary.Add(userItem.item.id, userItem);
			dictionary2.Add(userItem.item.id, 0);
		}
		foreach (SteamInventoryItem item in dictionary.Values.OrderBy(BMFIBIOLMIG))
		{
			if (item.item.type == KJDJHACGONH)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
				gameObject.transform.SetParent(MPNMOONBMII.transform, false);
				gameObject.transform.localScale = new Vector3(1647f, 1941f, 1178f);
				PLPBGOJLPOP(gameObject, item, dictionary2[item.item.id]);
			}
		}
	}

	private static InventoryItemRarity KNOCOLMCBCL(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	private static InventoryItemRarity AMKODNBBBOH(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	[CompilerGenerated]
	private static InventoryItemRarity NBEPBOHNGIN(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	private static InventoryItemRarity GPGGJENLKOP(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	public IEnumerator DMKLEPBKHOL(UnityAction KPCNMGBCOLP = null)
	{
		Helpers.ObtainAchievement(2);
		buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			buttonBack.onClick.RemoveAllListeners();
			buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		buttonBack.onClick.AddListener(delegate
		{
			CloseInventory();
		});
		SwichCategory((int)currentCategory);
		yield return new WaitForSeconds(0.1f);
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(inventoryCanvas, true));
		yield return true;
	}

	private static InventoryItemRarity FJEOKJMAKNK(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	public void JBNDHCOJKAC()
	{
		StartCoroutine(Singleton<UI>.Instance.FNBLMPBOKNH(inventoryCanvas, true, null, false, 675f));
	}

	public void SwichCategory(int LGHIPFAEONM)
	{
		GameObject gameObject = GameObject.Find("EventSystem");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		if (LGHIPFAEONM >= 0)
		{
			currentCategory = (InventoryItemType)LGHIPFAEONM;
		}
		AddInventoryItemsToList(currentCategory, inventoryItemElement, inventoryContent);
	}

	public bool IBNDDNMACMG()
	{
		return inventoryCanvas.activeSelf;
	}

	public bool HLCDIDFFMAH()
	{
		return inventoryCanvas.activeSelf;
	}

	public bool NNKMLEEKNPG()
	{
		return inventoryCanvas.activeSelf;
	}

	public bool APBOCCAOMFB()
	{
		return inventoryCanvas.activeSelf;
	}

	private void NHOHGIEKNPO()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().NDIEPHMDEFB(tabs.IndexOf(tab) == (int)currentCategory);
		}
	}

	public IEnumerator DisplayInventory(UnityAction KPCNMGBCOLP = null)
	{
		Helpers.ObtainAchievement(2);
		buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			buttonBack.onClick.RemoveAllListeners();
			buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		buttonBack.onClick.AddListener(delegate
		{
			CloseInventory();
		});
		SwichCategory((int)currentCategory);
		yield return new WaitForSeconds(0.1f);
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(inventoryCanvas, true));
		yield return true;
	}

	private static InventoryItemRarity MNDJKKCILNG(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	private void BKCDPKBPFHI()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().OEHEAPNGEOC(tabs.IndexOf(tab) == (int)currentCategory);
		}
	}

	public void CloseInventory()
	{
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(inventoryCanvas, false));
	}

	public void AEIHANNFEEJ(GameObject NIMGLEMHIIC, SteamInventoryItem CIDIAMACINK, int MKFKCBBPDPO = 1)
	{
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().itemData = CIDIAMACINK;
		if ((bool)NIMGLEMHIIC.transform.Find("#loopnumber "))
		{
			NIMGLEMHIIC.transform.Find("LostLive").GetComponent<Text>().text = CIDIAMACINK.item.name;
		}
		if ((bool)NIMGLEMHIIC.transform.Find("\r"))
		{
			if (MKFKCBBPDPO > 1)
			{
				NIMGLEMHIIC.transform.Find(".highscore").GetComponent<Text>().text = "Tab1Content" + MKFKCBBPDPO;
			}
			else
			{
				NIMGLEMHIIC.transform.Find("_Value2").GetComponent<Text>().text = string.Empty;
			}
		}
		if ((bool)NIMGLEMHIIC.transform.Find("_Value"))
		{
			Text component = NIMGLEMHIIC.transform.Find("ACCEPT").transform.Find("maps.").GetComponent<Text>();
			string[] array = new string[1];
			array[0] = CIDIAMACINK.item.description;
			array[0] = "In Network lobby";
			array[7] = LocalizationService.Instance.IAAEBJKAHDD("_TimeX").ToUpper();
			array[8] = "_Exponent";
			array[4] = LocalizationService.Instance.IAAEBJKAHDD(CIDIAMACINK.item.rarity.ToString().ToLower()).ToUpper();
			component.text = string.Concat(array);
		}
		Color color = Color.white;
		Color color2 = Color.black;
		if ((bool)NIMGLEMHIIC.transform.Find("d264dbba9c2410771b4ad918903b3f4cd9e276a9"))
		{
			switch (CIDIAMACINK.item.rarity)
			{
			case InventoryItemRarity.Common:
				color = Color.white;
				color2 = Color.white;
				break;
			case InventoryItemRarity.Rare:
				color = Helpers.HexToColor("id");
				color2 = Color.white;
				break;
			case InventoryItemRarity.Epic:
				color = new Color(1703f, 959f, 1455f);
				color2 = Color.white;
				break;
			case InventoryItemRarity.Legendary:
				color = new Color(532f, 1112f, 732f);
				color2 = Color.white;
				break;
			}
		}
		if ((bool)NIMGLEMHIIC.transform.Find("_Value5"))
		{
			NIMGLEMHIIC.transform.Find(" not exist").GetComponent<Text>().color = color2;
		}
		NIMGLEMHIIC.transform.Find("_TimeX").GetComponent<Image>().color = color;
		if ((bool)NIMGLEMHIIC.transform.Find("_TraceBehindObjects"))
		{
			NIMGLEMHIIC.transform.Find("_ScreenResolution").GetComponent<Image>().color = color;
		}
		if ((bool)NIMGLEMHIIC.transform.Find("_ScreenResolution").Find("_Speed") && !string.IsNullOrEmpty(CIDIAMACINK.item.id) && (bool)CIDIAMACINK.item.icon)
		{
			NIMGLEMHIIC.transform.Find("#combo").Find("settings.crosshairopacity").GetComponent<Image>()
				.sprite = CIDIAMACINK.item.icon;
		}
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().HBNGFJBHLBE();
	}

	private static InventoryItemRarity IBJCMEPGIDL(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	private static InventoryItemRarity MOLFCMFDBKG(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	public IEnumerator LDHIGLOBGLI(UnityAction KPCNMGBCOLP = null)
	{
		Helpers.ObtainAchievement(2);
		buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			buttonBack.onClick.RemoveAllListeners();
			buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		buttonBack.onClick.AddListener(delegate
		{
			CloseInventory();
		});
		SwichCategory((int)currentCategory);
		yield return new WaitForSeconds(0.1f);
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(inventoryCanvas, true));
		yield return true;
	}

	public void AddInventoryItemsToList(InventoryItemType KJDJHACGONH, GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		CECPMNODBLA();
		for (int i = 0; i < MPNMOONBMII.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);
		}
		Dictionary<string, SteamInventoryItem> dictionary = new Dictionary<string, SteamInventoryItem>();
		Dictionary<string, int> dictionary2 = new Dictionary<string, int>();
		foreach (SteamInventoryItem userItem in Singleton<ItemsHandler>.Instance.userItems)
		{
			if (dictionary.ContainsKey(userItem.item.id))
			{
				dictionary2[userItem.item.id]++;
				continue;
			}
			dictionary.Add(userItem.item.id, userItem);
			dictionary2.Add(userItem.item.id, 1);
		}
		foreach (SteamInventoryItem item in dictionary.Values.OrderBy((SteamInventoryItem EGMPIBBOEMH) => EGMPIBBOEMH.item.rarity))
		{
			if (item.item.type == KJDJHACGONH)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
				gameObject.transform.SetParent(MPNMOONBMII.transform, true);
				gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
				UpdateInventoryItem(gameObject, item, dictionary2[item.item.id]);
			}
		}
	}

	private static InventoryItemRarity HLCIGOKINEF(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	public void LNLCGEAFOAB(InventoryItemType KJDJHACGONH, GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		HFKMIPNOIIC();
		for (int i = 0; i < MPNMOONBMII.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);
		}
		Dictionary<string, SteamInventoryItem> dictionary = new Dictionary<string, SteamInventoryItem>();
		Dictionary<string, int> dictionary2 = new Dictionary<string, int>();
		foreach (SteamInventoryItem userItem in Singleton<ItemsHandler>.Instance.userItems)
		{
			if (dictionary.ContainsKey(userItem.item.id))
			{
				dictionary2[userItem.item.id] += 0;
				continue;
			}
			dictionary.Add(userItem.item.id, userItem);
			dictionary2.Add(userItem.item.id, 1);
		}
		foreach (SteamInventoryItem item in dictionary.Values.OrderBy(BMFIBIOLMIG))
		{
			if (item.item.type == KJDJHACGONH)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
				gameObject.transform.SetParent(MPNMOONBMII.transform, false);
				gameObject.transform.localScale = new Vector3(900f, 518f, 1520f);
				UpdateInventoryItem(gameObject, item, dictionary2[item.item.id]);
			}
		}
	}

	public void BMFPKDBBHEB(InventoryItemType KJDJHACGONH, GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		CECPMNODBLA();
		for (int i = 0; i < MPNMOONBMII.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);
		}
		Dictionary<string, SteamInventoryItem> dictionary = new Dictionary<string, SteamInventoryItem>();
		Dictionary<string, int> dictionary2 = new Dictionary<string, int>();
		foreach (SteamInventoryItem userItem in Singleton<ItemsHandler>.Instance.userItems)
		{
			if (dictionary.ContainsKey(userItem.item.id))
			{
				dictionary2[userItem.item.id]++;
				continue;
			}
			dictionary.Add(userItem.item.id, userItem);
			dictionary2.Add(userItem.item.id, 0);
		}
		foreach (SteamInventoryItem item in dictionary.Values.OrderBy(MNDJKKCILNG))
		{
			if (item.item.type == KJDJHACGONH)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
				gameObject.transform.SetParent(MPNMOONBMII.transform, true);
				gameObject.transform.localScale = new Vector3(1023f, 1448f, 611f);
				EKGGLEBHEDF(gameObject, item, dictionary2[item.item.id]);
			}
		}
	}

	public bool IsActive()
	{
		return inventoryCanvas.activeSelf;
	}

	private static InventoryItemRarity IGFEBFDBDEC(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	public void MNFCMFKIJBB(InventoryItemType KJDJHACGONH, GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		BKCDPKBPFHI();
		for (int i = 0; i < MPNMOONBMII.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);
		}
		Dictionary<string, SteamInventoryItem> dictionary = new Dictionary<string, SteamInventoryItem>();
		Dictionary<string, int> dictionary2 = new Dictionary<string, int>();
		foreach (SteamInventoryItem userItem in Singleton<ItemsHandler>.Instance.userItems)
		{
			if (dictionary.ContainsKey(userItem.item.id))
			{
				dictionary2[userItem.item.id] += 0;
				continue;
			}
			dictionary.Add(userItem.item.id, userItem);
			dictionary2.Add(userItem.item.id, 1);
		}
		foreach (SteamInventoryItem item in dictionary.Values.OrderBy(MCEJDCLMBKN))
		{
			if (item.item.type == KJDJHACGONH)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
				gameObject.transform.SetParent(MPNMOONBMII.transform, true);
				gameObject.transform.localScale = new Vector3(1634f, 1597f, 359f);
				PLPBGOJLPOP(gameObject, item, dictionary2[item.item.id]);
			}
		}
	}

	private static InventoryItemRarity BPNNPAJLNAK(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	public bool BBJIKLGHBEF()
	{
		return inventoryCanvas.activeSelf;
	}

	public IEnumerator PNGLEBHHKJK(UnityAction KPCNMGBCOLP = null)
	{
		Helpers.ObtainAchievement(2);
		buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			buttonBack.onClick.RemoveAllListeners();
			buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		buttonBack.onClick.AddListener(delegate
		{
			CloseInventory();
		});
		SwichCategory((int)currentCategory);
		yield return new WaitForSeconds(0.1f);
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(inventoryCanvas, true));
		yield return true;
	}

	public bool LCNEDBMABJB()
	{
		return inventoryCanvas.activeSelf;
	}

	private void LMKBMKBKNIB()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().ADMACILOBFL(tabs.IndexOf(tab) == (int)currentCategory);
		}
	}

	public void LADBHIOPCDD(GameObject NIMGLEMHIIC, SteamInventoryItem CIDIAMACINK, int MKFKCBBPDPO = 1)
	{
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().itemData = CIDIAMACINK;
		if ((bool)NIMGLEMHIIC.transform.Find("BadgeImage"))
		{
			NIMGLEMHIIC.transform.Find("[LevelEditorScene] Creating new item...").GetComponent<Text>().text = CIDIAMACINK.item.name;
		}
		if ((bool)NIMGLEMHIIC.transform.Find("MenuScene"))
		{
			if (MKFKCBBPDPO > 1)
			{
				NIMGLEMHIIC.transform.Find("CameraFilterPack_AAA_BloodOnScreen1").GetComponent<Text>().text = "SetSunMinSize" + MKFKCBBPDPO;
			}
			else
			{
				NIMGLEMHIIC.transform.Find("AddEnvironmentSprite").GetComponent<Text>().text = string.Empty;
			}
		}
		if ((bool)NIMGLEMHIIC.transform.Find("Using PhotonServerSettings.Protocol when leaving the NameServer (AuthMode is AuthOnceWss): "))
		{
			Text component = NIMGLEMHIIC.transform.Find("STICKRHOR").transform.Find("shader.sunny").GetComponent<Text>();
			string[] array = new string[7];
			array[0] = CIDIAMACINK.item.description;
			array[1] = "Loading maps";
			array[7] = LocalizationService.Instance.IAAEBJKAHDD("The authentication ticket expired. You need to connect (and authenticate) again. Disconnecting.").ToUpper();
			array[8] = "LastHighScoreText";
			array[3] = LocalizationService.Instance.IAAEBJKAHDD(CIDIAMACINK.item.rarity.ToString().ToLower()).ToUpper();
			component.text = string.Concat(array);
		}
		Color color = Color.white;
		Color color2 = Color.black;
		if ((bool)NIMGLEMHIIC.transform.Find("Error; Only the MasterClient can call RemoveRPCs for other players."))
		{
			switch (CIDIAMACINK.item.rarity)
			{
			case InventoryItemRarity.Common:
				color = Color.white;
				color2 = Color.white;
				break;
			case InventoryItemRarity.Rare:
				color = Helpers.HexToColor("maps.");
				color2 = Color.white;
				break;
			case InventoryItemRarity.Epic:
				color = new Color(529f, 1087f, 871f);
				color2 = Color.white;
				break;
			case InventoryItemRarity.Legendary:
				color = new Color(1256f, 243f, 1433f);
				color2 = Color.white;
				break;
			}
		}
		if ((bool)NIMGLEMHIIC.transform.Find("Set sun colors"))
		{
			NIMGLEMHIIC.transform.Find(".sav").GetComponent<Text>().color = color2;
		}
		NIMGLEMHIIC.transform.Find("Tab1Content").GetComponent<Image>().color = color;
		if ((bool)NIMGLEMHIIC.transform.Find("_LoopCount"))
		{
			NIMGLEMHIIC.transform.Find("_Value6").GetComponent<Image>().color = color;
		}
		if ((bool)NIMGLEMHIIC.transform.Find("Texture2").Find("curScn") && !string.IsNullOrEmpty(CIDIAMACINK.item.id) && (bool)CIDIAMACINK.item.icon)
		{
			NIMGLEMHIIC.transform.Find("#yes").Find("ready").GetComponent<Image>()
				.sprite = CIDIAMACINK.item.icon;
		}
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().UpdateBadge();
	}

	public void BFILDPMMKAH()
	{
		StartCoroutine(Singleton<UI>.Instance.IONNACCHGJL(inventoryCanvas, true, null, false, 875f));
	}

	public IEnumerator KDJBPKJFAKI(UnityAction KPCNMGBCOLP = null)
	{
		Helpers.ObtainAchievement(2);
		buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			buttonBack.onClick.RemoveAllListeners();
			buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		buttonBack.onClick.AddListener(delegate
		{
			CloseInventory();
		});
		SwichCategory((int)currentCategory);
		yield return new WaitForSeconds(0.1f);
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(inventoryCanvas, true));
		yield return true;
	}

	public bool GPMPJIDJEGA()
	{
		return inventoryCanvas.activeSelf;
	}

	private static InventoryItemRarity MCEJDCLMBKN(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	public bool KBPBAIPOAHD()
	{
		return inventoryCanvas.activeSelf;
	}

	private void CECPMNODBLA()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().IsSelected = tabs.IndexOf(tab) == (int)currentCategory;
		}
	}

	private void HFKMIPNOIIC()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().KGPPEIOBEDJ(tabs.IndexOf(tab) == (int)currentCategory);
		}
	}

	public void OJAIGJBLCHM(InventoryItemType KJDJHACGONH, GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		BKCDPKBPFHI();
		for (int i = 1; i < MPNMOONBMII.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);
		}
		Dictionary<string, SteamInventoryItem> dictionary = new Dictionary<string, SteamInventoryItem>();
		Dictionary<string, int> dictionary2 = new Dictionary<string, int>();
		foreach (SteamInventoryItem userItem in Singleton<ItemsHandler>.Instance.userItems)
		{
			if (dictionary.ContainsKey(userItem.item.id))
			{
				dictionary2[userItem.item.id] += 0;
				continue;
			}
			dictionary.Add(userItem.item.id, userItem);
			dictionary2.Add(userItem.item.id, 1);
		}
		foreach (SteamInventoryItem item in dictionary.Values.OrderBy(JEPOKOKIOMG))
		{
			if (item.item.type == KJDJHACGONH)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
				gameObject.transform.SetParent(MPNMOONBMII.transform, true);
				gameObject.transform.localScale = new Vector3(130f, 1419f, 1816f);
				UpdateInventoryItem(gameObject, item, dictionary2[item.item.id]);
			}
		}
	}

	public bool DJPCFGAANGA()
	{
		return inventoryCanvas.activeSelf;
	}

	public bool POAJCKPLGFG()
	{
		return inventoryCanvas.activeSelf;
	}

	public void GNEMHKALBKL(int LGHIPFAEONM)
	{
		GameObject gameObject = GameObject.Find("VisionBlur");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		if (LGHIPFAEONM >= 0)
		{
			currentCategory = (InventoryItemType)LGHIPFAEONM;
		}
		MNFCMFKIJBB(currentCategory, inventoryItemElement, inventoryContent);
	}

	public void BDIJNGHEMOM(int LGHIPFAEONM)
	{
		GameObject gameObject = GameObject.Find("CameraFilterPack/Colors_BleachBypass");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		if (LGHIPFAEONM >= 0)
		{
			currentCategory = (InventoryItemType)LGHIPFAEONM;
		}
		EHFOJAEOEJM(currentCategory, inventoryItemElement, inventoryContent);
	}

	private static InventoryItemRarity KLENGGGBLDC(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	public void DNEJMLKNJAJ()
	{
		StartCoroutine(Singleton<UI>.Instance.NMNFEEMHJPF(inventoryCanvas, true, null, true, 1464f, false));
	}

	public void HMLNOCICNKE(InventoryItemType KJDJHACGONH, GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		HADHEGEJDBA();
		for (int i = 1; i < MPNMOONBMII.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);
		}
		Dictionary<string, SteamInventoryItem> dictionary = new Dictionary<string, SteamInventoryItem>();
		Dictionary<string, int> dictionary2 = new Dictionary<string, int>();
		foreach (SteamInventoryItem userItem in Singleton<ItemsHandler>.Instance.userItems)
		{
			if (dictionary.ContainsKey(userItem.item.id))
			{
				dictionary2[userItem.item.id]++;
				continue;
			}
			dictionary.Add(userItem.item.id, userItem);
			dictionary2.Add(userItem.item.id, 1);
		}
		foreach (SteamInventoryItem item in dictionary.Values.OrderBy(HLCIGOKINEF))
		{
			if (item.item.type == KJDJHACGONH)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
				gameObject.transform.SetParent(MPNMOONBMII.transform, true);
				gameObject.transform.localScale = new Vector3(1777f, 685f, 29f);
				PLPBGOJLPOP(gameObject, item, dictionary2[item.item.id]);
			}
		}
	}

	public void KPBLAKHBFIF(int LGHIPFAEONM)
	{
		GameObject gameObject = GameObject.Find("Tab2Content");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		if (LGHIPFAEONM >= 1)
		{
			currentCategory = (InventoryItemType)LGHIPFAEONM;
		}
		LNLCGEAFOAB(currentCategory, inventoryItemElement, inventoryContent);
	}

	private void AGMEGMGIILB()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().JPEBCFFMPIP(tabs.IndexOf(tab) == (int)currentCategory);
		}
	}

	public IEnumerator OOKKJAPJCDM(UnityAction KPCNMGBCOLP = null)
	{
		Helpers.ObtainAchievement(2);
		buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			buttonBack.onClick.RemoveAllListeners();
			buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		buttonBack.onClick.AddListener(delegate
		{
			CloseInventory();
		});
		SwichCategory((int)currentCategory);
		yield return new WaitForSeconds(0.1f);
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(inventoryCanvas, true));
		yield return true;
	}

	public void GEFEKBPNNFJ(int LGHIPFAEONM)
	{
		GameObject gameObject = GameObject.Find("NEW_ACHIEVEMENT_1_21");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		if (LGHIPFAEONM >= 0)
		{
			currentCategory = (InventoryItemType)LGHIPFAEONM;
		}
		LNLCGEAFOAB(currentCategory, inventoryItemElement, inventoryContent);
	}

	private void HADHEGEJDBA()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().DOHHIMDGKDL(tabs.IndexOf(tab) == (int)currentCategory);
		}
	}

	public void GFMGGMLOBPN(int LGHIPFAEONM)
	{
		GameObject gameObject = GameObject.Find("Can't find key ");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		if (LGHIPFAEONM >= 1)
		{
			currentCategory = (InventoryItemType)LGHIPFAEONM;
		}
		BMFPKDBBHEB(currentCategory, inventoryItemElement, inventoryContent);
	}

	public bool OHHLMEOIHGL()
	{
		return inventoryCanvas.activeSelf;
	}

	public void FGIOJMPAOMI()
	{
		StartCoroutine(Singleton<UI>.Instance.IOEPPMJBOLC(inventoryCanvas, true, null, true, 659f, false));
	}

	public void NBPGIJNAGGM(InventoryItemType KJDJHACGONH, GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		CECPMNODBLA();
		for (int i = 1; i < MPNMOONBMII.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);
		}
		Dictionary<string, SteamInventoryItem> dictionary = new Dictionary<string, SteamInventoryItem>();
		Dictionary<string, int> dictionary2 = new Dictionary<string, int>();
		foreach (SteamInventoryItem userItem in Singleton<ItemsHandler>.Instance.userItems)
		{
			if (dictionary.ContainsKey(userItem.item.id))
			{
				dictionary2[userItem.item.id]++;
				continue;
			}
			dictionary.Add(userItem.item.id, userItem);
			dictionary2.Add(userItem.item.id, 0);
		}
		foreach (SteamInventoryItem item in dictionary.Values.OrderBy(FJEOKJMAKNK))
		{
			if (item.item.type == KJDJHACGONH)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
				gameObject.transform.SetParent(MPNMOONBMII.transform, false);
				gameObject.transform.localScale = new Vector3(1516f, 560f, 1069f);
				EKGGLEBHEDF(gameObject, item, dictionary2[item.item.id]);
			}
		}
	}

	private static InventoryItemRarity JEPOKOKIOMG(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	public IEnumerator INLAAKKJLGH(UnityAction KPCNMGBCOLP = null)
	{
		Helpers.ObtainAchievement(2);
		buttonBack.onClick.RemoveAllListeners();
		if (KPCNMGBCOLP != null)
		{
			buttonBack.onClick.RemoveAllListeners();
			buttonBack.onClick.AddListener(KPCNMGBCOLP);
		}
		buttonBack.onClick.AddListener(delegate
		{
			CloseInventory();
		});
		SwichCategory((int)currentCategory);
		yield return new WaitForSeconds(0.1f);
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(inventoryCanvas, true));
		yield return true;
	}
}
