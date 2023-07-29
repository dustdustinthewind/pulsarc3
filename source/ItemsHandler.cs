// ItemsHandler
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Steamworks;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.UI;

public class ItemsHandler : Singleton<ItemsHandler>
{
	[CompilerGenerated]
	private sealed class IHAFGMJBHMB
	{
		internal int EEBCDMFNKLH;

		internal bool PBCAHKDLFPE(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == EEBCDMFNKLH;
		}

		internal bool OLIGLEMPFOP(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == EEBCDMFNKLH;
		}

		internal bool AEINPAGJFME(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == EEBCDMFNKLH;
		}

		internal bool JKEDCEOCPJO(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == EEBCDMFNKLH;
		}

		internal bool DBFPGFHEGKA(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == EEBCDMFNKLH;
		}

		internal bool JDELIMPGFDJ(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == EEBCDMFNKLH;
		}

		internal bool LHHFJBIAHCN(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == EEBCDMFNKLH;
		}

		internal bool FFEGPHJKMFK(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == EEBCDMFNKLH;
		}

		internal bool MEMPOPNAEDN(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == EEBCDMFNKLH;
		}

		internal bool DKGPCPBNDPK(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == EEBCDMFNKLH;
		}

		internal bool LNDGINDKPFA(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == EEBCDMFNKLH;
		}

		internal bool LLNDDFGPOPL(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == EEBCDMFNKLH;
		}

		internal bool BFEABMIFIEE(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == EEBCDMFNKLH;
		}

		internal bool EGKGJJGAPMN(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == EEBCDMFNKLH;
		}

		internal bool LOEAMHGMMPK(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == EEBCDMFNKLH;
		}

		internal bool KFNBKFELFLH(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == EEBCDMFNKLH;
		}

		internal bool FIPCLHEKKCA(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == EEBCDMFNKLH;
		}

		internal bool EKHOOPGPPGE(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == EEBCDMFNKLH;
		}

		internal bool GBKBDKHPLKG(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == EEBCDMFNKLH;
		}

		internal bool BDGDIDPDBHG(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == EEBCDMFNKLH;
		}

		internal bool BKNHHGBPLGH(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == EEBCDMFNKLH;
		}

		internal bool OFHCGKJFGDI(KeyValuePair<int, string> IACGDFHKCAE)
		{
			return IACGDFHKCAE.Key == EEBCDMFNKLH;
		}
	}

	[CompilerGenerated]
	private sealed class LEMIJMHKLLM
	{
		internal int EGMPIBBOEMH;

		internal ItemsHandler ADPIKBBAKHP;

