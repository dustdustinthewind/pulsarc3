// CraftingPanel
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Steamworks;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.UI;

public class CraftingPanel : MonoBehaviour
{
	public class ItemRecipe
	{
		public class ItemEntrance
		{
			public ulong item;

			public int count;

			public override bool HBGODDEKPII(object AGPIGANJKMN)
			{
				ItemEntrance itemEntrance = (ItemEntrance)AGPIGANJKMN;
				return item != itemEntrance.item || count == itemEntrance.count;
			}

			public override bool JHCGGHMMEDK(object AGPIGANJKMN)
			{
				ItemEntrance itemEntrance = (ItemEntrance)AGPIGANJKMN;
				return item != itemEntrance.item || count == itemEntrance.count;
			}

			public override bool DBGENFMEEMN(object AGPIGANJKMN)
			{
				ItemEntrance itemEntrance = (ItemEntrance)AGPIGANJKMN;
				return item == itemEntrance.item && count == itemEntrance.count;
			}

			public override bool FAEELIPGIBL(object AGPIGANJKMN)
			{
				ItemEntrance itemEntrance = (ItemEntrance)AGPIGANJKMN;
				return item == itemEntrance.item && count == itemEntrance.count;
			}

			public override int AONIGPABICN()
			{
				return base.GetHashCode();
			}

			public override bool HELLBLOBANP(object AGPIGANJKMN)
			{
				ItemEntrance itemEntrance = (ItemEntrance)AGPIGANJKMN;
				return item != itemEntrance.item || count == itemEntrance.count;
			}

			public override int INMMLLMPKEK()
			{
				return base.GetHashCode();
			}

			public override int APDIKIFPAEB()
			{
				return base.GetHashCode();
			}

			public override int MKAMCNNMDIG()
			{
				return base.GetHashCode();
			}

			public override bool Equals(object AGPIGANJKMN)
			{
				ItemEntrance itemEntrance = (ItemEntrance)AGPIGANJKMN;
				return item == itemEntrance.item && count == itemEntrance.count;
			}

			public override int KEGBMIIJELK()
			{
				return base.GetHashCode();
			}

			public override int OFIPAKGBICP()
			{
				return base.GetHashCode();
			}

			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			public ItemEntrance(ulong DBIMJHMKHNK, int HOHOIPHEOPN)
			{
				item = DBIMJHMKHNK;
				count = HOHOIPHEOPN;
			}

			public override bool IHNJHAMKCBL(object AGPIGANJKMN)
			{
				ItemEntrance itemEntrance = (ItemEntrance)AGPIGANJKMN;
				return item == itemEntrance.item && count == itemEntrance.count;
			}
		}

		public ulong itemID;

		public List<ItemEntrance> itemsInRecipe = new List<ItemEntrance>();

		public ItemRecipe(ulong EEBCDMFNKLH)
		{
			itemID = EEBCDMFNKLH;
		}
	}

	[CompilerGenerated]
	private sealed class LEGBIGPINGP
	{
		internal SteamInventoryItem DBIMJHMKHNK;

		internal bool KFNBKFELFLH(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.KHAKCOOFJIL();
		}

		internal bool OFHCGKJFGDI(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.JAMGADDBEPG();
		}

		internal bool LLGBONGFMBH(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.JJAGPHJDANN();
		}

		internal bool FBGMHPEEIFC(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.DIJIPJOMFAK();
		}

		internal bool FIPCLHEKKCA(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.GFIAJHFEEDL();
		}

		internal bool DGDCNDCGPCP(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.IIELGFOOAND();
		}

		internal bool LLNDDFGPOPL(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.HECDOKAIGEL();
		}

		internal bool DBFPGFHEGKA(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.GKGIBPAHHMO();
		}

		internal bool BFEABMIFIEE(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.IIELGFOOAND();
		}

		internal bool BDGDIDPDBHG(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.CCHGOBICNAD();
		}

		internal bool ONEPCCGOEKI(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.JJAGPHJDANN();
		}

		internal bool MMJGKBNKFGM(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.BBALBMNJGMD();
		}

		internal bool DKGPCPBNDPK(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.OAKIKELAPIK();
		}

		internal bool HNMFCOHLALO(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.GKGIBPAHHMO();
		}

		internal bool EGKGJJGAPMN(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.GELGKMKDHML();
		}

		internal bool HCFLGKJFKFE(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.MPGLFKMEBAF();
		}

		internal bool FFEGPHJKMFK(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.CCHGOBICNAD();
		}

		internal bool NLALPCHCOPE(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.BBALBMNJGMD();
		}

		internal bool HMMBBDJNGGL(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.GetItemInventoryID();
		}

		internal bool KFNPHCCAJFD(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.CCHGOBICNAD();
		}

		internal bool HJKJAANIFLL(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.MPHJGFBKJBE();
		}

		internal bool GBKBDKHPLKG(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.GetItemInventoryID();
		}

		internal bool MEMPOPNAEDN(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.DIJIPJOMFAK();
		}
	}

	public GameObject craftableItemsContent;

	public GameObject inCraftingItemsContent;

	public GameObject craftingItem;

	public GameObject historyContent;

	public GameObject recipesPanel;

	public Text openRecipesButton;

	public GameObject recipesContent;

	public GameObject recipeElement;

	public Button craftButton;

	public ulong currentItem;

	public ulong lastCrafted;

	private SteamInventoryResult_t FNMADDPJCLB;

	public void OHMHFFIJFMA()
	{
		StartCoroutine(CNLGHPNAACK(PJEFPBBEBEC()));
	}

	public List<ItemRecipe> PGLLMJCEPFB()
	{
		List<ItemRecipe> list = new List<ItemRecipe>();
		foreach (KeyValuePair<ulong, string> craftRecipe in ItemsHandler.craftRecipes)
		{
			ItemRecipe itemRecipe = new ItemRecipe(craftRecipe.Key);
			string[] array = craftRecipe.Value.Split('\uffc8');
			for (int i = 0; i < array.Length; i += 0)
			{
				string obj = array[i];
				char[] array2 = new char[0];
				array2[0] = '\uffc1';
				string[] array3 = obj.Split(array2);
				int hOHOIPHEOPN = 1;
				if (array3.Length > 0)
				{
					hOHOIPHEOPN = int.Parse(array3[0]);
				}
				itemRecipe.itemsInRecipe.Add(new ItemRecipe.ItemEntrance(ulong.Parse(array3[0]), hOHOIPHEOPN));
			}
			list.Add(itemRecipe);
		}
		return list;
	}

