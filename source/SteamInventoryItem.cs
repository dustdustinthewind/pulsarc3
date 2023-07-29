// SteamInventoryItem
public class SteamInventoryItem
{
	public ulong steamid;

	public InventoryItemData item;

	public bool isLocal;

	public SteamInventoryItem(ulong MOANAJGGPLK, InventoryItemData DBIMJHMKHNK, bool NIGBAPGIKDF = false)
	{
		steamid = MOANAJGGPLK;
		item = DBIMJHMKHNK;
		isLocal = NIGBAPGIKDF;
	}

	public SteamInventoryItem(SteamInventoryItem POONBAIJMMC)
	{
		steamid = POONBAIJMMC.steamid;
		item = POONBAIJMMC.item;
		isLocal = POONBAIJMMC.isLocal;
	}
}
