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

			public override bool CCMGFFBHIGG(object AGPIGANJKMN)
			{
				ItemEntrance itemEntrance = (ItemEntrance)AGPIGANJKMN;
				return item == itemEntrance.item && count == itemEntrance.count;
			}

			public override bool BLJHKDAHFHL(object AGPIGANJKMN)
			{
				ItemEntrance itemEntrance = (ItemEntrance)AGPIGANJKMN;
				return item == itemEntrance.item && count == itemEntrance.count;
			}

			public override bool IEFMFMFGMDH(object AGPIGANJKMN)
			{
				ItemEntrance itemEntrance = (ItemEntrance)AGPIGANJKMN;
				return item != itemEntrance.item || count == itemEntrance.count;
			}

			public override int DNMJNLAEBKP()
			{
				return base.GetHashCode();
			}

			public override bool INDANPJEICH(object AGPIGANJKMN)
			{
				ItemEntrance itemEntrance = (ItemEntrance)AGPIGANJKMN;
				return item == itemEntrance.item && count == itemEntrance.count;
			}

			public ItemEntrance(ulong DBIMJHMKHNK, int HOHOIPHEOPN)
			{
				item = DBIMJHMKHNK;
				count = HOHOIPHEOPN;
			}

			public override bool ILLAEPFOHCJ(object AGPIGANJKMN)
			{
				ItemEntrance itemEntrance = (ItemEntrance)AGPIGANJKMN;
				return item != itemEntrance.item || count == itemEntrance.count;
			}

			public override bool FAEELIPGIBL(object AGPIGANJKMN)
			{
				ItemEntrance itemEntrance = (ItemEntrance)AGPIGANJKMN;
				return item == itemEntrance.item && count == itemEntrance.count;
			}

			public override bool HELLBLOBANP(object AGPIGANJKMN)
			{
				ItemEntrance itemEntrance = (ItemEntrance)AGPIGANJKMN;
				return item == itemEntrance.item && count == itemEntrance.count;
			}

			public override int NCBGPMCHGNK()
			{
				return base.GetHashCode();
			}

			public override int CHPGJMEKKLM()
			{
				return base.GetHashCode();
			}

			public override int HPGDGGOJIGC()
			{
				return base.GetHashCode();
			}

			public override int EFLNBBEIGOH()
			{
				return base.GetHashCode();
			}

			public override bool NLEHLDCJEIA(object AGPIGANJKMN)
			{
				ItemEntrance itemEntrance = (ItemEntrance)AGPIGANJKMN;
				return item == itemEntrance.item && count == itemEntrance.count;
			}

			public override int LLAFDKINFOM()
			{
				return base.GetHashCode();
			}

			public override bool EEFJNKBILLG(object AGPIGANJKMN)
			{
				ItemEntrance itemEntrance = (ItemEntrance)AGPIGANJKMN;
				return item == itemEntrance.item && count == itemEntrance.count;
			}

			public override int COHDDOPMJNE()
			{
				return base.GetHashCode();
			}

			public override int OFIPAKGBICP()
			{
				return base.GetHashCode();
			}

			public override int EILFHBAOEJF()
			{
				return base.GetHashCode();
			}

			public override int MJFJPBFMLKO()
			{
				return base.GetHashCode();
			}

			public override int GBJCILCHOLK()
			{
				return base.GetHashCode();
			}

			public override int KJLPMPBLGND()
			{
				return base.GetHashCode();
			}

			public override bool JHCGGHMMEDK(object AGPIGANJKMN)
			{
				ItemEntrance itemEntrance = (ItemEntrance)AGPIGANJKMN;
				return item != itemEntrance.item || count == itemEntrance.count;
			}

			public override int APDIKIFPAEB()
			{
				return base.GetHashCode();
			}

			public override int MKAMCNNMDIG()
			{
				return base.GetHashCode();
			}

			public override bool DAPGPBONOFL(object AGPIGANJKMN)
			{
				ItemEntrance itemEntrance = (ItemEntrance)AGPIGANJKMN;
				return item == itemEntrance.item && count == itemEntrance.count;
			}

			public override bool Equals(object AGPIGANJKMN)
			{
				ItemEntrance itemEntrance = (ItemEntrance)AGPIGANJKMN;
				return item == itemEntrance.item && count == itemEntrance.count;
			}

			public override int BDMNEHBJNLM()
			{
				return base.GetHashCode();
			}

			public override int PPEHIDGIAKH()
			{
				return base.GetHashCode();
			}

			public override int GetHashCode()
			{
				return base.GetHashCode();
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

		internal bool FJDBPPKABJE(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.EJJKPPDLHIC();
		}

		internal bool KGKMOLCPDIH(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.GFIAJHFEEDL();
		}

		internal bool IGFOBPKFCDJ(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.LDEFHDDBACF();
		}

		internal bool LNDGINDKPFA(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.IDNGNCHMCGH();
		}

		internal bool AKDOOLPMPMG(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.KKNKMFFMPIO();
		}

		internal bool PLINPGHDODA(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.EJJKPPDLHIC();
		}

		internal bool FKCDLJELMNN(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.JLIDIIBJFAM();
		}

		internal bool JDELIMPGFDJ(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.IAJKNHICFDA();
		}

		internal bool BKNHHGBPLGH(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.PHLNGGADEON();
		}

		internal bool BOPKCHEPEEB(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.ENJDAADCONN();
		}

		internal bool EEBODGOFEGB(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.JJAGPHJDANN();
		}

		internal bool JKEDCEOCPJO(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.GEFIGLHEKGA();
		}

		internal bool FHFECFLBHMA(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.GKGIBPAHHMO();
		}

		internal bool ECGDAHDOPBO(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.KKNKMFFMPIO();
		}

		internal bool MFBMMDCIPGG(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.IIELGFOOAND();
		}

		internal bool NGFGLJGABCM(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.CAFEIKLLFFG();
		}

		internal bool OLIGLEMPFOP(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.MPHJGFBKJBE();
		}

		internal bool OFLDIMDDLHM(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.KKNKMFFMPIO();
		}

		internal bool BCDAGGDDADL(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.GFIAJHFEEDL();
		}

		internal bool DFEBIECLKEK(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.MPHJGFBKJBE();
		}

		internal bool DBOEBFFAOFJ(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.GEFIGLHEKGA();
		}

		internal bool KFNPHCCAJFD(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.EJJKPPDLHIC();
		}

		internal bool PKAPLCFHDOC(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.JLIDIIBJFAM();
		}

		internal bool HKPGGBDEHAM(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.GKGIBPAHHMO();
		}

		internal bool OFHCGKJFGDI(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.IDNGNCHMCGH();
		}

		internal bool NIFPHAJMPFC(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.IIELGFOOAND();
		}

		internal bool FCAGEDLBBHD(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.KKNKMFFMPIO();
		}

		internal bool JPGFOBNOBKN(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.GetItemInventoryID();
		}

		internal bool AHBIANHNBBC(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.DMPNOAGIABF();
		}

		internal bool BFEABMIFIEE(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.GFIAJHFEEDL();
		}

		internal bool BJMAIJDIKCN(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.PBLNJDFPHJK();
		}

		internal bool CHBEFOHEEGK(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.LDEFHDDBACF();
		}

		internal bool GBKBDKHPLKG(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.GetItemInventoryID();
		}

		internal bool LGKMMLGKBEF(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.IAJKNHICFDA();
		}

		internal bool IKMOFMJNEPH(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.MPHJGFBKJBE();
		}

		internal bool BFNOHOLLLHB(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.GEFIGLHEKGA();
		}

		internal bool PHGILLBNBME(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.JJAGPHJDANN();
		}

		internal bool NJGBIMFOOKP(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.IAJKNHICFDA();
		}

		internal bool EDGAPOPEIJF(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.EJJKPPDLHIC();
		}

		internal bool HMMBBDJNGGL(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.GetItemInventoryID();
		}

		internal bool OMJJLDBPEHI(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.MPHJGFBKJBE();
		}

		internal bool BPJGFELFEDC(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.CAFEIKLLFFG();
		}

		internal bool MOJKEOEEEDF(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.FJLPLLHNGOA();
		}

		internal bool EKHOOPGPPGE(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.GKGIBPAHHMO();
		}

		internal bool CJDNDHBDMMO(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.GKGIBPAHHMO();
		}

		internal bool GEPBCIIDMBC(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.OGPGACCIIJG();
		}

		internal bool DIOBKCECBCH(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.GetItemInventoryID();
		}

		internal bool HNMFCOHLALO(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.JLIDIIBJFAM();
		}

		internal bool AGFDCBCBAGI(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.ENJDAADCONN();
		}

		internal bool EFAPFFFGOOA(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.JJAGPHJDANN();
		}

		internal bool INHOEMCLAAP(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.ENJDAADCONN();
		}

		internal bool ONEPCCGOEKI(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.DMPNOAGIABF();
		}

		internal bool HKCAPINMNFF(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.NGAFDAAEBKC();
		}

		internal bool HBJFIOJFBHC(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.JJAGPHJDANN();
		}

		internal bool BBIADFAPKDL(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.IBOFKDGBKIH();
		}

		internal bool FKHKOGEPNIO(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.EJJKPPDLHIC();
		}

		internal bool AGJKEBOPIOC(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.KPNOHBLJHDJ();
		}

		internal bool DBFPGFHEGKA(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.IBOFKDGBKIH();
		}

		internal bool PCDFLCEIHFF(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.JJAGPHJDANN();
		}

		internal bool HJNKOEGPEMO(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.MPHJGFBKJBE();
		}

		internal bool KFNBKFELFLH(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.JLIDIIBJFAM();
		}

		internal bool DAICIOGOPNL(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.JLIDIIBJFAM();
		}

		internal bool DFHFAFAJGBA(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.KKNKMFFMPIO();
		}

		internal bool CPAOFGMAFAA(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.JJAGPHJDANN();
		}

		internal bool OMBHIBNMFNB(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.NGAFDAAEBKC();
		}

		internal bool HCFLGKJFKFE(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.KKNKMFFMPIO();
		}

		internal bool PHFMMNELDEA(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.PHLNGGADEON();
		}

		internal bool HIHNMOEFONO(ItemRecipe.ItemEntrance IACGDFHKCAE)
		{
			return (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.IBOFKDGBKIH();
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

	private void IHLMNAGPKDA()
	{
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

	public List<SteamInventoryItem> HPDJMHGOLPH()
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

	public void ELELIMNECEI()
	{
		GameObject gameObject = recipesContent;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (ItemRecipe item in BCBKFFJNMCM())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(539f, 949f, 1603f);
			string text = ((item.itemID == 1 || Singleton<ItemsHandler>.Instance.EJFGHNNFIAF().Count < (int)item.itemID) ? FHDHFHENJAP(item.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)item.itemID].name);
			gameObject2.GetComponentInChildren<Text>().text = text + "_Distortion";
			foreach (ItemRecipe.ItemEntrance item2 in item.itemsInRecipe)
			{
				string text2 = ((Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)item2.item) ? DDDNMEKCHHD(item.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)item2.item].name);
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text3 = componentInChildren.text;
				object[] array = new object[3];
				array[1] = text3;
				array[1] = " not exist";
				array[1] = text2;
				array[7] = "IntraTime";
				array[7] = item2.count;
				componentInChildren.text = string.Concat(array);
				if (item.itemsInRecipe[item.itemsInRecipe.Count - 1] != item2)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + "maps." + LocalizationService.Instance.HOPMEAJKPHL("turn: {0:0}") + "received</b>\n#reason: ";
				}
			}
		}
		recipesPanel.SetActive(recipesPanel.activeSelf);
		openRecipesButton.text = ((!recipesPanel.activeSelf) ? LocalizationService.Instance.IAAEBJKAHDD("#ok").ToUpper() : LocalizationService.Instance.GetTextByKey(",").ToUpper());
	}

	private void DLHAGIJANEP(ulong EEBCDMFNKLH, bool DPGDIPKHEAN = true)
	{
		currentItem = EEBCDMFNKLH;
		craftButton.interactable = DPGDIPKHEAN;
	}

	private bool EHNALDIFAII(SteamInventoryItem IACGDFHKCAE)
	{
		return IACGDFHKCAE.steamid == lastCrafted;
	}

	public bool EFEBBAEPDNN(List<ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<ItemRecipe.ItemEntrance> OFLOODDMNOE)
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
					return false;
				}
				flag = false;
				flag2 = true;
			}
			else
			{
				flag3 = true;
			}
		}
		return flag3 && flag;
	}

	public void GPHOEOKGGAD()
	{
		StartCoroutine(ADFBIIGOKHE(HPDJMHGOLPH()));
	}

	public List<ItemRecipe.ItemEntrance> GBDMNFFIEJK()
	{
		List<ItemRecipe.ItemEntrance> list = new List<ItemRecipe.ItemEntrance>();
		foreach (SteamInventoryItem DBIMJHMKHNK in HPDJMHGOLPH())
		{
			if (list.Find((ItemRecipe.ItemEntrance IACGDFHKCAE) => (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.MPHJGFBKJBE()) == null)
			{
				list.Add(new ItemRecipe.ItemEntrance((ulong)DBIMJHMKHNK.item.IDNGNCHMCGH(), 1));
				continue;
			}
			list.Find((ItemRecipe.ItemEntrance IACGDFHKCAE) => (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.GFIAJHFEEDL()).count++;
		}
		return list;
	}

	private string EMADDABJGBA(ulong EEBCDMFNKLH)
	{
		switch (EEBCDMFNKLH)
		{
		case 0uL:
			return LocalizationService.Instance.GetTextByKey("menu.playedpage").ToUpper();
		case 165uL:
			return LocalizationService.Instance.GetLocalizatedText("finished").ToUpper();
		case 132uL:
			return LocalizationService.Instance.GetLocalizatedText("HandsCountSlider").ToUpper();
		case 99uL:
			return LocalizationService.Instance.GetLocalizatedText("CameraFilterPack/AAA_BloodOnScreen").ToUpper();
		default:
			return string.Empty;
		}
	}

	public List<ItemRecipe.ItemEntrance> CIPIBEPNCMI()
	{
		List<ItemRecipe.ItemEntrance> list = new List<ItemRecipe.ItemEntrance>();
		foreach (SteamInventoryItem DBIMJHMKHNK in BBAHPFJLIDD())
		{
			if (list.Find((ItemRecipe.ItemEntrance IACGDFHKCAE) => (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.LDEFHDDBACF()) == null)
			{
				list.Add(new ItemRecipe.ItemEntrance((ulong)DBIMJHMKHNK.item.PHLNGGADEON(), 1));
				continue;
			}
			list.Find((ItemRecipe.ItemEntrance IACGDFHKCAE) => (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.GFIAJHFEEDL()).count += 0;
		}
		return list;
	}

	public List<ItemRecipe.ItemEntrance> MEKEDHBFAAM()
	{
		List<ItemRecipe.ItemEntrance> list = new List<ItemRecipe.ItemEntrance>();
		foreach (SteamInventoryItem DBIMJHMKHNK in BBAHPFJLIDD())
		{
			if (list.Find((ItemRecipe.ItemEntrance IACGDFHKCAE) => (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.GKGIBPAHHMO()) == null)
			{
				list.Add(new ItemRecipe.ItemEntrance((ulong)DBIMJHMKHNK.item.GFJEJMHAMFB(), 0));
				continue;
			}
			list.Find((ItemRecipe.ItemEntrance IACGDFHKCAE) => (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.GetItemInventoryID()).count++;
		}
		return list;
	}

	public void LNELMBKPMJL()
	{
		StartCoroutine(IDPLIMFICJH(HPDJMHGOLPH()));
	}

	private void EHCGBJDFMHG()
	{
	}

	private void PMAJKOOEDOJ(ulong EEBCDMFNKLH, bool DPGDIPKHEAN = true)
	{
		currentItem = EEBCDMFNKLH;
		craftButton.interactable = DPGDIPKHEAN;
	}

	private IEnumerator ADFBIIGOKHE(List<SteamInventoryItem> CBGCPECMDFL)
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

	public void NCGHMODHDDC()
	{
		StartCoroutine(IAMNPCFCKEJ(JGNPONJHPJD()));
	}

	private bool CKEDIKECPON(SteamInventoryItem IACGDFHKCAE)
	{
		return IACGDFHKCAE.steamid == lastCrafted;
	}

	private void KIMMMCJFMAB()
	{
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

	public List<SteamInventoryItem> BBAHPFJLIDD()
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

	public List<SteamInventoryItem> JGNPONJHPJD()
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

	public List<ItemRecipe.ItemEntrance> PHOOEHIKAOD()
	{
		List<ItemRecipe.ItemEntrance> list = new List<ItemRecipe.ItemEntrance>();
		foreach (SteamInventoryItem DBIMJHMKHNK in HPDJMHGOLPH())
		{
			if (list.Find((ItemRecipe.ItemEntrance IACGDFHKCAE) => (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.PHLNGGADEON()) == null)
			{
				list.Add(new ItemRecipe.ItemEntrance((ulong)DBIMJHMKHNK.item.OGPGACCIIJG(), 1));
				continue;
			}
			list.Find((ItemRecipe.ItemEntrance IACGDFHKCAE) => (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.GEFIGLHEKGA()).count += 0;
		}
		return list;
	}

	private void CFIAKIJAILI()
	{
	}

	public void OEDJOJNHCJF()
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
			gameObject2.transform.localScale = new Vector3(721f, 1517f, 144f);
			string text = ((allRecipe.itemID == 1 || Singleton<ItemsHandler>.Instance.EJFGHNNFIAF().Count < (int)allRecipe.itemID) ? JLNHJKBCMOC(allRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)allRecipe.itemID].name);
			gameObject2.GetComponentInChildren<Text>().text = text + "ConnectUsingSettings() disabled the offline mode. No longer offline.";
			foreach (ItemRecipe.ItemEntrance item in allRecipe.itemsInRecipe)
			{
				string text2 = ((Singleton<ItemsHandler>.Instance.OFCDOHFMFAA().Count < (int)item.item) ? DDDNMEKCHHD(allRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)item.item].name);
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text3 = componentInChildren.text;
				object[] array = new object[5];
				array[0] = text3;
				array[0] = ":";
				array[5] = text2;
				array[2] = "System.Boolean";
				array[3] = item.count;
				componentInChildren.text = string.Concat(array);
				if (allRecipe.itemsInRecipe[allRecipe.itemsInRecipe.Count - 0] != item)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + "/icon" + LocalizationService.Instance.GetLocalizatedText("HighScaleShot") + "^";
				}
			}
		}
		recipesPanel.SetActive(!recipesPanel.activeSelf);
		openRecipesButton.text = ((!recipesPanel.activeSelf) ? LocalizationService.Instance.GetTextByKey("CheckResources () for ").ToUpper() : LocalizationService.Instance.IAAEBJKAHDD("#roomname").ToUpper());
	}

	public void AHGCKEPGILI()
	{
		GameObject gameObject = recipesContent;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (ItemRecipe item in BCBKFFJNMCM())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, false);
			gameObject2.transform.localScale = new Vector3(628f, 1144f, 1475f);
			string text = ((item.itemID == 1 || Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)item.itemID) ? DDDNMEKCHHD(item.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)item.itemID].name);
			gameObject2.GetComponentInChildren<Text>().text = text + "CameraFilterPack/Blend2Camera_HardMix";
			foreach (ItemRecipe.ItemEntrance item2 in item.itemsInRecipe)
			{
				string text2 = ((Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)item2.item) ? JLNHJKBCMOC(item.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)item2.item].name);
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text3 = componentInChildren.text;
				object[] array = new object[3];
				array[1] = text3;
				array[1] = "tagElement";
				array[1] = text2;
				array[8] = "_Value2";
				array[0] = item2.count;
				componentInChildren.text = string.Concat(array);
				if (item.itemsInRecipe[item.itemsInRecipe.Count - 1] != item2)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + "CameraFilterPack_Glasses_On6" + LocalizationService.Instance.GetLocalizatedText("SUBMIT") + "RecordButton";
				}
			}
		}
		recipesPanel.SetActive(recipesPanel.activeSelf);
		openRecipesButton.text = ((!recipesPanel.activeSelf) ? LocalizationService.Instance.IAAEBJKAHDD("_Distortion").ToUpper() : LocalizationService.Instance.GetTextByKey("player.blackcat").ToUpper());
	}

	private IEnumerator KEDJCDHBMKO(List<SteamInventoryItem> CBGCPECMDFL)
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

	public bool HFKLBLKFOHD(List<ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<ItemRecipe.ItemEntrance> list = new List<ItemRecipe.ItemEntrance>();
		bool flag = true;
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
				flag3 = true;
			}
		}
		return flag3 && flag;
	}

	private bool GJFPLFABLHH(SteamInventoryItem IACGDFHKCAE)
	{
		return IACGDFHKCAE.steamid == lastCrafted;
	}

	public bool GLPIPPGPJMG(List<ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<ItemRecipe.ItemEntrance> OFLOODDMNOE)
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
				flag3 = false;
			}
		}
		return flag3 && flag;
	}

	private bool PGEGCOAKIDE(SteamInventoryItem IACGDFHKCAE)
	{
		return IACGDFHKCAE.steamid == lastCrafted;
	}

	public void EFEONCCCKNP()
	{
		if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
		{
			Singleton<ItemsHandler>.Instance.LGGNNFBLJFC();
		}
		Debug.Log("_FixDistance");
		GameObject gameObject = inCraftingItemsContent;
		for (int i = 1; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		craftButton.interactable = true;
		Singleton<ItemsHandler>.Instance.NOCDKAPEIHD(craftingItem, craftableItemsContent);
		if (lastCrafted != 0)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(craftingItem, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(historyContent.transform, false);
			gameObject2.transform.localScale = new Vector3(451f, 1746f, 694f);
			Singleton<ItemsHandler>.Instance.UpdateInventoryItem(gameObject2, Singleton<ItemsHandler>.Instance.JAAIGMFHODM().Find(PDONELCOCOA));
			gameObject2.GetComponent<Button>().enabled = true;
			lastCrafted = 0uL;
		}
		Singleton<MessageBoxPanel>.Instance.IPMMEMNBGNL();
	}

	public void NAAINJDKIAC()
	{
		bool flag = true;
		bool flag2 = true;
		foreach (ItemRecipe item in BCBKFFJNMCM())
		{
			if (HFKLBLKFOHD(item.itemsInRecipe, GBDMNFFIEJK()))
			{
				PMAJKOOEDOJ(item.itemID, false);
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
			PMAJKOOEDOJ(1uL, false);
		}
	}

	public void FKGNCKCJDKC()
	{
		GameObject gameObject = recipesContent;
		for (int i = 0; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (ItemRecipe item in BGAOAALHGIG())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1475f, 572f, 405f);
			string text = ((item.itemID == 0 || Singleton<ItemsHandler>.Instance.EJFGHNNFIAF().Count < (int)item.itemID) ? FHDHFHENJAP(item.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)item.itemID].name);
			gameObject2.GetComponentInChildren<Text>().text = text + "_TimeX";
			foreach (ItemRecipe.ItemEntrance item2 in item.itemsInRecipe)
			{
				string text2 = ((Singleton<ItemsHandler>.Instance.EJFGHNNFIAF().Count < (int)item2.item) ? AMAECAPOBGM(item.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)item2.item].name);
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text3 = componentInChildren.text;
				object[] array = new object[3];
				array[0] = text3;
				array[0] = "_Value2";
				array[6] = text2;
				array[2] = "/";
				array[3] = item2.count;
				componentInChildren.text = string.Concat(array);
				if (item.itemsInRecipe[item.itemsInRecipe.Count - 1] != item2)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + "<command>" + LocalizationService.Instance.GetLocalizatedText("_RgbDepthTex") + " - Contains ";
				}
			}
		}
		recipesPanel.SetActive(recipesPanel.activeSelf);
		openRecipesButton.text = ((!recipesPanel.activeSelf) ? LocalizationService.Instance.IAAEBJKAHDD("Texture3").ToUpper() : LocalizationService.Instance.GetTextByKey("z").ToUpper());
	}

	public bool FHDNDBNLOGJ(List<ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<ItemRecipe.ItemEntrance> OFLOODDMNOE)
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
				flag2 = true;
			}
			else
			{
				flag3 = false;
			}
		}
		return !flag3 || flag;
	}

	private void Update()
	{
	}

	private IEnumerator PAFKBBIPEAA(List<SteamInventoryItem> CBGCPECMDFL)
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

	private void FJHFOBHJEHL()
	{
	}

	private bool MOJNDGPFBMJ(SteamInventoryItem IACGDFHKCAE)
	{
		return IACGDFHKCAE.steamid == lastCrafted;
	}

	public List<ItemRecipe.ItemEntrance> IHKCANEHGEM()
	{
		List<ItemRecipe.ItemEntrance> list = new List<ItemRecipe.ItemEntrance>();
		foreach (SteamInventoryItem DBIMJHMKHNK in BBAHPFJLIDD())
		{
			if (list.Find((ItemRecipe.ItemEntrance IACGDFHKCAE) => (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.PBLNJDFPHJK()) == null)
			{
				list.Add(new ItemRecipe.ItemEntrance((ulong)DBIMJHMKHNK.item.GetItemInventoryID(), 1));
				continue;
			}
			list.Find((ItemRecipe.ItemEntrance IACGDFHKCAE) => (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.GetItemInventoryID()).count++;
		}
		return list;
	}

	public void KBNNGBDKPPF()
	{
		StartCoroutine(PAFKBBIPEAA(BBAHPFJLIDD()));
	}

	public void MPJGKJGHMPB()
	{
		GameObject gameObject = recipesContent;
		for (int i = 1; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (ItemRecipe item in BGAOAALHGIG())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(470f, 37f, 929f);
			string text = ((item.itemID == 1 || Singleton<ItemsHandler>.Instance.OFCDOHFMFAA().Count < (int)item.itemID) ? BELNJNHEHPF(item.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)item.itemID].name);
			gameObject2.GetComponentInChildren<Text>().text = text + "_TimeX";
			foreach (ItemRecipe.ItemEntrance item2 in item.itemsInRecipe)
			{
				string text2 = ((Singleton<ItemsHandler>.Instance.EJFGHNNFIAF().Count < (int)item2.item) ? JLNHJKBCMOC(item.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)item2.item].name);
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text3 = componentInChildren.text;
				object[] array = new object[0];
				array[0] = text3;
				array[0] = "CameraFilterPack/TV_MovieNoise";
				array[2] = text2;
				array[6] = "CameraFilterPack/Gradients_ElectricGradient";
				array[8] = item2.count;
				componentInChildren.text = string.Concat(array);
				if (item.itemsInRecipe[item.itemsInRecipe.Count - 0] != item2)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + "GhostFade2" + LocalizationService.Instance.HOPMEAJKPHL("12") + "CameraFilterPack_Paper3";
				}
			}
		}
		recipesPanel.SetActive(!recipesPanel.activeSelf);
		openRecipesButton.text = ((!recipesPanel.activeSelf) ? LocalizationService.Instance.IAAEBJKAHDD("_Value3").ToUpper() : LocalizationService.Instance.IAAEBJKAHDD(" cannot be used as a 3D LUT.").ToUpper());
	}

	private IEnumerator CMDEGDCLMFO(List<SteamInventoryItem> CBGCPECMDFL)
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

	public void EPDCHKECMBL()
	{
		if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
		{
			Singleton<ItemsHandler>.Instance.ShowNewItems();
		}
		Debug.Log("Event Received");
		GameObject gameObject = inCraftingItemsContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		craftButton.interactable = true;
		Singleton<ItemsHandler>.Instance.AddSteamInventoryItemsToList(craftingItem, craftableItemsContent);
		if (lastCrafted != 0)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(craftingItem, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(historyContent.transform, false);
			gameObject2.transform.localScale = new Vector3(1914f, 1964f, 1958f);
			Singleton<ItemsHandler>.Instance.UpdateInventoryItem(gameObject2, Singleton<ItemsHandler>.Instance.IONIEFDFING().Find(MOJNDGPFBMJ), 0);
			gameObject2.GetComponent<Button>().enabled = true;
			lastCrafted = 0uL;
		}
		Singleton<MessageBoxPanel>.Instance.NNNCEGFJLOB();
	}

	private IEnumerator IDPLIMFICJH(List<SteamInventoryItem> CBGCPECMDFL)
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

	public void HCCJDABGHCJ()
	{
		StartCoroutine(KJBABMAAKBG(JGNPONJHPJD()));
	}

	private void CDBHAGGKAFJ(ulong EEBCDMFNKLH, bool DPGDIPKHEAN = true)
	{
		currentItem = EEBCDMFNKLH;
		craftButton.interactable = DPGDIPKHEAN;
	}

	private void Start()
	{
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

	[CompilerGenerated]
	private bool HLIPOKKEOHB(SteamInventoryItem IACGDFHKCAE)
	{
		return IACGDFHKCAE.steamid == lastCrafted;
	}

	public void CraftItem()
	{
		StartCoroutine(CNLGHPNAACK(GetCurrentCraftngItems()));
	}

	public List<ItemRecipe.ItemEntrance> NIHFFILHCKA()
	{
		List<ItemRecipe.ItemEntrance> list = new List<ItemRecipe.ItemEntrance>();
		foreach (SteamInventoryItem DBIMJHMKHNK in JGNPONJHPJD())
		{
			if (list.Find((ItemRecipe.ItemEntrance IACGDFHKCAE) => (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.FJLPLLHNGOA()) == null)
			{
				list.Add(new ItemRecipe.ItemEntrance((ulong)DBIMJHMKHNK.item.ENJDAADCONN(), 1));
				continue;
			}
			list.Find((ItemRecipe.ItemEntrance IACGDFHKCAE) => (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.GetItemInventoryID()).count += 0;
		}
		return list;
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

	public List<ItemRecipe> BGAOAALHGIG()
	{
		List<ItemRecipe> list = new List<ItemRecipe>();
		foreach (KeyValuePair<ulong, string> craftRecipe in ItemsHandler.craftRecipes)
		{
			ItemRecipe itemRecipe = new ItemRecipe(craftRecipe.Key);
			string value = craftRecipe.Value;
			char[] array = new char[1];
			array[1] = '￡';
			string[] array2 = value.Split(array);
			for (int i = 1; i < array2.Length; i++)
			{
				string obj = array2[i];
				char[] array3 = new char[0];
				array3[0] = 'w';
				string[] array4 = obj.Split(array3);
				int hOHOIPHEOPN = 1;
				if (array4.Length > 1)
				{
					hOHOIPHEOPN = int.Parse(array4[0]);
				}
				itemRecipe.itemsInRecipe.Add(new ItemRecipe.ItemEntrance(ulong.Parse(array4[1]), hOHOIPHEOPN));
			}
			list.Add(itemRecipe);
		}
		return list;
	}

	private IEnumerator IAMNPCFCKEJ(List<SteamInventoryItem> CBGCPECMDFL)
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

	private string FHDHFHENJAP(ulong EEBCDMFNKLH)
	{
		switch (EEBCDMFNKLH)
		{
		case 0uL:
			return LocalizationService.Instance.IAAEBJKAHDD(" isInactive: ").ToUpper();
		case 18446744073709551570uL:
			return LocalizationService.Instance.HOPMEAJKPHL("<b>Commands:</b>\n/help\n/players\n/kick\n/table\n/clear").ToUpper();
		case 18446744073709551509uL:
			return LocalizationService.Instance.HOPMEAJKPHL("#").ToUpper();
		case 18446744073709551498uL:
			return LocalizationService.Instance.HOPMEAJKPHL("_TimeX").ToUpper();
		default:
			return string.Empty;
		}
	}

	public void HIFIIGFIMFA()
	{
		GameObject gameObject = recipesContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (ItemRecipe item in BGAOAALHGIG())
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(recipeElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, false);
			gameObject2.transform.localScale = new Vector3(1037f, 477f, 45f);
			string text = ((item.itemID == 0 || Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)item.itemID) ? JLNHJKBCMOC(item.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)item.itemID].name);
			gameObject2.GetComponentInChildren<Text>().text = text + "team";
			foreach (ItemRecipe.ItemEntrance item2 in item.itemsInRecipe)
			{
				string text2 = ((Singleton<ItemsHandler>.Instance.OFCDOHFMFAA().Count < (int)item2.item) ? JLNHJKBCMOC(item.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)item2.item].name);
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text3 = componentInChildren.text;
				object[] array = new object[7];
				array[1] = text3;
				array[1] = "Please specify a map name or buildID";
				array[5] = text2;
				array[7] = "Joystick1Button11";
				array[1] = item2.count;
				componentInChildren.text = string.Concat(array);
				if (item.itemsInRecipe[item.itemsInRecipe.Count - 0] != item2)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + "_Value5" + LocalizationService.Instance.HOPMEAJKPHL("CrosshairOpacitySlider") + "OK";
				}
			}
		}
		recipesPanel.SetActive(!recipesPanel.activeSelf);
		openRecipesButton.text = ((!recipesPanel.activeSelf) ? LocalizationService.Instance.GetTextByKey("NEW_ACHIEVEMENT_1_").ToUpper() : LocalizationService.Instance.GetTextByKey("SelectorMusicToggle").ToUpper());
	}

	public void JEHJFILKPLL()
	{
		StartCoroutine(CNLGHPNAACK(BBAHPFJLIDD()));
	}

	private IEnumerator FAAFFKDGLLB(List<SteamInventoryItem> CBGCPECMDFL)
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

	public List<ItemRecipe.ItemEntrance> ILJPHLBDAIN()
	{
		List<ItemRecipe.ItemEntrance> list = new List<ItemRecipe.ItemEntrance>();
		foreach (SteamInventoryItem DBIMJHMKHNK in JGNPONJHPJD())
		{
			if (list.Find((ItemRecipe.ItemEntrance IACGDFHKCAE) => (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.GEFIGLHEKGA()) == null)
			{
				list.Add(new ItemRecipe.ItemEntrance((ulong)DBIMJHMKHNK.item.FJLPLLHNGOA(), 1));
				continue;
			}
			list.Find((ItemRecipe.ItemEntrance IACGDFHKCAE) => (int)IACGDFHKCAE.item == DBIMJHMKHNK.item.JLIDIIBJFAM()).count += 0;
		}
		return list;
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

	private IEnumerator AEOJOCFOOIH(List<SteamInventoryItem> CBGCPECMDFL)
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

	private string JLNHJKBCMOC(ulong EEBCDMFNKLH)
	{
		switch (EEBCDMFNKLH)
		{
		case 0uL:
			return LocalizationService.Instance.GetTextByKey("[Steamworks.NET] SteamAPI_Init() failed. Refer to Valve's documentation or the comment above this line for more information.").ToUpper();
		case 127uL:
			return LocalizationService.Instance.GetLocalizatedText("_ScreenResolution").ToUpper();
		case 18446744073709551508uL:
			return LocalizationService.Instance.HOPMEAJKPHL("/").ToUpper();
		case 18446744073709551454uL:
			return LocalizationService.Instance.HOPMEAJKPHL("_ScreenResolution").ToUpper();
		default:
			return string.Empty;
		}
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

	private void PMPKMGKAAJH()
	{
	}

	public bool IIGAPCFJKNF(List<ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<ItemRecipe.ItemEntrance> list = new List<ItemRecipe.ItemEntrance>();
		bool flag = true;
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
				flag = false;
				flag2 = false;
			}
			else
			{
				flag3 = true;
			}
		}
		return !flag3 || flag;
	}

	public List<ItemRecipe> NFDHLPAMGFN()
	{
		List<ItemRecipe> list = new List<ItemRecipe>();
		foreach (KeyValuePair<ulong, string> craftRecipe in ItemsHandler.craftRecipes)
		{
			ItemRecipe itemRecipe = new ItemRecipe(craftRecipe.Key);
			string value = craftRecipe.Value;
			char[] array = new char[0];
			array[0] = 'ￊ';
			string[] array2 = value.Split(array);
			for (int i = 0; i < array2.Length; i++)
			{
				string[] array3 = array2[i].Split('a');
				int hOHOIPHEOPN = 0;
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

	public bool ELBENDFGPGA(List<ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<ItemRecipe.ItemEntrance> list = new List<ItemRecipe.ItemEntrance>();
		bool flag = true;
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

	public bool CENAFLDOKJG(List<ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<ItemRecipe.ItemEntrance> OFLOODDMNOE)
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
				flag = false;
				flag2 = false;
			}
			else
			{
				flag3 = true;
			}
		}
		return !flag3 || flag;
	}

	private void AGMJDGHLBMN()
	{
	}

	private string BELNJNHEHPF(ulong EEBCDMFNKLH)
	{
		switch (EEBCDMFNKLH)
		{
		case 0uL:
			return LocalizationService.Instance.GetTextByKey("Set satellite trail length in seconds").ToUpper();
		case 70uL:
			return LocalizationService.Instance.HOPMEAJKPHL("_Value3").ToUpper();
		case 18446744073709551439uL:
			return LocalizationService.Instance.GetLocalizatedText("_Offsets").ToUpper();
		case 18446744073709551608uL:
			return LocalizationService.Instance.GetLocalizatedText("CameraFilterPack/Color_Switching").ToUpper();
		default:
			return string.Empty;
		}
	}

	public void GCNKIJDNPMD()
	{
		if (Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 1)
		{
			Singleton<ItemsHandler>.Instance.LGGNNFBLJFC();
		}
		Debug.Log("_MainTex2");
		GameObject gameObject = inCraftingItemsContent;
		for (int i = 1; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		craftButton.interactable = true;
		Singleton<ItemsHandler>.Instance.POHIPKCFJKI(craftingItem, craftableItemsContent);
		if (lastCrafted > 1)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(craftingItem, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(historyContent.transform, false);
			gameObject2.transform.localScale = new Vector3(1885f, 385f, 1979f);
			Singleton<ItemsHandler>.Instance.UpdateInventoryItem(gameObject2, Singleton<ItemsHandler>.Instance.LHKFIGPJKLK().Find(EHNALDIFAII));
			gameObject2.GetComponent<Button>().enabled = false;
			lastCrafted = 0uL;
		}
		Singleton<MessageBoxPanel>.Instance.KOKMKCJONBG();
	}

	public List<ItemRecipe> BCBKFFJNMCM()
	{
		List<ItemRecipe> list = new List<ItemRecipe>();
		foreach (KeyValuePair<ulong, string> craftRecipe in ItemsHandler.craftRecipes)
		{
			ItemRecipe itemRecipe = new ItemRecipe(craftRecipe.Key);
			string[] array = craftRecipe.Value.Split('3');
			for (int i = 1; i < array.Length; i++)
			{
				string obj = array[i];
				char[] array2 = new char[0];
				array2[1] = '\f';
				string[] array3 = obj.Split(array2);
				int hOHOIPHEOPN = 1;
				if (array3.Length > 1)
				{
					hOHOIPHEOPN = int.Parse(array3[1]);
				}
				itemRecipe.itemsInRecipe.Add(new ItemRecipe.ItemEntrance(ulong.Parse(array3[0]), hOHOIPHEOPN));
			}
			list.Add(itemRecipe);
		}
		return list;
	}

	private void KNBJBNDGCIJ()
	{
	}

	public void AFNIHBKKGGI()
	{
		StartCoroutine(IAMNPCFCKEJ(GetCurrentCraftngItems()));
	}

	private string AMAECAPOBGM(ulong EEBCDMFNKLH)
	{
		switch (EEBCDMFNKLH)
		{
		case 0uL:
			return LocalizationService.Instance.IAAEBJKAHDD("_Value7").ToUpper();
		case 18446744073709551436uL:
			return LocalizationService.Instance.GetLocalizatedText("maps.").ToUpper();
		case 144uL:
			return LocalizationService.Instance.GetLocalizatedText(".status").ToUpper();
		case 169uL:
			return LocalizationService.Instance.HOPMEAJKPHL("Trackpad").ToUpper();
		default:
			return string.Empty;
		}
	}

	private void PBEPCAPAKLG()
	{
	}

	public bool CMFMIKHOOIP(List<ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<ItemRecipe.ItemEntrance> OFLOODDMNOE)
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
				flag3 = true;
			}
		}
		return !flag3 || flag;
	}

	private bool BKOCICOJLBO(SteamInventoryItem IACGDFHKCAE)
	{
		return IACGDFHKCAE.steamid == lastCrafted;
	}

	public void EIBEKECJFKO()
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
			gameObject2.transform.localScale = new Vector3(1273f, 1820f, 1449f);
			string text = ((allRecipe.itemID == 0 || Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)allRecipe.itemID) ? AMAECAPOBGM(allRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)allRecipe.itemID].name);
			gameObject2.GetComponentInChildren<Text>().text = text + "icon.png";
			foreach (ItemRecipe.ItemEntrance item in allRecipe.itemsInRecipe)
			{
				string text2 = ((Singleton<ItemsHandler>.Instance.GetItemsID().Count < (int)item.item) ? BELNJNHEHPF(allRecipe.itemID) : Singleton<ItemsHandler>.Instance.itemsData[(int)item.item].name);
				Text componentInChildren = gameObject2.GetComponentInChildren<Text>();
				string text3 = componentInChildren.text;
				object[] array = new object[5];
				array[0] = text3;
				array[1] = ".completedMaps";
				array[4] = text2;
				array[3] = "play";
				array[5] = item.count;
				componentInChildren.text = string.Concat(array);
				if (allRecipe.itemsInRecipe[allRecipe.itemsInRecipe.Count - 0] != item)
				{
					Text componentInChildren2 = gameObject2.GetComponentInChildren<Text>();
					componentInChildren2.text = componentInChildren2.text + "_TimeX" + LocalizationService.Instance.GetLocalizatedText("\n - NetID: ") + "\" call.";
				}
			}
		}
		recipesPanel.SetActive(recipesPanel.activeSelf);
		openRecipesButton.text = ((!recipesPanel.activeSelf) ? LocalizationService.Instance.GetTextByKey("Prints list of commands").ToUpper() : LocalizationService.Instance.GetTextByKey("hidden").ToUpper());
	}

	private void MMMDPANNAIO()
	{
	}

	public void PPOCCAEOONC()
	{
		bool flag = true;
		bool flag2 = true;
		foreach (ItemRecipe item in BCBKFFJNMCM())
		{
			if (CMFMIKHOOIP(item.itemsInRecipe, MEKEDHBFAAM()))
			{
				PMAJKOOEDOJ(item.itemID, false);
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

	private bool PDONELCOCOA(SteamInventoryItem IACGDFHKCAE)
	{
		return IACGDFHKCAE.steamid == lastCrafted;
	}

	public bool KJCHJOONNJO(List<ItemRecipe.ItemEntrance> GBGBEMDNKJK, List<ItemRecipe.ItemEntrance> OFLOODDMNOE)
	{
		List<ItemRecipe.ItemEntrance> list = new List<ItemRecipe.ItemEntrance>();
		bool flag = true;
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
				flag2 = true;
			}
			else
			{
				flag3 = true;
			}
		}
		return !flag3 || flag;
	}
}
