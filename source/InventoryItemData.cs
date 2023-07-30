// InventoryItemData
using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using UnityEngine;

[Serializable]
public class InventoryItemData
{
	public string id;

	public string name = "No Name";

	public string description = "No Description";

	public Sprite icon;

	public InventoryItemType type;

	public InventoryItemRarity rarity;

	public int EHEPGMIBFKO()
	{
		return Singleton<ItemsHandler>.Instance.GetItemsID().FindIndex(DANGBPAFCJO);
	}

	private bool OHPKFOMAJHL(string IACGDFHKCAE)
	{
		return IACGDFHKCAE == id;
	}

	private bool DMEKNNHLGAL(string IACGDFHKCAE)
	{
		return IACGDFHKCAE == id;
	}

	public int JIAPOILPHLA()
	{
		return Singleton<ItemsHandler>.Instance.GetItemsID().FindIndex(NKBNLAGDCDA);
	}

	private bool CJNCIMHNNIL(string IACGDFHKCAE)
	{
		return IACGDFHKCAE == id;
	}

	public int GFIAJHFEEDL()
	{
		return Singleton<ItemsHandler>.Instance.GetItemsID().FindIndex(GJFPINDECBI);
	}

	private bool OEMNPBEABDK(string IACGDFHKCAE)
	{
		return IACGDFHKCAE == id;
	}

	public InventoryItemData()
	{
	}

	public int JAMGADDBEPG()
	{
		return Singleton<ItemsHandler>.Instance.GetItemsID().FindIndex(PMEDILNAIDE);
	}

	private bool DAOJNDBLHAO(string IACGDFHKCAE)
	{
		return IACGDFHKCAE == id;
	}

	public int JJAGPHJDANN()
	{
		return Singleton<ItemsHandler>.Instance.GetItemsID().FindIndex(PMEHJHIIHDK);
	}

	public int OAKIKELAPIK()
	{
		return Singleton<ItemsHandler>.Instance.GetItemsID().FindIndex(PMEHJHIIHDK);
	}

	private bool ODPDGBGBOAI(string IACGDFHKCAE)
	{
		return IACGDFHKCAE == id;
	}

	public int MPGLFKMEBAF()
	{
		return Singleton<ItemsHandler>.Instance.GetItemsID().FindIndex(JDLHKDGIECM);
	}

	private bool CHBOGIHGEAF(string IACGDFHKCAE)
	{
		return IACGDFHKCAE == id;
	}

	public int DIJIPJOMFAK()
	{
		return Singleton<ItemsHandler>.Instance.GetItemsID().FindIndex(IMBDBCPHOIN);
	}

	private bool HFNAACDIGFD(string IACGDFHKCAE)
	{
		return IACGDFHKCAE == id;
	}

	public int KHAKCOOFJIL()
	{
		return Singleton<ItemsHandler>.Instance.GetItemsID().FindIndex(GJFPINDECBI);
	}

	public int KOGCJEHOCOA()
	{
		return Singleton<ItemsHandler>.Instance.GetItemsID().FindIndex(IMBDBCPHOIN);
	}

	private bool MBDOMMIKHGI(string IACGDFHKCAE)
	{
		return IACGDFHKCAE == id;
	}

	public InventoryItemData(string JMMILEFMACB)
	{
		TextAsset textAsset = Resources.Load<TextAsset>("Items/" + JMMILEFMACB + "/config");
		InventoryItemData inventoryItemData = JsonConvert.DeserializeObject<InventoryItemData>(textAsset.text);
		id = inventoryItemData.id;
		name = inventoryItemData.name;
		description = inventoryItemData.description;
		type = inventoryItemData.type;
		rarity = inventoryItemData.rarity;
		icon = Resources.Load<Sprite>("Items/" + JMMILEFMACB + "/icon");
	}

	public int GKGIBPAHHMO()
	{
		return Singleton<ItemsHandler>.Instance.GetItemsID().FindIndex(IJFOBHEPNAG);
	}

	private bool OHHHKJAKAIF(string IACGDFHKCAE)
	{
		return IACGDFHKCAE == id;
	}

	private bool GJFPINDECBI(string IACGDFHKCAE)
	{
		return IACGDFHKCAE == id;
	}

	private bool HIDOIEBLBJP(string IACGDFHKCAE)
	{
		return IACGDFHKCAE == id;
	}

	public int MPHJGFBKJBE()
	{
		return Singleton<ItemsHandler>.Instance.GetItemsID().FindIndex(JDLHKDGIECM);
	}

	private bool CKCHAGFGMDG(string IACGDFHKCAE)
	{
		return IACGDFHKCAE == id;
	}

	public int CCHGOBICNAD()
	{
		return Singleton<ItemsHandler>.Instance.GetItemsID().FindIndex(ONLOLKLLMLM);
	}

