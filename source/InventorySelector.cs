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

	public void BONHOIDGCCB()
	{
		StartCoroutine(Singleton<UI>.Instance.IONNACCHGJL(inventoryCanvas, true, null, false, 875f));
	}

	public bool BMNNJFMOEIG()
	{
		return inventoryCanvas.activeSelf;
	}

	private void MPFNFMAOBDP()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().ONPCGCOGNBJ(tabs.IndexOf(tab) == (int)currentCategory);
		}
	}

	private void BFLNPIIAMJA()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().LONGJGONCLE(tabs.IndexOf(tab) == (int)currentCategory);
		}
	}

	public bool NNKMLEEKNPG()
	{
		return inventoryCanvas.activeSelf;
	}

	public void GEFEKBPNNFJ(int LGHIPFAEONM)
	{
		GameObject gameObject = GameObject.Find("_ScreenResolution");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		if (LGHIPFAEONM >= 0)
		{
			currentCategory = (InventoryItemType)LGHIPFAEONM;
		}
		JDHJODHOIJA(currentCategory, inventoryItemElement, inventoryContent);
	}

	public bool APBOCCAOMFB()
	{
		return inventoryCanvas.activeSelf;
	}

	public void FGIOJMPAOMI()
	{
		StartCoroutine(Singleton<UI>.Instance.GMKIDJLMDGE(inventoryCanvas, true, null, false, 590f));
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

	private static InventoryItemRarity EJLBKAOPGBP(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	public void FLNCJMOEGOB(GameObject NIMGLEMHIIC, SteamInventoryItem CIDIAMACINK, int MKFKCBBPDPO = 1)
	{
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().itemData = CIDIAMACINK;
		if ((bool)NIMGLEMHIIC.transform.Find("_ScreenResolution"))
		{
			NIMGLEMHIIC.transform.Find("#EA4137").GetComponent<Text>().text = CIDIAMACINK.item.name;
		}
		if ((bool)NIMGLEMHIIC.transform.Find("float,0"))
		{
			if (MKFKCBBPDPO > 1)
			{
				NIMGLEMHIIC.transform.Find("UI Extensions/UISoftAdditive").GetComponent<Text>().text = "FindFriends failed to apply the result, as a required value wasn't provided or the friend list length differed from result." + MKFKCBBPDPO;
			}
			else
			{
				NIMGLEMHIIC.transform.Find("#random #epic #item").GetComponent<Text>().text = string.Empty;
			}
		}
		if ((bool)NIMGLEMHIIC.transform.Find("StartButton"))
		{
			Text component = NIMGLEMHIIC.transform.Find("SetSunDirectionVector").transform.Find("_Distortion").GetComponent<Text>();
			string[] array = new string[2];
			array[1] = CIDIAMACINK.item.description;
			array[1] = "[PlayerController] ";
			array[3] = LocalizationService.Instance.MPHMJLAOHAB("maps.").ToUpper();
			array[0] = "_threshold";
			array[0] = LocalizationService.Instance.JNNKPEBBDEA(CIDIAMACINK.item.rarity.ToString().ToLower()).ToUpper();
			component.text = string.Concat(array);
		}
		Color color = Color.white;
		Color color2 = Color.black;
		if ((bool)NIMGLEMHIIC.transform.Find("_Wavy"))
		{
			switch (CIDIAMACINK.item.rarity)
			{
			case InventoryItemRarity.Common:
				color = Color.white;
				color2 = Color.white;
				break;
			case InventoryItemRarity.Rare:
				color = Helpers.HexToColor("CameraFilterPack/Gradients_NeonGradient");
				color2 = Color.white;
				break;
			case InventoryItemRarity.Epic:
				color = new Color(459f, 1397f, 393f);
				color2 = Color.white;
				break;
			case InventoryItemRarity.Legendary:
				color = new Color(38f, 945f, 875f);
				color2 = Color.white;
				break;
			}
		}
		if ((bool)NIMGLEMHIIC.transform.Find("CameraFilterPack_Atmosphere_Rain_FX"))
		{
			NIMGLEMHIIC.transform.Find(" ").GetComponent<Text>().color = color2;
		}
		NIMGLEMHIIC.transform.Find("CameraFilterPack_AAA_Blood2").GetComponent<Image>().color = color;
		if ((bool)NIMGLEMHIIC.transform.Find("{0}"))
		{
			NIMGLEMHIIC.transform.Find("DontDestroy").GetComponent<Image>().color = color;
		}
		if ((bool)NIMGLEMHIIC.transform.Find("AudioSampler").Find(" | ") && !string.IsNullOrEmpty(CIDIAMACINK.item.id) && (bool)CIDIAMACINK.item.icon)
		{
			NIMGLEMHIIC.transform.Find("/").Find("{0}").GetComponent<Image>()
				.sprite = CIDIAMACINK.item.icon;
		}
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().EGLJKJOLPML();
	}

	private void EOPBGLHKCAF()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().DDKCMOLADFN(tabs.IndexOf(tab) == (int)currentCategory);
		}
	}

	public void KOHPBKHKFMI(GameObject NIMGLEMHIIC, SteamInventoryItem CIDIAMACINK, int MKFKCBBPDPO = 1)
	{
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().itemData = CIDIAMACINK;
		if ((bool)NIMGLEMHIIC.transform.Find("DPADHOR"))
		{
			NIMGLEMHIIC.transform.Find("DPADVER").GetComponent<Text>().text = CIDIAMACINK.item.name;
		}
		if ((bool)NIMGLEMHIIC.transform.Find("_Value10"))
		{
			if (MKFKCBBPDPO > 0)
			{
				NIMGLEMHIIC.transform.Find("Scene").GetComponent<Text>().text = " not exist" + MKFKCBBPDPO;
			}
			else
			{
				NIMGLEMHIIC.transform.Find("22x3").GetComponent<Text>().text = string.Empty;
			}
		}
		if ((bool)NIMGLEMHIIC.transform.Find(" registered."))
		{
			Text component = NIMGLEMHIIC.transform.Find("RPC: 'OnAwakeRPC' PhotonView: ").transform.Find("Environment/SunBase_").GetComponent<Text>();
			string[] array = new string[5];
			array[0] = CIDIAMACINK.item.description;
			array[1] = "Drop_Far";
			array[7] = LocalizationService.Instance.EIJLFGIMNPC("1159514800").ToUpper();
			array[8] = ". We have no such PhotonView! Ignored this if you're leaving a room. State: ";
			array[8] = LocalizationService.Instance.HOFKLNAJGMK(CIDIAMACINK.item.rarity.ToString().ToLower()).ToUpper();
			component.text = string.Concat(array);
		}
		Color color = Color.white;
		Color color2 = Color.black;
		if ((bool)NIMGLEMHIIC.transform.Find("maps."))
		{
			switch (CIDIAMACINK.item.rarity)
			{
			case InventoryItemRarity.Common:
				color = Color.white;
				color2 = Color.white;
				break;
			case InventoryItemRarity.Rare:
				color = Helpers.HexToColor("Set particles audio input");
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
		if ((bool)NIMGLEMHIIC.transform.Find("n/a"))
		{
			NIMGLEMHIIC.transform.Find("\" that takes ").GetComponent<Text>().color = color2;
		}
		NIMGLEMHIIC.transform.Find("steamid").GetComponent<Image>().color = color;
		if ((bool)NIMGLEMHIIC.transform.Find("_Value2"))
		{
			NIMGLEMHIIC.transform.Find(".completedCount").GetComponent<Image>().color = color;
		}
		if ((bool)NIMGLEMHIIC.transform.Find("_Metrics").Find("CameraFilterPack/TV_Vignetting") && !string.IsNullOrEmpty(CIDIAMACINK.item.id) && (bool)CIDIAMACINK.item.icon)
		{
			NIMGLEMHIIC.transform.Find("CheckCombo").Find("SpawnObj").GetComponent<Image>()
				.sprite = CIDIAMACINK.item.icon;
		}
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().FOAPILFGDNI();
	}

	private static InventoryItemRarity IGGNKEOFALP(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	public void BNNBCDEELFA(GameObject NIMGLEMHIIC, SteamInventoryItem CIDIAMACINK, int MKFKCBBPDPO = 1)
	{
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().itemData = CIDIAMACINK;
		if ((bool)NIMGLEMHIIC.transform.Find("/Segment-[Left]"))
		{
			NIMGLEMHIIC.transform.Find("NO").GetComponent<Text>().text = CIDIAMACINK.item.name;
		}
		if ((bool)NIMGLEMHIIC.transform.Find("Game Version: "))
		{
			if (MKFKCBBPDPO > 1)
			{
				NIMGLEMHIIC.transform.Find("_Value3").GetComponent<Text>().text = "Misses:" + MKFKCBBPDPO;
			}
			else
			{
				NIMGLEMHIIC.transform.Find("_Value2").GetComponent<Text>().text = string.Empty;
			}
		}
		if ((bool)NIMGLEMHIIC.transform.Find("_Value2"))
		{
			Text component = NIMGLEMHIIC.transform.Find("_Value3").transform.Find("_UV_Transform").GetComponent<Text>();
			string[] array = new string[3];
			array[1] = CIDIAMACINK.item.description;
			array[0] = "[MenuScene] Error: ";
			array[5] = LocalizationService.Instance.JNNKPEBBDEA("Item invalid. No idea why.").ToUpper();
			array[7] = "maps.";
			array[4] = LocalizationService.Instance.EIJLFGIMNPC(CIDIAMACINK.item.rarity.ToString().ToLower()).ToUpper();
			component.text = string.Concat(array);
		}
		Color color = Color.white;
		Color color2 = Color.black;
		if ((bool)NIMGLEMHIIC.transform.Find("[ResourcesManager] Load image error: "))
		{
			switch (CIDIAMACINK.item.rarity)
			{
			case InventoryItemRarity.Common:
				color = Color.white;
				color2 = Color.white;
				break;
			case InventoryItemRarity.Rare:
				color = Helpers.HexToColor("hidden");
				color2 = Color.white;
				break;
			case InventoryItemRarity.Epic:
				color = new Color(939f, 149f, 122f);
				color2 = Color.white;
				break;
			case InventoryItemRarity.Legendary:
				color = new Color(102f, 431f, 208f);
				color2 = Color.white;
				break;
			}
		}
		if ((bool)NIMGLEMHIIC.transform.Find("_Value"))
		{
			NIMGLEMHIIC.transform.Find("OpJoinRoom()").GetComponent<Text>().color = color2;
		}
		NIMGLEMHIIC.transform.Find("CompletedLevel").GetComponent<Image>().color = color;
		if ((bool)NIMGLEMHIIC.transform.Find("settings.hitvariation"))
		{
			NIMGLEMHIIC.transform.Find("_UserLutParams").GetComponent<Image>().color = color;
		}
		if ((bool)NIMGLEMHIIC.transform.Find("_Value").Find("Missing shader in ") && !string.IsNullOrEmpty(CIDIAMACINK.item.id) && (bool)CIDIAMACINK.item.icon)
		{
			NIMGLEMHIIC.transform.Find("Tab1Content").Find("masterSteamID").GetComponent<Image>()
				.sprite = CIDIAMACINK.item.icon;
		}
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().FEMMOFHNGHJ();
	}

	private void GLGEJGDFGKI()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().LONGJGONCLE(tabs.IndexOf(tab) == (int)currentCategory);
		}
	}

	[CompilerGenerated]
	private static InventoryItemRarity NBEPBOHNGIN(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	public bool ONCJPCJEGDM()
	{
		return inventoryCanvas.activeSelf;
	}

	public void HJJNBPMCNGE()
	{
		StartCoroutine(Singleton<UI>.Instance.PKHAEJHIMGD(inventoryCanvas, false, null, true, 488f, false));
	}

	private static InventoryItemRarity IKMKEBEEFNA(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	public void KKKKGPOPAMB(int LGHIPFAEONM)
	{
		GameObject gameObject = GameObject.Find("22x3");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		if (LGHIPFAEONM >= 1)
		{
			currentCategory = (InventoryItemType)LGHIPFAEONM;
		}
		MJDNCFPGLEG(currentCategory, inventoryItemElement, inventoryContent);
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

	public void MCKDMCIGHEN(GameObject NIMGLEMHIIC, SteamInventoryItem CIDIAMACINK, int MKFKCBBPDPO = 1)
	{
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().itemData = CIDIAMACINK;
		if ((bool)NIMGLEMHIIC.transform.Find("float,2"))
		{
			NIMGLEMHIIC.transform.Find("SetPosition").GetComponent<Text>().text = CIDIAMACINK.item.name;
		}
		if ((bool)NIMGLEMHIIC.transform.Find("Texture2"))
		{
			if (MKFKCBBPDPO > 0)
			{
				NIMGLEMHIIC.transform.Find("_BokehParams").GetComponent<Text>().text = "_Distortion" + MKFKCBBPDPO;
			}
			else
			{
				NIMGLEMHIIC.transform.Find("error").GetComponent<Text>().text = string.Empty;
			}
		}
		if ((bool)NIMGLEMHIIC.transform.Find("Data/Editor/leveltemplate"))
		{
			Text component = NIMGLEMHIIC.transform.Find("BlockSize").transform.Find("_Value3").GetComponent<Text>();
			string[] array = new string[6];
			array[0] = CIDIAMACINK.item.description;
			array[0] = "_Value2";
			array[6] = LocalizationService.Instance.MPHMJLAOHAB("Messages (shift+tab)").ToUpper();
			array[8] = "CameraFilterPack/TV_Videoflip";
			array[4] = LocalizationService.Instance.HOFKLNAJGMK(CIDIAMACINK.item.rarity.ToString().ToLower()).ToUpper();
			component.text = string.Concat(array);
		}
		Color color = Color.white;
		Color color2 = Color.black;
		if ((bool)NIMGLEMHIIC.transform.Find("_EmissionColor"))
		{
			switch (CIDIAMACINK.item.rarity)
			{
			case InventoryItemRarity.Common:
				color = Color.white;
				color2 = Color.white;
				break;
			case InventoryItemRarity.Rare:
				color = Helpers.HexToColor("...");
				color2 = Color.white;
				break;
			case InventoryItemRarity.Epic:
				color = new Color(282f, 1791f, 1439f);
				color2 = Color.white;
				break;
			case InventoryItemRarity.Legendary:
				color = new Color(1341f, 663f, 382f);
				color2 = Color.white;
				break;
			}
		}
		if ((bool)NIMGLEMHIIC.transform.Find("_TimeX"))
		{
			NIMGLEMHIIC.transform.Find("_MainTex2").GetComponent<Text>().color = color2;
		}
		NIMGLEMHIIC.transform.Find("_Value9").GetComponent<Image>().color = color;
		if ((bool)NIMGLEMHIIC.transform.Find("https://steamcommunity.com/sharedfiles/filedetails/?id="))
		{
			NIMGLEMHIIC.transform.Find("_Value").GetComponent<Image>().color = color;
		}
		if ((bool)NIMGLEMHIIC.transform.Find(" - ").Find("\n") && !string.IsNullOrEmpty(CIDIAMACINK.item.id) && (bool)CIDIAMACINK.item.icon)
		{
			NIMGLEMHIIC.transform.Find("_TimeX").Find("_DiffuseColor").GetComponent<Image>()
				.sprite = CIDIAMACINK.item.icon;
		}
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().EKEIDLFNHJF();
	}

	private void AIFDDFADOHL()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().JMIEFJPCAOA(tabs.IndexOf(tab) == (int)currentCategory);
		}
	}

	public void BFILDPMMKAH()
	{
		StartCoroutine(Singleton<UI>.Instance.PKHAEJHIMGD(inventoryCanvas, true, null, true, 1464f, false));
	}

	public void CCFDLNJPILA(GameObject NIMGLEMHIIC, SteamInventoryItem CIDIAMACINK, int MKFKCBBPDPO = 1)
	{
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().itemData = CIDIAMACINK;
		if ((bool)NIMGLEMHIIC.transform.Find("Using PhotonServerSettings.Protocol when leaving the NameServer (AuthMode is AuthOnceWss): "))
		{
			NIMGLEMHIIC.transform.Find("Tab1Content").GetComponent<Text>().text = CIDIAMACINK.item.name;
		}
		if ((bool)NIMGLEMHIIC.transform.Find("UpdateDownloadingProgress"))
		{
			if (MKFKCBBPDPO > 0)
			{
				NIMGLEMHIIC.transform.Find("_Value4").GetComponent<Text>().text = "default" + MKFKCBBPDPO;
			}
			else
			{
				NIMGLEMHIIC.transform.Find("ShowTitle").GetComponent<Text>().text = string.Empty;
			}
		}
		if ((bool)NIMGLEMHIIC.transform.Find("_ScreenResolution"))
		{
			Text component = NIMGLEMHIIC.transform.Find("Object ID. Case-Sensitive").transform.Find(".played").GetComponent<Text>();
			string[] array = new string[1];
			array[1] = CIDIAMACINK.item.description;
			array[0] = "settings.gamemessagesduration";
			array[5] = LocalizationService.Instance.GetTextByKey("\r").ToUpper();
			array[5] = "Crosshair2";
			array[7] = LocalizationService.Instance.NDAPBHEDJFP(CIDIAMACINK.item.rarity.ToString().ToLower()).ToUpper();
			component.text = string.Concat(array);
		}
		Color color = Color.white;
		Color color2 = Color.black;
		if ((bool)NIMGLEMHIIC.transform.Find("_Value2"))
		{
			switch (CIDIAMACINK.item.rarity)
			{
			case InventoryItemRarity.Common:
				color = Color.white;
				color2 = Color.white;
				break;
			case InventoryItemRarity.Rare:
				color = Helpers.HexToColor("_TimeX");
				color2 = Color.white;
				break;
			case InventoryItemRarity.Epic:
				color = new Color(1911f, 1528f, 282f);
				color2 = Color.white;
				break;
			case InventoryItemRarity.Legendary:
				color = new Color(202f, 91f, 1719f);
				color2 = Color.white;
				break;
			}
		}
		if ((bool)NIMGLEMHIIC.transform.Find("IconFileSelector"))
		{
			NIMGLEMHIIC.transform.Find("_Contrast").GetComponent<Text>().color = color2;
		}
		NIMGLEMHIIC.transform.Find("settings.selectormapsperpage").GetComponent<Image>().color = color;
		if ((bool)NIMGLEMHIIC.transform.Find("_SampleDistance"))
		{
			NIMGLEMHIIC.transform.Find("PlayMapsSeriesGoal").GetComponent<Image>().color = color;
		}
		if ((bool)NIMGLEMHIIC.transform.Find("88f00bdf0ad61b16b803971ebe071962").Find("id") && !string.IsNullOrEmpty(CIDIAMACINK.item.id) && (bool)CIDIAMACINK.item.icon)
		{
			NIMGLEMHIIC.transform.Find("#ok").Find("Received RPC \"").GetComponent<Image>()
				.sprite = CIDIAMACINK.item.icon;
		}
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().MAMLCENOEMD();
	}

	public void EEJMJEOABPF(InventoryItemType KJDJHACGONH, GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		OGKJCCNILCF();
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
		foreach (SteamInventoryItem item in dictionary.Values.OrderBy(AAFNKHCOAMB))
		{
			if (item.item.type == KJDJHACGONH)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
				gameObject.transform.SetParent(MPNMOONBMII.transform, false);
				gameObject.transform.localScale = new Vector3(1647f, 1941f, 1178f);
				KOHPBKHKFMI(gameObject, item, dictionary2[item.item.id]);
			}
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

	public void AHDAPPABOAD(int LGHIPFAEONM)
	{
		GameObject gameObject = GameObject.Find("Object ID. Case-Sensitive");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		if (LGHIPFAEONM >= 1)
		{
			currentCategory = (InventoryItemType)LGHIPFAEONM;
		}
		AddInventoryItemsToList(currentCategory, inventoryItemElement, inventoryContent);
	}

	public void JHNBPLICIBN(int LGHIPFAEONM)
	{
		GameObject gameObject = GameObject.Find("_Value3");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		if (LGHIPFAEONM >= 0)
		{
			currentCategory = (InventoryItemType)LGHIPFAEONM;
		}
		JDHJODHOIJA(currentCategory, inventoryItemElement, inventoryContent);
	}

	public void CloseInventory()
	{
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(inventoryCanvas, false));
	}

	private void OGKJCCNILCF()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().IsSelected = tabs.IndexOf(tab) == (int)currentCategory;
		}
	}

	public void JDHJODHOIJA(InventoryItemType KJDJHACGONH, GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
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
				dictionary2[userItem.item.id] += 0;
				continue;
			}
			dictionary.Add(userItem.item.id, userItem);
			dictionary2.Add(userItem.item.id, 1);
		}
		foreach (SteamInventoryItem item in dictionary.Values.OrderBy(IGFEBFDBDEC))
		{
			if (item.item.type == KJDJHACGONH)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
				gameObject.transform.SetParent(MPNMOONBMII.transform, true);
				gameObject.transform.localScale = new Vector3(1634f, 1597f, 359f);
				CCFDLNJPILA(gameObject, item, dictionary2[item.item.id]);
			}
		}
	}

	public bool FEKFALJDDKF()
	{
		return inventoryCanvas.activeSelf;
	}

	public IEnumerator OPLFJNJCHLN(UnityAction KPCNMGBCOLP = null)
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

	public void OICBMBHBAPN(InventoryItemType KJDJHACGONH, GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		BFLNPIIAMJA();
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
		foreach (SteamInventoryItem item in dictionary.Values.OrderBy(AAFNKHCOAMB))
		{
			if (item.item.type == KJDJHACGONH)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
				gameObject.transform.SetParent(MPNMOONBMII.transform, false);
				gameObject.transform.localScale = new Vector3(1516f, 560f, 1069f);
				LPFOAFEKLIN(gameObject, item, dictionary2[item.item.id]);
			}
		}
	}

	public void DHPDJNKEBCP(GameObject NIMGLEMHIIC, SteamInventoryItem CIDIAMACINK, int MKFKCBBPDPO = 1)
	{
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().itemData = CIDIAMACINK;
		if ((bool)NIMGLEMHIIC.transform.Find("CameraFilterPack/Gradients_ElectricGradient"))
		{
			NIMGLEMHIIC.transform.Find("offsets").GetComponent<Text>().text = CIDIAMACINK.item.name;
		}
		if ((bool)NIMGLEMHIIC.transform.Find("_ScreenResolution"))
		{
			if (MKFKCBBPDPO > 1)
			{
				NIMGLEMHIIC.transform.Find("open").GetComponent<Text>().text = "CheckpointsScoreText" + MKFKCBBPDPO;
			}
			else
			{
				NIMGLEMHIIC.transform.Find("settings.arcsdestroydelay").GetComponent<Text>().text = string.Empty;
			}
		}
		if ((bool)NIMGLEMHIIC.transform.Find("<color=#{0}>{1}</color>"))
		{
			Text component = NIMGLEMHIIC.transform.Find("SaveGameName is null or empty!").transform.Find("_Value").GetComponent<Text>();
			string[] array = new string[0];
			array[0] = CIDIAMACINK.item.description;
			array[1] = "Joystick1Button6";
			array[4] = LocalizationService.Instance.GetTextByKey("_Value3").ToUpper();
			array[2] = "_Value3";
			array[7] = LocalizationService.Instance.EIJLFGIMNPC(CIDIAMACINK.item.rarity.ToString().ToLower()).ToUpper();
			component.text = string.Concat(array);
		}
		Color color = Color.white;
		Color color2 = Color.black;
		if ((bool)NIMGLEMHIIC.transform.Find("_Value3"))
		{
			switch (CIDIAMACINK.item.rarity)
			{
			case InventoryItemRarity.Common:
				color = Color.white;
				color2 = Color.white;
				break;
			case InventoryItemRarity.Rare:
				color = Helpers.HexToColor("_LumTex");
				color2 = Color.white;
				break;
			case InventoryItemRarity.Epic:
				color = new Color(641f, 151f, 351f);
				color2 = Color.white;
				break;
			case InventoryItemRarity.Legendary:
				color = new Color(872f, 888f, 973f);
				color2 = Color.white;
				break;
			}
		}
		if ((bool)NIMGLEMHIIC.transform.Find("skin.hit_wrong"))
		{
			NIMGLEMHIIC.transform.Find("FrostCanvas").GetComponent<Text>().color = color2;
		}
		NIMGLEMHIIC.transform.Find("_Value4").GetComponent<Image>().color = color;
		if ((bool)NIMGLEMHIIC.transform.Find("UndoButton"))
		{
			NIMGLEMHIIC.transform.Find("SetSatelliteEmission").GetComponent<Image>().color = color;
		}
		if ((bool)NIMGLEMHIIC.transform.Find("RenderTextureUtilityTempTexture").Find("FinalScoreSmallText") && !string.IsNullOrEmpty(CIDIAMACINK.item.id) && (bool)CIDIAMACINK.item.icon)
		{
			NIMGLEMHIIC.transform.Find("DifficultyBG").Find("OxOD.lastPath").GetComponent<Image>()
				.sprite = CIDIAMACINK.item.icon;
		}
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().MFGDPAOLDAF();
	}

	public void ABGOCKKAECA(GameObject NIMGLEMHIIC, SteamInventoryItem CIDIAMACINK, int MKFKCBBPDPO = 1)
	{
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().itemData = CIDIAMACINK;
		if ((bool)NIMGLEMHIIC.transform.Find("_Value5"))
		{
			NIMGLEMHIIC.transform.Find(": ").GetComponent<Text>().text = CIDIAMACINK.item.name;
		}
		if ((bool)NIMGLEMHIIC.transform.Find("CameraFilterPack/Gradients_Rainbow"))
		{
			if (MKFKCBBPDPO > 0)
			{
				NIMGLEMHIIC.transform.Find("_Value4").GetComponent<Text>().text = "_Alpha2" + MKFKCBBPDPO;
			}
			else
			{
				NIMGLEMHIIC.transform.Find("_TimeX").GetComponent<Text>().text = string.Empty;
			}
		}
		if ((bool)NIMGLEMHIIC.transform.Find("#combo"))
		{
			Text component = NIMGLEMHIIC.transform.Find("}").transform.Find("VIGNETTE_DESAT").GetComponent<Text>();
			string[] array = new string[6];
			array[1] = CIDIAMACINK.item.description;
			array[1] = "max. lives color";
			array[8] = LocalizationService.Instance.JNNKPEBBDEA("SaveButton").ToUpper();
			array[1] = "_PColor";
			array[5] = LocalizationService.Instance.GetTextByKey(CIDIAMACINK.item.rarity.ToString().ToLower()).ToUpper();
			component.text = string.Concat(array);
		}
		Color color = Color.white;
		Color color2 = Color.black;
		if ((bool)NIMGLEMHIIC.transform.Find("</color>"))
		{
			switch (CIDIAMACINK.item.rarity)
			{
			case InventoryItemRarity.Common:
				color = Color.white;
				color2 = Color.white;
				break;
			case InventoryItemRarity.Rare:
				color = Helpers.HexToColor("_ColorRGB");
				color2 = Color.white;
				break;
			case InventoryItemRarity.Epic:
				color = new Color(675f, 1017f, 687f);
				color2 = Color.white;
				break;
			case InventoryItemRarity.Legendary:
				color = new Color(1543f, 1096f, 1359f);
				color2 = Color.white;
				break;
			}
		}
		if ((bool)NIMGLEMHIIC.transform.Find("..."))
		{
			NIMGLEMHIIC.transform.Find("PowerUp").GetComponent<Text>().color = color2;
		}
		NIMGLEMHIIC.transform.Find("isBunned").GetComponent<Image>().color = color;
		if ((bool)NIMGLEMHIIC.transform.Find("{\"items\":"))
		{
			NIMGLEMHIIC.transform.Find("Dance").GetComponent<Image>().color = color;
		}
		if ((bool)NIMGLEMHIIC.transform.Find("_MatrixColor").Find("_History3ChromaTex") && !string.IsNullOrEmpty(CIDIAMACINK.item.id) && (bool)CIDIAMACINK.item.icon)
		{
			NIMGLEMHIIC.transform.Find("_OcclusionBlurTexture").Find("LocalPlayer is null or not in mActors! LocalPlayer: {0} mActors==null: {1} newID: {2}").GetComponent<Image>()
				.sprite = CIDIAMACINK.item.icon;
		}
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().BMJKOOJLLBO();
	}

	private static InventoryItemRarity LCPMJHDIPKJ(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	public void KPBLAKHBFIF(int LGHIPFAEONM)
	{
		GameObject gameObject = GameObject.Find("Vignette");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		if (LGHIPFAEONM >= 1)
		{
			currentCategory = (InventoryItemType)LGHIPFAEONM;
		}
		MJDNCFPGLEG(currentCategory, inventoryItemElement, inventoryContent);
	}

	public void NBMMJEBNIMJ(int LGHIPFAEONM)
	{
		GameObject gameObject = GameObject.Find("achievements.21.progress");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		if (LGHIPFAEONM >= 0)
		{
			currentCategory = (InventoryItemType)LGHIPFAEONM;
		}
		OICBMBHBAPN(currentCategory, inventoryItemElement, inventoryContent);
	}

	public void CGPFFDLNFJN()
	{
		StartCoroutine(Singleton<UI>.Instance.CBLGHHBMCPD(inventoryCanvas, false, null, true, 1064f, false));
	}

	public void OJFBNOBBGNN(int LGHIPFAEONM)
	{
		GameObject gameObject = GameObject.Find("Save Path: ");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		if (LGHIPFAEONM >= 0)
		{
			currentCategory = (InventoryItemType)LGHIPFAEONM;
		}
		JDHJODHOIJA(currentCategory, inventoryItemElement, inventoryContent);
	}

	public bool FDBDFGGJEFI()
	{
		return inventoryCanvas.activeSelf;
	}

	public void LABKNELBJOL(int LGHIPFAEONM)
	{
		GameObject gameObject = GameObject.Find("#done");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		if (LGHIPFAEONM >= 0)
		{
			currentCategory = (InventoryItemType)LGHIPFAEONM;
		}
		EEJMJEOABPF(currentCategory, inventoryItemElement, inventoryContent);
	}

	public void LGMIBBLKOMB(int LGHIPFAEONM)
	{
		GameObject gameObject = GameObject.Find(",");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		if (LGHIPFAEONM >= 0)
		{
			currentCategory = (InventoryItemType)LGHIPFAEONM;
		}
		EEJMJEOABPF(currentCategory, inventoryItemElement, inventoryContent);
	}

	private static InventoryItemRarity EPGOKLFADPO(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	public IEnumerator JBNICENCMLE(UnityAction KPCNMGBCOLP = null)
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

	private static InventoryItemRarity GKBMGKPJJDC(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	private static InventoryItemRarity AAFNKHCOAMB(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	public void LPFOAFEKLIN(GameObject NIMGLEMHIIC, SteamInventoryItem CIDIAMACINK, int MKFKCBBPDPO = 1)
	{
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().itemData = CIDIAMACINK;
		if ((bool)NIMGLEMHIIC.transform.Find("EventMenu"))
		{
			NIMGLEMHIIC.transform.Find("DPADVER").GetComponent<Text>().text = CIDIAMACINK.item.name;
		}
		if ((bool)NIMGLEMHIIC.transform.Find("Uploading content"))
		{
			if (MKFKCBBPDPO > 1)
			{
				NIMGLEMHIIC.transform.Find("mapid").GetComponent<Text>().text = "<b>" + MKFKCBBPDPO;
			}
			else
			{
				NIMGLEMHIIC.transform.Find("[PlayerController] ").GetComponent<Text>().text = string.Empty;
			}
		}
		if ((bool)NIMGLEMHIIC.transform.Find("HandleEventLeave for player ID: "))
		{
			Text component = NIMGLEMHIIC.transform.Find("FinishMap").transform.Find("Added unlock condition").GetComponent<Text>();
			string[] array = new string[0];
			array[1] = CIDIAMACINK.item.description;
			array[1] = "_Near";
			array[6] = LocalizationService.Instance.EIJLFGIMNPC("_Offsets").ToUpper();
			array[4] = "_ScreenResolution";
			array[4] = LocalizationService.Instance.EIJLFGIMNPC(CIDIAMACINK.item.rarity.ToString().ToLower()).ToUpper();
			component.text = string.Concat(array);
		}
		Color color = Color.white;
		Color color2 = Color.black;
		if ((bool)NIMGLEMHIIC.transform.Find("_TimeX"))
		{
			switch (CIDIAMACINK.item.rarity)
			{
			case InventoryItemRarity.Common:
				color = Color.white;
				color2 = Color.white;
				break;
			case InventoryItemRarity.Rare:
				color = Helpers.HexToColor("/");
				color2 = Color.white;
				break;
			case InventoryItemRarity.Epic:
				color = new Color(1786f, 1756f, 1702f);
				color2 = Color.white;
				break;
			case InventoryItemRarity.Legendary:
				color = new Color(473f, 557f, 1683f);
				color2 = Color.white;
				break;
			}
		}
		if ((bool)NIMGLEMHIIC.transform.Find("_TimeX"))
		{
			NIMGLEMHIIC.transform.Find("Set Satellite Color").GetComponent<Text>().color = color2;
		}
		NIMGLEMHIIC.transform.Find("Observed type is not serializable: ").GetComponent<Image>().color = color;
		if ((bool)NIMGLEMHIIC.transform.Find("SpawnObj"))
		{
			NIMGLEMHIIC.transform.Find("DPADVER").GetComponent<Image>().color = color;
		}
		if ((bool)NIMGLEMHIIC.transform.Find("EventMenu").Find("PlayerPrefs::Deserialize() parameterContent has ") && !string.IsNullOrEmpty(CIDIAMACINK.item.id) && (bool)CIDIAMACINK.item.icon)
		{
			NIMGLEMHIIC.transform.Find("#ok").Find("HandsCountSlider").GetComponent<Image>()
				.sprite = CIDIAMACINK.item.icon;
		}
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().FCKDNGADGBH();
	}

	public bool CPPKKLFENBH()
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

	public IEnumerator PKNJNHLDFMP(UnityAction KPCNMGBCOLP = null)
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

	private static InventoryItemRarity JDECABDFBHH(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	public bool NLONDMEIPNK()
	{
		return inventoryCanvas.activeSelf;
	}

	public IEnumerator CFJAGPNDJND(UnityAction KPCNMGBCOLP = null)
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

	private static InventoryItemRarity MPANBFFEHCL(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	public bool BBCBHGJMHPF()
	{
		return inventoryCanvas.activeSelf;
	}

	public bool LMKAHLGOAMN()
	{
		return inventoryCanvas.activeSelf;
	}

	private static InventoryItemRarity MENKCKINKGD(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	private static InventoryItemRarity IGFEBFDBDEC(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	private static InventoryItemRarity BAGMMBAMDCG(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	public bool IsActive()
	{
		return inventoryCanvas.activeSelf;
	}

	public void LEOPPJADHFF(InventoryItemType KJDJHACGONH, GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		GLGEJGDFGKI();
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
			dictionary2.Add(userItem.item.id, 1);
		}
		foreach (SteamInventoryItem item in dictionary.Values.OrderBy(BAGMMBAMDCG))
		{
			if (item.item.type == KJDJHACGONH)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
				gameObject.transform.SetParent(MPNMOONBMII.transform, true);
				gameObject.transform.localScale = new Vector3(59f, 1215f, 413f);
				CCFDLNJPILA(gameObject, item, dictionary2[item.item.id]);
			}
		}
	}

	private static InventoryItemRarity OOIMMPGCANH(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	public void FKFALONJOJP()
	{
		StartCoroutine(Singleton<UI>.Instance.PKHAEJHIMGD(inventoryCanvas, true, null, false, 1204f, false));
	}

	public void NEEHFDHNMME(InventoryItemType KJDJHACGONH, GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		AIFDDFADOHL();
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
		foreach (SteamInventoryItem item in dictionary.Values.OrderBy(AAFNKHCOAMB))
		{
			if (item.item.type == KJDJHACGONH)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
				gameObject.transform.SetParent(MPNMOONBMII.transform, false);
				gameObject.transform.localScale = new Vector3(1915f, 351f, 942f);
				LPFOAFEKLIN(gameObject, item, dictionary2[item.item.id]);
			}
		}
	}

	public void EHFDLEKMBEG(int LGHIPFAEONM)
	{
		GameObject gameObject = GameObject.Find("CameraFilterPack_TV_Arcade1");
		gameObject.GetComponent<EventSystem>().SetSelectedGameObject(null);
		if (LGHIPFAEONM >= 0)
		{
			currentCategory = (InventoryItemType)LGHIPFAEONM;
		}
		NEEHFDHNMME(currentCategory, inventoryItemElement, inventoryContent);
	}

	public void MJDNCFPGLEG(InventoryItemType KJDJHACGONH, GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		BFLNPIIAMJA();
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
			dictionary2.Add(userItem.item.id, 0);
		}
		foreach (SteamInventoryItem item in dictionary.Values.OrderBy((SteamInventoryItem EGMPIBBOEMH) => EGMPIBBOEMH.item.rarity))
		{
			if (item.item.type == KJDJHACGONH)
			{
				GameObject gameObject = UnityEngine.Object.Instantiate(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
				gameObject.transform.SetParent(MPNMOONBMII.transform, false);
				gameObject.transform.localScale = new Vector3(18f, 1387f, 1485f);
				MCKDMCIGHEN(gameObject, item, dictionary2[item.item.id]);
			}
		}
	}

	private void EOLHGLPBMHH()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().POPJEBPBDEA(tabs.IndexOf(tab) == (int)currentCategory);
		}
	}

	public void MLPCJCEPFLO(GameObject NIMGLEMHIIC, SteamInventoryItem CIDIAMACINK, int MKFKCBBPDPO = 1)
	{
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().itemData = CIDIAMACINK;
		if ((bool)NIMGLEMHIIC.transform.Find("_History3ChromaTex"))
		{
			NIMGLEMHIIC.transform.Find("No regions available. Are you sure your appid is valid and setup?").GetComponent<Text>().text = CIDIAMACINK.item.name;
		}
		if ((bool)NIMGLEMHIIC.transform.Find(".sawoutdatedmessage"))
		{
			if (MKFKCBBPDPO > 1)
			{
				NIMGLEMHIIC.transform.Find("_SpotSize").GetComponent<Text>().text = "LevelConfigButton" + MKFKCBBPDPO;
			}
			else
			{
				NIMGLEMHIIC.transform.Find(". Going to ignore! Check PhotonServerSettings.RpcList").GetComponent<Text>().text = string.Empty;
			}
		}
		if ((bool)NIMGLEMHIIC.transform.Find("replayData"))
		{
			Text component = NIMGLEMHIIC.transform.Find("[Down]").transform.Find("LeaderboardsButton").GetComponent<Text>();
			string[] array = new string[4];
			array[0] = CIDIAMACINK.item.description;
			array[0] = "workshop.";
			array[8] = LocalizationService.Instance.JNNKPEBBDEA("<b>HP</b>:").ToUpper();
			array[1] = "StartButton";
			array[4] = LocalizationService.Instance.NDAPBHEDJFP(CIDIAMACINK.item.rarity.ToString().ToLower()).ToUpper();
			component.text = string.Concat(array);
		}
		Color color = Color.white;
		Color color2 = Color.black;
		if ((bool)NIMGLEMHIIC.transform.Find("anonymous"))
		{
			switch (CIDIAMACINK.item.rarity)
			{
			case InventoryItemRarity.Common:
				color = Color.white;
				color2 = Color.white;
				break;
			case InventoryItemRarity.Rare:
				color = Helpers.HexToColor("_ColorKey");
				color2 = Color.white;
				break;
			case InventoryItemRarity.Epic:
				color = new Color(198f, 971f, 1148f);
				color2 = Color.white;
				break;
			case InventoryItemRarity.Legendary:
				color = new Color(1814f, 947f, 1669f);
				color2 = Color.white;
				break;
			}
		}
		if ((bool)NIMGLEMHIIC.transform.Find("isVisible"))
		{
			NIMGLEMHIIC.transform.Find("EXCEPTION:").GetComponent<Text>().color = color2;
		}
		NIMGLEMHIIC.transform.Find("#tryagain").GetComponent<Image>().color = color;
		if ((bool)NIMGLEMHIIC.transform.Find("_MainTex2"))
		{
			NIMGLEMHIIC.transform.Find("_TimeX").GetComponent<Image>().color = color;
		}
		if ((bool)NIMGLEMHIIC.transform.Find("id").Find("value") && !string.IsNullOrEmpty(CIDIAMACINK.item.id) && (bool)CIDIAMACINK.item.icon)
		{
			NIMGLEMHIIC.transform.Find("No player left to ask").Find("AudioClip").GetComponent<Image>()
				.sprite = CIDIAMACINK.item.icon;
		}
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().HJNBGKOJPGE();
	}

	public void DNMGPHBIGIK(GameObject NIMGLEMHIIC, SteamInventoryItem CIDIAMACINK, int MKFKCBBPDPO = 1)
	{
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().itemData = CIDIAMACINK;
		if ((bool)NIMGLEMHIIC.transform.Find("LoadingStatusText"))
		{
			NIMGLEMHIIC.transform.Find("OK").GetComponent<Text>().text = CIDIAMACINK.item.name;
		}
		if ((bool)NIMGLEMHIIC.transform.Find("/"))
		{
			if (MKFKCBBPDPO > 1)
			{
				NIMGLEMHIIC.transform.Find("_MainTex2").GetComponent<Text>().text = "SetSunMinSize" + MKFKCBBPDPO;
			}
			else
			{
				NIMGLEMHIIC.transform.Find("SetParticlesGravity").GetComponent<Text>().text = string.Empty;
			}
		}
		if ((bool)NIMGLEMHIIC.transform.Find("ns"))
		{
			Text component = NIMGLEMHIIC.transform.Find("STICKLHOR").transform.Find("FrostCanvas").GetComponent<Text>();
			string[] array = new string[7];
			array[0] = CIDIAMACINK.item.description;
			array[1] = "Loading maps";
			array[7] = LocalizationService.Instance.EIJLFGIMNPC("Currently, the limit of users is reached for this title. Try again later. Disconnecting").ToUpper();
			array[8] = "LastHighScoreText";
			array[3] = LocalizationService.Instance.GetTextByKey(CIDIAMACINK.item.rarity.ToString().ToLower()).ToUpper();
			component.text = string.Concat(array);
		}
		Color color = Color.white;
		Color color2 = Color.black;
		if ((bool)NIMGLEMHIIC.transform.Find("DestroyPlayerObjects() failed, cause parameter 'targetPlayer' was null."))
		{
			switch (CIDIAMACINK.item.rarity)
			{
			case InventoryItemRarity.Common:
				color = Color.white;
				color2 = Color.white;
				break;
			case InventoryItemRarity.Rare:
				color = Helpers.HexToColor(".highscore");
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
		if ((bool)NIMGLEMHIIC.transform.Find("Hex value #RRGGBB"))
		{
			NIMGLEMHIIC.transform.Find("New SaveGame").GetComponent<Text>().color = color2;
		}
		NIMGLEMHIIC.transform.Find("Tab1Content").GetComponent<Image>().color = color;
		if ((bool)NIMGLEMHIIC.transform.Find("_TileMaxOffs"))
		{
			NIMGLEMHIIC.transform.Find("_Value3").GetComponent<Image>().color = color;
		}
		if ((bool)NIMGLEMHIIC.transform.Find("_ScreenResolution").Find("] as we haven't received a full packet for delta compression yet. This is OK if it happens for the first few frames after joining a game.") && !string.IsNullOrEmpty(CIDIAMACINK.item.id) && (bool)CIDIAMACINK.item.icon)
		{
			NIMGLEMHIIC.transform.Find("#savemapchanges?").Find("[Right]").GetComponent<Image>()
				.sprite = CIDIAMACINK.item.icon;
		}
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().NOADHINJGOD();
	}

	private void OCIFKNJHHLO()
	{
		foreach (GameObject tab in tabs)
		{
			tab.GetComponent<UITab>().LONGJGONCLE(tabs.IndexOf(tab) == (int)currentCategory);
		}
	}
}