		internal bool BFEABMIFIEE(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool AEINPAGJFME(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool MEMPOPNAEDN(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool LOEAMHGMMPK(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool DKGPCPBNDPK(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool EKHOOPGPPGE(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool BKNHHGBPLGH(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool PBCAHKDLFPE(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool JKEDCEOCPJO(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool GBKBDKHPLKG(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool OLIGLEMPFOP(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool FFEGPHJKMFK(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool JDELIMPGFDJ(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool LLNDDFGPOPL(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool LNDGINDKPFA(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool OFHCGKJFGDI(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool EGKGJJGAPMN(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool KFNBKFELFLH(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool FIPCLHEKKCA(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool LHHFJBIAHCN(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool BDGDIDPDBHG(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}

		internal bool DBFPGFHEGKA(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ADPIKBBAKHP.IHIFDJEOGGK[ADPIKBBAKHP.NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef];
		}
	}

	[CompilerGenerated]
	private sealed class MOKFDBBHABE
	{
		internal string JMMILEFMACB;

		internal bool EKHOOPGPPGE(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(JMMILEFMACB);
		}

		internal bool BKNHHGBPLGH(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(JMMILEFMACB);
		}

		internal bool OLIGLEMPFOP(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(JMMILEFMACB);
		}

		internal bool BDGDIDPDBHG(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(JMMILEFMACB);
		}

		internal bool MEMPOPNAEDN(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(JMMILEFMACB);
		}

		internal bool KFNBKFELFLH(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(JMMILEFMACB);
		}

		internal bool JKEDCEOCPJO(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(JMMILEFMACB);
		}

		internal bool AEINPAGJFME(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(JMMILEFMACB);
		}

		internal bool LLNDDFGPOPL(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(JMMILEFMACB);
		}

		internal bool PBCAHKDLFPE(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(JMMILEFMACB);
		}

		internal bool LOEAMHGMMPK(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(JMMILEFMACB);
		}

		internal bool LNDGINDKPFA(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(JMMILEFMACB);
		}

		internal bool GBKBDKHPLKG(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(JMMILEFMACB);
		}

		internal bool DBFPGFHEGKA(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(JMMILEFMACB);
		}

		internal bool BFEABMIFIEE(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == ulong.Parse(JMMILEFMACB);
		}
	}

	[CompilerGenerated]
	private sealed class MOCPGDGNNCN
	{
		internal InventoryItemType CJEIKDHCCOI;

		internal bool LHHFJBIAHCN(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool LLNDDFGPOPL(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool MEMPOPNAEDN(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool EGKGJJGAPMN(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool GBKBDKHPLKG(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool FFEGPHJKMFK(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool KGKMOLCPDIH(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool FIPCLHEKKCA(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool IGFOBPKFCDJ(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool BMAOCLKPNNC(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool PIJAOCFAPKC(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool LOEAMHGMMPK(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool DBFPGFHEGKA(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool LNDGINDKPFA(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool BDGDIDPDBHG(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool JDELIMPGFDJ(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool EKHOOPGPPGE(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool OLIGLEMPFOP(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool FJDBPPKABJE(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool OFHCGKJFGDI(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool DKGPCPBNDPK(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool JKEDCEOCPJO(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool HBJFIOJFBHC(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool PBCAHKDLFPE(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool AGJKEBOPIOC(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool BKNHHGBPLGH(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool KFNBKFELFLH(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool AEINPAGJFME(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}

		internal bool BFEABMIFIEE(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.item.type == CJEIKDHCCOI;
		}
	}

	[CompilerGenerated]
	private sealed class FPDJBMKIHEE
	{
		internal ulong MOANAJGGPLK;

		internal bool FIPCLHEKKCA(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool AGJKEBOPIOC(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool BEBAENEJFLD(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool KGKMOLCPDIH(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool FHFECFLBHMA(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool JDELIMPGFDJ(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool PBCAHKDLFPE(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool BMAOCLKPNNC(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool MEMPOPNAEDN(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool JKEDCEOCPJO(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool FCAGEDLBBHD(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool GBKBDKHPLKG(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool BKNHHGBPLGH(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool HBJFIOJFBHC(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool EKHOOPGPPGE(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool LOEAMHGMMPK(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool LJDLIIIPIIJ(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool LNDGINDKPFA(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool EGKGJJGAPMN(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool JBAJEMGOPDL(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool BJMAIJDIKCN(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool BFEABMIFIEE(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool MGENGAEDACG(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool OFHCGKJFGDI(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool LHHFJBIAHCN(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool FDAIFOAGDLA(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool KFNBKFELFLH(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool DKGPCPBNDPK(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool FMIHBNPKEEO(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool OFLDIMDDLHM(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool IGFOBPKFCDJ(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool INHOEMCLAAP(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool DBFPGFHEGKA(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool FJDBPPKABJE(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool DNIMHEKGJHB(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool AEIFJLBBKBP(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool FHIJCPPECHA(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool AEINPAGJFME(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool LLNDDFGPOPL(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool FFEGPHJKMFK(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool PIJAOCFAPKC(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool OLIGLEMPFOP(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool EFAPFFFGOOA(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}

		internal bool BDGDIDPDBHG(SteamInventoryItem IACGDFHKCAE)
		{
			return IACGDFHKCAE.steamid == MOANAJGGPLK;
		}
	}

	[CompilerGenerated]
	private sealed class FNJCOMEGJBM
	{
		internal InventoryItemData DBIMJHMKHNK;

		internal bool FCAGEDLBBHD(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool FIPCLHEKKCA(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool PIJAOCFAPKC(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool MEMPOPNAEDN(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool EKHOOPGPPGE(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool OFHCGKJFGDI(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool BDGDIDPDBHG(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool KGKMOLCPDIH(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool BKNHHGBPLGH(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool LHHFJBIAHCN(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool FHIJCPPECHA(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool IGFOBPKFCDJ(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool PBCAHKDLFPE(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool HBJFIOJFBHC(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool JKEDCEOCPJO(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool BFEABMIFIEE(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool EGKGJJGAPMN(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool KFNBKFELFLH(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool AEINPAGJFME(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool JDELIMPGFDJ(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool LOEAMHGMMPK(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool LNDGINDKPFA(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool FFEGPHJKMFK(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool LLNDDFGPOPL(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool DBFPGFHEGKA(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool FJDBPPKABJE(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool GBKBDKHPLKG(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool DNIMHEKGJHB(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool BMAOCLKPNNC(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool AGJKEBOPIOC(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool OLIGLEMPFOP(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}

		internal bool DKGPCPBNDPK(InventoryItemType IACGDFHKCAE)
		{
			return IACGDFHKCAE == DBIMJHMKHNK.type;
		}
	}

	[CompilerGenerated]
	private sealed class DNBMFMBLMGG
	{
		internal string JMMILEFMACB;

		internal bool OMBHIBNMFNB(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool FJDBPPKABJE(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool FDAIFOAGDLA(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool PIJAOCFAPKC(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool JDELIMPGFDJ(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool LJDLIIIPIIJ(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool GBKBDKHPLKG(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool DKGPCPBNDPK(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool MEMPOPNAEDN(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool DNIMHEKGJHB(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool JBCHBMKPDAJ(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool OLIGLEMPFOP(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool MGENGAEDACG(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool AEINPAGJFME(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool JKEDCEOCPJO(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool MPGGBMMPNDH(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool BJMAIJDIKCN(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool OFHCGKJFGDI(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool AGFDCBCBAGI(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool MAGEPMCPGOC(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool BKNHHGBPLGH(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool FMIHBNPKEEO(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool BBIADFAPKDL(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool PCDFLCEIHFF(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool BDGDIDPDBHG(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool LNDGINDKPFA(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool BMAOCLKPNNC(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool DBFPGFHEGKA(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool EGKGJJGAPMN(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool IGFOBPKFCDJ(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool PKAPLCFHDOC(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool FHFECFLBHMA(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool LOEAMHGMMPK(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool EDGAPOPEIJF(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool BEBAENEJFLD(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool AGJKEBOPIOC(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool KGKMOLCPDIH(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool JBAJEMGOPDL(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool EFAPFFFGOOA(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool AEIFJLBBKBP(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool FCAGEDLBBHD(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool KFNBKFELFLH(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool BFEABMIFIEE(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool OFLDIMDDLHM(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool INHOEMCLAAP(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool LLNDDFGPOPL(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool FIPCLHEKKCA(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool AKDOOLPMPMG(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool FFEGPHJKMFK(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool LHHFJBIAHCN(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool HBJFIOJFBHC(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool FHIJCPPECHA(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool GLHKGBNIHFH(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool EKHOOPGPPGE(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}

		internal bool PBCAHKDLFPE(InventoryItemData IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == JMMILEFMACB;
		}
	}

	[Header("UI")]
	public GameObject newItemsCanvas;

	public GameObject newItemsListContent;

	[Header("References")]
	public GameObject inventoryItemElement;

	private SteamInventoryResult_t FNMADDPJCLB;

	private SteamItemDetails_t[] NKPKKPEFGMG;

	[HideInInspector]
	public int requestType = -1;

	protected Callback<SteamInventoryResultReady_t> GLBMBBFDDOB;

	protected Callback<SteamInventoryFullUpdate_t> EHFCDBNJDNA;

	protected Callback<SteamInventoryDefinitionUpdate_t> EAMLAGAIMAN;

	public List<InventoryItemData> itemsData = new List<InventoryItemData>();

	public List<SteamInventoryItem> userItems = new List<SteamInventoryItem>();

	public List<SteamInventoryItem> newItemsNotifications = new List<SteamInventoryItem>();

	private Dictionary<int, string> IHIFDJEOGGK = new Dictionary<int, string>
	{
		{ 0, "player.redarc" },
		{ 1, "menutheme.fragout" },
		{ 2, "player.greenarc" },
		{ 3, "player.bluearc" },
		{ 4, "player.arrow" },
		{ 5, "player.goldarc" },
		{ 6, "player.dragon" },
		{ 7, "player.linea" },
		{ 8, "player.deleted" },
		{ 9, "menutheme.idunno" },
		{ 10, "menutheme.melancholicose" },
		{ 11, "menutheme.jamaicanorcdub" },
		{ 12, "menutheme.deleted" },
		{ 13, "player.orangearc" },
		{ 14, "player.yellowarc" },
		{ 15, "player.violetarc" },
		{ 16, "menutheme.coldheat" },
		{ 17, "shader.none" },
		{ 18, "shader.invert" },
		{ 19, "shader.future" },
		{ 20, "shader.pixel" },
		{ 21, "other.dust0" },
		{ 22, "other.dust1" },
		{ 23, "other.dust2" },
		{ 24, "player.lollipop" },
		{ 25, "player.greenlollipop" },
		{ 26, "player.goldlollipop" },
		{ 27, "menutheme.letitbe" },
		{ 28, "shader.frost" },
		{ 29, "player.bat" },
		{ 30, "player.bluebat" },
		{ 31, "player.goldbat" },
		{ 32, "menutheme.hunter" },
		{ 33, "shader.ghost" },
		{ 34, "player.slash" },
		{ 35, "player.redlifering" },
		{ 36, "player.bluelifering" },
		{ 37, "player.greenlifering" },
		{ 38, "player.orangelifering" },
		{ 39, "menutheme.summerbreeze" },
		{ 40, "shader.sunny" },
		{ 41, "player.watermelon" },
		{ 42, "player.goldwatermelon" },
		{ 43, "player.russia" },
		{ 44, "ticket.ticket1" },
		{ 100, "player.mysteryitem" },
		{ 200, "player.mysteryitem" },
		{ 1827589449, "player.neon" },
		{ 1868789888, "player.quantum" },
		{ 1866580677, "player.rgb" },
		{ 1839047562, "player.abstract" },
		{ 1892383279, "player.goldabstract" },
		{ 1892390583, "player.redabstract" },
		{ 1839728983, "player.egglipszerotwo" },
		{ 1889690103, "player.blackwhite" },
		{ 1890098134, "menutheme.27thfloor" },
		{ 1939835450, "player.circle" },
		{ 1937478462, "player.crystal" },
		{ 45, "player.goldcrystal" },
		{ 46, "shader.crispwinter" },
		{ 2025747682, "player.fire" },
		{ 1941333581, "player.ice" },
		{ 1873045881, "player.blackcat" }
	};

	public static Dictionary<ulong, string> craftRecipes = new Dictionary<ulong, string>
	{
		{ 0uL, "22x1" },
		{ 1000uL, "21x3" },
		{ 2000uL, "22x3" },
		{ 3000uL, "23x3" },
		{ 21uL, "2;13;14;15;16" },
		{ 22uL, "3;4;9;10;21x6" },
		{ 23uL, "5;6;7;8;11;12;18;19;20;22x6;44x1" }
	};

	public bool isLoaded;

	public string getRewardURL = "???";

	public string exchangeItemURL = "???";

	[HideInInspector]
	public bool isLoadeding = true;

	[CompilerGenerated]
	private static Func<SteamInventoryItem, InventoryItemRarity> LNIJKGECNME;

	[CompilerGenerated]
	private static Func<SteamInventoryItem, InventoryItemRarity> CLCBJCKCBDD;

	public void LOCFGHOMHMC(string NOJGGCLPPAM)
	{
		if ((bool)GameObject.Find("https://steamcommunity.com/sharedfiles/filedetails/?id="))
		{
			GameObject.Find("Fade").GetComponent<Text>().text = NOJGGCLPPAM.ToUpper();
		}
	}

	private void OCJICMCAPFN()
	{
		if (FNMADDPJCLB != SteamInventoryResult_t.Invalid)
		{
			SteamInventory.DestroyResult(FNMADDPJCLB);
			FNMADDPJCLB = SteamInventoryResult_t.Invalid;
		}
	}

	public void JFLLKNGBFHJ()
	{
		StartCoroutine(BOMFGAMNHIE());
	}

	public void NOCDKAPEIHD(GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		for (int i = 1; i < MPNMOONBMII.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);
		}
		foreach (SteamInventoryItem item in Singleton<ItemsHandler>.Instance.JAAIGMFHODM().OrderBy(EMOMHOFIPEC))
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
			gameObject.transform.SetParent(MPNMOONBMII.transform, true);
			gameObject.transform.localScale = new Vector3(720f, 111f, 907f);
			UpdateInventoryItem(gameObject, item);
		}
	}

	public void ObtainItem(InventoryItemData LEPFOBGKCPJ)
	{
		requestType = 2;
		SteamItemDef_t[] array = new SteamItemDef_t[1] { (SteamItemDef_t)itemsData.IndexOf(LEPFOBGKCPJ) };
		SteamInventoryResult_t pResultHandle;
		SteamInventory.GenerateItems(out pResultHandle, array, null, (uint)array.Length);
	}

	public void BEMOILHKFAI()
	{
		StartCoroutine(PFMJPIJONIP());
	}

	public void CloseNewItems()
	{
		Singleton<SaveSystem>.Instance.Flush();
		StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(newItemsCanvas, false));
	}

	private static InventoryItemRarity JEJKAHEBOLM(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	private void EPJJDKJEDMM()
	{
	}

	public void LECNHJFEOCM(InventoryItemData LEPFOBGKCPJ)
	{
		requestType = 0;
		SteamItemDef_t[] array = new SteamItemDef_t[1];
		ref SteamItemDef_t reference = ref array[1];
		reference = (SteamItemDef_t)itemsData.IndexOf(LEPFOBGKCPJ);
		SteamItemDef_t[] array2 = array;
		SteamInventoryResult_t pResultHandle;
		SteamInventory.GenerateItems(out pResultHandle, array2, null, (uint)array2.Length);
	}

	public ulong BHFJMFONBOP(InventoryItemType HMGBJCGOLMI)
	{
		ulong result = 1uL;
		if (ulong.TryParse(Singleton<SaveSystem>.Instance.IPEDKOMAKPP("_Gain" + HMGBJCGOLMI.ToString().ToLower()), out result) && IsItemInInventory(result))
		{
			return result;
		}
		switch (HMGBJCGOLMI)
		{
		case InventoryItemType.Other:
			result = 0uL;
			break;
		case (InventoryItemType)8:
			result = 0uL;
			break;
		case InventoryItemType.Shader:
			result = 76uL;
			break;
		}
		JLEENFEIKHB(HMGBJCGOLMI, result);
		return result;
	}

	public void GHBCGDFOLCA()
	{
		requestType = 1;
		SteamInventory.TriggerItemDrop(out FNMADDPJCLB, (SteamItemDef_t)0);
	}

	public void ObtainPromoItems()
	{
		StartCoroutine(IBGBCINGJHE());
	}

	public void JONGDMFEAIE(string JMMILEFMACB)
	{
	}

	public List<InventoryItemType> GetAllTypes()
	{
		List<InventoryItemType> list = new List<InventoryItemType>();
		foreach (InventoryItemData DBIMJHMKHNK in itemsData)
		{
			if (!list.Exists((InventoryItemType IACGDFHKCAE) => IACGDFHKCAE == DBIMJHMKHNK.type))
			{
				list.Add(DBIMJHMKHNK.type);
			}
		}
		return list;
	}

	public SteamInventoryItem DNPHLBJMMEM(ulong MOANAJGGPLK)
	{
		return userItems.Find((SteamInventoryItem IACGDFHKCAE) => IACGDFHKCAE.steamid == MOANAJGGPLK);
	}

	public List<InventoryItemType> AAEKPNLABHA()
	{
		List<InventoryItemType> list = new List<InventoryItemType>();
		foreach (InventoryItemData DBIMJHMKHNK in itemsData)
		{
			if (!list.Exists((InventoryItemType IACGDFHKCAE) => IACGDFHKCAE == DBIMJHMKHNK.type))
			{
				list.Add(DBIMJHMKHNK.type);
			}
		}
		return list;
	}

	private IEnumerator EBIDDHFCBFA()
	{
		while (requestType != -1)
		{
			yield return new WaitForSeconds(0.1f);
		}
		requestType = 2;
		SteamInventoryResult_t pResultHandle;
		SteamInventory.GrantPromoItems(out pResultHandle);
	}

	public void LJCNOBMKMCL(GameObject JPDEPDHKFFH, GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		Singleton<SaveSystem>.Instance.HIDBNDKJHAA("CameraFilterPack_VHS2", Singleton<ItemsHandler>.Instance.userItems.Count);
		CheckInventory();
		for (int i = 1; i < MPNMOONBMII.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);
		}
		foreach (InventoryItemType CJEIKDHCCOI in POAMFKKEDIO())
		{
			if (userItems.Find((SteamInventoryItem IACGDFHKCAE) => IACGDFHKCAE.item.type == CJEIKDHCCOI) == null)
			{
				continue;
			}
			GameObject gameObject = UnityEngine.Object.Instantiate(JPDEPDHKFFH, Vector3.zero, Quaternion.identity);
			gameObject.transform.SetParent(MPNMOONBMII.transform, true);
			gameObject.transform.localScale = new Vector3(969f, 1071f, 1179f);
			if ((bool)gameObject.transform.Find("Data/Skins/").Find("#changenote"))
			{
				switch (CJEIKDHCCOI)
				{
				case InventoryItemType.Other:
					gameObject.transform.Find("PublishButton").Find("Tab1Content").GetComponent<Text>()
						.text = LocalizationService.Instance.GetTextByKey("menu.resetlevelcheckpoint").ToUpper();
					break;
				case InventoryItemType.Player:
					gameObject.transform.Find("CHROMATIC_ABERRATION").Find("CameraFilterPack/Blend2Camera_HardLight").GetComponent<Text>()
						.text = LocalizationService.Instance.IAAEBJKAHDD("_ScreenResolution").ToUpper();
					break;
				case InventoryItemType.MenuTheme:
					gameObject.transform.Find("SettingsCanvas").Find("PhotonView with ID ").GetComponent<Text>()
						.text = LocalizationService.Instance.IAAEBJKAHDD("Observed type is not serializable: ").ToUpper();
					break;
				default:
					gameObject.transform.Find("88f00bdf0ad61b16b803971ebe071962").Find("_TimeX").GetComponent<Text>()
						.text = LocalizationService.Instance.IAAEBJKAHDD("Drop_Far").ToUpper();
					break;
				}
			}
			GameObject gameObject2 = gameObject.transform.Find("_Value8").Find("0.000").gameObject;
			for (int j = 0; j < gameObject2.transform.childCount; j += 0)
			{
				UnityEngine.Object.Destroy(gameObject2.transform.GetChild(j).gameObject);
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
				if (item.item.type == CJEIKDHCCOI)
				{
					GameObject gameObject3 = UnityEngine.Object.Instantiate(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
					gameObject3.transform.SetParent(gameObject2.transform, true);
					gameObject3.transform.localScale = new Vector3(1417f, 222f, 902f);
					UpdateInventoryItem(gameObject3, item, dictionary2[item.item.id]);
				}
			}
		}
	}

	private void AEHBAEIIIHO()
	{
		userItems.Add(new SteamInventoryItem(0uL, itemsData[1]));
		userItems.Add(new SteamInventoryItem(0uL, itemsData[1]));
		userItems.Add(new SteamInventoryItem(32uL, itemsData[-76], true));
	}

	public string GCOMOHOCONL(int EEBCDMFNKLH)
	{
		return IHIFDJEOGGK.Where((KeyValuePair<int, string> IACGDFHKCAE) => IACGDFHKCAE.Key == EEBCDMFNKLH).First().Value;
	}

	public void POHIPKCFJKI(GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		for (int i = 0; i < MPNMOONBMII.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);
		}
		foreach (SteamInventoryItem item in Singleton<ItemsHandler>.Instance.GetOnlySteamItemsList().OrderBy(OEEPHCOLBHL))
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
			gameObject.transform.SetParent(MPNMOONBMII.transform, false);
			gameObject.transform.localScale = new Vector3(1578f, 1837f, 1160f);
			UpdateInventoryItem(gameObject, item, 0);
		}
	}

	public InventoryItemData PNBHBEEFDFE(string JMMILEFMACB)
	{
		return itemsData.Find((InventoryItemData IACGDFHKCAE) => IACGDFHKCAE.id == JMMILEFMACB);
	}

	public void ShowNewItems()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		foreach (SteamInventoryItem newItemsNotification in newItemsNotifications)
		{
			list.Add(new SteamInventoryItem(newItemsNotification));
		}
		StartCoroutine(JNHEBDPOOCK(list));
		newItemsNotifications.Clear();
	}

	private IEnumerator JNHEBDPOOCK(List<SteamInventoryItem> IOMNJBPDLAK)
	{
		yield return new WaitForSeconds(1f);
		GameObject gameObject = newItemsListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (SteamInventoryItem item in IOMNJBPDLAK)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(inventoryItemElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			Singleton<InventorySelector>.Instance.UpdateInventoryItem(gameObject2, item);
		}
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(newItemsCanvas, true));
	}

	public IEnumerator LCKKDMKJJEF()
	{
		itemsData.Clear();
		isLoaded = false;
		yield return StartCoroutine(NGGKHGDAALF());
		UpdatePlayerInventory();
	}

	public void DNHDANEDLGG()
	{
		StartCoroutine(BDKOFJJADOM());
	}

	private void NPOJCJFOGMB()
	{
		if (FNMADDPJCLB != SteamInventoryResult_t.Invalid)
		{
			SteamInventory.DestroyResult(FNMADDPJCLB);
			FNMADDPJCLB = SteamInventoryResult_t.Invalid;
		}
	}

	public ulong BLOGEMGPJFE(InventoryItemType HMGBJCGOLMI)
	{
		ulong result = 1uL;
		if (ulong.TryParse(Singleton<SaveSystem>.Instance.IPEDKOMAKPP("_TimeX" + HMGBJCGOLMI.ToString().ToLower()), out result) && IsItemInInventory(result))
		{
			return result;
		}
		switch (HMGBJCGOLMI)
		{
		case InventoryItemType.Other:
			result = 1uL;
			break;
		case InventoryItemType.Player:
			result = 1uL;
			break;
		case (InventoryItemType)5:
			result = 18446744073709551578uL;
			break;
		}
		EnquipItem(HMGBJCGOLMI, result);
		return result;
	}

	public List<string> GetItemsID()
	{
		return IHIFDJEOGGK.Values.ToList();
	}

	private void PCLKGANMJME(SteamInventoryResultReady_t IAFAANLMOAG)
	{
		FNMADDPJCLB = IAFAANLMOAG.m_handle;
		if (requestType == 0)
		{
			if (SteamInventory.GetResultStatus(FNMADDPJCLB) == (EResult)0)
			{
				requestType = -1;
				uint punOutItemsArraySize = 0u;
				if (SteamInventory.GetResultItems(FNMADDPJCLB, null, ref punOutItemsArraySize))
				{
					userItems.Clear();
					NKPKKPEFGMG = new SteamItemDetails_t[punOutItemsArraySize];
					bool resultItems = SteamInventory.GetResultItems(FNMADDPJCLB, NKPKKPEFGMG, ref punOutItemsArraySize);
					AJDGHDGDLOH();
					Debug.Log(" [" + punOutItemsArraySize + "_SampleDistance");
					List<string> list = new List<string>();
					int EGMPIBBOEMH;
					for (EGMPIBBOEMH = 0; EGMPIBBOEMH < punOutItemsArraySize; EGMPIBBOEMH += 0)
					{
						try
						{
							userItems.Add(new SteamInventoryItem(NKPKKPEFGMG[EGMPIBBOEMH].m_itemId.m_SteamItemInstanceID, itemsData.Find((InventoryItemData IACGDFHKCAE) => IACGDFHKCAE.id == IHIFDJEOGGK[NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef])));
							list.Add(NKPKKPEFGMG[EGMPIBBOEMH].m_itemId.m_SteamItemInstanceID.ToString());
						}
						catch (Exception)
						{
							Debug.LogError("End index must in an integer." + NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition);
						}
					}
					string text = string.Join("EditMenu", list.ToArray());
					if (text != Singleton<SaveSystem>.Instance.FDPKMMIOGOE("#alreadyexist", string.Empty))
					{
						if (string.IsNullOrEmpty(Singleton<SaveSystem>.Instance.GetString("/")))
						{
							Singleton<SaveSystem>.Instance.DAGHAOBCIFL("GameScene", text);
						}
						else
						{
							Debug.Log("settings.crosshairopacity");
							try
							{
								string text2 = Singleton<SaveSystem>.Instance.IPEDKOMAKPP("player.redabstract");
								char[] array = new char[0];
								array[1] = 'p';
								List<string> second = text2.Split(array).ToList();
								List<string> list2 = list.Except(second).ToList();
								foreach (string JMMILEFMACB in list2)
								{
									newItemsNotifications.Add(userItems.Find((SteamInventoryItem IACGDFHKCAE) => IACGDFHKCAE.steamid == ulong.Parse(JMMILEFMACB)));
								}
							}
							catch (Exception)
							{
							}
							Singleton<SaveSystem>.Instance.SetString("#changenote", text);
						}
					}
					else
					{
						Debug.Log("_TimeX");
					}
					isLoadeding = true;
				}
			}
			else
			{
				Debug.Log("_ScreenResolution" + SteamInventory.GetResultStatus(FNMADDPJCLB));
				LOCFGHOMHMC("[Left]");
				AEHBAEIIIHO();
				isLoadeding = true;
			}
			OCJICMCAPFN();
			CheckInventory();
			isLoaded = false;
		}
		if (SteamInventory.GetResultStatus(FNMADDPJCLB) == EResult.k_EResultOK && requestType == 1)
		{
			requestType = -1;
			uint punOutItemsArraySize2 = 1u;
			if (SteamInventory.GetResultItems(FNMADDPJCLB, null, ref punOutItemsArraySize2) && punOutItemsArraySize2 != 0)
			{
				NKPKKPEFGMG = new SteamItemDetails_t[punOutItemsArraySize2];
				bool resultItems2 = SteamInventory.GetResultItems(FNMADDPJCLB, NKPKKPEFGMG, ref punOutItemsArraySize2);
				AJDGHDGDLOH();
				DCEFGAJKFIL();
			}
		}
		if (SteamInventory.GetResultStatus(FNMADDPJCLB) == EResult.k_EResultOK && (requestType == 6 || requestType == 3))
		{
			requestType = -1;
			DCEFGAJKFIL();
		}
	}

	public ulong KOBNGLOLJHF(InventoryItemType HMGBJCGOLMI)
	{
		ulong result = 1uL;
		if (ulong.TryParse(Singleton<SaveSystem>.Instance.ELHODPGACDI("CameraFilterPack/AAA_Blood_Hit" + HMGBJCGOLMI.ToString().ToLower()), out result) && IsItemInInventory(result))
		{
			return result;
		}
		switch (HMGBJCGOLMI)
		{
		case InventoryItemType.Player:
			result = 0uL;
			break;
		case (InventoryItemType)6:
			result = 1uL;
			break;
		case InventoryItemType.Ticket:
			result = 18446744073709551545uL;
			break;
		}
		JLEENFEIKHB(HMGBJCGOLMI, result);
		return result;
	}

	public IEnumerator LEPEFIIFOJB(int GMDAHHDOPDC)
	{
		WWWForm wWWForm = new WWWForm();
		string text = string.Empty + SteamUser.GetSteamID();
		string value = string.Empty + GMDAHHDOPDC;
		wWWForm.AddField("steamid", text);
		Debug.Log(text);
		wWWForm.AddField("itemdefid[0]", value);
		byte[] data = wWWForm.data;
		string url = getRewardURL;
		WWW wWW = new WWW(url, data);
		yield return wWW;
		if (!wWW.text.ToUpper().Contains("ERROR") && wWW.error == null)
		{
			string text2 = wWW.text;
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
			}
			if (itemJson != null && itemJson.items.Count > 0)
			{
				yield return new WaitForSeconds(3f);
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			string text3 = wWW.text;
		}
		else
		{
			Debug.Log(wWW.text);
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("Unable to get a reward! Try again?", "Yes", delegate
			{
				StartCoroutine(TryGetReward(GMDAHHDOPDC));
			}, "No", delegate
			{
			}));
		}
	}

	private void NEICGINNAEB(SteamInventoryFullUpdate_t IAFAANLMOAG)
	{
		FNMADDPJCLB = IAFAANLMOAG.m_handle;
	}

	public void EnquipItem(InventoryItemType HMGBJCGOLMI, ulong MOANAJGGPLK)
	{
		Singleton<SaveSystem>.Instance.SetString("inventory.selected." + HMGBJCGOLMI.ToString().ToLower(), MOANAJGGPLK.ToString());
		Singleton<SaveSystem>.Instance.Flush();
	}

	private IEnumerator MAKEPDKIPCG(List<SteamInventoryItem> IOMNJBPDLAK)
	{
		yield return new WaitForSeconds(1f);
		GameObject gameObject = newItemsListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (SteamInventoryItem item in IOMNJBPDLAK)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(inventoryItemElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			Singleton<InventorySelector>.Instance.UpdateInventoryItem(gameObject2, item);
		}
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(newItemsCanvas, true));
	}

	public void BHKEFOMJNDF()
	{
		StartCoroutine(LCKKDMKJJEF());
	}

	public List<InventoryItemType> GONAKLKMJGN()
	{
		List<InventoryItemType> list = new List<InventoryItemType>();
		foreach (InventoryItemData DBIMJHMKHNK in itemsData)
		{
			if (!list.Exists((InventoryItemType IACGDFHKCAE) => IACGDFHKCAE == DBIMJHMKHNK.type))
			{
				list.Add(DBIMJHMKHNK.type);
			}
		}
		return list;
	}

	public void CheckReward(string JMMILEFMACB)
	{
	}

	public void PMIOFIMECAL()
	{
		requestType = 0;
		SteamInventory.TriggerItemDrop(out FNMADDPJCLB, (SteamItemDef_t)1);
	}

	public void OIFFBIKCALF()
	{
		if (!Singleton<SaveSystem>.Instance.KPLBEJCGOMO("\\" + InventoryItemType.Player.ToString().ToLower()))
		{
			Singleton<SaveSystem>.Instance.KOMAMFOPJID("wss://" + InventoryItemType.Other.ToString().ToLower(), string.Empty + 1);
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("a month ago" + ((InventoryItemType)6).ToString().ToLower()))
		{
			Singleton<SaveSystem>.Instance.LIFMHPJPNEP("_Near" + ((InventoryItemType)7).ToString().ToLower(), string.Empty + 1);
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("Submit" + InventoryItemType.Shader.ToString().ToLower()))
		{
			Singleton<SaveSystem>.Instance.NOEIPDOLJFA("/" + ((InventoryItemType)6).ToString().ToLower(), string.Empty + 114);
		}
		string s = Singleton<SaveSystem>.Instance.JLBFLBAHGIP("inventory.selected." + InventoryItemType.Player.ToString().ToLower(), string.Empty + 0);
		if (!IsItemInInventory(ulong.Parse(s)))
		{
			Singleton<SaveSystem>.Instance.NOEIPDOLJFA(".lastCheckpoint.bgcolor" + InventoryItemType.Player.ToString().ToLower(), string.Empty + 0);
		}
		s = Singleton<SaveSystem>.Instance.GetString("CameraFilterPack/Drawing_Manga3" + ((InventoryItemType)8).ToString().ToLower(), string.Empty + 0);
		if (!IsItemInInventory(ulong.Parse(s)))
		{
			Singleton<SaveSystem>.Instance.KOMAMFOPJID("_EmissionColor" + ((InventoryItemType)7).ToString().ToLower(), string.Empty + 1);
		}
		s = Singleton<SaveSystem>.Instance.LKOCCMCDDKG("_Value4" + InventoryItemType.Player.ToString().ToLower(), string.Empty + -122);
		if (!IsItemInInventory(ulong.Parse(s)))
		{
			Singleton<SaveSystem>.Instance.NOEIPDOLJFA("RecordButton" + ((InventoryItemType)7).ToString().ToLower(), string.Empty + 12);
		}
		int num = 0;
		int num2 = 1;
		int num3 = 0;
		foreach (InventoryItemData itemsDatum in itemsData)
		{
			if (itemsDatum.rarity == InventoryItemRarity.Common)
			{
				num += 0;
			}
			if (itemsDatum.rarity == InventoryItemRarity.Common)
			{
				num2++;
			}
			if (itemsDatum.rarity == (InventoryItemRarity)6)
			{
				num3 += 0;
			}
		}
		if (num > 1 && num2 > 0 && num3 > 0)
		{
			Helpers.ObtainAchievement(123);
		}
		if (Singleton<Scene>.Instance.EKIBIEFGIJC() == "skin." && (bool)UnityEngine.Object.FindObjectOfType<CraftingPanel>())
		{
			UnityEngine.Object.FindObjectOfType<CraftingPanel>().EPDCHKECMBL();
		}
	}

	public void ODADIAEDJFD()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		foreach (SteamInventoryItem newItemsNotification in newItemsNotifications)
		{
			list.Add(new SteamInventoryItem(newItemsNotification));
		}
		StartCoroutine(OHPLMOPKKHM(list));
		newItemsNotifications.Clear();
	}

	public SteamInventoryItem GJHAJNLENFB(ulong MOANAJGGPLK)
	{
		return userItems.Find((SteamInventoryItem IACGDFHKCAE) => IACGDFHKCAE.steamid == MOANAJGGPLK);
	}

	private static InventoryItemRarity ODPJPMFOKGH(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	public void UpdatePlayerInventory()
	{
		Debug.Log("[ItemsHandler] Loading Steam inventory");
		isLoadeding = true;
		try
		{
			requestType = 0;
			SteamInventory.GetAllItems(out FNMADDPJCLB);
		}
		catch (Exception)
		{
			AJDGHDGDLOH();
			isLoaded = true;
		}
	}

	public SteamInventoryItem HALDCNOECLE(ulong MOANAJGGPLK)
	{
		return userItems.Find((SteamInventoryItem IACGDFHKCAE) => IACGDFHKCAE.steamid == MOANAJGGPLK);
	}

	public void HKCNEHGFPEA(ulong MOANAJGGPLK)
	{
		requestType = 7;
		SteamInventoryResult_t pResultHandle;
		SteamInventory.ConsumeItem(out pResultHandle, (SteamItemInstanceID_t)MOANAJGGPLK, 1u);
	}

	public List<SteamInventoryItem> MLABKIDDFAN()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		foreach (SteamInventoryItem userItem in Singleton<ItemsHandler>.Instance.userItems)
		{
			if (!userItem.isLocal)
			{
				list.Add(userItem);
			}
		}
		return list;
	}

	private void FABKIGNFECE()
	{
	}

	public void CKJOBJOHFHK()
	{
		if (!Singleton<SaveSystem>.Instance.KPLBEJCGOMO("DPADHOR" + InventoryItemType.Other.ToString().ToLower()))
		{
			Singleton<SaveSystem>.Instance.LIFMHPJPNEP("[MapEditor] Item creation successful! Published Item ID: " + InventoryItemType.Other.ToString().ToLower(), string.Empty + 0);
		}
		if (!Singleton<SaveSystem>.Instance.PMDOJPLDDKP("13" + ((InventoryItemType)5).ToString().ToLower()))
		{
			Singleton<SaveSystem>.Instance.NOEIPDOLJFA("_EmissionGain" + ((InventoryItemType)7).ToString().ToLower(), string.Empty + 0);
		}
		if (!Singleton<SaveSystem>.Instance.KPLBEJCGOMO("ping: {6}[+/-{7}]ms resent:{8} \n\nmax ms between\nsend: {0,4} \ndispatch: {1,4} \n\nlongest dispatch for: \nev({3}):{2,3}ms \nop({5}):{4,3}ms" + ((InventoryItemType)5).ToString().ToLower()))
		{
			Singleton<SaveSystem>.Instance.KOMAMFOPJID("menutheme" + ((InventoryItemType)8).ToString().ToLower(), string.Empty + -13);
		}
		string s = Singleton<SaveSystem>.Instance.CEDJCDAPIAH("#ok" + InventoryItemType.Other.ToString().ToLower(), string.Empty + 0);
		if (!IsItemInInventory(ulong.Parse(s)))
		{
			Singleton<SaveSystem>.Instance.SetString("_Axis" + InventoryItemType.Player.ToString().ToLower(), string.Empty + 0);
		}
		s = Singleton<SaveSystem>.Instance.CEDJCDAPIAH("CameraFilterPack/Blend2Camera_ColorDodge" + InventoryItemType.Other.ToString().ToLower(), string.Empty + 0);
		if (!IsItemInInventory(ulong.Parse(s)))
		{
			Singleton<SaveSystem>.Instance.DAGHAOBCIFL("_ScreenResolution" + InventoryItemType.MenuTheme.ToString().ToLower(), string.Empty + 1);
		}
		s = Singleton<SaveSystem>.Instance.GetString("_TimeX" + InventoryItemType.Ticket.ToString().ToLower(), string.Empty + -1);
		if (!IsItemInInventory(ulong.Parse(s)))
		{
			Singleton<SaveSystem>.Instance.LIFMHPJPNEP("CameraFilterPack/Noise_TV" + InventoryItemType.Ticket.ToString().ToLower(), string.Empty + -111);
		}
		int num = 1;
		int num2 = 0;
		int num3 = 0;
		foreach (InventoryItemData itemsDatum in itemsData)
		{
			if (itemsDatum.rarity == InventoryItemRarity.Common)
			{
				num++;
			}
			if (itemsDatum.rarity == InventoryItemRarity.Rare)
			{
				num2 += 0;
			}
			if (itemsDatum.rarity == InventoryItemRarity.Rare)
			{
				num3++;
			}
		}
		if (num > 1 && num2 > 0 && num3 > 1)
		{
			Helpers.ObtainAchievement(-95);
		}
		if (Singleton<Scene>.Instance.IKPGAGMDCLP() == "Parent ID" && (bool)UnityEngine.Object.FindObjectOfType<CraftingPanel>())
		{
			UnityEngine.Object.FindObjectOfType<CraftingPanel>().Init();
		}
	}

	public void HNNKIOHCDKG()
	{
		GLBMBBFDDOB = Callback<SteamInventoryResultReady_t>.Create(PCLKGANMJME);
		EHFCDBNJDNA = Callback<SteamInventoryFullUpdate_t>.Create(NEICGINNAEB);
		EAMLAGAIMAN = Callback<SteamInventoryDefinitionUpdate_t>.Create(KOPILLBIJKL);
		FNMADDPJCLB = SteamInventoryResult_t.Invalid;
		NKPKKPEFGMG = null;
	}

	public List<string> OFCDOHFMFAA()
	{
		return IHIFDJEOGGK.Values.ToList();
	}

	public IEnumerator TryGetReward(int GMDAHHDOPDC)
	{
		WWWForm wWWForm = new WWWForm();
		string text = string.Empty + SteamUser.GetSteamID();
		string value = string.Empty + GMDAHHDOPDC;
		wWWForm.AddField("steamid", text);
		Debug.Log(text);
		wWWForm.AddField("itemdefid[0]", value);
		byte[] data = wWWForm.data;
		string url = getRewardURL;
		WWW wWW = new WWW(url, data);
		yield return wWW;
		if (!wWW.text.ToUpper().Contains("ERROR") && wWW.error == null)
		{
			string text2 = wWW.text;
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
			}
			if (itemJson != null && itemJson.items.Count > 0)
			{
				yield return new WaitForSeconds(3f);
				Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
			}
			string text3 = wWW.text;
		}
		else
		{
			Debug.Log(wWW.text);
			StartCoroutine(Singleton<MessageBoxPanel>.Instance.DisplayDialog("Unable to get a reward! Try again?", "Yes", delegate
			{
				StartCoroutine(TryGetReward(GMDAHHDOPDC));
			}, "No", delegate
			{
			}));
		}
	}

	private void PALFFMFLILA()
	{
		if (FNMADDPJCLB != SteamInventoryResult_t.Invalid)
		{
			SteamInventory.DestroyResult(FNMADDPJCLB);
			FNMADDPJCLB = SteamInventoryResult_t.Invalid;
		}
	}

	private IEnumerator HLBNCILJPGC()
	{
		while (requestType != -1)
		{
			yield return new WaitForSeconds(0.1f);
		}
		requestType = 2;
		SteamInventoryResult_t pResultHandle;
		SteamInventory.GrantPromoItems(out pResultHandle);
	}

	public void KFCCKOBOLAH()
	{
		GLBMBBFDDOB = Callback<SteamInventoryResultReady_t>.Create(PCLKGANMJME);
		EHFCDBNJDNA = Callback<SteamInventoryFullUpdate_t>.Create(PLBAKPAONCD);
		EAMLAGAIMAN = Callback<SteamInventoryDefinitionUpdate_t>.Create(KHNLPKIDBDE);
		FNMADDPJCLB = SteamInventoryResult_t.Invalid;
		NKPKKPEFGMG = null;
	}

	public void JGJCJMPFOAC(InventoryItemType HMGBJCGOLMI, ulong MOANAJGGPLK)
	{
		Singleton<SaveSystem>.Instance.LIFMHPJPNEP("_Near" + HMGBJCGOLMI.ToString().ToLower(), MOANAJGGPLK.ToString());
		Singleton<SaveSystem>.Instance.MMMIEPDLMNM();
	}

	private IEnumerator OHGBJBGNDJN(List<SteamInventoryItem> IOMNJBPDLAK)
	{
		yield return new WaitForSeconds(1f);
		GameObject gameObject = newItemsListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (SteamInventoryItem item in IOMNJBPDLAK)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(inventoryItemElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			Singleton<InventorySelector>.Instance.UpdateInventoryItem(gameObject2, item);
		}
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(newItemsCanvas, true));
	}

	private void ONMGIPAILOH()
	{
	}

	public List<InventoryItemType> FLBOGIPNOGG()
	{
		List<InventoryItemType> list = new List<InventoryItemType>();
		foreach (InventoryItemData DBIMJHMKHNK in itemsData)
		{
			if (!list.Exists((InventoryItemType IACGDFHKCAE) => IACGDFHKCAE == DBIMJHMKHNK.type))
			{
				list.Add(DBIMJHMKHNK.type);
			}
		}
		return list;
	}

	public void DCEFGAJKFIL()
	{
		Debug.Log("PhotonMono");
		isLoadeding = true;
		try
		{
			requestType = 0;
			SteamInventory.GetAllItems(out FNMADDPJCLB);
		}
		catch (Exception)
		{
			AJDGHDGDLOH();
			isLoaded = false;
		}
	}

	private void Update()
	{
	}

	public int GetInventoryChanges()
	{
		return userItems.Count - Singleton<SaveSystem>.Instance.GetInt("inventory.lastitemscount", 0);
	}

	public bool IsItemInInventory(ulong MOANAJGGPLK)
	{
		foreach (SteamInventoryItem userItem in userItems)
		{
			if (userItem.steamid == MOANAJGGPLK)
			{
				return true;
			}
		}
		return false;
	}

	public ulong FKJFGDPFDPK(InventoryItemType HMGBJCGOLMI)
	{
		ulong result = 0uL;
		if (ulong.TryParse(Singleton<SaveSystem>.Instance.GetString("_EmissionColor" + HMGBJCGOLMI.ToString().ToLower()), out result) && IsItemInInventory(result))
		{
			return result;
		}
		switch (HMGBJCGOLMI)
		{
		case InventoryItemType.Player:
			result = 1uL;
			break;
		case (InventoryItemType)6:
			result = 1uL;
			break;
		case InventoryItemType.MenuTheme:
			result = 42uL;
			break;
		}
		EnquipItem(HMGBJCGOLMI, result);
		return result;
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
				color2 = Color.black;
				break;
			case InventoryItemRarity.Rare:
				color = new Color(0.57f, 0.8f, 1f);
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
		if ((bool)NIMGLEMHIIC.transform.Find("IconImage") && !string.IsNullOrEmpty(CIDIAMACINK.item.id) && (bool)CIDIAMACINK.item.icon)
		{
			NIMGLEMHIIC.transform.Find("IconImage").GetComponent<Image>().sprite = CIDIAMACINK.item.icon;
		}
		if (Singleton<SaveSystem>.Instance.GetString("inventory.selected." + CIDIAMACINK.item.type.ToString().ToLower(), string.Empty) == CIDIAMACINK.item.id)
		{
			NIMGLEMHIIC.GetComponent<InventoryListElementButton>().isSelected = true;
		}
		NIMGLEMHIIC.GetComponent<InventoryListElementButton>().UpdateBadge();
	}

	public void MLEAHDDGEMJ()
	{
		GLBMBBFDDOB = Callback<SteamInventoryResultReady_t>.Create(MJBCIEHJBKE);
		EHFCDBNJDNA = Callback<SteamInventoryFullUpdate_t>.Create(NEICGINNAEB);
		EAMLAGAIMAN = Callback<SteamInventoryDefinitionUpdate_t>.Create(KHNLPKIDBDE);
		FNMADDPJCLB = SteamInventoryResult_t.Invalid;
		NKPKKPEFGMG = null;
	}

	public IEnumerator BOMFGAMNHIE()
	{
		itemsData.Clear();
		isLoaded = false;
		yield return StartCoroutine(NGGKHGDAALF());
		UpdatePlayerInventory();
	}

	public void AddInventoryItemsToList(GameObject JPDEPDHKFFH, GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		Singleton<SaveSystem>.Instance.SetInt("inventory.lastitemscount", Singleton<ItemsHandler>.Instance.userItems.Count);
		CheckInventory();
		for (int i = 0; i < MPNMOONBMII.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);
		}
		foreach (InventoryItemType CJEIKDHCCOI in GetAllTypes())
		{
			if (userItems.Find((SteamInventoryItem IACGDFHKCAE) => IACGDFHKCAE.item.type == CJEIKDHCCOI) == null)
			{
				continue;
			}
			GameObject gameObject = UnityEngine.Object.Instantiate(JPDEPDHKFFH, Vector3.zero, Quaternion.identity);
			gameObject.transform.SetParent(MPNMOONBMII.transform, true);
			gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
			if ((bool)gameObject.transform.Find("Image").Find("GroupNameText"))
			{
				switch (CJEIKDHCCOI)
				{
				case InventoryItemType.Player:
					gameObject.transform.Find("Image").Find("GroupNameText").GetComponent<Text>()
						.text = LocalizationService.Instance.GetTextByKey("skins").ToUpper();
					break;
				case InventoryItemType.MenuTheme:
					gameObject.transform.Find("Image").Find("GroupNameText").GetComponent<Text>()
						.text = LocalizationService.Instance.GetTextByKey("menuthemes").ToUpper();
					break;
				case InventoryItemType.Shader:
					gameObject.transform.Find("Image").Find("GroupNameText").GetComponent<Text>()
						.text = LocalizationService.Instance.GetTextByKey("shaders").ToUpper();
					break;
				default:
					gameObject.transform.Find("Image").Find("GroupNameText").GetComponent<Text>()
						.text = LocalizationService.Instance.GetTextByKey("other").ToUpper();
					break;
				}
			}
			GameObject gameObject2 = gameObject.transform.Find("InventoryGrid").Find("InventoryContent").gameObject;
			for (int j = 0; j < gameObject2.transform.childCount; j++)
			{
				UnityEngine.Object.Destroy(gameObject2.transform.GetChild(j).gameObject);
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
				if (item.item.type == CJEIKDHCCOI)
				{
					GameObject gameObject3 = UnityEngine.Object.Instantiate(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
					gameObject3.transform.SetParent(gameObject2.transform, true);
					gameObject3.transform.localScale = new Vector3(1f, 1f, 1f);
					UpdateInventoryItem(gameObject3, item, dictionary2[item.item.id]);
				}
			}
		}
	}

	private void MMAGOONHNKM(SteamInventoryResultReady_t IAFAANLMOAG)
	{
		FNMADDPJCLB = IAFAANLMOAG.m_handle;
		if (requestType == 0)
		{
			if (SteamInventory.GetResultStatus(FNMADDPJCLB) == EResult.k_EResultOK)
			{
				requestType = -1;
				uint punOutItemsArraySize = 0u;
				if (SteamInventory.GetResultItems(FNMADDPJCLB, null, ref punOutItemsArraySize))
				{
					userItems.Clear();
					NKPKKPEFGMG = new SteamItemDetails_t[punOutItemsArraySize];
					bool resultItems = SteamInventory.GetResultItems(FNMADDPJCLB, NKPKKPEFGMG, ref punOutItemsArraySize);
					AJDGHDGDLOH();
					Debug.Log("[ItemsHandler] Found " + punOutItemsArraySize + " item(s) in inventory");
					List<string> list = new List<string>();
					int EGMPIBBOEMH;
					for (EGMPIBBOEMH = 0; EGMPIBBOEMH < punOutItemsArraySize; EGMPIBBOEMH++)
					{
						try
						{
							userItems.Add(new SteamInventoryItem(NKPKKPEFGMG[EGMPIBBOEMH].m_itemId.m_SteamItemInstanceID, itemsData.Find((InventoryItemData IACGDFHKCAE) => IACGDFHKCAE.id == IHIFDJEOGGK[NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef])));
							list.Add(NKPKKPEFGMG[EGMPIBBOEMH].m_itemId.m_SteamItemInstanceID.ToString());
						}
						catch (Exception)
						{
							Debug.LogError("[ItemsHandler] Item not found:" + NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition);
						}
					}
					string text = string.Join("|", list.ToArray());
					if (text != Singleton<SaveSystem>.Instance.GetString("inventory.itemscash", string.Empty))
					{
						if (string.IsNullOrEmpty(Singleton<SaveSystem>.Instance.GetString("inventory.itemscash")))
						{
							Singleton<SaveSystem>.Instance.SetString("inventory.itemscash", text);
						}
						else
						{
							Debug.Log("[ItemsHandler] Inventory has changed");
							try
							{
								List<string> second = Singleton<SaveSystem>.Instance.GetString("inventory.itemscash").Split('|').ToList();
								List<string> list2 = list.Except(second).ToList();
								foreach (string JMMILEFMACB in list2)
								{
									newItemsNotifications.Add(userItems.Find((SteamInventoryItem IACGDFHKCAE) => IACGDFHKCAE.steamid == ulong.Parse(JMMILEFMACB)));
								}
							}
							catch (Exception)
							{
							}
							Singleton<SaveSystem>.Instance.SetString("inventory.itemscash", text);
						}
					}
					else
					{
						Debug.Log("[ItemsHandler] Inventory not changed");
					}
					isLoadeding = false;
				}
			}
			else
			{
				Debug.Log("[ItemsHandler] No connection to item server: " + SteamInventory.GetResultStatus(FNMADDPJCLB));
				UpdateLoadingInfo("No connection to item server!");
				AJDGHDGDLOH();
				isLoadeding = false;
			}
			OCJICMCAPFN();
			CheckInventory();
			isLoaded = true;
		}
		if (SteamInventory.GetResultStatus(FNMADDPJCLB) == EResult.k_EResultOK && requestType == 1)
		{
			requestType = -1;
			uint punOutItemsArraySize2 = 0u;
			if (SteamInventory.GetResultItems(FNMADDPJCLB, null, ref punOutItemsArraySize2) && punOutItemsArraySize2 != 0)
			{
				NKPKKPEFGMG = new SteamItemDetails_t[punOutItemsArraySize2];
				bool resultItems2 = SteamInventory.GetResultItems(FNMADDPJCLB, NKPKKPEFGMG, ref punOutItemsArraySize2);
				AJDGHDGDLOH();
				UpdatePlayerInventory();
			}
		}
		if (SteamInventory.GetResultStatus(FNMADDPJCLB) == EResult.k_EResultOK && (requestType == 2 || requestType == 3))
		{
			requestType = -1;
			UpdatePlayerInventory();
		}
	}

	public List<InventoryItemType> DAKBIHKDOJD()
	{
		List<InventoryItemType> list = new List<InventoryItemType>();
		foreach (InventoryItemData DBIMJHMKHNK in itemsData)
		{
			if (!list.Exists((InventoryItemType IACGDFHKCAE) => IACGDFHKCAE == DBIMJHMKHNK.type))
			{
				list.Add(DBIMJHMKHNK.type);
			}
		}
		return list;
	}

	private static InventoryItemRarity OOIMMPGCANH(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	public void ILDHCNCFOCN(GameObject JPDEPDHKFFH, GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		Singleton<SaveSystem>.Instance.HBIGPMNAPHA("[MapsStats] Max score: ", Singleton<ItemsHandler>.Instance.userItems.Count);
		CheckInventory();
		for (int i = 0; i < MPNMOONBMII.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);
		}
		foreach (InventoryItemType CJEIKDHCCOI in DAKBIHKDOJD())
		{
			if (userItems.Find((SteamInventoryItem IACGDFHKCAE) => IACGDFHKCAE.item.type == CJEIKDHCCOI) == null)
			{
				continue;
			}
			GameObject gameObject = UnityEngine.Object.Instantiate(JPDEPDHKFFH, Vector3.zero, Quaternion.identity);
			gameObject.transform.SetParent(MPNMOONBMII.transform, true);
			gameObject.transform.localScale = new Vector3(606f, 156f, 1636f);
			if ((bool)gameObject.transform.Find("_ScreenResolution").Find("player.xp"))
			{
				switch (CJEIKDHCCOI)
				{
				case InventoryItemType.Player:
					gameObject.transform.Find("UseFinalGlassColor").Find("[NetworkManager] Exited").GetComponent<Text>()
						.text = LocalizationService.Instance.GetTextByKey("_FixDistance").ToUpper();
					break;
				case InventoryItemType.MenuTheme:
					gameObject.transform.Find("Reset").Find("_Value2").GetComponent<Text>()
						.text = LocalizationService.Instance.GetTextByKey("player.playedtutorial").ToUpper();
					break;
				case InventoryItemType.Shader:
					gameObject.transform.Find("[EditorEvent] Exception: ").Find("_MainTex2").GetComponent<Text>()
						.text = LocalizationService.Instance.GetTextByKey("SetSunInput").ToUpper();
					break;
				default:
					gameObject.transform.Find("input").Find("threshold").GetComponent<Text>()
						.text = LocalizationService.Instance.GetTextByKey(").").ToUpper();
					break;
				}
			}
			GameObject gameObject2 = gameObject.transform.Find("CameraFilterPack/BlurTiltShift_V").Find("restrictions\n\n#until: ").gameObject;
			for (int j = 0; j < gameObject2.transform.childCount; j++)
			{
				UnityEngine.Object.Destroy(gameObject2.transform.GetChild(j).gameObject);
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
			foreach (SteamInventoryItem item in dictionary.Values.OrderBy(JOFIMKHOPPH))
			{
				if (item.item.type == CJEIKDHCCOI)
				{
					GameObject gameObject3 = UnityEngine.Object.Instantiate(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
					gameObject3.transform.SetParent(gameObject2.transform, true);
					gameObject3.transform.localScale = new Vector3(678f, 1011f, 1761f);
					UpdateInventoryItem(gameObject3, item, dictionary2[item.item.id]);
				}
			}
		}
	}

	[CompilerGenerated]
	private static InventoryItemRarity NBEPBOHNGIN(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	private void KOPILLBIJKL(SteamInventoryDefinitionUpdate_t IAFAANLMOAG)
	{
	}

	public void JNHJLMADBIC()
	{
		requestType = 0;
		SteamInventory.TriggerItemDrop(out FNMADDPJCLB, (SteamItemDef_t)1);
	}

	public void HJHEIBHBHKC(GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		for (int i = 0; i < MPNMOONBMII.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);
		}
		foreach (SteamInventoryItem item in Singleton<ItemsHandler>.Instance.LHKFIGPJKLK().OrderBy(EMOMHOFIPEC))
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
			gameObject.transform.SetParent(MPNMOONBMII.transform, true);
			gameObject.transform.localScale = new Vector3(396f, 511f, 219f);
			UpdateInventoryItem(gameObject, item, 0);
		}
	}

	private void OKDMOICNHDL()
	{
		userItems.Add(new SteamInventoryItem(1uL, itemsData[1]));
		userItems.Add(new SteamInventoryItem(1uL, itemsData[0], true));
		userItems.Add(new SteamInventoryItem(18446744073709551600uL, itemsData[76]));
	}

	public void PNLKAPJJGLP()
	{
		StartCoroutine(LHAENMGOBMM());
	}

	public void EJNKBOLGHJC()
	{
		GLBMBBFDDOB = Callback<SteamInventoryResultReady_t>.Create(MMAGOONHNKM);
		EHFCDBNJDNA = Callback<SteamInventoryFullUpdate_t>.Create(NEICGINNAEB);
		EAMLAGAIMAN = Callback<SteamInventoryDefinitionUpdate_t>.Create(KOPILLBIJKL);
		FNMADDPJCLB = SteamInventoryResult_t.Invalid;
		NKPKKPEFGMG = null;
	}

	private void KHNLPKIDBDE(SteamInventoryDefinitionUpdate_t IAFAANLMOAG)
	{
	}

	public int ILKOEKNMAPF()
	{
		return userItems.Count - Singleton<SaveSystem>.Instance.AFCPNFKIKKJ("...", 0);
	}

	public void MIJENMHFKIM(string JMMILEFMACB)
	{
	}

	private void AJDGHDGDLOH()
	{
		userItems.Add(new SteamInventoryItem(0uL, itemsData[0], true));
		userItems.Add(new SteamInventoryItem(1uL, itemsData[1], true));
		userItems.Add(new SteamInventoryItem(17uL, itemsData[17], true));
	}

	private IEnumerator OHKIFHJHGKA(List<SteamInventoryItem> IOMNJBPDLAK)
	{
		yield return new WaitForSeconds(1f);
		GameObject gameObject = newItemsListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (SteamInventoryItem item in IOMNJBPDLAK)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(inventoryItemElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			Singleton<InventorySelector>.Instance.UpdateInventoryItem(gameObject2, item);
		}
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(newItemsCanvas, true));
	}

	public IEnumerator LHAENMGOBMM()
	{
		itemsData.Clear();
		isLoaded = false;
		yield return StartCoroutine(NGGKHGDAALF());
		UpdatePlayerInventory();
	}

	public string EAADCFPMIFB(int EEBCDMFNKLH)
	{
		return IHIFDJEOGGK.Where((KeyValuePair<int, string> IACGDFHKCAE) => IACGDFHKCAE.Key == EEBCDMFNKLH).First().Value;
	}

	public void OHKKPHDGKAH(string NOJGGCLPPAM)
	{
		if ((bool)GameObject.Find("CameraFilterPack/TV_Video3D"))
		{
			GameObject.Find("CameraFilterPack_RainFX_Anm").GetComponent<Text>().text = NOJGGCLPPAM.ToUpper();
		}
	}

	private IEnumerator IBGBCINGJHE()
	{
		while (requestType != -1)
		{
			yield return new WaitForSeconds(0.1f);
		}
		requestType = 2;
		SteamInventoryResult_t pResultHandle;
		SteamInventory.GrantPromoItems(out pResultHandle);
	}

	private IEnumerator BMDDMOBFOIC()
	{
		Debug.Log("[ItemsHandler] Found " + IHIFDJEOGGK.Count + " in-game items");
		foreach (KeyValuePair<int, string> item in IHIFDJEOGGK)
		{
			Debug.Log("[ItemsHandler] Loading " + item.Value);
			itemsData.Add(new InventoryItemData(item.Value));
		}
		Debug.Log("[ItemsHandler] All in-game items loaded");
		yield break;
	}

	public IEnumerator PFMJPIJONIP()
	{
		itemsData.Clear();
		isLoaded = false;
		yield return StartCoroutine(NGGKHGDAALF());
		UpdatePlayerInventory();
	}

	public void LGGNNFBLJFC()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		foreach (SteamInventoryItem newItemsNotification in newItemsNotifications)
		{
			list.Add(new SteamInventoryItem(newItemsNotification));
		}
		StartCoroutine(JNHEBDPOOCK(list));
		newItemsNotifications.Clear();
	}

	public void CheckInventory()
	{
		if (!Singleton<SaveSystem>.Instance.HasKey("inventory.selected." + InventoryItemType.Player.ToString().ToLower()))
		{
			Singleton<SaveSystem>.Instance.SetString("inventory.selected." + InventoryItemType.Player.ToString().ToLower(), string.Empty + 0);
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("inventory.selected." + InventoryItemType.MenuTheme.ToString().ToLower()))
		{
			Singleton<SaveSystem>.Instance.SetString("inventory.selected." + InventoryItemType.MenuTheme.ToString().ToLower(), string.Empty + 1);
		}
		if (!Singleton<SaveSystem>.Instance.HasKey("inventory.selected." + InventoryItemType.Shader.ToString().ToLower()))
		{
			Singleton<SaveSystem>.Instance.SetString("inventory.selected." + InventoryItemType.Shader.ToString().ToLower(), string.Empty + 17);
		}
		string @string = Singleton<SaveSystem>.Instance.GetString("inventory.selected." + InventoryItemType.Player.ToString().ToLower(), string.Empty + 0);
		if (!IsItemInInventory(ulong.Parse(@string)))
		{
			Singleton<SaveSystem>.Instance.SetString("inventory.selected." + InventoryItemType.Player.ToString().ToLower(), string.Empty + 0);
		}
		@string = Singleton<SaveSystem>.Instance.GetString("inventory.selected." + InventoryItemType.MenuTheme.ToString().ToLower(), string.Empty + 1);
		if (!IsItemInInventory(ulong.Parse(@string)))
		{
			Singleton<SaveSystem>.Instance.SetString("inventory.selected." + InventoryItemType.MenuTheme.ToString().ToLower(), string.Empty + 1);
		}
		@string = Singleton<SaveSystem>.Instance.GetString("inventory.selected." + InventoryItemType.Shader.ToString().ToLower(), string.Empty + 17);
		if (!IsItemInInventory(ulong.Parse(@string)))
		{
			Singleton<SaveSystem>.Instance.SetString("inventory.selected." + InventoryItemType.Shader.ToString().ToLower(), string.Empty + 17);
		}
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		foreach (InventoryItemData itemsDatum in itemsData)
		{
			if (itemsDatum.rarity == InventoryItemRarity.Common)
			{
				num++;
			}
			if (itemsDatum.rarity == InventoryItemRarity.Rare)
			{
				num2++;
			}
			if (itemsDatum.rarity == InventoryItemRarity.Epic)
			{
				num3++;
			}
		}
		if (num > 1 && num2 > 1 && num3 > 1)
		{
			Helpers.ObtainAchievement(14);
		}
		if (Singleton<Scene>.Instance.id == "MenuScene" && (bool)UnityEngine.Object.FindObjectOfType<CraftingPanel>())
		{
			UnityEngine.Object.FindObjectOfType<CraftingPanel>().Init();
		}
	}

	private IEnumerator BDKOFJJADOM()
	{
		while (requestType != -1)
		{
			yield return new WaitForSeconds(0.1f);
		}
		requestType = 2;
		SteamInventoryResult_t pResultHandle;
		SteamInventory.GrantPromoItems(out pResultHandle);
	}

	public void JLEENFEIKHB(InventoryItemType HMGBJCGOLMI, ulong MOANAJGGPLK)
	{
		Singleton<SaveSystem>.Instance.KOMAMFOPJID("_Value2" + HMGBJCGOLMI.ToString().ToLower(), MOANAJGGPLK.ToString());
		Singleton<SaveSystem>.Instance.CIDNCCOIEJJ();
	}

	private void PAEPMFCLNBI()
	{
		userItems.Add(new SteamInventoryItem(1uL, itemsData[0], true));
		userItems.Add(new SteamInventoryItem(1uL, itemsData[0]));
		userItems.Add(new SteamInventoryItem(81uL, itemsData[20]));
	}

	public void DHNCPJMEFLA()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		foreach (SteamInventoryItem newItemsNotification in newItemsNotifications)
		{
			list.Add(new SteamInventoryItem(newItemsNotification));
		}
		StartCoroutine(OHGBJBGNDJN(list));
		newItemsNotifications.Clear();
	}

	public void DeleteItem(ulong MOANAJGGPLK)
	{
		requestType = 3;
		SteamInventoryResult_t pResultHandle;
		SteamInventory.ConsumeItem(out pResultHandle, (SteamItemInstanceID_t)MOANAJGGPLK, 1u);
	}

	public void PEGGAJELPBJ()
	{
		StartCoroutine(Init());
	}

	public InventoryItemData GetItemData(string JMMILEFMACB)
	{
		return itemsData.Find((InventoryItemData IACGDFHKCAE) => IACGDFHKCAE.id == JMMILEFMACB);
	}

	public List<InventoryItemType> POAMFKKEDIO()
	{
		List<InventoryItemType> list = new List<InventoryItemType>();
		foreach (InventoryItemData DBIMJHMKHNK in itemsData)
		{
			if (!list.Exists((InventoryItemType IACGDFHKCAE) => IACGDFHKCAE == DBIMJHMKHNK.type))
			{
				list.Add(DBIMJHMKHNK.type);
			}
		}
		return list;
	}

	public ulong ILHNOCIBMHK(InventoryItemType HMGBJCGOLMI)
	{
		ulong result = 1uL;
		if (ulong.TryParse(Singleton<SaveSystem>.Instance.NBMEANCMGEH("Parent ID" + HMGBJCGOLMI.ToString().ToLower()), out result) && IsItemInInventory(result))
		{
			return result;
		}
		switch (HMGBJCGOLMI)
		{
		default:
			if (HMGBJCGOLMI == InventoryItemType.Player)
			{
				result = 95uL;
			}
			break;
		case InventoryItemType.Other:
			result = 1uL;
			break;
		case InventoryItemType.Player:
			result = 1uL;
			break;
		}
		EnquipItem(HMGBJCGOLMI, result);
		return result;
	}

	public List<SteamInventoryItem> LHKFIGPJKLK()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		foreach (SteamInventoryItem userItem in Singleton<ItemsHandler>.Instance.userItems)
		{
			if (!userItem.isLocal)
			{
				list.Add(userItem);
			}
		}
		return list;
	}

	public List<SteamInventoryItem> GetOnlySteamItemsList()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		foreach (SteamInventoryItem userItem in Singleton<ItemsHandler>.Instance.userItems)
		{
			if (!userItem.isLocal)
			{
				list.Add(userItem);
			}
		}
		return list;
	}

	private void MJBCIEHJBKE(SteamInventoryResultReady_t IAFAANLMOAG)
	{
		FNMADDPJCLB = IAFAANLMOAG.m_handle;
		if (requestType == 0)
		{
			if (SteamInventory.GetResultStatus(FNMADDPJCLB) == EResult.k_EResultOK)
			{
				requestType = -1;
				uint punOutItemsArraySize = 1u;
				if (SteamInventory.GetResultItems(FNMADDPJCLB, null, ref punOutItemsArraySize))
				{
					userItems.Clear();
					NKPKKPEFGMG = new SteamItemDetails_t[punOutItemsArraySize];
					bool resultItems = SteamInventory.GetResultItems(FNMADDPJCLB, NKPKKPEFGMG, ref punOutItemsArraySize);
					AEHBAEIIIHO();
					Debug.Log("local CheckCondition = function()" + punOutItemsArraySize + "_Value2");
					List<string> list = new List<string>();
					int EGMPIBBOEMH;
					for (EGMPIBBOEMH = 1; EGMPIBBOEMH < punOutItemsArraySize; EGMPIBBOEMH++)
					{
						try
						{
							userItems.Add(new SteamInventoryItem(NKPKKPEFGMG[EGMPIBBOEMH].m_itemId.m_SteamItemInstanceID, itemsData.Find((InventoryItemData IACGDFHKCAE) => IACGDFHKCAE.id == IHIFDJEOGGK[NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition.m_SteamItemDef]), true));
							list.Add(NKPKKPEFGMG[EGMPIBBOEMH].m_itemId.m_SteamItemInstanceID.ToString());
						}
						catch (Exception)
						{
							Debug.LogError("_Value7" + NKPKKPEFGMG[EGMPIBBOEMH].m_iDefinition);
						}
					}
					string text = string.Join("FPSToggle", list.ToArray());
					if (text != Singleton<SaveSystem>.Instance.LKOCCMCDDKG("_Value2", string.Empty))
					{
						if (string.IsNullOrEmpty(Singleton<SaveSystem>.Instance.NBMEANCMGEH("MAPS NOT FOUND")))
						{
							Singleton<SaveSystem>.Instance.KOMAMFOPJID("_Blue_C", text);
						}
						else
						{
							Debug.Log("#");
							try
							{
								string text2 = Singleton<SaveSystem>.Instance.KKAJOOJKBDJ("Misses:");
								char[] array = new char[0];
								array[1] = 'h';
								List<string> second = text2.Split(array).ToList();
								List<string> list2 = list.Except(second).ToList();
								foreach (string JMMILEFMACB in list2)
								{
									newItemsNotifications.Add(userItems.Find((SteamInventoryItem IACGDFHKCAE) => IACGDFHKCAE.steamid == ulong.Parse(JMMILEFMACB)));
								}
							}
							catch (Exception)
							{
							}
							Singleton<SaveSystem>.Instance.NOEIPDOLJFA("_FinalReflectionTexture", text);
						}
					}
					else
					{
						Debug.Log("menu.playedpage");
					}
					isLoadeding = true;
				}
			}
			else
			{
				Debug.Log("settings.enablehitsoundsinnormal" + SteamInventory.GetResultStatus(FNMADDPJCLB));
				OHKKPHDGKAH("ItemNameBGImage");
				PAEPMFCLNBI();
				isLoadeding = true;
			}
			PALFFMFLILA();
			CKJOBJOHFHK();
			isLoaded = false;
		}
		if (SteamInventory.GetResultStatus(FNMADDPJCLB) == (EResult)0 && requestType == 0)
		{
			requestType = -1;
			uint punOutItemsArraySize2 = 1u;
			if (SteamInventory.GetResultItems(FNMADDPJCLB, null, ref punOutItemsArraySize2) && punOutItemsArraySize2 > 1)
			{
				NKPKKPEFGMG = new SteamItemDetails_t[punOutItemsArraySize2];
				bool resultItems2 = SteamInventory.GetResultItems(FNMADDPJCLB, NKPKKPEFGMG, ref punOutItemsArraySize2);
				AJDGHDGDLOH();
				DCEFGAJKFIL();
			}
		}
		if (SteamInventory.GetResultStatus(FNMADDPJCLB) == EResult.k_EResultOK && (requestType == 3 || requestType == 4))
		{
			requestType = -1;
			UpdatePlayerInventory();
		}
	}

	public void ECINNLEOMIH(ulong MOANAJGGPLK)
	{
		requestType = 6;
		SteamInventoryResult_t pResultHandle;
		SteamInventory.ConsumeItem(out pResultHandle, (SteamItemInstanceID_t)MOANAJGGPLK, 1u);
	}

	private void DHAPJFJFEDI(SteamInventoryFullUpdate_t IAFAANLMOAG)
	{
		FNMADDPJCLB = IAFAANLMOAG.m_handle;
	}

	public void HMLPIPGHDBI(GameObject JPDEPDHKFFH, GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		Singleton<SaveSystem>.Instance.NHONGIGFHJB("_Intensity", Singleton<ItemsHandler>.Instance.userItems.Count);
		OIFFBIKCALF();
		for (int i = 0; i < MPNMOONBMII.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);
		}
		foreach (InventoryItemType CJEIKDHCCOI in GetAllTypes())
		{
			if (userItems.Find((SteamInventoryItem IACGDFHKCAE) => IACGDFHKCAE.item.type == CJEIKDHCCOI) == null)
			{
				continue;
			}
			GameObject gameObject = UnityEngine.Object.Instantiate(JPDEPDHKFFH, Vector3.zero, Quaternion.identity);
			gameObject.transform.SetParent(MPNMOONBMII.transform, true);
			gameObject.transform.localScale = new Vector3(47f, 358f, 14f);
			if ((bool)gameObject.transform.Find("_Value").Find("intensity"))
			{
				switch (CJEIKDHCCOI)
				{
				case InventoryItemType.Player:
					gameObject.transform.Find("_ScreenResolution").Find("_MainTex2").GetComponent<Text>()
						.text = LocalizationService.Instance.IAAEBJKAHDD("GameScene").ToUpper();
					break;
				case InventoryItemType.MenuTheme:
					gameObject.transform.Find("UnityEngine.MonoBehaviour").Find("_BlurParams").GetComponent<Text>()
						.text = LocalizationService.Instance.GetTextByKey("_Value").ToUpper();
					break;
				case InventoryItemType.Shader:
					gameObject.transform.Find("_ScreenResolution").Find("In Map Editor").GetComponent<Text>()
						.text = LocalizationService.Instance.IAAEBJKAHDD("y").ToUpper();
					break;
				default:
					gameObject.transform.Find("?").Find("tolobby").GetComponent<Text>()
						.text = LocalizationService.Instance.GetTextByKey(" - GameWebCallback] - ").ToUpper();
					break;
				}
			}
			GameObject gameObject2 = gameObject.transform.Find("float,0").Find("OxOD.lastPath").gameObject;
			for (int j = 1; j < gameObject2.transform.childCount; j += 0)
			{
				UnityEngine.Object.Destroy(gameObject2.transform.GetChild(j).gameObject);
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
			foreach (SteamInventoryItem item in dictionary.Values.OrderBy(JOFIMKHOPPH))
			{
				if (item.item.type == CJEIKDHCCOI)
				{
					GameObject gameObject3 = UnityEngine.Object.Instantiate(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
					gameObject3.transform.SetParent(gameObject2.transform, false);
					gameObject3.transform.localScale = new Vector3(1758f, 1460f, 1670f);
					UpdateInventoryItem(gameObject3, item, dictionary2[item.item.id]);
				}
			}
		}
	}

	public List<SteamInventoryItem> JAAIGMFHODM()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		foreach (SteamInventoryItem userItem in Singleton<ItemsHandler>.Instance.userItems)
		{
			if (!userItem.isLocal)
			{
				list.Add(userItem);
			}
		}
		return list;
	}

	private static InventoryItemRarity JOFIMKHOPPH(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	public void HFKDDFOCLAD()
	{
		StartCoroutine(IBGBCINGJHE());
	}

	public IEnumerator Init()
	{
		itemsData.Clear();
		isLoaded = false;
		yield return StartCoroutine(NGGKHGDAALF());
		UpdatePlayerInventory();
	}

	public void EFBFKJNGAIJ()
	{
		requestType = 0;
		SteamInventory.TriggerItemDrop(out FNMADDPJCLB, (SteamItemDef_t)0);
	}

	public ulong GNLDKKBJNGF(InventoryItemType HMGBJCGOLMI)
	{
		ulong result = 1uL;
		if (ulong.TryParse(Singleton<SaveSystem>.Instance.CFLCJCJHNKD("Delete events" + HMGBJCGOLMI.ToString().ToLower()), out result) && IsItemInInventory(result))
		{
			return result;
		}
		switch (HMGBJCGOLMI)
		{
		case InventoryItemType.Player:
			result = 1uL;
			break;
		case (InventoryItemType)6:
			result = 0uL;
			break;
		case InventoryItemType.Shader:
			result = 98uL;
			break;
		}
		JLEENFEIKHB(HMGBJCGOLMI, result);
		return result;
	}

	public void CDFFAHIGGHC(string NOJGGCLPPAM)
	{
		if ((bool)GameObject.Find("steamid"))
		{
			GameObject.Find("UI Extensions/SoftMaskShader").GetComponent<Text>().text = NOJGGCLPPAM.ToUpper();
		}
	}

	private static InventoryItemRarity OEEPHCOLBHL(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	public void OnEnable()
	{
		GLBMBBFDDOB = Callback<SteamInventoryResultReady_t>.Create(MMAGOONHNKM);
		EHFCDBNJDNA = Callback<SteamInventoryFullUpdate_t>.Create(PLBAKPAONCD);
		EAMLAGAIMAN = Callback<SteamInventoryDefinitionUpdate_t>.Create(KHNLPKIDBDE);
		FNMADDPJCLB = SteamInventoryResult_t.Invalid;
		NKPKKPEFGMG = null;
	}

	public void NPLAKLFJEOF()
	{
		StartCoroutine(IBGBCINGJHE());
	}

	public ulong MFPEMIAAILI(InventoryItemType HMGBJCGOLMI)
	{
		ulong result = 0uL;
		if (ulong.TryParse(Singleton<SaveSystem>.Instance.NBMEANCMGEH("#close" + HMGBJCGOLMI.ToString().ToLower()), out result) && IsItemInInventory(result))
		{
			return result;
		}
		switch (HMGBJCGOLMI)
		{
		default:
			if (HMGBJCGOLMI == InventoryItemType.Other)
			{
				result = 18446744073709551488uL;
			}
			break;
		case InventoryItemType.Other:
			result = 0uL;
			break;
		case InventoryItemType.Shader:
			result = 0uL;
			break;
		}
		JGJCJMPFOAC(HMGBJCGOLMI, result);
		return result;
	}

	public void TriggerItemDrop()
	{
		requestType = 1;
		SteamInventory.TriggerItemDrop(out FNMADDPJCLB, (SteamItemDef_t)0);
	}

	private void NCEFBKLKFEJ(SteamInventoryDefinitionUpdate_t IAFAANLMOAG)
	{
	}

	public SteamInventoryItem GetItemBySteamId(ulong MOANAJGGPLK)
	{
		return userItems.Find((SteamInventoryItem IACGDFHKCAE) => IACGDFHKCAE.steamid == MOANAJGGPLK);
	}

	[CompilerGenerated]
	private static InventoryItemRarity MGDONOIEKEK(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	private void OMCLOFCJMPG()
	{
	}

	public void Initializate()
	{
		StartCoroutine(Init());
	}

	private void FOPOKOFGDCB(SteamInventoryFullUpdate_t IAFAANLMOAG)
	{
		FNMADDPJCLB = IAFAANLMOAG.m_handle;
	}

	public List<SteamInventoryItem> PMIPHDOOIEB()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		foreach (SteamInventoryItem userItem in Singleton<ItemsHandler>.Instance.userItems)
		{
			if (!userItem.isLocal)
			{
				list.Add(userItem);
			}
		}
		return list;
	}

	public void NBMPNNMLLCF(string JMMILEFMACB)
	{
	}

	private IEnumerator GANBALCKOOK()
	{
		while (requestType != -1)
		{
			yield return new WaitForSeconds(0.1f);
		}
		requestType = 2;
		SteamInventoryResult_t pResultHandle;
		SteamInventory.GrantPromoItems(out pResultHandle);
	}

	public void ALEGFDJJKMM(GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		for (int i = 0; i < MPNMOONBMII.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);
		}
		foreach (SteamInventoryItem item in Singleton<ItemsHandler>.Instance.PMIPHDOOIEB().OrderBy(JEJKAHEBOLM))
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
			gameObject.transform.SetParent(MPNMOONBMII.transform, false);
			gameObject.transform.localScale = new Vector3(258f, 240f, 1127f);
			UpdateInventoryItem(gameObject, item);
		}
	}

	private void PLBAKPAONCD(SteamInventoryFullUpdate_t IAFAANLMOAG)
	{
		FNMADDPJCLB = IAFAANLMOAG.m_handle;
	}

	public void UpdateLoadingInfo(string NOJGGCLPPAM)
	{
		if ((bool)GameObject.Find("LoadingStatusText"))
		{
			GameObject.Find("LoadingStatusText").GetComponent<Text>().text = NOJGGCLPPAM.ToUpper();
		}
	}

	public List<string> EJFGHNNFIAF()
	{
		return IHIFDJEOGGK.Values.ToList();
	}

	public void AddSteamInventoryItemsToList(GameObject BEKHIEOMCPM, GameObject MPNMOONBMII)
	{
		for (int i = 0; i < MPNMOONBMII.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(MPNMOONBMII.transform.GetChild(i).gameObject);
		}
		foreach (SteamInventoryItem item in from EGMPIBBOEMH in Singleton<ItemsHandler>.Instance.GetOnlySteamItemsList()
			orderby EGMPIBBOEMH.item.rarity
			select EGMPIBBOEMH)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(BEKHIEOMCPM, Vector3.zero, Quaternion.identity);
			gameObject.transform.SetParent(MPNMOONBMII.transform, true);
			gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
			UpdateInventoryItem(gameObject, item);
		}
	}

	private void ACDKNINNMPJ(SteamInventoryDefinitionUpdate_t IAFAANLMOAG)
	{
	}

	public int MAHLIKCBOCI()
	{
		return userItems.Count - Singleton<SaveSystem>.Instance.ANECPPFPKAP("_TimeX", 0);
	}

	public InventoryItemData BLBIGKOEHGK(string JMMILEFMACB)
	{
		return itemsData.Find((InventoryItemData IACGDFHKCAE) => IACGDFHKCAE.id == JMMILEFMACB);
	}

	public string GetItemNameByID(int EEBCDMFNKLH)
	{
		return IHIFDJEOGGK.Where((KeyValuePair<int, string> IACGDFHKCAE) => IACGDFHKCAE.Key == EEBCDMFNKLH).First().Value;
	}

	private IEnumerator NGGKHGDAALF()
	{
		Debug.Log("[ItemsHandler] Found " + IHIFDJEOGGK.Count + " in-game items");
		foreach (KeyValuePair<int, string> item in IHIFDJEOGGK)
		{
			Debug.Log("[ItemsHandler] Loading " + item.Value);
			itemsData.Add(new InventoryItemData(item.Value));
		}
		Debug.Log("[ItemsHandler] All in-game items loaded");
		yield break;
	}

	public ulong EnquippedItem(InventoryItemType HMGBJCGOLMI)
	{
		ulong result = 0uL;
		if (ulong.TryParse(Singleton<SaveSystem>.Instance.GetString("inventory.selected." + HMGBJCGOLMI.ToString().ToLower()), out result) && IsItemInInventory(result))
		{
			return result;
		}
		switch (HMGBJCGOLMI)
		{
		case InventoryItemType.Player:
			result = 0uL;
			break;
		case InventoryItemType.MenuTheme:
			result = 1uL;
			break;
		case InventoryItemType.Shader:
			result = 17uL;
			break;
		}
		EnquipItem(HMGBJCGOLMI, result);
		return result;
	}

	private static InventoryItemRarity EMOMHOFIPEC(SteamInventoryItem EGMPIBBOEMH)
	{
		return EGMPIBBOEMH.item.rarity;
	}

	public void KNGPEINMNMB()
	{
		Singleton<SaveSystem>.Instance.CIDNCCOIEJJ();
		StartCoroutine(Singleton<UI>.Instance.NIIOJBIEPMG(newItemsCanvas, true, null, true, 1215f, false));
	}

	public List<SteamInventoryItem> IONIEFDFING()
	{
		List<SteamInventoryItem> list = new List<SteamInventoryItem>();
		foreach (SteamInventoryItem userItem in Singleton<ItemsHandler>.Instance.userItems)
		{
			if (!userItem.isLocal)
			{
				list.Add(userItem);
			}
		}
		return list;
	}

	private IEnumerator OHPLMOPKKHM(List<SteamInventoryItem> IOMNJBPDLAK)
	{
		yield return new WaitForSeconds(1f);
		GameObject gameObject = newItemsListContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		foreach (SteamInventoryItem item in IOMNJBPDLAK)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate(inventoryItemElement, Vector3.zero, Quaternion.identity);
			gameObject2.transform.SetParent(gameObject.transform, true);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			Singleton<InventorySelector>.Instance.UpdateInventoryItem(gameObject2, item);
		}
		yield return StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(newItemsCanvas, true));
	}
}