	private bool DANGBPAFCJO(string IACGDFHKCAE)
	{
		return IACGDFHKCAE == id;
	}

	private bool FDOJPPODFPN(string IACGDFHKCAE)
	{
		return IACGDFHKCAE == id;
	}

	private bool DKICHECPCJP(string IACGDFHKCAE)
	{
		return IACGDFHKCAE == id;
	}

	private bool PMEHJHIIHDK(string IACGDFHKCAE)
	{
		return IACGDFHKCAE == id;
	}

	public int CHOCPBEDKMP()
	{
		return Singleton<ItemsHandler>.Instance.GetItemsID().FindIndex(NKBNLAGDCDA);
	}

	private bool OCFAFACLAGC(string IACGDFHKCAE)
	{
		return IACGDFHKCAE == id;
	}

	private bool IPMPHEFDNDE(string IACGDFHKCAE)
	{
		return IACGDFHKCAE == id;
	}

	public int EANMGMCLNLD()
	{
		return Singleton<ItemsHandler>.Instance.GetItemsID().FindIndex(OCFAFACLAGC);
	}

	private bool FPADFGHNHPI(string IACGDFHKCAE)
	{
		return IACGDFHKCAE == id;
	}

	private bool CNKLAPBPEID(string IACGDFHKCAE)
	{
		return IACGDFHKCAE == id;
	}

	private bool IFKHOLCMJMK(string IACGDFHKCAE)
	{
		return IACGDFHKCAE == id;
	}

	private bool AAIDCDKHGHC(string IACGDFHKCAE)
	{
		return IACGDFHKCAE == id;
	}

	public int FCOOIFPMEAB()
	{
		return Singleton<ItemsHandler>.Instance.GetItemsID().FindIndex(DAOJNDBLHAO);
	}

	public int GetItemInventoryID()
	{
		return Singleton<ItemsHandler>.Instance.GetItemsID().FindIndex((string IACGDFHKCAE) => IACGDFHKCAE == id);
	}

	public int EJJKPPDLHIC()
	{
		return Singleton<ItemsHandler>.Instance.GetItemsID().FindIndex(DPJABKCGPOJ);
	}

	public int OKNEKGKLOJF()
	{
		return Singleton<ItemsHandler>.Instance.GetItemsID().FindIndex(PMEHJHIIHDK);
	}

	private bool IJFOBHEPNAG(string IACGDFHKCAE)
	{
		return IACGDFHKCAE == id;
	}

	private bool KDIHHPPDEGG(string IACGDFHKCAE)
	{
		return IACGDFHKCAE == id;
	}

	public int GELGKMKDHML()
	{
		return Singleton<ItemsHandler>.Instance.GetItemsID().FindIndex(IFKHOLCMJMK);
	}

	public int HECDOKAIGEL()
	{
		return Singleton<ItemsHandler>.Instance.GetItemsID().FindIndex(AAIDCDKHGHC);
	}

	public int BBALBMNJGMD()
	{
		return Singleton<ItemsHandler>.Instance.GetItemsID().FindIndex(KDIHHPPDEGG);
	}

	private bool JDLHKDGIECM(string IACGDFHKCAE)
	{
		return IACGDFHKCAE == id;
	}

	private bool IMBDBCPHOIN(string IACGDFHKCAE)
	{
		return IACGDFHKCAE == id;
	}

	private bool DPJABKCGPOJ(string IACGDFHKCAE)
	{
		return IACGDFHKCAE == id;
	}

	private bool KGDDEBGPMNG(string IACGDFHKCAE)
	{
		return IACGDFHKCAE == id;
	}

	public int PBOLGNEHAAK()
	{
		return Singleton<ItemsHandler>.Instance.GetItemsID().FindIndex(OEMNPBEABDK);
	}

	public int FJLPLLHNGOA()
	{
		return Singleton<ItemsHandler>.Instance.GetItemsID().FindIndex(NKBNLAGDCDA);
	}

	private bool ODOCKKBHPPI(string IACGDFHKCAE)
	{
		return IACGDFHKCAE == id;
	}

	public int IIELGFOOAND()
	{
		return Singleton<ItemsHandler>.Instance.GetItemsID().FindIndex(ODOCKKBHPPI);
	}

	private bool ONLOLKLLMLM(string IACGDFHKCAE)
	{
		return IACGDFHKCAE == id;
	}

	[CompilerGenerated]
	private bool NLPDILIKBLA(string IACGDFHKCAE)
	{
		return IACGDFHKCAE == id;
	}

	private bool NKBNLAGDCDA(string IACGDFHKCAE)
	{
		return IACGDFHKCAE == id;
	}

	private bool PMEDILNAIDE(string IACGDFHKCAE)
	{
		return IACGDFHKCAE == id;
	}
}