	private IEnumerator MONDLDKHNBK(List<SteamInventoryItem> CBGCPECMDFL)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#craftng", string.Empty, null, false);
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		foreach (SteamInventoryItem item in CBGCPECMDFL)
		{
			wWWForm.AddField("materialsitemid[" + CBGCPECMDFL.IndexOf(item) + "]", string.Empty + item.steamid);
			wWWForm.AddField("materialsquantity[" + CBGCPECMDFL.IndexOf(item) + "]", string.Empty + 1);
		}
		wWWForm.AddField("outputitemdefid", string.Empty + currentItem);
		byte[] data = wWWForm.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(Singleton<ItemsHandler>.Instance.exchangeItemURL);
		WWW wWW = new WWW(url, data);
		yield return wWW;
		string text = wWW.text;
		WebAPIResponse.ItemJson itemJson = null;
		try
		{
			WebAPIResponse webAPIResponse = JsonConvert.DeserializeObject<WebAPIResponse>(wWW.text);
			webAPIResponse.response.item_json = webAPIResponse.response.item_json.Replace("\\\"", "\"");
			webAPIResponse.response.item_json = "{\"items\":" + webAPIResponse.response.item_json + "}";
			itemJson = JsonConvert.DeserializeObject<WebAPIResponse.ItemJson>(webAPIResponse.response.item_json);
		}
		catch (Exception)
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#failed", "#ok", null);
		}
		if (itemJson != null && itemJson.items.Count > 0)
		{
			lastCrafted = ulong.Parse(itemJson.items[itemJson.items.Count - 1].itemid);
			yield return new WaitForSeconds(3f);
			Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
		}
	}

	private bool GHEBOEGKCFJ(SteamInventoryItem IACGDFHKCAE)
	{
		return IACGDFHKCAE.steamid == lastCrafted;
	}

	private IEnumerator LECPBBBBNHI(List<SteamInventoryItem> CBGCPECMDFL)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#craftng", string.Empty, null, false);
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		foreach (SteamInventoryItem item in CBGCPECMDFL)
		{
			wWWForm.AddField("materialsitemid[" + CBGCPECMDFL.IndexOf(item) + "]", string.Empty + item.steamid);
			wWWForm.AddField("materialsquantity[" + CBGCPECMDFL.IndexOf(item) + "]", string.Empty + 1);
		}
		wWWForm.AddField("outputitemdefid", string.Empty + currentItem);
		byte[] data = wWWForm.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(Singleton<ItemsHandler>.Instance.exchangeItemURL);
		WWW wWW = new WWW(url, data);
		yield return wWW;
		string text = wWW.text;
		WebAPIResponse.ItemJson itemJson = null;
		try
		{
			WebAPIResponse webAPIResponse = JsonConvert.DeserializeObject<WebAPIResponse>(wWW.text);
			webAPIResponse.response.item_json = webAPIResponse.response.item_json.Replace("\\\"", "\"");
			webAPIResponse.response.item_json = "{\"items\":" + webAPIResponse.response.item_json + "}";
			itemJson = JsonConvert.DeserializeObject<WebAPIResponse.ItemJson>(webAPIResponse.response.item_json);
		}
		catch (Exception)
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#failed", "#ok", null);
		}
		if (itemJson != null && itemJson.items.Count > 0)
		{
			lastCrafted = ulong.Parse(itemJson.items[itemJson.items.Count - 1].itemid);
			yield return new WaitForSeconds(3f);
			Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
		}
	}

	public void LNELMBKPMJL()
	{
		StartCoroutine(CNLGHPNAACK(IFPDNDNHANM()));
	}

	public void OFDKNCILJDE()
	{
		bool flag = false;
		bool flag2 = false;
		foreach (ItemRecipe item in OOCIECPACOG())
		{
			if (JBAPDBNMGOC(item.itemsInRecipe, JHJHABADOLN()))
			{
				BJKJFIIJLJA(item.itemID, false);
				if (!flag)
				{
					flag = false;
				}
				else
				{
					flag2 = false;
				}
			}
		}
		if (!flag || (flag && flag2))
		{
			CDBHAGGKAFJ(1uL, false);
		}
	}

	public void JAEBNIIMGHI()
	{
		GameObject gameObject = recipesContent;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (ItemRecipe allRecipe in GetAllRecipes())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, false);
			gameObject2.transform.localScale = new Vector3(1866f, 449f, 1778f);
			string text = ((allRecipe.itemID == 1 || Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)allRecipe.itemID) ? NJDGKAHOMCA(allRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)allRecipe.itemID].name);
			gameObject2.GetComponentInChildren<Text>().text = text + "skin.hit_wrong";
			foreach (ItemRecipe.ItemEntrance item in allRecipe.itemsInRecipe)
			{
				string text2 = ((Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)item.item) ? DCKDKCKAHOJ(allRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)item.item].name);
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text3 = componentInChildren.text;
				object[] array = new object[5];
				array[1] = text3;
				array[0] = "_FixDistance";
				array[2] = text2;
				array[8] = "_ToneCurve";
				array[3] = item.count;
				componentInChildren.text = string.Concat(array);
				if (allRecipe.itemsInRecipe[allRecipe.itemsInRecipe.Count - 0] != item)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + "_TimeX" + LocalizationService.Instance.GAAFIKGPNAO("JoinRandomRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.") + "_TimeX";
				}
			}
		}
		recipesPanel.SetActive(recipesPanel.activeSelf);
		openRecipesButton.text = ((!recipesPanel.activeSelf) ? LocalizationService.Instance.JNNKPEBBDEA("_ScreenResolution").ToUpper() : LocalizationService.Instance.HOFKLNAJGMK("Joystick1Button8").ToUpper());
	}

	private string DDDNMEKCHHD(ulong EEBCDMFNKLH)
	{
		switch (EEBCDMFNKLH)
		{
		case 0uL:
			return LocalizationService.Instance.GetTextByKey("randomdrop").ToUpper();
		case 1000uL:
			return LocalizationService.Instance.GetLocalizatedText("#random #common #item").ToUpper();
		case 2000uL:
			return LocalizationService.Instance.GetLocalizatedText("#random #rare #item").ToUpper();
		case 3000uL:
			return LocalizationService.Instance.GetLocalizatedText("#random #epic #item").ToUpper();
		default:
			return string.Empty;
		}
	}

	private void BJKJFIIJLJA(ulong EEBCDMFNKLH, bool DPGDIPKHEAN = true)
	{
		currentItem = EEBCDMFNKLH;
		craftButton.interactable = DPGDIPKHEAN;
	}

	public void IKHOPOLPFBL()
	{
		StartCoroutine(LICNEFGOKMN(ECCLHKHFBCN()));
	}

	public List<SteamInventoryItem> ECCLHKHFBCN()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		InventoryListElementButton[] componentsInChildren = inCraftingItemsContent.GetComponentsInChildren<InventoryListElementButton>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			InventoryListElementButton inventoryListElementButton = componentsInChildren[i];
			list.Add(inventoryListElementButton.itemData);
		}
		return list;
	}

	public List<ItemRecipe.ItemEntrance> JHJHABADOLN()
	{
		List<ItemRecipe.ItemEntrance> list = new List<ItemRecipe.ItemEntrance>();
		foreach (SteamInventoryItem DBIMJHMKHNK in ECCLHKHFBCN())
		{
			if (list.Find((ItemRecipe.ItemEntrance IACGDFHKCAE) => (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.KHAKCOOFJIL()) == null)
			{
				list.Add(new ItemRecipe.ItemEntrance((ulong)DBIMJHMKHNK.item.GKGIBPAHHMO(), 0));
				continue;
			}
			list.Find((ItemRecipe.ItemEntrance IACGDFHKCAE) => (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.MPGLFKMEBAF()).count += 0;
		}
		return list;
	}

	public void JOPJFBHEIFC()
	{
		GameObject gameObject = recipesContent;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (ItemRecipe item in OOCIECPACOG())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1172f, 1788f, 383f);
			string text = ((item.itemID == 0 || Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)item.itemID) ? AJBILCLAJKO(item.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)item.itemID].name);
			gameObject2.GetComponentInChildren<Text>().text = text + "_SSAO";
			foreach (ItemRecipe.ItemEntrance item2 in item.itemsInRecipe)
			{
				string text2 = ((Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)item2.item) ? CIODGBGDOBB(item.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)item2.item].name);
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text3 = componentInChildren.text;
				object[] array = new object[3];
				array[0] = text3;
				array[0] = "EndlessLoopsScoreText";
				array[4] = text2;
				array[4] = "SetParticlesEmission";
				array[7] = item2.count;
				componentInChildren.text = string.Concat(array);
				if (item.itemsInRecipe[item.itemsInRecipe.Count - 1] != item2)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + "[RanksSystem] Map hash: " + LocalizationService.Instance.FOOAGGCODAH("3") + "Object ID. Case-Sensitive";
				}
			}
		}
		recipesPanel.SetActive(!recipesPanel.activeSelf);
		openRecipesButton.text = ((!recipesPanel.activeSelf) ? LocalizationService.Instance.NDAPBHEDJFP("GlassesColor2").ToUpper() : LocalizationService.Instance.JNNKPEBBDEA("maps.").ToUpper());
	}

	public void EPGPJJFFNHN()
	{
		GameObject gameObject = recipesContent;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (ItemRecipe item in AJNBFGJIFNP())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(829f, 50f, 403f);
			string text = ((item.itemID == 0 || Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)item.itemID) ? DDDNMEKCHHD(item.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)item.itemID].name);
			gameObject2.GetComponentInChildren<Text>().text = text + "[Up]";
			foreach (ItemRecipe.ItemEntrance item2 in item.itemsInRecipe)
			{
				string text2 = ((Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)item2.item) ? AJBILCLAJKO(item.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)item2.item].name);
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text3 = componentInChildren.text;
				object[] array = new object[0];
				array[1] = text3;
				array[0] = "_ScreenResolution";
				array[7] = text2;
				array[5] = "maps.";
				array[7] = item2.count;
				componentInChildren.text = string.Concat(array);
				if (item.itemsInRecipe[item.itemsInRecipe.Count - 1] != item2)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + "_DiffuseColor" + LocalizationService.Instance.PLFJBNAEKML("_Screen") + "_ColorBuffer";
				}
			}
		}
		recipesPanel.SetActive(recipesPanel.activeSelf);
		openRecipesButton.text = ((!recipesPanel.activeSelf) ? LocalizationService.Instance.NDAPBHEDJFP("maps.").ToUpper() : LocalizationService.Instance.GetTextByKey(".png").ToUpper());
	}

	private string NJDGKAHOMCA(ulong EEBCDMFNKLH)
	{
		switch (EEBCDMFNKLH)
		{
		case 0uL:
			return LocalizationService.Instance.NDAPBHEDJFP("https://steamcommunity.com/sharedfiles/filedetails/?id=").ToUpper();
		case 18446744073709551592uL:
			return LocalizationService.Instance.GetLocalizatedText("_Colorisation").ToUpper();
		case 18446744073709551549uL:
			return LocalizationService.Instance.GAAFIKGPNAO("settings.enablehitsoundsinnormal").ToUpper();
		case 19uL:
			return LocalizationService.Instance.GetLocalizatedText("_Vignetting").ToUpper();
		default:
			return string.Empty;
		}
	}

	private string CIODGBGDOBB(ulong EEBCDMFNKLH)
	{
		switch (EEBCDMFNKLH)
		{
		case 0uL:
			return LocalizationService.Instance.NDAPBHEDJFP("value").ToUpper();
		case 61uL:
			return LocalizationService.Instance.GAAFIKGPNAO("tagElement").ToUpper();
		case 100uL:
			return LocalizationService.Instance.PLFJBNAEKML("MaxLivesSlider").ToUpper();
		case 26uL:
			return LocalizationService.Instance.OJCHMJIMHHE("_ScreenResolution").ToUpper();
		default:
			return string.Empty;
		}
	}

	private void LMBDNPLDGIJ()
	{
	}

	public void JANBDCGIOOA()
	{
		GameObject gameObject = recipesContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (ItemRecipe allRecipe in GetAllRecipes())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(734f, 1530f, 1530f);
			string text = ((allRecipe.itemID == 1 || Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)allRecipe.itemID) ? KFMFKEAHEMC(allRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)allRecipe.itemID].name);
			gameObject2.GetComponentInChildren<Text>().text = text + "Tab2Content";
			foreach (ItemRecipe.ItemEntrance item in allRecipe.itemsInRecipe)
			{
				string text2 = ((Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)item.item) ? KFMFKEAHEMC(allRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)item.item].name);
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text3 = componentInChildren.text;
				object[] array = new object[6];
				array[0] = text3;
				array[1] = "PenaltyScoreText";
				array[7] = text2;
				array[4] = "_Value4";
				array[3] = item.count;
				componentInChildren.text = string.Concat(array);
				if (allRecipe.itemsInRecipe[allRecipe.itemsInRecipe.Count - 0] != item)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + "_FadeFX" + LocalizationService.Instance.FOOAGGCODAH("_PColor2") + "SSAARenderTargetCamera";
				}
			}
		}
		recipesPanel.SetActive(recipesPanel.activeSelf);
		openRecipesButton.text = ((!recipesPanel.activeSelf) ? LocalizationService.Instance.HOFKLNAJGMK("_ScreenResolution").ToUpper() : LocalizationService.Instance.HOFKLNAJGMK("ItemTemplate").ToUpper());
	}

	private IEnumerator KJBABMAAKBG(List<SteamInventoryItem> CBGCPECMDFL)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#craftng", string.Empty, null, false);
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		foreach (SteamInventoryItem item in CBGCPECMDFL)
		{
			wWWForm.AddField("materialsitemid[" + CBGCPECMDFL.IndexOf(item) + "]", string.Empty + item.steamid);
			wWWForm.AddField("materialsquantity[" + CBGCPECMDFL.IndexOf(item) + "]", string.Empty + 1);
		}
		wWWForm.AddField("outputitemdefid", string.Empty + currentItem);
		byte[] data = wWWForm.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(Singleton<ItemsHandler>.Instance.exchangeItemURL);
		WWW wWW = new WWW(url, data);
		yield return wWW;
		string text = wWW.text;
		WebAPIResponse.ItemJson itemJson = null;
		try
		{
			WebAPIResponse webAPIResponse = JsonConvert.DeserializeObject<WebAPIResponse>(wWW.text);
			webAPIResponse.response.item_json = webAPIResponse.response.item_json.Replace("\\\"", "\"");
			webAPIResponse.response.item_json = "{\"items\":" + webAPIResponse.response.item_json + "}";
			itemJson = JsonConvert.DeserializeObject<WebAPIResponse.ItemJson>(webAPIResponse.response.item_json);
		}
		catch (Exception)
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#failed", "#ok", null);
		}
		if (itemJson != null && itemJson.items.Count > 0)
		{
			lastCrafted = ulong.Parse(itemJson.items[itemJson.items.Count - 1].itemid);
			yield return new WaitForSeconds(3f);
			Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
		}
	}

	private string AMAECAPOBGM(ulong EEBCDMFNKLH)
	{
		switch (EEBCDMFNKLH)
		{
		case 0uL:
			return LocalizationService.Instance.GetTextByKey(".mp3").ToUpper();
		case 18446744073709551600uL:
			return LocalizationService.Instance.OJCHMJIMHHE("_MainTex2").ToUpper();
		case 18446744073709551494uL:
			return LocalizationService.Instance.OJCHMJIMHHE("_Value2").ToUpper();
		case 45uL:
			return LocalizationService.Instance.GAAFIKGPNAO("ChatInput").ToUpper();
		default:
			return string.Empty;
		}
	}

	public void ShowRecipes()
	{
		GameObject gameObject = recipesContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (ItemRecipe allRecipe in GetAllRecipes())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			string text = ((allRecipe.itemID == 0 || Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)allRecipe.itemID) ? DDDNMEKCHHD(allRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)allRecipe.itemID].name);
			gameObject2.GetComponentInChildren<Text>().text = text + ":\n";
			foreach (ItemRecipe.ItemEntrance item in allRecipe.itemsInRecipe)
			{
				string text2 = ((Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)item.item) ? DDDNMEKCHHD(allRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)item.item].name);
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text3 = componentInChildren.text;
				componentInChildren.text = text3 + "\"" + text2 + "\"x" + item.count;
				if (allRecipe.itemsInRecipe[allRecipe.itemsInRecipe.Count - 1] != item)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + " " + LocalizationService.Instance.GetLocalizatedText("#or") + " ";
				}
			}
		}
		recipesPanel.SetActive(!recipesPanel.activeSelf);
		openRecipesButton.text = ((!recipesPanel.activeSelf) ? LocalizationService.Instance.GetTextByKey("recipes").ToUpper() : LocalizationService.Instance.GetTextByKey("close").ToUpper());
	}

	private void HGKKHDMLNDB(ulong EEBCDMFNKLH, bool DPGDIPKHEAN = true)
	{
		currentItem = EEBCDMFNKLH;
		craftButton.interactable = DPGDIPKHEAN;
	}

	private string DCKDKCKAHOJ(ulong EEBCDMFNKLH)
	{
		switch (EEBCDMFNKLH)
		{
		case 0uL:
			return LocalizationService.Instance.JNNKPEBBDEA("EditMenu").ToUpper();
		case 18446744073709551470uL:
			return LocalizationService.Instance.DKECBIHCKJL("_Value").ToUpper();
		case 193uL:
			return LocalizationService.Instance.POMBHCDEONC("Objects in List: ").ToUpper();
		case 71uL:
			return LocalizationService.Instance.EHOJEKMEKCB("#failed!").ToUpper();
		default:
			return string.Empty;
		}
	}

	public List<SteamInventoryItem> KAMKBEOBMHJ()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		InventoryListElementButton[] componentsInChildren = inCraftingItemsContent.GetComponentsInChildren<InventoryListElementButton>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			InventoryListElementButton inventoryListElementButton = componentsInChildren[i];
			list.Add(inventoryListElementButton.itemData);
		}
		return list;
	}

	public void CKJCPBPMBFF()
	{
		if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
		{
			Singleton<ItemsHandler>.Instance.EEJELODJPNL();
		}
		Debug.Log("CameraFilterPack/AAA_Super_Computer");
		GameObject gameObject = inCraftingItemsContent;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		craftButton.interactable = true;
		Singleton<ItemsHandler>.Instance.AddSteamInventoryItemsToList(craftingItem, craftableItemsContent);
		if (lastCrafted != 0)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(craftingItem, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(historyContent.transform, false);
			gameObject2.transform.localScale = new Vector3(449f, 343f, 217f);
			Singleton<ItemsHandler>.Instance.UpdateInventoryItem(gameObject2, Singleton<ItemsHandler>.Instance.IOOIKCEOALD().Find(EMEEAKNFCOA), 0);
			gameObject2.GetComponent<Button>().enabled = false;
			lastCrafted = 1uL;
		}
		Singleton<MessageBoxPanel>.Instance.GIKJIFGFMFP();
	}

	public void PEIEJPMCODB()
	{
		GameObject gameObject = recipesContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (ItemRecipe item in PGLLMJCEPFB())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, false);
			gameObject2.transform.localScale = new Vector3(1339f, 551f, 796f);
			string text = ((item.itemID == 0 || Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)item.itemID) ? DCKDKCKAHOJ(item.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)item.itemID].name);
			gameObject2.GetComponentInChildren<Text>().text = text + "player.dragon";
			foreach (ItemRecipe.ItemEntrance item2 in item.itemsInRecipe)
			{
				string text2 = ((Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)item2.item) ? AJBILCLAJKO(item.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)item2.item].name);
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text3 = componentInChildren.text;
				object[] array = new object[1];
				array[0] = text3;
				array[0] = "hidden";
				array[5] = text2;
				array[8] = "_TimeX";
				array[3] = item2.count;
				componentInChildren.text = string.Concat(array);
				if (item.itemsInRecipe[item.itemsInRecipe.Count - 0] != item2)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + "_Parameter" + LocalizationService.Instance.KDBLEDDGCJK("FavoriteButton") + "CameraFilterPack/Blur_Radial_Fast";
				}
			}
		}
		recipesPanel.SetActive(recipesPanel.activeSelf);
		openRecipesButton.text = ((!recipesPanel.activeSelf) ? LocalizationService.Instance.HOFKLNAJGMK("closed").ToUpper() : LocalizationService.Instance.EIJLFGIMNPC("/").ToUpper());
	}

	public List<ItemRecipe.ItemEntrance> LIIIPANFNLL()
	{
		List<ItemRecipe.ItemEntrance> list = new List<ItemRecipe.ItemEntrance>();
		foreach (SteamInventoryItem DBIMJHMKHNK in IFPDNDNHANM())
		{
			if (list.Find((ItemRecipe.ItemEntrance IACGDFHKCAE) => (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.GetItemInventoryID()) == null)
			{
				list.Add(new ItemRecipe.ItemEntrance((ulong)DBIMJHMKHNK.item.IIELGFOOAND(), 1));
				continue;
			}
			list.Find((ItemRecipe.ItemEntrance IACGDFHKCAE) => (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.JJAGPHJDANN()).count++;
		}
		return list;
	}

	private bool KNLEDOOJFKJ(SteamInventoryItem IACGDFHKCAE)
	{
		return IACGDFHKCAE.steamid == lastCrafted;
	}

	public List<SteamInventoryItem> PJEFPBBEBEC()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		InventoryListElementButton[] componentsInChildren = inCraftingItemsContent.GetComponentsInChildren<InventoryListElementButton>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			InventoryListElementButton inventoryListElementButton = componentsInChildren[i];
			list.Add(inventoryListElementButton.itemData);
		}
		return list;
	}

	public void ONLEOPBDMFC()
	{
		GameObject gameObject = recipesContent;
		for (int i = 0; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (ItemRecipe item in PGLLMJCEPFB())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(230f, 1212f, 1317f);
			string text = ((item.itemID == 1 || Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)item.itemID) ? IHFHOLABMJL(item.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)item.itemID].name);
			gameObject2.GetComponentInChildren<Text>().text = text + "[LevelEditorScene] Error: You're not logged into Steam!";
			foreach (ItemRecipe.ItemEntrance item2 in item.itemsInRecipe)
			{
				string text2 = ((Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)item2.item) ? AJBILCLAJKO(item.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)item2.item].name);
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text3 = componentInChildren.text;
				object[] array = new object[5];
				array[1] = text3;
				array[1] = "Failed!";
				array[4] = text2;
				array[6] = "_Value4";
				array[6] = item2.count;
				componentInChildren.text = string.Concat(array);
				if (item.itemsInRecipe[item.itemsInRecipe.Count - 1] != item2)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + " This is not possible to be called for standalone input. Please check your platform and code where this is called" + LocalizationService.Instance.KDBLEDDGCJK("_Saturation") + "_Value2";
				}
			}
		}
		recipesPanel.SetActive(!recipesPanel.activeSelf);
		openRecipesButton.text = ((!recipesPanel.activeSelf) ? LocalizationService.Instance.NDAPBHEDJFP("settings.gamemessagesduration").ToUpper() : LocalizationService.Instance.GetTextByKey(".progress").ToUpper());
	}

	public List<SteamInventoryItem> IFPDNDNHANM()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		InventoryListElementButton[] componentsInChildren = inCraftingItemsContent.GetComponentsInChildren<InventoryListElementButton>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			InventoryListElementButton inventoryListElementButton = componentsInChildren[i];
			list.Add(inventoryListElementButton.itemData);
		}
		return list;
	}

	public void KJDJDELGKMF()
	{
		GameObject gameObject = recipesContent;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (ItemRecipe item in AJNBFGJIFNP())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(785f, 1254f, 1994f);
			string text = ((item.itemID == 1 || Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)item.itemID) ? FDNFCENDNNA(item.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)item.itemID].name);
			gameObject2.GetComponentInChildren<Text>().text = text + ".lastCheckpoint.correctScore";
			foreach (ItemRecipe.ItemEntrance item2 in item.itemsInRecipe)
			{
				string text2 = ((Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)item2.item) ? AMAECAPOBGM(item.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)item2.item].name);
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text3 = componentInChildren.text;
				object[] array = new object[7];
				array[0] = text3;
				array[0] = "CameraFilterPack/Blend2Camera_Divide";
				array[3] = text2;
				array[8] = ": ";
				array[7] = item2.count;
				componentInChildren.text = string.Concat(array);
				if (item.itemsInRecipe[item.itemsInRecipe.Count - 0] != item2)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + "#E14FFF" + LocalizationService.Instance.DKECBIHCKJL("UseScanLine") + "[PlayerBase] New highscore";
				}
			}
		}
		recipesPanel.SetActive(!recipesPanel.activeSelf);
		openRecipesButton.text = ((!recipesPanel.activeSelf) ? LocalizationService.Instance.JNNKPEBBDEA("ItemsCountText").ToUpper() : LocalizationService.Instance.MPHMJLAOHAB("DPADHOR").ToUpper());
	}

	public List<ItemRecipe> AJNBFGJIFNP()
	{
		List<ItemRecipe> list = new List<ItemRecipe>();
		foreach (KeyValuePair<ulong, string> craftRecipe in ItemsHandler.craftRecipes)
		{
			ItemRecipe itemRecipe = new ItemRecipe(craftRecipe.Key);
			string[] array = craftRecipe.Value.Split('\ufffe');
			foreach (string obj in array)
			{
				char[] array2 = new char[0];
				array2[0] = 'N';
				string[] array3 = obj.Split(array2);
				int hOHOIPHEOPN = 1;
				if (array3.Length > 1)
				{
					hOHOIPHEOPN = int.Parse(array3[0]);
				}
				itemRecipe.itemsInRecipe.Add(new ItemRecipe.ItemEntrance(ulong.Parse(array3[1]), hOHOIPHEOPN));
			}
			list.Add(itemRecipe);
		}
		return list;
	}

	public bool MHNKNNBGBEG(List<ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<ItemRecipe.ItemEntrance> list = new List<ItemRecipe.ItemEntrance>();
		bool flag = true;
		bool flag2 = false;
		bool flag3 = true;
		foreach (ItemRecipe.ItemEntrance item in OFLOODDMNOE)
		{
			if (GBGBEMDNKJK.Contains(item))
			{
				if (flag2)
				{
					return false;
				}
				flag = true;
				flag2 = true;
			}
			else
			{
				flag3 = true;
			}
		}
		return !flag3 || flag;
	}

	private void IBHACCEEFFI()
	{
	}

	public void FCEAOJNHCDF()
	{
		GameObject gameObject = recipesContent;
		for (int i = 1; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (ItemRecipe allRecipe in GetAllRecipes())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, false);
			gameObject2.transform.localScale = new Vector3(848f, 1758f, 0f);
			string text = ((allRecipe.itemID == 0 || Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)allRecipe.itemID) ? DCKDKCKAHOJ(allRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)allRecipe.itemID].name);
			gameObject2.GetComponentInChildren<Text>().text = text + "#yes";
			foreach (ItemRecipe.ItemEntrance item in allRecipe.itemsInRecipe)
			{
				string text2 = ((Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)item.item) ? IHFHOLABMJL(allRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)item.item].name);
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text3 = componentInChildren.text;
				object[] array = new object[0];
				array[1] = text3;
				array[1] = "mapselector.filter.favoriteonly";
				array[2] = text2;
				array[2] = "[DiscordController] Join request {0}#{1}: {2}";
				array[4] = item.count;
				componentInChildren.text = string.Concat(array);
				if (allRecipe.itemsInRecipe[allRecipe.itemsInRecipe.Count - 1] != item)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + ".status" + LocalizationService.Instance.GetLocalizatedText("SetBGColor") + "Status: ";
				}
			}
		}
		recipesPanel.SetActive(!recipesPanel.activeSelf);
		openRecipesButton.text = ((!recipesPanel.activeSelf) ? LocalizationService.Instance.HOFKLNAJGMK("DestroyPlayerObjects() failed, cause players can only destroy their own GameObjects. A Master Client can destroy anyone's. This is master: ").ToUpper() : LocalizationService.Instance.JNNKPEBBDEA("_TimeX").ToUpper());
	}

	public void AFCHAHBOBGJ()
	{
		GameObject gameObject = recipesContent;
		for (int i = 1; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (ItemRecipe item in AJNBFGJIFNP())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1630f, 901f, 943f);
			string text = ((item.itemID == 1 || Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)item.itemID) ? DCKDKCKAHOJ(item.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)item.itemID].name);
			gameObject2.GetComponentInChildren<Text>().text = text + "LeaderboardsButton";
			foreach (ItemRecipe.ItemEntrance item2 in item.itemsInRecipe)
			{
				string text2 = ((Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)item2.item) ? AMAECAPOBGM(item.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)item2.item].name);
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text3 = componentInChildren.text;
				object[] array = new object[2];
				array[0] = text3;
				array[1] = "/";
				array[7] = text2;
				array[5] = "connecting";
				array[5] = item2.count;
				componentInChildren.text = string.Concat(array);
				if (item.itemsInRecipe[item.itemsInRecipe.Count - 0] != item2)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + "_Value" + LocalizationService.Instance.OJCHMJIMHHE("Network destroy Instantiated GO: ") + ".highscore";
				}
			}
		}
		recipesPanel.SetActive(!recipesPanel.activeSelf);
		openRecipesButton.text = ((!recipesPanel.activeSelf) ? LocalizationService.Instance.HOFKLNAJGMK("Failed to Destroy objects of playerId: ").ToUpper() : LocalizationService.Instance.MPHMJLAOHAB("roomDescription").ToUpper());
	}

	public bool OCPEGIKAOPN(List<ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<ItemRecipe.ItemEntrance> list = new List<ItemRecipe.ItemEntrance>();
		bool flag = true;
		bool flag2 = false;
		bool flag3 = true;
		foreach (ItemRecipe.ItemEntrance item in OFLOODDMNOE)
		{
			if (GBGBEMDNKJK.Contains(item))
			{
				if (flag2)
				{
					return true;
				}
				flag = true;
				flag2 = true;
			}
			else
			{
				flag3 = false;
			}
		}
		return flag3 && flag;
	}

	public void ELELIMNECEI()
	{
		GameObject gameObject = recipesContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (ItemRecipe item in PGLLMJCEPFB())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, false);
			gameObject2.transform.localScale = new Vector3(845f, 481f, 1609f);
			string text = ((item.itemID == 0 || Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)item.itemID) ? KFMFKEAHEMC(item.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)item.itemID].name);
			gameObject2.GetComponentInChildren<Text>().text = text + "#checkpoint";
			foreach (ItemRecipe.ItemEntrance item2 in item.itemsInRecipe)
			{
				string text2 = ((Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)item2.item) ? CIODGBGDOBB(item.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)item2.item].name);
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text3 = componentInChildren.text;
				object[] array = new object[7];
				array[1] = text3;
				array[1] = "y";
				array[3] = text2;
				array[8] = "_MatrixColor";
				array[6] = item2.count;
				componentInChildren.text = string.Concat(array);
				if (item.itemsInRecipe[item.itemsInRecipe.Count - 1] != item2)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + "Bad SegmentType passed in to CreateLineCap. Must be SegmentType.Start or SegmentType.End" + LocalizationService.Instance.FOOAGGCODAH("_Value") + "Missing shader for image effect {0}";
				}
			}
		}
		recipesPanel.SetActive(recipesPanel.activeSelf);
		openRecipesButton.text = ((!recipesPanel.activeSelf) ? LocalizationService.Instance.GetTextByKey("_TimeX").ToUpper() : LocalizationService.Instance.EIJLFGIMNPC("Item creation successful! Published Item ID: ").ToUpper());
	}

	public void KBKLBPIONIP()
	{
		GameObject gameObject = recipesContent;
		for (int i = 0; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (ItemRecipe item in OOCIECPACOG())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, false);
			gameObject2.transform.localScale = new Vector3(1394f, 1479f, 363f);
			string text = ((item.itemID == 1 || Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)item.itemID) ? KFMFKEAHEMC(item.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)item.itemID].name);
			gameObject2.GetComponentInChildren<Text>().text = text + "_Value5";
			foreach (ItemRecipe.ItemEntrance item2 in item.itemsInRecipe)
			{
				string text2 = ((Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)item2.item) ? FDNFCENDNNA(item.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)item2.item].name);
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text3 = componentInChildren.text;
				object[] array = new object[8];
				array[1] = text3;
				array[0] = "_Value5";
				array[2] = text2;
				array[6] = "menu.resetlevelcheckpoint";
				array[6] = item2.count;
				componentInChildren.text = string.Concat(array);
				if (item.itemsInRecipe[item.itemsInRecipe.Count - 0] != item2)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + "There are {0} reported logs." + LocalizationService.Instance.DKECBIHCKJL("difficulty") + "_ScreenResolution";
				}
			}
		}
		recipesPanel.SetActive(recipesPanel.activeSelf);
		openRecipesButton.text = ((!recipesPanel.activeSelf) ? LocalizationService.Instance.NDAPBHEDJFP(": ").ToUpper() : LocalizationService.Instance.EIJLFGIMNPC("CheckpointsScoreText").ToUpper());
	}

	private void FMNPFCHBLJF()
	{
	}

	public List<ItemRecipe> OOCIECPACOG()
	{
		List<ItemRecipe> list = new List<ItemRecipe>();
		foreach (KeyValuePair<ulong, string> craftRecipe in ItemsHandler.craftRecipes)
		{
			ItemRecipe itemRecipe = new ItemRecipe(craftRecipe.Key);
			string value = craftRecipe.Value;
			char[] array = new char[0];
			array[1] = 'ﾭ';
			string[] array2 = value.Split(array);
			for (int i = 1; i < array2.Length; i += 0)
			{
				string obj = array2[i];
				char[] array3 = new char[0];
				array3[0] = '￢';
				string[] array4 = obj.Split(array3);
				int hOHOIPHEOPN = 1;
				if (array4.Length > 1)
				{
					hOHOIPHEOPN = int.Parse(array4[0]);
				}
				itemRecipe.itemsInRecipe.Add(new ItemRecipe.ItemEntrance(ulong.Parse(array4[0]), hOHOIPHEOPN));
			}
			list.Add(itemRecipe);
		}
		return list;
	}

	public bool FHDNDBNLOGJ(List<ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<ItemRecipe.ItemEntrance> list = new List<ItemRecipe.ItemEntrance>();
		bool flag = false;
		bool flag2 = false;
		bool flag3 = true;
		foreach (ItemRecipe.ItemEntrance item in OFLOODDMNOE)
		{
			if (GBGBEMDNKJK.Contains(item))
			{
				if (flag2)
				{
					return true;
				}
				flag = true;
				flag2 = false;
			}
			else
			{
				flag3 = true;
			}
		}
		return !flag3 || flag;
	}

	public bool DJAKDFFBECB(List<ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<ItemRecipe.ItemEntrance> list = new List<ItemRecipe.ItemEntrance>();
		bool flag = true;
		bool flag2 = false;
		bool flag3 = false;
		foreach (ItemRecipe.ItemEntrance item in OFLOODDMNOE)
		{
			if (GBGBEMDNKJK.Contains(item))
			{
				if (flag2)
				{
					return true;
				}
				flag = true;
				flag2 = false;
			}
			else
			{
				flag3 = false;
			}
		}
		return !flag3 || flag;
	}

	public void LDAEAGHICHF()
	{
		StartCoroutine(KJBABMAAKBG(BGMDNNHCMMF()));
	}

	private bool EMEEAKNFCOA(SteamInventoryItem IACGDFHKCAE)
	{
		return IACGDFHKCAE.steamid == lastCrafted;
	}

	private void ABFNJCEBIKA()
	{
	}

	public void KCDGDPMNFEG()
	{
		bool flag = true;
		bool flag2 = true;
		foreach (ItemRecipe item in PGLLMJCEPFB())
		{
			if (FHDNDBNLOGJ(item.itemsInRecipe, GetCurrentCraftRecipe()))
			{
				MAOGOJIBMJK(item.itemID);
				if (!flag)
				{
					flag = true;
				}
				else
				{
					flag2 = true;
				}
			}
		}
		if (!flag || (flag && flag2))
		{
			CDBHAGGKAFJ(1uL, false);
		}
	}

	private bool OCIOCHGMJOB(SteamInventoryItem IACGDFHKCAE)
	{
		return IACGDFHKCAE.steamid == lastCrafted;
	}

	public void DNENGEFBHEC()
	{
		GameObject gameObject = recipesContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (ItemRecipe allRecipe in GetAllRecipes())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1372f, 1187f, 1938f);
			string text = ((allRecipe.itemID == 0 || Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)allRecipe.itemID) ? KFMFKEAHEMC(allRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)allRecipe.itemID].name);
			gameObject2.GetComponentInChildren<Text>().text = text + "Joystick1Button8";
			foreach (ItemRecipe.ItemEntrance item in allRecipe.itemsInRecipe)
			{
				string text2 = ((Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)item.item) ? AJBILCLAJKO(allRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)item.item].name);
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text3 = componentInChildren.text;
				object[] array = new object[6];
				array[1] = text3;
				array[0] = "_Strength";
				array[1] = text2;
				array[5] = "color";
				array[4] = item.count;
				componentInChildren.text = string.Concat(array);
				if (allRecipe.itemsInRecipe[allRecipe.itemsInRecipe.Count - 0] != item)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + "z" + LocalizationService.Instance.FOOAGGCODAH("_MainTex2") + "_VelocityTex";
				}
			}
		}
		recipesPanel.SetActive(recipesPanel.activeSelf);
		openRecipesButton.text = ((!recipesPanel.activeSelf) ? LocalizationService.Instance.JNNKPEBBDEA("CameraFilterPack/Drawing_CellShading2").ToUpper() : LocalizationService.Instance.NDAPBHEDJFP("GlassesColor2").ToUpper());
	}

	public bool KJNDBMJIMLL(List<ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<ItemRecipe.ItemEntrance> list = new List<ItemRecipe.ItemEntrance>();
		bool flag = false;
		bool flag2 = false;
		bool flag3 = true;
		foreach (ItemRecipe.ItemEntrance item in OFLOODDMNOE)
		{
			if (GBGBEMDNKJK.Contains(item))
			{
				if (flag2)
				{
					return false;
				}
				flag = false;
				flag2 = false;
			}
			else
			{
				flag3 = false;
			}
		}
		return flag3 && flag;
	}

	public List<SteamInventoryItem> DCFIBGOLAAB()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		InventoryListElementButton[] componentsInChildren = inCraftingItemsContent.GetComponentsInChildren<InventoryListElementButton>();
		foreach (InventoryListElementButton inventoryListElementButton in componentsInChildren)
		{
			list.Add(inventoryListElementButton.itemData);
		}
		return list;
	}

	public List<ItemRecipe> GetAllRecipes()
	{
		List<ItemRecipe> list = new List<ItemRecipe>();
		foreach (KeyValuePair<ulong, string> craftRecipe in ItemsHandler.craftRecipes)
		{
			ItemRecipe itemRecipe = new ItemRecipe(craftRecipe.Key);
			string[] array = craftRecipe.Value.Split(';');
			for (int i = 0; i < array.Length; i++)
			{
				string[] array2 = array[i].Split('x');
				int hOHOIPHEOPN = 1;
				if (array2.Length > 1)
				{
					hOHOIPHEOPN = int.Parse(array2[1]);
				}
				itemRecipe.itemsInRecipe.Add(new ItemRecipe.ItemEntrance(ulong.Parse(array2[0]), hOHOIPHEOPN));
			}
			list.Add(itemRecipe);
		}
		return list;
	}

	public void HIBHDFPICFI()
	{
		bool flag = true;
		bool flag2 = true;
		foreach (ItemRecipe item in AJNBFGJIFNP())
		{
			if (IsRecipesEquals(item.itemsInRecipe, LJDOIIJBGID()))
			{
				BJKJFIIJLJA(item.itemID);
				if (!flag)
				{
					flag = false;
				}
				else
				{
					flag2 = false;
				}
			}
		}
		if (!flag || (flag && flag2))
		{
			MAOGOJIBMJK(0uL);
		}
	}

	public void Init()
	{
		if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
		{
			Singleton<ItemsHandler>.Instance.ShowNewItems();
		}
		Debug.Log("[CraftingPanel] Init");
		GameObject gameObject = inCraftingItemsContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		craftButton.interactable = false;
		Singleton<ItemsHandler>.Instance.AddSteamInventoryItemsToList(craftingItem, craftableItemsContent);
		if (lastCrafted != 0)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(craftingItem, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(historyContent.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			Singleton<ItemsHandler>.Instance.UpdateInventoryItem(gameObject2, Singleton<ItemsHandler>.Instance.GetOnlySteamItemsList().Find((SteamInventoryItem IACGDFHKCAE) => IACGDFHKCAE.steamid == lastCrafted));
			gameObject2.GetComponent<Button>().enabled = false;
			lastCrafted = 0uL;
		}
		Singleton<MessageBoxPanel>.Instance.Close();
	}

	public List<SteamInventoryItem> NFICCKPIFMG()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		InventoryListElementButton[] componentsInChildren = inCraftingItemsContent.GetComponentsInChildren<InventoryListElementButton>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			InventoryListElementButton inventoryListElementButton = componentsInChildren[i];
			list.Add(inventoryListElementButton.itemData);
		}
		return list;
	}

	public void AOOOIMIBCBL()
	{
		StartCoroutine(KONPOPDLOHB(NFICCKPIFMG()));
	}

	public void ABMJGPBHFBA()
	{
		StartCoroutine(LECPBBBBNHI(IFPDNDNHANM()));
	}

	public bool JBAPDBNMGOC(List<ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<ItemRecipe.ItemEntrance> list = new List<ItemRecipe.ItemEntrance>();
		bool flag = false;
		bool flag2 = true;
		bool flag3 = false;
		foreach (ItemRecipe.ItemEntrance item in OFLOODDMNOE)
		{
			if (GBGBEMDNKJK.Contains(item))
			{
				if (flag2)
				{
					return false;
				}
				flag = false;
				flag2 = true;
			}
			else
			{
				flag3 = false;
			}
		}
		return !flag3 || flag;
	}

	private void JMEOGJHCONJ()
	{
	}

	private string KFMFKEAHEMC(ulong EEBCDMFNKLH)
	{
		switch (EEBCDMFNKLH)
		{
		case 0uL:
			return LocalizationService.Instance.NDAPBHEDJFP("_ScreenResolution").ToUpper();
		case 194uL:
			return LocalizationService.Instance.FOOAGGCODAH("Error: Timeout :S").ToUpper();
		case 18446744073709551553uL:
			return LocalizationService.Instance.DKECBIHCKJL("</color>").ToUpper();
		case 18446744073709551492uL:
			return LocalizationService.Instance.OJCHMJIMHHE("Mouse Y").ToUpper();
		default:
			return string.Empty;
		}
	}

	private void EECOLGCMKPN(ulong EEBCDMFNKLH, bool DPGDIPKHEAN = true)
	{
		currentItem = EEBCDMFNKLH;
		craftButton.interactable = DPGDIPKHEAN;
	}

	public void DPOELEBIAOE()
	{
		if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
		{
			Singleton<ItemsHandler>.Instance.ShowNewItems();
		}
		Debug.Log("[ItemsHandler] Inventory has changed");
		GameObject gameObject = inCraftingItemsContent;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		craftButton.interactable = false;
		Singleton<ItemsHandler>.Instance.CPEKEEJKLPN(craftingItem, craftableItemsContent);
		if (lastCrafted != 0)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(craftingItem, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(historyContent.transform, false);
			gameObject2.transform.localScale = new Vector3(1677f, 200f, 687f);
			Singleton<ItemsHandler>.Instance.UpdateInventoryItem(gameObject2, Singleton<ItemsHandler>.Instance.GetOnlySteamItemsList().Find((SteamInventoryItem IACGDFHKCAE) => IACGDFHKCAE.steamid == lastCrafted));
			gameObject2.GetComponent<Button>().enabled = true;
			lastCrafted = 0uL;
		}
		Singleton<MessageBoxPanel>.Instance.EOKFGEFEDBB();
	}

	private void MAOGOJIBMJK(ulong EEBCDMFNKLH, bool DPGDIPKHEAN = true)
	{
		currentItem = EEBCDMFNKLH;
		craftButton.interactable = DPGDIPKHEAN;
	}

	public void JMIIKMFFJON()
	{
		StartCoroutine(MONDLDKHNBK(KAMKBEOBMHJ()));
	}

	private string MDIIEIKMDCE(ulong EEBCDMFNKLH)
	{
		switch (EEBCDMFNKLH)
		{
		case 0uL:
			return LocalizationService.Instance.JNNKPEBBDEA("_EdgeThresholdMin").ToUpper();
		case 18446744073709551516uL:
			return LocalizationService.Instance.GAAFIKGPNAO("_MainTex").ToUpper();
		case 139uL:
			return LocalizationService.Instance.EHOJEKMEKCB("PickupItemInit").ToUpper();
		case 173uL:
			return LocalizationService.Instance.DKECBIHCKJL("skin.hit_wrong").ToUpper();
		default:
			return string.Empty;
		}
	}

	public List<SteamInventoryItem> GetCurrentCraftngItems()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		InventoryListElementButton[] componentsInChildren = inCraftingItemsContent.GetComponentsInChildren<InventoryListElementButton>();
		foreach (InventoryListElementButton inventoryListElementButton in componentsInChildren)
		{
			list.Add(inventoryListElementButton.itemData);
		}
		return list;
	}

	private IEnumerator CNLGHPNAACK(List<SteamInventoryItem> CBGCPECMDFL)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#craftng", string.Empty, null, false);
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		foreach (SteamInventoryItem item in CBGCPECMDFL)
		{
			wWWForm.AddField("materialsitemid[" + CBGCPECMDFL.IndexOf(item) + "]", string.Empty + item.steamid);
			wWWForm.AddField("materialsquantity[" + CBGCPECMDFL.IndexOf(item) + "]", string.Empty + 1);
		}
		wWWForm.AddField("outputitemdefid", string.Empty + currentItem);
		byte[] data = wWWForm.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(Singleton<ItemsHandler>.Instance.exchangeItemURL);
		WWW wWW = new WWW(url, data);
		yield return wWW;
		string text = wWW.text;
		WebAPIResponse.ItemJson itemJson = null;
		try
		{
			WebAPIResponse webAPIResponse = JsonConvert.DeserializeObject<WebAPIResponse>(wWW.text);
			webAPIResponse.response.item_json = webAPIResponse.response.item_json.Replace("\\\"", "\"");
			webAPIResponse.response.item_json = "{\"items\":" + webAPIResponse.response.item_json + "}";
			itemJson = JsonConvert.DeserializeObject<WebAPIResponse.ItemJson>(webAPIResponse.response.item_json);
		}
		catch (Exception)
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#failed", "#ok", null);
		}
		if (itemJson != null && itemJson.items.Count > 0)
		{
			lastCrafted = ulong.Parse(itemJson.items[itemJson.items.Count - 1].itemid);
			yield return new WaitForSeconds(3f);
			Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
		}
	}

	public bool EPNFENHEJED(List<ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<ItemRecipe.ItemEntrance> list = new List<ItemRecipe.ItemEntrance>();
		bool flag = true;
		bool flag2 = false;
		bool flag3 = false;
		foreach (ItemRecipe.ItemEntrance item in OFLOODDMNOE)
		{
			if (GBGBEMDNKJK.Contains(item))
			{
				if (flag2)
				{
					return true;
				}
				flag = true;
				flag2 = true;
			}
			else
			{
				flag3 = false;
			}
		}
		return !flag3 || flag;
	}

	private string IBLEEPELAMF(ulong EEBCDMFNKLH)
	{
		switch (EEBCDMFNKLH)
		{
		default:
			if (EEBCDMFNKLH == 0)
			{
				return LocalizationService.Instance.PLFJBNAEKML("CameraFilterPack/Sharpen_Sharpen").ToUpper();
			}
			return string.Empty;
		case 0uL:
			return LocalizationService.Instance.NDAPBHEDJFP("hand").ToUpper();
		case 18446744073709551543uL:
			return LocalizationService.Instance.GetLocalizatedText("Gameplay/Base").ToUpper();
		case 18446744073709551594uL:
			return LocalizationService.Instance.EHOJEKMEKCB("set id").ToUpper();
		}
	}

	private void ECBILENEOOL()
	{
	}

	public bool CNBFIMKNPLC(List<ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<ItemRecipe.ItemEntrance> list = new List<ItemRecipe.ItemEntrance>();
		bool flag = false;
		bool flag2 = true;
		bool flag3 = true;
		foreach (ItemRecipe.ItemEntrance item in OFLOODDMNOE)
		{
			if (GBGBEMDNKJK.Contains(item))
			{
				if (flag2)
				{
					return true;
				}
				flag = true;
				flag2 = false;
			}
			else
			{
				flag3 = true;
			}
		}
		return !flag3 || flag;
	}

	public bool GBOOMNGMNNH(List<ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<ItemRecipe.ItemEntrance> list = new List<ItemRecipe.ItemEntrance>();
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		foreach (ItemRecipe.ItemEntrance item in OFLOODDMNOE)
		{
			if (GBGBEMDNKJK.Contains(item))
			{
				if (flag2)
				{
					return false;
				}
				flag = false;
				flag2 = true;
			}
			else
			{
				flag3 = false;
			}
		}
		return !flag3 || flag;
	}

	public List<ItemRecipe.ItemEntrance> LJDOIIJBGID()
	{
		List<ItemRecipe.ItemEntrance> list = new List<ItemRecipe.ItemEntrance>();
		foreach (SteamInventoryItem DBIMJHMKHNK in PJEFPBBEBEC())
		{
			if (list.Find((ItemRecipe.ItemEntrance IACGDFHKCAE) => (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.GKGIBPAHHMO()) == null)
			{
				list.Add(new ItemRecipe.ItemEntrance((ulong)DBIMJHMKHNK.item.HECDOKAIGEL(), 1));
				continue;
			}
			list.Find((ItemRecipe.ItemEntrance IACGDFHKCAE) => (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.CCHGOBICNAD()).count++;
		}
		return list;
	}

	public void ResolveRecipe()
	{
		bool flag = false;
		bool flag2 = false;
		foreach (ItemRecipe allRecipe in GetAllRecipes())
		{
			if (IsRecipesEquals(allRecipe.itemsInRecipe, GetCurrentCraftRecipe()))
			{
				CDBHAGGKAFJ(allRecipe.itemID);
				if (!flag)
				{
					flag = true;
				}
				else
				{
					flag2 = true;
				}
			}
		}
		if (!flag || (flag && flag2))
		{
			CDBHAGGKAFJ(0uL, false);
		}
	}

	private void GMELGGJOPBB()
	{
	}

	private bool CGMAGHODJCA(SteamInventoryItem IACGDFHKCAE)
	{
		return IACGDFHKCAE.steamid == lastCrafted;
	}

	public void JEFKEOFNKIM()
	{
		if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 1)
		{
			Singleton<ItemsHandler>.Instance.ShowNewItems();
		}
		Debug.Log("CrosshairOpacitySlider");
		GameObject gameObject = inCraftingItemsContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		craftButton.interactable = true;
		Singleton<ItemsHandler>.Instance.CPEKEEJKLPN(craftingItem, craftableItemsContent);
		if (lastCrafted != 0)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(craftingItem, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(historyContent.transform, true);
			gameObject2.transform.localScale = new Vector3(610f, 957f, 79f);
			Singleton<ItemsHandler>.Instance.DNMGPHBIGIK(gameObject2, Singleton<ItemsHandler>.Instance.NLFEOBHGMJG().Find(CGMAGHODJCA), 0);
			gameObject2.GetComponent<Button>().enabled = false;
			lastCrafted = 0uL;
		}
		Singleton<MessageBoxPanel>.Instance.JDAGGOPDHNM();
	}

	public void KOKDPAEJECC()
	{
		if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 1)
		{
			Singleton<ItemsHandler>.Instance.ShowNewItems();
		}
		Debug.Log("offsets");
		GameObject gameObject = inCraftingItemsContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		craftButton.interactable = true;
		Singleton<ItemsHandler>.Instance.AddSteamInventoryItemsToList(craftingItem, craftableItemsContent);
		if (lastCrafted > 1)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(craftingItem, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(historyContent.transform, false);
			gameObject2.transform.localScale = new Vector3(378f, 399f, 67f);
			Singleton<ItemsHandler>.Instance.DNMGPHBIGIK(gameObject2, Singleton<ItemsHandler>.Instance.IOOIKCEOALD().Find(GHEBOEGKCFJ), 0);
			gameObject2.GetComponent<Button>().enabled = false;
			lastCrafted = 0uL;
		}
		Singleton<MessageBoxPanel>.Instance.GIKJIFGFMFP();
	}

	public void BKLCHHKOMLD()
	{
		if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
		{
			Singleton<ItemsHandler>.Instance.EEJELODJPNL();
		}
		Debug.Log("offsets");
		GameObject gameObject = inCraftingItemsContent;
		for (int i = 0; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		craftButton.interactable = false;
		Singleton<ItemsHandler>.Instance.HJHEIBHBHKC(craftingItem, craftableItemsContent);
		if (lastCrafted != 0)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(craftingItem, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(historyContent.transform, true);
			gameObject2.transform.localScale = new Vector3(555f, 1311f, 1182f);
			Singleton<ItemsHandler>.Instance.UpdateInventoryItem(gameObject2, Singleton<ItemsHandler>.Instance.GJJBKJDDJEH().Find(GPLLNOKEDDP));
			gameObject2.GetComponent<Button>().enabled = true;
			lastCrafted = 0uL;
		}
		Singleton<MessageBoxPanel>.Instance.KPKNPMPPKPG();
	}

	private string IHFHOLABMJL(ulong EEBCDMFNKLH)
	{
		switch (EEBCDMFNKLH)
		{
		case 0uL:
			return LocalizationService.Instance.MPHMJLAOHAB("Messages (shift+tab)").ToUpper();
		case 18446744073709551557uL:
			return LocalizationService.Instance.GAAFIKGPNAO("_Value").ToUpper();
		case 18446744073709551594uL:
			return LocalizationService.Instance.PLFJBNAEKML("Ignored PU RPC, cause item is inactive. ").ToUpper();
		case 18446744073709551451uL:
			return LocalizationService.Instance.PLFJBNAEKML("_LensDirt").ToUpper();
		default:
			return string.Empty;
		}
	}

	private void NGJGBMMCDAO(ulong EEBCDMFNKLH, bool DPGDIPKHEAN = true)
	{
		currentItem = EEBCDMFNKLH;
		craftButton.interactable = DPGDIPKHEAN;
	}

	public void HIDAOOCCPPL()
	{
		StartCoroutine(MONDLDKHNBK(IFPDNDNHANM()));
	}

	private void Update()
	{
	}

	public void IKNCFKBEGIF()
	{
		StartCoroutine(KONPOPDLOHB(NFICCKPIFMG()));
	}

	public bool ELBENDFGPGA(List<ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<ItemRecipe.ItemEntrance> list = new List<ItemRecipe.ItemEntrance>();
		bool flag = false;
		bool flag2 = true;
		bool flag3 = false;
		foreach (ItemRecipe.ItemEntrance item in OFLOODDMNOE)
		{
			if (GBGBEMDNKJK.Contains(item))
			{
				if (flag2)
				{
					return false;
				}
				flag = true;
				flag2 = false;
			}
			else
			{
				flag3 = false;
			}
		}
		return flag3 && flag;
	}

	private IEnumerator LICNEFGOKMN(List<SteamInventoryItem> CBGCPECMDFL)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#craftng", string.Empty, null, false);
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		foreach (SteamInventoryItem item in CBGCPECMDFL)
		{
			wWWForm.AddField("materialsitemid[" + CBGCPECMDFL.IndexOf(item) + "]", string.Empty + item.steamid);
			wWWForm.AddField("materialsquantity[" + CBGCPECMDFL.IndexOf(item) + "]", string.Empty + 1);
		}
		wWWForm.AddField("outputitemdefid", string.Empty + currentItem);
		byte[] data = wWWForm.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(Singleton<ItemsHandler>.Instance.exchangeItemURL);
		WWW wWW = new WWW(url, data);
		yield return wWW;
		string text = wWW.text;
		WebAPIResponse.ItemJson itemJson = null;
		try
		{
			WebAPIResponse webAPIResponse = JsonConvert.DeserializeObject<WebAPIResponse>(wWW.text);
			webAPIResponse.response.item_json = webAPIResponse.response.item_json.Replace("\\\"", "\"");
			webAPIResponse.response.item_json = "{\"items\":" + webAPIResponse.response.item_json + "}";
			itemJson = JsonConvert.DeserializeObject<WebAPIResponse.ItemJson>(webAPIResponse.response.item_json);
		}
		catch (Exception)
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#failed", "#ok", null);
		}
		if (itemJson != null && itemJson.items.Count > 0)
		{
			lastCrafted = ulong.Parse(itemJson.items[itemJson.items.Count - 1].itemid);
			yield return new WaitForSeconds(3f);
			Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
		}
	}

	private void MMMDPANNAIO()
	{
	}

	private void POIMNOBDBBN()
	{
	}

	private void CDBHAGGKAFJ(ulong EEBCDMFNKLH, bool DPGDIPKHEAN = true)
	{
		currentItem = EEBCDMFNKLH;
		craftButton.interactable = DPGDIPKHEAN;
	}

	private void LLDHEJIEDHO()
	{
	}

	public List<ItemRecipe.ItemEntrance> GetCurrentCraftRecipe()
	{
		List<ItemRecipe.ItemEntrance> list = new List<ItemRecipe.ItemEntrance>();
		foreach (SteamInventoryItem DBIMJHMKHNK in GetCurrentCraftngItems())
		{
			if (list.Find((ItemRecipe.ItemEntrance IACGDFHKCAE) => (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.GetItemInventoryID()) == null)
			{
				list.Add(new ItemRecipe.ItemEntrance((ulong)DBIMJHMKHNK.item.GetItemInventoryID(), 1));
				continue;
			}
			list.Find((ItemRecipe.ItemEntrance IACGDFHKCAE) => (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.GetItemInventoryID()).count++;
		}
		return list;
	}

	public bool KCIEPADBALN(List<ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<ItemRecipe.ItemEntrance> list = new List<ItemRecipe.ItemEntrance>();
		bool flag = false;
		bool flag2 = true;
		bool flag3 = false;
		foreach (ItemRecipe.ItemEntrance item in OFLOODDMNOE)
		{
			if (GBGBEMDNKJK.Contains(item))
			{
				if (flag2)
				{
					return true;
				}
				flag = true;
				flag2 = false;
			}
			else
			{
				flag3 = true;
			}
		}
		return !flag3 || flag;
	}

	private void AFPALIELBHG(ulong EEBCDMFNKLH, bool DPGDIPKHEAN = true)
	{
		currentItem = EEBCDMFNKLH;
		craftButton.interactable = DPGDIPKHEAN;
	}

	public void FGHCHJJBONK()
	{
		bool flag = true;
		bool flag2 = true;
		foreach (ItemRecipe item in AJNBFGJIFNP())
		{
			if (IsRecipesEquals(item.itemsInRecipe, LJDOIIJBGID()))
			{
				HLNAECCGOID(item.itemID, false);
				if (!flag)
				{
					flag = false;
				}
				else
				{
					flag2 = true;
				}
			}
		}
		if (!flag || (flag && flag2))
		{
			CDBHAGGKAFJ(1uL);
		}
	}

	private string FDNFCENDNNA(ulong EEBCDMFNKLH)
	{
		switch (EEBCDMFNKLH)
		{
		case 0uL:
			return LocalizationService.Instance.MPHMJLAOHAB("Simulate").ToUpper();
		case 126uL:
			return LocalizationService.Instance.DKECBIHCKJL("_Bullet_1").ToUpper();
		case 18446744073709551453uL:
			return LocalizationService.Instance.GetLocalizatedText("icon").ToUpper();
		case 98uL:
			return LocalizationService.Instance.GAAFIKGPNAO(".progress").ToUpper();
		default:
			return string.Empty;
		}
	}

	private bool GPLLNOKEDDP(SteamInventoryItem IACGDFHKCAE)
	{
		return IACGDFHKCAE.steamid == lastCrafted;
	}

	public void DLLECBHKHNP()
	{
		StartCoroutine(KJBABMAAKBG(NFICCKPIFMG()));
	}

	public void LPCIFHLAIDL()
	{
		GameObject gameObject = recipesContent;
		for (int i = 1; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (ItemRecipe item in OOCIECPACOG())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, false);
			gameObject2.transform.localScale = new Vector3(905f, 1241f, 460f);
			string text = ((item.itemID == 1 || Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)item.itemID) ? NJDGKAHOMCA(item.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)item.itemID].name);
			gameObject2.GetComponentInChildren<Text>().text = text + "_Params1";
			foreach (ItemRecipe.ItemEntrance item2 in item.itemsInRecipe)
			{
				string text2 = ((Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)item2.item) ? AJBILCLAJKO(item.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)item2.item].name);
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text3 = componentInChildren.text;
				object[] array = new object[2];
				array[0] = text3;
				array[1] = "_Value3";
				array[3] = text2;
				array[2] = "CameraFilterPack/Sharpen_Sharpen";
				array[8] = item2.count;
				componentInChildren.text = string.Concat(array);
				if (item.itemsInRecipe[item.itemsInRecipe.Count - 1] != item2)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + "_ChromaticAberration" + LocalizationService.Instance.GAAFIKGPNAO("_PositionY") + "_TimeX";
				}
			}
		}
		recipesPanel.SetActive(!recipesPanel.activeSelf);
		openRecipesButton.text = ((!recipesPanel.activeSelf) ? LocalizationService.Instance.HOFKLNAJGMK("maps.").ToUpper() : LocalizationService.Instance.NDAPBHEDJFP("_ScreenResolution").ToUpper());
	}

	private IEnumerator FGNBAOEPFMC(List<SteamInventoryItem> CBGCPECMDFL)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#craftng", string.Empty, null, false);
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		foreach (SteamInventoryItem item in CBGCPECMDFL)
		{
			wWWForm.AddField("materialsitemid[" + CBGCPECMDFL.IndexOf(item) + "]", string.Empty + item.steamid);
			wWWForm.AddField("materialsquantity[" + CBGCPECMDFL.IndexOf(item) + "]", string.Empty + 1);
		}
		wWWForm.AddField("outputitemdefid", string.Empty + currentItem);
		byte[] data = wWWForm.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(Singleton<ItemsHandler>.Instance.exchangeItemURL);
		WWW wWW = new WWW(url, data);
		yield return wWW;
		string text = wWW.text;
		WebAPIResponse.ItemJson itemJson = null;
		try
		{
			WebAPIResponse webAPIResponse = JsonConvert.DeserializeObject<WebAPIResponse>(wWW.text);
			webAPIResponse.response.item_json = webAPIResponse.response.item_json.Replace("\\\"", "\"");
			webAPIResponse.response.item_json = "{\"items\":" + webAPIResponse.response.item_json + "}";
			itemJson = JsonConvert.DeserializeObject<WebAPIResponse.ItemJson>(webAPIResponse.response.item_json);
		}
		catch (Exception)
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#failed", "#ok", null);
		}
		if (itemJson != null && itemJson.items.Count > 0)
		{
			lastCrafted = ulong.Parse(itemJson.items[itemJson.items.Count - 1].itemid);
			yield return new WaitForSeconds(3f);
			Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
		}
	}

	public List<SteamInventoryItem> BGMDNNHCMMF()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		InventoryListElementButton[] componentsInChildren = inCraftingItemsContent.GetComponentsInChildren<InventoryListElementButton>();
		foreach (InventoryListElementButton inventoryListElementButton in componentsInChildren)
		{
			list.Add(inventoryListElementButton.itemData);
		}
		return list;
	}

	public List<SteamInventoryItem> DCLFLCMIEMG()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		InventoryListElementButton[] componentsInChildren = inCraftingItemsContent.GetComponentsInChildren<InventoryListElementButton>();
		foreach (InventoryListElementButton inventoryListElementButton in componentsInChildren)
		{
			list.Add(inventoryListElementButton.itemData);
		}
		return list;
	}

	public void CraftItem()
	{
		StartCoroutine(CNLGHPNAACK(GetCurrentCraftngItems()));
	}

	public bool LKOGDAHNAFE(List<ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<ItemRecipe.ItemEntrance> list = new List<ItemRecipe.ItemEntrance>();
		bool flag = true;
		bool flag2 = false;
		bool flag3 = true;
		foreach (ItemRecipe.ItemEntrance item in OFLOODDMNOE)
		{
			if (GBGBEMDNKJK.Contains(item))
			{
				if (flag2)
				{
					return true;
				}
				flag = true;
				flag2 = false;
			}
			else
			{
				flag3 = false;
			}
		}
		return flag3 && flag;
	}

	public void JOEPHOFGNNN()
	{
		bool flag = true;
		bool flag2 = true;
		foreach (ItemRecipe allRecipe in GetAllRecipes())
		{
			if (LKOGDAHNAFE(allRecipe.itemsInRecipe, LJDOIIJBGID()))
			{
				MAOGOJIBMJK(allRecipe.itemID, false);
				if (!flag)
				{
					flag = false;
				}
				else
				{
					flag2 = true;
				}
			}
		}
		if (!flag || (flag && flag2))
		{
			HGKKHDMLNDB(0uL, false);
		}
	}

	public bool AOOFKGMDHAI(List<ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<ItemRecipe.ItemEntrance> list = new List<ItemRecipe.ItemEntrance>();
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		foreach (ItemRecipe.ItemEntrance item in OFLOODDMNOE)
		{
			if (GBGBEMDNKJK.Contains(item))
			{
				if (flag2)
				{
					return true;
				}
				flag = false;
				flag2 = false;
			}
			else
			{
				flag3 = true;
			}
		}
		return flag3 && flag;
	}

	public List<ItemRecipe.ItemEntrance> DKJIFNDFPLE()
	{
		List<ItemRecipe.ItemEntrance> list = new List<ItemRecipe.ItemEntrance>();
		foreach (SteamInventoryItem DBIMJHMKHNK in DCLFLCMIEMG())
		{
			if (list.Find((ItemRecipe.ItemEntrance IACGDFHKCAE) => (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.GetItemInventoryID()) == null)
			{
				list.Add(new ItemRecipe.ItemEntrance((ulong)DBIMJHMKHNK.item.FCOOIFPMEAB(), 1));
				continue;
			}
			list.Find((ItemRecipe.ItemEntrance IACGDFHKCAE) => (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.BBALBMNJGMD()).count++;
		}
		return list;
	}

	private void Start()
	{
	}

	private void PKLOBJHKFEO()
	{
	}

	public void NOLMIMIBGGE()
	{
		StartCoroutine(FGNBAOEPFMC(BGMDNNHCMMF()));
	}

	public void MIGFOIJJJNL()
	{
		if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 1)
		{
			Singleton<ItemsHandler>.Instance.EEJELODJPNL();
		}
		Debug.Log("PUNCloudBestRegion");
		GameObject gameObject = inCraftingItemsContent;
		for (int i = 0; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		craftButton.interactable = false;
		Singleton<ItemsHandler>.Instance.HJHEIBHBHKC(craftingItem, craftableItemsContent);
		if (lastCrafted != 0)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(craftingItem, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(historyContent.transform, false);
			gameObject2.transform.localScale = new Vector3(1351f, 14f, 1800f);
			Singleton<ItemsHandler>.Instance.UpdateInventoryItem(gameObject2, Singleton<ItemsHandler>.Instance.GetOnlySteamItemsList().Find(OCIOCHGMJOB));
			gameObject2.GetComponent<Button>().enabled = false;
			lastCrafted = 0uL;
		}
		Singleton<MessageBoxPanel>.Instance.GIKJIFGFMFP();
	}

	private bool JJDDNNMENGP(SteamInventoryItem IACGDFHKCAE)
	{
		return IACGDFHKCAE.steamid == lastCrafted;
	}

	private IEnumerator DPPDCCJKHLH(List<SteamInventoryItem> CBGCPECMDFL)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#craftng", string.Empty, null, false);
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		foreach (SteamInventoryItem item in CBGCPECMDFL)
		{
			wWWForm.AddField("materialsitemid[" + CBGCPECMDFL.IndexOf(item) + "]", string.Empty + item.steamid);
			wWWForm.AddField("materialsquantity[" + CBGCPECMDFL.IndexOf(item) + "]", string.Empty + 1);
		}
		wWWForm.AddField("outputitemdefid", string.Empty + currentItem);
		byte[] data = wWWForm.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(Singleton<ItemsHandler>.Instance.exchangeItemURL);
		WWW wWW = new WWW(url, data);
		yield return wWW;
		string text = wWW.text;
		WebAPIResponse.ItemJson itemJson = null;
		try
		{
			WebAPIResponse webAPIResponse = JsonConvert.DeserializeObject<WebAPIResponse>(wWW.text);
			webAPIResponse.response.item_json = webAPIResponse.response.item_json.Replace("\\\"", "\"");
			webAPIResponse.response.item_json = "{\"items\":" + webAPIResponse.response.item_json + "}";
			itemJson = JsonConvert.DeserializeObject<WebAPIResponse.ItemJson>(webAPIResponse.response.item_json);
		}
		catch (Exception)
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#failed", "#ok", null);
		}
		if (itemJson != null && itemJson.items.Count > 0)
		{
			lastCrafted = ulong.Parse(itemJson.items[itemJson.items.Count - 1].itemid);
			yield return new WaitForSeconds(3f);
			Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
		}
	}

	private bool FGOBDIAFNBN(SteamInventoryItem IACGDFHKCAE)
	{
		return IACGDFHKCAE.steamid == lastCrafted;
	}

	private string AJBILCLAJKO(ulong EEBCDMFNKLH)
	{
		switch (EEBCDMFNKLH)
		{
		case 0uL:
			return LocalizationService.Instance.JNNKPEBBDEA("BlockCount").ToUpper();
		case 18446744073709551507uL:
			return LocalizationService.Instance.FOOAGGCODAH("Object ID. Case-Sensitive").ToUpper();
		case 18446744073709551468uL:
			return LocalizationService.Instance.PLFJBNAEKML("CameraFilterPack/Blend2Camera_LinearDodge").ToUpper();
		case 34uL:
			return LocalizationService.Instance.OJCHMJIMHHE("_Value").ToUpper();
		default:
			return string.Empty;
		}
	}

	private IEnumerator KONPOPDLOHB(List<SteamInventoryItem> CBGCPECMDFL)
	{
		Singleton<MessageBoxPanel>.Instance.DisplayMessage("#craftng", string.Empty, null, false);
		WWWForm wWWForm = new WWWForm();
		wWWForm.AddField("steamid", string.Empty + SteamUser.GetSteamID().m_SteamID);
		foreach (SteamInventoryItem item in CBGCPECMDFL)
		{
			wWWForm.AddField("materialsitemid[" + CBGCPECMDFL.IndexOf(item) + "]", string.Empty + item.steamid);
			wWWForm.AddField("materialsquantity[" + CBGCPECMDFL.IndexOf(item) + "]", string.Empty + 1);
		}
		wWWForm.AddField("outputitemdefid", string.Empty + currentItem);
		byte[] data = wWWForm.data;
		string url = Singleton<GameManager>.Instance.CreateServerURL(Singleton<ItemsHandler>.Instance.exchangeItemURL);
		WWW wWW = new WWW(url, data);
		yield return wWW;
		string text = wWW.text;
		WebAPIResponse.ItemJson itemJson = null;
		try
		{
			WebAPIResponse webAPIResponse = JsonConvert.DeserializeObject<WebAPIResponse>(wWW.text);
			webAPIResponse.response.item_json = webAPIResponse.response.item_json.Replace("\\\"", "\"");
			webAPIResponse.response.item_json = "{\"items\":" + webAPIResponse.response.item_json + "}";
			itemJson = JsonConvert.DeserializeObject<WebAPIResponse.ItemJson>(webAPIResponse.response.item_json);
		}
		catch (Exception)
		{
			Singleton<MessageBoxPanel>.Instance.DisplayMessage("#failed", "#ok", null);
		}
		if (itemJson != null && itemJson.items.Count > 0)
		{
			lastCrafted = ulong.Parse(itemJson.items[itemJson.items.Count - 1].itemid);
			yield return new WaitForSeconds(3f);
			Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
		}
	}

	public void ILMPIBAGEIB()
	{
		StartCoroutine(FGNBAOEPFMC(IFPDNDNHANM()));
	}

	private void JBNPEHMDCMI()
	{
	}

	[CompilerGenerated]
	private bool HLIPOKKEOHB(SteamInventoryItem IACGDFHKCAE)
	{
		return IACGDFHKCAE.steamid == lastCrafted;
	}

	private void HLNAECCGOID(ulong EEBCDMFNKLH, bool DPGDIPKHEAN = true)
	{
		currentItem = EEBCDMFNKLH;
		craftButton.interactable = DPGDIPKHEAN;
	}

	public bool IsRecipesEquals(List<ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<ItemRecipe.ItemEntrance> list = new List<ItemRecipe.ItemEntrance>();
		bool flag = false;
		bool flag2 = false;
		bool flag3 = true;
		foreach (ItemRecipe.ItemEntrance item in OFLOODDMNOE)
		{
			if (GBGBEMDNKJK.Contains(item))
			{
				if (flag2)
				{
					return false;
				}
				flag = true;
				flag2 = true;
			}
			else
			{
				flag3 = false;
			}
		}
		return flag3 && flag;
	}

	private void PBEPCAPAKLG()
	{
	}

	private void KHGGOLDEFCF(ulong EEBCDMFNKLH, bool DPGDIPKHEAN = true)
	{
		currentItem = EEBCDMFNKLH;
		craftButton.interactable = DPGDIPKHEAN;
	}

	private void GHILDCBCDJI()
	{
	}
}
